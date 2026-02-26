using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

namespace I2.Loc
{
	// Token: 0x020013A3 RID: 5027
	[Token(Token = "0x20013A3")]
	public static class I2Utils
	{
		// Token: 0x060077AC RID: 30636 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077AC")]
		[Address(RVA = "0xC10A", Offset = "0xC10A", VA = "0xC10A")]
		public static string ReverseText(string source)
		{
		/* --- GHIDRA: <ReverseText>g__Reverse|3_0 ---
		void I2_Loc_I2Utils___ReverseText_g__Reverse_3_0(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a54e0f == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_I2Utils___c_TypeInfo);
		    DAT_ram_00a54e0f = '\x01';
		  }
		  uVar1 = unnamed_function_1417(I2_Loc_I2Utils___c_TypeInfo);
		  **(undefined4 **)(I2_Loc_I2Utils___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: ReverseText ---
		undefined4 I2_Loc_I2Utils__ReverseText(int param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  bool bVar2;
		  bool bVar3;
		  uint uVar4;
		  uint uVar5;
		  int *param1_00;
		  uint param1_01;
		  int iVar6;
		  int param2_00;
		  undefined4 uVar7;
		  
		  bVar2 = false;
		  param2_00 = 0;
		  bVar3 = false;
		  if (DAT_ram_00a54e06 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1507);
		    DAT_ram_00a54e06 = '\x01';
		  }
		  if (param1 == 0) {
		    uVar7 = 0;
		  }
		  else {
		    param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		    func_ii_2101(param1_00,0);
		    if (0 < *(int *)(param1 + 8)) {
		      uVar4 = 0;
		      do {
		        param1_01 = func_ii_3010(param1,param2_00,0);
		        bVar1 = (bool)(bVar2 | (param1_01 != 0x7b && (param1_01 != 0x5b && param1_01 != 0x3c)));
		        if (bVar1) {
		          if (bVar2) {
		            if ((((param1_01 == 0x7d) && (uVar5 = 0x7b, (uVar4 & 0xffff) == 0x7b)) ||
		                ((param1_01 == 0x5d && (uVar5 = 0x5b, (uVar4 & 0xffff) == 0x5b)))) ||
		               ((bVar2 = true, param1_01 == 0x3e && (uVar5 = 0x3c, (uVar4 & 0xffff) == 0x3c)))) {
		code_r0x80b1e7bc:
		              bVar2 = (bool)(bVar1 ^ 1);
		              uVar4 = uVar5;
		            }
		          }
		          else {
		code_r0x80b1e6dd:
		            uVar5 = param1_01;
		            if ((param2 == 0) ||
		               ((param1_01 != 0x22 &&
		                ((((((param1_01 == 0x23 || (param1_01 == 0x24)) || (param1_01 == 0x25)) ||
		                   ((param1_01 == 0x26 || (param1_01 == 0x27)))) ||
		                  ((param1_01 == 0x28 || ((param1_01 == 0x29 || (param1_01 == 0x2a)))))) ||
		                 ((param1_01 == 0x2b ||
		                  ((((param1_01 == 0x2c || (param1_01 == 0x2d)) || (param1_01 == 0x2e)) ||
		                   ((param1_01 != 0x2f && (param1_01 != 0x5c)))))))))))) {
		              if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                func_ii_306000(DAT_ram_00a66974);
		              }
		              iVar6 = Sirenix_Serialization_Utilities_TypeExtensions__GetNiceFullName(param1_01,0);
		              if ((iVar6 == 0) &&
		                 (iVar6 = System_Xml_Schema_XmlSchemaException___ctor
		                                    (StringLiteral_1507,param1_01,0), iVar6 < 0)) {
		                uVar5 = 0x20;
		              }
		            }
		            if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		              func_ii_306000(DAT_ram_00a66974);
		            }
		            iVar6 = BestHTTP_PlatformSupport_Memory_BufferPool__Resize(param1_01,0);
		            if (iVar6 == 0) {
		              bVar2 = false;
		              func_ii_3135(param1_00,uVar5,0);
		              bVar3 = false;
		            }
		            else {
		              bVar2 = false;
		              if (bVar3) {
		                bVar3 = true;
		              }
		              else {
		                bVar3 = true;
		                iVar6 = func_ii_4075(param1_00,0);
		                if (0 < iVar6) {
		                  func_ii_3135(param1_00,0x20,0);
		                }
		              }
		            }
		          }
		        }
		        else {
		          if (param1_01 == 0x7b) {
		            uVar5 = 0x7b;
		            if ((*(int *)(param1 + 8) <= param2_00 + 1) ||
		               (iVar6 = func_ii_3010(param1,param2_00 + 1,0), iVar6 == 0x5b)) goto code_r0x80b1e7bc;
		            goto code_r0x80b1e6dd;
		          }
		          bVar2 = (bool)(bVar1 ^ 1);
		          uVar4 = param1_01;
		        }
		        param2_00 = param2_00 + 1;
		      } while (param2_00 < *(int *)(param1 + 8));
		    }
		    uVar7 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                      (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  }
		  return uVar7;
		}
		*/

			return null;
		}

