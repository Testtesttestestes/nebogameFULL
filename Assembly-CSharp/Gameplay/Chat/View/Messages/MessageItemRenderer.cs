using System;
using System.Runtime.CompilerServices;
using Gameplay.Chat.Model.Data;
using Gameplay.Chat.Model.Data.Message;
using Il2CppDummyDll;
using TMPro;
using UI.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Chat.View.Messages
{
	// Token: 0x02000AFC RID: 2812
	[Token(Token = "0x2000AFC")]
	public class MessageItemRenderer : MonoBehaviour
	{
		// Token: 0x140001A7 RID: 423
		// (add) Token: 0x060043D0 RID: 17360 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060043D1 RID: 17361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001A7")]
		public event Action<ChatMessageItem> MessageHasBeenViewedEvent
		{
			[Token(Token = "0x60043D0")]
			[Address(RVA = "0x9283", Offset = "0x9283", VA = "0x9283")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60043D1")]
			[Address(RVA = "0x9284", Offset = "0x9284", VA = "0x9284")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001A8 RID: 424
		// (add) Token: 0x060043D2 RID: 17362 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060043D3 RID: 17363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001A8")]
		public event Action<ChatMessageItem> DeleteMessageEvent
		{
			[Token(Token = "0x60043D2")]
			[Address(RVA = "0x9285", Offset = "0x9285", VA = "0x9285")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60043D3")]
			[Address(RVA = "0x9286", Offset = "0x9286", VA = "0x9286")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001A9 RID: 425
		// (add) Token: 0x060043D4 RID: 17364 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060043D5 RID: 17365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001A9")]
		public event Action<ChatVisitorData, ChatMessageItem> ClickOnUserNickEvent
		{
			[Token(Token = "0x60043D4")]
			[Address(RVA = "0x9287", Offset = "0x9287", VA = "0x9287")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60043D5")]
			[Address(RVA = "0x9288", Offset = "0x9288", VA = "0x9288")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x060043D6 RID: 17366 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D5E")]
		public ContentSizeFitter ContentSizeFitter
		{
			[Token(Token = "0x60043D6")]
			[Address(RVA = "0x9289", Offset = "0x9289", VA = "0x9289")]
			get
			{
				return null;
			}
		}

		// Token: 0x060043D7 RID: 17367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043D7")]
		[Address(RVA = "0x928A", Offset = "0x928A", VA = "0x928A")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Chat_View_Messages_MessageItemRenderer__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57b12 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_TMP_LinkInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Chat_View_Messages_MessageItemRenderer_HandleDeleteButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_Messages_MessageItemRenderer_HandleLinkClickEvent__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57b12 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Chat_View_Messages_MessageItemRenderer_HandleDeleteButtonClickEvent__,0
		            );
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  uVar1 = unnamed_function_1417(System_EventHandler_TMP_LinkInfo__TypeInfo);
		  System_EventHandler_object___Invoke
		            (uVar1,param1,
		             Method_Gameplay_Chat_View_Messages_MessageItemRenderer_HandleLinkClickEvent__,0);
		  UI_Utils_LayoutUpdater__SetDirty_d__2__System_Collections_IEnumerator_get_Current(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043D8")]
		[Address(RVA = "0x928B", Offset = "0x928B", VA = "0x928B")]
		private void Start()
		{
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x060043D9 RID: 17369 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060043DA RID: 17370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D5F")]
		public ChatMessageItem Data
		{
			[Token(Token = "0x60043D9")]
			[Address(RVA = "0x928C", Offset = "0x928C", VA = "0x928C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60043DA")]
			[Address(RVA = "0x928D", Offset = "0x928D", VA = "0x928D")]
			set
			{
			}
		}

		// Token: 0x060043DB RID: 17371 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60043DB")]
		[Address(RVA = "0x928E", Offset = "0x928E", VA = "0x928E")]
		public ChatUserMessageData GetUserMessage()
		{
		/* --- GHIDRA: GetUserMessage ---
		void Gameplay_Chat_View_Messages_MessageItemRenderer__GetUserMessage(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  uint uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  piVar1 = (int *)Gameplay_Chat_View_Messages_MessageItemRenderer__set_Data(param1,param1);
		  uVar3 = *(uint *)(*(int *)(*(int *)(*(int *)(param1 + 0x30) + 8) + 0x14) + 0x10);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  if ((uVar3 & 0x40) == 0) {
		    uVar3 = 0;
		  }
		  else {
		    uVar3 = (*(byte *)(*(int *)(*(int *)(*(int *)(*(int *)(param1 + 0x30) + 0xc) + 0x10) + 0x14) +
		                      0x14) & 2) >> 1;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,uVar3,0);
		  piVar4 = *(int **)(param1 + 0x14);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xf0) * 4))
		                    (piVar1,0,*(undefined4 *)(*piVar1 + 0xf4));
		  iVar5 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))
		            (piVar4,uVar2,*(undefined4 *)(iVar5 + 0x2d4));
		  piVar4 = *(int **)(param1 + 0x10);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x100) * 4))
		                    (piVar1,*(undefined4 *)(*piVar1 + 0x104));
		  iVar5 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))
		            (piVar4,uVar2,*(undefined4 *)(iVar5 + 0x2d4));
		  if (*(char *)(*(int *)(param1 + 0x30) + 0x10) == '\0') {
		    iVar5 = *(int *)(param1 + 0x24);
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		              (*(undefined4 *)(iVar5 + 0x20),*(int *)(param1 + 0x30),*(undefined4 *)(iVar5 + 0x14));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060043DC RID: 17372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043DC")]
		[Address(RVA = "0x928F", Offset = "0x928F", VA = "0x928F")]
		private void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Chat_View_Messages_MessageItemRenderer__HandleDataChanged
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x28);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x30),
		             *(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060043DD RID: 17373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043DD")]
		[Address(RVA = "0x9290", Offset = "0x9290", VA = "0x9290")]
		private void HandleDeleteButtonClickEvent()
		{
		/* --- GHIDRA: HandleDeleteButtonClickEvent ---
		void Gameplay_Chat_View_Messages_MessageItemRenderer__HandleDeleteButtonClickEvent
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  undefined1 auStack_10 [8];
		  longlong local_8;
		  
		  local_8 = 0;
		  param1_00 = TMPro_TMP_LinkInfo__GetLink(param3,0);
		  iVar1 = System_UInt64__Parse(param1_00,&local_8,0);
		  if ((iVar1 != 0) && (local_8 != 0)) {
		    iVar2 = Gameplay_Chat_View_Messages_MessageItemRenderer__set_Data(param1,auStack_10);
		    iVar1 = *(int *)(iVar2 + 0x18);
		    if ((*(longlong *)(*(int *)(*(int *)(iVar1 + 0x14) + 0xc) + 0x10) == local_8) ||
		       ((iVar1 = *(int *)(iVar2 + 0x1c), iVar1 != 0 &&
		        (*(longlong *)(*(int *)(*(int *)(iVar1 + 0x14) + 0xc) + 0x10) == local_8)))) {
		      iVar2 = *(int *)(param1 + 0x2c);
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),iVar1,*(undefined4 *)(param1 + 0x30),
		                 *(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060043DE RID: 17374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043DE")]
		[Address(RVA = "0x9291", Offset = "0x9291", VA = "0x9291")]
		private void HandleLinkClickEvent(object sender, TMP_LinkInfo e)
		{
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043DF")]
		[Address(RVA = "0x9292", Offset = "0x9292", VA = "0x9292")]
		public MessageItemRenderer()
		{
		}

		// Token: 0x04002564 RID: 9572
		[Token(Token = "0x4002564")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _timestampTextField;

		// Token: 0x04002565 RID: 9573
		[Token(Token = "0x4002565")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _textField;

		// Token: 0x04002566 RID: 9574
		[Token(Token = "0x4002566")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ContentSizeFitter _contentSizeFitter;

		// Token: 0x04002567 RID: 9575
		[Token(Token = "0x4002567")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _deleteButton;

		// Token: 0x04002568 RID: 9576
		[Token(Token = "0x4002568")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextLinkHandler _textFieldLinkHandler;

		// Token: 0x0400256C RID: 9580
		[Token(Token = "0x400256C")]
		[FieldOffset(Offset = "0x30")]
		private ChatMessageItem _data;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_MessageHasBeenViewedEvent ---
		void Gameplay_Chat_View_Messages_MessageItemRenderer__add_MessageHasBeenViewedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57b0c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ChatMessageItem__TypeInfo);
		    DAT_ram_00a57b0c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ChatMessageItem__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ChatMessageItem__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_MessageHasBeenViewedEvent ---
		void Gameplay_Chat_View_Messages_MessageItemRenderer__remove_MessageHasBeenViewedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57b0d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ChatMessageItem__TypeInfo);
		    DAT_ram_00a57b0d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ChatMessageItem__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ChatMessageItem__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_DeleteMessageEvent ---
		void Gameplay_Chat_View_Messages_MessageItemRenderer__add_DeleteMessageEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57b0e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ChatMessageItem__TypeInfo);
		    DAT_ram_00a57b0e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ChatMessageItem__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ChatMessageItem__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_DeleteMessageEvent ---
		void Gameplay_Chat_View_Messages_MessageItemRenderer__remove_DeleteMessageEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57b0f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ChatVisitorData__ChatMessageItem__TypeInfo);
		    DAT_ram_00a57b0f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ChatVisitorData__ChatMessageItem__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ChatVisitorData__ChatMessageItem__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_ClickOnUserNickEvent ---
		void Gameplay_Chat_View_Messages_MessageItemRenderer__add_ClickOnUserNickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57b10 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ChatVisitorData__ChatMessageItem__TypeInfo);
		    DAT_ram_00a57b10 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ChatVisitorData__ChatMessageItem__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ChatVisitorData__ChatMessageItem__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_ContentSizeFitter ---
		void Gameplay_Chat_View_Messages_MessageItemRenderer__get_ContentSizeFitter
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57b11 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_TMP_LinkInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Chat_View_Messages_MessageItemRenderer_HandleDeleteButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_Messages_MessageItemRenderer_HandleLinkClickEvent__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57b11 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Chat_View_Messages_MessageItemRenderer_HandleDeleteButtonClickEvent__,0
		            );
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  uVar1 = unnamed_function_1417(System_EventHandler_TMP_LinkInfo__TypeInfo);
		  System_EventHandler_object___Invoke
		            (uVar1,param1,
		             Method_Gameplay_Chat_View_Messages_MessageItemRenderer_HandleLinkClickEvent__,0);
		  UI_Utils_TextLinkHandler__add_LinkClickEvent(uVar2,uVar1,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_Data ---
		void Gameplay_Chat_View_Messages_MessageItemRenderer__get_Data
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x30)) {
		    *(int *)(param1 + 0x30) = param2;
		    Gameplay_Chat_View_Messages_MessageItemRenderer__GetUserMessage(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		int * Gameplay_Chat_View_Messages_MessageItemRenderer__set_Data(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a57b13 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_ChatComplaintData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_ChatUserMessageData_TypeInfo);
		    DAT_ram_00a57b13 = '\x01';
		  }
		  piVar2 = *(int **)(*(int *)(param1 + 0x30) + 0xc);
		  piVar1 = (int *)0x0;
		  if (piVar2 != (int *)0x0) {
		    iVar3 = *piVar2;
		    if (((uint)*(byte *)(iVar3 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Chat_Model_Data_Message_ChatComplaintData_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(iVar3 + 100) +
		                 (uint)*(byte *)(Gameplay_Chat_Model_Data_Message_ChatComplaintData_TypeInfo + 0xb8)
		                 * 4 + -4) != Gameplay_Chat_Model_Data_Message_ChatComplaintData_TypeInfo)) {
		      if (((uint)*(byte *)(iVar3 + 0xb8) <
		           (uint)*(byte *)(Gameplay_Chat_Model_Data_Message_ChatUserMessageData_TypeInfo + 0xb8)) ||
		         (piVar1 = piVar2,
		         *(int *)(*(int *)(iVar3 + 100) +
		                  (uint)*(byte *)(Gameplay_Chat_Model_Data_Message_ChatUserMessageData_TypeInfo +
		                                 0xb8) * 4 + -4) !=
		         Gameplay_Chat_Model_Data_Message_ChatUserMessageData_TypeInfo)) {
		        System_Activator__CreateInstance
		                  (piVar2,Gameplay_Chat_Model_Data_Message_ChatUserMessageData_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else {
		      piVar2 = (int *)piVar2[7];
		      piVar1 = (int *)0x0;
		      if (piVar2 != (int *)0x0) {
		        if (((uint)*(byte *)(Gameplay_Chat_Model_Data_Message_ChatUserMessageData_TypeInfo + 0xb8)
		             <= (uint)*(byte *)(*piVar2 + 0xb8)) &&
		           (*(int *)(*(int *)(*piVar2 + 100) +
		                     (uint)*(byte *)(Gameplay_Chat_Model_Data_Message_ChatUserMessageData_TypeInfo +
		                                    0xb8) * 4 + -4) ==
		            Gameplay_Chat_Model_Data_Message_ChatUserMessageData_TypeInfo)) {
		          return piVar2;
		        }
		        System_Activator__CreateInstance
		                  (piVar2,Gameplay_Chat_Model_Data_Message_ChatUserMessageData_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  return piVar1;
		}
		*/

}
