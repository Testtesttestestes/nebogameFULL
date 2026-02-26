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
		/* --- GHIDRA: Awake ---
		void UI_Elements_ShopItem__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63954 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Elements_ShopItem_ButtonClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a63954 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,Method_UI_Elements_ShopItem_ButtonClickedEventHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CEC")]
		[Address(RVA = "0x5FE3", Offset = "0x5FE3", VA = "0x5FE3")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_Elements_ShopItem__OnDestroy(int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0x3c) = param2;
		  UI_Elements_ShopItem__Init(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CED")]
		[Address(RVA = "0x5FE4", Offset = "0x5FE4", VA = "0x5FE4")]
		public void Init(int index)
		{
		/* --- GHIDRA: Init ---
		void UI_Elements_ShopItem__Init(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  undefined4 param1_01;
		  undefined4 param2_00;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a63955 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo);
		    Mono_Security_ASN1__get_Item(&long___TypeInfo);
		    DAT_ram_00a63955 = '\x01';
		  }
		  param1_00 = (int *)func_ii_5677(*(undefined4 *)(param1 + 0x1c),
		                                  Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		        goto code_r0x8231f873;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,4
		                               );
		code_r0x8231f873:
		  uVar1 = 0;
		  param1_01 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar3 = Mono_Security_ASN1Convert__ToOid(long___TypeInfo,1);
		  *(longlong *)(iVar3 + 0x10) = (longlong)(*(int *)(param1 + 0x3c) + 1);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x8231f914;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,5
		                               );
		code_r0x8231f914:
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,iVar3,puVar2[1]);
		  UnityEngine_Object__op_Implicit(param1_01,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CEE")]
		[Address(RVA = "0x5FE5", Offset = "0x5FE5", VA = "0x5FE5")]
		private void HandleIndexChanged()
		{
		/* --- GHIDRA: HandleIndexChanged ---
		void UI_Elements_ShopItem__HandleIndexChanged(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x38);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

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
		/* --- GHIDRA: .ctor ---
		void UI_Elements_ShopItem___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63956 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    DAT_ram_00a63956 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_int__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_int__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: remove_ClickEvent ---
		int * UI_Elements_ShopItem__remove_ClickEvent(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_SlotState ---
		void UI_Elements_ShopItem__get_SlotState(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 *puVar1;
		  
		  if (param2 == 0) {
		    puVar1 = (undefined4 *)(param1 + 0x24);
		  }
		  else {
		    if (param2 - 3U < 0xfffffffe) goto code_r0x8231f685;
		    puVar1 = (undefined4 *)(param1 + 0x28);
		  }
		  func_ii_7050(*(undefined4 *)(param1 + 0x14),*puVar1,0);
		code_r0x8231f685:
		  *(int *)(param1 + 0x40) = param2;
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,1,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_SlotState ---
		undefined4 UI_Elements_ShopItem__set_SlotState(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = **(int **)(param1 + 0x20);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))
		                    (*(int **)(param1 + 0x20),*(undefined4 *)(iVar2 + 0x134));
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_ArtifactData ---
		void UI_Elements_ShopItem__get_ArtifactData(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63953 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Elements_ShopItem_ButtonClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a63953 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,Method_UI_Elements_ShopItem_ButtonClickedEventHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_ArtifactData ---
		void UI_Elements_ShopItem__set_ArtifactData
		               (undefined4 param1,undefined4 param2,int param3,int param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58abf == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a58abf = '\x01';
		  }
		  if (param3 == 0) {
		    UI_Elements_ShopItem__get_SlotState(param4,param5,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param4 + 0x18),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    return;
		  }
		  UI_Elements_ShopItem__get_SlotState(param4,2,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param4 + 0x18),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  param1_00 = *(undefined4 *)(param4 + 0x18);
		  uVar1 = Gameplay_Shop_ShopEvents___ctor(param3,0);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar1 = Core_Money_Money__op_Explicit(uVar1,0);
		  UI_Price_Price__SetColor(param1_00,param2,uVar1,0);
		  return;
		}
		*/

}
