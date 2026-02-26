using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Utils;

namespace UI.Scroll
{
	// Token: 0x0200018C RID: 396
	[Token(Token = "0x200018C")]
	public class ScrollWithButtons : MonoBehaviour
	{
		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x17000173")]
		protected virtual float AnchoredPositionAxis
		{
			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0x5E2F", Offset = "0x5E2F", VA = "0x5E2F", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x5E30", Offset = "0x5E30", VA = "0x5E30")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_Scroll_ScrollWithButtons__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a599f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Scroll_ScrollWithButtons_ScrollToBeginning__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Scroll_ScrollWithButtons_ScrollToEnd__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a599f9 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_UI_Scroll_ScrollWithButtons_ScrollToBeginning__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull(uVar1,param1,Method_UI_Scroll_ScrollWithButtons_ScrollToEnd__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  Utils_TweenContainer__StopAllTweens(*(undefined4 *)(param1 + 0x2c),0);
		  return;
		}
		*/

		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x5E31", Offset = "0x5E31", VA = "0x5E31")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_Scroll_ScrollWithButtons__OnDestroy(int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  float fVar3;
		  float fVar4;
		  float fVar5;
		  double dVar6;
		  int iVar7;
		  double dVar8;
		  double dVar9;
		  ulonglong uVar10;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  float8 local_8;
		  
