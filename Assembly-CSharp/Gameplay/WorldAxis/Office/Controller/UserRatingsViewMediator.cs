using System;
using Gameplay.WorldAxis.Office.Events;
using Gameplay.WorldAxis.Office.Model;
using Gameplay.WorldAxis.Office.View.Ratings;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.WorldAxis.Office.Controller
{
	// Token: 0x020002E3 RID: 739
	[Token(Token = "0x20002E3")]
	public class UserRatingsViewMediator : AbstractViewMediator<RatingsModel, RatingsEvents, RatingsController, UserRatingsView>, IHideableMediator
	{
		// Token: 0x0600117C RID: 4476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600117C")]
		[Address(RVA = "0x6379", Offset = "0x6379", VA = "0x6379")]
		public UserRatingsViewMediator(RatingsModel model, RatingsEvents events, RatingsController controller)
		{
		/* --- GHIDRA: <UpdateList>b__12_1 ---
		void Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator___UpdateList_b__12_1
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58b68 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_WorldAxisOfficeModel__WorldAxisOfficeEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ColossusService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a58b68 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_WorldAxisOfficeModel__WorldAxisOfficeEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ColossusService___);
		  *(undefined4 *)(param1 + 0x18) = param4;
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: <UpdateList>b__12_0 ---
		undefined8
		Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator___UpdateList_b__12_0
		          (int param1,int param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined8 uVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a58b67 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_SortCategoryListElement_SortCategoryListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_long__TypeInfo);
		    DAT_ram_00a58b67 = '\x01';
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
		        goto code_r0x80f7c27e;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x80f7c27e:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,uVar3,puVar1[1]);
		  return uVar2;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a58b5f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingsModel__RatingsEvents__RatingsController__UserRatingsView__set_View__
		              );
		    DAT_ram_00a58b5f = '\x01';
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
		    Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000294 RID: 660
		// (set) Token: 0x0600117D RID: 4477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000294")]
		public override UserRatingsView View
		{
			[Token(Token = "0x600117D")]
			[Address(RVA = "0x637A", Offset = "0x637A", VA = "0x637A", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600117E")]
		[Address(RVA = "0x637B", Offset = "0x637B", VA = "0x637B")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  char cVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param2_00;
		  undefined4 *puVar4;
		  
		  if (DAT_ram_00a58b60 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingsModel__RatingsEvents__RatingsController__UserRatingsView__get_Model__
		              );
		    DAT_ram_00a58b60 = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_WorldAxis_Office_View_Ratings_UserRatingsView__get_NoRatingLabel
		            (uVar2,*(undefined4 *)(param1[2] + 0x18),0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(iVar3 + 0x10),
		             *(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x10) + 0x10) + 0x1c),0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar3 + 0x14);
		  iVar3 = *(int *)(*(int *)(param1[2] + 0x10) + 0x10);
		  if (DAT_ram_00a58ae8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17804);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17805);
		    DAT_ram_00a58ae8 = '\x01';
		  }
		  cVar1 = *(char *)(iVar3 + 0x20);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  puVar4 = &StringLiteral_17804;
		  if (cVar1 == '\0') {
		    puVar4 = &StringLiteral_17805;
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(*puVar4,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,param2_00,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_WorldAxis_Office_Controller_RatingsController__GetClansRatingsResultHandler(uVar2,param1)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x0600117F RID: 4479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600117F")]
		[Address(RVA = "0x637C", Offset = "0x637C", VA = "0x637C")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator__SetupView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58b61 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingsModel__RatingsEvents__RatingsController__UserRatingsView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator_InitEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator_UserRatingsRequestedEventHandler__
		              );
		    DAT_ram_00a58b61 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator_UserRatingsRequestedEventHandler__
		               ,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator_InitEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 8) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 8) = piVar4, *piVar4 != iVar1)) {
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator_UserRatingsRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator_InitEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 8) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 8) = piVar4, *piVar4 != iVar1)) {
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

		// Token: 0x17000295 RID: 661
		// (set) Token: 0x06001180 RID: 4480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000295")]
		public override RatingsEvents Events
		{
			[Token(Token = "0x6001180")]
			[Address(RVA = "0x637D", Offset = "0x637D", VA = "0x637D", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001181")]
		[Address(RVA = "0x637E", Offset = "0x637E", VA = "0x637E")]
		private void InitEventHandler()
		{
		/* --- GHIDRA: InitEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator__InitEventHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int iVar3;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a58b62 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingsModel__RatingsEvents__RatingsController__UserRatingsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_SortCategoryListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator_SortCategoryClickedEventHandler__
		              );
		    DAT_ram_00a58b62 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 8) + 0x18);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      iVar3 = *(int *)(iVar2 + iVar1 * 4 + 0x10);
		      param1_00 = unnamed_function_1417(System_Action_SortCategoryListElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (param1_00,param1,
		                 Method_Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator_SortCategoryClickedEventHandler__
		                 ,0);
		      *(undefined4 *)(iVar3 + 0x18) = param1_00;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001182 RID: 4482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001182")]
		[Address(RVA = "0x637F", Offset = "0x637F", VA = "0x637F")]
		private void InjectCategoriesCallback()
		{
		/* --- GHIDRA: InjectCategoriesCallback ---
		void Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator__InjectCategoriesCallback
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58b63 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58b63 = '\x01';
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
		  Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator__UserRatingsRequestedEventHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001183 RID: 4483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001183")]
		[Address(RVA = "0x6380", Offset = "0x6380", VA = "0x6380")]
		private void SortCategoryClickedEventHandler(SortCategoryListElement element)
		{
		/* --- GHIDRA: SortCategoryClickedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator__SortCategoryClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a58b64 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingsModel__RatingsEvents__RatingsController__UserRatingsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs__Init__
		              );
		    DAT_ram_00a58b64 = '\x01';
		  }
		  iVar2 = *(int *)(param1[2] + 0x34);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar2 != 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(iVar1 + 0x24),0,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_Elements_Buildings_SpellItemArgs___ctor
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1[2] + 0x34),
		               Method_UI_Elements_GenericList_GenericListElement_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs__Init__
		              );
		    Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator__UserRatingsRequestedEventHandler
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
		  Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator__UserRatingsRequestedEventHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001184 RID: 4484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001184")]
		[Address(RVA = "0x6381", Offset = "0x6381", VA = "0x6381")]
		private void UserRatingsRequestedEventHandler()
		{
		/* --- GHIDRA: UserRatingsRequestedEventHandler ---
		void Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator__UserRatingsRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a58b65 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingsModel__RatingsEvents__RatingsController__UserRatingsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_OrderByDescending_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs__long___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_OrderBy_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs__long___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs__long__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator__UpdateList_b__12_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator__UpdateList_b__12_1__
		              );
		    DAT_ram_00a58b65 = '\x01';
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
		      uVar4 = *(undefined4 *)(param1[2] + 0x2c);
		      uVar2 = unnamed_function_1417
		                        (
		                        System_Func_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs__long__TypeInfo
		                        );
		      System_Func_object__Int32Enum___Invoke
		                (uVar2,param1,
		                 Method_Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator__UpdateList_b__12_1__
		                 ,0);
		      uVar2 = System_Linq_Enumerable__OrderByDescending_KeyValuePair_object__object___uint_
		                        (uVar4,uVar2,
		                         Method_System_Linq_Enumerable_OrderByDescending_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs__long___
		                        );
		      uVar2 = func_ii_6295(uVar2,
		                           Method_System_Linq_Enumerable_ToArray_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs___
		                          );
		      Gameplay_WorldAxis_Office_View_Ratings_UserRatingsView__InitCategories(uVar1,uVar2,0);
		      return;
		    }
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = *(undefined4 *)(param1[2] + 0x2c);
		    uVar2 = unnamed_function_1417
		                      (
		                      System_Func_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs__long__TypeInfo
		                      );
		    System_Func_object__Int32Enum___Invoke
		              (uVar2,param1,
		               Method_Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator__UpdateList_b__12_0__
		               ,0);
		    uVar2 = System_Linq_Enumerable__OrderBy_MarkToMarkAdjustmentRecord__uint_
		                      (uVar4,uVar2,
		                       Method_System_Linq_Enumerable_OrderBy_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs__long___
		                      );
		    uVar2 = func_ii_6295(uVar2,
		                         Method_System_Linq_Enumerable_ToArray_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs___
		                        );
		    Gameplay_WorldAxis_Office_View_Ratings_UserRatingsView__InitCategories(uVar1,uVar2,0);
		    return;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_WorldAxis_Office_View_Ratings_UserRatingsView__InitCategories
		            (uVar1,*(undefined4 *)(param1[2] + 0x2c),0);
		  return;
		}
		*/

		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001185")]
		[Address(RVA = "0x6382", Offset = "0x6382", VA = "0x6382")]
		private void UpdateList()
		{
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001186")]
		[Address(RVA = "0x6383", Offset = "0x6383", VA = "0x6383", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		undefined8
		Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator__Hide
		          (int param1,int param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined8 uVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a58b66 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_SortCategoryListElement_SortCategoryListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_long__TypeInfo);
		    DAT_ram_00a58b66 = '\x01';
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
		        goto code_r0x80f7c1c0;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x80f7c1c0:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,uVar3,puVar1[1]);
		  return uVar2;
		}
		*/

		}

		// Token: 0x04000900 RID: 2304
		[Token(Token = "0x4000900")]
		[FieldOffset(Offset = "0x18")]
		private SortCategoryListElement _currentSortCategory;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/

}
