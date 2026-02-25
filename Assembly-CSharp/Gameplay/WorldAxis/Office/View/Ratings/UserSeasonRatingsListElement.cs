using System;
using System.Collections.Generic;
using Core.Data;
using Il2CppDummyDll;
using UI.Elements.GenericList;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View.Ratings
{
	// Token: 0x02000304 RID: 772
	[Token(Token = "0x2000304")]
	public class UserSeasonRatingsListElement : GenericListElement<UserSeasonRatingsListElement.UserSeasonRatingsListElementArgs>
	{
		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001216 RID: 4630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BD")]
		public UserSeasonRatingsListElement.UserSeasonRatingsListElementArgs Data
		{
			[Token(Token = "0x6001215")]
			[Address(RVA = "0x6410", Offset = "0x6410", VA = "0x6410")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001216")]
			[Address(RVA = "0x6411", Offset = "0x6411", VA = "0x6411")]
			set
			{
			}
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001217")]
		[Address(RVA = "0x6412", Offset = "0x6412", VA = "0x6412", Slot = "4")]
		protected override void OnInit(UserSeasonRatingsListElement.UserSeasonRatingsListElementArgs args)
		{
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001218")]
		[Address(RVA = "0x6413", Offset = "0x6413", VA = "0x6413")]
		private void ApplyArgs(UserSeasonRatingsListElement.UserSeasonRatingsListElementArgs args)
		{
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001219")]
		[Address(RVA = "0x6414", Offset = "0x6414", VA = "0x6414")]
		public UserSeasonRatingsListElement()
		{
		}

		// Token: 0x0400097F RID: 2431
		[Token(Token = "0x400097F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UserInRatingViewElements _baseElements;

		// Token: 0x04000980 RID: 2432
		[Token(Token = "0x4000980")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private DecorViewElements _decorElements;

		// Token: 0x04000981 RID: 2433
		[Token(Token = "0x4000981")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MultipleScoresViewElement _scores;

		// Token: 0x02000305 RID: 773
		[Token(Token = "0x2000305")]
		public class UserSeasonRatingsListElementArgs : GenericListElementArgs
		{
			// Token: 0x170002BE RID: 702
			// (get) Token: 0x0600121A RID: 4634 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170002BE")]
			public virtual string PlaceString
			{
				[Token(Token = "0x600121A")]
				[Address(RVA = "0x6415", Offset = "0x6415", VA = "0x6415", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600121B RID: 4635 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600121B")]
			[Address(RVA = "0x6416", Offset = "0x6416", VA = "0x6416")]
			public UserSeasonRatingsListElementArgs()
			{
			}

			// Token: 0x04000982 RID: 2434
			[Token(Token = "0x4000982")]
			[FieldOffset(Offset = "0xC")]
			public IList<int> UserRatingsIndexes;

			// Token: 0x04000983 RID: 2435
			[Token(Token = "0x4000983")]
			[FieldOffset(Offset = "0x10")]
			public IList<long> Scores;

			// Token: 0x04000984 RID: 2436
			[Token(Token = "0x4000984")]
			[FieldOffset(Offset = "0x14")]
			public UserData UserData;

			// Token: 0x04000985 RID: 2437
			[Token(Token = "0x4000985")]
			[FieldOffset(Offset = "0x18")]
			public int Place;

			// Token: 0x04000986 RID: 2438
			[Token(Token = "0x4000986")]
			[FieldOffset(Offset = "0x1C")]
			public bool MyUser;
		}

		// Token: 0x02000306 RID: 774
		[Token(Token = "0x2000306")]
		public class MyUserSeasonRatingsListElementArgs : UserSeasonRatingsListElement.UserSeasonRatingsListElementArgs
		{
			// Token: 0x170002BF RID: 703
			// (get) Token: 0x0600121C RID: 4636 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170002BF")]
			public override string PlaceString
			{
				[Token(Token = "0x600121C")]
				[Address(RVA = "0x6417", Offset = "0x6417", VA = "0x6417", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600121D RID: 4637 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600121D")]
			[Address(RVA = "0x6418", Offset = "0x6418", VA = "0x6418")]
			public MyUserSeasonRatingsListElementArgs()
			{
			}

			// Token: 0x04000987 RID: 2439
			[Token(Token = "0x4000987")]
			[FieldOffset(Offset = "0x20")]
			public string PlaceText;
		}
	}
}
