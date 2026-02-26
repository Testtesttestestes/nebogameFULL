using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x02000432 RID: 1074
	[Token(Token = "0x2000432")]
	public class CallbackQueue : TutorialStepsQueueBase
	{
		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x000058B0 File Offset: 0x00003AB0
		[Token(Token = "0x1700047F")]
		public override StepActionType StepActionType
		{
			[Token(Token = "0x6001968")]
			[Address(RVA = "0x6B07", Offset = "0x6B07", VA = "0x6B07", Slot = "4")]
			get
			{
				return StepActionType.None;
			}
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001969")]
		[Address(RVA = "0x6B08", Offset = "0x6B08", VA = "0x6B08")]
		public CallbackQueue(StepActionType actionType, IEnumerable<CallbackQueue.CallbackItem> sequence)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_TutorialV2_Controller_CallbackQueue___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a583b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_CallbackQueue_CallbackItem___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Queue_CallbackQueue_CallbackItem__TypeInfo);
		    DAT_ram_00a583b9 = '\x01';
		  }
		  *(undefined4 *)(param1 + 8) = param2;
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Queue_CallbackQueue_CallbackItem__TypeInfo);
		  System_Collections_Generic_Queue_JobHandle___get_Count
		            (param1_00,param3,
		             Method_System_Collections_Generic_Queue_CallbackQueue_CallbackItem___ctor__);
		  *(undefined4 *)(param1 + 0xc) = param1_00;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_TutorialV2_Controller_CallbackQueue___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a583b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_CallbackQueue_CallbackItem___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Queue_CallbackQueue_CallbackItem__TypeInfo);
		    DAT_ram_00a583b9 = '\x01';
		  }
		  *(undefined4 *)(param1 + 8) = param2;
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Queue_CallbackQueue_CallbackItem__TypeInfo);
		  System_Collections_Generic_Queue_JobHandle___get_Count
		            (param1_00,param3,
		             Method_System_Collections_Generic_Queue_CallbackQueue_CallbackItem___ctor__);
		  *(undefined4 *)(param1 + 0xc) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x0600196A RID: 6506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600196A")]
		[Address(RVA = "0x6B09", Offset = "0x6B09", VA = "0x6B09")]
		public CallbackQueue(StepActionType actionType, params CallbackQueue.CallbackItem[] sequence)
		{
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600196B")]
		[Address(RVA = "0x6B0A", Offset = "0x6B0A", VA = "0x6B0A", Slot = "6")]
		public override void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_TutorialV2_Controller_CallbackQueue__Hide
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a583ba == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_CallbackQueue_CallbackItem__Dequeue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_CallbackQueue_CallbackItem__get_Count__);
		    DAT_ram_00a583ba = '\x01';
		  }
		  if (*(int *)(*(int *)(param1 + 0xc) + 0x14) != 0) {
		    iVar1 = func_ii_7387(*(int *)(param1 + 0xc),
		                         Method_System_Collections_Generic_Queue_CallbackQueue_CallbackItem__Dequeue__
		                        );
		    iVar2 = *(int *)(iVar1 + 8);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		    *(undefined4 *)(iVar1 + 8) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600196C RID: 6508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600196C")]
		[Address(RVA = "0x6B0B", Offset = "0x6B0B", VA = "0x6B0B", Slot = "5")]
		protected override void ShowNextInternal(StepActionType actionType)
		{
		}

		// Token: 0x04000D80 RID: 3456
		[Token(Token = "0x4000D80")]
		[FieldOffset(Offset = "0x8")]
		private readonly StepActionType _stepActionType;

		// Token: 0x04000D81 RID: 3457
		[Token(Token = "0x4000D81")]
		[FieldOffset(Offset = "0xC")]
		private Queue<CallbackQueue.CallbackItem> _queue;

		// Token: 0x02000433 RID: 1075
		[Token(Token = "0x2000433")]
		public class CallbackItem
		{
			// Token: 0x0600196D RID: 6509 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600196D")]
			[Address(RVA = "0x6B0C", Offset = "0x6B0C", VA = "0x6B0C")]
			public CallbackItem(Action callback)
			{
			}

			// Token: 0x04000D82 RID: 3458
			[Token(Token = "0x4000D82")]
			[FieldOffset(Offset = "0x8")]
			public Action Callback;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_StepActionType ---
		void Gameplay_TutorialV2_Controller_CallbackQueue__get_StepActionType
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a583b8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_CallbackQueue_CallbackItem___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Queue_CallbackQueue_CallbackItem__TypeInfo);
		    DAT_ram_00a583b8 = '\x01';
		  }
		  *(undefined4 *)(param1 + 8) = param2;
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Queue_CallbackQueue_CallbackItem__TypeInfo);
		  System_Collections_Generic_Queue_JobHandle___get_Count
		            (param1_00,param3,
		             Method_System_Collections_Generic_Queue_CallbackQueue_CallbackItem___ctor__);
		  *(undefined4 *)(param1 + 0xc) = param1_00;
		  return;
		}
		*/

}
