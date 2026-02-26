using System;
using Core.Data;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Rewards
{
	// Token: 0x02000191 RID: 401
	[Token(Token = "0x2000191")]
	public abstract class AbstractRewardsRender : MonoBehaviour, IDisposable
	{
		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017B")]
		public RewardData[] Rewards
		{
			[Token(Token = "0x6000B32")]
			[Address(RVA = "0x5E54", Offset = "0x5E54", VA = "0x5E54")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B33")]
			[Address(RVA = "0x5E55", Offset = "0x5E55", VA = "0x5E55")]
			set
			{
			}
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x5E56", Offset = "0x5E56", VA = "0x5E56", Slot = "5")]
		public virtual void RemoveAll()
		{
		/* --- GHIDRA: RemoveAll ---
		void UI_Rewards_AbstractRewardsRender__RemoveAll(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 *puVar1;
		  int param1_01;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a59a03 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Comparison_RewardData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Sirenix_Utilities_LinqExtensions_Sort_RewardData___);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Rewards_AbstractRewardsRender___c__HandleRewardChanged_b__9_0__);
		    Mono_Security_ASN1__get_Item(&UI_Rewards_AbstractRewardsRender___c_TypeInfo);
		    DAT_ram_00a59a03 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  if (param1_00 != 0) {
		    if (*(int *)(UI_Rewards_AbstractRewardsRender___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UI_Rewards_AbstractRewardsRender___c_TypeInfo);
		    }
		    puVar1 = *(undefined4 **)(UI_Rewards_AbstractRewardsRender___c_TypeInfo + 0x5c);
		    param1_01 = puVar1[1];
		    if (param1_01 == 0) {
		      if (*(int *)(UI_Rewards_AbstractRewardsRender___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UI_Rewards_AbstractRewardsRender___c_TypeInfo);
		        puVar1 = *(undefined4 **)(UI_Rewards_AbstractRewardsRender___c_TypeInfo + 0x5c);
		      }
		      param2_00 = *puVar1;
		      param1_01 = unnamed_function_1417(System_Comparison_RewardData__TypeInfo);
		      System_Collections_Generic_Comparer_object___get_Default
		                (param1_01,param2_00,
		                 Method_UI_Rewards_AbstractRewardsRender___c__HandleRewardChanged_b__9_0__,0);
		      *(int *)(*(int *)(UI_Rewards_AbstractRewardsRender___c_TypeInfo + 0x5c) + 4) = param1_01;
		    }
		    Sirenix_Utilities_LinqExtensions__Sort___Il2CppFullySharedGenericType_
		              (param1_00,param1_01,Method_Sirenix_Utilities_LinqExtensions_Sort_RewardData___);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x1C8C", Offset = "0x1C8C", VA = "0x1C8C")]
		public AbstractRewardsRender SetRewards(params RewardData[] rewards)
		{
		/* --- GHIDRA: SetRewards ---
		int UI_Rewards_AbstractRewardsRender__SetRewards(undefined4 param1,int param2)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int param1_01;
		  
		  puVar2 = *(undefined4 **)(param2 + 0x1c);
		  if (puVar2 == (undefined4 *)0x0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param2);
		    puVar2 = *(undefined4 **)(param2 + 0x1c);
		  }
		  uVar3 = *puVar2;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  iVar1 = 0;
		  uVar3 = func_ii_2734(uVar3,0);
		  param1_00 = UnityEngine_Component__TryGetComponent(param1,uVar3,0,0);
		  param1_01 = *(int *)(*(int *)(param2 + 0x1c) + 4);
		  if ((*(byte *)(param1_01 + 0xbd) & 1) == 0) {
		    param1_01 = func_ii_1079(param1_01);
		  }
		  if ((param1_00 != 0) && (iVar1 = func_ii_1082(param1_00,param1_01), iVar1 == 0)) {
		    System_Activator__CreateInstance(param1_00,param1_01);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x5E57", Offset = "0x5E57", VA = "0x5E57")]
		private void HandleRewardChanged()
		{
		/* --- GHIDRA: HandleRewardChanged ---
		void UI_Rewards_AbstractRewardsRender__HandleRewardChanged(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  
		  piVar2 = *(int **)(param1 + 0x1c);
		  if ((piVar2 == (int *)0x0) ||
		     (iVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xc0) * 4))
		                        (piVar2,0,*(undefined4 *)(*piVar2 + 0xc4)), iVar1 == 0)) {
		    *(undefined4 *)(param1 + 0x1c) = 0;
		    UI_Rewards_AbstractRewardsRender__RemoveAll(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000B37 RID: 2871
		[Token(Token = "0x6000B37")]
		public abstract void Render();

		// Token: 0x06000B38 RID: 2872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x5E58", Offset = "0x5E58", VA = "0x5E58", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void UI_Rewards_AbstractRewardsRender__Dispose(int param1,undefined4 param2)
		
		{
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_24;
		  undefined8 local_1c;
		  undefined8 local_14;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  local_c = 0x3f8000003f800000;
		  local_30 = 0x3f8000003f800000;
		  local_14 = 0x3f8000003f800000;
		  local_38 = 0x3f8000003f800000;
		  UnityEngine_Color32___ctor(&local_4,&local_38,0);
		  *(undefined4 *)(param1 + 0x14) = local_4;
		  local_1c = 0x3f8000003f800000;
		  local_40 = 0x3f8000003f800000;
		  local_24 = 0x3f8000003f800000;
		  local_48 = 0x3f8000003f800000;
		  UnityEngine_Color32___ctor(&local_4,&local_48,0);
		  *(undefined4 *)(param1 + 0x18) = local_4;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x5E59", Offset = "0x5E59", VA = "0x5E59")]
		protected AbstractRewardsRender()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Rewards_AbstractRewardsRender___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59a04 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Rewards_AbstractRewardsRender___c_TypeInfo);
		    DAT_ram_00a59a04 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(UI_Rewards_AbstractRewardsRender___c_TypeInfo);
		  **(undefined4 **)(UI_Rewards_AbstractRewardsRender___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04000514 RID: 1300
		[Token(Token = "0x4000514")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected Transform _content;

		// Token: 0x04000515 RID: 1301
		[Token(Token = "0x4000515")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected Color32 _labelColor;

		// Token: 0x04000516 RID: 1302
		[Token(Token = "0x4000516")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Color32 _valueColor;

		// Token: 0x04000517 RID: 1303
		[Token(Token = "0x4000517")]
		[FieldOffset(Offset = "0x1C")]
		protected RewardData[] _rewards;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Rewards ---
		void UI_Rewards_AbstractRewardsRender__get_Rewards(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *piVar2;
		  
		  piVar2 = *(int **)(param1 + 0x1c);
		  if ((piVar2 == (int *)0x0) ||
		     (iVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xc0) * 4))
		                        (piVar2,param2,*(undefined4 *)(*piVar2 + 0xc4)), iVar1 == 0)) {
		    *(undefined4 *)(param1 + 0x1c) = param2;
		    UI_Rewards_AbstractRewardsRender__RemoveAll(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Rewards ---
		void UI_Rewards_AbstractRewardsRender__set_Rewards(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  uint *puVar7;
		  int iVar8;
		  int iVar9;
		  int iVar10;
		  int *piVar11;
		  int local_14;
		  int **local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a59a02 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentsInChildren_RewardsContainer___);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a59a02 = '\x01';
		  }
		  local_8 = 0;
		  iVar3 = UnityEngine_Component__GetComponents___Il2CppFullySharedGenericType_
		                    (param1,Method_UnityEngine_Component_GetComponentsInChildren_RewardsContainer___
		                    );
		  iVar8 = *(int *)(iVar3 + 0xc);
		  if (0 < iVar8) {
		    do {
		      iVar9 = *(int *)(iVar3 + iVar1 * 4 + 0x10);
		      iVar10 = *(int *)(iVar9 + 0x10);
		      if (iVar10 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar10 + 0xc) * 4))
		                  (*(undefined4 *)(iVar10 + 0x20),*(undefined4 *)(iVar10 + 0x14));
		        iVar8 = *(int *)(iVar3 + 0xc);
		      }
		      *(undefined4 *)(iVar9 + 0x10) = 0;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < iVar8);
		  }
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x10),0);
		  local_c = &local_8;
		  local_14 = 0;
		  local_10 = &local_4;
		  do {
		    piVar6 = local_4;
		    iVar1 = *local_4;
		    if (*(ushort *)(iVar1 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar1 + 0x58) + uVar2 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		          puVar4 = (undefined4 *)(iVar1 + piVar11[1] * 8 + 0xc0);
		          goto code_r0x810a6b49;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar1 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x810a6d8c:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810a6d94;
		    }
		code_r0x810a6b49:
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		    piVar6 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x810a6d8c;
		    if (iVar1 == 0) goto code_r0x810a6ddd;
		    iVar1 = *local_4;
		    if (*(ushort *)(iVar1 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar1 + 0x58) + uVar2 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		          puVar4 = (undefined4 *)(piVar11[1] * 8 + iVar1 + 200);
		          goto code_r0x810a6c26;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar1 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x810a6d6e:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810a6d94;
		    }
		code_r0x810a6c26:
		    DAT_ram_009d3e38 = 0;
		    piVar6 = (int *)import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x810a6d6e;
		    if (piVar6 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar6 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar6 + 100) +
		                      (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		             UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar6,
		                   UnityEngine_Transform_TypeInfo);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810a6d94;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar6,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar5,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810a6d94:
		  iVar1 = global_1;
		  iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar8) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		    local_14 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		code_r0x810a6ddd:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar6 = (int *)*local_c;
		      if (piVar6 != (int *)0x0) {
		        iVar1 = *piVar6;
		        if (*(ushort *)(iVar1 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar2 * 8)) {
		              puVar7 = (uint *)(iVar1 + *(int *)(*(int *)(iVar1 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x810a6e6d;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar1 + 0xb6) != uVar2);
		        }
		        puVar7 = (uint *)func_ii_1080(piVar6,System_IDisposable_TypeInfo,0);
		code_r0x810a6e6d:
		        (**(code **)((ulonglong)*puVar7 * 4))(piVar6,puVar7[1]);
		      }
		      if (local_14 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_14);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x62,&local_14);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
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
		*/

}
