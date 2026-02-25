using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using Core.Gameplay;
using Gameplay.Portals.View.RatingTab;
using Il2CppDummyDll;
using MVC;
using Protocol.Rating;
using Utils;

namespace Gameplay.Portals.Model
{
	// Token: 0x020005D2 RID: 1490
	[Token(Token = "0x20005D2")]
	public class PortalsRatingModel : AbstractModel
	{
		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x060023DB RID: 9179 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006BF")]
		public IGame Game
		{
			[Token(Token = "0x60023DB")]
			[Address(RVA = "0x752D", Offset = "0x752D", VA = "0x752D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060023DC RID: 9180 RVA: 0x00006F90 File Offset: 0x00005190
		// (set) Token: 0x060023DD RID: 9181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006C0")]
		public bool IsAwaitReceivingData
		{
			[Token(Token = "0x60023DC")]
			[Address(RVA = "0x752E", Offset = "0x752E", VA = "0x752E")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60023DD")]
			[Address(RVA = "0x752F", Offset = "0x752F", VA = "0x752F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023DE")]
		[Address(RVA = "0x7530", Offset = "0x7530", VA = "0x7530")]
		public PortalsRatingModel(float cacheTtl, UserData user, IGame game, IUserCache userCache)
		{
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60023DF")]
		[Address(RVA = "0x7531", Offset = "0x7531", VA = "0x7531")]
		public UserInPortalRatingListElement.UserInPortalRatingListElementArgs[] GetPortalRatingUsers(uint ratingType = 0U, RatingPeriods period = RatingPeriods.UnknownRatingPeriod)
		{
			return null;
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60023E0")]
		[Address(RVA = "0x7532", Offset = "0x7532", VA = "0x7532")]
		public UserInPortalRatingListElement.UserInPortalRatingListElementArgs GetPortalRatingMyUser(uint ratingType = 0U, RatingPeriods period = RatingPeriods.UnknownRatingPeriod)
		{
			return null;
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E1")]
		[Address(RVA = "0x7533", Offset = "0x7533", VA = "0x7533")]
		public void PopulateUsers(ProtoGetUserPortalRatingAns user, ProtoGetAllUsersPortalRatingAns msg, uint ratingType = 0U, RatingPeriods period = RatingPeriods.UnknownRatingPeriod)
		{
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E2")]
		[Address(RVA = "0x7534", Offset = "0x7534", VA = "0x7534")]
		private void DoPopulateUsers(UserInPortalRatingListElement.UserInPortalRatingListElementArgs[] usersInRatingArgs, uint ratingType, RatingPeriods period, double userRating, int userPlace, uint userParticipantNum)
		{
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60023E3")]
		[Address(RVA = "0x7535", Offset = "0x7535", VA = "0x7535")]
		private UserInPortalRatingListElement.UserInPortalRatingListElementArgs ConstructArgs(UserInPortalRating userInRating, in int place)
		{
			return null;
		}

		// Token: 0x040013C2 RID: 5058
		[Token(Token = "0x40013C2")]
		[FieldOffset(Offset = "0xC")]
		protected readonly IUserCache _userCache;

		// Token: 0x040013C3 RID: 5059
		[Token(Token = "0x40013C3")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<RatingPeriods, Dictionary<uint, UserInPortalRatingListElement.UserInPortalRatingListElementArgs[]>> _usersCache;

		// Token: 0x040013C4 RID: 5060
		[Token(Token = "0x40013C4")]
		[FieldOffset(Offset = "0x14")]
		private readonly Dictionary<RatingPeriods, Dictionary<uint, UserInPortalRatingListElement.UserInPortalRatingListElementArgs>> _myUserCache;

		// Token: 0x040013C7 RID: 5063
		[Token(Token = "0x40013C7")]
		[FieldOffset(Offset = "0x20")]
		public readonly BackTime CacheBackTime;

		// Token: 0x040013C8 RID: 5064
		[Token(Token = "0x40013C8")]
		[FieldOffset(Offset = "0x24")]
		private readonly float _cacheTtl;
	}
}
