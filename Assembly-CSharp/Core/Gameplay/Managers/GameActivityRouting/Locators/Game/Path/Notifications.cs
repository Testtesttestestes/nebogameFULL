using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011E2 RID: 4578
	[Token(Token = "0x20011E2")]
	public class Notifications : AbstractPathNode
	{
		// Token: 0x06006CD7 RID: 27863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CD7")]
		[Address(RVA = "0xB7C3", Offset = "0xB7C3", VA = "0xB7C3", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CD8 RID: 27864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CD8")]
		[Address(RVA = "0xB7C4", Offset = "0xB7C4", VA = "0xB7C4", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CD9 RID: 27865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CD9")]
		[Address(RVA = "0xB7C5", Offset = "0xB7C5", VA = "0xB7C5")]
		public Notifications()
		{
		}
	}
}
