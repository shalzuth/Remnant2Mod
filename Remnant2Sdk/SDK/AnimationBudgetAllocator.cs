using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
namespace SDK.Script.AnimationBudgetAllocatorSDK
{
    public class AnimationBudgetBlueprintLibrary : BlueprintFunctionLibrary
    {
        public AnimationBudgetBlueprintLibrary(nint addr) : base(addr) { }
        public void SetAnimationBudgetParameters(Object WorldContextObject, AnimationBudgetAllocatorParameters InParameters) { Invoke(nameof(SetAnimationBudgetParameters), WorldContextObject, InParameters); }
        public void EnableAnimationBudget(Object WorldContextObject, bool bEnabled) { Invoke(nameof(EnableAnimationBudget), WorldContextObject, bEnabled); }
    }
    public class SkeletalMeshComponentBudgeted : SkeletalMeshComponent
    {
        public SkeletalMeshComponentBudgeted(nint addr) : base(addr) { }
        public bool bAutoRegisterWithBudgetAllocator { get { return this[nameof(bAutoRegisterWithBudgetAllocator)].Flag; } set { this[nameof(bAutoRegisterWithBudgetAllocator)].Flag = value; } }
        public bool bAutoCalculateSignificance { get { return this[nameof(bAutoCalculateSignificance)].Flag; } set { this[nameof(bAutoCalculateSignificance)].Flag = value; } }
        public bool bShouldUseActorRenderedFlag { get { return this[nameof(bShouldUseActorRenderedFlag)].Flag; } set { this[nameof(bShouldUseActorRenderedFlag)].Flag = value; } }
        public void SetAutoRegisterWithBudgetAllocator(bool bInAutoRegisterWithBudgetAllocator) { Invoke(nameof(SetAutoRegisterWithBudgetAllocator), bInAutoRegisterWithBudgetAllocator); }
    }
    public class AnimationBudgetAllocatorParameters : Object
    {
        public AnimationBudgetAllocatorParameters(nint addr) : base(addr) { }
        public float BudgetInMs { get { return this[nameof(BudgetInMs)].GetValue<float>(); } set { this[nameof(BudgetInMs)].SetValue<float>(value); } }
        public float MinQuality { get { return this[nameof(MinQuality)].GetValue<float>(); } set { this[nameof(MinQuality)].SetValue<float>(value); } }
        public int MaxTickRate { get { return this[nameof(MaxTickRate)].GetValue<int>(); } set { this[nameof(MaxTickRate)].SetValue<int>(value); } }
        public float WorkUnitSmoothingSpeed { get { return this[nameof(WorkUnitSmoothingSpeed)].GetValue<float>(); } set { this[nameof(WorkUnitSmoothingSpeed)].SetValue<float>(value); } }
        public float AlwaysTickFalloffAggression { get { return this[nameof(AlwaysTickFalloffAggression)].GetValue<float>(); } set { this[nameof(AlwaysTickFalloffAggression)].SetValue<float>(value); } }
        public float InterpolationFalloffAggression { get { return this[nameof(InterpolationFalloffAggression)].GetValue<float>(); } set { this[nameof(InterpolationFalloffAggression)].SetValue<float>(value); } }
        public int InterpolationMaxRate { get { return this[nameof(InterpolationMaxRate)].GetValue<int>(); } set { this[nameof(InterpolationMaxRate)].SetValue<int>(value); } }
        public int MaxInterpolatedComponents { get { return this[nameof(MaxInterpolatedComponents)].GetValue<int>(); } set { this[nameof(MaxInterpolatedComponents)].SetValue<int>(value); } }
        public float InterpolationTickMultiplier { get { return this[nameof(InterpolationTickMultiplier)].GetValue<float>(); } set { this[nameof(InterpolationTickMultiplier)].SetValue<float>(value); } }
        public float InitialEstimatedWorkUnitTimeMs { get { return this[nameof(InitialEstimatedWorkUnitTimeMs)].GetValue<float>(); } set { this[nameof(InitialEstimatedWorkUnitTimeMs)].SetValue<float>(value); } }
        public int MaxTickedOffsreenComponents { get { return this[nameof(MaxTickedOffsreenComponents)].GetValue<int>(); } set { this[nameof(MaxTickedOffsreenComponents)].SetValue<int>(value); } }
        public int StateChangeThrottleInFrames { get { return this[nameof(StateChangeThrottleInFrames)].GetValue<int>(); } set { this[nameof(StateChangeThrottleInFrames)].SetValue<int>(value); } }
        public float BudgetFactorBeforeReducedWork { get { return this[nameof(BudgetFactorBeforeReducedWork)].GetValue<float>(); } set { this[nameof(BudgetFactorBeforeReducedWork)].SetValue<float>(value); } }
        public float BudgetFactorBeforeReducedWorkEpsilon { get { return this[nameof(BudgetFactorBeforeReducedWorkEpsilon)].GetValue<float>(); } set { this[nameof(BudgetFactorBeforeReducedWorkEpsilon)].SetValue<float>(value); } }
        public float BudgetPressureSmoothingSpeed { get { return this[nameof(BudgetPressureSmoothingSpeed)].GetValue<float>(); } set { this[nameof(BudgetPressureSmoothingSpeed)].SetValue<float>(value); } }
        public int ReducedWorkThrottleMinInFrames { get { return this[nameof(ReducedWorkThrottleMinInFrames)].GetValue<int>(); } set { this[nameof(ReducedWorkThrottleMinInFrames)].SetValue<int>(value); } }
        public int ReducedWorkThrottleMaxInFrames { get { return this[nameof(ReducedWorkThrottleMaxInFrames)].GetValue<int>(); } set { this[nameof(ReducedWorkThrottleMaxInFrames)].SetValue<int>(value); } }
        public float BudgetFactorBeforeAggressiveReducedWork { get { return this[nameof(BudgetFactorBeforeAggressiveReducedWork)].GetValue<float>(); } set { this[nameof(BudgetFactorBeforeAggressiveReducedWork)].SetValue<float>(value); } }
        public int ReducedWorkThrottleMaxPerFrame { get { return this[nameof(ReducedWorkThrottleMaxPerFrame)].GetValue<int>(); } set { this[nameof(ReducedWorkThrottleMaxPerFrame)].SetValue<int>(value); } }
        public float BudgetPressureBeforeEmergencyReducedWork { get { return this[nameof(BudgetPressureBeforeEmergencyReducedWork)].GetValue<float>(); } set { this[nameof(BudgetPressureBeforeEmergencyReducedWork)].SetValue<float>(value); } }
        public float AutoCalculatedSignificanceMaxDistance { get { return this[nameof(AutoCalculatedSignificanceMaxDistance)].GetValue<float>(); } set { this[nameof(AutoCalculatedSignificanceMaxDistance)].SetValue<float>(value); } }
    }
}
