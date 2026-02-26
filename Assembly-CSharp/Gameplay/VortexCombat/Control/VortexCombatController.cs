using System;
using System.Collections.Generic;
using Gameplay.Combat.Control;
using Gameplay.Combat.Model;
using Gameplay.VortexCombat.Model;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Partycombat;
using ServicesNamespace;
using Utils;

namespace Gameplay.VortexCombat.Control
{
	// Token: 0x020003B8 RID: 952
	[Token(Token = "0x20003B8")]
	public class VortexCombatController : CombatController<VortexCombatModel, VortexCombatEvents>
	{
		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001642 RID: 5698 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003B9")]
		public PartyCombatService PartyCombatService
		{
			[Token(Token = "0x6001642")]
			[Address(RVA = "0x6803", Offset = "0x6803", VA = "0x6803")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001643")]
		[Address(RVA = "0x6804", Offset = "0x6804", VA = "0x6804")]
		public VortexCombatController(ICombatService service, VortexCombatModel model, VortexCombatEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_VortexCombat_Control_VortexCombatController___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  
		  if (DAT_ram_00a58239 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__HandleRun__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexCombat_Control_VortexCombatController_HandlePutJoinRequestService__
		              );
		    DAT_ram_00a58239 = '\x01';
		  }
		  Gameplay_Combat_Control_CombatController_object__object___HandleRewardsGot
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__HandleRun__
		            );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x40) == 0) {
		    if (DAT_ram_00a58237 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__get_CombatService__
		                );
		      Mono_Security_ASN1__get_Item(&ServicesNamespace_PartyCombatService_TypeInfo);
		      DAT_ram_00a58237 = '\x01';
		    }
		    param1_00 = (int *)param1[6];
		    if (param1_00 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_00 + 0xb8) <
		           (uint)*(byte *)(ServicesNamespace_PartyCombatService_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_00 + 100) +
		                   (uint)*(byte *)(ServicesNamespace_PartyCombatService_TypeInfo + 0xb8) * 4 + -4)
		          != ServicesNamespace_PartyCombatService_TypeInfo)) {
		        System_Activator__CreateInstance(param1_00,ServicesNamespace_PartyCombatService_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x158) * 4))
		                      (piVar2,*(undefined4 *)(*piVar2 + 0x15c));
		    piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar4 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x160) * 4))
		                      (piVar2,*(undefined4 *)(*piVar2 + 0x164));
		    uVar3 = ServicesNamespace_PartyCombatService__ServerEventHandler(param1_00,uVar3,uVar4,0);
		    uVar4 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,
		               Method_Gameplay_VortexCombat_Control_VortexCombatController_HandlePutJoinRequestService__
		               ,0);
		    uVar3 = ServicesNamespace_MainService__GetUserStats
		                      (uVar3,uVar4,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Utils_OpToken_int__object___AddHandlers(param1,uVar3,0);
		    return;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		            (param1,*(undefined4 *)(iVar1 + 0x40),*(undefined4 *)(*param1 + 0x14c));
		  return;
		}
		*/

		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001644")]
		[Address(RVA = "0x6805", Offset = "0x6805", VA = "0x6805", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		int Gameplay_VortexCombat_Control_VortexCombatController__HandleRun
		              (int *param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int param1_00;
		  int iVar1;
		  int *piVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint uVar5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5823a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatSpellData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatSpellData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_CombatSpellData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_SpellCoolDown__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_SpellCoolDown__get_Item__);
		    DAT_ram_00a5823a = '\x01';
		  }
		  local_4 = 0;
		  uVar4 = *(undefined4 *)(param2 + 0xc);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_CombatSpellData__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (param1_00,uVar4,Method_System_Collections_Generic_List_CombatSpellData___ctor__);
		  if (0 < *(int *)(param2 + 0xc)) {
		    param2_00 = 0;
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (param2,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_SpellCoolDown__get_Item__)
		      ;
		      piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                                (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar4 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                        (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		      iVar3 = Gameplay_Combat_Model_CombatPlayer__GetSpellsAndElixirs
		                        (uVar4,*(undefined4 *)(iVar1 + 0xc),&local_4,0);
		      if (iVar3 != 0) {
		        Gameplay_Combat_Model_CombatSpellData__get_Cooldown(local_4,*(undefined4 *)(iVar1 + 0x10),0)
		        ;
		        iVar1 = Method_System_Collections_Generic_List_CombatSpellData__Add__;
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar5 = *(uint *)(param1_00 + 0xc);
		        if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		          *(undefined4 *)(*(int *)(param1_00 + 8) + uVar5 * 4 + 0x10) = local_4;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (param1_00,local_4,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		        }
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(param2 + 0xc));
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001645")]
		[Address(RVA = "0x6806", Offset = "0x6806", VA = "0x6806", Slot = "12")]
		protected override List<CombatSpellData> HandleCoolDowns(RepeatedField<SpellCoolDown> items)
		{
		/* --- GHIDRA: HandleCoolDowns ---
		void Gameplay_VortexCombat_Control_VortexCombatController__HandleCoolDowns
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a5823b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSkillsChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFieldChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSwitchTurnEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__AddCombatServiceEventsHandlers__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexCombat_Control_VortexCombatController_HandleCombatCompleteServiceEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexCombat_Control_VortexCombatController_HandleFieldChangedServiceEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexCombat_Control_VortexCombatController_HandleSkillsChangedServiceEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_VortexCombat_Control_VortexCombatController_HandleSwitchTurnEvent__)
		    ;
		    DAT_ram_00a5823b = '\x01';
		  }
		  if (DAT_ram_00a58237 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__get_CombatService__
		              );
		    Mono_Security_ASN1__get_Item(&ServicesNamespace_PartyCombatService_TypeInfo);
		    DAT_ram_00a58237 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x18);
		  if (piVar2 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar2 + 0xb8) <
		         (uint)*(byte *)(ServicesNamespace_PartyCombatService_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar2 + 100) +
		                 (uint)*(byte *)(ServicesNamespace_PartyCombatService_TypeInfo + 0xb8) * 4 + -4) !=
		        ServicesNamespace_PartyCombatService_TypeInfo)) {
		      System_Activator__CreateInstance(piVar2,ServicesNamespace_PartyCombatService_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar1 = unnamed_function_1417(System_Action_ProtoSkillsChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_VortexCombat_Control_VortexCombatController_HandleSkillsChangedServiceEvent__
		             ,0);
		  ServicesNamespace_PartyCombatService__get_ServiceId(piVar2,uVar1,0);
		  if (DAT_ram_00a58237 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__get_CombatService__
		              );
		    Mono_Security_ASN1__get_Item(&ServicesNamespace_PartyCombatService_TypeInfo);
		    DAT_ram_00a58237 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x18);
		  if (piVar2 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar2 + 0xb8) <
		         (uint)*(byte *)(ServicesNamespace_PartyCombatService_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar2 + 100) +
		                 (uint)*(byte *)(ServicesNamespace_PartyCombatService_TypeInfo + 0xb8) * 4 + -4) !=
		        ServicesNamespace_PartyCombatService_TypeInfo)) {
		      System_Activator__CreateInstance(piVar2,ServicesNamespace_PartyCombatService_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar1 = unnamed_function_1417(System_Action_ProtoFieldChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_VortexCombat_Control_VortexCombatController_HandleFieldChangedServiceEvent__
		             ,0);
		  ServicesNamespace_PartyCombatService__remove_SkillsChangedEvent(piVar2,uVar1,0);
		  if (DAT_ram_00a58237 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__get_CombatService__
		              );
		    Mono_Security_ASN1__get_Item(&ServicesNamespace_PartyCombatService_TypeInfo);
		    DAT_ram_00a58237 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x18);
		  if (piVar2 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar2 + 0xb8) <
		         (uint)*(byte *)(ServicesNamespace_PartyCombatService_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar2 + 100) +
		                 (uint)*(byte *)(ServicesNamespace_PartyCombatService_TypeInfo + 0xb8) * 4 + -4) !=
		        ServicesNamespace_PartyCombatService_TypeInfo)) {
		      System_Activator__CreateInstance(piVar2,ServicesNamespace_PartyCombatService_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar1 = unnamed_function_1417(System_Action_ProtoCombatCompleteEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_VortexCombat_Control_VortexCombatController_HandleCombatCompleteServiceEvent__
		             ,0);
		  ServicesNamespace_PartyCombatService__remove_FieldChangedEvent(piVar2,uVar1,0);
		  if (DAT_ram_00a58237 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__get_CombatService__
		              );
		    Mono_Security_ASN1__get_Item(&ServicesNamespace_PartyCombatService_TypeInfo);
		    DAT_ram_00a58237 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x18);
		  if (piVar2 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar2 + 0xb8) <
		         (uint)*(byte *)(ServicesNamespace_PartyCombatService_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar2 + 100) +
		                 (uint)*(byte *)(ServicesNamespace_PartyCombatService_TypeInfo + 0xb8) * 4 + -4) !=
		        ServicesNamespace_PartyCombatService_TypeInfo)) {
		      System_Activator__CreateInstance(piVar2,ServicesNamespace_PartyCombatService_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar1 = unnamed_function_1417(System_Action_ProtoSwitchTurnEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_VortexCombat_Control_VortexCombatController_HandleSwitchTurnEvent__,0);
		  ServicesNamespace_CombatService__remove_JumpToCombatEvent(piVar2,uVar1,0);
		  Gameplay_Combat_Control_CombatController_object__object____HandleSpellAppliedServiceEvent_g__Handler_42_0
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__AddCombatServiceEventsHandlers__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001646")]
		[Address(RVA = "0x6807", Offset = "0x6807", VA = "0x6807", Slot = "15")]
		protected override void AddCombatServiceEventsHandlers()
		{
		/* --- GHIDRA: AddCombatServiceEventsHandlers ---
		void Gameplay_VortexCombat_Control_VortexCombatController__AddCombatServiceEventsHandlers
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a5823c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSkillsChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFieldChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSwitchTurnEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__RemoveCombatServiceEventsHandlers__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexCombat_Control_VortexCombatController_HandleCombatCompleteServiceEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexCombat_Control_VortexCombatController_HandleFieldChangedServiceEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexCombat_Control_VortexCombatController_HandleSkillsChangedServiceEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_VortexCombat_Control_VortexCombatController_HandleSwitchTurnEvent__)
		    ;
		    DAT_ram_00a5823c = '\x01';
		  }
		  if (DAT_ram_00a58237 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__get_CombatService__
		              );
		    Mono_Security_ASN1__get_Item(&ServicesNamespace_PartyCombatService_TypeInfo);
		    DAT_ram_00a58237 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x18);
		  if (piVar2 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar2 + 0xb8) <
		         (uint)*(byte *)(ServicesNamespace_PartyCombatService_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar2 + 100) +
		                 (uint)*(byte *)(ServicesNamespace_PartyCombatService_TypeInfo + 0xb8) * 4 + -4) !=
		        ServicesNamespace_PartyCombatService_TypeInfo)) {
		      System_Activator__CreateInstance(piVar2,ServicesNamespace_PartyCombatService_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar1 = unnamed_function_1417(System_Action_ProtoSkillsChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_VortexCombat_Control_VortexCombatController_HandleSkillsChangedServiceEvent__
		             ,0);
		  ServicesNamespace_PartyCombatService__add_SkillsChangedEvent(piVar2,uVar1,0);
		  if (DAT_ram_00a58237 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__get_CombatService__
		              );
		    Mono_Security_ASN1__get_Item(&ServicesNamespace_PartyCombatService_TypeInfo);
		    DAT_ram_00a58237 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x18);
		  if (piVar2 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar2 + 0xb8) <
		         (uint)*(byte *)(ServicesNamespace_PartyCombatService_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar2 + 100) +
		                 (uint)*(byte *)(ServicesNamespace_PartyCombatService_TypeInfo + 0xb8) * 4 + -4) !=
		        ServicesNamespace_PartyCombatService_TypeInfo)) {
		      System_Activator__CreateInstance(piVar2,ServicesNamespace_PartyCombatService_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar1 = unnamed_function_1417(System_Action_ProtoFieldChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_VortexCombat_Control_VortexCombatController_HandleFieldChangedServiceEvent__
		             ,0);
		  ServicesNamespace_PartyCombatService__add_FieldChangedEvent(piVar2,uVar1,0);
		  if (DAT_ram_00a58237 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__get_CombatService__
		              );
		    Mono_Security_ASN1__get_Item(&ServicesNamespace_PartyCombatService_TypeInfo);
		    DAT_ram_00a58237 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x18);
		  if (piVar2 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar2 + 0xb8) <
		         (uint)*(byte *)(ServicesNamespace_PartyCombatService_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar2 + 100) +
		                 (uint)*(byte *)(ServicesNamespace_PartyCombatService_TypeInfo + 0xb8) * 4 + -4) !=
		        ServicesNamespace_PartyCombatService_TypeInfo)) {
		      System_Activator__CreateInstance(piVar2,ServicesNamespace_PartyCombatService_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar1 = unnamed_function_1417(System_Action_ProtoCombatCompleteEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_VortexCombat_Control_VortexCombatController_HandleCombatCompleteServiceEvent__
		             ,0);
		  ServicesNamespace_PartyCombatService__add_CombatCompleteEvent(piVar2,uVar1,0);
		  if (DAT_ram_00a58237 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__get_CombatService__
		              );
		    Mono_Security_ASN1__get_Item(&ServicesNamespace_PartyCombatService_TypeInfo);
		    DAT_ram_00a58237 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x18);
		  if (piVar2 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar2 + 0xb8) <
		         (uint)*(byte *)(ServicesNamespace_PartyCombatService_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar2 + 100) +
		                 (uint)*(byte *)(ServicesNamespace_PartyCombatService_TypeInfo + 0xb8) * 4 + -4) !=
		        ServicesNamespace_PartyCombatService_TypeInfo)) {
		      System_Activator__CreateInstance(piVar2,ServicesNamespace_PartyCombatService_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar1 = unnamed_function_1417(System_Action_ProtoSwitchTurnEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_VortexCombat_Control_VortexCombatController_HandleSwitchTurnEvent__,0);
		  ServicesNamespace_CombatService__add_SwitchTurnEvent(piVar2,uVar1,0);
		  Gameplay_Combat_Control_CombatController_object__object___PrepareView
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__RemoveCombatServiceEventsHandlers__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001647 RID: 5703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001647")]
		[Address(RVA = "0x6808", Offset = "0x6808", VA = "0x6808", Slot = "16")]
		protected override void RemoveCombatServiceEventsHandlers()
		{
		/* --- GHIDRA: RemoveCombatServiceEventsHandlers ---
		void Gameplay_VortexCombat_Control_VortexCombatController__RemoveCombatServiceEventsHandlers
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5823d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexCombat_Control_VortexCombatController_HandleJoinToCombatService__
		              );
		    DAT_ram_00a5823d = '\x01';
		  }
		  if (DAT_ram_00a58237 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__get_CombatService__
		              );
		    Mono_Security_ASN1__get_Item(&ServicesNamespace_PartyCombatService_TypeInfo);
		    DAT_ram_00a58237 = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0x18);
		  iVar2 = *param1_01;
		  if (((uint)*(byte *)(ServicesNamespace_PartyCombatService_TypeInfo + 0xb8) <=
		       (uint)*(byte *)(iVar2 + 0xb8)) &&
		     (*(int *)(*(int *)(iVar2 + 100) +
		               (uint)*(byte *)(ServicesNamespace_PartyCombatService_TypeInfo + 0xb8) * 4 + -4) ==
		      ServicesNamespace_PartyCombatService_TypeInfo)) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x230) * 4))
		                      (param1_01,*(undefined4 *)(iVar2 + 0x234));
		    param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Gameplay_VortexCombat_Control_VortexCombatController_HandleJoinToCombatService__
		               ,0);
		    uVar1 = ServicesNamespace_MainService__GetUserStats
		                      (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		    return;
		  }
		  System_Activator__CreateInstance(param1_01,ServicesNamespace_PartyCombatService_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001648")]
		[Address(RVA = "0x6809", Offset = "0x6809", VA = "0x6809", Slot = "25")]
		public override void NotifyShowViewProcessComplete()
		{
		/* --- GHIDRA: NotifyShowViewProcessComplete ---
		void Gameplay_VortexCombat_Control_VortexCombatController__NotifyShowViewProcessComplete
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param2_00;
		  int iVar1;
		  int *param4;
		  int param1_00;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int param2_01;
		  undefined8 param2_02;
		  
		  param2_01 = 0;
		  if (DAT_ram_00a5823e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__SetSkillsChanges__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_SkillsChange_IShortSpellInfo___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_SkillsChange_ISkillsChange___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_PlayerSkillsInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_PlayerSkillsInfo_Types_ShortSpellInfo__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_PlayerSkillsInfo_Types_ShortSpellInfo__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_PlayerSkillsInfo__get_Item__);
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_Model_SkillsChange_ShortSpellInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_SkillsChange_SkillsChange_TypeInfo);
		    DAT_ram_00a5823e = '\x01';
		  }
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid
		                               (Gameplay_Combat_Model_SkillsChange_ISkillsChange___TypeInfo,
		                                *(undefined4 *)(*(int *)(param2 + 0xc) + 0xc));
		  iVar4 = *(int *)(*(int *)(param2 + 0xc) + 0xc);
		  if (0 < iVar4) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param2 + 0xc),param2_01,
		                         Method_Google_Protobuf_Collections_RepeatedField_PlayerSkillsInfo__get_Item__
		                        );
		      iVar3 = 0;
		      param4 = (int *)Mono_Security_ASN1Convert__ToOid
		                                (Gameplay_Combat_Model_SkillsChange_IShortSpellInfo___TypeInfo,
		                                 *(undefined4 *)(*(int *)(iVar1 + 0x1c) + 0xc));
		      if (0 < param4[3]) {
		        do {
		          uVar5 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                            (*(undefined4 *)(iVar1 + 0x1c),iVar3,
		                             Method_Google_Protobuf_Collections_RepeatedField_PlayerSkillsInfo_Types_ShortSpellInfo__get_Item__
		                            );
		          param1_00 = unnamed_function_1417
		                                (Gameplay_VortexCombat_Model_SkillsChange_ShortSpellInfo_TypeInfo);
		          if (DAT_ram_00a58233 == '\0') {
		            Mono_Security_ASN1__get_Item
		                      (&
		                       Method_Gameplay_Combat_Model_SkillsChange_AbstractShortSpellInfo_PlayerSkillsInfo_Types_ShortSpellInfo___ctor__
		                      );
		            DAT_ram_00a58233 = '\x01';
		          }
		          Unity_Services_Core_Environments_Internal_Environments__get_Current
		                    (param1_00,uVar5,
		                     Method_Gameplay_Combat_Model_SkillsChange_AbstractShortSpellInfo_PlayerSkillsInfo_Types_ShortSpellInfo___ctor__
		                    );
		          if ((param1_00 != 0) &&
		             (iVar2 = func_ii_1082(param1_00,*(undefined4 *)(*param4 + 0x20)), iVar2 == 0)) {
		            uVar5 = func_ii_1083();
		            func_ii_1050(uVar5,0);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          param4[iVar3 + 4] = param1_00;
		          iVar3 = iVar3 + 1;
		        } while (iVar3 < param4[3]);
		      }
		      uVar5 = *(undefined4 *)(iVar1 + 0x18);
		      param2_02 = *(undefined8 *)(iVar1 + 0x10);
		      iVar3 = unnamed_function_1417(Gameplay_Combat_Model_SkillsChange_SkillsChange_TypeInfo);
		      System_Runtime_Serialization_ObjectHolder__get_ContainerID(iVar3,param2_02,uVar5,param4,0);
		      if ((iVar3 != 0) &&
		         (iVar1 = func_ii_1082(iVar3,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)) {
		        uVar5 = func_ii_1083();
		        func_ii_1050(uVar5,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      param2_00[param2_01 + 4] = iVar3;
		      param2_01 = param2_01 + 1;
		    } while (param2_01 != iVar4);
		  }
		  Gameplay_Combat_Control_CombatController_object__object___SetJoinToCombatInfo
		            (param1,param2_00,
		             Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__SetSkillsChanges__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001649")]
		[Address(RVA = "0x680A", Offset = "0x680A", VA = "0x680A")]
		private void HandleSkillsChangedServiceEvent(Protocol.Partycombat.ProtoSkillsChangedEvt msg)
		{
		/* --- GHIDRA: HandleSkillsChangedServiceEvent ---
		void Gameplay_VortexCombat_Control_VortexCombatController__HandleSkillsChangedServiceEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int *param2_01;
		  undefined4 uVar1;
		  int param1_00;
		  int iVar2;
		  int iVar3;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5823f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__AddFieldChange__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_Model_FieldChange_FieldChange_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_FieldChange_IFieldChange___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_FieldChangedInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_FieldChangedInfo__get_Item__);
		    DAT_ram_00a5823f = '\x01';
		  }
		  param2_01 = (int *)Mono_Security_ASN1Convert__ToOid
		                               (Gameplay_Combat_Model_FieldChange_IFieldChange___TypeInfo,
		                                *(undefined4 *)(*(int *)(param2 + 0xc) + 0xc));
		  iVar3 = *(int *)(*(int *)(param2 + 0xc) + 0xc);
		  if (0 < iVar3) {
		    do {
		      uVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param2 + 0xc),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_FieldChangedInfo__get_Item__
		                        );
		      param1_00 = unnamed_function_1417
		                            (Gameplay_VortexCombat_Model_FieldChange_FieldChange_TypeInfo);
		      if (DAT_ram_00a58234 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_Gameplay_Combat_Model_FieldChange_AbstractFieldChangeDecorator_FieldChangedInfo___ctor__
		                  );
		        DAT_ram_00a58234 = '\x01';
		      }
		      Unity_Services_Core_Environments_Internal_Environments__get_Current
		                (param1_00,uVar1,
		                 Method_Gameplay_Combat_Model_FieldChange_AbstractFieldChangeDecorator_FieldChangedInfo___ctor__
		                );
		      if ((param1_00 != 0) &&
		         (iVar2 = func_ii_1082(param1_00,*(undefined4 *)(*param2_01 + 0x20)), iVar2 == 0)) {
		        uVar1 = func_ii_1083();
		        func_ii_1050(uVar1,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      param2_01[param2_00 + 4] = param1_00;
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar3);
		  }
		  Gameplay_Combat_Control_CombatController_object__object___AddCombatServiceEventsHandlers
		            (param1,param2_01,
		             Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__AddFieldChange__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600164A RID: 5706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164A")]
		[Address(RVA = "0x680B", Offset = "0x680B", VA = "0x680B")]
		private void HandleFieldChangedServiceEvent(Protocol.Partycombat.ProtoFieldChangedEvt msg)
		{
		/* --- GHIDRA: HandleFieldChangedServiceEvent ---
		void Gameplay_VortexCombat_Control_VortexCombatController__HandleFieldChangedServiceEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  byte bVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 param1_00;
		  undefined4 param5;
		  undefined4 uVar5;
		  undefined8 uVar6;
		  
		  if (DAT_ram_00a58240 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__TryAppendGameOverToCombatEvents__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_GameOverData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_PlayerProfitData_TypeInfo);
		    DAT_ram_00a58240 = '\x01';
		  }
		  uVar6 = *(undefined8 *)(param2 + 0x18);
		  bVar1 = *(byte *)(param2 + 0x24);
		  piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param5 = *(undefined4 *)(*(int *)(iVar4 + 0xc) + 0xc);
		  uVar5 = *(undefined4 *)(param2 + 0x28);
		  param1_00 = unnamed_function_1417(Gameplay_Combat_Model_PlayerProfitData_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,uVar5,0);
		  uVar5 = unnamed_function_1417(Gameplay_Combat_Model_GameOverData_TypeInfo);
		  Gameplay_Combat_Model_GameFieldGamesData___ctor(uVar5,(uint)bVar1,uVar6,uVar3,param5,param1_00,0);
		  uVar3 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar4 + 0x10) = uVar5;
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar6 = CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x134));
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		            (param1,*(undefined4 *)(iVar4 + 0x10),uVar6);
		  uVar3 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  Gameplay_Combat_Control_CombatController_object__object___SwitchTurn
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__TryAppendGameOverToCombatEvents__
		            );
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x178) * 4))
		            (param1,uVar5,CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x17c)));
		  return;
		}
		*/

		}

		// Token: 0x0600164B RID: 5707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164B")]
		[Address(RVA = "0x680C", Offset = "0x680C", VA = "0x680C")]
		private void HandleCombatCompleteServiceEvent(Protocol.Partycombat.ProtoCombatCompleteEvt msg)
		{
		/* --- GHIDRA: HandleCombatCompleteServiceEvent ---
		void Gameplay_VortexCombat_Control_VortexCombatController__HandleCombatCompleteServiceEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  longlong lVar5;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58241 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_ulong__CombatPlayer__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo);
		    DAT_ram_00a58241 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(iVar1 + 0x1c),
		                     Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__)
		  ;
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_ulong__CombatPlayer__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2e2,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ebdbd9:
		      iVar1 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar3) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar3 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          if (iVar3 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x126,&local_18);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        import::env::__resumeException(uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    piVar4 = local_8._4_4_;
		    lVar5 = unnamed_function_184054
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x357,local_8._4_4_,0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ebdbd9;
		    }
		    if (piVar4 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar4 + 0xb8) <
		           (uint)*(byte *)(Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*piVar4 + 100) +
		                   (uint)*(byte *)(Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo + 0xb8) *
		                   4 + -4) != Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar4,
		                   Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ebdbd9;
		      }
		    }
		    *(bool *)(piVar4 + 0x19) = lVar5 == *(longlong *)(param2 + 0x10);
		  } while( true );
		}
		*/

		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164C")]
		[Address(RVA = "0x680D", Offset = "0x680D", VA = "0x680D")]
		private void HandleSwitchTurnEvent(ProtoSwitchTurnEvt msg)
		{
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164D")]
		[Address(RVA = "0x680E", Offset = "0x680E", VA = "0x680E", Slot = "21")]
		protected override void HandleShowHintServiceEvent(ProtoShowHintEvt msg)
		{
		/* --- GHIDRA: HandleShowHintServiceEvent ---
		void Gameplay_VortexCombat_Control_VortexCombatController__HandleShowHintServiceEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  int iVar1;
		  float param2_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int param1_01;
		  undefined8 uVar4;
		  undefined4 param2_01;
		  
		  if (DAT_ram_00a58242 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedCombatBillingErrors__ExpectedVortexCombatErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Partycombat_ProtoRequestCombatAns_TypeInfo);
		    DAT_ram_00a58242 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  uVar4 = CONCAT44(in_register_20000004,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (uVar4,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = *(undefined4 *)(iVar1 + 0x50);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Partycombat_ProtoRequestCombatAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Partycombat_ProtoRequestCombatAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_01 = param1_00[3];
		  uVar4 = CONCAT44((int)((ulonglong)uVar4 >> 0x20),param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (uVar4,*(undefined4 *)(*param1 + 0x104));
		  param2_01 = *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x14);
		  uVar4 = CONCAT44((int)((ulonglong)uVar4 >> 0x20),param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (uVar4,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  iVar1 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (param1_01,param2_01,*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x14),
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedCombatBillingErrors__ExpectedVortexCombatErrors___
		                    );
		  if (iVar1 != 0) {
		    uVar2 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    DefaultNamespace_SceneAppManager__RemoveScene(uVar2,uVar3,0);
		    return;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (CONCAT44(uVar2,param1),*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a5822b == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a5822b = '\x01';
		  }
		  *(int **)(iVar1 + 0x60) = param1_00;
		  uVar4 = *(undefined8 *)(param1_00 + 4);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = Utils_StringUtils___cctor(uVar4,0);
		  uVar3 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar2 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,param2_00,0);
		  *(undefined4 *)(iVar1 + 0x40) = uVar2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (CONCAT44(uVar3,param1),*(undefined4 *)(*param1 + 0x104));
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		            (param1,*(undefined4 *)(iVar1 + 0x40),*(undefined4 *)(*param1 + 0x14c));
		  return;
		}
		*/

		}

		// Token: 0x0600164E RID: 5710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164E")]
		[Address(RVA = "0x680F", Offset = "0x680F", VA = "0x680F")]
		private void HandlePutJoinRequestService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandlePutJoinRequestService ---
		void Gameplay_VortexCombat_Control_VortexCombatController__HandlePutJoinRequestService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int *param1_01;
		  int param1_02;
		  
		  if (DAT_ram_00a58243 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__SetJoinToCombatInfo__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__ValidateInit__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedVortexCombatErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Partycombat_ProtoJoinToCombatAns_TypeInfo);
		    DAT_ram_00a58243 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = *(undefined4 *)(iVar1 + 0x50);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Partycombat_ProtoJoinToCombatAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Partycombat_ProtoJoinToCombatAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_02 = param1_01[3];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_02,*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x14),
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedVortexCombatErrors___
		                    );
		  if (iVar1 != 0) {
		    param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    DefaultNamespace_SceneAppManager__RemoveScene(param1_00,param2_00,0);
		    return;
		  }
		  Gameplay_Combat_Control_CombatController_object__object___SelectSpell
		            (param1,param1_01[4],
		             Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__SetJoinToCombatInfo__
		            );
		  Gameplay_Combat_Control_CombatController_object__object___TryHandleJoinError
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__ValidateInit__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600164F RID: 5711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164F")]
		[Address(RVA = "0x6810", Offset = "0x6810", VA = "0x6810")]
		private void HandleJoinToCombatService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleJoinToCombatService ---
		void Gameplay_VortexCombat_Control_VortexCombatController__HandleJoinToCombatService
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58244 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__HandleJoinToCombatInfoChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_ulong__CombatPlayer__GetEnumerator__
		              );
		    DAT_ram_00a58244 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  Gameplay_Combat_Control_CombatController_object__object___HandleGameOverInfoChanged
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents__HandleJoinToCombatInfoChanged__
		            );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(iVar1 + 0x1c),
		                     Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__)
		  ;
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_ulong__CombatPlayer__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2e2,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ebe089:
		      iVar1 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar3) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar3 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          if (iVar3 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x127,&local_18);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        import::env::__resumeException(uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar3 = local_8._4_4_;
		    iVar4 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ebe089;
		    }
		    *(undefined1 *)(iVar3 + 0x50) = *(undefined1 *)(iVar4 + 0x5c);
		  } while( true );
		}
		*/

		}

		// Token: 0x06001650 RID: 5712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001650")]
		[Address(RVA = "0x6811", Offset = "0x6811", VA = "0x6811", Slot = "18")]
		protected override void HandleJoinToCombatInfoChanged()
		{
		/* --- GHIDRA: HandleJoinToCombatInfoChanged ---
		void Gameplay_VortexCombat_Control_VortexCombatController__HandleJoinToCombatInfoChanged
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58245 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView___ctor__
		              );
		    DAT_ram_00a58245 = '\x01';
		  }
		  UI_ToolTip_Implementations_View_Combat_AbstractCombatSpellToolTipView_object___HandleTitle
		            (param1,param2,param3,param4,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView___ctor__
		            );
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_PartyCombatService ---
		void Gameplay_VortexCombat_Control_VortexCombatController__get_PartyCombatService
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58238 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents___ctor__
		              );
		    DAT_ram_00a58238 = '\x01';
		  }
		  Sirenix_Serialization_ColorBlockFormatter___Il2CppFullySharedGenericType___Write
		            (param1,param2,param3,param4,
		             Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents___ctor__
		            );
		  return;
		}
		*/

}
