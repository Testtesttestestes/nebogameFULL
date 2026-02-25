using System;
using Gameplay.ThemeDuel.Events;
using Gameplay.ThemeDuel.Model;
using Gameplay.ThemeDuel.View.ShopTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.ThemeDuel.Controller
{
	// Token: 0x020004F5 RID: 1269
	[Token(Token = "0x20004F5")]
	public class ThemeDuelShopViewMediator : AbstractViewMediator<ThemeDuelModel, ThemeDuelEvents, ThemeDuelShopController, ShopView>, IHideableMediator
	{
		// Token: 0x06001E48 RID: 7752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E48")]
		[Address(RVA = "0x6FC6", Offset = "0x6FC6", VA = "0x6FC6")]
		public ThemeDuelShopViewMediator(ThemeDuelModel model, ThemeDuelEvents events, ThemeDuelShopController controller)
		{
		}

		// Token: 0x1700057D RID: 1405
		// (set) Token: 0x06001E49 RID: 7753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057D")]
		public override ThemeDuelShopController Controller
		{
			[Token(Token = "0x6001E49")]
			[Address(RVA = "0x6FC7", Offset = "0x6FC7", VA = "0x6FC7", Slot = "18")]
			set
			{
			}
		}

		// Token: 0x1700057E RID: 1406
		// (set) Token: 0x06001E4A RID: 7754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057E")]
		public override ShopView View
		{
			[Token(Token = "0x6001E4A")]
			[Address(RVA = "0x6FC8", Offset = "0x6FC8", VA = "0x6FC8", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E4B")]
		[Address(RVA = "0x6FC9", Offset = "0x6FC9", VA = "0x6FC9", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E4C")]
		[Address(RVA = "0x6FCA", Offset = "0x6FCA", VA = "0x6FCA")]
		private void Init()
		{
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E4D")]
		[Address(RVA = "0x6FCB", Offset = "0x6FCB", VA = "0x6FCB")]
		private void GetStoreItemsInfoEvent()
		{
		}
	}
}
