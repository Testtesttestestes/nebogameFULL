using System;
using System.Collections.Generic;
using Core.Data.Skills;
using Il2CppDummyDll;

namespace Core.Data.Effect
{
	// Token: 0x020010E8 RID: 4328
	[Token(Token = "0x20010E8")]
	public abstract class AbstractEffectDescription : IDisposable
	{
		// Token: 0x0600652D RID: 25901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600652D")]
		[Address(RVA = "0xB0FA", Offset = "0xB0FA", VA = "0xB0FA")]
		public void SetEffects(EffectData[] value)
		{
		}

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x0600652E RID: 25902 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600652F RID: 25903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700147C")]
		public string SourceText
		{
			[Token(Token = "0x600652E")]
			[Address(RVA = "0xB0FB", Offset = "0xB0FB", VA = "0xB0FB")]
			get
			{
				return null;
			}
			[Token(Token = "0x600652F")]
			[Address(RVA = "0xB0FC", Offset = "0xB0FC", VA = "0xB0FC")]
			set
			{
			}
		}

		// Token: 0x06006530 RID: 25904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006530")]
		[Address(RVA = "0xB0FD", Offset = "0xB0FD", VA = "0xB0FD", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06006531 RID: 25905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006531")]
		[Address(RVA = "0xB0FE", Offset = "0xB0FE", VA = "0xB0FE")]
		protected AbstractEffectDescription(string sourceText, EffectData[] effects, Skills userSkills)
		{
		}

		// Token: 0x06006532 RID: 25906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006532")]
		[Address(RVA = "0xB0FF", Offset = "0xB0FF", VA = "0xB0FF")]
		public void Reset()
		{
		/* --- GHIDRA: Reset ---
		int Core_Data_Effect_AbstractEffectDescription__Reset(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = param1[2];
		  if (iVar1 == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                      (param1,param1[3],*(undefined4 *)(*param1 + 0xec));
		    param1[2] = iVar1;
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x06006533 RID: 25907 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700147D")]
		public string Text
		{
			[Token(Token = "0x6006533")]
			[Address(RVA = "0xB100", Offset = "0xB100", VA = "0xB100")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006534 RID: 25908 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006534")]
		[Address(RVA = "0xB101", Offset = "0xB101", VA = "0xB101", Slot = "5")]
		protected virtual string GetText(string text)
		{
		/* --- GHIDRA: GetText ---
		void Core_Data_Effect_AbstractEffectDescription__GetText
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  undefined4 uVar1;
		  undefined4 local_4;
		  
		  local_4 = param3;
		  if (DAT_ram_00a6083e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19176);
		    DAT_ram_00a6083e = '\x01';
		  }
		  uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar1,StringLiteral_19176,param4,0);
		  func_ii_2946(param2,uVar1,param5,
		               Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06006535 RID: 25909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006535")]
		[Address(RVA = "0xB102", Offset = "0xB102", VA = "0xB102", Slot = "6")]
		protected virtual void WriteValue(Dictionary<string, string> source, uint effectId, string textVarName, string value)
		{
		}

		// Token: 0x06006536 RID: 25910
		[Token(Token = "0x6006536")]
		protected abstract string FormatUserSkillValue(long validValue, long rawValue);

		// Token: 0x0400361A RID: 13850
		[Token(Token = "0x400361A")]
		public const string CASTER_SKILLS_SCALER_KEY = "caster_skills_scaler_";

		// Token: 0x0400361B RID: 13851
		[Token(Token = "0x400361B")]
		[FieldOffset(Offset = "0x8")]
		private string _text;

		// Token: 0x0400361C RID: 13852
		[Token(Token = "0x400361C")]
		[FieldOffset(Offset = "0xC")]
		private string _sourceText;

		// Token: 0x0400361D RID: 13853
		[Token(Token = "0x400361D")]
		[FieldOffset(Offset = "0x10")]
		private EffectData[] _effects;

		// Token: 0x0400361E RID: 13854
		[Token(Token = "0x400361E")]
		[FieldOffset(Offset = "0x14")]
		private Skills _userSkills;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Text ---
		undefined4
		Core_Data_Effect_AbstractEffectDescription__get_Text
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 in_register_20000004;
		  undefined8 uVar2;
		  double dVar3;
		  undefined4 uVar4;
		  undefined4 in_register_20000014;
		  undefined8 uVar5;
		  uint in_register_20000024;
		  int iVar6;
		  undefined4 param1_00;
		  undefined4 uVar7;
		  int iVar8;
		  float fVar9;
		  undefined4 uVar10;
		  longlong lVar11;
		  double dVar12;
		  int iVar13;
		  int iVar14;
		  uint uVar15;
		  uint uVar16;
		  undefined4 uVar17;
		  undefined4 uVar18;
		  int iVar19;
		  ulonglong uVar20;
		  double dVar21;
		  uint param2_00;
		  uint uVar22;
		  ulonglong uVar23;
		  undefined4 uStack_30;
		  undefined4 local_2c;
		  uint local_28;
		  float8 local_20;
		  undefined8 local_18;
		  undefined4 local_c;
		  float8 local_8;
		  
		  lVar11 = (ulonglong)in_register_20000024 << 0x20;
		  iVar19 = 0;
		  if (DAT_ram_00a6083d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__string__TryGetValue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_EffectSkillsMapping_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Sirenix_Utilities_LinqExtensions_IsNullOrEmpty_EffectData___);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_float__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_long__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_float__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_long__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_UserSkillsIndexes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21065);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a6083d = '\x01';
		  }
		  local_c = 0;
		  local_18 = 0;
		  local_20 = 0.0;
		  iVar6 = Sirenix_Utilities_LinqExtensions__IsNullOrEmpty_object_
		                    (param1[4],Method_Sirenix_Utilities_LinqExtensions_IsNullOrEmpty_EffectData___);
		  if (iVar6 == 0) {
		    param1_00 = unnamed_function_1417
		                          (System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    uVar2 = CONCAT44(in_register_20000004,param1_00);
		    uVar5 = CONCAT44(in_register_20000014,
		                     Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    iVar6 = *(int *)(param1[4] + 0xc);
		    if (0 < iVar6) {
		      do {
		        iVar13 = *(int *)(param1[4] + iVar19 * 4 + 0x10);
		        iVar14 = *(int *)(iVar13 + 0xc);
		        uVar15 = *(uint *)(*(int *)(iVar14 + 0x18) + 0xc);
		        if (0 < (int)uVar15) {
		          do {
		            param2_00 = uVar15 - 1;
		            uVar7 = (undefined4)((ulonglong)uVar2 >> 0x20);
		            uVar22 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                               (*(undefined4 *)(*(int *)(iVar13 + 0xc) + 0x18),param2_00,
		                                Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		            uVar16 = (uVar22 & 0x40000000) << 1 | uVar22 & 0x7fffffff;
		            if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		              func_ii_306000(System_Math_TypeInfo);
		            }
		            uVar20 = (ulonglong)uVar22;
		            uVar22 = (int)uVar16 >> 0x1f;
		            uVar23 = (ulonglong)((uVar16 ^ uVar22) - uVar22);
		            iVar14 = param1[5];
		            if ((iVar14 != 0) &&
		               (uVar22 = *(uint *)(*(int *)(iVar13 + 8) + 0x14), (uVar22 & 5) == 5)) {
		              if (uVar15 == 4) {
		                if ((uVar22 & 0x10) == 0) {
		                  iVar14 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                                     (iVar14,5,
		                                      Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__
		                                     );
		                }
		                else {
		                  iVar14 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                                     (iVar14,6,
		                                      Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__
		                                     );
		                }
		              }
		              else {
		                if ((uVar15 != 5) || ((uVar22 & 0x10) == 0)) goto code_r0x81ced47e;
		                iVar14 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                                   (iVar14,7,
		                                    Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__
		                                   );
		              }
		              uVar23 = *(longlong *)(iVar14 + 0x10) + uVar23;
		            }
		code_r0x81ced47e:
		            uVar17 = *(undefined4 *)(*(int *)(iVar13 + 8) + 0xc);
		            local_2c = 0xffffffff;
		            uStack_30 = Core_Data_Skills_UserSkillsIndexes_TypeInfo;
		            local_28 = param2_00;
		            iVar14 = Spine_SkeletonJson__GetFloat(&uStack_30,0);
		            if (iVar14 == 0) {
		              iVar14 = StringLiteral_5;
		            }
		            uVar2 = CONCAT44(uVar7,param1);
		            uVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		                              (uVar2,uVar23,uVar20,*(undefined4 *)(*param1 + 0xfc));
		            uVar2 = CONCAT44((int)((ulonglong)uVar2 >> 0x20),param1);
		            uVar5 = CONCAT44((int)(uVar23 >> 0x20),param1_00);
		            lVar11 = CONCAT44((int)(uVar20 >> 0x20),uVar17);
		            (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                      (uVar2,uVar5,lVar11,iVar14,uVar7,*(undefined4 *)(*param1 + 0xf4));
		            bVar1 = 1 < uVar15;
		            uVar15 = param2_00;
		          } while (bVar1);
		          iVar14 = *(int *)(iVar13 + 0xc);
		        }
		        uVar15 = *(uint *)(*(int *)(iVar14 + 0x14) + 0xc);
		        if (0 < (int)uVar15) {
		          do {
		            uVar22 = uVar15 - 1;
		            uVar7 = (undefined4)((ulonglong)uVar2 >> 0x20);
		            uVar17 = (undefined4)((ulonglong)uVar5 >> 0x20);
		            uVar10 = (undefined4)((ulonglong)lVar11 >> 0x20);
		            local_18 = func_ii_7271(*(undefined4 *)(*(int *)(iVar13 + 0xc) + 0x14),uVar22,
		                                    Method_Google_Protobuf_Collections_RepeatedField_long__get_Item__
		                                   );
		            iVar14 = UnityEngine_GameObject__SetActive(&local_18,0);
		            if (uVar22 == 1) {
		              lVar11 = func_ii_7271(*(undefined4 *)(*(int *)(iVar13 + 0xc) + 0x14),1,
		                                    Method_Google_Protobuf_Collections_RepeatedField_long__get_Item__
		                                   );
		              if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		                func_ii_306000(System_Math_TypeInfo);
		              }
		              dVar21 = (double)((float)lVar11 / 1000.0);
		              dVar3 = dVar21;
		              dVar12 = unnamed_function_4206(dVar21,&uStack_30);
		              if (0.0 <= (float)lVar11 / 1000.0) {
		                if (dVar12 == 0.5) {
		                  local_20 = (float8)CONCAT44(local_2c,uStack_30);
		                  if (ABS((double)local_20) < 9.223372036854776e+18) {
		                    uVar23 = (ulonglong)(double)local_20;
		                  }
		                  else {
		                    uVar23 = 0;
		                  }
		                  if ((uVar23 & 1) != 0) {
		                    local_20 = (float8)((double)local_20 + 1.0);
		                  }
		                }
		                else {
		                  local_20 = (float8)FLOOR(dVar21 + 0.5);
		                }
		              }
		              else if (dVar12 == -0.5) {
		                local_20 = (float8)CONCAT44(local_2c,uStack_30);
		                if (ABS((double)local_20) < 9.223372036854776e+18) {
		                  uVar23 = (ulonglong)(double)local_20;
		                }
		                else {
		                  uVar23 = 0;
		                }
		                if ((uVar23 & 1) != 0) {
		                  local_20 = (float8)((double)local_20 + -1.0);
		                }
		              }
		              else {
		                local_20 = (float8)CEIL(dVar21 + -0.5);
		              }
		              uVar7 = (undefined4)((ulonglong)dVar3 >> 0x20);
		              iVar14 = func_ii_7515(&local_20,0);
		              if (iVar14 == 0) {
		                iVar14 = StringLiteral_5;
		              }
		            }
		            else if (iVar14 == 0) {
		              iVar14 = StringLiteral_5;
		            }
		            if (*(int *)(Core_Data_Skills_EffectSkillsMapping_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Core_Data_Skills_EffectSkillsMapping_TypeInfo);
		            }
		            if (DAT_ram_00a60873 == '\0') {
		              Mono_Security_ASN1__get_Item(&Core_Data_Skills_EffectSkillsMapping_TypeInfo);
		              DAT_ram_00a60873 = '\x01';
		            }
		            if (*(int *)(Core_Data_Skills_EffectSkillsMapping_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Core_Data_Skills_EffectSkillsMapping_TypeInfo);
		            }
		            uVar2 = CONCAT44(uVar7,**(undefined4 **)
		                                     (Core_Data_Skills_EffectSkillsMapping_TypeInfo + 0x5c));
		            uVar5 = CONCAT44(uVar17,uVar22);
		            lVar11 = CONCAT44(uVar10,&local_c);
		            iVar8 = System_Collections_Generic_List_Enumerator_int___MoveNext
		                              (**(undefined4 **)
		                                 (Core_Data_Skills_EffectSkillsMapping_TypeInfo + 0x5c),uVar22,
		                               &local_c,
		                               Method_System_Collections_Generic_Dictionary_int__string__TryGetValue__
		                              );
		            if (iVar8 != 0) {
		              uVar2 = CONCAT44((int)((ulonglong)uVar2 >> 0x20),param1);
		              uVar5 = CONCAT44((int)((ulonglong)uVar5 >> 0x20),param1_00);
		              lVar11 = CONCAT44((int)((ulonglong)lVar11 >> 0x20),
		                                *(undefined4 *)(*(int *)(iVar13 + 8) + 0xc));
		              (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                        (uVar2,uVar5,lVar11,local_c,iVar14,*(undefined4 *)(*param1 + 0xf4));
		            }
		            bVar1 = 1 < uVar15;
		            uVar15 = uVar22;
		          } while (bVar1);
		          iVar14 = *(int *)(iVar13 + 0xc);
		        }
		        uVar15 = *(uint *)(*(int *)(iVar14 + 0x1c) + 0xc);
		        if (0 < (int)uVar15) {
		          do {
		            uVar22 = uVar15 - 1;
		            uVar7 = (undefined4)((ulonglong)uVar5 >> 0x20);
		            uVar17 = (undefined4)((ulonglong)lVar11 >> 0x20);
		            fVar9 = Google_Protobuf_Collections_RepeatedField_float___get_IsReadOnly
		                              (*(undefined4 *)(*(int *)(iVar13 + 0xc) + 0x1c),uVar22,
		                               Method_Google_Protobuf_Collections_RepeatedField_float__get_Item__);
		            uVar18 = *(undefined4 *)(*(int *)(iVar13 + 8) + 0xc);
		            local_2c = 0xffffffff;
		            uStack_30 = Core_Data_Skills_UserSkillsIndexes_TypeInfo;
		            local_28 = uVar22;
		            uVar10 = Spine_SkeletonJson__GetFloat(&uStack_30,0);
		            uVar10 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_21065,uVar10,0);
		            if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		              func_ii_306000(System_Math_TypeInfo);
		            }
		            dVar21 = (double)(fVar9 * 100.0);
		            dVar3 = dVar21;
		            dVar12 = unnamed_function_4206(dVar21,&local_8);
		            local_20 = local_8;
		            if (0.0 <= fVar9 * 100.0) {
		              if (dVar12 == 0.5) {
		                if (ABS((double)local_8) < 9.223372036854776e+18) {
		                  uVar23 = (ulonglong)(double)local_8;
		                }
		                else {
		                  uVar23 = 0;
		                }
		                if ((uVar23 & 1) != 0) {
		                  local_20 = (float8)((double)local_8 + 1.0);
		                }
		              }
		              else {
		                local_20 = (float8)FLOOR(dVar21 + 0.5);
		              }
		            }
		            else if (dVar12 == -0.5) {
		              if (ABS((double)local_8) < 9.223372036854776e+18) {
		                uVar23 = (ulonglong)(double)local_8;
		              }
		              else {
		                uVar23 = 0;
		              }
		              if ((uVar23 & 1) != 0) {
		                local_20 = (float8)((double)local_8 + -1.0);
		              }
		            }
		            else {
		              local_20 = (float8)CEIL(dVar21 + -0.5);
		            }
		            uVar4 = (undefined4)((ulonglong)dVar3 >> 0x20);
		            iVar14 = func_ii_7515(&local_20,0);
		            if (iVar14 == 0) {
		              iVar14 = StringLiteral_5;
		            }
		            uVar2 = CONCAT44(uVar4,param1);
		            uVar5 = CONCAT44(uVar7,param1_00);
		            lVar11 = CONCAT44(uVar17,uVar18);
		            (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                      (uVar2,uVar5,lVar11,uVar10,iVar14,*(undefined4 *)(*param1 + 0xf4));
		            bVar1 = 1 < uVar15;
		            uVar15 = uVar22;
		          } while (bVar1);
		        }
		        iVar19 = iVar19 + 1;
		      } while (iVar19 != iVar6);
		    }
		    param2 = Core_GameLocalization__GetTranslation(param2,param1_00,0);
		  }
		  return param2;
		}
		*/

}
