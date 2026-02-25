using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Gameplay.Clans.Combat.Model;
using Gameplay.School.Model;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.ClanIsle;
using Protocol.Common;

namespace Core.Events.Scopes
{
	// Token: 0x02000FE5 RID: 4069
	[Token(Token = "0x2000FE5")]
	public class ClansScope : AbstractEventBusScope
	{
		// Token: 0x060060E9 RID: 24809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060E9")]
		[Address(RVA = "0xAD15", Offset = "0xAD15", VA = "0xAD15", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060060EA RID: 24810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060EA")]
		[Address(RVA = "0xAD16", Offset = "0xAD16", VA = "0xAD16")]
		public ClansScope()
		{
		}

		// Token: 0x040033D4 RID: 13268
		[Token(Token = "0x40033D4")]
		[FieldOffset(Offset = "0x8")]
		public Action<ClansScope.CreateClanEventArgs> CreateClanEvent;

		// Token: 0x040033D5 RID: 13269
		[Token(Token = "0x40033D5")]
		[FieldOffset(Offset = "0xC")]
		public Action<ClansScope.ClansEventArgs> JoinRequestEvent;

		// Token: 0x040033D6 RID: 13270
		[Token(Token = "0x40033D6")]
		[FieldOffset(Offset = "0x10")]
		public Action<UserScope.BaseUserEventArgs> ConfirmJoinClanEvent;

		// Token: 0x040033D7 RID: 13271
		[Token(Token = "0x40033D7")]
		[FieldOffset(Offset = "0x14")]
		public Action<ClansScope.ClansEventArgs> AddMoneyToClanEvent;

		// Token: 0x040033D8 RID: 13272
		[Token(Token = "0x40033D8")]
		[FieldOffset(Offset = "0x18")]
		public Action<ClansScope.ClanBuildingEventArgs> StartClanBuildEvent;

		// Token: 0x040033D9 RID: 13273
		[Token(Token = "0x40033D9")]
		[FieldOffset(Offset = "0x1C")]
		public Action<ClansScope.ClanIsleEventArgs> BuyClanSlotEvent;

		// Token: 0x040033DA RID: 13274
		[Token(Token = "0x40033DA")]
		[FieldOffset(Offset = "0x20")]
		public Action<ClansScope.ClanSpellEventArgs> StartLearnSpellEvent;

		// Token: 0x040033DB RID: 13275
		[Token(Token = "0x40033DB")]
		[FieldOffset(Offset = "0x24")]
		public Action<ClansScope.ClanSpellEventArgs> UseSpellEvent;

		// Token: 0x040033DC RID: 13276
		[Token(Token = "0x40033DC")]
		[FieldOffset(Offset = "0x28")]
		public Action<ClansScope.ClanWarsDeclarationEventArgs> WarDeclaredEvent;

		// Token: 0x040033DD RID: 13277
		[Token(Token = "0x40033DD")]
		[FieldOffset(Offset = "0x2C")]
		public Action<ClansScope.ClanWarsEventArgs> WarPrepareSpeedupEvent;

		// Token: 0x040033DE RID: 13278
		[Token(Token = "0x40033DE")]
		[FieldOffset(Offset = "0x30")]
		public Action<ClansScope.ClanWarsEventArgs> WarPrepareCancelSpeedupEvent;

		// Token: 0x040033DF RID: 13279
		[Token(Token = "0x40033DF")]
		[FieldOffset(Offset = "0x34")]
		public Action<ClansScope.ClanWarsEventArgs> WarPayoffEvent;

		// Token: 0x040033E0 RID: 13280
		[Token(Token = "0x40033E0")]
		[FieldOffset(Offset = "0x38")]
		public Action TakeGolemOutEvent;

		// Token: 0x040033E1 RID: 13281
		[Token(Token = "0x40033E1")]
		[FieldOffset(Offset = "0x3C")]
		public Action<ClansScope.BaseClansEventArgs> LeaveClanEvent;

		// Token: 0x040033E2 RID: 13282
		[Token(Token = "0x40033E2")]
		[FieldOffset(Offset = "0x40")]
		public Action<ClansScope.BaseClansEventArgs> DissolveClanEvent;

		// Token: 0x040033E3 RID: 13283
		[Token(Token = "0x40033E3")]
		[FieldOffset(Offset = "0x44")]
		public Action<ClansScope.ClanCombatEventArgs> ClanCombatStartedEvent;

		// Token: 0x040033E4 RID: 13284
		[Token(Token = "0x40033E4")]
		[FieldOffset(Offset = "0x48")]
		public Action<ClansScope.ClanCombatFinishEventArgs> ClanCombatFinishedEvent;

		// Token: 0x02000FE6 RID: 4070
		[Token(Token = "0x2000FE6")]
		public class CreateClanEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x060060EB RID: 24811 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060EB")]
			[Address(RVA = "0xAD17", Offset = "0xAD17", VA = "0xAD17")]
			public CreateClanEventArgs(App app, IGame game)
			{
			}

			// Token: 0x040033E5 RID: 13285
			[Token(Token = "0x40033E5")]
			[FieldOffset(Offset = "0x10")]
			public ulong ClanId;

			// Token: 0x040033E6 RID: 13286
			[Token(Token = "0x40033E6")]
			[FieldOffset(Offset = "0x18")]
			public string ClanName;

			// Token: 0x040033E7 RID: 13287
			[Token(Token = "0x40033E7")]
			[FieldOffset(Offset = "0x1C")]
			public ResourceSet Price;
		}

		// Token: 0x02000FE7 RID: 4071
		[Token(Token = "0x2000FE7")]
		public class BaseClansEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001321 RID: 4897
			// (get) Token: 0x060060EC RID: 24812 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060060ED RID: 24813 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001321")]
			public ClanData ClanData
			{
				[Token(Token = "0x60060EC")]
				[Address(RVA = "0xAD18", Offset = "0xAD18", VA = "0xAD18")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60060ED")]
				[Address(RVA = "0xAD19", Offset = "0xAD19", VA = "0xAD19")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001322 RID: 4898
			// (get) Token: 0x060060EE RID: 24814 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001322")]
			public ClanInfo ClanInfo
			{
				[Token(Token = "0x60060EE")]
				[Address(RVA = "0xAD1A", Offset = "0xAD1A", VA = "0xAD1A")]
				get
				{
					return null;
				}
			}

			// Token: 0x060060EF RID: 24815 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060EF")]
			[Address(RVA = "0xAD1B", Offset = "0xAD1B", VA = "0xAD1B")]
			public BaseClansEventArgs(App app, IGame game, ClanData clanData)
			{
			}
		}

		// Token: 0x02000FE8 RID: 4072
		[Token(Token = "0x2000FE8")]
		public class ClansEventArgs : ClansScope.BaseClansEventArgs
		{
			// Token: 0x060060F0 RID: 24816 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060F0")]
			[Address(RVA = "0xAD1C", Offset = "0xAD1C", VA = "0xAD1C")]
			public ClansEventArgs(App app, IGame game, ClanData clanData, ResourceSet price)
			{
			}

			// Token: 0x040033E9 RID: 13289
			[Token(Token = "0x40033E9")]
			[FieldOffset(Offset = "0x14")]
			public ResourceSet Price;
		}

		// Token: 0x02000FE9 RID: 4073
		[Token(Token = "0x2000FE9")]
		public class ClanBuildingEventArgs : ClansScope.BaseClansEventArgs
		{
			// Token: 0x17001323 RID: 4899
			// (get) Token: 0x060060F1 RID: 24817 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060060F2 RID: 24818 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001323")]
			public BaseBuildingData ClanBuildingData
			{
				[Token(Token = "0x60060F1")]
				[Address(RVA = "0xAD1D", Offset = "0xAD1D", VA = "0xAD1D")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60060F2")]
				[Address(RVA = "0xAD1E", Offset = "0xAD1E", VA = "0xAD1E")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060060F3 RID: 24819 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060F3")]
			[Address(RVA = "0xAD1F", Offset = "0xAD1F", VA = "0xAD1F")]
			public ClanBuildingEventArgs(App app, IGame game, ClanData clanData, BaseBuildingData clanBuilding)
			{
			}
		}

		// Token: 0x02000FEA RID: 4074
		[Token(Token = "0x2000FEA")]
		public class ClanIsleBaseEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001324 RID: 4900
			// (get) Token: 0x060060F4 RID: 24820 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060060F5 RID: 24821 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001324")]
			public ProtoGetIsleInfoAns.Types.ClanIsleInformation ClanIsleInformation
			{
				[Token(Token = "0x60060F4")]
				[Address(RVA = "0xAD20", Offset = "0xAD20", VA = "0xAD20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60060F5")]
				[Address(RVA = "0xAD21", Offset = "0xAD21", VA = "0xAD21")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060060F6 RID: 24822 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060F6")]
			[Address(RVA = "0xAD22", Offset = "0xAD22", VA = "0xAD22")]
			public ClanIsleBaseEventArgs(App app, IGame game, ProtoGetIsleInfoAns.Types.ClanIsleInformation clanIsleInformation)
			{
			}
		}

		// Token: 0x02000FEB RID: 4075
		[Token(Token = "0x2000FEB")]
		public class ClanIsleEventArgs : ClansScope.ClanIsleBaseEventArgs
		{
			// Token: 0x17001325 RID: 4901
			// (get) Token: 0x060060F7 RID: 24823 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060060F8 RID: 24824 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001325")]
			public ResourceSet Price
			{
				[Token(Token = "0x60060F7")]
				[Address(RVA = "0xAD23", Offset = "0xAD23", VA = "0xAD23")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60060F8")]
				[Address(RVA = "0xAD24", Offset = "0xAD24", VA = "0xAD24")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060060F9 RID: 24825 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060F9")]
			[Address(RVA = "0xAD25", Offset = "0xAD25", VA = "0xAD25")]
			public ClanIsleEventArgs(App app, IGame game, ProtoGetIsleInfoAns.Types.ClanIsleInformation clanIsleInformation, ResourceSet price)
			{
			}
		}

		// Token: 0x02000FEC RID: 4076
		[Token(Token = "0x2000FEC")]
		public class ClanSpellEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001326 RID: 4902
			// (get) Token: 0x060060FA RID: 24826 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060060FB RID: 24827 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001326")]
			public SchoolSpellData SpellData
			{
				[Token(Token = "0x60060FA")]
				[Address(RVA = "0xAD26", Offset = "0xAD26", VA = "0xAD26")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60060FB")]
				[Address(RVA = "0xAD27", Offset = "0xAD27", VA = "0xAD27")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001327 RID: 4903
			// (get) Token: 0x060060FC RID: 24828 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060060FD RID: 24829 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001327")]
			public ResourceSet Price
			{
				[Token(Token = "0x60060FC")]
				[Address(RVA = "0xAD28", Offset = "0xAD28", VA = "0xAD28")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60060FD")]
				[Address(RVA = "0xAD29", Offset = "0xAD29", VA = "0xAD29")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060060FE RID: 24830 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060FE")]
			[Address(RVA = "0xAD2A", Offset = "0xAD2A", VA = "0xAD2A")]
			public ClanSpellEventArgs(App app, IGame game, SchoolSpellData spellData, ResourceSet price)
			{
			}
		}

		// Token: 0x02000FED RID: 4077
		[Token(Token = "0x2000FED")]
		public class ClanWarsEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001328 RID: 4904
			// (get) Token: 0x060060FF RID: 24831 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06006100 RID: 24832 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001328")]
			public ClanInfo Attacker
			{
				[Token(Token = "0x60060FF")]
				[Address(RVA = "0xAD2B", Offset = "0xAD2B", VA = "0xAD2B")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6006100")]
				[Address(RVA = "0xAD2C", Offset = "0xAD2C", VA = "0xAD2C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001329 RID: 4905
			// (get) Token: 0x06006101 RID: 24833 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06006102 RID: 24834 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001329")]
			public ClanInfo Defender
			{
				[Token(Token = "0x6006101")]
				[Address(RVA = "0xAD2D", Offset = "0xAD2D", VA = "0xAD2D")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6006102")]
				[Address(RVA = "0xAD2E", Offset = "0xAD2E", VA = "0xAD2E")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06006103 RID: 24835 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006103")]
			[Address(RVA = "0xAD2F", Offset = "0xAD2F", VA = "0xAD2F")]
			public ClanWarsEventArgs(App app, IGame game, ClanInfo attacker, ClanInfo defender)
			{
			}
		}

		// Token: 0x02000FEE RID: 4078
		[Token(Token = "0x2000FEE")]
		public class ClanWarsDeclarationEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x1700132A RID: 4906
			// (get) Token: 0x06006104 RID: 24836 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06006105 RID: 24837 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700132A")]
			public ClanInfo Attacker
			{
				[Token(Token = "0x6006104")]
				[Address(RVA = "0xAD30", Offset = "0xAD30", VA = "0xAD30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6006105")]
				[Address(RVA = "0xAD31", Offset = "0xAD31", VA = "0xAD31")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700132B RID: 4907
			// (get) Token: 0x06006106 RID: 24838 RVA: 0x00011AA8 File Offset: 0x0000FCA8
			// (set) Token: 0x06006107 RID: 24839 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700132B")]
			public ulong DefenderClanId
			{
				[Token(Token = "0x6006106")]
				[Address(RVA = "0xAD32", Offset = "0xAD32", VA = "0xAD32")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
				[Token(Token = "0x6006107")]
				[Address(RVA = "0xAD33", Offset = "0xAD33", VA = "0xAD33")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700132C RID: 4908
			// (get) Token: 0x06006108 RID: 24840 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06006109 RID: 24841 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700132C")]
			public string DefenderName
			{
				[Token(Token = "0x6006108")]
				[Address(RVA = "0xAD34", Offset = "0xAD34", VA = "0xAD34")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6006109")]
				[Address(RVA = "0xAD35", Offset = "0xAD35", VA = "0xAD35")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600610A RID: 24842 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600610A")]
			[Address(RVA = "0xAD36", Offset = "0xAD36", VA = "0xAD36")]
			public ClanWarsDeclarationEventArgs(App app, IGame game, ClanInfo attacker, ulong defenderClanId, string defenderName)
			{
			}
		}

		// Token: 0x02000FEF RID: 4079
		[Token(Token = "0x2000FEF")]
		public class ClanCombatEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x0600610B RID: 24843 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600610B")]
			[Address(RVA = "0xAD37", Offset = "0xAD37", VA = "0xAD37")]
			public ClanCombatEventArgs(App app, IGame game, ClanInfo opponentClanInfo)
			{
			}

			// Token: 0x040033F4 RID: 13300
			[Token(Token = "0x40033F4")]
			[FieldOffset(Offset = "0x10")]
			public ClanInfo OpponentClanInfo;
		}

		// Token: 0x02000FF0 RID: 4080
		[Token(Token = "0x2000FF0")]
		public class ClanCombatFinishEventArgs : ClansScope.ClanCombatEventArgs
		{
			// Token: 0x0600610C RID: 24844 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600610C")]
			[Address(RVA = "0xAD38", Offset = "0xAD38", VA = "0xAD38")]
			public ClanCombatFinishEventArgs(App app, IGame game, ClanInfo opponentClanInfo, GameOverData gameOverData)
			{
			}

			// Token: 0x040033F5 RID: 13301
			[Token(Token = "0x40033F5")]
			[FieldOffset(Offset = "0x14")]
			public GameOverData GameOverData;
		}
	}
}
