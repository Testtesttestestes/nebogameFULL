using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Market.Model.Data;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Filters;

namespace Gameplay.Market.Controller.Filters
{
	// Token: 0x0200063B RID: 1595
	[Token(Token = "0x200063B")]
	internal class MarketSubFilter : IMarketFilter
	{
		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060026BC RID: 9916 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060026BD RID: 9917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700073F")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60026BC")]
			[Address(RVA = "0x77F1", Offset = "0x77F1", VA = "0x77F1", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026BD")]
			[Address(RVA = "0x77F2", Offset = "0x77F2", VA = "0x77F2", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x000076E0 File Offset: 0x000058E0
		[Token(Token = "0x60026BE")]
		[Address(RVA = "0x77F3", Offset = "0x77F3", VA = "0x77F3", Slot = "6")]
		public bool Filter(MarketLotData marketLotData)
		{
		/* --- GHIDRA: Filter ---
		void Gameplay_Market_Controller_Filters_MarketSubFilter__Filter(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int param1_00;
		  
		  if (DAT_ram_00a5a041 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_ArtikulTypeFilters__TypeInfo);
		    DAT_ram_00a5a041 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_IList_ArtikulTypeFilters__TypeInfo;
		  param1_00 = *(int *)(*(int *)(param1 + 0xc) + 0xc);
		  if (param1_00 == 0) {
		    *(undefined4 *)(param1 + 8) = 0;
		    return;
		  }
		  iVar2 = func_ii_1082(param1_00,System_Collections_Generic_IList_ArtikulTypeFilters__TypeInfo);
		  if (iVar2 == 0) {
		    System_Activator__CreateInstance(param1_00,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(param1 + 8) = iVar2;
		  uVar1 = System_Collections_Generic_IList_ArtikulTypeFilters__TypeInfo;
		  iVar2 = func_ii_1082(param1_00,System_Collections_Generic_IList_ArtikulTypeFilters__TypeInfo);
		  if (iVar2 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026BF")]
		[Address(RVA = "0x77F4", Offset = "0x77F4", VA = "0x77F4", Slot = "7")]
		public void Prepare()
		{
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026C0")]
		[Address(RVA = "0x77F5", Offset = "0x77F5", VA = "0x77F5")]
		public MarketSubFilter()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Market_Controller_Filters_MarketSubFilter___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a042 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Controller_Filters_MarketSubFilter___c_TypeInfo);
		    DAT_ram_00a5a042 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Market_Controller_Filters_MarketSubFilter___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Market_Controller_Filters_MarketSubFilter___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04001525 RID: 5413
		[Token(Token = "0x4001525")]
		[FieldOffset(Offset = "0x8")]
		private IList<ArtikulTypeFilters> _filters;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_FilterInfo ---
		int Gameplay_Market_Controller_Filters_MarketSubFilter__set_FilterInfo
		              (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 param3_00;
		  int *piVar8;
		  int iVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a040 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_uint__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_ArtikulTypeFilters__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_ArtikulTypeFilters__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Extensions_IListExt_BinarySearch_uint__uint___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Controller_Filters_MarketSubFilter___c__Filter_b__5_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Controller_Filters_MarketSubFilter___c_TypeInfo);
		    DAT_ram_00a5a040 = '\x01';
		  }
		  if (*(char *)(*(int *)(param1 + 0xc) + 0x10) == '\0') {
		    iVar7 = 1;
		  }
		  else {
		    uVar1 = 0;
		    piVar6 = *(int **)(param1 + 8);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_IEnumerable_ArtikulTypeFilters__TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x811b7fcb;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar6,
		                                  System_Collections_Generic_IEnumerable_ArtikulTypeFilters__TypeInfo
		                                  ,0);
		code_r0x811b7fcb:
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
		            goto code_r0x811b80a3;
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
		code_r0x811b80ef:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811b8375:
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
		          if (iVar9 != 1) goto code_r0x811b83c2;
		          uVar4 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x23c,&local_c);
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
		code_r0x811b80a3:
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		      piVar6 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811b80ef;
		      if (iVar7 == 0) {
		        iVar5 = 0;
		        iVar7 = 0;
		        goto code_r0x811b83c2;
		      }
		      iVar5 = *local_4;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_ArtikulTypeFilters__TypeInfo == *piVar8) {
		            puVar3 = (undefined4 *)(iVar5 + piVar8[1] * 8 + 0xc0);
		            goto code_r0x811b8192;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_ArtikulTypeFilters__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x811b8345:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811b8375;
		      }
		code_r0x811b8192:
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811b8345;
		      uVar4 = *(undefined4 *)(iVar5 + 0x18);
		      if (*(int *)(Gameplay_Market_Controller_Filters_MarketSubFilter___c_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   Gameplay_Market_Controller_Filters_MarketSubFilter___c_TypeInfo);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 != 1) goto code_r0x811b821d;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811b8375;
		      }
		code_r0x811b821d:
		      puVar3 = *(undefined4 **)
		                (Gameplay_Market_Controller_Filters_MarketSubFilter___c_TypeInfo + 0x5c);
		      iVar5 = puVar3[1];
		      if (iVar5 == 0) {
		        if (*(int *)(Gameplay_Market_Controller_Filters_MarketSubFilter___c_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     Gameplay_Market_Controller_Filters_MarketSubFilter___c_TypeInfo);
		          iVar5 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar5 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x811b8375;
		          }
		          puVar3 = *(undefined4 **)
		                    (Gameplay_Market_Controller_Filters_MarketSubFilter___c_TypeInfo + 0x5c);
		        }
		        param3_00 = *puVar3;
		        DAT_ram_009d3e38 = 0;
		        iVar5 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Func_uint__uint__TypeInfo);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 200,iVar5,param3_00,
		                     Method_Gameplay_Market_Controller_Filters_MarketSubFilter___c__Filter_b__5_0__,
		                     0);
		          if (DAT_ram_009d3e38 != 1) {
		            *(int *)(*(int *)(Gameplay_Market_Controller_Filters_MarketSubFilter___c_TypeInfo + 0x5c
		                             ) + 4) = iVar5;
		            goto code_r0x811b82f0;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811b8375;
		      }
		code_r0x811b82f0:
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iiiii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x23b,uVar4,iVar5,
		                         *(undefined4 *)(*(int *)(*(int *)(param2 + 8) + 0xc) + 0xc),
		                         Method_Core_Extensions_IListExt_BinarySearch_uint__uint___);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811b8375;
		      }
		    } while (iVar9 == 0);
		    iVar5 = 0;
		code_r0x811b83c2:
		    piVar6 = local_4;
		    DAT_ram_009d3e38 = 0;
		    if (local_4 != (int *)0x0) {
		      uVar1 = 0;
		      iVar9 = *local_4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        do {
		          if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x811b843a;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x811b843a:
		      (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		    }
		    if (iVar5 != 0) {
		      System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return iVar7;
		}
		*/

}
