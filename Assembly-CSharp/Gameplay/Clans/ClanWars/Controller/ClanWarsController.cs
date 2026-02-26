using System;
using Gameplay.Clans.ClanWars.Events;
using Gameplay.Clans.ClanWars.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.ClanWar;
using Protocol.Common;
using ServicesNamespace;
using Utils;

namespace Gameplay.Clans.ClanWars.Controller
{
	// Token: 0x02000AA8 RID: 2728
	[Token(Token = "0x2000AA8")]
	public class ClanWarsController : AbstractController<ClanWarsModel, ClanWarsEvents>
	{
		// Token: 0x060041C3 RID: 16835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C3")]
		[Address(RVA = "0x9077", Offset = "0x9077", VA = "0x9077")]
		public ClanWarsController(ClanWarsModel model, ClanWarsEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a577ca == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoClanWarCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSeasonStartedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoWarStateChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoNewWarDeclaredEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_ClanWarCompletedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_NewWarDeclaredEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_SeasonStartedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_WarStateChangedEventHandler__
		              );
		    DAT_ram_00a577ca = '\x01';
		  }
		  Gameplay_Clans_ClanWars_Controller_ClanWarsController__RequestUpdateActiveWar(param1,param1);
		  Gameplay_Clans_ClanWars_Controller_ClanWarsController__GetActiveWarInfoResultHandler
		            (param1,param1);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoWarStateChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_WarStateChangedEventHandler__
		             ,0);
		  ServicesNamespace_ClanWarsService__remove_NewWarDeclaredEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoNewWarDeclaredEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_NewWarDeclaredEventHandler__
		             ,0);
		  ServicesNamespace_ClanWarsService__get_ServiceId(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoClanWarCompleteEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_ClanWarCompletedEventHandler__
		             ,0);
		  ServicesNamespace_ClanWarsService__remove_PlayersCountChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoSeasonStartedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_SeasonStartedEventHandler__
		             ,0);
		  ServicesNamespace_ClanWarsService__remove_ClanWarCompletedEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060041C4 RID: 16836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C4")]
		[Address(RVA = "0x9078", Offset = "0x9078", VA = "0x9078", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController__HandleRun(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a577cb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoClanWarCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSeasonStartedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoWarStateChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoNewWarDeclaredEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_ClanWarCompletedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_NewWarDeclaredEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_SeasonStartedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_WarStateChangedEventHandler__
		              );
		    DAT_ram_00a577cb = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoWarStateChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_WarStateChangedEventHandler__
		             ,0);
		  ServicesNamespace_ClanWarsService__add_WarStateChanged(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoNewWarDeclaredEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_NewWarDeclaredEventHandler__
		             ,0);
		  ServicesNamespace_ClanWarsService__add_NewWarDeclaredEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoClanWarCompleteEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_ClanWarCompletedEventHandler__
		             ,0);
		  ServicesNamespace_ClanWarsService__add_ClanWarCompletedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoSeasonStartedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_SeasonStartedEventHandler__
		             ,0);
		  ServicesNamespace_ClanWarsService__add_SeasonStartedEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060041C5 RID: 16837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C5")]
		[Address(RVA = "0x9079", Offset = "0x9079", VA = "0x9079", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController__HandleStop
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 uVar1;
		  int iVar2;
		  float param2_00;
		  undefined4 uVar3;
		  int iVar4;
		  ulonglong param1_00;
		  
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (CONCAT44(in_register_20000004,param1),*(undefined4 *)(*param1 + 0x104));
		  iVar4 = *(int *)(param2 + 0xc);
		  if (DAT_ram_00a577c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a577c8 = '\x01';
		  }
		  param1_00 = (ulonglong)*(uint *)(iVar4 + 0x10);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = func_ii_7331(param1_00,0);
		  uVar1 = (undefined4)(param1_00 >> 0x20);
		  uVar3 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar3,param2_00,0);
		  *(undefined4 *)(iVar2 + 0x1c) = uVar3;
		  uVar3 = *(undefined4 *)(iVar4 + 0xc);
		  *(undefined4 *)(iVar2 + 0x20) = 0;
		  *(undefined4 *)(iVar2 + 0x28) = uVar3;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (CONCAT44(uVar1,param1),*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x1c);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060041C6 RID: 16838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C6")]
		[Address(RVA = "0x907A", Offset = "0x907A", VA = "0x907A")]
		private void SeasonStartedEventHandler(ProtoSeasonStartedEvt evt)
		{
		/* --- GHIDRA: SeasonStartedEventHandler ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController__SeasonStartedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Clans_ClanWars_Controller_ClanWarsController__RequestUpdateActiveWar(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060041C7 RID: 16839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C7")]
		[Address(RVA = "0x907B", Offset = "0x907B", VA = "0x907B")]
		public void RequestUpdateActiveWar()
		{
		/* --- GHIDRA: RequestUpdateActiveWar ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController__RequestUpdateActiveWar
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a577cc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_GetActiveWarInfoResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a577cc = '\x01';
		  }
		  uVar1 = ServicesNamespace_ClanWarsService__RequestPolitics(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_GetActiveWarInfoResultHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060041C8 RID: 16840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C8")]
		[Address(RVA = "0x907C", Offset = "0x907C", VA = "0x907C")]
		private void GetActiveWarInfo()
		{
		/* --- GHIDRA: GetActiveWarInfo ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController__GetActiveWarInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a577cd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoGetActiveWarInfoAns_TypeInfo);
		    DAT_ram_00a577cd = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_ClanWar_ProtoGetActiveWarInfoAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_ClanWar_ProtoGetActiveWarInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Clans_ClanWars_Model_ClanWarsModel__TryGetActiveWar(param1_00,param1_01[3],param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 8);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
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

		// Token: 0x060041C9 RID: 16841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C9")]
		[Address(RVA = "0x907D", Offset = "0x907D", VA = "0x907D")]
		private void GetActiveWarInfoResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetActiveWarInfoResultHandler ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController__GetActiveWarInfoResultHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a577ce == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_GetCurrentSeasonInfoResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a577ce = '\x01';
		  }
		  uVar1 = ServicesNamespace_ClanWarsService__GetWarsHistory(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_GetCurrentSeasonInfoResultHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060041CA RID: 16842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041CA")]
		[Address(RVA = "0x907E", Offset = "0x907E", VA = "0x907E")]
		public void GetCurrentSeasonInfo()
		{
		/* --- GHIDRA: GetCurrentSeasonInfo ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController__GetCurrentSeasonInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a577cf == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoGetCurrentSeasonInfoAns_TypeInfo);
		    DAT_ram_00a577cf = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_ClanWar_ProtoGetCurrentSeasonInfoAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance
		              (param1_01,Protocol_ClanWar_ProtoGetCurrentSeasonInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Clans_ClanWars_Model_ClanWarsModel__UpdateActiveWar(param1_00,param1_01,param1);
		  return;
		}
		*/

		}

		// Token: 0x060041CB RID: 16843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041CB")]
		[Address(RVA = "0x907F", Offset = "0x907F", VA = "0x907F")]
		private void GetCurrentSeasonInfoResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetCurrentSeasonInfoResultHandler ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController__GetCurrentSeasonInfoResultHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a577d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_TakeOutGolemResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a577d0 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_02 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_02;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x230);
		        goto code_r0x80dded5d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80dded5d:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_02,puVar2[1]);
		  iVar3 = Core_Errors_Expected_Clans_ExpectedClanBillingErrors__Handle
		                    (*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x18) + 8),param2,0);
		  if (iVar3 != 0) {
		    param1_00 = ServicesNamespace_ClanWarsService__GetCurrentSeasonInfo
		                          (*(undefined4 *)(param1 + 0x18),0);
		    param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_01,param1,
		               Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_TakeOutGolemResultHandler__
		               ,0);
		    ServicesNamespace_MainService__GetUserStats
		              (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060041CC RID: 16844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041CC")]
		[Address(RVA = "0x9080", Offset = "0x9080", VA = "0x9080")]
		public void TakeOutGolem(ResourceSet price)
		{
		/* --- GHIDRA: TakeOutGolem ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController__TakeOutGolem
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a577d1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors__ExpectedClanWarErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoDefaultAns_TypeInfo);
		    DAT_ram_00a577d1 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Common_ProtoDefaultAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Common_ProtoDefaultAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (param1_00[3],0,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors__ExpectedClanWarErrors___
		                    );
		  if (iVar1 == 0) {
		    iVar1 = System_Uri___ctor(0);
		    iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x84) + 0x38);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060041CD RID: 16845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041CD")]
		[Address(RVA = "0x9081", Offset = "0x9081", VA = "0x9081")]
		private void TakeOutGolemResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: TakeOutGolemResultHandler ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController__TakeOutGolemResultHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a577d2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_RepairGolemResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a577d2 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_02 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_02;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x230);
		        goto code_r0x80ddef32;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80ddef32:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_02,puVar2[1]);
		  iVar3 = Core_Errors_Expected_Clans_ExpectedClanBillingErrors__Handle
		                    (*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x18) + 8),param2,0);
		  if (iVar3 != 0) {
		    param1_00 = ServicesNamespace_ClanWarsService__TakeOutGolem(*(undefined4 *)(param1 + 0x18),0);
		    param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_01,param1,
		               Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_RepairGolemResultHandler__
		               ,0);
		    ServicesNamespace_MainService__GetUserStats
		              (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060041CE RID: 16846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041CE")]
		[Address(RVA = "0x9082", Offset = "0x9082", VA = "0x9082")]
		public void RepairGolem(ResourceSet price)
		{
		/* --- GHIDRA: RepairGolem ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController__RepairGolem
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a577d3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors__ExpectedClanWarErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoDefaultAns_TypeInfo);
		    DAT_ram_00a577d3 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Common_ProtoDefaultAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Common_ProtoDefaultAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		            (param1_00[3],0,0,
		             Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors__ExpectedClanWarErrors___
		            );
		  return;
		}
		*/

		}

		// Token: 0x060041CF RID: 16847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041CF")]
		[Address(RVA = "0x9083", Offset = "0x9083", VA = "0x9083")]
		private void RepairGolemResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: RepairGolemResultHandler ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController__RepairGolemResultHandler
		               (int param1,undefined8 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined8 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  int iVar6;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  uVar2 = param2;
		  if (DAT_ram_00a577d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_DeclareWarResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&Method_System_ValueTuple_ulong__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_ValueTuple_ulong__string__TypeInfo);
		    DAT_ram_00a577d4 = '\x01';
		  }
		  uVar4 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x230);
		        goto code_r0x80ddf0f8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80ddf0f8:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,CONCAT44(uVar4,puVar3[1]));
		  iVar6 = Core_Errors_Expected_Clans_ExpectedClanBillingErrors__Handle
		                    (*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x18) + 8),param3,0);
		  if (iVar6 != 0) {
		    uVar4 = ServicesNamespace_ClanWarsService__RepairGolem(*(undefined4 *)(param1 + 0x18),param2,0);
		    uVar5 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar5,param1,
		               Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_DeclareWarResultHandler__
		               ,0);
		    uVar4 = ServicesNamespace_MainService__GetUserStats
		                      (uVar4,uVar5,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    local_8 = 0;
		    local_10 = 0;
		    System_ValueTuple_uint__uint___ToString
		              (&local_10,param2,param4,Method_System_ValueTuple_ulong__string___ctor__);
		    local_18 = local_8;
		    local_20 = local_10;
		    uVar5 = func_ii_1081(System_ValueTuple_ulong__string__TypeInfo,&local_20);
		    DG_Tweening_TweenParams__SetId
		              (uVar4,uVar5,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060041D0 RID: 16848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041D0")]
		[Address(RVA = "0x9084", Offset = "0x9084", VA = "0x9084")]
		public void DeclareWar(ulong clanId, ResourceSet price, string clanName)
		{
		/* --- GHIDRA: DeclareWar ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController__DeclareWar
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined8 *puVar2;
		  undefined4 param2_00;
		  int iVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  undefined4 param6;
		  undefined4 param3_00;
		  undefined4 param4;
		  undefined8 param5;
		  
		  if (DAT_ram_00a577d5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Events_Scopes_ClansScope_ClanWarsDeclarationEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors__ExpectedClanWarErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoDeclarateWarAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_ValueTuple_ulong__string__TypeInfo);
		    DAT_ram_00a577d5 = '\x01';
		  }
		  piVar4 = *(int **)(param2 + 0x20);
		  if ((piVar4 != (int *)0x0) && (Protocol_ClanWar_ProtoDeclarateWarAns_TypeInfo != *piVar4)) {
		    System_Activator__CreateInstance(piVar4,Protocol_ClanWar_ProtoDeclarateWarAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (piVar4[3],0,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors__ExpectedClanWarErrors___
		                    );
		  if (iVar1 == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x18);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		    piVar4 = *(int **)(param2 + 0xc);
		    if (piVar4 == (int *)0x0) {
		      System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (*(int *)(*piVar4 + 0x20) != *(int *)(System_ValueTuple_ulong__string__TypeInfo + 0x20)) {
		      System_Activator__CreateInstance(piVar4,System_ValueTuple_ulong__string__TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    puVar2 = (undefined8 *)func_ii_15774(piVar4);
		    param6 = *(undefined4 *)(puVar2 + 1);
		    param5 = *puVar2;
		    iVar1 = System_Uri___ctor(0);
		    iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x84) + 0x28);
		    if (iVar1 != 0) {
		      param2_00 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param4 = *(undefined4 *)(*(int *)(*(int *)(iVar3 + 8) + 0x68) + 0x1c);
		      param1_00 = unnamed_function_1417
		                            (Core_Events_Scopes_ClansScope_ClanWarsDeclarationEventArgs_TypeInfo);
		      Core_Events_Scopes_ClansScope_ClanWarsDeclarationEventArgs__set_DefenderName
		                (param1_00,param2_00,param3_00,param4,param5,param6,0);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060041D1 RID: 16849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041D1")]
		[Address(RVA = "0x9085", Offset = "0x9085", VA = "0x9085")]
		private void DeclareWarResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: DeclareWarResultHandler ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController__DeclareWarResultHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  undefined4 uVar4;
		  int *param1_01;
		  int param1_02;
		  
		  if (DAT_ram_00a577d6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_PayOffResultHandler__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a577d6 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar4 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x40);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x230);
		        goto code_r0x80ddf456;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80ddf456:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  iVar2 = Core_Errors_Expected_Clans_ExpectedClanBillingErrors__Handle
		                    (*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x18) + 8),uVar4,0);
		  if (iVar2 != 0) {
		    param1_02 = param1[6];
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar4 = ServicesNamespace_ClanWarsService__DeclareWar
		                      (param1_02,*(undefined4 *)(*(int *)(iVar2 + 0x14) + 0xc),0);
		    param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_PayOffResultHandler__,0)
		    ;
		    uVar4 = ServicesNamespace_MainService__GetUserStats
		                      (uVar4,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    DG_Tweening_TweenParams__SetId
		              (uVar4,*(undefined4 *)(iVar2 + 0x14),
		               Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060041D2 RID: 16850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041D2")]
		[Address(RVA = "0x9086", Offset = "0x9086", VA = "0x9086")]
		public void PayOff()
		{
		/* --- GHIDRA: PayOff ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController__PayOff
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int *piVar2;
		  int param5;
		  int param4;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a577d7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ClanWarInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ClansScope_ClanWarsEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors__ExpectedClanWarErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoDefaultAns_TypeInfo);
		    DAT_ram_00a577d7 = '\x01';
		  }
		  piVar2 = *(int **)(param2 + 0x20);
		  if ((piVar2 != (int *)0x0) && (Protocol_Common_ProtoDefaultAns_TypeInfo != *piVar2)) {
		    System_Activator__CreateInstance(piVar2,Protocol_Common_ProtoDefaultAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (piVar2[3],0,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors__ExpectedClanWarErrors___
		                    );
		  if (iVar1 == 0) {
		    piVar2 = *(int **)(param2 + 0xc);
		    if ((piVar2 != (int *)0x0) && (Protocol_ClanWar_ClanWarInfo_TypeInfo != *piVar2)) {
		      System_Activator__CreateInstance(piVar2,Protocol_ClanWar_ClanWarInfo_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = System_Uri___ctor(0);
		    iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x84) + 0x34);
		    if (iVar1 != 0) {
		      param2_00 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param5 = piVar2[5];
		      param4 = piVar2[4];
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      param1_00 = unnamed_function_1417(Core_Events_Scopes_ClansScope_ClanWarsEventArgs_TypeInfo);
		      Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		                (param1_00,param2_00,param3_00,param4,param5,0);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060041D3 RID: 16851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041D3")]
		[Address(RVA = "0x9087", Offset = "0x9087", VA = "0x9087")]
		private void PayOffResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: PayOffResultHandler ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController__PayOffResultHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  float fVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  int *param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a577d8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_AccelerateWarPreparationResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4210);
		    DAT_ram_00a577d8 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a577c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a577c4 = '\x01';
		  }
		  fVar3 = func_ii_7103(*(undefined4 *)(iVar2 + 0x18),0);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  if (fVar3 <= *(float *)(*(int *)(Utils_TimeUtils_TypeInfo + 0x5c) + 4)) {
		    uVar4 = System_Uri___ctor(0);
		    uVar4 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar4,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4210,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar4,1,uVar6,0);
		    return;
		  }
		  iVar2 = *param1;
		  uVar4 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                    (param1,*(undefined4 *)(iVar2 + 0x104));
		  iVar2 = Gameplay_Clans_ClanWars_Model_ClanWarsModel__set_CurrentSeasonId(uVar4,iVar2);
		  uVar4 = *(undefined4 *)(iVar2 + 0x1c);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x230);
		        goto code_r0x80ddf7f4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80ddf7f4:
		  iVar2 = (**(code **)((ulonglong)*puVar5 * 4))(param1_00,puVar5[1]);
		  iVar2 = Core_Errors_Expected_Clans_ExpectedClanBillingErrors__Handle
		                    (*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x18) + 8),uVar4,0);
		  if (iVar2 != 0) {
		    param1_01 = param1[6];
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar4 = ServicesNamespace_ClanWarsService__PayOff
		                      (param1_01,*(undefined4 *)(*(int *)(iVar2 + 0x14) + 0xc),0);
		    uVar6 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar6,param1,
		               Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_AccelerateWarPreparationResultHandler__
		               ,0);
		    ServicesNamespace_MainService__GetUserStats
		              (uVar4,uVar6,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060041D4 RID: 16852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041D4")]
		[Address(RVA = "0x9088", Offset = "0x9088", VA = "0x9088")]
		public void AccelerateWarPreparation()
		{
		/* --- GHIDRA: AccelerateWarPreparation ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController__AccelerateWarPreparation
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 uVar2;
		  undefined8 uVar1;
		  int iVar3;
		  float param2_00;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param3_00;
		  undefined4 param4;
		  undefined4 param5;
		  ulonglong param1_02;
		  
		  if (DAT_ram_00a577d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ClansScope_ClanWarsEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors__ExpectedClanWarErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoAcceleratePreparationAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a577d9 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_ClanWar_ProtoAcceleratePreparationAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance
		              (param1_01,Protocol_ClanWar_ProtoAcceleratePreparationAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar3 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (param1_01[3],0,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors__ExpectedClanWarErrors___
		                    );
		  if (iVar3 == 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (CONCAT44(in_register_20000004,param1),*(undefined4 *)(*param1 + 0x104));
		    param1_02 = (ulonglong)(uint)param1_01[4];
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    param2_00 = func_ii_7331(param1_02,0);
		    uVar2 = (undefined4)(param1_02 >> 0x20);
		    uVar4 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar4,param2_00,0);
		    *(undefined4 *)(iVar3 + 0x24) = uVar4;
		    iVar3 = System_Uri___ctor(0);
		    iVar3 = *(int *)(*(int *)(*(int *)(*(int *)(iVar3 + 0x38) + 0x10) + 0x84) + 0x2c);
		    if (iVar3 != 0) {
		      uVar4 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      uVar1 = CONCAT44(uVar2,param1);
		      iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (uVar1,*(undefined4 *)(*param1 + 0x104));
		      param4 = *(undefined4 *)(*(int *)(iVar5 + 0x14) + 0x10);
		      uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),param1);
		      iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (uVar1,*(undefined4 *)(*param1 + 0x104));
		      param5 = *(undefined4 *)(*(int *)(iVar5 + 0x14) + 0x14);
		      uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      param1_00 = unnamed_function_1417(Core_Events_Scopes_ClansScope_ClanWarsEventArgs_TypeInfo);
		      Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		                (param1_00,uVar4,param3_00,param4,param5,0);
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (CONCAT44(uVar2,*(undefined4 *)(iVar3 + 0x20)),param1_00,
		                 *(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060041D5 RID: 16853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041D5")]
		[Address(RVA = "0x9089", Offset = "0x9089", VA = "0x9089")]
		private void AccelerateWarPreparationResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: AccelerateWarPreparationResultHandler ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController__AccelerateWarPreparationResultHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  int param1_02;
		  int iVar4;
		  
		  if (DAT_ram_00a577da == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_CancelAccelerationResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a577da = '\x01';
		  }
		  iVar4 = *param1;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x100) * 4))
		                    (param1,*(undefined4 *)(iVar4 + 0x104));
		  iVar4 = Gameplay_Clans_ClanWars_Model_ClanWarsModel__set_CurrentSeasonId(uVar2,iVar4);
		  uVar2 = *(undefined4 *)(iVar4 + 0x20);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x230);
		        goto code_r0x80ddfb0f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80ddfb0f:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  iVar4 = Core_Errors_Expected_Clans_ExpectedClanBillingErrors__Handle
		                    (*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x18) + 8),uVar2,0);
		  if (iVar4 != 0) {
		    param1_02 = param1[6];
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar2 = ServicesNamespace_ClanWarsService__AcceleratePreparation
		                      (param1_02,*(undefined4 *)(*(int *)(iVar4 + 0x14) + 0xc),0);
		    param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Gameplay_Clans_ClanWars_Controller_ClanWarsController_CancelAccelerationResultHandler__
		               ,0);
		    ServicesNamespace_MainService__GetUserStats
		              (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060041D6 RID: 16854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041D6")]
		[Address(RVA = "0x908A", Offset = "0x908A", VA = "0x908A")]
		public void CancelAcceleration()
		{
		/* --- GHIDRA: CancelAcceleration ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController__CancelAcceleration
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int iVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param3_00;
		  undefined4 param4;
		  undefined4 param5;
		  
		  if (DAT_ram_00a577db == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ClansScope_ClanWarsEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors__ExpectedClanWarErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoDefaultAns_TypeInfo);
		    DAT_ram_00a577db = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Common_ProtoDefaultAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Common_ProtoDefaultAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (param1_01[3],0,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors__ExpectedClanWarErrors___
		                    );
		  if (iVar1 == 0) {
		    iVar1 = System_Uri___ctor(0);
		    iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x84) + 0x30);
		    if (iVar1 != 0) {
		      param2_00 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param4 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x10);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param5 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x14);
		      param1_00 = unnamed_function_1417(Core_Events_Scopes_ClansScope_ClanWarsEventArgs_TypeInfo);
		      Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		                (param1_00,param2_00,param3_00,param4,param5,0);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060041D7 RID: 16855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041D7")]
		[Address(RVA = "0x908B", Offset = "0x908B", VA = "0x908B")]
		private void CancelAccelerationResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: CancelAccelerationResultHandler ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController__CancelAccelerationResultHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 uVar2;
		  undefined8 uVar1;
		  int iVar3;
		  float param2_00;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_00;
		  ulonglong param1_01;
		  uint uVar6;
		  
		  if (DAT_ram_00a577dc == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a577dc = '\x01';
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (CONCAT44(in_register_20000004,param1),*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar3 + 0x10) == 0) {
		    Gameplay_Clans_ClanWars_Controller_ClanWarsController__RequestUpdateActiveWar(param1,param2);
		    return;
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(*(int *)(iVar3 + 0x14) + 0x34) = *(undefined4 *)(param2 + 0x18);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(*(int *)(iVar3 + 0x14) + 0x1c) = *(undefined4 *)(param2 + 0x10);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = (ulonglong)*(uint *)(param2 + 0x14);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = func_ii_7331(param1_01,0);
		  uVar2 = (undefined4)(param1_01 >> 0x20);
		  uVar4 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar4,param2_00,0);
		  *(undefined4 *)(iVar3 + 0x18) = uVar4;
		  if (*(int *)(param2 + 0x10) - 3U < 2) {
		    uVar1 = CONCAT44(uVar2,param1);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (uVar1,*(undefined4 *)(*param1 + 0x104));
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    if (DAT_ram_00a577c6 == '\0') {
		      Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		      Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		      DAT_ram_00a577c6 = '\x01';
		    }
		    *(undefined4 *)(iVar3 + 0x10) = 0;
		    uVar4 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar4,0.0,0);
		    *(undefined4 *)(iVar3 + 0x18) = uVar4;
		    uVar1 = CONCAT44(uVar2,param1);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (uVar1,*(undefined4 *)(*param1 + 0x104));
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    *(undefined4 *)(iVar3 + 0x14) = 0;
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar6 = 0;
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8 + 4) * 8 + iVar3 + 0x230);
		          goto code_r0x80ddfee5;
		        }
		        uVar6 = uVar6 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar6);
		    }
		    puVar5 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80ddfee5:
		    uVar1 = CONCAT44(uVar2,param1_00);
		    iVar3 = (**(code **)((ulonglong)*puVar5 * 4))(uVar1,puVar5[1]);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    Gameplay_Clans_Controller_ClansController__GetClanTreasuryResultHandler
		              (*(undefined4 *)(iVar3 + 0x18),0);
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (CONCAT44(uVar2,param1),*(undefined4 *)(*param1 + 0x114));
		  iVar3 = *(int *)(iVar3 + 0x14);
		  if (iVar3 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060041D8 RID: 16856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041D8")]
		[Address(RVA = "0x908C", Offset = "0x908C", VA = "0x908C")]
		private void WarStateChangedEventHandler(ProtoWarStateChangedEvt evt)
		{
		/* --- GHIDRA: WarStateChangedEventHandler ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController__WarStateChangedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a577dd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Protocol_ClanWar_ProtoGetActiveWarInfoAns_Types_ActiveWarInfo_TypeInfo);
		    DAT_ram_00a577dd = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Protocol_ClanWar_ProtoGetActiveWarInfoAns_Types_ActiveWarInfo_TypeInfo);
		  *(undefined4 *)(param2_00 + 0xc) = *(undefined4 *)(param2 + 0xc);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Clans_ClanWars_Model_ClanWarsModel__TryGetActiveWar(param1_00,param2_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x060041D9 RID: 16857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041D9")]
		[Address(RVA = "0x908D", Offset = "0x908D", VA = "0x908D")]
		private void NewWarDeclaredEventHandler(ProtoNewWarDeclaredEvt evt)
		{
		/* --- GHIDRA: NewWarDeclaredEventHandler ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController__NewWarDeclaredEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a577c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a577c6 = '\x01';
		  }
		  *(undefined4 *)(iVar1 + 0x10) = 0;
		  param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,0.0,0);
		  *(undefined4 *)(iVar1 + 0x18) = param1_00;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x14) = 0;
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

		// Token: 0x060041DA RID: 16858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041DA")]
		[Address(RVA = "0x908E", Offset = "0x908E", VA = "0x908E")]
		private void ClanWarCompletedEventHandler(ProtoClanWarCompleteEvt evt)
		{
		/* --- GHIDRA: ClanWarCompletedEventHandler ---
		void Gameplay_Clans_ClanWars_Controller_ClanWarsController__ClanWarCompletedEventHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a577de == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ZigguratWindow___ctor__
		              );
		    DAT_ram_00a577de = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ZigguratWindow___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04002456 RID: 9302
		[Token(Token = "0x4002456")]
		[FieldOffset(Offset = "0x18")]
		private ClanWarsService _clanWarsService;
	}
}
