using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011D9 RID: 4569
	[Token(Token = "0x20011D9")]
	public class Feedback : AbstractPathNode
	{
		// Token: 0x06006CB8 RID: 27832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB8")]
		[Address(RVA = "0xB7A4", Offset = "0xB7A4", VA = "0xB7A4", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CB9 RID: 27833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB9")]
		[Address(RVA = "0xB7A5", Offset = "0xB7A5", VA = "0xB7A5", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CBA RID: 27834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CBA")]
		[Address(RVA = "0xB7A6", Offset = "0xB7A6", VA = "0xB7A6")]
		public Feedback()
		{
		}
	}
}
