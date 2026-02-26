using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.ConfirmationMessage
{
	// Token: 0x02000256 RID: 598
	[Token(Token = "0x2000256")]
	public class ConfirmationMessageController : MonoBehaviour
	{
		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x00004248 File Offset: 0x00002448
		// (set) Token: 0x06000E78 RID: 3704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F3")]
		public float DefaultDuration
		{
			[Token(Token = "0x6000E77")]
			[Address(RVA = "0x60F8", Offset = "0x60F8", VA = "0x60F8")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000E78")]
			[Address(RVA = "0x60F9", Offset = "0x60F9", VA = "0x60F9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E79")]
		[Address(RVA = "0x60FA", Offset = "0x60FA", VA = "0x60FA")]
		public void Show(string message)
		{
		/* --- GHIDRA: Show ---
		void UI_ConfirmationMessage_ConfirmationMessageController__Show(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (*(int *)(param1 + 0x24) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x24),0,0);
		  }
		  *(undefined4 *)(param1 + 0x20) = 0;
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x14),0,0);
		  UI_ConfirmationMessage_ConfirmationMessageController__Hide(param1,param1);
		  return;
		}
		*/

		/* --- GHIDRA: Show ---
		void UI_ConfirmationMessage_ConfirmationMessageController__Show(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (*(int *)(param1 + 0x24) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x24),0,0);
		  }
		  *(undefined4 *)(param1 + 0x20) = 0;
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x14),0,0);
		  UI_ConfirmationMessage_ConfirmationMessageController__Hide(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7A")]
		[Address(RVA = "0x60FB", Offset = "0x60FB", VA = "0x60FB")]
		public void Show(string message, float duration)
		{
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7B")]
		[Address(RVA = "0x60FC", Offset = "0x60FC", VA = "0x60FC")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void UI_ConfirmationMessage_ConfirmationMessageController__Hide(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  float param1_00;
		  
		  if (DAT_ram_00a639c2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ConfirmationMessage_ConfirmationMessageController_TempOnComplete__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_ConfirmationMessageController_ConfirmationMessageData__Dequeue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_ConfirmationMessageController_ConfirmationMessageData__get_Count__
		              );
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    DAT_ram_00a639c2 = '\x01';
		  }
		  if ((*(int *)(param1 + 0x20) == 0) && (*(int *)(*(int *)(param1 + 0x1c) + 0x14) != 0)) {
		    uVar1 = func_ii_7387(*(int *)(param1 + 0x1c),
		                         Method_System_Collections_Generic_Queue_ConfirmationMessageController_ConfirmationMessageData__Dequeue__
		                        );
		    *(undefined4 *)(param1 + 0x20) = uVar1;
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x10),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    UI_ConfirmationMessage_ConfirmationMessageController_ConfirmationMessageData___ctor
		              (*(undefined4 *)(param1 + 0x10),*(undefined4 *)(*(int *)(param1 + 0x20) + 8),
		               *(float *)(*(int *)(param1 + 0x20) + 0xc),param1);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1 + 0x14),1,0);
		    param1_00 = *(float *)(*(int *)(param1 + 0x20) + 0xc);
		    uVar1 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (uVar1,param1,
		               Method_UI_ConfirmationMessage_ConfirmationMessageController_TempOnComplete__,0);
		    uVar1 = DG_Tweening_DOVirtual__EasedValue(param1_00,uVar1,1,0);
		    *(undefined4 *)(param1 + 0x24) = uVar1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7C")]
		[Address(RVA = "0x60FD", Offset = "0x60FD", VA = "0x60FD")]
		private void HandleQueue()
		{
		/* --- GHIDRA: HandleQueue ---
		void UI_ConfirmationMessage_ConfirmationMessageController__HandleQueue(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  *(undefined4 *)(param1 + 0x20) = 0;
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x14),0,0);
		  UI_ConfirmationMessage_ConfirmationMessageController__Hide(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7D")]
		[Address(RVA = "0x60FE", Offset = "0x60FE", VA = "0x60FE")]
		private void TempOnComplete()
		{
		/* --- GHIDRA: TempOnComplete ---
		void UI_ConfirmationMessage_ConfirmationMessageController__TempOnComplete
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a639c3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_ConfirmationMessageController_ConfirmationMessageData___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Queue_ConfirmationMessageController_ConfirmationMessageData__TypeInfo
		              );
		    DAT_ram_00a639c3 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = 0x40000000;
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Queue_ConfirmationMessageController_ConfirmationMessageData__TypeInfo
		                        );
		  Sirenix_Serialization_StackFormatter_object____Il2CppFullySharedGenericType___SerializeImplementation
		            (param1_00,
		             Method_System_Collections_Generic_Queue_ConfirmationMessageController_ConfirmationMessageData___ctor__
		            );
		  *(undefined4 *)(param1 + 0x1c) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7E")]
		[Address(RVA = "0x60FF", Offset = "0x60FF", VA = "0x60FF")]
		public ConfirmationMessageController()
		{
		}

		// Token: 0x0400073F RID: 1855
		[Token(Token = "0x400073F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ConfirmationMessageRenderer _confirmationMessageRenderer;

		// Token: 0x04000740 RID: 1856
		[Token(Token = "0x4000740")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _block;

		// Token: 0x04000742 RID: 1858
		[Token(Token = "0x4000742")]
		[FieldOffset(Offset = "0x1C")]
		private Queue<ConfirmationMessageController.ConfirmationMessageData> _queue;

		// Token: 0x04000743 RID: 1859
		[Token(Token = "0x4000743")]
		[FieldOffset(Offset = "0x20")]
		private ConfirmationMessageController.ConfirmationMessageData _currentMessage;

		// Token: 0x04000744 RID: 1860
		[Token(Token = "0x4000744")]
		[FieldOffset(Offset = "0x24")]
		private Tween _delayedCall;

		// Token: 0x02000257 RID: 599
		[Token(Token = "0x2000257")]
		private class ConfirmationMessageData
		{
			// Token: 0x170001F4 RID: 500
			// (get) Token: 0x06000E7F RID: 3711 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170001F4")]
			public string Message
			{
				[Token(Token = "0x6000E7F")]
				[Address(RVA = "0x6100", Offset = "0x6100", VA = "0x6100")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170001F5 RID: 501
			// (get) Token: 0x06000E80 RID: 3712 RVA: 0x00004260 File Offset: 0x00002460
			[Token(Token = "0x170001F5")]
			public float Duration
			{
				[Token(Token = "0x6000E80")]
				[Address(RVA = "0x6101", Offset = "0x6101", VA = "0x6101")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06000E81 RID: 3713 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E81")]
			[Address(RVA = "0x6102", Offset = "0x6102", VA = "0x6102")]
			public ConfirmationMessageData(string message, float duration)
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_DefaultDuration ---
		void UI_ConfirmationMessage_ConfirmationMessageController__set_DefaultDuration
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  uVar1 = *(undefined4 *)(param1 + 0x18);
		  if (DAT_ram_00a639c1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_ConfirmationMessage_ConfirmationMessageController_ConfirmationMessageData_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_ConfirmationMessageController_ConfirmationMessageData__Enqueue__
		              );
		    DAT_ram_00a639c1 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x1c);
		  param2_00 = unnamed_function_1417
		                        (
		                        UI_ConfirmationMessage_ConfirmationMessageController_ConfirmationMessageData_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0xc) = uVar1;
		  *(undefined4 *)(param2_00 + 8) = param2;
		  System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		            (param1_00,param2_00,
		             Method_System_Collections_Generic_Queue_ConfirmationMessageController_ConfirmationMessageData__Enqueue__
		            );
		  UI_ConfirmationMessage_ConfirmationMessageController__Hide(param1,param1);
		  return;
		}
		*/

}
