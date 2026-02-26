using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.ContextMenu;
using UI.Inventory;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Inventory.View.ContextMenu
{
	// Token: 0x0200067D RID: 1661
	[Token(Token = "0x200067D")]
	public class ArtifactContextMenu : MonoBehaviour, IContextMenu<ItemContextMenuOptions>, IBaseContextMenu
	{
		// Token: 0x14000155 RID: 341
		// (add) Token: 0x06002841 RID: 10305 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002842 RID: 10306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000155")]
		public static event Action<ArtikulMenuActionDic.Types.Actions> ActionHandledEvent
		{
			[Token(Token = "0x6002841")]
			[Address(RVA = "0x7961", Offset = "0x7961", VA = "0x7961")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002842")]
			[Address(RVA = "0x7962", Offset = "0x7962", VA = "0x7962")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002843")]
		[Address(RVA = "0x7963", Offset = "0x7963", VA = "0x7963", Slot = "4")]
		public void Show(ItemContextMenuOptions options)
		{
		/* --- GHIDRA: Show ---
		void Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu__Show
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = Google_Protobuf_Reflection_EnumValueDescriptor__get_Name(uVar1,0);
		  UI_ContextMenu_ContextMenuController__HideCurrentContextMenu(uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002844 RID: 10308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002844")]
		[Address(RVA = "0x7964", Offset = "0x7964", VA = "0x7964")]
		private void ItemViewOnDataChangedEvent()
		{
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06002845 RID: 10309 RVA: 0x00007A88 File Offset: 0x00005C88
		[Token(Token = "0x170007A2")]
		public Vector2 MenuSize
		{
			[Token(Token = "0x6002845")]
			[Address(RVA = "0x7965", Offset = "0x7965", VA = "0x7965", Slot = "5")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002846")]
		[Address(RVA = "0x7966", Offset = "0x7966", VA = "0x7966")]
		private void ElementOnSelectEvent(ArtifactContextMenuElement element)
		{
		/* --- GHIDRA: ElementOnSelectEvent ---
		void Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu__ElementOnSelectEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a5a0e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactContextMenuElement__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu_ElementOnSelectEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu_ItemViewOnDataChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&DG_Tweening_DOTween_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    DAT_ram_00a5a0e2 = '\x01';
		  }
		  uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x10),0);
		  if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		    func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		  }
		  iVar1 = 0;
		  DG_Tweening_DOTween__KillAll(uVar3,0,0);
		  iVar5 = *(int *)(param1 + 0x1c);
		  if (0 < *(int *)(iVar5 + 0xc)) {
		    do {
		      param1_00 = *(undefined4 *)(iVar5 + iVar1 * 4 + 0x10);
		      uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param1_00,0);
		      if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		        func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		      }
		      DG_Tweening_DOTween__KillAll(uVar3,0,0);
		      uVar3 = unnamed_function_1417(System_Action_ArtifactContextMenuElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar3,param1,
		                 Method_Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu_ElementOnSelectEvent__
		                 ,0);
		      func_ii_8520(param1_00,uVar3,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar5 + 0xc));
		  }
		  if ((*(int *)(param1 + 0x28) != 0) &&
		     (param1_01 = *(int **)(*(int *)(param1 + 0x28) + 8), param1_01 != (int *)0x0)) {
		    uVar2 = 0;
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu_ItemViewOnDataChangedEvent__
		               ,0);
		    iVar1 = *param1_01;
		    if (*(ushort *)(iVar1 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar1 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar2 * 8 + 4) * 8 + iVar1 + 200);
		          goto code_r0x811ca551;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar1 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_01,Gameplay_Inventory_View_IArtifactView_TypeInfo,1);
		code_r0x811ca551:
		    (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,puVar4[1]);
		  }
		  *(undefined4 *)(param1 + 0x28) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06002847 RID: 10311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002847")]
		[Address(RVA = "0x7967", Offset = "0x7967", VA = "0x7967")]
		private void OnDestroy()
		{
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06002848 RID: 10312 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007A3")]
		public GameObject GameObject
		{
			[Token(Token = "0x6002848")]
			[Address(RVA = "0x7968", Offset = "0x7968", VA = "0x7968")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002849")]
		[Address(RVA = "0x7969", Offset = "0x7969", VA = "0x7969")]
		public ArtifactContextMenu()
		{
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600284A")]
		[Address(RVA = "0x796A", Offset = "0x796A", VA = "0x796A", Slot = "6")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600284B")]
		[Address(RVA = "0x796B", Offset = "0x796B", VA = "0x796B", Slot = "7")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x04001630 RID: 5680
		[Token(Token = "0x4001630")]
		public const ContextMenuId MenuId = ContextMenuId.Items;

		// Token: 0x04001632 RID: 5682
		[Token(Token = "0x4001632")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _bg;

		// Token: 0x04001633 RID: 5683
		[Token(Token = "0x4001633")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _itemTitleLabel;

		// Token: 0x04001634 RID: 5684
		[Token(Token = "0x4001634")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ArtifactView _itemView;

		// Token: 0x04001635 RID: 5685
		[Token(Token = "0x4001635")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ArtifactContextMenuElement[] _elements;

		// Token: 0x04001636 RID: 5686
		[Token(Token = "0x4001636")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _menuSize;

		// Token: 0x04001637 RID: 5687
		[Token(Token = "0x4001637")]
		[FieldOffset(Offset = "0x28")]
		private ItemContextMenuOptions _options;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ActionHandledEvent ---
		void Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu__add_ActionHandledEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a0df == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtikulMenuActionDic_Types_Actions__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu_TypeInfo);
		    DAT_ram_00a5a0df = '\x01';
		  }
		  param1_00 = **(int **)(Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu_TypeInfo + 0x5c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param1,0);
		    param2_00 = System_Action_ArtikulMenuActionDic_Types_Actions__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ArtikulMenuActionDic_Types_Actions__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(*(undefined4 *)
		                          (Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu_TypeInfo + 0x5c),
		                         iVar2,param1_00);
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


		/* --- GHIDRA: remove_ActionHandledEvent ---
		void Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu__remove_ActionHandledEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined8 *param1_00;
		  undefined4 uVar1;
		  uint *puVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 param1_01;
		  int iVar5;
		  int *piVar6;
		  int *piVar7;
		  uint uVar8;
		  int iVar9;
		  undefined8 local_a0;
		  undefined4 local_98;
		  undefined8 local_90;
		  undefined4 local_88;
		  undefined8 local_80;
		  undefined4 local_78;
		  undefined8 local_70;
		  undefined4 local_68;
		  undefined8 local_60;
		  undefined4 local_58;
		  undefined8 local_50;
		  undefined4 local_48;
		  undefined8 local_40;
		  undefined4 local_38;
		  uint local_34;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined4 local_28;
		  int *piStack_24;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a0e0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactContextMenuElement__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu_ElementOnSelectEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu_ItemViewOnDataChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__AbstractArtifactContextMenuElement__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__AbstractArtifactContextMenuElement__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__AbstractArtifactContextMenuElement___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__AbstractArtifactContextMenuElement__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_uint__AbstractArtifactContextMenuElement__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_AbstractArtifactContextMenuElement__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_AbstractArtifactContextMenuElement__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_AbstractArtifactContextMenuElement__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_AbstractArtifactContextMenuElement__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu___c__DisplayClass10_0__Show_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu___c__DisplayClass10_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_10018);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10017);
		    DAT_ram_00a5a0e0 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  *(int *)(param1 + 0x28) = param2;
		  piVar6 = *(int **)(param2 + 8);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu_ItemViewOnDataChangedEvent__
		             ,0);
		  iVar9 = *piVar6;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar8 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar9 + 0x58) + uVar8 * 8)) {
		        puVar2 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811c89df;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar8);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Gameplay_Inventory_View_IArtifactView_TypeInfo,0);
		code_r0x811c89df:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar6,uVar1,puVar2[1]);
		  uVar8 = 0;
		  piVar6 = *(int **)(*(int *)(param1 + 0x28) + 8);
		  iVar9 = *piVar6;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar9 + 0x58) + uVar8 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar8 * 8 + 4) * 8 + iVar9 + 0xd8);
		        goto code_r0x811c8a61;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar8);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Gameplay_Inventory_View_IArtifactView_TypeInfo,3);
		code_r0x811c8a61:
		  (**(code **)((ulonglong)*puVar2 * 4))(&local_30,piVar6,puVar2[1]);
		  param1_00 = puStack_2c;
		  if (*(int *)(Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo);
		  }
		  uVar1 = Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils__get_DefaultActions
		                    (param1_00,&local_a0);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_30,uVar1,
		             Method_System_Collections_Generic_List_AbstractArtifactContextMenuElement__GetEnumerator__
		            );
		  local_8._4_4_ = piStack_24;
		  local_10 = CONCAT44(puStack_2c,local_30);
		  local_30 = 0;
		  puStack_2c = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_AbstractArtifactContextMenuElement__MoveNext__
		                      );
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811c8bb0;
		    }
		    if (iVar3 == 0) goto code_r0x811c8c06;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(*local_8._4_4_ + 0xf0),local_8._4_4_,*(undefined4 *)(param2 + 8),
		               *(undefined4 *)(*local_8._4_4_ + 0xf4));
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar9 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811c8bb0:
		  iVar9 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar3) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar3 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_30 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x811c8c06:
		      DAT_ram_009d3e38 = 0;
		      param1_01 = unnamed_function_1417
		                            (
		                            System_Collections_Generic_Dictionary_uint__AbstractArtifactContextMenuElement__TypeInfo
		                            );
		      System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		                (param1_01,
		                 Method_System_Collections_Generic_Dictionary_uint__AbstractArtifactContextMenuElement___ctor__
		                );
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_30,uVar1,
		                 Method_System_Collections_Generic_List_AbstractArtifactContextMenuElement__GetEnumerator__
		                );
		      local_8._4_4_ = piStack_24;
		      local_10 = CONCAT44(puStack_2c,local_30);
		      local_30 = 0;
		      puStack_2c = &local_10;
		code_r0x811c8c9c:
		      do {
		        do {
		          DAT_ram_009d3e38 = 0;
		          iVar3 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                             Method_System_Collections_Generic_List_Enumerator_AbstractArtifactContextMenuElement__MoveNext__
		                            );
		          piVar6 = local_8._4_4_;
		          iVar9 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x811c9058;
		          }
		          if (iVar3 == 0) goto code_r0x811c90ae;
		          DAT_ram_009d3e38 = 0;
		          iVar3 = import::env::invoke_iiii
		                            (*(undefined4 *)(*local_8._4_4_ + 0xe8),local_8._4_4_,
		                             *(undefined4 *)(*(int *)(param1 + 0x28) + 8),
		                             *(undefined4 *)(*local_8._4_4_ + 0xec));
		          iVar9 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x811c9058;
		          }
		        } while (iVar3 == 0);
		        uVar8 = piVar6[3];
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3c1,param1_01,uVar8,
		                           Method_System_Collections_Generic_Dictionary_uint__AbstractArtifactContextMenuElement__ContainsKey__
		                          );
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811c9058;
		        }
		        if (iVar3 == 0) {
		          if ((uVar8 != 0) &&
		             ((longlong)(ulonglong)uVar8 <= (longlong)*(int *)(*(int *)(param1 + 0x1c) + 0xc))) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x39f,param1_01,uVar8,
		                       piVar6,
		                       Method_System_Collections_Generic_Dictionary_uint__AbstractArtifactContextMenuElement__Add__
		                      );
		            iVar9 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar9 == 1) {
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x811c9058;
		            }
		            goto code_r0x811c8c9c;
		          }
		          iVar3 = piVar6[2];
		          DAT_ram_009d3e38 = 0;
		          local_34 = uVar8;
		          uVar1 = import::env::invoke_iii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a66958
		                             ,&local_34);
		          iVar9 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x811c9058;
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar1 = import::env::invoke_iiiii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x261,
		                             StringLiteral_10017,iVar3,uVar1,0);
		          if (DAT_ram_009d3e38 != 1) {
		            if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                         OKG_Logs_Debug_TypeInfo);
		              if (DAT_ram_009d3e38 == 1) goto code_r0x811c8fcf;
		            }
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xc5,uVar1,0);
		            if (DAT_ram_009d3e38 != 1) goto code_r0x811c8c9c;
		          }
		code_r0x811c8fcf:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811c9058;
		        }
		        DAT_ram_009d3e38 = 0;
		        local_34 = uVar8;
		        uVar1 = import::env::invoke_iii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a66958,
		                           &local_34);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811c9058;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,param1_01,uVar8,
		                           Method_System_Collections_Generic_Dictionary_uint__AbstractArtifactContextMenuElement__get_Item__
		                          );
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811c9058;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar1 = import::env::invoke_iiiiii
		                          (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x24e,
		                           StringLiteral_10018,uVar1,*(undefined4 *)(iVar3 + 8),piVar6[2],0);
		        if (DAT_ram_009d3e38 == 1) break;
		        if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,OKG_Logs_Debug_TypeInfo
		                    );
		          if (DAT_ram_009d3e38 == 1) break;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x310,uVar1,0);
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811c9058:
		      iVar9 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar9 == iVar3) {
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		        iVar3 = *piVar6;
		        DAT_ram_009d3e38 = 0;
		        local_30 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 != 1) {
		          if (iVar3 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x811c90ae:
		          DAT_ram_009d3e38 = 0;
		          uVar8 = 0;
		          piVar6 = *(int **)(param1 + 0x14);
		          piVar7 = *(int **)(*(int *)(param1 + 0x28) + 8);
		          iVar9 = *piVar7;
		          if (*(ushort *)(iVar9 + 0xb6) != 0) {
		            do {
		              if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		                  *(int *)(*(int *)(iVar9 + 0x58) + uVar8 * 8)) {
		                puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar8 * 8 + 4) * 8 + iVar9 +
		                                 0xd0);
		                goto code_r0x811c912a;
		              }
		              uVar8 = uVar8 + 1;
		            } while (*(ushort *)(iVar9 + 0xb6) != uVar8);
		          }
		          puVar2 = (uint *)func_ii_1080(piVar7,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811c912a:
		          uVar8 = 0;
		          iVar9 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		          uVar1 = Core_Extensions_Dict_DictExt__GetArtikul
		                            (*(undefined4 *)(*(int *)(iVar9 + 8) + 0x10),0);
		          iVar9 = *piVar6;
		          (**(code **)((ulonglong)*(uint *)(iVar9 + 0x2d0) * 4))
		                    (piVar6,uVar1,*(undefined4 *)(iVar9 + 0x2d4));
		          piVar6 = *(int **)(param1 + 0x18);
		          piVar7 = *(int **)(*(int *)(param1 + 0x28) + 8);
		          iVar9 = *piVar7;
		          if (*(ushort *)(iVar9 + 0xb6) != 0) {
		            do {
		              if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		                  *(int *)(*(int *)(iVar9 + 0x58) + uVar8 * 8)) {
		                puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar8 * 8 + 4) * 8 + iVar9 +
		                                 0xd0);
		                goto code_r0x811c91d9;
		              }
		              uVar8 = uVar8 + 1;
		            } while (*(ushort *)(iVar9 + 0xb6) != uVar8);
		          }
		          puVar2 = (uint *)func_ii_1080(piVar7,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811c91d9:
		          uVar1 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		          iVar9 = *piVar6;
		          (**(code **)((ulonglong)*(uint *)(iVar9 + 0x138) * 4))
		                    (piVar6,uVar1,*(undefined4 *)(iVar9 + 0x13c));
		          uVar1 = *(undefined4 *)(param1 + 0x18);
		          uVar8 = 0;
		          piVar6 = *(int **)(*(int *)(param1 + 0x28) + 8);
		          iVar9 = *piVar6;
		          if (*(ushort *)(iVar9 + 0xb6) != 0) {
		            do {
		              if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		                  *(int *)(*(int *)(iVar9 + 0x58) + uVar8 * 8)) {
		                puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar8 * 8 + 4) * 8 + iVar9 +
		                                 0xd8);
		                goto code_r0x811c927c;
		              }
		              uVar8 = uVar8 + 1;
		            } while (*(ushort *)(iVar9 + 0xb6) != uVar8);
		          }
		          puVar2 = (uint *)func_ii_1080(piVar6,Gameplay_Inventory_View_IArtifactView_TypeInfo,3);
		code_r0x811c927c:
		          (**(code **)((ulonglong)*puVar2 * 4))(&local_30,piVar6,puVar2[1]);
		          local_58 = local_28;
		          local_60 = CONCAT44(puStack_2c,local_30);
		          func_ii_7564(uVar1,&local_60,0);
		          uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                            (*(undefined4 *)(param1 + 0x10),0);
		          if (DAT_ram_00a65020 == '\0') {
		            Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		            DAT_ram_00a65020 = '\x01';
		          }
		          local_70 = **(undefined8 **)(UnityEngine_Vector3_TypeInfo + 0x5c);
		          local_68 = *(undefined4 *)(*(undefined8 **)(UnityEngine_Vector3_TypeInfo + 0x5c) + 1);
		          local_40 = local_70;
		          local_38 = local_68;
		          Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar1,&local_70,0);
		          uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                            (*(undefined4 *)(param1 + 0x10),0);
		          if (DAT_ram_00a6501f == '\0') {
		            Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		            DAT_ram_00a6501f = '\x01';
		          }
		          iVar9 = 0;
		          local_78 = *(undefined4 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0x14);
		          local_80 = *(undefined8 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0xc);
		          uVar1 = System_Collections_Generic_Queue_object___Dequeue(uVar1,&local_80,0.1,0);
		          DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar1,0x1b,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		          if (0 < *(int *)(*(int *)(param1 + 0x1c) + 0xc)) {
		            do {
		              iVar3 = unnamed_function_1417
		                                (
		                                Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu___c__DisplayClass10_0_TypeInfo
		                                );
		              *(undefined4 *)(iVar3 + 8) =
		                   *(undefined4 *)(*(int *)(param1 + 0x1c) + iVar9 * 4 + 0x10);
		              iVar9 = iVar9 + 1;
		              iVar5 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                                (param1_01,iVar9,
		                                 Method_System_Collections_Generic_Dictionary_uint__AbstractArtifactContextMenuElement__ContainsKey__
		                                );
		              if (iVar5 == 0) {
		                uVar1 = 0;
		              }
		              else {
		                uVar1 = System_Collections_Generic_List_object___get_Item
		                                  (param1_01,iVar9,
		                                   Method_System_Collections_Generic_Dictionary_uint__AbstractArtifactContextMenuElement__get_Item__
		                                  );
		              }
		              *(undefined4 *)(iVar3 + 0xc) = uVar1;
		              uVar4 = *(undefined4 *)(iVar3 + 8);
		              uVar1 = unnamed_function_1417(System_Action_ArtifactContextMenuElement__TypeInfo);
		              UnityEngine_UIElements_VisualElement__get_layout
		                        (uVar1,param1,
		                         Method_Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu_ElementOnSelectEvent__
		                         ,0);
		              UI_Inventory_ArtifactContextMenuElement__set_ButtonBehaviour(uVar4,uVar1,0);
		              uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                                (*(undefined4 *)(iVar3 + 8),0);
		              UnityEngine_Transform___ctor(&local_30,uVar1,0);
		              local_18 = local_28;
		              local_20 = CONCAT44(puStack_2c,local_30);
		              uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                                (*(undefined4 *)(iVar3 + 8),0);
		              if (DAT_ram_00a65020 == '\0') {
		                Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		                DAT_ram_00a65020 = '\x01';
		              }
		              local_90 = **(undefined8 **)(UnityEngine_Vector3_TypeInfo + 0x5c);
		              local_88 = *(undefined4 *)(*(undefined8 **)(UnityEngine_Vector3_TypeInfo + 0x5c) + 1);
		              local_50 = local_90;
		              local_48 = local_88;
		              Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(uVar1,&local_90,0);
		              uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                                (*(undefined4 *)(iVar3 + 8),0);
		              local_98 = local_18;
		              local_a0 = local_20;
		              uVar1 = DG_Tweening_ShortcutExtensions__DOMoveZ(uVar1,&local_a0,0.1,0,0);
		              uVar1 = DG_Tweening_ShortcutExtensions__DOScale
		                                (uVar1,6,
		                                 Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                                );
		              uVar1 = DG_Tweening_DOTweenModuleUI__DOFade
		                                (uVar1,0.02,
		                                 Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Vector3__Vector3__VectorOptions____
		                                );
		              uVar4 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		              DG_Tweening_Color2__op_Multiply
		                        (uVar4,iVar3,
		                         Method_Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu___c__DisplayClass10_0__Show_b__0__
		                         ,0);
		              DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		                        (uVar1,uVar4,
		                         Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		                        );
		              UI_Inventory_ArtifactContextMenuElement__get_AbstractContextMenuElement
		                        (*(undefined4 *)(iVar3 + 8),*(undefined4 *)(iVar3 + 0xc),0);
		            } while (iVar9 < *(int *)(*(int *)(param1 + 0x1c) + 0xc));
		          }
		          return;
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x24f,&local_30);
		      goto joined_r0x811c9594;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x24d,&local_30);
		joined_r0x811c9594:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_MenuSize ---
		void Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu__get_MenuSize
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a0e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu_TypeInfo);
		    DAT_ram_00a5a0e1 = '\x01';
		  }
		  iVar3 = **(int **)(param2 + 0x34);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0xf8) * 4))
		            (*(int **)(param2 + 0x34),*(undefined4 *)(*(int *)(param1 + 0x28) + 8),
		             *(undefined4 *)(iVar3 + 0xfc));
		  iVar3 = **(int **)(Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu_TypeInfo + 0x5c);
		  if (iVar3 != 0) {
		    iVar2 = **(int **)(param2 + 0x34);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe0) * 4))
		                      (*(int **)(param2 + 0x34),*(undefined4 *)(iVar2 + 0xe4));
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),uVar1,*(undefined4 *)(iVar3 + 0x14));
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = Google_Protobuf_Reflection_EnumValueDescriptor__get_Name(uVar1,0);
		  UI_ContextMenu_ContextMenuController__RequestHide(uVar1,0);
		  return;
		}
		*/

}
