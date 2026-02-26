using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly.Movement
{
	// Token: 0x02001325 RID: 4901
	[Token(Token = "0x2001325")]
	public class ToNextVisibleIsleWorldMovement : AbstractWorldMovement
	{
		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x06007442 RID: 29762 RVA: 0x00014EC8 File Offset: 0x000130C8
		[Token(Token = "0x1700176E")]
		public override WorldMovementTypes Type
		{
			[Token(Token = "0x6007442")]
			[Address(RVA = "0xBE10", Offset = "0xBE10", VA = "0xBE10", Slot = "5")]
			get
			{
				return (WorldMovementTypes)0;
			}
		}

		// Token: 0x06007443 RID: 29763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007443")]
		[Address(RVA = "0xBE11", Offset = "0xBE11", VA = "0xBE11", Slot = "6")]
		public override void Move(Vector3 target, Camera camera, Action callback)
		{
		/* --- GHIDRA: Move ---
		void CloudsFly_Movement_ToNextVisibleIsleWorldMovement__Move(int *param1,undefined4 param2)
		
		{
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))(param1,*(undefined4 *)(*param1 + 0xfc));
		  param1[3] = 0;
		  return;
		}
		*/

		}

		// Token: 0x06007444 RID: 29764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007444")]
		[Address(RVA = "0xBE12", Offset = "0xBE12", VA = "0xBE12", Slot = "8")]
		public override void Dispose()
		{
		}

		// Token: 0x06007445 RID: 29765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007445")]
		[Address(RVA = "0xBE13", Offset = "0xBE13", VA = "0xBE13")]
		public ToNextVisibleIsleWorldMovement()
		{
		}

		// Token: 0x04003CDA RID: 15578
		[Token(Token = "0x4003CDA")]
		[FieldOffset(Offset = "0xC")]
		private Camera _camera;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Type ---
		void CloudsFly_Movement_ToNextVisibleIsleWorldMovement__get_Type
		               (int param1,float *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int iVar3;
		  uint uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a596a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_CloudsFly_Movement_ToNextVisibleIsleWorldMovement___c__DisplayClass3_0__Move_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&CloudsFly_Movement_ToNextVisibleIsleWorldMovement___c__DisplayClass3_0_TypeInfo);
		    DAT_ram_00a596a7 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (CloudsFly_Movement_ToNextVisibleIsleWorldMovement___c__DisplayClass3_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 8) = param4;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param3,0);
		  uVar2 = DG_Tweening_ShortcutExtensions__DOMove(uVar2,*param2,1.0,0,0);
		  uVar2 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar2,0xc,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  if (DAT_ram_00a5969b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Tween__Add__);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetAutoKill_Tween___);
		    DAT_ram_00a5969b = '\x01';
		  }
		  DG_Tweening_TweenSettingsExtensions__SetAutoKill_object_
		            (uVar2,0,Method_DG_Tweening_TweenSettingsExtensions_SetAutoKill_Tween___);
		  iVar5 = Method_System_Collections_Generic_List_Tween__Add__;
		  iVar3 = *(int *)(param1 + 8);
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0xc),0);
		  uVar2 = DG_Tweening_ShortcutExtensions__DOMoveX(uVar2,param2[1],0.6666667,0,0);
		  uVar2 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar2,5,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  uVar2 = DG_Tweening_DOTweenModuleUI__DOFade
		                    (uVar2,0.33333334,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  if (DAT_ram_00a5969b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Tween__Add__);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetAutoKill_Tween___);
		    DAT_ram_00a5969b = '\x01';
		  }
		  DG_Tweening_TweenSettingsExtensions__SetAutoKill_object_
		            (uVar2,0,Method_DG_Tweening_TweenSettingsExtensions_SetAutoKill_Tween___);
		  iVar5 = Method_System_Collections_Generic_List_Tween__Add__;
		  iVar3 = *(int *)(param1 + 8);
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0xc),0);
		  uVar2 = DG_Tweening_ShortcutExtensions__DOMoveY(uVar2,param2[2],1.0,0,0);
		  uVar2 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar2,6,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  param1_00 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (param1_00,iVar1,
		             Method_CloudsFly_Movement_ToNextVisibleIsleWorldMovement___c__DisplayClass3_0__Move_b__0__
		             ,0);
		  uVar2 = DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		                    (uVar2,param1_00,
		                     Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  if (DAT_ram_00a5969b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Tween__Add__);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetAutoKill_Tween___);
		    DAT_ram_00a5969b = '\x01';
		  }
		  DG_Tweening_TweenSettingsExtensions__SetAutoKill_object_
		            (uVar2,0,Method_DG_Tweening_TweenSettingsExtensions_SetAutoKill_Tween___);
		  iVar1 = Method_System_Collections_Generic_List_Tween__Add__;
		  iVar5 = *(int *)(param1 + 8);
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar5 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		    *(uint *)(iVar5 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(iVar5 + 8) + uVar4 * 4 + 0x10) = uVar2;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (iVar5,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

}
