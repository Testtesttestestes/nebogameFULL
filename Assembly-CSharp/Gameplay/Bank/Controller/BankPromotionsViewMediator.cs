using System;
using Gameplay.Bank.Events;
using Gameplay.Bank.Model;
using Gameplay.Bank.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.Bank.Controller
{
	// Token: 0x02000C67 RID: 3175
	[Token(Token = "0x2000C67")]
	public class BankPromotionsViewMediator : AbstractViewMediator<BankModel, BankEvents, BankController, BankPromotionsView>
	{
		// Token: 0x06004D93 RID: 19859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D93")]
		[Address(RVA = "0x9BCB", Offset = "0x9BCB", VA = "0x9BCB")]
		public BankPromotionsViewMediator(BankModel model, BankEvents events, BankController controller)
		{
		}

		// Token: 0x17000FB7 RID: 4023
		// (set) Token: 0x06004D94 RID: 19860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FB7")]
		public override BankPromotionsView View
		{
			[Token(Token = "0x6004D94")]
			[Address(RVA = "0x9BCC", Offset = "0x9BCC", VA = "0x9BCC", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000FB8 RID: 4024
		// (set) Token: 0x06004D95 RID: 19861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FB8")]
		public override BankEvents Events
		{
			[Token(Token = "0x6004D95")]
			[Address(RVA = "0x9BCD", Offset = "0x9BCD", VA = "0x9BCD", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004D96 RID: 19862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D96")]
		[Address(RVA = "0x9BCE", Offset = "0x9BCE", VA = "0x9BCE")]
		private void ActivePromotionsReceivedEvent()
		{
		}

		// Token: 0x06004D97 RID: 19863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D97")]
		[Address(RVA = "0x9BCF", Offset = "0x9BCF", VA = "0x9BCF")]
		private void ViewOnShowInfoEvent(PromotionsDic promotionsDic)
		{
		}
	}
}
