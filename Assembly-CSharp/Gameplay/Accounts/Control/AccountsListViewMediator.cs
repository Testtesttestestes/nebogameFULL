using System;
using System.Collections.Generic;
using Gameplay.Accounts.Model;
using Gameplay.Accounts.Model.Data;
using Gameplay.Accounts.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using UnityEngine.EventSystems;

namespace Gameplay.Accounts.Control
{
	// Token: 0x02000DE9 RID: 3561
	[Token(Token = "0x2000DE9")]
	public class AccountsListViewMediator : AbstractCozyViewMediator<AccountsModel, AccountsEvents, AccountsController, AccountsListView>
	{
		// Token: 0x060056EC RID: 22252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056EC")]
		[Address(RVA = "0xA469", Offset = "0xA469", VA = "0xA469")]
		public AccountsListViewMediator(AccountsListView view, AccountsModel model, AccountsEvents events, AccountsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Accounts_Control_AccountsListViewMediator___ctor
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a588e3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Control_AccountsListViewMediator_AccountStickerChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Control_AccountsListViewMediator_HandleAccountChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Control_AccountsListViewMediator_HandlePromotionUpdateCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IList_IAccountDataDecorator___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IAccountDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a588e3 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Accounts_Control_AccountsListViewMediator_HandlePromotionUpdateCompleteEvent__
		             ,0);
		  param1_00 = (int *)func_ii_7048(uVar5,uVar2,0);
		  iVar3 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0x1c) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_00) ||
		          (*(int **)(iVar1 + 0x1c) = param1_00, *param1_00 != iVar3)) {
		    System_Activator__CreateInstance(param1_00,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar3 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_IAccountDataDecorator__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Accounts_Control_AccountsListViewMediator_HandleAccountChangedEvent__,0
		            );
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_IAccountDataDecorator__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar3 + 0x14) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar1,System_Action_IAccountDataDecorator__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar3 + 0x14) = iVar4;
		    uVar2 = System_Action_IAccountDataDecorator__TypeInfo;
		    iVar3 = func_ii_1082(iVar1,System_Action_IAccountDataDecorator__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar3 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_IList_IAccountDataDecorator___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Accounts_Control_AccountsListViewMediator_AccountStickerChangedEvent__,
		             0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_IList_IAccountDataDecorator___TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar3 + 0x18) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar1,System_Action_IList_IAccountDataDecorator___TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar3 + 0x18) = iVar4;
		    uVar2 = System_Action_IList_IAccountDataDecorator___TypeInfo;
		    iVar3 = func_ii_1082(iVar1,System_Action_IList_IAccountDataDecorator___TypeInfo);
		    if (iVar3 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060056ED RID: 22253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056ED")]
		[Address(RVA = "0xA46A", Offset = "0xA46A", VA = "0xA46A", Slot = "21")]
		protected override void ResetEvents(AccountsEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_Accounts_Control_AccountsListViewMediator__ResetEvents
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a588e4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Control_AccountsListViewMediator_AccountStickerChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Control_AccountsListViewMediator_HandleAccountChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Control_AccountsListViewMediator_HandlePromotionUpdateCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IList_IAccountDataDecorator___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IAccountDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a588e4 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Accounts_Control_AccountsListViewMediator_HandlePromotionUpdateCompleteEvent__
		             ,0);
		  param1_00 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  iVar3 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0x1c) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_00) ||
		          (*(int **)(iVar1 + 0x1c) = param1_00, *param1_00 != iVar3)) {
		    System_Activator__CreateInstance(param1_00,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar3 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_IAccountDataDecorator__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Accounts_Control_AccountsListViewMediator_HandleAccountChangedEvent__,0
		            );
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_IAccountDataDecorator__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar3 + 0x14) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar1,System_Action_IAccountDataDecorator__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar3 + 0x14) = iVar4;
		    uVar2 = System_Action_IAccountDataDecorator__TypeInfo;
		    iVar3 = func_ii_1082(iVar1,System_Action_IAccountDataDecorator__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar3 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_IList_IAccountDataDecorator___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Accounts_Control_AccountsListViewMediator_AccountStickerChangedEvent__,
		             0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_IList_IAccountDataDecorator___TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar3 + 0x18) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar1,System_Action_IList_IAccountDataDecorator___TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar3 + 0x18) = iVar4;
		    uVar2 = System_Action_IList_IAccountDataDecorator___TypeInfo;
		    iVar3 = func_ii_1082(iVar1,System_Action_IList_IAccountDataDecorator___TypeInfo);
		    if (iVar3 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060056EE RID: 22254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056EE")]
		[Address(RVA = "0xA46B", Offset = "0xA46B", VA = "0xA46B", Slot = "22")]
		protected override void SetupEvents(AccountsEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_Accounts_Control_AccountsListViewMediator__SetupEvents
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int param1_01;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a588e5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_Control_AccountsListViewMediator_HandleItemClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Control_AccountsListViewMediator_HandlePromotionClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Control_AccountsListViewMediator_HandlePromotionInfoButtonClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IAccountDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_PromotionsDic__TypeInfo);
		    DAT_ram_00a588e5 = '\x01';
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = unnamed_function_1417(System_Action_IAccountDataDecorator__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Accounts_Control_AccountsListViewMediator_HandleItemClickEvent__,0);
		  if (DAT_ram_00a5888e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAccountDataDecorator__TypeInfo);
		    DAT_ram_00a5888e = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,uVar4,0);
		    uVar5 = System_Action_IAccountDataDecorator__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAccountDataDecorator__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(iVar3 + 0x28,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar5 = *(undefined4 *)(iVar3 + 0x1c);
		      uVar4 = unnamed_function_1417(System_Action_PromotionsDic__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar4,param1,
		                 Method_Gameplay_Accounts_Control_AccountsListViewMediator_HandlePromotionInfoButtonClickedEvent__
		                 ,0);
		      Gameplay_Bank_View_BankPromotionView__add_InfoButtonClickedEvent(uVar5,uVar4,0);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar5 = *(undefined4 *)(iVar3 + 0x20);
		      uVar4 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar4,param1,
		                 Method_Gameplay_Accounts_Control_AccountsListViewMediator_HandlePromotionClickEvent__
		                 ,0);
		      Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___get_Count(uVar5,uVar4,0);
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060056EF RID: 22255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056EF")]
		[Address(RVA = "0xA46C", Offset = "0xA46C", VA = "0xA46C", Slot = "23")]
		protected override void ResetView(AccountsListView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Accounts_Control_AccountsListViewMediator__ResetView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int param1_01;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a588e6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AccountsModel__AccountsEvents__AccountsController__AccountsListView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_Control_AccountsListViewMediator_HandleItemClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Control_AccountsListViewMediator_HandlePromotionClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Control_AccountsListViewMediator_HandlePromotionInfoButtonClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IAccountDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_PromotionsDic__TypeInfo);
		    DAT_ram_00a588e6 = '\x01';
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = unnamed_function_1417(System_Action_IAccountDataDecorator__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Accounts_Control_AccountsListViewMediator_HandleItemClickEvent__,0);
		  if (DAT_ram_00a5888d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAccountDataDecorator__TypeInfo);
		    DAT_ram_00a5888d = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,uVar4,0);
		    uVar5 = System_Action_IAccountDataDecorator__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAccountDataDecorator__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(iVar3 + 0x28,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar5 = *(undefined4 *)(iVar3 + 0x1c);
		      uVar4 = unnamed_function_1417(System_Action_PromotionsDic__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar4,param1,
		                 Method_Gameplay_Accounts_Control_AccountsListViewMediator_HandlePromotionInfoButtonClickedEvent__
		                 ,0);
		      Gameplay_Bank_View_BankPromotionInfoWindow_BankPromotionInfoWindowArgs___ctor(uVar5,uVar4,0);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar5 = *(undefined4 *)(iVar3 + 0x20);
		      uVar4 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar4,param1,
		                 Method_Gameplay_Accounts_Control_AccountsListViewMediator_HandlePromotionClickEvent__
		                 ,0);
		      Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(uVar5,uVar4,0);
		      iVar3 = *param1;
		      uVar4 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x158) * 4))
		                        (param1,*(undefined4 *)(iVar3 + 0x15c));
		      Gameplay_Accounts_View_AccountsListView__OnDestroy
		                (uVar4,*(undefined4 *)(param1[2] + 0x18),iVar3);
		      iVar3 = *param1;
		      uVar4 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x148) * 4))
		                        (param1,*(undefined4 *)(iVar3 + 0x14c));
		      Gameplay_Accounts_Control_AccountsController__SetNotificationsCount(uVar4,iVar3);
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060056F0 RID: 22256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056F0")]
		[Address(RVA = "0xA46D", Offset = "0xA46D", VA = "0xA46D", Slot = "24")]
		protected override void SetupView(AccountsListView view)
		{
		/* --- GHIDRA: SetupView ---
		/* WARNING: Removing unreachable block (ram,0x80f43c5c) */
		
		void Gameplay_Accounts_Control_AccountsListViewMediator__SetupView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 *puVar5;
		  int iVar6;
		  undefined4 param1_00;
		  int *piVar7;
		  int *piVar8;
		  int local_40;
		  undefined1 *local_3c;
		  int local_38;
		  undefined8 *puStack_34;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_14;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a588e7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AccountsListItemView__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AccountsListItemView__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__MoveNext__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_AccountsListItemView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IAccountDataDecorator__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AccountsListItemView__GetEnumerator__);
		    DAT_ram_00a588e7 = '\x01';
		  }
		  local_14 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_38,*(undefined4 *)(iVar3 + 0x24),
		             Method_System_Collections_Generic_List_AccountsListItemView__GetEnumerator__);
		  local_8 = local_30;
		  local_40 = 0;
		  local_3c = local_10;
		code_r0x80f4395f:
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                       Method_System_Collections_Generic_List_Enumerator_AccountsListItemView__MoveNext__
		                      );
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar3 = global_1;
		      goto code_r0x80f43d04;
		    }
		    if (iVar4 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    iVar4 = local_8._4_4_;
		    piVar7 = *(int **)(local_8._4_4_ + 0x34);
		    iVar3 = *piVar7;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		        if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo == *piVar8) {
		          puVar5 = (undefined4 *)(piVar8[1] * 8 + iVar3 + 0x100);
		          goto code_r0x80f43a43;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                        Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,8);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f43c18:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar3 = global_1;
		      goto code_r0x80f43d04;
		    }
		code_r0x80f43a43:
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iiii(*puVar5,piVar7,&local_14,puVar5[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f43c18;
		    iVar6 = DAT_ram_009d3e38;
		    if (iVar3 != 0) {
		      DAT_ram_009d3e38 = 0;
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_38,local_14,
		                 Method_System_Collections_Generic_List_IAccountDataDecorator__GetEnumerator__);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar3 = global_1;
		        goto code_r0x80f43d04;
		      }
		      local_20 = local_30;
		      local_28 = CONCAT44(puStack_34,local_38);
		      local_38 = 0;
		      puStack_34 = &local_28;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_28,
		                           Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__MoveNext__
		                          );
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f43b76;
		        if (iVar3 == 0) {
		          iVar3 = 0;
		          bVar1 = false;
		          goto code_r0x80f43c30;
		        }
		      } while (local_20._4_4_ != param2);
		      DAT_ram_009d3e38 = 0;
		      iVar3 = 0;
		      import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1ab,iVar4,0);
		      bVar1 = false;
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f43b76:
		        DAT_ram_009d3e38 = 0;
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar3 = global_1;
		        iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar3 == iVar6) {
		          piVar7 = (int *)import::env::__cxa_begin_catch(param1_00);
		          iVar3 = *piVar7;
		          DAT_ram_009d3e38 = 0;
		          local_38 = iVar3;
		          import::env::invoke_v(0x123);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          bVar1 = true;
		          if (iVar6 != 1) goto code_r0x80f43c30;
		          param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar3 = global_1;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1c6,&local_38);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) goto code_r0x80f43d94;
		        goto code_r0x80f43d04;
		      }
		code_r0x80f43c30:
		      if (iVar3 != 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,iVar3);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar3 = global_1;
		        goto code_r0x80f43d04;
		      }
		      iVar6 = 0;
		      if (!bVar1) goto code_r0x80f4395f;
		    }
		    if (*(int *)(iVar4 + 0x34) == param2) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1ab,iVar4,iVar6);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 != 1) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar3 = global_1;
		code_r0x80f43d04:
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar4 == iVar3) {
		        piVar7 = (int *)import::env::__cxa_begin_catch(param1_00);
		        iVar4 = *piVar7;
		        DAT_ram_009d3e38 = 0;
		        local_40 = iVar4;
		        import::env::invoke_v(0x123);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 != 1) {
		          if (iVar4 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        param1_00 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1c7,&local_40);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 != 1) {
		        import::env::__resumeException(param1_00);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80f43d94:
		      DAT_ram_009d3e38 = 0;
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		  } while( true );
		}
		*/

		}

		// Token: 0x060056F1 RID: 22257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056F1")]
		[Address(RVA = "0xA46E", Offset = "0xA46E", VA = "0xA46E")]
		private void HandleAccountChangedEvent(IAccountDataDecorator account)
		{
		/* --- GHIDRA: HandleAccountChangedEvent ---
		void Gameplay_Accounts_Control_AccountsListViewMediator__HandleAccountChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a588e8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AccountsModel__AccountsEvents__AccountsController__AccountsListView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Sirenix_Utilities_LinqExtensions_IsNullOrEmpty_PromotionsDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_PromotionsDic__get_Item__);
		    DAT_ram_00a588e8 = '\x01';
		  }
		  uVar1 = Sirenix_Utilities_LinqExtensions__IsNullOrEmpty_object_
		                    (*(undefined4 *)(param1[2] + 0x10),
		                     Method_Sirenix_Utilities_LinqExtensions_IsNullOrEmpty_PromotionsDic___);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,uVar1 ^ 1,0);
		  if (uVar1 == 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = System_Linq_Enumerable__ToList_object_
		                      (*(undefined4 *)(param1[2] + 0x10),0,
		                       Method_System_Collections_Generic_List_PromotionsDic__get_Item__);
		    Gameplay_Bank_View_BankPromotionView__get_PromotionsDic(param1_00,uVar3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060056F2 RID: 22258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056F2")]
		[Address(RVA = "0xA46F", Offset = "0xA46F", VA = "0xA46F")]
		private void HandlePromotionUpdateCompleteEvent()
		{
		/* --- GHIDRA: HandlePromotionUpdateCompleteEvent ---
		/* WARNING: Removing unreachable block (ram,0x80f440ba) */
		
		void Gameplay_Accounts_Control_AccountsListViewMediator__HandlePromotionUpdateCompleteEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  undefined4 param2_00;
		  int *piVar8;
		  int iVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a588e9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_SingleOrDefault_AccountsListItemView___);
		    Mono_Security_ASN1__get_Item(&System_Func_AccountsListItemView__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_IAccountDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_IAccountDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Control_AccountsListViewMediator___c__DisplayClass7_0__AccountStickerChangedEvent_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Accounts_Control_AccountsListViewMediator___c__DisplayClass7_0_TypeInfo);
		    DAT_ram_00a588e9 = '\x01';
		  }
		  iVar9 = *param2;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_IAccountDataDecorator__TypeInfo ==
		          *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f43f36;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_IEnumerable_IAccountDataDecorator__TypeInfo
		                                ,0);
		code_r0x80f43f36:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    do {
		      piVar7 = local_4;
		      iVar9 = *local_4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		            puVar3 = (undefined4 *)(iVar9 + piVar8[1] * 8 + 0xc0);
		            goto code_r0x80f44001;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f44049:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f4437a;
		      }
		code_r0x80f44001:
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f44049;
		      if (iVar9 == 0) {
		        iVar9 = 0;
		        goto code_r0x80f443c3;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         Gameplay_Accounts_Control_AccountsListViewMediator___c__DisplayClass7_0_TypeInfo
		                        );
		      piVar7 = local_4;
		      if (DAT_ram_009d3e38 == 1) {
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f4437a;
		      }
		      iVar6 = *local_4;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_IAccountDataDecorator__TypeInfo == *piVar8) {
		            puVar3 = (undefined4 *)(iVar6 + piVar8[1] * 8 + 0xc0);
		            goto code_r0x80f44155;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_IAccountDataDecorator__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f44308:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f4437a;
		      }
		code_r0x80f44155:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f44308;
		      *(undefined4 *)(iVar9 + 8) = uVar4;
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f4437a;
		      }
		      param2_00 = *(undefined4 *)(iVar5 + 0x24);
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Func_AccountsListItemView__bool__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f4431c:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f4437a;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar4,iVar9,
		                 Method_Gameplay_Accounts_Control_AccountsListViewMediator___c__DisplayClass7_0__AccountStickerChangedEvent_b__0__
		                 ,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f4431c;
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x339,param2_00,uVar4,
		                         Method_System_Linq_Enumerable_SingleOrDefault_AccountsListItemView___);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f4437a;
		      }
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   UnityEngine_Object_TypeInfo);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f4437a;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3b7,uVar4,0,0);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f4437a;
		      }
		    } while (iVar6 == 0);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1ab,uVar4,uVar4);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar9 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f4437a:
		  iVar9 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar9 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar9;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x80f443c3:
		      piVar7 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar6 = *local_4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80f4443b;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80f4443b:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		      }
		      if (iVar9 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      return;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1c8,&local_c);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 != 1) {
		    import::env::__resumeException(uVar4);
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

		// Token: 0x060056F3 RID: 22259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056F3")]
		[Address(RVA = "0xA470", Offset = "0xA470", VA = "0xA470")]
		private void AccountStickerChangedEvent(IList<IAccountDataDecorator> list)
		{
		/* --- GHIDRA: AccountStickerChangedEvent ---
		void Gameplay_Accounts_Control_AccountsListViewMediator__AccountStickerChangedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a588ea == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a588ea = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x1f8);
		        goto code_r0x80f4456a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x80f4456a:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_AccountsManager__ShowAccountsListWindow(param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x060056F4 RID: 22260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056F4")]
		[Address(RVA = "0xA471", Offset = "0xA471", VA = "0xA471")]
		private void HandleItemClickEvent(IAccountDataDecorator account)
		{
		/* --- GHIDRA: HandleItemClickEvent ---
		void Gameplay_Accounts_Control_AccountsListViewMediator__HandleItemClickEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Bank_View_BankPromotionInfoWindow__get_WindowId(param2,0);
		  return;
		}
		*/

		}

		// Token: 0x060056F5 RID: 22261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056F5")]
		[Address(RVA = "0xA472", Offset = "0xA472", VA = "0xA472")]
		private void HandlePromotionInfoButtonClickedEvent(PromotionsDic promotionsDic)
		{
		/* --- GHIDRA: HandlePromotionInfoButtonClickedEvent ---
		void Gameplay_Accounts_Control_AccountsListViewMediator__HandlePromotionInfoButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a588eb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AccountsModel__AccountsEvents__AccountsController__AccountsListView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a588eb = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 400);
		        goto code_r0x80f44654;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x80f44654:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  Core_Gameplay_Managers_BankManager__Deinit
		            (*(undefined4 *)(*(int *)(param1 + 8) + 0xc),
		             *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x1c) + 0x10) + 0x14),5,0);
		  return;
		}
		*/

		}

		// Token: 0x060056F6 RID: 22262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056F6")]
		[Address(RVA = "0xA473", Offset = "0xA473", VA = "0xA473")]
		private void HandlePromotionClickEvent(PointerEventData obj)
		{
		}
	}
}
