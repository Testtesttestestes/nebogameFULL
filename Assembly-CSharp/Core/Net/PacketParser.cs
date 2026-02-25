using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Net
{
	// Token: 0x02000E8A RID: 3722
	[Token(Token = "0x2000E8A")]
	public class PacketParser : IPacketParser
	{
		// Token: 0x14000222 RID: 546
		// (add) Token: 0x06005A88 RID: 23176 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005A89 RID: 23177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000222")]
		public event Action<PacketParser.Packet> CompleteEvent
		{
			[Token(Token = "0x6005A88")]
			[Address(RVA = "0xA778", Offset = "0xA778", VA = "0xA778", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005A89")]
			[Address(RVA = "0xA779", Offset = "0xA779", VA = "0xA779", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06005A8A RID: 23178 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005A8A")]
		[Address(RVA = "0xA77A", Offset = "0xA77A", VA = "0xA77A", Slot = "6")]
		public byte[] Serialize(SrvCommand command)
		{
			return null;
		}

		// Token: 0x06005A8B RID: 23179 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005A8B")]
		[Address(RVA = "0xA77B", Offset = "0xA77B", VA = "0xA77B")]
		public byte[] Serialize(string sessionId, short serviceId, uint commandIndex, short commandId, byte[] payload)
		{
			return null;
		}

		// Token: 0x06005A8C RID: 23180 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005A8C")]
		[Address(RVA = "0x362D", Offset = "0x362D", VA = "0x362D")]
		private PacketParser.Packet CompletePacket(PacketParser.Packet packet)
		{
			return null;
		}

		// Token: 0x06005A8D RID: 23181 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005A8D")]
		[Address(RVA = "0xA77C", Offset = "0xA77C", VA = "0xA77C", Slot = "7")]
		public IList<PacketParser.Packet> Deserialize(byte[] bytes)
		{
			return null;
		}

		// Token: 0x06005A8E RID: 23182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A8E")]
		[Address(RVA = "0xA77D", Offset = "0xA77D", VA = "0xA77D", Slot = "8")]
		public void Reset()
		{
		}

		// Token: 0x06005A8F RID: 23183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A8F")]
		[Address(RVA = "0xA77E", Offset = "0xA77E", VA = "0xA77E")]
		public PacketParser()
		{
		}

		// Token: 0x04003164 RID: 12644
		[Token(Token = "0x4003164")]
		[FieldOffset(Offset = "0xC")]
		private PacketParser.Packet _currentPacket;

		// Token: 0x04003165 RID: 12645
		[Token(Token = "0x4003165")]
		[FieldOffset(Offset = "0x10")]
		private PacketParser.ReaderState _readerState;

		// Token: 0x02000E8B RID: 3723
		[Token(Token = "0x2000E8B")]
		private enum ReaderState
		{
			// Token: 0x04003167 RID: 12647
			[Token(Token = "0x4003167")]
			PACKETREADER_STATE_CMDNUM_B1,
			// Token: 0x04003168 RID: 12648
			[Token(Token = "0x4003168")]
			PACKETREADER_STATE_CMDNUM_B2,
			// Token: 0x04003169 RID: 12649
			[Token(Token = "0x4003169")]
			PACKETREADER_STATE_CMDNUM_B3,
			// Token: 0x0400316A RID: 12650
			[Token(Token = "0x400316A")]
			PACKETREADER_STATE_CMDNUM_B4,
			// Token: 0x0400316B RID: 12651
			[Token(Token = "0x400316B")]
			PACKETREADER_STATE_DATALEN_B1,
			// Token: 0x0400316C RID: 12652
			[Token(Token = "0x400316C")]
			PACKETREADER_STATE_DATALEN_B2,
			// Token: 0x0400316D RID: 12653
			[Token(Token = "0x400316D")]
			PACKETREADER_STATE_DATALEN_B3,
			// Token: 0x0400316E RID: 12654
			[Token(Token = "0x400316E")]
			PACKETREADER_STATE_DATALEN_B4,
			// Token: 0x0400316F RID: 12655
			[Token(Token = "0x400316F")]
			PACKETREADER_STATE_READING_ANSWER
		}

		// Token: 0x02000E8C RID: 3724
		[Token(Token = "0x2000E8C")]
		public class Packet
		{
			// Token: 0x06005A90 RID: 23184 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6005A90")]
			[Address(RVA = "0xA77F", Offset = "0xA77F", VA = "0xA77F", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06005A91 RID: 23185 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005A91")]
			[Address(RVA = "0xA780", Offset = "0xA780", VA = "0xA780")]
			public Packet()
			{
			}

			// Token: 0x04003170 RID: 12656
			[Token(Token = "0x4003170")]
			[FieldOffset(Offset = "0x8")]
			public uint CmdIndex;

			// Token: 0x04003171 RID: 12657
			[Token(Token = "0x4003171")]
			[FieldOffset(Offset = "0xC")]
			public uint PacketContentLen;

			// Token: 0x04003172 RID: 12658
			[Token(Token = "0x4003172")]
			[FieldOffset(Offset = "0x10")]
			public byte[] AnswerContent;

			// Token: 0x04003173 RID: 12659
			[Token(Token = "0x4003173")]
			[FieldOffset(Offset = "0x14")]
			public int ReceivedPacketContentByteCount;

			// Token: 0x04003174 RID: 12660
			[Token(Token = "0x4003174")]
			[FieldOffset(Offset = "0x18")]
			public short ServiceId;

			// Token: 0x04003175 RID: 12661
			[Token(Token = "0x4003175")]
			[FieldOffset(Offset = "0x1C")]
			public uint EventId;

			// Token: 0x04003176 RID: 12662
			[Token(Token = "0x4003176")]
			[FieldOffset(Offset = "0x20")]
			public int RawEventId;
		}
	}
}
