using System;
using System.Collections;
using System.Collections.Generic;
using Gameplay.Chat.Model;
using Gameplay.Chat.Model.Data;
using Gameplay.Chat.Model.Data.Message;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Chat;
using ServicesNamespace;
using UnityEngine;
using Utils;

namespace Gameplay.Chat.Control
{
	// Token: 0x02000B26 RID: 2854
	[Token(Token = "0x2000B26")]
	public class ChatController : AbstractController<ChatModel, ChatEvents>
	{
		// Token: 0x060044E8 RID: 17640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044E8")]
		[Address(RVA = "0x938E", Offset = "0x938E", VA = "0x938E", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Chat_Control_ChatController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57b72 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_ChatModel__ChatEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ChatService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a57b72 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_ChatModel__ChatEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ChatService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060044E9 RID: 17641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044E9")]
		[Address(RVA = "0x938F", Offset = "0x938F", VA = "0x938F")]
		public ChatController(ChatModel model, ChatEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Chat_Control_ChatController___ctor(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Chat_Control_ChatController__TryDecrementNotViewMessages(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060044EA RID: 17642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044EA")]
		[Address(RVA = "0x9390", Offset = "0x9390", VA = "0x9390", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Chat_Control_ChatController__HandleRun(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Chat_Control_ChatController__StartListenServiceEvents(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060044EB RID: 17643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044EB")]
		[Address(RVA = "0x9391", Offset = "0x9391", VA = "0x9391", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Chat_Control_ChatController__HandleStop(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(char *)((int)param1 + 9) == '\0') {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    Gameplay_Chat_Control_ChatController__HandleVisitorBan(param1,param1);
		    Gameplay_Chat_Control_ChatController__ValidateInit(param1,param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 8);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060044EC RID: 17644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044EC")]
		[Address(RVA = "0x9392", Offset = "0x9392", VA = "0x9392")]
		private void ValidateInit()
		{
		/* --- GHIDRA: ValidateInit ---
		void Gameplay_Chat_Control_ChatController__ValidateInit(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57b73 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoContactRemovedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoRemoveMessageEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ChatUserInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserInfoChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoChatMessageEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoRightsChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoNewComplaintEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoJoinRoomEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoAttackabilityChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoAdmonitionEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoComplaintProcessedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUnjoinRoomEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleAdmonitionEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleAttackAbilityInfoChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleComplaintProcessedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleContactRemovedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleMessageRemovedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleNewComplaintEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleNewContactEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleNewMessageEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleRightsChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Chat_Control_ChatController_HandleRoomJoinEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleRoomUnjoinEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleUserInfoChangedEvent__);
		    DAT_ram_00a57b73 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoJoinRoomEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Chat_Control_ChatController_HandleRoomJoinEvent__,0);
		  ServicesNamespace_ChatService__get_ServiceId(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoUnjoinRoomEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Chat_Control_ChatController_HandleRoomUnjoinEvent__,0);
		  ServicesNamespace_ChatService__remove_RoomJoinEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoChatMessageEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Chat_Control_ChatController_HandleNewMessageEvent__,0);
		  ServicesNamespace_ChatService__remove_RoomUnjoinEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoUserInfoChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Chat_Control_ChatController_HandleUserInfoChangedEvent__,0
		            );
		  ServicesNamespace_ChatService__remove_NewMessageEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoNewComplaintEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Chat_Control_ChatController_HandleNewComplaintEvent__,0);
		  ServicesNamespace_ChatService__remove_UserInfoChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoComplaintProcessedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Chat_Control_ChatController_HandleComplaintProcessedEvent__,0);
		  ServicesNamespace_ChatService__remove_NewComplaintEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoAdmonitionEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Chat_Control_ChatController_HandleAdmonitionEvent__,0);
		  ServicesNamespace_ChatService__remove_ComplaintProcessedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoRemoveMessageEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Chat_Control_ChatController_HandleMessageRemovedEvent__,0)
		  ;
		  ServicesNamespace_ChatService__remove_AdmonitionEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ChatUserInfo__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Chat_Control_ChatController_HandleNewContactEvent__,0);
		  ServicesNamespace_ChatService__remove_MessageRemovedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoContactRemovedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Chat_Control_ChatController_HandleContactRemovedEvent__,0)
		  ;
		  ServicesNamespace_ChatService__remove_NewContactEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoRightsChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Chat_Control_ChatController_HandleRightsChangedEvent__,0);
		  ServicesNamespace_ChatService__remove_ContactRemovedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoAttackabilityChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Chat_Control_ChatController_HandleAttackAbilityInfoChangedEvent__,0);
		  ServicesNamespace_ChatService__remove_RightsChangedEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060044ED RID: 17645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044ED")]
		[Address(RVA = "0x9393", Offset = "0x9393", VA = "0x9393")]
		private void StartListenServiceEvents()
		{
		/* --- GHIDRA: StartListenServiceEvents ---
		void Gameplay_Chat_Control_ChatController__StartListenServiceEvents(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57b74 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoContactRemovedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoRemoveMessageEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ChatUserInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserInfoChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoChatMessageEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoRightsChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoNewComplaintEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoJoinRoomEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoAttackabilityChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoAdmonitionEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoComplaintProcessedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUnjoinRoomEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleAdmonitionEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleAttackAbilityInfoChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleComplaintProcessedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleContactRemovedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleMessageRemovedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleNewComplaintEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleNewContactEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleNewMessageEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleRightsChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Chat_Control_ChatController_HandleRoomJoinEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleRoomUnjoinEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleUserInfoChangedEvent__);
		    DAT_ram_00a57b74 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoJoinRoomEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Chat_Control_ChatController_HandleRoomJoinEvent__,0);
		  ServicesNamespace_ChatService__add_RoomJoinEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoUnjoinRoomEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Chat_Control_ChatController_HandleRoomUnjoinEvent__,0);
		  ServicesNamespace_ChatService__add_RoomUnjoinEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoChatMessageEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Chat_Control_ChatController_HandleNewMessageEvent__,0);
		  ServicesNamespace_ChatService__add_NewMessageEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoUserInfoChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Chat_Control_ChatController_HandleUserInfoChangedEvent__,0
		            );
		  ServicesNamespace_ChatService__add_UserInfoChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoNewComplaintEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Chat_Control_ChatController_HandleNewComplaintEvent__,0);
		  ServicesNamespace_ChatService__add_NewComplaintEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoComplaintProcessedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Chat_Control_ChatController_HandleComplaintProcessedEvent__,0);
		  ServicesNamespace_ChatService__add_ComplaintProcessedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoAdmonitionEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Chat_Control_ChatController_HandleAdmonitionEvent__,0);
		  ServicesNamespace_ChatService__add_AdmonitionEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoRemoveMessageEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Chat_Control_ChatController_HandleMessageRemovedEvent__,0)
		  ;
		  ServicesNamespace_ChatService__add_MessageRemovedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ChatUserInfo__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Chat_Control_ChatController_HandleNewContactEvent__,0);
		  ServicesNamespace_ChatService__add_NewContactEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoContactRemovedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Chat_Control_ChatController_HandleContactRemovedEvent__,0)
		  ;
		  ServicesNamespace_ChatService__add_ContactRemovedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoRightsChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Chat_Control_ChatController_HandleRightsChangedEvent__,0);
		  ServicesNamespace_ChatService__add_RightsChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoAttackabilityChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Chat_Control_ChatController_HandleAttackAbilityInfoChangedEvent__,0);
		  ServicesNamespace_ChatService__add_AttackAbilityInfoChangedEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060044EE RID: 17646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044EE")]
		[Address(RVA = "0x9394", Offset = "0x9394", VA = "0x9394")]
		private void StopListenServiceEvents()
		{
		/* --- GHIDRA: StopListenServiceEvents ---
		int Gameplay_Chat_Control_ChatController__StopListenServiceEvents
		              (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int *param1_00;
		  longlong param2_00;
		  uint uVar7;
		  int local_4;
		  
		  if (DAT_ram_00a57b75 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserCache_TypeInfo);
		    DAT_ram_00a57b75 = '\x01';
		  }
		  local_4 = 0;
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  uVar5 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  param2_00 = *(longlong *)(*(int *)(param2 + 0xc) + 0x10);
		  if (DAT_ram_00a57b3e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData__TryGetValue__);
		    DAT_ram_00a57b3e = '\x01';
		  }
		  if (param2_00 == 0) {
		    local_4 = 0;
		  }
		  else {
		    iVar3 = func_ii_7090(*(undefined4 *)(iVar2 + 0x3c),param2_00,&local_4,
		                         Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData__TryGetValue__
		                        );
		    uVar5 = (undefined4)((ulonglong)param2_00 >> 0x20);
		    if (iVar3 != 0) {
		      *(int *)(local_4 + 0x14) = param2;
		      Gameplay_Chat_Control_ChatController__UpdateVisitor(local_4,local_4,local_4);
		      return local_4;
		    }
		  }
		  iVar2 = Gameplay_Chat_Control_ChatController__GetVisitor(param1,param2,iVar2);
		  uVar1 = CONCAT44(uVar5,*(undefined4 *)(*param1 + 0x104));
		  local_4 = iVar2;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  uVar5 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar7 = 0;
		  uVar6 = *(undefined4 *)(param2 + 0xc);
		  param1_00 = *(int **)(iVar3 + 0x28);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Cache_User_IUserCache_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8)) {
		        puVar4 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e2add8;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar7);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Cache_User_IUserCache_TypeInfo,0);
		code_r0x80e2add8:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,CONCAT44(uVar5,uVar6),puVar4[1]);
		  *(undefined4 *)(iVar2 + 0x18) = uVar5;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = local_4;
		  if (DAT_ram_00a57b3f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData__Add__);
		    DAT_ram_00a57b3f = '\x01';
		  }
		  BestHTTP_Caching_HTTPCacheFileInfo___ctor
		            (*(undefined4 *)(iVar3 + 0x3c),
		             *(undefined8 *)(*(int *)(*(int *)(iVar2 + 0x14) + 0xc) + 0x10),iVar2,
		             Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData__Add__);
		  return local_4;
		}
		*/

		}

		// Token: 0x060044EF RID: 17647 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60044EF")]
		[Address(RVA = "0x9395", Offset = "0x9395", VA = "0x9395")]
		private ChatVisitorData GetVisitor(ChatUserInfo source)
		{
		/* --- GHIDRA: GetVisitor ---
		int Gameplay_Chat_Control_ChatController__GetVisitor
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57b76 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_ChatVisitorData_TypeInfo);
		    DAT_ram_00a57b76 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Gameplay_Chat_Model_Data_ChatVisitorData_TypeInfo);
		  if (DAT_ram_00a57b52 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__TypeInfo);
		    DAT_ram_00a57b52 = '\x01';
		  }
		  param1_01 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_01,Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData___ctor__);
		  *(undefined4 *)(param1_00 + 0x1c) = param1_01;
		  *(undefined4 *)(param1_00 + 0x14) = param2;
		  Gameplay_Chat_Control_ChatController__UpdateVisitor(param1_00,param1_00,param1_00);
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060044F0 RID: 17648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60044F0")]
		[Address(RVA = "0x9396", Offset = "0x9396", VA = "0x9396")]
		private ChatVisitorData ParseVisitor(ChatUserInfo source)
		{
		/* --- GHIDRA: ParseVisitor ---
		/* WARNING: Type propagation algorithm not settling */
		
		int * Gameplay_Chat_Control_ChatController__ParseVisitor(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  longlong lVar7;
		  int *piVar8;
		  int local_8 [2];
		  
		  if (DAT_ram_00a57b77 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_ChatUserMessageData_TypeInfo);
		    DAT_ram_00a57b77 = '\x01';
		  }
		  local_8[1] = 0;
		  local_8[0] = 0;
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  iVar5 = *(int *)(iVar3 + 0x2c);
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar3 = *(int *)(iVar3 + 0x20);
		  piVar4 = (int *)unnamed_function_1417
		                            (Gameplay_Chat_Model_Data_Message_ChatUserMessageData_TypeInfo);
		  if (DAT_ram_00a57b54 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_MessageDrawTarget__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_MessageDrawTarget__string__TypeInfo);
		    DAT_ram_00a57b54 = '\x01';
		  }
		  iVar6 = *(int *)(param2 + 0xc);
		  piVar4[4] = iVar5;
		  piVar4[2] = iVar6;
		  piVar4[3] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_MessageDrawTarget__string__TypeInfo);
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (iVar3,Method_System_Collections_Generic_Dictionary_MessageDrawTarget__string___ctor__);
		  piVar4[8] = param2;
		  piVar4[9] = iVar3;
		  uVar1 = CONCAT44(uVar2,1);
		  (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xe8) * 4))
		            (piVar4,uVar1,*(undefined4 *)(*piVar4 + 0xec));
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  if (*(int *)(piVar4[8] + 0x10) == 8) goto code_r0x80e2b14c;
		  uVar1 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  lVar7 = *(longlong *)(piVar4[8] + 0x20);
		  if (DAT_ram_00a57b3e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData__TryGetValue__);
		    DAT_ram_00a57b3e = '\x01';
		  }
		  if (lVar7 == 0) {
		    local_8[1] = 0;
		code_r0x80e2b129:
		    uVar1 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    piVar8 = (int *)(iVar3 + 0x18);
		  }
		  else {
		    piVar8 = local_8 + 1;
		    iVar3 = func_ii_7090(*(undefined4 *)(iVar3 + 0x3c),lVar7,local_8 + 1,
		                         Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData__TryGetValue__
		                        );
		    uVar2 = (undefined4)((ulonglong)lVar7 >> 0x20);
		    if (iVar3 == 0) goto code_r0x80e2b129;
		  }
		  piVar4[6] = *piVar8;
		code_r0x80e2b14c:
		  if (*(longlong *)(piVar4[8] + 0x18) != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104)));
		    lVar7 = *(longlong *)(piVar4[8] + 0x18);
		    if (DAT_ram_00a57b3e == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData__TryGetValue__
		                );
		      DAT_ram_00a57b3e = '\x01';
		    }
		    if ((lVar7 != 0) &&
		       (iVar3 = func_ii_7090(*(undefined4 *)(iVar3 + 0x3c),lVar7,local_8,
		                             Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData__TryGetValue__
		                            ), iVar3 != 0)) {
		      piVar4[7] = local_8[0];
		    }
		  }
		  return piVar4;
		}
		*/

			return null;
		}

		// Token: 0x060044F1 RID: 17649 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60044F1")]
		[Address(RVA = "0x9397", Offset = "0x9397", VA = "0x9397")]
		private ChatUserMessageData ParseMessage(ChatMessage source)
		{
		/* --- GHIDRA: ParseMessage ---
		void Gameplay_Chat_Control_ChatController__ParseMessage
		               (undefined4 param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  *(undefined4 *)(param2 + 0x14) = param3;
		  Gameplay_Chat_Control_ChatController__UpdateVisitor(param2,param2,param2);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060044F2 RID: 17650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F2")]
		[Address(RVA = "0x9398", Offset = "0x9398", VA = "0x9398")]
		private void UpdateVisitor(ChatVisitorData visitor, ChatUserInfo source)
		{
		/* --- GHIDRA: UpdateVisitor ---
		void Gameplay_Chat_Control_ChatController__UpdateVisitor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  float fVar1;
		  int iVar2;
		  int param2_00;
		  int iVar3;
		  
		  if (DAT_ram_00a57b78 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_ChatBanData_TypeInfo);
		    DAT_ram_00a57b78 = '\x01';
		  }
		  iVar2 = *(int *)(param2 + 0x10);
		  if (((*(byte *)(*(int *)(param2 + 0x14) + 0x14) & 1) != 0) &&
		     (param2_00 = *(int *)(*(int *)(param2 + 0x14) + 0x18), param2_00 != 0)) {
		    if (iVar2 != 0) {
		      iVar3 = *(int *)(*(int *)(iVar2 + 0xc) + 0xc);
		      *(int *)(iVar2 + 0xc) = param2_00;
		      *(bool *)(param2 + 0xc) = iVar3 != *(int *)(param2_00 + 0xc);
		      return;
		    }
		    iVar2 = unnamed_function_1417(Gameplay_Chat_Model_Data_ChatBanData_TypeInfo);
		    Gameplay_Chat_Model_Data_ChatBanData__Finalize(iVar2,param2_00,param2);
		    fVar1 = UnityEngine_Time__get_timeScale(0);
		    *(float *)(iVar2 + 8) = fVar1;
		    *(bool *)(param2 + 0xc) = iVar2 != 0;
		    *(int *)(param2 + 0x10) = iVar2;
		    return;
		  }
		  *(undefined4 *)(param2 + 0x10) = 0;
		  *(bool *)(param2 + 0xc) = iVar2 != 0;
		  return;
		}
		*/

		}

		// Token: 0x060044F3 RID: 17651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F3")]
		[Address(RVA = "0x9399", Offset = "0x9399", VA = "0x9399")]
		private void HandleVisitorBan(ChatVisitorData visitor)
		{
		/* --- GHIDRA: HandleVisitorBan ---
		void Gameplay_Chat_Control_ChatController__HandleVisitorBan(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  float fVar2;
		  undefined4 uVar3;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = *(int *)(*(int *)(iVar1 + 0x2c) + 0x14);
		  if (((*(byte *)(iVar1 + 0x14) & 1) != 0) && (*(int *)(iVar1 + 0x18) != 0)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    fVar2 = func_ii_7103(*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x2c) + 0x10) + 0x10),0);
		    if (0.0 < fVar2) {
		      if (param1[7] != 0) {
		        func_ii_7950(param1[7],0);
		      }
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x2c) + 0x10) + 0x10);
		      if (DAT_ram_00a57b7d == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Gameplay_Chat_Control_ChatController__BanCoroutine_d__20_TypeInfo);
		        DAT_ram_00a57b7d = '\x01';
		      }
		      iVar1 = unnamed_function_1417
		                        (Gameplay_Chat_Control_ChatController__BanCoroutine_d__20_TypeInfo);
		      Unity_Services_Core_Environments_Internal_Environments__get_Current(iVar1,0,0);
		      *(undefined4 *)(iVar1 + 0x10) = uVar3;
		      *(int **)(iVar1 + 0x14) = param1;
		      iVar1 = Utils_CoroutineSource__GetMono(iVar1,0);
		      param1[7] = iVar1;
		      return;
		    }
		    Gameplay_Chat_Control_ChatController__RequestGetChatInfo(param1,param1);
		    return;
		  }
		  if (param1[7] != 0) {
		    func_ii_7950(param1[7],0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060044F4 RID: 17652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F4")]
		[Address(RVA = "0x939A", Offset = "0x939A", VA = "0x939A")]
		private void ManageBan()
		{
		/* --- GHIDRA: ManageBan ---
		void Gameplay_Chat_Control_ChatController__ManageBan(int *param1,int param2,undefined4 param3)
		
		{
		  int param3_00;
		  undefined4 param1_00;
		  int iVar1;
		  int param5;
		  uint uVar2;
		  undefined1 auStack_4 [4];
		  
		  if (DAT_ram_00a57b79 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_ChatMessageItem___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ChatMessageItem__CopyTo__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatMessageItem__get_Count__);
		    DAT_ram_00a57b79 = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param2 + 0xc) + 0xc);
		  uVar2 = *(uint *)(*(int *)(param2 + 0x1c) + 0x10);
		  if ((longlong)(ulonglong)uVar2 < (longlong)iVar1) {
		    param5 = 0;
		    iVar1 = iVar1 - uVar2;
		    param3_00 = Mono_Security_ASN1Convert__ToOid
		                          (Gameplay_Chat_Model_Data_Message_ChatMessageItem___TypeInfo,iVar1);
		    System_Collections_Generic_List_RenderChain_VisualChangesProcessor_EntryProcessingInfo___CopyTo
		              (*(undefined4 *)(param2 + 0xc),0,param3_00,0,iVar1,
		               Method_System_Collections_Generic_List_ChatMessageItem__CopyTo__);
		    if (0 < iVar1) {
		      do {
		        param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x104));
		        Gameplay_Chat_Model_ChatModel__TryGetMessage
		                  (param1_00,*(undefined4 *)(*(int *)(param2 + 0x14) + 0xc),
		                   *(undefined4 *)(*(int *)(*(int *)(param3_00 + param5 * 4 + 0x10) + 0xc) + 8),
		                   auStack_4,param5);
		        param5 = param5 + 1;
		      } while (param5 != iVar1);
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if ((*(int *)(iVar1 + 0x30) == param2) && (*(int *)(param3_00 + 0xc) != 0)) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar1 = *(int *)(iVar1 + 0x34);
		      if (iVar1 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                  (*(undefined4 *)(iVar1 + 0x20),param3_00,*(undefined4 *)(iVar1 + 0x14));
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060044F5 RID: 17653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F5")]
		[Address(RVA = "0x939B", Offset = "0x939B", VA = "0x939B")]
		private void ManageMaxMessages(ChatRoomData room)
		{
		/* --- GHIDRA: ManageMaxMessages ---
		void Gameplay_Chat_Control_ChatController__ManageMaxMessages
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  int iVar5;
		  int *param1_01;
		  undefined4 param4;
		  int iVar6;
		  int iVar7;
		  int *piVar8;
		  int iVar9;
		  undefined1 local_5;
		  int local_4;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a57b7a == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_ChatRoomData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_RoomKey__bool__Add__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RoomKey__bool__TryGetValue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RoomKey__bool___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_RoomKey__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RoomRight__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RoomRight__get_Item__);
		    DAT_ram_00a57b7a = '\x01';
		  }
		  local_4 = 0;
		  local_5 = 0;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_RoomKey__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_RoomKey__bool___ctor__);
		  iVar7 = *param1;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x100) * 4))
		                    (param1,*(undefined4 *)(iVar7 + 0x104));
		  iVar7 = Gameplay_Chat_Model_ChatModel__AddRoom(uVar2,iVar7);
		  iVar5 = *(int *)(param2 + 0xc);
		  if (0 < iVar5) {
		    do {
		      iVar4 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (param2,iVar6,
		                         Method_Google_Protobuf_Collections_RepeatedField_RoomRight__get_Item__);
		      func_ii_12668(param1_00,*(undefined4 *)(iVar4 + 0xc),1,
		                    Method_System_Collections_Generic_Dictionary_RoomKey__bool__Add__);
		      iVar9 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar2 = *(undefined4 *)(iVar4 + 0xc);
		      if (DAT_ram_00a57b45 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__TryGetValue__
		                  );
		        DAT_ram_00a57b45 = '\x01';
		      }
		      iVar9 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                        (*(undefined4 *)(iVar9 + 0x40),uVar2,&local_4,
		                         Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__TryGetValue__
		                        );
		      if (iVar9 == 0) {
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar9 = *param1_01;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		            if (Core_Gameplay_IGame_TypeInfo == *piVar8) {
		              puVar3 = (uint *)(piVar8[1] * 8 + iVar9 + 0x178);
		              goto code_r0x80e2b536;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e2b536:
		        uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		        uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		        uVar2 = Core_Extensions_Dict_DictExt__GetSlotMachineSymbolDic
		                          (uVar2,*(undefined4 *)(*(int *)(iVar4 + 0xc) + 0xc),0);
		        iVar9 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        param4 = *(undefined4 *)(iVar9 + 0x10);
		        iVar9 = unnamed_function_1417(Gameplay_Chat_Model_Data_ChatRoomData_TypeInfo);
		        Gameplay_Chat_Model_Data_ChatRoomData__Finalize(iVar9,iVar4,uVar2,param4,iVar9);
		        local_4 = iVar9;
		        Gameplay_Chat_Control_ChatController__RemoveRoom(param1,iVar9,iVar9);
		      }
		      else {
		        *(int *)(local_4 + 0x14) = iVar4;
		      }
		      iVar6 = iVar6 + 1;
		    } while (iVar6 != iVar5);
		  }
		  iVar6 = *(int *)(iVar7 + 0xc);
		  if (0 < iVar6) {
		    iVar5 = 0;
		    do {
		      iVar9 = *(int *)(iVar7 + iVar5 * 4 + 0x10);
		      iVar4 = func_ii_8177(param1_00,*(undefined4 *)(*(int *)(iVar9 + 0x14) + 0xc),&local_5,
		                           Method_System_Collections_Generic_Dictionary_RoomKey__bool__TryGetValue__
		                          );
		      if (iVar4 == 0) {
		        Gameplay_Chat_Control_ChatController__ManageRights
		                  (param1,*(undefined4 *)(*(int *)(iVar9 + 0x14) + 0xc),iVar5);
		      }
		      iVar5 = iVar5 + 1;
		    } while (iVar5 != iVar6);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060044F6 RID: 17654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F6")]
		[Address(RVA = "0x939C", Offset = "0x939C", VA = "0x939C")]
		private void ManageRights(RepeatedField<RoomRight> rights)
		{
		/* --- GHIDRA: ManageRights ---
		int Gameplay_Chat_Control_ChatController__ManageRights
		              (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int local_4;
		  
		  if (DAT_ram_00a57b7b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__Remove__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatVisitorData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		    DAT_ram_00a57b7b = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a57b45 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__TryGetValue__);
		    DAT_ram_00a57b45 = '\x01';
		  }
		  iVar1 = 0;
		  iVar2 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (*(undefined4 *)(iVar2 + 0x40),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__TryGetValue__
		                    );
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (DAT_ram_00a57b46 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__Remove__);
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__get_Item__);
		      DAT_ram_00a57b46 = '\x01';
		    }
		    System_Data_DataRelationCollection__Add
		              (*(undefined4 *)(iVar2 + 0x40),param2,
		               Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__get_Item__);
		    System_Linq_Enumerable__First_KeyValuePair_object__object__
		              (*(undefined4 *)(iVar2 + 0x40),param2,
		               Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__Remove__);
		    *(undefined4 *)(iVar2 + 0x44) = 0;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (*(int *)(iVar2 + 0x30) == local_4) {
		      Gameplay_Chat_Control_ChatController__AddRoom(param1,0,local_4);
		    }
		    iVar2 = *(int *)(*(int *)(local_4 + 8) + 0xc);
		    if (0 < iVar2) {
		      iVar1 = 0;
		      do {
		        iVar3 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(local_4 + 8),iVar1,
		                           Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		        System_Linq_Enumerable__First_KeyValuePair_object__object__
		                  (*(undefined4 *)(iVar3 + 0x1c),param2,
		                   Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__Remove__);
		        iVar1 = iVar1 + 1;
		      } while (iVar1 != iVar2);
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = *(int *)(iVar2 + 0x1c) + -1;
		    if (iVar1 < 1) {
		      iVar1 = 0;
		    }
		    *(int *)(iVar2 + 0x1c) = iVar1;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x38);
		    iVar1 = local_4;
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),local_4,*(undefined4 *)(iVar2 + 0x14));
		      iVar1 = local_4;
		    }
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x060044F7 RID: 17655 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60044F7")]
		[Address(RVA = "0x939D", Offset = "0x939D", VA = "0x939D")]
		private ChatRoomData RemoveRoom(RoomKey roomKey)
		{
		/* --- GHIDRA: RemoveRoom ---
		int Gameplay_Chat_Control_ChatController__RemoveRoom(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a57b47 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__Add__);
		    DAT_ram_00a57b47 = '\x01';
		  }
		  System_Reflection_FieldInfo__get_IsStatic
		            (*(undefined4 *)(iVar1 + 0x40),*(undefined4 *)(*(int *)(param2 + 0x14) + 0xc),param2,
		             Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__Add__);
		  *(undefined4 *)(iVar1 + 0x44) = 0;
		  if ((*(byte *)(*(int *)(param2 + 0x14) + 0x10) & 1) != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = *(int *)(iVar1 + 0x1c) + 1;
		    if (iVar2 < 1) {
		      iVar2 = 0;
		    }
		    *(int *)(iVar1 + 0x1c) = iVar2;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x3c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return param2;
		}
		*/

			return null;
		}

		// Token: 0x060044F8 RID: 17656 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60044F8")]
		[Address(RVA = "0x939E", Offset = "0x939E", VA = "0x939E")]
		private ChatRoomData AddRoom(ChatRoomData room)
		{
		/* --- GHIDRA: AddRoom ---
		void Gameplay_Chat_Control_ChatController__AddRoom(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param3_00;
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param4;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a57b7c == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11284);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5343);
		    Mono_Security_ASN1__get_Item(&StringLiteral_193);
		    DAT_ram_00a57b7c = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = *(int *)(iVar1 + 0x30);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(int *)(iVar1 + 0x30) = param2;
		  uVar2 = StringLiteral_5343;
		  if (param2 != iVar3) {
		    param2_00 = StringLiteral_11284;
		    if (iVar3 != 0) {
		      piVar4 = *(int **)(*(int *)(iVar3 + 0x14) + 0xc);
		      iVar1 = *piVar4;
		      param2_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xd8) * 4))
		                            (piVar4,*(undefined4 *)(iVar1 + 0xdc));
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param3_00 = StringLiteral_193;
		    param4 = StringLiteral_11284;
		    if (*(int *)(iVar1 + 0x30) != 0) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      piVar4 = *(int **)(*(int *)(*(int *)(iVar1 + 0x30) + 0x14) + 0xc);
		      iVar1 = *piVar4;
		      param4 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xd8) * 4))
		                         (piVar4,*(undefined4 *)(iVar1 + 0xdc));
		    }
		    uVar2 = System_Int32__ToString(uVar2,param2_00,param3_00,param4,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x40);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if ((*(int *)(iVar1 + 0x30) != 0) &&
		       (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104)),
		       *(char *)(*(int *)(iVar1 + 0x30) + 0x18) == '\0')) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      *(undefined1 *)(*(int *)(iVar1 + 0x30) + 0x18) = 1;
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      Gameplay_Chat_Control_ChatController__RequestTakeOffBan
		                (param1,*(undefined4 *)(iVar1 + 0x30),param1);
		    }
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F9")]
		[Address(RVA = "0x939F", Offset = "0x939F", VA = "0x939F")]
		private void SetCurrentRoom(ChatRoomData room)
		{
		/* --- GHIDRA: SetCurrentRoom ---
		int Gameplay_Chat_Control_ChatController__SetCurrentRoom
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a57b7d == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Control_ChatController__BanCoroutine_d__20_TypeInfo)
		    ;
		    DAT_ram_00a57b7d = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Chat_Control_ChatController__BanCoroutine_d__20_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,0,0);
		  *(undefined4 *)(param1_00 + 0x10) = param2;
		  *(undefined4 *)(param1_00 + 0x14) = param1;
		  return param1_00;
		}
		*/

		}

		// Token: 0x060044FA RID: 17658 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60044FA")]
		[Address(RVA = "0x93A0", Offset = "0x93A0", VA = "0x93A0")]
		private IEnumerator BanCoroutine(BackTime backTime)
		{
		/* --- GHIDRA: BanCoroutine ---
		void Gameplay_Chat_Control_ChatController__BanCoroutine(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x1c) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x1c),0);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044FB")]
		[Address(RVA = "0x93A1", Offset = "0x93A1", VA = "0x93A1")]
		private void StopBanCoroutine()
		{
		/* --- GHIDRA: StopBanCoroutine ---
		void Gameplay_Chat_Control_ChatController__StopBanCoroutine(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int param3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a57b7e == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_ChatRoomData___);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5344);
		    DAT_ram_00a57b7e = '\x01';
		  }
		  iVar7 = *param1;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x100) * 4))
		                    (param1,*(undefined4 *)(iVar7 + 0x104));
		  iVar7 = Gameplay_Chat_Model_ChatModel__AddRoom(uVar2,iVar7);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x80e2bc3f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e2bc3f:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  param3 = Core_Extensions_Dict_DictExt__GetChatRoomDic(uVar2,0);
		  iVar5 = OKG_Logs_Debug_TypeInfo;
		  if (param3 == 0) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(StringLiteral_5344,0);
		    iVar6 = *(int *)(iVar7 + 0xc);
		    param3 = iVar5;
		  }
		  else {
		    iVar6 = *(int *)(iVar7 + 0xc);
		    if (0 < iVar6) {
		      piVar4 = (int *)(param3 + 0xc);
		      param3 = 0;
		      do {
		        iVar5 = *(int *)(iVar7 + param3 * 4 + 0x10);
		        if (*piVar4 == *(int *)(*(int *)(*(int *)(iVar5 + 0x14) + 0xc) + 0xc)) {
		          Gameplay_Chat_Control_ChatController__AddRoom(param1,iVar5,param3);
		          return;
		        }
		        param3 = param3 + 1;
		      } while (param3 != iVar6);
		      goto code_r0x80e2bd1c;
		    }
		  }
		  if (iVar6 == 0) {
		    iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar7 = *(int *)(iVar7 + 0x4c);
		    if (iVar7 == 0) {
		      return;
		    }
		    (**(code **)((ulonglong)*(uint *)(iVar7 + 0xc) * 4))
		              (*(undefined4 *)(iVar7 + 0x20),*(undefined4 *)(iVar7 + 0x14));
		    return;
		  }
		code_r0x80e2bd1c:
		  uVar2 = System_Linq_Enumerable__Count_object_
		                    (iVar7,Method_System_Linq_Enumerable_First_ChatRoomData___);
		  Gameplay_Chat_Control_ChatController__AddRoom(param1,uVar2,param3);
		  return;
		}
		*/

		}

		// Token: 0x060044FC RID: 17660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044FC")]
		[Address(RVA = "0x93A2", Offset = "0x93A2", VA = "0x93A2")]
		private void DefineCurrentRoom()
		{
		/* --- GHIDRA: DefineCurrentRoom ---
		void Gameplay_Chat_Control_ChatController__DefineCurrentRoom
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined8 param5,undefined4 param6)
		
		{
		  Gameplay_Chat_Control_ChatController__RequestRemoveToFavorites
		            (param1,param3,param2,param4,param5,param4);
		  return;
		}
		*/

		}

		// Token: 0x060044FD RID: 17661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044FD")]
		[Address(RVA = "0x93A3", Offset = "0x93A3", VA = "0x93A3")]
		private void SendMessage(string text, ChatRoomData room, ChatMessage.Types.ChatMessageTypes messageType, ulong userId)
		{
		/* --- GHIDRA: SendMessage ---
		undefined4
		Gameplay_Chat_Control_ChatController__SendMessage
		          (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param3_00;
		  undefined4 param1_00;
		  
		  param3_00 = Gameplay_Chat_Control_ChatController__StopListenServiceEvents(param1,param3,param1);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Chat_Model_ChatModel__AddVisitor(param1_00,param2,param3_00,param1);
		  return param3_00;
		}
		*/

		}

		// Token: 0x060044FE RID: 17662 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60044FE")]
		[Address(RVA = "0x93A4", Offset = "0x93A4", VA = "0x93A4")]
		private ChatVisitorData JoinUserToRoom(RoomKey roomKey, ChatUserInfo userInfo)
		{
		/* --- GHIDRA: JoinUserToRoom ---
		int Gameplay_Chat_Control_ChatController__JoinUserToRoom(int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  longlong param3_00;
		  int *piVar8;
		  int iVar9;
		  uint uVar10;
		  int local_10;
		  int **local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57b7f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Count_AttackabilityInfo___);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_AttackabilityInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_AttackabilityInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ChatVisitorData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ChatVisitorData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ChatVisitorData__TypeInfo);
		    DAT_ram_00a57b7f = '\x01';
		  }
		  local_8 = 0;
		  uVar1 = func_ii_6330(param2,Method_System_Linq_Enumerable_Count_AttackabilityInfo___);
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_ChatVisitorData__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (iVar2,uVar1,Method_System_Collections_Generic_List_ChatVisitorData___ctor__);
		  iVar9 = *param2;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_AttackabilityInfo__TypeInfo ==
		          *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8)) {
		        puVar3 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e2bf8f;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_IEnumerable_AttackabilityInfo__TypeInfo,0
		                               );
		code_r0x80e2bf8f:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  local_10 = 0;
		  local_c = &local_4;
		code_r0x80e2bfb4:
		  do {
		    do {
		      piVar7 = local_4;
		      iVar9 = *local_4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		            puVar4 = (undefined4 *)(iVar9 + piVar8[1] * 8 + 0xc0);
		            goto code_r0x80e2c05c;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80e2c0a0:
		        DAT_ram_009d3e38 = 0;
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e2c325;
		      }
		code_r0x80e2c05c:
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		      piVar7 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e2c0a0;
		      if (iVar9 == 0) goto code_r0x80e2c36e;
		      iVar9 = *local_4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8);
		          if (System_Collections_Generic_IEnumerator_AttackabilityInfo__TypeInfo == *piVar8) {
		            puVar4 = (undefined4 *)(iVar9 + piVar8[1] * 8 + 0xc0);
		            goto code_r0x80e2c14b;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_AttackabilityInfo__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80e2c26a:
		        DAT_ram_009d3e38 = 0;
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e2c325;
		      }
		code_r0x80e2c14b:
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e2c26a;
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e2c325;
		      }
		      param3_00 = *(longlong *)(iVar9 + 0x10);
		      if (DAT_ram_00a57b3e == '\0') {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (0x7ff,&
		                         Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData__TryGetValue__
		                  );
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_00a57b3e = '\x01';
		          goto code_r0x80e2c218;
		        }
		code_r0x80e2c27e:
		        DAT_ram_009d3e38 = 0;
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e2c325;
		      }
		code_r0x80e2c218:
		      if (param3_00 == 0) {
		        local_8 = 0;
		        goto code_r0x80e2bfb4;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar6 = unnamed_function_184060
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2c,
		                         *(undefined4 *)(iVar5 + 0x3c),param3_00,&local_8,
		                         Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData__TryGetValue__
		                        );
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e2c27e;
		    } while (iVar6 == 0);
		    *(int *)(local_8 + 8) = iVar9;
		    iVar9 = Method_System_Collections_Generic_List_ChatVisitorData__Add__;
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar10 = *(uint *)(iVar2 + 0xc);
		    if (uVar10 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar10 + 1;
		      *(int *)(*(int *)(iVar2 + 8) + uVar10 * 4 + 0x10) = local_8;
		      goto code_r0x80e2bfb4;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,local_8,
		               *(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar9 != 1);
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e2c325:
		  iVar9 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar1);
		    local_10 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		code_r0x80e2c36e:
		      DAT_ram_009d3e38 = 0;
		      piVar7 = *local_c;
		      if (piVar7 != (int *)0x0) {
		        uVar10 = 0;
		        iVar9 = *piVar7;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8)) {
		              puVar3 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80e2c3e9;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x80e2c3e9:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		      }
		      if (local_10 == 0) {
		        return iVar2;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_10);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2d,&local_10);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60044FF")]
		[Address(RVA = "0x93A5", Offset = "0x93A5", VA = "0x93A5")]
		private List<ChatVisitorData> UpdateAttackAbility(IEnumerable<AttackabilityInfo> value)
		{
		/* --- GHIDRA: UpdateAttackAbility ---
		undefined4
		Gameplay_Chat_Control_ChatController__UpdateAttackAbility
		          (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  uVar1 = Gameplay_Chat_Control_ChatController__ParseVisitor(param1,param3,param1);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = func_ii_7092(param1_00,param2,uVar1,param1);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004500")]
		[Address(RVA = "0x93A6", Offset = "0x93A6", VA = "0x93A6")]
		private ChatMessageItem AddMessage(RoomKey roomKey, ChatMessage message)
		{
		/* --- GHIDRA: AddMessage ---
		undefined4
		Gameplay_Chat_Control_ChatController__AddMessage(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  
		  if (DAT_ram_00a57b81 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ChatMessageItem___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_ChatMessageItem___);
		    Mono_Security_ASN1__get_Item(&System_Func_ChatMessageItem__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController___c__FilterMessage_b__29_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Control_ChatController___c_TypeInfo);
		    DAT_ram_00a57b81 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(char *)(iVar1 + 0x4a) == -1) {
		    if (*(int *)(Gameplay_Chat_Control_ChatController___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Chat_Control_ChatController___c_TypeInfo);
		    }
		    puVar3 = *(undefined4 **)(Gameplay_Chat_Control_ChatController___c_TypeInfo + 0x5c);
		    iVar1 = puVar3[1];
		    if (iVar1 == 0) {
		      if (*(int *)(Gameplay_Chat_Control_ChatController___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Chat_Control_ChatController___c_TypeInfo);
		        puVar3 = *(undefined4 **)(Gameplay_Chat_Control_ChatController___c_TypeInfo + 0x5c);
		      }
		      uVar2 = *puVar3;
		      iVar1 = unnamed_function_1417(System_Func_ChatMessageItem__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (iVar1,uVar2,
		                 Method_Gameplay_Chat_Control_ChatController___c__FilterMessage_b__29_0__,0);
		      *(int *)(*(int *)(Gameplay_Chat_Control_ChatController___c_TypeInfo + 0x5c) + 4) = iVar1;
		    }
		    uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                      (param2,iVar1,Method_System_Linq_Enumerable_Where_ChatMessageItem___);
		    param2 = func_ii_6295(uVar2,Method_System_Linq_Enumerable_ToArray_ChatMessageItem___);
		  }
		  return param2;
		}
		*/

		/* --- GHIDRA: AddMessage ---
		undefined4
		Gameplay_Chat_Control_ChatController__AddMessage(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  
		  if (DAT_ram_00a57b81 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ChatMessageItem___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_ChatMessageItem___);
		    Mono_Security_ASN1__get_Item(&System_Func_ChatMessageItem__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController___c__FilterMessage_b__29_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Control_ChatController___c_TypeInfo);
		    DAT_ram_00a57b81 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(char *)(iVar1 + 0x4a) == -1) {
		    if (*(int *)(Gameplay_Chat_Control_ChatController___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Chat_Control_ChatController___c_TypeInfo);
		    }
		    puVar3 = *(undefined4 **)(Gameplay_Chat_Control_ChatController___c_TypeInfo + 0x5c);
		    iVar1 = puVar3[1];
		    if (iVar1 == 0) {
		      if (*(int *)(Gameplay_Chat_Control_ChatController___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Chat_Control_ChatController___c_TypeInfo);
		        puVar3 = *(undefined4 **)(Gameplay_Chat_Control_ChatController___c_TypeInfo + 0x5c);
		      }
		      uVar2 = *puVar3;
		      iVar1 = unnamed_function_1417(System_Func_ChatMessageItem__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (iVar1,uVar2,
		                 Method_Gameplay_Chat_Control_ChatController___c__FilterMessage_b__29_0__,0);
		      *(int *)(*(int *)(Gameplay_Chat_Control_ChatController___c_TypeInfo + 0x5c) + 4) = iVar1;
		    }
		    uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                      (param2,iVar1,Method_System_Linq_Enumerable_Where_ChatMessageItem___);
		    param2 = func_ii_6295(uVar2,Method_System_Linq_Enumerable_ToArray_ChatMessageItem___);
		  }
		  return param2;
		}
		*/

			return null;
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004501")]
		[Address(RVA = "0x93A7", Offset = "0x93A7", VA = "0x93A7")]
		private ChatMessageItem AddMessage(RoomKey roomKey, ChatMessageData message)
		{
			return null;
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004502")]
		[Address(RVA = "0x1BB7", Offset = "0x1BB7", VA = "0x1BB7")]
		private void NotifyMessageReceived(ChatMessageItem message)
		{
		/* --- GHIDRA: NotifyMessageReceived ---
		int * Gameplay_Chat_Control_ChatController__NotifyMessageReceived(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004503 RID: 17667 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004503")]
		[Address(RVA = "0x93A8", Offset = "0x93A8", VA = "0x93A8")]
		private IList<ChatMessageItem> FilterMessage(IList<ChatMessageItem> messages)
		{
		/* --- GHIDRA: FilterMessage ---
		undefined4 Gameplay_Chat_Control_ChatController__FilterMessage(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = *(int *)(iVar1 + 0x30);
		  if (DAT_ram_00a57b82 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_ChatMessageItem___TypeInfo);
		    DAT_ram_00a57b82 = '\x01';
		  }
		  if (iVar1 == 0) {
		    uVar2 = Mono_Security_ASN1Convert__ToOid
		                      (Gameplay_Chat_Model_Data_Message_ChatMessageItem___TypeInfo,0);
		    return uVar2;
		  }
		  uVar2 = Gameplay_Chat_Control_ChatController__AddMessage
		                    (param1,*(undefined4 *)(iVar1 + 0xc),param1);
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004504")]
		[Address(RVA = "0x93A9", Offset = "0x93A9", VA = "0x93A9")]
		public IList<ChatMessageItem> GetCurrentRoomMessages()
		{
		/* --- GHIDRA: GetCurrentRoomMessages ---
		undefined4
		Gameplay_Chat_Control_ChatController__GetCurrentRoomMessages
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57b82 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_ChatMessageItem___TypeInfo);
		    DAT_ram_00a57b82 = '\x01';
		  }
		  if (param2 == 0) {
		    uVar1 = Mono_Security_ASN1Convert__ToOid
		                      (Gameplay_Chat_Model_Data_Message_ChatMessageItem___TypeInfo,0);
		    return uVar1;
		  }
		  uVar1 = Gameplay_Chat_Control_ChatController__AddMessage
		                    (param1,*(undefined4 *)(param2 + 0xc),param2);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06004505 RID: 17669 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004505")]
		[Address(RVA = "0x93AA", Offset = "0x93AA", VA = "0x93AA")]
		public IList<ChatMessageItem> GetRoomMessages(ChatRoomData room)
		{
		/* --- GHIDRA: GetRoomMessages ---
		void Gameplay_Chat_Control_ChatController__GetRoomMessages
		               (int *param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  uint uVar4;
		  uint uVar5;
		  uint uVar6;
		  int iVar7;
		  int iVar8;
		  
		  uVar5 = 0;
		  iVar2 = 0;
		  if (DAT_ram_00a57b83 == '\0') {
		    Mono_Security_ASN1__get_Item(&int___TypeInfo);
		    DAT_ram_00a57b83 = '\x01';
		  }
		  iVar3 = Mono_Security_ASN1Convert__ToOid(int___TypeInfo,*(undefined4 *)(param3 + 0xc));
		  uVar4 = *(uint *)(param3 + 0xc);
		  if (0 < (int)uVar4) {
		    if (uVar4 == 1) {
		      iVar1 = 0;
		    }
		    else {
		      iVar1 = 0;
		      do {
		        uVar6 = iVar1 * 4;
		        iVar7 = *(int *)(param3 + 0x10 + uVar6);
		        *(undefined4 *)(iVar3 + 0x10 + uVar6) = *(undefined4 *)(iVar7 + 0x10);
		        iVar7 = *(int *)(iVar7 + 0x10);
		        iVar8 = *(int *)((uVar6 | 4) + param3 + 0x10);
		        *(undefined4 *)(iVar3 + 0x10 + (uVar6 | 4)) = *(undefined4 *)(iVar8 + 0x10);
		        iVar2 = *(int *)(iVar8 + 0x10) + iVar2 + iVar7;
		        iVar1 = iVar1 + 2;
		        uVar5 = uVar5 + 2;
		      } while (uVar5 != (uVar4 & 0xfffffffe));
		    }
		    if ((uVar4 & 1) != 0) {
		      iVar7 = *(int *)(iVar1 * 4 + param3 + 0x10);
		      *(undefined4 *)(iVar3 + iVar1 * 4 + 0x10) = *(undefined4 *)(iVar7 + 0x10);
		      iVar2 = *(int *)(iVar7 + 0x10) + iVar2;
		    }
		  }
		  param1[1] = iVar3;
		  *param1 = iVar2;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004506 RID: 17670 RVA: 0x0000D080 File Offset: 0x0000B280
		[Token(Token = "0x6004506")]
		[Address(RVA = "0x93AB", Offset = "0x93AB", VA = "0x93AB")]
		public NotViewedMessagesInfoData GetNotViewedMessageCount(params ChatRoomData[] rooms)
		{
		/* --- GHIDRA: GetNotViewedMessageCount ---
		void Gameplay_Chat_Control_ChatController__GetNotViewedMessageCount
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  uint uVar3;
		  
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a57b3a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ChatVisitorData__Add__);
		    DAT_ram_00a57b3a = '\x01';
		  }
		  iVar1 = Method_System_Collections_Generic_List_ChatVisitorData__Add__;
		  iVar2 = *(int *)(iVar2 + 0x34);
		  *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		  uVar3 = *(uint *)(iVar2 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		    *(uint *)(iVar2 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(iVar2 + 8) + uVar3 * 4 + 0x10) = param2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar2,param2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(char *)(iVar2 + 0x48) == -1) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x24);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),param2,*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

			return default(NotViewedMessagesInfoData);
		}

		// Token: 0x06004507 RID: 17671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004507")]
		[Address(RVA = "0x93AC", Offset = "0x93AC", VA = "0x93AC")]
		private void AddToFavoritesInternal(ChatVisitorData visitor)
		{
		/* --- GHIDRA: AddToFavoritesInternal ---
		void Gameplay_Chat_Control_ChatController__AddToFavoritesInternal
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a57b3c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ChatVisitorData__Remove__);
		    DAT_ram_00a57b3c = '\x01';
		  }
		  iVar1 = func_ii_4876(*(undefined4 *)(iVar1 + 0x34),param2,
		                       Method_System_Collections_Generic_List_ChatVisitorData__Remove__);
		  if ((iVar1 != 0) &&
		     (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104)), *(char *)(iVar1 + 0x48) == -1)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x20);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004508 RID: 17672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004508")]
		[Address(RVA = "0x93AD", Offset = "0x93AD", VA = "0x93AD")]
		private void RemoveFromFavoritesInternal(ChatVisitorData visitor)
		{
		/* --- GHIDRA: RemoveFromFavoritesInternal ---
		void Gameplay_Chat_Control_ChatController__RemoveFromFavoritesInternal
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  uint uVar2;
		  uint uVar3;
		  uint uVar4;
		  int iVar5;
		  uint uVar6;
		  int iVar7;
		  uint uVar8;
		  int iVar9;
		  int iVar10;
		  ulonglong local_10;
		  ulonglong local_8;
		  
		  uVar6 = 0;
		  if (*(char *)(param2 + 0x10) == '\0') {
		    *(int *)(*(int *)(param2 + 8) + 0x10) = *(int *)(*(int *)(param2 + 8) + 0x10) + -1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x48);
		    if (iVar1 != 0) {
		      iVar7 = *param1;
		      param1_00 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x100) * 4))
		                            (param1,*(undefined4 *)(iVar7 + 0x104));
		      iVar7 = Gameplay_Chat_Model_ChatModel__AddRoom(param1_00,iVar7);
		      if (DAT_ram_00a57b83 == '\0') {
		        Mono_Security_ASN1__get_Item(&int___TypeInfo);
		        DAT_ram_00a57b83 = '\x01';
		      }
		      uVar2 = Mono_Security_ASN1Convert__ToOid(int___TypeInfo,*(undefined4 *)(iVar7 + 0xc));
		      uVar3 = *(uint *)(iVar7 + 0xc);
		      if ((int)uVar3 < 1) {
		        local_10 = 0;
		      }
		      else {
		        if (uVar3 == 1) {
		          uVar4 = 0;
		          iVar5 = 0;
		        }
		        else {
		          uVar4 = 0;
		          iVar5 = 0;
		          do {
		            uVar8 = iVar5 * 4;
		            iVar9 = *(int *)(iVar7 + 0x10 + uVar8);
		            *(undefined4 *)(uVar2 + 0x10 + uVar8) = *(undefined4 *)(iVar9 + 0x10);
		            iVar9 = *(int *)(iVar9 + 0x10);
		            iVar10 = *(int *)((uVar8 | 4) + iVar7 + 0x10);
		            *(undefined4 *)(uVar2 + 0x10 + (uVar8 | 4)) = *(undefined4 *)(iVar10 + 0x10);
		            uVar4 = *(int *)(iVar10 + 0x10) + uVar4 + iVar9;
		            iVar5 = iVar5 + 2;
		            uVar6 = uVar6 + 2;
		          } while (uVar6 != (uVar3 & 0xfffffffe));
		        }
		        if ((uVar3 & 1) != 0) {
		          iVar7 = *(int *)(iVar5 * 4 + iVar7 + 0x10);
		          *(undefined4 *)(uVar2 + iVar5 * 4 + 0x10) = *(undefined4 *)(iVar7 + 0x10);
		          uVar4 = *(int *)(iVar7 + 0x10) + uVar4;
		        }
		        local_10 = (ulonglong)uVar4;
		      }
		      local_10 = (ulonglong)uVar2 << 0x20 | local_10;
		      local_8 = local_10;
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),&local_10,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004509 RID: 17673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004509")]
		[Address(RVA = "0x1BB6", Offset = "0x1BB6", VA = "0x1BB6")]
		private void IncrementNotViewMessages(ChatRoomData room)
		{
		/* --- GHIDRA: IncrementNotViewMessages ---
		void Gameplay_Chat_Control_ChatController__IncrementNotViewMessages
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a57b80 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_ChatMessageItem___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_ChatMessageItem___);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ChatMessageItem__TypeInfo);
		    DAT_ram_00a57b80 = '\x01';
		  }
		  piVar2 = (int *)Mono_Security_ASN1Convert__ToOid
		                            (Gameplay_Chat_Model_Data_Message_ChatMessageItem___TypeInfo,1);
		  if ((param2 != 0) && (iVar5 = func_ii_1082(param2,*(undefined4 *)(*piVar2 + 0x20)), iVar5 == 0)) {
		    uVar4 = func_ii_1083();
		    func_ii_1050(uVar4,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[4] = param2;
		  piVar2 = (int *)Gameplay_Chat_Control_ChatController__AddMessage(param1,piVar2,param2);
		  uVar1 = 0;
		  iVar5 = *piVar2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_ChatMessageItem__TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e2c5a0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,
		                                System_Collections_Generic_ICollection_ChatMessageItem__TypeInfo,0);
		code_r0x80e2c5a0:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  if (0 < iVar5) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar5 = *(int *)(iVar5 + 0x30);
		    if (iVar5 != 0) {
		      uVar4 = System_Linq_Enumerable__Count_object_
		                        (piVar2,Method_System_Linq_Enumerable_First_ChatMessageItem___);
		      (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		                (*(undefined4 *)(iVar5 + 0x20),uVar4,*(undefined4 *)(iVar5 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600450A RID: 17674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600450A")]
		[Address(RVA = "0x93AE", Offset = "0x93AE", VA = "0x93AE")]
		private void TryDecrementNotViewMessages(ChatMessageItem message)
		{
		/* --- GHIDRA: TryDecrementNotViewMessages ---
		void Gameplay_Chat_Control_ChatController__TryDecrementNotViewMessages(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57b84 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleGetChatInfoService__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57b84 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ChatService__ServerEventHandler(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,Method_Gameplay_Chat_Control_ChatController_HandleGetChatInfoService__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600450B RID: 17675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600450B")]
		[Address(RVA = "0x93AF", Offset = "0x93AF", VA = "0x93AF")]
		private void RequestGetChatInfo()
		{
		/* --- GHIDRA: RequestGetChatInfo ---
		void Gameplay_Chat_Control_ChatController__RequestGetChatInfo(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57b85 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleTakeOffBanService__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57b85 = '\x01';
		  }
		  param1_00 = ServicesNamespace_ChatService__BanUser(*(undefined4 *)(param1 + 0x18),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,Method_Gameplay_Chat_Control_ChatController_HandleTakeOffBanService__,
		             0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x0600450C RID: 17676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600450C")]
		[Address(RVA = "0x93B0", Offset = "0x93B0", VA = "0x93B0")]
		private void RequestTakeOffBan()
		{
		/* --- GHIDRA: RequestTakeOffBan ---
		void Gameplay_Chat_Control_ChatController__RequestTakeOffBan
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57b86 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleGetRoomInfoService__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57b86 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ChatService__GetChatInfo
		                    (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(*(int *)(param2 + 0x14) + 0xc),0
		                    );
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,Method_Gameplay_Chat_Control_ChatController_HandleGetRoomInfoService__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,param2,
		                     Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600450D RID: 17677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600450D")]
		[Address(RVA = "0x93B1", Offset = "0x93B1", VA = "0x93B1")]
		private void RequestGetRoomInfo(ChatRoomData room)
		{
		/* --- GHIDRA: RequestGetRoomInfo ---
		void Gameplay_Chat_Control_ChatController__RequestGetRoomInfo(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57b87 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleGetAllComplaintsService__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57b87 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ChatService__RemoveMessage(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Chat_Control_ChatController_HandleGetAllComplaintsService__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600450E RID: 17678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600450E")]
		[Address(RVA = "0x93B2", Offset = "0x93B2", VA = "0x93B2")]
		private void RequestGetAllComplaints()
		{
		/* --- GHIDRA: RequestGetAllComplaints ---
		void Gameplay_Chat_Control_ChatController__RequestGetAllComplaints(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57b88 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleGetContactListService__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57b88 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ChatService__SendMessage(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Chat_Control_ChatController_HandleGetContactListService__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600450F RID: 17679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600450F")]
		[Address(RVA = "0x93B3", Offset = "0x93B3", VA = "0x93B3")]
		private void RequestGetContactList()
		{
		/* --- GHIDRA: RequestGetContactList ---
		void Gameplay_Chat_Control_ChatController__RequestGetContactList
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57b89 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleAddToFavoritesService__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57b89 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ChatService__GetContactList(*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Chat_Control_ChatController_HandleAddToFavoritesService__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004510 RID: 17680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004510")]
		[Address(RVA = "0x93B4", Offset = "0x93B4", VA = "0x93B4")]
		private void RequestAddToFavorites(ulong userId)
		{
		/* --- GHIDRA: RequestAddToFavorites ---
		void Gameplay_Chat_Control_ChatController__RequestAddToFavorites
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57b8a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleRemoveFromFavoritesService__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57b8a = '\x01';
		  }
		  param1_00 = ServicesNamespace_ChatService__AddToFavorites(*(undefined4 *)(param1 + 0x18),param2,0)
		  ;
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Chat_Control_ChatController_HandleRemoveFromFavoritesService__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06004511 RID: 17681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004511")]
		[Address(RVA = "0x93B5", Offset = "0x93B5", VA = "0x93B5")]
		private void RequestRemoveToFavorites(ulong userId)
		{
		/* --- GHIDRA: RequestRemoveToFavorites ---
		void Gameplay_Chat_Control_ChatController__RequestRemoveToFavorites
		               (int param1,int param2,undefined4 param3,undefined4 param4,undefined8 param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a57b8b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleSendMessageService__);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ChatScope_ChatEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57b8b = '\x01';
		  }
		  uVar1 = ServicesNamespace_ChatService__GetRoomInfo
		                    (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(*(int *)(param2 + 0x14) + 0xc),
		                     param3,param4,param5,0);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Gameplay_Chat_Control_ChatController_HandleSendMessageService__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,uVar2,param2,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  iVar3 = System_Uri___ctor(0);
		  iVar3 = *(int *)(*(int *)(*(int *)(*(int *)(iVar3 + 0x38) + 0x10) + 0x70) + 8);
		  if (iVar3 != 0) {
		    uVar1 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    uVar2 = unnamed_function_1417(Core_Events_Scopes_ChatScope_ChatEventArgs_TypeInfo);
		    Core_Events_Scopes_ChatScope_ChatEventArgs__get_ToUserId
		              (uVar2,uVar1,param3_00,param2,param3,param4,param5,0);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),uVar2,*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004512 RID: 17682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004512")]
		[Address(RVA = "0x93B6", Offset = "0x93B6", VA = "0x93B6")]
		private void RequestSendMessage(ChatRoomData room, string text, ChatMessage.Types.ChatMessageTypes messageType, ulong toUserId)
		{
		/* --- GHIDRA: RequestSendMessage ---
		void Gameplay_Chat_Control_ChatController__RequestSendMessage
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57b8c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleSendComplaintService__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57b8c = '\x01';
		  }
		  uVar1 = ServicesNamespace_ChatService__GetAllComplaints
		                    (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(*(int *)(param2 + 0x14) + 0xc),
		                     param3,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Chat_Control_ChatController_HandleSendComplaintService__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004513 RID: 17683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004513")]
		[Address(RVA = "0x93B7", Offset = "0x93B7", VA = "0x93B7")]
		private void RequestSendComplaint(ChatRoomData room, uint messageId)
		{
		/* --- GHIDRA: RequestSendComplaint ---
		void Gameplay_Chat_Control_ChatController__RequestSendComplaint
		               (int param1,undefined4 param2,undefined4 param3,int param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57b8d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleRemoveMessageService__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a57b8d = '\x01';
		  }
		  param1_00 = ServicesNamespace_ChatService__RemoveFromFavorites
		                        (*(undefined4 *)(param1 + 0x18),param2,param3,0,0);
		  if (param4 != 0) {
		    DG_Tweening_TweenParams__SetId
		              (param1_00,param4,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  }
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Chat_Control_ChatController_HandleRemoveMessageService__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004514 RID: 17684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004514")]
		[Address(RVA = "0x93B8", Offset = "0x93B8", VA = "0x93B8")]
		private void RequestRemoveMessage(RoomKey roomKey, uint messageId, ChatComplaintData complaint)
		{
		/* --- GHIDRA: RequestRemoveMessage ---
		void Gameplay_Chat_Control_ChatController__RequestRemoveMessage
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57b8e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandleProcessComplaintService__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57b8e = '\x01';
		  }
		  param1_00 = ServicesNamespace_ChatService__SendComplaint
		                        (*(undefined4 *)(param1 + 0x18),param2,param3,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Chat_Control_ChatController_HandleProcessComplaintService__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06004515 RID: 17685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004515")]
		[Address(RVA = "0x93B9", Offset = "0x93B9", VA = "0x93B9")]
		private void RequestProcessComplaint(uint complaintId, bool accepted)
		{
		/* --- GHIDRA: RequestProcessComplaint ---
		void Gameplay_Chat_Control_ChatController__RequestProcessComplaint
		               (int param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57b8f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Control_ChatController_HandlerBanUserService__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57b8f = '\x01';
		  }
		  param1_00 = ServicesNamespace_ChatService__ProcessComplaint
		                        (*(undefined4 *)(param1 + 0x18),param2,param3,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,Method_Gameplay_Chat_Control_ChatController_HandlerBanUserService__,0)
		  ;
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06004516 RID: 17686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004516")]
		[Address(RVA = "0x93BA", Offset = "0x93BA", VA = "0x93BA")]
		private void RequestBanUser(ulong userId, uint banId)
		{
		/* --- GHIDRA: RequestBanUser ---
		void Gameplay_Chat_Control_ChatController__RequestBanUser(int *param1,int param2,undefined4 param3)
		
		{
		  char cVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *param1_00;
		  
		  if (DAT_ram_00a57b90 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoGetChatInfoAns_TypeInfo);
		    DAT_ram_00a57b90 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Chat_ProtoGetChatInfoAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Chat_ProtoGetChatInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar2 = Gameplay_Chat_Control_ChatController__StopListenServiceEvents(param1,param1_00[3],param1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar3 + 0x2c) = uVar2;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  cVar1 = *(char *)(iVar3 + 0x38);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  if (cVar1 == '\0') {
		    iVar3 = *(int *)(iVar3 + 0xc);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		    }
		    Gameplay_Chat_Control_ChatController__RequestGetAllComplaints(param1,param1);
		    return;
		  }
		  iVar3 = *(int *)(iVar3 + 0x28);
		  if (iVar3 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004517 RID: 17687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004517")]
		[Address(RVA = "0x93BB", Offset = "0x93BB", VA = "0x93BB")]
		private void HandleGetChatInfoService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetChatInfoService ---
		void Gameplay_Chat_Control_ChatController__HandleGetChatInfoService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int *param1_01;
		  int iVar5;
		  undefined4 uVar6;
		  int local_4;
		  
		  if (DAT_ram_00a57b91 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_ChatRoomData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoGetRoomInfoAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ChatUserInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ChatMessage__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ChatMessage__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ChatUserInfo__get_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5346);
		    DAT_ram_00a57b91 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Chat_ProtoGetRoomInfoAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Chat_ProtoGetRoomInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_01 = *(int **)(param2 + 0xc);
		  if (param1_01 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_01 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Chat_Model_Data_ChatRoomData_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_01 + 100) +
		                 (uint)*(byte *)(Gameplay_Chat_Model_Data_ChatRoomData_TypeInfo + 0xb8) * 4 + -4) !=
		        Gameplay_Chat_Model_Data_ChatRoomData_TypeInfo)) {
		      System_Activator__CreateInstance(param1_01,Gameplay_Chat_Model_Data_ChatRoomData_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar5 = param1_00[3];
		  if (iVar5 < 0) {
		    *(undefined1 *)(param1_01 + 6) = 0;
		    local_4 = iVar5;
		    uVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    uVar2 = func_ii_4419(StringLiteral_5346,uVar2,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar2,0);
		  }
		  iVar5 = *(int *)(param1_00[6] + 0xc);
		  if (0 < iVar5) {
		    iVar1 = 0;
		    do {
		      uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (param1_00[6],iVar1,
		                         Method_Google_Protobuf_Collections_RepeatedField_ChatUserInfo__get_Item__);
		      Gameplay_Chat_Control_ChatController__StopListenServiceEvents(param1,uVar2,param1);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar5);
		  }
		  iVar5 = *(int *)(param1_00[4] + 0xc);
		  if (0 < iVar5) {
		    iVar1 = 0;
		    do {
		      uVar6 = *(undefined4 *)(param1_01[5] + 0xc);
		      uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (param1_00[4],iVar1,
		                         Method_Google_Protobuf_Collections_RepeatedField_ChatUserInfo__get_Item__);
		      uVar2 = Gameplay_Chat_Control_ChatController__StopListenServiceEvents(param1,uVar2,param1);
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      Gameplay_Chat_Model_ChatModel__AddVisitor(uVar3,uVar6,uVar2,param1);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar5);
		  }
		  Gameplay_Chat_Control_ChatController__JoinUserToRoom(param1,param1_00[7],param1);
		  iVar5 = *(int *)(param1_00[5] + 0xc);
		  if (0 < iVar5) {
		    iVar1 = 0;
		    do {
		      uVar6 = *(undefined4 *)(param1_01[5] + 0xc);
		      uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (param1_00[5],iVar1,
		                         Method_Google_Protobuf_Collections_RepeatedField_ChatMessage__get_Item__);
		      uVar2 = Gameplay_Chat_Control_ChatController__ParseVisitor(param1,uVar2,param1);
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      iVar4 = func_ii_7092(uVar3,uVar6,uVar2,param1);
		      *(undefined1 *)(iVar4 + 0x10) = 1;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar5);
		  }
		  if ((-1 < param1_00[3]) && (*(int *)(*(int *)(param1_01[5] + 0xc) + 0xc) == 100)) {
		    Gameplay_Chat_Control_ChatController__RequestGetRoomInfo(param1,param1);
		  }
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (param1_01 == *(int **)(iVar5 + 0x30)) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar5 = *(int *)(iVar5 + 0x44);
		    if (iVar5 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		                (*(undefined4 *)(iVar5 + 0x20),*(undefined4 *)(iVar5 + 0x14));
		    }
		  }
		  Gameplay_Chat_Control_ChatController__ManageBan(param1,param1_01,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004518 RID: 17688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004518")]
		[Address(RVA = "0x93BC", Offset = "0x93BC", VA = "0x93BC")]
		private void HandleGetRoomInfoService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetRoomInfoService ---
		void Gameplay_Chat_Control_ChatController__HandleGetRoomInfoService
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param2_01;
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a57b92 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoGetAllComplaintsAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ProtoNewComplaintEvt__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ProtoNewComplaintEvt__get_Item__);
		    DAT_ram_00a57b92 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Chat_ProtoGetAllComplaintsAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Chat_ProtoGetAllComplaintsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = *(int *)(param1_00[3] + 0xc);
		  if (0 < iVar1) {
		    param2_00 = 0;
		    do {
		      param2_01 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                            (param1_00[3],param2_00,
		                             Method_Google_Protobuf_Collections_RepeatedField_ProtoNewComplaintEvt__get_Item__
		                            );
		      Gameplay_Chat_Control_ChatController__HandleUserInfoChangedEvent(param1,param2_01,param2_00);
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004519 RID: 17689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004519")]
		[Address(RVA = "0x93BD", Offset = "0x93BD", VA = "0x93BD")]
		private void HandleGetAllComplaintsService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetAllComplaintsService ---
		void Gameplay_Chat_Control_ChatController__HandleGetAllComplaintsService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a57b93 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoGetContactListAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ChatUserInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ChatUserInfo__get_Item__);
		    DAT_ram_00a57b93 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x10);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  iVar2 = 0;
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Chat_ProtoGetContactListAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Chat_ProtoGetContactListAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar5 = *(int *)(param1_00[3] + 0xc);
		  if (0 < iVar5) {
		    do {
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar4 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (param1_00[3],iVar2,
		                         Method_Google_Protobuf_Collections_RepeatedField_ChatUserInfo__get_Item__);
		      uVar4 = Gameplay_Chat_Control_ChatController__StopListenServiceEvents(param1,uVar4,iVar3);
		      if (DAT_ram_00a57b3a == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ChatVisitorData__Add__)
		        ;
		        DAT_ram_00a57b3a = '\x01';
		      }
		      iVar1 = Method_System_Collections_Generic_List_ChatVisitorData__Add__;
		      iVar3 = *(int *)(iVar3 + 0x34);
		      *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		      uVar6 = *(uint *)(iVar3 + 0xc);
		      if (uVar6 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		        *(uint *)(iVar3 + 0xc) = uVar6 + 1;
		        *(undefined4 *)(*(int *)(iVar3 + 8) + uVar6 * 4 + 0x10) = uVar4;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (iVar3,uVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      }
		      iVar2 = iVar2 + 1;
		    } while (iVar2 != iVar5);
		  }
		  iVar5 = *param1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                    (param1,*(undefined4 *)(iVar5 + 0x104));
		  *(undefined1 *)(iVar2 + 0x38) = 1;
		  if (*(char *)((int)param1 + 9) == '\0') {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    Gameplay_Chat_Control_ChatController__HandleVisitorBan(param1,iVar5);
		    Gameplay_Chat_Control_ChatController__ValidateInit(param1,iVar5);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 8);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x28);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600451A RID: 17690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600451A")]
		[Address(RVA = "0x93BE", Offset = "0x93BE", VA = "0x93BE")]
		private void HandleGetContactListService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetContactListService ---
		void Gameplay_Chat_Control_ChatController__HandleGetContactListService
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a57b94 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoAddToFavoritesAns_TypeInfo);
		    DAT_ram_00a57b94 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Chat_ProtoAddToFavoritesAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Chat_ProtoAddToFavoritesAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600451B RID: 17691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600451B")]
		[Address(RVA = "0x93BF", Offset = "0x93BF", VA = "0x93BF")]
		private void HandleAddToFavoritesService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600451C RID: 17692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600451C")]
		[Address(RVA = "0x93C0", Offset = "0x93C0", VA = "0x93C0")]
		private void HandleRemoveFromFavoritesService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleRemoveFromFavoritesService ---
		void Gameplay_Chat_Control_ChatController__HandleRemoveFromFavoritesService
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a57b95 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_ChatRoomData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedChatSendMessageErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoSendMessageAns_TypeInfo);
		    DAT_ram_00a57b95 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  param1_01 = *(int **)(param2 + 0xc);
		  if (param1_01 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_01 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Chat_Model_Data_ChatRoomData_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_01 + 100) +
		                 (uint)*(byte *)(Gameplay_Chat_Model_Data_ChatRoomData_TypeInfo + 0xb8) * 4 + -4) !=
		        Gameplay_Chat_Model_Data_ChatRoomData_TypeInfo)) {
		      System_Activator__CreateInstance(param1_01,Gameplay_Chat_Model_Data_ChatRoomData_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if ((param1_00 != (int *)0x0) && (Protocol_Chat_ProtoSendMessageAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Chat_ProtoSendMessageAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		            (param1_00[3],param1_01,
		             Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedChatSendMessageErrors___
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600451D RID: 17693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600451D")]
		[Address(RVA = "0x93C1", Offset = "0x93C1", VA = "0x93C1")]
		private void HandleSendMessageService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleSendMessageService ---
		void Gameplay_Chat_Control_ChatController__HandleSendMessageService
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  int *param1_00;
		  
		  if (DAT_ram_00a57b96 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedChatComplaintErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoSendComplaintAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4173);
		    DAT_ram_00a57b96 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Chat_ProtoSendComplaintAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Chat_ProtoSendComplaintAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedChatComplaintErrors___
		                    );
		  if (iVar1 == 0) {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3_00 = func_ii_7508(StringLiteral_4173,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar2,4,param3_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600451E RID: 17694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600451E")]
		[Address(RVA = "0x93C2", Offset = "0x93C2", VA = "0x93C2")]
		private void HandleSendComplaintService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600451F RID: 17695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600451F")]
		[Address(RVA = "0x93C3", Offset = "0x93C3", VA = "0x93C3")]
		private void HandlerBanUserService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004520 RID: 17696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004520")]
		[Address(RVA = "0x93C4", Offset = "0x93C4", VA = "0x93C4")]
		private void HandleProcessComplaintService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleProcessComplaintService ---
		void Gameplay_Chat_Control_ChatController__HandleProcessComplaintService
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param4;
		  
		  if (DAT_ram_00a57b97 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_ChatComplaintData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoRemoveMessageAns_TypeInfo);
		    DAT_ram_00a57b97 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param4 = *(int **)(param2 + 0xc);
		  if (param4 != (int *)0x0) {
		    if (((uint)*(byte *)(Gameplay_Chat_Model_Data_Message_ChatComplaintData_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*param4 + 0xb8)) &&
		       (*(int *)(*(int *)(*param4 + 100) +
		                 (uint)*(byte *)(Gameplay_Chat_Model_Data_Message_ChatComplaintData_TypeInfo + 0xb8)
		                 * 4 + -4) == Gameplay_Chat_Model_Data_Message_ChatComplaintData_TypeInfo)) {
		      Gameplay_Chat_Control_ChatController__RequestRemoveMessage(param1,param4[2],1,param4);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004521 RID: 17697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004521")]
		[Address(RVA = "0x93C5", Offset = "0x93C5", VA = "0x93C5")]
		private void HandleRemoveMessageService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004522 RID: 17698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004522")]
		[Address(RVA = "0x93C6", Offset = "0x93C6", VA = "0x93C6")]
		private void HandleTakeOffBanService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleTakeOffBanService ---
		void Gameplay_Chat_Control_ChatController__HandleTakeOffBanService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param3_00;
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 param2_00;
		  
		  param2_00 = *(undefined4 *)(param2 + 0xc);
		  param3_00 = Gameplay_Chat_Control_ChatController__StopListenServiceEvents
		                        (param1,*(undefined4 *)(param2 + 0x10),param1);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Chat_Model_ChatModel__AddVisitor(param1_00,param2_00,param3_00,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if ((*(char *)(iVar1 + 0x48) == '\0') &&
		     (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104)), *(int *)(iVar1 + 0x30) != 0)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = Protocol_Common_Location__Equals
		                      (*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x30) + 0x14) + 0xc),
		                       *(undefined4 *)(param2 + 0xc),0);
		    if (iVar1 != 0) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar1 = *(int *)(iVar1 + 0x18);
		      if (iVar1 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                  (*(undefined4 *)(iVar1 + 0x20),param3_00,*(undefined4 *)(iVar1 + 0x14));
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004523 RID: 17699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004523")]
		[Address(RVA = "0x93C7", Offset = "0x93C7", VA = "0x93C7")]
		private void HandleRoomJoinEvent(ProtoJoinRoomEvt msg)
		{
		/* --- GHIDRA: HandleRoomJoinEvent ---
		void Gameplay_Chat_Control_ChatController__HandleRoomJoinEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param1_00;
		  longlong param2_00;
		  undefined4 local_4;
		  
		  local_4 = 0;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  param2_00 = *(longlong *)(param2 + 0x10);
		  if (DAT_ram_00a57b3e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData__TryGetValue__);
		    DAT_ram_00a57b3e = '\x01';
		  }
		  if ((param2_00 != 0) &&
		     (iVar3 = func_ii_7090(*(undefined4 *)(iVar3 + 0x3c),param2_00,&local_4,
		                           Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData__TryGetValue__
		                          ), iVar3 != 0)) {
		    uVar1 = CONCAT44((int)((ulonglong)param2_00 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    Gameplay_Chat_Model_ChatModel__AddVisitorToRoom
		              (param1_00,*(undefined4 *)(param2 + 0xc),local_4,param1);
		    uVar1 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    if (*(char *)(iVar3 + 0x48) == '\0') {
		      uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		      if (*(int *)(iVar3 + 0x30) != 0) {
		        uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		        iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		        uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		        iVar3 = Protocol_Common_Location__Equals
		                          (*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x30) + 0x14) + 0xc),
		                           *(undefined4 *)(param2 + 0xc),0);
		        if (iVar3 != 0) {
		          iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                            (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x114)));
		          iVar3 = *(int *)(iVar3 + 0x1c);
		          if (iVar3 != 0) {
		            (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                      (*(undefined4 *)(iVar3 + 0x20),local_4,*(undefined4 *)(iVar3 + 0x14));
		          }
		        }
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004524 RID: 17700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004524")]
		[Address(RVA = "0x93C8", Offset = "0x93C8", VA = "0x93C8")]
		private void HandleRoomUnjoinEvent(ProtoUnjoinRoomEvt msg)
		{
		/* --- GHIDRA: HandleRoomUnjoinEvent ---
		void Gameplay_Chat_Control_ChatController__HandleRoomUnjoinEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int iVar3;
		  undefined4 param2_00;
		  int local_4;
		  
		  local_4 = 0;
		  iVar3 = *(int *)(param2 + 0x10);
		  if (*(int *)(iVar3 + 0x10) == 8) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = Gameplay_Chat_Model_ChatModel__RemoveVisitorFromRoom
		                      (uVar1,*(undefined4 *)(param2 + 0xc),
		                       *(undefined4 *)(*(int *)(param2 + 0x10) + 0xc),&local_4,param1);
		    iVar3 = local_4;
		    if (iVar2 != 0) {
		      iVar2 = **(int **)(local_4 + 0xc);
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xf8) * 4))
		                (*(int **)(local_4 + 0xc),*(undefined4 *)(*(int *)(param2 + 0x10) + 0x14),
		                 *(undefined4 *)(iVar2 + 0xfc));
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar2 = *(int *)(iVar2 + 0x2c);
		      if (iVar2 == 0) {
		        return;
		      }
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),iVar3,*(undefined4 *)(iVar2 + 0x14));
		      return;
		    }
		    iVar3 = *(int *)(param2 + 0x10);
		  }
		  param2_00 = *(undefined4 *)(param2 + 0xc);
		  uVar1 = Gameplay_Chat_Control_ChatController__ParseVisitor(param1,iVar3,param1);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = func_ii_7092(param1_00,param2_00,uVar1,param1);
		  Gameplay_Chat_Model_ChatModel__AddMessage(param1,*(undefined4 *)(iVar3 + 8),param1);
		  Gameplay_Chat_Control_ChatController__ManageBan(param1,*(undefined4 *)(iVar3 + 8),param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar2 + 0x30) == *(int *)(iVar3 + 8)) {
		    Gameplay_Chat_Control_ChatController__IncrementNotViewMessages(param1,iVar3,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004525 RID: 17701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004525")]
		[Address(RVA = "0x93C9", Offset = "0x93C9", VA = "0x93C9")]
		private void HandleNewMessageEvent(ProtoChatMessageEvt msg)
		{
		/* --- GHIDRA: HandleNewMessageEvent ---
		/* WARNING: Type propagation algorithm not settling */
		
		void Gameplay_Chat_Control_ChatController__HandleNewMessageEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 in_register_20000014;
		  undefined4 uVar2;
		  undefined8 uVar1;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int iVar7;
		  float fVar8;
		  undefined4 uVar9;
		  int iVar10;
		  int *piVar11;
		  longlong param2_00;
		  undefined8 uVar12;
		  double param1_00;
		  uint uVar13;
		  undefined1 auStack_40 [8];
		  undefined8 local_38;
		  undefined8 local_30;
		  longlong local_28 [3];
		  undefined8 local_10;
		  int local_4;
		  
		  if (DAT_ram_00a57b98 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ChatMessage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ChatUserInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__GetEnumerator__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_RoomKey__ChatRoomData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_RoomKey__ChatRoomData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_RoomKey__ChatRoomData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_RoomKey__ChatRoomData__get_Value__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_UserInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26324);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4183);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27717);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25589);
		    DAT_ram_00a57b98 = '\x01';
		  }
		  local_4 = 0;
		  local_10 = 0;
		  local_28[2] = 0;
		  local_28[1] = 0;
		  uVar12 = CONCAT44(in_register_20000004,param1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (uVar12,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  uVar5 = (undefined4)((ulonglong)uVar12 >> 0x20);
		  param2_00 = *(longlong *)(*(int *)(*(int *)(param2 + 0xc) + 0xc) + 0x10);
		  if (DAT_ram_00a57b3e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData__TryGetValue__);
		    DAT_ram_00a57b3e = '\x01';
		  }
		  if ((param2_00 != 0) &&
		     (iVar3 = func_ii_7090(*(undefined4 *)(iVar3 + 0x3c),param2_00,&local_4,
		                           Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData__TryGetValue__
		                          ), iVar3 != 0)) {
		    *(undefined4 *)(local_4 + 0x14) = *(undefined4 *)(param2 + 0xc);
		    uVar2 = (undefined4)((ulonglong)param2_00 >> 0x20);
		    Gameplay_Chat_Control_ChatController__UpdateVisitor(auStack_40,local_4,auStack_40);
		    uVar12 = CONCAT44(uVar5,param1);
		    uVar1 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(uVar12,uVar1);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar5 = (undefined4)((ulonglong)uVar12 >> 0x20);
		    if (*(int *)(iVar3 + 0x2c) == local_4) {
		      Gameplay_Chat_Control_ChatController__HandleVisitorBan(param1,auStack_40);
		    }
		    if (*(char *)(local_4 + 0xc) != '\0') {
		      if (((*(byte *)(*(int *)(local_4 + 0x14) + 0x14) & 1) != 0) &&
		         (*(int *)(*(int *)(local_4 + 0x14) + 0x18) != 0)) {
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar11 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar3 = *piVar11;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar13 = 0;
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar13 * 8)) {
		              puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar13 * 8 + 4) * 8 + iVar3 +
		                               0x178);
		              goto code_r0x80e2df44;
		            }
		            uVar13 = uVar13 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar13);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar11,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e2df44:
		        uVar12 = CONCAT44(uVar2,puVar4[1]);
		        uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(CONCAT44(uVar5,piVar11),uVar12);
		        uVar2 = (undefined4)((ulonglong)uVar12 >> 0x20);
		        uVar5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar5,0);
		        iVar3 = Core_Extensions_Dict_DictExt__GetDefaultChatRoomDic
		                          (uVar5,*(undefined4 *)(*(int *)(*(int *)(local_4 + 0x10) + 0xc) + 0xc),0);
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar6 = func_ii_7508(StringLiteral_4183,1,0,1,0,0,0,0);
		        iVar7 = Mono_Security_ASN1Convert__ToOid
		                          (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,3);
		        local_28[0] = 0;
		        System_Text_Formatting_StringView__get_IsEmpty
		                  (local_28,StringLiteral_25589,
		                   *(undefined4 *)(*(int *)(*(int *)(local_4 + 0x14) + 0xc) + 0x18),
		                   Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		        *(longlong *)(iVar7 + 0x10) = local_28[0];
		        uVar5 = Core_Extensions_Dict_BossCategoryDicExt__GetTitle(iVar3,0);
		        local_30 = 0;
		        System_Text_Formatting_StringView__get_IsEmpty
		                  (&local_30,StringLiteral_26324,uVar5,
		                   Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		        *(undefined8 *)(iVar7 + 0x18) = local_30;
		        uVar12 = *(undefined8 *)(iVar3 + 0x10);
		        if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Utils_TimeUtils_TypeInfo);
		        }
		        fVar8 = Utils_StringUtils___cctor(uVar12,0);
		        param1_00 = (double)fVar8;
		        uVar9 = Utils_TimeUtils__DateFormat(param1_00,0);
		        local_38 = 0;
		        uVar5 = (undefined4)((ulonglong)param1_00 >> 0x20);
		        System_Text_Formatting_StringView__get_IsEmpty
		                  (&local_38,StringLiteral_27717,uVar9,
		                   Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		        *(undefined8 *)(iVar7 + 0x20) = local_38;
		        uVar6 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                          (uVar6,iVar7,0);
		        iVar3 = unnamed_function_1417(Protocol_Chat_ChatMessage_TypeInfo);
		        Protocol_Chat_ChatMessage__pb__Google_Protobuf_IMessage_get_Descriptor(iVar3,0);
		        *(undefined4 *)(iVar3 + 0xc) = 0;
		        Protocol_Chat_ChatMessage__get_Text(iVar3,uVar6,0);
		        *(undefined4 *)(iVar3 + 0x10) = 2;
		        uVar12 = Utils_LocalProps__Reset(0);
		        *(undefined8 *)(iVar3 + 0x28) = uVar12;
		        *(undefined8 *)(iVar3 + 0x20) =
		             *(undefined8 *)(*(int *)(*(int *)(local_4 + 0x10) + 0xc) + 0x28);
		        iVar3 = Gameplay_Chat_Control_ChatController__ParseVisitor(param1,iVar3,auStack_40);
		        if (*(int *)(iVar3 + 0x18) == 0) {
		          iVar7 = unnamed_function_1417(Protocol_Chat_ChatUserInfo_TypeInfo);
		          Protocol_Chat_ChatUserInfo__pb__Google_Protobuf_IMessage_get_Descriptor(iVar7,0);
		          iVar10 = unnamed_function_1417(Protocol_Common_UserInfo_TypeInfo);
		          Protocol_Common_UserInfo__pb__Google_Protobuf_IMessage_get_Descriptor(iVar10,0);
		          *(undefined8 *)(iVar10 + 0x10) =
		               *(undefined8 *)(*(int *)(*(int *)(local_4 + 0x10) + 0xc) + 0x28);
		          *(int *)(iVar7 + 0xc) = iVar10;
		          uVar6 = Gameplay_Chat_Control_ChatController__GetVisitor(param1,iVar7,auStack_40);
		          *(undefined4 *)(iVar3 + 0x18) = uVar6;
		        }
		        System_Collections_Generic_List_object___GetEnumerator
		                  (local_28 + 1,*(undefined4 *)(local_4 + 0x1c),
		                   Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__GetEnumerator__
		                  );
		        local_28[0] = ZEXT48(local_28 + 1) << 0x20;
		        do {
		          do {
		            DAT_ram_009d3e38 = 0;
		            iVar10 = import::env::invoke_iii
		                               (s_struct_Uniforms___color__array<v_ram_00000aff + 0x158,local_28 + 1
		                                ,
		                                Method_System_Collections_Generic_Dictionary_Enumerator_RoomKey__ChatRoomData__MoveNext__
		                               );
		            iVar7 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar7 == 1) {
		              uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80e2e2df;
		            }
		            if (iVar10 == 0) {
		              iVar7 = 5;
		              iVar3 = (int)local_28[0];
		              goto code_r0x80e2e32c;
		            }
		          } while (*(char *)(*(int *)((int)local_10 + 0x1c) + 0x29) != '\0');
		          uVar9 = *(undefined4 *)(*(int *)((int)local_10 + 0x14) + 0xc);
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::invoke_iii
		                            (*(undefined4 *)(*param1 + 0x100),param1,
		                             *(undefined4 *)(*param1 + 0x104));
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x80e2e2b9:
		            DAT_ram_009d3e38 = 0;
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e2e2df;
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar7 = import::env::invoke_iiiii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2e,uVar6,uVar9,
		                             iVar3,auStack_40);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80e2e2b9;
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2f,param1,
		                     *(undefined4 *)(iVar7 + 8),auStack_40);
		          iVar10 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar10 == 1) {
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e2e2df;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x30,param1,iVar7,auStack_40)
		          ;
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		        } while (iVar7 != 1);
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e2e2df:
		        iVar3 = global_1;
		        iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar3 != iVar7) {
		code_r0x80e2e39a:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x31,local_28);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 != 1) {
		            import::env::__resumeException(uVar6);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          import::env::__cxa_find_matching_catch_3(0);
		          unnamed_function_937();
		          do {
		            halt_trap();
		          } while( true );
		        }
		        piVar11 = (int *)import::env::__cxa_begin_catch(uVar6);
		        iVar3 = *piVar11;
		        iVar7 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_28[0] = CONCAT44(local_28[0]._4_4_,iVar3);
		        import::env::invoke_v(0x123);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar6 = import::env::__cxa_find_matching_catch_2();
		          goto code_r0x80e2e39a;
		        }
		code_r0x80e2e32c:
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 != 0) {
		          System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        if (iVar7 != 0) {
		          if (iVar7 == 1) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          if (iVar7 == 2) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          if (iVar7 == 3) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          if (iVar7 == 4) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          if (iVar7 != 5) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		        }
		      }
		      *(undefined1 *)(local_4 + 0xc) = 0;
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (CONCAT44(uVar5,param1),CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x114)));
		    iVar3 = *(int *)(iVar3 + 0x14);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),local_4,*(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004526 RID: 17702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004526")]
		[Address(RVA = "0x93CA", Offset = "0x93CA", VA = "0x93CA")]
		private void HandleUserInfoChangedEvent(ProtoUserInfoChangedEvt msg)
		{
		/* --- GHIDRA: HandleUserInfoChangedEvent ---
		void Gameplay_Chat_Control_ChatController__HandleUserInfoChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  int iVar8;
		  int local_4;
		  
		  if (DAT_ram_00a57b99 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_ChatComplaintData_TypeInfo);
		    DAT_ram_00a57b99 = '\x01';
		  }
		  Gameplay_Chat_Control_ChatController__StopListenServiceEvents
		            (param1,*(undefined4 *)(param2 + 0x1c),param1);
		  Gameplay_Chat_Control_ChatController__StopListenServiceEvents
		            (param1,*(undefined4 *)(param2 + 0x10),param1);
		  if (*(int *)(param2 + 0x20) != 0) {
		    Gameplay_Chat_Control_ChatController__StopListenServiceEvents
		              (param1,*(int *)(param2 + 0x20),param1);
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  local_4 = 0;
		  iVar2 = Gameplay_Chat_Model_ChatModel__RemoveVisitorFromRoom
		                    (uVar1,*(undefined4 *)(param2 + 0x18),
		                     *(undefined4 *)(*(int *)(param2 + 0x14) + 0xc),&local_4,param1);
		  if (iVar2 == 0) {
		    uVar1 = Gameplay_Chat_Control_ChatController__ParseVisitor
		                      (param1,*(undefined4 *)(param2 + 0x14),param1);
		  }
		  else {
		    uVar1 = *(undefined4 *)(local_4 + 0xc);
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x18);
		  uVar5 = *(undefined4 *)(param2 + 0xc);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar6 = *(undefined4 *)(iVar2 + 0x2c);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar7 = *(undefined4 *)(iVar2 + 0x20);
		  iVar2 = unnamed_function_1417(Gameplay_Chat_Model_Data_Message_ChatComplaintData_TypeInfo);
		  *(undefined4 *)(iVar2 + 0x10) = uVar6;
		  *(undefined4 *)(iVar2 + 8) = uVar5;
		  *(undefined4 *)(iVar2 + 0x1c) = uVar1;
		  *(undefined4 *)(iVar2 + 0x18) = uVar4;
		  *(undefined4 *)(iVar2 + 0xc) = uVar7;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar4 = *(undefined4 *)(iVar3 + 0xc);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = func_ii_7092(uVar1,uVar4,iVar2,param1);
		  Gameplay_Chat_Model_ChatModel__AddMessage(param1,*(undefined4 *)(iVar2 + 8),param1);
		  Gameplay_Chat_Control_ChatController__ManageBan(param1,*(undefined4 *)(iVar2 + 8),param1);
		  iVar8 = *(int *)(iVar2 + 8);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (iVar8 == *(int *)(iVar3 + 0x30)) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar3 = *(int *)(iVar3 + 0x30);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),iVar2,*(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004527 RID: 17703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004527")]
		[Address(RVA = "0x93CB", Offset = "0x93CB", VA = "0x93CB")]
		private void HandleNewComplaintEvent(ProtoNewComplaintEvt msg)
		{
		/* --- GHIDRA: HandleNewComplaintEvent ---
		void Gameplay_Chat_Control_ChatController__HandleNewComplaintEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int *piVar4;
		  int iVar5;
		  int local_4;
		  
		  if (DAT_ram_00a57b9a == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_ChatMessageItem___TypeInfo);
		    DAT_ram_00a57b9a = '\x01';
		  }
		  local_4 = 0;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = Gameplay_Chat_Model_ChatModel__TryGetMessage
		                    (uVar1,*(undefined4 *)(iVar2 + 0xc),*(undefined4 *)(param2 + 0xc),&local_4,
		                     param1);
		  iVar2 = local_4;
		  if (iVar3 != 0) {
		    Gameplay_Chat_Control_ChatController__RemoveFromFavoritesInternal(param1,local_4,param1);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (*(int *)(iVar3 + 0x30) == *(int *)(iVar2 + 8)) {
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar3 = *(int *)(iVar3 + 0x34);
		      if (iVar3 != 0) {
		        piVar4 = (int *)Mono_Security_ASN1Convert__ToOid
		                                  (Gameplay_Chat_Model_Data_Message_ChatMessageItem___TypeInfo,1);
		        iVar5 = func_ii_1082(iVar2,*(undefined4 *)(*piVar4 + 0x20));
		        if (iVar5 == 0) {
		          uVar1 = func_ii_1083();
		          func_ii_1050(uVar1,0);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        piVar4[4] = iVar2;
		        (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                  (*(undefined4 *)(iVar3 + 0x20),piVar4,*(undefined4 *)(iVar3 + 0x14));
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004528 RID: 17704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004528")]
		[Address(RVA = "0x93CC", Offset = "0x93CC", VA = "0x93CC")]
		private void HandleComplaintProcessedEvent(ProtoComplaintProcessedEvt msg)
		{
		}

		// Token: 0x06004529 RID: 17705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004529")]
		[Address(RVA = "0x93CD", Offset = "0x93CD", VA = "0x93CD")]
		private void HandleAdmonitionEvent(ProtoAdmonitionEvt msg)
		{
		/* --- GHIDRA: HandleAdmonitionEvent ---
		void Gameplay_Chat_Control_ChatController__HandleAdmonitionEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  undefined1 auStack_10 [12];
		  int local_4;
		  
		  if (DAT_ram_00a57b9b == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_ChatMessageItem___TypeInfo);
		    DAT_ram_00a57b9b = '\x01';
		  }
		  local_4 = 0;
		  if (*(int *)(param2 + 0x18) != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_Chat_Model_ChatModel__TryGetMessage
		              (uVar1,*(undefined4 *)(param2 + 0xc),*(undefined4 *)(param2 + 0x18),&local_4,
		               auStack_10);
		    param1_00 = local_4;
		    if (local_4 != 0) {
		      Gameplay_Chat_Control_ChatController__RemoveFromFavoritesInternal(param1,local_4,auStack_10);
		      iVar4 = *(int *)(param1_00 + 8);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      if (iVar4 == *(int *)(iVar2 + 0x30)) {
		        iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x114));
		        iVar2 = *(int *)(iVar2 + 0x34);
		        if (iVar2 != 0) {
		          piVar3 = (int *)Mono_Security_ASN1Convert__ToOid
		                                    (Gameplay_Chat_Model_Data_Message_ChatMessageItem___TypeInfo,1);
		          iVar4 = func_ii_1082(param1_00,*(undefined4 *)(*piVar3 + 0x20));
		          if (iVar4 == 0) {
		            uVar1 = func_ii_1083();
		            func_ii_1050(uVar1,0);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          piVar3[4] = param1_00;
		          (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                    (*(undefined4 *)(iVar2 + 0x20),piVar3,*(undefined4 *)(iVar2 + 0x14));
		        }
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600452A RID: 17706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600452A")]
		[Address(RVA = "0x93CE", Offset = "0x93CE", VA = "0x93CE")]
		private void HandleMessageRemovedEvent(ProtoRemoveMessageEvt msg)
		{
		/* --- GHIDRA: HandleMessageRemovedEvent ---
		void Gameplay_Chat_Control_ChatController__HandleMessageRemovedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param2_00;
		  int param2_01;
		  longlong lVar3;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  lVar3 = *(longlong *)(*(int *)(param2 + 0xc) + 0x10);
		  if (DAT_ram_00a57b3d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatVisitorData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		    DAT_ram_00a57b3d = '\x01';
		  }
		  param2_01 = *(int *)(*(int *)(iVar1 + 0x34) + 0xc);
		  do {
		    if (param2_01 < 1) {
		      param2_00 = Gameplay_Chat_Control_ChatController__StopListenServiceEvents
		                            (param1,param2,param2_01);
		      Gameplay_Chat_Control_ChatController__GetNotViewedMessageCount(param1,param2_00,param2_01);
		      return;
		    }
		    param2_01 = param2_01 + -1;
		    iVar2 = System_Linq_Enumerable__ToList_object_
		                      (*(undefined4 *)(iVar1 + 0x34),param2_01,
		                       Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		  } while (lVar3 != *(longlong *)(*(int *)(*(int *)(iVar2 + 0x14) + 0xc) + 0x10));
		  return;
		}
		*/

		}

		// Token: 0x0600452B RID: 17707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600452B")]
		[Address(RVA = "0x93CF", Offset = "0x93CF", VA = "0x93CF")]
		private void HandleNewContactEvent(ChatUserInfo msg)
		{
		/* --- GHIDRA: HandleNewContactEvent ---
		void Gameplay_Chat_Control_ChatController__HandleNewContactEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param2_00;
		  int param2_01;
		  longlong lVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  lVar2 = *(longlong *)(param2 + 0x10);
		  if (DAT_ram_00a57b3d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatVisitorData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		    DAT_ram_00a57b3d = '\x01';
		  }
		  param2_01 = *(int *)(*(int *)(iVar1 + 0x34) + 0xc);
		  do {
		    if (param2_01 < 1) {
		      return;
		    }
		    param2_01 = param2_01 + -1;
		    param2_00 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(iVar1 + 0x34),param2_01,
		                           Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		  } while (*(longlong *)(*(int *)(*(int *)(param2_00 + 0x14) + 0xc) + 0x10) != lVar2);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a57b3c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ChatVisitorData__Remove__);
		    DAT_ram_00a57b3c = '\x01';
		  }
		  iVar1 = func_ii_4876(*(undefined4 *)(iVar1 + 0x34),param2_00,
		                       Method_System_Collections_Generic_List_ChatVisitorData__Remove__);
		  if ((iVar1 != 0) &&
		     (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104)), *(char *)(iVar1 + 0x48) == -1)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x20);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param2_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600452C RID: 17708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600452C")]
		[Address(RVA = "0x93D0", Offset = "0x93D0", VA = "0x93D0")]
		private void HandleContactRemovedEvent(ProtoContactRemovedEvt msg)
		{
		/* --- GHIDRA: HandleContactRemovedEvent ---
		void Gameplay_Chat_Control_ChatController__HandleContactRemovedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  Gameplay_Chat_Control_ChatController__ManageMaxMessages
		            (param1,*(undefined4 *)(param2 + 0xc),param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x30) == 0) {
		    Gameplay_Chat_Control_ChatController__StopBanCoroutine(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600452D RID: 17709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600452D")]
		[Address(RVA = "0x93D1", Offset = "0x93D1", VA = "0x93D1")]
		private void HandleRightsChangedEvent(ProtoRightsChangedEvt msg)
		{
		/* --- GHIDRA: HandleRightsChangedEvent ---
		void Gameplay_Chat_Control_ChatController__HandleRightsChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int param1_00;
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 param1_01;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a57b9c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatVisitorData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		    DAT_ram_00a57b9c = '\x01';
		  }
		  param1_00 = Gameplay_Chat_Control_ChatController__JoinUserToRoom
		                        (param1,*(undefined4 *)(param2 + 0xc),param1);
		  iVar3 = *(int *)(param1_00 + 0xc);
		  if (0 < iVar3) {
		    do {
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (param1_00,param2_00,
		                         Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		      param1_01 = *(undefined4 *)(iVar1 + 0x1c);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      iVar2 = System_Xml_Schema_SchemaInfo__get_Notations
		                        (param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x30) + 0x14) + 0xc),
		                         Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__ContainsKey__
		                        );
		      if (iVar2 != 0) {
		        iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x114));
		        iVar2 = *(int *)(iVar2 + 0x14);
		        if (iVar2 != 0) {
		          (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                    (*(undefined4 *)(iVar2 + 0x20),iVar1,*(undefined4 *)(iVar2 + 0x14));
		        }
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar3);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600452E RID: 17710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600452E")]
		[Address(RVA = "0x93D2", Offset = "0x93D2", VA = "0x93D2")]
		private void HandleAttackAbilityInfoChangedEvent(ProtoAttackabilityChangedEvt msg)
		{
		/* --- GHIDRA: HandleAttackAbilityInfoChangedEvent ---
		void Gameplay_Chat_Control_ChatController__HandleAttackAbilityInfoChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  char cVar1;
		  int iVar2;
		  
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  cVar1 = *(char *)(iVar2 + 0x38);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  if (cVar1 == '\0') {
		    iVar2 = *(int *)(iVar2 + 0xc);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		    Gameplay_Chat_Control_ChatController__RequestGetAllComplaints(param1,param1);
		    return;
		  }
		  iVar2 = *(int *)(iVar2 + 0x28);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600452F RID: 17711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600452F")]
		[Address(RVA = "0x93D3", Offset = "0x93D3", VA = "0x93D3")]
		public void RequestFavoritesList()
		{
		/* --- GHIDRA: RequestFavoritesList ---
		void Gameplay_Chat_Control_ChatController__RequestFavoritesList
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  local_4 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a57b45 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__TryGetValue__);
		    DAT_ram_00a57b45 = '\x01';
		  }
		  iVar1 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (*(undefined4 *)(iVar1 + 0x40),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__TryGetValue__
		                    );
		  if (iVar1 != 0) {
		    Gameplay_Chat_Control_ChatController__AddRoom(param1,local_4,auStack_10);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004530 RID: 17712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004530")]
		[Address(RVA = "0x93D4", Offset = "0x93D4", VA = "0x93D4")]
		public void SetRoom(RoomKey roomKey)
		{
		/* --- GHIDRA: SetRoom ---
		void Gameplay_Chat_Control_ChatController__SetRoom
		               (undefined4 param1,undefined8 param2,undefined4 param3)
		
		{
		  Gameplay_Chat_Control_ChatController__RequestGetContactList(param1,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004531 RID: 17713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004531")]
		[Address(RVA = "0x93D5", Offset = "0x93D5", VA = "0x93D5")]
		public void AddToFavorites(ulong userId)
		{
		/* --- GHIDRA: AddToFavorites ---
		void Gameplay_Chat_Control_ChatController__AddToFavorites
		               (undefined4 param1,undefined8 param2,undefined4 param3)
		
		{
		  Gameplay_Chat_Control_ChatController__RequestAddToFavorites(param1,param2,param1);
		  return;
		}
		*/

		/* --- GHIDRA: AddToFavorites ---
		void Gameplay_Chat_Control_ChatController__AddToFavorites
		               (undefined4 param1,undefined8 param2,undefined4 param3)
		
		{
		  Gameplay_Chat_Control_ChatController__RequestAddToFavorites(param1,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004532 RID: 17714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004532")]
		[Address(RVA = "0x93D6", Offset = "0x93D6", VA = "0x93D6")]
		public void AddToFavorites(ChatVisitorData visitor)
		{
		}

		// Token: 0x06004533 RID: 17715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004533")]
		[Address(RVA = "0x93D7", Offset = "0x93D7", VA = "0x93D7")]
		public void RemoveFromFavorites(ulong userId)
		{
		/* --- GHIDRA: RemoveFromFavorites ---
		undefined4
		Gameplay_Chat_Control_ChatController__RemoveFromFavorites
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int iVar7;
		  int iVar8;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57b9d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_InputMessage_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25589);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4171);
		    DAT_ram_00a57b9d = '\x01';
		  }
		  iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(param2,0);
		  if (iVar1 != 0) {
		    return 0;
		  }
		  param1_00 = unnamed_function_1417(Gameplay_Chat_Model_Data_Message_InputMessage_TypeInfo);
		  Gameplay_Chat_Model_Data_Message_InputMessage__set_MessageText(param1_00,param2,param2);
		  iVar1 = *param1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(iVar1 + 0x104));
		  iVar2 = *(int *)(iVar2 + 0x30);
		  uVar6 = *(undefined4 *)(param1_00 + 0xc);
		  if (DAT_ram_00a57b51 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatVisitorData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		    DAT_ram_00a57b51 = '\x01';
		  }
		  iVar7 = *(int *)(iVar2 + 8);
		  iVar8 = *(int *)(iVar7 + 0xc);
		  if (iVar8 < 1) {
		    if (*(int *)(param1_00 + 0xc) == 0) {
		code_r0x80e2eb9b:
		      uVar6 = Gameplay_Chat_Control_ChatController__TrySendMessage(param1,param1_00,0,iVar1);
		      return uVar6;
		    }
		code_r0x80e2eafe:
		    uVar6 = 0;
		    uVar4 = System_Uri___ctor(0);
		    uVar4 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar4,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar5 = func_ii_7508(StringLiteral_4171,1,0,1,0,0,0,0);
		    iVar1 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    local_8 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_8,StringLiteral_25589,*(undefined4 *)(param1_00 + 0xc),
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar1 + 0x10) = local_8;
		    uVar5 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar5,iVar1,0);
		    Core_Application_App__get_ToastController(uVar4,4,uVar5,0);
		  }
		  else {
		    iVar1 = 0;
		    iVar7 = System_Linq_Enumerable__ToList_object_
		                      (iVar7,0,Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		    iVar3 = System_Collections_CollectionBase___ctor
		                      (*(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x14) + 0xc) + 0x18),uVar6,0);
		    if (iVar3 == 0) {
		      do {
		        iVar1 = iVar1 + 1;
		        if (iVar8 == iVar1) {
		          iVar7 = 0;
		          break;
		        }
		        iVar7 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(iVar2 + 8),iVar1,
		                           Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		        iVar3 = System_Collections_CollectionBase___ctor
		                          (*(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x14) + 0xc) + 0x18),uVar6,0);
		      } while (iVar3 == 0);
		      if ((iVar8 <= iVar1) && (*(int *)(param1_00 + 0xc) != 0)) goto code_r0x80e2eafe;
		      if (iVar8 <= iVar1) goto code_r0x80e2eb9b;
		    }
		    uVar6 = Gameplay_Chat_Control_ChatController__TrySendMessage(param1,param1_00,iVar7,iVar1);
		  }
		  return uVar6;
		}
		*/

		/* --- GHIDRA: RemoveFromFavorites ---
		undefined4
		Gameplay_Chat_Control_ChatController__RemoveFromFavorites
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int iVar7;
		  int iVar8;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57b9d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_InputMessage_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25589);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4171);
		    DAT_ram_00a57b9d = '\x01';
		  }
		  iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(param2,0);
		  if (iVar1 != 0) {
		    return 0;
		  }
		  param1_00 = unnamed_function_1417(Gameplay_Chat_Model_Data_Message_InputMessage_TypeInfo);
		  Gameplay_Chat_Model_Data_Message_InputMessage__set_MessageText(param1_00,param2,param2);
		  iVar1 = *param1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(iVar1 + 0x104));
		  iVar2 = *(int *)(iVar2 + 0x30);
		  uVar6 = *(undefined4 *)(param1_00 + 0xc);
		  if (DAT_ram_00a57b51 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatVisitorData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		    DAT_ram_00a57b51 = '\x01';
		  }
		  iVar7 = *(int *)(iVar2 + 8);
		  iVar8 = *(int *)(iVar7 + 0xc);
		  if (iVar8 < 1) {
		    if (*(int *)(param1_00 + 0xc) == 0) {
		code_r0x80e2eb9b:
		      uVar6 = Gameplay_Chat_Control_ChatController__TrySendMessage(param1,param1_00,0,iVar1);
		      return uVar6;
		    }
		code_r0x80e2eafe:
		    uVar6 = 0;
		    uVar4 = System_Uri___ctor(0);
		    uVar4 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar4,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar5 = func_ii_7508(StringLiteral_4171,1,0,1,0,0,0,0);
		    iVar1 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    local_8 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_8,StringLiteral_25589,*(undefined4 *)(param1_00 + 0xc),
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar1 + 0x10) = local_8;
		    uVar5 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar5,iVar1,0);
		    Core_Application_App__get_ToastController(uVar4,4,uVar5,0);
		  }
		  else {
		    iVar1 = 0;
		    iVar7 = System_Linq_Enumerable__ToList_object_
		                      (iVar7,0,Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		    iVar3 = System_Collections_CollectionBase___ctor
		                      (*(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x14) + 0xc) + 0x18),uVar6,0);
		    if (iVar3 == 0) {
		      do {
		        iVar1 = iVar1 + 1;
		        if (iVar8 == iVar1) {
		          iVar7 = 0;
		          break;
		        }
		        iVar7 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(iVar2 + 8),iVar1,
		                           Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		        iVar3 = System_Collections_CollectionBase___ctor
		                          (*(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x14) + 0xc) + 0x18),uVar6,0);
		      } while (iVar3 == 0);
		      if ((iVar8 <= iVar1) && (*(int *)(param1_00 + 0xc) != 0)) goto code_r0x80e2eafe;
		      if (iVar8 <= iVar1) goto code_r0x80e2eb9b;
		    }
		    uVar6 = Gameplay_Chat_Control_ChatController__TrySendMessage(param1,param1_00,iVar7,iVar1);
		  }
		  return uVar6;
		}
		*/

		}

		// Token: 0x06004534 RID: 17716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004534")]
		[Address(RVA = "0x93D8", Offset = "0x93D8", VA = "0x93D8")]
		public void RemoveFromFavorites(ChatVisitorData visitor)
		{
		}

		// Token: 0x06004535 RID: 17717 RVA: 0x0000D098 File Offset: 0x0000B298
		[Token(Token = "0x6004535")]
		[Address(RVA = "0x93D9", Offset = "0x93D9", VA = "0x93D9")]
		public bool TrySendMessage(string text)
		{
		/* --- GHIDRA: TrySendMessage ---
		undefined4
		Gameplay_Chat_Control_ChatController__TrySendMessage
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Chat_Control_ChatController__TrySendMessage(param1,param2,0,param2);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: TrySendMessage ---
		undefined4
		Gameplay_Chat_Control_ChatController__TrySendMessage
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Chat_Control_ChatController__TrySendMessage(param1,param2,0,param2);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: TrySendMessage ---
		undefined4
		Gameplay_Chat_Control_ChatController__TrySendMessage
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Chat_Control_ChatController__TrySendMessage(param1,param2,0,param2);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004536 RID: 17718 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
		[Token(Token = "0x6004536")]
		[Address(RVA = "0x93DA", Offset = "0x93DA", VA = "0x93DA")]
		public bool TrySendMessage(InputMessage message)
		{
			return default(bool);
		}

		// Token: 0x06004537 RID: 17719 RVA: 0x0000D0C8 File Offset: 0x0000B2C8
		[Token(Token = "0x6004537")]
		[Address(RVA = "0x93DB", Offset = "0x93DB", VA = "0x93DB")]
		public bool TrySendMessage(InputMessage message, ChatVisitorData visitor)
		{
			return default(bool);
		}

		// Token: 0x06004538 RID: 17720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004538")]
		[Address(RVA = "0x93DC", Offset = "0x93DC", VA = "0x93DC")]
		public void SendComplaint(ChatMessageItem message)
		{
		/* --- GHIDRA: SendComplaint ---
		void Gameplay_Chat_Control_ChatController__SendComplaint
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param4;
		  
		  if (DAT_ram_00a57b9f == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_ChatComplaintData_TypeInfo);
		    DAT_ram_00a57b9f = '\x01';
		  }
		  param4 = *(int **)(param2 + 0xc);
		  if (param4 != (int *)0x0) {
		    if (((uint)*(byte *)(Gameplay_Chat_Model_Data_Message_ChatComplaintData_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*param4 + 0xb8)) &&
		       (*(int *)(*(int *)(*param4 + 100) +
		                 (uint)*(byte *)(Gameplay_Chat_Model_Data_Message_ChatComplaintData_TypeInfo + 0xb8)
		                 * 4 + -4) == Gameplay_Chat_Model_Data_Message_ChatComplaintData_TypeInfo)) {
		      Gameplay_Chat_Control_ChatController__RequestSendComplaint
		                (param1,param4[6],*(undefined4 *)(param4[7] + 8),param4,param2);
		      return;
		    }
		  }
		  Gameplay_Chat_Control_ChatController__RequestSendComplaint
		            (param1,*(undefined4 *)(*(int *)(*(int *)(param2 + 8) + 0x14) + 0xc),param4[2],0,param2)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06004539 RID: 17721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004539")]
		[Address(RVA = "0x93DD", Offset = "0x93DD", VA = "0x93DD")]
		public void RemoveMessage(ChatMessageItem messageItem)
		{
		/* --- GHIDRA: RemoveMessage ---
		void Gameplay_Chat_Control_ChatController__RemoveMessage
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  Gameplay_Chat_Control_ChatController__RequestRemoveMessage
		            (param1,*(undefined4 *)(param2 + 8),0,param2);
		  return;
		}
		*/

		}

		// Token: 0x0600453A RID: 17722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600453A")]
		[Address(RVA = "0x93DE", Offset = "0x93DE", VA = "0x93DE")]
		public void RejectComplaint(ChatComplaintData complaint)
		{
		/* --- GHIDRA: RejectComplaint ---
		void Gameplay_Chat_Control_ChatController__RejectComplaint
		               (undefined4 param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  Gameplay_Chat_Control_ChatController__RequestProcessComplaint(param1,param2,param3,param3);
		  return;
		}
		*/

		}

		// Token: 0x0600453B RID: 17723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600453B")]
		[Address(RVA = "0x93DF", Offset = "0x93DF", VA = "0x93DF")]
		public void BanUser(ulong userId, uint banId)
		{
		/* --- GHIDRA: BanUser ---
		void Gameplay_Chat_Control_ChatController__BanUser(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined1 *)(iVar1 + 0x48) = (undefined1)param2;
		  return;
		}
		*/

		}

		// Token: 0x0600453C RID: 17724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600453C")]
		[Address(RVA = "0x93E0", Offset = "0x93E0", VA = "0x93E0")]
		public void SetCurrentUIVisitorsState(RoomVisitorsOrContactsStates value)
		{
		/* --- GHIDRA: SetCurrentUIVisitorsState ---
		void Gameplay_Chat_Control_ChatController__SetCurrentUIVisitorsState
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  char cVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 param3_00;
		  int iVar5;
		  
		  if (DAT_ram_00a57ba0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4186);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4187);
		    DAT_ram_00a57ba0 = '\x01';
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  cVar1 = *(char *)(iVar3 + 0x49);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined1 *)(iVar3 + 0x49) = (undefined1)param2;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (cVar1 == *(char *)(iVar3 + 0x49)) {
		    return;
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(char *)(iVar3 + 0x49) == -1) {
		    uVar4 = System_Uri___ctor(0);
		    uVar4 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar4,0);
		    puVar2 = &StringLiteral_4186;
		    iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  else {
		    if (*(char *)(iVar3 + 0x49) != '\0') goto code_r0x80e2ee7f;
		    uVar4 = System_Uri___ctor(0);
		    uVar4 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar4,0);
		    puVar2 = &StringLiteral_4187;
		    iVar3 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  if (iVar3 == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param3_00 = func_ii_7508(*puVar2,1,0,1,0,0,0,0);
		  Core_Application_App__get_ToastController(uVar4,4,param3_00,0);
		code_r0x80e2ee7f:
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar3 = *(int *)(iVar3 + 0x50);
		  if (iVar3 != 0) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),*(undefined1 *)(iVar5 + 0x49),
		               *(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600453D RID: 17725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600453D")]
		[Address(RVA = "0x93E1", Offset = "0x93E1", VA = "0x93E1")]
		public void SetCurrentMiniChatViewState(MiniChatButtonStates value)
		{
		/* --- GHIDRA: SetCurrentMiniChatViewState ---
		void Gameplay_Chat_Control_ChatController__SetCurrentMiniChatViewState
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined1 *)(iVar1 + 0x4a) = (undefined1)param2;
		  return;
		}
		*/

		}

		// Token: 0x0600453E RID: 17726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600453E")]
		[Address(RVA = "0x93E2", Offset = "0x93E2", VA = "0x93E2")]
		public void SetCurrentPrivateOrAllMessagesState(PrivateOrAllMessagesStates value)
		{
		/* --- GHIDRA: SetCurrentPrivateOrAllMessagesState ---
		void Gameplay_Chat_Control_ChatController__SetCurrentPrivateOrAllMessagesState
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  uint uVar2;
		  uint uVar3;
		  uint uVar4;
		  int iVar5;
		  uint uVar6;
		  int iVar7;
		  uint uVar8;
		  int iVar9;
		  int iVar10;
		  ulonglong local_10;
		  ulonglong local_8;
		  
		  uVar6 = 0;
		  if (*(char *)(param2 + 0x10) == '\0') {
		    *(undefined1 *)(param2 + 0x10) = 1;
		    *(int *)(*(int *)(param2 + 8) + 0x10) = *(int *)(*(int *)(param2 + 8) + 0x10) + -1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x48);
		    if (iVar1 != 0) {
		      iVar7 = *param1;
		      param1_00 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x100) * 4))
		                            (param1,*(undefined4 *)(iVar7 + 0x104));
		      iVar7 = Gameplay_Chat_Model_ChatModel__AddRoom(param1_00,iVar7);
		      if (DAT_ram_00a57b83 == '\0') {
		        Mono_Security_ASN1__get_Item(&int___TypeInfo);
		        DAT_ram_00a57b83 = '\x01';
		      }
		      uVar2 = Mono_Security_ASN1Convert__ToOid(int___TypeInfo,*(undefined4 *)(iVar7 + 0xc));
		      uVar3 = *(uint *)(iVar7 + 0xc);
		      if ((int)uVar3 < 1) {
		        local_10 = 0;
		      }
		      else {
		        if (uVar3 == 1) {
		          uVar4 = 0;
		          iVar5 = 0;
		        }
		        else {
		          uVar4 = 0;
		          iVar5 = 0;
		          do {
		            uVar8 = iVar5 * 4;
		            iVar9 = *(int *)(iVar7 + 0x10 + uVar8);
		            *(undefined4 *)(uVar2 + 0x10 + uVar8) = *(undefined4 *)(iVar9 + 0x10);
		            iVar9 = *(int *)(iVar9 + 0x10);
		            iVar10 = *(int *)((uVar8 | 4) + iVar7 + 0x10);
		            *(undefined4 *)(uVar2 + 0x10 + (uVar8 | 4)) = *(undefined4 *)(iVar10 + 0x10);
		            uVar4 = *(int *)(iVar10 + 0x10) + uVar4 + iVar9;
		            iVar5 = iVar5 + 2;
		            uVar6 = uVar6 + 2;
		          } while (uVar6 != (uVar3 & 0xfffffffe));
		        }
		        if ((uVar3 & 1) != 0) {
		          iVar7 = *(int *)(iVar5 * 4 + iVar7 + 0x10);
		          *(undefined4 *)(uVar2 + iVar5 * 4 + 0x10) = *(undefined4 *)(iVar7 + 0x10);
		          uVar4 = *(int *)(iVar7 + 0x10) + uVar4;
		        }
		        local_10 = (ulonglong)uVar4;
		      }
		      local_10 = (ulonglong)uVar2 << 0x20 | local_10;
		      local_8 = local_10;
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),&local_10,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600453F RID: 17727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600453F")]
		[Address(RVA = "0x93E3", Offset = "0x93E3", VA = "0x93E3")]
		public void SetMessageAsViewed(ChatMessageItem message)
		{
		/* --- GHIDRA: SetMessageAsViewed ---
		void Gameplay_Chat_Control_ChatController__SetMessageAsViewed
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57ba1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_InputMessage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1705);
		    DAT_ram_00a57ba1 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x14) + 0xc) + 0x18);
		  param1_00 = unnamed_function_1417(Gameplay_Chat_Model_Data_Message_InputMessage_TypeInfo);
		  Gameplay_Chat_Model_Data_Message_InputMessage__set_MessageText
		            (param1_00,StringLiteral_1705,param1);
		  *(undefined4 *)(param1_00 + 0xc) = uVar2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x54);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004540 RID: 17728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004540")]
		[Address(RVA = "0x93E4", Offset = "0x93E4", VA = "0x93E4")]
		public void StartWritePrivateMessage(ChatVisitorData visitor)
		{
		/* --- GHIDRA: StartWritePrivateMessage ---
		void Gameplay_Chat_Control_ChatController__StartWritePrivateMessage
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57ba2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_InputMessage_TypeInfo);
		    DAT_ram_00a57ba2 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x14) + 0xc) + 0x18);
		  param2_00 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  param1_00 = unnamed_function_1417(Gameplay_Chat_Model_Data_Message_InputMessage_TypeInfo);
		  Gameplay_Chat_Model_Data_Message_InputMessage__set_MessageText(param1_00,param2_00,param1);
		  *(undefined4 *)(param1_00 + 0xc) = uVar2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x54);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004541 RID: 17729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004541")]
		[Address(RVA = "0x93E5", Offset = "0x93E5", VA = "0x93E5")]
		public void StartWriteMessage(ChatVisitorData visitor)
		{
		/* --- GHIDRA: StartWriteMessage ---
		void Gameplay_Chat_Control_ChatController__StartWriteMessage(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57939 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Control_ChatController___c_TypeInfo);
		    DAT_ram_00a57939 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Chat_Control_ChatController___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Chat_Control_ChatController___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x040025FB RID: 9723
		[Token(Token = "0x40025FB")]
		[FieldOffset(Offset = "0x18")]
		private ChatService _service;

		// Token: 0x040025FC RID: 9724
		[Token(Token = "0x40025FC")]
		[FieldOffset(Offset = "0x1C")]
		private Coroutine _banCoroutine;
	}
}
