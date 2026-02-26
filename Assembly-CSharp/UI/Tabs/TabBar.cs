using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Tabs
{
	// Token: 0x02000179 RID: 377
	[Token(Token = "0x2000179")]
	public class TabBar : MonoBehaviour
	{
		// Token: 0x140000DC RID: 220
		// (add) Token: 0x06000A94 RID: 2708 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000A95 RID: 2709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000DC")]
		public event Action ChangeEvent
		{
			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x5DDF", Offset = "0x5DDF", VA = "0x5DDF")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A95")]
			[Address(RVA = "0x5DE0", Offset = "0x5DE0", VA = "0x5DE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000163")]
		public IList<TabBarItemData> Data
		{
			[Token(Token = "0x6000A96")]
			[Address(RVA = "0x5DE1", Offset = "0x5DE1", VA = "0x5DE1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00003990 File Offset: 0x00001B90
		[Token(Token = "0x17000164")]
		public int SelectedIndex
		{
			[Token(Token = "0x6000A97")]
			[Address(RVA = "0x5DE2", Offset = "0x5DE2", VA = "0x5DE2")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000165")]
		public TabBarItemData SelectedItem
		{
			[Token(Token = "0x6000A98")]
			[Address(RVA = "0x5DE3", Offset = "0x5DE3", VA = "0x5DE3")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x5DE4", Offset = "0x5DE4", VA = "0x5DE4", Slot = "4")]
		protected virtual void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_Tabs_TabBar__OnDestroy(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a599cd == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_RectTransform_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBar_NextButtonClicked__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBar_PrevButtonClicked__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a599cd = '\x01';
		  }
		  param2_00 = UnityEngine_RectTransform_TypeInfo;
		  piVar2 = *(int **)(param1 + 0x20);
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(param1 + 0x38) = 0;
		  }
		  else if ((*piVar2 != UnityEngine_RectTransform_TypeInfo) ||
		          (*(int **)(param1 + 0x38) = piVar2, *piVar2 != param2_00)) {
		    System_Activator__CreateInstance(piVar2,param2_00);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2 = *(int **)(param1 + 0x1c);
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(param1 + 0x34) = 0;
		  }
		  else if ((*piVar2 != param2_00) || (*(int **)(param1 + 0x34) = piVar2, *piVar2 != param2_00)) {
		    System_Activator__CreateInstance(piVar2,param2_00);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar3 = *(undefined4 *)(*(int *)(param1 + 0x28) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull(uVar1,param1,Method_UI_Tabs_TabBar_PrevButtonClicked__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		  uVar3 = *(undefined4 *)(*(int *)(param1 + 0x2c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull(uVar1,param1,Method_UI_Tabs_TabBar_NextButtonClicked__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x5DE5", Offset = "0x5DE5", VA = "0x5DE5")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_Tabs_TabBar__Awake(int param1,undefined4 param2)
		
		{
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (param1,*(int *)(param1 + 0x3c) + 1,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x5DE6", Offset = "0x5DE6", VA = "0x5DE6")]
		private void NextButtonClicked()
		{
		/* --- GHIDRA: NextButtonClicked ---
		void UI_Tabs_TabBar__NextButtonClicked(int param1,undefined4 param2)
		
		{
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (param1,*(int *)(param1 + 0x3c) + -1,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x5DE7", Offset = "0x5DE7", VA = "0x5DE7")]
		private void PrevButtonClicked()
		{
		/* --- GHIDRA: PrevButtonClicked ---
		void UI_Tabs_TabBar__PrevButtonClicked(int param1,undefined4 param2)
		
		{
		  float4 fVar1;
		  float4 fVar2;
		  float4 fVar3;
		  float4 fVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  undefined4 param2_00;
		  int *param1_00;
		  int iVar7;
		  float param1_01;
		  uint uVar8;
		  float fVar9;
		  float4 local_10;
		  float4 local_8;
		  
		  uVar8 = 0;
		  if (DAT_ram_00a599ce == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_RectTransform___);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_ITabBarItemView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetEase_Tweener___);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetLink_Tweener___);
		    DAT_ram_00a599ce = '\x01';
		  }
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties
		            (&local_10,*(undefined4 *)(param1 + 0x34),0);
		  fVar4 = local_8;
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties
		            (&local_10,*(undefined4 *)(param1 + 0x38),0);
		  param1_00 = *(int **)(param1 + 0x30);
		  iVar7 = *param1_00;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (UI_Tabs_ITabBarItemView_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8 + 4) * 8 + iVar7 + 0xf0);
		        goto code_r0x810a0cda;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar8);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_00,UI_Tabs_ITabBarItemView_TypeInfo,6);
		code_r0x810a0cda:
		  uVar6 = (**(code **)((ulonglong)*puVar5 * 4))(param1_00,puVar5[1]);
		  uVar6 = func_ii_6601(uVar6,Method_UnityEngine_GameObject_GetComponent_RectTransform___);
		  UnityEngine_RectTransform__set_anchorMax(&local_10,*(undefined4 *)(param1 + 0x34),0);
		  fVar1 = local_10;
		  UnityEngine_Transform___ctor(&local_10,uVar6,0);
		  fVar2 = local_10;
		  UnityEngine_Transform___ctor(&local_10,uVar6,0);
		  fVar3 = local_10;
		  UnityEngine_RectTransform__set_anchoredPosition(&local_10,uVar6,0);
		  param1_01 = -(float)fVar2;
		  fVar9 = ((float)local_8 - (float)fVar3) - (float)local_10;
		  if ((float)fVar1 < param1_01 || fVar9 < (float)fVar1) {
		    if (param1_01 <= (float)fVar1) {
		      param1_01 = fVar9;
		    }
		    if ((float)local_8 - (float)fVar4 != 0.0) {
		      param1_01 = UnityEngine_Camera__set_orthographicSize
		                            (param1_01,(float)local_8 - (float)fVar4,0);
		    }
		    uVar6 = DG_Tweening_DOTweenModuleUI__DONormalizedPos
		                      (*(undefined4 *)(param1 + 0x24),param1_01,0.5,0,0);
		    uVar6 = DG_Tweening_ShortcutExtensions__DOScale
		                      (uVar6,6,Method_DG_Tweening_TweenSettingsExtensions_SetEase_Tweener___);
		    param2_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(param1 + 0x24),0);
		    DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		              (uVar6,param2_00,Method_DG_Tweening_TweenSettingsExtensions_SetLink_Tweener___);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x5DE8", Offset = "0x5DE8", VA = "0x5DE8")]
		private void EnsureSelectedIsVisible()
		{
		/* --- GHIDRA: EnsureSelectedIsVisible ---
		void UI_Tabs_TabBar__EnsureSelectedIsVisible(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *param4;
		  int iVar2;
		  int param2_00;
		  int *piVar3;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a599cf == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Tabs_ITabBarItemView_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ITabBarItemView__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ITabBarItemView__get_Item__);
		    DAT_ram_00a599cf = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x44);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      param1_00 = (int *)System_Linq_Enumerable__ToList_object_
		                                   (iVar2,param2_00,
		                                    Method_System_Collections_Generic_List_ITabBarItemView__get_Item__
		                                   );
		      iVar2 = *param1_00;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar3 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		          if (UI_Tabs_ITabBarItemView_TypeInfo == *piVar3) {
		            param4 = (uint *)(piVar3[1] * 8 + iVar2 + 0xe0);
		            goto code_r0x810a0e95;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      param4 = (uint *)func_ii_1080(param1_00,UI_Tabs_ITabBarItemView_TypeInfo,4);
		code_r0x810a0e95:
		      iVar2 = (**(code **)((ulonglong)*param4 * 4))(param1_00,param4[1]);
		      if (iVar2 == param2) {
		        Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		                  (param1,param2_00,0,param4);
		        return;
		      }
		      param2_00 = param2_00 + 1;
		      iVar2 = *(int *)(param1 + 0x44);
		    } while (param2_00 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x5DE9", Offset = "0x5DE9", VA = "0x5DE9")]
		private void ItemOnSelectEvent(TabBarItemData itemData)
		{
		/* --- GHIDRA: ItemOnSelectEvent ---
		void UI_Tabs_TabBar__ItemOnSelectEvent(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 *puVar4;
		  uint *puVar5;
		  int iVar6;
		  int *piVar7;
		  uint uVar8;
		  int local_28;
		  int **ppiStack_24;
		  int *local_20;
		  int *piStack_1c;
		  int local_18;
		  int *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a599d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TabBarItemData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ITabBarItemView__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ITabBarItemView__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ITabBarItemView__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_ITabBarItemView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ITabBarItemView__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ITabBarItemView__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBar_ItemOnSelectEvent__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a599d0 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_14 = (int *)0x0;
		  local_18 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_28,*(undefined4 *)(param1 + 0x44),
		             Method_System_Collections_Generic_List_ITabBarItemView__GetEnumerator__);
		  local_8._4_4_ = piStack_1c;
		  local_28 = 0;
		  ppiStack_24 = (int **)&local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_ITabBarItemView__MoveNext__
		                      );
		    piVar3 = local_8._4_4_;
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8109f637;
		    }
		    if (iVar1 == 0) goto code_r0x8109f68d;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_TabBarItemData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar2,param1,
		               Method_UI_Tabs_TabBar_ItemOnSelectEvent__,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    iVar6 = *piVar3;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		        if (UI_Tabs_ITabBarItemView_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 200);
		          goto code_r0x8109f5d8;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar3,
		                        UI_Tabs_ITabBarItemView_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x8109f5d8:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar4,piVar3,uVar2,puVar4[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8109f637:
		  iVar6 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar1) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar1 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_28 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x8109f68d:
		      DAT_ram_009d3e38 = 0;
		      local_14 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x1c),0);
		      local_20 = &local_18;
		      local_28 = 0;
		      ppiStack_24 = &local_14;
		      do {
		        piVar3 = local_14;
		        iVar6 = *local_14;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar8 = 0;
		          do {
		            piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		              puVar4 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		              goto code_r0x8109f79e;
		            }
		            uVar8 = uVar8 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x8109f9e5:
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8109f9ed;
		        }
		code_r0x8109f79e:
		        DAT_ram_009d3e38 = 0;
		        iVar6 = import::env::invoke_iii(*puVar4,piVar3,puVar4[1]);
		        piVar3 = local_14;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x8109f9e5;
		        if (iVar6 == 0) {
		          iVar6 = 7;
		          goto code_r0x8109fa3a;
		        }
		        iVar6 = *local_14;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar8 = 0;
		          do {
		            piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		              puVar4 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 200);
		              goto code_r0x8109f878;
		            }
		            uVar8 = uVar8 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                            System_Collections_IEnumerator_TypeInfo,1);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x8109f9c7:
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8109f9ed;
		        }
		code_r0x8109f878:
		        DAT_ram_009d3e38 = 0;
		        piVar3 = (int *)import::env::invoke_iii(*puVar4,piVar3,puVar4[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x8109f9c7;
		        if (piVar3 != (int *)0x0) {
		          if (((uint)*(byte *)(*piVar3 + 0xb8) <
		               (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8)) ||
		             (*(int *)(*(int *)(*piVar3 + 100) +
		                       (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		              UnityEngine_Transform_TypeInfo)) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar3,
		                       UnityEngine_Transform_TypeInfo);
		            iVar6 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar6 != 1) {
		              do {
		                halt_trap();
		              } while( true );
		            }
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x8109f9ed;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar3,0);
		        if (DAT_ram_009d3e38 == 1) break;
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) break;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar2,0);
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8109f9ed:
		      iVar6 = global_1;
		      iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar6 == iVar1) {
		        piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		        local_28 = *piVar3;
		        iVar6 = 0;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		code_r0x8109fa3a:
		          DAT_ram_009d3e38 = 0;
		          local_18 = func_ii_1082(local_14,System_IDisposable_TypeInfo);
		          piVar3 = (int *)*local_20;
		          if (piVar3 != (int *)0x0) {
		            iVar1 = *piVar3;
		            if (*(ushort *)(iVar1 + 0xb6) != 0) {
		              uVar8 = 0;
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8)) {
		                  puVar5 = (uint *)(iVar1 + *(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x8109faca;
		                }
		                uVar8 = uVar8 + 1;
		              } while (*(ushort *)(iVar1 + 0xb6) != uVar8);
		            }
		            puVar5 = (uint *)func_ii_1080(piVar3,System_IDisposable_TypeInfo,0);
		code_r0x8109faca:
		            (**(code **)((ulonglong)*puVar5 * 4))(piVar3,puVar5[1]);
		          }
		          if (local_28 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(local_28);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if ((iVar6 == 0) ||
		             ((((iVar6 != 1 && (iVar6 != 2)) && (iVar6 != 3)) &&
		              (((iVar6 != 4 && (iVar6 != 5)) && ((iVar6 != 6 && (iVar6 == 7)))))))) {
		            iVar6 = *(int *)(param1 + 0x44);
		            iVar1 = *(int *)(iVar6 + 0xc);
		            *(undefined4 *)(iVar6 + 0xc) = 0;
		            *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		            if (0 < iVar1) {
		              func_ii_2064(*(undefined4 *)(iVar6 + 8),0,iVar1,0);
		            }
		            iVar6 = *(int *)(param1 + 0x40);
		            iVar1 = *(int *)(iVar6 + 0xc);
		            *(undefined4 *)(iVar6 + 0xc) = 0;
		            *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		            if (0 < iVar1) {
		              func_ii_2064(*(undefined4 *)(iVar6 + 8),0,iVar1,0);
		            }
		          }
		          return;
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x4a,&local_28);
		      goto joined_r0x8109fb9d;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x49,&local_28);
		joined_r0x8109fb9d:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x5DEA", Offset = "0x5DEA", VA = "0x5DEA")]
		private void Clear()
		{
		/* --- GHIDRA: Clear ---
		void UI_Tabs_TabBar__Clear(undefined4 param1,undefined4 param2)
		
		{
		  UI_Tabs_TabBar__ItemOnSelectEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x5DEB", Offset = "0x5DEB", VA = "0x5DEB", Slot = "5")]
		protected virtual void ResetView()
		{
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x5DEC", Offset = "0x5DEC", VA = "0x5DEC", Slot = "6")]
		protected virtual void HandleSelected()
		{
		/* --- GHIDRA: HandleSelected ---
		void UI_Tabs_TabBar__HandleSelected(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param2_00;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  uint uVar6;
		  int iVar7;
		  int *piVar8;
		  int local_24;
		  undefined1 *puStack_20;
		  undefined8 local_1c;
		  int *local_14;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a599d1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TabBarItemData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TabBarItemData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TabBarItemData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TabBarItemData__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_TryGetComponent_ITabBarItemView___);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_ITabBarItemView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_UI_LayoutRebuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData__AddRange__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ITabBarItemView__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TabBarItemData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ITabBarItemView__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TabBarItemData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_GameObject___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_RectTransform_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBar_ItemOnSelectEvent__);
		    DAT_ram_00a599d1 = '\x01';
		  }
		  local_14 = (int *)0x0;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))(param1,*(undefined4 *)(*param1 + 0xec));
		  func_ii_6335(param1[0x10],param2,Method_System_Collections_Generic_List_TabBarItemData__AddRange__
		              );
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_24,param1[0x10],
		             Method_System_Collections_Generic_List_TabBarItemData__GetEnumerator__);
		  local_8 = local_1c;
		  local_24 = 0;
		  puStack_20 = local_10;
		  while( true ) {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                         Method_System_Collections_Generic_List_Enumerator_TabBarItemData__MoveNext__
		                        );
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810a153b;
		      }
		      iVar7 = local_24;
		      if (iVar2 == 0) goto code_r0x810a1584;
		      iVar7 = param1[7];
		      iVar2 = param1[5];
		      uVar4 = local_8._4_4_;
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   UnityEngine_Object_TypeInfo);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x810a153b;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      param2_00 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,iVar2,iVar7,
		                             Method_UnityEngine_Object_Instantiate_GameObject___);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810a153b;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x4b,param2_00,&local_14,
		                         Method_UnityEngine_GameObject_TryGetComponent_ITabBarItemView___);
		      piVar5 = local_14;
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810a153b;
		      }
		    } while (iVar2 == 0);
		    iVar7 = *local_14;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar6 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar6 * 8);
		        if (UI_Tabs_ITabBarItemView_TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(piVar8[1] * 8 + iVar7 + 0xe8);
		          goto code_r0x810a11c2;
		        }
		        uVar6 = uVar6 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar6);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                        UI_Tabs_ITabBarItemView_TypeInfo,5);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x810a11c2:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar3,piVar5,uVar4,puVar3[1]);
		    piVar5 = local_14;
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_TabBarItemData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x810a14f7:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810a153b;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar4,param1,
		               Method_UI_Tabs_TabBar_ItemOnSelectEvent__,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x810a14f7;
		    iVar7 = *piVar5;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar6 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar6 * 8);
		        if (UI_Tabs_ITabBarItemView_TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x810a1306;
		        }
		        uVar6 = uVar6 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar6);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        UI_Tabs_ITabBarItemView_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x810a14f7;
		code_r0x810a1306:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar3,piVar5,uVar4,puVar3[1]);
		    iVar7 = Method_System_Collections_Generic_List_ITabBarItemView__Add__;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x810a14f7;
		    iVar2 = param1[0x11];
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar6 = *(uint *)(iVar2 + 0xc);
		    if (uVar6 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar6 + 1;
		      *(int **)(*(int *)(iVar2 + 8) + uVar6 * 4 + 0x10) = local_14;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,local_14,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810a153b;
		      }
		    }
		    iVar7 = param1[6];
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810a153b;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x268,iVar7,0)
		    ;
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810a153b;
		    }
		    if ((iVar2 != 0) && (*(int *)(param1[0x11] + 0xc) != *(int *)(param1[0x10] + 0xc))) {
		      iVar7 = param1[7];
		      iVar2 = param1[6];
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   UnityEngine_Object_TypeInfo);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x810a153b;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_iiii
		                (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,iVar2,iVar7,
		                 Method_UnityEngine_Object_Instantiate_GameObject___);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810a153b:
		        iVar7 = global_1;
		        iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar7 == iVar2) {
		          piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		          iVar7 = *piVar5;
		          DAT_ram_009d3e38 = 0;
		          local_24 = iVar7;
		          import::env::invoke_v(0x123);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 != 1) {
		code_r0x810a1584:
		            DAT_ram_009d3e38 = 0;
		            if (iVar7 == 0) {
		              piVar5 = (int *)param1[7];
		              if (*(int *)(UnityEngine_UI_LayoutRebuilder_TypeInfo + 0x74) == 0) {
		                func_ii_306000(UnityEngine_UI_LayoutRebuilder_TypeInfo);
		              }
		              if (piVar5 == (int *)0x0) {
		                piVar5 = (int *)0x0;
		              }
		              else if (*piVar5 != UnityEngine_RectTransform_TypeInfo) {
		                piVar5 = (int *)0x0;
		              }
		              UnityEngine_UI_LayoutRebuilder__StripDisabledBehavioursFromList(piVar5,0);
		              return;
		            }
		            System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar4 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x4c,&local_24);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          import::env::__cxa_find_matching_catch_3(0);
		          unnamed_function_937();
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__resumeException(uVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x810a153b;
		}
		*/

		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x5DED", Offset = "0x5DED", VA = "0x5DED")]
		public void Init([NotNull] IEnumerable<TabBarItemData> data)
		{
		/* --- GHIDRA: Init ---
		void UI_Tabs_TabBar__Init(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  undefined1 auStack_20 [8];
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a599d2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TabBarItemData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TabBarItemData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_TabBarItemData__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TabBarItemData__GetEnumerator__);
		    DAT_ram_00a599d2 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x40),
		             Method_System_Collections_Generic_List_TabBarItemData__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_TabBarItemData__MoveNext__)
		    ;
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810a177e:
		      iVar4 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar4 == iVar2) {
		        piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		        iVar2 = *piVar3;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		          if (iVar2 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        param1_00 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x4d,&local_18);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 != 1) {
		        import::env::__resumeException(param1_00);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (iVar1 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    if (param2 == local_8._4_4_) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x306,param1,iVar4,0,auStack_20);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 != 1) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810a177e;
		    }
		    iVar4 = iVar4 + 1;
		  } while( true );
		}
		*/

		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x5DEE", Offset = "0x5DEE", VA = "0x5DEE")]
		public void SelectByItem(TabBarItemData item)
		{
		/* --- GHIDRA: SelectByItem ---
		undefined4 UI_Tabs_TabBar__SelectByItem(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a599d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Tabs_ITabBarItemView_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ITabBarItemView__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ITabBarItemView__get_Item__);
		    DAT_ram_00a599d4 = '\x01';
		  }
		  if (param2 < *(int *)(*(int *)(param1 + 0x44) + 0xc)) {
		    param1_00 = (int *)System_Linq_Enumerable__ToList_object_
		                                 (*(int *)(param1 + 0x44),param2,
		                                  Method_System_Collections_Generic_List_ITabBarItemView__get_Item__
		                                 );
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (UI_Tabs_ITabBarItemView_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		          goto code_r0x810a18eb;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,UI_Tabs_ITabBarItemView_TypeInfo,4);
		code_r0x810a18eb:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  }
		  else {
		    uVar3 = 0;
		  }
		  return uVar3;
		}
		*/

		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x1ACE", Offset = "0x1ACE", VA = "0x1ACE")]
		public void SelectByIndex(int index, bool silent = false)
		{
		/* --- GHIDRA: SelectByIndex ---
		int * UI_Tabs_TabBar__SelectByIndex(int *param1)
		
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

		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x5DEF", Offset = "0x5DEF", VA = "0x5DEF")]
		public TabBarItemData GetItem(int index)
		{
		/* --- GHIDRA: GetItem<object> ---
		undefined4 UI_Tabs_TabBar__GetItem_object_(int param1,undefined4 ******param2,int param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 param4;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  int param3_00;
		  int iVar7;
		  undefined4 *puVar8;
		  int iVar9;
		  int param2_00;
		  uint uVar10;
		  int iVar11;
		  undefined4 ******param2_01;
		  int *piVar12;
		  undefined4 *****local_10;
		  int local_c;
		  undefined4 local_8;
		  byte local_1;
		  
		  param2_00 = 0;
		  iVar5 = *(int *)(param3 + 0x1c);
		  local_10 = param2;
		  if (iVar5 == 0) {
		    Mono_Security_ASN1__get_Item(&UI_Tabs_ITabBarItemView_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ITabBarItemView__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ITabBarItemView__get_Item__);
		    iVar5 = *(int *)(param3 + 0x1c);
		    if (iVar5 == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param3);
		      iVar5 = *(int *)(param3 + 0x1c);
		    }
		  }
		  iVar6 = *(int *)(iVar5 + 8);
		  param3_00 = *(int *)(iVar6 + 0x84);
		  iVar5 = param3_00;
		  if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		    iVar5 = func_ii_1079(iVar6);
		    iVar5 = *(int *)(iVar5 + 0x84);
		  }
		  iVar5 = (int)&local_10 - (iVar5 + 0x17U & 0xfffffff0);
		  uVar10 = param3_00 + 0xfU & 0xfffffff0;
		  iVar6 = iVar5 - uVar10;
		  param1_00 = unnamed_function_714((iVar6 - uVar10) - uVar10,0,param3_00);
		  iVar7 = *(int *)(*(int *)(param1 + 0x44) + 0xc);
		  if (0 < iVar7) {
		    do {
		      piVar2 = (int *)System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)(param1 + 0x44),param2_00,
		                                 Method_System_Collections_Generic_List_ITabBarItemView__get_Item__)
		      ;
		      iVar11 = *piVar2;
		      if (*(ushort *)(iVar11 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar12 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		          if (UI_Tabs_ITabBarItemView_TypeInfo == *piVar12) {
		            puVar3 = (uint *)(piVar12[1] * 8 + iVar11 + 0xe0);
		            goto code_r0x825b376c;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar2,UI_Tabs_ITabBarItemView_TypeInfo,4);
		code_r0x825b376c:
		      piVar2 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		      iVar11 = **(int **)(param3 + 0x1c);
		      if ((*(byte *)(iVar11 + 0xbd) & 1) == 0) {
		        iVar11 = func_ii_1079(iVar11);
		      }
		      if (piVar2 != (int *)0x0) {
		        if (((uint)*(byte *)(*piVar2 + 0xb8) < (uint)*(byte *)(iVar11 + 0xb8)) ||
		           (*(int *)(*(int *)(*piVar2 + 100) + (uint)*(byte *)(iVar11 + 0xb8) * 4 + -4) != iVar11))
		        {
		          System_Activator__CreateInstance(piVar2,iVar11);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      puVar8 = *(undefined4 **)(*(int *)(param3 + 0x1c) + 4);
		      local_c = iVar6;
		      (**(code **)((ulonglong)(uint)puVar8[2] * 4))(*puVar8,puVar8,piVar2,&local_c,iVar6);
		      param4 = unnamed_function_713(param1_00,iVar6,param3_00);
		      piVar12 = (int *)(*(int *)(param3 + 0x1c) + 8);
		      param2_01 = param2;
		      if (-1 < *(int *)(*piVar12 + 0x14)) {
		        param2_01 = &local_10;
		      }
		      uVar4 = unnamed_function_713(iVar6 - uVar10,param2_01,param3_00);
		      uVar4 = func_ii_1081(*piVar12,uVar4);
		      iVar9 = *(int *)(param3 + 0x1c);
		      iVar11 = *(int *)(iVar9 + 8);
		      if ((*(byte *)(iVar11 + 0xbd) & 1) == 0) {
		        iVar11 = func_ii_1079(iVar11);
		        iVar9 = *(int *)(param3 + 0x1c);
		      }
		      local_8 = uVar4;
		      func_ii_8296(iVar11,*(undefined4 *)(iVar9 + 0xc),iVar5,param4,&local_8,&local_1);
		      if (local_1 != 0) {
		        return piVar2;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar7);
		  }
		  return 0;
		}
		*/

		/* --- GHIDRA: GetItem<ByteEnum> ---
		undefined4 UI_Tabs_TabBar__GetItem_ByteEnum_(int param1,undefined4 param2,int param3)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *puVar3;
		  int iVar4;
		  int param2_00;
		  int iVar5;
		  int *piVar6;
		  
		  param2_00 = 0;
		  if (*(int *)(param3 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item(&UI_Tabs_ITabBarItemView_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ITabBarItemView__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ITabBarItemView__get_Item__);
		    if (*(int *)(param3 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param3);
		    }
		  }
		  iVar4 = *(int *)(*(int *)(param1 + 0x44) + 0xc);
		  if (0 < iVar4) {
		    do {
		      piVar2 = (int *)System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)(param1 + 0x44),param2_00,
		                                 Method_System_Collections_Generic_List_ITabBarItemView__get_Item__)
		      ;
		      iVar5 = *piVar2;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar6 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		          if (UI_Tabs_ITabBarItemView_TypeInfo == *piVar6) {
		            puVar3 = (uint *)(piVar6[1] * 8 + iVar5 + 0xe0);
		            goto code_r0x825b3584;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar2,UI_Tabs_ITabBarItemView_TypeInfo,4);
		code_r0x825b3584:
		      piVar2 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		      iVar5 = **(int **)(param3 + 0x1c);
		      if ((*(byte *)(iVar5 + 0xbd) & 1) == 0) {
		        iVar5 = func_ii_1079(iVar5);
		      }
		      if (piVar2 != (int *)0x0) {
		        if (((uint)*(byte *)(*piVar2 + 0xb8) < (uint)*(byte *)(iVar5 + 0xb8)) ||
		           (*(int *)(*(int *)(*piVar2 + 100) + (uint)*(byte *)(iVar5 + 0xb8) * 4 + -4) != iVar5)) {
		          System_Activator__CreateInstance(piVar2,iVar5);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      iVar5 = *(int *)piVar2[8];
		      iVar5 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc0) * 4))
		                        ((int *)piVar2[8],param2,*(undefined4 *)(iVar5 + 0xc4));
		      if (iVar5 != 0) {
		        return piVar2;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar4);
		  }
		  return 0;
		}
		*/

		/* --- GHIDRA: GetItem ---
		void UI_Tabs_TabBar__GetItem(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a599d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ITabBarItemView___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ITabBarItemView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_TabBarItemData__TypeInfo);
		    DAT_ram_00a599d5 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_TabBarItemData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_TabBarItemData___ctor__);
		  *(undefined4 *)(param1 + 0x40) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_ITabBarItemView__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_ITabBarItemView___ctor__);
		  *(undefined4 *)(param1 + 0x44) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AA6")]
		public TabBarItemData<T> GetItem<T>(T value)
		{
			return null;
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AA7")]
		public TabBarItemData<T> GetSelectedItem<T>()
		{
		/* --- GHIDRA: GetSelectedItem<__Il2CppFullySharedGenericType> ---
		int * UI_Tabs_TabBar__GetSelectedItem___Il2CppFullySharedGenericType_(int param1,int param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  int param1_00;
		  int *param1_01;
		  uint *puVar3;
		  int iVar4;
		  
		  iVar4 = 0;
		  if (*(int *)(param2 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item(&Com_TheFallenGames_OSA_CustomAdapters_TableView_ITuple_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_object__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_object__TypeInfo);
		    if (*(int *)(param2 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param2);
		    }
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_object__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (param1_00,param1,Method_System_Collections_Generic_List_object___ctor__);
		  if (0 < param1) {
		    do {
		      iVar1 = Method_System_Collections_Generic_List_object__Add__;
		      *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		      uVar2 = *(uint *)(param1_00 + 0xc);
		      if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		        *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		        *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = 0;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_00,0,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      }
		      iVar4 = iVar4 + 1;
		    } while (iVar4 != param1);
		  }
		  param1_01 = (int *)System_Delegate__Combine(**(undefined4 **)(param2 + 0x1c));
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Com_TheFallenGames_OSA_CustomAdapters_TableView_ITuple_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + iVar4 + 0xd8);
		        goto code_r0x825b3a7f;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,
		                                Com_TheFallenGames_OSA_CustomAdapters_TableView_ITuple_TypeInfo,3);
		code_r0x825b3a7f:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_01,param1_00,0,puVar3[1]);
		  return param1_01;
		}
		*/

		/* --- GHIDRA: GetSelectedItem<UInt32Enum> ---
		int * UI_Tabs_TabBar__GetSelectedItem_UInt32Enum_(int param1,int param2)
		
		{
		  int *param1_00;
		  int param1_01;
		  
		  if ((*(int *)(param2 + 0x1c) == 0) &&
		     (Mono_Security_ASN1__get_Item
		                (&Method_System_Linq_Enumerable_ElementAtOrDefault_TabBarItemData___),
		     *(int *)(param2 + 0x1c) == 0)) {
		    System_ReadOnlySpan_char___GetPinnableReference(param2);
		  }
		  param1_00 = (int *)System_Linq_Enumerable__ElementAt___Il2CppFullySharedGenericType_
		                               (*(undefined4 *)(param1 + 0x40),*(undefined4 *)(param1 + 0x3c),
		                                Method_System_Linq_Enumerable_ElementAtOrDefault_TabBarItemData___);
		  param1_01 = **(int **)(param2 + 0x1c);
		  if ((*(byte *)(param1_01 + 0xbd) & 1) == 0) {
		    param1_01 = func_ii_1079(param1_01);
		  }
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) < (uint)*(byte *)(param1_01 + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) + (uint)*(byte *)(param1_01 + 0xb8) * 4 + -4) !=
		        param1_01)) {
		      System_Activator__CreateInstance(param1_00,param1_01);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x5DF0", Offset = "0x5DF0", VA = "0x5DF0")]
		public TabBar()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Tabs_TabBar___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a599d6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    DAT_ram_00a599d6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_int__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_int__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
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

		// Token: 0x040004A6 RID: 1190
		[Token(Token = "0x40004A6")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _itemPrefab;

		// Token: 0x040004A7 RID: 1191
		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _separatorPrefab;

		// Token: 0x040004A8 RID: 1192
		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _container;

		// Token: 0x040004A9 RID: 1193
		[Token(Token = "0x40004A9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _viewport;

		// Token: 0x040004AA RID: 1194
		[Token(Token = "0x40004AA")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x040004AB RID: 1195
		[Token(Token = "0x40004AB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _prevButton;

		// Token: 0x040004AC RID: 1196
		[Token(Token = "0x40004AC")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _nextButton;

		// Token: 0x040004AD RID: 1197
		[Token(Token = "0x40004AD")]
		[FieldOffset(Offset = "0x30")]
		private ITabBarItemView _selectedItem;

		// Token: 0x040004AE RID: 1198
		[Token(Token = "0x40004AE")]
		[FieldOffset(Offset = "0x34")]
		private RectTransform _containerRectTransform;

		// Token: 0x040004AF RID: 1199
		[Token(Token = "0x40004AF")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform _viewportRectTransform;

		// Token: 0x040004B0 RID: 1200
		[Token(Token = "0x40004B0")]
		[FieldOffset(Offset = "0x3C")]
		private int _selectedIndex;

		// Token: 0x040004B1 RID: 1201
		[Token(Token = "0x40004B1")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<TabBarItemData> _data;

		// Token: 0x040004B2 RID: 1202
		[Token(Token = "0x40004B2")]
		[FieldOffset(Offset = "0x44")]
		protected readonly List<ITabBarItemView> _items;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ChangeEvent ---
		void UI_Tabs_TabBar__add_ChangeEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a599ca == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a599ca = '\x01';
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


		/* --- GHIDRA: get_SelectedIndex ---
		undefined4 UI_Tabs_TabBar__get_SelectedIndex(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a599cb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ElementAtOrDefault_TabBarItemData___);
		    DAT_ram_00a599cb = '\x01';
		  }
		  uVar1 = System_Linq_Enumerable__ElementAt___Il2CppFullySharedGenericType_
		                    (*(undefined4 *)(param1 + 0x40),*(undefined4 *)(param1 + 0x3c),
		                     Method_System_Linq_Enumerable_ElementAtOrDefault_TabBarItemData___);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_SelectedItem ---
		void UI_Tabs_TabBar__get_SelectedItem(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a599cc == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBar_NextButtonClicked__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBar_PrevButtonClicked__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a599cc = '\x01';
		  }
		  UI_Tabs_TabBar__ItemOnSelectEvent(param1,param1);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x28) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull(uVar1,param1,Method_UI_Tabs_TabBar_PrevButtonClicked__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x2c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull(uVar1,param1,Method_UI_Tabs_TabBar_NextButtonClicked__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  return;
		}
		*/

}
