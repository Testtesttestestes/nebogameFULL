using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using Core.Gameplay.Managers.Requirements;
using Gameplay.Clans.ClanWars;
using Gameplay.Combat.Factories;
using Gameplay.Combat.Model;
using Gameplay.Combat.TeamCombat.Model;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Common;
using Protocol.Dic;
using Utils;

namespace Gameplay.Clans.Combat.Model
{
	// Token: 0x02000A9C RID: 2716
	[Token(Token = "0x2000A9C")]
	public class ClanCombatModel : TeamCombatModel
	{
		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06004152 RID: 16722 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004153 RID: 16723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE3")]
		public IClanWars ClanWars
		{
			[Token(Token = "0x6004152")]
			[Address(RVA = "0x9009", Offset = "0x9009", VA = "0x9009")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004153")]
			[Address(RVA = "0x900A", Offset = "0x900A", VA = "0x900A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06004154 RID: 16724 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		// (set) Token: 0x06004155 RID: 16725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE4")]
		public bool IsViewMode
		{
			[Token(Token = "0x6004154")]
			[Address(RVA = "0x900B", Offset = "0x900B", VA = "0x900B")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004155")]
			[Address(RVA = "0x900C", Offset = "0x900C", VA = "0x900C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06004156 RID: 16726 RVA: 0x0000C900 File Offset: 0x0000AB00
		// (set) Token: 0x06004157 RID: 16727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE5")]
		public bool IsJoinProcess
		{
			[Token(Token = "0x6004156")]
			[Address(RVA = "0x900D", Offset = "0x900D", VA = "0x900D")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004157")]
			[Address(RVA = "0x900E", Offset = "0x900E", VA = "0x900E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x06004158 RID: 16728 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004159 RID: 16729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE6")]
		public RequirementsManager RequirementsManager
		{
			[Token(Token = "0x6004158")]
			[Address(RVA = "0x900F", Offset = "0x900F", VA = "0x900F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004159")]
			[Address(RVA = "0x9010", Offset = "0x9010", VA = "0x9010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x0600415A RID: 16730 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CE7")]
		public override CombatPlayer MyPlayer
		{
			[Token(Token = "0x600415A")]
			[Address(RVA = "0x9011", Offset = "0x9011", VA = "0x9011", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x0600415B RID: 16731 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600415C RID: 16732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE8")]
		public ClanCombatPlayer EnemyGolem
		{
			[Token(Token = "0x600415B")]
			[Address(RVA = "0x9012", Offset = "0x9012", VA = "0x9012")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600415C")]
			[Address(RVA = "0x9013", Offset = "0x9013", VA = "0x9013")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x0600415D RID: 16733 RVA: 0x0000C918 File Offset: 0x0000AB18
		[Token(Token = "0x17000CE9")]
		public bool JoinAvail
		{
			[Token(Token = "0x600415D")]
			[Address(RVA = "0x9014", Offset = "0x9014", VA = "0x9014")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x0600415E RID: 16734 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600415F RID: 16735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CEA")]
		public BackTime GlobalTimeout
		{
			[Token(Token = "0x600415E")]
			[Address(RVA = "0x9015", Offset = "0x9015", VA = "0x9015")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600415F")]
			[Address(RVA = "0x9016", Offset = "0x9016", VA = "0x9016")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004160 RID: 16736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004160")]
		[Address(RVA = "0x9017", Offset = "0x9017", VA = "0x9017", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06004161 RID: 16737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004161")]
		[Address(RVA = "0x9018", Offset = "0x9018", VA = "0x9018")]
		public ClanCombatModel(CombatDependencies dependencies, uint jointRequirementId, RequirementsManager requirementsManager, BackTime awaitBackTime, UserData loggedUser, UserData user)
		{
		}

		// Token: 0x06004162 RID: 16738 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004162")]
		[Address(RVA = "0x9019", Offset = "0x9019", VA = "0x9019")]
		private LinkedList<CombatPlayer> GetPlayerList(uint userSide)
		{
			return null;
		}

		// Token: 0x06004163 RID: 16739 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004163")]
		[Address(RVA = "0x901A", Offset = "0x901A", VA = "0x901A", Slot = "9")]
		protected override CombatPlayer CreatePlayer(ICombatPlayerFactory playerFactory, ICombatSpellDataFactory spellFactory, IUserCache userCache, PlayerInfo playerInfo)
		{
			return null;
		}

		// Token: 0x06004164 RID: 16740 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004164")]
		[Address(RVA = "0x901B", Offset = "0x901B", VA = "0x901B", Slot = "15")]
		public override CombatPlayer AddPlayer(PlayerInfo playerInfo)
		{
			return null;
		}

		// Token: 0x06004165 RID: 16741 RVA: 0x0000C930 File Offset: 0x0000AB30
		[Token(Token = "0x6004165")]
		[Address(RVA = "0x901C", Offset = "0x901C", VA = "0x901C", Slot = "16")]
		public override bool RemovePlayer(ulong userId, out CombatPlayer player)
		{
			return default(bool);
		}

		// Token: 0x06004166 RID: 16742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004166")]
		[Address(RVA = "0x901D", Offset = "0x901D", VA = "0x901D")]
		public void MovePlayers(out List<CombatPlayer> downPlayers)
		{
		}

		// Token: 0x06004167 RID: 16743 RVA: 0x0000C948 File Offset: 0x0000AB48
		[Token(Token = "0x6004167")]
		[Address(RVA = "0x901E", Offset = "0x901E", VA = "0x901E")]
		public int GetPlayerCount(CombatPlayer player)
		{
			return 0;
		}

		// Token: 0x06004168 RID: 16744 RVA: 0x0000C960 File Offset: 0x0000AB60
		[Token(Token = "0x6004168")]
		[Address(RVA = "0x901F", Offset = "0x901F", VA = "0x901F")]
		public bool TryGetCurrentPlayers(out CombatPlayer[] players)
		{
			return default(bool);
		}

		// Token: 0x06004169 RID: 16745 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004169")]
		[Address(RVA = "0x9020", Offset = "0x9020", VA = "0x9020", Slot = "17")]
		public override List<CombatPlayer> GetTeamPlayersContains(uint userSide)
		{
			return null;
		}

		// Token: 0x0600416A RID: 16746 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600416A")]
		[Address(RVA = "0x9021", Offset = "0x9021", VA = "0x9021", Slot = "18")]
		public override List<CombatPlayer> GetTeamPlayersNotContains(uint userSide)
		{
			return null;
		}

		// Token: 0x0600416B RID: 16747 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600416B")]
		[Address(RVA = "0x9022", Offset = "0x9022", VA = "0x9022", Slot = "12")]
		public override ResourceSet GetNextCombatCost()
		{
			return null;
		}

		// Token: 0x0600416C RID: 16748 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600416C")]
		[Address(RVA = "0x9023", Offset = "0x9023", VA = "0x9023", Slot = "13")]
		protected override CombatEventData CreateCombatEventData(CombatEventDic dict)
		{
			return null;
		}

		// Token: 0x0400243B RID: 9275
		[Token(Token = "0x400243B")]
		[FieldOffset(Offset = "0x5C")]
		public readonly uint JointRequirementId;

		// Token: 0x04002440 RID: 9280
		[Token(Token = "0x4002440")]
		[FieldOffset(Offset = "0x6C")]
		private LinkedList<CombatPlayer> _userSideQueue;

		// Token: 0x04002441 RID: 9281
		[Token(Token = "0x4002441")]
		[FieldOffset(Offset = "0x70")]
		private LinkedList<CombatPlayer> _enemiesQueue;

		// Token: 0x04002442 RID: 9282
		[Token(Token = "0x4002442")]
		[FieldOffset(Offset = "0x74")]
		private CombatPlayer[] _currentPlayers;
	}
}
