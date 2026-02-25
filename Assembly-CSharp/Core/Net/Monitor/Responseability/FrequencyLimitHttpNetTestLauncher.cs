using System;
using Core.Net.Monitor.Responseability.Testing.Common;
using Il2CppDummyDll;

namespace Core.Net.Monitor.Responseability
{
	// Token: 0x02000E94 RID: 3732
	[Token(Token = "0x2000E94")]
	public class FrequencyLimitHttpNetTestLauncher : INetTestLauncher
	{
		// Token: 0x06005AC0 RID: 23232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AC0")]
		[Address(RVA = "0xA7AB", Offset = "0xA7AB", VA = "0xA7AB")]
		public FrequencyLimitHttpNetTestLauncher(long period, Uri uri, Configuration configuration, object syncMonitor)
		{
		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x06005AC1 RID: 23233 RVA: 0x00010200 File Offset: 0x0000E400
		[Token(Token = "0x17001282")]
		private int DampingThreshold
		{
			[Token(Token = "0x6005AC1")]
			[Address(RVA = "0xA7AC", Offset = "0xA7AC", VA = "0xA7AC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06005AC2 RID: 23234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AC2")]
		[Address(RVA = "0xA7AD", Offset = "0xA7AD", VA = "0xA7AD")]
		private void SetCount(long value)
		{
		}

		// Token: 0x06005AC3 RID: 23235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AC3")]
		[Address(RVA = "0xA7AE", Offset = "0xA7AE", VA = "0xA7AE")]
		private void CommitTimes()
		{
		}

		// Token: 0x06005AC4 RID: 23236 RVA: 0x00010218 File Offset: 0x0000E418
		[Token(Token = "0x6005AC4")]
		[Address(RVA = "0xA7AF", Offset = "0xA7AF", VA = "0xA7AF", Slot = "4")]
		public bool TryCreateTest(out INetTest test)
		{
			return default(bool);
		}

		// Token: 0x06005AC5 RID: 23237 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005AC5")]
		[Address(RVA = "0xA7B0", Offset = "0xA7B0", VA = "0xA7B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04003198 RID: 12696
		[Token(Token = "0x4003198")]
		[FieldOffset(Offset = "0x8")]
		private readonly Uri _uri;

		// Token: 0x04003199 RID: 12697
		[Token(Token = "0x4003199")]
		[FieldOffset(Offset = "0xC")]
		private readonly Configuration _configuration;

		// Token: 0x0400319A RID: 12698
		[Token(Token = "0x400319A")]
		[FieldOffset(Offset = "0x10")]
		private object _syncMonitor;

		// Token: 0x0400319B RID: 12699
		[Token(Token = "0x400319B")]
		[FieldOffset(Offset = "0x18")]
		private readonly long _period;

		// Token: 0x0400319C RID: 12700
		[Token(Token = "0x400319C")]
		[FieldOffset(Offset = "0x20")]
		private long _count;

		// Token: 0x0400319D RID: 12701
		[Token(Token = "0x400319D")]
		[FieldOffset(Offset = "0x28")]
		private long _last;

		// Token: 0x0400319E RID: 12702
		[Token(Token = "0x400319E")]
		[FieldOffset(Offset = "0x30")]
		private long _sinceCall;

		// Token: 0x0400319F RID: 12703
		[Token(Token = "0x400319F")]
		[FieldOffset(Offset = "0x38")]
		private int _dampingCoeff;
	}
}
