using System;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Rating;
using UnityEngine;

namespace Gameplay.Clans.Office.View
{
	// Token: 0x02000A02 RID: 2562
	[Token(Token = "0x2000A02")]
	public class ClanInRatingListElement : ClanListElement<ClanInRatingListElement.ClanInRatingListElementArgs>
	{
		// Token: 0x06003CF2 RID: 15602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CF2")]
		[Address(RVA = "0x8BB2", Offset = "0x8BB2", VA = "0x8BB2", Slot = "11")]
		protected override void ApplyArgs()
		{
		}

		// Token: 0x06003CF3 RID: 15603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CF3")]
		[Address(RVA = "0x8BB3", Offset = "0x8BB3", VA = "0x8BB3", Slot = "10")]
		protected override void CallElementClickedEvent(ClanInRatingListElement.ClanInRatingListElementArgs args)
		{
		}

		// Token: 0x06003CF4 RID: 15604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CF4")]
		[Address(RVA = "0x8BB4", Offset = "0x8BB4", VA = "0x8BB4")]
		public ClanInRatingListElement()
		{
		}

		// Token: 0x040021D1 RID: 8657
		[Token(Token = "0x40021D1")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private GameImage _leagueBanner;

		// Token: 0x040021D2 RID: 8658
		[Token(Token = "0x40021D2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameImage _leagueIcon;

		// Token: 0x040021D3 RID: 8659
		[Token(Token = "0x40021D3")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GameObject _restrictionsIndicator;

		// Token: 0x02000A03 RID: 2563
		[Token(Token = "0x2000A03")]
		public class ClanInRatingListElementArgs : ClanListElementArgs<ClanInRating, ClanInRatingListElement>
		{
			// Token: 0x06003CF5 RID: 15605 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003CF5")]
			[Address(RVA = "0x8BB5", Offset = "0x8BB5", VA = "0x8BB5")]
			public ClanInRatingListElementArgs()
			{
			}

			// Token: 0x040021D4 RID: 8660
			[Token(Token = "0x40021D4")]
			[FieldOffset(Offset = "0x28")]
			public bool MyClan;
		}
	}
}
