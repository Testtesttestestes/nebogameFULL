using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011D5 RID: 4565
	[Token(Token = "0x20011D5")]
	public class Craft : AbstractPathNode
	{
		// Token: 0x06006CAB RID: 27819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CAB")]
		[Address(RVA = "0xB797", Offset = "0xB797", VA = "0xB797", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CAC RID: 27820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CAC")]
		[Address(RVA = "0xB798", Offset = "0xB798", VA = "0xB798", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CAD RID: 27821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CAD")]
		[Address(RVA = "0xB799", Offset = "0xB799", VA = "0xB799")]
		public Craft()
		{
		}
	}
}
