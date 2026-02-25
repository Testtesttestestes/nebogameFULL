using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay.Managers;
using Gameplay.WorldAxis.Office.View.Ratings;
using Il2CppDummyDll;
using MVC;
using Protocol.Colossus;
using Protocol.Dic;

namespace Gameplay.WorldAxis.Office.Model
{
	// Token: 0x020002D1 RID: 721
	[Token(Token = "0x20002D1")]
	public class RatingsModel : AbstractModel
	{
		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060010FE RID: 4350 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000281")]
		public Dictionaries Dict
		{
			[Token(Token = "0x60010FE")]
			[Address(RVA = "0x62FB", Offset = "0x62FB", VA = "0x62FB")]
			get
			{
				return null;
			}
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010FF")]
		[Address(RVA = "0x62FC", Offset = "0x62FC", VA = "0x62FC")]
		public RatingsModel(UserData user, WorldAxisOfficeModel officeModel)
		{
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001101 RID: 4353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000282")]
		public List<ClanSeasonRatingsListElement.ClanSeasonRatingsListElementArgs> ClanRatingsArgs
		{
			[Token(Token = "0x6001100")]
			[Address(RVA = "0x62FD", Offset = "0x62FD", VA = "0x62FD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001101")]
			[Address(RVA = "0x62FE", Offset = "0x62FE", VA = "0x62FE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001103 RID: 4355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000283")]
		public List<UserSeasonRatingsListElement.UserSeasonRatingsListElementArgs> UserRatingsArgs
		{
			[Token(Token = "0x6001102")]
			[Address(RVA = "0x62FF", Offset = "0x62FF", VA = "0x62FF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001103")]
			[Address(RVA = "0x6300", Offset = "0x6300", VA = "0x6300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001105 RID: 4357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000284")]
		public ClanSeasonRatingsListElement.ClanSeasonRatingsListElementArgs MyClanArgs
		{
			[Token(Token = "0x6001104")]
			[Address(RVA = "0x6301", Offset = "0x6301", VA = "0x6301")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001105")]
			[Address(RVA = "0x6302", Offset = "0x6302", VA = "0x6302")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06001106 RID: 4358 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001107 RID: 4359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000285")]
		public UserSeasonRatingsListElement.UserSeasonRatingsListElementArgs MyUserArgs
		{
			[Token(Token = "0x6001106")]
			[Address(RVA = "0x6303", Offset = "0x6303", VA = "0x6303")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001107")]
			[Address(RVA = "0x6304", Offset = "0x6304", VA = "0x6304")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001108")]
		[Address(RVA = "0x6305", Offset = "0x6305", VA = "0x6305")]
		public void PopulateClanRatings(IList<ColossusRating> ratings)
		{
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001109")]
		[Address(RVA = "0x6306", Offset = "0x6306", VA = "0x6306")]
		public void PopulateUserRatings(IList<HeroesRating> ratings)
		{
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600110A")]
		[Address(RVA = "0x6307", Offset = "0x6307", VA = "0x6307")]
		private void SetupMyClanArgs()
		{
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600110B")]
		[Address(RVA = "0x6308", Offset = "0x6308", VA = "0x6308")]
		private void SetupMyUserArgs()
		{
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600110C")]
		[Address(RVA = "0x6309", Offset = "0x6309", VA = "0x6309")]
		private SortCategoryListElement.SortCategoryListElementArgs CreateSortCategory(ColossusRatingDic dic)
		{
			return null;
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600110D")]
		[Address(RVA = "0x630A", Offset = "0x630A", VA = "0x630A")]
		[CompilerGenerated]
		private ClanSeasonRatingsListElement.ClanSeasonRatingsListElementArgs <PopulateClanRatings>g__CreateClanRatingsArgs|26_1(ColossusRating ratings, int index)
		{
			return null;
		}

		// Token: 0x040008CD RID: 2253
		[Token(Token = "0x40008CD")]
		[FieldOffset(Offset = "0xC")]
		private DictManager _dictManager;

		// Token: 0x040008CE RID: 2254
		[Token(Token = "0x40008CE")]
		[FieldOffset(Offset = "0x10")]
		public readonly WorldAxisOfficeModel OfficeModel;

		// Token: 0x040008CF RID: 2255
		[Token(Token = "0x40008CF")]
		[FieldOffset(Offset = "0x14")]
		public readonly SortCategoryListElement.SortCategoryListElementArgs[] ClanSortCategories;

		// Token: 0x040008D0 RID: 2256
		[Token(Token = "0x40008D0")]
		[FieldOffset(Offset = "0x18")]
		public readonly SortCategoryListElement.SortCategoryListElementArgs[] UserSortCategories;

		// Token: 0x040008D1 RID: 2257
		[Token(Token = "0x40008D1")]
		[FieldOffset(Offset = "0x1C")]
		private readonly int[] _clanRatingsIndexes;

		// Token: 0x040008D2 RID: 2258
		[Token(Token = "0x40008D2")]
		[FieldOffset(Offset = "0x20")]
		private readonly int[] _userRatingsIndexes;

		// Token: 0x040008D3 RID: 2259
		[Token(Token = "0x40008D3")]
		[FieldOffset(Offset = "0x24")]
		private readonly int _maxRatingEntries;
	}
}
