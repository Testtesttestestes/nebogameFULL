using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Discounts.Controller;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Discounts.View
{
	// Token: 0x02000897 RID: 2199
	[Token(Token = "0x2000897")]
	public class DiscountsWindow : ClosableBaseWindow<DiscountsWindow.DicountsWindowArgs>
	{
		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x060033CE RID: 13262 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A43")]
		public override string WindowId
		{
			[Token(Token = "0x60033CE")]
			[Address(RVA = "0x8406", Offset = "0x8406", VA = "0x8406", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060033CF RID: 13263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033CF")]
		[Address(RVA = "0x8407", Offset = "0x8407", VA = "0x8407", Slot = "22")]
		protected override void OnShow(DiscountsWindow.DicountsWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Discounts_View_DiscountsWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57cb5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_DiscountsWindow_DicountsWindowArgs__OnClose__);
		    DAT_ram_00a57cb5 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_DiscountsWindow_DicountsWindowArgs__OnClose__);
		  if (*(char *)(param1 + 0x48) != '\0') {
		    iVar1 = **(int **)(param1 + 0x44);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 0x44),*(undefined4 *)(iVar1 + 0x134));
		    *(undefined4 *)(param1 + 0x44) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060033D0 RID: 13264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D0")]
		[Address(RVA = "0x8408", Offset = "0x8408", VA = "0x8408", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Discounts_View_DiscountsWindow__OnClose(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  undefined4 uVar7;
		  undefined4 param2_00;
		  int *piVar8;
		  int iVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57cb6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Discounts_View_DiscountListElement_DiscountListElementArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_DiscountListElement_DiscountListElementArgs__Init__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_DiscountData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_DiscountData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_DiscountListElement___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a57cb6 = '\x01';
		  }
		  iVar9 = *param2;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_DiscountData__TypeInfo ==
		          *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e4517e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_IEnumerable_DiscountData__TypeInfo
		                                ,0);
		code_r0x80e4517e:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar6 = local_4;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(iVar9 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80e45252;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e454c6:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e454ce;
		    }
		code_r0x80e45252:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    piVar6 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e454c6;
		    if (iVar9 == 0) {
		      iVar9 = 0;
		      goto code_r0x80e45517;
		    }
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_DiscountData__TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(iVar9 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80e4532c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_DiscountData__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e45494:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e454ce;
		    }
		code_r0x80e4532c:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e45494;
		    uVar7 = *(undefined4 *)(param1 + 0x40);
		    param2_00 = *(undefined4 *)(param1 + 0x3c);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e454ce;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar7 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,param2_00,uVar7,
		                       Method_UnityEngine_Object_Instantiate_DiscountListElement___);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e454ce;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_Discounts_View_DiscountListElement_DiscountListElementArgs_TypeInfo)
		    ;
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e454b2:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e454ce;
		    }
		    DAT_ram_009d3e38 = 0;
		    Unity_Collections_NativeArray_ReadOnly_Enumerator_Painter2D_Painter2DJobData___MoveNext(iVar9,0)
		    ;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e454b2;
		    *(undefined4 *)(iVar9 + 0xc) = uVar4;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xc,uVar7,iVar9,
		               Method_UI_Elements_GenericList_GenericListElement_DiscountListElement_DiscountListElementArgs__Init__
		              );
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar9 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e454ce:
		  iVar9 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar9 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar9;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x80e45517:
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
		              goto code_r0x80e4558f;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e4558f:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		      }
		      if (iVar9 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x4b,&local_c);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 == 1) {
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

		// Token: 0x060033D1 RID: 13265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D1")]
		[Address(RVA = "0x8409", Offset = "0x8409", VA = "0x8409")]
		public void Init(IEnumerable<DiscountData> discounts)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Discounts_View_DiscountsWindow__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param3;
		  int *param1_00;
		  int *param4;
		  
		  if (DAT_ram_00a57cb7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_DiscountsWindow_DicountsWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Controller_DiscountsViewMediator_TypeInfo);
		    DAT_ram_00a57cb7 = '\x01';
		  }
		  if (*(char *)(param1 + 0x48) == '\0') {
		    iVar1 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_DiscountsWindow_DicountsWindowArgs__get_WindowArgs__
		                        );
		    param4 = *(int **)(iVar1 + 0x18);
		    param2_00 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x100) * 4))
		                          (param4,*(undefined4 *)(*param4 + 0x104));
		    param3 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x110) * 4))
		                       (param4,*(undefined4 *)(*param4 + 0x114));
		    param1_00 = (int *)unnamed_function_1417
		                                 (Gameplay_Discounts_Controller_DiscountsViewMediator_TypeInfo);
		    if (DAT_ram_00a57cc7 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_DiscountsModel__DiscountsEvents__DiscountsController__DiscountsWindow___ctor__
		                );
		      DAT_ram_00a57cc7 = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (param1_00,param2_00,param3,param4,
		               Method_MVC_AbstractViewMediator_DiscountsModel__DiscountsEvents__DiscountsController__DiscountsWindow___ctor__
		              );
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		              (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		    *(undefined1 *)(param1 + 0x48) = 1;
		    *(int **)(param1 + 0x44) = param1_00;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060033D2 RID: 13266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D2")]
		[Address(RVA = "0x840A", Offset = "0x840A", VA = "0x840A")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_Discounts_View_DiscountsWindow__SetupMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(char *)(param1 + 0x48) != '\0') {
		    iVar1 = **(int **)(param1 + 0x44);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 0x44),*(undefined4 *)(iVar1 + 0x134));
		    *(undefined4 *)(param1 + 0x44) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060033D3 RID: 13267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D3")]
		[Address(RVA = "0x840B", Offset = "0x840B", VA = "0x840B")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_Discounts_View_DiscountsWindow__DestroyMVC(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57cb8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_DiscountsWindow_DicountsWindowArgs___ctor__);
		    DAT_ram_00a57cb8 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_DiscountsWindow_DicountsWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060033D4 RID: 13268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D4")]
		[Address(RVA = "0x840C", Offset = "0x840C", VA = "0x840C")]
		public DiscountsWindow()
		{
		}

		// Token: 0x04001C38 RID: 7224
		[Token(Token = "0x4001C38")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Discounts/DiscountsWindow";

		// Token: 0x04001C39 RID: 7225
		[Token(Token = "0x4001C39")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private DiscountListElement _listElementPrefab;

		// Token: 0x04001C3A RID: 7226
		[Token(Token = "0x4001C3A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _contentParent;

		// Token: 0x04001C3B RID: 7227
		[Token(Token = "0x4001C3B")]
		[FieldOffset(Offset = "0x44")]
		private DiscountsViewMediator _mediator;

		// Token: 0x04001C3C RID: 7228
		[Token(Token = "0x4001C3C")]
		[FieldOffset(Offset = "0x48")]
		private bool _mvcSetUp;

		// Token: 0x02000898 RID: 2200
		[Token(Token = "0x2000898")]
		public class DicountsWindowArgs : BaseWindowArgs
		{
			// Token: 0x060033D5 RID: 13269 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60033D5")]
			[Address(RVA = "0x840D", Offset = "0x840D", VA = "0x840D")]
			public DicountsWindowArgs()
			{
			}

			// Token: 0x04001C3D RID: 7229
			[Token(Token = "0x4001C3D")]
			[FieldOffset(Offset = "0x18")]
			public DiscountsController Controller;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Discounts_View_DiscountsWindow__get_WindowId
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57cb4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_DiscountsWindow_DicountsWindowArgs__OnShow__);
		    DAT_ram_00a57cb4 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_DiscountsWindow_DicountsWindowArgs__OnShow__);
		  Gameplay_Discounts_View_DiscountsWindow__Init(param1,param1);
		  return;
		}
		*/

}
