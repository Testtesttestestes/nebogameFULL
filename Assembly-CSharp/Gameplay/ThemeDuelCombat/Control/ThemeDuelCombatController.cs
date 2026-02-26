using System;
using System.Collections.Generic;
using Gameplay.ArenaCombat;
using Gameplay.Combat.Control;
using Gameplay.Combat.Model;
using Gameplay.ThemeDuelCombat.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Themeduel;
using ServicesNamespace;
using Utils;

namespace Gameplay.ThemeDuelCombat.Control
{
	// Token: 0x020004D9 RID: 1241
	[Token(Token = "0x20004D9")]
	public class ThemeDuelCombatController : CombatController<ThemeDuelCombatModel, ThemeDuelCombatEvents>
	{
		// Token: 0x06001D84 RID: 7556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D84")]
		[Address(RVA = "0x6F03", Offset = "0x6F03", VA = "0x6F03")]
		public ThemeDuelCombatController(ICombatService service, ThemeDuelCombatModel model, ThemeDuelCombatEvents events, ThemeDuelCombatEventStatisticsObserver combatEventObserver)
		{
		/* --- GHIDRA: <HandleGameOverInfoChanged>b__14_0 ---
		void Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController___HandleGameOverInfoChanged_b__14_0
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a585af == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView___ctor__
		              );
		    DAT_ram_00a585af = '\x01';
		  }
		  HuaweiMobileServices_Drive_AbstractJsonClientRequest___Il2CppFullySharedGenericType____ctor
		            (param1,param2,param3,param4,
		             Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatView___ctor__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: <HandleJoinToCombatInfoChanged>b__13_0 ---
		uint Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController___HandleJoinToCombatInfoChanged_b__13_0
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  undefined4 param1_00;
		  longlong lVar2;
		  longlong lVar3;
		  
		  lVar2 = Core_Data_UserData__get_UserId(param2,0);
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x100) * 4))
		                        (piVar1,*(undefined4 *)(*piVar1 + 0x104));
		  lVar3 = Core_Data_UserData__get_UserId(param1_00,0);
		  return (uint)(lVar2 != lVar3);
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController___ctor
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != 0) {
		    *(int *)(param1 + 0x34) = *(int *)(param1 + 0x34) + 1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D85")]
		[Address(RVA = "0x6F04", Offset = "0x6F04", VA = "0x6F04")]
		private void OnTurn(bool isPlayerStep)
		{
		/* --- GHIDRA: OnTurn ---
		void Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController__OnTurn
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a585a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_long__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ThemeDuelCombatModel__ThemeDuelCombatEvents__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ThemeDuelCombatEvents__remove_OnTurn__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_OnScoreChanged__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_OnTurn__);
		    DAT_ram_00a585a3 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x40);
		  uVar1 = unnamed_function_1417(System_Action_long__TypeInfo);
		  System_Action_Int32Enum___Invoke
		            (uVar1,param1,
		             Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_OnScoreChanged__,0);
		  Gameplay_ArenaCombat_ThemeDuelCombatEventStatisticsObserver__add_OnScoreChanged(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x40);
		  uVar1 = unnamed_function_1417(System_Action_bool__TypeInfo);
		  System_Action_AsyncGPUReadbackRequest___Invoke
		            (uVar1,param1,Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_OnTurn__
		             ,0);
		  Gameplay_ArenaCombat_CombatEventStatisticsObserver_object___remove_OnMatchStones
		            (uVar2,uVar1,
		             Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ThemeDuelCombatEvents__remove_OnTurn__
		            );
		  Gameplay_Combat_Control_CombatController_object__object___CompleteQueueCallback
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_ThemeDuelCombatModel__ThemeDuelCombatEvents__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D86")]
		[Address(RVA = "0x6F05", Offset = "0x6F05", VA = "0x6F05", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController__Dispose
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param2_00;
		  undefined8 uVar2;
		  int local_4;
		  
		  if (DAT_ram_00a585a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_int__int__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__int__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_int__int__set_Item__)
		    ;
		    DAT_ram_00a585a4 = '\x01';
		  }
		  local_4 = 0;
		  uVar2 = *(undefined8 *)(param1 + 0x28);
		  *(undefined8 *)(param1 + 0x28) = param2;
		  param2_00 = (int)param2 - (int)uVar2;
		  if (0 < param2_00) {
		    iVar1 = System_Collections_Generic_List_Enumerator_int___MoveNext
		                      (*(undefined4 *)(param1 + 0x44),param2_00,&local_4,
		                       Method_System_Collections_Generic_Dictionary_int__int__TryGetValue__);
		    if (iVar1 == 0) {
		      func_ii_19535(*(undefined4 *)(param1 + 0x44),param2_00,1,
		                    Method_System_Collections_Generic_Dictionary_int__int__Add__);
		    }
		    else {
		      System_Collections_Generic_Dictionary_int__int___get_Values
		                (*(undefined4 *)(param1 + 0x44),param2_00,local_4 + 1,
		                 Method_System_Collections_Generic_Dictionary_int__int__set_Item__);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D87")]
		[Address(RVA = "0x6F06", Offset = "0x6F06", VA = "0x6F06")]
		private void OnScoreChanged(long score)
		{
		/* --- GHIDRA: OnScoreChanged ---
		void Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController__OnScoreChanged
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  uint *puVar3;
		  int iVar4;
		  int *param1_01;
		  
		  if (DAT_ram_00a585a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ThemeDuelCombatModel__ThemeDuelCombatEvents__HandleRun__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ThemeDuelCombatModel__ThemeDuelCombatEvents__get_CombatService__
		              );
		    Mono_Security_ASN1__get_Item(&ServicesNamespace_ICombatService_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_HandleThemeScoreChangedEvt__
		              );
		    DAT_ram_00a585a5 = '\x01';
		  }
		  Gameplay_Combat_Control_CombatController_object__object___HandleRewardsGot
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_ThemeDuelCombatModel__ThemeDuelCombatEvents__HandleRun__
		            );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar4 = *(int *)(iVar2 + 0x40);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (iVar4 == 0) {
		    Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController__HandleGameOverInfoChanged
		              (param1,*(undefined4 *)(iVar2 + 0x5c),0);
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		              (param1,*(undefined4 *)(iVar2 + 0x40),*(undefined4 *)(*param1 + 0x14c));
		  }
		  param1_01 = (int *)param1[6];
		  uVar1 = 0;
		  param1_00 = unnamed_function_1417(System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_HandleThemeScoreChangedEvt__
		             ,0);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (ServicesNamespace_ICombatService_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8))
		      {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x1b0);
		        goto code_r0x80f0b4b1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,ServicesNamespace_ICombatService_TypeInfo,0x1e);
		code_r0x80f0b4b1:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_01,param1_00,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D88")]
		[Address(RVA = "0x6F07", Offset = "0x6F07", VA = "0x6F07", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController__HandleRun
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined8 uVar5;
		  undefined8 param6;
		  int *piVar6;
		  int iVar7;
		  int iVar8;
		  int iVar9;
		  undefined4 param3;
		  longlong lVar10;
		  undefined8 param5;
		  longlong param15;
		  longlong param14;
		  longlong param13;
		  longlong param11;
		  longlong param10;
		  longlong param9;
		  longlong param8;
		  uint uVar11;
		  int iVar12;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a585a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ThemeDuelScope_BattleBeginEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_CombatPlayer___);
		    Mono_Security_ASN1__get_Item(&System_Func_CombatPlayer__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController__HandleJoinToCombatInfoChanged_b__13_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_TypeInfo);
		    DAT_ram_00a585a6 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = *(int *)(iVar1 + 100);
		  if (iVar1 != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar11 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8 + 4) * 8 + iVar7 + 0x288);
		          goto code_r0x80f0b6e4;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar11);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x80f0b6e4:
		    iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		    lVar10 = *(longlong *)(iVar1 + 0x10);
		    iVar7 = *(int *)(iVar7 + 0x14);
		    func_ii_7103(*(undefined4 *)(iVar7 + 0x34),0);
		    if (lVar10 == *(longlong *)(*(int *)(iVar7 + 0x10) + 0x10)) {
		      if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_DateTimeOffset_TypeInfo);
		      }
		      OKG_Logs_Debug__LogWarning(&local_20,0);
		      local_8 = local_18;
		      local_10 = local_20;
		      uVar5 = System_DateTimeOffset__get_UtcNow(&local_10,0);
		      *(undefined8 *)(param1 + 0xe) = uVar5;
		      if (*(int *)(Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_TypeInfo + 0x74) == 0)
		      {
		        func_ii_306000(Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_TypeInfo);
		      }
		      iVar12 = *(int *)**(undefined4 **)
		                         (Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_TypeInfo + 0x5c
		                         );
		      iVar12 = (**(code **)((ulonglong)*(uint *)(iVar12 + 0xe8) * 4))
		                         ((int *)**(undefined4 **)
		                                   (
		                                   Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_TypeInfo
		                                   + 0x5c),*(undefined4 *)(iVar12 + 0xec));
		      param1[0xc] = iVar12;
		      if (DAT_ram_00a58587 == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_System_Nullable_long__GetValueOrDefault__);
		        DAT_ram_00a58587 = '\x01';
		      }
		      *(undefined8 *)(param1 + 8) = *(undefined8 *)(iVar7 + 0x20);
		      iVar12 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                         (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar3 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                        (*(undefined4 *)(iVar12 + 0x1c),
		                         Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__
		                        );
		      uVar4 = unnamed_function_1417(System_Func_CombatPlayer__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (uVar4,param1,
		                 Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController__HandleJoinToCombatInfoChanged_b__13_0__
		                 ,0);
		      uVar3 = func_ii_7423(uVar3,uVar4,Method_System_Linq_Enumerable_First_CombatPlayer___);
		      piVar6 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                                (param1,*(undefined4 *)(*param1 + 0x104));
		      iVar12 = (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x120) * 4))
		                         (piVar6,*(undefined4 *)(*piVar6 + 0x124));
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar8 = *piVar6;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar11 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8 + 4) * 8 + iVar8 + 0x140)
		            ;
		            goto code_r0x80f0b8e4;
		          }
		          uVar11 = uVar11 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f0b8e4:
		      uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		      iVar8 = func_ii_7112(uVar4,0);
		      iVar9 = *(int *)(iVar8 + 0x78);
		      iVar8 = System_Uri___ctor(0);
		      iVar8 = *(int *)(*(int *)(*(int *)(*(int *)(iVar8 + 0x38) + 0x10) + 0x98) + 8);
		      if (iVar8 != 0) {
		        uVar4 = System_Uri___ctor(0);
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        uVar5 = *(undefined8 *)(iVar1 + 0x10);
		        param3 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        if (DAT_ram_00a58587 == '\0') {
		          Mono_Security_ASN1__get_Item(&Method_System_Nullable_long__GetValueOrDefault__);
		          DAT_ram_00a58587 = '\x01';
		        }
		        param5 = *(undefined8 *)(iVar7 + 0x20);
		        param6 = Core_Data_UserData__get_UserId(uVar3,0);
		        iVar1 = param1[0xc];
		        if (ABS(*(double *)(iVar9 + 0x30)) < 2147483648.0) {
		          iVar7 = (int)*(double *)(iVar9 + 0x30);
		        }
		        else {
		          iVar7 = -0x80000000;
		        }
		        if (ABS(*(double *)(iVar9 + 0x28)) < 9.223372036854776e+18) {
		          lVar10 = (longlong)*(double *)(iVar9 + 0x28);
		        }
		        else {
		          lVar10 = -0x8000000000000000;
		        }
		        if (ABS(*(double *)(iVar9 + 0x20)) < 9.223372036854776e+18) {
		          param15 = (longlong)*(double *)(iVar9 + 0x20);
		        }
		        else {
		          param15 = -0x8000000000000000;
		        }
		        if (ABS(*(double *)(iVar9 + 0x10)) < 9.223372036854776e+18) {
		          param14 = (longlong)*(double *)(iVar9 + 0x10);
		        }
		        else {
		          param14 = -0x8000000000000000;
		        }
		        if (ABS(*(double *)(iVar9 + 0x18)) < 9.223372036854776e+18) {
		          param13 = (longlong)*(double *)(iVar9 + 0x18);
		        }
		        else {
		          param13 = -0x8000000000000000;
		        }
		        if (ABS(*(double *)(iVar12 + 0x30)) < 2147483648.0) {
		          iVar9 = (int)*(double *)(iVar12 + 0x30);
		        }
		        else {
		          iVar9 = -0x80000000;
		        }
		        if (ABS(*(double *)(iVar12 + 0x28)) < 9.223372036854776e+18) {
		          param11 = (longlong)*(double *)(iVar12 + 0x28);
		        }
		        else {
		          param11 = -0x8000000000000000;
		        }
		        if (ABS(*(double *)(iVar12 + 0x20)) < 9.223372036854776e+18) {
		          param10 = (longlong)*(double *)(iVar12 + 0x20);
		        }
		        else {
		          param10 = -0x8000000000000000;
		        }
		        if (ABS(*(double *)(iVar12 + 0x10)) < 9.223372036854776e+18) {
		          param9 = (longlong)*(double *)(iVar12 + 0x10);
		        }
		        else {
		          param9 = -0x8000000000000000;
		        }
		        if (ABS(*(double *)(iVar12 + 0x18)) < 9.223372036854776e+18) {
		          param8 = (longlong)*(double *)(iVar12 + 0x18);
		        }
		        else {
		          param8 = -0x8000000000000000;
		        }
		        uVar3 = unnamed_function_1417
		                          (Core_Events_Scopes_ThemeDuelScope_BattleBeginEventArgs_TypeInfo);
		        Core_Events_Scopes_ThemeDuelScope_BaseThemeDuelEventArgs__get_EventId
		                  (uVar3,uVar4,param3,uVar5,param5,param6,iVar1,param8,param9,param10,param11,iVar9,
		                   param13,param14,param15,lVar10,iVar7,0);
		        (**(code **)((ulonglong)*(uint *)(iVar8 + 0xc) * 4))
		                  (*(undefined4 *)(iVar8 + 0x20),uVar3,*(undefined4 *)(iVar8 + 0x14));
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D89")]
		[Address(RVA = "0x6F08", Offset = "0x6F08", VA = "0x6F08", Slot = "18")]
		protected override void HandleJoinToCombatInfoChanged()
		{
		/* --- GHIDRA: HandleJoinToCombatInfoChanged ---
		void Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController__HandleJoinToCombatInfoChanged
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  longlong lVar5;
		  undefined8 param11;
		  int *piVar6;
		  int iVar7;
		  undefined4 param3_00;
		  int param10;
		  int param8;
		  int param7;
		  longlong lVar8;
		  longlong lVar9;
		  longlong lVar10;
		  undefined8 param4;
		  uint uVar11;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a585a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ThemeDuelScope_BattleFinishedArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_CombatPlayer___);
		    Mono_Security_ASN1__get_Item(&System_Func_CombatPlayer__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController__HandleGameOverInfoChanged_b__14_0__
		              );
		    DAT_ram_00a585a7 = '\x01';
		  }
		  if (0 < param1[0xc]) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = *(int *)(iVar1 + 100);
		    if (iVar1 != 0) {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar7 = *piVar6;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar11 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8 + 4) * 8 + iVar7 + 0x288)
		            ;
		            goto code_r0x80f0bc96;
		          }
		          uVar11 = uVar11 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar11);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x80f0bc96:
		      iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		      lVar8 = *(longlong *)(iVar1 + 0x10);
		      iVar1 = *(int *)(iVar7 + 0x14);
		      func_ii_7103(*(undefined4 *)(iVar1 + 0x34),0);
		      if (lVar8 == *(longlong *)(*(int *)(iVar1 + 0x10) + 0x10)) {
		        if (DAT_ram_00a58587 == '\0') {
		          Mono_Security_ASN1__get_Item(&Method_System_Nullable_long__GetValueOrDefault__);
		          DAT_ram_00a58587 = '\x01';
		        }
		        lVar8 = *(longlong *)(iVar1 + 0x20);
		        if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		          func_ii_306000(System_DateTimeOffset_TypeInfo);
		        }
		        OKG_Logs_Debug__LogWarning(&local_20,0);
		        local_8 = local_18;
		        local_10 = local_20;
		        lVar5 = System_DateTimeOffset__get_UtcNow(&local_10,0);
		        lVar9 = *(longlong *)(param1 + 0xe);
		        iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        uVar3 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                          (*(undefined4 *)(iVar7 + 0x1c),
		                           Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__
		                          );
		        uVar4 = unnamed_function_1417(System_Func_CombatPlayer__bool__TypeInfo);
		        System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                  (uVar4,param1,
		                   Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController__HandleGameOverInfoChanged_b__14_0__
		                   ,0);
		        uVar3 = func_ii_7423(uVar3,uVar4,Method_System_Linq_Enumerable_First_CombatPlayer___);
		        iVar7 = System_Uri___ctor(0);
		        iVar7 = *(int *)(*(int *)(*(int *)(*(int *)(iVar7 + 0x38) + 0x10) + 0x98) + 0xc);
		        if (iVar7 != 0) {
		          uVar4 = System_Uri___ctor(0);
		          if (DAT_ram_00a6456f == '\0') {
		            Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		            DAT_ram_00a6456f = '\x01';
		          }
		          param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		          func_ii_7103(*(undefined4 *)(iVar1 + 0x34),0);
		          param10 = param1[0xd];
		          param8 = param1[0xc];
		          param7 = param1[0x11];
		          lVar10 = *(longlong *)(param1 + 8);
		          param4 = *(undefined8 *)(*(int *)(iVar1 + 0x10) + 0x10);
		          if (*(char *)(param2 + 8) != '\0') {
		            piVar6 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                                      (param1,*(undefined4 *)(*param1 + 0x104));
		            uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x100) * 4))
		                              (piVar6,*(undefined4 *)(*piVar6 + 0x104));
		          }
		          param11 = Core_Data_UserData__get_UserId(uVar3,0);
		          uVar3 = unnamed_function_1417
		                            (Core_Events_Scopes_ThemeDuelScope_BattleFinishedArgs_TypeInfo);
		          Core_Events_Scopes_ThemeDuelScope_BattleBeginEventArgs__get_BalanceFragments
		                    (uVar3,uVar4,param3_00,param4,lVar8 - lVar10,lVar8,param7,param8,lVar5 - lVar9,
		                     param10,param11,0);
		          (**(code **)((ulonglong)*(uint *)(iVar7 + 0xc) * 4))
		                    (*(undefined4 *)(iVar7 + 0x20),uVar3,*(undefined4 *)(iVar7 + 0x14));
		        }
		        param1[0xc] = 0;
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D8A")]
		[Address(RVA = "0x6F09", Offset = "0x6F09", VA = "0x6F09", Slot = "23")]
		protected override void HandleGameOverInfoChanged(GameOverData gameOverData)
		{
		/* --- GHIDRA: HandleGameOverInfoChanged ---
		void Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController__HandleGameOverInfoChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar4;
		  
		  if (DAT_ram_00a585a8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ThemeDuelCombatModel__ThemeDuelCombatEvents__get_CombatService__
		              );
		    Mono_Security_ASN1__get_Item(&ServicesNamespace_ICombatService_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_HandlePutJoinServiceRequest__
		              );
		    DAT_ram_00a585a8 = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0x18);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (ServicesNamespace_ICombatService_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1d0);
		        goto code_r0x80f0b574;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,ServicesNamespace_ICombatService_TypeInfo,0x22);
		code_r0x80f0b574:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,param2,0xc,puVar2[1]);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_HandlePutJoinServiceRequest__
		             ,0);
		  uVar3 = ServicesNamespace_MainService__GetUserStats
		                    (uVar3,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D8B")]
		[Address(RVA = "0x6F0A", Offset = "0x6F0A", VA = "0x6F0A")]
		private void RequestPutJoinRequest(ProtoRequestCombatCmd.Types.ArenaCombatTypes type)
		{
		/* --- GHIDRA: RequestPutJoinRequest ---
		void Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController__RequestPutJoinRequest
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
		  
		  if (DAT_ram_00a585a9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedCombatBillingErrors__ExpectedThemeDuelCombatErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoRequestCombatAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a585a9 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  uVar4 = CONCAT44(in_register_20000004,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (uVar4,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = *(undefined4 *)(iVar1 + 0x50);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Combat_ProtoRequestCombatAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Combat_ProtoRequestCombatAns_TypeInfo);
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
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedCombatBillingErrors__ExpectedThemeDuelCombatErrors___
		                    );
		  if (iVar1 != 0) {
		    uVar2 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    DefaultNamespace_SceneAppManager__RemoveScene(uVar2,uVar3,0);
		    return;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (CONCAT44(uVar2,param1),*(undefined4 *)(*param1 + 0x104));
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

		// Token: 0x06001D8C RID: 7564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D8C")]
		[Address(RVA = "0x6F0B", Offset = "0x6F0B", VA = "0x6F0B")]
		private void HandlePutJoinServiceRequest(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandlePutJoinServiceRequest ---
		void Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController__HandlePutJoinServiceRequest
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a585aa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoThemeDuelStateChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ThemeDuelCombatModel__ThemeDuelCombatEvents__AddCombatServiceEventsHandlers__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_HandelCurrentThemeDuelStateChanged__
		              );
		    DAT_ram_00a585aa = '\x01';
		  }
		  Gameplay_Combat_Control_CombatController_object__object____HandleSpellAppliedServiceEvent_g__Handler_42_0
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_ThemeDuelCombatModel__ThemeDuelCombatEvents__AddCombatServiceEventsHandlers__
		            );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar4 = *(int *)(iVar1 + 0x70);
		  param1_00 = *(undefined4 *)(iVar4 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_ProtoThemeDuelStateChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_HandelCurrentThemeDuelStateChanged__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0);
		  uVar2 = System_Action_ProtoThemeDuelStateChangedEvt__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x1c) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_ProtoThemeDuelStateChangedEvt__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 0x1c) = iVar3;
		  uVar2 = System_Action_ProtoThemeDuelStateChangedEvt__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_ProtoThemeDuelStateChangedEvt__TypeInfo);
		  if (iVar4 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D8D")]
		[Address(RVA = "0x6F0C", Offset = "0x6F0C", VA = "0x6F0C", Slot = "15")]
		protected override void AddCombatServiceEventsHandlers()
		{
		/* --- GHIDRA: AddCombatServiceEventsHandlers ---
		void Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController__AddCombatServiceEventsHandlers
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 param1_01;
		  int iVar6;
		  
		  if (DAT_ram_00a585ab == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoThemeDuelStateChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ThemeDuelCombatModel__ThemeDuelCombatEvents__RemoveCombatServiceEventsHandlers__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ThemeDuelCombatModel__ThemeDuelCombatEvents__get_CombatService__
		              );
		    Mono_Security_ASN1__get_Item(&ServicesNamespace_ICombatService_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_HandelCurrentThemeDuelStateChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_HandleThemeScoreChangedEvt__
		              );
		    DAT_ram_00a585ab = '\x01';
		  }
		  Gameplay_Combat_Control_CombatController_object__object___PrepareView
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_ThemeDuelCombatModel__ThemeDuelCombatEvents__RemoveCombatServiceEventsHandlers__
		            );
		  param1_00 = (int *)param1[6];
		  uVar2 = unnamed_function_1417(System_Action_ProtoThemeScoreChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_HandleThemeScoreChangedEvt__
		             ,0);
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (ServicesNamespace_ICombatService_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8))
		      {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x1b8);
		        goto code_r0x80f0c1eb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,ServicesNamespace_ICombatService_TypeInfo,0x1f);
		code_r0x80f0c1eb:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar2,puVar3[1]);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar5 = *(int *)(iVar6 + 0x70);
		  param1_01 = *(undefined4 *)(iVar5 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_ProtoThemeDuelStateChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_HandelCurrentThemeDuelStateChanged__
		             ,0);
		  iVar6 = func_ii_7048(param1_01,uVar2,0);
		  uVar2 = System_Action_ProtoThemeDuelStateChangedEvt__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar5 + 0x1c) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar6,System_Action_ProtoThemeDuelStateChangedEvt__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar5 + 0x1c) = iVar4;
		    uVar2 = System_Action_ProtoThemeDuelStateChangedEvt__TypeInfo;
		    iVar5 = func_ii_1082(iVar6,System_Action_ProtoThemeDuelStateChangedEvt__TypeInfo);
		    if (iVar5 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar6,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar6,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D8E")]
		[Address(RVA = "0x6F0D", Offset = "0x6F0D", VA = "0x6F0D", Slot = "16")]
		protected override void RemoveCombatServiceEventsHandlers()
		{
		/* --- GHIDRA: RemoveCombatServiceEventsHandlers ---
		void Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController__RemoveCombatServiceEventsHandlers
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x74);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(longlong *)(*(int *)(param2 + 0xc) + 0x20) != 0,
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D8F")]
		[Address(RVA = "0x6F0E", Offset = "0x6F0E", VA = "0x6F0E")]
		private void HandelCurrentThemeDuelStateChanged(ProtoThemeDuelStateChangedEvt msg)
		{
		/* --- GHIDRA: HandelCurrentThemeDuelStateChanged ---
		void Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController__HandelCurrentThemeDuelStateChanged
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  undefined8 param3_00;
		  
		  if (DAT_ram_00a585ac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ulong__set_Item__);
		    DAT_ram_00a585ac = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  param3_00 = *(undefined8 *)(param2 + 0x18);
		  System_Collections_Generic_Dictionary_ulong__ulong___get_Values
		            (*(undefined4 *)(iVar2 + 0x60),*(undefined8 *)(param2 + 0x10),param3_00,
		             Method_System_Collections_Generic_Dictionary_ulong__ulong__set_Item__);
		  uVar1 = (undefined4)((ulonglong)param3_00 >> 0x20);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x70);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param2,CONCAT44(uVar1,*(undefined4 *)(iVar2 + 0x14)));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D90")]
		[Address(RVA = "0x6F0F", Offset = "0x6F0F", VA = "0x6F0F")]
		private void HandleThemeScoreChangedEvt(ProtoThemeScoreChangedEvt msg)
		{
		/* --- GHIDRA: HandleThemeScoreChangedEvt ---
		int Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController__HandleThemeScoreChangedEvt
		              (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a585ad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedThemeDuelCombatErrors___
		              );
		    DAT_ram_00a585ad = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = *(undefined4 *)(iVar1 + 0x50);
		  uVar2 = *(undefined4 *)(param2 + 0xc);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (uVar2,*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x14),
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedThemeDuelCombatErrors___
		                    );
		  if (iVar1 != 0) {
		    uVar2 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    DefaultNamespace_SceneAppManager__RemoveScene(uVar2,param2_00,0);
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x00006300 File Offset: 0x00004500
		[Token(Token = "0x6001D91")]
		[Address(RVA = "0x6F10", Offset = "0x6F10", VA = "0x6F10", Slot = "20")]
		protected override bool TryHandleJoinError(ProtoJoinToCombatAns msg)
		{
		/* --- GHIDRA: TryHandleJoinError ---
		void Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController__TryHandleJoinError
		               (undefined4 param1)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a585ae == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Random_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_TypeInfo);
		    DAT_ram_00a585ae = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Random_TypeInfo);
		  System_PlatformNotSupportedException___ctor(param1_00,0);
		  **(undefined4 **)(Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_TypeInfo + 0x5c) =
		       param1_00;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0400100E RID: 4110
		[Token(Token = "0x400100E")]
		[FieldOffset(Offset = "0x0")]
		private static Random _duelIdRandom;

		// Token: 0x0400100F RID: 4111
		[Token(Token = "0x400100F")]
		[FieldOffset(Offset = "0x20")]
		private long _startBalance;

		// Token: 0x04001010 RID: 4112
		[Token(Token = "0x4001010")]
		[FieldOffset(Offset = "0x28")]
		private long _gameBalance;

		// Token: 0x04001011 RID: 4113
		[Token(Token = "0x4001011")]
		[FieldOffset(Offset = "0x30")]
		private int _duelId;

		// Token: 0x04001012 RID: 4114
		[Token(Token = "0x4001012")]
		[FieldOffset(Offset = "0x34")]
		private int _numSteps;

		// Token: 0x04001013 RID: 4115
		[Token(Token = "0x4001013")]
		[FieldOffset(Offset = "0x38")]
		private long _startTs;

		// Token: 0x04001014 RID: 4116
		[Token(Token = "0x4001014")]
		[FieldOffset(Offset = "0x40")]
		private readonly ThemeDuelCombatEventStatisticsObserver _combatEventObserver;

		// Token: 0x04001015 RID: 4117
		[Token(Token = "0x4001015")]
		[FieldOffset(Offset = "0x44")]
		private readonly Dictionary<int, int> _eventStoneMatchesMap;
	}
}
