using System;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using Gameplay.Accounts.Model.Data;
using Gameplay.Combat.Factories;
using Gameplay.Combat.Model;
using Gameplay.Isles.User;
using Gameplay.Sound.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Combat;
using Protocol.Common;
using Utils;

namespace Gameplay.ArenaCombat.Model
{
	// Token: 0x02000D47 RID: 3399
	[Token(Token = "0x2000D47")]
	public class ArenaCombatModel : CombatModel
	{
		// Token: 0x06005342 RID: 21314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005342")]
		[Address(RVA = "0xA101", Offset = "0xA101", VA = "0xA101", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_ArenaCombat_Model_ArenaCombatModel__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a593cd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ArenaCombat_Model_ArenaCombatModel_ArenaCombatRequested_TypeInfo);
		    DAT_ram_00a593cd = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_ArenaCombat_Model_ArenaCombatModel_ArenaCombatRequested_TypeInfo);
		  *(undefined4 *)(param1 + 0x60) = uVar1;
		  Gameplay_Combat_Model_CombatModel__Dispose(param1,param2,param3,param4,param5,0);
		  return;
		}
		*/

		}

		// Token: 0x06005343 RID: 21315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005343")]
		[Address(RVA = "0xA102", Offset = "0xA102", VA = "0xA102")]
		public ArenaCombatModel(CombatDependencies dependencies, BackTime awaitBackTime, UserData loggedUser, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_ArenaCombat_Model_ArenaCombatModel___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = 3;
		  if (*(int *)(param1 + 0x5c) == 0) {
		    uVar1 = 2;
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x06005344 RID: 21316 RVA: 0x0000F0D8 File Offset: 0x0000D2D8
		[Token(Token = "0x6005344")]
		[Address(RVA = "0xA103", Offset = "0xA103", VA = "0xA103", Slot = "11")]
		public override PlayLists GetPlayList()
		{
		/* --- GHIDRA: GetPlayList ---
		undefined4 Gameplay_ArenaCombat_Model_ArenaCombatModel__GetPlayList(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a593ce == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a593ce = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1f8);
		        goto code_r0x80ff9d41;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x80ff9d41:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar7 = **(int **)(iVar4 + 0x14);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x100) * 4))
		                    (*(int **)(iVar4 + 0x14),*(undefined4 *)(iVar7 + 0x104));
		  uVar5 = *(undefined4 *)(iVar4 + 0x28);
		  if (*(int *)(param1[0x18] + 8) == 1) {
		    uVar5 = Gameplay_Accounts_Model_Data_BattleAccount__GetArenaEqualCost(uVar5,param1[2],0);
		  }
		  else if (*(int *)(param1[0x18] + 8) == 2) {
		    uVar5 = Gameplay_Accounts_Model_Data_BattleAccount__Init(uVar5,param1[2],0);
		  }
		  else {
		    piVar3 = (int *)param1[0x17];
		    if (piVar3 == (int *)0x0) {
		      uVar5 = 0;
		    }
		    else {
		      uVar5 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xf8) * 4))
		                        (piVar3,uVar5,*(undefined4 *)(*piVar3 + 0xfc));
		    }
		  }
		  iVar7 = *(int *)(param1[4] + 0x18);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar6 = uVar5;
		  if ((iVar7 != iVar4) && (uVar6 = 0, param1[0x17] == 0)) {
		    uVar6 = uVar5;
		  }
		  return uVar6;
		}
		*/

			return PlayLists.UNKNOWN;
		}

		// Token: 0x06005345 RID: 21317 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005345")]
		[Address(RVA = "0xA104", Offset = "0xA104", VA = "0xA104", Slot = "12")]
		public override ResourceSet GetNextCombatCost()
		{
		/* --- GHIDRA: GetNextCombatCost ---
		int Gameplay_ArenaCombat_Model_ArenaCombatModel__GetNextCombatCost
		              (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		              undefined4 param6)
		
		{
		  undefined4 uVar1;
		  int param4_00;
		  int param1_00;
		  
		  param4_00 = Gameplay_Combat_Model_CombatModel__TryGetEventSpell
		                        (param1,param2,param3,param4,param5,0);
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
		  uVar1 = 1;
		  if ((*(int *)(*(int *)(param1 + 0xc) + 0x2c) == *(int *)(*(int *)(param4_00 + 8) + 0x14)) &&
		     (uVar1 = 3, *(int *)(param1 + 0x5c) == 0)) {
		    uVar1 = 2;
		  }
		  uVar1 = Gameplay_Antiq_Model_AntiqModel__TryGetEffectValue
		                    (*(undefined4 *)(param4_00 + 0x14),*(undefined4 *)(*(int *)(param1 + 0xc) + 0xc)
		                     ,uVar1,param4_00);
		  param1_00 = *(int *)(param4_00 + 0x18);
		  *(undefined4 *)(param1_00 + 0xc) = 0;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  System_Collections_Generic_List_Int32Enum___AddEnumerable
		            (param1_00,uVar1,
		             Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__AddRange__
		            );
		  return param4_00;
		}
		*/

			return null;
		}

		// Token: 0x06005346 RID: 21318 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005346")]
		[Address(RVA = "0xA105", Offset = "0xA105", VA = "0xA105", Slot = "9")]
		protected override CombatPlayer CreatePlayer(ICombatPlayerFactory playerFactory, ICombatSpellDataFactory spellFactory, IUserCache userCache, PlayerInfo playerInfo)
		{
		/* --- GHIDRA: CreatePlayer ---
		void Gameplay_ArenaCombat_Model_ArenaCombatModel__CreatePlayer
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
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
		  uVar1 = 1;
		  if ((*(int *)(*(int *)(param1 + 0xc) + 0x2c) == *(int *)(*(int *)(param2 + 8) + 0x14)) &&
		     (uVar1 = 3, *(int *)(param1 + 0x5c) == 0)) {
		    uVar1 = 2;
		  }
		  uVar1 = Gameplay_Antiq_Model_AntiqModel__TryGetEffectValue
		                    (*(undefined4 *)(param2 + 0x14),*(undefined4 *)(*(int *)(param1 + 0xc) + 0xc),
		                     uVar1,param2);
		  param1_00 = *(int *)(param2 + 0x18);
		  *(undefined4 *)(param1_00 + 0xc) = 0;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  System_Collections_Generic_List_Int32Enum___AddEnumerable
		            (param1_00,uVar1,
		             Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__AddRange__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005347 RID: 21319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005347")]
		[Address(RVA = "0xA106", Offset = "0xA106", VA = "0xA106")]
		public void FillEffectIndexes(CombatPlayer player)
		{
		/* --- GHIDRA: FillEffectIndexes ---
		undefined8
		Gameplay_ArenaCombat_Model_ArenaCombatModel__FillEffectIndexes(int param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined8 uVar2;
		  int *param1_00;
		  int iVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a593d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_User_IMonsterSource_TypeInfo);
		    DAT_ram_00a593d0 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar4 = 0;
		    do {
		      if (Gameplay_Isles_User_IMonsterSource_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8)) {
		        puVar1 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80ffa6de;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar4);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,Gameplay_Isles_User_IMonsterSource_TypeInfo,0);
		code_r0x80ffa6de:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		  return uVar2;
		}
		*/

		}

		// Token: 0x04002D1F RID: 11551
		[Token(Token = "0x4002D1F")]
		[FieldOffset(Offset = "0x5C")]
		public ArenaCombatModel.AttackRequestedMonster RequestedMonster;

		// Token: 0x04002D20 RID: 11552
		[Token(Token = "0x4002D20")]
		[FieldOffset(Offset = "0x60")]
		public ArenaCombatModel.ArenaCombatRequested RequestedArena;

		// Token: 0x02000D48 RID: 3400
		[Token(Token = "0x2000D48")]
		public class AttackRequestedMonster
		{
			// Token: 0x170010EA RID: 4330
			// (get) Token: 0x06005348 RID: 21320 RVA: 0x0000F0F0 File Offset: 0x0000D2F0
			[Token(Token = "0x170010EA")]
			public ulong OwnerId
			{
				[Token(Token = "0x6005348")]
				[Address(RVA = "0xA107", Offset = "0xA107", VA = "0xA107")]
				get
				{
					return 0UL;
				}
			}

			// Token: 0x170010EB RID: 4331
			// (get) Token: 0x06005349 RID: 21321 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170010EB")]
			[CanBeNull]
			public virtual MonsterData Monster
			{
				[Token(Token = "0x6005349")]
				[Address(RVA = "0xA108", Offset = "0xA108", VA = "0xA108", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170010EC RID: 4332
			// (get) Token: 0x0600534A RID: 21322 RVA: 0x0000F108 File Offset: 0x0000D308
			[Token(Token = "0x170010EC")]
			public bool FromCave
			{
				[Token(Token = "0x600534A")]
				[Address(RVA = "0xA109", Offset = "0xA109", VA = "0xA109")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600534B RID: 21323 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600534B")]
			[Address(RVA = "0xA10A", Offset = "0xA10A", VA = "0xA10A")]
			public AttackRequestedMonster([NotNull] IMonsterSource source)
			{
			}

			// Token: 0x0600534C RID: 21324 RVA: 0x0000F120 File Offset: 0x0000D320
			[Token(Token = "0x600534C")]
			[Address(RVA = "0xA10B", Offset = "0xA10B", VA = "0xA10B", Slot = "5")]
			public virtual bool IsMonsterExist()
			{
				return default(bool);
			}

			// Token: 0x0600534D RID: 21325 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600534D")]
			[Address(RVA = "0xA10C", Offset = "0xA10C", VA = "0xA10C", Slot = "6")]
			public virtual ResourceSet GetStartMonsterAttackCost(BattleAccount account)
			{
				return null;
			}

			// Token: 0x0600534E RID: 21326 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600534E")]
			[Address(RVA = "0xA10D", Offset = "0xA10D", VA = "0xA10D", Slot = "7")]
			public virtual ResourceSet GetResumeMonsterAttackCost(BattleAccount account)
			{
				return null;
			}

			// Token: 0x04002D22 RID: 11554
			[Token(Token = "0x4002D22")]
			[FieldOffset(Offset = "0xC")]
			private IMonsterSource _source;
		}

		// Token: 0x02000D49 RID: 3401
		[Token(Token = "0x2000D49")]
		public class ArenaCombatRequested
		{
			// Token: 0x0600534F RID: 21327 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600534F")]
			[Address(RVA = "0xA10E", Offset = "0xA10E", VA = "0xA10E")]
			public ArenaCombatRequested()
			{
			}

			// Token: 0x04002D23 RID: 11555
			[Token(Token = "0x4002D23")]
			[FieldOffset(Offset = "0x8")]
			public ProtoRequestCombatCmd.Types.ArenaCombatTypes RequestedCombatType;

			// Token: 0x04002D24 RID: 11556
			[Token(Token = "0x4002D24")]
			[FieldOffset(Offset = "0xC")]
			public bool FromArena;
		}
	}
}
