using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Utils
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	public class OpTokenRepository : IDisposable
	{
		// Token: 0x060002D4 RID: 724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x5750", Offset = "0x5750", VA = "0x5750", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x5751", Offset = "0x5751", VA = "0x5751")]
		public OpTokenRepository()
		{
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x5752", Offset = "0x5752", VA = "0x5752")]
		public bool TryGet(object index, out IOpToken token)
		{
			return default(bool);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x5753", Offset = "0x5753", VA = "0x5753")]
		public void Add(IOpToken token)
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x5754", Offset = "0x5754", VA = "0x5754")]
		public void Remove(IOpToken token)
		{
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x5755", Offset = "0x5755", VA = "0x5755")]
		public void Cancel()
		{
		}

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x8")]
		private readonly LinkedList<IOpToken> _tokens;
	}
}
