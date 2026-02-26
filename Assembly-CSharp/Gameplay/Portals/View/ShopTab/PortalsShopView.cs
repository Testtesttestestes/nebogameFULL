using System;
using System.Collections;
using System.Collections.Generic;
using AssetContent;
using Gameplay.Portals.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Filters;
using UnityEngine;

namespace Gameplay.Portals.View.ShopTab
{
	// Token: 0x020005C0 RID: 1472
	[Token(Token = "0x20005C0")]
	public class PortalsShopView : MonoBehaviour
	{
		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700068D")]
		public TextMeshProUGUI FromCount
		{
			[Token(Token = "0x6002352")]
			[Address(RVA = "0x74A6", Offset = "0x74A6", VA = "0x74A6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06002353 RID: 9043 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700068E")]
		public TextMeshProUGUI ToCount
		{
			[Token(Token = "0x6002353")]
			[Address(RVA = "0x74A7", Offset = "0x74A7", VA = "0x74A7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06002354 RID: 9044 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700068F")]
		public FiltersView FiltersView
		{
			[Token(Token = "0x6002354")]
			[Address(RVA = "0x74A8", Offset = "0x74A8", VA = "0x74A8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06002355 RID: 9045 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000690")]
		public MetaFiltersView MetaFiltersView
		{
			[Token(Token = "0x6002355")]
			[Address(RVA = "0x74A9", Offset = "0x74A9", VA = "0x74A9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06002356 RID: 9046 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000691")]
		public GameRawImage Icon
		{
			[Token(Token = "0x6002356")]
			[Address(RVA = "0x74AA", Offset = "0x74AA", VA = "0x74AA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06002357 RID: 9047 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000692")]
		public RectTransform ExchangeMessage
		{
			[Token(Token = "0x6002357")]
			[Address(RVA = "0x74AB", Offset = "0x74AB", VA = "0x74AB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06002358 RID: 9048 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000693")]
		public GameObject Description
		{
			[Token(Token = "0x6002358")]
			[Address(RVA = "0x74AC", Offset = "0x74AC", VA = "0x74AC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002359")]
		[Address(RVA = "0x74AD", Offset = "0x74AD", VA = "0x74AD")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Portals_View_ShopTab_PortalsShopView__Init(int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  *(int *)(param1 + 0x3c) = param2;
		  if (*(int *)(param1 + 0x40) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x40),0);
		    *(undefined4 *)(param1 + 0x40) = 0;
		    param2 = *(int *)(param1 + 0x3c);
		  }
		  if (param2 != 0) {
		    if (DAT_ram_00a58104 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Gameplay_Portals_View_ShopTab_PortalsShopView__DisplayCurrentBackTime_d__32_TypeInfo
		                );
		      DAT_ram_00a58104 = '\x01';
		    }
		    param1_00 = unnamed_function_1417
		                          (
		                          Gameplay_Portals_View_ShopTab_PortalsShopView__DisplayCurrentBackTime_d__32_TypeInfo
		                          );
		    *(int *)(param1_00 + 0x10) = param1;
		    *(undefined4 *)(param1_00 + 8) = 0;
		    uVar1 = Utils_CoroutineSource__GetMono(param1_00,0);
		    *(undefined4 *)(param1 + 0x40) = uVar1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000694 RID: 1684
		// (set) Token: 0x0600235A RID: 9050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000694")]
		public PortalsModel Model
		{
			[Token(Token = "0x600235A")]
			[Address(RVA = "0x74AE", Offset = "0x74AE", VA = "0x74AE")]
			set
			{
			}
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235B")]
		[Address(RVA = "0x74AF", Offset = "0x74AF", VA = "0x74AF")]
		private void StopCurrentCoroutine()
		{
		/* --- GHIDRA: StopCurrentCoroutine ---
		void Gameplay_Portals_View_ShopTab_PortalsShopView__StopCurrentCoroutine
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  uint *puVar5;
		  int iVar6;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  int *piVar7;
		  uint uVar8;
		  int local_24;
		  int **local_20;
		  int *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a58103 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ShopItemData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ShopItemData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ShopItemData__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ShopItemData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Sprite__ToArray__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_PortalsShopItemView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a58103 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x14),0);
		  local_1c = &local_8;
		  local_24 = 0;
		  local_20 = &local_4;
		  do {
		    piVar4 = local_4;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar1 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80ea2d8a;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar1 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ea2fcd:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ea2fd5;
		    }
		code_r0x80ea2d8a:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar1,piVar4,puVar1[1]);
		    piVar4 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ea2fcd;
		    if (iVar6 == 0) goto code_r0x80ea301e;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar1 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 200);
		          goto code_r0x80ea2e67;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar1 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ea2faf:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ea2fd5;
		    }
		code_r0x80ea2e67:
		    DAT_ram_009d3e38 = 0;
		    piVar4 = (int *)import::env::invoke_iii(*puVar1,piVar4,puVar1[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ea2faf;
		    if (piVar4 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar4 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar4 + 100) +
		                      (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		             UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar4,
		                   UnityEngine_Transform_TypeInfo);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ea2fd5;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar4,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar2,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ea2fd5:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    local_24 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x80ea301e:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar4 = (int *)*local_1c;
		      if (piVar4 != (int *)0x0) {
		        iVar6 = *piVar4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar8 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8)) {
		              puVar5 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80ea30ae;
		            }
		            uVar8 = uVar8 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar4,System_IDisposable_TypeInfo,0);
		code_r0x80ea30ae:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		      }
		      if (local_24 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_24);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (param2 == 0) {
		        return;
		      }
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_18,param2,
		                 Method_System_Collections_Generic_List_ShopItemData__GetEnumerator__);
		      local_24 = 0;
		      local_20 = (int **)&local_18;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_18,
		                           Method_System_Collections_Generic_List_Enumerator_ShopItemData__MoveNext__
		                          );
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80ea32c5;
		        }
		        if (iVar3 == 0) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        param3_00 = *(undefined4 *)(param1 + 0x14);
		        param2_00 = *(undefined4 *)(param1 + 0x10);
		        uVar2 = local_10._4_4_;
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80ea32c5;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        piVar4 = (int *)import::env::invoke_iiii
		                                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,param2_00
		                                   ,param3_00,
		                                   Method_UnityEngine_Object_Instantiate_PortalsShopItemView___);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80ea32c5;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x10a,
		                           *(undefined4 *)(param1 + 0x18),
		                           Method_System_Collections_Generic_List_Sprite__ToArray__);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80ea32c5;
		        }
		        piVar4[0x12] = iVar3;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (*(undefined4 *)(*piVar4 + 0x138),piVar4,uVar2,*(undefined4 *)(*piVar4 + 0x13c));
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar6 != 1);
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ea32c5:
		      iVar6 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar6 == iVar3) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar3 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_24 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 != 1) {
		          if (iVar3 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x10b,&local_24);
		      goto joined_r0x80ea3355;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x109,&local_24);
		joined_r0x80ea3355:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar2);
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

		// Token: 0x0600235C RID: 9052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235C")]
		[Address(RVA = "0x74B0", Offset = "0x74B0", VA = "0x74B0")]
		public void PopulateGoods(List<ShopItemData> items)
		{
		/* --- GHIDRA: PopulateGoods ---
		int Gameplay_Portals_View_ShopTab_PortalsShopView__PopulateGoods
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58104 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Portals_View_ShopTab_PortalsShopView__DisplayCurrentBackTime_d__32_TypeInfo
		              );
		    DAT_ram_00a58104 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Portals_View_ShopTab_PortalsShopView__DisplayCurrentBackTime_d__32_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x0600235D RID: 9053 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600235D")]
		[Address(RVA = "0x74B1", Offset = "0x74B1", VA = "0x74B1")]
		private IEnumerator DisplayCurrentBackTime()
		{
			return null;
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235E")]
		[Address(RVA = "0x74B2", Offset = "0x74B2", VA = "0x74B2")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235F")]
		[Address(RVA = "0x74B3", Offset = "0x74B3", VA = "0x74B3")]
		public PortalsShopView()
		{
		}

		// Token: 0x04001368 RID: 4968
		[Token(Token = "0x4001368")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private PortalsShopItemView _itemViewPrefab;

		// Token: 0x04001369 RID: 4969
		[Token(Token = "0x4001369")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _shopContentContainer;

		// Token: 0x0400136A RID: 4970
		[Token(Token = "0x400136A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Sprite> _markerSprites;

		// Token: 0x0400136B RID: 4971
		[Token(Token = "0x400136B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _timerText;

		// Token: 0x0400136C RID: 4972
		[Token(Token = "0x400136C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _exchangeMessage;

		// Token: 0x0400136D RID: 4973
		[Token(Token = "0x400136D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _fromCount;

		// Token: 0x0400136E RID: 4974
		[Token(Token = "0x400136E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _toCount;

		// Token: 0x0400136F RID: 4975
		[Token(Token = "0x400136F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameObject _description;

		// Token: 0x04001370 RID: 4976
		[Token(Token = "0x4001370")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FiltersView _filtersView;

		// Token: 0x04001371 RID: 4977
		[Token(Token = "0x4001371")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private MetaFiltersView _metaFiltersView;

		// Token: 0x04001372 RID: 4978
		[Token(Token = "0x4001372")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x04001373 RID: 4979
		[Token(Token = "0x4001373")]
		[FieldOffset(Offset = "0x3C")]
		private PortalsModel _model;

		// Token: 0x04001374 RID: 4980
		[Token(Token = "0x4001374")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine _displayBackTimeCoroutine;
	}
}
