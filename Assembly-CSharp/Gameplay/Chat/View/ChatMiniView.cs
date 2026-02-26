using System;
using System.Runtime.CompilerServices;
using Gameplay.Chat.Control;
using Gameplay.Chat.Model;
using Gameplay.Chat.View.Messages;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.Counters;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Chat.View
{
	// Token: 0x02000AE8 RID: 2792
	[Token(Token = "0x2000AE8")]
	public class ChatMiniView : MonoBehaviourWithStates<MiniChatViewStates>, IChatView, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06004345 RID: 17221 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D41")]
		public ChatMiniMessagesCarousel MessagesСarousel
		{
			[Token(Token = "0x6004345")]
			[Address(RVA = "0x91F9", Offset = "0x91F9", VA = "0x91F9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x06004346 RID: 17222 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D42")]
		public CounterAutoHide NotViewedMessages
		{
			[Token(Token = "0x6004346")]
			[Address(RVA = "0x91FA", Offset = "0x91FA", VA = "0x91FA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x06004347 RID: 17223 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D43")]
		public TextMeshProUGUI CurrentRoomTitle
		{
			[Token(Token = "0x6004347")]
			[Address(RVA = "0x91FB", Offset = "0x91FB", VA = "0x91FB")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001A2 RID: 418
		// (add) Token: 0x06004348 RID: 17224 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004349 RID: 17225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001A2")]
		public event Action ClickEvent
		{
			[Token(Token = "0x6004348")]
			[Address(RVA = "0x91FC", Offset = "0x91FC", VA = "0x91FC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004349")]
			[Address(RVA = "0x91FD", Offset = "0x91FD", VA = "0x91FD")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600434A")]
		[Address(RVA = "0x91FE", Offset = "0x91FE", VA = "0x91FE")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Chat_View_ChatMiniView__OnDestroy(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param3;
		  int *piVar4;
		  undefined4 param4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a57acf == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Control_ChatMiniViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_MiniChatViewStates__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4180);
		    DAT_ram_00a57acf = '\x01';
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,0xfffffffe,
		             Method_UI_MonoBehaviourWithStates_MiniChatViewStates__set_CurrentState__);
		  piVar4 = *(int **)(param1 + 0x24);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_4180,1,0,1,0,0,0,0);
		  iVar6 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		            (piVar4,uVar2,*(undefined4 *)(iVar6 + 0x2d4));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar4;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x1d8);
		        goto code_r0x80e1eec1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x23);
		code_r0x80e1eec1:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  iVar5 = **(int **)(iVar6 + 0x10);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                    (*(int **)(iVar6 + 0x10),*(undefined4 *)(iVar5 + 0x104));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar4;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x1d8);
		        goto code_r0x80e1ef86;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x23);
		code_r0x80e1ef86:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  iVar5 = **(int **)(iVar6 + 0x10);
		  param3 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x110) * 4))
		                     (*(int **)(iVar6 + 0x10),*(undefined4 *)(iVar5 + 0x114));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar4;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x1d8);
		        goto code_r0x80e1f04b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x23);
		code_r0x80e1f04b:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  param4 = *(undefined4 *)(iVar6 + 0x10);
		  piVar4 = (int *)unnamed_function_1417(Gameplay_Chat_Control_ChatMiniViewMediator_TypeInfo);
		  Gameplay_Chat_Control_ChatController__BanCoroutine_d__20__System_Collections_IEnumerator_get_Current
		            (piVar4,uVar2,param3,param4,0);
		  *(int **)(param1 + 0x30) = piVar4;
		  (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x160) * 4))
		            (piVar4,param1,*(undefined4 *)(*piVar4 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x0600434B RID: 17227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600434B")]
		[Address(RVA = "0x91FF", Offset = "0x91FF", VA = "0x91FF")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Chat_View_ChatMiniView__Awake(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x2c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600434C RID: 17228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600434C")]
		[Address(RVA = "0x9200", Offset = "0x9200", VA = "0x9200", Slot = "5")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Gameplay_Chat_View_ChatMiniView__OnPointerClick(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57ad0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_MiniChatViewStates___ctor__);
		    DAT_ram_00a57ad0 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_MiniChatViewStates___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600434D RID: 17229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600434D")]
		[Address(RVA = "0x9201", Offset = "0x9201", VA = "0x9201")]
		public ChatMiniView()
		{
		}

		// Token: 0x04002514 RID: 9492
		[Token(Token = "0x4002514")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CounterAutoHide _notViewedMessages;

		// Token: 0x04002515 RID: 9493
		[Token(Token = "0x4002515")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _currentRoomTitle;

		// Token: 0x04002516 RID: 9494
		[Token(Token = "0x4002516")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _notAvailiableReasonDescription;

		// Token: 0x04002517 RID: 9495
		[Token(Token = "0x4002517")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ChatMiniMessagesCarousel _messagesСarousel;

		// Token: 0x04002519 RID: 9497
		[Token(Token = "0x4002519")]
		[FieldOffset(Offset = "0x30")]
		private ChatMiniViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CurrentRoomTitle ---
		void Gameplay_Chat_View_ChatMiniView__get_CurrentRoomTitle
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57acd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57acd = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x2c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_Chat_View_ChatMiniView__add_ClickEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57ace == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57ace = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x2c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ClickEvent ---
		void Gameplay_Chat_View_ChatMiniView__remove_ClickEvent(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x30);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x30),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x30) = 0;
		  return;
		}
		*/

}
