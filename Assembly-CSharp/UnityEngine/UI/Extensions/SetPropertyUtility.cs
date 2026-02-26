using System;
using Il2CppDummyDll;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	internal static class SetPropertyUtility
	{
		// Token: 0x0600017B RID: 379 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x5640", Offset = "0x5640", VA = "0x5640")]
		public static bool SetColor(ref Color currentValue, Color newValue)
		{
			return default(bool);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x600017C")]
		public static bool SetStruct<T>(ref T currentValue, T newValue) where T : struct
		{
			return default(bool);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x600017D")]
		public static bool SetClass<T>(ref T currentValue, T newValue) where T : class
		{
			return default(bool);
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: SetEquatableStruct<__Il2CppFullySharedGenericType> ---
		uint TMPro_SetPropertyUtility__SetEquatableStruct___Il2CppFullySharedGenericType_
		               (undefined1 *param1,undefined4 param2,int param3)
		
		{
		  undefined4 param2_00;
		  uint uVar1;
		  int iVar2;
		  undefined1 local_1;
		  
		  iVar2 = *(int *)(param3 + 0x1c);
		  if (iVar2 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		    iVar2 = *(int *)(param3 + 0x1c);
		  }
		  local_1 = (undefined1)param2;
		  param2_00 = func_ii_1081(*(undefined4 *)(iVar2 + 4),&local_1);
		  if (*(int *)(DAT_ram_00a66944 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a66944);
		  }
		  uVar1 = System_Boolean__ToString(param1,param2_00,*(undefined4 *)(*(int *)(param3 + 0x1c) + 8));
		  if (uVar1 == 0) {
		    *param1 = (undefined1)param2;
		  }
		  return uVar1 ^ 1;
		}
		*/


		/* --- GHIDRA: SetStruct<bool> ---
		uint TMPro_SetPropertyUtility__SetStruct_bool_(undefined2 *param1,undefined4 param2,int param3)
		
		{
		  undefined4 param2_00;
		  uint uVar1;
		  int iVar2;
		  undefined2 local_2;
		  
		  iVar2 = *(int *)(param3 + 0x1c);
		  if (iVar2 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		    iVar2 = *(int *)(param3 + 0x1c);
		  }
		  local_2 = (undefined2)param2;
		  param2_00 = func_ii_1081(*(undefined4 *)(iVar2 + 4),&local_2);
		  if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a66974);
		  }
		  uVar1 = System_Char__GetHashCode(param1,param2_00,*(undefined4 *)(*(int *)(param3 + 0x1c) + 8));
		  if (uVar1 == 0) {
		    *param1 = (undefined2)param2;
		  }
		  return uVar1 ^ 1;
		}
		*/


		/* --- GHIDRA: SetStruct<char> ---
		uint TMPro_SetPropertyUtility__SetStruct_char_(undefined4 *param1,undefined4 param2,int param3)
		
		{
		  undefined4 param2_00;
		  uint uVar1;
		  int iVar2;
		  undefined4 local_4;
		  
		  iVar2 = *(int *)(param3 + 0x1c);
		  if (iVar2 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		    iVar2 = *(int *)(param3 + 0x1c);
		  }
		  local_4 = param2;
		  param2_00 = func_ii_1081(*(undefined4 *)(iVar2 + 4),&local_4);
		  uVar1 = System_Int32__CompareTo(param1,param2_00,*(undefined4 *)(*(int *)(param3 + 0x1c) + 8));
		  if (uVar1 == 0) {
		    *param1 = param2;
		  }
		  return uVar1 ^ 1;
		}
		*/


		/* --- GHIDRA: SetStruct<int> ---
		uint TMPro_SetPropertyUtility__SetStruct_int_(undefined4 *param1,undefined4 param2,int param3)
		
		{
		  undefined4 param2_00;
		  uint uVar1;
		  int iVar2;
		  int local_10 [3];
		  undefined4 local_4;
		  
		  iVar2 = *(int *)(param3 + 0x1c);
		  if (iVar2 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		    iVar2 = *(int *)(param3 + 0x1c);
		  }
		  local_4 = param2;
		  param2_00 = func_ii_1081(*(undefined4 *)(iVar2 + 4),&local_4);
		  local_10[0] = *(int *)(*(int *)(param3 + 0x1c) + 4);
		  if ((*(byte *)(local_10[0] + 0xbd) & 1) == 0) {
		    local_10[0] = func_ii_1079(local_10[0]);
		  }
		  local_10[1] = 0xffffffff;
		  local_10[2] = *param1;
		  uVar1 = System_Enum__get_hashcode(local_10,param2_00,0);
		  if (uVar1 == 0) {
		    *param1 = param2;
		  }
		  return uVar1 ^ 1;
		}
		*/


		/* --- GHIDRA: SetStruct<Int32Enum> ---
		uint TMPro_SetPropertyUtility__SetStruct_Int32Enum_(float *param1,float param2,int param3)
		
		{
		  undefined4 param2_00;
		  uint uVar1;
		  int iVar2;
		  float4 local_4;
		  
		  iVar2 = *(int *)(param3 + 0x1c);
		  if (iVar2 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		    iVar2 = *(int *)(param3 + 0x1c);
		  }
		  local_4 = (float4)param2;
		  param2_00 = func_ii_1081(*(undefined4 *)(iVar2 + 4),&local_4);
		  uVar1 = System_Single__CompareTo(param1,param2_00,*(undefined4 *)(*(int *)(param3 + 0x1c) + 8));
		  if (uVar1 == 0) {
		    *param1 = param2;
		  }
		  return uVar1 ^ 1;
		}
		*/


		/* --- GHIDRA: SetStruct<float> ---
		uint TMPro_SetPropertyUtility__SetStruct_float_(undefined4 param1,undefined4 param2,int param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int iVar3;
		  int param3_00;
		  undefined1 local_10 [8];
		  undefined4 local_8;
		  byte local_1;
		  
		  iVar2 = *(int *)(param3 + 0x1c);
		  if (iVar2 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		    iVar2 = *(int *)(param3 + 0x1c);
		  }
		  iVar3 = *(int *)(iVar2 + 4);
		  param3_00 = *(int *)(iVar3 + 0x84);
		  iVar1 = param3_00;
		  if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		    iVar1 = func_ii_1079(iVar3);
		    iVar2 = *(int *)(param3 + 0x1c);
		    iVar1 = *(int *)(iVar1 + 0x84);
		  }
		  param2_00 = unnamed_function_713
		                        ((int)(local_10 + -(iVar1 + 0x17U & 0xfffffff0)) -
		                         (param3_00 + 0xfU & 0xfffffff0),param2,param3_00);
		  local_8 = func_ii_1081(*(undefined4 *)(iVar2 + 4),param2_00);
		  iVar3 = *(int *)(param3 + 0x1c);
		  iVar2 = *(int *)(iVar3 + 4);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		    iVar3 = *(int *)(param3 + 0x1c);
		  }
		  func_ii_8296(iVar2,*(undefined4 *)(iVar3 + 8),local_10 + -(iVar1 + 0x17U & 0xfffffff0),param1,
		               &local_8,&local_1);
		  if (local_1 == 0) {
		    unnamed_function_713(param2_00,param2,param3_00);
		    unnamed_function_773(param1,param2,param3_00);
		    iVar2 = *(int *)(*(int *)(param3 + 0x1c) + 4);
		    if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		      func_ii_1079(iVar2);
		    }
		  }
		  return (uint)(local_1 == 0);
		}
		*/


		/* --- GHIDRA: SetClass<object> ---
		uint TMPro_SetPropertyUtility__SetClass_object_(undefined4 param1,undefined4 ****param2,int param3)
		
		{
		  int iVar1;
		  undefined4 *param1_00;
		  int iVar2;
		  int iVar3;
		  int param3_00;
		  int param1_01;
		  undefined4 ****param2_00;
		  undefined1 local_10 [4];
		  undefined4 ***local_c;
		  undefined4 *local_8;
		  byte local_1;
		  
		  iVar2 = *(int *)(param3 + 0x1c);
		  local_c = param2;
		  if (iVar2 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		    iVar2 = *(int *)(param3 + 0x1c);
		  }
		  iVar3 = *(int *)(iVar2 + 4);
		  param3_00 = *(int *)(iVar3 + 0x84);
		  iVar1 = param3_00;
		  if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		    iVar1 = func_ii_1079(iVar3);
		    iVar2 = *(int *)(param3 + 0x1c);
		    iVar3 = *(int *)(iVar2 + 4);
		    iVar1 = *(int *)(iVar1 + 0x84);
		  }
		  param2_00 = param2;
		  if (-1 < *(int *)(iVar3 + 0x14)) {
		    param2_00 = &local_c;
		  }
		  param1_00 = (undefined4 *)
		              unnamed_function_713
		                        ((int)(local_10 + -(iVar1 + 0x17U & 0xfffffff0)) -
		                         (param3_00 + 0xfU & 0xfffffff0),param2_00,param3_00);
		  param1_01 = *(int *)(iVar2 + 4);
		  iVar3 = param1_01;
		  if ((*(byte *)(param1_01 + 0xbd) & 1) == 0) {
		    iVar3 = func_ii_1079(param1_01);
		    iVar2 = *(int *)(param3 + 0x1c);
		    param1_01 = *(int *)(iVar2 + 4);
		  }
		  local_8 = param1_00;
		  if (-1 < *(int *)(param1_01 + 0x14)) {
		    local_8 = (undefined4 *)*param1_00;
		  }
		  func_ii_8296(iVar3,*(undefined4 *)(iVar2 + 0xc),local_10 + -(iVar1 + 0x17U & 0xfffffff0),param1,
		               &local_8,&local_1);
		  if (local_1 == 0) {
		    if (-1 < *(int *)(*(int *)(*(int *)(param3 + 0x1c) + 4) + 0x14)) {
		      param2 = &local_c;
		    }
		    unnamed_function_713(param1_00,param2,param3_00);
		    unnamed_function_773(param1,param2,param3_00);
		    iVar2 = *(int *)(*(int *)(param3 + 0x1c) + 4);
		    if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		      func_ii_1079(iVar2);
		    }
		  }
		  return (uint)(local_1 == 0);
		}
		*/

}
