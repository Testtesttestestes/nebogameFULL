using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011E0 RID: 4576
	[Token(Token = "0x20011E0")]
	public class MenuSettings : AbstractPathNode
	{
		// Token: 0x06006CD1 RID: 27857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CD1")]
		[Address(RVA = "0xB7BD", Offset = "0xB7BD", VA = "0xB7BD", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CD2 RID: 27858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CD2")]
		[Address(RVA = "0xB7BE", Offset = "0xB7BE", VA = "0xB7BE", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CD3 RID: 27859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CD3")]
		[Address(RVA = "0xB7BF", Offset = "0xB7BF", VA = "0xB7BF")]
		public MenuSettings()
		{
		}
	}
}
