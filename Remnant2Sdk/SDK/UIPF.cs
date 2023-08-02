using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.FoliageSDK;
namespace SDK.Script.UIPFSDK
{
    public class UIPFActor : Actor
    {
        public UIPFActor(nint addr) : base(addr) { }
        public HierarchicalInstancedStaticMeshComponent MyISM { get { return this[nameof(MyISM)].As<HierarchicalInstancedStaticMeshComponent>(); } set { this["MyISM"] = value; } }
        public SkeletalMeshComponent SkeletalMeshComp { get { return this[nameof(SkeletalMeshComp)].As<SkeletalMeshComponent>(); } set { this["SkeletalMeshComp"] = value; } }
        public StaticMeshComponent BlockingCollisionOverideSMComp { get { return this[nameof(BlockingCollisionOverideSMComp)].As<StaticMeshComponent>(); } set { this["BlockingCollisionOverideSMComp"] = value; } }
        public StaticMesh SM { get { return this[nameof(SM)].As<StaticMesh>(); } set { this["SM"] = value; } }
        public SkeletalMesh SkelMesh { get { return this[nameof(SkelMesh)].As<SkeletalMesh>(); } set { this["SkelMesh"] = value; } }
        public void TrySleep() { Invoke(nameof(TrySleep)); }
        public void DelayPhysEnabled() { Invoke(nameof(DelayPhysEnabled)); }
    }
    public class UIPFImpulse : Actor
    {
        public UIPFImpulse(nint addr) : base(addr) { }
        public SphereComponent SphereComp { get { return this[nameof(SphereComp)].As<SphereComponent>(); } set { this["SphereComp"] = value; } }
        public void InitializeImpulse(float ImpulseRadius, bool UsingTruePhys, bool UsingShaderInt, float ImpulseStrength) { Invoke(nameof(InitializeImpulse), ImpulseRadius, UsingTruePhys, UsingShaderInt, ImpulseStrength); }
    }
    public class IPFTypes : DataTable
    {
        public IPFTypes(nint addr) : base(addr) { }
    }
    public class UIPFInteractorManager : WorldSubsystem
    {
        public UIPFInteractorManager(nint addr) : base(addr) { }
        public int MaxInteractorsPerFrame { get { return this[nameof(MaxInteractorsPerFrame)].GetValue<int>(); } set { this[nameof(MaxInteractorsPerFrame)].SetValue<int>(value); } }
        public int MaxActivationsPerFrame { get { return this[nameof(MaxActivationsPerFrame)].GetValue<int>(); } set { this[nameof(MaxActivationsPerFrame)].SetValue<int>(value); } }
        public Array<UIPFInteractor> Interactors { get { return new Array<UIPFInteractor>(this[nameof(Interactors)].Address); } }
    }
    public class UIPFInteractor : PrimitiveComponent
    {
        public UIPFInteractor(nint addr) : base(addr) { }
        public bool bLimitTickRate { get { return this[nameof(bLimitTickRate)].Flag; } set { this[nameof(bLimitTickRate)].Flag = value; } }
        public float TickRate { get { return this[nameof(TickRate)].GetValue<float>(); } set { this[nameof(TickRate)].SetValue<float>(value); } }
        public bool bInteractWithGrass { get { return this[nameof(bInteractWithGrass)].Flag; } set { this[nameof(bInteractWithGrass)].Flag = value; } }
        public float fGrassInteractionDiameter { get { return this[nameof(fGrassInteractionDiameter)].GetValue<float>(); } set { this[nameof(fGrassInteractionDiameter)].SetValue<float>(value); } }
        public bool bOverrideInteractorActivationDistance { get { return this[nameof(bOverrideInteractorActivationDistance)].Flag; } set { this[nameof(bOverrideInteractorActivationDistance)].Flag = value; } }
        public float InteractorActivationDistance { get { return this[nameof(InteractorActivationDistance)].GetValue<float>(); } set { this[nameof(InteractorActivationDistance)].SetValue<float>(value); } }
        public bool bPerCompVelocity { get { return this[nameof(bPerCompVelocity)].Flag; } set { this[nameof(bPerCompVelocity)].Flag = value; } }
        public bool bForceFixedInteractionStrength { get { return this[nameof(bForceFixedInteractionStrength)].Flag; } set { this[nameof(bForceFixedInteractionStrength)].Flag = value; } }
        public float FixedStrength { get { return this[nameof(FixedStrength)].GetValue<float>(); } set { this[nameof(FixedStrength)].SetValue<float>(value); } }
        public bool EnablePhysicsInteraction { get { return this[nameof(EnablePhysicsInteraction)].Flag; } set { this[nameof(EnablePhysicsInteraction)].Flag = value; } }
        public float PhysicsActivationRadius { get { return this[nameof(PhysicsActivationRadius)].GetValue<float>(); } set { this[nameof(PhysicsActivationRadius)].SetValue<float>(value); } }
        public float PhysicsDeactivationRadius { get { return this[nameof(PhysicsDeactivationRadius)].GetValue<float>(); } set { this[nameof(PhysicsDeactivationRadius)].SetValue<float>(value); } }
    }
    public class UIPFManager : Actor
    {
        public UIPFManager(nint addr) : base(addr) { }
        public bool UseShaderInteraction { get { return this[nameof(UseShaderInteraction)].Flag; } set { this[nameof(UseShaderInteraction)].Flag = value; } }
        public bool UseTruePhysics { get { return this[nameof(UseTruePhysics)].Flag; } set { this[nameof(UseTruePhysics)].Flag = value; } }
        public bool UseShaderIntSwitch { get { return this[nameof(UseShaderIntSwitch)].Flag; } set { this[nameof(UseShaderIntSwitch)].Flag = value; } }
        public bool UseShaderIntIOS { get { return this[nameof(UseShaderIntIOS)].Flag; } set { this[nameof(UseShaderIntIOS)].Flag = value; } }
        public bool UseShaderIntAndroid { get { return this[nameof(UseShaderIntAndroid)].Flag; } set { this[nameof(UseShaderIntAndroid)].Flag = value; } }
        public bool UseTruePhysicsSwitch { get { return this[nameof(UseTruePhysicsSwitch)].Flag; } set { this[nameof(UseTruePhysicsSwitch)].Flag = value; } }
        public bool UseTruePhysicsPS4 { get { return this[nameof(UseTruePhysicsPS4)].Flag; } set { this[nameof(UseTruePhysicsPS4)].Flag = value; } }
        public bool UseTruePhysicsXbox { get { return this[nameof(UseTruePhysicsXbox)].Flag; } set { this[nameof(UseTruePhysicsXbox)].Flag = value; } }
        public bool UseTruePhysicsIOS { get { return this[nameof(UseTruePhysicsIOS)].Flag; } set { this[nameof(UseTruePhysicsIOS)].Flag = value; } }
        public bool UseTruePhysicsAndroid { get { return this[nameof(UseTruePhysicsAndroid)].Flag; } set { this[nameof(UseTruePhysicsAndroid)].Flag = value; } }
        public bool ActivateOnImpulse { get { return this[nameof(ActivateOnImpulse)].Flag; } set { this[nameof(ActivateOnImpulse)].Flag = value; } }
        public bool bLimitTickRate { get { return this[nameof(bLimitTickRate)].Flag; } set { this[nameof(bLimitTickRate)].Flag = value; } }
        public float TickRate { get { return this[nameof(TickRate)].GetValue<float>(); } set { this[nameof(TickRate)].SetValue<float>(value); } }
        public float MaxPhysicsActivationDistance { get { return this[nameof(MaxPhysicsActivationDistance)].GetValue<float>(); } set { this[nameof(MaxPhysicsActivationDistance)].SetValue<float>(value); } }
        public float DefaultInteractorActivationDistance { get { return this[nameof(DefaultInteractorActivationDistance)].GetValue<float>(); } set { this[nameof(DefaultInteractorActivationDistance)].SetValue<float>(value); } }
        public DataTable FoliageDataTable { get { return this[nameof(FoliageDataTable)].As<DataTable>(); } set { this["FoliageDataTable"] = value; } }
        public MaterialParameterCollection MPC_UIPF { get { return this[nameof(MPC_UIPF)].As<MaterialParameterCollection>(); } set { this["MPC_UIPF"] = value; } }
        public Object UIPFActorClass { get { return this[nameof(UIPFActorClass)]; } set { this[nameof(UIPFActorClass)] = value; } }
        public bool bOverrideTraceChannel { get { return this[nameof(bOverrideTraceChannel)].Flag; } set { this[nameof(bOverrideTraceChannel)].Flag = value; } }
        public byte FoliageTraceChannel { get { return this[nameof(FoliageTraceChannel)].GetValue<byte>(); } set { this[nameof(FoliageTraceChannel)].SetValue<byte>(value); } }
        public MaterialInterface ForceSplatMat { get { return this[nameof(ForceSplatMat)].As<MaterialInterface>(); } set { this["ForceSplatMat"] = value; } }
        public MaterialInstanceDynamic AccumulatorInst { get { return this[nameof(AccumulatorInst)].As<MaterialInstanceDynamic>(); } set { this["AccumulatorInst"] = value; } }
        public MaterialInstanceDynamic ManualSplatInst { get { return this[nameof(ManualSplatInst)].As<MaterialInstanceDynamic>(); } set { this["ManualSplatInst"] = value; } }
        public MaterialInstanceDynamic VelocitySplatInst { get { return this[nameof(VelocitySplatInst)].As<MaterialInstanceDynamic>(); } set { this["VelocitySplatInst"] = value; } }
        public Canvas Canvas { get { return this[nameof(Canvas)].As<Canvas>(); } set { this["Canvas"] = value; } }
        public Vector2D Size { get { return this[nameof(Size)].As<Vector2D>(); } set { this["Size"] = value; } }
        public DrawToRenderTargetContext Context { get { return this[nameof(Context)].As<DrawToRenderTargetContext>(); } set { this["Context"] = value; } }
        public Canvas CanvasInteract { get { return this[nameof(CanvasInteract)].As<Canvas>(); } set { this["CanvasInteract"] = value; } }
        public Vector2D SizeInteract { get { return this[nameof(SizeInteract)].As<Vector2D>(); } set { this["SizeInteract"] = value; } }
        public DrawToRenderTargetContext ContextInteract { get { return this[nameof(ContextInteract)].As<DrawToRenderTargetContext>(); } set { this["ContextInteract"] = value; } }
        public Array<FoliagePool> FoliageTypes { get { return new Array<FoliagePool>(this[nameof(FoliageTypes)].Address); } }
        public void ImpulseAtLocation(Vector Location, float ImpulseDiameter, float ImpulseStrength) { Invoke(nameof(ImpulseAtLocation), Location, ImpulseDiameter, ImpulseStrength); }
        public void ForceAppliedAtLocation(Vector Loc, float Strength) { Invoke(nameof(ForceAppliedAtLocation), Loc, Strength); }
        public void FoliageForceAtLocation(float fStrength, float fSizePercent, Vector HitLocation, bool bIsImpulse) { Invoke(nameof(FoliageForceAtLocation), fStrength, fSizePercent, HitLocation, bIsImpulse); }
    }
    public class UIPFInstancedStaticMeshComponent : FoliageInstancedStaticMeshComponent
    {
        public UIPFInstancedStaticMeshComponent(nint addr) : base(addr) { }
    }
    public class UIPFType : TableRowBase
    {
        public UIPFType(nint addr) : base(addr) { }
        public Object StaticMesh { get { return this[nameof(StaticMesh)]; } set { this[nameof(StaticMesh)] = value; } }
        public Object SkeletalMesh { get { return this[nameof(SkeletalMesh)]; } set { this[nameof(SkeletalMesh)] = value; } }
        public Object OneshotVFX { get { return this[nameof(OneshotVFX)]; } set { this[nameof(OneshotVFX)] = value; } }
        public float OneshotVFXTriggerRange { get { return this[nameof(OneshotVFXTriggerRange)].GetValue<float>(); } set { this[nameof(OneshotVFXTriggerRange)].SetValue<float>(value); } }
        public float SleepThreshold { get { return this[nameof(SleepThreshold)].GetValue<float>(); } set { this[nameof(SleepThreshold)].SetValue<float>(value); } }
        public float BlendTime { get { return this[nameof(BlendTime)].GetValue<float>(); } set { this[nameof(BlendTime)].SetValue<float>(value); } }
        public bool KinematicBlocksPawn { get { return this[nameof(KinematicBlocksPawn)].Flag; } set { this[nameof(KinematicBlocksPawn)].Flag = value; } }
        public StaticMesh StaticCollisionOverride { get { return this[nameof(StaticCollisionOverride)].As<StaticMesh>(); } set { this["StaticCollisionOverride"] = value; } }
        public bool bDebugMakeColliderVisible { get { return this[nameof(bDebugMakeColliderVisible)].Flag; } set { this[nameof(bDebugMakeColliderVisible)].Flag = value; } }
        public Object CollisionProfile { get { return this[nameof(CollisionProfile)]; } set { this[nameof(CollisionProfile)] = value; } }
    }
    public class InteractorManagerTickFunction : TickFunction
    {
        public InteractorManagerTickFunction(nint addr) : base(addr) { }
    }
    public class FoliagePool : Object
    {
        public FoliagePool(nint addr) : base(addr) { }
        public Array<UIPFActor> PoolActors { get { return new Array<UIPFActor>(this[nameof(PoolActors)].Address); } }
    }
}
