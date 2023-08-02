using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.DeveloperSettingsSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.DataflowCoreSDK
{
    public class DataflowSettings : DeveloperSettings
    {
        public DataflowSettings(nint addr) : base(addr) { }
        public LinearColor ArrayPinTypeColor { get { return this[nameof(ArrayPinTypeColor)].As<LinearColor>(); } set { this["ArrayPinTypeColor"] = value; } }
        public LinearColor ManagedArrayCollectionPinTypeColor { get { return this[nameof(ManagedArrayCollectionPinTypeColor)].As<LinearColor>(); } set { this["ManagedArrayCollectionPinTypeColor"] = value; } }
        public LinearColor BoxPinTypeColor { get { return this[nameof(BoxPinTypeColor)].As<LinearColor>(); } set { this["BoxPinTypeColor"] = value; } }
        public LinearColor SpherePinTypeColor { get { return this[nameof(SpherePinTypeColor)].As<LinearColor>(); } set { this["SpherePinTypeColor"] = value; } }
        public Object NodeColorsMap { get { return this[nameof(NodeColorsMap)]; } set { this[nameof(NodeColorsMap)] = value; } }
    }
    public class DataflowNode : Object
    {
        public DataflowNode(nint addr) : base(addr) { }
        public bool bActive { get { return this[nameof(bActive)].Flag; } set { this[nameof(bActive)].Flag = value; } }
    }
    public class DataflowTerminalNode : DataflowNode
    {
        public DataflowTerminalNode(nint addr) : base(addr) { }
    }
    public class DataflowSelection : Object
    {
        public DataflowSelection(nint addr) : base(addr) { }
    }
    public class DataflowVertexSelection : DataflowSelection
    {
        public DataflowVertexSelection(nint addr) : base(addr) { }
    }
    public class DataflowFaceSelection : DataflowSelection
    {
        public DataflowFaceSelection(nint addr) : base(addr) { }
    }
    public class DataflowTransformSelection : DataflowSelection
    {
        public DataflowTransformSelection(nint addr) : base(addr) { }
    }
    public class DataflowConnection : Object
    {
        public DataflowConnection(nint addr) : base(addr) { }
    }
    public class DataflowInput : DataflowConnection
    {
        public DataflowInput(nint addr) : base(addr) { }
    }
    public class DataflowOutput : DataflowConnection
    {
        public DataflowOutput(nint addr) : base(addr) { }
    }
    public class NodeColors : Object
    {
        public NodeColors(nint addr) : base(addr) { }
        public LinearColor NodeTitleColor { get { return this[nameof(NodeTitleColor)].As<LinearColor>(); } set { this["NodeTitleColor"] = value; } }
        public LinearColor NodeBodyTintColor { get { return this[nameof(NodeBodyTintColor)].As<LinearColor>(); } set { this["NodeBodyTintColor"] = value; } }
    }
}
