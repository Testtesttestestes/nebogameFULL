using System;
using System.Collections.Generic;
using Gameplay.TutorialV2.View;
using Il2CppDummyDll;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x02000442 RID: 1090
	[Token(Token = "0x2000442")]
	public class TutorialViewStatesQueue : TutorialStepsQueueBase
	{
		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x060019BD RID: 6589 RVA: 0x00005928 File Offset: 0x00003B28
		[Token(Token = "0x17000489")]
		public override StepActionType StepActionType
		{
			[Token(Token = "0x60019BD")]
			[Address(RVA = "0x6B55", Offset = "0x6B55", VA = "0x6B55", Slot = "4")]
			get
			{
				return StepActionType.None;
			}
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019BE")]
		[Address(RVA = "0x6B56", Offset = "0x6B56", VA = "0x6B56")]
		public TutorialViewStatesQueue(TutorialView view, IEnumerable<TutorialView.States> states)
		{
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019BF")]
		[Address(RVA = "0x6B57", Offset = "0x6B57", VA = "0x6B57", Slot = "6")]
		public override void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_TutorialV2_Controller_TutorialViewStatesQueue__Hide
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a583e4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_TutorialView_States__set_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_TutorialView_States__Dequeue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_TutorialView_States__get_Count__);
		    DAT_ram_00a583e4 = '\x01';
		  }
		  if (*(int *)(*(int *)(param1 + 8) + 0x14) != 0) {
		    param1_00 = *(undefined4 *)(param1 + 0xc);
		    param2_00 = System_Collections_Generic_Queue_uint___Clear
		                          (*(int *)(param1 + 8),
		                           Method_System_Collections_Generic_Queue_TutorialView_States__Dequeue__);
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (param1_00,param2_00,
		               Method_UI_MonoBehaviourWithStates_TutorialView_States__set_CurrentState__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C0")]
		[Address(RVA = "0x6B58", Offset = "0x6B58", VA = "0x6B58", Slot = "5")]
		protected override void ShowNextInternal(StepActionType actionType)
		{
		}

		// Token: 0x04000DD2 RID: 3538
		[Token(Token = "0x4000DD2")]
		[FieldOffset(Offset = "0x8")]
		private Queue<TutorialView.States> _statesQueue;

		// Token: 0x04000DD3 RID: 3539
		[Token(Token = "0x4000DD3")]
		[FieldOffset(Offset = "0xC")]
		private readonly TutorialView _view;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_StepActionType ---
		void Gameplay_TutorialV2_Controller_TutorialViewStatesQueue__get_StepActionType
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a583e3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_TutorialView_States___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Queue_TutorialView_States__TypeInfo);
		    DAT_ram_00a583e3 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Queue_TutorialView_States__TypeInfo);
		  System_Collections_Generic_Queue_Int32Enum____ctor
		            (param1_00,param3,Method_System_Collections_Generic_Queue_TutorialView_States___ctor__);
		  *(undefined4 *)(param1 + 0xc) = param2;
		  *(undefined4 *)(param1 + 8) = param1_00;
		  return;
		}
		*/

}
