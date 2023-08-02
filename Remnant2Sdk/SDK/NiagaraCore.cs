using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
namespace SDK.Script.NiagaraCoreSDK
{
    public class NiagaraMergeable : Object
    {
        public NiagaraMergeable(nint addr) : base(addr) { }
    }
    public class NiagaraDataInterfaceBase : NiagaraMergeable
    {
        public NiagaraDataInterfaceBase(nint addr) : base(addr) { }
    }
    public enum ENiagaraIterationSource : int
    {
        Particles = 0,
        DataInterface = 1,
        DirectSet = 2,
        ENiagaraIterationSource_MAX = 3,
    }
    public class NiagaraVariableCommonReference : Object
    {
        public NiagaraVariableCommonReference(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object UnderlyingType { get { return this[nameof(UnderlyingType)].As<Object>(); } set { this["UnderlyingType"] = value; } }
    }
    public class NiagaraCompileHash : Object
    {
        public NiagaraCompileHash(nint addr) : base(addr) { }
        public Array<byte> DataHash { get { return new Array<byte>(this[nameof(DataHash)].Address); } }
    }
}
