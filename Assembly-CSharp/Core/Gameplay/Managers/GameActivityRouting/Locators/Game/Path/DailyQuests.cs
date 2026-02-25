using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011D6 RID: 4566
	[Token(Token = "0x20011D6")]
	public class DailyQuests : AbstractPathNode
	{
		// Token: 0x06006CAE RID: 27822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CAE")]
		[Address(RVA = "0xB79A", Offset = "0xB79A", VA = "0xB79A", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CAF RID: 27823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CAF")]
		[Address(RVA = "0xB79B", Offset = "0xB79B", VA = "0xB79B", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CB0 RID: 27824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB0")]
		[Address(RVA = "0xB79C", Offset = "0xB79C", VA = "0xB79C")]
		public DailyQuests()
		{
		}
	}
}
