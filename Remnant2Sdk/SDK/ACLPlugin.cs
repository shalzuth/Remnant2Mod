using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
namespace SDK.Script.ACLPluginSDK
{
    public class AnimationCompressionLibraryDatabase : Object
    {
        public AnimationCompressionLibraryDatabase(nint addr) : base(addr) { }
        public Array<byte> CookedCompressedBytes { get { return new Array<byte>(this[nameof(CookedCompressedBytes)].Address); } }
        public Array<ulong> CookedAnimSequenceMappings { get { return new Array<ulong>(this[nameof(CookedAnimSequenceMappings)].Address); } }
        public uint MaxStreamRequestSizeKB { get { return this[nameof(MaxStreamRequestSizeKB)].GetValue<uint>(); } set { this[nameof(MaxStreamRequestSizeKB)].SetValue<uint>(value); } }
        public void SetVisualFidelity(Object WorldContextObject, LatentActionInfo LatentInfo, AnimationCompressionLibraryDatabase DatabaseAsset, ACLVisualFidelityChangeResult Result, ACLVisualFidelity VisualFidelity) { Invoke(nameof(SetVisualFidelity), WorldContextObject, LatentInfo, DatabaseAsset, Result, VisualFidelity); }
        public ACLVisualFidelity GetVisualFidelity(AnimationCompressionLibraryDatabase DatabaseAsset) { return Invoke<ACLVisualFidelity>(nameof(GetVisualFidelity), DatabaseAsset); }
    }
    public class AnimBoneCompressionCodec_ACLBase : AnimBoneCompressionCodec
    {
        public AnimBoneCompressionCodec_ACLBase(nint addr) : base(addr) { }
    }
    public class AnimBoneCompressionCodec_ACL : AnimBoneCompressionCodec_ACLBase
    {
        public AnimBoneCompressionCodec_ACL(nint addr) : base(addr) { }
        public AnimBoneCompressionCodec SafetyFallbackCodec { get { return this[nameof(SafetyFallbackCodec)].As<AnimBoneCompressionCodec>(); } set { this["SafetyFallbackCodec"] = value; } }
    }
    public class AnimBoneCompressionCodec_ACLCustom : AnimBoneCompressionCodec_ACLBase
    {
        public AnimBoneCompressionCodec_ACLCustom(nint addr) : base(addr) { }
    }
    public class AnimBoneCompressionCodec_ACLDatabase : AnimBoneCompressionCodec_ACLBase
    {
        public AnimBoneCompressionCodec_ACLDatabase(nint addr) : base(addr) { }
        public AnimationCompressionLibraryDatabase DatabaseAsset { get { return this[nameof(DatabaseAsset)].As<AnimationCompressionLibraryDatabase>(); } set { this["DatabaseAsset"] = value; } }
    }
    public class AnimBoneCompressionCodec_ACLSafe : AnimBoneCompressionCodec_ACLBase
    {
        public AnimBoneCompressionCodec_ACLSafe(nint addr) : base(addr) { }
    }
    public class AnimCurveCompressionCodec_ACL : AnimCurveCompressionCodec
    {
        public AnimCurveCompressionCodec_ACL(nint addr) : base(addr) { }
    }
    public enum ACLRotationFormat : int
    {
        ACLRF_Quat_129 = 0,
        ACLRF_QuatDropW_97 = 1,
        ACLRF_QuatDropW_Variable = 2,
        ACLRF_MAX = 3,
    }
    public enum ACLVectorFormat : int
    {
        ACLVF_Vector3_97 = 0,
        ACLVF_Vector3_Variable = 1,
        ACLVF_Vector3_MAX = 2,
    }
    public enum ACLCompressionLevel : int
    {
        ACLCL_Lowest = 0,
        ACLCL_Low = 1,
        ACLCL_Medium = 2,
        ACLCL_High = 3,
        ACLCL_Highest = 4,
        ACLCL_MAX = 5,
    }
    public enum ACLVisualFidelity : int
    {
        Highest = 0,
        Medium = 1,
        Lowest = 2,
        ACLVisualFidelity_MAX = 3,
    }
    public enum ACLVisualFidelityChangeResult : int
    {
        Dispatched = 0,
        Completed = 1,
        Failed = 2,
        ACLVisualFidelityChangeResult_MAX = 3,
    }
}
