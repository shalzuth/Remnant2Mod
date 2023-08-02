using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.DataflowCoreSDK;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.DataflowNodesSDK
{
    public class FloatOverrideDataflowNode : DataflowNode
    {
        public FloatOverrideDataflowNode(nint addr) : base(addr) { }
        public Object PropertyName { get { return this[nameof(PropertyName)]; } set { this[nameof(PropertyName)] = value; } }
        public Object KeyName { get { return this[nameof(KeyName)]; } set { this[nameof(KeyName)] = value; } }
        public float ValueOut { get { return this[nameof(ValueOut)].GetValue<float>(); } set { this[nameof(ValueOut)].SetValue<float>(value); } }
    }
    public class SelectionSetDataflowNode : DataflowNode
    {
        public SelectionSetDataflowNode(nint addr) : base(addr) { }
        public Object Indices { get { return this[nameof(Indices)]; } set { this[nameof(Indices)] = value; } }
        public Array<int> IndicesOut { get { return new Array<int>(this[nameof(IndicesOut)].Address); } }
    }
    public class GetSkeletalMeshDataflowNode : DataflowNode
    {
        public GetSkeletalMeshDataflowNode(nint addr) : base(addr) { }
        public SkeletalMesh SkeletalMesh { get { return this[nameof(SkeletalMesh)].As<SkeletalMesh>(); } set { this["SkeletalMesh"] = value; } }
        public Object PropertyName { get { return this[nameof(PropertyName)]; } set { this[nameof(PropertyName)] = value; } }
    }
    public class GetSkeletonDataflowNode : DataflowNode
    {
        public GetSkeletonDataflowNode(nint addr) : base(addr) { }
        public Skeleton Skeleton { get { return this[nameof(Skeleton)].As<Skeleton>(); } set { this["Skeleton"] = value; } }
        public Object PropertyName { get { return this[nameof(PropertyName)]; } set { this[nameof(PropertyName)] = value; } }
    }
    public class SkeletalMeshBoneDataflowNode : DataflowNode
    {
        public SkeletalMeshBoneDataflowNode(nint addr) : base(addr) { }
        public Object BoneName { get { return this[nameof(BoneName)]; } set { this[nameof(BoneName)] = value; } }
        public SkeletalMesh SkeletalMesh { get { return this[nameof(SkeletalMesh)].As<SkeletalMesh>(); } set { this["SkeletalMesh"] = value; } }
        public int BoneIndexOut { get { return this[nameof(BoneIndexOut)].GetValue<int>(); } set { this[nameof(BoneIndexOut)].SetValue<int>(value); } }
        public Object PropertyName { get { return this[nameof(PropertyName)]; } set { this[nameof(PropertyName)] = value; } }
    }
    public class SkeletalMeshReferenceTransformDataflowNode : DataflowNode
    {
        public SkeletalMeshReferenceTransformDataflowNode(nint addr) : base(addr) { }
        public SkeletalMesh SkeletalMeshIn { get { return this[nameof(SkeletalMeshIn)].As<SkeletalMesh>(); } set { this["SkeletalMeshIn"] = value; } }
        public int BoneIndexIn { get { return this[nameof(BoneIndexIn)].GetValue<int>(); } set { this[nameof(BoneIndexIn)].SetValue<int>(value); } }
        public Transform TransformOut { get { return this[nameof(TransformOut)].As<Transform>(); } set { this["TransformOut"] = value; } }
    }
    public class GetStaticMeshDataflowNode : DataflowNode
    {
        public GetStaticMeshDataflowNode(nint addr) : base(addr) { }
        public StaticMesh StaticMesh { get { return this[nameof(StaticMesh)].As<StaticMesh>(); } set { this["StaticMesh"] = value; } }
        public Object PropertyName { get { return this[nameof(PropertyName)]; } set { this[nameof(PropertyName)] = value; } }
    }
}
