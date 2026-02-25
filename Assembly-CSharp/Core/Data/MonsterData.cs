using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Dict;
using Core.Dict.DictWrappers.Wrappers;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using Protocol.World;
using Utils;

namespace Core.Data
{
	// Token: 0x020010C1 RID: 4289
	[Token(Token = "0x20010C1")]
	public class MonsterData
	{
		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x06006425 RID: 25637 RVA: 0x00012FC0 File Offset: 0x000111C0
		[Token(Token = "0x17001425")]
		public bool HasMonster
		{
			[Token(Token = "0x6006425")]
			[Address(RVA = "0xB019", Offset = "0xB019", VA = "0xB019")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x06006426 RID: 25638 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006427 RID: 25639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001426")]
		public MonsterDic MonsterDic
		{
			[Token(Token = "0x6006426")]
			[Address(RVA = "0xB01A", Offset = "0xB01A", VA = "0xB01A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006427")]
			[Address(RVA = "0xB01B", Offset = "0xB01B", VA = "0xB01B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x06006428 RID: 25640 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006429 RID: 25641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001427")]
		public AprDicWrapper Apr
		{
			[Token(Token = "0x6006428")]
			[Address(RVA = "0xB01C", Offset = "0xB01C", VA = "0xB01C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006429")]
			[Address(RVA = "0xB01D", Offset = "0xB01D", VA = "0xB01D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x0600642A RID: 25642 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600642B RID: 25643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001428")]
		public BackTime Backtime
		{
			[Token(Token = "0x600642A")]
			[Address(RVA = "0xB01E", Offset = "0xB01E", VA = "0xB01E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600642B")]
			[Address(RVA = "0xB01F", Offset = "0xB01F", VA = "0xB01F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x0600642C RID: 25644 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001429")]
		public ResourceSet AttackPrice
		{
			[Token(Token = "0x600642C")]
			[Address(RVA = "0xB020", Offset = "0xB020", VA = "0xB020")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x0600642D RID: 25645 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700142A")]
		public ResourceSet KickPrice
		{
			[Token(Token = "0x600642D")]
			[Address(RVA = "0xB021", Offset = "0xB021", VA = "0xB021")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x0600642E RID: 25646 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700142B")]
		public string Title
		{
			[Token(Token = "0x600642E")]
			[Address(RVA = "0xB022", Offset = "0xB022", VA = "0xB022")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x0600642F RID: 25647 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700142C")]
		public string Description
		{
			[Token(Token = "0x600642F")]
			[Address(RVA = "0xB023", Offset = "0xB023", VA = "0xB023")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x06006430 RID: 25648 RVA: 0x00012FD8 File Offset: 0x000111D8
		[Token(Token = "0x1700142D")]
		public uint Level
		{
			[Token(Token = "0x6006430")]
			[Address(RVA = "0xB024", Offset = "0xB024", VA = "0xB024")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06006431 RID: 25649 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006431")]
		[Address(RVA = "0xB025", Offset = "0xB025", VA = "0xB025")]
		public RewardData[] GetRewards(UserData user, Dictionaries dictionaries)
		{
			return null;
		}

		// Token: 0x06006432 RID: 25650 RVA: 0x00012FF0 File Offset: 0x000111F0
		[Token(Token = "0x6006432")]
		[Address(RVA = "0xB026", Offset = "0xB026", VA = "0xB026")]
		private bool TryGetArtikulRewards(UserData user, Dictionaries dictionaries, out RewardInfo[] rewards)
		{
			return default(bool);
		}

		// Token: 0x06006433 RID: 25651 RVA: 0x00013008 File Offset: 0x00011208
		[Token(Token = "0x6006433")]
		[Address(RVA = "0xB027", Offset = "0xB027", VA = "0xB027")]
		private bool TryGetExpRewards(UserData user, Dictionaries dictionaries, out RewardInfo rewards)
		{
			return default(bool);
		}

		// Token: 0x06006434 RID: 25652 RVA: 0x00013020 File Offset: 0x00011220
		[Token(Token = "0x6006434")]
		[Address(RVA = "0xB028", Offset = "0xB028", VA = "0xB028")]
		private bool TryGetResourceRewards(UserData user, Dictionaries dictionaries, out RewardInfo rewards)
		{
			return default(bool);
		}

		// Token: 0x06006435 RID: 25653 RVA: 0x00013038 File Offset: 0x00011238
		[Token(Token = "0x6006435")]
		[Address(RVA = "0xB029", Offset = "0xB029", VA = "0xB029")]
		private bool TryGetRatingRewards(UserData user, Dictionaries dictionaries, out RewardInfo rewards)
		{
			return default(bool);
		}

		// Token: 0x06006436 RID: 25654 RVA: 0x00013050 File Offset: 0x00011250
		[Token(Token = "0x6006436")]
		[Address(RVA = "0xB02A", Offset = "0xB02A", VA = "0xB02A")]
		public int GetDifficulty(UserData user)
		{
			return 0;
		}

		// Token: 0x06006437 RID: 25655 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006437")]
		[Address(RVA = "0xB02B", Offset = "0xB02B", VA = "0xB02B")]
		public string GetDifficultyLocaleKey(UserData user)
		{
			return null;
		}

		// Token: 0x06006438 RID: 25656 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006438")]
		[Address(RVA = "0xB02C", Offset = "0xB02C", VA = "0xB02C")]
		public static MonsterData Create(MonsterInfo monsterInfo, IDictProvider dictionaries)
		{
			return null;
		}

		// Token: 0x06006439 RID: 25657 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006439")]
		[Address(RVA = "0xB02D", Offset = "0xB02D", VA = "0xB02D")]
		public static MonsterData Create(uint monsterId, IList<ArtikulStackSize> artikuls, IDictProvider dictionaries)
		{
			return null;
		}

		// Token: 0x0600643A RID: 25658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600643A")]
		[Address(RVA = "0xB02E", Offset = "0xB02E", VA = "0xB02E")]
		public MonsterData()
		{
		}

		// Token: 0x04003585 RID: 13701
		[Token(Token = "0x4003585")]
		[FieldOffset(Offset = "0x0")]
		public static readonly List<ValueTuple<int, string>> DIFFICULTY_KEYS;

		// Token: 0x04003589 RID: 13705
		[Token(Token = "0x4003589")]
		[FieldOffset(Offset = "0x14")]
		private IList<ArtikulStackSize> _artikulRewards;
	}
}
