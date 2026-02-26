using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
public class Amplitude
{
	// Token: 0x06000005 RID: 5 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x54D3", Offset = "0x54D3", VA = "0x54D3")]
	public static Amplitude getInstance()
	{
		/* --- GHIDRA: getInstance ---
		undefined4 Amplitude__getInstance(undefined4 param1)
		
		{
		  int param2;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a647df == '\0') {
		    Mono_Security_ASN1__get_Item(&Amplitude_TypeInfo);
		    DAT_ram_00a647df = '\x01';
		  }
		  if (*(int *)(Amplitude_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Amplitude_TypeInfo);
		  }
		  if (DAT_ram_00a647dd == '\0') {
		    Mono_Security_ASN1__get_Item(&Amplitude_TypeInfo);
		    DAT_ram_00a647dd = '\x01';
		  }
		  param2 = Amplitude_TypeInfo;
		  if (*(int *)(Amplitude_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Amplitude_TypeInfo);
		  }
		  uVar1 = Amplitude__getInstance(0,param2);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: getInstance ---
		undefined4 Amplitude__getInstance(undefined4 param1)
		
		{
		  int param2;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a647df == '\0') {
		    Mono_Security_ASN1__get_Item(&Amplitude_TypeInfo);
		    DAT_ram_00a647df = '\x01';
		  }
		  if (*(int *)(Amplitude_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Amplitude_TypeInfo);
		  }
		  if (DAT_ram_00a647dd == '\0') {
		    Mono_Security_ASN1__get_Item(&Amplitude_TypeInfo);
		    DAT_ram_00a647dd = '\x01';
		  }
		  param2 = Amplitude_TypeInfo;
		  if (*(int *)(Amplitude_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Amplitude_TypeInfo);
		  }
		  uVar1 = Amplitude__getInstance(0,param2);
		  return uVar1;
		}
		*/

		return null;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x54D4", Offset = "0x54D4", VA = "0x54D4")]
	public static Amplitude getInstance(string instanceName)
	{
		return null;
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000007 RID: 7 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000001")]
	public static Amplitude Instance
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x54D5", Offset = "0x54D5", VA = "0x54D5")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x4BAE", Offset = "0x4BAE", VA = "0x4BAE")]
	public Amplitude(string instanceName)
	{
		/* --- GHIDRA: .cctor ---
		void Amplitude___cctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a64861 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a64861 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x10,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x54D6", Offset = "0x54D6", VA = "0x54D6")]
	protected void Log(string message)
	{
		/* --- GHIDRA: Log<__Il2CppFullySharedGenericType> ---
		void Amplitude__Log___Il2CppFullySharedGenericType_
		               (undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a632cc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4051);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25144);
		    DAT_ram_00a632cc = '\x01';
		  }
		  if (param3 != 0) {
		    uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar1,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    System_Reflection_FieldInfo__get_IsStatic
		              (uVar1,StringLiteral_25144,param3,
		               Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    uVar1 = AmplitudeNS_MiniJSON_Json__Deserialize(uVar1,0);
		    uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_4051,param2,uVar1,0);
		    Amplitude__get_Instance(param1,uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: Log<float> ---
		void Amplitude__Log_float_(undefined4 param1,int param2,int param3,int param4,int param5)
		
		{
		  int *param2_00;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  
		  if (*(int *)(param5 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28643);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1238);
		    if (*(int *)(param5 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param5);
		    }
		  }
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,4);
		  if ((param2 != 0) && (iVar1 = func_ii_1082(param2,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)
		     ) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[4] = param2;
		  if ((param3 != 0) && (iVar1 = func_ii_1082(param3,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)
		     ) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[5] = param3;
		  if ((param4 != 0) && (iVar1 = func_ii_1082(param4,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)
		     ) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[6] = param4;
		  puVar4 = *(uint **)(*(int *)(param5 + 0x1c) + 4);
		  iVar1 = (**(code **)((ulonglong)*puVar4 * 4))(StringLiteral_1238,param4,puVar4);
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0))
		  {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[7] = iVar1;
		  uVar3 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                    (StringLiteral_28643,param2_00,0);
		  Amplitude__get_Instance(param1,uVar3,0);
		  return;
		}
		*/

		/* --- GHIDRA: Log<object> ---
		void Amplitude__Log_object_(undefined4 param1,int param2,int param3,int param4,int param5)
		
		{
		  int *param2_00;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (*(int *)(param5 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28643);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1238);
		    if (*(int *)(param5 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param5);
		    }
		  }
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,4);
		  if ((param2 != 0) && (iVar1 = func_ii_1082(param2,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)
		     ) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[4] = param2;
		  if ((param3 != 0) && (iVar1 = func_ii_1082(param3,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)
		     ) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[5] = param3;
		  if ((param4 != 0) && (iVar1 = func_ii_1082(param4,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)
		     ) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[6] = param4;
		  iVar1 = System_String__Join_object_
		                    (StringLiteral_1238,param4,*(undefined4 *)(*(int *)(param5 + 0x1c) + 4));
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0))
		  {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[7] = iVar1;
		  uVar3 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                    (StringLiteral_28643,param2_00,0);
		  Amplitude__get_Instance(param1,uVar3,0);
		  return;
		}
		*/

		/* --- GHIDRA: Log<long> ---
		void Amplitude__Log_long_(undefined4 param1,int param2,int param3,int param4,int param5)
		
		{
		  int *param2_00;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (*(int *)(param5 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28643);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1238);
		    if (*(int *)(param5 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param5);
		    }
		  }
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,4);
		  if ((param2 != 0) && (iVar1 = func_ii_1082(param2,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)
		     ) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[4] = param2;
		  if ((param3 != 0) && (iVar1 = func_ii_1082(param3,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)
		     ) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[5] = param3;
		  if ((param4 != 0) && (iVar1 = func_ii_1082(param4,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)
		     ) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[6] = param4;
		  iVar1 = System_String__Join_long_
		                    (StringLiteral_1238,param4,*(undefined4 *)(*(int *)(param5 + 0x1c) + 4));
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0))
		  {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[7] = iVar1;
		  uVar3 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                    (StringLiteral_28643,param2_00,0);
		  Amplitude__get_Instance(param1,uVar3,0);
		  return;
		}
		*/

		/* --- GHIDRA: Log<int> ---
		void Amplitude__Log_int_(undefined4 param1,int param2,int param3,int param4,int param5)
		
		{
		  int *param2_00;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (*(int *)(param5 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28643);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1238);
		    if (*(int *)(param5 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param5);
		    }
		  }
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,4);
		  if ((param2 != 0) && (iVar1 = func_ii_1082(param2,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)
		     ) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[4] = param2;
		  if ((param3 != 0) && (iVar1 = func_ii_1082(param3,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)
		     ) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[5] = param3;
		  if ((param4 != 0) && (iVar1 = func_ii_1082(param4,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)
		     ) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[6] = param4;
		  iVar1 = System_String__Join_Int32Enum_
		                    (StringLiteral_1238,param4,*(undefined4 *)(*(int *)(param5 + 0x1c) + 4));
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0))
		  {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[7] = iVar1;
		  uVar3 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                    (StringLiteral_28643,param2_00,0);
		  Amplitude__get_Instance(param1,uVar3,0);
		  return;
		}
		*/

		/* --- GHIDRA: Log<double> ---
		void Amplitude__Log_double_(undefined4 param1,int param2,int param3,int param4,int param5)
		
		{
		  int *param2_00;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (*(int *)(param5 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28643);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1238);
		    if (*(int *)(param5 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param5);
		    }
		  }
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,4);
		  if ((param2 != 0) && (iVar1 = func_ii_1082(param2,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)
		     ) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[4] = param2;
		  if ((param3 != 0) && (iVar1 = func_ii_1082(param3,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)
		     ) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[5] = param3;
		  if ((param4 != 0) && (iVar1 = func_ii_1082(param4,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)
		     ) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[6] = param4;
		  iVar1 = System_String__Join_HierarchySearchFilter_
		                    (StringLiteral_1238,param4,*(undefined4 *)(*(int *)(param5 + 0x1c) + 4));
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0))
		  {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[7] = iVar1;
		  uVar3 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                    (StringLiteral_28643,param2_00,0);
		  Amplitude__get_Instance(param1,uVar3,0);
		  return;
		}
		*/

		/* --- GHIDRA: Log<bool> ---
		void Amplitude__Log_bool_(undefined4 param1,int param2,int param3,int param4,int param5)
		
		{
		  int *param2_00;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (*(int *)(param5 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28643);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1238);
		    if (*(int *)(param5 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param5);
		    }
		  }
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,4);
		  if ((param2 != 0) && (iVar1 = func_ii_1082(param2,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)
		     ) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[4] = param2;
		  if ((param3 != 0) && (iVar1 = func_ii_1082(param3,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)
		     ) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[5] = param3;
		  if ((param4 != 0) && (iVar1 = func_ii_1082(param4,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)
		     ) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[6] = param4;
		  iVar1 = System_String__Join_bool_
		                    (StringLiteral_1238,param4,*(undefined4 *)(*(int *)(param5 + 0x1c) + 4));
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0))
		  {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[7] = iVar1;
		  uVar3 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                    (StringLiteral_28643,param2_00,0);
		  Amplitude__get_Instance(param1,uVar3,0);
		  return;
		}
		*/

		/* --- GHIDRA: Log ---
		void Amplitude__Log(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a647e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4056);
		    DAT_ram_00a647e2 = '\x01';
		  }
		  param1_00 = func_ii_4419(StringLiteral_4056,param2,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(param1_00,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	protected void Log<T>(string message, string property, IEnumerable<T> array)
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x54D7", Offset = "0x54D7", VA = "0x54D7")]
	public void init(string apiKey)
	{
		/* --- GHIDRA: init ---
		void Amplitude__init(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a647e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4089);
		    DAT_ram_00a647e4 = '\x01';
		  }
		  if (param2 != 0) {
		    uVar1 = AmplitudeNS_MiniJSON_Json__Deserialize(param2,0);
		    uVar1 = func_ii_4419(StringLiteral_4089,uVar1,0);
		    if (DAT_ram_00a647e1 == '\0') {
		      Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		      DAT_ram_00a647e1 = '\x01';
		    }
		    if (*(char *)(param1 + 8) != '\0') {
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		    }
		  }
		  return;
		}
		*/

		/* --- GHIDRA: init ---
		void Amplitude__init(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a647e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4089);
		    DAT_ram_00a647e4 = '\x01';
		  }
		  if (param2 != 0) {
		    uVar1 = AmplitudeNS_MiniJSON_Json__Deserialize(param2,0);
		    uVar1 = func_ii_4419(StringLiteral_4089,uVar1,0);
		    if (DAT_ram_00a647e1 == '\0') {
		      Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		      DAT_ram_00a647e1 = '\x01';
		    }
		    if (*(char *)(param1 + 8) != '\0') {
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		    }
		  }
		  return;
		}
		*/

	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x54D8", Offset = "0x54D8", VA = "0x54D8")]
	public void init(string apiKey, string userId)
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x54D9", Offset = "0x54D9", VA = "0x54D9")]
	public void setTrackingOptions(IDictionary<string, bool> trackingOptions)
	{
		/* --- GHIDRA: setTrackingOptions ---
		void Amplitude__setTrackingOptions(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a647e5 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4071);
		    DAT_ram_00a647e5 = '\x01';
		  }
		  param1_00 = func_ii_4419(StringLiteral_4071,param2,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(param1_00,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x54DA", Offset = "0x54DA", VA = "0x54DA")]
	public void logEvent(string evt)
	{
		/* --- GHIDRA: logEvent ---
		void Amplitude__logEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a647e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4078);
		    DAT_ram_00a647e8 = '\x01';
		  }
		  local_1 = (undefined1)param2;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = func_ii_4419(StringLiteral_4078,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: logEvent ---
		void Amplitude__logEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a647e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4078);
		    DAT_ram_00a647e8 = '\x01';
		  }
		  local_1 = (undefined1)param2;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = func_ii_4419(StringLiteral_4078,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: logEvent ---
		void Amplitude__logEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a647e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4078);
		    DAT_ram_00a647e8 = '\x01';
		  }
		  local_1 = (undefined1)param2;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = func_ii_4419(StringLiteral_4078,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x54DB", Offset = "0x54DB", VA = "0x54DB")]
	public void logEvent(string evt, IDictionary<string, object> properties)
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x54DC", Offset = "0x54DC", VA = "0x54DC")]
	public void logEvent(string evt, IDictionary<string, object> properties, bool outOfSession)
	{
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x54DD", Offset = "0x54DD", VA = "0x54DD")]
	public void setOffline(bool offline)
	{
		/* --- GHIDRA: setOffline ---
		void Amplitude__setOffline(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a647e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4085);
		    DAT_ram_00a647e9 = '\x01';
		  }
		  param1_00 = func_ii_4419(StringLiteral_4085,param2,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(param1_00,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x54DE", Offset = "0x54DE", VA = "0x54DE")]
	public void setUserId(string userId)
	{
		/* --- GHIDRA: setUserId ---
		void Amplitude__setUserId(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a647ea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4086);
		    DAT_ram_00a647ea = '\x01';
		  }
		  if (param2 == 0) {
		    uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar1,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    uVar1 = AmplitudeNS_MiniJSON_Json__Deserialize(uVar1,0);
		  }
		  else {
		    uVar1 = AmplitudeNS_MiniJSON_Json__Deserialize(param2,0);
		  }
		  uVar1 = func_ii_4419(StringLiteral_4086,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x54DF", Offset = "0x54DF", VA = "0x54DF")]
	public void setUserProperties(IDictionary<string, object> properties)
	{
		/* --- GHIDRA: setUserProperties ---
		void Amplitude__setUserProperties(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a647eb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_object___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4075);
		    DAT_ram_00a647eb = '\x01';
		  }
		  iVar2 = Method_System_Array_Empty_object___;
		  iVar1 = *(int *)(Method_System_Array_Empty_object___ + 0x1c);
		  if (iVar1 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_object___);
		    iVar1 = *(int *)(iVar2 + 0x1c);
		  }
		  iVar1 = *(int *)(iVar1 + 8);
		  if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		    iVar1 = func_ii_1079(iVar1);
		  }
		  if (*(int *)(iVar1 + 0x74) == 0) {
		    func_ii_306000(iVar1);
		  }
		  iVar2 = *(int *)(*(int *)(iVar2 + 0x1c) + 8);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  param1_00 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                        (StringLiteral_4075,**(undefined4 **)(iVar2 + 0x5c),0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(param1_00,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x54E0", Offset = "0x54E0", VA = "0x54E0")]
	public void setGroup(string groupType, string groupName)
	{
		/* --- GHIDRA: setGroup ---
		void Amplitude__setGroup(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a647ed == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4081);
		    DAT_ram_00a647ed = '\x01';
		  }
		  local_1 = (undefined1)param2;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = func_ii_4419(StringLiteral_4081,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setGroup ---
		void Amplitude__setGroup(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a647ed == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4081);
		    DAT_ram_00a647ed = '\x01';
		  }
		  local_1 = (undefined1)param2;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = func_ii_4419(StringLiteral_4081,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x54E1", Offset = "0x54E1", VA = "0x54E1")]
	public void setGroup(string groupType, string[] groupName)
	{
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x54E2", Offset = "0x54E2", VA = "0x54E2")]
	public void setOptOut(bool enabled)
	{
		/* --- GHIDRA: setOptOut ---
		void Amplitude__setOptOut(int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a647ee == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4062);
		    DAT_ram_00a647ee = '\x01';
		  }
		  local_8 = param2;
		  uVar1 = func_ii_1081(DAT_ram_00a66964,&local_8);
		  uVar1 = func_ii_4419(StringLiteral_4062,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x54E3", Offset = "0x54E3", VA = "0x54E3")]
	public void setMinTimeBetweenSessionsMillis(long minTimeBetweenSessionsMillis)
	{
		/* --- GHIDRA: setMinTimeBetweenSessionsMillis ---
		void Amplitude__setMinTimeBetweenSessionsMillis(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a647ef == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4055);
		    DAT_ram_00a647ef = '\x01';
		  }
		  local_4 = param2;
		  uVar1 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  uVar1 = func_ii_4419(StringLiteral_4055,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x54E4", Offset = "0x54E4", VA = "0x54E4")]
	public void setEventUploadPeriodSeconds(int eventUploadPeriodSeconds)
	{
		/* --- GHIDRA: setEventUploadPeriodSeconds ---
		void Amplitude__setEventUploadPeriodSeconds(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a647f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4074);
		    DAT_ram_00a647f0 = '\x01';
		  }
		  param1_00 = func_ii_4419(StringLiteral_4074,param2,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(param1_00,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x54E5", Offset = "0x54E5", VA = "0x54E5")]
	public void setDeviceId(string deviceId)
	{
		/* --- GHIDRA: setDeviceId ---
		void Amplitude__setDeviceId(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a647f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4054);
		    DAT_ram_00a647f1 = '\x01';
		  }
		  param1_00 = StringLiteral_4054;
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(param1_00,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x54E6", Offset = "0x54E6", VA = "0x54E6")]
	public void enableCoppaControl()
	{
		/* --- GHIDRA: enableCoppaControl ---
		void Amplitude__enableCoppaControl(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a647f2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_object___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4053);
		    DAT_ram_00a647f2 = '\x01';
		  }
		  iVar2 = Method_System_Array_Empty_object___;
		  iVar1 = *(int *)(Method_System_Array_Empty_object___ + 0x1c);
		  if (iVar1 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_object___);
		    iVar1 = *(int *)(iVar2 + 0x1c);
		  }
		  iVar1 = *(int *)(iVar1 + 8);
		  if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		    iVar1 = func_ii_1079(iVar1);
		  }
		  if (*(int *)(iVar1 + 0x74) == 0) {
		    func_ii_306000(iVar1);
		  }
		  iVar2 = *(int *)(*(int *)(iVar2 + 0x1c) + 8);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  param1_00 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                        (StringLiteral_4053,**(undefined4 **)(iVar2 + 0x5c),0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(param1_00,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x54E7", Offset = "0x54E7", VA = "0x54E7")]
	public void disableCoppaControl()
	{
		/* --- GHIDRA: disableCoppaControl ---
		void Amplitude__disableCoppaControl(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a647f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_object___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4082);
		    DAT_ram_00a647f3 = '\x01';
		  }
		  iVar2 = Method_System_Array_Empty_object___;
		  iVar1 = *(int *)(Method_System_Array_Empty_object___ + 0x1c);
		  if (iVar1 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_object___);
		    iVar1 = *(int *)(iVar2 + 0x1c);
		  }
		  iVar1 = *(int *)(iVar1 + 8);
		  if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		    iVar1 = func_ii_1079(iVar1);
		  }
		  if (*(int *)(iVar1 + 0x74) == 0) {
		    func_ii_306000(iVar1);
		  }
		  iVar2 = *(int *)(*(int *)(iVar2 + 0x1c) + 8);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  param1_00 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                        (StringLiteral_4082,**(undefined4 **)(iVar2 + 0x5c),0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(param1_00,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x54E8", Offset = "0x54E8", VA = "0x54E8")]
	public void setServerUrl(string serverUrl)
	{
		/* --- GHIDRA: setServerUrl ---
		void Amplitude__setServerUrl(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a647f4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_object___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4084);
		    DAT_ram_00a647f4 = '\x01';
		  }
		  iVar2 = Method_System_Array_Empty_object___;
		  iVar1 = *(int *)(Method_System_Array_Empty_object___ + 0x1c);
		  if (iVar1 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_object___);
		    iVar1 = *(int *)(iVar2 + 0x1c);
		  }
		  iVar1 = *(int *)(iVar1 + 8);
		  if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		    iVar1 = func_ii_1079(iVar1);
		  }
		  if (*(int *)(iVar1 + 0x74) == 0) {
		    func_ii_306000(iVar1);
		  }
		  iVar2 = *(int *)(*(int *)(iVar2 + 0x1c) + 8);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  param1_00 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                        (StringLiteral_4084,**(undefined4 **)(iVar2 + 0x5c),0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(param1_00,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x54E9", Offset = "0x54E9", VA = "0x54E9")]
	public void setUseDynamicConfig(bool useDynamicConfig)
	{
		/* --- GHIDRA: setUseDynamicConfig ---
		void Amplitude__setUseDynamicConfig
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a647f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&AmplitudeServerZone_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_object___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4083);
		    DAT_ram_00a647f5 = '\x01';
		  }
		  iVar2 = Method_System_Array_Empty_object___;
		  iVar1 = *(int *)(Method_System_Array_Empty_object___ + 0x1c);
		  if (iVar1 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_object___);
		    iVar1 = *(int *)(iVar2 + 0x1c);
		  }
		  iVar1 = *(int *)(iVar1 + 8);
		  if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		    iVar1 = func_ii_1079(iVar1);
		  }
		  if (*(int *)(iVar1 + 0x74) == 0) {
		    func_ii_306000(iVar1);
		  }
		  iVar2 = *(int *)(*(int *)(iVar2 + 0x1c) + 8);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  param1_00 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                        (StringLiteral_4083,**(undefined4 **)(iVar2 + 0x5c),0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(param1_00,0);
		  }
		  local_8 = 0xffffffff;
		  local_c = AmplitudeServerZone_TypeInfo;
		  local_4 = param2;
		  Spine_SkeletonJson__GetFloat(&local_c,0);
		  return;
		}
		*/

	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x54EA", Offset = "0x54EA", VA = "0x54EA")]
	public void setServerZone(AmplitudeServerZone serverZone, bool updateServerUrl = true)
	{
		/* --- GHIDRA: setServerZone ---
		void Amplitude__setServerZone(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Amplitude__setUserId(param1,param2,param2);
		  return;
		}
		*/

	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x54EB", Offset = "0x54EB", VA = "0x54EB")]
	[Obsolete("Please call setUserProperties instead", false)]
	public void setGlobalUserProperties(IDictionary<string, object> properties)
	{
		/* --- GHIDRA: setGlobalUserProperties ---
		void Amplitude__setGlobalUserProperties(int param1,double param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  float8 local_8;
		  
		  if (DAT_ram_00a647f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4058);
		    DAT_ram_00a647f6 = '\x01';
		  }
		  local_8 = (float8)param2;
		  uVar1 = func_ii_1081(DAT_ram_00a66970,&local_8);
		  uVar1 = func_ii_4419(StringLiteral_4058,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x54EC", Offset = "0x54EC", VA = "0x54EC")]
	public void logRevenue(double amount)
	{
		/* --- GHIDRA: logRevenue ---
		void Amplitude__logRevenue
		               (int param1,int param2,undefined4 param3,double param4,undefined4 param5,
		               undefined4 param6,int param7,int param8,undefined4 param9)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  int *param2_00;
		  int iVar2;
		  int iVar3;
		  float8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a647f9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4061);
		    DAT_ram_00a647f9 = '\x01';
		  }
		  if (param8 == 0) {
		    uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar1,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    param1_00 = AmplitudeNS_MiniJSON_Json__Deserialize(uVar1,0);
		  }
		  else {
		    param1_00 = AmplitudeNS_MiniJSON_Json__Deserialize(param8,0);
		  }
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,5);
		  if ((param2 != 0) && (iVar2 = func_ii_1082(param2,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0)
		     ) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[4] = param2;
		  local_4 = param3;
		  iVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  if ((iVar2 != 0) && (iVar3 = func_ii_1082(iVar2,*(undefined4 *)(*param2_00 + 0x20)), iVar3 == 0))
		  {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[5] = iVar2;
		  local_10 = (float8)param4;
		  iVar2 = func_ii_1081(DAT_ram_00a66970,&local_10);
		  if ((iVar2 != 0) && (iVar3 = func_ii_1082(iVar2,*(undefined4 *)(*param2_00 + 0x20)), iVar3 == 0))
		  {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[6] = iVar2;
		  if ((param7 != 0) && (iVar2 = func_ii_1082(param7,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0)
		     ) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[7] = param7;
		  if ((param1_00 != 0) &&
		     (iVar2 = func_ii_1082(param1_00,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[8] = param1_00;
		  uVar1 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                    (StringLiteral_4061,param2_00,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: logRevenue ---
		void Amplitude__logRevenue
		               (int param1,int param2,undefined4 param3,double param4,undefined4 param5,
		               undefined4 param6,int param7,int param8,undefined4 param9)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  int *param2_00;
		  int iVar2;
		  int iVar3;
		  float8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a647f9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4061);
		    DAT_ram_00a647f9 = '\x01';
		  }
		  if (param8 == 0) {
		    uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar1,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    param1_00 = AmplitudeNS_MiniJSON_Json__Deserialize(uVar1,0);
		  }
		  else {
		    param1_00 = AmplitudeNS_MiniJSON_Json__Deserialize(param8,0);
		  }
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,5);
		  if ((param2 != 0) && (iVar2 = func_ii_1082(param2,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0)
		     ) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[4] = param2;
		  local_4 = param3;
		  iVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  if ((iVar2 != 0) && (iVar3 = func_ii_1082(iVar2,*(undefined4 *)(*param2_00 + 0x20)), iVar3 == 0))
		  {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[5] = iVar2;
		  local_10 = (float8)param4;
		  iVar2 = func_ii_1081(DAT_ram_00a66970,&local_10);
		  if ((iVar2 != 0) && (iVar3 = func_ii_1082(iVar2,*(undefined4 *)(*param2_00 + 0x20)), iVar3 == 0))
		  {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[6] = iVar2;
		  if ((param7 != 0) && (iVar2 = func_ii_1082(param7,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0)
		     ) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[7] = param7;
		  if ((param1_00 != 0) &&
		     (iVar2 = func_ii_1082(param1_00,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[8] = param1_00;
		  uVar1 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                    (StringLiteral_4061,param2_00,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: logRevenue ---
		void Amplitude__logRevenue
		               (int param1,int param2,undefined4 param3,double param4,undefined4 param5,
		               undefined4 param6,int param7,int param8,undefined4 param9)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  int *param2_00;
		  int iVar2;
		  int iVar3;
		  float8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a647f9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4061);
		    DAT_ram_00a647f9 = '\x01';
		  }
		  if (param8 == 0) {
		    uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar1,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    param1_00 = AmplitudeNS_MiniJSON_Json__Deserialize(uVar1,0);
		  }
		  else {
		    param1_00 = AmplitudeNS_MiniJSON_Json__Deserialize(param8,0);
		  }
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,5);
		  if ((param2 != 0) && (iVar2 = func_ii_1082(param2,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0)
		     ) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[4] = param2;
		  local_4 = param3;
		  iVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  if ((iVar2 != 0) && (iVar3 = func_ii_1082(iVar2,*(undefined4 *)(*param2_00 + 0x20)), iVar3 == 0))
		  {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[5] = iVar2;
		  local_10 = (float8)param4;
		  iVar2 = func_ii_1081(DAT_ram_00a66970,&local_10);
		  if ((iVar2 != 0) && (iVar3 = func_ii_1082(iVar2,*(undefined4 *)(*param2_00 + 0x20)), iVar3 == 0))
		  {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[6] = iVar2;
		  if ((param7 != 0) && (iVar2 = func_ii_1082(param7,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0)
		     ) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[7] = param7;
		  if ((param1_00 != 0) &&
		     (iVar2 = func_ii_1082(param1_00,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[8] = param1_00;
		  uVar1 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                    (StringLiteral_4061,param2_00,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: logRevenue ---
		void Amplitude__logRevenue
		               (int param1,int param2,undefined4 param3,double param4,undefined4 param5,
		               undefined4 param6,int param7,int param8,undefined4 param9)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  int *param2_00;
		  int iVar2;
		  int iVar3;
		  float8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a647f9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4061);
		    DAT_ram_00a647f9 = '\x01';
		  }
		  if (param8 == 0) {
		    uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar1,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    param1_00 = AmplitudeNS_MiniJSON_Json__Deserialize(uVar1,0);
		  }
		  else {
		    param1_00 = AmplitudeNS_MiniJSON_Json__Deserialize(param8,0);
		  }
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,5);
		  if ((param2 != 0) && (iVar2 = func_ii_1082(param2,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0)
		     ) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[4] = param2;
		  local_4 = param3;
		  iVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  if ((iVar2 != 0) && (iVar3 = func_ii_1082(iVar2,*(undefined4 *)(*param2_00 + 0x20)), iVar3 == 0))
		  {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[5] = iVar2;
		  local_10 = (float8)param4;
		  iVar2 = func_ii_1081(DAT_ram_00a66970,&local_10);
		  if ((iVar2 != 0) && (iVar3 = func_ii_1082(iVar2,*(undefined4 *)(*param2_00 + 0x20)), iVar3 == 0))
		  {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[6] = iVar2;
		  if ((param7 != 0) && (iVar2 = func_ii_1082(param7,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0)
		     ) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[7] = param7;
		  if ((param1_00 != 0) &&
		     (iVar2 = func_ii_1082(param1_00,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[8] = param1_00;
		  uVar1 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                    (StringLiteral_4061,param2_00,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x54ED", Offset = "0x54ED", VA = "0x54ED")]
	public void logRevenue(string productId, int quantity, double price)
	{
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x54EE", Offset = "0x54EE", VA = "0x54EE")]
	public void logRevenue(string productId, int quantity, double price, string receipt, string receiptSignature)
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x54EF", Offset = "0x54EF", VA = "0x54EF")]
	public void logRevenue(string productId, int quantity, double price, string receipt, string receiptSignature, string revenueType, IDictionary<string, object> eventProperties)
	{
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x54F0", Offset = "0x54F0", VA = "0x54F0")]
	public string getDeviceId()
	{
		return null;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x54F1", Offset = "0x54F1", VA = "0x54F1")]
	public void regenerateDeviceId()
	{
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x54F2", Offset = "0x54F2", VA = "0x54F2")]
	public void useAdvertisingIdForDeviceId()
	{
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x54F3", Offset = "0x54F3", VA = "0x54F3")]
	public void useAppSetIdForDeviceId()
	{
		/* --- GHIDRA: useAppSetIdForDeviceId ---
		void Amplitude__useAppSetIdForDeviceId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a647fa == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4090);
		    DAT_ram_00a647fa = '\x01';
		  }
		  local_1 = (undefined1)param2;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = func_ii_4419(StringLiteral_4090,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x54F4", Offset = "0x54F4", VA = "0x54F4")]
	public void trackSessionEvents(bool enabled)
	{
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002058 File Offset: 0x00000258
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x54F5", Offset = "0x54F5", VA = "0x54F5")]
	public long getSessionId()
	{
		return 0L;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x54F6", Offset = "0x54F6", VA = "0x54F6")]
	public void uploadEvents()
	{
		/* --- GHIDRA: uploadEvents ---
		void Amplitude__uploadEvents(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a647fb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_object___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4052);
		    DAT_ram_00a647fb = '\x01';
		  }
		  iVar2 = Method_System_Array_Empty_object___;
		  iVar1 = *(int *)(Method_System_Array_Empty_object___ + 0x1c);
		  if (iVar1 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_object___);
		    iVar1 = *(int *)(iVar2 + 0x1c);
		  }
		  iVar1 = *(int *)(iVar1 + 8);
		  if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		    iVar1 = func_ii_1079(iVar1);
		  }
		  if (*(int *)(iVar1 + 0x74) == 0) {
		    func_ii_306000(iVar1);
		  }
		  iVar2 = *(int *)(*(int *)(iVar2 + 0x1c) + 8);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  param1_00 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                        (StringLiteral_4052,**(undefined4 **)(iVar2 + 0x5c),0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(param1_00,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x54F7", Offset = "0x54F7", VA = "0x54F7")]
	public void clearUserProperties()
	{
		/* --- GHIDRA: clearUserProperties ---
		void Amplitude__clearUserProperties(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a647fc == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4091);
		    DAT_ram_00a647fc = '\x01';
		  }
		  param1_00 = func_ii_4419(StringLiteral_4091,param2,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(param1_00,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x54F8", Offset = "0x54F8", VA = "0x54F8")]
	public void unsetUserProperty(string property)
	{
		/* --- GHIDRA: unsetUserProperty ---
		void Amplitude__unsetUserProperty(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a647fd == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4080);
		    DAT_ram_00a647fd = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4080,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x54F9", Offset = "0x54F9", VA = "0x54F9")]
	public void setOnceUserProperty(string property, bool value)
	{
		/* --- GHIDRA: setOnceUserProperty ---
		void Amplitude__setOnceUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6480a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4088);
		    DAT_ram_00a6480a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4088,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setOnceUserProperty ---
		void Amplitude__setOnceUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6480a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4088);
		    DAT_ram_00a6480a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4088,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setOnceUserProperty ---
		void Amplitude__setOnceUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6480a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4088);
		    DAT_ram_00a6480a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4088,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setOnceUserProperty ---
		void Amplitude__setOnceUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6480a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4088);
		    DAT_ram_00a6480a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4088,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setOnceUserProperty ---
		void Amplitude__setOnceUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6480a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4088);
		    DAT_ram_00a6480a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4088,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setOnceUserProperty ---
		void Amplitude__setOnceUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6480a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4088);
		    DAT_ram_00a6480a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4088,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setOnceUserProperty<__Il2CppFullySharedGenericType> ---
		void Amplitude__setOnceUserProperty___Il2CppFullySharedGenericType_
		               (undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a632d2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25144);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4088);
		    DAT_ram_00a632d2 = '\x01';
		  }
		  if (param3 != 0) {
		    uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar1,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    System_Reflection_FieldInfo__get_IsStatic
		              (uVar1,StringLiteral_25144,param3,
		               Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    uVar1 = AmplitudeNS_MiniJSON_Json__Deserialize(uVar1,0);
		    uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_4088,param2,uVar1,0);
		    Amplitude__get_Instance(param1,uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setOnceUserProperty ---
		void Amplitude__setOnceUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6480a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4088);
		    DAT_ram_00a6480a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4088,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setOnceUserProperty ---
		void Amplitude__setOnceUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6480a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4088);
		    DAT_ram_00a6480a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4088,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setOnceUserProperty ---
		void Amplitude__setOnceUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6480a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4088);
		    DAT_ram_00a6480a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4088,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setOnceUserProperty ---
		void Amplitude__setOnceUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6480a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4088);
		    DAT_ram_00a6480a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4088,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setOnceUserProperty ---
		void Amplitude__setOnceUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6480a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4088);
		    DAT_ram_00a6480a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4088,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setOnceUserProperty ---
		void Amplitude__setOnceUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6480a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4088);
		    DAT_ram_00a6480a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4088,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setOnceUserProperty ---
		void Amplitude__setOnceUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6480a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4088);
		    DAT_ram_00a6480a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4088,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x54FA", Offset = "0x54FA", VA = "0x54FA")]
	public void setOnceUserProperty(string property, double value)
	{
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x54FB", Offset = "0x54FB", VA = "0x54FB")]
	public void setOnceUserProperty(string property, float value)
	{
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x54FC", Offset = "0x54FC", VA = "0x54FC")]
	public void setOnceUserProperty(string property, int value)
	{
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x54FD", Offset = "0x54FD", VA = "0x54FD")]
	public void setOnceUserProperty(string property, long value)
	{
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x54FE", Offset = "0x54FE", VA = "0x54FE")]
	public void setOnceUserProperty(string property, string value)
	{
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x54FF", Offset = "0x54FF", VA = "0x54FF")]
	public void setOnceUserProperty(string property, IDictionary<string, object> values)
	{
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000034")]
	public void setOnceUserProperty<T>(string property, IList<T> values)
	{
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x5500", Offset = "0x5500", VA = "0x5500")]
	public void setOnceUserProperty(string property, bool[] array)
	{
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x5501", Offset = "0x5501", VA = "0x5501")]
	public void setOnceUserProperty(string property, double[] array)
	{
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x5502", Offset = "0x5502", VA = "0x5502")]
	public void setOnceUserProperty(string property, float[] array)
	{
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x5503", Offset = "0x5503", VA = "0x5503")]
	public void setOnceUserProperty(string property, int[] array)
	{
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x5504", Offset = "0x5504", VA = "0x5504")]
	public void setOnceUserProperty(string property, long[] array)
	{
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x5505", Offset = "0x5505", VA = "0x5505")]
	public void setOnceUserProperty(string property, string[] array)
	{
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x5506", Offset = "0x5506", VA = "0x5506")]
	public void setUserProperty(string property, bool value)
	{
		/* --- GHIDRA: setUserProperty ---
		void Amplitude__setUserProperty(int param1,undefined4 param2,double param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  float8 local_8;
		  
		  if (DAT_ram_00a64817 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4049);
		    DAT_ram_00a64817 = '\x01';
		  }
		  local_8 = (float8)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66970,&local_8);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4049,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setUserProperty ---
		void Amplitude__setUserProperty(int param1,undefined4 param2,double param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  float8 local_8;
		  
		  if (DAT_ram_00a64817 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4049);
		    DAT_ram_00a64817 = '\x01';
		  }
		  local_8 = (float8)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66970,&local_8);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4049,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setUserProperty ---
		void Amplitude__setUserProperty(int param1,undefined4 param2,double param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  float8 local_8;
		  
		  if (DAT_ram_00a64817 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4049);
		    DAT_ram_00a64817 = '\x01';
		  }
		  local_8 = (float8)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66970,&local_8);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4049,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setUserProperty ---
		void Amplitude__setUserProperty(int param1,undefined4 param2,double param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  float8 local_8;
		  
		  if (DAT_ram_00a64817 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4049);
		    DAT_ram_00a64817 = '\x01';
		  }
		  local_8 = (float8)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66970,&local_8);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4049,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setUserProperty ---
		void Amplitude__setUserProperty(int param1,undefined4 param2,double param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  float8 local_8;
		  
		  if (DAT_ram_00a64817 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4049);
		    DAT_ram_00a64817 = '\x01';
		  }
		  local_8 = (float8)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66970,&local_8);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4049,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setUserProperty ---
		void Amplitude__setUserProperty(int param1,undefined4 param2,double param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  float8 local_8;
		  
		  if (DAT_ram_00a64817 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4049);
		    DAT_ram_00a64817 = '\x01';
		  }
		  local_8 = (float8)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66970,&local_8);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4049,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setUserProperty<__Il2CppFullySharedGenericType> ---
		int Amplitude__setUserProperty___Il2CppFullySharedGenericType_(int param1,int param2)
		
		{
		  int iVar1;
		  int *param3;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  
		  puVar3 = *(undefined4 **)(param2 + 0x1c);
		  if (puVar3 == (undefined4 *)0x0) {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Type__AbstractAnalyticsListener__Add__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Type__AbstractAnalyticsListener__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Type__AbstractAnalyticsListener__get_Item__
		              );
		    puVar3 = *(undefined4 **)(param2 + 0x1c);
		    if (puVar3 == (undefined4 *)0x0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param2);
		      puVar3 = *(undefined4 **)(param2 + 0x1c);
		    }
		  }
		  uVar4 = *puVar3;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar4 = func_ii_2734(uVar4,0);
		  iVar1 = System_Xml_Schema_SchemaInfo__get_Notations
		                    (*(undefined4 *)(param1 + 0x14),uVar4,
		                     Method_System_Collections_Generic_Dictionary_Type__AbstractAnalyticsListener__ContainsKey__
		                    );
		  if (iVar1 == 0) {
		    param3 = (int *)System_Delegate__Combine(*(undefined4 *)(*(int *)(param2 + 0x1c) + 4));
		    iVar1 = System_Uri___ctor(0);
		    (**(code **)((ulonglong)*(uint *)(*param3 + 0xf8) * 4))
		              (param3,*(undefined4 *)(*(int *)(iVar1 + 0x38) + 0x10),*(undefined4 *)(*param3 + 0xfc)
		              );
		    (**(code **)((ulonglong)*(uint *)(*param3 + 0x110) * 4))
		              (param3,*(undefined4 *)(*param3 + 0x114));
		    System_Reflection_FieldInfo__get_IsStatic
		              (*(undefined4 *)(param1 + 0x14),uVar4,param3,
		               Method_System_Collections_Generic_Dictionary_Type__AbstractAnalyticsListener__Add__);
		  }
		  else {
		    param3 = (int *)System_Data_DataRelationCollection__Add
		                              (*(undefined4 *)(param1 + 0x14),uVar4,
		                               Method_System_Collections_Generic_Dictionary_Type__AbstractAnalyticsListener__get_Item__
		                              );
		  }
		  iVar1 = *(int *)(*(int *)(param2 + 0x1c) + 8);
		  if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		    iVar1 = func_ii_1079(iVar1);
		  }
		  if (param3 == (int *)0x0) {
		    iVar2 = 0;
		  }
		  else {
		    iVar2 = func_ii_1082(param3,iVar1);
		    if (iVar2 == 0) {
		      System_Activator__CreateInstance(param3,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return iVar2;
		}
		*/

		/* --- GHIDRA: setUserProperty ---
		void Amplitude__setUserProperty(int param1,undefined4 param2,double param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  float8 local_8;
		  
		  if (DAT_ram_00a64817 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4049);
		    DAT_ram_00a64817 = '\x01';
		  }
		  local_8 = (float8)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66970,&local_8);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4049,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setUserProperty ---
		void Amplitude__setUserProperty(int param1,undefined4 param2,double param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  float8 local_8;
		  
		  if (DAT_ram_00a64817 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4049);
		    DAT_ram_00a64817 = '\x01';
		  }
		  local_8 = (float8)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66970,&local_8);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4049,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setUserProperty ---
		void Amplitude__setUserProperty(int param1,undefined4 param2,double param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  float8 local_8;
		  
		  if (DAT_ram_00a64817 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4049);
		    DAT_ram_00a64817 = '\x01';
		  }
		  local_8 = (float8)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66970,&local_8);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4049,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setUserProperty ---
		void Amplitude__setUserProperty(int param1,undefined4 param2,double param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  float8 local_8;
		  
		  if (DAT_ram_00a64817 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4049);
		    DAT_ram_00a64817 = '\x01';
		  }
		  local_8 = (float8)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66970,&local_8);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4049,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setUserProperty ---
		void Amplitude__setUserProperty(int param1,undefined4 param2,double param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  float8 local_8;
		  
		  if (DAT_ram_00a64817 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4049);
		    DAT_ram_00a64817 = '\x01';
		  }
		  local_8 = (float8)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66970,&local_8);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4049,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setUserProperty ---
		void Amplitude__setUserProperty(int param1,undefined4 param2,double param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  float8 local_8;
		  
		  if (DAT_ram_00a64817 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4049);
		    DAT_ram_00a64817 = '\x01';
		  }
		  local_8 = (float8)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66970,&local_8);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4049,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: setUserProperty ---
		void Amplitude__setUserProperty(int param1,undefined4 param2,double param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  float8 local_8;
		  
		  if (DAT_ram_00a64817 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4049);
		    DAT_ram_00a64817 = '\x01';
		  }
		  local_8 = (float8)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66970,&local_8);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4049,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x5507", Offset = "0x5507", VA = "0x5507")]
	public void setUserProperty(string property, double value)
	{
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x5508", Offset = "0x5508", VA = "0x5508")]
	public void setUserProperty(string property, float value)
	{
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003E")]
	[Address(RVA = "0x5509", Offset = "0x5509", VA = "0x5509")]
	public void setUserProperty(string property, int value)
	{
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x550A", Offset = "0x550A", VA = "0x550A")]
	public void setUserProperty(string property, long value)
	{
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x550B", Offset = "0x550B", VA = "0x550B")]
	public void setUserProperty(string property, string value)
	{
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x550C", Offset = "0x550C", VA = "0x550C")]
	public void setUserProperty(string property, IDictionary<string, object> values)
	{
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000042")]
	public void setUserProperty<T>(string property, IList<T> values)
	{
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000043")]
	[Address(RVA = "0x550D", Offset = "0x550D", VA = "0x550D")]
	public void setUserProperty(string property, bool[] array)
	{
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x550E", Offset = "0x550E", VA = "0x550E")]
	public void setUserProperty(string property, double[] array)
	{
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x550F", Offset = "0x550F", VA = "0x550F")]
	public void setUserProperty(string property, float[] array)
	{
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x5510", Offset = "0x5510", VA = "0x5510")]
	public void setUserProperty(string property, int[] array)
	{
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x5511", Offset = "0x5511", VA = "0x5511")]
	public void setUserProperty(string property, long[] array)
	{
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x5512", Offset = "0x5512", VA = "0x5512")]
	public void setUserProperty(string property, string[] array)
	{
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x5513", Offset = "0x5513", VA = "0x5513")]
	public void addUserProperty(string property, double value)
	{
		/* --- GHIDRA: addUserProperty ---
		void Amplitude__addUserProperty(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6481d == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4051);
		    DAT_ram_00a6481d = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4051,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: addUserProperty ---
		void Amplitude__addUserProperty(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6481d == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4051);
		    DAT_ram_00a6481d = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4051,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: addUserProperty ---
		void Amplitude__addUserProperty(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6481d == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4051);
		    DAT_ram_00a6481d = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4051,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: addUserProperty ---
		void Amplitude__addUserProperty(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6481d == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4051);
		    DAT_ram_00a6481d = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4051,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: addUserProperty ---
		void Amplitude__addUserProperty(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6481d == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4051);
		    DAT_ram_00a6481d = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4051,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: addUserProperty ---
		void Amplitude__addUserProperty(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6481d == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4051);
		    DAT_ram_00a6481d = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4051,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004A")]
	[Address(RVA = "0x5514", Offset = "0x5514", VA = "0x5514")]
	public void addUserProperty(string property, float value)
	{
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004B")]
	[Address(RVA = "0x5515", Offset = "0x5515", VA = "0x5515")]
	public void addUserProperty(string property, int value)
	{
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004C")]
	[Address(RVA = "0x5516", Offset = "0x5516", VA = "0x5516")]
	public void addUserProperty(string property, long value)
	{
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004D")]
	[Address(RVA = "0x5517", Offset = "0x5517", VA = "0x5517")]
	public void addUserProperty(string property, string value)
	{
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x5518", Offset = "0x5518", VA = "0x5518")]
	public void addUserProperty(string property, IDictionary<string, object> values)
	{
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x5519", Offset = "0x5519", VA = "0x5519")]
	public void appendUserProperty(string property, bool value)
	{
		/* --- GHIDRA: appendUserProperty ---
		void Amplitude__appendUserProperty(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6482a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4068);
		    DAT_ram_00a6482a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4068,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: appendUserProperty ---
		void Amplitude__appendUserProperty(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6482a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4068);
		    DAT_ram_00a6482a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4068,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: appendUserProperty ---
		void Amplitude__appendUserProperty(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6482a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4068);
		    DAT_ram_00a6482a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4068,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: appendUserProperty ---
		void Amplitude__appendUserProperty(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6482a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4068);
		    DAT_ram_00a6482a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4068,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: appendUserProperty ---
		void Amplitude__appendUserProperty(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6482a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4068);
		    DAT_ram_00a6482a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4068,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: appendUserProperty ---
		void Amplitude__appendUserProperty(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6482a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4068);
		    DAT_ram_00a6482a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4068,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: appendUserProperty<__Il2CppFullySharedGenericType> ---
		void Amplitude__appendUserProperty___Il2CppFullySharedGenericType_
		               (undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a632cd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25144);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4064);
		    DAT_ram_00a632cd = '\x01';
		  }
		  if (param3 != 0) {
		    uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar1,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    System_Reflection_FieldInfo__get_IsStatic
		              (uVar1,StringLiteral_25144,param3,
		               Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    uVar1 = AmplitudeNS_MiniJSON_Json__Deserialize(uVar1,0);
		    uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_4064,param2,uVar1,0);
		    Amplitude__get_Instance(param1,uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: appendUserProperty ---
		void Amplitude__appendUserProperty(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6482a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4068);
		    DAT_ram_00a6482a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4068,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: appendUserProperty ---
		void Amplitude__appendUserProperty(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6482a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4068);
		    DAT_ram_00a6482a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4068,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: appendUserProperty ---
		void Amplitude__appendUserProperty(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6482a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4068);
		    DAT_ram_00a6482a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4068,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: appendUserProperty ---
		void Amplitude__appendUserProperty(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6482a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4068);
		    DAT_ram_00a6482a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4068,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: appendUserProperty ---
		void Amplitude__appendUserProperty(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6482a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4068);
		    DAT_ram_00a6482a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4068,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: appendUserProperty ---
		void Amplitude__appendUserProperty(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6482a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4068);
		    DAT_ram_00a6482a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4068,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: appendUserProperty ---
		void Amplitude__appendUserProperty(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a6482a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4068);
		    DAT_ram_00a6482a = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4068,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x551A", Offset = "0x551A", VA = "0x551A")]
	public void appendUserProperty(string property, double value)
	{
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x551B", Offset = "0x551B", VA = "0x551B")]
	public void appendUserProperty(string property, float value)
	{
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x551C", Offset = "0x551C", VA = "0x551C")]
	public void appendUserProperty(string property, int value)
	{
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000053")]
	[Address(RVA = "0x551D", Offset = "0x551D", VA = "0x551D")]
	public void appendUserProperty(string property, long value)
	{
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x551E", Offset = "0x551E", VA = "0x551E")]
	public void appendUserProperty(string property, string value)
	{
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x551F", Offset = "0x551F", VA = "0x551F")]
	public void appendUserProperty(string property, IDictionary<string, object> values)
	{
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000056")]
	public void appendUserProperty<T>(string property, IList<T> values)
	{
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000057")]
	[Address(RVA = "0x5520", Offset = "0x5520", VA = "0x5520")]
	public void appendUserProperty(string property, bool[] array)
	{
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x5521", Offset = "0x5521", VA = "0x5521")]
	public void appendUserProperty(string property, double[] array)
	{
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x5522", Offset = "0x5522", VA = "0x5522")]
	public void appendUserProperty(string property, float[] array)
	{
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x5523", Offset = "0x5523", VA = "0x5523")]
	public void appendUserProperty(string property, int[] array)
	{
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x5524", Offset = "0x5524", VA = "0x5524")]
	public void appendUserProperty(string property, long[] array)
	{
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x5525", Offset = "0x5525", VA = "0x5525")]
	public void appendUserProperty(string property, string[] array)
	{
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005D")]
	[Address(RVA = "0x5526", Offset = "0x5526", VA = "0x5526")]
	public void prependUserProperty(string property, bool value)
	{
		/* --- GHIDRA: prependUserProperty ---
		void Amplitude__prependUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64837 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4066);
		    DAT_ram_00a64837 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4066,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: prependUserProperty ---
		void Amplitude__prependUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64837 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4066);
		    DAT_ram_00a64837 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4066,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: prependUserProperty ---
		void Amplitude__prependUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64837 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4066);
		    DAT_ram_00a64837 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4066,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: prependUserProperty ---
		void Amplitude__prependUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64837 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4066);
		    DAT_ram_00a64837 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4066,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: prependUserProperty ---
		void Amplitude__prependUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64837 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4066);
		    DAT_ram_00a64837 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4066,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: prependUserProperty ---
		void Amplitude__prependUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64837 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4066);
		    DAT_ram_00a64837 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4066,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: prependUserProperty<__Il2CppFullySharedGenericType> ---
		void Amplitude__prependUserProperty___Il2CppFullySharedGenericType_
		               (undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a632d0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25144);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4070);
		    DAT_ram_00a632d0 = '\x01';
		  }
		  if (param3 != 0) {
		    uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar1,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    System_Reflection_FieldInfo__get_IsStatic
		              (uVar1,StringLiteral_25144,param3,
		               Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    uVar1 = AmplitudeNS_MiniJSON_Json__Deserialize(uVar1,0);
		    uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_4070,param2,uVar1,0);
		    Amplitude__get_Instance(param1,uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: prependUserProperty ---
		void Amplitude__prependUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64837 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4066);
		    DAT_ram_00a64837 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4066,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: prependUserProperty ---
		void Amplitude__prependUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64837 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4066);
		    DAT_ram_00a64837 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4066,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: prependUserProperty ---
		void Amplitude__prependUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64837 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4066);
		    DAT_ram_00a64837 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4066,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: prependUserProperty ---
		void Amplitude__prependUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64837 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4066);
		    DAT_ram_00a64837 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4066,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: prependUserProperty ---
		void Amplitude__prependUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64837 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4066);
		    DAT_ram_00a64837 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4066,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: prependUserProperty ---
		void Amplitude__prependUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64837 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4066);
		    DAT_ram_00a64837 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4066,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: prependUserProperty ---
		void Amplitude__prependUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64837 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4066);
		    DAT_ram_00a64837 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4066,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005E")]
	[Address(RVA = "0x5527", Offset = "0x5527", VA = "0x5527")]
	public void prependUserProperty(string property, double value)
	{
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005F")]
	[Address(RVA = "0x5528", Offset = "0x5528", VA = "0x5528")]
	public void prependUserProperty(string property, float value)
	{
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000060")]
	[Address(RVA = "0x5529", Offset = "0x5529", VA = "0x5529")]
	public void prependUserProperty(string property, int value)
	{
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000061")]
	[Address(RVA = "0x552A", Offset = "0x552A", VA = "0x552A")]
	public void prependUserProperty(string property, long value)
	{
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000062")]
	[Address(RVA = "0x552B", Offset = "0x552B", VA = "0x552B")]
	public void prependUserProperty(string property, string value)
	{
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000063")]
	[Address(RVA = "0x552C", Offset = "0x552C", VA = "0x552C")]
	public void prependUserProperty(string property, IDictionary<string, object> values)
	{
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000064")]
	public void prependUserProperty<T>(string property, IList<T> values)
	{
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000065")]
	[Address(RVA = "0x552D", Offset = "0x552D", VA = "0x552D")]
	public void prependUserProperty(string property, bool[] array)
	{
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000066")]
	[Address(RVA = "0x552E", Offset = "0x552E", VA = "0x552E")]
	public void prependUserProperty(string property, double[] array)
	{
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000067")]
	[Address(RVA = "0x552F", Offset = "0x552F", VA = "0x552F")]
	public void prependUserProperty(string property, float[] array)
	{
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x5530", Offset = "0x5530", VA = "0x5530")]
	public void prependUserProperty(string property, int[] array)
	{
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000069")]
	[Address(RVA = "0x5531", Offset = "0x5531", VA = "0x5531")]
	public void prependUserProperty(string property, long[] array)
	{
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006A")]
	[Address(RVA = "0x5532", Offset = "0x5532", VA = "0x5532")]
	public void prependUserProperty(string property, string[] array)
	{
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x5533", Offset = "0x5533", VA = "0x5533")]
	public void preInsertUserProperty(string property, bool value)
	{
		/* --- GHIDRA: preInsertUserProperty ---
		void Amplitude__preInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64844 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4064);
		    DAT_ram_00a64844 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4064,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: preInsertUserProperty ---
		void Amplitude__preInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64844 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4064);
		    DAT_ram_00a64844 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4064,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: preInsertUserProperty ---
		void Amplitude__preInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64844 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4064);
		    DAT_ram_00a64844 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4064,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: preInsertUserProperty ---
		void Amplitude__preInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64844 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4064);
		    DAT_ram_00a64844 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4064,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: preInsertUserProperty ---
		void Amplitude__preInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64844 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4064);
		    DAT_ram_00a64844 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4064,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: preInsertUserProperty ---
		void Amplitude__preInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64844 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4064);
		    DAT_ram_00a64844 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4064,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: preInsertUserProperty<__Il2CppFullySharedGenericType> ---
		void Amplitude__preInsertUserProperty___Il2CppFullySharedGenericType_
		               (undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a632cf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25144);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4068);
		    DAT_ram_00a632cf = '\x01';
		  }
		  if (param3 != 0) {
		    uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar1,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    System_Reflection_FieldInfo__get_IsStatic
		              (uVar1,StringLiteral_25144,param3,
		               Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    uVar1 = AmplitudeNS_MiniJSON_Json__Deserialize(uVar1,0);
		    uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_4068,param2,uVar1,0);
		    Amplitude__get_Instance(param1,uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: preInsertUserProperty ---
		void Amplitude__preInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64844 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4064);
		    DAT_ram_00a64844 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4064,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: preInsertUserProperty ---
		void Amplitude__preInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64844 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4064);
		    DAT_ram_00a64844 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4064,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: preInsertUserProperty ---
		void Amplitude__preInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64844 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4064);
		    DAT_ram_00a64844 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4064,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: preInsertUserProperty ---
		void Amplitude__preInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64844 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4064);
		    DAT_ram_00a64844 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4064,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: preInsertUserProperty ---
		void Amplitude__preInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64844 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4064);
		    DAT_ram_00a64844 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4064,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: preInsertUserProperty ---
		void Amplitude__preInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64844 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4064);
		    DAT_ram_00a64844 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4064,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: preInsertUserProperty ---
		void Amplitude__preInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64844 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4064);
		    DAT_ram_00a64844 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4064,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006C")]
	[Address(RVA = "0x5534", Offset = "0x5534", VA = "0x5534")]
	public void preInsertUserProperty(string property, double value)
	{
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006D")]
	[Address(RVA = "0x5535", Offset = "0x5535", VA = "0x5535")]
	public void preInsertUserProperty(string property, float value)
	{
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006E")]
	[Address(RVA = "0x5536", Offset = "0x5536", VA = "0x5536")]
	public void preInsertUserProperty(string property, int value)
	{
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006F")]
	[Address(RVA = "0x5537", Offset = "0x5537", VA = "0x5537")]
	public void preInsertUserProperty(string property, long value)
	{
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000070")]
	[Address(RVA = "0x5538", Offset = "0x5538", VA = "0x5538")]
	public void preInsertUserProperty(string property, string value)
	{
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000071")]
	[Address(RVA = "0x5539", Offset = "0x5539", VA = "0x5539")]
	public void preInsertUserProperty(string property, IDictionary<string, object> values)
	{
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000072")]
	public void preInsertUserProperty<T>(string property, IList<T> values)
	{
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000073")]
	[Address(RVA = "0x553A", Offset = "0x553A", VA = "0x553A")]
	public void preInsertUserProperty(string property, bool[] array)
	{
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000074")]
	[Address(RVA = "0x553B", Offset = "0x553B", VA = "0x553B")]
	public void preInsertUserProperty(string property, double[] array)
	{
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000075")]
	[Address(RVA = "0x553C", Offset = "0x553C", VA = "0x553C")]
	public void preInsertUserProperty(string property, float[] array)
	{
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000076")]
	[Address(RVA = "0x553D", Offset = "0x553D", VA = "0x553D")]
	public void preInsertUserProperty(string property, int[] array)
	{
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x553E", Offset = "0x553E", VA = "0x553E")]
	public void preInsertUserProperty(string property, long[] array)
	{
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000078")]
	[Address(RVA = "0x553F", Offset = "0x553F", VA = "0x553F")]
	public void preInsertUserProperty(string property, string[] array)
	{
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000079")]
	[Address(RVA = "0x5540", Offset = "0x5540", VA = "0x5540")]
	public void postInsertUserProperty(string property, bool value)
	{
		/* --- GHIDRA: postInsertUserProperty ---
		void Amplitude__postInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64851 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4070);
		    DAT_ram_00a64851 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4070,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: postInsertUserProperty ---
		void Amplitude__postInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64851 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4070);
		    DAT_ram_00a64851 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4070,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: postInsertUserProperty ---
		void Amplitude__postInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64851 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4070);
		    DAT_ram_00a64851 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4070,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: postInsertUserProperty ---
		void Amplitude__postInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64851 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4070);
		    DAT_ram_00a64851 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4070,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: postInsertUserProperty ---
		void Amplitude__postInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64851 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4070);
		    DAT_ram_00a64851 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4070,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: postInsertUserProperty ---
		void Amplitude__postInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64851 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4070);
		    DAT_ram_00a64851 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4070,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: postInsertUserProperty<__Il2CppFullySharedGenericType> ---
		void Amplitude__postInsertUserProperty___Il2CppFullySharedGenericType_
		               (undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a632ce == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25144);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4066);
		    DAT_ram_00a632ce = '\x01';
		  }
		  if (param3 != 0) {
		    uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar1,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    System_Reflection_FieldInfo__get_IsStatic
		              (uVar1,StringLiteral_25144,param3,
		               Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    uVar1 = AmplitudeNS_MiniJSON_Json__Deserialize(uVar1,0);
		    uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_4066,param2,uVar1,0);
		    Amplitude__get_Instance(param1,uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: postInsertUserProperty ---
		void Amplitude__postInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64851 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4070);
		    DAT_ram_00a64851 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4070,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: postInsertUserProperty ---
		void Amplitude__postInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64851 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4070);
		    DAT_ram_00a64851 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4070,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: postInsertUserProperty ---
		void Amplitude__postInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64851 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4070);
		    DAT_ram_00a64851 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4070,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: postInsertUserProperty ---
		void Amplitude__postInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64851 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4070);
		    DAT_ram_00a64851 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4070,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: postInsertUserProperty ---
		void Amplitude__postInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64851 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4070);
		    DAT_ram_00a64851 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4070,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: postInsertUserProperty ---
		void Amplitude__postInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64851 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4070);
		    DAT_ram_00a64851 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4070,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: postInsertUserProperty ---
		void Amplitude__postInsertUserProperty
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a64851 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4070);
		    DAT_ram_00a64851 = '\x01';
		  }
		  local_1 = (undefined1)param3;
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_4070,param2,uVar1,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007A")]
	[Address(RVA = "0x5541", Offset = "0x5541", VA = "0x5541")]
	public void postInsertUserProperty(string property, double value)
	{
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007B")]
	[Address(RVA = "0x5542", Offset = "0x5542", VA = "0x5542")]
	public void postInsertUserProperty(string property, float value)
	{
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007C")]
	[Address(RVA = "0x5543", Offset = "0x5543", VA = "0x5543")]
	public void postInsertUserProperty(string property, int value)
	{
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007D")]
	[Address(RVA = "0x5544", Offset = "0x5544", VA = "0x5544")]
	public void postInsertUserProperty(string property, long value)
	{
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007E")]
	[Address(RVA = "0x5545", Offset = "0x5545", VA = "0x5545")]
	public void postInsertUserProperty(string property, string value)
	{
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007F")]
	[Address(RVA = "0x5546", Offset = "0x5546", VA = "0x5546")]
	public void postInsertUserProperty(string property, IDictionary<string, object> values)
	{
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000080")]
	public void postInsertUserProperty<T>(string property, IList<T> values)
	{
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000081")]
	[Address(RVA = "0x5547", Offset = "0x5547", VA = "0x5547")]
	public void postInsertUserProperty(string property, bool[] array)
	{
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000082")]
	[Address(RVA = "0x5548", Offset = "0x5548", VA = "0x5548")]
	public void postInsertUserProperty(string property, double[] array)
	{
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000083")]
	[Address(RVA = "0x5549", Offset = "0x5549", VA = "0x5549")]
	public void postInsertUserProperty(string property, float[] array)
	{
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000084")]
	[Address(RVA = "0x554A", Offset = "0x554A", VA = "0x554A")]
	public void postInsertUserProperty(string property, int[] array)
	{
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000085")]
	[Address(RVA = "0x554B", Offset = "0x554B", VA = "0x554B")]
	public void postInsertUserProperty(string property, long[] array)
	{
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000086")]
	[Address(RVA = "0x554C", Offset = "0x554C", VA = "0x554C")]
	public void postInsertUserProperty(string property, string[] array)
	{
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000087")]
	[Address(RVA = "0x554D", Offset = "0x554D", VA = "0x554D")]
	public void removeUserProperty(string property, bool value)
	{
		/* --- GHIDRA: removeUserProperty ---
		void Amplitude__removeUserProperty
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a6485d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Amplitude_Log_string___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4069);
		    DAT_ram_00a6485d = '\x01';
		  }
		  Amplitude__Log_long_(param1,StringLiteral_4069,param2,param3,Method_Amplitude_Log_string___);
		  return;
		}
		*/

		/* --- GHIDRA: removeUserProperty ---
		void Amplitude__removeUserProperty
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a6485d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Amplitude_Log_string___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4069);
		    DAT_ram_00a6485d = '\x01';
		  }
		  Amplitude__Log_long_(param1,StringLiteral_4069,param2,param3,Method_Amplitude_Log_string___);
		  return;
		}
		*/

		/* --- GHIDRA: removeUserProperty ---
		void Amplitude__removeUserProperty
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a6485d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Amplitude_Log_string___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4069);
		    DAT_ram_00a6485d = '\x01';
		  }
		  Amplitude__Log_long_(param1,StringLiteral_4069,param2,param3,Method_Amplitude_Log_string___);
		  return;
		}
		*/

		/* --- GHIDRA: removeUserProperty ---
		void Amplitude__removeUserProperty
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a6485d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Amplitude_Log_string___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4069);
		    DAT_ram_00a6485d = '\x01';
		  }
		  Amplitude__Log_long_(param1,StringLiteral_4069,param2,param3,Method_Amplitude_Log_string___);
		  return;
		}
		*/

		/* --- GHIDRA: removeUserProperty ---
		void Amplitude__removeUserProperty
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a6485d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Amplitude_Log_string___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4069);
		    DAT_ram_00a6485d = '\x01';
		  }
		  Amplitude__Log_long_(param1,StringLiteral_4069,param2,param3,Method_Amplitude_Log_string___);
		  return;
		}
		*/

		/* --- GHIDRA: removeUserProperty ---
		void Amplitude__removeUserProperty
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a6485d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Amplitude_Log_string___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4069);
		    DAT_ram_00a6485d = '\x01';
		  }
		  Amplitude__Log_long_(param1,StringLiteral_4069,param2,param3,Method_Amplitude_Log_string___);
		  return;
		}
		*/

		/* --- GHIDRA: removeUserProperty<__Il2CppFullySharedGenericType> ---
		void Amplitude__removeUserProperty___Il2CppFullySharedGenericType_
		               (undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a632d1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25144);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4080);
		    DAT_ram_00a632d1 = '\x01';
		  }
		  if (param3 != 0) {
		    uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar1,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    System_Reflection_FieldInfo__get_IsStatic
		              (uVar1,StringLiteral_25144,param3,
		               Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    uVar1 = AmplitudeNS_MiniJSON_Json__Deserialize(uVar1,0);
		    uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_4080,param2,uVar1,0);
		    Amplitude__get_Instance(param1,uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: removeUserProperty ---
		void Amplitude__removeUserProperty
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a6485d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Amplitude_Log_string___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4069);
		    DAT_ram_00a6485d = '\x01';
		  }
		  Amplitude__Log_long_(param1,StringLiteral_4069,param2,param3,Method_Amplitude_Log_string___);
		  return;
		}
		*/

		/* --- GHIDRA: removeUserProperty ---
		void Amplitude__removeUserProperty
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a6485d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Amplitude_Log_string___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4069);
		    DAT_ram_00a6485d = '\x01';
		  }
		  Amplitude__Log_long_(param1,StringLiteral_4069,param2,param3,Method_Amplitude_Log_string___);
		  return;
		}
		*/

		/* --- GHIDRA: removeUserProperty ---
		void Amplitude__removeUserProperty
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a6485d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Amplitude_Log_string___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4069);
		    DAT_ram_00a6485d = '\x01';
		  }
		  Amplitude__Log_long_(param1,StringLiteral_4069,param2,param3,Method_Amplitude_Log_string___);
		  return;
		}
		*/

		/* --- GHIDRA: removeUserProperty ---
		void Amplitude__removeUserProperty
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a6485d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Amplitude_Log_string___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4069);
		    DAT_ram_00a6485d = '\x01';
		  }
		  Amplitude__Log_long_(param1,StringLiteral_4069,param2,param3,Method_Amplitude_Log_string___);
		  return;
		}
		*/

		/* --- GHIDRA: removeUserProperty ---
		void Amplitude__removeUserProperty
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a6485d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Amplitude_Log_string___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4069);
		    DAT_ram_00a6485d = '\x01';
		  }
		  Amplitude__Log_long_(param1,StringLiteral_4069,param2,param3,Method_Amplitude_Log_string___);
		  return;
		}
		*/

		/* --- GHIDRA: removeUserProperty ---
		void Amplitude__removeUserProperty
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a6485d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Amplitude_Log_string___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4069);
		    DAT_ram_00a6485d = '\x01';
		  }
		  Amplitude__Log_long_(param1,StringLiteral_4069,param2,param3,Method_Amplitude_Log_string___);
		  return;
		}
		*/

		/* --- GHIDRA: removeUserProperty ---
		void Amplitude__removeUserProperty
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a6485d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Amplitude_Log_string___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4069);
		    DAT_ram_00a6485d = '\x01';
		  }
		  Amplitude__Log_long_(param1,StringLiteral_4069,param2,param3,Method_Amplitude_Log_string___);
		  return;
		}
		*/

	}

	// Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000088")]
	[Address(RVA = "0x554E", Offset = "0x554E", VA = "0x554E")]
	public void removeUserProperty(string property, double value)
	{
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000089")]
	[Address(RVA = "0x554F", Offset = "0x554F", VA = "0x554F")]
	public void removeUserProperty(string property, float value)
	{
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008A")]
	[Address(RVA = "0x5550", Offset = "0x5550", VA = "0x5550")]
	public void removeUserProperty(string property, int value)
	{
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008B")]
	[Address(RVA = "0x5551", Offset = "0x5551", VA = "0x5551")]
	public void removeUserProperty(string property, long value)
	{
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008C")]
	[Address(RVA = "0x5552", Offset = "0x5552", VA = "0x5552")]
	public void removeUserProperty(string property, string value)
	{
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008D")]
	[Address(RVA = "0x5553", Offset = "0x5553", VA = "0x5553")]
	public void removeUserProperty(string property, IDictionary<string, object> values)
	{
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008E")]
	public void removeUserProperty<T>(string property, IList<T> values)
	{
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008F")]
	[Address(RVA = "0x5554", Offset = "0x5554", VA = "0x5554")]
	public void removeUserProperty(string property, bool[] array)
	{
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000090")]
	[Address(RVA = "0x5555", Offset = "0x5555", VA = "0x5555")]
	public void removeUserProperty(string property, double[] array)
	{
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000091")]
	[Address(RVA = "0x5556", Offset = "0x5556", VA = "0x5556")]
	public void removeUserProperty(string property, float[] array)
	{
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000092")]
	[Address(RVA = "0x5557", Offset = "0x5557", VA = "0x5557")]
	public void removeUserProperty(string property, int[] array)
	{
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000093")]
	[Address(RVA = "0x5558", Offset = "0x5558", VA = "0x5558")]
	public void removeUserProperty(string property, long[] array)
	{
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000094")]
	[Address(RVA = "0x5559", Offset = "0x5559", VA = "0x5559")]
	public void removeUserProperty(string property, string[] array)
	{
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000095")]
	[Address(RVA = "0x555A", Offset = "0x555A", VA = "0x555A")]
	private void setLibraryName(string libraryName)
	{
		/* --- GHIDRA: setLibraryName ---
		void Amplitude__setLibraryName(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6485f == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4077);
		    DAT_ram_00a6485f = '\x01';
		  }
		  param1_00 = func_ii_4419(StringLiteral_4077,param2,0);
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(param1_00,0);
		  }
		  return;
		}
		*/

	}

	// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000096")]
	[Address(RVA = "0x555B", Offset = "0x555B", VA = "0x555B")]
	private void setLibraryVersion(string libraryVersion)
	{
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000097")]
	[Address(RVA = "0x555C", Offset = "0x555C", VA = "0x555C")]
	public void startSession()
	{
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000098")]
	[Address(RVA = "0x555D", Offset = "0x555D", VA = "0x555D")]
	public void endSession()
	{
		/* --- GHIDRA: endSession ---
		void Amplitude__endSession(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a64860 == '\0') {
		    Mono_Security_ASN1__get_Item(&Amplitude_TypeInfo);
		    Mono_Security_ASN1__get_Item(&object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1965);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19803);
		    DAT_ram_00a64860 = '\x01';
		  }
		  **(undefined4 **)(Amplitude_TypeInfo + 0x5c) = StringLiteral_19803;
		  *(undefined4 *)(*(int *)(Amplitude_TypeInfo + 0x5c) + 4) = StringLiteral_1965;
		  uVar1 = unnamed_function_1417(object_TypeInfo);
		  *(undefined4 *)(*(int *)(Amplitude_TypeInfo + 0x5c) + 0xc) = uVar1;
		  return;
		}
		*/

	}

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string UnityLibraryName;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x4")]
	private static readonly string UnityLibraryVersion;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<string, Amplitude> instances;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0xC")]
	private static readonly object instanceLock;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x8")]
	public bool logging;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0xC")]
	private string instanceName;

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Instance ---
		void Amplitude__get_Instance(int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a647e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a647e1 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(param2,0);
		  }
		  return;
		}
		*/

}
