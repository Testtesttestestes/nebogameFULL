using System;
using Gameplay.Chat.Model;
using Gameplay.Chat.Model.Data;
using Gameplay.Chat.Model.Data.Message;
using Gameplay.Chat.View;
using Il2CppDummyDll;
using MVC;
using UI.Tabs;
using UnityEngine.EventSystems;

namespace Gameplay.Chat.Control
{
	// Token: 0x02000B2A RID: 2858
	[Token(Token = "0x2000B2A")]
	public class ChatViewMediator : AbstractViewMediator<ChatModel, ChatEvents, ChatController, ChatView>
	{
		// Token: 0x0600455D RID: 17757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600455D")]
		[Address(RVA = "0x9401", Offset = "0x9401", VA = "0x9401")]
		public ChatViewMediator(ChatModel model, ChatEvents events, ChatController controller)
		{
		/* --- GHIDRA: <HandleMessageDeleteRequestEvent>b__31_0 ---
		void Gameplay_Chat_Control_ChatViewMediator___HandleMessageDeleteRequestEvent_b__31_0
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5795c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_CaveModel__CaveEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_CommandsRepository_TypeInfo);
		    DAT_ram_00a5795c = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_CaveModel__CaveEvents___ctor__);
		  param1_00 = unnamed_function_1417(Utils_CommandsRepository_TypeInfo);
		  Utils_ColorUtil__SetRGB(param1_00,3.0,0);
		  *(undefined4 *)(param1 + 0x1c) = param1_00;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Chat_Control_ChatViewMediator___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a5794b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ChatMessageItem____TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_NotViewedMessagesInfoData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ChatVisitorData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ChatRoomData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ChatMessageItem__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_InputMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatViewMediator_HandleContactAddedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatViewMediator_HandleContactListReceivedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatViewMediator_HandleContactRemovedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatViewMediator_HandleCurrentRoomChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatViewMediator_HandleCurrentRoomReadyEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatViewMediator_HandleMessageReceivedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatViewMediator_HandleMessagesRemovedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleNotViewedMessageCountChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatViewMediator_HandleRoomAddedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatViewMediator_HandleRoomRemovedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatViewMediator_HandleStartWriteMessageToUserEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatViewMediator_HandleUserJoinedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatViewMediator_HandleUserLeftEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatViewMediator_HandleUserUpdatedEvent__);
		    DAT_ram_00a5794b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x3c);
		    uVar2 = unnamed_function_1417(System_Action_ChatRoomData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,Method_Gameplay_Chat_Control_ChatViewMediator_HandleRoomAddedEvent__,0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_ChatRoomData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x3c) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ChatRoomData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x3c) = iVar4;
		      uVar2 = System_Action_ChatRoomData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ChatRoomData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x38);
		    uVar2 = unnamed_function_1417(System_Action_ChatRoomData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,Method_Gameplay_Chat_Control_ChatViewMediator_HandleRoomRemovedEvent__,0
		              );
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_ChatRoomData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x38) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ChatRoomData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x38) = iVar4;
		      uVar2 = System_Action_ChatRoomData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ChatRoomData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x40);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleCurrentRoomChangedEvent__,0);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x40) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x40) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x44);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleCurrentRoomReadyEvent__,0);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x44) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x44) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x28);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleContactListReceivedEvent__,0);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x28) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x28) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_ChatVisitorData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,Method_Gameplay_Chat_Control_ChatViewMediator_HandleUserJoinedEvent__,0)
		    ;
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_ChatVisitorData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar4;
		      uVar2 = System_Action_ChatVisitorData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_ChatVisitorData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,Method_Gameplay_Chat_Control_ChatViewMediator_HandleUserLeftEvent__,0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_ChatVisitorData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x1c) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x1c) = iVar4;
		      uVar2 = System_Action_ChatVisitorData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x24);
		    uVar2 = unnamed_function_1417(System_Action_ChatVisitorData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,Method_Gameplay_Chat_Control_ChatViewMediator_HandleContactAddedEvent__,
		               0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_ChatVisitorData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x24) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x24) = iVar4;
		      uVar2 = System_Action_ChatVisitorData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x20);
		    uVar2 = unnamed_function_1417(System_Action_ChatVisitorData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleContactRemovedEvent__,0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_ChatVisitorData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x20) = iVar4;
		      uVar2 = System_Action_ChatVisitorData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_ChatVisitorData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,Method_Gameplay_Chat_Control_ChatViewMediator_HandleUserUpdatedEvent__,0
		              );
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_ChatVisitorData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x14) = iVar4;
		      uVar2 = System_Action_ChatVisitorData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x30);
		    uVar2 = unnamed_function_1417(System_Action_ChatMessageItem__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleMessageReceivedEvent__,0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_ChatMessageItem__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x30) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ChatMessageItem__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x30) = iVar4;
		      uVar2 = System_Action_ChatMessageItem__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ChatMessageItem__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x34);
		    uVar2 = unnamed_function_1417(System_Action_ChatMessageItem____TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleMessagesRemovedEvent__,0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_ChatMessageItem____TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x34) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ChatMessageItem____TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x34) = iVar4;
		      uVar2 = System_Action_ChatMessageItem____TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ChatMessageItem____TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x54);
		    uVar2 = unnamed_function_1417(System_Action_InputMessage__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleStartWriteMessageToUserEvent__,0)
		    ;
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_InputMessage__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x54) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_InputMessage__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x54) = iVar4;
		      uVar2 = System_Action_InputMessage__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_InputMessage__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x48);
		    uVar2 = unnamed_function_1417(System_Action_NotViewedMessagesInfoData__TypeInfo);
		    System_Action_NamedValue___Invoke
		              (uVar2,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleNotViewedMessageCountChangedEvent__
		               ,0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_NotViewedMessagesInfoData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x48) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_NotViewedMessagesInfoData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x48) = iVar4;
		      uVar2 = System_Action_NotViewedMessagesInfoData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_NotViewedMessagesInfoData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x3c);
		    uVar2 = unnamed_function_1417(System_Action_ChatRoomData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,Method_Gameplay_Chat_Control_ChatViewMediator_HandleRoomAddedEvent__,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_ChatRoomData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x3c) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ChatRoomData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x3c) = iVar4;
		      uVar2 = System_Action_ChatRoomData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ChatRoomData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x38);
		    uVar2 = unnamed_function_1417(System_Action_ChatRoomData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,Method_Gameplay_Chat_Control_ChatViewMediator_HandleRoomRemovedEvent__,0
		              );
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_ChatRoomData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x38) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ChatRoomData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x38) = iVar4;
		      uVar2 = System_Action_ChatRoomData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ChatRoomData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x40);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleCurrentRoomChangedEvent__,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x40) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x40) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x44);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleCurrentRoomReadyEvent__,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x44) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x44) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_ChatVisitorData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,Method_Gameplay_Chat_Control_ChatViewMediator_HandleUserJoinedEvent__,0)
		    ;
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_ChatVisitorData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar4;
		      uVar2 = System_Action_ChatVisitorData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_ChatVisitorData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,Method_Gameplay_Chat_Control_ChatViewMediator_HandleUserLeftEvent__,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_ChatVisitorData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x1c) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x1c) = iVar4;
		      uVar2 = System_Action_ChatVisitorData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x24);
		    uVar2 = unnamed_function_1417(System_Action_ChatVisitorData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,Method_Gameplay_Chat_Control_ChatViewMediator_HandleContactAddedEvent__,
		               0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_ChatVisitorData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x24) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x24) = iVar4;
		      uVar2 = System_Action_ChatVisitorData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x20);
		    uVar2 = unnamed_function_1417(System_Action_ChatVisitorData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleContactRemovedEvent__,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_ChatVisitorData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x20) = iVar4;
		      uVar2 = System_Action_ChatVisitorData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_ChatVisitorData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,Method_Gameplay_Chat_Control_ChatViewMediator_HandleUserUpdatedEvent__,0
		              );
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_ChatVisitorData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x14) = iVar4;
		      uVar2 = System_Action_ChatVisitorData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x30);
		    uVar2 = unnamed_function_1417(System_Action_ChatMessageItem__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleMessageReceivedEvent__,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_ChatMessageItem__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x30) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ChatMessageItem__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x30) = iVar4;
		      uVar2 = System_Action_ChatMessageItem__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ChatMessageItem__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x34);
		    uVar2 = unnamed_function_1417(System_Action_ChatMessageItem____TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleMessagesRemovedEvent__,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_ChatMessageItem____TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x34) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ChatMessageItem____TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x34) = iVar4;
		      uVar2 = System_Action_ChatMessageItem____TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ChatMessageItem____TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x54);
		    uVar2 = unnamed_function_1417(System_Action_InputMessage__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleStartWriteMessageToUserEvent__,0)
		    ;
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_InputMessage__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x54) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_InputMessage__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x54) = iVar4;
		      uVar2 = System_Action_InputMessage__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_InputMessage__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x48);
		    uVar2 = unnamed_function_1417(System_Action_NotViewedMessagesInfoData__TypeInfo);
		    System_Action_NamedValue___Invoke
		              (uVar2,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleNotViewedMessageCountChangedEvent__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_NotViewedMessagesInfoData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x48) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar3,System_Action_NotViewedMessagesInfoData__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x48) = iVar4;
		    uVar2 = System_Action_NotViewedMessagesInfoData__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_NotViewedMessagesInfoData__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000DB1 RID: 3505
		// (set) Token: 0x0600455E RID: 17758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DB1")]
		public override ChatEvents Events
		{
			[Token(Token = "0x600455E")]
			[Address(RVA = "0x9402", Offset = "0x9402", VA = "0x9402", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000DB2 RID: 3506
		// (set) Token: 0x0600455F RID: 17759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DB2")]
		public override ChatView View
		{
			[Token(Token = "0x600455F")]
			[Address(RVA = "0x9403", Offset = "0x9403", VA = "0x9403", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004560 RID: 17760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004560")]
		[Address(RVA = "0x9404", Offset = "0x9404", VA = "0x9404")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Chat_Control_ChatViewMediator__SetupView(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5794e == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5794e = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Gameplay_Chat_Control_ChatController__RemoveFromFavorites
		                    (uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x34) + 0x10) + 0x160),0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    TMPro_TMP_InputField__set_text(*(undefined4 *)(*(int *)(iVar2 + 0x34) + 0x10),StringLiteral_5,0)
		    ;
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Chat_View_ChatView__SetBan(uVar1,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Chat_View_ChatView__ShowSmilePanel(uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004561 RID: 17761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004561")]
		[Address(RVA = "0x9405", Offset = "0x9405", VA = "0x9405")]
		private void SendMessage()
		{
		/* --- GHIDRA: SendMessage ---
		int * Gameplay_Chat_Control_ChatViewMediator__SendMessage(int *param1,int param2,undefined4 param3)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int param1_00;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  undefined1 auStack_8 [4];
		  int local_4;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a5794f == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_ChatRoomData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_ChatRoomData__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_ChatRoomData__TypeInfo);
		    DAT_ram_00a5794f = '\x01';
		  }
		  piVar1 = (int *)Mono_Security_ASN1Convert__ToOid
		                            (UI_Tabs_TabBarItemData___TypeInfo,*(undefined4 *)(param2 + 0xc));
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Chat_Control_ChatController__GetRoomMessages(auStack_8,uVar2,param2,0);
		  iVar3 = *(int *)(param2 + 0xc);
		  if (0 < iVar3) {
		    do {
		      iVar4 = *(int *)(param2 + iVar5 * 4 + 0x10);
		      param1_00 = unnamed_function_1417(UI_Tabs_TabBarItemData_ChatRoomData__TypeInfo);
		      uVar2 = Core_Extensions_Dict_ChatBanDicExt__GetDescription(*(undefined4 *)(iVar4 + 0x1c),0);
		      *(int *)(param1_00 + 0x20) = iVar4;
		      *(undefined4 *)(param1_00 + 0x10) = uVar2;
		      Core_Extensions_Dict_BossGroupDictExt__GetTitle
		                (param1_00,*(undefined4 *)(iVar5 * 4 + local_4 + 0x10),0);
		      iVar4 = func_ii_1082(param1_00,*(undefined4 *)(*piVar1 + 0x20));
		      if (iVar4 == 0) {
		        uVar2 = func_ii_1083();
		        func_ii_1050(uVar2,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar1[iVar5 + 4] = param1_00;
		      iVar5 = iVar5 + 1;
		    } while (iVar5 != iVar3);
		  }
		  return piVar1;
		}
		*/

		}

