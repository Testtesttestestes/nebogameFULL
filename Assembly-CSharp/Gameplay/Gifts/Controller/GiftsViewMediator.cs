using System;
using Gameplay.Gifts.Events;
using Gameplay.Gifts.Model;
using Gameplay.Gifts.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using TMPro;

namespace Gameplay.Gifts.Controller
{
	// Token: 0x0200071B RID: 1819
	[Token(Token = "0x200071B")]
	public class GiftsViewMediator : AbstractViewMediator<GiftsModel, GiftsEvents, GiftsController, GiftsView>
	{
		// Token: 0x06002B84 RID: 11140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B84")]
		[Address(RVA = "0x7C1B", Offset = "0x7C1B", VA = "0x7C1B")]
		public GiftsViewMediator(GiftsModel model, GiftsEvents events, GiftsController controller)
		{
		}

		// Token: 0x1700084C RID: 2124
		// (set) Token: 0x06002B85 RID: 11141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084C")]
		public override GiftsView View
		{
			[Token(Token = "0x6002B85")]
			[Address(RVA = "0x7C1C", Offset = "0x7C1C", VA = "0x7C1C", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x1700084D RID: 2125
		// (set) Token: 0x06002B86 RID: 11142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084D")]
		public override GiftsEvents Events
		{
			[Token(Token = "0x6002B86")]
			[Address(RVA = "0x7C1D", Offset = "0x7C1D", VA = "0x7C1D", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B87")]
		[Address(RVA = "0x7C1E", Offset = "0x7C1E", VA = "0x7C1E")]
		private void Init()
		{
		}

		// Token: 0x06002B88 RID: 11144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B88")]
		[Address(RVA = "0x7C1F", Offset = "0x7C1F", VA = "0x7C1F")]
		private void GiftsStatusRequestedEventHandler()
		{
		}

		// Token: 0x06002B89 RID: 11145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B89")]
		[Address(RVA = "0x7C20", Offset = "0x7C20", VA = "0x7C20")]
		private void SendGiftEventHandler(GiftView view)
		{
		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B8A")]
		[Address(RVA = "0x7C21", Offset = "0x7C21", VA = "0x7C21")]
		private void GiftInfoButtonClickEventHandler(GiftView giftUI)
		{
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B8B")]
		[Address(RVA = "0x7C22", Offset = "0x7C22", VA = "0x7C22")]
		private void GiftSentEventHandler()
		{
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B8C")]
		[Address(RVA = "0x7C23", Offset = "0x7C23", VA = "0x7C23")]
		private void InitGiftView(SocialGiftDic gift, GiftView instance)
		{
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B8D")]
		[Address(RVA = "0x7C24", Offset = "0x7C24", VA = "0x7C24")]
		private void DisableAllSendButtons()
		{
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B8E")]
		[Address(RVA = "0x7C25", Offset = "0x7C25", VA = "0x7C25")]
		private void RefreshAnnotation()
		{
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B8F")]
		[Address(RVA = "0x7C26", Offset = "0x7C26", VA = "0x7C26")]
		private void UpdateAnnotation(TextMeshProUGUI text, string owner, int maxGifts, int giftsLeft)
		{
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B90")]
		[Address(RVA = "0x7C27", Offset = "0x7C27", VA = "0x7C27")]
		private void UpdateSentAnnotation(TextMeshProUGUI text)
		{
		}

		// Token: 0x040017D1 RID: 6097
		[Token(Token = "0x40017D1")]
		[FieldOffset(Offset = "0x18")]
		private GiftView[] _giftInstances;

		// Token: 0x040017D2 RID: 6098
		[Token(Token = "0x40017D2")]
		[FieldOffset(Offset = "0x1C")]
		private GiftInfoWindow _infoWindow;
	}
}
