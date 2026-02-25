using System;
using CloudsFly;
using Il2CppDummyDll;

namespace Gameplay.World.Model.View.IslandEngineActions
{
	// Token: 0x0200036E RID: 878
	[Token(Token = "0x200036E")]
	public abstract class BaseIsleEngineAction : IDisposable
	{
		// Token: 0x06001478 RID: 5240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001478")]
		[Address(RVA = "0x6645", Offset = "0x6645", VA = "0x6645")]
		protected BaseIsleEngineAction(IIsleWorldObjectEngine engine)
		{
		}

		// Token: 0x06001479 RID: 5241
		[Token(Token = "0x6001479")]
		public abstract void Invoke(Action<BaseIsleEngineAction> endCallback);

		// Token: 0x0600147A RID: 5242
		[Token(Token = "0x600147A")]
		public abstract void Cancel();

		// Token: 0x0600147B RID: 5243
		[Token(Token = "0x600147B")]
		public abstract void Dispose();

		// Token: 0x04000AE1 RID: 2785
		[Token(Token = "0x4000AE1")]
		[FieldOffset(Offset = "0x8")]
		protected IIsleWorldObjectEngine _engine;
	}
}
