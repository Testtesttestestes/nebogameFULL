using System;
using Gameplay.Bank.Events;
using Gameplay.Bank.Model;
using Gameplay.Bank.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Bank.Controller
{
	// Token: 0x02000C65 RID: 3173
	[Token(Token = "0x2000C65")]
	public class BankOptionInfoWindowMediator : AbstractViewMediator<BankModel, BankEvents, BankController, BankOptionInfoWindow>
	{
		// Token: 0x06004D85 RID: 19845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D85")]
		[Address(RVA = "0x9BBD", Offset = "0x9BBD", VA = "0x9BBD")]
		public BankOptionInfoWindowMediator(BankModel model, BankEvents events, BankController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Bank_Controller_BankOptionInfoWindowMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a597f4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankOptionInfoWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Bank_Controller_BankOptionInfoWindowMediator_OptionArtikulsReceivedEvent__
		              );
		    DAT_ram_00a597f4 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x20);
		    uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar2,param1,
		                  Method_Gameplay_Bank_Controller_BankOptionInfoWindowMediator_OptionArtikulsReceivedEvent__
		                  ,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_uint__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x20) = iVar4;
		      uVar2 = System_Action_uint__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x20);
		    uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar2,param1,
		                  Method_Gameplay_Bank_Controller_BankOptionInfoWindowMediator_OptionArtikulsReceivedEvent__
		                  ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_uint__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x20) = iVar4;
		    uVar2 = System_Action_uint__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000FB3 RID: 4019
		// (set) Token: 0x06004D86 RID: 19846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FB3")]
		public override BankEvents Events
		{
			[Token(Token = "0x6004D86")]
			[Address(RVA = "0x9BBE", Offset = "0x9BBE", VA = "0x9BBE", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004D87 RID: 19847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D87")]
		[Address(RVA = "0x9BBF", Offset = "0x9BBF", VA = "0x9BBF")]
		private void OptionArtikulsReceivedEvent(uint optionId)
		{
		/* --- GHIDRA: OptionArtikulsReceivedEvent ---
		void Gameplay_Bank_Controller_BankOptionInfoWindowMediator__OptionArtikulsReceivedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a597f6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_BankOptionInfoWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BankOptionArtikulContainerData__get_Item__);
		    DAT_ram_00a597f6 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x3c);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_8093(uVar2,Method_UI_Windows_BaseWindow_BankOptionInfoWindowArgs__get_WindowArgs__
		                      );
		  uVar2 = System_Linq_Enumerable__ToList_object_
		                    (*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x18) + 0xc) + 0x60),param1[6],
		                     Method_System_Collections_Generic_List_BankOptionArtikulContainerData__get_Item__
		                    );
		  Gameplay_Bank_View_BankOptionAdPlacementView___ctor(param1_00,uVar2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004D88 RID: 19848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D88")]
		[Address(RVA = "0x9BC0", Offset = "0x9BC0", VA = "0x9BC0")]
		private void DisplayCurrentContainer()
		{
		/* --- GHIDRA: DisplayCurrentContainer ---
		void Gameplay_Bank_Controller_BankOptionInfoWindowMediator__DisplayCurrentContainer
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a597f7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankOptionInfoWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IBankOptionView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Bank_Controller_BankOptionInfoWindowMediator_BankOptionViewOnBuyButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Bank_Controller_BankOptionInfoWindowMediator_NextButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Bank_Controller_BankOptionInfoWindowMediator_PrevButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_BankOptionInfoWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3530);
		    DAT_ram_00a597f7 = '\x01';
		  }
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar3,0);
		  if (iVar4 != 0) {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(iVar4 + 0x40) + 0xb4);
		    uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar3,param1,
		               Method_Gameplay_Bank_Controller_BankOptionInfoWindowMediator_PrevButtonClickHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar6,uVar3,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(iVar4 + 0x44) + 0xb4);
		    uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar3,param1,
		               Method_Gameplay_Bank_Controller_BankOptionInfoWindowMediator_NextButtonClickHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar6,uVar3,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar4 = *(int *)(iVar4 + 0x48);
		    uVar3 = unnamed_function_1417(System_Action_IBankOptionView__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Bank_Controller_BankOptionInfoWindowMediator_BankOptionViewOnBuyButtonClickEvent__
		               ,0);
		    if (DAT_ram_00a59772 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_IBankOptionView__TypeInfo);
		      DAT_ram_00a59772 = '\x01';
		    }
		    iVar8 = *(int *)(iVar4 + 0x5c);
		    do {
		      iVar2 = 0;
		      iVar5 = func_ii_7048(iVar8,uVar3,0);
		      uVar6 = System_Action_IBankOptionView__TypeInfo;
		      if ((iVar5 != 0) &&
		         (iVar2 = func_ii_1082(iVar5,System_Action_IBankOptionView__TypeInfo), iVar2 == 0)) {
		        System_Activator__CreateInstance(iVar5,uVar6);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar2 = func_ii_4329(iVar4 + 0x5c,iVar2,iVar8);
		      bVar1 = iVar2 != iVar8;
		      iVar8 = iVar2;
		    } while (bVar1);
		  }
		  param1[5] = param2;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar3,0);
		  if (iVar4 != 0) {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(iVar4 + 0x40) + 0xb4);
		    uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar3,param1,
		               Method_Gameplay_Bank_Controller_BankOptionInfoWindowMediator_PrevButtonClickHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar3,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(*(int *)(iVar4 + 0x44) + 0xb4);
		    uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar3,param1,
		               Method_Gameplay_Bank_Controller_BankOptionInfoWindowMediator_NextButtonClickHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar3,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar4 + 0x40),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar4 + 0x44),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar7 = *(int **)(iVar4 + 0x48);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar4 = func_ii_8093(uVar3,
		                         Method_UI_Windows_BaseWindow_BankOptionInfoWindowArgs__get_WindowArgs__);
		    iVar8 = *piVar7;
		    (**(code **)((ulonglong)*(uint *)(iVar8 + 0x138) * 4))
		              (piVar7,*(undefined4 *)(iVar4 + 0x18),*(undefined4 *)(iVar8 + 0x13c));
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar4 + 0x48) + 0x30),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar4 = *(int *)(iVar4 + 0x48);
		    uVar3 = unnamed_function_1417(System_Action_IBankOptionView__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Bank_Controller_BankOptionInfoWindowMediator_BankOptionViewOnBuyButtonClickEvent__
		               ,0);
		    if (DAT_ram_00a59771 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_IBankOptionView__TypeInfo);
		      DAT_ram_00a59771 = '\x01';
		    }
		    iVar8 = *(int *)(iVar4 + 0x5c);
		    do {
		      iVar2 = 0;
		      iVar5 = UnityEngine_UI_Image__set_sprite(iVar8,uVar3,0);
		      uVar6 = System_Action_IBankOptionView__TypeInfo;
		      if ((iVar5 != 0) &&
		         (iVar2 = func_ii_1082(iVar5,System_Action_IBankOptionView__TypeInfo), iVar2 == 0)) {
		        System_Activator__CreateInstance(iVar5,uVar6);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar2 = func_ii_4329(iVar4 + 0x5c,iVar2,iVar8);
		      bVar1 = iVar2 != iVar8;
		      iVar8 = iVar2;
		    } while (bVar1);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar7 = *(int **)(iVar4 + 0x4c);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3530,1,0,1,0,0,0,0);
		    iVar4 = *piVar7;
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		              (piVar7,uVar3,*(undefined4 *)(iVar4 + 0x2d4));
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    iVar8 = *param1;
		    uVar6 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x158) * 4))
		                      (param1,*(undefined4 *)(iVar8 + 0x15c));
		    iVar4 = func_ii_8093(uVar6,
		                         Method_UI_Windows_BaseWindow_BankOptionInfoWindowArgs__get_WindowArgs__);
		    Gameplay_Bank_Controller_BankController__BuyOption
		              (uVar3,*(undefined4 *)(*(int *)(iVar4 + 0x18) + 0xc),iVar8);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000FB4 RID: 4020
		// (set) Token: 0x06004D89 RID: 19849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FB4")]
		public override BankOptionInfoWindow View
		{
			[Token(Token = "0x6004D89")]
			[Address(RVA = "0x9BC1", Offset = "0x9BC1", VA = "0x9BC1", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004D8A RID: 19850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D8A")]
		[Address(RVA = "0x9BC2", Offset = "0x9BC2", VA = "0x9BC2")]
		private void BankOptionViewOnBuyButtonClickEvent(IBankOptionView bankOptionView)
		{
		/* --- GHIDRA: BankOptionViewOnBuyButtonClickEvent ---
		void Gameplay_Bank_Controller_BankOptionInfoWindowMediator__BankOptionViewOnBuyButtonClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a597f9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_BankOptionInfoWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BankOptionArtikulContainerData__get_Count__);
		    DAT_ram_00a597f9 = '\x01';
		  }
		  iVar2 = param1[6];
		  param1[6] = iVar2 + 1;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_8093(param1_00,
		                       Method_UI_Windows_BaseWindow_BankOptionInfoWindowArgs__get_WindowArgs__);
		  if (*(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x18) + 0xc) + 0x60) + 0xc) + -1 < iVar2 + 1) {
		    param1[6] = 0;
		  }
		  Gameplay_Bank_Controller_BankOptionInfoWindowMediator__OptionArtikulsReceivedEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004D8B RID: 19851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D8B")]
		[Address(RVA = "0x9BC3", Offset = "0x9BC3", VA = "0x9BC3")]
		private void PrevButtonClickHandler()
		{
		/* --- GHIDRA: PrevButtonClickHandler ---
		void Gameplay_Bank_Controller_BankOptionInfoWindowMediator__PrevButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a597fa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_BankOptionInfoWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BankOptionArtikulContainerData__get_Count__);
		    DAT_ram_00a597fa = '\x01';
		  }
		  iVar1 = param1[6];
		  param1[6] = iVar1 + -1;
		  if (iVar1 + -1 < 0) {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar1 = func_ii_8093(param1_00,
		                         Method_UI_Windows_BaseWindow_BankOptionInfoWindowArgs__get_WindowArgs__);
		    param1[6] = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x18) + 0xc) + 0x60) + 0xc) + -1;
		  }
		  Gameplay_Bank_Controller_BankOptionInfoWindowMediator__OptionArtikulsReceivedEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004D8C RID: 19852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D8C")]
		[Address(RVA = "0x9BC4", Offset = "0x9BC4", VA = "0x9BC4")]
		private void NextButtonClickHandler()
		{
		/* --- GHIDRA: NextButtonClickHandler ---
		void Gameplay_Bank_Controller_BankOptionInfoWindowMediator__NextButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a597fb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankOptionInfoWindow__Dispose__
		              );
		    DAT_ram_00a597fb = '\x01';
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankOptionInfoWindow__Dispose__
		            );
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		            (param1,0,*(undefined4 *)(*param1 + 0x144));
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x160) * 4))
		            (param1,0,*(undefined4 *)(*param1 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x06004D8D RID: 19853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D8D")]
		[Address(RVA = "0x9BC5", Offset = "0x9BC5", VA = "0x9BC5", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Bank_Controller_BankOptionInfoWindowMediator__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a597fc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PaymentBonusModel__PaymentBonusEvents__PaymentBonusController__BankPaymentBonusView___ctor__
		              );
		    DAT_ram_00a597fc = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_PaymentBonusModel__PaymentBonusEvents__PaymentBonusController__BankPaymentBonusView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04002A45 RID: 10821
		[Token(Token = "0x4002A45")]
		[FieldOffset(Offset = "0x18")]
		private int _currentIndex;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Bank_Controller_BankOptionInfoWindowMediator__set_Events
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  uint param2_00;
		  
		  if (DAT_ram_00a597f5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_BankOptionInfoWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BankOptionArtikulContainerData__get_Count__);
		    DAT_ram_00a597f5 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = func_ii_8093(uVar1,Method_UI_Windows_BaseWindow_BankOptionInfoWindowArgs__get_WindowArgs__
		                      );
		  iVar3 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x18) + 0xc) + 0x60) + 0xc);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x40),0);
		  param2_00 = (uint)(1 < iVar3);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2_00,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x44),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2_00,0);
		  Gameplay_Bank_Controller_BankOptionInfoWindowMediator__OptionArtikulsReceivedEvent(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Bank_Controller_BankOptionInfoWindowMediator__set_View
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *param3_00;
		  undefined4 param2_00;
		  int iVar2;
		  
		  if (DAT_ram_00a597f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_View_IBankOptionView_TypeInfo);
		    DAT_ram_00a597f8 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar2 = *param2;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Bank_View_IBankOptionView_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        param3_00 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81072d1b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  param3_00 = (uint *)func_ii_1080(param2,Gameplay_Bank_View_IBankOptionView_TypeInfo,0);
		code_r0x81072d1b:
		  param2_00 = (**(code **)((ulonglong)*param3_00 * 4))(param2,param3_00[1]);
		  Gameplay_Bank_Controller_BankController__RequestActivePromotions(param1_00,param2_00,param3_00);
		  return;
		}
		*/

}
