using System;
using CloudsFly.Movement;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011D1 RID: 4561
	[Token(Token = "0x20011D1")]
	public class ClanHome : AbstractPathNode
	{
		// Token: 0x06006C9D RID: 27805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C9D")]
		[Address(RVA = "0xB789", Offset = "0xB789", VA = "0xB789", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006C9E RID: 27806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C9E")]
		[Address(RVA = "0xB78A", Offset = "0xB78A", VA = "0xB78A")]
		private void MovCompleteEvent(WorldMovementTypes obj)
		{
		}

		// Token: 0x06006C9F RID: 27807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C9F")]
		[Address(RVA = "0xB78B", Offset = "0xB78B", VA = "0xB78B", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CA0 RID: 27808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CA0")]
		[Address(RVA = "0xB78C", Offset = "0xB78C", VA = "0xB78C")]
		private void Complete()
		{
		}

		// Token: 0x06006CA1 RID: 27809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CA1")]
		[Address(RVA = "0xB78D", Offset = "0xB78D", VA = "0xB78D")]
		public ClanHome()
		{
		}

		// Token: 0x04003908 RID: 14600
		[Token(Token = "0x4003908")]
		[FieldOffset(Offset = "0x18")]
		private LocatorPayload _payload;
	}
}
