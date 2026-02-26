using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Skills;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;

namespace Core.Data
{
	// Token: 0x020010BF RID: 4287
	[Token(Token = "0x20010BF")]
	public class ModifierData
	{
		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x06006411 RID: 25617 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006412 RID: 25618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001421")]
		public ModifierDic ModifierDic
		{
			[Token(Token = "0x6006411")]
			[Address(RVA = "0xB008", Offset = "0xB008", VA = "0xB008")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006412")]
			[Address(RVA = "0xB009", Offset = "0xB009", VA = "0xB009")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x06006413 RID: 25619 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006414 RID: 25620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001422")]
		public SpellModifierInfo ModifierInfo
		{
			[Token(Token = "0x6006413")]
			[Address(RVA = "0xB00A", Offset = "0xB00A", VA = "0xB00A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006414")]
			[Address(RVA = "0xB00B", Offset = "0xB00B", VA = "0xB00B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006415 RID: 25621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006415")]
		[Address(RVA = "0xB00C", Offset = "0xB00C", VA = "0xB00C")]
		public ModifierData(ModifierDic dict, SpellModifierInfo modInfo)
		{
		}

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x06006416 RID: 25622 RVA: 0x00012F00 File Offset: 0x00011100
		[Token(Token = "0x17001423")]
		public uint SpellId
		{
			[Token(Token = "0x6006416")]
			[Address(RVA = "0xB00D", Offset = "0xB00D", VA = "0xB00D")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x06006417 RID: 25623 RVA: 0x00012F18 File Offset: 0x00011118
		[Token(Token = "0x17001424")]
		public uint EffectId
		{
			[Token(Token = "0x6006417")]
			[Address(RVA = "0xB00E", Offset = "0xB00E", VA = "0xB00E")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06006418 RID: 25624 RVA: 0x00012F30 File Offset: 0x00011130
		[Token(Token = "0x6006418")]
		[Address(RVA = "0xB00F", Offset = "0xB00F", VA = "0xB00F")]
		public bool CompareTypeOfSkills(ModifierData mod)
		{
		/* --- GHIDRA: CompareTypeOfSkills ---
		int Core_Data_ModifierData__CompareTypeOfSkills(int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a607d6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_ModifierData_TypeInfo);
		    DAT_ram_00a607d6 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0xc);
		  param2_00 = *(undefined4 *)(param1 + 8);
		  param1_00 = unnamed_function_1417(Core_Data_ModifierData_TypeInfo);
		  Core_Data_ModifierData__set_ModifierInfo(param1_00,param2_00,uVar1,param1);
		  uVar1 = Core_Data_Skills_Skills__AddSkill
		                    (param1,*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param2 + 0x10),param1);
		  *(undefined4 *)(param1_00 + 0x10) = uVar1;
		  uVar1 = Core_Data_Skills_Skills__AddSkill
		                    (param1,*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param2 + 0x14),param1);
		  *(undefined4 *)(param1_00 + 0x14) = uVar1;
		  uVar1 = Core_Data_Skills_Skills__AddSkill
		                    (param1,*(undefined4 *)(param1 + 0x18),*(undefined4 *)(param2 + 0x18),param1);
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  return param1_00;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006419 RID: 25625 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006419")]
		[Address(RVA = "0x36EB", Offset = "0x36EB", VA = "0x36EB")]
		public static List<ModifierData> CalculateSummMods(List<ModifierData> modifiers)
		{
			return null;
		}

		// Token: 0x0600641A RID: 25626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600641A")]
		[Address(RVA = "0x36E2", Offset = "0x36E2", VA = "0x36E2")]
		public static void SummMods(List<ModifierData> source)
		{
		/* --- GHIDRA: SummMods ---
		int * Core_Data_ModifierData__SummMods(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600641B RID: 25627 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600641B")]
		[Address(RVA = "0xB010", Offset = "0xB010", VA = "0xB010")]
		public static ModifierData AddModificator(ModifierData m1, ModifierData m2)
		{
		/* --- GHIDRA: AddModificator ---
		undefined4 Core_Data_ModifierData__AddModificator(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int iVar5;
		  int param1_01;
		  int param3;
		  int iVar6;
		  int iVar7;
		  undefined4 uVar8;
		  undefined4 param1_02;
		  int *piVar9;
		  int iVar10;
		  int iVar11;
		  int param2_00;
		  int iVar12;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a607d7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_ModifierData___Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_ModifierData___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_ModifierData___GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_ModifierData____ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_ModifierData___get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__List_ModifierData___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_uint__List_ModifierData___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_uint__List_ModifierData___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_uint__List_ModifierData___get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_ICollection_SpellModifierInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_SpellModifierInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_uint__List_ModifierData___get_Value__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ModifierData__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ModifierData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ModifierData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ModifierData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_ModifierData_TypeInfo);
		    DAT_ram_00a607d7 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0x178);
		        goto code_r0x81ce5cac;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81ce5cac:
		  uVar1 = 0;
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar9,puVar3[1]);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_ModifierData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_ModifierData___ctor__);
		  iVar10 = unnamed_function_1417
		                     (System_Collections_Generic_Dictionary_uint__List_ModifierData___TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (iVar10,Method_System_Collections_Generic_Dictionary_uint__List_ModifierData____ctor__);
		  iVar5 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_uint__List_ModifierData___TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (iVar5,Method_System_Collections_Generic_Dictionary_uint__List_ModifierData____ctor__);
		  param1_01 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_uint__List_ModifierData___TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (param1_01,
		             Method_System_Collections_Generic_Dictionary_uint__List_ModifierData____ctor__);
		  iVar12 = *param1;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_SpellModifierInfo__TypeInfo ==
		          *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81ce5d94;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1,
		                                System_Collections_Generic_ICollection_SpellModifierInfo__TypeInfo,0
		                               );
		code_r0x81ce5d94:
		  iVar12 = (**(code **)((ulonglong)*puVar3 * 4))(param1,puVar3[1]);
		  if (0 < iVar12) {
		    iVar2 = 0;
		    iVar6 = 0;
		    iVar7 = 0;
		    do {
		      iVar11 = *param1;
		      if (*(ushort *)(iVar11 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IList_SpellModifierInfo__TypeInfo == *piVar9) {
		            puVar3 = (uint *)(iVar11 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x81ce5e27;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(param1,
		                                    System_Collections_Generic_IList_SpellModifierInfo__TypeInfo,0);
		code_r0x81ce5e27:
		      param3 = (**(code **)((ulonglong)*puVar3 * 4))(param1,iVar2,puVar3[1]);
		      param2_00 = *(int *)(param3 + 0x10);
		      iVar11 = iVar10;
		      if (((param2_00 == 0) && (param2_00 = *(int *)(param3 + 0x18), iVar11 = iVar5, param2_00 == 0)
		          ) && (iVar11 = param1_01, param2_00 = *(int *)(param3 + 0x14),
		               *(int *)(param3 + 0x14) == 0)) {
		        iVar11 = iVar6;
		        param2_00 = iVar7;
		      }
		      if (iVar11 != 0) {
		        iVar6 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                          (iVar11,param2_00,
		                           Method_System_Collections_Generic_Dictionary_uint__List_ModifierData___ContainsKey__
		                          );
		        if (iVar6 == 0) {
		          uVar8 = unnamed_function_1417(System_Collections_Generic_List_ModifierData__TypeInfo);
		          GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		                    (uVar8,Method_System_Collections_Generic_List_ModifierData___ctor__);
		          System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		                    (iVar11,param2_00,uVar8,
		                     Method_System_Collections_Generic_Dictionary_uint__List_ModifierData___Add__);
		        }
		        iVar7 = System_Collections_Generic_List_object___get_Item
		                          (iVar11,param2_00,
		                           Method_System_Collections_Generic_Dictionary_uint__List_ModifierData___get_Item__
		                          );
		        uVar8 = Core_Dict_Controller_BaseDictController__LoadDict
		                          (uVar4,*(undefined4 *)(param3 + 0xc),0);
		        param1_02 = unnamed_function_1417(Core_Data_ModifierData_TypeInfo);
		        Core_Data_ModifierData__set_ModifierInfo(param1_02,uVar8,param3,iVar11);
		        iVar6 = Method_System_Collections_Generic_List_ModifierData__Add__;
		        *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		        uVar1 = *(uint *)(iVar7 + 0xc);
		        if (uVar1 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		          *(uint *)(iVar7 + 0xc) = uVar1 + 1;
		          *(undefined4 *)(*(int *)(iVar7 + 8) + uVar1 * 4 + 0x10) = param1_02;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (iVar7,param1_02,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38)
		                    );
		        }
		      }
		      iVar2 = iVar2 + 1;
		      iVar6 = iVar11;
		      iVar7 = param2_00;
		    } while (iVar2 != iVar12);
		  }
		  System_Collections_Generic_List_object___GetEnumerator
		            (&local_30,iVar10,
		             Method_System_Collections_Generic_Dictionary_uint__List_ModifierData___GetEnumerator__)
		  ;
		  local_8 = local_20;
		  local_10 = local_28;
		  local_18 = CONCAT44(puStack_2c,local_30);
		  local_30 = 0;
		  puStack_2c = &local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar12 = import::env::invoke_iii
		                       (s_struct_Uniforms___color__array<v_ram_00000aff + 0x155,&local_18,
		                        Method_System_Collections_Generic_Dictionary_Enumerator_uint__List_ModifierData___MoveNext__
		                       );
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81ce6074;
		    }
		    if (iVar12 == 0) goto code_r0x81ce60ca;
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s___Scripting__UnityEngine__Render_ram_000036af + 0x3c,(undefined4)local_8,
		                       iVar10);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0xf8,param1_00,uVar4,
		               Method_System_Collections_Generic_List_ModifierData__AddRange__);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81ce6074:
		  iVar10 = global_1;
		  iVar12 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar10 == iVar12) {
		    piVar9 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar12 = *piVar9;
		    DAT_ram_009d3e38 = 0;
		    local_30 = iVar12;
		    import::env::invoke_v(0x123);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 != 1) {
		      if (iVar12 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar12);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x81ce60ca:
		      DAT_ram_009d3e38 = 0;
		      System_Collections_Generic_List_object___GetEnumerator
		                (&local_30,iVar5,
		                 Method_System_Collections_Generic_Dictionary_uint__List_ModifierData___GetEnumerator__
		                );
		      local_8 = local_20;
		      local_10 = local_28;
		      local_18 = CONCAT44(puStack_2c,local_30);
		      local_30 = 0;
		      puStack_2c = &local_18;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar5 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x155,&local_18,
		                           Method_System_Collections_Generic_Dictionary_Enumerator_uint__List_ModifierData___MoveNext__
		                          );
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81ce621f;
		        }
		        if (iVar5 == 0) goto code_r0x81ce6275;
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::invoke_iii
		                          (s___Scripting__UnityEngine__Render_ram_000036af + 0x3c,
		                           (undefined4)local_8,iVar10);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0xf8,param1_00,uVar4,
		                   Method_System_Collections_Generic_List_ModifierData__AddRange__);
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81ce621f:
		      iVar10 = global_1;
		      iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar10 == iVar5) {
		        piVar9 = (int *)import::env::__cxa_begin_catch(uVar4);
		        iVar5 = *piVar9;
		        DAT_ram_009d3e38 = 0;
		        local_30 = iVar5;
		        import::env::invoke_v(0x123);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 != 1) {
		          if (iVar5 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x81ce6275:
		          DAT_ram_009d3e38 = 0;
		          System_Collections_Generic_List_object___GetEnumerator
		                    (&local_30,param1_01,
		                     Method_System_Collections_Generic_Dictionary_uint__List_ModifierData___GetEnumerator__
		                    );
		          local_8 = local_20;
		          local_10 = local_28;
		          local_18 = CONCAT44(puStack_2c,local_30);
		          local_30 = 0;
		          puStack_2c = &local_18;
		          do {
		            DAT_ram_009d3e38 = 0;
		            iVar5 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x155,&local_18,
		                               Method_System_Collections_Generic_Dictionary_Enumerator_uint__List_ModifierData___MoveNext__
		                              );
		            iVar10 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar10 == 1) {
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x81ce63c2;
		            }
		            if (iVar5 == 0) {
		              DAT_ram_009d3e38 = 0;
		              return param1_00;
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar4 = import::env::invoke_iii
		                              (s___Scripting__UnityEngine__Render_ram_000036af + 0x3c,
		                               (undefined4)local_8,iVar10);
		            if (DAT_ram_009d3e38 == 1) break;
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0xf8,param1_00,uVar4,
		                       Method_System_Collections_Generic_List_ModifierData__AddRange__);
		          } while (DAT_ram_009d3e38 != 1);
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81ce63c2:
		          iVar10 = global_1;
		          iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar10 == iVar5) {
		            piVar9 = (int *)import::env::__cxa_begin_catch(uVar4);
		            iVar5 = *piVar9;
		            DAT_ram_009d3e38 = 0;
		            local_30 = iVar5;
		            import::env::invoke_v(0x123);
		            iVar10 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar10 != 1) {
		              if (iVar5 == 0) {
		                DAT_ram_009d3e38 = 0;
		                return param1_00;
		              }
		              System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		              do {
		                halt_trap();
		              } while( true );
		            }
		            uVar4 = import::env::__cxa_find_matching_catch_2();
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s___Scripting__UnityEngine__Render_ram_000036af + 0x3f,&local_30);
		          goto joined_r0x81ce6450;
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s___Scripting__UnityEngine__Render_ram_000036af + 0x3e,&local_30);
		      goto joined_r0x81ce6450;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Render_ram_000036af + 0x3d,&local_30);
		joined_r0x81ce6450:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x0600641C RID: 25628 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600641C")]
		[Address(RVA = "0xB011", Offset = "0xB011", VA = "0xB011")]
		public static List<ModifierData> ParseModifiers(IList<SpellModifierInfo> modifiers)
		{
		/* --- GHIDRA: ParseModifiers ---
		undefined4 Core_Data_ModifierData__ParseModifiers(ulonglong param1,undefined4 param2)
		
		{
		  return (int)((param1 & 0x80000000) >> 0x1f);
		}
		*/

			return null;
		}

		// Token: 0x0600641D RID: 25629 RVA: 0x00012F48 File Offset: 0x00011148
		[Token(Token = "0x600641D")]
		[Address(RVA = "0xB012", Offset = "0xB012", VA = "0xB012")]
		public static bool IsProcent(long value)
		{
		/* --- GHIDRA: IsProcent ---
		longlong Core_Data_ModifierData__IsProcent(undefined8 param1,undefined4 param2)
		
		{
		  return (longlong)(int)(((uint)param1 & 0x40000000) << 1 | (uint)param1 & 0x7fffffff);
		}
		*/

			return default(bool);
		}

		// Token: 0x0600641E RID: 25630 RVA: 0x00012F60 File Offset: 0x00011160
		[Token(Token = "0x600641E")]
		[Address(RVA = "0xB013", Offset = "0xB013", VA = "0xB013")]
		public static long ConvertModificatorValueToValue(long value)
		{
		/* --- GHIDRA: ConvertModificatorValueToValue ---
		ulonglong Core_Data_ModifierData__ConvertModificatorValueToValue
		                    (undefined8 param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a607d8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Convert_TypeInfo);
		    DAT_ram_00a607d8 = '\x01';
		  }
		  if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Convert_TypeInfo);
		  }
		  return (ulonglong)((uint)param1 & 0x7fffffff | param2 << 0x1f);
		}
		*/

			return 0L;
		}

		// Token: 0x0600641F RID: 25631 RVA: 0x00012F78 File Offset: 0x00011178
		[Token(Token = "0x600641F")]
		[Address(RVA = "0xB014", Offset = "0xB014", VA = "0xB014")]
		public static long ConvertValueToModificatorValue(long value, bool isProcent)
		{
		/* --- GHIDRA: ConvertValueToModificatorValue ---
		void Core_Data_ModifierData__ConvertValueToModificatorValue(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a607da == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_ModifierData___c_TypeInfo);
		    DAT_ram_00a607da = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Data_ModifierData___c_TypeInfo);
		  **(undefined4 **)(Core_Data_ModifierData___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return 0L;
		}

		// Token: 0x06006420 RID: 25632 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006420")]
		[Address(RVA = "0x2162", Offset = "0x2162", VA = "0x2162")]
		public static string FormatValue(long value)
		{
		/* --- GHIDRA: FormatValue ---
		int * Core_Data_ModifierData__FormatValue(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x0400357F RID: 13695
		[Token(Token = "0x400357F")]
		[FieldOffset(Offset = "0x10")]
		public Skills UserSkills;

		// Token: 0x04003580 RID: 13696
		[Token(Token = "0x4003580")]
		[FieldOffset(Offset = "0x14")]
		public Skills ArtifactSkills;

		// Token: 0x04003581 RID: 13697
		[Token(Token = "0x4003581")]
		[FieldOffset(Offset = "0x18")]
		public Skills SpellSkills;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_ModifierInfo ---
		void Core_Data_ModifierData__set_ModifierInfo
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a607d2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_uint__long___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_long___);
		    Mono_Security_ASN1__get_Item(&System_Func_uint__long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_ModifierData___c___ctor_b__11_0__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_ModifierData___c___ctor_b__11_1__);
		    Mono_Security_ASN1__get_Item(&Core_Data_ModifierData___c_TypeInfo);
		    DAT_ram_00a607d2 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0xc) = param3;
		  *(int *)(param1 + 8) = param2;
		  uVar1 = *(undefined4 *)(param2 + 0x18);
		  if (*(int *)(Core_Data_ModifierData___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Data_ModifierData___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Data_ModifierData___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[1];
		  if (iVar3 == 0) {
		    if (*(int *)(Core_Data_ModifierData___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Data_ModifierData___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Data_ModifierData___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Func_uint__long__TypeInfo);
		    System_Func_uint__Int32Enum___Invoke
		              (iVar3,uVar4,Method_Core_Data_ModifierData___c___ctor_b__11_0__,0);
		    *(int *)(*(int *)(Core_Data_ModifierData___c_TypeInfo + 0x5c) + 4) = iVar3;
		  }
		  uVar1 = System_Linq_Enumerable__Select_uint__Int32Enum_
		                    (uVar1,iVar3,Method_System_Linq_Enumerable_Select_uint__long___);
		  uVar1 = System_Linq_Enumerable__ToList_int_(uVar1,Method_System_Linq_Enumerable_ToList_long___);
		  uVar1 = Core_Data_Skills_Skills__AddMods(uVar1,param1);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  uVar1 = System_Linq_Enumerable__ToList_int_
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 0x20),
		                     Method_System_Linq_Enumerable_ToList_long___);
		  uVar1 = Core_Data_Skills_Skills__AddMods(uVar1,param1);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar1 = *(undefined4 *)(*(int *)(param1 + 8) + 0x1c);
		  if (*(int *)(Core_Data_ModifierData___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Data_ModifierData___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Data_ModifierData___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[2];
		  if (iVar3 == 0) {
		    if (*(int *)(Core_Data_ModifierData___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Data_ModifierData___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Data_ModifierData___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Func_uint__long__TypeInfo);
		    System_Func_uint__Int32Enum___Invoke
		              (iVar3,uVar4,Method_Core_Data_ModifierData___c___ctor_b__11_1__,0);
		    *(int *)(*(int *)(Core_Data_ModifierData___c_TypeInfo + 0x5c) + 8) = iVar3;
		  }
		  uVar1 = System_Linq_Enumerable__Select_uint__Int32Enum_
		                    (uVar1,iVar3,Method_System_Linq_Enumerable_Select_uint__long___);
		  uVar1 = System_Linq_Enumerable__ToList_int_(uVar1,Method_System_Linq_Enumerable_ToList_long___);
		  uVar1 = Core_Data_Skills_Skills__AddMods(uVar1,param1);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/


		/* --- GHIDRA: get_EffectId ---
		uint Core_Data_ModifierData__get_EffectId(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint uVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  int param2_00;
		  ulonglong uVar6;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a607d3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Count_KeyValuePair_int__Skill____);
		    DAT_ram_00a607d3 = '\x01';
		  }
		  uVar2 = 1;
		  iVar3 = System_Linq_Enumerable__Count_KeyValuePair_int__int__
		                    (*(undefined4 *)(param1 + 0x10),
		                     Method_System_Linq_Enumerable_Count_KeyValuePair_int__Skill____);
		  uVar1 = uVar2;
		  if (0 < iVar3) {
		    do {
		      uVar2 = 0;
		      if (uVar1 != 0) {
		        iVar4 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                          (*(undefined4 *)(param1 + 0x10),param2_00,
		                           Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		        iVar5 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                          (*(undefined4 *)(param2 + 0x10),param2_00,
		                           Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		        uVar6 = *(ulonglong *)(iVar5 + 0x10) & 0x80000000;
		        uVar2 = (uint)(uVar6 >> 0x1f);
		        if ((*(byte *)(iVar4 + 0x13) & 0x80) == 0) {
		          uVar2 = (uint)(uVar6 == 0);
		        }
		      }
		      param2_00 = param2_00 + 1;
		      uVar1 = uVar2;
		    } while (param2_00 != iVar3);
		  }
		  return uVar2;
		}
		*/

}
