using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
namespace SDK.Script.StreamlineBlueprintSDK
{
    public class StreamlineLibraryDLSSG : BlueprintFunctionLibrary
    {
        public StreamlineLibraryDLSSG(nint addr) : base(addr) { }
        public void SetDLSSGMode(UStreamlineDLSSGMode DLSSGMode) { Invoke(nameof(SetDLSSGMode), DLSSGMode); }
        public UStreamlineDLSSGSupport QueryDLSSGSupport() { return Invoke<UStreamlineDLSSGSupport>(nameof(QueryDLSSGSupport)); }
        public bool IsDLSSGSupported() { return Invoke<bool>(nameof(IsDLSSGSupported)); }
        public bool IsDLSSGModeSupported(UStreamlineDLSSGMode DLSSGMode) { return Invoke<bool>(nameof(IsDLSSGModeSupported), DLSSGMode); }
        public Array<UStreamlineDLSSGMode> GetSupportedDLSSGModes() { return Invoke<Array<UStreamlineDLSSGMode>>(nameof(GetSupportedDLSSGModes)); }
        public UStreamlineDLSSGMode GetDLSSGMode() { return Invoke<UStreamlineDLSSGMode>(nameof(GetDLSSGMode)); }
        public void GetDLSSGMinimumDriverVersion(int MinDriverVersionMajor, int MinDriverVersionMinor) { Invoke(nameof(GetDLSSGMinimumDriverVersion), MinDriverVersionMajor, MinDriverVersionMinor); }
        public void GetDLSSGFrameTiming(float FrameRateInHertz, int FramesPresented) { Invoke(nameof(GetDLSSGFrameTiming), FrameRateInHertz, FramesPresented); }
        public UStreamlineDLSSGMode GetDefaultDLSSGMode() { return Invoke<UStreamlineDLSSGMode>(nameof(GetDefaultDLSSGMode)); }
    }
    public class StreamlineLibraryReflex : BlueprintFunctionLibrary
    {
        public StreamlineLibraryReflex(nint addr) : base(addr) { }
        public void SetReflexMode(UStreamlineReflexMode Mode) { Invoke(nameof(SetReflexMode), Mode); }
        public UStreamlineReflexSupport QueryReflexSupport() { return Invoke<UStreamlineReflexSupport>(nameof(QueryReflexSupport)); }
        public bool IsReflexSupported() { return Invoke<bool>(nameof(IsReflexSupported)); }
        public float GetRenderLatencyInMs() { return Invoke<float>(nameof(GetRenderLatencyInMs)); }
        public UStreamlineReflexMode GetReflexMode() { return Invoke<UStreamlineReflexMode>(nameof(GetReflexMode)); }
        public float GetGameToRenderLatencyInMs() { return Invoke<float>(nameof(GetGameToRenderLatencyInMs)); }
        public float GetGameLatencyInMs() { return Invoke<float>(nameof(GetGameLatencyInMs)); }
        public UStreamlineReflexMode GetDefaultReflexMode() { return Invoke<UStreamlineReflexMode>(nameof(GetDefaultReflexMode)); }
    }
    public enum UStreamlineDLSSGSupport : int
    {
        Supported = 0,
        NotSupported = 1,
        NotSupportedIncompatibleHardware = 2,
        NotSupportedDriverOutOfDate = 3,
        NotSupportedOperatingSystemOutOfDate = 4,
        NotSupportedByPlatformAtBuildTime = 5,
        NotSupportedIncompatibleAPICaptureToolActive = 6,
        UStreamlineDLSSGSupport_MAX = 7,
    }
    public enum UStreamlineDLSSGMode : int
    {
        Off = 0,
        On = 1,
        UStreamlineDLSSGMode_MAX = 2,
    }
    public enum UStreamlineReflexMode : int
    {
        Disabled = 0,
        Enabled = 1,
        EnabledPlusBoost = 3,
        UStreamlineReflexMode_MAX = 4,
    }
    public enum UStreamlineReflexSupport : int
    {
        Supported = 0,
        NotSupported = 1,
        UStreamlineReflexSupport_MAX = 2,
    }
}
