using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
namespace SDK.Script.GunfireTechRequirementsSDK
{
    public class GunfireTechRequirementsImpl : GameInstanceSubsystem
    {
        public GunfireTechRequirementsImpl(nint addr) : base(addr) { }
        public Object OnFullGameAvailable { get { return this[nameof(OnFullGameAvailable)]; } set { this[nameof(OnFullGameAvailable)] = value; } }
        public Object OnControllerConnectionChanged { get { return this[nameof(OnControllerConnectionChanged)]; } set { this[nameof(OnControllerConnectionChanged)] = value; } }
        public Object OnActiveControllerSet { get { return this[nameof(OnActiveControllerSet)]; } set { this[nameof(OnActiveControllerSet)] = value; } }
        public Object OnActiveProfileSet { get { return this[nameof(OnActiveProfileSet)]; } set { this[nameof(OnActiveProfileSet)] = value; } }
        public Object OnOnlineUnavailable { get { return this[nameof(OnOnlineUnavailable)]; } set { this[nameof(OnOnlineUnavailable)] = value; } }
        public Object OnOnlinePrivilegeChecked { get { return this[nameof(OnOnlinePrivilegeChecked)]; } set { this[nameof(OnOnlinePrivilegeChecked)] = value; } }
        public Object OnQuitToMainMenu { get { return this[nameof(OnQuitToMainMenu)]; } set { this[nameof(OnQuitToMainMenu)] = value; } }
        public Object OnMainMenuLoaded { get { return this[nameof(OnMainMenuLoaded)]; } set { this[nameof(OnMainMenuLoaded)] = value; } }
        public Object OnWaitDialog { get { return this[nameof(OnWaitDialog)]; } set { this[nameof(OnWaitDialog)] = value; } }
        public Object OnActiveProfileLost { get { return this[nameof(OnActiveProfileLost)]; } set { this[nameof(OnActiveProfileLost)] = value; } }
        public Object OnDLCInstallFinished { get { return this[nameof(OnDLCInstallFinished)]; } set { this[nameof(OnDLCInstallFinished)] = value; } }
        public Object OnLegalComplete { get { return this[nameof(OnLegalComplete)]; } set { this[nameof(OnLegalComplete)] = value; } }
        public Object OnDLCEntitlementsUpdated { get { return this[nameof(OnDLCEntitlementsUpdated)]; } set { this[nameof(OnDLCEntitlementsUpdated)] = value; } }
        public Object OnShowStatusEventMessage { get { return this[nameof(OnShowStatusEventMessage)]; } set { this[nameof(OnShowStatusEventMessage)] = value; } }
        public Object OnStatusEventMessageAdded { get { return this[nameof(OnStatusEventMessageAdded)]; } set { this[nameof(OnStatusEventMessageAdded)] = value; } }
        public Object OnShowStatusToastMessage { get { return this[nameof(OnShowStatusToastMessage)]; } set { this[nameof(OnShowStatusToastMessage)] = value; } }
        public Object OnGameActivityRequested { get { return this[nameof(OnGameActivityRequested)]; } set { this[nameof(OnGameActivityRequested)] = value; } }
        public Array<ETechReqStatusChange> StatusChangeEvents { get { return new Array<ETechReqStatusChange>(this[nameof(StatusChangeEvents)].Address); } }
        public Array<Object> CustomStatusChangeMessage { get { return new Array<Object>(this[nameof(CustomStatusChangeMessage)].Address); } }
        public ETechReqStatusChange NetworkFailReason { get { return (ETechReqStatusChange)this[nameof(NetworkFailReason)].GetValue<int>(); } set { this[nameof(NetworkFailReason)].SetValue<int>((int)value); } }
        public ETechReqStatusChange PrivilegeFailReason { get { return (ETechReqStatusChange)this[nameof(PrivilegeFailReason)].GetValue<int>(); } set { this[nameof(PrivilegeFailReason)].SetValue<int>((int)value); } }
        public bool bHasSeenLegalScreen { get { return this[nameof(bHasSeenLegalScreen)].Flag; } set { this[nameof(bHasSeenLegalScreen)].Flag = value; } }
        public void ShowSwitchPlatformGameProfile() { Invoke(nameof(ShowSwitchPlatformGameProfile)); }
        public void ShowStatusChangedEventMessage(ETechReqStatusChange Event) { Invoke(nameof(ShowStatusChangedEventMessage), Event); }
        public void ShowPlayerGamertagInfo(UniqueNetIdRepl UniqueId) { Invoke(nameof(ShowPlayerGamertagInfo), UniqueId); }
        public void SetVoipEnabled(bool Enabled) { Invoke(nameof(SetVoipEnabled), Enabled); }
        public void SetUsingMultiplayerFeatures(bool IsUsing) { Invoke(nameof(SetUsingMultiplayerFeatures), IsUsing); }
        public void SetPresenceLocation(EPresenceContent Location) { Invoke(nameof(SetPresenceLocation), Location); }
        public void SetHasSeenLegalScreen() { Invoke(nameof(SetHasSeenLegalScreen)); }
        public void SetActiveController(PlayerController Controller) { Invoke(nameof(SetActiveController), Controller); }
        public void MuteVOIP(bool bMute) { Invoke(nameof(MuteVOIP), bMute); }
        public void MainMenuLoaded() { Invoke(nameof(MainMenuLoaded)); }
        public bool IsVoipPTTEnabled() { return Invoke<bool>(nameof(IsVoipPTTEnabled)); }
        public bool IsVoipMuted() { return Invoke<bool>(nameof(IsVoipMuted)); }
        public bool IsVoipEnabled() { return Invoke<bool>(nameof(IsVoipEnabled)); }
        public bool IsUsingMultiplayerFeatures() { return Invoke<bool>(nameof(IsUsingMultiplayerFeatures)); }
        public bool IsProfileValid() { return Invoke<bool>(nameof(IsProfileValid)); }
        public bool IsPremiumServiceAvailable() { return Invoke<bool>(nameof(IsPremiumServiceAvailable)); }
        public bool IsLoggedIn() { return Invoke<bool>(nameof(IsLoggedIn)); }
        public bool IsFullGameAvailable() { return Invoke<bool>(nameof(IsFullGameAvailable)); }
        public bool IsCrossplayEnabled() { return Invoke<bool>(nameof(IsCrossplayEnabled)); }
        public bool IsControllerConnected() { return Invoke<bool>(nameof(IsControllerConnected)); }
        public bool IsChatRestricted() { return Invoke<bool>(nameof(IsChatRestricted)); }
        public bool HasLicense(Object License) { return Invoke<bool>(nameof(HasLicense), License); }
        public bool HasCheckedOnlinePrivilege() { return Invoke<bool>(nameof(HasCheckedOnlinePrivilege)); }
        public EPresenceContent GetPresenceLocation() { return Invoke<EPresenceContent>(nameof(GetPresenceLocation)); }
        public Object GetPlatformGameProfileUserName() { return Invoke<Object>(nameof(GetPlatformGameProfileUserName)); }
        public Array<Object> GetLicensedContent() { return Invoke<Array<Object>>(nameof(GetLicensedContent)); }
        public GunfireTechRequirementsImpl GetGunfireTechRequirementsImpl(Object WorldContextObject) { return Invoke<GunfireTechRequirementsImpl>(nameof(GetGunfireTechRequirementsImpl), WorldContextObject); }
        public void EnableVoipPTT(bool Enabled) { Invoke(nameof(EnableVoipPTT), Enabled); }
        public void CustomLogin(EAlternateLoginType Type) { Invoke(nameof(CustomLogin), Type); }
        public void CheckOnlinePrivilege() { Invoke(nameof(CheckOnlinePrivilege)); }
        public void CheckOnlineCommunicationPrivilege() { Invoke(nameof(CheckOnlineCommunicationPrivilege)); }
        public bool CanRequestCustomLogin() { return Invoke<bool>(nameof(CanRequestCustomLogin)); }
        public void AddStatusChangedEvent(ETechReqStatusChange Event, Object CustomMessage) { Invoke(nameof(AddStatusChangedEvent), Event, CustomMessage); }
        public void ActivityStart(Object ActivityId) { Invoke(nameof(ActivityStart), ActivityId); }
        public void ActivitySetAvailability(Object ActivityId, bool Enabled) { Invoke(nameof(ActivitySetAvailability), ActivityId, Enabled); }
        public void ActivityResume(Object ActivityId, Array<Object> InProgressTasks, Array<Object> CompletedTasks) { Invoke(nameof(ActivityResume), ActivityId, InProgressTasks, CompletedTasks); }
        public void ActivityResetAll() { Invoke(nameof(ActivityResetAll)); }
        public void ActivityEnd(Object ActivityId, EOnlineActivityOutcomeBP Outcome) { Invoke(nameof(ActivityEnd), ActivityId, Outcome); }
    }
    public class GunfireTechRequirementsImplWin64 : GunfireTechRequirementsImpl
    {
        public GunfireTechRequirementsImplWin64(nint addr) : base(addr) { }
        public void VoipHotkeyReleased(PlayerController PlayerController) { Invoke(nameof(VoipHotkeyReleased), PlayerController); }
        public void VoipHotkeyPressed(PlayerController PlayerController) { Invoke(nameof(VoipHotkeyPressed), PlayerController); }
    }
    public enum ETechReqStatusChange : int
    {
        None = 0,
        ContDisconnected = 1,
        ConnectionLost = 2,
        InternetLost = 3,
        LiveLost = 4,
        PlusLost = 5,
        SessionLost = 6,
        UpdateRequired = 7,
        PatchRequired = 8,
        AgeRestricted = 9,
        UserNotLoggedIn = 10,
        NeedsFullInstall = 11,
        NewDlcInstalled = 12,
        DlcLicenseLost = 13,
        Normal = 14,
        Unknown = 15,
        ProfileAgeRestricted = 16,
        PreOrderInstalled = 17,
        CustomMessage = 18,
        ETechReqStatusChange_MAX = 19,
    }
    public enum EPresenceContent : int
    {
        MENU = 0,
        TUTORIAL = 1,
        EPresenceContent_MAX = 2,
    }
    public enum EOnlineActivityOutcomeBP : int
    {
        Completed = 0,
        Failed = 1,
        Cancelled = 2,
        EOnlineActivityOutcomeBP_MAX = 3,
    }
    public enum EAlternateLoginType : int
    {
        DEFAULT = 0,
        EPIC_LOGIN_EXTERNAL = 1,
        EPIC_LINK_HEADLESS = 2,
        EPIC_LINK_EXTERNAL = 3,
        EAlternateLoginType_MAX = 4,
    }
}
