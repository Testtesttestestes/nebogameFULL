using System;
using System.Runtime.CompilerServices;
using Core.Net.Factories;
using Google.Protobuf;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Core.Net
{
	// Token: 0x02000E91 RID: 3729
	[Token(Token = "0x2000E91")]
	public class SrvAnswer : ISrvAnswer
	{
		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x06005A9A RID: 23194 RVA: 0x00010170 File Offset: 0x0000E370
		[Token(Token = "0x17001275")]
		public uint CmdIndex
		{
			[Token(Token = "0x6005A9A")]
			[Address(RVA = "0xA787", Offset = "0xA787", VA = "0xA787", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x06005A9B RID: 23195 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005A9C RID: 23196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001276")]
		public IMessage Message
		{
			[Token(Token = "0x6005A9B")]
			[Address(RVA = "0xA788", Offset = "0xA788", VA = "0xA788", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A9C")]
			[Address(RVA = "0xA789", Offset = "0xA789", VA = "0xA789")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x06005A9D RID: 23197 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005A9E RID: 23198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001277")]
		[CanBeNull]
		public PacketParser.Packet Packet
		{
			[Token(Token = "0x6005A9D")]
			[Address(RVA = "0xA78A", Offset = "0xA78A", VA = "0xA78A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A9E")]
			[Address(RVA = "0xA78B", Offset = "0xA78B", VA = "0xA78B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x06005A9F RID: 23199 RVA: 0x00010188 File Offset: 0x0000E388
		// (set) Token: 0x06005AA0 RID: 23200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001278")]
		public long Latency
		{
			[Token(Token = "0x6005A9F")]
			[Address(RVA = "0xA78C", Offset = "0xA78C", VA = "0xA78C", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6005AA0")]
			[Address(RVA = "0xA78D", Offset = "0xA78D", VA = "0xA78D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005AA1 RID: 23201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AA1")]
		[Address(RVA = "0xA78E", Offset = "0xA78E", VA = "0xA78E")]
		private SrvAnswer(uint cmdIndex, short serviceId, uint eventId)
		{
		}

		// Token: 0x06005AA2 RID: 23202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AA2")]
		[Address(RVA = "0xA78F", Offset = "0xA78F", VA = "0xA78F")]
		private void Parse(PacketParser.Packet packet, IProtocolMessageFactory factory)
		{
		}

		// Token: 0x06005AA3 RID: 23203 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005AA3")]
		[Address(RVA = "0xA790", Offset = "0xA790", VA = "0xA790")]
		public static SrvAnswer Create(PacketParser.Packet packet, IProtocolMessageFactory factory)
		{
			return null;
		}

		// Token: 0x06005AA4 RID: 23204 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005AA4")]
		[Address(RVA = "0xA791", Offset = "0xA791", VA = "0xA791")]
		public static SrvAnswer Create(PacketParser.Packet packet, ISrvCommand cmd)
		{
			return null;
		}

		// Token: 0x0400317D RID: 12669
		[Token(Token = "0x400317D")]
		[FieldOffset(Offset = "0xC")]
		public readonly short ServiceId;

		// Token: 0x0400317E RID: 12670
		[Token(Token = "0x400317E")]
		[FieldOffset(Offset = "0x10")]
		public readonly uint EventId;

		// Token: 0x0400317F RID: 12671
		[Token(Token = "0x400317F")]
		[FieldOffset(Offset = "0x18")]
		public readonly long ReceiveTimestamp;
	}
}
