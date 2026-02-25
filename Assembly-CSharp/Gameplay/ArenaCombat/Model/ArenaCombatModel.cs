using System;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using Gameplay.Accounts.Model.Data;
using Gameplay.Combat.Factories;
using Gameplay.Combat.Model;
using Gameplay.Isles.User;
using Gameplay.Sound.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Combat;
using Protocol.Common;
using Utils;

namespace Gameplay.ArenaCombat.Model
{
	// Token: 0x02000D47 RID: 3399
	[Token(Token = "0x2000D47")]
	public class ArenaCombatModel : CombatModel
	{
		// Token: 0x06005342 RID: 21314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005342")]
		[Address(RVA = "0xA101", Offset = "0xA101", VA = "0xA101", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06005343 RID: 21315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005343")]
		[Address(RVA = "0xA102", Offset = "0xA102", VA = "0xA102")]
		public ArenaCombatModel(CombatDependencies dependencies, BackTime awaitBackTime, UserData loggedUser, UserData user)
		{
		}

		// Token: 0x06005344 RID: 21316 RVA: 0x0000F0D8 File Offset: 0x0000D2D8
		[Token(Token = "0x6005344")]
		[Address(RVA = "0xA103", Offset = "0xA103", VA = "0xA103", Slot = "11")]
		public override PlayLists GetPlayList()
		{
			return PlayLists.UNKNOWN;
		}

		// Token: 0x06005345 RID: 21317 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005345")]
		[Address(RVA = "0xA104", Offset = "0xA104", VA = "0xA104", Slot = "12")]
		public override ResourceSet GetNextCombatCost()
		{
			return null;
		}

		// Token: 0x06005346 RID: 21318 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005346")]
		[Address(RVA = "0xA105", Offset = "0xA105", VA = "0xA105", Slot = "9")]
		protected override CombatPlayer CreatePlayer(ICombatPlayerFactory playerFactory, ICombatSpellDataFactory spellFactory, IUserCache userCache, PlayerInfo playerInfo)
		{
			return null;
		}

		// Token: 0x06005347 RID: 21319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005347")]
		[Address(RVA = "0xA106", Offset = "0xA106", VA = "0xA106")]
		public void FillEffectIndexes(CombatPlayer player)
		{
		}

		// Token: 0x04002D1F RID: 11551
		[Token(Token = "0x4002D1F")]
		[FieldOffset(Offset = "0x5C")]
		public ArenaCombatModel.AttackRequestedMonster RequestedMonster;

		// Token: 0x04002D20 RID: 11552
		[Token(Token = "0x4002D20")]
		[FieldOffset(Offset = "0x60")]
		public ArenaCombatModel.ArenaCombatRequested RequestedArena;

		// Token: 0x02000D48 RID: 3400
		[Token(Token = "0x2000D48")]
		public class AttackRequestedMonster
		{
			// Token: 0x170010EA RID: 4330
			// (get) Token: 0x06005348 RID: 21320 RVA: 0x0000F0F0 File Offset: 0x0000D2F0
			[Token(Token = "0x170010EA")]
			public ulong OwnerId
			{
				[Token(Token = "0x6005348")]
				[Address(RVA = "0xA107", Offset = "0xA107", VA = "0xA107")]
				get
				{
					return 0UL;
				}
			}

			// Token: 0x170010EB RID: 4331
			// (get) Token: 0x06005349 RID: 21321 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170010EB")]
			[CanBeNull]
			public virtual MonsterData Monster
			{
				[Token(Token = "0x6005349")]
				[Address(RVA = "0xA108", Offset = "0xA108", VA = "0xA108", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170010EC RID: 4332
			// (get) Token: 0x0600534A RID: 21322 RVA: 0x0000F108 File Offset: 0x0000D308
			[Token(Token = "0x170010EC")]
			public bool FromCave
			{
				[Token(Token = "0x600534A")]
				[Address(RVA = "0xA109", Offset = "0xA109", VA = "0xA109")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600534B RID: 21323 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600534B")]
			[Address(RVA = "0xA10A", Offset = "0xA10A", VA = "0xA10A")]
			public AttackRequestedMonster([NotNull] IMonsterSource source)
			{
			}

			// Token: 0x0600534C RID: 21324 RVA: 0x0000F120 File Offset: 0x0000D320
			[Token(Token = "0x600534C")]
			[Address(RVA = "0xA10B", Offset = "0xA10B", VA = "0xA10B", Slot = "5")]
			public virtual bool IsMonsterExist()
			{
				return default(bool);
			}

			// Token: 0x0600534D RID: 21325 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600534D")]
			[Address(RVA = "0xA10C", Offset = "0xA10C", VA = "0xA10C", Slot = "6")]
			public virtual ResourceSet GetStartMonsterAttackCost(BattleAccount account)
			{
				return null;
			}

			// Token: 0x0600534E RID: 21326 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600534E")]
			[Address(RVA = "0xA10D", Offset = "0xA10D", VA = "0xA10D", Slot = "7")]
			public virtual ResourceSet GetResumeMonsterAttackCost(BattleAccount account)
			{
				return null;
			}

			// Token: 0x04002D22 RID: 11554
			[Token(Token = "0x4002D22")]
			[FieldOffset(Offset = "0xC")]
			private IMonsterSource _source;
		}

		// Token: 0x02000D49 RID: 3401
		[Token(Token = "0x2000D49")]
		public class ArenaCombatRequested
		{
			// Token: 0x0600534F RID: 21327 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600534F")]
			[Address(RVA = "0xA10E", Offset = "0xA10E", VA = "0xA10E")]
			public ArenaCombatRequested()
			{
			}

			// Token: 0x04002D23 RID: 11555
			[Token(Token = "0x4002D23")]
			[FieldOffset(Offset = "0x8")]
			public ProtoRequestCombatCmd.Types.ArenaCombatTypes RequestedCombatType;

			// Token: 0x04002D24 RID: 11556
			[Token(Token = "0x4002D24")]
			[FieldOffset(Offset = "0xC")]
			public bool FromArena;
		}
	}
}
