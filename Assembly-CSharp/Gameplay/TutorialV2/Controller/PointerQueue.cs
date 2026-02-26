using System;
using System.Collections.Generic;
using Gameplay.Tutorial.Guide.View;
using Il2CppDummyDll;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x02000437 RID: 1079
	[Token(Token = "0x2000437")]
	public class PointerQueue : TutorialStepsQueueBase
	{
		// Token: 0x06001977 RID: 6519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001977")]
		[Address(RVA = "0x6B16", Offset = "0x6B16", VA = "0x6B16")]
		public PointerQueue(GraphicPointerView pointer, IEnumerable<GraphicPointerView.GraphicPointerViewArgs> sequence)
		{
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06001978 RID: 6520 RVA: 0x000058F8 File Offset: 0x00003AF8
		[Token(Token = "0x17000482")]
		public override StepActionType StepActionType
		{
			[Token(Token = "0x6001978")]
			[Address(RVA = "0x6B17", Offset = "0x6B17", VA = "0x6B17", Slot = "4")]
			get
			{
				return StepActionType.None;
			}
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001979")]
		[Address(RVA = "0x6B18", Offset = "0x6B18", VA = "0x6B18", Slot = "6")]
		public override void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_TutorialV2_Controller_PointerQueue__Hide
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a583c0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_GraphicPointerView_GraphicPointerViewArgs__Dequeue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_GraphicPointerView_GraphicPointerViewArgs__get_Count__
		              );
		    DAT_ram_00a583c0 = '\x01';
		  }
		  if (*(int *)(*(int *)(param1 + 0xc) + 0x14) != 0) {
		    uVar1 = func_ii_7387(*(int *)(param1 + 0xc),
		                         Method_System_Collections_Generic_Queue_GraphicPointerView_GraphicPointerViewArgs__Dequeue__
		                        );
		    Gameplay_Tutorial_Guide_View_GraphicPointerView__SetPosition
		              (*(undefined4 *)(param1 + 8),uVar1,param1);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 8),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600197A RID: 6522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600197A")]
		[Address(RVA = "0x6B19", Offset = "0x6B19", VA = "0x6B19", Slot = "5")]
		protected override void ShowNextInternal(StepActionType actionType)
		{
		/* --- GHIDRA: ShowNextInternal ---
		void Gameplay_TutorialV2_Controller_PointerQueue__ShowNextInternal
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a583c1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_IReadOnlyList_ScaleQueue_ScaleQueueArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Queue_IReadOnlyList_ScaleQueue_ScaleQueueArgs___TypeInfo)
		    ;
		    DAT_ram_00a583c1 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Queue_IReadOnlyList_ScaleQueue_ScaleQueueArgs___TypeInfo
		                        );
		  System_Collections_Generic_Queue_JobHandle___get_Count
		            (param1_00,param2,
		             Method_System_Collections_Generic_Queue_IReadOnlyList_ScaleQueue_ScaleQueueArgs____ctor__
		            );
		  *(undefined4 *)(param1 + 8) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x04000D8B RID: 3467
		[Token(Token = "0x4000D8B")]
		[FieldOffset(Offset = "0x8")]
		private readonly GraphicPointerView _pointer;

		// Token: 0x04000D8C RID: 3468
		[Token(Token = "0x4000D8C")]
		[FieldOffset(Offset = "0xC")]
		private Queue<GraphicPointerView.GraphicPointerViewArgs> _queue;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_StepActionType ---
		void Gameplay_TutorialV2_Controller_PointerQueue__get_StepActionType(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 8),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  return;
		}
		*/

}
