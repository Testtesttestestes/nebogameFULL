using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011DC RID: 4572
	[Token(Token = "0x20011DC")]
	public class Idle : AbstractPathNode
	{
		// Token: 0x06006CC3 RID: 27843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CC3")]
		[Address(RVA = "0xB7AF", Offset = "0xB7AF", VA = "0xB7AF", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CC4 RID: 27844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CC4")]
		[Address(RVA = "0xB7B0", Offset = "0xB7B0", VA = "0xB7B0", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CC5 RID: 27845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CC5")]
		[Address(RVA = "0xB7B1", Offset = "0xB7B1", VA = "0xB7B1")]
		public Idle()
		{
		}
	}
}
