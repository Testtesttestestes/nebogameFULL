using System;
using Gameplay.ArenaCombat.Model;
using Gameplay.Combat.Control;
using Gameplay.Combat.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Combat;
using ServicesNamespace;
using Utils;

namespace Gameplay.ArenaCombat.Control
{
	// Token: 0x02000D4A RID: 3402
	[Token(Token = "0x2000D4A")]
	public class ArenaCombatController : CombatController<ArenaCombatModel, ArenaCombatEvents>
	{
		// Token: 0x06005350 RID: 21328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005350")]
		[Address(RVA = "0xA10F", Offset = "0xA10F", VA = "0xA10F")]
		public ArenaCombatController(ICombatService service, ArenaCombatModel model, ArenaCombatEvents events, MainService mainService)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ArenaCombat_Control_ArenaCombatController___ctor(int *param1,undefined4 param2)
		
		{
		  undefined8 in_i2q;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  undefined4 param4;
		  int iVar7;
		  int iVar8;
		  undefined8 local_38;
		  int local_30;
		  undefined8 *local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  uVar5 = (undefined4)((ulonglong)in_i2q >> 0x20);
		  if (DAT_ram_00a593d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArenaCombat_Control_ArenaCombatController_HandleGetOtherUserStatsService__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_CombatScope_CombatEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_ulong__CombatPlayer__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_ulong__CombatPlayer__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_ulong__CombatPlayer__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_ulong__CombatPlayer__get_Value__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a593d5 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  iVar1 = System_Uri___ctor(0);
		  iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x2c) + 8);
		  if (iVar1 != 0) {
		    uVar3 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar4 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param4 = *(undefined4 *)(*(int *)(iVar2 + 0xc) + 0xc);
		    iVar2 = unnamed_function_1417(Core_Events_Scopes_CombatScope_CombatEventArgs_TypeInfo);
		    Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(iVar2,uVar3,uVar4,param4,0);
		    iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(iVar2 + 0x14) = *(undefined4 *)(iVar7 + 0x60);
		    iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(iVar2 + 0x18) = *(undefined4 *)(iVar7 + 0x5c);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),iVar2,CONCAT44(uVar5,*(undefined4 *)(iVar1 + 0x14)));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  System_Collections_Generic_Dictionary_ulong__ulong___FindEntry
		            (&local_28,*(undefined4 *)(iVar1 + 0x1c),
		             Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__GetEnumerator__);
		  local_30 = 0;
		  local_2c = &local_28;
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2d5,&local_28,
		                         Method_System_Collections_Generic_Dictionary_Enumerator_ulong__CombatPlayer__MoveNext__
		                        );
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ffad5c;
		      }
		      if (iVar2 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      iVar7 = *(int *)((int)local_10 + 8);
		      iVar8 = *(int *)(iVar7 + 0x14);
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ffad5c;
		      }
		    } while ((iVar8 == *(int *)(*(int *)(iVar2 + 0xc) + 0x2c)) || (*(int *)(iVar7 + 0x10) != 1));
		    DAT_ram_009d3e38 = 0;
		    uVar5 = unnamed_function_184070
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x29e,param1[8],
		                       *(undefined8 *)(*(int *)(iVar7 + 0xc) + 0x10),0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ffad5c;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_OpToken_IMessage__object___TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ffad22:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ffad5c;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar3,param1,
		               Method_Gameplay_ArenaCombat_Control_ArenaCombatController_HandleGetOtherUserStatsService__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ffad22;
		    local_38 = *(undefined8 *)(*(int *)(iVar7 + 0xc) + 0x10);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a66968,
		                       &local_38);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ffad5c;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iiiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x29f,uVar5,uVar3,uVar4,
		                       Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ffad5c;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x327,param1,uVar5,0)
		    ;
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ffad5c:
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar2 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_30 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar2 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2a0,&local_30);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(uVar5);
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
		*/

		}

		// Token: 0x06005351 RID: 21329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005351")]
		[Address(RVA = "0xA110", Offset = "0xA110", VA = "0xA110", Slot = "18")]
		protected override void HandleJoinToCombatInfoChanged()
		{
		/* --- GHIDRA: HandleJoinToCombatInfoChanged ---
		void Gameplay_ArenaCombat_Control_ArenaCombatController__HandleJoinToCombatInfoChanged
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  undefined8 *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *param1_00;
		  int *param1_01;
		  undefined8 param2_00;
		  
		  if (DAT_ram_00a593d6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__Update__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetUserStatsAns_TypeInfo);
		    DAT_ram_00a593d6 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Main_ProtoGetUserStatsAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoGetUserStatsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_01 = *(int **)(param2 + 0xc);
		  if (param1_01 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*param1_01 + 0x20) == *(int *)(DAT_ram_00a66968 + 0x20)) {
		    puVar3 = (undefined8 *)func_ii_15774(param1_01);
		    param2_00 = *puVar3;
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		    uVar1 = param2_00;
		    iVar4 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                      (*(undefined4 *)(iVar4 + 0x1c),param2_00,
		                       Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Item__)
		    ;
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar5 = Core_Gameplay_Managers_UserManager__get_User(*(undefined4 *)(iVar4 + 0x14),0);
		    Utils_Accumulators_AccumulatorBase_int__object___RunTimer
		              (uVar5,param1_00[3],
		               Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__Update__);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104)));
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = param2_00;
		    iVar6 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                      (*(undefined4 *)(iVar6 + 0x1c),param2_00,
		                       Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Item__)
		    ;
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    if (DAT_ram_00a593cf == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__AddRange__
		                );
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__Clear__
		                );
		      DAT_ram_00a593cf = '\x01';
		    }
		    uVar5 = 1;
		    if ((*(int *)(*(int *)(iVar4 + 0xc) + 0x2c) == *(int *)(*(int *)(iVar6 + 8) + 0x14)) &&
		       (uVar5 = 3, *(int *)(iVar4 + 0x5c) == 0)) {
		      uVar5 = 2;
		    }
		    uVar5 = Gameplay_Antiq_Model_AntiqModel__TryGetEffectValue
		                      (*(undefined4 *)(iVar6 + 0x14),*(undefined4 *)(*(int *)(iVar4 + 0xc) + 0xc),
		                       uVar5,param1);
		    iVar4 = *(int *)(iVar6 + 0x18);
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		    System_Collections_Generic_List_Int32Enum___AddEnumerable
		              (iVar4,uVar5,
		               Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__AddRange__
		              );
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x114)));
		    iVar4 = *(int *)(iVar4 + 0x3c);
		    if (iVar4 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                (*(undefined4 *)(iVar4 + 0x20),param2_00,*(undefined4 *)(iVar4 + 0x14));
		    }
		    return;
		  }
		  System_Activator__CreateInstance(param1_01,DAT_ram_00a66968);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005352 RID: 21330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005352")]
		[Address(RVA = "0xA111", Offset = "0xA111", VA = "0xA111")]
		private void HandleGetOtherUserStatsService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetOtherUserStatsService ---
		void Gameplay_ArenaCombat_Control_ArenaCombatController__HandleGetOtherUserStatsService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  byte bVar1;
		  int iVar2;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar3;
		  undefined4 param4;
		  undefined4 param3_00;
		  undefined8 param5;
		  
		  if (DAT_ram_00a593d7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_CombatScope_CombatFinishedEventArgs_TypeInfo);
		    DAT_ram_00a593d7 = '\x01';
		  }
		  iVar2 = System_Uri___ctor(0);
		  iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x2c) + 0xc);
		  if (iVar2 != 0) {
		    param2_00 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    bVar1 = *(byte *)(param2 + 8);
		    param5 = *(undefined8 *)(param2 + 0x10);
		    param4 = *(undefined4 *)(param2 + 0x1c);
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    param1_00 = unnamed_function_1417
		                          (Core_Events_Scopes_CombatScope_CombatFinishedEventArgs_TypeInfo);
		    Core_Events_Scopes_CombatScope_CombatFinishedEventArgs__get_IsWin
		              (param1_00,param2_00,param3_00,param4,param5,(uint)bVar1,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(param1_00 + 0x14) = *(undefined4 *)(iVar3 + 0x60);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(param1_00 + 0x18) = *(undefined4 *)(iVar3 + 0x5c);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1_00,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005353 RID: 21331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005353")]
		[Address(RVA = "0xA112", Offset = "0xA112", VA = "0xA112", Slot = "23")]
		protected override void HandleGameOverInfoChanged(GameOverData gameOverData)
		{
		/* --- GHIDRA: HandleGameOverInfoChanged ---
		void Gameplay_ArenaCombat_Control_ArenaCombatController__HandleGameOverInfoChanged
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined8 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  int *param1_00;
		  int iVar7;
		  
		  if (DAT_ram_00a593d8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArenaCombat_Control_ArenaCombatController_HandleAttackMonsterServiceRequest__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ArenaCombatModel__ArenaCombatEvents__HandleRun__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ArenaCombatModel__ArenaCombatEvents__StartAwaitJumpToCombatEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_WorldService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a593d8 = '\x01';
		  }
		  Gameplay_Combat_Control_CombatController_object__object___HandleRewardsGot
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_ArenaCombatModel__ArenaCombatEvents__HandleRun__
		            );
		  uVar2 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar2);
		  uVar6 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  if (*(int *)(iVar3 + 0x5c) == 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x104)));
		    iVar7 = *(int *)(iVar3 + 0x40);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (iVar7 != 0) {
		      (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                (param1,*(undefined4 *)(iVar3 + 0x40),*(undefined4 *)(*param1 + 0x14c));
		      return;
		    }
		    Gameplay_ArenaCombat_Control_ArenaCombatController__HandleAttackMonsterServiceRequest
		              (param1,*(undefined4 *)(*(int *)(iVar3 + 0x60) + 8),0);
		    return;
		  }
		  Gameplay_Combat_Control_CombatController_object__object___SpellCalled
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_ArenaCombatModel__ArenaCombatEvents__StartAwaitJumpToCombatEvent__
		            );
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar4 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_WorldService___);
		  uVar2 = CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar2);
		  uVar6 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  iVar3 = *(int *)(iVar3 + 0x5c);
		  if (DAT_ram_00a593d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_User_IMonsterSource_TypeInfo);
		    DAT_ram_00a593d0 = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = *(int **)(iVar3 + 0xc);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Isles_User_IMonsterSource_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80ffb240;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_00,Gameplay_Isles_User_IMonsterSource_TypeInfo,0);
		code_r0x80ffb240:
		  uVar2 = (**(code **)((ulonglong)*puVar5 * 4))(param1_00,CONCAT44(uVar6,puVar5[1]));
		  uVar6 = ServicesNamespace_WorldService__GetUserIsleInfo(uVar4,uVar2,0);
		  uVar4 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_ArenaCombat_Control_ArenaCombatController_HandleAttackMonsterServiceRequest__
		             ,0);
		  uVar6 = ServicesNamespace_MainService__GetUserStats
		                    (uVar6,uVar4,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar6,0);
		  return;
		}
		*/

		}

		// Token: 0x06005354 RID: 21332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005354")]
		[Address(RVA = "0xA113", Offset = "0xA113", VA = "0xA113", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_ArenaCombat_Control_ArenaCombatController__HandleRun
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  int iVar3;
		  undefined4 param4;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a593d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_CombatScope_AttackMonsterEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedCombatBillingErrors__ExpectedArenaWhitMonsterErrors__ExpectedArenaCombatErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoRequestCombatAns_TypeInfo);
		    DAT_ram_00a593d9 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = *(undefined4 *)(iVar1 + 0x50);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Combat_ProtoRequestCombatAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Combat_ProtoRequestCombatAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar3 = param1_00[3];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar4 = *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x14);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar5 = *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x14);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object__object_
		                    (iVar3,uVar4,uVar5,*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x14),
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedCombatBillingErrors__ExpectedArenaWhitMonsterErrors__ExpectedArenaCombatErrors___
		                    );
		  if (iVar1 != 0) {
		    uVar4 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    DefaultNamespace_SceneAppManager__RemoveScene(uVar4,uVar2,0);
		    return;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x5c) != 0) {
		    iVar1 = System_Uri___ctor(0);
		    iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x2c) + 0x10);
		    if (iVar1 != 0) {
		      uVar2 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      uVar5 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param4 = *(undefined4 *)(iVar3 + 0x5c);
		      uVar4 = unnamed_function_1417(Core_Events_Scopes_CombatScope_AttackMonsterEventArgs_TypeInfo);
		      Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(uVar4,uVar2,uVar5,param4,0);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),uVar4,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005355 RID: 21333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005355")]
		[Address(RVA = "0xA114", Offset = "0xA114", VA = "0xA114")]
		private void HandleAttackMonsterServiceRequest(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleAttackMonsterServiceRequest ---
		void Gameplay_ArenaCombat_Control_ArenaCombatController__HandleAttackMonsterServiceRequest
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar4;
		  
		  if (DAT_ram_00a593da == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArenaCombat_Control_ArenaCombatController_HandlePutJoinServiceRequest__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ArenaCombatModel__ArenaCombatEvents__get_CombatService__
		              );
		    Mono_Security_ASN1__get_Item(&ServicesNamespace_ICombatService_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a593da = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0x18);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (ServicesNamespace_ICombatService_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1d0);
		        goto code_r0x80ffb3ae;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,ServicesNamespace_ICombatService_TypeInfo,0x22);
		code_r0x80ffb3ae:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,param2,0,puVar2[1]);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_ArenaCombat_Control_ArenaCombatController_HandlePutJoinServiceRequest__
		             ,0);
		  uVar3 = ServicesNamespace_MainService__GetUserStats
		                    (uVar3,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x06005356 RID: 21334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005356")]
		[Address(RVA = "0xA115", Offset = "0xA115", VA = "0xA115")]
		private void RequestPutJoinRequest(ProtoRequestCombatCmd.Types.ArenaCombatTypes type)
		{
		/* --- GHIDRA: RequestPutJoinRequest ---
		void Gameplay_ArenaCombat_Control_ArenaCombatController__RequestPutJoinRequest
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 uVar1;
		  int iVar2;
		  float param2_00;
		  int *param1_00;
		  int param1_01;
		  undefined8 uVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a593db == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedCombatBillingErrors__ExpectedArenaCombatErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoRequestCombatAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a593db = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Combat_ProtoRequestCombatAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Combat_ProtoRequestCombatAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_01 = param1_00[3];
		  uVar3 = CONCAT44(in_register_20000004,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (uVar3,*(undefined4 *)(*param1 + 0x104));
		  uVar4 = *(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x14);
		  uVar3 = CONCAT44((int)((ulonglong)uVar3 >> 0x20),param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (uVar3,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  iVar2 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (param1_01,uVar4,*(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x14),
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedCombatBillingErrors__ExpectedArenaCombatErrors___
		                    );
		  if (iVar2 == 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (CONCAT44(uVar1,param1),*(undefined4 *)(*param1 + 0x104));
		    uVar3 = *(undefined8 *)(param1_00 + 4);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    param2_00 = Utils_StringUtils___cctor(uVar3,0);
		    uVar1 = (undefined4)((ulonglong)uVar3 >> 0x20);
		    uVar4 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar4,param2_00,0);
		    *(undefined4 *)(iVar2 + 0x40) = uVar4;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (CONCAT44(uVar1,param1),*(undefined4 *)(*param1 + 0x104));
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		              (param1,*(undefined4 *)(iVar2 + 0x40),*(undefined4 *)(*param1 + 0x14c));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005357 RID: 21335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005357")]
		[Address(RVA = "0xA116", Offset = "0xA116", VA = "0xA116")]
		private void HandlePutJoinServiceRequest(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandlePutJoinServiceRequest ---
		void Gameplay_ArenaCombat_Control_ArenaCombatController__HandlePutJoinServiceRequest
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a593dc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController___ctor__
		              );
		    DAT_ram_00a593dc = '\x01';
		  }
		  HuaweiMobileServices_Base_OnSuccessListener___Il2CppFullySharedGenericType___onSuccess
		            (param1,param2,param3,param4,
		             Method_Gameplay_Combat_Control_OneOnOneCombatViewMediator_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04002D25 RID: 11557
		[Token(Token = "0x4002D25")]
		[FieldOffset(Offset = "0x20")]
		private MainService _mainService;
	}
}
