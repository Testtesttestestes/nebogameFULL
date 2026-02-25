using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Rating;
using UI.Tabs;

namespace Gameplay.VortexRating.Model
{
	// Token: 0x02000393 RID: 915
	[Token(Token = "0x2000393")]
	public class VortexRatingModel : AbstractModel
	{
		// Token: 0x06001555 RID: 5461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001555")]
		[Address(RVA = "0x6717", Offset = "0x6717", VA = "0x6717")]
		public VortexRatingModel(UserData user)
		{
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001556 RID: 5462 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001557 RID: 5463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000389")]
		public ProtoGetGreatTopAns GreatTop
		{
			[Token(Token = "0x6001556")]
			[Address(RVA = "0x6718", Offset = "0x6718", VA = "0x6718")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001557")]
			[Address(RVA = "0x6719", Offset = "0x6719", VA = "0x6719")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001559 RID: 5465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038A")]
		public Dictionary<ulong, GreatUserData> GreatUsers
		{
			[Token(Token = "0x6001558")]
			[Address(RVA = "0x671A", Offset = "0x671A", VA = "0x671A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001559")]
			[Address(RVA = "0x671B", Offset = "0x671B", VA = "0x671B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600155B RID: 5467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038B")]
		public RatingPrizeDic[] Prizes
		{
			[Token(Token = "0x600155A")]
			[Address(RVA = "0x671C", Offset = "0x671C", VA = "0x671C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600155B")]
			[Address(RVA = "0x671D", Offset = "0x671D", VA = "0x671D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600155C")]
		[Address(RVA = "0x671E", Offset = "0x671E", VA = "0x671E")]
		public TabBarItemData[] GetTabBarItemData()
		{
			return null;
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600155D")]
		[Address(RVA = "0x671F", Offset = "0x671F", VA = "0x671F")]
		public ResourceSet GetPartyCombatCost()
		{
			return null;
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600155E")]
		[Address(RVA = "0x6720", Offset = "0x6720", VA = "0x6720")]
		public void PopulateGreatTop(ProtoGetGreatTopAns ans)
		{
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600155F")]
		[Address(RVA = "0x6721", Offset = "0x6721", VA = "0x6721")]
		public void PopulateUsers(IList<GreatUserTopInfo> users)
		{
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001560")]
		[Address(RVA = "0x6722", Offset = "0x6722", VA = "0x6722")]
		private GreatUserData ConstructGreatUserData(GreatUserTopInfo greatUserInfo)
		{
			return null;
		}

		// Token: 0x04000B58 RID: 2904
		[Token(Token = "0x4000B58")]
		[FieldOffset(Offset = "0xC")]
		public readonly Dictionaries Dict;
	}
}
