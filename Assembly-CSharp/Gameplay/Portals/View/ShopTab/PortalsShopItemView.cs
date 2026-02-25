using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Inventory.View;
using Gameplay.Portals.Model;
using Il2CppDummyDll;
using Protocol;
using UI;
using UI.Price;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Portals.View.ShopTab
{
	// Token: 0x020005BF RID: 1471
	[Token(Token = "0x20005BF")]
	[DisallowMultipleComponent]
	public class PortalsShopItemView : AbstractDataRenderer<ShopItemData>, IPointerEnterHandler, IEventSystemHandler, IToolTipDataProvider, IPointerClickHandler, IArtifactView
	{
		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x0600233D RID: 9021 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600233E RID: 9022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000685")]
		public IActionInfo Info
		{
			[Token(Token = "0x600233D")]
			[Address(RVA = "0x7491", Offset = "0x7491", VA = "0x7491", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600233E")]
			[Address(RVA = "0x7492", Offset = "0x7492", VA = "0x7492")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x0600233F RID: 9023 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002340 RID: 9024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000686")]
		public BackTime Backtime
		{
			[Token(Token = "0x600233F")]
			[Address(RVA = "0x7493", Offset = "0x7493", VA = "0x7493", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002340")]
			[Address(RVA = "0x7494", Offset = "0x7494", VA = "0x7494")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06002341 RID: 9025 RVA: 0x00006DE0 File Offset: 0x00004FE0
		[Token(Token = "0x17000687")]
		public bool OnlyMarketAccount
		{
			[Token(Token = "0x6002341")]
			[Address(RVA = "0x7495", Offset = "0x7495", VA = "0x7495", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06002342 RID: 9026 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000688")]
		public ArtifactData ArtifactData
		{
			[Token(Token = "0x6002342")]
			[Address(RVA = "0x7496", Offset = "0x7496", VA = "0x7496", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06002343 RID: 9027 RVA: 0x00006DF8 File Offset: 0x00004FF8
		// (set) Token: 0x06002344 RID: 9028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000689")]
		public ArtifactView.ArtifactViewArgs Args
		{
			[Token(Token = "0x6002343")]
			[Address(RVA = "0x7497", Offset = "0x7497", VA = "0x7497", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(ArtifactView.ArtifactViewArgs);
			}
			[Token(Token = "0x6002344")]
			[Address(RVA = "0x7498", Offset = "0x7498", VA = "0x7498", Slot = "27")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06002345 RID: 9029 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700068A")]
		public GameObject GameObject
		{
			[Token(Token = "0x6002345")]
			[Address(RVA = "0x7499", Offset = "0x7499", VA = "0x7499", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002346")]
		[Address(RVA = "0x749A", Offset = "0x749A", VA = "0x749A", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002347")]
		[Address(RVA = "0x749B", Offset = "0x749B", VA = "0x749B", Slot = "20")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002348")]
		[Address(RVA = "0x749C", Offset = "0x749C", VA = "0x749C", Slot = "21")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700068B")]
		public Image Marker
		{
			[Token(Token = "0x6002349")]
			[Address(RVA = "0x749D", Offset = "0x749D", VA = "0x749D")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600234A")]
		[Address(RVA = "0x749E", Offset = "0x749E", VA = "0x749E", Slot = "22")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600234B")]
		[Address(RVA = "0x749F", Offset = "0x749F", VA = "0x749F", Slot = "17")]
		protected override void StartListenEvents(ShopItemData data)
		{
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600234C")]
		[Address(RVA = "0x74A0", Offset = "0x74A0", VA = "0x74A0", Slot = "18")]
		protected override void StopListenEvents(ShopItemData data)
		{
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600234D")]
		[Address(RVA = "0x74A1", Offset = "0x74A1", VA = "0x74A1")]
		private void UserBalanceUpdatedHandler()
		{
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x0600234F RID: 9039 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600234E RID: 9038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700068C")]
		public IList<Sprite> MarkerSprites
		{
			[Token(Token = "0x600234F")]
			[Address(RVA = "0x74A3", Offset = "0x74A3", VA = "0x74A3")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x600234E")]
			[Address(RVA = "0x74A2", Offset = "0x74A2", VA = "0x74A2")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002350")]
		[Address(RVA = "0x74A4", Offset = "0x74A4", VA = "0x74A4", Slot = "16")]
		protected override void OnDataInvalidated()
		{
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002351")]
		[Address(RVA = "0x74A5", Offset = "0x74A5", VA = "0x74A5")]
		public PortalsShopItemView()
		{
		}

		// Token: 0x04001360 RID: 4960
		[Token(Token = "0x4001360")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ArtikulView _artikulView;

		// Token: 0x04001361 RID: 4961
		[Token(Token = "0x4001361")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PriceItemRenderer _price;

		// Token: 0x04001362 RID: 4962
		[Token(Token = "0x4001362")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Image _marker;
	}
}
