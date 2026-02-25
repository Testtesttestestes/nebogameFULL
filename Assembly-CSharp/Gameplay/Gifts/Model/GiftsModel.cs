using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.Gifts.Model
{
	// Token: 0x0200070C RID: 1804
	[Token(Token = "0x200070C")]
	public class GiftsModel : AbstractModel
	{
		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06002B25 RID: 11045 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002B26 RID: 11046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000834")]
		public UserData TargetUser
		{
			[Token(Token = "0x6002B25")]
			[Address(RVA = "0x7BC0", Offset = "0x7BC0", VA = "0x7BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B26")]
			[Address(RVA = "0x7BC1", Offset = "0x7BC1", VA = "0x7BC1")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06002B27 RID: 11047 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002B28 RID: 11048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000835")]
		public SocialGiftDic[] Gifts
		{
			[Token(Token = "0x6002B27")]
			[Address(RVA = "0x7BC2", Offset = "0x7BC2", VA = "0x7BC2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B28")]
			[Address(RVA = "0x7BC3", Offset = "0x7BC3", VA = "0x7BC3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06002B29 RID: 11049 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002B2A RID: 11050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000836")]
		public IList<ulong> UsersGifted
		{
			[Token(Token = "0x6002B29")]
			[Address(RVA = "0x7BC4", Offset = "0x7BC4", VA = "0x7BC4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B2A")]
			[Address(RVA = "0x7BC5", Offset = "0x7BC5", VA = "0x7BC5")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06002B2B RID: 11051 RVA: 0x000086A0 File Offset: 0x000068A0
		[Token(Token = "0x17000837")]
		public int GiftsSent
		{
			[Token(Token = "0x6002B2B")]
			[Address(RVA = "0x7BC6", Offset = "0x7BC6", VA = "0x7BC6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06002B2C RID: 11052 RVA: 0x000086B8 File Offset: 0x000068B8
		[Token(Token = "0x17000838")]
		public int MaxSendGifts
		{
			[Token(Token = "0x6002B2C")]
			[Address(RVA = "0x7BC7", Offset = "0x7BC7", VA = "0x7BC7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06002B2D RID: 11053 RVA: 0x000086D0 File Offset: 0x000068D0
		[Token(Token = "0x17000839")]
		public int GiftsLeft
		{
			[Token(Token = "0x6002B2D")]
			[Address(RVA = "0x7BC8", Offset = "0x7BC8", VA = "0x7BC8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06002B2E RID: 11054 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002B2F RID: 11055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700083A")]
		public IDictProvider DictProvider
		{
			[Token(Token = "0x6002B2E")]
			[Address(RVA = "0x7BC9", Offset = "0x7BC9", VA = "0x7BC9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B2F")]
			[Address(RVA = "0x7BCA", Offset = "0x7BCA", VA = "0x7BCA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06002B30 RID: 11056 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002B31 RID: 11057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700083B")]
		public IGame Game
		{
			[Token(Token = "0x6002B30")]
			[Address(RVA = "0x7BCB", Offset = "0x7BCB", VA = "0x7BCB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B31")]
			[Address(RVA = "0x7BCC", Offset = "0x7BCC", VA = "0x7BCC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B32")]
		[Address(RVA = "0x7BCD", Offset = "0x7BCD", VA = "0x7BCD", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B33")]
		[Address(RVA = "0x7BCE", Offset = "0x7BCE", VA = "0x7BCE")]
		public GiftsModel(IGame game, IDictProvider dictProvider, UserData user)
		{
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B34")]
		[Address(RVA = "0x7BCF", Offset = "0x7BCF", VA = "0x7BCF")]
		public void SetUsersGifted(IList<ulong> usersList)
		{
		}
	}
}
