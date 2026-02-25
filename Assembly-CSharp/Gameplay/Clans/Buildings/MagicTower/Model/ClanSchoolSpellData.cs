using System;
using Core.Data.Balance;
using Gameplay.School.Model;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;

namespace Gameplay.Clans.Buildings.MagicTower.Model
{
	// Token: 0x02000AB5 RID: 2741
	[Token(Token = "0x2000AB5")]
	public class ClanSchoolSpellData : SchoolSpellData
	{
		// Token: 0x06004225 RID: 16933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004225")]
		[Address(RVA = "0x90D9", Offset = "0x90D9", VA = "0x90D9")]
		public ClanSchoolSpellData(ShortSpellInfo shortSpellInfo, IBalanceSource treasury, Dictionaries dict)
		{
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x06004226 RID: 16934 RVA: 0x0000CA68 File Offset: 0x0000AC68
		[Token(Token = "0x17000D07")]
		public override double PriceCoef
		{
			[Token(Token = "0x6004226")]
			[Address(RVA = "0x90DA", Offset = "0x90DA", VA = "0x90DA", Slot = "11")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06004227 RID: 16935 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D08")]
		public override ResourceSet LearnPrice
		{
			[Token(Token = "0x6004227")]
			[Address(RVA = "0x90DB", Offset = "0x90DB", VA = "0x90DB", Slot = "10")]
			get
			{
				return null;
			}
		}
	}
}
