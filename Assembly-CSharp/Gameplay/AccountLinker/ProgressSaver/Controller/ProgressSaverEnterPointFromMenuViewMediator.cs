using System;
using System.Collections.Generic;
using Core.Gameplay.Managers.Notifications.Controller;
using Gameplay.AccountLinker.Control;
using Gameplay.AccountLinker.ProgressSaver.Model;
using Gameplay.FeedbackForm.Model.Controll;
using Gameplay.UserInterface.Menu.ExternalLinks.Control;
using Gameplay.UserInterface.Menu.ExternalLinks.Model;
using Gameplay.UserInterface.Menu.ExternalLinks.View;
using Gameplay.UserInterface.Menu.Settings.Control;
using Gameplay.UserInterface.View.Menu;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.AccountLinker.ProgressSaver.Controller
{
	// Token: 0x02000E11 RID: 3601
	[Token(Token = "0x2000E11")]
	public class ProgressSaverEnterPointFromMenuViewMediator : BaseProgressSaverEnterPointViewMediator<MenuView>
	{
		// Token: 0x060057BE RID: 22462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057BE")]
		[Address(RVA = "0xA531", Offset = "0xA531", VA = "0xA531")]
		public ProgressSaverEnterPointFromMenuViewMediator(ProgressSaverModel model, ProgressSaverEvents events, ProgressSaverController controller, MenuWindow.MenuWindowArgs.SelectedTab selectedTab, IReadOnlyDictionary<string, string> payload)
		{
		/* --- GHIDRA: <OnTabChanged>b__15_0 ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___OnTabChanged_b__15_0
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63b56 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		              );
		    DAT_ram_00a63b56 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		                    );
		  **(undefined4 **)
		    (
		    Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		    + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: <set_View>b__14_0 ---
		uint Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___set_View_b__14_0
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param2 + 0xc);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x28),0);
		  return (uint)(iVar2 == *(int *)(iVar1 + 0x14));
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___ctor
		          (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63b48 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ProgressSaverModel__ProgressSaverEvents__ProgressSaverController__MenuView__get_View__
		              );
		    DAT_ram_00a63b48 = '\x01';
		  }
		  return *(undefined4 *)(param1 + 0x14);
		}
		*/

		}

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x060057BF RID: 22463 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060057C0 RID: 22464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011EB")]
		public override MenuView View
		{
			[Token(Token = "0x60057BF")]
			[Address(RVA = "0xA532", Offset = "0xA532", VA = "0xA532", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x60057C0")]
			[Address(RVA = "0xA533", Offset = "0xA533", VA = "0xA533", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060057C1 RID: 22465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C1")]
		[Address(RVA = "0xA534", Offset = "0xA534", VA = "0xA534")]
		private void OnTabChanged()
		{
		/* --- GHIDRA: OnTabChanged ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__OnTabChanged
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63b4b == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_UserInterface_View_Menu_MenuWindow_MenuWindowArgs_SelectedTab_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4638);
		    DAT_ram_00a63b4b = '\x01';
		  }
		  if (param2 == 0) {
		    local_4 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = func_ii_1081(Gameplay_UserInterface_View_Menu_MenuWindow_MenuWindowArgs_SelectedTab_TypeInfo
		                         ,&local_4);
		    uVar1 = func_ii_4419(StringLiteral_4638,uVar1,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7109(uVar1,0);
		  }
		  else {
		    Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__SwitchTab
		              (param1,param2,auStack_10);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: OnTabChanged ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__OnTabChanged
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63b4b == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_UserInterface_View_Menu_MenuWindow_MenuWindowArgs_SelectedTab_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4638);
		    DAT_ram_00a63b4b = '\x01';
		  }
		  if (param2 == 0) {
		    local_4 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = func_ii_1081(Gameplay_UserInterface_View_Menu_MenuWindow_MenuWindowArgs_SelectedTab_TypeInfo
		                         ,&local_4);
		    uVar1 = func_ii_4419(StringLiteral_4638,uVar1,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7109(uVar1,0);
		  }
		  else {
		    Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__SwitchTab
		              (param1,param2,auStack_10);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060057C2 RID: 22466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C2")]
		[Address(RVA = "0xA535", Offset = "0xA535", VA = "0xA535")]
		private void OnTabChanged(OptionsMenuButton optionsMenuButton)
		{
		}

		// Token: 0x060057C3 RID: 22467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C3")]
		[Address(RVA = "0xA536", Offset = "0xA536", VA = "0xA536", Slot = "21")]
		protected override void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		/* WARNING: Removing unreachable block (ram,0x8235ab4d) */
		
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *piVar3;
		  uint *puVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 *puVar7;
		  int iVar8;
		  undefined4 uVar9;
		  int param1_00;
		  int *piVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a63b4c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ProgressSaverModel__ProgressSaverEvents__ProgressSaverController__MenuView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_MenuWindow_MenuWindowArgs_SelectedTab__int__Clear__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_MenuWindow_MenuWindowArgs_SelectedTab__int__set_Item__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_GroupBy_OptionsMenuButton__bool___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderBy_IGrouping_bool__OptionsMenuButton___int___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_OptionsMenuButton__TabBarItemData___);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_UserInterface_Menu_ExternalLinks_Model_ExternalLinksModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_OptionsMenuButton__TabBarItemData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_IGrouping_bool__OptionsMenuButton___int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_OptionsMenuButton__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_IGrouping_bool__OptionsMenuButton___TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_IGrouping_bool__OptionsMenuButton___TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Linq_IGrouping_bool__OptionsMenuButton__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData__AddRange__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TabBarItemData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_TabBarItemData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c__SetupView_b__18_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c__SetupView_b__18_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c__SetupView_b__18_2__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_10739);
		    DAT_ram_00a63b4c = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_TabBarItemData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_TabBarItemData___ctor__);
		  uVar6 = *(undefined4 *)(param1[2] + 0x14);
		  if (*(int *)(
		              Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		              + 0x74) == 0) {
		    func_ii_306000(
		                  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		                  );
		  }
		  puVar7 = *(undefined4 **)
		            (
		            Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		            + 0x5c);
		  iVar8 = puVar7[1];
		  if (iVar8 == 0) {
		    if (*(int *)(
		                Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		                + 0x74) == 0) {
		      func_ii_306000(
		                    Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		                    );
		      puVar7 = *(undefined4 **)
		                (
		                Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		                + 0x5c);
		    }
		    uVar9 = *puVar7;
		    iVar8 = unnamed_function_1417(System_Func_OptionsMenuButton__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar8,uVar9,
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c__SetupView_b__18_0__
		               ,0);
		    *(int *)(*(int *)(
		                     Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		                     + 0x5c) + 4) = iVar8;
		  }
		  uVar6 = System_Linq_Enumerable__GroupBy_object__uint_
		                    (uVar6,iVar8,Method_System_Linq_Enumerable_GroupBy_OptionsMenuButton__bool___);
		  if (*(int *)(
		              Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		              + 0x74) == 0) {
		    func_ii_306000(
		                  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		                  );
		  }
		  puVar7 = *(undefined4 **)
		            (
		            Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		            + 0x5c);
		  iVar8 = puVar7[2];
		  if (iVar8 == 0) {
		    if (*(int *)(
		                Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		                + 0x74) == 0) {
		      func_ii_306000(
		                    Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		                    );
		      puVar7 = *(undefined4 **)
		                (
		                Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		                + 0x5c);
		    }
		    uVar9 = *puVar7;
		    iVar8 = unnamed_function_1417(System_Func_IGrouping_bool__OptionsMenuButton___int__TypeInfo);
		    func_ii_7937(iVar8,uVar9,
		                 Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c__SetupView_b__18_1__
		                 ,0);
		    *(int *)(*(int *)(
		                     Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		                     + 0x5c) + 8) = iVar8;
		  }
		  uVar1 = 0;
		  piVar3 = (int *)System_Linq_Enumerable__OrderBy_KeyValuePair_uint__object___uint_
		                            (uVar6,iVar8,
		                             Method_System_Linq_Enumerable_OrderBy_IGrouping_bool__OptionsMenuButton___int___
		                            );
		  iVar8 = *piVar3;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_IGrouping_bool__OptionsMenuButton___TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8235a66f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar3,
		                                System_Collections_Generic_IEnumerable_IGrouping_bool__OptionsMenuButton___TypeInfo
		                                ,0);
		code_r0x8235a66f:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x8235a6a8:
		  do {
		    piVar3 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		          puVar7 = (undefined4 *)(iVar8 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x8235a741;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar7 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8235ad05:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8235ad17;
		    }
		code_r0x8235a741:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar7,piVar3,puVar7[1]);
		    piVar3 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8235ad05;
		    if (iVar8 == 0) goto code_r0x8235ad60;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_IGrouping_bool__OptionsMenuButton___TypeInfo ==
		            *piVar10) {
		          puVar7 = (undefined4 *)(iVar8 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x8235a826;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar7 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_IGrouping_bool__OptionsMenuButton___TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8235aacc:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8235ad17;
		    }
		code_r0x8235a826:
		    DAT_ram_009d3e38 = 0;
		    piVar3 = (int *)import::env::invoke_iii(*puVar7,piVar3,puVar7[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8235aacc;
		    iVar8 = *piVar3;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Linq_IGrouping_bool__OptionsMenuButton__TypeInfo == *piVar10) {
		          puVar7 = (undefined4 *)(iVar8 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x8235a8f7;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar7 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar3,
		                        System_Linq_IGrouping_bool__OptionsMenuButton__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8235aad6:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8235ad17;
		    }
		code_r0x8235a8f7:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar7,piVar3,puVar7[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8235aad6;
		    if (iVar8 == 0) {
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         UI_Tabs_TabBarItemData_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) {
		        DAT_ram_009d3e38 = 0;
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8235ad17;
		      }
		      *(undefined4 *)(iVar8 + 0x14) = 0;
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   Core_GameLocalization_TypeInfo);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8235ad17;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::invoke_iiiiiiiii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x392,StringLiteral_10739
		                         ,1,0,1,0,0,0,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x8235acf1:
		        DAT_ram_009d3e38 = 0;
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8235ad17;
		      }
		      *(undefined4 *)(iVar8 + 0x10) = uVar6;
		      iVar5 = Method_System_Collections_Generic_List_TabBarItemData__Add__;
		      *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		      uVar1 = *(uint *)(iVar2 + 0xc);
		      if (uVar1 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		        *(uint *)(iVar2 + 0xc) = uVar1 + 1;
		        *(int *)(*(int *)(iVar2 + 8) + uVar1 * 4 + 0x10) = iVar8;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,iVar8,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		        if (DAT_ram_009d3e38 == 1) goto code_r0x8235acf1;
		      }
		      uVar6 = *(undefined4 *)(param1[2] + 8);
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         Gameplay_UserInterface_Menu_ExternalLinks_Model_ExternalLinksModel_TypeInfo
		                        );
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s___Scripting__UnityEngine__Render_ram_00004866 + 0x21,iVar8,uVar6,piVar3,0);
		        if (DAT_ram_009d3e38 != 1) {
		          param1[0xe] = iVar8;
		          goto code_r0x8235a6a8;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8235ad17;
		    }
		    if (*(int *)(
		                Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		                + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		                );
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8235ad17;
		      }
		    }
		    puVar7 = *(undefined4 **)
		              (
		              Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		              + 0x5c);
		    iVar8 = puVar7[3];
		    if (iVar8 == 0) {
		      if (*(int *)(
		                  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		                  + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		                  );
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 == 1) {
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8235ad17;
		        }
		        puVar7 = *(undefined4 **)
		                  (
		                  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		                  + 0x5c);
		      }
		      uVar6 = *puVar7;
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Func_OptionsMenuButton__TabBarItemData__TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x227,iVar8,uVar6,
		                   Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c__SetupView_b__18_2__
		                   ,0);
		        if (DAT_ram_009d3e38 != 1) {
		          *(int *)(*(int *)(
		                           Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c_TypeInfo
		                           + 0x5c) + 0xc) = iVar8;
		          goto code_r0x8235aa53;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8235ad17;
		    }
		code_r0x8235aa53:
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x228,piVar3,iVar8,
		                       Method_System_Linq_Enumerable_Select_OptionsMenuButton__TabBarItemData___);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0xf8,iVar2,uVar6,
		               Method_System_Collections_Generic_List_TabBarItemData__AddRange__);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8235ad17:
		  iVar8 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar5) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar6);
		    local_c = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		code_r0x8235ad60:
		      DAT_ram_009d3e38 = 0;
		      piVar3 = *local_8;
		      if (piVar3 != (int *)0x0) {
		        uVar1 = 0;
		        iVar8 = *piVar3;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		              puVar4 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x8235addb;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar3,System_IDisposable_TypeInfo,0);
		code_r0x8235addb:
		        (**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		      }
		      if (local_c != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_c);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar8 = 0;
		      System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		                (param1[0x10],
		                 Method_System_Collections_Generic_Dictionary_MenuWindow_MenuWindowArgs_SelectedTab__int__Clear__
		                );
		      if (0 < *(int *)(iVar2 + 0xc)) {
		        do {
		          param1_00 = param1[0x10];
		          iVar5 = System_Linq_Enumerable__ToList_object_
		                            (iVar2,iVar8,
		                             Method_System_Collections_Generic_List_TabBarItemData__get_Item__);
		          uVar1 = *(int *)(iVar5 + 0x14) - 1;
		          if (uVar1 < 5) {
		            uVar6 = *(undefined4 *)(&DAT_ram_005a4cf8 + uVar1 * 4);
		          }
		          else {
		            uVar6 = 0;
		          }
		          System_Collections_Generic_Dictionary_Int32Enum__int___get_Values
		                    (param1_00,uVar6,iVar8,
		                     Method_System_Collections_Generic_Dictionary_MenuWindow_MenuWindowArgs_SelectedTab__int__set_Item__
		                    );
		          iVar8 = iVar8 + 1;
		        } while (iVar8 < *(int *)(iVar2 + 0xc));
		      }
		      iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      UI_Tabs_TabBar__HandleSelected(*(undefined4 *)(iVar8 + 0x28),iVar2,0);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		                (*(undefined4 *)(iVar2 + 0x28),0,0,0);
		      return;
		    }
		    uVar6 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Render_ram_00004866 + 0x22,&local_c);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 != 1) {
		    import::env::__resumeException(uVar6);
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
		*/

		}

		// Token: 0x060057C4 RID: 22468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C4")]
		[Address(RVA = "0xA537", Offset = "0xA537", VA = "0xA537", Slot = "22")]
		protected override void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		undefined4
		Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__SetupView
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (param2 - 1U < 5) {
		    uVar1 = *(undefined4 *)(&DAT_ram_005a4cf8 + (param2 - 1U) * 4);
		  }
		  else {
		    uVar1 = 0;
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x060057C5 RID: 22469 RVA: 0x0000F9C0 File Offset: 0x0000DBC0
		[Token(Token = "0x60057C5")]
		[Address(RVA = "0xA538", Offset = "0xA538", VA = "0xA538")]
		private MenuWindow.MenuWindowArgs.SelectedTab ButtonId2Tab(uint buttonId)
		{
		/* --- GHIDRA: ButtonId2Tab ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__ButtonId2Tab
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int local_4;
		  
		  if (DAT_ram_00a63b4d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_MenuWindow_MenuWindowArgs_SelectedTab__int__TryGetValue__
		              );
		    DAT_ram_00a63b4d = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (param1[0x10],param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_MenuWindow_MenuWindowArgs_SelectedTab__int__TryGetValue__
		                    );
		  if ((iVar1 != 0) &&
		     (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c)),
		     *(int *)(*(int *)(iVar1 + 0x28) + 0x3c) != local_4)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		              (*(undefined4 *)(iVar1 + 0x28),local_4,1,0);
		  }
		  return;
		}
		*/

			return MenuWindow.MenuWindowArgs.SelectedTab.undefined;
		}

		// Token: 0x060057C6 RID: 22470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C6")]
		[Address(RVA = "0xA539", Offset = "0xA539", VA = "0xA539")]
		private void SwitchTab(MenuWindow.MenuWindowArgs.SelectedTab tab)
		{
		/* --- GHIDRA: SwitchTab ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__SwitchTab
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param2_00;
		  int iVar3;
		  uint *puVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int *piVar8;
		  undefined4 *puVar9;
		  undefined4 uVar10;
		  undefined4 local_20;
		  undefined4 local_1c;
		  int local_14;
		  int **local_10;
		  int *local_c;
		  int *local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a63b4e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ProgressSaverModel__ProgressSaverEvents__ProgressSaverController__MenuView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_KeyValuePair_string__string___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_KeyValuePair_string__string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Rounting_ILocatorRepository_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Rounting_ILocator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IReadOnlyCollection_KeyValuePair_string__string___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_GameActivityRouting_IRouter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string__get_Value__);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Uri_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2361);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2373);
		    Mono_Security_ASN1__get_Item(&StringLiteral_734);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10979);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10978);
		    DAT_ram_00a63b4e = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = (int *)0x0;
		  local_c = (int *)0x0;
		  uVar7 = *(undefined4 *)(param2 + 0x10);
		  if (*(int *)(System_Uri_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Uri_TypeInfo);
		  }
		  iVar3 = func_ii_16334(uVar7,0,&local_4,0);
		  if (iVar3 == 0) {
		    uVar7 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor
		                      (StringLiteral_10978,*(undefined4 *)(param2 + 0x10),0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar7,0);
		  }
		  else {
		    piVar8 = *(int **)(*(int *)(param1 + 8) + 0x10);
		    iVar3 = *piVar8;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + iVar3 + 0x2b0);
		          goto code_r0x82359b43;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x3e);
		code_r0x82359b43:
		    piVar8 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		    uVar2 = 0;
		    iVar3 = *piVar8;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_GameActivityRouting_IRouter_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x82359bc5;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar8,Core_Gameplay_Managers_GameActivityRouting_IRouter_TypeInfo
		                                  ,0);
		code_r0x82359bc5:
		    piVar5 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		    piVar8 = local_4;
		    uVar2 = 0;
		    iVar3 = *piVar5;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Rounting_ILocatorRepository_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x82359c4d;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Rounting_ILocatorRepository_TypeInfo,0);
		code_r0x82359c4d:
		    iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,piVar8,&local_8,puVar4[1]);
		    if (iVar3 == 0) {
		      uVar7 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor
		                        (StringLiteral_10979,*(undefined4 *)(param2 + 0x10),0);
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      func_ii_7830(uVar7,0);
		    }
		    else {
		      piVar8 = *(int **)(param1 + 0x1c);
		      if (piVar8 != (int *)0x0) {
		        uVar2 = 0;
		        iVar3 = *piVar8;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          do {
		            if (System_Collections_Generic_IReadOnlyCollection_KeyValuePair_string__string___TypeInfo
		                == *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		              puVar4 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x82359cdb;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar8,
		                                      System_Collections_Generic_IReadOnlyCollection_KeyValuePair_string__string___TypeInfo
		                                      ,0);
		code_r0x82359cdb:
		        iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		        if (0 < iVar3) {
		          uVar2 = 0;
		          puVar9 = &StringLiteral_734;
		          uVar7 = (**(code **)((ulonglong)*(uint *)(*local_4 + 0xd8) * 4))
		                            (local_4,*(undefined4 *)(*local_4 + 0xdc));
		          iVar3 = func_ii_7903(uVar7,StringLiteral_2373,0);
		          if (iVar3 == 0) {
		            puVar9 = &StringLiteral_2373;
		          }
		          uVar10 = *puVar9;
		          piVar8 = *(int **)(param1 + 0x1c);
		          iVar3 = *piVar8;
		          if (*(ushort *)(iVar3 + 0xb6) != 0) {
		            do {
		              if (System_Collections_Generic_IEnumerable_KeyValuePair_string__string___TypeInfo ==
		                  *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		                puVar4 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 +
		                                 0xc0);
		                goto code_r0x82359d9a;
		              }
		              uVar2 = uVar2 + 1;
		            } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		          }
		          puVar4 = (uint *)func_ii_1080(piVar8,
		                                        System_Collections_Generic_IEnumerable_KeyValuePair_string__string___TypeInfo
		                                        ,0);
		code_r0x82359d9a:
		          local_c = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		          local_14 = 0;
		          local_10 = &local_c;
		          do {
		            param2_00 = uVar7;
		            piVar8 = local_c;
		            iVar3 = *local_c;
		            if (*(ushort *)(iVar3 + 0xb6) != 0) {
		              uVar2 = 0;
		              do {
		                piVar5 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		                if (System_Collections_IEnumerator_TypeInfo == *piVar5) {
		                  puVar9 = (undefined4 *)(iVar3 + piVar5[1] * 8 + 0xc0);
		                  goto code_r0x82359e65;
		                }
		                uVar2 = uVar2 + 1;
		              } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar9 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                                System_Collections_IEnumerator_TypeInfo,0);
		            if (DAT_ram_009d3e38 == 1) {
		code_r0x8235a05b:
		              DAT_ram_009d3e38 = 0;
		              uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x8235a063;
		            }
		code_r0x82359e65:
		            DAT_ram_009d3e38 = 0;
		            iVar3 = import::env::invoke_iii(*puVar9,piVar8,puVar9[1]);
		            piVar8 = local_c;
		            if (DAT_ram_009d3e38 == 1) goto code_r0x8235a05b;
		            if (iVar3 == 0) {
		              iVar3 = 9;
		              goto code_r0x8235a0b0;
		            }
		            iVar3 = *local_c;
		            if (*(ushort *)(iVar3 + 0xb6) != 0) {
		              uVar2 = 0;
		              do {
		                piVar5 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		                if (System_Collections_Generic_IEnumerator_KeyValuePair_string__string___TypeInfo ==
		                    *piVar5) {
		                  puVar9 = (undefined4 *)(iVar3 + piVar5[1] * 8 + 0xc0);
		                  goto code_r0x82359f3f;
		                }
		                uVar2 = uVar2 + 1;
		              } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar9 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                                System_Collections_Generic_IEnumerator_KeyValuePair_string__string___TypeInfo
		                                ,0);
		            if (DAT_ram_009d3e38 == 1) {
		code_r0x8235a03d:
		              DAT_ram_009d3e38 = 0;
		              uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x8235a063;
		            }
		code_r0x82359f3f:
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii(*puVar9,&local_20,piVar8,puVar9[1]);
		            uVar1 = local_1c;
		            uVar7 = local_20;
		            if (DAT_ram_009d3e38 == 1) goto code_r0x8235a03d;
		            DAT_ram_009d3e38 = 0;
		            iVar6 = import::env::invoke_iii
		                              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1b1,
		                               string___TypeInfo,5);
		            iVar3 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar3 == 1) {
		              uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x8235a063;
		            }
		            *(undefined4 *)(iVar6 + 0x18) = uVar7;
		            *(undefined4 *)(iVar6 + 0x14) = uVar10;
		            *(undefined4 *)(iVar6 + 0x10) = param2_00;
		            uVar7 = StringLiteral_2361;
		            *(undefined4 *)(iVar6 + 0x20) = uVar1;
		            *(undefined4 *)(iVar6 + 0x1c) = uVar7;
		            DAT_ram_009d3e38 = 0;
		            uVar7 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x236,iVar6,0);
		            iVar3 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            uVar10 = StringLiteral_734;
		          } while (iVar3 != 1);
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8235a063:
		          iVar3 = global_1;
		          iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar3 != iVar6) {
		code_r0x8235a206:
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_ii(s___Scripting__UnityEngine__Render_ram_00004866 + 0x1f,&local_14)
		            ;
		            iVar3 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar3 == 1) {
		              import::env::__cxa_find_matching_catch_3(0);
		              unnamed_function_937();
		              do {
		                halt_trap();
		              } while( true );
		            }
		            import::env::__resumeException(uVar7);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          piVar8 = (int *)import::env::__cxa_begin_catch(uVar7);
		          local_14 = *piVar8;
		          iVar3 = 0;
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_v(0x123);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 == 1) {
		            uVar7 = import::env::__cxa_find_matching_catch_2();
		            goto code_r0x8235a206;
		          }
		code_r0x8235a0b0:
		          DAT_ram_009d3e38 = 0;
		          piVar8 = *local_10;
		          if (piVar8 != (int *)0x0) {
		            uVar2 = 0;
		            iVar6 = *piVar8;
		            if (*(ushort *)(iVar6 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		                  puVar4 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x8235a12b;
		                }
		                uVar2 = uVar2 + 1;
		              } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		            }
		            puVar4 = (uint *)func_ii_1080(piVar8,System_IDisposable_TypeInfo,0);
		code_r0x8235a12b:
		            (**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		          }
		          if (local_14 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(local_14);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if (iVar3 != 0) {
		            if (iVar3 == 1) {
		              return;
		            }
		            if (iVar3 == 2) {
		              return;
		            }
		            if (iVar3 == 3) {
		              return;
		            }
		            if (iVar3 == 4) {
		              return;
		            }
		            if (iVar3 == 5) {
		              return;
		            }
		            if (iVar3 == 6) {
		              return;
		            }
		            if (iVar3 == 7) {
		              return;
		            }
		            if (iVar3 == 8) {
		              return;
		            }
		            if (iVar3 != 9) {
		              return;
		            }
		          }
		          piVar8 = (int *)unnamed_function_1417(System_Uri_TypeInfo);
		          UI_Windows_ClosableBaseWindow_object___HandleCloseButton(piVar8,param2_00,0);
		          local_4 = piVar8;
		        }
		      }
		      piVar5 = local_4;
		      piVar8 = local_8;
		      uVar2 = 0;
		      iVar3 = *local_8;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        do {
		          if (Core_Rounting_ILocator_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + iVar3 + 0xd0);
		            goto code_r0x8235a1ea;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		      }
		      puVar4 = (uint *)func_ii_1080(local_8,Core_Rounting_ILocator_TypeInfo,2);
		code_r0x8235a1ea:
		      (**(code **)((ulonglong)*puVar4 * 4))(piVar8,piVar5,puVar4[1]);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060057C7 RID: 22471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C7")]
		[Address(RVA = "0xA53A", Offset = "0xA53A", VA = "0xA53A")]
		private void OptionMenuButtonClickedEventHandler(OptionsMenuButton dic)
		{
		}

		// Token: 0x060057C8 RID: 22472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C8")]
		[Address(RVA = "0xA53B", Offset = "0xA53B", VA = "0xA53B", Slot = "23")]
		protected override void ValidateShowProgressButton()
		{
		/* --- GHIDRA: ValidateShowProgressButton ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__ValidateShowProgressButton
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  undefined4 param1_00;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  int local_4;
		  
		  if (DAT_ram_00a63b4f == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_Control_AccountLinkerViewMediator_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_MenuWindow_MenuWindowArgs_SelectedTab__set_CurrentState__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_ProgressSaver_ProgressSaverEvents_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator_TypeInfo);
		    DAT_ram_00a63b4f = '\x01';
		  }
		  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__ShowExternalLinks
		            (param1,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar2,1,
		             Method_UI_MonoBehaviourWithStates_MenuWindow_MenuWindowArgs_SelectedTab__set_CurrentState__
		            );
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x1a8);
		        goto code_r0x8235b0ed;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x1d);
		code_r0x8235b0ed:
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  piVar6 = *(int **)(*(int *)(iVar7 + 0x18) + 0x18);
		  iVar7 = *piVar6;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x100) * 4))
		                    (piVar6,*(undefined4 *)(iVar7 + 0x104));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x1a8);
		        goto code_r0x8235b1b5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x1d);
		code_r0x8235b1b5:
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  piVar6 = *(int **)(*(int *)(iVar7 + 0x18) + 0x18);
		  iVar7 = *piVar6;
		  uVar4 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x110) * 4))
		                    (piVar6,*(undefined4 *)(iVar7 + 0x114));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x1a8);
		        goto code_r0x8235b27d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x1d);
		code_r0x8235b27d:
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar8 = *(undefined4 *)(*(int *)(iVar7 + 0x18) + 0x18);
		  piVar6 = (int *)unnamed_function_1417
		                            (Gameplay_AccountLinker_Control_AccountLinkerViewMediator_TypeInfo);
		  Gameplay_AccountLinker_Control_AccountLinkerViewMediator__Dispose(piVar6,uVar2,uVar4,uVar8,piVar6)
		  ;
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x160) * 4))
		            (piVar6,*(undefined4 *)(iVar7 + 0x2c),*(undefined4 *)(*piVar6 + 0x164));
		  param1[8] = (int)piVar6;
		  uVar2 = unnamed_function_1417(Gameplay_AccountLinker_ProgressSaver_ProgressSaverEvents_TypeInfo);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x8235b38b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8235b38b:
		  piVar5 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar1 = 0;
		  iVar7 = *piVar5;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x160);
		        goto code_r0x8235b40d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Application_IApp_TypeInfo,0x14);
		code_r0x8235b40d:
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar4 = *(undefined4 *)(iVar7 + 0x14);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar5;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x8235b4b8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8235b4b8:
		  uVar8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar8 = func_ii_7112(uVar8,0);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel_TypeInfo);
		  Gameplay_AccountLinker_ProgressSaver_Model_ProgressSaverModel__Dispose
		            (param1_00,piVar6,uVar4,uVar8,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x1a8);
		        goto code_r0x8235b583;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x1d);
		code_r0x8235b583:
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar8 = *(undefined4 *)(*(int *)(iVar7 + 0x18) + 0x18);
		  uVar4 = unnamed_function_1417
		                    (
		                    Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController_TypeInfo
		                    );
		  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController__Dispose
		            (uVar4,uVar8,param1_00,uVar2,0);
		  piVar6 = (int *)unnamed_function_1417
		                            (
		                            Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator_TypeInfo
		                            );
		  if (DAT_ram_00a63b5a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ProgressSaverModel__ProgressSaverEvents__ProgressSaverController__ProgressSaverView___ctor__
		              );
		    DAT_ram_00a63b5a = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (piVar6,param1_00,uVar2,uVar4,
		             Method_MVC_AbstractViewMediator_ProgressSaverModel__ProgressSaverEvents__ProgressSaverController__ProgressSaverView___ctor__
		            );
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x160) * 4))
		            (piVar6,*(undefined4 *)(iVar7 + 0x30),*(undefined4 *)(*piVar6 + 0x164));
		  param1[9] = (int)piVar6;
		  if (DAT_ram_00a63b4d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_MenuWindow_MenuWindowArgs_SelectedTab__int__TryGetValue__
		              );
		    DAT_ram_00a63b4d = '\x01';
		  }
		  local_4 = 0;
		  iVar7 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (param1[0x10],1,&local_4,
		                     Method_System_Collections_Generic_Dictionary_MenuWindow_MenuWindowArgs_SelectedTab__int__TryGetValue__
		                    );
		  if ((iVar7 != 0) &&
		     (iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c)),
		     *(int *)(*(int *)(iVar7 + 0x28) + 0x3c) != local_4)) {
		    iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		              (*(undefined4 *)(iVar7 + 0x28),local_4,1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060057C9 RID: 22473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C9")]
		[Address(RVA = "0xA53C", Offset = "0xA53C", VA = "0xA53C")]
		public void ShowSaveProgress()
		{
		/* --- GHIDRA: ShowSaveProgress ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__ShowSaveProgress
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int *piVar5;
		  int iVar6;
		  int local_4;
		  
		  if (DAT_ram_00a63b50 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_MenuWindow_MenuWindowArgs_SelectedTab__set_CurrentState__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_UserInterface_Menu_Settings_Control_SettingsController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_UserInterface_Menu_Settings_SettingsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_UserInterface_Menu_Settings_Model_SettingsModel_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator_TypeInfo);
		    DAT_ram_00a63b50 = '\x01';
		  }
		  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__ShowExternalLinks
		            (param1,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar2,2,
		             Method_UI_MonoBehaviourWithStates_MenuWindow_MenuWindowArgs_SelectedTab__set_CurrentState__
		            );
		  uVar2 = unnamed_function_1417(Gameplay_UserInterface_Menu_Settings_SettingsEvents_TypeInfo);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x8235bac2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8235bac2:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_UserInterface_Menu_Settings_Model_SettingsModel_TypeInfo);
		  Gameplay_UserInterface_Menu_Settings_Model_SettingsModel__Dispose(param1_00,piVar5,uVar4,0);
		  uVar4 = unnamed_function_1417
		                    (Gameplay_UserInterface_Menu_Settings_Control_SettingsController_TypeInfo);
		  Gameplay_UserInterface_Menu_Settings_Model_SettingsModel___ctor(uVar4,param1_00,uVar2,0);
		  piVar5 = (int *)unnamed_function_1417
		                            (
		                            Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator_TypeInfo
		                            );
		  Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator__Dispose
		            (piVar5,param1_00,uVar2,uVar4,0);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x160) * 4))
		            (piVar5,*(undefined4 *)(iVar6 + 0x34),*(undefined4 *)(*piVar5 + 0x164));
		  param1[10] = (int)piVar5;
		  if (DAT_ram_00a63b4d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_MenuWindow_MenuWindowArgs_SelectedTab__int__TryGetValue__
		              );
		    DAT_ram_00a63b4d = '\x01';
		  }
		  local_4 = 0;
		  iVar6 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (param1[0x10],2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_MenuWindow_MenuWindowArgs_SelectedTab__int__TryGetValue__
		                    );
		  if ((iVar6 != 0) &&
		     (iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c)),
		     *(int *)(*(int *)(iVar6 + 0x28) + 0x3c) != local_4)) {
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		              (*(undefined4 *)(iVar6 + 0x28),local_4,1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060057CA RID: 22474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057CA")]
		[Address(RVA = "0xA53D", Offset = "0xA53D", VA = "0xA53D")]
		public void ShowSettings()
		{
		/* --- GHIDRA: ShowSettings ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__ShowSettings
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 param3;
		  undefined4 param2_00;
		  int local_4;
		  
		  if (DAT_ram_00a63b51 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Notifications_Controller_GameNotificationSettingsWindowMediator_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_MenuWindow_MenuWindowArgs_SelectedTab__set_CurrentState__
		              );
		    DAT_ram_00a63b51 = '\x01';
		  }
		  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__ShowExternalLinks
		            (param1,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar2,3,
		             Method_UI_MonoBehaviourWithStates_MenuWindow_MenuWindowArgs_SelectedTab__set_CurrentState__
		            );
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x260);
		        goto code_r0x8235bcee;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x34);
		code_r0x8235bcee:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar2 = *(undefined4 *)(iVar5 + 0x10);
		  param3 = *(undefined4 *)(iVar5 + 0x18);
		  param2_00 = *(undefined4 *)(iVar5 + 0x14);
		  piVar4 = (int *)unnamed_function_1417
		                            (
		                            Core_Gameplay_Managers_Notifications_Controller_GameNotificationSettingsWindowMediator_TypeInfo
		                            );
		  Core_Gameplay_Managers_Notifications_Events_GameNotificationsEvents___ctor
		            (piVar4,param2_00,param3,uVar2,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x160) * 4))
		            (piVar4,*(undefined4 *)(iVar5 + 0x38),*(undefined4 *)(*piVar4 + 0x164));
		  param1[0xb] = (int)piVar4;
		  if (DAT_ram_00a63b4d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_MenuWindow_MenuWindowArgs_SelectedTab__int__TryGetValue__
		              );
		    DAT_ram_00a63b4d = '\x01';
		  }
		  local_4 = 0;
		  iVar5 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (param1[0x10],3,&local_4,
		                     Method_System_Collections_Generic_Dictionary_MenuWindow_MenuWindowArgs_SelectedTab__int__TryGetValue__
		                    );
		  if ((iVar5 != 0) &&
		     (iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c)),
		     *(int *)(*(int *)(iVar5 + 0x28) + 0x3c) != local_4)) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		              (*(undefined4 *)(iVar5 + 0x28),local_4,1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060057CB RID: 22475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057CB")]
		[Address(RVA = "0xA53E", Offset = "0xA53E", VA = "0xA53E")]
		public void ShowNotifications()
		{
		/* --- GHIDRA: ShowNotifications ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__ShowNotifications
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 uVar1;
		  uint *puVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  undefined4 uVar5;
		  undefined4 param1_01;
		  undefined8 uVar6;
		  int *piVar7;
		  int iVar8;
		  undefined4 uVar9;
		  uint uVar10;
		  int local_4;
		  
		  if (DAT_ram_00a63b52 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_AuthTokenSourceEternal_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_FeedbackForm_Model_Controll_FeedbackFormController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_FeedbackForm_FeedbackFormEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_FeedbackForm_Model_FeedbackFormModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_FeedbackForm_Service_FeedbackFormService_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_MenuWindow_MenuWindowArgs_SelectedTab__set_CurrentState__
		              );
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    DAT_ram_00a63b52 = '\x01';
		  }
		  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__ShowExternalLinks
		            (param1,0);
		  uVar6 = CONCAT44(in_register_20000004,param1);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar6,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar1,4,
		             Method_UI_MonoBehaviourWithStates_MenuWindow_MenuWindowArgs_SelectedTab__set_CurrentState__
		            );
		  uVar1 = unnamed_function_1417(Gameplay_FeedbackForm_FeedbackFormEvents_TypeInfo);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar10 = 0;
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8 + 4) * 8 + iVar8 + 0xe0);
		        goto code_r0x8235bf50;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8235bf50:
		  uVar6 = CONCAT44(uVar5,piVar7);
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(uVar6,puVar2[1]);
		  uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  uVar10 = 0;
		  iVar8 = *piVar3;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8 + 4) * 8 + iVar8 + 0x160);
		        goto code_r0x8235bfd4;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0x14);
		code_r0x8235bfd4:
		  uVar6 = CONCAT44(uVar5,piVar3);
		  iVar8 = (**(code **)((ulonglong)*puVar2 * 4))(uVar6,puVar2[1]);
		  uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  piVar7 = (int *)Gameplay_FeedbackForm_Model_Source_DefaultSource___ctor
		                            (piVar7,*(undefined4 *)(iVar8 + 0x14),0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *piVar3;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8 + 4) * 8 + iVar8 + 0x140);
		        goto code_r0x8235c085;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8235c085:
		  uVar10 = 0;
		  uVar6 = CONCAT44(uVar5,piVar3);
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(uVar6,puVar2[1]);
		  uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  uVar4 = func_ii_7112(uVar4,0);
		  param1_00 = unnamed_function_1417(Gameplay_FeedbackForm_Model_FeedbackFormModel_TypeInfo);
		  Gameplay_FeedbackForm_Model_FeedbackFormModel__Dispose(param1_00,piVar7,0xb,uVar4,0);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8 + 4) * 8 + iVar8 + 0xd8);
		        goto code_r0x8235c124;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,
		                                Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo,3);
		code_r0x8235c124:
		  uVar10 = 0;
		  uVar6 = CONCAT44(uVar5,piVar7);
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(uVar6,puVar2[1]);
		  uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8 + 4) * 8 + iVar8 + 0xe0);
		        goto code_r0x8235c1a6;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,
		                                Gameplay_FeedbackForm_Model_Source_IFeedbackFormSource_TypeInfo,4);
		code_r0x8235c1a6:
		  uVar6 = CONCAT44(uVar5,piVar7);
		  piVar7 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(uVar6,puVar2[1]);
		  uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  uVar10 = 0;
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8 + 4) * 8 + iVar8 + 200);
		        goto code_r0x8235c224;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,
		                                Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo
		                                ,1);
		code_r0x8235c224:
		  iVar8 = (**(code **)((ulonglong)*puVar2 * 4))(CONCAT44(uVar5,piVar7),puVar2[1]);
		  uVar9 = *(undefined4 *)(iVar8 + 0x24);
		  uVar5 = unnamed_function_1417(Core_Gameplay_AuthTokenSourceEternal_TypeInfo);
		  UnityEngine_Purchasing_Default_WinProductDescription__set_platformSpecificID(uVar5,uVar9,0);
		  if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_TimeSpan_TypeInfo);
		  }
		  uVar9 = 0x405e0000;
		  uVar6 = System_Threading_CancellationTokenSource___ctor(120.0,0);
		  param1_01 = unnamed_function_1417(Gameplay_FeedbackForm_Service_FeedbackFormService_TypeInfo);
		  Core_Application_Managers_Configuration_Curator_CuratorJsonMessages_BootAns___ctor
		            (param1_01,uVar4,uVar5,uVar6,0);
		  piVar7 = (int *)unnamed_function_1417
		                            (Gameplay_FeedbackForm_Model_Controll_FeedbackFormController_TypeInfo);
		  Gameplay_FeedbackForm_Model_Controll_FeedbackFormController__Dispose
		            (piVar7,param1_01,param1_00,uVar1,0);
		  piVar3 = (int *)unnamed_function_1417
		                            (Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator_TypeInfo)
		  ;
		  Gameplay_FeedbackForm_Model_Controll_FeedbackFormController__TrySubmit
		            (piVar3,param1_00,uVar1,piVar7,0);
		  uVar6 = CONCAT44(uVar9,param1);
		  iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (uVar6,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = CONCAT44((int)((ulonglong)uVar6 >> 0x20),piVar3);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		            (uVar6,*(undefined4 *)(iVar8 + 0x3c),*(undefined4 *)(*piVar3 + 0x164));
		  uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  param1[0xc] = (int)piVar3;
		  if ((char)piVar7[2] == '\0') {
		    uVar6 = CONCAT44(uVar5,piVar7);
		    (**(code **)((ulonglong)*(uint *)(*piVar7 + 0xf8) * 4))(uVar6,*(undefined4 *)(*piVar7 + 0xfc));
		    uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    *(undefined1 *)(piVar7 + 2) = 1;
		  }
		  if (DAT_ram_00a63b4d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_MenuWindow_MenuWindowArgs_SelectedTab__int__TryGetValue__
		              );
		    DAT_ram_00a63b4d = '\x01';
		  }
		  local_4 = 0;
		  iVar8 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (param1[0x10],4,&local_4,
		                     Method_System_Collections_Generic_Dictionary_MenuWindow_MenuWindowArgs_SelectedTab__int__TryGetValue__
		                    );
		  if (iVar8 != 0) {
		    iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (CONCAT44(uVar5,param1),*(undefined4 *)(*param1 + 0x15c));
		    if (*(int *)(*(int *)(iVar8 + 0x28) + 0x3c) != local_4) {
		      iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		                (*(undefined4 *)(iVar8 + 0x28),local_4,1,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060057CC RID: 22476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057CC")]
		[Address(RVA = "0xA53F", Offset = "0xA53F", VA = "0xA53F")]
		public void ShowFeedbackForm()
		{
		/* --- GHIDRA: ShowFeedbackForm ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__ShowFeedbackForm
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a63b53 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_UserInterface_Menu_ExternalLinks_Control_ExternalLinksController_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_UserInterface_Menu_ExternalLinks_Control_ExternalLinksMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_MenuWindow_MenuWindowArgs_SelectedTab__set_CurrentState__
		              );
		    DAT_ram_00a63b53 = '\x01';
		  }
		  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__ShowExternalLinks
		            (param1,param1);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar1,0,
		             Method_UI_MonoBehaviourWithStates_MenuWindow_MenuWindowArgs_SelectedTab__set_CurrentState__
		            );
		  iVar2 = param1[0xf];
		  iVar3 = param1[0xe];
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_UserInterface_Menu_ExternalLinks_Control_ExternalLinksController_TypeInfo
		                    );
		  Gameplay_UserInterface_Menu_ExternalLinks_Model_ExternalLinksModel__get_Buttons
		            (uVar1,iVar3,iVar2,0);
		  iVar2 = param1[0xf];
		  iVar3 = param1[0xe];
		  param1_00 = (int *)unnamed_function_1417
		                               (
		                               Gameplay_UserInterface_Menu_ExternalLinks_Control_ExternalLinksMediator_TypeInfo
		                               );
		  Gameplay_UserInterface_Menu_ExternalLinks_Control_ExternalLinksController___ctor
		            (param1_00,iVar3,iVar2,uVar1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,*(undefined4 *)(iVar2 + 0x40),*(undefined4 *)(*param1_00 + 0x164));
		  param1[0xd] = (int)param1_00;
		  return;
		}
		*/

		}

		// Token: 0x060057CD RID: 22477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057CD")]
		[Address(RVA = "0xA540", Offset = "0xA540", VA = "0xA540")]
		public void ShowExternalLinks()
		{
		/* --- GHIDRA: ShowExternalLinks ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__ShowExternalLinks
		               (int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  piVar1 = *(int **)(param1 + 0x20);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x20) = 0;
		  piVar1 = *(int **)(param1 + 0x24);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x24) = 0;
		  piVar1 = *(int **)(param1 + 0x28);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x28) = 0;
		  piVar1 = *(int **)(param1 + 0x2c);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x2c) = 0;
		  piVar1 = *(int **)(param1 + 0x30);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x30) = 0;
		  piVar1 = *(int **)(param1 + 0x34);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x34) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060057CE RID: 22478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057CE")]
		[Address(RVA = "0xA541", Offset = "0xA541", VA = "0xA541")]
		private void ClearMediators()
		{
		/* --- GHIDRA: ClearMediators ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__ClearMediators
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  int iVar2;
		  int iVar3;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63b54 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OptionsMenuButton__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_BaseProgressSaverEnterPointViewMediator_MenuView__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator_OptionMenuButtonClickedEventHandler__
		              );
		    DAT_ram_00a63b54 = '\x01';
		  }
		  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__ShowExternalLinks
		            (param1,param1);
		  iVar3 = *(int *)(param1 + 0x3c);
		  param1_01 = *(undefined4 *)(iVar3 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_OptionsMenuButton__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator_OptionMenuButtonClickedEventHandler__
		             ,0);
		  param1_00 = func_ii_7048(param1_01,uVar1,0);
		  uVar1 = System_Action_OptionsMenuButton__TypeInfo;
		  if (param1_00 == 0) {
		    *(undefined4 *)(iVar3 + 0x14) = 0;
		  }
		  else {
		    iVar2 = func_ii_1082(param1_00,System_Action_OptionsMenuButton__TypeInfo);
		    if (iVar2 == 0) {
		      System_Activator__CreateInstance(param1_00,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar3 + 0x14) = iVar2;
		    uVar1 = System_Action_OptionsMenuButton__TypeInfo;
		    iVar3 = func_ii_1082(param1_00,System_Action_OptionsMenuButton__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(param1_00,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  *(undefined4 *)(param1 + 0x3c) = 0;
		  Gameplay_AccountLinker_ProgressSaver_Controller_BaseProgressSaverEnterPointViewMediator_object___CloseProgressSaverWindow
		            (param1,
		             Method_Gameplay_AccountLinker_ProgressSaver_Controller_BaseProgressSaverEnterPointViewMediator_MenuView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060057CF RID: 22479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057CF")]
		[Address(RVA = "0xA542", Offset = "0xA542", VA = "0xA542", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		undefined4
		Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__Dispose
		          (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63b55 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_UserInterface_View_Menu_MenuWindow_MenuWindowArgs_SelectedTab_TypeInfo);
		    DAT_ram_00a63b55 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param2 + 0x10);
		  local_8 = 0xffffffff;
		  local_c = Gameplay_UserInterface_View_Menu_MenuWindow_MenuWindowArgs_SelectedTab_TypeInfo;
		  local_4 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  uVar1 = func_ii_7903(param1_00,uVar1,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x04002F86 RID: 12166
		[Token(Token = "0x4002F86")]
		[FieldOffset(Offset = "0x18")]
		private MenuWindow.MenuWindowArgs.SelectedTab _selectedTab;

		// Token: 0x04002F87 RID: 12167
		[Token(Token = "0x4002F87")]
		[FieldOffset(Offset = "0x1C")]
		private IReadOnlyDictionary<string, string> _payload;

		// Token: 0x04002F88 RID: 12168
		[Token(Token = "0x4002F88")]
		[FieldOffset(Offset = "0x20")]
		private AccountLinkerViewMediator _accountLinkerViewMediator;

		// Token: 0x04002F89 RID: 12169
		[Token(Token = "0x4002F89")]
		[FieldOffset(Offset = "0x24")]
		private ProgressSaverViewMediator _progressSaverViewMediator;

		// Token: 0x04002F8A RID: 12170
		[Token(Token = "0x4002F8A")]
		[FieldOffset(Offset = "0x28")]
		private SettingsViewMediator _settingsViewMediator;

		// Token: 0x04002F8B RID: 12171
		[Token(Token = "0x4002F8B")]
		[FieldOffset(Offset = "0x2C")]
		private GameNotificationSettingsWindowMediator _notificationSettingsMediator;

		// Token: 0x04002F8C RID: 12172
		[Token(Token = "0x4002F8C")]
		[FieldOffset(Offset = "0x30")]
		private FeedbackFormViewMediator _feedbackFormViewMediator;

		// Token: 0x04002F8D RID: 12173
		[Token(Token = "0x4002F8D")]
		[FieldOffset(Offset = "0x34")]
		private ExternalLinksMediator _externalLinksMediator;

		// Token: 0x04002F8E RID: 12174
		[Token(Token = "0x4002F8E")]
		[FieldOffset(Offset = "0x38")]
		private ExternalLinksModel _externalLinksModel;

		// Token: 0x04002F8F RID: 12175
		[Token(Token = "0x4002F8F")]
		[FieldOffset(Offset = "0x3C")]
		private ExternalLinksEvents _externalLinksEvents;

		// Token: 0x04002F90 RID: 12176
		[Token(Token = "0x4002F90")]
		[FieldOffset(Offset = "0x40")]
		private readonly Dictionary<MenuWindow.MenuWindowArgs.SelectedTab, int> _tabsMap;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_View ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__get_View
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a63b49 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ProgressSaverModel__ProgressSaverEvents__ProgressSaverController__MenuView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ProgressSaverModel__ProgressSaverEvents__ProgressSaverController__MenuView__get_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_BaseProgressSaverEnterPointViewMediator_MenuView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_OptionsMenuButton___)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Func_OptionsMenuButton__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator_OnTabChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__set_View_b__14_0__
		              );
		    DAT_ram_00a63b49 = '\x01';
		  }
		  iVar2 = param1[5];
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(iVar2,0,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x28);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator_OnTabChanged__
		               ,0);
		    UI_Tabs_TabBar__add_ChangeEvent(uVar3,uVar1,0);
		  }
		  Gameplay_AccountLinker_ProgressSaver_Controller_BaseProgressSaverEnterPointViewMediator_object___ShowProgressSaverWindow
		            (param1,param2,
		             Method_Gameplay_AccountLinker_ProgressSaver_Controller_BaseProgressSaverEnterPointViewMediator_MenuView__set_View__
		            );
		  iVar2 = param1[5];
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(iVar2,0,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x28);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator_OnTabChanged__
		               ,0);
		    UI_Tabs_CategoryTabBarItemView___ctor(uVar3,uVar1,0);
		    if (param1[6] == 0) {
		      Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__set_View
		                (param1,param1);
		      return;
		    }
		    uVar3 = *(undefined4 *)(param1[2] + 0x14);
		    uVar1 = unnamed_function_1417(System_Func_OptionsMenuButton__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar1,param1,
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__set_View_b__14_0__
		               ,0);
		    uVar1 = System_Func_object__bool____ctor
		                      (uVar3,uVar1,Method_System_Linq_Enumerable_FirstOrDefault_OptionsMenuButton___
		                      );
		    Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__OnTabChanged
		              (param1,uVar1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63b4a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ProgressSaverModel__ProgressSaverEvents__ProgressSaverController__MenuView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_OptionsMenuButton___);
		    Mono_Security_ASN1__get_Item(&System_Func_OptionsMenuButton__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__OnTabChanged_b__15_0__
		              );
		    DAT_ram_00a63b4a = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x28),0);
		  if (*(int *)(iVar1 + 0x14) == 0) {
		    Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__ShowFeedbackForm
		              (param1,param1);
		    return;
		  }
		  param1_00 = *(undefined4 *)(param1[2] + 0x14);
		  uVar2 = unnamed_function_1417(System_Func_OptionsMenuButton__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,param1,
		             Method_Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__OnTabChanged_b__15_0__
		             ,0);
		  uVar2 = func_ii_7423(param1_00,uVar2,Method_System_Linq_Enumerable_First_OptionsMenuButton___);
		  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__OnTabChanged
		            (param1,uVar2,param1);
		  return;
		}
		*/

}
