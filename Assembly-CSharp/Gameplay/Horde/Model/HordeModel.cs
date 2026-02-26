using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Core.Gameplay.Managers.Inventory;
using Gameplay.Accounts.Model;
using Gameplay.Horde.Model.Data;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.World;

namespace Gameplay.Horde.Model
{
	// Token: 0x020006FF RID: 1791
	[Token(Token = "0x20006FF")]
	public class HordeModel : AbstractModel
	{
		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06002ADD RID: 10973 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002ADE RID: 10974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000824")]
		public HordeDic Dic
		{
			[Token(Token = "0x6002ADD")]
			[Address(RVA = "0x7B78", Offset = "0x7B78", VA = "0x7B78")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002ADE")]
			[Address(RVA = "0x7B79", Offset = "0x7B79", VA = "0x7B79")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06002ADF RID: 10975 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002AE0 RID: 10976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000825")]
		public HordeMonsterData[] Monsters
		{
			[Token(Token = "0x6002ADF")]
			[Address(RVA = "0x7B7A", Offset = "0x7B7A", VA = "0x7B7A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AE0")]
			[Address(RVA = "0x7B7B", Offset = "0x7B7B", VA = "0x7B7B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06002AE1 RID: 10977 RVA: 0x00008640 File Offset: 0x00006840
		// (set) Token: 0x06002AE2 RID: 10978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000826")]
		public uint MainMonsterId
		{
			[Token(Token = "0x6002AE1")]
			[Address(RVA = "0x7B7C", Offset = "0x7B7C", VA = "0x7B7C")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002AE2")]
			[Address(RVA = "0x7B7D", Offset = "0x7B7D", VA = "0x7B7D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06002AE3 RID: 10979 RVA: 0x00008658 File Offset: 0x00006858
		// (set) Token: 0x06002AE4 RID: 10980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000827")]
		public int CurrentMonsterIndex
		{
			[Token(Token = "0x6002AE3")]
			[Address(RVA = "0x7B7E", Offset = "0x7B7E", VA = "0x7B7E")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002AE4")]
			[Address(RVA = "0x7B7F", Offset = "0x7B7F", VA = "0x7B7F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AE5")]
		[Address(RVA = "0x7B80", Offset = "0x7B80", VA = "0x7B80")]
		public HordeModel(IGame game, IDictProvider dictProviderProvider, InventoryManager userInventory, AccountsModel accounts, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Horde_Model_HordeModel___ctor(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a203 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_MonsterInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_MonsterInfo__TypeInfo);
		    DAT_ram_00a5a203 = '\x01';
		  }
		  local_4 = 0;
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IList_MonsterInfo__TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811e6ed3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_IList_MonsterInfo__TypeInfo,0);
		code_r0x811e6ed3:
		  uVar1 = 0;
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param2,0,puVar2[1]);
		  *(undefined4 *)(param1 + 0x24) = *(undefined4 *)(iVar5 + 0xc);
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_MonsterInfo__TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811e6f5f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_ICollection_MonsterInfo__TypeInfo,
		                                0);
		code_r0x811e6f5f:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  *(int *)(param1 + 0x28) = iVar5 + -1;
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x10);
		  iVar5 = *piVar6;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x811e6fe4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811e6fe4:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  uVar3 = Core_Extensions_Dict_DictExt__GetHordeMonsterDic(uVar3,*(undefined4 *)(param1 + 0x24),0);
		  uVar1 = 0;
		  Gameplay_Horde_Model_HordeModel__PopulateHordeMonsters(param1,param2,uVar3,0);
		  piVar6 = *(int **)(param1 + 0x10);
		  iVar5 = *piVar6;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x811e707a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811e707a:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  iVar5 = Core_Extensions_Dict_DictExt__GetDismantleInfoDic
		                    (uVar3,*(undefined4 *)(param1 + 0x24),&local_4,0);
		  if (iVar5 == 0) {
		    local_8 = *(undefined4 *)(param1 + 0x24);
		    uVar3 = func_ii_1081(DAT_ram_00a66958,&local_8);
		    uVar4 = unnamed_function_2232(&StringLiteral_8878);
		    uVar3 = func_ii_4419(uVar4,uVar3,0);
		    uVar4 = unnamed_function_2232(&System_Exception_TypeInfo);
		    uVar4 = unnamed_function_1417(uVar4);
		    System_String__Concat(uVar4,uVar3,0);
		    uVar3 = unnamed_function_2232(&Method_Gameplay_Horde_Model_HordeModel_PopulateHordeMonsters__);
		    func_ii_1050(uVar4,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(undefined4 *)(param1 + 0x1c) = local_4;
		  return;
		}
		*/

		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AE6")]
		[Address(RVA = "0x7B81", Offset = "0x7B81", VA = "0x7B81")]
		public void PopulateHordeMonsters(IList<MonsterInfo> monsterInfos)
		{
		/* --- GHIDRA: PopulateHordeMonsters ---
		void Gameplay_Horde_Model_HordeModel__PopulateHordeMonsters
		               (int param1,int *param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  int *piVar8;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a5a204 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Horde_Model_Data_HordeMonsterData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_MonsterInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_MonsterInfo__TypeInfo);
		    DAT_ram_00a5a204 = '\x01';
		  }
		  uVar2 = Mono_Security_ASN1Convert__ToOid
		                    (Gameplay_Horde_Model_Data_HordeMonsterData___TypeInfo,
		                     *(undefined4 *)(param3 + 0xc));
		  *(undefined4 *)(param1 + 0x20) = uVar2;
		  do {
		    iVar5 = *param2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_ICollection_MonsterInfo__TypeInfo == *piVar7) {
		          puVar3 = (uint *)(iVar5 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x811e71bb;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_ICollection_MonsterInfo__TypeInfo,0);
		code_r0x811e71bb:
		    iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		    if (iVar5 <= iVar6) {
		      uVar1 = 0;
		      iVar6 = *param2;
		      if (*(ushort *)(iVar6 + 0xb6) == 0) goto code_r0x811e72eb;
		      break;
		    }
		    piVar7 = *(int **)(param1 + 0x20);
		    iVar5 = *param2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IList_MonsterInfo__TypeInfo == *piVar8) {
		          puVar3 = (uint *)(iVar5 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x811e7241;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,System_Collections_Generic_IList_MonsterInfo__TypeInfo,0);
		code_r0x811e7241:
		    uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param2,iVar6,puVar3[1]);
		    iVar5 = Gameplay_Horde_Model_Data_HordeMonsterData__set_HordeMonsterDic
		                      (uVar2,*(undefined4 *)(param1 + 0x10),puVar3);
		    if ((iVar5 != 0) && (iVar4 = func_ii_1082(iVar5,*(undefined4 *)(*piVar7 + 0x20)), iVar4 == 0)) {
		      uVar2 = func_ii_1083();
		      func_ii_1050(uVar2,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar7[iVar6 + 4] = iVar5;
		    iVar6 = iVar6 + 1;
		  } while( true );
		  while (uVar1 = uVar1 + 1, *(ushort *)(iVar6 + 0xb6) != uVar1) {
		    if (System_Collections_Generic_ICollection_MonsterInfo__TypeInfo ==
		        *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		      puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		      goto code_r0x811e72f5;
		    }
		  }
		code_r0x811e72eb:
		  puVar3 = (uint *)func_ii_1080(param2,System_Collections_Generic_ICollection_MonsterInfo__TypeInfo,
		                                0);
		code_r0x811e72f5:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  piVar7 = *(int **)(param1 + 0x20);
		  if (iVar6 < piVar7[3]) {
		    do {
		      iVar5 = Gameplay_Horde_Model_Data_HordeMonsterData__Create
		                        (*(undefined4 *)(param3 + iVar6 * 4 + 0x10),*(undefined4 *)(param1 + 0x10),
		                         iVar6);
		      if ((iVar5 != 0) && (iVar4 = func_ii_1082(iVar5,*(undefined4 *)(*piVar7 + 0x20)), iVar4 == 0))
		      {
		        uVar2 = func_ii_1083();
		        func_ii_1050(uVar2,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar7[iVar6 + 4] = iVar5;
		      iVar6 = iVar6 + 1;
		      piVar7 = *(int **)(param1 + 0x20);
		    } while (iVar6 < piVar7[3]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AE7")]
		[Address(RVA = "0x7B82", Offset = "0x7B82", VA = "0x7B82")]
		private void PopulateMonstersData(IList<MonsterInfo> monsterInfos, MonsterHordesDic[] monsterDics)
		{
		}

		// Token: 0x0400176F RID: 5999
		[Token(Token = "0x400176F")]
		[FieldOffset(Offset = "0xC")]
		public readonly IGame Game;

		// Token: 0x04001770 RID: 6000
		[Token(Token = "0x4001770")]
		[FieldOffset(Offset = "0x10")]
		public readonly IDictProvider DictProvider;

		// Token: 0x04001771 RID: 6001
		[Token(Token = "0x4001771")]
		[FieldOffset(Offset = "0x14")]
		public readonly AccountsModel Accounts;

		// Token: 0x04001772 RID: 6002
		[Token(Token = "0x4001772")]
		[FieldOffset(Offset = "0x18")]
		public readonly InventoryManager UserInventory;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_CurrentMonsterIndex ---
		void Gameplay_Horde_Model_HordeModel__set_CurrentMonsterIndex
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param6,0);
		  *(undefined4 *)(param1 + 0x18) = param4;
		  *(undefined4 *)(param1 + 0x14) = param5;
		  *(undefined4 *)(param1 + 0x10) = param3;
		  *(undefined4 *)(param1 + 0xc) = param2;
		  return;
		}
		*/

}
