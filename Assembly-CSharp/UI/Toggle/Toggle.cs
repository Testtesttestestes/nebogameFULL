using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI.Toggle
{
	// Token: 0x02000170 RID: 368
	[Token(Token = "0x2000170")]
	[AddComponentMenu("Heavens/UI/Toggle")]
	public class Toggle : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IToggleControl
	{
		// Token: 0x140000D8 RID: 216
		// (add) Token: 0x06000A45 RID: 2629 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000A46 RID: 2630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000D8")]
		public event Action ChangedEvent
		{
			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x5D98", Offset = "0x5D98", VA = "0x5D98", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x5D99", Offset = "0x5D99", VA = "0x5D99", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x000038D0 File Offset: 0x00001AD0
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x5D9A", Offset = "0x5D9A", VA = "0x5D9A")]
		private float GetEnabledAppearAlpha()
		{
		/* --- GHIDRA: GetEnabledAppearAlpha ---
		float UI_Toggle_Toggle__GetEnabledAppearAlpha(undefined4 param1,int param2,undefined4 param3)
		
		{
		  float fVar1;
		  
		  fVar1 = 0.0;
		  if (param2 == 0) {
		    fVar1 = 0.3;
		  }
		  return fVar1;
		}
		*/

			return 0f;
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x000038E8 File Offset: 0x00001AE8
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x5D9B", Offset = "0x5D9B", VA = "0x5D9B")]
		private float GetDuration(bool isImmediate)
		{
		/* --- GHIDRA: GetDuration ---
		void UI_Toggle_Toggle__GetDuration(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  UI_Toggle_Toggle__OnPointerClick(param1,(uint)(*(char *)(param1 + 0x10) == '\0'),0,param1);
		  iVar1 = *(int *)(param1 + 0x30);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

			return 0f;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x5D9C", Offset = "0x5D9C", VA = "0x5D9C", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void UI_Toggle_Toggle__OnPointerClick(int param1,uint param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  float param2_00;
		  float param3_00;
		  int iVar3;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a599ab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Color__Color__ColorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a599ab = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  *(char *)(param1 + 0x10) = (char)param2;
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x24),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2 ^ 1,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2,0);
		  func_ii_8007(*(undefined4 *)(param1 + 0x14),0,0);
		  func_ii_8007(*(undefined4 *)(param1 + 0x18),0,0);
		  param2_00 = 1.0;
		  if (*(char *)(param1 + 0x10) == '\0') {
		    param2_00 = 0.0;
		  }
		  param3_00 = 0.0;
		  if (param3 == 0) {
		    param3_00 = 0.3;
		  }
		  uVar1 = func_ii_9125(*(undefined4 *)(param1 + 0x14),param2_00,param3_00,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		            (uVar1,uVar2,
		             Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Color__Color__ColorOptions____
		            );
		  uVar1 = *(undefined4 *)(param1 + 0x18);
		  iVar3 = 0x28;
		  if (*(char *)(param1 + 0x10) == '\0') {
		    iVar3 = 0x2c;
		  }
		  UnityEngine_Transform___ctor(&local_10,*(undefined4 *)(param1 + iVar3),0);
		  local_18 = local_8;
		  local_20 = local_10;
		  uVar1 = DG_Tweening_ShortcutExtensions__DOMoveZ(uVar1,&local_20,param3_00,0,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  uVar1 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                    (uVar1,uVar2,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  DG_Tweening_ShortcutExtensions__DOScale
		            (uVar1,6,
		             Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		            );
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(*(char *)(param1 + 0x10) == '\0'),0);
		  return;
		}
		*/

		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x5D9D", Offset = "0x5D9D", VA = "0x5D9D")]
		private void SetIsEnabled(bool value, bool isImmediate)
		{
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x00003900 File Offset: 0x00001B00
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000151")]
		public bool IsEnabled
		{
			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x5D9E", Offset = "0x5D9E", VA = "0x5D9E", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0x5D9F", Offset = "0x5D9F", VA = "0x5D9F", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x5DA0", Offset = "0x5DA0", VA = "0x5DA0")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_Toggle_Toggle__Awake(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = func_ii_12174(param1,0);
		  if (iVar1 != 0) {
		    UI_Toggle_Toggle__OnPointerClick(param1,(uint)*(byte *)(param1 + 0x10),0,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x5DA1", Offset = "0x5DA1", VA = "0x5DA1")]
		private void OnValidate()
		{
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x5DA2", Offset = "0x5DA2", VA = "0x5DA2")]
		public Toggle()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Toggle_Toggle___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined4 param3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a599ac == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_GameObjectPool_ToastView___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_Cache_GameObjectPool_ToastView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Utils_Cache_ObjectPool_ResetPoolObjectDelegate_ToastView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Toast_ToastController_OnReleaseToast__);
		    DAT_ram_00a599ac = '\x01';
		  }
		  param3 = *(undefined4 *)(param1 + 0x14);
		  param2_00 = *(undefined4 *)(param1 + 0x10);
		  param1_00 = unnamed_function_1417
		                        (Utils_Cache_ObjectPool_ResetPoolObjectDelegate_ToastView__TypeInfo);
		  Core_Cache_AbstractCache_RequestInvoker___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____ctor
		            (param1_00,param1,Method_UI_Toast_ToastController_OnReleaseToast__,0);
		  param1_01 = unnamed_function_1417(Utils_Cache_GameObjectPool_ToastView__TypeInfo);
		  Utils_Cache_GameObjectPoolRestricted_object___CreateInstance
		            (param1_01,param2_00,param3,param1_00,
		             Method_Utils_Cache_GameObjectPool_ToastView___ctor__);
		  *(undefined4 *)(param1 + 0x34) = param1_01;
		  return;
		}
		*/

		}

		// Token: 0x0400045C RID: 1116
		[Token(Token = "0x400045C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _isEnabled;

		// Token: 0x0400045D RID: 1117
		[Token(Token = "0x400045D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _appearEnabled;

		// Token: 0x0400045E RID: 1118
		[Token(Token = "0x400045E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _pointer;

		// Token: 0x0400045F RID: 1119
		[Token(Token = "0x400045F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RectTransform _pointerDisabled;

		// Token: 0x04000460 RID: 1120
		[Token(Token = "0x4000460")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _textEnabled;

		// Token: 0x04000461 RID: 1121
		[Token(Token = "0x4000461")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private RectTransform _textDisabled;

		// Token: 0x04000462 RID: 1122
		[Token(Token = "0x4000462")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _anchorEnabled;

		// Token: 0x04000463 RID: 1123
		[Token(Token = "0x4000463")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private RectTransform _anchorDisabled;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ChangedEvent ---
		void UI_Toggle_Toggle__add_ChangedEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a599aa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a599aa = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x30,param1_01,param1_00);
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


		/* --- GHIDRA: remove_ChangedEvent ---
		float UI_Toggle_Toggle__remove_ChangedEvent(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  
		  fVar1 = 1.0;
		  if (*(char *)(param1 + 0x10) == '\0') {
		    fVar1 = 0.0;
		  }
		  return fVar1;
		}
		*/


		/* --- GHIDRA: get_IsEnabled ---
		void UI_Toggle_Toggle__get_IsEnabled(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  UI_Toggle_Toggle__OnPointerClick(param1,param2,0,param2);
		  return;
		}
		*/


		/* --- GHIDRA: set_IsEnabled ---
		void UI_Toggle_Toggle__set_IsEnabled(int param1,undefined4 param2)
		
		{
		  UI_Toggle_Toggle__OnPointerClick(param1,(uint)*(byte *)(param1 + 0x10),1,param1);
		  return;
		}
		*/

}
