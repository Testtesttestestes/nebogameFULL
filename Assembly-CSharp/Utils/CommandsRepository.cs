using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;

namespace Utils
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	public class CommandsRepository : IDisposable
	{
		// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x56D1", Offset = "0x56D1", VA = "0x56D1")]
		public CommandsRepository(float timeout = 3f)
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x56D2", Offset = "0x56D2", VA = "0x56D2")]
		public bool TryAdd(Enum id)
		{
			return default(bool);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x56D3", Offset = "0x56D3", VA = "0x56D3")]
		public void Remove(Enum id)
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x56D4", Offset = "0x56D4", VA = "0x56D4")]
		private void RefreshTimer()
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x56D5", Offset = "0x56D5", VA = "0x56D5")]
		private void Clear()
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x56D6", Offset = "0x56D6", VA = "0x56D6", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x8")]
		private readonly HashSet<Enum> _ids;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0xC")]
		private readonly float _timeout;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x10")]
		private Tween _tween;
	}
}
