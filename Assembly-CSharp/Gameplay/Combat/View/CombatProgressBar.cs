using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UI.Elements.ProgressBars;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Combat.View
{
	// Token: 0x02000919 RID: 2329
	[Token(Token = "0x2000919")]
	public class CombatProgressBar : ProgressBarWithText
	{
		// Token: 0x060036E0 RID: 14048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036E0")]
		[Address(RVA = "0x86CF", Offset = "0x86CF", VA = "0x86CF")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Combat_View_CombatProgressBar__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int param1_01;
		  int param2_00;
		  int param3;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a63b28 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_DOTween_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Tweener__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Tweener__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Tweener__get_Item__);
		    DAT_ram_00a63b28 = '\x01';
		  }
		  param1_01 = *(int *)(param1 + 0x2c);
		  if (0 < *(int *)(param1_01 + 0xc)) {
		    do {
		      param1_00 = System_Linq_Enumerable__ToList_object_
		                            (param1_01,param2_00,
		                             Method_System_Collections_Generic_List_Tweener__get_Item__);
		      if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		        func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		      }
		      DG_Tweening_DOTween__KillAll(param1_00,0,0);
		      param2_00 = param2_00 + 1;
		      param1_01 = *(int *)(param1 + 0x2c);
		      param3 = *(int *)(param1_01 + 0xc);
		    } while (param2_00 < param3);
		    *(undefined4 *)(param1_01 + 0xc) = 0;
		    *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		    if (0 < param3) {
		      func_ii_2064(*(undefined4 *)(param1_01 + 8),0,param3,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036E1")]
		[Address(RVA = "0x86D0", Offset = "0x86D0", VA = "0x86D0")]
		private void StopTween()
		{
		/* --- GHIDRA: StopTween ---
		void Gameplay_Combat_View_CombatProgressBar__StopTween
		               (int param1,float param2,undefined4 param3,float param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  uint uVar3;
		  
		  if (DAT_ram_00a63b29 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Core_DOGetter_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Core_DOSetter_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_DOTween_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Tweener__Add__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_CombatProgressBar___c__DisplayClass6_0__TweenValue_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_CombatProgressBar___c__DisplayClass6_0__TweenValue_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_CombatProgressBar___c__DisplayClass6_0_TypeInfo);
		    DAT_ram_00a63b29 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Combat_View_CombatProgressBar___c__DisplayClass6_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param3;
		  Gameplay_Combat_View_CombatProgressBar__OnDestroy(param1,param1);
		  param1_01 = *(int *)(param1 + 0x2c);
		  uVar2 = unnamed_function_1417(DG_Tweening_Core_DOGetter_float__TypeInfo);
		  DG_Tweening_Core_DOGetter_Rect___Invoke
		            (uVar2,iVar1,
		             Method_Gameplay_Combat_View_CombatProgressBar___c__DisplayClass6_0__TweenValue_b__0__,0
		            );
		  param1_00 = unnamed_function_1417(DG_Tweening_Core_DOSetter_float__TypeInfo);
		  DG_Tweening_Core_DOSetter_Rect___Invoke
		            (param1_00,iVar1,
		             Method_Gameplay_Combat_View_CombatProgressBar___c__DisplayClass6_0__TweenValue_b__1__,0
		            );
		  if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		    func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		  }
		  uVar2 = DG_Tweening_DOTween__ManualUpdate(uVar2,param1_00,param2,param4,0);
		  iVar1 = Method_System_Collections_Generic_List_Tweener__Add__;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_01 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_01 + 8) + uVar3 * 4 + 0x10) = uVar2;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_01,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036E2")]
		[Address(RVA = "0x86D1", Offset = "0x86D1", VA = "0x86D1")]
		private void TweenValue(float toValue, Scrollbar bar, float duration)
		{
		/* --- GHIDRA: TweenValue ---
		void Gameplay_Combat_View_CombatProgressBar__TweenValue(int *param1,float param2,undefined4 param3)
		
		{
		  float fVar1;
		  int *piVar2;
		  
		  fVar1 = (float)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                           (param1,*(undefined4 *)(*param1 + 0x104));
		  if (0.0 < param2 - fVar1) {
		    Gameplay_Combat_View_CombatProgressBar__StopTween
		              (param1,param2,param1[8],(float)param1[10],param1);
		    piVar2 = param1 + 4;
		  }
		  else {
		    Gameplay_Combat_View_CombatProgressBar__StopTween
		              (param1,param2,param1[4],(float)param1[10],param1);
		    piVar2 = param1 + 8;
		  }
		  Gameplay_Combat_View_CombatProgressBar__StopTween(param1,param2,*piVar2,(float)param1[9],param1);
		  return;
		}
		*/

		}

		// Token: 0x17000AD4 RID: 2772
		// (set) Token: 0x060036E3 RID: 14051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AD4")]
		public override float Value
		{
			[Token(Token = "0x60036E3")]
			[Address(RVA = "0x86D2", Offset = "0x86D2", VA = "0x86D2", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036E4")]
		[Address(RVA = "0x86D3", Offset = "0x86D3", VA = "0x86D3")]
		public CombatProgressBar()
		{
		}

		// Token: 0x04001E0F RID: 7695
		[Token(Token = "0x4001E0F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Scrollbar _scrollbarSeccond;

		// Token: 0x04001E10 RID: 7696
		[Token(Token = "0x4001E10")]
		[FieldOffset(Offset = "0x24")]
		private float _slaveDuration;

		// Token: 0x04001E11 RID: 7697
		[Token(Token = "0x4001E11")]
		[FieldOffset(Offset = "0x28")]
		private float _masterDuration;

		// Token: 0x04001E12 RID: 7698
		[Token(Token = "0x4001E12")]
		[FieldOffset(Offset = "0x2C")]
		private List<Tweener> _currentTweens;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Value ---
		void Gameplay_Combat_View_CombatProgressBar__set_Value(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63b2a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Tweener___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Tweener__TypeInfo);
		    DAT_ram_00a63b2a = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x24) = 0x3f000000;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_Tweener__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (param1_00,2,Method_System_Collections_Generic_List_Tweener___ctor__);
		  *(undefined4 *)(param1 + 0x2c) = param1_00;
		  UnityEngine_ParticleSystemRenderer__GetMeshes(param1,0);
		  return;
		}
		*/

}
