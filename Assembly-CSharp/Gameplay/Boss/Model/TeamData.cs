using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Skills;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Boss;
using Utils;

namespace Gameplay.Boss.Model
{
	// Token: 0x02000B95 RID: 2965
	[Token(Token = "0x2000B95")]
	public class TeamData : IDisposable
	{
		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06004870 RID: 18544 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004871 RID: 18545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB3")]
		[NotNull]
		public BackTime TimeoutBacktimer
		{
			[Token(Token = "0x6004870")]
			[Address(RVA = "0x96EF", Offset = "0x96EF", VA = "0x96EF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004871")]
			[Address(RVA = "0x96F0", Offset = "0x96F0", VA = "0x96F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06004872 RID: 18546 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004873 RID: 18547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB4")]
		public Skill TotalSkillBonus
		{
			[Token(Token = "0x6004872")]
			[Address(RVA = "0x96F1", Offset = "0x96F1", VA = "0x96F1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004873")]
			[Address(RVA = "0x96F2", Offset = "0x96F2", VA = "0x96F2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06004874 RID: 18548 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004875 RID: 18549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB5")]
		public List<TeamData.TeamAssistantData> Assistants
		{
			[Token(Token = "0x6004874")]
			[Address(RVA = "0x96F3", Offset = "0x96F3", VA = "0x96F3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004875")]
			[Address(RVA = "0x96F4", Offset = "0x96F4", VA = "0x96F4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06004876 RID: 18550 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004877 RID: 18551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB6")]
		public TeamData.TeamCaptainData Captain
		{
			[Token(Token = "0x6004876")]
			[Address(RVA = "0x96F5", Offset = "0x96F5", VA = "0x96F5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004877")]
			[Address(RVA = "0x96F6", Offset = "0x96F6", VA = "0x96F6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x06004878 RID: 18552 RVA: 0x0000D668 File Offset: 0x0000B868
		[Token(Token = "0x17000EB7")]
		public bool HasEmptySlots
		{
			[Token(Token = "0x6004878")]
			[Address(RVA = "0x96F7", Offset = "0x96F7", VA = "0x96F7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x140001CA RID: 458
		// (add) Token: 0x06004879 RID: 18553 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600487A RID: 18554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001CA")]
		public event Action CaptainRatingChangedEvent
		{
			[Token(Token = "0x6004879")]
			[Address(RVA = "0x96F8", Offset = "0x96F8", VA = "0x96F8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600487A")]
			[Address(RVA = "0x96F9", Offset = "0x96F9", VA = "0x96F9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x0600487B RID: 18555 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600487C RID: 18556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB8")]
		public CaptainRating CaptainRating
		{
			[Token(Token = "0x600487B")]
			[Address(RVA = "0x96FA", Offset = "0x96FA", VA = "0x96FA")]
			get
			{
				return null;
			}
			[Token(Token = "0x600487C")]
			[Address(RVA = "0x96FB", Offset = "0x96FB", VA = "0x96FB")]
			set
			{
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x0600487D RID: 18557 RVA: 0x0000D680 File Offset: 0x0000B880
		// (set) Token: 0x0600487E RID: 18558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB9")]
		public ulong CaptainsCount
		{
			[Token(Token = "0x600487D")]
			[Address(RVA = "0x96FC", Offset = "0x96FC", VA = "0x96FC")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600487E")]
			[Address(RVA = "0x96FD", Offset = "0x96FD", VA = "0x96FD")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x0600487F RID: 18559 RVA: 0x0000D698 File Offset: 0x0000B898
		// (set) Token: 0x06004880 RID: 18560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EBA")]
		public bool IsMyTeam
		{
			[Token(Token = "0x600487F")]
			[Address(RVA = "0x96FE", Offset = "0x96FE", VA = "0x96FE")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004880")]
			[Address(RVA = "0x96FF", Offset = "0x96FF", VA = "0x96FF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06004881 RID: 18561 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
		[Token(Token = "0x17000EBB")]
		public ulong TeamId
		{
			[Token(Token = "0x6004881")]
			[Address(RVA = "0x9700", Offset = "0x9700", VA = "0x9700")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06004882 RID: 18562 RVA: 0x0000D6C8 File Offset: 0x0000B8C8
		[Token(Token = "0x17000EBC")]
		public ulong MyRatingPlace
		{
			[Token(Token = "0x6004882")]
			[Address(RVA = "0x9701", Offset = "0x9701", VA = "0x9701")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x06004883 RID: 18563 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004883")]
		[Address(RVA = "0x1B87", Offset = "0x1B87", VA = "0x1B87")]
		public TeamData.TeamAssistantData GetAssistantById(ulong uid)
		{
			return null;
		}

		// Token: 0x06004884 RID: 18564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004884")]
		[Address(RVA = "0x9702", Offset = "0x9702", VA = "0x9702")]
		public TeamData(TeamInfo rawTeamInfo, BossInfo bossInfo, UserData loggedUser)
		{
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x06004885 RID: 18565 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004886 RID: 18566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EBD")]
		public TeamInfo RawTeamInfo
		{
			[Token(Token = "0x6004885")]
			[Address(RVA = "0x9703", Offset = "0x9703", VA = "0x9703")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004886")]
			[Address(RVA = "0x9704", Offset = "0x9704", VA = "0x9704")]
			set
			{
			}
		}

		// Token: 0x06004887 RID: 18567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004887")]
		[Address(RVA = "0x9705", Offset = "0x9705", VA = "0x9705", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x040027B0 RID: 10160
		[Token(Token = "0x40027B0")]
		[FieldOffset(Offset = "0x8")]
		private BossInfo _bossInfo;

		// Token: 0x040027B1 RID: 10161
		[Token(Token = "0x40027B1")]
		public const int CAPACITY = 5;

		// Token: 0x040027B7 RID: 10167
		[Token(Token = "0x40027B7")]
		[FieldOffset(Offset = "0x20")]
		private CaptainRating _captainRating;

		// Token: 0x040027BA RID: 10170
		[Token(Token = "0x40027BA")]
		[FieldOffset(Offset = "0x34")]
		private TeamInfo _rawTeamInfo;

		// Token: 0x02000B96 RID: 2966
		[Token(Token = "0x2000B96")]
		public abstract class AbstractTeamMember
		{
			// Token: 0x17000EBE RID: 3774
			// (get) Token: 0x06004888 RID: 18568 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
			// (set) Token: 0x06004889 RID: 18569 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EBE")]
			public long InstanceId
			{
				[Token(Token = "0x6004888")]
				[Address(RVA = "0x9706", Offset = "0x9706", VA = "0x9706")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[Token(Token = "0x6004889")]
				[Address(RVA = "0x9707", Offset = "0x9707", VA = "0x9707")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000EBF RID: 3775
			// (get) Token: 0x0600488A RID: 18570 RVA: 0x0000D6F8 File Offset: 0x0000B8F8
			// (set) Token: 0x0600488B RID: 18571 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EBF")]
			public ulong TeamId
			{
				[Token(Token = "0x600488A")]
				[Address(RVA = "0x9708", Offset = "0x9708", VA = "0x9708")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
				[Token(Token = "0x600488B")]
				[Address(RVA = "0x9709", Offset = "0x9709", VA = "0x9709")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000EC0 RID: 3776
			// (get) Token: 0x0600488C RID: 18572
			[Token(Token = "0x17000EC0")]
			public abstract UserData UserData { [Token(Token = "0x600488C")] get; }

			// Token: 0x0600488D RID: 18573 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600488D")]
			[Address(RVA = "0x970A", Offset = "0x970A", VA = "0x970A")]
			public AbstractTeamMember(long instanceId, ulong teamId)
			{
			}
		}

		// Token: 0x02000B97 RID: 2967
		[Token(Token = "0x2000B97")]
		public class TeamAssistantData : TeamData.AbstractTeamMember
		{
			// Token: 0x17000EC1 RID: 3777
			// (get) Token: 0x0600488E RID: 18574 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000EC1")]
			public override UserData UserData
			{
				[Token(Token = "0x600488E")]
				[Address(RVA = "0x970B", Offset = "0x970B", VA = "0x970B", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000EC2 RID: 3778
			// (get) Token: 0x0600488F RID: 18575 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004890 RID: 18576 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EC2")]
			public Skills SkillBonuses
			{
				[Token(Token = "0x600488F")]
				[Address(RVA = "0x970C", Offset = "0x970C", VA = "0x970C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004890")]
				[Address(RVA = "0x970D", Offset = "0x970D", VA = "0x970D")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000EC3 RID: 3779
			// (get) Token: 0x06004891 RID: 18577 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004892 RID: 18578 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EC3")]
			public Skill SkillBonus
			{
				[Token(Token = "0x6004891")]
				[Address(RVA = "0x970E", Offset = "0x970E", VA = "0x970E")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004892")]
				[Address(RVA = "0x970F", Offset = "0x970F", VA = "0x970F")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000EC4 RID: 3780
			// (get) Token: 0x06004893 RID: 18579 RVA: 0x0000D710 File Offset: 0x0000B910
			// (set) Token: 0x06004894 RID: 18580 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EC4")]
			public int CultBonusPercent
			{
				[Token(Token = "0x6004893")]
				[Address(RVA = "0x9710", Offset = "0x9710", VA = "0x9710")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6004894")]
				[Address(RVA = "0x9711", Offset = "0x9711", VA = "0x9711")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000EC5 RID: 3781
			// (get) Token: 0x06004895 RID: 18581 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004896 RID: 18582 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EC5")]
			[NotNull]
			public BackTime BackTime
			{
				[Token(Token = "0x6004895")]
				[Address(RVA = "0x9712", Offset = "0x9712", VA = "0x9712")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004896")]
				[Address(RVA = "0x9713", Offset = "0x9713", VA = "0x9713")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000EC6 RID: 3782
			// (get) Token: 0x06004897 RID: 18583 RVA: 0x0000D728 File Offset: 0x0000B928
			[Token(Token = "0x17000EC6")]
			public bool IsAbsent
			{
				[Token(Token = "0x6004897")]
				[Address(RVA = "0x9714", Offset = "0x9714", VA = "0x9714")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000EC7 RID: 3783
			// (get) Token: 0x06004898 RID: 18584 RVA: 0x0000D740 File Offset: 0x0000B940
			[Token(Token = "0x17000EC7")]
			public bool IsInvited
			{
				[Token(Token = "0x6004898")]
				[Address(RVA = "0x9715", Offset = "0x9715", VA = "0x9715")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000EC8 RID: 3784
			// (get) Token: 0x06004899 RID: 18585 RVA: 0x0000D758 File Offset: 0x0000B958
			[Token(Token = "0x17000EC8")]
			public bool IsReady
			{
				[Token(Token = "0x6004899")]
				[Address(RVA = "0x9716", Offset = "0x9716", VA = "0x9716")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600489A RID: 18586 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600489A")]
			[Address(RVA = "0x9717", Offset = "0x9717", VA = "0x9717")]
			public TeamAssistantData(TeamInfo.Types.MercenaryInfo mercenaryInfo, BossInfo bossInfo, long instanceId, ulong teamId)
			{
			}

			// Token: 0x17000EC9 RID: 3785
			// (get) Token: 0x0600489B RID: 18587 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600489C RID: 18588 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EC9")]
			public TeamInfo.Types.MercenaryInfo RawMercenaryInfo
			{
				[Token(Token = "0x600489B")]
				[Address(RVA = "0x9718", Offset = "0x9718", VA = "0x9718")]
				get
				{
					return null;
				}
				[Token(Token = "0x600489C")]
				[Address(RVA = "0x1B30", Offset = "0x1B30", VA = "0x1B30")]
				set
				{
				}
			}

			// Token: 0x040027BD RID: 10173
			[Token(Token = "0x40027BD")]
			[FieldOffset(Offset = "0x18")]
			private BossInfo _bossInfo;

			// Token: 0x040027BE RID: 10174
			[Token(Token = "0x40027BE")]
			[FieldOffset(Offset = "0x1C")]
			private UserData _userData;

			// Token: 0x040027C3 RID: 10179
			[Token(Token = "0x40027C3")]
			[FieldOffset(Offset = "0x30")]
			private TeamInfo.Types.MercenaryInfo _rawMercenaryInfo;
		}

		// Token: 0x02000B99 RID: 2969
		[Token(Token = "0x2000B99")]
		public class TeamCaptainData : TeamData.AbstractTeamMember
		{
			// Token: 0x17000ECA RID: 3786
			// (get) Token: 0x060048A0 RID: 18592 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000ECA")]
			public override UserData UserData
			{
				[Token(Token = "0x60048A0")]
				[Address(RVA = "0x971C", Offset = "0x971C", VA = "0x971C", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000ECB RID: 3787
			// (get) Token: 0x060048A1 RID: 18593 RVA: 0x0000D788 File Offset: 0x0000B988
			// (set) Token: 0x060048A2 RID: 18594 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ECB")]
			public uint SlotsCont
			{
				[Token(Token = "0x60048A1")]
				[Address(RVA = "0x971D", Offset = "0x971D", VA = "0x971D")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
				[Token(Token = "0x60048A2")]
				[Address(RVA = "0x971E", Offset = "0x971E", VA = "0x971E")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060048A3 RID: 18595 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60048A3")]
			[Address(RVA = "0x971F", Offset = "0x971F", VA = "0x971F")]
			public TeamCaptainData(TeamInfo.Types.CaptainInfo captainInfo, long instanceId, ulong teamId)
			{
			}

			// Token: 0x17000ECC RID: 3788
			// (get) Token: 0x060048A4 RID: 18596 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060048A5 RID: 18597 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ECC")]
			public TeamInfo.Types.CaptainInfo RawCaptainInfo
			{
				[Token(Token = "0x60048A4")]
				[Address(RVA = "0x9720", Offset = "0x9720", VA = "0x9720")]
				get
				{
					return null;
				}
				[Token(Token = "0x60048A5")]
				[Address(RVA = "0x9721", Offset = "0x9721", VA = "0x9721")]
				set
				{
				}
			}

			// Token: 0x040027C6 RID: 10182
			[Token(Token = "0x40027C6")]
			[FieldOffset(Offset = "0x18")]
			private UserData _userData;

			// Token: 0x040027C8 RID: 10184
			[Token(Token = "0x40027C8")]
			[FieldOffset(Offset = "0x20")]
			private TeamInfo.Types.CaptainInfo _rawCaptainInfo;
		}
	}
}
