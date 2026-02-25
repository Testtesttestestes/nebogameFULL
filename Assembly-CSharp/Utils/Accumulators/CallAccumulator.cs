using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Utils.Accumulators
{
	// Token: 0x0200007B RID: 123
	[Token(Token = "0x200007B")]
	public class CallAccumulator : IDisposable
	{
		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000382 RID: 898 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000383 RID: 899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000011")]
		private event Action _call
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x57B5", Offset = "0x57B5", VA = "0x57B5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x57B6", Offset = "0x57B6", VA = "0x57B6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x57B7", Offset = "0x57B7", VA = "0x57B7")]
		public CallAccumulator(Action call, float timeout)
		{
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x57B8", Offset = "0x57B8", VA = "0x57B8")]
		public void Call()
		{
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x57B9", Offset = "0x57B9", VA = "0x57B9", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x57BA", Offset = "0x57BA", VA = "0x57BA")]
		private void RunTimer()
		{
		}

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0xC")]
		private readonly float _timeout;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x10")]
		private bool _running;
	}
}
