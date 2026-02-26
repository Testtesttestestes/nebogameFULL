using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Elements.ProgressBars
{
	// Token: 0x02000221 RID: 545
	[Token(Token = "0x2000221")]
	[ExecuteInEditMode]
	public class ProgressBarWithTimer : ProgressBarWithText
	{
		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D88 RID: 3464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C8")]
		public override string Text
		{
			[Token(Token = "0x6000D87")]
			[Address(RVA = "0x606A", Offset = "0x606A", VA = "0x606A", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D88")]
			[Address(RVA = "0x606B", Offset = "0x606B", VA = "0x606B", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000D89 RID: 3465 RVA: 0x000040C8 File Offset: 0x000022C8
		// (set) Token: 0x06000D8A RID: 3466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C9")]
		public override float Value
		{
			[Token(Token = "0x6000D89")]
			[Address(RVA = "0x606C", Offset = "0x606C", VA = "0x606C", Slot = "8")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D8A")]
			[Address(RVA = "0x606D", Offset = "0x606D", VA = "0x606D", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D8B")]
		[Address(RVA = "0x606E", Offset = "0x606E", VA = "0x606E")]
		private IEnumerator TimerRoutine(ulong durationMs, DateTime endTime)
		{
		/* --- GHIDRA: <>n__0 ---
		void UI_Elements_ProgressBars_ProgressBarWithTimer____n__0
		               (int param1,float param2,undefined4 param3)
		
		{
		  UnityEngine_UI_Scrollbar__get_value(*(undefined4 *)(param1 + 0x10),param2,0);
		  return;
		}
		*/

		/* --- GHIDRA: TimerRoutine ---
		void UI_Elements_ProgressBars_ProgressBarWithTimer__TimerRoutine
		               (int param1,longlong param2,undefined8 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (*(int *)(param1 + 0x20) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x20),0);
		  }
		  if (param2 == 0) {
		    if (DAT_ram_00a6397e == '\0') {
		      Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		      DAT_ram_00a6397e = '\x01';
		    }
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    uVar3 = 0;
		    uVar1 = Utils_TimeUtils__DateFormat(0.0,0);
		    iVar2 = **(int **)(param1 + 0x1c);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		              (CONCAT44(uVar3,*(int **)(param1 + 0x1c)),uVar1,*(undefined4 *)(iVar2 + 0x2d4));
		    UnityEngine_UI_Scrollbar__get_value(*(undefined4 *)(param1 + 0x10),1.0,0);
		    return;
		  }
		  if (DAT_ram_00a6397d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_ProgressBars_ProgressBarWithTimer__TimerRoutine_d__7_TypeInfo);
		    DAT_ram_00a6397d = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (UI_Elements_ProgressBars_ProgressBarWithTimer__TimerRoutine_d__7_TypeInfo);
		  *(longlong *)(iVar2 + 0x20) = param2;
		  *(int *)(iVar2 + 0x18) = param1;
		  *(undefined4 *)(iVar2 + 8) = 0;
		  *(undefined8 *)(iVar2 + 0x10) = param3;
		  uVar3 = Utils_CoroutineSource__GetMono(iVar2,0);
		  *(undefined4 *)(param1 + 0x20) = uVar3;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8C")]
		[Address(RVA = "0x606F", Offset = "0x606F", VA = "0x606F")]
		public void Init(ulong durationMs, DateTime endTime)
		{
		/* --- GHIDRA: Init ---
		void UI_Elements_ProgressBars_ProgressBarWithTimer__Init(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a6397e == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a6397e = '\x01';
		  }
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  uVar1 = 0;
		  uVar2 = Utils_TimeUtils__DateFormat(0.0,0);
		  iVar3 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (CONCAT44(uVar1,*(int **)(param1 + 0x1c)),uVar2,*(undefined4 *)(iVar3 + 0x2d4));
		  UnityEngine_UI_Scrollbar__get_value(*(undefined4 *)(param1 + 0x10),1.0,0);
		  return;
		}
		*/

		/* --- GHIDRA: Init ---
		void UI_Elements_ProgressBars_ProgressBarWithTimer__Init(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a6397e == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a6397e = '\x01';
		  }
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  uVar1 = 0;
		  uVar2 = Utils_TimeUtils__DateFormat(0.0,0);
		  iVar3 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (CONCAT44(uVar1,*(int **)(param1 + 0x1c)),uVar2,*(undefined4 *)(iVar3 + 0x2d4));
		  UnityEngine_UI_Scrollbar__get_value(*(undefined4 *)(param1 + 0x10),1.0,0);
		  return;
		}
		*/

		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8D")]
		[Address(RVA = "0x6070", Offset = "0x6070", VA = "0x6070")]
		private void TimerComplete()
		{
		/* --- GHIDRA: TimerComplete ---
		void UI_Elements_ProgressBars_ProgressBarWithTimer__TimerComplete
		               (undefined4 param1,undefined8 param2,ulonglong param3,undefined4 param4)
		
		{
		  undefined8 uVar1;
		  undefined8 param1_00;
		  
		  if (DAT_ram_00a6397f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    DAT_ram_00a6397f = '\x01';
		  }
		  if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_TimeSpan_TypeInfo);
		  }
		  uVar1 = System_Threading_CancellationTokenSource___ctor((double)param3,0);
		  if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTime_TypeInfo);
		  }
		  param1_00 = ICSharpCode_SharpZipLib_Zip_ZipEntry___ctor(0);
		  uVar1 = System_Convert__ToDouble(param1_00,uVar1,0);
		  UI_Elements_ProgressBars_ProgressBarWithTimer__TimerRoutine(param1,param2,uVar1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8E")]
		[Address(RVA = "0x6071", Offset = "0x6071", VA = "0x6071")]
		public void Init(ulong durationMs, ulong backtimer)
		{
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8F")]
		[Address(RVA = "0x6072", Offset = "0x6072", VA = "0x6072")]
		public ProgressBarWithTimer()
		{
		}

		// Token: 0x040006B9 RID: 1721
		[Token(Token = "0x40006B9")]
		[FieldOffset(Offset = "0x20")]
		private Coroutine _timerRoutine;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Text ---
		float UI_Elements_ProgressBars_ProgressBarWithTimer__set_Text(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  
		  fVar1 = UnityEngine_UI_Scrollbar___ctor(*(undefined4 *)(param1 + 0x10),0);
		  return fVar1;
		}
		*/


		/* --- GHIDRA: set_Value ---
		int UI_Elements_ProgressBars_ProgressBarWithTimer__set_Value
		              (undefined4 param1,undefined8 param2,undefined8 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a6397d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_ProgressBars_ProgressBarWithTimer__TimerRoutine_d__7_TypeInfo);
		    DAT_ram_00a6397d = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (UI_Elements_ProgressBars_ProgressBarWithTimer__TimerRoutine_d__7_TypeInfo);
		  *(undefined8 *)(iVar1 + 0x20) = param2;
		  *(undefined4 *)(iVar1 + 0x18) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined8 *)(iVar1 + 0x10) = param3;
		  return iVar1;
		}
		*/

}
