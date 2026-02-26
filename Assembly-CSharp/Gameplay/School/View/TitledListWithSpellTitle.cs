using System;
using System.Collections.Generic;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using UI.Elements.RightPanel.TitledList;
using UnityEngine;

namespace Gameplay.School.View
{
	// Token: 0x02000646 RID: 1606
	[Token(Token = "0x2000646")]
	public class TitledListWithSpellTitle : TitledListWithCustomTitle<SpellTitle>, IDiscountTarget
	{
		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060026E3 RID: 9955 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700074A")]
		public DiscountTargets[] DiscountTargets
		{
			[Token(Token = "0x60026E3")]
			[Address(RVA = "0x7818", Offset = "0x7818", VA = "0x7818", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026E4")]
		[Address(RVA = "0x7819", Offset = "0x7819", VA = "0x7819", Slot = "5")]
		public void Setup(IEnumerable<IDiscountArgs> value)
		{
		/* --- GHIDRA: Setup ---
		void Gameplay_School_View_TitledListWithSpellTitle__Setup(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a04f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle___ctor__
		              );
		    DAT_ram_00a5a04f = '\x01';
		  }
		  HuaweiMobileServices_CloudStorage_StorageTask_TimePointStateBase___Il2CppFullySharedGenericType___getError
		            (param1,
		             Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle___ctor__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026E5")]
		[Address(RVA = "0x781A", Offset = "0x781A", VA = "0x781A")]
		public TitledListWithSpellTitle()
		{
		}

		// Token: 0x04001552 RID: 5458
		[Token(Token = "0x4001552")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private DiscountTargets[] _discountTargets;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_DiscountTargets ---
		void Gameplay_School_View_TitledListWithSpellTitle__get_DiscountTargets
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  int iVar8;
		  int *piVar9;
		  int iVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a04e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Discounts_View_DiscountInfoTitledListElementArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_IDiscountArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_IDiscountArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle__AddElement_DiscountInfoTitledListElement___
		              );
		    DAT_ram_00a5a04e = '\x01';
		  }
		  iVar10 = *param2;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_IDiscountArgs__TypeInfo ==
		          *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811b9742;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_IEnumerable_IDiscountArgs__TypeInfo,0);
		code_r0x811b9742:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x811b9779:
		  piVar6 = local_4;
		  iVar10 = *local_4;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      piVar9 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		      if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		        puVar3 = (undefined4 *)(iVar10 + piVar9[1] * 8 + 0xc0);
		        goto code_r0x811b9811;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar3 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                      System_Collections_IEnumerator_TypeInfo,0);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x811b9859:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x811b9b12;
		  }
		code_r0x811b9811:
		  DAT_ram_009d3e38 = 0;
		  iVar10 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		  piVar6 = local_4;
		  if (DAT_ram_009d3e38 == 1) goto code_r0x811b9859;
		  if (iVar10 == 0) {
		    iVar10 = 0;
		    goto code_r0x811b9b5b;
		  }
		  iVar10 = *local_4;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      piVar9 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		      if (System_Collections_Generic_IEnumerator_IDiscountArgs__TypeInfo == *piVar9) {
		        puVar3 = (undefined4 *)(iVar10 + piVar9[1] * 8 + 0xc0);
		        goto code_r0x811b98fc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar3 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                      System_Collections_Generic_IEnumerator_IDiscountArgs__TypeInfo,0);
		  if (DAT_ram_009d3e38 != 1) {
		code_r0x811b98fc:
		    DAT_ram_009d3e38 = 0;
		    piVar6 = (int *)import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811b9b00;
		    iVar10 = 0;
		    iVar5 = *(int *)(param1 + 0x2c);
		    if (0 < *(int *)(iVar5 + 0xc)) {
		      do {
		        iVar7 = *(int *)(iVar5 + iVar10 * 4 + 0x10);
		        iVar8 = *piVar6;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		            if (Gameplay_Discounts_Model_IDiscountArgs_TypeInfo == *piVar9) {
		              puVar3 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		              goto code_r0x811b99f1;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar3 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                            Gameplay_Discounts_Model_IDiscountArgs_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x811b9b0a:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811b9b12;
		        }
		code_r0x811b99f1:
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x811b9b0a;
		        if (iVar8 == iVar7) {
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::invoke_ii
		                            (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                             Gameplay_Discounts_View_DiscountInfoTitledListElementArgs_TypeInfo);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            Unity_Services_Core_Environments_Internal_Environments__get_Current(uVar4,piVar6,0);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x23d,param1,uVar4,
		                         Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle__AddElement_DiscountInfoTitledListElement___
		                        );
		              iVar7 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar7 != 1) goto code_r0x811b9ad0;
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x811b9b12;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811b9b12;
		        }
		code_r0x811b9ad0:
		        iVar10 = iVar10 + 1;
		      } while (iVar10 < *(int *)(iVar5 + 0xc));
		    }
		    goto code_r0x811b9779;
		  }
		code_r0x811b9b00:
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811b9b12:
		  iVar10 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar10 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar10 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar10;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x811b9b5b:
		      piVar6 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar5 = *local_4;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x811b9bd3;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x811b9bd3:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		      }
		      if (iVar10 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar10);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x23e,&local_c);
		  iVar10 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar10 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
