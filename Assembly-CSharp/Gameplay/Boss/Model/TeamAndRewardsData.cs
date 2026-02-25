using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Boss;

namespace Gameplay.Boss.Model
{
	// Token: 0x02000B94 RID: 2964
	[Token(Token = "0x2000B94")]
	public class TeamAndRewardsData
	{
		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06004866 RID: 18534 RVA: 0x0000D650 File Offset: 0x0000B850
		[Token(Token = "0x17000EAE")]
		public bool NotDistributed
		{
			[Token(Token = "0x6004866")]
			[Address(RVA = "0x96E5", Offset = "0x96E5", VA = "0x96E5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06004867 RID: 18535 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004868 RID: 18536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EAF")]
		public TeamData TeamData
		{
			[Token(Token = "0x6004867")]
			[Address(RVA = "0x96E6", Offset = "0x96E6", VA = "0x96E6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004868")]
			[Address(RVA = "0x96E7", Offset = "0x96E7", VA = "0x96E7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06004869 RID: 18537 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600486A RID: 18538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB0")]
		public List<GetTeamRewardsAns.Types.BossRewardInfo> CaptainRewards
		{
			[Token(Token = "0x6004869")]
			[Address(RVA = "0x96E8", Offset = "0x96E8", VA = "0x96E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600486A")]
			[Address(RVA = "0x96E9", Offset = "0x96E9", VA = "0x96E9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x0600486B RID: 18539 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600486C RID: 18540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB1")]
		public List<GetTeamRewardsAns.Types.BossRewardInfo> AssistantRewards
		{
			[Token(Token = "0x600486B")]
			[Address(RVA = "0x96EA", Offset = "0x96EA", VA = "0x96EA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600486C")]
			[Address(RVA = "0x96EB", Offset = "0x96EB", VA = "0x96EB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x0600486D RID: 18541 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600486E RID: 18542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB2")]
		public List<GetTeamRewardsAns.Types.BossRewardInfo> RawRewards
		{
			[Token(Token = "0x600486D")]
			[Address(RVA = "0x96EC", Offset = "0x96EC", VA = "0x96EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600486E")]
			[Address(RVA = "0x96ED", Offset = "0x96ED", VA = "0x96ED")]
			set
			{
			}
		}

		// Token: 0x0600486F RID: 18543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600486F")]
		[Address(RVA = "0x96EE", Offset = "0x96EE", VA = "0x96EE")]
		public TeamAndRewardsData(TeamData teamData, IList<GetTeamRewardsAns.Types.BossRewardInfo> rewards)
		{
		}

		// Token: 0x040027AB RID: 10155
		[Token(Token = "0x40027AB")]
		[FieldOffset(Offset = "0x8")]
		public TeamRewardState State;

		// Token: 0x040027AF RID: 10159
		[Token(Token = "0x40027AF")]
		[FieldOffset(Offset = "0x18")]
		private List<GetTeamRewardsAns.Types.BossRewardInfo> _rawRewards;
	}
}
