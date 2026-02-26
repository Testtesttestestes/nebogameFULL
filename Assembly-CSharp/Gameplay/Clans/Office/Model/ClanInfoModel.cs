using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core.Data;
using Core.Dict;
using Gameplay.Clans.Model;
using Gameplay.Clans.Office.View;
using Gameplay.Clans.Office.View.ClanMembersTab;
using Il2CppDummyDll;
using MVC;
using Protocol.ClanIsle;
using Protocol.Clans;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Rating;
using UI.Elements.Filters.GenericFilter;
using UI.Elements.RatingElements.SubRatings;
using UI.Tabs;

namespace Gameplay.Clans.Office.Model
{
	// Token: 0x02000A42 RID: 2626
	[Token(Token = "0x2000A42")]
	public class ClanInfoModel : AbstractModel
	{
		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06003E22 RID: 15906 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C74")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6003E22")]
			[Address(RVA = "0x8CE1", Offset = "0x8CE1", VA = "0x8CE1")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003E23 RID: 15907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E23")]
		[Address(RVA = "0x8CE2", Offset = "0x8CE2", VA = "0x8CE2")]
		public ClanInfoModel(UserData user, ClansModel clansModel, ulong clanId, [Optional] ClanOfficeData clanOfficeData)
		{
		/* --- GHIDRA: <CreateUserRatingSubFilters>g__ConstructArgs|28_1 ---
		void Gameplay_Clans_Office_Model_ClanInfoModel___CreateUserRatingSubFilters_g__ConstructArgs_28_1
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57f93 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo);
		    DAT_ram_00a57f93 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: <CreateFilterDatas>g__CreateData|26_0 ---
		int Gameplay_Clans_Office_Model_ClanInfoModel___CreateFilterDatas_g__CreateData_26_0
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57f92 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_Filters_GenericFilter_SubFilterListElement_SubFilterData_TypeInfo);
		    DAT_ram_00a57f92 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (UI_Elements_Filters_GenericFilter_SubFilterListElement_SubFilterData_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  uVar2 = Gameplay_UserInfo_View_TitleIconValueBackground__set_Index(param1,0);
		  *(undefined4 *)(iVar1 + 0xc) = uVar2;
		  uVar2 = Core_Extensions_Dict_UserRatingKindDicExt__GetIcon256AssetId(param1,0);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  return iVar1;
		}
		*/

		/* --- GHIDRA: <.ctor>g__DetermineWindowState|9_0 ---
		int Gameplay_Clans_Office_Model_ClanInfoModel____ctor_g__DetermineWindowState_9_0
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57f91 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_Filters_GenericFilter_FilterListElement_FilterData_TypeInfo);
		    DAT_ram_00a57f91 = '\x01';
		  }
		  if (DAT_ram_00a57f87 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57f87 = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80e86792;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e86792:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = func_ii_7625(uVar3,param2,0);
		  iVar4 = unnamed_function_1417
		                    (UI_Elements_Filters_GenericFilter_FilterListElement_FilterData_TypeInfo);
		  *(undefined4 *)(iVar4 + 0xc) = uVar3;
		  uVar3 = Core_Extensions_Dict_DictExt__GetRatingTypeDic(uVar3,0);
		  *(undefined4 *)(iVar4 + 8) = uVar3;
		  return iVar4;
		}
		*/

		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06003E24 RID: 15908 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E25 RID: 15909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C75")]
		public ClanOfficeData ClanOfficeData
		{
			[Token(Token = "0x6003E24")]
			[Address(RVA = "0x8CE3", Offset = "0x8CE3", VA = "0x8CE3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E25")]
			[Address(RVA = "0x8CE4", Offset = "0x8CE4", VA = "0x8CE4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x06003E26 RID: 15910 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E27 RID: 15911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C76")]
		public List<ClanMemberListElement.ClanMemberListElementArgs> ClanMembers
		{
			[Token(Token = "0x6003E26")]
			[Address(RVA = "0x8CE5", Offset = "0x8CE5", VA = "0x8CE5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E27")]
			[Address(RVA = "0x8CE6", Offset = "0x8CE6", VA = "0x8CE6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x06003E28 RID: 15912 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C77")]
		public FilterListElement.FilterData[] FilterDatas
		{
			[Token(Token = "0x6003E28")]
			[Address(RVA = "0x8CE7", Offset = "0x8CE7", VA = "0x8CE7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003E29 RID: 15913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E29")]
		[Address(RVA = "0x8CE8", Offset = "0x8CE8", VA = "0x8CE8")]
		public void SetIsleInfo(ProtoGetIsleInfoAns.Types.ClanIsleInformation clanIsleInfo)
		{
		/* --- GHIDRA: SetIsleInfo ---
		int * Gameplay_Clans_Office_Model_ClanInfoModel__SetIsleInfo(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57f89 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4318);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4310);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4328);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17793);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4329);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4326);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4334);
		    DAT_ram_00a57f89 = '\x01';
		  }
		  if (*(int *)(param1 + 0x20) == 2) {
		    piVar1 = (int *)Mono_Security_ASN1Convert__ToOid(UI_Tabs_TabBarItemData___TypeInfo,6);
		    iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4310,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar2 + 0x14) = 0;
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
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4318,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar2 + 0x14) = 1;
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
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4334,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar2 + 0x14) = 2;
		    *(undefined4 *)(iVar2 + 0x10) = uVar3;
		    iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		    if (iVar4 != 0) {
		      piVar1[6] = iVar2;
		      iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		      uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4329,1,0,1,0,0,0,0);
		      *(undefined4 *)(iVar2 + 0x14) = 4;
		      *(undefined4 *)(iVar2 + 0x10) = uVar3;
		      iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		      if (iVar4 == 0) {
		        uVar3 = func_ii_1083();
		        func_ii_1050(uVar3,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar1[7] = iVar2;
		      iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		      uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4328,1,0,1,0,0,0,0);
		      *(undefined4 *)(iVar2 + 0x14) = 5;
		      *(undefined4 *)(iVar2 + 0x10) = uVar3;
		      iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		      if (iVar4 != 0) {
		        piVar1[8] = iVar2;
		        iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		        uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17793,1,0,1,0,0,0,0);
		        *(undefined4 *)(iVar2 + 0x14) = 6;
		        *(undefined4 *)(iVar2 + 0x10) = uVar3;
		        iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		        if (iVar4 != 0) {
		          piVar1[9] = iVar2;
		          return piVar1;
		        }
		        uVar3 = func_ii_1083();
		        func_ii_1050(uVar3,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar3 = func_ii_1083();
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(param1 + 0x20) != 3) {
		    piVar1 = (int *)Mono_Security_ASN1Convert__ToOid(UI_Tabs_TabBarItemData___TypeInfo,2);
		    iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4310,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar2 + 0x14) = 0;
		    *(undefined4 *)(iVar2 + 0x10) = uVar3;
		    iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		    if (iVar4 != 0) {
		      piVar1[4] = iVar2;
		      iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		      uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4318,1,0,1,0,0,0,0);
		      *(undefined4 *)(iVar2 + 0x14) = 1;
		      *(undefined4 *)(iVar2 + 0x10) = uVar3;
		      iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		      if (iVar4 != 0) {
		        piVar1[5] = iVar2;
		        return piVar1;
		      }
		      uVar3 = func_ii_1083();
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar1 = (int *)Mono_Security_ASN1Convert__ToOid(UI_Tabs_TabBarItemData___TypeInfo,7);
		  iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4310,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0x14) = 0;
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
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4318,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0x14) = 1;
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
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4334,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0x14) = 2;
		  *(undefined4 *)(iVar2 + 0x10) = uVar3;
		  iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		  if (iVar4 == 0) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar1[6] = iVar2;
		  iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4326,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0x14) = 3;
		  *(undefined4 *)(iVar2 + 0x10) = uVar3;
		  iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		  if (iVar4 == 0) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar1[7] = iVar2;
		  iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4329,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0x14) = 4;
		  *(undefined4 *)(iVar2 + 0x10) = uVar3;
		  iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		  if (iVar4 != 0) {
		    piVar1[8] = iVar2;
		    iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4328,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar2 + 0x14) = 5;
		    *(undefined4 *)(iVar2 + 0x10) = uVar3;
		    iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		    if (iVar4 == 0) {
		      uVar3 = func_ii_1083();
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar1[9] = iVar2;
		    iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17793,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar2 + 0x14) = 6;
		    *(undefined4 *)(iVar2 + 0x10) = uVar3;
		    iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		    if (iVar4 != 0) {
		      piVar1[10] = iVar2;
		      return piVar1;
		    }
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar3 = func_ii_1083();
		  func_ii_1050(uVar3,0);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003E2A RID: 15914 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E2A")]
		[Address(RVA = "0x8CE9", Offset = "0x8CE9", VA = "0x8CE9")]
		public TabBarItemData[] GetTabBarItemData()
		{
		/* --- GHIDRA: GetTabBarItemData ---
		void Gameplay_Clans_Office_Model_ClanInfoModel__GetTabBarItemData
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57f8a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Clans_Office_Model_ClanInfoModel_ConstructArgs__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ProtoGetMembersListAns_Types_MemberInfo__ClanMemberListElement_ClanMemberListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToList_ClanMemberListElement_ClanMemberListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_ProtoGetMembersListAns_Types_MemberInfo__ClanMemberListElement_ClanMemberListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_ClanMemberListElement_ClanMemberListElementArgs__get_Count__
		              );
		    DAT_ram_00a57f8a = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Func_ProtoGetMembersListAns_Types_MemberInfo__ClanMemberListElement_ClanMemberListElementArgs__TypeInfo
		                    );
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,Method_Gameplay_Clans_Office_Model_ClanInfoModel_ConstructArgs__,0);
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param2,uVar1,
		                     Method_System_Linq_Enumerable_Select_ProtoGetMembersListAns_Types_MemberInfo__ClanMemberListElement_ClanMemberListElementArgs___
		                    );
		  iVar2 = System_Linq_Enumerable__Select_object__object_
		                    (uVar1,
		                     Method_System_Linq_Enumerable_ToList_ClanMemberListElement_ClanMemberListElementArgs___
		                    );
		  *(int *)(param1 + 0x34) = iVar2;
		  *(undefined4 *)(*(int *)(param1 + 0x30) + 0x10) = *(undefined4 *)(iVar2 + 0xc);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003E2B RID: 15915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E2B")]
		[Address(RVA = "0x8CEA", Offset = "0x8CEA", VA = "0x8CEA")]
		public void PopulateMembers(IList<ProtoGetMembersListAns.Types.MemberInfo> members)
		{
		/* --- GHIDRA: PopulateMembers ---
		undefined4 Gameplay_Clans_Office_Model_ClanInfoModel__PopulateMembers(int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  undefined4 in_register_20000014;
		  undefined8 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  double param2_00;
		  int *piVar7;
		  int iVar8;
		  int iVar9;
		  uint uVar10;
		  
		  if (DAT_ram_00a57f8b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24610);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26091);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26090);
		    DAT_ram_00a57f8b = '\x01';
		  }
		  if (DAT_ram_00a57f87 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57f87 = '\x01';
		  }
		  uVar10 = 0;
		  piVar7 = *(int **)(param1 + 0xc);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8 + 4) * 8 + iVar8 + 0xd0);
		        goto code_r0x80e871f4;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e871f4:
		  uVar1 = CONCAT44(in_register_20000004,piVar7);
		  uVar2 = CONCAT44(in_register_20000014,puVar4[1]);
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(uVar1,uVar2);
		  uVar6 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  iVar8 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar5,StringLiteral_24610,0);
		  if (DAT_ram_00a57f87 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57f87 = '\x01';
		  }
		  piVar7 = *(int **)(param1 + 0xc);
		  iVar9 = *piVar7;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8 + 4) * 8 + iVar9 + 0xd0);
		        goto code_r0x80e872a5;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e872a5:
		  uVar1 = CONCAT44(uVar6,piVar7);
		  uVar2 = CONCAT44(uVar3,puVar4[1]);
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(uVar1,uVar2);
		  uVar6 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar5 = Core_Extensions_Dict_DictExt__GetBoolParameter(uVar5,StringLiteral_26090,0);
		  if (DAT_ram_00a57f87 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57f87 = '\x01';
		  }
		  piVar7 = *(int **)(param1 + 0xc);
		  iVar9 = *piVar7;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8 + 4) * 8 + iVar9 + 0xd0);
		        goto code_r0x80e87356;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e87356:
		  uVar6 = (**(code **)((ulonglong)*puVar4 * 4))(CONCAT44(uVar6,piVar7),CONCAT44(uVar3,puVar4[1]));
		  iVar9 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar6,StringLiteral_26091,0);
		  uVar10 = *(uint *)(*(int *)(*(int *)(param1 + 0x30) + 8) + 0x1c);
		  uVar6 = Protocol_Common_ResourceSet___ctor(uVar5,0);
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  param2_00 = System_Math__Log10((double)iVar9,
		                                 (double)(longlong)((ulonglong)uVar10 - (longlong)iVar8),0);
		  uVar6 = Core_Extensions_Dict_ResourceSetExt__Round(uVar6,param2_00,0);
		  return uVar6;
		}
		*/

		}

		// Token: 0x06003E2C RID: 15916 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E2C")]
		[Address(RVA = "0x8CEB", Offset = "0x8CEB", VA = "0x8CEB")]
		public ResourceSet GetAddVacancyPrice()
		{
		/* --- GHIDRA: GetAddVacancyPrice ---
		int Gameplay_Clans_Office_Model_ClanInfoModel__GetAddVacancyPrice
		              (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int param1_00;
		  uint *puVar2;
		  longlong lVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a57f8c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    DAT_ram_00a57f8c = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs_TypeInfo
		                        );
		  Unity_Collections_NativeArray_ReadOnly_Enumerator_Painter2D_Painter2DJobData___MoveNext
		            (param1_00,0);
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(param2 + 0x10);
		  *(undefined4 *)(param1_00 + 0x20) = *(undefined4 *)(param2 + 0x14);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x158);
		        goto code_r0x80e874b0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80e874b0:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  uVar6 = *(undefined4 *)(param2 + 0xc);
		  piVar4 = *(int **)(iVar5 + 0x14);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Cache_User_IUserInfoWrapper_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e8753c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x80e8753c:
		  uVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,uVar6,puVar2[1]);
		  *(undefined4 *)(param1_00 + 0x18) = uVar6;
		  *(bool *)(param1_00 + 0x24) =
		       *(longlong *)(*(int *)(param2 + 0xc) + 0x10) ==
		       *(longlong *)(*(int *)(*(int *)(*(int *)(param1 + 0x30) + 8) + 0x2c) + 0x10);
		  lVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(param1 + 8),0);
		  *(bool *)(param1_00 + 0x25) = lVar3 == *(longlong *)(*(int *)(param2 + 0xc) + 0x10);
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06003E2D RID: 15917 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E2D")]
		[Address(RVA = "0x8CEC", Offset = "0x8CEC", VA = "0x8CEC")]
		private ClanMemberListElement.ClanMemberListElementArgs ConstructArgs(ProtoGetMembersListAns.Types.MemberInfo memberInfo)
		{
		/* --- GHIDRA: ConstructArgs ---
		int * Gameplay_Clans_Office_Model_ClanInfoModel__ConstructArgs(undefined4 param1,undefined4 param2)
		
		{
		  int *param3;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57f8d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_Filters_GenericFilter_FilterListElement_FilterData___TypeInfo);
		    DAT_ram_00a57f8d = '\x01';
		  }
		  param3 = (int *)Mono_Security_ASN1Convert__ToOid
		                            (UI_Elements_Filters_GenericFilter_FilterListElement_FilterData___TypeInfo
		                             ,3);
		  iVar1 = Gameplay_Clans_Office_Model_ClanInfoModel____ctor_g__DetermineWindowState_9_0
		                    (param1,1,param3);
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param3 + 0x20)), iVar2 == 0)) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param3[4] = iVar1;
		  iVar1 = Gameplay_Clans_Office_Model_ClanInfoModel____ctor_g__DetermineWindowState_9_0
		                    (param1,2,param3);
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param3 + 0x20)), iVar2 == 0)) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param3[5] = iVar1;
		  iVar1 = Gameplay_Clans_Office_Model_ClanInfoModel____ctor_g__DetermineWindowState_9_0
		                    (param1,3,param3);
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param3 + 0x20)), iVar2 == 0)) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param3[6] = iVar1;
		  return param3;
		}
		*/

			return null;
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E2E")]
		[Address(RVA = "0x8CED", Offset = "0x8CED", VA = "0x8CED")]
		private FilterListElement.FilterData[] CreateFilterDatas()
		{
		/* --- GHIDRA: CreateFilterDatas ---
		undefined4
		Gameplay_Clans_Office_Model_ClanInfoModel__CreateFilterDatas(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 *puVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a57f8e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__SubRatingInfo__get_Values__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_SubRatingInfo__uint___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_SubRatingInfo__SubRatingListElementArgs___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_SubRatingListElementArgs___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_SubRatingInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_SubRatingInfo__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_SubRatingInfo__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_SubRatingInfo__SubRatingListElementArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Model_ClanInfoModel___c__CreateSubRatingListElementArgs_b__27_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Model_ClanInfoModel___c__CreateSubRatingListElementArgs_b__27_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Model_ClanInfoModel___c__CreateSubRatingListElementArgs_b__27_2__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo);
		    DAT_ram_00a57f8e = '\x01';
		  }
		  if (DAT_ram_00a57f87 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57f87 = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80e861f0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e861f0:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar4 = *(undefined4 *)(iVar3 + 0x260);
		  iVar3 = unnamed_function_1417(Gameplay_Rating_Model_RatingInfo_TypeInfo);
		  Gameplay_Rating_View_UserView___ctor(iVar3,uVar4,0);
		  uVar4 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(iVar3 + 0x10),
		                     Method_System_Collections_Generic_Dictionary_uint__SubRatingInfo__get_Values__)
		  ;
		  if (*(int *)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo);
		  }
		  puVar5 = *(undefined4 **)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x5c);
		  iVar3 = puVar5[1];
		  if (iVar3 == 0) {
		    if (*(int *)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo);
		      puVar5 = *(undefined4 **)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x5c);
		    }
		    uVar6 = *puVar5;
		    iVar3 = unnamed_function_1417(System_Func_SubRatingInfo__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar3,uVar6,
		               Method_Gameplay_Clans_Office_Model_ClanInfoModel___c__CreateSubRatingListElementArgs_b__27_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x5c) + 4) = iVar3;
		  }
		  uVar4 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar4,iVar3,Method_System_Linq_Enumerable_Where_SubRatingInfo___);
		  if (*(int *)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo);
		  }
		  puVar5 = *(undefined4 **)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x5c);
		  iVar3 = puVar5[2];
		  if (iVar3 == 0) {
		    if (*(int *)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo);
		      puVar5 = *(undefined4 **)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x5c);
		    }
		    uVar6 = *puVar5;
		    iVar3 = unnamed_function_1417(System_Func_SubRatingInfo__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar3,uVar6,
		               Method_Gameplay_Clans_Office_Model_ClanInfoModel___c__CreateSubRatingListElementArgs_b__27_1__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x5c) + 8) = iVar3;
		  }
		  uVar4 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar4,iVar3,Method_System_Linq_Enumerable_OrderBy_SubRatingInfo__uint___);
		  if (*(int *)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo);
		  }
		  puVar5 = *(undefined4 **)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x5c);
		  iVar3 = puVar5[3];
		  if (iVar3 == 0) {
		    if (*(int *)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo);
		      puVar5 = *(undefined4 **)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x5c);
		    }
		    uVar6 = *puVar5;
		    iVar3 = unnamed_function_1417(System_Func_SubRatingInfo__SubRatingListElementArgs__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar3,uVar6,
		               Method_Gameplay_Clans_Office_Model_ClanInfoModel___c__CreateSubRatingListElementArgs_b__27_2__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x5c) + 0xc) = iVar3;
		  }
		  uVar4 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar4,iVar3,
		                     Method_System_Linq_Enumerable_Select_SubRatingInfo__SubRatingListElementArgs___
		                    );
		  uVar4 = System_Linq_Enumerable__Select_object__object_
		                    (uVar4,Method_System_Linq_Enumerable_ToList_SubRatingListElementArgs___);
		  return uVar4;
		}
		*/

			return null;
		}

		// Token: 0x06003E2F RID: 15919 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E2F")]
		[Address(RVA = "0x8CEE", Offset = "0x8CEE", VA = "0x8CEE")]
		private List<SubRatingListElementArgs> CreateSubRatingListElementArgs()
		{
		/* --- GHIDRA: CreateSubRatingListElementArgs ---
		undefined4
		Gameplay_Clans_Office_Model_ClanInfoModel__CreateSubRatingListElementArgs
		          (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 *puVar6;
		  
		  if (DAT_ram_00a57f8f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Model_ClanInfoModel__CreateUserRatingSubFilters_g__ConstructArgs_28_1__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_UserRatingKindDic__uint___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_UserRatingKindDic__SubFilterListElement_SubFilterData___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToArray_SubFilterListElement_SubFilterData___);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_UserRatingKindDic__SubFilterListElement_SubFilterData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_UserRatingKindDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Model_ClanInfoModel___c__CreateUserRatingSubFilters_b__28_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo);
		    DAT_ram_00a57f8f = '\x01';
		  }
		  if (DAT_ram_00a57f87 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57f87 = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80e864d4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e864d4:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar5 = *(undefined4 *)(iVar4 + 0x260);
		  if (*(int *)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x5c);
		  iVar4 = puVar6[4];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x5c);
		    }
		    uVar3 = *puVar6;
		    iVar4 = unnamed_function_1417(System_Func_UserRatingKindDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar4,uVar3,
		               Method_Gameplay_Clans_Office_Model_ClanInfoModel___c__CreateUserRatingSubFilters_b__28_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x5c) + 0x10) = iVar4
		    ;
		  }
		  uVar5 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar5,iVar4,Method_System_Linq_Enumerable_OrderBy_UserRatingKindDic__uint___);
		  uVar3 = unnamed_function_1417
		                    (System_Func_UserRatingKindDic__SubFilterListElement_SubFilterData__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar3,0,
		             Method_Gameplay_Clans_Office_Model_ClanInfoModel__CreateUserRatingSubFilters_g__ConstructArgs_28_1__
		             ,0);
		  uVar5 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar5,uVar3,
		                     Method_System_Linq_Enumerable_Select_UserRatingKindDic__SubFilterListElement_SubFilterData___
		                    );
		  uVar5 = func_ii_6295(uVar5,
		                       Method_System_Linq_Enumerable_ToArray_SubFilterListElement_SubFilterData___);
		  return uVar5;
		}
		*/

			return null;
		}

		// Token: 0x06003E30 RID: 15920 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E30")]
		[Address(RVA = "0x8CEF", Offset = "0x8CEF", VA = "0x8CEF")]
		private SubFilterListElement.SubFilterData[] CreateUserRatingSubFilters()
		{
		/* --- GHIDRA: CreateUserRatingSubFilters ---
		undefined4
		Gameplay_Clans_Office_Model_ClanInfoModel__CreateUserRatingSubFilters(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 *puVar6;
		  int iVar7;
		  int *param1_00;
		  
		  uVar4 = 0;
		  if (DAT_ram_00a57f90 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_BuildingInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_BuildingInfo__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Model_ClanInfoModel___c__GetJoinPrice_b__29_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo);
		    DAT_ram_00a57f90 = '\x01';
		  }
		  uVar5 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x30) + 8) + 0xc);
		  if (*(int *)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x5c);
		  iVar7 = puVar6[5];
		  if (iVar7 == 0) {
		    if (*(int *)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x5c);
		    }
		    uVar3 = *puVar6;
		    iVar7 = unnamed_function_1417(System_Func_BuildingInfo__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar7,uVar3,
		               Method_Gameplay_Clans_Office_Model_ClanInfoModel___c__GetJoinPrice_b__29_0__,0);
		    *(int *)(*(int *)(Gameplay_Clans_Office_Model_ClanInfoModel___c_TypeInfo + 0x5c) + 0x14) = iVar7
		    ;
		  }
		  iVar7 = System_Func_object__bool____ctor
		                    (uVar5,iVar7,Method_System_Linq_Enumerable_FirstOrDefault_BuildingInfo___);
		  if (iVar7 != 0) {
		    uVar4 = *(undefined4 *)(iVar7 + 0x10);
		  }
		  uVar5 = *(undefined4 *)(*(int *)(param1 + 0x30) + 0xc);
		  if (DAT_ram_00a57f87 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57f87 = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar7 = *param1_00;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd0);
		        goto code_r0x80e87708;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e87708:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar4 = Gameplay_World_Model_ClanData__GetClanCultIconAssetId(uVar5,uVar4,uVar3,0);
		  return uVar4;
		}
		*/

			return null;
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E31")]
		[Address(RVA = "0x8CF0", Offset = "0x8CF0", VA = "0x8CF0")]
		public ResourceSet GetJoinPrice()
		{
		/* --- GHIDRA: GetJoinPrice ---
		undefined4
		Gameplay_Clans_Office_Model_ClanInfoModel__GetJoinPrice(int param1,int param2,undefined4 param3)
		
		{
		  longlong lVar1;
		  longlong lVar2;
		  undefined4 uVar3;
		  
		  uVar3 = 1;
		  lVar1 = Core_Data_UserData___ctor(*(undefined4 *)(param1 + 8),0);
		  if (lVar1 == *(longlong *)(param2 + 8)) {
		    uVar3 = 3;
		    lVar1 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x68) + 0x14),0);
		    lVar2 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(param1 + 8),0);
		    if (lVar1 != lVar2) {
		      uVar3 = 2;
		    }
		  }
		  return uVar3;
		}
		*/

			return null;
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x0000C408 File Offset: 0x0000A608
		[Token(Token = "0x6003E32")]
		[Address(RVA = "0x8CF1", Offset = "0x8CF1", VA = "0x8CF1")]
		[CompilerGenerated]
		private ClanInfoWindow.State <.ctor>g__DetermineWindowState|9_0(ref ClanInfoModel.<>c__DisplayClass9_0 A_1)
		{
			return ClanInfoWindow.State.UNKNOWN_STATE;
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E33")]
		[Address(RVA = "0x8CF2", Offset = "0x8CF2", VA = "0x8CF2")]
		[CompilerGenerated]
		private FilterListElement.FilterData <CreateFilterDatas>g__CreateData|26_0(RatingPeriods period)
		{
			return null;
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E34")]
		[Address(RVA = "0x8CF3", Offset = "0x8CF3", VA = "0x8CF3")]
		[CompilerGenerated]
		internal static SubFilterListElement.SubFilterData <CreateUserRatingSubFilters>g__ConstructArgs|28_1(UserRatingKindDic dic)
		{
			return null;
		}

		// Token: 0x040022E6 RID: 8934
		[Token(Token = "0x40022E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private readonly IDictProvider _dictProvider;

		// Token: 0x040022E7 RID: 8935
		[Token(Token = "0x40022E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ulong ClanId;

		// Token: 0x040022E8 RID: 8936
		[Token(Token = "0x40022E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly SubRatingsListArgs SubRatingsArgs;

		// Token: 0x040022E9 RID: 8937
		[Token(Token = "0x40022E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public readonly SubFilterListElement.SubFilterData[] UserRatingSubFilters;

		// Token: 0x040022EA RID: 8938
		[Token(Token = "0x40022EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly ClanInfoWindow.State State;

		// Token: 0x040022EB RID: 8939
		[Token(Token = "0x40022EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly ClansModel ClansModel;

		// Token: 0x040022EC RID: 8940
		[Token(Token = "0x40022EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ZigguratLevelDic ZigguratLevelDic;

		// Token: 0x040022ED RID: 8941
		[Token(Token = "0x40022ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private FilterListElement.FilterData[] _filterDatas;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Dict ---
		void Gameplay_Clans_Office_Model_ClanInfoModel__get_Dict
		               (int param1,undefined4 param2,undefined4 param3,longlong param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  longlong lVar3;
		  longlong lVar4;
		  int *piVar5;
		  int iVar6;
		  uint uVar7;
		  
		  if (DAT_ram_00a57f88 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Elements_RatingElements_SubRatings_SubRatingsListArgs_TypeInfo)
		    ;
		    DAT_ram_00a57f88 = '\x01';
		  }
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar7 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x80e85f63;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar7);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e85f63:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar5,puVar1[1]);
		  *(undefined4 *)(param1 + 0x24) = param3;
		  *(undefined4 *)(param1 + 0xc) = uVar2;
		  *(longlong *)(param1 + 0x10) = param4;
		  param2_00 = 0;
		  uVar2 = 1;
		  lVar3 = Core_Data_UserData___ctor(*(undefined4 *)(param1 + 8),0);
		  if (lVar3 == param4) {
		    uVar2 = 3;
		    lVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x68) + 0x14),0);
		    lVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(param1 + 8),0);
		    if (lVar3 != lVar4) {
		      uVar2 = 2;
		    }
		  }
		  *(undefined4 *)(param1 + 0x30) = param5;
		  *(undefined4 *)(param1 + 0x20) = uVar2;
		  iVar6 = *(int *)(*(int *)(param1 + 0x24) + 0x1c);
		  if (iVar6 != 0) {
		    param2_00 = Core_Extensions_ClanInfoExt___c___GetTotalMembersNum_b__2_0(iVar6,1,0);
		  }
		  if (DAT_ram_00a57f87 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57f87 = '\x01';
		  }
		  piVar5 = *(int **)(param1 + 0xc);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x80e8607f;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar7);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar5,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e8607f:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar5,puVar1[1]);
		  uVar2 = Core_Extensions_Dict_DictExt__GetClanLeagueDic(uVar2,param2_00,0);
		  *(undefined4 *)(param1 + 0x28) = uVar2;
		  uVar2 = Gameplay_Clans_Office_Model_ClanInfoModel__CreateFilterDatas(param1,puVar1);
		  iVar6 = unnamed_function_1417(UI_Elements_RatingElements_SubRatings_SubRatingsListArgs_TypeInfo);
		  UI_Elements_RatingElements_SubRatings_SubRatingsList___ctor(iVar6,0);
		  *(undefined4 *)(iVar6 + 0xc) = 0;
		  *(undefined4 *)(iVar6 + 8) = uVar2;
		  *(int *)(param1 + 0x18) = iVar6;
		  uVar2 = Gameplay_Clans_Office_Model_ClanInfoModel__CreateSubRatingListElementArgs(param1,iVar6);
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  return;
		}
		*/


		/* --- GHIDRA: set_ClanMembers ---
		int Gameplay_Clans_Office_Model_ClanInfoModel__set_ClanMembers(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x2c);
		  if (iVar1 == 0) {
		    iVar1 = Gameplay_Clans_Office_Model_ClanInfoModel__ConstructArgs(param1,param1);
		  }
		  *(int *)(param1 + 0x2c) = iVar1;
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_FilterDatas ---
		void Gameplay_Clans_Office_Model_ClanInfoModel__get_FilterDatas
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *param3_00;
		  undefined4 param2_00;
		  int *param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a57f87 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57f87 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        param3_00 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		        goto code_r0x80e86864;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  param3_00 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e86864:
		  param2_00 = (**(code **)((ulonglong)*param3_00 * 4))(param1_00,param3_00[1]);
		  iVar2 = Gameplay_Clans_Office_Model_ClanOfficeData___ctor(param2,param2_00,param3_00);
		  *(int *)(param1 + 0x30) = iVar2;
		  if (*(int *)(param1 + 0x20) == 3) {
		    *(undefined4 *)(*(int *)(iVar2 + 8) + 0x2c) = *(undefined4 *)(*(int *)(param1 + 8) + 0x34);
		  }
		  return;
		}
		*/

}
