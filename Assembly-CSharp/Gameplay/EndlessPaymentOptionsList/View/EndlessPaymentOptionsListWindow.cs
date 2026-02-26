using System;
using System.Collections;
using System.Collections.Generic;
using Gameplay.EndlessPaymentOptionsList.Control;
using Gameplay.EndlessPaymentOptionsList.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.EndlessPaymentOptionsList.View
{
	// Token: 0x0200083B RID: 2107
	[Token(Token = "0x200083B")]
	public class EndlessPaymentOptionsListWindow : ClosableBaseWindow<EndlessPaymentOptionsListWindow.EndlessPaymentOptionsListWindowArgs>
	{
		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06003191 RID: 12689 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009C7")]
		public override string WindowId
		{
			[Token(Token = "0x6003191")]
			[Address(RVA = "0x81E9", Offset = "0x81E9", VA = "0x81E9", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06003192 RID: 12690 RVA: 0x0000A128 File Offset: 0x00008328
		[Token(Token = "0x170009C8")]
		public override bool IsFullscreenWindow
		{
			[Token(Token = "0x6003192")]
			[Address(RVA = "0x81EA", Offset = "0x81EA", VA = "0x81EA", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06003193 RID: 12691 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009C9")]
		public MonoPointerClickHandler OptionClickHandler
		{
			[Token(Token = "0x6003193")]
			[Address(RVA = "0x81EB", Offset = "0x81EB", VA = "0x81EB")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06003194 RID: 12692 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009CA")]
		public EndlessPaymentOptionListTitleLayoutView TitleLayout
		{
			[Token(Token = "0x6003194")]
			[Address(RVA = "0x81EC", Offset = "0x81EC", VA = "0x81EC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003195 RID: 12693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003195")]
		[Address(RVA = "0x81ED", Offset = "0x81ED", VA = "0x81ED", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__OnClose
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param3_00;
		  int *param1_00;
		  undefined4 param4;
		  int iVar1;
		  
		  if (DAT_ram_00a57636 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_EndlessPaymentOptionsListWindow_EndlessPaymentOptionsListWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator_TypeInfo
		              );
		    DAT_ram_00a57636 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_EndlessPaymentOptionsListWindow_EndlessPaymentOptionsListWindowArgs__OnShow__
		              );
		  iVar1 = **(int **)(param2 + 0x18);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x100) * 4))
		                        (*(int **)(param2 + 0x18),*(undefined4 *)(iVar1 + 0x104));
		  iVar1 = **(int **)(param2 + 0x18);
		  param3_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x110) * 4))
		                        (*(int **)(param2 + 0x18),*(undefined4 *)(iVar1 + 0x114));
		  param4 = *(undefined4 *)(param2 + 0x18);
		  param1_00 = (int *)unnamed_function_1417
		                               (
		                               Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListWindowMediator_TypeInfo
		                               );
		  Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionsListEntryPointViewMediator__ShowListWindow
		            (param1_00,param2_00,param3_00,param4,0);
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  *(int **)(param1 + 0x68) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06003196 RID: 12694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003196")]
		[Address(RVA = "0x81EE", Offset = "0x81EE", VA = "0x81EE", Slot = "22")]
		protected override void OnShow(EndlessPaymentOptionsListWindow.EndlessPaymentOptionsListWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		int Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__OnShow
		              (int param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  uint uVar6;
		  int local_30;
		  undefined1 *puStack_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57638 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CardData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CardData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CardData__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_EndlessPaymentOptionView__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CardData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_EndlessPaymentOptionView___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CardData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_EndlessPaymentOptionView__TypeInfo);
		    DAT_ram_00a57638 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(System_Collections_Generic_List_EndlessPaymentOptionView__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar1,Method_System_Collections_Generic_List_EndlessPaymentOptionView___ctor__);
		  iVar4 = *(int *)(param3 + 0xc);
		  iVar5 = *(int *)(param2 + 0xc);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_30,param2,Method_System_Collections_Generic_List_CardData__GetEnumerator__);
		  local_8 = local_28;
		  local_30 = 0;
		  puStack_2c = local_10;
		  if (iVar5 < iVar4) {
		    do {
		      while( true ) {
		        DAT_ram_009d3e38 = 0;
		        iVar5 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                           Method_System_Collections_Generic_List_Enumerator_CardData__MoveNext__);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80dbbfee;
		        }
		        if (iVar5 == 0) goto code_r0x80dbc037;
		        local_18 = *(undefined4 *)(param1 + 0x58);
		        local_20 = *(undefined8 *)(param1 + 0x50);
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iiiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x33c,param1,
		                           local_8._4_4_,&local_20,&local_30);
		        iVar5 = DAT_ram_009d3e38;
		        iVar4 = Method_System_Collections_Generic_List_EndlessPaymentOptionView__Add__;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80dbbfee;
		        }
		        *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		        uVar6 = *(uint *)(iVar1 + 0xc);
		        if (*(uint *)(*(int *)(iVar1 + 8) + 0xc) <= uVar6) break;
		        *(uint *)(iVar1 + 0xc) = uVar6 + 1;
		        *(undefined4 *)(*(int *)(iVar1 + 8) + uVar6 * 4 + 0x10) = uVar2;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar1,uVar2,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		    } while (iVar4 != 1);
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    do {
		      while( true ) {
		        DAT_ram_009d3e38 = 0;
		        iVar5 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                           Method_System_Collections_Generic_List_Enumerator_CardData__MoveNext__);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80dbbfee;
		        }
		        if (iVar5 == 0) goto code_r0x80dbc037;
		        uVar2 = local_8._4_4_;
		        if (DAT_ram_00a65020 == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(0x7ff,&UnityEngine_Vector3_TypeInfo);
		          iVar4 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80dbbfee;
		          }
		          DAT_ram_00a65020 = '\x01';
		        }
		        local_18 = *(undefined4 *)(*(undefined8 **)(UnityEngine_Vector3_TypeInfo + 0x5c) + 1);
		        local_20 = **(undefined8 **)(UnityEngine_Vector3_TypeInfo + 0x5c);
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iiiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x33c,param1,uVar2,
		                           &local_20,&local_30);
		        iVar5 = DAT_ram_009d3e38;
		        iVar4 = Method_System_Collections_Generic_List_EndlessPaymentOptionView__Add__;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80dbbfee;
		        }
		        *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		        uVar6 = *(uint *)(iVar1 + 0xc);
		        if (*(uint *)(*(int *)(iVar1 + 8) + 0xc) <= uVar6) break;
		        *(uint *)(iVar1 + 0xc) = uVar6 + 1;
		        *(undefined4 *)(*(int *)(iVar1 + 8) + uVar6 * 4 + 0x10) = uVar2;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar1,uVar2,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		    } while (iVar4 != 1);
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		code_r0x80dbbfee:
		  iVar4 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar5) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    local_30 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		code_r0x80dbc037:
		      DAT_ram_009d3e38 = 0;
		      if (local_30 == 0) {
		        return iVar1;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_30);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x33d,&local_30);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003197 RID: 12695 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003197")]
		[Address(RVA = "0x1B04", Offset = "0x1B04", VA = "0x1B04")]
		private EndlessPaymentOptionView CreateItem(CardData data, in Vector3 offset)
		{
			return null;
		}

		// Token: 0x06003198 RID: 12696 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003198")]
		[Address(RVA = "0x81EF", Offset = "0x81EF", VA = "0x81EF")]
		public List<EndlessPaymentOptionView> CreateItems(List<CardData> optionsForDisplay, List<CardData> totalOptions)
		{
		/* --- GHIDRA: CreateItems ---
		int Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__CreateItems
		              (undefined4 param1,undefined8 *param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57639 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__Shift_d__25_TypeInfo
		              );
		    DAT_ram_00a57639 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__Shift_d__25_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined8 *)(iVar1 + 0x14) = *param2;
		  *(undefined4 *)(iVar1 + 0x1c) = *(undefined4 *)(param2 + 1);
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06003199 RID: 12697 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003199")]
		[Address(RVA = "0x81F0", Offset = "0x81F0", VA = "0x81F0")]
		private IEnumerator Shift(Vector3 offset)
		{
		/* --- GHIDRA: Shift ---
		int Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__Shift
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5763a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__PlayBuyRoutine_d__26_TypeInfo
		              );
		    DAT_ram_00a5763a = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__PlayBuyRoutine_d__26_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600319A RID: 12698 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600319A")]
		[Address(RVA = "0x81F1", Offset = "0x81F1", VA = "0x81F1")]
		private IEnumerator PlayBuyRoutine(CardData removeData)
		{
		/* --- GHIDRA: PlayBuyRoutine ---
		int Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__PlayBuyRoutine
		              (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5763b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__PlayBuyAndShiftRoutine_d__27_TypeInfo
		              );
		    DAT_ram_00a5763b = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__PlayBuyAndShiftRoutine_d__27_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x18) = param3;
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600319B RID: 12699 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600319B")]
		[Address(RVA = "0x81F2", Offset = "0x81F2", VA = "0x81F2")]
		private IEnumerator PlayBuyAndShiftRoutine(CardData removeData, CardData addData)
		{
		/* --- GHIDRA: PlayBuyAndShiftRoutine ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__PlayBuyAndShiftRoutine
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5763c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_Coroutine__Enqueue__);
		    DAT_ram_00a5763c = '\x01';
		  }
		  if (DAT_ram_00a5763a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__PlayBuyRoutine_d__26_TypeInfo
		              );
		    DAT_ram_00a5763a = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__PlayBuyRoutine_d__26_TypeInfo
		                        );
		  *(int *)(param1_00 + 0x14) = param1;
		  *(undefined4 *)(param1_00 + 8) = 0;
		  *(undefined4 *)(param1_00 + 0x10) = param2;
		  param2_00 = Utils_CoroutineSource__GetMono(param1_00,0);
		  System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		            (*(undefined4 *)(param1 + 0x6c),param2_00,
		             Method_System_Collections_Generic_Queue_Coroutine__Enqueue__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600319C RID: 12700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600319C")]
		[Address(RVA = "0x81F3", Offset = "0x81F3", VA = "0x81F3")]
		public void PlayBuy(CardData removeData)
		{
		/* --- GHIDRA: PlayBuy ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__PlayBuy
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5763d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_Coroutine__Enqueue__);
		    DAT_ram_00a5763d = '\x01';
		  }
		  if (DAT_ram_00a5763b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__PlayBuyAndShiftRoutine_d__27_TypeInfo
		              );
		    DAT_ram_00a5763b = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__PlayBuyAndShiftRoutine_d__27_TypeInfo
		                        );
		  *(int *)(param1_00 + 0x14) = param1;
		  *(undefined4 *)(param1_00 + 8) = 0;
		  *(undefined4 *)(param1_00 + 0x18) = param3;
		  *(undefined4 *)(param1_00 + 0x10) = param2;
		  param2_00 = Utils_CoroutineSource__GetMono(param1_00,0);
		  System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		            (*(undefined4 *)(param1 + 0x6c),param2_00,
		             Method_System_Collections_Generic_Queue_Coroutine__Enqueue__);
		  return;
		}
		*/

		}

		// Token: 0x0600319D RID: 12701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600319D")]
		[Address(RVA = "0x81F4", Offset = "0x81F4", VA = "0x81F4")]
		public void PlayBuyAndShift(CardData removeData, CardData addData)
		{
		/* --- GHIDRA: PlayBuyAndShift ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__PlayBuyAndShift
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  iVar2 = *(int *)(param1 + 0x3c);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      piVar3 = *(int **)(iVar2 + iVar1 * 4 + 0x10);
		      iVar4 = *piVar3;
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		                (piVar3,param2,*(undefined4 *)(iVar4 + 0x2d4));
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600319E RID: 12702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600319E")]
		[Address(RVA = "0x81F5", Offset = "0x81F5", VA = "0x81F5")]
		public void SetTitle(string value)
		{
		/* --- GHIDRA: SetTitle ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__SetTitle
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5763e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_EndlessPaymentOptionsListWindow_EndlessPaymentOptionsListWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_EndlessPaymentOptionView___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_LinkedList_EndlessPaymentOptionView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_Coroutine___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Queue_Coroutine__TypeInfo);
		    DAT_ram_00a5763e = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_LinkedList_EndlessPaymentOptionView__TypeInfo);
		  *(undefined4 *)(param1 + 100) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Queue_Coroutine__TypeInfo);
		  Sirenix_Serialization_StackFormatter_object____Il2CppFullySharedGenericType___SerializeImplementation
		            (uVar1,Method_System_Collections_Generic_Queue_Coroutine___ctor__);
		  *(undefined4 *)(param1 + 0x6c) = uVar1;
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_EndlessPaymentOptionsListWindow_EndlessPaymentOptionsListWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600319F RID: 12703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600319F")]
		[Address(RVA = "0x81F6", Offset = "0x81F6", VA = "0x81F6")]
		public EndlessPaymentOptionsListWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  UI_Windows_BaseWindowArgs__Dispose(param1,0);
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  *(undefined1 *)(param1 + 0xc) = 0;
		  *(undefined4 *)(param1 + 0x18) = param3;
		  *(undefined4 *)(param1 + 0x10) = param4;
		  return;
		}
		*/

		}

		// Token: 0x04001B21 RID: 6945
		[Token(Token = "0x4001B21")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/EndlessPaymentOptionsList/EndlessPaymentOptionsListWindow";

		// Token: 0x04001B22 RID: 6946
		[Token(Token = "0x4001B22")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI[] _title;

		// Token: 0x04001B23 RID: 6947
		[Token(Token = "0x4001B23")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private EndlessPaymentOptionView _listItemsPrefab;

		// Token: 0x04001B24 RID: 6948
		[Token(Token = "0x4001B24")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Transform _itemsOwner;

		// Token: 0x04001B25 RID: 6949
		[Token(Token = "0x4001B25")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _infoButton;

		// Token: 0x04001B26 RID: 6950
		[Token(Token = "0x4001B26")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Transform[] _anchors;

		// Token: 0x04001B27 RID: 6951
		[Token(Token = "0x4001B27")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector3 _itemsOffsetOver4;

		// Token: 0x04001B28 RID: 6952
		[Token(Token = "0x4001B28")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private EndlessPaymentOptionListTitleLayoutView _titleLayout;

		// Token: 0x04001B29 RID: 6953
		[Token(Token = "0x4001B29")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public Button ShowDiscountBtn_DBG;

		// Token: 0x04001B2A RID: 6954
		[Token(Token = "0x4001B2A")]
		[FieldOffset(Offset = "0x64")]
		[NonSerialized]
		public readonly LinkedList<EndlessPaymentOptionView> Items;

		// Token: 0x04001B2B RID: 6955
		[Token(Token = "0x4001B2B")]
		[FieldOffset(Offset = "0x68")]
		private EndlessPaymentOptionsListWindowMediator _mediator;

		// Token: 0x04001B2C RID: 6956
		[Token(Token = "0x4001B2C")]
		[FieldOffset(Offset = "0x6C")]
		private readonly Queue<Coroutine> _routines;

		// Token: 0x0200083C RID: 2108
		[Token(Token = "0x200083C")]
		public class EndlessPaymentOptionsListWindowArgs : BaseWindowArgs
		{
			// Token: 0x060031A0 RID: 12704 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60031A0")]
			[Address(RVA = "0x81F7", Offset = "0x81F7", VA = "0x81F7")]
			public EndlessPaymentOptionsListWindowArgs(EndlessPaymentOptionListData listData, EndlessPaymentOptionsListController controller, WindowOpenReasonSource source)
			{
			}

			// Token: 0x04001B2D RID: 6957
			[Token(Token = "0x4001B2D")]
			[FieldOffset(Offset = "0x18")]
			public readonly EndlessPaymentOptionsListController Controller;

			// Token: 0x04001B2E RID: 6958
			[Token(Token = "0x4001B2E")]
			[FieldOffset(Offset = "0x1C")]
			public readonly EndlessPaymentOptionListData ListData;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IsFullscreenWindow ---
		undefined4
		Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__get_IsFullscreenWindow
		          (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57634 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponent_MonoPointerClickHandler___);
		    DAT_ram_00a57634 = '\x01';
		  }
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 0x44),
		                       Method_UnityEngine_Component_GetComponent_MonoPointerClickHandler___);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_TitleLayout ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListWindow__get_TitleLayout
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int param1_01;
		  int iVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a57635 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_EndlessPaymentOptionsListWindow_EndlessPaymentOptionsListWindowArgs__OnClose__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_Coroutine__Dequeue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_Coroutine__get_Count__);
		    DAT_ram_00a57635 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_EndlessPaymentOptionsListWindow_EndlessPaymentOptionsListWindowArgs__OnClose__
		            );
		  param1_01 = *(int *)(param1 + 0x6c);
		  iVar1 = *(int *)(param1_01 + 0x14);
		  while (0 < iVar1) {
		    param1_00 = func_ii_7387(param1_01,Method_System_Collections_Generic_Queue_Coroutine__Dequeue__)
		    ;
		    func_ii_7950(param1_00,0);
		    param1_01 = *(int *)(param1 + 0x6c);
		    iVar1 = *(int *)(param1_01 + 0x14);
		  }
		  piVar2 = *(int **)(param1 + 0x68);
		  if (piVar2 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x130) * 4))
		              (piVar2,*(undefined4 *)(*piVar2 + 0x134));
		  }
		  return;
		}
		*/

}
