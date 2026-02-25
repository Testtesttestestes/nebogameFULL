using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using DefaultNamespace;
using Gameplay.Combat.Factories;
using Gameplay.Sound.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Combat;
using Protocol.Common;
using Protocol.Dic;
using Utils;

namespace Gameplay.Combat.Model
{
	// Token: 0x02000993 RID: 2451
	[Token(Token = "0x2000993")]
	public class CombatModel : AbstractModel
	{
		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06003A6C RID: 14956 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		[Token(Token = "0x17000B71")]
		public virtual int SpellSlotsCount
		{
			[Token(Token = "0x6003A6C")]
			[Address(RVA = "0x89E2", Offset = "0x89E2", VA = "0x89E2", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06003A6D RID: 14957 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		[Token(Token = "0x17000B72")]
		public virtual int ElixirsSlotsCount
		{
			[Token(Token = "0x6003A6D")]
			[Address(RVA = "0x89E3", Offset = "0x89E3", VA = "0x89E3", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06003A6E RID: 14958 RVA: 0x0000BA00 File Offset: 0x00009C00
		// (set) Token: 0x06003A6F RID: 14959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B73")]
		public int HandleGameOverCount
		{
			[Token(Token = "0x6003A6E")]
			[Address(RVA = "0x89E4", Offset = "0x89E4", VA = "0x89E4")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003A6F")]
			[Address(RVA = "0x89E5", Offset = "0x89E5", VA = "0x89E5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06003A70 RID: 14960 RVA: 0x0000BA18 File Offset: 0x00009C18
		// (set) Token: 0x06003A71 RID: 14961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B74")]
		public int RewardsGotCount
		{
			[Token(Token = "0x6003A70")]
			[Address(RVA = "0x89E6", Offset = "0x89E6", VA = "0x89E6")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003A71")]
			[Address(RVA = "0x89E7", Offset = "0x89E7", VA = "0x89E7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06003A72 RID: 14962 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B75")]
		public Dictionary<ulong, CombatPlayer> Players
		{
			[Token(Token = "0x6003A72")]
			[Address(RVA = "0x89E8", Offset = "0x89E8", VA = "0x89E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06003A73 RID: 14963 RVA: 0x0000BA30 File Offset: 0x00009C30
		// (set) Token: 0x06003A74 RID: 14964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B76")]
		public bool IsAwaitSwapStonesResponse
		{
			[Token(Token = "0x6003A73")]
			[Address(RVA = "0x89E9", Offset = "0x89E9", VA = "0x89E9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A74")]
			[Address(RVA = "0x89EA", Offset = "0x89EA", VA = "0x89EA")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06003A75 RID: 14965 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B77")]
		public virtual CombatPlayer MyPlayer
		{
			[Token(Token = "0x6003A75")]
			[Address(RVA = "0x89EB", Offset = "0x89EB", VA = "0x89EB", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06003A76 RID: 14966 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003A77 RID: 14967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B78")]
		public CombatSpellData CurrentSelectedSpell
		{
			[Token(Token = "0x6003A76")]
			[Address(RVA = "0x89EC", Offset = "0x89EC", VA = "0x89EC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A77")]
			[Address(RVA = "0x89ED", Offset = "0x89ED", VA = "0x89ED")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06003A78 RID: 14968 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003A79 RID: 14969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B79")]
		public JoinToCombatInfo JoinToCombatInfo
		{
			[Token(Token = "0x6003A78")]
			[Address(RVA = "0x89EE", Offset = "0x89EE", VA = "0x89EE")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A79")]
			[Address(RVA = "0x89EF", Offset = "0x89EF", VA = "0x89EF")]
			set
			{
			}
		}

		// Token: 0x06003A7A RID: 14970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A7A")]
		[Address(RVA = "0x89F0", Offset = "0x89F0", VA = "0x89F0")]
		private void HandleJoinToCombatInfoChanged()
		{
		}

		// Token: 0x06003A7B RID: 14971 RVA: 0x0000BA48 File Offset: 0x00009C48
		[Token(Token = "0x6003A7B")]
		[Address(RVA = "0x89F1", Offset = "0x89F1", VA = "0x89F1")]
		public bool TryGetEventSpell(SpellKey spellKey, out CombatSpellData spell)
		{
			return default(bool);
		}

		// Token: 0x06003A7C RID: 14972 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A7C")]
		[Address(RVA = "0x89F2", Offset = "0x89F2", VA = "0x89F2", Slot = "9")]
		protected virtual CombatPlayer CreatePlayer(ICombatPlayerFactory playerFactory, ICombatSpellDataFactory spellFactory, IUserCache userCache, PlayerInfo playerInfo)
		{
			return null;
		}

		// Token: 0x06003A7D RID: 14973 RVA: 0x0000BA60 File Offset: 0x00009C60
		[Token(Token = "0x6003A7D")]
		[Address(RVA = "0x89F3", Offset = "0x89F3", VA = "0x89F3", Slot = "10")]
		public virtual TurnStates GetTurnState(ulong userId)
		{
			return TurnStates.NoTurn;
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06003A7E RID: 14974 RVA: 0x0000BA78 File Offset: 0x00009C78
		[Token(Token = "0x17000B7A")]
		public bool IsMyTurn
		{
			[Token(Token = "0x6003A7E")]
			[Address(RVA = "0x89F4", Offset = "0x89F4", VA = "0x89F4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003A7F RID: 14975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A7F")]
		[Address(RVA = "0x89F5", Offset = "0x89F5", VA = "0x89F5")]
		private void AppendModsToCache(CombatPlayer player)
		{
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06003A80 RID: 14976 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003A81 RID: 14977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B7B")]
		public CombatDependencies Dependencies
		{
			[Token(Token = "0x6003A80")]
			[Address(RVA = "0x89F6", Offset = "0x89F6", VA = "0x89F6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A81")]
			[Address(RVA = "0x89F7", Offset = "0x89F7", VA = "0x89F7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06003A82 RID: 14978 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003A83 RID: 14979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B7C")]
		public BackTime AwaitCombatBackTime
		{
			[Token(Token = "0x6003A82")]
			[Address(RVA = "0x89F8", Offset = "0x89F8", VA = "0x89F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A83")]
			[Address(RVA = "0x89F9", Offset = "0x89F9", VA = "0x89F9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06003A84 RID: 14980 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003A85 RID: 14981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B7D")]
		public UserData LoggedUser
		{
			[Token(Token = "0x6003A84")]
			[Address(RVA = "0x89FA", Offset = "0x89FA", VA = "0x89FA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A85")]
			[Address(RVA = "0x89FB", Offset = "0x89FB", VA = "0x89FB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06003A86 RID: 14982 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003A87 RID: 14983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B7E")]
		public Dictionary<ulong, ProtoSkillsChangedEvt> ResurrectedUsers
		{
			[Token(Token = "0x6003A86")]
			[Address(RVA = "0x89FC", Offset = "0x89FC", VA = "0x89FC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A87")]
			[Address(RVA = "0x89FD", Offset = "0x89FD", VA = "0x89FD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06003A88 RID: 14984 RVA: 0x0000BA90 File Offset: 0x00009C90
		// (set) Token: 0x06003A89 RID: 14985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B7F")]
		public bool IsFieldCleared
		{
			[Token(Token = "0x6003A88")]
			[Address(RVA = "0x89FE", Offset = "0x89FE", VA = "0x89FE")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A89")]
			[Address(RVA = "0x89FF", Offset = "0x89FF", VA = "0x89FF")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003A8A RID: 14986 RVA: 0x0000BAA8 File Offset: 0x00009CA8
		[Token(Token = "0x6003A8A")]
		[Address(RVA = "0x8A00", Offset = "0x8A00", VA = "0x8A00", Slot = "11")]
		public virtual PlayLists GetPlayList()
		{
			return PlayLists.UNKNOWN;
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A8B")]
		[Address(RVA = "0x8A01", Offset = "0x8A01", VA = "0x8A01", Slot = "12")]
		public virtual ResourceSet GetNextCombatCost()
		{
			return null;
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A8C")]
		[Address(RVA = "0x8A02", Offset = "0x8A02", VA = "0x8A02")]
		public CombatEventData GetCombatEvent(uint id)
		{
			return null;
		}

		// Token: 0x06003A8D RID: 14989 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A8D")]
		[Address(RVA = "0x8A03", Offset = "0x8A03", VA = "0x8A03", Slot = "13")]
		protected virtual CombatEventData CreateCombatEventData(CombatEventDic dict)
		{
			return null;
		}

		// Token: 0x06003A8E RID: 14990 RVA: 0x0000BAC0 File Offset: 0x00009CC0
		[Token(Token = "0x6003A8E")]
		[Address(RVA = "0x8A04", Offset = "0x8A04", VA = "0x8A04", Slot = "14")]
		public virtual bool GetSpellsEnabled(ulong userId)
		{
			return default(bool);
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A8F")]
		[Address(RVA = "0x8A05", Offset = "0x8A05", VA = "0x8A05", Slot = "15")]
		public virtual CombatPlayer AddPlayer(PlayerInfo playerInfo)
		{
			return null;
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x0000BAD8 File Offset: 0x00009CD8
		[Token(Token = "0x6003A90")]
		[Address(RVA = "0x8A06", Offset = "0x8A06", VA = "0x8A06", Slot = "16")]
		public virtual bool RemovePlayer(ulong userId, out CombatPlayer player)
		{
			return default(bool);
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A91")]
		[Address(RVA = "0x8A07", Offset = "0x8A07", VA = "0x8A07")]
		public GameFieldGemSetsDic GetGameFieldGemSetDic()
		{
			return null;
		}

		// Token: 0x06003A92 RID: 14994 RVA: 0x0000BAF0 File Offset: 0x00009CF0
		[Token(Token = "0x6003A92")]
		[Address(RVA = "0x8A08", Offset = "0x8A08", VA = "0x8A08")]
		public CombatModel.States GetState()
		{
			return CombatModel.States.None;
		}

		// Token: 0x06003A93 RID: 14995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A93")]
		[Address(RVA = "0x8A09", Offset = "0x8A09", VA = "0x8A09", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06003A94 RID: 14996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A94")]
		[Address(RVA = "0x8A0A", Offset = "0x8A0A", VA = "0x8A0A")]
		public CombatModel(CombatDependencies dependencies, BackTime awaitBackTime, UserData loggedUser, UserData user)
		{
		}

		// Token: 0x04002040 RID: 8256
		[Token(Token = "0x4002040")]
		[FieldOffset(Offset = "0xC")]
		private JoinToCombatInfo _joinToCombatInfo;

		// Token: 0x04002041 RID: 8257
		[Token(Token = "0x4002041")]
		[FieldOffset(Offset = "0x10")]
		public GameOverData GameOver;

		// Token: 0x04002046 RID: 8262
		[Token(Token = "0x4002046")]
		[FieldOffset(Offset = "0x24")]
		protected CombatPlayer _myPlayer;

		// Token: 0x04002048 RID: 8264
		[Token(Token = "0x4002048")]
		[FieldOffset(Offset = "0x2C")]
		public readonly GameFieldGamesData FieldData;

		// Token: 0x04002049 RID: 8265
		[Token(Token = "0x4002049")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<CombatSpellData> _eventSpells;

		// Token: 0x0400204A RID: 8266
		[Token(Token = "0x400204A")]
		[FieldOffset(Offset = "0x34")]
		public ProtoSwitchTurnEvt CurrentTurn;

		// Token: 0x0400204B RID: 8267
		[Token(Token = "0x400204B")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<ulong, Dictionary<string, List<ModifierData>>> ActiveArtifactsCachByUserId;

		// Token: 0x04002051 RID: 8273
		[Token(Token = "0x4002051")]
		[FieldOffset(Offset = "0x50")]
		public Scenes[] ScenesForUnload;

		// Token: 0x04002052 RID: 8274
		[Token(Token = "0x4002052")]
		[FieldOffset(Offset = "0x54")]
		public Scenes[] TargetScenes;

		// Token: 0x04002053 RID: 8275
		[Token(Token = "0x4002053")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<uint, CombatEventData> _combatEventDicCache;

		// Token: 0x02000994 RID: 2452
		[Token(Token = "0x2000994")]
		public enum States
		{
			// Token: 0x04002055 RID: 8277
			[Token(Token = "0x4002055")]
			None,
			// Token: 0x04002056 RID: 8278
			[Token(Token = "0x4002056")]
			Await,
			// Token: 0x04002057 RID: 8279
			[Token(Token = "0x4002057")]
			Process,
			// Token: 0x04002058 RID: 8280
			[Token(Token = "0x4002058")]
			Complete
		}
	}
}
