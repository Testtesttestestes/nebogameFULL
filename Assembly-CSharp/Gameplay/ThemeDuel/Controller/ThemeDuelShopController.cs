using System;
using System.Runtime.CompilerServices;
using Gameplay.Inventory.View;
using Gameplay.ThemeDuel.Events;
using Gameplay.ThemeDuel.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Themeduel;
using ServicesNamespace;
using UI;
using Utils;

namespace Gameplay.ThemeDuel.Controller
{
	// Token: 0x020004F3 RID: 1267
	[Token(Token = "0x20004F3")]
	public class ThemeDuelShopController : AbstractController<ThemeDuelModel, ThemeDuelEvents>
	{
		// Token: 0x06001E3D RID: 7741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E3D")]
		[Address(RVA = "0x6FBB", Offset = "0x6FBB", VA = "0x6FBB")]
		public ThemeDuelShopController(ThemeDuelModel model, ThemeDuelEvents events)
		{
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001E3E RID: 7742 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001E3F RID: 7743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057C")]
		public ProtoGetEventStoreItemsInfoAns StoreItemsInfo
		{
			[Token(Token = "0x6001E3E")]
			[Address(RVA = "0x6FBC", Offset = "0x6FBC", VA = "0x6FBC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E3F")]
			[Address(RVA = "0x6FBD", Offset = "0x6FBD", VA = "0x6FBD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E40")]
		[Address(RVA = "0x6FBE", Offset = "0x6FBE", VA = "0x6FBE")]
		public void GetEventStoreItemsInfo()
		{
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E41")]
		[Address(RVA = "0x6FBF", Offset = "0x6FBF", VA = "0x6FBF")]
		private void OnGetEventStoreItemsInfo(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E42")]
		[Address(RVA = "0x6FC0", Offset = "0x6FC0", VA = "0x6FC0", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E43")]
		[Address(RVA = "0x6FC1", Offset = "0x6FC1", VA = "0x6FC1")]
		public void BuyShopItem(IArtifactView item)
		{
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E44")]
		[Address(RVA = "0x6FC2", Offset = "0x6FC2", VA = "0x6FC2")]
		private void PopupOnClose()
		{
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E45")]
		[Address(RVA = "0x6FC3", Offset = "0x6FC3", VA = "0x6FC3")]
		private void OnBuyEventShopItem(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x04001073 RID: 4211
		[Token(Token = "0x4001073")]
		[FieldOffset(Offset = "0x18")]
		private readonly ThemeDuelService _themeDuelService;

		// Token: 0x04001074 RID: 4212
		[Token(Token = "0x4001074")]
		[FieldOffset(Offset = "0x1C")]
		private NotEnoughTdScoreWindow _popup;
	}
}
