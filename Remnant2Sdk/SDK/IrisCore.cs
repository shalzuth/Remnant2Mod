using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.NetCoreSDK;
namespace SDK.Script.IrisCoreSDK
{
    public class DataStream : Object
    {
        public DataStream(nint addr) : base(addr) { }
    }
    public class DataStreamDefinitions : Object
    {
        public DataStreamDefinitions(nint addr) : base(addr) { }
        public Array<DataStreamDefinition> DataStreamDefinitions_value { get { return new Array<DataStreamDefinition>(this[nameof(DataStreamDefinitions)].Address); } }
    }
    public class DataStreamManager : DataStream
    {
        public DataStreamManager(nint addr) : base(addr) { }
    }
    public class NetObjectFilterConfig : Object
    {
        public NetObjectFilterConfig(nint addr) : base(addr) { }
    }
    public class FilterOutNetObjectFilterConfig : NetObjectFilterConfig
    {
        public FilterOutNetObjectFilterConfig(nint addr) : base(addr) { }
    }
    public class NetObjectFilter : Object
    {
        public NetObjectFilter(nint addr) : base(addr) { }
    }
    public class FilterOutNetObjectFilter : NetObjectFilter
    {
        public FilterOutNetObjectFilter(nint addr) : base(addr) { }
    }
    public class IrisObjectReferencePackageMap : PackageMap
    {
        public IrisObjectReferencePackageMap(nint addr) : base(addr) { }
    }
    public class NetObjectPrioritizer : Object
    {
        public NetObjectPrioritizer(nint addr) : base(addr) { }
    }
    public class LocationBasedNetObjectPrioritizer : NetObjectPrioritizer
    {
        public LocationBasedNetObjectPrioritizer(nint addr) : base(addr) { }
    }
    public class NetBlobHandler : Object
    {
        public NetBlobHandler(nint addr) : base(addr) { }
    }
    public class NetBlobHandlerDefinitions : Object
    {
        public NetBlobHandlerDefinitions(nint addr) : base(addr) { }
        public Array<NetBlobHandlerDefinition> NetBlobHandlerDefinitions_value { get { return new Array<NetBlobHandlerDefinition>(this[nameof(NetBlobHandlerDefinitions)].Address); } }
    }
    public class NetObjectBlobHandler : NetBlobHandler
    {
        public NetObjectBlobHandler(nint addr) : base(addr) { }
    }
    public class NetObjectPrioritizerConfig : Object
    {
        public NetObjectPrioritizerConfig(nint addr) : base(addr) { }
    }
    public class NetObjectCountLimiterConfig : NetObjectPrioritizerConfig
    {
        public NetObjectCountLimiterConfig(nint addr) : base(addr) { }
        public ENetObjectCountLimiterMode Mode { get { return (ENetObjectCountLimiterMode)this[nameof(Mode)].GetValue<int>(); } set { this[nameof(Mode)].SetValue<int>((int)value); } }
        public uint MaxObjectCount { get { return this[nameof(MaxObjectCount)].GetValue<uint>(); } set { this[nameof(MaxObjectCount)].SetValue<uint>(value); } }
        public float Priority { get { return this[nameof(Priority)].GetValue<float>(); } set { this[nameof(Priority)].SetValue<float>(value); } }
        public float OwningConnectionPriority { get { return this[nameof(OwningConnectionPriority)].GetValue<float>(); } set { this[nameof(OwningConnectionPriority)].SetValue<float>(value); } }
        public bool bEnableOwnedObjectsFastLane { get { return this[nameof(bEnableOwnedObjectsFastLane)].Flag; } set { this[nameof(bEnableOwnedObjectsFastLane)].Flag = value; } }
    }
    public class NetObjectCountLimiter : NetObjectPrioritizer
    {
        public NetObjectCountLimiter(nint addr) : base(addr) { }
    }
    public class NetObjectFilterDefinitions : Object
    {
        public NetObjectFilterDefinitions(nint addr) : base(addr) { }
        public Array<NetObjectFilterDefinition> NetObjectFilterDefinitions_value { get { return new Array<NetObjectFilterDefinition>(this[nameof(NetObjectFilterDefinitions)].Address); } }
    }
    public class NetObjectGridFilterConfig : NetObjectFilterConfig
    {
        public NetObjectGridFilterConfig(nint addr) : base(addr) { }
        public uint ViewPosRelevancyFrameCount { get { return this[nameof(ViewPosRelevancyFrameCount)].GetValue<uint>(); } set { this[nameof(ViewPosRelevancyFrameCount)].SetValue<uint>(value); } }
        public float CellSizeX { get { return this[nameof(CellSizeX)].GetValue<float>(); } set { this[nameof(CellSizeX)].SetValue<float>(value); } }
        public float CellSizeY { get { return this[nameof(CellSizeY)].GetValue<float>(); } set { this[nameof(CellSizeY)].SetValue<float>(value); } }
        public float MaxCullDistance { get { return this[nameof(MaxCullDistance)].GetValue<float>(); } set { this[nameof(MaxCullDistance)].SetValue<float>(value); } }
        public float DefaultCullDistance { get { return this[nameof(DefaultCullDistance)].GetValue<float>(); } set { this[nameof(DefaultCullDistance)].SetValue<float>(value); } }
        public Vector MinPos { get { return this[nameof(MinPos)].As<Vector>(); } set { this["MinPos"] = value; } }
        public Vector MaxPos { get { return this[nameof(MaxPos)].As<Vector>(); } set { this["MaxPos"] = value; } }
    }
    public class NetObjectGridFilter : NetObjectFilter
    {
        public NetObjectGridFilter(nint addr) : base(addr) { }
    }
    public class NetObjectPrioritizerDefinitions : Object
    {
        public NetObjectPrioritizerDefinitions(nint addr) : base(addr) { }
        public Array<NetObjectPrioritizerDefinition> NetObjectPrioritizerDefinitions_value { get { return new Array<NetObjectPrioritizerDefinition>(this[nameof(NetObjectPrioritizerDefinitions)].Address); } }
    }
    public class NetRPCHandler : NetBlobHandler
    {
        public NetRPCHandler(nint addr) : base(addr) { }
    }
    public class NetTokenDataStream : DataStream
    {
        public NetTokenDataStream(nint addr) : base(addr) { }
    }
    public class NopNetObjectFilterConfig : NetObjectFilterConfig
    {
        public NopNetObjectFilterConfig(nint addr) : base(addr) { }
    }
    public class NopNetObjectFilter : NetObjectFilter
    {
        public NopNetObjectFilter(nint addr) : base(addr) { }
    }
    public class ReplicationBridge : Object
    {
        public ReplicationBridge(nint addr) : base(addr) { }
    }
    public class ObjectReplicationBridge : ReplicationBridge
    {
        public ObjectReplicationBridge(nint addr) : base(addr) { }
    }
    public class ObjectReplicationBridgeConfig : Object
    {
        public ObjectReplicationBridgeConfig(nint addr) : base(addr) { }
        public Array<ObjectReplicationBridgePollConfig> PollConfigs { get { return new Array<ObjectReplicationBridgePollConfig>(this[nameof(PollConfigs)].Address); } }
        public Array<ObjectReplicationBridgeFilterConfig> FilterConfigs { get { return new Array<ObjectReplicationBridgeFilterConfig>(this[nameof(FilterConfigs)].Address); } }
        public Array<ObjectReplicationBridgePrioritizerConfig> PrioritizerConfigs { get { return new Array<ObjectReplicationBridgePrioritizerConfig>(this[nameof(PrioritizerConfigs)].Address); } }
        public Array<ObjectReplicationBridgeDeltaCompressionConfig> DeltaCompressionConfigs { get { return new Array<ObjectReplicationBridgeDeltaCompressionConfig>(this[nameof(DeltaCompressionConfigs)].Address); } }
        public Object DefaultSpatialFilterName { get { return this[nameof(DefaultSpatialFilterName)]; } set { this[nameof(DefaultSpatialFilterName)] = value; } }
        public Object RequiredNetDriverChannelClassName { get { return this[nameof(RequiredNetDriverChannelClassName)]; } set { this[nameof(RequiredNetDriverChannelClassName)] = value; } }
    }
    public class SequentialPartialNetBlobHandlerConfig : Object
    {
        public SequentialPartialNetBlobHandlerConfig(nint addr) : base(addr) { }
        public uint MaxPartBitCount { get { return this[nameof(MaxPartBitCount)].GetValue<uint>(); } set { this[nameof(MaxPartBitCount)].SetValue<uint>(value); } }
        public uint MaxPartCount { get { return this[nameof(MaxPartCount)].GetValue<uint>(); } set { this[nameof(MaxPartCount)].SetValue<uint>(value); } }
    }
    public class PartialNetObjectAttachmentHandlerConfig : SequentialPartialNetBlobHandlerConfig
    {
        public PartialNetObjectAttachmentHandlerConfig(nint addr) : base(addr) { }
        public uint BitCountSplitThreshold { get { return this[nameof(BitCountSplitThreshold)].GetValue<uint>(); } set { this[nameof(BitCountSplitThreshold)].SetValue<uint>(value); } }
    }
    public class SequentialPartialNetBlobHandler : NetBlobHandler
    {
        public SequentialPartialNetBlobHandler(nint addr) : base(addr) { }
    }
    public class PartialNetObjectAttachmentHandler : SequentialPartialNetBlobHandler
    {
        public PartialNetObjectAttachmentHandler(nint addr) : base(addr) { }
    }
    public class ReplicationDataStream : DataStream
    {
        public ReplicationDataStream(nint addr) : base(addr) { }
    }
    public class ReplicationSystem : Object
    {
        public ReplicationSystem(nint addr) : base(addr) { }
        public ReplicationBridge ReplicationBridge { get { return this[nameof(ReplicationBridge)].As<ReplicationBridge>(); } set { this["ReplicationBridge"] = value; } }
    }
    public class SphereNetObjectPrioritizerConfig : NetObjectPrioritizerConfig
    {
        public SphereNetObjectPrioritizerConfig(nint addr) : base(addr) { }
        public float InnerRadius { get { return this[nameof(InnerRadius)].GetValue<float>(); } set { this[nameof(InnerRadius)].SetValue<float>(value); } }
        public float OuterRadius { get { return this[nameof(OuterRadius)].GetValue<float>(); } set { this[nameof(OuterRadius)].SetValue<float>(value); } }
        public float InnerPriority { get { return this[nameof(InnerPriority)].GetValue<float>(); } set { this[nameof(InnerPriority)].SetValue<float>(value); } }
        public float OuterPriority { get { return this[nameof(OuterPriority)].GetValue<float>(); } set { this[nameof(OuterPriority)].SetValue<float>(value); } }
        public float OutsidePriority { get { return this[nameof(OutsidePriority)].GetValue<float>(); } set { this[nameof(OutsidePriority)].SetValue<float>(value); } }
    }
    public class SphereNetObjectPrioritizer : LocationBasedNetObjectPrioritizer
    {
        public SphereNetObjectPrioritizer(nint addr) : base(addr) { }
    }
    public class SphereWithOwnerBoostNetObjectPrioritizerConfig : SphereNetObjectPrioritizerConfig
    {
        public SphereWithOwnerBoostNetObjectPrioritizerConfig(nint addr) : base(addr) { }
        public float OwnerPriorityBoost { get { return this[nameof(OwnerPriorityBoost)].GetValue<float>(); } set { this[nameof(OwnerPriorityBoost)].SetValue<float>(value); } }
    }
    public class SphereWithOwnerBoostNetObjectPrioritizer : SphereNetObjectPrioritizer
    {
        public SphereWithOwnerBoostNetObjectPrioritizer(nint addr) : base(addr) { }
    }
    public class ReplicationStateDescriptorConfig : Object
    {
        public ReplicationStateDescriptorConfig(nint addr) : base(addr) { }
        public Array<SupportsStructNetSerializerConfig> SupportsStructNetSerializerList { get { return new Array<SupportsStructNetSerializerConfig>(this[nameof(SupportsStructNetSerializerList)].Address); } }
    }
    public enum EDataStreamSendStatus : int
    {
        Send = 0,
        Pause = 1,
        EDataStreamSendStatus_MAX = 2,
    }
    public enum ENetObjectCountLimiterMode : int
    {
        RoundRobin = 0,
        Fill = 1,
        ENetObjectCountLimiterMode_MAX = 2,
    }
    public class DataStreamDefinition : Object
    {
        public DataStreamDefinition(nint addr) : base(addr) { }
        public Object DataStreamName { get { return this[nameof(DataStreamName)]; } set { this[nameof(DataStreamName)] = value; } }
        public Object ClassName { get { return this[nameof(ClassName)]; } set { this[nameof(ClassName)] = value; } }
        public Object Class { get { return this[nameof(Class)].As<Object>(); } set { this["Class"] = value; } } // ClassPtrProperty
        public EDataStreamSendStatus DefaultSendStatus { get { return (EDataStreamSendStatus)this[nameof(DefaultSendStatus)].GetValue<int>(); } set { this[nameof(DefaultSendStatus)].SetValue<int>((int)value); } }
        public bool bAutoCreate { get { return this[nameof(bAutoCreate)].Flag; } set { this[nameof(bAutoCreate)].Flag = value; } }
    }
    public class NetSerializerConfig : Object
    {
        public NetSerializerConfig(nint addr) : base(addr) { }
    }
    public class DateTimeNetSerializerConfig : NetSerializerConfig
    {
        public DateTimeNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class EnumInt8NetSerializerConfig : NetSerializerConfig
    {
        public EnumInt8NetSerializerConfig(nint addr) : base(addr) { }
        public byte LowerBound { get { return this[nameof(LowerBound)].GetValue<byte>(); } set { this[nameof(LowerBound)].SetValue<byte>(value); } }
        public byte UpperBound { get { return this[nameof(UpperBound)].GetValue<byte>(); } set { this[nameof(UpperBound)].SetValue<byte>(value); } }
        public byte BitCount { get { return this[nameof(BitCount)].GetValue<byte>(); } set { this[nameof(BitCount)].SetValue<byte>(value); } }
    }
    public class EnumInt16NetSerializerConfig : NetSerializerConfig
    {
        public EnumInt16NetSerializerConfig(nint addr) : base(addr) { }
        public short LowerBound { get { return this[nameof(LowerBound)].GetValue<short>(); } set { this[nameof(LowerBound)].SetValue<short>(value); } }
        public short UpperBound { get { return this[nameof(UpperBound)].GetValue<short>(); } set { this[nameof(UpperBound)].SetValue<short>(value); } }
        public byte BitCount { get { return this[nameof(BitCount)].GetValue<byte>(); } set { this[nameof(BitCount)].SetValue<byte>(value); } }
    }
    public class EnumInt32NetSerializerConfig : NetSerializerConfig
    {
        public EnumInt32NetSerializerConfig(nint addr) : base(addr) { }
        public int LowerBound { get { return this[nameof(LowerBound)].GetValue<int>(); } set { this[nameof(LowerBound)].SetValue<int>(value); } }
        public int UpperBound { get { return this[nameof(UpperBound)].GetValue<int>(); } set { this[nameof(UpperBound)].SetValue<int>(value); } }
        public byte BitCount { get { return this[nameof(BitCount)].GetValue<byte>(); } set { this[nameof(BitCount)].SetValue<byte>(value); } }
    }
    public class EnumInt64NetSerializerConfig : NetSerializerConfig
    {
        public EnumInt64NetSerializerConfig(nint addr) : base(addr) { }
        public long LowerBound { get { return this[nameof(LowerBound)].GetValue<long>(); } set { this[nameof(LowerBound)].SetValue<long>(value); } }
        public long UpperBound { get { return this[nameof(UpperBound)].GetValue<long>(); } set { this[nameof(UpperBound)].SetValue<long>(value); } }
        public byte BitCount { get { return this[nameof(BitCount)].GetValue<byte>(); } set { this[nameof(BitCount)].SetValue<byte>(value); } }
    }
    public class EnumUint8NetSerializerConfig : NetSerializerConfig
    {
        public EnumUint8NetSerializerConfig(nint addr) : base(addr) { }
        public byte LowerBound { get { return this[nameof(LowerBound)].GetValue<byte>(); } set { this[nameof(LowerBound)].SetValue<byte>(value); } }
        public byte UpperBound { get { return this[nameof(UpperBound)].GetValue<byte>(); } set { this[nameof(UpperBound)].SetValue<byte>(value); } }
        public byte BitCount { get { return this[nameof(BitCount)].GetValue<byte>(); } set { this[nameof(BitCount)].SetValue<byte>(value); } }
    }
    public class EnumUint16NetSerializerConfig : NetSerializerConfig
    {
        public EnumUint16NetSerializerConfig(nint addr) : base(addr) { }
        public ushort LowerBound { get { return this[nameof(LowerBound)].GetValue<ushort>(); } set { this[nameof(LowerBound)].SetValue<ushort>(value); } }
        public ushort UpperBound { get { return this[nameof(UpperBound)].GetValue<ushort>(); } set { this[nameof(UpperBound)].SetValue<ushort>(value); } }
        public byte BitCount { get { return this[nameof(BitCount)].GetValue<byte>(); } set { this[nameof(BitCount)].SetValue<byte>(value); } }
    }
    public class EnumUint32NetSerializerConfig : NetSerializerConfig
    {
        public EnumUint32NetSerializerConfig(nint addr) : base(addr) { }
        public uint LowerBound { get { return this[nameof(LowerBound)].GetValue<uint>(); } set { this[nameof(LowerBound)].SetValue<uint>(value); } }
        public uint UpperBound { get { return this[nameof(UpperBound)].GetValue<uint>(); } set { this[nameof(UpperBound)].SetValue<uint>(value); } }
        public byte BitCount { get { return this[nameof(BitCount)].GetValue<byte>(); } set { this[nameof(BitCount)].SetValue<byte>(value); } }
    }
    public class EnumUint64NetSerializerConfig : NetSerializerConfig
    {
        public EnumUint64NetSerializerConfig(nint addr) : base(addr) { }
        public ulong LowerBound { get { return this[nameof(LowerBound)].GetValue<ulong>(); } set { this[nameof(LowerBound)].SetValue<ulong>(value); } }
        public ulong UpperBound { get { return this[nameof(UpperBound)].GetValue<ulong>(); } set { this[nameof(UpperBound)].SetValue<ulong>(value); } }
        public byte BitCount { get { return this[nameof(BitCount)].GetValue<byte>(); } set { this[nameof(BitCount)].SetValue<byte>(value); } }
    }
    public class FloatNetSerializerConfig : NetSerializerConfig
    {
        public FloatNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class DoubleNetSerializerConfig : NetSerializerConfig
    {
        public DoubleNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class GuidNetSerializerConfig : NetSerializerConfig
    {
        public GuidNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class BitfieldNetSerializerConfig : NetSerializerConfig
    {
        public BitfieldNetSerializerConfig(nint addr) : base(addr) { }
        public byte BitMask { get { return this[nameof(BitMask)].GetValue<byte>(); } set { this[nameof(BitMask)].SetValue<byte>(value); } }
    }
    public class ArrayPropertyNetSerializerConfig : NetSerializerConfig
    {
        public ArrayPropertyNetSerializerConfig(nint addr) : base(addr) { }
        public ushort MaxElementCount { get { return this[nameof(MaxElementCount)].GetValue<ushort>(); } set { this[nameof(MaxElementCount)].SetValue<ushort>(value); } }
        public ushort ElementCountBitCount { get { return this[nameof(ElementCountBitCount)].GetValue<ushort>(); } set { this[nameof(ElementCountBitCount)].SetValue<ushort>(value); } }
        public Object Property { get { return this[nameof(Property)]; } set { this[nameof(Property)] = value; } }
    }
    public class LastResortPropertyNetSerializerConfig : NetSerializerConfig
    {
        public LastResortPropertyNetSerializerConfig(nint addr) : base(addr) { }
        public Object Property { get { return this[nameof(Property)]; } set { this[nameof(Property)] = value; } }
    }
    public class NetRoleNetSerializerConfig : NetSerializerConfig
    {
        public NetRoleNetSerializerConfig(nint addr) : base(addr) { }
        public int RelativeInternalOffsetToOtherRole { get { return this[nameof(RelativeInternalOffsetToOtherRole)].GetValue<int>(); } set { this[nameof(RelativeInternalOffsetToOtherRole)].SetValue<int>(value); } }
        public int RelativeExternalOffsetToOtherRole { get { return this[nameof(RelativeExternalOffsetToOtherRole)].GetValue<int>(); } set { this[nameof(RelativeExternalOffsetToOtherRole)].SetValue<int>(value); } }
        public byte LowerBound { get { return this[nameof(LowerBound)].GetValue<byte>(); } set { this[nameof(LowerBound)].SetValue<byte>(value); } }
        public byte UpperBound { get { return this[nameof(UpperBound)].GetValue<byte>(); } set { this[nameof(UpperBound)].SetValue<byte>(value); } }
        public byte BitCount { get { return this[nameof(BitCount)].GetValue<byte>(); } set { this[nameof(BitCount)].SetValue<byte>(value); } }
        public byte AutonomousProxyValue { get { return this[nameof(AutonomousProxyValue)].GetValue<byte>(); } set { this[nameof(AutonomousProxyValue)].SetValue<byte>(value); } }
        public byte SimulatedProxyValue { get { return this[nameof(SimulatedProxyValue)].GetValue<byte>(); } set { this[nameof(SimulatedProxyValue)].SetValue<byte>(value); } }
    }
    public class FieldPathNetSerializerConfig : NetSerializerConfig
    {
        public FieldPathNetSerializerConfig(nint addr) : base(addr) { }
        public Object Property { get { return this[nameof(Property)]; } set { this[nameof(Property)] = value; } }
    }
    public class FieldPathNetSerializerSerializationHelper : Object
    {
        public FieldPathNetSerializerSerializationHelper(nint addr) : base(addr) { }
        public Object Owner { get { return this[nameof(Owner)]; } set { this[nameof(Owner)] = value; } }
        public Array<Object> PropertyPath { get { return new Array<Object>(this[nameof(PropertyPath)].Address); } }
    }
    public class IntNetSerializerConfig : NetSerializerConfig
    {
        public IntNetSerializerConfig(nint addr) : base(addr) { }
        public byte BitCount { get { return this[nameof(BitCount)].GetValue<byte>(); } set { this[nameof(BitCount)].SetValue<byte>(value); } }
    }
    public class Int8RangeNetSerializerConfig : NetSerializerConfig
    {
        public Int8RangeNetSerializerConfig(nint addr) : base(addr) { }
        public byte LowerBound { get { return this[nameof(LowerBound)].GetValue<byte>(); } set { this[nameof(LowerBound)].SetValue<byte>(value); } }
        public byte UpperBound { get { return this[nameof(UpperBound)].GetValue<byte>(); } set { this[nameof(UpperBound)].SetValue<byte>(value); } }
        public byte BitCount { get { return this[nameof(BitCount)].GetValue<byte>(); } set { this[nameof(BitCount)].SetValue<byte>(value); } }
    }
    public class Int16RangeNetSerializerConfig : NetSerializerConfig
    {
        public Int16RangeNetSerializerConfig(nint addr) : base(addr) { }
        public short LowerBound { get { return this[nameof(LowerBound)].GetValue<short>(); } set { this[nameof(LowerBound)].SetValue<short>(value); } }
        public short UpperBound { get { return this[nameof(UpperBound)].GetValue<short>(); } set { this[nameof(UpperBound)].SetValue<short>(value); } }
        public byte BitCount { get { return this[nameof(BitCount)].GetValue<byte>(); } set { this[nameof(BitCount)].SetValue<byte>(value); } }
    }
    public class Int32RangeNetSerializerConfig : NetSerializerConfig
    {
        public Int32RangeNetSerializerConfig(nint addr) : base(addr) { }
        public int LowerBound { get { return this[nameof(LowerBound)].GetValue<int>(); } set { this[nameof(LowerBound)].SetValue<int>(value); } }
        public int UpperBound { get { return this[nameof(UpperBound)].GetValue<int>(); } set { this[nameof(UpperBound)].SetValue<int>(value); } }
        public byte BitCount { get { return this[nameof(BitCount)].GetValue<byte>(); } set { this[nameof(BitCount)].SetValue<byte>(value); } }
    }
    public class Int64RangeNetSerializerConfig : NetSerializerConfig
    {
        public Int64RangeNetSerializerConfig(nint addr) : base(addr) { }
        public long LowerBound { get { return this[nameof(LowerBound)].GetValue<long>(); } set { this[nameof(LowerBound)].SetValue<long>(value); } }
        public long UpperBound { get { return this[nameof(UpperBound)].GetValue<long>(); } set { this[nameof(UpperBound)].SetValue<long>(value); } }
        public byte BitCount { get { return this[nameof(BitCount)].GetValue<byte>(); } set { this[nameof(BitCount)].SetValue<byte>(value); } }
    }
    public class IrisFastArraySerializer : FastArraySerializer
    {
        public IrisFastArraySerializer(nint addr) : base(addr) { }
        public uint ChangeMaskStorage { get { return this[nameof(ChangeMaskStorage)].GetValue<uint>(); } set { this[nameof(ChangeMaskStorage)].SetValue<uint>(value); } }
    }
    public class NetBlobHandlerDefinition : Object
    {
        public NetBlobHandlerDefinition(nint addr) : base(addr) { }
        public Object ClassName { get { return this[nameof(ClassName)]; } set { this[nameof(ClassName)] = value; } }
    }
    public class NetObjectFilterDefinition : Object
    {
        public NetObjectFilterDefinition(nint addr) : base(addr) { }
        public Object FilterName { get { return this[nameof(FilterName)]; } set { this[nameof(FilterName)] = value; } }
        public Object ClassName { get { return this[nameof(ClassName)]; } set { this[nameof(ClassName)] = value; } }
        public Object ConfigClassName { get { return this[nameof(ConfigClassName)]; } set { this[nameof(ConfigClassName)] = value; } }
    }
    public class NetObjectPrioritizerDefinition : Object
    {
        public NetObjectPrioritizerDefinition(nint addr) : base(addr) { }
        public Object PrioritizerName { get { return this[nameof(PrioritizerName)]; } set { this[nameof(PrioritizerName)] = value; } }
        public Object ClassName { get { return this[nameof(ClassName)]; } set { this[nameof(ClassName)] = value; } }
        public Object Class { get { return this[nameof(Class)].As<Object>(); } set { this["Class"] = value; } } // ClassPtrProperty
        public Object ConfigClassName { get { return this[nameof(ConfigClassName)]; } set { this[nameof(ConfigClassName)] = value; } }
        public Object ConfigClass { get { return this[nameof(ConfigClass)].As<Object>(); } set { this["ConfigClass"] = value; } } // ClassPtrProperty
    }
    public class BoolNetSerializerConfig : NetSerializerConfig
    {
        public BoolNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class StructNetSerializerConfig : NetSerializerConfig
    {
        public StructNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class NopNetSerializerConfig : NetSerializerConfig
    {
        public NopNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class ObjectNetSerializerConfig : NetSerializerConfig
    {
        public ObjectNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class WeakObjectNetSerializerConfig : NetSerializerConfig
    {
        public WeakObjectNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class ScriptInterfaceNetSerializerConfig : NetSerializerConfig
    {
        public ScriptInterfaceNetSerializerConfig(nint addr) : base(addr) { }
        public Object InterfaceClass { get { return this[nameof(InterfaceClass)].As<Object>(); } set { this["InterfaceClass"] = value; } } // ClassPtrProperty
    }
    public class ObjectReplicationBridgePollConfig : Object
    {
        public ObjectReplicationBridgePollConfig(nint addr) : base(addr) { }
        public Object ClassName { get { return this[nameof(ClassName)]; } set { this[nameof(ClassName)] = value; } }
        public uint PollFramePeriod { get { return this[nameof(PollFramePeriod)].GetValue<uint>(); } set { this[nameof(PollFramePeriod)].SetValue<uint>(value); } }
        public bool bIncludeSubclasses { get { return this[nameof(bIncludeSubclasses)].Flag; } set { this[nameof(bIncludeSubclasses)].Flag = value; } }
    }
    public class ObjectReplicationBridgeFilterConfig : Object
    {
        public ObjectReplicationBridgeFilterConfig(nint addr) : base(addr) { }
        public Object ClassName { get { return this[nameof(ClassName)]; } set { this[nameof(ClassName)] = value; } }
        public Object DynamicFilterName { get { return this[nameof(DynamicFilterName)]; } set { this[nameof(DynamicFilterName)] = value; } }
    }
    public class ObjectReplicationBridgePrioritizerConfig : Object
    {
        public ObjectReplicationBridgePrioritizerConfig(nint addr) : base(addr) { }
        public Object ClassName { get { return this[nameof(ClassName)]; } set { this[nameof(ClassName)] = value; } }
        public Object PrioritizerName { get { return this[nameof(PrioritizerName)]; } set { this[nameof(PrioritizerName)] = value; } }
    }
    public class ObjectReplicationBridgeDeltaCompressionConfig : Object
    {
        public ObjectReplicationBridgeDeltaCompressionConfig(nint addr) : base(addr) { }
        public Object ClassName { get { return this[nameof(ClassName)]; } set { this[nameof(ClassName)] = value; } }
        public bool bEnableDeltaCompression { get { return this[nameof(bEnableDeltaCompression)].Flag; } set { this[nameof(bEnableDeltaCompression)].Flag = value; } }
    }
    public class PackedInt32NetSerializerConfig : NetSerializerConfig
    {
        public PackedInt32NetSerializerConfig(nint addr) : base(addr) { }
    }
    public class PackedUint32NetSerializerConfig : NetSerializerConfig
    {
        public PackedUint32NetSerializerConfig(nint addr) : base(addr) { }
    }
    public class VectorNetQuantizeNetSerializerConfig : NetSerializerConfig
    {
        public VectorNetQuantizeNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class VectorNetQuantize10NetSerializerConfig : NetSerializerConfig
    {
        public VectorNetQuantize10NetSerializerConfig(nint addr) : base(addr) { }
    }
    public class VectorNetQuantize100NetSerializerConfig : NetSerializerConfig
    {
        public VectorNetQuantize100NetSerializerConfig(nint addr) : base(addr) { }
    }
    public class VectorNetQuantizeNormalNetSerializerConfig : NetSerializerConfig
    {
        public VectorNetQuantizeNormalNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class PolymorphicStructNetSerializerConfig : NetSerializerConfig
    {
        public PolymorphicStructNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class PolymorphicArrayStructNetSerializerConfig : PolymorphicStructNetSerializerConfig
    {
        public PolymorphicArrayStructNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class UnitQuatNetSerializerConfig : NetSerializerConfig
    {
        public UnitQuatNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class UnitQuat4fNetSerializerConfig : NetSerializerConfig
    {
        public UnitQuat4fNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class UnitQuat4dNetSerializerConfig : NetSerializerConfig
    {
        public UnitQuat4dNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class RotatorNetSerializerConfig : NetSerializerConfig
    {
        public RotatorNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class RotatorAsByteNetSerializerConfig : NetSerializerConfig
    {
        public RotatorAsByteNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class RotatorAsShortNetSerializerConfig : NetSerializerConfig
    {
        public RotatorAsShortNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class SoftObjectNetSerializerConfig : NetSerializerConfig
    {
        public SoftObjectNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class SoftObjectPathNetSerializerConfig : NetSerializerConfig
    {
        public SoftObjectPathNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class SoftClassPathNetSerializerConfig : NetSerializerConfig
    {
        public SoftClassPathNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class NameNetSerializerConfig : NetSerializerConfig
    {
        public NameNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class StringNetSerializerConfig : NetSerializerConfig
    {
        public StringNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class UintNetSerializerConfig : NetSerializerConfig
    {
        public UintNetSerializerConfig(nint addr) : base(addr) { }
        public byte BitCount { get { return this[nameof(BitCount)].GetValue<byte>(); } set { this[nameof(BitCount)].SetValue<byte>(value); } }
    }
    public class Uint8RangeNetSerializerConfig : NetSerializerConfig
    {
        public Uint8RangeNetSerializerConfig(nint addr) : base(addr) { }
        public byte LowerBound { get { return this[nameof(LowerBound)].GetValue<byte>(); } set { this[nameof(LowerBound)].SetValue<byte>(value); } }
        public byte UpperBound { get { return this[nameof(UpperBound)].GetValue<byte>(); } set { this[nameof(UpperBound)].SetValue<byte>(value); } }
        public byte BitCount { get { return this[nameof(BitCount)].GetValue<byte>(); } set { this[nameof(BitCount)].SetValue<byte>(value); } }
    }
    public class Uint16RangeNetSerializerConfig : NetSerializerConfig
    {
        public Uint16RangeNetSerializerConfig(nint addr) : base(addr) { }
        public ushort LowerBound { get { return this[nameof(LowerBound)].GetValue<ushort>(); } set { this[nameof(LowerBound)].SetValue<ushort>(value); } }
        public ushort UpperBound { get { return this[nameof(UpperBound)].GetValue<ushort>(); } set { this[nameof(UpperBound)].SetValue<ushort>(value); } }
        public byte BitCount { get { return this[nameof(BitCount)].GetValue<byte>(); } set { this[nameof(BitCount)].SetValue<byte>(value); } }
    }
    public class Uint32RangeNetSerializerConfig : NetSerializerConfig
    {
        public Uint32RangeNetSerializerConfig(nint addr) : base(addr) { }
        public uint LowerBound { get { return this[nameof(LowerBound)].GetValue<uint>(); } set { this[nameof(LowerBound)].SetValue<uint>(value); } }
        public uint UpperBound { get { return this[nameof(UpperBound)].GetValue<uint>(); } set { this[nameof(UpperBound)].SetValue<uint>(value); } }
        public byte BitCount { get { return this[nameof(BitCount)].GetValue<byte>(); } set { this[nameof(BitCount)].SetValue<byte>(value); } }
    }
    public class Uint64RangeNetSerializerConfig : NetSerializerConfig
    {
        public Uint64RangeNetSerializerConfig(nint addr) : base(addr) { }
        public ulong LowerBound { get { return this[nameof(LowerBound)].GetValue<ulong>(); } set { this[nameof(LowerBound)].SetValue<ulong>(value); } }
        public ulong UpperBound { get { return this[nameof(UpperBound)].GetValue<ulong>(); } set { this[nameof(UpperBound)].SetValue<ulong>(value); } }
        public byte BitCount { get { return this[nameof(BitCount)].GetValue<byte>(); } set { this[nameof(BitCount)].SetValue<byte>(value); } }
    }
    public class VectorNetSerializerConfig : NetSerializerConfig
    {
        public VectorNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class Vector3fNetSerializerConfig : NetSerializerConfig
    {
        public Vector3fNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class Vector3dNetSerializerConfig : NetSerializerConfig
    {
        public Vector3dNetSerializerConfig(nint addr) : base(addr) { }
    }
    public class SupportsStructNetSerializerConfig : Object
    {
        public SupportsStructNetSerializerConfig(nint addr) : base(addr) { }
        public Object StructName { get { return this[nameof(StructName)]; } set { this[nameof(StructName)] = value; } }
        public bool bCanUseStructNetSerializer { get { return this[nameof(bCanUseStructNetSerializer)].Flag; } set { this[nameof(bCanUseStructNetSerializer)].Flag = value; } }
    }
}
