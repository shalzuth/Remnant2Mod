using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.XeSSBlueprintSDK
{
    public class XeSSBlueprintLibrary : BlueprintFunctionLibrary
    {
        public XeSSBlueprintLibrary(nint addr) : base(addr) { }
        public void SetXeSSQualityMode(EXeSSQualityMode QualityMode) { Invoke(nameof(SetXeSSQualityMode), QualityMode); }
        public bool IsXeSSSupported() { return Invoke<bool>(nameof(IsXeSSSupported)); }
        public bool GetXeSSQualityModeInformation(EXeSSQualityMode QualityMode, float ScreenPercentage) { return Invoke<bool>(nameof(GetXeSSQualityModeInformation), QualityMode, ScreenPercentage); }
        public EXeSSQualityMode GetXeSSQualityMode() { return Invoke<EXeSSQualityMode>(nameof(GetXeSSQualityMode)); }
        public Array<EXeSSQualityMode> GetSupportedXeSSQualityModes() { return Invoke<Array<EXeSSQualityMode>>(nameof(GetSupportedXeSSQualityModes)); }
        public EXeSSQualityMode GetDefaultXeSSQualityMode(IntPoint ScreenResolution) { return Invoke<EXeSSQualityMode>(nameof(GetDefaultXeSSQualityMode), ScreenResolution); }
    }
    public enum EXeSSQualityMode : int
    {
        Off = 0,
        Performance = 1,
        Balanced = 2,
        Quality = 3,
        UltraQuality = 4,
        EXeSSQualityMode_MAX = 5,
    }
}
