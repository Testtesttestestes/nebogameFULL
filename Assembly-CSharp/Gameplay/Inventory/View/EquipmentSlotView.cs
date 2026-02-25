using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Inventory.View.Bag;
using Il2CppDummyDll;
using UI.ToolTip.Implementations;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Inventory.View
{
	// Token: 0x0200065F RID: 1631
	[Token(Token = "0x200065F")]
	[RequireComponent(typeof(InventoryBagSlotView))]
	[RequireComponent(typeof(TextToolTip))]
	public class EquipmentSlotView : MonoBehaviour, IInventoryBagSlotView, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x14000152 RID: 338
		// (add) Token: 0x0600279C RID: 10140 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600279D RID: 10141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000152")]
		public event Action<EquipmentSlotView> ClickEvent
		{
			[Token(Token = "0x600279C")]
			[Address(RVA = "0x78CD", Offset = "0x78CD", VA = "0x78CD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600279D")]
			[Address(RVA = "0x78CE", Offset = "0x78CE", VA = "0x78CE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600279E")]
		[Address(RVA = "0x78CF", Offset = "0x78CF", VA = "0x78CF")]
		private InventoryBagSlotView GetSlot()
		{
			return null;
		}

		// Token: 0x1700077C RID: 1916
		// (set) Token: 0x0600279F RID: 10143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077C")]
		public ArtifactView.ArtifactViewArgs ArtifactViewArgs
		{
			[Token(Token = "0x600279F")]
			[Address(RVA = "0x78D0", Offset = "0x78D0", VA = "0x78D0")]
			set
			{
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060027A0 RID: 10144 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700077D")]
		public TextToolTip ToolTip
		{
			[Token(Token = "0x60027A0")]
			[Address(RVA = "0x78D1", Offset = "0x78D1", VA = "0x78D1")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060027A1 RID: 10145 RVA: 0x00007980 File Offset: 0x00005B80
		// (set) Token: 0x060027A2 RID: 10146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077E")]
		public int SlotId
		{
			[Token(Token = "0x60027A1")]
			[Address(RVA = "0x78D2", Offset = "0x78D2", VA = "0x78D2", Slot = "4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60027A2")]
			[Address(RVA = "0x78D3", Offset = "0x78D3", VA = "0x78D3", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x060027A3 RID: 10147 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060027A4 RID: 10148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077F")]
		public ArtifactData ArtifactData
		{
			[Token(Token = "0x60027A3")]
			[Address(RVA = "0x38E2", Offset = "0x38E2", VA = "0x38E2", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60027A4")]
			[Address(RVA = "0x38E3", Offset = "0x38E3", VA = "0x38E3", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027A5")]
		[Address(RVA = "0x78D4", Offset = "0x78D4", VA = "0x78D4", Slot = "9")]
		protected virtual void HandleArtifactDataChanged()
		{
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027A6")]
		[Address(RVA = "0x78D5", Offset = "0x78D5", VA = "0x78D5", Slot = "8")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027A7")]
		[Address(RVA = "0x78D6", Offset = "0x78D6", VA = "0x78D6")]
		public EquipmentSlotView()
		{
		}

		// Token: 0x040015B6 RID: 5558
		[Token(Token = "0x40015B6")]
		[FieldOffset(Offset = "0x14")]
		private InventoryBagSlotView _slot;

		// Token: 0x040015B7 RID: 5559
		[Token(Token = "0x40015B7")]
		[FieldOffset(Offset = "0x18")]
		private TextToolTip _toolTip;
	}
}
