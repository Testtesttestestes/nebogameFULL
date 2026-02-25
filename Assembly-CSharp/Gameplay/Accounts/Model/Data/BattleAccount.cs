using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Accounts;
using Gameplay.ThemeDuelState.Model;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;

namespace Gameplay.Accounts.Model.Data
{
	// Token: 0x02000DDC RID: 3548
	[Token(Token = "0x2000DDC")]
	public class BattleAccount : UserAccount
	{
		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x06005697 RID: 22167 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005698 RID: 22168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011AC")]
		public BattleAccountCoefs BattleAccountCoeffs
		{
			[Token(Token = "0x6005697")]
			[Address(RVA = "0xA41F", Offset = "0xA41F", VA = "0xA41F")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005698")]
			[Address(RVA = "0xA420", Offset = "0xA420", VA = "0xA420")]
			set
			{
			}
		}

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x06005699 RID: 22169 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011AD")]
		public static BattleAccountCoefs BattleAccountCoeffsOneValue
		{
			[Token(Token = "0x6005699")]
			[Address(RVA = "0xA421", Offset = "0xA421", VA = "0xA421")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600569A RID: 22170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600569A")]
		[Address(RVA = "0xA422", Offset = "0xA422", VA = "0xA422", Slot = "19")]
		public override void Init(uint id, Dictionaries dicts, IAccountRepository accountRepository)
		{
		}

		// Token: 0x0600569B RID: 22171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600569B")]
		[Address(RVA = "0xA423", Offset = "0xA423", VA = "0xA423")]
		public ResourceSet GetArenaEqualCost(UserData user)
		{
			return null;
		}

		// Token: 0x0600569C RID: 22172 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600569C")]
		[Address(RVA = "0xA424", Offset = "0xA424", VA = "0xA424")]
		public ResourceSet GetArenaLevelCost(UserData user)
		{
			return null;
		}

		// Token: 0x0600569D RID: 22173 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600569D")]
		[Address(RVA = "0xA425", Offset = "0xA425", VA = "0xA425")]
		public ResourceSet GetMonsterAttackCost(MonsterDic monsterDic)
		{
			return null;
		}

		// Token: 0x0600569E RID: 22174 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600569E")]
		[Address(RVA = "0xA426", Offset = "0xA426", VA = "0xA426")]
		public ResourceSet GetMonsterAttackCost(MonsterHordesDic monsterHordeDic)
		{
			return null;
		}

		// Token: 0x0600569F RID: 22175 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600569F")]
		[Address(RVA = "0xA427", Offset = "0xA427", VA = "0xA427")]
		public ResourceSet GetMonsterKickCost(MonsterDic monsterDic)
		{
			return null;
		}

		// Token: 0x060056A0 RID: 22176 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60056A0")]
		[Address(RVA = "0xA428", Offset = "0xA428", VA = "0xA428")]
		public ResourceSet GetPartyCombatCost(UserData user)
		{
			return null;
		}

		// Token: 0x060056A1 RID: 22177 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60056A1")]
		[Address(RVA = "0xA429", Offset = "0xA429", VA = "0xA429")]
		public ResourceSet GetThemeDuelCombatPrice(ThemeDuelStateModel themeDuelStateModel)
		{
			return null;
		}

		// Token: 0x060056A2 RID: 22178 RVA: 0x0000F900 File Offset: 0x0000DB00
		[Token(Token = "0x60056A2")]
		[Address(RVA = "0xA42A", Offset = "0xA42A", VA = "0xA42A")]
		public uint GetTurnTimeout(UserData user)
		{
			return 0U;
		}

		// Token: 0x060056A3 RID: 22179 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60056A3")]
		[Address(RVA = "0xA42B", Offset = "0xA42B", VA = "0xA42B")]
		public ResourceSet GetCaveVisitPrice(CaveLevelDic caveLevelDic)
		{
			return null;
		}

		// Token: 0x060056A4 RID: 22180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056A4")]
		[Address(RVA = "0xA42C", Offset = "0xA42C", VA = "0xA42C")]
		public BattleAccount()
		{
		}

		// Token: 0x04002EF6 RID: 12022
		[Token(Token = "0x4002EF6")]
		[FieldOffset(Offset = "0x1C")]
		private BattleAccountCoefs _battleAccountCoeffs;
	}
}
