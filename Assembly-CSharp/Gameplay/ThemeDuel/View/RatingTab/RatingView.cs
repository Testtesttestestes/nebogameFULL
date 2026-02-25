using System;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using UI.Elements.Filters.GenericFilter;
using UI.Elements.RatingElements;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.ThemeDuel.View.RatingTab
{
	// Token: 0x020004E2 RID: 1250
	[Token(Token = "0x20004E2")]
	public class RatingView : MonoBehaviour
	{
		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000563")]
		public TopLeaders TopLeaders
		{
			[Token(Token = "0x6001DDA")]
			[Address(RVA = "0x6F58", Offset = "0x6F58", VA = "0x6F58")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001DDB RID: 7643 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000564")]
		public GenericSubFilterView SubRatings
		{
			[Token(Token = "0x6001DDB")]
			[Address(RVA = "0x6F59", Offset = "0x6F59", VA = "0x6F59")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001DDC RID: 7644 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000565")]
		public GenericFilterView PeriodFilter
		{
			[Token(Token = "0x6001DDC")]
			[Address(RVA = "0x6F5A", Offset = "0x6F5A", VA = "0x6F5A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000566")]
		public DeselectableGenericFilterView ExtraFilter
		{
			[Token(Token = "0x6001DDD")]
			[Address(RVA = "0x6F5B", Offset = "0x6F5B", VA = "0x6F5B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001DDE RID: 7646 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000567")]
		public CommonRatingOSAView UsersOSAView
		{
			[Token(Token = "0x6001DDE")]
			[Address(RVA = "0x6F5C", Offset = "0x6F5C", VA = "0x6F5C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001DDF RID: 7647 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000568")]
		public RatingsDescription Description
		{
			[Token(Token = "0x6001DDF")]
			[Address(RVA = "0x6F5D", Offset = "0x6F5D", VA = "0x6F5D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000569")]
		public Toggle PeriodFilterToggle
		{
			[Token(Token = "0x6001DE0")]
			[Address(RVA = "0x6F5E", Offset = "0x6F5E", VA = "0x6F5E")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700056A")]
		public Toggle ExtraFilterToggle
		{
			[Token(Token = "0x6001DE1")]
			[Address(RVA = "0x6F5F", Offset = "0x6F5F", VA = "0x6F5F")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700056B")]
		public Toggle RewardsToggle
		{
			[Token(Token = "0x6001DE2")]
			[Address(RVA = "0x6F60", Offset = "0x6F60", VA = "0x6F60")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700056C")]
		public MyCommonRatingView MyRatingView
		{
			[Token(Token = "0x6001DE3")]
			[Address(RVA = "0x6F61", Offset = "0x6F61", VA = "0x6F61")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700056D")]
		public RatingRewardsView RatingRewards
		{
			[Token(Token = "0x6001DE4")]
			[Address(RVA = "0x6F62", Offset = "0x6F62", VA = "0x6F62")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DE5")]
		[Address(RVA = "0x6F63", Offset = "0x6F63", VA = "0x6F63")]
		public void Init()
		{
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DE6")]
		[Address(RVA = "0x6F64", Offset = "0x6F64", VA = "0x6F64")]
		public RatingView()
		{
		}

		// Token: 0x0400103F RID: 4159
		[Token(Token = "0x400103F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TopLeaders _topLeaders;

		// Token: 0x04001040 RID: 4160
		[Token(Token = "0x4001040")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GenericSubFilterView _subRatings;

		// Token: 0x04001041 RID: 4161
		[Token(Token = "0x4001041")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GenericFilterView _periodFilter;

		// Token: 0x04001042 RID: 4162
		[Token(Token = "0x4001042")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private DeselectableGenericFilterView _extraFilter;

		// Token: 0x04001043 RID: 4163
		[Token(Token = "0x4001043")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RatingsDescription _description;

		// Token: 0x04001044 RID: 4164
		[Token(Token = "0x4001044")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private CommonRatingOSAView _usersOSAView;

		// Token: 0x04001045 RID: 4165
		[Token(Token = "0x4001045")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Toggle _periodFilterToggle;

		// Token: 0x04001046 RID: 4166
		[Token(Token = "0x4001046")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Toggle _extraFilterToggle;

		// Token: 0x04001047 RID: 4167
		[Token(Token = "0x4001047")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Toggle _rewardsToggle;

		// Token: 0x04001048 RID: 4168
		[Token(Token = "0x4001048")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private MyCommonRatingView _myRatingView;

		// Token: 0x04001049 RID: 4169
		[Token(Token = "0x4001049")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RatingRewardsView _ratingRewards;
	}
}
