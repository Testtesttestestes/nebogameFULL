using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using Core.Dict;
using Gameplay.Chat.Model.Data;
using Gameplay.Chat.Model.Data.Message;
using Gameplay.Chat.Model.Data.Message.Format;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Chat;

namespace Gameplay.Chat.Model
{
	// Token: 0x02000B0C RID: 2828
	[Token(Token = "0x2000B0C")]
	public class ChatModel : AbstractModel, IFavoriteUsersProvider
	{
		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06004419 RID: 17433 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
		// (set) Token: 0x0600441A RID: 17434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D67")]
		public int RoomsJoined
		{
			[Token(Token = "0x6004419")]
			[Address(RVA = "0x92CC", Offset = "0x92CC", VA = "0x92CC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600441A")]
			[Address(RVA = "0x92CD", Offset = "0x92CD", VA = "0x92CD")]
			set
			{
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x0600441B RID: 17435 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600441C RID: 17436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D68")]
		public IChatMsgPresenter MessagePresenter
		{
			[Token(Token = "0x600441B")]
			[Address(RVA = "0x92CE", Offset = "0x92CE", VA = "0x92CE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600441C")]
			[Address(RVA = "0x92CF", Offset = "0x92CF", VA = "0x92CF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x0600441D RID: 17437 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600441E RID: 17438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D69")]
		public IDictProvider DictProvider
		{
			[Token(Token = "0x600441D")]
			[Address(RVA = "0x92D0", Offset = "0x92D0", VA = "0x92D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600441E")]
			[Address(RVA = "0x92D1", Offset = "0x92D1", VA = "0x92D1")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x0600441F RID: 17439 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004420 RID: 17440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D6A")]
		public IUserCache UserCache
		{
			[Token(Token = "0x600441F")]
			[Address(RVA = "0x92D2", Offset = "0x92D2", VA = "0x92D2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004420")]
			[Address(RVA = "0x92D3", Offset = "0x92D3", VA = "0x92D3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004421 RID: 17441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004421")]
		[Address(RVA = "0x92D4", Offset = "0x92D4", VA = "0x92D4", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06004422 RID: 17442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004422")]
		[Address(RVA = "0x92D5", Offset = "0x92D5", VA = "0x92D5")]
		public ChatModel([NotNull] IDictProvider dictProvider, [NotNull] IChatMsgPresenter presenter, [NotNull] UserData user, [NotNull] IUserCache userCache, [NotNull] ChatVisitorData defaultVisitor, int startVisitorsCapacity, int startFavoritesCapacity)
		{
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06004423 RID: 17443 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004424 RID: 17444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D6B")]
		public ChatVisitorData ChatUser
		{
			[Token(Token = "0x6004423")]
			[Address(RVA = "0x92D6", Offset = "0x92D6", VA = "0x92D6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004424")]
			[Address(RVA = "0x92D7", Offset = "0x92D7", VA = "0x92D7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06004425 RID: 17445 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004426 RID: 17446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D6C")]
		public ChatRoomData CurrentRoom
		{
			[Token(Token = "0x6004425")]
			[Address(RVA = "0x92D8", Offset = "0x92D8", VA = "0x92D8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004426")]
			[Address(RVA = "0x92D9", Offset = "0x92D9", VA = "0x92D9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004427 RID: 17447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004427")]
		[Address(RVA = "0x92DA", Offset = "0x92DA", VA = "0x92DA")]
		public void SetChatUser(ChatVisitorData user)
		{
		}

		// Token: 0x06004428 RID: 17448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004428")]
		[Address(RVA = "0x92DB", Offset = "0x92DB", VA = "0x92DB")]
		public void SetCurrentRoom(ChatRoomData room)
		{
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06004429 RID: 17449 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D6D")]
		public List<ChatVisitorData> Favorites
		{
			[Token(Token = "0x6004429")]
			[Address(RVA = "0x92DC", Offset = "0x92DC", VA = "0x92DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x0600442A RID: 17450 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
		// (set) Token: 0x0600442B RID: 17451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D6E")]
		public bool IsFavoritesPrepared
		{
			[Token(Token = "0x600442A")]
			[Address(RVA = "0x92DD", Offset = "0x92DD", VA = "0x92DD")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600442B")]
			[Address(RVA = "0x92DE", Offset = "0x92DE", VA = "0x92DE")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600442C")]
		[Address(RVA = "0x92DF", Offset = "0x92DF", VA = "0x92DF")]
		public ChatVisitorData AddFavorite(ChatVisitorData visitor)
		{
			return null;
		}

		// Token: 0x0600442D RID: 17453 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		[Token(Token = "0x600442D")]
		[Address(RVA = "0x92E0", Offset = "0x92E0", VA = "0x92E0")]
		public bool RemoveFavorite(ulong userId)
		{
			return default(bool);
		}

		// Token: 0x0600442E RID: 17454 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
		[Token(Token = "0x600442E")]
		[Address(RVA = "0x92E1", Offset = "0x92E1", VA = "0x92E1")]
		public bool RemoveFavorite(ChatVisitorData visitor)
		{
			return default(bool);
		}

		// Token: 0x0600442F RID: 17455 RVA: 0x0000CD08 File Offset: 0x0000AF08
		[Token(Token = "0x600442F")]
		[Address(RVA = "0x92E2", Offset = "0x92E2", VA = "0x92E2")]
		public bool TryGetFavorite(ulong userId, out ChatVisitorData visitor)
		{
			return default(bool);
		}

		// Token: 0x06004430 RID: 17456 RVA: 0x0000CD20 File Offset: 0x0000AF20
		[Token(Token = "0x6004430")]
		[Address(RVA = "0x92E3", Offset = "0x92E3", VA = "0x92E3")]
		public bool TryGetVisitor(ulong userId, out ChatVisitorData visitor)
		{
			return default(bool);
		}

		// Token: 0x06004431 RID: 17457 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004431")]
		[Address(RVA = "0x92E4", Offset = "0x92E4", VA = "0x92E4")]
		public ChatVisitorData AddVisitor(ChatVisitorData visitor)
		{
			return null;
		}

		// Token: 0x06004432 RID: 17458 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004432")]
		[Address(RVA = "0x92E5", Offset = "0x92E5", VA = "0x92E5")]
		public ChatRoomData AddVisitorToRoom(RoomKey roomKey, ChatVisitorData visitor)
		{
			return null;
		}

		// Token: 0x06004433 RID: 17459 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004433")]
		[Address(RVA = "0x92E6", Offset = "0x92E6", VA = "0x92E6")]
		public ChatRoomData RemoveVisitorFromRoom(RoomKey roomKey, ChatVisitorData visitor)
		{
			return null;
		}

		// Token: 0x06004434 RID: 17460 RVA: 0x0000CD38 File Offset: 0x0000AF38
		[Token(Token = "0x6004434")]
		[Address(RVA = "0x92E7", Offset = "0x92E7", VA = "0x92E7")]
		public bool TryGetMessage(RoomKey roomKey, uint messageId, out ChatMessageItem messageItem)
		{
			return default(bool);
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x0000CD50 File Offset: 0x0000AF50
		[Token(Token = "0x6004435")]
		[Address(RVA = "0x92E8", Offset = "0x92E8", VA = "0x92E8")]
		public bool TryGetMessage(RoomKey roomKey, uint messageId, out ChatMessageData message)
		{
			return default(bool);
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004436")]
		[Address(RVA = "0x1BB5", Offset = "0x1BB5", VA = "0x1BB5")]
		public ChatMessageItem AddMessage(RoomKey roomKey, ChatMessageData messageData)
		{
			return null;
		}

		// Token: 0x06004437 RID: 17463 RVA: 0x0000CD68 File Offset: 0x0000AF68
		[Token(Token = "0x6004437")]
		[Address(RVA = "0x92E9", Offset = "0x92E9", VA = "0x92E9")]
		public bool TryRemoveMessage(RoomKey roomKey, uint messageId, out ChatMessageItem message)
		{
			return default(bool);
		}

		// Token: 0x06004438 RID: 17464 RVA: 0x0000CD80 File Offset: 0x0000AF80
		[Token(Token = "0x6004438")]
		[Address(RVA = "0x92EA", Offset = "0x92EA", VA = "0x92EA")]
		public bool TryGetRoom(RoomKey roomKey, out ChatRoomData room)
		{
			return default(bool);
		}

		// Token: 0x06004439 RID: 17465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004439")]
		[Address(RVA = "0x92EB", Offset = "0x92EB", VA = "0x92EB")]
		public void RemoveRoom(RoomKey roomKey)
		{
		}

		// Token: 0x0600443A RID: 17466 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600443A")]
		[Address(RVA = "0x92EC", Offset = "0x92EC", VA = "0x92EC")]
		public ChatRoomData AddRoom(ChatRoomData room)
		{
			return null;
		}

		// Token: 0x0600443B RID: 17467 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600443B")]
		[Address(RVA = "0x92ED", Offset = "0x92ED", VA = "0x92ED")]
		public ChatRoomData[] GetRooms()
		{
			return null;
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x0600443C RID: 17468 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D6F")]
		public string MessagePatterString
		{
			[Token(Token = "0x600443C")]
			[Address(RVA = "0x92EE", Offset = "0x92EE", VA = "0x92EE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x0600443D RID: 17469 RVA: 0x0000CD98 File Offset: 0x0000AF98
		[Token(Token = "0x17000D70")]
		public int MaxMessageSize
		{
			[Token(Token = "0x600443D")]
			[Address(RVA = "0x92EF", Offset = "0x92EF", VA = "0x92EF")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x0600443E RID: 17470 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
		// (set) Token: 0x0600443F RID: 17471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D71")]
		public RoomVisitorsOrContactsStates CurrentUIVisitorsState
		{
			[Token(Token = "0x600443E")]
			[Address(RVA = "0x92F0", Offset = "0x92F0", VA = "0x92F0")]
			[CompilerGenerated]
			get
			{
				return RoomVisitorsOrContactsStates.ROOM_VISITORS;
			}
			[Token(Token = "0x600443F")]
			[Address(RVA = "0x92F1", Offset = "0x92F1", VA = "0x92F1")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x06004440 RID: 17472 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		// (set) Token: 0x06004441 RID: 17473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D72")]
		public MiniChatButtonStates CurrentMiniChatViewState
		{
			[Token(Token = "0x6004440")]
			[Address(RVA = "0x92F2", Offset = "0x92F2", VA = "0x92F2")]
			[CompilerGenerated]
			get
			{
				return MiniChatButtonStates.ROLLED_UP;
			}
			[Token(Token = "0x6004441")]
			[Address(RVA = "0x92F3", Offset = "0x92F3", VA = "0x92F3")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x06004442 RID: 17474 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
		// (set) Token: 0x06004443 RID: 17475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D73")]
		public PrivateOrAllMessagesStates CurrentMessagesState
		{
			[Token(Token = "0x6004442")]
			[Address(RVA = "0x92F4", Offset = "0x92F4", VA = "0x92F4")]
			[CompilerGenerated]
			get
			{
				return PrivateOrAllMessagesStates.ALL;
			}
			[Token(Token = "0x6004443")]
			[Address(RVA = "0x92F5", Offset = "0x92F5", VA = "0x92F5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004444 RID: 17476 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004444")]
		[Address(RVA = "0x92F6", Offset = "0x92F6", VA = "0x92F6", Slot = "6")]
		public UserData[] GetFavoriteUsers()
		{
			return null;
		}

		// Token: 0x0400259D RID: 9629
		[Token(Token = "0x400259D")]
		[FieldOffset(Offset = "0xC")]
		public readonly RoomKey ComplaintsAggregatorRoomKey;

		// Token: 0x0400259E RID: 9630
		[Token(Token = "0x400259E")]
		[FieldOffset(Offset = "0x10")]
		public readonly int StartVisitorsCapacity;

		// Token: 0x0400259F RID: 9631
		[Token(Token = "0x400259F")]
		[FieldOffset(Offset = "0x14")]
		public readonly int StartFavoritesCapacity;

		// Token: 0x040025A0 RID: 9632
		[Token(Token = "0x40025A0")]
		[FieldOffset(Offset = "0x18")]
		public readonly ChatVisitorData DefaultVisitorData;

		// Token: 0x040025A1 RID: 9633
		[Token(Token = "0x40025A1")]
		[FieldOffset(Offset = "0x1C")]
		private int _roomsJoined;

		// Token: 0x040025A9 RID: 9641
		[Token(Token = "0x40025A9")]
		[FieldOffset(Offset = "0x3C")]
		private readonly Dictionary<ulong, ChatVisitorData> _visitors;

		// Token: 0x040025AA RID: 9642
		[Token(Token = "0x40025AA")]
		[FieldOffset(Offset = "0x40")]
		private readonly Dictionary<RoomKey, ChatRoomData> _rooms;

		// Token: 0x040025AB RID: 9643
		[Token(Token = "0x40025AB")]
		[FieldOffset(Offset = "0x44")]
		private ChatRoomData[] _sortedRoomsCache;
	}
}