		// Token: 0x06004562 RID: 17762 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004562")]
		[Address(RVA = "0x9406", Offset = "0x9406", VA = "0x9406")]
		private TabBarItemData[] RoomsToTabs(ChatRoomData[] items)
		{
		/* --- GHIDRA: RoomsToTabs ---
		void Gameplay_Chat_Control_ChatViewMediator__RoomsToTabs(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int param3;
		  
		  if (DAT_ram_00a57950 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatView__get_Model__
		              );
		    DAT_ram_00a57950 = '\x01';
		  }
		  iVar1 = Gameplay_Chat_Model_ChatModel__AddRoom(param1[2],0);
		  param3 = *param1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(param3 + 0x158) * 4))
		                    (param1,*(undefined4 *)(param3 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar2 + 0x1c);
		  param2_00 = Gameplay_Chat_Control_ChatViewMediator__SendMessage(param1,iVar1,param3);
		  UI_Tabs_TabBar__HandleSelected(param1_00,param2_00,0);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    iVar2 = 0;
		    do {
		      if (*(int *)(iVar1 + iVar2 * 4 + 0x10) == *(int *)(param1[2] + 0x30)) {
		        iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		                  (*(undefined4 *)(iVar1 + 0x1c),iVar2,0,0);
		        return;
		      }
		      iVar2 = iVar2 + 1;
		    } while (iVar2 != *(int *)(iVar1 + 0xc));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004563 RID: 17763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004563")]
		[Address(RVA = "0x9407", Offset = "0x9407", VA = "0x9407")]
		private void HandleRoomsChanges()
		{
		/* --- GHIDRA: HandleRoomsChanges ---
		void Gameplay_Chat_Control_ChatViewMediator__HandleRoomsChanges
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param3_00;
		  undefined4 uVar2;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57951 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_ContextMenu_ChatMenuContext_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_ContextMenu_ContextMenuController_Show_IChatMenuContext__UserContextMenu___
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_InputSystem_InputControl_Vector2__ReadValue__);
		    DAT_ram_00a57951 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = Google_Protobuf_Reflection_EnumValueDescriptor__get_Name(uVar1,0);
		  param3_00 = unnamed_function_1417(Gameplay_Chat_Model_Data_ContextMenu_ChatMenuContext_TypeInfo);
		  *(undefined4 *)(param3_00 + 0xc) = param3;
		  *(undefined4 *)(param3_00 + 8) = param2;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  *(undefined4 *)(param3_00 + 0x10) = uVar2;
		  if (DAT_ram_00a5a202 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_InputSystem_Pointer_TypeInfo);
		    DAT_ram_00a5a202 = '\x01';
		  }
		  UnityEngine_InputSystem_InputControl_Vector2___ReadUnprocessedValue
		            (&local_8,*(undefined4 *)
		                       (**(int **)(UnityEngine_InputSystem_Pointer_TypeInfo + 0x5c) + 0xe8),
		             Method_UnityEngine_InputSystem_InputControl_Vector2__ReadValue__);
		  local_10 = local_8;
		  UI_ContextMenu_ContextMenuController___Show_b__13_0___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		            (uVar1,1,param3_00,&local_10,
		             Method_UI_ContextMenu_ContextMenuController_Show_IChatMenuContext__UserContextMenu___);
		  return;
		}
		*/

		}

