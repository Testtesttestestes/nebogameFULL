using System;
using System.Collections.Generic;
using Gameplay.Chat.Model;
using Gameplay.Chat.Model.Data;
using Gameplay.Chat.Model.Data.Message;
using Gameplay.Chat.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Chat.Control
{
	// Token: 0x02000B29 RID: 2857
	[Token(Token = "0x2000B29")]
	public class ChatMiniViewMediator : AbstractViewMediator<ChatModel, ChatEvents, ChatController, ChatMiniView>
	{
		// Token: 0x0600454B RID: 17739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600454B")]
		[Address(RVA = "0x93EF", Offset = "0x93EF", VA = "0x93EF")]
		public ChatMiniViewMediator(ChatModel model, ChatEvents events, ChatController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Chat_Control_ChatMiniViewMediator___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a5793d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatMiniView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_NotViewedMessagesInfoData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_MiniChatButtonStates__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ChatMessageItem__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleCurrentRoomChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleCurrentRoomReadyEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleMessageReceivedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleNoJoinedRoomsEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleNotViewedMessageCountChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleSwitchMiniChatViewEvent__);
		    DAT_ram_00a5793d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x4c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleNoJoinedRoomsEvent__,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x4c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x4c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x50);
		    uVar3 = unnamed_function_1417(System_Action_MiniChatButtonStates__TypeInfo);
		    System_Action_byte___Invoke
		              (uVar3,param1,
		               Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleSwitchMiniChatViewEvent__,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_MiniChatButtonStates__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x50) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_MiniChatButtonStates__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x50) = iVar5;
		      uVar3 = System_Action_MiniChatButtonStates__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_MiniChatButtonStates__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x40);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleCurrentRoomChangedEvent__,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x40) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x40) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x30);
		    uVar3 = unnamed_function_1417(System_Action_ChatMessageItem__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleMessageReceivedEvent__,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_ChatMessageItem__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x30) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_ChatMessageItem__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x30) = iVar5;
		      uVar3 = System_Action_ChatMessageItem__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_ChatMessageItem__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x44);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleCurrentRoomReadyEvent__,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x44) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x44) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x48);
		    uVar3 = unnamed_function_1417(System_Action_NotViewedMessagesInfoData__TypeInfo);
		    System_Action_NamedValue___Invoke
		              (uVar3,param1,
		               Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleNotViewedMessageCountChangedEvent__
		               ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_NotViewedMessagesInfoData__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x48) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_NotViewedMessagesInfoData__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x48) = iVar5;
		      uVar3 = System_Action_NotViewedMessagesInfoData__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_NotViewedMessagesInfoData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x4c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleNoJoinedRoomsEvent__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x4c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x4c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x50);
		    uVar3 = unnamed_function_1417(System_Action_MiniChatButtonStates__TypeInfo);
		    System_Action_byte___Invoke
		              (uVar3,param1,
		               Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleSwitchMiniChatViewEvent__,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_MiniChatButtonStates__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x50) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_MiniChatButtonStates__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x50) = iVar5;
		      uVar3 = System_Action_MiniChatButtonStates__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_MiniChatButtonStates__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x40);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleCurrentRoomChangedEvent__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x40) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x40) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x30);
		    uVar3 = unnamed_function_1417(System_Action_ChatMessageItem__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleMessageReceivedEvent__,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_ChatMessageItem__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x30) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_ChatMessageItem__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x30) = iVar5;
		      uVar3 = System_Action_ChatMessageItem__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_ChatMessageItem__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x44);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleCurrentRoomReadyEvent__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x44) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x44) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x48);
		    uVar3 = unnamed_function_1417(System_Action_NotViewedMessagesInfoData__TypeInfo);
		    System_Action_NamedValue___Invoke
		              (uVar3,param1,
		               Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleNotViewedMessageCountChangedEvent__
		               ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_NotViewedMessagesInfoData__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x48) = 0;
		      return;
		    }
		    iVar5 = func_ii_1082(iVar2,System_Action_NotViewedMessagesInfoData__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x48) = iVar5;
		    uVar3 = System_Action_NotViewedMessagesInfoData__TypeInfo;
		    iVar1 = func_ii_1082(iVar2,System_Action_NotViewedMessagesInfoData__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000DAF RID: 3503
		// (set) Token: 0x0600454C RID: 17740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DAF")]
		public override ChatEvents Events
		{
			[Token(Token = "0x600454C")]
			[Address(RVA = "0x93F0", Offset = "0x93F0", VA = "0x93F0", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000DB0 RID: 3504
		// (set) Token: 0x0600454D RID: 17741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DB0")]
		public override ChatMiniView View
		{
			[Token(Token = "0x600454D")]
			[Address(RVA = "0x93F1", Offset = "0x93F1", VA = "0x93F1", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600454E")]
		[Address(RVA = "0x93F2", Offset = "0x93F2", VA = "0x93F2")]
		private void SetupView()
		{
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600454F")]
		[Address(RVA = "0x93F3", Offset = "0x93F3", VA = "0x93F3")]
		private void DefineCurrentViewState()
		{
		/* --- GHIDRA: DefineCurrentViewState ---
		void Gameplay_Chat_Control_ChatMiniViewMediator__DefineCurrentViewState
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param2_00;
		  int iVar4;
		  int param2_01;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  int *piVar8;
		  
		  if (DAT_ram_00a57940 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatMiniView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ChatMessageItem__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_ChatMessageItem__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    DAT_ram_00a57940 = '\x01';
		  }
		  if (*(char *)(param1[2] + 0x49) == -1) {
		    uVar1 = 0;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel__GetPool(*(undefined4 *)(iVar2 + 0x28),0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = *(undefined4 *)(*(int *)(iVar2 + 0x28) + 0x18);
		    iVar2 = *param2;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_ICollection_ChatMessageItem__TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e045e7;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_ICollection_ChatMessageItem__TypeInfo,0
		                                 );
		code_r0x80e045e7:
		    iVar2 = 0;
		    param2_00 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    iVar4 = UnityEngine_Mathf__Min(uVar5,param2_00,0);
		    if (0 < iVar4) {
		      do {
		        param2_01 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,1);
		        iVar6 = *param2;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_ICollection_ChatMessageItem__TypeInfo == *piVar8) {
		              puVar3 = (uint *)(iVar6 + piVar8[1] * 8 + 0xc0);
		              goto code_r0x80e046a2;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(param2,
		                                      System_Collections_Generic_ICollection_ChatMessageItem__TypeInfo
		                                      ,0);
		code_r0x80e046a2:
		        iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		        iVar7 = *param2;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IList_ChatMessageItem__TypeInfo == *piVar8) {
		              puVar3 = (uint *)(iVar7 + piVar8[1] * 8 + 0xc0);
		              goto code_r0x80e04726;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(param2,
		                                      System_Collections_Generic_IList_ChatMessageItem__TypeInfo,0);
		code_r0x80e04726:
		        iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(param2,iVar6 + (iVar2 - iVar4),puVar3[1]);
		        iVar7 = **(int **)(iVar6 + 0xc);
		        uVar5 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0xf0) * 4))
		                          (*(int **)(iVar6 + 0xc),1,*(undefined4 *)(iVar7 + 0xf4));
		        *(undefined4 *)(param2_01 + 0x10) = uVar5;
		        iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel__GetMoveDuration
		                  (*(undefined4 *)(iVar6 + 0x28),param2_01,0);
		        iVar2 = iVar2 + 1;
		      } while (iVar2 != iVar4);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004550 RID: 17744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004550")]
		[Address(RVA = "0x93F4", Offset = "0x93F4", VA = "0x93F4")]
		private void HandleLastMessagesForCurrentRoom(IList<ChatMessageItem> messages)
		{
		}

		// Token: 0x06004551 RID: 17745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004551")]
		[Address(RVA = "0x93F5", Offset = "0x93F5", VA = "0x93F5")]
		private void HandleNotViewedMessages(in NotViewedMessagesInfoData info)
		{
		/* --- GHIDRA: HandleNotViewedMessages ---
		void Gameplay_Chat_Control_ChatMiniViewMediator__HandleNotViewedMessages
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57942 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_MiniChatViewStates__get_CurrentState__);
		    DAT_ram_00a57942 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(iVar1 + 0x18) != -1) {
		    Gameplay_Chat_Control_ChatMiniViewMediator__AddMessageToView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004552 RID: 17746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004552")]
		[Address(RVA = "0x93F6", Offset = "0x93F6", VA = "0x93F6")]
		private void HandleCLickEvent()
		{
		/* --- GHIDRA: HandleCLickEvent ---
		void Gameplay_Chat_Control_ChatMiniViewMediator__HandleCLickEvent(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  uint param2_00;
		  
		  if (DAT_ram_00a5793f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatMiniView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_MiniChatViewStates__set_CurrentState__);
		    DAT_ram_00a5793f = '\x01';
		  }
		  iVar1 = *(int *)(param1[2] + 0x30);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar1 == 0) {
		    param2_00 = 0xffffffff;
		  }
		  else {
		    param2_00 = (uint)*(byte *)(param1[2] + 0x49);
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1_00,param2_00,
		             Method_UI_MonoBehaviourWithStates_MiniChatViewStates__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x06004553 RID: 17747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004553")]
		[Address(RVA = "0x93F7", Offset = "0x93F7", VA = "0x93F7")]
		private void HandleNoJoinedRoomsEvent()
		{
		/* --- GHIDRA: HandleNoJoinedRoomsEvent ---
		void Gameplay_Chat_Control_ChatMiniViewMediator__HandleNoJoinedRoomsEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  int iVar2;
		  undefined4 local_8 [2];
		  
		  if (DAT_ram_00a57943 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatMiniView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_MiniChatViewStates__set_CurrentState__);
		    DAT_ram_00a57943 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar1,param2,Method_UI_MonoBehaviourWithStates_MiniChatViewStates__set_CurrentState__);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  uVar1 = Gameplay_Chat_Control_ChatController__FilterMessage(uVar1,0);
		  Gameplay_Chat_Control_ChatMiniViewMediator__DefineCurrentViewState(param1,uVar1,param1);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  param3_00 = Gameplay_Chat_Model_ChatModel__AddRoom(param1[2],0);
		  Gameplay_Chat_Control_ChatController__GetRoomMessages(local_8,uVar1,param3_00,0);
		  if (DAT_ram_00a57941 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatMiniView__get_Model__
		              );
		    DAT_ram_00a57941 = '\x01';
		  }
		  if (*(char *)(param1[2] + 0x49) == '\0') {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Collections_Generic_Dictionary_int__object___get_Count
		              (*(undefined4 *)(iVar2 + 0x1c),local_8[0],0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004554 RID: 17748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004554")]
		[Address(RVA = "0x93F8", Offset = "0x93F8", VA = "0x93F8")]
		private void HandleSwitchMiniChatViewEvent(MiniChatButtonStates state)
		{
		/* --- GHIDRA: HandleSwitchMiniChatViewEvent ---
		void Gameplay_Chat_Control_ChatMiniViewMediator__HandleSwitchMiniChatViewEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57944 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatMiniView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    DAT_ram_00a57944 = '\x01';
		  }
		  if (*(char *)(param1[2] + 0x49) == -1) {
		    param2_00 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,1);
		    iVar2 = **(int **)(param2 + 0xc);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xf0) * 4))
		                      (*(int **)(param2 + 0xc),1,*(undefined4 *)(iVar2 + 0xf4));
		    *(undefined4 *)(param2_00 + 0x10) = uVar1;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel__GetMoveDuration
		              (*(undefined4 *)(iVar2 + 0x28),param2_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004555 RID: 17749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004555")]
		[Address(RVA = "0x93F9", Offset = "0x93F9", VA = "0x93F9")]
		private void HandleMessageReceivedEvent(ChatMessageItem messageItem)
		{
		/* --- GHIDRA: HandleMessageReceivedEvent ---
		void Gameplay_Chat_Control_ChatMiniViewMediator__HandleMessageReceivedEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param3;
		  int iVar2;
		  int *piVar3;
		  uint param2_00;
		  undefined4 local_8 [2];
		  
		  if (DAT_ram_00a57945 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatMiniView__get_Model__
		              );
		    DAT_ram_00a57945 = '\x01';
		  }
		  if (DAT_ram_00a5793f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatMiniView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_MiniChatViewStates__set_CurrentState__);
		    DAT_ram_00a5793f = '\x01';
		  }
		  iVar2 = *(int *)(param1[2] + 0x30);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar2 == 0) {
		    param2_00 = 0xffffffff;
		  }
		  else {
		    param2_00 = (uint)*(byte *)(param1[2] + 0x49);
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar1,param2_00,
		             Method_UI_MonoBehaviourWithStates_MiniChatViewStates__set_CurrentState__);
		  if (*(int *)(param1[2] + 0x30) != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar3 = *(int **)(iVar2 + 0x20);
		    uVar1 = Core_Extensions_Dict_ChatBanDicExt__GetDescription
		                      (*(undefined4 *)(*(int *)(param1[2] + 0x30) + 0x1c),0);
		    uVar1 = System_Uri__get_Authority(uVar1,0);
		    iVar2 = *piVar3;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		              (piVar3,uVar1,*(undefined4 *)(iVar2 + 0x2d4));
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    param3 = Gameplay_Chat_Model_ChatModel__AddRoom(param1[2],0);
		    Gameplay_Chat_Control_ChatController__GetRoomMessages(local_8,uVar1,param3,0);
		    if (DAT_ram_00a57941 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatMiniView__get_Model__
		                );
		      DAT_ram_00a57941 = '\x01';
		    }
		    if (*(char *)(param1[2] + 0x49) == '\0') {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      System_Collections_Generic_Dictionary_int__object___get_Count
		                (*(undefined4 *)(iVar2 + 0x1c),local_8[0],0);
		    }
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    uVar1 = Gameplay_Chat_Control_ChatController__FilterMessage(uVar1,0);
		    Gameplay_Chat_Control_ChatMiniViewMediator__DefineCurrentViewState(param1,uVar1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004556 RID: 17750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004556")]
		[Address(RVA = "0x93FA", Offset = "0x93FA", VA = "0x93FA")]
		private void HandleCurrentRoomChangedEvent()
		{
		/* --- GHIDRA: HandleCurrentRoomChangedEvent ---
		void Gameplay_Chat_Control_ChatMiniViewMediator__HandleCurrentRoomChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param3;
		  int iVar2;
		  undefined4 local_8 [2];
		  
		  if (DAT_ram_00a57946 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatMiniView__get_Model__
		              );
		    DAT_ram_00a57946 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  param3 = Gameplay_Chat_Model_ChatModel__AddRoom(param1[2],0);
		  Gameplay_Chat_Control_ChatController__GetRoomMessages(local_8,uVar1,param3,0);
		  if (DAT_ram_00a57941 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatMiniView__get_Model__
		              );
		    DAT_ram_00a57941 = '\x01';
		  }
		  if (*(char *)(param1[2] + 0x49) == '\0') {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Collections_Generic_Dictionary_int__object___get_Count
		              (*(undefined4 *)(iVar2 + 0x1c),local_8[0],0);
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  uVar1 = Gameplay_Chat_Control_ChatController__FilterMessage(uVar1,0);
		  Gameplay_Chat_Control_ChatMiniViewMediator__DefineCurrentViewState(param1,uVar1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004557 RID: 17751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004557")]
		[Address(RVA = "0x93FB", Offset = "0x93FB", VA = "0x93FB")]
		private void HandleCurrentRoomReadyEvent()
		{
		/* --- GHIDRA: HandleCurrentRoomReadyEvent ---
		void Gameplay_Chat_Control_ChatMiniViewMediator__HandleCurrentRoomReadyEvent
		               (int *param1,undefined4 *param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57941 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatMiniView__get_Model__
		              );
		    DAT_ram_00a57941 = '\x01';
		  }
		  if (*(char *)(param1[2] + 0x49) == '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Collections_Generic_Dictionary_int__object___get_Count
		              (*(undefined4 *)(iVar1 + 0x1c),*param2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004558 RID: 17752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004558")]
		[Address(RVA = "0x93FC", Offset = "0x93FC", VA = "0x93FC")]
		private void HandleNotViewedMessageCountChangedEvent(NotViewedMessagesInfoData info)
		{
		/* --- GHIDRA: HandleNotViewedMessageCountChangedEvent ---
		void Gameplay_Chat_Control_ChatMiniViewMediator__HandleNotViewedMessageCountChangedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel__GetMoveDuration
		            (*(undefined4 *)(iVar1 + 0x28),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06004559 RID: 17753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004559")]
		[Address(RVA = "0x93FD", Offset = "0x93FD", VA = "0x93FD")]
		private void AddMessageToView(params string[] texts)
		{
		/* --- GHIDRA: AddMessageToView ---
		void Gameplay_Chat_Control_ChatMiniViewMediator__AddMessageToView(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57947 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleCloseChatWindow__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_View_ChatWindow_ChatWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_ChatWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12585);
		    DAT_ram_00a57947 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  uVar2 = unnamed_function_1417(Gameplay_Chat_View_ChatWindow_ChatWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(uVar2,0);
		  uVar1 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar1,StringLiteral_12585,uVar2,
		                     Method_UI_Windows_PopupController_Show_ChatWindow___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleCloseChatWindow__,
		             0);
		  UI_Windows_BaseWindow__get_IsActiveResourceBar(uVar1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600455A RID: 17754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600455A")]
		[Address(RVA = "0x93FE", Offset = "0x93FE", VA = "0x93FE")]
		public void ShowChat()
		{
		/* --- GHIDRA: ShowChat ---
		void Gameplay_Chat_Control_ChatMiniViewMediator__ShowChat(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57948 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleCloseChatWindow__);
		    DAT_ram_00a57948 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x18);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleCloseChatWindow__,0);
		  UI_Windows_BaseWindow__add_onClose(param1_01,param1_00,0);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600455B RID: 17755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600455B")]
		[Address(RVA = "0x93FF", Offset = "0x93FF", VA = "0x93FF")]
		private void HandleCloseChatWindow()
		{
		/* --- GHIDRA: HandleCloseChatWindow ---
		int Gameplay_Chat_Control_ChatMiniViewMediator__HandleCloseChatWindow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57949 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a57949 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		  if (iVar1 != 0) {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		    UI_Windows_PopupController__Show(uVar2,*(undefined4 *)(param1 + 0x18),2,0);
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x0600455C RID: 17756 RVA: 0x0000D110 File Offset: 0x0000B310
		[Token(Token = "0x600455C")]
		[Address(RVA = "0x9400", Offset = "0x9400", VA = "0x9400")]
		public bool TryCloseChat()
		{
		/* --- GHIDRA: TryCloseChat ---
		void Gameplay_Chat_Control_ChatMiniViewMediator__TryCloseChat
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a5794a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatView___ctor__
		              );
		    DAT_ram_00a5794a = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatView___ctor__
		            );
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x04002603 RID: 9731
		[Token(Token = "0x4002603")]
		[FieldOffset(Offset = "0x18")]
		private ChatWindow _chatWindow;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Chat_Control_ChatMiniViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5793e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatMiniView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleCLickEvent__);
		    DAT_ram_00a5793e = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleCLickEvent__,0);
		    Gameplay_Chat_View_ChatMiniView__add_ClickEvent(uVar1,uVar3,0);
		    if (DAT_ram_00a57949 == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		      DAT_ram_00a57949 = '\x01';
		    }
		    iVar2 = param1[6];
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar2 = UnityEngine_Component__GetComponent_object_(iVar2,0);
		    if (iVar2 != 0) {
		      uVar1 = System_Uri___ctor(0);
		      uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		      UI_Windows_PopupController__Show(uVar1,param1[6],2,0);
		    }
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Chat_Control_ChatMiniViewMediator__HandleMessageReceivedEvent(param1,param1);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Chat_Control_ChatMiniViewMediator_HandleCLickEvent__,0);
		    Gameplay_Chat_View_ChatMiniView__get_CurrentRoomTitle(uVar1,uVar3,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Chat_Control_ChatMiniViewMediator__set_View(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Chat_Control_ChatMiniViewMediator__HandleMessageReceivedEvent(param1,param1);
		  return;
		}
		*/

}
