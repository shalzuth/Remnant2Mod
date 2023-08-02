using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.GeometryFrameworkSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.GeometryScriptingCoreSDK
{
    public class GeometryScriptDebug : Object
    {
        public GeometryScriptDebug(nint addr) : base(addr) { }
        public Array<GeometryScriptDebugMessage> Messages { get { return new Array<GeometryScriptDebugMessage>(this[nameof(Messages)].Address); } }
    }
    public class GeometryScriptLibrary_CollisionFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_CollisionFunctions(nint addr) : base(addr) { }
        public DynamicMesh SetStaticMeshCollisionFromMesh(DynamicMesh FromDynamicMesh, StaticMesh ToStaticMeshAsset, GeometryScriptCollisionFromMeshOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(SetStaticMeshCollisionFromMesh), FromDynamicMesh, ToStaticMeshAsset, Options, Debug); }
        public void SetStaticMeshCollisionFromComponent(StaticMesh StaticMeshAsset, PrimitiveComponent SourceComponent, GeometryScriptSetSimpleCollisionOptions Options, GeometryScriptDebug Debug) { Invoke(nameof(SetStaticMeshCollisionFromComponent), StaticMeshAsset, SourceComponent, Options, Debug); }
        public DynamicMesh SetDynamicMeshCollisionFromMesh(DynamicMesh FromDynamicMesh, DynamicMeshComponent ToDynamicMeshComponent, GeometryScriptCollisionFromMeshOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(SetDynamicMeshCollisionFromMesh), FromDynamicMesh, ToDynamicMeshComponent, Options, Debug); }
        public void ResetDynamicMeshCollision(DynamicMeshComponent Component, bool bEmitTransaction, GeometryScriptDebug Debug) { Invoke(nameof(ResetDynamicMeshCollision), Component, bEmitTransaction, Debug); }
    }
    public class GeometryScriptLibrary_ContainmentFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_ContainmentFunctions(nint addr) : base(addr) { }
        public DynamicMesh ComputeMeshSweptHull(DynamicMesh TargetMesh, DynamicMesh CopyToMesh, DynamicMesh CopyToMeshOut, Transform ProjectionFrame, GeometryScriptSweptHullOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ComputeMeshSweptHull), TargetMesh, CopyToMesh, CopyToMeshOut, ProjectionFrame, Options, Debug); }
        public DynamicMesh ComputeMeshConvexHull(DynamicMesh TargetMesh, DynamicMesh CopyToMesh, DynamicMesh CopyToMeshOut, GeometryScriptMeshSelection Selection, GeometryScriptConvexHullOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ComputeMeshConvexHull), TargetMesh, CopyToMesh, CopyToMeshOut, Selection, Options, Debug); }
        public DynamicMesh ComputeMeshConvexDecomposition(DynamicMesh TargetMesh, DynamicMesh CopyToMesh, DynamicMesh CopyToMeshOut, GeometryScriptConvexDecompositionOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ComputeMeshConvexDecomposition), TargetMesh, CopyToMesh, CopyToMeshOut, Options, Debug); }
    }
    public class GeometryScriptLibrary_ListUtilityFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_ListUtilityFunctions(nint addr) : base(addr) { }
        public void SetVectorListItem(GeometryScriptVectorList VectorList, int Index, Vector NewValue, bool bIsValidIndex) { Invoke(nameof(SetVectorListItem), VectorList, Index, NewValue, bIsValidIndex); }
        public void SetUVListItem(GeometryScriptUVList UVList, int Index, Vector2D NewUV, bool bIsValidIndex) { Invoke(nameof(SetUVListItem), UVList, Index, NewUV, bIsValidIndex); }
        public void SetScalarListItem(GeometryScriptScalarList ScalarList, int Index, double NewValue, bool bIsValidIndex) { Invoke(nameof(SetScalarListItem), ScalarList, Index, NewValue, bIsValidIndex); }
        public void SetIndexListItem(GeometryScriptIndexList IndexList, int Index, int NewValue, bool bIsValidIndex) { Invoke(nameof(SetIndexListItem), IndexList, Index, NewValue, bIsValidIndex); }
        public void SetColorListItem(GeometryScriptColorList ColorList, int Index, LinearColor NewColor, bool bIsValidIndex) { Invoke(nameof(SetColorListItem), ColorList, Index, NewColor, bIsValidIndex); }
        public int GetVectorListLength(GeometryScriptVectorList VectorList) { return Invoke<int>(nameof(GetVectorListLength), VectorList); }
        public int GetVectorListLastIndex(GeometryScriptVectorList VectorList) { return Invoke<int>(nameof(GetVectorListLastIndex), VectorList); }
        public Vector GetVectorListItem(GeometryScriptVectorList VectorList, int Index, bool bIsValidIndex) { return Invoke<Vector>(nameof(GetVectorListItem), VectorList, Index, bIsValidIndex); }
        public int GetUVListLength(GeometryScriptUVList UVList) { return Invoke<int>(nameof(GetUVListLength), UVList); }
        public int GetUVListLastIndex(GeometryScriptUVList UVList) { return Invoke<int>(nameof(GetUVListLastIndex), UVList); }
        public Vector2D GetUVListItem(GeometryScriptUVList UVList, int Index, bool bIsValidIndex) { return Invoke<Vector2D>(nameof(GetUVListItem), UVList, Index, bIsValidIndex); }
        public int GetTriangleListLength(GeometryScriptTriangleList TriangleList) { return Invoke<int>(nameof(GetTriangleListLength), TriangleList); }
        public int GetTriangleListLastTriangle(GeometryScriptTriangleList TriangleList) { return Invoke<int>(nameof(GetTriangleListLastTriangle), TriangleList); }
        public IntVector GetTriangleListItem(GeometryScriptTriangleList TriangleList, int Triangle, bool bIsValidTriangle) { return Invoke<IntVector>(nameof(GetTriangleListItem), TriangleList, Triangle, bIsValidTriangle); }
        public int GetScalarListLength(GeometryScriptScalarList ScalarList) { return Invoke<int>(nameof(GetScalarListLength), ScalarList); }
        public int GetScalarListLastIndex(GeometryScriptScalarList ScalarList) { return Invoke<int>(nameof(GetScalarListLastIndex), ScalarList); }
        public double GetScalarListItem(GeometryScriptScalarList ScalarList, int Index, bool bIsValidIndex) { return Invoke<double>(nameof(GetScalarListItem), ScalarList, Index, bIsValidIndex); }
        public int GetIndexListLength(GeometryScriptIndexList IndexList) { return Invoke<int>(nameof(GetIndexListLength), IndexList); }
        public int GetIndexListLastIndex(GeometryScriptIndexList IndexList) { return Invoke<int>(nameof(GetIndexListLastIndex), IndexList); }
        public int GetIndexListItem(GeometryScriptIndexList IndexList, int Index, bool bIsValidIndex) { return Invoke<int>(nameof(GetIndexListItem), IndexList, Index, bIsValidIndex); }
        public int GetColorListLength(GeometryScriptColorList ColorList) { return Invoke<int>(nameof(GetColorListLength), ColorList); }
        public int GetColorListLastIndex(GeometryScriptColorList ColorList) { return Invoke<int>(nameof(GetColorListLastIndex), ColorList); }
        public LinearColor GetColorListItem(GeometryScriptColorList ColorList, int Index, bool bIsValidIndex) { return Invoke<LinearColor>(nameof(GetColorListItem), ColorList, Index, bIsValidIndex); }
        public void ExtractColorListChannels(GeometryScriptColorList ColorList, GeometryScriptVectorList VectorList, int XChannelIndex, int YChannelIndex, int ZChannelIndex) { Invoke(nameof(ExtractColorListChannels), ColorList, VectorList, XChannelIndex, YChannelIndex, ZChannelIndex); }
        public void ExtractColorListChannel(GeometryScriptColorList ColorList, GeometryScriptScalarList ScalarList, int ChannelIndex) { Invoke(nameof(ExtractColorListChannel), ColorList, ScalarList, ChannelIndex); }
        public void DuplicateVectorList(GeometryScriptVectorList VectorList, GeometryScriptVectorList DuplicateList) { Invoke(nameof(DuplicateVectorList), VectorList, DuplicateList); }
        public void DuplicateUVList(GeometryScriptUVList UVList, GeometryScriptUVList DuplicateList) { Invoke(nameof(DuplicateUVList), UVList, DuplicateList); }
        public void DuplicateScalarList(GeometryScriptScalarList ScalarList, GeometryScriptScalarList DuplicateList) { Invoke(nameof(DuplicateScalarList), ScalarList, DuplicateList); }
        public void DuplicateIndexList(GeometryScriptIndexList IndexList, GeometryScriptIndexList DuplicateList) { Invoke(nameof(DuplicateIndexList), IndexList, DuplicateList); }
        public void DuplicateColorList(GeometryScriptColorList ColorList, GeometryScriptColorList DuplicateList) { Invoke(nameof(DuplicateColorList), ColorList, DuplicateList); }
        public void ConvertVectorListToArray(GeometryScriptVectorList VectorList, Array<Vector> VectorArray) { Invoke(nameof(ConvertVectorListToArray), VectorList, VectorArray); }
        public void ConvertUVListToArray(GeometryScriptUVList UVList, Array<Vector2D> UVArray) { Invoke(nameof(ConvertUVListToArray), UVList, UVArray); }
        public void ConvertTriangleListToArray(GeometryScriptTriangleList TriangleList, Array<IntVector> TriangleArray) { Invoke(nameof(ConvertTriangleListToArray), TriangleList, TriangleArray); }
        public void ConvertScalarListToArray(GeometryScriptScalarList ScalarList, Array<double> ScalarArray) { Invoke(nameof(ConvertScalarListToArray), ScalarList, ScalarArray); }
        public void ConvertIndexListToArray(GeometryScriptIndexList IndexList, Array<int> IndexArray) { Invoke(nameof(ConvertIndexListToArray), IndexList, IndexArray); }
        public void ConvertColorListToArray(GeometryScriptColorList ColorList, Array<LinearColor> ColorArray) { Invoke(nameof(ConvertColorListToArray), ColorList, ColorArray); }
        public void ConvertArrayToVectorList(Array<Vector> VectorArray, GeometryScriptVectorList VectorList) { Invoke(nameof(ConvertArrayToVectorList), VectorArray, VectorList); }
        public void ConvertArrayToUVList(Array<Vector2D> UVArray, GeometryScriptUVList UVList) { Invoke(nameof(ConvertArrayToUVList), UVArray, UVList); }
        public void ConvertArrayToTriangleList(Array<IntVector> TriangleArray, GeometryScriptTriangleList TriangleList) { Invoke(nameof(ConvertArrayToTriangleList), TriangleArray, TriangleList); }
        public void ConvertArrayToScalarList(Array<double> VectorArray, GeometryScriptScalarList ScalarList) { Invoke(nameof(ConvertArrayToScalarList), VectorArray, ScalarList); }
        public void ConvertArrayToIndexList(Array<int> IndexArray, GeometryScriptIndexList IndexList, EGeometryScriptIndexType IndexType) { Invoke(nameof(ConvertArrayToIndexList), IndexArray, IndexList, IndexType); }
        public void ConvertArrayToColorList(Array<LinearColor> ColorArray, GeometryScriptColorList ColorList) { Invoke(nameof(ConvertArrayToColorList), ColorArray, ColorList); }
        public void ClearVectorList(GeometryScriptVectorList VectorList, Vector ClearValue) { Invoke(nameof(ClearVectorList), VectorList, ClearValue); }
        public void ClearUVList(GeometryScriptUVList UVList, Vector2D ClearUV) { Invoke(nameof(ClearUVList), UVList, ClearUV); }
        public void ClearScalarList(GeometryScriptScalarList ScalarList, double ClearValue) { Invoke(nameof(ClearScalarList), ScalarList, ClearValue); }
        public void ClearIndexList(GeometryScriptIndexList IndexList, int ClearValue) { Invoke(nameof(ClearIndexList), IndexList, ClearValue); }
        public void ClearColorList(GeometryScriptColorList ColorList, LinearColor ClearColor) { Invoke(nameof(ClearColorList), ColorList, ClearColor); }
    }
    public class GeometryScriptLibrary_StaticMeshFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_StaticMeshFunctions(nint addr) : base(addr) { }
        public void GetSectionMaterialListFromStaticMesh(StaticMesh FromStaticMeshAsset, GeometryScriptMeshReadLOD RequestedLOD, Array<MaterialInterface> MaterialList, Array<int> MaterialIndex, EGeometryScriptOutcomePins Outcome, GeometryScriptDebug Debug) { Invoke(nameof(GetSectionMaterialListFromStaticMesh), FromStaticMeshAsset, RequestedLOD, MaterialList, MaterialIndex, Outcome, Debug); }
        public DynamicMesh CopyMeshToStaticMesh(DynamicMesh FromDynamicMesh, StaticMesh ToStaticMeshAsset, GeometryScriptCopyMeshToAssetOptions Options, GeometryScriptMeshWriteLOD TargetLod, EGeometryScriptOutcomePins Outcome, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(CopyMeshToStaticMesh), FromDynamicMesh, ToStaticMeshAsset, Options, TargetLod, Outcome, Debug); }
        public DynamicMesh CopyMeshToSkeletalMesh(DynamicMesh FromDynamicMesh, SkeletalMesh ToSkeletalMeshAsset, GeometryScriptCopyMeshToAssetOptions Options, GeometryScriptMeshWriteLOD TargetLod, EGeometryScriptOutcomePins Outcome, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(CopyMeshToSkeletalMesh), FromDynamicMesh, ToSkeletalMeshAsset, Options, TargetLod, Outcome, Debug); }
        public DynamicMesh CopyMeshFromStaticMesh(StaticMesh FromStaticMeshAsset, DynamicMesh ToDynamicMesh, GeometryScriptCopyMeshFromAssetOptions AssetOptions, GeometryScriptMeshReadLOD RequestedLOD, EGeometryScriptOutcomePins Outcome, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(CopyMeshFromStaticMesh), FromStaticMeshAsset, ToDynamicMesh, AssetOptions, RequestedLOD, Outcome, Debug); }
        public DynamicMesh CopyMeshFromSkeletalMesh(SkeletalMesh FromSkeletalMeshAsset, DynamicMesh ToDynamicMesh, GeometryScriptCopyMeshFromAssetOptions AssetOptions, GeometryScriptMeshReadLOD RequestedLOD, EGeometryScriptOutcomePins Outcome, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(CopyMeshFromSkeletalMesh), FromSkeletalMeshAsset, ToDynamicMesh, AssetOptions, RequestedLOD, Outcome, Debug); }
    }
    public class GeometryScriptLibrary_MeshBakeFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshBakeFunctions(nint addr) : base(addr) { }
        public GeometryScriptBakeTypeOptions MakeBakeTypeVertexColor() { return Invoke<GeometryScriptBakeTypeOptions>(nameof(MakeBakeTypeVertexColor)); }
        public GeometryScriptBakeTypeOptions MakeBakeTypeTexture(Texture2D SourceTexture, int SourceUVLayer) { return Invoke<GeometryScriptBakeTypeOptions>(nameof(MakeBakeTypeTexture), SourceTexture, SourceUVLayer); }
        public GeometryScriptBakeTypeOptions MakeBakeTypeTangentNormal() { return Invoke<GeometryScriptBakeTypeOptions>(nameof(MakeBakeTypeTangentNormal)); }
        public GeometryScriptBakeTypeOptions MakeBakeTypePosition() { return Invoke<GeometryScriptBakeTypeOptions>(nameof(MakeBakeTypePosition)); }
        public GeometryScriptBakeTypeOptions MakeBakeTypeObjectNormal() { return Invoke<GeometryScriptBakeTypeOptions>(nameof(MakeBakeTypeObjectNormal)); }
        public GeometryScriptBakeTypeOptions MakeBakeTypeMultiTexture(Array<Texture2D> MaterialIDSourceTextures, int SourceUVLayer) { return Invoke<GeometryScriptBakeTypeOptions>(nameof(MakeBakeTypeMultiTexture), MaterialIDSourceTextures, SourceUVLayer); }
        public GeometryScriptBakeTypeOptions MakeBakeTypeMaterialID() { return Invoke<GeometryScriptBakeTypeOptions>(nameof(MakeBakeTypeMaterialID)); }
        public GeometryScriptBakeTypeOptions MakeBakeTypeFaceNormal() { return Invoke<GeometryScriptBakeTypeOptions>(nameof(MakeBakeTypeFaceNormal)); }
        public GeometryScriptBakeTypeOptions MakeBakeTypeCurvature(EGeometryScriptBakeCurvatureTypeMode CurvatureType, EGeometryScriptBakeCurvatureColorMode ColorMapping, float ColorRangeMultiplier, float MinRangeMultiplier, EGeometryScriptBakeCurvatureClampMode Clamping) { return Invoke<GeometryScriptBakeTypeOptions>(nameof(MakeBakeTypeCurvature), CurvatureType, ColorMapping, ColorRangeMultiplier, MinRangeMultiplier, Clamping); }
        public GeometryScriptBakeTypeOptions MakeBakeTypeBentNormal(int OcclusionRays, float MaxDistance, float SpreadAngle) { return Invoke<GeometryScriptBakeTypeOptions>(nameof(MakeBakeTypeBentNormal), OcclusionRays, MaxDistance, SpreadAngle); }
        public GeometryScriptBakeTypeOptions MakeBakeTypeAmbientOcclusion(int OcclusionRays, float MaxDistance, float SpreadAngle, float BiasAngle) { return Invoke<GeometryScriptBakeTypeOptions>(nameof(MakeBakeTypeAmbientOcclusion), OcclusionRays, MaxDistance, SpreadAngle, BiasAngle); }
        public DynamicMesh BakeVertex(DynamicMesh TargetMesh, Transform TargetTransform, GeometryScriptBakeTargetMeshOptions TargetOptions, DynamicMesh SourceMesh, Transform SourceTransform, GeometryScriptBakeSourceMeshOptions SourceOptions, GeometryScriptBakeOutputType BakeTypes, GeometryScriptBakeVertexOptions BakeOptions, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(BakeVertex), TargetMesh, TargetTransform, TargetOptions, SourceMesh, SourceTransform, SourceOptions, BakeTypes, BakeOptions, Debug); }
        public GeometryScriptRenderCaptureTextures BakeTextureFromRenderCaptures(DynamicMesh TargetMesh, Transform TargetLocalToWorld, GeometryScriptBakeTargetMeshOptions TargetOptions, Array<Actor> SourceActors, GeometryScriptBakeRenderCaptureOptions BakeOptions, GeometryScriptDebug Debug) { return Invoke<GeometryScriptRenderCaptureTextures>(nameof(BakeTextureFromRenderCaptures), TargetMesh, TargetLocalToWorld, TargetOptions, SourceActors, BakeOptions, Debug); }
        public Array<Texture2D> BakeTexture(DynamicMesh TargetMesh, Transform TargetTransform, GeometryScriptBakeTargetMeshOptions TargetOptions, DynamicMesh SourceMesh, Transform SourceTransform, GeometryScriptBakeSourceMeshOptions SourceOptions, Array<GeometryScriptBakeTypeOptions> BakeTypes, GeometryScriptBakeTextureOptions BakeOptions, GeometryScriptDebug Debug) { return Invoke<Array<Texture2D>>(nameof(BakeTexture), TargetMesh, TargetTransform, TargetOptions, SourceMesh, SourceTransform, SourceOptions, BakeTypes, BakeOptions, Debug); }
    }
    public class GeometryScriptLibrary_MeshBasicEditFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshBasicEditFunctions(nint addr) : base(addr) { }
        public DynamicMesh SetVertexPosition(DynamicMesh TargetMesh, int VertexID, Vector NewPosition, bool bIsValidVertex, bool bDeferChangeNotifications) { return Invoke<DynamicMesh>(nameof(SetVertexPosition), TargetMesh, VertexID, NewPosition, bIsValidVertex, bDeferChangeNotifications); }
        public DynamicMesh SetAllMeshVertexPositions(DynamicMesh TargetMesh, GeometryScriptVectorList PositionList, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(SetAllMeshVertexPositions), TargetMesh, PositionList, Debug); }
        public DynamicMesh DiscardMeshAttributes(DynamicMesh TargetMesh, bool bDeferChangeNotifications) { return Invoke<DynamicMesh>(nameof(DiscardMeshAttributes), TargetMesh, bDeferChangeNotifications); }
        public DynamicMesh DeleteVerticesFromMesh(DynamicMesh TargetMesh, GeometryScriptIndexList VertexList, int NumDeleted, bool bDeferChangeNotifications) { return Invoke<DynamicMesh>(nameof(DeleteVerticesFromMesh), TargetMesh, VertexList, NumDeleted, bDeferChangeNotifications); }
        public DynamicMesh DeleteVertexFromMesh(DynamicMesh TargetMesh, int VertexID, bool bWasVertexDeleted, bool bDeferChangeNotifications) { return Invoke<DynamicMesh>(nameof(DeleteVertexFromMesh), TargetMesh, VertexID, bWasVertexDeleted, bDeferChangeNotifications); }
        public DynamicMesh DeleteTrianglesFromMesh(DynamicMesh TargetMesh, GeometryScriptIndexList TriangleList, int NumDeleted, bool bDeferChangeNotifications) { return Invoke<DynamicMesh>(nameof(DeleteTrianglesFromMesh), TargetMesh, TriangleList, NumDeleted, bDeferChangeNotifications); }
        public DynamicMesh DeleteTriangleFromMesh(DynamicMesh TargetMesh, int TriangleID, bool bWasTriangleDeleted, bool bDeferChangeNotifications) { return Invoke<DynamicMesh>(nameof(DeleteTriangleFromMesh), TargetMesh, TriangleID, bWasTriangleDeleted, bDeferChangeNotifications); }
        public DynamicMesh DeleteSelectedTrianglesFromMesh(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, int NumDeleted, bool bDeferChangeNotifications) { return Invoke<DynamicMesh>(nameof(DeleteSelectedTrianglesFromMesh), TargetMesh, Selection, NumDeleted, bDeferChangeNotifications); }
        public DynamicMesh AppendMeshTransformed(DynamicMesh TargetMesh, DynamicMesh AppendMesh, Array<Transform> AppendTransforms, Transform ConstantTransform, bool bConstantTransformIsRelative, bool bDeferChangeNotifications, GeometryScriptAppendMeshOptions AppendOptions, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendMeshTransformed), TargetMesh, AppendMesh, AppendTransforms, ConstantTransform, bConstantTransformIsRelative, bDeferChangeNotifications, AppendOptions, Debug); }
        public DynamicMesh AppendMeshRepeated(DynamicMesh TargetMesh, DynamicMesh AppendMesh, Transform AppendTransform, int RepeatCount, bool bApplyTransformToFirstInstance, bool bDeferChangeNotifications, GeometryScriptAppendMeshOptions AppendOptions, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendMeshRepeated), TargetMesh, AppendMesh, AppendTransform, RepeatCount, bApplyTransformToFirstInstance, bDeferChangeNotifications, AppendOptions, Debug); }
        public DynamicMesh AppendMesh(DynamicMesh TargetMesh, DynamicMesh AppendMesh, Transform AppendTransform, bool bDeferChangeNotifications, GeometryScriptAppendMeshOptions AppendOptions, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendMesh), TargetMesh, AppendMesh, AppendTransform, bDeferChangeNotifications, AppendOptions, Debug); }
        public DynamicMesh AppendBuffersToMesh(DynamicMesh TargetMesh, GeometryScriptSimpleMeshBuffers Buffers, GeometryScriptIndexList NewTriangleIndicesList, int MaterialID, bool bDeferChangeNotifications, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendBuffersToMesh), TargetMesh, Buffers, NewTriangleIndicesList, MaterialID, bDeferChangeNotifications, Debug); }
        public DynamicMesh AddVerticesToMesh(DynamicMesh TargetMesh, GeometryScriptVectorList NewPositionsList, GeometryScriptIndexList NewIndicesList, bool bDeferChangeNotifications) { return Invoke<DynamicMesh>(nameof(AddVerticesToMesh), TargetMesh, NewPositionsList, NewIndicesList, bDeferChangeNotifications); }
        public DynamicMesh AddVertexToMesh(DynamicMesh TargetMesh, Vector NewPosition, int NewVertexIndex, bool bDeferChangeNotifications) { return Invoke<DynamicMesh>(nameof(AddVertexToMesh), TargetMesh, NewPosition, NewVertexIndex, bDeferChangeNotifications); }
        public DynamicMesh AddTriangleToMesh(DynamicMesh TargetMesh, IntVector NewTriangle, int NewTriangleIndex, int NewTriangleGroupID, bool bDeferChangeNotifications, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AddTriangleToMesh), TargetMesh, NewTriangle, NewTriangleIndex, NewTriangleGroupID, bDeferChangeNotifications, Debug); }
        public DynamicMesh AddTrianglesToMesh(DynamicMesh TargetMesh, GeometryScriptTriangleList NewTrianglesList, GeometryScriptIndexList NewIndicesList, int NewTriangleGroupID, bool bDeferChangeNotifications, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AddTrianglesToMesh), TargetMesh, NewTrianglesList, NewIndicesList, NewTriangleGroupID, bDeferChangeNotifications, Debug); }
    }
    public class GeometryScriptLibrary_MeshBoneWeightFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshBoneWeightFunctions(nint addr) : base(addr) { }
        public DynamicMesh SetVertexBoneWeights(DynamicMesh TargetMesh, int VertexID, Array<GeometryScriptBoneWeight> BoneWeights, bool bIsValidVertexID, GeometryScriptBoneWeightProfile Profile) { return Invoke<DynamicMesh>(nameof(SetVertexBoneWeights), TargetMesh, VertexID, BoneWeights, bIsValidVertexID, Profile); }
        public DynamicMesh SetAllVertexBoneWeights(DynamicMesh TargetMesh, Array<GeometryScriptBoneWeight> BoneWeights, GeometryScriptBoneWeightProfile Profile) { return Invoke<DynamicMesh>(nameof(SetAllVertexBoneWeights), TargetMesh, BoneWeights, Profile); }
        public DynamicMesh MeshHasBoneWeights(DynamicMesh TargetMesh, bool bHasBoneWeights, GeometryScriptBoneWeightProfile Profile) { return Invoke<DynamicMesh>(nameof(MeshHasBoneWeights), TargetMesh, bHasBoneWeights, Profile); }
        public DynamicMesh MeshCreateBoneWeights(DynamicMesh TargetMesh, bool bProfileExisted, bool bReplaceExistingProfile, GeometryScriptBoneWeightProfile Profile) { return Invoke<DynamicMesh>(nameof(MeshCreateBoneWeights), TargetMesh, bProfileExisted, bReplaceExistingProfile, Profile); }
        public DynamicMesh GetVertexBoneWeights(DynamicMesh TargetMesh, int VertexID, Array<GeometryScriptBoneWeight> BoneWeights, bool bHasValidBoneWeights, GeometryScriptBoneWeightProfile Profile) { return Invoke<DynamicMesh>(nameof(GetVertexBoneWeights), TargetMesh, VertexID, BoneWeights, bHasValidBoneWeights, Profile); }
        public DynamicMesh GetMaxBoneWeightIndex(DynamicMesh TargetMesh, bool bHasBoneWeights, int MaxBoneIndex, GeometryScriptBoneWeightProfile Profile) { return Invoke<DynamicMesh>(nameof(GetMaxBoneWeightIndex), TargetMesh, bHasBoneWeights, MaxBoneIndex, Profile); }
        public DynamicMesh GetLargestVertexBoneWeight(DynamicMesh TargetMesh, int VertexID, GeometryScriptBoneWeight BoneWeight, bool bHasValidBoneWeights, GeometryScriptBoneWeightProfile Profile) { return Invoke<DynamicMesh>(nameof(GetLargestVertexBoneWeight), TargetMesh, VertexID, BoneWeight, bHasValidBoneWeights, Profile); }
        public DynamicMesh ComputeSmoothBoneWeights(DynamicMesh TargetMesh, Skeleton Skeleton, GeometryScriptSmoothBoneWeightsOptions Options, GeometryScriptBoneWeightProfile Profile, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ComputeSmoothBoneWeights), TargetMesh, Skeleton, Options, Profile, Debug); }
    }
    public class GeometryScriptLibrary_MeshBooleanFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshBooleanFunctions(nint addr) : base(addr) { }
        public DynamicMesh ApplyMeshSelfUnion(DynamicMesh TargetMesh, GeometryScriptMeshSelfUnionOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyMeshSelfUnion), TargetMesh, Options, Debug); }
        public DynamicMesh ApplyMeshPlaneSlice(DynamicMesh TargetMesh, Transform CutFrame, GeometryScriptMeshPlaneSliceOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyMeshPlaneSlice), TargetMesh, CutFrame, Options, Debug); }
        public DynamicMesh ApplyMeshPlaneCut(DynamicMesh TargetMesh, Transform CutFrame, GeometryScriptMeshPlaneCutOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyMeshPlaneCut), TargetMesh, CutFrame, Options, Debug); }
        public DynamicMesh ApplyMeshMirror(DynamicMesh TargetMesh, Transform MirrorFrame, GeometryScriptMeshMirrorOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyMeshMirror), TargetMesh, MirrorFrame, Options, Debug); }
        public DynamicMesh ApplyMeshBoolean(DynamicMesh TargetMesh, Transform TargetTransform, DynamicMesh ToolMesh, Transform ToolTransform, EGeometryScriptBooleanOperation Operation, GeometryScriptMeshBooleanOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyMeshBoolean), TargetMesh, TargetTransform, ToolMesh, ToolTransform, Operation, Options, Debug); }
    }
    public class GeometryScriptLibrary_MeshComparisonFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshComparisonFunctions(nint addr) : base(addr) { }
        public DynamicMesh MeasureDistancesBetweenMeshes(DynamicMesh TargetMesh, DynamicMesh OtherMesh, GeometryScriptMeasureMeshDistanceOptions Options, double MaxDistance, double MinDistance, double AverageDistance, double RootMeanSqrDeviation, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(MeasureDistancesBetweenMeshes), TargetMesh, OtherMesh, Options, MaxDistance, MinDistance, AverageDistance, RootMeanSqrDeviation, Debug); }
        public DynamicMesh IsSameMeshAs(DynamicMesh TargetMesh, DynamicMesh OtherMesh, GeometryScriptIsSameMeshOptions Options, bool bIsSameMesh, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(IsSameMeshAs), TargetMesh, OtherMesh, Options, bIsSameMesh, Debug); }
        public DynamicMesh IsIntersectingMesh(DynamicMesh TargetMesh, Transform TargetTransform, DynamicMesh OtherMesh, Transform OtherTransform, bool bIsIntersecting, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(IsIntersectingMesh), TargetMesh, TargetTransform, OtherMesh, OtherTransform, bIsIntersecting, Debug); }
    }
    public class GeometryScriptLibrary_MeshDecompositionFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshDecompositionFunctions(nint addr) : base(addr) { }
        public DynamicMesh SplitMeshByPolygroups(DynamicMesh TargetMesh, GeometryScriptGroupLayer GroupLayer, Array<DynamicMesh> ComponentMeshes, Array<int> ComponentPolygroups, DynamicMeshPool MeshPool, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(SplitMeshByPolygroups), TargetMesh, GroupLayer, ComponentMeshes, ComponentPolygroups, MeshPool, Debug); }
        public DynamicMesh SplitMeshByMaterialIDs(DynamicMesh TargetMesh, Array<DynamicMesh> ComponentMeshes, Array<int> ComponentMaterialIDs, DynamicMeshPool MeshPool, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(SplitMeshByMaterialIDs), TargetMesh, ComponentMeshes, ComponentMaterialIDs, MeshPool, Debug); }
        public DynamicMesh SplitMeshByComponents(DynamicMesh TargetMesh, Array<DynamicMesh> ComponentMeshes, DynamicMeshPool MeshPool, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(SplitMeshByComponents), TargetMesh, ComponentMeshes, MeshPool, Debug); }
        public DynamicMesh GetSubMeshFromMesh(DynamicMesh TargetMesh, DynamicMesh StoreToSubmesh, GeometryScriptIndexList TriangleList, DynamicMesh StoreToSubmeshOut, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(GetSubMeshFromMesh), TargetMesh, StoreToSubmesh, TriangleList, StoreToSubmeshOut, Debug); }
        public DynamicMesh CopyMeshToMesh(DynamicMesh CopyFromMesh, DynamicMesh CopyToMesh, DynamicMesh CopyToMeshOut, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(CopyMeshToMesh), CopyFromMesh, CopyToMesh, CopyToMeshOut, Debug); }
        public DynamicMesh CopyMeshSelectionToMesh(DynamicMesh TargetMesh, DynamicMesh StoreToSubmesh, GeometryScriptMeshSelection Selection, DynamicMesh StoreToSubmeshOut, bool bAppendToExisting, bool bPreserveGroupIDs, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(CopyMeshSelectionToMesh), TargetMesh, StoreToSubmesh, Selection, StoreToSubmeshOut, bAppendToExisting, bPreserveGroupIDs, Debug); }
    }
    public class GeometryScriptLibrary_MeshDeformFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshDeformFunctions(nint addr) : base(addr) { }
        public DynamicMesh ApplyTwistWarpToMesh(DynamicMesh TargetMesh, GeometryScriptTwistWarpOptions Options, Transform TwistOrientation, float TwistAngle, float TwistExtent, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyTwistWarpToMesh), TargetMesh, Options, TwistOrientation, TwistAngle, TwistExtent, Debug); }
        public DynamicMesh ApplyPerlinNoiseToMesh(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, GeometryScriptPerlinNoiseOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyPerlinNoiseToMesh), TargetMesh, Selection, Options, Debug); }
        public DynamicMesh ApplyMathWarpToMesh(DynamicMesh TargetMesh, Transform WarpOrientation, EGeometryScriptMathWarpType WarpType, GeometryScriptMathWarpOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyMathWarpToMesh), TargetMesh, WarpOrientation, WarpType, Options, Debug); }
        public DynamicMesh ApplyIterativeSmoothingToMesh(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, GeometryScriptIterativeMeshSmoothingOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyIterativeSmoothingToMesh), TargetMesh, Selection, Options, Debug); }
        public DynamicMesh ApplyFlareWarpToMesh(DynamicMesh TargetMesh, GeometryScriptFlareWarpOptions Options, Transform FlareOrientation, float FlarePercentX, float FlarePercentY, float FlareExtent, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyFlareWarpToMesh), TargetMesh, Options, FlareOrientation, FlarePercentX, FlarePercentY, FlareExtent, Debug); }
        public DynamicMesh ApplyDisplaceFromTextureMap(DynamicMesh TargetMesh, Texture2D Texture, GeometryScriptMeshSelection Selection, GeometryScriptDisplaceFromTextureOptions Options, int UVLayer, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyDisplaceFromTextureMap), TargetMesh, Texture, Selection, Options, UVLayer, Debug); }
        public DynamicMesh ApplyDisplaceFromPerVertexVectors(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, GeometryScriptVectorList VectorList, float Magnitude, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyDisplaceFromPerVertexVectors), TargetMesh, Selection, VectorList, Magnitude, Debug); }
        public DynamicMesh ApplyBendWarpToMesh(DynamicMesh TargetMesh, GeometryScriptBendWarpOptions Options, Transform BendOrientation, float BendAngle, float BendExtent, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyBendWarpToMesh), TargetMesh, Options, BendOrientation, BendAngle, BendExtent, Debug); }
    }
    public class GeometryScriptLibrary_MeshMaterialFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshMaterialFunctions(nint addr) : base(addr) { }
        public DynamicMesh SetTriangleMaterialID(DynamicMesh TargetMesh, int TriangleID, int MaterialID, bool bIsValidTriangle, bool bDeferChangeNotifications) { return Invoke<DynamicMesh>(nameof(SetTriangleMaterialID), TargetMesh, TriangleID, MaterialID, bIsValidTriangle, bDeferChangeNotifications); }
        public DynamicMesh SetPolygroupMaterialID(DynamicMesh TargetMesh, GeometryScriptGroupLayer GroupLayer, int PolygroupID, int MaterialID, bool bIsValidPolygroupID, bool bDeferChangeNotifications, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(SetPolygroupMaterialID), TargetMesh, GroupLayer, PolygroupID, MaterialID, bIsValidPolygroupID, bDeferChangeNotifications, Debug); }
        public DynamicMesh SetMaterialIDOnTriangles(DynamicMesh TargetMesh, GeometryScriptIndexList TriangleIDList, int MaterialID, bool bDeferChangeNotifications, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(SetMaterialIDOnTriangles), TargetMesh, TriangleIDList, MaterialID, bDeferChangeNotifications, Debug); }
        public DynamicMesh SetMaterialIDForMeshSelection(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, int MaterialID, bool bDeferChangeNotifications, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(SetMaterialIDForMeshSelection), TargetMesh, Selection, MaterialID, bDeferChangeNotifications, Debug); }
        public DynamicMesh SetAllTriangleMaterialIDs(DynamicMesh TargetMesh, GeometryScriptIndexList TriangleMaterialIDList, bool bDeferChangeNotifications, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(SetAllTriangleMaterialIDs), TargetMesh, TriangleMaterialIDList, bDeferChangeNotifications, Debug); }
        public DynamicMesh RemapMaterialIDs(DynamicMesh TargetMesh, int FromMaterialID, int ToMaterialID, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(RemapMaterialIDs), TargetMesh, FromMaterialID, ToMaterialID, Debug); }
        public DynamicMesh GetTrianglesByMaterialID(DynamicMesh TargetMesh, int MaterialID, GeometryScriptIndexList TriangleIDList, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(GetTrianglesByMaterialID), TargetMesh, MaterialID, TriangleIDList, Debug); }
        public int GetTriangleMaterialID(DynamicMesh TargetMesh, int TriangleID, bool bIsValidTriangle) { return Invoke<int>(nameof(GetTriangleMaterialID), TargetMesh, TriangleID, bIsValidTriangle); }
        public int GetMaxMaterialID(DynamicMesh TargetMesh, bool bHasMaterialIDs) { return Invoke<int>(nameof(GetMaxMaterialID), TargetMesh, bHasMaterialIDs); }
        public DynamicMesh GetMaterialIDsOfTriangles(DynamicMesh TargetMesh, GeometryScriptIndexList TriangleIDList, GeometryScriptIndexList MaterialIDList, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(GetMaterialIDsOfTriangles), TargetMesh, TriangleIDList, MaterialIDList, Debug); }
        public DynamicMesh GetAllTriangleMaterialIDs(DynamicMesh TargetMesh, GeometryScriptIndexList MaterialIDList, bool bHasMaterialIDs) { return Invoke<DynamicMesh>(nameof(GetAllTriangleMaterialIDs), TargetMesh, MaterialIDList, bHasMaterialIDs); }
        public DynamicMesh EnableMaterialIDs(DynamicMesh TargetMesh, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(EnableMaterialIDs), TargetMesh, Debug); }
        public DynamicMesh DeleteTrianglesByMaterialID(DynamicMesh TargetMesh, int MaterialID, int NumDeleted, bool bDeferChangeNotifications, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(DeleteTrianglesByMaterialID), TargetMesh, MaterialID, NumDeleted, bDeferChangeNotifications, Debug); }
        public DynamicMesh CompactMaterialIDs(DynamicMesh TargetMesh, Array<MaterialInterface> SourceMaterialList, Array<MaterialInterface> CompactedMaterialList, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(CompactMaterialIDs), TargetMesh, SourceMaterialList, CompactedMaterialList, Debug); }
        public DynamicMesh ClearMaterialIDs(DynamicMesh TargetMesh, int ClearValue, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ClearMaterialIDs), TargetMesh, ClearValue, Debug); }
    }
    public class GeometryScriptLibrary_MeshModelingFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshModelingFunctions(nint addr) : base(addr) { }
        public DynamicMesh ApplyMeshShell(DynamicMesh TargetMesh, GeometryScriptMeshOffsetOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyMeshShell), TargetMesh, Options, Debug); }
        public DynamicMesh ApplyMeshPolygroupBevel(DynamicMesh TargetMesh, GeometryScriptMeshBevelOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyMeshPolygroupBevel), TargetMesh, Options, Debug); }
        public DynamicMesh ApplyMeshOffsetFaces(DynamicMesh TargetMesh, GeometryScriptMeshOffsetFacesOptions Options, GeometryScriptMeshSelection Selection, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyMeshOffsetFaces), TargetMesh, Options, Selection, Debug); }
        public DynamicMesh ApplyMeshOffset(DynamicMesh TargetMesh, GeometryScriptMeshOffsetOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyMeshOffset), TargetMesh, Options, Debug); }
        public DynamicMesh ApplyMeshLinearExtrudeFaces(DynamicMesh TargetMesh, GeometryScriptMeshLinearExtrudeOptions Options, GeometryScriptMeshSelection Selection, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyMeshLinearExtrudeFaces), TargetMesh, Options, Selection, Debug); }
        public DynamicMesh ApplyMeshInsetOutsetFaces(DynamicMesh TargetMesh, GeometryScriptMeshInsetOutsetFacesOptions Options, GeometryScriptMeshSelection Selection, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyMeshInsetOutsetFaces), TargetMesh, Options, Selection, Debug); }
        public DynamicMesh ApplyMeshExtrude_Compatibility_5p0(DynamicMesh TargetMesh, GeometryScriptMeshExtrudeOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyMeshExtrude_Compatibility_5p0), TargetMesh, Options, Debug); }
        public DynamicMesh ApplyMeshDuplicateFaces(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, GeometryScriptMeshSelection NewTriangles, GeometryScriptMeshEditPolygroupOptions GroupOptions, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyMeshDuplicateFaces), TargetMesh, Selection, NewTriangles, GroupOptions, Debug); }
        public DynamicMesh ApplyMeshDisconnectFaces(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, bool bAllowBowtiesInOutput, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyMeshDisconnectFaces), TargetMesh, Selection, bAllowBowtiesInOutput, Debug); }
        public DynamicMesh ApplyMeshBevelSelection(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, EGeometryScriptMeshBevelSelectionMode BevelMode, GeometryScriptMeshBevelSelectionOptions BevelOptions, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyMeshBevelSelection), TargetMesh, Selection, BevelMode, BevelOptions, Debug); }
    }
    public class GeometryScriptLibrary_MeshNormalsFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshNormalsFunctions(nint addr) : base(addr) { }
        public DynamicMesh UpdateVertexNormal(DynamicMesh TargetMesh, int VertexID, bool bUpdateNormal, Vector NewNormal, bool bUpdateTangents, Vector NewTangentX, Vector NewTangentY, bool bIsValidVertex, bool bMergeSplitValues, bool bDeferChangeNotifications) { return Invoke<DynamicMesh>(nameof(UpdateVertexNormal), TargetMesh, VertexID, bUpdateNormal, NewNormal, bUpdateTangents, NewTangentX, NewTangentY, bIsValidVertex, bMergeSplitValues, bDeferChangeNotifications); }
        public DynamicMesh SetPerVertexNormals(DynamicMesh TargetMesh, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(SetPerVertexNormals), TargetMesh, Debug); }
        public DynamicMesh SetPerFaceNormals(DynamicMesh TargetMesh, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(SetPerFaceNormals), TargetMesh, Debug); }
        public DynamicMesh SetMeshTriangleNormals(DynamicMesh TargetMesh, int TriangleID, GeometryScriptTriangle Normals, bool bIsValidTriangle, bool bDeferChangeNotifications) { return Invoke<DynamicMesh>(nameof(SetMeshTriangleNormals), TargetMesh, TriangleID, Normals, bIsValidTriangle, bDeferChangeNotifications); }
        public DynamicMesh SetMeshPerVertexTangents(DynamicMesh TargetMesh, GeometryScriptVectorList TangentXList, GeometryScriptVectorList TangentYList, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(SetMeshPerVertexTangents), TargetMesh, TangentXList, TangentYList, Debug); }
        public DynamicMesh SetMeshPerVertexNormals(DynamicMesh TargetMesh, GeometryScriptVectorList VertexNormalList, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(SetMeshPerVertexNormals), TargetMesh, VertexNormalList, Debug); }
        public DynamicMesh RecomputeNormals(DynamicMesh TargetMesh, GeometryScriptCalculateNormalsOptions CalculateOptions, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(RecomputeNormals), TargetMesh, CalculateOptions, Debug); }
        public DynamicMesh GetMeshPerVertexTangents(DynamicMesh TargetMesh, GeometryScriptVectorList TangentXList, GeometryScriptVectorList TangentYList, bool bIsValidTangentSet, bool bHasVertexIDGaps, bool bAverageSplitVertexValues) { return Invoke<DynamicMesh>(nameof(GetMeshPerVertexTangents), TargetMesh, TangentXList, TangentYList, bIsValidTangentSet, bHasVertexIDGaps, bAverageSplitVertexValues); }
        public DynamicMesh GetMeshPerVertexNormals(DynamicMesh TargetMesh, GeometryScriptVectorList NormalList, bool bIsValidNormalSet, bool bHasVertexIDGaps, bool bAverageSplitVertexValues) { return Invoke<DynamicMesh>(nameof(GetMeshPerVertexNormals), TargetMesh, NormalList, bIsValidNormalSet, bHasVertexIDGaps, bAverageSplitVertexValues); }
        public DynamicMesh GetMeshHasTangents(DynamicMesh TargetMesh, bool bHasTangents, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(GetMeshHasTangents), TargetMesh, bHasTangents, Debug); }
        public DynamicMesh FlipNormals(DynamicMesh TargetMesh, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(FlipNormals), TargetMesh, Debug); }
        public DynamicMesh DiscardTangents(DynamicMesh TargetMesh, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(DiscardTangents), TargetMesh, Debug); }
        public DynamicMesh ComputeTangents(DynamicMesh TargetMesh, GeometryScriptTangentsOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ComputeTangents), TargetMesh, Options, Debug); }
        public DynamicMesh ComputeSplitNormals(DynamicMesh TargetMesh, GeometryScriptSplitNormalsOptions SplitOptions, GeometryScriptCalculateNormalsOptions CalculateOptions, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ComputeSplitNormals), TargetMesh, SplitOptions, CalculateOptions, Debug); }
        public DynamicMesh AutoRepairNormals(DynamicMesh TargetMesh, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AutoRepairNormals), TargetMesh, Debug); }
    }
    public class GeometryScriptLibrary_MeshPolygroupFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshPolygroupFunctions(nint addr) : base(addr) { }
        public DynamicMesh SetPolygroupForMeshSelection(DynamicMesh TargetMesh, GeometryScriptGroupLayer GroupLayer, GeometryScriptMeshSelection Selection, int SetPolygroupIDOut, int SetPolygroupID, bool bGenerateNewPolygroup, bool bDeferChangeNotifications) { return Invoke<DynamicMesh>(nameof(SetPolygroupForMeshSelection), TargetMesh, GroupLayer, Selection, SetPolygroupIDOut, SetPolygroupID, bGenerateNewPolygroup, bDeferChangeNotifications); }
        public DynamicMesh SetNumExtendedPolygroupLayers(DynamicMesh TargetMesh, int NumLayers, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(SetNumExtendedPolygroupLayers), TargetMesh, NumLayers, Debug); }
        public DynamicMesh GetTrianglesInPolygroup(DynamicMesh TargetMesh, GeometryScriptGroupLayer GroupLayer, int PolygroupID, GeometryScriptIndexList TriangleIDsOut) { return Invoke<DynamicMesh>(nameof(GetTrianglesInPolygroup), TargetMesh, GroupLayer, PolygroupID, TriangleIDsOut); }
        public int GetTrianglePolygroupID(DynamicMesh TargetMesh, GeometryScriptGroupLayer GroupLayer, int TriangleID, bool bIsValidTriangle) { return Invoke<int>(nameof(GetTrianglePolygroupID), TargetMesh, GroupLayer, TriangleID, bIsValidTriangle); }
        public DynamicMesh GetPolygroupIDsInMesh(DynamicMesh TargetMesh, GeometryScriptGroupLayer GroupLayer, GeometryScriptIndexList PolygroupIDsOut) { return Invoke<DynamicMesh>(nameof(GetPolygroupIDsInMesh), TargetMesh, GroupLayer, PolygroupIDsOut); }
        public DynamicMesh GetAllTrianglePolygroupIDs(DynamicMesh TargetMesh, GeometryScriptGroupLayer GroupLayer, GeometryScriptIndexList PolygroupIDsOut) { return Invoke<DynamicMesh>(nameof(GetAllTrianglePolygroupIDs), TargetMesh, GroupLayer, PolygroupIDsOut); }
        public DynamicMesh EnablePolygroups(DynamicMesh TargetMesh, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(EnablePolygroups), TargetMesh, Debug); }
        public DynamicMesh DeleteTrianglesInPolygroup(DynamicMesh TargetMesh, GeometryScriptGroupLayer GroupLayer, int PolygroupID, int NumDeleted, bool bDeferChangeNotifications, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(DeleteTrianglesInPolygroup), TargetMesh, GroupLayer, PolygroupID, NumDeleted, bDeferChangeNotifications, Debug); }
        public DynamicMesh CopyPolygroupsLayer(DynamicMesh TargetMesh, GeometryScriptGroupLayer FromGroupLayer, GeometryScriptGroupLayer ToGroupLayer, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(CopyPolygroupsLayer), TargetMesh, FromGroupLayer, ToGroupLayer, Debug); }
        public DynamicMesh ConvertUVIslandsToPolygroups(DynamicMesh TargetMesh, GeometryScriptGroupLayer GroupLayer, int UVLayer, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ConvertUVIslandsToPolygroups), TargetMesh, GroupLayer, UVLayer, Debug); }
        public DynamicMesh ConvertComponentsToPolygroups(DynamicMesh TargetMesh, GeometryScriptGroupLayer GroupLayer, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ConvertComponentsToPolygroups), TargetMesh, GroupLayer, Debug); }
        public DynamicMesh ComputePolygroupsFromPolygonDetection(DynamicMesh TargetMesh, GeometryScriptGroupLayer GroupLayer, bool bRespectUVSeams, bool bRespectHardNormals, double QuadAdjacencyWeight, double QuadMetricClamp, int MaxSearchRounds, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ComputePolygroupsFromPolygonDetection), TargetMesh, GroupLayer, bRespectUVSeams, bRespectHardNormals, QuadAdjacencyWeight, QuadMetricClamp, MaxSearchRounds, Debug); }
        public DynamicMesh ComputePolygroupsFromAngleThreshold(DynamicMesh TargetMesh, GeometryScriptGroupLayer GroupLayer, float CreaseAngle, int MinGroupSize, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ComputePolygroupsFromAngleThreshold), TargetMesh, GroupLayer, CreaseAngle, MinGroupSize, Debug); }
        public DynamicMesh ClearPolygroups(DynamicMesh TargetMesh, GeometryScriptGroupLayer GroupLayer, int ClearValue, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ClearPolygroups), TargetMesh, GroupLayer, ClearValue, Debug); }
    }
    public class GeometryScriptLibrary_MeshPrimitiveFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshPrimitiveFunctions(nint addr) : base(addr) { }
        public DynamicMesh AppendVoronoiDiagram2D(DynamicMesh TargetMesh, GeometryScriptPrimitiveOptions PrimitiveOptions, Transform Transform, Array<Vector2D> VoronoiSites, GeometryScriptVoronoiOptions VoronoiOptions, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendVoronoiDiagram2D), TargetMesh, PrimitiveOptions, Transform, VoronoiSites, VoronoiOptions, Debug); }
        public DynamicMesh AppendTriangulatedPolygon(DynamicMesh TargetMesh, GeometryScriptPrimitiveOptions PrimitiveOptions, Transform Transform, Array<Vector2D> PolygonVertices, bool bAllowSelfIntersections, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendTriangulatedPolygon), TargetMesh, PrimitiveOptions, Transform, PolygonVertices, bAllowSelfIntersections, Debug); }
        public DynamicMesh AppendTorus(DynamicMesh TargetMesh, GeometryScriptPrimitiveOptions PrimitiveOptions, Transform Transform, GeometryScriptRevolveOptions RevolveOptions, float MajorRadius, float MinorRadius, int MajorSteps, int MinorSteps, EGeometryScriptPrimitiveOriginMode Origin, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendTorus), TargetMesh, PrimitiveOptions, Transform, RevolveOptions, MajorRadius, MinorRadius, MajorSteps, MinorSteps, Origin, Debug); }
        public DynamicMesh AppendSweepPolyline(DynamicMesh TargetMesh, GeometryScriptPrimitiveOptions PrimitiveOptions, Transform Transform, Array<Vector2D> PolylineVertices, Array<Transform> SweepPath, Array<float> PolylineTexParamU, Array<float> SweepPathTexParamV, bool bLoop, float StartScale, float EndScale, float RotationAngleDeg, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendSweepPolyline), TargetMesh, PrimitiveOptions, Transform, PolylineVertices, SweepPath, PolylineTexParamU, SweepPathTexParamV, bLoop, StartScale, EndScale, RotationAngleDeg, Debug); }
        public DynamicMesh AppendSweepPolygon(DynamicMesh TargetMesh, GeometryScriptPrimitiveOptions PrimitiveOptions, Transform Transform, Array<Vector2D> PolygonVertices, Array<Transform> SweepPath, bool bLoop, bool bCapped, float StartScale, float EndScale, float RotationAngleDeg, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendSweepPolygon), TargetMesh, PrimitiveOptions, Transform, PolygonVertices, SweepPath, bLoop, bCapped, StartScale, EndScale, RotationAngleDeg, Debug); }
        public DynamicMesh AppendSpiralRevolvePolygon(DynamicMesh TargetMesh, GeometryScriptPrimitiveOptions PrimitiveOptions, Transform Transform, Array<Vector2D> PolygonVertices, GeometryScriptRevolveOptions RevolveOptions, float Radius, int Steps, float RisePerRevolution, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendSpiralRevolvePolygon), TargetMesh, PrimitiveOptions, Transform, PolygonVertices, RevolveOptions, Radius, Steps, RisePerRevolution, Debug); }
        public DynamicMesh AppendSphereLatLong(DynamicMesh TargetMesh, GeometryScriptPrimitiveOptions PrimitiveOptions, Transform Transform, float Radius, int StepsPhi, int StepsTheta, EGeometryScriptPrimitiveOriginMode Origin, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendSphereLatLong), TargetMesh, PrimitiveOptions, Transform, Radius, StepsPhi, StepsTheta, Origin, Debug); }
        public DynamicMesh AppendSphereBox(DynamicMesh TargetMesh, GeometryScriptPrimitiveOptions PrimitiveOptions, Transform Transform, float Radius, int StepsX, int StepsY, int StepsZ, EGeometryScriptPrimitiveOriginMode Origin, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendSphereBox), TargetMesh, PrimitiveOptions, Transform, Radius, StepsX, StepsY, StepsZ, Origin, Debug); }
        public DynamicMesh AppendSimpleSweptPolygon(DynamicMesh TargetMesh, GeometryScriptPrimitiveOptions PrimitiveOptions, Transform Transform, Array<Vector2D> PolygonVertices, Array<Vector> SweepPath, bool bLoop, bool bCapped, float StartScale, float EndScale, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendSimpleSweptPolygon), TargetMesh, PrimitiveOptions, Transform, PolygonVertices, SweepPath, bLoop, bCapped, StartScale, EndScale, Debug); }
        public DynamicMesh AppendSimpleExtrudePolygon(DynamicMesh TargetMesh, GeometryScriptPrimitiveOptions PrimitiveOptions, Transform Transform, Array<Vector2D> PolygonVertices, float Height, int HeightSteps, bool bCapped, EGeometryScriptPrimitiveOriginMode Origin, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendSimpleExtrudePolygon), TargetMesh, PrimitiveOptions, Transform, PolygonVertices, Height, HeightSteps, bCapped, Origin, Debug); }
        public DynamicMesh AppendRoundRectangleXY(DynamicMesh TargetMesh, GeometryScriptPrimitiveOptions PrimitiveOptions, Transform Transform, float DimensionX, float DimensionY, float CornerRadius, int StepsWidth, int StepsHeight, int StepsRound, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendRoundRectangleXY), TargetMesh, PrimitiveOptions, Transform, DimensionX, DimensionY, CornerRadius, StepsWidth, StepsHeight, StepsRound, Debug); }
        public DynamicMesh AppendRoundRectangle_Compatibility_5(DynamicMesh TargetMesh, GeometryScriptPrimitiveOptions PrimitiveOptions, Transform Transform, float DimensionX, float DimensionY, float CornerRadius, int StepsWidth, int StepsHeight, int StepsRound, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendRoundRectangle_Compatibility_5), TargetMesh, PrimitiveOptions, Transform, DimensionX, DimensionY, CornerRadius, StepsWidth, StepsHeight, StepsRound, Debug); }
        public DynamicMesh AppendRevolvePolygon(DynamicMesh TargetMesh, GeometryScriptPrimitiveOptions PrimitiveOptions, Transform Transform, Array<Vector2D> PolygonVertices, GeometryScriptRevolveOptions RevolveOptions, float Radius, int Steps, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendRevolvePolygon), TargetMesh, PrimitiveOptions, Transform, PolygonVertices, RevolveOptions, Radius, Steps, Debug); }
        public DynamicMesh AppendRevolvePath(DynamicMesh TargetMesh, GeometryScriptPrimitiveOptions PrimitiveOptions, Transform Transform, Array<Vector2D> PathVertices, GeometryScriptRevolveOptions RevolveOptions, int Steps, bool bCapped, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendRevolvePath), TargetMesh, PrimitiveOptions, Transform, PathVertices, RevolveOptions, Steps, bCapped, Debug); }
        public DynamicMesh AppendRectangleXY(DynamicMesh TargetMesh, GeometryScriptPrimitiveOptions PrimitiveOptions, Transform Transform, float DimensionX, float DimensionY, int StepsWidth, int StepsHeight, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendRectangleXY), TargetMesh, PrimitiveOptions, Transform, DimensionX, DimensionY, StepsWidth, StepsHeight, Debug); }
        public DynamicMesh AppendRectangle_Compatibility_5(DynamicMesh TargetMesh, GeometryScriptPrimitiveOptions PrimitiveOptions, Transform Transform, float DimensionX, float DimensionY, int StepsWidth, int StepsHeight, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendRectangle_Compatibility_5), TargetMesh, PrimitiveOptions, Transform, DimensionX, DimensionY, StepsWidth, StepsHeight, Debug); }
        public DynamicMesh AppendLinearStairs(DynamicMesh TargetMesh, GeometryScriptPrimitiveOptions PrimitiveOptions, Transform Transform, float StepWidth, float StepHeight, float StepDepth, int NumSteps, bool bFloating, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendLinearStairs), TargetMesh, PrimitiveOptions, Transform, StepWidth, StepHeight, StepDepth, NumSteps, bFloating, Debug); }
        public DynamicMesh AppendDisc(DynamicMesh TargetMesh, GeometryScriptPrimitiveOptions PrimitiveOptions, Transform Transform, float Radius, int AngleSteps, int SpokeSteps, float StartAngle, float EndAngle, float HoleRadius, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendDisc), TargetMesh, PrimitiveOptions, Transform, Radius, AngleSteps, SpokeSteps, StartAngle, EndAngle, HoleRadius, Debug); }
        public DynamicMesh AppendCylinder(DynamicMesh TargetMesh, GeometryScriptPrimitiveOptions PrimitiveOptions, Transform Transform, float Radius, float Height, int RadialSteps, int HeightSteps, bool bCapped, EGeometryScriptPrimitiveOriginMode Origin, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendCylinder), TargetMesh, PrimitiveOptions, Transform, Radius, Height, RadialSteps, HeightSteps, bCapped, Origin, Debug); }
        public DynamicMesh AppendCurvedStairs(DynamicMesh TargetMesh, GeometryScriptPrimitiveOptions PrimitiveOptions, Transform Transform, float StepWidth, float StepHeight, float InnerRadius, float CurveAngle, int NumSteps, bool bFloating, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendCurvedStairs), TargetMesh, PrimitiveOptions, Transform, StepWidth, StepHeight, InnerRadius, CurveAngle, NumSteps, bFloating, Debug); }
        public DynamicMesh AppendCone(DynamicMesh TargetMesh, GeometryScriptPrimitiveOptions PrimitiveOptions, Transform Transform, float BaseRadius, float TopRadius, float Height, int RadialSteps, int HeightSteps, bool bCapped, EGeometryScriptPrimitiveOriginMode Origin, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendCone), TargetMesh, PrimitiveOptions, Transform, BaseRadius, TopRadius, Height, RadialSteps, HeightSteps, bCapped, Origin, Debug); }
        public DynamicMesh AppendCapsule(DynamicMesh TargetMesh, GeometryScriptPrimitiveOptions PrimitiveOptions, Transform Transform, float Radius, float LineLength, int HemisphereSteps, int CircleSteps, EGeometryScriptPrimitiveOriginMode Origin, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendCapsule), TargetMesh, PrimitiveOptions, Transform, Radius, LineLength, HemisphereSteps, CircleSteps, Origin, Debug); }
        public DynamicMesh AppendBox(DynamicMesh TargetMesh, GeometryScriptPrimitiveOptions PrimitiveOptions, Transform Transform, float DimensionX, float DimensionY, float DimensionZ, int StepsX, int StepsY, int StepsZ, EGeometryScriptPrimitiveOriginMode Origin, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AppendBox), TargetMesh, PrimitiveOptions, Transform, DimensionX, DimensionY, DimensionZ, StepsX, StepsY, StepsZ, Origin, Debug); }
    }
    public class GeometryScriptLibrary_MeshQueryFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshQueryFunctions(nint addr) : base(addr) { }
        public bool IsValidVertexID(DynamicMesh TargetMesh, int VertexID) { return Invoke<bool>(nameof(IsValidVertexID), TargetMesh, VertexID); }
        public bool IsValidTriangleID(DynamicMesh TargetMesh, int TriangleID) { return Invoke<bool>(nameof(IsValidTriangleID), TargetMesh, TriangleID); }
        public Vector GetVertexPosition(DynamicMesh TargetMesh, int VertexID, bool bIsValidVertex) { return Invoke<Vector>(nameof(GetVertexPosition), TargetMesh, VertexID, bIsValidVertex); }
        public int GetVertexCount(DynamicMesh TargetMesh) { return Invoke<int>(nameof(GetVertexCount), TargetMesh); }
        public Box2D GetUVSetBoundingBox(DynamicMesh TargetMesh, int UvSetIndex, bool bIsValidUVSet, bool bUVSetIsEmpty) { return Invoke<Box2D>(nameof(GetUVSetBoundingBox), TargetMesh, UvSetIndex, bIsValidUVSet, bUVSetIsEmpty); }
        public DynamicMesh GetTriangleVertexColors(DynamicMesh TargetMesh, int TriangleID, LinearColor Color1, LinearColor Color2, LinearColor Color3, bool bTriHasValidVertexColors) { return Invoke<DynamicMesh>(nameof(GetTriangleVertexColors), TargetMesh, TriangleID, Color1, Color2, Color3, bTriHasValidVertexColors); }
        public void GetTriangleUVs(DynamicMesh TargetMesh, int UvSetIndex, int TriangleID, Vector2D UV1, Vector2D UV2, Vector2D UV3, bool bHaveValidUVs) { Invoke(nameof(GetTriangleUVs), TargetMesh, UvSetIndex, TriangleID, UV1, UV2, UV3, bHaveValidUVs); }
        public void GetTrianglePositions(DynamicMesh TargetMesh, int TriangleID, bool bIsValidTriangle, Vector Vertex1, Vector Vertex2, Vector Vertex3) { Invoke(nameof(GetTrianglePositions), TargetMesh, TriangleID, bIsValidTriangle, Vertex1, Vertex2, Vertex3); }
        public DynamicMesh GetTriangleNormalTangents(DynamicMesh TargetMesh, int TriangleID, bool bTriHasValidElements, GeometryScriptTriangle Normals, GeometryScriptTriangle Tangents, GeometryScriptTriangle BiTangents) { return Invoke<DynamicMesh>(nameof(GetTriangleNormalTangents), TargetMesh, TriangleID, bTriHasValidElements, Normals, Tangents, BiTangents); }
        public DynamicMesh GetTriangleNormals(DynamicMesh TargetMesh, int TriangleID, Vector Normal1, Vector Normal2, Vector Normal3, bool bTriHasValidNormals) { return Invoke<DynamicMesh>(nameof(GetTriangleNormals), TargetMesh, TriangleID, Normal1, Normal2, Normal3, bTriHasValidNormals); }
        public IntVector GetTriangleIndices(DynamicMesh TargetMesh, int TriangleID, bool bIsValidTriangle) { return Invoke<IntVector>(nameof(GetTriangleIndices), TargetMesh, TriangleID, bIsValidTriangle); }
        public Vector GetTriangleFaceNormal(DynamicMesh TargetMesh, int TriangleID, bool bIsValidTriangle) { return Invoke<Vector>(nameof(GetTriangleFaceNormal), TargetMesh, TriangleID, bIsValidTriangle); }
        public int GetNumVertexIDs(DynamicMesh TargetMesh) { return Invoke<int>(nameof(GetNumVertexIDs), TargetMesh); }
        public int GetNumUVSets(DynamicMesh TargetMesh) { return Invoke<int>(nameof(GetNumUVSets), TargetMesh); }
        public int GetNumTriangleIDs(DynamicMesh TargetMesh) { return Invoke<int>(nameof(GetNumTriangleIDs), TargetMesh); }
        public int GetNumOpenBorderLoops(DynamicMesh TargetMesh, bool bAmbiguousTopologyFound) { return Invoke<int>(nameof(GetNumOpenBorderLoops), TargetMesh, bAmbiguousTopologyFound); }
        public int GetNumOpenBorderEdges(DynamicMesh TargetMesh) { return Invoke<int>(nameof(GetNumOpenBorderEdges), TargetMesh); }
        public int GetNumExtendedPolygroupLayers(DynamicMesh TargetMesh) { return Invoke<int>(nameof(GetNumExtendedPolygroupLayers), TargetMesh); }
        public int GetNumConnectedComponents(DynamicMesh TargetMesh) { return Invoke<int>(nameof(GetNumConnectedComponents), TargetMesh); }
        public void GetMeshVolumeArea(DynamicMesh TargetMesh, float SurfaceArea, float Volume) { Invoke(nameof(GetMeshVolumeArea), TargetMesh, SurfaceArea, Volume); }
        public Object GetMeshInfoString(DynamicMesh TargetMesh) { return Invoke<Object>(nameof(GetMeshInfoString), TargetMesh); }
        public bool GetMeshHasAttributeSet(DynamicMesh TargetMesh) { return Invoke<bool>(nameof(GetMeshHasAttributeSet), TargetMesh); }
        public Box GetMeshBoundingBox(DynamicMesh TargetMesh) { return Invoke<Box>(nameof(GetMeshBoundingBox), TargetMesh); }
        public bool GetIsDenseMesh(DynamicMesh TargetMesh) { return Invoke<bool>(nameof(GetIsDenseMesh), TargetMesh); }
        public bool GetIsClosedMesh(DynamicMesh TargetMesh) { return Invoke<bool>(nameof(GetIsClosedMesh), TargetMesh); }
        public DynamicMesh GetInterpolatedTriangleVertexColor(DynamicMesh TargetMesh, int TriangleID, Vector BarycentricCoords, LinearColor DefaultColor, bool bTriHasValidVertexColors, LinearColor InterpolatedColor) { return Invoke<DynamicMesh>(nameof(GetInterpolatedTriangleVertexColor), TargetMesh, TriangleID, BarycentricCoords, DefaultColor, bTriHasValidVertexColors, InterpolatedColor); }
        public DynamicMesh GetInterpolatedTriangleUV(DynamicMesh TargetMesh, int UvSetIndex, int TriangleID, Vector BarycentricCoords, bool bTriHasValidUVs, Vector2D InterpolatedUV) { return Invoke<DynamicMesh>(nameof(GetInterpolatedTriangleUV), TargetMesh, UvSetIndex, TriangleID, BarycentricCoords, bTriHasValidUVs, InterpolatedUV); }
        public DynamicMesh GetInterpolatedTrianglePosition(DynamicMesh TargetMesh, int TriangleID, Vector BarycentricCoords, bool bIsValidTriangle, Vector InterpolatedPosition) { return Invoke<DynamicMesh>(nameof(GetInterpolatedTrianglePosition), TargetMesh, TriangleID, BarycentricCoords, bIsValidTriangle, InterpolatedPosition); }
        public DynamicMesh GetInterpolatedTriangleNormalTangents(DynamicMesh TargetMesh, int TriangleID, Vector BarycentricCoords, bool bTriHasValidElements, Vector InterpolatedNormal, Vector InterpolatedTangent, Vector InterpolatedBiTangent) { return Invoke<DynamicMesh>(nameof(GetInterpolatedTriangleNormalTangents), TargetMesh, TriangleID, BarycentricCoords, bTriHasValidElements, InterpolatedNormal, InterpolatedTangent, InterpolatedBiTangent); }
        public DynamicMesh GetInterpolatedTriangleNormal(DynamicMesh TargetMesh, int TriangleID, Vector BarycentricCoords, bool bTriHasValidNormals, Vector InterpolatedNormal) { return Invoke<DynamicMesh>(nameof(GetInterpolatedTriangleNormal), TargetMesh, TriangleID, BarycentricCoords, bTriHasValidNormals, InterpolatedNormal); }
        public bool GetHasVertexIDGaps(DynamicMesh TargetMesh) { return Invoke<bool>(nameof(GetHasVertexIDGaps), TargetMesh); }
        public bool GetHasVertexColors(DynamicMesh TargetMesh) { return Invoke<bool>(nameof(GetHasVertexColors), TargetMesh); }
        public bool GetHasTriangleNormals(DynamicMesh TargetMesh) { return Invoke<bool>(nameof(GetHasTriangleNormals), TargetMesh); }
        public bool GetHasTriangleIDGaps(DynamicMesh TargetMesh) { return Invoke<bool>(nameof(GetHasTriangleIDGaps), TargetMesh); }
        public bool GetHasPolygroups(DynamicMesh TargetMesh) { return Invoke<bool>(nameof(GetHasPolygroups), TargetMesh); }
        public bool GetHasMaterialIDs(DynamicMesh TargetMesh) { return Invoke<bool>(nameof(GetHasMaterialIDs), TargetMesh); }
        public DynamicMesh GetAllVertexPositions(DynamicMesh TargetMesh, GeometryScriptVectorList PositionList, bool bSkipGaps, bool bHasVertexIDGaps) { return Invoke<DynamicMesh>(nameof(GetAllVertexPositions), TargetMesh, PositionList, bSkipGaps, bHasVertexIDGaps); }
        public DynamicMesh GetAllVertexIDs(DynamicMesh TargetMesh, GeometryScriptIndexList VertexIDList, bool bHasVertexIDGaps) { return Invoke<DynamicMesh>(nameof(GetAllVertexIDs), TargetMesh, VertexIDList, bHasVertexIDGaps); }
        public DynamicMesh GetAllTriangleIndices(DynamicMesh TargetMesh, GeometryScriptTriangleList TriangleList, bool bSkipGaps, bool bHasTriangleIDGaps) { return Invoke<DynamicMesh>(nameof(GetAllTriangleIndices), TargetMesh, TriangleList, bSkipGaps, bHasTriangleIDGaps); }
        public DynamicMesh GetAllTriangleIDs(DynamicMesh TargetMesh, GeometryScriptIndexList TriangleIDList, bool bHasTriangleIDGaps) { return Invoke<DynamicMesh>(nameof(GetAllTriangleIDs), TargetMesh, TriangleIDList, bHasTriangleIDGaps); }
        public DynamicMesh ComputeTriangleBarycentricCoords(DynamicMesh TargetMesh, int TriangleID, bool bIsValidTriangle, Vector Point, Vector Vertex1, Vector Vertex2, Vector Vertex3, Vector BarycentricCoords) { return Invoke<DynamicMesh>(nameof(ComputeTriangleBarycentricCoords), TargetMesh, TriangleID, bIsValidTriangle, Point, Vertex1, Vertex2, Vertex3, BarycentricCoords); }
    }
    public class GeometryScriptLibrary_RemeshingFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_RemeshingFunctions(nint addr) : base(addr) { }
        public DynamicMesh ApplyUniformRemesh(DynamicMesh TargetMesh, GeometryScriptRemeshOptions RemeshOptions, GeometryScriptUniformRemeshOptions UniformOptions, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyUniformRemesh), TargetMesh, RemeshOptions, UniformOptions, Debug); }
    }
    public class GeometryScriptLibrary_MeshRepairFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshRepairFunctions(nint addr) : base(addr) { }
        public DynamicMesh WeldMeshEdges(DynamicMesh TargetMesh, GeometryScriptWeldEdgesOptions WeldOptions, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(WeldMeshEdges), TargetMesh, WeldOptions, Debug); }
        public DynamicMesh SplitMeshBowties(DynamicMesh TargetMesh, bool bMeshBowties, bool bAttributeBowties, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(SplitMeshBowties), TargetMesh, bMeshBowties, bAttributeBowties, Debug); }
        public DynamicMesh ResolveMeshTJunctions(DynamicMesh TargetMesh, GeometryScriptResolveTJunctionOptions ResolveOptions, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ResolveMeshTJunctions), TargetMesh, ResolveOptions, Debug); }
        public DynamicMesh RepairMeshDegenerateGeometry(DynamicMesh TargetMesh, GeometryScriptDegenerateTriangleOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(RepairMeshDegenerateGeometry), TargetMesh, Options, Debug); }
        public DynamicMesh RemoveSmallComponents(DynamicMesh TargetMesh, GeometryScriptRemoveSmallComponentOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(RemoveSmallComponents), TargetMesh, Options, Debug); }
        public DynamicMesh RemoveHiddenTriangles(DynamicMesh TargetMesh, GeometryScriptRemoveHiddenTrianglesOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(RemoveHiddenTriangles), TargetMesh, Options, Debug); }
        public DynamicMesh FillAllMeshHoles(DynamicMesh TargetMesh, GeometryScriptFillHolesOptions FillOptions, int NumFilledHoles, int NumFailedHoleFills, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(FillAllMeshHoles), TargetMesh, FillOptions, NumFilledHoles, NumFailedHoleFills, Debug); }
        public DynamicMesh CompactMesh(DynamicMesh TargetMesh, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(CompactMesh), TargetMesh, Debug); }
    }
    public class GeometryScriptLibrary_MeshSamplingFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshSamplingFunctions(nint addr) : base(addr) { }
        public DynamicMesh ComputeVertexWeightedPointSampling(DynamicMesh TargetMesh, GeometryScriptMeshPointSamplingOptions Options, GeometryScriptNonUniformPointSamplingOptions NonUniformOptions, GeometryScriptScalarList VertexWeights, Array<Transform> Samples, Array<double> SampleRadii, GeometryScriptIndexList TriangleIDs, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ComputeVertexWeightedPointSampling), TargetMesh, Options, NonUniformOptions, VertexWeights, Samples, SampleRadii, TriangleIDs, Debug); }
        public DynamicMesh ComputePointSampling(DynamicMesh TargetMesh, GeometryScriptMeshPointSamplingOptions Options, Array<Transform> Samples, GeometryScriptIndexList TriangleIDs, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ComputePointSampling), TargetMesh, Options, Samples, TriangleIDs, Debug); }
        public DynamicMesh ComputeNonUniformPointSampling(DynamicMesh TargetMesh, GeometryScriptMeshPointSamplingOptions Options, GeometryScriptNonUniformPointSamplingOptions NonUniformOptions, Array<Transform> Samples, Array<double> SampleRadii, GeometryScriptIndexList TriangleIDs, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ComputeNonUniformPointSampling), TargetMesh, Options, NonUniformOptions, Samples, SampleRadii, TriangleIDs, Debug); }
    }
    public class GeometryScriptLibrary_MeshSelectionFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshSelectionFunctions(nint addr) : base(addr) { }
        public DynamicMesh SelectMeshElementsWithPlane(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, Vector PlaneOrigin, Vector PlaneNormal, EGeometryScriptMeshSelectionType SelectionType, bool bInvert, int MinNumTrianglePoints) { return Invoke<DynamicMesh>(nameof(SelectMeshElementsWithPlane), TargetMesh, Selection, PlaneOrigin, PlaneNormal, SelectionType, bInvert, MinNumTrianglePoints); }
        public DynamicMesh SelectMeshElementsInSphere(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, Vector SphereOrigin, double SphereRadius, EGeometryScriptMeshSelectionType SelectionType, bool bInvert, int MinNumTrianglePoints) { return Invoke<DynamicMesh>(nameof(SelectMeshElementsInSphere), TargetMesh, Selection, SphereOrigin, SphereRadius, SelectionType, bInvert, MinNumTrianglePoints); }
        public DynamicMesh SelectMeshElementsInsideMesh(DynamicMesh TargetMesh, DynamicMesh SelectionMesh, GeometryScriptMeshSelection Selection, Transform SelectionMeshTransform, EGeometryScriptMeshSelectionType SelectionType, bool bInvert, double ShellDistance, double WindingThreshold, int MinNumTrianglePoints) { return Invoke<DynamicMesh>(nameof(SelectMeshElementsInsideMesh), TargetMesh, SelectionMesh, Selection, SelectionMeshTransform, SelectionType, bInvert, ShellDistance, WindingThreshold, MinNumTrianglePoints); }
        public DynamicMesh SelectMeshElementsInBox(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, Box Box, EGeometryScriptMeshSelectionType SelectionType, bool bInvert, int MinNumTrianglePoints) { return Invoke<DynamicMesh>(nameof(SelectMeshElementsInBox), TargetMesh, Selection, Box, SelectionType, bInvert, MinNumTrianglePoints); }
        public DynamicMesh SelectMeshElementsByNormalAngle(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, Vector Normal, double MaxAngleDeg, EGeometryScriptMeshSelectionType SelectionType, bool bInvert, int MinNumTrianglePoints) { return Invoke<DynamicMesh>(nameof(SelectMeshElementsByNormalAngle), TargetMesh, Selection, Normal, MaxAngleDeg, SelectionType, bInvert, MinNumTrianglePoints); }
        public DynamicMesh InvertMeshSelection(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, GeometryScriptMeshSelection NewSelection, bool bOnlyToConnected) { return Invoke<DynamicMesh>(nameof(InvertMeshSelection), TargetMesh, Selection, NewSelection, bOnlyToConnected); }
        public void GetMeshSelectionInfo(GeometryScriptMeshSelection Selection, EGeometryScriptMeshSelectionType SelectionType, int NumSelected) { Invoke(nameof(GetMeshSelectionInfo), Selection, SelectionType, NumSelected); }
        public DynamicMesh ExpandMeshSelectionToConnected(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, GeometryScriptMeshSelection NewSelection, EGeometryScriptTopologyConnectionType ConnectionType) { return Invoke<DynamicMesh>(nameof(ExpandMeshSelectionToConnected), TargetMesh, Selection, NewSelection, ConnectionType); }
        public DynamicMesh ExpandContractMeshSelection(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, GeometryScriptMeshSelection NewSelection, int Iterations, bool bContract, bool bOnlyExpandToFaceNeighbours) { return Invoke<DynamicMesh>(nameof(ExpandContractMeshSelection), TargetMesh, Selection, NewSelection, Iterations, bContract, bOnlyExpandToFaceNeighbours); }
        public void DebugPrintMeshSelection(GeometryScriptMeshSelection Selection, bool bDisable) { Invoke(nameof(DebugPrintMeshSelection), Selection, bDisable); }
        public DynamicMesh CreateSelectAllMeshSelection(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, EGeometryScriptMeshSelectionType SelectionType) { return Invoke<DynamicMesh>(nameof(CreateSelectAllMeshSelection), TargetMesh, Selection, SelectionType); }
        public DynamicMesh ConvertMeshSelectionToIndexList(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, GeometryScriptIndexList IndexList, EGeometryScriptIndexType ResultListType, EGeometryScriptIndexType ConvertToType) { return Invoke<DynamicMesh>(nameof(ConvertMeshSelectionToIndexList), TargetMesh, Selection, IndexList, ResultListType, ConvertToType); }
        public DynamicMesh ConvertMeshSelectionToIndexArray(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, Array<int> IndexArray, EGeometryScriptMeshSelectionType SelectionType) { return Invoke<DynamicMesh>(nameof(ConvertMeshSelectionToIndexArray), TargetMesh, Selection, IndexArray, SelectionType); }
        public DynamicMesh ConvertMeshSelection(DynamicMesh TargetMesh, GeometryScriptMeshSelection FromSelection, GeometryScriptMeshSelection ToSelection, EGeometryScriptMeshSelectionType NewType, bool bAllowPartialInclusion) { return Invoke<DynamicMesh>(nameof(ConvertMeshSelection), TargetMesh, FromSelection, ToSelection, NewType, bAllowPartialInclusion); }
        public DynamicMesh ConvertIndexSetToMeshSelection(DynamicMesh TargetMesh, Object IndexSet, EGeometryScriptMeshSelectionType SelectionType, GeometryScriptMeshSelection Selection) { return Invoke<DynamicMesh>(nameof(ConvertIndexSetToMeshSelection), TargetMesh, IndexSet, SelectionType, Selection); }
        public DynamicMesh ConvertIndexListToMeshSelection(DynamicMesh TargetMesh, GeometryScriptIndexList IndexList, EGeometryScriptMeshSelectionType SelectionType, GeometryScriptMeshSelection Selection) { return Invoke<DynamicMesh>(nameof(ConvertIndexListToMeshSelection), TargetMesh, IndexList, SelectionType, Selection); }
        public DynamicMesh ConvertIndexArrayToMeshSelection(DynamicMesh TargetMesh, Array<int> IndexArray, EGeometryScriptMeshSelectionType SelectionType, GeometryScriptMeshSelection Selection) { return Invoke<DynamicMesh>(nameof(ConvertIndexArrayToMeshSelection), TargetMesh, IndexArray, SelectionType, Selection); }
        public void CombineMeshSelections(GeometryScriptMeshSelection SelectionA, GeometryScriptMeshSelection SelectionB, GeometryScriptMeshSelection ResultSelection, EGeometryScriptCombineSelectionMode CombineMode) { Invoke(nameof(CombineMeshSelections), SelectionA, SelectionB, ResultSelection, CombineMode); }
    }
    public class GeometryScriptLibrary_MeshSelectionQueryFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshSelectionQueryFunctions(nint addr) : base(addr) { }
        public DynamicMesh GetMeshSelectionBoundingBox(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, Box SelectionBounds, bool bIsEmpty, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(GetMeshSelectionBoundingBox), TargetMesh, Selection, SelectionBounds, bIsEmpty, Debug); }
        public DynamicMesh GetMeshSelectionBoundaryLoops(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, Array<GeometryScriptIndexList> IndexLoops, Array<GeometryScriptPolyPath> PathLoops, int NumLoops, bool bFoundErrors, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(GetMeshSelectionBoundaryLoops), TargetMesh, Selection, IndexLoops, PathLoops, NumLoops, bFoundErrors, Debug); }
    }
    public class GeometryScriptLibrary_MeshSimplifyFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshSimplifyFunctions(nint addr) : base(addr) { }
        public DynamicMesh ApplySimplifyToVertexCount(DynamicMesh TargetMesh, int VertexCount, GeometryScriptSimplifyMeshOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplySimplifyToVertexCount), TargetMesh, VertexCount, Options, Debug); }
        public DynamicMesh ApplySimplifyToTriangleCount(DynamicMesh TargetMesh, int TriangleCount, GeometryScriptSimplifyMeshOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplySimplifyToTriangleCount), TargetMesh, TriangleCount, Options, Debug); }
        public DynamicMesh ApplySimplifyToTolerance(DynamicMesh TargetMesh, float Tolerance, GeometryScriptSimplifyMeshOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplySimplifyToTolerance), TargetMesh, Tolerance, Options, Debug); }
        public DynamicMesh ApplySimplifyToPolygroupTopology(DynamicMesh TargetMesh, GeometryScriptPolygroupSimplifyOptions Options, GeometryScriptGroupLayer GroupLayer, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplySimplifyToPolygroupTopology), TargetMesh, Options, GroupLayer, Debug); }
        public DynamicMesh ApplySimplifyToPlanar(DynamicMesh TargetMesh, GeometryScriptPlanarSimplifyOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplySimplifyToPlanar), TargetMesh, Options, Debug); }
    }
    public class GeometryScriptLibrary_MeshSpatial : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshSpatial(nint addr) : base(addr) { }
        public void ResetBVH(GeometryScriptDynamicMeshBVH ResetBVH) { Invoke(nameof(ResetBVH), ResetBVH); }
        public DynamicMesh RebuildBVHForMesh(DynamicMesh TargetMesh, GeometryScriptDynamicMeshBVH UpdateBVH, bool bOnlyIfInvalid, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(RebuildBVHForMesh), TargetMesh, UpdateBVH, bOnlyIfInvalid, Debug); }
        public DynamicMesh IsPointInsideMesh(DynamicMesh TargetMesh, GeometryScriptDynamicMeshBVH QueryBVH, Vector QueryPoint, GeometryScriptSpatialQueryOptions Options, bool bIsInside, EGeometryScriptContainmentOutcomePins Outcome, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(IsPointInsideMesh), TargetMesh, QueryBVH, QueryPoint, Options, bIsInside, Outcome, Debug); }
        public DynamicMesh IsBVHValidForMesh(DynamicMesh TargetMesh, GeometryScriptDynamicMeshBVH TestBVH, bool bIsValid, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(IsBVHValidForMesh), TargetMesh, TestBVH, bIsValid, Debug); }
        public DynamicMesh FindNearestRayIntersectionWithMesh(DynamicMesh TargetMesh, GeometryScriptDynamicMeshBVH QueryBVH, Vector RayOrigin, Vector RayDirection, GeometryScriptSpatialQueryOptions Options, GeometryScriptRayHitResult HitResult, EGeometryScriptSearchOutcomePins Outcome, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(FindNearestRayIntersectionWithMesh), TargetMesh, QueryBVH, RayOrigin, RayDirection, Options, HitResult, Outcome, Debug); }
        public DynamicMesh FindNearestPointOnMesh(DynamicMesh TargetMesh, GeometryScriptDynamicMeshBVH QueryBVH, Vector QueryPoint, GeometryScriptSpatialQueryOptions Options, GeometryScriptTrianglePoint NearestResult, EGeometryScriptSearchOutcomePins Outcome, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(FindNearestPointOnMesh), TargetMesh, QueryBVH, QueryPoint, Options, NearestResult, Outcome, Debug); }
        public DynamicMesh BuildBVHForMesh(DynamicMesh TargetMesh, GeometryScriptDynamicMeshBVH OutputBVH, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(BuildBVHForMesh), TargetMesh, OutputBVH, Debug); }
    }
    public class GeometryScriptLibrary_MeshSubdivideFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshSubdivideFunctions(nint addr) : base(addr) { }
        public DynamicMesh ApplyUniformTessellation(DynamicMesh TargetMesh, int TessellationLevel, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyUniformTessellation), TargetMesh, TessellationLevel, Debug); }
        public DynamicMesh ApplySelectiveTessellation(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, GeometryScriptSelectiveTessellateOptions Options, int TessellationLevel, ESelectiveTessellatePatternType PatternType, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplySelectiveTessellation), TargetMesh, Selection, Options, TessellationLevel, PatternType, Debug); }
        public DynamicMesh ApplyPNTessellation(DynamicMesh TargetMesh, GeometryScriptPNTessellateOptions Options, int TessellationLevel, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyPNTessellation), TargetMesh, Options, TessellationLevel, Debug); }
    }
    public class GeometryScriptLibrary_MeshTransformFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshTransformFunctions(nint addr) : base(addr) { }
        public DynamicMesh TranslatePivotToLocation(DynamicMesh TargetMesh, Vector PivotLocation, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(TranslatePivotToLocation), TargetMesh, PivotLocation, Debug); }
        public DynamicMesh TranslateMeshSelection(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, Vector Translation, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(TranslateMeshSelection), TargetMesh, Selection, Translation, Debug); }
        public DynamicMesh TranslateMesh(DynamicMesh TargetMesh, Vector Translation, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(TranslateMesh), TargetMesh, Translation, Debug); }
        public DynamicMesh TransformMeshSelection(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, Transform Transform, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(TransformMeshSelection), TargetMesh, Selection, Transform, Debug); }
        public DynamicMesh TransformMesh(DynamicMesh TargetMesh, Transform Transform, bool bFixOrientationForNegativeScale, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(TransformMesh), TargetMesh, Transform, bFixOrientationForNegativeScale, Debug); }
        public DynamicMesh ScaleMeshSelection(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, Vector Scale, Vector ScaleOrigin, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ScaleMeshSelection), TargetMesh, Selection, Scale, ScaleOrigin, Debug); }
        public DynamicMesh ScaleMesh(DynamicMesh TargetMesh, Vector Scale, Vector ScaleOrigin, bool bFixOrientationForNegativeScale, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ScaleMesh), TargetMesh, Scale, ScaleOrigin, bFixOrientationForNegativeScale, Debug); }
        public DynamicMesh RotateMeshSelection(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, Rotator Rotation, Vector RotationOrigin, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(RotateMeshSelection), TargetMesh, Selection, Rotation, RotationOrigin, Debug); }
        public DynamicMesh RotateMesh(DynamicMesh TargetMesh, Rotator Rotation, Vector RotationOrigin, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(RotateMesh), TargetMesh, Rotation, RotationOrigin, Debug); }
    }
    public class GeometryScriptLibrary_MeshUVFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshUVFunctions(nint addr) : base(addr) { }
        public DynamicMesh TranslateMeshUVs(DynamicMesh TargetMesh, int UvSetIndex, Vector2D Translation, GeometryScriptMeshSelection Selection, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(TranslateMeshUVs), TargetMesh, UvSetIndex, Translation, Selection, Debug); }
        public DynamicMesh SetNumUVSets(DynamicMesh TargetMesh, int NumUVSets, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(SetNumUVSets), TargetMesh, NumUVSets, Debug); }
        public DynamicMesh SetMeshUVsFromPlanarProjection(DynamicMesh TargetMesh, int UvSetIndex, Transform PlaneTransform, GeometryScriptMeshSelection Selection, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(SetMeshUVsFromPlanarProjection), TargetMesh, UvSetIndex, PlaneTransform, Selection, Debug); }
        public DynamicMesh SetMeshUVsFromCylinderProjection(DynamicMesh TargetMesh, int UvSetIndex, Transform CylinderTransform, GeometryScriptMeshSelection Selection, float SplitAngle, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(SetMeshUVsFromCylinderProjection), TargetMesh, UvSetIndex, CylinderTransform, Selection, SplitAngle, Debug); }
        public DynamicMesh SetMeshUVsFromBoxProjection(DynamicMesh TargetMesh, int UvSetIndex, Transform BoxTransform, GeometryScriptMeshSelection Selection, int MinIslandTriCount, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(SetMeshUVsFromBoxProjection), TargetMesh, UvSetIndex, BoxTransform, Selection, MinIslandTriCount, Debug); }
        public DynamicMesh SetMeshTriangleUVs(DynamicMesh TargetMesh, int UvSetIndex, int TriangleID, GeometryScriptUVTriangle UVs, bool bIsValidTriangle, bool bDeferChangeNotifications) { return Invoke<DynamicMesh>(nameof(SetMeshTriangleUVs), TargetMesh, UvSetIndex, TriangleID, UVs, bIsValidTriangle, bDeferChangeNotifications); }
        public DynamicMesh ScaleMeshUVs(DynamicMesh TargetMesh, int UvSetIndex, Vector2D Scale, Vector2D ScaleOrigin, GeometryScriptMeshSelection Selection, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ScaleMeshUVs), TargetMesh, UvSetIndex, Scale, ScaleOrigin, Selection, Debug); }
        public DynamicMesh RotateMeshUVs(DynamicMesh TargetMesh, int UvSetIndex, float RotationAngle, Vector2D RotationOrigin, GeometryScriptMeshSelection Selection, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(RotateMeshUVs), TargetMesh, UvSetIndex, RotationAngle, RotationOrigin, Selection, Debug); }
        public DynamicMesh RepackMeshUVs(DynamicMesh TargetMesh, int UvSetIndex, GeometryScriptRepackUVsOptions RepackOptions, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(RepackMeshUVs), TargetMesh, UvSetIndex, RepackOptions, Debug); }
        public DynamicMesh RecomputeMeshUVs(DynamicMesh TargetMesh, int UvSetIndex, GeometryScriptRecomputeUVsOptions Options, GeometryScriptMeshSelection Selection, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(RecomputeMeshUVs), TargetMesh, UvSetIndex, Options, Selection, Debug); }
        public DynamicMesh GetMeshUVSizeInfo(DynamicMesh TargetMesh, int UvSetIndex, GeometryScriptMeshSelection Selection, double MeshArea, double UVArea, Box MeshBounds, Box2D UVBounds, bool bIsValidUVSet, bool bFoundUnsetUVs, bool bOnlyIncludeValidUVTris, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(GetMeshUVSizeInfo), TargetMesh, UvSetIndex, Selection, MeshArea, UVArea, MeshBounds, UVBounds, bIsValidUVSet, bFoundUnsetUVs, bOnlyIncludeValidUVTris, Debug); }
        public DynamicMesh GetMeshPerVertexUVs(DynamicMesh TargetMesh, int UvSetIndex, GeometryScriptUVList UVList, bool bIsValidUVSet, bool bHasVertexIDGaps, bool bHasSplitUVs, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(GetMeshPerVertexUVs), TargetMesh, UvSetIndex, UVList, bIsValidUVSet, bHasVertexIDGaps, bHasSplitUVs, Debug); }
        public DynamicMesh CopyUVSet(DynamicMesh TargetMesh, int FromUVSet, int ToUVSet, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(CopyUVSet), TargetMesh, FromUVSet, ToUVSet, Debug); }
        public DynamicMesh CopyMeshUVLayerToMesh(DynamicMesh CopyFromMesh, int UvSetIndex, DynamicMesh CopyToUVMesh, DynamicMesh CopyToUVMeshOut, bool bInvalidTopology, bool bIsValidUVSet, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(CopyMeshUVLayerToMesh), CopyFromMesh, UvSetIndex, CopyToUVMesh, CopyToUVMeshOut, bInvalidTopology, bIsValidUVSet, Debug); }
        public DynamicMesh CopyMeshToMeshUVLayer(DynamicMesh CopyFromUVMesh, int ToUVSetIndex, DynamicMesh CopyToMesh, DynamicMesh CopyToMeshOut, bool bFoundTopologyErrors, bool bIsValidUVSet, bool bOnlyUVPositions, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(CopyMeshToMeshUVLayer), CopyFromUVMesh, ToUVSetIndex, CopyToMesh, CopyToMeshOut, bFoundTopologyErrors, bIsValidUVSet, bOnlyUVPositions, Debug); }
        public DynamicMesh AutoGenerateXAtlasMeshUVs(DynamicMesh TargetMesh, int UvSetIndex, GeometryScriptXAtlasOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AutoGenerateXAtlasMeshUVs), TargetMesh, UvSetIndex, Options, Debug); }
        public DynamicMesh AutoGeneratePatchBuilderMeshUVs(DynamicMesh TargetMesh, int UvSetIndex, GeometryScriptPatchBuilderOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(AutoGeneratePatchBuilderMeshUVs), TargetMesh, UvSetIndex, Options, Debug); }
    }
    public class GeometryScriptLibrary_MeshVertexColorFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshVertexColorFunctions(nint addr) : base(addr) { }
        public DynamicMesh SetMeshSelectionVertexColor(DynamicMesh TargetMesh, GeometryScriptMeshSelection Selection, LinearColor Color, GeometryScriptColorFlags Flags, bool bCreateColorSeam, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(SetMeshSelectionVertexColor), TargetMesh, Selection, Color, Flags, bCreateColorSeam, Debug); }
        public DynamicMesh SetMeshPerVertexColors(DynamicMesh TargetMesh, GeometryScriptColorList VertexColorList, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(SetMeshPerVertexColors), TargetMesh, VertexColorList, Debug); }
        public DynamicMesh SetMeshConstantVertexColor(DynamicMesh TargetMesh, LinearColor Color, GeometryScriptColorFlags Flags, bool bClearExisting, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(SetMeshConstantVertexColor), TargetMesh, Color, Flags, bClearExisting, Debug); }
        public DynamicMesh GetMeshPerVertexColors(DynamicMesh TargetMesh, GeometryScriptColorList ColorList, bool bIsValidColorSet, bool bHasVertexIDGaps, bool bBlendSplitVertexValues) { return Invoke<DynamicMesh>(nameof(GetMeshPerVertexColors), TargetMesh, ColorList, bIsValidColorSet, bHasVertexIDGaps, bBlendSplitVertexValues); }
        public DynamicMesh ConvertMeshVertexColorsSRGBToLinear(DynamicMesh TargetMesh, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ConvertMeshVertexColorsSRGBToLinear), TargetMesh, Debug); }
        public DynamicMesh ConvertMeshVertexColorsLinearToSRGB(DynamicMesh TargetMesh, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ConvertMeshVertexColorsLinearToSRGB), TargetMesh, Debug); }
    }
    public class GeometryScriptLibrary_MeshVoxelFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_MeshVoxelFunctions(nint addr) : base(addr) { }
        public DynamicMesh ApplyMeshSolidify(DynamicMesh TargetMesh, GeometryScriptSolidifyOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyMeshSolidify), TargetMesh, Options, Debug); }
        public DynamicMesh ApplyMeshMorphology(DynamicMesh TargetMesh, GeometryScriptMorphologyOptions Options, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(ApplyMeshMorphology), TargetMesh, Options, Debug); }
    }
    public class GeometryScriptLibrary_PolyPathFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_PolyPathFunctions(nint addr) : base(addr) { }
        public void SampleSplineToTransforms(SplineComponent Spline, Array<Transform> Frames, Array<double> FrameTimes, GeometryScriptSplineSamplingOptions SamplingOptions, Transform RelativeTransform, bool bIncludeScale) { Invoke(nameof(SampleSplineToTransforms), Spline, Frames, FrameTimes, SamplingOptions, RelativeTransform, bIncludeScale); }
        public Vector GetPolyPathVertex(GeometryScriptPolyPath PolyPath, int Index, bool bIsValidIndex) { return Invoke<Vector>(nameof(GetPolyPathVertex), PolyPath, Index, bIsValidIndex); }
        public Vector GetPolyPathTangent(GeometryScriptPolyPath PolyPath, int Index, bool bIsValidIndex) { return Invoke<Vector>(nameof(GetPolyPathTangent), PolyPath, Index, bIsValidIndex); }
        public int GetPolyPathNumVertices(GeometryScriptPolyPath PolyPath) { return Invoke<int>(nameof(GetPolyPathNumVertices), PolyPath); }
        public int GetPolyPathLastIndex(GeometryScriptPolyPath PolyPath) { return Invoke<int>(nameof(GetPolyPathLastIndex), PolyPath); }
        public double GetPolyPathArcLength(GeometryScriptPolyPath PolyPath) { return Invoke<double>(nameof(GetPolyPathArcLength), PolyPath); }
        public int GetNearestVertexIndex(GeometryScriptPolyPath PolyPath, Vector Point) { return Invoke<int>(nameof(GetNearestVertexIndex), PolyPath, Point); }
        public GeometryScriptPolyPath FlattenTo2DOnAxis(GeometryScriptPolyPath PolyPath, EGeometryScriptAxis DropAxis) { return Invoke<GeometryScriptPolyPath>(nameof(FlattenTo2DOnAxis), PolyPath, DropAxis); }
        public GeometryScriptPolyPath CreateCirclePath3D(Transform Transform, float Radius, int NumPoints) { return Invoke<GeometryScriptPolyPath>(nameof(CreateCirclePath3D), Transform, Radius, NumPoints); }
        public GeometryScriptPolyPath CreateCirclePath2D(Vector2D Center, float Radius, int NumPoints) { return Invoke<GeometryScriptPolyPath>(nameof(CreateCirclePath2D), Center, Radius, NumPoints); }
        public GeometryScriptPolyPath CreateArcPath3D(Transform Transform, float Radius, int NumPoints, float StartAngle, float EndAngle) { return Invoke<GeometryScriptPolyPath>(nameof(CreateArcPath3D), Transform, Radius, NumPoints, StartAngle, EndAngle); }
        public GeometryScriptPolyPath CreateArcPath2D(Vector2D Center, float Radius, int NumPoints, float StartAngle, float EndAngle) { return Invoke<GeometryScriptPolyPath>(nameof(CreateArcPath2D), Center, Radius, NumPoints, StartAngle, EndAngle); }
        public void ConvertSplineToPolyPath(SplineComponent Spline, GeometryScriptPolyPath PolyPath, GeometryScriptSplineSamplingOptions SamplingOptions) { Invoke(nameof(ConvertSplineToPolyPath), Spline, PolyPath, SamplingOptions); }
        public void ConvertPolyPathToArrayOfVector2D(GeometryScriptPolyPath PolyPath, Array<Vector2D> VertexArray) { Invoke(nameof(ConvertPolyPathToArrayOfVector2D), PolyPath, VertexArray); }
        public void ConvertPolyPathToArray(GeometryScriptPolyPath PolyPath, Array<Vector> VertexArray) { Invoke(nameof(ConvertPolyPathToArray), PolyPath, VertexArray); }
        public void ConvertArrayToPolyPath(Array<Vector> VertexArray, GeometryScriptPolyPath PolyPath) { Invoke(nameof(ConvertArrayToPolyPath), VertexArray, PolyPath); }
        public void ConvertArrayOfVector2DToPolyPath(Array<Vector2D> VertexArray, GeometryScriptPolyPath PolyPath) { Invoke(nameof(ConvertArrayOfVector2DToPolyPath), VertexArray, PolyPath); }
        public Array<Vector2D> Conv_GeometryScriptPolyPathToArrayOfVector2D(GeometryScriptPolyPath PolyPath) { return Invoke<Array<Vector2D>>(nameof(Conv_GeometryScriptPolyPathToArrayOfVector2D), PolyPath); }
        public Array<Vector> Conv_GeometryScriptPolyPathToArray(GeometryScriptPolyPath PolyPath) { return Invoke<Array<Vector>>(nameof(Conv_GeometryScriptPolyPathToArray), PolyPath); }
        public GeometryScriptPolyPath Conv_ArrayToGeometryScriptPolyPath(Array<Vector> PathVertices) { return Invoke<GeometryScriptPolyPath>(nameof(Conv_ArrayToGeometryScriptPolyPath), PathVertices); }
        public GeometryScriptPolyPath Conv_ArrayOfVector2DToGeometryScriptPolyPath(Array<Vector2D> PathVertices) { return Invoke<GeometryScriptPolyPath>(nameof(Conv_ArrayOfVector2DToGeometryScriptPolyPath), PathVertices); }
    }
    public class GeometryScriptLibrary_SceneUtilityFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_SceneUtilityFunctions(nint addr) : base(addr) { }
        public void SetComponentMaterialList(PrimitiveComponent Component, Array<MaterialInterface> MaterialList, GeometryScriptDebug Debug) { Invoke(nameof(SetComponentMaterialList), Component, MaterialList, Debug); }
        public DynamicMeshPool CreateDynamicMeshPool() { return Invoke<DynamicMeshPool>(nameof(CreateDynamicMeshPool)); }
        public DynamicMesh CopyMeshFromComponent(SceneComponent Component, DynamicMesh ToDynamicMesh, GeometryScriptCopyMeshFromComponentOptions Options, bool bTransformToWorld, Transform LocalToWorld, EGeometryScriptOutcomePins Outcome, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(CopyMeshFromComponent), Component, ToDynamicMesh, Options, bTransformToWorld, LocalToWorld, Outcome, Debug); }
        public DynamicMesh CopyCollisionMeshesFromObject(Object FromObject, DynamicMesh ToDynamicMesh, bool bTransformToWorld, Transform LocalToWorld, EGeometryScriptOutcomePins Outcome, bool bUseComplexCollision, int SphereResolution, GeometryScriptDebug Debug) { return Invoke<DynamicMesh>(nameof(CopyCollisionMeshesFromObject), FromObject, ToDynamicMesh, bTransformToWorld, LocalToWorld, Outcome, bUseComplexCollision, SphereResolution, Debug); }
    }
    public class GeometryScriptLibrary_TransformFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_TransformFunctions(nint addr) : base(addr) { }
        public Transform MakeTransformFromZAxis(Vector Location, Vector ZAxis) { return Invoke<Transform>(nameof(MakeTransformFromZAxis), Location, ZAxis); }
        public Transform MakeTransformFromAxes(Vector Location, Vector ZAxis, Vector TangentAxis, bool bTangentIsX) { return Invoke<Transform>(nameof(MakeTransformFromAxes), Location, ZAxis, TangentAxis, bTangentIsX); }
        public Vector GetTransformAxisVector(Transform Transform, EGeometryScriptAxis Axis) { return Invoke<Vector>(nameof(GetTransformAxisVector), Transform, Axis); }
        public Ray GetTransformAxisRay(Transform Transform, EGeometryScriptAxis Axis) { return Invoke<Ray>(nameof(GetTransformAxisRay), Transform, Axis); }
        public Plane GetTransformAxisPlane(Transform Transform, EGeometryScriptAxis Axis) { return Invoke<Plane>(nameof(GetTransformAxisPlane), Transform, Axis); }
    }
    public class GeometryScriptLibrary_RayFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_RayFunctions(nint addr) : base(addr) { }
        public Ray MakeRayFromPoints(Vector A, Vector B) { return Invoke<Ray>(nameof(MakeRayFromPoints), A, B); }
        public Ray MakeRayFromPointDirection(Vector Origin, Vector Direction, bool bDirectionIsNormalized) { return Invoke<Ray>(nameof(MakeRayFromPointDirection), Origin, Direction, bDirectionIsNormalized); }
        public Ray GetTransformedRay(Ray Ray, Transform Transform, bool bInvert) { return Invoke<Ray>(nameof(GetTransformedRay), Ray, Transform, bInvert); }
        public void GetRayStartEnd(Ray Ray, double StartDistance, double EndDistance, Vector StartPoint, Vector EndPoint) { Invoke(nameof(GetRayStartEnd), Ray, StartDistance, EndDistance, StartPoint, EndPoint); }
        public bool GetRaySphereIntersection(Ray Ray, Vector SphereCenter, double SphereRadius, double Distance1, double Distance2) { return Invoke<bool>(nameof(GetRaySphereIntersection), Ray, SphereCenter, SphereRadius, Distance1, Distance2); }
        public double GetRaySegmentClosestPoint(Ray Ray, Vector SegStartPoint, Vector SegEndPoint, double RayParameter, Vector RayPoint, Vector SegPoint) { return Invoke<double>(nameof(GetRaySegmentClosestPoint), Ray, SegStartPoint, SegEndPoint, RayParameter, RayPoint, SegPoint); }
        public double GetRayPointDistance(Ray Ray, Vector Point) { return Invoke<double>(nameof(GetRayPointDistance), Ray, Point); }
        public Vector GetRayPoint(Ray Ray, double Distance) { return Invoke<Vector>(nameof(GetRayPoint), Ray, Distance); }
        public bool GetRayPlaneIntersection(Ray Ray, Plane Plane, double HitDistance) { return Invoke<bool>(nameof(GetRayPlaneIntersection), Ray, Plane, HitDistance); }
        public double GetRayParameter(Ray Ray, Vector Point) { return Invoke<double>(nameof(GetRayParameter), Ray, Point); }
        public double GetRayLineClosestPoint(Ray Ray, Vector LineOrigin, Vector LineDirection, double RayParameter, Vector RayPoint, double LineParameter, Vector LinePoint) { return Invoke<double>(nameof(GetRayLineClosestPoint), Ray, LineOrigin, LineDirection, RayParameter, RayPoint, LineParameter, LinePoint); }
        public Vector GetRayClosestPoint(Ray Ray, Vector Point) { return Invoke<Vector>(nameof(GetRayClosestPoint), Ray, Point); }
        public bool GetRayBoxIntersection(Ray Ray, Box Box, double HitDistance) { return Invoke<bool>(nameof(GetRayBoxIntersection), Ray, Box, HitDistance); }
    }
    public class GeometryScriptLibrary_BoxFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_BoxFunctions(nint addr) : base(addr) { }
        public bool TestPointInsideBox(Box Box, Vector Point, bool bConsiderOnBoxAsInside) { return Invoke<bool>(nameof(TestPointInsideBox), Box, Point, bConsiderOnBoxAsInside); }
        public bool TestBoxSphereIntersection(Box Box, Vector SphereCenter, double SphereRadius) { return Invoke<bool>(nameof(TestBoxSphereIntersection), Box, SphereCenter, SphereRadius); }
        public bool TestBoxBoxIntersection(Box Box1, Box Box2) { return Invoke<bool>(nameof(TestBoxBoxIntersection), Box1, Box2); }
        public Box MakeBoxFromCenterSize(Vector Center, Vector Dimensions) { return Invoke<Box>(nameof(MakeBoxFromCenterSize), Center, Dimensions); }
        public Box MakeBoxFromCenterExtents(Vector Center, Vector Extents) { return Invoke<Box>(nameof(MakeBoxFromCenterExtents), Center, Extents); }
        public Box GetTransformedBox(Box Box, Transform Transform) { return Invoke<Box>(nameof(GetTransformedBox), Box, Transform); }
        public Box GetExpandedBox(Box Box, Vector ExpandBy) { return Invoke<Box>(nameof(GetExpandedBox), Box, ExpandBy); }
        public void GetBoxVolumeArea(Box Box, double Volume, double SurfaceArea) { Invoke(nameof(GetBoxVolumeArea), Box, Volume, SurfaceArea); }
        public double GetBoxPointDistance(Box Box, Vector Point) { return Invoke<double>(nameof(GetBoxPointDistance), Box, Point); }
        public Vector GetBoxFaceCenter(Box Box, int FaceIndex, Vector FaceNormal) { return Invoke<Vector>(nameof(GetBoxFaceCenter), Box, FaceIndex, FaceNormal); }
        public Vector GetBoxCorner(Box Box, int CornerIndex) { return Invoke<Vector>(nameof(GetBoxCorner), Box, CornerIndex); }
        public void GetBoxCenterSize(Box Box, Vector Center, Vector Dimensions) { Invoke(nameof(GetBoxCenterSize), Box, Center, Dimensions); }
        public double GetBoxBoxDistance(Box Box1, Box Box2) { return Invoke<double>(nameof(GetBoxBoxDistance), Box1, Box2); }
        public Vector FindClosestPointOnBox(Box Box, Vector Point, bool bIsInside) { return Invoke<Vector>(nameof(FindClosestPointOnBox), Box, Point, bIsInside); }
        public Box FindBoxBoxIntersection(Box Box1, Box Box2, bool bIsIntersecting) { return Invoke<Box>(nameof(FindBoxBoxIntersection), Box1, Box2, bIsIntersecting); }
    }
    public class GeometryScriptLibrary_TextureMapFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_TextureMapFunctions(nint addr) : base(addr) { }
        public void SampleTextureRenderTarget2DAtUVPositions(GeometryScriptUVList UVList, TextureRenderTarget2D Texture, GeometryScriptSampleTextureOptions SampleOptions, GeometryScriptColorList ColorList, GeometryScriptDebug Debug) { Invoke(nameof(SampleTextureRenderTarget2DAtUVPositions), UVList, Texture, SampleOptions, ColorList, Debug); }
        public void SampleTexture2DAtUVPositions(GeometryScriptUVList UVList, Texture2D Texture, GeometryScriptSampleTextureOptions SampleOptions, GeometryScriptColorList ColorList, GeometryScriptDebug Debug) { Invoke(nameof(SampleTexture2DAtUVPositions), UVList, Texture, SampleOptions, ColorList, Debug); }
    }
    public class GeometryScriptLibrary_VectorMathFunctions : BlueprintFunctionLibrary
    {
        public GeometryScriptLibrary_VectorMathFunctions(nint addr) : base(addr) { }
        public GeometryScriptScalarList VectorToScalar(GeometryScriptVectorList VectorList, double ConstantX, double ConstantY, double ConstantZ) { return Invoke<GeometryScriptScalarList>(nameof(VectorToScalar), VectorList, ConstantX, ConstantY, ConstantZ); }
        public void VectorNormalizeInPlace(GeometryScriptVectorList VectorList, Vector SetOnFailure) { Invoke(nameof(VectorNormalizeInPlace), VectorList, SetOnFailure); }
        public GeometryScriptScalarList VectorLength(GeometryScriptVectorList VectorList) { return Invoke<GeometryScriptScalarList>(nameof(VectorLength), VectorList); }
        public GeometryScriptScalarList VectorDot(GeometryScriptVectorList VectorListA, GeometryScriptVectorList VectorListB) { return Invoke<GeometryScriptScalarList>(nameof(VectorDot), VectorListA, VectorListB); }
        public GeometryScriptVectorList VectorCross(GeometryScriptVectorList VectorListA, GeometryScriptVectorList VectorListB) { return Invoke<GeometryScriptVectorList>(nameof(VectorCross), VectorListA, VectorListB); }
        public void VectorBlendInPlace(GeometryScriptVectorList VectorListA, GeometryScriptVectorList VectorListB, double ConstantA, double ConstantB) { Invoke(nameof(VectorBlendInPlace), VectorListA, VectorListB, ConstantA, ConstantB); }
        public GeometryScriptVectorList VectorBlend(GeometryScriptVectorList VectorListA, GeometryScriptVectorList VectorListB, double ConstantA, double ConstantB) { return Invoke<GeometryScriptVectorList>(nameof(VectorBlend), VectorListA, VectorListB, ConstantA, ConstantB); }
        public void ScalarVectorMultiplyInPlace(GeometryScriptScalarList ScalarList, GeometryScriptVectorList VectorList, double ScalarMultiplier) { Invoke(nameof(ScalarVectorMultiplyInPlace), ScalarList, VectorList, ScalarMultiplier); }
        public GeometryScriptVectorList ScalarVectorMultiply(GeometryScriptScalarList ScalarList, GeometryScriptVectorList VectorList, double ScalarMultiplier) { return Invoke<GeometryScriptVectorList>(nameof(ScalarVectorMultiply), ScalarList, VectorList, ScalarMultiplier); }
        public void ScalarMultiplyInPlace(GeometryScriptScalarList ScalarListA, GeometryScriptScalarList ScalarListB, double ConstantMultiplier) { Invoke(nameof(ScalarMultiplyInPlace), ScalarListA, ScalarListB, ConstantMultiplier); }
        public GeometryScriptScalarList ScalarMultiply(GeometryScriptScalarList ScalarListA, GeometryScriptScalarList ScalarListB, double ConstantMultiplier) { return Invoke<GeometryScriptScalarList>(nameof(ScalarMultiply), ScalarListA, ScalarListB, ConstantMultiplier); }
        public void ScalarInvertInPlace(GeometryScriptScalarList ScalarList, double Numerator, double SetOnFailure, double Epsilon) { Invoke(nameof(ScalarInvertInPlace), ScalarList, Numerator, SetOnFailure, Epsilon); }
        public GeometryScriptScalarList ScalarInvert(GeometryScriptScalarList ScalarList, double Numerator, double SetOnFailure, double Epsilon) { return Invoke<GeometryScriptScalarList>(nameof(ScalarInvert), ScalarList, Numerator, SetOnFailure, Epsilon); }
        public void ScalarBlendInPlace(GeometryScriptScalarList ScalarListA, GeometryScriptScalarList ScalarListB, double ConstantA, double ConstantB) { Invoke(nameof(ScalarBlendInPlace), ScalarListA, ScalarListB, ConstantA, ConstantB); }
        public GeometryScriptScalarList ScalarBlend(GeometryScriptScalarList ScalarListA, GeometryScriptScalarList ScalarListB, double ConstantA, double ConstantB) { return Invoke<GeometryScriptScalarList>(nameof(ScalarBlend), ScalarListA, ScalarListB, ConstantA, ConstantB); }
        public void ConstantVectorMultiplyInPlace(double Constant, GeometryScriptVectorList VectorList) { Invoke(nameof(ConstantVectorMultiplyInPlace), Constant, VectorList); }
        public GeometryScriptVectorList ConstantVectorMultiply(double Constant, GeometryScriptVectorList VectorList) { return Invoke<GeometryScriptVectorList>(nameof(ConstantVectorMultiply), Constant, VectorList); }
        public void ConstantScalarMultiplyInPlace(double Constant, GeometryScriptScalarList ScalarList) { Invoke(nameof(ConstantScalarMultiplyInPlace), Constant, ScalarList); }
        public GeometryScriptScalarList ConstantScalarMultiply(double Constant, GeometryScriptScalarList ScalarList) { return Invoke<GeometryScriptScalarList>(nameof(ConstantScalarMultiply), Constant, ScalarList); }
    }
    public enum EGeometryScriptOutcomePins : int
    {
        Failure = 0,
        Success = 1,
        EGeometryScriptOutcomePins_MAX = 2,
    }
    public enum EGeometryScriptSearchOutcomePins : int
    {
        Found = 0,
        NotFound = 1,
        EGeometryScriptSearchOutcomePins_MAX = 2,
    }
    public enum EGeometryScriptContainmentOutcomePins : int
    {
        Inside = 0,
        Outside = 1,
        EGeometryScriptContainmentOutcomePins_MAX = 2,
    }
    public enum EGeometryScriptLODType : int
    {
        MaxAvailable = 0,
        HiResSourceModel = 1,
        SourceModel = 2,
        RenderData = 3,
        EGeometryScriptLODType_MAX = 4,
    }
    public enum EGeometryScriptAxis : int
    {
        X = 0,
        Y = 1,
        Z = 2,
        EGeometryScriptAxis_MAX = 3,
    }
    public enum EGeometryScriptIndexType : int
    {
        Any = 0,
        Triangle = 1,
        Vertex = 2,
        MaterialID = 3,
        PolygroupID = 4,
        EGeometryScriptIndexType_MAX = 5,
    }
    public enum EGeometryScriptDebugMessageType : int
    {
        ErrorMessage = 0,
        WarningMessage = 1,
        EGeometryScriptDebugMessageType_MAX = 2,
    }
    public enum EGeometryScriptErrorType : int
    {
        NoError = 0,
        UnknownError = 1,
        InvalidInputs = 2,
        OperationFailed = 3,
        EGeometryScriptErrorType_MAX = 4,
    }
    public enum EGeometryScriptCollisionGenerationMethod : int
    {
        AlignedBoxes = 0,
        OrientedBoxes = 1,
        MinimalSpheres = 2,
        Capsules = 3,
        ConvexHulls = 4,
        SweptHulls = 5,
        MinVolumeShapes = 6,
        EGeometryScriptCollisionGenerationMethod_MAX = 7,
    }
    public enum EGeometryScriptSweptHullAxis : int
    {
        X = 0,
        Y = 1,
        Z = 2,
        SmallestBoxDimension = 3,
        SmallestVolume = 4,
        EGeometryScriptSweptHullAxis_MAX = 5,
    }
    public enum EGeometryScriptMeshSelectionType : int
    {
        Vertices = 0,
        Triangles = 1,
        Polygroups = 2,
        EGeometryScriptMeshSelectionType_MAX = 3,
    }
    public enum EGeometryScriptMeshSelectionConversionType : int
    {
        NoConversion = 0,
        ToVertices = 1,
        ToTriangles = 2,
        ToPolygroups = 3,
        EGeometryScriptMeshSelectionConversionType_MAX = 4,
    }
    public enum EGeometryScriptCombineSelectionMode : int
    {
        Add = 0,
        Subtract = 1,
        Intersection = 2,
        EGeometryScriptCombineSelectionMode_MAX = 3,
    }
    public enum EGeometryScriptEmptySelectionBehavior : int
    {
        FullMeshSelection = 0,
        EmptySelection = 1,
        EGeometryScriptEmptySelectionBehavior_MAX = 2,
    }
    public enum EGeometryScriptBakeResolution : int
    {
        Resolution16 = 0,
        Resolution32 = 1,
        Resolution64 = 2,
        Resolution128 = 3,
        Resolution256 = 4,
        Resolution512 = 5,
        Resolution1024 = 6,
        Resolution2048 = 7,
        Resolution4096 = 8,
        Resolution8192 = 9,
        EGeometryScriptBakeResolution_MAX = 10,
    }
    public enum EGeometryScriptBakeBitDepth : int
    {
        ChannelBits8 = 0,
        ChannelBits16 = 1,
        EGeometryScriptBakeBitDepth_MAX = 2,
    }
    public enum EGeometryScriptBakeSamplesPerPixel : int
    {
        Sample1 = 0,
        Sample4 = 1,
        Sample16 = 2,
        Sample64 = 3,
        Samples256 = 4,
        EGeometryScriptBakeSamplesPerPixel_MAX = 5,
    }
    public enum EGeometryScriptBakeTypes : int
    {
        TangentSpaceNormal = 0,
        ObjectSpaceNormal = 1,
        FaceNormal = 2,
        BentNormal = 3,
        Position = 4,
        Curvature = 5,
        AmbientOcclusion = 6,
        Texture = 7,
        MultiTexture = 8,
        VertexColor = 9,
        MaterialID = 10,
        EGeometryScriptBakeTypes_MAX = 11,
    }
    public enum EGeometryScriptBakeOutputMode : int
    {
        RGBA = 0,
        PerChannel = 1,
        EGeometryScriptBakeOutputMode_MAX = 2,
    }
    public enum EGeometryScriptBakeNormalSpace : int
    {
        Tangent = 0,
        Object = 1,
        EGeometryScriptBakeNormalSpace_MAX = 2,
    }
    public enum EGeometryScriptBakeCurvatureTypeMode : int
    {
        Mean = 0,
        Max = 1,
        Min = 2,
        Gaussian = 3,
    }
    public enum EGeometryScriptBakeCurvatureColorMode : int
    {
        Grayscale = 0,
        RedBlue = 1,
        RedGreenBlue = 2,
        EGeometryScriptBakeCurvatureColorMode_MAX = 3,
    }
    public enum EGeometryScriptBakeCurvatureClampMode : int
    {
        None = 0,
        OnlyPositive = 1,
        OnlyNegative = 2,
        EGeometryScriptBakeCurvatureClampMode_MAX = 3,
    }
    public enum EGeometryScriptCombineAttributesMode : int
    {
        EnableAllMatching = 0,
        UseTarget = 1,
        UseSource = 2,
        EGeometryScriptCombineAttributesMode_MAX = 3,
    }
    public enum EGeometryScriptSmoothBoneWeightsType : int
    {
        DirectDistance = 0,
        GeodesicVoxel = 1,
        EGeometryScriptSmoothBoneWeightsType_MAX = 2,
    }
    public enum EGeometryScriptBooleanOperation : int
    {
        Union = 0,
        Intersection = 1,
        Subtract = 2,
        EGeometryScriptBooleanOperation_MAX = 3,
    }
    public enum EGeometryScriptFlareType : int
    {
        SinMode = 0,
        SinSquaredMode = 1,
        TriangleMode = 2,
        EGeometryScriptFlareType_MAX = 3,
    }
    public enum EGeometryScriptMathWarpType : int
    {
        SinWave1D = 0,
        SinWave2D = 1,
        SinWave3D = 2,
        EGeometryScriptMathWarpType_MAX = 3,
    }
    public enum EGeometryScriptMeshEditPolygroupMode : int
    {
        PreserveExisting = 0,
        AutoGenerateNew = 1,
        SetConstant = 2,
        EGeometryScriptMeshEditPolygroupMode_MAX = 3,
    }
    public enum EGeometryScriptPolyOperationArea : int
    {
        EntireSelection = 0,
        PerPolygroup = 1,
        PerTriangle = 2,
        EGeometryScriptPolyOperationArea_MAX = 3,
    }
    public enum EGeometryScriptLinearExtrudeDirection : int
    {
        FixedDirection = 0,
        AverageFaceNormal = 1,
        EGeometryScriptLinearExtrudeDirection_MAX = 2,
    }
    public enum EGeometryScriptOffsetFacesType : int
    {
        VertexNormal = 0,
        FaceNormal = 1,
        ParallelFaceOffset = 2,
        EGeometryScriptOffsetFacesType_MAX = 3,
    }
    public enum EGeometryScriptMeshBevelSelectionMode : int
    {
        TriangleArea = 0,
        AllPolygroupEdges = 1,
        SharedPolygroupEdges = 2,
        EGeometryScriptMeshBevelSelectionMode_MAX = 3,
    }
    public enum EGeometryScriptTangentTypes : int
    {
        FastMikkT = 0,
        PerTriangle = 1,
        EGeometryScriptTangentTypes_MAX = 2,
    }
    public enum EGeometryScriptPrimitivePolygroupMode : int
    {
        SingleGroup = 0,
        PerFace = 1,
        PerQuad = 2,
        EGeometryScriptPrimitivePolygroupMode_MAX = 3,
    }
    public enum EGeometryScriptPrimitiveOriginMode : int
    {
        Center = 0,
        Base = 1,
        EGeometryScriptPrimitiveOriginMode_MAX = 2,
    }
    public enum EGeometryScriptPrimitiveUVMode : int
    {
        Uniform = 0,
        ScaleToFill = 1,
        EGeometryScriptPrimitiveUVMode_MAX = 2,
    }
    public enum EGeometryScriptUniformRemeshTargetType : int
    {
        TriangleCount = 0,
        TargetEdgeLength = 1,
        EGeometryScriptUniformRemeshTargetType_MAX = 2,
    }
    public enum EGeometryScriptRemeshEdgeConstraintType : int
    {
        Fixed = 0,
        Refine = 1,
        Free = 2,
        Ignore = 3,
        EGeometryScriptRemeshEdgeConstraintType_MAX = 4,
    }
    public enum EGeometryScriptRemeshSmoothingType : int
    {
        Uniform = 0,
        UVPreserving = 1,
        Mixed = 2,
        EGeometryScriptRemeshSmoothingType_MAX = 3,
    }
    public enum EGeometryScriptFillHolesMethod : int
    {
        Automatic = 0,
        MinimalFill = 1,
        PolygonTriangulation = 2,
        TriangleFan = 3,
        PlanarProjection = 4,
        EGeometryScriptFillHolesMethod_MAX = 5,
    }
    public enum EGeometryScriptRemoveHiddenTrianglesMethod : int
    {
        FastWindingNumber = 0,
        RaycastOcclusionTest = 1,
        EGeometryScriptRemoveHiddenTrianglesMethod_MAX = 2,
    }
    public enum EGeometryScriptRepairMeshMode : int
    {
        DeleteOnly = 0,
        RepairOrDelete = 1,
        RepairOrSkip = 2,
        EGeometryScriptRepairMeshMode_MAX = 3,
    }
    public enum EGeometryScriptSamplingWeightMode : int
    {
        WeightToRadius = 0,
        FilledWeightToRadius = 1,
        WeightedRandom = 2,
        EGeometryScriptSamplingWeightMode_MAX = 3,
    }
    public enum EGeometryScriptSamplingDistributionMode : int
    {
        Uniform = 0,
        Smaller = 1,
        Larger = 2,
        EGeometryScriptSamplingDistributionMode_MAX = 3,
    }
    public enum EGeometryScriptTopologyConnectionType : int
    {
        Geometric = 0,
        Polygroup = 1,
        MaterialID = 2,
        EGeometryScriptTopologyConnectionType_MAX = 3,
    }
    public enum EGeometryScriptRemoveMeshSimplificationType : int
    {
        StandardQEM = 0,
        VolumePreserving = 1,
        AttributeAware = 2,
        EGeometryScriptRemoveMeshSimplificationType_MAX = 3,
    }
    public enum ESelectiveTessellatePatternType : int
    {
        ConcentricRings = 0,
        ESelectiveTessellatePatternType_MAX = 1,
    }
    public enum EGeometryScriptUVFlattenMethod : int
    {
        ExpMap = 0,
        Conformal = 1,
        SpectralConformal = 2,
        EGeometryScriptUVFlattenMethod_MAX = 3,
    }
    public enum EGeometryScriptUVIslandSource : int
    {
        PolyGroups = 0,
        UVIslands = 1,
        EGeometryScriptUVIslandSource_MAX = 2,
    }
    public enum EGeometryScriptGridSizingMethod : int
    {
        GridCellSize = 0,
        GridResolution = 1,
        EGeometryScriptGridSizingMethod_MAX = 2,
    }
    public enum EGeometryScriptMorphologicalOpType : int
    {
        Dilate = 0,
        Contract = 1,
        Close = 2,
        Open = 3,
        EGeometryScriptMorphologicalOpType_MAX = 4,
    }
    public enum EGeometryScriptSampleSpacing : int
    {
        UniformDistance = 0,
        UniformTime = 1,
        ErrorTolerance = 2,
        EGeometryScriptSampleSpacing_MAX = 3,
    }
    public enum EGeometryScriptPixelSamplingMethod : int
    {
        Bilinear = 0,
        Nearest = 1,
        EGeometryScriptPixelSamplingMethod_MAX = 2,
    }
    public class GeometryScriptMeshReadLOD : Object
    {
        public GeometryScriptMeshReadLOD(nint addr) : base(addr) { }
        public EGeometryScriptLODType LODType { get { return (EGeometryScriptLODType)this[nameof(LODType)].GetValue<int>(); } set { this[nameof(LODType)].SetValue<int>((int)value); } }
        public int LODIndex { get { return this[nameof(LODIndex)].GetValue<int>(); } set { this[nameof(LODIndex)].SetValue<int>(value); } }
    }
    public class GeometryScriptMeshWriteLOD : Object
    {
        public GeometryScriptMeshWriteLOD(nint addr) : base(addr) { }
        public bool bWriteHiResSource { get { return this[nameof(bWriteHiResSource)].Flag; } set { this[nameof(bWriteHiResSource)].Flag = value; } }
        public int LODIndex { get { return this[nameof(LODIndex)].GetValue<int>(); } set { this[nameof(LODIndex)].SetValue<int>(value); } }
    }
    public class GeometryScriptTriangle : Object
    {
        public GeometryScriptTriangle(nint addr) : base(addr) { }
        public Vector Vector0 { get { return this[nameof(Vector0)].As<Vector>(); } set { this["Vector0"] = value; } }
        public Vector Vector1 { get { return this[nameof(Vector1)].As<Vector>(); } set { this["Vector1"] = value; } }
        public Vector Vector2 { get { return this[nameof(Vector2)].As<Vector>(); } set { this["Vector2"] = value; } }
    }
    public class GeometryScriptTrianglePoint : Object
    {
        public GeometryScriptTrianglePoint(nint addr) : base(addr) { }
        public bool bValid { get { return this[nameof(bValid)].Flag; } set { this[nameof(bValid)].Flag = value; } }
        public int TriangleID { get { return this[nameof(TriangleID)].GetValue<int>(); } set { this[nameof(TriangleID)].SetValue<int>(value); } }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public Vector BaryCoords { get { return this[nameof(BaryCoords)].As<Vector>(); } set { this["BaryCoords"] = value; } }
    }
    public class GeometryScriptUVTriangle : Object
    {
        public GeometryScriptUVTriangle(nint addr) : base(addr) { }
        public Vector2D UV0 { get { return this[nameof(UV0)].As<Vector2D>(); } set { this["UV0"] = value; } }
        public Vector2D UV1 { get { return this[nameof(UV1)].As<Vector2D>(); } set { this["UV1"] = value; } }
        public Vector2D UV2 { get { return this[nameof(UV2)].As<Vector2D>(); } set { this["UV2"] = value; } }
    }
    public class GeometryScriptColorFlags : Object
    {
        public GeometryScriptColorFlags(nint addr) : base(addr) { }
        public bool bRed { get { return this[nameof(bRed)].Flag; } set { this[nameof(bRed)].Flag = value; } }
        public bool bGreen { get { return this[nameof(bGreen)].Flag; } set { this[nameof(bGreen)].Flag = value; } }
        public bool bBlue { get { return this[nameof(bBlue)].Flag; } set { this[nameof(bBlue)].Flag = value; } }
        public bool bAlpha { get { return this[nameof(bAlpha)].Flag; } set { this[nameof(bAlpha)].Flag = value; } }
    }
    public class GeometryScriptGroupLayer : Object
    {
        public GeometryScriptGroupLayer(nint addr) : base(addr) { }
        public bool bDefaultLayer { get { return this[nameof(bDefaultLayer)].Flag; } set { this[nameof(bDefaultLayer)].Flag = value; } }
        public int ExtendedLayerIndex { get { return this[nameof(ExtendedLayerIndex)].GetValue<int>(); } set { this[nameof(ExtendedLayerIndex)].SetValue<int>(value); } }
    }
    public class GeometryScriptIndexList : Object
    {
        public GeometryScriptIndexList(nint addr) : base(addr) { }
        public EGeometryScriptIndexType IndexType { get { return (EGeometryScriptIndexType)this[nameof(IndexType)].GetValue<int>(); } set { this[nameof(IndexType)].SetValue<int>((int)value); } }
    }
    public class GeometryScriptTriangleList : Object
    {
        public GeometryScriptTriangleList(nint addr) : base(addr) { }
    }
    public class GeometryScriptScalarList : Object
    {
        public GeometryScriptScalarList(nint addr) : base(addr) { }
    }
    public class GeometryScriptVectorList : Object
    {
        public GeometryScriptVectorList(nint addr) : base(addr) { }
    }
    public class GeometryScriptUVList : Object
    {
        public GeometryScriptUVList(nint addr) : base(addr) { }
    }
    public class GeometryScriptColorList : Object
    {
        public GeometryScriptColorList(nint addr) : base(addr) { }
    }
    public class GeometryScriptPolyPath : Object
    {
        public GeometryScriptPolyPath(nint addr) : base(addr) { }
        public bool bClosedLoop { get { return this[nameof(bClosedLoop)].Flag; } set { this[nameof(bClosedLoop)].Flag = value; } }
    }
    public class GeometryScriptDynamicMeshBVH : Object
    {
        public GeometryScriptDynamicMeshBVH(nint addr) : base(addr) { }
    }
    public class GeometryScriptDebugMessage : Object
    {
        public GeometryScriptDebugMessage(nint addr) : base(addr) { }
        public EGeometryScriptDebugMessageType MessageType { get { return (EGeometryScriptDebugMessageType)this[nameof(MessageType)].GetValue<int>(); } set { this[nameof(MessageType)].SetValue<int>((int)value); } }
        public EGeometryScriptErrorType ErrorType { get { return (EGeometryScriptErrorType)this[nameof(ErrorType)].GetValue<int>(); } set { this[nameof(ErrorType)].SetValue<int>((int)value); } }
        public Object Message { get { return this[nameof(Message)]; } set { this[nameof(Message)] = value; } }
    }
    public class GeometryScriptCollisionFromMeshOptions : Object
    {
        public GeometryScriptCollisionFromMeshOptions(nint addr) : base(addr) { }
        public bool bEmitTransaction { get { return this[nameof(bEmitTransaction)].Flag; } set { this[nameof(bEmitTransaction)].Flag = value; } }
        public EGeometryScriptCollisionGenerationMethod Method { get { return (EGeometryScriptCollisionGenerationMethod)this[nameof(Method)].GetValue<int>(); } set { this[nameof(Method)].SetValue<int>((int)value); } }
        public bool bAutoDetectSpheres { get { return this[nameof(bAutoDetectSpheres)].Flag; } set { this[nameof(bAutoDetectSpheres)].Flag = value; } }
        public bool bAutoDetectBoxes { get { return this[nameof(bAutoDetectBoxes)].Flag; } set { this[nameof(bAutoDetectBoxes)].Flag = value; } }
        public bool bAutoDetectCapsules { get { return this[nameof(bAutoDetectCapsules)].Flag; } set { this[nameof(bAutoDetectCapsules)].Flag = value; } }
        public float MinThickness { get { return this[nameof(MinThickness)].GetValue<float>(); } set { this[nameof(MinThickness)].SetValue<float>(value); } }
        public bool bSimplifyHulls { get { return this[nameof(bSimplifyHulls)].Flag; } set { this[nameof(bSimplifyHulls)].Flag = value; } }
        public int ConvexHullTargetFaceCount { get { return this[nameof(ConvexHullTargetFaceCount)].GetValue<int>(); } set { this[nameof(ConvexHullTargetFaceCount)].SetValue<int>(value); } }
        public int MaxConvexHullsPerMesh { get { return this[nameof(MaxConvexHullsPerMesh)].GetValue<int>(); } set { this[nameof(MaxConvexHullsPerMesh)].SetValue<int>(value); } }
        public float ConvexDecompositionSearchFactor { get { return this[nameof(ConvexDecompositionSearchFactor)].GetValue<float>(); } set { this[nameof(ConvexDecompositionSearchFactor)].SetValue<float>(value); } }
        public float ConvexDecompositionErrorTolerance { get { return this[nameof(ConvexDecompositionErrorTolerance)].GetValue<float>(); } set { this[nameof(ConvexDecompositionErrorTolerance)].SetValue<float>(value); } }
        public float ConvexDecompositionMinPartThickness { get { return this[nameof(ConvexDecompositionMinPartThickness)].GetValue<float>(); } set { this[nameof(ConvexDecompositionMinPartThickness)].SetValue<float>(value); } }
        public float SweptHullSimplifyTolerance { get { return this[nameof(SweptHullSimplifyTolerance)].GetValue<float>(); } set { this[nameof(SweptHullSimplifyTolerance)].SetValue<float>(value); } }
        public EGeometryScriptSweptHullAxis SweptHullAxis { get { return (EGeometryScriptSweptHullAxis)this[nameof(SweptHullAxis)].GetValue<int>(); } set { this[nameof(SweptHullAxis)].SetValue<int>((int)value); } }
        public bool bRemoveFullyContainedShapes { get { return this[nameof(bRemoveFullyContainedShapes)].Flag; } set { this[nameof(bRemoveFullyContainedShapes)].Flag = value; } }
        public int MaxShapeCount { get { return this[nameof(MaxShapeCount)].GetValue<int>(); } set { this[nameof(MaxShapeCount)].SetValue<int>(value); } }
    }
    public class GeometryScriptSetSimpleCollisionOptions : Object
    {
        public GeometryScriptSetSimpleCollisionOptions(nint addr) : base(addr) { }
        public bool bEmitTransaction { get { return this[nameof(bEmitTransaction)].Flag; } set { this[nameof(bEmitTransaction)].Flag = value; } }
    }
    public class GeometryScriptConvexHullOptions : Object
    {
        public GeometryScriptConvexHullOptions(nint addr) : base(addr) { }
        public bool bPrefilterVertices { get { return this[nameof(bPrefilterVertices)].Flag; } set { this[nameof(bPrefilterVertices)].Flag = value; } }
        public int PrefilterGridResolution { get { return this[nameof(PrefilterGridResolution)].GetValue<int>(); } set { this[nameof(PrefilterGridResolution)].SetValue<int>(value); } }
        public int SimplifyToFaceCount { get { return this[nameof(SimplifyToFaceCount)].GetValue<int>(); } set { this[nameof(SimplifyToFaceCount)].SetValue<int>(value); } }
    }
    public class GeometryScriptSweptHullOptions : Object
    {
        public GeometryScriptSweptHullOptions(nint addr) : base(addr) { }
        public bool bPrefilterVertices { get { return this[nameof(bPrefilterVertices)].Flag; } set { this[nameof(bPrefilterVertices)].Flag = value; } }
        public int PrefilterGridResolution { get { return this[nameof(PrefilterGridResolution)].GetValue<int>(); } set { this[nameof(PrefilterGridResolution)].SetValue<int>(value); } }
        public float MinThickness { get { return this[nameof(MinThickness)].GetValue<float>(); } set { this[nameof(MinThickness)].SetValue<float>(value); } }
        public bool bSimplify { get { return this[nameof(bSimplify)].Flag; } set { this[nameof(bSimplify)].Flag = value; } }
        public float MinEdgeLength { get { return this[nameof(MinEdgeLength)].GetValue<float>(); } set { this[nameof(MinEdgeLength)].SetValue<float>(value); } }
        public float SimplifyTolerance { get { return this[nameof(SimplifyTolerance)].GetValue<float>(); } set { this[nameof(SimplifyTolerance)].SetValue<float>(value); } }
    }
    public class GeometryScriptConvexDecompositionOptions : Object
    {
        public GeometryScriptConvexDecompositionOptions(nint addr) : base(addr) { }
        public int NumHulls { get { return this[nameof(NumHulls)].GetValue<int>(); } set { this[nameof(NumHulls)].SetValue<int>(value); } }
        public double SearchFactor { get { return this[nameof(SearchFactor)].GetValue<double>(); } set { this[nameof(SearchFactor)].SetValue<double>(value); } }
        public double ErrorTolerance { get { return this[nameof(ErrorTolerance)].GetValue<double>(); } set { this[nameof(ErrorTolerance)].SetValue<double>(value); } }
        public double MinPartThickness { get { return this[nameof(MinPartThickness)].GetValue<double>(); } set { this[nameof(MinPartThickness)].SetValue<double>(value); } }
        public int SimplifyToFaceCount { get { return this[nameof(SimplifyToFaceCount)].GetValue<int>(); } set { this[nameof(SimplifyToFaceCount)].SetValue<int>(value); } }
    }
    public class GeometryScriptMeshSelection : Object
    {
        public GeometryScriptMeshSelection(nint addr) : base(addr) { }
    }
    public class GeometryScriptCopyMeshFromAssetOptions : Object
    {
        public GeometryScriptCopyMeshFromAssetOptions(nint addr) : base(addr) { }
        public bool bApplyBuildSettings { get { return this[nameof(bApplyBuildSettings)].Flag; } set { this[nameof(bApplyBuildSettings)].Flag = value; } }
        public bool bRequestTangents { get { return this[nameof(bRequestTangents)].Flag; } set { this[nameof(bRequestTangents)].Flag = value; } }
        public bool bIgnoreRemoveDegenerates { get { return this[nameof(bIgnoreRemoveDegenerates)].Flag; } set { this[nameof(bIgnoreRemoveDegenerates)].Flag = value; } }
    }
    public class GeometryScriptNaniteOptions : Object
    {
        public GeometryScriptNaniteOptions(nint addr) : base(addr) { }
        public bool bEnabled { get { return this[nameof(bEnabled)].Flag; } set { this[nameof(bEnabled)].Flag = value; } }
        public float FallbackPercentTriangles { get { return this[nameof(FallbackPercentTriangles)].GetValue<float>(); } set { this[nameof(FallbackPercentTriangles)].SetValue<float>(value); } }
        public float FallbackRelativeError { get { return this[nameof(FallbackRelativeError)].GetValue<float>(); } set { this[nameof(FallbackRelativeError)].SetValue<float>(value); } }
    }
    public class GeometryScriptCopyMeshToAssetOptions : Object
    {
        public GeometryScriptCopyMeshToAssetOptions(nint addr) : base(addr) { }
        public bool bEnableRecomputeNormals { get { return this[nameof(bEnableRecomputeNormals)].Flag; } set { this[nameof(bEnableRecomputeNormals)].Flag = value; } }
        public bool bEnableRecomputeTangents { get { return this[nameof(bEnableRecomputeTangents)].Flag; } set { this[nameof(bEnableRecomputeTangents)].Flag = value; } }
        public bool bEnableRemoveDegenerates { get { return this[nameof(bEnableRemoveDegenerates)].Flag; } set { this[nameof(bEnableRemoveDegenerates)].Flag = value; } }
        public bool bReplaceMaterials { get { return this[nameof(bReplaceMaterials)].Flag; } set { this[nameof(bReplaceMaterials)].Flag = value; } }
        public Array<MaterialInterface> NewMaterials { get { return new Array<MaterialInterface>(this[nameof(NewMaterials)].Address); } }
        public Array<Object> NewMaterialSlotNames { get { return new Array<Object>(this[nameof(NewMaterialSlotNames)].Address); } }
        public bool bApplyNaniteSettings { get { return this[nameof(bApplyNaniteSettings)].Flag; } set { this[nameof(bApplyNaniteSettings)].Flag = value; } }
        public GeometryScriptNaniteOptions NaniteSettings { get { return this[nameof(NaniteSettings)].As<GeometryScriptNaniteOptions>(); } set { this["NaniteSettings"] = value; } }
        public MeshNaniteSettings NewNaniteSettings { get { return this[nameof(NewNaniteSettings)].As<MeshNaniteSettings>(); } set { this["NewNaniteSettings"] = value; } }
        public bool bEmitTransaction { get { return this[nameof(bEmitTransaction)].Flag; } set { this[nameof(bEmitTransaction)].Flag = value; } }
        public bool bDeferMeshPostEditChange { get { return this[nameof(bDeferMeshPostEditChange)].Flag; } set { this[nameof(bDeferMeshPostEditChange)].Flag = value; } }
    }
    public class GeometryScriptBakeTypeOptions : Object
    {
        public GeometryScriptBakeTypeOptions(nint addr) : base(addr) { }
        public EGeometryScriptBakeTypes BakeType { get { return (EGeometryScriptBakeTypes)this[nameof(BakeType)].GetValue<int>(); } set { this[nameof(BakeType)].SetValue<int>((int)value); } }
    }
    public class GeometryScriptBakeTextureOptions : Object
    {
        public GeometryScriptBakeTextureOptions(nint addr) : base(addr) { }
        public EGeometryScriptBakeResolution Resolution { get { return (EGeometryScriptBakeResolution)this[nameof(Resolution)].GetValue<int>(); } set { this[nameof(Resolution)].SetValue<int>((int)value); } }
        public EGeometryScriptBakeBitDepth BitDepth { get { return (EGeometryScriptBakeBitDepth)this[nameof(BitDepth)].GetValue<int>(); } set { this[nameof(BitDepth)].SetValue<int>((int)value); } }
        public EGeometryScriptBakeSamplesPerPixel SamplesPerPixel { get { return (EGeometryScriptBakeSamplesPerPixel)this[nameof(SamplesPerPixel)].GetValue<int>(); } set { this[nameof(SamplesPerPixel)].SetValue<int>((int)value); } }
        public Texture2D SampleFilterMask { get { return this[nameof(SampleFilterMask)].As<Texture2D>(); } set { this["SampleFilterMask"] = value; } }
        public float ProjectionDistance { get { return this[nameof(ProjectionDistance)].GetValue<float>(); } set { this[nameof(ProjectionDistance)].SetValue<float>(value); } }
        public bool bProjectionInWorldSpace { get { return this[nameof(bProjectionInWorldSpace)].Flag; } set { this[nameof(bProjectionInWorldSpace)].Flag = value; } }
    }
    public class GeometryScriptBakeVertexOptions : Object
    {
        public GeometryScriptBakeVertexOptions(nint addr) : base(addr) { }
        public bool bSplitAtNormalSeams { get { return this[nameof(bSplitAtNormalSeams)].Flag; } set { this[nameof(bSplitAtNormalSeams)].Flag = value; } }
        public bool bSplitAtUVSeams { get { return this[nameof(bSplitAtUVSeams)].Flag; } set { this[nameof(bSplitAtUVSeams)].Flag = value; } }
        public float ProjectionDistance { get { return this[nameof(ProjectionDistance)].GetValue<float>(); } set { this[nameof(ProjectionDistance)].SetValue<float>(value); } }
        public bool bProjectionInWorldSpace { get { return this[nameof(bProjectionInWorldSpace)].Flag; } set { this[nameof(bProjectionInWorldSpace)].Flag = value; } }
    }
    public class GeometryScriptBakeOutputType : Object
    {
        public GeometryScriptBakeOutputType(nint addr) : base(addr) { }
        public EGeometryScriptBakeOutputMode OutputMode { get { return (EGeometryScriptBakeOutputMode)this[nameof(OutputMode)].GetValue<int>(); } set { this[nameof(OutputMode)].SetValue<int>((int)value); } }
        public GeometryScriptBakeTypeOptions RGBA { get { return this[nameof(RGBA)].As<GeometryScriptBakeTypeOptions>(); } set { this["RGBA"] = value; } }
        public GeometryScriptBakeTypeOptions R { get { return this[nameof(R)].As<GeometryScriptBakeTypeOptions>(); } set { this["R"] = value; } }
        public GeometryScriptBakeTypeOptions G { get { return this[nameof(G)].As<GeometryScriptBakeTypeOptions>(); } set { this["G"] = value; } }
        public GeometryScriptBakeTypeOptions B { get { return this[nameof(B)].As<GeometryScriptBakeTypeOptions>(); } set { this["B"] = value; } }
        public GeometryScriptBakeTypeOptions A { get { return this[nameof(A)].As<GeometryScriptBakeTypeOptions>(); } set { this["A"] = value; } }
    }
    public class GeometryScriptBakeTargetMeshOptions : Object
    {
        public GeometryScriptBakeTargetMeshOptions(nint addr) : base(addr) { }
        public int TargetUVLayer { get { return this[nameof(TargetUVLayer)].GetValue<int>(); } set { this[nameof(TargetUVLayer)].SetValue<int>(value); } }
    }
    public class GeometryScriptBakeSourceMeshOptions : Object
    {
        public GeometryScriptBakeSourceMeshOptions(nint addr) : base(addr) { }
        public Texture2D SourceNormalMap { get { return this[nameof(SourceNormalMap)].As<Texture2D>(); } set { this["SourceNormalMap"] = value; } }
        public int SourceNormalUVLayer { get { return this[nameof(SourceNormalUVLayer)].GetValue<int>(); } set { this[nameof(SourceNormalUVLayer)].SetValue<int>(value); } }
        public EGeometryScriptBakeNormalSpace SourceNormalSpace { get { return (EGeometryScriptBakeNormalSpace)this[nameof(SourceNormalSpace)].GetValue<int>(); } set { this[nameof(SourceNormalSpace)].SetValue<int>((int)value); } }
    }
    public class GeometryScriptBakeRenderCaptureOptions : Object
    {
        public GeometryScriptBakeRenderCaptureOptions(nint addr) : base(addr) { }
        public EGeometryScriptBakeResolution Resolution { get { return (EGeometryScriptBakeResolution)this[nameof(Resolution)].GetValue<int>(); } set { this[nameof(Resolution)].SetValue<int>((int)value); } }
        public EGeometryScriptBakeResolution RenderCaptureResolution { get { return (EGeometryScriptBakeResolution)this[nameof(RenderCaptureResolution)].GetValue<int>(); } set { this[nameof(RenderCaptureResolution)].SetValue<int>((int)value); } }
        public EGeometryScriptBakeSamplesPerPixel SamplesPerPixel { get { return (EGeometryScriptBakeSamplesPerPixel)this[nameof(SamplesPerPixel)].GetValue<int>(); } set { this[nameof(SamplesPerPixel)].SetValue<int>((int)value); } }
        public bool bRenderCaptureAntiAliasing { get { return this[nameof(bRenderCaptureAntiAliasing)].Flag; } set { this[nameof(bRenderCaptureAntiAliasing)].Flag = value; } }
        public float CleanupTolerance { get { return this[nameof(CleanupTolerance)].GetValue<float>(); } set { this[nameof(CleanupTolerance)].SetValue<float>(value); } }
        public bool bBaseColorMap { get { return this[nameof(bBaseColorMap)].Flag; } set { this[nameof(bBaseColorMap)].Flag = value; } }
        public bool bNormalMap { get { return this[nameof(bNormalMap)].Flag; } set { this[nameof(bNormalMap)].Flag = value; } }
        public bool bPackedMRSMap { get { return this[nameof(bPackedMRSMap)].Flag; } set { this[nameof(bPackedMRSMap)].Flag = value; } }
        public bool bMetallicMap { get { return this[nameof(bMetallicMap)].Flag; } set { this[nameof(bMetallicMap)].Flag = value; } }
        public bool bRoughnessMap { get { return this[nameof(bRoughnessMap)].Flag; } set { this[nameof(bRoughnessMap)].Flag = value; } }
        public bool bSpecularMap { get { return this[nameof(bSpecularMap)].Flag; } set { this[nameof(bSpecularMap)].Flag = value; } }
        public bool bEmissiveMap { get { return this[nameof(bEmissiveMap)].Flag; } set { this[nameof(bEmissiveMap)].Flag = value; } }
        public bool bOpacityMap { get { return this[nameof(bOpacityMap)].Flag; } set { this[nameof(bOpacityMap)].Flag = value; } }
        public bool bSubsurfaceColorMap { get { return this[nameof(bSubsurfaceColorMap)].Flag; } set { this[nameof(bSubsurfaceColorMap)].Flag = value; } }
        public double FieldOfViewDegrees { get { return this[nameof(FieldOfViewDegrees)].GetValue<double>(); } set { this[nameof(FieldOfViewDegrees)].SetValue<double>(value); } }
        public double NearPlaneDist { get { return this[nameof(NearPlaneDist)].GetValue<double>(); } set { this[nameof(NearPlaneDist)].SetValue<double>(value); } }
    }
    public class GeometryScriptRenderCaptureTextures : Object
    {
        public GeometryScriptRenderCaptureTextures(nint addr) : base(addr) { }
        public Texture2D BaseColorMap { get { return this[nameof(BaseColorMap)].As<Texture2D>(); } set { this["BaseColorMap"] = value; } }
        public bool bHasBaseColorMap { get { return this[nameof(bHasBaseColorMap)].Flag; } set { this[nameof(bHasBaseColorMap)].Flag = value; } }
        public Texture2D NormalMap { get { return this[nameof(NormalMap)].As<Texture2D>(); } set { this["NormalMap"] = value; } }
        public bool bHasNormalMap { get { return this[nameof(bHasNormalMap)].Flag; } set { this[nameof(bHasNormalMap)].Flag = value; } }
        public Texture2D PackedMRSMap { get { return this[nameof(PackedMRSMap)].As<Texture2D>(); } set { this["PackedMRSMap"] = value; } }
        public bool bHasPackedMRSMap { get { return this[nameof(bHasPackedMRSMap)].Flag; } set { this[nameof(bHasPackedMRSMap)].Flag = value; } }
        public Texture2D MetallicMap { get { return this[nameof(MetallicMap)].As<Texture2D>(); } set { this["MetallicMap"] = value; } }
        public bool bHasMetallicMap { get { return this[nameof(bHasMetallicMap)].Flag; } set { this[nameof(bHasMetallicMap)].Flag = value; } }
        public Texture2D RoughnessMap { get { return this[nameof(RoughnessMap)].As<Texture2D>(); } set { this["RoughnessMap"] = value; } }
        public bool bHasRoughnessMap { get { return this[nameof(bHasRoughnessMap)].Flag; } set { this[nameof(bHasRoughnessMap)].Flag = value; } }
        public Texture2D SpecularMap { get { return this[nameof(SpecularMap)].As<Texture2D>(); } set { this["SpecularMap"] = value; } }
        public bool bHasSpecularMap { get { return this[nameof(bHasSpecularMap)].Flag; } set { this[nameof(bHasSpecularMap)].Flag = value; } }
        public Texture2D EmissiveMap { get { return this[nameof(EmissiveMap)].As<Texture2D>(); } set { this["EmissiveMap"] = value; } }
        public bool bHasEmissiveMap { get { return this[nameof(bHasEmissiveMap)].Flag; } set { this[nameof(bHasEmissiveMap)].Flag = value; } }
        public Texture2D OpacityMap { get { return this[nameof(OpacityMap)].As<Texture2D>(); } set { this["OpacityMap"] = value; } }
        public bool bHasOpacityMap { get { return this[nameof(bHasOpacityMap)].Flag; } set { this[nameof(bHasOpacityMap)].Flag = value; } }
        public Texture2D SubsurfaceColorMap { get { return this[nameof(SubsurfaceColorMap)].As<Texture2D>(); } set { this["SubsurfaceColorMap"] = value; } }
        public bool bHasSubsurfaceColorMap { get { return this[nameof(bHasSubsurfaceColorMap)].Flag; } set { this[nameof(bHasSubsurfaceColorMap)].Flag = value; } }
    }
    public class GeometryScriptSimpleMeshBuffers : Object
    {
        public GeometryScriptSimpleMeshBuffers(nint addr) : base(addr) { }
        public Array<Vector> Vertices { get { return new Array<Vector>(this[nameof(Vertices)].Address); } }
        public Array<Vector> Normals { get { return new Array<Vector>(this[nameof(Normals)].Address); } }
        public Array<Vector2D> UV0 { get { return new Array<Vector2D>(this[nameof(UV0)].Address); } }
        public Array<Vector2D> UV1 { get { return new Array<Vector2D>(this[nameof(UV1)].Address); } }
        public Array<Vector2D> UV2 { get { return new Array<Vector2D>(this[nameof(UV2)].Address); } }
        public Array<Vector2D> UV3 { get { return new Array<Vector2D>(this[nameof(UV3)].Address); } }
        public Array<Vector2D> UV4 { get { return new Array<Vector2D>(this[nameof(UV4)].Address); } }
        public Array<Vector2D> UV5 { get { return new Array<Vector2D>(this[nameof(UV5)].Address); } }
        public Array<Vector2D> UV6 { get { return new Array<Vector2D>(this[nameof(UV6)].Address); } }
        public Array<Vector2D> UV7 { get { return new Array<Vector2D>(this[nameof(UV7)].Address); } }
        public Array<LinearColor> VertexColors { get { return new Array<LinearColor>(this[nameof(VertexColors)].Address); } }
        public Array<IntVector> Triangles { get { return new Array<IntVector>(this[nameof(Triangles)].Address); } }
        public Array<int> TriGroupIDs { get { return new Array<int>(this[nameof(TriGroupIDs)].Address); } }
    }
    public class GeometryScriptAppendMeshOptions : Object
    {
        public GeometryScriptAppendMeshOptions(nint addr) : base(addr) { }
        public EGeometryScriptCombineAttributesMode CombineMode { get { return (EGeometryScriptCombineAttributesMode)this[nameof(CombineMode)].GetValue<int>(); } set { this[nameof(CombineMode)].SetValue<int>((int)value); } }
    }
    public class GeometryScriptBoneWeight : Object
    {
        public GeometryScriptBoneWeight(nint addr) : base(addr) { }
        public int BoneIndex { get { return this[nameof(BoneIndex)].GetValue<int>(); } set { this[nameof(BoneIndex)].SetValue<int>(value); } }
        public float Weight { get { return this[nameof(Weight)].GetValue<float>(); } set { this[nameof(Weight)].SetValue<float>(value); } }
    }
    public class GeometryScriptBoneWeightProfile : Object
    {
        public GeometryScriptBoneWeightProfile(nint addr) : base(addr) { }
        public Object ProfileName { get { return this[nameof(ProfileName)]; } set { this[nameof(ProfileName)] = value; } }
    }
    public class GeometryScriptSmoothBoneWeightsOptions : Object
    {
        public GeometryScriptSmoothBoneWeightsOptions(nint addr) : base(addr) { }
        public EGeometryScriptSmoothBoneWeightsType DistanceWeighingType { get { return (EGeometryScriptSmoothBoneWeightsType)this[nameof(DistanceWeighingType)].GetValue<int>(); } set { this[nameof(DistanceWeighingType)].SetValue<int>((int)value); } }
        public float Stiffness { get { return this[nameof(Stiffness)].GetValue<float>(); } set { this[nameof(Stiffness)].SetValue<float>(value); } }
        public int MaxInfluences { get { return this[nameof(MaxInfluences)].GetValue<int>(); } set { this[nameof(MaxInfluences)].SetValue<int>(value); } }
        public int VoxelResolution { get { return this[nameof(VoxelResolution)].GetValue<int>(); } set { this[nameof(VoxelResolution)].SetValue<int>(value); } }
    }
    public class GeometryScriptMeshBooleanOptions : Object
    {
        public GeometryScriptMeshBooleanOptions(nint addr) : base(addr) { }
        public bool bFillHoles { get { return this[nameof(bFillHoles)].Flag; } set { this[nameof(bFillHoles)].Flag = value; } }
        public bool bSimplifyOutput { get { return this[nameof(bSimplifyOutput)].Flag; } set { this[nameof(bSimplifyOutput)].Flag = value; } }
        public float SimplifyPlanarTolerance { get { return this[nameof(SimplifyPlanarTolerance)].GetValue<float>(); } set { this[nameof(SimplifyPlanarTolerance)].SetValue<float>(value); } }
    }
    public class GeometryScriptMeshSelfUnionOptions : Object
    {
        public GeometryScriptMeshSelfUnionOptions(nint addr) : base(addr) { }
        public bool bFillHoles { get { return this[nameof(bFillHoles)].Flag; } set { this[nameof(bFillHoles)].Flag = value; } }
        public bool bTrimFlaps { get { return this[nameof(bTrimFlaps)].Flag; } set { this[nameof(bTrimFlaps)].Flag = value; } }
        public bool bSimplifyOutput { get { return this[nameof(bSimplifyOutput)].Flag; } set { this[nameof(bSimplifyOutput)].Flag = value; } }
        public float SimplifyPlanarTolerance { get { return this[nameof(SimplifyPlanarTolerance)].GetValue<float>(); } set { this[nameof(SimplifyPlanarTolerance)].SetValue<float>(value); } }
        public float WindingThreshold { get { return this[nameof(WindingThreshold)].GetValue<float>(); } set { this[nameof(WindingThreshold)].SetValue<float>(value); } }
    }
    public class GeometryScriptMeshPlaneCutOptions : Object
    {
        public GeometryScriptMeshPlaneCutOptions(nint addr) : base(addr) { }
        public bool bFillHoles { get { return this[nameof(bFillHoles)].Flag; } set { this[nameof(bFillHoles)].Flag = value; } }
        public bool bFillSpans { get { return this[nameof(bFillSpans)].Flag; } set { this[nameof(bFillSpans)].Flag = value; } }
        public bool bFlipCutSide { get { return this[nameof(bFlipCutSide)].Flag; } set { this[nameof(bFlipCutSide)].Flag = value; } }
        public float UVWorldDimension { get { return this[nameof(UVWorldDimension)].GetValue<float>(); } set { this[nameof(UVWorldDimension)].SetValue<float>(value); } }
    }
    public class GeometryScriptMeshPlaneSliceOptions : Object
    {
        public GeometryScriptMeshPlaneSliceOptions(nint addr) : base(addr) { }
        public bool bFillHoles { get { return this[nameof(bFillHoles)].Flag; } set { this[nameof(bFillHoles)].Flag = value; } }
        public bool bFillSpans { get { return this[nameof(bFillSpans)].Flag; } set { this[nameof(bFillSpans)].Flag = value; } }
        public float GapWidth { get { return this[nameof(GapWidth)].GetValue<float>(); } set { this[nameof(GapWidth)].SetValue<float>(value); } }
        public float UVWorldDimension { get { return this[nameof(UVWorldDimension)].GetValue<float>(); } set { this[nameof(UVWorldDimension)].SetValue<float>(value); } }
    }
    public class GeometryScriptMeshMirrorOptions : Object
    {
        public GeometryScriptMeshMirrorOptions(nint addr) : base(addr) { }
        public bool bApplyPlaneCut { get { return this[nameof(bApplyPlaneCut)].Flag; } set { this[nameof(bApplyPlaneCut)].Flag = value; } }
        public bool bFlipCutSide { get { return this[nameof(bFlipCutSide)].Flag; } set { this[nameof(bFlipCutSide)].Flag = value; } }
        public bool bWeldAlongPlane { get { return this[nameof(bWeldAlongPlane)].Flag; } set { this[nameof(bWeldAlongPlane)].Flag = value; } }
    }
    public class GeometryScriptIsSameMeshOptions : Object
    {
        public GeometryScriptIsSameMeshOptions(nint addr) : base(addr) { }
        public bool bCheckConnectivity { get { return this[nameof(bCheckConnectivity)].Flag; } set { this[nameof(bCheckConnectivity)].Flag = value; } }
        public bool bCheckEdgeIDs { get { return this[nameof(bCheckEdgeIDs)].Flag; } set { this[nameof(bCheckEdgeIDs)].Flag = value; } }
        public bool bCheckNormals { get { return this[nameof(bCheckNormals)].Flag; } set { this[nameof(bCheckNormals)].Flag = value; } }
        public bool bCheckColors { get { return this[nameof(bCheckColors)].Flag; } set { this[nameof(bCheckColors)].Flag = value; } }
        public bool bCheckUVs { get { return this[nameof(bCheckUVs)].Flag; } set { this[nameof(bCheckUVs)].Flag = value; } }
        public bool bCheckGroups { get { return this[nameof(bCheckGroups)].Flag; } set { this[nameof(bCheckGroups)].Flag = value; } }
        public bool bCheckAttributes { get { return this[nameof(bCheckAttributes)].Flag; } set { this[nameof(bCheckAttributes)].Flag = value; } }
        public float Epsilon { get { return this[nameof(Epsilon)].GetValue<float>(); } set { this[nameof(Epsilon)].SetValue<float>(value); } }
    }
    public class GeometryScriptMeasureMeshDistanceOptions : Object
    {
        public GeometryScriptMeasureMeshDistanceOptions(nint addr) : base(addr) { }
        public bool bSymmetric { get { return this[nameof(bSymmetric)].Flag; } set { this[nameof(bSymmetric)].Flag = value; } }
    }
    public class GeometryScriptBendWarpOptions : Object
    {
        public GeometryScriptBendWarpOptions(nint addr) : base(addr) { }
        public bool bSymmetricExtents { get { return this[nameof(bSymmetricExtents)].Flag; } set { this[nameof(bSymmetricExtents)].Flag = value; } }
        public float LowerExtent { get { return this[nameof(LowerExtent)].GetValue<float>(); } set { this[nameof(LowerExtent)].SetValue<float>(value); } }
        public bool bBidirectional { get { return this[nameof(bBidirectional)].Flag; } set { this[nameof(bBidirectional)].Flag = value; } }
    }
    public class GeometryScriptTwistWarpOptions : Object
    {
        public GeometryScriptTwistWarpOptions(nint addr) : base(addr) { }
        public bool bSymmetricExtents { get { return this[nameof(bSymmetricExtents)].Flag; } set { this[nameof(bSymmetricExtents)].Flag = value; } }
        public float LowerExtent { get { return this[nameof(LowerExtent)].GetValue<float>(); } set { this[nameof(LowerExtent)].SetValue<float>(value); } }
        public bool bBidirectional { get { return this[nameof(bBidirectional)].Flag; } set { this[nameof(bBidirectional)].Flag = value; } }
    }
    public class GeometryScriptFlareWarpOptions : Object
    {
        public GeometryScriptFlareWarpOptions(nint addr) : base(addr) { }
        public bool bSymmetricExtents { get { return this[nameof(bSymmetricExtents)].Flag; } set { this[nameof(bSymmetricExtents)].Flag = value; } }
        public float LowerExtent { get { return this[nameof(LowerExtent)].GetValue<float>(); } set { this[nameof(LowerExtent)].SetValue<float>(value); } }
        public EGeometryScriptFlareType FlareType { get { return (EGeometryScriptFlareType)this[nameof(FlareType)].GetValue<int>(); } set { this[nameof(FlareType)].SetValue<int>((int)value); } }
    }
    public class GeometryScriptPerlinNoiseLayerOptions : Object
    {
        public GeometryScriptPerlinNoiseLayerOptions(nint addr) : base(addr) { }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public float Frequency { get { return this[nameof(Frequency)].GetValue<float>(); } set { this[nameof(Frequency)].SetValue<float>(value); } }
        public Vector FrequencyShift { get { return this[nameof(FrequencyShift)].As<Vector>(); } set { this["FrequencyShift"] = value; } }
        public int RandomSeed { get { return this[nameof(RandomSeed)].GetValue<int>(); } set { this[nameof(RandomSeed)].SetValue<int>(value); } }
    }
    public class GeometryScriptMathWarpOptions : Object
    {
        public GeometryScriptMathWarpOptions(nint addr) : base(addr) { }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public float Frequency { get { return this[nameof(Frequency)].GetValue<float>(); } set { this[nameof(Frequency)].SetValue<float>(value); } }
        public float FrequencyShift { get { return this[nameof(FrequencyShift)].GetValue<float>(); } set { this[nameof(FrequencyShift)].SetValue<float>(value); } }
    }
    public class GeometryScriptPerlinNoiseOptions : Object
    {
        public GeometryScriptPerlinNoiseOptions(nint addr) : base(addr) { }
        public GeometryScriptPerlinNoiseLayerOptions BaseLayer { get { return this[nameof(BaseLayer)].As<GeometryScriptPerlinNoiseLayerOptions>(); } set { this["BaseLayer"] = value; } }
        public bool bApplyAlongNormal { get { return this[nameof(bApplyAlongNormal)].Flag; } set { this[nameof(bApplyAlongNormal)].Flag = value; } }
        public EGeometryScriptEmptySelectionBehavior EmptyBehavior { get { return (EGeometryScriptEmptySelectionBehavior)this[nameof(EmptyBehavior)].GetValue<int>(); } set { this[nameof(EmptyBehavior)].SetValue<int>((int)value); } }
    }
    public class GeometryScriptIterativeMeshSmoothingOptions : Object
    {
        public GeometryScriptIterativeMeshSmoothingOptions(nint addr) : base(addr) { }
        public int NumIterations { get { return this[nameof(NumIterations)].GetValue<int>(); } set { this[nameof(NumIterations)].SetValue<int>(value); } }
        public float Alpha { get { return this[nameof(Alpha)].GetValue<float>(); } set { this[nameof(Alpha)].SetValue<float>(value); } }
        public EGeometryScriptEmptySelectionBehavior EmptyBehavior { get { return (EGeometryScriptEmptySelectionBehavior)this[nameof(EmptyBehavior)].GetValue<int>(); } set { this[nameof(EmptyBehavior)].SetValue<int>((int)value); } }
    }
    public class GeometryScriptDisplaceFromTextureOptions : Object
    {
        public GeometryScriptDisplaceFromTextureOptions(nint addr) : base(addr) { }
        public float Magnitude { get { return this[nameof(Magnitude)].GetValue<float>(); } set { this[nameof(Magnitude)].SetValue<float>(value); } }
        public Vector2D UVScale { get { return this[nameof(UVScale)].As<Vector2D>(); } set { this["UVScale"] = value; } }
        public Vector2D UVOffset { get { return this[nameof(UVOffset)].As<Vector2D>(); } set { this["UVOffset"] = value; } }
        public float Center { get { return this[nameof(Center)].GetValue<float>(); } set { this[nameof(Center)].SetValue<float>(value); } }
        public int ImageChannel { get { return this[nameof(ImageChannel)].GetValue<int>(); } set { this[nameof(ImageChannel)].SetValue<int>(value); } }
        public EGeometryScriptEmptySelectionBehavior EmptyBehavior { get { return (EGeometryScriptEmptySelectionBehavior)this[nameof(EmptyBehavior)].GetValue<int>(); } set { this[nameof(EmptyBehavior)].SetValue<int>((int)value); } }
    }
    public class GeometryScriptMeshEditPolygroupOptions : Object
    {
        public GeometryScriptMeshEditPolygroupOptions(nint addr) : base(addr) { }
        public EGeometryScriptMeshEditPolygroupMode GroupMode { get { return (EGeometryScriptMeshEditPolygroupMode)this[nameof(GroupMode)].GetValue<int>(); } set { this[nameof(GroupMode)].SetValue<int>((int)value); } }
        public int ConstantGroup { get { return this[nameof(ConstantGroup)].GetValue<int>(); } set { this[nameof(ConstantGroup)].SetValue<int>(value); } }
    }
    public class GeometryScriptMeshOffsetOptions : Object
    {
        public GeometryScriptMeshOffsetOptions(nint addr) : base(addr) { }
        public float OffsetDistance { get { return this[nameof(OffsetDistance)].GetValue<float>(); } set { this[nameof(OffsetDistance)].SetValue<float>(value); } }
        public bool bFixedBoundary { get { return this[nameof(bFixedBoundary)].Flag; } set { this[nameof(bFixedBoundary)].Flag = value; } }
        public int SolveSteps { get { return this[nameof(SolveSteps)].GetValue<int>(); } set { this[nameof(SolveSteps)].SetValue<int>(value); } }
        public float SmoothAlpha { get { return this[nameof(SmoothAlpha)].GetValue<float>(); } set { this[nameof(SmoothAlpha)].SetValue<float>(value); } }
        public bool bReprojectDuringSmoothing { get { return this[nameof(bReprojectDuringSmoothing)].Flag; } set { this[nameof(bReprojectDuringSmoothing)].Flag = value; } }
        public float BoundaryAlpha { get { return this[nameof(BoundaryAlpha)].GetValue<float>(); } set { this[nameof(BoundaryAlpha)].SetValue<float>(value); } }
    }
    public class GeometryScriptMeshExtrudeOptions : Object
    {
        public GeometryScriptMeshExtrudeOptions(nint addr) : base(addr) { }
        public float ExtrudeDistance { get { return this[nameof(ExtrudeDistance)].GetValue<float>(); } set { this[nameof(ExtrudeDistance)].SetValue<float>(value); } }
        public Vector ExtrudeDirection { get { return this[nameof(ExtrudeDirection)].As<Vector>(); } set { this["ExtrudeDirection"] = value; } }
        public float UVScale { get { return this[nameof(UVScale)].GetValue<float>(); } set { this[nameof(UVScale)].SetValue<float>(value); } }
        public bool bSolidsToShells { get { return this[nameof(bSolidsToShells)].Flag; } set { this[nameof(bSolidsToShells)].Flag = value; } }
    }
    public class GeometryScriptMeshLinearExtrudeOptions : Object
    {
        public GeometryScriptMeshLinearExtrudeOptions(nint addr) : base(addr) { }
        public float Distance { get { return this[nameof(Distance)].GetValue<float>(); } set { this[nameof(Distance)].SetValue<float>(value); } }
        public EGeometryScriptLinearExtrudeDirection DirectionMode { get { return (EGeometryScriptLinearExtrudeDirection)this[nameof(DirectionMode)].GetValue<int>(); } set { this[nameof(DirectionMode)].SetValue<int>((int)value); } }
        public Vector Direction { get { return this[nameof(Direction)].As<Vector>(); } set { this["Direction"] = value; } }
        public EGeometryScriptPolyOperationArea AreaMode { get { return (EGeometryScriptPolyOperationArea)this[nameof(AreaMode)].GetValue<int>(); } set { this[nameof(AreaMode)].SetValue<int>((int)value); } }
        public GeometryScriptMeshEditPolygroupOptions GroupOptions { get { return this[nameof(GroupOptions)].As<GeometryScriptMeshEditPolygroupOptions>(); } set { this["GroupOptions"] = value; } }
        public float UVScale { get { return this[nameof(UVScale)].GetValue<float>(); } set { this[nameof(UVScale)].SetValue<float>(value); } }
        public bool bSolidsToShells { get { return this[nameof(bSolidsToShells)].Flag; } set { this[nameof(bSolidsToShells)].Flag = value; } }
    }
    public class GeometryScriptMeshOffsetFacesOptions : Object
    {
        public GeometryScriptMeshOffsetFacesOptions(nint addr) : base(addr) { }
        public float Distance { get { return this[nameof(Distance)].GetValue<float>(); } set { this[nameof(Distance)].SetValue<float>(value); } }
        public EGeometryScriptOffsetFacesType OffsetType { get { return (EGeometryScriptOffsetFacesType)this[nameof(OffsetType)].GetValue<int>(); } set { this[nameof(OffsetType)].SetValue<int>((int)value); } }
        public EGeometryScriptPolyOperationArea AreaMode { get { return (EGeometryScriptPolyOperationArea)this[nameof(AreaMode)].GetValue<int>(); } set { this[nameof(AreaMode)].SetValue<int>((int)value); } }
        public GeometryScriptMeshEditPolygroupOptions GroupOptions { get { return this[nameof(GroupOptions)].As<GeometryScriptMeshEditPolygroupOptions>(); } set { this["GroupOptions"] = value; } }
        public float UVScale { get { return this[nameof(UVScale)].GetValue<float>(); } set { this[nameof(UVScale)].SetValue<float>(value); } }
        public bool bSolidsToShells { get { return this[nameof(bSolidsToShells)].Flag; } set { this[nameof(bSolidsToShells)].Flag = value; } }
    }
    public class GeometryScriptMeshInsetOutsetFacesOptions : Object
    {
        public GeometryScriptMeshInsetOutsetFacesOptions(nint addr) : base(addr) { }
        public float Distance { get { return this[nameof(Distance)].GetValue<float>(); } set { this[nameof(Distance)].SetValue<float>(value); } }
        public bool bReproject { get { return this[nameof(bReproject)].Flag; } set { this[nameof(bReproject)].Flag = value; } }
        public bool bBoundaryOnly { get { return this[nameof(bBoundaryOnly)].Flag; } set { this[nameof(bBoundaryOnly)].Flag = value; } }
        public float Softness { get { return this[nameof(Softness)].GetValue<float>(); } set { this[nameof(Softness)].SetValue<float>(value); } }
        public float AreaScale { get { return this[nameof(AreaScale)].GetValue<float>(); } set { this[nameof(AreaScale)].SetValue<float>(value); } }
        public EGeometryScriptPolyOperationArea AreaMode { get { return (EGeometryScriptPolyOperationArea)this[nameof(AreaMode)].GetValue<int>(); } set { this[nameof(AreaMode)].SetValue<int>((int)value); } }
        public GeometryScriptMeshEditPolygroupOptions GroupOptions { get { return this[nameof(GroupOptions)].As<GeometryScriptMeshEditPolygroupOptions>(); } set { this["GroupOptions"] = value; } }
        public float UVScale { get { return this[nameof(UVScale)].GetValue<float>(); } set { this[nameof(UVScale)].SetValue<float>(value); } }
    }
    public class GeometryScriptMeshBevelOptions : Object
    {
        public GeometryScriptMeshBevelOptions(nint addr) : base(addr) { }
        public float BevelDistance { get { return this[nameof(BevelDistance)].GetValue<float>(); } set { this[nameof(BevelDistance)].SetValue<float>(value); } }
        public bool bInferMaterialID { get { return this[nameof(bInferMaterialID)].Flag; } set { this[nameof(bInferMaterialID)].Flag = value; } }
        public int SetMaterialID { get { return this[nameof(SetMaterialID)].GetValue<int>(); } set { this[nameof(SetMaterialID)].SetValue<int>(value); } }
        public bool bApplyFilterBox { get { return this[nameof(bApplyFilterBox)].Flag; } set { this[nameof(bApplyFilterBox)].Flag = value; } }
        public Box FilterBox { get { return this[nameof(FilterBox)].As<Box>(); } set { this["FilterBox"] = value; } }
        public Transform FilterBoxTransform { get { return this[nameof(FilterBoxTransform)].As<Transform>(); } set { this["FilterBoxTransform"] = value; } }
        public bool bFullyContained { get { return this[nameof(bFullyContained)].Flag; } set { this[nameof(bFullyContained)].Flag = value; } }
    }
    public class GeometryScriptMeshBevelSelectionOptions : Object
    {
        public GeometryScriptMeshBevelSelectionOptions(nint addr) : base(addr) { }
        public float BevelDistance { get { return this[nameof(BevelDistance)].GetValue<float>(); } set { this[nameof(BevelDistance)].SetValue<float>(value); } }
        public bool bInferMaterialID { get { return this[nameof(bInferMaterialID)].Flag; } set { this[nameof(bInferMaterialID)].Flag = value; } }
        public int SetMaterialID { get { return this[nameof(SetMaterialID)].GetValue<int>(); } set { this[nameof(SetMaterialID)].SetValue<int>(value); } }
    }
    public class GeometryScriptCalculateNormalsOptions : Object
    {
        public GeometryScriptCalculateNormalsOptions(nint addr) : base(addr) { }
        public bool bAngleWeighted { get { return this[nameof(bAngleWeighted)].Flag; } set { this[nameof(bAngleWeighted)].Flag = value; } }
        public bool bAreaWeighted { get { return this[nameof(bAreaWeighted)].Flag; } set { this[nameof(bAreaWeighted)].Flag = value; } }
    }
    public class GeometryScriptSplitNormalsOptions : Object
    {
        public GeometryScriptSplitNormalsOptions(nint addr) : base(addr) { }
        public bool bSplitByOpeningAngle { get { return this[nameof(bSplitByOpeningAngle)].Flag; } set { this[nameof(bSplitByOpeningAngle)].Flag = value; } }
        public float OpeningAngleDeg { get { return this[nameof(OpeningAngleDeg)].GetValue<float>(); } set { this[nameof(OpeningAngleDeg)].SetValue<float>(value); } }
        public bool bSplitByFaceGroup { get { return this[nameof(bSplitByFaceGroup)].Flag; } set { this[nameof(bSplitByFaceGroup)].Flag = value; } }
        public GeometryScriptGroupLayer GroupLayer { get { return this[nameof(GroupLayer)].As<GeometryScriptGroupLayer>(); } set { this["GroupLayer"] = value; } }
    }
    public class GeometryScriptTangentsOptions : Object
    {
        public GeometryScriptTangentsOptions(nint addr) : base(addr) { }
        public EGeometryScriptTangentTypes Type { get { return (EGeometryScriptTangentTypes)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public int UVLayer { get { return this[nameof(UVLayer)].GetValue<int>(); } set { this[nameof(UVLayer)].SetValue<int>(value); } }
    }
    public class GeometryScriptPrimitiveOptions : Object
    {
        public GeometryScriptPrimitiveOptions(nint addr) : base(addr) { }
        public EGeometryScriptPrimitivePolygroupMode PolygroupMode { get { return (EGeometryScriptPrimitivePolygroupMode)this[nameof(PolygroupMode)].GetValue<int>(); } set { this[nameof(PolygroupMode)].SetValue<int>((int)value); } }
        public bool bFlipOrientation { get { return this[nameof(bFlipOrientation)].Flag; } set { this[nameof(bFlipOrientation)].Flag = value; } }
        public EGeometryScriptPrimitiveUVMode UVMode { get { return (EGeometryScriptPrimitiveUVMode)this[nameof(UVMode)].GetValue<int>(); } set { this[nameof(UVMode)].SetValue<int>((int)value); } }
    }
    public class GeometryScriptRevolveOptions : Object
    {
        public GeometryScriptRevolveOptions(nint addr) : base(addr) { }
        public float RevolveDegrees { get { return this[nameof(RevolveDegrees)].GetValue<float>(); } set { this[nameof(RevolveDegrees)].SetValue<float>(value); } }
        public float DegreeOffset { get { return this[nameof(DegreeOffset)].GetValue<float>(); } set { this[nameof(DegreeOffset)].SetValue<float>(value); } }
        public bool bReverseDirection { get { return this[nameof(bReverseDirection)].Flag; } set { this[nameof(bReverseDirection)].Flag = value; } }
        public bool bHardNormals { get { return this[nameof(bHardNormals)].Flag; } set { this[nameof(bHardNormals)].Flag = value; } }
        public float HardNormalAngle { get { return this[nameof(HardNormalAngle)].GetValue<float>(); } set { this[nameof(HardNormalAngle)].SetValue<float>(value); } }
        public bool bProfileAtMidpoint { get { return this[nameof(bProfileAtMidpoint)].Flag; } set { this[nameof(bProfileAtMidpoint)].Flag = value; } }
        public bool bFillPartialRevolveEndcaps { get { return this[nameof(bFillPartialRevolveEndcaps)].Flag; } set { this[nameof(bFillPartialRevolveEndcaps)].Flag = value; } }
    }
    public class GeometryScriptVoronoiOptions : Object
    {
        public GeometryScriptVoronoiOptions(nint addr) : base(addr) { }
        public float BoundsExpand { get { return this[nameof(BoundsExpand)].GetValue<float>(); } set { this[nameof(BoundsExpand)].SetValue<float>(value); } }
        public Box Bounds { get { return this[nameof(Bounds)].As<Box>(); } set { this["Bounds"] = value; } }
        public Array<int> CreateCells { get { return new Array<int>(this[nameof(CreateCells)].Address); } }
        public bool bIncludeBoundary { get { return this[nameof(bIncludeBoundary)].Flag; } set { this[nameof(bIncludeBoundary)].Flag = value; } }
    }
    public class GeometryScriptRemeshOptions : Object
    {
        public GeometryScriptRemeshOptions(nint addr) : base(addr) { }
        public bool bDiscardAttributes { get { return this[nameof(bDiscardAttributes)].Flag; } set { this[nameof(bDiscardAttributes)].Flag = value; } }
        public bool bReprojectToInputMesh { get { return this[nameof(bReprojectToInputMesh)].Flag; } set { this[nameof(bReprojectToInputMesh)].Flag = value; } }
        public EGeometryScriptRemeshSmoothingType SmoothingType { get { return (EGeometryScriptRemeshSmoothingType)this[nameof(SmoothingType)].GetValue<int>(); } set { this[nameof(SmoothingType)].SetValue<int>((int)value); } }
        public float SmoothingRate { get { return this[nameof(SmoothingRate)].GetValue<float>(); } set { this[nameof(SmoothingRate)].SetValue<float>(value); } }
        public EGeometryScriptRemeshEdgeConstraintType MeshBoundaryConstraint { get { return (EGeometryScriptRemeshEdgeConstraintType)this[nameof(MeshBoundaryConstraint)].GetValue<int>(); } set { this[nameof(MeshBoundaryConstraint)].SetValue<int>((int)value); } }
        public EGeometryScriptRemeshEdgeConstraintType GroupBoundaryConstraint { get { return (EGeometryScriptRemeshEdgeConstraintType)this[nameof(GroupBoundaryConstraint)].GetValue<int>(); } set { this[nameof(GroupBoundaryConstraint)].SetValue<int>((int)value); } }
        public EGeometryScriptRemeshEdgeConstraintType MaterialBoundaryConstraint { get { return (EGeometryScriptRemeshEdgeConstraintType)this[nameof(MaterialBoundaryConstraint)].GetValue<int>(); } set { this[nameof(MaterialBoundaryConstraint)].SetValue<int>((int)value); } }
        public bool bAllowFlips { get { return this[nameof(bAllowFlips)].Flag; } set { this[nameof(bAllowFlips)].Flag = value; } }
        public bool bAllowSplits { get { return this[nameof(bAllowSplits)].Flag; } set { this[nameof(bAllowSplits)].Flag = value; } }
        public bool bAllowCollapses { get { return this[nameof(bAllowCollapses)].Flag; } set { this[nameof(bAllowCollapses)].Flag = value; } }
        public bool bPreventNormalFlips { get { return this[nameof(bPreventNormalFlips)].Flag; } set { this[nameof(bPreventNormalFlips)].Flag = value; } }
        public bool bPreventTinyTriangles { get { return this[nameof(bPreventTinyTriangles)].Flag; } set { this[nameof(bPreventTinyTriangles)].Flag = value; } }
        public bool bUseFullRemeshPasses { get { return this[nameof(bUseFullRemeshPasses)].Flag; } set { this[nameof(bUseFullRemeshPasses)].Flag = value; } }
        public int RemeshIterations { get { return this[nameof(RemeshIterations)].GetValue<int>(); } set { this[nameof(RemeshIterations)].SetValue<int>(value); } }
        public bool bAutoCompact { get { return this[nameof(bAutoCompact)].Flag; } set { this[nameof(bAutoCompact)].Flag = value; } }
    }
    public class GeometryScriptUniformRemeshOptions : Object
    {
        public GeometryScriptUniformRemeshOptions(nint addr) : base(addr) { }
        public EGeometryScriptUniformRemeshTargetType TargetType { get { return (EGeometryScriptUniformRemeshTargetType)this[nameof(TargetType)].GetValue<int>(); } set { this[nameof(TargetType)].SetValue<int>((int)value); } }
        public int TargetTriangleCount { get { return this[nameof(TargetTriangleCount)].GetValue<int>(); } set { this[nameof(TargetTriangleCount)].SetValue<int>(value); } }
        public float TargetEdgeLength { get { return this[nameof(TargetEdgeLength)].GetValue<float>(); } set { this[nameof(TargetEdgeLength)].SetValue<float>(value); } }
    }
    public class GeometryScriptWeldEdgesOptions : Object
    {
        public GeometryScriptWeldEdgesOptions(nint addr) : base(addr) { }
        public float Tolerance { get { return this[nameof(Tolerance)].GetValue<float>(); } set { this[nameof(Tolerance)].SetValue<float>(value); } }
        public bool bOnlyUniquePairs { get { return this[nameof(bOnlyUniquePairs)].Flag; } set { this[nameof(bOnlyUniquePairs)].Flag = value; } }
    }
    public class GeometryScriptResolveTJunctionOptions : Object
    {
        public GeometryScriptResolveTJunctionOptions(nint addr) : base(addr) { }
        public float Tolerance { get { return this[nameof(Tolerance)].GetValue<float>(); } set { this[nameof(Tolerance)].SetValue<float>(value); } }
    }
    public class GeometryScriptFillHolesOptions : Object
    {
        public GeometryScriptFillHolesOptions(nint addr) : base(addr) { }
        public EGeometryScriptFillHolesMethod FillMethod { get { return (EGeometryScriptFillHolesMethod)this[nameof(FillMethod)].GetValue<int>(); } set { this[nameof(FillMethod)].SetValue<int>((int)value); } }
        public bool bDeleteIsolatedTriangles { get { return this[nameof(bDeleteIsolatedTriangles)].Flag; } set { this[nameof(bDeleteIsolatedTriangles)].Flag = value; } }
    }
    public class GeometryScriptRemoveSmallComponentOptions : Object
    {
        public GeometryScriptRemoveSmallComponentOptions(nint addr) : base(addr) { }
        public float MinVolume { get { return this[nameof(MinVolume)].GetValue<float>(); } set { this[nameof(MinVolume)].SetValue<float>(value); } }
        public float MinArea { get { return this[nameof(MinArea)].GetValue<float>(); } set { this[nameof(MinArea)].SetValue<float>(value); } }
        public int MinTriangleCount { get { return this[nameof(MinTriangleCount)].GetValue<int>(); } set { this[nameof(MinTriangleCount)].SetValue<int>(value); } }
    }
    public class GeometryScriptRemoveHiddenTrianglesOptions : Object
    {
        public GeometryScriptRemoveHiddenTrianglesOptions(nint addr) : base(addr) { }
        public EGeometryScriptRemoveHiddenTrianglesMethod Method { get { return (EGeometryScriptRemoveHiddenTrianglesMethod)this[nameof(Method)].GetValue<int>(); } set { this[nameof(Method)].SetValue<int>((int)value); } }
        public int SamplesPerTriangle { get { return this[nameof(SamplesPerTriangle)].GetValue<int>(); } set { this[nameof(SamplesPerTriangle)].SetValue<int>(value); } }
        public int ShrinkSelection { get { return this[nameof(ShrinkSelection)].GetValue<int>(); } set { this[nameof(ShrinkSelection)].SetValue<int>(value); } }
        public float WindingIsoValue { get { return this[nameof(WindingIsoValue)].GetValue<float>(); } set { this[nameof(WindingIsoValue)].SetValue<float>(value); } }
        public int RaysPerSample { get { return this[nameof(RaysPerSample)].GetValue<int>(); } set { this[nameof(RaysPerSample)].SetValue<int>(value); } }
        public float NormalOffset { get { return this[nameof(NormalOffset)].GetValue<float>(); } set { this[nameof(NormalOffset)].SetValue<float>(value); } }
        public bool bCompactResult { get { return this[nameof(bCompactResult)].Flag; } set { this[nameof(bCompactResult)].Flag = value; } }
    }
    public class GeometryScriptDegenerateTriangleOptions : Object
    {
        public GeometryScriptDegenerateTriangleOptions(nint addr) : base(addr) { }
        public EGeometryScriptRepairMeshMode Mode { get { return (EGeometryScriptRepairMeshMode)this[nameof(Mode)].GetValue<int>(); } set { this[nameof(Mode)].SetValue<int>((int)value); } }
        public double MinTriangleArea { get { return this[nameof(MinTriangleArea)].GetValue<double>(); } set { this[nameof(MinTriangleArea)].SetValue<double>(value); } }
        public double MinEdgeLength { get { return this[nameof(MinEdgeLength)].GetValue<double>(); } set { this[nameof(MinEdgeLength)].SetValue<double>(value); } }
        public bool bCompactOnCompletion { get { return this[nameof(bCompactOnCompletion)].Flag; } set { this[nameof(bCompactOnCompletion)].Flag = value; } }
    }
    public class GeometryScriptMeshPointSamplingOptions : Object
    {
        public GeometryScriptMeshPointSamplingOptions(nint addr) : base(addr) { }
        public float SamplingRadius { get { return this[nameof(SamplingRadius)].GetValue<float>(); } set { this[nameof(SamplingRadius)].SetValue<float>(value); } }
        public int MaxNumSamples { get { return this[nameof(MaxNumSamples)].GetValue<int>(); } set { this[nameof(MaxNumSamples)].SetValue<int>(value); } }
        public int RandomSeed { get { return this[nameof(RandomSeed)].GetValue<int>(); } set { this[nameof(RandomSeed)].SetValue<int>(value); } }
        public double SubSampleDensity { get { return this[nameof(SubSampleDensity)].GetValue<double>(); } set { this[nameof(SubSampleDensity)].SetValue<double>(value); } }
    }
    public class GeometryScriptNonUniformPointSamplingOptions : Object
    {
        public GeometryScriptNonUniformPointSamplingOptions(nint addr) : base(addr) { }
        public float MaxSamplingRadius { get { return this[nameof(MaxSamplingRadius)].GetValue<float>(); } set { this[nameof(MaxSamplingRadius)].SetValue<float>(value); } }
        public EGeometryScriptSamplingDistributionMode SizeDistribution { get { return (EGeometryScriptSamplingDistributionMode)this[nameof(SizeDistribution)].GetValue<int>(); } set { this[nameof(SizeDistribution)].SetValue<int>((int)value); } }
        public double SizeDistributionPower { get { return this[nameof(SizeDistributionPower)].GetValue<double>(); } set { this[nameof(SizeDistributionPower)].SetValue<double>(value); } }
        public EGeometryScriptSamplingWeightMode WeightMode { get { return (EGeometryScriptSamplingWeightMode)this[nameof(WeightMode)].GetValue<int>(); } set { this[nameof(WeightMode)].SetValue<int>((int)value); } }
        public bool bInvertWeights { get { return this[nameof(bInvertWeights)].Flag; } set { this[nameof(bInvertWeights)].Flag = value; } }
    }
    public class GeometryScriptPlanarSimplifyOptions : Object
    {
        public GeometryScriptPlanarSimplifyOptions(nint addr) : base(addr) { }
        public float AngleThreshold { get { return this[nameof(AngleThreshold)].GetValue<float>(); } set { this[nameof(AngleThreshold)].SetValue<float>(value); } }
        public bool bAutoCompact { get { return this[nameof(bAutoCompact)].Flag; } set { this[nameof(bAutoCompact)].Flag = value; } }
    }
    public class GeometryScriptPolygroupSimplifyOptions : Object
    {
        public GeometryScriptPolygroupSimplifyOptions(nint addr) : base(addr) { }
        public float AngleThreshold { get { return this[nameof(AngleThreshold)].GetValue<float>(); } set { this[nameof(AngleThreshold)].SetValue<float>(value); } }
        public bool bAutoCompact { get { return this[nameof(bAutoCompact)].Flag; } set { this[nameof(bAutoCompact)].Flag = value; } }
    }
    public class GeometryScriptSimplifyMeshOptions : Object
    {
        public GeometryScriptSimplifyMeshOptions(nint addr) : base(addr) { }
        public EGeometryScriptRemoveMeshSimplificationType Method { get { return (EGeometryScriptRemoveMeshSimplificationType)this[nameof(Method)].GetValue<int>(); } set { this[nameof(Method)].SetValue<int>((int)value); } }
        public bool bAllowSeamCollapse { get { return this[nameof(bAllowSeamCollapse)].Flag; } set { this[nameof(bAllowSeamCollapse)].Flag = value; } }
        public bool bAllowSeamSmoothing { get { return this[nameof(bAllowSeamSmoothing)].Flag; } set { this[nameof(bAllowSeamSmoothing)].Flag = value; } }
        public bool bAllowSeamSplits { get { return this[nameof(bAllowSeamSplits)].Flag; } set { this[nameof(bAllowSeamSplits)].Flag = value; } }
        public bool bPreserveVertexPositions { get { return this[nameof(bPreserveVertexPositions)].Flag; } set { this[nameof(bPreserveVertexPositions)].Flag = value; } }
        public bool bRetainQuadricMemory { get { return this[nameof(bRetainQuadricMemory)].Flag; } set { this[nameof(bRetainQuadricMemory)].Flag = value; } }
        public bool bAutoCompact { get { return this[nameof(bAutoCompact)].Flag; } set { this[nameof(bAutoCompact)].Flag = value; } }
    }
    public class GeometryScriptSpatialQueryOptions : Object
    {
        public GeometryScriptSpatialQueryOptions(nint addr) : base(addr) { }
        public float MaxDistance { get { return this[nameof(MaxDistance)].GetValue<float>(); } set { this[nameof(MaxDistance)].SetValue<float>(value); } }
        public bool bAllowUnsafeModifiedQueries { get { return this[nameof(bAllowUnsafeModifiedQueries)].Flag; } set { this[nameof(bAllowUnsafeModifiedQueries)].Flag = value; } }
        public float WindingIsoThreshold { get { return this[nameof(WindingIsoThreshold)].GetValue<float>(); } set { this[nameof(WindingIsoThreshold)].SetValue<float>(value); } }
    }
    public class GeometryScriptRayHitResult : Object
    {
        public GeometryScriptRayHitResult(nint addr) : base(addr) { }
        public bool bHit { get { return this[nameof(bHit)].Flag; } set { this[nameof(bHit)].Flag = value; } }
        public float RayParameter { get { return this[nameof(RayParameter)].GetValue<float>(); } set { this[nameof(RayParameter)].SetValue<float>(value); } }
        public int HitTriangleID { get { return this[nameof(HitTriangleID)].GetValue<int>(); } set { this[nameof(HitTriangleID)].SetValue<int>(value); } }
        public Vector HitPosition { get { return this[nameof(HitPosition)].As<Vector>(); } set { this["HitPosition"] = value; } }
        public Vector HitBaryCoords { get { return this[nameof(HitBaryCoords)].As<Vector>(); } set { this["HitBaryCoords"] = value; } }
    }
    public class GeometryScriptPNTessellateOptions : Object
    {
        public GeometryScriptPNTessellateOptions(nint addr) : base(addr) { }
        public bool bRecomputeNormals { get { return this[nameof(bRecomputeNormals)].Flag; } set { this[nameof(bRecomputeNormals)].Flag = value; } }
    }
    public class GeometryScriptSelectiveTessellateOptions : Object
    {
        public GeometryScriptSelectiveTessellateOptions(nint addr) : base(addr) { }
        public bool bEnableMultithreading { get { return this[nameof(bEnableMultithreading)].Flag; } set { this[nameof(bEnableMultithreading)].Flag = value; } }
        public EGeometryScriptEmptySelectionBehavior EmptyBehavior { get { return (EGeometryScriptEmptySelectionBehavior)this[nameof(EmptyBehavior)].GetValue<int>(); } set { this[nameof(EmptyBehavior)].SetValue<int>((int)value); } }
    }
    public class GeometryScriptRepackUVsOptions : Object
    {
        public GeometryScriptRepackUVsOptions(nint addr) : base(addr) { }
        public int TargetImageWidth { get { return this[nameof(TargetImageWidth)].GetValue<int>(); } set { this[nameof(TargetImageWidth)].SetValue<int>(value); } }
        public bool bOptimizeIslandRotation { get { return this[nameof(bOptimizeIslandRotation)].Flag; } set { this[nameof(bOptimizeIslandRotation)].Flag = value; } }
    }
    public class GeometryScriptExpMapUVOptions : Object
    {
        public GeometryScriptExpMapUVOptions(nint addr) : base(addr) { }
        public int NormalSmoothingRounds { get { return this[nameof(NormalSmoothingRounds)].GetValue<int>(); } set { this[nameof(NormalSmoothingRounds)].SetValue<int>(value); } }
        public float NormalSmoothingAlpha { get { return this[nameof(NormalSmoothingAlpha)].GetValue<float>(); } set { this[nameof(NormalSmoothingAlpha)].SetValue<float>(value); } }
    }
    public class GeometryScriptSpectralConformalUVOptions : Object
    {
        public GeometryScriptSpectralConformalUVOptions(nint addr) : base(addr) { }
        public bool bPreserveIrregularity { get { return this[nameof(bPreserveIrregularity)].Flag; } set { this[nameof(bPreserveIrregularity)].Flag = value; } }
    }
    public class GeometryScriptRecomputeUVsOptions : Object
    {
        public GeometryScriptRecomputeUVsOptions(nint addr) : base(addr) { }
        public EGeometryScriptUVFlattenMethod Method { get { return (EGeometryScriptUVFlattenMethod)this[nameof(Method)].GetValue<int>(); } set { this[nameof(Method)].SetValue<int>((int)value); } }
        public EGeometryScriptUVIslandSource IslandSource { get { return (EGeometryScriptUVIslandSource)this[nameof(IslandSource)].GetValue<int>(); } set { this[nameof(IslandSource)].SetValue<int>((int)value); } }
        public GeometryScriptExpMapUVOptions ExpMapOptions { get { return this[nameof(ExpMapOptions)].As<GeometryScriptExpMapUVOptions>(); } set { this["ExpMapOptions"] = value; } }
        public GeometryScriptSpectralConformalUVOptions SpectralConformalOptions { get { return this[nameof(SpectralConformalOptions)].As<GeometryScriptSpectralConformalUVOptions>(); } set { this["SpectralConformalOptions"] = value; } }
        public GeometryScriptGroupLayer GroupLayer { get { return this[nameof(GroupLayer)].As<GeometryScriptGroupLayer>(); } set { this["GroupLayer"] = value; } }
        public bool bAutoAlignIslandsWithAxes { get { return this[nameof(bAutoAlignIslandsWithAxes)].Flag; } set { this[nameof(bAutoAlignIslandsWithAxes)].Flag = value; } }
    }
    public class GeometryScriptPatchBuilderOptions : Object
    {
        public GeometryScriptPatchBuilderOptions(nint addr) : base(addr) { }
        public int InitialPatchCount { get { return this[nameof(InitialPatchCount)].GetValue<int>(); } set { this[nameof(InitialPatchCount)].SetValue<int>(value); } }
        public int MinPatchSize { get { return this[nameof(MinPatchSize)].GetValue<int>(); } set { this[nameof(MinPatchSize)].SetValue<int>(value); } }
        public float PatchCurvatureAlignmentWeight { get { return this[nameof(PatchCurvatureAlignmentWeight)].GetValue<float>(); } set { this[nameof(PatchCurvatureAlignmentWeight)].SetValue<float>(value); } }
        public float PatchMergingMetricThresh { get { return this[nameof(PatchMergingMetricThresh)].GetValue<float>(); } set { this[nameof(PatchMergingMetricThresh)].SetValue<float>(value); } }
        public float PatchMergingAngleThresh { get { return this[nameof(PatchMergingAngleThresh)].GetValue<float>(); } set { this[nameof(PatchMergingAngleThresh)].SetValue<float>(value); } }
        public GeometryScriptExpMapUVOptions ExpMapOptions { get { return this[nameof(ExpMapOptions)].As<GeometryScriptExpMapUVOptions>(); } set { this["ExpMapOptions"] = value; } }
        public bool bRespectInputGroups { get { return this[nameof(bRespectInputGroups)].Flag; } set { this[nameof(bRespectInputGroups)].Flag = value; } }
        public GeometryScriptGroupLayer GroupLayer { get { return this[nameof(GroupLayer)].As<GeometryScriptGroupLayer>(); } set { this["GroupLayer"] = value; } }
        public bool bAutoPack { get { return this[nameof(bAutoPack)].Flag; } set { this[nameof(bAutoPack)].Flag = value; } }
        public GeometryScriptRepackUVsOptions PackingOptions { get { return this[nameof(PackingOptions)].As<GeometryScriptRepackUVsOptions>(); } set { this["PackingOptions"] = value; } }
    }
    public class GeometryScriptXAtlasOptions : Object
    {
        public GeometryScriptXAtlasOptions(nint addr) : base(addr) { }
        public int MaxIterations { get { return this[nameof(MaxIterations)].GetValue<int>(); } set { this[nameof(MaxIterations)].SetValue<int>(value); } }
    }
    public class GeometryScript3DGridParameters : Object
    {
        public GeometryScript3DGridParameters(nint addr) : base(addr) { }
        public EGeometryScriptGridSizingMethod SizeMethod { get { return (EGeometryScriptGridSizingMethod)this[nameof(SizeMethod)].GetValue<int>(); } set { this[nameof(SizeMethod)].SetValue<int>((int)value); } }
        public float GridCellSize { get { return this[nameof(GridCellSize)].GetValue<float>(); } set { this[nameof(GridCellSize)].SetValue<float>(value); } }
        public int GridResolution { get { return this[nameof(GridResolution)].GetValue<int>(); } set { this[nameof(GridResolution)].SetValue<int>(value); } }
    }
    public class GeometryScriptSolidifyOptions : Object
    {
        public GeometryScriptSolidifyOptions(nint addr) : base(addr) { }
        public GeometryScript3DGridParameters GridParameters { get { return this[nameof(GridParameters)].As<GeometryScript3DGridParameters>(); } set { this["GridParameters"] = value; } }
        public float WindingThreshold { get { return this[nameof(WindingThreshold)].GetValue<float>(); } set { this[nameof(WindingThreshold)].SetValue<float>(value); } }
        public bool bSolidAtBoundaries { get { return this[nameof(bSolidAtBoundaries)].Flag; } set { this[nameof(bSolidAtBoundaries)].Flag = value; } }
        public float ExtendBounds { get { return this[nameof(ExtendBounds)].GetValue<float>(); } set { this[nameof(ExtendBounds)].SetValue<float>(value); } }
        public int SurfaceSearchSteps { get { return this[nameof(SurfaceSearchSteps)].GetValue<int>(); } set { this[nameof(SurfaceSearchSteps)].SetValue<int>(value); } }
        public bool bThickenShells { get { return this[nameof(bThickenShells)].Flag; } set { this[nameof(bThickenShells)].Flag = value; } }
        public double ShellThickness { get { return this[nameof(ShellThickness)].GetValue<double>(); } set { this[nameof(ShellThickness)].SetValue<double>(value); } }
    }
    public class GeometryScriptMorphologyOptions : Object
    {
        public GeometryScriptMorphologyOptions(nint addr) : base(addr) { }
        public GeometryScript3DGridParameters SDFGridParameters { get { return this[nameof(SDFGridParameters)].As<GeometryScript3DGridParameters>(); } set { this["SDFGridParameters"] = value; } }
        public bool bUseSeparateMeshGrid { get { return this[nameof(bUseSeparateMeshGrid)].Flag; } set { this[nameof(bUseSeparateMeshGrid)].Flag = value; } }
        public GeometryScript3DGridParameters MeshGridParameters { get { return this[nameof(MeshGridParameters)].As<GeometryScript3DGridParameters>(); } set { this["MeshGridParameters"] = value; } }
        public EGeometryScriptMorphologicalOpType Operation { get { return (EGeometryScriptMorphologicalOpType)this[nameof(Operation)].GetValue<int>(); } set { this[nameof(Operation)].SetValue<int>((int)value); } }
        public float Distance { get { return this[nameof(Distance)].GetValue<float>(); } set { this[nameof(Distance)].SetValue<float>(value); } }
    }
    public class GeometryScriptSplineSamplingOptions : Object
    {
        public GeometryScriptSplineSamplingOptions(nint addr) : base(addr) { }
        public int NumSamples { get { return this[nameof(NumSamples)].GetValue<int>(); } set { this[nameof(NumSamples)].SetValue<int>(value); } }
        public float ErrorTolerance { get { return this[nameof(ErrorTolerance)].GetValue<float>(); } set { this[nameof(ErrorTolerance)].SetValue<float>(value); } }
        public EGeometryScriptSampleSpacing SampleSpacing { get { return (EGeometryScriptSampleSpacing)this[nameof(SampleSpacing)].GetValue<int>(); } set { this[nameof(SampleSpacing)].SetValue<int>((int)value); } }
        public byte CoordinateSpace { get { return this[nameof(CoordinateSpace)].GetValue<byte>(); } set { this[nameof(CoordinateSpace)].SetValue<byte>(value); } }
    }
    public class GeometryScriptCopyMeshFromComponentOptions : Object
    {
        public GeometryScriptCopyMeshFromComponentOptions(nint addr) : base(addr) { }
        public bool bWantNormals { get { return this[nameof(bWantNormals)].Flag; } set { this[nameof(bWantNormals)].Flag = value; } }
        public bool bWantTangents { get { return this[nameof(bWantTangents)].Flag; } set { this[nameof(bWantTangents)].Flag = value; } }
        public GeometryScriptMeshReadLOD RequestedLOD { get { return this[nameof(RequestedLOD)].As<GeometryScriptMeshReadLOD>(); } set { this["RequestedLOD"] = value; } }
    }
    public class GeometryScriptSampleTextureOptions : Object
    {
        public GeometryScriptSampleTextureOptions(nint addr) : base(addr) { }
        public EGeometryScriptPixelSamplingMethod SamplingMethod { get { return (EGeometryScriptPixelSamplingMethod)this[nameof(SamplingMethod)].GetValue<int>(); } set { this[nameof(SamplingMethod)].SetValue<int>((int)value); } }
        public bool bWrap { get { return this[nameof(bWrap)].Flag; } set { this[nameof(bWrap)].Flag = value; } }
        public Vector2D UVScale { get { return this[nameof(UVScale)].As<Vector2D>(); } set { this["UVScale"] = value; } }
        public Vector2D UVOffset { get { return this[nameof(UVOffset)].As<Vector2D>(); } set { this["UVOffset"] = value; } }
    }
}
