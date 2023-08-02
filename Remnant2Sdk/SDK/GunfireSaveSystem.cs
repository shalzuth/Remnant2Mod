using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.DeveloperSettingsSDK;
namespace SDK.Script.GunfireSaveSystemSDK
{
    public class SaveGamePersistence : SaveGame
    {
        public SaveGamePersistence(nint addr) : base(addr) { }
        public void PreCommit(PersistenceManager PersistenceManager) { Invoke(nameof(PreCommit), PersistenceManager); }
    }
    public class SaveGameProfile : SaveGamePersistence
    {
        public SaveGameProfile(nint addr) : base(addr) { }
        public Array<SaveGameUserSetting> UserSettings { get { return new Array<SaveGameUserSetting>(this[nameof(UserSettings)].Address); } }
        public Array<SaveGameAchievementProgress> AchievementProgress { get { return new Array<SaveGameAchievementProgress>(this[nameof(AchievementProgress)].Address); } }
    }
    public class LevelScriptActorGunfire : LevelScriptActor
    {
        public LevelScriptActorGunfire(nint addr) : base(addr) { }
        public ulong UniqueIDGenerator { get { return this[nameof(UniqueIDGenerator)].GetValue<ulong>(); } set { this[nameof(UniqueIDGenerator)].SetValue<ulong>(value); } }
    }
    public class PersistenceCallbackProxy : BlueprintAsyncActionBase
    {
        public PersistenceCallbackProxy(nint addr) : base(addr) { }
        public PersistenceManager PersistenceManager { get { return this[nameof(PersistenceManager)].As<PersistenceManager>(); } set { this["PersistenceManager"] = value; } }
    }
    public class CommitSaveWithResultCallbackProxy : PersistenceCallbackProxy
    {
        public CommitSaveWithResultCallbackProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public CommitSaveWithResultCallbackProxy CommitSaveWithResult(Object WorldContextObject, Object Reason) { return Invoke<CommitSaveWithResultCallbackProxy>(nameof(CommitSaveWithResult), WorldContextObject, Reason); }
    }
    public class LoadSaveCallbackProxy : PersistenceCallbackProxy
    {
        public LoadSaveCallbackProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public LoadSaveCallbackProxy LoadSave(Object WorldContextObject, int Slot) { return Invoke<LoadSaveCallbackProxy>(nameof(LoadSave), WorldContextObject, Slot); }
    }
    public class LoadProfileSaveCallbackProxy : PersistenceCallbackProxy
    {
        public LoadProfileSaveCallbackProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public LoadProfileSaveCallbackProxy LoadProfileSave(Object WorldContextObject) { return Invoke<LoadProfileSaveCallbackProxy>(nameof(LoadProfileSave), WorldContextObject); }
    }
    public class ReadSaveCallbackProxy : PersistenceCallbackProxy
    {
        public ReadSaveCallbackProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public ReadSaveCallbackProxy ReadSave(Object WorldContextObject, int Slot) { return Invoke<ReadSaveCallbackProxy>(nameof(ReadSave), WorldContextObject, Slot); }
    }
    public class HasSaveCallbackProxy : PersistenceCallbackProxy
    {
        public HasSaveCallbackProxy(nint addr) : base(addr) { }
        public Object OnComplete { get { return this[nameof(OnComplete)]; } set { this[nameof(OnComplete)] = value; } }
        public HasSaveCallbackProxy HasSave(Object WorldContextObject, int Slot) { return Invoke<HasSaveCallbackProxy>(nameof(HasSave), WorldContextObject, Slot); }
    }
    public class DeleteSaveCallbackProxy : PersistenceCallbackProxy
    {
        public DeleteSaveCallbackProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public DeleteSaveCallbackProxy DeleteSave(Object WorldContextObject, int Slot) { return Invoke<DeleteSaveCallbackProxy>(nameof(DeleteSave), WorldContextObject, Slot); }
    }
    public class DeleteProfileSaveCallbackProxy : PersistenceCallbackProxy
    {
        public DeleteProfileSaveCallbackProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public DeleteProfileSaveCallbackProxy DeleteProfileSave(Object WorldContextObject) { return Invoke<DeleteProfileSaveCallbackProxy>(nameof(DeleteProfileSave), WorldContextObject); }
    }
    public class HasProfileBackupCallbackProxy : PersistenceCallbackProxy
    {
        public HasProfileBackupCallbackProxy(nint addr) : base(addr) { }
        public Object HasBackup { get { return this[nameof(HasBackup)]; } set { this[nameof(HasBackup)] = value; } }
        public Object NoBackup { get { return this[nameof(NoBackup)]; } set { this[nameof(NoBackup)] = value; } }
        public HasProfileBackupCallbackProxy HasProfileBackup(Object WorldContextObject) { return Invoke<HasProfileBackupCallbackProxy>(nameof(HasProfileBackup), WorldContextObject); }
    }
    public class RestoreProfileBackupCallbackProxy : PersistenceCallbackProxy
    {
        public RestoreProfileBackupCallbackProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public RestoreProfileBackupCallbackProxy RestoreProfileBackup(Object WorldContextObject) { return Invoke<RestoreProfileBackupCallbackProxy>(nameof(RestoreProfileBackup), WorldContextObject); }
    }
    public class HasSlotBackupCallbackProxy : PersistenceCallbackProxy
    {
        public HasSlotBackupCallbackProxy(nint addr) : base(addr) { }
        public Object HasBackup { get { return this[nameof(HasBackup)]; } set { this[nameof(HasBackup)] = value; } }
        public Object NoBackup { get { return this[nameof(NoBackup)]; } set { this[nameof(NoBackup)] = value; } }
        public HasSlotBackupCallbackProxy HasSlotBackup(Object WorldContextObject, int Slot) { return Invoke<HasSlotBackupCallbackProxy>(nameof(HasSlotBackup), WorldContextObject, Slot); }
    }
    public class RestoreSlotBackupCallbackProxy : PersistenceCallbackProxy
    {
        public RestoreSlotBackupCallbackProxy(nint addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public RestoreSlotBackupCallbackProxy RestoreSlotBackup(Object WorldContextObject, int Slot) { return Invoke<RestoreSlotBackupCallbackProxy>(nameof(RestoreSlotBackup), WorldContextObject, Slot); }
    }
    public class PersistenceBlueprintFunctionLibrary : BlueprintFunctionLibrary
    {
        public PersistenceBlueprintFunctionLibrary(nint addr) : base(addr) { }
        public void SetReference(PersistentReference Reference, Actor InActor) { Invoke(nameof(SetReference), Reference, InActor); }
        public void SetDisableCommit(Object WorldContextObject, bool DisableCommit) { Invoke(nameof(SetDisableCommit), WorldContextObject, DisableCommit); }
        public Actor GetReference(Object WorldContextObject, PersistentReference Reference) { return Invoke<Actor>(nameof(GetReference), WorldContextObject, Reference); }
        public SaveGameProfile GetProfileSave(Object WorldContextObject) { return Invoke<SaveGameProfile>(nameof(GetProfileSave), WorldContextObject); }
        public PersistenceManager GetPersistenceManager(Object WorldContextObject) { return Invoke<PersistenceManager>(nameof(GetPersistenceManager), WorldContextObject); }
        public SaveGameWorld GetCurrentSave(Object WorldContextObject) { return Invoke<SaveGameWorld>(nameof(GetCurrentSave), WorldContextObject); }
        public void CopyReference(PersistentReference From, PersistentReference To) { Invoke(nameof(CopyReference), From, To); }
        public void CommitSave(Object WorldContextObject, Object Reason) { Invoke(nameof(CommitSave), WorldContextObject, Reason); }
        public void ClearReference(PersistentReference Reference) { Invoke(nameof(ClearReference), Reference); }
    }
    public class PersistenceComponent : ActorComponent
    {
        public PersistenceComponent(nint addr) : base(addr) { }
        public ulong UniqueId { get { return this[nameof(UniqueId)].GetValue<ulong>(); } set { this[nameof(UniqueId)].SetValue<ulong>(value); } }
        public Object SaveKey { get { return this[nameof(SaveKey)]; } set { this[nameof(SaveKey)] = value; } }
        public bool HasModifiedSaveValues { get { return this[nameof(HasModifiedSaveValues)].Flag; } set { this[nameof(HasModifiedSaveValues)].Flag = value; } }
        public bool PersistTransform { get { return this[nameof(PersistTransform)].Flag; } set { this[nameof(PersistTransform)].Flag = value; } }
        public bool PersistDestroyed { get { return this[nameof(PersistDestroyed)].Flag; } set { this[nameof(PersistDestroyed)].Flag = value; } }
    }
    public class PersistenceContainer : Object
    {
        public PersistenceContainer(nint addr) : base(addr) { }
        public Object Key { get { return this[nameof(Key)]; } set { this[nameof(Key)] = value; } }
        public PersistenceBlob Blob { get { return this[nameof(Blob)].As<PersistenceBlob>(); } set { this["Blob"] = value; } }
    }
    public class PersistenceSettings : Object
    {
        public PersistenceSettings(nint addr) : base(addr) { }
        public bool AllowEditorSaving { get { return this[nameof(AllowEditorSaving)].Flag; } set { this[nameof(AllowEditorSaving)].Flag = value; } }
        public bool AutomaticallyCreateSave { get { return this[nameof(AutomaticallyCreateSave)].Flag; } set { this[nameof(AutomaticallyCreateSave)].Flag = value; } }
    }
    public class GunfireSaveSystemSettings : DeveloperSettings
    {
        public GunfireSaveSystemSettings(nint addr) : base(addr) { }
        public Object SaveGameClass { get { return this[nameof(SaveGameClass)]; } set { this[nameof(SaveGameClass)] = value; } }
        public Object SaveProfileClass { get { return this[nameof(SaveProfileClass)]; } set { this[nameof(SaveProfileClass)] = value; } }
    }
    public class PersistenceManager : GameInstanceSubsystem
    {
        public PersistenceManager(nint addr) : base(addr) { }
        public Object OnBackgroundWorkBegin { get { return this[nameof(OnBackgroundWorkBegin)]; } set { this[nameof(OnBackgroundWorkBegin)] = value; } }
        public Object OnBackgroundWorkEnd { get { return this[nameof(OnBackgroundWorkEnd)]; } set { this[nameof(OnBackgroundWorkEnd)] = value; } }
        public SaveGameWorld CurrentData { get { return this[nameof(CurrentData)].As<SaveGameWorld>(); } set { this["CurrentData"] = value; } }
        public SaveGameProfile UserProfile { get { return this[nameof(UserProfile)].As<SaveGameProfile>(); } set { this["UserProfile"] = value; } }
        public Object LoadedLevels { get { return this[nameof(LoadedLevels)]; } set { this[nameof(LoadedLevels)] = value; } }
        public Array<Level> CachedUnloads { get { return new Array<Level>(this[nameof(CachedUnloads)].Address); } }
        public Array<Level> CachedLoads { get { return new Array<Level>(this[nameof(CachedLoads)].Address); } }
    }
    public class SaveGameWorld : SaveGamePersistence
    {
        public SaveGameWorld(nint addr) : base(addr) { }
        public bool RequiresFullGame { get { return this[nameof(RequiresFullGame)].Flag; } set { this[nameof(RequiresFullGame)].Flag = value; } }
        public ulong UniqueIDGenerator { get { return this[nameof(UniqueIDGenerator)].GetValue<ulong>(); } set { this[nameof(UniqueIDGenerator)].SetValue<ulong>(value); } }
        public Array<PersistenceContainer> Containers { get { return new Array<PersistenceContainer>(this[nameof(Containers)].Address); } }
    }
    public enum EPersistenceSaveResult : int
    {
        Success = 0,
        Disabled = 1,
        Busy = 2,
        Unknown = 3,
        EPersistenceSaveResult_MAX = 4,
    }
    public enum EPersistenceHasResult : int
    {
        Empty = 0,
        Exists = 1,
        Corrupt = 2,
        Unknown = 3,
        EPersistenceHasResult_MAX = 4,
    }
    public enum EPersistenceLoadResult : int
    {
        Success = 0,
        DoesNotExist = 1,
        Corrupt = 2,
        TooNew = 3,
        Unknown = 4,
        EPersistenceLoadResult_MAX = 5,
    }
    public class PersistenceKey : Object
    {
        public PersistenceKey(nint addr) : base(addr) { }
        public Object ContainerKey { get { return this[nameof(ContainerKey)]; } set { this[nameof(ContainerKey)] = value; } }
        public ulong PersistentID { get { return this[nameof(PersistentID)].GetValue<ulong>(); } set { this[nameof(PersistentID)].SetValue<ulong>(value); } }
    }
    public class PersistenceBlob : Object
    {
        public PersistenceBlob(nint addr) : base(addr) { }
    }
    public class SaveGameUserSetting : Object
    {
        public SaveGameUserSetting(nint addr) : base(addr) { }
        public Object Key { get { return this[nameof(Key)]; } set { this[nameof(Key)] = value; } }
        public Object Value { get { return this[nameof(Value)]; } set { this[nameof(Value)] = value; } }
    }
    public class SaveGameAchievementProgress : Object
    {
        public SaveGameAchievementProgress(nint addr) : base(addr) { }
        public Object AchievementId { get { return this[nameof(AchievementId)]; } set { this[nameof(AchievementId)] = value; } }
        public int Value { get { return this[nameof(Value)].GetValue<int>(); } set { this[nameof(Value)].SetValue<int>(value); } }
    }
    public class PersistentReference : Object
    {
        public PersistentReference(nint addr) : base(addr) { }
        public PersistenceKey Key { get { return this[nameof(Key)].As<PersistenceKey>(); } set { this["Key"] = value; } }
        public Actor CachedActor { get { return this[nameof(CachedActor)].As<Actor>(); } set { this["CachedActor"] = value; } }
    }
}
