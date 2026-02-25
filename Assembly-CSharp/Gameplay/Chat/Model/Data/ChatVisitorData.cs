using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Chat;

namespace Gameplay.Chat.Model.Data
{
	// Token: 0x02000B12 RID: 2834
	[Token(Token = "0x2000B12")]
	public class ChatVisitorData : IDisposable
	{
		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x06004465 RID: 17509 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004466 RID: 17510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D7E")]
		public AttackabilityInfo AttackAbilityInfo
		{
			[Token(Token = "0x6004465")]
			[Address(RVA = "0x9315", Offset = "0x9315", VA = "0x9315")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004466")]
			[Address(RVA = "0x9316", Offset = "0x9316", VA = "0x9316")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x06004467 RID: 17511 RVA: 0x0000CE88 File Offset: 0x0000B088
		// (set) Token: 0x06004468 RID: 17512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D7F")]
		public bool HasBanDataUpdated
		{
			[Token(Token = "0x6004467")]
			[Address(RVA = "0x9317", Offset = "0x9317", VA = "0x9317")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004468")]
			[Address(RVA = "0x9318", Offset = "0x9318", VA = "0x9318")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06004469 RID: 17513 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600446A RID: 17514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D80")]
		public ChatBanData BanData
		{
			[Token(Token = "0x6004469")]
			[Address(RVA = "0x9319", Offset = "0x9319", VA = "0x9319")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600446A")]
			[Address(RVA = "0x931A", Offset = "0x931A", VA = "0x931A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x0600446B RID: 17515 RVA: 0x0000CEA0 File Offset: 0x0000B0A0
		[Token(Token = "0x17000D81")]
		public bool IsModerator
		{
			[Token(Token = "0x600446B")]
			[Address(RVA = "0x931B", Offset = "0x931B", VA = "0x931B")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x0600446C RID: 17516 RVA: 0x0000CEB8 File Offset: 0x0000B0B8
		[Token(Token = "0x17000D82")]
		public bool IsBanned
		{
			[Token(Token = "0x600446C")]
			[Address(RVA = "0x931C", Offset = "0x931C", VA = "0x931C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x0600446D RID: 17517 RVA: 0x0000CED0 File Offset: 0x0000B0D0
		[Token(Token = "0x17000D83")]
		public bool IsVulnerable
		{
			[Token(Token = "0x600446D")]
			[Address(RVA = "0x931D", Offset = "0x931D", VA = "0x931D")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x0600446E RID: 17518 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600446F RID: 17519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D84")]
		public ChatUserInfo UserInfo
		{
			[Token(Token = "0x600446E")]
			[Address(RVA = "0x931E", Offset = "0x931E", VA = "0x931E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600446F")]
			[Address(RVA = "0x931F", Offset = "0x931F", VA = "0x931F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x06004470 RID: 17520 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004471 RID: 17521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D85")]
		public UserData User
		{
			[Token(Token = "0x6004470")]
			[Address(RVA = "0x9320", Offset = "0x9320", VA = "0x9320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004471")]
			[Address(RVA = "0x9321", Offset = "0x9321", VA = "0x9321")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x06004472 RID: 17522 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004473 RID: 17523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D86")]
		public Dictionary<RoomKey, ChatRoomData> Rooms
		{
			[Token(Token = "0x6004472")]
			[Address(RVA = "0x9322", Offset = "0x9322", VA = "0x9322")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004473")]
			[Address(RVA = "0x9323", Offset = "0x9323", VA = "0x9323")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004474 RID: 17524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004474")]
		[Address(RVA = "0x9324", Offset = "0x9324", VA = "0x9324", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06004475 RID: 17525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004475")]
		[Address(RVA = "0x9325", Offset = "0x9325", VA = "0x9325")]
		public ChatVisitorData(ChatUserInfo userInfo)
		{
		}

		// Token: 0x06004476 RID: 17526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004476")]
		[Address(RVA = "0x9326", Offset = "0x9326", VA = "0x9326", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
