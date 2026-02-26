using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Medals.Controller.Filters
{
	// Token: 0x02000613 RID: 1555
	[Token(Token = "0x2000613")]
	public class MedalSkillFilter : IMedalFilter
	{
		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060025C5 RID: 9669 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060025C6 RID: 9670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000718")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60025C5")]
			[Address(RVA = "0x7703", Offset = "0x7703", VA = "0x7703", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60025C6")]
			[Address(RVA = "0x7704", Offset = "0x7704", VA = "0x7704", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x00007368 File Offset: 0x00005568
		[Token(Token = "0x60025C7")]
		[Address(RVA = "0x7705", Offset = "0x7705", VA = "0x7705", Slot = "6")]
		public bool Filter(MedalData medalData)
		{
			return default(bool);
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025C8")]
		[Address(RVA = "0x7706", Offset = "0x7706", VA = "0x7706")]
		public MedalSkillFilter()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_FilterInfo ---
		int Gameplay_Medals_Controller_Filters_MedalSkillFilter__set_FilterInfo
		              (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  int *piVar8;
		  int iVar9;
		  int iVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57ddf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Model_MedalUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Values__);
		    DAT_ram_00a57ddf = '\x01';
		  }
		  if (*(char *)(*(int *)(param1 + 8) + 0x10) == '\0') {
		    iVar10 = 1;
		  }
		  else {
		    piVar7 = *(int **)(*(int *)(param1 + 8) + 0xc);
		    if (piVar7 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar7 + 0xb8) <
		           (uint)*(byte *)(System_Collections_Generic_List_int__TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*piVar7 + 100) +
		                   (uint)*(byte *)(System_Collections_Generic_List_int__TypeInfo + 0xb8) * 4 + -4)
		          != System_Collections_Generic_List_int__TypeInfo)) {
		        System_Activator__CreateInstance(piVar7,System_Collections_Generic_List_int__TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    piVar2 = (int *)System_Collections_Generic_SortedList_uint__object___System_Collections_Generic_IReadOnlyDictionary_TKey_TValue__get_Keys
		                              (*(undefined4 *)(*(int *)(param2 + 8) + 8),
		                               Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Values__
		                              );
		    iVar10 = *piVar2;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo ==
		            *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e6538c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar2,
		                                  System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo,0
		                                 );
		code_r0x80e6538c:
		    local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		    local_c = 0;
		    local_8 = &local_4;
		    do {
		      piVar2 = local_4;
		      iVar10 = *local_4;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		            puVar4 = (undefined4 *)(iVar10 + piVar8[1] * 8 + 0xc0);
		            goto code_r0x80e6545a;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80e654a6:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e65625:
		        iVar10 = global_1;
		        iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar10 == iVar6) {
		          piVar7 = (int *)import::env::__cxa_begin_catch(uVar5);
		          iVar6 = *piVar7;
		          iVar10 = 0;
		          DAT_ram_009d3e38 = 0;
		          local_c = iVar6;
		          import::env::invoke_v(0x123);
		          iVar9 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 != 1) goto code_r0x80e65672;
		          uVar5 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xa8,&local_c);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          import::env::__cxa_find_matching_catch_3(0);
		          unnamed_function_937();
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__resumeException(uVar5);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80e6545a:
		      DAT_ram_009d3e38 = 0;
		      iVar10 = import::env::invoke_iii(*puVar4,piVar2,puVar4[1]);
		      piVar2 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e654a6;
		      if (iVar10 == 0) {
		        iVar6 = 0;
		        iVar10 = 0;
		        goto code_r0x80e65672;
		      }
		      iVar6 = *local_4;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo == *piVar8) {
		            puVar4 = (undefined4 *)(iVar6 + piVar8[1] * 8 + 0xc0);
		            goto code_r0x80e65549;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80e65609:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e65625;
		      }
		code_r0x80e65549:
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iii(*puVar4,piVar2,puVar4[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e65609;
		      uVar5 = *(undefined4 *)(iVar6 + 0x10);
		      if (*(int *)(Gameplay_Medals_Model_MedalUtils_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   Gameplay_Medals_Model_MedalUtils_TypeInfo);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 != 1) goto code_r0x80e655ca;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e65625;
		      }
		code_r0x80e655ca:
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xa7,uVar5,piVar7,uVar5);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e65625;
		      }
		    } while (iVar9 == 0);
		    iVar6 = 0;
		code_r0x80e65672:
		    piVar7 = local_4;
		    DAT_ram_009d3e38 = 0;
		    if (local_4 != (int *)0x0) {
		      uVar1 = 0;
		      iVar9 = *local_4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        do {
		          if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80e656ea;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e656ea:
		      (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		    }
		    if (iVar6 != 0) {
		      System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return iVar10;
		}
		*/

}
