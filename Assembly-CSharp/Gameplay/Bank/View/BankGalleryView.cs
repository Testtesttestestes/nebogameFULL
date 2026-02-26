using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C35 RID: 3125
	[Token(Token = "0x2000C35")]
	public class BankGalleryView : MonoBehaviour
	{
		// Token: 0x06004C2F RID: 19503 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004C2F")]
		[Address(RVA = "0x9A73", Offset = "0x9A73", VA = "0x9A73")]
		private IEnumerator ShowNextElementDemo()
		{
		/* --- GHIDRA: ShowNextElementDemo ---
		void Gameplay_Bank_View_BankGalleryView__ShowNextElementDemo(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59761 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MonoPointerClickHandler__get_Count__);
		    DAT_ram_00a59761 = '\x01';
		  }
		  if (*(int *)(param1 + 0x34) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x34),0);
		    *(undefined4 *)(param1 + 0x34) = 0;
		  }
		  if (1 < *(int *)(*(int *)(param1 + 0x2c) + 0xc)) {
		    if (DAT_ram_00a5975f == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Gameplay_Bank_View_BankGalleryView__ShowNextElementDemo_d__11_TypeInfo);
		      DAT_ram_00a5975f = '\x01';
		    }
		    param1_00 = unnamed_function_1417
		                          (Gameplay_Bank_View_BankGalleryView__ShowNextElementDemo_d__11_TypeInfo);
		    *(int *)(param1_00 + 0x10) = param1;
		    *(undefined4 *)(param1_00 + 8) = 0;
		    uVar1 = Utils_CoroutineSource__GetMono(param1_00,0);
		    *(undefined4 *)(param1 + 0x34) = uVar1;
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004C30 RID: 19504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C30")]
		[Address(RVA = "0x1EFC", Offset = "0x1EFC", VA = "0x1EFC")]
		public void AddElement(GameObject element)
		{
		/* --- GHIDRA: AddElement ---
		undefined4 Gameplay_Bank_View_BankGalleryView__AddElement(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  param1_00 = *(int *)(param1 + 0x1c);
		  param2_00 = 0;
		  if (DAT_ram_00a5acf4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__);
		    DAT_ram_00a5acf4 = '\x01';
		  }
		  if (*(int *)(param1_00 + 0xc) < 1) {
		    uVar2 = 0;
		  }
		  else {
		    while (iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                             (param1_00,param2_00,
		                              Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__
		                             ), *(int *)(iVar1 + 0xc) != 0x4e) {
		      param2_00 = param2_00 + 1;
		      if (*(int *)(param1_00 + 0xc) <= param2_00) {
		        return 0;
		      }
		    }
		    uVar2 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x06004C31 RID: 19505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C31")]
		[Address(RVA = "0x9A74", Offset = "0x9A74", VA = "0x9A74")]
		private void RestartDemo()
		{
		/* --- GHIDRA: RestartDemo ---
		void Gameplay_Bank_View_BankGalleryView__RestartDemo(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59762 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_GameObject_GetComponent_MonoPointerClickHandler___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MonoPointerClickHandler__IndexOf__);
		    DAT_ram_00a59762 = '\x01';
		  }
		  uVar1 = func_ii_6601(*(undefined4 *)(param2 + 0x24),
		                       Method_UnityEngine_GameObject_GetComponent_MonoPointerClickHandler___);
		  uVar1 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                    (*(undefined4 *)(param1 + 0x2c),uVar1,
		                     Method_System_Collections_Generic_List_MonoPointerClickHandler__IndexOf__);
		  Gameplay_Bank_View_BankGalleryView__ButtonOnSelectEvent(param1,uVar1,param1);
		  Gameplay_Bank_View_BankGalleryView__ShowNextElementDemo(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004C32 RID: 19506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C32")]
		[Address(RVA = "0x9A75", Offset = "0x9A75", VA = "0x9A75")]
		private void ButtonOnSelectEvent(PointerEventData pointerEventData)
		{
		/* --- GHIDRA: ButtonOnSelectEvent ---
		void Gameplay_Bank_View_BankGalleryView__ButtonOnSelectEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  float param2_01;
		  int iVar3;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  param2_01 = 0.0;
		  if (DAT_ram_00a59763 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MonoPointerClickHandler__IndexOf__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MonoPointerClickHandler__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MonoPointerClickHandler__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetEase_Tweener___);
		    DAT_ram_00a59763 = '\x01';
		  }
		  iVar3 = *(int *)(*(int *)(param1 + 0x2c) + 0xc) + -1;
		  if (param2 <= iVar3) {
		    iVar3 = param2;
		  }
		  *(int *)(param1 + 0x30) = iVar3;
		  Utils_TweenContainer__AddTween(*(undefined4 *)(param1 + 0x38),0);
		  uVar1 = System_Linq_Enumerable__ToList_object_
		                    (*(undefined4 *)(param1 + 0x2c),*(undefined4 *)(param1 + 0x30),
		                     Method_System_Collections_Generic_List_MonoPointerClickHandler__get_Item__);
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x18),0);
		  param2_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (uVar1,0);
		  UnityEngine_Transform___ctor(&local_c,param2_00,0);
		  local_10 = local_4;
		  local_18 = local_c;
		  uVar2 = DG_Tweening_ShortcutExtensions__DOMoveZ(uVar2,&local_18,0.2,0,0);
		  uVar2 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar2,6,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x38),uVar2,0);
		  if (1 < *(int *)(*(int *)(param1 + 0x2c) + 0xc)) {
		    iVar3 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                      (*(int *)(param1 + 0x2c),uVar1,
		                       Method_System_Collections_Generic_List_MonoPointerClickHandler__IndexOf__);
		    param2_01 = (float)(iVar3 / (*(int *)(*(int *)(param1 + 0x2c) + 0xc) + -1));
		  }
		  uVar1 = DG_Tweening_DOTweenModuleUI__DONormalizedPos
		                    (*(undefined4 *)(param1 + 0x10),param2_01,0.5,0,0);
		  uVar1 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar1,6,Method_DG_Tweening_TweenSettingsExtensions_SetEase_Tweener___);
		  Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x38),uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004C33 RID: 19507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C33")]
		[Address(RVA = "0x9A76", Offset = "0x9A76", VA = "0x9A76")]
		public void SelectByIndex(int index)
		{
		/* --- GHIDRA: SelectByIndex ---
		void Gameplay_Bank_View_BankGalleryView__SelectByIndex(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59764 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Bank_View_BankGalleryView_ButtonOnSelectEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MonoPointerClickHandler__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_MonoPointerClickHandler__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_MonoPointerClickHandler__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MonoPointerClickHandler__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MonoPointerClickHandler__GetEnumerator__);
		    DAT_ram_00a59764 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x2c),
		             Method_System_Collections_Generic_List_MonoPointerClickHandler__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_MonoPointerClickHandler__MoveNext__
		                      );
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8106346b;
		    }
		    if (iVar1 == 0) goto code_r0x810634c1;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = local_8._4_4_;
		    param2_00 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Action_PointerEventData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,param2_00,param1,
		               Method_Gameplay_Bank_View_BankGalleryView_ButtonOnSelectEvent__,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x21,uVar2,param2_00,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8106346b:
		  iVar4 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar1) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar1 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x810634c1:
		      DAT_ram_009d3e38 = 0;
		      iVar4 = *(int *)(param1 + 0x2c);
		      iVar1 = *(int *)(iVar4 + 0xc);
		      *(undefined4 *)(iVar4 + 0xc) = 0;
		      *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		      if (0 < iVar1) {
		        func_ii_2064(*(undefined4 *)(iVar4 + 8),0,iVar1,0);
		      }
		      Utils_TweenContainer__StopAllTweens(*(undefined4 *)(param1 + 0x38),0);
		      if (*(int *)(param1 + 0x34) != 0) {
		        func_ii_7950(*(int *)(param1 + 0x34),0);
		        *(undefined4 *)(param1 + 0x34) = 0;
		      }
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x36c,&local_18);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 == 1) {
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

		// Token: 0x06004C34 RID: 19508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C34")]
		[Address(RVA = "0x9A77", Offset = "0x9A77", VA = "0x9A77")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Bank_View_BankGalleryView__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59765 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MonoPointerClickHandler___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_MonoPointerClickHandler__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Utils_TweenContainer_TypeInfo);
		    DAT_ram_00a59765 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x24) = 0x40a00000;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_MonoPointerClickHandler__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_MonoPointerClickHandler___ctor__);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  uVar1 = unnamed_function_1417(Utils_TweenContainer_TypeInfo);
		  Utils_TweenContainer__Dispose(uVar1,0);
		  *(undefined4 *)(param1 + 0x38) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004C35 RID: 19509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C35")]
		[Address(RVA = "0x9A78", Offset = "0x9A78", VA = "0x9A78")]
		public BankGalleryView()
		{
		}

		// Token: 0x0400297C RID: 10620
		[Token(Token = "0x400297C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0400297D RID: 10621
		[Token(Token = "0x400297D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0400297E RID: 10622
		[Token(Token = "0x400297E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _selectedButtonImage;

		// Token: 0x0400297F RID: 10623
		[Token(Token = "0x400297F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _buttonsContainer;

		// Token: 0x04002980 RID: 10624
		[Token(Token = "0x4002980")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MonoPointerClickHandler _bankGalleryButtonPrefab;

		// Token: 0x04002981 RID: 10625
		[Token(Token = "0x4002981")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _demoModeDelay;

		// Token: 0x04002982 RID: 10626
		[Token(Token = "0x4002982")]
		[FieldOffset(Offset = "0x28")]
		private RectTransform _buttonsContainerRectTransform;

		// Token: 0x04002983 RID: 10627
		[Token(Token = "0x4002983")]
		[FieldOffset(Offset = "0x2C")]
		private List<MonoPointerClickHandler> _buttons;

		// Token: 0x04002984 RID: 10628
		[Token(Token = "0x4002984")]
		[FieldOffset(Offset = "0x30")]
		private int _currentSelectedIndex;

		// Token: 0x04002985 RID: 10629
		[Token(Token = "0x4002985")]
		[FieldOffset(Offset = "0x34")]
		private Coroutine _demoCoroutine;

		// Token: 0x04002986 RID: 10630
		[Token(Token = "0x4002986")]
		[FieldOffset(Offset = "0x38")]
		private TweenContainer _tweenContainer;
	}
}
