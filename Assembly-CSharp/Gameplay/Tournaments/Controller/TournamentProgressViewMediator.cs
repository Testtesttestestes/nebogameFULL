using System;
using System.Collections.Generic;
using Gameplay.Tournaments.Events;
using Gameplay.Tournaments.Model;
using Gameplay.Tournaments.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Tournaments;
using UnityEngine;

namespace Gameplay.Tournaments.Controller
{
	// Token: 0x020004C0 RID: 1216
	[Token(Token = "0x20004C0")]
	public class TournamentProgressViewMediator : AbstractViewMediator<TournamentsModel, TournamentsEvents, TournamentsController, TournamentProgressWindow>
	{
		// Token: 0x06001CC3 RID: 7363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CC3")]
		[Address(RVA = "0x6E42", Offset = "0x6E42", VA = "0x6E42")]
		public TournamentProgressViewMediator(TournamentsModel model, TournamentsEvents events, TournamentsController controller)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Tournaments_Controller_TournamentProgressViewMediator___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5852c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    DAT_ram_00a5852c = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 8);
		  if (DAT_ram_00a5850e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		    DAT_ram_00a5850e = '\x01';
		  }
		  iVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar1 + 0xc),*(undefined4 *)(iVar1 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		  return *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0xc) + 0x14) + 0xc);
		}
		*/

		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x00006048 File Offset: 0x00004248
		[Token(Token = "0x17000530")]
		private TournamentStates _currentState
		{
			[Token(Token = "0x6001CC4")]
			[Address(RVA = "0x6E43", Offset = "0x6E43", VA = "0x6E43")]
			get
			{
				return TournamentStates.NoTournament;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x00006060 File Offset: 0x00004260
		[Token(Token = "0x17000531")]
		private bool _selectable
		{
			[Token(Token = "0x6001CC5")]
			[Address(RVA = "0x6E44", Offset = "0x6E44", VA = "0x6E44")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000532 RID: 1330
		// (set) Token: 0x06001CC6 RID: 7366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000532")]
		public override TournamentProgressWindow View
		{
			[Token(Token = "0x6001CC6")]
			[Address(RVA = "0x6E45", Offset = "0x6E45", VA = "0x6E45", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000533 RID: 1331
		// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000533")]
		public override TournamentsEvents Events
		{
			[Token(Token = "0x6001CC7")]
			[Address(RVA = "0x6E46", Offset = "0x6E46", VA = "0x6E46", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CC8")]
		[Address(RVA = "0x6E47", Offset = "0x6E47", VA = "0x6E47")]
		private void CurrentCombatCompleteEventHandler(ProtoCurrentTnmCombatCompleteEvt evt)
		{
		/* --- GHIDRA: CurrentCombatCompleteEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__CurrentCombatCompleteEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58530 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__set_Controller__
		              );
		    DAT_ram_00a58530 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (iVar1 != 0) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    Gameplay_Tournaments_Controller_TournamentsController__SubscribeToParticipantEvents
		              (uVar2,param1);
		  }
		  param1[4] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (iVar1 != 0) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    Gameplay_Tournaments_Controller_TournamentsController__UnsubscribeResultHandler(uVar2,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000534 RID: 1332
		// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000534")]
		public override TournamentsController Controller
		{
			[Token(Token = "0x6001CC9")]
			[Address(RVA = "0x6E48", Offset = "0x6E48", VA = "0x6E48", Slot = "18")]
			set
			{
			}
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CCA")]
		[Address(RVA = "0x6E49", Offset = "0x6E49", VA = "0x6E49")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__Init
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a58532 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19433);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27811);
		    DAT_ram_00a58532 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80f03054;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f03054:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetResourceSetParameter(uVar3,StringLiteral_27811,0);
		  Core_ExternAppMethods__OpenPaymentWindow(uVar3,StringLiteral_19433,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CCB")]
		[Address(RVA = "0x6E4A", Offset = "0x6E4A", VA = "0x6E4A")]
		private void RulesButtonClickHandler()
		{
		/* --- GHIDRA: RulesButtonClickHandler ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__RulesButtonClickHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Tournaments_Controller_TournamentsController__SetBetResultHandler
		            (param1_00,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CCC")]
		[Address(RVA = "0x6E4B", Offset = "0x6E4B", VA = "0x6E4B")]
		private void WatchBattleButtonClickedEventHandler(UserInfo userInfo)
		{
		/* --- GHIDRA: WatchBattleButtonClickedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__WatchBattleButtonClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a58533 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    DAT_ram_00a58533 = '\x01';
		  }
		  if (*(int *)(param2 + 0xc) == *(int *)(param1[2] + 0x20)) {
		    iVar1 = *(int *)(*(int *)(param2 + 0x10) + 0xc);
		    if ((iVar1 == 0) ||
		       ((((iVar1 != 1 && (iVar1 != 2)) && (iVar1 != 3)) && ((iVar1 != 4 && (iVar1 == 5)))))) {
		      param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		      System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(param1_00,0,0);
		      return;
		    }
		    Gameplay_Tournaments_Controller_TournamentProgressViewMediator__set_Controller(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CCD")]
		[Address(RVA = "0x6E4C", Offset = "0x6E4C", VA = "0x6E4C")]
		private void StateChangedEventHandler(ProtoStateChangedEvt evt)
		{
		/* --- GHIDRA: StateChangedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__StateChangedEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  uint *puVar7;
		  longlong lVar8;
		  int iVar9;
		  undefined4 param2_00;
		  longlong lVar10;
		  int *piVar11;
		  uint uVar12;
		  undefined8 local_28;
		  undefined8 local_20;
		  int local_14;
		  int **local_10;
		  int local_c;
		  int *local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58534 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView__TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_Fighter__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_Fighter__GetEnumerator__);
		    DAT_ram_00a58534 = '\x01';
		  }
		  local_c = 0;
		  if (*(int *)(*(int *)(param1 + 8) + 0x20) != *(int *)(param2 + 0xc)) {
		    return;
		  }
		  local_8 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(param2 + 0x10),
		                              Method_Google_Protobuf_Collections_RepeatedField_Fighter__GetEnumerator__
		                             );
		  local_14 = 0;
		  local_10 = &local_8;
		  do {
		    do {
		      do {
		        piVar6 = local_8;
		        iVar9 = *local_8;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar12 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar12 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		              puVar2 = (undefined4 *)(iVar9 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x80f037b2;
		            }
		            uVar12 = uVar12 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar12);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f037fa:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f03b4e;
		        }
		code_r0x80f037b2:
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iii(*puVar2,piVar6,puVar2[1]);
		        piVar6 = local_8;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f037fa;
		        if (iVar9 == 0) {
		          iVar9 = 6;
		          goto code_r0x80f03b9b;
		        }
		        iVar9 = *local_8;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar12 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar12 * 8);
		            if (System_Collections_Generic_IEnumerator_Fighter__TypeInfo == *piVar11) {
		              puVar2 = (undefined4 *)(iVar9 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x80f038a7;
		            }
		            uVar12 = uVar12 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar12);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                            System_Collections_Generic_IEnumerator_Fighter__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f03a2f:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f03b4e;
		        }
		code_r0x80f038a7:
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iii(*puVar2,piVar6,puVar2[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f03a2f;
		        iVar5 = *(int *)(param1 + 8);
		        if (DAT_ram_00a5850e == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (0x7ff,&
		                           Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__
		                    );
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_00a5850e = '\x01';
		            goto code_r0x80f03930;
		          }
		code_r0x80f03a39:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f03b4e;
		        }
		code_r0x80f03930:
		        DAT_ram_009d3e38 = 0;
		        iVar5 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                           *(undefined4 *)(iVar5 + 0xc),*(undefined4 *)(iVar5 + 0x20),
		                           Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__
		                          );
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f03a39;
		        *(undefined4 *)(iVar9 + 0x24) = *(undefined4 *)(*(int *)(iVar5 + 8) + 0x10);
		        lVar10 = *(longlong *)(*(int *)(iVar9 + 0xc) + 0x10);
		        DAT_ram_009d3e38 = 0;
		        lVar8 = unnamed_function_184054
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x356,
		                           *(undefined4 *)(*(int *)(param1 + 8) + 8),0);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f03b4e;
		        }
		        if (lVar10 == lVar8) {
		          *(undefined1 *)(iVar9 + 0x28) = 1;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar4 = unnamed_function_184060
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2c,
		                           *(undefined4 *)(param1 + 0x30),
		                           *(undefined8 *)(*(int *)(iVar9 + 0xc) + 0x10),&local_c,
		                           Method_System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView__TryGetValue__
		                          );
		        iVar1 = local_c;
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f03b4e;
		        }
		      } while (iVar4 == 0);
		      *(int *)(local_c + 0x3c) = iVar9;
		      param2_00 = *(undefined4 *)(local_c + 0x38);
		      local_4 = *(undefined4 *)(iVar9 + 0x18);
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x167,&local_4,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f03b46;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x107,param2_00,uVar3,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f03b46;
		    } while (*(char *)(iVar9 + 0x28) == '\0');
		    iVar9 = **(int **)(iVar1 + 0x10);
		    DAT_ram_009d3e38 = 0;
		    local_20 = *(undefined8 *)(iVar1 + 0x28);
		    local_28 = *(undefined8 *)(iVar1 + 0x20);
		    import::env::invoke_viii
		              (*(undefined4 *)(iVar9 + 0x178),*(int **)(iVar1 + 0x10),&local_28,
		               *(undefined4 *)(iVar9 + 0x17c));
		  } while (DAT_ram_009d3e38 != 1);
		code_r0x80f03b46:
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f03b4e:
		  iVar9 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_14 = *piVar6;
		    iVar9 = 0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x80f03b9b:
		      DAT_ram_009d3e38 = 0;
		      piVar6 = *local_10;
		      if (piVar6 != (int *)0x0) {
		        uVar12 = 0;
		        iVar5 = *piVar6;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar12 * 8)) {
		              puVar7 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar12 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80f03c16;
		            }
		            uVar12 = uVar12 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar12);
		        }
		        puVar7 = (uint *)func_ii_1080(piVar6,System_IDisposable_TypeInfo,0);
		code_r0x80f03c16:
		        (**(code **)((ulonglong)*puVar7 * 4))(piVar6,puVar7[1]);
		      }
		      if (local_14 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_14);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (iVar9 != 0) {
		        if (iVar9 == 1) {
		          return;
		        }
		        if (iVar9 == 2) {
		          return;
		        }
		        if (iVar9 == 3) {
		          return;
		        }
		        if (iVar9 == 4) {
		          return;
		        }
		        if (iVar9 == 5) {
		          return;
		        }
		        if (iVar9 != 6) {
		          return;
		        }
		      }
		      if (*(int *)(param1 + 0x28) == 2) {
		        Gameplay_Tournaments_Controller_TournamentProgressViewMediator__DisplayBetOnPlayerInfo
		                  (param1,0);
		        return;
		      }
		      Gameplay_Tournaments_Controller_TournamentProgressViewMediator__DisplayBetOnPlayerForViewer
		                (param1,0);
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x181,&local_14);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CCE")]
		[Address(RVA = "0x6E4D", Offset = "0x6E4D", VA = "0x6E4D")]
		private void BetChangedOnPlayerEventHandler(ProtoBetChangedOnPlayerEvt evt)
		{
		/* --- GHIDRA: BetChangedOnPlayerEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__BetChangedOnPlayerEventHandler
		               (undefined4 param1,undefined8 param2,undefined4 param3)
		
		{
		  Gameplay_Tournaments_Controller_TournamentProgressViewMediator__DisplayPageBeforeBet
		            (param1,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CCF")]
		[Address(RVA = "0x6E4E", Offset = "0x6E4E", VA = "0x6E4E")]
		private void BetOnPlayerEventHandler(ulong userId)
		{
		/* --- GHIDRA: BetOnPlayerEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__BetOnPlayerEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58535 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    DAT_ram_00a58535 = '\x01';
		  }
		  if (param1[0xd] != 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1[0xd] + 0x1c),0,0);
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param2 + 0x1c),1,0);
		  param1[0xd] = param2;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Tournaments_Controller_TournamentsController__AddBetResultHandler
		            (param1_00,*(undefined4 *)(param1[2] + 0x20),
		             *(undefined8 *)(*(int *)(*(int *)(param2 + 0x3c) + 0xc) + 0x10),param1);
		  return;
		}
		*/

		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD0")]
		[Address(RVA = "0x6E4F", Offset = "0x6E4F", VA = "0x6E4F")]
		private void PlayerViewClickedEventHandler(TournamentPlayerBattleView playerView)
		{
		/* --- GHIDRA: PlayerViewClickedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__PlayerViewClickedEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58536 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView__TryGetValue__
		              );
		    DAT_ram_00a58536 = '\x01';
		  }
		  local_4 = 0;
		  if ((*(int *)(param2 + 0xc) == *(int *)(*(int *)(param1 + 8) + 0x20)) &&
		     (iVar1 = func_ii_7090(*(undefined4 *)(param1 + 0x30),*(undefined8 *)(param2 + 0x10),&local_4,
		                           Method_System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView__TryGetValue__
		                          ), iVar1 != 0)) {
		    UnityEngine_GameObject__get_transform(local_4,*(undefined4 *)(param2 + 0x18),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD1")]
		[Address(RVA = "0x6E50", Offset = "0x6E50", VA = "0x6E50")]
		private void HealthChangedEventHandler(ProtoHealtChangedEvt evt)
		{
		/* --- GHIDRA: HealthChangedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__HealthChangedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58537 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TournamentPlayerBattleView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_View_BattleInfoListElementBase_TournamentPlayerBattleView__ValueTuple_Fighter__Fighter___add_PlayerViewClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_PlayerViewClickedEventHandler__
		              );
		    DAT_ram_00a58537 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 8);
		  if (DAT_ram_00a5850e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		    DAT_ram_00a5850e = '\x01';
		  }
		  iVar2 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar2 + 0xc),*(undefined4 *)(iVar2 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		  *(undefined4 *)(param1 + 0x28) = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0xc) + 0x14) + 0x30);
		  if (DAT_ram_00a5852c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    DAT_ram_00a5852c = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 8);
		  if (DAT_ram_00a5850e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		    DAT_ram_00a5850e = '\x01';
		  }
		  iVar2 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar2 + 0xc),*(undefined4 *)(iVar2 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		  if (((*(int *)(*(int *)(*(int *)(iVar2 + 0xc) + 0x14) + 0xc) == 2) &&
		      (*(int *)(param1 + 0x28) == 1)) &&
		     (iVar2 = *(int *)(param1 + 0x2c), 0 < *(int *)(iVar2 + 0xc))) {
		    iVar1 = 0;
		    do {
		      param1_01 = *(undefined4 *)(iVar2 + iVar1 * 4 + 0x10);
		      param1_00 = unnamed_function_1417(System_Action_TournamentPlayerBattleView__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (param1_00,param1,
		                 Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_PlayerViewClickedEventHandler__
		                 ,0);
		      Gameplay_BlitzTournament_View_BattleInfoListElementBase_object____Il2CppFullySharedGenericType___PlayerClickedEventHandler
		                (param1_01,param1_00,
		                 Method_Gameplay_BlitzTournament_View_BattleInfoListElementBase_TournamentPlayerBattleView__ValueTuple_Fighter__Fighter___add_PlayerViewClickedEvent__
		                );
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD2")]
		[Address(RVA = "0x6E51", Offset = "0x6E51", VA = "0x6E51")]
		private void DeterminePlayerRole()
		{
		/* --- GHIDRA: DeterminePlayerRole ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__DeterminePlayerRole
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  longlong lVar7;
		  int iVar8;
		  int iVar9;
		  int iVar10;
		  int iVar11;
		  longlong lVar12;
		  int *piVar13;
		  int iVar14;
		  uint uVar15;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  int *local_10;
		  int local_c;
		  float4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58538 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_UserInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView__Clear__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView__set_Item__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_Fighter__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_Fighter__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_WatchBattleButtonClickedEventHandler__
		              );
		    DAT_ram_00a58538 = '\x01';
		  }
		  iVar8 = param1[2];
		  if (DAT_ram_00a5850e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		    DAT_ram_00a5850e = '\x01';
		  }
		  iVar8 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar8 + 0xc),*(undefined4 *)(iVar8 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		  local_10 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                              (*(undefined4 *)(*(int *)(*(int *)(iVar8 + 0xc) + 0x14) + 0x2c),
		                               Method_Google_Protobuf_Collections_RepeatedField_Fighter__GetEnumerator__
		                              );
		  local_c = 0;
		  local_8 = (float4)&local_10;
		code_r0x80f009a4:
		  piVar5 = local_10;
		  iVar8 = *local_10;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar15 = 0;
		    do {
		      piVar13 = (int *)(*(int *)(iVar8 + 0x58) + uVar15 * 8);
		      if (System_Collections_IEnumerator_TypeInfo == *piVar13) {
		        puVar2 = (undefined4 *)(iVar8 + piVar13[1] * 8 + 0xc0);
		        goto code_r0x80f00a3c;
		      }
		      uVar15 = uVar15 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar15);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar2 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_10,
		                      System_Collections_IEnumerator_TypeInfo,0);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x80f00a84:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80f00c81;
		  }
		code_r0x80f00a3c:
		  DAT_ram_009d3e38 = 0;
		  iVar8 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		  piVar5 = local_10;
		  if (DAT_ram_009d3e38 == 1) goto code_r0x80f00a84;
		  if (iVar8 == 0) {
		    iVar8 = 0;
		    goto code_r0x80f00cca;
		  }
		  iVar8 = *local_10;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar15 = 0;
		    do {
		      piVar13 = (int *)(*(int *)(iVar8 + 0x58) + uVar15 * 8);
		      if (System_Collections_Generic_IEnumerator_Fighter__TypeInfo == *piVar13) {
		        puVar2 = (undefined4 *)(iVar8 + piVar13[1] * 8 + 0xc0);
		        goto code_r0x80f00b29;
		      }
		      uVar15 = uVar15 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar15);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar2 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_10,
		                      System_Collections_Generic_IEnumerator_Fighter__TypeInfo,0);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x80f00c65:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80f00c81;
		  }
		code_r0x80f00b29:
		  DAT_ram_009d3e38 = 0;
		  iVar8 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		  if (DAT_ram_009d3e38 == 1) goto code_r0x80f00c65;
		  iVar4 = param1[2];
		  if (DAT_ram_00a5850e == '\0') {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vi
		              (0x7ff,&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__)
		    ;
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_00a5850e = '\x01';
		      goto code_r0x80f00bb2;
		    }
		code_r0x80f00c6f:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80f00c81;
		  }
		code_r0x80f00bb2:
		  DAT_ram_009d3e38 = 0;
		  iVar4 = import::env::invoke_iiii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                     *(undefined4 *)(iVar4 + 0xc),*(undefined4 *)(iVar4 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		  if (DAT_ram_009d3e38 == 1) goto code_r0x80f00c6f;
		  *(undefined4 *)(iVar8 + 0x24) = *(undefined4 *)(*(int *)(iVar4 + 8) + 0x10);
		  lVar12 = *(longlong *)(*(int *)(iVar8 + 0xc) + 0x10);
		  DAT_ram_009d3e38 = 0;
		  lVar7 = unnamed_function_184054
		                    (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x356,
		                     *(undefined4 *)(param1[2] + 8),0);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 != 1) {
		    if (lVar12 == lVar7) {
		      *(undefined1 *)(iVar8 + 0x28) = 1;
		    }
		    goto code_r0x80f009a4;
		  }
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f00c81:
		  iVar8 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar8 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar8;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		code_r0x80f00cca:
		      piVar5 = local_10;
		      DAT_ram_009d3e38 = 0;
		      if (local_10 != (int *)0x0) {
		        uVar15 = 0;
		        iVar4 = *local_10;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar15 * 8)) {
		              puVar6 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar15 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80f00d42;
		            }
		            uVar15 = uVar15 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar15);
		        }
		        puVar6 = (uint *)func_ii_1080(local_10,System_IDisposable_TypeInfo,0);
		code_r0x80f00d42:
		        uVar1 = CONCAT44(in_register_20000014,puVar6[1]);
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,uVar1);
		        in_register_20000014 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      }
		      if (iVar8 == 0) {
		        uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c)));
		        iVar8 = param1[2];
		        if (DAT_ram_00a5850e == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__)
		          ;
		          DAT_ram_00a5850e = '\x01';
		        }
		        param2_00 = System_Collections_Generic_List_object___get_Item
		                              (*(undefined4 *)(iVar8 + 0xc),*(undefined4 *)(iVar8 + 0x20),
		                               Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__
		                              );
		        param1_00 = unnamed_function_1417(System_Action_UserInfo__TypeInfo);
		        UnityEngine_UIElements_VisualElement__get_layout
		                  (param1_00,param1,
		                   Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_WatchBattleButtonClickedEventHandler__
		                   ,0);
		        iVar8 = Gameplay_Tournaments_View_TournamentProgressWindow__OnClose
		                          (uVar3,param2_00,param1_00,&local_30);
		        param1[0xb] = iVar8;
		        System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		                  (param1[0xc],
		                   Method_System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView__Clear__
		                  );
		        iVar8 = param1[0xb];
		        if (0 < *(int *)(iVar8 + 0xc)) {
		          iVar4 = 0;
		          do {
		            iVar9 = *(int *)(iVar8 + iVar4 * 4 + 0x10);
		            iVar10 = *(int *)(*(int *)(iVar9 + 0x14) + 0x3c);
		            iVar14 = *(int *)(*(int *)(iVar9 + 0x10) + 0x3c);
		            Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel_DollArtifacts___ctor
		                      (param1[0xc],*(undefined8 *)(*(int *)(iVar14 + 0xc) + 0x10),
		                       *(int *)(iVar9 + 0x10),
		                       Method_System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView__set_Item__
		                      );
		            Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel_DollArtifacts___ctor
		                      (param1[0xc],*(undefined8 *)(*(int *)(iVar10 + 0xc) + 0x10),
		                       *(undefined4 *)(iVar9 + 0x14),
		                       Method_System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView__set_Item__
		                      );
		            iVar11 = param1[2];
		            if (DAT_ram_00a5850e == '\0') {
		              Mono_Security_ASN1__get_Item
		                        (&
		                         Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__
		                        );
		              DAT_ram_00a5850e = '\x01';
		            }
		            iVar11 = System_Collections_Generic_List_object___get_Item
		                               (*(undefined4 *)(iVar11 + 0xc),*(undefined4 *)(iVar11 + 0x20),
		                                Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__
		                               );
		            iVar11 = *(int *)(*(int *)(*(int *)(iVar11 + 0xc) + 0x14) + 0xc);
		            uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                              (*(undefined4 *)(iVar9 + 0x1c),0);
		            Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                      (uVar3,(uint)(iVar11 == 3),0);
		            uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                              (*(undefined4 *)(iVar9 + 0x20),0);
		            Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                      (uVar3,(uint)(iVar11 != 3),0);
		            if ((*(int *)(iVar14 + 0x1c) != 0) || (*(int *)(iVar10 + 0x1c) != 0)) {
		              System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar9 + 0x1c),0,0);
		              iVar11 = *(int *)(iVar14 + 0x1c);
		              iVar14 = *(int *)(iVar9 + 0x10);
		              Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                        (*(undefined4 *)(iVar14 + 0x34),1,0);
		              uVar3 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(iVar14 + 0x34),0);
		              local_4 = 0x3f800000;
		              local_18 = 0x3f800000;
		              local_8 = -1.0;
		              if (iVar11 == 0) {
		                local_8 = 1.0;
		              }
		              local_c = 0x3f800000;
		              local_20 = CONCAT44(local_8,0x3f800000);
		              Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition
		                        (uVar3,&local_20,0);
		              iVar10 = *(int *)(iVar10 + 0x1c);
		              iVar9 = *(int *)(iVar9 + 0x14);
		              Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                        (*(undefined4 *)(iVar9 + 0x34),1,0);
		              uVar3 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(iVar9 + 0x34),0);
		              local_4 = 0x3f800000;
		              local_28 = 0x3f800000;
		              local_8 = -1.0;
		              if (iVar10 == 0) {
		                local_8 = 1.0;
		              }
		              local_c = 0x3f800000;
		              local_30 = CONCAT44(local_8,0x3f800000);
		              Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition
		                        (uVar3,&local_30,0);
		            }
		            iVar4 = iVar4 + 1;
		          } while (iVar4 < *(int *)(iVar8 + 0xc));
		        }
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x180,&local_c);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD3")]
		[Address(RVA = "0x6E52", Offset = "0x6E52", VA = "0x6E52")]
		private void PopulateTournamentGrid()
		{
		/* --- GHIDRA: PopulateTournamentGrid ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__PopulateTournamentGrid
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a58539 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    DAT_ram_00a58539 = '\x01';
		  }
		  iVar3 = param1[2];
		  if (DAT_ram_00a5850e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		    DAT_ram_00a5850e = '\x01';
		  }
		  iVar3 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar3 + 0xc),*(undefined4 *)(iVar3 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(iVar1 + 0x50),*(undefined4 *)(param1[2] + 0x2c),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar1 + 0x54);
		  uVar2 = Gameplay_Tournaments_Model_TournamentsModel__GetPlayerStatusLocalization
		                    (param1,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0xc) + 0x14) + 0x34),param1);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x1c);
		  uVar2 = Core_Extensions_Dict_ThemeRatingKindDicExt__GetDescription(*(undefined4 *)(iVar3 + 8),0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x24);
		  uVar2 = Core_Data_Tournaments_TournamentData__Create(iVar3,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar1 + 0x58);
		  uVar2 = Core_Data_Tournaments_TournamentData__Create(iVar3,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD4")]
		[Address(RVA = "0x6E53", Offset = "0x6E53", VA = "0x6E53")]
		private void UpdateView()
		{
		/* --- GHIDRA: UpdateView ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__UpdateView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5853a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_TournamentProgressWindow_TournamentProgressWindowArgs__get_BackButton__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_Fighter___);
		    Mono_Security_ASN1__get_Item(&System_Func_Fighter__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__HandleGladiatorRole_b__44_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_WindowWhitCloseButton_TournamentProgressWindow_TournamentProgressWindowArgs__get_CloseButton__
		              );
		    DAT_ram_00a5853a = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar1 + 0x34),0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar1 + 0x38),0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (DAT_ram_00a58501 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_TournamentProgressWindow_TournamentProgressWindowArgs__get_BackButton__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_WindowWhitCloseButton_TournamentProgressWindow_TournamentProgressWindowArgs__get_CloseButton__
		              );
		    DAT_ram_00a58501 = '\x01';
		  }
		  *(undefined1 *)(iVar1 + 0x69) = 0;
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar1 + 0x38),0,0);
		  System_Linq_Enumerable__First_object_
		            (*(undefined4 *)(iVar1 + 0x34),(uint)*(byte *)(iVar1 + 0x69),0);
		  iVar1 = param1[2];
		  if (DAT_ram_00a5850e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		    DAT_ram_00a5850e = '\x01';
		  }
		  iVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar1 + 0xc),*(undefined4 *)(iVar1 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0xc) + 0x14) + 0x2c);
		  if (*(int *)(Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c_TypeInfo + 0x74)
		      == 0) {
		    func_ii_306000(Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)
		            (Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c_TypeInfo + 0x5c);
		  iVar1 = puVar3[1];
		  if (iVar1 == 0) {
		    if (*(int *)(Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c_TypeInfo + 0x74)
		        == 0) {
		      func_ii_306000(Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c_TypeInfo);
		      puVar3 = *(undefined4 **)
		                (Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c_TypeInfo + 0x5c)
		      ;
		    }
		    param2_00 = *puVar3;
		    iVar1 = unnamed_function_1417(System_Func_Fighter__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar1,param2_00,
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__HandleGladiatorRole_b__44_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c_TypeInfo +
		                     0x5c) + 4) = iVar1;
		  }
		  iVar1 = func_ii_7423(uVar2,iVar1,Method_System_Linq_Enumerable_First_Fighter___);
		  if (*(int *)(iVar1 + 0x1c) != 0) {
		    Gameplay_Tournaments_Controller_TournamentProgressViewMediator__HandleGladiatorRole
		              (param1,param1);
		    return;
		  }
		  if (DAT_ram_00a5852c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    DAT_ram_00a5852c = '\x01';
		  }
		  iVar1 = param1[2];
		  if (DAT_ram_00a5850e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		    DAT_ram_00a5850e = '\x01';
		  }
		  iVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar1 + 0xc),*(undefined4 *)(iVar1 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		  if (*(int *)(*(int *)(*(int *)(iVar1 + 0xc) + 0x14) + 0xc) == 3) {
		    Gameplay_Tournaments_Controller_TournamentProgressViewMediator__HandleLoseGladiator
		              (param1,param1);
		    return;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x2c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  Gameplay_Tournaments_Controller_TournamentProgressViewMediator__HandleWinViewer(param1,param1);
		  Gameplay_Tournaments_Controller_TournamentProgressViewMediator__UpdateBetOnPlayerForViewer
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD5")]
		[Address(RVA = "0x6E54", Offset = "0x6E54", VA = "0x6E54")]
		private void HandleGladiatorRole()
		{
		/* --- GHIDRA: HandleGladiatorRole ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__HandleGladiatorRole
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5853b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15154);
		    DAT_ram_00a5853b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (DAT_ram_00a58501 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_TournamentProgressWindow_TournamentProgressWindowArgs__get_BackButton__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_WindowWhitCloseButton_TournamentProgressWindow_TournamentProgressWindowArgs__get_CloseButton__
		              );
		    DAT_ram_00a58501 = '\x01';
		  }
		  *(undefined1 *)(iVar1 + 0x69) = 1;
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar1 + 0x38),1,0);
		  System_Linq_Enumerable__First_object_
		            (*(undefined4 *)(iVar1 + 0x34),(uint)*(byte *)(iVar1 + 0x69),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(iVar1 + 0x60),1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x28);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15154,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,param2_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD6")]
		[Address(RVA = "0x6E55", Offset = "0x6E55", VA = "0x6E55")]
		private void HandleLoseGladiator()
		{
		/* --- GHIDRA: HandleLoseGladiator ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__HandleLoseGladiator
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5853c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15171);
		    DAT_ram_00a5853c = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(iVar1 + 0x5c),1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x28);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15171,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,param2_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD7")]
		[Address(RVA = "0x6E56", Offset = "0x6E56", VA = "0x6E56")]
		private void HandleWinGladiator()
		{
		/* --- GHIDRA: HandleWinGladiator ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__HandleWinGladiator
		               (int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 in_register_20000014;
		  undefined8 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int iVar8;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5853d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_Fighter___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_First_TournamentBattleInfoListElement___);
		    Mono_Security_ASN1__get_Item(&System_Func_TournamentBattleInfoListElement__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Fighter__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass47_0__HandleViewerRole_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass47_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass47_1__HandleViewerRole_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass47_1_TypeInfo
		              );
		    DAT_ram_00a5853d = '\x01';
		  }
		  iVar3 = unnamed_function_1417
		                    (
		                    Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass47_0_TypeInfo
		                    );
		  iVar6 = param1[2];
		  if (DAT_ram_00a5850e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		    DAT_ram_00a5850e = '\x01';
		  }
		  iVar6 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar6 + 0xc),*(undefined4 *)(iVar6 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		  iVar6 = *(int *)(*(int *)(iVar6 + 0xc) + 0x14);
		  *(int *)(iVar3 + 0x10) = iVar6;
		  *(undefined8 *)(iVar3 + 8) = *(undefined8 *)(iVar6 + 0x18);
		  uVar7 = *(undefined4 *)(iVar6 + 0x2c);
		  uVar4 = unnamed_function_1417(System_Func_Fighter__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar4,iVar3,
		             Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass47_0__HandleViewerRole_b__0__
		             ,0);
		  iVar6 = System_Func_object__bool____ctor
		                    (uVar7,uVar4,Method_System_Linq_Enumerable_FirstOrDefault_Fighter___);
		  uVar2 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar2);
		  uVar4 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  iVar8 = *(int *)(*(int *)(iVar3 + 0x10) + 0xc);
		  if (DAT_ram_00a58501 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_TournamentProgressWindow_TournamentProgressWindowArgs__get_BackButton__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_WindowWhitCloseButton_TournamentProgressWindow_TournamentProgressWindowArgs__get_CloseButton__
		              );
		    DAT_ram_00a58501 = '\x01';
		  }
		  bVar1 = iVar8 != 2;
		  *(bool *)(iVar5 + 0x69) = bVar1;
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar5 + 0x38),(uint)bVar1,0);
		  System_Linq_Enumerable__First_object_
		            (*(undefined4 *)(iVar5 + 0x34),(uint)*(byte *)(iVar5 + 0x69),0);
		  if (DAT_ram_00a5852c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    DAT_ram_00a5852c = '\x01';
		  }
		  iVar5 = param1[2];
		  if (DAT_ram_00a5850e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		    DAT_ram_00a5850e = '\x01';
		  }
		  iVar5 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar5 + 0xc),*(undefined4 *)(iVar5 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		  if (*(int *)(*(int *)(*(int *)(iVar5 + 0xc) + 0x14) + 0xc) == 2) {
		    Gameplay_Tournaments_Controller_TournamentProgressViewMediator__DisplayOpponentName
		              (param1,param1);
		    return;
		  }
		  if (iVar6 == 0) {
		    Gameplay_Tournaments_Controller_TournamentProgressViewMediator__HandleViewerRole(param1,param1);
		    return;
		  }
		  if (*(int *)(iVar6 + 0x1c) != 0) {
		    Gameplay_Tournaments_Controller_TournamentProgressViewMediator__HandleNoFighter
		              (param1,*(undefined4 *)(iVar3 + 0x10),param1);
		    return;
		  }
		  iVar6 = unnamed_function_1417
		                    (
		                    Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass47_1_TypeInfo
		                    );
		  *(undefined4 *)(iVar6 + 8) = 0;
		  *(int *)(iVar6 + 0xc) = iVar3;
		  iVar3 = param1[0xb];
		  uVar7 = unnamed_function_1417(System_Func_TournamentBattleInfoListElement__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar7,iVar6,
		             Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass47_1__HandleViewerRole_b__1__
		             ,0);
		  iVar3 = func_ii_7423(iVar3,uVar7,
		                       Method_System_Linq_Enumerable_First_TournamentBattleInfoListElement___);
		  uVar7 = *(undefined4 *)(iVar3 + 0x10);
		  param2_00 = *(undefined4 *)(iVar6 + 8);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar8 = 0x14;
		  iVar5 = func_ii_3812(uVar7,param2_00,0);
		  if (iVar5 == 0) {
		    iVar8 = 0x10;
		  }
		  if (*(int *)(*(int *)(*(int *)(iVar3 + iVar8) + 0x3c) + 0x1c) != 0) {
		    Gameplay_Tournaments_Controller_TournamentProgressViewMediator__HandleLoseViewer
		              (param1,*(undefined4 *)(*(int *)(iVar6 + 0xc) + 0x10),param1);
		    return;
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(uVar4,*(undefined4 *)(*param1 + 0x15c)));
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar3 + 0x44) + 0x30),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,1,0);
		  Gameplay_Tournaments_Controller_TournamentProgressViewMediator__DisplayPageBeforeBet
		            (param1,*(undefined8 *)(*(int *)(*(int *)(iVar6 + 0xc) + 0x10) + 0x18),param1);
		  return;
		}
		*/

		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD8")]
		[Address(RVA = "0x6E57", Offset = "0x6E57", VA = "0x6E57")]
		private void HandleViewerRole()
		{
		/* --- GHIDRA: HandleViewerRole ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__HandleViewerRole
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5853e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15136);
		    DAT_ram_00a5853e = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x28);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15136,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,param2_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD9")]
		[Address(RVA = "0x6E58", Offset = "0x6E58", VA = "0x6E58")]
		private void HandleNoFighter()
		{
		/* --- GHIDRA: HandleNoFighter ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__HandleNoFighter
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined4 uVar4;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a5853f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_Fighter___);
		    Mono_Security_ASN1__get_Item(&System_Func_Fighter__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass49_0__HandleLoseViewer_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass49_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_23161);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15143);
		    DAT_ram_00a5853f = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass49_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 8) = param2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(*(int *)(iVar2 + 0x44) + 0x28);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15143,1,0,1,0,0,0,0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  param1_02 = *(undefined4 *)(*(int *)(iVar1 + 8) + 0x2c);
		  param1_01 = unnamed_function_1417(System_Func_Fighter__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_01,iVar1,
		             Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass49_0__HandleLoseViewer_b__0__
		             ,0);
		  iVar1 = func_ii_7423(param1_02,param1_01,Method_System_Linq_Enumerable_First_Fighter___);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_23161,*(undefined4 *)(*(int *)(iVar1 + 0xc) + 0x18),
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar3 = Core_GameLocalization__GetTranslation(uVar3,param1_00,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar3,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CDA")]
		[Address(RVA = "0x6E59", Offset = "0x6E59", VA = "0x6E59")]
		private void HandleLoseViewer(StateInfo stateInfo)
		{
		/* --- GHIDRA: HandleLoseViewer ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__HandleLoseViewer
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined4 uVar4;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a58540 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_Fighter___);
		    Mono_Security_ASN1__get_Item(&System_Func_Fighter__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass50_0__HandleWinViewer_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass50_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_23161);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15144);
		    DAT_ram_00a58540 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass50_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 8) = param2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(*(int *)(iVar2 + 0x44) + 0x28);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15144,1,0,1,0,0,0,0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  param1_02 = *(undefined4 *)(*(int *)(iVar1 + 8) + 0x2c);
		  param1_01 = unnamed_function_1417(System_Func_Fighter__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_01,iVar1,
		             Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass50_0__HandleWinViewer_b__0__
		             ,0);
		  iVar1 = func_ii_7423(param1_02,param1_01,Method_System_Linq_Enumerable_First_Fighter___);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_23161,*(undefined4 *)(*(int *)(iVar1 + 0xc) + 0x18),
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar3 = Core_GameLocalization__GetTranslation(uVar3,param1_00,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar3,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CDB")]
		[Address(RVA = "0x6E5A", Offset = "0x6E5A", VA = "0x6E5A")]
		private void HandleWinViewer(StateInfo stateInfo)
		{
		/* --- GHIDRA: HandleWinViewer ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__HandleWinViewer
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a58541 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_First_TournamentBattleInfoListElement___);
		    Mono_Security_ASN1__get_Item(&System_Func_TournamentBattleInfoListElement__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass51_0__DisplayOpponentName_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass51_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_25860);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15152);
		    DAT_ram_00a58541 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass51_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int **)(iVar1 + 8) = param1;
		  iVar3 = param1[0xb];
		  uVar2 = unnamed_function_1417(System_Func_TournamentBattleInfoListElement__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,iVar1,
		             Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass51_0__DisplayOpponentName_b__0__
		             ,0);
		  iVar3 = func_ii_7423(iVar3,uVar2,
		                       Method_System_Linq_Enumerable_First_TournamentBattleInfoListElement___);
		  uVar2 = *(undefined4 *)(iVar3 + 0x10);
		  uVar4 = *(undefined4 *)(iVar1 + 0xc);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar5 = 0x14;
		  iVar1 = func_ii_3812(uVar2,uVar4,0);
		  if (iVar1 == 0) {
		    iVar5 = 0x10;
		  }
		  iVar3 = *(int *)(iVar3 + iVar5);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x28);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15152,1,0,1,0,0,0,0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_25860,
		             *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x3c) + 0xc) + 0x18),
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar4 = Core_GameLocalization__GetTranslation(uVar4,param1_00,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar4,0);
		  return;
		}
		*/

		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CDC")]
		[Address(RVA = "0x6E5B", Offset = "0x6E5B", VA = "0x6E5B")]
		private void DisplayOpponentName()
		{
		/* --- GHIDRA: DisplayOpponentName ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__DisplayOpponentName
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param4;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58542 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15141);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15139);
		    DAT_ram_00a58542 = '\x01';
		  }
		  iVar3 = param1[2];
		  if (DAT_ram_00a5850e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		    DAT_ram_00a5850e = '\x01';
		  }
		  iVar3 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar3 + 0xc),*(undefined4 *)(iVar3 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x28);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15141,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x2c);
		  uVar2 = *(undefined4 *)(iVar3 + 0x14);
		  uVar5 = *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0xc) + 0x14) + 0x24);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar5 = Core_Money_Money__op_Explicit(uVar5,0);
		  param4 = Core_Money_Money__op_Explicit
		                     (*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0xc) + 0x14) + 0x28),0);
		  Gameplay_Tournaments_View_TournamentBank__Start
		            (uVar4,uVar2,uVar5,param4,*(undefined4 *)(iVar3 + 0x18),param1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar3 + 0x44) + 0x20);
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15139,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar4,0);
		  return;
		}
		*/

		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CDD")]
		[Address(RVA = "0x6E5C", Offset = "0x6E5C", VA = "0x6E5C")]
		private void DisplayPageBeforeBet()
		{
		/* --- GHIDRA: DisplayPageBeforeBet ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__DisplayPageBeforeBet
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined8 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 param3_00;
		  undefined4 param1_00;
		  int iVar6;
		  
		  uVar1 = param2;
		  if (DAT_ram_00a58543 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView__get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26152);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15133);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26104);
		    DAT_ram_00a58543 = '\x01';
		  }
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  param1_00 = *(undefined4 *)(*(int *)(iVar3 + 0x44) + 0x30);
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar5 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar3 + 0x44) + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,0,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(uVar5,*(undefined4 *)(*param1 + 0x15c)));
		  uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar3 + 0x44) + 0x2c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar5,0,0);
		  iVar3 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                    (param1[0xc],param2,
		                     Method_System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView__get_Item__
		                    );
		  iVar3 = *(int *)(iVar3 + 0x3c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar5 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15155,1,0,1,0,0,0,0);
		  uVar4 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar4,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  iVar6 = param1[2];
		  if (DAT_ram_00a5850e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		    DAT_ram_00a5850e = '\x01';
		  }
		  iVar6 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar6 + 0xc),*(undefined4 *)(iVar6 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		  uVar2 = 0x7ff80000;
		  param3_00 = Core_Extensions_Dict_ResourceSetExt__ToLocaleString
		                        (*(undefined4 *)(*(int *)(iVar6 + 0xc) + 0x28),NAN,0,StringLiteral_2556,0,0,
		                         0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar4,StringLiteral_26152,param3_00,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar4,StringLiteral_26104,*(undefined4 *)(*(int *)(iVar3 + 0xc) + 0x18),
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar5 = Core_GameLocalization__GetTranslation(uVar5,uVar4,0);
		  UI_Elements_MultilineTextList__ChangeLine(param1_00,0,uVar5,0);
		  Gameplay_Tournaments_Controller_TournamentProgressViewMediator__DisplayBetOnPlayerForViewer
		            (param1,param1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x15c)));
		  uVar4 = *(undefined4 *)(*(int *)(iVar3 + 0x44) + 0x20);
		  uVar5 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15133,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar5,0);
		  return;
		}
		*/

		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CDE")]
		[Address(RVA = "0x6E5D", Offset = "0x6E5D", VA = "0x6E5D")]
		private void DisplayBetOnPlayerForViewer(ulong userId)
		{
		/* --- GHIDRA: DisplayBetOnPlayerForViewer ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__DisplayBetOnPlayerForViewer
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  undefined4 in_register_20000014;
		  undefined8 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  double dVar7;
		  double dVar8;
		  int iVar9;
		  int iVar10;
		  undefined4 uVar11;
		  double param1_00;
		  ulonglong uVar12;
		  undefined8 local_18;
		  undefined8 local_10;
		  float8 local_8;
		  
		  if (DAT_ram_00a58544 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView__get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26152);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26061);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28645);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15160);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15161);
		    DAT_ram_00a58544 = '\x01';
		  }
		  iVar9 = param1[2];
		  if (DAT_ram_00a5850e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		    DAT_ram_00a5850e = '\x01';
		  }
		  iVar9 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar9 + 0xc),*(undefined4 *)(iVar9 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		  iVar10 = *(int *)(*(int *)(iVar9 + 0xc) + 0x14);
		  if (*(longlong *)(iVar10 + 0x18) != 0) {
		    uVar1 = CONCAT44(in_register_20000004,param1);
		    uVar2 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(uVar1,uVar2);
		    uVar11 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar5 = (undefined4)((ulonglong)uVar2 >> 0x20);
		    uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar3 + 0x44) + 0x30),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar4,1,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (CONCAT44(uVar11,param1),CONCAT44(uVar5,*(undefined4 *)(*param1 + 0x15c)));
		    uVar11 = *(undefined4 *)(*(int *)(iVar3 + 0x44) + 0x30);
		    iVar3 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                      (param1[0xc],*(undefined8 *)(iVar10 + 0x18),
		                       Method_System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView__get_Item__
		                      );
		    iVar3 = *(int *)(iVar3 + 0x3c);
		    dVar7 = func_ii_6906(*(undefined4 *)(*(int *)(iVar9 + 0xc) + 0x28),*(undefined4 *)(iVar9 + 0x18)
		                         ,0);
		    dVar8 = func_ii_6906(*(undefined4 *)(iVar3 + 0x10),*(undefined4 *)(iVar9 + 0x18),0);
		    dVar7 = dVar7 / dVar8;
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    if (dVar8 <= 0.0) {
		      dVar7 = 1.0;
		    }
		    uVar5 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15160,1,0,1,0,0,0,0);
		    uVar4 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar4,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    param1_00 = dVar7 * 100.0;
		    dVar8 = unnamed_function_4206(param1_00,&local_8);
		    if (0.0 <= param1_00) {
		      if (dVar8 == 0.5) {
		        if (ABS((double)local_8) < 9.223372036854776e+18) {
		          uVar12 = (ulonglong)(double)local_8;
		        }
		        else {
		          uVar12 = 0;
		        }
		        if ((uVar12 & 1) != 0) {
		          local_8 = (float8)((double)local_8 + 1.0);
		        }
		      }
		      else {
		        local_8 = (float8)FLOOR(param1_00 + 0.5);
		      }
		    }
		    else if (dVar8 == -0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar12 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar12 = 0;
		      }
		      if ((uVar12 & 1) != 0) {
		        local_8 = (float8)((double)local_8 + -1.0);
		      }
		    }
		    else {
		      local_8 = (float8)CEIL(param1_00 + -0.5);
		    }
		    uVar6 = func_ii_1081(DAT_ram_00a66970,&local_8);
		    uVar6 = func_ii_4419(StringLiteral_28645,uVar6,0);
		    System_Reflection_FieldInfo__get_IsStatic
		              (uVar4,StringLiteral_26061,uVar6,
		               Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    uVar5 = Core_GameLocalization__GetTranslation(uVar5,uVar4,0);
		    UI_Elements_MultilineTextList__ChangeLine(uVar11,1,uVar5,0);
		    uVar5 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15161,1,0,1,0,0,0,0);
		    uVar4 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar4,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    uVar6 = Protocol_Common_ResourceSet___ctor(*(undefined4 *)(iVar10 + 0x28),0);
		    uVar6 = Core_Extensions_Dict_ResourceSetExt__Round
		                      (uVar6,dVar7 * (double)*(float *)(param1[2] + 0x24),0);
		    uVar6 = Core_Extensions_Dict_ResourceSetExt__SetValue(uVar6,0);
		    uVar6 = Core_Extensions_Dict_ResourceSetExt__ToLocaleString
		                      (uVar6,NAN,0,StringLiteral_2556,0,0,0);
		    System_Reflection_FieldInfo__get_IsStatic
		              (uVar4,StringLiteral_26152,uVar6,
		               Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    uVar5 = Core_GameLocalization__GetTranslation(uVar5,uVar4,0);
		    local_10 = *(undefined8 *)(param1 + 8);
		    local_18 = *(undefined8 *)(param1 + 6);
		    UI_Elements_DecoratedTitle__Rebuild_d__5__System_Collections_IEnumerator_get_Current
		              (uVar11,2,uVar5,&local_18,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CDF")]
		[Address(RVA = "0x6E5E", Offset = "0x6E5E", VA = "0x6E5E")]
		private void UpdateBetOnPlayerForViewer()
		{
		/* --- GHIDRA: UpdateBetOnPlayerForViewer ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__UpdateBetOnPlayerForViewer
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined8 param2_00;
		  undefined4 param1_00;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58545 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView__get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15147);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    DAT_ram_00a58545 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c)));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x30);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1_00,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  iVar1 = param1[0xc];
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(param1[2] + 8),0);
		  iVar1 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                    (iVar1,param2_00,
		                     Method_System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView__get_Item__
		                    );
		  uVar2 = *(undefined4 *)(iVar1 + 0x3c);
		  iVar1 = param1[2];
		  if (DAT_ram_00a5850e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		    DAT_ram_00a5850e = '\x01';
		  }
		  iVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar1 + 0xc),*(undefined4 *)(iVar1 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		  iVar1 = *(int *)(*(int *)(*(int *)(iVar1 + 0xc) + 0x14) + 0x24);
		  if (iVar1 == 0) {
		    iVar1 = Utils_MoneyUtils__CalculateResource(0);
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15147,1,0,1,0,0,0,0);
		  uVar4 = Core_Extensions_Dict_ResourceSetExt__Round(iVar1,(double)*(float *)(param1[2] + 0x24),0);
		  uVar4 = Core_Extensions_Dict_ResourceSetExt__SetValue(uVar4,0);
		  uVar4 = Core_Extensions_Dict_ResourceSetExt__ToLocaleString(uVar4,NAN,0,StringLiteral_2556,0,0,0);
		  uVar3 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar3,StringLiteral_118,uVar4,0);
		  local_18 = *(undefined8 *)(param1 + 8);
		  local_20 = *(undefined8 *)(param1 + 6);
		  UI_Elements_DecoratedTitle__Rebuild_d__5__System_Collections_IEnumerator_get_Current
		            (param1_00,0,uVar3,&local_20,0);
		  uVar3 = Gameplay_Tournaments_Controller_TournamentProgressViewMediator__UpdateBetsOnPlayer
		                    (&local_40,uVar2,&local_40);
		  local_28 = *(undefined8 *)(param1 + 8);
		  local_30 = *(undefined8 *)(param1 + 6);
		  UI_Elements_DecoratedTitle__Rebuild_d__5__System_Collections_IEnumerator_get_Current
		            (param1_00,1,uVar3,&local_30,0);
		  uVar2 = Gameplay_Tournaments_Controller_TournamentProgressViewMediator__GetBetsOnFighterText
		                    (param1,uVar2,&local_40);
		  local_8 = 0x3f8000003f800000;
		  local_38 = 0x3f8000003f800000;
		  local_10 = 0x3f8000003f800000;
		  local_40 = 0x3f8000003f800000;
		  UI_Elements_DecoratedTitle__Rebuild_d__5__System_Collections_IEnumerator_get_Current
		            (param1_00,2,uVar2,&local_40,0);
		  return;
		}
		*/

		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CE0")]
		[Address(RVA = "0x6E5F", Offset = "0x6E5F", VA = "0x6E5F")]
		private void DisplayBetOnPlayerInfo()
		{
		/* --- GHIDRA: DisplayBetOnPlayerInfo ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__DisplayBetOnPlayerInfo
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  undefined8 param2_00;
		  undefined4 param1_00;
		  undefined4 param2_01;
		  
		  if (DAT_ram_00a58546 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView__get_Item__
		              );
		    DAT_ram_00a58546 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c)));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x30);
		  iVar1 = param1[0xc];
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(param1[2] + 8),0);
		  iVar1 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                    (iVar1,param2_00,
		                     Method_System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView__get_Item__
		                    );
		  param2_01 = *(undefined4 *)(iVar1 + 0x3c);
		  uVar2 = Gameplay_Tournaments_Controller_TournamentProgressViewMediator__UpdateBetsOnPlayer
		                    (param1,param2_01,param1);
		  UI_Elements_MultilineTextList__ChangeLine(param1_00,1,uVar2,0);
		  uVar2 = Gameplay_Tournaments_Controller_TournamentProgressViewMediator__GetBetsOnFighterText
		                    (param1,param2_01,param1);
		  UI_Elements_MultilineTextList__ChangeLine(param1_00,2,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CE1")]
		[Address(RVA = "0x6E60", Offset = "0x6E60", VA = "0x6E60")]
		private void UpdateBetsOnPlayer()
		{
		/* --- GHIDRA: UpdateBetsOnPlayer ---
		undefined4
		Gameplay_Tournaments_Controller_TournamentProgressViewMediator__UpdateBetsOnPlayer
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58547 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15135);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20505);
		    DAT_ram_00a58547 = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15135,1,0,1,0,0,0,0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  local_4 = *(undefined4 *)(param2 + 0x18);
		  param3_00 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_20505,param3_00,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar1 = Core_GameLocalization__GetTranslation(uVar1,param1_00,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001CE2")]
		[Address(RVA = "0x6E61", Offset = "0x6E61", VA = "0x6E61")]
		private string GetBetsOnFighterText(Fighter fighter)
		{
		/* --- GHIDRA: GetBetsOnFighterText ---
		undefined4
		Gameplay_Tournaments_Controller_TournamentProgressViewMediator__GetBetsOnFighterText
		          (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int iVar1;
		  float fVar2;
		  undefined4 uVar3;
		  double dVar4;
		  
		  if (DAT_ram_00a58548 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26152);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15148);
		    DAT_ram_00a58548 = '\x01';
		  }
		  iVar1 = param1[2];
		  if (DAT_ram_00a5850e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		    DAT_ram_00a5850e = '\x01';
		  }
		  iVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar1 + 0xc),*(undefined4 *)(iVar1 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		  dVar4 = *(double *)(*(int *)(iVar1 + 8) + 0x18);
		  fVar2 = *(float *)(param1[2] + 0x24);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c)));
		  dVar4 = dVar4 * (double)fVar2;
		  UI_Elements_MultilineTextList__ChangeLine
		            (*(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x30),2,
		             (uint)(0.0 < dVar4 * (double)*(uint *)(param2 + 0x18)),0);
		  if (*(int *)(param2 + 0x10) == 0) {
		    uVar3 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  }
		  else {
		    uVar3 = Protocol_Common_ResourceSet___ctor(*(int *)(param2 + 0x10),0);
		    uVar3 = Core_Extensions_Dict_ResourceSetExt__Round(uVar3,dVar4,0);
		    uVar3 = Core_Extensions_Dict_ResourceSetExt__Floor(uVar3,0);
		    uVar3 = Core_Extensions_Dict_ResourceSetExt__ToLocaleString
		                      (uVar3,NAN,0,StringLiteral_2556,0,0,0);
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param1_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15148,1,0,1,0,0,0,0);
		  param1_01 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_01,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_01,StringLiteral_26152,uVar3,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar3 = Core_GameLocalization__GetTranslation(param1_00,param1_01,0);
		  return uVar3;
		}
		*/

			return null;
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001CE3")]
		[Address(RVA = "0x6E62", Offset = "0x6E62", VA = "0x6E62")]
		private string GetGainForFighterText(Fighter fighter)
		{
		/* --- GHIDRA: GetGainForFighterText ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__GetGainForFighterText
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58549 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__Dispose__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TournamentPlayerBattleView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_View_BattleInfoListElementBase_TournamentPlayerBattleView__ValueTuple_Fighter__Fighter___remove_PlayerViewClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_PlayerViewClickedEventHandler__
		              );
		    DAT_ram_00a58549 = '\x01';
		  }
		  if (DAT_ram_00a5852c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    DAT_ram_00a5852c = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 8);
		  if (DAT_ram_00a5850e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		    DAT_ram_00a5850e = '\x01';
		  }
		  iVar2 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar2 + 0xc),*(undefined4 *)(iVar2 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		  if (((*(int *)(*(int *)(*(int *)(iVar2 + 0xc) + 0x14) + 0xc) == 2) &&
		      (*(int *)(param1 + 0x28) == 1)) &&
		     (iVar2 = *(int *)(param1 + 0x2c), 0 < *(int *)(iVar2 + 0xc))) {
		    iVar1 = 0;
		    do {
		      param1_01 = *(undefined4 *)(iVar2 + iVar1 * 4 + 0x10);
		      param1_00 = unnamed_function_1417(System_Action_TournamentPlayerBattleView__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (param1_00,param1,
		                 Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_PlayerViewClickedEventHandler__
		                 ,0);
		      Gameplay_BlitzTournament_View_BattleInfoListElementBase_object____Il2CppFullySharedGenericType___add_PlayerViewClickedEvent
		                (param1_01,param1_00,
		                 Method_Gameplay_BlitzTournament_View_BattleInfoListElementBase_TournamentPlayerBattleView__ValueTuple_Fighter__Fighter___remove_PlayerViewClickedEvent__
		                );
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__Dispose__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CE4")]
		[Address(RVA = "0x6E63", Offset = "0x6E63", VA = "0x6E63", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__Dispose(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5854a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c_TypeInfo);
		    DAT_ram_00a5854a = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c_TypeInfo);
		  **(undefined4 **)
		    (Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04000FB2 RID: 4018
		[Token(Token = "0x4000FB2")]
		private const string LOCALIZATION_GLADIATOR_ANNOTATION = "TOURNAMENTS/GLADIATOR_ANNOTATION";

		// Token: 0x04000FB3 RID: 4019
		[Token(Token = "0x4000FB3")]
		private const string LOCALIZATION_FOR_VICTORY = "TOURNAMENTS/FOR_VICTORY";

		// Token: 0x04000FB4 RID: 4020
		[Token(Token = "0x4000FB4")]
		private const string LOCALIZATION_BETS_ON_VICTORY = "TOURNAMENTS/BETS_ON_VICTORY";

		// Token: 0x04000FB5 RID: 4021
		[Token(Token = "0x4000FB5")]
		private const string LOCALIZATION_GAIN_INCREASE = "TOURNAMENTS/GAIN_INCREASE";

		// Token: 0x04000FB6 RID: 4022
		[Token(Token = "0x4000FB6")]
		private const string LOCALIZATION_MADE_BET = "TOURNAMENTS/MADE_BET";

		// Token: 0x04000FB7 RID: 4023
		[Token(Token = "0x4000FB7")]
		private const string LOCALIZATION_PLAYER_BET_PERCENTAGE = "TOURNAMENTS/PLAYER_BET_PERCENTAGE";

		// Token: 0x04000FB8 RID: 4024
		[Token(Token = "0x4000FB8")]
		private const string LOCALIZATION_POSSIBLE_GAIN = "TOURNAMENTS/POSSIBLE_GAIN";

		// Token: 0x04000FB9 RID: 4025
		[Token(Token = "0x4000FB9")]
		private const string LOCALIZATION_ARENA_LEVEL_ANNOTATION = "TOURNAMENTS/ARENA_LEVEL_ANNOTATION";

		// Token: 0x04000FBA RID: 4026
		[Token(Token = "0x4000FBA")]
		private const string LOCALIZATION_BET_WARNING = "TOURNAMENTS/BET_WARNING";

		// Token: 0x04000FBB RID: 4027
		[Token(Token = "0x4000FBB")]
		private const string LOCALIZATION_CHOOSE_BET_ANNOTATION = "TOURNAMENTS/CHOOSE_BET_ANNOTATION";

		// Token: 0x04000FBC RID: 4028
		[Token(Token = "0x4000FBC")]
		private const string LOCALIZATION_LOSE_ANNOTATION = "TOURNAMENTS/LOSE_ANNOTATION";

		// Token: 0x04000FBD RID: 4029
		[Token(Token = "0x4000FBD")]
		private const string LOCALIZATION_WIN_ANNOTATION = "TOURNAMENTS/WIN_ANNOTATION";

		// Token: 0x04000FBE RID: 4030
		[Token(Token = "0x4000FBE")]
		private const string LOCALIZATION_FIGHTER_LOST_ANNOTATION = "TOURNAMENTS/FIGHTER_LOST_ANNOTATION";

		// Token: 0x04000FBF RID: 4031
		[Token(Token = "0x4000FBF")]
		private const string LOCALIZATION_FIGHTER_WON_ANNOTATION = "TOURNAMENTS/FIGHTER_WON_ANNOTATION";

		// Token: 0x04000FC0 RID: 4032
		[Token(Token = "0x4000FC0")]
		private const string LOCALIZATION_BET_BURNED = "TOURNAMENTS/BET_BURNED";

		// Token: 0x04000FC1 RID: 4033
		[Token(Token = "0x4000FC1")]
		private const int TO_PERCENT = 100;

		// Token: 0x04000FC2 RID: 4034
		[Token(Token = "0x4000FC2")]
		[FieldOffset(Offset = "0x18")]
		private readonly Color _color;

		// Token: 0x04000FC3 RID: 4035
		[Token(Token = "0x4000FC3")]
		[FieldOffset(Offset = "0x28")]
		private UserTNMStatus _playerStatus;

		// Token: 0x04000FC4 RID: 4036
		[Token(Token = "0x4000FC4")]
		[FieldOffset(Offset = "0x2C")]
		private TournamentBattleInfoListElement[] _listElements;

		// Token: 0x04000FC5 RID: 4037
		[Token(Token = "0x4000FC5")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<ulong, TournamentPlayerBattleView> _playerViewsById;

		// Token: 0x04000FC6 RID: 4038
		[Token(Token = "0x4000FC6")]
		[FieldOffset(Offset = "0x34")]
		private TournamentPlayerBattleView _selectedPlayer;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get__currentState ---
		uint Gameplay_Tournaments_Controller_TournamentProgressViewMediator__get__currentState
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  
		  if (DAT_ram_00a5852c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    DAT_ram_00a5852c = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 8);
		  if (DAT_ram_00a5850e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		    DAT_ram_00a5850e = '\x01';
		  }
		  iVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar1 + 0xc),*(undefined4 *)(iVar1 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		  if (*(int *)(*(int *)(*(int *)(iVar1 + 0xc) + 0x14) + 0xc) == 2) {
		    uVar2 = (uint)(*(int *)(param1 + 0x28) == 1);
		  }
		  else {
		    uVar2 = 0;
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get__selectable ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__get__selectable
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5852d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_RulesButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5852d = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x40) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_RulesButtonClickHandler__
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
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x40) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_RulesButtonClickHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_Tabs_TabBar__HandleSelected
		              (*(undefined4 *)(iVar2 + 0x3c),*(undefined4 *)(param1[2] + 0x30),0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		              (*(undefined4 *)(iVar2 + 0x3c),0,0,0);
		    Gameplay_Tournaments_Controller_TournamentProgressViewMediator__set_Controller(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5852e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoHealtChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoStateChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBetChangedOnPlayerEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_BetChangedOnPlayerEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_BetOnPlayerEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_CurrentCombatCompleteEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_HealthChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_StateChangedEventHandler__
		              );
		    DAT_ram_00a5852e = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x30);
		    uVar2 = unnamed_function_1417(System_Action_ProtoHealtChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_HealthChangedEventHandler__
		               ,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_ProtoHealtChangedEvt__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x30) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ProtoHealtChangedEvt__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x30) = iVar4;
		      uVar2 = System_Action_ProtoHealtChangedEvt__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ProtoHealtChangedEvt__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x2c);
		    uVar2 = unnamed_function_1417(System_Action_ProtoBetChangedOnPlayerEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_BetChangedOnPlayerEventHandler__
		               ,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_ProtoBetChangedOnPlayerEvt__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x2c) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ProtoBetChangedOnPlayerEvt__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x2c) = iVar4;
		      uVar2 = System_Action_ProtoBetChangedOnPlayerEvt__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ProtoBetChangedOnPlayerEvt__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		    func_ii_6877(uVar2,param1,
		                 Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_BetOnPlayerEventHandler__
		                 ,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_ulong__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x1c) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ulong__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x1c) = iVar4;
		      uVar2 = System_Action_ulong__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ulong__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x34);
		    uVar2 = unnamed_function_1417(System_Action_ProtoStateChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_StateChangedEventHandler__
		               ,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_ProtoStateChangedEvt__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x34) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ProtoStateChangedEvt__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x34) = iVar4;
		      uVar2 = System_Action_ProtoStateChangedEvt__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ProtoStateChangedEvt__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x38);
		    uVar2 = unnamed_function_1417(System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_CurrentCombatCompleteEventHandler__
		               ,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x38) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x38) = iVar4;
		      uVar2 = System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x30);
		    uVar2 = unnamed_function_1417(System_Action_ProtoHealtChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_HealthChangedEventHandler__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_ProtoHealtChangedEvt__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x30) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ProtoHealtChangedEvt__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x30) = iVar4;
		      uVar2 = System_Action_ProtoHealtChangedEvt__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ProtoHealtChangedEvt__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x2c);
		    uVar2 = unnamed_function_1417(System_Action_ProtoBetChangedOnPlayerEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_BetChangedOnPlayerEventHandler__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_ProtoBetChangedOnPlayerEvt__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x2c) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ProtoBetChangedOnPlayerEvt__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x2c) = iVar4;
		      uVar2 = System_Action_ProtoBetChangedOnPlayerEvt__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ProtoBetChangedOnPlayerEvt__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		    func_ii_6877(uVar2,param1,
		                 Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_BetOnPlayerEventHandler__
		                 ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_ulong__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x1c) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ulong__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x1c) = iVar4;
		      uVar2 = System_Action_ulong__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ulong__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x34);
		    uVar2 = unnamed_function_1417(System_Action_ProtoStateChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_StateChangedEventHandler__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_ProtoStateChangedEvt__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x34) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ProtoStateChangedEvt__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x34) = iVar4;
		      uVar2 = System_Action_ProtoStateChangedEvt__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ProtoStateChangedEvt__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x38);
		    uVar2 = unnamed_function_1417(System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator_CurrentCombatCompleteEventHandler__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x38) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar3,System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x38) = iVar4;
		    uVar2 = System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__set_Events
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5852f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_TournamentBattleInfoListElement___);
		    Mono_Security_ASN1__get_Item(&System_Func_TournamentBattleInfoListElement__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass30_0__CurrentCombatCompleteEventHandler_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass30_0_TypeInfo
		              );
		    DAT_ram_00a5852f = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass30_0_TypeInfo
		                    );
		  *(int *)(iVar1 + 8) = param2;
		  if (*(int *)(param2 + 0xc) == *(int *)(*(int *)(param1 + 8) + 0x20)) {
		    param1_00 = *(undefined4 *)(param1 + 0x2c);
		    uVar2 = unnamed_function_1417(System_Func_TournamentBattleInfoListElement__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar2,iVar1,
		               Method_Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass30_0__CurrentCombatCompleteEventHandler_b__0__
		               ,0);
		    iVar3 = System_Func_object__bool____ctor
		                      (param1_00,uVar2,
		                       Method_System_Linq_Enumerable_FirstOrDefault_TournamentBattleInfoListElement___
		                      );
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar4 = func_ii_3812(iVar3,0,0);
		    if (iVar4 == 0) {
		      System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar3 + 0x1c),0,0);
		      iVar3 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                        (*(undefined4 *)(param1 + 0x30),*(undefined8 *)(*(int *)(iVar1 + 8) + 0x18),
		                         Method_System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView__get_Item__
		                        );
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(iVar3 + 0x34),1,0);
		      uVar2 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(iVar3 + 0x34),0);
		      local_4 = 0x3f800000;
		      local_10 = 0x3f800000;
		      local_c = 0xbf8000003f800000;
		      local_18 = 0xbf8000003f800000;
		      Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar2,&local_18,0);
		      iVar1 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                        (*(undefined4 *)(param1 + 0x30),*(undefined8 *)(*(int *)(iVar1 + 8) + 0x10),
		                         Method_System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView__get_Item__
		                        );
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(iVar1 + 0x34),1,0);
		      uVar2 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(iVar1 + 0x34),0);
		      local_4 = 0x3f800000;
		      local_20 = 0x3f800000;
		      local_c = 0x3f8000003f800000;
		      local_28 = 0x3f8000003f800000;
		      Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar2,&local_28,0);
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Controller ---
		void Gameplay_Tournaments_Controller_TournamentProgressViewMediator__set_Controller
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58531 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_TournamentProgressInfoBox_State__set_CurrentState__
		              );
		    DAT_ram_00a58531 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x44);
		  iVar1 = param1[2];
		  if (DAT_ram_00a5850e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		    DAT_ram_00a5850e = '\x01';
		  }
		  iVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar1 + 0xc),*(undefined4 *)(iVar1 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1_00,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0xc) + 0x14) + 0xc),
		             Method_UI_MonoBehaviourWithStates_TournamentProgressInfoBox_State__set_CurrentState__);
		  Gameplay_Tournaments_Controller_TournamentProgressViewMediator__PopulateTournamentGrid
		            (param1,param1);
		  Gameplay_Tournaments_Controller_TournamentProgressViewMediator__DeterminePlayerRole(param1,param1)
		  ;
		  Gameplay_Tournaments_Controller_TournamentProgressViewMediator__HealthChangedEventHandler
		            (param1,param1);
		  if (param1[10] == 2) {
		    Gameplay_Tournaments_Controller_TournamentProgressViewMediator__UpdateView(param1,param1);
		    return;
		  }
		  Gameplay_Tournaments_Controller_TournamentProgressViewMediator__HandleWinGladiator(param1,param1);
		  return;
		}
		*/

}
