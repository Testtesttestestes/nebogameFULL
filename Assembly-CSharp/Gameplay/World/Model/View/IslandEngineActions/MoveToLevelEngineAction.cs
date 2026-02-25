using System;
using CloudsFly;
using Gameplay.World.View;
using Il2CppDummyDll;

namespace Gameplay.World.Model.View.IslandEngineActions
{
	// Token: 0x02000372 RID: 882
	[Token(Token = "0x2000372")]
	public class MoveToLevelEngineAction : BaseIsleEngineAction
	{
		// Token: 0x0600148C RID: 5260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148C")]
		[Address(RVA = "0x6656", Offset = "0x6656", VA = "0x6656")]
		public MoveToLevelEngineAction(IIsleWorldObjectEngine engine, WorldLevel fromLevel, WorldLevel toLevel, Action<WorldLevel> levelChangedCallback, CloudsVerticalMovementAnimation cloudsVerticalMovementAnimation)
		{
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148D")]
		[Address(RVA = "0x6657", Offset = "0x6657", VA = "0x6657", Slot = "5")]
		public override void Invoke(Action<BaseIsleEngineAction> endCallback)
		{
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148E")]
		[Address(RVA = "0x6658", Offset = "0x6658", VA = "0x6658")]
		private void OnMovementMiddleCallback()
		{
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148F")]
		[Address(RVA = "0x6659", Offset = "0x6659", VA = "0x6659", Slot = "6")]
		public override void Cancel()
		{
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001490")]
		[Address(RVA = "0x665A", Offset = "0x665A", VA = "0x665A", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x04000AEC RID: 2796
		[Token(Token = "0x4000AEC")]
		[FieldOffset(Offset = "0xC")]
		private WorldLevel _fromLevel;

		// Token: 0x04000AED RID: 2797
		[Token(Token = "0x4000AED")]
		[FieldOffset(Offset = "0x10")]
		private WorldLevel _toLevel;

		// Token: 0x04000AEE RID: 2798
		[Token(Token = "0x4000AEE")]
		[FieldOffset(Offset = "0x14")]
		private Action<WorldLevel> _levelChangedCallback;

		// Token: 0x04000AEF RID: 2799
		[Token(Token = "0x4000AEF")]
		[FieldOffset(Offset = "0x18")]
		private CloudsVerticalMovementAnimation _cloudsVerticalMovementAnimation;

		// Token: 0x04000AF0 RID: 2800
		[Token(Token = "0x4000AF0")]
		[FieldOffset(Offset = "0x1C")]
		private Action<BaseIsleEngineAction> _endCallback;
	}
}
