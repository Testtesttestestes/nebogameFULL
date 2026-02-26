using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x0200043C RID: 1084
	[Token(Token = "0x200043C")]
	public class TutorialStepsConveyor
	{
		// Token: 0x06001996 RID: 6550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001996")]
		[Address(RVA = "0x6B35", Offset = "0x6B35", VA = "0x6B35")]
		public TutorialStepsConveyor(IEnumerable<StepActionType> actions)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_TutorialV2_Controller_TutorialStepsConveyor___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a583d2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TutorialStepsQueueBase__Add__);
		    DAT_ram_00a583d2 = '\x01';
		  }
		  iVar1 = Method_System_Collections_Generic_List_TutorialStepsQueueBase__Add__;
		  param1_00 = *(int *)(param1 + 0xc);
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

		// Token: 0x06001997 RID: 6551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001997")]
		[Address(RVA = "0x6B36", Offset = "0x6B36", VA = "0x6B36")]
		public void AppendQueue(TutorialStepsQueueBase queue)
		{
		/* --- GHIDRA: AppendQueue ---
		void Gameplay_TutorialV2_Controller_TutorialStepsConveyor__AppendQueue(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = *(int *)(param1 + 0x10);
		  if (iVar1 != 0) {
		    iVar2 = *(int *)(iVar1 + 0xc);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),iVar1,*(undefined4 *)(iVar2 + 0x14));
		      iVar1 = *(int *)(param1 + 0x10);
		      if (iVar1 == 0) goto code_r0x80ede788;
		    }
		    *(undefined4 *)(iVar1 + 0xc) = 0;
		  }
		code_r0x80ede788:
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__EmulateCombatForTutorialGameService__PlayerActionEmulate_d__75_
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001998 RID: 6552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001998")]
		[Address(RVA = "0x6B37", Offset = "0x6B37", VA = "0x6B37")]
		public void Continue()
		{
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001999")]
		[Address(RVA = "0x1CEB", Offset = "0x1CEB", VA = "0x1CEB")]
		private void Next()
		{
		}

		// Token: 0x04000DC9 RID: 3529
		[Token(Token = "0x4000DC9")]
		[FieldOffset(Offset = "0x8")]
		private readonly Queue<StepActionType> _actionsQueue;

		// Token: 0x04000DCA RID: 3530
		[Token(Token = "0x4000DCA")]
		[FieldOffset(Offset = "0xC")]
		private List<TutorialStepsQueueBase> _stepQueues;

		// Token: 0x04000DCB RID: 3531
		[Token(Token = "0x4000DCB")]
		[FieldOffset(Offset = "0x10")]
		private TutorialStepAction _currentStep;
	}
}
