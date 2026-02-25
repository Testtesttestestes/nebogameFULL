using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Utils
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	public class OpTokenStorage<TKey, FTT, STT> : IDisposable
	{
		// Token: 0x060002CE RID: 718 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002CE")]
		public OpToken<FTT, STT> GetToken(TKey key)
		{
			return null;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x60002CF")]
		public bool TryGet(TKey key, out OpToken<FTT, STT> oparg)
		{
			return default(bool);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D0")]
		private void KillOpToken(OpToken<FTT, STT> op)
		{
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D1")]
		private void HandleOpFault(OpToken<FTT, STT> op)
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D2")]
		public void Dispose()
		{
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D3")]
		public OpTokenStorage()
		{
		}

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, OpToken<FTT, STT>> _ops;
	}
}
