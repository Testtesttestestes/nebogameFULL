using System;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using Gameplay.Combat.Factories;
using Gameplay.Combat.Model;
using Gameplay.Combat.TeamCombat.Model;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Partycombat;
using Utils;

namespace Gameplay.VortexCombat.Model
{
	// Token: 0x020003B1 RID: 945
	[Token(Token = "0x20003B1")]
	public class VortexCombatModel : TeamCombatModel
	{
		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x000053A0 File Offset: 0x000035A0
		[Token(Token = "0x170003AE")]
		public override int SpellSlotsCount
		{
			[Token(Token = "0x6001621")]
			[Address(RVA = "0x67E2", Offset = "0x67E2", VA = "0x67E2", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001622 RID: 5666 RVA: 0x000053B8 File Offset: 0x000035B8
		[Token(Token = "0x170003AF")]
		public override int ElixirsSlotsCount
		{
			[Token(Token = "0x6001622")]
			[Address(RVA = "0x67E3", Offset = "0x67E3", VA = "0x67E3", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001623 RID: 5667 RVA: 0x000053D0 File Offset: 0x000035D0
		// (set) Token: 0x06001624 RID: 5668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B0")]
		public bool SkillNumbersOnBarsEnabled
		{
			[Token(Token = "0x6001623")]
			[Address(RVA = "0x67E4", Offset = "0x67E4", VA = "0x67E4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001624")]
			[Address(RVA = "0x67E5", Offset = "0x67E5", VA = "0x67E5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x000053E8 File Offset: 0x000035E8
		[Token(Token = "0x170003B1")]
		public virtual CombatTypes CombatType
		{
			[Token(Token = "0x6001625")]
			[Address(RVA = "0x67E6", Offset = "0x67E6", VA = "0x67E6", Slot = "19")]
			get
			{
				return CombatTypes.UnknownCombat;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001626 RID: 5670 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003B2")]
		public virtual long[] CombatParams
		{
			[Token(Token = "0x6001626")]
			[Address(RVA = "0x67E7", Offset = "0x67E7", VA = "0x67E7", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001627")]
		[Address(RVA = "0x67E8", Offset = "0x67E8", VA = "0x67E8", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_VortexCombat_Model_VortexCombatModel__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  Gameplay_Combat_TeamCombat_TeamCombatEvents___ctor(param1,param2,param3,param4,param5,0);
		  return;
		}
		*/

		}

		// Token: 0x06001628 RID: 5672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001628")]
		[Address(RVA = "0x67E9", Offset = "0x67E9", VA = "0x67E9")]
		public VortexCombatModel(CombatDependencies dependencies, BackTime awaitBackTime, UserData loggedUser, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_VortexCombat_Model_VortexCombatModel___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  longlong lVar4;
		  int iVar5;
		  longlong lVar6;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5822a == '\0') {
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
		    DAT_ram_00a5822a = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar5 = *(int *)(param1 + 0x24);
		  if (iVar5 == 0) {
		    uVar1 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                      (*(undefined4 *)(param1 + 0x1c),
		                       Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__
		                      );
		    System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		              (&local_10,uVar1,
		               Method_System_Collections_Generic_Dictionary_ValueCollection_ulong__CombatPlayer__GetEnumerator__
		              );
		    local_18 = 0;
		    local_14 = &local_10;
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2e2,&local_10,
		                         Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__MoveNext__
		                        );
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ebc359:
		        iVar5 = global_1;
		        iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar5 == iVar2) {
		          piVar3 = (int *)import::env::__cxa_begin_catch(uVar1);
		          iVar2 = *piVar3;
		          DAT_ram_009d3e38 = 0;
		          local_18 = iVar2;
		          import::env::invoke_v(0x123);
		          iVar5 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar5 != 1) {
		            if (iVar2 != 0) {
		              System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		              do {
		                halt_trap();
		              } while( true );
		            }
		            goto code_r0x80ebc3af;
		          }
		          uVar1 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x125,&local_18);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          import::env::__cxa_find_matching_catch_3(0);
		          unnamed_function_937();
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__resumeException(uVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (iVar2 == 0) goto code_r0x80ebc3af;
		      lVar6 = *(longlong *)(*(int *)(param1 + 0xc) + 0x38);
		      DAT_ram_009d3e38 = 0;
		      uVar1 = local_8._4_4_;
		      lVar4 = unnamed_function_184054
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x357,local_8._4_4_,0);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ebc359;
		      }
		    } while (lVar6 != lVar4);
		    *(undefined4 *)(param1 + 0x24) = uVar1;
		code_r0x80ebc3af:
		    iVar5 = *(int *)(param1 + 0x24);
		  }
		  return iVar5;
		}
		*/

		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001629 RID: 5673 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003B3")]
		public override CombatPlayer MyPlayer
		{
			[Token(Token = "0x6001629")]
			[Address(RVA = "0x67EA", Offset = "0x67EA", VA = "0x67EA", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600162A")]
		[Address(RVA = "0x67EB", Offset = "0x67EB", VA = "0x67EB")]
		public void SetRequestCombatData(Protocol.Partycombat.ProtoRequestCombatAns value)
		{
		/* --- GHIDRA: SetRequestCombatData ---
		undefined4
		Gameplay_VortexCombat_Model_VortexCombatModel__SetRequestCombatData
		          (int *param1,longlong param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  longlong lVar3;
		  int iVar4;
		  int local_4;
		  
		  if (DAT_ram_00a5822c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__TryGetValue__);
		    DAT_ram_00a5822c = '\x01';
		  }
		  local_4 = 0;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  lVar3 = Core_Data_UserData__get_UserId(uVar1,0);
		  if (lVar3 == param2) {
		    uVar1 = 3;
		  }
		  else {
		    iVar2 = func_ii_7090(param1[7],param2,&local_4,
		                         Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__TryGetValue__
		                        );
		    if (iVar2 == 0) {
		      uVar1 = 0;
		    }
		    else {
		      uVar1 = 1;
		      iVar4 = *(int *)(*(int *)(local_4 + 8) + 0x14);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      if (iVar4 != *(int *)(*(int *)(iVar2 + 8) + 0x14)) {
		        uVar1 = 2;
		      }
		    }
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00005400 File Offset: 0x00003600
		[Token(Token = "0x600162B")]
		[Address(RVA = "0x67EC", Offset = "0x67EC", VA = "0x67EC", Slot = "10")]
		public override TurnStates GetTurnState(ulong userId)
		{
		/* --- GHIDRA: GetTurnState ---
		int * Gameplay_VortexCombat_Model_VortexCombatModel__GetTurnState
		                (int param1,int *param2,undefined4 param3,undefined4 param4,int param5,
		                undefined4 param6)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  longlong lVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  longlong lVar7;
		  
		  if (DAT_ram_00a5822d == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_ICombatPlayerFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo);
		    DAT_ram_00a5822d = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param5 + 0xc);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x80ebc60a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ebc60a:
		  uVar1 = 0;
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar4 = Core_Data_UserData__get_IsSigninConfirmed(uVar4,param2_00,0);
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_Factories_ICombatPlayerFactory_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80ebc692;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Combat_Factories_ICombatPlayerFactory_TypeInfo,0);
		code_r0x80ebc692:
		  piVar5 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,param5,uVar4,param3,puVar2[1]);
		  if (piVar5 == (int *)0x0) {
		    piVar5 = (int *)0x0;
		  }
		  else if ((uint)*(byte *)(*piVar5 + 0xb8) <
		           (uint)*(byte *)(Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo + 0xb8)) {
		    piVar5 = (int *)0x0;
		  }
		  else if (*(int *)(*(int *)(*piVar5 + 100) +
		                    (uint)*(byte *)(Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo + 0xb8)
		                    * 4 + -4) != Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo) {
		    piVar5 = (int *)0x0;
		  }
		  lVar7 = *(longlong *)(*(int *)(param1 + 0xc) + 0x38);
		  lVar3 = Core_Data_UserData__get_UserId(piVar5,0);
		  *(bool *)((int)piVar5 + 0x65) = lVar7 == lVar3;
		  lVar7 = *(longlong *)(*(int *)(param1 + 0xc) + 0x20);
		  lVar3 = Core_Data_UserData__get_UserId(piVar5,0);
		  *(bool *)(piVar5 + 0x19) = lVar7 == lVar3;
		  if (*(char *)((int)piVar5 + 0x65) != '\0') {
		    Core_Data_UserData__get_Money(piVar5[5],*(undefined4 *)(*(int *)(param1 + 8) + 0x78),0);
		    iVar6 = *(int *)(piVar5[5] + 0x34);
		    uVar4 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(param1 + 8),0);
		    *(undefined4 *)(iVar6 + 0x20) = uVar4;
		    iVar6 = *(int *)(piVar5[5] + 0x34);
		    uVar4 = Core_Data_UserData__set_Level(*(undefined4 *)(param1 + 8),0);
		    *(undefined4 *)(iVar6 + 0x28) = uVar4;
		  }
		  return piVar5;
		}
		*/

			return TurnStates.NoTurn;
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600162C")]
		[Address(RVA = "0x67ED", Offset = "0x67ED", VA = "0x67ED", Slot = "9")]
		protected override CombatPlayer CreatePlayer(ICombatPlayerFactory playerFactory, ICombatSpellDataFactory spellFactory, IUserCache userCache, PlayerInfo playerInfo)
		{
		/* --- GHIDRA: CreatePlayer ---
		undefined4
		Gameplay_VortexCombat_Model_VortexCombatModel__CreatePlayer
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5822e == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_Model_VortexCombatEventData_TypeInfo);
		    DAT_ram_00a5822e = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Gameplay_VortexCombat_Model_VortexCombatEventData_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,param2,0);
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600162D")]
		[Address(RVA = "0x67EE", Offset = "0x67EE", VA = "0x67EE", Slot = "13")]
		protected override CombatEventData CreateCombatEventData(CombatEventDic dict)
		{
		/* --- GHIDRA: CreateCombatEventData ---
		undefined4
		Gameplay_VortexCombat_Model_VortexCombatModel__CreateCombatEventData(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5822f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5822f = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1f8);
		        goto code_r0x80ebc857;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x80ebc857:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar5 = **(int **)(iVar4 + 0x14);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                    (*(int **)(iVar4 + 0x14),*(undefined4 *)(iVar5 + 0x104));
		  uVar3 = Gameplay_Accounts_Model_Data_BattleAccount__GetMonsterKickCost
		                    (*(undefined4 *)(iVar4 + 0x28),*(undefined4 *)(param1 + 8),0);
		  return uVar3;
		}
		*/

			return null;
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600162E")]
		[Address(RVA = "0x67EF", Offset = "0x67EF", VA = "0x67EF", Slot = "12")]
		public override ResourceSet GetNextCombatCost()
		{
		/* --- GHIDRA: GetNextCombatCost ---
		uint Gameplay_VortexCombat_Model_VortexCombatModel__GetNextCombatCost
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  int local_4;
		  
		  uVar2 = 0;
		  if (DAT_ram_00a58230 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__TryGetValue__);
		    DAT_ram_00a58230 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = func_ii_7090(param1[7],param2,&local_4,
		                       Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__TryGetValue__
		                      );
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar2 = (uint)(*(int *)(*(int *)(iVar1 + 8) + 0x14) == *(int *)(*(int *)(local_4 + 8) + 0x14));
		  }
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00005418 File Offset: 0x00003618
		[Token(Token = "0x600162F")]
		[Address(RVA = "0x67F0", Offset = "0x67F0", VA = "0x67F0", Slot = "14")]
		public override bool GetSpellsEnabled(ulong userId)
		{
		/* --- GHIDRA: GetSpellsEnabled ---
		void Gameplay_VortexCombat_Model_VortexCombatModel__GetSpellsEnabled
		               (undefined4 param1,undefined4 *param2,undefined4 *param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58231 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2801);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2802);
		    DAT_ram_00a58231 = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2802,1,0,1,0,0,0,0);
		  *param2 = uVar1;
		  uVar1 = func_ii_7508(StringLiteral_2801,1,0,1,0,0,0,0);
		  *param3 = uVar1;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001630")]
		[Address(RVA = "0x67F1", Offset = "0x67F1", VA = "0x67F1", Slot = "21")]
		public virtual void GetAwaitText(out string title, out string description)
		{
		/* --- GHIDRA: GetAwaitText ---
		void Gameplay_VortexCombat_Model_VortexCombatModel__GetAwaitText
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  Gameplay_Combat_TeamCombat_Model_TeamCombatPlayer__set_IsMyPlayer(param1,param2,param3,param4,0);
		  return;
		}
		*/

		}

		// Token: 0x04000BBB RID: 3003
		[Token(Token = "0x4000BBB")]
		[FieldOffset(Offset = "0x60")]
		private Protocol.Partycombat.ProtoRequestCombatAns _requestOfCombat;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CombatType ---
		undefined4
		Gameplay_VortexCombat_Model_VortexCombatModel__get_CombatType(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a58229 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_long___);
		    DAT_ram_00a58229 = '\x01';
		  }
		  iVar2 = Method_System_Array_Empty_long___;
		  iVar1 = *(int *)(Method_System_Array_Empty_long___ + 0x1c);
		  if (iVar1 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_long___);
		    iVar1 = *(int *)(iVar2 + 0x1c);
		  }
		  iVar1 = *(int *)(iVar1 + 8);
		  if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		    iVar1 = func_ii_1079(iVar1);
		  }
		  if (*(int *)(iVar1 + 0x74) == 0) {
		    func_ii_306000(iVar1);
		  }
		  iVar2 = *(int *)(*(int *)(iVar2 + 0x1c) + 8);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  return **(undefined4 **)(iVar2 + 0x5c);
		}
		*/


		/* --- GHIDRA: get_CombatParams ---
		void Gameplay_VortexCombat_Model_VortexCombatModel__get_CombatParams(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x60) = 0;
		  Gameplay_Combat_Model_CombatModel__GetState(param1,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_MyPlayer ---
		void Gameplay_VortexCombat_Model_VortexCombatModel__get_MyPlayer
		               (int param1,int param2,undefined4 param3)
		
		{
		  float param2_00;
		  undefined4 param1_00;
		  undefined8 param1_01;
		  
		  if (DAT_ram_00a5822b == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a5822b = '\x01';
		  }
		  *(int *)(param1 + 0x60) = param2;
		  param1_01 = *(undefined8 *)(param2 + 0x10);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = Utils_StringUtils___cctor(param1_01,0);
		  param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2_00,0);
		  *(undefined4 *)(param1 + 0x40) = param1_00;
		  return;
		}
		*/

}
