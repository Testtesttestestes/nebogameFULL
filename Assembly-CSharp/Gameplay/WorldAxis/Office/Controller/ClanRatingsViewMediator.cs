using System;
using Gameplay.WorldAxis.Office.Events;
using Gameplay.WorldAxis.Office.Model;
using Gameplay.WorldAxis.Office.View.Ratings;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.WorldAxis.Office.Controller
{
	// Token: 0x020002DC RID: 732
	[Token(Token = "0x20002DC")]
	public class ClanRatingsViewMediator : AbstractViewMediator<RatingsModel, RatingsEvents, RatingsController, ClanRatingsView>, IHideableMediator
	{
		// Token: 0x06001135 RID: 4405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001135")]
		[Address(RVA = "0x6332", Offset = "0x6332", VA = "0x6332")]
		public ClanRatingsViewMediator(RatingsModel model, RatingsEvents events, RatingsController controller)
		{
		/* --- GHIDRA: <UpdateList>b__13_1 ---
		void Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator___UpdateList_b__13_1
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58b35 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__FrontPageView___ctor__
		              );
		    DAT_ram_00a58b35 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_WorldAxisOfficeModel__WorldAxisOfficeEvents__WorldAxisOfficeController__FrontPageView___ctor__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: <UpdateList>b__13_0 ---
		undefined8
		Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator___UpdateList_b__13_0
		          (int param1,int param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined8 uVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a58b34 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_SortCategoryListElement_SortCategoryListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_long__TypeInfo);
		    DAT_ram_00a58b34 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x18) + 0x18) + 8);
		  param1_00 = *(int **)(param2 + 0x10);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar5 = 0;
		    do {
		      if (System_Collections_Generic_IList_long__TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar1 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f79269;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x80f79269:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,uVar3,puVar1[1]);
		  return uVar2;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a58b2a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingsModel__RatingsEvents__RatingsController__ClanRatingsView__set_View__
		              );
		    DAT_ram_00a58b2a = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700028C RID: 652
		// (set) Token: 0x06001136 RID: 4406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028C")]
		public override ClanRatingsView View
		{
			[Token(Token = "0x6001136")]
			[Address(RVA = "0x6333", Offset = "0x6333", VA = "0x6333", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001137")]
		[Address(RVA = "0x6334", Offset = "0x6334", VA = "0x6334")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  char cVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  int iVar4;
		  int iVar5;
		  undefined4 *puVar6;
		  
		  if (DAT_ram_00a58b2b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingsModel__RatingsEvents__RatingsController__ClanRatingsView__get_Model__
		              );
		    DAT_ram_00a58b2b = '\x01';
		  }
		  if (DAT_ram_00a58b2d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingsModel__RatingsEvents__RatingsController__ClanRatingsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_SortCategoryListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator_SortCategoryClickedEventHandler__
		              );
		    DAT_ram_00a58b2d = '\x01';
		  }
		  iVar4 = *(int *)(param1[2] + 0x14);
		  if (0 < *(int *)(iVar4 + 0xc)) {
		    iVar2 = 0;
		    do {
		      iVar5 = *(int *)(iVar4 + iVar2 * 4 + 0x10);
		      uVar3 = unnamed_function_1417(System_Action_SortCategoryListElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar3,param1,
		                 Method_Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator_SortCategoryClickedEventHandler__
		                 ,0);
		      *(undefined4 *)(iVar5 + 0x18) = uVar3;
		      iVar2 = iVar2 + 1;
		    } while (iVar2 < *(int *)(iVar4 + 0xc));
		  }
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar3,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,1,0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_WorldAxis_Office_View_Ratings_UserRatingsView__get_NoRatingLabel
		            (uVar3,*(undefined4 *)(param1[2] + 0x14),0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(iVar4 + 0x10),
		             *(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x10) + 0x10) + 0x1c),0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar4 + 0x14);
		  iVar4 = *(int *)(*(int *)(param1[2] + 0x10) + 0x10);
		  if (DAT_ram_00a58ae8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17804);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17805);
		    DAT_ram_00a58ae8 = '\x01';
		  }
		  cVar1 = *(char *)(iVar4 + 0x20);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  puVar6 = &StringLiteral_17804;
		  if (cVar1 == '\0') {
		    puVar6 = &StringLiteral_17805;
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(*puVar6,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,param2_00,0);
		  iVar4 = *param1;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x148) * 4))
		                    (param1,*(undefined4 *)(iVar4 + 0x14c));
		  Gameplay_WorldAxis_Office_Controller_RatingsController___ctor(uVar3,iVar4);
		  return;
		}
		*/

		}

		// Token: 0x06001138 RID: 4408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001138")]
		[Address(RVA = "0x6335", Offset = "0x6335", VA = "0x6335")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator__SetupView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58b2c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingsModel__RatingsEvents__RatingsController__ClanRatingsView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator_ClanRatingsRequestedEventHandler__
		              );
		    DAT_ram_00a58b2c = '\x01';
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
		               Method_Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator_ClanRatingsRequestedEventHandler__
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
		               Method_Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator_ClanRatingsRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1))
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

		}

		// Token: 0x1700028D RID: 653
		// (set) Token: 0x06001139 RID: 4409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028D")]
		public override RatingsEvents Events
		{
			[Token(Token = "0x6001139")]
			[Address(RVA = "0x6336", Offset = "0x6336", VA = "0x6336", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600113A")]
		[Address(RVA = "0x6337", Offset = "0x6337", VA = "0x6337")]
		private void InjectCategoriesCallback()
		{
		/* --- GHIDRA: InjectCategoriesCallback ---
		void Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator__InjectCategoriesCallback
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58b2e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingsModel__RatingsEvents__RatingsController__ClanRatingsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ClanSeasonRatingsListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator_ClanListElementClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__GetEnumerator__
		              );
		    DAT_ram_00a58b2e = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(*(int *)(param1 + 8) + 0x28),
		             Method_System_Collections_Generic_List_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f78c4a:
		      iVar1 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar2) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar2 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          if (iVar2 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x246,&local_18);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        import::env::__resumeException(uVar3);
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
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar1 = local_8._4_4_;
		    uVar3 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_ClanSeasonRatingsListElement__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f78c38:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f78c4a;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar3,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator_ClanListElementClickedEventHandler__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f78c38;
		    *(undefined4 *)(iVar1 + 0x20) = uVar3;
		  } while( true );
		}
		*/

		}

		// Token: 0x0600113B RID: 4411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600113B")]
		[Address(RVA = "0x6338", Offset = "0x6338", VA = "0x6338")]
		private void InjectCallback()
		{
		/* --- GHIDRA: InjectCallback ---
		void Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator__InjectCallback
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a58b2f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58b2f = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x230);
		        goto code_r0x80f78ddf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f78ddf:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_ClansManager__OpenClanTreasury
		            (param1_00,*(undefined4 *)(*(int *)(param2 + 0x18) + 0x14),0);
		  return;
		}
		*/

		}

		// Token: 0x0600113C RID: 4412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600113C")]
		[Address(RVA = "0x6339", Offset = "0x6339", VA = "0x6339")]
		private void ClanListElementClickedEventHandler(ClanSeasonRatingsListElement element)
		{
		/* --- GHIDRA: ClanListElementClickedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator__ClanListElementClickedEventHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58b30 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58b30 = '\x01';
		  }
		  Gameplay_WorldAxis_Office_View_Ratings_SortCategoryListElement__SetOrder(param2,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 != 0) {
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,param2,0);
		    if (iVar1 != 0) {
		      Gameplay_WorldAxis_Office_View_Ratings_SortCategoryListElement__set_Order
		                (*(undefined4 *)(param1 + 0x18),0,0);
		    }
		  }
		  *(undefined4 *)(param1 + 0x18) = param2;
		  Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator__ClanRatingsRequestedEventHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600113D RID: 4413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600113D")]
		[Address(RVA = "0x633A", Offset = "0x633A", VA = "0x633A")]
		private void SortCategoryClickedEventHandler(SortCategoryListElement element)
		{
		/* --- GHIDRA: SortCategoryClickedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator__SortCategoryClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a58b31 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingsModel__RatingsEvents__RatingsController__ClanRatingsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__Init__
		              );
		    DAT_ram_00a58b31 = '\x01';
		  }
		  Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator__InjectCategoriesCallback
		            (param1,param1);
		  iVar2 = *(int *)(param1[2] + 0x30);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar2 != 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(iVar1 + 0x24),0,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_Elements_Buildings_SpellItemArgs___ctor
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1[2] + 0x30),
		               Method_UI_Elements_GenericList_GenericListElement_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__Init__
		              );
		    Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator__ClanRatingsRequestedEventHandler
		              (param1,param1);
		    return;
		  }
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(iVar1 + 0x24),1,0);
		  Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator__ClanRatingsRequestedEventHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600113E RID: 4414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600113E")]
		[Address(RVA = "0x633B", Offset = "0x633B", VA = "0x633B")]
		private void ClanRatingsRequestedEventHandler()
		{
		/* --- GHIDRA: ClanRatingsRequestedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator__ClanRatingsRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a58b32 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingsModel__RatingsEvents__RatingsController__ClanRatingsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator__UpdateList_b__13_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator__UpdateList_b__13_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_OrderByDescending_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__long___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_OrderBy_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__long___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__long__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58b32 = '\x01';
		  }
		  iVar3 = param1[6];
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar3 = func_ii_3812(iVar3,0,0);
		  if ((iVar3 == 0) && (*(char *)(param1[6] + 0x2c) != '\0')) {
		    if (*(char *)(param1[6] + 0x2c) != '\x01') {
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar4 = *(undefined4 *)(param1[2] + 0x28);
		      uVar2 = unnamed_function_1417
		                        (
		                        System_Func_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__long__TypeInfo
		                        );
		      System_Func_object__Int32Enum___Invoke
		                (uVar2,param1,
		                 Method_Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator__UpdateList_b__13_1__
		                 ,0);
		      uVar2 = System_Linq_Enumerable__OrderByDescending_KeyValuePair_object__object___uint_
		                        (uVar4,uVar2,
		                         Method_System_Linq_Enumerable_OrderByDescending_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__long___
		                        );
		      uVar2 = func_ii_6295(uVar2,
		                           Method_System_Linq_Enumerable_ToArray_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs___
		                          );
		      Gameplay_WorldAxis_Office_View_Ratings_ClanRatingsView__InitCategories(uVar1,uVar2,0);
		      return;
		    }
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = *(undefined4 *)(param1[2] + 0x28);
		    uVar2 = unnamed_function_1417
		                      (
		                      System_Func_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__long__TypeInfo
		                      );
		    System_Func_object__Int32Enum___Invoke
		              (uVar2,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator__UpdateList_b__13_0__
		               ,0);
		    uVar2 = System_Linq_Enumerable__OrderBy_MarkToMarkAdjustmentRecord__uint_
		                      (uVar4,uVar2,
		                       Method_System_Linq_Enumerable_OrderBy_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__long___
		                      );
		    uVar2 = func_ii_6295(uVar2,
		                         Method_System_Linq_Enumerable_ToArray_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs___
		                        );
		    Gameplay_WorldAxis_Office_View_Ratings_ClanRatingsView__InitCategories(uVar1,uVar2,0);
		    return;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_WorldAxis_Office_View_Ratings_ClanRatingsView__InitCategories
		            (uVar1,*(undefined4 *)(param1[2] + 0x28),0);
		  return;
		}
		*/

		}

		// Token: 0x0600113F RID: 4415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600113F")]
		[Address(RVA = "0x633C", Offset = "0x633C", VA = "0x633C")]
		private void UpdateList()
		{
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001140")]
		[Address(RVA = "0x633D", Offset = "0x633D", VA = "0x633D", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		undefined8
		Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator__Hide
		          (int param1,int param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined8 uVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a58b33 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_SortCategoryListElement_SortCategoryListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_long__TypeInfo);
		    DAT_ram_00a58b33 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x18) + 0x18) + 8);
		  param1_00 = *(int **)(param2 + 0x10);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar5 = 0;
		    do {
		      if (System_Collections_Generic_IList_long__TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar1 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f791ab;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x80f791ab:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,uVar3,puVar1[1]);
		  return uVar2;
		}
		*/

		}

		// Token: 0x040008F8 RID: 2296
		[Token(Token = "0x40008F8")]
		[FieldOffset(Offset = "0x18")]
		private SortCategoryListElement _currentSortCategory;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator__set_Events
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int iVar3;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a58b2d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingsModel__RatingsEvents__RatingsController__ClanRatingsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_SortCategoryListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator_SortCategoryClickedEventHandler__
		              );
		    DAT_ram_00a58b2d = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 8) + 0x14);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      iVar3 = *(int *)(iVar2 + iVar1 * 4 + 0x10);
		      param1_00 = unnamed_function_1417(System_Action_SortCategoryListElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (param1_00,param1,
		                 Method_Gameplay_WorldAxis_Office_Controller_ClanRatingsViewMediator_SortCategoryClickedEventHandler__
		                 ,0);
		      *(undefined4 *)(iVar3 + 0x18) = param1_00;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

}
