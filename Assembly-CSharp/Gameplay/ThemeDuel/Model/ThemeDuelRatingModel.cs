using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Clans.Office.View.ClanResumesTab;
using Gameplay.Rating.Model;
using Il2CppDummyDll;
using Protocol.Rating;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.ThemeDuel.Model
{
	// Token: 0x020004E7 RID: 1255
	[Token(Token = "0x20004E7")]
	public class ThemeDuelRatingModel : RatingModel
	{
		// Token: 0x06001DFC RID: 7676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DFC")]
		[Address(RVA = "0x6F7A", Offset = "0x6F7A", VA = "0x6F7A")]
		public ThemeDuelRatingModel(UserData user, ThemeRatingTypes themeRatingType)
		{
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x00006408 File Offset: 0x00004608
		[Token(Token = "0x17000574")]
		public ThemeRatingTypes ThemeRatingType
		{
			[Token(Token = "0x6001DFD")]
			[Address(RVA = "0x6F7B", Offset = "0x6F7B", VA = "0x6F7B")]
			[CompilerGenerated]
			get
			{
				return ThemeRatingTypes.Unknown;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001DFE RID: 7678 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000575")]
		public override FilterListElement.FilterData[] UserPeriodFilterDatas
		{
			[Token(Token = "0x6001DFE")]
			[Address(RVA = "0x6F7C", Offset = "0x6F7C", VA = "0x6F7C", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DFF")]
		[Address(RVA = "0x6F7D", Offset = "0x6F7D", VA = "0x6F7D")]
		public void PopulateUsers(ProtoGetUserTDRatingAns user, ProtoGetAllUsersTDRatingAns msg, uint ratingType, RatingPeriods period)
		{
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001E00")]
		[Address(RVA = "0x6F7E", Offset = "0x6F7E", VA = "0x6F7E")]
		private UserInRatingListElement.UserInRatingListElementArgs ConstructArgs(UserInThemeduelRating userInRating, in int index)
		{
			return null;
		}

		// Token: 0x04001056 RID: 4182
		[Token(Token = "0x4001056")]
		[FieldOffset(Offset = "0x48")]
		private FilterListElement.FilterData[] _usersFilterDatas;
	}
}