		// Token: 0x060077AD RID: 30637 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077AD")]
		[Address(RVA = "0xC10B", Offset = "0xC10B", VA = "0xC10B")]
		public static string GetValidTermName(string text, bool allowCategory = false)
		{
		/* --- GHIDRA: GetValidTermName ---
		int I2_Loc_I2Utils__GetValidTermName(int param1,int param2,undefined4 param3)
		
		{
		  ushort uVar1;
		  bool bVar2;
		  bool bVar3;
		  int iVar4;
		  int param1_00;
		  int iVar5;
		  undefined4 uVar6;
		  ushort *puVar7;
		  undefined4 *puVar8;
		  int iVar9;
		  uint param1_01;
		  
		  iVar9 = 0;
		  bVar3 = false;
		  if (DAT_ram_00a54e07 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_char___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_char___);
		    Mono_Security_ASN1__get_Item(&System_Func_char__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_I2_Loc_I2Utils___c__SplitLine_b__5_0__);
		    Mono_Security_ASN1__get_Item(&I2_Loc_I2Utils___c_TypeInfo);
		    DAT_ram_00a54e07 = '\x01';
		  }
		  if ((0 < param2) && (param2 <= *(int *)(param1 + 8))) {
		    bVar2 = true;
		    param1_00 = I2_Loc_StringObfucator__XoREncode(param1,0);
		    if (0 < *(int *)(param1_00 + 0xc)) {
		      iVar4 = 0;
		      do {
		        if (bVar2) {
		          bVar2 = true;
		          iVar9 = iVar9 + 1;
		          puVar7 = (ushort *)(param1_00 + iVar4 * 2 + 0x10);
		          param1_01 = (uint)*puVar7;
		          if (param1_01 == 10) {
		            iVar9 = 0;
		          }
		          if (param2 <= iVar9) {
		            if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		              func_ii_306000(DAT_ram_00a66974);
		            }
		            iVar5 = BestHTTP_PlatformSupport_Memory_BufferPool__Resize(param1_01,0);
		            if (iVar5 != 0) {
		              *puVar7 = 10;
		              bVar3 = false;
		              bVar2 = false;
		            }
		          }
		        }
		        else {
		          puVar7 = (ushort *)(param1_00 + iVar4 * 2 + 0x10);
		          uVar1 = *puVar7;
		          if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		            func_ii_306000(DAT_ram_00a66974);
		          }
		          bVar2 = true;
		          iVar5 = BestHTTP_PlatformSupport_Memory_BufferPool__Resize((uint)uVar1,0);
		          if (iVar5 == 0) {
		            iVar9 = 0;
		          }
		          else if (*puVar7 == 10) {
		            bVar2 = false;
		            if (!bVar3) {
		              *puVar7 = 0;
		            }
		            bVar3 = true;
		          }
		          else {
		            bVar2 = false;
		            *puVar7 = 0;
		          }
		        }
		        iVar4 = iVar4 + 1;
		      } while (iVar4 < *(int *)(param1_00 + 0xc));
		    }
		    if (*(int *)(I2_Loc_I2Utils___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_I2Utils___c_TypeInfo);
		    }
		    puVar8 = *(undefined4 **)(I2_Loc_I2Utils___c_TypeInfo + 0x5c);
		    iVar9 = puVar8[1];
		    if (iVar9 == 0) {
		      if (*(int *)(I2_Loc_I2Utils___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(I2_Loc_I2Utils___c_TypeInfo);
		        puVar8 = *(undefined4 **)(I2_Loc_I2Utils___c_TypeInfo + 0x5c);
		      }
		      uVar6 = *puVar8;
		      iVar9 = unnamed_function_1417(System_Func_char__bool__TypeInfo);
		      System_Func_CancellationToken__UniTaskVoid___Invoke
		                (iVar9,uVar6,Method_I2_Loc_I2Utils___c__SplitLine_b__5_0__,0);
		      *(int *)(*(int *)(I2_Loc_I2Utils___c_TypeInfo + 0x5c) + 4) = iVar9;
		    }
		    uVar6 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                      (param1_00,iVar9,Method_System_Linq_Enumerable_Where_char___);
		    uVar6 = System_Linq_Enumerable__ToArray_ValueTuple_int__double__
		                      (uVar6,Method_System_Linq_Enumerable_ToArray_char___);
		    param1 = System_String__ToCharArray(0,uVar6,0);
		  }
		  return param1;
		}
		*/

			return null;
		}

