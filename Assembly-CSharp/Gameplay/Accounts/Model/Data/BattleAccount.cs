using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Accounts;
using Gameplay.ThemeDuelState.Model;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;

namespace Gameplay.Accounts.Model.Data
{
	// Token: 0x02000DDC RID: 3548
	[Token(Token = "0x2000DDC")]
	public class BattleAccount : UserAccount
	{
		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x06005697 RID: 22167 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005698 RID: 22168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011AC")]
		public BattleAccountCoefs BattleAccountCoeffs
		{
			[Token(Token = "0x6005697")]
			[Address(RVA = "0xA41F", Offset = "0xA41F", VA = "0xA41F")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005698")]
			[Address(RVA = "0xA420", Offset = "0xA420", VA = "0xA420")]
			set
			{
			}
		}

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x06005699 RID: 22169 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011AD")]
		public static BattleAccountCoefs BattleAccountCoeffsOneValue
		{
			[Token(Token = "0x6005699")]
			[Address(RVA = "0xA421", Offset = "0xA421", VA = "0xA421")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600569A RID: 22170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600569A")]
		[Address(RVA = "0xA422", Offset = "0xA422", VA = "0xA422", Slot = "19")]
		public override void Init(uint id, Dictionaries dicts, IAccountRepository accountRepository)
		{
		/* --- GHIDRA: Init ---
		undefined4
		Gameplay_Accounts_Model_Data_BattleAccount__Init(int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *param1_00;
		  uint *puVar3;
		  
		  if (DAT_ram_00a588b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountData_TypeInfo);
		    DAT_ram_00a588b4 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x144));
		  if (iVar2 != 0) {
		    param1_00 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		                                 (param1,*(undefined4 *)(*param1 + 0x144));
		    uVar1 = 0;
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Data_Accounts_IAccountData_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)
		           ) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		          goto code_r0x80f3b0af;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Data_Accounts_IAccountData_TypeInfo,2);
		code_r0x80f3b0af:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    if (iVar2 == 0) {
		      return *(undefined4 *)(*(int *)(param2 + 0x6c) + 0x38);
		    }
		  }
		  return *(undefined4 *)(*(int *)(param2 + 0x6c) + 0x28);
		}
		*/

		}

		// Token: 0x0600569B RID: 22171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600569B")]
		[Address(RVA = "0xA423", Offset = "0xA423", VA = "0xA423")]
		public ResourceSet GetArenaEqualCost(UserData user)
		{
		/* --- GHIDRA: GetArenaEqualCost ---
		undefined4
		Gameplay_Accounts_Model_Data_BattleAccount__GetArenaEqualCost
		          (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *param1_00;
		  uint *puVar3;
		  
		  if (DAT_ram_00a588b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountData_TypeInfo);
		    DAT_ram_00a588b4 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x144));
		  if (iVar2 != 0) {
		    param1_00 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		                                 (param1,*(undefined4 *)(*param1 + 0x144));
		    uVar1 = 0;
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Data_Accounts_IAccountData_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)
		           ) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		          goto code_r0x80f3b197;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Data_Accounts_IAccountData_TypeInfo,2);
		code_r0x80f3b197:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    if (iVar2 == 0) {
		      return *(undefined4 *)(*(int *)(param2 + 0x6c) + 0x34);
		    }
		  }
		  return *(undefined4 *)(*(int *)(param2 + 0x6c) + 0x20);
		}
		*/

			return null;
		}

		// Token: 0x0600569C RID: 22172 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600569C")]
		[Address(RVA = "0xA424", Offset = "0xA424", VA = "0xA424")]
		public ResourceSet GetArenaLevelCost(UserData user)
		{
		/* --- GHIDRA: GetArenaLevelCost ---
		undefined4
		Gameplay_Accounts_Model_Data_BattleAccount__GetArenaLevelCost
		          (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *param1_00;
		  uint *puVar3;
		  
		  if (DAT_ram_00a588b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountData_TypeInfo);
		    DAT_ram_00a588b4 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x144));
		  if (iVar2 != 0) {
		    param1_00 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		                                 (param1,*(undefined4 *)(*param1 + 0x144));
		    uVar1 = 0;
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Data_Accounts_IAccountData_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)
		           ) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		          goto code_r0x80f3b27f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Data_Accounts_IAccountData_TypeInfo,2);
		code_r0x80f3b27f:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    if (iVar2 == 0) {
		      return *(undefined4 *)(param2 + 0x34);
		    }
		  }
		  return *(undefined4 *)(param2 + 0x24);
		}
		*/

			return null;
		}

		// Token: 0x0600569D RID: 22173 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600569D")]
		[Address(RVA = "0xA425", Offset = "0xA425", VA = "0xA425")]
		public ResourceSet GetMonsterAttackCost(MonsterDic monsterDic)
		{
		/* --- GHIDRA: GetMonsterAttackCost ---
		undefined4
		Gameplay_Accounts_Model_Data_BattleAccount__GetMonsterAttackCost
		          (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *param1_00;
		  uint *puVar3;
		  
		  if (DAT_ram_00a588b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountData_TypeInfo);
		    DAT_ram_00a588b4 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x144));
		  if (iVar2 != 0) {
		    param1_00 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		                                 (param1,*(undefined4 *)(*param1 + 0x144));
		    uVar1 = 0;
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Data_Accounts_IAccountData_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)
		           ) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		          goto code_r0x80f3b443;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Data_Accounts_IAccountData_TypeInfo,2);
		code_r0x80f3b443:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    if (iVar2 == 0) {
		      return *(undefined4 *)(param2 + 0x30);
		    }
		  }
		  return *(undefined4 *)(param2 + 0x2c);
		}
		*/

		/* --- GHIDRA: GetMonsterAttackCost ---
		undefined4
		Gameplay_Accounts_Model_Data_BattleAccount__GetMonsterAttackCost
		          (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *param1_00;
		  uint *puVar3;
		  
		  if (DAT_ram_00a588b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountData_TypeInfo);
		    DAT_ram_00a588b4 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x144));
		  if (iVar2 != 0) {
		    param1_00 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		                                 (param1,*(undefined4 *)(*param1 + 0x144));
		    uVar1 = 0;
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Data_Accounts_IAccountData_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)
		           ) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		          goto code_r0x80f3b443;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Data_Accounts_IAccountData_TypeInfo,2);
		code_r0x80f3b443:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    if (iVar2 == 0) {
		      return *(undefined4 *)(param2 + 0x30);
		    }
		  }
		  return *(undefined4 *)(param2 + 0x2c);
		}
		*/

			return null;
		}

		// Token: 0x0600569E RID: 22174 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600569E")]
		[Address(RVA = "0xA426", Offset = "0xA426", VA = "0xA426")]
		public ResourceSet GetMonsterAttackCost(MonsterHordesDic monsterHordeDic)
		{
			return null;
		}

		// Token: 0x0600569F RID: 22175 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600569F")]
		[Address(RVA = "0xA427", Offset = "0xA427", VA = "0xA427")]
		public ResourceSet GetMonsterKickCost(MonsterDic monsterDic)
		{
		/* --- GHIDRA: GetMonsterKickCost ---
		undefined4
		Gameplay_Accounts_Model_Data_BattleAccount__GetMonsterKickCost
		          (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *param1_00;
		  uint *puVar3;
		  
		  if (DAT_ram_00a588b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountData_TypeInfo);
		    DAT_ram_00a588b4 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x144));
		  if (iVar2 != 0) {
		    param1_00 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		                                 (param1,*(undefined4 *)(*param1 + 0x144));
		    uVar1 = 0;
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Data_Accounts_IAccountData_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)
		           ) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		          goto code_r0x80f3b525;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Data_Accounts_IAccountData_TypeInfo,2);
		code_r0x80f3b525:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    if (iVar2 == 0) {
		      return *(undefined4 *)(*(int *)(param2 + 0x6c) + 0x3c);
		    }
		  }
		  return *(undefined4 *)(*(int *)(param2 + 0x6c) + 0x2c);
		}
		*/

			return null;
		}

		// Token: 0x060056A0 RID: 22176 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60056A0")]
		[Address(RVA = "0xA428", Offset = "0xA428", VA = "0xA428")]
		public ResourceSet GetPartyCombatCost(UserData user)
		{
		/* --- GHIDRA: GetPartyCombatCost ---
		int Gameplay_Accounts_Model_Data_BattleAccount__GetPartyCombatCost
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  float8 fVar1;
		  int iVar2;
		  int iVar3;
		  double dVar4;
		  double dVar5;
		  double dVar6;
		  ulonglong uVar7;
		  float8 local_10;
		  float8 local_8;
		  
		  if (DAT_ram_00a588b8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    DAT_ram_00a588b8 = '\x01';
		  }
		  iVar2 = Gameplay_Accounts_Model_Data_AccountOptionData___ctor(param1,&local_10);
		  local_10 = *(float8 *)(iVar2 + 0x60);
		  iVar2 = System_Double__Equals(&local_10,1.0,0);
		  if (iVar2 == 0) {
		    iVar2 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		    iVar3 = Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__get_EventEntryAttempt(param2,0);
		    fVar1 = local_10;
		    dVar5 = *(double *)(iVar3 + 0x10);
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    *(double *)(iVar2 + 0x10) = CEIL(dVar5 * (double)fVar1);
		    iVar3 = Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__get_EventEntryAttempt(param2,0);
		    *(double *)(iVar2 + 0x18) = CEIL(*(double *)(iVar3 + 0x18) * (double)local_10);
		    iVar3 = Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__get_EventEntryAttempt(param2,0);
		    dVar6 = *(double *)(iVar3 + 0x20) * (double)local_10;
		    dVar4 = unnamed_function_4206(dVar6,&local_8);
		    dVar5 = (double)local_8;
		    if (0.0 <= dVar6) {
		      if (dVar4 == 0.5) {
		        if (ABS((double)local_8) < 9.223372036854776e+18) {
		          uVar7 = (ulonglong)(double)local_8;
		        }
		        else {
		          uVar7 = 0;
		        }
		        if ((uVar7 & 1) != 0) {
		          dVar5 = (double)local_8 + 1.0;
		        }
		      }
		      else {
		        dVar5 = FLOOR(dVar6 + 0.5);
		      }
		    }
		    else if (dVar4 == -0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar7 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar7 = 0;
		      }
		      if ((uVar7 & 1) != 0) {
		        dVar5 = (double)local_8 + -1.0;
		      }
		    }
		    else {
		      dVar5 = CEIL(dVar6 + -0.5);
		    }
		    *(double *)(iVar2 + 0x20) = dVar5;
		    iVar3 = Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__get_EventEntryAttempt(param2,0);
		    dVar6 = *(double *)(iVar3 + 0x30) * (double)local_10;
		    dVar4 = unnamed_function_4206(dVar6,&local_8);
		    dVar5 = (double)local_8;
		    if (0.0 <= dVar6) {
		      if (dVar4 == 0.5) {
		        if (ABS((double)local_8) < 9.223372036854776e+18) {
		          uVar7 = (ulonglong)(double)local_8;
		        }
		        else {
		          uVar7 = 0;
		        }
		        if ((uVar7 & 1) != 0) {
		          dVar5 = (double)local_8 + 1.0;
		        }
		      }
		      else {
		        dVar5 = FLOOR(dVar6 + 0.5);
		      }
		    }
		    else if (dVar4 == -0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar7 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar7 = 0;
		      }
		      if ((uVar7 & 1) != 0) {
		        dVar5 = (double)local_8 + -1.0;
		      }
		    }
		    else {
		      dVar5 = CEIL(dVar6 + -0.5);
		    }
		    *(double *)(iVar2 + 0x30) = dVar5;
		    iVar3 = Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__get_EventEntryAttempt(param2,0);
		    dVar4 = *(double *)(iVar3 + 0x28) * (double)local_10;
		    dVar5 = unnamed_function_4206(dVar4,&local_8);
		    if (0.0 <= dVar4) {
		      if (dVar5 == 0.5) {
		        if (ABS((double)local_8) < 9.223372036854776e+18) {
		          uVar7 = (ulonglong)(double)local_8;
		        }
		        else {
		          uVar7 = 0;
		        }
		        if ((uVar7 & 1) != 0) {
		          local_8 = (float8)((double)local_8 + 1.0);
		        }
		        *(float8 *)(iVar2 + 0x28) = local_8;
		      }
		      else {
		        *(double *)(iVar2 + 0x28) = FLOOR(dVar4 + 0.5);
		      }
		    }
		    else if (dVar5 == -0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar7 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar7 = 0;
		      }
		      if ((uVar7 & 1) != 0) {
		        local_8 = (float8)((double)local_8 + -1.0);
		      }
		      *(float8 *)(iVar2 + 0x28) = local_8;
		    }
		    else {
		      *(double *)(iVar2 + 0x28) = CEIL(dVar4 + -0.5);
		    }
		  }
		  else {
		    iVar2 = Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__get_EventEntryAttempt(param2,0);
		  }
		  return iVar2;
		}
		*/

			return null;
		}

		// Token: 0x060056A1 RID: 22177 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60056A1")]
		[Address(RVA = "0xA429", Offset = "0xA429", VA = "0xA429")]
		public ResourceSet GetThemeDuelCombatPrice(ThemeDuelStateModel themeDuelStateModel)
		{
		/* --- GHIDRA: GetThemeDuelCombatPrice ---
		undefined4
		Gameplay_Accounts_Model_Data_BattleAccount__GetThemeDuelCombatPrice
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  uint uVar3;
		  uint uVar4;
		  uint uVar5;
		  uint uVar6;
		  uint uVar7;
		  
		  if (DAT_ram_00a588b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_UserAccountLevelsDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_UserAccountLevelsDic__get_Item__);
		    DAT_ram_00a588b9 = '\x01';
		  }
		  uVar4 = *(uint *)(*(int *)(param1 + 0x18) + 0xc);
		  if ((int)uVar4 < 1) {
		    return 0;
		  }
		  do {
		    iVar2 = System_Linq_Enumerable__ToList_object_
		                      (*(undefined4 *)(param1 + 0x18),uVar4 - 1,
		                       Method_System_Collections_Generic_List_UserAccountLevelsDic__get_Item__);
		    uVar3 = Core_Data_UserData__set_LevelDic(param2,0);
		    uVar5 = *(uint *)(*(int *)(iVar2 + 0xc) + 0x14);
		    uVar6 = *(uint *)(*(int *)(iVar2 + 0xc) + 0x10);
		    uVar7 = uVar6;
		    if (uVar5 == 0) {
		      uVar7 = 0;
		    }
		    if (uVar7 == 0) {
		      if (uVar6 == 0) {
		        if (uVar5 != 0) goto joined_r0x80f3b98f;
		        if (uVar3 == 0) goto code_r0x80f3b9aa;
		      }
		      else if (uVar6 <= uVar3) goto code_r0x80f3b9aa;
		    }
		    else if (uVar6 <= uVar3) {
		joined_r0x80f3b98f:
		      if (uVar3 <= uVar5) {
		code_r0x80f3b9aa:
		        return *(undefined4 *)(iVar2 + 0x10);
		      }
		    }
		    bVar1 = uVar4 < 2;
		    uVar4 = uVar4 - 1;
		    if (bVar1) {
		      return 0;
		    }
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x060056A2 RID: 22178 RVA: 0x0000F900 File Offset: 0x0000DB00
		[Token(Token = "0x60056A2")]
		[Address(RVA = "0xA42A", Offset = "0xA42A", VA = "0xA42A")]
		public uint GetTurnTimeout(UserData user)
		{
		/* --- GHIDRA: GetTurnTimeout ---
		undefined4
		Gameplay_Accounts_Model_Data_BattleAccount__GetTurnTimeout(int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *param1_00;
		  uint *puVar3;
		  
		  if (DAT_ram_00a588b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountData_TypeInfo);
		    DAT_ram_00a588b4 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x144));
		  if (iVar2 != 0) {
		    param1_00 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		                                 (param1,*(undefined4 *)(*param1 + 0x144));
		    uVar1 = 0;
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Data_Accounts_IAccountData_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)
		           ) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		          goto code_r0x80f3ba87;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Data_Accounts_IAccountData_TypeInfo,2);
		code_r0x80f3ba87:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    if (iVar2 == 0) {
		      return *(undefined4 *)(param2 + 0x14);
		    }
		  }
		  return *(undefined4 *)(param2 + 0x10);
		}
		*/

			return 0U;
		}

		// Token: 0x060056A3 RID: 22179 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60056A3")]
		[Address(RVA = "0xA42B", Offset = "0xA42B", VA = "0xA42B")]
		public ResourceSet GetCaveVisitPrice(CaveLevelDic caveLevelDic)
		{
			return null;
		}

		// Token: 0x060056A4 RID: 22180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056A4")]
		[Address(RVA = "0xA42C", Offset = "0xA42C", VA = "0xA42C")]
		public BattleAccount()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Accounts_Model_Data_BattleAccount___ctor(undefined4 param1)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a588ba == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_BattleAccountCoefs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_BattleAccount_TypeInfo);
		    DAT_ram_00a588ba = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Protocol_Dic_BattleAccountCoefs_TypeInfo);
		  *(undefined8 *)(iVar1 + 0x48) = 0x3ff0000000000000;
		  *(undefined8 *)(iVar1 + 0x38) = 0x3ff0000000000000;
		  *(undefined8 *)(iVar1 + 0x40) = 0x3ff0000000000000;
		  *(undefined8 *)(iVar1 + 0x50) = 0x3ff0000000000000;
		  *(undefined8 *)(iVar1 + 0x28) = 0x3ff0000000000000;
		  *(undefined8 *)(iVar1 + 0x20) = 0x3ff0000000000000;
		  *(undefined8 *)(iVar1 + 0x58) = 0x3ff0000000000000;
		  *(undefined8 *)(iVar1 + 0x30) = 0x3ff0000000000000;
		  *(undefined8 *)(iVar1 + 0x18) = 0x3ff0000000000000;
		  *(undefined8 *)(iVar1 + 0x60) = 0x3ff0000000000000;
		  *(undefined8 *)(iVar1 + 0xc) = 0x100000001;
		  **(int **)(Gameplay_Accounts_Model_Data_BattleAccount_TypeInfo + 0x5c) = iVar1;
		  return;
		}
		*/

		}

