using System;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Aprs.Events;
using Gameplay.Aprs.Model;
using Gameplay.Aprs.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Aprs.Controller
{
	// Token: 0x02000D70 RID: 3440
	[Token(Token = "0x2000D70")]
	public class AprInfoWindowMediator : AbstractViewMediator<AprsModel, AprsEvents, AprsController, AprInfoWindow>
	{
		// Token: 0x06005440 RID: 21568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005440")]
		[Address(RVA = "0xA1F7", Offset = "0xA1F7", VA = "0xA1F7", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Aprs_Controller_AprInfoWindowMediator__Dispose
		               (undefined4 param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a5944d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AprsModel__AprsEvents__AprsController__AprInfoWindow___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_AprDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_UserOnOnUserAprChangedEvent__)
		    ;
		    DAT_ram_00a5944d = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_AprsModel__AprsEvents__AprsController__AprInfoWindow___ctor__
		            );
		  param1_01 = *(int *)(param2 + 8);
		  if (param1_01 == *(int *)(param2 + 0x14)) {
		    param1_00 = unnamed_function_1417(System_Action_AprDicWrapper__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_UserOnOnUserAprChangedEvent__,0
		              );
		    Core_Data_UserData__remove_OnUserLevelChangedEvent(param1_01,param1_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005441 RID: 21569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005441")]
		[Address(RVA = "0xA1F8", Offset = "0xA1F8", VA = "0xA1F8")]
		public AprInfoWindowMediator(AprsModel model, AprsEvents events, AprsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Aprs_Controller_AprInfoWindowMediator___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5944e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AprsModel__AprsEvents__AprsController__AprInfoWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Events_AprsEvents_AprChangedEventDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_AprChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_HandleDictionariesChangeEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_OwnerChangedEvent__);
		    DAT_ram_00a5944e = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(Gameplay_Aprs_Events_AprsEvents_AprChangedEventDelegate_TypeInfo);
		    Gameplay_Aprs_Events_AprsEvents___ctor
		              (uVar3,param1,Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_AprChangedEvent__,
		               param1);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = Gameplay_Aprs_Events_AprsEvents_AprChangedEventDelegate_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((Gameplay_Aprs_Events_AprsEvents_AprChangedEventDelegate_TypeInfo != *piVar4) ||
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
		               Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_OwnerChangedEvent__,0);
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_HandleDictionariesChangeEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
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
		    uVar3 = unnamed_function_1417(Gameplay_Aprs_Events_AprsEvents_AprChangedEventDelegate_TypeInfo);
		    Gameplay_Aprs_Events_AprsEvents___ctor
		              (uVar3,param1,Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_AprChangedEvent__,
		               param1);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = Gameplay_Aprs_Events_AprsEvents_AprChangedEventDelegate_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((Gameplay_Aprs_Events_AprsEvents_AprChangedEventDelegate_TypeInfo != *piVar4) ||
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
		               Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_OwnerChangedEvent__,0);
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_HandleDictionariesChangeEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1))
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

		// Token: 0x17001126 RID: 4390
		// (set) Token: 0x06005442 RID: 21570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001126")]
		public override AprsEvents Events
		{
			[Token(Token = "0x6005442")]
			[Address(RVA = "0xA1F9", Offset = "0xA1F9", VA = "0xA1F9", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06005443 RID: 21571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005443")]
		[Address(RVA = "0xA1FA", Offset = "0xA1FA", VA = "0xA1FA")]
		private void HandleDictionariesChangeEvent()
		{
		/* --- GHIDRA: HandleDictionariesChangeEvent ---
		void Gameplay_Aprs_Controller_AprInfoWindowMediator__HandleDictionariesChangeEvent
		               (int param1,undefined4 param2)
		
		{
		  Gameplay_Aprs_Controller_AprInfoWindowMediator__ShowApr
		            (param1,*(undefined4 *)(param1 + 0x1c),param1);
		  return;
		}
		*/

		}

		// Token: 0x06005444 RID: 21572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005444")]
		[Address(RVA = "0xA1FB", Offset = "0xA1FB", VA = "0xA1FB")]
		private void OwnerChangedEvent()
		{
		/* --- GHIDRA: OwnerChangedEvent ---
		void Gameplay_Aprs_Controller_AprInfoWindowMediator__OwnerChangedEvent
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  if (param2 == *(int *)(param1 + 0x1c)) {
		    Gameplay_Aprs_Controller_AprInfoWindowMediator__ShowApr(param1,param2,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005445 RID: 21573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005445")]
		[Address(RVA = "0xA1FC", Offset = "0xA1FC", VA = "0xA1FC")]
		private void AprChangedEvent(AprData aprData, uint medalId)
		{
		/* --- GHIDRA: AprChangedEvent ---
		void Gameplay_Aprs_Controller_AprInfoWindowMediator__AprChangedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59450 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19888);
		    DAT_ram_00a59450 = '\x01';
		  }
		  local_4 = *(undefined4 *)(*(int *)(param2 + 0x10) + 0xc);
		  uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_19888,uVar1,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  Gameplay_Aprs_Controller_AprInfoWindowMediator__ShowApr
		            (param1,*(undefined4 *)(param1 + 0x1c),auStack_10);
		  return;
		}
		*/

		}

		// Token: 0x06005446 RID: 21574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005446")]
		[Address(RVA = "0xA1FD", Offset = "0xA1FD", VA = "0xA1FD")]
		private void UserOnOnUserAprChangedEvent(AprDicWrapper obj)
		{
		/* --- GHIDRA: UserOnOnUserAprChangedEvent ---
		void Gameplay_Aprs_Controller_AprInfoWindowMediator__UserOnOnUserAprChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a59451 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AprsModel__AprsEvents__AprsController__AprInfoWindow__set_View__
		              );
		    DAT_ram_00a59451 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Aprs_Controller_AprInfoWindowMediator__set_View(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Aprs_Controller_AprInfoWindowMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17001127 RID: 4391
		// (set) Token: 0x06005447 RID: 21575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001127")]
		public override AprInfoWindow View
		{
			[Token(Token = "0x6005447")]
			[Address(RVA = "0xA1FE", Offset = "0xA1FE", VA = "0xA1FE", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06005448 RID: 21576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005448")]
		[Address(RVA = "0xA1FF", Offset = "0xA1FF", VA = "0xA1FF")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Aprs_Controller_AprInfoWindowMediator__ResetView(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int iVar4;
		  uint param2_00;
		  
		  if (DAT_ram_00a59453 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_BuyButtonClicked__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_ShowNext__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_ShowPrev__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_UseButtonClickHandler__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_BaseWindow_AprInfoWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData__IndexOf__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData__get_Count__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a59453 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_ShowPrev__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x40) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_ShowNext__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x4c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_BuyButtonClicked__,0
		            );
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x48) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_UseButtonClickHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x3c);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x40);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_8093(uVar2,Method_UI_Windows_BaseWindow_AprInfoWindowArgs__get_WindowArgs__);
		  param2_00 = (uint)(1 < *(int *)(*(int *)(iVar1 + 0x1c) + 0xc));
		  System_Linq_Enumerable__First_object_(param1_00,param2_00,0);
		  System_Linq_Enumerable__First_object_(uVar3,param2_00,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_8093(uVar2,Method_UI_Windows_BaseWindow_AprInfoWindowArgs__get_WindowArgs__);
		  iVar4 = *(int *)(*(int *)(iVar1 + 0x1c) + 0xc);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_8093(uVar2,Method_UI_Windows_BaseWindow_AprInfoWindowArgs__get_WindowArgs__);
		  if (1 < iVar4) {
		    uVar3 = *(undefined4 *)(iVar1 + 0x1c);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar1 = func_ii_8093(uVar2,Method_UI_Windows_BaseWindow_AprInfoWindowArgs__get_WindowArgs__);
		    iVar1 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                      (uVar3,*(undefined4 *)(iVar1 + 0x18),
		                       Method_System_Collections_Generic_List_AprData__IndexOf__);
		    param1[6] = iVar1;
		    if (DAT_ram_00a5945a == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_UI_Windows_BaseWindow_AprInfoWindowArgs__get_WindowArgs__);
		      Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData__get_Item__);
		      DAT_ram_00a5945a = '\x01';
		    }
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar1 = func_ii_8093(uVar2,Method_UI_Windows_BaseWindow_AprInfoWindowArgs__get_WindowArgs__);
		    uVar2 = System_Linq_Enumerable__ToList_object_
		                      (*(undefined4 *)(iVar1 + 0x1c),param1[6],
		                       Method_System_Collections_Generic_List_AprData__get_Item__);
		    Gameplay_Aprs_Controller_AprInfoWindowMediator__ShowApr(param1,uVar2,param1);
		    return;
		  }
		  Gameplay_Aprs_Controller_AprInfoWindowMediator__ShowApr
		            (param1,*(undefined4 *)(iVar1 + 0x18),param1);
		  return;
		}
		*/

		}

		// Token: 0x06005449 RID: 21577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005449")]
		[Address(RVA = "0xA200", Offset = "0xA200", VA = "0xA200")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Aprs_Controller_AprInfoWindowMediator__SetupView(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59454 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    DAT_ram_00a59454 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Aprs_Controller_AprsController__UserOnOnUserCultChangedEvent
		            (param1_00,*(undefined4 *)(*(int *)(*(int *)(param1[7] + 0x14) + 0x10) + 0xc),param1);
		  return;
		}
		*/

		}

		// Token: 0x0600544A RID: 21578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600544A")]
		[Address(RVA = "0xA201", Offset = "0xA201", VA = "0xA201")]
		private void UseButtonClickHandler()
		{
		/* --- GHIDRA: UseButtonClickHandler ---
		void Gameplay_Aprs_Controller_AprInfoWindowMediator__UseButtonClickHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59455 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AprsModel__AprsEvents__AprsController__AprInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14325);
		    DAT_ram_00a59455 = '\x01';
		  }
		  iVar1 = Gameplay_Aprs_Controller_AprInfoWindowMediator__BuyButtonClicked(param1,auStack_10);
		  if (iVar1 == 0) {
		    local_4 = *(undefined4 *)(*(int *)(param1 + 8) + 0x30);
		    uVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    uVar2 = func_ii_4419(StringLiteral_14325,uVar2,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600544B RID: 21579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600544B")]
		[Address(RVA = "0xA202", Offset = "0xA202", VA = "0xA202")]
		private void BuyButtonClicked()
		{
		/* --- GHIDRA: BuyButtonClicked ---
		uint Gameplay_Aprs_Controller_AprInfoWindowMediator__BuyButtonClicked(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a59456 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AprsModel__AprsEvents__AprsController__AprInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_AprData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_HandleBuyAprConfirmation__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountHandler_TypeInfo);
		    DAT_ram_00a59456 = '\x01';
		  }
		  iVar4 = *(int *)(*(int *)(param1 + 8) + 0x30);
		  if (iVar4 < 1) {
		    param1_00 = *(undefined4 *)(param1 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_AprData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_HandleBuyAprConfirmation__,0);
		    uVar2 = Gameplay_Aprs_View_ConfirmBuyAprWindow__get_WindowId(param1_00,uVar2,param1);
		    param1_01 = *(int **)(*(int *)(param1 + 8) + 0x2c);
		    if (param1_01 != (int *)0x0) {
		      iVar5 = *param1_01;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Gameplay_Discounts_Model_IDiscountHandler_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x810071d8;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(param1_01,Gameplay_Discounts_Model_IDiscountHandler_TypeInfo,0);
		code_r0x810071d8:
		      (**(code **)((ulonglong)*puVar3 * 4))(param1_01,uVar2,puVar3[1]);
		    }
		  }
		  return (uint)(iVar4 < 1);
		}
		*/

		}

		// Token: 0x0600544C RID: 21580 RVA: 0x0000F378 File Offset: 0x0000D578
		[Token(Token = "0x600544C")]
		[Address(RVA = "0xA203", Offset = "0xA203", VA = "0xA203")]
		private bool TryShowBuyAprConfirmation()
		{
		/* --- GHIDRA: TryShowBuyAprConfirmation ---
		void Gameplay_Aprs_Controller_AprInfoWindowMediator__TryShowBuyAprConfirmation
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined8 local_34;
		  undefined8 local_2c;
		  undefined4 local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59457 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AprInfoWindowMediator__HandleBuyAprConfirmation_d__17___
		              );
		    DAT_ram_00a59457 = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_34,0);
		  local_18 = local_2c;
		  local_24 = 0xffffffff;
		  local_20 = local_34;
		  local_10 = param1;
		  local_c = param2;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_AccountsController__HandleDictsChangedEvent_d__6_
		            (&local_20,&local_24,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AprInfoWindowMediator__HandleBuyAprConfirmation_d__17___
		            );
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600544D RID: 21581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600544D")]
		[Address(RVA = "0xA204", Offset = "0xA204", VA = "0xA204")]
		private void HandleBuyAprConfirmation(AprData data)
		{
		/* --- GHIDRA: HandleBuyAprConfirmation ---
		void Gameplay_Aprs_Controller_AprInfoWindowMediator__HandleBuyAprConfirmation
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a59458 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_BaseWindow_AprInfoWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData__get_Count__);
		    DAT_ram_00a59458 = '\x01';
		  }
		  iVar3 = param1[6];
		  param1[6] = iVar3 + 1;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = func_ii_8093(uVar1,Method_UI_Windows_BaseWindow_AprInfoWindowArgs__get_WindowArgs__);
		  if (*(int *)(*(int *)(iVar2 + 0x1c) + 0xc) + -1 < iVar3 + 1) {
		    param1[6] = 0;
		  }
		  if (DAT_ram_00a5945a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_BaseWindow_AprInfoWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData__get_Item__);
		    DAT_ram_00a5945a = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = func_ii_8093(uVar1,Method_UI_Windows_BaseWindow_AprInfoWindowArgs__get_WindowArgs__);
		  uVar1 = System_Linq_Enumerable__ToList_object_
		                    (*(undefined4 *)(iVar2 + 0x1c),param1[6],
		                     Method_System_Collections_Generic_List_AprData__get_Item__);
		  Gameplay_Aprs_Controller_AprInfoWindowMediator__ShowApr(param1,uVar1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600544E RID: 21582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600544E")]
		[Address(RVA = "0xA205", Offset = "0xA205", VA = "0xA205")]
		private void ShowNext()
		{
		/* --- GHIDRA: ShowNext ---
		void Gameplay_Aprs_Controller_AprInfoWindowMediator__ShowNext(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a59459 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_BaseWindow_AprInfoWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData__get_Count__);
		    DAT_ram_00a59459 = '\x01';
		  }
		  iVar2 = param1[6];
		  param1[6] = iVar2 + -1;
		  if (iVar2 + -1 < 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar2 = func_ii_8093(uVar1,Method_UI_Windows_BaseWindow_AprInfoWindowArgs__get_WindowArgs__);
		    param1[6] = *(int *)(*(int *)(iVar2 + 0x1c) + 0xc) + -1;
		  }
		  if (DAT_ram_00a5945a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_BaseWindow_AprInfoWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData__get_Item__);
		    DAT_ram_00a5945a = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = func_ii_8093(uVar1,Method_UI_Windows_BaseWindow_AprInfoWindowArgs__get_WindowArgs__);
		  uVar1 = System_Linq_Enumerable__ToList_object_
		                    (*(undefined4 *)(iVar2 + 0x1c),param1[6],
		                     Method_System_Collections_Generic_List_AprData__get_Item__);
		  Gameplay_Aprs_Controller_AprInfoWindowMediator__ShowApr(param1,uVar1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600544F RID: 21583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600544F")]
		[Address(RVA = "0xA206", Offset = "0xA206", VA = "0xA206")]
		private void ShowPrev()
		{
		/* --- GHIDRA: ShowPrev ---
		void Gameplay_Aprs_Controller_AprInfoWindowMediator__ShowPrev
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5945a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_BaseWindow_AprInfoWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData__get_Item__);
		    DAT_ram_00a5945a = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = func_ii_8093(uVar1,Method_UI_Windows_BaseWindow_AprInfoWindowArgs__get_WindowArgs__);
		  uVar1 = System_Linq_Enumerable__ToList_object_
		                    (*(undefined4 *)(iVar2 + 0x1c),param1[6],
		                     Method_System_Collections_Generic_List_AprData__get_Item__);
		  Gameplay_Aprs_Controller_AprInfoWindowMediator__ShowApr(param1,uVar1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06005450 RID: 21584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005450")]
		[Address(RVA = "0xA207", Offset = "0xA207", VA = "0xA207")]
		private void ShowApr(int index)
		{
		/* --- GHIDRA: ShowApr ---
		void Gameplay_Aprs_Controller_AprInfoWindowMediator__ShowApr
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 *puVar6;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5945b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AprsModel__AprsEvents__AprsController__AprInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountHandler_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27180);
		    DAT_ram_00a5945b = '\x01';
		  }
		  param1[7] = param2;
		  iVar4 = *(int *)(param1[2] + 0x14);
		  iVar5 = *(int *)(param1[2] + 8);
		  local_4 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x1c) + 0x10) + 0xc);
		  uVar2 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_27180,uVar2,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		  if (iVar5 == iVar4) {
		    if (DAT_ram_00a59431 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_SortedList_uint__MedalInfo__get_Count__);
		      DAT_ram_00a59431 = '\x01';
		    }
		    if (*(int *)(*(int *)(param2 + 0x28) + 0x10) < 1) {
		      Gameplay_Aprs_Controller_AprInfoWindowMediator__ShowApr(param1,param2,param1);
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      puVar6 = (undefined4 *)(iVar4 + 0x48);
		    }
		    else {
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar4 + 0x48),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,(uint)(*(int *)(*(int *)(*(int *)(param2 + 0x1c) + 0x10) + 0xc) !=
		                             *(int *)(*(int *)(*(int *)(param1[2] + 8) + 0x34) + 0x1c)),0);
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      puVar6 = (undefined4 *)(iVar4 + 0x4c);
		    }
		  }
		  else {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar4 + 0x48),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,0,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    puVar6 = (undefined4 *)(iVar4 + 0x4c);
		  }
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*puVar6,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = param1[7];
		  if (DAT_ram_00a593f2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    DAT_ram_00a593f2 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(iVar4 + 0x44);
		  uVar2 = UI_Wiki_WikiUriRouter__SetData(*(undefined4 *)(*(int *)(iVar5 + 0x1c) + 0x10),0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1_00,uVar2,0);
		  Gameplay_Aprs_View_AprInfoView__get_DurationPrefix(*(undefined4 *)(iVar4 + 0x54),iVar5,param1);
		  *(int *)(*(int *)(iVar4 + 0x58) + 0x18) = iVar5;
		  param1_01 = *(int **)(param1[2] + 0x2c);
		  if (param1_01 != (int *)0x0) {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = *(undefined4 *)(iVar4 + 0x58);
		    uVar1 = 0;
		    iVar4 = *param1_01;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Discounts_Model_IDiscountHandler_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8100699a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,Gameplay_Discounts_Model_IDiscountHandler_TypeInfo,0);
		code_r0x8100699a:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_01,uVar2,puVar3[1]);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: ShowApr ---
		void Gameplay_Aprs_Controller_AprInfoWindowMediator__ShowApr
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 *puVar6;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5945b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AprsModel__AprsEvents__AprsController__AprInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountHandler_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27180);
		    DAT_ram_00a5945b = '\x01';
		  }
		  param1[7] = param2;
		  iVar4 = *(int *)(param1[2] + 0x14);
		  iVar5 = *(int *)(param1[2] + 8);
		  local_4 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x1c) + 0x10) + 0xc);
		  uVar2 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_27180,uVar2,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		  if (iVar5 == iVar4) {
		    if (DAT_ram_00a59431 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_SortedList_uint__MedalInfo__get_Count__);
		      DAT_ram_00a59431 = '\x01';
		    }
		    if (*(int *)(*(int *)(param2 + 0x28) + 0x10) < 1) {
		      Gameplay_Aprs_Controller_AprInfoWindowMediator__ShowApr(param1,param2,param1);
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      puVar6 = (undefined4 *)(iVar4 + 0x48);
		    }
		    else {
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar4 + 0x48),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,(uint)(*(int *)(*(int *)(*(int *)(param2 + 0x1c) + 0x10) + 0xc) !=
		                             *(int *)(*(int *)(*(int *)(param1[2] + 8) + 0x34) + 0x1c)),0);
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      puVar6 = (undefined4 *)(iVar4 + 0x4c);
		    }
		  }
		  else {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar4 + 0x48),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,0,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    puVar6 = (undefined4 *)(iVar4 + 0x4c);
		  }
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*puVar6,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = param1[7];
		  if (DAT_ram_00a593f2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    DAT_ram_00a593f2 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(iVar4 + 0x44);
		  uVar2 = UI_Wiki_WikiUriRouter__SetData(*(undefined4 *)(*(int *)(iVar5 + 0x1c) + 0x10),0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1_00,uVar2,0);
		  Gameplay_Aprs_View_AprInfoView__get_DurationPrefix(*(undefined4 *)(iVar4 + 0x54),iVar5,param1);
		  *(int *)(*(int *)(iVar4 + 0x58) + 0x18) = iVar5;
		  param1_01 = *(int **)(param1[2] + 0x2c);
		  if (param1_01 != (int *)0x0) {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = *(undefined4 *)(iVar4 + 0x58);
		    uVar1 = 0;
		    iVar4 = *param1_01;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Discounts_Model_IDiscountHandler_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8100699a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,Gameplay_Discounts_Model_IDiscountHandler_TypeInfo,0);
		code_r0x8100699a:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_01,uVar2,puVar3[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005451 RID: 21585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005451")]
		[Address(RVA = "0xA208", Offset = "0xA208", VA = "0xA208")]
		private void ShowApr(AprData aprData)
		{
		}

		// Token: 0x06005452 RID: 21586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005452")]
		[Address(RVA = "0xA209", Offset = "0xA209", VA = "0xA209")]
		private void ValidateOpportunityToBuy(AprData data)
		{
		}

		// Token: 0x04002DA4 RID: 11684
		[Token(Token = "0x4002DA4")]
		[FieldOffset(Offset = "0x18")]
		private int _currentIndex;

		// Token: 0x04002DA5 RID: 11685
		[Token(Token = "0x4002DA5")]
		[FieldOffset(Offset = "0x1C")]
		private AprData _currentAprData;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Aprs_Controller_AprInfoWindowMediator__set_Events(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *param3;
		  int *param1_00;
		  undefined4 uVar3;
		  
		  param3 = (uint *)0x0;
		  if (DAT_ram_00a5944f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AprsModel__AprsEvents__AprsController__AprInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountHandler_TypeInfo);
		    DAT_ram_00a5944f = '\x01';
		  }
		  param1_00 = *(int **)(param1[2] + 0x2c);
		  if (param1_00 != (int *)0x0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x58);
		    uVar1 = 0;
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Discounts_Model_IDiscountHandler_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          param3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x810065b3;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    param3 = (uint *)func_ii_1080(param1_00,Gameplay_Discounts_Model_IDiscountHandler_TypeInfo,0);
		code_r0x810065b3:
		    (**(code **)((ulonglong)*param3 * 4))(param1_00,uVar3,param3[1]);
		  }
		  Gameplay_Aprs_Controller_AprInfoWindowMediator__ShowApr(param1,param1[7],param3);
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Aprs_Controller_AprInfoWindowMediator__set_View(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a59452 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_BuyButtonClicked__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_ShowNext__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_ShowPrev__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_UseButtonClickHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a59452 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_ShowPrev__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x40) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_ShowNext__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x4c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_BuyButtonClicked__,0
		            );
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x48) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Aprs_Controller_AprInfoWindowMediator_UseButtonClickHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  return;
		}
		*/

}
