using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
namespace SDK.Script.DataflowEnginePluginSDK
{
    public class DataflowActor : Actor
    {
        public DataflowActor(nint addr) : base(addr) { }
        public DataflowComponent DataflowComponent { get { return this[nameof(DataflowComponent)].As<DataflowComponent>(); } set { this["DataflowComponent"] = value; } }
    }
    public class DataflowComponent : PrimitiveComponent
    {
        public DataflowComponent(nint addr) : base(addr) { }
    }
}