		// Token: 0x06004564 RID: 17764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004564")]
		[Address(RVA = "0x9408", Offset = "0x9408", VA = "0x9408")]
		private void ShowVisitorContextMenu(ChatVisitorData visitor, ChatMessageItem messageItem)
		{
		}

		// Token: 0x06004565 RID: 17765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004565")]
		[Address(RVA = "0x9409", Offset = "0x9409", VA = "0x9409")]
		private void HandleRoomRemovedEvent(ChatRoomData room)
		{
		/* --- GHIDRA: HandleRoomRemovedEvent ---
		void Gameplay_Chat_Control_ChatViewMediator__HandleRoomRemovedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Chat_Control_ChatViewMediator__RoomsToTabs(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004566 RID: 17766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004566")]
		[Address(RVA = "0x940A", Offset = "0x940A", VA = "0x940A")]
		private void HandleRoomAddedEvent(ChatRoomData room)
		{
		/* --- GHIDRA: HandleRoomAddedEvent ---
		void Gameplay_Chat_Control_ChatViewMediator__HandleRoomAddedEvent(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57952 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ChatVisitorData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ChatVisitorData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ChatViewStates__set_CurrentState__);
		    DAT_ram_00a57952 = '\x01';
		  }
		  if (*(int *)(param1[2] + 0x30) == 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_MonoBehaviourWithStates_ByteEnum___remove_CurrentStateChangedEvent
		              (uVar1,1,Method_UI_MonoBehaviourWithStates_ChatViewStates__set_CurrentState__);
		    if (*(char *)(param1[2] + 0x48) == '\0') {
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar3 = unnamed_function_1417(System_Collections_Generic_List_ChatVisitorData__TypeInfo);
		      Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		                (uVar3,0,Method_System_Collections_Generic_List_ChatVisitorData___ctor__);
		      Gameplay_Chat_View_ChatView__HandleCurrentStateChanged(uVar1,uVar3,0);
		    }
		  }
		  else {
		    uVar1 = Google_Protobuf_Reflection_ServiceDescriptor___ctor(*(int *)(param1[2] + 0x30),0);
		    iVar2 = Protocol_Common_Location__Equals(uVar1,*(undefined4 *)(param1[2] + 0xc),0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = 2;
		    if (iVar2 == 0) {
		      uVar3 = 1;
		    }
		    UI_MonoBehaviourWithStates_ByteEnum___remove_CurrentStateChangedEvent
		              (uVar1,uVar3,Method_UI_MonoBehaviourWithStates_ChatViewStates__set_CurrentState__);
		    if (*(char *)(param1[2] + 0x48) == '\0') {
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Gameplay_Chat_View_ChatView__HandleCurrentStateChanged
		                (uVar1,*(undefined4 *)(*(int *)(param1[2] + 0x30) + 8),0);
		    }
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar2 + 0x44);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  uVar1 = Gameplay_Chat_Control_ChatController__FilterMessage(uVar1,0);
		  Gameplay_Chat_View_Messages_MessagesListAdapter__OnEnable(uVar3,uVar1,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Chat_View_ChatView__RemoveVisitor(uVar1,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Chat_View_ChatView__ScrollMessagesDown
		            (uVar1,*(undefined4 *)(*(int *)(param1[2] + 0x2c) + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x06004567 RID: 17767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004567")]
		[Address(RVA = "0x940B", Offset = "0x940B", VA = "0x940B")]
		private void HandleCurrentRoomChangedEvent()
		{
		/* --- GHIDRA: HandleCurrentRoomChangedEvent ---
		void Gameplay_Chat_Control_ChatViewMediator__HandleCurrentRoomChangedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Chat_Control_ChatViewMediator__HandleRoomAddedEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004568 RID: 17768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004568")]
		[Address(RVA = "0x940C", Offset = "0x940C", VA = "0x940C")]
		private void HandleCurrentRoomReadyEvent()
		{
		}

		// Token: 0x06004569 RID: 17769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004569")]
		[Address(RVA = "0x940D", Offset = "0x940D", VA = "0x940D")]
		private void HandleUserLeftEvent(ChatVisitorData visitor)
		{
		}

		// Token: 0x0600456A RID: 17770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600456A")]
		[Address(RVA = "0x940E", Offset = "0x940E", VA = "0x940E")]
		private void HandleContactAddedEvent(ChatVisitorData visitor)
		{
		/* --- GHIDRA: HandleContactAddedEvent ---
		void Gameplay_Chat_Control_ChatViewMediator__HandleContactAddedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Chat_View_ChatView__AddVisitor(param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600456B RID: 17771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600456B")]
		[Address(RVA = "0x940F", Offset = "0x940F", VA = "0x940F")]
		private void HandleContactRemovedEvent(ChatVisitorData visitor)
		{
		/* --- GHIDRA: HandleContactRemovedEvent ---
		void Gameplay_Chat_Control_ChatViewMediator__HandleContactRemovedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Chat_View_ChatView__SetVisitors(param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600456C RID: 17772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600456C")]
		[Address(RVA = "0x9410", Offset = "0x9410", VA = "0x9410")]
		private void HandleUserJoinedEvent(ChatVisitorData visitor)
		{
		/* --- GHIDRA: HandleUserJoinedEvent ---
		void Gameplay_Chat_Control_ChatViewMediator__HandleUserJoinedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int *param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57953 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_View_ChatVisitorViewsHolder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ChatVisitorData__IndexOf__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ChatVisitorViewsHolder__GetBaseItemViewsHolderIfVisible__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatVisitorData__get_List__
		              );
		    DAT_ram_00a57953 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                    (*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0xa0) + 0xc),param2,
		                     Method_System_Collections_Generic_List_ChatVisitorData__IndexOf__);
		  if (iVar1 != -1) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = (int *)Com_TheFallenGames_OSA_Core_OSA_object__object___GetBaseItemViewsHolder
		                                 (*(undefined4 *)(iVar2 + 0x3c),iVar1,
		                                  Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ChatVisitorViewsHolder__GetBaseItemViewsHolderIfVisible__
		                                 );
		    if (param1_00 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_00 + 0xb8) <
		           (uint)*(byte *)(Gameplay_Chat_View_ChatVisitorViewsHolder_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_00 + 100) +
		                   (uint)*(byte *)(Gameplay_Chat_View_ChatVisitorViewsHolder_TypeInfo + 0xb8) * 4 +
		                  -4) != Gameplay_Chat_View_ChatVisitorViewsHolder_TypeInfo)) {
		        System_Activator__CreateInstance
		                  (param1_00,Gameplay_Chat_View_ChatVisitorViewsHolder_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      Gameplay_Chat_View_VisitorItemRenderer__HandleDataChanged(param1_00[5],0);
		    }
		  }
		  if (param2 == *(int *)(param1[2] + 0x2c)) {
		    param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Chat_View_ChatView__ScrollMessagesDown(param1_01,*(undefined4 *)(param2 + 0x10),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600456D RID: 17773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600456D")]
		[Address(RVA = "0x9411", Offset = "0x9411", VA = "0x9411")]
		private void HandleUserUpdatedEvent(ChatVisitorData visitor)
		{
		/* --- GHIDRA: HandleUserUpdatedEvent ---
		void Gameplay_Chat_Control_ChatViewMediator__HandleUserUpdatedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param2_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57954 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_ChatMessageItem___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem__InsertItemsAtEnd__
		              );
		    DAT_ram_00a57954 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0xa0);
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid
		                               (Gameplay_Chat_Model_Data_Message_ChatMessageItem___TypeInfo,1);
		  if ((param2 != 0) && (iVar1 = func_ii_1082(param2,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)
		     ) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[4] = param2;
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___InsertItems
		            (uVar2,param2_00,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem__InsertItemsAtEnd__
		            );
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Chat_View_ChatView__RemoveVisitor(uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600456E RID: 17774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600456E")]
		[Address(RVA = "0x9412", Offset = "0x9412", VA = "0x9412")]
		private void HandleMessageReceivedEvent(ChatMessageItem message)
		{
		/* --- GHIDRA: HandleMessageReceivedEvent ---
		void Gameplay_Chat_Control_ChatViewMediator__HandleMessageReceivedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a57955 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem__RemoveItems__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem__get_Item__
		              );
		    DAT_ram_00a57955 = '\x01';
		  }
		  iVar3 = *(int *)(param2 + 0xc);
		  if (0 < iVar3) {
		    do {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar1 = UnityEngine_AndroidJavaObject___GetRawObject
		                        (*(undefined4 *)(*(int *)(iVar1 + 0x44) + 0xa0),
		                         Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem__get_Count__
		                        );
		      if (0 < iVar1) {
		        iVar1 = 0;
		        do {
		          iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		          iVar2 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                            (*(undefined4 *)(*(int *)(iVar2 + 0x44) + 0xa0),iVar1,
		                             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem__get_Item__
		                            );
		          if (iVar2 == *(int *)(param2 + iVar4 * 4 + 0x10)) {
		            iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x15c));
		            Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___NotifyListChangedExternally
		                      (*(undefined4 *)(*(int *)(iVar2 + 0x44) + 0xa0),iVar1,1,0,
		                       Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem__RemoveItems__
		                      );
		            break;
		          }
		          iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		          iVar2 = UnityEngine_AndroidJavaObject___GetRawObject
		                            (*(undefined4 *)(*(int *)(iVar2 + 0x44) + 0xa0),
		                             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem__get_Count__
		                            );
		          iVar1 = iVar1 + 1;
		        } while (iVar1 < iVar2);
		      }
		      iVar4 = iVar4 + 1;
		    } while (iVar4 != iVar3);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600456F RID: 17775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600456F")]
		[Address(RVA = "0x9413", Offset = "0x9413", VA = "0x9413")]
		private void HandleMessagesRemovedEvent(ChatMessageItem[] messages)
		{
		/* --- GHIDRA: HandleMessagesRemovedEvent ---
		void Gameplay_Chat_Control_ChatViewMediator__HandleMessagesRemovedEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = Gameplay_Chat_Model_Data_Message_InputMessage__ToString
		                    (*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x34) + 0x10) + 0x160),0);
		  param2[4] = iVar1;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x34) + 0x10);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xd8) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xdc));
		  TMPro_TMP_InputField__get_text(param1_00,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0x34) + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  TMPro_TMP_InputField__get_caretPosition
		            (uVar2,*(undefined4 *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x34) + 0x10) + 0x160) + 8),0)
		  ;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Chat_View_ChatView__SetBan(uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06004570 RID: 17776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004570")]
		[Address(RVA = "0x9414", Offset = "0x9414", VA = "0x9414")]
		private void HandleStartWriteMessageToUserEvent(InputMessage inputMessage)
		{
		/* --- GHIDRA: HandleStartWriteMessageToUserEvent ---
		void Gameplay_Chat_Control_ChatViewMediator__HandleStartWriteMessageToUserEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int iVar3;
		  undefined4 param2_01;
		  
		  iVar2 = *(int *)(param2 + 4);
		  if ((iVar2 != 0) && (iVar3 = *(int *)(iVar2 + 0xc), 0 < iVar3)) {
		    param2_00 = 0;
		    do {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      param1_00 = UI_Tabs_TabBar__SelectByItem(*(undefined4 *)(iVar1 + 0x1c),param2_00,0);
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      if (param2_00 == *(int *)(*(int *)(iVar1 + 0x1c) + 0x3c)) {
		        param2_01 = 0;
		      }
		      else {
		        param2_01 = *(undefined4 *)(iVar2 + param2_00 * 4 + 0x10);
		      }
		      Core_Extensions_Dict_BossGroupDictExt__GetTitle(param1_00,param2_01,0);
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar3);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004571 RID: 17777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004571")]
		[Address(RVA = "0x9415", Offset = "0x9415", VA = "0x9415")]
		private void HandleNotViewedMessageCountChangedEvent(NotViewedMessagesInfoData info)
		{
		/* --- GHIDRA: HandleNotViewedMessageCountChangedEvent ---
		void Gameplay_Chat_Control_ChatViewMediator__HandleNotViewedMessageCountChangedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Chat_Control_ChatViewMediator__SetupView(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004572 RID: 17778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004572")]
		[Address(RVA = "0x9416", Offset = "0x9416", VA = "0x9416")]
		private void HandleSendMessageEvent()
		{
		/* --- GHIDRA: HandleSendMessageEvent ---
		void Gameplay_Chat_Control_ChatViewMediator__HandleSendMessageEvent(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 param1_01;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57956 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_ChatRoomData__get_Data__);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_ChatRoomData__TypeInfo);
		    DAT_ram_00a57956 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = (int *)UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x1c),0);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(UI_Tabs_TabBarItemData_ChatRoomData__TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(UI_Tabs_TabBarItemData_ChatRoomData__TypeInfo + 0xb8) * 4 + -4) !=
		        UI_Tabs_TabBarItemData_ChatRoomData__TypeInfo)) {
		      System_Activator__CreateInstance(param1_00,UI_Tabs_TabBarItemData_ChatRoomData__TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param2_00 = Google_Protobuf_Reflection_ServiceDescriptor___ctor(param1_00[8],0);
		  Gameplay_Chat_Control_ChatController__RequestFavoritesList(param1_01,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004573 RID: 17779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004573")]
		[Address(RVA = "0x9417", Offset = "0x9417", VA = "0x9417")]
		private void HandleRoomsTabBarChangedEvent()
		{
		/* --- GHIDRA: HandleRoomsTabBarChangedEvent ---
		void Gameplay_Chat_Control_ChatViewMediator__HandleRoomsTabBarChangedEvent
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 *puVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *param1_00;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a57957 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatViewMediator_HandleContactListReceivedEvent__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4189);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4185);
		    DAT_ram_00a57957 = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Chat_Control_ChatController__BanUser(uVar2,*(byte *)(param1[2] + 0x48) ^ 0xff,0);
		  if (*(char *)(param1[2] + 0x48) == '\0') {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Chat_View_ChatView__HandleCurrentStateChanged
		              (uVar2,*(undefined4 *)(*(int *)(param1[2] + 0x30) + 8),0);
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		    puVar1 = &StringLiteral_4189;
		    iVar5 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  else {
		    if (*(char *)(param1[2] + 0x48) != -1) {
		      return;
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar4 = *(undefined4 *)(iVar3 + 0x28);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleContactListReceivedEvent__,0);
		    param1_00 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar2,0);
		    iVar5 = System_Action_TypeInfo;
		    if (param1_00 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x28) = 0;
		    }
		    else if ((System_Action_TypeInfo != *param1_00) ||
		            (*(int **)(iVar3 + 0x28) = param1_00, *param1_00 != iVar5)) {
		      System_Activator__CreateInstance(param1_00,iVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    Gameplay_Chat_Control_ChatController__HandleAttackAbilityInfoChangedEvent(uVar2,0);
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		    puVar1 = &StringLiteral_4185;
		    iVar5 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  if (iVar5 == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = func_ii_7508(*puVar1,1,0,1,0,0,0,0);
		  Core_Application_App__get_ToastController(uVar2,4,uVar4,0);
		  return;
		}
		*/

		}

