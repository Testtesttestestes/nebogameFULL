using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011DE RID: 4574
	[Token(Token = "0x20011DE")]
	public class MarketBuilding : AbstractPathNode
	{
		// Token: 0x06006CCA RID: 27850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CCA")]
		[Address(RVA = "0xB7B6", Offset = "0xB7B6", VA = "0xB7B6", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CCB RID: 27851 RVA: 0x000140B8 File Offset: 0x000122B8
		[Token(Token = "0x6006CCB")]
		[Address(RVA = "0xB7B7", Offset = "0xB7B7", VA = "0xB7B7", Slot = "4")]
		public override bool Check()
		{
			return default(bool);
		}

		// Token: 0x06006CCC RID: 27852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CCC")]
		[Address(RVA = "0xB7B8", Offset = "0xB7B8", VA = "0xB7B8", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CCD RID: 27853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CCD")]
		[Address(RVA = "0xB7B9", Offset = "0xB7B9", VA = "0xB7B9")]
		public MarketBuilding()
		{
		}
	}
}
