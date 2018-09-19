// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: samples/Contracts/protos/project.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Project.Proto {

  /// <summary>Holder for reflection information generated from samples/Contracts/protos/project.proto</summary>
  public static partial class ProjectReflection {

    #region Descriptor
    /// <summary>File descriptor for samples/Contracts/protos/project.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProjectReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZzYW1wbGVzL0NvbnRyYWN0cy9wcm90b3MvcHJvamVjdC5wcm90bxINcHJv",
            "amVjdC5wcm90bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byJR",
            "ChFQcm9qZWN0Q3JlYXRlZE1zZxIMCgROYW1lGAEgASgJEi4KCk9jY3VycmVk",
            "T24YAiABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Project.Proto.ProjectCreatedMsg), global::Project.Proto.ProjectCreatedMsg.Parser, new[]{ "Name", "OccurredOn" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ProjectCreatedMsg : pb::IMessage<ProjectCreatedMsg> {
    private static readonly pb::MessageParser<ProjectCreatedMsg> _parser = new pb::MessageParser<ProjectCreatedMsg>(() => new ProjectCreatedMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProjectCreatedMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Project.Proto.ProjectReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProjectCreatedMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProjectCreatedMsg(ProjectCreatedMsg other) : this() {
      name_ = other.name_;
      occurredOn_ = other.occurredOn_ != null ? other.occurredOn_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProjectCreatedMsg Clone() {
      return new ProjectCreatedMsg(this);
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "OccurredOn" field.</summary>
    public const int OccurredOnFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp occurredOn_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp OccurredOn {
      get { return occurredOn_; }
      set {
        occurredOn_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProjectCreatedMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProjectCreatedMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(OccurredOn, other.OccurredOn)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (occurredOn_ != null) hash ^= OccurredOn.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (occurredOn_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(OccurredOn);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (occurredOn_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OccurredOn);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProjectCreatedMsg other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.occurredOn_ != null) {
        if (occurredOn_ == null) {
          occurredOn_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        OccurredOn.MergeFrom(other.OccurredOn);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (occurredOn_ == null) {
              occurredOn_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(occurredOn_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code