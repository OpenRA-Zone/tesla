// Code generated by protoc-gen-go.
// source: lobby.proto
// DO NOT EDIT!

package tesla

import proto "github.com/golang/protobuf/proto"
import math "math"

// Reference imports to suppress errors if they are not otherwise used.
var _ = proto.Marshal
var _ = math.Inf

type LobbyChatMessage_MessageTarget int32

const (
	LobbyChatMessage_All  LobbyChatMessage_MessageTarget = 1
	LobbyChatMessage_Team LobbyChatMessage_MessageTarget = 2
)

var LobbyChatMessage_MessageTarget_name = map[int32]string{
	1: "All",
	2: "Team",
}
var LobbyChatMessage_MessageTarget_value = map[string]int32{
	"All":  1,
	"Team": 2,
}

func (x LobbyChatMessage_MessageTarget) Enum() *LobbyChatMessage_MessageTarget {
	p := new(LobbyChatMessage_MessageTarget)
	*p = x
	return p
}
func (x LobbyChatMessage_MessageTarget) String() string {
	return proto.EnumName(LobbyChatMessage_MessageTarget_name, int32(x))
}
func (x *LobbyChatMessage_MessageTarget) UnmarshalJSON(data []byte) error {
	value, err := proto.UnmarshalJSONEnum(LobbyChatMessage_MessageTarget_value, data, "LobbyChatMessage_MessageTarget")
	if err != nil {
		return err
	}
	*x = LobbyChatMessage_MessageTarget(value)
	return nil
}

type LobbyPlayerJoin struct {
	PlayerID         *uint64 `protobuf:"varint,1,req" json:"PlayerID,omitempty"`
	EventTime        *int64  `protobuf:"varint,2,req" json:"EventTime,omitempty"`
	XXX_unrecognized []byte  `json:"-"`
}

func (m *LobbyPlayerJoin) Reset()         { *m = LobbyPlayerJoin{} }
func (m *LobbyPlayerJoin) String() string { return proto.CompactTextString(m) }
func (*LobbyPlayerJoin) ProtoMessage()    {}

func (m *LobbyPlayerJoin) GetPlayerID() uint64 {
	if m != nil && m.PlayerID != nil {
		return *m.PlayerID
	}
	return 0
}

func (m *LobbyPlayerJoin) GetEventTime() int64 {
	if m != nil && m.EventTime != nil {
		return *m.EventTime
	}
	return 0
}

type LobbyPlayerLeave struct {
	PlayerID         *uint64 `protobuf:"varint,1,req" json:"PlayerID,omitempty"`
	EventTime        *int64  `protobuf:"varint,2,req" json:"EventTime,omitempty"`
	XXX_unrecognized []byte  `json:"-"`
}

func (m *LobbyPlayerLeave) Reset()         { *m = LobbyPlayerLeave{} }
func (m *LobbyPlayerLeave) String() string { return proto.CompactTextString(m) }
func (*LobbyPlayerLeave) ProtoMessage()    {}

func (m *LobbyPlayerLeave) GetPlayerID() uint64 {
	if m != nil && m.PlayerID != nil {
		return *m.PlayerID
	}
	return 0
}

func (m *LobbyPlayerLeave) GetEventTime() int64 {
	if m != nil && m.EventTime != nil {
		return *m.EventTime
	}
	return 0
}

// Lobby chat is handled by the dedicated server. A
type LobbyChatMessage struct {
	PlayerID         *uint64                         `protobuf:"varint,1,req" json:"PlayerID,omitempty"`
	EventTime        *int64                          `protobuf:"varint,2,req" json:"EventTime,omitempty"`
	Text             *string                         `protobuf:"bytes,3,req" json:"Text,omitempty"`
	Target           *LobbyChatMessage_MessageTarget `protobuf:"varint,4,req,enum=tesla.LobbyChatMessage_MessageTarget" json:"Target,omitempty"`
	XXX_unrecognized []byte                          `json:"-"`
}

func (m *LobbyChatMessage) Reset()         { *m = LobbyChatMessage{} }
func (m *LobbyChatMessage) String() string { return proto.CompactTextString(m) }
func (*LobbyChatMessage) ProtoMessage()    {}

func (m *LobbyChatMessage) GetPlayerID() uint64 {
	if m != nil && m.PlayerID != nil {
		return *m.PlayerID
	}
	return 0
}

func (m *LobbyChatMessage) GetEventTime() int64 {
	if m != nil && m.EventTime != nil {
		return *m.EventTime
	}
	return 0
}

func (m *LobbyChatMessage) GetText() string {
	if m != nil && m.Text != nil {
		return *m.Text
	}
	return ""
}

func (m *LobbyChatMessage) GetTarget() LobbyChatMessage_MessageTarget {
	if m != nil && m.Target != nil {
		return *m.Target
	}
	return LobbyChatMessage_All
}

func init() {
	proto.RegisterEnum("tesla.LobbyChatMessage_MessageTarget", LobbyChatMessage_MessageTarget_name, LobbyChatMessage_MessageTarget_value)
}
