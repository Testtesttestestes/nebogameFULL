using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Test;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Core.Dev
{
	// Token: 0x020010B1 RID: 4273
	[Token(Token = "0x20010B1")]
	public class DevMenuUnlocker : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x14000230 RID: 560
		// (add) Token: 0x06006330 RID: 25392 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006331 RID: 25393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000230")]
		public event Action DevMenuUnlockedEvent
		{
			[Token(Token = "0x6006330")]
			[Address(RVA = "0xAF3C", Offset = "0xAF3C", VA = "0xAF3C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006331")]
			[Address(RVA = "0xAF3D", Offset = "0xAF3D", VA = "0xAF3D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000231 RID: 561
		// (add) Token: 0x06006332 RID: 25394 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006333 RID: 25395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000231")]
		public event Action ClickedEvent
		{
			[Token(Token = "0x6006332")]
			[Address(RVA = "0xAF3E", Offset = "0xAF3E", VA = "0xAF3E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006333")]
			[Address(RVA = "0xAF3F", Offset = "0xAF3F", VA = "0xAF3F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006334 RID: 25396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006334")]
		[Address(RVA = "0xAF40", Offset = "0xAF40", VA = "0xAF40")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Core_Dev_DevMenuUnlocker__Awake(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60773 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Dev_DevMenuUnlocker_HideDevMenuByConsole__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Dev_DevMenuUnlocker_ShowDevMenuByConsole__);
		    DAT_ram_00a60773 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Core_Dev_DevMenuUnlocker_ShowDevMenuByConsole__,0);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Core_Dev_DevMenuUnlocker_HideDevMenuByConsole__,0);
		  return;
		}
		*/

		}

		// Token: 0x06006335 RID: 25397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006335")]
		[Address(RVA = "0xAF41", Offset = "0xAF41", VA = "0xAF41")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Core_Dev_DevMenuUnlocker__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,1,0);
		  LunarConsolePlugin_LunarConsole__Show(0);
		  return;
		}
		*/

		}

		// Token: 0x06006336 RID: 25398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006336")]
		[Address(RVA = "0xAF42", Offset = "0xAF42", VA = "0xAF42")]
		private void ShowDevMenuByConsole()
		{
		/* --- GHIDRA: ShowDevMenuByConsole ---
		void Core_Dev_DevMenuUnlocker__ShowDevMenuByConsole(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  LunarConsolePlugin_LunarConsole__Show(0);
		  return;
		}
		*/

		}

		// Token: 0x06006337 RID: 25399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006337")]
		[Address(RVA = "0xAF43", Offset = "0xAF43", VA = "0xAF43")]
		private void HideDevMenuByConsole()
		{
		/* --- GHIDRA: HideDevMenuByConsole ---
		void Core_Dev_DevMenuUnlocker__HideDevMenuByConsole(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  float param2_00;
		  int param2_01;
		  uint uVar2;
		  
		  if (DAT_ram_00a60774 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_float__Add__);
		    DAT_ram_00a60774 = '\x01';
		  }
		  param2_01 = *(int *)(param1 + 0x1c);
		  param2_00 = UnityEngine_SystemClock___cctor(0);
		  iVar1 = Method_System_Collections_Generic_List_float__Add__;
		  *(int *)(param2_01 + 0x10) = *(int *)(param2_01 + 0x10) + 1;
		  uVar2 = *(uint *)(param2_01 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param2_01 + 8) + 0xc)) {
		    *(uint *)(param2_01 + 0xc) = uVar2 + 1;
		    *(float *)(*(int *)(param2_01 + 8) + uVar2 * 4 + 0x10) = param2_00;
		    Core_Dev_DevMenuUnlocker__OnPointerClick(param1,param2_01);
		    return;
		  }
		  func_ii_2840(param2_01,param2_00,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  Core_Dev_DevMenuUnlocker__OnPointerClick(param1,param2_01);
		  return;
		}
		*/

		}

		// Token: 0x06006338 RID: 25400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006338")]
		[Address(RVA = "0xAF44", Offset = "0xAF44", VA = "0xAF44", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Core_Dev_DevMenuUnlocker__OnPointerClick(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  float fVar2;
		  int iVar3;
		  int param2_00;
		  
		  if (DAT_ram_00a60775 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_float__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_float__RemoveAt__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_float__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_float__get_Item__);
		    DAT_ram_00a60775 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x18);
		  if (iVar3 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		  }
		  iVar3 = *(int *)(param1 + 0x1c);
		  if (9 < *(int *)(iVar3 + 0xc)) {
		    if (*(int *)(iVar3 + 0xc) == 10) {
		      param2_00 = 0;
		    }
		    else {
		      System_Collections_Generic_List_VisualTreeAsset_UxmlObjectEntry___RemoveAt
		                (iVar3,0,Method_System_Collections_Generic_List_float__RemoveAt__);
		      iVar3 = *(int *)(param1 + 0x1c);
		      param2_00 = *(int *)(iVar3 + 0xc) + -10;
		    }
		    fVar1 = System_Collections_Generic_List_float___get_Count
		                      (iVar3,param2_00,Method_System_Collections_Generic_List_float__get_Item__);
		    fVar2 = System_Collections_Generic_List_float___get_Count
		                      (*(int *)(param1 + 0x1c),*(int *)(*(int *)(param1 + 0x1c) + 0xc) + -1,
		                       Method_System_Collections_Generic_List_float__get_Item__);
		    if (fVar2 - fVar1 < 3.0) {
		      iVar3 = *(int *)(param1 + 0x14);
		      if (iVar3 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                  (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		      }
		      iVar3 = *(int *)(param1 + 0x1c);
		      *(undefined4 *)(iVar3 + 0xc) = 0;
		      *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006339 RID: 25401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006339")]
		[Address(RVA = "0xAF45", Offset = "0xAF45", VA = "0xAF45")]
		private void Validate()
		{
		/* --- GHIDRA: Validate ---
		void Core_Dev_DevMenuUnlocker__Validate(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600633A RID: 25402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600633A")]
		[Address(RVA = "0xAF46", Offset = "0xAF46", VA = "0xAF46")]
		public void Show()
		{
		}

		// Token: 0x0600633B RID: 25403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600633B")]
		[Address(RVA = "0xAF47", Offset = "0xAF47", VA = "0xAF47")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Core_Dev_DevMenuUnlocker__Hide(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a60776 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_float___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_float__TypeInfo);
		    DAT_ram_00a60776 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_float__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_float___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600633C RID: 25404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600633C")]
		[Address(RVA = "0xAF48", Offset = "0xAF48", VA = "0xAF48")]
		public DevMenuUnlocker()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Dev_DevMenuUnlocker___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a60777 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Dev_DevMenuVideoAd_ButtonClick__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12403);
		    DAT_ram_00a60777 = '\x01';
		  }
		  TMPro_TMP_InputField__get_text(*(undefined4 *)(param1 + 0x10),StringLiteral_12403,0);
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull(param1_00,param1,Method_Core_Dev_DevMenuVideoAd_ButtonClick__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0400352D RID: 13613
		[Token(Token = "0x400352D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private DevMenuWindow _devMenuWindow;

		// Token: 0x04003530 RID: 13616
		[Token(Token = "0x4003530")]
		public const float TIME_TO_UNLOCK = 3f;

		// Token: 0x04003531 RID: 13617
		[Token(Token = "0x4003531")]
		public const int NUM_CLICK_TO_UNLOCK = 10;

		// Token: 0x04003532 RID: 13618
		[Token(Token = "0x4003532")]
		[FieldOffset(Offset = "0x1C")]
		private List<float> _clicks;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_DevMenuUnlockedEvent ---
		void Core_Dev_DevMenuUnlocker__add_DevMenuUnlockedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a6076f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a6076f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x14,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_DevMenuUnlockedEvent ---
		void Core_Dev_DevMenuUnlocker__remove_DevMenuUnlockedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a60770 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a60770 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x18,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_ClickedEvent ---
		void Core_Dev_DevMenuUnlocker__add_ClickedEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a60771 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a60771 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x18,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ClickedEvent ---
		void Core_Dev_DevMenuUnlocker__remove_ClickedEvent(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60772 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Dev_DevMenuUnlocker_HideDevMenuByConsole__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Dev_DevMenuUnlocker_ShowDevMenuByConsole__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8843);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14321);
		    DAT_ram_00a60772 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Core_Dev_DevMenuUnlocker_ShowDevMenuByConsole__,0);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Core_Dev_DevMenuUnlocker_HideDevMenuByConsole__,0);
		  return;
		}
		*/

}
