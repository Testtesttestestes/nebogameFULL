using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using TMPro;
using UI.Utils;
using UnityEngine;

namespace Gameplay.Combat.View
{
	// Token: 0x02000922 RID: 2338
	[Token(Token = "0x2000922")]
	public class PlayerChatBubble : MonoBehaviour
	{
		// Token: 0x06003717 RID: 14103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003717")]
		[Address(RVA = "0x8706", Offset = "0x8706", VA = "0x8706")]
		private void OnDestroy()
		{
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06003718 RID: 14104 RVA: 0x0000B070 File Offset: 0x00009270
		// (set) Token: 0x06003719 RID: 14105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE2")]
		public bool Visible
		{
			[Token(Token = "0x6003718")]
			[Address(RVA = "0x8707", Offset = "0x8707", VA = "0x8707")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003719")]
			[Address(RVA = "0x8708", Offset = "0x8708", VA = "0x8708")]
			set
			{
			}
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600371A")]
		[Address(RVA = "0x8709", Offset = "0x8709", VA = "0x8709")]
		private void HandleVisibleChaged()
		{
		/* --- GHIDRA: HandleVisibleChaged ---
		void Gameplay_Combat_View_PlayerChatBubble__HandleVisibleChaged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a63b3c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_string__Enqueue__);
		    DAT_ram_00a63b3c = '\x01';
		  }
		  System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		            (*(undefined4 *)(param1 + 0x1c),param2,
		             Method_System_Collections_Generic_Queue_string__Enqueue__);
		  if (*(char *)(param1 + 0x24) == '\0') {
		    Gameplay_Combat_View_PlayerChatBubble__TryStopTween(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600371B RID: 14107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600371B")]
		[Address(RVA = "0x870A", Offset = "0x870A", VA = "0x870A")]
		public void AddText(string text)
		{
		/* --- GHIDRA: AddText ---
		void Gameplay_Combat_View_PlayerChatBubble__AddText(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (*(char *)(param1 + 0x18) != '\0') {
		    *(undefined1 *)(param1 + 0x18) = 0;
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (param1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,(uint)*(byte *)(param1 + 0x18),0);
		  }
		  if (*(int *)(param1 + 0x20) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x20),0,0);
		    *(undefined4 *)(param1 + 0x20) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600371C RID: 14108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600371C")]
		[Address(RVA = "0x870B", Offset = "0x870B", VA = "0x870B")]
		public void Stop()
		{
		/* --- GHIDRA: Stop ---
		uint Gameplay_Combat_View_PlayerChatBubble__Stop(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x20);
		  if (param1_00 != 0) {
		    func_ii_7891(param1_00,0,0);
		    *(undefined4 *)(param1 + 0x20) = 0;
		  }
		  return (uint)(param1_00 != 0);
		}
		*/

		}

		// Token: 0x0600371D RID: 14109 RVA: 0x0000B088 File Offset: 0x00009288
		[Token(Token = "0x600371D")]
		[Address(RVA = "0x870C", Offset = "0x870C", VA = "0x870C")]
		private bool TryStopTween()
		{
		/* --- GHIDRA: TryStopTween ---
		void Gameplay_Combat_View_PlayerChatBubble__TryStopTween(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a63b3d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Combat_View_PlayerChatBubble__Play_b__15_0__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_string__Dequeue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_string__get_Count__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a63b3d = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x1c);
		  iVar3 = *(int *)(iVar2 + 0x14);
		  if (0 < iVar3 != (bool)*(char *)(param1 + 0x18)) {
		    *(bool *)(param1 + 0x18) = 0 < iVar3;
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,(uint)*(byte *)(param1 + 0x18),0);
		    iVar2 = *(int *)(param1 + 0x1c);
		    iVar3 = *(int *)(iVar2 + 0x14);
		  }
		  if (0 < iVar3) {
		    uVar1 = func_ii_7387(iVar2,Method_System_Collections_Generic_Queue_string__Dequeue__);
		    iVar2 = **(int **)(param1 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		              (*(int **)(param1 + 0x10),uVar1,*(undefined4 *)(iVar2 + 0x2d4));
		    UI_Utils_LayoutUpdater__Start(*(undefined4 *)(param1 + 0x14),0);
		    uVar1 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (uVar1,param1,Method_Gameplay_Combat_View_PlayerChatBubble__Play_b__15_0__,0);
		    uVar1 = DG_Tweening_DOVirtual__EasedValue(4.5,uVar1,1,0);
		    *(undefined4 *)(param1 + 0x20) = uVar1;
		    *(undefined1 *)(param1 + 0x24) = 1;
		    return;
		  }
		  iVar2 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x10),StringLiteral_5,*(undefined4 *)(iVar2 + 0x2d4));
		  *(undefined1 *)(param1 + 0x24) = 0;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600371E")]
		[Address(RVA = "0x870D", Offset = "0x870D", VA = "0x870D")]
		private void Play()
		{
		/* --- GHIDRA: Play ---
		void Gameplay_Combat_View_PlayerChatBubble__Play(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63b3e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Queue_string__TypeInfo);
		    DAT_ram_00a63b3e = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Queue_string__TypeInfo);
		  Sirenix_Serialization_StackFormatter_object____Il2CppFullySharedGenericType___SerializeImplementation
		            (param1_00,Method_System_Collections_Generic_Queue_string___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600371F RID: 14111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600371F")]
		[Address(RVA = "0x870E", Offset = "0x870E", VA = "0x870E")]
		public PlayerChatBubble()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_PlayerChatBubble___ctor(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Combat_View_PlayerChatBubble__TryStopTween(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x04001E3C RID: 7740
		[Token(Token = "0x4001E3C")]
		public const float DISPLAY_DURATION = 4.5f;

		// Token: 0x04001E3D RID: 7741
		[Token(Token = "0x4001E3D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _textField;

		// Token: 0x04001E3E RID: 7742
		[Token(Token = "0x4001E3E")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private LayoutUpdater _layoutUpdater;

		// Token: 0x04001E3F RID: 7743
		[Token(Token = "0x4001E3F")]
		[FieldOffset(Offset = "0x18")]
		private bool _visible;

		// Token: 0x04001E40 RID: 7744
		[Token(Token = "0x4001E40")]
		[FieldOffset(Offset = "0x1C")]
		private Queue<string> _textQueue;

		// Token: 0x04001E41 RID: 7745
		[Token(Token = "0x4001E41")]
		[FieldOffset(Offset = "0x20")]
		private Tween _delayedTween;

		// Token: 0x04001E42 RID: 7746
		[Token(Token = "0x4001E42")]
		[FieldOffset(Offset = "0x24")]
		private bool _isPlay;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Visible ---
		void Gameplay_Combat_View_PlayerChatBubble__get_Visible(int param1,uint param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (param2 != *(byte *)(param1 + 0x18)) {
		    *(char *)(param1 + 0x18) = (char)param2;
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (param1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,(uint)*(byte *)(param1 + 0x18),0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Visible ---
		void Gameplay_Combat_View_PlayerChatBubble__set_Visible(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)*(byte *)(param1 + 0x18),0);
		  return;
		}
		*/

}
