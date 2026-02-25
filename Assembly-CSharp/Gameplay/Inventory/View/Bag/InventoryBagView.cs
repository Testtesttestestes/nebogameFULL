using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Inventory.View.Bag
{
	// Token: 0x0200069A RID: 1690
	[Token(Token = "0x200069A")]
	public class InventoryBagView : MonoBehaviour
	{
		// Token: 0x14000157 RID: 343
		// (add) Token: 0x060028D1 RID: 10449 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060028D2 RID: 10450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000157")]
		public event Action SwitchEvent
		{
			[Token(Token = "0x60028D1")]
			[Address(RVA = "0x79EB", Offset = "0x79EB", VA = "0x79EB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60028D2")]
			[Address(RVA = "0x79EC", Offset = "0x79EC", VA = "0x79EC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170007BC RID: 1980
		// (set) Token: 0x060028D3 RID: 10451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007BC")]
		public ArtifactView.ArtifactViewArgs ArtifactViewArgs
		{
			[Token(Token = "0x60028D3")]
			[Address(RVA = "0x79ED", Offset = "0x79ED", VA = "0x79ED")]
			set
			{
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x060028D4 RID: 10452 RVA: 0x00007B18 File Offset: 0x00005D18
		[Token(Token = "0x170007BD")]
		public bool IsOpened
		{
			[Token(Token = "0x60028D4")]
			[Address(RVA = "0x79EE", Offset = "0x79EE", VA = "0x79EE")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D5")]
		[Address(RVA = "0x79EF", Offset = "0x79EF", VA = "0x79EF")]
		private void Start()
		{
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D6")]
		[Address(RVA = "0x79F0", Offset = "0x79F0", VA = "0x79F0")]
		private void SwitchButtonClickHandler()
		{
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D7")]
		[Address(RVA = "0x79F1", Offset = "0x79F1", VA = "0x79F1")]
		private void Switch(bool isOpened)
		{
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D8")]
		[Address(RVA = "0x79F2", Offset = "0x79F2", VA = "0x79F2")]
		public void SetData(IList<ArtifactData> data, bool hideEmptySlots)
		{
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D9")]
		[Address(RVA = "0x79F3", Offset = "0x79F3", VA = "0x79F3")]
		private void OnDestroy()
		{
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028DA")]
		[Address(RVA = "0x79F4", Offset = "0x79F4", VA = "0x79F4")]
		public InventoryBagView()
		{
		}

		// Token: 0x04001689 RID: 5769
		[Token(Token = "0x4001689")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private InventoryBagSlotView[] _slots;

		// Token: 0x0400168A RID: 5770
		[Token(Token = "0x400168A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _switchButton;

		// Token: 0x0400168B RID: 5771
		[Token(Token = "0x400168B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _switchButtonLabel;

		// Token: 0x0400168C RID: 5772
		[Token(Token = "0x400168C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _slotsContainer;

		// Token: 0x0400168D RID: 5773
		[Token(Token = "0x400168D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector2 _openedPosition;

		// Token: 0x0400168E RID: 5774
		[Token(Token = "0x400168E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector2 _closedPosition;

		// Token: 0x0400168F RID: 5775
		[Token(Token = "0x400168F")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Sprite _switchButtonClosedSprite;

		// Token: 0x04001690 RID: 5776
		[Token(Token = "0x4001690")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _switchButtonOpenedSprite;

		// Token: 0x04001691 RID: 5777
		[Token(Token = "0x4001691")]
		[FieldOffset(Offset = "0x3C")]
		private TweenContainer _tweenContainer;

		// Token: 0x04001692 RID: 5778
		[Token(Token = "0x4001692")]
		[FieldOffset(Offset = "0x40")]
		private bool _isOpened;
	}
}
