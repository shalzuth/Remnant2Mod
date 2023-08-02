using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.NavigationSystemSDK;
using SDK.Script.EngineSDK;
using SDK.Script.AIModuleSDK;
namespace SDK.Script.Gunfire3DNavigationSDK
{
    public class Gunfire3DNavData : NavigationData
    {
        public Gunfire3DNavData(nint addr) : base(addr) { }
        public bool bDrawShell { get { return this[nameof(bDrawShell)].Flag; } set { this[nameof(bDrawShell)].Flag = value; } }
        public bool bDrawOctree { get { return this[nameof(bDrawOctree)].Flag; } set { this[nameof(bDrawOctree)].Flag = value; } }
        public ENav3DDrawType DrawType { get { return (ENav3DDrawType)this[nameof(DrawType)].GetValue<int>(); } set { this[nameof(DrawType)].SetValue<int>((int)value); } }
        public bool bIncludeVoxelAreas { get { return this[nameof(bIncludeVoxelAreas)].Flag; } set { this[nameof(bIncludeVoxelAreas)].Flag = value; } }
        public bool bDrawSingleLayer { get { return this[nameof(bDrawSingleLayer)].Flag; } set { this[nameof(bDrawSingleLayer)].Flag = value; } }
        public byte DrawLayerIndex { get { return this[nameof(DrawLayerIndex)].GetValue<byte>(); } set { this[nameof(DrawLayerIndex)].SetValue<byte>(value); } }
        public float VoxelSize { get { return this[nameof(VoxelSize)].GetValue<float>(); } set { this[nameof(VoxelSize)].SetValue<float>(value); } }
        public byte TileLayerIndex { get { return this[nameof(TileLayerIndex)].GetValue<byte>(); } set { this[nameof(TileLayerIndex)].SetValue<byte>(value); } }
        public uint TilePoolSize { get { return this[nameof(TilePoolSize)].GetValue<uint>(); } set { this[nameof(TilePoolSize)].SetValue<uint>(value); } }
        public bool bFixedTilePoolSize { get { return this[nameof(bFixedTilePoolSize)].Flag; } set { this[nameof(bFixedTilePoolSize)].Flag = value; } }
        public int MaxTileGenerationJobs { get { return this[nameof(MaxTileGenerationJobs)].GetValue<int>(); } set { this[nameof(MaxTileGenerationJobs)].SetValue<int>(value); } }
        public int MaxTilesPerGenerationJob { get { return this[nameof(MaxTilesPerGenerationJob)].GetValue<int>(); } set { this[nameof(MaxTilesPerGenerationJob)].SetValue<int>(value); } }
        public bool bDoAsyncGeometryGathering { get { return this[nameof(bDoAsyncGeometryGathering)].Flag; } set { this[nameof(bDoAsyncGeometryGathering)].Flag = value; } }
        public uint DefaultMaxSearchNodes { get { return this[nameof(DefaultMaxSearchNodes)].GetValue<uint>(); } set { this[nameof(DefaultMaxSearchNodes)].SetValue<uint>(value); } }
        public float DefaultHeuristicScale { get { return this[nameof(DefaultHeuristicScale)].GetValue<float>(); } set { this[nameof(DefaultHeuristicScale)].SetValue<float>(value); } }
        public float DefaultBaseTraversalCost { get { return this[nameof(DefaultBaseTraversalCost)].GetValue<float>(); } set { this[nameof(DefaultBaseTraversalCost)].SetValue<float>(value); } }
    }
    public class Gunfire3DNavigationQueryFilter : NavigationQueryFilter
    {
        public Gunfire3DNavigationQueryFilter(nint addr) : base(addr) { }
        public uint MaxPathSearchNodes { get { return this[nameof(MaxPathSearchNodes)].GetValue<uint>(); } set { this[nameof(MaxPathSearchNodes)].SetValue<uint>(value); } }
        public float PathHeuristicScale { get { return this[nameof(PathHeuristicScale)].GetValue<float>(); } set { this[nameof(PathHeuristicScale)].SetValue<float>(value); } }
        public float NodeBaseTraversalCost { get { return this[nameof(NodeBaseTraversalCost)].GetValue<float>(); } set { this[nameof(NodeBaseTraversalCost)].SetValue<float>(value); } }
    }
    public class Gunfire3DNavRenderingComponent : PrimitiveComponent
    {
        public Gunfire3DNavRenderingComponent(nint addr) : base(addr) { }
    }
    public class EnvQueryGenerator_PathingGrid3D : EnvQueryGenerator
    {
        public EnvQueryGenerator_PathingGrid3D(nint addr) : base(addr) { }
        public AIDataProviderFloatValue GridHalfSize { get { return this[nameof(GridHalfSize)].As<AIDataProviderFloatValue>(); } set { this["GridHalfSize"] = value; } }
        public AIDataProviderFloatValue SpaceBetween { get { return this[nameof(SpaceBetween)].As<AIDataProviderFloatValue>(); } set { this["SpaceBetween"] = value; } }
        public AIDataProviderFloatValue MinHeight { get { return this[nameof(MinHeight)].As<AIDataProviderFloatValue>(); } set { this["MinHeight"] = value; } }
        public AIDataProviderFloatValue MaxHeight { get { return this[nameof(MaxHeight)].As<AIDataProviderFloatValue>(); } set { this["MaxHeight"] = value; } }
        public Object GenerateAround { get { return this[nameof(GenerateAround)]; } set { this[nameof(GenerateAround)] = value; } }
    }
    public class NavSvoDebugActor : Actor
    {
        public NavSvoDebugActor(nint addr) : base(addr) { }
        public float AgentRadius { get { return this[nameof(AgentRadius)].GetValue<float>(); } set { this[nameof(AgentRadius)].SetValue<float>(value); } }
        public float AgentHeight { get { return this[nameof(AgentHeight)].GetValue<float>(); } set { this[nameof(AgentHeight)].SetValue<float>(value); } }
        public uint MaxPathSearchNodes { get { return this[nameof(MaxPathSearchNodes)].GetValue<uint>(); } set { this[nameof(MaxPathSearchNodes)].SetValue<uint>(value); } }
        public float PathHeuristicScale { get { return this[nameof(PathHeuristicScale)].GetValue<float>(); } set { this[nameof(PathHeuristicScale)].SetValue<float>(value); } }
        public float NodeBaseTraversalCost { get { return this[nameof(NodeBaseTraversalCost)].GetValue<float>(); } set { this[nameof(NodeBaseTraversalCost)].SetValue<float>(value); } }
        public float PathCostLimit { get { return this[nameof(PathCostLimit)].GetValue<float>(); } set { this[nameof(PathCostLimit)].SetValue<float>(value); } }
        public bool bAllowPartialPath { get { return this[nameof(bAllowPartialPath)].Flag; } set { this[nameof(bAllowPartialPath)].Flag = value; } }
        public bool bStringPullPath { get { return this[nameof(bStringPullPath)].Flag; } set { this[nameof(bStringPullPath)].Flag = value; } }
        public bool bSmoothPath { get { return this[nameof(bSmoothPath)].Flag; } set { this[nameof(bSmoothPath)].Flag = value; } }
        public float PathLength { get { return this[nameof(PathLength)].GetValue<float>(); } set { this[nameof(PathLength)].SetValue<float>(value); } }
        public float PathCost { get { return this[nameof(PathCost)].GetValue<float>(); } set { this[nameof(PathCost)].SetValue<float>(value); } }
        public int NumPathNodesVisited { get { return this[nameof(NumPathNodesVisited)].GetValue<int>(); } set { this[nameof(NumPathNodesVisited)].SetValue<int>(value); } }
        public int NumPathNodesQueried { get { return this[nameof(NumPathNodesQueried)].GetValue<int>(); } set { this[nameof(NumPathNodesQueried)].SetValue<int>(value); } }
        public int NumPathNodesOpened { get { return this[nameof(NumPathNodesOpened)].GetValue<int>(); } set { this[nameof(NumPathNodesOpened)].SetValue<int>(value); } }
        public int NumPathNodesReopened { get { return this[nameof(NumPathNodesReopened)].GetValue<int>(); } set { this[nameof(NumPathNodesReopened)].SetValue<int>(value); } }
        public int QueryMemoryUsed { get { return this[nameof(QueryMemoryUsed)].GetValue<int>(); } set { this[nameof(QueryMemoryUsed)].SetValue<int>(value); } }
        public float PathSearchTime { get { return this[nameof(PathSearchTime)].GetValue<float>(); } set { this[nameof(PathSearchTime)].SetValue<float>(value); } }
        public bool bIsPartialPath { get { return this[nameof(bIsPartialPath)].Flag; } set { this[nameof(bIsPartialPath)].Flag = value; } }
        public bool bPathExists { get { return this[nameof(bPathExists)].Flag; } set { this[nameof(bPathExists)].Flag = value; } }
        public bool bPathNodeLimitReached { get { return this[nameof(bPathNodeLimitReached)].Flag; } set { this[nameof(bPathNodeLimitReached)].Flag = value; } }
        public bool bDrawPath { get { return this[nameof(bDrawPath)].Flag; } set { this[nameof(bDrawPath)].Flag = value; } }
        public bool bDrawPathNodes { get { return this[nameof(bDrawPathNodes)].Flag; } set { this[nameof(bDrawPathNodes)].Flag = value; } }
        public bool bDrawPathSearch { get { return this[nameof(bDrawPathSearch)].Flag; } set { this[nameof(bDrawPathSearch)].Flag = value; } }
        public int CurrentPathSearchStep { get { return this[nameof(CurrentPathSearchStep)].GetValue<int>(); } set { this[nameof(CurrentPathSearchStep)].SetValue<int>(value); } }
        public bool bAutoStepPathSearch { get { return this[nameof(bAutoStepPathSearch)].Flag; } set { this[nameof(bAutoStepPathSearch)].Flag = value; } }
        public int PathSearchAutoStepRate { get { return this[nameof(PathSearchAutoStepRate)].GetValue<int>(); } set { this[nameof(PathSearchAutoStepRate)].SetValue<int>(value); } }
        public uint MaxRaycastSearchNodes { get { return this[nameof(MaxRaycastSearchNodes)].GetValue<uint>(); } set { this[nameof(MaxRaycastSearchNodes)].SetValue<uint>(value); } }
        public bool bDrawRaycast { get { return this[nameof(bDrawRaycast)].Flag; } set { this[nameof(bDrawRaycast)].Flag = value; } }
        public bool bDrawRaycastSearch { get { return this[nameof(bDrawRaycastSearch)].Flag; } set { this[nameof(bDrawRaycastSearch)].Flag = value; } }
        public int CurrentRaycastStep { get { return this[nameof(CurrentRaycastStep)].GetValue<int>(); } set { this[nameof(CurrentRaycastStep)].SetValue<int>(value); } }
        public bool bAutoStepRaycastSearch { get { return this[nameof(bAutoStepRaycastSearch)].Flag; } set { this[nameof(bAutoStepRaycastSearch)].Flag = value; } }
        public int RaycastSearchAutoStepRate { get { return this[nameof(RaycastSearchAutoStepRate)].GetValue<int>(); } set { this[nameof(RaycastSearchAutoStepRate)].SetValue<int>(value); } }
        public bool bDrawNeighbors { get { return this[nameof(bDrawNeighbors)].Flag; } set { this[nameof(bDrawNeighbors)].Flag = value; } }
        public SceneComponent StartPosition { get { return this[nameof(StartPosition)].As<SceneComponent>(); } set { this["StartPosition"] = value; } }
        public SceneComponent EndPosition { get { return this[nameof(EndPosition)].As<SceneComponent>(); } set { this["EndPosition"] = value; } }
        public Gunfire3DNavData NavData { get { return this[nameof(NavData)].As<Gunfire3DNavData>(); } set { this["NavData"] = value; } }
        public BillboardComponent StartSprite { get { return this[nameof(StartSprite)].As<BillboardComponent>(); } set { this["StartSprite"] = value; } }
        public BillboardComponent EndSprite { get { return this[nameof(EndSprite)].As<BillboardComponent>(); } set { this["EndSprite"] = value; } }
    }
    public class NavSvoStreamingData : NavigationDataChunk
    {
        public NavSvoStreamingData(nint addr) : base(addr) { }
        public Level Level { get { return this[nameof(Level)].As<Level>(); } set { this["Level"] = value; } }
    }
    public enum ENav3DDrawType : int
    {
        Open = 0,
        Blocked = 1,
        ENav3DDrawType_MAX = 2,
    }
}
