using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.BinkMediaPlayerSDK
{
    public class BinkFunctionLibrary : BlueprintFunctionLibrary
    {
        public BinkFunctionLibrary(nint addr) : base(addr) { }
        public Timespan BinkLoadingMovie_GetTime() { return Invoke<Timespan>(nameof(BinkLoadingMovie_GetTime)); }
        public Timespan BinkLoadingMovie_GetDuration() { return Invoke<Timespan>(nameof(BinkLoadingMovie_GetDuration)); }
        public void Bink_DrawOverlays() { Invoke(nameof(Bink_DrawOverlays)); }
    }
    public class BinkMediaPlayer : Object
    {
        public BinkMediaPlayer(nint addr) : base(addr) { }
        public Object OnMediaClosed { get { return this[nameof(OnMediaClosed)]; } set { this[nameof(OnMediaClosed)] = value; } }
        public Object OnMediaOpened { get { return this[nameof(OnMediaOpened)]; } set { this[nameof(OnMediaOpened)] = value; } }
        public Object OnMediaReachedEnd { get { return this[nameof(OnMediaReachedEnd)]; } set { this[nameof(OnMediaReachedEnd)] = value; } }
        public Object OnPlaybackSuspended { get { return this[nameof(OnPlaybackSuspended)]; } set { this[nameof(OnPlaybackSuspended)] = value; } }
        public bool Looping { get { return this[nameof(Looping)].Flag; } set { this[nameof(Looping)].Flag = value; } }
        public bool StartImmediately { get { return this[nameof(StartImmediately)].Flag; } set { this[nameof(StartImmediately)].Flag = value; } }
        public bool DelayedOpen { get { return this[nameof(DelayedOpen)].Flag; } set { this[nameof(DelayedOpen)].Flag = value; } }
        public Vector2D BinkDestinationUpperLeft { get { return this[nameof(BinkDestinationUpperLeft)].As<Vector2D>(); } set { this["BinkDestinationUpperLeft"] = value; } }
        public Vector2D BinkDestinationLowerRight { get { return this[nameof(BinkDestinationLowerRight)].As<Vector2D>(); } set { this["BinkDestinationLowerRight"] = value; } }
        public Object URL { get { return this[nameof(URL)]; } set { this[nameof(URL)] = value; } }
        public byte BinkBufferMode { get { return this[nameof(BinkBufferMode)].GetValue<byte>(); } set { this[nameof(BinkBufferMode)].SetValue<byte>(value); } }
        public byte BinkSoundTrack { get { return this[nameof(BinkSoundTrack)].GetValue<byte>(); } set { this[nameof(BinkSoundTrack)].SetValue<byte>(value); } }
        public int BinkSoundTrackStart { get { return this[nameof(BinkSoundTrackStart)].GetValue<int>(); } set { this[nameof(BinkSoundTrackStart)].SetValue<int>(value); } }
        public byte BinkDrawStyle { get { return this[nameof(BinkDrawStyle)].GetValue<byte>(); } set { this[nameof(BinkDrawStyle)].SetValue<byte>(value); } }
        public int BinkLayerDepth { get { return this[nameof(BinkLayerDepth)].GetValue<int>(); } set { this[nameof(BinkLayerDepth)].SetValue<int>(value); } }
        public bool SupportsSeeking() { return Invoke<bool>(nameof(SupportsSeeking)); }
        public bool SupportsScrubbing() { return Invoke<bool>(nameof(SupportsScrubbing)); }
        public bool SupportsRate(float Rate, bool Unthinned) { return Invoke<bool>(nameof(SupportsRate), Rate, Unthinned); }
        public void Stop() { Invoke(nameof(Stop)); }
        public void SetVolume(float Rate) { Invoke(nameof(SetVolume), Rate); }
        public bool SetRate(float Rate) { return Invoke<bool>(nameof(SetRate), Rate); }
        public bool SetLooping(bool InLooping) { return Invoke<bool>(nameof(SetLooping), InLooping); }
        public bool Seek(Timespan InTime) { return Invoke<bool>(nameof(Seek), InTime); }
        public bool Rewind() { return Invoke<bool>(nameof(Rewind)); }
        public bool Play() { return Invoke<bool>(nameof(Play)); }
        public bool Pause() { return Invoke<bool>(nameof(Pause)); }
        public bool OpenUrl(Object NewUrl) { return Invoke<bool>(nameof(OpenUrl), NewUrl); }
        public bool IsStopped() { return Invoke<bool>(nameof(IsStopped)); }
        public bool IsPlaying() { return Invoke<bool>(nameof(IsPlaying)); }
        public bool IsPaused() { return Invoke<bool>(nameof(IsPaused)); }
        public bool IsLooping() { return Invoke<bool>(nameof(IsLooping)); }
        public bool IsInitialized() { return Invoke<bool>(nameof(IsInitialized)); }
        public Object GetUrl() { return Invoke<Object>(nameof(GetUrl)); }
        public Timespan GetTime() { return Invoke<Timespan>(nameof(GetTime)); }
        public float GetRate() { return Invoke<float>(nameof(GetRate)); }
        public Timespan GetDuration() { return Invoke<Timespan>(nameof(GetDuration)); }
        public void Draw(Texture Texture, bool tonemap, int out_nits, float Alpha, bool srgb_decode, bool hdr) { Invoke(nameof(Draw), Texture, tonemap, out_nits, Alpha, srgb_decode, hdr); }
        public void CloseUrl() { Invoke(nameof(CloseUrl)); }
        public bool CanPlay() { return Invoke<bool>(nameof(CanPlay)); }
        public bool CanPause() { return Invoke<bool>(nameof(CanPause)); }
    }
    public class BinkMediaTexture : Texture
    {
        public BinkMediaTexture(nint addr) : base(addr) { }
        public byte AddressX { get { return this[nameof(AddressX)].GetValue<byte>(); } set { this[nameof(AddressX)].SetValue<byte>(value); } }
        public byte AddressY { get { return this[nameof(AddressY)].GetValue<byte>(); } set { this[nameof(AddressY)].SetValue<byte>(value); } }
        public BinkMediaPlayer MediaPlayer { get { return this[nameof(MediaPlayer)].As<BinkMediaPlayer>(); } set { this["MediaPlayer"] = value; } }
        public byte PixelFormat { get { return this[nameof(PixelFormat)].GetValue<byte>(); } set { this[nameof(PixelFormat)].SetValue<byte>(value); } }
        public bool tonemap { get { return this[nameof(tonemap)].Flag; } set { this[nameof(tonemap)].Flag = value; } }
        public float OutputNits { get { return this[nameof(OutputNits)].GetValue<float>(); } set { this[nameof(OutputNits)].SetValue<float>(value); } }
        public float Alpha { get { return this[nameof(Alpha)].GetValue<float>(); } set { this[nameof(Alpha)].SetValue<float>(value); } }
        public bool DecodeSRGB { get { return this[nameof(DecodeSRGB)].Flag; } set { this[nameof(DecodeSRGB)].Flag = value; } }
        public void SetMediaPlayer(BinkMediaPlayer InMediaPlayer) { Invoke(nameof(SetMediaPlayer), InMediaPlayer); }
        public void Clear() { Invoke(nameof(Clear)); }
    }
    public class BinkMoviePlayerSettings : Object
    {
        public BinkMoviePlayerSettings(nint addr) : base(addr) { }
        public byte BinkBufferMode { get { return this[nameof(BinkBufferMode)].GetValue<byte>(); } set { this[nameof(BinkBufferMode)].SetValue<byte>(value); } }
        public byte BinkSoundTrack { get { return this[nameof(BinkSoundTrack)].GetValue<byte>(); } set { this[nameof(BinkSoundTrack)].SetValue<byte>(value); } }
        public int BinkSoundTrackStart { get { return this[nameof(BinkSoundTrackStart)].GetValue<int>(); } set { this[nameof(BinkSoundTrackStart)].SetValue<int>(value); } }
        public Vector2D BinkDestinationUpperLeft { get { return this[nameof(BinkDestinationUpperLeft)].As<Vector2D>(); } set { this["BinkDestinationUpperLeft"] = value; } }
        public Vector2D BinkDestinationLowerRight { get { return this[nameof(BinkDestinationLowerRight)].As<Vector2D>(); } set { this["BinkDestinationLowerRight"] = value; } }
        public byte BinkPixelFormat { get { return this[nameof(BinkPixelFormat)].GetValue<byte>(); } set { this[nameof(BinkPixelFormat)].SetValue<byte>(value); } }
    }
    public enum EBinkMediaPlayerBinkBufferModes : int
    {
        BMASM_Bink_Stream = 0,
        BMASM_Bink_PreloadAll = 1,
        BMASM_Bink_StreamUntilResident = 2,
        BMASM_Bink_MAX = 3,
    }
    public enum EBinkMediaPlayerBinkSoundTrack : int
    {
        BMASM_Bink_Sound_None = 0,
        BMASM_Bink_Sound_Simple = 1,
        BMASM_Bink_Sound_LanguageOverride = 2,
        BMASM_Bink_Sound_52 = 3,
        BMASM_Bink_Sound_51LanguageOverride = 4,
        BMASM_Bink_Sound_72 = 5,
        BMASM_Bink_Sound_71LanguageOverride = 6,
        BMASM_Bink_Sound_MAX = 7,
    }
    public enum EBinkMediaPlayerBinkDrawStyle : int
    {
        BMASM_Bink_DS_RenderToTexture = 0,
        BMASM_Bink_DS_OverlayFillScreenWithAspectRatio = 1,
        BMASM_Bink_DS_OverlayOriginalMovieSize = 2,
        BMASM_Bink_DS_OverlayFillScreen = 3,
        BMASM_Bink_DS_OverlaySpecificDestinationRectangle = 4,
        BMASM_Bink_DS_MAX = 5,
    }
    public enum EBinkMoviePlayerBinkBufferModes : int
    {
        MP_Bink_Stream = 0,
        MP_Bink_PreloadAll = 1,
        MP_Bink_StreamUntilResident = 2,
        MP_Bink_MAX = 3,
    }
    public enum EBinkMoviePlayerBinkSoundTrack : int
    {
        MP_Bink_Sound_None = 0,
        MP_Bink_Sound_Simple = 1,
        MP_Bink_Sound_LanguageOverride = 2,
        MP_Bink_Sound_52 = 3,
        MP_Bink_Sound_51LanguageOverride = 4,
        MP_Bink_Sound_72 = 5,
        MP_Bink_Sound_71LanguageOverride = 6,
        MP_Bink_Sound_MAX = 7,
    }
}
