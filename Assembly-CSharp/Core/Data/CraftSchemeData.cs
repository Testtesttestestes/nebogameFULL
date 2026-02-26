using System;
using Core.Dict;
using Il2CppDummyDll;
using Protocol.Craft;
using Protocol.Dic;

namespace Core.Data
{
	// Token: 0x020010BA RID: 4282
	[Token(Token = "0x20010BA")]
	public class CraftSchemeData
	{
		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x060063DE RID: 25566 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001413")]
		public string TitleToLower
		{
			[Token(Token = "0x60063DE")]
			[Address(RVA = "0xAFDB", Offset = "0xAFDB", VA = "0xAFDB")]
			get
			{
				return null;
			}
		}

		// Token: 0x060063DF RID: 25567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063DF")]
		[Address(RVA = "0xAFDC", Offset = "0xAFDC", VA = "0xAFDC")]
		public CraftSchemeData(IDictProvider provider, UserScheme scheme)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Data_CraftSchemeData___ctor(int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  
		  if (DAT_ram_00a607ab == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__get_Item__);
		    DAT_ram_00a607ab = '\x01';
		  }
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x81ce22b7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x81ce22b7:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar3 = Core_Extensions_Dict_DictExt__GetSeasonLeagueDic(uVar3,param3,0);
		  *(undefined4 *)(param1 + 8) = uVar3;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x81ce2342;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x81ce2342:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar3 = Core_Extensions_Dict_DictExt__GetStringParameter
		                    (uVar3,*(undefined4 *)(*(int *)(param1 + 8) + 0x14),0);
		  *(undefined4 *)(param1 + 0xc) = uVar3;
		  iVar4 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 0x24),0,
		                     Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__get_Item__);
		  param1_00 = *(int **)(iVar4 + 0x10);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IList_uint__TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81ce23f0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_IList_uint__TypeInfo,0);
		code_r0x81ce23f0:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,0,puVar2[1]);
		  uVar1 = 0;
		  uVar3 = func_ii_7944(uVar3,param2,0);
		  *(undefined4 *)(param1 + 0x10) = uVar3;
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_uint__TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81ce247d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_ICollection_uint__TypeInfo,0);
		code_r0x81ce247d:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  if (1 < iVar4) {
		    uVar1 = 0;
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_IList_uint__TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81ce2502;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_IList_uint__TypeInfo,0);
		code_r0x81ce2502:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,1,puVar2[1]);
		    *(undefined4 *)(param1 + 0x14) = uVar3;
		  }
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Core_Data_CraftSchemeData___ctor(int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  
		  if (DAT_ram_00a607ab == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__get_Item__);
		    DAT_ram_00a607ab = '\x01';
		  }
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x81ce22b7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x81ce22b7:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar3 = Core_Extensions_Dict_DictExt__GetSeasonLeagueDic(uVar3,param3,0);
		  *(undefined4 *)(param1 + 8) = uVar3;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x81ce2342;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x81ce2342:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar3 = Core_Extensions_Dict_DictExt__GetStringParameter
		                    (uVar3,*(undefined4 *)(*(int *)(param1 + 8) + 0x14),0);
		  *(undefined4 *)(param1 + 0xc) = uVar3;
		  iVar4 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 0x24),0,
		                     Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__get_Item__);
		  param1_00 = *(int **)(iVar4 + 0x10);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IList_uint__TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81ce23f0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_IList_uint__TypeInfo,0);
		code_r0x81ce23f0:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,0,puVar2[1]);
		  uVar1 = 0;
		  uVar3 = func_ii_7944(uVar3,param2,0);
		  *(undefined4 *)(param1 + 0x10) = uVar3;
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_uint__TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81ce247d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_ICollection_uint__TypeInfo,0);
		code_r0x81ce247d:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  if (1 < iVar4) {
		    uVar1 = 0;
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_IList_uint__TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81ce2502;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_IList_uint__TypeInfo,0);
		code_r0x81ce2502:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,1,puVar2[1]);
		    *(undefined4 *)(param1 + 0x14) = uVar3;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060063E0 RID: 25568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063E0")]
		[Address(RVA = "0xAFDD", Offset = "0xAFDD", VA = "0xAFDD")]
		public CraftSchemeData(UserScheme scheme, CraftSchemeData.CraftSchemeInfo info)
		{
		}

		// Token: 0x0400356B RID: 13675
		[Token(Token = "0x400356B")]
		[FieldOffset(Offset = "0x8")]
		public readonly UserScheme Scheme;

		// Token: 0x0400356C RID: 13676
		[Token(Token = "0x400356C")]
		[FieldOffset(Offset = "0xC")]
		public readonly CraftSchemeData.CraftSchemeInfo Info;

		// Token: 0x0400356D RID: 13677
		[Token(Token = "0x400356D")]
		[FieldOffset(Offset = "0x10")]
		private string _titleToLower;

		// Token: 0x020010BB RID: 4283
		[Token(Token = "0x20010BB")]
		public class CraftSchemeInfo
		{
			// Token: 0x060063E1 RID: 25569 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60063E1")]
			[Address(RVA = "0xAFDE", Offset = "0xAFDE", VA = "0xAFDE")]
			public CraftSchemeInfo(IDictProvider provider, uint schemeId)
			{
			}

			// Token: 0x0400356E RID: 13678
			[Token(Token = "0x400356E")]
			[FieldOffset(Offset = "0x8")]
			public readonly CraftSchemeDic Dic;

			// Token: 0x0400356F RID: 13679
			[Token(Token = "0x400356F")]
			[FieldOffset(Offset = "0xC")]
			public readonly RequirementDic Requirements;

			// Token: 0x04003570 RID: 13680
			[Token(Token = "0x4003570")]
			[FieldOffset(Offset = "0x10")]
			public readonly ArtikulData Artikul;

			// Token: 0x04003571 RID: 13681
			[Token(Token = "0x4003571")]
			[FieldOffset(Offset = "0x14")]
			public readonly uint Quantity;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_TitleToLower ---
		void Core_Data_CraftSchemeData__get_TitleToLower
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a607aa == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_CraftSchemeData_CraftSchemeInfo_TypeInfo);
		    DAT_ram_00a607aa = '\x01';
		  }
		  *(int *)(param1 + 8) = param3;
		  param3_00 = *(undefined4 *)(param3 + 0xc);
		  param1_00 = unnamed_function_1417(Core_Data_CraftSchemeData_CraftSchemeInfo_TypeInfo);
		  Core_Data_CraftSchemeData___ctor(param1_00,param2,param3_00,param1);
		  *(undefined4 *)(param1 + 0xc) = param1_00;
		  return;
		}
		*/

}
