using System;
using System.Collections;
using Gameplay.Inventory.Controller;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x02000690 RID: 1680
	[Token(Token = "0x2000690")]
	public class UserInventoryChestWindow : InventoryChestWindow
	{
		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06002895 RID: 10389 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007AF")]
		public override string WindowId
		{
			[Token(Token = "0x6002895")]
			[Address(RVA = "0x79B4", Offset = "0x79B4", VA = "0x79B4", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06002896 RID: 10390 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007B0")]
		public GameObject SaleIcon
		{
			[Token(Token = "0x6002896")]
			[Address(RVA = "0x79B5", Offset = "0x79B5", VA = "0x79B5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06002897 RID: 10391 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007B1")]
		public TextMeshProUGUI DiscountText
		{
			[Token(Token = "0x6002897")]
			[Address(RVA = "0x79B6", Offset = "0x79B6", VA = "0x79B6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002898")]
		[Address(RVA = "0x79B7", Offset = "0x79B7", VA = "0x79B7")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002899")]
		[Address(RVA = "0x79B8", Offset = "0x79B8", VA = "0x79B8", Slot = "24")]
		protected override void Awake()
		{
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600289A")]
		[Address(RVA = "0x79B9", Offset = "0x79B9", VA = "0x79B9")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600289B")]
		[Address(RVA = "0x79BA", Offset = "0x79BA", VA = "0x79BA")]
		public UserInventoryChestWindow()
		{
		}

		// Token: 0x04001667 RID: 5735
		[Token(Token = "0x4001667")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/UserInventoryChestWindow";

		// Token: 0x04001668 RID: 5736
		[Token(Token = "0x4001668")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private GameObject _saleIcon;

		// Token: 0x04001669 RID: 5737
		[Token(Token = "0x4001669")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI _discountText;

		// Token: 0x0400166A RID: 5738
		[Token(Token = "0x400166A")]
		[FieldOffset(Offset = "0x5C")]
		private InventoryChestViewMediator _chestViewMediator;
	}
}
