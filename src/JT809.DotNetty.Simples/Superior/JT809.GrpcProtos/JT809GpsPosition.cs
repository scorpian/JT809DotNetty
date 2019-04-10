// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/JT809GpsPosition.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace JT809.GrpcProtos {

  /// <summary>Holder for reflection information generated from Protos/JT809GpsPosition.proto</summary>
  public static partial class JT809GpsPositionReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/JT809GpsPosition.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static JT809GpsPositionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1Qcm90b3MvSlQ4MDlHcHNQb3NpdGlvbi5wcm90bxIQSlQ4MDkuR3JwY1By",
            "b3RvcyLtAQoQSlQ4MDlHcHNQb3NpdGlvbhILCgNWbm8YASABKAkSDgoGVkNv",
            "bG9yGAIgASgFEhMKC0Zyb21DaGFubmVsGAMgASgJEg8KB0VuY3J5cHQYBCAB",
            "KAUSDwoHR3BzVGltZRgFIAEoAxILCgNMb24YBiABKAMSCwoDTGF0GAcgASgD",
            "EgwKBFZlYzEYDSABKAUSDAoEVmVjMhgOIAEoBRIMCgRWZWMzGA8gASgFEhEK",
            "CURpcmVjdGlvbhgQIAEoBRIQCghBbHRpdHVkZRgRIAEoBRINCgVTdGF0ZRgS",
            "IAEoBRINCgVBbGFybRgTIAEoBWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::JT809.GrpcProtos.JT809GpsPosition), global::JT809.GrpcProtos.JT809GpsPosition.Parser, new[]{ "Vno", "VColor", "FromChannel", "Encrypt", "GpsTime", "Lon", "Lat", "Vec1", "Vec2", "Vec3", "Direction", "Altitude", "State", "Alarm" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// 809车辆定位信息
  /// </summary>
  public sealed partial class JT809GpsPosition : pb::IMessage<JT809GpsPosition> {
    private static readonly pb::MessageParser<JT809GpsPosition> _parser = new pb::MessageParser<JT809GpsPosition>(() => new JT809GpsPosition());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<JT809GpsPosition> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::JT809.GrpcProtos.JT809GpsPositionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public JT809GpsPosition() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public JT809GpsPosition(JT809GpsPosition other) : this() {
      vno_ = other.vno_;
      vColor_ = other.vColor_;
      fromChannel_ = other.fromChannel_;
      encrypt_ = other.encrypt_;
      gpsTime_ = other.gpsTime_;
      lon_ = other.lon_;
      lat_ = other.lat_;
      vec1_ = other.vec1_;
      vec2_ = other.vec2_;
      vec3_ = other.vec3_;
      direction_ = other.direction_;
      altitude_ = other.altitude_;
      state_ = other.state_;
      alarm_ = other.alarm_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public JT809GpsPosition Clone() {
      return new JT809GpsPosition(this);
    }

    /// <summary>Field number for the "Vno" field.</summary>
    public const int VnoFieldNumber = 1;
    private string vno_ = "";
    /// <summary>
    /// 车牌号
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Vno {
      get { return vno_; }
      set {
        vno_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "VColor" field.</summary>
    public const int VColorFieldNumber = 2;
    private int vColor_;
    /// <summary>
    /// 车牌颜色
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int VColor {
      get { return vColor_; }
      set {
        vColor_ = value;
      }
    }

    /// <summary>Field number for the "FromChannel" field.</summary>
    public const int FromChannelFieldNumber = 3;
    private string fromChannel_ = "";
    /// <summary>
    /// 来源
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FromChannel {
      get { return fromChannel_; }
      set {
        fromChannel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Encrypt" field.</summary>
    public const int EncryptFieldNumber = 4;
    private int encrypt_;
    /// <summary>
    /// 该字段标识传输的定位信息是否使用国家测绘局批准的地图保密插件进行加密。
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Encrypt {
      get { return encrypt_; }
      set {
        encrypt_ = value;
      }
    }

    /// <summary>Field number for the "GpsTime" field.</summary>
    public const int GpsTimeFieldNumber = 5;
    private long gpsTime_;
    /// <summary>
    /// 定位时间
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long GpsTime {
      get { return gpsTime_; }
      set {
        gpsTime_ = value;
      }
    }

    /// <summary>Field number for the "Lon" field.</summary>
    public const int LonFieldNumber = 6;
    private long lon_;
    /// <summary>
    /// 经度，单位为 1*10^-6 度。
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Lon {
      get { return lon_; }
      set {
        lon_ = value;
      }
    }

    /// <summary>Field number for the "Lat" field.</summary>
    public const int LatFieldNumber = 7;
    private long lat_;
    /// <summary>
    /// 纬度，单位为 1*10^-6 度。
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Lat {
      get { return lat_; }
      set {
        lat_ = value;
      }
    }

    /// <summary>Field number for the "Vec1" field.</summary>
    public const int Vec1FieldNumber = 13;
    private int vec1_;
    /// <summary>
    /// 速度，指卫星定位车载终端设备上传的行车速度信息，为必填项。单位为千米每小时（km/h）。
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Vec1 {
      get { return vec1_; }
      set {
        vec1_ = value;
      }
    }

    /// <summary>Field number for the "Vec2" field.</summary>
    public const int Vec2FieldNumber = 14;
    private int vec2_;
    /// <summary>
    /// 行驶记录速度，指车辆行驶记录设备上传的行车速度 信息，为必填项。单位为千米每小时（km/h）。
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Vec2 {
      get { return vec2_; }
      set {
        vec2_ = value;
      }
    }

    /// <summary>Field number for the "Vec3" field.</summary>
    public const int Vec3FieldNumber = 15;
    private int vec3_;
    /// <summary>
    /// 车辆当前总里程数，值车辆上传的行车里程数。单位单位为千米（km）
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Vec3 {
      get { return vec3_; }
      set {
        vec3_ = value;
      }
    }

    /// <summary>Field number for the "Direction" field.</summary>
    public const int DirectionFieldNumber = 16;
    private int direction_;
    /// <summary>
    /// 方向，0-359，单位为度（。），正北为 0，顺时针。
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Direction {
      get { return direction_; }
      set {
        direction_ = value;
      }
    }

    /// <summary>Field number for the "Altitude" field.</summary>
    public const int AltitudeFieldNumber = 17;
    private int altitude_;
    /// <summary>
    /// 海拔高度，单位为米（m）。
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Altitude {
      get { return altitude_; }
      set {
        altitude_ = value;
      }
    }

    /// <summary>Field number for the "State" field.</summary>
    public const int StateFieldNumber = 18;
    private int state_;
    /// <summary>
    /// 车辆状态
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "Alarm" field.</summary>
    public const int AlarmFieldNumber = 19;
    private int alarm_;
    /// <summary>
    /// 报警状态
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Alarm {
      get { return alarm_; }
      set {
        alarm_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as JT809GpsPosition);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(JT809GpsPosition other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Vno != other.Vno) return false;
      if (VColor != other.VColor) return false;
      if (FromChannel != other.FromChannel) return false;
      if (Encrypt != other.Encrypt) return false;
      if (GpsTime != other.GpsTime) return false;
      if (Lon != other.Lon) return false;
      if (Lat != other.Lat) return false;
      if (Vec1 != other.Vec1) return false;
      if (Vec2 != other.Vec2) return false;
      if (Vec3 != other.Vec3) return false;
      if (Direction != other.Direction) return false;
      if (Altitude != other.Altitude) return false;
      if (State != other.State) return false;
      if (Alarm != other.Alarm) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Vno.Length != 0) hash ^= Vno.GetHashCode();
      if (VColor != 0) hash ^= VColor.GetHashCode();
      if (FromChannel.Length != 0) hash ^= FromChannel.GetHashCode();
      if (Encrypt != 0) hash ^= Encrypt.GetHashCode();
      if (GpsTime != 0L) hash ^= GpsTime.GetHashCode();
      if (Lon != 0L) hash ^= Lon.GetHashCode();
      if (Lat != 0L) hash ^= Lat.GetHashCode();
      if (Vec1 != 0) hash ^= Vec1.GetHashCode();
      if (Vec2 != 0) hash ^= Vec2.GetHashCode();
      if (Vec3 != 0) hash ^= Vec3.GetHashCode();
      if (Direction != 0) hash ^= Direction.GetHashCode();
      if (Altitude != 0) hash ^= Altitude.GetHashCode();
      if (State != 0) hash ^= State.GetHashCode();
      if (Alarm != 0) hash ^= Alarm.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Vno.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Vno);
      }
      if (VColor != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(VColor);
      }
      if (FromChannel.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(FromChannel);
      }
      if (Encrypt != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Encrypt);
      }
      if (GpsTime != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(GpsTime);
      }
      if (Lon != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(Lon);
      }
      if (Lat != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(Lat);
      }
      if (Vec1 != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(Vec1);
      }
      if (Vec2 != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(Vec2);
      }
      if (Vec3 != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(Vec3);
      }
      if (Direction != 0) {
        output.WriteRawTag(128, 1);
        output.WriteInt32(Direction);
      }
      if (Altitude != 0) {
        output.WriteRawTag(136, 1);
        output.WriteInt32(Altitude);
      }
      if (State != 0) {
        output.WriteRawTag(144, 1);
        output.WriteInt32(State);
      }
      if (Alarm != 0) {
        output.WriteRawTag(152, 1);
        output.WriteInt32(Alarm);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Vno.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Vno);
      }
      if (VColor != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(VColor);
      }
      if (FromChannel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FromChannel);
      }
      if (Encrypt != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Encrypt);
      }
      if (GpsTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(GpsTime);
      }
      if (Lon != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Lon);
      }
      if (Lat != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Lat);
      }
      if (Vec1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Vec1);
      }
      if (Vec2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Vec2);
      }
      if (Vec3 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Vec3);
      }
      if (Direction != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Direction);
      }
      if (Altitude != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Altitude);
      }
      if (State != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(State);
      }
      if (Alarm != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Alarm);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(JT809GpsPosition other) {
      if (other == null) {
        return;
      }
      if (other.Vno.Length != 0) {
        Vno = other.Vno;
      }
      if (other.VColor != 0) {
        VColor = other.VColor;
      }
      if (other.FromChannel.Length != 0) {
        FromChannel = other.FromChannel;
      }
      if (other.Encrypt != 0) {
        Encrypt = other.Encrypt;
      }
      if (other.GpsTime != 0L) {
        GpsTime = other.GpsTime;
      }
      if (other.Lon != 0L) {
        Lon = other.Lon;
      }
      if (other.Lat != 0L) {
        Lat = other.Lat;
      }
      if (other.Vec1 != 0) {
        Vec1 = other.Vec1;
      }
      if (other.Vec2 != 0) {
        Vec2 = other.Vec2;
      }
      if (other.Vec3 != 0) {
        Vec3 = other.Vec3;
      }
      if (other.Direction != 0) {
        Direction = other.Direction;
      }
      if (other.Altitude != 0) {
        Altitude = other.Altitude;
      }
      if (other.State != 0) {
        State = other.State;
      }
      if (other.Alarm != 0) {
        Alarm = other.Alarm;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Vno = input.ReadString();
            break;
          }
          case 16: {
            VColor = input.ReadInt32();
            break;
          }
          case 26: {
            FromChannel = input.ReadString();
            break;
          }
          case 32: {
            Encrypt = input.ReadInt32();
            break;
          }
          case 40: {
            GpsTime = input.ReadInt64();
            break;
          }
          case 48: {
            Lon = input.ReadInt64();
            break;
          }
          case 56: {
            Lat = input.ReadInt64();
            break;
          }
          case 104: {
            Vec1 = input.ReadInt32();
            break;
          }
          case 112: {
            Vec2 = input.ReadInt32();
            break;
          }
          case 120: {
            Vec3 = input.ReadInt32();
            break;
          }
          case 128: {
            Direction = input.ReadInt32();
            break;
          }
          case 136: {
            Altitude = input.ReadInt32();
            break;
          }
          case 144: {
            State = input.ReadInt32();
            break;
          }
          case 152: {
            Alarm = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
