using System;
using System.Collections.Generic;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Dic;
using Protocol.Rating;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.VortexRating.View.VoteRewardsTab
{
	// Token: 0x02000388 RID: 904
	[Token(Token = "0x2000388")]
	public class VoteRewardsView : MonoBehaviour
	{
		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000377")]
		public Button SetGiftButton
		{
			[Token(Token = "0x6001512")]
			[Address(RVA = "0x66D4", Offset = "0x66D4", VA = "0x66D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001513")]
		[Address(RVA = "0x66D5", Offset = "0x66D5", VA = "0x66D5")]
		public GiftListElement[] Init(ProtoGetGreatTopAns ans, IList<GreatRewardSets> rewardSets, UserData user)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_VortexRating_View_VoteRewardsTab_VoteRewardsView__Init
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 local_4;
		  
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  local_4 = *(undefined4 *)(param2 + 0x10);
		  uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  local_4 = *(undefined4 *)(param2 + 0x14);
		  uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  local_4 = *(undefined4 *)(param2 + 0x1c);
		  uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x24);
		  local_4 = *(undefined4 *)(param2 + 0x20);
		  uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001514")]
		[Address(RVA = "0x66D6", Offset = "0x66D6", VA = "0x66D6")]
		public void UpdateRatings(ProtoGetGreatTopAns ans)
		{
		/* --- GHIDRA: UpdateRatings ---
		int * Gameplay_VortexRating_View_VoteRewardsTab_VoteRewardsView__UpdateRatings
		                (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  int *piVar7;
		  int iVar8;
		  int iVar9;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int *piVar10;
		  int local_14;
		  int **local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a581b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_GreatRewardSets__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_GreatRewardSets___);
		    Mono_Security_ASN1__get_Item(&System_Func_GreatRewardSets__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_VortexRating_View_VoteRewardsTab_GiftListElement___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_GreatRewardSets__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_GreatRewardSets__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_GiftListElement___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_View_VoteRewardsTab_VoteRewardsView___c__UpdateRewardSets_b__11_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_VortexRating_View_VoteRewardsTab_VoteRewardsView___c_TypeInfo);
		    DAT_ram_00a581b0 = '\x01';
		  }
		  local_8 = 0;
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x28),0);
		  local_c = &local_8;
		  local_14 = 0;
		  local_10 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar2 = (undefined4 *)(iVar9 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80eb2987;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80eb2bca:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80eb2bd2;
		    }
		code_r0x80eb2987:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80eb2bca;
		    if (iVar9 == 0) goto code_r0x80eb2c1b;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar2 = (undefined4 *)(piVar7[1] * 8 + iVar9 + 200);
		          goto code_r0x80eb2a64;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80eb2bac:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80eb2bd2;
		    }
		code_r0x80eb2a64:
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80eb2bac;
		    if (piVar5 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar5 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar5 + 100) +
		                      (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		             UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar5,
		                   UnityEngine_Transform_TypeInfo);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80eb2bd2;
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
		code_r0x80eb2bd2:
		  iVar9 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_14 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		code_r0x80eb2c1b:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar5 = (int *)*local_c;
		      if (piVar5 != (int *)0x0) {
		        iVar9 = *piVar5;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80eb2cab;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x80eb2cab:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (local_14 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_14);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (*(int *)(Gameplay_VortexRating_View_VoteRewardsTab_VoteRewardsView___c_TypeInfo + 0x74) ==
		          0) {
		        func_ii_306000(Gameplay_VortexRating_View_VoteRewardsTab_VoteRewardsView___c_TypeInfo);
		      }
		      puVar2 = *(undefined4 **)
		                (Gameplay_VortexRating_View_VoteRewardsTab_VoteRewardsView___c_TypeInfo + 0x5c);
		      iVar9 = puVar2[1];
		      if (iVar9 == 0) {
		        if (*(int *)(Gameplay_VortexRating_View_VoteRewardsTab_VoteRewardsView___c_TypeInfo + 0x74)
		            == 0) {
		          func_ii_306000(Gameplay_VortexRating_View_VoteRewardsTab_VoteRewardsView___c_TypeInfo);
		          puVar2 = *(undefined4 **)
		                    (Gameplay_VortexRating_View_VoteRewardsTab_VoteRewardsView___c_TypeInfo + 0x5c);
		        }
		        uVar3 = *puVar2;
		        iVar9 = unnamed_function_1417(System_Func_GreatRewardSets__uint__TypeInfo);
		        System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                  (iVar9,uVar3,
		                   Method_Gameplay_VortexRating_View_VoteRewardsTab_VoteRewardsView___c__UpdateRewardSets_b__11_0__
		                   ,0);
		        *(int *)(*(int *)(Gameplay_VortexRating_View_VoteRewardsTab_VoteRewardsView___c_TypeInfo +
		                         0x5c) + 4) = iVar9;
		      }
		      uVar1 = 0;
		      uVar3 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                        (param2,iVar9,Method_System_Linq_Enumerable_OrderBy_GreatRewardSets__uint___
		                        );
		      piVar5 = (int *)func_ii_6295(uVar3,Method_System_Linq_Enumerable_ToArray_GreatRewardSets___);
		      iVar9 = *piVar5;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        do {
		          if (System_Collections_Generic_ICollection_GreatRewardSets__TypeInfo ==
		              *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		            puVar6 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80eb2e05;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      puVar6 = (uint *)func_ii_1080(piVar5,
		                                    System_Collections_Generic_ICollection_GreatRewardSets__TypeInfo
		                                    ,0);
		code_r0x80eb2e05:
		      uVar3 = (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      piVar7 = (int *)Mono_Security_ASN1Convert__ToOid
		                                (Gameplay_VortexRating_View_VoteRewardsTab_GiftListElement___TypeInfo
		                                 ,uVar3);
		      iVar9 = 0;
		      do {
		        iVar4 = *piVar5;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_ICollection_GreatRewardSets__TypeInfo == *piVar10) {
		              puVar6 = (uint *)(iVar4 + piVar10[1] * 8 + 0xc0);
		              goto code_r0x80eb2e98;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,
		                                      System_Collections_Generic_ICollection_GreatRewardSets__TypeInfo
		                                      ,0);
		code_r0x80eb2e98:
		        iVar4 = (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		        if (iVar4 <= iVar9) {
		          return piVar7;
		        }
		        iVar4 = *piVar5;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IList_GreatRewardSets__TypeInfo == *piVar10) {
		              puVar6 = (uint *)(iVar4 + piVar10[1] * 8 + 0xc0);
		              goto code_r0x80eb2f17;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,
		                                      System_Collections_Generic_IList_GreatRewardSets__TypeInfo,0);
		code_r0x80eb2f17:
		        uVar3 = (**(code **)((ulonglong)*puVar6 * 4))(piVar5,iVar9,puVar6[1]);
		        param2_00 = *(undefined4 *)(param1 + 0x28);
		        param1_00 = *(undefined4 *)(param1 + 0x10);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          func_ii_306000(UnityEngine_Object_TypeInfo);
		        }
		        iVar4 = func_ii_6805(param1_00,param2_00,
		                             Method_UnityEngine_Object_Instantiate_GiftListElement___);
		        Gameplay_VortexRating_View_VoteRewardsTab_GiftListElement__Init(iVar4,uVar3,param3,iVar4);
		        if ((iVar4 != 0) &&
		           (iVar8 = func_ii_1082(iVar4,*(undefined4 *)(*piVar7 + 0x20)), iVar8 == 0)) {
		          uVar3 = func_ii_1083();
		          func_ii_1050(uVar3,0);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        piVar7[iVar9 + 4] = iVar4;
		        iVar9 = iVar9 + 1;
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x121,&local_14);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 != 1) {
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

		// Token: 0x06001515 RID: 5397 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001515")]
		[Address(RVA = "0x66D7", Offset = "0x66D7", VA = "0x66D7")]
		public GiftListElement[] UpdateRewardSets(IList<GreatRewardSets> rewardSets, UserData user)
		{
			return null;
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001516")]
		[Address(RVA = "0x66D8", Offset = "0x66D8", VA = "0x66D8")]
		public VoteRewardsView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_VortexRating_View_VoteRewardsTab_VoteRewardsView___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a581b1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_VortexRating_View_VoteRewardsTab_VoteRewardsView___c_TypeInfo);
		    DAT_ram_00a581b1 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_VortexRating_View_VoteRewardsTab_VoteRewardsView___c_TypeInfo);
		  **(undefined4 **)(Gameplay_VortexRating_View_VoteRewardsTab_VoteRewardsView___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04000B2A RID: 2858
		[Token(Token = "0x4000B2A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GiftListElement _giftListElementPrefab;

		// Token: 0x04000B2B RID: 2859
		[Token(Token = "0x4000B2B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _setGiftButton;

		// Token: 0x04000B2C RID: 2860
		[Token(Token = "0x4000B2C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _vortexRating;

		// Token: 0x04000B2D RID: 2861
		[Token(Token = "0x4000B2D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _likesRating;

		// Token: 0x04000B2E RID: 2862
		[Token(Token = "0x4000B2E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _giftsSent;

		// Token: 0x04000B2F RID: 2863
		[Token(Token = "0x4000B2F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _totalRating;

		// Token: 0x04000B30 RID: 2864
		[Token(Token = "0x4000B30")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _content;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SetGiftButton ---
		undefined4
		Gameplay_VortexRating_View_VoteRewardsTab_VoteRewardsView__get_SetGiftButton
		          (int param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  local_4 = *(undefined4 *)(param2 + 0x10);
		  uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  local_4 = *(undefined4 *)(param2 + 0x14);
		  uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  local_4 = *(undefined4 *)(param2 + 0x1c);
		  uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x24);
		  local_4 = *(undefined4 *)(param2 + 0x20);
		  uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  uVar1 = Gameplay_VortexRating_View_VoteRewardsTab_VoteRewardsView__UpdateRatings
		                    (param1,param3,param4,auStack_10);
		  return uVar1;
		}
		*/

}
