//Generated by AntilatencyApiGenerator
#pragma warning disable IDE1006 // Do not warn about naming style violations
using Csml;
public sealed partial class Api : Scope {
	public sealed partial class Antilatency : Scope {
		public sealed partial class DeviceNetwork : Scope {
			public sealed partial class Tasks : Scope {
				public sealed partial class Tests : Scope {
					public sealed partial class BytesFlow : Scope {
						public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"BytesFlow").AddClasses("Namespace");
						public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
						public static IElement _FullNameRef => new Text($"{Antilatency.DeviceNetwork.Tasks.Tests._FullNameRef}.{_NameRef}");
						public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
						public static Material Material => new Material("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow",null,$"Namespace in `{Api.Antilatency.DeviceNetwork.Tasks.Tests._FullNameRef}`")
							[new Section("Types")
								[new UnorderedList()
									[$"*struct* {Settings.NameRefCode}"]
									[$"*constant group* {Constants.NameRefCode}"]
									[$"*interface* {IHostToDevice.NameRefCode}"]
									[$"*interface* {IDeviceToHost.NameRefCode}"]
								]
							]
							;
						public sealed partial class Settings : Scope {
							public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"Settings").AddClasses("Type");
							public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
							public static IElement _FullNameRef => new Text($"{BytesFlow._FullNameRef}.{_NameRef}");
							public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
							public static Material Material => new Material("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.Settings",null,$"Struct in {Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.FullNameRefCode}")[CodeBlock];
							public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
							public static IElement RawDeclarationCode => new Text($"{Struct} {_NameRef} {{\n    {Fields.blocksCount.RawDeclarationCode};\n    {Fields.packetSize.RawDeclarationCode};\n}}");
							public sealed partial class Fields : Scope {
								public sealed partial class blocksCount : Scope {
									public static IElement RawDeclarationCode => new Text($"{Keyword("uint")} {Name}");
									public static IElement Name => new Modify($"blocksCount").SetAttributeValue("title", "field blocksCount");
								} //scope blocksCount
								public sealed partial class packetSize : Scope {
									public static IElement RawDeclarationCode => new Text($"{Keyword("uint")} {Name}");
									public static IElement Name => new Modify($"packetSize").SetAttributeValue("title", "field packetSize");
								} //scope packetSize
							} //scope Fields
						} //scope Settings
						
						public sealed partial class Constants : Scope {
							public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"Constants").AddClasses("Type");
							public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
							public static IElement _FullNameRef => new Text($"{BytesFlow._FullNameRef}.{_NameRef}");
							public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
							public static Material Material => new Material("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.Constants",null,$"Constants in `{Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow._FullNameRef}`")[CodeBlock];
							public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
							public static IElement RawDeclarationCode => new Text($"{Fields.TaskID.RawDeclarationCode}");
							public sealed partial class Fields : Scope {
								public sealed partial class TaskID : Scope {
									public static IElement _Name => new Modify($"TaskID").AddClasses("Constant").SetAttributeValue("title", "{{5f5a1475-f8d5-4db2-9e37-1a05c260b17a}}");
									public static IElement NameCode => _Name.Modify().Wrap("code");
									public static System.Guid Value => new System.Guid("5f5a1475-f8d5-4db2-9e37-1a05c260b17a");
									public static IElement RawDeclarationCode => new Text($"{Keyword("Guid")} {_Name} = {_Value}");
									public static IElement _Value => new Text($"{{5f5a1475-f8d5-4db2-9e37-1a05c260b17a}}");
								} //scope TaskID
							} //scope Fields
						} //scope Constants
						
						public sealed partial class IHostToDevice : Scope {
							public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"IHostToDevice").AddClasses("Type");
							public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
							public static IElement _FullNameRef => new Text($"{BytesFlow._FullNameRef}.{_NameRef}");
							public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
							public static IElement RawDeclarationCode => new Text($"{Interface} {_NameRef} : {Namespace("InterfaceContract")}.{Type("IInterface")} {{\n    {Methods.settings.RawDeclarationCode};\n}}");
							public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
							public static Material Material => new Material("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IHostToDevice",null,$"Interface in `{Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow._FullNameRef}`")[CodeBlock];
							public sealed partial class Methods : Scope {
								public sealed partial class settings : Scope {
									public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"settings").AddClasses("Method");
									public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
									public static IElement _FullNameRef => new Text($"{IHostToDevice._FullNameRef}.{_NameRef}");
									public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
									public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
									public static IElement CodeInline => CodeInline(RawDeclarationCode);
									public static IElement RawDeclarationCode => new Text($"{Keyword("void")} {_NameRef}({Parameters.value.RawDeclarationCode})");
									public static Material Material => new Material("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IHostToDevice.settings",null,$"Method of `{Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IHostToDevice._NameRef}`\n`{RawDeclarationCode}`")
										[new Section("Parameters")]
										;
									public sealed partial class Parameters : Scope {
										public sealed partial class value : Scope {
											public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
											public static IElement CodeInline => CodeInline(RawDeclarationCode);
											public static IElement RawDeclarationCode => new Text($"{Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.Settings._NameRef} {_Name}");
											public static IElement _Name => new Modify($"value").SetAttributeValue("title", "parameter value");
											public static IElement NameCode => _Name.Modify().Wrap("code");
										} //scope value
									} //scope Parameters
								} //scope settings
							} //scope Methods
						} //scope IHostToDevice
						
