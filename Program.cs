﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using Csml;

namespace Csml {



    static class Program {
        static void Main(string[] args) {
            #region CsmlEngineMain

            //Set dot decimal separator
            var customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = customCulture;

            ScopeUtils.EnableGetOnce();

            GitHub.RepositoryBranch.IgnorePinning = true;


            var context = new Context {
                SourceRootDirectory = Path.GetDirectoryName(Utils.ThisFilePath()),
                Watch = true
            };
            Cache.RootDirectory = Path.Combine(context.SourceRootDirectory, "cache");

            using (new Stopwatch("Verify")) {
                ScopeUtils.All.ForEach(x => x.Verify());
            }


            context.AssetsToCopy = Directory.GetFiles(context.SourceRootDirectory, "*.ttf", SearchOption.AllDirectories)
                .Concat(Directory.GetFiles(context.SourceRootDirectory, "*.woff", SearchOption.AllDirectories))
                .Concat(Directory.GetFiles(context.SourceRootDirectory, "*.woff2", SearchOption.AllDirectories))
                .Concat(Directory.GetFiles(context.SourceRootDirectory, "*.svg", SearchOption.AllDirectories))
                .ToHashSet();

            /*.ForEach(x => context.AssetsToCopy.Add(x));
            .ForEach(x => context.AssetsToCopy.Add(x));
            Directory.GetFiles(context.SourceRootDirectory, "*.svg", SearchOption.AllDirectories).ForEach(x => context.AssetsToCopy.Add(x));*/


            if (args.Length == 1) {
                

                context.OutputRootDirectory = args[0];

                context.BaseUri = new Uri(context.OutputRootDirectory + "/");
                context.CleanOutputRootDirectory();
                context.CopyAssets();

                SassProcessor sassProcessor = new SassProcessor(
                    context.SourceRootDirectory,
                    context.OutputRootDirectory,
                    "Assets/style.scss");
                JavascriptProcessor javascriptProcessor = new JavascriptProcessor(
                    context.SourceRootDirectory,
                    context.OutputRootDirectory);


                ScopeUtils.All.ForEach(x => {
                    //Log.Info.Here($"Generation Scope {x.GetType().Name}");
                    x.Generate(context);
                    
                    });

                Console.WriteLine("All files generated!");
                Console.WriteLine();

                if (context.Watch) {
                    Console.WriteLine("Watching for file changes. Press any key to exit.");
                    bool reloadRequired = true;

                    string ScssError = null;
                    while (Console.KeyAvailable == false) {
                        if (reloadRequired) {
                            F5.Send();
                            reloadRequired = false;
                        }
                        if (sassProcessor.Error != ScssError) {
                            ScssError = sassProcessor.Error;
                            Console.Clear();
                            if (ScssError != null) {
                                Console.WriteLine("Scss:" + ScssError);
                            }
                        }
                        Thread.Sleep(250);
                        reloadRequired |= sassProcessor.UpdateIfChanged();
                        reloadRequired |= javascriptProcessor.UpdateIfChanged();
                    }

                }
            }
            #endregion
        }
    }
}