		  if (DAT_ram_00a599fa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a599fa = '\x01';
		  }
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties(&local_18,param1[9],0);
		  local_30 = local_10;
		  local_38 = local_18;
		  uVar1 = CONCAT44(in_register_20000004,param1);
		  fVar3 = (float)(**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		                           (uVar1,&local_38,*(undefined4 *)(*param1 + 0xfc));
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties(&local_28,param1[10],0);
		  local_40 = local_20;
		  local_48 = local_28;
		  fVar4 = (float)(**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		                           (CONCAT44(uVar2,param1),&local_48,*(undefined4 *)(*param1 + 0xfc));
		  fVar5 = (float)(**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                           (param1,*(undefined4 *)(*param1 + 0xe4));
		  iVar7 = param1[7];
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  dVar8 = (double)fVar5;
		  dVar6 = unnamed_function_4206(dVar8,&local_8);
		  dVar9 = (double)local_8;
		  if (0.0 <= fVar5) {
		    if (dVar6 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar10 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar10 = 0;
		      }
		      if ((uVar10 & 1) != 0) {
		        dVar9 = (double)local_8 + 1.0;
		      }
		    }
		    else {
		      dVar9 = FLOOR(dVar8 + 0.5);
		    }
		  }
		  else if (dVar6 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar10 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar10 = 0;
		    }
		    if ((uVar10 & 1) != 0) {
		      dVar9 = (double)local_8 + -1.0;
		    }
		  }
		  else {
		    dVar9 = CEIL(dVar8 + -0.5);
		  }
		  System_Linq_Enumerable__First_object_(iVar7,(uint)(dVar9 < 0.0),0);
		  iVar7 = param1[8];
		  dVar6 = unnamed_function_4206(dVar8,&local_8);
		  dVar9 = (double)local_8;
		  if (0.0 <= fVar5) {
		    if (dVar6 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar10 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar10 = 0;
		      }
		      if ((uVar10 & 1) != 0) {
		        dVar9 = (double)local_8 + 1.0;
		      }
		    }
		    else {
		      dVar9 = FLOOR(dVar8 + 0.5);
		    }
		  }
		  else if (dVar6 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar10 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar10 = 0;
		    }
		    if ((uVar10 & 1) != 0) {
		      dVar9 = (double)local_8 + -1.0;
		    }
		  }
		  else {
		    dVar9 = CEIL(dVar8 + -0.5);
		  }
		  dVar8 = (double)(fVar3 - fVar4);
		  dVar6 = unnamed_function_4206(dVar8,&local_8);
		  if (0.0 <= fVar3 - fVar4) {
		    if (dVar6 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar10 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar10 = 0;
		      }
		      if ((uVar10 & 1) != 0) {
		        local_8 = (float8)((double)local_8 + 1.0);
		      }
		    }
		    else {
		      local_8 = (float8)FLOOR(dVar8 + 0.5);
		    }
		  }
		  else if (dVar6 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar10 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar10 = 0;
		    }
		    if ((uVar10 & 1) != 0) {
		      local_8 = (float8)((double)local_8 + -1.0);
		    }
		  }
		  else {
		    local_8 = (float8)CEIL(dVar8 + -0.5);
		  }
		  System_Linq_Enumerable__First_object_(iVar7,(uint)((double)local_8 < dVar9),0);
		  return;
		}
		*/

		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x5E32", Offset = "0x5E32", VA = "0x5E32", Slot = "5")]
		protected virtual void Update()
		{
		/* --- GHIDRA: Update ---
		int UI_Scroll_ScrollWithButtons__Update(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a599fb == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Scroll_ScrollWithButtons__ValidateScrollButtons_d__13_TypeInfo)
		    ;
		    DAT_ram_00a599fb = '\x01';
		  }
		  iVar1 = unnamed_function_1417(UI_Scroll_ScrollWithButtons__ValidateScrollButtons_d__13_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x5E33", Offset = "0x5E33", VA = "0x5E33")]
		private IEnumerator ValidateScrollButtons()
		{
		/* --- GHIDRA: ValidateScrollButtons ---
		void UI_Scroll_ScrollWithButtons__ValidateScrollButtons(undefined4 param1,undefined4 param2)
		
		{
		  UI_Scroll_ScrollWithButtons__ScrollToBeginning(param1,1,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x5E34", Offset = "0x5E34", VA = "0x5E34")]
		public void ScrollToEnd()
		{
		/* --- GHIDRA: ScrollToEnd ---
		void UI_Scroll_ScrollWithButtons__ScrollToEnd(undefined4 param1,undefined4 param2)
		
		{
		  UI_Scroll_ScrollWithButtons__ScrollToBeginning(param1,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x5E35", Offset = "0x5E35", VA = "0x5E35")]
		public void ScrollToBeginning()
		{
		/* --- GHIDRA: ScrollToBeginning ---
		void UI_Scroll_ScrollWithButtons__ScrollToBeginning(int *param1,int param2,undefined4 param3)
		
		{
		  float fVar1;
		  float fVar2;
		  undefined4 param2_00;
		  float param1_00;
		  float fVar3;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties(&local_10,param1[9],0);
		  local_28 = local_8;
		  local_30 = local_10;
		  fVar1 = (float)(**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		                           (param1,&local_30,*(undefined4 *)(*param1 + 0xfc));
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties(&local_20,param1[10],0);
		  local_38 = local_18;
		  local_40 = local_20;
		  fVar2 = (float)(**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		                           (param1,&local_40,*(undefined4 *)(*param1 + 0xfc));
		  if (fVar1 < fVar2) {
		    fVar2 = fVar1 - fVar2;
		    fVar3 = -fVar1;
		    if (param2 == 0) {
		      fVar3 = fVar1;
		    }
		    fVar1 = (float)(**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                             (param1,*(undefined4 *)(*param1 + 0xe4));
		    fVar3 = fVar3 + fVar1;
		    fVar1 = 0.0;
		    if (fVar3 <= 0.0) {
		      fVar1 = fVar3;
		    }
		    param1_00 = fVar2;
		    if (fVar2 <= fVar3) {
		      param1_00 = fVar1;
		    }
		    fVar1 = UnityEngine_Camera__set_orthographicSize(param1_00,fVar2,0);
		    param2_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                          (param1,fVar1,*(undefined4 *)(*param1 + 0xf4));
		    Utils_TimeUtils___cctor(param1[0xb],param2_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x5E36", Offset = "0x5E36", VA = "0x5E36")]
		private void Scroll(bool toEnd)
		{
		/* --- GHIDRA: Scroll ---
		undefined4 UI_Scroll_ScrollWithButtons__Scroll(int param1,float param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a599fc == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetEase_Tweener___);
		    DAT_ram_00a599fc = '\x01';
		  }
		  uVar1 = DG_Tweening_DOTweenModuleUI__DONormalizedPos
		                    (*(undefined4 *)(param1 + 0x10),param2,0.5,0,0);
		  uVar1 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar1,6,Method_DG_Tweening_TweenSettingsExtensions_SetEase_Tweener___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x5E37", Offset = "0x5E37", VA = "0x5E37", Slot = "6")]
		protected virtual Tweener DoMove(float scrollPosNormalized)
		{
			return null;
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00003AC8 File Offset: 0x00001CC8
		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x5E38", Offset = "0x5E38", VA = "0x5E38", Slot = "7")]
		protected virtual float GetRectAxis(Rect rect)
		{
		/* --- GHIDRA: GetRectAxis ---
		void UI_Scroll_ScrollWithButtons__GetRectAxis(undefined4 param1,undefined4 param2)
		
		{
		  int param2_00;
		  
		  if (DAT_ram_00a599fb == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Scroll_ScrollWithButtons__ValidateScrollButtons_d__13_TypeInfo)
		    ;
		    DAT_ram_00a599fb = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (UI_Scroll_ScrollWithButtons__ValidateScrollButtons_d__13_TypeInfo);
		  *(undefined4 *)(param2_00 + 0x10) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  return;
		}
		*/

			return 0f;
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x5E39", Offset = "0x5E39", VA = "0x5E39")]
		public void Invalidate()
		{
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x5E3A", Offset = "0x5E3A", VA = "0x5E3A")]
		public ScrollWithButtons()
		{
		}

		// Token: 0x04000502 RID: 1282
		[Token(Token = "0x4000502")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected ScrollRect _scrollRect;

		// Token: 0x04000503 RID: 1283
		[Token(Token = "0x4000503")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _viewport;

		// Token: 0x04000504 RID: 1284
		[Token(Token = "0x4000504")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04000505 RID: 1285
		[Token(Token = "0x4000505")]
		[FieldOffset(Offset = "0x1C")]
		[FormerlySerializedAs("_scrollLeftButton")]
		[SerializeField]
		protected Button _scrollToBeginningButton;

		// Token: 0x04000506 RID: 1286
		[Token(Token = "0x4000506")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("_scrollRightButton")]
		[SerializeField]
		protected Button _scrollToEndButton;

		// Token: 0x04000507 RID: 1287
		[Token(Token = "0x4000507")]
		[FieldOffset(Offset = "0x24")]
		protected RectTransform _viewportRectTransform;

		// Token: 0x04000508 RID: 1288
		[Token(Token = "0x4000508")]
		[FieldOffset(Offset = "0x28")]
		protected RectTransform _containerRectTransform;

		// Token: 0x04000509 RID: 1289
		[Token(Token = "0x4000509")]
		[FieldOffset(Offset = "0x2C")]
		private TweenContainer _tweenContainer;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_AnchoredPositionAxis ---
		void UI_Scroll_ScrollWithButtons__get_AnchoredPositionAxis(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a599f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    Mono_Security_ASN1__get_Item(&Method_UI_Scroll_ScrollWithButtons_ScrollToBeginning__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Scroll_ScrollWithButtons_ScrollToEnd__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a599f8 = '\x01';
		  }
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                       Method_UnityEngine_Component_GetComponent_RectTransform___);
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 0x18),
		                       Method_UnityEngine_Component_GetComponent_RectTransform___);
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_UI_Scroll_ScrollWithButtons_ScrollToBeginning__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull(uVar1,param1,Method_UI_Scroll_ScrollWithButtons_ScrollToEnd__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  return;
		}
		*/

}
