using System;
using Gameplay.BlitzTournament.Events;
using Gameplay.BlitzTournament.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.BlitzTournaments;
using Protocol.Tournaments;
using ServicesNamespace;
using Utils;

namespace Gameplay.BlitzTournament.Controller
{
	// Token: 0x02000BD9 RID: 3033
	[Token(Token = "0x2000BD9")]
	public class BlitzTournamentController : AbstractController<BlitzTournamentModel, Gameplay.BlitzTournament.Events.BlitzTournamentEvents>
	{
		// Token: 0x06004A4D RID: 19021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A4D")]
		[Address(RVA = "0x98AF", Offset = "0x98AF", VA = "0x98AF")]
		public BlitzTournamentController(BlitzTournamentModel model, Gameplay.BlitzTournament.Events.BlitzTournamentEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentController___ctor
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined4 param2_00;
		  undefined4 param3;
		  undefined4 param4;
		  
		  if (DAT_ram_00a608bf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__BlitzTournamentCombatMediator__OneOnOneCombatView__TryRun__
		              );
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_BlitzTournament_BlitzTournamentCombat_TypeInfo);
		    DAT_ram_00a608bf = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param2_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param3 = *(undefined4 *)(iVar1 + 8);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param4 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,0.0,0);
		  param1_01 = unnamed_function_1417(Gameplay_BlitzTournament_BlitzTournamentCombat_TypeInfo);
		  if (DAT_ram_00a60891 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__BlitzTournamentCombatMediator__OneOnOneCombatView___ctor__
		              );
		    DAT_ram_00a60891 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1_01,param2_00,param3,param4,param1_00,
		             Method_Gameplay_Combat_AbstractCombat_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__BlitzTournamentCombatMediator__OneOnOneCombatView___ctor__
		            );
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___Stop
		            (param1_01,
		             Method_Gameplay_Combat_AbstractCombat_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__BlitzTournamentCombatMediator__OneOnOneCombatView__TryRun__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004A4E RID: 19022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A4E")]
		[Address(RVA = "0x98B0", Offset = "0x98B0", VA = "0x98B0")]
		public void StartCombatImmediately()
		{
		/* --- GHIDRA: StartCombatImmediately ---
		undefined4
		Gameplay_BlitzTournament_Controller_BlitzTournamentController__StartCombatImmediately
		          (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  float fVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  undefined4 param2_00;
		  undefined4 param3;
		  undefined4 param4;
		  
		  if (DAT_ram_00a608c0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__BlitzTournamentCombatMediator__OneOnOneCombatView__TryRun__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_BlitzTournament_BlitzTournamentCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ICombatManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a608c0 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x218);
		        goto code_r0x81cf532e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2b);
		code_r0x81cf532e:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_ICombatManager_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81cf53b4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_Managers_ICombatManager_TypeInfo,0);
		code_r0x81cf53b4:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  if (iVar5 != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x218);
		          goto code_r0x81cf545d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2b);
		code_r0x81cf545d:
		    piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    uVar1 = 0;
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_ICombatManager_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81cf54df;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_Managers_ICombatManager_TypeInfo,0);
		code_r0x81cf54df:
		    piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    if (piVar4 != (int *)0x0) {
		      if (((uint)*(byte *)(Gameplay_BlitzTournament_BlitzTournamentCombat_TypeInfo + 0xb8) <=
		           (uint)*(byte *)(*piVar4 + 0xb8)) &&
		         (*(int *)(*(int *)(*piVar4 + 100) +
		                   (uint)*(byte *)(Gameplay_BlitzTournament_BlitzTournamentCombat_TypeInfo + 0xb8) *
		                   4 + -4) == Gameplay_BlitzTournament_BlitzTournamentCombat_TypeInfo)) {
		        if (DAT_ram_00a6088e == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&
		                     Method_Gameplay_Combat_AbstractCombat_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__BlitzTournamentCombatMediator__OneOnOneCombatView__get_AwaitBackTime__
		                    );
		          DAT_ram_00a6088e = '\x01';
		        }
		        if (piVar4[5] == 0) {
		          return 0;
		        }
		        fVar3 = func_ii_7103(piVar4[5],0);
		        if (0.0 < fVar3) {
		          return 0;
		        }
		      }
		    }
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param2_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param3 = *(undefined4 *)(iVar5 + 8);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param4 = *(undefined4 *)(iVar5 + 8);
		  param1_00 = unnamed_function_1417(Gameplay_BlitzTournament_BlitzTournamentCombat_TypeInfo);
		  if (DAT_ram_00a60891 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__BlitzTournamentCombatMediator__OneOnOneCombatView___ctor__
		              );
		    DAT_ram_00a60891 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1_00,param2_00,param3,param4,0,
		             Method_Gameplay_Combat_AbstractCombat_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__BlitzTournamentCombatMediator__OneOnOneCombatView___ctor__
		            );
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___Stop
		            (param1_00,
		             Method_Gameplay_Combat_AbstractCombat_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__BlitzTournamentCombatMediator__OneOnOneCombatView__TryRun__
		            );
		  return param1_00;
		}
		*/

		}

		// Token: 0x06004A4F RID: 19023 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004A4F")]
		[Address(RVA = "0x98B1", Offset = "0x98B1", VA = "0x98B1")]
		public BlitzTournamentCombat StartListeningForCombatStart()
		{
		/* --- GHIDRA: StartListeningForCombatStart ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentController__StartListeningForCombatStart
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a608c1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_GetTournamentInfoResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a608c1 = '\x01';
		  }
		  param1_00 = ServicesNamespace_BlitzTournamentService__ServerEventHandler
		                        (*(undefined4 *)(param1 + 0x18),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_GetTournamentInfoResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004A50 RID: 19024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A50")]
		[Address(RVA = "0x98B2", Offset = "0x98B2", VA = "0x98B2")]
		public void GetTournamentInfo()
		{
		/* --- GHIDRA: GetTournamentInfo ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentController__GetTournamentInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a608c2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_BlitzTournaments_ProtoGetTournamentInfoAns_TypeInfo);
		    DAT_ram_00a608c2 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_BlitzTournaments_ProtoGetTournamentInfoAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_BlitzTournaments_ProtoGetTournamentInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if ((param1_00[3] == 0) || (*(int *)(param1_00[3] + 0xc) == 0)) {
		    Gameplay_BlitzTournament_Controller_BlitzTournamentController__SubscribeToServiceEvents
		              (param1,param1);
		  }
		  else {
		    Gameplay_BlitzTournament_Controller_BlitzTournamentController__ResolveTournamentState
		              (param1,param1);
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_BlitzTournament_Model_BlitzTournamentModel___ctor(uVar1,param1_00[3],param1);
		  iVar2 = *param1;
		  if (param1_00[3] == 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                      (param1,*(undefined4 *)(iVar2 + 0x104));
		    *(undefined4 *)(iVar2 + 0x10) = 0;
		    return;
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		                    (param1,*(undefined4 *)(iVar2 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x14);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  iVar2 = param1_00[3];
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_BlitzTournament_Model_BlitzTournamentModel__PopulateTournaments
		            (uVar1,*(undefined4 *)(iVar2 + 0x20),param1);
		  if (*(int *)(iVar2 + 0x18) == 2) {
		    Gameplay_BlitzTournament_Controller_BlitzTournamentController__StartCombatImmediately
		              (param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004A51 RID: 19025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A51")]
		[Address(RVA = "0x98B3", Offset = "0x98B3", VA = "0x98B3")]
		private void GetTournamentInfoResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetTournamentInfoResultHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentController__GetTournamentInfoResultHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a608c3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_GetTournamentListResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a608c3 = '\x01';
		  }
		  param1_00 = ServicesNamespace_BlitzTournamentService__GetTournamentInfo
		                        (*(undefined4 *)(param1 + 0x18),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_GetTournamentListResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06004A52 RID: 19026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A52")]
		[Address(RVA = "0x98B4", Offset = "0x98B4", VA = "0x98B4")]
		public void GetTournamentList()
		{
		/* --- GHIDRA: GetTournamentList ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentController__GetTournamentList
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a608c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_BlitzTournaments_ProtoGetTournamentListAns_TypeInfo);
		    DAT_ram_00a608c4 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_BlitzTournaments_ProtoGetTournamentListAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance
		              (param1_01,Protocol_BlitzTournaments_ProtoGetTournamentListAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_BlitzTournament_Model_BlitzTournamentModel__SetTournamentInfo(param1_00,param1_01,param1)
		  ;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  Gameplay_BlitzTournament_Controller_BlitzTournamentController__StartListeningForCombatStart
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004A53 RID: 19027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A53")]
		[Address(RVA = "0x98B5", Offset = "0x98B5", VA = "0x98B5")]
		private void GetTournamentListResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetTournamentListResultHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentController__GetTournamentListResultHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a608c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_JoinQueueResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a608c5 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = Core_Data_UserData__set_Money(*(undefined4 *)(iVar2 + 8),0);
		  if (iVar2 == 0) {
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
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x1a8);
		          goto code_r0x81cf5d6b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x1d);
		code_r0x81cf5d6b:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    Core_Gameplay_Managers_ProgressSaverManager__ShowProgressSaverWindow(uVar4,0);
		  }
		  else {
		    uVar4 = ServicesNamespace_BlitzTournamentService__GetTournamentList(param1[6],param2,0);
		    uVar5 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar5,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_JoinQueueResultHandler__
		               ,0);
		    uVar4 = ServicesNamespace_MainService__GetUserStats
		                      (uVar4,uVar5,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    local_4 = param2;
		    uVar5 = func_ii_1081(DAT_ram_00a66958,&local_4);
		    DG_Tweening_TweenParams__SetId
		              (uVar4,uVar5,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004A54 RID: 19028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A54")]
		[Address(RVA = "0x98B6", Offset = "0x98B6", VA = "0x98B6")]
		public void JoinQueue(uint tournamentType)
		{
		/* --- GHIDRA: JoinQueue ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentController__JoinQueue
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a608c6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_BlitzTournamentData___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedJoinBlitzTournamentErrors__ExpectedBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_BlitzTournamentData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Events_Scopes_BlitzTournamentScope_JoinedQueueEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_BlitzTournaments_ProtoJoinQueueAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController___c__DisplayClass10_0__JoinQueueResultHandler_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_BlitzTournament_Controller_BlitzTournamentController___c__DisplayClass10_0_TypeInfo
		              );
		    DAT_ram_00a608c6 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_BlitzTournament_Controller_BlitzTournamentController___c__DisplayClass10_0_TypeInfo
		                    );
		  piVar5 = *(int **)(param2 + 0x20);
		  if ((piVar5 != (int *)0x0) && (Protocol_BlitzTournaments_ProtoJoinQueueAns_TypeInfo != *piVar5)) {
		    System_Activator__CreateInstance(piVar5,Protocol_BlitzTournaments_ProtoJoinQueueAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (piVar5[3],0,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedJoinBlitzTournamentErrors__ExpectedBillingErrors___
		                    );
		  if (iVar2 == 0) {
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
		    puVar3 = (undefined4 *)func_ii_15774(piVar5);
		    *(undefined4 *)(iVar1 + 8) = *puVar3;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar6 = *(undefined4 *)(iVar2 + 0xc);
		    uVar4 = unnamed_function_1417(System_Func_BlitzTournamentData__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar4,iVar1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController___c__DisplayClass10_0__JoinQueueResultHandler_b__0__
		               ,0);
		    iVar1 = System_Func_object__bool____ctor
		                      (uVar6,uVar4,
		                       Method_System_Linq_Enumerable_FirstOrDefault_BlitzTournamentData___);
		    if (iVar1 != 0) {
		      iVar2 = System_Uri___ctor(0);
		      iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x34) + 8);
		      if (iVar2 != 0) {
		        uVar4 = System_Uri___ctor(0);
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        uVar6 = unnamed_function_1417
		                          (Core_Events_Scopes_BlitzTournamentScope_JoinedQueueEventArgs_TypeInfo);
		        Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(uVar6,uVar4,param3_00,iVar1,0);
		        (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                  (*(undefined4 *)(iVar2 + 0x20),uVar6,*(undefined4 *)(iVar2 + 0x14));
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined1 *)(iVar1 + 0x14) = 1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x1c);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		    Gameplay_BlitzTournament_Controller_BlitzTournamentController__ResolveTournamentState
		              (param1,param1);
		    Gameplay_BlitzTournament_Controller_BlitzTournamentController__StartListeningForCombatStart
		              (param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004A55 RID: 19029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A55")]
		[Address(RVA = "0x98B7", Offset = "0x98B7", VA = "0x98B7")]
		private void JoinQueueResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: JoinQueueResultHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentController__JoinQueueResultHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a608c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_LeaveQueueResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a608c7 = '\x01';
		  }
		  param1_00 = ServicesNamespace_BlitzTournamentService__JoinQueue(*(undefined4 *)(param1 + 0x18),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_LeaveQueueResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06004A56 RID: 19030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A56")]
		[Address(RVA = "0x98B8", Offset = "0x98B8", VA = "0x98B8")]
		public void LeaveQueue()
		{
		/* --- GHIDRA: LeaveQueue ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentController__LeaveQueue
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a608c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_BaseEventBusEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_BlitzTournaments_ProtoLeaveQueueAns_TypeInfo);
		    DAT_ram_00a608c8 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_BlitzTournaments_ProtoLeaveQueueAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance
		              (param1_01,Protocol_BlitzTournaments_ProtoLeaveQueueAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (-1 < param1_01[3]) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined1 *)(iVar1 + 0x14) = 0;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x20);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		    Gameplay_BlitzTournament_Controller_BlitzTournamentController__SubscribeToServiceEvents
		              (param1,param1);
		    iVar1 = System_Uri___ctor(0);
		    iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x34) + 0xc);
		    if (iVar1 != 0) {
		      param2_00 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      param1_00 = unnamed_function_1417(Core_Events_BaseEventBusEventArgs_TypeInfo);
		      Core_Application_Managers_Connection_ServerConnectionDelay__ResetAll
		                (param1_00,param2_00,param3_00,0);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004A57 RID: 19031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A57")]
		[Address(RVA = "0x98B9", Offset = "0x98B9", VA = "0x98B9")]
		private void LeaveQueueResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: LeaveQueueResultHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentController__LeaveQueueResultHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x28);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param2 + 0xc),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004A58 RID: 19032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A58")]
		[Address(RVA = "0x98BA", Offset = "0x98BA", VA = "0x98BA")]
		private void FightersCountChangedEventHandler(ProtoFighterCountChangedEvt evt)
		{
		/* --- GHIDRA: FightersCountChangedEventHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentController__FightersCountChangedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x24) = *(undefined4 *)(param2 + 0xc);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_BlitzTournament_Model_BlitzTournamentModel__PopulateTournaments
		            (param1_00,*(undefined4 *)(param2 + 0x10),param1);
		  if ((*(int *)(param2 + 0xc) == 2) &&
		     (Gameplay_BlitzTournament_Controller_BlitzTournamentController__StartCombatImmediately
		                (param1,param1), *(int *)(param2 + 0xc) == 2)) {
		    Gameplay_BlitzTournament_Controller_BlitzTournamentController__StartListeningForCombatStart
		              (param1,param1);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x24);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004A59 RID: 19033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A59")]
		[Address(RVA = "0x98BB", Offset = "0x98BB", VA = "0x98BB")]
		private void StateChangedEventHandler(Protocol.BlitzTournaments.ProtoStateChangedEvt evt)
		{
		/* --- GHIDRA: StateChangedEventHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentController__StateChangedEventHandler
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  undefined4 param4;
		  undefined4 param3_00;
		  undefined8 param6;
		  undefined8 param5;
		  
		  if (DAT_ram_00a608c9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Events_Scopes_BlitzTournamentScope_FinalCombatCompleteEventArgs_TypeInfo);
		    DAT_ram_00a608c9 = '\x01';
		  }
		  iVar1 = System_Uri___ctor(0);
		  iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x34) + 0x10);
		  if (iVar1 != 0) {
		    param2_00 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param6 = *(undefined8 *)(param2 + 0x18);
		    param5 = *(undefined8 *)(param2 + 0x10);
		    param4 = *(undefined4 *)(param2 + 0xc);
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    param1_00 = unnamed_function_1417
		                          (
		                          Core_Events_Scopes_BlitzTournamentScope_FinalCombatCompleteEventArgs_TypeInfo
		                          );
		    Core_Events_Scopes_TournamentsScope_FinalCombatCompleteEventArgs__get_LooserId
		              (param1_00,param2_00,param3_00,param4,param5,param6,0);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004A5A RID: 19034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A5A")]
		[Address(RVA = "0x98BC", Offset = "0x98BC", VA = "0x98BC")]
		private void FinalBattleCompleteEventHandler(ProtoFinalTnmCombatCompleteEvt evt)
		{
		/* --- GHIDRA: FinalBattleCompleteEventHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentController__FinalBattleCompleteEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x30);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004A5B RID: 19035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A5B")]
		[Address(RVA = "0x98BD", Offset = "0x98BD", VA = "0x98BD")]
		private void HealthChangedEventHandler(ProtoHealthChangedEvt evt)
		{
		/* --- GHIDRA: HealthChangedEventHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentController__HealthChangedEventHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_BlitzTournament_Controller_BlitzTournamentController__JoinQueueResultHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004A5C RID: 19036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A5C")]
		[Address(RVA = "0x98BE", Offset = "0x98BE", VA = "0x98BE")]
		private void JoinRequestCancelledEventHandler(ProtoRequestCanceledEvt evt)
		{
		/* --- GHIDRA: JoinRequestCancelledEventHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentController__JoinRequestCancelledEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_BlitzTournament_Model_BlitzTournamentModel__PopulateTournaments
		            (param1_00,*(undefined4 *)(param2 + 0x20),param1);
		  if (*(int *)(param2 + 0x18) == 2) {
		    Gameplay_BlitzTournament_Controller_BlitzTournamentController__StartCombatImmediately
		              (param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004A5D RID: 19037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A5D")]
		[Address(RVA = "0x98BF", Offset = "0x98BF", VA = "0x98BF")]
		private void HandleTournamentState(ProtoGetTournamentInfoAns.Types.TournamentInfo tournamentInfo)
		{
		/* --- GHIDRA: HandleTournamentState ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentController__HandleTournamentState
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  if (param2 == 2) {
		    Gameplay_BlitzTournament_Controller_BlitzTournamentController__StartCombatImmediately(param1,2);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004A5E RID: 19038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A5E")]
		[Address(RVA = "0x98C0", Offset = "0x98C0", VA = "0x98C0")]
		private void ResolveTournamentState(Protocol.BlitzTournaments.TournamentStates currentState)
		{
		/* --- GHIDRA: ResolveTournamentState ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentController__ResolveTournamentState
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a608ca == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFighterCountChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoRequestCanceledEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoStateChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoHealthChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_FightersCountChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_FinalBattleCompleteEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_HealthChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_JoinRequestCancelledEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_StateChangedEventHandler__
		              );
		    DAT_ram_00a608ca = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined1 *)(iVar1 + 0x20) = 1;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x2c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  if ((char)param1[7] == '\0') {
		    *(undefined1 *)(param1 + 7) = 1;
		    iVar1 = param1[6];
		    uVar2 = unnamed_function_1417(System_Action_ProtoStateChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_StateChangedEventHandler__
		               ,0);
		    ServicesNamespace_BalanceService___ctor(iVar1,uVar2,0);
		    iVar1 = param1[6];
		    uVar2 = unnamed_function_1417(System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_FinalBattleCompleteEventHandler__
		               ,0);
		    ServicesNamespace_BlitzTournamentService__remove_CurrentBattleCompleteEvent(iVar1,uVar2,0);
		    iVar1 = param1[6];
		    uVar2 = unnamed_function_1417(System_Action_ProtoHealthChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_HealthChangedEventHandler__
		               ,0);
		    ServicesNamespace_BlitzTournamentService__remove_FinalBattleCompleteEvent(iVar1,uVar2,0);
		    iVar1 = param1[6];
		    uVar2 = unnamed_function_1417(System_Action_ProtoRequestCanceledEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_JoinRequestCancelledEventHandler__
		               ,0);
		    ServicesNamespace_BlitzTournamentService__remove_HealthChangedEvent(iVar1,uVar2,0);
		    iVar1 = param1[6];
		    uVar2 = unnamed_function_1417(System_Action_ProtoFighterCountChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_FightersCountChangedEventHandler__
		               ,0);
		    ServicesNamespace_BlitzTournamentService__remove_JoinRequestCancelledEvent(iVar1,uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A5F")]
		[Address(RVA = "0x98C1", Offset = "0x98C1", VA = "0x98C1")]
		public void SubscribeToServiceEvents()
		{
		/* --- GHIDRA: SubscribeToServiceEvents ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentController__SubscribeToServiceEvents
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a608cb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFighterCountChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoRequestCanceledEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoStateChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoHealthChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_FightersCountChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_FinalBattleCompleteEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_HealthChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_JoinRequestCancelledEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_StateChangedEventHandler__
		              );
		    DAT_ram_00a608cb = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined1 *)(iVar1 + 0x20) = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x2c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),0,*(undefined4 *)(iVar1 + 0x14));
		  }
		  if ((char)param1[7] != '\0') {
		    *(undefined1 *)(param1 + 7) = 0;
		    iVar1 = param1[6];
		    uVar2 = unnamed_function_1417(System_Action_ProtoStateChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_StateChangedEventHandler__
		               ,0);
		    ServicesNamespace_BlitzTournamentService__add_StateChangedEvent(iVar1,uVar2,0);
		    iVar1 = param1[6];
		    uVar2 = unnamed_function_1417(System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_FinalBattleCompleteEventHandler__
		               ,0);
		    ServicesNamespace_BlitzTournamentService__add_FinalBattleCompleteEvent(iVar1,uVar2,0);
		    iVar1 = param1[6];
		    uVar2 = unnamed_function_1417(System_Action_ProtoHealthChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_HealthChangedEventHandler__
		               ,0);
		    ServicesNamespace_BlitzTournamentService__add_HealthChangedEvent(iVar1,uVar2,0);
		    iVar1 = param1[6];
		    uVar2 = unnamed_function_1417(System_Action_ProtoRequestCanceledEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_JoinRequestCancelledEventHandler__
		               ,0);
		    ServicesNamespace_BlitzTournamentService__add_JoinRequestCancelledEvent(iVar1,uVar2,0);
		    iVar1 = param1[6];
		    uVar2 = unnamed_function_1417(System_Action_ProtoFighterCountChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentController_FightersCountChangedEventHandler__
		               ,0);
		    ServicesNamespace_BlitzTournamentService__add_FightersCountChangedEvent(iVar1,uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A60")]
		[Address(RVA = "0x98C2", Offset = "0x98C2", VA = "0x98C2")]
		public void UnsubscribeFromServiceEvents()
		{
		/* --- GHIDRA: UnsubscribeFromServiceEvents ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentController__UnsubscribeFromServiceEvents
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(char *)(iVar1 + 0x20) = (char)param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x2c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004A61 RID: 19041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A61")]
		[Address(RVA = "0x98C3", Offset = "0x98C3", VA = "0x98C3")]
		public void BlockUI(bool block)
		{
		/* --- GHIDRA: BlockUI ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentController__BlockUI
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a608cc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_BlitzTournamentModel__BlitzTournamentEvents__Dispose__
		              );
		    DAT_ram_00a608cc = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  MVC_AbstractController_object__object____ctor
		            (param1,
		             Method_MVC_AbstractController_BlitzTournamentModel__BlitzTournamentEvents__Dispose__);
		  return;
		}
		*/

		}

		// Token: 0x06004A62 RID: 19042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A62")]
		[Address(RVA = "0x98C4", Offset = "0x98C4", VA = "0x98C4", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x04002880 RID: 10368
		[Token(Token = "0x4002880")]
		[FieldOffset(Offset = "0x18")]
		private BlitzTournamentService _blitzService;

		// Token: 0x04002881 RID: 10369
		[Token(Token = "0x4002881")]
		[FieldOffset(Offset = "0x1C")]
		private bool _listeningForService;
	}
}
