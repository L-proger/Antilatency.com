using Csml;

partial class Software : Scope {
    public static LanguageSelector<IMaterial> Antilatency_Hardware_Extension_Interface_Library => new LanguageSelector<IMaterial>();
    public partial class Antilatency_Hardware_Extension_Interface_Library_Assets : Scope {

        public static CSharpCode IInputPinCode => new CSharpCode(@"public interface IInputPin : Antilatency.InterfaceContract.IInterface {
    Interop.PinState getState();
}");
        public static CSharpCode IOutputPinCode => new CSharpCode(@"public interface IOutputPin : Antilatency.InterfaceContract.IInterface {
    void setState(Interop.PinState state);
    Interop.PinState getState();
}");
        public static CSharpCode IAnalogPinCode => new CSharpCode(@"public interface IAnalogPin : Antilatency.InterfaceContract.IInterface {
    float getValue();
}");
        public static CSharpCode IPulseCounterPinCode => new CSharpCode(@"public interface IPulseCounterPin : Antilatency.InterfaceContract.IInterface {
    UInt16 getValue();
}");
        public static CSharpCode IPwmPinCode => new CSharpCode(@"public interface IPwmPin : Antilatency.InterfaceContract.IInterface {
    void setDuty(float value);
    float getDuty();
    uint getFrequency();
}");
        public static CSharpCode ICotaskCode => new CSharpCode(@"public interface ICotask : Antilatency.DeviceNetwork.ICotask {
    IInputPin createInputPin(Interop.Pins pin);
    IOutputPin createOutputPin(Interop.Pins pin, Interop.PinState initialState);
    IAnalogPin createAnalogPin(Interop.Pins pin, uint refreshIntervalMs);
    IPulseCounterPin createPulseCounterPin(Interop.Pins pin, uint refreshIntervalMs);
    IPwmPin createPwmPin(Interop.Pins pin, uint frequency, float initialDuty);
    void run();
}");
    }
}