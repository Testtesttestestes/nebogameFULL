using System;
using Gameplay.Boss.Model;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Boss.View.TeamsTab
{
	// Token: 0x02000B54 RID: 2900
	[Token(Token = "0x2000B54")]
	public class BossTeamMemberView : MonoBehaviour
	{
		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x0600462C RID: 17964 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600462D RID: 17965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DD5")]
		public TeamRewardData.TeamMemberData TeamMemberData
		{
			[Token(Token = "0x600462C")]
			[Address(RVA = "0x94C5", Offset = "0x94C5", VA = "0x94C5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600462D")]
			[Address(RVA = "0x94C6", Offset = "0x94C6", VA = "0x94C6")]
			set
			{
			}
		}

		// Token: 0x0600462E RID: 17966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600462E")]
		[Address(RVA = "0x94C7", Offset = "0x94C7", VA = "0x94C7")]
		private void HandleMemberDataChanged(TeamRewardData.TeamMemberData from, TeamRewardData.TeamMemberData to)
		{
		}

		// Token: 0x0600462F RID: 17967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600462F")]
		[Address(RVA = "0x94C8", Offset = "0x94C8", VA = "0x94C8")]
		private void TeamMemberDataOnUserDataChangedEvent()
		{
		}

		// Token: 0x06004630 RID: 17968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004630")]
		[Address(RVA = "0x94C9", Offset = "0x94C9", VA = "0x94C9")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004631 RID: 17969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004631")]
		[Address(RVA = "0x94CA", Offset = "0x94CA", VA = "0x94CA")]
		public BossTeamMemberView()
		{
		}

		// Token: 0x04002664 RID: 9828
		[Token(Token = "0x4002664")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private UserView _userView;

		// Token: 0x04002665 RID: 9829
		[Token(Token = "0x4002665")]
		[FieldOffset(Offset = "0x14")]
		private TeamRewardData.TeamMemberData _teamMemberData;
	}
}
