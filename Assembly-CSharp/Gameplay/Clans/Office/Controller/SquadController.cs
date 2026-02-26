using System;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Colossus;
using Protocol.Common;
using ServicesNamespace;
using Utils;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A78 RID: 2680
	[Token(Token = "0x2000A78")]
	public class SquadController : AbstractController<SquadModel, SquadEvents>
	{
		// Token: 0x06003FCE RID: 16334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FCE")]
		[Address(RVA = "0x8E88", Offset = "0x8E88", VA = "0x8E88")]
		public SquadController(SquadModel model, SquadEvents events, ClanInfoController clanInfoController)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_SquadController___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a576b8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSlotsChanged__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_SquadController_SlotsChangedEventHandler__);
		    DAT_ram_00a576b8 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x18);
		  param1_00 = unnamed_function_1417(System_Action_ProtoSlotsChanged__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Office_Controller_SquadController_SlotsChangedEventHandler__,0);
		  ServicesNamespace_ColossusService__get_ServiceId(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003FCF RID: 16335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FCF")]
		[Address(RVA = "0x8E89", Offset = "0x8E89", VA = "0x8E89", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Clans_Office_Controller_SquadController__HandleRun(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a576b9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSlotsChanged__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_SquadController_SlotsChangedEventHandler__);
		    DAT_ram_00a576b9 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x18);
		  param1_00 = unnamed_function_1417(System_Action_ProtoSlotsChanged__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Office_Controller_SquadController_SlotsChangedEventHandler__,0);
		  ServicesNamespace_ColossusService__add_SlotsChangedEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003FD0 RID: 16336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD0")]
		[Address(RVA = "0x8E8A", Offset = "0x8E8A", VA = "0x8E8A", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Clans_Office_Controller_SquadController__HandleStop(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a576ba == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_SquadController_GetPartyInfoResultHandler__)
		    ;
		    DAT_ram_00a576ba = '\x01';
		  }
		  param1_00 = ServicesNamespace_ColossusService__GetColossusInfo(*(undefined4 *)(param1 + 0x18),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Clans_Office_Controller_SquadController_GetPartyInfoResultHandler__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06003FD1 RID: 16337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD1")]
		[Address(RVA = "0x8E8B", Offset = "0x8E8B", VA = "0x8E8B")]
		public void GetPartyInfo()
		{
		/* --- GHIDRA: GetPartyInfo ---
		void Gameplay_Clans_Office_Controller_SquadController__GetPartyInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a576bb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetPartyInfoAns_TypeInfo);
		    DAT_ram_00a576bb = '\x01';
		  }
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
		  Gameplay_Clans_Office_Model_SquadModel___ctor(param1_00,param1_01[3],0);
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

		// Token: 0x06003FD2 RID: 16338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD2")]
		[Address(RVA = "0x8E8C", Offset = "0x8E8C", VA = "0x8E8C")]
		private void GetPartyInfoResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetPartyInfoResultHandler ---
		void Gameplay_Clans_Office_Controller_SquadController__GetPartyInfoResultHandler
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined8 param4_00;
		  int param1_02;
		  
		  if (DAT_ram_00a576bc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_SquadController_SwapPartySlotResultHandler__
		              );
		    DAT_ram_00a576bc = '\x01';
		  }
		  param1_02 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param4_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(iVar1 + 8),0);
		  param1_00 = ServicesNamespace_ColossusService__GetColossusRating
		                        (param1_02,param2,param3,param4_00,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Clans_Office_Controller_SquadController_SwapPartySlotResultHandler__,0)
		  ;
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06003FD3 RID: 16339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD3")]
		[Address(RVA = "0x8E8D", Offset = "0x8E8D", VA = "0x8E8D")]
		public void SwapPartySlot(uint partyId, uint slotId)
		{
		}

		// Token: 0x06003FD4 RID: 16340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD4")]
		[Address(RVA = "0x8E8E", Offset = "0x8E8E", VA = "0x8E8E")]
		private void SwapPartySlotResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: SwapPartySlotResultHandler ---
		void Gameplay_Clans_Office_Controller_SquadController__SwapPartySlotResultHandler
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a576bd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_SquadController_BuyPartySlotReslutHandler__)
		    ;
		    DAT_ram_00a576bd = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = *(int **)(iVar2 + 0x1c);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_Balance_IBalanceSource_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8))
		      {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		        goto code_r0x80dc7994;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Data_Balance_IBalanceSource_TypeInfo,2);
		code_r0x80dc7994:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  iVar2 = Core_Errors_Expected_Clans_ExpectedClanBillingErrors__Handle(uVar4,param3,0);
		  if (iVar2 != 0) {
		    uVar4 = ServicesNamespace_ColossusService__BuyParty(param1[6],param2,0);
		    param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Gameplay_Clans_Office_Controller_SquadController_BuyPartySlotReslutHandler__,0
		              );
		    ServicesNamespace_MainService__GetUserStats
		              (uVar4,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003FD5 RID: 16341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD5")]
		[Address(RVA = "0x8E8F", Offset = "0x8E8F", VA = "0x8E8F")]
		public void BuyPartySlot(uint partyId, ResourceSet price)
		{
		}

		// Token: 0x06003FD6 RID: 16342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD6")]
		[Address(RVA = "0x8E90", Offset = "0x8E90", VA = "0x8E90")]
		private void BuyPartySlotReslutHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: BuyPartySlotReslutHandler ---
		void Gameplay_Clans_Office_Controller_SquadController__BuyPartySlotReslutHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a576be == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_SquadController_BuyPartyReslutHandler__);
		    DAT_ram_00a576be = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = *(int **)(iVar2 + 0x1c);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_Balance_IBalanceSource_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8))
		      {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		        goto code_r0x80dc7ab5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Data_Balance_IBalanceSource_TypeInfo,2);
		code_r0x80dc7ab5:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  iVar2 = Core_Errors_Expected_Clans_ExpectedClanBillingErrors__Handle(uVar4,param2,0);
		  if (iVar2 != 0) {
		    uVar4 = ServicesNamespace_ColossusService__UserDollSelect(param1[6],0);
		    param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Gameplay_Clans_Office_Controller_SquadController_BuyPartyReslutHandler__,0);
		    ServicesNamespace_MainService__GetUserStats
		              (uVar4,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003FD7 RID: 16343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD7")]
		[Address(RVA = "0x8E91", Offset = "0x8E91", VA = "0x8E91")]
		public void BuyParty(ResourceSet price)
		{
		/* --- GHIDRA: BuyParty ---
		void Gameplay_Clans_Office_Controller_SquadController__BuyParty
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Clans_Office_Controller_SquadController__SlotsChangedEventHandler(param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06003FD8 RID: 16344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD8")]
		[Address(RVA = "0x8E92", Offset = "0x8E92", VA = "0x8E92")]
		private void BuyPartyReslutHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: BuyPartyReslutHandler ---
		void Gameplay_Clans_Office_Controller_SquadController__BuyPartyReslutHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Clans_Office_Model_SquadModel__PopulateParties
		            (param1_00,*(undefined4 *)(param2 + 0x10),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x20);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(*(int *)(iVar1 + 0x18) + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003FD9 RID: 16345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD9")]
		[Address(RVA = "0x8E93", Offset = "0x8E93", VA = "0x8E93")]
		private void SlotsChangedEventHandler(ProtoSlotsChanged msg)
		{
		/* --- GHIDRA: SlotsChangedEventHandler ---
		void Gameplay_Clans_Office_Controller_SquadController__SlotsChangedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a576bf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedSlotsChangedErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoSlotsChanged_TypeInfo);
		    DAT_ram_00a576bf = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Colossus_ProtoSlotsChanged_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Colossus_ProtoSlotsChanged_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_01[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedSlotsChangedErrors___
		                    );
		  if (iVar1 == 0) {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_Clans_Office_Model_SquadModel__PopulateParties(param1_00,param1_01[4],0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x20);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(*(int *)(iVar1 + 0x18) + 0x18);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(*(int *)(iVar1 + 0x18) + 0x18);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003FDA RID: 16346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FDA")]
		[Address(RVA = "0x8E94", Offset = "0x8E94", VA = "0x8E94")]
		private void ChangeSlotsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: ChangeSlotsResultHandler ---
		void Gameplay_Clans_Office_Controller_SquadController__ChangeSlotsResultHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a576c0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SquadModel__SquadEvents__SquadController__SquadView___ctor__
		              );
		    DAT_ram_00a576c0 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_SquadModel__SquadEvents__SquadController__SquadView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x040023B7 RID: 9143
		[Token(Token = "0x40023B7")]
		[FieldOffset(Offset = "0x18")]
		private ColossusService _service;

		// Token: 0x040023B8 RID: 9144
		[Token(Token = "0x40023B8")]
		[FieldOffset(Offset = "0x1C")]
		public readonly ClanInfoController ClanInfoController;
	}
}
