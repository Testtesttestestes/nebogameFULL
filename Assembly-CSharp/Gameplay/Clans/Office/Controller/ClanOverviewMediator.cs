using System;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.ClanCreationTab;
using Gameplay.Clans.Office.View.ClanOverviewTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Common;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A6D RID: 2669
	[Token(Token = "0x2000A6D")]
	public class ClanOverviewMediator : AbstractViewMediator<ClanInfoModel, ClanInfoEvents, ClanInfoController, ClanOverview>, IHideableMediator
	{
		// Token: 0x06003F59 RID: 16217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F59")]
		[Address(RVA = "0x8E14", Offset = "0x8E14", VA = "0x8E14")]
		public ClanOverviewMediator(ClanInfoModel model, ClanInfoEvents events, ClanInfoController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_ClanOverviewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57666 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanOverview__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ClanTypeListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanOverviewMediator_ChangeClanButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanOverviewMediator_DescriptionInputChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanOverviewMediator_FractionClanClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanOverviewMediator_NameInputChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanOverviewMediator_ZigguratButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_string__RemoveListener__);
		    DAT_ram_00a57666 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x1c) + 0x20) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanOverviewMediator_ChangeClanButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x1c) + 0x18) + 0x10) + 0x130);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		    func_ii_7054(uVar1,param1,
		                 Method_Gameplay_Clans_Office_Controller_ClanOverviewMediator_NameInputChangedEventHandler__
		                 ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_string__RemoveListener__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x1c) + 0x1c) + 0x10) + 0x130);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		    func_ii_7054(uVar1,param1,
		                 Method_Gameplay_Clans_Office_Controller_ClanOverviewMediator_DescriptionInputChangedEventHandler__
		                 ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_string__RemoveListener__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x1c) + 0x24);
		    uVar1 = unnamed_function_1417(System_Action_ClanTypeListElement__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanOverviewMediator_FractionClanClickedEventHandler__
		               ,0);
		    Gameplay_Clans_Office_View_ClanCreationTab_ClanTypeListElement__add_ClickedEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x24) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanOverviewMediator_ZigguratButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x1c) + 0x20) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanOverviewMediator_ChangeClanButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x1c) + 0x18) + 0x10) + 0x130);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		    func_ii_7054(uVar1,param1,
		                 Method_Gameplay_Clans_Office_Controller_ClanOverviewMediator_NameInputChangedEventHandler__
		                 ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x1c) + 0x1c) + 0x10) + 0x130);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		    func_ii_7054(uVar1,param1,
		                 Method_Gameplay_Clans_Office_Controller_ClanOverviewMediator_DescriptionInputChangedEventHandler__
		                 ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x1c) + 0x24);
		    uVar1 = unnamed_function_1417(System_Action_ClanTypeListElement__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanOverviewMediator_FractionClanClickedEventHandler__
		               ,0);
		    Gameplay_Clans_Office_View_ClanCreationTab_ClanCreationView___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x24) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanOverviewMediator_ZigguratButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    Gameplay_Clans_Office_Controller_ClanOverviewMediator__set_View(param1,param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    if (*(char *)(iVar2 + 9) != '\0') {
		      Gameplay_Clans_Office_Controller_ClanOverviewMediator__ClanTreasuryRequestedEventHandler
		                (param1,param1);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000CA0 RID: 3232
		// (set) Token: 0x06003F5A RID: 16218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA0")]
		public override ClanOverview View
		{
			[Token(Token = "0x6003F5A")]
			[Address(RVA = "0x8E15", Offset = "0x8E15", VA = "0x8E15", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003F5B RID: 16219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F5B")]
		[Address(RVA = "0x8E16", Offset = "0x8E16", VA = "0x8E16")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Office_Controller_ClanOverviewMediator__Init(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57668 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanOverview__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57668 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x80dc0584;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80dc0584:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,CONCAT44(in_register_20000014,puVar2[1]));
		  Core_Gameplay_Managers_WorldManager__GoToUserIsleById
		            (uVar3,*(undefined8 *)(*(int *)(param1 + 8) + 0x10),0);
		  uVar3 = System_Uri___ctor(0);
		  uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar3,0);
		  UI_Windows_PopupController__Close(uVar3,2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F5C RID: 16220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F5C")]
		[Address(RVA = "0x8E17", Offset = "0x8E17", VA = "0x8E17")]
		private void ZigguratButtonClickedEventHandler()
		{
		/* --- GHIDRA: ZigguratButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanOverviewMediator__ZigguratButtonClickedEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint param2_00;
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57669 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanOverview__get_Model__
		              );
		    DAT_ram_00a57669 = '\x01';
		  }
		  uVar1 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                    (param2,*(undefined4 *)
		                             (*(int *)(*(int *)(*(int *)(param1[2] + 0x30) + 8) + 0x10) + 0x18),0);
		  *(char *)((int)param1 + 0x21) = (char)uVar1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = 1;
		  if (((char)param1[8] == '\0') && (*(char *)((int)param1 + 0x21) == '\0')) {
		    param2_00 = (uint)(*(char *)((int)param1 + 0x22) != '\0');
		  }
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(*(int *)(iVar2 + 0x1c) + 0x20),param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F5D")]
		[Address(RVA = "0x8E18", Offset = "0x8E18", VA = "0x8E18")]
		private void NameInputChangedEventHandler(string name)
		{
		/* --- GHIDRA: NameInputChangedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanOverviewMediator__NameInputChangedEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint param2_00;
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5766a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanOverview__get_Model__
		              );
		    DAT_ram_00a5766a = '\x01';
		  }
		  uVar1 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                    (param2,*(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x30) + 8) + 0x14),0);
		  *(char *)((int)param1 + 0x22) = (char)uVar1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = 1;
		  if (((char)param1[8] == '\0') && (*(char *)((int)param1 + 0x21) == '\0')) {
		    param2_00 = (uint)(*(char *)((int)param1 + 0x22) != '\0');
		  }
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(*(int *)(iVar2 + 0x1c) + 0x20),param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F5E RID: 16222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F5E")]
		[Address(RVA = "0x8E19", Offset = "0x8E19", VA = "0x8E19")]
		private void DescriptionInputChangedEventHandler(string description)
		{
		/* --- GHIDRA: DescriptionInputChangedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanOverviewMediator__DescriptionInputChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  *(undefined1 *)((int)param1 + 0x22) = 0;
		  *(undefined2 *)(param1 + 8) = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanCreationTab_ClanTypeListElement__remove_ClickedEvent
		            (*(undefined4 *)(*(int *)(iVar1 + 0x1c) + 0x24),0,0);
		  Gameplay_Clans_Office_Controller_ClanOverviewMediator__FractionClanClickedEventHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003F5F RID: 16223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F5F")]
		[Address(RVA = "0x8E1A", Offset = "0x8E1A", VA = "0x8E1A")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Clans_Office_Controller_ClanOverviewMediator__ResetView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  byte bVar1;
		  uint param2_00;
		  int iVar2;
		  
		  param2_00 = 1;
		  bVar1 = *(byte *)(param1 + 8);
		  *(byte *)(param1 + 8) = bVar1 ^ 1;
		  Gameplay_Clans_Office_View_ClanCreationTab_ClanTypeListElement__remove_ClickedEvent
		            (param2,(uint)(bVar1 == 0),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (((char)param1[8] == '\0') && (*(char *)((int)param1 + 0x21) == '\0')) {
		    param2_00 = (uint)(*(char *)((int)param1 + 0x22) != '\0');
		  }
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(*(int *)(iVar2 + 0x1c) + 0x20),param2_00,0);
		  Gameplay_Clans_Office_Controller_ClanOverviewMediator__FractionClanClickedEventHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003F60 RID: 16224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F60")]
		[Address(RVA = "0x8E1B", Offset = "0x8E1B", VA = "0x8E1B")]
		private void FractionClanClickedEventHandler(ClanTypeListElement element)
		{
		/* --- GHIDRA: FractionClanClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanOverviewMediator__FractionClanClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar4;
		  
		  if (DAT_ram_00a5766b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a5766b = '\x01';
		  }
		  iVar4 = 0x1c;
		  if ((char)param1[8] == '\0') {
		    iVar4 = 0x18;
		  }
		  uVar3 = *(undefined4 *)((int)param1 + iVar4);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar3 = Core_Money_Money__op_Explicit(uVar3,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x1c) + 0x20) + 0xb8);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x230);
		        goto code_r0x80dc0461;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80dc0461:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  UI_Price_Price__SetColor(param1_00,*(undefined4 *)(*(int *)(iVar4 + 0x10) + 0x18),uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F61 RID: 16225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F61")]
		[Address(RVA = "0x8E1C", Offset = "0x8E1C", VA = "0x8E1C")]
		private void UpdateCostButton()
		{
		/* --- GHIDRA: UpdateCostButton ---
		void Gameplay_Clans_Office_Controller_ClanOverviewMediator__UpdateCostButton
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param5;
		  int iVar1;
		  undefined4 param2_00;
		  
		  iVar1 = 0x1c;
		  if ((char)param1[8] == '\0') {
		    iVar1 = 0x18;
		  }
		  param5 = *(undefined4 *)((int)param1 + iVar1);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x1c) + 0x18) + 0x10) + 0x160);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_Controller_ClanInfoController__CancelJoinRequestResultHandler
		            (param1_00,param2_00,
		             *(undefined4 *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x1c) + 0x1c) + 0x10) + 0x160),
		             (uint)*(byte *)(param1 + 8),param5,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F62 RID: 16226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F62")]
		[Address(RVA = "0x8E1D", Offset = "0x8E1D", VA = "0x8E1D")]
		private void ChangeClanButtonClickedEventHandler()
		{
		/* --- GHIDRA: ChangeClanButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanOverviewMediator__ChangeClanButtonClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5766c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanOverview__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanOverviewMediator_ClanTreasuryRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_ClanOverviewMediator_InitEventHandler__);
		    DAT_ram_00a5766c = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanOverviewMediator_InitEventHandler__,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x38);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanOverviewMediator_ClanTreasuryRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x38) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x38) = piVar4, *piVar4 != iVar1)) {
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
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanOverviewMediator_InitEventHandler__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x38);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanOverviewMediator_ClanTreasuryRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x38) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x38) = piVar4, *piVar4 != iVar1))
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

		// Token: 0x17000CA1 RID: 3233
		// (set) Token: 0x06003F63 RID: 16227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA1")]
		public override ClanInfoEvents Events
		{
			[Token(Token = "0x6003F63")]
			[Address(RVA = "0x8E1E", Offset = "0x8E1E", VA = "0x8E1E", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003F64 RID: 16228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F64")]
		[Address(RVA = "0x8E1F", Offset = "0x8E1F", VA = "0x8E1F")]
		private void ClanTreasuryRequestedEventHandler()
		{
		/* --- GHIDRA: ClanTreasuryRequestedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanOverviewMediator__ClanTreasuryRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint param2_00;
		  undefined4 param1_00;
		  undefined4 param4;
		  int iVar1;
		  undefined4 param2_01;
		  undefined4 param3;
		  
		  if (DAT_ram_00a5766d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanOverview__get_Model__
		              );
		    DAT_ram_00a5766d = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = param1[2];
		  param2_01 = *(undefined4 *)(iVar1 + 0x30);
		  param3 = *(undefined4 *)(iVar1 + 8);
		  param4 = Gameplay_Clans_Office_View_AboutClansTab_AboutClansView___ctor(iVar1,0);
		  Gameplay_Clans_Office_View_ClanOverviewTab_ClanOverview__get_ZigguratButton
		            (param1_00,param2_01,param3,param4,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  TMPro_TMP_InputField__set_text
		            (*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x1c) + 0x18) + 0x10),
		             *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1[2] + 0x30) + 8) + 0x10) + 0x18),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  TMPro_TMP_InputField__set_text
		            (*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x1c) + 0x1c) + 0x10),
		             *(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x30) + 8) + 0x14),0);
		  *(undefined1 *)((int)param1 + 0x22) = 0;
		  *(undefined2 *)(param1 + 8) = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanCreationTab_ClanTypeListElement__remove_ClickedEvent
		            (*(undefined4 *)(*(int *)(iVar1 + 0x1c) + 0x24),0,0);
		  Gameplay_Clans_Office_Controller_ClanOverviewMediator__FractionClanClickedEventHandler
		            (param1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = 1;
		  if (((char)param1[8] == '\0') && (*(char *)((int)param1 + 0x21) == '\0')) {
		    param2_00 = (uint)(*(char *)((int)param1 + 0x22) != '\0');
		  }
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(*(int *)(iVar1 + 0x1c) + 0x20),param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F65 RID: 16229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F65")]
		[Address(RVA = "0x8E20", Offset = "0x8E20", VA = "0x8E20")]
		private void InitEventHandler()
		{
		/* --- GHIDRA: InitEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanOverviewMediator__InitEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint param2_00;
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = 1;
		  if (((char)param1[8] == '\0') && (*(char *)((int)param1 + 0x21) == '\0')) {
		    param2_00 = (uint)(*(char *)((int)param1 + 0x22) != '\0');
		  }
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(*(int *)(iVar1 + 0x1c) + 0x20),param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F66 RID: 16230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F66")]
		[Address(RVA = "0x8E21", Offset = "0x8E21", VA = "0x8E21")]
		private void ValidateChangeButton()
		{
		}

		// Token: 0x06003F67 RID: 16231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F67")]
		[Address(RVA = "0x8E22", Offset = "0x8E22", VA = "0x8E22", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x0400239A RID: 9114
		[Token(Token = "0x400239A")]
		[FieldOffset(Offset = "0x18")]
		private ResourceSet _changeClanPrice;

		// Token: 0x0400239B RID: 9115
		[Token(Token = "0x400239B")]
		[FieldOffset(Offset = "0x1C")]
		private ResourceSet _changeToFractionClanPrice;

		// Token: 0x0400239C RID: 9116
		[Token(Token = "0x400239C")]
		[FieldOffset(Offset = "0x20")]
		private bool _fractionSelected;

		// Token: 0x0400239D RID: 9117
		[Token(Token = "0x400239D")]
		[FieldOffset(Offset = "0x21")]
		private bool _nameChanged;

		// Token: 0x0400239E RID: 9118
		[Token(Token = "0x400239E")]
		[FieldOffset(Offset = "0x22")]
		private bool _descriptionChanged;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Office_Controller_ClanOverviewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57667 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanOverview__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_21198);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21199);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21213);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21214);
		    DAT_ram_00a57667 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x1c) + 0x18);
		  uVar2 = Gameplay_Clans_Office_View_AboutClansTab_AboutClansView___ctor(param1[2],0);
		  uVar2 = Core_Extensions_Dict_DictExt__GetResourceSetParameter(uVar2,StringLiteral_21214,0);
		  Gameplay_UserInfo_View_PatternTextInput__get_Pattern(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x1c) + 0x1c);
		  uVar2 = Gameplay_Clans_Office_View_AboutClansTab_AboutClansView___ctor(param1[2],0);
		  uVar2 = Core_Extensions_Dict_DictExt__GetResourceSetParameter(uVar2,StringLiteral_21199,0);
		  Gameplay_UserInfo_View_PatternTextInput__get_Pattern(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x1c) + 0x18) + 0x10);
		  uVar2 = Gameplay_Clans_Office_View_AboutClansTab_AboutClansView___ctor(param1[2],0);
		  uVar2 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar2,StringLiteral_21213,0);
		  TMPro_TMP_InputField__get_characterLimit(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x1c) + 0x1c) + 0x10);
		  uVar2 = Gameplay_Clans_Office_View_AboutClansTab_AboutClansView___ctor(param1[2],0);
		  uVar2 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar2,StringLiteral_21198,0);
		  TMPro_TMP_InputField__get_characterLimit(uVar3,uVar2,0);
		  *(undefined1 *)((int)param1 + 0x22) = 0;
		  *(undefined2 *)(param1 + 8) = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanCreationTab_ClanTypeListElement__remove_ClickedEvent
		            (*(undefined4 *)(*(int *)(iVar1 + 0x1c) + 0x24),0,0);
		  Gameplay_Clans_Office_Controller_ClanOverviewMediator__FractionClanClickedEventHandler
		            (param1,param1);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Clans_Office_Controller_ClanOverviewMediator__set_Events
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Clans_Office_Controller_ClanOverviewMediator__FractionClanClickedEventHandler
		            (param1,param1);
		  return;
		}
		*/

}
