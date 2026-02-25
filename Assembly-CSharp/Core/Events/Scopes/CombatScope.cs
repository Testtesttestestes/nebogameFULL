using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Data;
using Core.Gameplay;
using Gameplay.ArenaCombat.Model;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Core.Events.Scopes
{
	// Token: 0x02000FF3 RID: 4083
	[Token(Token = "0x2000FF3")]
	public class CombatScope : AbstractEventBusScope
	{
		// Token: 0x06006111 RID: 24849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006111")]
		[Address(RVA = "0xAD3D", Offset = "0xAD3D", VA = "0xAD3D", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06006112 RID: 24850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006112")]
		[Address(RVA = "0xAD3E", Offset = "0xAD3E", VA = "0xAD3E")]
		public CombatScope()
		{
		}

		// Token: 0x040033F8 RID: 13304
		[Token(Token = "0x40033F8")]
		[FieldOffset(Offset = "0x8")]
		public Action<CombatScope.CombatEventArgs> CombatStartedEvent;

		// Token: 0x040033F9 RID: 13305
		[Token(Token = "0x40033F9")]
		[FieldOffset(Offset = "0xC")]
		public Action<CombatScope.CombatFinishedEventArgs> CombatFinishedEvent;

		// Token: 0x040033FA RID: 13306
		[Token(Token = "0x40033FA")]
		[FieldOffset(Offset = "0x10")]
		public Action<CombatScope.AttackMonsterEventArgs> AttackMonsterEvent;

		// Token: 0x040033FB RID: 13307
		[Token(Token = "0x40033FB")]
		[FieldOffset(Offset = "0x14")]
		public Action<CombatScope.KickMonsterEventArgs> KickMonsterEvent;

		// Token: 0x040033FC RID: 13308
		[Token(Token = "0x40033FC")]
		[FieldOffset(Offset = "0x18")]
		public Action<CombatScope.ComboEventArgs> ComboEvent;

		// Token: 0x040033FD RID: 13309
		[Token(Token = "0x40033FD")]
		[FieldOffset(Offset = "0x1C")]
		public Action<CombatScope.UseSpellArgs> UseSpellEvent;

		// Token: 0x040033FE RID: 13310
		[Token(Token = "0x40033FE")]
		[FieldOffset(Offset = "0x20")]
		public Action<CombatScope.UseSpellArgs> UseElixirEvent;

		// Token: 0x02000FF4 RID: 4084
		[Token(Token = "0x2000FF4")]
		public class CombatEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x1700132E RID: 4910
			// (get) Token: 0x06006113 RID: 24851 RVA: 0x00011AC0 File Offset: 0x0000FCC0
			[Token(Token = "0x1700132E")]
			public CombatTypes CombatType
			{
				[Token(Token = "0x6006113")]
				[Address(RVA = "0xAD3F", Offset = "0xAD3F", VA = "0xAD3F")]
				[CompilerGenerated]
				get
				{
					return CombatTypes.UnknownCombat;
				}
			}

			// Token: 0x1700132F RID: 4911
			// (get) Token: 0x06006114 RID: 24852 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06006115 RID: 24853 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700132F")]
			public ArenaCombatModel.ArenaCombatRequested ArenaCombatRequested
			{
				[Token(Token = "0x6006114")]
				[Address(RVA = "0xAD40", Offset = "0xAD40", VA = "0xAD40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6006115")]
				[Address(RVA = "0xAD41", Offset = "0xAD41", VA = "0xAD41")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17001330 RID: 4912
			// (get) Token: 0x06006116 RID: 24854 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06006117 RID: 24855 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001330")]
			public ArenaCombatModel.AttackRequestedMonster AttackRequestedMonster
			{
				[Token(Token = "0x6006116")]
				[Address(RVA = "0xAD42", Offset = "0xAD42", VA = "0xAD42")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6006117")]
				[Address(RVA = "0xAD43", Offset = "0xAD43", VA = "0xAD43")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06006118 RID: 24856 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006118")]
			[Address(RVA = "0xAD44", Offset = "0xAD44", VA = "0xAD44")]
			public CombatEventArgs(App app, IGame game, CombatTypes combatType)
			{
			}
		}

		// Token: 0x02000FF5 RID: 4085
		[Token(Token = "0x2000FF5")]
		public class CombatFinishedEventArgs : CombatScope.CombatEventArgs
		{
			// Token: 0x17001331 RID: 4913
			// (get) Token: 0x06006119 RID: 24857 RVA: 0x00011AD8 File Offset: 0x0000FCD8
			[Token(Token = "0x17001331")]
			public ulong OpponentId
			{
				[Token(Token = "0x6006119")]
				[Address(RVA = "0xAD45", Offset = "0xAD45", VA = "0xAD45")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
			}

			// Token: 0x17001332 RID: 4914
			// (get) Token: 0x0600611A RID: 24858 RVA: 0x00011AF0 File Offset: 0x0000FCF0
			[Token(Token = "0x17001332")]
			public bool IsWin
			{
				[Token(Token = "0x600611A")]
				[Address(RVA = "0xAD46", Offset = "0xAD46", VA = "0xAD46")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600611B RID: 24859 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600611B")]
			[Address(RVA = "0xAD47", Offset = "0xAD47", VA = "0xAD47")]
			public CombatFinishedEventArgs(App app, IGame game, CombatTypes combatType, ulong opponentId, bool isWin)
			{
			}
		}

		// Token: 0x02000FF6 RID: 4086
		[Token(Token = "0x2000FF6")]
		public class AttackMonsterEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001333 RID: 4915
			// (get) Token: 0x0600611C RID: 24860 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001333")]
			public ArenaCombatModel.AttackRequestedMonster AttackRequestedMonster
			{
				[Token(Token = "0x600611C")]
				[Address(RVA = "0xAD48", Offset = "0xAD48", VA = "0xAD48")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x0600611D RID: 24861 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600611D")]
			[Address(RVA = "0xAD49", Offset = "0xAD49", VA = "0xAD49")]
			public AttackMonsterEventArgs(App app, IGame game, ArenaCombatModel.AttackRequestedMonster attackRequestedMonster)
			{
			}
		}

		// Token: 0x02000FF7 RID: 4087
		[Token(Token = "0x2000FF7")]
		public class KickMonsterEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001334 RID: 4916
			// (get) Token: 0x0600611E RID: 24862 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001334")]
			public MonsterData MonsterData
			{
				[Token(Token = "0x600611E")]
				[Address(RVA = "0xAD4A", Offset = "0xAD4A", VA = "0xAD4A")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17001335 RID: 4917
			// (get) Token: 0x0600611F RID: 24863 RVA: 0x00011B08 File Offset: 0x0000FD08
			[Token(Token = "0x17001335")]
			public ulong OwnerId
			{
				[Token(Token = "0x600611F")]
				[Address(RVA = "0xAD4B", Offset = "0xAD4B", VA = "0xAD4B")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
			}

			// Token: 0x06006120 RID: 24864 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006120")]
			[Address(RVA = "0xAD4C", Offset = "0xAD4C", VA = "0xAD4C")]
			public KickMonsterEventArgs(App app, IGame game, MonsterData monsterData, ulong ownerId)
			{
			}
		}

		// Token: 0x02000FF8 RID: 4088
		[Token(Token = "0x2000FF8")]
		public class ComboEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001336 RID: 4918
			// (get) Token: 0x06006121 RID: 24865 RVA: 0x00011B20 File Offset: 0x0000FD20
			[Token(Token = "0x17001336")]
			public int NumStones
			{
				[Token(Token = "0x6006121")]
				[Address(RVA = "0xAD4D", Offset = "0xAD4D", VA = "0xAD4D")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001337 RID: 4919
			// (get) Token: 0x06006122 RID: 24866 RVA: 0x00011B38 File Offset: 0x0000FD38
			[Token(Token = "0x17001337")]
			public StonesTypes StonesType
			{
				[Token(Token = "0x6006122")]
				[Address(RVA = "0xAD4E", Offset = "0xAD4E", VA = "0xAD4E")]
				[CompilerGenerated]
				get
				{
					return StonesTypes.Empty;
				}
			}

			// Token: 0x17001338 RID: 4920
			// (get) Token: 0x06006123 RID: 24867 RVA: 0x00011B50 File Offset: 0x0000FD50
			[Token(Token = "0x17001338")]
			public bool IsPlayersStep
			{
				[Token(Token = "0x6006123")]
				[Address(RVA = "0xAD4F", Offset = "0xAD4F", VA = "0xAD4F")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06006124 RID: 24868 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006124")]
			[Address(RVA = "0xAD50", Offset = "0xAD50", VA = "0xAD50")]
			public ComboEventArgs(IApp app, IGame game, int numStones, StonesTypes stonesType, bool isPlayersStep)
			{
			}
		}

		// Token: 0x02000FF9 RID: 4089
		[Token(Token = "0x2000FF9")]
		public class UseSpellArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001339 RID: 4921
			// (get) Token: 0x06006125 RID: 24869 RVA: 0x00011B68 File Offset: 0x0000FD68
			[Token(Token = "0x17001339")]
			public uint SpellId
			{
				[Token(Token = "0x6006125")]
				[Address(RVA = "0xAD51", Offset = "0xAD51", VA = "0xAD51")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
			}

			// Token: 0x06006126 RID: 24870 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006126")]
			[Address(RVA = "0xAD52", Offset = "0xAD52", VA = "0xAD52")]
			public UseSpellArgs(IApp app, IGame game, uint spellId)
			{
			}
		}
	}
}
