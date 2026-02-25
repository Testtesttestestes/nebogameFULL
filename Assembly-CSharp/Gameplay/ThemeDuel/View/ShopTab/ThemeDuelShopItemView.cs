using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol;
using Protocol.Themeduel;
using UI;
using UI.Price;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Gameplay.ThemeDuel.View.ShopTab
{
	// Token: 0x020004DF RID: 1247
	[Token(Token = "0x20004DF")]
	[DisallowMultipleComponent]
	public class ThemeDuelShopItemView : AbstractDataRenderer<EventStoreItem>, IPointerEnterHandler, IEventSystemHandler, IToolTipDataProvider, IPointerClickHandler, IArtifactView
	{
		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001DBE RID: 7614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000555")]
		public IActionInfo Info
		{
			[Token(Token = "0x6001DBD")]
			[Address(RVA = "0x6F3B", Offset = "0x6F3B", VA = "0x6F3B", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DBE")]
			[Address(RVA = "0x6F3C", Offset = "0x6F3C", VA = "0x6F3C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001DC0 RID: 7616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000556")]
		public BackTime Backtime
		{
			[Token(Token = "0x6001DBF")]
			[Address(RVA = "0x6F3D", Offset = "0x6F3D", VA = "0x6F3D", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DC0")]
			[Address(RVA = "0x6F3E", Offset = "0x6F3E", VA = "0x6F3E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x00006390 File Offset: 0x00004590
		[Token(Token = "0x17000557")]
		public bool OnlyMarketAccount
		{
			[Token(Token = "0x6001DC1")]
			[Address(RVA = "0x6F3F", Offset = "0x6F3F", VA = "0x6F3F", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000558")]
		public ArtifactData ArtifactData
		{
			[Token(Token = "0x6001DC2")]
			[Address(RVA = "0x6F40", Offset = "0x6F40", VA = "0x6F40", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x000063A8 File Offset: 0x000045A8
		// (set) Token: 0x06001DC4 RID: 7620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000559")]
		public ArtifactView.ArtifactViewArgs Args
		{
			[Token(Token = "0x6001DC3")]
			[Address(RVA = "0x6F41", Offset = "0x6F41", VA = "0x6F41", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(ArtifactView.ArtifactViewArgs);
			}
			[Token(Token = "0x6001DC4")]
			[Address(RVA = "0x6F42", Offset = "0x6F42", VA = "0x6F42", Slot = "27")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700055A")]
		public GameObject GameObject
		{
			[Token(Token = "0x6001DC5")]
			[Address(RVA = "0x6F43", Offset = "0x6F43", VA = "0x6F43", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DC6")]
		[Address(RVA = "0x6F44", Offset = "0x6F44", VA = "0x6F44", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DC7")]
		[Address(RVA = "0x6F45", Offset = "0x6F45", VA = "0x6F45", Slot = "20")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001DC8")]
		[Address(RVA = "0x6F46", Offset = "0x6F46", VA = "0x6F46", Slot = "21")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001DC9 RID: 7625 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700055B")]
		public Image Marker
		{
			[Token(Token = "0x6001DC9")]
			[Address(RVA = "0x6F47", Offset = "0x6F47", VA = "0x6F47")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001DCA")]
		[Address(RVA = "0x6F48", Offset = "0x6F48", VA = "0x6F48")]
		private static ArtifactData GetArtifactData(ArtifactDetails artifactDetails)
		{
			return null;
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DCB")]
		[Address(RVA = "0x6F49", Offset = "0x6F49", VA = "0x6F49", Slot = "22")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DCC")]
		[Address(RVA = "0x6F4A", Offset = "0x6F4A", VA = "0x6F4A", Slot = "17")]
		protected override void StartListenEvents(EventStoreItem data)
		{
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DCD")]
		[Address(RVA = "0x6F4B", Offset = "0x6F4B", VA = "0x6F4B", Slot = "18")]
		protected override void StopListenEvents(EventStoreItem data)
		{
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DCE")]
		[Address(RVA = "0x6F4C", Offset = "0x6F4C", VA = "0x6F4C")]
		private void OnEventBalanceChanged(long value)
		{
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001DCF RID: 7631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700055C")]
		public IList<Sprite> MarkerSprites
		{
			[Token(Token = "0x6001DD0")]
			[Address(RVA = "0x6F4E", Offset = "0x6F4E", VA = "0x6F4E")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6001DCF")]
			[Address(RVA = "0x6F4D", Offset = "0x6F4D", VA = "0x6F4D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DD1")]
		[Address(RVA = "0x6F4F", Offset = "0x6F4F", VA = "0x6F4F", Slot = "16")]
		protected override void OnDataInvalidated()
		{
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DD2")]
		[Address(RVA = "0x6F50", Offset = "0x6F50", VA = "0x6F50")]
		public ThemeDuelShopItemView()
		{
		}

		// Token: 0x0400102D RID: 4141
		[Token(Token = "0x400102D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ArtikulView _artikulView;

		// Token: 0x0400102E RID: 4142
		[Token(Token = "0x400102E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PriceItemRenderer _price;

		// Token: 0x0400102F RID: 4143
		[Token(Token = "0x400102F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Image _marker;
	}
}
