// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: account.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from account.proto</summary>
public static partial class AccountReflection {

  #region Descriptor
  /// <summary>File descriptor for account.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static AccountReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg1hY2NvdW50LnByb3RvIiUKE0VtcGxveWVlTmFtZVJlcXVlc3QSDgoGZW1w",
          "X2lkGAEgASgJIjUKDEVtcGxveWVlTmFtZRISCgpmaXJzdF9uYW1lGAEgASgJ",
          "EhEKCWxhc3RfbmFtZRgCIAEoCTJICg5BY2NvdW50U2VydmljZRI2Cg9HZXRF",
          "bXBsb3llZU5hbWUSFC5FbXBsb3llZU5hbWVSZXF1ZXN0Gg0uRW1wbG95ZWVO",
          "YW1lYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::EmployeeNameRequest), global::EmployeeNameRequest.Parser, new[]{ "EmpId" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::EmployeeName), global::EmployeeName.Parser, new[]{ "FirstName", "LastName" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class EmployeeNameRequest : pb::IMessage<EmployeeNameRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<EmployeeNameRequest> _parser = new pb::MessageParser<EmployeeNameRequest>(() => new EmployeeNameRequest());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<EmployeeNameRequest> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AccountReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public EmployeeNameRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public EmployeeNameRequest(EmployeeNameRequest other) : this() {
    empId_ = other.empId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public EmployeeNameRequest Clone() {
    return new EmployeeNameRequest(this);
  }

  /// <summary>Field number for the "emp_id" field.</summary>
  public const int EmpIdFieldNumber = 1;
  private string empId_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string EmpId {
    get { return empId_; }
    set {
      empId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as EmployeeNameRequest);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(EmployeeNameRequest other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (EmpId != other.EmpId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (EmpId.Length != 0) hash ^= EmpId.GetHashCode();
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
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (EmpId.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(EmpId);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (EmpId.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(EmpId);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (EmpId.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(EmpId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(EmployeeNameRequest other) {
    if (other == null) {
      return;
    }
    if (other.EmpId.Length != 0) {
      EmpId = other.EmpId;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          EmpId = input.ReadString();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          EmpId = input.ReadString();
          break;
        }
      }
    }
  }
  #endif

}

public sealed partial class EmployeeName : pb::IMessage<EmployeeName>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<EmployeeName> _parser = new pb::MessageParser<EmployeeName>(() => new EmployeeName());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<EmployeeName> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AccountReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public EmployeeName() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public EmployeeName(EmployeeName other) : this() {
    firstName_ = other.firstName_;
    lastName_ = other.lastName_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public EmployeeName Clone() {
    return new EmployeeName(this);
  }

  /// <summary>Field number for the "first_name" field.</summary>
  public const int FirstNameFieldNumber = 1;
  private string firstName_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string FirstName {
    get { return firstName_; }
    set {
      firstName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "last_name" field.</summary>
  public const int LastNameFieldNumber = 2;
  private string lastName_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string LastName {
    get { return lastName_; }
    set {
      lastName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as EmployeeName);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(EmployeeName other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (FirstName != other.FirstName) return false;
    if (LastName != other.LastName) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (FirstName.Length != 0) hash ^= FirstName.GetHashCode();
    if (LastName.Length != 0) hash ^= LastName.GetHashCode();
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
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (FirstName.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(FirstName);
    }
    if (LastName.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(LastName);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (FirstName.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(FirstName);
    }
    if (LastName.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(LastName);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (FirstName.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(FirstName);
    }
    if (LastName.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(LastName);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(EmployeeName other) {
    if (other == null) {
      return;
    }
    if (other.FirstName.Length != 0) {
      FirstName = other.FirstName;
    }
    if (other.LastName.Length != 0) {
      LastName = other.LastName;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          FirstName = input.ReadString();
          break;
        }
        case 18: {
          LastName = input.ReadString();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          FirstName = input.ReadString();
          break;
        }
        case 18: {
          LastName = input.ReadString();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
