using System;
using Core.Data;
using Gameplay.Tournaments.Events;
using Gameplay.Tournaments.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Tournaments;
using ServicesNamespace;
using Utils;

namespace Gameplay.Tournaments.Controller
{
	// Token: 0x020004C8 RID: 1224
	[Token(Token = "0x20004C8")]
	public class TournamentsController : AbstractController<TournamentsModel, TournamentsEvents>
	{
		// Token: 0x06001CF4 RID: 7412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CF4")]
		[Address(RVA = "0x6E73", Offset = "0x6E73", VA = "0x6E73")]
		public TournamentsController(TournamentsModel model, TournamentsEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Tournaments_Controller_TournamentsController___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined4 param2_00;
		  undefined4 param3;
		  undefined4 param4;
		  
		  if (DAT_ram_00a5854d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__TournamentCombatViewMediator__OneOnOneCombatView__TryRun__
		              );
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tournaments_TournamentCombat_TypeInfo);
		    DAT_ram_00a5854d = '\x01';
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
		  param1_01 = unnamed_function_1417(Gameplay_Tournaments_TournamentCombat_TypeInfo);
		  if (DAT_ram_00a584e4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__TournamentCombatViewMediator__OneOnOneCombatView___ctor__
		              );
		    DAT_ram_00a584e4 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1_01,param2_00,param3,param4,param1_00,
		             Method_Gameplay_Combat_AbstractCombat_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__TournamentCombatViewMediator__OneOnOneCombatView___ctor__
		            );
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___Stop
		            (param1_01,
		             Method_Gameplay_Combat_AbstractCombat_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__TournamentCombatViewMediator__OneOnOneCombatView__TryRun__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CF5")]
		[Address(RVA = "0x6E74", Offset = "0x6E74", VA = "0x6E74")]
		public void StartCombatImmediately()
		{
		/* --- GHIDRA: StartCombatImmediately ---
		undefined4
		Gameplay_Tournaments_Controller_TournamentsController__StartCombatImmediately
		          (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  float fVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5854e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__TournamentCombatViewMediator__OneOnOneCombatView__TryRun__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ICombatManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tournaments_TournamentCombat_TypeInfo);
		    DAT_ram_00a5854e = '\x01';
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
		        goto code_r0x80f03327;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2b);
		code_r0x80f03327:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_ICombatManager_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f033ad;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_Managers_ICombatManager_TypeInfo,0);
		code_r0x80f033ad:
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
		          goto code_r0x80f03456;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2b);
		code_r0x80f03456:
		    piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    uVar1 = 0;
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_ICombatManager_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80f034d8;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_Managers_ICombatManager_TypeInfo,0);
		code_r0x80f034d8:
		    piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    if (piVar4 != (int *)0x0) {
		      if (((uint)*(byte *)(Gameplay_Tournaments_TournamentCombat_TypeInfo + 0xb8) <=
		           (uint)*(byte *)(*piVar4 + 0xb8)) &&
		         (*(int *)(*(int *)(*piVar4 + 100) +
		                   (uint)*(byte *)(Gameplay_Tournaments_TournamentCombat_TypeInfo + 0xb8) * 4 + -4)
		          == Gameplay_Tournaments_TournamentCombat_TypeInfo)) {
		        if (DAT_ram_00a584e1 == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&
		                     Method_Gameplay_Combat_AbstractCombat_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__TournamentCombatViewMediator__OneOnOneCombatView__get_AwaitBackTime__
		                    );
		          DAT_ram_00a584e1 = '\x01';
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
		  param3_00 = *(undefined4 *)(iVar5 + 8);
		  param1_00 = unnamed_function_1417(Gameplay_Tournaments_TournamentCombat_TypeInfo);
		  if (DAT_ram_00a584e4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__TournamentCombatViewMediator__OneOnOneCombatView___ctor__
		              );
		    DAT_ram_00a584e4 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1_00,param2_00,param3_00,param2,param3,
		             Method_Gameplay_Combat_AbstractCombat_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__TournamentCombatViewMediator__OneOnOneCombatView___ctor__
		            );
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___Stop
		            (param1_00,
		             Method_Gameplay_Combat_AbstractCombat_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__TournamentCombatViewMediator__OneOnOneCombatView__TryRun__
		            );
		  return param1_00;
		}
		*/

		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001CF6")]
		[Address(RVA = "0x6E75", Offset = "0x6E75", VA = "0x6E75")]
		public TournamentCombat StartListeningForCombatStart(UserData user, BackTime backTime)
		{
		/* --- GHIDRA: StartListeningForCombatStart ---
		void Gameplay_Tournaments_Controller_TournamentsController__StartListeningForCombatStart
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5854f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsController_GetTournamentListResultHandler__
		              );
		    DAT_ram_00a5854f = '\x01';
		  }
		  uVar1 = ServicesNamespace_TournamentsService__ServerEventHandler(*(undefined4 *)(param1 + 0x18),0)
		  ;
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Tournaments_Controller_TournamentsController_GetTournamentListResultHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CF7")]
		[Address(RVA = "0x6E76", Offset = "0x6E76", VA = "0x6E76")]
		public void GetTournamentsList()
		{
		/* --- GHIDRA: GetTournamentsList ---
		void Gameplay_Tournaments_Controller_TournamentsController__GetTournamentsList
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  int iVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58550 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_TournamentInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_TournamentInfo__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_ProtoGetTournamentListAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsController___c__GetTournamentListResultHandler_b__7_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tournaments_Controller_TournamentsController___c_TypeInfo);
		    DAT_ram_00a58550 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Tournaments_ProtoGetTournamentListAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Tournaments_ProtoGetTournamentListAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = param1_00[3];
		  if (*(int *)(Gameplay_Tournaments_Controller_TournamentsController___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Tournaments_Controller_TournamentsController___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)
		            (Gameplay_Tournaments_Controller_TournamentsController___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[1];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_Tournaments_Controller_TournamentsController___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Tournaments_Controller_TournamentsController___c_TypeInfo);
		      puVar3 = *(undefined4 **)
		                (Gameplay_Tournaments_Controller_TournamentsController___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar3;
		    iVar4 = unnamed_function_1417(System_Func_TournamentInfo__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar4,uVar1,
		               Method_Gameplay_Tournaments_Controller_TournamentsController___c__GetTournamentListResultHandler_b__7_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Tournaments_Controller_TournamentsController___c_TypeInfo + 0x5c) + 4
		            ) = iVar4;
		  }
		  iVar2 = System_Func_object__bool____ctor
		                    (iVar2,iVar4,Method_System_Linq_Enumerable_FirstOrDefault_TournamentInfo___);
		  if (iVar2 != 0) {
		    Gameplay_Tournaments_Controller_TournamentsController__StateChangedEventHandler
		              (param1,*(undefined4 *)(iVar2 + 0x14),param1);
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Tournaments_Model_TournamentsModel__SetStateInfo(uVar1,param1_00,iVar2,param1);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(bool *)(iVar4 + 0x1c) = iVar2 != 0;
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar4 = *(int *)(iVar4 + 0x20);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),iVar2 != 0,*(undefined4 *)(iVar4 + 0x14));
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x14);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CF8")]
		[Address(RVA = "0x6E77", Offset = "0x6E77", VA = "0x6E77")]
		private void GetTournamentListResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetTournamentListResultHandler ---
		void Gameplay_Tournaments_Controller_TournamentsController__GetTournamentListResultHandler
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58551 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tournaments_Controller_TournamentsController_AddBetResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_System_Tuple_uint__ResourceSet___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Tuple_uint__ResourceSet__TypeInfo);
		    DAT_ram_00a58551 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Tuple_uint__ResourceSet__TypeInfo);
		  UnityEngine_Purchasing_Default_Factory__Create
		            (uVar1,param2,param3,Method_System_Tuple_uint__ResourceSet___ctor__);
		  uVar2 = ServicesNamespace_TournamentsService__GetTournamentsList
		                    (*(undefined4 *)(param1 + 0x18),param2,param3,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Tournaments_Controller_TournamentsController_AddBetResultHandler__,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar2,uVar1,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CF9")]
		[Address(RVA = "0x6E78", Offset = "0x6E78", VA = "0x6E78")]
		public void AddBet(uint tournamentTypeId, ResourceSet bet)
		{
		/* --- GHIDRA: AddBet ---
		void Gameplay_Tournaments_Controller_TournamentsController__AddBet
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  int *param1_02;
		  int param6;
		  int param2_01;
		  int iVar2;
		  undefined4 param4;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a58552 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_TournamentsScope_AddBetEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedTournamentErrors__ExpectedBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_ProtoAddBetAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Tuple_uint__ResourceSet__get_Item1__);
		    Mono_Security_ASN1__get_Item(&Method_System_Tuple_uint__ResourceSet__get_Item2__);
		    Mono_Security_ASN1__get_Item(&System_Tuple_uint__ResourceSet__TypeInfo);
		    DAT_ram_00a58552 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Tournaments_ProtoAddBetAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Tournaments_ProtoAddBetAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (param1_01[3],0,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedTournamentErrors__ExpectedBillingErrors___
		                    );
		  if (iVar1 == 0) {
		    param1_02 = *(int **)(param2 + 0xc);
		    if (param1_02 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_02 + 0xb8) <
		           (uint)*(byte *)(System_Tuple_uint__ResourceSet__TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_02 + 100) +
		                   (uint)*(byte *)(System_Tuple_uint__ResourceSet__TypeInfo + 0xb8) * 4 + -4) !=
		          System_Tuple_uint__ResourceSet__TypeInfo)) {
		        System_Activator__CreateInstance(param1_02,System_Tuple_uint__ResourceSet__TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    param6 = param1_02[3];
		    param2_01 = param1_02[2];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = System_Collections_Generic_List_object___get_Item
		                      (*(undefined4 *)(iVar1 + 0xc),param2_01,
		                       Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__
		                      );
		    iVar2 = *(int *)(iVar1 + 0xc);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined1 *)(iVar1 + 0x1c) = 1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x20);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),1,*(undefined4 *)(iVar1 + 0x14));
		    }
		    *(int *)(iVar2 + 0x28) = param1_01[4];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x18);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		    iVar1 = System_Uri___ctor(0);
		    iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x30) + 8);
		    if (iVar1 != 0) {
		      param2_00 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param4 = *(undefined4 *)(iVar2 + 0xc);
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      param1_00 = unnamed_function_1417
		                            (Core_Events_Scopes_TournamentsScope_AddBetEventArgs_TypeInfo);
		      Core_Events_Scopes_TournamentsScope_AddBetEventArgs__get_Bet
		                (param1_00,param2_00,param3_00,param4,param2_01,param6,0);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CFA")]
		[Address(RVA = "0x6E79", Offset = "0x6E79", VA = "0x6E79")]
		private void AddBetResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: AddBetResultHandler ---
		void Gameplay_Tournaments_Controller_TournamentsController__AddBetResultHandler
		               (int param1,undefined4 param2,undefined8 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58553 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tournaments_Controller_TournamentsController_SetBetResultHandler__);
		    DAT_ram_00a58553 = '\x01';
		  }
		  param1_00 = ServicesNamespace_TournamentsService__AddBet
		                        (*(undefined4 *)(param1 + 0x18),param2,param3,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Tournaments_Controller_TournamentsController_SetBetResultHandler__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CFB")]
		[Address(RVA = "0x6E7A", Offset = "0x6E7A", VA = "0x6E7A")]
		public void SetBet(uint tournamentTypeId, ulong userId)
		{
		/* --- GHIDRA: SetBet ---
		void Gameplay_Tournaments_Controller_TournamentsController__SetBet
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar3;
		  int *param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58554 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_ProtoSetBetAns_TypeInfo);
		    DAT_ram_00a58554 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Tournaments_ProtoSetBetAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Tournaments_ProtoSetBetAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (-1 < param1_00[3]) {
		    uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    if (DAT_ram_00a5850e == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		      DAT_ram_00a5850e = '\x01';
		    }
		    iVar3 = System_Collections_Generic_List_object___get_Item
		                      (*(undefined4 *)(iVar3 + 0xc),*(undefined4 *)(iVar3 + 0x20),
		                       Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__
		                      );
		    *(undefined8 *)(*(int *)(*(int *)(iVar3 + 0xc) + 0x14) + 0x18) = *(undefined8 *)(param1_00 + 4);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x114)));
		    iVar3 = *(int *)(iVar3 + 0x1c);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),*(undefined8 *)(param1_00 + 4),
		                 *(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CFC")]
		[Address(RVA = "0x6E7B", Offset = "0x6E7B", VA = "0x6E7B")]
		private void SetBetResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: SetBetResultHandler ---
		void Gameplay_Tournaments_Controller_TournamentsController__SetBetResultHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  undefined8 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a58555 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TournamentCombatModel__TournamentCombatEvents__TournamentCombatController__TournamentCombatViewMediator__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    DAT_ram_00a58555 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x158);
		        goto code_r0x80f0317f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80f0317f:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  piVar4 = *(int **)(iVar5 + 0x14);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Cache_User_IUserInfoWrapper_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f03204;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x80f03204:
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,param2,puVar2[1]);
		  param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,0.0,0);
		  iVar5 = Gameplay_Tournaments_Controller_TournamentsController__StartCombatImmediately
		                    (param1,param2_00,param1_00,param2_00);
		  if (iVar5 != 0) {
		    iVar5 = *(int *)(iVar5 + 0x18);
		    uVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param2_00,0);
		    *(undefined8 *)(iVar5 + 0x60) = uVar3;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CFD")]
		[Address(RVA = "0x6E7C", Offset = "0x6E7C", VA = "0x6E7C")]
		public void WatchCombat(UserInfo userInfo)
		{
		/* --- GHIDRA: WatchCombat ---
		void Gameplay_Tournaments_Controller_TournamentsController__WatchCombat
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58556 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsController_GetTournamentHistoryResultHandler__
		              );
		    DAT_ram_00a58556 = '\x01';
		  }
		  uVar1 = ServicesNamespace_TournamentsService__LeaveCombatBrowsing
		                    (*(undefined4 *)(param1 + 0x18),param2,0);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Tournaments_Controller_TournamentsController_GetTournamentHistoryResultHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  local_4 = param2;
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  DG_Tweening_TweenParams__SetId(uVar1,uVar2,Method_Utils_OpToken_IMessage__object__SetCustomData__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CFE")]
		[Address(RVA = "0x6E7D", Offset = "0x6E7D", VA = "0x6E7D")]
		public void GetTournamentHistory(uint tournamentTypeId)
		{
		/* --- GHIDRA: GetTournamentHistory ---
		void Gameplay_Tournaments_Controller_TournamentsController__GetTournamentHistory
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 *puVar1;
		  int *param1_01;
		  int *param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a58557 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_ProtoGetHistoryAns_TypeInfo);
		    DAT_ram_00a58557 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Tournaments_ProtoGetHistoryAns_TypeInfo != *param1_01))
		  {
		    System_Activator__CreateInstance(param1_01,Protocol_Tournaments_ProtoGetHistoryAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_02 = *(int **)(param2 + 0xc);
		  if (param1_02 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*param1_02 + 0x20) == *(int *)(DAT_ram_00a66958 + 0x20)) {
		    iVar2 = param1_01[3];
		    puVar1 = (undefined4 *)func_ii_15774(param1_02);
		    Gameplay_Tournaments_Model_TournamentsModel__PopulateTournaments(param1_00,iVar2,*puVar1,param1)
		    ;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x24);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		    return;
		  }
		  System_Activator__CreateInstance(param1_02,DAT_ram_00a66958);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CFF")]
		[Address(RVA = "0x6E7E", Offset = "0x6E7E", VA = "0x6E7E")]
		private void GetTournamentHistoryResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetTournamentHistoryResultHandler ---
		void Gameplay_Tournaments_Controller_TournamentsController__GetTournamentHistoryResultHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58558 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsController_LeaveTournamentResultHandler__
		              );
		    DAT_ram_00a58558 = '\x01';
		  }
		  param1_00 = ServicesNamespace_TournamentsService__Unsubscribe(*(undefined4 *)(param1 + 0x18),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Tournaments_Controller_TournamentsController_LeaveTournamentResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D00")]
		[Address(RVA = "0x6E7F", Offset = "0x6E7F", VA = "0x6E7F")]
		public void LeaveTournament()
		{
		/* --- GHIDRA: LeaveTournament ---
		void Gameplay_Tournaments_Controller_TournamentsController__LeaveTournament
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a58559 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_BaseEventBusEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_ProtoLeaveTournamentAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15153);
		    DAT_ram_00a58559 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Tournaments_ProtoLeaveTournamentAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Tournaments_ProtoLeaveTournamentAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (param1_00[3] == -1) {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15153,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar2,6,uVar3,0);
		    return;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined1 *)(iVar1 + 0x1c) = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x20);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),0,*(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a5850e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		    DAT_ram_00a5850e = '\x01';
		  }
		  iVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar1 + 0xc),*(undefined4 *)(iVar1 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		  *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0xc) + 0x14) + 0x30) = 0;
		  iVar1 = System_Uri___ctor(0);
		  iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x30) + 0x10);
		  if (iVar1 != 0) {
		    uVar2 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    uVar3 = unnamed_function_1417(Core_Events_BaseEventBusEventArgs_TypeInfo);
		    Core_Application_Managers_Connection_ServerConnectionDelay__ResetAll(uVar3,uVar2,param3_00,0);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),uVar3,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D01")]
		[Address(RVA = "0x6E80", Offset = "0x6E80", VA = "0x6E80")]
		private void LeaveTournamentResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: LeaveTournamentResultHandler ---
		void Gameplay_Tournaments_Controller_TournamentsController__LeaveTournamentResultHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5855a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBetChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoStateChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsController_BetChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsController_StateChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsController_SubscribeResultHandler__
		              );
		    DAT_ram_00a5855a = '\x01';
		  }
		  if (*(char *)(param1 + 0x1c) == '\0') {
		    *(undefined1 *)(param1 + 0x1c) = 1;
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_ProtoBetChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsController_BetChangedEventHandler__
		               ,0);
		    ServicesNamespace_TournamentsService__get_ServiceId(uVar2,uVar1,0);
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_ProtoStateChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsController_StateChangedEventHandler__
		               ,0);
		    ServicesNamespace_TournamentsService__remove_HealthChangedEvent(uVar2,uVar1,0);
		    uVar1 = ServicesNamespace_TournamentsService__GetTournamentHistory
		                      (*(undefined4 *)(param1 + 0x18),0);
		    uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsController_SubscribeResultHandler__
		               ,0);
		    ServicesNamespace_MainService__GetUserStats
		              (uVar1,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D02")]
		[Address(RVA = "0x6E81", Offset = "0x6E81", VA = "0x6E81")]
		public void Subscribe()
		{
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D03")]
		[Address(RVA = "0x6E82", Offset = "0x6E82", VA = "0x6E82")]
		private void SubscribeResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: SubscribeResultHandler ---
		void Gameplay_Tournaments_Controller_TournamentsController__SubscribeResultHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5855b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBetChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoStateChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsController_BetChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsController_StateChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsController_UnsubscribeResultHandler__
		              );
		    DAT_ram_00a5855b = '\x01';
		  }
		  if (*(char *)(param1 + 0x1c) != '\0') {
		    *(undefined1 *)(param1 + 0x1c) = 0;
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_ProtoBetChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsController_BetChangedEventHandler__
		               ,0);
		    ServicesNamespace_TournamentsService__add_BetChangedEvent(uVar2,uVar1,0);
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_ProtoStateChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsController_StateChangedEventHandler__
		               ,0);
		    ServicesNamespace_TournamentsService__add_StateChangedEvent(uVar2,uVar1,0);
		    uVar1 = ServicesNamespace_TournamentsService__Subscribe(*(undefined4 *)(param1 + 0x18),0);
		    uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsController_UnsubscribeResultHandler__
		               ,0);
		    ServicesNamespace_MainService__GetUserStats
		              (uVar1,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D04")]
		[Address(RVA = "0x6E83", Offset = "0x6E83", VA = "0x6E83")]
		public void Unsubscribe()
		{
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D05")]
		[Address(RVA = "0x6E84", Offset = "0x6E84", VA = "0x6E84")]
		private void UnsubscribeResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: UnsubscribeResultHandler ---
		void Gameplay_Tournaments_Controller_TournamentsController__UnsubscribeResultHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5855c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoHealtChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBetChangedOnPlayerEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsController_BetOnPlayerChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsController_CurrentCombatCompleteEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsController_FinalCombatCompleteEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsController_HealthChangedEventHandler__
		              );
		    DAT_ram_00a5855c = '\x01';
		  }
		  if (*(char *)(param1 + 0x1d) == '\0') {
		    *(undefined1 *)(param1 + 0x1d) = 1;
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_ProtoBetChangedOnPlayerEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsController_BetOnPlayerChangedEventHandler__
		               ,0);
		    ServicesNamespace_TournamentsService__remove_BetChangedEvent(uVar2,uVar1,0);
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_ProtoHealtChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsController_HealthChangedEventHandler__
		               ,0);
		    ServicesNamespace_TournamentsService__remove_BetChangedOnPlayerEvent(uVar2,uVar1,0);
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsController_CurrentCombatCompleteEventHandler__
		               ,0);
		    ServicesNamespace_TournamentsService__remove_StateChangedEvent(uVar2,uVar1,0);
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsController_FinalCombatCompleteEventHandler__
		               ,0);
		    ServicesNamespace_TournamentsService__remove_CurrentCombatCompleteEvent(uVar2,uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D06")]
		[Address(RVA = "0x6E85", Offset = "0x6E85", VA = "0x6E85")]
		public void SubscribeToParticipantEvents()
		{
		/* --- GHIDRA: SubscribeToParticipantEvents ---
		void Gameplay_Tournaments_Controller_TournamentsController__SubscribeToParticipantEvents
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5855d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoHealtChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBetChangedOnPlayerEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsController_BetOnPlayerChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsController_CurrentCombatCompleteEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsController_FinalCombatCompleteEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsController_HealthChangedEventHandler__
		              );
		    DAT_ram_00a5855d = '\x01';
		  }
		  if (*(char *)(param1 + 0x1d) != '\0') {
		    *(undefined1 *)(param1 + 0x1d) = 0;
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_ProtoBetChangedOnPlayerEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsController_BetOnPlayerChangedEventHandler__
		               ,0);
		    ServicesNamespace_TournamentsService__add_BetChangedOnPlayerEvent(uVar2,uVar1,0);
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_ProtoHealtChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsController_HealthChangedEventHandler__
		               ,0);
		    ServicesNamespace_TournamentsService__add_HealthChangedEvent(uVar2,uVar1,0);
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsController_CurrentCombatCompleteEventHandler__
		               ,0);
		    ServicesNamespace_TournamentsService__add_CurrentCombatCompleteEvent(uVar2,uVar1,0);
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentsController_FinalCombatCompleteEventHandler__
		               ,0);
		    ServicesNamespace_TournamentsService__add_FinalCombatCompleteEvent(uVar2,uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D07")]
		[Address(RVA = "0x6E86", Offset = "0x6E86", VA = "0x6E86")]
		public void UnsubscribeFromParticipantEvents()
		{
		/* --- GHIDRA: UnsubscribeFromParticipantEvents ---
		void Gameplay_Tournaments_Controller_TournamentsController__UnsubscribeFromParticipantEvents
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(char *)(iVar1 + 0x1c) = (char)param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x20);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D08")]
		[Address(RVA = "0x6E87", Offset = "0x6E87", VA = "0x6E87")]
		public void BlockUI(bool block)
		{
		/* --- GHIDRA: BlockUI ---
		void Gameplay_Tournaments_Controller_TournamentsController__BlockUI
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int local_4;
		  
		  if (DAT_ram_00a5855e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__TryGetValue__);
		    DAT_ram_00a5855e = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(iVar1 + 0xc),*(undefined4 *)(param2 + 0xc),&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__TryGetValue__
		                    );
		  if (iVar1 != 0) {
		    iVar1 = *(int *)(local_4 + 0xc);
		    *(undefined4 *)(iVar1 + 0x18) = *(undefined4 *)(param2 + 0x10);
		    *(undefined4 *)(iVar1 + 0x10) = *(undefined4 *)(param2 + 0x20);
		    *(undefined4 *)(*(int *)(iVar1 + 0x14) + 0x24) = *(undefined4 *)(param2 + 0x24);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x28);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D09")]
		[Address(RVA = "0x6E88", Offset = "0x6E88", VA = "0x6E88")]
		private void BetChangedEventHandler(ProtoBetChangedEvt evt)
		{
		/* --- GHIDRA: BetChangedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentsController__BetChangedEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
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

		// Token: 0x06001D0A RID: 7434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0A")]
		[Address(RVA = "0x6E89", Offset = "0x6E89", VA = "0x6E89")]
		private void BetOnPlayerChangedEventHandler(ProtoBetChangedOnPlayerEvt evt)
		{
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0B")]
		[Address(RVA = "0x6E8A", Offset = "0x6E8A", VA = "0x6E8A")]
		private void HealthChangedEventHandler(ProtoHealtChangedEvt evt)
		{
		/* --- GHIDRA: HealthChangedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentsController__HealthChangedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Tournaments_Model_TournamentsModel__set_NextStateBacktime(param1_00,param2,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x20) == *(int *)(param2 + 0xc)) {
		    Gameplay_Tournaments_Controller_TournamentsController__StateChangedEventHandler
		              (param1,*(undefined4 *)(param2 + 0x10),param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined1 *)(iVar1 + 0x1c) = 0;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x20);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),0,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x34);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0C")]
		[Address(RVA = "0x6E8B", Offset = "0x6E8B", VA = "0x6E8B")]
		private void StateChangedEventHandler(ProtoStateChangedEvt evt)
		{
		/* --- GHIDRA: StateChangedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentsController__StateChangedEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  float param2_00;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 *puVar7;
		  ulonglong param1_00;
		  
		  if (DAT_ram_00a5855f == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_Fighter___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_Fighter___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_Fighter___);
		    Mono_Security_ASN1__get_Item(&System_Func_Fighter__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsController___c__HandleTournamentState_b__28_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsController___c__DisplayClass28_0__HandleTournamentState_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentsController___c__DisplayClass28_0__HandleTournamentState_b__2__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tournaments_Controller_TournamentsController___c__DisplayClass28_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tournaments_Controller_TournamentsController___c_TypeInfo);
		    DAT_ram_00a5855f = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (
		                    Gameplay_Tournaments_Controller_TournamentsController___c__DisplayClass28_0_TypeInfo
		                    );
		  *(int **)(iVar2 + 0xc) = param1;
		  *(undefined4 *)(iVar2 + 8) = param2;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (CONCAT44(in_register_20000004,param1),*(undefined4 *)(*param1 + 0x104));
		  param1_00 = (ulonglong)*(uint *)(*(int *)(iVar2 + 8) + 0x10);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = func_ii_7331(param1_00,0);
		  uVar1 = (undefined4)(param1_00 >> 0x20);
		  uVar4 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar4,param2_00,0);
		  *(undefined4 *)(iVar3 + 0x2c) = uVar4;
		  iVar3 = *(int *)(iVar2 + 8);
		  if ((*(int *)(iVar3 + 0x30) == 2) &&
		     ((iVar5 = *(int *)(iVar3 + 0xc), iVar5 == 2 || ((iVar5 != 3 && (iVar5 == 4)))))) {
		    uVar6 = *(undefined4 *)(iVar3 + 0x2c);
		    uVar4 = unnamed_function_1417(System_Func_Fighter__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar4,iVar2,
		               Method_Gameplay_Tournaments_Controller_TournamentsController___c__DisplayClass28_0__HandleTournamentState_b__0__
		               ,0);
		    uVar4 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                      (uVar6,uVar4,Method_System_Linq_Enumerable_Where_Fighter___);
		    if (*(int *)(Gameplay_Tournaments_Controller_TournamentsController___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Tournaments_Controller_TournamentsController___c_TypeInfo);
		    }
		    puVar7 = *(undefined4 **)
		              (Gameplay_Tournaments_Controller_TournamentsController___c_TypeInfo + 0x5c);
		    iVar3 = puVar7[2];
		    if (iVar3 == 0) {
		      if (*(int *)(Gameplay_Tournaments_Controller_TournamentsController___c_TypeInfo + 0x74) == 0)
		      {
		        func_ii_306000(Gameplay_Tournaments_Controller_TournamentsController___c_TypeInfo);
		        puVar7 = *(undefined4 **)
		                  (Gameplay_Tournaments_Controller_TournamentsController___c_TypeInfo + 0x5c);
		      }
		      uVar6 = *puVar7;
		      iVar3 = unnamed_function_1417(System_Func_Fighter__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (iVar3,uVar6,
		                 Method_Gameplay_Tournaments_Controller_TournamentsController___c__HandleTournamentState_b__28_1__
		                 ,0);
		      *(int *)(*(int *)(Gameplay_Tournaments_Controller_TournamentsController___c_TypeInfo + 0x5c) +
		              8) = iVar3;
		    }
		    iVar3 = Newtonsoft_Json_Utilities_ReflectionUtils__IsOverridenGenericMember
		                      (uVar4,iVar3,Method_System_Linq_Enumerable_Any_Fighter___);
		    uVar6 = *(undefined4 *)(*(int *)(iVar2 + 8) + 0x2c);
		    uVar4 = unnamed_function_1417(System_Func_Fighter__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar4,iVar2,
		               Method_Gameplay_Tournaments_Controller_TournamentsController___c__DisplayClass28_0__HandleTournamentState_b__2__
		               ,0);
		    iVar2 = System_Func_object__bool____ctor
		                      (uVar6,uVar4,Method_System_Linq_Enumerable_FirstOrDefault_Fighter___);
		    if ((iVar2 != 0) && (iVar3 == 0 && *(int *)(iVar2 + 0x1c) == 0)) {
		      iVar3 = *param1;
		      iVar2 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x100) * 4))
		                        (CONCAT44(uVar1,param1),*(undefined4 *)(iVar3 + 0x104));
		      Gameplay_Tournaments_Controller_TournamentsController__StartCombatImmediately
		                (param1,*(undefined4 *)(iVar2 + 8),0,iVar3);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0D")]
		[Address(RVA = "0x6E8C", Offset = "0x6E8C", VA = "0x6E8C")]
		private void HandleTournamentState(StateInfo stateInfo)
		{
		/* --- GHIDRA: HandleTournamentState ---
		void Gameplay_Tournaments_Controller_TournamentsController__HandleTournamentState
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x38);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0E")]
		[Address(RVA = "0x6E8D", Offset = "0x6E8D", VA = "0x6E8D")]
		private void CurrentCombatCompleteEventHandler(ProtoCurrentTnmCombatCompleteEvt evt)
		{
		/* --- GHIDRA: CurrentCombatCompleteEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentsController__CurrentCombatCompleteEventHandler
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  undefined4 param4;
		  undefined4 param3_00;
		  undefined8 param6;
		  undefined8 param5;
		  
		  if (DAT_ram_00a58560 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Events_Scopes_TournamentsScope_FinalCombatCompleteEventArgs_TypeInfo);
		    DAT_ram_00a58560 = '\x01';
		  }
		  iVar1 = System_Uri___ctor(0);
		  iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x30) + 0xc);
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
		                          (Core_Events_Scopes_TournamentsScope_FinalCombatCompleteEventArgs_TypeInfo
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

		// Token: 0x06001D0F RID: 7439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0F")]
		[Address(RVA = "0x6E8E", Offset = "0x6E8E", VA = "0x6E8E")]
		private void FinalCombatCompleteEventHandler(ProtoFinalTnmCombatCompleteEvt evt)
		{
		/* --- GHIDRA: FinalCombatCompleteEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentsController__FinalCombatCompleteEventHandler
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58561 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_TournamentsModel__TournamentsEvents__Dispose__);
		    DAT_ram_00a58561 = '\x01';
		  }
		  Gameplay_Tournaments_Controller_TournamentsController__SubscribeResultHandler(param1,param1);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_TournamentsModel__TournamentsEvents__Dispose__);
		  return;
		}
		*/

		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D10")]
		[Address(RVA = "0x6E8F", Offset = "0x6E8F", VA = "0x6E8F", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Tournaments_Controller_TournamentsController__Dispose(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58562 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tournaments_Controller_TournamentsController___c_TypeInfo);
		    DAT_ram_00a58562 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Tournaments_Controller_TournamentsController___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Tournaments_Controller_TournamentsController___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04000FD2 RID: 4050
		[Token(Token = "0x4000FD2")]
		[FieldOffset(Offset = "0x18")]
		private TournamentsService _tournamentsService;

		// Token: 0x04000FD3 RID: 4051
		[Token(Token = "0x4000FD3")]
		[FieldOffset(Offset = "0x1C")]
		private bool _subscribed;

		// Token: 0x04000FD4 RID: 4052
		[Token(Token = "0x4000FD4")]
		[FieldOffset(Offset = "0x1D")]
		private bool _participantSubscribed;
	}
}
