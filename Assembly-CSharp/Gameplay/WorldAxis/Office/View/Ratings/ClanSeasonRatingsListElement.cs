using System;
using System.Collections.Generic;
using Gameplay.World.Model;
using Il2CppDummyDll;
using UI.Elements.GenericList;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View.Ratings
{
	// Token: 0x020002F9 RID: 761
	[Token(Token = "0x20002F9")]
	public class ClanSeasonRatingsListElement : GenericListElement<ClanSeasonRatingsListElement.ClanSeasonRatingsListElementArgs>
	{
		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060011F5 RID: 4597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B5")]
		public ClanSeasonRatingsListElement.ClanSeasonRatingsListElementArgs Data
		{
			[Token(Token = "0x60011F4")]
			[Address(RVA = "0x63EF", Offset = "0x63EF", VA = "0x63EF")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011F5")]
			[Address(RVA = "0x63F0", Offset = "0x63F0", VA = "0x63F0")]
			set
			{
			}
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F6")]
		[Address(RVA = "0x63F1", Offset = "0x63F1", VA = "0x63F1", Slot = "4")]
		protected override void OnInit(ClanSeasonRatingsListElement.ClanSeasonRatingsListElementArgs args)
		{
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F7")]
		[Address(RVA = "0x63F2", Offset = "0x63F2", VA = "0x63F2")]
		private void OnClickEventHandler(ClanSeasonRatingsListElement.ClanSeasonRatingsListElementArgs args)
		{
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F8")]
		[Address(RVA = "0x63F3", Offset = "0x63F3", VA = "0x63F3")]
		private void ApplyArgs(ClanSeasonRatingsListElement.ClanSeasonRatingsListElementArgs args)
		{
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F9")]
		[Address(RVA = "0x63F4", Offset = "0x63F4", VA = "0x63F4")]
		public ClanSeasonRatingsListElement()
		{
		}

		// Token: 0x04000962 RID: 2402
		[Token(Token = "0x4000962")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ClanInRatingViewElements _baseElements;

		// Token: 0x04000963 RID: 2403
		[Token(Token = "0x4000963")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private DecorViewElements _decorElements;

		// Token: 0x04000964 RID: 2404
		[Token(Token = "0x4000964")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MultipleScoresViewElement _scores;

		// Token: 0x020002FA RID: 762
		[Token(Token = "0x20002FA")]
		public class ClanSeasonRatingsListElementArgs : GenericListElementArgs
		{
			// Token: 0x170002B6 RID: 694
			// (get) Token: 0x060011FA RID: 4602 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170002B6")]
			public virtual string PlaceString
			{
				[Token(Token = "0x60011FA")]
				[Address(RVA = "0x63F5", Offset = "0x63F5", VA = "0x63F5", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x060011FB RID: 4603 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60011FB")]
			[Address(RVA = "0x63F6", Offset = "0x63F6", VA = "0x63F6")]
			public ClanSeasonRatingsListElementArgs()
			{
			}

			// Token: 0x04000965 RID: 2405
			[Token(Token = "0x4000965")]
			[FieldOffset(Offset = "0xC")]
			public IList<int> ClanRatingsIndexes;

			// Token: 0x04000966 RID: 2406
			[Token(Token = "0x4000966")]
			[FieldOffset(Offset = "0x10")]
			public IList<long> Scores;

			// Token: 0x04000967 RID: 2407
			[Token(Token = "0x4000967")]
			[FieldOffset(Offset = "0x14")]
			public ClanData ClanData;

			// Token: 0x04000968 RID: 2408
			[Token(Token = "0x4000968")]
			[FieldOffset(Offset = "0x18")]
			public int Place;

			// Token: 0x04000969 RID: 2409
			[Token(Token = "0x4000969")]
			[FieldOffset(Offset = "0x1C")]
			public bool MyClan;

			// Token: 0x0400096A RID: 2410
			[Token(Token = "0x400096A")]
			[FieldOffset(Offset = "0x20")]
			public Action<ClanSeasonRatingsListElement> ButtonClickedEvent;
		}

		// Token: 0x020002FB RID: 763
		[Token(Token = "0x20002FB")]
		public class MyClanSeasonRatingsListElementArgs : ClanSeasonRatingsListElement.ClanSeasonRatingsListElementArgs
		{
			// Token: 0x170002B7 RID: 695
			// (get) Token: 0x060011FC RID: 4604 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170002B7")]
			public override string PlaceString
			{
				[Token(Token = "0x60011FC")]
				[Address(RVA = "0x63F7", Offset = "0x63F7", VA = "0x63F7", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x060011FD RID: 4605 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60011FD")]
			[Address(RVA = "0x63F8", Offset = "0x63F8", VA = "0x63F8")]
			public MyClanSeasonRatingsListElementArgs()
			{
			}

			// Token: 0x0400096B RID: 2411
			[Token(Token = "0x400096B")]
			[FieldOffset(Offset = "0x24")]
			public string PlaceText;
		}
	}
}
