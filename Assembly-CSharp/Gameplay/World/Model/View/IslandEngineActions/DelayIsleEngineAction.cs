using System;
using System.Collections;
using CloudsFly;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.World.Model.View.IslandEngineActions
{
	// Token: 0x0200036F RID: 879
	[Token(Token = "0x200036F")]
	public class DelayIsleEngineAction : BaseIsleEngineAction
	{
		// Token: 0x0600147C RID: 5244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600147C")]
		[Address(RVA = "0x6646", Offset = "0x6646", VA = "0x6646")]
		public DelayIsleEngineAction(IIsleWorldObjectEngine engine, float delay)
		{
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600147D")]
		[Address(RVA = "0x6647", Offset = "0x6647", VA = "0x6647", Slot = "5")]
		public override void Invoke(Action<BaseIsleEngineAction> endCallback)
		{
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600147E")]
		[Address(RVA = "0x6648", Offset = "0x6648", VA = "0x6648")]
		private IEnumerator DelayRoutine(Action<BaseIsleEngineAction> callback, float delay)
		{
			return null;
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600147F")]
		[Address(RVA = "0x6649", Offset = "0x6649", VA = "0x6649", Slot = "6")]
		public override void Cancel()
		{
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001480")]
		[Address(RVA = "0x664A", Offset = "0x664A", VA = "0x664A", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x04000AE2 RID: 2786
		[Token(Token = "0x4000AE2")]
		[FieldOffset(Offset = "0xC")]
		private readonly float _delay;

		// Token: 0x04000AE3 RID: 2787
		[Token(Token = "0x4000AE3")]
		[FieldOffset(Offset = "0x10")]
		private Coroutine _routine;
	}
}
