using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Tweens
{
	// Token: 0x02000134 RID: 308
	[Token(Token = "0x2000134")]
	internal class TweeningValue : MonoBehaviour
	{
		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x00003738 File Offset: 0x00001938
		[Token(Token = "0x17000137")]
		public float Value
		{
			[Token(Token = "0x600094F")]
			[Address(RVA = "0x5CC9", Offset = "0x5CC9", VA = "0x5CC9")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000138")]
		public RectTransform ValueTransform
		{
			[Token(Token = "0x6000950")]
			[Address(RVA = "0x5CCA", Offset = "0x5CCA", VA = "0x5CCA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000139")]
		public RectTransform RectTransform
		{
			[Token(Token = "0x6000951")]
			[Address(RVA = "0x5CCB", Offset = "0x5CCB", VA = "0x5CCB")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x5CCC", Offset = "0x5CCC", VA = "0x5CCC")]
		private IEnumerator SetValue(float value, float duration)
		{
		/* --- GHIDRA: SetValue ---
		void UI_Tweens_TweeningValue__SetValue(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5b8d1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_RewardToBalanceTweener_DurationCfg___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_RewardToBalanceTweener_DurationCfg__TypeInfo);
		    DAT_ram_00a5b8d1 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_RewardToBalanceTweener_DurationCfg__TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,
		             Method_System_Collections_Generic_List_RewardToBalanceTweener_DurationCfg___ctor__);
		  *(undefined8 *)(param1 + 0x18) = 0x1200000015;
		  *(undefined4 *)(param1 + 0x14) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		/* --- GHIDRA: SetValue ---
		void UI_Tweens_TweeningValue__SetValue(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5b8d1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_RewardToBalanceTweener_DurationCfg___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_RewardToBalanceTweener_DurationCfg__TypeInfo);
		    DAT_ram_00a5b8d1 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_RewardToBalanceTweener_DurationCfg__TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,
		             Method_System_Collections_Generic_List_RewardToBalanceTweener_DurationCfg___ctor__);
		  *(undefined8 *)(param1 + 0x18) = 0x1200000015;
		  *(undefined4 *)(param1 + 0x14) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x5CCD", Offset = "0x5CCD", VA = "0x5CCD")]
		private void Display(float value)
		{
		/* --- GHIDRA: Display ---
		void UI_Tweens_TweeningValue__Display(int param1,float param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  undefined4 param2_00;
		  int iVar3;
		  float4 local_4;
		  
		  *(float *)(param1 + 0x30) = param2;
		  if (DAT_ram_00a5b8cf == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_28728);
		    DAT_ram_00a5b8cf = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x10);
		  param2_00 = *(undefined4 *)(param1 + 0x28);
		  local_4 = (float4)param2;
		  uVar1 = func_ii_1081(DAT_ram_00a6696c,&local_4);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28728,param2_00,uVar1,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x5CCE", Offset = "0x5CCE", VA = "0x5CCE")]
		public void SetValueImmediately(float value)
		{
		/* --- GHIDRA: SetValueImmediately ---
		int UI_Tweens_TweeningValue__SetValueImmediately(int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5b8d0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_First_RewardToBalanceTweener_DurationCfg___);
		    Mono_Security_ASN1__get_Item(&System_Func_RewardToBalanceTweener_DurationCfg__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Tweens_TweeningValue___c__DisplayClass18_0__SetValue_b__0__);
		    Mono_Security_ASN1__get_Item(&UI_Tweens_TweeningValue___c__DisplayClass18_0_TypeInfo);
		    DAT_ram_00a5b8d0 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(UI_Tweens_TweeningValue___c__DisplayClass18_0_TypeInfo);
		  *(float *)(iVar1 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x14);
		  uVar2 = unnamed_function_1417(System_Func_RewardToBalanceTweener_DurationCfg__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,iVar1,Method_UI_Tweens_TweeningValue___c__DisplayClass18_0__SetValue_b__0__,0);
		  iVar1 = func_ii_7423(param1_00,uVar2,
		                       Method_System_Linq_Enumerable_First_RewardToBalanceTweener_DurationCfg___);
		  uVar2 = *(undefined4 *)(iVar1 + 0x10);
		  if (DAT_ram_00a5b8ce == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Tweens_TweeningValue__SetValue_d__15_TypeInfo);
		    DAT_ram_00a5b8ce = '\x01';
		  }
		  iVar1 = unnamed_function_1417(UI_Tweens_TweeningValue__SetValue_d__15_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x18) = uVar2;
		  *(float *)(iVar1 + 0x14) = param2;
		  *(int *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000955")]
		[Address(RVA = "0x5CCF", Offset = "0x5CCF", VA = "0x5CCF")]
		public IEnumerator SetValue(float value)
		{
			return null;
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000956")]
		[Address(RVA = "0x5CD0", Offset = "0x5CD0", VA = "0x5CD0")]
		public TweeningValue()
		{
		}

		// Token: 0x04000376 RID: 886
		[Token(Token = "0x4000376")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _textField;

		// Token: 0x04000377 RID: 887
		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private List<RewardToBalanceTweener.DurationCfg> _durations;

		// Token: 0x04000378 RID: 888
		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Ease _easeForAdditionValue;

		// Token: 0x04000379 RID: 889
		[Token(Token = "0x4000379")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Ease _easeForScale;

		// Token: 0x0400037A RID: 890
		[Token(Token = "0x400037A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _scaleDuration;

		// Token: 0x0400037B RID: 891
		[Token(Token = "0x400037B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _scale;

		// Token: 0x0400037C RID: 892
		[Token(Token = "0x400037C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _numberPrefix;

		// Token: 0x0400037D RID: 893
		[Token(Token = "0x400037D")]
		[FieldOffset(Offset = "0x2C")]
		private RectTransform _rectTransform;

		// Token: 0x0400037E RID: 894
		[Token(Token = "0x400037E")]
		[FieldOffset(Offset = "0x30")]
		private float _value;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Value ---
		undefined4 UI_Tweens_TweeningValue__get_Value(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = TMPro_TMP_Text__get_transform(*(undefined4 *)(param1 + 0x10),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_ValueTransform ---
		int * UI_Tweens_TweeningValue__get_ValueTransform(int param1,undefined4 param2)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a5b8cd == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_RectTransform_TypeInfo);
		    DAT_ram_00a5b8cd = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x2c);
		  if (param1_00 == (int *)0x0) {
		    param1_00 = (int *)System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                                 (param1,0);
		    if ((param1_00 != (int *)0x0) && (UnityEngine_RectTransform_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,UnityEngine_RectTransform_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int **)(param1 + 0x2c) = param1_00;
		  }
		  return param1_00;
		}
		*/


		/* --- GHIDRA: get_RectTransform ---
		int UI_Tweens_TweeningValue__get_RectTransform
		              (undefined4 param1,float param2,float param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5b8ce == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Tweens_TweeningValue__SetValue_d__15_TypeInfo);
		    DAT_ram_00a5b8ce = '\x01';
		  }
		  iVar1 = unnamed_function_1417(UI_Tweens_TweeningValue__SetValue_d__15_TypeInfo);
		  *(float *)(iVar1 + 0x18) = param3;
		  *(float *)(iVar1 + 0x14) = param2;
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

}
