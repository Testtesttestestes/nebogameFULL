using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Elements.Sliders
{
	// Token: 0x020001F8 RID: 504
	[Token(Token = "0x20001F8")]
	public class SliderWithButtons : MonoBehaviour
	{
		// Token: 0x140000EA RID: 234
		// (add) Token: 0x06000CF1 RID: 3313 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000CF2 RID: 3314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000EA")]
		public event Action<int> OnValueChangedEvent
		{
			[Token(Token = "0x6000CF1")]
			[Address(RVA = "0x5FE8", Offset = "0x5FE8", VA = "0x5FE8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000CF2")]
			[Address(RVA = "0x5FE9", Offset = "0x5FE9", VA = "0x5FE9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x00003FA8 File Offset: 0x000021A8
		// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B1")]
		public int MinValue
		{
			[Token(Token = "0x6000CF3")]
			[Address(RVA = "0x5FEA", Offset = "0x5FEA", VA = "0x5FEA")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000CF4")]
			[Address(RVA = "0x5FEB", Offset = "0x5FEB", VA = "0x5FEB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x00003FC0 File Offset: 0x000021C0
		// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B2")]
		public int MaxValue
		{
			[Token(Token = "0x6000CF5")]
			[Address(RVA = "0x5FEC", Offset = "0x5FEC", VA = "0x5FEC")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000CF6")]
			[Address(RVA = "0x5FED", Offset = "0x5FED", VA = "0x5FED")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x00003FD8 File Offset: 0x000021D8
		// (set) Token: 0x06000CF8 RID: 3320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B3")]
		public int Value
		{
			[Token(Token = "0x6000CF7")]
			[Address(RVA = "0x5FEE", Offset = "0x5FEE", VA = "0x5FEE")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000CF8")]
			[Address(RVA = "0x5FEF", Offset = "0x5FEF", VA = "0x5FEF")]
			set
			{
			}
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF9")]
		[Address(RVA = "0x5FF0", Offset = "0x5FF0", VA = "0x5FF0")]
		public void SetLimitValues(int minValue, int maxValue)
		{
		/* --- GHIDRA: SetLimitValues ---
		void UI_Elements_Sliders_SliderWithButtons__SetLimitValues(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a63958 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_Sliders_SliderWithButtons_DecrementButtonClickEventHandler__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Elements_Sliders_SliderWithButtons_HandleValueChanged__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_Sliders_SliderWithButtons_IncrementButtonClickEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_float__RemoveListener__);
		    DAT_ram_00a63958 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xd0);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_float__TypeInfo);
		  UnityEngine_Events_UnityAction_Scene___Invoke
		            (uVar1,param1,Method_UI_Elements_Sliders_SliderWithButtons_HandleValueChanged__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_float__RemoveListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_UI_Elements_Sliders_SliderWithButtons_DecrementButtonClickEventHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_UI_Elements_Sliders_SliderWithButtons_IncrementButtonClickEventHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  return;
		}
		*/

		/* --- GHIDRA: SetLimitValues ---
		void UI_Elements_Sliders_SliderWithButtons__SetLimitValues(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a63958 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_Sliders_SliderWithButtons_DecrementButtonClickEventHandler__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Elements_Sliders_SliderWithButtons_HandleValueChanged__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_Sliders_SliderWithButtons_IncrementButtonClickEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_float__RemoveListener__);
		    DAT_ram_00a63958 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xd0);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_float__TypeInfo);
		  UnityEngine_Events_UnityAction_Scene___Invoke
		            (uVar1,param1,Method_UI_Elements_Sliders_SliderWithButtons_HandleValueChanged__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_float__RemoveListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_UI_Elements_Sliders_SliderWithButtons_DecrementButtonClickEventHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_UI_Elements_Sliders_SliderWithButtons_IncrementButtonClickEventHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFA")]
		[Address(RVA = "0x5FF1", Offset = "0x5FF1", VA = "0x5FF1")]
		public void SetLimitValues(int minValue, int maxValue, int value)
		{
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFB")]
		[Address(RVA = "0x5FF2", Offset = "0x5FF2", VA = "0x5FF2")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_Elements_Sliders_SliderWithButtons__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a63959 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_Sliders_SliderWithButtons_DecrementButtonClickEventHandler__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Elements_Sliders_SliderWithButtons_HandleValueChanged__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_Sliders_SliderWithButtons_IncrementButtonClickEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_float__AddListener__);
		    DAT_ram_00a63959 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xd0);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_float__TypeInfo);
		  UnityEngine_Events_UnityAction_Scene___Invoke
		            (uVar1,param1,Method_UI_Elements_Sliders_SliderWithButtons_HandleValueChanged__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_float__AddListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_UI_Elements_Sliders_SliderWithButtons_DecrementButtonClickEventHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_UI_Elements_Sliders_SliderWithButtons_IncrementButtonClickEventHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFC")]
		[Address(RVA = "0x5FF3", Offset = "0x5FF3", VA = "0x5FF3")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void UI_Elements_Sliders_SliderWithButtons__Start(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  int *piVar2;
		  
		  piVar2 = *(int **)(param1 + 0x10);
		  fVar1 = (float)(**(code **)((ulonglong)*(uint *)(*piVar2 + 0x230) * 4))
		                           (piVar2,*(undefined4 *)(*piVar2 + 0x234));
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x238) * 4))
		            (piVar2,fVar1 + 1.0,*(undefined4 *)(*piVar2 + 0x23c));
		  return;
		}
		*/

		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFD")]
		[Address(RVA = "0x5FF4", Offset = "0x5FF4", VA = "0x5FF4")]
		private void IncrementButtonClickEventHandler()
		{
		/* --- GHIDRA: IncrementButtonClickEventHandler ---
		void UI_Elements_Sliders_SliderWithButtons__IncrementButtonClickEventHandler
		               (int param1,undefined4 param2)
		
		{
		  float fVar1;
		  int *piVar2;
		  
		  piVar2 = *(int **)(param1 + 0x10);
		  fVar1 = (float)(**(code **)((ulonglong)*(uint *)(*piVar2 + 0x230) * 4))
		                           (piVar2,*(undefined4 *)(*piVar2 + 0x234));
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x238) * 4))
		            (piVar2,fVar1 + -1.0,*(undefined4 *)(*piVar2 + 0x23c));
		  return;
		}
		*/

		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFE")]
		[Address(RVA = "0x5FF5", Offset = "0x5FF5", VA = "0x5FF5")]
		private void DecrementButtonClickEventHandler()
		{
		/* --- GHIDRA: DecrementButtonClickEventHandler ---
		void UI_Elements_Sliders_SliderWithButtons__DecrementButtonClickEventHandler
		               (int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = *(int *)(param1 + 0x1c);
		  if (iVar1 != 0) {
		    if (ABS(param2) < 2.1474836e+09) {
		      iVar2 = (int)param2;
		    }
		    else {
		      iVar2 = -0x80000000;
		    }
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),iVar2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFF")]
		[Address(RVA = "0x5FF6", Offset = "0x5FF6", VA = "0x5FF6")]
		private void HandleValueChanged(float newValue)
		{
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D00")]
		[Address(RVA = "0x5FF7", Offset = "0x5FF7", VA = "0x5FF7")]
		public SliderWithButtons()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Elements_Sliders_SliderWithButtons___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6395a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    DAT_ram_00a6395a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_int__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_int__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04000664 RID: 1636
		[Token(Token = "0x4000664")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Slider _slider;

		// Token: 0x04000665 RID: 1637
		[Token(Token = "0x4000665")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _decrementButton;

		// Token: 0x04000666 RID: 1638
		[Token(Token = "0x4000666")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _incrementButton;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_OnValueChangedEvent ---
		void UI_Elements_Sliders_SliderWithButtons__add_OnValueChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63957 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    DAT_ram_00a63957 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_int__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_int__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_MaxValue ---
		undefined4 UI_Elements_Sliders_SliderWithButtons__set_MaxValue(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  int iVar2;
		  
		  iVar2 = **(int **)(param1 + 0x10);
		  fVar1 = (float)(**(code **)((ulonglong)*(uint *)(iVar2 + 0x230) * 4))
		                           (*(int **)(param1 + 0x10),*(undefined4 *)(iVar2 + 0x234));
		  if (2.1474836e+09 <= ABS(fVar1)) {
		    return 0x80000000;
		  }
		  return (int)fVar1;
		}
		*/


		/* --- GHIDRA: get_Value ---
		void UI_Elements_Sliders_SliderWithButtons__get_Value(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x238) * 4))
		            (*(int **)(param1 + 0x10),(float)param2,*(undefined4 *)(iVar1 + 0x23c));
		  return;
		}
		*/


		/* --- GHIDRA: set_Value ---
		void UI_Elements_Sliders_SliderWithButtons__set_Value
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int local_8;
		  int local_4;
		  
		  if (param2 <= param3) {
		    *(int *)(param1 + 0x24) = param3;
		    *(int *)(param1 + 0x20) = param2;
		    UnityEngine_UI_Slider__get_minValue(*(undefined4 *)(param1 + 0x10),(float)param2,0);
		    UnityEngine_UI_Slider__get_maxValue(*(undefined4 *)(param1 + 0x10),(float)param3,0);
		    return;
		  }
		  local_4 = param2;
		  uVar1 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  local_8 = param3;
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_8);
		  param1_00 = unnamed_function_2232(&StringLiteral_11122);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey(param1_00,uVar1,uVar2,0);
		  uVar2 = unnamed_function_2232(&System_ArgumentException_TypeInfo);
		  uVar2 = unnamed_function_1417(uVar2);
		  func_ii_3067(uVar2,uVar1,0);
		  uVar1 = unnamed_function_2232(&Method_UI_Elements_Sliders_SliderWithButtons_SetLimitValues__);
		  func_ii_1050(uVar2,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
