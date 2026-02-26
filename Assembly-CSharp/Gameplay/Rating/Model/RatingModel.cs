using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using Gameplay.Clans.Office.View;
using Gameplay.Clans.Office.View.ClanResumesTab;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Rating;
using UI.Elements.Filters.GenericFilter;
using UI.Tabs;

namespace Gameplay.Rating.Model
{
	// Token: 0x0200058C RID: 1420
	[Token(Token = "0x200058C")]
	public class RatingModel : AbstractModel
	{
		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x060021DF RID: 8671 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000636")]
		public FilterWithIconListElement.FilterWithIconData[] CultExtraFilterDatas
		{
			[Token(Token = "0x60021DF")]
			[Address(RVA = "0x733E", Offset = "0x733E", VA = "0x733E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x060021E0 RID: 8672 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000637")]
		public FilterWithIconListElement.FilterWithIconData[] ClanCultExtraFilterDatas
		{
			[Token(Token = "0x60021E0")]
			[Address(RVA = "0x733F", Offset = "0x733F", VA = "0x733F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x060021E1 RID: 8673 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000638")]
		public virtual FilterListElement.FilterData[] UserPeriodFilterDatas
		{
			[Token(Token = "0x60021E1")]
			[Address(RVA = "0x7340", Offset = "0x7340", VA = "0x7340", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060021E2 RID: 8674 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000639")]
		public FilterListElement.FilterData[] ClansPeriodFilterDatas
		{
			[Token(Token = "0x60021E2")]
			[Address(RVA = "0x7341", Offset = "0x7341", VA = "0x7341")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060021E3 RID: 8675 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700063A")]
		public FilterListElement.FilterData[] CultsPeriodFilterDatas
		{
			[Token(Token = "0x60021E3")]
			[Address(RVA = "0x7342", Offset = "0x7342", VA = "0x7342")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060021E4 RID: 8676 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700063B")]
		public SubFilterListElement.SubFilterData[] UsersSubFilters
		{
			[Token(Token = "0x60021E4")]
			[Address(RVA = "0x7343", Offset = "0x7343", VA = "0x7343")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060021E5 RID: 8677 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700063C")]
		public SubFilterListElement.SubFilterData[] ClansSubFilters
		{
			[Token(Token = "0x60021E5")]
			[Address(RVA = "0x7344", Offset = "0x7344", VA = "0x7344")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060021E6 RID: 8678 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700063D")]
		public SubFilterListElement.SubFilterData[] CultsSubFilters
		{
			[Token(Token = "0x60021E6")]
			[Address(RVA = "0x7345", Offset = "0x7345", VA = "0x7345")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021E7")]
		[Address(RVA = "0x7346", Offset = "0x7346", VA = "0x7346")]
		public RatingModel(UserData user)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Competition_Model_RatingModel___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  int param3_00;
		  
		  if (DAT_ram_00a63ac2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_RatingModel_RatingRecord__AddRange__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_RatingModel_RatingRecord__Clear__);
		    DAT_ram_00a63ac2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  param3_00 = *(int *)(param1_00 + 0xc);
		  *(undefined4 *)(param1_00 + 0xc) = 0;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  if (0 < param3_00) {
		    func_ii_2064(*(undefined4 *)(param1_00 + 8),0,param3_00,0);
		    param1_00 = *(int *)(param1 + 0x14);
		  }
		  func_ii_6335(param1_00,param2,
		               Method_System_Collections_Generic_List_RatingModel_RatingRecord__AddRange__);
		  return;
		}
		*/

		/* --- GHIDRA: <PopulateClans>g__ConstructArgs|51_1 ---
		void Gameplay_Rating_Model_RatingModel___PopulateClans_g__ConstructArgs_51_1(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58066 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		    DAT_ram_00a58066 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: <PopulateClans>b__51_0 ---
		int Gameplay_Rating_Model_RatingModel___PopulateClans_b__51_0
		              (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  longlong lVar2;
		  longlong lVar3;
		  
		  if (DAT_ram_00a58065 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo
		              );
		    DAT_ram_00a58065 = '\x01';
		  }
		  if (*(int *)(param2 + 0x1c) == 0) {
		    *(int *)(param2 + 0x1c) = *param3 + 1;
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo
		                        );
		  Gameplay_Clans_Office_View_ClanInRatingListElement___ctor(param1_00,0);
		  uVar1 = func_ii_7325(*(undefined4 *)(param2 + 0xc),*(undefined4 *)(param1 + 0xc),0);
		  *(int *)(param1_00 + 0x24) = param2;
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  lVar3 = *(longlong *)(*(int *)(param2 + 0xc) + 0x10);
		  lVar2 = Core_Data_UserData___ctor(*(undefined4 *)(param1 + 8),0);
		  *(bool *)(param1_00 + 0x28) = lVar3 == lVar2;
		  return param1_00;
		}
		*/

		/* --- GHIDRA: <PopulateUsers>b__48_1 ---
		int Gameplay_Rating_Model_RatingModel___PopulateUsers_b__48_1
		              (int param1,int param2,int param3,undefined4 param4)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  longlong lVar2;
		  longlong lVar3;
		  
		  if (DAT_ram_00a58065 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo
		              );
		    DAT_ram_00a58065 = '\x01';
		  }
		  if (*(int *)(param2 + 0x1c) == 0) {
		    *(int *)(param2 + 0x1c) = param3 + 1;
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo
		                        );
		  Gameplay_Clans_Office_View_ClanInRatingListElement___ctor(param1_00,0);
		  uVar1 = func_ii_7325(*(undefined4 *)(param2 + 0xc),*(undefined4 *)(param1 + 0xc),0);
		  *(int *)(param1_00 + 0x24) = param2;
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  lVar3 = *(longlong *)(*(int *)(param2 + 0xc) + 0x10);
		  lVar2 = Core_Data_UserData___ctor(*(undefined4 *)(param1 + 8),0);
		  *(bool *)(param1_00 + 0x28) = lVar3 == lVar2;
		  return param1_00;
		}
		*/

		/* --- GHIDRA: <CreateCultSubRatingListElementArgs>g__ConstructArgs|47_2 ---
		undefined4
		Gameplay_Rating_Model_RatingModel___CreateCultSubRatingListElementArgs_g__ConstructArgs_47_2
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  local_4 = param3;
		  uVar1 = Gameplay_Rating_Model_RatingModel__DoPopulateUsers(param1,param2,&local_4,auStack_10);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: <CreateClanSubRatingListElementArgs>g__ConstructArgs|46_2 ---
		int Gameplay_Rating_Model_RatingModel___CreateClanSubRatingListElementArgs_g__ConstructArgs_46_2
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58064 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_Filters_GenericFilter_SubFilterListElement_SubFilterData_TypeInfo);
		    DAT_ram_00a58064 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (UI_Elements_Filters_GenericFilter_SubFilterListElement_SubFilterData_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  uVar2 = Core_Extensions_Dict_CultRatingKindDicExt__GetButton128AssetId(param1,0);
		  *(undefined4 *)(iVar1 + 0xc) = uVar2;
		  uVar2 = Core_Extensions_Dict_CultRatingKindDicExt__GetIcon32AssetId(param1,0);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  return iVar1;
		}
		*/

		/* --- GHIDRA: <CreateUserSubRatingListElementArgs>g__ConstructArgs|45_2 ---
		int Gameplay_Rating_Model_RatingModel___CreateUserSubRatingListElementArgs_g__ConstructArgs_45_2
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58063 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_Filters_GenericFilter_SubFilterListElement_SubFilterData_TypeInfo);
		    DAT_ram_00a58063 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (UI_Elements_Filters_GenericFilter_SubFilterListElement_SubFilterData_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  uVar2 = Core_Extensions_Dict_ClanRatingKindDicExt__GetButton128AssetId(param1,0);
		  *(undefined4 *)(iVar1 + 0xc) = uVar2;
		  uVar2 = Core_Extensions_Dict_ClanRatingKindDicExt__GetIcon32AssetId(param1,0);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  return iVar1;
		}
		*/

		/* --- GHIDRA: <CreateClanCultFilterDatas>g__CreateData|44_0 ---
		int Gameplay_Rating_Model_RatingModel___CreateClanCultFilterDatas_g__CreateData_44_0
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58062 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_Filters_GenericFilter_SubFilterListElement_SubFilterData_TypeInfo);
		    DAT_ram_00a58062 = '\x01';
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

		/* --- GHIDRA: <CreateCultFilterDatas>g__CreateData|43_0 ---
		int Gameplay_Rating_Model_RatingModel___CreateCultFilterDatas_g__CreateData_43_0
		              (int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58061 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData_TypeInfo
		              );
		    DAT_ram_00a58061 = '\x01';
		  }
		  param1_00 = Core_Extensions_Dict_DictExt__GetAllArtikulTypeMetaFilterByType
		                        (*(undefined4 *)(param1 + 0xc),*(undefined4 *)(param2 + 0xc),0);
		  iVar1 = unnamed_function_1417
		                    (
		                    UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData_TypeInfo
		                    );
		  *(int *)(iVar1 + 0xc) = param2;
		  if (param1_00 == 0) {
		    uVar2 = Core_Extensions_Dict_ClanCultDicExt__GetTitleBarBgAssetId(param2,0);
		    *(undefined4 *)(iVar1 + 8) = uVar2;
		    uVar2 = Core_Extensions_Dict_ClanBuildingViewDicExt__GetIsleViewAssetId(param2,0);
		    *(undefined4 *)(iVar1 + 0x10) = uVar2;
		    return iVar1;
		  }
		  uVar2 = System_Collections_Generic_Dictionary_object__object____ctor(param1_00,0);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  uVar2 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription(param1_00,0);
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  return iVar1;
		}
		*/

		/* --- GHIDRA: <CreatePeriodFilterDatas>g__CreateData|42_0 ---
		int Gameplay_Rating_Model_RatingModel___CreatePeriodFilterDatas_g__CreateData_42_0
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58060 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData_TypeInfo
		              );
		    DAT_ram_00a58060 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0xc) = param1;
		  uVar2 = System_Collections_Generic_Dictionary_object__object____ctor(param1,0);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  uVar2 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription(param1,0);
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  return iVar1;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Rating_Model_RatingModel___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a5804a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_TabBarItemData__uint___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_RatingKindTypeDic__TabBarItemData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_TabBarItemData___);
		    Mono_Security_ASN1__get_Item(&System_Func_RatingKindTypeDic__TabBarItemData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_TabBarItemData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Rating_Model_RatingModel___c__GetTabBarData_b__32_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Rating_Model_RatingModel___c__GetTabBarData_b__32_1__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		    DAT_ram_00a5804a = '\x01';
		  }
		  uVar1 = *(undefined4 *)(*(int *)(param1 + 0xc) + 0x25c);
		  if (*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[1];
		  if (iVar3 == 0) {
		    if (*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Func_RatingKindTypeDic__TabBarItemData__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar3,uVar4,Method_Gameplay_Rating_Model_RatingModel___c__GetTabBarData_b__32_0__,0);
		    *(int *)(*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c) + 4) = iVar3;
		  }
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar1,iVar3,
		                     Method_System_Linq_Enumerable_Select_RatingKindTypeDic__TabBarItemData___);
		  if (*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[2];
		  if (iVar3 == 0) {
		    if (*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Func_TabBarItemData__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar3,uVar4,Method_Gameplay_Rating_Model_RatingModel___c__GetTabBarData_b__32_1__,0);
		    *(int *)(*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c) + 8) = iVar3;
		  }
		  uVar1 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar1,iVar3,Method_System_Linq_Enumerable_OrderBy_TabBarItemData__uint___);
		  uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_TabBarItemData___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021E8")]
		[Address(RVA = "0x7347", Offset = "0x7347", VA = "0x7347")]
		public TabBarItemData[] GetTabBarData()
		{
		/* --- GHIDRA: GetTabBarData ---
		undefined4
		Gameplay_Rating_Model_RatingModel__GetTabBarData
		          (undefined4 param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int param2_00;
		  ulonglong local_10;
		  int local_4;
		  
		  if (DAT_ram_00a5804b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28579);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28651);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26089);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13096);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28658);
		    DAT_ram_00a5804b = '\x01';
		  }
		  if (param2 == param3) {
		    local_10 = CONCAT44(local_10._4_4_,param2);
		    uVar1 = func_ii_1081(DAT_ram_00a66958,&local_10);
		    uVar1 = func_ii_4419(StringLiteral_28579,uVar1,0);
		  }
		  else {
		    local_10 = CONCAT44(local_10._4_4_,param2);
		    uVar1 = func_ii_1081(DAT_ram_00a66958,&local_10);
		    local_4 = param3;
		    uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		    uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_28658,uVar1,uVar2,0);
		  }
		  if (param3 == 0) {
		    local_10 = local_10 & 0xffffffff00000000;
		    uVar1 = func_ii_1081(DAT_ram_00a66958,&local_10);
		    uVar1 = func_ii_4419(StringLiteral_28651,uVar1,0);
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13096,1,0,1,0,0,0,0);
		  param2_00 = Mono_Security_ASN1Convert__ToOid
		                        (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_26089,uVar1,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(ulonglong *)(param2_00 + 0x10) = local_10;
		  uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,param2_00,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021E9")]
		[Address(RVA = "0x7348", Offset = "0x7348", VA = "0x7348")]
		public string GetPlacesText(uint lowerBound, uint upperBound)
		{
		/* --- GHIDRA: GetPlacesText ---
		undefined4
		Gameplay_Rating_Model_RatingModel__GetPlacesText
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5804c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs___get_Item__
		              );
		    DAT_ram_00a5804c = '\x01';
		  }
		  uVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x20),param3,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs___get_Item__
		                    );
		  uVar1 = System_Collections_Generic_List_object___get_Item
		                    (uVar1,param2,
		                     Method_System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs__get_Item__
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021EA")]
		[Address(RVA = "0x7349", Offset = "0x7349", VA = "0x7349")]
		public UserInRatingListElement.UserInRatingListElementArgs GetMyUser(uint ratingType, RatingPeriods period)
		{
		/* --- GHIDRA: GetMyUser ---
		undefined4
		Gameplay_Rating_Model_RatingModel__GetMyUser
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5804d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs___get_Item__
		              );
		    DAT_ram_00a5804d = '\x01';
		  }
		  uVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x24),param3,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs___get_Item__
		                    );
		  uVar1 = System_Collections_Generic_List_object___get_Item
		                    (uVar1,param2,
		                     Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs__get_Item__
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021EB")]
		[Address(RVA = "0x734A", Offset = "0x734A", VA = "0x734A")]
		public ClanInRatingListElement.ClanInRatingListElementArgs GetMyClan(uint ratingType, RatingPeriods period)
		{
		/* --- GHIDRA: GetMyClan ---
		undefined4
		Gameplay_Rating_Model_RatingModel__GetMyClan
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5804e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs_____get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs____get_Item__
		              );
		    DAT_ram_00a5804e = '\x01';
		  }
		  uVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x14),param3,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs_____get_Item__
		                    );
		  uVar1 = System_Collections_Generic_List_object___get_Item
		                    (uVar1,param2,
		                     Method_System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs____get_Item__
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021EC")]
		[Address(RVA = "0x734B", Offset = "0x734B", VA = "0x734B")]
		public UserInRatingListElement.UserInRatingListElementArgs[] GetUsers(uint ratingType, RatingPeriods period)
		{
		/* --- GHIDRA: GetUsers ---
		void Gameplay_Competition_Model_RatingModel__GetUsers
		               (int param1,undefined4 param2,undefined8 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  *(undefined8 *)(param1 + 0x18) = param3;
		  *(undefined4 *)(param1 + 0x10) = param2;
		  *(undefined4 *)(param1 + 0xc) = param5;
		  *(undefined4 *)(param1 + 8) = param4;
		  return;
		}
		*/

		/* --- GHIDRA: GetUsers ---
		undefined4
		Gameplay_Rating_Model_RatingModel__GetUsers
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5804f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs____get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs_____get_Item__
		              );
		    DAT_ram_00a5804f = '\x01';
		  }
		  uVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x18),param3,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs_____get_Item__
		                    );
		  uVar1 = System_Collections_Generic_List_object___get_Item
		                    (uVar1,param2,
		                     Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs____get_Item__
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021ED")]
		[Address(RVA = "0x734C", Offset = "0x734C", VA = "0x734C")]
		public ClanInRatingListElement.ClanInRatingListElementArgs[] GetClans(uint ratingType, RatingPeriods period)
		{
		/* --- GHIDRA: GetClans ---
		undefined4
		Gameplay_Rating_Model_RatingModel__GetClans
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58050 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs____get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs_____get_Item__
		              );
		    DAT_ram_00a58050 = '\x01';
		  }
		  uVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x1c),param3,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs_____get_Item__
		                    );
		  uVar1 = System_Collections_Generic_List_object___get_Item
		                    (uVar1,param2,
		                     Method_System_Collections_Generic_Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs____get_Item__
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021EE")]
		[Address(RVA = "0x734D", Offset = "0x734D", VA = "0x734D")]
		public CultInRatingListElement.CultInRatingListElementArgs[] GetCults(uint ratingType, RatingPeriods period)
		{
		/* --- GHIDRA: GetCults ---
		undefined4
		Gameplay_Rating_Model_RatingModel__GetCults
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_4;
		  
		  uVar2 = 0;
		  if (DAT_ram_00a58051 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs____ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs_____TryGetValue__
		              );
		    DAT_ram_00a58051 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(param1 + 0x14),param3,&local_4,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs_____TryGetValue__
		                    );
		  if (iVar1 != 0) {
		    uVar2 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                      (local_4,param2,
		                       Method_System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs____ContainsKey__
		                      );
		  }
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x00006B28 File Offset: 0x00004D28
		[Token(Token = "0x60021EF")]
		[Address(RVA = "0x734E", Offset = "0x734E", VA = "0x734E")]
		public bool HasUserCache(uint ratingType, RatingPeriods period)
		{
		/* --- GHIDRA: HasUserCache ---
		undefined4
		Gameplay_Rating_Model_RatingModel__HasUserCache
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_4;
		  
		  uVar2 = 0;
		  if (DAT_ram_00a58052 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs____ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs_____TryGetValue__
		              );
		    DAT_ram_00a58052 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(param1 + 0x18),param3,&local_4,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs_____TryGetValue__
		                    );
		  if (iVar1 != 0) {
		    uVar2 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                      (local_4,param2,
		                       Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs____ContainsKey__
		                      );
		  }
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x00006B40 File Offset: 0x00004D40
		[Token(Token = "0x60021F0")]
		[Address(RVA = "0x734F", Offset = "0x734F", VA = "0x734F")]
		public bool HasClansCache(uint ratingType, RatingPeriods period)
		{
		/* --- GHIDRA: HasClansCache ---
		undefined4
		Gameplay_Rating_Model_RatingModel__HasClansCache
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_4;
		  
		  uVar2 = 0;
		  if (DAT_ram_00a58053 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs____ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs_____TryGetValue__
		              );
		    DAT_ram_00a58053 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(param1 + 0x1c),param3,&local_4,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs_____TryGetValue__
		                    );
		  if (iVar1 != 0) {
		    uVar2 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                      (local_4,param2,
		                       Method_System_Collections_Generic_Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs____ContainsKey__
		                      );
		  }
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x00006B58 File Offset: 0x00004D58
		[Token(Token = "0x60021F1")]
		[Address(RVA = "0x7350", Offset = "0x7350", VA = "0x7350")]
		public bool HasCultsCache(uint ratingType, RatingPeriods period)
		{
		/* --- GHIDRA: HasCultsCache ---
		undefined4
		Gameplay_Rating_Model_RatingModel__HasCultsCache
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58054 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_RatingPeriods__FilterListElement_FilterData___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToArray_FilterListElement_FilterData___);
		    Mono_Security_ASN1__get_Item(&System_Func_RatingPeriods__FilterListElement_FilterData__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Model_RatingModel__CreatePeriodFilterDatas_g__CreateData_42_0__
		              );
		    DAT_ram_00a58054 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Func_RatingPeriods__FilterListElement_FilterData__TypeInfo);
		  func_ii_8070(uVar1,param1,
		               Method_Gameplay_Rating_Model_RatingModel__CreatePeriodFilterDatas_g__CreateData_42_0__
		               ,0);
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param2,uVar1,
		                     Method_System_Linq_Enumerable_Select_RatingPeriods__FilterListElement_FilterData___
		                    );
		  uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_FilterListElement_FilterData___);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021F2")]
		[Address(RVA = "0x7351", Offset = "0x7351", VA = "0x7351")]
		protected FilterListElement.FilterData[] CreatePeriodFilterDatas(params RatingPeriods[] periods)
		{
		/* --- GHIDRA: CreatePeriodFilterDatas ---
		undefined4 Gameplay_Rating_Model_RatingModel__CreatePeriodFilterDatas(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58055 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_CultDic__FilterWithIconListElement_FilterWithIconData___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_FilterWithIconListElement_FilterWithIconData___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_CultDic__FilterWithIconListElement_FilterWithIconData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Rating_Model_RatingModel__CreateCultFilterDatas_g__CreateData_43_0__
		              );
		    DAT_ram_00a58055 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(*(int *)(param1 + 0xc) + 0x30);
		  uVar1 = unnamed_function_1417
		                    (System_Func_CultDic__FilterWithIconListElement_FilterWithIconData__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar1,0,
		             Method_Gameplay_Rating_Model_RatingModel__CreateCultFilterDatas_g__CreateData_43_0__,0)
		  ;
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param1_00,uVar1,
		                     Method_System_Linq_Enumerable_Select_CultDic__FilterWithIconListElement_FilterWithIconData___
		                    );
		  uVar1 = func_ii_6295(uVar1,
		                       Method_System_Linq_Enumerable_ToArray_FilterWithIconListElement_FilterWithIconData___
		                      );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021F3")]
		[Address(RVA = "0x7352", Offset = "0x7352", VA = "0x7352")]
		private FilterWithIconListElement.FilterWithIconData[] CreateCultFilterDatas()
		{
		/* --- GHIDRA: CreateCultFilterDatas ---
		undefined4 Gameplay_Rating_Model_RatingModel__CreateCultFilterDatas(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58056 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ClanCultDic__FilterWithIconListElement_FilterWithIconData___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_FilterWithIconListElement_FilterWithIconData___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_ClanCultDic__FilterWithIconListElement_FilterWithIconData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Model_RatingModel__CreateClanCultFilterDatas_g__CreateData_44_0__
		              );
		    DAT_ram_00a58056 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(*(int *)(param1 + 0xc) + 0x24);
		  uVar1 = unnamed_function_1417
		                    (System_Func_ClanCultDic__FilterWithIconListElement_FilterWithIconData__TypeInfo
		                    );
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,
		             Method_Gameplay_Rating_Model_RatingModel__CreateClanCultFilterDatas_g__CreateData_44_0__
		             ,0);
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param1_00,uVar1,
		                     Method_System_Linq_Enumerable_Select_ClanCultDic__FilterWithIconListElement_FilterWithIconData___
		                    );
		  uVar1 = func_ii_6295(uVar1,
		                       Method_System_Linq_Enumerable_ToArray_FilterWithIconListElement_FilterWithIconData___
		                      );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021F4")]
		[Address(RVA = "0x7353", Offset = "0x7353", VA = "0x7353")]
		private FilterWithIconListElement.FilterWithIconData[] CreateClanCultFilterDatas()
		{
		/* --- GHIDRA: CreateClanCultFilterDatas ---
		undefined4
		Gameplay_Rating_Model_RatingModel__CreateClanCultFilterDatas(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58057 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_UserRatingKindDic__uint___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_UserRatingKindDic__SubFilterListElement_SubFilterData___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToArray_SubFilterListElement_SubFilterData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_UserRatingKindDic___);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_UserRatingKindDic__SubFilterListElement_SubFilterData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_UserRatingKindDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_UserRatingKindDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Model_RatingModel__CreateUserSubRatingListElementArgs_g__ConstructArgs_45_2__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Model_RatingModel___c__CreateUserSubRatingListElementArgs_b__45_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Model_RatingModel___c__CreateUserSubRatingListElementArgs_b__45_1__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		    DAT_ram_00a58057 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0xc) + 0x260);
		  if (*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[3];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar3;
		    iVar4 = unnamed_function_1417(System_Func_UserRatingKindDic__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar4,uVar1,
		               Method_Gameplay_Rating_Model_RatingModel___c__CreateUserSubRatingListElementArgs_b__45_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c) + 0xc) = iVar4;
		  }
		  uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar2,iVar4,Method_System_Linq_Enumerable_Where_UserRatingKindDic___);
		  if (*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[4];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar3;
		    iVar4 = unnamed_function_1417(System_Func_UserRatingKindDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar4,uVar1,
		               Method_Gameplay_Rating_Model_RatingModel___c__CreateUserSubRatingListElementArgs_b__45_1__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c) + 0x10) = iVar4;
		  }
		  uVar2 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar2,iVar4,Method_System_Linq_Enumerable_OrderBy_UserRatingKindDic__uint___);
		  uVar1 = unnamed_function_1417
		                    (System_Func_UserRatingKindDic__SubFilterListElement_SubFilterData__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar1,0,
		             Method_Gameplay_Rating_Model_RatingModel__CreateUserSubRatingListElementArgs_g__ConstructArgs_45_2__
		             ,0);
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar2,uVar1,
		                     Method_System_Linq_Enumerable_Select_UserRatingKindDic__SubFilterListElement_SubFilterData___
		                    );
		  uVar2 = func_ii_6295(uVar2,
		                       Method_System_Linq_Enumerable_ToArray_SubFilterListElement_SubFilterData___);
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021F5")]
		[Address(RVA = "0x7354", Offset = "0x7354", VA = "0x7354")]
		private SubFilterListElement.SubFilterData[] CreateUserSubRatingListElementArgs()
		{
		/* --- GHIDRA: CreateUserSubRatingListElementArgs ---
		undefined4
		Gameplay_Rating_Model_RatingModel__CreateUserSubRatingListElementArgs(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58058 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_ClanRatingKindDic__uint___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ClanRatingKindDic__SubFilterListElement_SubFilterData___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToArray_SubFilterListElement_SubFilterData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_ClanRatingKindDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_ClanRatingKindDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_ClanRatingKindDic__SubFilterListElement_SubFilterData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_ClanRatingKindDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Model_RatingModel__CreateClanSubRatingListElementArgs_g__ConstructArgs_46_2__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Model_RatingModel___c__CreateClanSubRatingListElementArgs_b__46_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Model_RatingModel___c__CreateClanSubRatingListElementArgs_b__46_1__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		    DAT_ram_00a58058 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0xc) + 0x264);
		  if (*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[5];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar3;
		    iVar4 = unnamed_function_1417(System_Func_ClanRatingKindDic__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar4,uVar1,
		               Method_Gameplay_Rating_Model_RatingModel___c__CreateClanSubRatingListElementArgs_b__46_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c) + 0x14) = iVar4;
		  }
		  uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar2,iVar4,Method_System_Linq_Enumerable_Where_ClanRatingKindDic___);
		  if (*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[6];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar3;
		    iVar4 = unnamed_function_1417(System_Func_ClanRatingKindDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar4,uVar1,
		               Method_Gameplay_Rating_Model_RatingModel___c__CreateClanSubRatingListElementArgs_b__46_1__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c) + 0x18) = iVar4;
		  }
		  uVar2 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar2,iVar4,Method_System_Linq_Enumerable_OrderBy_ClanRatingKindDic__uint___);
		  uVar1 = unnamed_function_1417
		                    (System_Func_ClanRatingKindDic__SubFilterListElement_SubFilterData__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar1,0,
		             Method_Gameplay_Rating_Model_RatingModel__CreateClanSubRatingListElementArgs_g__ConstructArgs_46_2__
		             ,0);
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar2,uVar1,
		                     Method_System_Linq_Enumerable_Select_ClanRatingKindDic__SubFilterListElement_SubFilterData___
		                    );
		  uVar2 = func_ii_6295(uVar2,
		                       Method_System_Linq_Enumerable_ToArray_SubFilterListElement_SubFilterData___);
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021F6")]
		[Address(RVA = "0x7355", Offset = "0x7355", VA = "0x7355")]
		private SubFilterListElement.SubFilterData[] CreateClanSubRatingListElementArgs()
		{
		/* --- GHIDRA: CreateClanSubRatingListElementArgs ---
		undefined4
		Gameplay_Rating_Model_RatingModel__CreateClanSubRatingListElementArgs(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58059 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_CultRatingKindDic__uint___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_CultRatingKindDic__SubFilterListElement_SubFilterData___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToArray_SubFilterListElement_SubFilterData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_CultRatingKindDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_CultRatingKindDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_CultRatingKindDic__SubFilterListElement_SubFilterData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_CultRatingKindDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Model_RatingModel__CreateCultSubRatingListElementArgs_g__ConstructArgs_47_2__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Model_RatingModel___c__CreateCultSubRatingListElementArgs_b__47_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Model_RatingModel___c__CreateCultSubRatingListElementArgs_b__47_1__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		    DAT_ram_00a58059 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0xc) + 0x268);
		  if (*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[7];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar3;
		    iVar4 = unnamed_function_1417(System_Func_CultRatingKindDic__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar4,uVar1,
		               Method_Gameplay_Rating_Model_RatingModel___c__CreateCultSubRatingListElementArgs_b__47_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c) + 0x1c) = iVar4;
		  }
		  uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar2,iVar4,Method_System_Linq_Enumerable_Where_CultRatingKindDic___);
		  if (*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[8];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar3;
		    iVar4 = unnamed_function_1417(System_Func_CultRatingKindDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar4,uVar1,
		               Method_Gameplay_Rating_Model_RatingModel___c__CreateCultSubRatingListElementArgs_b__47_1__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c) + 0x20) = iVar4;
		  }
		  uVar2 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar2,iVar4,Method_System_Linq_Enumerable_OrderBy_CultRatingKindDic__uint___);
		  uVar1 = unnamed_function_1417
		                    (System_Func_CultRatingKindDic__SubFilterListElement_SubFilterData__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar1,0,
		             Method_Gameplay_Rating_Model_RatingModel__CreateCultSubRatingListElementArgs_g__ConstructArgs_47_2__
		             ,0);
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar2,uVar1,
		                     Method_System_Linq_Enumerable_Select_CultRatingKindDic__SubFilterListElement_SubFilterData___
		                    );
		  uVar2 = func_ii_6295(uVar2,
		                       Method_System_Linq_Enumerable_ToArray_SubFilterListElement_SubFilterData___);
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021F7")]
		[Address(RVA = "0x7356", Offset = "0x7356", VA = "0x7356")]
		private SubFilterListElement.SubFilterData[] CreateCultSubRatingListElementArgs()
		{
		/* --- GHIDRA: CreateCultSubRatingListElementArgs ---
		void Gameplay_Rating_Model_RatingModel__CreateCultSubRatingListElementArgs
		               (undefined4 param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int param1_00;
		  
		  if (DAT_ram_00a5805a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_UserInRating__UserInRatingListElement_UserInRatingListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_UserInRatingListElement_UserInRatingListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_UserInRating___);
		    Mono_Security_ASN1__get_Item(&System_Func_UserInRating__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_UserInRating__int__UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Rating_Model_RatingModel__PopulateUsers_b__48_1__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Rating_Model_RatingModel___c__PopulateUsers_b__48_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		    DAT_ram_00a5805a = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param2 + 0xc);
		  if (*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c);
		  param1_00 = puVar3[9];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Rating_Model_RatingModel___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar3;
		    param1_00 = unnamed_function_1417(System_Func_UserInRating__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (param1_00,uVar1,Method_Gameplay_Rating_Model_RatingModel___c__PopulateUsers_b__48_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Rating_Model_RatingModel___c_TypeInfo + 0x5c) + 0x24) = param1_00;
		  }
		  uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar2,param1_00,Method_System_Linq_Enumerable_Where_UserInRating___);
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Func_UserInRating__int__UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		                    );
		  System_Func_object__int__long___Invoke
		            (uVar1,param1,Method_Gameplay_Rating_Model_RatingModel__PopulateUsers_b__48_1__,0);
		  uVar2 = System_Linq_Enumerable__SelectMany_ValueTuple_object__object___object_
		                    (uVar2,uVar1,
		                     Method_System_Linq_Enumerable_Select_UserInRating__UserInRatingListElement_UserInRatingListElementArgs___
		                    );
		  uVar2 = func_ii_6295(uVar2,
		                       Method_System_Linq_Enumerable_ToArray_UserInRatingListElement_UserInRatingListElementArgs___
		                      );
		  Gameplay_Rating_Model_RatingModel__PopulateUsers
		            (param1,uVar2,param3,param4,*(double *)(param2 + 0x10),*(undefined4 *)(param2 + 0x18),
		             param2);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F8")]
		[Address(RVA = "0x7357", Offset = "0x7357", VA = "0x7357")]
		public void PopulateUsers(ProtoGetUsersRatingAns msg, uint ratingType, RatingPeriods period)
		{
		/* --- GHIDRA: PopulateUsers ---
		void Gameplay_Rating_Model_RatingModel__PopulateUsers
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,double param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  longlong lVar5;
		  longlong lVar6;
		  float8 local_8;
		  
		  local_8 = (float8)param5;
		  if (DAT_ram_00a5805b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs_____ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs_____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs_____get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs___set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs_____set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs____set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs__set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs____TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement_UserInRatingListElementArgs_TypeInfo
		              );
		    DAT_ram_00a5805b = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_Int32Enum__uint___Clear
		                    (*(undefined4 *)(param1 + 0x14),param4,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs_____ContainsKey__
		                    );
		  if (iVar1 == 0) {
		    uVar4 = *(undefined4 *)(param1 + 0x14);
		    uVar2 = unnamed_function_1417
		                      (
		                      System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs____TypeInfo
		                      );
		    System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		              (uVar2,
		               Method_System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs_____ctor__
		              );
		    System_Collections_Generic_Dictionary_Int32Enum__object___ContainsKey
		              (uVar4,param4,uVar2,
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs_____set_Item__
		              );
		  }
		  iVar1 = 0;
		  uVar2 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x14),param4,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs_____get_Item__
		                    );
		  System_Collections_Generic_Dictionary_uint__object___get_Item
		            (uVar2,param3,param2,
		             Method_System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs____set_Item__
		            );
		  iVar3 = System_Collections_Generic_Dictionary_Int32Enum__uint___Clear
		                    (*(undefined4 *)(param1 + 0x20),param4,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs___ContainsKey__
		                    );
		  if (iVar3 == 0) {
		    uVar4 = *(undefined4 *)(param1 + 0x20);
		    uVar2 = unnamed_function_1417
		                      (
		                      System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		                      );
		    System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		              (uVar2,
		               Method_System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs___ctor__
		              );
		    System_Collections_Generic_Dictionary_Int32Enum__object___ContainsKey
		              (uVar4,param4,uVar2,
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs___set_Item__
		              );
		  }
		  uVar2 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x20),param4,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs___get_Item__
		                    );
		  iVar3 = System_Double__Equals(&local_8,-1.0,0);
		  if (iVar3 == 0) {
		    iVar1 = unnamed_function_1417
		                      (
		                      Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement_UserInRatingListElementArgs_TypeInfo
		                      );
		    Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement___ctor(iVar1,0);
		    uVar4 = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(iVar1 + 0x28) = param6;
		    *(undefined4 *)(iVar1 + 0x1c) = uVar4;
		    if ((double)local_8 < 1.8446744073709552e+19 && 0.0 <= (double)local_8) {
		      lVar5 = (longlong)(double)local_8;
		    }
		    else {
		      lVar5 = 0;
		    }
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      lVar6 = (longlong)(double)local_8;
		    }
		    else {
		      lVar6 = -0x8000000000000000;
		    }
		    if (0.0 <= (double)local_8) {
		      lVar6 = lVar5;
		    }
		    *(longlong *)(iVar1 + 0x20) = lVar6;
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Item
		            (uVar2,param3,iVar1,
		             Method_System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs__set_Item__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F9")]
		[Address(RVA = "0x7358", Offset = "0x7358", VA = "0x7358")]
		protected void DoPopulateUsers(UserInRatingListElement.UserInRatingListElementArgs[] usersInRatingArgs, uint ratingType, RatingPeriods period, double userRating, int userPlace)
		{
		/* --- GHIDRA: DoPopulateUsers ---
		int Gameplay_Rating_Model_RatingModel__DoPopulateUsers
		              (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  int param1_00;
		  uint *puVar1;
		  undefined4 uVar2;
		  int *param1_01;
		  int iVar3;
		  double dVar4;
		  longlong lVar5;
		  uint uVar6;
		  longlong lVar7;
		  
		  if (DAT_ram_00a5805c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement_UserInRatingListElementArgs_TypeInfo
		              );
		    DAT_ram_00a5805c = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement_UserInRatingListElementArgs_TypeInfo
		                        );
		  Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement___ctor(param1_00,0);
		  uVar2 = *(undefined4 *)(param2 + 0xc);
		  param1_01 = *(int **)(param1 + 0x10);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (Core_Cache_User_IUserInfoWrapper_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8))
		      {
		        puVar1 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e991bd;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_01,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x80e991bd:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_01,uVar2,puVar1[1]);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  dVar4 = *(double *)(param2 + 0x10);
		  if (dVar4 < 1.8446744073709552e+19 && 0.0 <= dVar4) {
		    lVar5 = (longlong)dVar4;
		  }
		  else {
		    lVar5 = 0;
		  }
		  if (ABS(dVar4) < 9.223372036854776e+18) {
		    lVar7 = (longlong)dVar4;
		  }
		  else {
		    lVar7 = -0x8000000000000000;
		  }
		  if (0.0 <= dVar4) {
		    lVar7 = lVar5;
		  }
		  *(longlong *)(param1_00 + 0x20) = lVar7;
		  *(int *)(param1_00 + 0x28) = *param3 + 1;
		  lVar7 = *(longlong *)(*(int *)(param2 + 0xc) + 0x10);
		  lVar5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(param1 + 8),0);
		  *(bool *)(param1_00 + 0x2c) = lVar7 == lVar5;
		  return param1_00;
		}
		*/

		}

		// Token: 0x060021FA RID: 8698 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021FA")]
		[Address(RVA = "0x7359", Offset = "0x7359", VA = "0x7359")]
		private UserInRatingListElement.UserInRatingListElementArgs ConstructArgs(UserInRating userInRating, in int index)
		{
		/* --- GHIDRA: ConstructArgs ---
		void Gameplay_Rating_Model_RatingModel__ConstructArgs
		               (int param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int param1_00;
		  undefined4 uVar3;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5805d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ClanInRating_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs_____ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs_____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs_____get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs__set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs___set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs_____set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs____set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs____TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ClanInRating__ClanInRatingListElement_ClanInRatingListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_ClanInRatingListElement_ClanInRatingListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_ClanInRating__int__ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Rating_Model_RatingModel__PopulateClans_b__51_0__)
		    ;
		    DAT_ram_00a5805d = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param2 + 0xc);
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Func_ClanInRating__int__ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		                    );
		  System_Func_object__int__long___Invoke
		            (uVar1,param1,Method_Gameplay_Rating_Model_RatingModel__PopulateClans_b__51_0__,0);
		  uVar1 = System_Linq_Enumerable__SelectMany_ValueTuple_object__object___object_
		                    (uVar3,uVar1,
		                     Method_System_Linq_Enumerable_Select_ClanInRating__ClanInRatingListElement_ClanInRatingListElementArgs___
		                    );
		  uVar1 = func_ii_6295(uVar1,
		                       Method_System_Linq_Enumerable_ToArray_ClanInRatingListElement_ClanInRatingListElementArgs___
		                      );
		  iVar2 = System_Collections_Generic_Dictionary_Int32Enum__uint___Clear
		                    (*(undefined4 *)(param1 + 0x18),param4,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs_____ContainsKey__
		                    );
		  if (iVar2 == 0) {
		    param1_01 = *(undefined4 *)(param1 + 0x18);
		    uVar3 = unnamed_function_1417
		                      (
		                      System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs____TypeInfo
		                      );
		    System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		              (uVar3,
		               Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs_____ctor__
		              );
		    System_Collections_Generic_Dictionary_Int32Enum__object___ContainsKey
		              (param1_01,param4,uVar3,
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs_____set_Item__
		              );
		  }
		  uVar3 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x18),param4,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs_____get_Item__
		                    );
		  System_Collections_Generic_Dictionary_uint__object___get_Item
		            (uVar3,param3,uVar1,
		             Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs____set_Item__
		            );
		  iVar2 = System_Collections_Generic_Dictionary_Int32Enum__uint___Clear
		                    (*(undefined4 *)(param1 + 0x24),param4,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs___ContainsKey__
		                    );
		  if (iVar2 == 0) {
		    uVar3 = *(undefined4 *)(param1 + 0x24);
		    uVar1 = unnamed_function_1417
		                      (
		                      System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		                      );
		    System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		              (uVar1,
		               Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs___ctor__
		              );
		    System_Collections_Generic_Dictionary_Int32Enum__object___ContainsKey
		              (uVar3,param4,uVar1,
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs___set_Item__
		              );
		  }
		  if ((*(double *)(param2 + 0x10) != -1.0) && (*(int *)(*(int *)(param1 + 8) + 0x68) != 0)) {
		    iVar2 = unnamed_function_1417(Protocol_Rating_ClanInRating_TypeInfo);
		    *(undefined4 *)(iVar2 + 0xc) = *(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x68) + 0x1c);
		    *(undefined4 *)(iVar2 + 0x1c) = *(undefined4 *)(param2 + 0x18);
		    *(undefined8 *)(iVar2 + 0x10) = *(undefined8 *)(param2 + 0x10);
		    uVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                      (*(undefined4 *)(param1 + 0x24),param4,
		                       Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs___get_Item__
		                      );
		    param1_00 = unnamed_function_1417
		                          (
		                          Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo
		                          );
		    Gameplay_Clans_Office_View_ClanInRatingListElement___ctor(param1_00,0);
		    *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(*(int *)(param1 + 8) + 0x68);
		    uVar3 = *(undefined4 *)(param2 + 0x18);
		    *(int *)(param1_00 + 0x24) = iVar2;
		    *(undefined4 *)(param1_00 + 0x20) = uVar3;
		    System_Collections_Generic_Dictionary_uint__object___get_Item
		              (uVar1,param3,param1_00,
		               Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs__set_Item__
		              );
		    return;
		  }
		  uVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x24),param4,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs___get_Item__
		                    );
		  System_Collections_Generic_Dictionary_uint__object___get_Item
		            (uVar1,param3,0,
		             Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs__set_Item__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021FB")]
		[Address(RVA = "0x735A", Offset = "0x735A", VA = "0x735A")]
		public void PopulateClans(ProtoGetClansRatingAns msg, uint ratingType, RatingPeriods period)
		{
		/* --- GHIDRA: PopulateClans ---
		void Gameplay_Rating_Model_RatingModel__PopulateClans
		               (int param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5805e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs_____ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs_____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs_____get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs_____set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs____set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs____TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_CultInRating__CultInRatingListElement_CultInRatingListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_CultInRatingListElement_CultInRatingListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_CultInRating__int__CultInRatingListElement_CultInRatingListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Rating_Model_RatingModel___c__DisplayClass52_0__PopulateCults_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingModel___c__DisplayClass52_0_TypeInfo);
		    DAT_ram_00a5805e = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Gameplay_Rating_Model_RatingModel___c__DisplayClass52_0_TypeInfo);
		  *(int *)(iVar1 + 8) = param1;
		  uVar2 = func_ii_6965(*(undefined4 *)(param1 + 8),0);
		  *(undefined4 *)(iVar1 + 0xc) = uVar2;
		  uVar3 = *(undefined4 *)(param2 + 0xc);
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Func_CultInRating__int__CultInRatingListElement_CultInRatingListElementArgs__TypeInfo
		                    );
		  System_Func_object__int__long___Invoke
		            (uVar2,iVar1,
		             Method_Gameplay_Rating_Model_RatingModel___c__DisplayClass52_0__PopulateCults_b__0__,0)
		  ;
		  uVar2 = System_Linq_Enumerable__SelectMany_ValueTuple_object__object___object_
		                    (uVar3,uVar2,
		                     Method_System_Linq_Enumerable_Select_CultInRating__CultInRatingListElement_CultInRatingListElementArgs___
		                    );
		  uVar2 = func_ii_6295(uVar2,
		                       Method_System_Linq_Enumerable_ToArray_CultInRatingListElement_CultInRatingListElementArgs___
		                      );
		  iVar1 = System_Collections_Generic_Dictionary_Int32Enum__uint___Clear
		                    (*(undefined4 *)(param1 + 0x1c),param4,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs_____ContainsKey__
		                    );
		  if (iVar1 == 0) {
		    param1_00 = *(undefined4 *)(param1 + 0x1c);
		    uVar3 = unnamed_function_1417
		                      (
		                      System_Collections_Generic_Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs____TypeInfo
		                      );
		    System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		              (uVar3,
		               Method_System_Collections_Generic_Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs_____ctor__
		              );
		    System_Collections_Generic_Dictionary_Int32Enum__object___ContainsKey
		              (param1_00,param4,uVar3,
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs_____set_Item__
		              );
		  }
		  uVar3 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x1c),param4,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs_____get_Item__
		                    );
		  System_Collections_Generic_Dictionary_uint__object___get_Item
		            (uVar3,param3,uVar2,
		             Method_System_Collections_Generic_Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs____set_Item__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060021FC RID: 8700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021FC")]
		[Address(RVA = "0x735B", Offset = "0x735B", VA = "0x735B")]
		public void PopulateCults(ProtoGetCultsRatingAns msg, uint ratingType, RatingPeriods period)
		{
		/* --- GHIDRA: PopulateCults ---
		int Gameplay_Rating_Model_RatingModel__PopulateCults(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5805f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_Filters_GenericFilter_FilterListElement_FilterData_TypeInfo);
		    DAT_ram_00a5805f = '\x01';
		  }
		  uVar1 = func_ii_7625(*(undefined4 *)(param1 + 0xc),param2,0);
		  iVar2 = unnamed_function_1417
		                    (UI_Elements_Filters_GenericFilter_FilterListElement_FilterData_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  uVar1 = Core_Extensions_Dict_DictExt__GetRatingTypeDic(uVar1,0);
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  return iVar2;
		}
		*/

		}

		// Token: 0x060021FD RID: 8701 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021FD")]
		[Address(RVA = "0x735C", Offset = "0x735C", VA = "0x735C")]
		[CompilerGenerated]
		private FilterListElement.FilterData <CreatePeriodFilterDatas>g__CreateData|42_0(RatingPeriods period)
		{
			return null;
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021FE")]
		[Address(RVA = "0x735D", Offset = "0x735D", VA = "0x735D")]
		[CompilerGenerated]
		internal static FilterWithIconListElement.FilterWithIconData <CreateCultFilterDatas>g__CreateData|43_0(CultDic cultDic)
		{
			return null;
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60021FF")]
		[Address(RVA = "0x735E", Offset = "0x735E", VA = "0x735E")]
		[CompilerGenerated]
		private FilterWithIconListElement.FilterWithIconData <CreateClanCultFilterDatas>g__CreateData|44_0(ClanCultDic clanCultDic)
		{
			return null;
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002200")]
		[Address(RVA = "0x735F", Offset = "0x735F", VA = "0x735F")]
		[CompilerGenerated]
		internal static SubFilterListElement.SubFilterData <CreateUserSubRatingListElementArgs>g__ConstructArgs|45_2(UserRatingKindDic dic)
		{
			return null;
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002201")]
		[Address(RVA = "0x7360", Offset = "0x7360", VA = "0x7360")]
		[CompilerGenerated]
		internal static SubFilterListElement.SubFilterData <CreateClanSubRatingListElementArgs>g__ConstructArgs|46_2(ClanRatingKindDic dic)
		{
			return null;
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002202")]
		[Address(RVA = "0x7361", Offset = "0x7361", VA = "0x7361")]
		[CompilerGenerated]
		internal static SubFilterListElement.SubFilterData <CreateCultSubRatingListElementArgs>g__ConstructArgs|47_2(CultRatingKindDic dic)
		{
			return null;
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002205")]
		[Address(RVA = "0x7364", Offset = "0x7364", VA = "0x7364")]
		[CompilerGenerated]
		private ClanInRatingListElement.ClanInRatingListElementArgs <PopulateClans>g__ConstructArgs|51_1(ClanInRating clan, in int index)
		{
			return null;
		}

		// Token: 0x040012A0 RID: 4768
		[Token(Token = "0x40012A0")]
		[FieldOffset(Offset = "0xC")]
		public readonly Dictionaries Dict;

		// Token: 0x040012A1 RID: 4769
		[Token(Token = "0x40012A1")]
		[FieldOffset(Offset = "0x10")]
		protected readonly IUserCache _userCache;

		// Token: 0x040012A2 RID: 4770
		[Token(Token = "0x40012A2")]
		[FieldOffset(Offset = "0x14")]
		private readonly Dictionary<RatingPeriods, Dictionary<uint, UserInRatingListElement.UserInRatingListElementArgs[]>> _usersCache;

		// Token: 0x040012A3 RID: 4771
		[Token(Token = "0x40012A3")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<RatingPeriods, Dictionary<uint, ClanInRatingListElement.ClanInRatingListElementArgs[]>> _clansCache;

		// Token: 0x040012A4 RID: 4772
		[Token(Token = "0x40012A4")]
		[FieldOffset(Offset = "0x1C")]
		private readonly Dictionary<RatingPeriods, Dictionary<uint, CultInRatingListElement.CultInRatingListElementArgs[]>> _cultsCache;

		// Token: 0x040012A5 RID: 4773
		[Token(Token = "0x40012A5")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<RatingPeriods, Dictionary<uint, UserInRatingListElement.UserInRatingListElementArgs>> _myUserCache;

		// Token: 0x040012A6 RID: 4774
		[Token(Token = "0x40012A6")]
		[FieldOffset(Offset = "0x24")]
		private readonly Dictionary<RatingPeriods, Dictionary<uint, ClanInRatingListElement.ClanInRatingListElementArgs>> _myClanCache;

		// Token: 0x040012A7 RID: 4775
		[Token(Token = "0x40012A7")]
		[FieldOffset(Offset = "0x28")]
		private FilterWithIconListElement.FilterWithIconData[] _cultExtraFilterDatas;

		// Token: 0x040012A8 RID: 4776
		[Token(Token = "0x40012A8")]
		[FieldOffset(Offset = "0x2C")]
		private FilterWithIconListElement.FilterWithIconData[] _clanCultExtraFilterDatas;

		// Token: 0x040012A9 RID: 4777
		[Token(Token = "0x40012A9")]
		[FieldOffset(Offset = "0x30")]
		private FilterListElement.FilterData[] _usersFilterDatas;

		// Token: 0x040012AA RID: 4778
		[Token(Token = "0x40012AA")]
		[FieldOffset(Offset = "0x34")]
		private FilterListElement.FilterData[] _clansFilterDatas;

		// Token: 0x040012AB RID: 4779
		[Token(Token = "0x40012AB")]
		[FieldOffset(Offset = "0x38")]
		private FilterListElement.FilterData[] _cultsFilterDatas;

		// Token: 0x040012AC RID: 4780
		[Token(Token = "0x40012AC")]
		[FieldOffset(Offset = "0x3C")]
		private SubFilterListElement.SubFilterData[] _usersSubFilters;

		// Token: 0x040012AD RID: 4781
		[Token(Token = "0x40012AD")]
		[FieldOffset(Offset = "0x40")]
		private SubFilterListElement.SubFilterData[] _clansSubFilters;

		// Token: 0x040012AE RID: 4782
		[Token(Token = "0x40012AE")]
		[FieldOffset(Offset = "0x44")]
		private SubFilterListElement.SubFilterData[] _cultsSubFilters;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CultExtraFilterDatas ---
		int Gameplay_Rating_Model_RatingModel__get_CultExtraFilterDatas(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x2c);
		  if (iVar1 == 0) {
		    iVar1 = Gameplay_Rating_Model_RatingModel__CreateCultFilterDatas(param1,param1);
		    *(int *)(param1 + 0x2c) = iVar1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_ClanCultExtraFilterDatas ---
		int Gameplay_Rating_Model_RatingModel__get_ClanCultExtraFilterDatas(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a58046 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_RatingPeriods___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Field__PrivateImplementationDetails__47A696487DD1E818E2E1E0C043C22CAD421DC3113043F9BA418EAAB2A8B882AB
		              );
		    DAT_ram_00a58046 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x30);
		  if (iVar1 == 0) {
		    param1_00 = Mono_Security_ASN1Convert__ToOid(Protocol_Rating_RatingPeriods___TypeInfo,5);
		    System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray
		              (param1_00,
		               Field__PrivateImplementationDetails__47A696487DD1E818E2E1E0C043C22CAD421DC3113043F9BA418EAAB2A8B882AB
		               ,0);
		    iVar1 = Gameplay_Rating_Model_RatingModel__HasCultsCache(param1,param1_00,param1);
		    *(int *)(param1 + 0x30) = iVar1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_UserPeriodFilterDatas ---
		int Gameplay_Rating_Model_RatingModel__get_UserPeriodFilterDatas(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a58047 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_RatingPeriods___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Field__PrivateImplementationDetails__4636993D3E1DA4E9D6B8F87B79E8F7C6D018580D52661950EABC3845C5897A4D
		              );
		    DAT_ram_00a58047 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x34);
		  if (iVar1 == 0) {
		    param1_00 = Mono_Security_ASN1Convert__ToOid(Protocol_Rating_RatingPeriods___TypeInfo,3);
		    System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray
		              (param1_00,
		               Field__PrivateImplementationDetails__4636993D3E1DA4E9D6B8F87B79E8F7C6D018580D52661950EABC3845C5897A4D
		               ,0);
		    iVar1 = Gameplay_Rating_Model_RatingModel__HasCultsCache(param1,param1_00,param1);
		    *(int *)(param1 + 0x34) = iVar1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_ClansPeriodFilterDatas ---
		int Gameplay_Rating_Model_RatingModel__get_ClansPeriodFilterDatas(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58048 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_RatingPeriods___TypeInfo);
		    DAT_ram_00a58048 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x38);
		  if (iVar1 == 0) {
		    iVar1 = Mono_Security_ASN1Convert__ToOid(Protocol_Rating_RatingPeriods___TypeInfo,2);
		    *(undefined8 *)(iVar1 + 0x10) = 0x400000005;
		    iVar1 = Gameplay_Rating_Model_RatingModel__HasCultsCache(param1,iVar1,param1);
		    *(int *)(param1 + 0x38) = iVar1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_CultsPeriodFilterDatas ---
		int Gameplay_Rating_Model_RatingModel__get_CultsPeriodFilterDatas(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x3c);
		  if (iVar1 == 0) {
		    iVar1 = Gameplay_Rating_Model_RatingModel__CreateClanCultFilterDatas(param1,param1);
		    *(int *)(param1 + 0x3c) = iVar1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_UsersSubFilters ---
		int Gameplay_Rating_Model_RatingModel__get_UsersSubFilters(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x40);
		  if (iVar1 == 0) {
		    iVar1 = Gameplay_Rating_Model_RatingModel__CreateUserSubRatingListElementArgs(param1,param1);
		    *(int *)(param1 + 0x40) = iVar1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_ClansSubFilters ---
		int Gameplay_Rating_Model_RatingModel__get_ClansSubFilters(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x44);
		  if (iVar1 == 0) {
		    iVar1 = Gameplay_Rating_Model_RatingModel__CreateClanSubRatingListElementArgs(param1,param1);
		    *(int *)(param1 + 0x44) = iVar1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_CultsSubFilters ---
		void Gameplay_Rating_Model_RatingModel__get_CultsSubFilters
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a58049 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs______ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs______ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs______ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs_____TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs_____TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs_____TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58049 = '\x01';
		  }
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs_____TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar2,
		             Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs______ctor__
		            );
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs_____TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar2,
		             Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs______ctor__
		            );
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs_____TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar2,
		             Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs______ctor__
		            );
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs___TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar2,
		             Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs____ctor__
		            );
		  *(undefined4 *)(param1 + 0x20) = uVar2;
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs___TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar2,
		             Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs____ctor__
		            );
		  *(undefined4 *)(param1 + 0x24) = uVar2;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
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
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x80e96da0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e96da0:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  *(undefined4 *)(param1 + 0xc) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x158);
		        goto code_r0x80e96e55;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80e96e55:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  *(undefined4 *)(param1 + 0x10) = *(undefined4 *)(iVar5 + 0x14);
		  return;
		}
		*/


		/* --- GHIDRA: SetRating ---
		undefined4 Gameplay_Competition_Model_RatingModel__SetRating(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a63ac3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_RatingModel_RatingRecord__UserInRatingListElement_UserInRatingListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_UserInRatingListElement_UserInRatingListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_RatingModel_RatingRecord__UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Model_RatingModel___c__GetCompetitionRatingUsers_b__7_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Model_RatingModel___c_TypeInfo);
		    DAT_ram_00a63ac3 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x14);
		  if (*(int *)(Gameplay_Competition_Model_RatingModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Competition_Model_RatingModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_Competition_Model_RatingModel___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_Competition_Model_RatingModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Competition_Model_RatingModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_Competition_Model_RatingModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_00 = unnamed_function_1417
		                          (
		                          System_Func_RatingModel_RatingRecord__UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		                          );
		    System_Linq_Enumerable__Where_object_
		              (param1_00,param2_00,
		               Method_Gameplay_Competition_Model_RatingModel___c__GetCompetitionRatingUsers_b__7_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Competition_Model_RatingModel___c_TypeInfo + 0x5c) + 4) = param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar1,param1_00,
		                     Method_System_Linq_Enumerable_Select_RatingModel_RatingRecord__UserInRatingListElement_UserInRatingListElementArgs___
		                    );
		  uVar1 = func_ii_6295(uVar1,
		                       Method_System_Linq_Enumerable_ToArray_UserInRatingListElement_UserInRatingListElementArgs___
		                      );
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GetCompetitionRatingUsers ---
		int Gameplay_Competition_Model_RatingModel__GetCompetitionRatingUsers(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a63ac4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement_UserInRatingListElementArgs_TypeInfo
		              );
		    DAT_ram_00a63ac4 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement_UserInRatingListElementArgs_TypeInfo
		                        );
		  Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(param1 + 8);
		  iVar2 = *(int *)(param1 + 0x10);
		  *(undefined8 *)(param1_00 + 0x20) = *(undefined8 *)(iVar2 + 0x10);
		  uVar1 = *(undefined4 *)(iVar2 + 0xc);
		  *(undefined1 *)(param1_00 + 0x2c) = 1;
		  *(undefined4 *)(param1_00 + 0x28) = uVar1;
		  return param1_00;
		}
		*/


		/* --- GHIDRA: GetOwnerRating ---
		undefined4 Gameplay_Competition_Model_RatingModel__GetOwnerRating(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a63ac5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_RatingModel_RatingRecord__UserData___);
		    Mono_Security_ASN1__get_Item(&System_Func_RatingModel_RatingRecord__UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Competition_Model_RatingModel___c__GetUsers_b__9_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Model_RatingModel___c_TypeInfo);
		    DAT_ram_00a63ac5 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x14);
		  if (*(int *)(Gameplay_Competition_Model_RatingModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Competition_Model_RatingModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_Competition_Model_RatingModel___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[2];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_Competition_Model_RatingModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Competition_Model_RatingModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_Competition_Model_RatingModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_RatingModel_RatingRecord__UserData__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (param1_00,param2_00,
		               Method_Gameplay_Competition_Model_RatingModel___c__GetUsers_b__9_0__,0);
		    *(int *)(*(int *)(Gameplay_Competition_Model_RatingModel___c_TypeInfo + 0x5c) + 8) = param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar1,param1_00,
		                     Method_System_Linq_Enumerable_Select_RatingModel_RatingRecord__UserData___);
		  return uVar1;
		}
		*/

}