		// Token: 0x06004574 RID: 17780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004574")]
		[Address(RVA = "0x9418", Offset = "0x9418", VA = "0x9418")]
		private void HandleRoomVisitorsOrContactsClickEvent(object sender, PointerEventData evt)
		{
		/* --- GHIDRA: HandleRoomVisitorsOrContactsClickEvent ---
		void Gameplay_Chat_Control_ChatViewMediator__HandleRoomVisitorsOrContactsClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57958 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatViewMediator_HandleContactListReceivedEvent__);
		    DAT_ram_00a57958 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  param1_01 = *(undefined4 *)(iVar1 + 0x28);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Chat_Control_ChatViewMediator_HandleContactListReceivedEvent__,0);
		  param1_00 = (int *)func_ii_7048(param1_01,uVar2,0);
		  param2_00 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0x28) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_00) ||
		          (*(int **)(iVar1 + 0x28) = param1_00, *param1_00 != param2_00)) {
		    System_Activator__CreateInstance(param1_00,param2_00);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Chat_View_ChatView__HandleCurrentStateChanged(uVar2,*(undefined4 *)(param1[2] + 0x34),0);
		  return;
		}
		*/

		}

		// Token: 0x06004575 RID: 17781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004575")]
		[Address(RVA = "0x9419", Offset = "0x9419", VA = "0x9419")]
		private void HandleContactListReceivedEvent()
		{
		/* --- GHIDRA: HandleContactListReceivedEvent ---
		void Gameplay_Chat_Control_ChatViewMediator__HandleContactListReceivedEvent
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57959 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatView__get_Model__
		              );
		    DAT_ram_00a57959 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Chat_Control_ChatController__SetCurrentUIVisitorsState
		            (param1_00,*(byte *)(param1[2] + 0x49) ^ 0xff,0);
		  return;
		}
		*/

		}

