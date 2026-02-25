using System;
using System.Collections.Generic;
using Core.Cache.User;
using Core.Data;
using Gameplay.Clans.Office.View.ClanResumesTab;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.Competition.Model
{
	// Token: 0x020008F7 RID: 2295
	[Token(Token = "0x20008F7")]
	public class RatingModel : AbstractModel
	{
		// Token: 0x0600360E RID: 13838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600360E")]
		[Address(RVA = "0x861B", Offset = "0x861B", VA = "0x861B")]
		public RatingModel(OwnerRating ownerRating, IUserCache userCache, UserData user, CompetitionRatingKindDic dict)
		{
		}

		// Token: 0x0600360F RID: 13839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600360F")]
		[Address(RVA = "0x861C", Offset = "0x861C", VA = "0x861C")]
		public void SetRating(RatingModel.RatingRecord[] ratingRows)
		{
		}

		// Token: 0x06003610 RID: 13840 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003610")]
		[Address(RVA = "0x861D", Offset = "0x861D", VA = "0x861D")]
		public UserInRatingListElement.UserInRatingListElementArgs[] GetCompetitionRatingUsers()
		{
			return null;
		}

		// Token: 0x06003611 RID: 13841 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003611")]
		[Address(RVA = "0x861E", Offset = "0x861E", VA = "0x861E")]
		public UserInRatingListElement.UserInRatingListElementArgs GetOwnerRating()
		{
			return null;
		}

		// Token: 0x06003612 RID: 13842 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003612")]
		[Address(RVA = "0x861F", Offset = "0x861F", VA = "0x861F")]
		public IEnumerable<UserData> GetUsers()
		{
			return null;
		}

		// Token: 0x04001DB3 RID: 7603
		[Token(Token = "0x4001DB3")]
		[FieldOffset(Offset = "0xC")]
		public readonly IUserCache UserCache;

		// Token: 0x04001DB4 RID: 7604
		[Token(Token = "0x4001DB4")]
		[FieldOffset(Offset = "0x10")]
		public readonly OwnerRating OwnerRating;

		// Token: 0x04001DB5 RID: 7605
		[Token(Token = "0x4001DB5")]
		[FieldOffset(Offset = "0x14")]
		private readonly List<RatingModel.RatingRecord> _records;

		// Token: 0x04001DB6 RID: 7606
		[Token(Token = "0x4001DB6")]
		[FieldOffset(Offset = "0x18")]
		public readonly CompetitionRatingKindDic Dict;

		// Token: 0x020008F8 RID: 2296
		[Token(Token = "0x20008F8")]
		public class RatingRecord
		{
			// Token: 0x06003613 RID: 13843 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003613")]
			[Address(RVA = "0x8620", Offset = "0x8620", VA = "0x8620")]
			public RatingRecord(int place, ulong value, UserData userData, UserData loggedUser)
			{
			}

			// Token: 0x04001DB7 RID: 7607
			[Token(Token = "0x4001DB7")]
			[FieldOffset(Offset = "0x8")]
			public readonly UserData UserData;

			// Token: 0x04001DB8 RID: 7608
			[Token(Token = "0x4001DB8")]
			[FieldOffset(Offset = "0xC")]
			public readonly UserData LoggedUser;

			// Token: 0x04001DB9 RID: 7609
			[Token(Token = "0x4001DB9")]
			[FieldOffset(Offset = "0x10")]
			public readonly int Place;

			// Token: 0x04001DBA RID: 7610
			[Token(Token = "0x4001DBA")]
			[FieldOffset(Offset = "0x18")]
			public readonly ulong Value;
		}
	}
}
