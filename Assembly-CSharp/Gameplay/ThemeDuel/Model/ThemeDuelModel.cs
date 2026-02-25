using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.ThemeDuelState.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Rating;
using UI.Tabs;

namespace Gameplay.ThemeDuel.Model
{
	// Token: 0x020004E4 RID: 1252
	[Token(Token = "0x20004E4")]
	public class ThemeDuelModel : AbstractModel
	{
		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001DEB RID: 7659 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700056F")]
		public ThemeDuelRatingModel RatingModel
		{
			[Token(Token = "0x6001DEB")]
			[Address(RVA = "0x6F69", Offset = "0x6F69", VA = "0x6F69")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001DEC RID: 7660 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000570")]
		public ThemeDuelStateModel StateModel
		{
			[Token(Token = "0x6001DEC")]
			[Address(RVA = "0x6F6A", Offset = "0x6F6A", VA = "0x6F6A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DED")]
		[Address(RVA = "0x6F6B", Offset = "0x6F6B", VA = "0x6F6B")]
		public ThemeDuelModel(UserData user, IGame game)
		{
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001DEE RID: 7662 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001DEF RID: 7663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000571")]
		public ProtoGetGreatTopAns GreatTop
		{
			[Token(Token = "0x6001DEE")]
			[Address(RVA = "0x6F6C", Offset = "0x6F6C", VA = "0x6F6C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DEF")]
			[Address(RVA = "0x6F6D", Offset = "0x6F6D", VA = "0x6F6D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000572")]
		public Dictionary<ulong, GreatUserData> GreatUsers
		{
			[Token(Token = "0x6001DF0")]
			[Address(RVA = "0x6F6E", Offset = "0x6F6E", VA = "0x6F6E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DF1")]
			[Address(RVA = "0x6F6F", Offset = "0x6F6F", VA = "0x6F6F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000573")]
		public RatingPrizeDic[] Prizes
		{
			[Token(Token = "0x6001DF2")]
			[Address(RVA = "0x6F70", Offset = "0x6F70", VA = "0x6F70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DF3")]
			[Address(RVA = "0x6F71", Offset = "0x6F71", VA = "0x6F71")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001DF4")]
		[Address(RVA = "0x6F72", Offset = "0x6F72", VA = "0x6F72")]
		public TabBarItemData[] GetTabBarItemData()
		{
			return null;
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DF5")]
		[Address(RVA = "0x6F73", Offset = "0x6F73", VA = "0x6F73")]
		public void PopulateGreatTop(ProtoGetGreatTopAns ans)
		{
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DF6")]
		[Address(RVA = "0x6F74", Offset = "0x6F74", VA = "0x6F74")]
		public void PopulateUsers(IList<GreatUserTopInfo> users)
		{
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001DF7")]
		[Address(RVA = "0x6F75", Offset = "0x6F75", VA = "0x6F75")]
		private GreatUserData ConstructGreatUserData(GreatUserTopInfo greatUserInfo)
		{
			return null;
		}

		// Token: 0x0400104A RID: 4170
		[Token(Token = "0x400104A")]
		[FieldOffset(Offset = "0xC")]
		public readonly Dictionaries Dict;
	}
}
