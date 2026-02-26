using System;
using DG.Tweening;
using Gameplay.Clans.Events;
using Gameplay.WorldAxis.Events;
using Gameplay.WorldAxis.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Colossus;
using Protocol.Dic;
using Protocol.Main;
using ServicesNamespace;
using Utils;

namespace Gameplay.WorldAxis.Controller
{
	// Token: 0x020002CA RID: 714
	[Token(Token = "0x20002CA")]
	public class WorldAxisController : AbstractController<WorldAxisModel, WorldAxisEvents>
	{
		// Token: 0x060010CF RID: 4303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010CF")]
		[Address(RVA = "0x62CC", Offset = "0x62CC", VA = "0x62CC")]
		public WorldAxisController(WorldAxisModel model, WorldAxisEvents events, ClansEvents clansEvents)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Controller_WorldAxisController___ctor(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a58af8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGetScheduleAns__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGetColossusInfoAns__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoInventoryChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Controller_WorldAxisController_ClanStatusChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Controller_WorldAxisController_ColossusChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Controller_WorldAxisController_InventoryChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Controller_WorldAxisController_ScheduleChangedEventHandler__
		              );
		    DAT_ram_00a58af8 = '\x01';
		  }
		  Gameplay_WorldAxis_Controller_WorldAxisController__InventoryChangedEventHandler(param1,param1);
		  Gameplay_WorldAxis_Controller_WorldAxisController__GetSchedultResultHandler(param1,param1);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  uVar2 = unnamed_function_1417(System_Action_ProtoInventoryChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_WorldAxis_Controller_WorldAxisController_InventoryChangedEventHandler__
		             ,0);
		  ServicesNamespace_MainService__remove_DictionariesUpdatedEvent(uVar1,uVar2,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoGetScheduleAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_Controller_WorldAxisController_ScheduleChangedEventHandler__,
		             0);
		  ServicesNamespace_ColossusService__remove_ColossusChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoGetColossusInfoAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_Controller_WorldAxisController_ColossusChangedEventHandler__,
		             0);
		  ServicesNamespace_ColossusService__remove_SlotsChangedEvent(uVar2,uVar1,0);
		  iVar3 = *(int *)(param1 + 0x1c);
		  uVar2 = *(undefined4 *)(iVar3 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_Controller_WorldAxisController_ClanStatusChangedEventHandler__
		             ,0);
		  param1_00 = (int *)UnityEngine_UI_Image__set_sprite(uVar2,uVar1,0);
		  param2_00 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(iVar3 + 0x18) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *param1_00) &&
		     (*(int **)(iVar3 + 0x18) = param1_00, *param1_00 == param2_00)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D0")]
		[Address(RVA = "0x62CD", Offset = "0x62CD", VA = "0x62CD", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_WorldAxis_Controller_WorldAxisController__HandleRun(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a58af9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGetScheduleAns__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGetColossusInfoAns__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoInventoryChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Controller_WorldAxisController_ClanStatusChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Controller_WorldAxisController_ColossusChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Controller_WorldAxisController_InventoryChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Controller_WorldAxisController_ScheduleChangedEventHandler__
		              );
		    DAT_ram_00a58af9 = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  uVar2 = unnamed_function_1417(System_Action_ProtoInventoryChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_WorldAxis_Controller_WorldAxisController_InventoryChangedEventHandler__
		             ,0);
		  ServicesNamespace_MainService__add_InventoryChangedEvent(uVar1,uVar2,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoGetScheduleAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_Controller_WorldAxisController_ScheduleChangedEventHandler__,
		             0);
		  ServicesNamespace_ColossusService__add_ScheduleChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoGetColossusInfoAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_Controller_WorldAxisController_ColossusChangedEventHandler__,
		             0);
		  ServicesNamespace_ColossusService__add_ColossusChangedEvent(uVar2,uVar1,0);
		  iVar3 = *(int *)(param1 + 0x1c);
		  uVar2 = *(undefined4 *)(iVar3 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_Controller_WorldAxisController_ClanStatusChangedEventHandler__
		             ,0);
		  param1_00 = (int *)func_ii_7048(uVar2,uVar1,0);
		  param2_00 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(iVar3 + 0x18) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_00) ||
		          (*(int **)(iVar3 + 0x18) = param1_00, *param1_00 != param2_00)) {
		    System_Activator__CreateInstance(param1_00,param2_00);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(param1 + 0x20) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x20),0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D1")]
		[Address(RVA = "0x62CE", Offset = "0x62CE", VA = "0x62CE", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_WorldAxis_Controller_WorldAxisController__HandleStop
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a58afa == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__Add__);
		    DAT_ram_00a58afa = '\x01';
		  }
		  if (*(longlong *)(param2 + 0x10) != 0) {
		    param1_00 = unnamed_function_1417(Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    Protocol_Main_ProtoStackableChangesAns__pb__Google_Protobuf_IMessage_get_Descriptor(param1_00,0)
		    ;
		    Google_Protobuf_Collections_RepeatedField_object____ctor
		              (*(undefined4 *)(param1_00 + 0x10),*(undefined4 *)(param2 + 0xc),
		               Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__Add__);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x1c);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D2")]
		[Address(RVA = "0x62CF", Offset = "0x62CF", VA = "0x62CF")]
		private void InventoryChangedEventHandler(ProtoInventoryChangedEvt evt)
		{
		/* --- GHIDRA: InventoryChangedEventHandler ---
		void Gameplay_WorldAxis_Controller_WorldAxisController__InventoryChangedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58afb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_Controller_WorldAxisController_GetSchedultResultHandler__)
		    ;
		    DAT_ram_00a58afb = '\x01';
		  }
		  uVar1 = ServicesNamespace_ColossusService__GetAvailableDolls(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_WorldAxis_Controller_WorldAxisController_GetSchedultResultHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D3")]
		[Address(RVA = "0x62D0", Offset = "0x62D0", VA = "0x62D0")]
		public void GetSchedule()
		{
		/* --- GHIDRA: GetSchedule ---
		void Gameplay_WorldAxis_Controller_WorldAxisController__GetSchedule
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a58afc == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetScheduleAns_TypeInfo);
		    DAT_ram_00a58afc = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Colossus_ProtoGetScheduleAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Colossus_ProtoGetScheduleAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_WorldAxis_Controller_WorldAxisController__GetColossusInfoResultHandler
		            (param1,param1_00,param1);
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

		// Token: 0x060010D4 RID: 4308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D4")]
		[Address(RVA = "0x62D1", Offset = "0x62D1", VA = "0x62D1")]
		private void GetSchedultResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetSchedultResultHandler ---
		void Gameplay_WorldAxis_Controller_WorldAxisController__GetSchedultResultHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58afd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Controller_WorldAxisController_GetAvailableDollsResultHandler__
		              );
		    DAT_ram_00a58afd = '\x01';
		  }
		  uVar1 = ServicesNamespace_ColossusService__GetPartyInfo(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_WorldAxis_Controller_WorldAxisController_GetAvailableDollsResultHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D5")]
		[Address(RVA = "0x62D2", Offset = "0x62D2", VA = "0x62D2")]
		public void GetAvailableDolls()
		{
		/* --- GHIDRA: GetAvailableDolls ---
		void Gameplay_WorldAxis_Controller_WorldAxisController__GetAvailableDolls
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a58afe == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetAvailDollsAns_TypeInfo);
		    DAT_ram_00a58afe = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Colossus_ProtoGetAvailDollsAns_TypeInfo != *param1_01))
		  {
		    System_Activator__CreateInstance(param1_01,Protocol_Colossus_ProtoGetAvailDollsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_WorldAxis_Model_WorldAxisModel__CreateBacktime(param1_00,param1_01,param1);
		  return;
		}
		*/

		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D6")]
		[Address(RVA = "0x62D3", Offset = "0x62D3", VA = "0x62D3")]
		private void GetAvailableDollsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetAvailableDollsResultHandler ---
		void Gameplay_WorldAxis_Controller_WorldAxisController__GetAvailableDollsResultHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58aff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_Controller_WorldAxisController_GetPartyInfoResultHandler__
		              );
		    DAT_ram_00a58aff = '\x01';
		  }
		  uVar1 = ServicesNamespace_ColossusService__GetColossusInfo(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_WorldAxis_Controller_WorldAxisController_GetPartyInfoResultHandler__,0)
		  ;
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D7")]
		[Address(RVA = "0x62D4", Offset = "0x62D4", VA = "0x62D4")]
		public void GetPartyInfo()
		{
		/* --- GHIDRA: GetPartyInfo ---
		void Gameplay_WorldAxis_Controller_WorldAxisController__GetPartyInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a58b00 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetPartyInfoAns_TypeInfo);
		    DAT_ram_00a58b00 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Colossus_ProtoGetPartyInfoAns_TypeInfo != *param1_01))
		  {
		    System_Activator__CreateInstance(param1_01,Protocol_Colossus_ProtoGetPartyInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_WorldAxis_Model_WorldAxisModel__PopulateDolls(param1_00,param1_01,param1);
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

		// Token: 0x060010D8 RID: 4312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D8")]
		[Address(RVA = "0x62D5", Offset = "0x62D5", VA = "0x62D5")]
		private void GetPartyInfoResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetPartyInfoResultHandler ---
		void Gameplay_WorldAxis_Controller_WorldAxisController__GetPartyInfoResultHandler
		               (int param1,undefined8 param2,undefined8 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58b01 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Controller_WorldAxisController_FromGolemToDollResultHandler__
		              );
		    DAT_ram_00a58b01 = '\x01';
		  }
		  param1_00 = ServicesNamespace_ColossusService__FromDollToGolem
		                        (*(undefined4 *)(param1 + 0x18),param2,param3,param4,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_WorldAxis_Controller_WorldAxisController_FromGolemToDollResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D9")]
		[Address(RVA = "0x62D6", Offset = "0x62D6", VA = "0x62D6")]
		public void FromGolemToDoll(ulong artifactId, ulong dollId, uint slotId)
		{
		/* --- GHIDRA: FromGolemToDoll ---
		void Gameplay_WorldAxis_Controller_WorldAxisController__FromGolemToDoll
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *param1_00;
		  int local_4;
		  
		  if (DAT_ram_00a58b02 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7403);
		    DAT_ram_00a58b02 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Main_ProtoStackableChangesAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (param1_00[3] < 0) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    local_4 = param1_00[3];
		    uVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    uVar2 = func_ii_4419(StringLiteral_7403,uVar2,0);
		    Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		  }
		  else {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar3 = *(int *)(iVar3 + 0x1c);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),param1_00,*(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060010DA RID: 4314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010DA")]
		[Address(RVA = "0x62D7", Offset = "0x62D7", VA = "0x62D7")]
		private void FromGolemToDollResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: FromGolemToDollResultHandler ---
		void Gameplay_WorldAxis_Controller_WorldAxisController__FromGolemToDollResultHandler
		               (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58b03 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_int__int___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_GolemInventoryModel__StartResolveEmptySlotsProcess__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_int__int__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Controller_WorldAxisController___c__DisplayClass15_0__FromDollToGolem_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Controller_WorldAxisController___c__DisplayClass15_0_TypeInfo);
		    DAT_ram_00a58b03 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_WorldAxis_Controller_WorldAxisController___c__DisplayClass15_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0x18) = param3;
		  *(undefined8 *)(param2_00 + 0x10) = param2;
		  *(int **)(param2_00 + 8) = param1;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_object___ShowNotAvailableSlotsWindow
		                        (*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x14) + 0x20),1,2,
		                         Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_GolemInventoryModel__StartResolveEmptySlotsProcess__
		                        );
		  param1_01 = unnamed_function_1417(System_Action_OpToken_int__int___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param2_00,
		             Method_Gameplay_WorldAxis_Controller_WorldAxisController___c__DisplayClass15_0__FromDollToGolem_b__0__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_int__int__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010DB")]
		[Address(RVA = "0x62D8", Offset = "0x62D8", VA = "0x62D8")]
		public void FromDollToGolem(ulong artifactId, uint fromSlotId)
		{
		/* --- GHIDRA: FromDollToGolem ---
		void Gameplay_WorldAxis_Controller_WorldAxisController__FromDollToGolem
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  int iVar3;
		  uint *puVar4;
		  int *param1_01;
		  int *piVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  int local_4;
		  
		  if (DAT_ram_00a58b04 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__ParseSlotChanges__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__Add__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_UserArtifact_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7403);
		    DAT_ram_00a58b04 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Main_ProtoStackableChangesAns_TypeInfo != *param1_01))
		  {
		    System_Activator__CreateInstance(param1_01,Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (param1_01[3] < 0) {
		    uVar6 = System_Uri___ctor(0);
		    uVar6 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar6,0);
		    local_4 = param1_01[3];
		    uVar7 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    uVar7 = func_ii_4419(StringLiteral_7403,uVar7,0);
		    Core_Application_App__get_ToastController(uVar6,2,uVar7,0);
		  }
		  else {
		    piVar5 = *(int **)(param2 + 0xc);
		    if (piVar5 == (int *)0x0) {
		      System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (*(int *)(*piVar5 + 0x20) != *(int *)(DAT_ram_00a66958 + 0x20)) {
		      System_Activator__CreateInstance(piVar5,DAT_ram_00a66958);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    puVar2 = (undefined4 *)func_ii_15774(piVar5);
		    uVar6 = *puVar2;
		    param1_00 = unnamed_function_1417(Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    Protocol_Main_ProtoStackableChangesAns__pb__Google_Protobuf_IMessage_get_Descriptor(param1_00,0)
		    ;
		    uVar7 = *(undefined4 *)(param1_00 + 0x10);
		    iVar3 = unnamed_function_1417(Protocol_Main_UserArtifact_TypeInfo);
		    *(undefined4 *)(iVar3 + 0xc) = uVar6;
		    *(undefined4 *)(iVar3 + 0x10) = 0;
		    func_ii_6441(uVar7,iVar3,Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__Add__);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar3 = *piVar5;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x238);
		          goto code_r0x80f75c11;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x2f);
		code_r0x80f75c11:
		    iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		    Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleSuccessDismantle
		              (*(undefined4 *)(iVar3 + 0x14),param1_01[4],
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_GolemInventoryModel__GolemInventoryEvents__ParseSlotChanges__
		              );
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar3 = *(int *)(iVar3 + 0x1c);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),param1_00,*(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060010DC RID: 4316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010DC")]
		[Address(RVA = "0x62D9", Offset = "0x62D9", VA = "0x62D9")]
		private void FromDollToGolemResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: FromDollToGolemResultHandler ---
		void Gameplay_WorldAxis_Controller_WorldAxisController__FromDollToGolemResultHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58b05 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_Controller_WorldAxisController_SelectDollResultHandler__);
		    DAT_ram_00a58b05 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ColossusService__SwapPartySlot
		                    (*(undefined4 *)(param1 + 0x18),*(undefined8 *)(*(int *)(param2 + 0xc) + 0x10),0
		                    );
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_WorldAxis_Controller_WorldAxisController_SelectDollResultHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  DG_Tweening_TweenParams__SetId
		            (uVar1,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  return;
		}
		*/

		}

		// Token: 0x060010DD RID: 4317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010DD")]
		[Address(RVA = "0x62DA", Offset = "0x62DA", VA = "0x62DA")]
		public void SelectDoll(DollsInfoDic doll)
		{
		/* --- GHIDRA: SelectDoll ---
		void Gameplay_WorldAxis_Controller_WorldAxisController__SelectDoll
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a58b06 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_DollsInfoDic_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoSlotsChanged_TypeInfo);
		    DAT_ram_00a58b06 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(int **)(param2 + 0xc);
		  if ((param1_00 != (int *)0x0) && (Protocol_Dic_DollsInfoDic_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Dic_DollsInfoDic_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int **)(iVar1 + 0x24) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x060010DE RID: 4318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010DE")]
		[Address(RVA = "0x62DB", Offset = "0x62DB", VA = "0x62DB")]
		private void SelectDollResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: SelectDollResultHandler ---
		void Gameplay_WorldAxis_Controller_WorldAxisController__SelectDollResultHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58b07 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Controller_WorldAxisController_GetColossusInfoResultHandler__
		              );
		    DAT_ram_00a58b07 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ColossusService__ServerEventHandler(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_WorldAxis_Controller_WorldAxisController_GetColossusInfoResultHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060010DF RID: 4319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010DF")]
		[Address(RVA = "0x62DC", Offset = "0x62DC", VA = "0x62DC")]
		public void GetColossusInfo()
		{
		/* --- GHIDRA: GetColossusInfo ---
		void Gameplay_WorldAxis_Controller_WorldAxisController__GetColossusInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a58b08 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetColossusInfoAns_TypeInfo);
		    DAT_ram_00a58b08 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Colossus_ProtoGetColossusInfoAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Colossus_ProtoGetColossusInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_WorldAxis_Model_WorldAxisModel__UpdateData(param1_00,param1_01,param1);
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

		// Token: 0x060010E0 RID: 4320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E0")]
		[Address(RVA = "0x62DD", Offset = "0x62DD", VA = "0x62DD")]
		private void GetColossusInfoResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetColossusInfoResultHandler ---
		void Gameplay_WorldAxis_Controller_WorldAxisController__GetColossusInfoResultHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  float fVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined8 uVar6;
		  
		  if (DAT_ram_00a58b09 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_Controller_WorldAxisController_GetSchedule__);
		    DAT_ram_00a58b09 = '\x01';
		  }
		  uVar6 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar6);
		  uVar4 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  iVar5 = *(int *)(param2 + 0x10);
		  if (iVar5 == 0) {
		    *(undefined1 *)(iVar1 + 0x20) = 0;
		  }
		  else {
		    uVar6 = *(undefined8 *)(iVar5 + 0x10);
		    *(byte *)(iVar1 + 0x20) = (byte)((ulonglong)uVar6 >> 0x3f);
		    uVar2 = Gameplay_WorldAxis_Model_WorldAxisModel__GetAttackState
		                      (iVar1,uVar6,*(undefined8 *)(iVar5 + 0x18),param1);
		    uVar4 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    *(undefined4 *)(iVar1 + 0x1c) = uVar2;
		  }
		  if (*(int *)(*(int *)(iVar1 + 0x18) + 0xc) == 0) {
		    Gameplay_WorldAxis_Model_WorldAxisModel__PopulateSchedule(iVar1,param2,param1);
		  }
		  else {
		    Gameplay_WorldAxis_Model_WorldAxisModel__CreateData(iVar1,param2,param1);
		  }
		  uVar6 = CONCAT44(uVar4,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(param1,uVar6);
		  uVar4 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    uVar6 = CONCAT44(uVar4,*(undefined4 *)(iVar1 + 0x14));
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))(*(undefined4 *)(iVar1 + 0x20),uVar6);
		    uVar4 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  }
		  if (param1[8] != 0) {
		    func_ii_7891(param1[8],0,0);
		  }
		  uVar6 = CONCAT44(uVar4,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar6);
		  if (*(int *)(iVar1 + 0x1c) != 0) {
		    uVar6 = CONCAT44((int)((ulonglong)uVar6 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar6);
		    uVar4 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    fVar3 = func_ii_7103(*(undefined4 *)(iVar1 + 0x1c),0);
		    if (0.0 < fVar3) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,CONCAT44(uVar4,*(undefined4 *)(*param1 + 0x104)));
		      fVar3 = func_ii_7103(*(undefined4 *)(iVar1 + 0x1c),0);
		      uVar4 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		      DG_Tweening_Color2__op_Multiply
		                (uVar4,param1,Method_Gameplay_WorldAxis_Controller_WorldAxisController_GetSchedule__
		                 ,0);
		      iVar1 = DG_Tweening_DOVirtual__EasedValue(fVar3,uVar4,1,0);
		      param1[8] = iVar1;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E1")]
		[Address(RVA = "0x62DE", Offset = "0x62DE", VA = "0x62DE")]
		private void ScheduleChangedEventHandler(ProtoGetScheduleAns msg)
		{
		/* --- GHIDRA: ScheduleChangedEventHandler ---
		void Gameplay_WorldAxis_Controller_WorldAxisController__ScheduleChangedEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_WorldAxis_Model_WorldAxisModel__UpdateData(param1_00,param2,param1);
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

		// Token: 0x060010E2 RID: 4322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E2")]
		[Address(RVA = "0x62DF", Offset = "0x62DF", VA = "0x62DF")]
		private void ColossusChangedEventHandler(ProtoGetColossusInfoAns msg)
		{
		/* --- GHIDRA: ColossusChangedEventHandler ---
		void Gameplay_WorldAxis_Controller_WorldAxisController__ColossusChangedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_WorldAxis_Controller_WorldAxisController__GetSchedultResultHandler(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E3")]
		[Address(RVA = "0x62E0", Offset = "0x62E0", VA = "0x62E0")]
		private void ClanStatusChangedEventHandler()
		{
		}

		// Token: 0x040008B1 RID: 2225
		[Token(Token = "0x40008B1")]
		[FieldOffset(Offset = "0x18")]
		private ColossusService _service;

		// Token: 0x040008B2 RID: 2226
		[Token(Token = "0x40008B2")]
		[FieldOffset(Offset = "0x1C")]
		private ClansEvents _clansEvents;

		// Token: 0x040008B3 RID: 2227
		[Token(Token = "0x40008B3")]
		[FieldOffset(Offset = "0x20")]
		private Tween _timer;
	}
}