		// Token: 0x04002EF6 RID: 12022
		[Token(Token = "0x4002EF6")]
		[FieldOffset(Offset = "0x1C")]
		private BattleAccountCoefs _battleAccountCoeffs;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_BattleAccountCoeffs ---
		undefined4 Gameplay_Accounts_Model_Data_BattleAccount__set_BattleAccountCoeffs(undefined4 param1)
		
		{
		  if (DAT_ram_00a588b7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_BattleAccount_TypeInfo);
		    DAT_ram_00a588b7 = '\x01';
		  }
		  if (*(int *)(Gameplay_Accounts_Model_Data_BattleAccount_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Accounts_Model_Data_BattleAccount_TypeInfo);
		  }
		  return **(undefined4 **)(Gameplay_Accounts_Model_Data_BattleAccount_TypeInfo + 0x5c);
		}
		*/


		/* --- GHIDRA: get_BattleAccountCoeffsOneValue ---
		void Gameplay_Accounts_Model_Data_BattleAccount__get_BattleAccountCoeffsOneValue
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  
		  Core_Data_Accounts_UserAccount__get_Title(param1,param2,param3,param4,0);
		  uVar1 = Core_Extensions_Dict_DictExt__GetUIResourceAssetId(param3,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  return;
		}
		*/

}
