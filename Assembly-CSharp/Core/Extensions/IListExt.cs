using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Extensions
{
	// Token: 0x02000F0C RID: 3852
	[Token(Token = "0x2000F0C")]
	public static class IListExt
	{
		// Token: 0x06005D30 RID: 23856 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D30")]
		public static T GetRandom<T>(this IList<T> array)
		{
		/* --- GHIDRA: GetRandom<__Il2CppFullySharedGenericType> ---
		uint Core_Extensions_IListExt__GetRandom___Il2CppFullySharedGenericType_
		               (int *param1,undefined4 param2,int param3)
		
		{
		  ushort uVar1;
		  uint uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  uint *puVar5;
		  undefined4 param2_00;
		  undefined4 uVar6;
		  byte *pbVar7;
		  int iVar8;
		  int param3_00;
		  int iVar9;
		  int param3_01;
		  byte *param2_01;
		  int param1_01;
		  int param2_02;
		  int iVar10;
		  undefined4 *puVar11;
		  int iVar12;
		  int iVar13;
		  uint uVar14;
		  int *piVar15;
		  int iVar16;
		  byte local_10 [4];
		  byte *local_c;
		  byte *local_8;
		  byte local_4;
		  
		  iVar8 = *(int *)(param3 + 0x1c);
		  if (iVar8 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		    iVar8 = *(int *)(param3 + 0x1c);
		  }
		  param3_00 = *(int *)(*(int *)(iVar8 + 0xc) + 0x84);
		  iVar9 = *(int *)(iVar8 + 0x14);
		  param3_01 = *(int *)(iVar9 + 0x84);
		  uVar1 = *(ushort *)(iVar9 + 0xbd);
		  iVar3 = param3_01;
		  if ((uVar1 & 1) == 0) {
		    iVar3 = func_ii_1079(iVar9);
		    iVar8 = *(int *)(param3 + 0x1c);
		    iVar9 = *(int *)(iVar8 + 0x14);
		    uVar1 = *(ushort *)(iVar9 + 0xbd);
		    iVar3 = *(int *)(iVar3 + 0x84);
		  }
		  iVar3 = (int)local_10 - (iVar3 + 0x17U & 0xfffffff0);
		  if ((uVar1 & 1) == 0) {
		    iVar9 = func_ii_1079(iVar9);
		    iVar8 = *(int *)(param3 + 0x1c);
		  }
		  iVar9 = iVar3 - (*(int *)(iVar9 + 0x84) + 0x17U & 0xfffffff0);
		  uVar14 = param3_00 + 0xfU & 0xfffffff0;
		  param2_01 = (byte *)(iVar9 - uVar14);
		  param1_01 = (int)param2_01 - uVar14;
		  uVar14 = param3_01 + 0xfU & 0xfffffff0;
		  param2_02 = param1_01 - uVar14;
		  iVar10 = (param2_02 - uVar14) - uVar14;
		  uVar4 = unnamed_function_714(iVar10,0,param3_01);
		  param1_00 = unnamed_function_714(iVar10 - uVar14,0,param3_01);
		  iVar8 = *(int *)(iVar8 + 4);
		  if ((*(byte *)(iVar8 + 0xbd) & 1) == 0) {
		    iVar8 = func_ii_1079(iVar8);
		  }
		  _local_4 = 0;
		  iVar10 = *param1;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (iVar8 == *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8)) {
		        iVar8 = iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0;
		        goto code_r0x8206df4d;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		  }
		  iVar8 = func_ii_1080(param1,iVar8,0);
		code_r0x8206df4d:
		  local_c = &local_4;
		  iVar8 = *(int *)(iVar8 + 4);
		  local_8 = param2_01;
		  (**(code **)((ulonglong)*(uint *)(iVar8 + 8) * 4))
		            (*(undefined4 *)(iVar8 + 4),iVar8,param1,&local_c,param2_01);
		  puVar11 = *(undefined4 **)(*(int *)(param3 + 0x1c) + 0x10);
		  local_c = param2_01;
		  if (-1 < *(int *)(*(int *)(*(int *)(param3 + 0x1c) + 0xc) + 0x14)) {
		    local_c = *(byte **)param2_01;
		  }
		  local_8 = (byte *)param2_02;
		  (**(code **)((ulonglong)(uint)puVar11[2] * 4))(*puVar11,puVar11,param2,&local_c,param2_02);
		  uVar4 = unnamed_function_713(uVar4,param2_02,param3_01);
		  iVar8 = 1;
		  do {
		    iVar10 = *(int *)(*(int *)(param3 + 0x1c) + 0x20);
		    if ((*(byte *)(iVar10 + 0xbd) & 1) == 0) {
		      iVar10 = func_ii_1079(iVar10);
		    }
		    iVar16 = *param1;
		    if (*(ushort *)(iVar16 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar15 = (int *)(*(int *)(iVar16 + 0x58) + uVar2 * 8);
		        if (iVar10 == *piVar15) {
		          puVar5 = (uint *)(iVar16 + piVar15[1] * 8 + 0xc0);
		          goto code_r0x8206e05c;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar16 + 0xb6) != uVar2);
		    }
		    puVar5 = (uint *)func_ii_1080(param1,iVar10,0);
		code_r0x8206e05c:
		    iVar10 = (**(code **)((ulonglong)*puVar5 * 4))(param1,puVar5[1]);
		    if (iVar10 <= iVar8) {
		code_r0x8206e275:
		      return (uint)(iVar10 <= iVar8);
		    }
		    iVar16 = *(int *)(*(int *)(param3 + 0x1c) + 4);
		    if ((*(byte *)(iVar16 + 0xbd) & 1) == 0) {
		      iVar16 = func_ii_1079(iVar16);
		    }
		    iVar12 = *param1;
		    _local_4 = iVar8;
		    if (*(ushort *)(iVar12 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar15 = (int *)(*(int *)(iVar12 + 0x58) + uVar2 * 8);
		        if (iVar16 == *piVar15) {
		          iVar16 = iVar12 + piVar15[1] * 8 + 0xc0;
		          goto code_r0x8206e0f0;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar12 + 0xb6) != uVar2);
		    }
		    iVar16 = func_ii_1080(param1,iVar16,0);
		code_r0x8206e0f0:
		    local_c = &local_4;
		    iVar16 = *(int *)(iVar16 + 4);
		    local_8 = param2_01;
		    (**(code **)((ulonglong)*(uint *)(iVar16 + 8) * 4))
		              (*(undefined4 *)(iVar16 + 4),iVar16,param1,&local_c,param2_01);
		    local_c = (byte *)unnamed_function_713(param1_01,param2_01,param3_00);
		    puVar11 = *(undefined4 **)(*(int *)(param3 + 0x1c) + 0x10);
		    if (-1 < *(int *)(*(int *)(*(int *)(param3 + 0x1c) + 0xc) + 0x14)) {
		      local_c = *(byte **)local_c;
		    }
		    local_8 = (byte *)param2_02;
		    (**(code **)((ulonglong)(uint)puVar11[2] * 4))(*puVar11,puVar11,param2,&local_c,param2_02);
		    param2_00 = unnamed_function_713(param1_00,param2_02,param3_01);
		    uVar6 = unnamed_function_713(param2_02 - uVar14,param2_02,param3_01);
		    pbVar7 = (byte *)func_ii_1081(*(undefined4 *)(*(int *)(param3 + 0x1c) + 0x14),uVar6);
		    iVar12 = *(int *)(param3 + 0x1c);
		    iVar16 = *(int *)(iVar12 + 0x14);
		    if ((*(byte *)(iVar16 + 0xbd) & 1) == 0) {
		      iVar16 = func_ii_1079(iVar16);
		      iVar12 = *(int *)(param3 + 0x1c);
		    }
		    local_c = pbVar7;
		    func_ii_8296(iVar16,*(undefined4 *)(iVar12 + 0x18),iVar3,uVar4,&local_c,&local_4);
		    if (local_4 == 0) {
		      uVar6 = unnamed_function_713(param2_02,param2_00,param3_01);
		      iVar12 = func_ii_1081(*(undefined4 *)(*(int *)(param3 + 0x1c) + 0x14),uVar6);
		      iVar13 = *(int *)(param3 + 0x1c);
		      iVar16 = *(int *)(iVar13 + 0x14);
		      if ((*(byte *)(iVar16 + 0xbd) & 1) == 0) {
		        iVar16 = func_ii_1079(iVar16);
		        iVar13 = *(int *)(param3 + 0x1c);
		      }
		      _local_4 = iVar12;
		      func_ii_8296(iVar16,*(undefined4 *)(iVar13 + 0x1c),iVar9,uVar4,&local_4,&local_c);
		      if (0 < (int)local_c) goto code_r0x8206e275;
		    }
		    unnamed_function_713(param2_02,param2_00,param3_01);
		    unnamed_function_713(uVar4,param2_00,param3_01);
		    iVar8 = iVar8 + 1;
		  } while( true );
		}
		*/

		/* --- GHIDRA: GetRandom<uint> ---
		void Core_Extensions_IListExt__GetRandom_uint_(int *param1,undefined4 param2,int param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  int iVar3;
		  undefined1 *param2_01;
		  int param3_00;
		  int iVar4;
		  undefined1 local_10 [4];
		  undefined4 *local_c;
		  undefined1 *local_8;
		  undefined4 local_4;
		  
		  iVar3 = *(int *)(param3 + 0x1c);
		  if (iVar3 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		    iVar3 = *(int *)(param3 + 0x1c);
		  }
		  param3_00 = *(int *)(*(int *)(iVar3 + 0x10) + 0x84);
		  param2_01 = local_10 + -(param3_00 + 0xfU & 0xfffffff0);
		  iVar3 = *(int *)(iVar3 + 4);
		  if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		    iVar3 = func_ii_1079(iVar3);
		  }
		  iVar4 = *param1;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (iVar3 == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8206db84;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,iVar3,0);
		code_r0x8206db84:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  local_8 = param2_01;
		  if (iVar3 == 1) {
		    iVar3 = **(int **)(param3 + 0x1c);
		    if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		      iVar3 = func_ii_1079(iVar3);
		    }
		    uVar1 = 0;
		    local_4 = 0;
		    iVar4 = *param1;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (iVar3 == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          iVar3 = iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0;
		          goto code_r0x8206dc26;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    iVar3 = func_ii_1080(param1,iVar3,0);
		code_r0x8206dc26:
		    local_c = &local_4;
		    iVar3 = *(int *)(iVar3 + 4);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 8) * 4))
		              (*(undefined4 *)(iVar3 + 4),iVar3,param1,&local_c,param2_01);
		  }
		  else {
		    iVar3 = (*(int **)(param3 + 0x1c))[1];
		    if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		      iVar3 = func_ii_1079(iVar3);
		    }
		    iVar4 = *param1;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (iVar3 == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8206dcd9;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1,iVar3,0);
		code_r0x8206dcd9:
		    param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		    local_4 = UnityEngine_Random__Range(0,param2_00,0);
		    iVar3 = **(int **)(param3 + 0x1c);
		    if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		      iVar3 = func_ii_1079(iVar3);
		    }
		    iVar4 = *param1;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (iVar3 == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          iVar3 = iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0;
		          goto code_r0x8206dd74;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    iVar3 = func_ii_1080(param1,iVar3,0);
		code_r0x8206dd74:
		    local_c = &local_4;
		    iVar3 = *(int *)(iVar3 + 4);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 8) * 4))
		              (*(undefined4 *)(iVar3 + 4),iVar3,param1,&local_c,param2_01);
		  }
		  unnamed_function_713(param2,param2_01,param3_00);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005D31 RID: 23857 RVA: 0x00010CB0 File Offset: 0x0000EEB0
		[Token(Token = "0x6005D31")]
		public static int GetIndexRandom<T>(this IList<T> array, out T item)
		{
		/* --- GHIDRA: GetIndexRandom<__Il2CppFullySharedGenericType> ---
		undefined4
		Core_Extensions_IListExt__GetIndexRandom___Il2CppFullySharedGenericType_(int *param1,int param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  
		  iVar4 = *(int *)(param2 + 0x1c);
		  if (iVar4 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param2);
		    iVar4 = *(int *)(param2 + 0x1c);
		  }
		  iVar4 = *(int *)(iVar4 + 4);
		  if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		    iVar4 = func_ii_1079(iVar4);
		  }
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (iVar4 == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8206d8fb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,iVar4,0);
		code_r0x8206d8fb:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  if (iVar4 == 1) {
		    iVar4 = **(int **)(param2 + 0x1c);
		    if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		      iVar4 = func_ii_1079(iVar4);
		    }
		    iVar5 = *param1;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (iVar4 == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          uVar3 = 0;
		          puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8206dab0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    uVar3 = 0;
		    puVar2 = (uint *)func_ii_1080(param1,iVar4,0);
		  }
		  else {
		    iVar4 = (*(int **)(param2 + 0x1c))[1];
		    if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		      iVar4 = func_ii_1079(iVar4);
		    }
		    iVar5 = *param1;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (iVar4 == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8206da1e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1,iVar4,0);
		code_r0x8206da1e:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		    uVar3 = UnityEngine_Random__Range(0,uVar3,0);
		    iVar4 = **(int **)(param2 + 0x1c);
		    if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		      iVar4 = func_ii_1079(iVar4);
		    }
		    iVar5 = *param1;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (iVar4 == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8206dab0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1,iVar4,0);
		  }
		code_r0x8206dab0:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1,uVar3,puVar2[1]);
		  return uVar3;
		}
		*/

			return 0;
		}

		// Token: 0x06005D32 RID: 23858 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D32")]
		public static TListElement BinarySearch<TListElement, SValue>(this IList<TListElement> list, Func<TListElement, SValue> getter, SValue searchValue) where SValue : IComparable
		{
			return null;
		}

		// Token: 0x06005D33 RID: 23859 RVA: 0x00010CC8 File Offset: 0x0000EEC8
		[Token(Token = "0x6005D33")]
		public static bool IsSorted<TListElement, SValue>(this IList<TListElement> list, Func<TListElement, SValue> getter) where SValue : IComparable
		{
			return default(bool);
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: BinarySearch<object, uint> ---
		undefined4
		Core_Extensions_IListExt__BinarySearch_object__uint_
		          (int *param1,int param2,undefined8 param3,int param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  int *piVar9;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar7 = 0;
		  iVar4 = *(int *)(param4 + 0x1c);
		  if (iVar4 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param4);
		    iVar4 = *(int *)(param4 + 0x1c);
		  }
		  local_8 = 0;
		  iVar4 = *(int *)(iVar4 + 4);
		  if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		    iVar4 = func_ii_1079(iVar4);
		  }
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (iVar4 == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8206d0bf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,iVar4,0);
		code_r0x8206d0bf:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  iVar4 = iVar4 + -1;
		  if (-1 < iVar4) {
		code_r0x8206d0e2:
		    do {
		      iVar5 = **(int **)(param4 + 0x1c);
		      if ((*(byte *)(iVar5 + 0xbd) & 1) == 0) {
		        iVar5 = func_ii_1079(iVar5);
		      }
		      iVar6 = (iVar4 - iVar7) / 2 + iVar7;
		      iVar8 = *param1;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		          if (iVar5 == *piVar9) {
		            puVar2 = (uint *)(iVar8 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x8206d170;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param1,iVar5,0);
		code_r0x8206d170:
		      uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1,iVar6,puVar2[1]);
		      local_8 = (**(code **)((ulonglong)*(uint *)(param2 + 0xc) * 4))
		                          (*(undefined4 *)(param2 + 0x20),uVar3,*(undefined4 *)(param2 + 0x14));
		      local_10 = param3;
		      param2_00 = func_ii_1081(*(undefined4 *)(*(int *)(param4 + 0x1c) + 0x1c),&local_10);
		      iVar5 = System_UInt64__CompareTo
		                        (&local_8,param2_00,*(undefined4 *)(*(int *)(param4 + 0x1c) + 0x20));
		      if (iVar5 != 0) {
		        return uVar3;
		      }
		      local_8 = (**(code **)((ulonglong)*(uint *)(param2 + 0xc) * 4))
		                          (*(undefined4 *)(param2 + 0x20),uVar3,*(undefined4 *)(param2 + 0x14));
		      local_10 = param3;
		      uVar3 = func_ii_1081(*(undefined4 *)(*(int *)(param4 + 0x1c) + 0x1c),&local_10);
		      iVar5 = System_UInt32__System_IConvertible_ToType
		                        (&local_8,uVar3,*(undefined4 *)(*(int *)(param4 + 0x1c) + 0x24));
		      if (0 < iVar5) {
		        iVar4 = iVar6 + -1;
		        if (iVar4 < iVar7) {
		          return 0;
		        }
		        goto code_r0x8206d0e2;
		      }
		      iVar7 = iVar6 + 1;
		    } while (iVar7 <= iVar4);
		  }
		  return 0;
		}
		*/


		/* --- GHIDRA: BinarySearch<object, ulong> ---
		/* WARNING: Type propagation algorithm not settling */
		
		void Core_Extensions_IListExt__BinarySearch_object__ulong_
		               (int *param1,undefined4 param2,byte *******param3,undefined4 param4,int param5)
		
		{
		  ushort uVar1;
		  uint uVar2;
		  int iVar3;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 param2_00;
		  byte **ppbVar7;
		  int iVar8;
		  int iVar9;
		  int param3_00;
		  int param3_01;
		  int param2_01;
		  int param2_02;
		  int iVar10;
		  int iVar11;
		  undefined4 *puVar12;
		  uint uVar13;
		  uint uVar14;
		  int iVar15;
		  byte *******pppppppbVar16;
		  int iVar17;
		  int *piVar18;
		  byte *******local_10;
		  byte **local_c;
		  int local_8;
		  byte local_4;
		  
		  iVar17 = 0;
		  iVar8 = *(int *)(param5 + 0x1c);
		  local_10 = param3;
		  if (iVar8 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param5);
		    iVar8 = *(int *)(param5 + 0x1c);
		  }
		  iVar9 = *(int *)(iVar8 + 0x1c);
		  param3_00 = *(int *)(iVar9 + 0x84);
		  param3_01 = *(int *)(*(int *)(iVar8 + 0x10) + 0x84);
		  uVar1 = *(ushort *)(iVar9 + 0xbd);
		  iVar3 = param3_00;
		  if ((uVar1 & 1) == 0) {
		    iVar3 = func_ii_1079(iVar9);
		    iVar8 = *(int *)(param5 + 0x1c);
		    iVar9 = *(int *)(iVar8 + 0x1c);
		    uVar1 = *(ushort *)(iVar9 + 0xbd);
		    iVar3 = *(int *)(iVar3 + 0x84);
		  }
		  iVar3 = (int)&local_10 - (iVar3 + 0x17U & 0xfffffff0);
		  if ((uVar1 & 1) == 0) {
		    iVar9 = func_ii_1079(iVar9);
		    iVar8 = *(int *)(param5 + 0x1c);
		  }
		  iVar9 = iVar3 - (*(int *)(iVar9 + 0x84) + 0x17U & 0xfffffff0);
		  uVar13 = param3_01 + 0xfU & 0xfffffff0;
		  param2_01 = iVar9 - uVar13;
		  uVar14 = param3_00 + 0xfU & 0xfffffff0;
		  param2_02 = (param2_01 - uVar13) - uVar14;
		  iVar10 = (param2_02 - uVar14) - uVar13;
		  param1_00 = unnamed_function_714(iVar10,0,param3_01);
		  param1_01 = unnamed_function_714(iVar10 - uVar14,0,param3_00);
		  iVar8 = *(int *)(iVar8 + 4);
		  if ((*(byte *)(iVar8 + 0xbd) & 1) == 0) {
		    iVar8 = func_ii_1079(iVar8);
		  }
		  iVar10 = *param1;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (iVar8 == *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8206d3cb;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1,iVar8,0);
		code_r0x8206d3cb:
		  iVar8 = (**(code **)((ulonglong)*puVar4 * 4))(param1,puVar4[1]);
		  iVar8 = iVar8 + -1;
		  if (-1 < iVar8) {
		code_r0x8206d3e4:
		    do {
		      iVar10 = **(int **)(param5 + 0x1c);
		      if ((*(byte *)(iVar10 + 0xbd) & 1) == 0) {
		        iVar10 = func_ii_1079(iVar10);
		      }
		      iVar15 = (iVar8 - iVar17) / 2 + iVar17;
		      iVar11 = *param1;
		      _local_4 = iVar15;
		      if (*(ushort *)(iVar11 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar18 = (int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8);
		          if (iVar10 == *piVar18) {
		            iVar10 = iVar11 + piVar18[1] * 8 + 0xc0;
		            goto code_r0x8206d471;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar11 + 0xb6) != uVar2);
		      }
		      iVar10 = func_ii_1080(param1,iVar10,0);
		code_r0x8206d471:
		      local_c = (byte **)&local_4;
		      iVar10 = *(int *)(iVar10 + 4);
		      local_8 = param2_01;
		      (**(code **)((ulonglong)*(uint *)(iVar10 + 8) * 4))
		                (*(undefined4 *)(iVar10 + 4),iVar10,param1,&local_c,param2_01);
		      uVar5 = unnamed_function_713(param1_00,param2_01,param3_01);
		      local_c = (byte **)unnamed_function_713(param2_01 - uVar13,param2_01,param3_01);
		      puVar12 = *(undefined4 **)(*(int *)(param5 + 0x1c) + 0x18);
		      if (-1 < *(int *)(*(int *)(*(int *)(param5 + 0x1c) + 0x10) + 0x14)) {
		        local_c = (byte **)*local_c;
		      }
		      local_8 = param2_02;
		      (**(code **)((ulonglong)(uint)puVar12[2] * 4))(*puVar12,puVar12,param2,&local_c,param2_02);
		      uVar6 = unnamed_function_713(param1_01,param2_02,param3_00);
		      piVar18 = (int *)(*(int *)(param5 + 0x1c) + 0x1c);
		      pppppppbVar16 = param3;
		      if (-1 < *(int *)(*piVar18 + 0x14)) {
		        pppppppbVar16 = (byte *******)&local_10;
		      }
		      param2_00 = unnamed_function_713(param2_02 - uVar14,pppppppbVar16,param3_00);
		      ppbVar7 = (byte **)func_ii_1081(*piVar18,param2_00);
		      iVar11 = *(int *)(param5 + 0x1c);
		      iVar10 = *(int *)(iVar11 + 0x1c);
		      if ((*(byte *)(iVar10 + 0xbd) & 1) == 0) {
		        iVar10 = func_ii_1079(iVar10);
		        iVar11 = *(int *)(param5 + 0x1c);
		      }
		      local_c = ppbVar7;
		      func_ii_8296(iVar10,*(undefined4 *)(iVar11 + 0x20),iVar3,uVar6,&local_c,&local_4);
		      if (local_4 != 0) {
		        unnamed_function_713(param4,uVar5,param3_01);
		        return;
		      }
		      local_c = (byte **)unnamed_function_713(param2_01,uVar5,param3_01);
		      puVar12 = *(undefined4 **)(*(int *)(param5 + 0x1c) + 0x18);
		      if (-1 < *(int *)(*(int *)(*(int *)(param5 + 0x1c) + 0x10) + 0x14)) {
		        local_c = (byte **)*local_c;
		      }
		      local_8 = param2_02;
		      (**(code **)((ulonglong)(uint)puVar12[2] * 4))(*puVar12,puVar12,param2,&local_c,param2_02);
		      uVar5 = unnamed_function_713(uVar6,param2_02,param3_00);
		      piVar18 = (int *)(*(int *)(param5 + 0x1c) + 0x1c);
		      pppppppbVar16 = param3;
		      if (-1 < *(int *)(*piVar18 + 0x14)) {
		        pppppppbVar16 = (byte *******)&local_10;
		      }
		      uVar6 = unnamed_function_713(param2_00,pppppppbVar16,param3_00);
		      uVar6 = func_ii_1081(*piVar18,uVar6);
		      iVar11 = *(int *)(param5 + 0x1c);
		      iVar10 = *(int *)(iVar11 + 0x1c);
		      if ((*(byte *)(iVar10 + 0xbd) & 1) == 0) {
		        iVar10 = func_ii_1079(iVar10);
		        iVar11 = *(int *)(param5 + 0x1c);
		      }
		      _local_4 = uVar6;
		      func_ii_8296(iVar10,*(undefined4 *)(iVar11 + 0x24),iVar9,uVar5,&local_4,&local_c);
		      if ((int)local_c < 1) {
		        iVar17 = iVar15 + 1;
		        if (iVar8 < iVar17) break;
		        goto code_r0x8206d3e4;
		      }
		      iVar8 = iVar15 + -1;
		    } while (iVar17 <= iVar8);
		  }
		  unnamed_function_714(param4,0,param3_01);
		  return;
		}
		*/


		/* --- GHIDRA: BinarySearch<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType> ---
		undefined4
		Core_Extensions_IListExt__BinarySearch___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		          (int *param1,undefined4 param2,int param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined1 *param2_00;
		  int param3_00;
		  int iVar5;
		  undefined1 local_10 [4];
		  undefined4 *local_c;
		  undefined1 *local_8;
		  undefined4 local_4;
		  
		  iVar4 = *(int *)(param3 + 0x1c);
		  if (iVar4 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		    iVar4 = *(int *)(param3 + 0x1c);
		  }
		  param3_00 = *(int *)(*(int *)(iVar4 + 0x14) + 0x84);
		  param2_00 = local_10 + -(param3_00 + 0xfU & 0xfffffff0);
		  iVar4 = *(int *)(iVar4 + 4);
		  if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		    iVar4 = func_ii_1079(iVar4);
		  }
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (iVar4 == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8206d768;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,iVar4,0);
		code_r0x8206d768:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar3 = UnityEngine_Random__Range(0,uVar3,0);
		  iVar4 = **(int **)(param3 + 0x1c);
		  if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		    iVar4 = func_ii_1079(iVar4);
		  }
		  iVar5 = *param1;
		  local_4 = uVar3;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (iVar4 == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0;
		        goto code_r0x8206d803;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param1,iVar4,0);
		code_r0x8206d803:
		  local_c = &local_4;
		  iVar4 = *(int *)(iVar4 + 4);
		  local_8 = param2_00;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 8) * 4))
		            (*(undefined4 *)(iVar4 + 4),iVar4,param1,&local_c,param2_00);
		  unnamed_function_713(param2,param2_00,param3_00);
		  iVar4 = *(int *)(*(int *)(param3 + 0x1c) + 0x14);
		  if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		    func_ii_1079(iVar4);
		  }
		  return uVar3;
		}
		*/

}
