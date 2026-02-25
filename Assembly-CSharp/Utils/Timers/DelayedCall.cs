using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Utils.Timers
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	public class DelayedCall : IDisposable
	{
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000312 RID: 786 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000313 RID: 787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000D")]
		private event Action Callback
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x5785", Offset = "0x5785", VA = "0x5785")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x5786", Offset = "0x5786", VA = "0x5786")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x5787", Offset = "0x5787", VA = "0x5787")]
		public DelayedCall(Action callback)
		{
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x5788", Offset = "0x5788", VA = "0x5788")]
		public void SetDelay(float seconds)
		{
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x5789", Offset = "0x5789", VA = "0x5789")]
		public void SetDelay(BackTime backTime)
		{
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x578A", Offset = "0x578A", VA = "0x578A")]
		public void Cancel()
		{
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x578B", Offset = "0x578B", VA = "0x578B")]
		private UniTaskVoid DelayedCallAsync(CancellationToken token)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x578C", Offset = "0x578C", VA = "0x578C", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0xC")]
		private BackTime _backtime;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x10")]
		private CancellationTokenSource _source;
	}
}
