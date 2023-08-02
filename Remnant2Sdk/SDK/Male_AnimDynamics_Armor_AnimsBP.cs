using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.AnimGraphRuntimeSDK;
namespace SDK.Game.Characters.Player.Male.Blueprints.Male_AnimDynamics_Armor_AnimsBPSDK
{
    public class AnimBlueprintGeneratedConstantData : AnimBlueprintConstantData
    {
        public AnimBlueprintGeneratedConstantData(nint addr) : base(addr) { }
        public AnimSubsystem_PropertyAccess AnimBlueprintExtension_PropertyAccess { get { return this[nameof(AnimBlueprintExtension_PropertyAccess)].As<AnimSubsystem_PropertyAccess>(); } set { this["AnimBlueprintExtension_PropertyAccess"] = value; } }
        public AnimSubsystem_Base AnimBlueprintExtension_Base { get { return this[nameof(AnimBlueprintExtension_Base)].As<AnimSubsystem_Base>(); } set { this["AnimBlueprintExtension_Base"] = value; } }
    }
    public class AnimBlueprintGeneratedMutableData : AnimBlueprintMutableData
    {
        public AnimBlueprintGeneratedMutableData(nint addr) : base(addr) { }
    }
}
