using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Engine.TransientSDK
{
    public class ChaosDestructionEvent_SWC : Object
    {
        public ChaosDestructionEvent_SWC(nint addr) : base(addr) { }
        public Vector3f Position { get { return this[nameof(Position)].As<Vector3f>(); } set { this["Position"] = value; } }
        public Vector3f Normal { get { return this[nameof(Normal)].As<Vector3f>(); } set { this["Normal"] = value; } }
        public Vector3f Velocity { get { return this[nameof(Velocity)].As<Vector3f>(); } set { this["Velocity"] = value; } }
        public Vector3f AngularVelocity { get { return this[nameof(AngularVelocity)].As<Vector3f>(); } set { this["AngularVelocity"] = value; } }
        public float ExtentMin { get { return this[nameof(ExtentMin)].GetValue<float>(); } set { this[nameof(ExtentMin)].SetValue<float>(value); } }
        public float ExtentMax { get { return this[nameof(ExtentMax)].GetValue<float>(); } set { this[nameof(ExtentMax)].SetValue<float>(value); } }
        public int ParticleID { get { return this[nameof(ParticleID)].GetValue<int>(); } set { this[nameof(ParticleID)].SetValue<int>(value); } }
        public float Time { get { return this[nameof(Time)].GetValue<float>(); } set { this[nameof(Time)].SetValue<float>(value); } }
        public int Type { get { return this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>(value); } }
    }
    public enum EnumUserSetting : int
    {
    }
}
