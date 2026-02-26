using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly.Movement
{
	// Token: 0x02001322 RID: 4898
	[Token(Token = "0x2001322")]
	public class ToLevel : AbstractWorldMovement
	{
		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x06007439 RID: 29753 RVA: 0x00014E98 File Offset: 0x00013098
		[Token(Token = "0x1700176C")]
		public override WorldMovementTypes Type
		{
			[Token(Token = "0x6007439")]
			[Address(RVA = "0xBE07", Offset = "0xBE07", VA = "0xBE07", Slot = "5")]
			get
			{
				return (WorldMovementTypes)0;
			}
		}

		// Token: 0x0600743A RID: 29754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600743A")]
		[Address(RVA = "0xBE08", Offset = "0xBE08", VA = "0xBE08", Slot = "6")]
		public override void Move(Vector3 target, Camera camera, Action callback)
		{
		}

		// Token: 0x0600743B RID: 29755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600743B")]
		[Address(RVA = "0xBE09", Offset = "0xBE09", VA = "0xBE09", Slot = "8")]
		public override void Dispose()
		{
		}

		// Token: 0x0600743C RID: 29756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600743C")]
		[Address(RVA = "0xBE0A", Offset = "0xBE0A", VA = "0xBE0A")]
		public ToLevel()
		{
		}

		// Token: 0x04003CD8 RID: 15576
		[Token(Token = "0x4003CD8")]
		[FieldOffset(Offset = "0xC")]
		private Camera _camera;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Type ---
		void CloudsFly_Movement_ToLevel__get_Type
		               (int param1,undefined8 *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  uint uVar3;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a596a6 == '\0') {
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
		              (&Method_CloudsFly_Movement_ToLevel___c__DisplayClass3_0__Move_b__0__);
		    Mono_Security_ASN1__get_Item(&CloudsFly_Movement_ToLevel___c__DisplayClass3_0_TypeInfo);
		    DAT_ram_00a596a6 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(CloudsFly_Movement_ToLevel___c__DisplayClass3_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param4;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param3,0);
		  local_8 = *(undefined4 *)(param2 + 1);
		  local_10 = *param2;
		  uVar2 = DG_Tweening_ShortcutExtensions__DOTime(uVar2,&local_10,0.8,0,0);
		  uVar2 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar2,5,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  param1_00 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (param1_00,iVar1,Method_CloudsFly_Movement_ToLevel___c__DisplayClass3_0__Move_b__0__,0);
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
