using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011E7 RID: 4583
	[Token(Token = "0x20011E7")]
	public class UserInfo : AbstractPathNode
	{
		// Token: 0x06006CE7 RID: 27879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CE7")]
		[Address(RVA = "0xB7D3", Offset = "0xB7D3", VA = "0xB7D3", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CE8 RID: 27880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CE8")]
		[Address(RVA = "0xB7D4", Offset = "0xB7D4", VA = "0xB7D4", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CE9 RID: 27881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CE9")]
		[Address(RVA = "0xB7D5", Offset = "0xB7D5", VA = "0xB7D5")]
		public UserInfo()
		{
		}
	}
}
