using System;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Gameplay.Competition.View;
using Il2CppDummyDll;
using MVC;
using UnityEngine.EventSystems;

namespace Gameplay.Competition.Control
{
	// Token: 0x02000904 RID: 2308
	[Token(Token = "0x2000904")]
	public class CompetitionEpViewMediator : AbstractCozyViewMediator<CompetitionModel, CompetitionEvents, CompetitionController, CompetitionEpView>
	{
		// Token: 0x06003639 RID: 13881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003639")]
		[Address(RVA = "0x8646", Offset = "0x8646", VA = "0x8646")]
		public CompetitionEpViewMediator(CompetitionModel model, CompetitionEvents events, CompetitionController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Competition_Control_CompetitionEpViewMediator___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a63ad5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CompetitionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_ChangedFromTo_OwnerRating__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionEpViewMediator_HandleActiveQuestsCountChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionEpViewMediator_HandleOwnerRatingChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionEpViewMediator_HandleQuestsChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionEpViewMediator_HandleStateChangedEvent__
		              );
		    DAT_ram_00a63ad5 = '\x01';
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_CompetitionData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Competition_Control_CompetitionEpViewMediator_HandleStateChangedEvent__
		             ,0);
		  iVar2 = func_ii_7048(uVar5,uVar1,0);
		  uVar1 = System_Action_CompetitionData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_CompetitionData__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x14) = iVar3;
		    uVar1 = System_Action_CompetitionData__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_CompetitionData__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x18);
		  uVar1 = unnamed_function_1417(Core_ChangedFromTo_OwnerRating__TypeInfo);
		  UnityEngine_UIElements_ChangeEvent___Il2CppFullySharedGenericType___set_previousValue
		            (uVar1,param1,
		             Method_Gameplay_Competition_Control_CompetitionEpViewMediator_HandleOwnerRatingChangedEvent__
		             ,0);
		  iVar2 = func_ii_7048(uVar5,uVar1,0);
		  uVar1 = Core_ChangedFromTo_OwnerRating__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x18) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,Core_ChangedFromTo_OwnerRating__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x18) = iVar3;
		    uVar1 = Core_ChangedFromTo_OwnerRating__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,Core_ChangedFromTo_OwnerRating__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Competition_Control_CompetitionEpViewMediator_HandleActiveQuestsCountChanged__
		             ,0);
		  piVar4 = (int *)func_ii_7048(uVar5,uVar1,0);
		  iVar2 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x24) = 0;
		  }
		  else if ((*piVar4 != System_Action_TypeInfo) ||
		          (*(int **)(param2 + 0x24) = piVar4, *piVar4 != iVar2)) {
		    System_Activator__CreateInstance(piVar4,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x20);
		  uVar1 = unnamed_function_1417(iVar2);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Competition_Control_CompetitionEpViewMediator_HandleQuestsChangedEvent__
		             ,0);
		  piVar4 = (int *)func_ii_7048(uVar5,uVar1,0);
		  iVar2 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x20) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar4) && (*(int **)(param2 + 0x20) = piVar4, *piVar4 == iVar2))
		  {
		    return;
		  }
		  System_Activator__CreateInstance(piVar4,iVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600363A RID: 13882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363A")]
		[Address(RVA = "0x8647", Offset = "0x8647", VA = "0x8647", Slot = "21")]
		protected override void ResetEvents(CompetitionEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_Competition_Control_CompetitionEpViewMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a63ad6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CompetitionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_ChangedFromTo_OwnerRating__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionEpViewMediator_HandleActiveQuestsCountChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionEpViewMediator_HandleOwnerRatingChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionEpViewMediator_HandleQuestsChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionEpViewMediator_HandleStateChangedEvent__
		              );
		    DAT_ram_00a63ad6 = '\x01';
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_CompetitionData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Competition_Control_CompetitionEpViewMediator_HandleStateChangedEvent__
		             ,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  uVar1 = System_Action_CompetitionData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_CompetitionData__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x14) = iVar3;
		    uVar1 = System_Action_CompetitionData__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_CompetitionData__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x18);
		  uVar1 = unnamed_function_1417(Core_ChangedFromTo_OwnerRating__TypeInfo);
		  UnityEngine_UIElements_ChangeEvent___Il2CppFullySharedGenericType___set_previousValue
		            (uVar1,param1,
		             Method_Gameplay_Competition_Control_CompetitionEpViewMediator_HandleOwnerRatingChangedEvent__
		             ,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  uVar1 = Core_ChangedFromTo_OwnerRating__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x18) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,Core_ChangedFromTo_OwnerRating__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x18) = iVar3;
		    uVar1 = Core_ChangedFromTo_OwnerRating__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,Core_ChangedFromTo_OwnerRating__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Competition_Control_CompetitionEpViewMediator_HandleActiveQuestsCountChanged__
		             ,0);
		  piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  iVar2 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x24) = 0;
		  }
		  else if ((*piVar4 != System_Action_TypeInfo) ||
		          (*(int **)(param2 + 0x24) = piVar4, *piVar4 != iVar2)) {
		    System_Activator__CreateInstance(piVar4,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x20);
		  uVar1 = unnamed_function_1417(iVar2);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Competition_Control_CompetitionEpViewMediator_HandleQuestsChangedEvent__
		             ,0);
		  piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  iVar2 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x20) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar4) && (*(int **)(param2 + 0x20) = piVar4, *piVar4 == iVar2))
		  {
		    return;
		  }
		  System_Activator__CreateInstance(piVar4,iVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600363B RID: 13883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363B")]
		[Address(RVA = "0x8648", Offset = "0x8648", VA = "0x8648", Slot = "22")]
		protected override void SetupEvents(CompetitionEvents events)
		{
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363C")]
		[Address(RVA = "0x8649", Offset = "0x8649", VA = "0x8649")]
		private void HandleQuestsChangedEvent()
		{
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363D")]
		[Address(RVA = "0x864A", Offset = "0x864A", VA = "0x864A")]
		private void HandleActiveQuestsCountChanged()
		{
		/* --- GHIDRA: HandleActiveQuestsCountChanged ---
		void Gameplay_Competition_Control_CompetitionEpViewMediator__HandleActiveQuestsCountChanged
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a63ad7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionEpView__get_Model__
		              );
		    DAT_ram_00a63ad7 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar1 != 0) {
		    param2_00 = Gameplay_Competition_Model_CompetitionModel__GetAvailSections(param1[2],param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Collections_Generic_Dictionary_int__object___get_Count
		              (*(undefined4 *)(iVar1 + 0x1c),param2_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600363E RID: 13886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363E")]
		[Address(RVA = "0x864B", Offset = "0x864B", VA = "0x864B")]
		private void TryShowNotification()
		{
		/* --- GHIDRA: TryShowNotification ---
		void Gameplay_Competition_Control_CompetitionEpViewMediator__TryShowNotification
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63ad8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Competition_Control_CompetitionEpViewMediator_HandleEpClickEvent__);
		    DAT_ram_00a63ad8 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param2 + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Competition_Control_CompetitionEpViewMediator_HandleEpClickEvent__,0);
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___get_Count(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600363F RID: 13887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363F")]
		[Address(RVA = "0x864C", Offset = "0x864C", VA = "0x864C", Slot = "23")]
		protected override void ResetView(CompetitionEpView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Competition_Control_CompetitionEpViewMediator__ResetView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63ad9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionEpView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Competition_Control_CompetitionEpViewMediator_HandleEpClickEvent__);
		    DAT_ram_00a63ad9 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param2 + 0x10);
		  uVar1 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Competition_Control_CompetitionEpViewMediator_HandleEpClickEvent__,0);
		  Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(uVar3,uVar1,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(*(int *)(param1[2] + 0x2c) != 0),0);
		  if (*(int *)(param1[2] + 0x2c) != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    local_8 = *(undefined8 *)(*(int *)(param1[2] + 0x30) + 0x10);
		    piVar4 = *(int **)(iVar2 + 0x18);
		    uVar1 = func_ii_8783(&local_8,0);
		    iVar2 = *piVar4;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		              (piVar4,uVar1,*(undefined4 *)(iVar2 + 0x2d4));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x14);
		    uVar1 = Core_Extensions_Dict_CompetitionDicExt__GetTitle
		                      (*(undefined4 *)(*(int *)(param1[2] + 0x2c) + 8),0);
		    AssetContent_GameImage__get_AssetId(uVar3,uVar1,0);
		    if (DAT_ram_00a63ad7 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionEpView__get_Model__
		                );
		      DAT_ram_00a63ad7 = '\x01';
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    if (iVar2 != 0) {
		      uVar1 = Gameplay_Competition_Model_CompetitionModel__GetAvailSections(param1[2],param1);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      System_Collections_Generic_Dictionary_int__object___get_Count
		                (*(undefined4 *)(iVar2 + 0x1c),uVar1,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003640 RID: 13888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003640")]
		[Address(RVA = "0x864D", Offset = "0x864D", VA = "0x864D", Slot = "24")]
		protected override void SetupView(CompetitionEpView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Competition_Control_CompetitionEpViewMediator__SetupView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63ada == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionEpView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Competition_View_CompetitionWindow_CompetitionWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_CompetitionWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12602);
		    DAT_ram_00a63ada = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1[2] + 0xc) + 0x1c);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Competition_View_CompetitionWindow_CompetitionWindowArgs_TypeInfo)
		  ;
		  Gameplay_Competition_View_CompetitionWindow___ctor(param1_00,param2_00,param1_00);
		  *(undefined4 *)(param1_00 + 0x10) = 10;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_01,StringLiteral_12602,param1_00,
		             Method_UI_Windows_PopupController_Show_CompetitionWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06003641 RID: 13889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003641")]
		[Address(RVA = "0x864E", Offset = "0x864E", VA = "0x864E")]
		private void HandleEpClickEvent(PointerEventData data)
		{
		/* --- GHIDRA: HandleEpClickEvent ---
		void Gameplay_Competition_Control_CompetitionEpViewMediator__HandleEpClickEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63adb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionEpView__get_Model__
		              );
		    DAT_ram_00a63adb = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(param2 != 0),0);
		  if (param2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar2 + 0x14);
		    uVar1 = Core_Extensions_Dict_CompetitionDicExt__GetTitle(*(undefined4 *)(param2 + 8),0);
		    AssetContent_GameImage__get_AssetId(param1_00,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    local_8 = *(undefined8 *)(*(int *)(param1[2] + 0x30) + 0x10);
		    piVar3 = *(int **)(iVar2 + 0x18);
		    uVar1 = func_ii_8783(&local_8,0);
		    iVar2 = *piVar3;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		              (piVar3,uVar1,*(undefined4 *)(iVar2 + 0x2d4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003642 RID: 13890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003642")]
		[Address(RVA = "0x864F", Offset = "0x864F", VA = "0x864F")]
		private void HandleStateChangedEvent(CompetitionData data)
		{
		/* --- GHIDRA: HandleStateChangedEvent ---
		void Gameplay_Competition_Control_CompetitionEpViewMediator__HandleStateChangedEvent
		               (int *param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined8 local_8;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  local_8 = *(undefined8 *)(param3 + 0x10);
		  piVar3 = *(int **)(iVar1 + 0x18);
		  uVar2 = func_ii_8783(&local_8,0);
		  iVar1 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar3,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06003643 RID: 13891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003643")]
		[Address(RVA = "0x8650", Offset = "0x8650", VA = "0x8650")]
		private void HandleOwnerRatingChangedEvent(OwnerRating from, OwnerRating to)
		{
		/* --- GHIDRA: HandleOwnerRatingChangedEvent ---
		void Gameplay_Competition_Control_CompetitionEpViewMediator__HandleOwnerRatingChangedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a63adc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionGetRatingView___ctor__
		              );
		    DAT_ram_00a63adc = '\x01';
		  }
		  MVC_AbstractController_object__object___set_Model
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractCozyViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionGetRatingView___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