		// Token: 0x060077AE RID: 30638 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077AE")]
		[Address(RVA = "0xC10C", Offset = "0xC10C", VA = "0xC10C")]
		public static string SplitLine(string line, int maxCharacters)
		{
		/* --- GHIDRA: SplitLine ---
		undefined4
		I2_Loc_I2Utils__SplitLine(int param1,int param2,int *param3,int *param4,undefined4 param5)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  int iVar4;
		  
		code_r0x80b1e9f4:
		  *param3 = -1;
		  *param4 = -1;
		  iVar3 = *(int *)(param1 + 8);
		  *param3 = param2;
		  if (param2 < iVar3) {
		    do {
		      iVar4 = func_ii_3010(param1,param2,0);
		      if ((((iVar4 == 0x5b) || (iVar4 = func_ii_3010(param1,*param3,0), iVar4 == 0x28)) ||
		          (iVar4 = func_ii_3010(param1,*param3,0), iVar4 == 0x7b)) ||
		         (iVar4 = func_ii_3010(param1,*param3,0), iVar4 == 0x3c)) break;
		      param2 = *param3 + 1;
		      *param3 = param2;
		    } while (param2 < iVar3);
		    param2 = *param3;
		  }
		  if (param2 != iVar3) {
		    iVar4 = param2 + 1;
		    *param4 = iVar4;
		    bVar1 = false;
		    if (iVar4 < iVar3) {
		      do {
		        uVar2 = func_ii_3010(param1,iVar4,0);
		        if ((int)uVar2 < 0x5d) {
		          if ((uVar2 == 0x29) || (uVar2 == 0x3e)) goto code_r0x80b1eae7;
		        }
		        else if ((uVar2 == 0x7d) || (uVar2 == 0x5d)) goto code_r0x80b1eae7;
		        iVar4 = *param4 + 1;
		        *param4 = iVar4;
		        bVar1 = (bool)(0xff < uVar2 | bVar1);
		        if (iVar3 <= iVar4) {
		          return 0;
		        }
		      } while( true );
		    }
		  }
		  return 0;
		code_r0x80b1eae7:
		  if (!bVar1) {
		    return 1;
		  }
		  param2 = *param4 + 1;
		  goto code_r0x80b1e9f4;
		}
		*/

			return null;
		}

