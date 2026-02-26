using System;
using System.Collections.Generic;
using Gameplay.Bank.View;
using Gameplay.Fresco.Events;
using Gameplay.Fresco.Model;
using Gameplay.Fresco.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Fresco;
using UI;

namespace Gameplay.Fresco.Controller
{
	// Token: 0x0200080F RID: 2063
	[Token(Token = "0x200080F")]
	public class FrescoEditViewMediator : AbstractCozyViewMediator<FrescoModel, Gameplay.Fresco.Events.FrescoEvents, FrescoController, FrescoEditView>
	{
		// Token: 0x06003089 RID: 12425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003089")]
		[Address(RVA = "0x80EE", Offset = "0x80EE", VA = "0x80EE")]
		public FrescoEditViewMediator(FrescoModel model, Gameplay.Fresco.Events.FrescoEvents events, FrescoController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a575bb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_Fresco__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_BalanceChangedHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_FrescoUpdatedHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_FrescoesUpdatedHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_UniversalFragmentsCountChangedHandler__
		              );
		    DAT_ram_00a575bb = '\x01';
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_Fresco__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_FrescoUpdatedHandler__,0);
		  iVar2 = func_ii_7048(uVar5,uVar1,0);
		  uVar1 = System_Action_Fresco__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_Fresco__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x14) = iVar3;
		    uVar1 = System_Action_Fresco__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_Fresco__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_BalanceChangedHandler__,0);
		  piVar4 = (int *)func_ii_7048(uVar5,uVar1,0);
		  iVar2 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x18) = 0;
		  }
		  else if ((*piVar4 != System_Action_TypeInfo) ||
		          (*(int **)(param2 + 0x18) = piVar4, *piVar4 != iVar2)) {
		    System_Activator__CreateInstance(piVar4,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x1c);
		  uVar1 = unnamed_function_1417(iVar2);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_FrescoesUpdatedHandler__,0);
		  piVar4 = (int *)func_ii_7048(uVar5,uVar1,0);
		  iVar2 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x1c) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar4) ||
		          (*(int **)(param2 + 0x1c) = piVar4, *piVar4 != iVar2)) {
		    System_Activator__CreateInstance(piVar4,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar1,param1,
		                Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_UniversalFragmentsCountChangedHandler__
		                ,0);
		  iVar2 = func_ii_7048(uVar5,uVar1,0);
		  uVar1 = System_Action_uint__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x24) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(param2 + 0x24) = iVar3;
		    uVar1 = System_Action_uint__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		    if (iVar3 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar2,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar2,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600308A RID: 12426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600308A")]
		[Address(RVA = "0x80EF", Offset = "0x80EF", VA = "0x80EF", Slot = "21")]
		protected override void ResetEvents(Gameplay.Fresco.Events.FrescoEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a575bc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_Fresco__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_BalanceChangedHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_FrescoUpdatedHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_FrescoesUpdatedHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_UniversalFragmentsCountChangedHandler__
		              );
		    DAT_ram_00a575bc = '\x01';
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_Fresco__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_FrescoUpdatedHandler__,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  uVar1 = System_Action_Fresco__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_Fresco__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x14) = iVar3;
		    uVar1 = System_Action_Fresco__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_Fresco__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_BalanceChangedHandler__,0);
		  piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  iVar2 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x18) = 0;
		  }
		  else if ((*piVar4 != System_Action_TypeInfo) ||
		          (*(int **)(param2 + 0x18) = piVar4, *piVar4 != iVar2)) {
		    System_Activator__CreateInstance(piVar4,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x1c);
		  uVar1 = unnamed_function_1417(iVar2);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_FrescoesUpdatedHandler__,0);
		  piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  iVar2 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x1c) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar4) ||
		          (*(int **)(param2 + 0x1c) = piVar4, *piVar4 != iVar2)) {
		    System_Activator__CreateInstance(piVar4,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar1,param1,
		                Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_UniversalFragmentsCountChangedHandler__
		                ,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  uVar1 = System_Action_uint__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x24) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(param2 + 0x24) = iVar3;
		    uVar1 = System_Action_uint__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		    if (iVar3 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar2,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar2,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600308B RID: 12427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600308B")]
		[Address(RVA = "0x80F0", Offset = "0x80F0", VA = "0x80F0", Slot = "22")]
		protected override void SetupEvents(Gameplay.Fresco.Events.FrescoEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__SetupEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_01;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a575bd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBankOptionView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_List_uint___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_AcceptButtonClickHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_AdditionalRequirementsButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_BankOptionsListViewOnBuyButtonClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_BuyUniversalFragmentButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_CloseTopButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_CollectRewardButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_CompleteFrescoButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_FrescoFieldOnChangeSelected__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_InBankButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_InstallAllButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_InstallAllUniversalButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_InstallAndContinueButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_InstallUniversalButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_LeftButtonClickHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_RightButtonClickHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a575bd = '\x01';
		  }
		  iVar4 = *(int *)(param2 + 0x24);
		  uVar3 = unnamed_function_1417(System_Action_List_uint___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_FrescoFieldOnChangeSelected__,
		             0);
		  if (DAT_ram_00a57568 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_List_uint___TypeInfo);
		    DAT_ram_00a57568 = '\x01';
		  }
		  param1_00 = *(int *)(iVar4 + 0x54);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,uVar3,0);
		    uVar5 = System_Action_List_uint___TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_List_uint___TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar4 + 0x54,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      uVar5 = *(undefined4 *)(param2 + 0x6c);
		      uVar3 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_InBankButtonClickedEventHandler__
		                 ,0);
		      UI_IndexButtonBasic__add_ClickEvent(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x7c) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_CompleteFrescoButtonClickHandler__
		                 ,0);
		      UnityEngine_Events_UnityAction___ctor(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x84) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_AcceptButtonClickHandler__
		                 ,0);
		      UnityEngine_Events_UnityAction___ctor(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x44) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_AdditionalRequirementsButtonClickHandler__
		                 ,0);
		      UnityEngine_Events_UnityAction___ctor(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x5c) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_BuyUniversalFragmentButtonClickHandler__
		                 ,0);
		      UnityEngine_Events_UnityAction___ctor(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x8c) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_CloseTopButtonClickHandler__
		                 ,0);
		      UnityEngine_Events_UnityAction___ctor(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x88) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_CollectRewardButtonClickHandler__
		                 ,0);
		      UnityEngine_Events_UnityAction___ctor(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x78) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_InstallAllButtonClickHandler__
		                 ,0);
		      UnityEngine_Events_UnityAction___ctor(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x60) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_InstallAllUniversalButtonClickHandler__
		                 ,0);
		      UnityEngine_Events_UnityAction___ctor(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x80) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_InstallAndContinueButtonClickHandler__
		                 ,0);
		      UnityEngine_Events_UnityAction___ctor(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x70) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_LeftButtonClickHandler__,0
		                );
		      UnityEngine_Events_UnityAction___ctor(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x74) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_RightButtonClickHandler__,
		                 0);
		      UnityEngine_Events_UnityAction___ctor(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x58) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_InstallUniversalButtonClickHandler__
		                 ,0);
		      UnityEngine_Events_UnityAction___ctor(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(param2 + 100);
		      uVar3 = unnamed_function_1417(System_Action_IBankOptionView__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_BankOptionsListViewOnBuyButtonClickedEvent__
		                 ,0);
		      Gameplay_Bank_View_BankOptionsListView__add_BuyButtonClickedEvent(uVar5,uVar3,0);
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

		// Token: 0x0600308C RID: 12428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600308C")]
		[Address(RVA = "0x80F1", Offset = "0x80F1", VA = "0x80F1", Slot = "23")]
		protected override void ResetView(FrescoEditView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__ResetView
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_01;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a575be == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBankOptionView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_List_uint___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_AcceptButtonClickHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_AdditionalRequirementsButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_BankOptionsListViewOnBuyButtonClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_BuyUniversalFragmentButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_CloseTopButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_CollectRewardButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_CompleteFrescoButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_FrescoFieldOnChangeSelected__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_InBankButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_InstallAllButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_InstallAllUniversalButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_InstallAndContinueButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_InstallUniversalButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_LeftButtonClickHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_RightButtonClickHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a575be = '\x01';
		  }
		  iVar4 = *(int *)(param2 + 0x24);
		  uVar3 = unnamed_function_1417(System_Action_List_uint___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_FrescoFieldOnChangeSelected__,
		             0);
		  if (DAT_ram_00a57567 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_List_uint___TypeInfo);
		    DAT_ram_00a57567 = '\x01';
		  }
		  param1_00 = *(int *)(iVar4 + 0x54);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,uVar3,0);
		    uVar5 = System_Action_List_uint___TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_List_uint___TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar4 + 0x54,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      uVar5 = *(undefined4 *)(param2 + 0x6c);
		      uVar3 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_InBankButtonClickedEventHandler__
		                 ,0);
		      UI_IndexButtonBasic__get_CanvasGroup(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x7c) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_CompleteFrescoButtonClickHandler__
		                 ,0);
		      Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x84) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_AcceptButtonClickHandler__
		                 ,0);
		      Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x44) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_AdditionalRequirementsButtonClickHandler__
		                 ,0);
		      Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x5c) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_BuyUniversalFragmentButtonClickHandler__
		                 ,0);
		      Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x8c) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_CloseTopButtonClickHandler__
		                 ,0);
		      Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x88) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_CollectRewardButtonClickHandler__
		                 ,0);
		      Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x78) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_InstallAllButtonClickHandler__
		                 ,0);
		      Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x60) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_InstallAllUniversalButtonClickHandler__
		                 ,0);
		      Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x80) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_InstallAndContinueButtonClickHandler__
		                 ,0);
		      Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x70) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_LeftButtonClickHandler__,0
		                );
		      Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x74) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_RightButtonClickHandler__,
		                 0);
		      Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(*(int *)(param2 + 0x58) + 0xb4);
		      uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_InstallUniversalButtonClickHandler__
		                 ,0);
		      Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar3,0);
		      uVar5 = *(undefined4 *)(param2 + 100);
		      uVar3 = unnamed_function_1417(System_Action_IBankOptionView__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar3,param1,
		                 Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_BankOptionsListViewOnBuyButtonClickedEvent__
		                 ,0);
		      Gameplay_Bank_View_BankOptionView___ctor(uVar5,uVar3,0);
		      Gameplay_Fresco_Controller_FrescoEditViewMediator__SetupView(param1,uVar5);
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

		// Token: 0x0600308D RID: 12429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600308D")]
		[Address(RVA = "0x80F2", Offset = "0x80F2", VA = "0x80F2", Slot = "24")]
		protected override void SetupView(FrescoEditView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__SetupView(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  undefined4 param6;
		  undefined4 param5;
		  uint uVar8;
		  undefined8 local_40;
		  undefined8 local_38;
		  ulonglong local_30;
		  undefined4 local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  int local_10 [2];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a575bf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEditView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_Value__);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_SortedDictionary_Fresco__Fresco_Types_FrescoDic__get_Count__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_1142);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a575bf = '\x01';
		  }
		  local_24 = 0;
		  local_30 = 0;
		  Gameplay_Fresco_Model_FrescoModel__SetOtherFrescoData
		            (param1[2],*(undefined4 *)(param1[2] + 0x14),param1);
		  Gameplay_Fresco_Controller_FrescoEditViewMediator__SetBankOptions(param1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = *(int *)(iVar1 + 0x24);
		  iVar4 = *(int *)(param1[2] + 0x1c);
		  uVar5 = *(undefined4 *)(param1[2] + 0x14);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = param1[2];
		  if (DAT_ram_00a57569 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    DAT_ram_00a57569 = '\x01';
		  }
		  *(int *)(iVar1 + 0x5c) = iVar6;
		  *(int *)(iVar1 + 0x50) = iVar4;
		  *(undefined4 *)(iVar1 + 0x4c) = uVar5;
		  *(undefined4 *)(iVar1 + 0x58) = uVar2;
		  iVar6 = 0;
		  if (iVar4 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    iVar6 = *(int *)(iVar4 + 0x24);
		    uVar2 = Core_Extensions_Dict_FrescoDicExt__GetTitle(iVar4,0);
		  }
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (iVar1,uVar2,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  Gameplay_Fresco_View_FrescoField__Init
		            (iVar1,*(undefined4 *)(iVar1 + 0x48),*(undefined4 *)(iVar6 + 0xc),
		             *(undefined4 *)(iVar6 + 0x10),param1);
		  Gameplay_Fresco_Controller_FrescoEditViewMediator__UpdateState(param1,param1);
		  Gameplay_Fresco_Controller_FrescoEditViewMediator__FrescoFieldOnChangeSelected(param1,param1);
		  Gameplay_Fresco_Controller_FrescoEditViewMediator__RightButtonClickHandler(param1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar1 + 0x54);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties
		            (local_10,*(undefined4 *)(iVar1 + 0x90),0);
		  local_18 = local_8;
		  local_38 = local_8;
		  UnityEngine_RectTransform__get_sizeDelta(uVar2,&local_38,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar1 + 0x68);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties
		            (local_10,*(undefined4 *)(iVar1 + 0x90),0);
		  local_20 = local_8;
		  local_40 = local_8;
		  UnityEngine_RectTransform__get_sizeDelta(uVar2,&local_40,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar1 + 0x78);
		  iVar1 = Gameplay_Fresco_Model_FrescoModel__HasAvailableCells(param1[2],1,param1);
		  System_Linq_Enumerable__First_object_(uVar2,(uint)(*(int *)(iVar1 + 0xc) != 0),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x74);
		  uVar2 = Gameplay_Fresco_Model_FrescoModel__UpdateFresco(param1[2],&local_24,param1);
		  System_Linq_Enumerable__First_object_(uVar5,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x70);
		  uVar2 = Gameplay_Fresco_Model_FrescoModel__TryGetNextFresco(param1[2],&local_24,param1);
		  System_Linq_Enumerable__First_object_(uVar5,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar7 = *(int **)(iVar1 + 0x1c);
		  iVar1 = Core_Extensions_Dict_FrescoDicExt__GetMessage(*(undefined4 *)(param1[2] + 0x1c),0);
		  if (iVar1 == 0) {
		    iVar1 = StringLiteral_5;
		  }
		  iVar4 = *piVar7;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		            (piVar7,iVar1,*(undefined4 *)(iVar4 + 0x2d4));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar7 = *(int **)(iVar1 + 0x20);
		  iVar1 = param1[2];
		  if (DAT_ram_00a57586 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_Fresco___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Fresco__IndexOf__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_SortedDictionary_Fresco__Fresco_Types_FrescoDic__get_Keys__
		              );
		    DAT_ram_00a57586 = '\x01';
		  }
		  uVar2 = System_Collections_Generic_SortedDictionary_object__object___get_Item
		                    (*(undefined4 *)(iVar1 + 0x24),
		                     Method_System_Collections_Generic_SortedDictionary_Fresco__Fresco_Types_FrescoDic__get_Keys__
		                    );
		  uVar2 = System_Linq_Enumerable__Select_object__object_
		                    (uVar2,Method_System_Linq_Enumerable_ToList_Fresco___);
		  local_10[0] = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                          (uVar2,*(undefined4 *)(iVar1 + 0x14),
		                           Method_System_Collections_Generic_List_Fresco__IndexOf__);
		  local_10[0] = local_10[0] + 1;
		  uVar2 = func_ii_1081(DAT_ram_00a66954,local_10);
		  uVar5 = System_Collections_Generic_SortedDictionary_object__object___TryGetValue
		                    (*(undefined4 *)(param1[2] + 0x24),
		                     Method_System_Collections_Generic_SortedDictionary_Fresco__Fresco_Types_FrescoDic__get_Count__
		                    );
		  local_18 = CONCAT44(local_18._4_4_,uVar5);
		  uVar5 = func_ii_1081(DAT_ram_00a66954,&local_18);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_1142,uVar2,uVar5,0);
		  iVar1 = *piVar7;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar7,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		  Gameplay_Fresco_Controller_FrescoEditViewMediator__UpdateUniversalFragmentsCounters
		            (param1,*(undefined4 *)(param1[2] + 0x2c),param1);
		  iVar1 = param1[2];
		  iVar6 = *(int *)(iVar1 + 0x1c);
		  iVar4 = *(int *)(iVar6 + 0x28);
		  if (iVar4 != 0) {
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(iVar4,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar7 = (int *)func_ii_7307(*(undefined4 *)(iVar1 + 0x34),uVar2,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar7 + 0xf0) * 4))(piVar7,*(undefined4 *)(*piVar7 + 0xf4));
		    iVar1 = param1[2];
		    iVar6 = *(int *)(iVar1 + 0x1c);
		  }
		  local_30 = *(ulonglong *)(iVar6 + 0x2c);
		  if ((local_30 & 0xff) != 0) {
		    uVar8 = 0;
		    piVar7 = *(int **)(*(int *)(iVar1 + 0xc) + 8);
		    iVar1 = *piVar7;
		    if (*(ushort *)(iVar1 + 0xb6) != 0) {
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8 + 4) * 8 + iVar1 + 0xd0);
		          goto code_r0x80db059d;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar1 + 0xb6) != uVar8);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar7,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80db059d:
		    uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		    local_30 = *(ulonglong *)(*(int *)(param1[2] + 0x1c) + 0x2c);
		    uVar5 = System_Nullable_DefaultEventSystem_FocusBasedEventSequenceContext___get_HasValue
		                      (&local_30,Method_System_Nullable_uint__get_Value__);
		    iVar1 = Core_Extensions_Dict_DictExt__GetStringParameter(uVar2,uVar5,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar4 + 0x3c);
		    uVar5 = *(undefined4 *)(iVar1 + 0x10);
		    param2_00 = *(undefined4 *)(param1[2] + 8);
		    uVar2 = unnamed_function_1417
		                      (Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		    Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__Dispose
		              (uVar2,param2_00,param2_00,uVar5,0);
		    param6 = *(undefined4 *)(iVar1 + 0x14);
		    param5 = *(undefined4 *)(iVar1 + 0x18);
		    uVar5 = unnamed_function_1417
		                      (Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__Dispose
		              (uVar5,param2_00,param2_00,uVar2,param5,param6,0);
		    UI_Requirements_RequirementsView__get_Data(param1_00,uVar5,0);
		    Gameplay_Fresco_Controller_FrescoEditViewMediator__SetupDarkBG(param1,param1);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  local_30 = *(ulonglong *)(*(int *)(param1[2] + 0x1c) + 0x2c);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(iVar1 + 0x38),(uint)((local_30 & 0xff) != 0),0);
		  return;
		}
		*/

		}

		// Token: 0x0600308E RID: 12430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600308E")]
		[Address(RVA = "0x80F3", Offset = "0x80F3", VA = "0x80F3")]
		private void InitView()
		{
		/* --- GHIDRA: InitView ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__InitView(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined1 auStack_10 [8];
		  undefined8 local_8;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar1 + 0x54);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties
		            (auStack_10,*(undefined4 *)(iVar1 + 0x90),0);
		  local_18 = local_8;
		  local_28 = local_8;
		  UnityEngine_RectTransform__get_sizeDelta(uVar2,&local_28,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar1 + 0x68);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties
		            (auStack_10,*(undefined4 *)(iVar1 + 0x90),0);
		  local_20 = local_8;
		  local_30 = local_8;
		  UnityEngine_RectTransform__get_sizeDelta(uVar2,&local_30,0);
		  return;
		}
		*/

		}

		// Token: 0x0600308F RID: 12431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600308F")]
		[Address(RVA = "0x80F4", Offset = "0x80F4", VA = "0x80F4")]
		private void SetupDarkBG()
		{
		/* --- GHIDRA: SetupDarkBG ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__SetupDarkBG(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a575c0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEditView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_Value__);
		    DAT_ram_00a575c0 = '\x01';
		  }
		  if (*(char *)(*(int *)(param1[2] + 0x1c) + 0x2c) != '\0') {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar2 + 0x7c);
		    uVar1 = 0;
		    param1_01 = *(int **)(*(int *)(param1[2] + 0xc) + 0x20);
		    iVar2 = *param1_01;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x160);
		          goto code_r0x80db0ebe;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x80db0ebe:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		    local_8 = *(undefined8 *)(*(int *)(param1[2] + 0x1c) + 0x2c);
		    param2_00 = System_Nullable_DefaultEventSystem_FocusBasedEventSequenceContext___get_HasValue
		                          (&local_8,Method_System_Nullable_uint__get_Value__);
		    uVar4 = Core_Gameplay_Managers_Requirements_RequirementsManager__GetRequirementDic
		                      (uVar4,param2_00,*(undefined4 *)(param1[2] + 8),0);
		    System_Linq_Enumerable__First_object_(param1_00,uVar4,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003090 RID: 12432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003090")]
		[Address(RVA = "0x80F5", Offset = "0x80F5", VA = "0x80F5")]
		private void CheckRequirements()
		{
		/* --- GHIDRA: CheckRequirements ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__CheckRequirements
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a575c1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEditView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a575c1 = '\x01';
		  }
		  param1_00 = *(int **)(*(int *)(param1[2] + 0xc) + 0x20);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x268);
		        goto code_r0x80db108b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x35);
		code_r0x80db108b:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  param2_00 = *(undefined4 *)(iVar3 + 0x14);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Cysharp_Threading_Tasks_Triggers_AsyncTriggerBase_AsyncTriggerEnumerator_float____cctor
		            (*(undefined4 *)(iVar3 + 100),param2_00,param2_00,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Bank_View_BankOptionsListView__get_Data
		            (*(undefined4 *)(iVar3 + 100),*(undefined4 *)(param1[2] + 0x3c),0);
		  return;
		}
		*/

		}

		// Token: 0x06003091 RID: 12433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003091")]
		[Address(RVA = "0x80F6", Offset = "0x80F6", VA = "0x80F6")]
		private void SetBankOptions()
		{
		/* --- GHIDRA: SetBankOptions ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__SetBankOptions
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a575c2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEditView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_uint___);
		    DAT_ram_00a575c2 = '\x01';
		  }
		  iVar3 = Method_System_Array_Empty_uint___;
		  iVar1 = param1[2];
		  iVar2 = *(int *)(Method_System_Array_Empty_uint___ + 0x1c);
		  if (iVar2 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_uint___);
		    iVar2 = *(int *)(iVar3 + 0x1c);
		  }
		  iVar2 = *(int *)(iVar2 + 8);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  if (*(int *)(iVar2 + 0x74) == 0) {
		    func_ii_306000(iVar2);
		  }
		  iVar3 = *(int *)(*(int *)(iVar3 + 0x1c) + 8);
		  if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		    iVar3 = func_ii_1079(iVar3);
		  }
		  *(undefined4 *)(iVar1 + 0x28) = **(undefined4 **)(iVar3 + 0x5c);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = *(int *)(iVar3 + 0x24);
		  if (DAT_ram_00a5756a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__Clear__);
		    DAT_ram_00a5756a = '\x01';
		  }
		  iVar3 = *(int *)(iVar3 + 0x60);
		  *(undefined4 *)(iVar3 + 0xc) = 0;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  return;
		}
		*/

		}

		// Token: 0x06003092 RID: 12434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003092")]
		[Address(RVA = "0x80F7", Offset = "0x80F7", VA = "0x80F7")]
		private void ClearSelection()
		{
		/* --- GHIDRA: ClearSelection ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__ClearSelection
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int param1_00;
		  uint uVar3;
		  
		  if (DAT_ram_00a575c3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEditView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__ToArray__);
		    DAT_ram_00a575c3 = '\x01';
		  }
		  iVar2 = param1[2];
		  uVar1 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                    (param2,Method_System_Collections_Generic_List_uint__ToArray__);
		  *(undefined4 *)(iVar2 + 0x28) = uVar1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_
		            (*(undefined4 *)(iVar2 + 0x84),(uint)(*(int *)(*(int *)(param1[2] + 0x28) + 0xc) != 0),0
		            );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = *(undefined4 *)(iVar2 + 0x60);
		  param1_00 = param1[2];
		  uVar3 = *(uint *)(param1_00 + 0x2c);
		  iVar2 = Gameplay_Fresco_Model_FrescoModel__get_CanSelectUniversalFragment(param1_00,param1);
		  if ((longlong)(ulonglong)uVar3 < (longlong)iVar2) {
		    uVar3 = 0;
		  }
		  else {
		    iVar2 = Gameplay_Fresco_Model_FrescoModel__get_CanSelectUniversalFragment(param1_00,param1);
		    uVar3 = (uint)(*(int *)(*(int *)(param1_00 + 0x28) + 0xc) < iVar2);
		  }
		  System_Linq_Enumerable__First_object_(uVar1,uVar3,0);
		  Gameplay_Fresco_Controller_FrescoEditViewMediator__FrescoFieldOnChangeSelected(param1,param1);
		  Gameplay_Fresco_Controller_FrescoEditViewMediator__UpdateState(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003093 RID: 12435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003093")]
		[Address(RVA = "0x80F8", Offset = "0x80F8", VA = "0x80F8")]
		private void FrescoFieldOnChangeSelected(List<uint> selectedCells)
		{
		/* --- GHIDRA: FrescoFieldOnChangeSelected ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__FrescoFieldOnChangeSelected
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a575c4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEditView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_FrescoEditView_States__get_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_FrescoEditView_States__set_CurrentState__);
		    DAT_ram_00a575c4 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1[2] + 0x14) + 0x1c);
		  if ((iVar2 == 0) || (iVar2 == 1)) {
		    iVar3 = *(int *)(*(int *)(param1[2] + 0x28) + 0xc);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    if (iVar3 != 0) {
		      uVar1 = 2;
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      if (1 < *(int *)(iVar3 + 0x18) - 1U) {
		        uVar1 = 4;
		      }
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (iVar2,uVar1,
		                 Method_UI_MonoBehaviourWithStates_FrescoEditView_States__set_CurrentState__);
		      return;
		    }
		    if ((*(int *)(iVar2 + 0x18) == 4) &&
		       ((iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                           (param1,*(undefined4 *)(*param1 + 0x15c)), *(int *)(iVar2 + 0x18) != 4 ||
		        (iVar2 = Gameplay_Fresco_Model_FrescoModel__get_CanInstallUniversalFragment
		                           (param1[2],param1), iVar2 != 0)))) {
		      return;
		    }
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (uVar1,1,Method_UI_MonoBehaviourWithStates_FrescoEditView_States__set_CurrentState__);
		    return;
		  }
		  if (iVar2 != 2) {
		    if ((iVar2 == 3) || (iVar2 == 4)) {
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (uVar1,6,Method_UI_MonoBehaviourWithStates_FrescoEditView_States__set_CurrentState__
		                );
		      return;
		    }
		    if (iVar2 == 5) {
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (uVar1,7,Method_UI_MonoBehaviourWithStates_FrescoEditView_States__set_CurrentState__
		                );
		      return;
		    }
		    if (iVar2 == 6) {
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (uVar1,8,Method_UI_MonoBehaviourWithStates_FrescoEditView_States__set_CurrentState__
		                );
		      return;
		    }
		  }
		  uVar1 = unnamed_function_2232(&System_ArgumentOutOfRangeException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  System_ArgumentNullException___ctor(uVar1,0);
		  param2_00 = unnamed_function_2232
		                        (&Method_Gameplay_Fresco_Controller_FrescoEditViewMediator_UpdateState__);
		  func_ii_1050(uVar1,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003094 RID: 12436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003094")]
		[Address(RVA = "0x80F9", Offset = "0x80F9", VA = "0x80F9")]
		private void UpdateState()
		{
		/* --- GHIDRA: UpdateState ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__UpdateState(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined1 auStack_20 [8];
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a575c5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEditView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21978);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28579);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2006);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7852);
		    DAT_ram_00a575c5 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar4 = *(int **)(iVar1 + 0x48);
		  local_8 = *(undefined4 *)(*(int *)(param1[2] + 0x28) + 0xc);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_8);
		  local_c = *(undefined4 *)(param1[2] + 0x2c);
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_c);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_2006,uVar2,uVar3,0);
		  iVar1 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar4,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar4 = *(int **)(iVar1 + 0x4c);
		  local_10 = *(undefined4 *)(param1[2] + 0x2c);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_10);
		  uVar2 = func_ii_4419(StringLiteral_28579,uVar2,0);
		  iVar1 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar4,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		  iVar1 = Gameplay_Fresco_Model_FrescoModel__HasAvailableCells(param1[2],0,auStack_20);
		  local_4 = *(undefined4 *)(iVar1 + 0xc);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_7852,1,0,1,0,0,0,0);
		  iVar1 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  uVar3 = func_ii_4443(&local_4,0);
		  local_18 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,StringLiteral_21978,uVar3,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar1 + 0x10) = local_18;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,iVar1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = **(int **)(iVar1 + 0x50);
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))
		            (*(int **)(iVar1 + 0x50),uVar2,*(undefined4 *)(iVar5 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06003095 RID: 12437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003095")]
		[Address(RVA = "0x80FA", Offset = "0x80FA", VA = "0x80FA")]
		private void UpdateUniversalFragmentsCounters()
		{
		/* --- GHIDRA: UpdateUniversalFragmentsCounters ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__UpdateUniversalFragmentsCounters
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  uint param2_00;
		  
		  if (DAT_ram_00a575c6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEditView__get_Model__
		              );
		    DAT_ram_00a575c6 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x58),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(param2 != 0),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar1 + 0x58);
		  if (*(int *)(param1[2] + 0x2c) == 0) {
		    param2_00 = 0;
		  }
		  else {
		    iVar1 = Gameplay_Fresco_Model_FrescoModel__get_CanSelectUniversalFragment(param1[2],param1);
		    param2_00 = (uint)(0 < iVar1);
		  }
		  System_Linq_Enumerable__First_object_(uVar2,param2_00,0);
		  Gameplay_Fresco_Controller_FrescoEditViewMediator__UpdateState(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003096 RID: 12438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003096")]
		[Address(RVA = "0x80FB", Offset = "0x80FB", VA = "0x80FB")]
		private void UniversalFragmentsCountChangedHandler(uint count)
		{
		/* --- GHIDRA: UniversalFragmentsCountChangedHandler ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__UniversalFragmentsCountChangedHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Fresco_Controller_FrescoEditViewMediator__SetupDarkBG(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003097 RID: 12439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003097")]
		[Address(RVA = "0x80FC", Offset = "0x80FC", VA = "0x80FC")]
		private void BalanceChangedHandler()
		{
		/* --- GHIDRA: BalanceChangedHandler ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__BalanceChangedHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Fresco_Controller_FrescoEditViewMediator__SetupView(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003098 RID: 12440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003098")]
		[Address(RVA = "0x80FD", Offset = "0x80FD", VA = "0x80FD")]
		private void FrescoesUpdatedHandler()
		{
		/* --- GHIDRA: FrescoesUpdatedHandler ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__FrescoesUpdatedHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a575c7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEditView__get_Model__
		              );
		    DAT_ram_00a575c7 = '\x01';
		  }
		  if (*(longlong *)(param2 + 0x10) == *(longlong *)(*(int *)(*(int *)(param1 + 8) + 0x14) + 0x10)) {
		    Gameplay_Fresco_Controller_FrescoEditViewMediator__SetupView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003099 RID: 12441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003099")]
		[Address(RVA = "0x80FE", Offset = "0x80FE", VA = "0x80FE")]
		private void FrescoUpdatedHandler(Fresco fresco)
		{
		/* --- GHIDRA: FrescoUpdatedHandler ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__FrescoUpdatedHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a575c8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEditView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_FrescoEditView_States__set_CurrentState__);
		    DAT_ram_00a575c8 = '\x01';
		  }
		  Gameplay_Fresco_Controller_FrescoEditViewMediator__SetBankOptions(param1,param1);
		  iVar1 = Gameplay_Fresco_Model_FrescoModel__HasAvailableCells(param1[2],0,param1);
		  if (*(int *)(iVar1 + 0xc) != 0) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (uVar2,3,Method_UI_MonoBehaviourWithStates_FrescoEditView_States__set_CurrentState__);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar1 + 0x60),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,0,0);
		    Gameplay_Fresco_Controller_FrescoEditViewMediator__UpdateState(param1,param1);
		    return;
		  }
		  Gameplay_Fresco_Controller_FrescoEditViewMediator__InstallUniversalButtonClickHandler
		            (param1,param1);
		  Gameplay_Fresco_Controller_FrescoEditViewMediator__UpdateState(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600309A RID: 12442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600309A")]
		[Address(RVA = "0x80FF", Offset = "0x80FF", VA = "0x80FF")]
		private void InstallUniversalButtonClickHandler()
		{
		/* --- GHIDRA: InstallUniversalButtonClickHandler ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__InstallUniversalButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a575c9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEditView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_FrescoEditView_States__set_CurrentState__);
		    DAT_ram_00a575c9 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar1,4,Method_UI_MonoBehaviourWithStates_FrescoEditView_States__set_CurrentState__);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar2 + 0x84),0,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x60),0);
		  iVar3 = param1[2];
		  uVar4 = *(uint *)(iVar3 + 0x2c);
		  iVar2 = Gameplay_Fresco_Model_FrescoModel__get_CanSelectUniversalFragment(iVar3,param1);
		  if ((longlong)(ulonglong)uVar4 < (longlong)iVar2) {
		    uVar4 = 0;
		  }
		  else {
		    iVar2 = Gameplay_Fresco_Model_FrescoModel__get_CanSelectUniversalFragment(iVar3,param1);
		    uVar4 = (uint)(*(int *)(*(int *)(iVar3 + 0x28) + 0xc) < iVar2);
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,uVar4,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = *(undefined4 *)(iVar2 + 0x60);
		  iVar3 = param1[2];
		  uVar4 = *(uint *)(iVar3 + 0x2c);
		  iVar2 = Gameplay_Fresco_Model_FrescoModel__get_CanSelectUniversalFragment(iVar3,iVar3);
		  if ((longlong)(ulonglong)uVar4 < (longlong)iVar2) {
		    uVar4 = 0;
		  }
		  else {
		    iVar2 = Gameplay_Fresco_Model_FrescoModel__get_CanSelectUniversalFragment(iVar3,iVar3);
		    uVar4 = (uint)(*(int *)(*(int *)(iVar3 + 0x28) + 0xc) < iVar2);
		  }
		  System_Linq_Enumerable__First_object_(uVar1,uVar4,0);
		  return;
		}
		*/

		}

		// Token: 0x0600309B RID: 12443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600309B")]
		[Address(RVA = "0x8100", Offset = "0x8100", VA = "0x8100")]
		private void SetUniversalFragmentInstallationState()
		{
		/* --- GHIDRA: SetUniversalFragmentInstallationState ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__SetUniversalFragmentInstallationState
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a575ca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEditView__get_Model__
		              );
		    DAT_ram_00a575ca = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x14c)));
		  Gameplay_Fresco_Controller_FrescoController__FillFrescoSlots
		            (param1_00,*(undefined8 *)(*(int *)(param1[2] + 0x14) + 0x10),param1);
		  return;
		}
		*/

		}

		// Token: 0x0600309C RID: 12444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600309C")]
		[Address(RVA = "0x8101", Offset = "0x8101", VA = "0x8101")]
		private void CompleteFrescoButtonClickHandler()
		{
		/* --- GHIDRA: CompleteFrescoButtonClickHandler ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__CompleteFrescoButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  undefined8 param2_00;
		  
		  if (DAT_ram_00a575cb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEditView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_FrescoEditView_States__get_CurrentState__);
		    DAT_ram_00a575cb = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c)));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  param3 = *(undefined4 *)(param1[2] + 0x28);
		  param2_00 = *(undefined8 *)(*(int *)(param1[2] + 0x14) + 0x10);
		  if (iVar1 == 2) {
		    Gameplay_Fresco_Controller_FrescoController__GetOtherUserFrescoes(uVar2,param2_00,param3,param1)
		    ;
		    uVar2 = (undefined4)((ulonglong)param2_00 >> 0x20);
		  }
		  else {
		    Gameplay_Fresco_Controller_FrescoController__CollectFrescoReward(uVar2,param2_00,param3,param1);
		    uVar2 = (undefined4)((ulonglong)param2_00 >> 0x20);
		  }
		  Gameplay_Fresco_Controller_FrescoEditViewMediator__SetBankOptions(param1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x15c)));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar1 + 0x84),0,0);
		  return;
		}
		*/

		}

		// Token: 0x0600309D RID: 12445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600309D")]
		[Address(RVA = "0x8102", Offset = "0x8102", VA = "0x8102")]
		private void AcceptButtonClickHandler()
		{
		/* --- GHIDRA: AcceptButtonClickHandler ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__AcceptButtonClickHandler
		               (int param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 param2_00;
		  int *param1_00;
		  uint uVar5;
		  ulonglong local_8;
		  
		  if (DAT_ram_00a575cc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEditView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_Value__);
		    Mono_Security_ASN1__get_Item(&UI_Windows_RequirementsWindow_RequirementsWindowArgs_TypeInfo);
		    DAT_ram_00a575cc = '\x01';
		  }
		  local_8 = *(ulonglong *)(*(int *)(*(int *)(param1 + 8) + 0x1c) + 0x2c);
		  if ((local_8 & 0xff) != 0) {
		    uVar5 = 0;
		    iVar4 = *(int *)(*(int *)(param1 + 8) + 0xc);
		    param2_00 = *(undefined4 *)(iVar4 + 0x1c);
		    param1_00 = *(int **)(iVar4 + 0x20);
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0x160);
		          goto code_r0x80db15c0;
		        }
		        uVar5 = uVar5 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		    }
		    puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x80db15c0:
		    uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		    uVar3 = System_Nullable_DefaultEventSystem_FocusBasedEventSequenceContext___get_HasValue
		                      (&local_8,Method_System_Nullable_uint__get_Value__);
		    uVar2 = Core_Gameplay_Managers_Requirements_RequirementsManager__Deinit(uVar2,uVar3,0);
		    uVar3 = unnamed_function_1417(UI_Windows_RequirementsWindow_RequirementsWindowArgs_TypeInfo);
		    UI_Windows_RequirementsWindow_RequirementsWindowArgs__set_User
		              (uVar3,param2_00,param2_00,uVar2,0);
		    UI_Windows_RequirementsWindow__HandleContent(uVar3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600309E RID: 12446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600309E")]
		[Address(RVA = "0x8103", Offset = "0x8103", VA = "0x8103")]
		private void AdditionalRequirementsButtonClickHandler()
		{
		/* --- GHIDRA: AdditionalRequirementsButtonClickHandler ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__AdditionalRequirementsButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a575cd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_FrescoEditView_States__set_CurrentState__);
		    DAT_ram_00a575cd = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1_00,5,Method_UI_MonoBehaviourWithStates_FrescoEditView_States__set_CurrentState__
		            );
		  Gameplay_Fresco_Controller_FrescoEditViewMediator__CheckRequirements(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600309F RID: 12447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600309F")]
		[Address(RVA = "0x8104", Offset = "0x8104", VA = "0x8104")]
		private void BuyUniversalFragmentButtonClickHandler()
		{
		/* --- GHIDRA: BuyUniversalFragmentButtonClickHandler ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__BuyUniversalFragmentButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a575ce == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_FrescoEditView_States__set_CurrentState__);
		    DAT_ram_00a575ce = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1_00,1,Method_UI_MonoBehaviourWithStates_FrescoEditView_States__set_CurrentState__
		            );
		  Gameplay_Fresco_Controller_FrescoEditViewMediator__SetupView(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060030A0 RID: 12448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A0")]
		[Address(RVA = "0x8105", Offset = "0x8105", VA = "0x8105")]
		private void CloseTopButtonClickHandler()
		{
		/* --- GHIDRA: CloseTopButtonClickHandler ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__CloseTopButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a575cf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEditView__get_Model__
		              );
		    DAT_ram_00a575cf = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x14c)));
		  Gameplay_Fresco_Controller_FrescoController__CompleteFresco
		            (param1_00,*(undefined8 *)(*(int *)(param1[2] + 0x14) + 0x10),param1);
		  return;
		}
		*/

		}

		// Token: 0x060030A1 RID: 12449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A1")]
		[Address(RVA = "0x8106", Offset = "0x8106", VA = "0x8106")]
		private void CollectRewardButtonClickHandler()
		{
		/* --- GHIDRA: CollectRewardButtonClickHandler ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__CollectRewardButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 param1_00;
		  undefined4 param3;
		  int param1_01;
		  undefined8 param2_00;
		  
		  if (DAT_ram_00a575d0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEditView__get_Model__
		              );
		    DAT_ram_00a575d0 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x14c)));
		  param1_01 = param1[2];
		  param2_00 = *(undefined8 *)(*(int *)(param1_01 + 0x14) + 0x10);
		  param3 = Gameplay_Fresco_Model_FrescoModel__HasAvailableCells(param1_01,1,param1_01);
		  Gameplay_Fresco_Controller_FrescoController__GetOtherUserFrescoes
		            (param1_00,param2_00,param3,param1_01);
		  return;
		}
		*/

		}

		// Token: 0x060030A2 RID: 12450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A2")]
		[Address(RVA = "0x8107", Offset = "0x8107", VA = "0x8107")]
		private void InstallAllButtonClickHandler()
		{
		/* --- GHIDRA: InstallAllButtonClickHandler ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__InstallAllButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar1 + 0x60),0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Fresco_View_FrescoFieldEditable__ValidateSize(*(undefined4 *)(iVar1 + 0x24),param1);
		  return;
		}
		*/

		}

		// Token: 0x060030A3 RID: 12451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A3")]
		[Address(RVA = "0x8108", Offset = "0x8108", VA = "0x8108")]
		private void InstallAllUniversalButtonClickHandler()
		{
		/* --- GHIDRA: InstallAllUniversalButtonClickHandler ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__InstallAllUniversalButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 param1_00;
		  undefined4 param3;
		  undefined8 param2_00;
		  
		  if (DAT_ram_00a575d1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEditView__get_Model__
		              );
		    DAT_ram_00a575d1 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x14c)));
		  param2_00 = *(undefined8 *)(*(int *)(param1[2] + 0x14) + 0x10);
		  param3 = Gameplay_Fresco_Model_FrescoModel__HasAvailableCells(param1[2],0,param1);
		  Gameplay_Fresco_Controller_FrescoController__GetOtherUserFrescoes
		            (param1_00,param2_00,param3,param1);
		  Gameplay_Fresco_Controller_FrescoEditViewMediator__InstallUniversalButtonClickHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060030A4 RID: 12452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A4")]
		[Address(RVA = "0x8109", Offset = "0x8109", VA = "0x8109")]
		private void InstallAndContinueButtonClickHandler()
		{
		/* --- GHIDRA: InstallAndContinueButtonClickHandler ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__InstallAndContinueButtonClickHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a575d2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEditView__get_Model__
		              );
		    DAT_ram_00a575d2 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = Gameplay_Fresco_Model_FrescoModel__TryGetNextFresco
		                    (*(undefined4 *)(param1 + 8),&local_4,auStack_10);
		  if (iVar1 != 0) {
		    Gameplay_Fresco_Model_FrescoModel__SetOtherFrescoData
		              (*(undefined4 *)(param1 + 8),local_4,auStack_10);
		    Gameplay_Fresco_Controller_FrescoEditViewMediator__SetupView(param1,auStack_10);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060030A5 RID: 12453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A5")]
		[Address(RVA = "0x810A", Offset = "0x810A", VA = "0x810A")]
		private void LeftButtonClickHandler()
		{
		/* --- GHIDRA: LeftButtonClickHandler ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__LeftButtonClickHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a575d3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEditView__get_Model__
		              );
		    DAT_ram_00a575d3 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = Gameplay_Fresco_Model_FrescoModel__UpdateFresco
		                    (*(undefined4 *)(param1 + 8),&local_4,auStack_10);
		  if (iVar1 != 0) {
		    Gameplay_Fresco_Model_FrescoModel__SetOtherFrescoData
		              (*(undefined4 *)(param1 + 8),local_4,auStack_10);
		    Gameplay_Fresco_Controller_FrescoEditViewMediator__SetupView(param1,auStack_10);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060030A6 RID: 12454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A6")]
		[Address(RVA = "0x810B", Offset = "0x810B", VA = "0x810B")]
		private void RightButtonClickHandler()
		{
		/* --- GHIDRA: RightButtonClickHandler ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__RightButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 param3;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  undefined4 param1_01;
		  int iVar4;
		  float param2_00;
		  int iVar5;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a575d4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEditView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_FrescoFragment__TypeInfo);
		    DAT_ram_00a575d4 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x28);
		  iVar1 = Gameplay_Fresco_Model_FrescoModel__get_OtherFrescoData(param1[2],param1);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,(uint)(iVar1 != 0),0);
		  iVar1 = Gameplay_Fresco_Model_FrescoModel__get_OtherFrescoData(param1[2],param1);
		  if (iVar1 != 0) {
		    iVar1 = Gameplay_Fresco_Model_FrescoModel__get_OtherFrescoData(param1[2],param1);
		    piVar2 = (int *)Core_Data_ArtikulDataCustom__SetCurrentDurability
		                              (*(undefined4 *)(iVar1 + 0x10),
		                               *(undefined4 *)(*(int *)(param1[2] + 0xc) + 8),0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe8) * 4))
		                      (piVar2,*(undefined4 *)(*piVar2 + 0xec));
		    piVar2[0xe] = iVar1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar5 = **(int **)(iVar1 + 0x2c);
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0x138) * 4))
		              (*(int **)(iVar1 + 0x2c),piVar2,*(undefined4 *)(iVar5 + 0x13c));
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_01 = *(undefined4 *)(iVar1 + 0x30);
		    uVar3 = Gameplay_Fresco_Model_FrescoModel__get_KeyCell(param1[2],param1);
		    param3 = Gameplay_Fresco_Model_FrescoModel__get_KeyFrescoCell(param1[2],param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar2 = *(int **)(iVar1 + 0x24);
		    param1_00 = unnamed_function_1417(System_Action_FrescoFragment__TypeInfo);
		    if (piVar2 == (int *)0x0) {
		      System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,piVar2,*(undefined4 *)(*piVar2 + 0x134),0);
		    Gameplay_Fresco_View_FrescoFragment__OnDestroy(param1_01,uVar3,param3,param1_00,param1);
		    iVar1 = Gameplay_Fresco_Model_FrescoModel__get_KeyCell(param1[2],param1);
		    if (iVar1 != 0) {
		      iVar4 = *(int *)(iVar1 + 0x10);
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar1 + 0x30),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)(iVar4 != 2),0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar1 + 0x2c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)(iVar4 != 0),0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param2_00 = 1.0;
		    if (iVar4 != 1) {
		      param2_00 = 0.0;
		    }
		    Gameplay_Inventory_View_ArtikulView__GetData(*(undefined4 *)(iVar1 + 0x2c),param2_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060030A7 RID: 12455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A7")]
		[Address(RVA = "0x810C", Offset = "0x810C", VA = "0x810C")]
		private void SetKeyObject()
		{
		/* --- GHIDRA: SetKeyObject ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__SetKeyObject
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a575d5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEditView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a575d5 = '\x01';
		  }
		  param1_01 = *(int **)(*(int *)(*(int *)(param1 + 8) + 0xc) + 0x20);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 400);
		        goto code_r0x80db1953;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x80db1953:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_BankManager__Deinit(param1_00,0,0xe,0);
		  return;
		}
		*/

		}

		// Token: 0x060030A8 RID: 12456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A8")]
		[Address(RVA = "0x810D", Offset = "0x810D", VA = "0x810D")]
		private void InBankButtonClickedEventHandler(IndexButtonBasic _)
		{
		/* --- GHIDRA: InBankButtonClickedEventHandler ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__InBankButtonClickedEventHandler
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 param2_00;
		  int iVar4;
		  
		  if (DAT_ram_00a575d6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_View_IBankOptionView_TypeInfo);
		    DAT_ram_00a575d6 = '\x01';
		  }
		  piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Bank_View_IBankOptionView_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80db1a19;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Gameplay_Bank_View_IBankOptionView_TypeInfo,0);
		code_r0x80db1a19:
		  param2_00 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		  Gameplay_Bank_Controller_BankController__RequestActivePromotions
		            (*(undefined4 *)(*(int *)(iVar4 + 0xc) + 0x14),param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060030A9 RID: 12457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030A9")]
		[Address(RVA = "0x810E", Offset = "0x810E", VA = "0x810E")]
		private void BankOptionsListViewOnBuyButtonClickedEvent(IBankOptionView bankOptionView)
		{
		/* --- GHIDRA: BankOptionsListViewOnBuyButtonClickedEvent ---
		void Gameplay_Fresco_Controller_FrescoEditViewMediator__BankOptionsListViewOnBuyButtonClickedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a575d7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEpView___ctor__
		              );
		    DAT_ram_00a575d7 = '\x01';
		  }
		  MVC_AbstractController_object__object___set_Model
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractCozyViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEpView___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
