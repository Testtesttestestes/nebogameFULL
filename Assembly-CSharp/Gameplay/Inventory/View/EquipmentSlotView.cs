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
		/* --- GHIDRA: GetSlot ---
		void Gameplay_Inventory_View_EquipmentSlotView__GetSlot
		               (int param1,undefined8 *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  undefined8 uVar2;
		  
		  uVar1 = *(undefined4 *)(param2 + 1);
		  uVar2 = *param2;
		  param1_00 = *(int *)(*(int *)(param1 + 0x14) + 0x14);
		  *(undefined1 *)(param1_00 + 0x45) = 1;
		  *(undefined8 *)(param1_00 + 0x50) = uVar2;
		  *(undefined4 *)(param1_00 + 0x58) = uVar1;
		  UI_AbstractDeferredRenderer__KillCoroutine(param1_00,0);
		  return;
		}
		*/

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
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Inventory_View_EquipmentSlotView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a0a9 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12639);
		    DAT_ram_00a5a0a9 = '\x01';
		  }
		  return StringLiteral_12639;
		}
		*/

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

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_Inventory_View_EquipmentSlotView__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a0a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_EquipmentSlotView__TypeInfo);
		    DAT_ram_00a5a0a6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_EquipmentSlotView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_EquipmentSlotView__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ClickEvent ---
		undefined4
		Gameplay_Inventory_View_EquipmentSlotView__remove_ClickEvent(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a0a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_InventoryBagSlotView___)
		    ;
		    DAT_ram_00a5a0a7 = '\x01';
		  }
		  if (*(int *)(param1 + 0x14) != 0) {
		    return *(undefined4 *)(param1 + 0x14);
		  }
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_InventoryBagSlotView___);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return uVar1;
		}
		*/


		/* --- GHIDRA: set_ArtifactViewArgs ---
		undefined4
		Gameplay_Inventory_View_EquipmentSlotView__set_ArtifactViewArgs(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a0a8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_TextToolTip___);
		    DAT_ram_00a5a0a8 = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) != 0) {
		    return *(undefined4 *)(param1 + 0x18);
		  }
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_TextToolTip___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_ToolTip ---
		undefined4 Gameplay_Inventory_View_EquipmentSlotView__get_ToolTip(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a0a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_InventoryBagSlotView___)
		    ;
		    DAT_ram_00a5a0a7 = '\x01';
		  }
		  if (*(int *)(param1 + 0x14) != 0) {
		    return *(undefined4 *)(*(int *)(param1 + 0x14) + 0x18);
		  }
		  iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_InventoryBagSlotView___);
		  *(int *)(param1 + 0x14) = iVar1;
		  return *(undefined4 *)(iVar1 + 0x18);
		}
		*/


		/* --- GHIDRA: get_SlotId ---
		void Gameplay_Inventory_View_EquipmentSlotView__get_SlotId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a0a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_InventoryBagSlotView___)
		    ;
		    DAT_ram_00a5a0a7 = '\x01';
		  }
		  if (*(int *)(param1 + 0x14) != 0) {
		    *(undefined4 *)(*(int *)(param1 + 0x14) + 0x18) = param2;
		    return;
		  }
		  iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_InventoryBagSlotView___);
		  *(int *)(param1 + 0x14) = iVar1;
		  *(undefined4 *)(iVar1 + 0x18) = param2;
		  return;
		}
		*/


		/* --- GHIDRA: set_SlotId ---
		void Gameplay_Inventory_View_EquipmentSlotView__set_SlotId(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int iVar1;
		  
		  if (DAT_ram_00a5a0a8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_TextToolTip___);
		    DAT_ram_00a5a0a8 = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) == 0) {
		    param1_00 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_TextToolTip___);
		    *(undefined4 *)(param1 + 0x18) = param1_00;
		  }
		  else {
		    param1_00 = *(undefined4 *)(param1 + 0x18);
		  }
		  if (DAT_ram_00a5a0a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_InventoryBagSlotView___)
		    ;
		    DAT_ram_00a5a0a7 = '\x01';
		  }
		  if (*(int *)(param1 + 0x14) == 0) {
		    param1_01 = func_ii_5677(param1,
		                             Method_UnityEngine_Component_GetComponent_InventoryBagSlotView___);
		    *(undefined4 *)(param1 + 0x14) = param1_01;
		  }
		  else {
		    param1_01 = *(undefined4 *)(param1 + 0x14);
		  }
		  iVar1 = Mono_Net_Security_MobileAuthenticatedStream__set_Position(param1_01,0);
		  UI_ToolTip_ToolTip__get_enabled(param1_00,(uint)(iVar1 == 0),0);
		  return;
		}
		*/


		/* --- GHIDRA: get_ArtifactData ---
		void Gameplay_Inventory_View_EquipmentSlotView__get_ArtifactData
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5a0a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_InventoryBagSlotView___)
		    ;
		    DAT_ram_00a5a0a7 = '\x01';
		  }
		  if (param1[5] == 0) {
		    param1_00 = func_ii_5677(param1,
		                             Method_UnityEngine_Component_GetComponent_InventoryBagSlotView___);
		    param1[5] = param1_00;
		  }
		  else {
		    param1_00 = param1[5];
		  }
		  iVar1 = Mono_Net_Security_MobileAuthenticatedStream__set_Position(param1_00,0);
		  Gameplay_Inventory_View_Bag_InventoryBagSlotView__get_ArtifactData(param1_00,param2,0);
		  if (param2 != iVar1) {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))
		              (param1,*(undefined4 *)(*param1 + 0x10c));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_ArtifactData ---
		void Gameplay_Inventory_View_EquipmentSlotView__set_ArtifactData
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int iVar1;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59830 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Sound_Model_Sounds_TypeInfo);
		    DAT_ram_00a59830 = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  local_c = 0xffffffff;
		  local_10 = Gameplay_Sound_Model_Sounds_TypeInfo;
		  local_8 = param2;
		  param2_00 = Spine_SkeletonJson__GetFloat(&local_10,0);
		  iVar1 = Gameplay_Sound_Model_AudioModel___ctor(param1_00,param2_00,&local_4,&local_10);
		  if (iVar1 != 0) {
		    Gameplay_Sound_Control_AudioController__SetMusicEnabled(param1,local_4,&local_10);
		  }
		  return;
		}
		*/

}
