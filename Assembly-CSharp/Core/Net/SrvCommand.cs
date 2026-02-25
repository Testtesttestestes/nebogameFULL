using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Core.Net.Factories;
using Google.Protobuf;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Core.Net
{
	// Token: 0x02000E92 RID: 3730
	[Token(Token = "0x2000E92")]
	public class SrvCommand : ISrvCommand, IDisposable
	{
		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x06005AA5 RID: 23205 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005AA6 RID: 23206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001279")]
		public static string SessionId
		{
			[Token(Token = "0x6005AA5")]
			[Address(RVA = "0xA792", Offset = "0xA792", VA = "0xA792")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005AA6")]
			[Address(RVA = "0xA793", Offset = "0xA793", VA = "0xA793")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x06005AA7 RID: 23207 RVA: 0x000101A0 File Offset: 0x0000E3A0
		[Token(Token = "0x1700127A")]
		public uint CommandIndex
		{
			[Token(Token = "0x6005AA7")]
			[Address(RVA = "0xA794", Offset = "0xA794", VA = "0xA794", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x06005AA8 RID: 23208 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005AA9 RID: 23209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700127B")]
		public string Name
		{
			[Token(Token = "0x6005AA8")]
			[Address(RVA = "0xA795", Offset = "0xA795", VA = "0xA795")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005AA9")]
			[Address(RVA = "0xA796", Offset = "0xA796", VA = "0xA796")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x06005AAA RID: 23210 RVA: 0x000101B8 File Offset: 0x0000E3B8
		// (set) Token: 0x06005AAB RID: 23211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700127C")]
		public long Latency
		{
			[Token(Token = "0x6005AAA")]
			[Address(RVA = "0xA797", Offset = "0xA797", VA = "0xA797")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6005AAB")]
			[Address(RVA = "0xA798", Offset = "0xA798", VA = "0xA798")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x06005AAC RID: 23212 RVA: 0x000101D0 File Offset: 0x0000E3D0
		[Token(Token = "0x1700127D")]
		public long CreateTimestamp
		{
			[Token(Token = "0x6005AAC")]
			[Address(RVA = "0xA799", Offset = "0xA799", VA = "0xA799", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x06005AAD RID: 23213 RVA: 0x000101E8 File Offset: 0x0000E3E8
		// (set) Token: 0x06005AAE RID: 23214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700127E")]
		public long SerializeTimestamp
		{
			[Token(Token = "0x6005AAD")]
			[Address(RVA = "0xA79A", Offset = "0xA79A", VA = "0xA79A", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6005AAE")]
			[Address(RVA = "0xA79B", Offset = "0xA79B", VA = "0xA79B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x06005AAF RID: 23215 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005AB0 RID: 23216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700127F")]
		public IMessage Message
		{
			[Token(Token = "0x6005AAF")]
			[Address(RVA = "0xA79C", Offset = "0xA79C", VA = "0xA79C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005AB0")]
			[Address(RVA = "0xA79D", Offset = "0xA79D", VA = "0xA79D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005AB1 RID: 23217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AB1")]
		[Address(RVA = "0xA79E", Offset = "0xA79E", VA = "0xA79E", Slot = "9")]
		public void Dispose()
		{
		}

		// Token: 0x06005AB2 RID: 23218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AB2")]
		[Address(RVA = "0xA79F", Offset = "0xA79F", VA = "0xA79F", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06005AB3 RID: 23219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AB3")]
		[Address(RVA = "0xA7A0", Offset = "0xA7A0", VA = "0xA7A0")]
		private SrvCommand(string sId, short serviceId, short commandId, IMessage msg)
		{
		}

		// Token: 0x06005AB4 RID: 23220 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005AB4")]
		[Address(RVA = "0xA7A1", Offset = "0xA7A1", VA = "0xA7A1")]
		public static SrvCommand Create(short serviceId, short commandId, IMessage msg)
		{
			return null;
		}

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x06005AB5 RID: 23221 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005AB6 RID: 23222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001280")]
		public IProtocolMessageFactory MessageFactory
		{
			[Token(Token = "0x6005AB5")]
			[Address(RVA = "0xA7A2", Offset = "0xA7A2", VA = "0xA7A2", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005AB6")]
			[Address(RVA = "0xA7A3", Offset = "0xA7A3", VA = "0xA7A3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005AB7 RID: 23223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AB7")]
		public void SetCallback<TAnswer>(Action<SrvCommand, IMessage> callback) where TAnswer : IMessage, new()
		{
		}

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x06005AB8 RID: 23224 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001281")]
		public byte[] Payload
		{
			[Token(Token = "0x6005AB8")]
			[Address(RVA = "0xA7A4", Offset = "0xA7A4", VA = "0xA7A4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005AB9 RID: 23225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AB9")]
		[Address(RVA = "0xA7A5", Offset = "0xA7A5", VA = "0xA7A5")]
		public void Execute(ISrvAnswer answer)
		{
		}

		// Token: 0x06005ABA RID: 23226 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005ABA")]
		[Address(RVA = "0x3643", Offset = "0x3643", VA = "0x3643")]
		public byte[] Serialize(IPacketParser parser)
		{
			return null;
		}

		// Token: 0x06005ABB RID: 23227 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005ABB")]
		[Address(RVA = "0xA7A6", Offset = "0xA7A6", VA = "0xA7A6", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005ABC RID: 23228 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005ABC")]
		[Address(RVA = "0xA7A7", Offset = "0xA7A7", VA = "0xA7A7")]
		public string ToString([NotNull] ProtocolCommandInfoProvider infoProvider)
		{
			return null;
		}

		// Token: 0x04003183 RID: 12675
		[Token(Token = "0x4003183")]
		[FieldOffset(Offset = "0x0")]
		public static SynchronizationContext ExecuteContext;

		// Token: 0x04003184 RID: 12676
		[Token(Token = "0x4003184")]
		[FieldOffset(Offset = "0x4")]
		public static uint GlobalCommandIndexSequence;

		// Token: 0x04003186 RID: 12678
		[Token(Token = "0x4003186")]
		[FieldOffset(Offset = "0x8")]
		public readonly string SId;

		// Token: 0x04003188 RID: 12680
		[Token(Token = "0x4003188")]
		[FieldOffset(Offset = "0x10")]
		public readonly short ServiceId;

		// Token: 0x04003189 RID: 12681
		[Token(Token = "0x4003189")]
		[FieldOffset(Offset = "0x12")]
		public readonly short CommandId;

		// Token: 0x0400318F RID: 12687
		[Token(Token = "0x400318F")]
		[FieldOffset(Offset = "0x34")]
		private Action<SrvCommand, IMessage> _callback;

		// Token: 0x04003191 RID: 12689
		[Token(Token = "0x4003191")]
		[FieldOffset(Offset = "0x3C")]
		private byte[] _payload;
	}
}
