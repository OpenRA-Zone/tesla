// Code generated by protoc-gen-go.
// source: players.proto
// DO NOT EDIT!

package tesla

import proto "github.com/golang/protobuf/proto"
import math "math"

// Reference imports to suppress errors if they are not otherwise used.
var _ = proto.Marshal
var _ = math.Inf

type PlayerAuthenticationLevel int32

const (
	PlayerAuthenticationLevel_None      PlayerAuthenticationLevel = 0
	PlayerAuthenticationLevel_Anonymous PlayerAuthenticationLevel = 1
	PlayerAuthenticationLevel_Member    PlayerAuthenticationLevel = 2
	PlayerAuthenticationLevel_ProMember PlayerAuthenticationLevel = 3
	PlayerAuthenticationLevel_Mod       PlayerAuthenticationLevel = 21
	PlayerAuthenticationLevel_Admin     PlayerAuthenticationLevel = 42
)

var PlayerAuthenticationLevel_name = map[int32]string{
	0:  "None",
	1:  "Anonymous",
	2:  "Member",
	3:  "ProMember",
	21: "Mod",
	42: "Admin",
}
var PlayerAuthenticationLevel_value = map[string]int32{
	"None":      0,
	"Anonymous": 1,
	"Member":    2,
	"ProMember": 3,
	"Mod":       21,
	"Admin":     42,
}

func (x PlayerAuthenticationLevel) Enum() *PlayerAuthenticationLevel {
	p := new(PlayerAuthenticationLevel)
	*p = x
	return p
}
func (x PlayerAuthenticationLevel) String() string {
	return proto.EnumName(PlayerAuthenticationLevel_name, int32(x))
}
func (x *PlayerAuthenticationLevel) UnmarshalJSON(data []byte) error {
	value, err := proto.UnmarshalJSONEnum(PlayerAuthenticationLevel_value, data, "PlayerAuthenticationLevel")
	if err != nil {
		return err
	}
	*x = PlayerAuthenticationLevel(value)
	return nil
}

type PlayerReference struct {
	ID               *uint64 `protobuf:"varint,1,req" json:"ID,omitempty"`
	DisplayName      *string `protobuf:"bytes,2,req" json:"DisplayName,omitempty"`
	XXX_unrecognized []byte  `json:"-"`
}

func (m *PlayerReference) Reset()         { *m = PlayerReference{} }
func (m *PlayerReference) String() string { return proto.CompactTextString(m) }
func (*PlayerReference) ProtoMessage()    {}

func (m *PlayerReference) GetID() uint64 {
	if m != nil && m.ID != nil {
		return *m.ID
	}
	return 0
}

func (m *PlayerReference) GetDisplayName() string {
	if m != nil && m.DisplayName != nil {
		return *m.DisplayName
	}
	return ""
}

type PlayerInfo struct {
	ID               *uint64 `protobuf:"varint,1,req" json:"ID,omitempty"`
	DisplayName      *string `protobuf:"bytes,2,req" json:"DisplayName,omitempty"`
	XXX_unrecognized []byte  `json:"-"`
}

func (m *PlayerInfo) Reset()         { *m = PlayerInfo{} }
func (m *PlayerInfo) String() string { return proto.CompactTextString(m) }
func (*PlayerInfo) ProtoMessage()    {}

func (m *PlayerInfo) GetID() uint64 {
	if m != nil && m.ID != nil {
		return *m.ID
	}
	return 0
}

func (m *PlayerInfo) GetDisplayName() string {
	if m != nil && m.DisplayName != nil {
		return *m.DisplayName
	}
	return ""
}

func init() {
	proto.RegisterEnum("tesla.PlayerAuthenticationLevel", PlayerAuthenticationLevel_name, PlayerAuthenticationLevel_value)
}
