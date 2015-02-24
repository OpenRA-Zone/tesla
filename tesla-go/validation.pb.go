// Code generated by protoc-gen-go.
// source: validation.proto
// DO NOT EDIT!

package tesla

import proto "github.com/golang/protobuf/proto"
import math "math"

// Reference imports to suppress errors if they are not otherwise used.
var _ = proto.Marshal
var _ = math.Inf

// PlayerJoinRequest is sent by the DS to the CS when a player wants to join the DS.
// The CS verifies the JoinHash sent by the PC to the DS and responds with a PlayerJoinResponse.
type PlayerJoinRequest struct {
	RequestID          *uint64 `protobuf:"varint,1,req" json:"RequestID,omitempty"`
	PlayerID           *uint64 `protobuf:"varint,2,req" json:"PlayerID,omitempty"`
	AuthenticationHash []byte  `protobuf:"bytes,3,req" json:"AuthenticationHash,omitempty"`
	XXX_unrecognized   []byte  `json:"-"`
}

func (m *PlayerJoinRequest) Reset()         { *m = PlayerJoinRequest{} }
func (m *PlayerJoinRequest) String() string { return proto.CompactTextString(m) }
func (*PlayerJoinRequest) ProtoMessage()    {}

func (m *PlayerJoinRequest) GetRequestID() uint64 {
	if m != nil && m.RequestID != nil {
		return *m.RequestID
	}
	return 0
}

func (m *PlayerJoinRequest) GetPlayerID() uint64 {
	if m != nil && m.PlayerID != nil {
		return *m.PlayerID
	}
	return 0
}

func (m *PlayerJoinRequest) GetAuthenticationHash() []byte {
	if m != nil {
		return m.AuthenticationHash
	}
	return nil
}

// PlayerJoinResponse is sent from the CS to the DS. The field `Valid` indicates wether the JoinRequest was valid.
type PlayerJoinResponse struct {
	RequestID        *uint64 `protobuf:"varint,1,req" json:"RequestID,omitempty"`
	Valid            *bool   `protobuf:"varint,2,req" json:"Valid,omitempty"`
	XXX_unrecognized []byte  `json:"-"`
}

func (m *PlayerJoinResponse) Reset()         { *m = PlayerJoinResponse{} }
func (m *PlayerJoinResponse) String() string { return proto.CompactTextString(m) }
func (*PlayerJoinResponse) ProtoMessage()    {}

func (m *PlayerJoinResponse) GetRequestID() uint64 {
	if m != nil && m.RequestID != nil {
		return *m.RequestID
	}
	return 0
}

func (m *PlayerJoinResponse) GetValid() bool {
	if m != nil && m.Valid != nil {
		return *m.Valid
	}
	return false
}

func init() {
}