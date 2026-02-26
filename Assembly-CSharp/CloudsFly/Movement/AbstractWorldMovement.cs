using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly.Movement
{
	// Token: 0x02001314 RID: 4884
	[Token(Token = "0x2001314")]
	public abstract class AbstractWorldMovement : IDisposable
	{
		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x0600740B RID: 29707
		[Token(Token = "0x17001763")]
		public abstract WorldMovementTypes Type { [Token(Token = "0x600740B")] get; }

		// Token: 0x0600740C RID: 29708
		[Token(Token = "0x600740C")]
		public abstract void Move(Vector3 target, Camera camera, Action callback);

		// Token: 0x0600740D RID: 29709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600740D")]
		[Address(RVA = "0xBDDB", Offset = "0xBDDB", VA = "0xBDDB", Slot = "7")]
		public virtual void Cancel()
		{
		}

		// Token: 0x0600740E RID: 29710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600740E")]
		[Address(RVA = "0xBDDC", Offset = "0xBDDC", VA = "0xBDDC", Slot = "8")]
		public virtual void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void CloudsFly_Movement_AbstractWorldMovement__Dispose
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a5969b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Tween__Add__);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetAutoKill_Tween___);
		    DAT_ram_00a5969b = '\x01';
		  }
		  DG_Tweening_TweenSettingsExtensions__SetAutoKill_object_
		            (param2,0,Method_DG_Tweening_TweenSettingsExtensions_SetAutoKill_Tween___);
		  iVar1 = Method_System_Collections_Generic_List_Tween__Add__;
		  param1_00 = *(int *)(param1 + 8);
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param2;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,param2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

		}

		// Token: 0x0600740F RID: 29711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600740F")]
		[Address(RVA = "0xBDDD", Offset = "0xBDDD", VA = "0xBDDD")]
		protected void AddTween(Tween tween)
		{
		}

		// Token: 0x06007410 RID: 29712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007410")]
		[Address(RVA = "0xBDDE", Offset = "0xBDDE", VA = "0xBDDE")]
		protected AbstractWorldMovement()
		{
		}

		// Token: 0x04003CCE RID: 15566
		[Token(Token = "0x4003CCE")]
		[FieldOffset(Offset = "0x8")]
		protected List<Tween> _runningTweens;
	}
}
