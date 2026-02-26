using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay.Managers;
using Gameplay.WorldAxis.Office.View.Ratings;
using Il2CppDummyDll;
using MVC;
using Protocol.Colossus;
using Protocol.Dic;

namespace Gameplay.WorldAxis.Office.Model
{
	// Token: 0x020002D1 RID: 721
	[Token(Token = "0x20002D1")]
	public class RatingsModel : AbstractModel
	{
		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060010FE RID: 4350 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000281")]
		public Dictionaries Dict
		{
			[Token(Token = "0x60010FE")]
			[Address(RVA = "0x62FB", Offset = "0x62FB", VA = "0x62FB")]
			get
			{
				return null;
			}
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010FF")]
		[Address(RVA = "0x62FC", Offset = "0x62FC", VA = "0x62FC")]
		public RatingsModel(UserData user, WorldAxisOfficeModel officeModel)
		{
		/* --- GHIDRA: <PopulateClanRatings>g__CreateClanRatingsArgs|26_1 ---
		void Gameplay_WorldAxis_Office_Model_RatingsModel___PopulateClanRatings_g__CreateClanRatingsArgs_26_1
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58b1c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo);
		    DAT_ram_00a58b1c = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001101 RID: 4353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000282")]
		public List<ClanSeasonRatingsListElement.ClanSeasonRatingsListElementArgs> ClanRatingsArgs
		{
			[Token(Token = "0x6001100")]
			[Address(RVA = "0x62FD", Offset = "0x62FD", VA = "0x62FD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001101")]
			[Address(RVA = "0x62FE", Offset = "0x62FE", VA = "0x62FE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001103 RID: 4355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000283")]
		public List<UserSeasonRatingsListElement.UserSeasonRatingsListElementArgs> UserRatingsArgs
		{
			[Token(Token = "0x6001102")]
			[Address(RVA = "0x62FF", Offset = "0x62FF", VA = "0x62FF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001103")]
			[Address(RVA = "0x6300", Offset = "0x6300", VA = "0x6300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001105 RID: 4357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000284")]
		public ClanSeasonRatingsListElement.ClanSeasonRatingsListElementArgs MyClanArgs
		{
			[Token(Token = "0x6001104")]
			[Address(RVA = "0x6301", Offset = "0x6301", VA = "0x6301")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001105")]
			[Address(RVA = "0x6302", Offset = "0x6302", VA = "0x6302")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06001106 RID: 4358 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001107 RID: 4359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000285")]
		public UserSeasonRatingsListElement.UserSeasonRatingsListElementArgs MyUserArgs
		{
			[Token(Token = "0x6001106")]
			[Address(RVA = "0x6303", Offset = "0x6303", VA = "0x6303")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001107")]
			[Address(RVA = "0x6304", Offset = "0x6304", VA = "0x6304")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001108")]
		[Address(RVA = "0x6305", Offset = "0x6305", VA = "0x6305")]
		public void PopulateClanRatings(IList<ColossusRating> ratings)
		{
		/* --- GHIDRA: PopulateClanRatings ---
		void Gameplay_WorldAxis_Office_Model_RatingsModel__PopulateClanRatings
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 *puVar6;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58b17 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_FirstOrDefault_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_HeroesRating__UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToList_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs__bool__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_HeroesRating__int__UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Model_RatingsModel___c__PopulateUserRatings_b__27_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Model_RatingsModel___c__DisplayClass27_0__PopulateUserRatings_g__CreateUserRatingsArgs_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Office_Model_RatingsModel___c__DisplayClass27_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo);
		    DAT_ram_00a58b17 = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (Gameplay_WorldAxis_Office_Model_RatingsModel___c__DisplayClass27_0_TypeInfo);
		  *(int *)(iVar2 + 8) = param1;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x158);
		        goto code_r0x80f77056;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80f77056:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  *(undefined4 *)(iVar2 + 0xc) = *(undefined4 *)(iVar5 + 0x14);
		  uVar4 = unnamed_function_1417
		                    (
		                    System_Func_HeroesRating__int__UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs__TypeInfo
		                    );
		  System_Func_object__int__long___Invoke
		            (uVar4,iVar2,
		             Method_Gameplay_WorldAxis_Office_Model_RatingsModel___c__DisplayClass27_0__PopulateUserRatings_g__CreateUserRatingsArgs_1__
		             ,0);
		  uVar4 = System_Linq_Enumerable__SelectMany_ValueTuple_object__object___object_
		                    (param2,uVar4,
		                     Method_System_Linq_Enumerable_Select_HeroesRating__UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs___
		                    );
		  uVar4 = System_Linq_Enumerable__Select_object__object_
		                    (uVar4,
		                     Method_System_Linq_Enumerable_ToList_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs___
		                    );
		  *(undefined4 *)(param1 + 0x2c) = uVar4;
		  if (*(int *)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x5c);
		  iVar2 = puVar6[6];
		  if (iVar2 == 0) {
		    if (*(int *)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar6;
		    iVar2 = unnamed_function_1417
		                      (
		                      System_Func_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs__bool__TypeInfo
		                      );
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar2,param2_00,
		               Method_Gameplay_WorldAxis_Office_Model_RatingsModel___c__PopulateUserRatings_b__27_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x5c) + 0x18) =
		         iVar2;
		  }
		  iVar2 = System_Func_object__bool____ctor
		                    (uVar4,iVar2,
		                     Method_System_Linq_Enumerable_FirstOrDefault_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs___
		                    );
		  *(int *)(param1 + 0x34) = iVar2;
		  if (iVar2 != 0) {
		    Gameplay_WorldAxis_Office_Model_RatingsModel__SetupMyClanArgs(param1,iVar2);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001109")]
		[Address(RVA = "0x6306", Offset = "0x6306", VA = "0x6306")]
		public void PopulateUserRatings(IList<HeroesRating> ratings)
		{
		/* --- GHIDRA: PopulateUserRatings ---
		void Gameplay_WorldAxis_Office_Model_RatingsModel__PopulateUserRatings(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58b18 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__RemoveAt__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_Office_View_Ratings_ClanSeasonRatingsListElement_MyClanSeasonRatingsListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_28651);
		    DAT_ram_00a58b18 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x30);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_WorldAxis_Office_View_Ratings_ClanSeasonRatingsListElement_MyClanSeasonRatingsListElementArgs_TypeInfo
		                        );
		  UnityEngine_InputSystem_LowLevel_SelectObservable___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___Subscribe
		            (param1_00,0);
		  *(undefined4 *)(param1_00 + 0xc) = *(undefined4 *)(iVar2 + 0xc);
		  *(undefined4 *)(param1_00 + 0x10) = *(undefined4 *)(iVar2 + 0x10);
		  *(undefined4 *)(param1_00 + 0x14) = *(undefined4 *)(iVar2 + 0x14);
		  *(undefined4 *)(param1_00 + 0x18) = *(undefined4 *)(iVar2 + 0x18);
		  *(undefined1 *)(param1_00 + 0x1c) = *(undefined1 *)(iVar2 + 0x1c);
		  *(undefined4 *)(param1_00 + 0x20) = *(undefined4 *)(iVar2 + 0x20);
		  if (*(int *)(param1 + 0x24) < *(int *)(iVar2 + 0x18)) {
		    UnityEngine_TextCore_Glyph__set_atlasIndex
		              (*(undefined4 *)(param1 + 0x28),*(int *)(*(int *)(param1 + 0x30) + 0x18) + -1,
		               Method_System_Collections_Generic_List_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__RemoveAt__
		              );
		    local_4 = *(undefined4 *)(param1 + 0x24);
		    uVar1 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    uVar1 = func_ii_4419(StringLiteral_28651,uVar1,0);
		  }
		  else {
		    uVar1 = func_ii_4443(iVar2 + 0x18,0);
		  }
		  *(undefined4 *)(param1_00 + 0x24) = uVar1;
		  *(int *)(param1 + 0x30) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x0600110A RID: 4362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600110A")]
		[Address(RVA = "0x6307", Offset = "0x6307", VA = "0x6307")]
		private void SetupMyClanArgs()
		{
		/* --- GHIDRA: SetupMyClanArgs ---
		void Gameplay_WorldAxis_Office_Model_RatingsModel__SetupMyClanArgs(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58b19 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__RemoveAt__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_Office_View_Ratings_UserSeasonRatingsListElement_MyUserSeasonRatingsListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_28651);
		    DAT_ram_00a58b19 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x34);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_WorldAxis_Office_View_Ratings_UserSeasonRatingsListElement_MyUserSeasonRatingsListElementArgs_TypeInfo
		                        );
		  UnityEngine_InputSystem_LowLevel_SelectObservable___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___Subscribe
		            (param1_00,0);
		  *(undefined4 *)(param1_00 + 0xc) = *(undefined4 *)(iVar2 + 0xc);
		  *(undefined4 *)(param1_00 + 0x10) = *(undefined4 *)(iVar2 + 0x10);
		  *(undefined4 *)(param1_00 + 0x14) = *(undefined4 *)(iVar2 + 0x14);
		  *(undefined4 *)(param1_00 + 0x18) = *(undefined4 *)(iVar2 + 0x18);
		  *(undefined1 *)(param1_00 + 0x1c) = *(undefined1 *)(iVar2 + 0x1c);
		  if (*(int *)(param1 + 0x24) < *(int *)(iVar2 + 0x18)) {
		    UnityEngine_TextCore_Glyph__set_atlasIndex
		              (*(undefined4 *)(param1 + 0x28),*(int *)(*(int *)(param1 + 0x30) + 0x18) + -1,
		               Method_System_Collections_Generic_List_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__RemoveAt__
		              );
		    local_4 = *(undefined4 *)(param1 + 0x24);
		    uVar1 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    uVar1 = func_ii_4419(StringLiteral_28651,uVar1,0);
		  }
		  else {
		    uVar1 = func_ii_4443(iVar2 + 0x18,0);
		  }
		  *(undefined4 *)(param1_00 + 0x20) = uVar1;
		  *(int *)(param1 + 0x34) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x0600110B RID: 4363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600110B")]
		[Address(RVA = "0x6308", Offset = "0x6308", VA = "0x6308")]
		private void SetupMyUserArgs()
		{
		/* --- GHIDRA: SetupMyUserArgs ---
		int Gameplay_WorldAxis_Office_Model_RatingsModel__SetupMyUserArgs
		              (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58b1a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_Office_View_Ratings_SortCategoryListElement_SortCategoryListElementArgs_TypeInfo
		              );
		    DAT_ram_00a58b1a = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_WorldAxis_Office_View_Ratings_SortCategoryListElement_SortCategoryListElementArgs_TypeInfo
		                        );
		  Gameplay_WorldAxis_Office_View_Ratings_SortCategoryListElement___ctor(param1_00,0);
		  uVar1 = Core_Extensions_Dict_ColossusRatingDicExt__GetDescription(param2,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  uVar1 = Core_Extensions_Dict_ColossusFragmentsOptionsDicExt__GetEventPromoDescription(param2,0);
		  *(undefined4 *)(param1_00 + 0x20) = uVar1;
		  *(int *)(param1_00 + 8) = *(int *)(param2 + 0xc) + -1;
		  return param1_00;
		}
		*/

		}

		// Token: 0x0600110C RID: 4364 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600110C")]
		[Address(RVA = "0x6309", Offset = "0x6309", VA = "0x6309")]
		private SortCategoryListElement.SortCategoryListElementArgs CreateSortCategory(ColossusRatingDic dic)
		{
		/* --- GHIDRA: CreateSortCategory ---
		int Gameplay_WorldAxis_Office_Model_RatingsModel__CreateSortCategory
		              (int param1,int param2,int param3,undefined4 param4)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  longlong lVar2;
		  undefined4 param1_01;
		  longlong lVar3;
		  
		  if (DAT_ram_00a58b1b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_Office_View_Ratings_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs_TypeInfo
		              );
		    DAT_ram_00a58b1b = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_WorldAxis_Office_View_Ratings_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs_TypeInfo
		                        );
		  UnityEngine_InputSystem_LowLevel_SelectObservable___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___Subscribe
		            (param1_00,0);
		  *(undefined4 *)(param1_00 + 0xc) = *(undefined4 *)(param1 + 0x1c);
		  *(undefined4 *)(param1_00 + 0x10) = *(undefined4 *)(param2 + 0x10);
		  param1_01 = *(undefined4 *)(param2 + 0xc);
		  uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1 + 0xc),0);
		  uVar1 = func_ii_7325(param1_01,uVar1,0);
		  *(int *)(param1_00 + 0x18) = param3 + 1;
		  *(undefined4 *)(param1_00 + 0x14) = uVar1;
		  lVar3 = *(longlong *)(*(int *)(param2 + 0xc) + 0x10);
		  lVar2 = Core_Data_UserData___ctor(*(undefined4 *)(param1 + 8),0);
		  *(bool *)(param1_00 + 0x1c) = lVar3 == lVar2;
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600110D")]
		[Address(RVA = "0x630A", Offset = "0x630A", VA = "0x630A")]
		[CompilerGenerated]
		private ClanSeasonRatingsListElement.ClanSeasonRatingsListElementArgs <PopulateClanRatings>g__CreateClanRatingsArgs|26_1(ColossusRating ratings, int index)
		{
			return null;
		}

		// Token: 0x040008CD RID: 2253
		[Token(Token = "0x40008CD")]
		[FieldOffset(Offset = "0xC")]
		private DictManager _dictManager;

		// Token: 0x040008CE RID: 2254
		[Token(Token = "0x40008CE")]
		[FieldOffset(Offset = "0x10")]
		public readonly WorldAxisOfficeModel OfficeModel;

		// Token: 0x040008CF RID: 2255
		[Token(Token = "0x40008CF")]
		[FieldOffset(Offset = "0x14")]
		public readonly SortCategoryListElement.SortCategoryListElementArgs[] ClanSortCategories;

		// Token: 0x040008D0 RID: 2256
		[Token(Token = "0x40008D0")]
		[FieldOffset(Offset = "0x18")]
		public readonly SortCategoryListElement.SortCategoryListElementArgs[] UserSortCategories;

		// Token: 0x040008D1 RID: 2257
		[Token(Token = "0x40008D1")]
		[FieldOffset(Offset = "0x1C")]
		private readonly int[] _clanRatingsIndexes;

		// Token: 0x040008D2 RID: 2258
		[Token(Token = "0x40008D2")]
		[FieldOffset(Offset = "0x20")]
		private readonly int[] _userRatingsIndexes;

		// Token: 0x040008D3 RID: 2259
		[Token(Token = "0x40008D3")]
		[FieldOffset(Offset = "0x24")]
		private readonly int _maxRatingEntries;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Dict ---
		void Gameplay_WorldAxis_Office_Model_RatingsModel__get_Dict
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 *puVar6;
		  
		  if (DAT_ram_00a58b15 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ColossusRatingDic__SortCategoryListElement_SortCategoryListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_SortCategoryListElement_SortCategoryListElementArgs__int___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_int___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_SortCategoryListElement_SortCategoryListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_ColossusRatingDic___);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_ColossusRatingDic__SortCategoryListElement_SortCategoryListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_SortCategoryListElement_SortCategoryListElementArgs__int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_ColossusRatingDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_Office_Model_RatingsModel_CreateSortCategory__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_Office_Model_RatingsModel___c___ctor_b__9_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_Office_Model_RatingsModel___c___ctor_b__9_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_Office_Model_RatingsModel___c___ctor_b__9_2__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_Office_Model_RatingsModel___c___ctor_b__9_3__);
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26305);
		    DAT_ram_00a58b15 = '\x01';
		  }
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined4 *)(param1 + 0x10) = param3;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x80f769bb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f769bb:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  *(undefined4 *)(param1 + 0xc) = uVar3;
		  iVar5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = *(undefined4 *)(iVar5 + 0x214);
		  if (*(int *)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x5c);
		  iVar5 = puVar6[1];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar6;
		    iVar5 = unnamed_function_1417(System_Func_ColossusRatingDic__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar5,uVar4,Method_Gameplay_WorldAxis_Office_Model_RatingsModel___c___ctor_b__9_0__,0
		              );
		    *(int *)(*(int *)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x5c) + 4) = iVar5
		    ;
		  }
		  uVar3 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar3,iVar5,Method_System_Linq_Enumerable_Where_ColossusRatingDic___);
		  uVar4 = unnamed_function_1417
		                    (
		                    System_Func_ColossusRatingDic__SortCategoryListElement_SortCategoryListElementArgs__TypeInfo
		                    );
		  System_Linq_Enumerable__Where_object_
		            (uVar4,param1,Method_Gameplay_WorldAxis_Office_Model_RatingsModel_CreateSortCategory__,0
		            );
		  uVar3 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar3,uVar4,
		                     Method_System_Linq_Enumerable_Select_ColossusRatingDic__SortCategoryListElement_SortCategoryListElementArgs___
		                    );
		  uVar3 = func_ii_6295(uVar3,
		                       Method_System_Linq_Enumerable_ToArray_SortCategoryListElement_SortCategoryListElementArgs___
		                      );
		  *(undefined4 *)(param1 + 0x14) = uVar3;
		  iVar5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1 + 0xc),0);
		  uVar3 = *(undefined4 *)(iVar5 + 0x218);
		  if (*(int *)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x5c);
		  iVar5 = puVar6[2];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar6;
		    iVar5 = unnamed_function_1417(System_Func_ColossusRatingDic__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar5,uVar4,Method_Gameplay_WorldAxis_Office_Model_RatingsModel___c___ctor_b__9_1__,0
		              );
		    *(int *)(*(int *)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x5c) + 8) = iVar5
		    ;
		  }
		  uVar3 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar3,iVar5,Method_System_Linq_Enumerable_Where_ColossusRatingDic___);
		  uVar4 = unnamed_function_1417
		                    (
		                    System_Func_ColossusRatingDic__SortCategoryListElement_SortCategoryListElementArgs__TypeInfo
		                    );
		  System_Linq_Enumerable__Where_object_
		            (uVar4,param1,Method_Gameplay_WorldAxis_Office_Model_RatingsModel_CreateSortCategory__,0
		            );
		  uVar3 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar3,uVar4,
		                     Method_System_Linq_Enumerable_Select_ColossusRatingDic__SortCategoryListElement_SortCategoryListElementArgs___
		                    );
		  uVar3 = func_ii_6295(uVar3,
		                       Method_System_Linq_Enumerable_ToArray_SortCategoryListElement_SortCategoryListElementArgs___
		                      );
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  uVar3 = *(undefined4 *)(param1 + 0x14);
		  if (*(int *)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x5c);
		  iVar5 = puVar6[3];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar6;
		    iVar5 = unnamed_function_1417
		                      (
		                      System_Func_SortCategoryListElement_SortCategoryListElementArgs__int__TypeInfo
		                      );
		    func_ii_7937(iVar5,uVar4,Method_Gameplay_WorldAxis_Office_Model_RatingsModel___c___ctor_b__9_2__
		                 ,0);
		    *(int *)(*(int *)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x5c) + 0xc) =
		         iVar5;
		  }
		  uVar3 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar3,iVar5,
		                     Method_System_Linq_Enumerable_Select_SortCategoryListElement_SortCategoryListElementArgs__int___
		                    );
		  uVar3 = System_Linq_Enumerable__ToArray_double_
		                    (uVar3,Method_System_Linq_Enumerable_ToArray_int___);
		  *(undefined4 *)(param1 + 0x1c) = uVar3;
		  uVar3 = *(undefined4 *)(param1 + 0x18);
		  if (*(int *)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x5c);
		  iVar5 = puVar6[4];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar6;
		    iVar5 = unnamed_function_1417
		                      (
		                      System_Func_SortCategoryListElement_SortCategoryListElementArgs__int__TypeInfo
		                      );
		    func_ii_7937(iVar5,uVar4,Method_Gameplay_WorldAxis_Office_Model_RatingsModel___c___ctor_b__9_3__
		                 ,0);
		    *(int *)(*(int *)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x5c) + 0x10) =
		         iVar5;
		  }
		  uVar3 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar3,iVar5,
		                     Method_System_Linq_Enumerable_Select_SortCategoryListElement_SortCategoryListElementArgs__int___
		                    );
		  uVar3 = System_Linq_Enumerable__ToArray_double_
		                    (uVar3,Method_System_Linq_Enumerable_ToArray_int___);
		  *(undefined4 *)(param1 + 0x20) = uVar3;
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1 + 0xc),0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar3,StringLiteral_26305,0);
		  *(undefined4 *)(param1 + 0x24) = uVar3;
		  return;
		}
		*/


		/* --- GHIDRA: set_MyUserArgs ---
		void Gameplay_WorldAxis_Office_Model_RatingsModel__set_MyUserArgs
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58b16 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_FirstOrDefault_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ColossusRating__ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToList_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__bool__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_ColossusRating__int__ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Model_RatingsModel__PopulateClanRatings_g__CreateClanRatingsArgs_26_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Model_RatingsModel___c__PopulateClanRatings_b__26_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo);
		    DAT_ram_00a58b16 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Func_ColossusRating__int__ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__TypeInfo
		                    );
		  System_Func_object__int__long___Invoke
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_Office_Model_RatingsModel__PopulateClanRatings_g__CreateClanRatingsArgs_26_1__
		             ,0);
		  uVar1 = System_Linq_Enumerable__SelectMany_ValueTuple_object__object___object_
		                    (param2,uVar1,
		                     Method_System_Linq_Enumerable_Select_ColossusRating__ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs___
		                    );
		  uVar1 = System_Linq_Enumerable__Select_object__object_
		                    (uVar1,
		                     Method_System_Linq_Enumerable_ToList_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs___
		                    );
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  if (*(int *)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[5];
		  if (iVar3 == 0) {
		    if (*(int *)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    iVar3 = unnamed_function_1417
		                      (
		                      System_Func_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__bool__TypeInfo
		                      );
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar3,param2_00,
		               Method_Gameplay_WorldAxis_Office_Model_RatingsModel___c__PopulateClanRatings_b__26_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_WorldAxis_Office_Model_RatingsModel___c_TypeInfo + 0x5c) + 0x14) =
		         iVar3;
		  }
		  iVar3 = System_Func_object__bool____ctor
		                    (uVar1,iVar3,
		                     Method_System_Linq_Enumerable_FirstOrDefault_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs___
		                    );
		  *(int *)(param1 + 0x30) = iVar3;
		  if (iVar3 != 0) {
		    Gameplay_WorldAxis_Office_Model_RatingsModel__PopulateUserRatings(param1,param1);
		  }
		  return;
		}
		*/

}
