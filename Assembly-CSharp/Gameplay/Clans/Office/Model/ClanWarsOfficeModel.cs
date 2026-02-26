using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Gameplay.Clans.ClanWars.Model;
using Gameplay.Clans.Office.View.ClanWarsTab.ClanPoliticsTab;
using Gameplay.World.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.ClanWar;
using Protocol.Common;
using Protocol.Dic;
using UI.Elements.Filters.GenericFilter;
using UI.Tabs;

namespace Gameplay.Clans.Office.Model
{
	// Token: 0x02000A4C RID: 2636
	[Token(Token = "0x2000A4C")]
	public class ClanWarsOfficeModel : AbstractModel
	{
		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x06003E6C RID: 15980 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C83")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6003E6C")]
			[Address(RVA = "0x8D2B", Offset = "0x8D2B", VA = "0x8D2B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06003E6D RID: 15981 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E6E RID: 15982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C84")]
		public ClanPolicyListElement.ClanPolicyListElementArgs MyClanArgs
		{
			[Token(Token = "0x6003E6D")]
			[Address(RVA = "0x8D2C", Offset = "0x8D2C", VA = "0x8D2C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E6E")]
			[Address(RVA = "0x8D2D", Offset = "0x8D2D", VA = "0x8D2D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06003E6F RID: 15983 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E70 RID: 15984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C85")]
		public ClanWarsModel ClanWarsModel
		{
			[Token(Token = "0x6003E6F")]
			[Address(RVA = "0x8D2E", Offset = "0x8D2E", VA = "0x8D2E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E70")]
			[Address(RVA = "0x8D2F", Offset = "0x8D2F", VA = "0x8D2F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06003E71 RID: 15985 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E72 RID: 15986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C86")]
		public ClanData ClanData
		{
			[Token(Token = "0x6003E71")]
			[Address(RVA = "0x8D30", Offset = "0x8D30", VA = "0x8D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E72")]
			[Address(RVA = "0x8D31", Offset = "0x8D31", VA = "0x8D31")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003E73 RID: 15987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E73")]
		[Address(RVA = "0x8D32", Offset = "0x8D32", VA = "0x8D32")]
		public ClanWarsOfficeModel(UserData user, ClanWarsModel clanWarsModel)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Model_ClanWarsOfficeModel___ctor(int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57fa8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyListElement_ClanPolicyListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Model_ClanWarsOfficeModel_Policy_TypeInfo);
		    DAT_ram_00a57fa8 = '\x01';
		  }
		  *(int *)(param1 + 0x30) = param2;
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyListElement_ClanPolicyListElementArgs_TypeInfo
		                        );
		  if (DAT_ram_00a57f5f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_ClanListElementArgs_ClanWarsOfficeModel_Policy__ClanPolicyListElement___ctor__
		              );
		    DAT_ram_00a57f5f = '\x01';
		  }
		  Gameplay_Clans_Office_View_ClanListElementArgs___Il2CppFullySharedGenericType____ctor
		            (param1_00,
		             Method_Gameplay_Clans_Office_View_ClanListElementArgs_ClanWarsOfficeModel_Policy__ClanPolicyListElement___ctor__
		            );
		  *(int *)(param1_00 + 0x1c) = param2;
		  uVar1 = unnamed_function_1417(Gameplay_Clans_Office_Model_ClanWarsOfficeModel_Policy_TypeInfo);
		  *(undefined4 *)(param1_00 + 0x24) = uVar1;
		  *(undefined4 *)(param1_00 + 0x20) =
		       *(undefined4 *)(*(int *)(*(int *)(param2 + 0x1c) + 0x3c) + 0x10);
		  *(int *)(param1 + 0x28) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06003E74 RID: 15988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E74")]
		[Address(RVA = "0x8D33", Offset = "0x8D33", VA = "0x8D33")]
		public void InitClanData(ClanData clanData)
		{
		/* --- GHIDRA: InitClanData ---
		int * Gameplay_Clans_Office_Model_ClanWarsOfficeModel__InitClanData
		                (undefined4 param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57fa9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4245);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10752);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4249);
		    DAT_ram_00a57fa9 = '\x01';
		  }
		  piVar1 = (int *)Mono_Security_ASN1Convert__ToOid(UI_Tabs_TabBarItemData___TypeInfo,3);
		  iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_10752,1,0,1,0,0,0,0);
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
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4249,1,0,1,0,0,0,0);
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
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4245,1,0,1,0,0,0,0);
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

		// Token: 0x06003E75 RID: 15989 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E75")]
		[Address(RVA = "0x8D34", Offset = "0x8D34", VA = "0x8D34")]
		public TabBarItemData[] GetTabBarData()
		{
		/* --- GHIDRA: GetTabBarData ---
		int * Gameplay_Clans_Office_Model_ClanWarsOfficeModel__GetTabBarData
		                (undefined4 param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57faa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_Filters_GenericFilter_FilterListElement_FilterData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4213);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4216);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4215);
		    DAT_ram_00a57faa = '\x01';
		  }
		  piVar1 = (int *)Mono_Security_ASN1Convert__ToOid
		                            (UI_Elements_Filters_GenericFilter_FilterListElement_FilterData___TypeInfo
		                             ,3);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4213,1,0,1,0,0,0,0);
		  if (DAT_ram_00a57fb3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Model_ClanWarsOfficeModel_ClanPolicyFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_Filters_GenericFilter_FilterListElement_FilterData_TypeInfo);
		    DAT_ram_00a57fb3 = '\x01';
		  }
		  iVar3 = unnamed_function_1417
		                    (UI_Elements_Filters_GenericFilter_FilterListElement_FilterData_TypeInfo);
		  local_c = 0;
		  uVar4 = func_ii_1081(Gameplay_Clans_Office_Model_ClanWarsOfficeModel_ClanPolicyFilter_TypeInfo,
		                       &local_c);
		  *(undefined4 *)(iVar3 + 8) = uVar2;
		  *(undefined4 *)(iVar3 + 0xc) = uVar4;
		  iVar5 = func_ii_1082(iVar3,*(undefined4 *)(*piVar1 + 0x20));
		  if (iVar5 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar1[4] = iVar3;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4216,1,0,1,0,0,0,0);
		  if (DAT_ram_00a57fb3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Model_ClanWarsOfficeModel_ClanPolicyFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_Filters_GenericFilter_FilterListElement_FilterData_TypeInfo);
		    DAT_ram_00a57fb3 = '\x01';
		  }
		  iVar3 = unnamed_function_1417
		                    (UI_Elements_Filters_GenericFilter_FilterListElement_FilterData_TypeInfo);
		  local_8 = 1;
		  uVar4 = func_ii_1081(Gameplay_Clans_Office_Model_ClanWarsOfficeModel_ClanPolicyFilter_TypeInfo,
		                       &local_8);
		  *(undefined4 *)(iVar3 + 8) = uVar2;
		  *(undefined4 *)(iVar3 + 0xc) = uVar4;
		  iVar5 = func_ii_1082(iVar3,*(undefined4 *)(*piVar1 + 0x20));
		  if (iVar5 != 0) {
		    piVar1[5] = iVar3;
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4215,1,0,1,0,0,0,0);
		    if (DAT_ram_00a57fb3 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Gameplay_Clans_Office_Model_ClanWarsOfficeModel_ClanPolicyFilter_TypeInfo);
		      Mono_Security_ASN1__get_Item
		                (&UI_Elements_Filters_GenericFilter_FilterListElement_FilterData_TypeInfo);
		      DAT_ram_00a57fb3 = '\x01';
		    }
		    iVar3 = unnamed_function_1417
		                      (UI_Elements_Filters_GenericFilter_FilterListElement_FilterData_TypeInfo);
		    local_4 = 2;
		    uVar4 = func_ii_1081(Gameplay_Clans_Office_Model_ClanWarsOfficeModel_ClanPolicyFilter_TypeInfo,
		                         &local_4);
		    *(undefined4 *)(iVar3 + 8) = uVar2;
		    *(undefined4 *)(iVar3 + 0xc) = uVar4;
		    iVar5 = func_ii_1082(iVar3,*(undefined4 *)(*piVar1 + 0x20));
		    if (iVar5 != 0) {
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

		// Token: 0x06003E76 RID: 15990 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E76")]
		[Address(RVA = "0x8D35", Offset = "0x8D35", VA = "0x8D35")]
		public FilterListElement.FilterData[] GetFilterDatas()
		{
		/* --- GHIDRA: GetFilterDatas ---
		void Gameplay_Clans_Office_Model_ClanWarsOfficeModel__GetFilterDatas
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  int *piVar8;
		  int iVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57fab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__ResourceSet___Clear__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__ResourceSet___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__ResourceSet___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__ResourceSet___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__ResourceSet__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__ResourceSet___set_Item__
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_uint__ResourceSet__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerable_ProtoGetSeasonBankDistributionAns_Types_BankDistributionInfo__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_ProtoGetSeasonBankDistributionAns_Types_BankDistributionInfo__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    DAT_ram_00a57fab = '\x01';
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x20),
		             Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__ResourceSet___Clear__
		            );
		  iVar9 = *param2;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_ProtoGetSeasonBankDistributionAns_Types_BankDistributionInfo__TypeInfo
		          == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e896ef;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_IEnumerable_ProtoGetSeasonBankDistributionAns_Types_BankDistributionInfo__TypeInfo
		                                ,0);
		code_r0x80e896ef:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar7 = local_4;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(iVar9 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80e897bd;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e89a9e:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e89aa6;
		    }
		code_r0x80e897bd:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    piVar7 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e89a9e;
		    if (iVar9 == 0) {
		      iVar9 = 0;
		      goto code_r0x80e89aef;
		    }
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_ProtoGetSeasonBankDistributionAns_Types_BankDistributionInfo__TypeInfo
		            == *piVar8) {
		          puVar3 = (undefined4 *)(iVar9 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80e8989d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_ProtoGetSeasonBankDistributionAns_Types_BankDistributionInfo__TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e899df:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e89aa6;
		    }
		code_r0x80e8989d:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e899df;
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3c1,
		                       *(undefined4 *)(param1 + 0x20),*(undefined4 *)(iVar9 + 0xc),
		                       Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__ResourceSet___ContainsKey__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e89aa6;
		    }
		    if (iVar4 == 0) {
		      param3_00 = *(undefined4 *)(iVar9 + 0xc);
		      param2_00 = *(undefined4 *)(param1 + 0x20);
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Collections_Generic_Dictionary_uint__ResourceSet__TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x225,uVar5,
		                   Method_System_Collections_Generic_Dictionary_uint__ResourceSet___ctor__);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,param2_00,param3_00,
		                     uVar5,
		                     Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__ResourceSet___set_Item__
		                    );
		          if (DAT_ram_009d3e38 != 1) goto code_r0x80e899f3;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e89aa6;
		    }
		code_r0x80e899f3:
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                       *(undefined4 *)(param1 + 0x20),*(undefined4 *)(iVar9 + 0xc),
		                       Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__ResourceSet___get_Item__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e89aa6;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,uVar5,
		               *(undefined4 *)(iVar9 + 0x10),*(undefined4 *)(iVar9 + 0x18),
		               Method_System_Collections_Generic_Dictionary_uint__ResourceSet__set_Item__);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar9 != 1);
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e89aa6:
		  iVar9 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar9 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar9;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x80e89aef:
		      piVar7 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar6 = *local_4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80e89b67;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e89b67:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		      }
		      if (iVar9 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xf8,&local_c);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06003E77 RID: 15991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E77")]
		[Address(RVA = "0x8D36", Offset = "0x8D36", VA = "0x8D36")]
		public void SetBankDistribution(IList<ProtoGetSeasonBankDistributionAns.Types.BankDistributionInfo> bankDistribution)
		{
		/* --- GHIDRA: SetBankDistribution ---
		undefined4
		Gameplay_Clans_Office_Model_ClanWarsOfficeModel__SetBankDistribution
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57fac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__ResourceSet___TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__ResourceSet__TryGetValue__);
		    DAT_ram_00a57fac = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  iVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 0x20),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__ResourceSet___TryGetValue__
		                    );
		  if (iVar1 != 0) {
		    puVar2 = &local_8;
		    iVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                      (local_4,param3,&local_8,
		                       Method_System_Collections_Generic_Dictionary_uint__ResourceSet__TryGetValue__
		                      );
		    if (iVar1 != 0) goto code_r0x80e89c4f;
		  }
		  puVar2 = (undefined4 *)(param1 + 0x24);
		code_r0x80e89c4f:
		  return *puVar2;
		}
		*/

		}

		// Token: 0x06003E78 RID: 15992 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E78")]
		[Address(RVA = "0x8D37", Offset = "0x8D37", VA = "0x8D37")]
		public ResourceSet GetBankDistribution(uint leagueId, uint lowerBound)
		{
		/* --- GHIDRA: GetBankDistribution ---
		undefined4
		Gameplay_Clans_Office_Model_ClanWarsOfficeModel__GetBankDistribution
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  
		  if (DAT_ram_00a57fad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__SeasonLeagueRewardsDic____ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__SeasonLeagueRewardsDic____get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__SeasonLeagueRewardsDic____set_Item__
		              );
		    DAT_ram_00a57fad = '\x01';
		  }
		  iVar2 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                    (*(undefined4 *)(param1 + 0x1c),param2,
		                     Method_System_Collections_Generic_Dictionary_uint__SeasonLeagueRewardsDic____ContainsKey__
		                    );
		  if (iVar2 == 0) {
		    uVar5 = *(undefined4 *)(param1 + 0x1c);
		    if (DAT_ram_00a57fa6 == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		      DAT_ram_00a57fa6 = '\x01';
		    }
		    param1_00 = *(int **)(param1 + 0xc);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		          goto code_r0x80e89d3d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e89d3d:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    uVar4 = Core_Extensions_Dict_DictExt__GetZigguratLevelDic(uVar4,param2,0);
		    System_Collections_Generic_Dictionary_uint__object___get_Item
		              (uVar5,param2,uVar4,
		               Method_System_Collections_Generic_Dictionary_uint__SeasonLeagueRewardsDic____set_Item__
		              );
		  }
		  uVar5 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(param1 + 0x1c),param2,
		                     Method_System_Collections_Generic_Dictionary_uint__SeasonLeagueRewardsDic____get_Item__
		                    );
		  return uVar5;
		}
		*/

			return null;
		}

		// Token: 0x06003E79 RID: 15993 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E79")]
		[Address(RVA = "0x8D38", Offset = "0x8D38", VA = "0x8D38")]
		public SeasonLeagueRewardsDic[] GetSeasonLeagueRewards(uint leagueId)
		{
		/* --- GHIDRA: GetSeasonLeagueRewards ---
		void Gameplay_Clans_Office_Model_ClanWarsOfficeModel__GetSeasonLeagueRewards
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57fae == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_IList_ClanPolicyListElement_ClanPolicyListElementArgs___Clear__
		              );
		    DAT_ram_00a57fae = '\x01';
		  }
		  System_Collections_Generic_Stack_BindingRestrictions_TestBuilder_AndNode____ctor
		            (*(undefined4 *)(param1 + 0x18),
		             Method_System_Collections_Generic_Stack_IList_ClanPolicyListElement_ClanPolicyListElementArgs___Clear__
		            );
		  Gameplay_Clans_Office_Model_ClanWarsOfficeModel__CreateClanList(param1,param2,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003E7A RID: 15994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E7A")]
		[Address(RVA = "0x8D39", Offset = "0x8D39", VA = "0x8D39")]
		public void CreateClanList(IList<ProtoRequestClanPolicyAns.Types.PolicyInfo> clansList)
		{
		/* --- GHIDRA: CreateClanList ---
		void Gameplay_Clans_Office_Model_ClanWarsOfficeModel__CreateClanList
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57faf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ProtoRequestClanPolicyAns_Types_PolicyInfo__ClanPolicyListElement_ClanPolicyListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_ClanPolicyListElement_ClanPolicyListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_ProtoRequestClanPolicyAns_Types_PolicyInfo__int__ClanPolicyListElement_ClanPolicyListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_IList_ClanPolicyListElement_ClanPolicyListElementArgs___Push__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_IList_ClanPolicyListElement_ClanPolicyListElementArgs___get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Model_ClanWarsOfficeModel___c__DisplayClass29_0__AddClansList_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Model_ClanWarsOfficeModel___c__DisplayClass29_0_TypeInfo);
		    DAT_ram_00a57faf = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Office_Model_ClanWarsOfficeModel___c__DisplayClass29_0_TypeInfo
		                        );
		  *(int *)(param2_00 + 8) = param1;
		  *(int *)(param2_00 + 0xc) = *(int *)(*(int *)(param1 + 0x18) + 0xc) * 100;
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Func_ProtoRequestClanPolicyAns_Types_PolicyInfo__int__ClanPolicyListElement_ClanPolicyListElementArgs__TypeInfo
		                    );
		  System_Func_object__int__long___Invoke
		            (uVar1,param2_00,
		             Method_Gameplay_Clans_Office_Model_ClanWarsOfficeModel___c__DisplayClass29_0__AddClansList_b__0__
		             ,0);
		  uVar1 = System_Linq_Enumerable__SelectMany_ValueTuple_object__object___object_
		                    (param2,uVar1,
		                     Method_System_Linq_Enumerable_Select_ProtoRequestClanPolicyAns_Types_PolicyInfo__ClanPolicyListElement_ClanPolicyListElementArgs___
		                    );
		  uVar1 = func_ii_6295(uVar1,
		                       Method_System_Linq_Enumerable_ToArray_ClanPolicyListElement_ClanPolicyListElementArgs___
		                      );
		  System_Linq_Expressions_Expression__Parameter
		            (*(undefined4 *)(param1 + 0x18),uVar1,
		             Method_System_Collections_Generic_Stack_IList_ClanPolicyListElement_ClanPolicyListElementArgs___Push__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E7B")]
		[Address(RVA = "0x8D3A", Offset = "0x8D3A", VA = "0x8D3A")]
		public void AddClansList(IList<ProtoRequestClanPolicyAns.Types.PolicyInfo> clansList)
		{
		/* --- GHIDRA: AddClansList ---
		undefined4
		Gameplay_Clans_Office_Model_ClanWarsOfficeModel__AddClansList(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 *puVar6;
		  
		  if (DAT_ram_00a57fb0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Model_ClanWarsOfficeModel_ConstructArgs__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_ClanLeagueDic__uint___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ClanLeagueDic__SubFilterListElement_SubFilterData___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToArray_SubFilterListElement_SubFilterData___);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_ClanLeagueDic__SubFilterListElement_SubFilterData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_ClanLeagueDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Model_ClanWarsOfficeModel___c__CreateSubRatingListElementArgs_b__30_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Model_ClanWarsOfficeModel___c_TypeInfo);
		    DAT_ram_00a57fb0 = '\x01';
		  }
		  if (DAT_ram_00a57fa6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57fa6 = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80e89044;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e89044:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar5 = *(undefined4 *)(iVar4 + 0xd4);
		  if (*(int *)(Gameplay_Clans_Office_Model_ClanWarsOfficeModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Clans_Office_Model_ClanWarsOfficeModel___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_Clans_Office_Model_ClanWarsOfficeModel___c_TypeInfo + 0x5c);
		  iVar4 = puVar6[1];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_Clans_Office_Model_ClanWarsOfficeModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Clans_Office_Model_ClanWarsOfficeModel___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_Clans_Office_Model_ClanWarsOfficeModel___c_TypeInfo + 0x5c)
		      ;
		    }
		    uVar3 = *puVar6;
		    iVar4 = unnamed_function_1417(System_Func_ClanLeagueDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar4,uVar3,
		               Method_Gameplay_Clans_Office_Model_ClanWarsOfficeModel___c__CreateSubRatingListElementArgs_b__30_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Clans_Office_Model_ClanWarsOfficeModel___c_TypeInfo + 0x5c) + 4) =
		         iVar4;
		  }
		  uVar5 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar5,iVar4,Method_System_Linq_Enumerable_OrderBy_ClanLeagueDic__uint___);
		  uVar3 = unnamed_function_1417
		                    (System_Func_ClanLeagueDic__SubFilterListElement_SubFilterData__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar3,param1,Method_Gameplay_Clans_Office_Model_ClanWarsOfficeModel_ConstructArgs__,0);
		  uVar5 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar5,uVar3,
		                     Method_System_Linq_Enumerable_Select_ClanLeagueDic__SubFilterListElement_SubFilterData___
		                    );
		  uVar5 = func_ii_6295(uVar5,
		                       Method_System_Linq_Enumerable_ToArray_SubFilterListElement_SubFilterData___);
		  return uVar5;
		}
		*/

		}

		// Token: 0x06003E7C RID: 15996 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E7C")]
		[Address(RVA = "0x8D3B", Offset = "0x8D3B", VA = "0x8D3B")]
		private SubFilterListElement.SubFilterData[] CreateSubRatingListElementArgs()
		{
		/* --- GHIDRA: CreateSubRatingListElementArgs ---
		int Gameplay_Clans_Office_Model_ClanWarsOfficeModel__CreateSubRatingListElementArgs
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57fb1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_Filters_GenericFilter_SubFilterListElement_SubFilterData_TypeInfo);
		    DAT_ram_00a57fb1 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (UI_Elements_Filters_GenericFilter_SubFilterListElement_SubFilterData_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  uVar2 = Core_Extensions_Dict_ClanCultDicExt__GetTitle(param2,0);
		  *(undefined4 *)(iVar1 + 0xc) = uVar2;
		  uVar2 = Core_Extensions_Dict_ClanLeagueDicExt__GetBanner2AssetId(param2,0);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06003E7D RID: 15997 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E7D")]
		[Address(RVA = "0x8D3C", Offset = "0x8D3C", VA = "0x8D3C")]
		private SubFilterListElement.SubFilterData ConstructArgs(ClanLeagueDic dic)
		{
		/* --- GHIDRA: ConstructArgs ---
		int Gameplay_Clans_Office_Model_ClanWarsOfficeModel__ConstructArgs
		              (int param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  int iVar2;
		  int param1_00;
		  uint *puVar3;
		  undefined4 param2_00;
		  undefined4 uVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a57fb2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyListElement_ClanPolicyListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Model_ClanWarsOfficeModel_Policy_TypeInfo);
		    DAT_ram_00a57fb2 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Gameplay_Clans_Office_Model_ClanWarsOfficeModel_Policy_TypeInfo);
		  *(undefined4 *)(iVar2 + 8) = *(undefined4 *)(param2 + 0x18);
		  *(undefined4 *)(iVar2 + 0xc) = *(undefined4 *)(param2 + 0x10);
		  *(undefined4 *)(iVar2 + 0x10) = *(undefined4 *)(param2 + 0x14);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyListElement_ClanPolicyListElementArgs_TypeInfo
		                        );
		  if (DAT_ram_00a57f5f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_ClanListElementArgs_ClanWarsOfficeModel_Policy__ClanPolicyListElement___ctor__
		              );
		    DAT_ram_00a57f5f = '\x01';
		  }
		  Gameplay_Clans_Office_View_ClanListElementArgs___Il2CppFullySharedGenericType____ctor
		            (param1_00,
		             Method_Gameplay_Clans_Office_View_ClanListElementArgs_ClanWarsOfficeModel_Policy__ClanPolicyListElement___ctor__
		            );
		  uVar4 = *(undefined4 *)(param2 + 0xc);
		  if (DAT_ram_00a57fa6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57fa6 = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0xc);
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x80e89fec;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e89fec:
		  param2_00 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  uVar4 = func_ii_7325(uVar4,param2_00,0);
		  *(int *)(param1_00 + 0x24) = iVar2;
		  *(undefined4 *)(param1_00 + 0x1c) = uVar4;
		  *(undefined4 *)(param1_00 + 0x20) =
		       *(undefined4 *)(*(int *)(*(int *)(param2 + 0xc) + 0x3c) + 0x10);
		  return param1_00;
		}
		*/

		/* --- GHIDRA: ConstructArgs ---
		int Gameplay_Clans_Office_Model_ClanWarsOfficeModel__ConstructArgs
		              (int param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  int iVar2;
		  int param1_00;
		  uint *puVar3;
		  undefined4 param2_00;
		  undefined4 uVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a57fb2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyListElement_ClanPolicyListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Model_ClanWarsOfficeModel_Policy_TypeInfo);
		    DAT_ram_00a57fb2 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Gameplay_Clans_Office_Model_ClanWarsOfficeModel_Policy_TypeInfo);
		  *(undefined4 *)(iVar2 + 8) = *(undefined4 *)(param2 + 0x18);
		  *(undefined4 *)(iVar2 + 0xc) = *(undefined4 *)(param2 + 0x10);
		  *(undefined4 *)(iVar2 + 0x10) = *(undefined4 *)(param2 + 0x14);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyListElement_ClanPolicyListElementArgs_TypeInfo
		                        );
		  if (DAT_ram_00a57f5f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_ClanListElementArgs_ClanWarsOfficeModel_Policy__ClanPolicyListElement___ctor__
		              );
		    DAT_ram_00a57f5f = '\x01';
		  }
		  Gameplay_Clans_Office_View_ClanListElementArgs___Il2CppFullySharedGenericType____ctor
		            (param1_00,
		             Method_Gameplay_Clans_Office_View_ClanListElementArgs_ClanWarsOfficeModel_Policy__ClanPolicyListElement___ctor__
		            );
		  uVar4 = *(undefined4 *)(param2 + 0xc);
		  if (DAT_ram_00a57fa6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57fa6 = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0xc);
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x80e89fec;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e89fec:
		  param2_00 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  uVar4 = func_ii_7325(uVar4,param2_00,0);
		  *(int *)(param1_00 + 0x24) = iVar2;
		  *(undefined4 *)(param1_00 + 0x1c) = uVar4;
		  *(undefined4 *)(param1_00 + 0x20) =
		       *(undefined4 *)(*(int *)(*(int *)(param2 + 0xc) + 0x3c) + 0x10);
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06003E7E RID: 15998 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E7E")]
		[Address(RVA = "0x8D3D", Offset = "0x8D3D", VA = "0x8D3D")]
		private ClanPolicyListElement.ClanPolicyListElementArgs ConstructArgs(ProtoRequestClanPolicyAns.Types.PolicyInfo policyInfo, in int index, in int prevCount)
		{
			return null;
		}

		// Token: 0x06003E7F RID: 15999 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E7F")]
		[Address(RVA = "0x8D3E", Offset = "0x8D3E", VA = "0x8D3E")]
		[CompilerGenerated]
		internal static FilterListElement.FilterData <GetFilterDatas>g__CreateData|24_0(ClanWarsOfficeModel.ClanPolicyFilter filter, string title)
		{
			return null;
		}

		// Token: 0x04002318 RID: 8984
		[Token(Token = "0x4002318")]
		[FieldOffset(Offset = "0xC")]
		private readonly IDictProvider _dictProvider;

		// Token: 0x04002319 RID: 8985
		[Token(Token = "0x4002319")]
		[FieldOffset(Offset = "0x10")]
		public readonly string HonorAssetId;

		// Token: 0x0400231A RID: 8986
		[Token(Token = "0x400231A")]
		[FieldOffset(Offset = "0x14")]
		public readonly SubFilterListElement.SubFilterData[] SubRatingsData;

		// Token: 0x0400231B RID: 8987
		[Token(Token = "0x400231B")]
		[FieldOffset(Offset = "0x18")]
		public readonly Stack<IList<ClanPolicyListElement.ClanPolicyListElementArgs>> ArgsPagesStack;

		// Token: 0x0400231C RID: 8988
		[Token(Token = "0x400231C")]
		[FieldOffset(Offset = "0x1C")]
		private readonly Dictionary<uint, SeasonLeagueRewardsDic[]> _seasonLeagueRewardsByLeagueId;

		// Token: 0x0400231D RID: 8989
		[Token(Token = "0x400231D")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<uint, Dictionary<uint, ResourceSet>> _banksByLowerBoundByLeagueId;

		// Token: 0x0400231E RID: 8990
		[Token(Token = "0x400231E")]
		[FieldOffset(Offset = "0x24")]
		private readonly ResourceSet _zeroResource;

		// Token: 0x02000A4D RID: 2637
		[Token(Token = "0x2000A4D")]
		public class Policy
		{
			// Token: 0x06003E80 RID: 16000 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003E80")]
			[Address(RVA = "0x8D3F", Offset = "0x8D3F", VA = "0x8D3F")]
			public Policy()
			{
			}

			// Token: 0x04002322 RID: 8994
			[Token(Token = "0x4002322")]
			[FieldOffset(Offset = "0x8")]
			public ResourceSet AttackPrice;

			// Token: 0x04002323 RID: 8995
			[Token(Token = "0x4002323")]
			[FieldOffset(Offset = "0xC")]
			public int WarDeclarationError;

			// Token: 0x04002324 RID: 8996
			[Token(Token = "0x4002324")]
			[FieldOffset(Offset = "0x10")]
			public int WarWinRatingDelta;
		}

		// Token: 0x02000A4E RID: 2638
		[Token(Token = "0x2000A4E")]
		public enum ClanPolicyFilter
		{
			// Token: 0x04002326 RID: 8998
			[Token(Token = "0x4002326")]
			ALL,
			// Token: 0x04002327 RID: 8999
			[Token(Token = "0x4002327")]
			CLAN_WARS,
			// Token: 0x04002328 RID: 9000
			[Token(Token = "0x4002328")]
			CAN_ATTACK
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_ClanData ---
		void Gameplay_Clans_Office_Model_ClanWarsOfficeModel__set_ClanData
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a57fa7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__ResourceSet____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__SeasonLeagueRewardsDic_____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__SeasonLeagueRewardsDic____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__Dictionary_uint__ResourceSet___TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_IList_ClanPolicyListElement_ClanPolicyListElementArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Stack_IList_ClanPolicyListElement_ClanPolicyListElementArgs___TypeInfo
		              );
		    DAT_ram_00a57fa7 = '\x01';
		  }
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Stack_IList_ClanPolicyListElement_ClanPolicyListElementArgs___TypeInfo
		                    );
		  Sirenix_Serialization_StackFormatter_object____Il2CppFullySharedGenericType___SerializeImplementation
		            (uVar2,
		             Method_System_Collections_Generic_Stack_IList_ClanPolicyListElement_ClanPolicyListElementArgs____ctor__
		            );
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  uVar2 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_uint__SeasonLeagueRewardsDic____TypeInfo)
		  ;
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar2,
		             Method_System_Collections_Generic_Dictionary_uint__SeasonLeagueRewardsDic_____ctor__);
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_uint__Dictionary_uint__ResourceSet___TypeInfo
		                    );
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar2,
		             Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__ResourceSet____ctor__
		            );
		  *(undefined4 *)(param1 + 0x20) = uVar2;
		  uVar2 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		  *(undefined4 *)(param1 + 0x24) = uVar2;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined4 *)(param1 + 0x2c) = param3;
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
		        goto code_r0x80e88e7f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e88e7f:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  *(int **)(param1 + 0xc) = piVar4;
		  if (DAT_ram_00a57fa6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57fa6 = '\x01';
		    piVar4 = *(int **)(param1 + 0xc);
		  }
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x80e88f2d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e88f2d:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar2 = Core_Extensions_Dict_DictExt__GetUserRatingKindDic(uVar2,4,0);
		  uVar2 = Core_Extensions_Dict_ClanLeagueDicExt__GetIconAssetId(uVar2,0);
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  uVar2 = Gameplay_Clans_Office_Model_ClanWarsOfficeModel__AddClansList(param1,puVar3);
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  return;
		}
		*/

}
