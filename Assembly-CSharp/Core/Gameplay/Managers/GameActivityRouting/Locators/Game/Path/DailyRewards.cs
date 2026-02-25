using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011D7 RID: 4567
	[Token(Token = "0x20011D7")]
	public class DailyRewards : AbstractPathNode
	{
		// Token: 0x06006CB1 RID: 27825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB1")]
		[Address(RVA = "0xB79D", Offset = "0xB79D", VA = "0xB79D", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CB2 RID: 27826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB2")]
		[Address(RVA = "0xB79E", Offset = "0xB79E", VA = "0xB79E", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CB3 RID: 27827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB3")]
		[Address(RVA = "0xB79F", Offset = "0xB79F", VA = "0xB79F")]
		public DailyRewards()
		{
		}
	}
}
