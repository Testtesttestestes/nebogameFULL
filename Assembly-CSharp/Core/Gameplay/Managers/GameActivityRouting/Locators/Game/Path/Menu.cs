using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011DF RID: 4575
	[Token(Token = "0x20011DF")]
	public class Menu : AbstractPathNode
	{
		// Token: 0x06006CCE RID: 27854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CCE")]
		[Address(RVA = "0xB7BA", Offset = "0xB7BA", VA = "0xB7BA", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CCF RID: 27855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CCF")]
		[Address(RVA = "0xB7BB", Offset = "0xB7BB", VA = "0xB7BB", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CD0 RID: 27856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CD0")]
		[Address(RVA = "0xB7BC", Offset = "0xB7BC", VA = "0xB7BC")]
		public Menu()
		{
		}
	}
}
