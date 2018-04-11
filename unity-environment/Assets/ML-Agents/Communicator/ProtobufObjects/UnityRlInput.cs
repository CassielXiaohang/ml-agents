// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: communicator/unity_rl_input.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MLAgents.Communicator {

  /// <summary>Holder for reflection information generated from communicator/unity_rl_input.proto</summary>
  public static partial class UnityRlInputReflection {

    #region Descriptor
    /// <summary>File descriptor for communicator/unity_rl_input.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UnityRlInputReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFjb21tdW5pY2F0b3IvdW5pdHlfcmxfaW5wdXQucHJvdG8SDGNvbW11bmlj",
            "YXRvchofY29tbXVuaWNhdG9yL2FnZW50X2FjdGlvbi5wcm90bxonY29tbXVu",
            "aWNhdG9yL2VuZ2luZV9jb25maWd1cmF0aW9uLnByb3RvGiljb21tdW5pY2F0",
            "b3IvZW52aXJvbm1lbnRfcGFyYW1ldGVycy5wcm90bxoaY29tbXVuaWNhdG9y",
            "L2NvbW1hbmQucHJvdG8inwMKDFVuaXR5UkxJbnB1dBJDCg1hZ2VudF9hY3Rp",
            "b25zGAEgAygLMiwuY29tbXVuaWNhdG9yLlVuaXR5UkxJbnB1dC5BZ2VudEFj",
            "dGlvbnNFbnRyeRJDChZlbnZpcm9ubWVudF9wYXJhbWV0ZXJzGAIgASgLMiMu",
            "Y29tbXVuaWNhdG9yLkVudmlyb25tZW50UGFyYW1ldGVycxI/ChRlbmdpbmVf",
            "Y29uZmlndXJhdGlvbhgDIAEoCzIhLmNvbW11bmljYXRvci5FbmdpbmVDb25m",
            "aWd1cmF0aW9uEiYKB2NvbW1hbmQYBCABKA4yFS5jb21tdW5pY2F0b3IuQ29t",
            "bWFuZBo7Cg9MaXN0QWdlbnRBY3Rpb24SKAoFdmFsdWUYASADKAsyGS5jb21t",
            "dW5pY2F0b3IuQWdlbnRBY3Rpb24aXwoRQWdlbnRBY3Rpb25zRW50cnkSCwoD",
            "a2V5GAEgASgJEjkKBXZhbHVlGAIgASgLMiouY29tbXVuaWNhdG9yLlVuaXR5",
            "UkxJbnB1dC5MaXN0QWdlbnRBY3Rpb246AjgBQhiqAhVNTEFnZW50cy5Db21t",
            "dW5pY2F0b3JiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MLAgents.Communicator.AgentActionReflection.Descriptor, global::MLAgents.Communicator.EngineConfigurationReflection.Descriptor, global::MLAgents.Communicator.EnvironmentParametersReflection.Descriptor, global::MLAgents.Communicator.CommandReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MLAgents.Communicator.UnityRLInput), global::MLAgents.Communicator.UnityRLInput.Parser, new[]{ "AgentActions", "EnvironmentParameters", "EngineConfiguration", "Command" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::MLAgents.Communicator.UnityRLInput.Types.ListAgentAction), global::MLAgents.Communicator.UnityRLInput.Types.ListAgentAction.Parser, new[]{ "Value" }, null, null, null),
            null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UnityRLInput : pb::IMessage<UnityRLInput> {
    private static readonly pb::MessageParser<UnityRLInput> _parser = new pb::MessageParser<UnityRLInput>(() => new UnityRLInput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UnityRLInput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MLAgents.Communicator.UnityRlInputReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityRLInput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityRLInput(UnityRLInput other) : this() {
      agentActions_ = other.agentActions_.Clone();
      EnvironmentParameters = other.environmentParameters_ != null ? other.EnvironmentParameters.Clone() : null;
      EngineConfiguration = other.engineConfiguration_ != null ? other.EngineConfiguration.Clone() : null;
      command_ = other.command_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityRLInput Clone() {
      return new UnityRLInput(this);
    }

    /// <summary>Field number for the "agent_actions" field.</summary>
    public const int AgentActionsFieldNumber = 1;
    private static readonly pbc::MapField<string, global::MLAgents.Communicator.UnityRLInput.Types.ListAgentAction>.Codec _map_agentActions_codec
        = new pbc::MapField<string, global::MLAgents.Communicator.UnityRLInput.Types.ListAgentAction>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::MLAgents.Communicator.UnityRLInput.Types.ListAgentAction.Parser), 10);
    private readonly pbc::MapField<string, global::MLAgents.Communicator.UnityRLInput.Types.ListAgentAction> agentActions_ = new pbc::MapField<string, global::MLAgents.Communicator.UnityRLInput.Types.ListAgentAction>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::MLAgents.Communicator.UnityRLInput.Types.ListAgentAction> AgentActions {
      get { return agentActions_; }
    }

    /// <summary>Field number for the "environment_parameters" field.</summary>
    public const int EnvironmentParametersFieldNumber = 2;
    private global::MLAgents.Communicator.EnvironmentParameters environmentParameters_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::MLAgents.Communicator.EnvironmentParameters EnvironmentParameters {
      get { return environmentParameters_; }
      set {
        environmentParameters_ = value;
      }
    }

    /// <summary>Field number for the "engine_configuration" field.</summary>
    public const int EngineConfigurationFieldNumber = 3;
    private global::MLAgents.Communicator.EngineConfiguration engineConfiguration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::MLAgents.Communicator.EngineConfiguration EngineConfiguration {
      get { return engineConfiguration_; }
      set {
        engineConfiguration_ = value;
      }
    }

    /// <summary>Field number for the "command" field.</summary>
    public const int CommandFieldNumber = 4;
    private global::MLAgents.Communicator.Command command_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::MLAgents.Communicator.Command Command {
      get { return command_; }
      set {
        command_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UnityRLInput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UnityRLInput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!AgentActions.Equals(other.AgentActions)) return false;
      if (!object.Equals(EnvironmentParameters, other.EnvironmentParameters)) return false;
      if (!object.Equals(EngineConfiguration, other.EngineConfiguration)) return false;
      if (Command != other.Command) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= AgentActions.GetHashCode();
      if (environmentParameters_ != null) hash ^= EnvironmentParameters.GetHashCode();
      if (engineConfiguration_ != null) hash ^= EngineConfiguration.GetHashCode();
      if (Command != 0) hash ^= Command.GetHashCode();
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
      agentActions_.WriteTo(output, _map_agentActions_codec);
      if (environmentParameters_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(EnvironmentParameters);
      }
      if (engineConfiguration_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(EngineConfiguration);
      }
      if (Command != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Command);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += agentActions_.CalculateSize(_map_agentActions_codec);
      if (environmentParameters_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EnvironmentParameters);
      }
      if (engineConfiguration_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EngineConfiguration);
      }
      if (Command != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Command);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UnityRLInput other) {
      if (other == null) {
        return;
      }
      agentActions_.Add(other.agentActions_);
      if (other.environmentParameters_ != null) {
        if (environmentParameters_ == null) {
          environmentParameters_ = new global::MLAgents.Communicator.EnvironmentParameters();
        }
        EnvironmentParameters.MergeFrom(other.EnvironmentParameters);
      }
      if (other.engineConfiguration_ != null) {
        if (engineConfiguration_ == null) {
          engineConfiguration_ = new global::MLAgents.Communicator.EngineConfiguration();
        }
        EngineConfiguration.MergeFrom(other.EngineConfiguration);
      }
      if (other.Command != 0) {
        Command = other.Command;
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
            agentActions_.AddEntriesFrom(input, _map_agentActions_codec);
            break;
          }
          case 18: {
            if (environmentParameters_ == null) {
              environmentParameters_ = new global::MLAgents.Communicator.EnvironmentParameters();
            }
            input.ReadMessage(environmentParameters_);
            break;
          }
          case 26: {
            if (engineConfiguration_ == null) {
              engineConfiguration_ = new global::MLAgents.Communicator.EngineConfiguration();
            }
            input.ReadMessage(engineConfiguration_);
            break;
          }
          case 32: {
            command_ = (global::MLAgents.Communicator.Command) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the UnityRLInput message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class ListAgentAction : pb::IMessage<ListAgentAction> {
        private static readonly pb::MessageParser<ListAgentAction> _parser = new pb::MessageParser<ListAgentAction>(() => new ListAgentAction());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<ListAgentAction> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::MLAgents.Communicator.UnityRLInput.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ListAgentAction() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ListAgentAction(ListAgentAction other) : this() {
          value_ = other.value_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ListAgentAction Clone() {
          return new ListAgentAction(this);
        }

        /// <summary>Field number for the "value" field.</summary>
        public const int ValueFieldNumber = 1;
        private static readonly pb::FieldCodec<global::MLAgents.Communicator.AgentAction> _repeated_value_codec
            = pb::FieldCodec.ForMessage(10, global::MLAgents.Communicator.AgentAction.Parser);
        private readonly pbc::RepeatedField<global::MLAgents.Communicator.AgentAction> value_ = new pbc::RepeatedField<global::MLAgents.Communicator.AgentAction>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::MLAgents.Communicator.AgentAction> Value {
          get { return value_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as ListAgentAction);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(ListAgentAction other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if(!value_.Equals(other.value_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          hash ^= value_.GetHashCode();
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
          value_.WriteTo(output, _repeated_value_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          size += value_.CalculateSize(_repeated_value_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(ListAgentAction other) {
          if (other == null) {
            return;
          }
          value_.Add(other.value_);
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
                value_.AddEntriesFrom(input, _repeated_value_codec);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
