using System;
using Gameplay.Clans.Combat.Model;
using Gameplay.Combat.Control;
using Gameplay.Combat.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.ClanWar;
using Protocol.Combat;
using Protocol.Common;
using ServicesNamespace;
using Utils;

namespace Gameplay.Clans.Combat.Control
{
	// Token: 0x02000AA2 RID: 2722
	[Token(Token = "0x2000AA2")]
	public class ClanCombatController : CombatController<ClanCombatModel, ClanCombatEvents>
	{
		// Token: 0x06004179 RID: 16761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004179")]
		[Address(RVA = "0x9030", Offset = "0x9030", VA = "0x9030", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Clans_Combat_Control_ClanCombatController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  if (DAT_ram_00a5779b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents___ctor__
		              );
		    DAT_ram_00a5779b = '\x01';
		  }
		  Sirenix_Serialization_ColorBlockFormatter___Il2CppFullySharedGenericType___Write
		            (param1,param3,param4,param5,
		             Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents___ctor__
		            );
		  *(undefined4 *)(param1 + 0x20) = param2;
		  return;
		}
		*/

		}

		// Token: 0x0600417A RID: 16762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600417A")]
		[Address(RVA = "0x9031", Offset = "0x9031", VA = "0x9031")]
		public ClanCombatController(ClanWarsService clanWarsService, ICombatService service, ClanCombatModel model, ClanCombatEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Combat_Control_ClanCombatController___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int iVar4;
		  int *param1_00;
		  int local_4;
		  
		  if (DAT_ram_00a5779c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__HandleRun__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__PrepareView__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_ClanWars_IClanWars_TypeInfo);
		    DAT_ram_00a5779c = '\x01';
		  }
		  local_4 = 0;
		  Gameplay_Combat_Control_CombatController_object__object___HandleRewardsGot
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__HandleRun__
		            );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar4 = *(int *)(iVar2 + 0x40);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (iVar4 == 0) {
		    if (*(char *)(iVar2 + 100) == '\0') {
		      Gameplay_Combat_Control_CombatController_object__object___PrepareField
		                (param1,
		                 Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__PrepareView__
		                );
		    }
		    else {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar1 = 0;
		      param1_00 = *(int **)(iVar2 + 0x60);
		      iVar2 = *param1_00;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Clans_ClanWars_IClanWars_TypeInfo ==
		              *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80dd9461;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(param1_00,Gameplay_Clans_ClanWars_IClanWars_TypeInfo,0);
		code_r0x80dd9461:
		      iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,&local_4,puVar3[1]);
		      if (iVar2 == 0) {
		        Gameplay_Clans_Combat_Control_ClanCombatController__NotifyShowViewProcessComplete
		                  (param1,param1);
		      }
		      else {
		        Gameplay_Clans_Combat_Control_ClanCombatController__HandleRequestCombatService
		                  (param1,*(undefined4 *)(*(int *)(local_4 + 0xc) + 0xc),param1);
		      }
		    }
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		              (param1,*(undefined4 *)(iVar2 + 0x40),*(undefined4 *)(*param1 + 0x14c));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600417B RID: 16763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600417B")]
		[Address(RVA = "0x9032", Offset = "0x9032", VA = "0x9032", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Clans_Combat_Control_ClanCombatController__HandleRun(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *piVar4;
		  undefined4 param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a5779d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPlayerAddedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoClanWarCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoDefaultUserCmd__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSwitchTurnEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Combat_Control_ClanCombatController_HandleClanWarComplete__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Combat_Control_ClanCombatController_HandlePlayerAddedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Combat_Control_ClanCombatController_HandlePlayerRemovedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Combat_Control_ClanCombatController_HandleSwitchTurnServiceEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__AddCombatServiceEventsHandlers__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__get_CombatService__
		              );
		    Mono_Security_ASN1__get_Item(&ServicesNamespace_ICombatService_TypeInfo);
		    DAT_ram_00a5779d = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_ProtoPlayerAddedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatController_HandlePlayerAddedEvent__,0);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (ServicesNamespace_ICombatService_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		      {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 400);
		        goto code_r0x80dd97cd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,ServicesNamespace_ICombatService_TypeInfo,0x1a);
		code_r0x80dd97cd:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,uVar2,puVar3[1]);
		  piVar4 = *(int **)(param1 + 0x18);
		  uVar1 = 0;
		  uVar2 = unnamed_function_1417(System_Action_ProtoDefaultUserCmd__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatController_HandlePlayerRemovedEvent__,0)
		  ;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (ServicesNamespace_ICombatService_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		      {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1a0);
		        goto code_r0x80dd986f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,ServicesNamespace_ICombatService_TypeInfo,0x1c);
		code_r0x80dd986f:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,uVar2,puVar3[1]);
		  piVar4 = *(int **)(param1 + 0x18);
		  uVar1 = 0;
		  uVar2 = unnamed_function_1417(System_Action_ProtoSwitchTurnEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatController_HandleSwitchTurnServiceEvent__
		             ,0);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (ServicesNamespace_ICombatService_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		      {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x80dd9911;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,ServicesNamespace_ICombatService_TypeInfo,2);
		code_r0x80dd9911:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,uVar2,puVar3[1]);
		  param1_00 = *(undefined4 *)(param1 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_ProtoClanWarCompleteEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatController_HandleClanWarComplete__,0);
		  ServicesNamespace_ClanWarsService__remove_PlayersCountChangedEvent(param1_00,uVar2,0);
		  Gameplay_Combat_Control_CombatController_object__object____HandleSpellAppliedServiceEvent_g__Handler_42_0
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__AddCombatServiceEventsHandlers__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600417C RID: 16764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600417C")]
		[Address(RVA = "0x9033", Offset = "0x9033", VA = "0x9033", Slot = "15")]
		protected override void AddCombatServiceEventsHandlers()
		{
		/* --- GHIDRA: AddCombatServiceEventsHandlers ---
		void Gameplay_Clans_Combat_Control_ClanCombatController__AddCombatServiceEventsHandlers
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *piVar4;
		  undefined4 param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a5779e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPlayerAddedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoClanWarCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoDefaultUserCmd__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSwitchTurnEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Combat_Control_ClanCombatController_HandleClanWarComplete__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Combat_Control_ClanCombatController_HandlePlayerAddedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Combat_Control_ClanCombatController_HandlePlayerRemovedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Combat_Control_ClanCombatController_HandleSwitchTurnServiceEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__RemoveCombatServiceEventsHandlers__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__get_CombatService__
		              );
		    Mono_Security_ASN1__get_Item(&ServicesNamespace_ICombatService_TypeInfo);
		    DAT_ram_00a5779e = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_ProtoPlayerAddedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatController_HandlePlayerAddedEvent__,0);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (ServicesNamespace_ICombatService_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		      {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x198);
		        goto code_r0x80dd9a63;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,ServicesNamespace_ICombatService_TypeInfo,0x1b);
		code_r0x80dd9a63:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,uVar2,puVar3[1]);
		  piVar4 = *(int **)(param1 + 0x18);
		  uVar1 = 0;
		  uVar2 = unnamed_function_1417(System_Action_ProtoDefaultUserCmd__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatController_HandlePlayerRemovedEvent__,0)
		  ;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (ServicesNamespace_ICombatService_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		      {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1a8);
		        goto code_r0x80dd9b05;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,ServicesNamespace_ICombatService_TypeInfo,0x1d);
		code_r0x80dd9b05:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,uVar2,puVar3[1]);
		  piVar4 = *(int **)(param1 + 0x18);
		  uVar1 = 0;
		  uVar2 = unnamed_function_1417(System_Action_ProtoSwitchTurnEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatController_HandleSwitchTurnServiceEvent__
		             ,0);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (ServicesNamespace_ICombatService_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		      {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x80dd9ba7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,ServicesNamespace_ICombatService_TypeInfo,3);
		code_r0x80dd9ba7:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,uVar2,puVar3[1]);
		  param1_00 = *(undefined4 *)(param1 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_ProtoClanWarCompleteEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatController_HandleClanWarComplete__,0);
		  ServicesNamespace_ClanWarsService__add_ClanWarCompletedEvent(param1_00,uVar2,0);
		  Gameplay_Combat_Control_CombatController_object__object___PrepareView
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__RemoveCombatServiceEventsHandlers__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600417D RID: 16765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600417D")]
		[Address(RVA = "0x9034", Offset = "0x9034", VA = "0x9034", Slot = "16")]
		protected override void RemoveCombatServiceEventsHandlers()
		{
		/* --- GHIDRA: RemoveCombatServiceEventsHandlers ---
		void Gameplay_Clans_Combat_Control_ClanCombatController__RemoveCombatServiceEventsHandlers
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x138) * 4))
		                    (piVar1,param2,*(undefined4 *)(*piVar1 + 0x13c));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar3 = *(int *)(iVar3 + 0x30);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		            (*(undefined4 *)(iVar3 + 0x20),uVar2,*(undefined4 *)(iVar3 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x0600417E RID: 16766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600417E")]
		[Address(RVA = "0x9035", Offset = "0x9035", VA = "0x9035")]
		private void AddPlayer(PlayerInfo info)
		{
		/* --- GHIDRA: AddPlayer ---
		void Gameplay_Clans_Combat_Control_ClanCombatController__AddPlayer
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 local_4;
		  
		  local_4 = 0;
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x140) * 4))
		                    (piVar1,param2,&local_4,*(undefined4 *)(*piVar1 + 0x144));
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x34);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),local_4,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600417F RID: 16767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600417F")]
		[Address(RVA = "0x9036", Offset = "0x9036", VA = "0x9036")]
		private void RemovePlayer(ulong userId)
		{
		/* --- GHIDRA: RemovePlayer ---
		void Gameplay_Clans_Combat_Control_ClanCombatController__RemovePlayer
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 in_register_20000014;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  float param2_00;
		  int iVar7;
		  undefined4 *puVar8;
		  undefined4 param2_01;
		  undefined8 uVar9;
		  undefined8 uVar10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5779f == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__SetJoinToCombatInfo__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__SwitchTurn__
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_CombatEvent_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_CombatPlayer__ulong___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ulong___);
		    Mono_Security_ASN1__get_Item(&System_Func_CombatPlayer__ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoCombatEventsEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_CombatEvent__Add__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Combat_Control_ClanCombatController___c__Join_b__8_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Combat_Control_ClanCombatController___c_TypeInfo);
		    DAT_ram_00a5779f = '\x01';
		  }
		  uVar10 = CONCAT44(in_register_20000004,param1);
		  uVar9 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(uVar10,uVar9);
		  *(undefined1 *)(iVar3 + 0x65) = 0;
		  uVar10 = CONCAT44((int)((ulonglong)uVar10 >> 0x20),param1);
		  uVar9 = CONCAT44((int)((ulonglong)uVar9 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(uVar10,uVar9);
		  *(undefined1 *)(iVar3 + 100) = 0;
		  uVar10 = CONCAT44((int)((ulonglong)uVar10 >> 0x20),param1);
		  uVar9 = CONCAT44((int)((ulonglong)uVar9 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(uVar10,uVar9);
		  uVar1 = (undefined4)((ulonglong)uVar10 >> 0x20);
		  uVar2 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  uVar4 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(iVar3 + 0x1c),
		                     Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__)
		  ;
		  if (*(int *)(Gameplay_Clans_Combat_Control_ClanCombatController___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Clans_Combat_Control_ClanCombatController___c_TypeInfo);
		  }
		  puVar8 = *(undefined4 **)(Gameplay_Clans_Combat_Control_ClanCombatController___c_TypeInfo + 0x5c);
		  iVar3 = puVar8[1];
		  if (iVar3 == 0) {
		    if (*(int *)(Gameplay_Clans_Combat_Control_ClanCombatController___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Clans_Combat_Control_ClanCombatController___c_TypeInfo);
		      puVar8 = *(undefined4 **)
		                (Gameplay_Clans_Combat_Control_ClanCombatController___c_TypeInfo + 0x5c);
		    }
		    param2_01 = *puVar8;
		    iVar3 = unnamed_function_1417(System_Func_CombatPlayer__ulong__TypeInfo);
		    func_ii_7542(iVar3,param2_01,
		                 Method_Gameplay_Clans_Combat_Control_ClanCombatController___c__Join_b__8_0__,0);
		    *(int *)(*(int *)(Gameplay_Clans_Combat_Control_ClanCombatController___c_TypeInfo + 0x5c) + 4) =
		         iVar3;
		  }
		  iVar7 = 0;
		  uVar4 = System_Linq_Enumerable__Select_uint__Int32Enum_
		                    (uVar4,iVar3,Method_System_Linq_Enumerable_Select_CombatPlayer__ulong___);
		  uVar10 = CONCAT44(uVar1,uVar4);
		  iVar3 = System_Linq_Enumerable__ToArray_PlayerLoopSystem_
		                    (uVar4,Method_System_Linq_Enumerable_ToArray_ulong___);
		  uVar1 = (undefined4)((ulonglong)uVar10 >> 0x20);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      uVar9 = *(undefined8 *)(iVar3 + iVar7 * 8 + 0x10);
		      local_4 = 0;
		      uVar10 = CONCAT44((int)((ulonglong)uVar10 >> 0x20),param1);
		      piVar5 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                                (uVar10,*(undefined4 *)(*param1 + 0x104));
		      uVar10 = CONCAT44((int)((ulonglong)uVar10 >> 0x20),piVar5);
		      iVar6 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x140) * 4))
		                        (uVar10,uVar9,&local_4,*(undefined4 *)(*piVar5 + 0x144));
		      uVar2 = (undefined4)((ulonglong)uVar9 >> 0x20);
		      if (iVar6 != 0) {
		        uVar10 = CONCAT44((int)((ulonglong)uVar10 >> 0x20),param1);
		        uVar9 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x114));
		        iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(uVar10,uVar9);
		        iVar6 = *(int *)(iVar6 + 0x34);
		        uVar10 = CONCAT44((int)((ulonglong)uVar10 >> 0x20),*(undefined4 *)(iVar6 + 0x20));
		        uVar9 = CONCAT44((int)((ulonglong)uVar9 >> 0x20),local_4);
		        (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))
		                  (uVar10,uVar9,*(undefined4 *)(iVar6 + 0x14));
		        uVar2 = (undefined4)((ulonglong)uVar9 >> 0x20);
		      }
		      uVar1 = (undefined4)((ulonglong)uVar10 >> 0x20);
		      iVar7 = iVar7 + 1;
		    } while (iVar7 < *(int *)(iVar3 + 0xc));
		  }
		  uVar10 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(CONCAT44(uVar1,param1),uVar10);
		  uVar1 = (undefined4)((ulonglong)uVar10 >> 0x20);
		  uVar10 = *(undefined8 *)(*(int *)(param2 + 0x10) + 0x10);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = Utils_StringUtils___cctor(uVar10,0);
		  uVar2 = (undefined4)((ulonglong)uVar10 >> 0x20);
		  uVar4 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar4,param2_00,0);
		  *(undefined4 *)(iVar3 + 0x7c) = uVar4;
		  Gameplay_Combat_Control_CombatController_object__object___SelectSpell
		            (param1,*(undefined4 *)(param2 + 0x10),
		             Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__SetJoinToCombatInfo__
		            );
		  iVar3 = unnamed_function_1417(Protocol_Combat_ProtoCombatEventsEvt_TypeInfo);
		  Gameplay_Combat_View_GameField_GameFieldMono__ShowSwapStones(iVar3,0);
		  uVar4 = *(undefined4 *)(iVar3 + 0xc);
		  iVar7 = unnamed_function_1417(Protocol_Combat_CombatEvent_TypeInfo);
		  *(undefined4 *)(iVar7 + 0xc) = 7;
		  func_ii_6441(uVar4,iVar7,Method_Google_Protobuf_Collections_RepeatedField_CombatEvent__Add__);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (CONCAT44(uVar2,param1),CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x114)));
		  iVar7 = *(int *)(iVar7 + 0x28);
		  (**(code **)((ulonglong)*(uint *)(iVar7 + 0xc) * 4))
		            (*(undefined4 *)(iVar7 + 0x20),iVar3,*(undefined4 *)(iVar7 + 0x14));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar3 = *(int *)(iVar3 + 0x74);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		            (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Combat_Control_CombatController_object__object___Swap
		            (param1,*(undefined8 *)(*(int *)(iVar3 + 0x34) + 0x10),
		             Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__SwitchTurn__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004180 RID: 16768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004180")]
		[Address(RVA = "0x9037", Offset = "0x9037", VA = "0x9037")]
		private void Join(ProtoJoinToCombatAns msg)
		{
		/* --- GHIDRA: Join ---
		void Gameplay_Clans_Combat_Control_ClanCombatController__Join
		               (int *param1,int param2,undefined4 param3)
		
		{
		  char cVar1;
		  char cVar2;
		  uint uVar3;
		  undefined4 in_register_20000014;
		  undefined4 uVar4;
		  undefined8 uVar5;
		  int iVar6;
		  int *piVar7;
		  undefined4 uVar8;
		  int iVar9;
		  undefined4 uVar10;
		  undefined4 uVar11;
		  undefined4 param1_00;
		  uint *puVar12;
		  undefined4 param2_00;
		  undefined8 uVar13;
		  
		  if (DAT_ram_00a577a0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__TryAppendGameOverToCombatEvents__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Item__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Combat_Model_GameOverData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_ClanWars_IClanWars_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_PlayerProfitData_TypeInfo);
		    DAT_ram_00a577a0 = '\x01';
		  }
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  cVar1 = *(char *)(param2 + 0x24);
		  piVar7 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar8 = (**(code **)((ulonglong)*(uint *)(*piVar7 + 0x100) * 4))
		                    (piVar7,*(undefined4 *)(*piVar7 + 0x104));
		  iVar9 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar13 = *(undefined8 *)(param2 + 0x18);
		  uVar10 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                     (*(undefined4 *)(iVar9 + 0x1c),uVar13,
		                      Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Item__);
		  cVar2 = *(char *)(param2 + 0x24);
		  uVar13 = CONCAT44((int)((ulonglong)uVar13 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		  piVar7 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar13);
		  if (cVar2 == '\0') {
		    uVar13 = CONCAT44((int)((ulonglong)uVar13 >> 0x20),*(undefined4 *)(*piVar7 + 0x104));
		    uVar11 = (**(code **)((ulonglong)*(uint *)(*piVar7 + 0x100) * 4))(piVar7,uVar13);
		    uVar4 = (undefined4)((ulonglong)uVar13 >> 0x20);
		  }
		  else {
		    uVar13 = *(undefined8 *)(param2 + 0x18);
		    uVar11 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                       (piVar7[7],uVar13,
		                        Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Item__
		                       );
		    uVar4 = (undefined4)((ulonglong)uVar13 >> 0x20);
		  }
		  param2_00 = *(undefined4 *)(param2 + 0x28);
		  uVar3 = 0;
		  param1_00 = unnamed_function_1417(Gameplay_Combat_Model_PlayerProfitData_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,param2_00,0);
		  iVar9 = unnamed_function_1417(Gameplay_Clans_Combat_Model_GameOverData_TypeInfo);
		  uVar13 = Core_Data_UserData__get_UserId(uVar10,0);
		  Gameplay_Combat_Model_GameFieldGamesData___ctor
		            (iVar9,(uint)(cVar1 != '\0'),uVar13,uVar11,2,param1_00,0);
		  uVar11 = (undefined4)((ulonglong)uVar13 >> 0x20);
		  *(undefined4 *)(iVar9 + 0x2c) = uVar10;
		  *(undefined4 *)(iVar9 + 0x28) = uVar8;
		  *(undefined4 *)(iVar9 + 0x24) = 0;
		  *(int *)(iVar6 + 0x10) = iVar9;
		  uVar13 = CONCAT44(uVar4,*(undefined4 *)(*param1 + 0x104));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar13);
		  uVar8 = (undefined4)((ulonglong)uVar13 >> 0x20);
		  piVar7 = *(int **)(iVar6 + 0x60);
		  iVar6 = *piVar7;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Clans_ClanWars_IClanWars_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar3 * 8)
		         ) {
		        puVar12 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar3 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x80dda22c;
		      }
		      uVar3 = uVar3 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar3);
		  }
		  puVar12 = (uint *)func_ii_1080(piVar7,Gameplay_Clans_ClanWars_IClanWars_TypeInfo,1);
		code_r0x80dda22c:
		  uVar13 = CONCAT44(uVar8,puVar12[1]);
		  (**(code **)((ulonglong)*puVar12 * 4))(piVar7,uVar13);
		  uVar13 = CONCAT44((int)((ulonglong)uVar13 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar13);
		  uVar13 = CONCAT44((int)((ulonglong)uVar13 >> 0x20),*(undefined4 *)(iVar6 + 0x10));
		  uVar5 = CONCAT44(uVar11,*(undefined4 *)(*param1 + 0x134));
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))(param1,uVar13,uVar5);
		  uVar10 = (undefined4)((ulonglong)uVar5 >> 0x20);
		  uVar8 = (undefined4)((ulonglong)uVar13 >> 0x20);
		  iVar6 = Gameplay_Combat_Control_CombatController_object__object___SwitchTurn
		                    (param1,
		                     Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__TryAppendGameOverToCombatEvents__
		                    );
		  if (iVar6 != 0) {
		    uVar13 = CONCAT44(uVar8,*(undefined4 *)(*param1 + 0x144));
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))(param1,uVar13);
		    uVar8 = (undefined4)((ulonglong)uVar13 >> 0x20);
		  }
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(uVar8,*(undefined4 *)(*param1 + 0x104)));
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x178) * 4))
		            (param1,*(undefined4 *)(iVar6 + 0x10),CONCAT44(uVar10,*(undefined4 *)(*param1 + 0x17c)))
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06004181 RID: 16769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004181")]
		[Address(RVA = "0x9038", Offset = "0x9038", VA = "0x9038", Slot = "19")]
		protected override void HandleGameOver(ProtoCombatCompleteEvt msg)
		{
		/* --- GHIDRA: HandleGameOver ---
		void Gameplay_Clans_Combat_Control_ClanCombatController__HandleGameOver
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 param3;
		  undefined4 param4;
		  
		  if (DAT_ram_00a577a1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ClansScope_ClanCombatEventArgs_TypeInfo);
		    DAT_ram_00a577a1 = '\x01';
		  }
		  iVar1 = System_Uri___ctor(0);
		  iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x84) + 0x44);
		  if (iVar1 != 0) {
		    param2_00 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param4 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x78) + 0x14) + 0x68) + 0x1c);
		    param1_00 = unnamed_function_1417(Core_Events_Scopes_ClansScope_ClanCombatEventArgs_TypeInfo);
		    Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData
		              (param1_00,param2_00,param3,param4,0);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004182 RID: 16770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004182")]
		[Address(RVA = "0x9039", Offset = "0x9039", VA = "0x9039", Slot = "18")]
		protected override void HandleJoinToCombatInfoChanged()
		{
		/* --- GHIDRA: HandleJoinToCombatInfoChanged ---
		void Gameplay_Clans_Combat_Control_ClanCombatController__HandleJoinToCombatInfoChanged
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  undefined4 param4;
		  
		  if (DAT_ram_00a577a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ClansScope_ClanCombatFinishEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Combat_Model_GameOverData_TypeInfo);
		    DAT_ram_00a577a2 = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Clans_Combat_Model_GameOverData_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(Gameplay_Clans_Combat_Model_GameOverData_TypeInfo + 0xb8) * 4 + -4)
		        != Gameplay_Clans_Combat_Model_GameOverData_TypeInfo)) {
		      System_Activator__CreateInstance(param2,Gameplay_Clans_Combat_Model_GameOverData_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = System_Uri___ctor(0);
		  iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x84) + 0x48);
		  if (iVar1 != 0) {
		    param2_00 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param4 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x78) + 0x14) + 0x68) + 0x1c);
		    param1_00 = unnamed_function_1417
		                          (Core_Events_Scopes_ClansScope_ClanCombatFinishEventArgs_TypeInfo);
		    Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		              (param1_00,param2_00,param3_00,param4,param2,0);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004183 RID: 16771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004183")]
		[Address(RVA = "0x903A", Offset = "0x903A", VA = "0x903A", Slot = "23")]
		protected override void HandleGameOverInfoChanged(Gameplay.Combat.Model.GameOverData gameOverData)
		{
		/* --- GHIDRA: HandleGameOverInfoChanged ---
		uint Gameplay_Clans_Combat_Control_ClanCombatController__HandleGameOverInfoChanged
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  longlong lVar2;
		  longlong lVar3;
		  
		  lVar3 = *(longlong *)(param2 + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  lVar2 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x44),0);
		  return (uint)(lVar3 != lVar2);
		}
		*/

		}

		// Token: 0x06004184 RID: 16772 RVA: 0x0000C978 File Offset: 0x0000AB78
		[Token(Token = "0x6004184")]
		[Address(RVA = "0x903B", Offset = "0x903B", VA = "0x903B", Slot = "22")]
		protected override bool IsOtherPlayer(ProtoPlayerActionEvt msg)
		{
		/* --- GHIDRA: IsOtherPlayer ---
		void Gameplay_Clans_Combat_Control_ClanCombatController__IsOtherPlayer
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  uVar3 = *(undefined4 *)(param2 + 0xc);
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x138) * 4))
		                    (piVar1,uVar3,*(undefined4 *)(*piVar1 + 0x13c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x30);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		            (*(undefined4 *)(iVar2 + 0x20),uVar3,*(undefined4 *)(iVar2 + 0x14));
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004185 RID: 16773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004185")]
		[Address(RVA = "0x903C", Offset = "0x903C", VA = "0x903C")]
		private void HandlePlayerAddedEvent(ProtoPlayerAddedEvt msg)
		{
		/* --- GHIDRA: HandlePlayerAddedEvent ---
		void Gameplay_Clans_Combat_Control_ClanCombatController__HandlePlayerAddedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int *piVar1;
		  int iVar2;
		  undefined8 uVar3;
		  undefined4 local_4;
		  
		  uVar3 = *(undefined8 *)(param2 + 0x10);
		  local_4 = 0;
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)))
		  ;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x140) * 4))
		                    (piVar1,uVar3,&local_4,*(undefined4 *)(*piVar1 + 0x144));
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x34);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),local_4,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004186 RID: 16774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004186")]
		[Address(RVA = "0x903D", Offset = "0x903D", VA = "0x903D")]
		private void HandlePlayerRemovedEvent(ProtoDefaultUserCmd msg)
		{
		/* --- GHIDRA: HandlePlayerRemovedEvent ---
		void Gameplay_Clans_Combat_Control_ClanCombatController__HandlePlayerRemovedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined1 auStack_10 [12];
		  int local_4;
		  
		  if (DAT_ram_00a577a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatPlayer__get_Count__);
		    DAT_ram_00a577a3 = '\x01';
		  }
		  local_4 = 0;
		  if (*(char *)(param2 + 0x1c) != '\0') {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_Clans_Combat_Model_ClanCombatModel__RemovePlayer(param1_00,&local_4,auStack_10);
		    iVar1 = local_4;
		    if (0 < *(int *)(local_4 + 0xc)) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar2 = *(int *)(iVar2 + 0x70);
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),iVar1,*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004187 RID: 16775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004187")]
		[Address(RVA = "0x903E", Offset = "0x903E", VA = "0x903E")]
		private void HandleSwitchTurnServiceEvent(ProtoSwitchTurnEvt msg)
		{
		/* --- GHIDRA: HandleSwitchTurnServiceEvent ---
		void Gameplay_Clans_Combat_Control_ClanCombatController__HandleSwitchTurnServiceEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  byte bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  undefined4 param1_00;
		  int param1_01;
		  undefined8 uVar6;
		  undefined4 param1_02;
		  undefined4 uVar7;
		  undefined4 param2_00;
		  int local_4;
		  
		  uVar2 = 0;
		  if (DAT_ram_00a577a4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__TryAppendGameOverToCombatEvents__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Combat_Model_GameOverData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_PlayerProfitData_TypeInfo);
		    DAT_ram_00a577a4 = '\x01';
		  }
		  local_4 = 0;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(char *)(iVar3 + 100) == '\0') {
		    piVar4 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar5 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x100) * 4))
		                      (piVar4,*(undefined4 *)(*piVar4 + 0x104));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param1_02 = *(undefined4 *)(iVar3 + 0x78);
		    if (*(int *)(param2 + 0xc) == 1) {
		      uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      iVar3 = Gameplay_Clans_Combat_Model_ClanCombatModel__GetPlayerCount(uVar5,&local_4,param1);
		      if (iVar3 != 0) {
		        param1_02 = *(undefined4 *)(local_4 + 0x14);
		      }
		    }
		    else {
		      uVar2 = param1_02;
		      if (*(char *)(param2 + 0x10) == '\0') {
		        uVar2 = uVar5;
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar7 = *(undefined4 *)(param2 + 0xc);
		    bVar1 = *(byte *)(param2 + 0x10);
		    piVar4 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar5 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x100) * 4))
		                      (piVar4,*(undefined4 *)(*piVar4 + 0x104));
		    param2_00 = *(undefined4 *)(param2 + 0x14);
		    param1_00 = unnamed_function_1417(Gameplay_Combat_Model_PlayerProfitData_TypeInfo);
		    Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,param2_00,0);
		    param1_01 = unnamed_function_1417(Gameplay_Clans_Combat_Model_GameOverData_TypeInfo);
		    uVar6 = Core_Data_UserData__get_UserId(param1_02,0);
		    Gameplay_Combat_Model_GameFieldGamesData___ctor(param1_01,(uint)bVar1,uVar6,uVar2,2,param1_00,0)
		    ;
		    uVar2 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    *(undefined4 *)(param1_01 + 0x2c) = param1_02;
		    *(undefined4 *)(param1_01 + 0x28) = uVar5;
		    *(undefined4 *)(param1_01 + 0x24) = uVar7;
		    *(int *)(iVar3 + 0x10) = param1_01;
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar6 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x134));
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		              (param1,*(undefined4 *)(iVar3 + 0x10),uVar6);
		    uVar2 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    Gameplay_Combat_Control_CombatController_object__object___SwitchTurn
		              (param1,
		               Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__TryAppendGameOverToCombatEvents__
		              );
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x178) * 4))
		              (param1,*(undefined4 *)(iVar3 + 0x10),CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x17c))
		              );
		  }
		  else {
		    Gameplay_Clans_Combat_Control_ClanCombatController__NotifyShowViewProcessComplete(param1,param1)
		    ;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004188 RID: 16776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004188")]
		[Address(RVA = "0x903F", Offset = "0x903F", VA = "0x903F")]
		private void HandleClanWarComplete(ProtoClanWarCompleteEvt msg)
		{
		/* --- GHIDRA: HandleClanWarComplete ---
		void Gameplay_Clans_Combat_Control_ClanCombatController__HandleClanWarComplete
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar4;
		  
		  if (DAT_ram_00a577a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Combat_Control_ClanCombatController_HandleJoinToCombatService__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__get_CombatService__
		              );
		    Mono_Security_ASN1__get_Item(&ServicesNamespace_ICombatService_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a577a5 = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0x18);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (ServicesNamespace_ICombatService_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1d8);
		        goto code_r0x80dda929;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,ServicesNamespace_ICombatService_TypeInfo,0x23);
		code_r0x80dda929:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatController_HandleJoinToCombatService__,0
		            );
		  uVar3 = ServicesNamespace_MainService__GetUserStats
		                    (uVar3,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x06004189 RID: 16777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004189")]
		[Address(RVA = "0x9040", Offset = "0x9040", VA = "0x9040")]
		private void RequestJoin()
		{
		/* --- GHIDRA: RequestJoin ---
		void Gameplay_Clans_Combat_Control_ClanCombatController__RequestJoin
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  uint *puVar3;
		  int *piVar4;
		  int param1_01;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a577a6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedCombatErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoJoinToCombatAns_TypeInfo);
		    DAT_ram_00a577a6 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar4 = *(int **)(param2 + 0x20);
		  if ((piVar4 != (int *)0x0) && (Protocol_Combat_ProtoJoinToCombatAns_TypeInfo != *piVar4)) {
		    System_Activator__CreateInstance(piVar4,Protocol_Combat_ProtoJoinToCombatAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_01 = piVar4[3];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_01,*(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x14),
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedCombatErrors___
		                    );
		  if (iVar2 == 0) {
		    Gameplay_Clans_Combat_Control_ClanCombatController__RemovePlayer(param1,piVar4,piVar4);
		    return;
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = *(undefined4 *)(iVar2 + 0x50);
		  param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  DefaultNamespace_SceneAppManager__RemoveScene(param1_00,param2_00,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar4 = *(int **)(*(int *)(iVar2 + 0x3c) + 0x14);
		  iVar2 = *piVar4;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd8);
		        goto code_r0x80ddaac4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_Combat_ICombat_TypeInfo,3);
		code_r0x80ddaac4:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar4 = *(int **)(*(int *)(iVar2 + 0x3c) + 0x14);
		  iVar2 = *piVar4;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80ddab62;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,System_IDisposable_TypeInfo,0);
		code_r0x80ddab62:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600418A RID: 16778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418A")]
		[Address(RVA = "0x9041", Offset = "0x9041", VA = "0x9041")]
		private void HandleJoinToCombatService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleJoinToCombatService ---
		void Gameplay_Clans_Combat_Control_ClanCombatController__HandleJoinToCombatService
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a577a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Combat_Control_ClanCombatController_HandleRequestCombatService__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a577a7 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ClanWarsService__JoinCombatAsViewer
		                    (*(undefined4 *)(param1 + 0x20),param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatController_HandleRequestCombatService__,
		             0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600418B RID: 16779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418B")]
		[Address(RVA = "0x9042", Offset = "0x9042", VA = "0x9042")]
		private void RequestCombat(uint clanWarId)
		{
		/* --- GHIDRA: RequestCombat ---
		void Gameplay_Clans_Combat_Control_ClanCombatController__RequestCombat
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a577a8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanWarErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoJoinClanCombatAns_TypeInfo);
		    DAT_ram_00a577a8 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_ClanWar_ProtoJoinClanCombatAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_ClanWar_ProtoJoinClanCombatAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanWarErrors___
		                    );
		  if (iVar1 == 0) {
		    Gameplay_Clans_Combat_Control_ClanCombatController__HandleClanWarComplete(param1,param1_00);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600418C RID: 16780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418C")]
		[Address(RVA = "0x9043", Offset = "0x9043", VA = "0x9043")]
		private void HandleRequestCombatService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleRequestCombatService ---
		void Gameplay_Clans_Combat_Control_ClanCombatController__HandleRequestCombatService
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a577a9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Combat_Control_ClanCombatController_HandleJoinCombatAsViewerService__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a577a9 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ClanWarsService__CancelAcceleration
		                    (*(undefined4 *)(param1 + 0x20),param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatController_HandleJoinCombatAsViewerService__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600418D RID: 16781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418D")]
		[Address(RVA = "0x9044", Offset = "0x9044", VA = "0x9044")]
		private void RequestJoinCombatAsViewer(uint clanWarId)
		{
		/* --- GHIDRA: RequestJoinCombatAsViewer ---
		void Gameplay_Clans_Combat_Control_ClanCombatController__RequestJoinCombatAsViewer
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  int iVar1;
		  undefined4 uVar2;
		  float param2_00;
		  undefined4 uVar3;
		  int *param1_00;
		  int param1_01;
		  undefined8 uVar4;
		  
		  if (DAT_ram_00a577aa == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__PrepareView__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__SetJoinToCombatInfo__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedCombatErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoJoinToCombatAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a577aa = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  uVar4 = CONCAT44(in_register_20000004,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (uVar4,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = *(undefined4 *)(iVar1 + 0x50);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Combat_ProtoJoinToCombatAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Combat_ProtoJoinToCombatAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_01 = param1_00[3];
		  uVar4 = CONCAT44((int)((ulonglong)uVar4 >> 0x20),param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (uVar4,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_01,*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x14),
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedCombatErrors___
		                    );
		  if (iVar1 != 0) {
		    uVar2 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    DefaultNamespace_SceneAppManager__RemoveScene(uVar2,uVar3,0);
		    return;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (CONCAT44(uVar2,param1),*(undefined4 *)(*param1 + 0x104));
		  uVar4 = *(undefined8 *)(param1_00[4] + 0x10);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = Utils_StringUtils___cctor(uVar4,0);
		  uVar3 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar3,param2_00,0);
		  *(undefined4 *)(iVar1 + 0x7c) = uVar3;
		  Gameplay_Combat_Control_CombatController_object__object___SelectSpell
		            (param1,param1_00[4],
		             Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__SetJoinToCombatInfo__
		            );
		  Gameplay_Combat_Control_CombatController_object__object___PrepareField
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__PrepareView__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600418E RID: 16782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418E")]
		[Address(RVA = "0x9045", Offset = "0x9045", VA = "0x9045")]
		private void HandleJoinCombatAsViewerService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleJoinCombatAsViewerService ---
		undefined4
		Gameplay_Clans_Combat_Control_ClanCombatController__HandleJoinCombatAsViewerService
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a577ab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedRequirementsErrors___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Errors_Expected_ExpectedRequirementsErrors_ExpectedRequirementsErrorsArgs_TypeInfo
		              );
		    DAT_ram_00a577ab = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(char *)(iVar1 + 0x65) == '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = Core_Gameplay_Managers_Requirements_RequirementsManager__GetRequirementDic
		                      (*(undefined4 *)(iVar1 + 0x68),*(undefined4 *)(iVar1 + 0x5c),
		                       *(undefined4 *)(iVar1 + 8),0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (iVar1 != 0) {
		      *(undefined1 *)(iVar2 + 0x65) = 1;
		      Gameplay_Clans_Combat_Control_ClanCombatController__HandleJoinToCombatService
		                (param1,param2,param1);
		      return 1;
		    }
		    param2_00 = *(undefined4 *)(iVar2 + 8);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar3 = *(undefined4 *)(iVar1 + 0x68);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar3 = Core_Gameplay_Managers_Requirements_RequirementsManager__Deinit
		                      (uVar3,*(undefined4 *)(iVar1 + 0x5c),0);
		    param1_00 = unnamed_function_1417
		                          (
		                          Core_Errors_Expected_ExpectedRequirementsErrors_ExpectedRequirementsErrorsArgs_TypeInfo
		                          );
		    Core_Errors_Expected_ExpectedRequirementsErrors___ctor(param1_00,param2_00,uVar3,0);
		    UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		              (0xfffffc18,param1_00,
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedRequirementsErrors___
		              );
		  }
		  return 0;
		}
		*/

		}

		// Token: 0x0600418F RID: 16783 RVA: 0x0000C990 File Offset: 0x0000AB90
		[Token(Token = "0x600418F")]
		[Address(RVA = "0x9046", Offset = "0x9046", VA = "0x9046")]
		public bool TryRequestCombat(uint clanWarId)
		{
		/* --- GHIDRA: TryRequestCombat ---
		void Gameplay_Clans_Combat_Control_ClanCombatController__TryRequestCombat
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a577ac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__NotifyShowViewProcessComplete__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__ValidateInit__
		              );
		    DAT_ram_00a577ac = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(char *)(iVar1 + 100) != '\0') {
		    Gameplay_Combat_Control_CombatController_object__object___TryHandleJoinError
		              (param1,
		               Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__ValidateInit__
		              );
		    return;
		  }
		  Gameplay_Combat_Control_CombatController_object__object___NotifyAllAnimationComplete
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents__NotifyShowViewProcessComplete__
		            );
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004190 RID: 16784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004190")]
		[Address(RVA = "0x9047", Offset = "0x9047", VA = "0x9047", Slot = "25")]
		public override void NotifyShowViewProcessComplete()
		{
		/* --- GHIDRA: NotifyShowViewProcessComplete ---
		void Gameplay_Clans_Combat_Control_ClanCombatController__NotifyShowViewProcessComplete
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int *piVar4;
		  
		  if (DAT_ram_00a577ad == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    DAT_ram_00a577ad = '\x01';
		  }
		  ServicesNamespace_ClanWarsService__RequestClanCombat(param1[8],0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = *(undefined4 *)(iVar2 + 0x50);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar4 = *(int **)(*(int *)(iVar2 + 0x3c) + 0x14);
		  iVar2 = *piVar4;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd8);
		        goto code_r0x80dd9607;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_Combat_ICombat_TypeInfo,3);
		code_r0x80dd9607:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar4 = *(int **)(*(int *)(iVar2 + 0x3c) + 0x14);
		  iVar2 = *piVar4;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dd96a5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,System_IDisposable_TypeInfo,0);
		code_r0x80dd96a5:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  DefaultNamespace_SceneAppManager__RemoveScene(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004191 RID: 16785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004191")]
		[Address(RVA = "0x9048", Offset = "0x9048", VA = "0x9048")]
		public void Exit()
		{
		/* --- GHIDRA: Exit ---
		void Gameplay_Clans_Combat_Control_ClanCombatController__Exit(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a577ae == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Combat_Control_ClanCombatController___c_TypeInfo);
		    DAT_ram_00a577ae = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Clans_Combat_Control_ClanCombatController___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Clans_Combat_Control_ClanCombatController___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04002448 RID: 9288
		[Token(Token = "0x4002448")]
		[FieldOffset(Offset = "0x20")]
		private ClanWarsService _clanWarsService;
	}
}
