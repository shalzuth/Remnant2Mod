using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.PropertyPathSDK
{
    public class PropertyPathTestObject : Object
    {
        public PropertyPathTestObject(nint addr) : base(addr) { }
        public bool Bool { get { return this[nameof(Bool)].Flag; } set { this[nameof(Bool)].Flag = value; } }
        public byte EnumOne { get { return this[nameof(EnumOne)].GetValue<byte>(); } set { this[nameof(EnumOne)].SetValue<byte>(value); } }
        public byte EnumTwo { get { return this[nameof(EnumTwo)].GetValue<byte>(); } set { this[nameof(EnumTwo)].SetValue<byte>(value); } }
        public byte EnumThree { get { return this[nameof(EnumThree)].GetValue<byte>(); } set { this[nameof(EnumThree)].SetValue<byte>(value); } }
        public byte EnumFour { get { return this[nameof(EnumFour)].GetValue<byte>(); } set { this[nameof(EnumFour)].SetValue<byte>(value); } }
        public int Integer { get { return this[nameof(Integer)].GetValue<int>(); } set { this[nameof(Integer)].SetValue<int>(value); } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
        public float Float { get { return this[nameof(Float)].GetValue<float>(); } set { this[nameof(Float)].SetValue<float>(value); } }
        public PropertyPathTestStruct Struct { get { return this[nameof(Struct)].As<PropertyPathTestStruct>(); } set { this["Struct"] = value; } }
        public PropertyPathTestStruct StructRef { get { return this[nameof(StructRef)].As<PropertyPathTestStruct>(); } set { this["StructRef"] = value; } }
        public PropertyPathTestStruct StructConstRef { get { return this[nameof(StructConstRef)].As<PropertyPathTestStruct>(); } set { this["StructConstRef"] = value; } }
        public PropertyPathTestObject InnerObject { get { return this[nameof(InnerObject)].As<PropertyPathTestObject>(); } set { this["InnerObject"] = value; } }
        public void SetStructRef(PropertyPathTestStruct InStruct) { Invoke(nameof(SetStructRef), InStruct); }
        public void SetStructConstRef(PropertyPathTestStruct InStruct) { Invoke(nameof(SetStructConstRef), InStruct); }
        public void SetStruct(PropertyPathTestStruct InStruct) { Invoke(nameof(SetStruct), InStruct); }
        public void SetFloat(float InFloat) { Invoke(nameof(SetFloat), InFloat); }
        public PropertyPathTestStruct GetStructRef() { return Invoke<PropertyPathTestStruct>(nameof(GetStructRef)); }
        public PropertyPathTestStruct GetStructConstRef() { return Invoke<PropertyPathTestStruct>(nameof(GetStructConstRef)); }
        public PropertyPathTestStruct GetStruct() { return Invoke<PropertyPathTestStruct>(nameof(GetStruct)); }
        public float GetFloat() { return Invoke<float>(nameof(GetFloat)); }
    }
    public enum EPropertyPathTestEnum : int
    {
        One = 0,
        Two = 1,
        Three = 2,
        Four = 3,
        EPropertyPathTestEnum_MAX = 4,
    }
    public class PropertyPathSegment : Object
    {
        public PropertyPathSegment(nint addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public int ArrayIndex { get { return this[nameof(ArrayIndex)].GetValue<int>(); } set { this[nameof(ArrayIndex)].SetValue<int>(value); } }
        public Struct Struct { get { return this[nameof(Struct)].As<Struct>(); } set { this["Struct"] = value; } }
    }
    public class CachedPropertyPath : Object
    {
        public CachedPropertyPath(nint addr) : base(addr) { }
        public Array<PropertyPathSegment> Segments { get { return new Array<PropertyPathSegment>(this[nameof(Segments)].Address); } }
        public Function CachedFunction { get { return this[nameof(CachedFunction)].As<Function>(); } set { this["CachedFunction"] = value; } }
    }
    public class PropertyPathTestInnerStruct : Object
    {
        public PropertyPathTestInnerStruct(nint addr) : base(addr) { }
        public float Float { get { return this[nameof(Float)].GetValue<float>(); } set { this[nameof(Float)].SetValue<float>(value); } }
        public bool Bool { get { return this[nameof(Bool)].Flag; } set { this[nameof(Bool)].Flag = value; } }
        public byte EnumOne { get { return this[nameof(EnumOne)].GetValue<byte>(); } set { this[nameof(EnumOne)].SetValue<byte>(value); } }
        public byte EnumTwo { get { return this[nameof(EnumTwo)].GetValue<byte>(); } set { this[nameof(EnumTwo)].SetValue<byte>(value); } }
        public byte EnumThree { get { return this[nameof(EnumThree)].GetValue<byte>(); } set { this[nameof(EnumThree)].SetValue<byte>(value); } }
        public byte EnumFour { get { return this[nameof(EnumFour)].GetValue<byte>(); } set { this[nameof(EnumFour)].SetValue<byte>(value); } }
        public int Integer { get { return this[nameof(Integer)].GetValue<int>(); } set { this[nameof(Integer)].SetValue<int>(value); } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
    }
    public class PropertyPathTestStruct : Object
    {
        public PropertyPathTestStruct(nint addr) : base(addr) { }
        public bool Bool { get { return this[nameof(Bool)].Flag; } set { this[nameof(Bool)].Flag = value; } }
        public int Integer { get { return this[nameof(Integer)].GetValue<int>(); } set { this[nameof(Integer)].SetValue<int>(value); } }
        public byte EnumOne { get { return this[nameof(EnumOne)].GetValue<byte>(); } set { this[nameof(EnumOne)].SetValue<byte>(value); } }
        public byte EnumTwo { get { return this[nameof(EnumTwo)].GetValue<byte>(); } set { this[nameof(EnumTwo)].SetValue<byte>(value); } }
        public byte EnumThree { get { return this[nameof(EnumThree)].GetValue<byte>(); } set { this[nameof(EnumThree)].SetValue<byte>(value); } }
        public byte EnumFour { get { return this[nameof(EnumFour)].GetValue<byte>(); } set { this[nameof(EnumFour)].SetValue<byte>(value); } }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
        public float Float { get { return this[nameof(Float)].GetValue<float>(); } set { this[nameof(Float)].SetValue<float>(value); } }
        public PropertyPathTestInnerStruct InnerStruct { get { return this[nameof(InnerStruct)].As<PropertyPathTestInnerStruct>(); } set { this["InnerStruct"] = value; } }
        public PropertyPathTestObject InnerObject { get { return this[nameof(InnerObject)].As<PropertyPathTestObject>(); } set { this["InnerObject"] = value; } }
    }
    public class PropertyPathTestBed : Object
    {
        public PropertyPathTestBed(nint addr) : base(addr) { }
        public PropertyPathTestObject Object { get { return this[nameof(Object)].As<PropertyPathTestObject>(); } set { this["Object"] = value; } }
        public PropertyPathTestObject ModifiedObject { get { return this[nameof(ModifiedObject)].As<PropertyPathTestObject>(); } set { this["ModifiedObject"] = value; } }
        public PropertyPathTestStruct ModifiedStruct { get { return this[nameof(ModifiedStruct)].As<PropertyPathTestStruct>(); } set { this["ModifiedStruct"] = value; } }
        public PropertyPathTestStruct DefaultStruct { get { return this[nameof(DefaultStruct)].As<PropertyPathTestStruct>(); } set { this["DefaultStruct"] = value; } }
    }
}