		// Token: 0x06004576 RID: 17782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004576")]
		[Address(RVA = "0x941A", Offset = "0x941A", VA = "0x941A")]
		private void HandleMiniChatViewSwitchClickEvent(object sender, PointerEventData evt)
		{
		/* --- GHIDRA: HandleMiniChatViewSwitchClickEvent ---
		void Gameplay_Chat_Control_ChatViewMediator__HandleMiniChatViewSwitchClickEvent
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 *puVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a5795a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4188);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4184);
		    DAT_ram_00a5795a = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Chat_Control_ChatController__SetCurrentMiniChatViewState
		            (uVar2,*(byte *)(param1[2] + 0x4a) ^ 0xff,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar3 + 0x44);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  uVar2 = Gameplay_Chat_Control_ChatController__FilterMessage(uVar2,0);
		  Gameplay_Chat_View_Messages_MessagesListAdapter__OnEnable(uVar4,uVar2,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Chat_View_ChatView__RemoveVisitor(uVar2,0);
		  if (*(char *)(param1[2] + 0x4a) == -1) {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		    puVar1 = &StringLiteral_4188;
		    iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  else {
		    if (*(char *)(param1[2] + 0x4a) != '\0') {
		      return;
		    }
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		    puVar1 = &StringLiteral_4184;
		    iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  if (iVar3 == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = func_ii_7508(*puVar1,1,0,1,0,0,0,0);
		  Core_Application_App__get_ToastController(uVar2,4,uVar4,0);
		  return;
		}
		*/

		}

