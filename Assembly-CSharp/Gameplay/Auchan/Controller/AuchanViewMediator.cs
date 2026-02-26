using System;
using System.Collections.Generic;
using Core.Sorting;
using Gameplay.Auchan.Controller.Filters;
using Gameplay.Auchan.Events;
using Gameplay.Auchan.Model;
using Gameplay.Auchan.View;
using Il2CppDummyDll;
using MVC;
using UI.Filters;

namespace Gameplay.Auchan.Controller
{
	// Token: 0x02000C9F RID: 3231
	[Token(Token = "0x2000C9F")]
	public class AuchanViewMediator : AbstractViewMediator<AuchanModel, AuchanEvents, AuchanController, AuchanView>
	{
		// Token: 0x06004E9E RID: 20126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E9E")]
		[Address(RVA = "0x9CCF", Offset = "0x9CCF", VA = "0x9CCF")]
		public AuchanViewMediator(AuchanModel model, AuchanEvents events, AuchanController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Auchan_Controller_AuchanViewMediator___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58966 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Sorting_AbstractSortControlView_AuchanArtifactData__add_ComparerChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Sorting_AbstractSortControlView_AuchanArtifactData__get_SelectedFilter__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Sorting_AbstractSortControlView_AuchanArtifactData__remove_ComparerChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AuchanModel__AuchanEvents__AuchanController__AuchanView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IGameDataComparer_AuchanArtifactData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Auchan_Controller_AuchanViewMediator_FilterInputChanged__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Auchan_Controller_AuchanViewMediator_HandleComparerChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Auchan_Controller_AuchanViewMediator_HandleToggleChanged__);
		    DAT_ram_00a58966 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_string__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Auchan_Controller_AuchanViewMediator_FilterInputChanged__,0);
		    UI_SearchInput__add_InputChangedEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Auchan_Controller_AuchanViewMediator_HandleToggleChanged__,0);
		    UI_Toggle_GreenToggle__add_ChangedEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x20);
		    uVar1 = unnamed_function_1417(System_Action_IGameDataComparer_AuchanArtifactData___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Auchan_Controller_AuchanViewMediator_HandleComparerChangedEvent__,0);
		    UI_Sorting_AbstractSortControlView___Il2CppFullySharedGenericType___get_SelectedFilter
		              (uVar3,uVar1,
		               Method_UI_Sorting_AbstractSortControlView_AuchanArtifactData__remove_ComparerChangedEvent__
		              );
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_string__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Auchan_Controller_AuchanViewMediator_FilterInputChanged__,0);
		    UI_NumbersInput___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Auchan_Controller_AuchanViewMediator_HandleToggleChanged__,0);
		    UI_ToolTip_Controller_Android_ToolTipController__GetPointerPosition(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1[7] = *(int *)(*(int *)(iVar2 + 0x20) + 0x28);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x20);
		    uVar1 = unnamed_function_1417(System_Action_IGameDataComparer_AuchanArtifactData___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Auchan_Controller_AuchanViewMediator_HandleComparerChangedEvent__,0);
		    UI_Sorting_AbstractSortControlView___Il2CppFullySharedGenericType___SwitcherValueChangedHandler
		              (uVar3,uVar1,
		               Method_UI_Sorting_AbstractSortControlView_AuchanArtifactData__add_ComparerChangedEvent__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000FE9 RID: 4073
		// (set) Token: 0x06004E9F RID: 20127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FE9")]
		public override AuchanView View
		{
			[Token(Token = "0x6004E9F")]
			[Address(RVA = "0x9CD0", Offset = "0x9CD0", VA = "0x9CD0", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000FEA RID: 4074
		// (set) Token: 0x06004EA0 RID: 20128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FEA")]
		public override AuchanEvents Events
		{
			[Token(Token = "0x6004EA0")]
			[Address(RVA = "0x9CD1", Offset = "0x9CD1", VA = "0x9CD1", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000FEB RID: 4075
		// (set) Token: 0x06004EA1 RID: 20129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FEB")]
		public override AuchanController Controller
		{
			[Token(Token = "0x6004EA1")]
			[Address(RVA = "0x9CD2", Offset = "0x9CD2", VA = "0x9CD2", Slot = "18")]
			set
			{
			}
		}

		// Token: 0x06004EA2 RID: 20130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EA2")]
		[Address(RVA = "0x9CD3", Offset = "0x9CD3", VA = "0x9CD3")]
		private void HandleAuchanItemBought()
		{
		/* --- GHIDRA: HandleAuchanItemBought ---
		void Gameplay_Auchan_Controller_AuchanViewMediator__HandleAuchanItemBought
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  Gameplay_Auchan_Controller_AuchanViewMediator__FilterInputChanged(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004EA3 RID: 20131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EA3")]
		[Address(RVA = "0x9CD4", Offset = "0x9CD4", VA = "0x9CD4")]
		private void HandleComparerChangedEvent(IGameDataComparer<AuchanArtifactData> comparer)
		{
		/* --- GHIDRA: HandleComparerChangedEvent ---
		void Gameplay_Auchan_Controller_AuchanViewMediator__HandleComparerChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  int iVar3;
		  int iVar4;
		  int param2_00;
		  
		  if (DAT_ram_00a5896a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IAuchanItemFilter__get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_Controller_Filters_IAuchanItemFilter_TypeInfo);
		    DAT_ram_00a5896a = '\x01';
		  }
		  param1_00 = (int *)GAFInternal_Reader_GAFReader__OpenTag
		                               (param1[6],5,
		                                Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IAuchanItemFilter__get_Item__
		                               );
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Auchan_Controller_Filters_IAuchanItemFilter_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f4fb34;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                Gameplay_Auchan_Controller_Filters_IAuchanItemFilter_TypeInfo,0);
		code_r0x80f4fb34:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  param2_00 = *param1;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(param2_00 + 0x158) * 4))
		                    (param1,*(undefined4 *)(param2_00 + 0x15c));
		  *(undefined1 *)(iVar4 + 0x10) = *(undefined1 *)(*(int *)(iVar3 + 0x1c) + 0x48);
		  Gameplay_Auchan_Controller_AuchanViewMediator__FilterInputChanged(param1,param2_00);
		  return;
		}
		*/

		}

		// Token: 0x06004EA4 RID: 20132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EA4")]
		[Address(RVA = "0x9CD5", Offset = "0x9CD5", VA = "0x9CD5")]
		private void HandleToggleChanged()
		{
		/* --- GHIDRA: HandleToggleChanged ---
		void Gameplay_Auchan_Controller_AuchanViewMediator__HandleToggleChanged
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *puVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5896b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IAuchanItemFilter__get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_Controller_Filters_IAuchanItemFilter_TypeInfo);
		    DAT_ram_00a5896b = '\x01';
		  }
		  piVar2 = (int *)GAFInternal_Reader_GAFReader__OpenTag
		                            (*(undefined4 *)(param1 + 0x18),4,
		                             Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IAuchanItemFilter__get_Item__
		                            );
		  iVar4 = *piVar2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Auchan_Controller_Filters_IAuchanItemFilter_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f4fc18;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,Gameplay_Auchan_Controller_Filters_IAuchanItemFilter_TypeInfo
		                                ,0);
		code_r0x80f4fc18:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  *(int *)(iVar4 + 0xc) = param2;
		  uVar1 = 0;
		  piVar2 = (int *)GAFInternal_Reader_GAFReader__OpenTag
		                            (*(undefined4 *)(param1 + 0x18),4,
		                             Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IAuchanItemFilter__get_Item__
		                            );
		  iVar4 = *piVar2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Auchan_Controller_Filters_IAuchanItemFilter_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f4fcae;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,Gameplay_Auchan_Controller_Filters_IAuchanItemFilter_TypeInfo
		                                ,0);
		code_r0x80f4fcae:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  *(bool *)(iVar4 + 0x10) = 2 < *(int *)(param2 + 8);
		  Gameplay_Auchan_Controller_AuchanViewMediator__FilterInputChanged(param1,puVar3);
		  return;
		}
		*/

		}

		// Token: 0x06004EA5 RID: 20133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EA5")]
		[Address(RVA = "0x9CD6", Offset = "0x9CD6", VA = "0x9CD6")]
		private void FilterInputChanged(string str)
		{
		/* --- GHIDRA: FilterInputChanged ---
		/* WARNING: Removing unreachable block (ram,0x80f4ef26) */
		
		void Gameplay_Auchan_Controller_AuchanViewMediator__FilterInputChanged
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  undefined4 *puVar8;
		  undefined4 param3;
		  uint uVar9;
		  int iVar10;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5896c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AuchanModel__AuchanEvents__AuchanController__AuchanView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_View_AuchanArtifactCategoryData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__string__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___get_Keys__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_AuchanArtifactData___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_AuchanArtifactData___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_AuchanArtifactData___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_AuchanArtifactData___get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_AuchanArtifactData__AuchanArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Extensions_IEnumerableExt_SortGameData_AuchanArtifactData__AuchanArtifactData___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_uint__List_AuchanArtifactData___GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AuchanArtifactCategoryData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AuchanArtifactCategoryData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_AuchanArtifactCategoryData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Auchan_Controller_AuchanViewMediator___c__RedrawCurrentTab_b__14_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_Controller_AuchanViewMediator___c_TypeInfo);
		    DAT_ram_00a5896c = '\x01';
		  }
		  uVar2 = Gameplay_Auchan_Controller_AuchanViewMediator__RedrawCurrentTab
		                    (param1,*(undefined4 *)(param1[2] + 0xc),0);
		  iVar3 = unnamed_function_1417
		                    (System_Collections_Generic_List_AuchanArtifactCategoryData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar3,Method_System_Collections_Generic_List_AuchanArtifactCategoryData___ctor__);
		  uVar4 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                    (uVar2,
		                     Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___get_Keys__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_20,uVar4,
		             Method_System_Collections_Generic_Dictionary_KeyCollection_uint__List_AuchanArtifactData___GetEnumerator__
		            );
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3ad,local_10,
		                       Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_AuchanArtifactData___MoveNext__
		                      );
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f4f075;
		    }
		    if (iVar5 == 0) {
		      iVar5 = 6;
		      iVar10 = local_20;
		      goto code_r0x80f4f0c2;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = local_8._4_4_;
		    uVar6 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,uVar2,local_8._4_4_,
		                       Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___get_Item__
		                      );
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f4f075;
		    }
		    if (param1[7] != 0) {
		      if (*(int *)(Gameplay_Auchan_Controller_AuchanViewMediator___c_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   Gameplay_Auchan_Controller_AuchanViewMediator___c_TypeInfo);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f4f075;
		        }
		      }
		      puVar8 = *(undefined4 **)(Gameplay_Auchan_Controller_AuchanViewMediator___c_TypeInfo + 0x5c);
		      iVar10 = puVar8[1];
		      if (iVar10 == 0) {
		        if (*(int *)(Gameplay_Auchan_Controller_AuchanViewMediator___c_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     Gameplay_Auchan_Controller_AuchanViewMediator___c_TypeInfo);
		          iVar10 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar10 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80f4f075;
		          }
		          puVar8 = *(undefined4 **)
		                    (Gameplay_Auchan_Controller_AuchanViewMediator___c_TypeInfo + 0x5c);
		        }
		        param3 = *puVar8;
		        DAT_ram_009d3e38 = 0;
		        iVar10 = import::env::invoke_ii
		                           (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                            System_Func_AuchanArtifactData__AuchanArtifactData__TypeInfo);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x227,iVar10,param3,
		                     Method_Gameplay_Auchan_Controller_AuchanViewMediator___c__RedrawCurrentTab_b__14_0__
		                     ,0);
		          if (DAT_ram_009d3e38 != 1) {
		            *(int *)(*(int *)(Gameplay_Auchan_Controller_AuchanViewMediator___c_TypeInfo + 0x5c) + 4
		                    ) = iVar10;
		            goto code_r0x80f4ee57;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f4f075;
		      }
		code_r0x80f4ee57:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::invoke_iiiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1db,uVar6,iVar10,
		                         param1[7],
		                         Method_Core_Extensions_IEnumerableExt_SortGameData_AuchanArtifactData__AuchanArtifactData___
		                        );
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f4f075;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x229,uVar6,
		                         Method_System_Linq_Enumerable_ToList_AuchanArtifactData___);
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f4f075;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar10 = import::env::invoke_ii
		                       (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                        Gameplay_Auchan_View_AuchanArtifactCategoryData_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f4f075;
		    }
		    *(undefined4 *)(iVar10 + 0xc) = uVar6;
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                       *(undefined4 *)(param1[2] + 0x10),uVar4,
		                       Method_System_Collections_Generic_Dictionary_uint__string__get_Item__);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f4f075;
		    }
		    *(undefined4 *)(iVar10 + 0x10) = uVar4;
		    *(undefined4 *)(iVar10 + 8) = uVar6;
		    iVar5 = Method_System_Collections_Generic_List_AuchanArtifactCategoryData__Add__;
		    *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		    uVar9 = *(uint *)(iVar3 + 0xc);
		    if (uVar9 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		      *(uint *)(iVar3 + 0xc) = uVar9 + 1;
		      *(int *)(*(int *)(iVar3 + 8) + uVar9 * 4 + 0x10) = iVar10;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar3,iVar10,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f4f075:
		        iVar10 = global_1;
		        iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar10 == iVar5) {
		          piVar7 = (int *)import::env::__cxa_begin_catch(uVar2);
		          iVar10 = *piVar7;
		          iVar5 = 0;
		          DAT_ram_009d3e38 = 0;
		          local_20 = iVar10;
		          import::env::invoke_v(0x123);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 != 1) {
		code_r0x80f4f0c2:
		            DAT_ram_009d3e38 = 0;
		            if (iVar10 == 0) {
		              if ((iVar5 == 0) ||
		                 ((((iVar5 != 1 && (iVar5 != 2)) && (iVar5 != 3)) &&
		                  (((iVar5 != 4 && (iVar5 != 5)) && (iVar5 == 6)))))) {
		                uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                                  (param1,*(undefined4 *)(*param1 + 0x15c));
		                Gameplay_Auchan_View_AuchanView__TabBarOnChangeEvent(uVar2,iVar3,0);
		              }
		              return;
		            }
		            System_Data_DataSet__ValidateLocaleConstraint(iVar10);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar2 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1dd,&local_20);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          import::env::__cxa_find_matching_catch_3(0);
		          unnamed_function_937();
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__resumeException(uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  } while( true );
		}
		*/

		}

		// Token: 0x06004EA6 RID: 20134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EA6")]
		[Address(RVA = "0x9CD7", Offset = "0x9CD7", VA = "0x9CD7")]
		private void RedrawCurrentTab()
		{
		/* --- GHIDRA: RedrawCurrentTab ---
		/* WARNING: Removing unreachable block (ram,0x80f4f664) */
		/* WARNING: Removing unreachable block (ram,0x80f4f959) */
		
		undefined4
		Gameplay_Auchan_Controller_AuchanViewMediator__RedrawCurrentTab
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param3_00;
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  uint uVar4;
		  undefined4 *puVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  int *piVar9;
		  int local_50;
		  undefined8 *local_4c;
		  int local_48;
		  undefined1 *local_44;
		  int local_40;
		  undefined8 *puStack_3c;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5896d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___get_Keys__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IAuchanItemFilter__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_AuchanArtifactData___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AuchanArtifactData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__IAuchanItemFilter__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AuchanArtifactData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__IAuchanItemFilter__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_AuchanArtifactData___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__IAuchanItemFilter__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AuchanArtifactData__get_Current__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_AuchanArtifactData___get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_Controller_Filters_IAuchanItemFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_uint__List_AuchanArtifactData___GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AuchanArtifactData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AuchanArtifactData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AuchanArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AuchanArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_FilterInfo_FilterType__IAuchanItemFilter__GetEnumerator__
		              );
		    DAT_ram_00a5896d = '\x01';
		  }
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  local_30 = 0;
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___TypeInfo
		                        );
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData____ctor__);
		  uVar2 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                    (param2,
		                     Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___get_Keys__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_40,uVar2,
		             Method_System_Collections_Generic_Dictionary_KeyCollection_uint__List_AuchanArtifactData___GetEnumerator__
		            );
		  local_8 = local_38;
		  local_48 = 0;
		  local_44 = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3ad,local_10,
		                       Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_AuchanArtifactData___MoveNext__
		                      );
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar8 = global_1;
		      goto code_r0x80f4f9ab;
		    }
		    iVar8 = local_48;
		    if (iVar3 == 0) goto code_r0x80f4f9f2;
		    DAT_ram_009d3e38 = 0;
		    param3_00 = local_8._4_4_;
		    uVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,param2,local_8._4_4_,
		                       Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___get_Item__
		                      );
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar8 = global_1;
		      goto code_r0x80f4f9ab;
		    }
		    DAT_ram_009d3e38 = 0;
		    System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		              (&local_40,uVar2,
		               Method_System_Collections_Generic_List_AuchanArtifactData__GetEnumerator__);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar8 = global_1;
		      goto code_r0x80f4f9ab;
		    }
		    local_18 = local_38;
		    local_20 = CONCAT44(puStack_3c,local_40);
		    local_50 = 0;
		    local_4c = &local_20;
		code_r0x80f4f3c5:
		    do {
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_20,
		                           Method_System_Collections_Generic_List_Enumerator_AuchanArtifactData__MoveNext__
		                          );
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f4f895;
		        if (iVar8 == 0) goto code_r0x80f4f927;
		        DAT_ram_009d3e38 = 0;
		        iVar3 = local_18._4_4_;
		        uVar2 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x9f,
		                           *(undefined4 *)(param1 + 0x18),
		                           Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IAuchanItemFilter__get_Values__
		                          );
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f4f895;
		        DAT_ram_009d3e38 = 0;
		        System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		                  (&local_40,uVar2,
		                   Method_System_Collections_Generic_Dictionary_ValueCollection_FilterInfo_FilterType__IAuchanItemFilter__GetEnumerator__
		                  );
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f4f895;
		        local_28 = local_38;
		        local_30 = CONCAT44(puStack_3c,local_40);
		        local_40 = 0;
		        puStack_3c = &local_30;
		        do {
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xa1,&local_30,
		                             Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__IAuchanItemFilter__MoveNext__
		                            );
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x80f4f5dc:
		            DAT_ram_009d3e38 = 0;
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar8 = global_1;
		            iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		            if (iVar8 == iVar6) {
		              piVar7 = (int *)import::env::__cxa_begin_catch(uVar2);
		              local_40 = *piVar7;
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_v(0x123);
		              iVar8 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              uVar4 = 1;
		              if (iVar8 != 1) goto code_r0x80f4f632;
		              uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              iVar8 = global_1;
		            }
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_ii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1de,&local_40);
		            iVar3 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar3 == 1) goto code_r0x80f4fa47;
		            goto code_r0x80f4f8a3;
		          }
		          if (uVar4 == 0) break;
		          uVar2 = *(undefined4 *)(iVar3 + 0x1c);
		          piVar7 = local_28._4_4_;
		          iVar8 = *local_28._4_4_;
		          if (*(ushort *)(iVar8 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		              if (Gameplay_Auchan_Controller_Filters_IAuchanItemFilter_TypeInfo == *piVar9) {
		                puVar5 = (undefined4 *)(piVar9[1] * 8 + iVar8 + 0xd0);
		                goto code_r0x80f4f58d;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar5 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_28._4_4_,
		                              Gameplay_Auchan_Controller_Filters_IAuchanItemFilter_TypeInfo,2);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80f4f5dc;
		code_r0x80f4f58d:
		          DAT_ram_009d3e38 = 0;
		          iVar8 = import::env::invoke_iiii(*puVar5,piVar7,uVar2,puVar5[1]);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80f4f5dc;
		        } while (iVar8 != 0);
		        uVar4 = uVar4 ^ 1;
		code_r0x80f4f632:
		        if (local_40 != 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_40);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x80f4fa5d;
		          goto code_r0x80f4f895;
		        }
		      } while (uVar4 == 0);
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3c1,param1_00,param3_00
		                         ,
		                         Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___ContainsKey__
		                        );
		      if (DAT_ram_009d3e38 == 1) break;
		      if (iVar8 == 0) {
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Collections_Generic_List_AuchanArtifactData__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x252,uVar2,
		                   Method_System_Collections_Generic_List_AuchanArtifactData___ctor__);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,param1_00,param3_00,uVar2
		                   ,
		                   Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___set_Item__
		                  );
		        if (DAT_ram_009d3e38 == 1) break;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,param1_00,param3_00
		                         ,
		                         Method_System_Collections_Generic_Dictionary_uint__List_AuchanArtifactData___get_Item__
		                        );
		      iVar8 = Method_System_Collections_Generic_List_AuchanArtifactData__Add__;
		      if (DAT_ram_009d3e38 == 1) break;
		      *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		      uVar4 = *(uint *)(iVar6 + 0xc);
		      if (uVar4 < *(uint *)(*(int *)(iVar6 + 8) + 0xc)) {
		        *(uint *)(iVar6 + 0xc) = uVar4 + 1;
		        *(int *)(*(int *)(iVar6 + 8) + uVar4 * 4 + 0x10) = iVar3;
		        goto code_r0x80f4f3c5;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar6,iVar3,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		    } while (DAT_ram_009d3e38 != 1);
		code_r0x80f4f895:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar8 = global_1;
		code_r0x80f4f8a3:
		    iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar3 != iVar8) {
		code_r0x80f4f8f7:
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1df,&local_50);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) goto code_r0x80f4fa47;
		      goto code_r0x80f4f9ab;
		    }
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar2);
		    local_50 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar8 = global_1;
		      goto code_r0x80f4f8f7;
		    }
		code_r0x80f4f927:
		    if (local_50 != 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_50);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar8 = global_1;
		code_r0x80f4f9ab:
		        iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar3 == iVar8) {
		          piVar7 = (int *)import::env::__cxa_begin_catch(uVar2);
		          iVar8 = *piVar7;
		          DAT_ram_009d3e38 = 0;
		          local_48 = iVar8;
		          import::env::invoke_v(0x123);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 != 1) {
		code_r0x80f4f9f2:
		            DAT_ram_009d3e38 = 0;
		            if (iVar8 == 0) {
		              return param1_00;
		            }
		            System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar2 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1e0,&local_48);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 == 1) {
		code_r0x80f4fa47:
		          DAT_ram_009d3e38 = 0;
		          import::env::__cxa_find_matching_catch_3(0);
		          unnamed_function_937();
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__resumeException(uVar2);
		      }
		code_r0x80f4fa5d:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  } while( true );
		}
		*/

		}

		// Token: 0x06004EA7 RID: 20135 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004EA7")]
		[Address(RVA = "0x9CD8", Offset = "0x9CD8", VA = "0x9CD8")]
		private Dictionary<uint, List<AuchanArtifactData>> Filter(Dictionary<uint, List<AuchanArtifactData>> items)
		{
		/* --- GHIDRA: Filter ---
		void Gameplay_Auchan_Controller_AuchanViewMediator__Filter(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Auchan_Controller_AuchanViewMediator__FilterInputChanged(param1,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004EA8 RID: 20136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EA8")]
		[Address(RVA = "0x9CD9", Offset = "0x9CD9", VA = "0x9CD9")]
		private void HandleAuchanItemsInfoRequested()
		{
		/* --- GHIDRA: HandleAuchanItemsInfoRequested ---
		void Gameplay_Auchan_Controller_AuchanViewMediator__HandleAuchanItemsInfoRequested
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5896e == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_Controller_AuchanViewMediator___c_TypeInfo);
		    DAT_ram_00a5896e = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Auchan_Controller_AuchanViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Auchan_Controller_AuchanViewMediator___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04002AF0 RID: 10992
		[Token(Token = "0x4002AF0")]
		private const int DETECTION_LENGTH_THRESHOLD = 2;

		// Token: 0x04002AF1 RID: 10993
		[Token(Token = "0x4002AF1")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<FilterInfo.FilterType, IAuchanItemFilter> _filters;

		// Token: 0x04002AF2 RID: 10994
		[Token(Token = "0x4002AF2")]
		[FieldOffset(Offset = "0x1C")]
		private IGameDataComparer<AuchanArtifactData> _comparer;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Auchan_Controller_AuchanViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58967 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AuchanModel__AuchanEvents__AuchanController__AuchanView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Auchan_Controller_AuchanViewMediator_HandleAuchanItemBought__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Auchan_Controller_AuchanViewMediator_HandleAuchanItemsInfoRequested__
		              );
		    DAT_ram_00a58967 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Auchan_Controller_AuchanViewMediator_HandleAuchanItemsInfoRequested__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Auchan_Controller_AuchanViewMediator_HandleAuchanItemBought__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Auchan_Controller_AuchanViewMediator_HandleAuchanItemsInfoRequested__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Auchan_Controller_AuchanViewMediator_HandleAuchanItemBought__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Auchan_Controller_AuchanViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58968 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AuchanModel__AuchanEvents__AuchanController__AuchanView__set_Controller__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Auchan_Controller_AuchanController_TryStartBuyAndEquip__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Auchan_Controller_AuchanController_TryStartBuy__);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtifactData__bool__TypeInfo);
		    DAT_ram_00a58968 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (iVar1 != 0) {
		    uVar5 = *(undefined4 *)
		             (*(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) + 8);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    uVar3 = unnamed_function_1417(System_Func_ArtifactData__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar3,uVar2,Method_Gameplay_Auchan_Controller_AuchanController_TryStartBuy__,0);
		    iVar1 = func_ii_7048(uVar5,uVar3,0);
		    uVar2 = System_Func_ArtifactData__bool__TypeInfo;
		    if (iVar1 == 0) {
		      iVar1 = *(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c);
		      *(undefined4 *)(iVar1 + 8) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar1,System_Func_ArtifactData__bool__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar1,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(*(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) + 8) =
		           iVar4;
		      uVar2 = System_Func_ArtifactData__bool__TypeInfo;
		      iVar4 = func_ii_1082(iVar1,System_Func_ArtifactData__bool__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar1,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar1 = *(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c);
		    }
		    uVar5 = *(undefined4 *)(iVar1 + 0xc);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    uVar3 = unnamed_function_1417(System_Func_ArtifactData__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar3,uVar2,Method_Gameplay_Auchan_Controller_AuchanController_TryStartBuyAndEquip__,
		               0);
		    iVar1 = func_ii_7048(uVar5,uVar3,0);
		    uVar2 = System_Func_ArtifactData__bool__TypeInfo;
		    if (iVar1 == 0) {
		      *(undefined4 *)
		       (*(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) + 0xc) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar1,System_Func_ArtifactData__bool__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar1,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(*(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) + 0xc) =
		           iVar4;
		      uVar2 = System_Func_ArtifactData__bool__TypeInfo;
		      iVar4 = func_ii_1082(iVar1,System_Func_ArtifactData__bool__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar1,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  param1[4] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (iVar1 != 0) {
		    uVar5 = *(undefined4 *)
		             (*(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) + 8);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    uVar3 = unnamed_function_1417(System_Func_ArtifactData__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar3,uVar2,Method_Gameplay_Auchan_Controller_AuchanController_TryStartBuy__,0);
		    iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    uVar2 = System_Func_ArtifactData__bool__TypeInfo;
		    if (iVar1 == 0) {
		      iVar1 = *(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c);
		      *(undefined4 *)(iVar1 + 8) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar1,System_Func_ArtifactData__bool__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar1,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(*(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) + 8) =
		           iVar4;
		      uVar2 = System_Func_ArtifactData__bool__TypeInfo;
		      iVar4 = func_ii_1082(iVar1,System_Func_ArtifactData__bool__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar1,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar1 = *(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c);
		    }
		    uVar5 = *(undefined4 *)(iVar1 + 0xc);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    uVar3 = unnamed_function_1417(System_Func_ArtifactData__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar3,uVar2,Method_Gameplay_Auchan_Controller_AuchanController_TryStartBuyAndEquip__,
		               0);
		    iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    uVar2 = System_Func_ArtifactData__bool__TypeInfo;
		    if (iVar1 == 0) {
		      *(undefined4 *)
		       (*(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) + 0xc) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar1,System_Func_ArtifactData__bool__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(*(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) + 0xc) =
		         iVar4;
		    uVar2 = System_Func_ArtifactData__bool__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Func_ArtifactData__bool__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Controller ---
		void Gameplay_Auchan_Controller_AuchanViewMediator__set_Controller
		               (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58969 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo);
		    DAT_ram_00a58969 = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) + 0x10
		                  );
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}
