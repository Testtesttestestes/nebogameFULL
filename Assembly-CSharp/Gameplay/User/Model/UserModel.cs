using System;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using Core.Gameplay;
using Il2CppDummyDll;
using MVC;
using Protocol.Auth;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Craft;
using Protocol.Dic;
using Utils;

namespace Gameplay.User.Model
{
	// Token: 0x0200041F RID: 1055
	[Token(Token = "0x200041F")]
	public class UserModel : AbstractModel
	{
		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060018EC RID: 6380 RVA: 0x000057A8 File Offset: 0x000039A8
		[Token(Token = "0x1700045E")]
		public int PremiumExpMinLevel
		{
			[Token(Token = "0x60018EC")]
			[Address(RVA = "0x6A8B", Offset = "0x6A8B", VA = "0x6A8B")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700045F")]
		public ResourceSet TreeLicencePrice
		{
			[Token(Token = "0x60018ED")]
			[Address(RVA = "0x6A8C", Offset = "0x6A8C", VA = "0x6A8C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060018EE RID: 6382 RVA: 0x000057C0 File Offset: 0x000039C0
		// (set) Token: 0x060018EF RID: 6383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000460")]
		public ulong RequestedClanId
		{
			[Token(Token = "0x60018EE")]
			[Address(RVA = "0x6A8D", Offset = "0x6A8D", VA = "0x6A8D")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60018EF")]
			[Address(RVA = "0x6A8E", Offset = "0x6A8E", VA = "0x6A8E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060018F0 RID: 6384 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000461")]
		public Cults[] AvailableCults
		{
			[Token(Token = "0x60018F0")]
			[Address(RVA = "0x6A8F", Offset = "0x6A8F", VA = "0x6A8F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060018F1 RID: 6385 RVA: 0x000057D8 File Offset: 0x000039D8
		[Token(Token = "0x17000462")]
		public float ExperienceProgress
		{
			[Token(Token = "0x60018F1")]
			[Address(RVA = "0x6A90", Offset = "0x6A90", VA = "0x6A90")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060018F2 RID: 6386 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000463")]
		public UserLevelDic NextUserLevelDic
		{
			[Token(Token = "0x60018F2")]
			[Address(RVA = "0x6A91", Offset = "0x6A91", VA = "0x6A91")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060018F4 RID: 6388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000464")]
		public EnergyRegenStatus CurrentEnergyRegenStatus
		{
			[Token(Token = "0x60018F3")]
			[Address(RVA = "0x6A92", Offset = "0x6A92", VA = "0x6A92")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018F4")]
			[Address(RVA = "0x6A93", Offset = "0x6A93", VA = "0x6A93")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060018F6 RID: 6390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000465")]
		public UserProfession Profession
		{
			[Token(Token = "0x60018F5")]
			[Address(RVA = "0x6A94", Offset = "0x6A94", VA = "0x6A94")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018F6")]
			[Address(RVA = "0x6A95", Offset = "0x6A95", VA = "0x6A95")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060018F8 RID: 6392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000466")]
		public BanInfo BanInfo
		{
			[Token(Token = "0x60018F7")]
			[Address(RVA = "0x6A96", Offset = "0x6A96", VA = "0x6A96")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018F8")]
			[Address(RVA = "0x6A97", Offset = "0x6A97", VA = "0x6A97")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060018F9 RID: 6393 RVA: 0x000057F0 File Offset: 0x000039F0
		[Token(Token = "0x17000467")]
		public double EnergyRecoveryStep
		{
			[Token(Token = "0x60018F9")]
			[Address(RVA = "0x6A98", Offset = "0x6A98", VA = "0x6A98")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060018FB RID: 6395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000468")]
		public IGame Game
		{
			[Token(Token = "0x60018FA")]
			[Address(RVA = "0x6A99", Offset = "0x6A99", VA = "0x6A99")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018FB")]
			[Address(RVA = "0x6A9A", Offset = "0x6A9A", VA = "0x6A9A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018FC")]
		[Address(RVA = "0x6A9B", Offset = "0x6A9B", VA = "0x6A9B", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018FD")]
		[Address(RVA = "0x6A9C", Offset = "0x6A9C", VA = "0x6A9C")]
		public UserModel(IGame game, IUserCache userCache, LocalProps localProps, uint energyRecoveryIncrementInterval, double energyRecoveryIncrementPercentPerInterval, UserData user)
		{
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018FE")]
		[Address(RVA = "0x6A9D", Offset = "0x6A9D", VA = "0x6A9D")]
		public void SetUserProfession(UserProfession profession)
		{
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018FF")]
		[Address(RVA = "0x6A9E", Offset = "0x6A9E", VA = "0x6A9E")]
		public void SetBanInfo(BanInfo banInfo)
		{
		}

		// Token: 0x04000D2D RID: 3373
		[Token(Token = "0x4000D2D")]
		[FieldOffset(Offset = "0x18")]
		private UserLevelDic _nextUserLevelDic;

		// Token: 0x04000D31 RID: 3377
		[Token(Token = "0x4000D31")]
		[FieldOffset(Offset = "0x28")]
		public readonly uint EnergyRecoveryIncrementInterval;

		// Token: 0x04000D32 RID: 3378
		[Token(Token = "0x4000D32")]
		[FieldOffset(Offset = "0x30")]
		public readonly double EnergyRecoveryIncrementPercentPerInterval;

		// Token: 0x04000D33 RID: 3379
		[Token(Token = "0x4000D33")]
		[FieldOffset(Offset = "0x38")]
		public readonly IUserCache UserCache;

		// Token: 0x04000D34 RID: 3380
		[Token(Token = "0x4000D34")]
		[FieldOffset(Offset = "0x3C")]
		public readonly LocalProps LocalProps;
	}
}
