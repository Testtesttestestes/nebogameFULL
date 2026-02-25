using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;

namespace Utils
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	public class TweenContainer : IDisposable
	{
		// Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x576E", Offset = "0x576E", VA = "0x576E")]
		public void AddTween(Tween tween)
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x576F", Offset = "0x576F", VA = "0x576F")]
		public void StopAllTweens()
		{
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x5770", Offset = "0x5770", VA = "0x5770", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x5771", Offset = "0x5771", VA = "0x5771")]
		public TweenContainer()
		{
		}

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x8")]
		private readonly List<Tween> _tweens;
	}
}
