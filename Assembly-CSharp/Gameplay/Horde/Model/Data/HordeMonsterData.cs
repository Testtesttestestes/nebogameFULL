using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Il2CppDummyDll;
using Protocol.Dic;
using Protocol.World;

namespace Gameplay.Horde.Model.Data
{
	// Token: 0x02000700 RID: 1792
	[Token(Token = "0x2000700")]
	public class HordeMonsterData
	{
		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06002AE8 RID: 10984 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002AE9 RID: 10985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000828")]
		public MonsterData MonsterData
		{
			[Token(Token = "0x6002AE8")]
			[Address(RVA = "0x7B83", Offset = "0x7B83", VA = "0x7B83")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AE9")]
			[Address(RVA = "0x7B84", Offset = "0x7B84", VA = "0x7B84")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06002AEA RID: 10986 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002AEB RID: 10987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000829")]
		public MonsterHordesDic HordeMonsterDic
		{
			[Token(Token = "0x6002AEA")]
			[Address(RVA = "0x7B85", Offset = "0x7B85", VA = "0x7B85")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AEB")]
			[Address(RVA = "0x7B86", Offset = "0x7B86", VA = "0x7B86")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002AEC RID: 10988 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002AEC")]
		[Address(RVA = "0x7B87", Offset = "0x7B87", VA = "0x7B87")]
		public static HordeMonsterData Create(MonsterInfo monsterInfo, IDictProvider dict)
		{
		/* --- GHIDRA: Create ---
		int Gameplay_Horde_Model_Data_HordeMonsterData__Create
		              (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  uint *puVar6;
		  
		  if (DAT_ram_00a5a206 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ArtikulStackSize___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ArtikulStackSize_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Horde_Model_Data_HordeMonsterData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_MonsterData_TypeInfo);
		    DAT_ram_00a5a206 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Gameplay_Horde_Model_Data_HordeMonsterData_TypeInfo);
		  iVar3 = Mono_Security_ASN1Convert__ToOid(Protocol_Common_ArtikulStackSize___TypeInfo,1);
		  iVar4 = unnamed_function_1417(Protocol_Common_ArtikulStackSize_TypeInfo);
		  *(undefined8 *)(iVar4 + 0xc) = 0xffffffffffffffff;
		  *(int *)(iVar3 + 0x10) = iVar4;
		  if (*(int *)(Core_Data_MonsterData_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Data_MonsterData_TypeInfo);
		  }
		  uVar1 = 0;
		  uVar5 = Core_Data_MonsterData__Create(param1,iVar3,param2,0);
		  *(undefined4 *)(iVar2 + 8) = uVar5;
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x811e7698;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar6 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811e7698:
		  uVar5 = (**(code **)((ulonglong)*puVar6 * 4))(param2,puVar6[1]);
		  uVar5 = Core_Extensions_Dict_DictExt__TryGetHordeDic(uVar5,param1,0);
		  *(undefined4 *)(iVar2 + 0xc) = uVar5;
		  return iVar2;
		}
		*/

		/* --- GHIDRA: Create ---
		int Gameplay_Horde_Model_Data_HordeMonsterData__Create
		              (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  uint *puVar6;
		  
		  if (DAT_ram_00a5a206 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ArtikulStackSize___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ArtikulStackSize_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Horde_Model_Data_HordeMonsterData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_MonsterData_TypeInfo);
		    DAT_ram_00a5a206 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Gameplay_Horde_Model_Data_HordeMonsterData_TypeInfo);
		  iVar3 = Mono_Security_ASN1Convert__ToOid(Protocol_Common_ArtikulStackSize___TypeInfo,1);
		  iVar4 = unnamed_function_1417(Protocol_Common_ArtikulStackSize_TypeInfo);
		  *(undefined8 *)(iVar4 + 0xc) = 0xffffffffffffffff;
		  *(int *)(iVar3 + 0x10) = iVar4;
		  if (*(int *)(Core_Data_MonsterData_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Data_MonsterData_TypeInfo);
		  }
		  uVar1 = 0;
		  uVar5 = Core_Data_MonsterData__Create(param1,iVar3,param2,0);
		  *(undefined4 *)(iVar2 + 8) = uVar5;
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x811e7698;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar6 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811e7698:
		  uVar5 = (**(code **)((ulonglong)*puVar6 * 4))(param2,puVar6[1]);
		  uVar5 = Core_Extensions_Dict_DictExt__TryGetHordeDic(uVar5,param1,0);
		  *(undefined4 *)(iVar2 + 0xc) = uVar5;
		  return iVar2;
		}
		*/

		/* --- GHIDRA: Create ---
		int Gameplay_Horde_Model_Data_HordeMonsterData__Create
		              (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  uint *puVar6;
		  
		  if (DAT_ram_00a5a206 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ArtikulStackSize___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ArtikulStackSize_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Horde_Model_Data_HordeMonsterData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_MonsterData_TypeInfo);
		    DAT_ram_00a5a206 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Gameplay_Horde_Model_Data_HordeMonsterData_TypeInfo);
		  iVar3 = Mono_Security_ASN1Convert__ToOid(Protocol_Common_ArtikulStackSize___TypeInfo,1);
		  iVar4 = unnamed_function_1417(Protocol_Common_ArtikulStackSize_TypeInfo);
		  *(undefined8 *)(iVar4 + 0xc) = 0xffffffffffffffff;
		  *(int *)(iVar3 + 0x10) = iVar4;
		  if (*(int *)(Core_Data_MonsterData_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Data_MonsterData_TypeInfo);
		  }
		  uVar1 = 0;
		  uVar5 = Core_Data_MonsterData__Create(param1,iVar3,param2,0);
		  *(undefined4 *)(iVar2 + 8) = uVar5;
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x811e7698;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar6 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811e7698:
		  uVar5 = (**(code **)((ulonglong)*puVar6 * 4))(param2,puVar6[1]);
		  uVar5 = Core_Extensions_Dict_DictExt__TryGetHordeDic(uVar5,param1,0);
		  *(undefined4 *)(iVar2 + 0xc) = uVar5;
		  return iVar2;
		}
		*/

			return null;
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002AED")]
		[Address(RVA = "0x7B88", Offset = "0x7B88", VA = "0x7B88")]
		public static HordeMonsterData Create(uint monsterId, IDictProvider dict)
		{
			return null;
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002AEE")]
		[Address(RVA = "0x7B89", Offset = "0x7B89", VA = "0x7B89")]
		public static HordeMonsterData Create(MonsterHordesDic monster, IDictProvider dict)
		{
			return null;
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AEF")]
		[Address(RVA = "0x7B8A", Offset = "0x7B8A", VA = "0x7B8A")]
		public HordeMonsterData()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_HordeMonsterDic ---
		int Gameplay_Horde_Model_Data_HordeMonsterData__set_HordeMonsterDic
		              (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a205 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Horde_Model_Data_HordeMonsterData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_MonsterData_TypeInfo);
		    DAT_ram_00a5a205 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Gameplay_Horde_Model_Data_HordeMonsterData_TypeInfo);
		  if (*(int *)(Core_Data_MonsterData_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Data_MonsterData_TypeInfo);
		  }
		  uVar1 = 0;
		  uVar3 = Core_Data_MonsterData__GetDifficultyLocaleKey(param1,param2,0);
		  *(undefined4 *)(iVar2 + 8) = uVar3;
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x811e744d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811e744d:
		  uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(param2,puVar4[1]);
		  uVar3 = Core_Extensions_Dict_DictExt__TryGetHordeDic(uVar3,*(undefined4 *)(param1 + 0xc),0);
		  *(undefined4 *)(iVar2 + 0xc) = uVar3;
		  return iVar2;
		}
		*/

}
