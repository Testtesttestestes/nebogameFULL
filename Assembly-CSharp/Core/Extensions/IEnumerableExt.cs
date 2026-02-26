using System;
using System.Collections.Generic;
using System.Linq;
using Core.Sorting;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Core.Extensions
{
	// Token: 0x02000F0B RID: 3851
	[Token(Token = "0x2000F0B")]
	public static class IEnumerableExt
	{
		// Token: 0x06005D2D RID: 23853 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D2D")]
		public static IOrderedEnumerable<TSource> SortGameData<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IGameDataComparer<TKey> comparer)
		{
			return null;
		}

		// Token: 0x06005D2E RID: 23854 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D2E")]
		public static YResult MinOrDefault<TSource, YResult>(this IEnumerable<TSource> sequence, Func<TSource, YResult> selector)
		{
		/* --- GHIDRA: MinOrDefault<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType> ---
		undefined4
		Core_Extensions_IEnumerableExt__MinOrDefault___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		          (undefined4 param1,undefined4 param2,int *param3,int param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  
		  piVar4 = *(int **)(param4 + 0x1c);
		  if (piVar4 == (int *)0x0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param4);
		    piVar4 = *(int **)(param4 + 0x1c);
		  }
		  iVar5 = *piVar4;
		  if ((*(byte *)(iVar5 + 0xbd) & 1) == 0) {
		    iVar5 = func_ii_1079(iVar5);
		  }
		  iVar6 = *param3;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (iVar5 == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x8206c46e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param3,iVar5,1);
		code_r0x8206c46e:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param3,puVar2[1]);
		  iVar6 = 0x10;
		  if (iVar5 == 0) {
		    iVar6 = 0x1c;
		  }
		  puVar2 = *(uint **)(*(int *)(param4 + 0x1c) + iVar6);
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1,param2,param3,puVar2);
		  return uVar3;
		}
		*/

		/* --- GHIDRA: MinOrDefault<object, float> ---
		void Core_Extensions_IEnumerableExt__MinOrDefault_object__float_
		               (undefined4 param1,undefined4 param2,undefined4 param3,int param4)
		
		{
		  int iVar1;
		  undefined1 *param2_00;
		  undefined4 *puVar2;
		  int param3_00;
		  undefined1 local_10 [4];
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined1 *local_4;
		  
		  iVar1 = *(int *)(param4 + 0x1c);
		  if (iVar1 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param4);
		    iVar1 = *(int *)(param4 + 0x1c);
		  }
		  param3_00 = *(int *)(*(int *)(iVar1 + 0x10) + 0x84);
		  param2_00 = local_10 + -(param3_00 + 0xfU & 0xfffffff0);
		  iVar1 = (**(code **)((ulonglong)**(uint **)(iVar1 + 4) * 4))(param1,*(uint **)(iVar1 + 4));
		  if (iVar1 == 0) {
		    unnamed_function_714(param3,0,param3_00);
		  }
		  else {
		    puVar2 = *(undefined4 **)(*(int *)(param4 + 0x1c) + 0xc);
		    local_c = param1;
		    local_8 = param2;
		    local_4 = param2_00;
		    (**(code **)((ulonglong)(uint)puVar2[2] * 4))(*puVar2,puVar2,0,&local_c,param2_00);
		    unnamed_function_713(param3,param2_00,param3_00);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005D2F RID: 23855 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D2F")]
		[NotNull]
		public static string ToString<T>(this IEnumerable<T> source, string separator)
		{
		/* --- GHIDRA: ToString<__Il2CppFullySharedGenericType> ---
		void Core_Extensions_IEnumerableExt__ToString___Il2CppFullySharedGenericType_(int param1)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x1c);
		  if (iVar1 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param1);
		    iVar1 = *(int *)(param1 + 0x1c);
		  }
		  iVar1 = *(int *)(iVar1 + 4);
		  if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		    iVar1 = func_ii_1079(iVar1);
		  }
		  if (*(int *)(iVar1 + 0x74) == 0) {
		    func_ii_306000(iVar1);
		  }
		  Unity_Jobs_IJobExtensions_JobStruct_NativeArrayDisposeJob___Execute
		            (**(undefined4 **)(param1 + 0x1c));
		  return;
		}
		*/

			return null;
		}
	}
}
