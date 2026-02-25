using System;
using CloudsFly;
using CloudsFly.Movement;
using Gameplay.Isles.Base;
using Il2CppDummyDll;

namespace Gameplay.World.Model.View.IslandEngineActions
{
	// Token: 0x02000371 RID: 881
	[Token(Token = "0x2000371")]
	public class MoveToIslandEngineAction : BaseIsleEngineAction
	{
		// Token: 0x06001487 RID: 5255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001487")]
		[Address(RVA = "0x6651", Offset = "0x6651", VA = "0x6651")]
		public MoveToIslandEngineAction(IIsleWorldObjectEngine engine, IIsle isle, WorldMovementTypes type)
		{
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001488")]
		[Address(RVA = "0x6652", Offset = "0x6652", VA = "0x6652", Slot = "5")]
		public override void Invoke(Action<BaseIsleEngineAction> endCallback)
		{
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001489")]
		[Address(RVA = "0x6653", Offset = "0x6653", VA = "0x6653", Slot = "6")]
		public override void Cancel()
		{
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148A")]
		[Address(RVA = "0x6654", Offset = "0x6654", VA = "0x6654", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148B")]
		[Address(RVA = "0x6655", Offset = "0x6655", VA = "0x6655")]
		private void Callback()
		{
		}

		// Token: 0x04000AE9 RID: 2793
		[Token(Token = "0x4000AE9")]
		[FieldOffset(Offset = "0xC")]
		private IIsle _isle;

		// Token: 0x04000AEA RID: 2794
		[Token(Token = "0x4000AEA")]
		[FieldOffset(Offset = "0x10")]
		private WorldMovementTypes _type;

		// Token: 0x04000AEB RID: 2795
		[Token(Token = "0x4000AEB")]
		[FieldOffset(Offset = "0x14")]
		private Action<BaseIsleEngineAction> _endCallback;
	}
}
