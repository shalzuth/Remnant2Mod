using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
namespace SDK.Script.DataflowEngineSDK
{
    public class DataflowBlueprintLibrary : BlueprintFunctionLibrary
    {
        public DataflowBlueprintLibrary(nint addr) : base(addr) { }
        public void EvaluateTerminalNodeByName(Dataflow Dataflow, Object TerminalNodeName, Object ResultAsset) { Invoke(nameof(EvaluateTerminalNodeByName), Dataflow, TerminalNodeName, ResultAsset); }
    }
    public class DataflowEdNode : EdGraphNode
    {
        public DataflowEdNode(nint addr) : base(addr) { }
        public bool bRenderInAssetEditor { get { return this[nameof(bRenderInAssetEditor)].Flag; } set { this[nameof(bRenderInAssetEditor)].Flag = value; } }
    }
    public class Dataflow : EdGraph
    {
        public Dataflow(nint addr) : base(addr) { }
        public bool bActive { get { return this[nameof(bActive)].Flag; } set { this[nameof(bActive)].Flag = value; } }
        public Array<Object> Targets { get { return new Array<Object>(this[nameof(Targets)].Address); } }
        public Material Material { get { return this[nameof(Material)].As<Material>(); } set { this["Material"] = value; } }
    }
    public class StringValuePair : Object
    {
        public StringValuePair(nint addr) : base(addr) { }
        public Object Key { get { return this[nameof(Key)]; } set { this[nameof(Key)] = value; } }
        public Object Value { get { return this[nameof(Value)]; } set { this[nameof(Value)] = value; } }
    }
}
