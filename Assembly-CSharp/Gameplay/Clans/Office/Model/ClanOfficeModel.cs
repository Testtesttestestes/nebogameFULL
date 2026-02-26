using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay.Managers.Requirements;
using Gameplay.Clans.Office.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Clans;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Rating;
using UI.Elements.Filters.GenericFilter;
using UI.Elements.RatingElements.SubRatings;
using UI.Tabs;

namespace Gameplay.Clans.Office.Model
{
	// Token: 0x02000A46 RID: 2630
	[Token(Token = "0x2000A46")]
	public class ClanOfficeModel : AbstractModel
	{
		// Token: 0x06003E44 RID: 15940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E44")]
		[Address(RVA = "0x8D03", Offset = "0x8D03", VA = "0x8D03")]
		public ClanOfficeModel(UserData user)
		{
		/* --- GHIDRA: <CreateFilterDatas>g__CreateData|40_0 ---
		void Gameplay_Clans_Office_Model_ClanOfficeModel___CreateFilterDatas_g__CreateData_40_0
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  char cVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  uVar3 = *(undefined4 *)(param3 + 4);
		  *(int *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 8) = uVar3;
		  *(int *)(param1 + 0x10) = param2;
		  cVar1 = *(char *)(param3 + 0x2e);
		  *(int *)(param1 + 0x20) = param1;
		  iVar2 = func_ii_4538(param3);
		  if (iVar2 == 0) {
		    if (param2 == 0) {
		      uVar3 = Mono_Unity_CertHelper__AddCertificatesToNativeChain
		                        (0,s_Delegate_to_an_instance_method_c_ram_0005d205);
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  else if (cVar1 == '\x02') {
		    *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001b87 + 0xf6;
		  }
		  else {
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  *(char **)(param1 + 0x1c) = s_struct_Uniforms___color__array<v_ram_00001b87 + 0xf7;
		  return;
		}
		*/

		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x06003E45 RID: 15941 RVA: 0x0000C498 File Offset: 0x0000A698
		// (set) Token: 0x06003E46 RID: 15942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C7B")]
		public uint MinPage
		{
			[Token(Token = "0x6003E45")]
			[Address(RVA = "0x8D04", Offset = "0x8D04", VA = "0x8D04")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6003E46")]
			[Address(RVA = "0x8D05", Offset = "0x8D05", VA = "0x8D05")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06003E47 RID: 15943 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
		// (set) Token: 0x06003E48 RID: 15944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C7C")]
		public uint MaxPage
		{
			[Token(Token = "0x6003E47")]
			[Address(RVA = "0x8D06", Offset = "0x8D06", VA = "0x8D06")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6003E48")]
			[Address(RVA = "0x8D07", Offset = "0x8D07", VA = "0x8D07")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06003E49 RID: 15945 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
		[Token(Token = "0x17000C7D")]
		public bool PageDifferenceExceeded
		{
			[Token(Token = "0x6003E49")]
			[Address(RVA = "0x8D08", Offset = "0x8D08", VA = "0x8D08")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06003E4A RID: 15946 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C7E")]
		public FilterListElement.FilterData[] FilterDatas
		{
			[Token(Token = "0x6003E4A")]
			[Address(RVA = "0x8D09", Offset = "0x8D09", VA = "0x8D09")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x06003E4B RID: 15947 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		// (set) Token: 0x06003E4C RID: 15948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C7F")]
		public ulong RequestedClanId
		{
			[Token(Token = "0x6003E4B")]
			[Address(RVA = "0x8D0A", Offset = "0x8D0A", VA = "0x8D0A")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6003E4C")]
			[Address(RVA = "0x8D0B", Offset = "0x8D0B", VA = "0x8D0B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x06003E4D RID: 15949 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E4E RID: 15950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C80")]
		public ClanInRatingListElement.ClanInRatingListElementArgs RequestedClan
		{
			[Token(Token = "0x6003E4D")]
			[Address(RVA = "0x8D0C", Offset = "0x8D0C", VA = "0x8D0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E4E")]
			[Address(RVA = "0x8D0D", Offset = "0x8D0D", VA = "0x8D0D")]
			set
			{
			}
		}

		// Token: 0x06003E4F RID: 15951 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E4F")]
		[Address(RVA = "0x8D0E", Offset = "0x8D0E", VA = "0x8D0E")]
		public TabBarItemData[] GetTabBarItemData()
		{
		/* --- GHIDRA: GetTabBarItemData ---
		void Gameplay_Clans_Office_Model_ClanOfficeModel__GetTabBarItemData
		               (int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined8 uVar4;
		  
		  if (DAT_ram_00a57f98 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs___Clear__
		              );
		    DAT_ram_00a57f98 = '\x01';
		  }
		  iVar2 = *(int *)(param2 + 0x10);
		  if (iVar2 == 0) {
		    *(undefined4 *)(param1 + 0x38) = 0;
		    uVar4 = 0;
		  }
		  else {
		    if (DAT_ram_00a57f9a == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo
		                );
		      DAT_ram_00a57f9a = '\x01';
		    }
		    param1_00 = unnamed_function_1417
		                          (
		                          Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo
		                          );
		    if (DAT_ram_00a57f0e == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Gameplay_Clans_Office_View_ClanListElementArgs_ClanInRating__ClanInRatingListElement___ctor__
		                );
		      DAT_ram_00a57f0e = '\x01';
		    }
		    Gameplay_Clans_Office_View_ClanListElementArgs___Il2CppFullySharedGenericType____ctor
		              (param1_00,
		               Method_Gameplay_Clans_Office_View_ClanListElementArgs_ClanInRating__ClanInRatingListElement___ctor__
		              );
		    uVar1 = func_ii_7325(*(undefined4 *)(iVar2 + 0xc),*(undefined4 *)(param1 + 0xc),0);
		    *(int *)(param1_00 + 0x24) = iVar2;
		    *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		    iVar3 = param1;
		    if (iVar2 == 0) {
		      iVar3 = 0;
		    }
		    *(int *)(iVar3 + 0x38) = param1_00;
		    uVar4 = *(undefined8 *)(*(int *)(iVar2 + 0xc) + 0x10);
		  }
		  *(undefined8 *)(param1 + 0x48) = uVar4;
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x14),
		             Method_System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs___Clear__
		            );
		  *(undefined8 *)(param1 + 0x3c) = 0;
		  Gameplay_Clans_Office_Model_ClanOfficeModel__CreateClanVacancies(param1,param2,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003E50 RID: 15952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E50")]
		[Address(RVA = "0x8D0F", Offset = "0x8D0F", VA = "0x8D0F")]
		public void CreateClanVacancies(ProtoGetClanVacanciesListAns msg)
		{
		/* --- GHIDRA: CreateClanVacancies ---
		void Gameplay_Clans_Office_Model_ClanOfficeModel__CreateClanVacancies
		               (int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined4 param2_01;
		  
		  if (DAT_ram_00a57f99 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs___set_Item__
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
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Model_ClanOfficeModel___c__DisplayClass36_0__AddClanList_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Model_ClanOfficeModel___c__DisplayClass36_0_TypeInfo);
		    DAT_ram_00a57f99 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Clans_Office_Model_ClanOfficeModel___c__DisplayClass36_0_TypeInfo)
		  ;
		  *(int *)(param2_00 + 8) = param1;
		  param2_01 = *(undefined4 *)(param2 + 0x18);
		  *(undefined4 *)(param2_00 + 0xc) = param2_01;
		  param1_00 = *(undefined4 *)(param1 + 0x14);
		  param1_01 = *(undefined4 *)(param2 + 0xc);
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Func_ClanInRating__int__ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		                    );
		  System_Func_object__int__long___Invoke
		            (uVar1,param2_00,
		             Method_Gameplay_Clans_Office_Model_ClanOfficeModel___c__DisplayClass36_0__AddClanList_b__0__
		             ,0);
		  uVar1 = System_Linq_Enumerable__SelectMany_ValueTuple_object__object___object_
		                    (param1_01,uVar1,
		                     Method_System_Linq_Enumerable_Select_ClanInRating__ClanInRatingListElement_ClanInRatingListElementArgs___
		                    );
		  uVar1 = func_ii_6295(uVar1,
		                       Method_System_Linq_Enumerable_ToArray_ClanInRatingListElement_ClanInRatingListElementArgs___
		                      );
		  System_Collections_Generic_Dictionary_uint__object___get_Item
		            (param1_00,param2_01,uVar1,
		             Method_System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs___set_Item__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E51")]
		[Address(RVA = "0x8D10", Offset = "0x8D10", VA = "0x8D10")]
		public void AddClanList(ProtoGetClanVacanciesListAns msg)
		{
		/* --- GHIDRA: AddClanList ---
		int Gameplay_Clans_Office_Model_ClanOfficeModel__AddClanList
		              (int param1,int param2,int *param3,int *param4,undefined4 param5)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (*(int *)(param2 + 0x1c) == 0) {
		    *(int *)(param2 + 0x1c) = *param3 + *(int *)(param1 + 0x1c) * *param4 + 1;
		  }
		  if (DAT_ram_00a57f9a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo
		              );
		    DAT_ram_00a57f9a = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo
		                        );
		  if (DAT_ram_00a57f0e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_ClanListElementArgs_ClanInRating__ClanInRatingListElement___ctor__
		              );
		    DAT_ram_00a57f0e = '\x01';
		  }
		  Gameplay_Clans_Office_View_ClanListElementArgs___Il2CppFullySharedGenericType____ctor
		            (param1_00,
		             Method_Gameplay_Clans_Office_View_ClanListElementArgs_ClanInRating__ClanInRatingListElement___ctor__
		            );
		  uVar1 = func_ii_7325(*(undefined4 *)(param2 + 0xc),*(undefined4 *)(param1 + 0xc),0);
		  *(int *)(param1_00 + 0x24) = param2;
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  if (*(longlong *)(param1 + 0x48) == *(longlong *)(*(int *)(param2 + 0xc) + 0x10)) {
		    *(int *)(param1 + 0x38) = param1_00;
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E52")]
		[Address(RVA = "0x8D11", Offset = "0x8D11", VA = "0x8D11")]
		private ClanInRatingListElement.ClanInRatingListElementArgs ConstructArgs(ClanInRating clan, in int index, in int pageNumber)
		{
		/* --- GHIDRA: ConstructArgs ---
		int Gameplay_Clans_Office_Model_ClanOfficeModel__ConstructArgs
		              (int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57f9a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo
		              );
		    DAT_ram_00a57f9a = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo
		                        );
		  if (DAT_ram_00a57f0e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_ClanListElementArgs_ClanInRating__ClanInRatingListElement___ctor__
		              );
		    DAT_ram_00a57f0e = '\x01';
		  }
		  Gameplay_Clans_Office_View_ClanListElementArgs___Il2CppFullySharedGenericType____ctor
		            (param1_00,
		             Method_Gameplay_Clans_Office_View_ClanListElementArgs_ClanInRating__ClanInRatingListElement___ctor__
		            );
		  uVar1 = func_ii_7325(*(undefined4 *)(param2 + 0xc),*(undefined4 *)(param1 + 0xc),0);
		  *(int *)(param1_00 + 0x24) = param2;
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  return param1_00;
		}
		*/

		/* --- GHIDRA: ConstructArgs ---
		int Gameplay_Clans_Office_Model_ClanOfficeModel__ConstructArgs
		              (int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57f9a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo
		              );
		    DAT_ram_00a57f9a = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo
		                        );
		  if (DAT_ram_00a57f0e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_ClanListElementArgs_ClanInRating__ClanInRatingListElement___ctor__
		              );
		    DAT_ram_00a57f0e = '\x01';
		  }
		  Gameplay_Clans_Office_View_ClanListElementArgs___Il2CppFullySharedGenericType____ctor
		            (param1_00,
		             Method_Gameplay_Clans_Office_View_ClanListElementArgs_ClanInRating__ClanInRatingListElement___ctor__
		            );
		  uVar1 = func_ii_7325(*(undefined4 *)(param2 + 0xc),*(undefined4 *)(param1 + 0xc),0);
		  *(int *)(param1_00 + 0x24) = param2;
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E53")]
		[Address(RVA = "0x8D12", Offset = "0x8D12", VA = "0x8D12")]
		private ClanInRatingListElement.ClanInRatingListElementArgs ConstructArgs(ClanInRating clan)
		{
			return null;
		}

		// Token: 0x06003E54 RID: 15956 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E54")]
		[Address(RVA = "0x8D13", Offset = "0x8D13", VA = "0x8D13")]
		private List<SubRatingListElementArgs> CreateSubRatingListElementArgs()
		{
		/* --- GHIDRA: CreateSubRatingListElementArgs ---
		int * Gameplay_Clans_Office_Model_ClanOfficeModel__CreateSubRatingListElementArgs
		                (int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57f9c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_Filters_GenericFilter_FilterListElement_FilterData___TypeInfo);
		    DAT_ram_00a57f9c = '\x01';
		  }
		  piVar1 = (int *)Mono_Security_ASN1Convert__ToOid
		                            (UI_Elements_Filters_GenericFilter_FilterListElement_FilterData___TypeInfo
		                             ,3);
		  if (DAT_ram_00a57f9d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_Filters_GenericFilter_FilterListElement_FilterData_TypeInfo);
		    DAT_ram_00a57f9d = '\x01';
		  }
		  uVar2 = func_ii_7625(*(undefined4 *)(param1 + 0xc),1,0);
		  iVar3 = unnamed_function_1417
		                    (UI_Elements_Filters_GenericFilter_FilterListElement_FilterData_TypeInfo);
		  *(undefined4 *)(iVar3 + 0xc) = uVar2;
		  uVar2 = Core_Extensions_Dict_DictExt__GetRatingTypeDic(uVar2,0);
		  *(undefined4 *)(iVar3 + 8) = uVar2;
		  iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar1 + 0x20));
		  if (iVar4 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar1[4] = iVar3;
		  if (DAT_ram_00a57f9d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_Filters_GenericFilter_FilterListElement_FilterData_TypeInfo);
		    DAT_ram_00a57f9d = '\x01';
		  }
		  uVar2 = func_ii_7625(*(undefined4 *)(param1 + 0xc),2,0);
		  iVar3 = unnamed_function_1417
		                    (UI_Elements_Filters_GenericFilter_FilterListElement_FilterData_TypeInfo);
		  *(undefined4 *)(iVar3 + 0xc) = uVar2;
		  uVar2 = Core_Extensions_Dict_DictExt__GetRatingTypeDic(uVar2,0);
		  *(undefined4 *)(iVar3 + 8) = uVar2;
		  iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar1 + 0x20));
		  if (iVar4 != 0) {
		    piVar1[5] = iVar3;
		    if (DAT_ram_00a57f9d == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&UI_Elements_Filters_GenericFilter_FilterListElement_FilterData_TypeInfo);
		      DAT_ram_00a57f9d = '\x01';
		    }
		    uVar2 = func_ii_7625(*(undefined4 *)(param1 + 0xc),3,0);
		    iVar3 = unnamed_function_1417
		                      (UI_Elements_Filters_GenericFilter_FilterListElement_FilterData_TypeInfo);
		    *(undefined4 *)(iVar3 + 0xc) = uVar2;
		    uVar2 = Core_Extensions_Dict_DictExt__GetRatingTypeDic(uVar2,0);
		    *(undefined4 *)(iVar3 + 8) = uVar2;
		    iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar1 + 0x20));
		    if (iVar4 != 0) {
		      piVar1[6] = iVar3;
		      return piVar1;
		    }
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar2 = func_ii_1083();
		  func_ii_1050(uVar2,0);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06003E55 RID: 15957 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E55")]
		[Address(RVA = "0x8D14", Offset = "0x8D14", VA = "0x8D14")]
		private FilterListElement.FilterData[] CreateFilterDatas()
		{
		/* --- GHIDRA: CreateFilterDatas ---
		int Gameplay_Clans_Office_Model_ClanOfficeModel__CreateFilterDatas
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57f9d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_Filters_GenericFilter_FilterListElement_FilterData_TypeInfo);
		    DAT_ram_00a57f9d = '\x01';
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

			return null;
		}

		// Token: 0x06003E56 RID: 15958 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E56")]
		[Address(RVA = "0x8D15", Offset = "0x8D15", VA = "0x8D15")]
		[CompilerGenerated]
		private FilterListElement.FilterData <CreateFilterDatas>g__CreateData|40_0(RatingPeriods period)
		{
			return null;
		}

		// Token: 0x040022FB RID: 8955
		[Token(Token = "0x40022FB")]
		public const int MIN_PAGE_DIFFERENCE = 2;

		// Token: 0x040022FC RID: 8956
		[Token(Token = "0x40022FC")]
		[FieldOffset(Offset = "0xC")]
		public readonly Dictionaries Dict;

		// Token: 0x040022FD RID: 8957
		[Token(Token = "0x40022FD")]
		[FieldOffset(Offset = "0x10")]
		public readonly string HonorAssetId;

		// Token: 0x040022FE RID: 8958
		[Token(Token = "0x40022FE")]
		[FieldOffset(Offset = "0x14")]
		public readonly Dictionary<uint, IList<ClanInRatingListElement.ClanInRatingListElementArgs>> ClanVacanciesByPage;

		// Token: 0x040022FF RID: 8959
		[Token(Token = "0x40022FF")]
		[FieldOffset(Offset = "0x18")]
		public readonly SubRatingsListArgs SubRatingsArgs;

		// Token: 0x04002300 RID: 8960
		[Token(Token = "0x4002300")]
		[FieldOffset(Offset = "0x1C")]
		public readonly int PageSize;

		// Token: 0x04002301 RID: 8961
		[Token(Token = "0x4002301")]
		[FieldOffset(Offset = "0x20")]
		public readonly List<RestrictionInfo> Restrictions;

		// Token: 0x04002302 RID: 8962
		[Token(Token = "0x4002302")]
		[FieldOffset(Offset = "0x24")]
		public readonly RequirementsInfoProvider ClanRestrictions;

		// Token: 0x04002303 RID: 8963
		[Token(Token = "0x4002303")]
		[FieldOffset(Offset = "0x28")]
		public readonly RequirementsInfoProvider FractionRestrictions;

		// Token: 0x04002304 RID: 8964
		[Token(Token = "0x4002304")]
		[FieldOffset(Offset = "0x2C")]
		public readonly ResourceSet ClanCreationCost;

		// Token: 0x04002305 RID: 8965
		[Token(Token = "0x4002305")]
		[FieldOffset(Offset = "0x30")]
		public readonly ResourceSet FractionClanCreationCost;

		// Token: 0x04002306 RID: 8966
		[Token(Token = "0x4002306")]
		[FieldOffset(Offset = "0x34")]
		private FilterListElement.FilterData[] _filterDatas;

		// Token: 0x04002307 RID: 8967
		[Token(Token = "0x4002307")]
		[FieldOffset(Offset = "0x38")]
		private ClanInRatingListElement.ClanInRatingListElementArgs _requestedClan;

		// Token: 0x02000A47 RID: 2631
		// (Invoke) Token: 0x06003E58 RID: 15960
		[Token(Token = "0x2000A47")]
		public delegate void ClanPageRemoved(int count, bool fromEnd);
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_MaxPage ---
		uint Gameplay_Clans_Office_Model_ClanOfficeModel__set_MaxPage(int param1,undefined4 param2)
		
		{
		  return (uint)(2 < (uint)(*(int *)(param1 + 0x40) - *(int *)(param1 + 0x3c)));
		}
		*/


		/* --- GHIDRA: get_PageDifferenceExceeded ---
		int Gameplay_Clans_Office_Model_ClanOfficeModel__get_PageDifferenceExceeded
		              (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x34);
		  if (iVar1 == 0) {
		    iVar1 = Gameplay_Clans_Office_Model_ClanOfficeModel__CreateSubRatingListElementArgs
		                      (param1,param1);
		    *(int *)(param1 + 0x34) = iVar1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_RequestedClan ---
		void Gameplay_Clans_Office_Model_ClanOfficeModel__get_RequestedClan
		               (int param1,int param2,undefined4 param3)
		
		{
		  *(int *)(param1 + 0x38) = param2;
		  if (param2 != 0) {
		    *(undefined8 *)(param1 + 0x48) = *(undefined8 *)(*(int *)(*(int *)(param2 + 0x24) + 0xc) + 0x10)
		    ;
		    return;
		  }
		  *(undefined8 *)(param1 + 0x48) = 0;
		  return;
		}
		*/


		/* --- GHIDRA: set_RequestedClan ---
		int * Gameplay_Clans_Office_Model_ClanOfficeModel__set_RequestedClan
		                (undefined4 param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57f97 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4302);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4296);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4330);
		    DAT_ram_00a57f97 = '\x01';
		  }
		  piVar1 = (int *)Mono_Security_ASN1Convert__ToOid(UI_Tabs_TabBarItemData___TypeInfo,3);
		  iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4296,1,0,1,0,0,0,0);
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
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4302,1,0,1,0,0,0,0);
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
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4330,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0x14) = 2;
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
