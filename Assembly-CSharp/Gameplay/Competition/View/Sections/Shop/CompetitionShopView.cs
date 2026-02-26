using System;
using System.Collections;
using System.Collections.Generic;
using AssetContent;
using Gameplay.Competition.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Filters;
using UnityEngine;

namespace Gameplay.Competition.View.Sections.Shop
{
	// Token: 0x020008E3 RID: 2275
	[Token(Token = "0x20008E3")]
	public class CompetitionShopView : MonoBehaviour
	{
		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06003592 RID: 13714 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A99")]
		public TextMeshProUGUI FromCount
		{
			[Token(Token = "0x6003592")]
			[Address(RVA = "0x85A0", Offset = "0x85A0", VA = "0x85A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06003593 RID: 13715 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A9A")]
		public TextMeshProUGUI ToCount
		{
			[Token(Token = "0x6003593")]
			[Address(RVA = "0x85A1", Offset = "0x85A1", VA = "0x85A1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06003594 RID: 13716 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A9B")]
		public FiltersView FiltersView
		{
			[Token(Token = "0x6003594")]
			[Address(RVA = "0x85A2", Offset = "0x85A2", VA = "0x85A2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06003595 RID: 13717 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A9C")]
		public MetaFiltersView MetaFiltersView
		{
			[Token(Token = "0x6003595")]
			[Address(RVA = "0x85A3", Offset = "0x85A3", VA = "0x85A3")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06003596 RID: 13718 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A9D")]
		public GameRawImage Icon
		{
			[Token(Token = "0x6003596")]
			[Address(RVA = "0x85A4", Offset = "0x85A4", VA = "0x85A4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06003597 RID: 13719 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A9E")]
		public RectTransform ExchangeMessage
		{
			[Token(Token = "0x6003597")]
			[Address(RVA = "0x85A5", Offset = "0x85A5", VA = "0x85A5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06003598 RID: 13720 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A9F")]
		public GameObject Description
		{
			[Token(Token = "0x6003598")]
			[Address(RVA = "0x85A6", Offset = "0x85A6", VA = "0x85A6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003599")]
		[Address(RVA = "0x85A7", Offset = "0x85A7", VA = "0x85A7")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Competition_View_Sections_Shop_CompetitionShopView__Init
		               (int param1,int param2,undefined4 param3)
		
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
		    if (DAT_ram_00a63a93 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Gameplay_Competition_View_Sections_Shop_CompetitionShopView__DisplayCurrentBackTime_d__32_TypeInfo
		                );
		      DAT_ram_00a63a93 = '\x01';
		    }
		    param1_00 = unnamed_function_1417
		                          (
		                          Gameplay_Competition_View_Sections_Shop_CompetitionShopView__DisplayCurrentBackTime_d__32_TypeInfo
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

		// Token: 0x17000AA0 RID: 2720
		// (set) Token: 0x0600359A RID: 13722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AA0")]
		public CompetitionModel Model
		{
			[Token(Token = "0x600359A")]
			[Address(RVA = "0x85A8", Offset = "0x85A8", VA = "0x85A8")]
			set
			{
			}
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600359B")]
		[Address(RVA = "0x85A9", Offset = "0x85A9", VA = "0x85A9")]
		private void StopCurrentCoroutine()
		{
		/* --- GHIDRA: StopCurrentCoroutine ---
		void Gameplay_Competition_View_Sections_Shop_CompetitionShopView__StopCurrentCoroutine
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
		  
		  if (DAT_ram_00a63a92 == '\0') {
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
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_CompetitionShopItemView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a63a92 = '\x01';
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
		          goto code_r0x82336711;
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
		code_r0x82336954:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8233695c;
		    }
		code_r0x82336711:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar1,piVar4,puVar1[1]);
		    piVar4 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x82336954;
		    if (iVar6 == 0) goto code_r0x823369a5;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar1 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 200);
		          goto code_r0x823367ee;
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
		code_r0x82336936:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8233695c;
		    }
		code_r0x823367ee:
		    DAT_ram_009d3e38 = 0;
		    piVar4 = (int *)import::env::invoke_iii(*puVar1,piVar4,puVar1[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x82336936;
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
		        goto code_r0x8233695c;
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
		code_r0x8233695c:
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
		code_r0x823369a5:
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
		              goto code_r0x82336a35;
		            }
		            uVar8 = uVar8 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar4,System_IDisposable_TypeInfo,0);
		code_r0x82336a35:
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
		          goto code_r0x82336c4d;
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
		            goto code_r0x82336c4d;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        piVar4 = (int *)import::env::invoke_iiii
		                                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,param2_00
		                                   ,param3_00,
		                                   Method_UnityEngine_Object_Instantiate_CompetitionShopItemView___)
		        ;
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x82336c4d;
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
		          goto code_r0x82336c4d;
		        }
		        piVar4[0x12] = iVar3;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (*(undefined4 *)(*piVar4 + 0x138),piVar4,uVar2,*(undefined4 *)(*piVar4 + 0x13c));
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar6 != 1);
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x82336c4d:
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
		      import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x2d,&local_24);
		      goto joined_r0x82336cde;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x2c,&local_24);
		joined_r0x82336cde:
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

		// Token: 0x0600359C RID: 13724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600359C")]
		[Address(RVA = "0x85AA", Offset = "0x85AA", VA = "0x85AA")]
		public void PopulateGoods(List<ShopItemData> items)
		{
		/* --- GHIDRA: PopulateGoods ---
		int Gameplay_Competition_View_Sections_Shop_CompetitionShopView__PopulateGoods
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63a93 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Competition_View_Sections_Shop_CompetitionShopView__DisplayCurrentBackTime_d__32_TypeInfo
		              );
		    DAT_ram_00a63a93 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Competition_View_Sections_Shop_CompetitionShopView__DisplayCurrentBackTime_d__32_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x0600359D RID: 13725 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600359D")]
		[Address(RVA = "0x85AB", Offset = "0x85AB", VA = "0x85AB")]
		private IEnumerator DisplayCurrentBackTime()
		{
		/* --- GHIDRA: DisplayCurrentBackTime ---
		void Gameplay_Competition_View_Sections_Shop_CompetitionShopView__DisplayCurrentBackTime
		               (int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x40) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x40),0);
		    *(undefined4 *)(param1 + 0x40) = 0;
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600359E RID: 13726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600359E")]
		[Address(RVA = "0x85AC", Offset = "0x85AC", VA = "0x85AC")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600359F RID: 13727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600359F")]
		[Address(RVA = "0x85AD", Offset = "0x85AD", VA = "0x85AD")]
		public CompetitionShopView()
		{
		}

		// Token: 0x04001D4A RID: 7498
		[Token(Token = "0x4001D4A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CompetitionShopItemView _itemViewPrefab;

		// Token: 0x04001D4B RID: 7499
		[Token(Token = "0x4001D4B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _shopContentContainer;

		// Token: 0x04001D4C RID: 7500
		[Token(Token = "0x4001D4C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Sprite> _markerSprites;

		// Token: 0x04001D4D RID: 7501
		[Token(Token = "0x4001D4D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _timerText;

		// Token: 0x04001D4E RID: 7502
		[Token(Token = "0x4001D4E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _exchangeMessage;

		// Token: 0x04001D4F RID: 7503
		[Token(Token = "0x4001D4F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _fromCount;

		// Token: 0x04001D50 RID: 7504
		[Token(Token = "0x4001D50")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _toCount;

		// Token: 0x04001D51 RID: 7505
		[Token(Token = "0x4001D51")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameObject _description;

		// Token: 0x04001D52 RID: 7506
		[Token(Token = "0x4001D52")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FiltersView _filtersView;

		// Token: 0x04001D53 RID: 7507
		[Token(Token = "0x4001D53")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private MetaFiltersView _metaFiltersView;

		// Token: 0x04001D54 RID: 7508
		[Token(Token = "0x4001D54")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x04001D55 RID: 7509
		[Token(Token = "0x4001D55")]
		[FieldOffset(Offset = "0x3C")]
		private CompetitionModel _model;

		// Token: 0x04001D56 RID: 7510
		[Token(Token = "0x4001D56")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine _displayBackTimeCoroutine;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Description ---
		void Gameplay_Competition_View_Sections_Shop_CompetitionShopView__get_Description
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x2c),0,0);
		  return;
		}
		*/

}
