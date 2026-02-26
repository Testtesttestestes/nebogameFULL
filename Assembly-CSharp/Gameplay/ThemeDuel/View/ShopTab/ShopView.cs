using System;
using System.Collections;
using System.Collections.Generic;
using AssetContent.Loaders;
using Gameplay.ThemeDuelState.Model;
using Il2CppDummyDll;
using Protocol.Themeduel;
using TMPro;
using UnityEngine;

namespace Gameplay.ThemeDuel.View.ShopTab
{
	// Token: 0x020004DD RID: 1245
	[Token(Token = "0x20004DD")]
	public class ShopView : MonoBehaviour
	{
		// Token: 0x17000551 RID: 1361
		// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000551")]
		public string PointIconAssetId
		{
			[Token(Token = "0x6001DB0")]
			[Address(RVA = "0x6F2E", Offset = "0x6F2E", VA = "0x6F2E")]
			set
			{
			}
		}

		// Token: 0x17000552 RID: 1362
		// (set) Token: 0x06001DB1 RID: 7601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000552")]
		public ThemeDuelStateModel StateModel
		{
			[Token(Token = "0x6001DB1")]
			[Address(RVA = "0x6F2F", Offset = "0x6F2F", VA = "0x6F2F")]
			set
			{
			}
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DB2")]
		[Address(RVA = "0x6F30", Offset = "0x6F30", VA = "0x6F30")]
		private void StopCurrentCoroutine()
		{
		/* --- GHIDRA: StopCurrentCoroutine ---
		void Gameplay_ThemeDuel_View_ShopTab_ShopView__StopCurrentCoroutine
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  int *piVar7;
		  int iVar8;
		  int local_18;
		  int **local_14;
		  int *local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a585c2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_EventStoreItem__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_EventStoreItem__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Sprite__ToArray__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_ThemeDuelShopItemView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a585c2 = '\x01';
		  }
		  local_8 = 0;
		  local_c = (int *)0x0;
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x14),0);
		  local_10 = &local_8;
		  local_18 = 0;
		  local_14 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar2 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80f0e1a0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f0e3e3:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f0e3eb;
		    }
		code_r0x80f0e1a0:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f0e3e3;
		    if (iVar8 == 0) goto code_r0x80f0e434;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar2 = (undefined4 *)(piVar7[1] * 8 + iVar8 + 200);
		          goto code_r0x80f0e27d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f0e3c5:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f0e3eb;
		    }
		code_r0x80f0e27d:
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f0e3c5;
		    if (piVar5 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar5 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar5 + 100) +
		                      (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		             UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar5,
		                   UnityEngine_Transform_TypeInfo);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f0e3eb;
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
		code_r0x80f0e3eb:
		  iVar8 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_18 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		code_r0x80f0e434:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar5 = (int *)*local_10;
		      if (piVar5 != (int *)0x0) {
		        iVar8 = *piVar5;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80f0e4c4;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x80f0e4c4:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (local_18 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_18);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (param2 == (int *)0x0) {
		        return;
		      }
		      uVar1 = 0;
		      iVar8 = *param2;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        do {
		          if (System_Collections_Generic_IEnumerable_EventStoreItem__TypeInfo ==
		              *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		            puVar6 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80f0e584;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar6 = (uint *)func_ii_1080(param2,
		                                    System_Collections_Generic_IEnumerable_EventStoreItem__TypeInfo,
		                                    0);
		code_r0x80f0e584:
		      local_c = (int *)(**(code **)((ulonglong)*puVar6 * 4))(param2,puVar6[1]);
		      local_18 = 0;
		      local_14 = &local_c;
		      do {
		        piVar5 = local_c;
		        iVar8 = *local_c;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		              puVar2 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		              goto code_r0x80f0e650;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f0e8af:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f0e8b7;
		        }
		code_r0x80f0e650:
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		        piVar5 = local_c;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f0e8af;
		        if (iVar8 == 0) {
		          iVar8 = 0;
		          goto code_r0x80f0e900;
		        }
		        iVar8 = *local_c;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IEnumerator_EventStoreItem__TypeInfo == *piVar7) {
		              puVar2 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		              goto code_r0x80f0e72a;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                            System_Collections_Generic_IEnumerator_EventStoreItem__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f0e87d:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f0e8b7;
		        }
		code_r0x80f0e72a:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f0e87d;
		        param3_00 = *(undefined4 *)(param1 + 0x14);
		        param2_00 = *(undefined4 *)(param1 + 0x10);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80f0e8b7;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        piVar5 = (int *)import::env::invoke_iiii
		                                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,param2_00
		                                   ,param3_00,
		                                   Method_UnityEngine_Object_Instantiate_ThemeDuelShopItemView___);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f0e8b7;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x10a,
		                           *(undefined4 *)(param1 + 0x18),
		                           Method_System_Collections_Generic_List_Sprite__ToArray__);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f0e8b7;
		        }
		        piVar5[0x12] = iVar4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (*(undefined4 *)(*piVar5 + 0x138),piVar5,uVar3,*(undefined4 *)(*piVar5 + 0x13c));
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar8 != 1);
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f0e8b7:
		      iVar8 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar8 == iVar4) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar8 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar8;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		code_r0x80f0e900:
		          piVar5 = local_c;
		          DAT_ram_009d3e38 = 0;
		          if (local_c != (int *)0x0) {
		            uVar1 = 0;
		            iVar4 = *local_c;
		            if (*(ushort *)(iVar4 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		                  puVar6 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x80f0e978;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		            }
		            puVar6 = (uint *)func_ii_1080(local_c,System_IDisposable_TypeInfo,0);
		code_r0x80f0e978:
		            (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		          }
		          if (iVar8 == 0) {
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x187,&local_18);
		      goto joined_r0x80f0e9c7;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x186,&local_18);
		joined_r0x80f0e9c7:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DB3")]
		[Address(RVA = "0x6F31", Offset = "0x6F31", VA = "0x6F31")]
		public void PopulateGoods(IEnumerable<EventStoreItem> items)
		{
		/* --- GHIDRA: PopulateGoods ---
		int Gameplay_ThemeDuel_View_ShopTab_ShopView__PopulateGoods(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a585c3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ThemeDuel_View_ShopTab_ShopView__DisplayCurrentBackTime_d__14_TypeInfo);
		    DAT_ram_00a585c3 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_ThemeDuel_View_ShopTab_ShopView__DisplayCurrentBackTime_d__14_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001DB4")]
		[Address(RVA = "0x6F32", Offset = "0x6F32", VA = "0x6F32")]
		private IEnumerator DisplayCurrentBackTime()
		{
		/* --- GHIDRA: DisplayCurrentBackTime ---
		void Gameplay_ThemeDuel_View_ShopTab_ShopView__DisplayCurrentBackTime(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x2c) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x2c),0);
		    *(undefined4 *)(param1 + 0x2c) = 0;
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DB5")]
		[Address(RVA = "0x6F33", Offset = "0x6F33", VA = "0x6F33")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DB6")]
		[Address(RVA = "0x6F34", Offset = "0x6F34", VA = "0x6F34")]
		public ShopView()
		{
		}

		// Token: 0x04001021 RID: 4129
		[Token(Token = "0x4001021")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ThemeDuelShopItemView _itemViewPrefab;

		// Token: 0x04001022 RID: 4130
		[Token(Token = "0x4001022")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _shopContentContainer;

		// Token: 0x04001023 RID: 4131
		[Token(Token = "0x4001023")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Sprite> _markerSprites;

		// Token: 0x04001024 RID: 4132
		[Token(Token = "0x4001024")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameRawImageLoader _pointIcon;

		// Token: 0x04001025 RID: 4133
		[Token(Token = "0x4001025")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _timerText;

		// Token: 0x04001026 RID: 4134
		[Token(Token = "0x4001026")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameObject _timer;

		// Token: 0x04001027 RID: 4135
		[Token(Token = "0x4001027")]
		[FieldOffset(Offset = "0x28")]
		private ThemeDuelStateModel _stateModel;

		// Token: 0x04001028 RID: 4136
		[Token(Token = "0x4001028")]
		[FieldOffset(Offset = "0x2C")]
		private Coroutine _displayBackTimeCoroutine;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_PointIconAssetId ---
		void Gameplay_ThemeDuel_View_ShopTab_ShopView__set_PointIconAssetId
		               (int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  *(int *)(param1 + 0x28) = param2;
		  if (*(int *)(param1 + 0x2c) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x2c),0);
		    *(undefined4 *)(param1 + 0x2c) = 0;
		    param2 = *(int *)(param1 + 0x28);
		  }
		  if (param2 != 0) {
		    if (DAT_ram_00a585c3 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Gameplay_ThemeDuel_View_ShopTab_ShopView__DisplayCurrentBackTime_d__14_TypeInfo);
		      DAT_ram_00a585c3 = '\x01';
		    }
		    param1_00 = unnamed_function_1417
		                          (
		                          Gameplay_ThemeDuel_View_ShopTab_ShopView__DisplayCurrentBackTime_d__14_TypeInfo
		                          );
		    *(int *)(param1_00 + 0x10) = param1;
		    *(undefined4 *)(param1_00 + 8) = 0;
		    uVar1 = Utils_CoroutineSource__GetMono(param1_00,0);
		    *(undefined4 *)(param1 + 0x2c) = uVar1;
		  }
		  return;
		}
		*/


		/* --- GHIDRA: add_BuyEvent ---
		void Gameplay_Competition_View_Sections_Shop_ShopView__add_BuyEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63a96 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BankOptionData__TypeInfo);
		    DAT_ram_00a63a96 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_BankOptionData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BankOptionData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
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


		/* --- GHIDRA: get_BankOptionsListView ---
		void Gameplay_Competition_View_Sections_Shop_ShopView__get_BankOptionsListView
		               (undefined4 param1,int param2,undefined4 param3,undefined4 *param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  int param3_00;
		  undefined4 uVar1;
		  undefined4 param3_01;
		  
		  if (DAT_ram_00a63a97 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Control_Sections_ShopController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Events_ShopEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Model_ShopModel_TypeInfo);
		    DAT_ram_00a63a97 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param2 + 8);
		  param3_01 = *(undefined4 *)(*(int *)(param2 + 0xc) + 0x18);
		  param1_00 = unnamed_function_1417(Gameplay_Competition_Model_ShopModel_TypeInfo);
		  Gameplay_Competition_Model_ShopModel__set_Options(param1_00,param2,param3_01,uVar1,param2);
		  param3_00 = unnamed_function_1417(Gameplay_Competition_Events_ShopEvents_TypeInfo);
		  *(undefined4 *)(param3_00 + 0x14) = param3;
		  uVar1 = unnamed_function_1417(Gameplay_Competition_Control_Sections_ShopController_TypeInfo);
		  if (DAT_ram_00a63b0a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_ShopModel__ShopEvents___ctor__);
		    DAT_ram_00a63b0a = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (uVar1,param1_00,param3_00,Method_MVC_AbstractController_ShopModel__ShopEvents___ctor__)
		  ;
		  *param4 = uVar1;
		  return;
		}
		*/


		/* --- GHIDRA: CreateController ---
		void Gameplay_Competition_View_Sections_Shop_ShopView__CreateController
		               (undefined4 param1,int *param2,undefined4 *param3,undefined4 param4)
		
		{
		  undefined4 param3_00;
		  undefined4 param4_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63a98 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Control_Sections_ShopViewMediator_TypeInfo);
		    DAT_ram_00a63a98 = '\x01';
		  }
		  param3_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x100) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0x104));
		  param4_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x110) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0x114));
		  param1_00 = unnamed_function_1417(Gameplay_Competition_Control_Sections_ShopViewMediator_TypeInfo)
		  ;
		  if (DAT_ram_00a63b0c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_ShopModel__ShopEvents__ShopController__ShopView___ctor__
		              );
		    DAT_ram_00a63b0c = '\x01';
		  }
		  MVC_AbstractCozyViewMediator_object__object__object__object____ctor
		            (param1_00,param1,param3_00,param4_00,param2,
		             Method_MVC_AbstractCozyViewMediator_ShopModel__ShopEvents__ShopController__ShopView___ctor__
		            );
		  *param3 = param1_00;
		  return;
		}
		*/


		/* --- GHIDRA: RunController ---
		void Gameplay_Competition_View_Sections_Shop_ShopView__RunController
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63a99 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Competition_View_Sections_BaseSectionView_ShopController___ctor__);
		    DAT_ram_00a63a99 = '\x01';
		  }
		  Gameplay_AccountLinker_ProgressSaver_Controller_BaseProgressSaverEnterPointViewMediator_object___set_View
		            (param1,
		             Method_Gameplay_Competition_View_Sections_BaseSectionView_ShopController___ctor__);
		  return;
		}
		*/

}
