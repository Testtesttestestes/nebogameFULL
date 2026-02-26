using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using TMPro;
using Unity.Profiling;
using UnityEngine;

namespace Profile
{
	// Token: 0x020000BA RID: 186
	[Token(Token = "0x20000BA")]
	public class Profiler : MonoBehaviour
	{
		// Token: 0x06000718 RID: 1816 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x5B10", Offset = "0x5B10", VA = "0x5B10")]
		private static string BytesToMB(double value)
		{
		/* --- GHIDRA: BytesToMB ---
		undefined4 Profile_Profiler__BytesToMB(double param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  longlong local_8;
		  
		  if (ABS(param1) < 9.223372036854776e+18) {
		    local_8 = (longlong)param1;
		  }
		  else {
		    local_8 = -0x8000000000000000;
		  }
		  uVar1 = UnityEngine_GameObject__SetActive(&local_8,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x5B11", Offset = "0x5B11", VA = "0x5B11")]
		private static string CountToString(double value)
		{
		/* --- GHIDRA: CountToString ---
		void Profile_Profiler__CountToString(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  ushort local_14;
		  ushort local_12;
		  undefined8 local_10;
		  ushort local_2;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a5b819 == '\0') {
		    Mono_Security_ASN1__get_Item(&Unity_Profiling_ProfilerRecorder___TypeInfo);
		    DAT_ram_00a5b819 = '\x01';
		  }
		  uVar1 = Mono_Security_ASN1Convert__ToOid
		                    (Unity_Profiling_ProfilerRecorder___TypeInfo,
		                     *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xc));
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  if (0 < *(int *)(*(int *)(param1 + 0x1c) + 0xc)) {
		    do {
		      iVar2 = *(int *)(param1 + 0x18);
		      Unity_Profiling_ProfilerCategory__get_Scripts(&local_2,0);
		      local_12 = local_2;
		      local_14 = local_2;
		      local_10 = 0;
		      Unity_Profiling_ProfilerMarker_AutoScope__Dispose
		                (&local_10,&local_14,*(undefined4 *)(iVar3 * 8 + *(int *)(param1 + 0x1c) + 0x10),1,
		                 0x18,0);
		      *(undefined8 *)(iVar2 + iVar3 * 8 + 0x10) = local_10;
		      iVar3 = iVar3 + 1;
		    } while (iVar3 < *(int *)(*(int *)(param1 + 0x1c) + 0xc));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x5B12", Offset = "0x5B12", VA = "0x5B12")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		int Profile_Profiler__Awake(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5b81a == '\0') {
		    Mono_Security_ASN1__get_Item(&Profile_Profiler__CollectStatsCoroutine_d__8_TypeInfo);
		    DAT_ram_00a5b81a = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Profile_Profiler__CollectStatsCoroutine_d__8_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x5B13", Offset = "0x5B13", VA = "0x5B13")]
		private IEnumerator CollectStatsCoroutine()
		{
		/* --- GHIDRA: CollectStatsCoroutine ---
		void Profile_Profiler__CollectStatsCoroutine(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined8 local_8;
		  
		  local_8 = 0;
		  iVar3 = *(int *)(param1 + 0x18);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    iVar1 = 0;
		    do {
		      local_8 = *(undefined8 *)(iVar3 + iVar1 * 8 + 0x10);
		      Unity_Profiling_ProfilerRecorder___ctor(&local_8,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar3 + 0xc));
		  }
		  if (DAT_ram_00a5b81a == '\0') {
		    Mono_Security_ASN1__get_Item(&Profile_Profiler__CollectStatsCoroutine_d__8_TypeInfo);
		    DAT_ram_00a5b81a = '\x01';
		  }
		  iVar3 = unnamed_function_1417(Profile_Profiler__CollectStatsCoroutine_d__8_TypeInfo);
		  *(int *)(iVar3 + 0x10) = param1;
		  *(undefined4 *)(iVar3 + 8) = 0;
		  uVar2 = UnityEngine_MonoBehaviour__StartCoroutine(param1,iVar3,0);
		  *(undefined4 *)(param1 + 0x20) = uVar2;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x5B14", Offset = "0x5B14", VA = "0x5B14")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void Profile_Profiler__OnEnable(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined8 local_8;
		  
		  iVar2 = 0;
		  local_8 = 0;
		  iVar1 = *(int *)(param1 + 0x18);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      local_8 = *(undefined8 *)(iVar1 + iVar2 * 8 + 0x10);
		      Unity_Profiling_ProfilerRecorder__Start(&local_8,0);
		      iVar2 = iVar2 + 1;
		    } while (iVar2 < *(int *)(iVar1 + 0xc));
		  }
		  func_ii_20511(param1,*(undefined4 *)(param1 + 0x20),0);
		  *(undefined4 *)(param1 + 0x20) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x5B15", Offset = "0x5B15", VA = "0x5B15")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void Profile_Profiler__OnDisable(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined8 local_8;
		  
		  iVar2 = *(int *)(param1 + 0x18);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      local_8 = *(undefined8 *)(iVar2 + iVar1 * 8 + 0x10);
		      Unity_Profiling_ProfilerRecorder__GetLastValueAsDouble(&local_8,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x5B16", Offset = "0x5B16", VA = "0x5B16")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Profile_Profiler__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined8 local_50;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b81b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_double__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Profile_Profiler_BytesToMB__);
		    Mono_Security_ASN1__get_Item(&Method_Profile_Profiler_CountToString__);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_ValueTuple_string__Func_double__string_____TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_ValueTuple_string__Func_double__string____ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14809);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8313);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15405);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15404);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8312);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16368);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16367);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8314);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8311);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3434);
		    DAT_ram_00a5b81b = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  func_ii_12828(uVar1,500,0);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  iVar2 = Mono_Security_ASN1Convert__ToOid
		                    (System_ValueTuple_string__Func_double__string_____TypeInfo,10);
		  uVar1 = unnamed_function_1417(System_Func_double__string__TypeInfo);
		  System_Func_double__int___Invoke(uVar1,0,Method_Profile_Profiler_BytesToMB__,0);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_14809,uVar1,
		             Method_System_ValueTuple_string__Func_double__string____ctor__);
		  *(undefined8 *)(iVar2 + 0x10) = local_8;
		  uVar1 = unnamed_function_1417(System_Func_double__string__TypeInfo);
		  System_Func_double__int___Invoke(uVar1,0,Method_Profile_Profiler_BytesToMB__,0);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_16368,uVar1,
		             Method_System_ValueTuple_string__Func_double__string____ctor__);
		  *(undefined8 *)(iVar2 + 0x18) = local_10;
		  uVar1 = unnamed_function_1417(System_Func_double__string__TypeInfo);
		  System_Func_double__int___Invoke(uVar1,0,Method_Profile_Profiler_BytesToMB__,0);
		  local_18 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,StringLiteral_16367,uVar1,
		             Method_System_ValueTuple_string__Func_double__string____ctor__);
		  *(undefined8 *)(iVar2 + 0x20) = local_18;
		  uVar1 = unnamed_function_1417(System_Func_double__string__TypeInfo);
		  System_Func_double__int___Invoke(uVar1,0,Method_Profile_Profiler_BytesToMB__,0);
		  local_20 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_20,StringLiteral_15405,uVar1,
		             Method_System_ValueTuple_string__Func_double__string____ctor__);
		  *(undefined8 *)(iVar2 + 0x28) = local_20;
		  uVar1 = unnamed_function_1417(System_Func_double__string__TypeInfo);
		  System_Func_double__int___Invoke(uVar1,0,Method_Profile_Profiler_BytesToMB__,0);
		  local_28 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_28,StringLiteral_8313,uVar1,
		             Method_System_ValueTuple_string__Func_double__string____ctor__);
		  *(undefined8 *)(iVar2 + 0x30) = local_28;
		  uVar1 = unnamed_function_1417(System_Func_double__string__TypeInfo);
		  System_Func_double__int___Invoke(uVar1,0,Method_Profile_Profiler_BytesToMB__,0);
		  local_30 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_30,StringLiteral_8314,uVar1,
		             Method_System_ValueTuple_string__Func_double__string____ctor__);
		  *(undefined8 *)(iVar2 + 0x38) = local_30;
		  uVar1 = unnamed_function_1417(System_Func_double__string__TypeInfo);
		  System_Func_double__int___Invoke(uVar1,0,Method_Profile_Profiler_BytesToMB__,0);
		  local_38 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_38,StringLiteral_8311,uVar1,
		             Method_System_ValueTuple_string__Func_double__string____ctor__);
		  *(undefined8 *)(iVar2 + 0x40) = local_38;
		  uVar1 = unnamed_function_1417(System_Func_double__string__TypeInfo);
		  System_Func_double__int___Invoke(uVar1,0,Method_Profile_Profiler_CountToString__,0);
		  local_40 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_40,StringLiteral_15404,uVar1,
		             Method_System_ValueTuple_string__Func_double__string____ctor__);
		  *(undefined8 *)(iVar2 + 0x48) = local_40;
		  uVar1 = unnamed_function_1417(System_Func_double__string__TypeInfo);
		  System_Func_double__int___Invoke(uVar1,0,Method_Profile_Profiler_CountToString__,0);
		  local_48 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_48,StringLiteral_3434,uVar1,
		             Method_System_ValueTuple_string__Func_double__string____ctor__);
		  *(undefined8 *)(iVar2 + 0x50) = local_48;
		  uVar1 = unnamed_function_1417(System_Func_double__string__TypeInfo);
		  System_Func_double__int___Invoke(uVar1,0,Method_Profile_Profiler_CountToString__,0);
		  local_50 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_50,StringLiteral_8312,uVar1,
		             Method_System_ValueTuple_string__Func_double__string____ctor__);
		  *(undefined8 *)(iVar2 + 0x58) = local_50;
		  *(int *)(param1 + 0x1c) = iVar2;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x5B17", Offset = "0x5B17", VA = "0x5B17")]
		public Profiler()
		{
		}

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _stats;

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x14")]
		private StringBuilder _output;

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x18")]
		private ProfilerRecorder[] _recorders;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x1C")]
		[TupleElementNames(new string[]
		{
			"Name",
			"Format"
		})]
		private ValueTuple<string, Func<double, string>>[] _recorderNames;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x20")]
		private Coroutine _routine;
	}
}
