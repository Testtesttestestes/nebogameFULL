using System;
using Il2CppDummyDll;
using UI.Elements.ProgressBars;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Preloader
{
	// Token: 0x020001CF RID: 463
	[Token(Token = "0x20001CF")]
	public class PreloaderProgressBar : ProgressBarWithText
	{
		// Token: 0x06000C25 RID: 3109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C25")]
		[Address(RVA = "0x5F34", Offset = "0x5F34", VA = "0x5F34", Slot = "4")]
		protected override void OnValidateSafety()
		{
		/* --- GHIDRA: OnValidateSafety ---
		void UI_Preloader_PreloaderProgressBar__OnValidateSafety(int *param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63901 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    DAT_ram_00a63901 = '\x01';
		  }
		  if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Application_TypeInfo);
		  }
		  iVar1 = func_ii_3441(0);
		  if (iVar1 == 0) {
		    UnityEngine_UI_Scrollbar__get_value(param1[4],param2,0);
		    UnityEngine_UI_Scrollbar__get_value(param1[4],param2,0);
		    return;
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,*(undefined4 *)(*param1 + 0x104));
		  UI_Preloader_PreloaderProgressBar__UpdateSize(param1,param2,param1[4],(float)param1[0xb],param1);
		  return;
		}
		*/

		}

		// Token: 0x17000194 RID: 404
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000194")]
		public override float Value
		{
			[Token(Token = "0x6000C26")]
			[Address(RVA = "0x5F35", Offset = "0x5F35", VA = "0x5F35", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C27")]
		[Address(RVA = "0x5F36", Offset = "0x5F36", VA = "0x5F36")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_Preloader_PreloaderProgressBar__Awake(int param1,undefined4 param2)
		
		{
		  UnityEngine_UI_Scrollbar__get_size
		            (*(undefined4 *)(param1 + 0x10),1.0 - *(float *)(param1 + 0x24),0);
		  *(undefined4 *)(*(int *)(param1 + 0x14) + 0x18) = *(undefined4 *)(param1 + 0x28);
		  return;
		}
		*/

		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C28")]
		[Address(RVA = "0x5F37", Offset = "0x5F37", VA = "0x5F37")]
		private void UpdateSize()
		{
		/* --- GHIDRA: UpdateSize ---
		void UI_Preloader_PreloaderProgressBar__UpdateSize
		               (int param1,float param2,undefined4 param3,float param4,undefined4 param5)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int *param2_01;
		  
		  if (DAT_ram_00a63902 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Core_DOGetter_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Core_DOSetter_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_DOTween_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnUpdate_TweenerCore_float__float__FloatOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_float__float__FloatOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_float__float__FloatOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Preloader_PreloaderProgressBar___c__DisplayClass9_0__TweenValue_b__0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Preloader_PreloaderProgressBar___c__DisplayClass9_0__TweenValue_b__1__);
		    Mono_Security_ASN1__get_Item(&UI_Preloader_PreloaderProgressBar___c__DisplayClass9_0_TypeInfo);
		    DAT_ram_00a63902 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(UI_Preloader_PreloaderProgressBar___c__DisplayClass9_0_TypeInfo)
		  ;
		  *(undefined4 *)(param2_00 + 8) = param3;
		  uVar1 = unnamed_function_1417(DG_Tweening_Core_DOGetter_float__TypeInfo);
		  DG_Tweening_Core_DOGetter_Rect___Invoke
		            (uVar1,param2_00,
		             Method_UI_Preloader_PreloaderProgressBar___c__DisplayClass9_0__TweenValue_b__0__,0);
		  uVar2 = unnamed_function_1417(DG_Tweening_Core_DOSetter_float__TypeInfo);
		  DG_Tweening_Core_DOSetter_Rect___Invoke
		            (uVar2,param2_00,
		             Method_UI_Preloader_PreloaderProgressBar___c__DisplayClass9_0__TweenValue_b__1__,0);
		  if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		    func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		  }
		  uVar1 = DG_Tweening_DOTween__ManualUpdate(uVar1,uVar2,param2,param4,0);
		  param2_01 = *(int **)(param1 + 0x14);
		  uVar2 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  if (param2_01 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DG_Tweening_Color2__op_Multiply(uVar2,param2_01,*(undefined4 *)(*param2_01 + 0xe4),0);
		  uVar1 = DG_Tweening_TweenSettingsExtensions__OnStepComplete_object_
		                    (uVar1,uVar2,
		                     Method_DG_Tweening_TweenSettingsExtensions_OnUpdate_TweenerCore_float__float__FloatOptions____
		                    );
		  uVar1 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar1,1,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_float__float__FloatOptions____
		                    );
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		            (uVar1,uVar2,
		             Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_float__float__FloatOptions____
		            );
		  return;
		}
		*/

		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x5F38", Offset = "0x5F38", VA = "0x5F38")]
		private void TweenValue(float toValue, Scrollbar bar, float duration)
		{
		/* --- GHIDRA: TweenValue ---
		void UI_Preloader_PreloaderProgressBar__TweenValue(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x2c) = 0x3f000000;
		  *(undefined8 *)(param1 + 0x20) = 0x3f8000003f800000;
		  ScreenAdaptation_Common_AppSize__Update(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C2A")]
		[Address(RVA = "0x5F39", Offset = "0x5F39", VA = "0x5F39")]
		public PreloaderProgressBar()
		{
		}

		// Token: 0x040005CF RID: 1487
		[Token(Token = "0x40005CF")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _value;

		// Token: 0x040005D0 RID: 1488
		[Token(Token = "0x40005D0")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _fillWidth;

		// Token: 0x040005D1 RID: 1489
		[Token(Token = "0x40005D1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _fillOffset;

		// Token: 0x040005D2 RID: 1490
		[Token(Token = "0x40005D2")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _duration;
	}
}
