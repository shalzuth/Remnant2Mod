using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.GunfireRuntimeSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.PhysicsCoreSDK;
using SDK.Script.GunfireSaveSystemSDK;
using SDK.Script.OnlineSubsystemUtilsSDK;
using SDK.Script.AIModuleSDK;
using SDK.Script.EnhancedInputSDK;
using SDK.Script.UMGSDK;
namespace SDK.Script.RemnantSDK
{
    public class AccountAward : Object
    {
        public AccountAward(nint addr) : base(addr) { }
        public Object Label { get { return this[nameof(Label)]; } set { this[nameof(Label)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public Object Requirement { get { return this[nameof(Requirement)]; } set { this[nameof(Requirement)] = value; } }
        public Texture2D Image { get { return this[nameof(Image)].As<Texture2D>(); } set { this["Image"] = value; } }
        public bool Silent { get { return this[nameof(Silent)].Flag; } set { this[nameof(Silent)].Flag = value; } }
        public bool bAllowDuplicates { get { return this[nameof(bAllowDuplicates)].Flag; } set { this[nameof(bAllowDuplicates)].Flag = value; } }
        public bool bNotifyOnlyOnInitialAward { get { return this[nameof(bNotifyOnlyOnInitialAward)].Flag; } set { this[nameof(bNotifyOnlyOnInitialAward)].Flag = value; } }
    }
    public class ActionInfiniteStamina : ActionBase
    {
        public ActionInfiniteStamina(nint addr) : base(addr) { }
        public float AIMaxDistance { get { return this[nameof(AIMaxDistance)].GetValue<float>(); } set { this[nameof(AIMaxDistance)].SetValue<float>(value); } }
        public float UpdateFrequency { get { return this[nameof(UpdateFrequency)].GetValue<float>(); } set { this[nameof(UpdateFrequency)].SetValue<float>(value); } }
        public Object InfiniteStaminaTag { get { return this[nameof(InfiniteStaminaTag)]; } set { this[nameof(InfiniteStaminaTag)] = value; } }
        public bool bHasInfiniteStamina { get { return this[nameof(bHasInfiniteStamina)].Flag; } set { this[nameof(bHasInfiniteStamina)].Flag = value; } }
        public void UpdateInfiniteStamina() { Invoke(nameof(UpdateInfiniteStamina)); }
        public void OnRep_HasInfiniteStamina() { Invoke(nameof(OnRep_HasInfiniteStamina)); }
    }
    public class Armor : Equipment
    {
        public Armor(nint addr) : base(addr) { }
    }
    public class DamageClassBuildup : DamageClass
    {
        public DamageClassBuildup(nint addr) : base(addr) { }
        public EBuildupMethod Method { get { return (EBuildupMethod)this[nameof(Method)].GetValue<int>(); } set { this[nameof(Method)].SetValue<int>((int)value); } }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
        public float Scale { get { return this[nameof(Scale)].GetValue<float>(); } set { this[nameof(Scale)].SetValue<float>(value); } }
        public CurveFloat Curve { get { return this[nameof(Curve)].As<CurveFloat>(); } set { this["Curve"] = value; } }
        public float GetBuildupValue(DamageInfo DamageInfo, float CurrentBuildup) { return Invoke<float>(nameof(GetBuildupValue), DamageInfo, CurrentBuildup); }
    }
    public class FlashlightIlluminationInterface : Interface
    {
        public FlashlightIlluminationInterface(nint addr) : base(addr) { }
        public void OnFlashlightEndOverlap(Actor LightOwner) { Invoke(nameof(OnFlashlightEndOverlap), LightOwner); }
        public void OnFlashlightBeginOverlap(Actor LightOwner) { Invoke(nameof(OnFlashlightBeginOverlap), LightOwner); }
    }
    public class RadialShortcutComponent : ActorComponent
    {
        public RadialShortcutComponent(nint addr) : base(addr) { }
    }
    public class RemnantGameType : Object
    {
        public RemnantGameType(nint addr) : base(addr) { }
        public Object Label { get { return this[nameof(Label)]; } set { this[nameof(Label)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
    }
    public class RemnantSettings : Object
    {
        public RemnantSettings(nint addr) : base(addr) { }
        public float ModPowerSplashScalar { get { return this[nameof(ModPowerSplashScalar)].GetValue<float>(); } set { this[nameof(ModPowerSplashScalar)].SetValue<float>(value); } }
        public float ModPowerSplashFromOtherModScalar { get { return this[nameof(ModPowerSplashFromOtherModScalar)].GetValue<float>(); } set { this[nameof(ModPowerSplashFromOtherModScalar)].SetValue<float>(value); } }
        public float BonusModPower { get { return this[nameof(BonusModPower)].GetValue<float>(); } set { this[nameof(BonusModPower)].SetValue<float>(value); } }
        public Object ModDamageClass { get { return this[nameof(ModDamageClass)]; } set { this[nameof(ModDamageClass)] = value; } }
        public bool bAnalogCursorOverridesMouseLock { get { return this[nameof(bAnalogCursorOverridesMouseLock)].Flag; } set { this[nameof(bAnalogCursorOverridesMouseLock)].Flag = value; } }
        public EMouseLockMode AnalogCursorMouseLockMode { get { return (EMouseLockMode)this[nameof(AnalogCursorMouseLockMode)].GetValue<int>(); } set { this[nameof(AnalogCursorMouseLockMode)].SetValue<int>((int)value); } }
        public CursorSettings AnalogCursorMovementSettings { get { return this[nameof(AnalogCursorMovementSettings)].As<CursorSettings>(); } set { this["AnalogCursorMovementSettings"] = value; } }
        public Array<DirectoryPath> QuestDirectoryBlacklist { get { return new Array<DirectoryPath>(this[nameof(QuestDirectoryBlacklist)].Address); } }
        public float PingDistance { get { return this[nameof(PingDistance)].GetValue<float>(); } set { this[nameof(PingDistance)].SetValue<float>(value); } }
    }
    public class RemnantTrait : Trait
    {
        public RemnantTrait(nint addr) : base(addr) { }
        public void SetTraitProgress(int Progress) { Invoke(nameof(SetTraitProgress), Progress); }
        public int GetTraitProgress() { return Invoke<int>(nameof(GetTraitProgress)); }
    }
    public class ArchetypeAward : AccountAward
    {
        public ArchetypeAward(nint addr) : base(addr) { }
        public Object Archetype { get { return this[nameof(Archetype)]; } set { this[nameof(Archetype)] = value; } }
        public Object GetEngramItem() { return Invoke<Object>(nameof(GetEngramItem)); }
        public Object GetArchetypeTrait() { return Invoke<Object>(nameof(GetArchetypeTrait)); }
    }
    public class EmoteAward : AccountAward
    {
        public EmoteAward(nint addr) : base(addr) { }
        public Object Emote { get { return this[nameof(Emote)]; } set { this[nameof(Emote)] = value; } }
    }
    public class ItemAward : AccountAward
    {
        public ItemAward(nint addr) : base(addr) { }
        public Object Item { get { return this[nameof(Item)]; } set { this[nameof(Item)] = value; } }
        public int Level { get { return this[nameof(Level)].GetValue<int>(); } set { this[nameof(Level)].SetValue<int>(value); } }
        public bool bAutoEquip { get { return this[nameof(bAutoEquip)].Flag; } set { this[nameof(bAutoEquip)].Flag = value; } }
    }
    public class SpawnTableAccountAward : SpawnTableEntry
    {
        public SpawnTableAccountAward(nint addr) : base(addr) { }
        public Object Award { get { return this[nameof(Award)]; } set { this[nameof(Award)] = value; } }
        public bool bHardcoreOnly { get { return this[nameof(bHardcoreOnly)].Flag; } set { this[nameof(bHardcoreOnly)].Flag = value; } }
    }
    public class ActionBuff : ActionBase
    {
        public ActionBuff(nint addr) : base(addr) { }
        public float Duration { get { return this[nameof(Duration)].GetValue<float>(); } set { this[nameof(Duration)].SetValue<float>(value); } }
        public bool Persistent { get { return this[nameof(Persistent)].Flag; } set { this[nameof(Persistent)].Flag = value; } }
        public Object ContextualDialogTrigger { get { return this[nameof(ContextualDialogTrigger)]; } set { this[nameof(ContextualDialogTrigger)] = value; } }
        public float ContextualDialogTriggerRate { get { return this[nameof(ContextualDialogTriggerRate)].GetValue<float>(); } set { this[nameof(ContextualDialogTriggerRate)].SetValue<float>(value); } }
        public bool IgnoreOwnerTimeDilation { get { return this[nameof(IgnoreOwnerTimeDilation)].Flag; } set { this[nameof(IgnoreOwnerTimeDilation)].Flag = value; } }
        public int VisualPriority { get { return this[nameof(VisualPriority)].GetValue<int>(); } set { this[nameof(VisualPriority)].SetValue<int>(value); } }
        public float ElapsedTime { get { return this[nameof(ElapsedTime)].GetValue<float>(); } set { this[nameof(ElapsedTime)].SetValue<float>(value); } }
        public ActorCustomizationComponent CachedVisuals { get { return this[nameof(CachedVisuals)].As<ActorCustomizationComponent>(); } set { this["CachedVisuals"] = value; } }
        public ActionComponent CachedActions { get { return this[nameof(CachedActions)].As<ActionComponent>(); } set { this["CachedActions"] = value; } }
        public void ResetTimerWithNewDuration(float InDuration) { Invoke(nameof(ResetTimerWithNewDuration), InDuration); }
        public void ResetTimer() { Invoke(nameof(ResetTimer)); }
        public void PauseDuration(bool Paused) { Invoke(nameof(PauseDuration), Paused); }
        public bool IsDurationPaused() { return Invoke<bool>(nameof(IsDurationPaused)); }
        public float GetRemainingTime() { return Invoke<float>(nameof(GetRemainingTime)); }
        public float GetElapsedTimePct() { return Invoke<float>(nameof(GetElapsedTimePct)); }
        public bool GetDesiredVisual(Object Slot, Object ID) { return Invoke<bool>(nameof(GetDesiredVisual), Slot, ID); }
        public void ApplyTimerDelta(float DeltaTime) { Invoke(nameof(ApplyTimerDelta), DeltaTime); }
    }
    public class ActionShield : ActionBuff
    {
        public ActionShield(nint addr) : base(addr) { }
        public float ShieldMax { get { return this[nameof(ShieldMax)].GetValue<float>(); } set { this[nameof(ShieldMax)].SetValue<float>(value); } }
        public float ShieldValue { get { return this[nameof(ShieldValue)].GetValue<float>(); } set { this[nameof(ShieldValue)].SetValue<float>(value); } }
        public float IncomingDamageScalar { get { return this[nameof(IncomingDamageScalar)].GetValue<float>(); } set { this[nameof(IncomingDamageScalar)].SetValue<float>(value); } }
        public Array<Object> ShieldedTags { get { return new Array<Object>(this[nameof(ShieldedTags)].Address); } }
        public PhysicalMaterial PhysMatOverride { get { return this[nameof(PhysMatOverride)].As<PhysicalMaterial>(); } set { this["PhysMatOverride"] = value; } }
        public Object PhysMatShieldMatParamName { get { return this[nameof(PhysMatShieldMatParamName)]; } set { this[nameof(PhysMatShieldMatParamName)] = value; } }
        public float PhysMatAnimationTweenTime { get { return this[nameof(PhysMatAnimationTweenTime)].GetValue<float>(); } set { this[nameof(PhysMatAnimationTweenTime)].SetValue<float>(value); } }
        public float PhysMatAnimationExponent { get { return this[nameof(PhysMatAnimationExponent)].GetValue<float>(); } set { this[nameof(PhysMatAnimationExponent)].SetValue<float>(value); } }
        public float ShieldMaterialMinValue { get { return this[nameof(ShieldMaterialMinValue)].GetValue<float>(); } set { this[nameof(ShieldMaterialMinValue)].SetValue<float>(value); } }
        public float ShieldMaterialMaxValue { get { return this[nameof(ShieldMaterialMaxValue)].GetValue<float>(); } set { this[nameof(ShieldMaterialMaxValue)].SetValue<float>(value); } }
        public WeakAudioComponentGunfire TrackedActiveSound { get { return this[nameof(TrackedActiveSound)].As<WeakAudioComponentGunfire>(); } set { this["TrackedActiveSound"] = value; } }
        public Object ShieldBreakStateName { get { return this[nameof(ShieldBreakStateName)]; } set { this[nameof(ShieldBreakStateName)] = value; } }
        public bool FinishActionOnBroken { get { return this[nameof(FinishActionOnBroken)].Flag; } set { this[nameof(FinishActionOnBroken)].Flag = value; } }
        public bool ShouldDecay { get { return this[nameof(ShouldDecay)].Flag; } set { this[nameof(ShouldDecay)].Flag = value; } }
        public float DecayRate { get { return this[nameof(DecayRate)].GetValue<float>(); } set { this[nameof(DecayRate)].SetValue<float>(value); } }
        public bool ShouldRegen { get { return this[nameof(ShouldRegen)].Flag; } set { this[nameof(ShouldRegen)].Flag = value; } }
        public StatValue ShieldRegenRate { get { return this[nameof(ShieldRegenRate)].As<StatValue>(); } set { this["ShieldRegenRate"] = value; } }
        public StatValue ShieldRegenDelay { get { return this[nameof(ShieldRegenDelay)].As<StatValue>(); } set { this["ShieldRegenDelay"] = value; } }
        public StatValue ShieldBrokenRegenDelay { get { return this[nameof(ShieldBrokenRegenDelay)].As<StatValue>(); } set { this["ShieldBrokenRegenDelay"] = value; } }
        public Object OnHit { get { return this[nameof(OnHit)]; } set { this[nameof(OnHit)] = value; } }
        public Object OnShieldValueChanged { get { return this[nameof(OnShieldValueChanged)]; } set { this[nameof(OnShieldValueChanged)] = value; } }
        public Object OnShieldMaxChanged { get { return this[nameof(OnShieldMaxChanged)]; } set { this[nameof(OnShieldMaxChanged)] = value; } }
        public Object OnShieldBroken { get { return this[nameof(OnShieldBroken)]; } set { this[nameof(OnShieldBroken)] = value; } }
        public void ShieldBreak() { Invoke(nameof(ShieldBreak)); }
        public void SetShieldValue(float Amount) { Invoke(nameof(SetShieldValue), Amount); }
        public void SetShieldMax(float Amount) { Invoke(nameof(SetShieldMax), Amount); }
        public void PlaySound(SoundGunfire SoundEvent, bool StoreSound) { Invoke(nameof(PlaySound), SoundEvent, StoreSound); }
        public void OnRep_ShieldValue() { Invoke(nameof(OnRep_ShieldValue)); }
        public void OnRep_ShieldMax() { Invoke(nameof(OnRep_ShieldMax)); }
        public float GetShieldPct() { return Invoke<float>(nameof(GetShieldPct)); }
        public float GetShieldMax() { return Invoke<float>(nameof(GetShieldMax)); }
        public void DamageShieldMatAmount(float Amount) { Invoke(nameof(DamageShieldMatAmount), Amount); }
        public void ClientShieldHit() { Invoke(nameof(ClientShieldHit)); }
        public void ApplyShieldDelta(float Delta) { Invoke(nameof(ApplyShieldDelta), Delta); }
        public void ApplyShieldDamage(DamageInfo ShieldDamageInfo) { Invoke(nameof(ApplyShieldDamage), ShieldDamageInfo); }
        public void AnimateShieldChange(float From, float To) { Invoke(nameof(AnimateShieldChange), From, To); }
    }
    public class ActionTeleport : ActionBase
    {
        public ActionTeleport(nint addr) : base(addr) { }
        public Vector TargetLocation { get { return this[nameof(TargetLocation)].As<Vector>(); } set { this["TargetLocation"] = value; } }
        public float TeleportDelay { get { return this[nameof(TeleportDelay)].GetValue<float>(); } set { this[nameof(TeleportDelay)].SetValue<float>(value); } }
        public float TeleportDuration { get { return this[nameof(TeleportDuration)].GetValue<float>(); } set { this[nameof(TeleportDuration)].SetValue<float>(value); } }
        public float ReappearDelay { get { return this[nameof(ReappearDelay)].GetValue<float>(); } set { this[nameof(ReappearDelay)].SetValue<float>(value); } }
        public bool bAutoHideActor { get { return this[nameof(bAutoHideActor)].Flag; } set { this[nameof(bAutoHideActor)].Flag = value; } }
        public Object TeleportCamera { get { return this[nameof(TeleportCamera)]; } set { this[nameof(TeleportCamera)] = value; } }
        public float CameraBlendIn { get { return this[nameof(CameraBlendIn)].GetValue<float>(); } set { this[nameof(CameraBlendIn)].SetValue<float>(value); } }
        public float CameraBlendOut { get { return this[nameof(CameraBlendOut)].GetValue<float>(); } set { this[nameof(CameraBlendOut)].SetValue<float>(value); } }
        public bool bFaceTarget { get { return this[nameof(bFaceTarget)].Flag; } set { this[nameof(bFaceTarget)].Flag = value; } }
        public bool bMoveCameraOverTime { get { return this[nameof(bMoveCameraOverTime)].Flag; } set { this[nameof(bMoveCameraOverTime)].Flag = value; } }
        public float CameraSnapMaxPitch { get { return this[nameof(CameraSnapMaxPitch)].GetValue<float>(); } set { this[nameof(CameraSnapMaxPitch)].SetValue<float>(value); } }
        public float ElapsedTime { get { return this[nameof(ElapsedTime)].GetValue<float>(); } set { this[nameof(ElapsedTime)].SetValue<float>(value); } }
        public Vector InitialLocation { get { return this[nameof(InitialLocation)].As<Vector>(); } set { this["InitialLocation"] = value; } }
        public bool bTeleportInitialized { get { return this[nameof(bTeleportInitialized)].Flag; } set { this[nameof(bTeleportInitialized)].Flag = value; } }
        public bool bTeleportFinalized { get { return this[nameof(bTeleportFinalized)].Flag; } set { this[nameof(bTeleportFinalized)].Flag = value; } }
        public Array<SceneComponent> HiddenComponents { get { return new Array<SceneComponent>(this[nameof(HiddenComponents)].Address); } }
        public void TryInitializeTeleport() { Invoke(nameof(TryInitializeTeleport)); }
        public void TryFinalizeTeleport() { Invoke(nameof(TryFinalizeTeleport)); }
        public void ServerFinishTeleport(Vector FinalLocation) { Invoke(nameof(ServerFinishTeleport), FinalLocation); }
        public void ServerBeginTeleport(Actor Target, Vector FinalLocation) { Invoke(nameof(ServerBeginTeleport), Target, FinalLocation); }
        public void OverrideTeleportLocation(Vector OutTargetLocation) { Invoke(nameof(OverrideTeleportLocation), OutTargetLocation); }
        public void OnTeleportEnd(Vector FinalLocation) { Invoke(nameof(OnTeleportEnd), FinalLocation); }
        public void OnTeleportBegin(Vector FinalLocation) { Invoke(nameof(OnTeleportBegin), FinalLocation); }
        public void MulticastFinishTeleport(Vector NewLocation) { Invoke(nameof(MulticastFinishTeleport), NewLocation); }
        public void MulticastBeginTeleport(Actor Target, Vector NewLocation) { Invoke(nameof(MulticastBeginTeleport), Target, NewLocation); }
        public void ClearTeleportCamera() { Invoke(nameof(ClearTeleportCamera)); }
        public bool CanTeleport() { return Invoke<bool>(nameof(CanTeleport)); }
    }
    public class AITacticalGraphNodeVisualizerComponent : ActorComponent
    {
        public AITacticalGraphNodeVisualizerComponent(nint addr) : base(addr) { }
    }
    public class AITacticalGraphNode : AICustomTacticalPoint
    {
        public AITacticalGraphNode(nint addr) : base(addr) { }
        public Object TacticalPointTag { get { return this[nameof(TacticalPointTag)]; } set { this[nameof(TacticalPointTag)] = value; } }
        public FloatRange RangeRestriction { get { return this[nameof(RangeRestriction)].As<FloatRange>(); } set { this["RangeRestriction"] = value; } }
        public bool bStitchNeighbors { get { return this[nameof(bStitchNeighbors)].Flag; } set { this[nameof(bStitchNeighbors)].Flag = value; } }
        public bool bDeferStitchUntilRequested { get { return this[nameof(bDeferStitchUntilRequested)].Flag; } set { this[nameof(bDeferStitchUntilRequested)].Flag = value; } }
        public bool bValidateJump { get { return this[nameof(bValidateJump)].Flag; } set { this[nameof(bValidateJump)].Flag = value; } }
        public float CapsuleRadius { get { return this[nameof(CapsuleRadius)].GetValue<float>(); } set { this[nameof(CapsuleRadius)].SetValue<float>(value); } }
        public float CapsuleHalfHeight { get { return this[nameof(CapsuleHalfHeight)].GetValue<float>(); } set { this[nameof(CapsuleHalfHeight)].SetValue<float>(value); } }
        public float JumpInitialOffset { get { return this[nameof(JumpInitialOffset)].GetValue<float>(); } set { this[nameof(JumpInitialOffset)].SetValue<float>(value); } }
        public float GravityScale { get { return this[nameof(GravityScale)].GetValue<float>(); } set { this[nameof(GravityScale)].SetValue<float>(value); } }
        public EAutoArcType ArcMethod { get { return (EAutoArcType)this[nameof(ArcMethod)].GetValue<int>(); } set { this[nameof(ArcMethod)].SetValue<int>((int)value); } }
        public float ArcHeight { get { return this[nameof(ArcHeight)].GetValue<float>(); } set { this[nameof(ArcHeight)].SetValue<float>(value); } }
        public float JumpSpeed { get { return this[nameof(JumpSpeed)].GetValue<float>(); } set { this[nameof(JumpSpeed)].SetValue<float>(value); } }
        public float RetractDistance { get { return this[nameof(RetractDistance)].GetValue<float>(); } set { this[nameof(RetractDistance)].SetValue<float>(value); } }
        public Array<AITacticalGraphNode> GeneratedNeighbors { get { return new Array<AITacticalGraphNode>(this[nameof(GeneratedNeighbors)].Address); } }
        public ETacticalGraphNodeStatus NodeStatus { get { return (ETacticalGraphNodeStatus)this[nameof(NodeStatus)].GetValue<int>(); } set { this[nameof(NodeStatus)].SetValue<int>((int)value); } }
    }
    public class AITacticalPathCondition : Condition
    {
        public AITacticalPathCondition(nint addr) : base(addr) { }
        public Object Params { get { return this[nameof(Params)]; } set { this[nameof(Params)] = value; } }
    }
    public class AITacticalPathStateDecorator : ActorStateDecorator
    {
        public AITacticalPathStateDecorator(nint addr) : base(addr) { }
        public Object Params { get { return this[nameof(Params)]; } set { this[nameof(Params)] = value; } }
        public float AcceptanceRadius { get { return this[nameof(AcceptanceRadius)].GetValue<float>(); } set { this[nameof(AcceptanceRadius)].SetValue<float>(value); } }
        public bool bUpdateTacticalPoint { get { return this[nameof(bUpdateTacticalPoint)].Flag; } set { this[nameof(bUpdateTacticalPoint)].Flag = value; } }
        public bool bNavigatePath { get { return this[nameof(bNavigatePath)].Flag; } set { this[nameof(bNavigatePath)].Flag = value; } }
        public Object BlackboardKey { get { return this[nameof(BlackboardKey)]; } set { this[nameof(BlackboardKey)] = value; } }
        public Object StatusKey { get { return this[nameof(StatusKey)]; } set { this[nameof(StatusKey)] = value; } }
    }
    public class TacticalGraphQueryParams : Object
    {
        public TacticalGraphQueryParams(nint addr) : base(addr) { }
        public PositionValue Destination { get { return this[nameof(Destination)].As<PositionValue>(); } set { this["Destination"] = value; } }
        public Object TacticalPointTag { get { return this[nameof(TacticalPointTag)]; } set { this[nameof(TacticalPointTag)] = value; } }
        public float IdealDistance { get { return this[nameof(IdealDistance)].GetValue<float>(); } set { this[nameof(IdealDistance)].SetValue<float>(value); } }
        public float IdealDistancePreferenceScalar { get { return this[nameof(IdealDistancePreferenceScalar)].GetValue<float>(); } set { this[nameof(IdealDistancePreferenceScalar)].SetValue<float>(value); } }
        public bool bApplyRangeRestriction { get { return this[nameof(bApplyRangeRestriction)].Flag; } set { this[nameof(bApplyRangeRestriction)].Flag = value; } }
        public FloatRange RangeRestriction { get { return this[nameof(RangeRestriction)].As<FloatRange>(); } set { this["RangeRestriction"] = value; } }
    }
    public class TacticalGraphComponent : ActorComponent
    {
        public TacticalGraphComponent(nint addr) : base(addr) { }
        public void Stop() { Invoke(nameof(Stop)); }
        public bool MoveTo(Object Params, float InAcceptanceRadius, bool InUpdateTacticalPoint, bool InNavigatePath, Object InBlackboardKey, Object InStatusKey) { return Invoke<bool>(nameof(MoveTo), Params, InAcceptanceRadius, InUpdateTacticalPoint, InNavigatePath, InBlackboardKey, InStatusKey); }
        public bool IsFollowingPath() { return Invoke<bool>(nameof(IsFollowingPath)); }
        public int GetCurrentPathIndex() { return Invoke<int>(nameof(GetCurrentPathIndex)); }
        public TacticalGraphPath GetCurrentPath() { return Invoke<TacticalGraphPath>(nameof(GetCurrentPath)); }
        public bool FindPath(Object Params, TacticalGraphPath OutPath) { return Invoke<bool>(nameof(FindPath), Params, OutPath); }
    }
    public class TurretTargetSelector : AIDefaultTargetSelector
    {
        public TurretTargetSelector(nint addr) : base(addr) { }
        public Object WeaponType { get { return this[nameof(WeaponType)]; } set { this[nameof(WeaponType)] = value; } }
        public float OptimalTargetRange { get { return this[nameof(OptimalTargetRange)].GetValue<float>(); } set { this[nameof(OptimalTargetRange)].SetValue<float>(value); } }
        public float MaximumTargetRange { get { return this[nameof(MaximumTargetRange)].GetValue<float>(); } set { this[nameof(MaximumTargetRange)].SetValue<float>(value); } }
        public float PriorityOptimalTargetRange { get { return this[nameof(PriorityOptimalTargetRange)].GetValue<float>(); } set { this[nameof(PriorityOptimalTargetRange)].SetValue<float>(value); } }
        public float PriorityMaximumTargetRange { get { return this[nameof(PriorityMaximumTargetRange)].GetValue<float>(); } set { this[nameof(PriorityMaximumTargetRange)].SetValue<float>(value); } }
        public float MaximumRangePenalty { get { return this[nameof(MaximumRangePenalty)].GetValue<float>(); } set { this[nameof(MaximumRangePenalty)].SetValue<float>(value); } }
        public float AimArcMin { get { return this[nameof(AimArcMin)].GetValue<float>(); } set { this[nameof(AimArcMin)].SetValue<float>(value); } }
        public float AimArcMax { get { return this[nameof(AimArcMax)].GetValue<float>(); } set { this[nameof(AimArcMax)].SetValue<float>(value); } }
        public float OutOfArcPenalty { get { return this[nameof(OutOfArcPenalty)].GetValue<float>(); } set { this[nameof(OutOfArcPenalty)].SetValue<float>(value); } }
        public Object PriorityTargetName { get { return this[nameof(PriorityTargetName)]; } set { this[nameof(PriorityTargetName)] = value; } }
        public float CurrentPriorityTargetBonus { get { return this[nameof(CurrentPriorityTargetBonus)].GetValue<float>(); } set { this[nameof(CurrentPriorityTargetBonus)].SetValue<float>(value); } }
        public float PriorityTargetMaxBonusRange { get { return this[nameof(PriorityTargetMaxBonusRange)].GetValue<float>(); } set { this[nameof(PriorityTargetMaxBonusRange)].SetValue<float>(value); } }
        public float PriorityTargetNoBonusRange { get { return this[nameof(PriorityTargetNoBonusRange)].GetValue<float>(); } set { this[nameof(PriorityTargetNoBonusRange)].SetValue<float>(value); } }
        public float PriorityTargetMaxProximityScalar { get { return this[nameof(PriorityTargetMaxProximityScalar)].GetValue<float>(); } set { this[nameof(PriorityTargetMaxProximityScalar)].SetValue<float>(value); } }
    }
    public class AnimNotify_ShowLastUsedItem : AnimNotify
    {
        public AnimNotify_ShowLastUsedItem(nint addr) : base(addr) { }
        public bool bShowItem { get { return this[nameof(bShowItem)].Flag; } set { this[nameof(bShowItem)].Flag = value; } }
    }
    public class RemnantAnimInstance : AnimInstanceGunfire
    {
        public RemnantAnimInstance(nint addr) : base(addr) { }
        public bool bIsStopped { get { return this[nameof(bIsStopped)].Flag; } set { this[nameof(bIsStopped)].Flag = value; } }
        public bool bIsJogging { get { return this[nameof(bIsJogging)].Flag; } set { this[nameof(bIsJogging)].Flag = value; } }
        public bool bIsSprinting { get { return this[nameof(bIsSprinting)].Flag; } set { this[nameof(bIsSprinting)].Flag = value; } }
        public bool bIsMovingForward { get { return this[nameof(bIsMovingForward)].Flag; } set { this[nameof(bIsMovingForward)].Flag = value; } }
        public bool bNoLookPose { get { return this[nameof(bNoLookPose)].Flag; } set { this[nameof(bNoLookPose)].Flag = value; } }
        public float JogRef { get { return this[nameof(JogRef)].GetValue<float>(); } set { this[nameof(JogRef)].SetValue<float>(value); } }
        public float SprintRef { get { return this[nameof(SprintRef)].GetValue<float>(); } set { this[nameof(SprintRef)].SetValue<float>(value); } }
        public bool bComputeMoveDirection { get { return this[nameof(bComputeMoveDirection)].Flag; } set { this[nameof(bComputeMoveDirection)].Flag = value; } }
        public float MoveForwardRef { get { return this[nameof(MoveForwardRef)].GetValue<float>(); } set { this[nameof(MoveForwardRef)].SetValue<float>(value); } }
        public bool bNeedsLookPose { get { return this[nameof(bNeedsLookPose)].Flag; } set { this[nameof(bNeedsLookPose)].Flag = value; } }
        public Object NoLookPoseTag { get { return this[nameof(NoLookPoseTag)]; } set { this[nameof(NoLookPoseTag)] = value; } }
    }
    public class GunnerAnimInstance : RemnantAnimInstance
    {
        public GunnerAnimInstance(nint addr) : base(addr) { }
        public bool bIsTurning { get { return this[nameof(bIsTurning)].Flag; } set { this[nameof(bIsTurning)].Flag = value; } }
        public bool bIsTurningRight { get { return this[nameof(bIsTurningRight)].Flag; } set { this[nameof(bIsTurningRight)].Flag = value; } }
        public float TurnSpeedAlpha { get { return this[nameof(TurnSpeedAlpha)].GetValue<float>(); } set { this[nameof(TurnSpeedAlpha)].SetValue<float>(value); } }
        public bool bIsAimingForward { get { return this[nameof(bIsAimingForward)].Flag; } set { this[nameof(bIsAimingForward)].Flag = value; } }
        public bool bNeedsTargetAlign { get { return this[nameof(bNeedsTargetAlign)].Flag; } set { this[nameof(bNeedsTargetAlign)].Flag = value; } }
        public float TurnSpeedRef { get { return this[nameof(TurnSpeedRef)].GetValue<float>(); } set { this[nameof(TurnSpeedRef)].SetValue<float>(value); } }
        public float AimForwardRef { get { return this[nameof(AimForwardRef)].GetValue<float>(); } set { this[nameof(AimForwardRef)].SetValue<float>(value); } }
        public bool bCheckTargetAlign { get { return this[nameof(bCheckTargetAlign)].Flag; } set { this[nameof(bCheckTargetAlign)].Flag = value; } }
        public Object TargetAlignTag { get { return this[nameof(TargetAlignTag)]; } set { this[nameof(TargetAlignTag)] = value; } }
        public EWindupState WindupState { get { return (EWindupState)this[nameof(WindupState)].GetValue<int>(); } set { this[nameof(WindupState)].SetValue<int>((int)value); } }
        public float OverdrawnAlpha { get { return this[nameof(OverdrawnAlpha)].GetValue<float>(); } set { this[nameof(OverdrawnAlpha)].SetValue<float>(value); } }
    }
    public class RemnantFlyCameraState : FlyCameraState
    {
        public RemnantFlyCameraState(nint addr) : base(addr) { }
        public Actor PreviousLockActor { get { return this[nameof(PreviousLockActor)].As<Actor>(); } set { this["PreviousLockActor"] = value; } }
    }
    public class RemnantStateCameraComponent : StateCameraComponent
    {
        public RemnantStateCameraComponent(nint addr) : base(addr) { }
    }
    public class Emote : Object
    {
        public Emote(nint addr) : base(addr) { }
        public Object StateName { get { return this[nameof(StateName)]; } set { this[nameof(StateName)] = value; } }
        public Object Label { get { return this[nameof(Label)]; } set { this[nameof(Label)] = value; } }
        public Object Icon { get { return this[nameof(Icon)]; } set { this[nameof(Icon)] = value; } }
        public bool bOverrideAudio { get { return this[nameof(bOverrideAudio)].Flag; } set { this[nameof(bOverrideAudio)].Flag = value; } }
        public Object SoundSetID { get { return this[nameof(SoundSetID)]; } set { this[nameof(SoundSetID)] = value; } }
        public Object SubtitleText { get { return this[nameof(SubtitleText)]; } set { this[nameof(SubtitleText)] = value; } }
        public Texture2D GetIcon(EmotesComponent Emotes, Object Reason) { return Invoke<Texture2D>(nameof(GetIcon), Emotes, Reason); }
    }
    public class EmotesComponent : ActorComponent
    {
        public EmotesComponent(nint addr) : base(addr) { }
        public Object OnIconLoaded { get { return this[nameof(OnIconLoaded)]; } set { this[nameof(OnIconLoaded)] = value; } }
        public Array<Object> Slots { get { return new Array<Object>(this[nameof(Slots)].Address); } }
        public Array<Object> UnlockedEmotes { get { return new Array<Object>(this[nameof(UnlockedEmotes)].Address); } }
        public Array<EmoteIconState> IconStates { get { return new Array<EmoteIconState>(this[nameof(IconStates)].Address); } }
        public void UnlockEmote(Object NewEmote) { Invoke(nameof(UnlockEmote), NewEmote); }
        public void SlotEmote(int Slot, Object Emote) { Invoke(nameof(SlotEmote), Slot, Emote); }
        public void ServerUpdateSlots(Array<Object> NewSlots) { Invoke(nameof(ServerUpdateSlots), NewSlots); }
        public void ServerUnlockEmote(Object Emote) { Invoke(nameof(ServerUnlockEmote), Emote); }
        public Texture2D RequestEmoteIcon(Object Emote, Object Reason) { return Invoke<Texture2D>(nameof(RequestEmoteIcon), Emote, Reason); }
        public void OnLoadIcon(Object Emote) { Invoke(nameof(OnLoadIcon), Emote); }
        public bool HasEmote(Object Emote) { return Invoke<bool>(nameof(HasEmote), Emote); }
        public Array<Emote> GetUnlockedEmotes(Array<Object> IgnoreList) { return Invoke<Array<Emote>>(nameof(GetUnlockedEmotes), IgnoreList); }
        public Emote GetEmoteForSlot(int Index) { return Invoke<Emote>(nameof(GetEmoteForSlot), Index); }
        public void ClearEmoteIcon(Object Emote, Object Reason) { Invoke(nameof(ClearEmoteIcon), Emote, Reason); }
        public void ClearAllEmoteIcons(Object Reason) { Invoke(nameof(ClearAllEmoteIcons), Reason); }
    }
    public class SavedCharacter : Object
    {
        public SavedCharacter(nint addr) : base(addr) { }
        public int Level { get { return this[nameof(Level)].GetValue<int>(); } set { this[nameof(Level)].SetValue<int>(value); } }
        public int Age { get { return this[nameof(Age)].GetValue<int>(); } set { this[nameof(Age)].SetValue<int>(value); } }
        public int TraitRank { get { return this[nameof(TraitRank)].GetValue<int>(); } set { this[nameof(TraitRank)].SetValue<int>(value); } }
        public Object Archetype { get { return this[nameof(Archetype)]; } set { this[nameof(Archetype)] = value; } }
        public Object SecondaryArchetype { get { return this[nameof(SecondaryArchetype)]; } set { this[nameof(SecondaryArchetype)] = value; } }
        public bool HasInitializedArchetype { get { return this[nameof(HasInitializedArchetype)].Flag; } set { this[nameof(HasInitializedArchetype)].Flag = value; } }
        public bool bFinishedIntro { get { return this[nameof(bFinishedIntro)].Flag; } set { this[nameof(bFinishedIntro)].Flag = value; } }
        public bool bSkipIntro { get { return this[nameof(bSkipIntro)].Flag; } set { this[nameof(bSkipIntro)].Flag = value; } }
        public Array<ActorCustomizationSlot> Customizations { get { return new Array<ActorCustomizationSlot>(this[nameof(Customizations)].Address); } }
        public Array<SavedEquipmentVisual> EquipmentCustomizations { get { return new Array<SavedEquipmentVisual>(this[nameof(EquipmentCustomizations)].Address); } }
        public Array<ActorCustomizationSlot> CachedLastValidCustomizations { get { return new Array<ActorCustomizationSlot>(this[nameof(CachedLastValidCustomizations)].Address); } }
        public Array<SavedEquipmentVisual> CachedLastValidEquipmentCustomizations { get { return new Array<SavedEquipmentVisual>(this[nameof(CachedLastValidEquipmentCustomizations)].Address); } }
        public EGender Gender { get { return (EGender)this[nameof(Gender)].GetValue<int>(); } set { this[nameof(Gender)].SetValue<int>((int)value); } }
        public ELastHostType HostType { get { return (ELastHostType)this[nameof(HostType)].GetValue<int>(); } set { this[nameof(HostType)].SetValue<int>((int)value); } }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Array<byte> CharacterBlob { get { return new Array<byte>(this[nameof(CharacterBlob)].Address); } }
        public PersistenceBlob CharacterData { get { return this[nameof(CharacterData)].As<PersistenceBlob>(); } set { this["CharacterData"] = value; } }
        public int QuestDifficulty { get { return this[nameof(QuestDifficulty)].GetValue<int>(); } set { this[nameof(QuestDifficulty)].SetValue<int>(value); } }
        public int InitialDifficulty { get { return this[nameof(InitialDifficulty)].GetValue<int>(); } set { this[nameof(InitialDifficulty)].SetValue<int>(value); } }
        public int PowerLevel { get { return this[nameof(PowerLevel)].GetValue<int>(); } set { this[nameof(PowerLevel)].SetValue<int>(value); } }
        public Array<Object> Keys { get { return new Array<Object>(this[nameof(Keys)].Address); } }
        public Object Counters { get { return this[nameof(Counters)]; } set { this[nameof(Counters)] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public ERemnantCharacterType CharacterType { get { return (ERemnantCharacterType)this[nameof(CharacterType)].GetValue<int>(); } set { this[nameof(CharacterType)].SetValue<int>((int)value); } }
        public bool bDeceased { get { return this[nameof(bDeceased)].Flag; } set { this[nameof(bDeceased)].Flag = value; } }
        public int BossCount { get { return this[nameof(BossCount)].GetValue<int>(); } set { this[nameof(BossCount)].SetValue<int>(value); } }
        public bool bValidExit { get { return this[nameof(bValidExit)].Flag; } set { this[nameof(bValidExit)].Flag = value; } }
        public int InvalidExitCount { get { return this[nameof(InvalidExitCount)].GetValue<int>(); } set { this[nameof(InvalidExitCount)].SetValue<int>(value); } }
        public Array<AccountAwardInstance> ReceivedAwards { get { return new Array<AccountAwardInstance>(this[nameof(ReceivedAwards)].Address); } }
        public bool bHasHandledCurrencyAward { get { return this[nameof(bHasHandledCurrencyAward)].Flag; } set { this[nameof(bHasHandledCurrencyAward)].Flag = value; } }
        public Array<EntitlementInstance> EntitledAwards { get { return new Array<EntitlementInstance>(this[nameof(EntitledAwards)].Address); } }
        public bool bHasEntitledArchetype { get { return this[nameof(bHasEntitledArchetype)].Flag; } set { this[nameof(bHasEntitledArchetype)].Flag = value; } }
        public void SetSkipIntro(bool ShouldSkipIntro) { Invoke(nameof(SetSkipIntro), ShouldSkipIntro); }
        public void SetKey(Object Key) { Invoke(nameof(SetKey), Key); }
        public void SetCharacterType(ERemnantCharacterType NewCharacterType) { Invoke(nameof(SetCharacterType), NewCharacterType); }
        public void MarkValidExit() { Invoke(nameof(MarkValidExit)); }
        public void IncrementCounter(Object Counter) { Invoke(nameof(IncrementCounter), Counter); }
        public bool HasRevokedEntitledArchetype(RemnantSaveGameProfile Profile) { return Invoke<bool>(nameof(HasRevokedEntitledArchetype), Profile); }
        public bool HasKey(Object Key) { return Invoke<bool>(nameof(HasKey), Key); }
        public int GetCounter(Object Counter) { return Invoke<int>(nameof(GetCounter), Counter); }
        public void ConditionallyMarkEntitledArchetype(RemnantSaveGameProfile Profile, Object NewArchetype) { Invoke(nameof(ConditionallyMarkEntitledArchetype), Profile, NewArchetype); }
        public bool CheckForInvalidExit() { return Invoke<bool>(nameof(CheckForInvalidExit)); }
    }
    public class RemnantSaveGameProfile : SaveGameProfile
    {
        public RemnantSaveGameProfile(nint addr) : base(addr) { }
        public Array<SavedCharacter> Characters { get { return new Array<SavedCharacter>(this[nameof(Characters)].Address); } }
        public int ActiveCharacterIndex { get { return this[nameof(ActiveCharacterIndex)].GetValue<int>(); } set { this[nameof(ActiveCharacterIndex)].SetValue<int>(value); } }
        public bool bHasEverCompletedIntro { get { return this[nameof(bHasEverCompletedIntro)].Flag; } set { this[nameof(bHasEverCompletedIntro)].Flag = value; } }
        public bool bNeedsCheatedSaveConfirmation { get { return this[nameof(bNeedsCheatedSaveConfirmation)].Flag; } set { this[nameof(bNeedsCheatedSaveConfirmation)].Flag = value; } }
        public Array<Object> AccountAwards { get { return new Array<Object>(this[nameof(AccountAwards)].Address); } }
        public Array<ArchetypeEntitlement> ArchetypeEntitlements { get { return new Array<ArchetypeEntitlement>(this[nameof(ArchetypeEntitlements)].Address); } }
        public Array<ItemEntitlement> ItemEntitlements { get { return new Array<ItemEntitlement>(this[nameof(ItemEntitlements)].Address); } }
        public Array<AccountCurrencyInstance> AccountCurrencies { get { return new Array<AccountCurrencyInstance>(this[nameof(AccountCurrencies)].Address); } }
        public int SurvivalBossesKilled { get { return this[nameof(SurvivalBossesKilled)].GetValue<int>(); } set { this[nameof(SurvivalBossesKilled)].SetValue<int>(value); } }
        public int SurvivalCoopBossesKilled { get { return this[nameof(SurvivalCoopBossesKilled)].GetValue<int>(); } set { this[nameof(SurvivalCoopBossesKilled)].SetValue<int>(value); } }
        public int SurvivalItemsAcquired { get { return this[nameof(SurvivalItemsAcquired)].GetValue<int>(); } set { this[nameof(SurvivalItemsAcquired)].SetValue<int>(value); } }
        public Object SurvivalMiniBossQuestsCompleteMap { get { return this[nameof(SurvivalMiniBossQuestsCompleteMap)]; } set { this[nameof(SurvivalMiniBossQuestsCompleteMap)] = value; } }
        public Object SurvivalWorldBossQuestsCompleteMap { get { return this[nameof(SurvivalWorldBossQuestsCompleteMap)]; } set { this[nameof(SurvivalWorldBossQuestsCompleteMap)] = value; } }
        public bool UpdateAccountCurrency(Object CurrencyType, int Quantity) { return Invoke<bool>(nameof(UpdateAccountCurrency), CurrencyType, Quantity); }
        public bool HasAccountAward(Object Award) { return Invoke<bool>(nameof(HasAccountAward), Award); }
        public Array<Object> GetUnlockedArchetypes(bool bIncludedEntitledArchetypes) { return Invoke<Array<Object>>(nameof(GetUnlockedArchetypes), bIncludedEntitledArchetypes); }
        public int GetAccountCurrencyForItemType(Object CurrencyType) { return Invoke<int>(nameof(GetAccountCurrencyForItemType), CurrencyType); }
        public bool CheckHasEverCompletedIntro() { return Invoke<bool>(nameof(CheckHasEverCompletedIntro)); }
    }
    public class RemnantCharacterManager : Object
    {
        public RemnantCharacterManager(nint addr) : base(addr) { }
        public Object CharacterCreated { get { return this[nameof(CharacterCreated)]; } set { this[nameof(CharacterCreated)] = value; } }
        public Object CharacterDeleted { get { return this[nameof(CharacterDeleted)]; } set { this[nameof(CharacterDeleted)] = value; } }
        public Object CharaterCreationFailed { get { return this[nameof(CharaterCreationFailed)]; } set { this[nameof(CharaterCreationFailed)] = value; } }
        public Object CharacterLoadingFailed { get { return this[nameof(CharacterLoadingFailed)]; } set { this[nameof(CharacterLoadingFailed)] = value; } }
        public Object OnActiveCharacterChanged { get { return this[nameof(OnActiveCharacterChanged)]; } set { this[nameof(OnActiveCharacterChanged)] = value; } }
        public Array<SavedCharacter> TransientCharacters { get { return new Array<SavedCharacter>(this[nameof(TransientCharacters)].Address); } }
        public Object ClientCharacters { get { return this[nameof(ClientCharacters)]; } set { this[nameof(ClientCharacters)] = value; } }
        public Array<Object> NewCharacterEquipmentVisuals { get { return new Array<Object>(this[nameof(NewCharacterEquipmentVisuals)].Address); } }
        public bool ShouldAwardHardcoreRewards(Object WorldContextObject) { return Invoke<bool>(nameof(ShouldAwardHardcoreRewards), WorldContextObject); }
        public bool SetActiveCharacter(int ID) { return Invoke<bool>(nameof(SetActiveCharacter), ID); }
        public bool RestoreCharacters() { return Invoke<bool>(nameof(RestoreCharacters)); }
        public bool ResolvePendingExit() { return Invoke<bool>(nameof(ResolvePendingExit)); }
        public bool IsHardcore(Object WorldContextObject) { return Invoke<bool>(nameof(IsHardcore), WorldContextObject); }
        public bool IsDeceasedCharacter(Object WorldContextObject) { return Invoke<bool>(nameof(IsDeceasedCharacter), WorldContextObject); }
        public bool HasBackupCharacters() { return Invoke<bool>(nameof(HasBackupCharacters)); }
        public bool HasActiveCharacter() { return Invoke<bool>(nameof(HasActiveCharacter)); }
        public Array<SavedCharacter> GetTransientCharacters() { return Invoke<Array<SavedCharacter>>(nameof(GetTransientCharacters)); }
        public int GetMaxCharacterCount() { return Invoke<int>(nameof(GetMaxCharacterCount)); }
        public Array<SavedCharacter> GetCharacters() { return Invoke<Array<SavedCharacter>>(nameof(GetCharacters)); }
        public RemnantCharacterManager GetCharacterManager(Object WorldContextObject) { return Invoke<RemnantCharacterManager>(nameof(GetCharacterManager), WorldContextObject); }
        public SavedCharacter GetCharacterInfo(PlayerController Controller) { return Invoke<SavedCharacter>(nameof(GetCharacterInfo), Controller); }
        public int GetCharacterCount() { return Invoke<int>(nameof(GetCharacterCount)); }
        public SavedCharacter GetCharacterAt(int Index) { return Invoke<SavedCharacter>(nameof(GetCharacterAt), Index); }
        public SavedCharacter GetCharacter(int ID) { return Invoke<SavedCharacter>(nameof(GetCharacter), ID); }
        public void GetActiveEquipmentVisuals(SavedCharacter CharacterInfo, Array<Object> OutVisuals, Array<byte> OutLevels, Array<Object> OutSkins) { Invoke(nameof(GetActiveEquipmentVisuals), CharacterInfo, OutVisuals, OutLevels, OutSkins); }
        public SavedCharacter GetActiveCharacter() { return Invoke<SavedCharacter>(nameof(GetActiveCharacter)); }
        public bool DeleteTransientCharacters() { return Invoke<bool>(nameof(DeleteTransientCharacters)); }
        public bool DeleteTransientCharacter(int ID) { return Invoke<bool>(nameof(DeleteTransientCharacter), ID); }
        public bool DeleteCharacter(int ID) { return Invoke<bool>(nameof(DeleteCharacter), ID); }
        public SavedCharacter CreateTransientCharacter(Object Name, Object SaveGameClass, int ErrorCode, bool SetActive, ERemnantCharacterType CharacterType, bool ShouldSkipIntro, Object Archetype, Object SecondaryArchetype, int StartingDifficulty, SavedCharacter ReferenceCharacter, Array<Object> AllowedAccountAwards) { return Invoke<SavedCharacter>(nameof(CreateTransientCharacter), Name, SaveGameClass, ErrorCode, SetActive, CharacterType, ShouldSkipIntro, Archetype, SecondaryArchetype, StartingDifficulty, ReferenceCharacter, AllowedAccountAwards); }
        public SavedCharacter CreateCharacter(Object Name, Object SaveGameClass, int ErrorCode, bool SetActive, ERemnantCharacterType CharacterType, bool ShouldSkipIntro, Object Archetype, Object SecondaryArchetype, int StartingDifficulty) { return Invoke<SavedCharacter>(nameof(CreateCharacter), Name, SaveGameClass, ErrorCode, SetActive, CharacterType, ShouldSkipIntro, Archetype, SecondaryArchetype, StartingDifficulty); }
    }
    public class RemnantCharacterSettings : Object
    {
        public RemnantCharacterSettings(nint addr) : base(addr) { }
        public EPIESelectionGender GenderSelection { get { return (EPIESelectionGender)this[nameof(GenderSelection)].GetValue<int>(); } set { this[nameof(GenderSelection)].SetValue<int>((int)value); } }
    }
    public class RemnantPlayerInventoryComponent : PlayerInventoryComponent
    {
        public RemnantPlayerInventoryComponent(nint addr) : base(addr) { }
        public bool AutoTransferWeaponMods { get { return this[nameof(AutoTransferWeaponMods)].Flag; } set { this[nameof(AutoTransferWeaponMods)].Flag = value; } }
        public Array<Object> LimitInitialLevelClasses { get { return new Array<Object>(this[nameof(LimitInitialLevelClasses)].Address); } }
        public Array<Object> EquipmentVisualsSlotTypes { get { return new Array<Object>(this[nameof(EquipmentVisualsSlotTypes)].Address); } }
        public Object NullReferenceReplacementClass { get { return this[nameof(NullReferenceReplacementClass)]; } set { this[nameof(NullReferenceReplacementClass)] = value; } }
        public Object OnUseMod { get { return this[nameof(OnUseMod)]; } set { this[nameof(OnUseMod)] = value; } }
        public Object ItemTypeOverrideMap { get { return this[nameof(ItemTypeOverrideMap)]; } set { this[nameof(ItemTypeOverrideMap)] = value; } }
        public void RemoveItemTypeOverride(Object ItemBP) { Invoke(nameof(RemoveItemTypeOverride), ItemBP); }
        public int ModifyLevelForNewItem(Object ItemBP, int ItemLevel) { return Invoke<int>(nameof(ModifyLevelForNewItem), ItemBP, ItemLevel); }
        public int GetLevelForNewItem(Actor Actor, Object ItemBP, int ItemLevel) { return Invoke<int>(nameof(GetLevelForNewItem), Actor, ItemBP, ItemLevel); }
        public Equipment GetEquippedItemByType(Object Type) { return Invoke<Equipment>(nameof(GetEquippedItemByType), Type); }
        public void AddItemTypeOverride(Object ItemBP, Object Type) { Invoke(nameof(AddItemTypeOverride), ItemBP, Type); }
    }
    public class RemnantSkyboxManager : ActorComponent
    {
        public RemnantSkyboxManager(nint addr) : base(addr) { }
        public Array<SkyboxModifierVolumeInfo> ModifierVolumes { get { return new Array<SkyboxModifierVolumeInfo>(this[nameof(ModifierVolumes)].Address); } }
        public Object OnSkyboxManagerInit { get { return this[nameof(OnSkyboxManagerInit)]; } set { this[nameof(OnSkyboxManagerInit)] = value; } }
        public Actor SkyboxRefActor { get { return this[nameof(SkyboxRefActor)].As<Actor>(); } set { this["SkyboxRefActor"] = value; } }
        public void RegisterSkyboxModifierVolume(Actor SkyboxModVolume) { Invoke(nameof(RegisterSkyboxModifierVolume), SkyboxModVolume); }
        public void RefreshModifierVolumes() { Invoke(nameof(RefreshModifierVolumes)); }
        public void OnPlayerExitVolume(PrimitiveComponent OverlappedComponent, Actor OtherActor, PrimitiveComponent OtherComp, int OtherBodyIndex) { Invoke(nameof(OnPlayerExitVolume), OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex); }
        public void OnPlayerEnterVolume(PrimitiveComponent OverlappedComponent, Actor OtherActor, PrimitiveComponent OtherComp, int OtherBodyIndex, bool FromSweep, HitResult SweepResult) { Invoke(nameof(OnPlayerEnterVolume), OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, FromSweep, SweepResult); }
        public bool IsPlayerInAnyModifierVolumes(Actor Player, Actor ExcludedVolume) { return Invoke<bool>(nameof(IsPlayerInAnyModifierVolumes), Player, ExcludedVolume); }
        public void InitSkyboxManager(Actor SkyboxActor) { Invoke(nameof(InitSkyboxManager), SkyboxActor); }
        public RemnantSkyboxManager GetInstance(Object WorldContextObject) { return Invoke<RemnantSkyboxManager>(nameof(GetInstance), WorldContextObject); }
    }
    public class RemnantSpectatorPawn : SpectatorPawn
    {
        public RemnantSpectatorPawn(nint addr) : base(addr) { }
        public SpectatorTargetComponent CurrentSpectatorTarget { get { return this[nameof(CurrentSpectatorTarget)].As<SpectatorTargetComponent>(); } set { this["CurrentSpectatorTarget"] = value; } }
        public Actor PrevViewTarget { get { return this[nameof(PrevViewTarget)].As<Actor>(); } set { this["PrevViewTarget"] = value; } }
        public void OnValidTarget() { Invoke(nameof(OnValidTarget)); }
        public void OnTargetUnavailable(SpectatorTargetComponent SpectatorTarget) { Invoke(nameof(OnTargetUnavailable), SpectatorTarget); }
        public void OnSpectateTarget(Actor Target) { Invoke(nameof(OnSpectateTarget), Target); }
        public void OnLeaveTarget() { Invoke(nameof(OnLeaveTarget)); }
        public void OnInvalidTarget() { Invoke(nameof(OnInvalidTarget)); }
        public void OnFinishTravel() { Invoke(nameof(OnFinishTravel)); }
        public bool IsValidTarget(Actor Target) { return Invoke<bool>(nameof(IsValidTarget), Target); }
        public int GetNumAvailableTargets() { return Invoke<int>(nameof(GetNumAvailableTargets)); }
        public Actor GetCurrentTarget(bool bOnlyIfValid) { return Invoke<Actor>(nameof(GetCurrentTarget), bOnlyIfValid); }
    }
    public class RemnantWeaponMaterialCustomization : ActorCustomization
    {
        public RemnantWeaponMaterialCustomization(nint addr) : base(addr) { }
        public Array<RemnantMaterialParam> MaterialChanges { get { return new Array<RemnantMaterialParam>(this[nameof(MaterialChanges)].Address); } }
    }
    public class RemnantWeaponParticleCustomization : ParticleCustomization
    {
        public RemnantWeaponParticleCustomization(nint addr) : base(addr) { }
        public bool bUpdatePowerChanged { get { return this[nameof(bUpdatePowerChanged)].Flag; } set { this[nameof(bUpdatePowerChanged)].Flag = value; } }
        public bool bUpdateChargesChaged { get { return this[nameof(bUpdateChargesChaged)].Flag; } set { this[nameof(bUpdateChargesChaged)].Flag = value; } }
    }
    public class SpawnTableCharacterMod : SpawnTableEntry
    {
        public SpawnTableCharacterMod(nint addr) : base(addr) { }
        public Object Modifier { get { return this[nameof(Modifier)]; } set { this[nameof(Modifier)] = value; } }
    }
    public class SpectatorTargetComponent : ActorComponent
    {
        public SpectatorTargetComponent(nint addr) : base(addr) { }
        public Object OnNotifySpectatorTargetUnavail { get { return this[nameof(OnNotifySpectatorTargetUnavail)]; } set { this[nameof(OnNotifySpectatorTargetUnavail)] = value; } }
        public void OnSpectatorTargetUnavailable() { Invoke(nameof(OnSpectatorTargetUnavailable)); }
    }
    public class GreyHealthComponent : ActorComponent
    {
        public GreyHealthComponent(nint addr) : base(addr) { }
        public Object GreyHealthRate { get { return this[nameof(GreyHealthRate)]; } set { this[nameof(GreyHealthRate)] = value; } }
        public Object GreyHealthRegen { get { return this[nameof(GreyHealthRegen)]; } set { this[nameof(GreyHealthRegen)] = value; } }
        public Object GreyHealthBonusSegments { get { return this[nameof(GreyHealthBonusSegments)]; } set { this[nameof(GreyHealthBonusSegments)] = value; } }
        public int InitialGreyhealthSegments { get { return this[nameof(InitialGreyhealthSegments)].GetValue<int>(); } set { this[nameof(InitialGreyhealthSegments)].SetValue<int>(value); } }
        public float TimeThresholdForMultiHitGrouping { get { return this[nameof(TimeThresholdForMultiHitGrouping)].GetValue<float>(); } set { this[nameof(TimeThresholdForMultiHitGrouping)].SetValue<float>(value); } }
        public float TimeAfterHitForRegenStart { get { return this[nameof(TimeAfterHitForRegenStart)].GetValue<float>(); } set { this[nameof(TimeAfterHitForRegenStart)].SetValue<float>(value); } }
        public Object OnGreyHealthChanged { get { return this[nameof(OnGreyHealthChanged)]; } set { this[nameof(OnGreyHealthChanged)] = value; } }
        public Object OnComponentActiveStateChanged { get { return this[nameof(OnComponentActiveStateChanged)]; } set { this[nameof(OnComponentActiveStateChanged)] = value; } }
        public Object OnServerGreyHealthHealedOwnerHealth { get { return this[nameof(OnServerGreyHealthHealedOwnerHealth)]; } set { this[nameof(OnServerGreyHealthHealedOwnerHealth)] = value; } }
        public bool GreyHealthDisabled { get { return this[nameof(GreyHealthDisabled)].Flag; } set { this[nameof(GreyHealthDisabled)].Flag = value; } }
        public Array<float> GreyHealthSegments { get { return new Array<float>(this[nameof(GreyHealthSegments)].Address); } }
        public void Reset(float InitialValue, bool Notify) { Invoke(nameof(Reset), InitialValue, Notify); }
        public void OnRep_GreyHealth(Array<float> PreviousSegments) { Invoke(nameof(OnRep_GreyHealth), PreviousSegments); }
        public void OnOwnerHealthRegen(CharacterGunfire Character, float RegenAmount) { Invoke(nameof(OnOwnerHealthRegen), Character, RegenAmount); }
        public void OnOwnerHealed(HealingInfo HealingInfo) { Invoke(nameof(OnOwnerHealed), HealingInfo); }
        public void OnOwnerDamageTaken(DamageInfo DamageInfo) { Invoke(nameof(OnOwnerDamageTaken), DamageInfo); }
        public bool IsGreyHealthDisabled() { return Invoke<bool>(nameof(IsGreyHealthDisabled)); }
        public int GetNumSegments() { return Invoke<int>(nameof(GetNumSegments)); }
        public int GetMaxSegments() { return Invoke<int>(nameof(GetMaxSegments)); }
        public GreyHealthComponent GetGreyHealthComponent(Actor Actor) { return Invoke<GreyHealthComponent>(nameof(GetGreyHealthComponent), Actor); }
        public float GetGreyHealth() { return Invoke<float>(nameof(GetGreyHealth)); }
        public Object GetDebugInfo(int DebugLevel) { return Invoke<Object>(nameof(GetDebugInfo), DebugLevel); }
        public bool CanRegenHealth() { return Invoke<bool>(nameof(CanRegenHealth)); }
        public void ApplyDeltaReplicated(float Delta) { Invoke(nameof(ApplyDeltaReplicated), Delta); }
        public void ApplyDelta(float Delta) { Invoke(nameof(ApplyDelta), Delta); }
        public void Append(float AppendAmount, bool CreateNewSegment, bool Notify) { Invoke(nameof(Append), AppendAmount, CreateNewSegment, Notify); }
    }
    public class MinionComponent : ActorComponent
    {
        public MinionComponent(nint addr) : base(addr) { }
        public Actor Summoner { get { return this[nameof(Summoner)].As<Actor>(); } set { this["Summoner"] = value; } }
        public Object MinionDestroyedEvent { get { return this[nameof(MinionDestroyedEvent)]; } set { this[nameof(MinionDestroyedEvent)] = value; } }
        public Object DisplayDataUpdated { get { return this[nameof(DisplayDataUpdated)]; } set { this[nameof(DisplayDataUpdated)] = value; } }
        public Texture2D DisplayIcon { get { return this[nameof(DisplayIcon)].As<Texture2D>(); } set { this["DisplayIcon"] = value; } }
        public void SetValid(bool IsMinionValid) { Invoke(nameof(SetValid), IsMinionValid); }
        public void NotifyDisplayDataUpdated() { Invoke(nameof(NotifyDisplayDataUpdated)); }
        public bool IsValidMinion() { return Invoke<bool>(nameof(IsValidMinion)); }
        public float GetSummonerStat(Object StatName) { return Invoke<float>(nameof(GetSummonerStat), StatName); }
        public float GetSpawnTime() { return Invoke<float>(nameof(GetSpawnTime)); }
        public int GetMaxMinionsForCause(Actor Cause, int Bonus) { return Invoke<int>(nameof(GetMaxMinionsForCause), Cause, Bonus); }
        public void DestroyMinion() { Invoke(nameof(DestroyMinion)); }
    }
    public class BoardPositionState : WeightedGraphNode
    {
        public BoardPositionState(nint addr) : base(addr) { }
        public BoardPositionInfo BoardSlotInfo { get { return this[nameof(BoardSlotInfo)].As<BoardPositionInfo>(); } set { this["BoardSlotInfo"] = value; } }
    }
    public class RemnantGameBoardComponent : WeightedGraphComponent
    {
        public RemnantGameBoardComponent(nint addr) : base(addr) { }
        public Object OnStartGame { get { return this[nameof(OnStartGame)]; } set { this[nameof(OnStartGame)] = value; } }
        public Object OnTurnStart { get { return this[nameof(OnTurnStart)]; } set { this[nameof(OnTurnStart)] = value; } }
        public Object OnTurnEnd { get { return this[nameof(OnTurnEnd)]; } set { this[nameof(OnTurnEnd)] = value; } }
        public Object OnPiecePositionUpdated { get { return this[nameof(OnPiecePositionUpdated)]; } set { this[nameof(OnPiecePositionUpdated)] = value; } }
        public Object OnPieceAddedOrRemoved { get { return this[nameof(OnPieceAddedOrRemoved)]; } set { this[nameof(OnPieceAddedOrRemoved)] = value; } }
        public Object OnPotentialMovePieceAddedOrRemoved { get { return this[nameof(OnPotentialMovePieceAddedOrRemoved)]; } set { this[nameof(OnPotentialMovePieceAddedOrRemoved)] = value; } }
        public Object OnPiecePositionReset { get { return this[nameof(OnPiecePositionReset)]; } set { this[nameof(OnPiecePositionReset)] = value; } }
        public Object OnGameWon { get { return this[nameof(OnGameWon)]; } set { this[nameof(OnGameWon)] = value; } }
        public Object PlayerPieceBase { get { return this[nameof(PlayerPieceBase)]; } set { this[nameof(PlayerPieceBase)] = value; } }
        public Object PlayerPotentialMoveVisualBase { get { return this[nameof(PlayerPotentialMoveVisualBase)]; } set { this[nameof(PlayerPotentialMoveVisualBase)] = value; } }
        public Object AIPieceBase { get { return this[nameof(AIPieceBase)]; } set { this[nameof(AIPieceBase)] = value; } }
        public bool bAllowDiagonalMovement { get { return this[nameof(bAllowDiagonalMovement)].Flag; } set { this[nameof(bAllowDiagonalMovement)].Flag = value; } }
        public bool bSlotInfoDeterminesDiagonalMovement { get { return this[nameof(bSlotInfoDeterminesDiagonalMovement)].Flag; } set { this[nameof(bSlotInfoDeterminesDiagonalMovement)].Flag = value; } }
        public bool bScaleRulesByDifficulty { get { return this[nameof(bScaleRulesByDifficulty)].Flag; } set { this[nameof(bScaleRulesByDifficulty)].Flag = value; } }
        public BoardRules GameRules { get { return this[nameof(GameRules)].As<BoardRules>(); } set { this["GameRules"] = value; } }
        public Object DifficultyScaledGameRules { get { return this[nameof(DifficultyScaledGameRules)]; } set { this[nameof(DifficultyScaledGameRules)] = value; } }
        public bool bUseDefaultConfiguration { get { return this[nameof(bUseDefaultConfiguration)].Flag; } set { this[nameof(bUseDefaultConfiguration)].Flag = value; } }
        public Array<BoardRow> DefaultConfiguration { get { return new Array<BoardRow>(this[nameof(DefaultConfiguration)].Address); } }
        public Array<BoardRow> StartingConfiguration { get { return new Array<BoardRow>(this[nameof(StartingConfiguration)].Address); } }
        public bool bIsPlaying { get { return this[nameof(bIsPlaying)].Flag; } set { this[nameof(bIsPlaying)].Flag = value; } }
        public EBoardUser CurrentTurn { get { return (EBoardUser)this[nameof(CurrentTurn)].GetValue<int>(); } set { this[nameof(CurrentTurn)].SetValue<int>((int)value); } }
        public Actor CurrentAI { get { return this[nameof(CurrentAI)].As<Actor>(); } set { this["CurrentAI"] = value; } }
        public Actor CurrentPlayer { get { return this[nameof(CurrentPlayer)].As<Actor>(); } set { this["CurrentPlayer"] = value; } }
        public Array<CachedPotentialMovePieceInfo> CachedMoveVisualPieces { get { return new Array<CachedPotentialMovePieceInfo>(this[nameof(CachedMoveVisualPieces)].Address); } }
        public Object CachedUserPieces { get { return this[nameof(CachedUserPieces)]; } set { this[nameof(CachedUserPieces)] = value; } }
        public void UpdatePieceActorLocations() { Invoke(nameof(UpdatePieceActorLocations)); }
        public void StartTurn(bool bIsResuming) { Invoke(nameof(StartTurn), bIsResuming); }
        public void StartGame(bool bResetBoardState, Actor Player, Actor Opponent) { Invoke(nameof(StartGame), bResetBoardState, Player, Opponent); }
        public void PauseTurn() { Invoke(nameof(PauseTurn)); }
        public void OnRep_CurrentPlayer() { Invoke(nameof(OnRep_CurrentPlayer)); }
        public bool IsGameInProgress() { return Invoke<bool>(nameof(IsGameInProgress)); }
        public void GetPositionsForUser(EBoardUser User, Array<GraphPosition> OutPositions) { Invoke(nameof(GetPositionsForUser), User, OutPositions); }
        public void EndTurn() { Invoke(nameof(EndTurn)); }
        public void EndGame(bool bResetBoard, EBoardLayout GraphLayout) { Invoke(nameof(EndGame), bResetBoard, GraphLayout); }
    }
    public class RemnantGameBoardUserComponent : ActorComponent
    {
        public RemnantGameBoardUserComponent(nint addr) : base(addr) { }
        public RemnantGameBoardComponent GameBoard { get { return this[nameof(GameBoard)].As<RemnantGameBoardComponent>(); } set { this["GameBoard"] = value; } }
        public void ServerHandleGamePieceFocusEvent(Actor Actor, GraphPosition TargetPosition, GraphPosition RootPosition) { Invoke(nameof(ServerHandleGamePieceFocusEvent), Actor, TargetPosition, RootPosition); }
        public void ServerCleanupGame() { Invoke(nameof(ServerCleanupGame)); }
        public void NotifyGamePieceFocusEvent(Actor Actor, ECursorInteractType InteractType) { Invoke(nameof(NotifyGamePieceFocusEvent), Actor, InteractType); }
        public void ClientUpdateMovePieces(Array<CachedPotentialMovePieceInfo> PositionInfo, bool bSetVisible, bool bApplyToAll, bool bClearInfo) { Invoke(nameof(ClientUpdateMovePieces), PositionInfo, bSetVisible, bApplyToAll, bClearInfo); }
        public void ClientSetPlayerControlsActive(bool bDoActivate) { Invoke(nameof(ClientSetPlayerControlsActive), bDoActivate); }
        public void ClientSetCursorBindings(bool bDoActivate) { Invoke(nameof(ClientSetCursorBindings), bDoActivate); }
        public void ClientInitializeForGame(RemnantGameBoardComponent GameBoardComponent) { Invoke(nameof(ClientInitializeForGame), GameBoardComponent); }
    }
    public class RemnantGameBoardAIComponent : ActorComponent
    {
        public RemnantGameBoardAIComponent(nint addr) : base(addr) { }
        public int RandomMovePercent { get { return this[nameof(RandomMovePercent)].GetValue<int>(); } set { this[nameof(RandomMovePercent)].SetValue<int>(value); } }
        public bool bScaleWithDifficulty { get { return this[nameof(bScaleWithDifficulty)].Flag; } set { this[nameof(bScaleWithDifficulty)].Flag = value; } }
        public int DifficultyModifier { get { return this[nameof(DifficultyModifier)].GetValue<int>(); } set { this[nameof(DifficultyModifier)].SetValue<int>(value); } }
    }
    public class RemnantSilhouetteComponent : SilhouetteComponent
    {
        public RemnantSilhouetteComponent(nint addr) : base(addr) { }
    }
    public class SummonerComponent : ActorComponent
    {
        public SummonerComponent(nint addr) : base(addr) { }
        public Object OnSummonAdded { get { return this[nameof(OnSummonAdded)]; } set { this[nameof(OnSummonAdded)] = value; } }
        public Object OnSummonRemoved { get { return this[nameof(OnSummonRemoved)]; } set { this[nameof(OnSummonRemoved)] = value; } }
        public void RemoveSummon(Actor Summon) { Invoke(nameof(RemoveSummon), Summon); }
        public void RegisterSummon(Actor Summon) { Invoke(nameof(RegisterSummon), Summon); }
        public void OnSummonEndPlay(Actor Summon, byte EndPlayReason) { Invoke(nameof(OnSummonEndPlay), Summon, EndPlayReason); }
        public bool HasSummon(Object SummonClass) { return Invoke<bool>(nameof(HasSummon), SummonClass); }
        public Array<Actor> GetSummonsOfType(Object SummonClass) { return Invoke<Array<Actor>>(nameof(GetSummonsOfType), SummonClass); }
        public Array<Actor> GetSummons() { return Invoke<Array<Actor>>(nameof(GetSummons)); }
        public int GetNumSummonsOfType(Object SummonClass) { return Invoke<int>(nameof(GetNumSummonsOfType), SummonClass); }
    }
    public class PlayerStateRemnant : PlayerStateGunfire
    {
        public PlayerStateRemnant(nint addr) : base(addr) { }
        public Object OnLocalPlayerTargetChanged { get { return this[nameof(OnLocalPlayerTargetChanged)]; } set { this[nameof(OnLocalPlayerTargetChanged)] = value; } }
        public bool bTraveling { get { return this[nameof(bTraveling)].Flag; } set { this[nameof(bTraveling)].Flag = value; } }
        public bool bIsLocalPlayerTarget { get { return this[nameof(bIsLocalPlayerTarget)].Flag; } set { this[nameof(bIsLocalPlayerTarget)].Flag = value; } }
        public void SetIsLocalPlayerTarget(bool IsTarget) { Invoke(nameof(SetIsLocalPlayerTarget), IsTarget); }
        public void OnRep_Traveling() { Invoke(nameof(OnRep_Traveling)); }
        public bool IsTraveling() { return Invoke<bool>(nameof(IsTraveling)); }
    }
    public class RemnantOnlineUtil : Object
    {
        public RemnantOnlineUtil(nint addr) : base(addr) { }
        public void SetModeFilter(int Mode) { Invoke(nameof(SetModeFilter), Mode); }
        public void SetDifficultyFilter(int Difficulty) { Invoke(nameof(SetDifficultyFilter), Difficulty); }
        public OnlineSessionDetailsRemnant GetOnlineSessionDetails(BlueprintSessionResult SessionResult) { return Invoke<OnlineSessionDetailsRemnant>(nameof(GetOnlineSessionDetails), SessionResult); }
        public BlueprintSessionResult GetLocalSession(Object WorldContextObject) { return Invoke<BlueprintSessionResult>(nameof(GetLocalSession), WorldContextObject); }
    }
    public class RemnantSequencerManager : SequencerManager
    {
        public RemnantSequencerManager(nint addr) : base(addr) { }
    }
    public class RemnantUtil : Object
    {
        public RemnantUtil(nint addr) : base(addr) { }
        public bool IsZoneLinkValid(ZoneLinkInfo ZoneLink) { return Invoke<bool>(nameof(IsZoneLinkValid), ZoneLink); }
        public bool IsGameSessionReady(Object WorldContextObject) { return Invoke<bool>(nameof(IsGameSessionReady), WorldContextObject); }
        public bool IsGameSeedOverridden() { return Invoke<bool>(nameof(IsGameSeedOverridden)); }
        public Actor GetZoneLinkActor(ZoneLinkInfo ZoneLink) { return Invoke<Actor>(nameof(GetZoneLinkActor), ZoneLink); }
        public int GetGameSeed() { return Invoke<int>(nameof(GetGameSeed)); }
        public bool GetBaseZoneLinkByLabel(Object WorldContextObject, Object Label, ZoneLinkInfo OutZoneLink) { return Invoke<bool>(nameof(GetBaseZoneLinkByLabel), WorldContextObject, Label, OutZoneLink); }
        public bool GetBaseZoneLink(Object WorldContextObject, ZoneLinkInfo OutZoneLink) { return Invoke<bool>(nameof(GetBaseZoneLink), WorldContextObject, OutZoneLink); }
        public int GetBaseZoneID() { return Invoke<int>(nameof(GetBaseZoneID)); }
        public ZoneActor GetBaseZoneActor(Object WorldContextObject) { return Invoke<ZoneActor>(nameof(GetBaseZoneActor), WorldContextObject); }
        public bool CanPlayerExitGame(Object WorldContextObject) { return Invoke<bool>(nameof(CanPlayerExitGame), WorldContextObject); }
    }
    public class WorldResetInterface : Interface
    {
        public WorldResetInterface(nint addr) : base(addr) { }
        public void OnWorldReset() { Invoke(nameof(OnWorldReset)); }
        public void OnNotifyAllWorldReset() { Invoke(nameof(OnNotifyAllWorldReset)); }
    }
    public class WorldResetUtil : Object
    {
        public WorldResetUtil(nint addr) : base(addr) { }
        public bool IsWorldResetInProgress(Object WorldContextObject) { return Invoke<bool>(nameof(IsWorldResetInProgress), WorldContextObject); }
        public byte GetWorldResetColorIndex() { return Invoke<byte>(nameof(GetWorldResetColorIndex)); }
    }
    public class EnvQueryTest_InZone : EnvQueryTest
    {
        public EnvQueryTest_InZone(nint addr) : base(addr) { }
        public float ZonePadding { get { return this[nameof(ZonePadding)].GetValue<float>(); } set { this[nameof(ZonePadding)].SetValue<float>(value); } }
    }
    public class DragonHeart : UseableItem
    {
        public DragonHeart(nint addr) : base(addr) { }
        public int NumCharges { get { return this[nameof(NumCharges)].GetValue<int>(); } set { this[nameof(NumCharges)].SetValue<int>(value); } }
        public Object UpgradeItemBP { get { return this[nameof(UpgradeItemBP)]; } set { this[nameof(UpgradeItemBP)] = value; } }
        public Object DHPool { get { return this[nameof(DHPool)]; } set { this[nameof(DHPool)] = value; } }
        public VitalityComponent DHPoolComponent { get { return this[nameof(DHPoolComponent)].As<VitalityComponent>(); } set { this["DHPoolComponent"] = value; } }
        public void VerifyQuantity() { Invoke(nameof(VerifyQuantity)); }
        public void Regenerate() { Invoke(nameof(Regenerate)); }
        public void OnPoolValueChanged(VitalityComponent PoolComponent) { Invoke(nameof(OnPoolValueChanged), PoolComponent); }
        public int GetMaxCurrentQuantity() { return Invoke<int>(nameof(GetMaxCurrentQuantity)); }
    }
    public class FlashlightInstanceData : EquipmentInstanceData
    {
        public FlashlightInstanceData(nint addr) : base(addr) { }
        public float Charge { get { return this[nameof(Charge)].GetValue<float>(); } set { this[nameof(Charge)].SetValue<float>(value); } }
        public bool Depleted { get { return this[nameof(Depleted)].Flag; } set { this[nameof(Depleted)].Flag = value; } }
        public bool On { get { return this[nameof(On)].Flag; } set { this[nameof(On)].Flag = value; } }
    }
    public class FlashlightLOSTaggingComponent : ActorComponent
    {
        public FlashlightLOSTaggingComponent(nint addr) : base(addr) { }
        public Array<Object> LightOverlapTags { get { return new Array<Object>(this[nameof(LightOverlapTags)].Address); } }
        public PrimitiveComponent OverlapComponent { get { return this[nameof(OverlapComponent)].As<PrimitiveComponent>(); } set { this["OverlapComponent"] = value; } }
        public bool LightEndOverlap(Actor Actor) { return Invoke<bool>(nameof(LightEndOverlap), Actor); }
        public void LightBeginOverlap(Actor Actor) { Invoke(nameof(LightBeginOverlap), Actor); }
        public void EnableOverlapCheck(PrimitiveComponent Primitive) { Invoke(nameof(EnableOverlapCheck), Primitive); }
        public void DisableOverlapCheck() { Invoke(nameof(DisableOverlapCheck)); }
    }
    public class Flashlight : UseableItem
    {
        public Flashlight(nint addr) : base(addr) { }
        public bool On { get { return this[nameof(On)].Flag; } set { this[nameof(On)].Flag = value; } }
        public float FlashThreshold { get { return this[nameof(FlashThreshold)].GetValue<float>(); } set { this[nameof(FlashThreshold)].SetValue<float>(value); } }
        public float ChargeTimeMin { get { return this[nameof(ChargeTimeMin)].GetValue<float>(); } set { this[nameof(ChargeTimeMin)].SetValue<float>(value); } }
        public FlashlightLOSTaggingComponent FlashLOSComp { get { return this[nameof(FlashLOSComp)].As<FlashlightLOSTaggingComponent>(); } set { this["FlashLOSComp"] = value; } }
        public PrimitiveComponent OverlapComponent { get { return this[nameof(OverlapComponent)].As<PrimitiveComponent>(); } set { this["OverlapComponent"] = value; } }
        public void ServerToggleFlashlight() { Invoke(nameof(ServerToggleFlashlight)); }
        public void OnTurnedOn() { Invoke(nameof(OnTurnedOn)); }
        public void OnTurnedOff() { Invoke(nameof(OnTurnedOff)); }
        public void OnEndFlash() { Invoke(nameof(OnEndFlash)); }
        public void OnBeginFlash() { Invoke(nameof(OnBeginFlash)); }
        public bool LightEndOverlap(Actor Actor) { return Invoke<bool>(nameof(LightEndOverlap), Actor); }
        public void LightBeginOverlap(Actor Actor) { Invoke(nameof(LightBeginOverlap), Actor); }
        public void ApplyChargeDelta(float Delta) { Invoke(nameof(ApplyChargeDelta), Delta); }
    }
    public class GenericItem : Item
    {
        public GenericItem(nint addr) : base(addr) { }
        public SpawnTable RandomizedDrop { get { return this[nameof(RandomizedDrop)].As<SpawnTable>(); } set { this["RandomizedDrop"] = value; } }
        public Array<Object> SpawnTags { get { return new Array<Object>(this[nameof(SpawnTags)].Address); } }
        public EGenerationType GenerationType { get { return (EGenerationType)this[nameof(GenerationType)].GetValue<int>(); } set { this[nameof(GenerationType)].SetValue<int>((int)value); } }
        public bool UsePlayerLevel { get { return this[nameof(UsePlayerLevel)].Flag; } set { this[nameof(UsePlayerLevel)].Flag = value; } }
        public SpawnList CachedSpawnList { get { return this[nameof(CachedSpawnList)].As<SpawnList>(); } set { this["CachedSpawnList"] = value; } }
        public Array<GenericDropInfo> CachedSpawnInfo { get { return new Array<GenericDropInfo>(this[nameof(CachedSpawnInfo)].Address); } }
        public bool bUseGeneratedObjectLabel { get { return this[nameof(bUseGeneratedObjectLabel)].Flag; } set { this[nameof(bUseGeneratedObjectLabel)].Flag = value; } }
        public bool bUseGeneratedObjectIcon { get { return this[nameof(bUseGeneratedObjectIcon)].Flag; } set { this[nameof(bUseGeneratedObjectIcon)].Flag = value; } }
        public bool bUseGeneratedObjectPickupSound { get { return this[nameof(bUseGeneratedObjectPickupSound)].Flag; } set { this[nameof(bUseGeneratedObjectPickupSound)].Flag = value; } }
        public bool bAddToInventory { get { return this[nameof(bAddToInventory)].Flag; } set { this[nameof(bAddToInventory)].Flag = value; } }
        public bool bSaveOnAward { get { return this[nameof(bSaveOnAward)].Flag; } set { this[nameof(bSaveOnAward)].Flag = value; } }
        public bool ValidatePickupHandled(InventoryComponent Inventory) { return Invoke<bool>(nameof(ValidatePickupHandled), Inventory); }
        public bool ValidateAddToInventory(InventoryComponent Inventory) { return Invoke<bool>(nameof(ValidateAddToInventory), Inventory); }
        public void OnRep_CachedSpawnInfo() { Invoke(nameof(OnRep_CachedSpawnInfo)); }
        public void OnFinishedItemInit() { Invoke(nameof(OnFinishedItemInit)); }
        public bool HasMaxSpawnsForCharacter(Actor Actor) { return Invoke<bool>(nameof(HasMaxSpawnsForCharacter), Actor); }
        public void HandleAward(InventoryComponent Inventory, bool bForceNoSharing) { Invoke(nameof(HandleAward), Inventory, bForceNoSharing); }
        public int GetRewardItemLevel(Actor Receipient) { return Invoke<int>(nameof(GetRewardItemLevel), Receipient); }
        public void FinishSpawnInit() { Invoke(nameof(FinishSpawnInit)); }
        public void ClientSetSpawnInfo(Array<GenericDropInfo> SpawnInfo) { Invoke(nameof(ClientSetSpawnInfo), SpawnInfo); }
    }
    public class ItemCategory_Quest : ItemCategory
    {
        public ItemCategory_Quest(nint addr) : base(addr) { }
    }
    public class ItemCategory_PlayerQuest : ItemCategory_Quest
    {
        public ItemCategory_PlayerQuest(nint addr) : base(addr) { }
    }
    public class LootContainer : ManagedActor
    {
        public LootContainer(nint addr) : base(addr) { }
        public Object OnGenerated { get { return this[nameof(OnGenerated)]; } set { this[nameof(OnGenerated)] = value; } }
        public SpawnList SpawnList { get { return this[nameof(SpawnList)].As<SpawnList>(); } set { this["SpawnList"] = value; } }
        public Array<LootContainerItem> Items { get { return new Array<LootContainerItem>(this[nameof(Items)].Address); } }
        public bool IsGenerating { get { return this[nameof(IsGenerating)].Flag; } set { this[nameof(IsGenerating)].Flag = value; } }
        public void OnSpawnListLoaded() { Invoke(nameof(OnSpawnListLoaded)); }
        public void Generate(SpawnTable SpawnTable, Array<Object> SpawnTags) { Invoke(nameof(Generate), SpawnTable, SpawnTags); }
        public void ClearItems() { Invoke(nameof(ClearItems)); }
    }
    public class LoreItem : Item
    {
        public LoreItem(nint addr) : base(addr) { }
        public bool AutoOpenUI { get { return this[nameof(AutoOpenUI)].Flag; } set { this[nameof(AutoOpenUI)].Flag = value; } }
        public bool OverrideHideReadUI { get { return this[nameof(OverrideHideReadUI)].Flag; } set { this[nameof(OverrideHideReadUI)].Flag = value; } }
        public Array<LorePage> Pages { get { return new Array<LorePage>(this[nameof(Pages)].Address); } }
        public Object LoreImageSet { get { return this[nameof(LoreImageSet)]; } set { this[nameof(LoreImageSet)] = value; } }
        public void LoreNotify(Object WorldContextObject, LorePage Page) { Invoke(nameof(LoreNotify), WorldContextObject, Page); }
    }
    public class LoreSubsystem : WorldSubsystem
    {
        public LoreSubsystem(nint addr) : base(addr) { }
        public Object OnLoreImageSetLoaded { get { return this[nameof(OnLoreImageSetLoaded)]; } set { this[nameof(OnLoreImageSetLoaded)] = value; } }
        public Array<LoreImageSetData> ImageSetRefs { get { return new Array<LoreImageSetData>(this[nameof(ImageSetRefs)].Address); } }
        public void OnImageSetLoaded(Actor ContextActor, SoftObjectPath ImageSetPath) { Invoke(nameof(OnImageSetLoaded), ContextActor, ImageSetPath); }
        public void OnContextActorEndPlay(Actor ContextActor, byte EndPlayReason) { Invoke(nameof(OnContextActorEndPlay), ContextActor, EndPlayReason); }
        public void InitializeLoreImageSet(Actor LifetimeContextActor, Object LoreClass) { Invoke(nameof(InitializeLoreImageSet), LifetimeContextActor, LoreClass); }
        public LoreSubsystem GetInstance(Object WorldContextObject) { return Invoke<LoreSubsystem>(nameof(GetInstance), WorldContextObject); }
    }
    public class MinionSummonableInterface : Interface
    {
        public MinionSummonableInterface(nint addr) : base(addr) { }
        public int GetMaxSummons() { return Invoke<int>(nameof(GetMaxSummons)); }
    }
    public class MinionInterface : Interface
    {
        public MinionInterface(nint addr) : base(addr) { }
        public Array<Texture2D> GetStateIcons() { return Invoke<Array<Texture2D>>(nameof(GetStateIcons)); }
    }
    public class QuestItemType : ItemType
    {
        public QuestItemType(nint addr) : base(addr) { }
        public Object Quest { get { return this[nameof(Quest)]; } set { this[nameof(Quest)] = value; } }
    }
    public class RemnantRangedWeapon : RangedWeapon
    {
        public RemnantRangedWeapon(nint addr) : base(addr) { }
        public Object DefaultMod { get { return this[nameof(DefaultMod)]; } set { this[nameof(DefaultMod)] = value; } }
        public WeaponAffinityComponent WeaponAffinity { get { return this[nameof(WeaponAffinity)].As<WeaponAffinityComponent>(); } set { this["WeaponAffinity"] = value; } }
        public bool bResetAmmoOnEquip { get { return this[nameof(bResetAmmoOnEquip)].Flag; } set { this[nameof(bResetAmmoOnEquip)].Flag = value; } }
        public InputAction AltFireInputAction { get { return this[nameof(AltFireInputAction)].As<InputAction>(); } set { this["AltFireInputAction"] = value; } }
        public float Power { get { return this[nameof(Power)].GetValue<float>(); } set { this[nameof(Power)].SetValue<float>(value); } }
        public byte Charges { get { return this[nameof(Charges)].GetValue<byte>(); } set { this[nameof(Charges)].SetValue<byte>(value); } }
        public float PassiveModPowerRegenFrequency { get { return this[nameof(PassiveModPowerRegenFrequency)].GetValue<float>(); } set { this[nameof(PassiveModPowerRegenFrequency)].SetValue<float>(value); } }
        public Object OnPowerChanged { get { return this[nameof(OnPowerChanged)]; } set { this[nameof(OnPowerChanged)] = value; } }
        public Object OnChargesChanged { get { return this[nameof(OnChargesChanged)]; } set { this[nameof(OnChargesChanged)] = value; } }
        public Object OnUseMod { get { return this[nameof(OnUseMod)]; } set { this[nameof(OnUseMod)] = value; } }
        public Object OnUseModFail { get { return this[nameof(OnUseModFail)]; } set { this[nameof(OnUseModFail)] = value; } }
        public Object OnActivateMod { get { return this[nameof(OnActivateMod)]; } set { this[nameof(OnActivateMod)] = value; } }
        public EModActiveState ActiveState { get { return (EModActiveState)this[nameof(ActiveState)].GetValue<int>(); } set { this[nameof(ActiveState)].SetValue<int>((int)value); } }
        public int ActiveModActionID { get { return this[nameof(ActiveModActionID)].GetValue<int>(); } set { this[nameof(ActiveModActionID)].SetValue<int>(value); } }
        public float AdditionalRadius { get { return this[nameof(AdditionalRadius)].GetValue<float>(); } set { this[nameof(AdditionalRadius)].SetValue<float>(value); } }
        public float AdditionalDistance { get { return this[nameof(AdditionalDistance)].GetValue<float>(); } set { this[nameof(AdditionalDistance)].SetValue<float>(value); } }
        public Vector AdditionalRelativeOffsets { get { return this[nameof(AdditionalRelativeOffsets)].As<Vector>(); } set { this["AdditionalRelativeOffsets"] = value; } }
        public void UseMod() { Invoke(nameof(UseMod)); }
        public void UseCharge() { Invoke(nameof(UseCharge)); }
        public void UseAllCharges() { Invoke(nameof(UseAllCharges)); }
        public bool ShouldModCancelUse() { return Invoke<bool>(nameof(ShouldModCancelUse)); }
        public void SetModActive(EModActiveState ModState, int ActionID, bool bForceNotify) { Invoke(nameof(SetModActive), ModState, ActionID, bForceNotify); }
        public void ServerUseWithAim(Vector_NetQuantize AimOrigin, Vector_NetQuantize AimEnd) { Invoke(nameof(ServerUseWithAim), AimOrigin, AimEnd); }
        public void ServerUse() { Invoke(nameof(ServerUse)); }
        public void OnRep_Power() { Invoke(nameof(OnRep_Power)); }
        public void OnRep_ModActive() { Invoke(nameof(OnRep_ModActive)); }
        public void OnRep_Charges() { Invoke(nameof(OnRep_Charges)); }
        public void OnFinishWeaponModeAnimation() { Invoke(nameof(OnFinishWeaponModeAnimation)); }
        public void OnFinishUseState(Object StateName, Object PreviousStateName) { Invoke(nameof(OnFinishUseState), StateName, PreviousStateName); }
        public void OnFinishUseAnimation() { Invoke(nameof(OnFinishUseAnimation)); }
        public void OnAltFireReleased() { Invoke(nameof(OnAltFireReleased)); }
        public void OnAltFirePressed() { Invoke(nameof(OnAltFirePressed)); }
        public void OnActivateSecondary() { Invoke(nameof(OnActivateSecondary)); }
        public void OnActivate() { Invoke(nameof(OnActivate)); }
        public void OnActionRemoved(ActionBase Action) { Invoke(nameof(OnActionRemoved), Action); }
        public void MulticastUse() { Invoke(nameof(MulticastUse)); }
        public bool IsModActive() { return Invoke<bool>(nameof(IsModActive)); }
        public RemnantWeaponMod GetWeaponMod() { return Invoke<RemnantWeaponMod>(nameof(GetWeaponMod)); }
        public float GetPower() { return Invoke<float>(nameof(GetPower)); }
        public EModActiveState GetModActiveState() { return Invoke<EModActiveState>(nameof(GetModActiveState)); }
        public float GetModActiveRemainingPct() { return Invoke<float>(nameof(GetModActiveRemainingPct)); }
        public byte GetCharges() { return Invoke<byte>(nameof(GetCharges)); }
        public void EndUseAnimation() { Invoke(nameof(EndUseAnimation)); }
        public void DelayedDeactivate() { Invoke(nameof(DelayedDeactivate)); }
    }
    public class RemnantBeamWeapon : RemnantRangedWeapon
    {
        public RemnantBeamWeapon(nint addr) : base(addr) { }
        public bool BeamWeaponFiring { get { return this[nameof(BeamWeaponFiring)].Flag; } set { this[nameof(BeamWeaponFiring)].Flag = value; } }
        public void SetBeamFiring_Server(bool Firing) { Invoke(nameof(SetBeamFiring_Server), Firing); }
        public void OnRep_BeamFiring() { Invoke(nameof(OnRep_BeamFiring)); }
        public void OnEndBeamFX() { Invoke(nameof(OnEndBeamFX)); }
        public void OnBeginBeamFX() { Invoke(nameof(OnBeginBeamFX)); }
        public bool IsBeamFiring() { return Invoke<bool>(nameof(IsBeamFiring)); }
    }
    public class RemnantMeleeWeapon : MeleeWeapon
    {
        public RemnantMeleeWeapon(nint addr) : base(addr) { }
        public WeaponAffinityComponent WeaponAffinity { get { return this[nameof(WeaponAffinity)].As<WeaponAffinityComponent>(); } set { this["WeaponAffinity"] = value; } }
        public Object OverridePower2DamageType { get { return this[nameof(OverridePower2DamageType)]; } set { this[nameof(OverridePower2DamageType)] = value; } }
    }
    public class RemnantWeaponMod : EquipmentMod
    {
        public RemnantWeaponMod(nint addr) : base(addr) { }
        public float PowerBasis { get { return this[nameof(PowerBasis)].GetValue<float>(); } set { this[nameof(PowerBasis)].SetValue<float>(value); } }
        public byte MaxCharges { get { return this[nameof(MaxCharges)].GetValue<byte>(); } set { this[nameof(MaxCharges)].SetValue<byte>(value); } }
        public EModInputMode InputMode { get { return (EModInputMode)this[nameof(InputMode)].GetValue<int>(); } set { this[nameof(InputMode)].SetValue<int>((int)value); } }
        public Array<Object> PreviewAnimTags { get { return new Array<Object>(this[nameof(PreviewAnimTags)].Address); } }
        public bool bStowWeaponForPreview { get { return this[nameof(bStowWeaponForPreview)].Flag; } set { this[nameof(bStowWeaponForPreview)].Flag = value; } }
        public float MinimumHoldTime { get { return this[nameof(MinimumHoldTime)].GetValue<float>(); } set { this[nameof(MinimumHoldTime)].SetValue<float>(value); } }
        public bool bUseAllChargesOnConsume { get { return this[nameof(bUseAllChargesOnConsume)].Flag; } set { this[nameof(bUseAllChargesOnConsume)].Flag = value; } }
        public bool bToggleable { get { return this[nameof(bToggleable)].Flag; } set { this[nameof(bToggleable)].Flag = value; } }
        public bool bHasSecondaryAction { get { return this[nameof(bHasSecondaryAction)].Flag; } set { this[nameof(bHasSecondaryAction)].Flag = value; } }
        public bool bRequiresAllowActionForUse { get { return this[nameof(bRequiresAllowActionForUse)].Flag; } set { this[nameof(bRequiresAllowActionForUse)].Flag = value; } }
        public Object ModUsageTag { get { return this[nameof(ModUsageTag)]; } set { this[nameof(ModUsageTag)] = value; } }
        public bool bBlocksActionsWhileInUse { get { return this[nameof(bBlocksActionsWhileInUse)].Flag; } set { this[nameof(bBlocksActionsWhileInUse)].Flag = value; } }
        public RangedWeaponMode WeaponMode { get { return this[nameof(WeaponMode)].As<RangedWeaponMode>(); } set { this["WeaponMode"] = value; } }
        public Object ActivateAnimation { get { return this[nameof(ActivateAnimation)]; } set { this[nameof(ActivateAnimation)] = value; } }
        public Object DeactivateAnimation { get { return this[nameof(DeactivateAnimation)]; } set { this[nameof(DeactivateAnimation)] = value; } }
        public Object UseStartAnimation { get { return this[nameof(UseStartAnimation)]; } set { this[nameof(UseStartAnimation)] = value; } }
        public Object UseAnimation { get { return this[nameof(UseAnimation)]; } set { this[nameof(UseAnimation)] = value; } }
        public bool LoopUseAnimation { get { return this[nameof(LoopUseAnimation)].Flag; } set { this[nameof(LoopUseAnimation)].Flag = value; } }
        public Object UseEndAnimation { get { return this[nameof(UseEndAnimation)]; } set { this[nameof(UseEndAnimation)] = value; } }
        public Object SecondaryUseAnimation { get { return this[nameof(SecondaryUseAnimation)]; } set { this[nameof(SecondaryUseAnimation)] = value; } }
        public Object UseState { get { return this[nameof(UseState)]; } set { this[nameof(UseState)] = value; } }
        public Object UseCrouchState { get { return this[nameof(UseCrouchState)]; } set { this[nameof(UseCrouchState)] = value; } }
        public bool bStowWeaponForUseAnimation { get { return this[nameof(bStowWeaponForUseAnimation)].Flag; } set { this[nameof(bStowWeaponForUseAnimation)].Flag = value; } }
        public Object ActiveVisual { get { return this[nameof(ActiveVisual)]; } set { this[nameof(ActiveVisual)] = value; } }
        public Object ActiveImpactEffectOverride { get { return this[nameof(ActiveImpactEffectOverride)]; } set { this[nameof(ActiveImpactEffectOverride)] = value; } }
        public Object ActiveImpactEffectOverlayOverride { get { return this[nameof(ActiveImpactEffectOverlayOverride)]; } set { this[nameof(ActiveImpactEffectOverlayOverride)] = value; } }
        public Array<Object> CharacterAnimTags { get { return new Array<Object>(this[nameof(CharacterAnimTags)].Address); } }
        public Array<LoadableModAsset> Assets { get { return new Array<LoadableModAsset>(this[nameof(Assets)].Address); } }
        public bool ShowReticule() { return Invoke<bool>(nameof(ShowReticule)); }
        public void SetMinHoldTime(float HoldTime) { Invoke(nameof(SetMinHoldTime), HoldTime); }
        public void OnUse() { Invoke(nameof(OnUse)); }
        public void OnStartCustomIdle() { Invoke(nameof(OnStartCustomIdle)); }
        public void OnSecondaryActivate() { Invoke(nameof(OnSecondaryActivate)); }
        public void OnPreviewStart() { Invoke(nameof(OnPreviewStart)); }
        public void OnPreviewEnd() { Invoke(nameof(OnPreviewEnd)); }
        public void OnPreFireEnd() { Invoke(nameof(OnPreFireEnd)); }
        public void OnPreFireBegin() { Invoke(nameof(OnPreFireBegin)); }
        public void OnPreActivate() { Invoke(nameof(OnPreActivate)); }
        public void OnFireEnd() { Invoke(nameof(OnFireEnd)); }
        public void OnFireBegin() { Invoke(nameof(OnFireBegin)); }
        public void OnFire(Vector From, Vector To, float WeaponSpread) { Invoke(nameof(OnFire), From, To, WeaponSpread); }
        public void OnFinishLoadingAssets() { Invoke(nameof(OnFinishLoadingAssets)); }
        public void OnEndUse() { Invoke(nameof(OnEndUse)); }
        public void OnEndCustomIdle() { Invoke(nameof(OnEndCustomIdle)); }
        public void OnDeactivate() { Invoke(nameof(OnDeactivate)); }
        public void OnChargesChanged(int Charges) { Invoke(nameof(OnChargesChanged), Charges); }
        public void OnCharacterHitTarget(DamageInfo DamageInfo) { Invoke(nameof(OnCharacterHitTarget), DamageInfo); }
        public void OnBeginUse() { Invoke(nameof(OnBeginUse)); }
        public void OnActivate() { Invoke(nameof(OnActivate)); }
        public void ModifyModPower(float Delta) { Invoke(nameof(ModifyModPower), Delta); }
        public bool IsUseState(Object State) { return Invoke<bool>(nameof(IsUseState), State); }
        public bool IsPreviewing() { return Invoke<bool>(nameof(IsPreviewing)); }
        public float GetWindupProgress(float TimePassed) { return Invoke<float>(nameof(GetWindupProgress), TimePassed); }
        public float GetWindupOverdrawnProgress(float TimePassed) { return Invoke<float>(nameof(GetWindupOverdrawnProgress), TimePassed); }
        public RemnantRangedWeapon GetWeapon() { return Invoke<RemnantRangedWeapon>(nameof(GetWeapon)); }
        public Object GetUseState() { return Invoke<Object>(nameof(GetUseState)); }
        public float GetPowerBasis() { return Invoke<float>(nameof(GetPowerBasis)); }
        public Object GetModAssetAsClass(Object AssetName) { return Invoke<Object>(nameof(GetModAssetAsClass), AssetName); }
        public Object GetModAsset(Object AssetName) { return Invoke<Object>(nameof(GetModAsset), AssetName); }
        public float GetModActiveRemainingPct() { return Invoke<float>(nameof(GetModActiveRemainingPct)); }
        public int GetMaxCharges() { return Invoke<int>(nameof(GetMaxCharges)); }
        public bool GetClientAimVector(Vector AimOrigin, Vector AimEnd) { return Invoke<bool>(nameof(GetClientAimVector), AimOrigin, AimEnd); }
        public void DoInstantHit(Vector Origin, Vector End, float WeaponSpread) { Invoke(nameof(DoInstantHit), Origin, End, WeaponSpread); }
        public bool CanUse(bool IsSecondaryActivation) { return Invoke<bool>(nameof(CanUse), IsSecondaryActivation); }
        public bool CanDeactivateMod() { return Invoke<bool>(nameof(CanDeactivateMod)); }
        public bool CalculateClientAimVector(Vector AimOrigin, Vector AimEnd) { return Invoke<bool>(nameof(CalculateClientAimVector), AimOrigin, AimEnd); }
        public bool AreAssetsLoaded() { return Invoke<bool>(nameof(AreAssetsLoaded)); }
        public void ApplyDamageInfoToModPower(DamageInfo DamageInfo, float ModPowerScalar, bool bForce, bool bIgnorePenalties, bool bFillActiveMods) { Invoke(nameof(ApplyDamageInfoToModPower), DamageInfo, ModPowerScalar, bForce, bIgnorePenalties, bFillActiveMods); }
        public void AddModPower(float Damage, float BonusModPowerMod, bool bFillActiveMods) { Invoke(nameof(AddModPower), Damage, BonusModPowerMod, bFillActiveMods); }
    }
    public class SpawnTableSmartAmmo : SpawnTableElement
    {
        public SpawnTableSmartAmmo(nint addr) : base(addr) { }
        public Array<SmartAmmo> AmmoTypes { get { return new Array<SmartAmmo>(this[nameof(AmmoTypes)].Address); } }
        public int WeightedChanceForNoAmmo { get { return this[nameof(WeightedChanceForNoAmmo)].GetValue<int>(); } set { this[nameof(WeightedChanceForNoAmmo)].SetValue<int>(value); } }
        public int WeighteChanceWhenEmpty { get { return this[nameof(WeighteChanceWhenEmpty)].GetValue<int>(); } set { this[nameof(WeighteChanceWhenEmpty)].SetValue<int>(value); } }
        public int WeighteChanceQuarter { get { return this[nameof(WeighteChanceQuarter)].GetValue<int>(); } set { this[nameof(WeighteChanceQuarter)].SetValue<int>(value); } }
        public int WeighteChanceHalf { get { return this[nameof(WeighteChanceHalf)].GetValue<int>(); } set { this[nameof(WeighteChanceHalf)].SetValue<int>(value); } }
        public int WeighteChanceThreeQuarters { get { return this[nameof(WeighteChanceThreeQuarters)].GetValue<int>(); } set { this[nameof(WeighteChanceThreeQuarters)].SetValue<int>(value); } }
        public int WeighteChanceLessThanFull { get { return this[nameof(WeighteChanceLessThanFull)].GetValue<int>(); } set { this[nameof(WeighteChanceLessThanFull)].SetValue<int>(value); } }
        public float AmmoProximityRadius { get { return this[nameof(AmmoProximityRadius)].GetValue<float>(); } set { this[nameof(AmmoProximityRadius)].SetValue<float>(value); } }
    }
    public class UtilityItemInstanceData : ItemInstanceData
    {
        public UtilityItemInstanceData(nint addr) : base(addr) { }
        public byte Charges { get { return this[nameof(Charges)].GetValue<byte>(); } set { this[nameof(Charges)].SetValue<byte>(value); } }
        public float Cooldown { get { return this[nameof(Cooldown)].GetValue<float>(); } set { this[nameof(Cooldown)].SetValue<float>(value); } }
    }
    public class UtilityItem : UseableItem
    {
        public UtilityItem(nint addr) : base(addr) { }
        public byte MaxCharges { get { return this[nameof(MaxCharges)].GetValue<byte>(); } set { this[nameof(MaxCharges)].SetValue<byte>(value); } }
        public float CooldownTime { get { return this[nameof(CooldownTime)].GetValue<float>(); } set { this[nameof(CooldownTime)].SetValue<float>(value); } }
        public void UseCharge() { Invoke(nameof(UseCharge)); }
        public void Recharge() { Invoke(nameof(Recharge)); }
        public byte GetCharges() { return Invoke<byte>(nameof(GetCharges)); }
    }
    public class ExplorableMinimapModelRemnant : ExplorableMinimapModel
    {
        public ExplorableMinimapModelRemnant(nint addr) : base(addr) { }
        public ZoneActor VisitedCoordinatesOwner { get { return this[nameof(VisitedCoordinatesOwner)].As<ZoneActor>(); } set { this["VisitedCoordinatesOwner"] = value; } }
    }
    public class LegacyTraitsComponent : TraitsComponent
    {
        public LegacyTraitsComponent(nint addr) : base(addr) { }
        public ETraitProgressionType ProgressionType { get { return (ETraitProgressionType)this[nameof(ProgressionType)].GetValue<int>(); } set { this[nameof(ProgressionType)].SetValue<int>((int)value); } }
    }
    public class RemnantArchetypeTrait : Archetype
    {
        public RemnantArchetypeTrait(nint addr) : base(addr) { }
        public Object RemnantArchetype { get { return this[nameof(RemnantArchetype)]; } set { this[nameof(RemnantArchetype)] = value; } }
    }
    public class RemnantProgressionComponent : ProgressionComponent
    {
        public RemnantProgressionComponent(nint addr) : base(addr) { }
        public Object OnExperienceGained { get { return this[nameof(OnExperienceGained)]; } set { this[nameof(OnExperienceGained)] = value; } }
    }
    public class RemnantTraitsComponent : TraitsComponent
    {
        public RemnantTraitsComponent(nint addr) : base(addr) { }
        public DataTable ArchetypeNameTable { get { return this[nameof(ArchetypeNameTable)].As<DataTable>(); } set { this["ArchetypeNameTable"] = value; } }
        public bool bUseTypeForSortPriority { get { return this[nameof(bUseTypeForSortPriority)].Flag; } set { this[nameof(bUseTypeForSortPriority)].Flag = value; } }
        public bool bSortPropertyGreatestToLeast { get { return this[nameof(bSortPropertyGreatestToLeast)].Flag; } set { this[nameof(bSortPropertyGreatestToLeast)].Flag = value; } }
        public ETraitSortProperty TraitPropertySort { get { return (ETraitSortProperty)this[nameof(TraitPropertySort)].GetValue<int>(); } set { this[nameof(TraitPropertySort)].SetValue<int>((int)value); } }
        public Object ArchetypeTraitType { get { return this[nameof(ArchetypeTraitType)]; } set { this[nameof(ArchetypeTraitType)] = value; } }
        public Array<TraitSortPriorityField> TraitSortType { get { return new Array<TraitSortPriorityField>(this[nameof(TraitSortType)].Address); } }
        public Array<TraitInfo> CachedSortedTraitList { get { return new Array<TraitInfo>(this[nameof(CachedSortedTraitList)].Address); } }
        public Array<TraitInfo> OwnedArchetypeTraits { get { return new Array<TraitInfo>(this[nameof(OwnedArchetypeTraits)].Address); } }
        public Object ArchetypeAddedTraits { get { return this[nameof(ArchetypeAddedTraits)]; } set { this[nameof(ArchetypeAddedTraits)] = value; } }
        public bool IsInitializing() { return Invoke<bool>(nameof(IsInitializing)); }
        public bool IsEquipmentTrait(TraitInfo TraitInfo) { return Invoke<bool>(nameof(IsEquipmentTrait), TraitInfo); }
        public bool IsArchetypeAppliedTrait(TraitInfo TraitInfo) { return Invoke<bool>(nameof(IsArchetypeAppliedTrait), TraitInfo); }
        public int GetTraitProgress(Object TraitBP) { return Invoke<int>(nameof(GetTraitProgress), TraitBP); }
        public Array<TraitInfo> GetSortedTraitList() { return Invoke<Array<TraitInfo>>(nameof(GetSortedTraitList)); }
        public Array<TraitInfo> GetCustomSortedTraitList(DataTable TraitSortTable) { return Invoke<Array<TraitInfo>>(nameof(GetCustomSortedTraitList), TraitSortTable); }
        public Object GetArchetypeNameForCombo(Object ArchetypeA, Object ArchetypeB) { return Invoke<Object>(nameof(GetArchetypeNameForCombo), ArchetypeA, ArchetypeB); }
        public void CheckOnTraitUpdated(Object TraitBP) { Invoke(nameof(CheckOnTraitUpdated), TraitBP); }
        public void CheckOnTraitRemoved(Object TraitBP) { Invoke(nameof(CheckOnTraitRemoved), TraitBP); }
        public void CheckOnTraitLevelChanged(Object TraitBP, int Level) { Invoke(nameof(CheckOnTraitLevelChanged), TraitBP, Level); }
        public void CheckOnTraitAdded(Object TraitBP) { Invoke(nameof(CheckOnTraitAdded), TraitBP); }
    }
    public class EventRegion : Actor
    {
        public EventRegion(nint addr) : base(addr) { }
        public PersistenceComponent PersistenceComponent { get { return this[nameof(PersistenceComponent)].As<PersistenceComponent>(); } set { this["PersistenceComponent"] = value; } }
        public Object NameID { get { return this[nameof(NameID)]; } set { this[nameof(NameID)] = value; } }
        public MusicSetAsset MusicSet { get { return this[nameof(MusicSet)].As<MusicSetAsset>(); } set { this["MusicSet"] = value; } }
        public EMusicState MusicState { get { return (EMusicState)this[nameof(MusicState)].GetValue<int>(); } set { this[nameof(MusicState)].SetValue<int>((int)value); } }
        public bool AutoStartEvent { get { return this[nameof(AutoStartEvent)].Flag; } set { this[nameof(AutoStartEvent)].Flag = value; } }
        public bool AutoEndEvent { get { return this[nameof(AutoEndEvent)].Flag; } set { this[nameof(AutoEndEvent)].Flag = value; } }
        public bool DisableCommitsWhenActive { get { return this[nameof(DisableCommitsWhenActive)].Flag; } set { this[nameof(DisableCommitsWhenActive)].Flag = value; } }
        public bool StartsActive { get { return this[nameof(StartsActive)].Flag; } set { this[nameof(StartsActive)].Flag = value; } }
        public bool Complete { get { return this[nameof(Complete)].Flag; } set { this[nameof(Complete)].Flag = value; } }
        public bool RegionHasUniqueAggroGroup { get { return this[nameof(RegionHasUniqueAggroGroup)].Flag; } set { this[nameof(RegionHasUniqueAggroGroup)].Flag = value; } }
        public Object OnBegin { get { return this[nameof(OnBegin)]; } set { this[nameof(OnBegin)] = value; } }
        public Object OnEnd { get { return this[nameof(OnEnd)]; } set { this[nameof(OnEnd)] = value; } }
        public Object OnPlayerEnter { get { return this[nameof(OnPlayerEnter)]; } set { this[nameof(OnPlayerEnter)] = value; } }
        public Object OnPlayerExit { get { return this[nameof(OnPlayerExit)]; } set { this[nameof(OnPlayerExit)] = value; } }
        public Object OnPlayerDead { get { return this[nameof(OnPlayerDead)]; } set { this[nameof(OnPlayerDead)] = value; } }
        public Object OnCharacterEnter { get { return this[nameof(OnCharacterEnter)]; } set { this[nameof(OnCharacterEnter)] = value; } }
        public Object OnCharacterExit { get { return this[nameof(OnCharacterExit)]; } set { this[nameof(OnCharacterExit)] = value; } }
        public Object OnCharacterDead { get { return this[nameof(OnCharacterDead)]; } set { this[nameof(OnCharacterDead)] = value; } }
        public Object OnUpdateActiveState { get { return this[nameof(OnUpdateActiveState)]; } set { this[nameof(OnUpdateActiveState)] = value; } }
        public Array<EventRegionCharacter> Characters { get { return new Array<EventRegionCharacter>(this[nameof(Characters)].Address); } }
        public Array<CharacterGunfire> NonPlayerCharacters { get { return new Array<CharacterGunfire>(this[nameof(NonPlayerCharacters)].Address); } }
        public bool Active { get { return this[nameof(Active)].Flag; } set { this[nameof(Active)].Flag = value; } }
        public bool Locked { get { return this[nameof(Locked)].Flag; } set { this[nameof(Locked)].Flag = value; } }
        public Array<PlayerController> Players { get { return new Array<PlayerController>(this[nameof(Players)].Address); } }
        public Array<RemnantQuestComponent> RegisteredRegionComponents { get { return new Array<RemnantQuestComponent>(this[nameof(RegisteredRegionComponents)].Address); } }
        public void PlayerExit(RemnantCharacter Character) { Invoke(nameof(PlayerExit), Character); }
        public void PlayerEnter(RemnantCharacter Character) { Invoke(nameof(PlayerEnter), Character); }
        public void OnRep_Players() { Invoke(nameof(OnRep_Players)); }
        public void OnRep_Active() { Invoke(nameof(OnRep_Active)); }
        public void OnPlayerDead_Internal(byte Reason, CharacterGunfire Character, Actor Cause) { Invoke(nameof(OnPlayerDead_Internal), Reason, Character, Cause); }
        public void OnCharacterDead_Internal(byte Reason, CharacterGunfire Character, Actor Cause) { Invoke(nameof(OnCharacterDead_Internal), Reason, Character, Cause); }
        public void LockEvent() { Invoke(nameof(LockEvent)); }
        public bool IsPlayerInRegion(PlayerController Controller) { return Invoke<bool>(nameof(IsPlayerInRegion), Controller); }
        public bool IsLocked() { return Invoke<bool>(nameof(IsLocked)); }
        public bool IsLocalPlayerInRegion() { return Invoke<bool>(nameof(IsLocalPlayerInRegion)); }
        public bool IsComplete() { return Invoke<bool>(nameof(IsComplete)); }
        public bool IsCharacterInRegion(RemnantCharacter Character) { return Invoke<bool>(nameof(IsCharacterInRegion), Character); }
        public bool IsActive() { return Invoke<bool>(nameof(IsActive)); }
        public bool HasUniqueAggroGroup() { return Invoke<bool>(nameof(HasUniqueAggroGroup)); }
        public bool HasLocalPlayerVisited() { return Invoke<bool>(nameof(HasLocalPlayerVisited)); }
        public Array<CharacterGunfire> GetNonPlayerCharacters() { return Invoke<Array<CharacterGunfire>>(nameof(GetNonPlayerCharacters)); }
        public RemnantCharacter GetFirstCharacter() { return Invoke<RemnantCharacter>(nameof(GetFirstCharacter)); }
        public EventRegion GetEventRegionForActor(Actor Context, Object EventRegionNameID, bool FirstResultFallback) { return Invoke<EventRegion>(nameof(GetEventRegionForActor), Context, EventRegionNameID, FirstResultFallback); }
        public EventRegion GetEventRegionContainingActor(Actor Actor) { return Invoke<EventRegion>(nameof(GetEventRegionContainingActor), Actor); }
        public Array<EventRegionCharacter> GetCharacters() { return Invoke<Array<EventRegionCharacter>>(nameof(GetCharacters)); }
        public void End() { Invoke(nameof(End)); }
        public void CompleteEvent() { Invoke(nameof(CompleteEvent)); }
        public void CharacterExit(CharacterGunfire CharGunfire) { Invoke(nameof(CharacterExit), CharGunfire); }
        public void CharacterEnter(CharacterGunfire CharGunfire) { Invoke(nameof(CharacterEnter), CharGunfire); }
        public void Begin() { Invoke(nameof(Begin)); }
    }
    public class QuestTrigger : Actor
    {
        public QuestTrigger(nint addr) : base(addr) { }
        public TriggerVolume TriggerVolume { get { return this[nameof(TriggerVolume)].As<TriggerVolume>(); } set { this["TriggerVolume"] = value; } }
        public Object NameID { get { return this[nameof(NameID)]; } set { this[nameof(NameID)] = value; } }
        public Object OnPlayerEnter { get { return this[nameof(OnPlayerEnter)]; } set { this[nameof(OnPlayerEnter)] = value; } }
        public Object OnPlayerExit { get { return this[nameof(OnPlayerExit)]; } set { this[nameof(OnPlayerExit)] = value; } }
        public bool bUseManualCollision { get { return this[nameof(bUseManualCollision)].Flag; } set { this[nameof(bUseManualCollision)].Flag = value; } }
        public Array<RemnantCharacter> Characters { get { return new Array<RemnantCharacter>(this[nameof(Characters)].Address); } }
        public bool IsLocalPlayerInRegion() { return Invoke<bool>(nameof(IsLocalPlayerInRegion)); }
        public TriggerVolume GetTriggerVolume() { return Invoke<TriggerVolume>(nameof(GetTriggerVolume)); }
        public Array<RemnantCharacter> GetCharacters() { return Invoke<Array<RemnantCharacter>>(nameof(GetCharacters)); }
        public void EvaluateOverlaps() { Invoke(nameof(EvaluateOverlaps)); }
    }
    public class RemnantQuest : Quest
    {
        public RemnantQuest(nint addr) : base(addr) { }
        public PersistenceComponent PersistenceComponent { get { return this[nameof(PersistenceComponent)].As<PersistenceComponent>(); } set { this["PersistenceComponent"] = value; } }
        public VariableComponent VariableComponent { get { return this[nameof(VariableComponent)].As<VariableComponent>(); } set { this["VariableComponent"] = value; } }
        public ERemnantQuestType Type { get { return (ERemnantQuestType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public ERemnantQuestRarity Rarity { get { return (ERemnantQuestRarity)this[nameof(Rarity)].GetValue<int>(); } set { this[nameof(Rarity)].SetValue<int>((int)value); } }
        public int MaxUsageCount { get { return this[nameof(MaxUsageCount)].GetValue<int>(); } set { this[nameof(MaxUsageCount)].SetValue<int>(value); } }
        public ERemnantQuestDebugState DebugState { get { return (ERemnantQuestDebugState)this[nameof(DebugState)].GetValue<int>(); } set { this[nameof(DebugState)].SetValue<int>((int)value); } }
        public EQuestMode QuestGameMode { get { return (EQuestMode)this[nameof(QuestGameMode)].GetValue<int>(); } set { this[nameof(QuestGameMode)].SetValue<int>((int)value); } }
        public Object RequiredAward { get { return this[nameof(RequiredAward)]; } set { this[nameof(RequiredAward)] = value; } }
        public Array<SpawnTable> ResourceCachedSpawns { get { return new Array<SpawnTable>(this[nameof(ResourceCachedSpawns)].Address); } }
        public Object Container { get { return this[nameof(Container)]; } set { this[nameof(Container)] = value; } }
        public int LevelMin { get { return this[nameof(LevelMin)].GetValue<int>(); } set { this[nameof(LevelMin)].SetValue<int>(value); } }
        public int LevelMax { get { return this[nameof(LevelMax)].GetValue<int>(); } set { this[nameof(LevelMax)].SetValue<int>(value); } }
        public Array<RemnantQuestBreadcrumb> Breadcrumbs { get { return new Array<RemnantQuestBreadcrumb>(this[nameof(Breadcrumbs)].Address); } }
        public int Level { get { return this[nameof(Level)].GetValue<int>(); } set { this[nameof(Level)].SetValue<int>(value); } }
        public int Difficulty { get { return this[nameof(Difficulty)].GetValue<int>(); } set { this[nameof(Difficulty)].SetValue<int>(value); } }
        public Timespan PlayTime { get { return this[nameof(PlayTime)].As<Timespan>(); } set { this["PlayTime"] = value; } }
        public int SlotID { get { return this[nameof(SlotID)].GetValue<int>(); } set { this[nameof(SlotID)].SetValue<int>(value); } }
        public int ZoneID { get { return this[nameof(ZoneID)].GetValue<int>(); } set { this[nameof(ZoneID)].SetValue<int>(value); } }
        public Object BiomeName { get { return this[nameof(BiomeName)]; } set { this[nameof(BiomeName)] = value; } }
        public Object RequiredEntitlement { get { return this[nameof(RequiredEntitlement)]; } set { this[nameof(RequiredEntitlement)] = value; } }
        public bool bDisableMultiplayer { get { return this[nameof(bDisableMultiplayer)].Flag; } set { this[nameof(bDisableMultiplayer)].Flag = value; } }
        public DataTable ItemValueTable { get { return this[nameof(ItemValueTable)].As<DataTable>(); } set { this["ItemValueTable"] = value; } }
        public Object OnCheckpointSet { get { return this[nameof(OnCheckpointSet)]; } set { this[nameof(OnCheckpointSet)] = value; } }
        public Object OnSetRespawn { get { return this[nameof(OnSetRespawn)]; } set { this[nameof(OnSetRespawn)] = value; } }
        public Object OnPreZoneLoaded { get { return this[nameof(OnPreZoneLoaded)]; } set { this[nameof(OnPreZoneLoaded)] = value; } }
        public Object OnQuestLoaded { get { return this[nameof(OnQuestLoaded)]; } set { this[nameof(OnQuestLoaded)] = value; } }
        public Object OnUpdateBreadcrumbs { get { return this[nameof(OnUpdateBreadcrumbs)]; } set { this[nameof(OnUpdateBreadcrumbs)] = value; } }
        public Array<RemnantQuestBreadcrumbInfo> BreadcrumbInfo { get { return new Array<RemnantQuestBreadcrumbInfo>(this[nameof(BreadcrumbInfo)].Address); } }
        public ERemnantQuestStatus Status { get { return (ERemnantQuestStatus)this[nameof(Status)].GetValue<int>(); } set { this[nameof(Status)].SetValue<int>((int)value); } }
        public int LastCheckpointZoneID { get { return this[nameof(LastCheckpointZoneID)].GetValue<int>(); } set { this[nameof(LastCheckpointZoneID)].SetValue<int>(value); } }
        public Object LastCheckpointNameID { get { return this[nameof(LastCheckpointNameID)]; } set { this[nameof(LastCheckpointNameID)] = value; } }
        public int RespawnZoneID { get { return this[nameof(RespawnZoneID)].GetValue<int>(); } set { this[nameof(RespawnZoneID)].SetValue<int>(value); } }
        public Object RespawnLinkNameID { get { return this[nameof(RespawnLinkNameID)]; } set { this[nameof(RespawnLinkNameID)] = value; } }
        public LevelStreaming ContainerLevel { get { return this[nameof(ContainerLevel)].As<LevelStreaming>(); } set { this["ContainerLevel"] = value; } }
        public bool Created { get { return this[nameof(Created)].Flag; } set { this[nameof(Created)].Flag = value; } }
        public Object UsageCount { get { return this[nameof(UsageCount)]; } set { this[nameof(UsageCount)] = value; } }
        public bool ShowQuestBreadcrumbs() { return Invoke<bool>(nameof(ShowQuestBreadcrumbs)); }
        public bool ShouldBreadcrumbForName(Object Objective) { return Invoke<bool>(nameof(ShouldBreadcrumbForName), Objective); }
        public bool ShouldBreadcrumb(ZoneLinkInfo ZoneLink) { return Invoke<bool>(nameof(ShouldBreadcrumb), ZoneLink); }
        public void OnRep_Status() { Invoke(nameof(OnRep_Status)); }
        public void OnRep_BreadcrumbInfo() { Invoke(nameof(OnRep_BreadcrumbInfo)); }
        public void MulticastUnloadContainerLevel() { Invoke(nameof(MulticastUnloadContainerLevel)); }
        public void MulticastSetCheckpoint() { Invoke(nameof(MulticastSetCheckpoint)); }
        public bool IsStaticQuest() { return Invoke<bool>(nameof(IsStaticQuest)); }
        public bool IsRootQuest() { return Invoke<bool>(nameof(IsRootQuest)); }
        public bool IsLoadingOrLoaded() { return Invoke<bool>(nameof(IsLoadingOrLoaded)); }
        public bool IsLoaded() { return Invoke<bool>(nameof(IsLoaded)); }
        public bool HasRespawn() { return Invoke<bool>(nameof(HasRespawn)); }
        public bool HasLastCheckpoint() { return Invoke<bool>(nameof(HasLastCheckpoint)); }
        public bool HasActiveBreadcrumbs() { return Invoke<bool>(nameof(HasActiveBreadcrumbs)); }
        public void GiveRewardToPlayerController(RemnantPlayerController Player, SpawnTable SpawnTable, Object SpawnTag, Array<Object> AdditionalTags, ERemnantQuestRewardType RewardType, int RandomSeed) { Invoke(nameof(GiveRewardToPlayerController), Player, SpawnTable, SpawnTag, AdditionalTags, RewardType, RandomSeed); }
        public void GiveRewardToPlayer(RemnantCharacter Player, SpawnTable SpawnTable, Object SpawnTag, Array<Object> AdditionalTags, ERemnantQuestRewardType RewardType) { Invoke(nameof(GiveRewardToPlayer), Player, SpawnTable, SpawnTag, AdditionalTags, RewardType); }
        public void GiveReward(SpawnTable SpawnTable, Object SpawnTag, Array<Object> AdditionalTags, ERemnantQuestRewardType RewardType) { Invoke(nameof(GiveReward), SpawnTable, SpawnTag, AdditionalTags, RewardType); }
        public void GiveDetailedRewardToPlayerController(RemnantPlayerController Player, SpawnTable SpawnTable, Object SpawnTag, Array<Object> AdditionalTags, RemnantQuestReward Reward, int RandomSeed) { Invoke(nameof(GiveDetailedRewardToPlayerController), Player, SpawnTable, SpawnTag, AdditionalTags, Reward, RandomSeed); }
        public void GiveDetailedReward(SpawnTable SpawnTable, Object SpawnTag, Array<Object> AdditionalTags, RemnantQuestReward Reward) { Invoke(nameof(GiveDetailedReward), SpawnTable, SpawnTag, AdditionalTags, Reward); }
        public ZoneLinkInfo GetRespawn() { return Invoke<ZoneLinkInfo>(nameof(GetRespawn)); }
        public int GetQuestLevel() { return Invoke<int>(nameof(GetQuestLevel)); }
        public InventoryComponent GetQuestInventory() { return Invoke<InventoryComponent>(nameof(GetQuestInventory)); }
        public bool GetObjectQuestValue(Object ObjectBP, int ObjectValue, float OutSellScalar, int OutPickupValue) { return Invoke<bool>(nameof(GetObjectQuestValue), ObjectBP, ObjectValue, OutSellScalar, OutPickupValue); }
        public ZoneLinkInfo GetLastCheckpoint() { return Invoke<ZoneLinkInfo>(nameof(GetLastCheckpoint)); }
        public Object GetBiomeName() { return Invoke<Object>(nameof(GetBiomeName)); }
        public Array<ZoneLinkInfo> GetAutoJoinZoneLinks() { return Invoke<Array<ZoneLinkInfo>>(nameof(GetAutoJoinZoneLinks)); }
        public void EventSetRespawn(ZoneLinkInfo ZoneLink) { Invoke(nameof(EventSetRespawn), ZoneLink); }
        public void EventQuestComplete(Quest Quest, EQuestResult Result) { Invoke(nameof(EventQuestComplete), Quest, Result); }
        public void EventAddItem(Object ItemBP, int Quantity) { Invoke(nameof(EventAddItem), ItemBP, Quantity); }
        public void DeactivateQuest() { Invoke(nameof(DeactivateQuest)); }
        public void CompleteBreadcrumb(Object BreadcrumbNameID) { Invoke(nameof(CompleteBreadcrumb), BreadcrumbNameID); }
        public void ActivateQuest() { Invoke(nameof(ActivateQuest)); }
    }
    public class RemnantQuestComponent : QuestComponent
    {
        public RemnantQuestComponent(nint addr) : base(addr) { }
        public bool IsZoneLoaded() { return Invoke<bool>(nameof(IsZoneLoaded)); }
        public ZoneActor GetZone() { return Invoke<ZoneActor>(nameof(GetZone)); }
        public RemnantQuest GetRemnantQuest() { return Invoke<RemnantQuest>(nameof(GetRemnantQuest)); }
        public RemnantQuestZone GetQuestZone() { return Invoke<RemnantQuestZone>(nameof(GetQuestZone)); }
        public RemnantQuestTile GetQuestTile() { return Invoke<RemnantQuestTile>(nameof(GetQuestTile)); }
        public RemnantQuestEntity GetQuestEntity() { return Invoke<RemnantQuestEntity>(nameof(GetQuestEntity)); }
    }
    public class RemnantQuestAIDirector : RemnantQuestComponent
    {
        public RemnantQuestAIDirector(nint addr) : base(addr) { }
        public Array<EncounterGroup> Groups { get { return new Array<EncounterGroup>(this[nameof(Groups)].Address); } }
        public bool IncludeZoneGroups { get { return this[nameof(IncludeZoneGroups)].Flag; } set { this[nameof(IncludeZoneGroups)].Flag = value; } }
        public Object OnSpawned { get { return this[nameof(OnSpawned)]; } set { this[nameof(OnSpawned)] = value; } }
        public Object OnDestroyed { get { return this[nameof(OnDestroyed)]; } set { this[nameof(OnDestroyed)] = value; } }
        public Object OnAllSpawnsDestroyed { get { return this[nameof(OnAllSpawnsDestroyed)]; } set { this[nameof(OnAllSpawnsDestroyed)] = value; } }
        public Object OnEncounterEvent { get { return this[nameof(OnEncounterEvent)]; } set { this[nameof(OnEncounterEvent)] = value; } }
        public void StopAllGroups(bool DestroyActiveSpawns) { Invoke(nameof(StopAllGroups), DestroyActiveSpawns); }
        public void SetSpawnTable(SpawnTable SpawnTable) { Invoke(nameof(SetSpawnTable), SpawnTable); }
        public void OnEncounterGroupRemoved(EncounterGroupInstance EncounterGroup) { Invoke(nameof(OnEncounterGroupRemoved), EncounterGroup); }
        public void OnEncounterGroupActorSpawned(EncounterGroupInstance EncounterGroup, Actor Actor) { Invoke(nameof(OnEncounterGroupActorSpawned), EncounterGroup, Actor); }
        public void OnEncounterGroupActorDead(EncounterGroupInstance EncounterGroup, Actor Actor) { Invoke(nameof(OnEncounterGroupActorDead), EncounterGroup, Actor); }
        public bool HasActiveSpawns(bool IncludeQueuedSpawns) { return Invoke<bool>(nameof(HasActiveSpawns), IncludeQueuedSpawns); }
        public int GetTotalSpawns(bool IncludeQueuedSpawns) { return Invoke<int>(nameof(GetTotalSpawns), IncludeQueuedSpawns); }
        public void EventPlayerExit(EventRegionCharacter Character) { Invoke(nameof(EventPlayerExit), Character); }
        public void EventPlayerEnter(EventRegionCharacter Character) { Invoke(nameof(EventPlayerEnter), Character); }
        public void EventEncounterEvent(EncounterGroupInstance EncounterGroup, Object EventName) { Invoke(nameof(EventEncounterEvent), EncounterGroup, EventName); }
    }
    public class LootSourceInterface : Interface
    {
        public LootSourceInterface(nint addr) : base(addr) { }
        public void OverrideLootTable(SpawnTable SpawnTable, Array<Object> SpawnTags) { Invoke(nameof(OverrideLootTable), SpawnTable, SpawnTags); }
    }
    public class RemnantQuestEntity : QuestEntity
    {
        public RemnantQuestEntity(nint addr) : base(addr) { }
        public SpawnTable SpawnTable { get { return this[nameof(SpawnTable)].As<SpawnTable>(); } set { this["SpawnTable"] = value; } }
        public Array<Object> SpawnTags { get { return new Array<Object>(this[nameof(SpawnTags)].Address); } }
        public bool Transient { get { return this[nameof(Transient)].Flag; } set { this[nameof(Transient)].Flag = value; } }
        public bool ForceSpawnIfNotFound { get { return this[nameof(ForceSpawnIfNotFound)].Flag; } set { this[nameof(ForceSpawnIfNotFound)].Flag = value; } }
        public bool PersistDestroyed { get { return this[nameof(PersistDestroyed)].Flag; } set { this[nameof(PersistDestroyed)].Flag = value; } }
        public Object ActorNameID { get { return this[nameof(ActorNameID)]; } set { this[nameof(ActorNameID)] = value; } }
        public Array<Object> ActorTags { get { return new Array<Object>(this[nameof(ActorTags)].Address); } }
        public SpawnTable LootSpawnTable { get { return this[nameof(LootSpawnTable)].As<SpawnTable>(); } set { this["LootSpawnTable"] = value; } }
        public Array<Object> LootSpawnTags { get { return new Array<Object>(this[nameof(LootSpawnTags)].Address); } }
        public Object Faction { get { return this[nameof(Faction)]; } set { this[nameof(Faction)] = value; } }
        public Array<Actor> Actors { get { return new Array<Actor>(this[nameof(Actors)].Address); } }
        public Array<RemnantQuestEntityInfo> Spawns { get { return new Array<RemnantQuestEntityInfo>(this[nameof(Spawns)].Address); } }
        public void ZoneUnloaded() { Invoke(nameof(ZoneUnloaded)); }
        public void SetSpawnTable(SpawnTable NewSpawnTable, Array<Object> NewSpawnTags) { Invoke(nameof(SetSpawnTable), NewSpawnTable, NewSpawnTags); }
        public void SetFactionAffiliation(Object TargetFaction, EAffiliation Affiliation, bool Propogate) { Invoke(nameof(SetFactionAffiliation), TargetFaction, Affiliation, Propogate); }
        public void SetFaction(Object NewFaction) { Invoke(nameof(SetFaction), NewFaction); }
        public void ResetSpawns() { Invoke(nameof(ResetSpawns)); }
        public void ReactivateSpawns() { Invoke(nameof(ReactivateSpawns)); }
        public void OnSpawnListLoaded() { Invoke(nameof(OnSpawnListLoaded)); }
        public void OnDead(byte Reason, CharacterGunfire Character, Actor Cause) { Invoke(nameof(OnDead), Reason, Character, Cause); }
        public void OnActorRegistered(Actor Actor) { Invoke(nameof(OnActorRegistered), Actor); }
        public void OnActorDestroyed(Actor Actor) { Invoke(nameof(OnActorDestroyed), Actor); }
        public void OnActorDead(DamageInfo DamageInfo) { Invoke(nameof(OnActorDead), DamageInfo); }
        public ZoneActor GetZone() { return Invoke<ZoneActor>(nameof(GetZone)); }
        public RemnantQuest GetRemnantQuest() { return Invoke<RemnantQuest>(nameof(GetRemnantQuest)); }
        public RemnantQuestZone GetQuestZone() { return Invoke<RemnantQuestZone>(nameof(GetQuestZone)); }
        public RemnantQuestTile GetQuestTile() { return Invoke<RemnantQuestTile>(nameof(GetQuestTile)); }
        public Array<Actor> GetActors() { return Invoke<Array<Actor>>(nameof(GetActors)); }
    }
    public class RemnantQuestEntityDialog : RemnantQuestComponent
    {
        public RemnantQuestEntityDialog(nint addr) : base(addr) { }
        public EventTree Dialog { get { return this[nameof(Dialog)].As<EventTree>(); } set { this["Dialog"] = value; } }
        public void OnActorSpawned(Actor Actor) { Invoke(nameof(OnActorSpawned), Actor); }
    }
    public class RemnantQuestEventRegion : RemnantQuestComponent
    {
        public RemnantQuestEventRegion(nint addr) : base(addr) { }
        public Object EventRegionNameID { get { return this[nameof(EventRegionNameID)]; } set { this[nameof(EventRegionNameID)] = value; } }
        public Object OnBegin { get { return this[nameof(OnBegin)]; } set { this[nameof(OnBegin)] = value; } }
        public Object OnEnd { get { return this[nameof(OnEnd)]; } set { this[nameof(OnEnd)] = value; } }
        public Object OnPlayerEnter { get { return this[nameof(OnPlayerEnter)]; } set { this[nameof(OnPlayerEnter)] = value; } }
        public Object OnPlayerExit { get { return this[nameof(OnPlayerExit)]; } set { this[nameof(OnPlayerExit)] = value; } }
        public MusicSetAsset MusicSet { get { return this[nameof(MusicSet)].As<MusicSetAsset>(); } set { this["MusicSet"] = value; } }
        public bool bOverrideExistingSet { get { return this[nameof(bOverrideExistingSet)].Flag; } set { this[nameof(bOverrideExistingSet)].Flag = value; } }
        public EventRegion EventRegion { get { return this[nameof(EventRegion)].As<EventRegion>(); } set { this["EventRegion"] = value; } }
        public void SetMusicState(EMusicState MusicState) { Invoke(nameof(SetMusicState), MusicState); }
        public void OnNotifyTakeDamage(DamageInfo DamageInfo) { Invoke(nameof(OnNotifyTakeDamage), DamageInfo); }
        public void OnActorRegistered(Actor Actor) { Invoke(nameof(OnActorRegistered), Actor); }
        public void LockEvent() { Invoke(nameof(LockEvent)); }
        public bool IsEventRegionActive() { return Invoke<bool>(nameof(IsEventRegionActive)); }
        public bool IsComplete() { return Invoke<bool>(nameof(IsComplete)); }
        public Array<RemnantCharacter> GetPlayersInRegion() { return Invoke<Array<RemnantCharacter>>(nameof(GetPlayersInRegion)); }
        public int GetNumPlayersInRegion() { return Invoke<int>(nameof(GetNumPlayersInRegion)); }
        public RemnantCharacter GetFirstPlayerInRegion() { return Invoke<RemnantCharacter>(nameof(GetFirstPlayerInRegion)); }
        public EventRegion GetEventRegion() { return Invoke<EventRegion>(nameof(GetEventRegion)); }
        public Object GetAggroGroup() { return Invoke<Object>(nameof(GetAggroGroup)); }
        public void EventPlayerExit(EventRegionCharacter Player) { Invoke(nameof(EventPlayerExit), Player); }
        public void EventPlayerEnter(EventRegionCharacter Player) { Invoke(nameof(EventPlayerEnter), Player); }
        public void EventOnEnd() { Invoke(nameof(EventOnEnd)); }
        public void EventOnBegin() { Invoke(nameof(EventOnBegin)); }
        public void EventCharacterExit(CharacterGunfire Character) { Invoke(nameof(EventCharacterExit), Character); }
        public void EventCharacterEnter(CharacterGunfire Character) { Invoke(nameof(EventCharacterEnter), Character); }
        public void End() { Invoke(nameof(End)); }
        public void CompleteEvent() { Invoke(nameof(CompleteEvent)); }
        public void Begin() { Invoke(nameof(Begin)); }
    }
    public class RemnantQuestLink : RemnantQuestComponent
    {
        public RemnantQuestLink(nint addr) : base(addr) { }
        public Object QuestNameID { get { return this[nameof(QuestNameID)]; } set { this[nameof(QuestNameID)] = value; } }
        public Object ComponentName { get { return this[nameof(ComponentName)]; } set { this[nameof(ComponentName)] = value; } }
        public bool AutoLink { get { return this[nameof(AutoLink)].Flag; } set { this[nameof(AutoLink)].Flag = value; } }
        public Array<Object> QuestTags { get { return new Array<Object>(this[nameof(QuestTags)].Address); } }
        public Array<Object> RequiredSlots { get { return new Array<Object>(this[nameof(RequiredSlots)].Address); } }
        public bool IsMainPath { get { return this[nameof(IsMainPath)].Flag; } set { this[nameof(IsMainPath)].Flag = value; } }
        public bool IsWorldMapLocation { get { return this[nameof(IsWorldMapLocation)].Flag; } set { this[nameof(IsWorldMapLocation)].Flag = value; } }
        public Object WorldMapID { get { return this[nameof(WorldMapID)]; } set { this[nameof(WorldMapID)] = value; } }
        public int AutoLinkQuestID { get { return this[nameof(AutoLinkQuestID)].GetValue<int>(); } set { this[nameof(AutoLinkQuestID)].SetValue<int>(value); } }
        public void OnLinkDeactivated(QuestComponent Component) { Invoke(nameof(OnLinkDeactivated), Component); }
        public void OnLinkActivated(QuestComponent Component) { Invoke(nameof(OnLinkActivated), Component); }
    }
    public class RemnantQuestManager : QuestManager
    {
        public RemnantQuestManager(nint addr) : base(addr) { }
        public Variables RootQuestVariables { get { return this[nameof(RootQuestVariables)].As<Variables>(); } set { this["RootQuestVariables"] = value; } }
        public Object OnQuestLoaded { get { return this[nameof(OnQuestLoaded)]; } set { this[nameof(OnQuestLoaded)] = value; } }
        public Object OnQuestCheckpointSet { get { return this[nameof(OnQuestCheckpointSet)]; } set { this[nameof(OnQuestCheckpointSet)] = value; } }
        public Array<RemnantQuestEntry> RegisteredQuests { get { return new Array<RemnantQuestEntry>(this[nameof(RegisteredQuests)].Address); } }
        public Array<RemnantQuestEntry> SortQuestList(Array<RemnantQuestEntry> QuestList) { return Invoke<Array<RemnantQuestEntry>>(nameof(SortQuestList), QuestList); }
        public bool IsQuestValid(RemnantQuest Quest, Actor Actor) { return Invoke<bool>(nameof(IsQuestValid), Quest, Actor); }
        public Array<RemnantQuest> GetRootQuests() { return Invoke<Array<RemnantQuest>>(nameof(GetRootQuests)); }
        public RemnantQuest GetRootQuestForSlot(int SlotID) { return Invoke<RemnantQuest>(nameof(GetRootQuestForSlot), SlotID); }
        public Array<RemnantQuestEntry> GetRegisteredRootQuestsForMode(EQuestMode Mode) { return Invoke<Array<RemnantQuestEntry>>(nameof(GetRegisteredRootQuestsForMode), Mode); }
        public Array<RemnantQuestEntry> GetRegisteredRootQuests() { return Invoke<Array<RemnantQuestEntry>>(nameof(GetRegisteredRootQuests)); }
        public Array<RemnantQuestEntry> GetRegisteredQuests() { return Invoke<Array<RemnantQuestEntry>>(nameof(GetRegisteredQuests)); }
        public RemnantQuestEntry GetRegisteredQuestByID(Object QuestID) { return Invoke<RemnantQuestEntry>(nameof(GetRegisteredQuestByID), QuestID); }
        public void GetQuestsForActor(Actor Actor, bool IncludeInjectedQuests, Array<RemnantQuest> Rtn) { Invoke(nameof(GetQuestsForActor), Actor, IncludeInjectedQuests, Rtn); }
        public QuestObjective GetCurrentQuestObjective(RemnantQuest Quest) { return Invoke<QuestObjective>(nameof(GetCurrentQuestObjective), Quest); }
        public RemnantQuest GetActiveRootQuest() { return Invoke<RemnantQuest>(nameof(GetActiveRootQuest)); }
        public void DestroyRootQuest(RemnantQuest Quest) { Invoke(nameof(DestroyRootQuest), Quest); }
        public RemnantQuest CreateRootQuest(int SlotID, Object QuestID, int Difficulty) { return Invoke<RemnantQuest>(nameof(CreateRootQuest), SlotID, QuestID, Difficulty); }
        public bool ActivateRootQuest(RemnantQuest Quest) { return Invoke<bool>(nameof(ActivateRootQuest), Quest); }
    }
    public class RemnantQuestSubQuest : RemnantQuestComponent
    {
        public RemnantQuestSubQuest(nint addr) : base(addr) { }
        public Object QuestBP { get { return this[nameof(QuestBP)]; } set { this[nameof(QuestBP)] = value; } }
        public ERemnantQuestType QuestType { get { return (ERemnantQuestType)this[nameof(QuestType)].GetValue<int>(); } set { this[nameof(QuestType)].SetValue<int>((int)value); } }
        public Array<Object> QuestTags { get { return new Array<Object>(this[nameof(QuestTags)].Address); } }
        public float ChanceToSpawn { get { return this[nameof(ChanceToSpawn)].GetValue<float>(); } set { this[nameof(ChanceToSpawn)].SetValue<float>(value); } }
        public bool Optional { get { return this[nameof(Optional)].Flag; } set { this[nameof(Optional)].Flag = value; } }
        public int LevelMin { get { return this[nameof(LevelMin)].GetValue<int>(); } set { this[nameof(LevelMin)].SetValue<int>(value); } }
        public bool LevelRemapping { get { return this[nameof(LevelRemapping)].Flag; } set { this[nameof(LevelRemapping)].Flag = value; } }
        public int LevelRemappingMin { get { return this[nameof(LevelRemappingMin)].GetValue<int>(); } set { this[nameof(LevelRemappingMin)].SetValue<int>(value); } }
        public int LevelRemappingMax { get { return this[nameof(LevelRemappingMax)].GetValue<int>(); } set { this[nameof(LevelRemappingMax)].SetValue<int>(value); } }
        public int QuestID { get { return this[nameof(QuestID)].GetValue<int>(); } set { this[nameof(QuestID)].SetValue<int>(value); } }
        public Object OnSubQuestComplete { get { return this[nameof(OnSubQuestComplete)]; } set { this[nameof(OnSubQuestComplete)] = value; } }
        public Object QuestToSpawn { get { return this[nameof(QuestToSpawn)]; } set { this[nameof(QuestToSpawn)] = value; } }
        public Object CachedQuest { get { return this[nameof(CachedQuest)]; } set { this[nameof(CachedQuest)] = value; } }
        public void SubQuestComplete(Quest Quest, EQuestResult Result) { Invoke(nameof(SubQuestComplete), Quest, Result); }
        public void OnLinkDeactivated(QuestComponent Component) { Invoke(nameof(OnLinkDeactivated), Component); }
        public void OnLinkActivated(QuestComponent Component) { Invoke(nameof(OnLinkActivated), Component); }
        public RemnantQuest GetSubQuest() { return Invoke<RemnantQuest>(nameof(GetSubQuest)); }
    }
    public class RemnantQuestTile : RemnantQuestComponent
    {
        public RemnantQuestTile(nint addr) : base(addr) { }
        public Object TileNameID { get { return this[nameof(TileNameID)]; } set { this[nameof(TileNameID)] = value; } }
        public bool IsWorldMapLocation { get { return this[nameof(IsWorldMapLocation)].Flag; } set { this[nameof(IsWorldMapLocation)].Flag = value; } }
        public Object WorldMapID { get { return this[nameof(WorldMapID)]; } set { this[nameof(WorldMapID)] = value; } }
        public bool IsMainPath { get { return this[nameof(IsMainPath)].Flag; } set { this[nameof(IsMainPath)].Flag = value; } }
        public Array<Object> TileTags { get { return new Array<Object>(this[nameof(TileTags)].Address); } }
        public Array<QuestTileDependency> TileDependencies { get { return new Array<QuestTileDependency>(this[nameof(TileDependencies)].Address); } }
        public bool Exclusive { get { return this[nameof(Exclusive)].Flag; } set { this[nameof(Exclusive)].Flag = value; } }
        public Object OverrideTileTag { get { return this[nameof(OverrideTileTag)]; } set { this[nameof(OverrideTileTag)] = value; } }
        public Array<TileSpawnList> OverrideSpawnLists { get { return new Array<TileSpawnList>(this[nameof(OverrideSpawnLists)].Address); } }
        public byte OverrideFlags { get { return this[nameof(OverrideFlags)].GetValue<byte>(); } set { this[nameof(OverrideFlags)].SetValue<byte>(value); } }
        public int TileID { get { return this[nameof(TileID)].GetValue<int>(); } set { this[nameof(TileID)].SetValue<int>(value); } }
        public Object OnSetTileActive { get { return this[nameof(OnSetTileActive)]; } set { this[nameof(OnSetTileActive)] = value; } }
        public void SetTileActive(int ID, bool Active) { Invoke(nameof(SetTileActive), ID, Active); }
        public Actor GetZoneLink(Object ZoneLinkNameID) { return Invoke<Actor>(nameof(GetZoneLink), ZoneLinkNameID); }
        public bool GetTileAttribute(Object Key, MapGenAttribute Out) { return Invoke<bool>(nameof(GetTileAttribute), Key, Out); }
    }
    public class RemnantQuestTrigger : RemnantQuestComponent
    {
        public RemnantQuestTrigger(nint addr) : base(addr) { }
        public Object TriggerNameID { get { return this[nameof(TriggerNameID)]; } set { this[nameof(TriggerNameID)] = value; } }
        public Object OnPlayerEnter { get { return this[nameof(OnPlayerEnter)]; } set { this[nameof(OnPlayerEnter)] = value; } }
        public Object OnPlayerExit { get { return this[nameof(OnPlayerExit)]; } set { this[nameof(OnPlayerExit)] = value; } }
        public QuestTrigger Trigger { get { return this[nameof(Trigger)].As<QuestTrigger>(); } set { this["Trigger"] = value; } }
        public void OnActorRegistered(Actor Actor) { Invoke(nameof(OnActorRegistered), Actor); }
        public QuestTrigger GetTrigger() { return Invoke<QuestTrigger>(nameof(GetTrigger)); }
        public Array<RemnantCharacter> GetPlayersInTrigger() { return Invoke<Array<RemnantCharacter>>(nameof(GetPlayersInTrigger)); }
        public int GetNumPlayersInTrigger() { return Invoke<int>(nameof(GetNumPlayersInTrigger)); }
        public void EventPlayerExit(RemnantCharacter Player) { Invoke(nameof(EventPlayerExit), Player); }
        public void EventPlayerEnter(RemnantCharacter Player) { Invoke(nameof(EventPlayerEnter), Player); }
    }
    public class RemnantQuestWaveEncounter : RemnantQuestComponent
    {
        public RemnantQuestWaveEncounter(nint addr) : base(addr) { }
        public SpawnTable SpawnTable { get { return this[nameof(SpawnTable)].As<SpawnTable>(); } set { this["SpawnTable"] = value; } }
        public Array<EncounterWave> Waves { get { return new Array<EncounterWave>(this[nameof(Waves)].Address); } }
        public Object OnWaveComplete { get { return this[nameof(OnWaveComplete)]; } set { this[nameof(OnWaveComplete)] = value; } }
        public Object OnAllWavesComplete { get { return this[nameof(OnAllWavesComplete)]; } set { this[nameof(OnAllWavesComplete)] = value; } }
        public Actor EncounterTarget { get { return this[nameof(EncounterTarget)].As<Actor>(); } set { this["EncounterTarget"] = value; } }
        public EventRegion EventRegion { get { return this[nameof(EventRegion)].As<EventRegion>(); } set { this["EventRegion"] = value; } }
        public EncounterInstance EncounterInstance { get { return this[nameof(EncounterInstance)].As<EncounterInstance>(); } set { this["EncounterInstance"] = value; } }
        public void WaveComplete(EncounterInstance Instance) { Invoke(nameof(WaveComplete), Instance); }
        public void Stop(bool DestroyActiveSpawns) { Invoke(nameof(Stop), DestroyActiveSpawns); }
        public void SpawnWave() { Invoke(nameof(SpawnWave)); }
        public void Resume() { Invoke(nameof(Resume)); }
        public void Pause() { Invoke(nameof(Pause)); }
        public bool IsQuestWaveActive() { return Invoke<bool>(nameof(IsQuestWaveActive)); }
        public void EventPlayerExit(EventRegionCharacter Character) { Invoke(nameof(EventPlayerExit), Character); }
        public void EventPlayerEnter(EventRegionCharacter Character) { Invoke(nameof(EventPlayerEnter), Character); }
        public void EventOnEnd() { Invoke(nameof(EventOnEnd)); }
        public void Begin(Actor Target) { Invoke(nameof(Begin), Target); }
    }
    public class RemnantQuestZone : RemnantQuestComponent
    {
        public RemnantQuestZone(nint addr) : base(addr) { }
        public Object Label { get { return this[nameof(Label)]; } set { this[nameof(Label)] = value; } }
        public Object Image { get { return this[nameof(Image)]; } set { this[nameof(Image)] = value; } }
        public Object ZoneDef { get { return this[nameof(ZoneDef)]; } set { this[nameof(ZoneDef)] = value; } }
        public bool Static { get { return this[nameof(Static)].Flag; } set { this[nameof(Static)].Flag = value; } }
        public int RequestedID { get { return this[nameof(RequestedID)].GetValue<int>(); } set { this[nameof(RequestedID)].SetValue<int>(value); } }
        public bool bForceLevelOffset { get { return this[nameof(bForceLevelOffset)].Flag; } set { this[nameof(bForceLevelOffset)].Flag = value; } }
        public Vector ForceLevelOffset { get { return this[nameof(ForceLevelOffset)].As<Vector>(); } set { this["ForceLevelOffset"] = value; } }
        public Array<Object> MapTemplates { get { return new Array<Object>(this[nameof(MapTemplates)].Address); } }
        public TileSet TileSet { get { return this[nameof(TileSet)].As<TileSet>(); } set { this["TileSet"] = value; } }
        public Array<TileSpawnList> SpawnLists { get { return new Array<TileSpawnList>(this[nameof(SpawnLists)].Address); } }
        public Object SkyBox { get { return this[nameof(SkyBox)]; } set { this[nameof(SkyBox)] = value; } }
        public Array<MapGenAttribute> Attributes { get { return new Array<MapGenAttribute>(this[nameof(Attributes)].Address); } }
        public Object ThemeTag { get { return this[nameof(ThemeTag)]; } set { this[nameof(ThemeTag)] = value; } }
        public int LevelMin { get { return this[nameof(LevelMin)].GetValue<int>(); } set { this[nameof(LevelMin)].SetValue<int>(value); } }
        public Array<Object> Slots { get { return new Array<Object>(this[nameof(Slots)].Address); } }
        public Object OnZoneLoaded { get { return this[nameof(OnZoneLoaded)]; } set { this[nameof(OnZoneLoaded)] = value; } }
        public Object OnPreZoneUnloaded { get { return this[nameof(OnPreZoneUnloaded)]; } set { this[nameof(OnPreZoneUnloaded)] = value; } }
        public Object OnZoneUnloaded { get { return this[nameof(OnZoneUnloaded)]; } set { this[nameof(OnZoneUnloaded)] = value; } }
        public Object OnPlayerEnteredZone { get { return this[nameof(OnPlayerEnteredZone)]; } set { this[nameof(OnPlayerEnteredZone)] = value; } }
        public Object OnPlayerExitedZone { get { return this[nameof(OnPlayerExitedZone)]; } set { this[nameof(OnPlayerExitedZone)] = value; } }
        public Array<RemnantQuestTile> QuestTiles { get { return new Array<RemnantQuestTile>(this[nameof(QuestTiles)].Address); } }
        public bool OwnsZone { get { return this[nameof(OwnsZone)].Flag; } set { this[nameof(OwnsZone)].Flag = value; } }
        public int ZoneID { get { return this[nameof(ZoneID)].GetValue<int>(); } set { this[nameof(ZoneID)].SetValue<int>(value); } }
        public bool AssetsGathered { get { return this[nameof(AssetsGathered)].Flag; } set { this[nameof(AssetsGathered)].Flag = value; } }
        public void ZoneUnloaded() { Invoke(nameof(ZoneUnloaded)); }
        public void ZoneLoaded() { Invoke(nameof(ZoneLoaded)); }
        public void TravelToParent() { Invoke(nameof(TravelToParent)); }
        public void SetSpawnTableOverride(SpawnTable SpawnTable) { Invoke(nameof(SetSpawnTableOverride), SpawnTable); }
        public void PreZoneLoaded() { Invoke(nameof(PreZoneLoaded)); }
        public void PlayerExitedZone(PlayerController Controller) { Invoke(nameof(PlayerExitedZone), Controller); }
        public void PlayerEnteredZone(PlayerController Controller) { Invoke(nameof(PlayerEnteredZone), Controller); }
        public void ParentMapLoaded() { Invoke(nameof(ParentMapLoaded)); }
        public void MapLoaded() { Invoke(nameof(MapLoaded)); }
    }
    public class RemnantQuestZoneLink : RemnantQuestComponent
    {
        public RemnantQuestZoneLink(nint addr) : base(addr) { }
        public EZoneLinkType Type { get { return (EZoneLinkType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public Object ZoneLinkNameID { get { return this[nameof(ZoneLinkNameID)]; } set { this[nameof(ZoneLinkNameID)] = value; } }
        public Object Destination { get { return this[nameof(Destination)]; } set { this[nameof(Destination)] = value; } }
        public bool StartsActive { get { return this[nameof(StartsActive)].Flag; } set { this[nameof(StartsActive)].Flag = value; } }
        public bool CanBeRespawnLink { get { return this[nameof(CanBeRespawnLink)].Flag; } set { this[nameof(CanBeRespawnLink)].Flag = value; } }
        public bool IsMainPath { get { return this[nameof(IsMainPath)].Flag; } set { this[nameof(IsMainPath)].Flag = value; } }
        public Object WorldMapID { get { return this[nameof(WorldMapID)]; } set { this[nameof(WorldMapID)] = value; } }
        public Object WaypointBP { get { return this[nameof(WaypointBP)]; } set { this[nameof(WaypointBP)] = value; } }
        public Object WaypointSpawnPointTag { get { return this[nameof(WaypointSpawnPointTag)]; } set { this[nameof(WaypointSpawnPointTag)] = value; } }
        public Object Category { get { return this[nameof(Category)]; } set { this[nameof(Category)] = value; } }
        public Object Label { get { return this[nameof(Label)]; } set { this[nameof(Label)] = value; } }
        public Object Image { get { return this[nameof(Image)]; } set { this[nameof(Image)] = value; } }
        public bool OwnsLink { get { return this[nameof(OwnsLink)].Flag; } set { this[nameof(OwnsLink)].Flag = value; } }
        public void TravelTo() { Invoke(nameof(TravelTo)); }
        public void SetWaypointDisabled(bool Disabled) { Invoke(nameof(SetWaypointDisabled), Disabled); }
        public void SetAsCheckpoint() { Invoke(nameof(SetAsCheckpoint)); }
        public void MulticastSetLinkDisabled(ZoneActor Zone, bool Disabled) { Invoke(nameof(MulticastSetLinkDisabled), Zone, Disabled); }
        public void MulticastSetLinkActive(ZoneActor Zone, bool Active) { Invoke(nameof(MulticastSetLinkActive), Zone, Active); }
        public void MapLoaded() { Invoke(nameof(MapLoaded)); }
        public Array<ZoneLinkInfo> GetWaypointsForMapLocation(Quest Quest, Object InWorldMapID) { return Invoke<Array<ZoneLinkInfo>>(nameof(GetWaypointsForMapLocation), Quest, InWorldMapID); }
        public void DestinationZoneLoaded() { Invoke(nameof(DestinationZoneLoaded)); }
        public void DestinationMapLoaded() { Invoke(nameof(DestinationMapLoaded)); }
        public void DeactivateWaypoint() { Invoke(nameof(DeactivateWaypoint)); }
        public void ActivateWaypoint(bool SetAsRespawnPoint) { Invoke(nameof(ActivateWaypoint), SetAsRespawnPoint); }
    }
    public class SpawnTableChallenge : SpawnTableEntry
    {
        public SpawnTableChallenge(nint addr) : base(addr) { }
        public ChallengeEvent Challenge { get { return this[nameof(Challenge)].As<ChallengeEvent>(); } set { this["Challenge"] = value; } }
    }
    public class SpawnTableExperience : SpawnTableEntry
    {
        public SpawnTableExperience(nint addr) : base(addr) { }
        public int ExperienceMin { get { return this[nameof(ExperienceMin)].GetValue<int>(); } set { this[nameof(ExperienceMin)].SetValue<int>(value); } }
        public int ExperienceMax { get { return this[nameof(ExperienceMax)].GetValue<int>(); } set { this[nameof(ExperienceMax)].SetValue<int>(value); } }
        public int ExperienceIncPerLevel { get { return this[nameof(ExperienceIncPerLevel)].GetValue<int>(); } set { this[nameof(ExperienceIncPerLevel)].SetValue<int>(value); } }
        public float ExperienceExpPerLevel { get { return this[nameof(ExperienceExpPerLevel)].GetValue<float>(); } set { this[nameof(ExperienceExpPerLevel)].SetValue<float>(value); } }
    }
    public class SpawnTableTrait : SpawnTableEntry
    {
        public SpawnTableTrait(nint addr) : base(addr) { }
        public Object TraitBP { get { return this[nameof(TraitBP)]; } set { this[nameof(TraitBP)] = value; } }
    }
    public class AccountAwardRecipe : CraftingRecipe_Base
    {
        public AccountAwardRecipe(nint addr) : base(addr) { }
        public Object Award { get { return this[nameof(Award)]; } set { this[nameof(Award)] = value; } }
    }
    public class QuestItemAwardRecipe : CraftingRecipe_Base
    {
        public QuestItemAwardRecipe(nint addr) : base(addr) { }
        public Object Award { get { return this[nameof(Award)]; } set { this[nameof(Award)] = value; } }
        public ERemnantQuestRewardType RewardType { get { return (ERemnantQuestRewardType)this[nameof(RewardType)].GetValue<int>(); } set { this[nameof(RewardType)].SetValue<int>((int)value); } }
        public int AwardLevel { get { return this[nameof(AwardLevel)].GetValue<int>(); } set { this[nameof(AwardLevel)].SetValue<int>(value); } }
        public int AwardQuantity { get { return this[nameof(AwardQuantity)].GetValue<int>(); } set { this[nameof(AwardQuantity)].SetValue<int>(value); } }
        public bool bAutoEquip { get { return this[nameof(bAutoEquip)].Flag; } set { this[nameof(bAutoEquip)].Flag = value; } }
        public bool bSkipDuplicates { get { return this[nameof(bSkipDuplicates)].Flag; } set { this[nameof(bSkipDuplicates)].Flag = value; } }
        public bool bWantsSaveOnAward { get { return this[nameof(bWantsSaveOnAward)].Flag; } set { this[nameof(bWantsSaveOnAward)].Flag = value; } }
    }
    public class RemnantArchetype : Object
    {
        public RemnantArchetype(nint addr) : base(addr) { }
        public Object Label { get { return this[nameof(Label)]; } set { this[nameof(Label)] = value; } }
        public Object NameID { get { return this[nameof(NameID)]; } set { this[nameof(NameID)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public Object BriefDescription { get { return this[nameof(BriefDescription)]; } set { this[nameof(BriefDescription)] = value; } }
        public Array<Object> FlavorTags { get { return new Array<Object>(this[nameof(FlavorTags)].Address); } }
        public int Difficulty { get { return this[nameof(Difficulty)].GetValue<int>(); } set { this[nameof(Difficulty)].SetValue<int>(value); } }
        public Texture2D Image { get { return this[nameof(Image)].As<Texture2D>(); } set { this["Image"] = value; } }
        public Object Archetype { get { return this[nameof(Archetype)]; } set { this[nameof(Archetype)] = value; } }
        public Object Engram { get { return this[nameof(Engram)]; } set { this[nameof(Engram)] = value; } }
        public Array<Object> StartingGear { get { return new Array<Object>(this[nameof(StartingGear)].Address); } }
        public Array<ArchetypeStartingTrait> StartingTraits { get { return new Array<ArchetypeStartingTrait>(this[nameof(StartingTraits)].Address); } }
        public Array<Object> UITags { get { return new Array<Object>(this[nameof(UITags)].Address); } }
        public Object GetEngramItem(Object ArchetypeSoft) { return Invoke<Object>(nameof(GetEngramItem), ArchetypeSoft); }
        public Object GetArchetypeTrait(Object ArchetypeSoft) { return Invoke<Object>(nameof(GetArchetypeTrait), ArchetypeSoft); }
    }
    public class RemnantAssetManagerSettings : Object
    {
        public RemnantAssetManagerSettings(nint addr) : base(addr) { }
        public Array<AssetPackageRedirection> AssetPakRedirection { get { return new Array<AssetPackageRedirection>(this[nameof(AssetPakRedirection)].Address); } }
        public Object AssetsToIgnoreFile { get { return this[nameof(AssetsToIgnoreFile)]; } set { this[nameof(AssetsToIgnoreFile)] = value; } }
    }
    public class RemnantAssetManager : AssetManager
    {
        public RemnantAssetManager(nint addr) : base(addr) { }
    }
    public class RemnantCharacter : PlayerGunfire
    {
        public RemnantCharacter(nint addr) : base(addr) { }
        public ActorCustomizationComponent Customization { get { return this[nameof(Customization)].As<ActorCustomizationComponent>(); } set { this["Customization"] = value; } }
        public RemnantPlayerInventoryComponent Inventory { get { return this[nameof(Inventory)].As<RemnantPlayerInventoryComponent>(); } set { this["Inventory"] = value; } }
        public EmotesComponent Emotes { get { return this[nameof(Emotes)].As<EmotesComponent>(); } set { this["Emotes"] = value; } }
        public Object FemaleAnimInstanceClass { get { return this[nameof(FemaleAnimInstanceClass)]; } set { this[nameof(FemaleAnimInstanceClass)] = value; } }
        public SkeletalMesh FemaleSkeletalMesh { get { return this[nameof(FemaleSkeletalMesh)].As<SkeletalMesh>(); } set { this["FemaleSkeletalMesh"] = value; } }
        public ActorCustomizationSet FemaleCustomizationSet { get { return this[nameof(FemaleCustomizationSet)].As<ActorCustomizationSet>(); } set { this["FemaleCustomizationSet"] = value; } }
        public EGender Gender { get { return (EGender)this[nameof(Gender)].GetValue<int>(); } set { this[nameof(Gender)].SetValue<int>((int)value); } }
        public Object OnPossessedBy { get { return this[nameof(OnPossessedBy)]; } set { this[nameof(OnPossessedBy)] = value; } }
        public bool bHasAggro { get { return this[nameof(bHasAggro)].Flag; } set { this[nameof(bHasAggro)].Flag = value; } }
        public Array<CharacterGunfire> ProxyAggroCharacters { get { return new Array<CharacterGunfire>(this[nameof(ProxyAggroCharacters)].Address); } }
        public int ControllerIndex { get { return this[nameof(ControllerIndex)].GetValue<int>(); } set { this[nameof(ControllerIndex)].SetValue<int>(value); } }
        public int LastUsedItemId { get { return this[nameof(LastUsedItemId)].GetValue<int>(); } set { this[nameof(LastUsedItemId)].SetValue<int>(value); } }
        public Object CurrentPlayerInfoTag { get { return this[nameof(CurrentPlayerInfoTag)]; } set { this[nameof(CurrentPlayerInfoTag)] = value; } }
        public Object CurrentPlayerGenderTag { get { return this[nameof(CurrentPlayerGenderTag)]; } set { this[nameof(CurrentPlayerGenderTag)] = value; } }
        public bool ShowHelmet { get { return this[nameof(ShowHelmet)].Flag; } set { this[nameof(ShowHelmet)].Flag = value; } }
        public Object HelmetSlot { get { return this[nameof(HelmetSlot)]; } set { this[nameof(HelmetSlot)] = value; } }
        public Object ShowHelmetOption { get { return this[nameof(ShowHelmetOption)]; } set { this[nameof(ShowHelmetOption)] = value; } }
        public Checkpoint GrabbedCheckpoint { get { return this[nameof(GrabbedCheckpoint)].As<Checkpoint>(); } set { this["GrabbedCheckpoint"] = value; } }
        public Object PrimaryWeaponType { get { return this[nameof(PrimaryWeaponType)]; } set { this[nameof(PrimaryWeaponType)] = value; } }
        public float ObstructedAdditionalDistance { get { return this[nameof(ObstructedAdditionalDistance)].GetValue<float>(); } set { this[nameof(ObstructedAdditionalDistance)].SetValue<float>(value); } }
        public float ObstructedAdditionalRadius { get { return this[nameof(ObstructedAdditionalRadius)].GetValue<float>(); } set { this[nameof(ObstructedAdditionalRadius)].SetValue<float>(value); } }
        public GunObstructionParameters StandingParameters { get { return this[nameof(StandingParameters)].As<GunObstructionParameters>(); } set { this["StandingParameters"] = value; } }
        public GunObstructionParameters StandingExtentParameters { get { return this[nameof(StandingExtentParameters)].As<GunObstructionParameters>(); } set { this["StandingExtentParameters"] = value; } }
        public GunObstructionParameters CrouchingParameters { get { return this[nameof(CrouchingParameters)].As<GunObstructionParameters>(); } set { this["CrouchingParameters"] = value; } }
        public GunObstructionParameters CrouchExtentParameters { get { return this[nameof(CrouchExtentParameters)].As<GunObstructionParameters>(); } set { this["CrouchExtentParameters"] = value; } }
        public Object OnAimChange { get { return this[nameof(OnAimChange)]; } set { this[nameof(OnAimChange)] = value; } }
        public Object OnAggroChanged { get { return this[nameof(OnAggroChanged)]; } set { this[nameof(OnAggroChanged)] = value; } }
        public bool bDeactivated { get { return this[nameof(bDeactivated)].Flag; } set { this[nameof(bDeactivated)].Flag = value; } }
        public Array<PersistentBuff> PersistentBuffs { get { return new Array<PersistentBuff>(this[nameof(PersistentBuffs)].Address); } }
        public bool bOnlyExitDialogFromHostileDamage { get { return this[nameof(bOnlyExitDialogFromHostileDamage)].Flag; } set { this[nameof(bOnlyExitDialogFromHostileDamage)].Flag = value; } }
        public bool bManualIgnoreDamageExitingDialog { get { return this[nameof(bManualIgnoreDamageExitingDialog)].Flag; } set { this[nameof(bManualIgnoreDamageExitingDialog)].Flag = value; } }
        public Array<Object> ExitDialogDamageClasses { get { return new Array<Object>(this[nameof(ExitDialogDamageClasses)].Address); } }
        public void UpdatePlayerInfoTags() { Invoke(nameof(UpdatePlayerInfoTags)); }
        public void UpdatePersistentBuffs() { Invoke(nameof(UpdatePersistentBuffs)); }
        public void TeleportToSpawnPoint(Actor SpawnPoint) { Invoke(nameof(TeleportToSpawnPoint), SpawnPoint); }
        public void SetSpawnPoint(SpawnPoint SpawnPoint) { Invoke(nameof(SetSpawnPoint), SpawnPoint); }
        public void SetHelmetShown(bool bShow) { Invoke(nameof(SetHelmetShown), bShow); }
        public void SetGrabbedCheckpoint(Checkpoint NewCheckpoint) { Invoke(nameof(SetGrabbedCheckpoint), NewCheckpoint); }
        public void SetDeactivated() { Invoke(nameof(SetDeactivated)); }
        public void ServerSetHelmetShown(bool bShow) { Invoke(nameof(ServerSetHelmetShown), bShow); }
        public void ResetAmmoInClip() { Invoke(nameof(ResetAmmoInClip)); }
        public int RequestPowerLevel() { return Invoke<int>(nameof(RequestPowerLevel)); }
        public int RequestArchetypeLevel() { return Invoke<int>(nameof(RequestArchetypeLevel)); }
        public void RemovePersistentBuff(ActionBuff Buff) { Invoke(nameof(RemovePersistentBuff), Buff); }
        public void RemoveAggroProxyCharacter(CharacterGunfire Character) { Invoke(nameof(RemoveAggroProxyCharacter), Character); }
        public void OnShowHelmetOptionChanged(UserSetting AppliedSetting, GameUserSettingsGunfire UserSettings) { Invoke(nameof(OnShowHelmetOptionChanged), AppliedSetting, UserSettings); }
        public void OnRespawnAfterDeath() { Invoke(nameof(OnRespawnAfterDeath)); }
        public void OnRep_ShowHelmet() { Invoke(nameof(OnRep_ShowHelmet)); }
        public void OnRep_GrabbedCheckpoint(Checkpoint Previous) { Invoke(nameof(OnRep_GrabbedCheckpoint), Previous); }
        public void OnRep_Deactivated() { Invoke(nameof(OnRep_Deactivated)); }
        public void OnCharacterDied(byte Reason, CharacterGunfire Character, Actor Cause) { Invoke(nameof(OnCharacterDied), Reason, Character, Cause); }
        public bool IsReviving() { return Invoke<bool>(nameof(IsReviving)); }
        public bool IsDead() { return Invoke<bool>(nameof(IsDead)); }
        public void InitializePersistentBuffs() { Invoke(nameof(InitializePersistentBuffs)); }
        public bool HasUnlockedSecondaryArchetype() { return Invoke<bool>(nameof(HasUnlockedSecondaryArchetype)); }
        public RangedWeapon GetCurrentRangedWeapon() { return Invoke<RangedWeapon>(nameof(GetCurrentRangedWeapon)); }
        public SavedCharacter GetCharacterInfo() { return Invoke<SavedCharacter>(nameof(GetCharacterInfo)); }
        public int GetAge() { return Invoke<int>(nameof(GetAge)); }
        public int ComputePowerLevel() { return Invoke<int>(nameof(ComputePowerLevel)); }
        public int ComputeOffenseLevel() { return Invoke<int>(nameof(ComputeOffenseLevel)); }
        public int ComputeItemLevel() { return Invoke<int>(nameof(ComputeItemLevel)); }
        public int ComputeEquipmentLevel(Object Tag, int HighestItemLevelWeight) { return Invoke<int>(nameof(ComputeEquipmentLevel), Tag, HighestItemLevelWeight); }
        public int ComputeDefenseLevel() { return Invoke<int>(nameof(ComputeDefenseLevel)); }
        public int ComputeArchetypeLevel() { return Invoke<int>(nameof(ComputeArchetypeLevel)); }
        public void ClientTeleportToSpawnPoint(SpawnPoint SpawnPoint) { Invoke(nameof(ClientTeleportToSpawnPoint), SpawnPoint); }
        public void ClientTeleport(Transform Transform) { Invoke(nameof(ClientTeleport), Transform); }
        public void ClientSetSpawnPoint(PersistenceKey SpawnPointID) { Invoke(nameof(ClientSetSpawnPoint), SpawnPointID); }
        public void ClientRemoveAllPings() { Invoke(nameof(ClientRemoveAllPings)); }
        public void BroadcastAimEvent(bool Aiming) { Invoke(nameof(BroadcastAimEvent), Aiming); }
        public void AddOrUpdatePersistentBuff(ActionBuff Buff) { Invoke(nameof(AddOrUpdatePersistentBuff), Buff); }
        public void AddAggroProxyCharacter(CharacterGunfire Character) { Invoke(nameof(AddAggroProxyCharacter), Character); }
    }
    public class RemnantCheatManager : CheatManagerGunfire
    {
        public RemnantCheatManager(nint addr) : base(addr) { }
        public void UnlockAllWaypoints() { Invoke(nameof(UnlockAllWaypoints)); }
        public void UnlockAllEmotes() { Invoke(nameof(UnlockAllEmotes)); }
        public void TravelToQuest(Object QuestName, Object ComponentName) { Invoke(nameof(TravelToQuest), QuestName, ComponentName); }
        public void ToggleMinimap() { Invoke(nameof(ToggleMinimap)); }
        public void ToggleFogOfWar() { Invoke(nameof(ToggleFogOfWar)); }
        public void SpawnDebugQuest(Object NameOfBP, Object StartPoint) { Invoke(nameof(SpawnDebugQuest), NameOfBP, StartPoint); }
        public void SetQuestState(Object NameOfQuest, int QuestState, int QuestOutcome) { Invoke(nameof(SetQuestState), NameOfQuest, QuestState, QuestOutcome); }
        public void SetDifficulty(int Difficulty) { Invoke(nameof(SetDifficulty), Difficulty); }
        public void SetArchetype(Object NameOfBP, int ArchetypeLevel, int GearLevel, int Slot) { Invoke(nameof(SetArchetype), NameOfBP, ArchetypeLevel, GearLevel, Slot); }
        public void RaiseDifficulty() { Invoke(nameof(RaiseDifficulty)); }
        public void LowerDifficulty() { Invoke(nameof(LowerDifficulty)); }
        public bool IsSettingArchetypeFromCheat(Object WorldContextObject) { return Invoke<bool>(nameof(IsSettingArchetypeFromCheat), WorldContextObject); }
        public void GiveAccountAward(Object NameOfBP) { Invoke(nameof(GiveAccountAward), NameOfBP); }
        public void AddScrap(int Amount) { Invoke(nameof(AddScrap), Amount); }
        public void AddExperience(int Amount) { Invoke(nameof(AddExperience), Amount); }
    }
    public class RemnantDifficultyScalingComponent : DifficultyScalingComponent
    {
        public RemnantDifficultyScalingComponent(nint addr) : base(addr) { }
    }
    public class RemnantGameInstance : GameInstanceGunfire
    {
        public RemnantGameInstance(nint addr) : base(addr) { }
        public RemnantCharacterManager CharacterManager { get { return this[nameof(CharacterManager)].As<RemnantCharacterManager>(); } set { this["CharacterManager"] = value; } }
        public void SetInFullscreenDialog(bool InDialog) { Invoke(nameof(SetInFullscreenDialog), InDialog); }
        public void OnOnlinePrivilegeChecked() { Invoke(nameof(OnOnlinePrivilegeChecked)); }
        public void OnMainMenuLoaded() { Invoke(nameof(OnMainMenuLoaded)); }
        public void OnDeviceChanged(int ControllerId, EInputDevice NewDevice) { Invoke(nameof(OnDeviceChanged), ControllerId, NewDevice); }
        public void OnActiveProfileSet() { Invoke(nameof(OnActiveProfileSet)); }
        public bool IsDemo() { return Invoke<bool>(nameof(IsDemo)); }
        public void Host() { Invoke(nameof(Host)); }
        public ERemnantDemoMode GetDemoMode() { return Invoke<ERemnantDemoMode>(nameof(GetDemoMode)); }
        public void DoAuth() { Invoke(nameof(DoAuth)); }
        public void CheckConnectionStatusChanges() { Invoke(nameof(CheckConnectionStatusChanges)); }
    }
    public class RemnantGameMode : GameModeGunfire
    {
        public RemnantGameMode(nint addr) : base(addr) { }
        public Object BaseQuest { get { return this[nameof(BaseQuest)]; } set { this[nameof(BaseQuest)] = value; } }
        public Object AutoLoadQuest { get { return this[nameof(AutoLoadQuest)]; } set { this[nameof(AutoLoadQuest)] = value; } }
        public Object DebugQuest { get { return this[nameof(DebugQuest)]; } set { this[nameof(DebugQuest)] = value; } }
        public Object DebugWaypointBP { get { return this[nameof(DebugWaypointBP)]; } set { this[nameof(DebugWaypointBP)] = value; } }
        public bool DebugWithoutZone { get { return this[nameof(DebugWithoutZone)].Flag; } set { this[nameof(DebugWithoutZone)].Flag = value; } }
        public RemnantQuestZone DebugQuestStartZone { get { return this[nameof(DebugQuestStartZone)].As<RemnantQuestZone>(); } set { this["DebugQuestStartZone"] = value; } }
        public RemnantQuestZoneLink DebugQuestStartWaypoint { get { return this[nameof(DebugQuestStartWaypoint)].As<RemnantQuestZoneLink>(); } set { this["DebugQuestStartWaypoint"] = value; } }
        public Object EventOnDebugQuestLoading { get { return this[nameof(EventOnDebugQuestLoading)]; } set { this[nameof(EventOnDebugQuestLoading)] = value; } }
        public RemnantQuest PendingDebugQuestInstance { get { return this[nameof(PendingDebugQuestInstance)].As<RemnantQuest>(); } set { this["PendingDebugQuestInstance"] = value; } }
        public RemnantQuest DebugQuestInstance { get { return this[nameof(DebugQuestInstance)].As<RemnantQuest>(); } set { this["DebugQuestInstance"] = value; } }
        public Object OnAllPlayersDead { get { return this[nameof(OnAllPlayersDead)]; } set { this[nameof(OnAllPlayersDead)] = value; } }
        public Object OnFinishRespawnAllPlayers { get { return this[nameof(OnFinishRespawnAllPlayers)]; } set { this[nameof(OnFinishRespawnAllPlayers)] = value; } }
        public float FailResetDelay { get { return this[nameof(FailResetDelay)].GetValue<float>(); } set { this[nameof(FailResetDelay)].SetValue<float>(value); } }
        public float MaxFailResetDelay { get { return this[nameof(MaxFailResetDelay)].GetValue<float>(); } set { this[nameof(MaxFailResetDelay)].SetValue<float>(value); } }
        public float ZoneTravelDelay { get { return this[nameof(ZoneTravelDelay)].GetValue<float>(); } set { this[nameof(ZoneTravelDelay)].SetValue<float>(value); } }
        public Object OnWorldReset { get { return this[nameof(OnWorldReset)]; } set { this[nameof(OnWorldReset)] = value; } }
        public Object OnWorldResetComplete { get { return this[nameof(OnWorldResetComplete)]; } set { this[nameof(OnWorldResetComplete)] = value; } }
        public Object OnTravelCountdownComplete { get { return this[nameof(OnTravelCountdownComplete)]; } set { this[nameof(OnTravelCountdownComplete)] = value; } }
        public TimerHandle RespawnHandle { get { return this[nameof(RespawnHandle)].As<TimerHandle>(); } set { this["RespawnHandle"] = value; } }
        public TimerHandle FailsafeRespawnHandle { get { return this[nameof(FailsafeRespawnHandle)].As<TimerHandle>(); } set { this["FailsafeRespawnHandle"] = value; } }
        public TimerHandle PostDeathRespawnHandle { get { return this[nameof(PostDeathRespawnHandle)].As<TimerHandle>(); } set { this["PostDeathRespawnHandle"] = value; } }
        public Array<RemnantPlayerController> WorldResetPlayers { get { return new Array<RemnantPlayerController>(this[nameof(WorldResetPlayers)].Address); } }
        public void TryRespawnPlayersPostDeath() { Invoke(nameof(TryRespawnPlayersPostDeath)); }
        public void TravelToZone(int DestZoneID, Object DestLink, Actor Source, bool bForce, bool bInstant) { Invoke(nameof(TravelToZone), DestZoneID, DestLink, Source, bForce, bInstant); }
        public void TravelToLastCheckpoint(Actor Source) { Invoke(nameof(TravelToLastCheckpoint), Source); }
        public void SetPostDeathScreenTime(float Time) { Invoke(nameof(SetPostDeathScreenTime), Time); }
        public void SetChunkDownloaded(Object PakPath) { Invoke(nameof(SetChunkDownloaded), PakPath); }
        public bool SetAsRootCheckpoint(ZoneLinkInfo NewZoneLink, bool IgnoreActive) { return Invoke<bool>(nameof(SetAsRootCheckpoint), NewZoneLink, IgnoreActive); }
        public bool SetAsRespawnZoneLink(ZoneLinkInfo NewZoneLink, bool bIgnoreWorldState) { return Invoke<bool>(nameof(SetAsRespawnZoneLink), NewZoneLink, bIgnoreWorldState); }
        public void OnStateDebugQuestLoaded(Quest Quest) { Invoke(nameof(OnStateDebugQuestLoaded), Quest); }
        public void OnSpawnDebugQuestLoaded(Quest Quest) { Invoke(nameof(OnSpawnDebugQuestLoaded), Quest); }
        public void OnFullGameAvailable() { Invoke(nameof(OnFullGameAvailable)); }
        public bool IsEveryoneEntitled(Object RequiredEntitlement, bool ShowFailDialog, bool KickUnentitled) { return Invoke<bool>(nameof(IsEveryoneEntitled), RequiredEntitlement, ShowFailDialog, KickUnentitled); }
        public void IncrementAllPlayersBossCounters() { Invoke(nameof(IncrementAllPlayersBossCounters)); }
        public ZoneLinkInfo GetRespawnZoneLink() { return Invoke<ZoneLinkInfo>(nameof(GetRespawnZoneLink)); }
        public void ActivateCheckpoint(Checkpoint Checkpoint) { Invoke(nameof(ActivateCheckpoint), Checkpoint); }
    }
    public class RemnantGameState : GameStateGunfire
    {
        public RemnantGameState(nint addr) : base(addr) { }
        public bool bTestMap { get { return this[nameof(bTestMap)].Flag; } set { this[nameof(bTestMap)].Flag = value; } }
        public float TravelCountdownAdditionalDistance { get { return this[nameof(TravelCountdownAdditionalDistance)].GetValue<float>(); } set { this[nameof(TravelCountdownAdditionalDistance)].SetValue<float>(value); } }
        public RemnantPingManager PingManager { get { return this[nameof(PingManager)].As<RemnantPingManager>(); } set { this["PingManager"] = value; } }
        public Object PingManagerType { get { return this[nameof(PingManagerType)]; } set { this[nameof(PingManagerType)] = value; } }
        public Object OnZoneTravelStateChanged { get { return this[nameof(OnZoneTravelStateChanged)]; } set { this[nameof(OnZoneTravelStateChanged)] = value; } }
        public Object OnAllPlayersFinishedTravel { get { return this[nameof(OnAllPlayersFinishedTravel)]; } set { this[nameof(OnAllPlayersFinishedTravel)] = value; } }
        public Object OnClientJoinBeginSpectate { get { return this[nameof(OnClientJoinBeginSpectate)]; } set { this[nameof(OnClientJoinBeginSpectate)] = value; } }
        public ZoneTravelState ZoneTravelState { get { return this[nameof(ZoneTravelState)].As<ZoneTravelState>(); } set { this["ZoneTravelState"] = value; } }
        public Checkpoint ActivatedCheckpoint { get { return this[nameof(ActivatedCheckpoint)].As<Checkpoint>(); } set { this["ActivatedCheckpoint"] = value; } }
        public Checkpoint DeactivatingCheckpoint { get { return this[nameof(DeactivatingCheckpoint)].As<Checkpoint>(); } set { this["DeactivatingCheckpoint"] = value; } }
        public Checkpoint PreviouslyActivatingCheckpoint { get { return this[nameof(PreviouslyActivatingCheckpoint)].As<Checkpoint>(); } set { this["PreviouslyActivatingCheckpoint"] = value; } }
        public Actor TravelCountdownSource { get { return this[nameof(TravelCountdownSource)].As<Actor>(); } set { this["TravelCountdownSource"] = value; } }
        public void OnRep_ZoneTravelState() { Invoke(nameof(OnRep_ZoneTravelState)); }
        public void OnRep_ActivatedCheckpoint() { Invoke(nameof(OnRep_ActivatedCheckpoint)); }
        public void NotifyClientJoinBeginSpectate(PlayerState Player) { Invoke(nameof(NotifyClientJoinBeginSpectate), Player); }
        public void LogStats() { Invoke(nameof(LogStats)); }
        public bool IsZoneTravelPending(Object WorldContextObject, float OutTimeRemaining) { return Invoke<bool>(nameof(IsZoneTravelPending), WorldContextObject, OutTimeRemaining); }
        public bool IsZoneTravelAvailable(Object WorldContextObject, EZoneTravelLock OutReason, Actor Source, bool bIsTravelMenu, float AdditionalDistance) { return Invoke<bool>(nameof(IsZoneTravelAvailable), WorldContextObject, OutReason, Source, bIsTravelMenu, AdditionalDistance); }
        public bool IsTravelPending(float OutTimeRemaining) { return Invoke<bool>(nameof(IsTravelPending), OutTimeRemaining); }
        public bool IsTravelAvailable(EZoneTravelLock OutReason, Actor Source, bool bIsTravelMenu, float AdditionalDistance) { return Invoke<bool>(nameof(IsTravelAvailable), OutReason, Source, bIsTravelMenu, AdditionalDistance); }
        public Checkpoint GetActivatedCheckpoint(Object WorldContextObject, bool bIncludeDeactivatingCheckpoint) { return Invoke<Checkpoint>(nameof(GetActivatedCheckpoint), WorldContextObject, bIncludeDeactivatingCheckpoint); }
    }
    public class RemnantPlayerController : PlayerControllerGunfire
    {
        public RemnantPlayerController(nint addr) : base(addr) { }
        public Object OnSetPawn { get { return this[nameof(OnSetPawn)]; } set { this[nameof(OnSetPawn)] = value; } }
        public Object OnPawnChanged { get { return this[nameof(OnPawnChanged)]; } set { this[nameof(OnPawnChanged)] = value; } }
        public Object OnNotifyQuestReward { get { return this[nameof(OnNotifyQuestReward)]; } set { this[nameof(OnNotifyQuestReward)] = value; } }
        public Object OnFinishTravelEvent { get { return this[nameof(OnFinishTravelEvent)]; } set { this[nameof(OnFinishTravelEvent)] = value; } }
        public Object OnBeginTravelEvent { get { return this[nameof(OnBeginTravelEvent)]; } set { this[nameof(OnBeginTravelEvent)] = value; } }
        public Object TravelAction { get { return this[nameof(TravelAction)]; } set { this[nameof(TravelAction)] = value; } }
        public int LevelsOnDuplicateTrait { get { return this[nameof(LevelsOnDuplicateTrait)].GetValue<int>(); } set { this[nameof(LevelsOnDuplicateTrait)].SetValue<int>(value); } }
        public bool bKeepPawnWhenTraveling { get { return this[nameof(bKeepPawnWhenTraveling)].Flag; } set { this[nameof(bKeepPawnWhenTraveling)].Flag = value; } }
        public EPlayerTravelState TravelState { get { return (EPlayerTravelState)this[nameof(TravelState)].GetValue<int>(); } set { this[nameof(TravelState)].SetValue<int>((int)value); } }
        public float TravelCleanupDelay { get { return this[nameof(TravelCleanupDelay)].GetValue<float>(); } set { this[nameof(TravelCleanupDelay)].SetValue<float>(value); } }
        public Object IntroQuest { get { return this[nameof(IntroQuest)]; } set { this[nameof(IntroQuest)] = value; } }
        public Object IntroQuestStartLink { get { return this[nameof(IntroQuestStartLink)]; } set { this[nameof(IntroQuestStartLink)] = value; } }
        public Object OnLocalPlayerFinishedLevelSequence { get { return this[nameof(OnLocalPlayerFinishedLevelSequence)]; } set { this[nameof(OnLocalPlayerFinishedLevelSequence)] = value; } }
        public bool bPrimaryWeaponToggled { get { return this[nameof(bPrimaryWeaponToggled)].Flag; } set { this[nameof(bPrimaryWeaponToggled)].Flag = value; } }
        public Object OnPingFailed { get { return this[nameof(OnPingFailed)]; } set { this[nameof(OnPingFailed)] = value; } }
        public TimerHandle FinishTravelHandle { get { return this[nameof(FinishTravelHandle)].As<TimerHandle>(); } set { this["FinishTravelHandle"] = value; } }
        public Object OnDeathScreenUnlocked { get { return this[nameof(OnDeathScreenUnlocked)]; } set { this[nameof(OnDeathScreenUnlocked)] = value; } }
        public Object OnPendingPlayStateActive { get { return this[nameof(OnPendingPlayStateActive)]; } set { this[nameof(OnPendingPlayStateActive)] = value; } }
        public RemnantArchetype CachedArchetype { get { return this[nameof(CachedArchetype)].As<RemnantArchetype>(); } set { this["CachedArchetype"] = value; } }
        public RemnantArchetype CachedSecondaryArchetype { get { return this[nameof(CachedSecondaryArchetype)].As<RemnantArchetype>(); } set { this["CachedSecondaryArchetype"] = value; } }
        public int CurrentZoneID { get { return this[nameof(CurrentZoneID)].GetValue<int>(); } set { this[nameof(CurrentZoneID)].SetValue<int>(value); } }
        public int PendingDestinationZoneID { get { return this[nameof(PendingDestinationZoneID)].GetValue<int>(); } set { this[nameof(PendingDestinationZoneID)].SetValue<int>(value); } }
        public int DestinationZoneID { get { return this[nameof(DestinationZoneID)].GetValue<int>(); } set { this[nameof(DestinationZoneID)].SetValue<int>(value); } }
        public Object DestinationLink { get { return this[nameof(DestinationLink)]; } set { this[nameof(DestinationLink)] = value; } }
        public Array<RemnantQuestReward> QueuedQuestRewards { get { return new Array<RemnantQuestReward>(this[nameof(QueuedQuestRewards)].Address); } }
        public Array<RemnantQuestReward> QueuedNotifyQueue { get { return new Array<RemnantQuestReward>(this[nameof(QueuedNotifyQueue)].Address); } }
        public EMusicState MusicState { get { return (EMusicState)this[nameof(MusicState)].GetValue<int>(); } set { this[nameof(MusicState)].SetValue<int>((int)value); } }
        public bool Respawning { get { return this[nameof(Respawning)].Flag; } set { this[nameof(Respawning)].Flag = value; } }
        public Object DeathScreenContextOverride { get { return this[nameof(DeathScreenContextOverride)]; } set { this[nameof(DeathScreenContextOverride)] = value; } }
        public Object LoadingState { get { return this[nameof(LoadingState)]; } set { this[nameof(LoadingState)] = value; } }
        public Object PendingTravelState { get { return this[nameof(PendingTravelState)]; } set { this[nameof(PendingTravelState)] = value; } }
        public Object CinematicState { get { return this[nameof(CinematicState)]; } set { this[nameof(CinematicState)] = value; } }
        public Object FinalizeResetState { get { return this[nameof(FinalizeResetState)]; } set { this[nameof(FinalizeResetState)] = value; } }
        public Object AliveResetState { get { return this[nameof(AliveResetState)]; } set { this[nameof(AliveResetState)] = value; } }
        public Object RespawnedResetState { get { return this[nameof(RespawnedResetState)]; } set { this[nameof(RespawnedResetState)] = value; } }
        public Object DeadResetState { get { return this[nameof(DeadResetState)]; } set { this[nameof(DeadResetState)] = value; } }
        public Object SpectatingState { get { return this[nameof(SpectatingState)]; } set { this[nameof(SpectatingState)] = value; } }
        public Object DyingState { get { return this[nameof(DyingState)]; } set { this[nameof(DyingState)] = value; } }
        public Object JoiningState { get { return this[nameof(JoiningState)]; } set { this[nameof(JoiningState)] = value; } }
        public Object CinematicFromWorldReset { get { return this[nameof(CinematicFromWorldReset)]; } set { this[nameof(CinematicFromWorldReset)] = value; } }
        public float AudioListenerPlayerCamLerp { get { return this[nameof(AudioListenerPlayerCamLerp)].GetValue<float>(); } set { this[nameof(AudioListenerPlayerCamLerp)].SetValue<float>(value); } }
        public float AudioListenerPlayerOffset { get { return this[nameof(AudioListenerPlayerOffset)].GetValue<float>(); } set { this[nameof(AudioListenerPlayerOffset)].SetValue<float>(value); } }
        public Array<Object> TeleportStates { get { return new Array<Object>(this[nameof(TeleportStates)].Address); } }
        public Pawn DeadPawn { get { return this[nameof(DeadPawn)].As<Pawn>(); } set { this["DeadPawn"] = value; } }
        public Pawn CachedPawn { get { return this[nameof(CachedPawn)].As<Pawn>(); } set { this["CachedPawn"] = value; } }
        public Array<int> PendingRewards { get { return new Array<int>(this[nameof(PendingRewards)].Address); } }
        public Array<int> PendingCurrencyRewards { get { return new Array<int>(this[nameof(PendingCurrencyRewards)].Address); } }
        public Object OnLicensesGiven { get { return this[nameof(OnLicensesGiven)]; } set { this[nameof(OnLicensesGiven)] = value; } }
        public void UpdatePlayState() { Invoke(nameof(UpdatePlayState)); }
        public void TravelPlayerTo(int DestZoneID, Object DestLink, bool bForce, bool bInstant) { Invoke(nameof(TravelPlayerTo), DestZoneID, DestLink, bForce, bInstant); }
        public void SwapCharacter(ZoneLinkInfo StartingWaypoint) { Invoke(nameof(SwapCharacter), StartingWaypoint); }
        public void StreamActiveCharacterToServer() { Invoke(nameof(StreamActiveCharacterToServer)); }
        public void ShowTutorial(Object Tutorial, Actor ContextActor) { Invoke(nameof(ShowTutorial), Tutorial, ContextActor); }
        public void SetReadyToTravel() { Invoke(nameof(SetReadyToTravel)); }
        public void SetIntroComplete() { Invoke(nameof(SetIntroComplete)); }
        public void SetDeathScreenLock(bool Locked) { Invoke(nameof(SetDeathScreenLock), Locked); }
        public void SetDeathScreenContextClass(Object ContextOverride) { Invoke(nameof(SetDeathScreenContextClass), ContextOverride); }
        public void ServerWorldResetComplete() { Invoke(nameof(ServerWorldResetComplete)); }
        public void ServerUpdateUsingMultiplayerFeatures() { Invoke(nameof(ServerUpdateUsingMultiplayerFeatures)); }
        public void ServerUpdateLicensedContent(Array<Object> Licenses) { Invoke(nameof(ServerUpdateLicensedContent), Licenses); }
        public void ServerUnlockItemAward(Object ItemAward, bool bDoNotify, bool bAutoEquip) { Invoke(nameof(ServerUnlockItemAward), ItemAward, bDoNotify, bAutoEquip); }
        public void ServerUnlockArchetypeAward(Object ArchetypeAward, bool bDoNotify) { Invoke(nameof(ServerUnlockArchetypeAward), ArchetypeAward, bDoNotify); }
        public void ServerUnlockAccountCurrency(Object CurrencyType, int Quantity, bool bDoNotify) { Invoke(nameof(ServerUnlockAccountCurrency), CurrencyType, Quantity, bDoNotify); }
        public void ServerStreamCharacterFinalize() { Invoke(nameof(ServerStreamCharacterFinalize)); }
        public void ServerStreamCharacterChunk(Array<byte> CharacterData) { Invoke(nameof(ServerStreamCharacterChunk), CharacterData); }
        public void ServerStreamCharacterBegin(int CharacterBlobSize) { Invoke(nameof(ServerStreamCharacterBegin), CharacterBlobSize); }
        public void ServerSetCurrentLock(EZoneTravelLock NewLock, bool bNewIsSaving, bool bNewWantsTravelMenuAccess) { Invoke(nameof(ServerSetCurrentLock), NewLock, bNewIsSaving, bNewWantsTravelMenuAccess); }
        public void ServerSetArchetype(Object NameOfBP, int ArchetypeLevel, int GearLevel, int Slot) { Invoke(nameof(ServerSetArchetype), NameOfBP, ArchetypeLevel, GearLevel, Slot); }
        public void ServerRevokeItemAward(Object ItemAward) { Invoke(nameof(ServerRevokeItemAward), ItemAward); }
        public void ServerRespawnSwappedCharacter(int ZoneID, Object ZoneNameId) { Invoke(nameof(ServerRespawnSwappedCharacter), ZoneID, ZoneNameId); }
        public void ServerRemoveTravelState() { Invoke(nameof(ServerRemoveTravelState)); }
        public void ServerRemoveItem(Object NameOfBP, int Quantity) { Invoke(nameof(ServerRemoveItem), NameOfBP, Quantity); }
        public void ServerReliableCameraLocationUpdate(Vector_NetQuantize CamLoc) { Invoke(nameof(ServerReliableCameraLocationUpdate), CamLoc); }
        public void ServerReadyToTravel() { Invoke(nameof(ServerReadyToTravel)); }
        public void ServerReadyForWorldReset() { Invoke(nameof(ServerReadyForWorldReset)); }
        public void ServerOnDataSynchronized() { Invoke(nameof(ServerOnDataSynchronized)); }
        public void ServerNotifyPendingPlayStateActive(Object PendingPlayState) { Invoke(nameof(ServerNotifyPendingPlayStateActive), PendingPlayState); }
        public void ServerInspectableUp(Actor Inspectable) { Invoke(nameof(ServerInspectableUp), Inspectable); }
        public void ServerInspectableToggle(Actor Inspectable) { Invoke(nameof(ServerInspectableToggle), Inspectable); }
        public void ServerInspectablePrev(Actor Inspectable) { Invoke(nameof(ServerInspectablePrev), Inspectable); }
        public void ServerInspectableOpen(Actor Inspectable) { Invoke(nameof(ServerInspectableOpen), Inspectable); }
        public void ServerInspectableNext(Actor Inspectable) { Invoke(nameof(ServerInspectableNext), Inspectable); }
        public void ServerInspectableDown(Actor Inspectable) { Invoke(nameof(ServerInspectableDown), Inspectable); }
        public void ServerHandleSkipIntro() { Invoke(nameof(ServerHandleSkipIntro)); }
        public void ServerGiveItemSilent(Object NameOfBP, int Quantity, int LevelOverride, bool bAutoEquip) { Invoke(nameof(ServerGiveItemSilent), NameOfBP, Quantity, LevelOverride, bAutoEquip); }
        public void ServerGiveItem(Object NameOfBP, int Quantity, int LevelOverride, bool bAutoEquip) { Invoke(nameof(ServerGiveItem), NameOfBP, Quantity, LevelOverride, bAutoEquip); }
        public void ServerEndInspect(Actor Inspectable) { Invoke(nameof(ServerEndInspect), Inspectable); }
        public void ServerDestinationZoneLoaded() { Invoke(nameof(ServerDestinationZoneLoaded)); }
        public void ServerClearWaitingForZones(int SyncCounter) { Invoke(nameof(ServerClearWaitingForZones), SyncCounter); }
        public void ServerBeginInspect(Actor Inspectable) { Invoke(nameof(ServerBeginInspect), Inspectable); }
        public void ServerAddExperience(ProgressionComponent Progression, int Amount) { Invoke(nameof(ServerAddExperience), Progression, Amount); }
        public void Respawn(ZoneLinkInfo StartingWaypoint) { Invoke(nameof(Respawn), StartingWaypoint); }
        public void RemoveAccountAwardListener(Object Event) { Invoke(nameof(RemoveAccountAwardListener), Event); }
        public void RefreshAccountAwards() { Invoke(nameof(RefreshAccountAwards)); }
        public void QueueManualQuestReward(RemnantQuest Quest, Array<Object> Items, bool bSkipDuplicates, bool bAutoEquip, ERemnantQuestRewardType RewardType, int Quantity, int LevelOverride, bool bIsArchetype, bool bWantsSaveOnAward) { Invoke(nameof(QueueManualQuestReward), Quest, Items, bSkipDuplicates, bAutoEquip, RewardType, Quantity, LevelOverride, bIsArchetype, bWantsSaveOnAward); }
        public void OnSessionDisconnected(World InWorld, NetDriver NetDriver) { Invoke(nameof(OnSessionDisconnected), InWorld, NetDriver); }
        public void OnServerFinalizeTravel() { Invoke(nameof(OnServerFinalizeTravel)); }
        public void OnRootQuestLoaded(Quest Quest) { Invoke(nameof(OnRootQuestLoaded), Quest); }
        public void OnReadyToTravel(int PendingZoneID) { Invoke(nameof(OnReadyToTravel), PendingZoneID); }
        public void OnPlayStateChanged(Object PreviousState, Object NewState) { Invoke(nameof(OnPlayStateChanged), PreviousState, NewState); }
        public void OnPlayInEditor() { Invoke(nameof(OnPlayInEditor)); }
        public void OnPlayerDied(byte Reason, CharacterGunfire DeadCharacter, Actor Cause) { Invoke(nameof(OnPlayerDied), Reason, DeadCharacter, Cause); }
        public void OnFinishWorldReset(Checkpoint ActivatedCheckpoint) { Invoke(nameof(OnFinishWorldReset), ActivatedCheckpoint); }
        public void OnFinishTravelLoad() { Invoke(nameof(OnFinishTravelLoad)); }
        public void OnFinishTravel() { Invoke(nameof(OnFinishTravel)); }
        public void OnFinishPlayStateTransition(Object NewState) { Invoke(nameof(OnFinishPlayStateTransition), NewState); }
        public void OnEntitlementsChanged() { Invoke(nameof(OnEntitlementsChanged)); }
        public void OnDeceased() { Invoke(nameof(OnDeceased)); }
        public void OnBeginWorldReset(Checkpoint ActivatedCheckpoint, bool bWasDead) { Invoke(nameof(OnBeginWorldReset), ActivatedCheckpoint, bWasDead); }
        public void OnBeginTravel(int PendingZoneID) { Invoke(nameof(OnBeginTravel), PendingZoneID); }
        public void OnAllZonesUnloaded() { Invoke(nameof(OnAllZonesUnloaded)); }
        public void MarkRevived() { Invoke(nameof(MarkRevived)); }
        public bool IsPlayerDead() { return Invoke<bool>(nameof(IsPlayerDead)); }
        public bool IsIntroQuestDisabled(Object WorldContextObject) { return Invoke<bool>(nameof(IsIntroQuestDisabled), WorldContextObject); }
        public bool IsIntroQuestComplete(Object WorldContextObject) { return Invoke<bool>(nameof(IsIntroQuestComplete), WorldContextObject); }
        public bool IsDeathScreenLocked() { return Invoke<bool>(nameof(IsDeathScreenLocked)); }
        public bool IsAwardingArchetype() { return Invoke<bool>(nameof(IsAwardingArchetype)); }
        public bool HasLicense(Object License) { return Invoke<bool>(nameof(HasLicense), License); }
        public bool HasGivenLicenses() { return Invoke<bool>(nameof(HasGivenLicenses)); }
        public bool HasFinishedInitialJoin() { return Invoke<bool>(nameof(HasFinishedInitialJoin)); }
        public bool HasAccountAward(Object Award) { return Invoke<bool>(nameof(HasAccountAward), Award); }
        public void HandleSkipIntro() { Invoke(nameof(HandleSkipIntro)); }
        public void GiveTableRewards(SpawnTable SpawnTable, Array<Object> SpawnTags, RemnantQuestReward Reward, int RandomSeed) { Invoke(nameof(GiveTableRewards), SpawnTable, SpawnTags, Reward, RandomSeed); }
        public void GiveQuestRewards(RemnantQuest Quest, SpawnTable SpawnTable, Array<Object> SpawnTags, ERemnantQuestRewardType RewardType, int RandomSeed) { Invoke(nameof(GiveQuestRewards), Quest, SpawnTable, SpawnTags, RewardType, RandomSeed); }
        public void GiveAccountAward(Object NewAward) { Invoke(nameof(GiveAccountAward), NewAward); }
        public float GetTimeSinceLastInput() { return Invoke<float>(nameof(GetTimeSinceLastInput)); }
        public bool GetTargetZoneLink(ZoneLinkInfo OutZoneLink, bool bSkipTravelDestination) { return Invoke<bool>(nameof(GetTargetZoneLink), OutZoneLink, bSkipTravelDestination); }
        public int GetScalingLevelOffset() { return Invoke<int>(nameof(GetScalingLevelOffset)); }
        public InventoryComponent GetRelevantInventoryComponentForItemType(Object ItemType) { return Invoke<InventoryComponent>(nameof(GetRelevantInventoryComponentForItemType), ItemType); }
        public InventoryComponent GetRelevantInventoryComponentForItem(Object Item) { return Invoke<InventoryComponent>(nameof(GetRelevantInventoryComponentForItem), Item); }
        public TraitsComponent GetPlayerTraits() { return Invoke<TraitsComponent>(nameof(GetPlayerTraits)); }
        public InventoryComponent GetPlayerInventory() { return Invoke<InventoryComponent>(nameof(GetPlayerInventory)); }
        public Object GetDeathScreenContextClass() { return Invoke<Object>(nameof(GetDeathScreenContextClass)); }
        public ZoneActor GetCurrentZone() { return Invoke<ZoneActor>(nameof(GetCurrentZone)); }
        public EZoneTravelLock GetCurrentTravelLock() { return Invoke<EZoneTravelLock>(nameof(GetCurrentTravelLock)); }
        public Pawn GetCurrentOrDeadPawn() { return Invoke<Pawn>(nameof(GetCurrentOrDeadPawn)); }
        public Array<Object> GetAdditionalItemsForAccountAward(Object Item) { return Invoke<Array<Object>>(nameof(GetAdditionalItemsForAccountAward), Item); }
        public EPingGenerationResult GatherPing(ActionPing OutPing) { return Invoke<EPingGenerationResult>(nameof(GatherPing), OutPing); }
        public void EnableWidgetComponentInteraction(bool bEnabled) { Invoke(nameof(EnableWidgetComponentInteraction), bEnabled); }
        public int ComputePowerLevel() { return Invoke<int>(nameof(ComputePowerLevel)); }
        public int ComputeItemLevel() { return Invoke<int>(nameof(ComputeItemLevel)); }
        public void ClientUpdateUsingMultiplayerFeatures(bool bEnabled) { Invoke(nameof(ClientUpdateUsingMultiplayerFeatures), bEnabled); }
        public void ClientUpdateFogOfWar(int ZoneID, VisitedCoordinates VisitedCoordinatesMap) { Invoke(nameof(ClientUpdateFogOfWar), ZoneID, VisitedCoordinatesMap); }
        public void ClientUpdateDeathScreenContextClass(Object ContextClass) { Invoke(nameof(ClientUpdateDeathScreenContextClass), ContextClass); }
        public void ClientUpdateArchetype(Object Archetype, bool bSecondary) { Invoke(nameof(ClientUpdateArchetype), Archetype, bSecondary); }
        public void ClientSetWaitingForZones(int SyncCounter) { Invoke(nameof(ClientSetWaitingForZones), SyncCounter); }
        public void ClientSetSpawnPrerequisites(PlayerSpawnPrerequisites Prerequisites) { Invoke(nameof(ClientSetSpawnPrerequisites), Prerequisites); }
        public void ClientSetMusicState(EMusicState State) { Invoke(nameof(ClientSetMusicState), State); }
        public void ClientRequestPendingPlayState(Object PendingPlayState) { Invoke(nameof(ClientRequestPendingPlayState), PendingPlayState); }
        public void ClientRequestCinematicFromWorldReset(bool Request) { Invoke(nameof(ClientRequestCinematicFromWorldReset), Request); }
        public void ClientOnSessionChanged() { Invoke(nameof(ClientOnSessionChanged)); }
        public void ClientNotifyQuestReward(RemnantQuestReward QuestReward) { Invoke(nameof(ClientNotifyQuestReward), QuestReward); }
        public void ClientLoadDestinationZone(int DestZoneID) { Invoke(nameof(ClientLoadDestinationZone), DestZoneID); }
        public void ClientIncrementBossCounter() { Invoke(nameof(ClientIncrementBossCounter)); }
        public void ClientHandleDeceased(bool bExitToMenu) { Invoke(nameof(ClientHandleDeceased), bExitToMenu); }
        public void ClientGiveAccountAward(Object NewAward) { Invoke(nameof(ClientGiveAccountAward), NewAward); }
        public void ClientFinishWorldReset(Checkpoint ActivatedCheckpoint) { Invoke(nameof(ClientFinishWorldReset), ActivatedCheckpoint); }
        public void ClientFinishTravel(Transform Destination) { Invoke(nameof(ClientFinishTravel), Destination); }
        public void ClientBeginWorldReset(Checkpoint ActivatedCheckpoint, bool bWasDead) { Invoke(nameof(ClientBeginWorldReset), ActivatedCheckpoint, bWasDead); }
        public void ClientBeginTravel(bool bRespawning, int PendingZoneID) { Invoke(nameof(ClientBeginTravel), bRespawning, PendingZoneID); }
        public void ClearTravelLock(EZoneTravelLock Lock) { Invoke(nameof(ClearTravelLock), Lock); }
        public void ClearPawn(bool SetCurrentAsDead, bool ShouldClearDeadPawn) { Invoke(nameof(ClearPawn), SetCurrentAsDead, ShouldClearDeadPawn); }
        public void ClearDeadPawn() { Invoke(nameof(ClearDeadPawn)); }
        public void ClearCachedSecondaryArchetype() { Invoke(nameof(ClearCachedSecondaryArchetype)); }
        public void ClearCachedArchetype() { Invoke(nameof(ClearCachedArchetype)); }
        public bool CanRespawnPlayers() { return Invoke<bool>(nameof(CanRespawnPlayers)); }
        public void BroadcastPing(ActionPing PingRequest) { Invoke(nameof(BroadcastPing), PingRequest); }
        public void BroadcastFinishedLevelSequence(CinematicPlayerSettings CinematicSettings, Object CurrentCinematic, Actor SequenceInstigator) { Invoke(nameof(BroadcastFinishedLevelSequence), CinematicSettings, CurrentCinematic, SequenceInstigator); }
        public void BroadcastEmote(Object Emote) { Invoke(nameof(BroadcastEmote), Emote); }
        public void BroadcastClientFinishedLevelSequence(CinematicPlayerSettings CinematicSettings, Object CurrentCinematic, Actor SequenceInstigator) { Invoke(nameof(BroadcastClientFinishedLevelSequence), CinematicSettings, CurrentCinematic, SequenceInstigator); }
        public void AwardArchetype(RemnantArchetype ArchetypeClass, RemnantQuest Quest, ERemnantQuestRewardType RewardType, bool bUseWhitelist, Array<Object> WhitelistClasses, bool bAddTraits, bool bAutoEquipArchetype, bool bAutoEquipItems, bool bSecondaryArchetype) { Invoke(nameof(AwardArchetype), ArchetypeClass, Quest, RewardType, bUseWhitelist, WhitelistClasses, bAddTraits, bAutoEquipArchetype, bAutoEquipItems, bSecondaryArchetype); }
        public EPingGenerationResult AttemptPing() { return Invoke<EPingGenerationResult>(nameof(AttemptPing)); }
        public void ApplyTravelLock(EZoneTravelLock Lock) { Invoke(nameof(ApplyTravelLock), Lock); }
        public void AddAccountAwardListener(Object Event) { Invoke(nameof(AddAccountAwardListener), Event); }
    }
    public class PlayStateEffect_TeleportPause : PlayStateEffect
    {
        public PlayStateEffect_TeleportPause(nint addr) : base(addr) { }
        public bool bWaitForTeleport { get { return this[nameof(bWaitForTeleport)].Flag; } set { this[nameof(bWaitForTeleport)].Flag = value; } }
    }
    public class RemnantSaveGame : SaveGameWorld
    {
        public RemnantSaveGame(nint addr) : base(addr) { }
        public bool NewGame { get { return this[nameof(NewGame)].Flag; } set { this[nameof(NewGame)].Flag = value; } }
        public bool HasMainCampaign { get { return this[nameof(HasMainCampaign)].Flag; } set { this[nameof(HasMainCampaign)].Flag = value; } }
        public int LastActiveRootSlot { get { return this[nameof(LastActiveRootSlot)].GetValue<int>(); } set { this[nameof(LastActiveRootSlot)].SetValue<int>(value); } }
        public int ZoneIDGen { get { return this[nameof(ZoneIDGen)].GetValue<int>(); } set { this[nameof(ZoneIDGen)].SetValue<int>(value); } }
        public int QuestIDGen { get { return this[nameof(QuestIDGen)].GetValue<int>(); } set { this[nameof(QuestIDGen)].SetValue<int>(value); } }
        public Object QuestFailCount { get { return this[nameof(QuestFailCount)]; } set { this[nameof(QuestFailCount)] = value; } }
        public float TimePlayed { get { return this[nameof(TimePlayed)].GetValue<float>(); } set { this[nameof(TimePlayed)].SetValue<float>(value); } }
        public float GetSavedTimePlayed() { return Invoke<float>(nameof(GetSavedTimePlayed)); }
        public float GetCurrentTimePlayed(Object WorldContextObject) { return Invoke<float>(nameof(GetCurrentTimePlayed), WorldContextObject); }
    }
    public class GameReadyCondition : Condition
    {
        public GameReadyCondition(nint addr) : base(addr) { }
    }
    public class GunObstructionCondition : Condition
    {
        public GunObstructionCondition(nint addr) : base(addr) { }
        public EGunObstructionTypes Type { get { return (EGunObstructionTypes)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public bool bInObstructedState { get { return this[nameof(bInObstructedState)].Flag; } set { this[nameof(bInObstructedState)].Flag = value; } }
    }
    public class LadderObstructionCondition : Condition
    {
        public LadderObstructionCondition(nint addr) : base(addr) { }
        public float Range { get { return this[nameof(Range)].GetValue<float>(); } set { this[nameof(Range)].SetValue<float>(value); } }
        public bool TestLOS { get { return this[nameof(TestLOS)].Flag; } set { this[nameof(TestLOS)].Flag = value; } }
        public bool ObstructionMustBeOnLadder { get { return this[nameof(ObstructionMustBeOnLadder)].Flag; } set { this[nameof(ObstructionMustBeOnLadder)].Flag = value; } }
        public ELadderDirection CheckDirection { get { return (ELadderDirection)this[nameof(CheckDirection)].GetValue<int>(); } set { this[nameof(CheckDirection)].SetValue<int>((int)value); } }
    }
    public class PlayersNearbyCondition : Condition
    {
        public PlayersNearbyCondition(nint addr) : base(addr) { }
        public float Range { get { return this[nameof(Range)].GetValue<float>(); } set { this[nameof(Range)].SetValue<float>(value); } }
        public bool TestLOS { get { return this[nameof(TestLOS)].Flag; } set { this[nameof(TestLOS)].Flag = value; } }
    }
    public class AITargetSwitchStateDecorator : ActorStateDecorator
    {
        public AITargetSwitchStateDecorator(nint addr) : base(addr) { }
        public ETargetSwitchType Type { get { return (ETargetSwitchType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public ETargetSelectionType SelectionType { get { return (ETargetSelectionType)this[nameof(SelectionType)].GetValue<int>(); } set { this[nameof(SelectionType)].SetValue<int>((int)value); } }
        public Object EventRegionName { get { return this[nameof(EventRegionName)]; } set { this[nameof(EventRegionName)] = value; } }
        public bool CooldownEnabled { get { return this[nameof(CooldownEnabled)].Flag; } set { this[nameof(CooldownEnabled)].Flag = value; } }
        public float CooldownMin { get { return this[nameof(CooldownMin)].GetValue<float>(); } set { this[nameof(CooldownMin)].SetValue<float>(value); } }
        public float CooldownMax { get { return this[nameof(CooldownMax)].GetValue<float>(); } set { this[nameof(CooldownMax)].SetValue<float>(value); } }
    }
    public class ShowLastEquipmentDecorator : ShowEquipmentAbstractDecorator
    {
        public ShowLastEquipmentDecorator(nint addr) : base(addr) { }
    }
    public class PreservedUserWidget : UserWidget
    {
        public PreservedUserWidget(nint addr) : base(addr) { }
    }
    public class RasterWidgetComponent : WidgetComponent
    {
        public RasterWidgetComponent(nint addr) : base(addr) { }
        public MaterialInterface MaterialOverride { get { return this[nameof(MaterialOverride)].As<MaterialInterface>(); } set { this["MaterialOverride"] = value; } }
        public Texture GetWidgetTexture() { return Invoke<Texture>(nameof(GetWidgetTexture)); }
        public void ForceRedraw() { Invoke(nameof(ForceRedraw)); }
        public MaterialInstanceDynamic CreateWidgetMaterial(PrimitiveComponent Primitive, MaterialInterface SourceMaterial, Object MaterialTextureName, int ElementIndex) { return Invoke<MaterialInstanceDynamic>(nameof(CreateWidgetMaterial), Primitive, SourceMaterial, MaterialTextureName, ElementIndex); }
    }
    public class RemnantAnalogCursorManager : GunfireAnalogCursorManager
    {
        public RemnantAnalogCursorManager(nint addr) : base(addr) { }
        public Object OnAnalogCursorStateChanged { get { return this[nameof(OnAnalogCursorStateChanged)]; } set { this[nameof(OnAnalogCursorStateChanged)] = value; } }
        public Widget CachedSnapWidget { get { return this[nameof(CachedSnapWidget)].As<Widget>(); } set { this["CachedSnapWidget"] = value; } }
        public void UpdateCachedCursorLockMode() { Invoke(nameof(UpdateCachedCursorLockMode)); }
        public void SnapToWidget(UserWidget WidgetToSnap, bool bUseCursorTarget, Vector2D OverrideSnapPoint) { Invoke(nameof(SnapToWidget), WidgetToSnap, bUseCursorTarget, OverrideSnapPoint); }
        public RemnantAnalogCursorManager GetInstance(Object WorldContextObject) { return Invoke<RemnantAnalogCursorManager>(nameof(GetInstance), WorldContextObject); }
    }
    public class RemnantCursorPanel : CanvasPanel
    {
        public RemnantCursorPanel(nint addr) : base(addr) { }
        public ECursorPanelType CursorPanelType { get { return (ECursorPanelType)this[nameof(CursorPanelType)].GetValue<int>(); } set { this[nameof(CursorPanelType)].SetValue<int>((int)value); } }
        public float GravitySpeedMod { get { return this[nameof(GravitySpeedMod)].GetValue<float>(); } set { this[nameof(GravitySpeedMod)].SetValue<float>(value); } }
        public float OverrideGravityDistanceNormalized { get { return this[nameof(OverrideGravityDistanceNormalized)].GetValue<float>(); } set { this[nameof(OverrideGravityDistanceNormalized)].SetValue<float>(value); } }
        public float FrictionSpeedMod { get { return this[nameof(FrictionSpeedMod)].GetValue<float>(); } set { this[nameof(FrictionSpeedMod)].SetValue<float>(value); } }
        public Object OnCursorEnter { get { return this[nameof(OnCursorEnter)]; } set { this[nameof(OnCursorEnter)] = value; } }
        public Object OnCursorExit { get { return this[nameof(OnCursorExit)]; } set { this[nameof(OnCursorExit)] = value; } }
        public Object OnCursorHover { get { return this[nameof(OnCursorHover)]; } set { this[nameof(OnCursorHover)] = value; } }
        public RemnantCursorTarget CachedLastHoveredTarget { get { return this[nameof(CachedLastHoveredTarget)].As<RemnantCursorTarget>(); } set { this["CachedLastHoveredTarget"] = value; } }
        public void DeregisterCursorTarget(RemnantCursorTarget Target) { Invoke(nameof(DeregisterCursorTarget), Target); }
    }
    public class RemnantCursorTarget : Border
    {
        public RemnantCursorTarget(nint addr) : base(addr) { }
        public float GravitySpeedMod { get { return this[nameof(GravitySpeedMod)].GetValue<float>(); } set { this[nameof(GravitySpeedMod)].SetValue<float>(value); } }
        public Vector2D GravityAnchor { get { return this[nameof(GravityAnchor)].As<Vector2D>(); } set { this["GravityAnchor"] = value; } }
        public float OverrideGravityDistanceTolerance { get { return this[nameof(OverrideGravityDistanceTolerance)].GetValue<float>(); } set { this[nameof(OverrideGravityDistanceTolerance)].SetValue<float>(value); } }
        public bool bFrictionOverrideActive { get { return this[nameof(bFrictionOverrideActive)].Flag; } set { this[nameof(bFrictionOverrideActive)].Flag = value; } }
        public float OverrideFrictionMod { get { return this[nameof(OverrideFrictionMod)].GetValue<float>(); } set { this[nameof(OverrideFrictionMod)].SetValue<float>(value); } }
        public Object OnCursorEnter { get { return this[nameof(OnCursorEnter)]; } set { this[nameof(OnCursorEnter)] = value; } }
        public Object OnCursorExit { get { return this[nameof(OnCursorExit)]; } set { this[nameof(OnCursorExit)] = value; } }
        public Object OnCursorHover { get { return this[nameof(OnCursorHover)]; } set { this[nameof(OnCursorHover)] = value; } }
        public Object OnBeginSnapToTarget { get { return this[nameof(OnBeginSnapToTarget)]; } set { this[nameof(OnBeginSnapToTarget)] = value; } }
        public Array<RemnantCursorPanel> ParentPanels { get { return new Array<RemnantCursorPanel>(this[nameof(ParentPanels)].Address); } }
        public void ForceRefreshCachedVisibility() { Invoke(nameof(ForceRefreshCachedVisibility)); }
        public void CatchWidgetAnimStateChange(EAnimationState AnimState) { Invoke(nameof(CatchWidgetAnimStateChange), AnimState); }
        public void CatchRootVisibilityUpdate(ESlateVisibility NewVisibility, ESlateVisibility PrevVisibility) { Invoke(nameof(CatchRootVisibilityUpdate), NewVisibility, PrevVisibility); }
    }
    public class RemnantHUD : UIHud
    {
        public RemnantHUD(nint addr) : base(addr) { }
        public Actor ContextActor { get { return this[nameof(ContextActor)].As<Actor>(); } set { this["ContextActor"] = value; } }
        public UIActor ShowUtilityRadial() { return Invoke<UIActor>(nameof(ShowUtilityRadial)); }
        public void ShowLoading(bool Show) { Invoke(nameof(ShowLoading), Show); }
        public UIActor ShowJoinSpectateScreen() { return Invoke<UIActor>(nameof(ShowJoinSpectateScreen)); }
        public UIActor ShowInGameMenu() { return Invoke<UIActor>(nameof(ShowInGameMenu)); }
        public UIActor ShowDeathScreen() { return Invoke<UIActor>(nameof(ShowDeathScreen)); }
        public UIActor ShowConsumableRadial() { return Invoke<UIActor>(nameof(ShowConsumableRadial)); }
        public UIActor ShowCinematicMenu(Object Cinematic, Array<PlayerGunfire> RelevantPlayers, Actor MenuInstigator) { return Invoke<UIActor>(nameof(ShowCinematicMenu), Cinematic, RelevantPlayers, MenuInstigator); }
        public bool ShouldShowSubtitles() { return Invoke<bool>(nameof(ShouldShowSubtitles)); }
        public bool ShouldShowHealthBars() { return Invoke<bool>(nameof(ShouldShowHealthBars)); }
        public void RemoveCheckpointNotification(Object NameID) { Invoke(nameof(RemoveCheckpointNotification), NameID); }
        public void QueueNotification(ENotificationType Type, Object Trait, Object Text, Object Prompt, Object ItemBP, int Value) { Invoke(nameof(QueueNotification), Type, Trait, Text, Prompt, ItemBP, Value); }
        public void OnStopPendingTravel() { Invoke(nameof(OnStopPendingTravel)); }
        public void OnStartPendingTravel() { Invoke(nameof(OnStartPendingTravel)); }
        public bool IsLoadingScreenFinishedTransitioning() { return Invoke<bool>(nameof(IsLoadingScreenFinishedTransitioning)); }
        public bool IsCheckpointNotificationActive(Object NameID) { return Invoke<bool>(nameof(IsCheckpointNotificationActive), NameID); }
        public bool HasInvalidDialog() { return Invoke<bool>(nameof(HasInvalidDialog)); }
        public Widget GetHudWidget() { return Invoke<Widget>(nameof(GetHudWidget)); }
        public void FadeOut() { Invoke(nameof(FadeOut)); }
        public void FadeIn() { Invoke(nameof(FadeIn)); }
        public void FadeAudioOut(Object Reason, bool Instant, bool FadeAudio) { Invoke(nameof(FadeAudioOut), Reason, Instant, FadeAudio); }
        public void FadeAudioIn(Object Reason) { Invoke(nameof(FadeAudioIn), Reason); }
        public void EnteringZoneAnimation(Object ZoneName) { Invoke(nameof(EnteringZoneAnimation), ZoneName); }
        public void ClearAllCheckpointNotifications() { Invoke(nameof(ClearAllCheckpointNotifications)); }
        public void AddCheckpointNotification(Object NameID, float TimeOverride) { Invoke(nameof(AddCheckpointNotification), NameID, TimeOverride); }
    }
    public class RemnantPingActor : Actor
    {
        public RemnantPingActor(nint addr) : base(addr) { }
        public void SetPingDetails(float Duration, Texture2D Icon, Color Color, ETailType Tail, ActionPing PingDetails) { Invoke(nameof(SetPingDetails), Duration, Icon, Color, Tail, PingDetails); }
        public void OnCinematicEvent(PlayerControllerGunfire PlayerController, bool bIsInCinematic) { Invoke(nameof(OnCinematicEvent), PlayerController, bIsInCinematic); }
    }
    public class PingSubContext : Object
    {
        public PingSubContext(nint addr) : base(addr) { }
        public byte PingType { get { return this[nameof(PingType)].GetValue<byte>(); } set { this[nameof(PingType)].SetValue<byte>(value); } }
        public ETownLock TownLock { get { return (ETownLock)this[nameof(TownLock)].GetValue<int>(); } set { this[nameof(TownLock)].SetValue<int>((int)value); } }
        public Texture2D Icon { get { return this[nameof(Icon)].As<Texture2D>(); } set { this["Icon"] = value; } }
        public Texture2D WorldIconOverride { get { return this[nameof(WorldIconOverride)].As<Texture2D>(); } set { this["WorldIconOverride"] = value; } }
        public bool ShouldOverrideWorldColor { get { return this[nameof(ShouldOverrideWorldColor)].Flag; } set { this[nameof(ShouldOverrideWorldColor)].Flag = value; } }
        public Color WorldObjectColorOverride { get { return this[nameof(WorldObjectColorOverride)].As<Color>(); } set { this["WorldObjectColorOverride"] = value; } }
        public Object SubContextText { get { return this[nameof(SubContextText)]; } set { this[nameof(SubContextText)] = value; } }
        public Object SoundSetID { get { return this[nameof(SoundSetID)]; } set { this[nameof(SoundSetID)] = value; } }
        public Object SubtitleText { get { return this[nameof(SubtitleText)]; } set { this[nameof(SubtitleText)] = value; } }
        public bool IsValidForPingType(EGamePingType Type) { return Invoke<bool>(nameof(IsValidForPingType), Type); }
    }
    public class PingEmoteSubContext : PingSubContext
    {
        public PingEmoteSubContext(nint addr) : base(addr) { }
        public int EmoteIndex { get { return this[nameof(EmoteIndex)].GetValue<int>(); } set { this[nameof(EmoteIndex)].SetValue<int>(value); } }
    }
    public class PingRequestSubContext : PingSubContext
    {
        public PingRequestSubContext(nint addr) : base(addr) { }
        public EPingSubRequestType RequestType { get { return (EPingSubRequestType)this[nameof(RequestType)].GetValue<int>(); } set { this[nameof(RequestType)].SetValue<int>((int)value); } }
        public float RequestDuration { get { return this[nameof(RequestDuration)].GetValue<float>(); } set { this[nameof(RequestDuration)].SetValue<float>(value); } }
        public Texture2D RequestHudIcon { get { return this[nameof(RequestHudIcon)].As<Texture2D>(); } set { this["RequestHudIcon"] = value; } }
    }
    public class RemnantPingManager : ActorComponent
    {
        public RemnantPingManager(nint addr) : base(addr) { }
        public Object OnCharacterPing { get { return this[nameof(OnCharacterPing)]; } set { this[nameof(OnCharacterPing)] = value; } }
        public Object OnPingRemoved { get { return this[nameof(OnPingRemoved)]; } set { this[nameof(OnPingRemoved)] = value; } }
        public Object OnRequestPing { get { return this[nameof(OnRequestPing)]; } set { this[nameof(OnRequestPing)] = value; } }
        public Object OnCharacterPingCooldown { get { return this[nameof(OnCharacterPingCooldown)]; } set { this[nameof(OnCharacterPingCooldown)] = value; } }
        public Array<Actor> VOCoolDownActors { get { return new Array<Actor>(this[nameof(VOCoolDownActors)].Address); } }
        public Array<Actor> PingCoolDownActors { get { return new Array<Actor>(this[nameof(PingCoolDownActors)].Address); } }
        public Object CharacterPingAttempts { get { return this[nameof(CharacterPingAttempts)]; } set { this[nameof(CharacterPingAttempts)] = value; } }
        public Object CharacterPingCooldownHandles { get { return this[nameof(CharacterPingCooldownHandles)]; } set { this[nameof(CharacterPingCooldownHandles)] = value; } }
        public Object PingTypeMap { get { return this[nameof(PingTypeMap)]; } set { this[nameof(PingTypeMap)] = value; } }
        public Array<PingSubContext> PingContextOptions { get { return new Array<PingSubContext>(this[nameof(PingContextOptions)].Address); } }
        public PingSubContext PrimaryAmmoRequest { get { return this[nameof(PrimaryAmmoRequest)].As<PingSubContext>(); } set { this["PrimaryAmmoRequest"] = value; } }
        public PingSubContext SecondaryAmmoRequest { get { return this[nameof(SecondaryAmmoRequest)].As<PingSubContext>(); } set { this["SecondaryAmmoRequest"] = value; } }
        public PingSubContext HealingRequest { get { return this[nameof(HealingRequest)].As<PingSubContext>(); } set { this["HealingRequest"] = value; } }
        public Object RangedWeaponType { get { return this[nameof(RangedWeaponType)]; } set { this[nameof(RangedWeaponType)] = value; } }
        public Object PrimaryAmmoClass { get { return this[nameof(PrimaryAmmoClass)]; } set { this[nameof(PrimaryAmmoClass)] = value; } }
        public Object SecondaryAmmoClass { get { return this[nameof(SecondaryAmmoClass)]; } set { this[nameof(SecondaryAmmoClass)] = value; } }
        public Object PingActorBP { get { return this[nameof(PingActorBP)]; } set { this[nameof(PingActorBP)] = value; } }
        public float DefaultPingDuration { get { return this[nameof(DefaultPingDuration)].GetValue<float>(); } set { this[nameof(DefaultPingDuration)].SetValue<float>(value); } }
        public float VoCooldownDuration { get { return this[nameof(VoCooldownDuration)].GetValue<float>(); } set { this[nameof(VoCooldownDuration)].SetValue<float>(value); } }
        public byte AllowedPingsPerInterval { get { return this[nameof(AllowedPingsPerInterval)].GetValue<byte>(); } set { this[nameof(AllowedPingsPerInterval)].SetValue<byte>(value); } }
        public float PingCooldownDuration { get { return this[nameof(PingCooldownDuration)].GetValue<float>(); } set { this[nameof(PingCooldownDuration)].SetValue<float>(value); } }
        public bool IsCharacterOnVOCooldown(Actor Character) { return Invoke<bool>(nameof(IsCharacterOnVOCooldown), Character); }
        public bool IsCharacterOnPingCooldown(Actor Character) { return Invoke<bool>(nameof(IsCharacterOnPingCooldown), Character); }
        public float GetRemainingCharacterPingCooldown(Actor Character) { return Invoke<float>(nameof(GetRemainingCharacterPingCooldown), Character); }
        public RemnantPingManager GetPingManager(Object WorldContextObject) { return Invoke<RemnantPingManager>(nameof(GetPingManager), WorldContextObject); }
        public bool GetPingFromCharacter(Actor Character, ActionPing OutPing, int PingIndex) { return Invoke<bool>(nameof(GetPingFromCharacter), Character, OutPing, PingIndex); }
        public Array<ActionPing> GetCurrentPings() { return Invoke<Array<ActionPing>>(nameof(GetCurrentPings)); }
        public void Client_UpdateCharacterPing(Actor Character, ActionPing NewPing) { Invoke(nameof(Client_UpdateCharacterPing), Character, NewPing); }
        public void Client_MarkPlayerSoloPing(Actor Character, bool IsSolo) { Invoke(nameof(Client_MarkPlayerSoloPing), Character, IsSolo); }
    }
    public class RemnantTutorial : PrimaryDataAsset
    {
        public RemnantTutorial(nint addr) : base(addr) { }
        public void ShowTutorial(Pawn Player, Actor ContextActor, bool bForceShow) { Invoke(nameof(ShowTutorial), Player, ContextActor, bForceShow); }
        public void OnShowTutorial(Pawn Player, Actor ContextActor, bool bForceShow) { Invoke(nameof(OnShowTutorial), Player, ContextActor, bForceShow); }
    }
    public class RemnantUIActor : UIActor
    {
        public RemnantUIActor(nint addr) : base(addr) { }
        public EDialogTravelLock TravelLock { get { return (EDialogTravelLock)this[nameof(TravelLock)].GetValue<int>(); } set { this[nameof(TravelLock)].SetValue<int>((int)value); } }
        public bool bAllowedDuringTravel { get { return this[nameof(bAllowedDuringTravel)].Flag; } set { this[nameof(bAllowedDuringTravel)].Flag = value; } }
        public bool bEnableControllerCursor { get { return this[nameof(bEnableControllerCursor)].Flag; } set { this[nameof(bEnableControllerCursor)].Flag = value; } }
        public void SetCursorStateOnInstance(ECursorOverrideState CursorActiveState) { Invoke(nameof(SetCursorStateOnInstance), CursorActiveState); }
        public void DeviceChangedCallback(int ControllerId, EInputDevice CurrentInputDevice, EInputDevice NewInputDevice) { Invoke(nameof(DeviceChangedCallback), ControllerId, CurrentInputDevice, NewInputDevice); }
    }
    public class RemnantValidationComponent : ActorComponent
    {
        public RemnantValidationComponent(nint addr) : base(addr) { }
        public ValidationTable ValidationTable { get { return this[nameof(ValidationTable)].As<ValidationTable>(); } set { this["ValidationTable"] = value; } }
        public float ExceptionTimeOutSeconds { get { return this[nameof(ExceptionTimeOutSeconds)].GetValue<float>(); } set { this[nameof(ExceptionTimeOutSeconds)].SetValue<float>(value); } }
        public RemnantValidationManager ValidationManager { get { return this[nameof(ValidationManager)].As<RemnantValidationManager>(); } set { this["ValidationManager"] = value; } }
        public Actor LocalValidationPawn { get { return this[nameof(LocalValidationPawn)].As<Actor>(); } set { this["LocalValidationPawn"] = value; } }
        public CachedValidationInfo CachedInfo { get { return this[nameof(CachedInfo)].As<CachedValidationInfo>(); } set { this["CachedInfo"] = value; } }
        public Object Rules { get { return this[nameof(Rules)]; } set { this[nameof(Rules)] = value; } }
        public Array<QueuedExceptionInfo> ExceptionQueue { get { return new Array<QueuedExceptionInfo>(this[nameof(ExceptionQueue)].Address); } }
        public void ValidateTraits(RemnantTraitsComponent CachedTraits) { Invoke(nameof(ValidateTraits), CachedTraits); }
        public void ValidateProgression(RemnantProgressionComponent CachedProgression) { Invoke(nameof(ValidateProgression), CachedProgression); }
        public void ValidateInventory(InventoryComponent CachedInventory) { Invoke(nameof(ValidateInventory), CachedInventory); }
        public void OnItemInstanceDataUpdate() { Invoke(nameof(OnItemInstanceDataUpdate)); }
        public void ExceptionTimeOut() { Invoke(nameof(ExceptionTimeOut)); }
        public void AddTraitException(Object TraitBP, int LevelChange, bool bIsRemovingTrait) { Invoke(nameof(AddTraitException), TraitBP, LevelChange, bIsRemovingTrait); }
        public void AddSoftTraitException(Object SoftTraitBP, int LevelChange, bool bIsRemovingTrait) { Invoke(nameof(AddSoftTraitException), SoftTraitBP, LevelChange, bIsRemovingTrait); }
        public void AddSoftItemException(Object SoftItemBP, int QuantityChange, int LevelChange) { Invoke(nameof(AddSoftItemException), SoftItemBP, QuantityChange, LevelChange); }
        public void AddProgressionException(int LevelChange, int ExperienceChange) { Invoke(nameof(AddProgressionException), LevelChange, ExperienceChange); }
        public void AddItemException(Object ItemBP, int QuantityChange, int LevelChange) { Invoke(nameof(AddItemException), ItemBP, QuantityChange, LevelChange); }
        public void AddEquipmentModException(int ModID, bool bIsEquipping) { Invoke(nameof(AddEquipmentModException), ModID, bIsEquipping); }
        public void AddCraftingRecipeExceptions(RecipeInfo RecipeInfo, int UpgradeItemID) { Invoke(nameof(AddCraftingRecipeExceptions), RecipeInfo, UpgradeItemID); }
    }
    public class RemnantValidationManager : ActorComponent
    {
        public RemnantValidationManager(nint addr) : base(addr) { }
        public Array<QueuedExceptionInfo> QueuedExceptions { get { return new Array<QueuedExceptionInfo>(this[nameof(QueuedExceptions)].Address); } }
        public void QueueSoftTraitException(Object SoftTraitBP, int LevelChange, bool bIsRemovingTrait) { Invoke(nameof(QueueSoftTraitException), SoftTraitBP, LevelChange, bIsRemovingTrait); }
        public void QueueSoftItemException(Object SoftItemBP, int QuantityChange, int LevelChange) { Invoke(nameof(QueueSoftItemException), SoftItemBP, QuantityChange, LevelChange); }
        public void QueueProgressionException(int LevelChange, int ExperienceChange) { Invoke(nameof(QueueProgressionException), LevelChange, ExperienceChange); }
        public RemnantValidationManager GetInstance(Object WorldContextObject) { return Invoke<RemnantValidationManager>(nameof(GetInstance), WorldContextObject); }
        public bool CanDoCheatValidation(Actor ValidatedActor) { return Invoke<bool>(nameof(CanDoCheatValidation), ValidatedActor); }
    }
    public class RemnantValidationItemEntry : ValidationTableEntry
    {
        public RemnantValidationItemEntry(nint addr) : base(addr) { }
        public EQuantityValidationType QuantityValidation { get { return (EQuantityValidationType)this[nameof(QuantityValidation)].GetValue<int>(); } set { this[nameof(QuantityValidation)].SetValue<int>((int)value); } }
        public EQuantityValidationType LevelValidation { get { return (EQuantityValidationType)this[nameof(LevelValidation)].GetValue<int>(); } set { this[nameof(LevelValidation)].SetValue<int>((int)value); } }
        public bool ValidateOverTimeOnly { get { return this[nameof(ValidateOverTimeOnly)].Flag; } set { this[nameof(ValidateOverTimeOnly)].Flag = value; } }
        public bool ValidateQuantityOverTime { get { return this[nameof(ValidateQuantityOverTime)].Flag; } set { this[nameof(ValidateQuantityOverTime)].Flag = value; } }
        public int MaxQuantityChangeOverTime { get { return this[nameof(MaxQuantityChangeOverTime)].GetValue<int>(); } set { this[nameof(MaxQuantityChangeOverTime)].SetValue<int>(value); } }
        public int QuantityChangeTimeOutSeconds { get { return this[nameof(QuantityChangeTimeOutSeconds)].GetValue<int>(); } set { this[nameof(QuantityChangeTimeOutSeconds)].SetValue<int>(value); } }
    }
    public class RemnantValidationItemType : RemnantValidationItemEntry
    {
        public RemnantValidationItemType(nint addr) : base(addr) { }
        public Object ItemType { get { return this[nameof(ItemType)]; } set { this[nameof(ItemType)] = value; } }
    }
    public class RemnantValidationItemClass : RemnantValidationItemEntry
    {
        public RemnantValidationItemClass(nint addr) : base(addr) { }
        public Object ItemClass { get { return this[nameof(ItemClass)]; } set { this[nameof(ItemClass)] = value; } }
    }
    public class RemnantValidationProgressEntry : ValidationTableEntry
    {
        public RemnantValidationProgressEntry(nint addr) : base(addr) { }
        public EQuantityValidationType ExperienceValidation { get { return (EQuantityValidationType)this[nameof(ExperienceValidation)].GetValue<int>(); } set { this[nameof(ExperienceValidation)].SetValue<int>((int)value); } }
        public EQuantityValidationType LevelValidation { get { return (EQuantityValidationType)this[nameof(LevelValidation)].GetValue<int>(); } set { this[nameof(LevelValidation)].SetValue<int>((int)value); } }
        public bool ValidateExperienceOverTime { get { return this[nameof(ValidateExperienceOverTime)].Flag; } set { this[nameof(ValidateExperienceOverTime)].Flag = value; } }
        public int MaxExperienceChangeOverTime { get { return this[nameof(MaxExperienceChangeOverTime)].GetValue<int>(); } set { this[nameof(MaxExperienceChangeOverTime)].SetValue<int>(value); } }
        public int ExperienceChangeTimeOutSeconds { get { return this[nameof(ExperienceChangeTimeOutSeconds)].GetValue<int>(); } set { this[nameof(ExperienceChangeTimeOutSeconds)].SetValue<int>(value); } }
    }
    public class RemnantValidationTraitEntry : ValidationTableEntry
    {
        public RemnantValidationTraitEntry(nint addr) : base(addr) { }
        public ETraitValidationType TraitValidation { get { return (ETraitValidationType)this[nameof(TraitValidation)].GetValue<int>(); } set { this[nameof(TraitValidation)].SetValue<int>((int)value); } }
        public EQuantityValidationType LevelValidation { get { return (EQuantityValidationType)this[nameof(LevelValidation)].GetValue<int>(); } set { this[nameof(LevelValidation)].SetValue<int>((int)value); } }
        public Object TraitClass { get { return this[nameof(TraitClass)]; } set { this[nameof(TraitClass)] = value; } }
    }
    public class Checkpoint : ManagedActor
    {
        public Checkpoint(nint addr) : base(addr) { }
        public void TransitionToMenu(RemnantCharacter Character) { Invoke(nameof(TransitionToMenu), Character); }
        public void TransitionFromMenu(RemnantCharacter Character) { Invoke(nameof(TransitionFromMenu), Character); }
        public void RemoveTutorialPrompts(RemnantCharacter Character) { Invoke(nameof(RemoveTutorialPrompts), Character); }
        public void OnUpgrade(RemnantCharacter Character) { Invoke(nameof(OnUpgrade), Character); }
        public void OnFinishActivation() { Invoke(nameof(OnFinishActivation)); }
        public void OnEndGrab(RemnantCharacter Player) { Invoke(nameof(OnEndGrab), Player); }
        public void OnBeginGrab(RemnantCharacter Player) { Invoke(nameof(OnBeginGrab), Player); }
        public void OnBeginActivation() { Invoke(nameof(OnBeginActivation)); }
        public void OnActivate() { Invoke(nameof(OnActivate)); }
        public void EndUseCheckpoint(RemnantCharacter Character) { Invoke(nameof(EndUseCheckpoint), Character); }
        public bool CanCheckpointActivate() { return Invoke<bool>(nameof(CanCheckpointActivate)); }
        public void BeginUseCheckpoint(RemnantCharacter Character, bool WasSummoned) { Invoke(nameof(BeginUseCheckpoint), Character, WasSummoned); }
    }
    public class ZoneActor : Actor
    {
        public ZoneActor(nint addr) : base(addr) { }
        public MapGenComponent MapGen { get { return this[nameof(MapGen)].As<MapGenComponent>(); } set { this["MapGen"] = value; } }
        public AIDirector AIDirector { get { return this[nameof(AIDirector)].As<AIDirector>(); } set { this["AIDirector"] = value; } }
        public EncounterManager EncounterManager { get { return this[nameof(EncounterManager)].As<EncounterManager>(); } set { this["EncounterManager"] = value; } }
        public AmbientSpawnManager AmbientSpawnManager { get { return this[nameof(AmbientSpawnManager)].As<AmbientSpawnManager>(); } set { this["AmbientSpawnManager"] = value; } }
        public ResourceSpawnManager ResourceSpawnManager { get { return this[nameof(ResourceSpawnManager)].As<ResourceSpawnManager>(); } set { this["ResourceSpawnManager"] = value; } }
        public PersistenceComponent PersistenceComponent { get { return this[nameof(PersistenceComponent)].As<PersistenceComponent>(); } set { this["PersistenceComponent"] = value; } }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int Level { get { return this[nameof(Level)].GetValue<int>(); } set { this[nameof(Level)].SetValue<int>(value); } }
        public int LevelMin { get { return this[nameof(LevelMin)].GetValue<int>(); } set { this[nameof(LevelMin)].SetValue<int>(value); } }
        public int LevelMax { get { return this[nameof(LevelMax)].GetValue<int>(); } set { this[nameof(LevelMax)].SetValue<int>(value); } }
        public int ZoneLevel { get { return this[nameof(ZoneLevel)].GetValue<int>(); } set { this[nameof(ZoneLevel)].SetValue<int>(value); } }
        public int ItemLevel { get { return this[nameof(ItemLevel)].GetValue<int>(); } set { this[nameof(ItemLevel)].SetValue<int>(value); } }
        public int ParentZoneID { get { return this[nameof(ParentZoneID)].GetValue<int>(); } set { this[nameof(ParentZoneID)].SetValue<int>(value); } }
        public int QuestID { get { return this[nameof(QuestID)].GetValue<int>(); } set { this[nameof(QuestID)].SetValue<int>(value); } }
        public Object NameID { get { return this[nameof(NameID)]; } set { this[nameof(NameID)] = value; } }
        public Object Label { get { return this[nameof(Label)]; } set { this[nameof(Label)] = value; } }
        public int Seed { get { return this[nameof(Seed)].GetValue<int>(); } set { this[nameof(Seed)].SetValue<int>(value); } }
        public int SlotID { get { return this[nameof(SlotID)].GetValue<int>(); } set { this[nameof(SlotID)].SetValue<int>(value); } }
        public TileSet TileSet { get { return this[nameof(TileSet)].As<TileSet>(); } set { this["TileSet"] = value; } }
        public Object MapTemplate { get { return this[nameof(MapTemplate)]; } set { this[nameof(MapTemplate)] = value; } }
        public Object SkyBox { get { return this[nameof(SkyBox)]; } set { this[nameof(SkyBox)] = value; } }
        public Array<MapGenAttribute> Attributes { get { return new Array<MapGenAttribute>(this[nameof(Attributes)].Address); } }
        public float DayLength { get { return this[nameof(DayLength)].GetValue<float>(); } set { this[nameof(DayLength)].SetValue<float>(value); } }
        public float DayOffset { get { return this[nameof(DayOffset)].GetValue<float>(); } set { this[nameof(DayOffset)].SetValue<float>(value); } }
        public bool Static { get { return this[nameof(Static)].Flag; } set { this[nameof(Static)].Flag = value; } }
        public VisitedCoordinates FowVisitedCoordinates { get { return this[nameof(FowVisitedCoordinates)].As<VisitedCoordinates>(); } set { this["FowVisitedCoordinates"] = value; } }
        public Object OnPlayerEnteredZone { get { return this[nameof(OnPlayerEnteredZone)]; } set { this[nameof(OnPlayerEnteredZone)] = value; } }
        public Object OnPlayerExitedZone { get { return this[nameof(OnPlayerExitedZone)]; } set { this[nameof(OnPlayerExitedZone)] = value; } }
        public Object OnPreZoneLoaded { get { return this[nameof(OnPreZoneLoaded)]; } set { this[nameof(OnPreZoneLoaded)] = value; } }
        public Object OnZoneLoaded { get { return this[nameof(OnZoneLoaded)]; } set { this[nameof(OnZoneLoaded)] = value; } }
        public Object OnZoneUnloaded { get { return this[nameof(OnZoneUnloaded)]; } set { this[nameof(OnZoneUnloaded)] = value; } }
        public bool ZoneLevelInitialized { get { return this[nameof(ZoneLevelInitialized)].Flag; } set { this[nameof(ZoneLevelInitialized)].Flag = value; } }
        public Array<ZoneLinkInfo> ZoneLinks { get { return new Array<ZoneLinkInfo>(this[nameof(ZoneLinks)].Address); } }
        public Array<SoftObjectPath> DynamicResources { get { return new Array<SoftObjectPath>(this[nameof(DynamicResources)].Address); } }
        public Array<Object> DynamicResourceRefs { get { return new Array<Object>(this[nameof(DynamicResourceRefs)].Address); } }
        public Array<PlayerController> Players { get { return new Array<PlayerController>(this[nameof(Players)].Address); } }
        public ZoneState State { get { return this[nameof(State)].As<ZoneState>(); } set { this["State"] = value; } }
        public ZoneState ServerState { get { return this[nameof(ServerState)].As<ZoneState>(); } set { this["ServerState"] = value; } }
        public void UpdateLevelScaling(bool Force) { Invoke(nameof(UpdateLevelScaling), Force); }
        public void UnloadZone() { Invoke(nameof(UnloadZone)); }
        public void OnResourcesLoad() { Invoke(nameof(OnResourcesLoad)); }
        public void OnRep_ServerState() { Invoke(nameof(OnRep_ServerState)); }
        public void OnRep_Level() { Invoke(nameof(OnRep_Level)); }
        public void OnMapGenInitialized() { Invoke(nameof(OnMapGenInitialized)); }
        public void OnMapGenFullyLoaded() { Invoke(nameof(OnMapGenFullyLoaded)); }
        public void OnMapGenFailed() { Invoke(nameof(OnMapGenFailed)); }
        public void OnFinalizeLoad() { Invoke(nameof(OnFinalizeLoad)); }
        public void LoadZone(Object Link) { Invoke(nameof(LoadZone), Link); }
        public bool IsLoaded() { return Invoke<bool>(nameof(IsLoaded)); }
        public bool IsFullyUnloaded() { return Invoke<bool>(nameof(IsFullyUnloaded)); }
        public bool IsChildZone() { return Invoke<bool>(nameof(IsChildZone)); }
        public bool HasFailedLoad() { return Invoke<bool>(nameof(HasFailedLoad)); }
        public EZoneStatus GetZoneStatus() { return Invoke<EZoneStatus>(nameof(GetZoneStatus)); }
        public int GetZoneLevel() { return Invoke<int>(nameof(GetZoneLevel)); }
        public Object GetUniqueName() { return Invoke<Object>(nameof(GetUniqueName)); }
        public float GetTOD() { return Invoke<float>(nameof(GetTOD)); }
        public RemnantQuest GetQuest() { return Invoke<RemnantQuest>(nameof(GetQuest)); }
        public ZoneActor GetParentZone() { return Invoke<ZoneActor>(nameof(GetParentZone)); }
        public int GetItemLevel() { return Invoke<int>(nameof(GetItemLevel)); }
        public bool ContainsActor(Actor Actor) { return Invoke<bool>(nameof(ContainsActor), Actor); }
    }
    public class ZoneManager : ActorComponent
    {
        public ZoneManager(nint addr) : base(addr) { }
        public Object OnManagedZoneLoaded { get { return this[nameof(OnManagedZoneLoaded)]; } set { this[nameof(OnManagedZoneLoaded)] = value; } }
        public Object OnAllZonesUnloaded { get { return this[nameof(OnAllZonesUnloaded)]; } set { this[nameof(OnAllZonesUnloaded)] = value; } }
        public Object OnAllRelevantZonesLoaded { get { return this[nameof(OnAllRelevantZonesLoaded)]; } set { this[nameof(OnAllRelevantZonesLoaded)] = value; } }
        public Array<ZoneActor> Zones { get { return new Array<ZoneActor>(this[nameof(Zones)].Address); } }
        public Array<ZoneRegion> ZoneRegions { get { return new Array<ZoneRegion>(this[nameof(ZoneRegions)].Address); } }
        public Object ActiveZoneRegions { get { return this[nameof(ActiveZoneRegions)]; } set { this[nameof(ActiveZoneRegions)] = value; } }
        public Object TempZoneRegions { get { return this[nameof(TempZoneRegions)]; } set { this[nameof(TempZoneRegions)] = value; } }
        public int UnlockAllWaypoints() { return Invoke<int>(nameof(UnlockAllWaypoints)); }
        public ZoneActor GetZoneForSlot(int SlotID) { return Invoke<ZoneActor>(nameof(GetZoneForSlot), SlotID); }
        public ZoneActor GetZoneForActor(Actor Actor) { return Invoke<ZoneActor>(nameof(GetZoneForActor), Actor); }
        public ZoneActor GetZoneByNameID(Object WorldContextObject, Object NameID) { return Invoke<ZoneActor>(nameof(GetZoneByNameID), WorldContextObject, NameID); }
        public ZoneActor GetZoneByID(Object WorldContextObject, int ID) { return Invoke<ZoneActor>(nameof(GetZoneByID), WorldContextObject, ID); }
        public ZoneManager GetInstance(Object WorldContextObject) { return Invoke<ZoneManager>(nameof(GetInstance), WorldContextObject); }
        public Object GetBiomeForActor(Actor Actor) { return Invoke<Object>(nameof(GetBiomeForActor), Actor); }
        public void DestroyZone(ZoneActor Zone) { Invoke(nameof(DestroyZone), Zone); }
        public ZoneActor CreateZone(int SlotID, Object ZoneActorBP, int SeedOverride) { return Invoke<ZoneActor>(nameof(CreateZone), SlotID, ZoneActorBP, SeedOverride); }
    }
    public class ZoneDef : Object
    {
        public ZoneDef(nint addr) : base(addr) { }
        public Array<Object> MapTemplates { get { return new Array<Object>(this[nameof(MapTemplates)].Address); } }
        public TileSet TileSet { get { return this[nameof(TileSet)].As<TileSet>(); } set { this["TileSet"] = value; } }
        public Array<TileSpawnList> SpawnLists { get { return new Array<TileSpawnList>(this[nameof(SpawnLists)].Address); } }
        public Array<EncounterGroup> EncounterGroups { get { return new Array<EncounterGroup>(this[nameof(EncounterGroups)].Address); } }
        public Object Resources { get { return this[nameof(Resources)]; } set { this[nameof(Resources)] = value; } }
        public Array<ZoneSkyBoxDef> SkyBoxes { get { return new Array<ZoneSkyBoxDef>(this[nameof(SkyBoxes)].Address); } }
        public Array<MapGenAttribute> Attributes { get { return new Array<MapGenAttribute>(this[nameof(Attributes)].Address); } }
    }
    public class ZoneLinkComponent : ActorComponent
    {
        public ZoneLinkComponent(nint addr) : base(addr) { }
        public Object NameID { get { return this[nameof(NameID)]; } set { this[nameof(NameID)] = value; } }
        public EZoneLinkStatus Status { get { return (EZoneLinkStatus)this[nameof(Status)].GetValue<int>(); } set { this[nameof(Status)].SetValue<int>((int)value); } }
        public Object OnInitialized { get { return this[nameof(OnInitialized)]; } set { this[nameof(OnInitialized)] = value; } }
        public bool AutoRegister { get { return this[nameof(AutoRegister)].Flag; } set { this[nameof(AutoRegister)].Flag = value; } }
        public EZoneLinkType Type { get { return (EZoneLinkType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public Object Label { get { return this[nameof(Label)]; } set { this[nameof(Label)] = value; } }
        public Object OnBecomeRespawnZoneLink { get { return this[nameof(OnBecomeRespawnZoneLink)]; } set { this[nameof(OnBecomeRespawnZoneLink)] = value; } }
        public Object OnActivatedZoneLink { get { return this[nameof(OnActivatedZoneLink)]; } set { this[nameof(OnActivatedZoneLink)] = value; } }
        public Object OnClearRespawnZoneLink { get { return this[nameof(OnClearRespawnZoneLink)]; } set { this[nameof(OnClearRespawnZoneLink)] = value; } }
        public Object OnPlayerSpawned { get { return this[nameof(OnPlayerSpawned)]; } set { this[nameof(OnPlayerSpawned)] = value; } }
        public float RequiredPlayerProximity { get { return this[nameof(RequiredPlayerProximity)].GetValue<float>(); } set { this[nameof(RequiredPlayerProximity)].SetValue<float>(value); } }
        public bool bIsRespawnZoneLink { get { return this[nameof(bIsRespawnZoneLink)].Flag; } set { this[nameof(bIsRespawnZoneLink)].Flag = value; } }
        public bool bHasWaypointAccess { get { return this[nameof(bHasWaypointAccess)].Flag; } set { this[nameof(bHasWaypointAccess)].Flag = value; } }
        public void TravelToWaypoint(Object LinkNameID) { Invoke(nameof(TravelToWaypoint), LinkNameID); }
        public void TravelToDestinationZone(bool Force, bool Instant) { Invoke(nameof(TravelToDestinationZone), Force, Instant); }
        public void SetLinkDisabled(bool Disabled) { Invoke(nameof(SetLinkDisabled), Disabled); }
        public void OnZoneLoaded(ZoneActor NewZone) { Invoke(nameof(OnZoneLoaded), NewZone); }
        public void OnRep_NameID() { Invoke(nameof(OnRep_NameID)); }
        public void OnRep_IsRespawnZoneLink() { Invoke(nameof(OnRep_IsRespawnZoneLink)); }
        public bool IsWaypoint() { return Invoke<bool>(nameof(IsWaypoint)); }
        public bool IsRespawnZoneLink() { return Invoke<bool>(nameof(IsRespawnZoneLink)); }
        public bool IsLinkDisabled() { return Invoke<bool>(nameof(IsLinkDisabled)); }
        public bool IsLinkActive() { return Invoke<bool>(nameof(IsLinkActive)); }
        public bool IsDestinationZoneLoaded() { return Invoke<bool>(nameof(IsDestinationZoneLoaded)); }
        public bool HasBeenUsed() { return Invoke<bool>(nameof(HasBeenUsed)); }
        public EZoneLinkType GetType() { return Invoke<EZoneLinkType>(nameof(GetType)); }
        public SpawnPoint GetSpawnPoint() { return Invoke<SpawnPoint>(nameof(GetSpawnPoint)); }
        public ZoneLinkInfo GetLinkInfo() { return Invoke<ZoneLinkInfo>(nameof(GetLinkInfo)); }
        public ZoneActor GetDestinationZone() { return Invoke<ZoneActor>(nameof(GetDestinationZone)); }
        public Array<ZoneLinkInfo> GetAccessibleWaypoints() { return Invoke<Array<ZoneLinkInfo>>(nameof(GetAccessibleWaypoints)); }
        public void ActivateLink() { Invoke(nameof(ActivateLink)); }
    }
    public class ZoneRegion : Actor
    {
        public ZoneRegion(nint addr) : base(addr) { }
        public int Priority { get { return this[nameof(Priority)].GetValue<int>(); } set { this[nameof(Priority)].SetValue<int>(value); } }
        public Object RegionType { get { return this[nameof(RegionType)]; } set { this[nameof(RegionType)] = value; } }
        public void OnRegionExit() { Invoke(nameof(OnRegionExit)); }
        public void OnRegionEnter() { Invoke(nameof(OnRegionEnter)); }
        public bool Contains(Vector Location) { return Invoke<bool>(nameof(Contains), Location); }
    }
    public class EventRegionCharacter : Object
    {
        public EventRegionCharacter(nint addr) : base(addr) { }
        public PlayerController Controller { get { return this[nameof(Controller)].As<PlayerController>(); } set { this["Controller"] = value; } }
        public RemnantCharacter Character { get { return this[nameof(Character)].As<RemnantCharacter>(); } set { this["Character"] = value; } }
    }
    public class ActionPing : Object
    {
        public ActionPing(nint addr) : base(addr) { }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public float Duration { get { return this[nameof(Duration)].GetValue<float>(); } set { this[nameof(Duration)].SetValue<float>(value); } }
        public EGamePingType PingType { get { return (EGamePingType)this[nameof(PingType)].GetValue<int>(); } set { this[nameof(PingType)].SetValue<int>((int)value); } }
        public PingSubContext SubContext { get { return this[nameof(SubContext)].As<PingSubContext>(); } set { this["SubContext"] = value; } }
        public bool ShouldSpawnPingActor { get { return this[nameof(ShouldSpawnPingActor)].Flag; } set { this[nameof(ShouldSpawnPingActor)].Flag = value; } }
        public Actor PingOwner { get { return this[nameof(PingOwner)].As<Actor>(); } set { this["PingOwner"] = value; } }
        public Actor Target { get { return this[nameof(Target)].As<Actor>(); } set { this["Target"] = value; } }
        public Actor SpawnedPingActor { get { return this[nameof(SpawnedPingActor)].As<Actor>(); } set { this["SpawnedPingActor"] = value; } }
        public ETailType TailType { get { return (ETailType)this[nameof(TailType)].GetValue<int>(); } set { this[nameof(TailType)].SetValue<int>((int)value); } }
        public Object Emote { get { return this[nameof(Emote)]; } set { this[nameof(Emote)] = value; } }
        public TimerHandle PingTimerHandle { get { return this[nameof(PingTimerHandle)].As<TimerHandle>(); } set { this["PingTimerHandle"] = value; } }
    }
    public enum ETailType : int
    {
        NoTail = 0,
        HalfTail = 1,
        FullTail = 2,
        ETailType_MAX = 3,
    }
    public enum EGamePingType : int
    {
        Location = 0,
        Item = 1,
        PrimaryAmmo = 2,
        SecondaryAmmo = 3,
        Quest = 4,
        Friendly = 5,
        Enemy = 6,
        Checkpoint = 7,
        EGamePingType_MAX = 8,
    }
    public enum EBoardUser : int
    {
        None = 0,
        Player = 1,
        Opponent = 2,
        EBoardUser_MAX = 3,
    }
    public enum EPingGenerationResult : int
    {
        Success = 0,
        PingMuted = 1,
        GenericFailure = 2,
        EPingGenerationResult_MAX = 3,
    }
    public class ZoneTravelState : Object
    {
        public ZoneTravelState(nint addr) : base(addr) { }
        public EZoneTravelLock CurrentTravelLock { get { return (EZoneTravelLock)this[nameof(CurrentTravelLock)].GetValue<int>(); } set { this[nameof(CurrentTravelLock)].SetValue<int>((int)value); } }
        public bool bIsZoneTravelPending { get { return this[nameof(bIsZoneTravelPending)].Flag; } set { this[nameof(bIsZoneTravelPending)].Flag = value; } }
        public float TravelCountdown { get { return this[nameof(TravelCountdown)].GetValue<float>(); } set { this[nameof(TravelCountdown)].SetValue<float>(value); } }
        public PlayerState ExclusiveTravelMenuPlayer { get { return this[nameof(ExclusiveTravelMenuPlayer)].As<PlayerState>(); } set { this["ExclusiveTravelMenuPlayer"] = value; } }
        public bool bInitializingZones { get { return this[nameof(bInitializingZones)].Flag; } set { this[nameof(bInitializingZones)].Flag = value; } }
        public int NumZones { get { return this[nameof(NumZones)].GetValue<int>(); } set { this[nameof(NumZones)].SetValue<int>(value); } }
    }
    public enum EZoneTravelLock : int
    {
        None = 0,
        Menu = 1,
        Dialog = 2,
        Saving = 3,
        TravelMenu = 4,
        ConnectingPlayer = 5,
        Traveling = 6,
        Proximity = 7,
        Wounded = 8,
        QuestInit = 9,
        QuestMenu = 10,
        EZoneTravelLock_MAX = 11,
    }
    public class RemnantQuestReward : Object
    {
        public RemnantQuestReward(nint addr) : base(addr) { }
        public ERemnantQuestRewardType RewardType { get { return (ERemnantQuestRewardType)this[nameof(RewardType)].GetValue<int>(); } set { this[nameof(RewardType)].SetValue<int>((int)value); } }
        public RemnantQuest Quest { get { return this[nameof(Quest)].As<RemnantQuest>(); } set { this["Quest"] = value; } }
        public int Experience { get { return this[nameof(Experience)].GetValue<int>(); } set { this[nameof(Experience)].SetValue<int>(value); } }
        public Array<RemnantQuestRewardItem> Items { get { return new Array<RemnantQuestRewardItem>(this[nameof(Items)].Address); } }
        public bool bAutoEquip { get { return this[nameof(bAutoEquip)].Flag; } set { this[nameof(bAutoEquip)].Flag = value; } }
        public bool bSkipDuplicates { get { return this[nameof(bSkipDuplicates)].Flag; } set { this[nameof(bSkipDuplicates)].Flag = value; } }
        public bool bIsArchetype { get { return this[nameof(bIsArchetype)].Flag; } set { this[nameof(bIsArchetype)].Flag = value; } }
        public bool bSaveOnAward { get { return this[nameof(bSaveOnAward)].Flag; } set { this[nameof(bSaveOnAward)].Flag = value; } }
        public SpawnList QuestRewards { get { return this[nameof(QuestRewards)].As<SpawnList>(); } set { this["QuestRewards"] = value; } }
        public Array<int> ClearedLoot { get { return new Array<int>(this[nameof(ClearedLoot)].Address); } }
    }
    public class RemnantQuestRewardItem : Object
    {
        public RemnantQuestRewardItem(nint addr) : base(addr) { }
        public int ItemId { get { return this[nameof(ItemId)].GetValue<int>(); } set { this[nameof(ItemId)].SetValue<int>(value); } }
        public int Quantity { get { return this[nameof(Quantity)].GetValue<int>(); } set { this[nameof(Quantity)].SetValue<int>(value); } }
        public int NewLevel { get { return this[nameof(NewLevel)].GetValue<int>(); } set { this[nameof(NewLevel)].SetValue<int>(value); } }
        public int QuestRewardIndex { get { return this[nameof(QuestRewardIndex)].GetValue<int>(); } set { this[nameof(QuestRewardIndex)].SetValue<int>(value); } }
        public Object ItemBP { get { return this[nameof(ItemBP)]; } set { this[nameof(ItemBP)] = value; } }
    }
    public enum ERemnantQuestRewardType : int
    {
        Quest = 0,
        Objective = 1,
        Individual = 2,
        SharedPickup = 3,
        ERemnantQuestRewardType_MAX = 4,
    }
    public class ZoneLinkInfo : Object
    {
        public ZoneLinkInfo(nint addr) : base(addr) { }
        public Actor LinkActor { get { return this[nameof(LinkActor)].As<Actor>(); } set { this["LinkActor"] = value; } }
        public int ZoneID { get { return this[nameof(ZoneID)].GetValue<int>(); } set { this[nameof(ZoneID)].SetValue<int>(value); } }
        public Object NameID { get { return this[nameof(NameID)]; } set { this[nameof(NameID)] = value; } }
        public Object WorldMapID { get { return this[nameof(WorldMapID)]; } set { this[nameof(WorldMapID)] = value; } }
        public Object Category { get { return this[nameof(Category)]; } set { this[nameof(Category)] = value; } }
        public Object Label { get { return this[nameof(Label)]; } set { this[nameof(Label)] = value; } }
        public Object Image { get { return this[nameof(Image)]; } set { this[nameof(Image)] = value; } }
        public EZoneLinkType Type { get { return (EZoneLinkType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public bool IsActive { get { return this[nameof(IsActive)].Flag; } set { this[nameof(IsActive)].Flag = value; } }
        public bool IsMainPath { get { return this[nameof(IsMainPath)].Flag; } set { this[nameof(IsMainPath)].Flag = value; } }
        public bool IsDisabled { get { return this[nameof(IsDisabled)].Flag; } set { this[nameof(IsDisabled)].Flag = value; } }
        public bool CanBeRespawnLink { get { return this[nameof(CanBeRespawnLink)].Flag; } set { this[nameof(CanBeRespawnLink)].Flag = value; } }
        public bool Used { get { return this[nameof(Used)].Flag; } set { this[nameof(Used)].Flag = value; } }
        public int TileID { get { return this[nameof(TileID)].GetValue<int>(); } set { this[nameof(TileID)].SetValue<int>(value); } }
        public Object DestinationZone { get { return this[nameof(DestinationZone)]; } set { this[nameof(DestinationZone)] = value; } }
        public Object DestinationLink { get { return this[nameof(DestinationLink)]; } set { this[nameof(DestinationLink)] = value; } }
    }
    public enum EZoneLinkType : int
    {
        Link = 0,
        Checkpoint = 1,
        Waypoint = 2,
        EZoneLinkType_MAX = 3,
    }
    public enum EModActiveState : int
    {
        NotActive = 0,
        ActiveAction = 1,
        ActiveWeaponMode = 2,
        EModActiveState_MAX = 3,
    }
    public enum EBuildupMethod : int
    {
        Damage = 0,
        DamageScaled = 1,
        DamageCurve = 2,
        Set = 3,
        BuildupCurve = 4,
        HealthPercentCurve = 5,
        EBuildupMethod_MAX = 6,
    }
    public enum EAnalogCursorMovementMode : int
    {
        Direct = 0,
        Accelerated = 1,
        EAnalogCursorMovementMode_MAX = 2,
    }
    public enum EQuestMode : int
    {
        Campaign = 0,
        Adventure = 1,
        Debug = 2,
        None = 3,
        EQuestMode_MAX = 4,
    }
    public enum ERemnantQuestType : int
    {
        Default = 0,
        Root = 1,
        Static = 2,
        ERemnantQuestType_MAX = 3,
    }
    public enum ERemnantQuestRarity : int
    {
        Common = 0,
        Uncommon = 1,
        Rare = 2,
        Epic = 3,
        Legendary = 4,
        ERemnantQuestRarity_MAX = 5,
    }
    public enum ERemnantQuestDebugState : int
    {
        None = 0,
        Prototype = 1,
        WorkInProgress = 2,
        Final = 3,
        ERemnantQuestDebugState_MAX = 4,
    }
    public enum ERemnantQuestStatus : int
    {
        Unloaded = 0,
        Loading = 1,
        Creating = 2,
        Initializing = 3,
        Loaded = 4,
        Error = 5,
        ERemnantQuestStatus_MAX = 6,
    }
    public enum ETacticalGraphNodeStatus : int
    {
        Generated = 0,
        Dirty = 1,
        Stitch = 2,
        ETacticalGraphNodeStatus_MAX = 3,
    }
    public enum EWindupState : int
    {
        None = 0,
        Windup = 1,
        Overdraw = 2,
        EWindupState_MAX = 3,
    }
    public enum EGender : int
    {
        Male = 0,
        Female = 1,
        EGender_MAX = 2,
    }
    public enum EPIESelectionGender : int
    {
        Male = 0,
        Female = 1,
        Random = 2,
        None = 3,
        EPIESelectionGender_MAX = 4,
    }
    public enum ELastHostType : int
    {
        FriendsOnly = 0,
        Public = 1,
        Offline = 2,
        ELastHostType_MAX = 3,
    }
    public enum ERemnantCharacterType : int
    {
        Standard = 0,
        Hardcore = 1,
        Survival = 2,
        ERemnantCharacterType_MAX = 3,
    }
    public enum ESharedPickupType : int
    {
        NoSharedPickup = 0,
        SharePickup = 1,
        SharePickupAsCurrency = 2,
        SharePickupAsCurrencySplit = 3,
        ESharedPickupType_MAX = 4,
    }
    public enum ERemnantMaterialInputType : int
    {
        CappedPower = 0,
        WrappedPower = 1,
        NormalPower = 2,
        TotalPower = 3,
        Charges = 4,
        Constant = 5,
        ERemnantMaterialInputType_MAX = 6,
    }
    public enum ERemnantWeaponMaterialParameterType : int
    {
        Scalar = 0,
        Color = 1,
        ERemnantWeaponMaterialParameterType_MAX = 2,
    }
    public enum EBoardLayout : int
    {
        None = 0,
        Default = 1,
        GameStart = 2,
        EBoardLayout_MAX = 3,
    }
    public enum EMatchmakingPlatform : int
    {
        Steam = 0,
        Epic = 1,
        XBox = 2,
        Playstation = 3,
        EMatchmakingPlatform_MAX = 4,
    }
    public enum EGenerationType : int
    {
        TargetPlayerOnly = 0,
        SharedItems = 1,
        SharedAll = 2,
        IndividualRollsPerPlayer = 3,
        EGenerationType_MAX = 4,
    }
    public enum ELoreTextMode : int
    {
        None = 0,
        Normal = 1,
        Alternate = 2,
        ELoreTextMode_MAX = 3,
    }
    public enum EModInputMode : int
    {
        Press = 0,
        Release = 1,
        EModInputMode_MAX = 2,
    }
    public enum ETraitProgressionType : int
    {
        LegacyProgression = 0,
        CharacterProgression = 1,
        ETraitProgressionType_MAX = 2,
    }
    public enum ETraitSortProperty : int
    {
        None = 0,
        Level = 1,
        ETraitSortProperty_MAX = 2,
    }
    public enum ETraitSortType : int
    {
        Archetype = 0,
        Character = 1,
        Equipment = 2,
        ETraitSortType_MAX = 3,
    }
    public enum ENetGameMode : int
    {
        SinglePlayer = 0,
        HostPublic = 1,
        HostFriends = 2,
        Join = 3,
        ENetGameMode_MAX = 4,
    }
    public enum ERemnantDemoMode : int
    {
        None = 0,
        GamesComFloor = 1,
        GamesComPress = 2,
        ERemnantDemoMode_MAX = 3,
    }
    public enum EPresenceJoinResult : int
    {
        Success = 0,
        IntroIncomplete = 1,
        NoCharacters = 2,
        ConnectFailed = 3,
        EPresenceJoinResult_MAX = 4,
    }
    public enum EWorldResetServerState : int
    {
        Idle = 0,
        Pending = 1,
        Respawning = 2,
        EWorldResetServerState_MAX = 3,
    }
    public enum EPlayerTravelState : int
    {
        Idle = 0,
        PendingTravel = 1,
        Traveling = 2,
        PostTravel = 3,
        WaitingForServer = 4,
        WaitingForFinishTravel = 5,
        PendingCharSwap = 6,
        WaitingForClientToBeginTravel = 7,
        WaitingForClientToLoad = 8,
        FinalizingTravel = 9,
        WaitingForClient = 10,
        LoadingRootQuest = 11,
        LoadingDestinationZone = 12,
        EPlayerTravelState_MAX = 13,
    }
    public enum EWorldResetPlayerState : int
    {
        Idle = 0,
        FadeOutWorldDead = 1,
        FadeOutWorldRespawned = 2,
        FadeOutWorldAlive = 3,
        FadeInWorld = 4,
        WaitingForClient = 5,
        ReadyForReset = 6,
        EWorldResetPlayerState_MAX = 7,
    }
    public enum EGunObstructionTypes : int
    {
        Default = 0,
        Extent = 1,
        Crouching = 2,
        CrouchExtent = 3,
        EGunObstructionTypes_MAX = 4,
    }
    public enum ELadderDirection : int
    {
        EVERYWHERE = 0,
        ABOVE_ONLY = 1,
        BELOW_ONLY = 2,
        ELadderDirection_MAX = 3,
    }
    public enum ETargetSwitchType : int
    {
        EventRegion = 0,
        KnownThreats = 1,
        ETargetSwitchType_MAX = 2,
    }
    public enum ETargetSelectionType : int
    {
        Random = 0,
        HighestThreat = 1,
        LowestThreat = 2,
        ETargetSelectionType_MAX = 3,
    }
    public enum EAnalogCursorSnapState : int
    {
        None = 0,
        Requested = 1,
        InProgress = 2,
        Finishing = 3,
        EAnalogCursorSnapState_MAX = 4,
    }
    public enum ECursorPanelType : int
    {
        Friction = 0,
        Gravity = 1,
        ECursorPanelType_MAX = 2,
    }
    public enum EPingSubRequestType : int
    {
        PrimaryAmmo = 0,
        SecondaryAmmo = 1,
        Assistance = 2,
        WorldStone = 3,
        ThisWay = 4,
        LetsGo = 5,
        EPingSubRequestType_MAX = 6,
    }
    public enum ETownLock : int
    {
        NoLock = 0,
        OnlyTown = 1,
        NotInTown = 2,
        ETownLock_MAX = 3,
    }
    public enum EDialogTravelLock : int
    {
        None = 0,
        Menu = 1,
        Dialog = 2,
        TravelMenu = 3,
        QuestSelectMenu = 4,
        EDialogTravelLock_MAX = 5,
    }
    public enum ECursorOverrideState : int
    {
        None = 0,
        Active = 1,
        Inactive = 2,
        ECursorOverrideState_MAX = 3,
    }
    public enum EValidationType : int
    {
        Item = 0,
        Trait = 1,
        Progression = 2,
        EValidationType_MAX = 3,
    }
    public enum EExceptionType : int
    {
        None = 0,
        Add = 1,
        Remove = 2,
        EExceptionType_MAX = 3,
    }
    public enum ETraitValidationType : int
    {
        NoValidation = 0,
        ValidateOnRemove = 1,
        ETraitValidationType_MAX = 2,
    }
    public enum EZoneStatus : int
    {
        Unloaded = 0,
        Loading = 1,
        LoadingDynamicResources = 2,
        LoadingDynamicSubResources = 3,
        WaitingForServerLoading = 4,
        WaitingForServer = 5,
        Loaded = 6,
        Failed = 7,
        EZoneStatus_MAX = 8,
    }
    public enum EZoneLinkStatus : int
    {
        None = 0,
        Unloaded = 1,
        Loaded = 2,
        EZoneLinkStatus_MAX = 3,
    }
    public class RadialShortcut : Object
    {
        public RadialShortcut(nint addr) : base(addr) { }
        public Object Radial { get { return this[nameof(Radial)]; } set { this[nameof(Radial)] = value; } }
        public int Slot { get { return this[nameof(Slot)].GetValue<int>(); } set { this[nameof(Slot)].SetValue<int>(value); } }
        public Object ItemBP { get { return this[nameof(ItemBP)]; } set { this[nameof(ItemBP)] = value; } }
    }
    public class CursorSettings : Object
    {
        public CursorSettings(nint addr) : base(addr) { }
        public float Acceleration { get { return this[nameof(Acceleration)].GetValue<float>(); } set { this[nameof(Acceleration)].SetValue<float>(value); } }
        public float MaxSpeed { get { return this[nameof(MaxSpeed)].GetValue<float>(); } set { this[nameof(MaxSpeed)].SetValue<float>(value); } }
        public float SpeedFloor { get { return this[nameof(SpeedFloor)].GetValue<float>(); } set { this[nameof(SpeedFloor)].SetValue<float>(value); } }
        public float DeadZone { get { return this[nameof(DeadZone)].GetValue<float>(); } set { this[nameof(DeadZone)].SetValue<float>(value); } }
        public EAnalogCursorMovementMode CursorMovementMode { get { return (EAnalogCursorMovementMode)this[nameof(CursorMovementMode)].GetValue<int>(); } set { this[nameof(CursorMovementMode)].SetValue<int>((int)value); } }
        public int DoubleClickDelay { get { return this[nameof(DoubleClickDelay)].GetValue<int>(); } set { this[nameof(DoubleClickDelay)].SetValue<int>(value); } }
        public float SlowdownAccelerationScalar { get { return this[nameof(SlowdownAccelerationScalar)].GetValue<float>(); } set { this[nameof(SlowdownAccelerationScalar)].SetValue<float>(value); } }
        public float SlowdownAccelerationTimeout { get { return this[nameof(SlowdownAccelerationTimeout)].GetValue<float>(); } set { this[nameof(SlowdownAccelerationTimeout)].SetValue<float>(value); } }
        public float GravityIdleDelay { get { return this[nameof(GravityIdleDelay)].GetValue<float>(); } set { this[nameof(GravityIdleDelay)].SetValue<float>(value); } }
        public float GravityDistanceToAnchorTolerance { get { return this[nameof(GravityDistanceToAnchorTolerance)].GetValue<float>(); } set { this[nameof(GravityDistanceToAnchorTolerance)].SetValue<float>(value); } }
        public float GravityMaxDistanceNormalized { get { return this[nameof(GravityMaxDistanceNormalized)].GetValue<float>(); } set { this[nameof(GravityMaxDistanceNormalized)].SetValue<float>(value); } }
        public float CursorTargetFrictionMod { get { return this[nameof(CursorTargetFrictionMod)].GetValue<float>(); } set { this[nameof(CursorTargetFrictionMod)].SetValue<float>(value); } }
        public float AnalogSnapThreshold { get { return this[nameof(AnalogSnapThreshold)].GetValue<float>(); } set { this[nameof(AnalogSnapThreshold)].SetValue<float>(value); } }
        public int AnalogSnapWindow { get { return this[nameof(AnalogSnapWindow)].GetValue<int>(); } set { this[nameof(AnalogSnapWindow)].SetValue<int>(value); } }
        public int AnalogSnapToleranceTime { get { return this[nameof(AnalogSnapToleranceTime)].GetValue<int>(); } set { this[nameof(AnalogSnapToleranceTime)].SetValue<int>(value); } }
        public int AnalogPostSnapCooldown { get { return this[nameof(AnalogPostSnapCooldown)].GetValue<int>(); } set { this[nameof(AnalogPostSnapCooldown)].SetValue<int>(value); } }
        public float AnalogSnapAngleToDistanceWeight { get { return this[nameof(AnalogSnapAngleToDistanceWeight)].GetValue<float>(); } set { this[nameof(AnalogSnapAngleToDistanceWeight)].SetValue<float>(value); } }
        public float AnalogSnapAngleRange { get { return this[nameof(AnalogSnapAngleRange)].GetValue<float>(); } set { this[nameof(AnalogSnapAngleRange)].SetValue<float>(value); } }
        public float AnalogSnapMaxDistanceNormalized { get { return this[nameof(AnalogSnapMaxDistanceNormalized)].GetValue<float>(); } set { this[nameof(AnalogSnapMaxDistanceNormalized)].SetValue<float>(value); } }
        public float AnalogSnapMinDistance { get { return this[nameof(AnalogSnapMinDistance)].GetValue<float>(); } set { this[nameof(AnalogSnapMinDistance)].SetValue<float>(value); } }
        public float RepeatSnapThresholdMod { get { return this[nameof(RepeatSnapThresholdMod)].GetValue<float>(); } set { this[nameof(RepeatSnapThresholdMod)].SetValue<float>(value); } }
        public float RepeatSnapTimeout { get { return this[nameof(RepeatSnapTimeout)].GetValue<float>(); } set { this[nameof(RepeatSnapTimeout)].SetValue<float>(value); } }
        public bool bLerpOnManualSnap { get { return this[nameof(bLerpOnManualSnap)].Flag; } set { this[nameof(bLerpOnManualSnap)].Flag = value; } }
        public bool bLerpOnControllerSnap { get { return this[nameof(bLerpOnControllerSnap)].Flag; } set { this[nameof(bLerpOnControllerSnap)].Flag = value; } }
        public float LerpOnSnapSpeedRelative { get { return this[nameof(LerpOnSnapSpeedRelative)].GetValue<float>(); } set { this[nameof(LerpOnSnapSpeedRelative)].SetValue<float>(value); } }
        public int MinLerpFrames { get { return this[nameof(MinLerpFrames)].GetValue<int>(); } set { this[nameof(MinLerpFrames)].SetValue<int>(value); } }
        public EAnalogCursorMovementMode CursorLerpMovementMode { get { return (EAnalogCursorMovementMode)this[nameof(CursorLerpMovementMode)].GetValue<int>(); } set { this[nameof(CursorLerpMovementMode)].SetValue<int>((int)value); } }
    }
    public class PersistentBuff : Object
    {
        public PersistentBuff(nint addr) : base(addr) { }
        public SoftClassPath ActionClass { get { return this[nameof(ActionClass)].As<SoftClassPath>(); } set { this["ActionClass"] = value; } }
        public float RemainingTime { get { return this[nameof(RemainingTime)].GetValue<float>(); } set { this[nameof(RemainingTime)].SetValue<float>(value); } }
        public int Level { get { return this[nameof(Level)].GetValue<int>(); } set { this[nameof(Level)].SetValue<int>(value); } }
    }
    public class TacticalGraphPath : Object
    {
        public TacticalGraphPath(nint addr) : base(addr) { }
        public Array<AITacticalPoint> Points { get { return new Array<AITacticalPoint>(this[nameof(Points)].Address); } }
    }
    public class TacticalGraphQuery : Object
    {
        public TacticalGraphQuery(nint addr) : base(addr) { }
        public Object Params { get { return this[nameof(Params)]; } set { this[nameof(Params)] = value; } }
        public TacticalGraphPath Result { get { return this[nameof(Result)].As<TacticalGraphPath>(); } set { this["Result"] = value; } }
    }
    public class EmoteIconState : Object
    {
        public EmoteIconState(nint addr) : base(addr) { }
        public Object Emote { get { return this[nameof(Emote)]; } set { this[nameof(Emote)] = value; } }
        public Texture2D Icon { get { return this[nameof(Icon)].As<Texture2D>(); } set { this["Icon"] = value; } }
        public Array<Object> Reasons { get { return new Array<Object>(this[nameof(Reasons)].Address); } }
    }
    public class SavedEquipmentVisual : Object
    {
        public SavedEquipmentVisual(nint addr) : base(addr) { }
        public SoftClassPath EquipmentPath { get { return this[nameof(EquipmentPath)].As<SoftClassPath>(); } set { this["EquipmentPath"] = value; } }
        public SoftClassPath SkinEquipmentPath { get { return this[nameof(SkinEquipmentPath)].As<SoftClassPath>(); } set { this["SkinEquipmentPath"] = value; } }
        public byte EquipmentLevel { get { return this[nameof(EquipmentLevel)].GetValue<byte>(); } set { this[nameof(EquipmentLevel)].SetValue<byte>(value); } }
    }
    public class AccountAwardInstance : Object
    {
        public AccountAwardInstance(nint addr) : base(addr) { }
        public Object AccountAward { get { return this[nameof(AccountAward)]; } set { this[nameof(AccountAward)] = value; } }
        public bool bHasBeenAwarded { get { return this[nameof(bHasBeenAwarded)].Flag; } set { this[nameof(bHasBeenAwarded)].Flag = value; } }
        public bool bIsInitialAward { get { return this[nameof(bIsInitialAward)].Flag; } set { this[nameof(bIsInitialAward)].Flag = value; } }
    }
    public class EntitlementRequirements : Object
    {
        public EntitlementRequirements(nint addr) : base(addr) { }
        public Array<Object> Entitlements { get { return new Array<Object>(this[nameof(Entitlements)].Address); } }
    }
    public class ArchetypeEntitlement : Object
    {
        public ArchetypeEntitlement(nint addr) : base(addr) { }
        public Object Archetype { get { return this[nameof(Archetype)]; } set { this[nameof(Archetype)] = value; } }
        public EntitlementRequirements Requirements { get { return this[nameof(Requirements)].As<EntitlementRequirements>(); } set { this["Requirements"] = value; } }
    }
    public class ItemEntitlement : Object
    {
        public ItemEntitlement(nint addr) : base(addr) { }
        public Object Item { get { return this[nameof(Item)]; } set { this[nameof(Item)] = value; } }
        public bool bAllowRevoke { get { return this[nameof(bAllowRevoke)].Flag; } set { this[nameof(bAllowRevoke)].Flag = value; } }
        public EntitlementRequirements Requirements { get { return this[nameof(Requirements)].As<EntitlementRequirements>(); } set { this["Requirements"] = value; } }
    }
    public class EntitlementInstance : Object
    {
        public EntitlementInstance(nint addr) : base(addr) { }
        public Object AccountAward { get { return this[nameof(AccountAward)]; } set { this[nameof(AccountAward)] = value; } }
        public Object Entitlement { get { return this[nameof(Entitlement)]; } set { this[nameof(Entitlement)] = value; } }
    }
    public class AccountCurrencyInstance : Object
    {
        public AccountCurrencyInstance(nint addr) : base(addr) { }
        public Object CurrencyType { get { return this[nameof(CurrencyType)]; } set { this[nameof(CurrencyType)] = value; } }
        public int Quantity { get { return this[nameof(Quantity)].GetValue<int>(); } set { this[nameof(Quantity)].SetValue<int>(value); } }
    }
    public class SkyboxModifierVolumeInfo : Object
    {
        public SkyboxModifierVolumeInfo(nint addr) : base(addr) { }
        public Actor ModifierVolume { get { return this[nameof(ModifierVolume)].As<Actor>(); } set { this["ModifierVolume"] = value; } }
        public Array<Actor> PlayersInVolume { get { return new Array<Actor>(this[nameof(PlayersInVolume)].Address); } }
    }
    public class RemnantMaterialParam : Object
    {
        public RemnantMaterialParam(nint addr) : base(addr) { }
        public ERemnantMaterialInputType InputType { get { return (ERemnantMaterialInputType)this[nameof(InputType)].GetValue<int>(); } set { this[nameof(InputType)].SetValue<int>((int)value); } }
        public float ScalarValue { get { return this[nameof(ScalarValue)].GetValue<float>(); } set { this[nameof(ScalarValue)].SetValue<float>(value); } }
        public LinearColor ColorValue { get { return this[nameof(ColorValue)].As<LinearColor>(); } set { this["ColorValue"] = value; } }
        public CurveFloat ScalarCurveFilter { get { return this[nameof(ScalarCurveFilter)].As<CurveFloat>(); } set { this["ScalarCurveFilter"] = value; } }
        public CurveLinearColor ColorCurveFilter { get { return this[nameof(ColorCurveFilter)].As<CurveLinearColor>(); } set { this["ColorCurveFilter"] = value; } }
        public ERemnantWeaponMaterialParameterType OutputType { get { return (ERemnantWeaponMaterialParameterType)this[nameof(OutputType)].GetValue<int>(); } set { this[nameof(OutputType)].SetValue<int>((int)value); } }
        public int MaterialIndex { get { return this[nameof(MaterialIndex)].GetValue<int>(); } set { this[nameof(MaterialIndex)].SetValue<int>(value); } }
        public Object ParamName { get { return this[nameof(ParamName)]; } set { this[nameof(ParamName)] = value; } }
    }
    public class BoardUserInfo : Object
    {
        public BoardUserInfo(nint addr) : base(addr) { }
        public EBoardUser CurrentPlayer { get { return (EBoardUser)this[nameof(CurrentPlayer)].GetValue<int>(); } set { this[nameof(CurrentPlayer)].SetValue<int>((int)value); } }
        public Actor PieceActor { get { return this[nameof(PieceActor)].As<Actor>(); } set { this["PieceActor"] = value; } }
    }
    public class BoardPositionInfo : Object
    {
        public BoardPositionInfo(nint addr) : base(addr) { }
        public BoardUserInfo SlotUserInfo { get { return this[nameof(SlotUserInfo)].As<BoardUserInfo>(); } set { this["SlotUserInfo"] = value; } }
        public Object SlotAttachName { get { return this[nameof(SlotAttachName)]; } set { this[nameof(SlotAttachName)] = value; } }
        public bool bSupportsDiagonalMovement { get { return this[nameof(bSupportsDiagonalMovement)].Flag; } set { this[nameof(bSupportsDiagonalMovement)].Flag = value; } }
        public SceneComponent SlotPosition { get { return this[nameof(SlotPosition)].As<SceneComponent>(); } set { this["SlotPosition"] = value; } }
    }
    public class CachedUserPiecePositions : Object
    {
        public CachedUserPiecePositions(nint addr) : base(addr) { }
        public Array<GraphPosition> PiecePositions { get { return new Array<GraphPosition>(this[nameof(PiecePositions)].Address); } }
    }
    public class CachedPotentialMovePieceInfo : Object
    {
        public CachedPotentialMovePieceInfo(nint addr) : base(addr) { }
        public Actor MovePieceVisualActor { get { return this[nameof(MovePieceVisualActor)].As<Actor>(); } set { this["MovePieceVisualActor"] = value; } }
        public GraphPosition Position { get { return this[nameof(Position)].As<GraphPosition>(); } set { this["Position"] = value; } }
        public GraphPosition RootPosition { get { return this[nameof(RootPosition)].As<GraphPosition>(); } set { this["RootPosition"] = value; } }
        public Vector WorldPosition { get { return this[nameof(WorldPosition)].As<Vector>(); } set { this["WorldPosition"] = value; } }
    }
    public class BoardRow : Object
    {
        public BoardRow(nint addr) : base(addr) { }
        public Array<BoardPositionInfo> BoardRow_value { get { return new Array<BoardPositionInfo>(this[nameof(BoardRow)].Address); } }
    }
    public class BoardRules : Object
    {
        public BoardRules(nint addr) : base(addr) { }
        public int PiecesPerPlayer { get { return this[nameof(PiecesPerPlayer)].GetValue<int>(); } set { this[nameof(PiecesPerPlayer)].SetValue<int>(value); } }
        public EBoardUser UserWithFirstMove { get { return (EBoardUser)this[nameof(UserWithFirstMove)].GetValue<int>(); } set { this[nameof(UserWithFirstMove)].SetValue<int>((int)value); } }
        public int PlayerHasFirstMoveChance { get { return this[nameof(PlayerHasFirstMoveChance)].GetValue<int>(); } set { this[nameof(PlayerHasFirstMoveChance)].SetValue<int>(value); } }
    }
    public class OnlineSessionDetailsRemnant : Object
    {
        public OnlineSessionDetailsRemnant(nint addr) : base(addr) { }
        public ERemnantCharacterType CharacterType { get { return (ERemnantCharacterType)this[nameof(CharacterType)].GetValue<int>(); } set { this[nameof(CharacterType)].SetValue<int>((int)value); } }
        public int PowerLevel { get { return this[nameof(PowerLevel)].GetValue<int>(); } set { this[nameof(PowerLevel)].SetValue<int>(value); } }
        public int Difficulty { get { return this[nameof(Difficulty)].GetValue<int>(); } set { this[nameof(Difficulty)].SetValue<int>(value); } }
        public EQuestMode GameMode { get { return (EQuestMode)this[nameof(GameMode)].GetValue<int>(); } set { this[nameof(GameMode)].SetValue<int>((int)value); } }
        public int NumPlayers { get { return this[nameof(NumPlayers)].GetValue<int>(); } set { this[nameof(NumPlayers)].SetValue<int>(value); } }
        public Object CheckpointBiome { get { return this[nameof(CheckpointBiome)]; } set { this[nameof(CheckpointBiome)] = value; } }
        public Object CheckpointLabel { get { return this[nameof(CheckpointLabel)]; } set { this[nameof(CheckpointLabel)] = value; } }
        public Object CheckpointImage { get { return this[nameof(CheckpointImage)]; } set { this[nameof(CheckpointImage)] = value; } }
        public EMatchmakingPlatform Platform { get { return (EMatchmakingPlatform)this[nameof(Platform)].GetValue<int>(); } set { this[nameof(Platform)].SetValue<int>((int)value); } }
    }
    public class GenericDropInfo : Object
    {
        public GenericDropInfo(nint addr) : base(addr) { }
        public bool HasTarget { get { return this[nameof(HasTarget)].Flag; } set { this[nameof(HasTarget)].Flag = value; } }
        public Actor Target { get { return this[nameof(Target)].As<Actor>(); } set { this["Target"] = value; } }
        public bool TargetIsHost { get { return this[nameof(TargetIsHost)].Flag; } set { this[nameof(TargetIsHost)].Flag = value; } }
        public SpawnList CachedSpawnList { get { return this[nameof(CachedSpawnList)].As<SpawnList>(); } set { this["CachedSpawnList"] = value; } }
    }
    public class LootContainerItem : Object
    {
        public LootContainerItem(nint addr) : base(addr) { }
        public Object ItemBP { get { return this[nameof(ItemBP)]; } set { this[nameof(ItemBP)] = value; } }
        public byte Quantity { get { return this[nameof(Quantity)].GetValue<byte>(); } set { this[nameof(Quantity)].SetValue<byte>(value); } }
    }
    public class LoreTokenPair : Object
    {
        public LoreTokenPair(nint addr) : base(addr) { }
        public Object TokenPairs { get { return this[nameof(TokenPairs)]; } set { this[nameof(TokenPairs)] = value; } }
    }
    public class LoreImageSetData : Object
    {
        public LoreImageSetData(nint addr) : base(addr) { }
        public ImageSet ImageSet { get { return this[nameof(ImageSet)].As<ImageSet>(); } set { this["ImageSet"] = value; } }
    }
    public class LorePage : Object
    {
        public LorePage(nint addr) : base(addr) { }
        public Object Text { get { return this[nameof(Text)]; } set { this[nameof(Text)] = value; } }
        public Texture2D Image { get { return this[nameof(Image)].As<Texture2D>(); } set { this["Image"] = value; } }
        public SoftSoundGunfire Audio { get { return this[nameof(Audio)].As<SoftSoundGunfire>(); } set { this["Audio"] = value; } }
        public bool NotifyOnRead { get { return this[nameof(NotifyOnRead)].Flag; } set { this[nameof(NotifyOnRead)].Flag = value; } }
        public Object NotifyQuestNameID { get { return this[nameof(NotifyQuestNameID)]; } set { this[nameof(NotifyQuestNameID)] = value; } }
        public Object NotifyQuestEvent { get { return this[nameof(NotifyQuestEvent)]; } set { this[nameof(NotifyQuestEvent)] = value; } }
        public int SubPage { get { return this[nameof(SubPage)].GetValue<int>(); } set { this[nameof(SubPage)].SetValue<int>(value); } }
        public Object AltModeTokens { get { return this[nameof(AltModeTokens)]; } set { this[nameof(AltModeTokens)] = value; } }
        public Texture2D AltModeImage { get { return this[nameof(AltModeImage)].As<Texture2D>(); } set { this["AltModeImage"] = value; } }
    }
    public class LoadableModAsset : Object
    {
        public LoadableModAsset(nint addr) : base(addr) { }
        public Object AssetName { get { return this[nameof(AssetName)]; } set { this[nameof(AssetName)] = value; } }
        public SoftObjectPath Asset { get { return this[nameof(Asset)].As<SoftObjectPath>(); } set { this["Asset"] = value; } }
        public Object AssetClass { get { return this[nameof(AssetClass)]; } set { this[nameof(AssetClass)] = value; } }
        public Object Reference { get { return this[nameof(Reference)].As<Object>(); } set { this["Reference"] = value; } }
        public Object ClassReference { get { return this[nameof(ClassReference)].As<Object>(); } set { this["ClassReference"] = value; } } // ClassPtrProperty
    }
    public class SmartAmmo : Object
    {
        public SmartAmmo(nint addr) : base(addr) { }
        public Object AmmoType { get { return this[nameof(AmmoType)]; } set { this[nameof(AmmoType)] = value; } }
        public float QuantityRef { get { return this[nameof(QuantityRef)].GetValue<float>(); } set { this[nameof(QuantityRef)].SetValue<float>(value); } }
        public float Scalar { get { return this[nameof(Scalar)].GetValue<float>(); } set { this[nameof(Scalar)].SetValue<float>(value); } }
        public int QuantityMin { get { return this[nameof(QuantityMin)].GetValue<int>(); } set { this[nameof(QuantityMin)].SetValue<int>(value); } }
        public int QuantityMax { get { return this[nameof(QuantityMax)].GetValue<int>(); } set { this[nameof(QuantityMax)].SetValue<int>(value); } }
    }
    public class TraitSortPriorityField : Object
    {
        public TraitSortPriorityField(nint addr) : base(addr) { }
        public ETraitSortType SortType { get { return (ETraitSortType)this[nameof(SortType)].GetValue<int>(); } set { this[nameof(SortType)].SetValue<int>((int)value); } }
        public int SortPriority { get { return this[nameof(SortPriority)].GetValue<int>(); } set { this[nameof(SortPriority)].SetValue<int>(value); } }
    }
    public class TraitOrderRow : TableRowBase
    {
        public TraitOrderRow(nint addr) : base(addr) { }
        public Object Trait { get { return this[nameof(Trait)]; } set { this[nameof(Trait)] = value; } }
    }
    public class RemnantQuestBreadcrumb : Object
    {
        public RemnantQuestBreadcrumb(nint addr) : base(addr) { }
        public Object NameID { get { return this[nameof(NameID)]; } set { this[nameof(NameID)] = value; } }
        public Object Waypoint { get { return this[nameof(Waypoint)]; } set { this[nameof(Waypoint)] = value; } }
        public Object Objective { get { return this[nameof(Objective)]; } set { this[nameof(Objective)] = value; } }
        public Object Objective2 { get { return this[nameof(Objective2)]; } set { this[nameof(Objective2)] = value; } }
        public bool Secondary { get { return this[nameof(Secondary)].Flag; } set { this[nameof(Secondary)].Flag = value; } }
        public bool CanSkip { get { return this[nameof(CanSkip)].Flag; } set { this[nameof(CanSkip)].Flag = value; } }
        public bool RequireAllSecondaryComplete { get { return this[nameof(RequireAllSecondaryComplete)].Flag; } set { this[nameof(RequireAllSecondaryComplete)].Flag = value; } }
        public Object RequiredQuestItemBP { get { return this[nameof(RequiredQuestItemBP)]; } set { this[nameof(RequiredQuestItemBP)] = value; } }
        public bool SuperHack { get { return this[nameof(SuperHack)].Flag; } set { this[nameof(SuperHack)].Flag = value; } }
    }
    public class RemnantQuestBreadcrumbInfo : Object
    {
        public RemnantQuestBreadcrumbInfo(nint addr) : base(addr) { }
        public bool Visited { get { return this[nameof(Visited)].Flag; } set { this[nameof(Visited)].Flag = value; } }
        public bool HasRequirements { get { return this[nameof(HasRequirements)].Flag; } set { this[nameof(HasRequirements)].Flag = value; } }
    }
    public class RemnantQuestEntityInfo : Object
    {
        public RemnantQuestEntityInfo(nint addr) : base(addr) { }
        public SpawnEntry SpawnEntry { get { return this[nameof(SpawnEntry)].As<SpawnEntry>(); } set { this["SpawnEntry"] = value; } }
        public PersistenceKey Key { get { return this[nameof(Key)].As<PersistenceKey>(); } set { this["Key"] = value; } }
        public bool Destroyed { get { return this[nameof(Destroyed)].Flag; } set { this[nameof(Destroyed)].Flag = value; } }
        public int Seed { get { return this[nameof(Seed)].GetValue<int>(); } set { this[nameof(Seed)].SetValue<int>(value); } }
        public Object Actor { get { return this[nameof(Actor)]; } set { this[nameof(Actor)] = value; } }
    }
    public class RemnantQuestEntry : Object
    {
        public RemnantQuestEntry(nint addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public Object Label { get { return this[nameof(Label)]; } set { this[nameof(Label)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public Object Icon { get { return this[nameof(Icon)]; } set { this[nameof(Icon)] = value; } }
        public Object QuestBP { get { return this[nameof(QuestBP)]; } set { this[nameof(QuestBP)] = value; } }
        public ERemnantQuestType Type { get { return (ERemnantQuestType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public ERemnantQuestRarity Rarity { get { return (ERemnantQuestRarity)this[nameof(Rarity)].GetValue<int>(); } set { this[nameof(Rarity)].SetValue<int>((int)value); } }
        public Array<Object> QuestTags { get { return new Array<Object>(this[nameof(QuestTags)].Address); } }
        public Array<Object> ParentQuestTags { get { return new Array<Object>(this[nameof(ParentQuestTags)].Address); } }
        public int MaxUsageCount { get { return this[nameof(MaxUsageCount)].GetValue<int>(); } set { this[nameof(MaxUsageCount)].SetValue<int>(value); } }
        public ERemnantQuestDebugState DebugState { get { return (ERemnantQuestDebugState)this[nameof(DebugState)].GetValue<int>(); } set { this[nameof(DebugState)].SetValue<int>((int)value); } }
        public EQuestMode QuestGameMode { get { return (EQuestMode)this[nameof(QuestGameMode)].GetValue<int>(); } set { this[nameof(QuestGameMode)].SetValue<int>((int)value); } }
        public Object RequiredAward { get { return this[nameof(RequiredAward)]; } set { this[nameof(RequiredAward)] = value; } }
    }
    public class QuestTileDependency : Object
    {
        public QuestTileDependency(nint addr) : base(addr) { }
        public Object RelativeTileNameID { get { return this[nameof(RelativeTileNameID)]; } set { this[nameof(RelativeTileNameID)] = value; } }
        public int MinDistance { get { return this[nameof(MinDistance)].GetValue<int>(); } set { this[nameof(MinDistance)].SetValue<int>(value); } }
        public int MaxDistance { get { return this[nameof(MaxDistance)].GetValue<int>(); } set { this[nameof(MaxDistance)].SetValue<int>(value); } }
    }
    public class EncounterWave : Object
    {
        public EncounterWave(nint addr) : base(addr) { }
        public Object NameID { get { return this[nameof(NameID)]; } set { this[nameof(NameID)] = value; } }
        public Object InvokeEventOnWaveStart { get { return this[nameof(InvokeEventOnWaveStart)]; } set { this[nameof(InvokeEventOnWaveStart)] = value; } }
        public Object InvokeEventOnWaveComplete { get { return this[nameof(InvokeEventOnWaveComplete)]; } set { this[nameof(InvokeEventOnWaveComplete)] = value; } }
        public float StartDelayMin { get { return this[nameof(StartDelayMin)].GetValue<float>(); } set { this[nameof(StartDelayMin)].SetValue<float>(value); } }
        public float StartDelayMax { get { return this[nameof(StartDelayMax)].GetValue<float>(); } set { this[nameof(StartDelayMax)].SetValue<float>(value); } }
        public Array<Object> SpawnTags { get { return new Array<Object>(this[nameof(SpawnTags)].Address); } }
    }
    public class ArchetypeNameCombo : TableRowBase
    {
        public ArchetypeNameCombo(nint addr) : base(addr) { }
        public Object ArchetypeA { get { return this[nameof(ArchetypeA)]; } set { this[nameof(ArchetypeA)] = value; } }
        public Object ArchetypeB { get { return this[nameof(ArchetypeB)]; } set { this[nameof(ArchetypeB)] = value; } }
        public Object ComboName { get { return this[nameof(ComboName)]; } set { this[nameof(ComboName)] = value; } }
    }
    public class ArchetypeStartingTrait : Object
    {
        public ArchetypeStartingTrait(nint addr) : base(addr) { }
        public int StartingLevel { get { return this[nameof(StartingLevel)].GetValue<int>(); } set { this[nameof(StartingLevel)].SetValue<int>(value); } }
        public Object Trait { get { return this[nameof(Trait)]; } set { this[nameof(Trait)] = value; } }
    }
    public class AssetPackageRedirection : Object
    {
        public AssetPackageRedirection(nint addr) : base(addr) { }
        public int CurrentPakId { get { return this[nameof(CurrentPakId)].GetValue<int>(); } set { this[nameof(CurrentPakId)].SetValue<int>(value); } }
        public int RedirectedPakId { get { return this[nameof(RedirectedPakId)].GetValue<int>(); } set { this[nameof(RedirectedPakId)].SetValue<int>(value); } }
        public Array<DirectoryPath> DirectoriesToRedirect { get { return new Array<DirectoryPath>(this[nameof(DirectoriesToRedirect)].Address); } }
        public Array<SoftObjectPath> AssetsToRedirect { get { return new Array<SoftObjectPath>(this[nameof(AssetsToRedirect)].Address); } }
    }
    public class PlayerSpawnPrerequisites : Object
    {
        public PlayerSpawnPrerequisites(nint addr) : base(addr) { }
        public short NumLoadedQuestsRequired { get { return this[nameof(NumLoadedQuestsRequired)].GetValue<short>(); } set { this[nameof(NumLoadedQuestsRequired)].SetValue<short>(value); } }
        public short NumReadyQuestsRequired { get { return this[nameof(NumReadyQuestsRequired)].GetValue<short>(); } set { this[nameof(NumReadyQuestsRequired)].SetValue<short>(value); } }
        public short NumReadyZonesRequired { get { return this[nameof(NumReadyZonesRequired)].GetValue<short>(); } set { this[nameof(NumReadyZonesRequired)].SetValue<short>(value); } }
    }
    public class BookPage : Object
    {
        public BookPage(nint addr) : base(addr) { }
        public Object Text { get { return this[nameof(Text)]; } set { this[nameof(Text)] = value; } }
        public Texture2D Image { get { return this[nameof(Image)].As<Texture2D>(); } set { this["Image"] = value; } }
        public bool NotifyOnRead { get { return this[nameof(NotifyOnRead)].Flag; } set { this[nameof(NotifyOnRead)].Flag = value; } }
        public int SubPage { get { return this[nameof(SubPage)].GetValue<int>(); } set { this[nameof(SubPage)].SetValue<int>(value); } }
        public int LorePage { get { return this[nameof(LorePage)].GetValue<int>(); } set { this[nameof(LorePage)].SetValue<int>(value); } }
    }
    public class RemnantClientInventoryChangeInfo : Object
    {
        public RemnantClientInventoryChangeInfo(nint addr) : base(addr) { }
    }
    public class RemnantCharacterStatData : StatData
    {
        public RemnantCharacterStatData(nint addr) : base(addr) { }
        public int ExperienceValue { get { return this[nameof(ExperienceValue)].GetValue<int>(); } set { this[nameof(ExperienceValue)].SetValue<int>(value); } }
        public int HealthMax { get { return this[nameof(HealthMax)].GetValue<int>(); } set { this[nameof(HealthMax)].SetValue<int>(value); } }
        public int HealthMaxMod { get { return this[nameof(HealthMaxMod)].GetValue<int>(); } set { this[nameof(HealthMaxMod)].SetValue<int>(value); } }
        public float HealthRegen { get { return this[nameof(HealthRegen)].GetValue<float>(); } set { this[nameof(HealthRegen)].SetValue<float>(value); } }
        public int StaminaMax { get { return this[nameof(StaminaMax)].GetValue<int>(); } set { this[nameof(StaminaMax)].SetValue<int>(value); } }
        public float StaminaRegen { get { return this[nameof(StaminaRegen)].GetValue<float>(); } set { this[nameof(StaminaRegen)].SetValue<float>(value); } }
        public float StaminaRegenDelay { get { return this[nameof(StaminaRegenDelay)].GetValue<float>(); } set { this[nameof(StaminaRegenDelay)].SetValue<float>(value); } }
        public int WoundedHealthMax { get { return this[nameof(WoundedHealthMax)].GetValue<int>(); } set { this[nameof(WoundedHealthMax)].SetValue<int>(value); } }
        public float WoundedHealthRegen { get { return this[nameof(WoundedHealthRegen)].GetValue<float>(); } set { this[nameof(WoundedHealthRegen)].SetValue<float>(value); } }
        public float WoundedReviveSpeed { get { return this[nameof(WoundedReviveSpeed)].GetValue<float>(); } set { this[nameof(WoundedReviveSpeed)].SetValue<float>(value); } }
        public int Damage { get { return this[nameof(Damage)].GetValue<int>(); } set { this[nameof(Damage)].SetValue<int>(value); } }
        public int DamageMod { get { return this[nameof(DamageMod)].GetValue<int>(); } set { this[nameof(DamageMod)].SetValue<int>(value); } }
        public int Defense { get { return this[nameof(Defense)].GetValue<int>(); } set { this[nameof(Defense)].SetValue<int>(value); } }
    }
    public class GunObstructionParameters : Object
    {
        public GunObstructionParameters(nint addr) : base(addr) { }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public float Distance { get { return this[nameof(Distance)].GetValue<float>(); } set { this[nameof(Distance)].SetValue<float>(value); } }
        public bool bTraceComplex { get { return this[nameof(bTraceComplex)].Flag; } set { this[nameof(bTraceComplex)].Flag = value; } }
        public byte TraceChannel { get { return this[nameof(TraceChannel)].GetValue<byte>(); } set { this[nameof(TraceChannel)].SetValue<byte>(value); } }
        public Vector UpwardTraceLocation { get { return this[nameof(UpwardTraceLocation)].As<Vector>(); } set { this["UpwardTraceLocation"] = value; } }
        public Vector BaseTraceLocation { get { return this[nameof(BaseTraceLocation)].As<Vector>(); } set { this["BaseTraceLocation"] = value; } }
        public Vector DownwardTraceLocation { get { return this[nameof(DownwardTraceLocation)].As<Vector>(); } set { this["DownwardTraceLocation"] = value; } }
        public Vector MaleOffsets { get { return this[nameof(MaleOffsets)].As<Vector>(); } set { this["MaleOffsets"] = value; } }
        public Vector RelativeTraceOffset { get { return this[nameof(RelativeTraceOffset)].As<Vector>(); } set { this["RelativeTraceOffset"] = value; } }
        public Vector LeftAdditionalTraceOffset { get { return this[nameof(LeftAdditionalTraceOffset)].As<Vector>(); } set { this["LeftAdditionalTraceOffset"] = value; } }
    }
    public class CachedAnalogInput : Object
    {
        public CachedAnalogInput(nint addr) : base(addr) { }
    }
    public class PrimaryPingInfo : Object
    {
        public PrimaryPingInfo(nint addr) : base(addr) { }
        public Object SoundSetID { get { return this[nameof(SoundSetID)]; } set { this[nameof(SoundSetID)] = value; } }
        public Texture2D WorldIcon { get { return this[nameof(WorldIcon)].As<Texture2D>(); } set { this["WorldIcon"] = value; } }
        public Color WorldObjectColor { get { return this[nameof(WorldObjectColor)].As<Color>(); } set { this["WorldObjectColor"] = value; } }
    }
    public class ValidationRule : Object
    {
        public ValidationRule(nint addr) : base(addr) { }
        public ValidationTableEntry ValidationEntry { get { return this[nameof(ValidationEntry)].As<ValidationTableEntry>(); } set { this["ValidationEntry"] = value; } }
    }
    public class ValidationSearchEntry : Object
    {
        public ValidationSearchEntry(nint addr) : base(addr) { }
        public Object ItemType { get { return this[nameof(ItemType)]; } set { this[nameof(ItemType)] = value; } }
        public Object ItemClass { get { return this[nameof(ItemClass)]; } set { this[nameof(ItemClass)] = value; } }
        public Object TraitClass { get { return this[nameof(TraitClass)]; } set { this[nameof(TraitClass)] = value; } }
    }
    public class CachedItemInstanceData : Object
    {
        public CachedItemInstanceData(nint addr) : base(addr) { }
    }
    public class ValidateOverTimeInfo : Object
    {
        public ValidateOverTimeInfo(nint addr) : base(addr) { }
    }
    public class CachedItemInfo : Object
    {
        public CachedItemInfo(nint addr) : base(addr) { }
        public Object CachedItemBP { get { return this[nameof(CachedItemBP)]; } set { this[nameof(CachedItemBP)] = value; } }
        public Object SoftItemBP { get { return this[nameof(SoftItemBP)]; } set { this[nameof(SoftItemBP)] = value; } }
        public Object CachedItemType { get { return this[nameof(CachedItemType)]; } set { this[nameof(CachedItemType)] = value; } }
        public Array<CachedItemInstanceData> CachedInstanceData { get { return new Array<CachedItemInstanceData>(this[nameof(CachedInstanceData)].Address); } }
        public CachedItemInstanceData ExceptionInstanceDataMin { get { return this[nameof(ExceptionInstanceDataMin)].As<CachedItemInstanceData>(); } set { this["ExceptionInstanceDataMin"] = value; } }
        public CachedItemInstanceData ExceptionInstanceDataMax { get { return this[nameof(ExceptionInstanceDataMax)].As<CachedItemInstanceData>(); } set { this["ExceptionInstanceDataMax"] = value; } }
        public ValidateOverTimeInfo QuantityOverTime { get { return this[nameof(QuantityOverTime)].As<ValidateOverTimeInfo>(); } set { this["QuantityOverTime"] = value; } }
    }
    public class CachedTraitInfo : Object
    {
        public CachedTraitInfo(nint addr) : base(addr) { }
        public Object CachedTraitBP { get { return this[nameof(CachedTraitBP)]; } set { this[nameof(CachedTraitBP)] = value; } }
        public Object SoftTraitBP { get { return this[nameof(SoftTraitBP)]; } set { this[nameof(SoftTraitBP)] = value; } }
    }
    public class CachedProgressionInfo : Object
    {
        public CachedProgressionInfo(nint addr) : base(addr) { }
        public ValidateOverTimeInfo ExperienceOverTime { get { return this[nameof(ExperienceOverTime)].As<ValidateOverTimeInfo>(); } set { this["ExperienceOverTime"] = value; } }
    }
    public class CachedValidationInfo : Object
    {
        public CachedValidationInfo(nint addr) : base(addr) { }
        public Object CachedItems { get { return this[nameof(CachedItems)]; } set { this[nameof(CachedItems)] = value; } }
        public Object CachedTraits { get { return this[nameof(CachedTraits)]; } set { this[nameof(CachedTraits)] = value; } }
        public CachedProgressionInfo CachedProgression { get { return this[nameof(CachedProgression)].As<CachedProgressionInfo>(); } set { this["CachedProgression"] = value; } }
    }
    public class InitialItemInfo : Object
    {
        public InitialItemInfo(nint addr) : base(addr) { }
    }
    public class QueuedExceptionInfo : Object
    {
        public QueuedExceptionInfo(nint addr) : base(addr) { }
        public CachedItemInfo QueuedItemInfo { get { return this[nameof(QueuedItemInfo)].As<CachedItemInfo>(); } set { this["QueuedItemInfo"] = value; } }
        public CachedTraitInfo QueuedTraitInfo { get { return this[nameof(QueuedTraitInfo)].As<CachedTraitInfo>(); } set { this["QueuedTraitInfo"] = value; } }
        public CachedProgressionInfo QueuedProgressionInfo { get { return this[nameof(QueuedProgressionInfo)].As<CachedProgressionInfo>(); } set { this["QueuedProgressionInfo"] = value; } }
        public Array<InitialItemInfo> InitialInfoList { get { return new Array<InitialItemInfo>(this[nameof(InitialInfoList)].Address); } }
        public TimerHandle ExceptionTimeOutHandle { get { return this[nameof(ExceptionTimeOutHandle)].As<TimerHandle>(); } set { this["ExceptionTimeOutHandle"] = value; } }
    }
    public class ZoneState : Object
    {
        public ZoneState(nint addr) : base(addr) { }
        public EZoneStatus Status { get { return (EZoneStatus)this[nameof(Status)].GetValue<int>(); } set { this[nameof(Status)].SetValue<int>((int)value); } }
        public Vector LevelOffset { get { return this[nameof(LevelOffset)].As<Vector>(); } set { this["LevelOffset"] = value; } }
        public Object SkyBox { get { return this[nameof(SkyBox)]; } set { this[nameof(SkyBox)] = value; } }
    }
    public class ZoneSkyBoxDef : Object
    {
        public ZoneSkyBoxDef(nint addr) : base(addr) { }
        public VariableStatements ValidateStatements { get { return this[nameof(ValidateStatements)].As<VariableStatements>(); } set { this["ValidateStatements"] = value; } }
        public Object SkyBox { get { return this[nameof(SkyBox)]; } set { this[nameof(SkyBox)] = value; } }
    }
}
