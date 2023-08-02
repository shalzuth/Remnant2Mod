using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.PrefabricatorRuntimeSDK;
using SDK.Script.EngineSDK;
using SDK.Script.UMGSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.ConstructionSystemRuntimeSDK
{
    public class ConstructionSystemTool : Object
    {
        public ConstructionSystemTool(nint addr) : base(addr) { }
    }
    public class ConstructionSystemBuildTool : ConstructionSystemTool
    {
        public ConstructionSystemBuildTool(nint addr) : base(addr) { }
        public float TraceDistance { get { return this[nameof(TraceDistance)].GetValue<float>(); } set { this[nameof(TraceDistance)].SetValue<float>(value); } }
        public float CursorRotationStepAngle { get { return this[nameof(CursorRotationStepAngle)].GetValue<float>(); } set { this[nameof(CursorRotationStepAngle)].SetValue<float>(value); } }
        public ConstructionSystemCursor Cursor { get { return this[nameof(Cursor)].As<ConstructionSystemCursor>(); } set { this["Cursor"] = value; } }
        public PrefabricatorAssetInterface ActivePrefabAsset { get { return this[nameof(ActivePrefabAsset)].As<PrefabricatorAssetInterface>(); } set { this["ActivePrefabAsset"] = value; } }
        public void SetActivePrefab(PrefabricatorAssetInterface InActivePrefabAsset) { Invoke(nameof(SetActivePrefab), InActivePrefabAsset); }
        public void HandleInput_RotateCursorStep(float NumSteps) { Invoke(nameof(HandleInput_RotateCursorStep), NumSteps); }
        public void HandleInput_CursorMovePrev() { Invoke(nameof(HandleInput_CursorMovePrev)); }
        public void HandleInput_CursorMoveNext() { Invoke(nameof(HandleInput_CursorMoveNext)); }
        public void HandleInput_ConstructAtCursor() { Invoke(nameof(HandleInput_ConstructAtCursor)); }
    }
    public class ConstructionSystemComponent : ActorComponent
    {
        public ConstructionSystemComponent(nint addr) : base(addr) { }
        public MaterialInterface CursorMaterial { get { return this[nameof(CursorMaterial)].As<MaterialInterface>(); } set { this["CursorMaterial"] = value; } }
        public MaterialInterface CursorInvalidMaterial { get { return this[nameof(CursorInvalidMaterial)].As<MaterialInterface>(); } set { this["CursorInvalidMaterial"] = value; } }
        public float TraceStartDistance { get { return this[nameof(TraceStartDistance)].GetValue<float>(); } set { this[nameof(TraceStartDistance)].SetValue<float>(value); } }
        public float TraceSweepRadius { get { return this[nameof(TraceSweepRadius)].GetValue<float>(); } set { this[nameof(TraceSweepRadius)].SetValue<float>(value); } }
        public Actor ConstructionCameraActor { get { return this[nameof(ConstructionCameraActor)].As<Actor>(); } set { this["ConstructionCameraActor"] = value; } }
        public float ConstructionCameraTransitionTime { get { return this[nameof(ConstructionCameraTransitionTime)].GetValue<float>(); } set { this[nameof(ConstructionCameraTransitionTime)].SetValue<float>(value); } }
        public float ConstructionCameraTransitionExp { get { return this[nameof(ConstructionCameraTransitionExp)].GetValue<float>(); } set { this[nameof(ConstructionCameraTransitionExp)].SetValue<float>(value); } }
        public Object BuildMenuUI { get { return this[nameof(BuildMenuUI)]; } set { this[nameof(BuildMenuUI)] = value; } }
        public ConstructionSystemUIAsset BuildMenuData { get { return this[nameof(BuildMenuData)].As<ConstructionSystemUIAsset>(); } set { this["BuildMenuData"] = value; } }
        public UserWidget BuildMenuUIInstance { get { return this[nameof(BuildMenuUIInstance)].As<UserWidget>(); } set { this["BuildMenuUIInstance"] = value; } }
        public EConstructionSystemToolType ActiveToolType { get { return (EConstructionSystemToolType)this[nameof(ActiveToolType)].GetValue<int>(); } set { this[nameof(ActiveToolType)].SetValue<int>((int)value); } }
        public Object Tools { get { return this[nameof(Tools)]; } set { this[nameof(Tools)] = value; } }
        public void ToggleConstructionSystem() { Invoke(nameof(ToggleConstructionSystem)); }
        public void ShowBuildMenu() { Invoke(nameof(ShowBuildMenu)); }
        public void SetActiveTool(EConstructionSystemToolType InToolType) { Invoke(nameof(SetActiveTool), InToolType); }
        public void HideBuildMenu() { Invoke(nameof(HideBuildMenu)); }
        public ConstructionSystemTool GetTool(EConstructionSystemToolType InToolType) { return Invoke<ConstructionSystemTool>(nameof(GetTool), InToolType); }
        public EConstructionSystemToolType GetActiveToolType() { return Invoke<EConstructionSystemToolType>(nameof(GetActiveToolType)); }
        public ConstructionSystemTool GetActiveTool() { return Invoke<ConstructionSystemTool>(nameof(GetActiveTool)); }
        public void EnableConstructionSystem(EConstructionSystemToolType InToolType) { Invoke(nameof(EnableConstructionSystem), InToolType); }
        public void DisableConstructionSystem() { Invoke(nameof(DisableConstructionSystem)); }
    }
    public class ConstructionSystemItemUserData : AssetUserData
    {
        public ConstructionSystemItemUserData(nint addr) : base(addr) { }
        public int Seed { get { return this[nameof(Seed)].GetValue<int>(); } set { this[nameof(Seed)].SetValue<int>(value); } }
    }
    public class ConstructionSystemCursor : Object
    {
        public ConstructionSystemCursor(nint addr) : base(addr) { }
        public PrefabActor CursorGhostActor { get { return this[nameof(CursorGhostActor)].As<PrefabActor>(); } set { this["CursorGhostActor"] = value; } }
        public int CursorSeed { get { return this[nameof(CursorSeed)].GetValue<int>(); } set { this[nameof(CursorSeed)].SetValue<int>(value); } }
        public MaterialInterface CursorMaterial { get { return this[nameof(CursorMaterial)].As<MaterialInterface>(); } set { this["CursorMaterial"] = value; } }
        public MaterialInterface CursorInvalidMaterial { get { return this[nameof(CursorInvalidMaterial)].As<MaterialInterface>(); } set { this["CursorInvalidMaterial"] = value; } }
        public Array<PrefabricatorConstructionSnapComponent> SnapComponents { get { return new Array<PrefabricatorConstructionSnapComponent>(this[nameof(SnapComponents)].Address); } }
        public int ActiveSnapComponentIndex { get { return this[nameof(ActiveSnapComponentIndex)].GetValue<int>(); } set { this[nameof(ActiveSnapComponentIndex)].SetValue<int>(value); } }
    }
    public class ConstructionSystemRemoveTool : ConstructionSystemTool
    {
        public ConstructionSystemRemoveTool(nint addr) : base(addr) { }
        public float TraceDistance { get { return this[nameof(TraceDistance)].GetValue<float>(); } set { this[nameof(TraceDistance)].SetValue<float>(value); } }
        public Object FocusedActor { get { return this[nameof(FocusedActor)]; } set { this[nameof(FocusedActor)] = value; } }
        public void HandleInput_RemoveAtCursor() { Invoke(nameof(HandleInput_RemoveAtCursor)); }
    }
    public class ConstructionSystemSaveGame : SaveGame
    {
        public ConstructionSystemSaveGame(nint addr) : base(addr) { }
        public Object SaveSlotName { get { return this[nameof(SaveSlotName)]; } set { this[nameof(SaveSlotName)] = value; } }
        public uint UserIndex { get { return this[nameof(UserIndex)].GetValue<uint>(); } set { this[nameof(UserIndex)].SetValue<uint>(value); } }
        public ConstructionSystemSavePlayerInfo PlayerInfo { get { return this[nameof(PlayerInfo)].As<ConstructionSystemSavePlayerInfo>(); } set { this["PlayerInfo"] = value; } }
        public Array<ConstructionSystemSaveConstructedItem> ConstructedItems { get { return new Array<ConstructionSystemSaveConstructedItem>(this[nameof(ConstructedItems)].Address); } }
    }
    public class ConstructionSystemSaveSystem : BlueprintFunctionLibrary
    {
        public ConstructionSystemSaveSystem(nint addr) : base(addr) { }
        public void SaveConstructionSystemLevel(Object WorldContextObject, Object SaveSlotName, int UserIndex, bool bSavePlayerState) { Invoke(nameof(SaveConstructionSystemLevel), WorldContextObject, SaveSlotName, UserIndex, bSavePlayerState); }
        public void LoadConstructionSystemLevel(Object WorldContextObject, Object LevelName, bool bAbsolute, Object SaveSlotName, int UserIndex) { Invoke(nameof(LoadConstructionSystemLevel), WorldContextObject, LevelName, bAbsolute, SaveSlotName, UserIndex); }
        public void HandleConstructionSystemLevelLoad(Object WorldContextObject) { Invoke(nameof(HandleConstructionSystemLevelLoad), WorldContextObject); }
    }
    public class PrefabricatorConstructionSnapComponent : BoxComponent
    {
        public PrefabricatorConstructionSnapComponent(nint addr) : base(addr) { }
        public EPrefabricatorConstructionSnapType SnapType { get { return (EPrefabricatorConstructionSnapType)this[nameof(SnapType)].GetValue<int>(); } set { this[nameof(SnapType)].SetValue<int>((int)value); } }
        public PCSnapConstraintFloor FloorConstraint { get { return this[nameof(FloorConstraint)].As<PCSnapConstraintFloor>(); } set { this["FloorConstraint"] = value; } }
        public PCSnapConstraintWall WallConstraint { get { return this[nameof(WallConstraint)].As<PCSnapConstraintWall>(); } set { this["WallConstraint"] = value; } }
        public bool bAlignToGroundSlope { get { return this[nameof(bAlignToGroundSlope)].Flag; } set { this[nameof(bAlignToGroundSlope)].Flag = value; } }
        public bool bUseMaxGroundSlopeConstraint { get { return this[nameof(bUseMaxGroundSlopeConstraint)].Flag; } set { this[nameof(bUseMaxGroundSlopeConstraint)].Flag = value; } }
        public float MaxGroundPlacementSlope { get { return this[nameof(MaxGroundPlacementSlope)].GetValue<float>(); } set { this[nameof(MaxGroundPlacementSlope)].SetValue<float>(value); } }
    }
    public class PrefabricatorConstructionSnap : Actor
    {
        public PrefabricatorConstructionSnap(nint addr) : base(addr) { }
        public PrefabricatorConstructionSnapComponent ConstructionSnapComponent { get { return this[nameof(ConstructionSnapComponent)].As<PrefabricatorConstructionSnapComponent>(); } set { this["ConstructionSnapComponent"] = value; } }
    }
    public class ConstructionSystemBuildUI : Interface
    {
        public ConstructionSystemBuildUI(nint addr) : base(addr) { }
        public void SetUIAsset(ConstructionSystemUIAsset UIAsset) { Invoke(nameof(SetUIAsset), UIAsset); }
        public void SetConstructionSystem(ConstructionSystemComponent ConstructionSystem) { Invoke(nameof(SetConstructionSystem), ConstructionSystem); }
    }
    public class ConstructionSystemUIAsset : DataAsset
    {
        public ConstructionSystemUIAsset(nint addr) : base(addr) { }
        public Object MenuTitle { get { return this[nameof(MenuTitle)]; } set { this[nameof(MenuTitle)] = value; } }
        public Array<ConstructionSystemUICategory> Categories { get { return new Array<ConstructionSystemUICategory>(this[nameof(Categories)].Address); } }
    }
    public enum EConstructionSystemToolType : int
    {
        BuildTool = 0,
        RemoveTool = 1,
        EConstructionSystemToolType_MAX = 2,
    }
    public enum EConstructionSystemCursorVisiblity : int
    {
        Visible = 0,
        VisibleInvalid = 1,
        Hidden = 2,
        EConstructionSystemCursorVisiblity_MAX = 3,
    }
    public enum EPrefabricatorConstructionSnapType : int
    {
        Floor = 0,
        Wall = 1,
        Object = 2,
        EPrefabricatorConstructionSnapType_MAX = 3,
    }
    public class ConstructionSystemSaveConstructedItem : Object
    {
        public ConstructionSystemSaveConstructedItem(nint addr) : base(addr) { }
        public PrefabricatorAssetInterface PrefabAsset { get { return this[nameof(PrefabAsset)].As<PrefabricatorAssetInterface>(); } set { this["PrefabAsset"] = value; } }
        public int Seed { get { return this[nameof(Seed)].GetValue<int>(); } set { this[nameof(Seed)].SetValue<int>(value); } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
    }
    public class ConstructionSystemSavePlayerInfo : Object
    {
        public ConstructionSystemSavePlayerInfo(nint addr) : base(addr) { }
        public bool bRestorePlayerInfo { get { return this[nameof(bRestorePlayerInfo)].Flag; } set { this[nameof(bRestorePlayerInfo)].Flag = value; } }
        public Transform Transform { get { return this[nameof(Transform)].As<Transform>(); } set { this["Transform"] = value; } }
        public Rotator ControlRotation { get { return this[nameof(ControlRotation)].As<Rotator>(); } set { this["ControlRotation"] = value; } }
    }
    public class PCSnapConstraintFloor : Object
    {
        public PCSnapConstraintFloor(nint addr) : base(addr) { }
        public bool AttachX { get { return this[nameof(AttachX)].Flag; } set { this[nameof(AttachX)].Flag = value; } }
        public bool AttachXNegative { get { return this[nameof(AttachXNegative)].Flag; } set { this[nameof(AttachXNegative)].Flag = value; } }
        public bool AttachY { get { return this[nameof(AttachY)].Flag; } set { this[nameof(AttachY)].Flag = value; } }
        public bool AttachYNegative { get { return this[nameof(AttachYNegative)].Flag; } set { this[nameof(AttachYNegative)].Flag = value; } }
        public bool AttachZ { get { return this[nameof(AttachZ)].Flag; } set { this[nameof(AttachZ)].Flag = value; } }
        public bool AttachZNegative { get { return this[nameof(AttachZNegative)].Flag; } set { this[nameof(AttachZNegative)].Flag = value; } }
    }
    public class PCSnapConstraintWall : Object
    {
        public PCSnapConstraintWall(nint addr) : base(addr) { }
        public bool AttachTop { get { return this[nameof(AttachTop)].Flag; } set { this[nameof(AttachTop)].Flag = value; } }
        public bool AttachBottom { get { return this[nameof(AttachBottom)].Flag; } set { this[nameof(AttachBottom)].Flag = value; } }
        public bool AttachLeft { get { return this[nameof(AttachLeft)].Flag; } set { this[nameof(AttachLeft)].Flag = value; } }
        public bool AttachRight { get { return this[nameof(AttachRight)].Flag; } set { this[nameof(AttachRight)].Flag = value; } }
    }
    public class ConstructionSystemUIPrefabEntry : Object
    {
        public ConstructionSystemUIPrefabEntry(nint addr) : base(addr) { }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Object Tooltip { get { return this[nameof(Tooltip)]; } set { this[nameof(Tooltip)] = value; } }
        public Texture2D Icon { get { return this[nameof(Icon)].As<Texture2D>(); } set { this["Icon"] = value; } }
        public PrefabricatorAssetInterface Prefab { get { return this[nameof(Prefab)].As<PrefabricatorAssetInterface>(); } set { this["Prefab"] = value; } }
    }
    public class ConstructionSystemUICategory : Object
    {
        public ConstructionSystemUICategory(nint addr) : base(addr) { }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Texture2D Icon { get { return this[nameof(Icon)].As<Texture2D>(); } set { this["Icon"] = value; } }
        public Array<ConstructionSystemUIPrefabEntry> PrefabEntries { get { return new Array<ConstructionSystemUIPrefabEntry>(this[nameof(PrefabEntries)].Address); } }
    }
}