		// Token: 0x06004577 RID: 17783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004577")]
		[Address(RVA = "0x941B", Offset = "0x941B", VA = "0x941B")]
		private void HandlePrivateMessagesButtonClickEvent(object sender, PointerEventData evt)
		{
		/* --- GHIDRA: HandlePrivateMessagesButtonClickEvent ---
		void Gameplay_Chat_Control_ChatViewMediator__HandlePrivateMessagesButtonClickEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Gameplay_Chat_Control_ChatViewMediator__HandleRoomsChanges(param1,param3,0,param3);
		  return;
		}
		*/

		}

		// Token: 0x06004578 RID: 17784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004578")]
		[Address(RVA = "0x941C", Offset = "0x941C", VA = "0x941C")]
		private void HandleVisitorClickedEvent(object sender, ChatVisitorData visitor)
		{
		/* --- GHIDRA: HandleVisitorClickedEvent ---
		void Gameplay_Chat_Control_ChatViewMediator__HandleVisitorClickedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Chat_Control_ChatController__SetCurrentPrivateOrAllMessagesState(param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06004579 RID: 17785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004579")]
		[Address(RVA = "0x941D", Offset = "0x941D", VA = "0x941D")]
		private void HandleMessageHasBeenViewedEvent(ChatMessageItem messageItem)
		{
		/* --- GHIDRA: HandleMessageHasBeenViewedEvent ---
		void Gameplay_Chat_Control_ChatViewMediator__HandleMessageHasBeenViewedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param3_00;
		  int param1_00;
		  uint uVar4;
		  int iVar5;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5795b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_DialogWindow_DialogWindowArgs__get_DescriptionField__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__ChatMessageItem__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__ChatMessageItem___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__ChatMessageItem__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Chat_Control_ChatViewMediator__HandleMessageDeleteRequestEvent_b__31_0__
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_25487);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4174);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4175);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13135);
		    DAT_ram_00a5795b = '\x01';
		  }
		  iVar1 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(iVar1,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_4175,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar1 + 0x18) = uVar2;
		  uVar2 = func_ii_7508(StringLiteral_4174,1,0,1,0,0,0,0);
		  iVar3 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  iVar5 = **(int **)(param2 + 0xc);
		  param3_00 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xf0) * 4))
		                        (*(int **)(param2 + 0xc),0,*(undefined4 *)(iVar5 + 0xf4));
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_25487,param3_00,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar3 + 0x10) = local_8;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,iVar3,0);
		  *(undefined4 *)(iVar1 + 0x1c) = uVar2;
		  iVar5 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                    );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar5,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		            );
		  param1_00 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_00,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = func_ii_7508(StringLiteral_13135,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 8) = uVar2;
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__ChatMessageItem__TypeInfo
		                    );
		  *(int *)(iVar3 + 0xc) = param2;
		  uVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__ChatMessageItem__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object__Int32Enum___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Chat_Control_ChatViewMediator__HandleMessageDeleteRequestEvent_b__31_0__
		             ,0);
		  *(undefined4 *)(iVar3 + 0x10) = uVar2;
		  *(int *)(param1_00 + 0x14) = iVar3;
		  iVar3 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar5 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		    *(uint *)(iVar5 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar5 + 8) + uVar4 * 4 + 0x10) = param1_00;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar5,param1_00,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(iVar1 + 0x24) = iVar5;
		  iVar1 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (iVar1,0);
		  uVar2 = *(undefined4 *)(iVar1 + 0x3c);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  TMPro_TMP_Text__get_spriteAsset
		            (uVar2,*(undefined4 *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x48) + 0x28) + 0x10) + 0x134)
		             ,0);
		  return;
		}
		*/

		}

