using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Boss;
using Utils;

namespace Gameplay.Boss.Model
{
	// Token: 0x02000B91 RID: 2961
	[Token(Token = "0x2000B91")]
	public class BossInstanceModel : AbstractModel
	{
		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06004826 RID: 18470 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
		[Token(Token = "0x17000E8D")]
		public bool IsAlive
		{
			[Token(Token = "0x6004826")]
			[Address(RVA = "0x96A9", Offset = "0x96A9", VA = "0x96A9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06004827 RID: 18471 RVA: 0x0000D4D0 File Offset: 0x0000B6D0
		[Token(Token = "0x17000E8E")]
		public bool IsDead
		{
			[Token(Token = "0x6004827")]
			[Address(RVA = "0x96AA", Offset = "0x96AA", VA = "0x96AA")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06004828 RID: 18472 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		[Token(Token = "0x17000E8F")]
		public bool IsLocked
		{
			[Token(Token = "0x6004828")]
			[Address(RVA = "0x96AB", Offset = "0x96AB", VA = "0x96AB")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06004829 RID: 18473 RVA: 0x0000D500 File Offset: 0x0000B700
		[Token(Token = "0x17000E90")]
		public bool IsEnded
		{
			[Token(Token = "0x6004829")]
			[Address(RVA = "0x96AC", Offset = "0x96AC", VA = "0x96AC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x0600482A RID: 18474 RVA: 0x0000D518 File Offset: 0x0000B718
		[Token(Token = "0x17000E91")]
		public bool Allowed
		{
			[Token(Token = "0x600482A")]
			[Address(RVA = "0x96AD", Offset = "0x96AD", VA = "0x96AD")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x0600482B RID: 18475 RVA: 0x0000D530 File Offset: 0x0000B730
		[Token(Token = "0x17000E92")]
		public bool IsIParticipated
		{
			[Token(Token = "0x600482B")]
			[Address(RVA = "0x96AE", Offset = "0x96AE", VA = "0x96AE")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x0600482C RID: 18476 RVA: 0x0000D548 File Offset: 0x0000B748
		[Token(Token = "0x17000E93")]
		public int NumUndistributedRewards
		{
			[Token(Token = "0x600482C")]
			[Address(RVA = "0x1B39", Offset = "0x1B39", VA = "0x1B39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x0600482D RID: 18477 RVA: 0x0000D560 File Offset: 0x0000B760
		[Token(Token = "0x17000E94")]
		public int NumInvites
		{
			[Token(Token = "0x600482D")]
			[Address(RVA = "0x96AF", Offset = "0x96AF", VA = "0x96AF")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x0600482E RID: 18478 RVA: 0x0000D578 File Offset: 0x0000B778
		[Token(Token = "0x17000E95")]
		public int NumNotifications
		{
			[Token(Token = "0x600482E")]
			[Address(RVA = "0x96B0", Offset = "0x96B0", VA = "0x96B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x0600482F RID: 18479 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004830 RID: 18480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E96")]
		public List<BossInviteData> MyInvites
		{
			[Token(Token = "0x600482F")]
			[Address(RVA = "0x96B1", Offset = "0x96B1", VA = "0x96B1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004830")]
			[Address(RVA = "0x96B2", Offset = "0x96B2", VA = "0x96B2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06004831 RID: 18481 RVA: 0x0000D590 File Offset: 0x0000B790
		[Token(Token = "0x17000E97")]
		public long Id
		{
			[Token(Token = "0x6004831")]
			[Address(RVA = "0x96B3", Offset = "0x96B3", VA = "0x96B3")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06004832 RID: 18482 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004833 RID: 18483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E98")]
		public BossInfo BossInfo
		{
			[Token(Token = "0x6004832")]
			[Address(RVA = "0x96B4", Offset = "0x96B4", VA = "0x96B4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004833")]
			[Address(RVA = "0x96B5", Offset = "0x96B5", VA = "0x96B5")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06004834 RID: 18484 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004835 RID: 18485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E99")]
		public BackTime NextPhaseBacktime
		{
			[Token(Token = "0x6004834")]
			[Address(RVA = "0x96B6", Offset = "0x96B6", VA = "0x96B6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004835")]
			[Address(RVA = "0x96B7", Offset = "0x96B7", VA = "0x96B7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06004836 RID: 18486 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004837 RID: 18487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E9A")]
		public InstanceInfo InstanceInfo
		{
			[Token(Token = "0x6004836")]
			[Address(RVA = "0x96B8", Offset = "0x96B8", VA = "0x96B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004837")]
			[Address(RVA = "0x1B67", Offset = "0x1B67", VA = "0x1B67")]
			set
			{
			}
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06004838 RID: 18488 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004839 RID: 18489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E9B")]
		public InstanceState InstanceState
		{
			[Token(Token = "0x6004838")]
			[Address(RVA = "0x96B9", Offset = "0x96B9", VA = "0x96B9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004839")]
			[Address(RVA = "0x96BA", Offset = "0x96BA", VA = "0x96BA")]
			set
			{
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x0600483A RID: 18490 RVA: 0x0000D5A8 File Offset: 0x0000B7A8
		// (set) Token: 0x0600483B RID: 18491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E9C")]
		public ulong CurrentHealth
		{
			[Token(Token = "0x600483A")]
			[Address(RVA = "0x96BB", Offset = "0x96BB", VA = "0x96BB")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600483B")]
			[Address(RVA = "0x96BC", Offset = "0x96BC", VA = "0x96BC")]
			set
			{
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x0600483C RID: 18492 RVA: 0x0000D5C0 File Offset: 0x0000B7C0
		[Token(Token = "0x17000E9D")]
		public float CurrentHealthPercent
		{
			[Token(Token = "0x600483C")]
			[Address(RVA = "0x96BD", Offset = "0x96BD", VA = "0x96BD")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x0600483D RID: 18493 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E9E")]
		public string HealthBarValue
		{
			[Token(Token = "0x600483D")]
			[Address(RVA = "0x96BE", Offset = "0x96BE", VA = "0x96BE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x0600483E RID: 18494 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600483F RID: 18495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E9F")]
		public TeamData MyTeam
		{
			[Token(Token = "0x600483E")]
			[Address(RVA = "0x96BF", Offset = "0x96BF", VA = "0x96BF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600483F")]
			[Address(RVA = "0x96C0", Offset = "0x96C0", VA = "0x96C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004840 RID: 18496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004840")]
		[Address(RVA = "0x96C1", Offset = "0x96C1", VA = "0x96C1")]
		public BossInstanceModel(IDictProvider dictProvider, UserData user)
		{
		}

		// Token: 0x06004841 RID: 18497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004841")]
		[Address(RVA = "0x96C2", Offset = "0x96C2", VA = "0x96C2")]
		public void SetMyTeam(TeamInfo teamInfo)
		{
		}

		// Token: 0x06004842 RID: 18498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004842")]
		[Address(RVA = "0x96C3", Offset = "0x96C3", VA = "0x96C3")]
		public void SetMyInvites(IList<MercenaryInvitesEvt.Types.Invite> invitesRaw)
		{
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06004843 RID: 18499 RVA: 0x0000D5D8 File Offset: 0x0000B7D8
		// (set) Token: 0x06004844 RID: 18500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EA0")]
		public int LicenceCountCurrent
		{
			[Token(Token = "0x6004843")]
			[Address(RVA = "0x96C4", Offset = "0x96C4", VA = "0x96C4")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004844")]
			[Address(RVA = "0x96C5", Offset = "0x96C5", VA = "0x96C5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06004845 RID: 18501 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004846 RID: 18502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EA1")]
		public RepeatedField<GetCaptainTeamListAns.Types.TeamRewardInfo> TeamsRewardInfo
		{
			[Token(Token = "0x6004845")]
			[Address(RVA = "0x96C6", Offset = "0x96C6", VA = "0x96C6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004846")]
			[Address(RVA = "0x96C7", Offset = "0x96C7", VA = "0x96C7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06004847 RID: 18503 RVA: 0x0000D5F0 File Offset: 0x0000B7F0
		// (set) Token: 0x06004848 RID: 18504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EA2")]
		public ulong CaptainsCount
		{
			[Token(Token = "0x6004847")]
			[Address(RVA = "0x96C8", Offset = "0x96C8", VA = "0x96C8")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6004848")]
			[Address(RVA = "0x96C9", Offset = "0x96C9", VA = "0x96C9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06004849 RID: 18505 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600484A RID: 18506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EA3")]
		public RepeatedField<ShortTeamInfo> MyCaptainsAllTeams
		{
			[Token(Token = "0x6004849")]
			[Address(RVA = "0x96CA", Offset = "0x96CA", VA = "0x96CA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600484A")]
			[Address(RVA = "0x96CB", Offset = "0x96CB", VA = "0x96CB")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600484B RID: 18507 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600484B")]
		[Address(RVA = "0x96CC", Offset = "0x96CC", VA = "0x96CC")]
		[NotNull]
		public List<ulong> GetTeamIdsForMyCaptain(ulong captainId)
		{
			return null;
		}

		// Token: 0x0600484C RID: 18508 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600484C")]
		[Address(RVA = "0x1B81", Offset = "0x1B81", VA = "0x1B81")]
		[NotNull]
		public List<TeamData.TeamAssistantData> GetAssistantsByCultId(uint cultId)
		{
			return null;
		}

		// Token: 0x04002796 RID: 10134
		[Token(Token = "0x4002796")]
		[FieldOffset(Offset = "0xC")]
		public readonly IDictProvider DictProvider;

		// Token: 0x04002797 RID: 10135
		[Token(Token = "0x4002797")]
		[FieldOffset(Offset = "0x10")]
		[TupleElementNames(new string[]
		{
			"OptionId",
			"VariantId"
		})]
		public ValueTuple<long, int>? LastSavedOptionAndVariant;

		// Token: 0x04002798 RID: 10136
		[Token(Token = "0x4002798")]
		[FieldOffset(Offset = "0x28")]
		private InstanceInfo _instanceInfo;

		// Token: 0x0400279C RID: 10140
		[Token(Token = "0x400279C")]
		[FieldOffset(Offset = "0x38")]
		private InstanceState _instanceState;
	}
}
