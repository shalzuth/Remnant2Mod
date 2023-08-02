using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.DeveloperSettingsSDK;
namespace SDK.Script.XeSSPluginSDK
{
    public class XeSSSettings : DeveloperSettings
    {
        public XeSSSettings(nint addr) : base(addr) { }
        public bool bEnableXeSSInEditorViewports { get { return this[nameof(bEnableXeSSInEditorViewports)].Flag; } set { this[nameof(bEnableXeSSInEditorViewports)].Flag = value; } }
        public Object DebugDataDumpPath { get { return this[nameof(DebugDataDumpPath)]; } set { this[nameof(DebugDataDumpPath)] = value; } }
    }
}
