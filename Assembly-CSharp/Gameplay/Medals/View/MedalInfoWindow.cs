using System;
using System.Collections.Generic;
using AssetContent.Loaders;
using Core.Data;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Collections.View;
using Gameplay.Discounts.View;
using Gameplay.Medals.Controller;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Price;
using UI.Requirements;
using UI.Rewards;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Medals.View
{
	// Token: 0x020005F6 RID: 1526
	[Token(Token = "0x20005F6")]
	public class MedalInfoWindow : ClosableBaseWindow<MedalInfoWindowArgs>
	{
		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060024F9 RID: 9465 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006E3")]
		public override string WindowId
		{
			[Token(Token = "0x60024F9")]
			[Address(RVA = "0x7644", Offset = "0x7644", VA = "0x7644", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060024FA RID: 9466 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006E4")]
		public Button BuyButton
		{
			[Token(Token = "0x60024FA")]
			[Address(RVA = "0x7645", Offset = "0x7645", VA = "0x7645")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060024FB RID: 9467 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006E5")]
		public Price Price
		{
			[Token(Token = "0x60024FB")]
			[Address(RVA = "0x7646", Offset = "0x7646", VA = "0x7646")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x060024FC RID: 9468 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006E6")]
		public RequirementsView RequirementsView
		{
			[Token(Token = "0x60024FC")]
			[Address(RVA = "0x7647", Offset = "0x7647", VA = "0x7647")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060024FD RID: 9469 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006E7")]
		public RewardsRender RewardsRender
		{
			[Token(Token = "0x60024FD")]
			[Address(RVA = "0x7648", Offset = "0x7648", VA = "0x7648")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x060024FE RID: 9470 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006E8")]
		public BacktimeViewUGUI DurationLabel
		{
			[Token(Token = "0x60024FE")]
			[Address(RVA = "0x7649", Offset = "0x7649", VA = "0x7649")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x060024FF RID: 9471 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006E9")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x60024FF")]
			[Address(RVA = "0x764A", Offset = "0x764A", VA = "0x764A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06002500 RID: 9472 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006EA")]
		public TextMeshProUGUI Description
		{
			[Token(Token = "0x6002500")]
			[Address(RVA = "0x764B", Offset = "0x764B", VA = "0x764B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06002501 RID: 9473 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006EB")]
		public TextMeshProUGUI GroupLabel
		{
			[Token(Token = "0x6002501")]
			[Address(RVA = "0x764C", Offset = "0x764C", VA = "0x764C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06002502 RID: 9474 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006EC")]
		public MedalView MedalView
		{
			[Token(Token = "0x6002502")]
			[Address(RVA = "0x764D", Offset = "0x764D", VA = "0x764D")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06002503 RID: 9475 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006ED")]
		public GameRawImageLoader QualityBGLoader
		{
			[Token(Token = "0x6002503")]
			[Address(RVA = "0x764E", Offset = "0x764E", VA = "0x764E")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06002504 RID: 9476 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006EE")]
		public DiscountGroup DiscountGroup
		{
			[Token(Token = "0x6002504")]
			[Address(RVA = "0x764F", Offset = "0x764F", VA = "0x764F")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06002505 RID: 9477 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006EF")]
		public CollectionRowHelper CollectionRow
		{
			[Token(Token = "0x6002505")]
			[Address(RVA = "0x7650", Offset = "0x7650", VA = "0x7650")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002506")]
		[Address(RVA = "0x7651", Offset = "0x7651", VA = "0x7651", Slot = "24")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Medals_View_MedalInfoWindow__Awake(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57d82 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_MedalInfoWindowArgs__OnClose__);
		    DAT_ram_00a57d82 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,Method_UI_Windows_ClosableBaseWindow_MedalInfoWindowArgs__OnClose__);
		  iVar1 = **(int **)(param1 + 0x78);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x78),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x78) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06002507 RID: 9479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002507")]
		[Address(RVA = "0x7652", Offset = "0x7652", VA = "0x7652", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Medals_View_MedalInfoWindow__OnClose
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57d83 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_MedalInfoWindowArgs__OnShow__);
		    DAT_ram_00a57d83 = '\x01';
		  }
		  func_ii_7769(param1,param2,Method_UI_Windows_ClosableBaseWindow_MedalInfoWindowArgs__OnShow__);
		  Gameplay_Medals_View_MedalInfoWindow__DrawMedalsClamped(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002508 RID: 9480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002508")]
		[Address(RVA = "0x7653", Offset = "0x7653", VA = "0x7653", Slot = "22")]
		protected override void OnShow(MedalInfoWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Medals_View_MedalInfoWindow__OnShow(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  
		  UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(param1 + 0x40),param2,0);
		  param1_00 = *(undefined4 *)(param1 + 0x50);
		  uVar1 = func_ii_4769(param2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,uVar1 ^ 1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002509 RID: 9481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002509")]
		[Address(RVA = "0x7654", Offset = "0x7654", VA = "0x7654")]
		public void SetDescription(string description)
		{
		/* --- GHIDRA: SetDescription ---
		undefined4
		Gameplay_Medals_View_MedalInfoWindow__SetDescription
		          (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 param2_00;
		  int *piVar8;
		  int iVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57d84 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MedalViewSelectable___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_MedalViewSelectable__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_MedalViewSelectable___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Values__);
		    DAT_ram_00a57d84 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_MedalViewSelectable__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_MedalViewSelectable___ctor__);
		  piVar2 = (int *)System_Collections_Generic_SortedList_uint__object___System_Collections_Generic_IReadOnlyDictionary_TKey_TValue__get_Keys
		                            (*(undefined4 *)(*(int *)(param2 + 8) + 8),
		                             Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Values__
		                            );
		  iVar9 = *piVar2;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo ==
		          *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e5886b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,
		                                System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo,0);
		code_r0x80e5886b:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar2 = local_4;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar4 = (undefined4 *)(iVar9 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80e5893d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e58b42:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e58b4a;
		    }
		code_r0x80e5893d:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar4,piVar2,puVar4[1]);
		    piVar2 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e58b42;
		    if (iVar9 == 0) {
		      iVar9 = 0;
		      goto code_r0x80e58b93;
		    }
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo == *piVar8) {
		          puVar4 = (undefined4 *)(iVar9 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80e58a17;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e58b1a:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e58b4a;
		    }
		code_r0x80e58a17:
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii(*puVar4,piVar2,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e58b1a;
		    uVar7 = *(undefined4 *)(param1 + 0x5c);
		    param2_00 = *(undefined4 *)(param1 + 0x74);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e58b4a;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar7 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,param2_00,uVar7,
		                       Method_UnityEngine_Object_Instantiate_MedalViewSelectable___);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e58b4a;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiiiiii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x66,iVar9,param2,param3,param1_00,
		               uVar5,uVar7,iVar9);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar9 != 1);
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e58b4a:
		  iVar9 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar6) {
		    piVar2 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar9 = *piVar2;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar9;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x80e58b93:
		      piVar2 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar6 = *local_4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80e58c0b;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e58c0b:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		      }
		      if (iVar9 == 0) {
		        return param1_00;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x67,&local_c);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 == 1) {
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

		// Token: 0x0600250A RID: 9482 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600250A")]
		[Address(RVA = "0x7655", Offset = "0x7655", VA = "0x7655")]
		public List<MedalViewSelectable> DrawMedals(MedalData medalData, Action<MedalViewSelectable> callback)
		{
		/* --- GHIDRA: DrawMedals ---
		undefined4
		Gameplay_Medals_View_MedalInfoWindow__DrawMedals
		          (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int param2_00;
		  undefined4 param3_00;
		  undefined4 param2_01;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a57d85 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MedalViewSelectable___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_MedalViewSelectable__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_MedalViewSelectable___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Values__);
		    DAT_ram_00a57d85 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_MedalViewSelectable__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_MedalViewSelectable___ctor__);
		  piVar2 = (int *)System_Collections_Generic_SortedList_uint__object___System_Collections_Generic_IReadOnlyDictionary_TKey_TValue__get_Keys
		                            (*(undefined4 *)(*(int *)(param2 + 8) + 8),
		                             Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Values__
		                            );
		  iVar8 = *piVar2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e58f23;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,
		                                System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo,0);
		code_r0x80e58f23:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar2 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80e58ff5;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e59039:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e5920a:
		      iVar6 = global_1;
		      iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar6 == iVar8) {
		        piVar2 = (int *)import::env::__cxa_begin_catch(uVar5);
		        iVar6 = *piVar2;
		        DAT_ram_009d3e38 = 0;
		        local_c = iVar6;
		        import::env::invoke_v(0x123);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 != 1) break;
		        uVar5 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x68,&local_c);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
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
		code_r0x80e58ff5:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar4,piVar2,puVar4[1]);
		    piVar2 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e59039;
		    if (iVar8 == 0) break;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80e590de;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e591e4:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e5920a;
		    }
		code_r0x80e590de:
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii(*puVar4,piVar2,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e591e4;
		    param3_00 = *(undefined4 *)(param1 + 0x5c);
		    param2_01 = *(undefined4 *)(param1 + 0x74);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 != 1) goto code_r0x80e59166;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e5920a;
		    }
		code_r0x80e59166:
		    DAT_ram_009d3e38 = 0;
		    param2_00 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,param2_01,
		                           param3_00,Method_UnityEngine_Object_Instantiate_MedalViewSelectable___);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e5920a;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiiiiii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x66,param2_00,param2,param3,
		               param1_00,uVar5,param2_00,param2_00);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e5920a;
		    }
		  } while (*(char *)(*(int *)(param2_00 + 0x10) + 0x50) != '\0');
		  piVar2 = local_4;
		  DAT_ram_009d3e38 = 0;
		  if (local_4 != (int *)0x0) {
		    uVar1 = 0;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e592cb;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e592cb:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  }
		  if (iVar6 == 0) {
		    return param1_00;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600250B")]
		[Address(RVA = "0x7656", Offset = "0x7656", VA = "0x7656")]
		public List<MedalViewSelectable> DrawMedalsClamped(MedalData medalData, Action<MedalViewSelectable> callback)
		{
		/* --- GHIDRA: DrawMedalsClamped ---
		void Gameplay_Medals_View_MedalInfoWindow__DrawMedalsClamped(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param3;
		  int *param1_00;
		  int *param4;
		  
		  if (DAT_ram_00a57d87 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_MedalInfoWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Controller_MedalInfoViewMediator_TypeInfo);
		    DAT_ram_00a57d87 = '\x01';
		  }
		  iVar1 = func_ii_8093(param1,Method_UI_Windows_BaseWindow_MedalInfoWindowArgs__get_WindowArgs__);
		  param4 = *(int **)(iVar1 + 0x18);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x100) * 4))
		                        (param4,*(undefined4 *)(*param4 + 0x104));
		  param3 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x110) * 4))
		                     (param4,*(undefined4 *)(*param4 + 0x114));
		  param1_00 = (int *)unnamed_function_1417
		                               (Gameplay_Medals_Controller_MedalInfoViewMediator_TypeInfo);
		  Gameplay_Medals_Events_MedalsEvents_MedalChangedEventDelegate__EndInvoke
		            (param1_00,param2_00,param3,param4,param4);
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  *(int **)(param1 + 0x78) = param1_00;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600250C")]
		[Address(RVA = "0x1BED", Offset = "0x1BED", VA = "0x1BED")]
		private void PopulateMedalView(MedalData medalData, Action<MedalViewSelectable> callback, List<MedalViewSelectable> result, MedalDicWrapper md, MedalViewSelectable mv)
		{
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600250D")]
		[Address(RVA = "0x7657", Offset = "0x7657", VA = "0x7657")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_Medals_View_MedalInfoWindow__SetupMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x78);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x78),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x78) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600250E RID: 9486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600250E")]
		[Address(RVA = "0x7658", Offset = "0x7658", VA = "0x7658")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_Medals_View_MedalInfoWindow__DestroyMVC(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57d88 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_ClosableBaseWindow_MedalInfoWindowArgs___ctor__)
		    ;
		    DAT_ram_00a57d88 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_MedalInfoWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600250F RID: 9487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600250F")]
		[Address(RVA = "0x7659", Offset = "0x7659", VA = "0x7659")]
		public MedalInfoWindow()
		{
		}

		// Token: 0x0400142F RID: 5167
		[Token(Token = "0x400142F")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Medals/MedalInfoWindow";

		// Token: 0x04001430 RID: 5168
		[Token(Token = "0x4001430")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _titleLabel;

		// Token: 0x04001431 RID: 5169
		[Token(Token = "0x4001431")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _descriptionLabel;

		// Token: 0x04001432 RID: 5170
		[Token(Token = "0x4001432")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TextMeshProUGUI _groupLabel;

		// Token: 0x04001433 RID: 5171
		[Token(Token = "0x4001433")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private MedalView _medalView;

		// Token: 0x04001434 RID: 5172
		[Token(Token = "0x4001434")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private GameRawImageLoader _qualityBigBgLoader;

		// Token: 0x04001435 RID: 5173
		[Token(Token = "0x4001435")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _descGroup;

		// Token: 0x04001436 RID: 5174
		[Token(Token = "0x4001436")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Button _buyButton;

		// Token: 0x04001437 RID: 5175
		[Token(Token = "0x4001437")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Price _price;

		// Token: 0x04001438 RID: 5176
		[Token(Token = "0x4001438")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Transform _medalsContainer;

		// Token: 0x04001439 RID: 5177
		[Token(Token = "0x4001439")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RequirementsView _requirementsView;

		// Token: 0x0400143A RID: 5178
		[Token(Token = "0x400143A")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private RewardsRender _rewardsView;

		// Token: 0x0400143B RID: 5179
		[Token(Token = "0x400143B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private BacktimeViewUGUI _durationLabel;

		// Token: 0x0400143C RID: 5180
		[Token(Token = "0x400143C")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private DiscountGroup _discountGroup;

		// Token: 0x0400143D RID: 5181
		[Token(Token = "0x400143D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CollectionRowHelper _collectionRow;

		// Token: 0x0400143E RID: 5182
		[Token(Token = "0x400143E")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private MedalViewSelectable _medalViewPrefab;

		// Token: 0x0400143F RID: 5183
		[Token(Token = "0x400143F")]
		[FieldOffset(Offset = "0x78")]
		private MedalInfoViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CollectionRow ---
		void Gameplay_Medals_View_MedalInfoWindow__get_CollectionRow(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57d81 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_ClosableBaseWindow_MedalInfoWindowArgs__Awake__)
		    ;
		    DAT_ram_00a57d81 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object____ctor
		            (param1,Method_UI_Windows_ClosableBaseWindow_MedalInfoWindowArgs__Awake__);
		  *(undefined4 *)(*(int *)(param1 + 0x48) + 0x40) = 2;
		  return;
		}
		*/

}
