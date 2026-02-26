using System;
using System.Collections.Generic;
using Core.Animations;
using DefaultNamespace;
using Il2CppDummyDll;
using Test;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000009")]
public class AnimationTest : MonoBehaviour
{
	// Token: 0x17000004 RID: 4
	// (get) Token: 0x060000A8 RID: 168 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000004")]
	public Toggle PanToggle
	{
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x556D", Offset = "0x556D", VA = "0x556D")]
		get
		{
			return null;
		}
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x556E", Offset = "0x556E", VA = "0x556E")]
	private void Awake()
	{
		/* --- GHIDRA: Awake ---
		void AnimationTest__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  int param1_00;
		  
		  if (DAT_ram_00a64865 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_AnimationTest_OnTypeAnimationChanged__);
		    Mono_Security_ASN1__get_Item(&Method_AnimationTest_PlayOnceClickHandler__);
		    Mono_Security_ASN1__get_Item(&Method_AnimationTest_ShowButtonClicked__);
		    Mono_Security_ASN1__get_Item(&DefaultNamespace_AnimationType___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_CanvasGroup___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_AnimationType__Dropdown_OptionData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_Dropdown_OptionData___);
		    Mono_Security_ASN1__get_Item(&System_Func_AnimationType__Dropdown_OptionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_AnimationTest___c__Start_b__21_0__);
		    Mono_Security_ASN1__get_Item(&AnimationTest___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_int__AddListener__);
		    DAT_ram_00a64865 = '\x01';
		  }
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_CanvasGroup___);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  uVar1 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar1,0,0);
		  if (iVar2 != 0) {
		    System_Linq_Enumerable__First_object_(*(undefined4 *)(param1 + 0x10),0,0);
		    uVar3 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull(uVar1,param1,Method_AnimationTest_ShowButtonClicked__,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		  }
		  iVar2 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_AnimationType___TypeInfo,2);
		  *(undefined8 *)(iVar2 + 0x10) = 0x300000002;
		  *(int *)(param1 + 0x40) = iVar2;
		  uVar1 = *(undefined4 *)(param1 + 0x18);
		  if (*(int *)(AnimationTest___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(AnimationTest___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(AnimationTest___c_TypeInfo + 0x5c);
		  param1_00 = puVar4[1];
		  if (param1_00 == 0) {
		    if (*(int *)(AnimationTest___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(AnimationTest___c_TypeInfo);
		      puVar4 = *(undefined4 **)(AnimationTest___c_TypeInfo + 0x5c);
		    }
		    uVar3 = *puVar4;
		    param1_00 = unnamed_function_1417(System_Func_AnimationType__Dropdown_OptionData__TypeInfo);
		    func_ii_8070(param1_00,uVar3,Method_AnimationTest___c__Start_b__21_0__,0);
		    *(int *)(*(int *)(AnimationTest___c_TypeInfo + 0x5c) + 4) = param1_00;
		  }
		  uVar3 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (iVar2,param1_00,
		                     Method_System_Linq_Enumerable_Select_AnimationType__Dropdown_OptionData___);
		  uVar3 = System_Linq_Enumerable__Select_object__object_
		                    (uVar3,Method_System_Linq_Enumerable_ToList_Dropdown_OptionData___);
		  UnityEngine_UI_Dropdown__set_itemImage(uVar1,uVar3,0);
		  uVar3 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xd0);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_int__TypeInfo);
		  UnityEngine_Events_UnityAction_Color___Invoke
		            (uVar1,param1,Method_AnimationTest_OnTypeAnimationChanged__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_int__AddListener__);
		  *(undefined4 *)(param1 + 0x48) =
		       *(undefined4 *)(*(int *)(param1 + 0x40) + *(int *)(*(int *)(param1 + 0x18) + 200) * 4 + 0x10)
		  ;
		  AnimationTest__OnTypeAnimationChanged(param1,param1);
		  uVar3 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull(uVar1,param1,Method_AnimationTest_PlayOnceClickHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		  return;
		}
		*/

	}

	// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x556F", Offset = "0x556F", VA = "0x556F")]
	private void Start()
	{
		/* --- GHIDRA: Start ---
		void AnimationTest__Start(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a64866 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_string___);
		    Mono_Security_ASN1__get_Item(&System_Func_string__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_AnimationLoaderTest___)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_GameObject___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_AnimationTest___c__DisplayClass23_0__PlayOnceClickHandler_b__0__);
		    Mono_Security_ASN1__get_Item(&AnimationTest___c__DisplayClass23_0_TypeInfo);
		    DAT_ram_00a64866 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x58);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 != 0) {
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x58),0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    UnityEngine_Application__get_isPlaying(uVar2,0);
		    *(undefined4 *)(param1 + 0x58) = 0;
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x24) + 0x160);
		  iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar2,0);
		  if (iVar1 == 0) goto code_r0x82594ad5;
		  iVar1 = unnamed_function_1417(AnimationTest___c__DisplayClass23_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) =
		       *(undefined4 *)(*(int *)(param1 + 0x3c) + *(int *)(*(int *)(param1 + 0x1c) + 200) * 4 + 0x10)
		  ;
		  uVar2 = 0;
		  if (*(int *)(param1 + 0x48) == 2) {
		    puVar3 = (undefined4 *)(*(int *)(param1 + 0x38) + 0xc);
		code_r0x82594aa0:
		    uVar2 = *puVar3;
		  }
		  else if (*(int *)(param1 + 0x48) == 3) {
		    puVar3 = (undefined4 *)(*(int *)(param1 + 0x38) + 0x10);
		    goto code_r0x82594aa0;
		  }
		  uVar4 = unnamed_function_1417(System_Func_string__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar4,iVar1,Method_AnimationTest___c__DisplayClass23_0__PlayOnceClickHandler_b__0__,0);
		  uVar2 = System_Func_object__bool____ctor
		                    (uVar2,uVar4,Method_System_Linq_Enumerable_FirstOrDefault_string___);
		code_r0x82594ad5:
		  uVar4 = *(undefined4 *)(param1 + 0x34);
		  uVar5 = *(undefined4 *)(param1 + 0x4c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar4 = func_ii_6805(uVar5,uVar4,Method_UnityEngine_Object_Instantiate_GameObject___);
		  uVar5 = UnityEngine_UI_Selectable__set_interactable(uVar4,0);
		  if (DAT_ram_00a65020 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		    DAT_ram_00a65020 = '\x01';
		  }
		  local_20 = **(undefined8 **)(UnityEngine_Vector3_TypeInfo + 0x5c);
		  local_18 = *(undefined4 *)(*(undefined8 **)(UnityEngine_Vector3_TypeInfo + 0x5c) + 1);
		  local_10 = local_20;
		  local_8 = local_18;
		  Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(uVar5,&local_20,0);
		  uVar4 = func_ii_6601(uVar4,Method_UnityEngine_GameObject_GetComponent_AnimationLoaderTest___);
		  Test_AnimationLoaderTest___ctor
		            (uVar4,uVar2,*(undefined4 *)(param1 + 0x34),*(undefined4 *)(param1 + 0x30),0);
		  *(undefined4 *)(param1 + 0x58) = uVar4;
		  return;
		}
		*/

	}

	// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x5570", Offset = "0x5570", VA = "0x5570")]
	private void PlayOnceClickHandler()
	{
		/* --- GHIDRA: PlayOnceClickHandler ---
		void AnimationTest__PlayOnceClickHandler(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a64867 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGameAnimation__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_AnimationTest_CurrentSpellAnimationOnCompleteEvent__);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22119);
		    DAT_ram_00a64867 = '\x01';
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  uVar1 = 0;
		  System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_22119,0);
		  uVar2 = unnamed_function_1417(System_Action_IGameAnimation__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_AnimationTest_CurrentSpellAnimationOnCompleteEvent__,0);
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd8);
		        goto code_r0x82594cd7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_Animations_IGameAnimation_TypeInfo,3);
		code_r0x82594cd7:
		  (**(code **)((ulonglong)*puVar3 * 4))(param2,uVar2,puVar3[1]);
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf0);
		        goto code_r0x82594d53;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_Animations_IGameAnimation_TypeInfo,6);
		code_r0x82594d53:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar2,0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  UnityEngine_Application__get_isPlaying(uVar2,0);
		  UnityEngine_CanvasGroup__get_interactable(*(undefined4 *)(param1 + 0x2c),1,0);
		  return;
		}
		*/

	}

	// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x5571", Offset = "0x5571", VA = "0x5571")]
	private void CurrentSpellAnimationOnCompleteEvent(IGameAnimation animation)
	{
		/* --- GHIDRA: CurrentSpellAnimationOnCompleteEvent ---
		void AnimationTest__CurrentSpellAnimationOnCompleteEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  AnimationTest__OnTypeAnimationChanged(param1,param1);
		  return;
		}
		*/

	}

	// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x5572", Offset = "0x5572", VA = "0x5572")]
	private void OnFilterInputChanged(string arg0)
	{
		/* --- GHIDRA: OnFilterInputChanged ---
		undefined4 AnimationTest__OnFilterInputChanged(int param1,undefined4 param2)
		
		{
		  undefined4 *puVar1;
		  
		  if (*(int *)(param1 + 0x48) == 2) {
		    puVar1 = (undefined4 *)(*(int *)(param1 + 0x38) + 0xc);
		  }
		  else {
		    if (*(int *)(param1 + 0x48) != 3) {
		      return 0;
		    }
		    puVar1 = (undefined4 *)(*(int *)(param1 + 0x38) + 0x10);
		  }
		  return *puVar1;
		}
		*/

	}

	// Token: 0x060000AE RID: 174 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x5573", Offset = "0x5573", VA = "0x5573")]
	private string[] GetCurrentPrefabsArray()
	{
		/* --- GHIDRA: GetCurrentPrefabsArray ---
		void AnimationTest__GetCurrentPrefabsArray(int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0x48) =
		       *(undefined4 *)(*(int *)(param1 + 0x40) + *(int *)(*(int *)(param1 + 0x18) + 200) * 4 + 0x10)
		  ;
		  AnimationTest__OnTypeAnimationChanged(param1,param1);
		  return;
		}
		*/

		return null;
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x5574", Offset = "0x5574", VA = "0x5574")]
	private void OnTypeAnimationChanged(int arg0)
	{
		/* --- GHIDRA: OnTypeAnimationChanged ---
		void AnimationTest__OnTypeAnimationChanged(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  undefined4 param2_00;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a64868 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_string__Dropdown_OptionData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_string___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_Dropdown_OptionData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_string___);
		    Mono_Security_ASN1__get_Item(&System_Func_string__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_string__Dropdown_OptionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_AnimationTest___c__ValidateDropdown_b__28_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_AnimationTest___c__DisplayClass28_0__ValidateDropdown_b__0__);
		    Mono_Security_ASN1__get_Item(&AnimationTest___c__DisplayClass28_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&AnimationTest___c_TypeInfo);
		    DAT_ram_00a64868 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(AnimationTest___c__DisplayClass28_0_TypeInfo);
		  *(undefined4 *)(iVar2 + 8) = *(undefined4 *)(*(int *)(param1 + 0x20) + 0x114);
		  if (*(int *)(param1 + 0x48) == 2) {
		    puVar4 = (undefined4 *)(*(int *)(param1 + 0x38) + 0xc);
		  }
		  else {
		    if (*(int *)(param1 + 0x48) != 3) goto code_r0x82594870;
		    puVar4 = (undefined4 *)(*(int *)(param1 + 0x38) + 0x10);
		  }
		  uVar1 = *puVar4;
		code_r0x82594870:
		  uVar3 = unnamed_function_1417(System_Func_string__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar3,iVar2,Method_AnimationTest___c__DisplayClass28_0__ValidateDropdown_b__0__,0);
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar1,uVar3,Method_System_Linq_Enumerable_Where_string___);
		  uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_string___);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  uVar3 = *(undefined4 *)(param1 + 0x1c);
		  if (*(int *)(AnimationTest___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(AnimationTest___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(AnimationTest___c_TypeInfo + 0x5c);
		  iVar2 = puVar4[2];
		  if (iVar2 == 0) {
		    if (*(int *)(AnimationTest___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(AnimationTest___c_TypeInfo);
		      puVar4 = *(undefined4 **)(AnimationTest___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar4;
		    iVar2 = unnamed_function_1417(System_Func_string__Dropdown_OptionData__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar2,param2_00,Method_AnimationTest___c__ValidateDropdown_b__28_1__,0);
		    *(int *)(*(int *)(AnimationTest___c_TypeInfo + 0x5c) + 8) = iVar2;
		  }
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar1,iVar2,Method_System_Linq_Enumerable_Select_string__Dropdown_OptionData___
		                    );
		  uVar1 = System_Linq_Enumerable__Select_object__object_
		                    (uVar1,Method_System_Linq_Enumerable_ToList_Dropdown_OptionData___);
		  UnityEngine_UI_Dropdown__set_itemImage(uVar3,uVar1,0);
		  return;
		}
		*/

	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x5575", Offset = "0x5575", VA = "0x5575")]
	private void ValidateDropdown()
	{
		/* --- GHIDRA: ValidateDropdown ---
		void AnimationTest__ValidateDropdown(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a64869 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_AnimationLoaderTest___)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_GameObject___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a64869 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x34);
		  param1_00 = *(undefined4 *)(param1 + 0x4c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  func_ii_6805(param1_00,uVar1,Method_UnityEngine_Object_Instantiate_GameObject___);
		  uVar1 = func_ii_6601(*(undefined4 *)(param1 + 0x4c),
		                       Method_UnityEngine_GameObject_GetComponent_AnimationLoaderTest___);
		  Test_AnimationLoaderTest__OnCompleteEvent(uVar1,*(undefined4 *)(param1 + 0x50),0);
		  return;
		}
		*/

	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x5576", Offset = "0x5576", VA = "0x5576")]
	private void ShowButtonClicked()
	{
		/* --- GHIDRA: ShowButtonClicked ---
		void AnimationTest__ShowButtonClicked(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6486a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameObject___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_GameObject__TypeInfo);
		    DAT_ram_00a6486a = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_GameObject__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_GameObject___ctor__);
		  *(undefined4 *)(param1 + 0x54) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x5577", Offset = "0x5577", VA = "0x5577")]
	public AnimationTest()
	{
		/* --- GHIDRA: .ctor ---
		void AnimationTest___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6486b == '\0') {
		    Mono_Security_ASN1__get_Item(&AnimationTest___c_TypeInfo);
		    DAT_ram_00a6486b = '\x01';
		  }
		  uVar1 = unnamed_function_1417(AnimationTest___c_TypeInfo);
		  **(undefined4 **)(AnimationTest___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

	}

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private Button _startButton;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	private Button _playOnceButton;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Dropdown _typeDropdown;

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private Dropdown _dropdown;

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private InputField _filterInput;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private TMP_InputField _urlInput;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Toggle _panToggle;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x2C")]
	private CanvasGroup _canvasGroup;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform _canvasAnimationsContainer;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private Transform _worldAnimationsContainer;

	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AnimationArrayStringData _animationNames;

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x3C")]
	private string[] _names;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x40")]
	private AnimationType[] _types;

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x44")]
	private bool _isBenchmarkNow;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x48")]
	private AnimationType _currentAnimationType;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private GameObject _animationComponentPrefab;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject _testPrefab;

	// Token: 0x04000027 RID: 39
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x54")]
	private List<GameObject> _animations;

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x58")]
	private AnimationLoaderTest _currentLoader;

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_PanToggle ---
		/* WARNING: Type propagation algorithm not settling */
		
		void AnimationTest__get_PanToggle(undefined4 param1,undefined4 param2)
		
		{
		  undefined8 local_20;
		  ushort local_14 [7];
		  ushort local_6;
		  undefined2 local_4;
		  ushort local_2;
		  
		  if (DAT_ram_00a64864 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_DOTween_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool___ctor__);
		    DAT_ram_00a64864 = '\x01';
		  }
		  local_2 = 0;
		  System_Data_SqlTypes_SqlByte__ToSqlInt64(&local_2,0,Method_System_Nullable_bool___ctor__);
		  local_6 = local_2;
		  if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		    func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		  }
		  local_4 = 0;
		  local_14[2] = 0;
		  local_14[3] = 0;
		  local_14[4] = 0;
		  local_14[5] = 0;
		  local_14[1] = 0;
		  local_14[0] = local_6;
		  local_20 = 0;
		  DG_Tweening_DOTween__set_isQuitting(local_14 + 1,local_14,&local_20,0);
		  return;
		}
		*/

}
