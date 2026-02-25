using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path.Stots
{
	// Token: 0x020011EA RID: 4586
	[Token(Token = "0x20011EA")]
	public class SlotsDiamond : AbstractPathNode
	{
		// Token: 0x06006CF0 RID: 27888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CF0")]
		[Address(RVA = "0xB7DC", Offset = "0xB7DC", VA = "0xB7DC", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CF1 RID: 27889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CF1")]
		[Address(RVA = "0xB7DD", Offset = "0xB7DD", VA = "0xB7DD", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CF2 RID: 27890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CF2")]
		[Address(RVA = "0xB7DE", Offset = "0xB7DE", VA = "0xB7DE")]
		public SlotsDiamond()
		{
		}
	}
}
