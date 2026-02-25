using System;
using Gameplay.Boss.Controller;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Boss.View.TeamsTab
{
	// Token: 0x02000B58 RID: 2904
	[Token(Token = "0x2000B58")]
	public class BossTeamsView : AbstractBossWindowView<BossTeamsView, BossTeamsViewMediator>
	{
		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x06004649 RID: 17993 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DD9")]
		public BossPossibleEmptyWindowStateController StateController
		{
			[Token(Token = "0x6004649")]
			[Address(RVA = "0x94E2", Offset = "0x94E2", VA = "0x94E2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x0600464A RID: 17994 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DDA")]
		public BossTeamsListAdapter ListAdapter
		{
			[Token(Token = "0x600464A")]
			[Address(RVA = "0x94E3", Offset = "0x94E3", VA = "0x94E3")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600464B")]
		[Address(RVA = "0x94E4", Offset = "0x94E4", VA = "0x94E4", Slot = "5")]
		protected override BossTeamsViewMediator CreateMediator()
		{
			return null;
		}

		// Token: 0x0600464C RID: 17996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600464C")]
		[Address(RVA = "0x94E5", Offset = "0x94E5", VA = "0x94E5")]
		public BossTeamsView()
		{
		}

		// Token: 0x0400266F RID: 9839
		[Token(Token = "0x400266F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private BossTeamsListAdapter _listAdapter;

		// Token: 0x04002670 RID: 9840
		[Token(Token = "0x4002670")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BossPossibleEmptyWindowStateController _stateController;
	}
}
