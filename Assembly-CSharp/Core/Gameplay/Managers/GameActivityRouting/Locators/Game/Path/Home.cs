using System;
using CloudsFly.Movement;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011DB RID: 4571
	[Token(Token = "0x20011DB")]
	public class Home : AbstractPathNode
	{
		// Token: 0x06006CBE RID: 27838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CBE")]
		[Address(RVA = "0xB7AA", Offset = "0xB7AA", VA = "0xB7AA", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CBF RID: 27839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CBF")]
		[Address(RVA = "0xB7AB", Offset = "0xB7AB", VA = "0xB7AB")]
		private void MovCompleteEvent(WorldMovementTypes obj)
		{
		}

		// Token: 0x06006CC0 RID: 27840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CC0")]
		[Address(RVA = "0xB7AC", Offset = "0xB7AC", VA = "0xB7AC", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CC1 RID: 27841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CC1")]
		[Address(RVA = "0xB7AD", Offset = "0xB7AD", VA = "0xB7AD")]
		private void Complete()
		{
		}

		// Token: 0x06006CC2 RID: 27842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CC2")]
		[Address(RVA = "0xB7AE", Offset = "0xB7AE", VA = "0xB7AE")]
		public Home()
		{
		}

		// Token: 0x04003909 RID: 14601
		[Token(Token = "0x4003909")]
		[FieldOffset(Offset = "0x18")]
		private LocatorPayload _payload;
	}
}
