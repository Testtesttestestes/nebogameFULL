using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011CC RID: 4556
	[Token(Token = "0x20011CC")]
	public class Bank : AbstractPathNode
	{
		// Token: 0x06006C8D RID: 27789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C8D")]
		[Address(RVA = "0xB779", Offset = "0xB779", VA = "0xB779", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006C8E RID: 27790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C8E")]
		[Address(RVA = "0xB77A", Offset = "0xB77A", VA = "0xB77A", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006C8F RID: 27791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C8F")]
		[Address(RVA = "0xB77B", Offset = "0xB77B", VA = "0xB77B")]
		public Bank()
		{
		}
	}
}
