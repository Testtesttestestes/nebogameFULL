using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path.Stots
{
	// Token: 0x020011EB RID: 4587
	[Token(Token = "0x20011EB")]
	public class SlotsOnyx : AbstractPathNode
	{
		// Token: 0x06006CF3 RID: 27891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CF3")]
		[Address(RVA = "0xB7DF", Offset = "0xB7DF", VA = "0xB7DF", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CF4 RID: 27892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CF4")]
		[Address(RVA = "0xB7E0", Offset = "0xB7E0", VA = "0xB7E0", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CF5 RID: 27893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CF5")]
		[Address(RVA = "0xB7E1", Offset = "0xB7E1", VA = "0xB7E1")]
		public SlotsOnyx()
		{
		}
	}
}
