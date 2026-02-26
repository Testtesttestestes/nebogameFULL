using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Accounts.Model.Data;
using Gameplay.Combat.Model;
using Gameplay.ThemeDuelState;
using Gameplay.ThemeDuelState.Model;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Common;
using Protocol.Dic;
using Utils;

namespace Gameplay.ThemeDuelCombat.Model
{
	// Token: 0x020004D8 RID: 1240
	[Token(Token = "0x20004D8")]
	public class ThemeDuelCombatModel : CombatModel
	{
		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001D7D RID: 7549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000549")]
		public ThemeDuelStateModel ThemeDuelModel
		{
			[Token(Token = "0x6001D7C")]
			[Address(RVA = "0x6EFB", Offset = "0x6EFB", VA = "0x6EFB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D7D")]
			[Address(RVA = "0x6EFC", Offset = "0x6EFC", VA = "0x6EFC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001D7E RID: 7550 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001D7F RID: 7551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054A")]
		public ThemeDuelStateEvents ThemeDuelEvents
		{
			[Token(Token = "0x6001D7E")]
			[Address(RVA = "0x6EFD", Offset = "0x6EFD", VA = "0x6EFD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D7F")]
			[Address(RVA = "0x6EFE", Offset = "0x6EFE", VA = "0x6EFE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D80")]
		[Address(RVA = "0x6EFF", Offset = "0x6EFF", VA = "0x6EFF", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_ThemeDuelCombat_Model_ThemeDuelCombatModel__Dispose
		               (int param1,undefined4 param2,int param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7,undefined4 param8,undefined4 param9,
		               undefined4 param10)
		
		{
		  undefined4 uVar1;
		  float fVar2;
		  
		  if (DAT_ram_00a585a1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ulong___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_ulong__ulong__TypeInfo);
		    DAT_ram_00a585a1 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_ulong__ulong__TypeInfo);
		  System_Collections_Generic_Dictionary_ulong__ulong___set_Item
		            (uVar1,Method_System_Collections_Generic_Dictionary_ulong__ulong___ctor__);
		  *(undefined4 *)(param1 + 0x60) = uVar1;
		  Gameplay_Combat_Model_CombatModel__Dispose(param1,param2,param6,param7,param8,0);
		  *(undefined4 *)(param1 + 0x70) = param4;
		  *(int *)(param1 + 0x6c) = param3;
		  *(undefined4 *)(param1 + 0x68) = param9;
		  *(undefined4 *)(param1 + 0x5c) = param5;
		  fVar2 = func_ii_7103(*(undefined4 *)(param3 + 0x34),0);
		  if (0.0 < fVar2) {
		    uVar1 = *(undefined4 *)(param3 + 0x10);
		  }
		  else {
		    uVar1 = 0;
		  }
		  *(undefined4 *)(param1 + 100) = uVar1;
		  func_ii_7103(*(undefined4 *)(param3 + 0x34),0);
		  return;
		}
		*/

		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D81")]
		[Address(RVA = "0x6F00", Offset = "0x6F00", VA = "0x6F00")]
		public ThemeDuelCombatModel(CombatDependencies dependencies, ThemeDuelStateModel themeDuelModel, ThemeDuelStateEvents themeDuelEvents, ProtoRequestCombatCmd.Types.ArenaCombatTypes matchmakingWay, BackTime awaitBackTime, UserData loggedUser, UserData user, BattleAccount battleAccount)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_ThemeDuelCombat_Model_ThemeDuelCombatModel___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Accounts_Model_Data_BattleAccount__GetPartyCombatCost
		                    (*(undefined4 *)(param1 + 0x68),*(undefined4 *)(param1 + 0x6c),0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001D82")]
		[Address(RVA = "0x6F01", Offset = "0x6F01", VA = "0x6F01", Slot = "12")]
		public override ResourceSet GetNextCombatCost()
		{
		/* --- GHIDRA: GetNextCombatCost ---
		uint Gameplay_ThemeDuelCombat_Model_ThemeDuelCombatModel__GetNextCombatCost
		               (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  *param2 = *(undefined4 *)(param1 + 100);
		  return (uint)(*(int *)(param1 + 100) != 0);
		}
		*/

			return null;
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x000062E8 File Offset: 0x000044E8
		[Token(Token = "0x6001D83")]
		[Address(RVA = "0x6F02", Offset = "0x6F02", VA = "0x6F02")]
		public bool TryGetCurrentDuel(out ThemeDuelDic dic)
		{
		/* --- GHIDRA: TryGetCurrentDuel ---
		void Gameplay_ThemeDuelCombat_Model_ThemeDuelCombatModel__TryGetCurrentDuel
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a585a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_long__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ThemeDuelCombatModel__ThemeDuelCombatEvents___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ThemeDuelCombatEvents__add_OnTurn__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_int__int___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_int__int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_OnScoreChanged__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_OnTurn__);
		    DAT_ram_00a585a2 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_int__int__TypeInfo);
		  System_Collections_Generic_Dictionary_int__TMP_ResourceManager_FontAssetRef___set_Item
		            (uVar1,Method_System_Collections_Generic_Dictionary_int__int___ctor__);
		  *(undefined4 *)(param1 + 0x44) = uVar1;
		  Sirenix_Serialization_ColorBlockFormatter___Il2CppFullySharedGenericType___Write
		            (param1,param2,param3,param4,
		             Method_Gameplay_Combat_Control_CombatController_ThemeDuelCombatModel__ThemeDuelCombatEvents___ctor__
		            );
		  *(undefined4 *)(param1 + 0x40) = param5;
		  uVar1 = unnamed_function_1417(System_Action_long__TypeInfo);
		  System_Action_Int32Enum___Invoke
		            (uVar1,param1,
		             Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_OnScoreChanged__,0);
		  Gameplay_ArenaCombat_ArenaCombatEvents___ctor(param5,uVar1,0);
		  param1_00 = *(undefined4 *)(param1 + 0x40);
		  uVar1 = unnamed_function_1417(System_Action_bool__TypeInfo);
		  System_Action_AsyncGPUReadbackRequest___Invoke
		            (uVar1,param1,Method_Gameplay_ThemeDuelCombat_Control_ThemeDuelCombatController_OnTurn__
		             ,0);
		  Gameplay_ArenaCombat_CombatEventStatisticsObserver_object___add_OnMatchStones
		            (param1_00,uVar1,
		             Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ThemeDuelCombatEvents__add_OnTurn__
		            );
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x04001008 RID: 4104
		[Token(Token = "0x4001008")]
		[FieldOffset(Offset = "0x5C")]
		public readonly ProtoRequestCombatCmd.Types.ArenaCombatTypes MatchmakingWay;

		// Token: 0x04001009 RID: 4105
		[Token(Token = "0x4001009")]
		[FieldOffset(Offset = "0x60")]
		public readonly Dictionary<ulong, ulong> ThemeDuelScoreByPlayerId;

		// Token: 0x0400100A RID: 4106
		[Token(Token = "0x400100A")]
		[FieldOffset(Offset = "0x64")]
		private readonly ThemeDuelDic _cachedThemeDuelDic;

		// Token: 0x0400100B RID: 4107
		[Token(Token = "0x400100B")]
		[FieldOffset(Offset = "0x68")]
		private readonly BattleAccount _battleAccount;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_ThemeDuelEvents ---
		void Gameplay_ThemeDuelCombat_Model_ThemeDuelCombatModel__set_ThemeDuelEvents
		               (int param1,undefined4 param2)
		
		{
		  Gameplay_Combat_Model_CombatModel__GetState(param1,0);
		  *(undefined8 *)(param1 + 0x6c) = 0;
		  return;
		}
		*/

}
