using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.DeveloperSettingsSDK;
namespace SDK.Script.PrefabricatorRuntimeSDK
{
    public class PrefabActor : Actor
    {
        public PrefabActor(nint addr) : base(addr) { }
        public PrefabComponent PrefabComponent { get { return this[nameof(PrefabComponent)].As<PrefabComponent>(); } set { this["PrefabComponent"] = value; } }
        public Guid LastUpdateID { get { return this[nameof(LastUpdateID)].As<Guid>(); } set { this["LastUpdateID"] = value; } }
        public int Seed { get { return this[nameof(Seed)].GetValue<int>(); } set { this[nameof(Seed)].SetValue<int>(value); } }
        public void SavePrefab() { Invoke(nameof(SavePrefab)); }
        public void RandomizeSeed(RandomStream InRandom, bool bRecursive) { Invoke(nameof(RandomizeSeed), InRandom, bRecursive); }
        public void LoadPrefab() { Invoke(nameof(LoadPrefab)); }
        public bool IsPrefabOutdated() { return Invoke<bool>(nameof(IsPrefabOutdated)); }
        public PrefabricatorAsset GetPrefabAsset() { return Invoke<PrefabricatorAsset>(nameof(GetPrefabAsset)); }
    }
    public class ReplicablePrefabActor : PrefabActor
    {
        public ReplicablePrefabActor(nint addr) : base(addr) { }
    }
    public class PrefabComponent : SceneComponent
    {
        public PrefabComponent(nint addr) : base(addr) { }
        public Object PrefabAssetInterface { get { return this[nameof(PrefabAssetInterface)]; } set { this[nameof(PrefabAssetInterface)] = value; } }
    }
    public class PrefabDebugActor : Actor
    {
        public PrefabDebugActor(nint addr) : base(addr) { }
        public Actor Actor { get { return this[nameof(Actor)].As<Actor>(); } set { this["Actor"] = value; } }
        public Array<byte> ActorData { get { return new Array<byte>(this[nameof(ActorData)].Address); } }
    }
    public class PrefabRandomizer : Actor
    {
        public PrefabRandomizer(nint addr) : base(addr) { }
        public bool bRandomizeOnBeginPlay { get { return this[nameof(bRandomizeOnBeginPlay)].Flag; } set { this[nameof(bRandomizeOnBeginPlay)].Flag = value; } }
        public int SeedOffset { get { return this[nameof(SeedOffset)].GetValue<int>(); } set { this[nameof(SeedOffset)].SetValue<int>(value); } }
        public float MaxBuildTimePerFrame { get { return this[nameof(MaxBuildTimePerFrame)].GetValue<float>(); } set { this[nameof(MaxBuildTimePerFrame)].SetValue<float>(value); } }
        public Object OnRandomizationComplete { get { return this[nameof(OnRandomizationComplete)]; } set { this[nameof(OnRandomizationComplete)] = value; } }
        public bool bFastSyncBuild { get { return this[nameof(bFastSyncBuild)].Flag; } set { this[nameof(bFastSyncBuild)].Flag = value; } }
        public Array<PrefabActor> ActorsToRandomize { get { return new Array<PrefabActor>(this[nameof(ActorsToRandomize)].Address); } }
        public void Randomize(int InSeed) { Invoke(nameof(Randomize), InSeed); }
    }
    public class PrefabricatorProperty : Object
    {
        public PrefabricatorProperty(nint addr) : base(addr) { }
        public Object PropertyName { get { return this[nameof(PropertyName)]; } set { this[nameof(PropertyName)] = value; } }
        public Object ExportedValue { get { return this[nameof(ExportedValue)]; } set { this[nameof(ExportedValue)] = value; } }
        public Array<PrefabricatorPropertyAssetMapping> AssetSoftReferenceMappings { get { return new Array<PrefabricatorPropertyAssetMapping>(this[nameof(AssetSoftReferenceMappings)].Address); } }
        public bool bIsCrossReferencedActor { get { return this[nameof(bIsCrossReferencedActor)].Flag; } set { this[nameof(bIsCrossReferencedActor)].Flag = value; } }
        public Guid CrossReferencePrefabActorId { get { return this[nameof(CrossReferencePrefabActorId)].As<Guid>(); } set { this["CrossReferencePrefabActorId"] = value; } }
    }
    public class PrefabricatorEventListener : Object
    {
        public PrefabricatorEventListener(nint addr) : base(addr) { }
        public void PostSpawn(PrefabActor Prefab) { Invoke(nameof(PostSpawn), Prefab); }
    }
    public class PrefabricatorAssetInterface : Object
    {
        public PrefabricatorAssetInterface(nint addr) : base(addr) { }
        public Object EventListener { get { return this[nameof(EventListener)]; } set { this[nameof(EventListener)] = value; } }
        public bool bReplicates { get { return this[nameof(bReplicates)].Flag; } set { this[nameof(bReplicates)].Flag = value; } }
    }
    public class PrefabricatorAsset : PrefabricatorAssetInterface
    {
        public PrefabricatorAsset(nint addr) : base(addr) { }
        public Array<PrefabricatorActorData> ActorData { get { return new Array<PrefabricatorActorData>(this[nameof(ActorData)].Address); } }
        public byte PrefabMobility { get { return this[nameof(PrefabMobility)].GetValue<byte>(); } set { this[nameof(PrefabMobility)].SetValue<byte>(value); } }
        public Guid LastUpdateID { get { return this[nameof(LastUpdateID)].As<Guid>(); } set { this["LastUpdateID"] = value; } }
        public ThumbnailInfo ThumbnailInfo { get { return this[nameof(ThumbnailInfo)].As<ThumbnailInfo>(); } set { this["ThumbnailInfo"] = value; } }
        public uint Version { get { return this[nameof(Version)].GetValue<uint>(); } set { this[nameof(Version)].SetValue<uint>(value); } }
    }
    public class PrefabricatorAssetCollection : PrefabricatorAssetInterface
    {
        public PrefabricatorAssetCollection(nint addr) : base(addr) { }
        public Array<PrefabricatorAssetCollectionItem> Prefabs { get { return new Array<PrefabricatorAssetCollectionItem>(this[nameof(Prefabs)].Address); } }
        public uint Version { get { return this[nameof(Version)].GetValue<uint>(); } set { this[nameof(Version)].SetValue<uint>(value); } }
    }
    public class PrefabricatorAssetUserData : AssetUserData
    {
        public PrefabricatorAssetUserData(nint addr) : base(addr) { }
        public Object PrefabActor { get { return this[nameof(PrefabActor)]; } set { this[nameof(PrefabActor)] = value; } }
        public Guid ItemId { get { return this[nameof(ItemId)].As<Guid>(); } set { this["ItemId"] = value; } }
    }
    public class PrefabricatorBlueprintLibrary : BlueprintFunctionLibrary
    {
        public PrefabricatorBlueprintLibrary(nint addr) : base(addr) { }
        public void UnlinkPrefab(PrefabActor PrefabActor) { Invoke(nameof(UnlinkPrefab), PrefabActor); }
        public PrefabActor SpawnPrefab(Object WorldContextObject, PrefabricatorAssetInterface Prefab, Transform Transform, int Seed) { return Invoke<PrefabActor>(nameof(SpawnPrefab), WorldContextObject, Prefab, Transform, Seed); }
        public void SetPrefabAsset(PrefabActor PrefabActor, PrefabricatorAssetInterface Prefab, bool bReloadPrefab) { Invoke(nameof(SetPrefabAsset), PrefabActor, Prefab, bReloadPrefab); }
        public void RandomizePrefab(PrefabActor PrefabActor, RandomStream InRandom) { Invoke(nameof(RandomizePrefab), PrefabActor, InRandom); }
        public void GetAllAttachedActors(Actor Prefab, Array<Actor> AttachedActors) { Invoke(nameof(GetAllAttachedActors), Prefab, AttachedActors); }
        public PrefabActor FindTopMostPrefabActor(Actor InActor) { return Invoke<PrefabActor>(nameof(FindTopMostPrefabActor), InActor); }
    }
    public class PrefabricatorSettings : DeveloperSettings
    {
        public PrefabricatorSettings(nint addr) : base(addr) { }
        public EPrefabricatorPivotPosition PivotPosition { get { return (EPrefabricatorPivotPosition)this[nameof(PivotPosition)].GetValue<int>(); } set { this[nameof(PivotPosition)].SetValue<int>((int)value); } }
        public bool bAllowDynamicUpdate { get { return this[nameof(bAllowDynamicUpdate)].Flag; } set { this[nameof(bAllowDynamicUpdate)].Flag = value; } }
        public Object IgnoreBoundingBoxForObjects { get { return this[nameof(IgnoreBoundingBoxForObjects)]; } set { this[nameof(IgnoreBoundingBoxForObjects)] = value; } }
        public float DefaultThumbnailPitch { get { return this[nameof(DefaultThumbnailPitch)].GetValue<float>(); } set { this[nameof(DefaultThumbnailPitch)].SetValue<float>(value); } }
        public float DefaultThumbnailYaw { get { return this[nameof(DefaultThumbnailYaw)].GetValue<float>(); } set { this[nameof(DefaultThumbnailYaw)].SetValue<float>(value); } }
        public float DefaultThumbnailZoom { get { return this[nameof(DefaultThumbnailZoom)].GetValue<float>(); } set { this[nameof(DefaultThumbnailZoom)].SetValue<float>(value); } }
    }
    public class PrefabSeedLinkerComponent : SceneComponent
    {
        public PrefabSeedLinkerComponent(nint addr) : base(addr) { }
    }
    public class PrefabSeedLinker : Actor
    {
        public PrefabSeedLinker(nint addr) : base(addr) { }
        public Array<Object> LinkedActors { get { return new Array<Object>(this[nameof(LinkedActors)].Address); } }
        public PrefabSeedLinkerComponent SeedLinkerComponent { get { return this[nameof(SeedLinkerComponent)].As<PrefabSeedLinkerComponent>(); } set { this["SeedLinkerComponent"] = value; } }
    }
    public enum EPrefabricatorPivotPosition : int
    {
        ExtremeLeft = 0,
        ExtremeRight = 1,
        Center = 2,
        EPrefabricatorPivotPosition_MAX = 3,
    }
    public class PrefabricatorPropertyAssetMapping : Object
    {
        public PrefabricatorPropertyAssetMapping(nint addr) : base(addr) { }
        public SoftObjectPath AssetReference { get { return this[nameof(AssetReference)].As<SoftObjectPath>(); } set { this["AssetReference"] = value; } }
        public Object AssetClassName { get { return this[nameof(AssetClassName)]; } set { this[nameof(AssetClassName)] = value; } }
        public Object AssetObjectPath { get { return this[nameof(AssetObjectPath)]; } set { this[nameof(AssetObjectPath)] = value; } }
        public bool bUseQuotes { get { return this[nameof(bUseQuotes)].Flag; } set { this[nameof(bUseQuotes)].Flag = value; } }
    }
    public class PrefabricatorComponentData : Object
    {
        public PrefabricatorComponentData(nint addr) : base(addr) { }
        public Transform RelativeTransform { get { return this[nameof(RelativeTransform)].As<Transform>(); } set { this["RelativeTransform"] = value; } }
        public Object ComponentName { get { return this[nameof(ComponentName)]; } set { this[nameof(ComponentName)] = value; } }
        public Array<PrefabricatorProperty> Properties { get { return new Array<PrefabricatorProperty>(this[nameof(Properties)].Address); } }
    }
    public class PrefabricatorActorData : Object
    {
        public PrefabricatorActorData(nint addr) : base(addr) { }
        public Guid PrefabItemID { get { return this[nameof(PrefabItemID)].As<Guid>(); } set { this["PrefabItemID"] = value; } }
        public Transform RelativeTransform { get { return this[nameof(RelativeTransform)].As<Transform>(); } set { this["RelativeTransform"] = value; } }
        public Object ClassPath { get { return this[nameof(ClassPath)]; } set { this[nameof(ClassPath)] = value; } }
        public SoftClassPath ClassPathRef { get { return this[nameof(ClassPathRef)].As<SoftClassPath>(); } set { this["ClassPathRef"] = value; } }
        public Array<PrefabricatorProperty> Properties { get { return new Array<PrefabricatorProperty>(this[nameof(Properties)].Address); } }
        public Array<PrefabricatorComponentData> Components { get { return new Array<PrefabricatorComponentData>(this[nameof(Components)].Address); } }
    }
    public class PrefabricatorAssetCollectionItem : Object
    {
        public PrefabricatorAssetCollectionItem(nint addr) : base(addr) { }
        public Object PrefabAsset { get { return this[nameof(PrefabAsset)]; } set { this[nameof(PrefabAsset)] = value; } }
        public float Weight { get { return this[nameof(Weight)].GetValue<float>(); } set { this[nameof(Weight)].SetValue<float>(value); } }
    }
}
