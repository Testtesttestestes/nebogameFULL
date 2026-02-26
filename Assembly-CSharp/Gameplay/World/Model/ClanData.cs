using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;

namespace Gameplay.World.Model
{
	// Token: 0x02000364 RID: 868
	[Token(Token = "0x2000364")]
	public class ClanData : ClanData.IManagedClanData
	{
		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060013F3 RID: 5107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000331")]
		public ClanCultDic ClanCultDic
		{
			[Token(Token = "0x60013F2")]
			[Address(RVA = "0x65D0", Offset = "0x65D0", VA = "0x65D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013F3")]
			[Address(RVA = "0x65D1", Offset = "0x65D1", VA = "0x65D1")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x00004C98 File Offset: 0x00002E98
		[Token(Token = "0x17000332")]
		public ulong ClanId
		{
			[Token(Token = "0x60013F4")]
			[Address(RVA = "0x65D2", Offset = "0x65D2", VA = "0x65D2")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060013F6 RID: 5110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000333")]
		public UserData HeadUser
		{
			[Token(Token = "0x60013F5")]
			[Address(RVA = "0x65D3", Offset = "0x65D3", VA = "0x65D3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013F6")]
			[Address(RVA = "0x65D4", Offset = "0x65D4", VA = "0x65D4")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060013F8 RID: 5112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000334")]
		public UserData Golem
		{
			[Token(Token = "0x60013F7")]
			[Address(RVA = "0x65D5", Offset = "0x65D5", VA = "0x65D5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013F8")]
			[Address(RVA = "0x65D6", Offset = "0x65D6", VA = "0x65D6")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060013FA RID: 5114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000335")]
		public ClanInfo ClanInfo
		{
			[Token(Token = "0x60013F9")]
			[Address(RVA = "0x65D7", Offset = "0x65D7", VA = "0x65D7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013FA")]
			[Address(RVA = "0x65D8", Offset = "0x65D8", VA = "0x65D8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060013FC RID: 5116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000336")]
		public ClanLeagueDic ClanLeagueDic
		{
			[Token(Token = "0x60013FB")]
			[Address(RVA = "0x65D9", Offset = "0x65D9", VA = "0x65D9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013FC")]
			[Address(RVA = "0x65DA", Offset = "0x65DA", VA = "0x65DA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000337")]
		public ClanCurseData[] Restrictions
		{
			[Token(Token = "0x60013FD")]
			[Address(RVA = "0x65DB", Offset = "0x65DB", VA = "0x65DB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x00004CB0 File Offset: 0x00002EB0
		[Token(Token = "0x17000338")]
		public bool IsFraction
		{
			[Token(Token = "0x60013FE")]
			[Address(RVA = "0x65DC", Offset = "0x65DC", VA = "0x65DC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x00004CC8 File Offset: 0x00002EC8
		[Token(Token = "0x17000339")]
		public bool IsLeftHandClan
		{
			[Token(Token = "0x60013FF")]
			[Address(RVA = "0x65DD", Offset = "0x65DD", VA = "0x65DD")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x00004CE0 File Offset: 0x00002EE0
		[Token(Token = "0x1700033A")]
		public bool IsRightHandClan
		{
			[Token(Token = "0x6001400")]
			[Address(RVA = "0x65DE", Offset = "0x65DE", VA = "0x65DE")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x00004CF8 File Offset: 0x00002EF8
		[Token(Token = "0x1700033B")]
		public bool HasCreditDebt
		{
			[Token(Token = "0x6001401")]
			[Address(RVA = "0x65DF", Offset = "0x65DF", VA = "0x65DF")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001402")]
		[Address(RVA = "0x65E0", Offset = "0x65E0", VA = "0x65E0")]
		private ClanData()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_World_Model_ClanData___ctor(int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  uint param2_01;
		  uint uVar3;
		  uint uVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a58c7c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_ClanRestrictionInfo__ClanCurseData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ClanCurseData___);
		    Mono_Security_ASN1__get_Item(&System_Func_ClanRestrictionInfo__ClanCurseData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_World_Model_ClanData___c__DisplayClass36_0__Gameplay_World_Model_ClanData_IManagedClanData_SetClanInfo_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Model_ClanData___c__DisplayClass36_0_TypeInfo);
		    DAT_ram_00a58c7c = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Gameplay_World_Model_ClanData___c__DisplayClass36_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param3;
		  uVar4 = *(uint *)(param2 + 0x1c);
		  uVar3 = 0x66;
		  if (uVar4 < 4) {
		    uVar3 = uVar4;
		  }
		  uVar5 = *(uint *)(param2 + 0x20) & 1;
		  if (uVar5 == 0) {
		    uVar3 = uVar4;
		  }
		  param2_01 = 0x65;
		  if (3 < uVar4) {
		    param2_01 = uVar3;
		  }
		  if (uVar5 == 0) {
		    param2_01 = uVar3;
		  }
		  uVar1 = Core_Extensions_Dict_DictExt__GetCult(param3,param2_01,0);
		  uVar2 = Core_Extensions_Dict_DictExt__GetAllArtikulTypeMetaFilterByType
		                    (*(undefined4 *)(param2_00 + 8),*(undefined4 *)(param2 + 0x1c),0);
		  *(int *)(param1 + 0x1c) = param2;
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  *(undefined4 *)(param1 + 8) = uVar2;
		  uVar1 = Core_Extensions_Dict_DictExt__GetClanPrizesByKindId
		                    (*(undefined4 *)(param2_00 + 8),*(undefined4 *)(*(int *)(param2 + 0x3c) + 0xc),0
		                    );
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  uVar2 = *(undefined4 *)(param2 + 0x44);
		  uVar1 = unnamed_function_1417(System_Func_ClanRestrictionInfo__ClanCurseData__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param2_00,
		             Method_Gameplay_World_Model_ClanData___c__DisplayClass36_0__Gameplay_World_Model_ClanData_IManagedClanData_SetClanInfo_b__0__
		             ,0);
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar2,uVar1,
		                     Method_System_Linq_Enumerable_Select_ClanRestrictionInfo__ClanCurseData___);
		  uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_ClanCurseData___);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06001403 RID: 5123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001403")]
		[Address(RVA = "0x65E1", Offset = "0x65E1", VA = "0x65E1", Slot = "4")]
		private void SetClanInfo(ClanInfo clanInfo, Dictionaries dictionaries)
		{
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001404")]
		[Address(RVA = "0x1C9E", Offset = "0x1C9E", VA = "0x1C9E")]
		public static ClanData Create(ClanInfo clanInfo, Dictionaries dictionaries)
		{
		/* --- GHIDRA: Create ---
		void Gameplay_World_Model_ClanData__Create(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Isles_User_Model_UserIsleModel__get_IsleInformation(uVar1,param2,0);
		  Gameplay_Isles_User_Controller_UserIsleController__OnMonsterChangedEvent(param1,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = Gameplay_Isles_User_Model_UserIsleAccountMarkerData__Create(uVar1,0);
		  *(undefined4 *)(iVar2 + 0x50) = uVar1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x1c);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x00004D10 File Offset: 0x00002F10
		[Token(Token = "0x6001405")]
		[Address(RVA = "0x65E2", Offset = "0x65E2", VA = "0x65E2")]
		public uint ClearTreasuryFlag(uint flag)
		{
		/* --- GHIDRA: ClearTreasuryFlag ---
		uint Gameplay_World_Model_ClanData__ClearTreasuryFlag(int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = 0;
		  if ((*(byte *)(*(int *)(param1 + 0x1c) + 0x20) & 1) != 0) {
		    iVar1 = *(int *)(param1 + 0x10);
		  }
		  *param2 = iVar1;
		  return (uint)(iVar1 != 0);
		}
		*/

			return 0U;
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x00004D28 File Offset: 0x00002F28
		[Token(Token = "0x6001406")]
		[Address(RVA = "0x65E3", Offset = "0x65E3", VA = "0x65E3")]
		public bool TryGetFractionCultDic(out ClanCultDic dic)
		{
		/* --- GHIDRA: TryGetFractionCultDic ---
		uint Gameplay_World_Model_ClanData__TryGetFractionCultDic
		               (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  *param2 = *(undefined4 *)(param1 + 8);
		  return (uint)(*(int *)(param1 + 8) != 0);
		}
		*/

			return default(bool);
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x00004D40 File Offset: 0x00002F40
		[Token(Token = "0x6001407")]
		[Address(RVA = "0x65E4", Offset = "0x65E4", VA = "0x65E4")]
		public bool TryGetCultDic(out CultDic dic)
		{
		/* --- GHIDRA: TryGetCultDic ---
		uint Gameplay_World_Model_ClanData__TryGetCultDic(int param1,uint param2,undefined4 param3)
		
		{
		  uint uVar1;
		  
		  uVar1 = *(uint *)(*(int *)(param1 + 0x1c) + 0x1c);
		  if (uVar1 == param2) {
		    uVar1 = 1;
		  }
		  else if ((*(byte *)(*(int *)(param1 + 0x1c) + 0x20) & 1) == 0) {
		    uVar1 = 0;
		  }
		  else {
		    uVar1 = (uint)(uVar1 < 4 != 3 < param2);
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x00004D58 File Offset: 0x00002F58
		[Token(Token = "0x6001408")]
		[Address(RVA = "0x65E5", Offset = "0x65E5", VA = "0x65E5")]
		public bool ContainsCult(uint cultId)
		{
		/* --- GHIDRA: ContainsCult ---
		undefined4 Gameplay_World_Model_ClanData__ContainsCult(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if ((*(byte *)(*(int *)(param1 + 0x1c) + 0x20) & 1) == 0) {
		    uVar1 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription
		                      (*(undefined4 *)(param1 + 8),0);
		    return uVar1;
		  }
		  uVar1 = Core_Extensions_Dict_ClanBuildingViewDicExt__GetIsleViewAssetId
		                    (*(undefined4 *)(param1 + 0x10),0);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001409")]
		[Address(RVA = "0x65E6", Offset = "0x65E6", VA = "0x65E6")]
		public string GetClanCultIconAssetId()
		{
		/* --- GHIDRA: GetClanCultIconAssetId ---
		undefined4
		Gameplay_World_Model_ClanData__GetClanCultIconAssetId
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetClanLeagueDic(param3,param2,0);
		  return *(undefined4 *)(iVar1 + 0x10);
		}
		*/

			return null;
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600140A")]
		[Address(RVA = "0x65E7", Offset = "0x65E7", VA = "0x65E7")]
		public ResourceSet GetJoinPrice(uint zigguratLevel, Dictionaries dict)
		{
		/* --- GHIDRA: GetJoinPrice ---
		uint Gameplay_World_Model_ClanData__GetJoinPrice(uint param1,undefined4 param2)
		
		{
		  return param1 & 1;
		}
		*/

			return null;
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x00004D70 File Offset: 0x00002F70
		[Token(Token = "0x600140B")]
		[Address(RVA = "0x65E8", Offset = "0x65E8", VA = "0x65E8")]
		public static bool GetIsFraction(uint flags)
		{
		/* --- GHIDRA: GetIsFraction ---
		uint Gameplay_World_Model_ClanData__GetIsFraction(uint param1,uint param2,undefined4 param3)
		
		{
		  return param1 & 3 < param2;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x00004D88 File Offset: 0x00002F88
		[Token(Token = "0x600140C")]
		[Address(RVA = "0x65E9", Offset = "0x65E9", VA = "0x65E9")]
		public static bool GetIsLeftHandClan(uint flags, uint cultId)
		{
		/* --- GHIDRA: GetIsLeftHandClan ---
		uint Gameplay_World_Model_ClanData__GetIsLeftHandClan(uint param1,uint param2,undefined4 param3)
		
		{
		  return param1 & param2 < 4;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x00004DA0 File Offset: 0x00002FA0
		[Token(Token = "0x600140D")]
		[Address(RVA = "0x65EA", Offset = "0x65EA", VA = "0x65EA")]
		public static bool GetIsRightHandClan(uint flags, uint cultId)
		{
		/* --- GHIDRA: GetIsRightHandClan ---
		uint Gameplay_World_Model_ClanData__GetIsRightHandClan(uint param1,undefined4 param2)
		
		{
		  return (uint)(3 < param1);
		}
		*/

			return default(bool);
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x00004DB8 File Offset: 0x00002FB8
		[Token(Token = "0x600140E")]
		[Address(RVA = "0x65EB", Offset = "0x65EB", VA = "0x65EB")]
		public static bool IsPartOfLeftHandClan(uint cultId)
		{
		/* --- GHIDRA: IsPartOfLeftHandClan ---
		uint Gameplay_World_Model_ClanData__IsPartOfLeftHandClan(uint param1,undefined4 param2)
		
		{
		  return (uint)(param1 < 4);
		}
		*/

			return default(bool);
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x00004DD0 File Offset: 0x00002FD0
		[Token(Token = "0x600140F")]
		[Address(RVA = "0x65EC", Offset = "0x65EC", VA = "0x65EC")]
		public static bool IsPartOfRightHandClan(uint cultId)
		{
		/* --- GHIDRA: IsPartOfRightHandClan ---
		void Gameplay_World_Model_ClanData__IsPartOfRightHandClan(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58c7e == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Model_ClanData___c_TypeInfo);
		    DAT_ram_00a58c7e = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_World_Model_ClanData___c_TypeInfo);
		  **(undefined4 **)(Gameplay_World_Model_ClanData___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x04000AB7 RID: 2743
		[Token(Token = "0x4000AB7")]
		[FieldOffset(Offset = "0x8")]
		private CultDic _cultDic;

		// Token: 0x04000AB8 RID: 2744
		[Token(Token = "0x4000AB8")]
		[FieldOffset(Offset = "0xC")]
		private ClanCurseData[] _restrictions;

		// Token: 0x02000365 RID: 869
		[Token(Token = "0x2000365")]
		public interface IManagedClanData
		{
			// Token: 0x06001410 RID: 5136
			[Token(Token = "0x6001410")]
			void SetClanInfo(ClanInfo clanInfo, Dictionaries dictionaries);
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_ClanCultDic ---
		undefined8 Gameplay_World_Model_ClanData__set_ClanCultDic(int param1,undefined4 param2)
		
		{
		  return *(undefined8 *)(*(int *)(param1 + 0x1c) + 0x10);
		}
		*/


		/* --- GHIDRA: set_ClanLeagueDic ---
		undefined4 Gameplay_World_Model_ClanData__set_ClanLeagueDic(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a58c7b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_ClanCurseData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ClanCurseData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_ClanCurseData___);
		    Mono_Security_ASN1__get_Item(&System_Func_ClanCurseData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Model_ClanData___c__get_Restrictions_b__26_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Model_ClanData___c__get_Restrictions_b__26_1__);
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Model_ClanData___c_TypeInfo);
		    DAT_ram_00a58c7b = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0xc);
		  if (*(int *)(Gameplay_World_Model_ClanData___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_World_Model_ClanData___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_World_Model_ClanData___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[1];
		  if (iVar3 == 0) {
		    if (*(int *)(Gameplay_World_Model_ClanData___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_World_Model_ClanData___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_World_Model_ClanData___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Func_ClanCurseData__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar3,uVar4,Method_Gameplay_World_Model_ClanData___c__get_Restrictions_b__26_0__,0);
		    *(int *)(*(int *)(Gameplay_World_Model_ClanData___c_TypeInfo + 0x5c) + 4) = iVar3;
		  }
		  iVar3 = Newtonsoft_Json_Utilities_ReflectionUtils__IsOverridenGenericMember
		                    (uVar1,iVar3,Method_System_Linq_Enumerable_Any_ClanCurseData___);
		  uVar1 = *(undefined4 *)(param1 + 0xc);
		  if (iVar3 != 0) {
		    if (*(int *)(Gameplay_World_Model_ClanData___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_World_Model_ClanData___c_TypeInfo);
		    }
		    puVar2 = *(undefined4 **)(Gameplay_World_Model_ClanData___c_TypeInfo + 0x5c);
		    iVar3 = puVar2[2];
		    if (iVar3 == 0) {
		      if (*(int *)(Gameplay_World_Model_ClanData___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_World_Model_ClanData___c_TypeInfo);
		        puVar2 = *(undefined4 **)(Gameplay_World_Model_ClanData___c_TypeInfo + 0x5c);
		      }
		      uVar4 = *puVar2;
		      iVar3 = unnamed_function_1417(System_Func_ClanCurseData__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (iVar3,uVar4,Method_Gameplay_World_Model_ClanData___c__get_Restrictions_b__26_1__,0)
		      ;
		      *(int *)(*(int *)(Gameplay_World_Model_ClanData___c_TypeInfo + 0x5c) + 8) = iVar3;
		    }
		    uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                      (uVar1,iVar3,Method_System_Linq_Enumerable_Where_ClanCurseData___);
		    uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_ClanCurseData___);
		    *(undefined4 *)(param1 + 0xc) = uVar1;
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_Restrictions ---
		uint Gameplay_World_Model_ClanData__get_Restrictions(int param1,undefined4 param2)
		
		{
		  return *(uint *)(*(int *)(param1 + 0x1c) + 0x20) & 1;
		}
		*/


		/* --- GHIDRA: get_IsFraction ---
		uint Gameplay_World_Model_ClanData__get_IsFraction(int param1,undefined4 param2)
		
		{
		  return (uint)(*(byte *)(*(int *)(param1 + 0x1c) + 0x20) &
		               3 < *(uint *)(*(int *)(param1 + 0x1c) + 0x1c));
		}
		*/


		/* --- GHIDRA: get_IsLeftHandClan ---
		uint Gameplay_World_Model_ClanData__get_IsLeftHandClan(int param1,undefined4 param2)
		
		{
		  return (uint)(*(byte *)(*(int *)(param1 + 0x1c) + 0x20) &
		               *(uint *)(*(int *)(param1 + 0x1c) + 0x1c) < 4);
		}
		*/


		/* --- GHIDRA: get_IsRightHandClan ---
		uint Gameplay_World_Model_ClanData__get_IsRightHandClan(int param1,undefined4 param2)
		
		{
		  return (*(byte *)(*(int *)(param1 + 0x1c) + 0x2c) & 2) >> 1;
		}
		*/


		/* --- GHIDRA: Gameplay.World.Model.ClanData.IManagedClanData.SetClanInfo ---
		uint Gameplay_World_Model_ClanData__Gameplay_World_Model_ClanData_IManagedClanData_SetClanInfo
		               (int param1,uint param2,undefined4 param3)
		
		{
		  uint uVar1;
		  
		  uVar1 = *(uint *)(*(int *)(param1 + 0x1c) + 0x2c) & (param2 ^ 0xffffffff);
		  *(uint *)(*(int *)(param1 + 0x1c) + 0x2c) = uVar1;
		  return uVar1;
		}
		*/

}
