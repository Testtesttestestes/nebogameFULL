using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Elements.Buttons;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.VortexRating.View.GreatPrizesTab
{
	// Token: 0x0200038F RID: 911
	[Token(Token = "0x200038F")]
	public class GreatPrizesView : MonoBehaviour
	{
		// Token: 0x1700037B RID: 891
		// (get) Token: 0x0600152E RID: 5422 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700037B")]
		public RewardsRender RewardsView
		{
			[Token(Token = "0x600152E")]
			[Address(RVA = "0x66F0", Offset = "0x66F0", VA = "0x66F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x0600152F RID: 5423 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700037C")]
		public GenericListFilter FilterView
		{
			[Token(Token = "0x600152F")]
			[Address(RVA = "0x66F1", Offset = "0x66F1", VA = "0x66F1")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700037D")]
		public ButtonWithCost InVortexButton
		{
			[Token(Token = "0x6001530")]
			[Address(RVA = "0x66F2", Offset = "0x66F2", VA = "0x66F2")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001531")]
		[Address(RVA = "0x66F3", Offset = "0x66F3", VA = "0x66F3")]
		public PrizeListElement[] Init(IList<RatingPrizeDic> prizes, string period)
		{
			return null;
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001532")]
		[Address(RVA = "0x66F4", Offset = "0x66F4", VA = "0x66F4")]
		public GreatPrizesView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_VortexRating_View_GreatPrizesTab_GreatPrizesView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a581bb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PrizeListElement__TypeInfo);
		    DAT_ram_00a581bb = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_PrizeListElement__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_PrizeListElement__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04000B40 RID: 2880
		[Token(Token = "0x4000B40")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private PrizeListElement _prizeListElementPrefab;

		// Token: 0x04000B41 RID: 2881
		[Token(Token = "0x4000B41")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x04000B42 RID: 2882
		[Token(Token = "0x4000B42")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RewardsRender _rewardsView;

		// Token: 0x04000B43 RID: 2883
		[Token(Token = "0x4000B43")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GenericListFilter _filterView;

		// Token: 0x04000B44 RID: 2884
		[Token(Token = "0x4000B44")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ButtonWithCost _inVortexButton;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_InVortexButton ---
		int * Gameplay_VortexRating_View_GreatPrizesTab_GreatPrizesView__get_InVortexButton
		                (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  int iVar7;
		  undefined4 param1_00;
		  int iVar8;
		  int *piVar9;
		  int local_14;
		  int **local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a581ba == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_RatingPrizeDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_RatingPrizeDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_PrizeListElement___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a581ba = '\x01';
		  }
		  local_8 = 0;
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x14),0);
		  local_c = &local_8;
		  local_14 = 0;
		  local_10 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar2 = (undefined4 *)(iVar7 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80eb41ab;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80eb43ee:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80eb43f6;
		    }
		code_r0x80eb41ab:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80eb43ee;
		    if (iVar7 == 0) goto code_r0x80eb443f;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar2 = (undefined4 *)(piVar9[1] * 8 + iVar7 + 200);
		          goto code_r0x80eb4288;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80eb43d0:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80eb43f6;
		    }
		code_r0x80eb4288:
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80eb43d0;
		    if (piVar5 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar5 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar5 + 100) +
		                      (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		             UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar5,
		                   UnityEngine_Transform_TypeInfo);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80eb43f6;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar5,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar3,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80eb43f6:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_14 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x80eb443f:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar5 = (int *)*local_c;
		      if (piVar5 != (int *)0x0) {
		        iVar7 = *piVar5;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80eb44cf;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x80eb44cf:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (local_14 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_14);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar1 = 0;
		      iVar7 = *param2;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (System_Collections_Generic_ICollection_RatingPrizeDic__TypeInfo ==
		              *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		            puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80eb4555;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar6 = (uint *)func_ii_1080(param2,
		                                    System_Collections_Generic_ICollection_RatingPrizeDic__TypeInfo,
		                                    0);
		code_r0x80eb4555:
		      uVar3 = (**(code **)((ulonglong)*puVar6 * 4))(param2,puVar6[1]);
		      piVar5 = (int *)Mono_Security_ASN1Convert__ToOid
		                                (Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement___TypeInfo
		                                 ,uVar3);
		      iVar7 = 0;
		      do {
		        iVar4 = *param2;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_ICollection_RatingPrizeDic__TypeInfo == *piVar9) {
		              puVar6 = (uint *)(iVar4 + piVar9[1] * 8 + 0xc0);
		              goto code_r0x80eb4622;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(param2,
		                                      System_Collections_Generic_ICollection_RatingPrizeDic__TypeInfo
		                                      ,0);
		code_r0x80eb4622:
		        iVar4 = (**(code **)((ulonglong)*puVar6 * 4))(param2,puVar6[1]);
		        if (iVar4 <= iVar7) {
		          return piVar5;
		        }
		        uVar3 = *(undefined4 *)(param1 + 0x14);
		        param1_00 = *(undefined4 *)(param1 + 0x10);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          func_ii_306000(UnityEngine_Object_TypeInfo);
		        }
		        iVar4 = func_ii_6805(param1_00,uVar3,
		                             Method_UnityEngine_Object_Instantiate_PrizeListElement___);
		        iVar8 = *param2;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IList_RatingPrizeDic__TypeInfo == *piVar9) {
		              puVar6 = (uint *)(iVar8 + piVar9[1] * 8 + 0xc0);
		              goto code_r0x80eb46da;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(param2,
		                                      System_Collections_Generic_IList_RatingPrizeDic__TypeInfo,0);
		code_r0x80eb46da:
		        uVar3 = (**(code **)((ulonglong)*puVar6 * 4))(param2,iVar7,puVar6[1]);
		        Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement__OnDestroy
		                  (iVar4,uVar3,param3,puVar6);
		        if ((iVar4 != 0) &&
		           (iVar8 = func_ii_1082(iVar4,*(undefined4 *)(*piVar5 + 0x20)), iVar8 == 0)) {
		          uVar3 = func_ii_1083();
		          func_ii_1050(uVar3,0);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        piVar5[iVar7 + 4] = iVar4;
		        iVar7 = iVar7 + 1;
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x124,&local_14);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 != 1) {
		    import::env::__resumeException(uVar3);
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
		*/

}
