using System;
using System.Collections.Generic;
using Gameplay.TutorialV2.View;
using Il2CppDummyDll;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x02000436 RID: 1078
	[Token(Token = "0x2000436")]
	public class MessageBubbleQueue : TutorialStepsQueueBase
	{
		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x000058E0 File Offset: 0x00003AE0
		[Token(Token = "0x17000481")]
		public override StepActionType StepActionType
		{
			[Token(Token = "0x6001973")]
			[Address(RVA = "0x6B12", Offset = "0x6B12", VA = "0x6B12", Slot = "4")]
			get
			{
				return StepActionType.None;
			}
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001974")]
		[Address(RVA = "0x6B13", Offset = "0x6B13", VA = "0x6B13")]
		public MessageBubbleQueue(MessageBubbleView view, IEnumerable<MessageBubbleView.MessageBubbleViewArgs> steps)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_TutorialV2_Controller_MessageBubbleQueue___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a583be == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_MessageBubbleView_MessageBubbleViewArgs__Dequeue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_MessageBubbleView_MessageBubbleViewArgs__get_Count__
		              );
		    DAT_ram_00a583be = '\x01';
		  }
		  if (*(int *)(*(int *)(param1 + 8) + 0x14) != 0) {
		    param2_00 = func_ii_7387(*(int *)(param1 + 8),
		                             Method_System_Collections_Generic_Queue_MessageBubbleView_MessageBubbleViewArgs__Dequeue__
		                            );
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(param1 + 0xc),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,1,0);
		    Gameplay_TutorialV2_View_MessageBubbleView__SetPosition
		              (*(undefined4 *)(param1 + 0xc),param2_00,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001975 RID: 6517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001975")]
		[Address(RVA = "0x6B14", Offset = "0x6B14", VA = "0x6B14", Slot = "5")]
		protected override void ShowNextInternal(StepActionType actionType)
		{
		/* --- GHIDRA: ShowNextInternal ---
		void Gameplay_TutorialV2_Controller_MessageBubbleQueue__ShowNextInternal
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0xc),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06001976 RID: 6518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001976")]
		[Address(RVA = "0x6B15", Offset = "0x6B15", VA = "0x6B15", Slot = "6")]
		public override void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_TutorialV2_Controller_MessageBubbleQueue__Hide
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a583bf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_GraphicPointerView_GraphicPointerViewArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Queue_GraphicPointerView_GraphicPointerViewArgs__TypeInfo
		              );
		    DAT_ram_00a583bf = '\x01';
		  }
		  *(undefined4 *)(param1 + 8) = param2;
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Queue_GraphicPointerView_GraphicPointerViewArgs__TypeInfo
		                        );
		  System_Collections_Generic_Queue_JobHandle___get_Count
		            (param1_00,param3,
		             Method_System_Collections_Generic_Queue_GraphicPointerView_GraphicPointerViewArgs___ctor__
		            );
		  *(undefined4 *)(param1 + 0xc) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x04000D89 RID: 3465
		[Token(Token = "0x4000D89")]
		[FieldOffset(Offset = "0x8")]
		private Queue<MessageBubbleView.MessageBubbleViewArgs> _steps;

		// Token: 0x04000D8A RID: 3466
		[Token(Token = "0x4000D8A")]
		[FieldOffset(Offset = "0xC")]
		private MessageBubbleView _view;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_StepActionType ---
		void Gameplay_TutorialV2_Controller_MessageBubbleQueue__get_StepActionType
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a583bd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_MessageBubbleView_MessageBubbleViewArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_MessageBubbleView_MessageBubbleViewArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Queue_MessageBubbleView_MessageBubbleViewArgs__TypeInfo);
		    DAT_ram_00a583bd = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Queue_MessageBubbleView_MessageBubbleViewArgs__TypeInfo
		                    );
		  Sirenix_Serialization_StackFormatter_object____Il2CppFullySharedGenericType___SerializeImplementation
		            (uVar1,
		             Method_System_Collections_Generic_Queue_MessageBubbleView_MessageBubbleViewArgs___ctor__
		            );
		  *(undefined4 *)(param1 + 8) = uVar1;
		  *(undefined4 *)(param1 + 0xc) = param2;
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Queue_MessageBubbleView_MessageBubbleViewArgs__TypeInfo
		                    );
		  System_Collections_Generic_Queue_JobHandle___get_Count
		            (uVar1,param3,
		             Method_System_Collections_Generic_Queue_MessageBubbleView_MessageBubbleViewArgs___ctor__
		            );
		  *(undefined4 *)(param1 + 8) = uVar1;
		  return;
		}
		*/

}
