using System;
using System.Collections.Generic;
using Gameplay.VortexRating.View.GreatPrizesTab;
using Il2CppDummyDll;
using Protocol.Dic;
using UI;
using UI.Elements.Filters.GenericFilter;
using UI.Rewards;
using UI.Tabs;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View.Rewards
{
	// Token: 0x020002F5 RID: 757
	[Token(Token = "0x20002F5")]
	public class SeasonRewardsView : MonoBehaviourWithStates<SeasonRewardsView.Tab>
	{
		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002AE")]
		public RewardsRender RewardsView
		{
			[Token(Token = "0x60011E6")]
			[Address(RVA = "0x63E1", Offset = "0x63E1", VA = "0x63E1")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002AF")]
		public GenericFilterView PeriodFilter
		{
			[Token(Token = "0x60011E7")]
			[Address(RVA = "0x63E2", Offset = "0x63E2", VA = "0x63E2")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002B0")]
		public TabBar TabBar
		{
			[Token(Token = "0x60011E8")]
			[Address(RVA = "0x63E3", Offset = "0x63E3", VA = "0x63E3")]
			get
			{
				return null;
			}
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60011E9")]
		[Address(RVA = "0x63E4", Offset = "0x63E4", VA = "0x63E4")]
		public PrizeListElement[] Init(IList<RatingPrizeDic> prizes, string period)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_WorldAxis_Office_View_Rewards_SeasonRewardsView__Init
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58b9c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_SeasonRewardsView_Tab___ctor__);
		    DAT_ram_00a58b9c = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_SeasonRewardsView_Tab___ctor__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011EA")]
		[Address(RVA = "0x63E5", Offset = "0x63E5", VA = "0x63E5")]
		public SeasonRewardsView()
		{
		}

		// Token: 0x04000951 RID: 2385
		[Token(Token = "0x4000951")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private PrizeListElement _prizeListElementPrefab;

		// Token: 0x04000952 RID: 2386
		[Token(Token = "0x4000952")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x04000953 RID: 2387
		[Token(Token = "0x4000953")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private RewardsRender _rewardsView;

		// Token: 0x04000954 RID: 2388
		[Token(Token = "0x4000954")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GenericFilterView _periodFilter;

		// Token: 0x04000955 RID: 2389
		[Token(Token = "0x4000955")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x020002F6 RID: 758
		[Token(Token = "0x20002F6")]
		public enum Tab
		{
			// Token: 0x04000957 RID: 2391
			[Token(Token = "0x4000957")]
			UNKNOWN_TAB,
			// Token: 0x04000958 RID: 2392
			[Token(Token = "0x4000958")]
			USERS,
			// Token: 0x04000959 RID: 2393
			[Token(Token = "0x4000959")]
			CLANS
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_TabBar ---
		int * Gameplay_WorldAxis_Office_View_Rewards_SeasonRewardsView__get_TabBar
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
		  
		  if (DAT_ram_00a58b9b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_RatingPrizeDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_RatingPrizeDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_PrizeListElement___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a58b9b = '\x01';
		  }
		  local_8 = 0;
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x20),0);
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
		          goto code_r0x80f802ae;
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
		code_r0x80f804f1:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f804f9;
		    }
		code_r0x80f802ae:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f804f1;
		    if (iVar7 == 0) goto code_r0x80f80542;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar2 = (undefined4 *)(piVar9[1] * 8 + iVar7 + 200);
		          goto code_r0x80f8038b;
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
		code_r0x80f804d3:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f804f9;
		    }
		code_r0x80f8038b:
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f804d3;
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
		        goto code_r0x80f804f9;
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
		code_r0x80f804f9:
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
		code_r0x80f80542:
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
		              goto code_r0x80f805d2;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x80f805d2:
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
		            goto code_r0x80f80658;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar6 = (uint *)func_ii_1080(param2,
		                                    System_Collections_Generic_ICollection_RatingPrizeDic__TypeInfo,
		                                    0);
		code_r0x80f80658:
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
		              goto code_r0x80f80725;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(param2,
		                                      System_Collections_Generic_ICollection_RatingPrizeDic__TypeInfo
		                                      ,0);
		code_r0x80f80725:
		        iVar4 = (**(code **)((ulonglong)*puVar6 * 4))(param2,puVar6[1]);
		        if (iVar4 <= iVar7) {
		          return piVar5;
		        }
		        uVar3 = *(undefined4 *)(param1 + 0x20);
		        param1_00 = *(undefined4 *)(param1 + 0x1c);
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
		              goto code_r0x80f807dd;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(param2,
		                                      System_Collections_Generic_IList_RatingPrizeDic__TypeInfo,0);
		code_r0x80f807dd:
		        uVar3 = (**(code **)((ulonglong)*puVar6 * 4))(param2,iVar7,puVar6[1]);
		        Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement__OnDestroy(iVar4,uVar3,param3,0);
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
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x24b,&local_14);
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
