//Generated by AntilatencyApiGenerator
#pragma warning disable IDE1006 // Do not warn about naming style violations
using Csml;
public sealed partial class Api : Scope {
	public sealed partial class Antilatency : Scope {
		public sealed partial class HardwareExtensionInterface : Scope {
			public sealed partial class Interop : Scope {
				public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"Interop").AddClasses("Namespace");
				public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
				public static IElement _FullNameRef => new Text($"{Antilatency.HardwareExtensionInterface._FullNameRef}.{_NameRef}");
				public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
				public static Material Material => new Material("Antilatency.HardwareExtensionInterface.Interop",null,$"Namespace in `{Api.Antilatency.HardwareExtensionInterface._FullNameRef}`")
					[new Section("Types")
						[new UnorderedList()
							[$"*enum* {PinState.NameRefCode}"]
							[$"*enum* {Pins.NameRefCode}"]
							[$"*constant group* {Constants.NameRefCode}"]
						]
					]
					;
				public sealed partial class PinState : Scope {
					public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"PinState").AddClasses("Type");
					public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
					public static IElement _FullNameRef => new Text($"{Interop._FullNameRef}.{_NameRef}");
					public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
					public static Material Material => new Material("Antilatency.HardwareExtensionInterface.Interop.PinState",null,$"Enum in {Api.Antilatency.HardwareExtensionInterface.Interop.FullNameRefCode}")[CodeBlock];
					public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
					public static IElement RawDeclarationCode => new Text($"{Enum} {_NameRef} {{\n    {Fields.Low.RawDeclarationCode},\n    {Fields.High.RawDeclarationCode}\n}}");
					public sealed partial class Fields : Scope {
						public sealed partial class Low : Scope {
							public static IElement RawDeclarationCode => new Text($"{Name}");
							public static IElement Name => new Modify($"Low").SetAttributeValue("title", "enum element Low");
						} //scope Low
						public sealed partial class High : Scope {
							public static IElement RawDeclarationCode => new Text($"{Name}");
							public static IElement Name => new Modify($"High").SetAttributeValue("title", "enum element High");
						} //scope High
					} //scope Fields
				} //scope PinState
				
				public sealed partial class Pins : Scope {
					public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"Pins").AddClasses("Type");
					public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
					public static IElement _FullNameRef => new Text($"{Interop._FullNameRef}.{_NameRef}");
					public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
					public static Material Material => new Material("Antilatency.HardwareExtensionInterface.Interop.Pins",null,$"Enum in {Api.Antilatency.HardwareExtensionInterface.Interop.FullNameRefCode}")[CodeBlock];
					public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
					public static IElement RawDeclarationCode => new Text($"{Enum} {_NameRef} {{\n    {Fields.IO1.RawDeclarationCode},\n    {Fields.IO2.RawDeclarationCode},\n    {Fields.IOA3.RawDeclarationCode},\n    {Fields.IOA4.RawDeclarationCode},\n    {Fields.IO5.RawDeclarationCode},\n    {Fields.IO6.RawDeclarationCode},\n    {Fields.IO7.RawDeclarationCode},\n    {Fields.IO8.RawDeclarationCode}\n}}");
					public sealed partial class Fields : Scope {
						public sealed partial class IO1 : Scope {
							public static IElement RawDeclarationCode => new Text($"{Name}");
							public static IElement Name => new Modify($"IO1").SetAttributeValue("title", "enum element IO1");
						} //scope IO1
						public sealed partial class IO2 : Scope {
							public static IElement RawDeclarationCode => new Text($"{Name}");
							public static IElement Name => new Modify($"IO2").SetAttributeValue("title", "enum element IO2");
						} //scope IO2
						public sealed partial class IOA3 : Scope {
							public static IElement RawDeclarationCode => new Text($"{Name}");
							public static IElement Name => new Modify($"IOA3").SetAttributeValue("title", "enum element IOA3");
						} //scope IOA3
						public sealed partial class IOA4 : Scope {
							public static IElement RawDeclarationCode => new Text($"{Name}");
							public static IElement Name => new Modify($"IOA4").SetAttributeValue("title", "enum element IOA4");
						} //scope IOA4
						public sealed partial class IO5 : Scope {
							public static IElement RawDeclarationCode => new Text($"{Name}");
							public static IElement Name => new Modify($"IO5").SetAttributeValue("title", "enum element IO5");
						} //scope IO5
						public sealed partial class IO6 : Scope {
							public static IElement RawDeclarationCode => new Text($"{Name}");
							public static IElement Name => new Modify($"IO6").SetAttributeValue("title", "enum element IO6");
						} //scope IO6
						public sealed partial class IO7 : Scope {
							public static IElement RawDeclarationCode => new Text($"{Name}");
							public static IElement Name => new Modify($"IO7").SetAttributeValue("title", "enum element IO7");
						} //scope IO7
						public sealed partial class IO8 : Scope {
							public static IElement RawDeclarationCode => new Text($"{Name}");
							public static IElement Name => new Modify($"IO8").SetAttributeValue("title", "enum element IO8");
						} //scope IO8
					} //scope Fields
				} //scope Pins
				
