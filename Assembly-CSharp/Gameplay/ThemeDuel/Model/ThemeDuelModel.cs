using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.ThemeDuelState.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Rating;
using UI.Tabs;

namespace Gameplay.ThemeDuel.Model
{
	// Token: 0x020004E4 RID: 1252
	[Token(Token = "0x20004E4")]
	public class ThemeDuelModel : AbstractModel
	{
		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001DEB RID: 7659 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700056F")]
		public ThemeDuelRatingModel RatingModel
		{
			[Token(Token = "0x6001DEB")]
			[Address(RVA = "0x6F69", Offset = "0x6F69", VA = "0x6F69")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001DEC RID: 7660 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000570")]
		public ThemeDuelStateModel StateModel
		{
			[Token(Token = "0x6001DEC")]
			[Address(RVA = "0x6F6A", Offset = "0x6F6A", VA = "0x6F6A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DED")]
		[Address(RVA = "0x6F6B", Offset = "0x6F6B", VA = "0x6F6B")]
		public ThemeDuelModel(UserData user, IGame game)
		{
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001DEE RID: 7662 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001DEF RID: 7663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000571")]
		public ProtoGetGreatTopAns GreatTop
		{
			[Token(Token = "0x6001DEE")]
			[Address(RVA = "0x6F6C", Offset = "0x6F6C", VA = "0x6F6C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DEF")]
			[Address(RVA = "0x6F6D", Offset = "0x6F6D", VA = "0x6F6D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000572")]
		public Dictionary<ulong, GreatUserData> GreatUsers
		{
			[Token(Token = "0x6001DF0")]
			[Address(RVA = "0x6F6E", Offset = "0x6F6E", VA = "0x6F6E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DF1")]
			[Address(RVA = "0x6F6F", Offset = "0x6F6F", VA = "0x6F6F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000573")]
		public RatingPrizeDic[] Prizes
		{
			[Token(Token = "0x6001DF2")]
			[Address(RVA = "0x6F70", Offset = "0x6F70", VA = "0x6F70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DF3")]
			[Address(RVA = "0x6F71", Offset = "0x6F71", VA = "0x6F71")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001DF4")]
		[Address(RVA = "0x6F72", Offset = "0x6F72", VA = "0x6F72")]
		public TabBarItemData[] GetTabBarItemData()
		{
		/* --- GHIDRA: GetTabBarItemData ---
		void Gameplay_ThemeDuel_Model_ThemeDuelModel__GetTabBarItemData
		               (int param1,int param2,undefined4 param3)
		
		{
		  *(int *)(param1 + 0x18) = param2;
		  Gameplay_ThemeDuel_Model_ThemeDuelModel__PopulateGreatTop
		            (param1,*(undefined4 *)(param2 + 0xc),param2);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DF5")]
		[Address(RVA = "0x6F73", Offset = "0x6F73", VA = "0x6F73")]
		public void PopulateGreatTop(ProtoGetGreatTopAns ans)
		{
		/* --- GHIDRA: PopulateGreatTop ---
		void Gameplay_ThemeDuel_Model_ThemeDuelModel__PopulateGreatTop
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a585d2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_GreatUserTopInfo__GreatUserData___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToDictionary_GreatUserData__ulong___);
		    Mono_Security_ASN1__get_Item(&System_Func_GreatUserTopInfo__GreatUserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_GreatUserData__ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuel_Model_ThemeDuelModel_ConstructGreatUserData__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuel_Model_ThemeDuelModel___c__PopulateUsers_b__22_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuel_Model_ThemeDuelModel___c_TypeInfo);
		    DAT_ram_00a585d2 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Func_GreatUserTopInfo__GreatUserData__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,Method_Gameplay_ThemeDuel_Model_ThemeDuelModel_ConstructGreatUserData__,0)
		  ;
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param2,uVar1,
		                     Method_System_Linq_Enumerable_Select_GreatUserTopInfo__GreatUserData___);
		  if (*(int *)(Gameplay_ThemeDuel_Model_ThemeDuelModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_ThemeDuel_Model_ThemeDuelModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_ThemeDuel_Model_ThemeDuelModel___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_ThemeDuel_Model_ThemeDuelModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_ThemeDuel_Model_ThemeDuelModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_ThemeDuel_Model_ThemeDuelModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_GreatUserData__ulong__TypeInfo);
		    func_ii_7542(param1_00,param2_00,
		                 Method_Gameplay_ThemeDuel_Model_ThemeDuelModel___c__PopulateUsers_b__22_0__,0);
		    *(int *)(*(int *)(Gameplay_ThemeDuel_Model_ThemeDuelModel___c_TypeInfo + 0x5c) + 4) = param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__ToDictionary_object__uint_
		                    (uVar1,param1_00,
		                     Method_System_Linq_Enumerable_ToDictionary_GreatUserData__ulong___);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DF6")]
		[Address(RVA = "0x6F74", Offset = "0x6F74", VA = "0x6F74")]
		public void PopulateUsers(IList<GreatUserTopInfo> users)
		{
		/* --- GHIDRA: PopulateUsers ---
		int Gameplay_ThemeDuel_Model_ThemeDuelModel__PopulateUsers(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a585d3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuel_Model_GreatUserData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ulong__Contains__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a585d3 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Gameplay_ThemeDuel_Model_GreatUserData_TypeInfo);
		  *(int *)(iVar1 + 8) = param2;
		  uVar2 = Core_Extensions_Dict_DictExt__GetArtikulTypeFiltersByFilterType
		                    (*(undefined4 *)(param1 + 0xc),*(undefined4 *)(*(int *)(param2 + 0xc) + 0x1c),0)
		  ;
		  *(undefined4 *)(iVar1 + 0xc) = uVar2;
		  iVar3 = Core_Extensions_Dict_DictExt__GetDuelUserStateFlags
		                    (*(undefined4 *)(param1 + 0xc),*(undefined4 *)(param2 + 0x18),0);
		  uVar2 = *(undefined4 *)(iVar3 + 0x1c);
		  if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(uVar2,0);
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  uVar2 = Google_Protobuf_Collections_RepeatedField_ulong___Clone
		                    (*(undefined4 *)(*(int *)(param1 + 0x18) + 0x24),
		                     *(undefined8 *)(*(int *)(param2 + 0xc) + 0x10),
		                     Method_Google_Protobuf_Collections_RepeatedField_ulong__Contains__);
		  *(char *)(iVar1 + 0x14) = (char)uVar2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001DF7")]
		[Address(RVA = "0x6F75", Offset = "0x6F75", VA = "0x6F75")]
		private GreatUserData ConstructGreatUserData(GreatUserTopInfo greatUserInfo)
		{
		/* --- GHIDRA: ConstructGreatUserData ---
		void Gameplay_ThemeDuel_Model_ThemeDuelModel__ConstructGreatUserData(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a585d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuel_Model_ThemeDuelModel___c_TypeInfo);
		    DAT_ram_00a585d4 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_ThemeDuel_Model_ThemeDuelModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_ThemeDuel_Model_ThemeDuelModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0400104A RID: 4170
		[Token(Token = "0x400104A")]
		[FieldOffset(Offset = "0xC")]
		public readonly Dictionaries Dict;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_StateModel ---
		void Gameplay_ThemeDuel_Model_ThemeDuelModel__get_StateModel
		               (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  float fVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  int iVar6;
		  
		  if (DAT_ram_00a585d0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__GreatUserData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_ulong__GreatUserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuel_Model_ThemeDuelRatingModel_TypeInfo);
		    DAT_ram_00a585d0 = '\x01';
		  }
		  uVar2 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_ulong__GreatUserData__TypeInfo);
		  System_Collections_Generic_Dictionary_ulong__ulong___set_Item
		            (uVar2,Method_System_Collections_Generic_Dictionary_ulong__GreatUserData___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  iVar6 = *param3;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x288);
		        goto code_r0x80f0da4d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param3,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x80f0da4d:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(param3,puVar3[1]);
		  *(undefined4 *)(param1 + 0x14) = *(undefined4 *)(iVar6 + 0x14);
		  uVar1 = 0;
		  iVar6 = *param3;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x80f0dacf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param3,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f0dacf:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param3,puVar3[1]);
		  uVar2 = func_ii_7112(uVar2,0);
		  iVar6 = *(int *)(param1 + 0x14);
		  fVar4 = func_ii_7103(*(undefined4 *)(iVar6 + 0x34),0);
		  if (0.0 < fVar4) {
		    if (*(int *)(iVar6 + 0x10) == 0) {
		      uVar5 = 0;
		    }
		    else {
		      func_ii_7103(*(undefined4 *)(iVar6 + 0x34),0);
		      uVar5 = *(undefined4 *)(*(int *)(iVar6 + 0x10) + 0x10);
		    }
		  }
		  else {
		    uVar5 = 0;
		  }
		  iVar6 = unnamed_function_1417(Gameplay_ThemeDuel_Model_ThemeDuelRatingModel_TypeInfo);
		  Gameplay_Rating_Model_RatingModel__get_CultsSubFilters(iVar6,uVar2,0);
		  *(undefined4 *)(iVar6 + 0x4c) = uVar5;
		  *(int *)(param1 + 0x10) = iVar6;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x80f0dbe0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f0dbe0:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  *(undefined4 *)(param1 + 0xc) = uVar2;
		  uVar2 = Core_Extensions_Dict_DictExt__GetGreatRewardSet(uVar2,7,0);
		  *(undefined4 *)(param1 + 0x20) = uVar2;
		  return;
		}
		*/


		/* --- GHIDRA: set_Prizes ---
		int * Gameplay_ThemeDuel_Model_ThemeDuelModel__set_Prizes(undefined4 param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a585d1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15054);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15053);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15052);
		    DAT_ram_00a585d1 = '\x01';
		  }
		  piVar1 = (int *)Mono_Security_ASN1Convert__ToOid(UI_Tabs_TabBarItemData___TypeInfo,3);
		  iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  *(undefined4 *)(iVar2 + 0x14) = 1;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15053,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0x10) = uVar3;
		  iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		  if (iVar4 == 0) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar1[4] = iVar2;
		  iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  *(undefined4 *)(iVar2 + 0x14) = 2;
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15052,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0x10) = uVar3;
		  iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		  if (iVar4 == 0) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar1[5] = iVar2;
		  iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  *(undefined4 *)(iVar2 + 0x14) = 3;
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15054,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0x10) = uVar3;
		  iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		  if (iVar4 != 0) {
		    piVar1[6] = iVar2;
		    return piVar1;
		  }
		  uVar3 = func_ii_1083();
		  func_ii_1050(uVar3,0);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