		// Token: 0x060077AF RID: 30639 RVA: 0x00015F78 File Offset: 0x00014178
		[Token(Token = "0x60077AF")]
		[Address(RVA = "0xC10D", Offset = "0xC10D", VA = "0xC10D")]
		public static bool FindNextTag(string line, int iStart, out int tagStart, out int tagEnd)
		{
		/* --- GHIDRA: FindNextTag ---
		undefined4 I2_Loc_I2Utils__FindNextTag(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a54e08 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Text_RegularExpressions_Regex_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19092);
		    DAT_ram_00a54e08 = '\x01';
		  }
		  if (*(int *)(System_Text_RegularExpressions_Regex_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Text_RegularExpressions_Regex_TypeInfo);
		  }
		  uVar1 = System_Text_RegularExpressions_Regex__Matches
		                    (param1,StringLiteral_19092,StringLiteral_5,0);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x060077B0 RID: 30640 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077B0")]
		[Address(RVA = "0xC10E", Offset = "0xC10E", VA = "0xC10E")]
		public static string RemoveTags(string text)
		{
		/* --- GHIDRA: RemoveTags ---
		undefined4 I2_Loc_I2Utils__RemoveTags(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int iVar7;
		  int iVar8;
		  uint uVar9;
		  int iVar10;
		  int iVar11;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a54e09 == '\0') {
		    Mono_Security_ASN1__get_Item(&int___TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IO_Path_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1686);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19003);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19004);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1685);
		    DAT_ram_00a54e09 = '\x01';
		  }
		  iVar3 = System_Xml_XmlTextEncoder__StartAttribute(*param1,StringLiteral_19004,4,0);
		  uVar4 = System_Xml_XmlTextEncoder__StartAttribute(*param1,StringLiteral_19003,4,0);
		  uVar5 = System_Xml_XmlTextEncoder__StartAttribute(*param1,StringLiteral_1686,4,0);
		  uVar6 = System_Xml_XmlTextEncoder__StartAttribute(*param1,StringLiteral_1685,4,0);
		  iVar7 = Mono_Security_ASN1Convert__ToOid(int___TypeInfo,4);
		  *(undefined4 *)(iVar7 + 0x1c) = uVar6;
		  *(undefined4 *)(iVar7 + 0x18) = uVar5;
		  *(undefined4 *)(iVar7 + 0x14) = uVar4;
		  *(int *)(iVar7 + 0x10) = iVar3;
		  iVar8 = *(int *)(iVar7 + 0xc);
		  if (iVar8 == 0) {
		code_r0x80b1ed56:
		    uVar4 = 1;
		    iVar1 = System_String__get_Chars(*param1,iVar1 + 0xb,0);
		  }
		  else {
		    if (1 < iVar8) {
		      uVar9 = iVar8 - 1U & 3;
		      if (iVar8 - 2U < 3) {
		        iVar1 = 1;
		      }
		      else {
		        uVar2 = 0;
		        iVar1 = 1;
		        do {
		          iVar10 = iVar7 + iVar1 * 4;
		          iVar11 = *(int *)(iVar10 + 0x10);
		          if (*(int *)(iVar10 + 0x10) <= iVar3) {
		            iVar11 = iVar3;
		          }
		          iVar3 = *(int *)(iVar10 + 0x14);
		          if (*(int *)(iVar10 + 0x14) <= iVar11) {
		            iVar3 = iVar11;
		          }
		          iVar11 = *(int *)(iVar10 + 0x18);
		          if (*(int *)(iVar10 + 0x18) <= iVar3) {
		            iVar11 = iVar3;
		          }
		          iVar3 = *(int *)(iVar10 + 0x1c);
		          if (*(int *)(iVar10 + 0x1c) <= iVar11) {
		            iVar3 = iVar11;
		          }
		          iVar1 = iVar1 + 4;
		          uVar2 = uVar2 + 4;
		        } while (uVar2 != (iVar8 - 1U & 0xfffffffc));
		      }
		      if (uVar9 != 0) {
		        uVar2 = 0;
		        do {
		          iVar8 = *(int *)(iVar7 + iVar1 * 4 + 0x10);
		          if (iVar8 <= iVar3) {
		            iVar8 = iVar3;
		          }
		          iVar3 = iVar8;
		          iVar1 = iVar1 + 1;
		          uVar2 = uVar2 + 1;
		        } while (uVar2 != uVar9);
		      }
		    }
		    iVar1 = iVar3;
		    if (-1 < iVar3) goto code_r0x80b1ed56;
		    uVar4 = 0;
		    iVar1 = *param1;
		    if (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x74) == 0) {
		      func_ii_306000(I2_Loc_LanguageSourceData_TypeInfo);
		    }
		    iVar3 = System_String__LastIndexOf
		                      (iVar1,*(undefined4 *)
		                              (*(int *)(I2_Loc_LanguageSourceData_TypeInfo + 0x5c) + 4),0);
		    iVar1 = *param1;
		    if (iVar3 < 1) goto code_r0x80b1edc7;
		    iVar1 = System_String__get_Chars(iVar1,iVar3 + 1,0);
		  }
		  *param1 = iVar1;
		code_r0x80b1edc7:
		  if (*(int *)(System_IO_Path_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_IO_Path_TypeInfo);
		  }
		  iVar1 = System_IO_Path__GetDirectoryName(iVar1,0);
		  iVar3 = func_ii_4769(iVar1,0);
		  if (iVar3 == 0) {
		    iVar1 = System_Data_DataSet__ReadXmlSchema
		                      (*param1,0,*(int *)(*param1 + 8) - *(int *)(iVar1 + 8),0);
		    *param1 = iVar1;
		  }
		  return uVar4;
		}
		*/

			return null;
		}

