//Generated by AntilatencyApiGenerator
#pragma warning disable IDE1006 // Do not warn about naming style violations
using Csml;
public sealed partial class Api : Scope {
	public sealed partial class Antilatency : Scope {
		public sealed partial class DeviceNetwork : Scope {
			public sealed partial class Tasks : Scope {
				public sealed partial class Tests : Scope {
					public sealed partial class Sync : Scope {
						public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"Sync").AddClasses("Namespace");
						public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
						public static IElement _FullNameRef => new Text($"{Antilatency.DeviceNetwork.Tasks.Tests._FullNameRef}.{_NameRef}");
						public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
						public static Material Material => new Material("Antilatency.DeviceNetwork.Tasks.Tests.Sync",null,$"Namespace in `{Api.Antilatency.DeviceNetwork.Tasks.Tests._FullNameRef}`")
							[new Section("Types")
								[new UnorderedList()
									[$"*constant group* {Constants.NameRefCode}"]
									[$"*interface* {IHostToDevice.NameRefCode}"]
									[$"*interface* {IDeviceToHost.NameRefCode}"]
								]
							]
							;
						public sealed partial class Constants : Scope {
							public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"Constants").AddClasses("Type");
							public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
							public static IElement _FullNameRef => new Text($"{Sync._FullNameRef}.{_NameRef}");
							public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
							public static Material Material => new Material("Antilatency.DeviceNetwork.Tasks.Tests.Sync.Constants",null,$"Constants in `{Api.Antilatency.DeviceNetwork.Tasks.Tests.Sync._FullNameRef}`")[CodeBlock];
							public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
							public static IElement RawDeclarationCode => new Text($"{Fields.TaskID.RawDeclarationCode}");
							public sealed partial class Fields : Scope {
								public sealed partial class TaskID : Scope {
									public static IElement _Name => new Modify($"TaskID").AddClasses("Constant").SetAttributeValue("title", "{{c5b34bb5-dd74-4dd8-8ce8-08ec0dc139aa}}");
									public static IElement NameCode => _Name.Modify().Wrap("code");
									public static System.Guid Value => new System.Guid("c5b34bb5-dd74-4dd8-8ce8-08ec0dc139aa");
									public static IElement RawDeclarationCode => new Text($"{Keyword("Guid")} {_Name} = {_Value}");
									public static IElement _Value => new Text($"{{c5b34bb5-dd74-4dd8-8ce8-08ec0dc139aa}}");
								} //scope TaskID
							} //scope Fields
						} //scope Constants
						
						public sealed partial class IHostToDevice : Scope {
							public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"IHostToDevice").AddClasses("Type");
							public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
							public static IElement _FullNameRef => new Text($"{Sync._FullNameRef}.{_NameRef}");
							public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
							public static IElement RawDeclarationCode => new Text($"{Interface} {_NameRef} : {Namespace("InterfaceContract")}.{Type("IInterface")} {{\n    {Methods.ack.RawDeclarationCode};\n}}");
							public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
							public static Material Material => new Material("Antilatency.DeviceNetwork.Tasks.Tests.Sync.IHostToDevice",null,$"Interface in `{Api.Antilatency.DeviceNetwork.Tasks.Tests.Sync._FullNameRef}`")[CodeBlock];
							public sealed partial class Methods : Scope {
								public sealed partial class ack : Scope {
									public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"ack").AddClasses("Method");
									public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
									public static IElement _FullNameRef => new Text($"{IHostToDevice._FullNameRef}.{_NameRef}");
									public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
									public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
									public static IElement CodeInline => CodeInline(RawDeclarationCode);
									public static IElement RawDeclarationCode => new Text($"{Keyword("void")} {_NameRef}()");
									public static Material Material => new Material("Antilatency.DeviceNetwork.Tasks.Tests.Sync.IHostToDevice.ack",null,$"Method of `{Api.Antilatency.DeviceNetwork.Tasks.Tests.Sync.IHostToDevice._NameRef}`\n`{RawDeclarationCode}`")
										[new Section("Parameters")]
										;
									public sealed partial class Parameters : Scope {
									} //scope Parameters
								} //scope ack
							} //scope Methods
						} //scope IHostToDevice
						
						public sealed partial class IDeviceToHost : Scope {
							public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"IDeviceToHost").AddClasses("Type");
							public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
							public static IElement _FullNameRef => new Text($"{Sync._FullNameRef}.{_NameRef}");
							public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
							public static IElement RawDeclarationCode => new Text($"{Interface} {_NameRef} : {Namespace("InterfaceContract")}.{Type("IInterface")} {{\n    {Methods.ack.RawDeclarationCode};\n}}");
							public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
							public static Material Material => new Material("Antilatency.DeviceNetwork.Tasks.Tests.Sync.IDeviceToHost",null,$"Interface in `{Api.Antilatency.DeviceNetwork.Tasks.Tests.Sync._FullNameRef}`")[CodeBlock];
							public sealed partial class Methods : Scope {
								public sealed partial class ack : Scope {
									public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"ack").AddClasses("Method");
									public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
									public static IElement _FullNameRef => new Text($"{IDeviceToHost._FullNameRef}.{_NameRef}");
									public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
									public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
									public static IElement CodeInline => CodeInline(RawDeclarationCode);
									public static IElement RawDeclarationCode => new Text($"{Keyword("void")} {_NameRef}()");
									public static Material Material => new Material("Antilatency.DeviceNetwork.Tasks.Tests.Sync.IDeviceToHost.ack",null,$"Method of `{Api.Antilatency.DeviceNetwork.Tasks.Tests.Sync.IDeviceToHost._NameRef}`\n`{RawDeclarationCode}`")
										[new Section("Parameters")]
										;
									public sealed partial class Parameters : Scope {
									} //scope Parameters
								} //scope ack
							} //scope Methods
						} //scope IDeviceToHost
						
						
					} //scope Sync
				} //scope Tests
			} //scope Tasks
		} //scope DeviceNetwork
	} //scope Antilatency
} //scope Api
