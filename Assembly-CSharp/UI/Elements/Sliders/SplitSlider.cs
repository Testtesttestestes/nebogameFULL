using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Elements.Sliders
{
	// Token: 0x020001F9 RID: 505
	[Token(Token = "0x20001F9")]
	public class SplitSlider : MonoBehaviour
	{
		// Token: 0x140000EB RID: 235
		// (add) Token: 0x06000D01 RID: 3329 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000D02 RID: 3330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000EB")]
		public event Action<int> OnValueChangedEvent
		{
			[Token(Token = "0x6000D01")]
			[Address(RVA = "0x5FF8", Offset = "0x5FF8", VA = "0x5FF8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000D02")]
			[Address(RVA = "0x5FF9", Offset = "0x5FF9", VA = "0x5FF9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000D03 RID: 3331 RVA: 0x00003FF0 File Offset: 0x000021F0
		// (set) Token: 0x06000D04 RID: 3332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B4")]
		public int MinRemainCount
		{
			[Token(Token = "0x6000D03")]
			[Address(RVA = "0x5FFA", Offset = "0x5FFA", VA = "0x5FFA")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000D04")]
			[Address(RVA = "0x5FFB", Offset = "0x5FFB", VA = "0x5FFB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x00004008 File Offset: 0x00002208
		// (set) Token: 0x06000D06 RID: 3334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B5")]
		public int TotalCount
		{
			[Token(Token = "0x6000D05")]
			[Address(RVA = "0x5FFC", Offset = "0x5FFC", VA = "0x5FFC")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000D06")]
			[Address(RVA = "0x5FFD", Offset = "0x5FFD", VA = "0x5FFD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D07")]
		[Address(RVA = "0x5FFE", Offset = "0x5FFE", VA = "0x5FFE")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_Elements_Sliders_SplitSlider__OnDestroy(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_01;
		  float fVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  int local_8;
		  int local_4;
		  
		  if (DAT_ram_00a6395d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_Sliders_SplitSlider_HandleSliderValueChangedEventEvent__);
		    DAT_ram_00a6395d = '\x01';
		  }
		  iVar5 = *(int *)(param1 + 0x10);
		  uVar3 = unnamed_function_1417(System_Action_int__TypeInfo);
		  System_Action_short___Invoke
		            (uVar3,param1,
		             Method_UI_Elements_Sliders_SplitSlider_HandleSliderValueChangedEventEvent__,0);
		  if (DAT_ram_00a63956 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    DAT_ram_00a63956 = '\x01';
		  }
		  param1_00 = *(int *)(iVar5 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,uVar3,0);
		    uVar6 = System_Action_int__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_int__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar5 + 0x1c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      piVar7 = *(int **)(*(int *)(param1 + 0x10) + 0x10);
		      iVar5 = *piVar7;
		      fVar4 = (float)(**(code **)((ulonglong)*(uint *)(iVar5 + 0x230) * 4))
		                               (piVar7,*(undefined4 *)(iVar5 + 0x234));
		      if (ABS(fVar4) < 2.1474836e+09) {
		        local_4 = (int)fVar4;
		      }
		      else {
		        local_4 = -0x80000000;
		      }
		      uVar6 = *(undefined4 *)(param1 + 0x14);
		      uVar3 = func_ii_4443(&local_4,0);
		      UnityEngine_Component__GetComponentInChildren_object_(uVar6,uVar3,0);
		      uVar6 = *(undefined4 *)(param1 + 0x18);
		      local_8 = *(int *)(param1 + 0x24) - local_4;
		      uVar3 = func_ii_4443(&local_8,0);
		      UnityEngine_Component__GetComponentInChildren_object_(uVar6,uVar3,0);
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,uVar6);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D08")]
		[Address(RVA = "0x5FFF", Offset = "0x5FFF", VA = "0x5FFF")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void UI_Elements_Sliders_SplitSlider__Start(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int local_8;
		  int local_4;
		  
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  local_4 = param2;
		  uVar1 = func_ii_4443(&local_4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  local_8 = *(int *)(param1 + 0x24) - local_4;
		  uVar1 = func_ii_4443(&local_8,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  iVar3 = *(int *)(param1 + 0x1c);
		  if (iVar3 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),param2,*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D09")]
		[Address(RVA = "0x6000", Offset = "0x6000", VA = "0x6000")]
		private void HandleSliderValueChangedEventEvent(int value)
		{
		/* --- GHIDRA: HandleSliderValueChangedEventEvent ---
		void UI_Elements_Sliders_SplitSlider__HandleSliderValueChangedEventEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int local_8;
		  int local_4;
		  
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  local_4 = param2;
		  uVar1 = func_ii_4443(&local_4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  local_8 = *(int *)(param1 + 0x24) - local_4;
		  uVar1 = func_ii_4443(&local_8,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0A")]
		[Address(RVA = "0x6001", Offset = "0x6001", VA = "0x6001")]
		private void DisplayValue(int value)
		{
		/* --- GHIDRA: DisplayValue ---
		void UI_Elements_Sliders_SplitSlider__DisplayValue
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int *piVar2;
		  
		  *(int *)(param1 + 0x24) = param3;
		  *(int *)(param1 + 0x20) = param2;
		  iVar1 = *(int *)(param1 + 0x10);
		  UI_Elements_Sliders_SliderWithButtons__set_Value(iVar1,param2,param3 - param2,param3);
		  piVar2 = *(int **)(iVar1 + 0x10);
		  iVar1 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x238) * 4))
		            (piVar2,(float)(param3 / 2),*(undefined4 *)(iVar1 + 0x23c));
		  return;
		}
		*/

		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0B")]
		[Address(RVA = "0x6002", Offset = "0x6002", VA = "0x6002")]
		public void SetValues(int minRemainCount, int totalCount)
		{
		/* --- GHIDRA: SetValues ---
		undefined4 UI_Elements_Sliders_SplitSlider__SetValues(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  int *piVar2;
		  int iVar3;
		  
		  piVar2 = *(int **)(*(int *)(param1 + 0x10) + 0x10);
		  iVar3 = *piVar2;
		  fVar1 = (float)(**(code **)((ulonglong)*(uint *)(iVar3 + 0x230) * 4))
		                           (piVar2,*(undefined4 *)(iVar3 + 0x234));
		  if (2.1474836e+09 <= ABS(fVar1)) {
		    return 0x80000000;
		  }
		  return (int)fVar1;
		}
		*/

		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00004020 File Offset: 0x00002220
		[Token(Token = "0x6000D0C")]
		[Address(RVA = "0x6003", Offset = "0x6003", VA = "0x6003")]
		public int GetValue()
		{
		/* --- GHIDRA: GetValue ---
		void UI_Elements_Sliders_SplitSlider__GetValue(int param1,int param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  piVar1 = *(int **)(*(int *)(param1 + 0x10) + 0x10);
		  iVar2 = *piVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x238) * 4))
		            (piVar1,(float)param2,*(undefined4 *)(iVar2 + 0x23c));
		  return;
		}
		*/

			return 0;
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0D")]
		[Address(RVA = "0x6004", Offset = "0x6004", VA = "0x6004")]
		public void SetValue(int value)
		{
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0E")]
		[Address(RVA = "0x6005", Offset = "0x6005", VA = "0x6005")]
		public SplitSlider()
		{
		}

		// Token: 0x0400066A RID: 1642
		[Token(Token = "0x400066A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SliderWithButtons _slider;

		// Token: 0x0400066B RID: 1643
		[Token(Token = "0x400066B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _leftTextfield;

		// Token: 0x0400066C RID: 1644
		[Token(Token = "0x400066C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _rightTextfield;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_OnValueChangedEvent ---
		void UI_Elements_Sliders_SplitSlider__add_OnValueChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6395b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    DAT_ram_00a6395b = '\x01';
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


		/* --- GHIDRA: set_TotalCount ---
		void UI_Elements_Sliders_SplitSlider__set_TotalCount(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a6395c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_Sliders_SplitSlider_HandleSliderValueChangedEventEvent__);
		    DAT_ram_00a6395c = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x10);
		  param1_01 = unnamed_function_1417(System_Action_int__TypeInfo);
		  System_Action_short___Invoke
		            (param1_01,param1,
		             Method_UI_Elements_Sliders_SplitSlider_HandleSliderValueChangedEventEvent__,0);
		  if (DAT_ram_00a63957 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    DAT_ram_00a63957 = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = func_ii_7048(param1_00,param1_01,0);
		    param2_00 = System_Action_int__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_Action_int__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar3 + 0x1c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
