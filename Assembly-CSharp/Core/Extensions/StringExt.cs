using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Extensions
{
	// Token: 0x02000F0F RID: 3855
	[Token(Token = "0x2000F0F")]
	public static class StringExt
	{
		// Token: 0x06005D37 RID: 23863 RVA: 0x00010CF8 File Offset: 0x0000EEF8
		[Token(Token = "0x6005D37")]
		[Address(RVA = "0x225A", Offset = "0x225A", VA = "0x225A")]
		public static bool IsNullOrEmpty(this string str)
		{
			return default(bool);
		}

		// Token: 0x06005D38 RID: 23864 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D38")]
		[Address(RVA = "0x1B5B", Offset = "0x1B5B", VA = "0x1B5B")]
		public static string Replacer(this string str, Dictionary<string, string> replacements)
		{
		/* --- GHIDRA: Replacer ---
		undefined4 Core_Extensions_StringExt__Replacer(undefined4 param1,double param2,undefined4 param3)
		
		{
		  int iVar1;
		  double dVar2;
		  undefined4 *puVar3;
		  double param1_00;
		  
		  if (DAT_ram_00a5acdc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a5acdc = '\x01';
		  }
		  iVar1 = System_Net_WebConnection__ReadLine(param1,0x2c,0,0);
		  if (1 < *(int *)(iVar1 + 0xc)) {
		    if (0.0 <= param2) {
		      param1_00 = unnamed_function_7668(param2,100.0);
		    }
		    else {
		      param1_00 = param2 - (param2 + param2);
		    }
		    dVar2 = unnamed_function_7668(param1_00,10.0);
		    if (param1_00 <= 20.0) {
		      dVar2 = param1_00;
		    }
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    if (0.2 <= ABS(dVar2 + -1.0)) {
		      if ((4.0 < dVar2) || (dVar2 < 1.0)) {
		        puVar3 = (undefined4 *)(iVar1 + 0x18);
		      }
		      else {
		        puVar3 = (undefined4 *)(iVar1 + 0x14);
		      }
		    }
		    else {
		      puVar3 = (undefined4 *)(iVar1 + 0x10);
		    }
		    param1 = *puVar3;
		  }
		  return param1;
		}
		*/

		/* --- GHIDRA: Replacer ---
		undefined4 Core_Extensions_StringExt__Replacer(undefined4 param1,double param2,undefined4 param3)
		
		{
		  int iVar1;
		  double dVar2;
		  undefined4 *puVar3;
		  double param1_00;
		  
		  if (DAT_ram_00a5acdc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a5acdc = '\x01';
		  }
		  iVar1 = System_Net_WebConnection__ReadLine(param1,0x2c,0,0);
		  if (1 < *(int *)(iVar1 + 0xc)) {
		    if (0.0 <= param2) {
		      param1_00 = unnamed_function_7668(param2,100.0);
		    }
		    else {
		      param1_00 = param2 - (param2 + param2);
		    }
		    dVar2 = unnamed_function_7668(param1_00,10.0);
		    if (param1_00 <= 20.0) {
		      dVar2 = param1_00;
		    }
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    if (0.2 <= ABS(dVar2 + -1.0)) {
		      if ((4.0 < dVar2) || (dVar2 < 1.0)) {
		        puVar3 = (undefined4 *)(iVar1 + 0x18);
		      }
		      else {
		        puVar3 = (undefined4 *)(iVar1 + 0x14);
		      }
		    }
		    else {
		      puVar3 = (undefined4 *)(iVar1 + 0x10);
		    }
		    param1 = *puVar3;
		  }
		  return param1;
		}
		*/

		/* --- GHIDRA: Replacer ---
		undefined4 Core_Extensions_StringExt__Replacer(undefined4 param1,double param2,undefined4 param3)
		
		{
		  int iVar1;
		  double dVar2;
		  undefined4 *puVar3;
		  double param1_00;
		  
		  if (DAT_ram_00a5acdc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a5acdc = '\x01';
		  }
		  iVar1 = System_Net_WebConnection__ReadLine(param1,0x2c,0,0);
		  if (1 < *(int *)(iVar1 + 0xc)) {
		    if (0.0 <= param2) {
		      param1_00 = unnamed_function_7668(param2,100.0);
		    }
		    else {
		      param1_00 = param2 - (param2 + param2);
		    }
		    dVar2 = unnamed_function_7668(param1_00,10.0);
		    if (param1_00 <= 20.0) {
		      dVar2 = param1_00;
		    }
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    if (0.2 <= ABS(dVar2 + -1.0)) {
		      if ((4.0 < dVar2) || (dVar2 < 1.0)) {
		        puVar3 = (undefined4 *)(iVar1 + 0x18);
		      }
		      else {
		        puVar3 = (undefined4 *)(iVar1 + 0x14);
		      }
		    }
		    else {
		      puVar3 = (undefined4 *)(iVar1 + 0x10);
		    }
		    param1 = *puVar3;
		  }
		  return param1;
		}
		*/

			return null;
		}

		// Token: 0x06005D39 RID: 23865 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D39")]
		[Address(RVA = "0x1C79", Offset = "0x1C79", VA = "0x1C79")]
		public static string Replacer(this string str, params KeyValuePair<string, string>[] pairs)
		{
			return null;
		}

		// Token: 0x06005D3A RID: 23866 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D3A")]
		[Address(RVA = "0xA9AF", Offset = "0xA9AF", VA = "0xA9AF")]
		public static string Replacer(this string str, params object[] values)
		{
			return null;
		}

		// Token: 0x06005D3B RID: 23867 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D3B")]
		[Address(RVA = "0xA9B0", Offset = "0xA9B0", VA = "0xA9B0")]
		public static string GetDeclension(this string value, double number)
		{
		/* --- GHIDRA: GetDeclension ---
		void Core_Extensions_StringExt__GetDeclension(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined8 *puVar1;
		  undefined4 uVar2;
		  undefined8 local_44;
		  undefined4 local_3c;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  puVar1 = (undefined8 *)unnamed_function_714(param2,0,0x48);
		  func_ii_7888(&local_c,param1,0);
		  *(undefined4 *)(puVar1 + 1) = local_4;
		  *puVar1 = local_c;
		  UnityEngine_Transform___ctor(&local_18,param1,0);
		  *(undefined4 *)((int)puVar1 + 0x24) = local_10;
		  *(undefined8 *)((int)puVar1 + 0x1c) = local_18;
		  UnityEngine_Transform__get_forward(&local_28,param1,0);
		  *(undefined8 *)((int)puVar1 + 0x14) = local_20;
		  *(undefined8 *)((int)puVar1 + 0xc) = local_28;
		  UnityEngine_Transform__set_rotation(&local_38,param1,0);
		  *(undefined8 *)((int)puVar1 + 0x3c) = local_30;
		  *(undefined8 *)((int)puVar1 + 0x34) = local_38;
		  func_ii_20513(&local_44,param1,0);
		  *(undefined4 *)(puVar1 + 6) = local_3c;
		  puVar1[5] = local_44;
		  uVar2 = UnityEngine_Transform__set_parent(param1,0);
		  *(undefined4 *)((int)puVar1 + 0x44) = uVar2;
		  return;
		}
		*/

			return null;
		}
	}
}
