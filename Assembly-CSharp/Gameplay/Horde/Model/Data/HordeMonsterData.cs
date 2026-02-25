using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Il2CppDummyDll;
using Protocol.Dic;
using Protocol.World;

namespace Gameplay.Horde.Model.Data
{
	// Token: 0x02000700 RID: 1792
	[Token(Token = "0x2000700")]
	public class HordeMonsterData
	{
		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06002AE8 RID: 10984 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002AE9 RID: 10985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000828")]
		public MonsterData MonsterData
		{
			[Token(Token = "0x6002AE8")]
			[Address(RVA = "0x7B83", Offset = "0x7B83", VA = "0x7B83")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AE9")]
			[Address(RVA = "0x7B84", Offset = "0x7B84", VA = "0x7B84")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06002AEA RID: 10986 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002AEB RID: 10987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000829")]
		public MonsterHordesDic HordeMonsterDic
		{
			[Token(Token = "0x6002AEA")]
			[Address(RVA = "0x7B85", Offset = "0x7B85", VA = "0x7B85")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AEB")]
			[Address(RVA = "0x7B86", Offset = "0x7B86", VA = "0x7B86")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002AEC RID: 10988 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002AEC")]
		[Address(RVA = "0x7B87", Offset = "0x7B87", VA = "0x7B87")]
		public static HordeMonsterData Create(MonsterInfo monsterInfo, IDictProvider dict)
		{
			return null;
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002AED")]
		[Address(RVA = "0x7B88", Offset = "0x7B88", VA = "0x7B88")]
		public static HordeMonsterData Create(uint monsterId, IDictProvider dict)
		{
			return null;
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002AEE")]
		[Address(RVA = "0x7B89", Offset = "0x7B89", VA = "0x7B89")]
		public static HordeMonsterData Create(MonsterHordesDic monster, IDictProvider dict)
		{
			return null;
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AEF")]
		[Address(RVA = "0x7B8A", Offset = "0x7B8A", VA = "0x7B8A")]
		public HordeMonsterData()
		{
		}
	}
}