		// Token: 0x060077B1 RID: 30641 RVA: 0x00015F90 File Offset: 0x00014190
		[Token(Token = "0x60077B1")]
		[Address(RVA = "0xC10F", Offset = "0xC10F", VA = "0xC10F")]
		public static bool RemoveResourcesPath(ref string sPath)
		{
		/* --- GHIDRA: RemoveResourcesPath ---
		undefined4 I2_Loc_I2Utils__RemoveResourcesPath(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param3;
		  
		  if (DAT_ram_00a54e0b == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    DAT_ram_00a54e0b = '\x01';
		  }
		  uVar1 = UnityEngine_Transform__set_parent(param1,0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = func_ii_3812(param1,0,0);
		  if (iVar2 != 0) {
		    uVar1 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData(param1,0);
		    return uVar1;
		  }
		  uVar1 = I2_Loc_I2Utils__RemoveResourcesPath(uVar1,param1);
		  param3 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData(param1,0);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar1,StringLiteral_1618,param3,0);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x060077B2 RID: 30642 RVA: 0x00015FA8 File Offset: 0x000141A8
		[Token(Token = "0x60077B2")]
		[Address(RVA = "0x3606", Offset = "0x3606", VA = "0x3606")]
		public static bool IsPlaying()
		{
		/* --- GHIDRA: IsPlaying ---
		void I2_Loc_I2Utils__IsPlaying(int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param2_00;
		  undefined4 uVar3;
		  int local_4;
		  
		  if (DAT_ram_00a604af == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10356);
		    DAT_ram_00a604af = '\x01';
		  }
		  if (*(int *)(param1 + 0x2c) != 0) {
		    iVar1 = 0;
		    iVar2 = I2_Loc_PersistentStorage__HasSetting(0);
		    if ((iVar2 != 0) && (iVar2 = *(int *)(param1 + 0x24), 0 < *(int *)(iVar2 + 0xc))) {
		      do {
		        iVar2 = System_Linq_Enumerable__ToList_object_
		                          (iVar2,iVar1,
		                           Method_System_Collections_Generic_List_LanguageData__get_Item__);
		        iVar2 = func_ii_4769(*(undefined4 *)(iVar2 + 8),0);
		        if (iVar2 == 0) {
		          if (DAT_ram_00a6049f == '\0') {
		            Mono_Security_ASN1__get_Item
		                      (&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		            Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		            DAT_ram_00a6049f = '\x01';
		          }
		          if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		          }
		          if (DAT_ram_00a604e6 == '\0') {
		            Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		            DAT_ram_00a604e6 = '\x01';
		          }
		          if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		          }
		          I2_Loc_LocalizeDropdown___ctor(iVar1);
		          uVar3 = **(undefined4 **)(I2_Loc_LocalizationManager_TypeInfo + 0x5c);
		          iVar2 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(param1 + 0x24),iVar1,
		                             Method_System_Collections_Generic_List_LanguageData__get_Item__);
		          uVar3 = System_Collections_CollectionBase___ctor(uVar3,*(undefined4 *)(iVar2 + 8),0);
		          uVar3 = I2_Loc_LanguageSourceData__AddAsset(param1,iVar1,uVar3,iVar1);
		          iVar2 = func_ii_4769(uVar3,0);
		          if (iVar2 == 0) {
		            param2_00 = I2_Loc_LanguageSourceData__AllowUnloadingLanguages(param1,iVar1,iVar1);
		            I2_Loc_StringObfucator__Encode(2,param2_00,uVar3,1,0);
		          }
		        }
		        else {
		          local_4 = iVar1;
		          uVar3 = func_ii_1081(DAT_ram_00a66954,&local_4);
		          uVar3 = func_ii_4419(StringLiteral_10356,uVar3,0);
		          if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		            func_ii_306000(OKG_Logs_Debug_TypeInfo);
		          }
		          func_ii_7109(uVar3,0);
		        }
		        iVar1 = iVar1 + 1;
		        iVar2 = *(int *)(param1 + 0x24);
		      } while (iVar1 < *(int *)(iVar2 + 0xc));
		      if ((0 < *(int *)(iVar2 + 0xc)) && (param2 != 0)) {
		        iVar1 = 0;
		        do {
		          if (DAT_ram_00a6049f == '\0') {
		            Mono_Security_ASN1__get_Item
		                      (&Method_System_Collections_Generic_List_LanguageData__get_Item__);
		            Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		            DAT_ram_00a6049f = '\x01';
		          }
		          if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		          }
		          if (DAT_ram_00a604e6 == '\0') {
		            Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		            DAT_ram_00a604e6 = '\x01';
		          }
		          if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		            func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		          }
		          I2_Loc_LocalizeDropdown___ctor(iVar1);
		          uVar3 = **(undefined4 **)(I2_Loc_LocalizationManager_TypeInfo + 0x5c);
		          iVar2 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(param1 + 0x24),iVar1,
		                             Method_System_Collections_Generic_List_LanguageData__get_Item__);
		          iVar2 = System_Collections_CollectionBase___ctor(uVar3,*(undefined4 *)(iVar2 + 8),0);
		          if (iVar2 == 0) {
		            I2_Loc_LanguageSourceData__LoadAllLanguages(param1,iVar1,iVar1);
		          }
		          iVar1 = iVar1 + 1;
		        } while (iVar1 < *(int *)(*(int *)(param1 + 0x24) + 0xc));
		      }
		    }
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060077B3 RID: 30643 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077B3")]
		[Address(RVA = "0xC110", Offset = "0xC110", VA = "0xC110")]
		public static string GetPath(this Transform tr)
		{
		/* --- GHIDRA: GetPath ---
		undefined4 I2_Loc_I2Utils__GetPath(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a54e0c == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_SceneManagement_SceneManager_TypeInfo);
		    DAT_ram_00a54e0c = '\x01';
		  }
		  if (*(int *)(UnityEngine_SceneManagement_SceneManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_SceneManagement_SceneManager_TypeInfo);
		  }
		  uVar1 = UnityEngine_SceneManagement_SceneManager__get_sceneCountInBuildSettings(0);
		  uVar1 = I2_Loc_I2Utils__FindObject(uVar1,param1,param1);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060077B4 RID: 30644 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077B4")]
		[Address(RVA = "0xC111", Offset = "0xC111", VA = "0xC111")]
		public static Transform FindObject(string objectPath)
		{
		/* --- GHIDRA: FindObject ---
		undefined4 I2_Loc_I2Utils__FindObject(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  int iVar2;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  param2_00 = System_Text_RegularExpressions_GroupCollection__get_IsReadOnly(uVar1,0);
		  do {
		    iVar2 = *param1;
		    param2_00 = param2_00 + -1;
		    if (param2_00 < 0) goto code_r0x80b1f137;
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		                      (param1,*(undefined4 *)(iVar2 + 0xec));
		    uVar1 = System_Text_RegularExpressions_GroupCollection__System_Collections_IList_RemoveAt
		                      (uVar1,param2_00,0);
		    iVar2 = Unity_Services_Core_Internal_UnityServicesInternal__InitializeAsync(uVar1,0);
		  } while (iVar2 == 0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  param1 = (int *)System_Text_RegularExpressions_GroupCollection__System_Collections_IList_RemoveAt
		                            (uVar1,param2_00,0);
		  iVar2 = *param1;
		code_r0x80b1f137:
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xd8) * 4))
		                    (param1,*(undefined4 *)(iVar2 + 0xdc));
		  return uVar1;
		}
		*/

		/* --- GHIDRA: FindObject ---
		undefined4 I2_Loc_I2Utils__FindObject(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  int iVar2;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  param2_00 = System_Text_RegularExpressions_GroupCollection__get_IsReadOnly(uVar1,0);
		  do {
		    iVar2 = *param1;
		    param2_00 = param2_00 + -1;
		    if (param2_00 < 0) goto code_r0x80b1f137;
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		                      (param1,*(undefined4 *)(iVar2 + 0xec));
		    uVar1 = System_Text_RegularExpressions_GroupCollection__System_Collections_IList_RemoveAt
		                      (uVar1,param2_00,0);
		    iVar2 = Unity_Services_Core_Internal_UnityServicesInternal__InitializeAsync(uVar1,0);
		  } while (iVar2 == 0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  param1 = (int *)System_Text_RegularExpressions_GroupCollection__System_Collections_IList_RemoveAt
		                            (uVar1,param2_00,0);
		  iVar2 = *param1;
		code_r0x80b1f137:
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xd8) * 4))
		                    (param1,*(undefined4 *)(iVar2 + 0xdc));
		  return uVar1;
		}
		*/

		/* --- GHIDRA: FindObject ---
		undefined4 I2_Loc_I2Utils__FindObject(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  int iVar2;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  param2_00 = System_Text_RegularExpressions_GroupCollection__get_IsReadOnly(uVar1,0);
		  do {
		    iVar2 = *param1;
		    param2_00 = param2_00 + -1;
		    if (param2_00 < 0) goto code_r0x80b1f137;
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		                      (param1,*(undefined4 *)(iVar2 + 0xec));
		    uVar1 = System_Text_RegularExpressions_GroupCollection__System_Collections_IList_RemoveAt
		                      (uVar1,param2_00,0);
		    iVar2 = Unity_Services_Core_Internal_UnityServicesInternal__InitializeAsync(uVar1,0);
		  } while (iVar2 == 0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  param1 = (int *)System_Text_RegularExpressions_GroupCollection__System_Collections_IList_RemoveAt
		                            (uVar1,param2_00,0);
		  iVar2 = *param1;
		code_r0x80b1f137:
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xd8) * 4))
		                    (param1,*(undefined4 *)(iVar2 + 0xdc));
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060077B5 RID: 30645 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077B5")]
		[Address(RVA = "0xC112", Offset = "0xC112", VA = "0xC112")]
		public static Transform FindObject(Scene scene, string objectPath)
		{
			return null;
		}

		// Token: 0x060077B6 RID: 30646 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077B6")]
		[Address(RVA = "0xC113", Offset = "0xC113", VA = "0xC113")]
		public static Transform FindObject(Transform root, string objectPath)
		{
			return null;
		}

		// Token: 0x060077B7 RID: 30647 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077B7")]
		public static H FindInParents<H>(Transform tr) where H : Component
		{
			return null;
		}

		// Token: 0x060077B8 RID: 30648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077B8")]
		[Address(RVA = "0xC114", Offset = "0xC114", VA = "0xC114")]
		public static string GetCaptureMatch(Match match)
		{
		/* --- GHIDRA: GetCaptureMatch ---
		void I2_Loc_I2Utils__GetCaptureMatch(undefined4 param1,undefined4 param2)
		
		{
		  Core_Analytics_Okg_OkgAnalytics___c__DisplayClass50_0___DoSendLog_g__CreateWebRequest_0(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060077B9 RID: 30649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077B9")]
		[Address(RVA = "0xC115", Offset = "0xC115", VA = "0xC115")]
		public static void SendWebRequest(UnityWebRequest www)
		{
		/* --- GHIDRA: SendWebRequest ---
		void I2_Loc_I2Utils__SendWebRequest(int param1,int param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (-1 < param2 - param1) {
		    iVar1 = 0;
		    do {
		      iVar3 = *param3;
		      uVar2 = func_ii_3010(param3[1],param1 + iVar1,0);
		      *(short *)(iVar3 + (param2 - iVar1) * 2 + 0x10) = (short)uVar2;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 <= param2 - param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060077BA RID: 30650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077BA")]
		[Address(RVA = "0xC116", Offset = "0xC116", VA = "0xC116")]
		[CompilerGenerated]
		internal static void <ReverseText>g__Reverse|3_0(int start, int end, ref I2Utils.<>c__DisplayClass3_0 A_2)
		{
		}

		// Token: 0x04003E75 RID: 15989
		[Token(Token = "0x4003E75")]
		public const string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";

		// Token: 0x04003E76 RID: 15990
		[Token(Token = "0x4003E76")]
		public const string NumberChars = "0123456789";

		// Token: 0x04003E77 RID: 15991
		[Token(Token = "0x4003E77")]
		public const string ValidNameSymbols = ".-_$#@*()[]{}+:?!&',^=<>~`";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: FindInParents<object> ---
		int I2_Loc_I2Utils__FindInParents_object_(int *param1,int *param2,int param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  int iVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  piVar5 = *(int **)(param3 + 0x1c);
		  if (piVar5 == (int *)0x0) {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    piVar5 = *(int **)(param3 + 0x1c);
		    if (piVar5 == (int *)0x0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param3);
		      piVar5 = *(int **)(param3 + 0x1c);
		    }
		  }
		  iVar6 = *piVar5;
		  if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		    iVar6 = func_ii_1079(iVar6);
		  }
		  iVar9 = *param2;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (iVar6 == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8206b7b1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,iVar6,0);
		code_r0x8206b7b1:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x8206b881;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8206b8cd:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8206bb13:
		      iVar6 = global_1;
		      iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar6 == iVar9) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		        iVar9 = *piVar5;
		        iVar6 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_c = iVar9;
		        import::env::invoke_v(0x123);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 != 1) goto code_r0x8206bb60;
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s___Scripting__UnityEngine__Vector_ram_00003fea + 8,&local_c);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
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
		code_r0x8206b881:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8206b8cd;
		    if (iVar6 == 0) {
		      iVar9 = 0;
		      iVar6 = 0;
		      goto code_r0x8206bb60;
		    }
		    iVar9 = *(int *)(*(int *)(param3 + 0x1c) + 8);
		    if ((*(byte *)(iVar9 + 0xbd) & 1) == 0) {
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_ii(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar9);
		      if (DAT_ram_009d3e38 != 1) goto code_r0x8206b925;
		code_r0x8206bb01:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8206bb13;
		    }
		code_r0x8206b925:
		    iVar8 = *piVar5;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (iVar9 == *piVar7) {
		          puVar3 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x8206b9ab;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,iVar9,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8206bb01;
		code_r0x8206b9ab:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8206bb01;
		    iVar9 = *(int *)(*(int *)(param3 + 0x1c) + 0x14);
		    if ((*(byte *)(iVar9 + 0xbd) & 1) == 0) {
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_ii(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar9);
		      if (DAT_ram_009d3e38 != 1) goto code_r0x8206ba2f;
		code_r0x8206bb0b:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8206bb13;
		    }
		code_r0x8206ba2f:
		    iVar8 = *param1;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar5 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (iVar9 == *piVar5) {
		          puVar3 = (undefined4 *)(piVar5[1] * 8 + iVar8 + 0xe0);
		          goto code_r0x8206bab5;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,param1,iVar9,4);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8206bb0b;
		code_r0x8206bab5:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iiii(*puVar3,param1,uVar4,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8206bb0b;
		  } while (iVar9 == 0);
		  iVar9 = 0;
		code_r0x8206bb60:
		  piVar5 = local_4;
		  DAT_ram_009d3e38 = 0;
		  if (local_4 != (int *)0x0) {
		    uVar1 = 0;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8206bbd8;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x8206bbd8:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  }
		  if (iVar9 == 0) {
		    return iVar6;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
