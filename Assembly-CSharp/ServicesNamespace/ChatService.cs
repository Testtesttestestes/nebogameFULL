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
			return null;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x5887", Offset = "0x5887", VA = "0x5887")]
		public OpToken<IMessage, object> GetRoomInfo(RoomKey roomKey)
		{
			return null;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x5888", Offset = "0x5888", VA = "0x5888")]
		public OpToken<IMessage, object> SendMessage(RoomKey roomKey, string text, ChatMessage.Types.ChatMessageTypes messageType, ulong toUserId)
		{
			return null;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x5889", Offset = "0x5889", VA = "0x5889")]
		public OpToken<IMessage, object> GetContactList()
		{
			return null;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x588A", Offset = "0x588A", VA = "0x588A")]
		public OpToken<IMessage, object> AddToFavorites(ulong userId)
		{
			return null;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x588B", Offset = "0x588B", VA = "0x588B")]
		public OpToken<IMessage, object> RemoveFromFavorites(ulong userId)
		{
			return null;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x588C", Offset = "0x588C", VA = "0x588C")]
		public OpToken<IMessage, object> RemoveMessage(RoomKey roomKey, uint messageId, ulong userId)
		{
			return null;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x588D", Offset = "0x588D", VA = "0x588D")]
		public OpToken<IMessage, object> GetAllComplaints()
		{
			return null;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x588E", Offset = "0x588E", VA = "0x588E")]
		public OpToken<IMessage, object> SendComplaint(RoomKey roomKey, uint messageId)
		{
			return null;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x588F", Offset = "0x588F", VA = "0x588F")]
		public OpToken<IMessage, object> ProcessComplaint(uint complaintId, bool accepted)
		{
			return null;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x5890", Offset = "0x5890", VA = "0x5890")]
		public OpToken<IMessage, object> BanUser(ulong userId, uint banId)
		{
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
}
