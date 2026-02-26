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
		/* --- GHIDRA: <Switch>b__19_0 ---
		uint Gameplay_Inventory_View_Bag_InventoryBagView___Switch_b__19_0(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  
		  if (*(int *)(param1 + 0x80) == 1) {
		    iVar1 = *(int *)(param1 + 0x7c);
		    if (DAT_ram_00a5a162 == '\0') {
		      Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		      DAT_ram_00a5a162 = '\x01';
		    }
		    if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		    }
		    uVar2 = (uint)(*(int *)(*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x5c) +
		                           4) <= iVar1);
		  }
		  else {
		    uVar2 = 0;
		  }
		  return uVar2;
		}
		*/

		/* --- GHIDRA: <Start>b__17_0 ---
		void Gameplay_Inventory_View_Bag_InventoryBagView___Start_b__17_0(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  uint uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 param1_00;
		  int *local_4;
		  
		  if (DAT_ram_00a5a12a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_TryGetComponent_IGuideTarget___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo);
		    DAT_ram_00a5a12a = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar3 = UnityEngine_UIElements_GroupBoxUtility__UnregisterGroupBoxOption_object_
		                    (*(undefined4 *)(param1 + 0x20),&local_4,
		                     Method_UnityEngine_Component_TryGetComponent_IGuideTarget___);
		  piVar1 = local_4;
		  if (iVar3 != 0) {
		    uVar2 = 0;
		    iVar3 = *local_4;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + iVar3 + 0xe0);
		          goto code_r0x811cfbfc;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(local_4,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,4
		                                 );
		code_r0x811cfbfc:
		    param1_00 = (**(code **)((ulonglong)*puVar4 * 4))(piVar1,puVar4[1]);
		    UnityEngine_Object__op_Implicit(param1_00,1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: Start ---
		void Gameplay_Inventory_View_Bag_InventoryBagView__Start(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  Gameplay_Inventory_View_Bag_InventoryBagView__SwitchButtonClickHandler
		            (param1,(uint)(*(char *)(param1 + 0x40) == '\0'),param1);
		  iVar1 = *(int *)(param1 + 0x10);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D6")]
		[Address(RVA = "0x79F0", Offset = "0x79F0", VA = "0x79F0")]
		private void SwitchButtonClickHandler()
		{
		/* --- GHIDRA: SwitchButtonClickHandler ---
		void Gameplay_Inventory_View_Bag_InventoryBagView__SwitchButtonClickHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a127 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_Bag_InventoryBagView__Switch_b__19_0__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_9108);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9109);
		    DAT_ram_00a5a127 = '\x01';
		  }
		  *(char *)(param1 + 0x40) = (char)param2;
		  Utils_TweenContainer__AddTween(*(undefined4 *)(param1 + 0x3c),0);
		  iVar4 = 0x24;
		  if (param2 == 0) {
		    iVar4 = 0x2c;
		  }
		  local_18 = *(undefined8 *)(param1 + iVar4);
		  local_4 = 0;
		  local_10 = 0;
		  local_c = local_18;
		  uVar1 = DG_Tweening_ShortcutExtensions__DOMoveZ(*(undefined4 *)(param1 + 0x20),&local_18,0.4,0,0);
		  uVar1 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar1,6,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  param1_00 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (param1_00,param1,Method_Gameplay_Inventory_View_Bag_InventoryBagView__Switch_b__19_0__,
		             0);
		  uVar1 = DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		                    (uVar1,param1_00,
		                     Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x3c),uVar1,0);
		  uVar1 = UnityEngine_UI_Selectable___ctor(*(undefined4 *)(param1 + 0x18),0);
		  iVar4 = 0x38;
		  if (param2 == 0) {
		    iVar4 = 0x34;
		  }
		  func_ii_7050(uVar1,*(undefined4 *)(param1 + iVar4),0);
		  piVar2 = *(int **)(param1 + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  puVar3 = &StringLiteral_9109;
		  if (param2 == 0) {
		    puVar3 = &StringLiteral_9108;
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(*puVar3,1,0,1,0,0,0,0);
		  iVar4 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar4 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D7")]
		[Address(RVA = "0x79F1", Offset = "0x79F1", VA = "0x79F1")]
		private void Switch(bool isOpened)
		{
		/* --- GHIDRA: Switch ---
		void Gameplay_Inventory_View_Bag_InventoryBagView__Switch
		               (int param1,int *param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  uint *puVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int *piVar8;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a5a128 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__ArtifactData__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__ArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__ArtifactData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__ArtifactData__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_int__ArtifactData__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_ArtifactData__TypeInfo);
		    DAT_ram_00a5a128 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_int__ArtifactData__TypeInfo);
		  System_Collections_Generic_Dictionary_int__TMP_ResourceManager_FontAssetRef___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_int__ArtifactData___ctor__);
		  do {
		    iVar5 = *param2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_ICollection_ArtifactData__TypeInfo == *piVar8) {
		          puVar3 = (uint *)(iVar5 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x811cf8f1;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_ICollection_ArtifactData__TypeInfo,0);
		code_r0x811cf8f1:
		    iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		    if (iVar5 <= iVar4) {
		      iVar4 = *(int *)(param1 + 0x14);
		      if (0 < *(int *)(iVar4 + 0xc)) {
		        iVar5 = 0;
		        if (param3 == 0) {
		          do {
		            iVar2 = 0;
		            iVar6 = *(int *)(iVar4 + iVar5 * 4 + 0x10);
		            uVar7 = *(undefined4 *)(iVar6 + 0x18);
		            iVar4 = GAFInternal_Core_GAFSetSequenceEvent__subscribe
		                              (param1_00,uVar7,
		                               Method_System_Collections_Generic_Dictionary_int__ArtifactData__ContainsKey__
		                              );
		            if (iVar4 != 0) {
		              iVar2 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                                (param1_00,uVar7,
		                                 Method_System_Collections_Generic_Dictionary_int__ArtifactData__get_Item__
		                                );
		            }
		            iVar4 = **(int **)(iVar6 + 0x14);
		            (**(code **)((ulonglong)*(uint *)(iVar4 + 0x138) * 4))
		                      (*(int **)(iVar6 + 0x14),iVar2,*(undefined4 *)(iVar4 + 0x13c));
		            uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                              (*(undefined4 *)(iVar6 + 0x14),0);
		            Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                      (uVar7,(uint)(iVar2 != 0),0);
		            uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                              (iVar6,0);
		            Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                      (uVar7,1,0);
		            iVar5 = iVar5 + 1;
		            iVar4 = *(int *)(param1 + 0x14);
		          } while (iVar5 < *(int *)(iVar4 + 0xc));
		        }
		        else {
		          do {
		            iVar2 = 0;
		            iVar6 = *(int *)(iVar4 + iVar5 * 4 + 0x10);
		            uVar7 = *(undefined4 *)(iVar6 + 0x18);
		            iVar4 = GAFInternal_Core_GAFSetSequenceEvent__subscribe
		                              (param1_00,uVar7,
		                               Method_System_Collections_Generic_Dictionary_int__ArtifactData__ContainsKey__
		                              );
		            if (iVar4 != 0) {
		              iVar2 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                                (param1_00,uVar7,
		                                 Method_System_Collections_Generic_Dictionary_int__ArtifactData__get_Item__
		                                );
		            }
		            iVar4 = **(int **)(iVar6 + 0x14);
		            (**(code **)((ulonglong)*(uint *)(iVar4 + 0x138) * 4))
		                      (*(int **)(iVar6 + 0x14),iVar2,*(undefined4 *)(iVar4 + 0x13c));
		            uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                              (*(undefined4 *)(iVar6 + 0x14),0);
		            Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                      (uVar7,(uint)(iVar2 != 0),0);
		            uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                              (iVar6,0);
		            Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                      (uVar7,(uint)(iVar2 != 0),0);
		            iVar5 = iVar5 + 1;
		            iVar4 = *(int *)(param1 + 0x14);
		          } while (iVar5 < *(int *)(iVar4 + 0xc));
		        }
		      }
		      return;
		    }
		    iVar5 = *param2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IList_ArtifactData__TypeInfo == *piVar8) {
		          puVar3 = (uint *)(iVar5 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x811cf970;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,System_Collections_Generic_IList_ArtifactData__TypeInfo,0);
		code_r0x811cf970:
		    iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param2,iVar4,puVar3[1]);
		    if (iVar5 != 0) {
		      Gameplay_Inventory_View_Info_InfoBox_TitleIconLoaderValueRow__set_Value
		                (param1_00,*(undefined4 *)(iVar5 + 0x7c),iVar5,
		                 Method_System_Collections_Generic_Dictionary_int__ArtifactData__set_Item__);
		    }
		    iVar4 = iVar4 + 1;
		  } while( true );
		}
		*/

		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D8")]
		[Address(RVA = "0x79F2", Offset = "0x79F2", VA = "0x79F2")]
		public void SetData(IList<ArtifactData> data, bool hideEmptySlots)
		{
		/* --- GHIDRA: SetData ---
		void Gameplay_Inventory_View_Bag_InventoryBagView__SetData(int param1,undefined4 param2)
		
		{
		  Utils_TweenContainer__StopAllTweens(*(undefined4 *)(param1 + 0x3c),0);
		  return;
		}
		*/

		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D9")]
		[Address(RVA = "0x79F3", Offset = "0x79F3", VA = "0x79F3")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Inventory_View_Bag_InventoryBagView__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a129 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TweenContainer_TypeInfo);
		    DAT_ram_00a5a129 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Utils_TweenContainer_TypeInfo);
		  Utils_TweenContainer__Dispose(param1_00,0);
		  *(undefined4 *)(param1 + 0x3c) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060028DA RID: 10458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028DA")]
		[Address(RVA = "0x79F4", Offset = "0x79F4", VA = "0x79F4")]
		public InventoryBagView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_View_Bag_InventoryBagView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Inventory_View_Bag_InventoryBagView__SwitchButtonClickHandler(param1,1,param1);
		  return;
		}
		*/

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

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_SwitchEvent ---
		void Gameplay_Inventory_View_Bag_InventoryBagView__add_SwitchEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5a125 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5a125 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x10,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_SwitchEvent ---
		void Gameplay_Inventory_View_Bag_InventoryBagView__remove_SwitchEvent
		               (int param1,undefined8 *param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  iVar2 = *(int *)(param1 + 0x14);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      local_8 = *(undefined4 *)(param2 + 1);
		      local_10 = *param2;
		      func_ii_7564(*(undefined4 *)(*(int *)(iVar2 + iVar1 * 4 + 0x10) + 0x14),&local_10,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_IsOpened ---
		void Gameplay_Inventory_View_Bag_InventoryBagView__get_IsOpened(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint uVar4;
		  int iVar5;
		  int iVar6;
		  uint uVar7;
		  uint uVar8;
		  undefined4 param1_00;
		  
		  uVar7 = 0;
		  uVar8 = 0;
		  if (DAT_ram_00a5a126 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_Bag_InventoryBagView_SwitchButtonClickHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_Bag_InventoryBagView__Start_b__17_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5a126 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x14);
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (0 < (int)uVar4) {
		    uVar1 = 0;
		    iVar5 = Gameplay_Inventory_Model_InventoryConstants_TypeInfo;
		    if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		      do {
		        if (*(int *)(iVar5 + 0x74) == 0) {
		          func_ii_306000(iVar5);
		          iVar3 = *(int *)(param1 + 0x14);
		          iVar5 = Gameplay_Inventory_Model_InventoryConstants_TypeInfo;
		        }
		        *(uint *)(*(int *)(iVar3 + uVar1 * 4 + 0x10) + 0x18) = **(int **)(iVar5 + 0x5c) + uVar1;
		        uVar1 = uVar1 + 1;
		      } while ((int)uVar1 < *(int *)(iVar3 + 0xc));
		    }
		    else {
		      iVar5 = **(int **)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x5c);
		      if (3 < uVar4) {
		        iVar6 = iVar3 + 0x10;
		        do {
		          *(uint *)(*(int *)(iVar6 + uVar1 * 4) + 0x18) = uVar1 + iVar5;
		          *(uint *)(*(int *)(iVar6 + (uVar1 | 1) * 4) + 0x18) = iVar5 + (uVar1 | 1);
		          *(uint *)(*(int *)(iVar6 + (uVar1 | 2) * 4) + 0x18) = iVar5 + (uVar1 | 2);
		          *(uint *)(*(int *)(iVar6 + (uVar1 | 3) * 4) + 0x18) = iVar5 + (uVar1 | 3);
		          uVar1 = uVar1 + 4;
		          uVar7 = uVar7 + 4;
		        } while (uVar7 != (uVar4 & 0xfffffffc));
		      }
		      if ((uVar4 & 3) != 0) {
		        do {
		          *(uint *)(*(int *)(iVar3 + uVar1 * 4 + 0x10) + 0x18) = uVar1 + iVar5;
		          uVar1 = uVar1 + 1;
		          uVar8 = uVar8 + 1;
		        } while (uVar8 != (uVar4 & 3));
		      }
		    }
		  }
		  param1_00 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Inventory_View_Bag_InventoryBagView_SwitchButtonClickHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_00,uVar2,0);
		  Gameplay_Inventory_View_Bag_InventoryBagView__SwitchButtonClickHandler(param1,0,param1_00);
		  uVar2 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (uVar2,param1,Method_Gameplay_Inventory_View_Bag_InventoryBagView__Start_b__17_0__,0);
		  DG_Tweening_DOVirtual__EasedValue(0.1,uVar2,1,0);
		  return;
		}
		*/

}
