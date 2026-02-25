using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Dict.DictWrappers.Wrappers;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Portal;

namespace Gameplay.Portals.Model
{
	// Token: 0x020005CE RID: 1486
	[Token(Token = "0x20005CE")]
	public class PortalMonsterData
	{
		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06002392 RID: 9106 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002393 RID: 9107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A1")]
		public MonsterDic MonsterDic
		{
			[Token(Token = "0x6002392")]
			[Address(RVA = "0x74E4", Offset = "0x74E4", VA = "0x74E4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002393")]
			[Address(RVA = "0x74E5", Offset = "0x74E5", VA = "0x74E5")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06002394 RID: 9108 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002395 RID: 9109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A2")]
		public AprDicWrapper Apr
		{
			[Token(Token = "0x6002394")]
			[Address(RVA = "0x74E6", Offset = "0x74E6", VA = "0x74E6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002395")]
			[Address(RVA = "0x74E7", Offset = "0x74E7", VA = "0x74E7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06002396 RID: 9110 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002397 RID: 9111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A3")]
		public PortalMonsterInfo MonsterInfo
		{
			[Token(Token = "0x6002396")]
			[Address(RVA = "0x74E8", Offset = "0x74E8", VA = "0x74E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002397")]
			[Address(RVA = "0x74E9", Offset = "0x74E9", VA = "0x74E9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06002398 RID: 9112 RVA: 0x00006E58 File Offset: 0x00005058
		// (set) Token: 0x06002399 RID: 9113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A4")]
		public uint DropChance
		{
			[Token(Token = "0x6002398")]
			[Address(RVA = "0x74EA", Offset = "0x74EA", VA = "0x74EA")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002399")]
			[Address(RVA = "0x74EB", Offset = "0x74EB", VA = "0x74EB")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600239A")]
		[Address(RVA = "0x74EC", Offset = "0x74EC", VA = "0x74EC")]
		public static PortalMonsterData Create(PortalMonsterInfo monsterInfo, IDictProvider dictionaries, uint dropChance)
		{
			return null;
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600239B")]
		[Address(RVA = "0x74ED", Offset = "0x74ED", VA = "0x74ED")]
		public RewardData[] GetRewards(UserData user, Dictionaries dictionaries)
		{
			return null;
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x00006E70 File Offset: 0x00005070
		[Token(Token = "0x600239C")]
		[Address(RVA = "0x74EE", Offset = "0x74EE", VA = "0x74EE")]
		private bool TryGetPortalCurrencyRewards(UserData user, Dictionaries dictionaries, out RewardInfo rewards)
		{
			return default(bool);
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x00006E88 File Offset: 0x00005088
		[Token(Token = "0x600239D")]
		[Address(RVA = "0x74EF", Offset = "0x74EF", VA = "0x74EF")]
		private bool TryGetExpRewards(UserData user, Dictionaries dictionaries, out RewardInfo rewards)
		{
			return default(bool);
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x00006EA0 File Offset: 0x000050A0
		[Token(Token = "0x600239E")]
		[Address(RVA = "0x74F0", Offset = "0x74F0", VA = "0x74F0")]
		private bool TryGetRatingRewards(UserData user, Dictionaries dictionaries, out RewardInfo rewards)
		{
			return default(bool);
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600239F")]
		[Address(RVA = "0x74F1", Offset = "0x74F1", VA = "0x74F1")]
		public PortalMonsterData()
		{
		}
	}
}
