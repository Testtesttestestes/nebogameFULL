using System;
using System.Runtime.InteropServices;
using Core.Data.Effect;
using Core.Data.Skills;
using Il2CppDummyDll;

namespace Core.Data.Spells
{
	// Token: 0x020010CD RID: 4301
	[Token(Token = "0x20010CD")]
	public abstract class AbstractSpellsBasedDescription : IDisposable
	{
		// Token: 0x060064B9 RID: 25785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064B9")]
		[Address(RVA = "0xB0A1", Offset = "0xB0A1", VA = "0xB0A1", Slot = "5")]
		public virtual void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Data_Spells_AbstractSpellsBasedDescription__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  *(undefined4 *)(param1 + 0x10) = param3;
		  *(undefined4 *)(param1 + 0xc) = param2;
		  return;
		}
		*/

		}

		// Token: 0x060064BA RID: 25786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064BA")]
		[Address(RVA = "0xB0A2", Offset = "0xB0A2", VA = "0xB0A2")]
		protected AbstractSpellsBasedDescription(string sourceText, SpellData[] spells, [Optional] Skills userSkills)
		{
		/* --- GHIDRA: .ctor ---
		int Core_Data_Spells_AbstractSpellsBasedDescription___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = param1[2];
		  if (iVar1 == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                      (param1,param1[3],*(undefined4 *)(*param1 + 0xf4));
		    param1[2] = iVar1;
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x060064BB RID: 25787 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001461")]
		public string Text
		{
			[Token(Token = "0x60064BB")]
			[Address(RVA = "0xB0A3", Offset = "0xB0A3", VA = "0xB0A3")]
			get
			{
				return null;
			}
		}

		// Token: 0x060064BC RID: 25788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064BC")]
		[Address(RVA = "0xB0A4", Offset = "0xB0A4", VA = "0xB0A4")]
		public void Reset()
		{
		/* --- GHIDRA: Reset ---
		int Core_Data_Spells_AbstractSpellsBasedDescription__Reset(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  int param4;
		  undefined4 uVar4;
		  int *piVar5;
		  double dVar6;
		  undefined4 param2_00;
		  int iVar7;
		  float fVar8;
		  int iVar9;
		  int iVar10;
		  longlong lVar11;
		  double param1_01;
		  ulonglong uVar12;
		  int local_40;
		  float8 *local_3c;
		  float8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  float8 local_20;
		  float8 local_18;
		  undefined4 local_10;
		  int iStack_c;
		  undefined4 local_8;
		  undefined4 uStack_4;
		  
		  iVar10 = 0;
		  if (DAT_ram_00a60809 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__string__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__EffectData__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_EffectData___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_int__string__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_int__string__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_int__string__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_int__string__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_int__string__get_Value__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Sirenix_Utilities_LinqExtensions_IsNullOrEmpty_SpellData___);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_SpellSkillsIndexNameMapping_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a60809 = '\x01';
		  }
		  local_8 = 0;
		  uStack_4 = 0;
		  local_10 = 0;
		  iStack_c = 0;
		  local_18 = 0.0;
		  local_20 = 0.0;
		  iVar1 = Sirenix_Utilities_LinqExtensions__IsNullOrEmpty_object_
		                    (*(undefined4 *)(param1 + 0x10),
		                     Method_Sirenix_Utilities_LinqExtensions_IsNullOrEmpty_SpellData___);
		  if (iVar1 == 0) {
		    param1_00 = unnamed_function_1417
		                          (System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    if (*(int *)(Core_Data_Skills_SpellSkillsIndexNameMapping_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Data_Skills_SpellSkillsIndexNameMapping_TypeInfo);
		    }
		    if (DAT_ram_00a60872 == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Data_Skills_SpellSkillsIndexNameMapping_TypeInfo);
		      DAT_ram_00a60872 = '\x01';
		    }
		    if (*(int *)(Core_Data_Skills_SpellSkillsIndexNameMapping_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Data_Skills_SpellSkillsIndexNameMapping_TypeInfo);
		    }
		    iVar1 = *(int *)(*(int *)(param1 + 0x10) + 0xc);
		    if (0 < iVar1) {
		      param2_00 = **(undefined4 **)(Core_Data_Skills_SpellSkillsIndexNameMapping_TypeInfo + 0x5c);
		      do {
		        uVar2 = unnamed_function_1417
		                          (System_Collections_Generic_Dictionary_string__string__TypeInfo);
		        System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		                  (uVar2,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		        iVar7 = *(int *)(*(int *)(param1 + 0x10) + iVar10 * 4 + 0x10);
		        System_Collections_Generic_List_object___GetEnumerator
		                  (&local_38,param2_00,
		                   Method_System_Collections_Generic_Dictionary_int__string__GetEnumerator__);
		        local_8 = (undefined4)local_28;
		        uStack_4 = (undefined4)((ulonglong)local_28 >> 0x20);
		        local_10 = (undefined4)local_30;
		        iStack_c = (int)((ulonglong)local_30 >> 0x20);
		        local_18 = local_38;
		        local_40 = 0;
		        local_3c = &local_18;
		        do {
		          do {
		            DAT_ram_009d3e38 = 0;
		            iVar3 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x20e,&local_18,
		                               Method_System_Collections_Generic_Dictionary_Enumerator_int__string__MoveNext__
		                              );
		            uVar4 = local_8;
		            iVar9 = iStack_c;
		            if (DAT_ram_009d3e38 == 1) goto code_r0x81ceaa64;
		            if (iVar3 == 0) goto code_r0x81ceaac1;
		            DAT_ram_009d3e38 = 0;
		            iVar3 = import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x260,
		                               *(undefined4 *)(iVar7 + 0x18),iStack_c,
		                               Method_System_Collections_Generic_Dictionary_int__Skill__ContainsKey__
		                              );
		            if (DAT_ram_009d3e38 == 1) goto code_r0x81ceaa64;
		          } while (iVar3 == 0);
		          DAT_ram_009d3e38 = 0;
		          iVar3 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x32,
		                             *(undefined4 *)(iVar7 + 0x18),iVar9,
		                             Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          param4 = import::env::invoke_iii
		                             (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26e,
		                              (longlong *)(iVar3 + 0x10),0);
		          if (DAT_ram_009d3e38 == 1) break;
		          if (iVar9 == 8) {
		            lVar11 = *(longlong *)(iVar3 + 0x10);
		            if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                         System_Math_TypeInfo);
		              if (DAT_ram_009d3e38 == 1) break;
		            }
		            DAT_ram_009d3e38 = 0;
		            fVar8 = (float)lVar11 / 1000.0;
		            param1_01 = (double)fVar8;
		            dVar6 = unnamed_function_4206(param1_01,&local_38);
		            local_20 = local_38;
		            if (0.0 <= fVar8) {
		              if (dVar6 == 0.5) {
		                if (ABS((double)local_38) < 9.223372036854776e+18) {
		                  uVar12 = (ulonglong)(double)local_38;
		                }
		                else {
		                  uVar12 = 0;
		                }
		                if ((uVar12 & 1) != 0) {
		                  local_20 = (float8)((double)local_38 + 1.0);
		                }
		              }
		              else {
		                local_20 = (float8)FLOOR(param1_01 + 0.5);
		              }
		            }
		            else if (dVar6 == -0.5) {
		              if (ABS((double)local_38) < 9.223372036854776e+18) {
		                uVar12 = (ulonglong)(double)local_38;
		              }
		              else {
		                uVar12 = 0;
		              }
		              if ((uVar12 & 1) != 0) {
		                local_20 = (float8)((double)local_38 + -1.0);
		              }
		            }
		            else {
		              local_20 = (float8)CEIL(param1_01 + -0.5);
		            }
		            DAT_ram_009d3e38 = 0;
		            param4 = import::env::invoke_iii
		                               (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1d5,&local_20,0)
		            ;
		            if (DAT_ram_009d3e38 == 1) break;
		            if (param4 == 0) {
		              param4 = StringLiteral_5;
		            }
		          }
		          else if (param4 == 0) {
		            param4 = StringLiteral_5;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x84,uVar2,uVar4,param4,
		                     Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		        } while (DAT_ram_009d3e38 != 1);
		code_r0x81ceaa64:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar9 = global_1;
		        iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar9 != iVar3) {
		code_r0x81ceab5e:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s___Scripting__UnityEngine__Playab_ram_000036f4,&local_40);
		          iVar10 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar10 == 1) {
		            import::env::__cxa_find_matching_catch_3(0);
		            unnamed_function_937();
		            do {
		              halt_trap();
		            } while( true );
		          }
		          import::env::__resumeException(uVar4);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		        iVar3 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_40 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_2();
		          goto code_r0x81ceab5e;
		        }
		        if (iVar3 != 0) {
		          System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		          do {
		            halt_trap();
		          } while( true );
		        }
		code_r0x81ceaac1:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = Core_GameLocalization__GetTranslation(param2,uVar2,0);
		        iVar9 = *(int *)(param1 + 0x14);
		        *(undefined4 *)(iVar9 + 0xc) = uVar2;
		        *(undefined4 *)(iVar9 + 8) = 0;
		        uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                          (*(undefined4 *)(iVar7 + 0x14),
		                           Method_System_Collections_Generic_Dictionary_uint__EffectData__get_Values__
		                          );
		        uVar2 = func_ii_6295(uVar2,Method_System_Linq_Enumerable_ToArray_EffectData___);
		        *(undefined4 *)(iVar9 + 0x10) = uVar2;
		        piVar5 = *(int **)(param1 + 0x14);
		        param2 = piVar5[2];
		        if (param2 == 0) {
		          param2 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xe8) * 4))
		                             (piVar5,piVar5[3],*(undefined4 *)(*piVar5 + 0xec));
		          piVar5[2] = param2;
		        }
		        iVar10 = iVar10 + 1;
		      } while (iVar10 != iVar1);
		    }
		    param2 = Core_GameLocalization__GetTranslation(param2,param1_00,0);
		  }
		  return param2;
		}
		*/

		}

		// Token: 0x060064BD RID: 25789 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064BD")]
		[Address(RVA = "0xB0A5", Offset = "0xB0A5", VA = "0xB0A5", Slot = "6")]
		protected virtual string GetText(string text)
		{
		/* --- GHIDRA: GetText ---
		void Core_Data_Spells_AbstractSpellsBasedDescription__GetText
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a6080a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Effect_CombatEffectDescription_TypeInfo);
		    DAT_ram_00a6080a = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x10) = param3;
		  *(undefined4 *)(param1 + 0xc) = param2;
		  iVar1 = unnamed_function_1417(Core_Data_Effect_CombatEffectDescription_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x14) = param4;
		  *(undefined4 *)(iVar1 + 0x10) = 0;
		  *(undefined4 *)(iVar1 + 0xc) = param2;
		  *(int *)(param1 + 0x14) = iVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x040035BF RID: 13759
		[Token(Token = "0x40035BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private string _text;

		// Token: 0x040035C0 RID: 13760
		[Token(Token = "0x40035C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private string _sourceText;

		// Token: 0x040035C1 RID: 13761
		[Token(Token = "0x40035C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private SpellData[] _spells;

		// Token: 0x040035C2 RID: 13762
		[Token(Token = "0x40035C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected AbstractEffectDescription _effectsDescription;
	}
}
