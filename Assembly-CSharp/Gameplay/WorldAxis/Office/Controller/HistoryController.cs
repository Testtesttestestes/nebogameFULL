using System;
using Gameplay.WorldAxis.Office.Events;
using Gameplay.WorldAxis.Office.Model;
using Gameplay.WorldAxis.Office.View.History;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.WorldAxis.Office.Controller
{
	// Token: 0x020002DE RID: 734
	[Token(Token = "0x20002DE")]
	public class HistoryController : AbstractController<HistoryModel, HistoryEvents>
	{
		// Token: 0x0600114D RID: 4429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600114D")]
		[Address(RVA = "0x634A", Offset = "0x634A", VA = "0x634A")]
		public HistoryController(HistoryModel model, HistoryEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_Controller_HistoryController___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_WorldAxis_Office_Controller_HistoryController__HandleRun(param1,0,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600114E RID: 4430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600114E")]
		[Address(RVA = "0x634B", Offset = "0x634B", VA = "0x634B", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_WorldAxis_Office_Controller_HistoryController__HandleRun
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58b3d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryController_GetFirstHistoryResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a58b3d = '\x01';
		  }
		  param1_00 = ServicesNamespace_ColossusService__GetDollArtifacts
		                        (*(undefined4 *)(param1 + 0x18),0,param2,param3,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_WorldAxis_Office_Controller_HistoryController_GetFirstHistoryResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x0600114F RID: 4431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600114F")]
		[Address(RVA = "0x634C", Offset = "0x634C", VA = "0x634C")]
		public void GetFirstHistory(uint colossusId, bool clanBattles)
		{
		/* --- GHIDRA: GetFirstHistory ---
		void Gameplay_WorldAxis_Office_Controller_HistoryController__GetFirstHistory
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  int iVar2;
		  int param3_00;
		  
		  if (DAT_ram_00a58b3e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetColossusBattlesAns_TypeInfo);
		    DAT_ram_00a58b3e = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Colossus_ProtoGetColossusBattlesAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Colossus_ProtoGetColossusBattlesAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a58b0e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BattleHistoryListElement_BattleHistoryListElementArgs__Clear__
		              );
		    DAT_ram_00a58b0e = '\x01';
		  }
		  iVar2 = *(int *)(iVar1 + 0x2c);
		  param3_00 = *(int *)(iVar2 + 0xc);
		  *(undefined4 *)(iVar2 + 0xc) = 0;
		  *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		  if (0 < param3_00) {
		    func_ii_2064(*(undefined4 *)(iVar2 + 8),0,param3_00,0);
		  }
		  Gameplay_WorldAxis_Office_Model_HistoryModel__CreateBattlesList(iVar1,param1_00,param1);
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

		// Token: 0x06001150 RID: 4432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001150")]
		[Address(RVA = "0x634D", Offset = "0x634D", VA = "0x634D")]
		private void GetFirstHistoryResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetFirstHistoryResultHandler ---
		void Gameplay_WorldAxis_Office_Controller_HistoryController__GetFirstHistoryResultHandler
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58b3f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryController_GetHistoryResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a58b3f = '\x01';
		  }
		  param1_00 = ServicesNamespace_ColossusService__GetDollArtifacts
		                        (*(undefined4 *)(param1 + 0x18),param2,param3,param4,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_WorldAxis_Office_Controller_HistoryController_GetHistoryResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06001151 RID: 4433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001151")]
		[Address(RVA = "0x634E", Offset = "0x634E", VA = "0x634E")]
		public void GetHistory(uint pageNumber, uint colossusId, bool clanBattles)
		{
		/* --- GHIDRA: GetHistory ---
		void Gameplay_WorldAxis_Office_Controller_HistoryController__GetHistory
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a58b40 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetColossusBattlesAns_TypeInfo);
		    DAT_ram_00a58b40 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Colossus_ProtoGetColossusBattlesAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance
		              (param1_01,Protocol_Colossus_ProtoGetColossusBattlesAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_WorldAxis_Office_Model_HistoryModel__CreateBattlesList(param1_00,param1_01,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001152 RID: 4434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001152")]
		[Address(RVA = "0x634F", Offset = "0x634F", VA = "0x634F")]
		private void GetHistoryResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetHistoryResultHandler ---
		void Gameplay_WorldAxis_Office_Controller_HistoryController__GetHistoryResultHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58b41 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_HistoryController_GetBattleInfoResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a58b41 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ColossusService__GetColossusBattles
		                    (*(undefined4 *)(param1 + 0x18),*(undefined8 *)(*(int *)(param2 + 0x1c) + 0x10),
		                     0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_WorldAxis_Office_Controller_HistoryController_GetBattleInfoResultHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  DG_Tweening_TweenParams__SetId
		            (uVar1,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  return;
		}
		*/

		}

		// Token: 0x06001153 RID: 4435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001153")]
		[Address(RVA = "0x6350", Offset = "0x6350", VA = "0x6350")]
		public void GetBattleInfo(BattleHistoryListElement.BattleHistoryListElementArgs args)
		{
		/* --- GHIDRA: GetBattleInfo ---
		void Gameplay_WorldAxis_Office_Controller_HistoryController__GetBattleInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int *param1_01;
		  int param2_00;
		  undefined4 param4;
		  int local_4;
		  
		  if (DAT_ram_00a58b42 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_Office_View_History_BattleHistoryListElement_BattleHistoryListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetColossusBattleInfoAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7486);
		    DAT_ram_00a58b42 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Colossus_ProtoGetColossusBattleInfoAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Colossus_ProtoGetColossusBattleInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (param1_00[3] < 0) {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		    local_4 = param1_00[3];
		    uVar3 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    uVar3 = func_ii_4419(StringLiteral_7486,uVar3,0);
		    Core_Application_App__get_ToastController(uVar2,2,uVar3,0);
		  }
		  else {
		    param1_01 = *(int **)(param2 + 0xc);
		    if (param1_01 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_01 + 0xb8) <
		           (uint)*(byte *)(
		                          Gameplay_WorldAxis_Office_View_History_BattleHistoryListElement_BattleHistoryListElementArgs_TypeInfo
		                          + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_01 + 100) +
		                   (uint)*(byte *)(
		                                  Gameplay_WorldAxis_Office_View_History_BattleHistoryListElement_BattleHistoryListElementArgs_TypeInfo
		                                  + 0xb8) * 4 + -4) !=
		          Gameplay_WorldAxis_Office_View_History_BattleHistoryListElement_BattleHistoryListElementArgs_TypeInfo
		         )) {
		        System_Activator__CreateInstance
		                  (param1_01,
		                   Gameplay_WorldAxis_Office_View_History_BattleHistoryListElement_BattleHistoryListElementArgs_TypeInfo
		                  );
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param2_00 = param1_00[4];
		    if (DAT_ram_00a58b11 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Gameplay_WorldAxis_Office_Model_HistoryModel_BattleFullInfo_TypeInfo);
		      DAT_ram_00a58b11 = '\x01';
		    }
		    param4 = *(undefined4 *)(iVar1 + 0x28);
		    uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                      (*(undefined4 *)(iVar1 + 0x10),0);
		    uVar3 = unnamed_function_1417
		                      (Gameplay_WorldAxis_Office_Model_HistoryModel_BattleFullInfo_TypeInfo);
		    Gameplay_WorldAxis_Office_Model_HistoryModel_Participant___ctor
		              (uVar3,param2_00,param1_01,param4,uVar2,param2_00);
		    *(undefined4 *)(iVar1 + 0x24) = uVar3;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x1c);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001154")]
		[Address(RVA = "0x6351", Offset = "0x6351", VA = "0x6351")]
		private void GetBattleInfoResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetBattleInfoResultHandler ---
		void Gameplay_WorldAxis_Office_Controller_HistoryController__GetBattleInfoResultHandler
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58b43 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_HistoryModel__HistoryEvents__Dispose__);
		    DAT_ram_00a58b43 = '\x01';
		  }
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_HistoryModel__HistoryEvents__Dispose__);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06001155 RID: 4437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001155")]
		[Address(RVA = "0x6352", Offset = "0x6352", VA = "0x6352", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_WorldAxis_Office_Controller_HistoryController__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58b44 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_HistoryModel__HistoryEvents__HistoryController__HistoryView___ctor__
		              );
		    DAT_ram_00a58b44 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_HistoryModel__HistoryEvents__HistoryController__HistoryView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x040008F9 RID: 2297
		[Token(Token = "0x40008F9")]
		[FieldOffset(Offset = "0x18")]
		private ColossusService _service;
	}
}