		// Token: 0x0600457A RID: 17786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600457A")]
		[Address(RVA = "0x941E", Offset = "0x941E", VA = "0x941E")]
		private void HandleMessageDeleteRequestEvent(ChatMessageItem messageItem)
		{
		/* --- GHIDRA: HandleMessageDeleteRequestEvent ---
		void Gameplay_Chat_Control_ChatViewMediator__HandleMessageDeleteRequestEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Gameplay_Chat_Control_ChatViewMediator__HandleRoomsChanges(param1,param2,param3,param3);
		  return;
		}
		*/

		}

		// Token: 0x0600457B RID: 17787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600457B")]
		[Address(RVA = "0x941F", Offset = "0x941F", VA = "0x941F")]
		private void HandleClickOnVisitorEvent(ChatVisitorData visitor, ChatMessageItem messageItem)
		{
		/* --- GHIDRA: HandleClickOnVisitorEvent ---
		void Gameplay_Chat_Control_ChatViewMediator__HandleClickOnVisitorEvent
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Chat_Control_ChatController__SendComplaint(param1_00,param3,0);
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Chat_Control_ChatViewMediator__set_Events(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5794c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ChatMessageItem__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ChatVisitorData__ChatMessageItem__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatViewMediator_HandleClickOnVisitorEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatViewMediator_HandleMessageDeleteRequestEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatViewMediator_HandleMessageHasBeenViewedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatViewMediator_HandleMiniChatViewSwitchClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandlePrivateMessagesButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleRoomVisitorsOrContactsClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatViewMediator_HandleRoomsTabBarChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatViewMediator_HandleSendMessageEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatViewMediator_HandleVisitorClickedEvent__);
		    Mono_Security_ASN1__get_Item(&System_EventHandler_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_EventHandler_ChatVisitorData__TypeInfo);
		    DAT_ram_00a5794c = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x24);
		    uVar1 = unnamed_function_1417(System_EventHandler_PointerEventData__TypeInfo);
		    UnityEngine_Object__Instantiate_object_
		              (uVar1,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandlePrivateMessagesButtonClickEvent__
		               ,0);
		    UI_SelectedButton__add_ClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleRoomsTabBarChangedEvent__,0);
		    UI_Tabs_TabBar__add_ChangeEvent(uVar3,uVar1,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Chat_Control_ChatViewMediator_HandleSendMessageEvent__,0
		              );
		    Gameplay_Chat_View_ChatView__add_SendMessageEvent(uVar1,uVar3,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x2c);
		    uVar1 = unnamed_function_1417(System_EventHandler_PointerEventData__TypeInfo);
		    UnityEngine_Object__Instantiate_object_
		              (uVar1,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleRoomVisitorsOrContactsClickEvent__
		               ,0);
		    UI_SelectedButton__add_ClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x30);
		    uVar1 = unnamed_function_1417(System_EventHandler_PointerEventData__TypeInfo);
		    UnityEngine_Object__Instantiate_object_
		              (uVar1,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleMiniChatViewSwitchClickEvent__,0)
		    ;
		    UI_SelectedButton__add_ClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x3c);
		    uVar1 = unnamed_function_1417(System_EventHandler_ChatVisitorData__TypeInfo);
		    UnityEngine_Object__Instantiate_object_
		              (uVar1,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleVisitorClickedEvent__,0);
		    Gameplay_Chat_View_ChatRoomVisitorsListAdapter__add_ItemClickedEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x44);
		    uVar1 = unnamed_function_1417(System_Action_ChatMessageItem__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleMessageHasBeenViewedEvent__,0);
		    Gameplay_Chat_View_Messages_MessagesListAdapter__add_MessageHasBeenViewedEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x44);
		    uVar1 = unnamed_function_1417(System_Action_ChatMessageItem__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleMessageDeleteRequestEvent__,0);
		    Gameplay_Chat_View_Messages_MessagesListAdapter__add_MessageDeleteRequestEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x44);
		    uVar1 = unnamed_function_1417(System_Action_ChatVisitorData__ChatMessageItem__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar1,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleClickOnVisitorEvent__,0);
		    Gameplay_Chat_View_Messages_MessagesListAdapter__add_ClickOnVisitorEvent(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x24);
		    uVar1 = unnamed_function_1417(System_EventHandler_PointerEventData__TypeInfo);
		    UnityEngine_Object__Instantiate_object_
		              (uVar1,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandlePrivateMessagesButtonClickEvent__
		               ,0);
		    UI_RawImageWithGrayscale___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleRoomsTabBarChangedEvent__,0);
		    UI_Tabs_CategoryTabBarItemView___ctor(uVar3,uVar1,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Chat_Control_ChatViewMediator_HandleSendMessageEvent__,0
		              );
		    Gameplay_Chat_View_ChatView__get_SmilesView(uVar1,uVar3,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x2c);
		    uVar1 = unnamed_function_1417(System_EventHandler_PointerEventData__TypeInfo);
		    UnityEngine_Object__Instantiate_object_
		              (uVar1,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleRoomVisitorsOrContactsClickEvent__
		               ,0);
		    UI_RawImageWithGrayscale___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x30);
		    uVar1 = unnamed_function_1417(System_EventHandler_PointerEventData__TypeInfo);
		    UnityEngine_Object__Instantiate_object_
		              (uVar1,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleMiniChatViewSwitchClickEvent__,0)
		    ;
		    UI_RawImageWithGrayscale___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x3c);
		    uVar1 = unnamed_function_1417(System_EventHandler_ChatVisitorData__TypeInfo);
		    UnityEngine_Object__Instantiate_object_
		              (uVar1,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleVisitorClickedEvent__,0);
		    Gameplay_Chat_View_ChatRoomVisitorsListAdapter__set_Data(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x44);
		    uVar1 = unnamed_function_1417(System_Action_ChatMessageItem__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleMessageHasBeenViewedEvent__,0);
		    Gameplay_Chat_View_Messages_MessagesListAdapter__set_Data(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x44);
		    uVar1 = unnamed_function_1417(System_Action_ChatMessageItem__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleMessageDeleteRequestEvent__,0);
		    Gameplay_Chat_View_Messages_MessagesListAdapter__remove_MessageHasBeenViewedEvent(uVar3,uVar1,0)
		    ;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x44);
		    uVar1 = unnamed_function_1417(System_Action_ChatVisitorData__ChatMessageItem__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar1,param1,
		               Method_Gameplay_Chat_Control_ChatViewMediator_HandleClickOnVisitorEvent__,0);
		    Gameplay_Chat_View_Messages_MessagesListAdapter__remove_MessageDeleteRequestEvent(uVar3,uVar1,0)
		    ;
		    Gameplay_Chat_Control_ChatViewMediator__set_View(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Chat_Control_ChatViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  char cVar1;
		  uint uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 *param2_00;
		  
		  if (DAT_ram_00a5794d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__ChatController__ChatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5794d = '\x01';
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = *(int *)(iVar3 + 0x48);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar2 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x80e06360;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e06360:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		  iVar6 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar5,0);
		  *(undefined4 *)(iVar3 + 0x38) = *(undefined4 *)(iVar6 + 0x1d4);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_SelectedButton__get_Selected
		            (*(undefined4 *)(iVar3 + 0x2c),(uint)(*(char *)(param1[2] + 0x48) == -1),0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_SelectedButton__get_Selected
		            (*(undefined4 *)(iVar3 + 0x30),(uint)(*(char *)(param1[2] + 0x49) == -1),0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_SelectedButton__get_Selected
		            (*(undefined4 *)(iVar3 + 0x24),(uint)(*(char *)(param1[2] + 0x4a) == -1),0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar7 = *(undefined4 *)(*(int *)(iVar3 + 0x34) + 0x10);
		  uVar5 = Gameplay_Chat_Model_ChatModel__get_MessagePatterString(param1[2],0);
		  TMPro_TMP_InputField__get_characterLimit(uVar7,uVar5,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar7 = *(undefined4 *)(iVar3 + 0x34);
		  uVar5 = Gameplay_Chat_Model_ChatModel__GetRooms(param1[2],0);
		  Gameplay_UserInfo_View_PatternTextInput__get_Pattern(uVar7,uVar5,0);
		  cVar1 = *(char *)(param1[2] + 0x48);
		  uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (cVar1 == '\0') {
		    param2_00 = (undefined4 *)(*(int *)(param1[2] + 0x30) + 8);
		  }
		  else {
		    param2_00 = (undefined4 *)(param1[2] + 0x34);
		  }
		  Gameplay_Chat_View_ChatView__HandleCurrentStateChanged(uVar5,*param2_00,0);
		  Gameplay_Chat_Control_ChatViewMediator__RoomsToTabs(param1,param2_00);
		  Gameplay_Chat_Control_ChatViewMediator__HandleRoomAddedEvent(param1,param2_00);
		  return;
		}
		*/

}
