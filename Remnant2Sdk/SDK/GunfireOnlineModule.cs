using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.OnlineSubsystemUtilsSDK;
using SDK.Script.DeveloperSettingsSDK;
namespace SDK.Script.GunfireOnlineModuleSDK
{
    public class GunfireOnlineSubsystemBase : GameInstanceSubsystem
    {
        public GunfireOnlineSubsystemBase(nint addr) : base(addr) { }
        public Object OnWaitDialog { get { return this[nameof(OnWaitDialog)]; } set { this[nameof(OnWaitDialog)] = value; } }
        public bool CanPlayOnline() { return Invoke<bool>(nameof(CanPlayOnline)); }
    }
    public class GunfireOnlineFriends : GunfireOnlineSubsystemBase
    {
        public GunfireOnlineFriends(nint addr) : base(addr) { }
        public Object OnInviteReceived { get { return this[nameof(OnInviteReceived)]; } set { this[nameof(OnInviteReceived)] = value; } }
        public Object OnFriendsListComplete { get { return this[nameof(OnFriendsListComplete)]; } set { this[nameof(OnFriendsListComplete)] = value; } }
        public Object OnFriendsListFail { get { return this[nameof(OnFriendsListFail)]; } set { this[nameof(OnFriendsListFail)] = value; } }
        public Object OnSessionsFound { get { return this[nameof(OnSessionsFound)]; } set { this[nameof(OnSessionsFound)] = value; } }
        public Object OnFriendUpdated { get { return this[nameof(OnFriendUpdated)]; } set { this[nameof(OnFriendUpdated)] = value; } }
        public void UpdateFriendsList() { Invoke(nameof(UpdateFriendsList)); }
        public void RejectInvite(Object FriendId) { Invoke(nameof(RejectInvite), FriendId); }
        public void RefreshFriendDetails(Object FriendId) { Invoke(nameof(RefreshFriendDetails), FriendId); }
        public void OnUserLoginChanged(bool IsLoggedIn, int UserId, int UserIndex) { Invoke(nameof(OnUserLoginChanged), IsLoggedIn, UserId, UserIndex); }
        public bool JoinSessionInvite() { return Invoke<bool>(nameof(JoinSessionInvite)); }
        public bool IsFindingSessions() { return Invoke<bool>(nameof(IsFindingSessions)); }
        public void InviteFriend(OnlineFriendDetails FriendDetails) { Invoke(nameof(InviteFriend), FriendDetails); }
        public bool HasSessionInvite() { return Invoke<bool>(nameof(HasSessionInvite)); }
        public GunfireOnlineFriends GetGunfireOnlineFriends(Object WorldContextObject) { return Invoke<GunfireOnlineFriends>(nameof(GetGunfireOnlineFriends), WorldContextObject); }
        public Array<OnlineFriendDetails> GetFriendsList() { return Invoke<Array<OnlineFriendDetails>>(nameof(GetFriendsList)); }
        public OnlineFriendDetails GetFriendDetails(Object FriendId) { return Invoke<OnlineFriendDetails>(nameof(GetFriendDetails), FriendId); }
        public void FindJoinableFriendSessions() { Invoke(nameof(FindJoinableFriendSessions)); }
        public void ClearInvites() { Invoke(nameof(ClearInvites)); }
        public bool AcceptInvite(Object FriendId, bool SuppressNotifications) { return Invoke<bool>(nameof(AcceptInvite), FriendId, SuppressNotifications); }
    }
    public class GunfireOnlineMatchmaker : GunfireOnlineSubsystemBase
    {
        public GunfireOnlineMatchmaker(nint addr) : base(addr) { }
        public Object OnMatchmakeBegin { get { return this[nameof(OnMatchmakeBegin)]; } set { this[nameof(OnMatchmakeBegin)] = value; } }
        public Object OnMatchmakeFail { get { return this[nameof(OnMatchmakeFail)]; } set { this[nameof(OnMatchmakeFail)] = value; } }
        public Object OnMatchmakeSuccess { get { return this[nameof(OnMatchmakeSuccess)]; } set { this[nameof(OnMatchmakeSuccess)] = value; } }
        public void Matchmake(ESessionSearchType NewSearchType, int MaxSessions, float Timeout) { Invoke(nameof(Matchmake), NewSearchType, MaxSessions, Timeout); }
        public bool IsFindingSessions() { return Invoke<bool>(nameof(IsFindingSessions)); }
        public GunfireOnlineMatchmaker GetGunfireOnlineMatchmaker(Object WorldContextObject) { return Invoke<GunfireOnlineMatchmaker>(nameof(GetGunfireOnlineMatchmaker), WorldContextObject); }
        public void CancelFindSessions() { Invoke(nameof(CancelFindSessions)); }
    }
    public class GunfireOnlineSessionManager : GunfireOnlineSubsystemBase
    {
        public GunfireOnlineSessionManager(nint addr) : base(addr) { }
        public Object OnSessionCreated { get { return this[nameof(OnSessionCreated)]; } set { this[nameof(OnSessionCreated)] = value; } }
        public Object OnSessionStarted { get { return this[nameof(OnSessionStarted)]; } set { this[nameof(OnSessionStarted)] = value; } }
        public Object OnSessionEnded { get { return this[nameof(OnSessionEnded)]; } set { this[nameof(OnSessionEnded)] = value; } }
        public Object OnStartedJoiningSession { get { return this[nameof(OnStartedJoiningSession)]; } set { this[nameof(OnStartedJoiningSession)] = value; } }
        public Object OnSessionJoined { get { return this[nameof(OnSessionJoined)]; } set { this[nameof(OnSessionJoined)] = value; } }
        public Object OnSessionJoinAttemptsFailed { get { return this[nameof(OnSessionJoinAttemptsFailed)]; } set { this[nameof(OnSessionJoinAttemptsFailed)] = value; } }
        public Object OnStateFailed { get { return this[nameof(OnStateFailed)]; } set { this[nameof(OnStateFailed)] = value; } }
        public Object OnRegisterPlayer { get { return this[nameof(OnRegisterPlayer)]; } set { this[nameof(OnRegisterPlayer)] = value; } }
        public Object OnUnregisterPlayer { get { return this[nameof(OnUnregisterPlayer)]; } set { this[nameof(OnUnregisterPlayer)] = value; } }
        public EOnlineSessionType SessionType { get { return (EOnlineSessionType)this[nameof(SessionType)].GetValue<int>(); } set { this[nameof(SessionType)].SetValue<int>((int)value); } }
        public void UpdateSession() { Invoke(nameof(UpdateSession)); }
        public void ShowSessionGamertagInfo(BlueprintSessionResult SessionInfo) { Invoke(nameof(ShowSessionGamertagInfo), SessionInfo); }
        public void SetSessionJoinability(bool IsJoinable) { Invoke(nameof(SetSessionJoinability), IsJoinable); }
        public void OnPostGameplayMainMenuLoaded() { Invoke(nameof(OnPostGameplayMainMenuLoaded)); }
        public void KickPlayer(PlayerController PlayerController, bool Banned) { Invoke(nameof(KickPlayer), PlayerController, Banned); }
        public bool JoinSession(BlueprintSessionResult SearchResult, bool SuppressNotifications) { return Invoke<bool>(nameof(JoinSession), SearchResult, SuppressNotifications); }
        public bool IsSessionValid() { return Invoke<bool>(nameof(IsSessionValid)); }
        public bool IsOnline() { return Invoke<bool>(nameof(IsOnline)); }
        public bool IsJoiningSession() { return Invoke<bool>(nameof(IsJoiningSession)); }
        public bool IsCurrentSession(BlueprintSessionResult InSession) { return Invoke<bool>(nameof(IsCurrentSession), InSession); }
        public bool HasPlayerBeenBanned(UniqueNetIdRepl UniqueNetId) { return Invoke<bool>(nameof(HasPlayerBeenBanned), UniqueNetId); }
        public SessionDetails GetSessionDetails(BlueprintSessionResult Session) { return Invoke<SessionDetails>(nameof(GetSessionDetails), Session); }
        public Array<SessionDetails> GetRecentlyJoinedSessions() { return Invoke<Array<SessionDetails>>(nameof(GetRecentlyJoinedSessions)); }
        public GunfireOnlineSessionManager GetGunfireOnlineSessionManager(Object WorldContextObject) { return Invoke<GunfireOnlineSessionManager>(nameof(GetGunfireOnlineSessionManager), WorldContextObject); }
        public void DestroySession(EOnlineSubsystemServiceType Type) { Invoke(nameof(DestroySession), Type); }
        public void CreateSession(EOnlineSessionType NewSessionType) { Invoke(nameof(CreateSession), NewSessionType); }
        public void ChangeSession(EOnlineSessionType NewSessionType) { Invoke(nameof(ChangeSession), NewSessionType); }
        public EOnlineCanJoinResult CanPlayerJoinSession(UniqueNetIdRepl UniqueId) { return Invoke<EOnlineCanJoinResult>(nameof(CanPlayerJoinSession), UniqueId); }
        public bool CanChangeSessiontype() { return Invoke<bool>(nameof(CanChangeSessiontype)); }
    }
    public class GunfireOnlineSettings : DeveloperSettings
    {
        public GunfireOnlineSettings(nint addr) : base(addr) { }
        public bool bSupportsSessionsInMainMenu { get { return this[nameof(bSupportsSessionsInMainMenu)].Flag; } set { this[nameof(bSupportsSessionsInMainMenu)].Flag = value; } }
    }
    public enum ESessionSearchType : int
    {
        QuickMatch = 0,
        Browse = 1,
        ESessionSearchType_MAX = 2,
    }
    public enum EMatchmakingFailure : int
    {
        Generic = 0,
        Cancelled = 1,
        EMatchmakingFailure_MAX = 2,
    }
    public enum EGunfireOnlineEvent : int
    {
        Normal = 0,
        GenericFailure = 1,
        ConnectionLost = 2,
        SessionLost = 3,
        SessionFull = 4,
        SessionNonexistant = 5,
        AlreadyInSession = 6,
        CreateSessionFailed = 7,
        InternetLost = 8,
        FailedToJoinAny = 9,
        CouldNotGetAddress = 10,
        ChatRestrictions = 11,
        FriendListFailed = 12,
        MatchmakingUnavailable = 13,
        VersionMismatch = 14,
        Destroying = 15,
        ChangeSessionFailed = 16,
        OfflineSessionStarted = 17,
        GameModeMismatch = 18,
        KickedFromSession = 19,
        BannedFromSession = 20,
        AFK = 21,
        MissingDLC = 22,
        SessionChanged = 23,
        JoinConnectionLost = 24,
        SessionInvalid = 25,
        QuestMultiplayerDisabled = 26,
        StartSessionFailed = 27,
        EGunfireOnlineEvent_MAX = 28,
    }
    public class OnlineFriendDetails : Object
    {
        public OnlineFriendDetails(nint addr) : base(addr) { }
        public UniqueNetIdRepl UniqueNetId { get { return this[nameof(UniqueNetId)].As<UniqueNetIdRepl>(); } set { this["UniqueNetId"] = value; } }
        public Object FriendId { get { return this[nameof(FriendId)]; } set { this[nameof(FriendId)] = value; } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public bool IsPlayingThisGame { get { return this[nameof(IsPlayingThisGame)].Flag; } set { this[nameof(IsPlayingThisGame)].Flag = value; } }
        public bool IsJoinable { get { return this[nameof(IsJoinable)].Flag; } set { this[nameof(IsJoinable)].Flag = value; } }
        public bool HaveInvite { get { return this[nameof(HaveInvite)].Flag; } set { this[nameof(HaveInvite)].Flag = value; } }
        public bool HasVoiceSupport { get { return this[nameof(HasVoiceSupport)].Flag; } set { this[nameof(HasVoiceSupport)].Flag = value; } }
        public SessionDetails SessionDetails { get { return this[nameof(SessionDetails)].As<SessionDetails>(); } set { this["SessionDetails"] = value; } }
        public EOnlineSessionSearchState FriendState { get { return (EOnlineSessionSearchState)this[nameof(FriendState)].GetValue<int>(); } set { this[nameof(FriendState)].SetValue<int>((int)value); } }
    }
    public enum EOnlineSessionSearchState : int
    {
        Idle = 0,
        UpdatingList = 1,
        FindingSession = 2,
        FindingFriendSessions = 3,
        EOnlineSessionSearchState_MAX = 4,
    }
    public class SessionDetails : Object
    {
        public SessionDetails(nint addr) : base(addr) { }
        public BlueprintSessionResult Session { get { return this[nameof(Session)].As<BlueprintSessionResult>(); } set { this["Session"] = value; } }
        public Array<Object> Players { get { return new Array<Object>(this[nameof(Players)].Address); } }
    }
    public enum EOnlineMatchmakerState : int
    {
        Idle = 0,
        FindingSession = 1,
        EOnlineMatchmakerState_MAX = 2,
    }
    public enum EOnlineSessionType : int
    {
        Public = 0,
        FriendsOnly = 1,
        InviteOnly = 2,
        Offline = 3,
        Joined = 4,
        EOnlineSessionType_MAX = 5,
    }
    public enum EOnlineSessionManagerState : int
    {
        Idle = 0,
        CreatingSession = 1,
        ChangingSession = 2,
        ChangingSessionComplete = 3,
        JoiningSession = 4,
        JoiningPresenceSession = 5,
        ReCreatingSession = 6,
        DestroyingSession = 7,
        StartingSession = 8,
        SwitchingSession = 9,
        EOnlineSessionManagerState_MAX = 10,
    }
    public enum EOnlineCanJoinResult : int
    {
        Success = 0,
        Banned = 1,
        DLC = 2,
        GameMode = 3,
        NoSession = 4,
        AlreadyJoined = 5,
        Failed = 6,
        EOnlineCanJoinResult_MAX = 7,
    }
    public enum EOnlineSubsystemServiceType : int
    {
        DefaultPlatformService = 0,
        NativePlatformService = 1,
        EOnlineSubsystemServiceType_MAX = 2,
    }
    public class FriendSessionLookup : Object
    {
        public FriendSessionLookup(nint addr) : base(addr) { }
    }
}
