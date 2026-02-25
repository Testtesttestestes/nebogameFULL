using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using Core.Dict;
using Gameplay.Clans.Office.View.ClanResumesTab;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Rating;

namespace Gameplay.Clans.Office.Model
{
	// Token: 0x02000A4A RID: 2634
	[Token(Token = "0x2000A4A")]
	public class ClanResumesModel : AbstractModel
	{
		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06003E62 RID: 15970 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C81")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6003E62")]
			[Address(RVA = "0x8D21", Offset = "0x8D21", VA = "0x8D21")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06003E63 RID: 15971 RVA: 0x0000C528 File Offset: 0x0000A728
		// (set) Token: 0x06003E64 RID: 15972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C82")]
		public int MaxListCount
		{
			[Token(Token = "0x6003E63")]
			[Address(RVA = "0x8D22", Offset = "0x8D22", VA = "0x8D22")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003E64")]
			[Address(RVA = "0x8D23", Offset = "0x8D23", VA = "0x8D23")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003E65 RID: 15973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E65")]
		[Address(RVA = "0x8D24", Offset = "0x8D24", VA = "0x8D24")]
		public ClanResumesModel(UserData user, ClanInfoModel clanInfoModel)
		{
		}

		// Token: 0x06003E66 RID: 15974 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E66")]
		[Address(RVA = "0x8D25", Offset = "0x8D25", VA = "0x8D25")]
		public IList<UserInRatingListElement.UserInRatingListElementArgs> GetLastPage()
		{
			return null;
		}

		// Token: 0x06003E67 RID: 15975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E67")]
		[Address(RVA = "0x8D26", Offset = "0x8D26", VA = "0x8D26")]
		public void CreateUsersList(IList<UserInRating> usersList)
		{
		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E68")]
		[Address(RVA = "0x8D27", Offset = "0x8D27", VA = "0x8D27")]
		public void AddUsersList(IList<UserInRating> usersList)
		{
		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E69")]
		[Address(RVA = "0x8D28", Offset = "0x8D28", VA = "0x8D28")]
		private UserInRatingListElement.UserInRatingListElementArgs ConstructArgs(UserInRating userInRating, in int index, in int prevCount)
		{
			return null;
		}

		// Token: 0x04002311 RID: 8977
		[Token(Token = "0x4002311")]
		[FieldOffset(Offset = "0xC")]
		private readonly IDictProvider _dictProvider;

		// Token: 0x04002312 RID: 8978
		[Token(Token = "0x4002312")]
		[FieldOffset(Offset = "0x10")]
		public readonly ClanInfoModel ClanInfoModel;

		// Token: 0x04002313 RID: 8979
		[Token(Token = "0x4002313")]
		[FieldOffset(Offset = "0x14")]
		public readonly Stack<IList<UserInRatingListElement.UserInRatingListElementArgs>> UsersInRatingStack;

		// Token: 0x04002314 RID: 8980
		[Token(Token = "0x4002314")]
		[FieldOffset(Offset = "0x18")]
		private readonly IUserCache _userCache;
	}
}
