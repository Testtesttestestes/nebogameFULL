using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions
{
	// Token: 0x02000F07 RID: 3847
	[Token(Token = "0x2000F07")]
	public static class RatingTypesDicExt
	{
		// Token: 0x06005D25 RID: 23845 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D25")]
		[Address(RVA = "0x1DCB", Offset = "0x1DCB", VA = "0x1DCB")]
		public static string GetTitle(this RatingTypesDic dic)
		{
			return null;
		}

		// Token: 0x06005D26 RID: 23846 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D26")]
		[Address(RVA = "0xA9AB", Offset = "0xA9AB", VA = "0xA9AB")]
		public static string GetDescription(this RatingTypesDic dic)
		{
		/* --- GHIDRA: GetDescription ---
		undefined4 Core_Extensions_RatingTypesDicExt__GetDescription(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x20);
		  param2_00 = 0;
		  if (DAT_ram_00a5acf5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__);
		    DAT_ram_00a5acf5 = '\x01';
		  }
		  if (0 < *(int *)(param1_00 + 0xc)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (param1_00,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == 0x33) {
		        return *(undefined4 *)(iVar1 + 0x10);
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(param1_00 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005D27 RID: 23847 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D27")]
		[Address(RVA = "0xA9AC", Offset = "0xA9AC", VA = "0xA9AC")]
		public static string GetHint(this RatingTypesDic dic)
		{
		/* --- GHIDRA: GetHint ---
		int Core_Extensions_RatingTypesDicExt__GetHint(int *param1,undefined4 param2)
		
		{
		  longlong lVar1;
		  undefined8 uVar2;
		  undefined4 uVar6;
		  undefined8 uVar4;
		  longlong lVar5;
		  undefined4 uVar9;
		  undefined8 uVar8;
		  int iVar10;
		  uint *puVar11;
		  int *piVar12;
		  int iVar13;
		  uint uVar14;
		  undefined4 uVar3;
		  uint uVar7;
		  
		  if (DAT_ram_00a5acd8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Decorators_IRewardInfo_TypeInfo);
		    DAT_ram_00a5acd8 = '\x01';
		  }
		  uVar3 = 0;
		  uVar6 = 0;
		  uVar9 = 0;
		  iVar10 = Utils_MoneyUtils__Create(0.0,0.0,0.0,NAN,NAN,0);
		  iVar13 = *param1;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    uVar14 = 0;
		    do {
		      if (Core_Data_Decorators_IRewardInfo_TypeInfo ==
		          *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8)) {
		        puVar11 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8 + 4) * 8 + iVar13 + 0xd0);
		        goto code_r0x812ccbda;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		  }
		  puVar11 = (uint *)func_ii_1080(param1,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x812ccbda:
		  uVar2 = CONCAT44(uVar3,param1);
		  uVar4 = CONCAT44(uVar6,puVar11[1]);
		  piVar12 = (int *)(**(code **)((ulonglong)*puVar11 * 4))(uVar2,uVar4);
		  uVar7 = (uint)((ulonglong)uVar4 >> 0x20);
		  uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar14 = 0;
		  iVar13 = *piVar12;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IList_long__TypeInfo ==
		          *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8)) {
		        puVar11 = (uint *)(iVar13 + *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x812ccc56;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		  }
		  puVar11 = (uint *)func_ii_1080(piVar12,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x812ccc56:
		  uVar14 = 0;
		  uVar2 = CONCAT44(uVar3,piVar12);
		  lVar5 = (ulonglong)uVar7 << 0x20;
		  uVar4 = CONCAT44(uVar9,puVar11[1]);
		  lVar1 = (**(code **)((ulonglong)*puVar11 * 4))(uVar2,lVar5,uVar4);
		  uVar9 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar6 = (undefined4)((ulonglong)lVar5 >> 0x20);
		  uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  *(double *)(iVar10 + 0x10) = (double)lVar1;
		  iVar13 = *param1;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    do {
		      if (Core_Data_Decorators_IRewardInfo_TypeInfo ==
		          *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8)) {
		        puVar11 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8 + 4) * 8 + iVar13 + 0xd0);
		        goto code_r0x812cccde;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		  }
		  puVar11 = (uint *)func_ii_1080(param1,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x812cccde:
		  uVar2 = CONCAT44(uVar3,param1);
		  uVar4 = CONCAT44(uVar6,puVar11[1]);
		  piVar12 = (int *)(**(code **)((ulonglong)*puVar11 * 4))(uVar2,uVar4);
		  uVar6 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar14 = 0;
		  iVar13 = *piVar12;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IList_long__TypeInfo ==
		          *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8)) {
		        puVar11 = (uint *)(iVar13 + *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x812ccd60;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		  }
		  puVar11 = (uint *)func_ii_1080(piVar12,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x812ccd60:
		  uVar2 = CONCAT44(uVar3,piVar12);
		  uVar4 = CONCAT44(uVar6,1);
		  uVar8 = CONCAT44(uVar9,puVar11[1]);
		  lVar1 = (**(code **)((ulonglong)*puVar11 * 4))(uVar2,uVar4,uVar8);
		  uVar9 = (undefined4)((ulonglong)uVar8 >> 0x20);
		  uVar6 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  *(double *)(iVar10 + 0x18) = (double)lVar1;
		  uVar14 = 0;
		  iVar13 = *param1;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    do {
		      if (Core_Data_Decorators_IRewardInfo_TypeInfo ==
		          *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8)) {
		        puVar11 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8 + 4) * 8 + iVar13 + 0xd0);
		        goto code_r0x812ccde0;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		  }
		  puVar11 = (uint *)func_ii_1080(param1,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x812ccde0:
		  uVar2 = CONCAT44(uVar3,param1);
		  uVar4 = CONCAT44(uVar6,puVar11[1]);
		  piVar12 = (int *)(**(code **)((ulonglong)*puVar11 * 4))(uVar2,uVar4);
		  uVar6 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar14 = 0;
		  iVar13 = *piVar12;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IList_long__TypeInfo ==
		          *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8)) {
		        puVar11 = (uint *)(iVar13 + *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x812cce62;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		  }
		  puVar11 = (uint *)func_ii_1080(piVar12,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x812cce62:
		  uVar2 = CONCAT44(uVar3,piVar12);
		  uVar4 = CONCAT44(uVar6,2);
		  uVar8 = CONCAT44(uVar9,puVar11[1]);
		  lVar1 = (**(code **)((ulonglong)*puVar11 * 4))(uVar2,uVar4,uVar8);
		  uVar9 = (undefined4)((ulonglong)uVar8 >> 0x20);
		  uVar6 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  *(double *)(iVar10 + 0x20) = (double)lVar1;
		  uVar14 = 0;
		  iVar13 = *param1;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    do {
		      if (Core_Data_Decorators_IRewardInfo_TypeInfo ==
		          *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8)) {
		        puVar11 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8 + 4) * 8 + iVar13 + 0xd0);
		        goto code_r0x812ccee2;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		  }
		  puVar11 = (uint *)func_ii_1080(param1,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x812ccee2:
		  uVar2 = CONCAT44(uVar3,param1);
		  uVar4 = CONCAT44(uVar6,puVar11[1]);
		  piVar12 = (int *)(**(code **)((ulonglong)*puVar11 * 4))(uVar2,uVar4);
		  uVar6 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar14 = 0;
		  iVar13 = *piVar12;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IList_long__TypeInfo ==
		          *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8)) {
		        puVar11 = (uint *)(iVar13 + *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x812ccf64;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		  }
		  puVar11 = (uint *)func_ii_1080(piVar12,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x812ccf64:
		  uVar2 = CONCAT44(uVar3,piVar12);
		  uVar4 = CONCAT44(uVar6,3);
		  uVar8 = CONCAT44(uVar9,puVar11[1]);
		  lVar1 = (**(code **)((ulonglong)*puVar11 * 4))(uVar2,uVar4,uVar8);
		  uVar9 = (undefined4)((ulonglong)uVar8 >> 0x20);
		  uVar6 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  *(double *)(iVar10 + 0x28) = (double)lVar1;
		  uVar14 = 0;
		  iVar13 = *param1;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    do {
		      if (Core_Data_Decorators_IRewardInfo_TypeInfo ==
		          *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8)) {
		        puVar11 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8 + 4) * 8 + iVar13 + 0xd0);
		        goto code_r0x812ccfe4;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		  }
		  puVar11 = (uint *)func_ii_1080(param1,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x812ccfe4:
		  uVar2 = CONCAT44(uVar3,param1);
		  uVar4 = CONCAT44(uVar6,puVar11[1]);
		  piVar12 = (int *)(**(code **)((ulonglong)*puVar11 * 4))(uVar2,uVar4);
		  uVar6 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar14 = 0;
		  iVar13 = *piVar12;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IList_long__TypeInfo ==
		          *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8)) {
		        puVar11 = (uint *)(iVar13 + *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x812cd066;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		  }
		  puVar11 = (uint *)func_ii_1080(piVar12,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x812cd066:
		  lVar1 = (**(code **)((ulonglong)*puVar11 * 4))
		                    (CONCAT44(uVar3,piVar12),CONCAT44(uVar6,4),CONCAT44(uVar9,puVar11[1]));
		  *(double *)(iVar10 + 0x30) = (double)lVar1;
		  return iVar10;
		}
		*/

			return null;
		}
	}
}
