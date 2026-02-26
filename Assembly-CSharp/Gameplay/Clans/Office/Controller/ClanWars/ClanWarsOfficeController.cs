using System;
using System.Runtime.CompilerServices;
using Gameplay.Clans.ClanWars.Controller;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.Clans.Office.Controller.ClanWars
{
	// Token: 0x02000A84 RID: 2692
	[Token(Token = "0x2000A84")]
	public class ClanWarsOfficeController : AbstractController<ClanWarsOfficeModel, ClanWarsOfficeEvents>
	{
		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06004055 RID: 16469 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004056 RID: 16470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB3")]
		public ClanWarsController ClanWarsController
		{
			[Token(Token = "0x6004055")]
			[Address(RVA = "0x8F0F", Offset = "0x8F0F", VA = "0x8F0F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004056")]
			[Address(RVA = "0x8F10", Offset = "0x8F10", VA = "0x8F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x06004057 RID: 16471 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004058 RID: 16472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB4")]
		public ClanInfoController ClanInfoController
		{
			[Token(Token = "0x6004057")]
			[Address(RVA = "0x8F11", Offset = "0x8F11", VA = "0x8F11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004058")]
			[Address(RVA = "0x8F12", Offset = "0x8F12", VA = "0x8F12")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004059 RID: 16473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004059")]
		[Address(RVA = "0x8F13", Offset = "0x8F13", VA = "0x8F13")]
		public ClanWarsOfficeController(ClanWarsOfficeModel model, ClanWarsOfficeEvents events, ClanWarsController clanWarsController, ClanInfoController clanInfoController)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController___ctor
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  undefined4 param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a57714 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController_InitEventHandler__
		              );
		    DAT_ram_00a57714 = '\x01';
		  }
		  iVar3 = *(int *)param1[7];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x110) * 4))
		                    ((int *)param1[7],*(undefined4 *)(iVar3 + 0x114));
		  param1_01 = *(undefined4 *)(iVar1 + 8);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController_InitEventHandler__
		             ,0);
		  param1_00 = (int *)UnityEngine_UI_Image__set_sprite(param1_01,uVar2,0);
		  iVar3 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_00) ||
		          (*(int **)(iVar1 + 8) = param1_00, *param1_00 != iVar3)) {
		    System_Activator__CreateInstance(param1_00,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(char *)(param1[7] + 9) != '\0') {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar3 = *(int *)param1[7];
		    iVar3 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x100) * 4))
		                      ((int *)param1[7],*(undefined4 *)(iVar3 + 0x104));
		    Gameplay_Clans_Office_Model_ClanWarsOfficeModel___ctor
		              (uVar2,*(undefined4 *)(*(int *)(iVar3 + 0x30) + 0xc),0);
		    *(undefined1 *)((int)param1 + 9) = 1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600405A RID: 16474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600405A")]
		[Address(RVA = "0x8F14", Offset = "0x8F14", VA = "0x8F14", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController__HandleRun
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a57715 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController_InitEventHandler__
		              );
		    DAT_ram_00a57715 = '\x01';
		  }
		  iVar2 = **(int **)(param1 + 0x1c);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		                    (*(int **)(param1 + 0x1c),*(undefined4 *)(iVar2 + 0x114));
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController_InitEventHandler__
		             ,0);
		  param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		  iVar2 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 8) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *param1_01) &&
		     (*(int **)(iVar1 + 8) = param1_01, *param1_01 == iVar2)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_01,iVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600405B RID: 16475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600405B")]
		[Address(RVA = "0x8F15", Offset = "0x8F15", VA = "0x8F15", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController__HandleStop
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = *(int *)param1[7];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x100) * 4))
		                    ((int *)param1[7],*(undefined4 *)(iVar1 + 0x104));
		  Gameplay_Clans_Office_Model_ClanWarsOfficeModel___ctor
		            (param1_00,*(undefined4 *)(*(int *)(iVar1 + 0x30) + 0xc),0);
		  *(undefined1 *)((int)param1 + 9) = 1;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 8);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600405C RID: 16476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600405C")]
		[Address(RVA = "0x8F16", Offset = "0x8F16", VA = "0x8F16")]
		private void InitEventHandler()
		{
		/* --- GHIDRA: InitEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController__InitEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = *(int *)param1[7];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x100) * 4))
		                    ((int *)param1[7],*(undefined4 *)(iVar1 + 0x104));
		  Gameplay_Clans_Office_Model_ClanWarsOfficeModel___ctor
		            (param1_00,*(undefined4 *)(*(int *)(iVar1 + 0x30) + 0xc),0);
		  *(undefined1 *)((int)param1 + 9) = 1;
		  return;
		}
		*/

		}

		// Token: 0x0600405D RID: 16477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600405D")]
		[Address(RVA = "0x8F17", Offset = "0x8F17", VA = "0x8F17")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController__Init
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57716 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController_GetSeasonBankDistributionResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57716 = '\x01';
		  }
		  param1_00 = ServicesNamespace_ClanWarsService__ServerEventHandler
		                        (*(undefined4 *)(param1 + 0x20),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController_GetSeasonBankDistributionResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x0600405E RID: 16478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600405E")]
		[Address(RVA = "0x8F18", Offset = "0x8F18", VA = "0x8F18")]
		public void GetSeasonBankDistribution()
		{
		/* --- GHIDRA: GetSeasonBankDistribution ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController__GetSeasonBankDistribution
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a57717 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoGetSeasonBankDistributionAns_TypeInfo);
		    DAT_ram_00a57717 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_ClanWar_ProtoGetSeasonBankDistributionAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance
		              (param1_01,Protocol_ClanWar_ProtoGetSeasonBankDistributionAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Clans_Office_Model_ClanWarsOfficeModel__GetFilterDatas(param1_00,param1_01[3],0);
		  return;
		}
		*/

		}

		// Token: 0x0600405F RID: 16479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600405F")]
		[Address(RVA = "0x8F19", Offset = "0x8F19", VA = "0x8F19")]
		private void GetSeasonBankDistributionResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetSeasonBankDistributionResultHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController__GetSeasonBankDistributionResultHandler
		               (int param1,undefined4 param2,undefined8 param3,undefined4 param4,int param5,
		               undefined4 param6,undefined4 param7,undefined4 param8,undefined4 param9)
		
		{
		  int param1_00;
		  undefined4 param1_01;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a57718 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController_RequestPoliticsResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoRequestClanPolicyCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a57718 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Protocol_ClanWar_ProtoRequestClanPolicyCmd_TypeInfo);
		  Protocol_ClanWar_ProtoRequestClanPolicyCmd__pb__Google_Protobuf_IMessage_get_Descriptor
		            (param1_00,0);
		  *(undefined4 *)(param1_00 + 0x18) = param4;
		  *(undefined8 *)(param1_00 + 0x10) = param3;
		  *(undefined1 *)(param1_00 + 0xd) = (undefined1)param7;
		  *(undefined1 *)(param1_00 + 0xc) = (undefined1)param6;
		  if (param5 == 0) {
		    param5 = StringLiteral_5;
		  }
		  Protocol_ClanWar_ProtoRequestClanPolicyCmd__get_Title(param1_00,param5,0);
		  *(undefined4 *)(param1_00 + 0x1c) = param8;
		  *(undefined4 *)(param1_00 + 0x20) = param2;
		  param1_01 = ServicesNamespace_ClanWarsService__GetSeasonBankDistribution
		                        (*(undefined4 *)(param1 + 0x20),param1_00,0);
		  param1_02 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_02,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController_RequestPoliticsResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_01,param1_02,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06004060 RID: 16480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004060")]
		[Address(RVA = "0x8F1A", Offset = "0x8F1A", VA = "0x8F1A")]
		public void RequestPolitics(uint leagueId, ulong previousClanId, uint lastHonorRating, string title, bool readyForWar, bool onlyBlitz, uint linesCount)
		{
		/* --- GHIDRA: RequestPolitics ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController__RequestPolitics
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a57719 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoRequestClanPolicyAns_TypeInfo);
		    DAT_ram_00a57719 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_ClanWar_ProtoRequestClanPolicyAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_ClanWar_ProtoRequestClanPolicyAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Clans_Office_Model_ClanWarsOfficeModel__CreateClanList(param1_00,param1_01[3],0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004061 RID: 16481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004061")]
		[Address(RVA = "0x8F1B", Offset = "0x8F1B", VA = "0x8F1B")]
		private void RequestPoliticsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: RequestPoliticsResultHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController__RequestPoliticsResultHandler
		               (int param1,undefined4 param2,int param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  int param1_00;
		  undefined4 param1_01;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a5771a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController_RequestFirstPoliticsResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoRequestClanPolicyCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5771a = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Protocol_ClanWar_ProtoRequestClanPolicyCmd_TypeInfo);
		  Protocol_ClanWar_ProtoRequestClanPolicyCmd__pb__Google_Protobuf_IMessage_get_Descriptor
		            (param1_00,0);
		  *(undefined4 *)(param1_00 + 0x18) = 0;
		  *(undefined8 *)(param1_00 + 0x10) = 0;
		  *(undefined1 *)(param1_00 + 0xd) = (undefined1)param5;
		  *(undefined1 *)(param1_00 + 0xc) = (undefined1)param4;
		  if (param3 == 0) {
		    param3 = StringLiteral_5;
		  }
		  Protocol_ClanWar_ProtoRequestClanPolicyCmd__get_Title(param1_00,param3,0);
		  *(undefined4 *)(param1_00 + 0x1c) = param6;
		  *(undefined4 *)(param1_00 + 0x20) = param2;
		  param1_01 = ServicesNamespace_ClanWarsService__GetSeasonBankDistribution
		                        (*(undefined4 *)(param1 + 0x20),param1_00,0);
		  param1_02 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_02,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController_RequestFirstPoliticsResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_01,param1_02,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06004062 RID: 16482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004062")]
		[Address(RVA = "0x8F1C", Offset = "0x8F1C", VA = "0x8F1C")]
		public void RequestFirstPolitics(uint leagueId, string title, bool readyForWar, bool onlyBlitz, uint linesCount)
		{
		/* --- GHIDRA: RequestFirstPolitics ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController__RequestFirstPolitics
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a5771b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoRequestClanPolicyAns_TypeInfo);
		    DAT_ram_00a5771b = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_ClanWar_ProtoRequestClanPolicyAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_ClanWar_ProtoRequestClanPolicyAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Clans_Office_Model_ClanWarsOfficeModel__GetSeasonLeagueRewards(param1_00,param1_01[3],0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004063 RID: 16483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004063")]
		[Address(RVA = "0x8F1D", Offset = "0x8F1D", VA = "0x8F1D")]
		private void RequestFirstPoliticsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: RequestFirstPoliticsResultHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController__RequestFirstPoliticsResultHandler
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5771c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ClanWarsOfficeModel__ClanWarsOfficeEvents__Dispose__);
		    DAT_ram_00a5771c = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  *(undefined4 *)(param1 + 0x20) = 0;
		  MVC_AbstractController_object__object____ctor
		            (param1,
		             Method_MVC_AbstractController_ClanWarsOfficeModel__ClanWarsOfficeEvents__Dispose__);
		  return;
		}
		*/

		}

		// Token: 0x06004064 RID: 16484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004064")]
		[Address(RVA = "0x8F1E", Offset = "0x8F1E", VA = "0x8F1E", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5771d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanWarsView___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator_ShowClanPoliticsTab__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator_ShowClanWarsRewardsTab__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator_ShowHistoryTab__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator____ctor__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_IHideableMediator__TypeInfo);
		    DAT_ram_00a5771d = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanWarsView___ctor__
		            );
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___TypeInfo
		                        );
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator____ctor__);
		  uVar1 = unnamed_function_1417(System_Func_IHideableMediator__TypeInfo);
		  func_ii_19797(uVar1,param1,
		                Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator_ShowClanWarsRewardsTab__
		                ,0);
		  System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		            (param1_00,0,uVar1,
		             Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___Add__);
		  uVar1 = unnamed_function_1417(System_Func_IHideableMediator__TypeInfo);
		  func_ii_19797(uVar1,param1,
		                Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator_ShowClanPoliticsTab__
		                ,0);
		  System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		            (param1_00,1,uVar1,
		             Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___Add__);
		  uVar1 = unnamed_function_1417(System_Func_IHideableMediator__TypeInfo);
		  func_ii_19797(uVar1,param1,
		                Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeViewMediator_ShowHistoryTab__
		                ,0);
		  System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		            (param1_00,2,uVar1,
		             Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___Add__);
		  *(undefined4 *)(param1 + 0x24) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x040023D7 RID: 9175
		[Token(Token = "0x40023D7")]
		[FieldOffset(Offset = "0x20")]
		private ClanWarsService _clanWarsService;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_ClanInfoController ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController__set_ClanInfoController
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57713 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ClanWarsOfficeModel__ClanWarsOfficeEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClanWarsService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a57713 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_ClanWarsOfficeModel__ClanWarsOfficeEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ClanWarsService___);
		  *(undefined4 *)(param1 + 0x1c) = param5;
		  *(undefined4 *)(param1 + 0x18) = param4;
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  return;
		}
		*/

}
