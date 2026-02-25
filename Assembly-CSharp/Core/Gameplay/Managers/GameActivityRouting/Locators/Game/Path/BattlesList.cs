using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011CD RID: 4557
	[Token(Token = "0x20011CD")]
	public class BattlesList : AbstractPathNode
	{
		// Token: 0x06006C90 RID: 27792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C90")]
		[Address(RVA = "0xB77C", Offset = "0xB77C", VA = "0xB77C", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006C91 RID: 27793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C91")]
		[Address(RVA = "0xB77D", Offset = "0xB77D", VA = "0xB77D", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006C92 RID: 27794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C92")]
		[Address(RVA = "0xB77E", Offset = "0xB77E", VA = "0xB77E")]
		public BattlesList()
		{
		}
	}
}
