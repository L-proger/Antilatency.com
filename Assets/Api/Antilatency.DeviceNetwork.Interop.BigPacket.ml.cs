//Generated by AntilatencyApiGenerator
#pragma warning disable IDE1006 // Do not warn about naming style violations
using Csml;
public sealed partial class Api : Scope {
	public sealed partial class Antilatency : Scope {
		public sealed partial class DeviceNetwork : Scope {
			public sealed partial class Interop : Scope {
				public sealed partial class BigPacket : Scope {
					public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"BigPacket").AddClasses("Namespace");
					public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
					public static IElement _FullNameRef => new Text($"{Antilatency.DeviceNetwork.Interop._FullNameRef}.{_NameRef}");
					public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
					public static Material Material => new Material("Antilatency.DeviceNetwork.Interop.BigPacket",null,$"Namespace in `{Api.Antilatency.DeviceNetwork.Interop._FullNameRef}`")
						[new Section("Types")
							[new UnorderedList()
								[$"*struct* {FullBlock.NameRefCode}"]
								[$"*struct* {PartialBlock.NameRefCode}"]
							]
						]
						;
					public sealed partial class FullBlock : Scope {
						public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"FullBlock").AddClasses("Type");
						public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
						public static IElement _FullNameRef => new Text($"{BigPacket._FullNameRef}.{_NameRef}");
						public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
						public static Material Material => new Material("Antilatency.DeviceNetwork.Interop.BigPacket.FullBlock",null,$"Struct in {Api.Antilatency.DeviceNetwork.Interop.BigPacket.FullNameRefCode}")[CodeBlock];
						public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
						public static IElement RawDeclarationCode => new Text($"{Struct} {_NameRef} {{\n    {Fields.payload.RawDeclarationCode};\n}}");
						public sealed partial class Fields : Scope {
							public sealed partial class payload : Scope {
								public static IElement RawDeclarationCode => new Text($"{Api.Antilatency.DeviceNetwork.Interop.Memory._NameRef.Modify().ContentReplace($"Memory")}.{Api.Antilatency.DeviceNetwork.Interop.Memory.Memory63._NameRef} {Name}");
								public static IElement Name => new Modify($"payload").SetAttributeValue("title", "field payload");
							} //scope payload
						} //scope Fields
					} //scope FullBlock
					
					public sealed partial class PartialBlock : Scope {
						public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"PartialBlock").AddClasses("Type");
						public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
						public static IElement _FullNameRef => new Text($"{BigPacket._FullNameRef}.{_NameRef}");
						public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
						public static Material Material => new Material("Antilatency.DeviceNetwork.Interop.BigPacket.PartialBlock",null,$"Struct in {Api.Antilatency.DeviceNetwork.Interop.BigPacket.FullNameRefCode}")[CodeBlock];
						public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
						public static IElement RawDeclarationCode => new Text($"{Struct} {_NameRef} {{\n    {Fields.payloadSize.RawDeclarationCode};\n    {Fields.payload.RawDeclarationCode};\n}}");
						public sealed partial class Fields : Scope {
							public sealed partial class payloadSize : Scope {
								public static IElement RawDeclarationCode => new Text($"{Keyword("byte")} {Name}");
								public static IElement Name => new Modify($"payloadSize").SetAttributeValue("title", "field payloadSize");
							} //scope payloadSize
							public sealed partial class payload : Scope {
								public static IElement RawDeclarationCode => new Text($"{Api.Antilatency.DeviceNetwork.Interop.Memory._NameRef.Modify().ContentReplace($"Memory")}.{Api.Antilatency.DeviceNetwork.Interop.Memory.Memory63._NameRef} {Name}");
								public static IElement Name => new Modify($"payload").SetAttributeValue("title", "field payload");
							} //scope payload
						} //scope Fields
					} //scope PartialBlock
					
					
				} //scope BigPacket
			} //scope Interop
		} //scope DeviceNetwork
	} //scope Antilatency
} //scope Api
