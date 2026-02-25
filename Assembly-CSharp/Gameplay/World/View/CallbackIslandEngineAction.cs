using System;
using CloudsFly;
using Gameplay.World.Model.View.IslandEngineActions;
using Il2CppDummyDll;

namespace Gameplay.World.View
{
	// Token: 0x02000356 RID: 854
	[Token(Token = "0x2000356")]
	public class CallbackIslandEngineAction : BaseIsleEngineAction
	{
		// Token: 0x06001381 RID: 4993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001381")]
		[Address(RVA = "0x6571", Offset = "0x6571", VA = "0x6571")]
		public CallbackIslandEngineAction(IIsleWorldObjectEngine engine, Action callback)
		{
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001382")]
		[Address(RVA = "0x6572", Offset = "0x6572", VA = "0x6572", Slot = "5")]
		public override void Invoke(Action<BaseIsleEngineAction> endCallback)
		{
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001383")]
		[Address(RVA = "0x6573", Offset = "0x6573", VA = "0x6573", Slot = "6")]
		public override void Cancel()
		{
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001384")]
		[Address(RVA = "0x6574", Offset = "0x6574", VA = "0x6574", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x04000A75 RID: 2677
		[Token(Token = "0x4000A75")]
		[FieldOffset(Offset = "0xC")]
		protected Action callback;
	}
}
