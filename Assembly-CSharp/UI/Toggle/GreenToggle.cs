using System;
using System.Runtime.CompilerServices;
using I2.Loc;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace UI.Toggle
{
	// Token: 0x0200016E RID: 366
	[Token(Token = "0x200016E")]
	public class GreenToggle : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IToggleControl
	{
		// Token: 0x140000D6 RID: 214
		// (add) Token: 0x06000A35 RID: 2613 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000A36 RID: 2614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000D6")]
		public event Action ChangedEvent
		{
			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x5D8C", Offset = "0x5D8C", VA = "0x5D8C", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A36")]
			[Address(RVA = "0x5D8D", Offset = "0x5D8D", VA = "0x5D8D", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x00003870 File Offset: 0x00001A70
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014F")]
		public bool IsEnabled
		{
			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x5D8E", Offset = "0x5D8E", VA = "0x5D8E", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A38")]
			[Address(RVA = "0x5D8F", Offset = "0x5D8F", VA = "0x5D8F", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x5D90", Offset = "0x5D90", VA = "0x5D90")]
		private void SetIsEnableInternal(bool value, bool immediate)
		{
		/* --- GHIDRA: SetIsEnableInternal ---
		void UI_Toggle_GreenToggle__SetIsEnableInternal(float *param1,int param2,undefined4 param3)
		
		{
		  char cVar1;
		  undefined4 param2_00;
		  float fVar2;
		  float fVar3;
		  float4 local_c;
		  float4 local_8;
		  
		  UnityEngine_RectTransform__set_anchoredPosition(&local_c,*(undefined4 *)(param2 + 0x40),0);
		  cVar1 = *(char *)(param2 + 0x48);
		  fVar2 = *(float *)(param2 + 0x1c);
		  param2_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param2 + 0x10),0);
		  UnityEngine_Transform___ctor(&local_c,param2_00,0);
		  param1[1] = (float)local_8;
		  fVar3 = (float)local_c * 0.5 - fVar2;
		  if (cVar1 == '\0') {
		    fVar3 = fVar2 - (float)local_c * 0.5;
		  }
		  *param1 = fVar3;
		  return;
		}
		*/

		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00003888 File Offset: 0x00001A88
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x5D91", Offset = "0x5D91", VA = "0x5D91")]
		private Vector2 GetTogglePosition()
		{
		/* --- GHIDRA: GetTogglePosition ---
		undefined4 UI_Toggle_GreenToggle__GetTogglePosition(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = 1;
		  if (*(char *)(param1 + 0x48) == '\0') {
		    uVar1 = 4;
		  }
		  return uVar1;
		}
		*/

			return default(Vector2);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x000038A0 File Offset: 0x00001AA0
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x5D92", Offset = "0x5D92", VA = "0x5D92")]
		private HorizontalAlignmentOptions GetLabelAlign()
		{
		/* --- GHIDRA: GetLabelAlign ---
		float UI_Toggle_GreenToggle__GetLabelAlign(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  
		  fVar1 = 1.0;
		  if (*(char *)(param1 + 0x48) == '\0') {
		    fVar1 = 0.0;
		  }
		  return fVar1;
		}
		*/

			return (HorizontalAlignmentOptions)0;
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x000038B8 File Offset: 0x00001AB8
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x5D93", Offset = "0x5D93", VA = "0x5D93")]
		private float GetGreenBgAlpha()
		{
		/* --- GHIDRA: GetGreenBgAlpha ---
		void UI_Toggle_GreenToggle__GetGreenBgAlpha(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a599a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    DAT_ram_00a599a7 = '\x01';
		  }
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_RectTransform___);
		  *(undefined4 *)(param1 + 0x40) = uVar1;
		  UI_Toggle_GreenToggle__set_IsEnabled(param1,0,1,param1);
		  return;
		}
		*/

			return 0f;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x5D94", Offset = "0x5D94", VA = "0x5D94")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_Toggle_GreenToggle__Awake(int param1,undefined4 param2)
		
		{
		  Utils_TweenContainer__StopAllTweens(*(undefined4 *)(param1 + 0x4c),0);
		  return;
		}
		*/

		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x5D95", Offset = "0x5D95", VA = "0x5D95")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_Toggle_GreenToggle__OnDestroy(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  UI_Toggle_GreenToggle__set_IsEnabled(param1,(uint)(*(char *)(param1 + 0x48) == '\0'),0,param1);
		  iVar1 = *(int *)(param1 + 0x44);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x5D96", Offset = "0x5D96", VA = "0x5D96", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void UI_Toggle_GreenToggle__OnPointerClick(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a599a8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TweenContainer_TypeInfo);
		    DAT_ram_00a599a8 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Utils_TweenContainer_TypeInfo);
		  Utils_TweenContainer__Dispose(param1_00,0);
		  *(undefined4 *)(param1 + 0x4c) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x5D97", Offset = "0x5D97", VA = "0x5D97")]
		public GreenToggle()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Toggle_GreenToggle___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a599a9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a599a9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
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

		}

		// Token: 0x04000452 RID: 1106
		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _toggleView;

		// Token: 0x04000453 RID: 1107
		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _greenBg;

		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x04000455 RID: 1109
		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _togglePadding;

		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LocalizedString _enabledText;

		// Token: 0x04000457 RID: 1111
		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LocalizedString _disabledText;

		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransform;

		// Token: 0x0400045A RID: 1114
		[Token(Token = "0x400045A")]
		[FieldOffset(Offset = "0x48")]
		private bool _isEnabled;

		// Token: 0x0400045B RID: 1115
		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x4C")]
		private TweenContainer _tweenContainer;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ChangedEvent ---
		void UI_Toggle_GreenToggle__add_ChangedEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a599a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a599a5 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x44);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x44,param1_01,param1_00);
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


		/* --- GHIDRA: get_IsEnabled ---
		void UI_Toggle_GreenToggle__get_IsEnabled(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  UI_Toggle_GreenToggle__set_IsEnabled(param1,param2,0,param2);
		  return;
		}
		*/


		/* --- GHIDRA: set_IsEnabled ---
		void UI_Toggle_GreenToggle__set_IsEnabled(int param1,int param2,int param3,undefined4 param4)
		
		{
		  char cVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  float fVar3;
		  int *piVar4;
		  float param3_00;
		  int iVar5;
		  undefined8 local_28;
		  undefined4 local_20;
		  float4 local_18;
		  float4 local_14;
		  undefined4 local_10;
		  float4 local_c;
		  float4 local_8;
		  
		  if (DAT_ram_00a599a6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a599a6 = '\x01';
		  }
		  Utils_TweenContainer__AddTween(*(undefined4 *)(param1 + 0x4c),0);
		  *(char *)(param1 + 0x48) = (char)param2;
		  fVar3 = 1.0;
		  if (param2 == 0) {
		    fVar3 = 0.0;
		  }
		  param3_00 = 0.0;
		  if (param3 == 0) {
		    param3_00 = 0.3;
		  }
		  uVar2 = func_ii_9125(*(undefined4 *)(param1 + 0x14),fVar3,param3_00,0);
		  Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x4c),uVar2,0);
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x10),0);
		  UnityEngine_RectTransform__set_anchoredPosition(&local_c,*(undefined4 *)(param1 + 0x40),0);
		  cVar1 = *(char *)(param1 + 0x48);
		  fVar3 = *(float *)(param1 + 0x1c);
		  param2_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param1 + 0x10),0);
		  UnityEngine_Transform___ctor(&local_c,param2_00,0);
		  local_10 = 0;
		  local_20 = 0;
		  local_18 = (float4)((float)local_c * 0.5 - fVar3);
		  if (cVar1 == '\0') {
		    local_18 = (float4)(fVar3 - (float)local_c * 0.5);
		  }
		  local_14 = local_8;
		  local_28 = CONCAT44(local_8,local_18);
		  uVar2 = DG_Tweening_ShortcutExtensions__DOMoveZ(uVar2,&local_28,param3_00,0,0);
		  uVar2 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar2,6,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x4c),uVar2,0);
		  uVar2 = 1;
		  if (*(char *)(param1 + 0x48) == '\0') {
		    uVar2 = 4;
		  }
		  TMPro_TMP_Text__get_horizontalAlignment(*(undefined4 *)(param1 + 0x18),uVar2,0);
		  piVar4 = *(int **)(param1 + 0x18);
		  iVar5 = 0x20;
		  if (*(char *)(param1 + 0x48) == '\0') {
		    iVar5 = 0x30;
		  }
		  uVar2 = I2_Loc_LocalizedString___ctor(param1 + iVar5,0);
		  iVar5 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))
		            (piVar4,uVar2,*(undefined4 *)(iVar5 + 0x2d4));
		  return;
		}
		*/

}
