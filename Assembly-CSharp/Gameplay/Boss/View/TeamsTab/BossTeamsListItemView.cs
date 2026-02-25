using System;
using System.Runtime.CompilerServices;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Boss.View.TeamsTab
{
	// Token: 0x02000B57 RID: 2903
	[Token(Token = "0x2000B57")]
	public class BossTeamsListItemView : MonoBehaviour
	{
		// Token: 0x140001B2 RID: 434
		// (add) Token: 0x06004641 RID: 17985 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004642 RID: 17986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001B2")]
		public event Action<TeamRewardData> ButtonClickedEvent
		{
			[Token(Token = "0x6004641")]
			[Address(RVA = "0x94DA", Offset = "0x94DA", VA = "0x94DA")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004642")]
			[Address(RVA = "0x94DB", Offset = "0x94DB", VA = "0x94DB")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004643 RID: 17987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004643")]
		[Address(RVA = "0x94DC", Offset = "0x94DC", VA = "0x94DC")]
		private void Awake()
		{
		}

		// Token: 0x06004644 RID: 17988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004644")]
		[Address(RVA = "0x94DD", Offset = "0x94DD", VA = "0x94DD")]
		private void ButtonClickedHandler()
		{
		}

		// Token: 0x06004645 RID: 17989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004645")]
		[Address(RVA = "0x94DE", Offset = "0x94DE", VA = "0x94DE")]
		private void OnDestroy()
		{
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06004646 RID: 17990 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004647 RID: 17991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DD8")]
		public TeamRewardData Data
		{
			[Token(Token = "0x6004646")]
			[Address(RVA = "0x94DF", Offset = "0x94DF", VA = "0x94DF")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004647")]
			[Address(RVA = "0x94E0", Offset = "0x94E0", VA = "0x94E0")]
			set
			{
			}
		}

		// Token: 0x06004648 RID: 17992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004648")]
		[Address(RVA = "0x94E1", Offset = "0x94E1", VA = "0x94E1")]
		public BossTeamsListItemView()
		{
		}

		// Token: 0x04002669 RID: 9833
		[Token(Token = "0x4002669")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x0400266A RID: 9834
		[Token(Token = "0x400266A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private BossTeamMemberView[] _teamMembers;

		// Token: 0x0400266B RID: 9835
		[Token(Token = "0x400266B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _noButtonLabel;

		// Token: 0x0400266C RID: 9836
		[Token(Token = "0x400266C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _button;

		// Token: 0x0400266E RID: 9838
		[Token(Token = "0x400266E")]
		[FieldOffset(Offset = "0x24")]
		private TeamRewardData _teamRewardData;
	}
}
