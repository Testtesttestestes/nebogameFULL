using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011E1 RID: 4577
	[Token(Token = "0x20011E1")]
	public class NotSupported : AbstractPathNode
	{
		// Token: 0x06006CD4 RID: 27860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CD4")]
		[Address(RVA = "0xB7C0", Offset = "0xB7C0", VA = "0xB7C0", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CD5 RID: 27861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CD5")]
		[Address(RVA = "0xB7C1", Offset = "0xB7C1", VA = "0xB7C1", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CD6 RID: 27862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CD6")]
		[Address(RVA = "0xB7C2", Offset = "0xB7C2", VA = "0xB7C2")]
		public NotSupported()
		{
		}
	}
}
