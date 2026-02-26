using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly.Movement
{
	// Token: 0x0200131F RID: 4895
	[Token(Token = "0x200131F")]
	public class ToIsleAfterLevelChanges : AbstractWorldMovement
	{
		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x06007430 RID: 29744 RVA: 0x00014E68 File Offset: 0x00013068
		[Token(Token = "0x1700176A")]
		public override WorldMovementTypes Type
		{
			[Token(Token = "0x6007430")]
			[Address(RVA = "0xBDFE", Offset = "0xBDFE", VA = "0xBDFE", Slot = "5")]
			get
			{
				return (WorldMovementTypes)0;
			}
		}

		// Token: 0x06007431 RID: 29745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007431")]
		[Address(RVA = "0xBDFF", Offset = "0xBDFF", VA = "0xBDFF", Slot = "6")]
		public override void Move(Vector3 target, Camera camera, Action callback)
		{
		}

		// Token: 0x06007432 RID: 29746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007432")]
		[Address(RVA = "0xBE00", Offset = "0xBE00", VA = "0xBE00", Slot = "8")]
		public override void Dispose()
		{
		}

		// Token: 0x06007433 RID: 29747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007433")]
		[Address(RVA = "0xBE01", Offset = "0xBE01", VA = "0xBE01")]
		public ToIsleAfterLevelChanges()
		{
		}

		// Token: 0x04003CD6 RID: 15574
		[Token(Token = "0x4003CD6")]
		[FieldOffset(Offset = "0xC")]
		private Camera _camera;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Type ---
		void CloudsFly_Movement_ToIsleAfterLevelChanges__get_Type
		               (int param1,undefined8 *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  uint uVar3;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a596a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_CloudsFly_Movement_ToIsleAfterLevelChanges___c__DisplayClass3_0__Move_b__0__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&CloudsFly_Movement_ToIsleAfterLevelChanges___c__DisplayClass3_0_TypeInfo);
		    DAT_ram_00a596a5 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (CloudsFly_Movement_ToIsleAfterLevelChanges___c__DisplayClass3_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param4;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param3,0);
		  local_8 = *(undefined4 *)(param2 + 1);
		  local_10 = *param2;
		  uVar2 = DG_Tweening_ShortcutExtensions__DOTime(uVar2,&local_10,0.8,0,0);
		  uVar2 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar2,6,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  param1_00 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (param1_00,iVar1,
		             Method_CloudsFly_Movement_ToIsleAfterLevelChanges___c__DisplayClass3_0__Move_b__0__,0);
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
		  param1_01 = *(int *)(param1 + 8);
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_01 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_01 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  return;
		}
		*/

}
