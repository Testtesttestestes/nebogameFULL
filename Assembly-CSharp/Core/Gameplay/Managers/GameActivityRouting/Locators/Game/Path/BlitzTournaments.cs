using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011CE RID: 4558
	[Token(Token = "0x20011CE")]
	public class BlitzTournaments : AbstractPathNode
	{
		// Token: 0x06006C93 RID: 27795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C93")]
		[Address(RVA = "0xB77F", Offset = "0xB77F", VA = "0xB77F", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006C94 RID: 27796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C94")]
		[Address(RVA = "0xB780", Offset = "0xB780", VA = "0xB780", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006C95 RID: 27797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C95")]
		[Address(RVA = "0xB781", Offset = "0xB781", VA = "0xB781")]
		public BlitzTournaments()
		{
		}
	}
}
