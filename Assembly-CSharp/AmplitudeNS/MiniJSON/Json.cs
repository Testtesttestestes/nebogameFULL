using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace AmplitudeNS.MiniJSON
{
	// Token: 0x020013E5 RID: 5093
	[Token(Token = "0x20013E5")]
	public static class Json
	{
		// Token: 0x06007982 RID: 31106 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007982")]
		[Address(RVA = "0xC261", Offset = "0xC261", VA = "0xC261")]
		public static object Deserialize(string json)
		{
		/* --- GHIDRA: Deserialize ---
		uint AFMiniJSON_Json__Deserialize(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  
		  if (DAT_ram_00a54946 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_28760);
		    DAT_ram_00a54946 = '\x01';
		  }
		  if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a66974);
		  }
		  iVar1 = BestHTTP_PlatformSupport_Memory_BufferPool__Resize(param1,0);
		  if (iVar1 == 0) {
		    iVar1 = System_Xml_Schema_XmlSchemaException___ctor(StringLiteral_28760,param1,0);
		    uVar2 = (uint)(iVar1 != -1);
		  }
		  else {
		    uVar2 = 1;
		  }
		  return uVar2;
		}
		*/

		/* --- GHIDRA: Deserialize ---
		undefined4 IronSourceJSON_Json__Deserialize(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = IronSourceJSON_Json_Serializer___ctor(param1,param1);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: Deserialize ---
		undefined4 Facebook_MiniJSON_Json__Deserialize(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Facebook_MiniJSON_Json_Serializer___ctor(param1,param1);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: Deserialize ---
		undefined4 GAFInternal_Utils_Json__Deserialize(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = GAFInternal_Utils_Json_Serializer___ctor(param1,param1);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: Deserialize ---
		float Spine_Json__Deserialize(float param1,undefined4 param2)
		
		{
		  double dVar1;
		  
		  if (DAT_ram_00a54449 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a54449 = '\x01';
		  }
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  dVar1 = unnamed_function_27131((double)param1);
		  return (float)dVar1;
		}
		*/

		/* --- GHIDRA: Deserialize ---
		undefined4 AmplitudeNS_MiniJSON_Json__Deserialize(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = AmplitudeNS_MiniJSON_Json_Serializer___ctor(param1,param1);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06007983 RID: 31107 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007983")]
		[Address(RVA = "0xC262", Offset = "0xC262", VA = "0xC262")]
		public static string Serialize(object obj)
		{
		/* --- GHIDRA: Serialize ---
		void IronSourceJSON_Json__Serialize(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a506 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IO_StringReader_TypeInfo);
		    DAT_ram_00a5a506 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_IO_StringReader_TypeInfo);
		  UnityEngine_TextAsset__get_text(param1_00,param2,0);
		  *(undefined4 *)(param1 + 8) = param1_00;
		  return;
		}
		*/

		/* --- GHIDRA: Serialize ---
		void Facebook_MiniJSON_Json__Serialize(undefined4 param1)
		
		{
		  int *param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5aea4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Facebook_MiniJSON_Json_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22897);
		    DAT_ram_00a5aea4 = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417(System_Globalization_CultureInfo_TypeInfo);
		  func_ii_3041(param1_00,StringLiteral_22897,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x138) * 4))
		                    (param1_00,*(undefined4 *)(*param1_00 + 0x13c));
		  **(undefined4 **)(Facebook_MiniJSON_Json_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: Serialize ---
		uint GAFInternal_Utils_Json__Serialize(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  
		  if (DAT_ram_00a5157a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_28760);
		    DAT_ram_00a5157a = '\x01';
		  }
		  if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a66974);
		  }
		  iVar1 = BestHTTP_PlatformSupport_Memory_BufferPool__Resize(param1,0);
		  if (iVar1 == 0) {
		    iVar1 = System_Xml_Schema_XmlSchemaException___ctor(StringLiteral_28760,param1,0);
		    uVar2 = (uint)(iVar1 != -1);
		  }
		  else {
		    uVar2 = 1;
		  }
		  return uVar2;
		}
		*/

		/* --- GHIDRA: Serialize ---
		void AmplitudeNS_MiniJSON_Json__Serialize(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a54eae == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IO_StringReader_TypeInfo);
		    DAT_ram_00a54eae = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_IO_StringReader_TypeInfo);
		  UnityEngine_TextAsset__get_text(param1_00,param2,0);
		  *(undefined4 *)(param1 + 8) = param1_00;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x020013E6 RID: 5094
		[Token(Token = "0x20013E6")]
		private sealed class Parser : IDisposable
		{
			// Token: 0x06007984 RID: 31108 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007984")]
			[Address(RVA = "0xC263", Offset = "0xC263", VA = "0xC263")]
			private Parser(string jsonString)
			{
			}

			// Token: 0x06007985 RID: 31109 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6007985")]
			[Address(RVA = "0xC264", Offset = "0xC264", VA = "0xC264")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			// Token: 0x06007986 RID: 31110 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007986")]
			[Address(RVA = "0xC265", Offset = "0xC265", VA = "0xC265", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x06007987 RID: 31111 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6007987")]
			[Address(RVA = "0xC266", Offset = "0xC266", VA = "0xC266")]
			private Dictionary<string, object> ParseObject()
			{
		/* --- GHIDRA: ParseObject ---
		undefined4
		BestHTTP_JSON_Json__ParseObject(undefined4 param1,undefined4 *param2,char *param3,undefined4 param4)
		
		{
		  int param1_00;
		  int iVar1;
		  undefined4 param2_00;
		  uint uVar2;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a61d1f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_object__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_object__TypeInfo);
		    DAT_ram_00a61d1f = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_object__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_object___ctor__);
		  BestHTTP_JSON_Json__LookAhead(param1,param2,auStack_10);
		  do {
		    while( true ) {
		      local_4 = *param2;
		      iVar1 = BestHTTP_JSON_Json__LookAhead(param1,&local_4,auStack_10);
		      if (iVar1 == 0) {
		        *param3 = '\0';
		        return 0;
		      }
		      if (((iVar1 != 1) && (iVar1 != 2)) && (iVar1 != 3)) break;
		code_r0x820276b3:
		      param2_00 = BestHTTP_JSON_Json__ParseArray(param1,param2,param3,auStack_10);
		      iVar1 = Method_System_Collections_Generic_List_object__Add__;
		      if (*param3 == '\0') {
		        return 0;
		      }
		      *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		      uVar2 = *(uint *)(param1_00 + 0xc);
		      if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		        *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		        *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param2_00;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_00,param2_00,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      }
		    }
		    if (iVar1 == 4) {
		      BestHTTP_JSON_Json__LookAhead(param1,param2,auStack_10);
		      return param1_00;
		    }
		    if ((iVar1 == 5) || (iVar1 != 6)) goto code_r0x820276b3;
		    BestHTTP_JSON_Json__LookAhead(param1,param2,auStack_10);
		  } while( true );
		}
		*/

				return null;
			}

			// Token: 0x06007988 RID: 31112 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6007988")]
			[Address(RVA = "0xC267", Offset = "0xC267", VA = "0xC267")]
			private List<object> ParseArray()
			{
		/* --- GHIDRA: ParseArray ---
		undefined4
		BestHTTP_JSON_Json__ParseArray
		          (undefined4 param1,undefined4 *param2,undefined1 *param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined1 auStack_20 [14];
		  undefined1 local_12;
		  undefined1 local_11;
		  float8 local_10;
		  undefined4 local_4;
		  
		  local_4 = *param2;
		  iVar1 = BestHTTP_JSON_Json__LookAhead(param1,&local_4,auStack_20);
		  if (iVar1 == 1) {
		    uVar2 = BestHTTP_JSON_Json__Encode(param1,param2,param3,auStack_20);
		    return uVar2;
		  }
		  if (iVar1 != 2) {
		    if (iVar1 == 3) {
		      uVar2 = BestHTTP_JSON_Json__ParseObject(param1,param2,param3,auStack_20);
		      return uVar2;
		    }
		    if (((iVar1 != 4) && (iVar1 != 5)) && (iVar1 != 6)) {
		      if (iVar1 == 7) {
		        uVar2 = BestHTTP_JSON_Json__ParseValue(param1,param2,param3,auStack_20);
		        return uVar2;
		      }
		      if (iVar1 == 8) {
		        local_10 = (float8)BestHTTP_JSON_Json__ParseString(param1,param2,param3,auStack_20);
		        uVar2 = func_ii_1081(DAT_ram_00a66970,&local_10);
		        return uVar2;
		      }
		      if (iVar1 == 9) {
		        BestHTTP_JSON_Json__LookAhead(param1,param2,auStack_20);
		        local_11 = 1;
		        uVar2 = func_ii_1081(DAT_ram_00a66944,&local_11);
		        return uVar2;
		      }
		      if (iVar1 == 10) {
		        BestHTTP_JSON_Json__LookAhead(param1,param2,auStack_20);
		        local_12 = 0;
		        uVar2 = func_ii_1081(DAT_ram_00a66944,&local_12);
		        return uVar2;
		      }
		      if (iVar1 == 0xb) {
		        BestHTTP_JSON_Json__LookAhead(param1,param2,auStack_20);
		        return 0;
		      }
		    }
		  }
		  *param3 = 0;
		  return 0;
		}
		*/

				return null;
			}

			// Token: 0x06007989 RID: 31113 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6007989")]
			[Address(RVA = "0xC268", Offset = "0xC268", VA = "0xC268")]
			private object ParseValue()
			{
		/* --- GHIDRA: ParseValue ---
		undefined4
		BestHTTP_JSON_Json__ParseValue(int param1,int *param2,undefined1 *param3,undefined4 param4)
		
		{
		  short sVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  int iVar3;
		  uint param2_00;
		  int iVar4;
		  int iVar5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a61d20 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a61d20 = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  func_ii_12828(param1_00,s_var<private>_posTex__array<vec4<_ram_00000655 + 0x17b,0);
		  if (DAT_ram_00a61d23 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_119);
		    DAT_ram_00a61d23 = '\x01';
		  }
		  iVar3 = *param2;
		  iVar4 = *(int *)(param1 + 0xc);
		  if (iVar3 < iVar4) {
		    do {
		      iVar4 = System_Xml_Schema_XmlSchemaException___ctor
		                        (StringLiteral_119,(uint)*(ushort *)(param1 + iVar3 * 2 + 0x10),0);
		      iVar3 = *param2;
		      if (iVar4 == -1) {
		        iVar4 = *(int *)(param1 + 0xc);
		        break;
		      }
		      iVar3 = iVar3 + 1;
		      *param2 = iVar3;
		      iVar4 = *(int *)(param1 + 0xc);
		    } while (iVar3 < iVar4);
		  }
		  iVar3 = iVar3 + 1;
		  *param2 = iVar3;
		  if (iVar3 != iVar4) {
		    do {
		      iVar5 = iVar3 + 1;
		      *param2 = iVar5;
		      param2_00 = (uint)*(ushort *)(param1 + iVar3 * 2 + 0x10);
		      if (param2_00 == 0x5c) {
		        if (iVar4 == iVar5) break;
		        iVar3 = iVar3 + 2;
		        *param2 = iVar3;
		        sVar1 = *(short *)(param1 + iVar5 * 2 + 0x10);
		        if (sVar1 == 0x22) {
		          func_ii_3135(param1_00,0x22,0);
		        }
		        else if (((((sVar1 != 0x23) && (sVar1 != 0x24)) && (sVar1 != 0x25)) &&
		                 ((sVar1 != 0x26 && (sVar1 != 0x27)))) &&
		                (((sVar1 != 0x28 && ((sVar1 != 0x29 && (sVar1 != 0x2a)))) &&
		                 ((sVar1 != 0x2b && (((sVar1 != 0x2c && (sVar1 != 0x2d)) && (sVar1 != 0x2e)))))))) {
		          if (sVar1 == 0x2f) {
		            func_ii_3135(param1_00,0x2f,0);
		          }
		          else if (((((sVar1 != 0x30) && (sVar1 != 0x31)) &&
		                    ((sVar1 != 0x32 && ((sVar1 != 0x33 && (sVar1 != 0x34)))))) &&
		                   ((sVar1 != 0x35 &&
		                    ((((((sVar1 != 0x36 && (sVar1 != 0x37)) && (sVar1 != 0x38)) &&
		                       ((sVar1 != 0x39 && (sVar1 != 0x3a)))) &&
		                      (((sVar1 != 0x3b && ((sVar1 != 0x3c && (sVar1 != 0x3d)))) && (sVar1 != 0x3e)))
		                      ) && ((((((sVar1 != 0x3f && (sVar1 != 0x40)) && (sVar1 != 0x41)) &&
		                              ((sVar1 != 0x42 && (sVar1 != 0x43)))) && (sVar1 != 0x44)) &&
		                            (((sVar1 != 0x45 && (sVar1 != 0x46)) &&
		                             ((sVar1 != 0x47 &&
		                              (((sVar1 != 0x48 && (sVar1 != 0x49)) && (sVar1 != 0x4a))))))))))))))
		                  && (((((sVar1 != 0x4b && (sVar1 != 0x4c)) && (sVar1 != 0x4d)) &&
		                       ((((sVar1 != 0x4e && (sVar1 != 0x4f)) &&
		                         ((sVar1 != 0x50 &&
		                          (((sVar1 != 0x51 && (sVar1 != 0x52)) && (sVar1 != 0x53)))))) &&
		                        ((sVar1 != 0x54 && (sVar1 != 0x55)))))) &&
		                      ((sVar1 != 0x56 &&
		                       (((sVar1 != 0x57 && (sVar1 != 0x58)) &&
		                        ((sVar1 != 0x59 && ((sVar1 != 0x5a && (sVar1 != 0x5b)))))))))))) {
		            if (sVar1 == 0x5c) {
		              func_ii_3135(param1_00,0x5c,0);
		            }
		            else if ((((sVar1 != 0x5d) && (sVar1 != 0x5e)) && (sVar1 != 0x5f)) &&
		                    ((sVar1 != 0x60 && (sVar1 != 0x61)))) {
		              if (sVar1 == 0x62) {
		                func_ii_3135(param1_00,8,0);
		              }
		              else if (((sVar1 != 99) && (sVar1 != 100)) && (sVar1 != 0x65)) {
		                if (sVar1 == 0x66) {
		                  func_ii_3135(param1_00,0xc,0);
		                }
		                else if ((((sVar1 != 0x67) && (sVar1 != 0x68)) && (sVar1 != 0x69)) &&
		                        (((sVar1 != 0x6a && (sVar1 != 0x6b)) && ((sVar1 != 0x6c && (sVar1 != 0x6d)))
		                         ))) {
		                  if (sVar1 == 0x6e) {
		                    func_ii_3135(param1_00,10,0);
		                  }
		                  else if (((sVar1 != 0x6f) && (sVar1 != 0x70)) && (sVar1 != 0x71)) {
		                    if (sVar1 == 0x72) {
		                      func_ii_3135(param1_00,0xd,0);
		                    }
		                    else if (sVar1 != 0x73) {
		                      if (sVar1 == 0x74) {
		                        func_ii_3135(param1_00,9,0);
		                      }
		                      else if (sVar1 == 0x75) {
		                        if (iVar4 - iVar3 < 4) break;
		                        uVar2 = System_String__CreateString(0,param1,iVar3,4,0);
		                        if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		                          func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		                        }
		                        param3_00 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		                        iVar3 = System_UInt32__TryParse(uVar2,0x203,param3_00,&local_4,0);
		                        uVar2 = local_4;
		                        *param3 = (char)iVar3;
		                        if (iVar3 == 0) {
		                          return StringLiteral_5;
		                        }
		                        if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                          func_ii_306000(DAT_ram_00a66974);
		                        }
		                        uVar2 = System_Char__IsLowSurrogate(uVar2,0);
		                        func_ii_2010(param1_00,uVar2,0);
		                        *param2 = *param2 + 4;
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		      else {
		        if (param2_00 == 0x22) {
		          uVar2 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                            (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		          return uVar2;
		        }
		        func_ii_3135(param1_00,param2_00,0);
		      }
		      iVar3 = *param2;
		      iVar4 = *(int *)(param1 + 0xc);
		    } while (iVar3 != iVar4);
		  }
		  *param3 = 0;
		  return 0;
		}
		*/

				return null;
			}

			// Token: 0x0600798A RID: 31114 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600798A")]
			[Address(RVA = "0x1911", Offset = "0x1911", VA = "0x1911")]
			private object ParseByToken(Json.Parser.TOKEN token)
			{
				return null;
			}

			// Token: 0x0600798B RID: 31115 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600798B")]
			[Address(RVA = "0xC269", Offset = "0xC269", VA = "0xC269")]
			private string ParseString()
			{
		/* --- GHIDRA: ParseString ---
		double BestHTTP_JSON_Json__ParseString(int param1,int *param2,undefined1 *param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  int iVar3;
		  float8 local_8;
		  
		  if (DAT_ram_00a61d21 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    DAT_ram_00a61d21 = '\x01';
		  }
		  local_8 = 0.0;
		  if (DAT_ram_00a61d23 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_119);
		    DAT_ram_00a61d23 = '\x01';
		  }
		  iVar3 = *param2;
		  if (iVar3 < *(int *)(param1 + 0xc)) {
		    do {
		      iVar1 = System_Xml_Schema_XmlSchemaException___ctor
		                        (StringLiteral_119,(uint)*(ushort *)(param1 + iVar3 * 2 + 0x10),0);
		      iVar3 = *param2;
		      if (iVar1 == -1) break;
		      iVar3 = iVar3 + 1;
		      *param2 = iVar3;
		    } while (iVar3 < *(int *)(param1 + 0xc));
		  }
		  if (DAT_ram_00a61d22 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_1753);
		    DAT_ram_00a61d22 = '\x01';
		  }
		  if (iVar3 < *(int *)(param1 + 0xc)) {
		    do {
		      iVar1 = System_Xml_Schema_XmlSchemaException___ctor
		                        (StringLiteral_1753,(uint)*(ushort *)(param1 + iVar3 * 2 + 0x10),0);
		      if (iVar1 == -1) break;
		      iVar3 = iVar3 + 1;
		    } while (iVar3 < *(int *)(param1 + 0xc));
		  }
		  uVar2 = System_String__CreateString(0,param1,*param2,iVar3 - *param2,0);
		  if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		  }
		  param3_00 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		  uVar2 = func_ii_6596(uVar2,0x1ff,param3_00,&local_8,0);
		  *param3 = (char)uVar2;
		  *param2 = iVar3;
		  return (double)local_8;
		}
		*/

				return null;
			}

			// Token: 0x0600798C RID: 31116 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600798C")]
			[Address(RVA = "0xC26A", Offset = "0xC26A", VA = "0xC26A")]
			private object ParseNumber()
			{
		/* --- GHIDRA: ParseNumber ---
		int BestHTTP_JSON_Json__ParseNumber(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a61d22 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_1753);
		    DAT_ram_00a61d22 = '\x01';
		  }
		  if (param2 < *(int *)(param1 + 0xc)) {
		    do {
		      iVar1 = System_Xml_Schema_XmlSchemaException___ctor
		                        (StringLiteral_1753,(uint)*(ushort *)(param1 + param2 * 2 + 0x10),0);
		      if (iVar1 == -1) break;
		      param2 = param2 + 1;
		    } while (param2 < *(int *)(param1 + 0xc));
		  }
		  return param2 + -1;
		}
		*/

				return null;
			}

			// Token: 0x0600798D RID: 31117 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600798D")]
			[Address(RVA = "0xC26B", Offset = "0xC26B", VA = "0xC26B")]
			private void EatWhitespace()
			{
		/* --- GHIDRA: EatWhitespace ---
		undefined4 BestHTTP_JSON_Json__EatWhitespace(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  local_4 = param2;
		  uVar1 = BestHTTP_JSON_Json__LookAhead(param1,&local_4,auStack_10);
		  return uVar1;
		}
		*/

			}

			// Token: 0x17001802 RID: 6146
			// (get) Token: 0x0600798E RID: 31118 RVA: 0x000165D8 File Offset: 0x000147D8
			[Token(Token = "0x17001802")]
			private char PeekChar
			{
				[Token(Token = "0x600798E")]
				[Address(RVA = "0xC26C", Offset = "0xC26C", VA = "0xC26C")]
				get
				{
					return '\0';
				}
			}

			// Token: 0x17001803 RID: 6147
			// (get) Token: 0x0600798F RID: 31119 RVA: 0x000165F0 File Offset: 0x000147F0
			[Token(Token = "0x17001803")]
			private char NextChar
			{
				[Token(Token = "0x600798F")]
				[Address(RVA = "0xC26D", Offset = "0xC26D", VA = "0xC26D")]
				get
				{
					return '\0';
				}
			}

			// Token: 0x17001804 RID: 6148
			// (get) Token: 0x06007990 RID: 31120 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001804")]
			private string NextWord
			{
				[Token(Token = "0x6007990")]
				[Address(RVA = "0xC26E", Offset = "0xC26E", VA = "0xC26E")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001805 RID: 6149
			// (get) Token: 0x06007991 RID: 31121 RVA: 0x00016608 File Offset: 0x00014808
			[Token(Token = "0x17001805")]
			private Json.Parser.TOKEN NextToken
			{
				[Token(Token = "0x6007991")]
				[Address(RVA = "0x1910", Offset = "0x1910", VA = "0x1910")]
				get
				{
					return Json.Parser.TOKEN.NONE;
				}
			}

			// Token: 0x04003F5F RID: 16223
			[Token(Token = "0x4003F5F")]
			private const string WHITE_SPACE = " \t\n\r";

			// Token: 0x04003F60 RID: 16224
			[Token(Token = "0x4003F60")]
			private const string WORD_BREAK = " \t\n\r{}[],:\"";

			// Token: 0x04003F61 RID: 16225
			[Token(Token = "0x4003F61")]
			[FieldOffset(Offset = "0x8")]
			private StringReader json;

			// Token: 0x020013E7 RID: 5095
			[Token(Token = "0x20013E7")]
			private enum TOKEN
			{
				// Token: 0x04003F63 RID: 16227
				[Token(Token = "0x4003F63")]
				NONE,
				// Token: 0x04003F64 RID: 16228
				[Token(Token = "0x4003F64")]
				CURLY_OPEN,
				// Token: 0x04003F65 RID: 16229
				[Token(Token = "0x4003F65")]
				CURLY_CLOSE,
				// Token: 0x04003F66 RID: 16230
				[Token(Token = "0x4003F66")]
				SQUARED_OPEN,
				// Token: 0x04003F67 RID: 16231
				[Token(Token = "0x4003F67")]
				SQUARED_CLOSE,
				// Token: 0x04003F68 RID: 16232
				[Token(Token = "0x4003F68")]
				COLON,
				// Token: 0x04003F69 RID: 16233
				[Token(Token = "0x4003F69")]
				COMMA,
				// Token: 0x04003F6A RID: 16234
				[Token(Token = "0x4003F6A")]
				STRING,
				// Token: 0x04003F6B RID: 16235
				[Token(Token = "0x4003F6B")]
				NUMBER,
				// Token: 0x04003F6C RID: 16236
				[Token(Token = "0x4003F6C")]
				TRUE,
				// Token: 0x04003F6D RID: 16237
				[Token(Token = "0x4003F6D")]
				FALSE,
				// Token: 0x04003F6E RID: 16238
				[Token(Token = "0x4003F6E")]
				NULL
			}
		}

		// Token: 0x020013E8 RID: 5096
		[Token(Token = "0x20013E8")]
		private sealed class Serializer
		{
			// Token: 0x06007992 RID: 31122 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007992")]
			[Address(RVA = "0xC26F", Offset = "0xC26F", VA = "0xC26F")]
			private Serializer()
			{
			}

			// Token: 0x06007993 RID: 31123 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6007993")]
			[Address(RVA = "0xC270", Offset = "0xC270", VA = "0xC270")]
			public static string Serialize(object obj)
			{
				return null;
			}

			// Token: 0x06007994 RID: 31124 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007994")]
			[Address(RVA = "0x1913", Offset = "0x1913", VA = "0x1913")]
			private void SerializeValue(object value)
			{
		/* --- GHIDRA: SerializeValue ---
		uint BestHTTP_JSON_Json__SerializeValue(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  uint uVar2;
		  uint *puVar3;
		  int *param1_00;
		  uint uVar4;
		  int *piVar5;
		  undefined4 param1_01;
		  undefined4 param3_00;
		  int iVar6;
		  
		  if (DAT_ram_00a61d25 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_IDictionaryEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IDictionary_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28547);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28773);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1238);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2003);
		    DAT_ram_00a61d25 = '\x01';
		  }
		  func_ii_2010(param2,StringLiteral_28547,0);
		  iVar6 = *param1;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar4 = 0;
		    do {
		      if (System_Collections_IDictionary_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar4 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar4 * 8 + 4) * 8 + iVar6 + 0x108);
		        goto code_r0x82027a1d;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar4);
		  }
		  puVar3 = (uint *)func_ii_1080(param1,System_Collections_IDictionary_TypeInfo,9);
		code_r0x82027a1d:
		  param1_00 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param1,puVar3[1]);
		  bVar1 = true;
		  do {
		    iVar6 = *param1_00;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar4 = 0;
		      do {
		        piVar5 = (int *)(*(int *)(iVar6 + 0x58) + uVar4 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar5) {
		          puVar3 = (uint *)(iVar6 + piVar5[1] * 8 + 0xc0);
		          goto code_r0x82027a9f;
		        }
		        uVar4 = uVar4 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar4);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,System_Collections_IEnumerator_TypeInfo,0);
		code_r0x82027a9f:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    if (uVar4 == 0) {
		      func_ii_2010(param2,StringLiteral_28773,0);
		      break;
		    }
		    iVar6 = *param1_00;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar5 = (int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8);
		        if (System_Collections_IDictionaryEnumerator_TypeInfo == *piVar5) {
		          puVar3 = (uint *)(iVar6 + piVar5[1] * 8 + 0xc0);
		          goto code_r0x82027b1b;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,System_Collections_IDictionaryEnumerator_TypeInfo,0);
		code_r0x82027b1b:
		    piVar5 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    param1_01 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xd8) * 4))
		                          (piVar5,*(undefined4 *)(*piVar5 + 0xdc));
		    iVar6 = *param1_00;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar5 = (int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8);
		        if (System_Collections_IDictionaryEnumerator_TypeInfo == *piVar5) {
		          puVar3 = (uint *)(piVar5[1] * 8 + iVar6 + 200);
		          goto code_r0x82027bab;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,System_Collections_IDictionaryEnumerator_TypeInfo,1);
		code_r0x82027bab:
		    param3_00 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    if (!bVar1) {
		      func_ii_2010(param2,StringLiteral_1238,0);
		    }
		    BestHTTP_JSON_Json__SerializeArray(param1_01,param2,param3_00);
		    bVar1 = false;
		    func_ii_2010(param2,StringLiteral_2003,0);
		    iVar6 = BestHTTP_JSON_Json__NextToken(param3_00,param2,param3_00);
		  } while (iVar6 != 0);
		  return uVar4 ^ 1;
		}
		*/

			}

			// Token: 0x06007995 RID: 31125 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007995")]
			[Address(RVA = "0xC271", Offset = "0xC271", VA = "0xC271")]
			private void SerializeObject(IDictionary obj)
			{
		/* --- GHIDRA: SerializeObject ---
		uint BestHTTP_JSON_Json__SerializeObject(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  uint uVar3;
		  uint *puVar4;
		  int iVar5;
		  undefined4 param1_00;
		  int iVar6;
		  int iVar7;
		  int *piVar8;
		  
		  if (DAT_ram_00a61d26 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_ICollection_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IList_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1238);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18830);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19094);
		    DAT_ram_00a61d26 = '\x01';
		  }
		  func_ii_2010(param2,StringLiteral_18830,0);
		  bVar1 = true;
		  iVar7 = 0;
		  do {
		    iVar2 = iVar7;
		    iVar7 = *param1;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar3 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar3 * 8);
		        if (System_Collections_ICollection_TypeInfo == *piVar8) {
		          puVar4 = (uint *)(piVar8[1] * 8 + iVar7 + 200);
		          goto code_r0x82027ce9;
		        }
		        uVar3 = uVar3 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar3);
		    }
		    puVar4 = (uint *)func_ii_1080(param1,System_Collections_ICollection_TypeInfo,1);
		code_r0x82027ce9:
		    iVar5 = (**(code **)((ulonglong)*puVar4 * 4))(param1,puVar4[1]);
		    if (iVar5 <= iVar2) {
		      func_ii_2010(param2,StringLiteral_19094,0);
		      break;
		    }
		    iVar7 = *param1;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar3 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar3 * 8);
		        if (System_Collections_IList_TypeInfo == *piVar8) {
		          puVar4 = (uint *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x82027d68;
		        }
		        uVar3 = uVar3 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar3);
		    }
		    puVar4 = (uint *)func_ii_1080(param1,System_Collections_IList_TypeInfo,0);
		code_r0x82027d68:
		    param1_00 = (**(code **)((ulonglong)*puVar4 * 4))(param1,iVar2,puVar4[1]);
		    if (!bVar1) {
		      func_ii_2010(param2,StringLiteral_1238,0);
		    }
		    bVar1 = false;
		    iVar6 = BestHTTP_JSON_Json__NextToken(param1_00,param2,iVar2 + 1);
		    iVar7 = iVar2 + 1;
		  } while (iVar6 != 0);
		  return (uint)(iVar5 <= iVar2);
		}
		*/

			}

			// Token: 0x06007996 RID: 31126 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007996")]
			[Address(RVA = "0xC272", Offset = "0xC272", VA = "0xC272")]
			private void SerializeArray(IList anArray)
			{
		/* --- GHIDRA: SerializeArray ---
		undefined4 BestHTTP_JSON_Json__SerializeArray(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  uint param2_00;
		  int iVar3;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a61d27 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Convert_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19010);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19016);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19024);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18992);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19015);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19022);
		    Mono_Security_ASN1__get_Item(&StringLiteral_527);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19025);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19006);
		    DAT_ram_00a61d27 = '\x01';
		  }
		  func_ii_2010(param2,StringLiteral_527,0);
		  iVar1 = I2_Loc_StringObfucator__XoREncode(param1,0);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      param2_00 = (uint)*(ushort *)(iVar1 + iVar3 * 2 + 0x10);
		      if (param2_00 == 8) {
		        func_ii_2010(param2,StringLiteral_19010,0);
		      }
		      else if (param2_00 == 9) {
		        func_ii_2010(param2,StringLiteral_19024,0);
		      }
		      else if (param2_00 == 10) {
		        func_ii_2010(param2,StringLiteral_19016,0);
		      }
		      else {
		        if (param2_00 == 0xb) goto code_r0x82027897;
		        if (param2_00 == 0xc) {
		          func_ii_2010(param2,StringLiteral_19015,0);
		        }
		        else if (param2_00 == 0xd) {
		          func_ii_2010(param2,StringLiteral_19022,0);
		        }
		        else if (((((((param2_00 == 0xe) || (param2_00 == 0xf)) || (param2_00 == 0x10)) ||
		                   ((param2_00 == 0x11 || (param2_00 == 0x12)))) ||
		                  (((param2_00 == 0x13 || ((param2_00 == 0x14 || (param2_00 == 0x15)))) ||
		                   (param2_00 == 0x16)))) ||
		                 ((((param2_00 == 0x17 || (param2_00 == 0x18)) || (param2_00 == 0x19)) ||
		                  (((param2_00 == 0x1a || (param2_00 == 0x1b)) ||
		                   ((param2_00 == 0x1c || ((param2_00 == 0x1d || (param2_00 == 0x1e)))))))))) ||
		                ((param2_00 == 0x1f || ((param2_00 == 0x20 || (param2_00 == 0x21)))))) {
		code_r0x82027897:
		          if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		            func_ii_306000(System_Convert_TypeInfo);
		          }
		          if (param2_00 - 0x7f < 0xffffffa1) {
		            if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		              func_ii_306000(System_Convert_TypeInfo);
		            }
		            uVar2 = System_Convert__ToString(param2_00,0x10,0);
		            uVar2 = System_String__JoinCore(uVar2,4,0x30,0);
		            uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_19025,uVar2,0);
		            func_ii_2010(param2,uVar2,0);
		          }
		          else {
		            func_ii_3135(param2,param2_00,0);
		          }
		        }
		        else if (param2_00 == 0x22) {
		          func_ii_2010(param2,StringLiteral_18992,0);
		        }
		        else {
		          if (param2_00 != 0x5c) goto code_r0x82027897;
		          func_ii_2010(param2,StringLiteral_19006,0);
		        }
		      }
		      iVar3 = iVar3 + 1;
		    } while (iVar3 < *(int *)(iVar1 + 0xc));
		  }
		  func_ii_2010(param2,StringLiteral_527,0);
		  return 1;
		}
		*/

			}

			// Token: 0x06007997 RID: 31127 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007997")]
			[Address(RVA = "0x1915", Offset = "0x1915", VA = "0x1915")]
			private void SerializeString(string str)
			{
		/* --- GHIDRA: SerializeString ---
		undefined4 BestHTTP_JSON_Json__SerializeString(double param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a61d28 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Convert_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    DAT_ram_00a61d28 = '\x01';
		  }
		  if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		  }
		  uVar1 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		  if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Convert_TypeInfo);
		  }
		  uVar1 = System_Convert__ToString(param1,uVar1,0);
		  func_ii_2010(param2,uVar1,0);
		  return 1;
		}
		*/

			}

			// Token: 0x06007998 RID: 31128 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007998")]
			[Address(RVA = "0xC273", Offset = "0xC273", VA = "0xC273")]
			private void SerializeOther(object value)
			{
			}

			// Token: 0x04003F6F RID: 16239
			[Token(Token = "0x4003F6F")]
			[FieldOffset(Offset = "0x8")]
			private StringBuilder builder;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: Decode ---
		undefined4 BestHTTP_JSON_Json__Decode(undefined4 param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a61d1d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    DAT_ram_00a61d1d = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  func_ii_12828(param1_00,s_var<private>_posTex__array<vec4<_ram_00000655 + 0x17b,0);
		  iVar1 = BestHTTP_JSON_Json__NextToken(param1,param1_00,param1_00);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                      (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: Decode ---
		undefined4 BestHTTP_JSON_Json__Decode(undefined4 param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a61d1d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    DAT_ram_00a61d1d = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  func_ii_12828(param1_00,s_var<private>_posTex__array<vec4<_ram_00000655 + 0x17b,0);
		  iVar1 = BestHTTP_JSON_Json__NextToken(param1,param1_00,param1_00);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                      (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: Encode ---
		undefined4
		BestHTTP_JSON_Json__Encode(undefined4 param1,undefined4 *param2,char *param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a61d1e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a61d1e = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  BestHTTP_JSON_Json__LookAhead(param1,param2,param2);
		  while( true ) {
		    local_4 = *param2;
		    iVar1 = BestHTTP_JSON_Json__LookAhead(param1,&local_4,param2);
		    if (iVar1 == 0) break;
		    if (iVar1 == 1) {
		code_r0x82027595:
		      param2_00 = BestHTTP_JSON_Json__ParseValue(param1,param2,param3,param2);
		      if (((*param3 == '\0') ||
		          (iVar1 = BestHTTP_JSON_Json__LookAhead(param1,param2,param2), iVar1 != 5)) ||
		         (param3_00 = BestHTTP_JSON_Json__ParseArray(param1,param2,param3,param2), *param3 == '\0'))
		      break;
		      func_ii_2946(param1_00,param2_00,param3_00,
		                   Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    }
		    else {
		      if (iVar1 == 2) {
		        BestHTTP_JSON_Json__LookAhead(param1,param2,param2);
		        return param1_00;
		      }
		      if ((((iVar1 == 3) || (iVar1 == 4)) || (iVar1 == 5)) || (iVar1 != 6)) goto code_r0x82027595;
		      BestHTTP_JSON_Json__LookAhead(param1,param2,param2);
		    }
		  }
		  *param3 = '\0';
		  return 0;
		}
		*/


		/* --- GHIDRA: GetLastIndexOfNumber ---
		void BestHTTP_JSON_Json__GetLastIndexOfNumber(int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a61d23 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_119);
		    DAT_ram_00a61d23 = '\x01';
		  }
		  iVar1 = *param2;
		  if (iVar1 < *(int *)(param1 + 0xc)) {
		    do {
		      iVar1 = System_Xml_Schema_XmlSchemaException___ctor
		                        (StringLiteral_119,(uint)*(ushort *)(param1 + iVar1 * 2 + 0x10),0);
		      if (iVar1 == -1) {
		        return;
		      }
		      iVar1 = *param2 + 1;
		      *param2 = iVar1;
		    } while (iVar1 < *(int *)(param1 + 0xc));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: LookAhead ---
		/* WARNING: Type propagation algorithm not settling */
		
		undefined4 BestHTTP_JSON_Json__LookAhead(int param1,int *param2,undefined4 param3)
		
		{
		  ushort uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a61d23 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_119);
		    DAT_ram_00a61d23 = '\x01';
		  }
		  iVar2 = *param2;
		  iVar3 = *(int *)(param1 + 0xc);
		  if (iVar2 < iVar3) {
		    do {
		      iVar3 = System_Xml_Schema_XmlSchemaException___ctor
		                        (StringLiteral_119,(uint)*(ushort *)(param1 + iVar2 * 2 + 0x10),0);
		      iVar2 = *param2;
		      if (iVar3 == -1) {
		        iVar3 = *(int *)(param1 + 0xc);
		        break;
		      }
		      iVar2 = iVar2 + 1;
		      *param2 = iVar2;
		      iVar3 = *(int *)(param1 + 0xc);
		    } while (iVar2 < iVar3);
		  }
		  if (iVar2 == iVar3) {
		    return 0;
		  }
		  uVar1 = *(ushort *)(param1 + iVar2 * 2 + 0x10);
		  iVar4 = iVar2 + 1;
		  *param2 = iVar4;
		  if (uVar1 < 0x5c) {
		    if (uVar1 == 0x22) {
		      return 7;
		    }
		    if ((((uVar1 != 0x23) && (uVar1 != 0x24)) && (uVar1 != 0x25)) &&
		       ((((uVar1 != 0x26 && (uVar1 != 0x27)) &&
		         ((uVar1 != 0x28 && ((uVar1 != 0x29 && (uVar1 != 0x2a)))))) && (uVar1 != 0x2b)))) {
		      if (uVar1 == 0x2c) {
		        return 6;
		      }
		      if (uVar1 == 0x2d) {
		        return 8;
		      }
		      if ((uVar1 != 0x2e) && (uVar1 != 0x2f)) {
		        if (uVar1 == 0x30) {
		          return 8;
		        }
		        if (uVar1 == 0x31) {
		          return 8;
		        }
		        if (uVar1 == 0x32) {
		          return 8;
		        }
		        if (uVar1 == 0x33) {
		          return 8;
		        }
		        if (uVar1 == 0x34) {
		          return 8;
		        }
		        if (uVar1 == 0x35) {
		          return 8;
		        }
		        if (uVar1 == 0x36) {
		          return 8;
		        }
		        if (uVar1 == 0x37) {
		          return 8;
		        }
		        if (uVar1 == 0x38) {
		          return 8;
		        }
		        if (uVar1 == 0x39) {
		          return 8;
		        }
		        if (uVar1 == 0x3a) {
		          return 5;
		        }
		        if ((((((((uVar1 != 0x3b) && (uVar1 != 0x3c)) && (uVar1 != 0x3d)) &&
		               (((uVar1 != 0x3e && (uVar1 != 0x3f)) &&
		                ((uVar1 != 0x40 && ((uVar1 != 0x41 && (uVar1 != 0x42)))))))) &&
		              ((uVar1 != 0x43 &&
		               (((((uVar1 != 0x44 && (uVar1 != 0x45)) && (uVar1 != 0x46)) &&
		                 ((uVar1 != 0x47 && (uVar1 != 0x48)))) && (uVar1 != 0x49)))))) &&
		             (((uVar1 != 0x4a && (uVar1 != 0x4b)) &&
		              ((((uVar1 != 0x4c && (((uVar1 != 0x4d && (uVar1 != 0x4e)) && (uVar1 != 0x4f)))) &&
		                (((uVar1 != 0x50 && (uVar1 != 0x51)) && (uVar1 != 0x52)))) &&
		               ((uVar1 != 0x53 && (uVar1 != 0x54)))))))) &&
		            ((uVar1 != 0x55 && (((uVar1 != 0x56 && (uVar1 != 0x57)) && (uVar1 != 0x58)))))) &&
		           (((uVar1 != 0x59 && (uVar1 != 0x5a)) && (uVar1 == 0x5b)))) {
		          return 3;
		        }
		      }
		    }
		  }
		  else {
		    if (uVar1 == 0x7b) {
		      return 1;
		    }
		    if (uVar1 != 0x7c) {
		      if (uVar1 == 0x7d) {
		        return 2;
		      }
		      if (uVar1 == 0x5d) {
		        return 4;
		      }
		    }
		  }
		  *param2 = iVar2;
		  if (iVar3 - iVar2 < 5) {
		    if (iVar3 - iVar2 != 4) {
		      return 0;
		    }
		  }
		  else {
		    if (uVar1 == 0x66) {
		      if (*(short *)(param1 + iVar4 * 2 + 0x10) != 0x61) {
		        return 0;
		      }
		      if (*(short *)(iVar2 * 2 + param1 + 0x14) != 0x6c) {
		        return 0;
		      }
		      iVar3 = iVar2 * 2 + param1;
		      if (*(short *)(iVar3 + 0x16) != 0x73) {
		        return 0;
		      }
		      if (*(short *)(iVar3 + 0x18) != 0x65) {
		        return 0;
		      }
		      *param2 = iVar2 + 5;
		      return 10;
		    }
		    if (uVar1 == 0x67) {
		      return 0;
		    }
		    if (uVar1 == 0x68) {
		      return 0;
		    }
		    if (uVar1 == 0x69) {
		      return 0;
		    }
		    if (uVar1 == 0x6a) {
		      return 0;
		    }
		    if (uVar1 == 0x6b) {
		      return 0;
		    }
		    if (uVar1 == 0x6c) {
		      return 0;
		    }
		    if (uVar1 == 0x6d) {
		      return 0;
		    }
		  }
		  if (uVar1 == 0x6e) {
		    if (*(short *)(param1 + iVar4 * 2 + 0x10) != 0x75) {
		      return 0;
		    }
		    if (*(short *)(iVar2 * 2 + param1 + 0x14) != 0x6c) {
		      return 0;
		    }
		    if (*(short *)(iVar2 * 2 + param1 + 0x16) == 0x6c) {
		      *param2 = iVar2 + 4;
		      return 0xb;
		    }
		  }
		  else if (((uVar1 != 0x6f) && (uVar1 != 0x70)) &&
		          ((uVar1 != 0x71 && (((uVar1 != 0x72 && (uVar1 != 0x73)) && (uVar1 == 0x74)))))) {
		    if (*(short *)(param1 + iVar4 * 2 + 0x10) != 0x72) {
		      return 0;
		    }
		    if (*(short *)(iVar2 * 2 + param1 + 0x14) != 0x75) {
		      return 0;
		    }
		    if (*(short *)(iVar2 * 2 + param1 + 0x16) == 0x65) {
		      *param2 = iVar2 + 4;
		      return 9;
		    }
		  }
		  return 0;
		}
		*/


		/* --- GHIDRA: NextToken ---
		undefined4 BestHTTP_JSON_Json__NextToken(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  char *pcVar4;
		  double param1_00;
		  
		  if (DAT_ram_00a61d24 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Convert_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IDictionary_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IList_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25673);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23131);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27872);
		    DAT_ram_00a61d24 = '\x01';
		  }
		  if ((param1 == (int *)0x0) || (*param1 != DAT_ram_00a66978)) {
		    iVar2 = 0;
		    iVar1 = func_ii_1082(param1,System_Collections_IDictionary_TypeInfo);
		    uVar3 = System_Collections_IDictionary_TypeInfo;
		    if (iVar1 != 0) {
		      if ((param1 != (int *)0x0) &&
		         (iVar2 = func_ii_1082(param1,System_Collections_IDictionary_TypeInfo), iVar2 == 0)) {
		        System_Activator__CreateInstance(param1,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar3 = BestHTTP_JSON_Json__SerializeValue(iVar2,param2,param1);
		      return uVar3;
		    }
		    iVar2 = func_ii_1082(param1,System_Collections_IList_TypeInfo);
		    if (iVar2 != 0) {
		      uVar3 = func_ii_1082(param1,System_Collections_IList_TypeInfo);
		      uVar3 = BestHTTP_JSON_Json__SerializeObject(uVar3,param2,param1);
		      return uVar3;
		    }
		    if (param1 == (int *)0x0) {
		      func_ii_2010(param2,StringLiteral_25673,0);
		    }
		    else {
		      iVar2 = *param1;
		      if (iVar2 == DAT_ram_00a66944) {
		        pcVar4 = (char *)func_ii_15774(param1);
		        if (*pcVar4 != '\0') {
		          func_ii_2010(param2,StringLiteral_27872,0);
		          return 1;
		        }
		        iVar2 = *param1;
		      }
		      if (DAT_ram_00a66944 == iVar2) {
		        pcVar4 = (char *)func_ii_15774(param1);
		        if (*pcVar4 == '\0') {
		          func_ii_2010(param2,StringLiteral_23131,0);
		          return 1;
		        }
		        iVar2 = *param1;
		      }
		      if ((uint)*(byte *)(iVar2 + 0xb8) < (uint)*(byte *)(DAT_ram_00a66a58 + 0xb8)) {
		        return 0;
		      }
		      if (*(int *)(*(int *)(iVar2 + 100) + (uint)*(byte *)(DAT_ram_00a66a58 + 0xb8) * 4 + -4) !=
		          DAT_ram_00a66a58) {
		        return 0;
		      }
		      if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Convert_TypeInfo);
		      }
		      param1_00 = System_Convert__ToSingle(param1,0);
		      BestHTTP_JSON_Json__SerializeString(param1_00,param2,param1);
		    }
		  }
		  else {
		    BestHTTP_JSON_Json__SerializeArray(param1,param2,param1);
		  }
		  return 1;
		}
		*/


		/* --- GHIDRA: .cctor ---
		void Facebook_MiniJSON_Json___cctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5aea5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IO_StringReader_TypeInfo);
		    DAT_ram_00a5aea5 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_IO_StringReader_TypeInfo);
		  UnityEngine_TextAsset__get_text(param1_00,param2,0);
		  *(undefined4 *)(param1 + 8) = param1_00;
		  return;
		}
		*/

}
