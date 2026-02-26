using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Chat;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x02000092 RID: 146
	[Token(Token = "0x2000092")]
	public class ChatService : AbstractService
	{
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x17000096")]
		public override short ServiceId
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x586C", Offset = "0x586C", VA = "0x586C", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06000441 RID: 1089 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000442 RID: 1090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400002A")]
		public event Action<ProtoJoinRoomEvt> RoomJoinEvent
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x586D", Offset = "0x586D", VA = "0x586D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x586E", Offset = "0x586E", VA = "0x586E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06000443 RID: 1091 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000444 RID: 1092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400002B")]
		public event Action<ProtoUnjoinRoomEvt> RoomUnjoinEvent
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x586F", Offset = "0x586F", VA = "0x586F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x5870", Offset = "0x5870", VA = "0x5870")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06000445 RID: 1093 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000446 RID: 1094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400002C")]
		public event Action<ProtoChatMessageEvt> NewMessageEvent
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x5871", Offset = "0x5871", VA = "0x5871")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x5872", Offset = "0x5872", VA = "0x5872")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06000447 RID: 1095 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000448 RID: 1096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400002D")]
		public event Action<ProtoUserInfoChangedEvt> UserInfoChangedEvent
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x5873", Offset = "0x5873", VA = "0x5873")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x5874", Offset = "0x5874", VA = "0x5874")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06000449 RID: 1097 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600044A RID: 1098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400002E")]
		public event Action<ProtoNewComplaintEvt> NewComplaintEvent
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x5875", Offset = "0x5875", VA = "0x5875")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x5876", Offset = "0x5876", VA = "0x5876")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x0600044B RID: 1099 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600044C RID: 1100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400002F")]
		public event Action<ProtoComplaintProcessedEvt> ComplaintProcessedEvent
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x5877", Offset = "0x5877", VA = "0x5877")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x5878", Offset = "0x5878", VA = "0x5878")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x0600044D RID: 1101 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600044E RID: 1102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000030")]
		public event Action<ProtoAdmonitionEvt> AdmonitionEvent
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x5879", Offset = "0x5879", VA = "0x5879")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x587A", Offset = "0x587A", VA = "0x587A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x0600044F RID: 1103 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000450 RID: 1104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000031")]
		public event Action<ProtoRemoveMessageEvt> MessageRemovedEvent
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x587B", Offset = "0x587B", VA = "0x587B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x587C", Offset = "0x587C", VA = "0x587C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x06000451 RID: 1105 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000452 RID: 1106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000032")]
		public event Action<ChatUserInfo> NewContactEvent
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x587D", Offset = "0x587D", VA = "0x587D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x587E", Offset = "0x587E", VA = "0x587E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x06000453 RID: 1107 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000454 RID: 1108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000033")]
		public event Action<ProtoContactRemovedEvt> ContactRemovedEvent
		{
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x587F", Offset = "0x587F", VA = "0x587F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x5880", Offset = "0x5880", VA = "0x5880")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x06000455 RID: 1109 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000456 RID: 1110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000034")]
		public event Action<ProtoRightsChangedEvt> RightsChangedEvent
		{
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x5881", Offset = "0x5881", VA = "0x5881")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x5882", Offset = "0x5882", VA = "0x5882")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x06000457 RID: 1111 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000458 RID: 1112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000035")]
		public event Action<ProtoAttackabilityChangedEvt> AttackAbilityInfoChangedEvent
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x5883", Offset = "0x5883", VA = "0x5883")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x5884", Offset = "0x5884", VA = "0x5884")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x5885", Offset = "0x5885", VA = "0x5885", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		undefined4 ServicesNamespace_ChatService__ServerEventHandler(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a628e6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_ServicesNamespace_ChatService_Request_ProtoGetChatInfoAns___);
		    DAT_ram_00a628e6 = '\x01';
		  }
		  uVar1 = ServicesNamespace_CaveService__CaveRequest___Il2CppFullySharedGenericType_
		                    (param1,0x10,0,
		                     Method_ServicesNamespace_ChatService_Request_ProtoGetChatInfoAns___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600045A")]
		private OpToken<IMessage, object> Request<TAns>(ChatCommands command, IMessage msg) where TAns : IMessage, new()
		{
			return null;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x5886", Offset = "0x5886", VA = "0x5886")]
		public OpToken<IMessage, object> GetChatInfo()
		{
		/* --- GHIDRA: GetChatInfo ---
		undefined4
		ServicesNamespace_ChatService__GetChatInfo(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param3_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a628e7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_ServicesNamespace_ChatService_Request_ProtoGetRoomInfoAns___);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoGetRoomInfoCmd_TypeInfo);
		    DAT_ram_00a628e7 = '\x01';
		  }
		  param3_00 = unnamed_function_1417(Protocol_Chat_ProtoGetRoomInfoCmd_TypeInfo);
		  *(undefined4 *)(param3_00 + 0xc) = param2;
		  uVar1 = ServicesNamespace_CaveService__CaveRequest___Il2CppFullySharedGenericType_
		                    (param1,0x12,param3_00,
		                     Method_ServicesNamespace_ChatService_Request_ProtoGetRoomInfoAns___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x5887", Offset = "0x5887", VA = "0x5887")]
		public OpToken<IMessage, object> GetRoomInfo(RoomKey roomKey)
		{
		/* --- GHIDRA: GetRoomInfo ---
		undefined4
		ServicesNamespace_ChatService__GetRoomInfo
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,longlong param5,
		          undefined4 param6)
		
		{
		  int param1_00;
		  int param3_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a628e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ChatMessage_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_ServicesNamespace_ChatService_Request_ProtoSendMessageAns___);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoSendMessageCmd_TypeInfo);
		    DAT_ram_00a628e8 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Protocol_Chat_ChatMessage_TypeInfo);
		  Protocol_Chat_ChatMessage__pb__Google_Protobuf_IMessage_get_Descriptor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x10) = param4;
		  Protocol_Chat_ChatMessage__get_Text(param1_00,param3,0);
		  if (param5 != 0) {
		    *(longlong *)(param1_00 + 0x18) = param5;
		  }
		  param3_00 = unnamed_function_1417(Protocol_Chat_ProtoSendMessageCmd_TypeInfo);
		  *(int *)(param3_00 + 0x10) = param1_00;
		  *(undefined4 *)(param3_00 + 0xc) = param2;
		  uVar1 = ServicesNamespace_CaveService__CaveRequest___Il2CppFullySharedGenericType_
		                    (param1,3,param3_00,
		                     Method_ServicesNamespace_ChatService_Request_ProtoSendMessageAns___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x5888", Offset = "0x5888", VA = "0x5888")]
		public OpToken<IMessage, object> SendMessage(RoomKey roomKey, string text, ChatMessage.Types.ChatMessageTypes messageType, ulong toUserId)
		{
		/* --- GHIDRA: SendMessage ---
		undefined4 ServicesNamespace_ChatService__SendMessage(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a628e9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_ServicesNamespace_ChatService_Request_ProtoGetContactListAns___);
		    DAT_ram_00a628e9 = '\x01';
		  }
		  uVar1 = ServicesNamespace_CaveService__CaveRequest___Il2CppFullySharedGenericType_
		                    (param1,0xb,0,
		                     Method_ServicesNamespace_ChatService_Request_ProtoGetContactListAns___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x5889", Offset = "0x5889", VA = "0x5889")]
		public OpToken<IMessage, object> GetContactList()
		{
		/* --- GHIDRA: GetContactList ---
		undefined4
		ServicesNamespace_ChatService__GetContactList(undefined4 param1,undefined8 param2,undefined4 param3)
		
		{
		  int param3_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a628ea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_ServicesNamespace_ChatService_Request_ProtoAddToFavoritesAns___);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoAddToFavoritesCmd_TypeInfo);
		    DAT_ram_00a628ea = '\x01';
		  }
		  param3_00 = unnamed_function_1417(Protocol_Chat_ProtoAddToFavoritesCmd_TypeInfo);
		  *(undefined8 *)(param3_00 + 0x10) = param2;
		  uVar1 = ServicesNamespace_CaveService__CaveRequest___Il2CppFullySharedGenericType_
		                    (param1,0xc,param3_00,
		                     Method_ServicesNamespace_ChatService_Request_ProtoAddToFavoritesAns___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x588A", Offset = "0x588A", VA = "0x588A")]
		public OpToken<IMessage, object> AddToFavorites(ulong userId)
		{
		/* --- GHIDRA: AddToFavorites ---
		undefined4
		ServicesNamespace_ChatService__AddToFavorites(undefined4 param1,undefined8 param2,undefined4 param3)
		
		{
		  int param3_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a628eb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_ServicesNamespace_ChatService_Request_ProtoEmptyAns___);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoRemoveFromFavoritesCmd_TypeInfo);
		    DAT_ram_00a628eb = '\x01';
		  }
		  param3_00 = unnamed_function_1417(Protocol_Chat_ProtoRemoveFromFavoritesCmd_TypeInfo);
		  *(undefined8 *)(param3_00 + 0x10) = param2;
		  uVar1 = ServicesNamespace_CaveService__CaveRequest___Il2CppFullySharedGenericType_
		                    (param1,0xe,param3_00,
		                     Method_ServicesNamespace_ChatService_Request_ProtoEmptyAns___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x588B", Offset = "0x588B", VA = "0x588B")]
		public OpToken<IMessage, object> RemoveFromFavorites(ulong userId)
		{
		/* --- GHIDRA: RemoveFromFavorites ---
		undefined4
		ServicesNamespace_ChatService__RemoveFromFavorites
		          (undefined4 param1,undefined4 param2,undefined4 param3,longlong param4,undefined4 param5)
		
		{
		  int param3_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a628ec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_ServicesNamespace_ChatService_Request_ProtoRemoveMessageAns___);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoRemoveMessageCmd_TypeInfo);
		    DAT_ram_00a628ec = '\x01';
		  }
		  param3_00 = unnamed_function_1417(Protocol_Chat_ProtoRemoveMessageCmd_TypeInfo);
		  *(undefined4 *)(param3_00 + 0xc) = param2;
		  if (param4 == 0) {
		    *(undefined4 *)(param3_00 + 0x18) = param3;
		  }
		  else {
		    *(longlong *)(param3_00 + 0x10) = param4;
		  }
		  uVar1 = ServicesNamespace_CaveService__CaveRequest___Il2CppFullySharedGenericType_
		                    (param1,10,param3_00,
		                     Method_ServicesNamespace_ChatService_Request_ProtoRemoveMessageAns___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x588C", Offset = "0x588C", VA = "0x588C")]
		public OpToken<IMessage, object> RemoveMessage(RoomKey roomKey, uint messageId, ulong userId)
		{
		/* --- GHIDRA: RemoveMessage ---
		undefined4 ServicesNamespace_ChatService__RemoveMessage(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a628ed == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_ServicesNamespace_ChatService_Request_ProtoGetAllComplaintsAns___);
		    DAT_ram_00a628ed = '\x01';
		  }
		  uVar1 = ServicesNamespace_CaveService__CaveRequest___Il2CppFullySharedGenericType_
		                    (param1,0x11,0,
		                     Method_ServicesNamespace_ChatService_Request_ProtoGetAllComplaintsAns___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x588D", Offset = "0x588D", VA = "0x588D")]
		public OpToken<IMessage, object> GetAllComplaints()
		{
		/* --- GHIDRA: GetAllComplaints ---
		undefined4
		ServicesNamespace_ChatService__GetAllComplaints
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param3_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a628ee == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_ServicesNamespace_ChatService_Request_ProtoSendComplaintAns___);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoSendComplaintCmd_TypeInfo);
		    DAT_ram_00a628ee = '\x01';
		  }
		  param3_00 = unnamed_function_1417(Protocol_Chat_ProtoSendComplaintCmd_TypeInfo);
		  *(undefined4 *)(param3_00 + 0x10) = param3;
		  *(undefined4 *)(param3_00 + 0xc) = param2;
		  uVar1 = ServicesNamespace_CaveService__CaveRequest___Il2CppFullySharedGenericType_
		                    (param1,5,param3_00,
		                     Method_ServicesNamespace_ChatService_Request_ProtoSendComplaintAns___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x588E", Offset = "0x588E", VA = "0x588E")]
		public OpToken<IMessage, object> SendComplaint(RoomKey roomKey, uint messageId)
		{
		/* --- GHIDRA: SendComplaint ---
		undefined4
		ServicesNamespace_ChatService__SendComplaint
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param3_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a628ef == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_ServicesNamespace_ChatService_Request_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoProcessComplaintCmd_TypeInfo);
		    DAT_ram_00a628ef = '\x01';
		  }
		  param3_00 = unnamed_function_1417(Protocol_Chat_ProtoProcessComplaintCmd_TypeInfo);
		  *(undefined1 *)(param3_00 + 0x10) = (undefined1)param3;
		  *(undefined4 *)(param3_00 + 0xc) = param2;
		  uVar1 = ServicesNamespace_CaveService__CaveRequest___Il2CppFullySharedGenericType_
		                    (param1,6,param3_00,
		                     Method_ServicesNamespace_ChatService_Request_ProtoDefaultAns___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x588F", Offset = "0x588F", VA = "0x588F")]
		public OpToken<IMessage, object> ProcessComplaint(uint complaintId, bool accepted)
		{
		/* --- GHIDRA: ProcessComplaint ---
		undefined4
		ServicesNamespace_ChatService__ProcessComplaint
		          (undefined4 param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param3_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a628f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_ServicesNamespace_ChatService_Request_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoBanUserCmd_TypeInfo);
		    DAT_ram_00a628f0 = '\x01';
		  }
		  param3_00 = unnamed_function_1417(Protocol_Chat_ProtoBanUserCmd_TypeInfo);
		  *(undefined4 *)(param3_00 + 0x18) = param3;
		  *(undefined8 *)(param3_00 + 0x10) = param2;
		  uVar1 = ServicesNamespace_CaveService__CaveRequest___Il2CppFullySharedGenericType_
		                    (param1,7,param3_00,
		                     Method_ServicesNamespace_ChatService_Request_ProtoDefaultAns___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x5890", Offset = "0x5890", VA = "0x5890")]
		public OpToken<IMessage, object> BanUser(ulong userId, uint banId)
		{
		/* --- GHIDRA: BanUser ---
		undefined4 ServicesNamespace_ChatService__BanUser(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a628f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_ServicesNamespace_ChatService_Request_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoTakeoffBanCmd_TypeInfo);
		    DAT_ram_00a628f1 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Protocol_Chat_ProtoTakeoffBanCmd_TypeInfo);
		  uVar1 = ServicesNamespace_CaveService__CaveRequest___Il2CppFullySharedGenericType_
		                    (param1,9,uVar1,Method_ServicesNamespace_ChatService_Request_ProtoDefaultAns___)
		  ;
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x5891", Offset = "0x5891", VA = "0x5891")]
		public OpToken<IMessage, object> TakeOffBan()
		{
			return null;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x5892", Offset = "0x5892", VA = "0x5892")]
		public ChatService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_ChatService__get_ServiceId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628cd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoJoinRoomEvt__TypeInfo);
		    DAT_ram_00a628cd = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoJoinRoomEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoJoinRoomEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
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


		/* --- GHIDRA: add_RoomJoinEvent ---
		void ServicesNamespace_ChatService__add_RoomJoinEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628ce == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoJoinRoomEvt__TypeInfo);
		    DAT_ram_00a628ce = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoJoinRoomEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoJoinRoomEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
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


		/* --- GHIDRA: remove_RoomJoinEvent ---
		void ServicesNamespace_ChatService__remove_RoomJoinEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628cf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUnjoinRoomEvt__TypeInfo);
		    DAT_ram_00a628cf = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoUnjoinRoomEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoUnjoinRoomEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
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


		/* --- GHIDRA: add_RoomUnjoinEvent ---
		void ServicesNamespace_ChatService__add_RoomUnjoinEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUnjoinRoomEvt__TypeInfo);
		    DAT_ram_00a628d0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoUnjoinRoomEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoUnjoinRoomEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
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


		/* --- GHIDRA: remove_RoomUnjoinEvent ---
		void ServicesNamespace_ChatService__remove_RoomUnjoinEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628d1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoChatMessageEvt__TypeInfo);
		    DAT_ram_00a628d1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoChatMessageEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoChatMessageEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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


		/* --- GHIDRA: add_NewMessageEvent ---
		void ServicesNamespace_ChatService__add_NewMessageEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628d2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoChatMessageEvt__TypeInfo);
		    DAT_ram_00a628d2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoChatMessageEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoChatMessageEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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


		/* --- GHIDRA: remove_NewMessageEvent ---
		void ServicesNamespace_ChatService__remove_NewMessageEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628d3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserInfoChangedEvt__TypeInfo);
		    DAT_ram_00a628d3 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoUserInfoChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoUserInfoChangedEvt__TypeInfo), iVar2 == 0)
		       ) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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


		/* --- GHIDRA: add_UserInfoChangedEvent ---
		void ServicesNamespace_ChatService__add_UserInfoChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserInfoChangedEvt__TypeInfo);
		    DAT_ram_00a628d4 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoUserInfoChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoUserInfoChangedEvt__TypeInfo), iVar2 == 0)
		       ) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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


		/* --- GHIDRA: remove_UserInfoChangedEvent ---
		void ServicesNamespace_ChatService__remove_UserInfoChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoNewComplaintEvt__TypeInfo);
		    DAT_ram_00a628d5 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoNewComplaintEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoNewComplaintEvt__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: add_NewComplaintEvent ---
		void ServicesNamespace_ChatService__add_NewComplaintEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628d6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoNewComplaintEvt__TypeInfo);
		    DAT_ram_00a628d6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoNewComplaintEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoNewComplaintEvt__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: remove_NewComplaintEvent ---
		void ServicesNamespace_ChatService__remove_NewComplaintEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628d7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoComplaintProcessedEvt__TypeInfo);
		    DAT_ram_00a628d7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoComplaintProcessedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoComplaintProcessedEvt__TypeInfo),
		       iVar2 == 0)) break;
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


		/* --- GHIDRA: add_ComplaintProcessedEvent ---
		void ServicesNamespace_ChatService__add_ComplaintProcessedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628d8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoComplaintProcessedEvt__TypeInfo);
		    DAT_ram_00a628d8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoComplaintProcessedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoComplaintProcessedEvt__TypeInfo),
		       iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_ComplaintProcessedEvent ---
		void ServicesNamespace_ChatService__remove_ComplaintProcessedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoAdmonitionEvt__TypeInfo);
		    DAT_ram_00a628d9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoAdmonitionEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoAdmonitionEvt__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: add_AdmonitionEvent ---
		void ServicesNamespace_ChatService__add_AdmonitionEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628da == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoAdmonitionEvt__TypeInfo);
		    DAT_ram_00a628da = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoAdmonitionEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoAdmonitionEvt__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: remove_AdmonitionEvent ---
		void ServicesNamespace_ChatService__remove_AdmonitionEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628db == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoRemoveMessageEvt__TypeInfo);
		    DAT_ram_00a628db = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoRemoveMessageEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoRemoveMessageEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x30,iVar2,param1_00);
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


		/* --- GHIDRA: add_MessageRemovedEvent ---
		void ServicesNamespace_ChatService__add_MessageRemovedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628dc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoRemoveMessageEvt__TypeInfo);
		    DAT_ram_00a628dc = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoRemoveMessageEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoRemoveMessageEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x30,iVar2,param1_00);
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


		/* --- GHIDRA: remove_MessageRemovedEvent ---
		void ServicesNamespace_ChatService__remove_MessageRemovedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628dd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ChatUserInfo__TypeInfo);
		    DAT_ram_00a628dd = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x34);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ChatUserInfo__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ChatUserInfo__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x34,iVar2,param1_00);
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


		/* --- GHIDRA: add_NewContactEvent ---
		void ServicesNamespace_ChatService__add_NewContactEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628de == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ChatUserInfo__TypeInfo);
		    DAT_ram_00a628de = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x34);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ChatUserInfo__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ChatUserInfo__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x34,iVar2,param1_00);
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


		/* --- GHIDRA: remove_NewContactEvent ---
		void ServicesNamespace_ChatService__remove_NewContactEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628df == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoContactRemovedEvt__TypeInfo);
		    DAT_ram_00a628df = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x38);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoContactRemovedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoContactRemovedEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x38,iVar2,param1_00);
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


		/* --- GHIDRA: add_ContactRemovedEvent ---
		void ServicesNamespace_ChatService__add_ContactRemovedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoContactRemovedEvt__TypeInfo);
		    DAT_ram_00a628e0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x38);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoContactRemovedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoContactRemovedEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x38,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ContactRemovedEvent ---
		void ServicesNamespace_ChatService__remove_ContactRemovedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoRightsChangedEvt__TypeInfo);
		    DAT_ram_00a628e1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoRightsChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoRightsChangedEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x3c,iVar2,param1_00);
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


		/* --- GHIDRA: add_RightsChangedEvent ---
		void ServicesNamespace_ChatService__add_RightsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoRightsChangedEvt__TypeInfo);
		    DAT_ram_00a628e2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoRightsChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoRightsChangedEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x3c,iVar2,param1_00);
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


		/* --- GHIDRA: remove_RightsChangedEvent ---
		void ServicesNamespace_ChatService__remove_RightsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628e3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoAttackabilityChangedEvt__TypeInfo);
		    DAT_ram_00a628e3 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoAttackabilityChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoAttackabilityChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x40,iVar2,param1_00);
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


		/* --- GHIDRA: add_AttackAbilityInfoChangedEvent ---
		void ServicesNamespace_ChatService__add_AttackAbilityInfoChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a628e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoAttackabilityChangedEvt__TypeInfo);
		    DAT_ram_00a628e4 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoAttackabilityChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoAttackabilityChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x40,iVar2,param1_00);
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


		/* --- GHIDRA: remove_AttackAbilityInfoChangedEvent ---
		void ServicesNamespace_ChatService__remove_AttackAbilityInfoChangedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a628e5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_ChatEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ChatUserInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoAdmonitionEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoAttackabilityChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoChatMessageEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoComplaintProcessedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoContactRemovedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoJoinRoomEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoNewComplaintEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoRemoveMessageEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoRightsChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoUnjoinRoomEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ProtoUserInfoChangedEvt_TypeInfo);
		    DAT_ram_00a628e5 = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar1,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_ChatEvents___);
		  if (iVar1 == 1) {
		    iVar1 = *(int *)(param1 + 0x14);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Chat_ProtoJoinRoomEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Chat_ProtoJoinRoomEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 2) {
		    iVar1 = *(int *)(param1 + 0x18);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Chat_ProtoUnjoinRoomEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Chat_ProtoUnjoinRoomEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 3) {
		    iVar1 = *(int *)(param1 + 0x1c);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Chat_ProtoChatMessageEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Chat_ProtoChatMessageEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 4) {
		    iVar1 = *(int *)(param1 + 0x20);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Chat_ProtoUserInfoChangedEvt_TypeInfo != *param1_00))
		    {
		      System_Activator__CreateInstance(param1_00,Protocol_Chat_ProtoUserInfoChangedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 5) {
		    iVar1 = *(int *)(param1 + 0x24);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Chat_ProtoNewComplaintEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Chat_ProtoNewComplaintEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 6) {
		    iVar1 = *(int *)(param1 + 0x28);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_Chat_ProtoComplaintProcessedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Chat_ProtoComplaintProcessedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else {
		    if (iVar1 == 7) {
		      return;
		    }
		    if (iVar1 == 8) {
		      iVar1 = *(int *)(param1 + 0x2c);
		      if (iVar1 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) && (Protocol_Chat_ProtoAdmonitionEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance(param1_00,Protocol_Chat_ProtoAdmonitionEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else if (iVar1 == 9) {
		      iVar1 = *(int *)(param1 + 0x30);
		      if (iVar1 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) && (Protocol_Chat_ProtoRemoveMessageEvt_TypeInfo != *param1_00))
		      {
		        System_Activator__CreateInstance(param1_00,Protocol_Chat_ProtoRemoveMessageEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else {
		      if (iVar1 == 10) {
		        return;
		      }
		      if (iVar1 == 0xb) {
		        iVar1 = *(int *)(param1 + 0x34);
		        if (iVar1 == 0) {
		          return;
		        }
		        param1_00 = *(int **)(param2 + 0x20);
		        if ((param1_00 != (int *)0x0) && (Protocol_Chat_ChatUserInfo_TypeInfo != *param1_00)) {
		          System_Activator__CreateInstance(param1_00,Protocol_Chat_ChatUserInfo_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      else if (iVar1 == 0xc) {
		        iVar1 = *(int *)(param1 + 0x38);
		        if (iVar1 == 0) {
		          return;
		        }
		        param1_00 = *(int **)(param2 + 0x20);
		        if ((param1_00 != (int *)0x0) &&
		           (Protocol_Chat_ProtoContactRemovedEvt_TypeInfo != *param1_00)) {
		          System_Activator__CreateInstance(param1_00,Protocol_Chat_ProtoContactRemovedEvt_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      else if (iVar1 == 0xd) {
		        iVar1 = *(int *)(param1 + 0x3c);
		        if (iVar1 == 0) {
		          return;
		        }
		        param1_00 = *(int **)(param2 + 0x20);
		        if ((param1_00 != (int *)0x0) &&
		           (Protocol_Chat_ProtoRightsChangedEvt_TypeInfo != *param1_00)) {
		          System_Activator__CreateInstance(param1_00,Protocol_Chat_ProtoRightsChangedEvt_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      else {
		        if (iVar1 != 0xe) {
		          return;
		        }
		        iVar1 = *(int *)(param1 + 0x40);
		        if (iVar1 == 0) {
		          return;
		        }
		        param1_00 = *(int **)(param2 + 0x20);
		        if ((param1_00 != (int *)0x0) &&
		           (Protocol_Chat_ProtoAttackabilityChangedEvt_TypeInfo != *param1_00)) {
		          System_Activator__CreateInstance
		                    (param1_00,Protocol_Chat_ProtoAttackabilityChangedEvt_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		    }
		  }
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/


		/* --- GHIDRA: Request<object> ---
		int * ServicesNamespace_ChatService__Request_object_
		                (int *param1,undefined4 param2,undefined4 param3,int param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (*(int *)(param4 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ChatCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    if (*(int *)(param4 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param4);
		    }
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = (int *)Core_Net_AbstractService__PushCommand
		                               (param1,*(undefined4 *)
		                                        (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  iVar1 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		              (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,(int)(short)param2,param3,0);
		    local_8 = 0xffffffff;
		    local_c = Protocol_Chat_ChatCommands_TypeInfo;
		    local_4 = param2;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    (**(code **)((ulonglong)*(uint *)**(undefined4 **)(param4 + 0x1c) * 4))
		              (iVar1,uVar2,(uint *)**(undefined4 **)(param4 + 0x1c));
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

}
