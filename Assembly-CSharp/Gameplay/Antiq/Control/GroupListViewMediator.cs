using System;
using System.Threading;
using Gameplay.Antiq.Model;
using Gameplay.Antiq.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Antiq.Control
{
	// Token: 0x02000D9A RID: 3482
	[Token(Token = "0x2000D9A")]
	internal class GroupListViewMediator : AbstractCozyViewMediator<AntiqModel, AntiqEvents, AntiqController, GroupListView>
	{
		// Token: 0x06005523 RID: 21795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005523")]
		[Address(RVA = "0xA2C6", Offset = "0xA2C6", VA = "0xA2C6", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Antiq_Control_GroupListViewMediator__Dispose
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a5880b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Control_GroupListViewMediator_HandleInitEvent__);
		    DAT_ram_00a5880b = '\x01';
		  }
		  param1_02 = *(undefined4 *)(param2 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Gameplay_Antiq_Control_GroupListViewMediator_HandleInitEvent__,
		             0);
		  param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		  param2_00 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(param2 + 8) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *param1_01) &&
		     (*(int **)(param2 + 8) = param1_01, *param1_01 == param2_00)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005524 RID: 21796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005524")]
		[Address(RVA = "0x1E5E", Offset = "0x1E5E", VA = "0x1E5E")]
		public GroupListViewMediator(GroupListView view, AntiqModel model, AntiqEvents events, AntiqController controller)
		{
		}

		// Token: 0x06005525 RID: 21797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005525")]
		[Address(RVA = "0xA2C7", Offset = "0xA2C7", VA = "0xA2C7", Slot = "21")]
		protected override void ResetEvents(AntiqEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_Antiq_Control_GroupListViewMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a5880c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Control_GroupListViewMediator_HandleInitEvent__);
		    DAT_ram_00a5880c = '\x01';
		  }
		  param1_02 = *(undefined4 *)(param2 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Gameplay_Antiq_Control_GroupListViewMediator_HandleInitEvent__,
		             0);
		  param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_02,param1_00,0);
		  param2_00 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(param2 + 8) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *param1_01) &&
		     (*(int **)(param2 + 8) = param1_01, *param1_01 == param2_00)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005526 RID: 21798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005526")]
		[Address(RVA = "0xA2C8", Offset = "0xA2C8", VA = "0xA2C8", Slot = "22")]
		protected override void SetupEvents(AntiqEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_Antiq_Control_GroupListViewMediator__SetupEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a5880d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_GroupData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Control_GroupListViewMediator_HandleListSelectEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Control_GroupListViewMediator_HandleSearchInputChangedEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Control_GroupListViewMediator_HandleTabChangeEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Control_GroupListViewMediator_HandleToggleChangeEvent__);
		    Mono_Security_ASN1__get_Item(&UI_Toggle_IToggleControl_TypeInfo);
		    DAT_ram_00a5880d = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_string__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Antiq_Control_GroupListViewMediator_HandleSearchInputChangedEvent__,0);
		  UI_SearchInput__add_InputChangedEvent(uVar4,uVar2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Antiq_Control_GroupListViewMediator_HandleToggleChangeEvent__,0);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (UI_Toggle_IToggleControl_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x80f2f4f3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,UI_Toggle_IToggleControl_TypeInfo,1);
		code_r0x80f2f4f3:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar2,puVar3[1]);
		  uVar4 = *(undefined4 *)(param2 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Gameplay_Antiq_Control_GroupListViewMediator_HandleTabChangeEvent__
		             ,0);
		  UI_Tabs_TabBar__add_ChangeEvent(uVar4,uVar2,0);
		  uVar4 = *(undefined4 *)(param2 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_GroupData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Antiq_Control_GroupListViewMediator_HandleListSelectEvent__,0);
		  Gameplay_Antiq_View_Grid_GridList__add_SelectEvent(uVar4,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06005527 RID: 21799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005527")]
		[Address(RVA = "0xA2C9", Offset = "0xA2C9", VA = "0xA2C9", Slot = "23")]
		protected override void ResetView(GroupListView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Antiq_Control_GroupListViewMediator__ResetView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  undefined4 *puVar5;
		  int param2_00;
		  int iVar6;
		  
		  if (DAT_ram_00a5880e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AntiqModel__AntiqEvents__AntiqController__GroupListView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_GroupData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_CategoryData__TabBarItemData_CategoryData____);
		    Mono_Security_ASN1__get_Item(&System_Func_CategoryData__TabBarItemData_CategoryData___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Control_GroupListViewMediator_HandleListSelectEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Control_GroupListViewMediator_HandleSearchInputChangedEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Control_GroupListViewMediator_HandleTabChangeEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Control_GroupListViewMediator_HandleToggleChangeEvent__);
		    Mono_Security_ASN1__get_Item(&UI_Toggle_IToggleControl_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBar_GetItem_CategoryData___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Antiq_Control_GroupListViewMediator___c__SetupView_b__6_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Antiq_Control_GroupListViewMediator___c_TypeInfo);
		    DAT_ram_00a5880e = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_string__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Antiq_Control_GroupListViewMediator_HandleSearchInputChangedEvent__,0);
		  UI_NumbersInput___ctor(uVar4,uVar2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Antiq_Control_GroupListViewMediator_HandleToggleChangeEvent__,0);
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (UI_Toggle_IToggleControl_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f2f6ab;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,UI_Toggle_IToggleControl_TypeInfo,0);
		code_r0x80f2f6ab:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar2,puVar3[1]);
		  uVar4 = *(undefined4 *)(param2 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Gameplay_Antiq_Control_GroupListViewMediator_HandleTabChangeEvent__
		             ,0);
		  UI_Tabs_CategoryTabBarItemView___ctor(uVar4,uVar2,0);
		  uVar4 = *(undefined4 *)(param2 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_GroupData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Antiq_Control_GroupListViewMediator_HandleListSelectEvent__,0);
		  Gameplay_Antiq_View_Grid_CellHolder___ctor(uVar4,uVar2,0);
		  uVar2 = Gameplay_Antiq_Model_AntiqModel__GetIsArtifactsScrollEnabled(param1[2],0);
		  if (*(int *)(Gameplay_Antiq_Control_GroupListViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Antiq_Control_GroupListViewMediator___c_TypeInfo);
		  }
		  puVar5 = *(undefined4 **)(Gameplay_Antiq_Control_GroupListViewMediator___c_TypeInfo + 0x5c);
		  iVar6 = puVar5[1];
		  if (iVar6 == 0) {
		    if (*(int *)(Gameplay_Antiq_Control_GroupListViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Antiq_Control_GroupListViewMediator___c_TypeInfo);
		      puVar5 = *(undefined4 **)(Gameplay_Antiq_Control_GroupListViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar5;
		    iVar6 = unnamed_function_1417(System_Func_CategoryData__TabBarItemData_CategoryData___TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar6,uVar4,
		               Method_Gameplay_Antiq_Control_GroupListViewMediator___c__SetupView_b__6_0__,0);
		    *(int *)(*(int *)(Gameplay_Antiq_Control_GroupListViewMediator___c_TypeInfo + 0x5c) + 4) = iVar6
		    ;
		  }
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar2,iVar6,
		                     Method_System_Linq_Enumerable_Select_CategoryData__TabBarItemData_CategoryData____
		                    );
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Tabs_TabBar__HandleSelected(*(undefined4 *)(iVar6 + 0x10),uVar2,0);
		  param2_00 = *param1;
		  iVar6 = (**(code **)((ulonglong)*(uint *)(param2_00 + 0x148) * 4))
		                    (param1,*(undefined4 *)(param2_00 + 0x14c));
		  if (*(char *)(iVar6 + 9) != '\0') {
		    Gameplay_Antiq_Control_GroupListViewMediator__HandleListSelectEvent(param1,param2_00);
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x10);
		  uVar2 = UI_Tabs_TabBar__GetItem_ByteEnum_
		                    (uVar4,*(undefined4 *)(*(int *)(param1[2] + 0x18) + 0xc),
		                     Method_UI_Tabs_TabBar_GetItem_CategoryData___);
		  UI_Tabs_TabBar__Init(uVar4,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06005528 RID: 21800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005528")]
		[Address(RVA = "0xA2CA", Offset = "0xA2CA", VA = "0xA2CA", Slot = "24")]
		protected override void SetupView(GroupListView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Antiq_Control_GroupListViewMediator__SetupView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5880f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AntiqModel__AntiqEvents__AntiqController__GroupListView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_GroupReviewWindow___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Antiq_View_GroupReviewWindow_WindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12560);
		    DAT_ram_00a5880f = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___UserEquipmentViewMediator__ShowAntiqGroupReview_d__13_
		            (uVar1,param2,param1);
		  param1_01 = *(undefined4 *)(param1[2] + 0x20);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_00 = unnamed_function_1417(Gameplay_Antiq_View_GroupReviewWindow_WindowArgs_TypeInfo);
		  Core_Browser_BrowserWindow___ctor(param1_00,uVar1,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_01,StringLiteral_12560,param1_00,
		             Method_UI_Windows_PopupController_Show_GroupReviewWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06005529 RID: 21801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005529")]
		[Address(RVA = "0xA2CB", Offset = "0xA2CB", VA = "0xA2CB")]
		private void HandleListSelectEvent(GroupData data)
		{
		/* --- GHIDRA: HandleListSelectEvent ---
		void Gameplay_Antiq_Control_GroupListViewMediator__HandleListSelectEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58810 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AntiqModel__AntiqEvents__AntiqController__GroupListView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_28672);
		    DAT_ram_00a58810 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x18);
		  uVar2 = System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___GroupListViewMediator__HandleSearchInputChangedEvent_d__9_
		                    (*(undefined4 *)(param1[2] + 0x18),*(undefined4 *)(param1[2] + 0x24),&local_4,
		                     &local_8,0);
		  Gameplay_Antiq_Model_Filter__Apply(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x14);
		  local_c = local_4;
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_c);
		  local_10 = local_8;
		  uVar3 = func_ii_1081(DAT_ram_00a66954,&local_10);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28672,uVar2,uVar3,0);
		  Gameplay_Antiq_View_Grid_GridList__SetData(param1_00,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600552A RID: 21802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600552A")]
		[Address(RVA = "0xA2CC", Offset = "0xA2CC", VA = "0xA2CC")]
		private void HandleInitEvent()
		{
		/* --- GHIDRA: HandleInitEvent ---
		void Gameplay_Antiq_Control_GroupListViewMediator__HandleInitEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined8 local_14;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58811 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_GroupListViewMediator__HandleSearchInputChangedEvent_d__9___
		              );
		    DAT_ram_00a58811 = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_30,0);
		  local_14 = local_28;
		  local_20 = 0xffffffff;
		  local_1c = local_30;
		  local_c = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_GooglePurchaseUpdatedListener__HandleUserCancelledPurchaseFailure_d__14_
		            (&local_1c,&local_20,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_GroupListViewMediator__HandleSearchInputChangedEvent_d__9___
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600552B RID: 21803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600552B")]
		[Address(RVA = "0xA2CD", Offset = "0xA2CD", VA = "0xA2CD")]
		private void HandleSearchInputChangedEvent(string value)
		{
		/* --- GHIDRA: HandleSearchInputChangedEvent ---
		void Gameplay_Antiq_Control_GroupListViewMediator__HandleSearchInputChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined1 uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  undefined4 uVar8;
		  undefined4 param1_00;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58812 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AntiqModel__AntiqEvents__AntiqController__GroupListView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&UI_Toggle_IToggleControl_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28672);
		    DAT_ram_00a58812 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  iVar6 = *(int *)(param1[2] + 0x18);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar7 = *(int **)(iVar3 + 0x20);
		  iVar3 = *piVar7;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (UI_Toggle_IToggleControl_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80f2fb0d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,UI_Toggle_IToggleControl_TypeInfo,2);
		code_r0x80f2fb0d:
		  uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  *(undefined1 *)(iVar6 + 0x10) = uVar2;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar8 = *(undefined4 *)(iVar3 + 0x14);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = 0;
		  piVar7 = *(int **)(iVar3 + 0x20);
		  iVar3 = *piVar7;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (UI_Toggle_IToggleControl_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80f2fbc8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,UI_Toggle_IToggleControl_TypeInfo,2);
		code_r0x80f2fbc8:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  UI_CounterBacklight__get_IsEnabled(uVar8,uVar5,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(iVar3 + 0x18);
		  uVar8 = System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___GroupListViewMediator__HandleSearchInputChangedEvent_d__9_
		                    (*(undefined4 *)(param1[2] + 0x18),*(undefined4 *)(param1[2] + 0x24),&local_4,
		                     &local_8,0);
		  Gameplay_Antiq_Model_Filter__Apply(uVar5,uVar8,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar3 + 0x14);
		  local_c = local_4;
		  uVar8 = func_ii_1081(DAT_ram_00a66954,&local_c);
		  local_10 = local_8;
		  uVar5 = func_ii_1081(DAT_ram_00a66954,&local_10);
		  uVar8 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28672,uVar8,uVar5,0);
		  Gameplay_Antiq_View_Grid_GridList__SetData(param1_00,uVar8,0);
		  return;
		}
		*/

		}

		// Token: 0x0600552C RID: 21804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600552C")]
		[Address(RVA = "0xA2CE", Offset = "0xA2CE", VA = "0xA2CE")]
		private void HandleToggleChangeEvent()
		{
		/* --- GHIDRA: HandleToggleChangeEvent ---
		void Gameplay_Antiq_Control_GroupListViewMediator__HandleToggleChangeEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58813 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AntiqModel__AntiqEvents__AntiqController__GroupListView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_CategoryData__get_Data__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBar_GetSelectedItem_CategoryData___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28672);
		    DAT_ram_00a58813 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  iVar3 = *(int *)(param1[2] + 0x18);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UI_Tabs_TabBar__GetSelectedItem_UInt32Enum_
		                    (*(undefined4 *)(iVar1 + 0x10),
		                     Method_UI_Tabs_TabBar_GetSelectedItem_CategoryData___);
		  *(undefined4 *)(iVar3 + 0xc) = *(undefined4 *)(iVar1 + 0x20);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar1 + 0x18);
		  uVar2 = System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___GroupListViewMediator__HandleSearchInputChangedEvent_d__9_
		                    (*(undefined4 *)(param1[2] + 0x18),*(undefined4 *)(param1[2] + 0x24),&local_4,
		                     &local_8,0);
		  Gameplay_Antiq_Model_Filter__Apply(uVar4,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x14);
		  local_c = local_4;
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_c);
		  local_10 = local_8;
		  uVar4 = func_ii_1081(DAT_ram_00a66954,&local_10);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28672,uVar2,uVar4,0);
		  Gameplay_Antiq_View_Grid_GridList__SetData(param1_00,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600552D RID: 21805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600552D")]
		[Address(RVA = "0xA2CF", Offset = "0xA2CF", VA = "0xA2CF")]
		private void HandleTabChangeEvent()
		{
		/* --- GHIDRA: HandleTabChangeEvent ---
		void Gameplay_Antiq_Control_GroupListViewMediator__HandleTabChangeEvent(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58814 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Antiq_Control_GroupListViewMediator___c_TypeInfo);
		    DAT_ram_00a58814 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Antiq_Control_GroupListViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Antiq_Control_GroupListViewMediator___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04002E20 RID: 11808
		[Token(Token = "0x4002E20")]
		[FieldOffset(Offset = "0x18")]
		private readonly CancellationTokenSource _cancellationTokenSource;
	}
}
