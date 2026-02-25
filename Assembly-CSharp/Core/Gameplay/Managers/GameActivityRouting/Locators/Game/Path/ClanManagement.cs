using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011D2 RID: 4562
	[Token(Token = "0x20011D2")]
	public class ClanManagement : AbstractPathNode
	{
		// Token: 0x06006CA2 RID: 27810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CA2")]
		[Address(RVA = "0xB78E", Offset = "0xB78E", VA = "0xB78E", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CA3 RID: 27811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CA3")]
		[Address(RVA = "0xB78F", Offset = "0xB78F", VA = "0xB78F", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CA4 RID: 27812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CA4")]
		[Address(RVA = "0xB790", Offset = "0xB790", VA = "0xB790")]
		public ClanManagement()
		{
		}
	}
}
