using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Cache;
using Core.Data;
using Core.Data.Skills;
using Core.Gameplay.Managers;
using Gameplay.School.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Main;
using Protocol.School;
using UI.Elements.Buildings;
using UI.Elements.Filters.GenericFilter;
using UI.Tabs;

namespace Gameplay.Clans.Office.Model
{
	// Token: 0x02000A51 RID: 2641
	[Token(Token = "0x2000A51")]
	public class ClassModel : AbstractModel
	{
		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06003E86 RID: 16006 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C87")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6003E86")]
			[Address(RVA = "0x8D45", Offset = "0x8D45", VA = "0x8D45")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003E87 RID: 16007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E87")]
		[Address(RVA = "0x8D46", Offset = "0x8D46", VA = "0x8D46")]
		public ClassModel(UserData user, WorldAxisManager worldAxisManager)
		{
		/* --- GHIDRA: <PopulateSpells>b__29_0 ---
		void Gameplay_Clans_Office_Model_ClassModel___PopulateSpells_b__29_0
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined8 param2_00;
		  
		  *(undefined1 *)(param1 + 0x10) = 1;
		  *(undefined4 *)(param1 + 8) = param2;
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param2,0);
		  uVar1 = Core_Extensions_Dict_DictExt__GetColossusDic(param3,param2_00,0);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: <.ctor>b__6_1 ---
		undefined4
		Gameplay_Clans_Office_Model_ClassModel____ctor_b__6_1
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57fbc == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_School_Model_SchoolSpellData_TypeInfo);
		    DAT_ram_00a57fbc = '\x01';
		  }
		  param4 = UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfoDialogWindow_SpellUpgradeInfoDialogWindowArgs___ctor
		                     (*(undefined4 *)(*(int *)(param1 + 0x14) + 0x14),0);
		  param1_00 = unnamed_function_1417(Gameplay_School_Model_SchoolSpellData_TypeInfo);
		  Gameplay_School_Model_SchoolSpellData___ctor(param1_00,param2,0,param4,0);
		  return param1_00;
		}
		*/

		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06003E88 RID: 16008 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E89 RID: 16009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C88")]
		public Dictionary<ulong, SpellListArgs> SpellsByDollById
		{
			[Token(Token = "0x6003E88")]
			[Address(RVA = "0x8D47", Offset = "0x8D47", VA = "0x8D47")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E89")]
			[Address(RVA = "0x8D48", Offset = "0x8D48", VA = "0x8D48")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06003E8A RID: 16010 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E8B RID: 16011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C89")]
		public Dictionary<uint, SchoolSpellData> SpellsById
		{
			[Token(Token = "0x6003E8A")]
			[Address(RVA = "0x8D49", Offset = "0x8D49", VA = "0x8D49")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E8B")]
			[Address(RVA = "0x8D4A", Offset = "0x8D4A", VA = "0x8D4A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x06003E8C RID: 16012 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E8D RID: 16013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8A")]
		public Dictionary<int, ArtifactData> ArtifactsBySlotId
		{
			[Token(Token = "0x6003E8C")]
			[Address(RVA = "0x8D4B", Offset = "0x8D4B", VA = "0x8D4B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E8D")]
			[Address(RVA = "0x8D4C", Offset = "0x8D4C", VA = "0x8D4C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x06003E8E RID: 16014 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E8F RID: 16015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8B")]
		public SubFilterListElement.SubFilterData[] SubFilterData
		{
			[Token(Token = "0x6003E8E")]
			[Address(RVA = "0x8D4D", Offset = "0x8D4D", VA = "0x8D4D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E8F")]
			[Address(RVA = "0x8D4E", Offset = "0x8D4E", VA = "0x8D4E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06003E90 RID: 16016 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E91 RID: 16017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8C")]
		public Dictionary<ulong, ClassModel.DollData> DollDataById
		{
			[Token(Token = "0x6003E90")]
			[Address(RVA = "0x8D4F", Offset = "0x8D4F", VA = "0x8D4F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E91")]
			[Address(RVA = "0x8D50", Offset = "0x8D50", VA = "0x8D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003E92 RID: 16018 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E92")]
		[Address(RVA = "0x8D51", Offset = "0x8D51", VA = "0x8D51")]
		public TabBarItemData[] GetTabBarData()
		{
		/* --- GHIDRA: GetTabBarData ---
		void Gameplay_Clans_Office_Model_ClassModel__GetTabBarData
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 param1_00;
		  int iVar4;
		  int *piVar5;
		  int *piVar6;
		  int iVar7;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57fb7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_UserArtifact__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_UserArtifact__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    DAT_ram_00a57fb7 = '\x01';
		  }
		  iVar7 = *param2;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_UserArtifact__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e8a8ec;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_IEnumerable_UserArtifact__TypeInfo
		                                ,0);
		code_r0x80e8a8ec:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar6 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar6) {
		          puVar3 = (undefined4 *)(iVar7 + piVar6[1] * 8 + 0xc0);
		          goto code_r0x80e8a9ba;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e8ab30:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e8ab38;
		    }
		code_r0x80e8a9ba:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e8ab30;
		    if (iVar7 == 0) {
		      iVar7 = 0;
		      goto code_r0x80e8ab81;
		    }
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar6 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_UserArtifact__TypeInfo == *piVar6) {
		          puVar3 = (undefined4 *)(iVar7 + piVar6[1] * 8 + 0xc0);
		          goto code_r0x80e8aa94;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_UserArtifact__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e8ab1c:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e8ab38;
		    }
		code_r0x80e8aa94:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e8ab1c;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xf9,param1,
		               *(undefined4 *)(iVar7 + 0xc),*(undefined4 *)(iVar7 + 0x10),
		               *(undefined4 *)(iVar7 + 0xc));
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar7 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e8ab38:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar7 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar7;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		code_r0x80e8ab81:
		      piVar5 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar4 = *local_4;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80e8abf9;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e8abf9:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      }
		      if (iVar7 == 0) {
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
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xfa,&local_c);
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

			return null;
		}

		// Token: 0x06003E93 RID: 16019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E93")]
		[Address(RVA = "0x8D52", Offset = "0x8D52", VA = "0x8D52")]
		public void ParseSlotChanges(IList<UserArtifact> artifacts)
		{
		/* --- GHIDRA: ParseSlotChanges ---
		void Gameplay_Clans_Office_Model_ClassModel__ParseSlotChanges
		               (int param1,int param2,undefined8 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  undefined4 param1_01;
		  int param3_00;
		  
		  if (DAT_ram_00a57fb8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Model_ClassModel__PopulateSpells_b__29_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__SpellListArgs__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_SchoolSpellData__SpellItemArgs___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_ShortSpellInfo__SchoolSpellData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_SchoolSpellData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_SpellItemArgs___);
		    Mono_Security_ASN1__get_Item(&System_Func_ShortSpellInfo__SchoolSpellData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_SchoolSpellData__SpellItemArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Elements_Buildings_SpellListArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Model_ClassModel___c__PopulateSpells_b__29_1__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Model_ClassModel___c_TypeInfo);
		    DAT_ram_00a57fb8 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param2 + 0xc);
		  uVar1 = unnamed_function_1417(System_Func_ShortSpellInfo__SchoolSpellData__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,Method_Gameplay_Clans_Office_Model_ClassModel__PopulateSpells_b__29_0__,0)
		  ;
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar2,uVar1,
		                     Method_System_Linq_Enumerable_Select_ShortSpellInfo__SchoolSpellData___);
		  param1_00 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_SchoolSpellData___);
		  if (*(int *)(Gameplay_Clans_Office_Model_ClassModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Clans_Office_Model_ClassModel___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Clans_Office_Model_ClassModel___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[3];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_Clans_Office_Model_ClassModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Clans_Office_Model_ClassModel___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Gameplay_Clans_Office_Model_ClassModel___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar3;
		    iVar4 = unnamed_function_1417(System_Func_SchoolSpellData__SpellItemArgs__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar4,uVar1,
		               Method_Gameplay_Clans_Office_Model_ClassModel___c__PopulateSpells_b__29_1__,0);
		    *(int *)(*(int *)(Gameplay_Clans_Office_Model_ClassModel___c_TypeInfo + 0x5c) + 0xc) = iVar4;
		  }
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param1_00,iVar4,
		                     Method_System_Linq_Enumerable_Select_SchoolSpellData__SpellItemArgs___);
		  uVar1 = System_Linq_Enumerable__Select_object__object_
		                    (uVar1,Method_System_Linq_Enumerable_ToList_SpellItemArgs___);
		  param1_01 = *(undefined4 *)(param1 + 0x1c);
		  uVar2 = unnamed_function_1417(UI_Elements_Buildings_SpellListArgs_TypeInfo);
		  UI_Elements_Buildings_SpellListArgs___ctor(uVar2,uVar1,0);
		  Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel_DollArtifacts___ctor
		            (param1_01,param3,uVar2,
		             Method_System_Collections_Generic_Dictionary_ulong__SpellListArgs__set_Item__);
		  if (0 < *(int *)(param1_00 + 0xc)) {
		    iVar4 = 0;
		    do {
		      param3_00 = *(int *)(param1_00 + iVar4 * 4 + 0x10);
		      System_Collections_Generic_Dictionary_uint__object___get_Item
		                (*(undefined4 *)(param1 + 0x20),*(undefined4 *)(*(int *)(param3_00 + 0xc) + 0xc),
		                 param3_00,
		                 Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__set_Item__);
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(param1_00 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003E94 RID: 16020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E94")]
		[Address(RVA = "0x8D53", Offset = "0x8D53", VA = "0x8D53")]
		public void PopulateSpells(ProtoGetSchoolInfoAns msg, ulong dollId)
		{
		/* --- GHIDRA: PopulateSpells ---
		int Gameplay_Clans_Office_Model_ClassModel__PopulateSpells
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57fb9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_Filters_GenericFilter_SubFilterListElement_SubFilterData_TypeInfo);
		    DAT_ram_00a57fb9 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (UI_Elements_Filters_GenericFilter_SubFilterListElement_SubFilterData_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  uVar2 = Core_Extensions_Dict_DiscountsDicExt__GetDiscountDescription(param2,0);
		  *(undefined4 *)(iVar1 + 0xc) = uVar2;
		  uVar2 = Core_Extensions_Dict_DollInfoDicExt__GetTraitsColumn(param2,0);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06003E95 RID: 16021 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E95")]
		[Address(RVA = "0x8D54", Offset = "0x8D54", VA = "0x8D54")]
		private SubFilterListElement.SubFilterData CreateSubFilters(DollsInfoDic dic)
		{
		/* --- GHIDRA: CreateSubFilters ---
		int Gameplay_Clans_Office_Model_ClassModel__CreateSubFilters
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined8 param2_00;
		  
		  if (DAT_ram_00a57fbb == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Model_ClassModel_DollData_TypeInfo);
		    DAT_ram_00a57fbb = '\x01';
		  }
		  uVar1 = UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfoDialogWindow_SpellUpgradeInfoDialogWindowArgs___ctor
		                    (*(undefined4 *)(*(int *)(param1 + 0x14) + 0x14),0);
		  iVar2 = unnamed_function_1417(Gameplay_Clans_Office_Model_ClassModel_DollData_TypeInfo);
		  *(undefined1 *)(iVar2 + 0x10) = 1;
		  *(undefined4 *)(iVar2 + 8) = param2;
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param2,0);
		  uVar1 = Core_Extensions_Dict_DictExt__GetColossusDic(uVar1,param2_00,0);
		  *(undefined4 *)(iVar2 + 0x14) = uVar1;
		  return iVar2;
		}
		*/

			return null;
		}

		// Token: 0x06003E96 RID: 16022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E96")]
		[Address(RVA = "0x1C80", Offset = "0x1C80", VA = "0x1C80")]
		private void SetArtifact(int slotId, ArtifactInfo artifactInfo)
		{
		}

		// Token: 0x0400232D RID: 9005
		[Token(Token = "0x400232D")]
		[FieldOffset(Offset = "0xC")]
		private readonly ArtifactCache _cache;

		// Token: 0x0400232E RID: 9006
		[Token(Token = "0x400232E")]
		[FieldOffset(Offset = "0x10")]
		public readonly UserData GolemUserData;

		// Token: 0x0400232F RID: 9007
		[Token(Token = "0x400232F")]
		[FieldOffset(Offset = "0x14")]
		public readonly WorldAxisManager WorldAxisManager;

		// Token: 0x04002330 RID: 9008
		[Token(Token = "0x4002330")]
		[FieldOffset(Offset = "0x18")]
		public readonly HashSet<uint> CustomSkillIds;

		// Token: 0x02000A52 RID: 2642
		[Token(Token = "0x2000A52")]
		public class DollData
		{
			// Token: 0x06003E99 RID: 16025 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003E99")]
			[Address(RVA = "0x8D57", Offset = "0x8D57", VA = "0x8D57")]
			public DollData(UserData user, Dictionaries dict)
			{
			}

			// Token: 0x04002336 RID: 9014
			[Token(Token = "0x4002336")]
			[FieldOffset(Offset = "0x8")]
			public readonly UserData UserData;

			// Token: 0x04002337 RID: 9015
			[Token(Token = "0x4002337")]
			[FieldOffset(Offset = "0xC")]
			public SkillCollection Skills;

			// Token: 0x04002338 RID: 9016
			[Token(Token = "0x4002338")]
			[FieldOffset(Offset = "0x10")]
			public bool IsDirty;

			// Token: 0x04002339 RID: 9017
			[Token(Token = "0x4002339")]
			[FieldOffset(Offset = "0x14")]
			public DollsInfoDic Dic;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Dict ---
		void Gameplay_Clans_Office_Model_ClassModel__get_Dict
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 *puVar8;
		  
		  if (DAT_ram_00a57fb5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Clans_Office_Model_ClassModel_CreateSubFilters__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Clans_Office_Model_ClassModel___ctor_b__6_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__SpellListArgs___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__ArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__ArtifactData__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__SchoolSpellData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_int__ArtifactData__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_ulong__SpellListArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_DollsInfoDic__SubFilterListElement_SubFilterData___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_DollsInfoDic__UserInfo___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_UserData__ClassModel_DollData___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToArray_SubFilterListElement_SubFilterData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_UserInfo___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToDictionary_ClassModel_DollData__ulong___);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_DollsInfoDic__SubFilterListElement_SubFilterData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_ClassModel_DollData__ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_DollsInfoDic__UserInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_UserData__ClassModel_DollData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Clans_Office_Model_ClassModel___c___ctor_b__6_0__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Clans_Office_Model_ClassModel___c___ctor_b__6_2__)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Model_ClassModel___c_TypeInfo);
		    DAT_ram_00a57fb5 = '\x01';
		  }
		  uVar3 = unnamed_function_1417(System_Collections_Generic_HashSet_uint__TypeInfo);
		  System_Collections_Generic_HashSet_PropertyPath___get_Count
		            (uVar3,Method_System_Collections_Generic_HashSet_uint___ctor__);
		  UnityEngine_TextCore_LowLevel_FontEngine__GetGlyphIndex
		            (uVar3,3,Method_System_Collections_Generic_HashSet_uint__Add__);
		  UnityEngine_TextCore_LowLevel_FontEngine__GetGlyphIndex
		            (uVar3,5,Method_System_Collections_Generic_HashSet_uint__Add__);
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  uVar3 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_ulong__SpellListArgs__TypeInfo);
		  System_Collections_Generic_Dictionary_ulong__ulong___set_Item
		            (uVar3,Method_System_Collections_Generic_Dictionary_ulong__SpellListArgs___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = uVar3;
		  uVar3 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_uint__SchoolSpellData__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar3,Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData___ctor__);
		  *(undefined4 *)(param1 + 0x20) = uVar3;
		  uVar3 = unnamed_function_1417(System_Collections_Generic_Dictionary_int__ArtifactData__TypeInfo);
		  System_Collections_Generic_Dictionary_int__TMP_ResourceManager_FontAssetRef___set_Item
		            (uVar3,Method_System_Collections_Generic_Dictionary_int__ArtifactData___ctor__);
		  *(undefined4 *)(param1 + 0x24) = uVar3;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(int *)(param1 + 0x14) = param3;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x158);
		        goto code_r0x80e8a2cf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80e8a2cf:
		  uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		  uVar3 = Core_Gameplay_Managers_CacheManager__GetEndOfFrameCacheRequestAccumulator(uVar3,0);
		  *(undefined4 *)(param1 + 0xc) = uVar3;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x230);
		        goto code_r0x80e8a384;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e8a384:
		  iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		  *(undefined4 *)(param1 + 0x10) = *(undefined4 *)(*(int *)(iVar6 + 0x10) + 0x20);
		  uVar7 = *(undefined4 *)(*(int *)(param3 + 0x14) + 0x28);
		  uVar3 = unnamed_function_1417
		                    (System_Func_DollsInfoDic__SubFilterListElement_SubFilterData__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar3,param1,Method_Gameplay_Clans_Office_Model_ClassModel_CreateSubFilters__,0);
		  uVar3 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar7,uVar3,
		                     Method_System_Linq_Enumerable_Select_DollsInfoDic__SubFilterListElement_SubFilterData___
		                    );
		  uVar3 = func_ii_6295(uVar3,
		                       Method_System_Linq_Enumerable_ToArray_SubFilterListElement_SubFilterData___);
		  *(undefined4 *)(param1 + 0x28) = uVar3;
		  if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		  }
		  if (DAT_ram_00a5a1ff == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		    DAT_ram_00a5a1ff = '\x01';
		  }
		  if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		  }
		  iVar6 = *(int *)(*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x5c) + 0xc);
		  if (1 < *(int *)(iVar6 + 0xc)) {
		    iVar2 = 1;
		    do {
		      Gameplay_Inventory_View_Info_InfoBox_TitleIconLoaderValueRow__set_Value
		                (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(iVar6 + iVar2 * 4 + 0x10),0,
		                 Method_System_Collections_Generic_Dictionary_int__ArtifactData__set_Item__);
		      iVar2 = iVar2 + 1;
		    } while (iVar2 < *(int *)(iVar6 + 0xc));
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x158);
		        goto code_r0x80e8a51b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80e8a51b:
		  iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		  piVar5 = *(int **)(iVar6 + 0x14);
		  uVar3 = *(undefined4 *)(*(int *)(param3 + 0x14) + 0x28);
		  if (*(int *)(Gameplay_Clans_Office_Model_ClassModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Clans_Office_Model_ClassModel___c_TypeInfo);
		  }
		  puVar8 = *(undefined4 **)(Gameplay_Clans_Office_Model_ClassModel___c_TypeInfo + 0x5c);
		  iVar6 = puVar8[1];
		  if (iVar6 == 0) {
		    if (*(int *)(Gameplay_Clans_Office_Model_ClassModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Clans_Office_Model_ClassModel___c_TypeInfo);
		      puVar8 = *(undefined4 **)(Gameplay_Clans_Office_Model_ClassModel___c_TypeInfo + 0x5c);
		    }
		    uVar7 = *puVar8;
		    iVar6 = unnamed_function_1417(System_Func_DollsInfoDic__UserInfo__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar6,uVar7,Method_Gameplay_Clans_Office_Model_ClassModel___c___ctor_b__6_0__,0);
		    *(int *)(*(int *)(Gameplay_Clans_Office_Model_ClassModel___c_TypeInfo + 0x5c) + 4) = iVar6;
		  }
		  uVar1 = 0;
		  uVar3 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar3,iVar6,Method_System_Linq_Enumerable_Select_DollsInfoDic__UserInfo___);
		  uVar3 = func_ii_6295(uVar3,Method_System_Linq_Enumerable_ToArray_UserInfo___);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Cache_User_IUserInfoWrapper_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8))
		      {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x80e8a648;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Cache_User_IUserInfoWrapper_TypeInfo,1);
		code_r0x80e8a648:
		  uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar3,puVar4[1]);
		  uVar7 = unnamed_function_1417(System_Func_UserData__ClassModel_DollData__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar7,param1,Method_Gameplay_Clans_Office_Model_ClassModel___ctor_b__6_1__,0);
		  uVar3 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar3,uVar7,
		                     Method_System_Linq_Enumerable_Select_UserData__ClassModel_DollData___);
		  if (*(int *)(Gameplay_Clans_Office_Model_ClassModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Clans_Office_Model_ClassModel___c_TypeInfo);
		  }
		  puVar8 = *(undefined4 **)(Gameplay_Clans_Office_Model_ClassModel___c_TypeInfo + 0x5c);
		  iVar6 = puVar8[2];
		  if (iVar6 == 0) {
		    if (*(int *)(Gameplay_Clans_Office_Model_ClassModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Clans_Office_Model_ClassModel___c_TypeInfo);
		      puVar8 = *(undefined4 **)(Gameplay_Clans_Office_Model_ClassModel___c_TypeInfo + 0x5c);
		    }
		    uVar7 = *puVar8;
		    iVar6 = unnamed_function_1417(System_Func_ClassModel_DollData__ulong__TypeInfo);
		    func_ii_7542(iVar6,uVar7,Method_Gameplay_Clans_Office_Model_ClassModel___c___ctor_b__6_2__,0);
		    *(int *)(*(int *)(Gameplay_Clans_Office_Model_ClassModel___c_TypeInfo + 0x5c) + 8) = iVar6;
		  }
		  uVar3 = System_Linq_Enumerable__ToDictionary_object__uint_
		                    (uVar3,iVar6,
		                     Method_System_Linq_Enumerable_ToDictionary_ClassModel_DollData__ulong___);
		  *(undefined4 *)(param1 + 0x2c) = uVar3;
		  return;
		}
		*/


		/* --- GHIDRA: set_DollDataById ---
		int * Gameplay_Clans_Office_Model_ClassModel__set_DollDataById(undefined4 param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57fb6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17769);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2635);
		    DAT_ram_00a57fb6 = '\x01';
		  }
		  piVar1 = (int *)Mono_Security_ASN1Convert__ToOid(UI_Tabs_TabBarItemData___TypeInfo,2);
		  iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2635,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0x14) = 1;
		  *(undefined4 *)(iVar2 + 0x10) = uVar3;
		  iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		  if (iVar4 != 0) {
		    piVar1[4] = iVar2;
		    iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17769,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar2 + 0x14) = 2;
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
