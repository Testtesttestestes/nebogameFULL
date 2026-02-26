using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Collections.Model
{
	// Token: 0x020009D2 RID: 2514
	[Token(Token = "0x20009D2")]
	public class CollectionDicGroup
	{
		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06003C2C RID: 15404 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
		[Token(Token = "0x17000BDE")]
		public uint MaxRank
		{
			[Token(Token = "0x6003C2C")]
			[Address(RVA = "0x8AFB", Offset = "0x8AFB", VA = "0x8AFB")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06003C2D RID: 15405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C2D")]
		[Address(RVA = "0x8AFC", Offset = "0x8AFC", VA = "0x8AFC")]
		public CollectionDicGroup(CollectionsDic dic, IEnumerable<CollectionRanksInfoDic> rankInfo, Dictionary<uint, CollectionRanksDic> ranks, Dictionary<uint, MedalDic> medals)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Collections_Model_CollectionDicGroup___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57eaa == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalDic__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10928);
		    DAT_ram_00a57eaa = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 0x14),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__MedalDic__TryGetValue__);
		  if (iVar1 == 0) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_10928,0);
		  }
		  return local_4;
		}
		*/

		}

		// Token: 0x06003C2E RID: 15406 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003C2E")]
		[Address(RVA = "0x8AFD", Offset = "0x8AFD", VA = "0x8AFD")]
		public MedalDic GetMedal(uint rank)
		{
		/* --- GHIDRA: GetMedal ---
		undefined4
		Gameplay_Collections_Model_CollectionDicGroup__GetMedal
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57eab == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__CollectionRanksDic__TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_5545);
		    DAT_ram_00a57eab = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 0x10),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__CollectionRanksDic__TryGetValue__
		                    );
		  if (iVar1 == 0) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_5545,0);
		  }
		  return local_4;
		}
		*/

			return null;
		}

		// Token: 0x06003C2F RID: 15407 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003C2F")]
		[Address(RVA = "0x8AFE", Offset = "0x8AFE", VA = "0x8AFE")]
		public CollectionRanksDic GetCollectionRanksDic(uint rank)
		{
		/* --- GHIDRA: GetCollectionRanksDic ---
		undefined4
		Gameplay_Collections_Model_CollectionDicGroup__GetCollectionRanksDic
		          (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  int *piVar8;
		  int iVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57eac == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_CollectionRanksInfoDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_CollectionRanksInfoDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    DAT_ram_00a57eac = '\x01';
		  }
		  piVar6 = *(int **)(param1 + 0xc);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_CollectionRanksInfoDic__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e7110e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,
		                                System_Collections_Generic_IEnumerable_CollectionRanksInfoDic__TypeInfo
		                                ,0);
		code_r0x80e7110e:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar6 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80e711e6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e71236:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e7133f:
		      iVar7 = global_1;
		      iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar7 == iVar5) {
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		        iVar5 = *piVar6;
		        iVar7 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_c = iVar5;
		        import::env::invoke_v(0x123);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        uVar4 = 0;
		        if (iVar9 != 1) goto code_r0x80e71390;
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xc1,&local_c);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 != 1) {
		        import::env::__resumeException(uVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		code_r0x80e711e6:
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    piVar6 = local_4;
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) goto code_r0x80e71236;
		    if (iVar5 == 0) {
		      iVar5 = 0;
		      iVar7 = 5;
		      uVar4 = 0;
		      goto code_r0x80e71390;
		    }
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_CollectionRanksInfoDic__TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80e712d9;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_CollectionRanksInfoDic__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e71337:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e7133f;
		    }
		code_r0x80e712d9:
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) goto code_r0x80e71337;
		  } while (*(int *)(iVar5 + 0xc) != param2);
		  *param3 = iVar5;
		  uVar4 = 1;
		  iVar7 = 4;
		  iVar5 = 0;
		code_r0x80e71390:
		  piVar6 = local_4;
		  if (local_4 != (int *)0x0) {
		    uVar1 = 0;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e71408;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e71408:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  }
		  if (iVar5 == 0) {
		    if ((iVar7 == 0) ||
		       ((((iVar7 != 1 && (iVar7 != 2)) && (iVar7 != 3)) && ((iVar7 != 4 && (iVar7 == 5)))))) {
		      uVar4 = 0;
		      *param3 = 0;
		    }
		    return uVar4;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06003C30 RID: 15408 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		[Token(Token = "0x6003C30")]
		[Address(RVA = "0x8AFF", Offset = "0x8AFF", VA = "0x8AFF")]
		public bool TryGetRankInfo(uint rank, out CollectionRanksInfoDic info)
		{
		/* --- GHIDRA: TryGetRankInfo ---
		void Gameplay_Collections_Model_CollectionDicGroup__TryGetRankInfo
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  if (DAT_ram_00a57ead == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalDic__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__CollectionRanksDic__Add__);
		    DAT_ram_00a57ead = '\x01';
		  }
		  System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		            (*(undefined4 *)(param1 + 0x10),param2,param3,
		             Method_System_Collections_Generic_Dictionary_uint__CollectionRanksDic__Add__);
		  System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		            (*(undefined4 *)(param1 + 0x14),param2,param4,
		             Method_System_Collections_Generic_Dictionary_uint__MedalDic__Add__);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06003C31 RID: 15409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C31")]
		[Address(RVA = "0x8B00", Offset = "0x8B00", VA = "0x8B00")]
		public void AddRank(uint rank, CollectionRanksDic collectionRanksDic, MedalDic medal)
		{
		/* --- GHIDRA: AddRank ---
		void Gameplay_Collections_Model_CollectionDicGroup__AddRank
		               (undefined4 param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  undefined4 *puVar4;
		  undefined4 param1_00;
		  uint uVar5;
		  int iVar6;
		  int iVar7;
		  int *piVar8;
		  int local_10;
		  int **local_c;
		  int *local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57eae == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IDictionary_uint__CollectionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_CollectionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_CollectionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    DAT_ram_00a57eae = '\x01';
		  }
		  iVar7 = *param3;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IDictionary_uint__CollectionData__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd8);
		        goto code_r0x80e75caf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param3,
		                                System_Collections_Generic_IDictionary_uint__CollectionData__TypeInfo
		                                ,3);
		code_r0x80e75caf:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param3,puVar2[1]);
		  uVar1 = 0;
		  iVar7 = *piVar3;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_CollectionData__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e75d2f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,
		                                System_Collections_Generic_IEnumerable_CollectionData__TypeInfo,0);
		code_r0x80e75d2f:
		  local_8 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  local_10 = 0;
		  local_c = &local_8;
		code_r0x80e75d64:
		  piVar3 = local_8;
		  iVar7 = *local_8;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		      if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		        puVar4 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		        goto code_r0x80e75dfc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar4 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                      System_Collections_IEnumerator_TypeInfo,0);
		  if (DAT_ram_009d3e38 != 1) {
		code_r0x80e75dfc:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar4,piVar3,puVar4[1]);
		    piVar3 = local_8;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e75e44;
		    if (iVar7 != 0) {
		      iVar7 = *local_8;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_CollectionData__TypeInfo == *piVar8) {
		            puVar4 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		            goto code_r0x80e75eeb;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                          System_Collections_Generic_IEnumerator_CollectionData__TypeInfo,0);
		      if (DAT_ram_009d3e38 != 1) {
		code_r0x80e75eeb:
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iii(*puVar4,piVar3,puVar4[1]);
		        if (DAT_ram_009d3e38 != 1) {
		          uVar1 = 1;
		          do {
		            iVar6 = *(int *)(iVar7 + 0x18);
		            if (DAT_ram_00a57ea8 == '\0') {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (0x7ff,&
		                               Method_System_Collections_Generic_Dictionary_uint__CollectionRanksDic__get_Count__
		                        );
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_00a57ea8 = '\x01';
		                goto code_r0x80e75f89;
		              }
		code_r0x80e76198:
		              DAT_ram_009d3e38 = 0;
		              param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80e761a0;
		            }
		code_r0x80e75f89:
		            DAT_ram_009d3e38 = 0;
		            uVar5 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                              (*(undefined4 *)(iVar6 + 0x10),
		                               Method_System_Collections_Generic_Dictionary_uint__CollectionRanksDic__get_Count__
		                              );
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80e76198;
		            if (uVar5 < uVar1) goto code_r0x80e75d64;
		            iVar6 = *(int *)(iVar7 + 0x18);
		            if (DAT_ram_00a57eab == '\0') {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi(0x7ff,&OKG_Logs_Debug_TypeInfo);
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vi
		                          (0x7ff,&
		                                 Method_System_Collections_Generic_Dictionary_uint__CollectionRanksDic__TryGetValue__
		                          );
		                if (DAT_ram_009d3e38 != 1) {
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_vi(0x7ff,&StringLiteral_5545);
		                  if (DAT_ram_009d3e38 != 1) {
		                    DAT_ram_00a57eab = '\x01';
		                    goto code_r0x80e76075;
		                  }
		                }
		              }
		code_r0x80e76184:
		              DAT_ram_009d3e38 = 0;
		              param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80e761a0;
		            }
		code_r0x80e76075:
		            local_4 = 0;
		            DAT_ram_009d3e38 = 0;
		            iVar6 = import::env::invoke_iiiii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x39d,
		                               *(undefined4 *)(iVar6 + 0x10),uVar1,&local_4,
		                               Method_System_Collections_Generic_Dictionary_uint__CollectionRanksDic__TryGetValue__
		                              );
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80e76184;
		            if (iVar6 == 0) {
		              if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vi
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                           OKG_Logs_Debug_TypeInfo);
		                if (DAT_ram_009d3e38 == 1) goto code_r0x80e76184;
		              }
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xc5,StringLiteral_5545,0
		                        );
		              if (DAT_ram_009d3e38 == 1) goto code_r0x80e76184;
		            }
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xc6,param1,local_4,param2,
		                       iVar7,uVar1);
		            iVar6 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar6 == 1) {
		              param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80e761a0;
		            }
		            uVar1 = uVar1 + 1;
		          } while( true );
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e761a0;
		    }
		    iVar7 = 0;
		    goto code_r0x80e761e9;
		  }
		code_r0x80e75e44:
		  DAT_ram_009d3e38 = 0;
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e761a0:
		  iVar7 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar6) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar7 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_10 = iVar7;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x80e761e9:
		      piVar3 = local_8;
		      DAT_ram_009d3e38 = 0;
		      if (local_8 != (int *)0x0) {
		        uVar1 = 0;
		        iVar6 = *local_8;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80e76261;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_8,System_IDisposable_TypeInfo,0);
		code_r0x80e76261:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		      }
		      if (iVar7 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 199,&local_10);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04002141 RID: 8513
		[Token(Token = "0x4002141")]
		[FieldOffset(Offset = "0x8")]
		public readonly CollectionsDic CollectionsDic;

		// Token: 0x04002142 RID: 8514
		[Token(Token = "0x4002142")]
		[FieldOffset(Offset = "0xC")]
		private readonly IEnumerable<CollectionRanksInfoDic> _rankInfo;

		// Token: 0x04002143 RID: 8515
		[Token(Token = "0x4002143")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<uint, CollectionRanksDic> _collectionRanksDicsByIndex;

		// Token: 0x04002144 RID: 8516
		[Token(Token = "0x4002144")]
		[FieldOffset(Offset = "0x14")]
		private readonly Dictionary<uint, MedalDic> _medalsByRank;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_MaxRank ---
		void Gameplay_Collections_Model_CollectionDicGroup__get_MaxRank
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57ea9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__CollectionRanksDic___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalDic___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_uint__MedalDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__CollectionRanksDic__TypeInfo);
		    DAT_ram_00a57ea9 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_uint__CollectionRanksDic__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar1,Method_System_Collections_Generic_Dictionary_uint__CollectionRanksDic___ctor__);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__MedalDic__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar1,Method_System_Collections_Generic_Dictionary_uint__MedalDic___ctor__);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  *(undefined4 *)(param1 + 0x14) = param5;
		  *(undefined4 *)(param1 + 0x10) = param4;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  *(undefined4 *)(param1 + 8) = param2;
		  return;
		}
		*/

}
