using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
namespace SDK.Script.RendererSDK
{
    public class SparseVolumeTextureViewerComponent : PrimitiveComponent
    {
        public SparseVolumeTextureViewerComponent(nint addr) : base(addr) { }
        public SparseVolumeTexture SparseVolumeTexturePreview { get { return this[nameof(SparseVolumeTexturePreview)].As<SparseVolumeTexture>(); } set { this["SparseVolumeTexturePreview"] = value; } }
        public bool bAnimate { get { return this[nameof(bAnimate)].Flag; } set { this[nameof(bAnimate)].Flag = value; } }
        public float AnimationFrame { get { return this[nameof(AnimationFrame)].GetValue<float>(); } set { this[nameof(AnimationFrame)].SetValue<float>(value); } }
        public float FrameRate { get { return this[nameof(FrameRate)].GetValue<float>(); } set { this[nameof(FrameRate)].SetValue<float>(value); } }
        public float AnimationTime { get { return this[nameof(AnimationTime)].GetValue<float>(); } set { this[nameof(AnimationTime)].SetValue<float>(value); } }
        public int ComponentToVisualize { get { return this[nameof(ComponentToVisualize)].GetValue<int>(); } set { this[nameof(ComponentToVisualize)].SetValue<int>(value); } }
    }
    public class SparseVolumeTextureViewer : Info
    {
        public SparseVolumeTextureViewer(nint addr) : base(addr) { }
        public SparseVolumeTextureViewerComponent SparseVolumeTextureViewerComponent { get { return this[nameof(SparseVolumeTextureViewerComponent)].As<SparseVolumeTextureViewerComponent>(); } set { this["SparseVolumeTextureViewerComponent"] = value; } }
    }
}