						public sealed partial class IDeviceToHost : Scope {
							public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"IDeviceToHost").AddClasses("Type");
							public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
							public static IElement _FullNameRef => new Text($"{BytesFlow._FullNameRef}.{_NameRef}");
							public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
							public static IElement RawDeclarationCode => new Text($"{Interface} {_NameRef} : {Namespace("InterfaceContract")}.{Type("IInterface")} {{\n    {Methods.byte1.RawDeclarationCode};\n    {Methods.byte2.RawDeclarationCode};\n    {Methods.byte4.RawDeclarationCode};\n    {Methods.byte8.RawDeclarationCode};\n    {Methods.byte16.RawDeclarationCode};\n    {Methods.byte32.RawDeclarationCode};\n    {Methods.byte64.RawDeclarationCode};\n    {Methods.byte128.RawDeclarationCode};\n    {Methods.byte255.RawDeclarationCode};\n}}");
							public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
							public static Material Material => new Material("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost",null,$"Interface in `{Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow._FullNameRef}`")[CodeBlock];
							public sealed partial class Methods : Scope {
								public sealed partial class byte1 : Scope {
									public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"byte1").AddClasses("Method");
									public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
									public static IElement _FullNameRef => new Text($"{IDeviceToHost._FullNameRef}.{_NameRef}");
									public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
									public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
									public static IElement CodeInline => CodeInline(RawDeclarationCode);
									public static IElement RawDeclarationCode => new Text($"{Keyword("void")} {_NameRef}({Parameters.value.RawDeclarationCode})");
									public static Material Material => new Material("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.byte1",null,$"Method of `{Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost._NameRef}`\n`{RawDeclarationCode}`")
										[new Section("Parameters")]
										;
									public sealed partial class Parameters : Scope {
										public sealed partial class value : Scope {
											public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
											public static IElement CodeInline => CodeInline(RawDeclarationCode);
											public static IElement RawDeclarationCode => new Text($"{Keyword("byte")} {_Name}");
											public static IElement _Name => new Modify($"value").SetAttributeValue("title", "parameter value");
											public static IElement NameCode => _Name.Modify().Wrap("code");
										} //scope value
									} //scope Parameters
								} //scope byte1
								public sealed partial class byte2 : Scope {
									public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"byte2").AddClasses("Method");
									public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
									public static IElement _FullNameRef => new Text($"{IDeviceToHost._FullNameRef}.{_NameRef}");
									public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
									public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
									public static IElement CodeInline => CodeInline(RawDeclarationCode);
									public static IElement RawDeclarationCode => new Text($"{Keyword("void")} {_NameRef}({Parameters.value.RawDeclarationCode})");
									public static Material Material => new Material("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.byte2",null,$"Method of `{Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost._NameRef}`\n`{RawDeclarationCode}`")
										[new Section("Parameters")]
										;
									public sealed partial class Parameters : Scope {
										public sealed partial class value : Scope {
											public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
											public static IElement CodeInline => CodeInline(RawDeclarationCode);
											public static IElement RawDeclarationCode => new Text($"{Api.Antilatency.DeviceNetwork.Interop.Memory._NameRef.Modify().ContentReplace($"Interop.Memory")}.{Api.Antilatency.DeviceNetwork.Interop.Memory.Memory2._NameRef} {_Name}");
											public static IElement _Name => new Modify($"value").SetAttributeValue("title", "parameter value");
											public static IElement NameCode => _Name.Modify().Wrap("code");
										} //scope value
									} //scope Parameters
								} //scope byte2
								public sealed partial class byte4 : Scope {
									public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"byte4").AddClasses("Method");
									public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
									public static IElement _FullNameRef => new Text($"{IDeviceToHost._FullNameRef}.{_NameRef}");
									public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
									public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
									public static IElement CodeInline => CodeInline(RawDeclarationCode);
									public static IElement RawDeclarationCode => new Text($"{Keyword("void")} {_NameRef}({Parameters.value.RawDeclarationCode})");
									public static Material Material => new Material("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.byte4",null,$"Method of `{Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost._NameRef}`\n`{RawDeclarationCode}`")
										[new Section("Parameters")]
										;
									public sealed partial class Parameters : Scope {
										public sealed partial class value : Scope {
											public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
											public static IElement CodeInline => CodeInline(RawDeclarationCode);
											public static IElement RawDeclarationCode => new Text($"{Api.Antilatency.DeviceNetwork.Interop.Memory._NameRef.Modify().ContentReplace($"Interop.Memory")}.{Api.Antilatency.DeviceNetwork.Interop.Memory.Memory4._NameRef} {_Name}");
											public static IElement _Name => new Modify($"value").SetAttributeValue("title", "parameter value");
											public static IElement NameCode => _Name.Modify().Wrap("code");
										} //scope value
									} //scope Parameters
								} //scope byte4
								public sealed partial class byte8 : Scope {
									public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"byte8").AddClasses("Method");
									public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
									public static IElement _FullNameRef => new Text($"{IDeviceToHost._FullNameRef}.{_NameRef}");
									public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
									public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
									public static IElement CodeInline => CodeInline(RawDeclarationCode);
									public static IElement RawDeclarationCode => new Text($"{Keyword("void")} {_NameRef}({Parameters.value.RawDeclarationCode})");
									public static Material Material => new Material("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.byte8",null,$"Method of `{Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost._NameRef}`\n`{RawDeclarationCode}`")
										[new Section("Parameters")]
										;
									public sealed partial class Parameters : Scope {
										public sealed partial class value : Scope {
											public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
											public static IElement CodeInline => CodeInline(RawDeclarationCode);
											public static IElement RawDeclarationCode => new Text($"{Api.Antilatency.DeviceNetwork.Interop.Memory._NameRef.Modify().ContentReplace($"Interop.Memory")}.{Api.Antilatency.DeviceNetwork.Interop.Memory.Memory8._NameRef} {_Name}");
											public static IElement _Name => new Modify($"value").SetAttributeValue("title", "parameter value");
											public static IElement NameCode => _Name.Modify().Wrap("code");
										} //scope value
									} //scope Parameters
								} //scope byte8
								public sealed partial class byte16 : Scope {
									public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"byte16").AddClasses("Method");
									public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
									public static IElement _FullNameRef => new Text($"{IDeviceToHost._FullNameRef}.{_NameRef}");
									public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
									public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
									public static IElement CodeInline => CodeInline(RawDeclarationCode);
									public static IElement RawDeclarationCode => new Text($"{Keyword("void")} {_NameRef}({Parameters.value.RawDeclarationCode})");
									public static Material Material => new Material("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.byte16",null,$"Method of `{Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost._NameRef}`\n`{RawDeclarationCode}`")
										[new Section("Parameters")]
										;
									public sealed partial class Parameters : Scope {
										public sealed partial class value : Scope {
											public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
											public static IElement CodeInline => CodeInline(RawDeclarationCode);
											public static IElement RawDeclarationCode => new Text($"{Api.Antilatency.DeviceNetwork.Interop.Memory._NameRef.Modify().ContentReplace($"Interop.Memory")}.{Api.Antilatency.DeviceNetwork.Interop.Memory.Memory16._NameRef} {_Name}");
											public static IElement _Name => new Modify($"value").SetAttributeValue("title", "parameter value");
											public static IElement NameCode => _Name.Modify().Wrap("code");
										} //scope value
									} //scope Parameters
								} //scope byte16
								public sealed partial class byte32 : Scope {
									public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"byte32").AddClasses("Method");
									public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
									public static IElement _FullNameRef => new Text($"{IDeviceToHost._FullNameRef}.{_NameRef}");
									public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
									public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
									public static IElement CodeInline => CodeInline(RawDeclarationCode);
									public static IElement RawDeclarationCode => new Text($"{Keyword("void")} {_NameRef}({Parameters.value.RawDeclarationCode})");
									public static Material Material => new Material("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.byte32",null,$"Method of `{Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost._NameRef}`\n`{RawDeclarationCode}`")
										[new Section("Parameters")]
										;
									public sealed partial class Parameters : Scope {
										public sealed partial class value : Scope {
											public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
											public static IElement CodeInline => CodeInline(RawDeclarationCode);
											public static IElement RawDeclarationCode => new Text($"{Api.Antilatency.DeviceNetwork.Interop.Memory._NameRef.Modify().ContentReplace($"Interop.Memory")}.{Api.Antilatency.DeviceNetwork.Interop.Memory.Memory32._NameRef} {_Name}");
											public static IElement _Name => new Modify($"value").SetAttributeValue("title", "parameter value");
											public static IElement NameCode => _Name.Modify().Wrap("code");
										} //scope value
									} //scope Parameters
								} //scope byte32
								public sealed partial class byte64 : Scope {
									public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"byte64").AddClasses("Method");
									public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
									public static IElement _FullNameRef => new Text($"{IDeviceToHost._FullNameRef}.{_NameRef}");
									public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
									public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
									public static IElement CodeInline => CodeInline(RawDeclarationCode);
									public static IElement RawDeclarationCode => new Text($"{Keyword("void")} {_NameRef}({Parameters.value.RawDeclarationCode})");
									public static Material Material => new Material("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.byte64",null,$"Method of `{Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost._NameRef}`\n`{RawDeclarationCode}`")
										[new Section("Parameters")]
										;
									public sealed partial class Parameters : Scope {
										public sealed partial class value : Scope {
											public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
											public static IElement CodeInline => CodeInline(RawDeclarationCode);
											public static IElement RawDeclarationCode => new Text($"{Api.Antilatency.DeviceNetwork.Interop.Memory._NameRef.Modify().ContentReplace($"Interop.Memory")}.{Api.Antilatency.DeviceNetwork.Interop.Memory.Memory64._NameRef} {_Name}");
											public static IElement _Name => new Modify($"value").SetAttributeValue("title", "parameter value");
											public static IElement NameCode => _Name.Modify().Wrap("code");
										} //scope value
									} //scope Parameters
								} //scope byte64
								public sealed partial class byte128 : Scope {
									public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"byte128").AddClasses("Method");
									public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
									public static IElement _FullNameRef => new Text($"{IDeviceToHost._FullNameRef}.{_NameRef}");
									public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
									public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
									public static IElement CodeInline => CodeInline(RawDeclarationCode);
									public static IElement RawDeclarationCode => new Text($"{Keyword("void")} {_NameRef}({Parameters.value.RawDeclarationCode})");
									public static Material Material => new Material("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.byte128",null,$"Method of `{Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost._NameRef}`\n`{RawDeclarationCode}`")
										[new Section("Parameters")]
										;
									public sealed partial class Parameters : Scope {
										public sealed partial class value : Scope {
											public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
											public static IElement CodeInline => CodeInline(RawDeclarationCode);
											public static IElement RawDeclarationCode => new Text($"{Api.Antilatency.DeviceNetwork.Interop.Memory._NameRef.Modify().ContentReplace($"Interop.Memory")}.{Api.Antilatency.DeviceNetwork.Interop.Memory.Memory128._NameRef} {_Name}");
											public static IElement _Name => new Modify($"value").SetAttributeValue("title", "parameter value");
											public static IElement NameCode => _Name.Modify().Wrap("code");
										} //scope value
									} //scope Parameters
								} //scope byte128
								public sealed partial class byte255 : Scope {
									public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"byte255").AddClasses("Method");
									public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
									public static IElement _FullNameRef => new Text($"{IDeviceToHost._FullNameRef}.{_NameRef}");
									public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
									public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
									public static IElement CodeInline => CodeInline(RawDeclarationCode);
									public static IElement RawDeclarationCode => new Text($"{Keyword("void")} {_NameRef}({Parameters.value.RawDeclarationCode})");
									public static Material Material => new Material("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.byte255",null,$"Method of `{Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost._NameRef}`\n`{RawDeclarationCode}`")
										[new Section("Parameters")]
										;
									public sealed partial class Parameters : Scope {
										public sealed partial class value : Scope {
											public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
											public static IElement CodeInline => CodeInline(RawDeclarationCode);
											public static IElement RawDeclarationCode => new Text($"{Api.Antilatency.DeviceNetwork.Interop.Memory._NameRef.Modify().ContentReplace($"Interop.Memory")}.{Api.Antilatency.DeviceNetwork.Interop.Memory.Memory255._NameRef} {_Name}");
											public static IElement _Name => new Modify($"value").SetAttributeValue("title", "parameter value");
											public static IElement NameCode => _Name.Modify().Wrap("code");
										} //scope value
									} //scope Parameters
								} //scope byte255
							} //scope Methods
						} //scope IDeviceToHost
						
						
					} //scope BytesFlow
				} //scope Tests
			} //scope Tasks
		} //scope DeviceNetwork
	} //scope Antilatency
} //scope Api
