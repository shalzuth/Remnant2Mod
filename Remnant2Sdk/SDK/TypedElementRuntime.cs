using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.TypedElementRuntimeSDK
{
    public class TypedElementSelectionSetLibrary : Object
    {
        public TypedElementSelectionSetLibrary(nint addr) : base(addr) { }
    }
    public class TypedElementSelectionSet : Object
    {
        public TypedElementSelectionSet(nint addr) : base(addr) { }
    }
    public class TypedElementAssetDataInterface : Interface
    {
        public TypedElementAssetDataInterface(nint addr) : base(addr) { }
    }
    public class TypedElementHierarchyInterface : Interface
    {
        public TypedElementHierarchyInterface(nint addr) : base(addr) { }
    }
    public class TypedElementObjectInterface : Interface
    {
        public TypedElementObjectInterface(nint addr) : base(addr) { }
    }
    public class TypedElementSelectionInterface : Interface
    {
        public TypedElementSelectionInterface(nint addr) : base(addr) { }
    }
    public class TypedElementSelectionOptions : Object
    {
        public TypedElementSelectionOptions(nint addr) : base(addr) { }
        public bool bAllowHidden { get { return this[nameof(bAllowHidden)].Flag; } set { this[nameof(bAllowHidden)].Flag = value; } }
        public bool bAllowGroups { get { return this[nameof(bAllowGroups)].Flag; } set { this[nameof(bAllowGroups)].Flag = value; } }
        public bool bAllowLegacyNotifications { get { return this[nameof(bAllowLegacyNotifications)].Flag; } set { this[nameof(bAllowLegacyNotifications)].Flag = value; } }
        public bool bWarnIfLocked { get { return this[nameof(bWarnIfLocked)].Flag; } set { this[nameof(bWarnIfLocked)].Flag = value; } }
        public ETypedElementChildInclusionMethod ChildElementInclusionMethod { get { return (ETypedElementChildInclusionMethod)this[nameof(ChildElementInclusionMethod)].GetValue<int>(); } set { this[nameof(ChildElementInclusionMethod)].SetValue<int>((int)value); } }
    }
    public enum ETypedElementChildInclusionMethod : int
    {
        None = 0,
        Immediate = 1,
        Recursive = 2,
        ETypedElementChildInclusionMethod_MAX = 3,
    }
    public class TypedElementSelectionSetState : Object
    {
        public TypedElementSelectionSetState(nint addr) : base(addr) { }
        public Object CreatedFromSelectionSet { get { return this[nameof(CreatedFromSelectionSet)]; } set { this[nameof(CreatedFromSelectionSet)] = value; } }
    }
    public enum ETypedElementSelectionMethod : int
    {
        Primary = 0,
        Secondary = 1,
        ETypedElementSelectionMethod_MAX = 2,
    }
    public class TypedElementIsSelectedOptions : Object
    {
        public TypedElementIsSelectedOptions(nint addr) : base(addr) { }
        public bool bAllowIndirect { get { return this[nameof(bAllowIndirect)].Flag; } set { this[nameof(bAllowIndirect)].Flag = value; } }
    }
    public class TypedElementSelectionNormalizationOptions : Object
    {
        public TypedElementSelectionNormalizationOptions(nint addr) : base(addr) { }
        public bool bExpandGroups { get { return this[nameof(bExpandGroups)].Flag; } set { this[nameof(bExpandGroups)].Flag = value; } }
        public bool bFollowAttachment { get { return this[nameof(bFollowAttachment)].Flag; } set { this[nameof(bFollowAttachment)].Flag = value; } }
    }
}