				public sealed partial class Constants : Scope {
					public static IElement _NameRef => new Deferred(()=>Material).Modify().ContentReplace($"Constants").AddClasses("Type");
					public static IElement NameRefCode => _NameRef.Modify().Wrap("code");
					public static IElement _FullNameRef => new Text($"{Interop._FullNameRef}.{_NameRef}");
					public static IElement FullNameRefCode => _FullNameRef.Modify().Wrap("code");
					public static Material Material => new Material("Antilatency.HardwareExtensionInterface.Interop.Constants",null,$"Constants in `{Api.Antilatency.HardwareExtensionInterface.Interop._FullNameRef}`")[CodeBlock];
					public static IElement CodeBlock => CodeBlock(RawDeclarationCode);
					public static IElement RawDeclarationCode => new Text($"{Fields.MaxInputPinsCount.RawDeclarationCode}\n{Fields.MaxOutputPinsCount.RawDeclarationCode}\n{Fields.MaxAnalogPinsCount.RawDeclarationCode}\n{Fields.MaxPulseCounterPinsCount.RawDeclarationCode}\n{Fields.MaxPwmPinsCount.RawDeclarationCode}");
					public sealed partial class Fields : Scope {
						public sealed partial class MaxInputPinsCount : Scope {
							public static IElement _Name => new Modify($"MaxInputPinsCount").AddClasses("Constant").SetAttributeValue("title", "8");
							public static IElement NameCode => _Name.Modify().Wrap("code");
							public static System.UInt32 Value => 8;
							public static IElement RawDeclarationCode => new Text($"{Keyword("uint")} {_Name} = {_Value}");
							public static IElement _Value => new Text($"8");
						} //scope MaxInputPinsCount
						public sealed partial class MaxOutputPinsCount : Scope {
							public static IElement _Name => new Modify($"MaxOutputPinsCount").AddClasses("Constant").SetAttributeValue("title", "8");
							public static IElement NameCode => _Name.Modify().Wrap("code");
							public static System.UInt32 Value => 8;
							public static IElement RawDeclarationCode => new Text($"{Keyword("uint")} {_Name} = {_Value}");
							public static IElement _Value => new Text($"8");
						} //scope MaxOutputPinsCount
						public sealed partial class MaxAnalogPinsCount : Scope {
							public static IElement _Name => new Modify($"MaxAnalogPinsCount").AddClasses("Constant").SetAttributeValue("title", "2");
							public static IElement NameCode => _Name.Modify().Wrap("code");
							public static System.UInt32 Value => 2;
							public static IElement RawDeclarationCode => new Text($"{Keyword("uint")} {_Name} = {_Value}");
							public static IElement _Value => new Text($"2");
						} //scope MaxAnalogPinsCount
						public sealed partial class MaxPulseCounterPinsCount : Scope {
							public static IElement _Name => new Modify($"MaxPulseCounterPinsCount").AddClasses("Constant").SetAttributeValue("title", "2");
							public static IElement NameCode => _Name.Modify().Wrap("code");
							public static System.UInt32 Value => 2;
							public static IElement RawDeclarationCode => new Text($"{Keyword("uint")} {_Name} = {_Value}");
							public static IElement _Value => new Text($"2");
						} //scope MaxPulseCounterPinsCount
						public sealed partial class MaxPwmPinsCount : Scope {
							public static IElement _Name => new Modify($"MaxPwmPinsCount").AddClasses("Constant").SetAttributeValue("title", "4");
							public static IElement NameCode => _Name.Modify().Wrap("code");
							public static System.UInt32 Value => 4;
							public static IElement RawDeclarationCode => new Text($"{Keyword("uint")} {_Name} = {_Value}");
							public static IElement _Value => new Text($"4");
						} //scope MaxPwmPinsCount
					} //scope Fields
				} //scope Constants
				
				
			} //scope Interop
		} //scope HardwareExtensionInterface
	} //scope Antilatency
} //scope Api