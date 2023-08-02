using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.DataflowCoreSDK;
using SDK.Script.ChaosSDK;
using SDK.Script.EngineSDK;
using SDK.Script.GeometryCollectionEngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.GeometryFrameworkSDK;
namespace SDK.Script.GeometryCollectionNodesSDK
{
    public enum EDataflowFieldFalloffType : int
    {
        Dataflow_FieldFalloffType_None = 0,
        Dataflow_FieldFalloffType_Linear = 1,
        Dataflow_FieldFalloffType_Inverse = 2,
        Dataflow_FieldFalloffType_Squared = 3,
        Dataflow_FieldFalloffType_Logarithmic = 4,
        Dataflow_Max = 5,
    }
    public enum EDataflowSetMaskConditionType : int
    {
        Dataflow_SetMaskConditionType_Always = 0,
        Dataflow_SetMaskConditionType_IFF_NOT_Interior = 1,
        Dataflow_SetMaskConditionType_IFF_NOT_Exterior = 2,
        Dataflow_Max = 3,
    }
    public enum EDataflowWaveFunctionType : int
    {
        Dataflow_WaveFunctionType_Cosine = 0,
        Dataflow_WaveFunctionType_Gaussian = 1,
        Dataflow_WaveFunctionType_Falloff = 2,
        Dataflow_WaveFunctionType_Decay = 3,
        Dataflow_Max = 4,
    }
    public enum EDataflowFloatFieldOperationType : int
    {
        Dataflow_FloatFieldOperationType_Multiply = 0,
        Dataflow_FloatFieldFalloffType_Divide = 1,
        Dataflow_FloatFieldFalloffType_Add = 2,
        Dataflow_FloatFieldFalloffType_Substract = 3,
        Dataflow_FloatFieldFalloffType_Min = 4,
        Dataflow_FloatFieldFalloffType_Max = 5,
        Dataflow_Max = 6,
    }
    public enum EDataflowVectorFieldOperationType : int
    {
        Dataflow_VectorFieldOperationType_Multiply = 0,
        Dataflow_VectorFieldFalloffType_Divide = 1,
        Dataflow_VectorFieldFalloffType_Add = 2,
        Dataflow_VectorFieldFalloffType_Substract = 3,
        Dataflow_VectorFieldFalloffType_CrossProduct = 4,
        Dataflow_Max = 5,
    }
    public enum ESetMaterialOperationTypeEnum : int
    {
        Dataflow_SetMaterialOperationType_Add = 0,
        Dataflow_SetMaterialOperationType_Insert = 1,
        Dataflow_Max = 2,
    }
    public enum EConvexOverlapRemovalMethodEnum : int
    {
        Dataflow_EConvexOverlapRemovalMethod_None = 0,
        Dataflow_EConvexOverlapRemovalMethod_All = 1,
        Dataflow_EConvexOverlapRemovalMethod_OnlyClusters = 2,
        Dataflow_EConvexOverlapRemovalMethod_OnlyClustersVsClusters = 3,
        Dataflow_Max = 4,
    }
    public enum EClusterSizeMethodEnum : int
    {
        Dataflow_ClusterSizeMethod_ByNumber = 0,
        Dataflow_ClusterSizeMethod_ByFractionOfInput = 1,
        Dataflow_ClusterSizeMethod_BySize = 2,
        Dataflow_Max = 3,
    }
    public enum EVisibiltyOptionsEnum : int
    {
        Dataflow_VisibilityOptions_Visible = 0,
        Dataflow_VisibilityOptions_Invisible = 1,
        Dataflow_Max = 2,
    }
    public enum EMeshBooleanOperationEnum : int
    {
        Dataflow_MeshBoolean_Union = 0,
        Dataflow_MeshBoolean_Intersect = 1,
        Dataflow_MeshBoolean_Difference = 2,
        Dataflow_Max = 3,
    }
    public enum EMakeBoxDataTypeEnum : int
    {
        Dataflow_MakeBox_DataType_MinMax = 0,
        Dataflow_MakeBox_DataType_CenterSize = 1,
        Dataflow_Max = 2,
    }
    public enum EFloatToIntFunctionEnum : int
    {
        Dataflow_FloatToInt_Function_Floor = 0,
        Dataflow_FloatToInt_Function_Ceil = 1,
        Dataflow_FloatToInt_Function_Round = 2,
        Dataflow_FloatToInt_Function_Truncate = 3,
        Dataflow_Max = 4,
    }
    public enum EFloatArrayToIntArrayFunctionEnum : int
    {
        Dataflow_FloatToInt_Function_Floor = 0,
        Dataflow_FloatToInt_Function_Ceil = 1,
        Dataflow_FloatToInt_Function_Round = 2,
        Dataflow_FloatToInt_Function_Truncate = 3,
        Dataflow_FloatToInt_NonZeroToIndex = 4,
        Dataflow_FloatToInt_ZeroToIndex = 5,
        Dataflow_Max = 6,
    }
    public enum EMathConstantsEnum : int
    {
        Dataflow_MathConstants_Pi = 0,
        Dataflow_MathConstants_HalfPi = 1,
        Dataflow_MathConstants_TwoPi = 2,
        Dataflow_MathConstants_FourPi = 3,
        Dataflow_MathConstants_InvPi = 4,
        Dataflow_MathConstants_InvTwoPi = 5,
        Dataflow_MathConstants_Sqrt2 = 6,
        Dataflow_MathConstants_InvSqrt2 = 7,
        Dataflow_MathConstants_Sqrt3 = 8,
        Dataflow_MathConstants_InvSqrt3 = 9,
        Dataflow_FloatToInt_Function_E = 10,
        Dataflow_FloatToInt_Function_Gamma = 11,
        Dataflow_FloatToInt_Function_GoldenRatio = 12,
        Dataflow_FloatToInt_Function_ZeroTolerance = 13,
        Dataflow_Max = 14,
    }
    public enum ERotationOrderEnum : int
    {
        Dataflow_RotationOrder_XYZ = 0,
        Dataflow_RotationOrder_YZX = 1,
        Dataflow_RotationOrder_ZXY = 2,
        Dataflow_RotationOrder_XZY = 3,
        Dataflow_RotationOrder_YXZ = 4,
        Dataflow_RotationOrder_ZYX = 5,
        Dataflow_Max = 6,
    }
    public enum ECompareOperationEnum : int
    {
        Dataflow_Compare_Equal = 0,
        Dataflow_Compare_Smaller = 1,
        Dataflow_Compare_SmallerOrEqual = 2,
        Dataflow_Compare_Greater = 3,
        Dataflow_Compare_GreaterOrEqual = 4,
        Dataflow_Max = 5,
    }
    public enum EAnchorStateEnum : int
    {
        Dataflow_AnchorState_Anchored = 0,
        Dataflow_AnchorState_NotAnchored = 1,
        Dataflow_Max = 2,
    }
    public enum EProximityMethodEnum : int
    {
        Dataflow_ProximityMethod_Precise = 0,
        Dataflow_ProximityMethod_ConvexHull = 1,
        Dataflow_Max = 2,
    }
    public enum EStandardGroupNameEnum : int
    {
        Dataflow_EStandardGroupNameEnum_Transform = 0,
        Dataflow_EStandardGroupNameEnum_Geometry = 1,
        Dataflow_EStandardGroupNameEnum_Faces = 2,
        Dataflow_EStandardGroupNameEnum_Vertices = 3,
        Dataflow_EStandardGroupNameEnum_Material = 4,
        Dataflow_EStandardGroupNameEnum_Breaking = 5,
        Dataflow_EStandardGroupNameEnum_Custom = 6,
        Dataflow_Max = 7,
    }
    public enum ECustomAttributeTypeEnum : int
    {
        Dataflow_CustomAttributeType_UInt8 = 0,
        Dataflow_CustomAttributeType_Int32 = 1,
        Dataflow_CustomAttributeType_Float = 2,
        Dataflow_CustomAttributeType_Double = 3,
        Dataflow_CustomAttributeType_Bool = 4,
        Dataflow_CustomAttributeType_String = 5,
        Dataflow_CustomAttributeType_Vector2f = 6,
        Dataflow_CustomAttributeType_Vector3f = 7,
        Dataflow_CustomAttributeType_Vector3d = 8,
        Dataflow_CustomAttributeType_Vector4f = 9,
        Dataflow_CustomAttributeType_LinearColor = 10,
        Dataflow_CustomAttributeType_Transform = 11,
        Dataflow_CustomAttributeType_Quat4f = 12,
        Dataflow_CustomAttributeType_Box = 13,
        Dataflow_CustomAttributeType_Guid = 14,
        Dataflow_CustomAttributeType_Int32Set = 15,
        Dataflow_CustomAttributeType_Int32Array = 16,
        Dataflow_CustomAttributeType_IntVector = 17,
        Dataflow_CustomAttributeType_IntVector2 = 18,
        Dataflow_CustomAttributeType_IntVector4 = 19,
        Dataflow_CustomAttributeType_IntVector2Array = 20,
        Dataflow_CustomAttributeType_FloatArray = 21,
        Dataflow_CustomAttributeType_Vector2fArray = 22,
        Dataflow_CustomAttributeType_FVector3fArray = 23,
        Dataflow_Max = 24,
    }
    public enum ESetOperationEnum : int
    {
        Dataflow_SetOperation_AND = 0,
        Dataflow_SetOperation_OR = 1,
        Dataflow_SetOperation_XOR = 2,
        Dataflow_Max = 3,
    }
    public enum ERangeSettingEnum : int
    {
        Dataflow_RangeSetting_InsideRange = 0,
        Dataflow_RangeSetting_OutsideRange = 1,
        Dataflow_Max = 2,
    }
    public enum ESelectSubjectTypeEnum : int
    {
        Dataflow_SelectSubjectType_Vertices = 0,
        Dataflow_SelectSubjectType_BoundingBox = 1,
        Dataflow_SelectSubjectType_Centroid = 2,
        Dataflow_Max = 3,
    }
    public class GeometryCollectionTerminalDataflowNode : DataflowTerminalNode
    {
        public GeometryCollectionTerminalDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public Array<Material> Materials { get { return new Array<Material>(this[nameof(Materials)].Address); } }
        public Array<GeometryCollectionAutoInstanceMesh> InstancedMeshes { get { return new Array<GeometryCollectionAutoInstanceMesh>(this[nameof(InstancedMeshes)].Address); } }
    }
    public class GetGeometryCollectionAssetDataflowNode : DataflowNode
    {
        public GetGeometryCollectionAssetDataflowNode(nint addr) : base(addr) { }
        public GeometryCollection Asset { get { return this[nameof(Asset)].As<GeometryCollection>(); } set { this["Asset"] = value; } }
    }
    public class GetGeometryCollectionSourcesDataflowNode : DataflowNode
    {
        public GetGeometryCollectionSourcesDataflowNode(nint addr) : base(addr) { }
        public GeometryCollection Asset { get { return this[nameof(Asset)].As<GeometryCollection>(); } set { this["Asset"] = value; } }
        public Array<GeometryCollectionSource> Sources { get { return new Array<GeometryCollectionSource>(this[nameof(Sources)].Address); } }
    }
    public class CreateGeometryCollectionFromSourcesDataflowNode : DataflowNode
    {
        public CreateGeometryCollectionFromSourcesDataflowNode(nint addr) : base(addr) { }
        public Array<GeometryCollectionSource> Sources { get { return new Array<GeometryCollectionSource>(this[nameof(Sources)].Address); } }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public Array<Material> Materials { get { return new Array<Material>(this[nameof(Materials)].Address); } }
        public Array<GeometryCollectionAutoInstanceMesh> InstancedMeshes { get { return new Array<GeometryCollectionAutoInstanceMesh>(this[nameof(InstancedMeshes)].Address); } }
    }
    public class RadialFalloffFieldDataflowNode : DataflowNode
    {
        public RadialFalloffFieldDataflowNode(nint addr) : base(addr) { }
        public Array<Vector3f> SamplePositions { get { return new Array<Vector3f>(this[nameof(SamplePositions)].Address); } }
        public DataflowVertexSelection SampleIndices { get { return this[nameof(SampleIndices)].As<DataflowVertexSelection>(); } set { this["SampleIndices"] = value; } }
        public Sphere Sphere { get { return this[nameof(Sphere)].As<Sphere>(); } set { this["Sphere"] = value; } }
        public Vector Translation { get { return this[nameof(Translation)].As<Vector>(); } set { this["Translation"] = value; } }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public float MinRange { get { return this[nameof(MinRange)].GetValue<float>(); } set { this[nameof(MinRange)].SetValue<float>(value); } }
        public float MaxRange { get { return this[nameof(MaxRange)].GetValue<float>(); } set { this[nameof(MaxRange)].SetValue<float>(value); } }
        public float Default { get { return this[nameof(Default)].GetValue<float>(); } set { this[nameof(Default)].SetValue<float>(value); } }
        public EDataflowFieldFalloffType FalloffType { get { return (EDataflowFieldFalloffType)this[nameof(FalloffType)].GetValue<int>(); } set { this[nameof(FalloffType)].SetValue<int>((int)value); } }
        public Array<float> FieldFloatResult { get { return new Array<float>(this[nameof(FieldFloatResult)].Address); } }
        public Array<int> FieldRemap { get { return new Array<int>(this[nameof(FieldRemap)].Address); } }
        public DataflowVertexSelection FieldSelectionMask { get { return this[nameof(FieldSelectionMask)].As<DataflowVertexSelection>(); } set { this["FieldSelectionMask"] = value; } }
        public int NumSamplePositions { get { return this[nameof(NumSamplePositions)].GetValue<int>(); } set { this[nameof(NumSamplePositions)].SetValue<int>(value); } }
    }
    public class BoxFalloffFieldDataflowNode : DataflowNode
    {
        public BoxFalloffFieldDataflowNode(nint addr) : base(addr) { }
        public Array<Vector3f> SamplePositions { get { return new Array<Vector3f>(this[nameof(SamplePositions)].Address); } }
        public DataflowVertexSelection SampleIndices { get { return this[nameof(SampleIndices)].As<DataflowVertexSelection>(); } set { this["SampleIndices"] = value; } }
        public Box Box { get { return this[nameof(Box)].As<Box>(); } set { this["Box"] = value; } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public float MinRange { get { return this[nameof(MinRange)].GetValue<float>(); } set { this[nameof(MinRange)].SetValue<float>(value); } }
        public float MaxRange { get { return this[nameof(MaxRange)].GetValue<float>(); } set { this[nameof(MaxRange)].SetValue<float>(value); } }
        public float Default { get { return this[nameof(Default)].GetValue<float>(); } set { this[nameof(Default)].SetValue<float>(value); } }
        public EDataflowFieldFalloffType FalloffType { get { return (EDataflowFieldFalloffType)this[nameof(FalloffType)].GetValue<int>(); } set { this[nameof(FalloffType)].SetValue<int>((int)value); } }
        public Array<float> FieldFloatResult { get { return new Array<float>(this[nameof(FieldFloatResult)].Address); } }
        public Array<int> FieldRemap { get { return new Array<int>(this[nameof(FieldRemap)].Address); } }
        public DataflowVertexSelection FieldSelectionMask { get { return this[nameof(FieldSelectionMask)].As<DataflowVertexSelection>(); } set { this["FieldSelectionMask"] = value; } }
        public int NumSamplePositions { get { return this[nameof(NumSamplePositions)].GetValue<int>(); } set { this[nameof(NumSamplePositions)].SetValue<int>(value); } }
    }
    public class PlaneFalloffFieldDataflowNode : DataflowNode
    {
        public PlaneFalloffFieldDataflowNode(nint addr) : base(addr) { }
        public Array<Vector3f> SamplePositions { get { return new Array<Vector3f>(this[nameof(SamplePositions)].Address); } }
        public DataflowVertexSelection SampleIndices { get { return this[nameof(SampleIndices)].As<DataflowVertexSelection>(); } set { this["SampleIndices"] = value; } }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public Vector Normal { get { return this[nameof(Normal)].As<Vector>(); } set { this["Normal"] = value; } }
        public float Distance { get { return this[nameof(Distance)].GetValue<float>(); } set { this[nameof(Distance)].SetValue<float>(value); } }
        public Vector Translation { get { return this[nameof(Translation)].As<Vector>(); } set { this["Translation"] = value; } }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public float MinRange { get { return this[nameof(MinRange)].GetValue<float>(); } set { this[nameof(MinRange)].SetValue<float>(value); } }
        public float MaxRange { get { return this[nameof(MaxRange)].GetValue<float>(); } set { this[nameof(MaxRange)].SetValue<float>(value); } }
        public float Default { get { return this[nameof(Default)].GetValue<float>(); } set { this[nameof(Default)].SetValue<float>(value); } }
        public EDataflowFieldFalloffType FalloffType { get { return (EDataflowFieldFalloffType)this[nameof(FalloffType)].GetValue<int>(); } set { this[nameof(FalloffType)].SetValue<int>((int)value); } }
        public Array<float> FieldFloatResult { get { return new Array<float>(this[nameof(FieldFloatResult)].Address); } }
        public Array<int> FieldRemap { get { return new Array<int>(this[nameof(FieldRemap)].Address); } }
        public DataflowVertexSelection FieldSelectionMask { get { return this[nameof(FieldSelectionMask)].As<DataflowVertexSelection>(); } set { this["FieldSelectionMask"] = value; } }
        public int NumSamplePositions { get { return this[nameof(NumSamplePositions)].GetValue<int>(); } set { this[nameof(NumSamplePositions)].SetValue<int>(value); } }
    }
    public class RadialIntMaskFieldDataflowNode : DataflowNode
    {
        public RadialIntMaskFieldDataflowNode(nint addr) : base(addr) { }
        public Array<Vector3f> SamplePositions { get { return new Array<Vector3f>(this[nameof(SamplePositions)].Address); } }
        public DataflowVertexSelection SampleIndices { get { return this[nameof(SampleIndices)].As<DataflowVertexSelection>(); } set { this["SampleIndices"] = value; } }
        public Sphere Sphere { get { return this[nameof(Sphere)].As<Sphere>(); } set { this["Sphere"] = value; } }
        public Vector Translation { get { return this[nameof(Translation)].As<Vector>(); } set { this["Translation"] = value; } }
        public int InteriorValue { get { return this[nameof(InteriorValue)].GetValue<int>(); } set { this[nameof(InteriorValue)].SetValue<int>(value); } }
        public int ExteriorValue { get { return this[nameof(ExteriorValue)].GetValue<int>(); } set { this[nameof(ExteriorValue)].SetValue<int>(value); } }
        public EDataflowSetMaskConditionType SetMaskConditionType { get { return (EDataflowSetMaskConditionType)this[nameof(SetMaskConditionType)].GetValue<int>(); } set { this[nameof(SetMaskConditionType)].SetValue<int>((int)value); } }
        public Array<int> FieldIntResult { get { return new Array<int>(this[nameof(FieldIntResult)].Address); } }
        public Array<int> FieldRemap { get { return new Array<int>(this[nameof(FieldRemap)].Address); } }
        public int NumSamplePositions { get { return this[nameof(NumSamplePositions)].GetValue<int>(); } set { this[nameof(NumSamplePositions)].SetValue<int>(value); } }
    }
    public class UniformScalarFieldDataflowNode : DataflowNode
    {
        public UniformScalarFieldDataflowNode(nint addr) : base(addr) { }
        public Array<Vector3f> SamplePositions { get { return new Array<Vector3f>(this[nameof(SamplePositions)].Address); } }
        public DataflowVertexSelection SampleIndices { get { return this[nameof(SampleIndices)].As<DataflowVertexSelection>(); } set { this["SampleIndices"] = value; } }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public Array<float> FieldFloatResult { get { return new Array<float>(this[nameof(FieldFloatResult)].Address); } }
        public Array<int> FieldRemap { get { return new Array<int>(this[nameof(FieldRemap)].Address); } }
        public int NumSamplePositions { get { return this[nameof(NumSamplePositions)].GetValue<int>(); } set { this[nameof(NumSamplePositions)].SetValue<int>(value); } }
    }
    public class UniformVectorFieldDataflowNode : DataflowNode
    {
        public UniformVectorFieldDataflowNode(nint addr) : base(addr) { }
        public Array<Vector3f> SamplePositions { get { return new Array<Vector3f>(this[nameof(SamplePositions)].Address); } }
        public DataflowVertexSelection SampleIndices { get { return this[nameof(SampleIndices)].As<DataflowVertexSelection>(); } set { this["SampleIndices"] = value; } }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public Vector Direction { get { return this[nameof(Direction)].As<Vector>(); } set { this["Direction"] = value; } }
        public Array<Vector> FieldVectorResult { get { return new Array<Vector>(this[nameof(FieldVectorResult)].Address); } }
        public Array<int> FieldRemap { get { return new Array<int>(this[nameof(FieldRemap)].Address); } }
        public int NumSamplePositions { get { return this[nameof(NumSamplePositions)].GetValue<int>(); } set { this[nameof(NumSamplePositions)].SetValue<int>(value); } }
    }
    public class RadialVectorFieldDataflowNode : DataflowNode
    {
        public RadialVectorFieldDataflowNode(nint addr) : base(addr) { }
        public Array<Vector3f> SamplePositions { get { return new Array<Vector3f>(this[nameof(SamplePositions)].Address); } }
        public DataflowVertexSelection SampleIndices { get { return this[nameof(SampleIndices)].As<DataflowVertexSelection>(); } set { this["SampleIndices"] = value; } }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public Array<Vector> FieldVectorResult { get { return new Array<Vector>(this[nameof(FieldVectorResult)].Address); } }
        public Array<int> FieldRemap { get { return new Array<int>(this[nameof(FieldRemap)].Address); } }
        public int NumSamplePositions { get { return this[nameof(NumSamplePositions)].GetValue<int>(); } set { this[nameof(NumSamplePositions)].SetValue<int>(value); } }
    }
    public class RandomVectorFieldDataflowNode : DataflowNode
    {
        public RandomVectorFieldDataflowNode(nint addr) : base(addr) { }
        public Array<Vector3f> SamplePositions { get { return new Array<Vector3f>(this[nameof(SamplePositions)].Address); } }
        public DataflowVertexSelection SampleIndices { get { return this[nameof(SampleIndices)].As<DataflowVertexSelection>(); } set { this["SampleIndices"] = value; } }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public Array<Vector> FieldVectorResult { get { return new Array<Vector>(this[nameof(FieldVectorResult)].Address); } }
        public Array<int> FieldRemap { get { return new Array<int>(this[nameof(FieldRemap)].Address); } }
        public int NumSamplePositions { get { return this[nameof(NumSamplePositions)].GetValue<int>(); } set { this[nameof(NumSamplePositions)].SetValue<int>(value); } }
    }
    public class NoiseFieldDataflowNode : DataflowNode
    {
        public NoiseFieldDataflowNode(nint addr) : base(addr) { }
        public Array<Vector3f> SamplePositions { get { return new Array<Vector3f>(this[nameof(SamplePositions)].Address); } }
        public DataflowVertexSelection SampleIndices { get { return this[nameof(SampleIndices)].As<DataflowVertexSelection>(); } set { this["SampleIndices"] = value; } }
        public float MinRange { get { return this[nameof(MinRange)].GetValue<float>(); } set { this[nameof(MinRange)].SetValue<float>(value); } }
        public float MaxRange { get { return this[nameof(MaxRange)].GetValue<float>(); } set { this[nameof(MaxRange)].SetValue<float>(value); } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
        public Array<float> FieldFloatResult { get { return new Array<float>(this[nameof(FieldFloatResult)].Address); } }
        public Array<int> FieldRemap { get { return new Array<int>(this[nameof(FieldRemap)].Address); } }
        public int NumSamplePositions { get { return this[nameof(NumSamplePositions)].GetValue<int>(); } set { this[nameof(NumSamplePositions)].SetValue<int>(value); } }
    }
    public class UniformIntegerFieldDataflowNode : DataflowNode
    {
        public UniformIntegerFieldDataflowNode(nint addr) : base(addr) { }
        public Array<Vector3f> SamplePositions { get { return new Array<Vector3f>(this[nameof(SamplePositions)].Address); } }
        public DataflowVertexSelection SampleIndices { get { return this[nameof(SampleIndices)].As<DataflowVertexSelection>(); } set { this["SampleIndices"] = value; } }
        public int Magnitude { get { return this[nameof(Magnitude)].GetValue<int>(); } set { this[nameof(Magnitude)].SetValue<int>(value); } }
        public Array<int> FieldIntResult { get { return new Array<int>(this[nameof(FieldIntResult)].Address); } }
        public Array<int> FieldRemap { get { return new Array<int>(this[nameof(FieldRemap)].Address); } }
        public int NumSamplePositions { get { return this[nameof(NumSamplePositions)].GetValue<int>(); } set { this[nameof(NumSamplePositions)].SetValue<int>(value); } }
    }
    public class WaveScalarFieldDataflowNode : DataflowNode
    {
        public WaveScalarFieldDataflowNode(nint addr) : base(addr) { }
        public Array<Vector3f> SamplePositions { get { return new Array<Vector3f>(this[nameof(SamplePositions)].Address); } }
        public DataflowVertexSelection SampleIndices { get { return this[nameof(SampleIndices)].As<DataflowVertexSelection>(); } set { this["SampleIndices"] = value; } }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public Vector Translation { get { return this[nameof(Translation)].As<Vector>(); } set { this["Translation"] = value; } }
        public float Wavelength { get { return this[nameof(Wavelength)].GetValue<float>(); } set { this[nameof(Wavelength)].SetValue<float>(value); } }
        public float Period { get { return this[nameof(Period)].GetValue<float>(); } set { this[nameof(Period)].SetValue<float>(value); } }
        public EDataflowWaveFunctionType FunctionType { get { return (EDataflowWaveFunctionType)this[nameof(FunctionType)].GetValue<int>(); } set { this[nameof(FunctionType)].SetValue<int>((int)value); } }
        public EDataflowFieldFalloffType FalloffType { get { return (EDataflowFieldFalloffType)this[nameof(FalloffType)].GetValue<int>(); } set { this[nameof(FalloffType)].SetValue<int>((int)value); } }
        public Array<float> FieldFloatResult { get { return new Array<float>(this[nameof(FieldFloatResult)].Address); } }
        public Array<int> FieldRemap { get { return new Array<int>(this[nameof(FieldRemap)].Address); } }
        public int NumSamplePositions { get { return this[nameof(NumSamplePositions)].GetValue<int>(); } set { this[nameof(NumSamplePositions)].SetValue<int>(value); } }
    }
    public class SumScalarFieldDataflowNode : DataflowNode
    {
        public SumScalarFieldDataflowNode(nint addr) : base(addr) { }
        public Array<float> FieldFloatLeft { get { return new Array<float>(this[nameof(FieldFloatLeft)].Address); } }
        public Array<int> FieldRemapLeft { get { return new Array<int>(this[nameof(FieldRemapLeft)].Address); } }
        public Array<float> FieldFloatRight { get { return new Array<float>(this[nameof(FieldFloatRight)].Address); } }
        public Array<int> FieldRemapRight { get { return new Array<int>(this[nameof(FieldRemapRight)].Address); } }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public EDataflowFloatFieldOperationType Operation { get { return (EDataflowFloatFieldOperationType)this[nameof(Operation)].GetValue<int>(); } set { this[nameof(Operation)].SetValue<int>((int)value); } }
        public bool bSwapInputs { get { return this[nameof(bSwapInputs)].Flag; } set { this[nameof(bSwapInputs)].Flag = value; } }
        public Array<float> FieldFloatResult { get { return new Array<float>(this[nameof(FieldFloatResult)].Address); } }
        public Array<int> FieldRemap { get { return new Array<int>(this[nameof(FieldRemap)].Address); } }
    }
    public class SumVectorFieldDataflowNode : DataflowNode
    {
        public SumVectorFieldDataflowNode(nint addr) : base(addr) { }
        public Array<float> FieldFloat { get { return new Array<float>(this[nameof(FieldFloat)].Address); } }
        public Array<int> FieldFloatRemap { get { return new Array<int>(this[nameof(FieldFloatRemap)].Address); } }
        public Array<Vector> FieldVectorLeft { get { return new Array<Vector>(this[nameof(FieldVectorLeft)].Address); } }
        public Array<int> FieldRemapLeft { get { return new Array<int>(this[nameof(FieldRemapLeft)].Address); } }
        public Array<Vector> FieldVectorRight { get { return new Array<Vector>(this[nameof(FieldVectorRight)].Address); } }
        public Array<int> FieldRemapRight { get { return new Array<int>(this[nameof(FieldRemapRight)].Address); } }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public EDataflowVectorFieldOperationType Operation { get { return (EDataflowVectorFieldOperationType)this[nameof(Operation)].GetValue<int>(); } set { this[nameof(Operation)].SetValue<int>((int)value); } }
        public bool bSwapVectorInputs { get { return this[nameof(bSwapVectorInputs)].Flag; } set { this[nameof(bSwapVectorInputs)].Flag = value; } }
        public Array<Vector> FieldVectorResult { get { return new Array<Vector>(this[nameof(FieldVectorResult)].Address); } }
        public Array<int> FieldRemap { get { return new Array<int>(this[nameof(FieldRemap)].Address); } }
    }
    public class FieldMakeDenseFloatArrayDataflowNode : DataflowNode
    {
        public FieldMakeDenseFloatArrayDataflowNode(nint addr) : base(addr) { }
        public Array<float> FieldFloatInput { get { return new Array<float>(this[nameof(FieldFloatInput)].Address); } }
        public Array<int> FieldRemap { get { return new Array<int>(this[nameof(FieldRemap)].Address); } }
        public int NumSamplePositions { get { return this[nameof(NumSamplePositions)].GetValue<int>(); } set { this[nameof(NumSamplePositions)].SetValue<int>(value); } }
        public float Default { get { return this[nameof(Default)].GetValue<float>(); } set { this[nameof(Default)].SetValue<float>(value); } }
        public Array<float> FieldFloatResult { get { return new Array<float>(this[nameof(FieldFloatResult)].Address); } }
    }
    public class AddMaterialToCollectionDataflowNode : DataflowNode
    {
        public AddMaterialToCollectionDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public DataflowFaceSelection FaceSelection { get { return this[nameof(FaceSelection)].As<DataflowFaceSelection>(); } set { this["FaceSelection"] = value; } }
        public Array<Material> Materials { get { return new Array<Material>(this[nameof(Materials)].Address); } }
        public Material OutsideMaterial { get { return this[nameof(OutsideMaterial)].As<Material>(); } set { this["OutsideMaterial"] = value; } }
        public Material InsideMaterial { get { return this[nameof(InsideMaterial)].As<Material>(); } set { this["InsideMaterial"] = value; } }
        public bool bAssignOutsideMaterial { get { return this[nameof(bAssignOutsideMaterial)].Flag; } set { this[nameof(bAssignOutsideMaterial)].Flag = value; } }
        public bool bAssignInsideMaterial { get { return this[nameof(bAssignInsideMaterial)].Flag; } set { this[nameof(bAssignInsideMaterial)].Flag = value; } }
    }
    public class ReAssignMaterialInCollectionDataflowNode : DataflowNode
    {
        public ReAssignMaterialInCollectionDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public DataflowFaceSelection FaceSelection { get { return this[nameof(FaceSelection)].As<DataflowFaceSelection>(); } set { this["FaceSelection"] = value; } }
        public Array<Material> Materials { get { return new Array<Material>(this[nameof(Materials)].Address); } }
        public int OutsideMaterialIdx { get { return this[nameof(OutsideMaterialIdx)].GetValue<int>(); } set { this[nameof(OutsideMaterialIdx)].SetValue<int>(value); } }
        public int InsideMaterialIdx { get { return this[nameof(InsideMaterialIdx)].GetValue<int>(); } set { this[nameof(InsideMaterialIdx)].SetValue<int>(value); } }
        public bool bAssignOutsideMaterial { get { return this[nameof(bAssignOutsideMaterial)].Flag; } set { this[nameof(bAssignOutsideMaterial)].Flag = value; } }
        public bool bAssignInsideMaterial { get { return this[nameof(bAssignInsideMaterial)].Flag; } set { this[nameof(bAssignInsideMaterial)].Flag = value; } }
    }
    public class MaterialsInfoDataflowNode : DataflowNode
    {
        public MaterialsInfoDataflowNode(nint addr) : base(addr) { }
        public Array<Material> Materials { get { return new Array<Material>(this[nameof(Materials)].Address); } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
    }
    public class GetMaterialFromMaterialsArrayDataflowNode : DataflowNode
    {
        public GetMaterialFromMaterialsArrayDataflowNode(nint addr) : base(addr) { }
        public Array<Material> Materials { get { return new Array<Material>(this[nameof(Materials)].Address); } }
        public Material Material { get { return this[nameof(Material)].As<Material>(); } set { this["Material"] = value; } }
        public int MaterialIdx { get { return this[nameof(MaterialIdx)].GetValue<int>(); } set { this[nameof(MaterialIdx)].SetValue<int>(value); } }
    }
    public class SetMaterialInMaterialsArrayDataflowNode : DataflowNode
    {
        public SetMaterialInMaterialsArrayDataflowNode(nint addr) : base(addr) { }
        public Array<Material> Materials { get { return new Array<Material>(this[nameof(Materials)].Address); } }
        public Material Material { get { return this[nameof(Material)].As<Material>(); } set { this["Material"] = value; } }
        public ESetMaterialOperationTypeEnum Operation { get { return (ESetMaterialOperationTypeEnum)this[nameof(Operation)].GetValue<int>(); } set { this[nameof(Operation)].SetValue<int>((int)value); } }
        public int MaterialIdx { get { return this[nameof(MaterialIdx)].GetValue<int>(); } set { this[nameof(MaterialIdx)].SetValue<int>(value); } }
    }
    public class MakeMaterialDataflowNode : DataflowNode
    {
        public MakeMaterialDataflowNode(nint addr) : base(addr) { }
        public Material InMaterial { get { return this[nameof(InMaterial)].As<Material>(); } set { this["InMaterial"] = value; } }
        public Material Material { get { return this[nameof(Material)].As<Material>(); } set { this["Material"] = value; } }
    }
    public class MakeMaterialsArrayDataflowNode : DataflowNode
    {
        public MakeMaterialsArrayDataflowNode(nint addr) : base(addr) { }
        public Array<Material> Materials { get { return new Array<Material>(this[nameof(Materials)].Address); } }
    }
    public class CloseGeometryOnCollectionDataflowNode : DataflowNode
    {
        public CloseGeometryOnCollectionDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
    }
    public class SkeletonToCollectionDataflowNode : DataflowNode
    {
        public SkeletonToCollectionDataflowNode(nint addr) : base(addr) { }
        public Skeleton Skeleton { get { return this[nameof(Skeleton)].As<Skeleton>(); } set { this["Skeleton"] = value; } }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
    }
    public class CreateNonOverlappingConvexHullsDataflowNode : DataflowNode
    {
        public CreateNonOverlappingConvexHullsDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public float CanRemoveFraction { get { return this[nameof(CanRemoveFraction)].GetValue<float>(); } set { this[nameof(CanRemoveFraction)].SetValue<float>(value); } }
        public float SimplificationDistanceThreshold { get { return this[nameof(SimplificationDistanceThreshold)].GetValue<float>(); } set { this[nameof(SimplificationDistanceThreshold)].SetValue<float>(value); } }
        public float CanExceedFraction { get { return this[nameof(CanExceedFraction)].GetValue<float>(); } set { this[nameof(CanExceedFraction)].SetValue<float>(value); } }
        public EConvexOverlapRemovalMethodEnum OverlapRemovalMethod { get { return (EConvexOverlapRemovalMethodEnum)this[nameof(OverlapRemovalMethod)].GetValue<int>(); } set { this[nameof(OverlapRemovalMethod)].SetValue<int>((int)value); } }
        public float OverlapRemovalShrinkPercent { get { return this[nameof(OverlapRemovalShrinkPercent)].GetValue<float>(); } set { this[nameof(OverlapRemovalShrinkPercent)].SetValue<float>(value); } }
    }
    public class AutoClusterDataflowNode : DataflowNode
    {
        public AutoClusterDataflowNode(nint addr) : base(addr) { }
        public EClusterSizeMethodEnum ClusterSizeMethod { get { return (EClusterSizeMethodEnum)this[nameof(ClusterSizeMethod)].GetValue<int>(); } set { this[nameof(ClusterSizeMethod)].SetValue<int>((int)value); } }
        public int ClusterSites { get { return this[nameof(ClusterSites)].GetValue<int>(); } set { this[nameof(ClusterSites)].SetValue<int>(value); } }
        public float ClusterFraction { get { return this[nameof(ClusterFraction)].GetValue<float>(); } set { this[nameof(ClusterFraction)].SetValue<float>(value); } }
        public float SiteSize { get { return this[nameof(SiteSize)].GetValue<float>(); } set { this[nameof(SiteSize)].SetValue<float>(value); } }
        public bool AutoCluster { get { return this[nameof(AutoCluster)].Flag; } set { this[nameof(AutoCluster)].Flag = value; } }
        public bool AvoidIsolated { get { return this[nameof(AvoidIsolated)].Flag; } set { this[nameof(AvoidIsolated)].Flag = value; } }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
    }
    public class ClusterFlattenDataflowNode : DataflowNode
    {
        public ClusterFlattenDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
    }
    public class PruneInCollectionDataflowNode : DataflowNode
    {
        public PruneInCollectionDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
    }
    public class SetVisibilityInCollectionDataflowNode : DataflowNode
    {
        public SetVisibilityInCollectionDataflowNode(nint addr) : base(addr) { }
        public EVisibiltyOptionsEnum Visibility { get { return (EVisibiltyOptionsEnum)this[nameof(Visibility)].GetValue<int>(); } set { this[nameof(Visibility)].SetValue<int>((int)value); } }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
        public DataflowFaceSelection FaceSelection { get { return this[nameof(FaceSelection)].As<DataflowFaceSelection>(); } set { this["FaceSelection"] = value; } }
    }
    public class MergeInCollectionDataflowNode : DataflowNode
    {
        public MergeInCollectionDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
    }
    public class UniformScatterPointsDataflowNode : DataflowNode
    {
        public UniformScatterPointsDataflowNode(nint addr) : base(addr) { }
        public int MinNumberOfPoints { get { return this[nameof(MinNumberOfPoints)].GetValue<int>(); } set { this[nameof(MinNumberOfPoints)].SetValue<int>(value); } }
        public int MaxNumberOfPoints { get { return this[nameof(MaxNumberOfPoints)].GetValue<int>(); } set { this[nameof(MaxNumberOfPoints)].SetValue<int>(value); } }
        public float RandomSeed { get { return this[nameof(RandomSeed)].GetValue<float>(); } set { this[nameof(RandomSeed)].SetValue<float>(value); } }
        public Box BoundingBox { get { return this[nameof(BoundingBox)].As<Box>(); } set { this["BoundingBox"] = value; } }
        public Array<Vector> Points { get { return new Array<Vector>(this[nameof(Points)].Address); } }
    }
    public class RadialScatterPointsDataflowNode : DataflowNode
    {
        public RadialScatterPointsDataflowNode(nint addr) : base(addr) { }
        public Vector Center { get { return this[nameof(Center)].As<Vector>(); } set { this["Center"] = value; } }
        public Vector Normal { get { return this[nameof(Normal)].As<Vector>(); } set { this["Normal"] = value; } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public int AngularSteps { get { return this[nameof(AngularSteps)].GetValue<int>(); } set { this[nameof(AngularSteps)].SetValue<int>(value); } }
        public int RadialSteps { get { return this[nameof(RadialSteps)].GetValue<int>(); } set { this[nameof(RadialSteps)].SetValue<int>(value); } }
        public float AngleOffset { get { return this[nameof(AngleOffset)].GetValue<float>(); } set { this[nameof(AngleOffset)].SetValue<float>(value); } }
        public float Variability { get { return this[nameof(Variability)].GetValue<float>(); } set { this[nameof(Variability)].SetValue<float>(value); } }
        public float RandomSeed { get { return this[nameof(RandomSeed)].GetValue<float>(); } set { this[nameof(RandomSeed)].SetValue<float>(value); } }
        public Array<Vector> Points { get { return new Array<Vector>(this[nameof(Points)].Address); } }
    }
    public class VoronoiFractureDataflowNode : DataflowNode
    {
        public VoronoiFractureDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public Array<Vector> Points { get { return new Array<Vector>(this[nameof(Points)].Address); } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
        public float RandomSeed { get { return this[nameof(RandomSeed)].GetValue<float>(); } set { this[nameof(RandomSeed)].SetValue<float>(value); } }
        public float ChanceToFracture { get { return this[nameof(ChanceToFracture)].GetValue<float>(); } set { this[nameof(ChanceToFracture)].SetValue<float>(value); } }
        public bool GroupFracture { get { return this[nameof(GroupFracture)].Flag; } set { this[nameof(GroupFracture)].Flag = value; } }
        public float Grout { get { return this[nameof(Grout)].GetValue<float>(); } set { this[nameof(Grout)].SetValue<float>(value); } }
        public float Amplitude { get { return this[nameof(Amplitude)].GetValue<float>(); } set { this[nameof(Amplitude)].SetValue<float>(value); } }
        public float Frequency { get { return this[nameof(Frequency)].GetValue<float>(); } set { this[nameof(Frequency)].SetValue<float>(value); } }
        public float Persistence { get { return this[nameof(Persistence)].GetValue<float>(); } set { this[nameof(Persistence)].SetValue<float>(value); } }
        public float Lacunarity { get { return this[nameof(Lacunarity)].GetValue<float>(); } set { this[nameof(Lacunarity)].SetValue<float>(value); } }
        public int OctaveNumber { get { return this[nameof(OctaveNumber)].GetValue<int>(); } set { this[nameof(OctaveNumber)].SetValue<int>(value); } }
        public float PointSpacing { get { return this[nameof(PointSpacing)].GetValue<float>(); } set { this[nameof(PointSpacing)].SetValue<float>(value); } }
        public bool AddSamplesForCollision { get { return this[nameof(AddSamplesForCollision)].Flag; } set { this[nameof(AddSamplesForCollision)].Flag = value; } }
        public float CollisionSampleSpacing { get { return this[nameof(CollisionSampleSpacing)].GetValue<float>(); } set { this[nameof(CollisionSampleSpacing)].SetValue<float>(value); } }
    }
    public class PlaneCutterDataflowNode : DataflowNode
    {
        public PlaneCutterDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public Box BoundingBox { get { return this[nameof(BoundingBox)].As<Box>(); } set { this["BoundingBox"] = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
        public int NumPlanes { get { return this[nameof(NumPlanes)].GetValue<int>(); } set { this[nameof(NumPlanes)].SetValue<int>(value); } }
        public float RandomSeed { get { return this[nameof(RandomSeed)].GetValue<float>(); } set { this[nameof(RandomSeed)].SetValue<float>(value); } }
        public float Grout { get { return this[nameof(Grout)].GetValue<float>(); } set { this[nameof(Grout)].SetValue<float>(value); } }
        public float Amplitude { get { return this[nameof(Amplitude)].GetValue<float>(); } set { this[nameof(Amplitude)].SetValue<float>(value); } }
        public float Frequency { get { return this[nameof(Frequency)].GetValue<float>(); } set { this[nameof(Frequency)].SetValue<float>(value); } }
        public float Persistence { get { return this[nameof(Persistence)].GetValue<float>(); } set { this[nameof(Persistence)].SetValue<float>(value); } }
        public float Lacunarity { get { return this[nameof(Lacunarity)].GetValue<float>(); } set { this[nameof(Lacunarity)].SetValue<float>(value); } }
        public int OctaveNumber { get { return this[nameof(OctaveNumber)].GetValue<int>(); } set { this[nameof(OctaveNumber)].SetValue<int>(value); } }
        public float PointSpacing { get { return this[nameof(PointSpacing)].GetValue<float>(); } set { this[nameof(PointSpacing)].SetValue<float>(value); } }
        public bool AddSamplesForCollision { get { return this[nameof(AddSamplesForCollision)].Flag; } set { this[nameof(AddSamplesForCollision)].Flag = value; } }
        public float CollisionSampleSpacing { get { return this[nameof(CollisionSampleSpacing)].GetValue<float>(); } set { this[nameof(CollisionSampleSpacing)].SetValue<float>(value); } }
    }
    public class ExplodedViewDataflowNode : DataflowNode
    {
        public ExplodedViewDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public float UniformScale { get { return this[nameof(UniformScale)].GetValue<float>(); } set { this[nameof(UniformScale)].SetValue<float>(value); } }
        public Vector Scale { get { return this[nameof(Scale)].As<Vector>(); } set { this["Scale"] = value; } }
    }
    public class PointsToMeshDataflowNode : DataflowNode
    {
        public PointsToMeshDataflowNode(nint addr) : base(addr) { }
        public Array<Vector> Points { get { return new Array<Vector>(this[nameof(Points)].Address); } }
        public DynamicMesh Mesh { get { return this[nameof(Mesh)].As<DynamicMesh>(); } set { this["Mesh"] = value; } }
        public int TriangleCount { get { return this[nameof(TriangleCount)].GetValue<int>(); } set { this[nameof(TriangleCount)].SetValue<int>(value); } }
    }
    public class BoxToMeshDataflowNode : DataflowNode
    {
        public BoxToMeshDataflowNode(nint addr) : base(addr) { }
        public Box Box { get { return this[nameof(Box)].As<Box>(); } set { this["Box"] = value; } }
        public DynamicMesh Mesh { get { return this[nameof(Mesh)].As<DynamicMesh>(); } set { this["Mesh"] = value; } }
        public int TriangleCount { get { return this[nameof(TriangleCount)].GetValue<int>(); } set { this[nameof(TriangleCount)].SetValue<int>(value); } }
    }
    public class MeshInfoDataflowNode : DataflowNode
    {
        public MeshInfoDataflowNode(nint addr) : base(addr) { }
        public DynamicMesh Mesh { get { return this[nameof(Mesh)].As<DynamicMesh>(); } set { this["Mesh"] = value; } }
        public Object InfoString { get { return this[nameof(InfoString)]; } set { this[nameof(InfoString)] = value; } }
    }
    public class MeshToCollectionDataflowNode : DataflowNode
    {
        public MeshToCollectionDataflowNode(nint addr) : base(addr) { }
        public DynamicMesh Mesh { get { return this[nameof(Mesh)].As<DynamicMesh>(); } set { this["Mesh"] = value; } }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
    }
    public class CollectionToMeshDataflowNode : DataflowNode
    {
        public CollectionToMeshDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public bool bCenterPivot { get { return this[nameof(bCenterPivot)].Flag; } set { this[nameof(bCenterPivot)].Flag = value; } }
        public DynamicMesh Mesh { get { return this[nameof(Mesh)].As<DynamicMesh>(); } set { this["Mesh"] = value; } }
    }
    public class StaticMeshToMeshDataflowNode : DataflowNode
    {
        public StaticMeshToMeshDataflowNode(nint addr) : base(addr) { }
        public StaticMesh StaticMesh { get { return this[nameof(StaticMesh)].As<StaticMesh>(); } set { this["StaticMesh"] = value; } }
        public bool bUseHiRes { get { return this[nameof(bUseHiRes)].Flag; } set { this[nameof(bUseHiRes)].Flag = value; } }
        public int LODLevel { get { return this[nameof(LODLevel)].GetValue<int>(); } set { this[nameof(LODLevel)].SetValue<int>(value); } }
        public DynamicMesh Mesh { get { return this[nameof(Mesh)].As<DynamicMesh>(); } set { this["Mesh"] = value; } }
    }
    public class MeshAppendDataflowNode : DataflowNode
    {
        public MeshAppendDataflowNode(nint addr) : base(addr) { }
        public DynamicMesh Mesh1 { get { return this[nameof(Mesh1)].As<DynamicMesh>(); } set { this["Mesh1"] = value; } }
        public DynamicMesh Mesh2 { get { return this[nameof(Mesh2)].As<DynamicMesh>(); } set { this["Mesh2"] = value; } }
        public DynamicMesh Mesh { get { return this[nameof(Mesh)].As<DynamicMesh>(); } set { this["Mesh"] = value; } }
    }
    public class MeshBooleanDataflowNode : DataflowNode
    {
        public MeshBooleanDataflowNode(nint addr) : base(addr) { }
        public EMeshBooleanOperationEnum Operation { get { return (EMeshBooleanOperationEnum)this[nameof(Operation)].GetValue<int>(); } set { this[nameof(Operation)].SetValue<int>((int)value); } }
        public DynamicMesh Mesh1 { get { return this[nameof(Mesh1)].As<DynamicMesh>(); } set { this["Mesh1"] = value; } }
        public DynamicMesh Mesh2 { get { return this[nameof(Mesh2)].As<DynamicMesh>(); } set { this["Mesh2"] = value; } }
        public DynamicMesh Mesh { get { return this[nameof(Mesh)].As<DynamicMesh>(); } set { this["Mesh"] = value; } }
    }
    public class MeshCopyToPointsDataflowNode : DataflowNode
    {
        public MeshCopyToPointsDataflowNode(nint addr) : base(addr) { }
        public Array<Vector> Points { get { return new Array<Vector>(this[nameof(Points)].Address); } }
        public DynamicMesh MeshToCopy { get { return this[nameof(MeshToCopy)].As<DynamicMesh>(); } set { this["MeshToCopy"] = value; } }
        public float Scale { get { return this[nameof(Scale)].GetValue<float>(); } set { this[nameof(Scale)].SetValue<float>(value); } }
        public DynamicMesh Mesh { get { return this[nameof(Mesh)].As<DynamicMesh>(); } set { this["Mesh"] = value; } }
    }
    public class GetMeshDataDataflowNode : DataflowNode
    {
        public GetMeshDataDataflowNode(nint addr) : base(addr) { }
        public DynamicMesh Mesh { get { return this[nameof(Mesh)].As<DynamicMesh>(); } set { this["Mesh"] = value; } }
        public int VertexCount { get { return this[nameof(VertexCount)].GetValue<int>(); } set { this[nameof(VertexCount)].SetValue<int>(value); } }
        public int EdgeCount { get { return this[nameof(EdgeCount)].GetValue<int>(); } set { this[nameof(EdgeCount)].SetValue<int>(value); } }
        public int TriangleCount { get { return this[nameof(TriangleCount)].GetValue<int>(); } set { this[nameof(TriangleCount)].SetValue<int>(value); } }
    }
    public class GetCollectionFromAssetDataflowNode : DataflowNode
    {
        public GetCollectionFromAssetDataflowNode(nint addr) : base(addr) { }
        public GeometryCollection CollectionAsset { get { return this[nameof(CollectionAsset)].As<GeometryCollection>(); } set { this["CollectionAsset"] = value; } }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
    }
    public class AppendCollectionAssetsDataflowNode : DataflowNode
    {
        public AppendCollectionAssetsDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection1 { get { return this[nameof(Collection1)].As<ManagedArrayCollection>(); } set { this["Collection1"] = value; } }
        public ManagedArrayCollection Collection2 { get { return this[nameof(Collection2)].As<ManagedArrayCollection>(); } set { this["Collection2"] = value; } }
        public Array<Object> GeometryGroupGuidsOut1 { get { return new Array<Object>(this[nameof(GeometryGroupGuidsOut1)].Address); } }
        public Array<Object> GeometryGroupGuidsOut2 { get { return new Array<Object>(this[nameof(GeometryGroupGuidsOut2)].Address); } }
    }
    public class PrintStringDataflowNode : DataflowNode
    {
        public PrintStringDataflowNode(nint addr) : base(addr) { }
        public bool bPrintToScreen { get { return this[nameof(bPrintToScreen)].Flag; } set { this[nameof(bPrintToScreen)].Flag = value; } }
        public bool bPrintToLog { get { return this[nameof(bPrintToLog)].Flag; } set { this[nameof(bPrintToLog)].Flag = value; } }
        public Color Color { get { return this[nameof(Color)].As<Color>(); } set { this["Color"] = value; } }
        public float Duration { get { return this[nameof(Duration)].GetValue<float>(); } set { this[nameof(Duration)].SetValue<float>(value); } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
    }
    public class LogStringDataflowNode : DataflowNode
    {
        public LogStringDataflowNode(nint addr) : base(addr) { }
        public bool bPrintToLog { get { return this[nameof(bPrintToLog)].Flag; } set { this[nameof(bPrintToLog)].Flag = value; } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
    }
    public class MakeLiteralStringDataflowNode : DataflowNode
    {
        public MakeLiteralStringDataflowNode(nint addr) : base(addr) { }
        public Object Value { get { return this[nameof(Value)]; } set { this[nameof(Value)] = value; } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
    }
    public class BoundingBoxDataflowNode : DataflowNode
    {
        public BoundingBoxDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public Box BoundingBox { get { return this[nameof(BoundingBox)].As<Box>(); } set { this["BoundingBox"] = value; } }
    }
    public class ExpandBoundingBoxDataflowNode : DataflowNode
    {
        public ExpandBoundingBoxDataflowNode(nint addr) : base(addr) { }
        public Box BoundingBox { get { return this[nameof(BoundingBox)].As<Box>(); } set { this["BoundingBox"] = value; } }
        public Vector Min { get { return this[nameof(Min)].As<Vector>(); } set { this["Min"] = value; } }
        public Vector Max { get { return this[nameof(Max)].As<Vector>(); } set { this["Max"] = value; } }
        public Vector Center { get { return this[nameof(Center)].As<Vector>(); } set { this["Center"] = value; } }
        public Vector HalfExtents { get { return this[nameof(HalfExtents)].As<Vector>(); } set { this["HalfExtents"] = value; } }
        public float Volume { get { return this[nameof(Volume)].GetValue<float>(); } set { this[nameof(Volume)].SetValue<float>(value); } }
    }
    public class VectorToStringDataflowNode : DataflowNode
    {
        public VectorToStringDataflowNode(nint addr) : base(addr) { }
        public Vector Vector { get { return this[nameof(Vector)].As<Vector>(); } set { this["Vector"] = value; } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
    }
    public class FloatToStringDataflowNode : DataflowNode
    {
        public FloatToStringDataflowNode(nint addr) : base(addr) { }
        public float Float { get { return this[nameof(Float)].GetValue<float>(); } set { this[nameof(Float)].SetValue<float>(value); } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
    }
    public class MakePointsDataflowNode : DataflowNode
    {
        public MakePointsDataflowNode(nint addr) : base(addr) { }
        public Array<Vector> Point { get { return new Array<Vector>(this[nameof(Point)].Address); } }
        public Array<Vector> Points { get { return new Array<Vector>(this[nameof(Points)].Address); } }
    }
    public class MakeBoxDataflowNode : DataflowNode
    {
        public MakeBoxDataflowNode(nint addr) : base(addr) { }
        public EMakeBoxDataTypeEnum DataType { get { return (EMakeBoxDataTypeEnum)this[nameof(DataType)].GetValue<int>(); } set { this[nameof(DataType)].SetValue<int>((int)value); } }
        public Vector Min { get { return this[nameof(Min)].As<Vector>(); } set { this["Min"] = value; } }
        public Vector Max { get { return this[nameof(Max)].As<Vector>(); } set { this["Max"] = value; } }
        public Vector Center { get { return this[nameof(Center)].As<Vector>(); } set { this["Center"] = value; } }
        public Vector Size { get { return this[nameof(Size)].As<Vector>(); } set { this["Size"] = value; } }
        public Box Box { get { return this[nameof(Box)].As<Box>(); } set { this["Box"] = value; } }
    }
    public class MakeSphereDataflowNode : DataflowNode
    {
        public MakeSphereDataflowNode(nint addr) : base(addr) { }
        public Vector Center { get { return this[nameof(Center)].As<Vector>(); } set { this["Center"] = value; } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public Sphere Sphere { get { return this[nameof(Sphere)].As<Sphere>(); } set { this["Sphere"] = value; } }
    }
    public class MakeLiteralFloatDataflowNode : DataflowNode
    {
        public MakeLiteralFloatDataflowNode(nint addr) : base(addr) { }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
        public float Float { get { return this[nameof(Float)].GetValue<float>(); } set { this[nameof(Float)].SetValue<float>(value); } }
    }
    public class MakeLiteralIntDataflowNode : DataflowNode
    {
        public MakeLiteralIntDataflowNode(nint addr) : base(addr) { }
        public int Value { get { return this[nameof(Value)].GetValue<int>(); } set { this[nameof(Value)].SetValue<int>(value); } }
        public int Int { get { return this[nameof(Int)].GetValue<int>(); } set { this[nameof(Int)].SetValue<int>(value); } }
    }
    public class MakeLiteralBoolDataflowNode : DataflowNode
    {
        public MakeLiteralBoolDataflowNode(nint addr) : base(addr) { }
        public bool Value { get { return this[nameof(Value)].Flag; } set { this[nameof(Value)].Flag = value; } }
        public bool Bool { get { return this[nameof(Bool)].Flag; } set { this[nameof(Bool)].Flag = value; } }
    }
    public class MakeLiteralVectorDataflowNode : DataflowNode
    {
        public MakeLiteralVectorDataflowNode(nint addr) : base(addr) { }
        public float X { get { return this[nameof(X)].GetValue<float>(); } set { this[nameof(X)].SetValue<float>(value); } }
        public float Y { get { return this[nameof(Y)].GetValue<float>(); } set { this[nameof(Y)].SetValue<float>(value); } }
        public float Z { get { return this[nameof(Z)].GetValue<float>(); } set { this[nameof(Z)].SetValue<float>(value); } }
        public Vector Vector { get { return this[nameof(Vector)].As<Vector>(); } set { this["Vector"] = value; } }
    }
    public class IntToStringDataflowNode : DataflowNode
    {
        public IntToStringDataflowNode(nint addr) : base(addr) { }
        public int Int { get { return this[nameof(Int)].GetValue<int>(); } set { this[nameof(Int)].SetValue<int>(value); } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
    }
    public class BoolToStringDataflowNode : DataflowNode
    {
        public BoolToStringDataflowNode(nint addr) : base(addr) { }
        public bool Bool { get { return this[nameof(Bool)].Flag; } set { this[nameof(Bool)].Flag = value; } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
    }
    public class ExpandVectorDataflowNode : DataflowNode
    {
        public ExpandVectorDataflowNode(nint addr) : base(addr) { }
        public Vector Vector { get { return this[nameof(Vector)].As<Vector>(); } set { this["Vector"] = value; } }
        public float X { get { return this[nameof(X)].GetValue<float>(); } set { this[nameof(X)].SetValue<float>(value); } }
        public float Y { get { return this[nameof(Y)].GetValue<float>(); } set { this[nameof(Y)].SetValue<float>(value); } }
        public float Z { get { return this[nameof(Z)].GetValue<float>(); } set { this[nameof(Z)].SetValue<float>(value); } }
    }
    public class IntToFloatDataflowNode : DataflowNode
    {
        public IntToFloatDataflowNode(nint addr) : base(addr) { }
        public int Int { get { return this[nameof(Int)].GetValue<int>(); } set { this[nameof(Int)].SetValue<int>(value); } }
        public float Float { get { return this[nameof(Float)].GetValue<float>(); } set { this[nameof(Float)].SetValue<float>(value); } }
    }
    public class StringAppendDataflowNode : DataflowNode
    {
        public StringAppendDataflowNode(nint addr) : base(addr) { }
        public Object String1 { get { return this[nameof(String1)]; } set { this[nameof(String1)] = value; } }
        public Object String2 { get { return this[nameof(String2)]; } set { this[nameof(String2)] = value; } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
    }
    public class RandomFloatDataflowNode : DataflowNode
    {
        public RandomFloatDataflowNode(nint addr) : base(addr) { }
        public bool bDeterministic { get { return this[nameof(bDeterministic)].Flag; } set { this[nameof(bDeterministic)].Flag = value; } }
        public float RandomSeed { get { return this[nameof(RandomSeed)].GetValue<float>(); } set { this[nameof(RandomSeed)].SetValue<float>(value); } }
        public float Float { get { return this[nameof(Float)].GetValue<float>(); } set { this[nameof(Float)].SetValue<float>(value); } }
    }
    public class RandomFloatInRangeDataflowNode : DataflowNode
    {
        public RandomFloatInRangeDataflowNode(nint addr) : base(addr) { }
        public bool bDeterministic { get { return this[nameof(bDeterministic)].Flag; } set { this[nameof(bDeterministic)].Flag = value; } }
        public float RandomSeed { get { return this[nameof(RandomSeed)].GetValue<float>(); } set { this[nameof(RandomSeed)].SetValue<float>(value); } }
        public float Min { get { return this[nameof(Min)].GetValue<float>(); } set { this[nameof(Min)].SetValue<float>(value); } }
        public float Max { get { return this[nameof(Max)].GetValue<float>(); } set { this[nameof(Max)].SetValue<float>(value); } }
        public float Float { get { return this[nameof(Float)].GetValue<float>(); } set { this[nameof(Float)].SetValue<float>(value); } }
    }
    public class RandomUnitVectorDataflowNode : DataflowNode
    {
        public RandomUnitVectorDataflowNode(nint addr) : base(addr) { }
        public bool bDeterministic { get { return this[nameof(bDeterministic)].Flag; } set { this[nameof(bDeterministic)].Flag = value; } }
        public float RandomSeed { get { return this[nameof(RandomSeed)].GetValue<float>(); } set { this[nameof(RandomSeed)].SetValue<float>(value); } }
        public Vector Vector { get { return this[nameof(Vector)].As<Vector>(); } set { this["Vector"] = value; } }
    }
    public class RandomUnitVectorInConeDataflowNode : DataflowNode
    {
        public RandomUnitVectorInConeDataflowNode(nint addr) : base(addr) { }
        public bool bDeterministic { get { return this[nameof(bDeterministic)].Flag; } set { this[nameof(bDeterministic)].Flag = value; } }
        public float RandomSeed { get { return this[nameof(RandomSeed)].GetValue<float>(); } set { this[nameof(RandomSeed)].SetValue<float>(value); } }
        public Vector ConeDirection { get { return this[nameof(ConeDirection)].As<Vector>(); } set { this["ConeDirection"] = value; } }
        public float ConeHalfAngle { get { return this[nameof(ConeHalfAngle)].GetValue<float>(); } set { this[nameof(ConeHalfAngle)].SetValue<float>(value); } }
        public Vector Vector { get { return this[nameof(Vector)].As<Vector>(); } set { this["Vector"] = value; } }
    }
    public class RadiansToDegreesDataflowNode : DataflowNode
    {
        public RadiansToDegreesDataflowNode(nint addr) : base(addr) { }
        public float Radians { get { return this[nameof(Radians)].GetValue<float>(); } set { this[nameof(Radians)].SetValue<float>(value); } }
        public float Degrees { get { return this[nameof(Degrees)].GetValue<float>(); } set { this[nameof(Degrees)].SetValue<float>(value); } }
    }
    public class DegreesToRadiansDataflowNode : DataflowNode
    {
        public DegreesToRadiansDataflowNode(nint addr) : base(addr) { }
        public float Degrees { get { return this[nameof(Degrees)].GetValue<float>(); } set { this[nameof(Degrees)].SetValue<float>(value); } }
        public float Radians { get { return this[nameof(Radians)].GetValue<float>(); } set { this[nameof(Radians)].SetValue<float>(value); } }
    }
    public class HashStringDataflowNode : DataflowNode
    {
        public HashStringDataflowNode(nint addr) : base(addr) { }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
        public int Hash { get { return this[nameof(Hash)].GetValue<int>(); } set { this[nameof(Hash)].SetValue<int>(value); } }
    }
    public class HashVectorDataflowNode : DataflowNode
    {
        public HashVectorDataflowNode(nint addr) : base(addr) { }
        public Vector Vector { get { return this[nameof(Vector)].As<Vector>(); } set { this["Vector"] = value; } }
        public int Hash { get { return this[nameof(Hash)].GetValue<int>(); } set { this[nameof(Hash)].SetValue<int>(value); } }
    }
    public class FloatToIntDataflowNode : DataflowNode
    {
        public FloatToIntDataflowNode(nint addr) : base(addr) { }
        public EFloatToIntFunctionEnum Function { get { return (EFloatToIntFunctionEnum)this[nameof(Function)].GetValue<int>(); } set { this[nameof(Function)].SetValue<int>((int)value); } }
        public float Float { get { return this[nameof(Float)].GetValue<float>(); } set { this[nameof(Float)].SetValue<float>(value); } }
        public int Int { get { return this[nameof(Int)].GetValue<int>(); } set { this[nameof(Int)].SetValue<int>(value); } }
    }
    public class FloatArrayToIntArrayDataflowNode : DataflowNode
    {
        public FloatArrayToIntArrayDataflowNode(nint addr) : base(addr) { }
        public EFloatArrayToIntArrayFunctionEnum Function { get { return (EFloatArrayToIntArrayFunctionEnum)this[nameof(Function)].GetValue<int>(); } set { this[nameof(Function)].SetValue<int>((int)value); } }
        public Array<float> FloatArray { get { return new Array<float>(this[nameof(FloatArray)].Address); } }
        public Array<int> IntArray { get { return new Array<int>(this[nameof(IntArray)].Address); } }
    }
    public class MathConstantsDataflowNode : DataflowNode
    {
        public MathConstantsDataflowNode(nint addr) : base(addr) { }
        public EMathConstantsEnum Constant { get { return (EMathConstantsEnum)this[nameof(Constant)].GetValue<int>(); } set { this[nameof(Constant)].SetValue<int>((int)value); } }
        public float Float { get { return this[nameof(Float)].GetValue<float>(); } set { this[nameof(Float)].SetValue<float>(value); } }
    }
    public class GetArrayElementDataflowNode : DataflowNode
    {
        public GetArrayElementDataflowNode(nint addr) : base(addr) { }
        public int Index { get { return this[nameof(Index)].GetValue<int>(); } set { this[nameof(Index)].SetValue<int>(value); } }
        public Array<Vector> Points { get { return new Array<Vector>(this[nameof(Points)].Address); } }
        public Vector Point { get { return this[nameof(Point)].As<Vector>(); } set { this["Point"] = value; } }
    }
    public class GetNumArrayElementsDataflowNode : DataflowNode
    {
        public GetNumArrayElementsDataflowNode(nint addr) : base(addr) { }
        public Array<Vector> Points { get { return new Array<Vector>(this[nameof(Points)].Address); } }
        public Array<Vector3f> Vector3fArray { get { return new Array<Vector3f>(this[nameof(Vector3fArray)].Address); } }
        public int NumElements { get { return this[nameof(NumElements)].GetValue<int>(); } set { this[nameof(NumElements)].SetValue<int>(value); } }
    }
    public class GetBoundingBoxesFromCollectionDataflowNode : DataflowNode
    {
        public GetBoundingBoxesFromCollectionDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
        public Array<Box> BoundingBoxes { get { return new Array<Box>(this[nameof(BoundingBoxes)].Address); } }
    }
    public class GetCentroidsFromCollectionDataflowNode : DataflowNode
    {
        public GetCentroidsFromCollectionDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
        public Array<Vector> Centroids { get { return new Array<Vector>(this[nameof(Centroids)].Address); } }
    }
    public class TransformCollectionDataflowNode : DataflowNode
    {
        public TransformCollectionDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public Vector Translate { get { return this[nameof(Translate)].As<Vector>(); } set { this["Translate"] = value; } }
        public ERotationOrderEnum RotationOrder { get { return (ERotationOrderEnum)this[nameof(RotationOrder)].GetValue<int>(); } set { this[nameof(RotationOrder)].SetValue<int>((int)value); } }
        public Vector Rotate { get { return this[nameof(Rotate)].As<Vector>(); } set { this["Rotate"] = value; } }
        public Vector Scale { get { return this[nameof(Scale)].As<Vector>(); } set { this["Scale"] = value; } }
        public float UniformScale { get { return this[nameof(UniformScale)].GetValue<float>(); } set { this[nameof(UniformScale)].SetValue<float>(value); } }
        public Vector RotatePivot { get { return this[nameof(RotatePivot)].As<Vector>(); } set { this["RotatePivot"] = value; } }
        public Vector ScalePivot { get { return this[nameof(ScalePivot)].As<Vector>(); } set { this["ScalePivot"] = value; } }
        public bool bInvertTransformation { get { return this[nameof(bInvertTransformation)].Flag; } set { this[nameof(bInvertTransformation)].Flag = value; } }
    }
    public class BakeTransformsInCollectionDataflowNode : DataflowNode
    {
        public BakeTransformsInCollectionDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
    }
    public class TransformMeshDataflowNode : DataflowNode
    {
        public TransformMeshDataflowNode(nint addr) : base(addr) { }
        public DynamicMesh Mesh { get { return this[nameof(Mesh)].As<DynamicMesh>(); } set { this["Mesh"] = value; } }
        public Vector Translate { get { return this[nameof(Translate)].As<Vector>(); } set { this["Translate"] = value; } }
        public ERotationOrderEnum RotationOrder { get { return (ERotationOrderEnum)this[nameof(RotationOrder)].GetValue<int>(); } set { this[nameof(RotationOrder)].SetValue<int>((int)value); } }
        public Vector Rotate { get { return this[nameof(Rotate)].As<Vector>(); } set { this["Rotate"] = value; } }
        public Vector Scale { get { return this[nameof(Scale)].As<Vector>(); } set { this["Scale"] = value; } }
        public float UniformScale { get { return this[nameof(UniformScale)].GetValue<float>(); } set { this[nameof(UniformScale)].SetValue<float>(value); } }
        public Vector RotatePivot { get { return this[nameof(RotatePivot)].As<Vector>(); } set { this["RotatePivot"] = value; } }
        public Vector ScalePivot { get { return this[nameof(ScalePivot)].As<Vector>(); } set { this["ScalePivot"] = value; } }
        public bool bInvertTransformation { get { return this[nameof(bInvertTransformation)].Flag; } set { this[nameof(bInvertTransformation)].Flag = value; } }
    }
    public class CompareIntDataflowNode : DataflowNode
    {
        public CompareIntDataflowNode(nint addr) : base(addr) { }
        public ECompareOperationEnum Operation { get { return (ECompareOperationEnum)this[nameof(Operation)].GetValue<int>(); } set { this[nameof(Operation)].SetValue<int>((int)value); } }
        public int IntA { get { return this[nameof(IntA)].GetValue<int>(); } set { this[nameof(IntA)].SetValue<int>(value); } }
        public int IntB { get { return this[nameof(IntB)].GetValue<int>(); } set { this[nameof(IntB)].SetValue<int>(value); } }
        public bool Result { get { return this[nameof(Result)].Flag; } set { this[nameof(Result)].Flag = value; } }
    }
    public class BranchDataflowNode : DataflowNode
    {
        public BranchDataflowNode(nint addr) : base(addr) { }
        public DynamicMesh MeshA { get { return this[nameof(MeshA)].As<DynamicMesh>(); } set { this["MeshA"] = value; } }
        public DynamicMesh MeshB { get { return this[nameof(MeshB)].As<DynamicMesh>(); } set { this["MeshB"] = value; } }
        public bool bCondition { get { return this[nameof(bCondition)].Flag; } set { this[nameof(bCondition)].Flag = value; } }
        public DynamicMesh Mesh { get { return this[nameof(Mesh)].As<DynamicMesh>(); } set { this["Mesh"] = value; } }
    }
    public class GetSchemaDataflowNode : DataflowNode
    {
        public GetSchemaDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
    }
    public class RemoveOnBreakDataflowNode : DataflowNode
    {
        public RemoveOnBreakDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
        public bool bEnabledRemoval { get { return this[nameof(bEnabledRemoval)].Flag; } set { this[nameof(bEnabledRemoval)].Flag = value; } }
        public Vector2f PostBreakTimer { get { return this[nameof(PostBreakTimer)].As<Vector2f>(); } set { this["PostBreakTimer"] = value; } }
        public Vector2f RemovalTimer { get { return this[nameof(RemovalTimer)].As<Vector2f>(); } set { this["RemovalTimer"] = value; } }
        public bool bClusterCrumbling { get { return this[nameof(bClusterCrumbling)].Flag; } set { this[nameof(bClusterCrumbling)].Flag = value; } }
    }
    public class SetAnchorStateDataflowNode : DataflowNode
    {
        public SetAnchorStateDataflowNode(nint addr) : base(addr) { }
        public EAnchorStateEnum AnchorState { get { return (EAnchorStateEnum)this[nameof(AnchorState)].GetValue<int>(); } set { this[nameof(AnchorState)].SetValue<int>((int)value); } }
        public bool bSetNotSelectedBonesToOppositeState { get { return this[nameof(bSetNotSelectedBonesToOppositeState)].Flag; } set { this[nameof(bSetNotSelectedBonesToOppositeState)].Flag = value; } }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
    }
    public class ProximityDataflowNode : DataflowNode
    {
        public ProximityDataflowNode(nint addr) : base(addr) { }
        public EProximityMethodEnum ProximityMethod { get { return (EProximityMethodEnum)this[nameof(ProximityMethod)].GetValue<int>(); } set { this[nameof(ProximityMethod)].SetValue<int>((int)value); } }
        public float DistanceThreshold { get { return this[nameof(DistanceThreshold)].GetValue<float>(); } set { this[nameof(DistanceThreshold)].SetValue<float>(value); } }
        public float ContactThreshold { get { return this[nameof(ContactThreshold)].GetValue<float>(); } set { this[nameof(ContactThreshold)].SetValue<float>(value); } }
        public bool bUseAsConnectionGraph { get { return this[nameof(bUseAsConnectionGraph)].Flag; } set { this[nameof(bUseAsConnectionGraph)].Flag = value; } }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
    }
    public class CollectionSetPivotDataflowNode : DataflowNode
    {
        public CollectionSetPivotDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
    }
    public class AddCustomCollectionAttributeDataflowNode : DataflowNode
    {
        public AddCustomCollectionAttributeDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public EStandardGroupNameEnum GroupName { get { return (EStandardGroupNameEnum)this[nameof(GroupName)].GetValue<int>(); } set { this[nameof(GroupName)].SetValue<int>((int)value); } }
        public Object CustomGroupName { get { return this[nameof(CustomGroupName)]; } set { this[nameof(CustomGroupName)] = value; } }
        public Object AttrName { get { return this[nameof(AttrName)]; } set { this[nameof(AttrName)] = value; } }
        public ECustomAttributeTypeEnum CustomAttributeType { get { return (ECustomAttributeTypeEnum)this[nameof(CustomAttributeType)].GetValue<int>(); } set { this[nameof(CustomAttributeType)].SetValue<int>((int)value); } }
        public int NumElements { get { return this[nameof(NumElements)].GetValue<int>(); } set { this[nameof(NumElements)].SetValue<int>(value); } }
    }
    public class GetNumElementsInCollectionGroupDataflowNode : DataflowNode
    {
        public GetNumElementsInCollectionGroupDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public EStandardGroupNameEnum GroupName { get { return (EStandardGroupNameEnum)this[nameof(GroupName)].GetValue<int>(); } set { this[nameof(GroupName)].SetValue<int>((int)value); } }
        public Object CustomGroupName { get { return this[nameof(CustomGroupName)]; } set { this[nameof(CustomGroupName)] = value; } }
        public int NumElements { get { return this[nameof(NumElements)].GetValue<int>(); } set { this[nameof(NumElements)].SetValue<int>(value); } }
    }
    public class GetCollectionAttributeDataTypedDataflowNode : DataflowNode
    {
        public GetCollectionAttributeDataTypedDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public EStandardGroupNameEnum GroupName { get { return (EStandardGroupNameEnum)this[nameof(GroupName)].GetValue<int>(); } set { this[nameof(GroupName)].SetValue<int>((int)value); } }
        public Object CustomGroupName { get { return this[nameof(CustomGroupName)]; } set { this[nameof(CustomGroupName)] = value; } }
        public Object AttrName { get { return this[nameof(AttrName)]; } set { this[nameof(AttrName)] = value; } }
        public Array<bool> BoolAttributeData { get { return new Array<bool>(this[nameof(BoolAttributeData)].Address); } }
        public Array<float> FloatAttributeData { get { return new Array<float>(this[nameof(FloatAttributeData)].Address); } }
        public Array<double> DoubleAttributeData { get { return new Array<double>(this[nameof(DoubleAttributeData)].Address); } }
        public Array<int> Int32AttributeData { get { return new Array<int>(this[nameof(Int32AttributeData)].Address); } }
        public Array<Object> StringAttributeData { get { return new Array<Object>(this[nameof(StringAttributeData)].Address); } }
        public Array<Vector3f> Vector3fAttributeData { get { return new Array<Vector3f>(this[nameof(Vector3fAttributeData)].Address); } }
        public Array<Vector3d> Vector3dAttributeData { get { return new Array<Vector3d>(this[nameof(Vector3dAttributeData)].Address); } }
    }
    public class SetCollectionAttributeDataTypedDataflowNode : DataflowNode
    {
        public SetCollectionAttributeDataTypedDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public EStandardGroupNameEnum GroupName { get { return (EStandardGroupNameEnum)this[nameof(GroupName)].GetValue<int>(); } set { this[nameof(GroupName)].SetValue<int>((int)value); } }
        public Object CustomGroupName { get { return this[nameof(CustomGroupName)]; } set { this[nameof(CustomGroupName)] = value; } }
        public Object AttrName { get { return this[nameof(AttrName)]; } set { this[nameof(AttrName)] = value; } }
        public Array<bool> BoolAttributeData { get { return new Array<bool>(this[nameof(BoolAttributeData)].Address); } }
        public Array<float> FloatAttributeData { get { return new Array<float>(this[nameof(FloatAttributeData)].Address); } }
        public Array<double> DoubleAttributeData { get { return new Array<double>(this[nameof(DoubleAttributeData)].Address); } }
        public Array<int> Int32AttributeData { get { return new Array<int>(this[nameof(Int32AttributeData)].Address); } }
        public Array<Object> StringAttributeData { get { return new Array<Object>(this[nameof(StringAttributeData)].Address); } }
        public Array<Vector3f> Vector3fAttributeData { get { return new Array<Vector3f>(this[nameof(Vector3fAttributeData)].Address); } }
        public Array<Vector3d> Vector3dAttributeData { get { return new Array<Vector3d>(this[nameof(Vector3dAttributeData)].Address); } }
    }
    public class BoolArrayToFaceSelectionDataflowNode : DataflowNode
    {
        public BoolArrayToFaceSelectionDataflowNode(nint addr) : base(addr) { }
        public Array<bool> BoolAttributeData { get { return new Array<bool>(this[nameof(BoolAttributeData)].Address); } }
        public DataflowFaceSelection FaceSelection { get { return this[nameof(FaceSelection)].As<DataflowFaceSelection>(); } set { this["FaceSelection"] = value; } }
    }
    public class FloatArrayToVertexSelectionDataflowNode : DataflowNode
    {
        public FloatArrayToVertexSelectionDataflowNode(nint addr) : base(addr) { }
        public Array<float> FloatArray { get { return new Array<float>(this[nameof(FloatArray)].Address); } }
        public ECompareOperationEnum Operation { get { return (ECompareOperationEnum)this[nameof(Operation)].GetValue<int>(); } set { this[nameof(Operation)].SetValue<int>((int)value); } }
        public float Threshold { get { return this[nameof(Threshold)].GetValue<float>(); } set { this[nameof(Threshold)].SetValue<float>(value); } }
        public DataflowVertexSelection VertexSelection { get { return this[nameof(VertexSelection)].As<DataflowVertexSelection>(); } set { this["VertexSelection"] = value; } }
    }
    public class SetVertexColorInCollectionFromVertexSelectionDataflowNode : DataflowNode
    {
        public SetVertexColorInCollectionFromVertexSelectionDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public DataflowVertexSelection VertexSelection { get { return this[nameof(VertexSelection)].As<DataflowVertexSelection>(); } set { this["VertexSelection"] = value; } }
        public LinearColor SelectedColor { get { return this[nameof(SelectedColor)].As<LinearColor>(); } set { this["SelectedColor"] = value; } }
        public LinearColor NonSelectedColor { get { return this[nameof(NonSelectedColor)].As<LinearColor>(); } set { this["NonSelectedColor"] = value; } }
    }
    public class SelectionToVertexListDataflowNode : DataflowNode
    {
        public SelectionToVertexListDataflowNode(nint addr) : base(addr) { }
        public DataflowVertexSelection VertexSelection { get { return this[nameof(VertexSelection)].As<DataflowVertexSelection>(); } set { this["VertexSelection"] = value; } }
        public Array<int> VertexList { get { return new Array<int>(this[nameof(VertexList)].Address); } }
    }
    public class MakeTransformDataflowNode : DataflowNode
    {
        public MakeTransformDataflowNode(nint addr) : base(addr) { }
        public Vector InTranslation { get { return this[nameof(InTranslation)].As<Vector>(); } set { this["InTranslation"] = value; } }
        public Vector InRotation { get { return this[nameof(InRotation)].As<Vector>(); } set { this["InRotation"] = value; } }
        public Vector InScale { get { return this[nameof(InScale)].As<Vector>(); } set { this["InScale"] = value; } }
        public Transform OutTransform { get { return this[nameof(OutTransform)].As<Transform>(); } set { this["OutTransform"] = value; } }
    }
    public class SetVertexColorInCollectionFromFloatArrayDataflowNode : DataflowNode
    {
        public SetVertexColorInCollectionFromFloatArrayDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public Array<float> FloatArray { get { return new Array<float>(this[nameof(FloatArray)].Address); } }
        public float Scale { get { return this[nameof(Scale)].GetValue<float>(); } set { this[nameof(Scale)].SetValue<float>(value); } }
    }
    public class FloatArrayNormalizeDataflowNode : DataflowNode
    {
        public FloatArrayNormalizeDataflowNode(nint addr) : base(addr) { }
        public Array<float> InFloatArray { get { return new Array<float>(this[nameof(InFloatArray)].Address); } }
        public DataflowVertexSelection Selection { get { return this[nameof(Selection)].As<DataflowVertexSelection>(); } set { this["Selection"] = value; } }
        public float MinRange { get { return this[nameof(MinRange)].GetValue<float>(); } set { this[nameof(MinRange)].SetValue<float>(value); } }
        public float MaxRange { get { return this[nameof(MaxRange)].GetValue<float>(); } set { this[nameof(MaxRange)].SetValue<float>(value); } }
        public Array<float> OutFloatArray { get { return new Array<float>(this[nameof(OutFloatArray)].Address); } }
    }
    public class VectorArrayNormalizeDataflowNode : DataflowNode
    {
        public VectorArrayNormalizeDataflowNode(nint addr) : base(addr) { }
        public Array<Vector> InVectorArray { get { return new Array<Vector>(this[nameof(InVectorArray)].Address); } }
        public DataflowVertexSelection Selection { get { return this[nameof(Selection)].As<DataflowVertexSelection>(); } set { this["Selection"] = value; } }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public Array<Vector> OutVectorArray { get { return new Array<Vector>(this[nameof(OutVectorArray)].Address); } }
    }
    public class MultiplyTransformDataflowNode : DataflowNode
    {
        public MultiplyTransformDataflowNode(nint addr) : base(addr) { }
        public Transform InLeftTransform { get { return this[nameof(InLeftTransform)].As<Transform>(); } set { this["InLeftTransform"] = value; } }
        public Transform InRightTransform { get { return this[nameof(InRightTransform)].As<Transform>(); } set { this["InRightTransform"] = value; } }
        public Transform OutTransform { get { return this[nameof(OutTransform)].As<Transform>(); } set { this["OutTransform"] = value; } }
    }
    public class InvertTransformDataflowNode : DataflowNode
    {
        public InvertTransformDataflowNode(nint addr) : base(addr) { }
        public Transform InTransform { get { return this[nameof(InTransform)].As<Transform>(); } set { this["InTransform"] = value; } }
        public Transform OutTransform { get { return this[nameof(OutTransform)].As<Transform>(); } set { this["OutTransform"] = value; } }
    }
    public class UnionIntArraysDataflowNode : DataflowNode
    {
        public UnionIntArraysDataflowNode(nint addr) : base(addr) { }
        public Array<int> InArray1 { get { return new Array<int>(this[nameof(InArray1)].Address); } }
        public Array<int> InArray2 { get { return new Array<int>(this[nameof(InArray2)].Address); } }
        public Array<int> OutArray { get { return new Array<int>(this[nameof(OutArray)].Address); } }
    }
    public class MakeQuaternionDataflowNode : DataflowNode
    {
        public MakeQuaternionDataflowNode(nint addr) : base(addr) { }
        public float X { get { return this[nameof(X)].GetValue<float>(); } set { this[nameof(X)].SetValue<float>(value); } }
        public float Y { get { return this[nameof(Y)].GetValue<float>(); } set { this[nameof(Y)].SetValue<float>(value); } }
        public float Z { get { return this[nameof(Z)].GetValue<float>(); } set { this[nameof(Z)].SetValue<float>(value); } }
        public float W { get { return this[nameof(W)].GetValue<float>(); } set { this[nameof(W)].SetValue<float>(value); } }
        public Quat Quaternion { get { return this[nameof(Quaternion)].As<Quat>(); } set { this["Quaternion"] = value; } }
    }
    public class CollectionTransformSelectionAllDataflowNode : DataflowNode
    {
        public CollectionTransformSelectionAllDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
    }
    public class CollectionTransformSelectionSetOperationDataflowNode : DataflowNode
    {
        public CollectionTransformSelectionSetOperationDataflowNode(nint addr) : base(addr) { }
        public ESetOperationEnum Operation { get { return (ESetOperationEnum)this[nameof(Operation)].GetValue<int>(); } set { this[nameof(Operation)].SetValue<int>((int)value); } }
        public DataflowTransformSelection TransformSelectionA { get { return this[nameof(TransformSelectionA)].As<DataflowTransformSelection>(); } set { this["TransformSelectionA"] = value; } }
        public DataflowTransformSelection TransformSelectionB { get { return this[nameof(TransformSelectionB)].As<DataflowTransformSelection>(); } set { this["TransformSelectionB"] = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
    }
    public class CollectionTransformSelectionInfoDataflowNode : DataflowNode
    {
        public CollectionTransformSelectionInfoDataflowNode(nint addr) : base(addr) { }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
    }
    public class CollectionTransformSelectionNoneDataflowNode : DataflowNode
    {
        public CollectionTransformSelectionNoneDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
    }
    public class CollectionTransformSelectionInvertDataflowNode : DataflowNode
    {
        public CollectionTransformSelectionInvertDataflowNode(nint addr) : base(addr) { }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
    }
    public class CollectionTransformSelectionRandomDataflowNode : DataflowNode
    {
        public CollectionTransformSelectionRandomDataflowNode(nint addr) : base(addr) { }
        public bool bDeterministic { get { return this[nameof(bDeterministic)].Flag; } set { this[nameof(bDeterministic)].Flag = value; } }
        public float RandomSeed { get { return this[nameof(RandomSeed)].GetValue<float>(); } set { this[nameof(RandomSeed)].SetValue<float>(value); } }
        public float RandomThreshold { get { return this[nameof(RandomThreshold)].GetValue<float>(); } set { this[nameof(RandomThreshold)].SetValue<float>(value); } }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
    }
    public class CollectionTransformSelectionRootDataflowNode : DataflowNode
    {
        public CollectionTransformSelectionRootDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
    }
    public class CollectionTransformSelectionCustomDataflowNode : DataflowNode
    {
        public CollectionTransformSelectionCustomDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public Object BoneIndicies { get { return this[nameof(BoneIndicies)]; } set { this[nameof(BoneIndicies)] = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
    }
    public class CollectionTransformSelectionParentDataflowNode : DataflowNode
    {
        public CollectionTransformSelectionParentDataflowNode(nint addr) : base(addr) { }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
    }
    public class CollectionTransformSelectionByPercentageDataflowNode : DataflowNode
    {
        public CollectionTransformSelectionByPercentageDataflowNode(nint addr) : base(addr) { }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
        public int Percentage { get { return this[nameof(Percentage)].GetValue<int>(); } set { this[nameof(Percentage)].SetValue<int>(value); } }
        public bool bDeterministic { get { return this[nameof(bDeterministic)].Flag; } set { this[nameof(bDeterministic)].Flag = value; } }
        public float RandomSeed { get { return this[nameof(RandomSeed)].GetValue<float>(); } set { this[nameof(RandomSeed)].SetValue<float>(value); } }
    }
    public class CollectionTransformSelectionChildrenDataflowNode : DataflowNode
    {
        public CollectionTransformSelectionChildrenDataflowNode(nint addr) : base(addr) { }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
    }
    public class CollectionTransformSelectionSiblingsDataflowNode : DataflowNode
    {
        public CollectionTransformSelectionSiblingsDataflowNode(nint addr) : base(addr) { }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
    }
    public class CollectionTransformSelectionLevelDataflowNode : DataflowNode
    {
        public CollectionTransformSelectionLevelDataflowNode(nint addr) : base(addr) { }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
    }
    public class CollectionTransformSelectionContactDataflowNode : DataflowNode
    {
        public CollectionTransformSelectionContactDataflowNode(nint addr) : base(addr) { }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
    }
    public class CollectionTransformSelectionLeafDataflowNode : DataflowNode
    {
        public CollectionTransformSelectionLeafDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
    }
    public class CollectionTransformSelectionClusterDataflowNode : DataflowNode
    {
        public CollectionTransformSelectionClusterDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
    }
    public class CollectionTransformSelectionBySizeDataflowNode : DataflowNode
    {
        public CollectionTransformSelectionBySizeDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public float SizeMin { get { return this[nameof(SizeMin)].GetValue<float>(); } set { this[nameof(SizeMin)].SetValue<float>(value); } }
        public float SizeMax { get { return this[nameof(SizeMax)].GetValue<float>(); } set { this[nameof(SizeMax)].SetValue<float>(value); } }
        public ERangeSettingEnum RangeSetting { get { return (ERangeSettingEnum)this[nameof(RangeSetting)].GetValue<int>(); } set { this[nameof(RangeSetting)].SetValue<int>((int)value); } }
        public bool bInclusive { get { return this[nameof(bInclusive)].Flag; } set { this[nameof(bInclusive)].Flag = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
    }
    public class CollectionTransformSelectionByVolumeDataflowNode : DataflowNode
    {
        public CollectionTransformSelectionByVolumeDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public float VolumeMin { get { return this[nameof(VolumeMin)].GetValue<float>(); } set { this[nameof(VolumeMin)].SetValue<float>(value); } }
        public float VolumeMax { get { return this[nameof(VolumeMax)].GetValue<float>(); } set { this[nameof(VolumeMax)].SetValue<float>(value); } }
        public ERangeSettingEnum RangeSetting { get { return (ERangeSettingEnum)this[nameof(RangeSetting)].GetValue<int>(); } set { this[nameof(RangeSetting)].SetValue<int>((int)value); } }
        public bool bInclusive { get { return this[nameof(bInclusive)].Flag; } set { this[nameof(bInclusive)].Flag = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
    }
    public class CollectionTransformSelectionInBoxDataflowNode : DataflowNode
    {
        public CollectionTransformSelectionInBoxDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public Box Box { get { return this[nameof(Box)].As<Box>(); } set { this["Box"] = value; } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
        public ESelectSubjectTypeEnum Type { get { return (ESelectSubjectTypeEnum)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public bool bAllVerticesMustContainedInBox { get { return this[nameof(bAllVerticesMustContainedInBox)].Flag; } set { this[nameof(bAllVerticesMustContainedInBox)].Flag = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
    }
    public class CollectionTransformSelectionInSphereDataflowNode : DataflowNode
    {
        public CollectionTransformSelectionInSphereDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public Sphere Sphere { get { return this[nameof(Sphere)].As<Sphere>(); } set { this["Sphere"] = value; } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
        public ESelectSubjectTypeEnum Type { get { return (ESelectSubjectTypeEnum)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public bool bAllVerticesMustContainedInSphere { get { return this[nameof(bAllVerticesMustContainedInSphere)].Flag; } set { this[nameof(bAllVerticesMustContainedInSphere)].Flag = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
    }
    public class CollectionTransformSelectionByFloatAttrDataflowNode : DataflowNode
    {
        public CollectionTransformSelectionByFloatAttrDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public Object GroupName { get { return this[nameof(GroupName)]; } set { this[nameof(GroupName)] = value; } }
        public Object AttrName { get { return this[nameof(AttrName)]; } set { this[nameof(AttrName)] = value; } }
        public float Min { get { return this[nameof(Min)].GetValue<float>(); } set { this[nameof(Min)].SetValue<float>(value); } }
        public float Max { get { return this[nameof(Max)].GetValue<float>(); } set { this[nameof(Max)].SetValue<float>(value); } }
        public ERangeSettingEnum RangeSetting { get { return (ERangeSettingEnum)this[nameof(RangeSetting)].GetValue<int>(); } set { this[nameof(RangeSetting)].SetValue<int>((int)value); } }
        public bool bInclusive { get { return this[nameof(bInclusive)].Flag; } set { this[nameof(bInclusive)].Flag = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
    }
    public class CollectionTransformSelectionByIntAttrDataflowNode : DataflowNode
    {
        public CollectionTransformSelectionByIntAttrDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public Object GroupName { get { return this[nameof(GroupName)]; } set { this[nameof(GroupName)] = value; } }
        public Object AttrName { get { return this[nameof(AttrName)]; } set { this[nameof(AttrName)] = value; } }
        public int Min { get { return this[nameof(Min)].GetValue<int>(); } set { this[nameof(Min)].SetValue<int>(value); } }
        public int Max { get { return this[nameof(Max)].GetValue<int>(); } set { this[nameof(Max)].SetValue<int>(value); } }
        public ERangeSettingEnum RangeSetting { get { return (ERangeSettingEnum)this[nameof(RangeSetting)].GetValue<int>(); } set { this[nameof(RangeSetting)].SetValue<int>((int)value); } }
        public bool bInclusive { get { return this[nameof(bInclusive)].Flag; } set { this[nameof(bInclusive)].Flag = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
    }
    public class CollectionVertexSelectionCustomDataflowNode : DataflowNode
    {
        public CollectionVertexSelectionCustomDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public Object VertexIndicies { get { return this[nameof(VertexIndicies)]; } set { this[nameof(VertexIndicies)] = value; } }
        public DataflowVertexSelection VertexSelection { get { return this[nameof(VertexSelection)].As<DataflowVertexSelection>(); } set { this["VertexSelection"] = value; } }
    }
    public class CollectionFaceSelectionCustomDataflowNode : DataflowNode
    {
        public CollectionFaceSelectionCustomDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public Object FaceIndicies { get { return this[nameof(FaceIndicies)]; } set { this[nameof(FaceIndicies)] = value; } }
        public DataflowFaceSelection FaceSelection { get { return this[nameof(FaceSelection)].As<DataflowFaceSelection>(); } set { this["FaceSelection"] = value; } }
    }
    public class CollectionSelectionConvertDataflowNode : DataflowNode
    {
        public CollectionSelectionConvertDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public DataflowTransformSelection TransformSelection { get { return this[nameof(TransformSelection)].As<DataflowTransformSelection>(); } set { this["TransformSelection"] = value; } }
        public DataflowFaceSelection FaceSelection { get { return this[nameof(FaceSelection)].As<DataflowFaceSelection>(); } set { this["FaceSelection"] = value; } }
        public DataflowVertexSelection VertexSelection { get { return this[nameof(VertexSelection)].As<DataflowVertexSelection>(); } set { this["VertexSelection"] = value; } }
        public bool bAllElementsMustBeSelected { get { return this[nameof(bAllElementsMustBeSelected)].Flag; } set { this[nameof(bAllElementsMustBeSelected)].Flag = value; } }
    }
    public class CollectionFaceSelectionInvertDataflowNode : DataflowNode
    {
        public CollectionFaceSelectionInvertDataflowNode(nint addr) : base(addr) { }
        public DataflowFaceSelection FaceSelection { get { return this[nameof(FaceSelection)].As<DataflowFaceSelection>(); } set { this["FaceSelection"] = value; } }
    }
    public class CollectionVertexSelectionByPercentageDataflowNode : DataflowNode
    {
        public CollectionVertexSelectionByPercentageDataflowNode(nint addr) : base(addr) { }
        public DataflowVertexSelection VertexSelection { get { return this[nameof(VertexSelection)].As<DataflowVertexSelection>(); } set { this["VertexSelection"] = value; } }
        public int Percentage { get { return this[nameof(Percentage)].GetValue<int>(); } set { this[nameof(Percentage)].SetValue<int>(value); } }
        public bool bDeterministic { get { return this[nameof(bDeterministic)].Flag; } set { this[nameof(bDeterministic)].Flag = value; } }
        public float RandomSeed { get { return this[nameof(RandomSeed)].GetValue<float>(); } set { this[nameof(RandomSeed)].SetValue<float>(value); } }
    }
    public class CollectionVertexSelectionSetOperationDataflowNode : DataflowNode
    {
        public CollectionVertexSelectionSetOperationDataflowNode(nint addr) : base(addr) { }
        public ESetOperationEnum Operation { get { return (ESetOperationEnum)this[nameof(Operation)].GetValue<int>(); } set { this[nameof(Operation)].SetValue<int>((int)value); } }
        public DataflowVertexSelection VertexSelectionA { get { return this[nameof(VertexSelectionA)].As<DataflowVertexSelection>(); } set { this["VertexSelectionA"] = value; } }
        public DataflowVertexSelection VertexSelectionB { get { return this[nameof(VertexSelectionB)].As<DataflowVertexSelection>(); } set { this["VertexSelectionB"] = value; } }
        public DataflowVertexSelection VertexSelection { get { return this[nameof(VertexSelection)].As<DataflowVertexSelection>(); } set { this["VertexSelection"] = value; } }
    }
    public class TransformCollectionAttributeDataflowNode : DataflowNode
    {
        public TransformCollectionAttributeDataflowNode(nint addr) : base(addr) { }
        public ManagedArrayCollection Collection { get { return this[nameof(Collection)].As<ManagedArrayCollection>(); } set { this["Collection"] = value; } }
        public Transform TransformIn { get { return this[nameof(TransformIn)].As<Transform>(); } set { this["TransformIn"] = value; } }
        public Transform LocalTransform { get { return this[nameof(LocalTransform)].As<Transform>(); } set { this["LocalTransform"] = value; } }
        public Object GroupName { get { return this[nameof(GroupName)]; } set { this[nameof(GroupName)] = value; } }
        public Object AttributeName { get { return this[nameof(AttributeName)]; } set { this[nameof(AttributeName)] = value; } }
    }
}
