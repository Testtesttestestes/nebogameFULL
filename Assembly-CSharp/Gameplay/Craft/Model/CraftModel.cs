using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Il2CppDummyDll;
using MVC;
using Protocol.Craft;
using Protocol.Dic;
using UI.Tabs;

namespace Gameplay.Craft.Model
{
	// Token: 0x020008C0 RID: 2240
	[Token(Token = "0x20008C0")]
	public class CraftModel : AbstractModel
	{
		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06003495 RID: 13461 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A70")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6003495")]
			[Address(RVA = "0x84BF", Offset = "0x84BF", VA = "0x84BF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06003496 RID: 13462 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003497 RID: 13463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A71")]
		public UserProfession Profession
		{
			[Token(Token = "0x6003496")]
			[Address(RVA = "0x84C0", Offset = "0x84C0", VA = "0x84C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003497")]
			[Address(RVA = "0x84C1", Offset = "0x84C1", VA = "0x84C1")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06003498 RID: 13464 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003499 RID: 13465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A72")]
		public ProfessionDic ProfessionDic
		{
			[Token(Token = "0x6003498")]
			[Address(RVA = "0x84C2", Offset = "0x84C2", VA = "0x84C2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003499")]
			[Address(RVA = "0x84C3", Offset = "0x84C3", VA = "0x84C3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x0600349A RID: 13466 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600349B RID: 13467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A73")]
		public ArtikulTypeFilters[] Filters
		{
			[Token(Token = "0x600349A")]
			[Address(RVA = "0x84C4", Offset = "0x84C4", VA = "0x84C4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600349B")]
			[Address(RVA = "0x84C5", Offset = "0x84C5", VA = "0x84C5")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x0600349C RID: 13468 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600349D RID: 13469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A74")]
		public IList<UserCraftSlotInfo> SlotInfos
		{
			[Token(Token = "0x600349C")]
			[Address(RVA = "0x84C6", Offset = "0x84C6", VA = "0x84C6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600349D")]
			[Address(RVA = "0x84C7", Offset = "0x84C7", VA = "0x84C7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x0600349E RID: 13470 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600349F RID: 13471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A75")]
		public IList<CraftSlotDic> AllCraftSlots
		{
			[Token(Token = "0x600349E")]
			[Address(RVA = "0x84C8", Offset = "0x84C8", VA = "0x84C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600349F")]
			[Address(RVA = "0x84C9", Offset = "0x84C9", VA = "0x84C9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x060034A0 RID: 13472 RVA: 0x0000AA88 File Offset: 0x00008C88
		// (set) Token: 0x060034A1 RID: 13473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A76")]
		public DateTime OriginTime
		{
			[Token(Token = "0x60034A0")]
			[Address(RVA = "0x84CA", Offset = "0x84CA", VA = "0x84CA")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60034A1")]
			[Address(RVA = "0x84CB", Offset = "0x84CB", VA = "0x84CB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A2")]
		[Address(RVA = "0x84CC", Offset = "0x84CC", VA = "0x84CC")]
		public CraftModel(UserData user)
		{
		/* --- GHIDRA: <PopulateSchemes>b__33_0 ---
		void Gameplay_Craft_Model_CraftModel___PopulateSchemes_b__33_0(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63a2c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_Model_CraftModel___c_TypeInfo);
		    DAT_ram_00a63a2c = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Craft_Model_CraftModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Craft_Model_CraftModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Craft_Model_CraftModel___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a63a25 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Craft_Model_CraftModel__PopulateSchemes_b__33_0__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderByDescending_CraftSchemeData__uint___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_UserScheme__CraftSchemeData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_CraftSchemeData___);
		    Mono_Security_ASN1__get_Item(&System_Func_UserScheme__CraftSchemeData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_CraftSchemeData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_Model_CraftModel___c__PopulateSchemes_b__33_1__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_Model_CraftModel___c_TypeInfo);
		    DAT_ram_00a63a25 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Func_UserScheme__CraftSchemeData__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,Method_Gameplay_Craft_Model_CraftModel__PopulateSchemes_b__33_0__,0);
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param2,uVar1,
		                     Method_System_Linq_Enumerable_Select_UserScheme__CraftSchemeData___);
		  if (*(int *)(Gameplay_Craft_Model_CraftModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Craft_Model_CraftModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_Craft_Model_CraftModel___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[4];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_Craft_Model_CraftModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Craft_Model_CraftModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_Craft_Model_CraftModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_CraftSchemeData__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_00,param2_00,
		               Method_Gameplay_Craft_Model_CraftModel___c__PopulateSchemes_b__33_1__,0);
		    *(int *)(*(int *)(Gameplay_Craft_Model_CraftModel___c_TypeInfo + 0x5c) + 0x10) = param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__OrderBy___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar1,param1_00,
		                     Method_System_Linq_Enumerable_OrderByDescending_CraftSchemeData__uint___);
		  uVar1 = System_Linq_Enumerable__Select_object__object_
		                    (uVar1,Method_System_Linq_Enumerable_ToList_CraftSchemeData___);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A3")]
		[Address(RVA = "0x84CD", Offset = "0x84CD", VA = "0x84CD")]
		public void PopulateSchemes(IList<UserScheme> userSchemes)
		{
		/* --- GHIDRA: PopulateSchemes ---
		int * Gameplay_Craft_Model_CraftModel__PopulateSchemes(undefined4 param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a63a26 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4474);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4475);
		    DAT_ram_00a63a26 = '\x01';
		  }
		  piVar1 = (int *)Mono_Security_ASN1Convert__ToOid(UI_Tabs_TabBarItemData___TypeInfo,2);
		  iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4475,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0x10) = uVar3;
		  iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		  if (iVar4 != 0) {
		    piVar1[4] = iVar2;
		    iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4474,1,0,1,0,0,0,0);
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
		*/

		}

		// Token: 0x060034A4 RID: 13476 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034A4")]
		[Address(RVA = "0x84CE", Offset = "0x84CE", VA = "0x84CE")]
		public TabBarItemData[] GetTabBarData()
		{
		/* --- GHIDRA: GetTabBarData ---
		void Gameplay_Craft_Model_CraftModel__GetTabBarData(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  *(int *)(param1 + 0x14) = param2;
		  if (DAT_ram_00a63a23 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a63a23 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x8232c71b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x8232c71b:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Core_Extensions_Dict_DictExt__GetIsleAnimationDic(uVar3,*(undefined4 *)(param2 + 0xc),0);
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060034A5 RID: 13477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A5")]
		[Address(RVA = "0x84CF", Offset = "0x84CF", VA = "0x84CF")]
		public void SetProfession(UserProfession profession)
		{
		/* --- GHIDRA: SetProfession ---
		void Gameplay_Craft_Model_CraftModel__SetProfession(int param1,int *param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 *puVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int *piVar4;
		  undefined8 uVar5;
		  int *piVar6;
		  int iVar7;
		  uint uVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a63a27 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTime_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__long__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_UserCraftSlotInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_UserCraftSlotInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    DAT_ram_00a63a27 = '\x01';
		  }
		  if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTime_TypeInfo);
		  }
		  uVar8 = 0;
		  uVar5 = ICSharpCode_SharpZipLib_Zip_ZipEntry___ctor(0);
		  *(undefined8 *)(param1 + 0x28) = uVar5;
		  iVar7 = *param2;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_UserCraftSlotInfo__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8)) {
		        puVar1 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8232c826;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar8);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_IEnumerable_UserCraftSlotInfo__TypeInfo,0
		                               );
		code_r0x8232c826:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar4 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar6 = (int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar6) {
		          puVar2 = (undefined4 *)(iVar7 + piVar6[1] * 8 + 0xc0);
		          goto code_r0x8232c8f4;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar8);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8232ca7a:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8232ca82;
		    }
		code_r0x8232c8f4:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar2,piVar4,puVar2[1]);
		    piVar4 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8232ca7a;
		    if (iVar7 == 0) {
		      iVar7 = 0;
		      goto code_r0x8232cacb;
		    }
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar6 = (int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8);
		        if (System_Collections_Generic_IEnumerator_UserCraftSlotInfo__TypeInfo == *piVar6) {
		          puVar2 = (undefined4 *)(iVar7 + piVar6[1] * 8 + 0xc0);
		          goto code_r0x8232c9ce;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar8);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_UserCraftSlotInfo__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8232ca66:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8232ca82;
		    }
		code_r0x8232c9ce:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar2,piVar4,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8232ca66;
		    DAT_ram_009d3e38 = 0;
		    unnamed_function_184064
		              (s___Scripting__Unity__IO__Archive__ram_00004472 + 0x1f,*(undefined4 *)(param1 + 0x34)
		               ,*(undefined4 *)(iVar7 + 0xc),*(undefined8 *)(iVar7 + 0x10),
		               Method_System_Collections_Generic_Dictionary_uint__long__set_Item__);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar7 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8232ca82:
		  iVar7 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar7 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar7;
		    import::env::invoke_v(0x123);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
		code_r0x8232cacb:
		      piVar4 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar8 = 0;
		        iVar3 = *local_4;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar8 * 8)) {
		              puVar1 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x8232cb43;
		            }
		            uVar8 = uVar8 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar8);
		        }
		        puVar1 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x8232cb43:
		        (**(code **)((ulonglong)*puVar1 * 4))(piVar4,puVar1[1]);
		      }
		      if (iVar7 == 0) {
		        *(int **)(param1 + 0x20) = param2;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x20,&local_c);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060034A6 RID: 13478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A6")]
		[Address(RVA = "0x84D0", Offset = "0x84D0", VA = "0x84D0")]
		public void SetCraftSlots(IList<UserCraftSlotInfo> slots)
		{
		/* --- GHIDRA: SetCraftSlots ---
		uint Gameplay_Craft_Model_CraftModel__SetCraftSlots
		               (int param1,undefined4 param2,longlong *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined8 param1_00;
		  double dVar2;
		  longlong lVar3;
		  longlong lVar4;
		  undefined8 local_10;
		  longlong local_8;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a63a29 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTime_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__long__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    DAT_ram_00a63a29 = '\x01';
		  }
		  local_8 = 0;
		  *param3 = 0;
		  System_Collections_Generic_Dictionary_uint__long___TryAdd
		            (*(undefined4 *)(param1 + 0x34),param2,&local_8,
		             Method_System_Collections_Generic_Dictionary_uint__long__TryGetValue__);
		  if (local_8 != 0) {
		    if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_DateTime_TypeInfo);
		    }
		    param1_00 = ICSharpCode_SharpZipLib_Zip_ZipEntry___ctor(0);
		    local_10 = System_DateTime__op_Subtraction(param1_00,*(undefined8 *)(param1 + 0x28),0);
		    lVar3 = local_8;
		    if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_TimeSpan_TypeInfo);
		    }
		    dVar2 = System_Net_FtpMethodInfo__GetMethodInfo(&local_10,0);
		    if (ABS(dVar2) < 9.223372036854776e+18) {
		      lVar4 = (longlong)dVar2;
		    }
		    else {
		      lVar4 = -0x8000000000000000;
		    }
		    lVar3 = lVar3 - lVar4;
		    lVar4 = lVar3;
		    if (lVar3 < 1) {
		      lVar4 = 0;
		    }
		    *param3 = lVar4;
		    uVar1 = (uint)(lVar3 < 1);
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034A7")]
		[Address(RVA = "0x4498", Offset = "0x4498", VA = "0x4498")]
		public CraftSchemeData.CraftSchemeInfo GetSchemeInfo(uint schemeId)
		{
		/* --- GHIDRA: GetSchemeInfo ---
		void Gameplay_Craft_Model_CraftModel__GetSchemeInfo
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  float param2_00;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  undefined8 param1_01;
		  longlong lVar5;
		  undefined4 *puVar6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57cf4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_CraftSlotArtikulView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_CraftSlotListElement_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4463);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4464);
		    DAT_ram_00a57cf4 = '\x01';
		  }
		  *(int *)(param1 + 0x44) = param3;
		  *(int *)(param1 + 0x4c) = param2;
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,3,
		             Method_UI_MonoBehaviourWithStates_CraftSlotListElement_State__set_CurrentState__);
		  uVar3 = *(undefined4 *)(param1 + 0x20);
		  uVar2 = Core_Extensions_Dict_CompetitionRatingKindDicExt__GetDescription
		                    (*(undefined4 *)(param2 + 8),0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar2,0);
		  uVar3 = *(undefined4 *)(param1 + 0x38);
		  local_4 = *(undefined4 *)(*(int *)(param1 + 0x44) + 0x28);
		  uVar2 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar2,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x38),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(*(int *)(*(int *)(param1 + 0x44) + 0x28) != 0),0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x3c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(*(longlong *)(param3 + 0x20) != 0),0);
		  uVar3 = *(undefined4 *)(param1 + 0x3c);
		  uVar2 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,0.0,0);
		  param1_01 = *(undefined8 *)(param3 + 0x20);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = Utils_StringUtils___cctor(param1_01,0);
		  uVar1 = (undefined4)((ulonglong)param1_01 >> 0x20);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,param2_00,0);
		  UI_Elements_RightPanel_TitleWithLevel__set_Level(uVar3,uVar2,0);
		  param1_00 = *(int **)(param1 + 0x2c);
		  iVar4 = *param1_00;
		  if (iVar4 == Gameplay_Inventory_View_CraftSlotArtikulView_TypeInfo) {
		    Gameplay_Inventory_View_CraftSlotArtikulView__set_Data(param1_00,param2,param3,0);
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0x138) * 4))
		              (CONCAT44(uVar1,param1_00),*(undefined4 *)(param2 + 0x10),
		               *(undefined4 *)(iVar4 + 0x13c));
		  }
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x2c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x28);
		  lVar5 = *(longlong *)(param3 + 0x20);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  puVar6 = &StringLiteral_4464;
		  if (lVar5 != 0) {
		    puVar6 = &StringLiteral_4463;
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(*puVar6,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar3,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x0000AAA0 File Offset: 0x00008CA0
		[Token(Token = "0x60034A8")]
		[Address(RVA = "0x84D1", Offset = "0x84D1", VA = "0x84D1")]
		public bool TryGetSlotExpirationTime(uint slotId, out long time)
		{
		/* --- GHIDRA: TryGetSlotExpirationTime ---
		void Gameplay_Craft_Model_CraftModel__TryGetSlotExpirationTime(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63a2a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_uint__long__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__CraftSchemeData_CraftSchemeInfo__Clear__
		              );
		    DAT_ram_00a63a2a = '\x01';
		  }
		  *(undefined4 *)(param1 + 0xc) = 0;
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x30),
		             Method_System_Collections_Generic_Dictionary_uint__CraftSchemeData_CraftSchemeInfo__Clear__
		            );
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x34),
		             Method_System_Collections_Generic_Dictionary_uint__long__Clear__);
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060034A9 RID: 13481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A9")]
		[Address(RVA = "0x84D2", Offset = "0x84D2", VA = "0x84D2", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		undefined4 Gameplay_Craft_Model_CraftModel__Dispose(undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param3_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63a2b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_CraftSchemeData_TypeInfo);
		    DAT_ram_00a63a2b = '\x01';
		  }
		  param3_00 = Gameplay_Craft_View_CraftSlotListElement__DisplayEmptySlot
		                        (param1,*(undefined4 *)(param2 + 0xc),param2);
		  param1_00 = unnamed_function_1417(Core_Data_CraftSchemeData_TypeInfo);
		  UnityEngine_Purchasing_Default_Factory__Create(param1_00,param2,param3_00,0);
		  return param1_00;
		}
		*/

		}

		// Token: 0x04001CCC RID: 7372
		[Token(Token = "0x4001CCC")]
		private const string LOCALIZATION_CRAFT_RECIPES = "CRAFT/RECIPES";

		// Token: 0x04001CCD RID: 7373
		[Token(Token = "0x4001CCD")]
		private const string LOCALIZATION_CRAFT_PRODUCTION = "CRAFT/PRODUCTION";

		// Token: 0x04001CCE RID: 7374
		[Token(Token = "0x4001CCE")]
		[FieldOffset(Offset = "0xC")]
		public List<CraftSchemeData> CraftSchemes;

		// Token: 0x04001CCF RID: 7375
		[Token(Token = "0x4001CCF")]
		[FieldOffset(Offset = "0x10")]
		private IDictProvider _dictProvider;

		// Token: 0x04001CD6 RID: 7382
		[Token(Token = "0x4001CD6")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<uint, CraftSchemeData.CraftSchemeInfo> _schemeInfoCache;

		// Token: 0x04001CD7 RID: 7383
		[Token(Token = "0x4001CD7")]
		[FieldOffset(Offset = "0x34")]
		private readonly Dictionary<uint, long> _expirationTimesBySlotId;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_OriginTime ---
		void Gameplay_Craft_Model_CraftModel__set_OriginTime(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 *puVar6;
		  undefined4 uVar7;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a63a24 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_uint__long___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__CraftSchemeData_CraftSchemeInfo___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_uint__long__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_uint__CraftSchemeData_CraftSchemeInfo__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Aggregate_CraftSlotDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_ArtikulTypeFilters__uint___)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_CraftSlotDic__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ArtikulTypeFilters___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_CraftSlotDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_CraftSlotDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtikulTypeFilters__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_CraftSlotDic__CraftSlotDic__CraftSlotDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_CraftSlotDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_CraftSlotDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CraftSchemeData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_CraftSchemeData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Craft_Model_CraftModel___c___ctor_b__32_0__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Craft_Model_CraftModel___c___ctor_b__32_1__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Craft_Model_CraftModel___c___ctor_b__32_2__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_Model_CraftModel___c_TypeInfo);
		    DAT_ram_00a63a24 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Collections_Generic_List_CraftSchemeData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar2,Method_System_Collections_Generic_List_CraftSchemeData___ctor__);
		  *(undefined4 *)(param1 + 0xc) = uVar2;
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_uint__CraftSchemeData_CraftSchemeInfo__TypeInfo
		                    );
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar2,
		             Method_System_Collections_Generic_Dictionary_uint__CraftSchemeData_CraftSchemeInfo___ctor__
		            );
		  *(undefined4 *)(param1 + 0x30) = uVar2;
		  uVar2 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__long__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar2,Method_System_Collections_Generic_Dictionary_uint__long___ctor__);
		  *(undefined4 *)(param1 + 0x34) = uVar2;
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
		        goto code_r0x8232bf67;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8232bf67:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  *(int **)(param1 + 0x10) = piVar4;
		  if (DAT_ram_00a63a23 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a63a23 = '\x01';
		    piVar4 = *(int **)(param1 + 0x10);
		  }
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x8232c013;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x8232c013:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar2 = Core_Extensions_Dict_DictExt__GetGameFiledGems(uVar2,0x80,0);
		  if (*(int *)(Gameplay_Craft_Model_CraftModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Craft_Model_CraftModel___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_Craft_Model_CraftModel___c_TypeInfo + 0x5c);
		  iVar5 = puVar6[1];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_Craft_Model_CraftModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Craft_Model_CraftModel___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_Craft_Model_CraftModel___c_TypeInfo + 0x5c);
		    }
		    uVar7 = *puVar6;
		    iVar5 = unnamed_function_1417(System_Func_ArtikulTypeFilters__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar5,uVar7,Method_Gameplay_Craft_Model_CraftModel___c___ctor_b__32_0__,0);
		    *(int *)(*(int *)(Gameplay_Craft_Model_CraftModel___c_TypeInfo + 0x5c) + 4) = iVar5;
		  }
		  uVar2 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar2,iVar5,Method_System_Linq_Enumerable_OrderBy_ArtikulTypeFilters__uint___);
		  uVar2 = func_ii_6295(uVar2,Method_System_Linq_Enumerable_ToArray_ArtikulTypeFilters___);
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  if (DAT_ram_00a63a23 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a63a23 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x10);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x8232c15a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x8232c15a:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar2 = *(undefined4 *)(iVar5 + 0xb4);
		  if (*(int *)(Gameplay_Craft_Model_CraftModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Craft_Model_CraftModel___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_Craft_Model_CraftModel___c_TypeInfo + 0x5c);
		  iVar5 = puVar6[2];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_Craft_Model_CraftModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Craft_Model_CraftModel___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_Craft_Model_CraftModel___c_TypeInfo + 0x5c);
		    }
		    uVar7 = *puVar6;
		    iVar5 = unnamed_function_1417(System_Func_CraftSlotDic__CraftSlotDic__CraftSlotDic__TypeInfo);
		    System_Threading_Tasks_Task_object___get_Factory
		              (iVar5,uVar7,Method_Gameplay_Craft_Model_CraftModel___c___ctor_b__32_1__,0);
		    *(int *)(*(int *)(Gameplay_Craft_Model_CraftModel___c_TypeInfo + 0x5c) + 8) = iVar5;
		  }
		  uVar2 = UnityEngine_UIElements_EnumField__ProcessPointerDown_object_
		                    (uVar2,iVar5,Method_System_Linq_Enumerable_Aggregate_CraftSlotDic___);
		  if (DAT_ram_00a63a23 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a63a23 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x10);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x8232c291;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x8232c291:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar7 = *(undefined4 *)(iVar5 + 0xb4);
		  if (*(int *)(Gameplay_Craft_Model_CraftModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Craft_Model_CraftModel___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_Craft_Model_CraftModel___c_TypeInfo + 0x5c);
		  iVar5 = puVar6[3];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_Craft_Model_CraftModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Craft_Model_CraftModel___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_Craft_Model_CraftModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar6;
		    iVar5 = unnamed_function_1417(System_Func_CraftSlotDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar5,param2_00,Method_Gameplay_Craft_Model_CraftModel___c___ctor_b__32_2__,0);
		    *(int *)(*(int *)(Gameplay_Craft_Model_CraftModel___c_TypeInfo + 0x5c) + 0xc) = iVar5;
		  }
		  uVar1 = 0;
		  uVar7 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar7,iVar5,Method_System_Linq_Enumerable_OrderBy_CraftSlotDic__uint___);
		  piVar4 = (int *)System_Linq_Enumerable__Select_object__object_
		                            (uVar7,Method_System_Linq_Enumerable_ToList_CraftSlotDic___);
		  *(int **)(param1 + 0x24) = piVar4;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_CraftSlotDic__TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xf0);
		        goto code_r0x8232c3ba;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,System_Collections_Generic_ICollection_CraftSlotDic__TypeInfo
		                                ,6);
		code_r0x8232c3ba:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,uVar2,puVar3[1]);
		  uVar1 = 0;
		  piVar4 = *(int **)(param1 + 0x24);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IList_CraftSlotDic__TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8232c43a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,System_Collections_Generic_IList_CraftSlotDic__TypeInfo,3);
		code_r0x8232c43a:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,0,uVar2,puVar3[1]);
		  return;
		}
		*/

}
