using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Elements
{
	// Token: 0x020001F5 RID: 501
	[Token(Token = "0x20001F5")]
	public class ShopItem : MonoBehaviour
	{
		// Token: 0x140000E9 RID: 233
		// (add) Token: 0x06000CE1 RID: 3297 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000CE2 RID: 3298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000E9")]
		public event Action<ShopItem> ClickEvent
		{
			[Token(Token = "0x6000CE1")]
			[Address(RVA = "0x5FDB", Offset = "0x5FDB", VA = "0x5FDB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000CE2")]
			[Address(RVA = "0x1DBE", Offset = "0x1DBE", VA = "0x1DBE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x00003F78 File Offset: 0x00002178
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AC")]
		public int Index
		{
			[Token(Token = "0x6000CE3")]
			[Address(RVA = "0x5FDC", Offset = "0x5FDC", VA = "0x5FDC")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000CE4")]
			[Address(RVA = "0x5FDD", Offset = "0x5FDD", VA = "0x5FDD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001AD")]
		public Price Price
		{
			[Token(Token = "0x6000CE5")]
			[Address(RVA = "0x5FDE", Offset = "0x5FDE", VA = "0x5FDE")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001AE RID: 430
		// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AE")]
		public SlotTypes SlotType
		{
			[Token(Token = "0x6000CE6")]
			[Address(RVA = "0x1DC4", Offset = "0x1DC4", VA = "0x1DC4")]
			set
			{
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x00003F90 File Offset: 0x00002190
		// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AF")]
		public SlotStates SlotState
		{
			[Token(Token = "0x6000CE7")]
			[Address(RVA = "0x5FDF", Offset = "0x5FDF", VA = "0x5FDF")]
			get
			{
				return SlotStates.Lock;
			}
			[Token(Token = "0x6000CE8")]
			[Address(RVA = "0x5FE0", Offset = "0x5FE0", VA = "0x5FE0")]
			set
			{
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000CEA RID: 3306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B0")]
		public ArtifactData ArtifactData
		{
			[Token(Token = "0x6000CE9")]
			[Address(RVA = "0x5FE1", Offset = "0x5FE1", VA = "0x5FE1")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CEA")]
			[Address(RVA = "0x1DC1", Offset = "0x1DC1", VA = "0x1DC1")]
			set
			{
			}
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CEB")]
		[Address(RVA = "0x5FE2", Offset = "0x5FE2", VA = "0x5FE2")]
		private void Awake()
		{
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CEC")]
		[Address(RVA = "0x5FE3", Offset = "0x5FE3", VA = "0x5FE3")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CED")]
		[Address(RVA = "0x5FE4", Offset = "0x5FE4", VA = "0x5FE4")]
		public void Init(int index)
		{
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CEE")]
		[Address(RVA = "0x5FE5", Offset = "0x5FE5", VA = "0x5FE5")]
		private void HandleIndexChanged()
		{
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CEF")]
		[Address(RVA = "0x5FE6", Offset = "0x5FE6", VA = "0x5FE6")]
		private void ButtonClickedEventHandler()
		{
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF0")]
		[Address(RVA = "0x5FE7", Offset = "0x5FE7", VA = "0x5FE7")]
		public ShopItem()
		{
		}

		// Token: 0x0400064F RID: 1615
		[Token(Token = "0x400064F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _background;

		// Token: 0x04000650 RID: 1616
		[Token(Token = "0x4000650")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _itemBackground;

		// Token: 0x04000651 RID: 1617
		[Token(Token = "0x4000651")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Price _price;

		// Token: 0x04000652 RID: 1618
		[Token(Token = "0x4000652")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _button;

		// Token: 0x04000653 RID: 1619
		[Token(Token = "0x4000653")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArtifactView _artifactView;

		// Token: 0x04000654 RID: 1620
		[Token(Token = "0x4000654")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Sprite _bgItemLock;

		// Token: 0x04000655 RID: 1621
		[Token(Token = "0x4000655")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _bgItemNormal;

		// Token: 0x04000656 RID: 1622
		[Token(Token = "0x4000656")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Sprite _bgBronze;

		// Token: 0x04000657 RID: 1623
		[Token(Token = "0x4000657")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _bgSilver;

		// Token: 0x04000658 RID: 1624
		[Token(Token = "0x4000658")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Sprite _bgGold;

		// Token: 0x0400065B RID: 1627
		[Token(Token = "0x400065B")]
		[FieldOffset(Offset = "0x40")]
		private SlotStates _slotState;
	}
}
