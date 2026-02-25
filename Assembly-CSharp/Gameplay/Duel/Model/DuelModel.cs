using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Skills;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Duel;
using Utils;

namespace Gameplay.Duel.Model
{
	// Token: 0x02000860 RID: 2144
	[Token(Token = "0x2000860")]
	public class DuelModel : AbstractModel
	{
		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06003257 RID: 12887 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003258 RID: 12888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F0")]
		public DuelModel.DuelUserData Player
		{
			[Token(Token = "0x6003257")]
			[Address(RVA = "0x82AC", Offset = "0x82AC", VA = "0x82AC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003258")]
			[Address(RVA = "0x82AD", Offset = "0x82AD", VA = "0x82AD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06003259 RID: 12889 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600325A RID: 12890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F1")]
		public DuelModel.DuelUserData Opponent
		{
			[Token(Token = "0x6003259")]
			[Address(RVA = "0x82AE", Offset = "0x82AE", VA = "0x82AE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600325A")]
			[Address(RVA = "0x82AF", Offset = "0x82AF", VA = "0x82AF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x0600325B RID: 12891 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600325C RID: 12892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F2")]
		public DuelModel.DuelData CurrentDuel
		{
			[Token(Token = "0x600325B")]
			[Address(RVA = "0x82B0", Offset = "0x82B0", VA = "0x82B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600325C")]
			[Address(RVA = "0x82B1", Offset = "0x82B1", VA = "0x82B1")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x0600325D RID: 12893 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600325E RID: 12894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F3")]
		public BackTime Backtimer
		{
			[Token(Token = "0x600325D")]
			[Address(RVA = "0x82B2", Offset = "0x82B2", VA = "0x82B2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600325E")]
			[Address(RVA = "0x82B3", Offset = "0x82B3", VA = "0x82B3")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x0600325F RID: 12895 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003260 RID: 12896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F4")]
		public RequirementDic RequirementDic
		{
			[Token(Token = "0x600325F")]
			[Address(RVA = "0x82B4", Offset = "0x82B4", VA = "0x82B4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003260")]
			[Address(RVA = "0x82B5", Offset = "0x82B5", VA = "0x82B5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003261")]
		[Address(RVA = "0x82B6", Offset = "0x82B6", VA = "0x82B6")]
		public DuelModel(UserData user)
		{
		}

		// Token: 0x06003262 RID: 12898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003262")]
		[Address(RVA = "0x82B7", Offset = "0x82B7", VA = "0x82B7")]
		public void SetOpponent(UserData opponent)
		{
		}

		// Token: 0x06003263 RID: 12899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003263")]
		[Address(RVA = "0x82B8", Offset = "0x82B8", VA = "0x82B8")]
		public void CreateDuel(ProtoGetDuelsInfoAns.Types.DuelInfo info)
		{
		}

		// Token: 0x04001B9A RID: 7066
		[Token(Token = "0x4001B9A")]
		[FieldOffset(Offset = "0xC")]
		public readonly Dictionaries Dict;

		// Token: 0x02000861 RID: 2145
		[Token(Token = "0x2000861")]
		public class DuelUserData
		{
			// Token: 0x170009F5 RID: 2549
			// (get) Token: 0x06003264 RID: 12900 RVA: 0x0000A428 File Offset: 0x00008628
			[Token(Token = "0x170009F5")]
			public ulong UserId
			{
				[Token(Token = "0x6003264")]
				[Address(RVA = "0x82B9", Offset = "0x82B9", VA = "0x82B9")]
				get
				{
					return 0UL;
				}
			}

			// Token: 0x06003265 RID: 12901 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003265")]
			[Address(RVA = "0x82BA", Offset = "0x82BA", VA = "0x82BA")]
			public DuelUserData()
			{
			}

			// Token: 0x04001BA0 RID: 7072
			[Token(Token = "0x4001BA0")]
			[FieldOffset(Offset = "0x8")]
			public UserData Data;

			// Token: 0x04001BA1 RID: 7073
			[Token(Token = "0x4001BA1")]
			[FieldOffset(Offset = "0xC")]
			public SkillCollection Skills;

			// Token: 0x04001BA2 RID: 7074
			[Token(Token = "0x4001BA2")]
			[FieldOffset(Offset = "0x10")]
			public DuelUserInfo DuelUserUnfo;
		}

		// Token: 0x02000862 RID: 2146
		[Token(Token = "0x2000862")]
		public class DuelData
		{
			// Token: 0x06003266 RID: 12902 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003266")]
			[Address(RVA = "0x82BB", Offset = "0x82BB", VA = "0x82BB")]
			public DuelData()
			{
			}

			// Token: 0x04001BA3 RID: 7075
			[Token(Token = "0x4001BA3")]
			[FieldOffset(Offset = "0x8")]
			public DuelTypesDict DuelTypeDic;

			// Token: 0x04001BA4 RID: 7076
			[Token(Token = "0x4001BA4")]
			[FieldOffset(Offset = "0xC")]
			public ProtoGetDuelsInfoAns.Types.DuelInfo DuelInfo;
		}
	}
}
