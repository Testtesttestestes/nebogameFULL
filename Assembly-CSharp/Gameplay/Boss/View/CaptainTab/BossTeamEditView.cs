using System;
using System.Runtime.CompilerServices;
using Gameplay.Boss.Controller;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B83 RID: 2947
	[Token(Token = "0x2000B83")]
	public class BossTeamEditView : AbstractBossWindowView<BossTeamEditView, BossTeamEditViewMediator>
	{
		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06004796 RID: 18326 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E4F")]
		public UserDataSortControlView SortControl
		{
			[Token(Token = "0x6004796")]
			[Address(RVA = "0x9626", Offset = "0x9626", VA = "0x9626")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06004797 RID: 18327 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E50")]
		public BossTeamEditListAdapter ListAdapter
		{
			[Token(Token = "0x6004797")]
			[Address(RVA = "0x9627", Offset = "0x9627", VA = "0x9627")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06004798 RID: 18328 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E51")]
		public Button ConfirmButton
		{
			[Token(Token = "0x6004798")]
			[Address(RVA = "0x9628", Offset = "0x9628", VA = "0x9628")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06004799 RID: 18329 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E52")]
		public Button CancelButton
		{
			[Token(Token = "0x6004799")]
			[Address(RVA = "0x9629", Offset = "0x9629", VA = "0x9629")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x0600479A RID: 18330 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E53")]
		public BossTeamView TeamView
		{
			[Token(Token = "0x600479A")]
			[Address(RVA = "0x962A", Offset = "0x962A", VA = "0x962A")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001C5 RID: 453
		// (add) Token: 0x0600479B RID: 18331 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600479C RID: 18332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001C5")]
		public event Action ExitEditModeEvent
		{
			[Token(Token = "0x600479B")]
			[Address(RVA = "0x1B4A", Offset = "0x1B4A", VA = "0x1B4A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600479C")]
			[Address(RVA = "0x962B", Offset = "0x962B", VA = "0x962B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600479D RID: 18333 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600479D")]
		[Address(RVA = "0x962C", Offset = "0x962C", VA = "0x962C", Slot = "5")]
		protected override BossTeamEditViewMediator CreateMediator()
		{
			return null;
		}

		// Token: 0x0600479E RID: 18334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600479E")]
		[Address(RVA = "0x962D", Offset = "0x962D", VA = "0x962D")]
		public void ExitEditMode()
		{
		}

		// Token: 0x0600479F RID: 18335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600479F")]
		[Address(RVA = "0x962E", Offset = "0x962E", VA = "0x962E")]
		public BossTeamEditView()
		{
		}

		// Token: 0x04002750 RID: 10064
		[Token(Token = "0x4002750")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private BossTeamView _teamView;

		// Token: 0x04002751 RID: 10065
		[Token(Token = "0x4002751")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _confirmButton;

		// Token: 0x04002752 RID: 10066
		[Token(Token = "0x4002752")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private BossTeamEditListAdapter _listAdapter;

		// Token: 0x04002753 RID: 10067
		[Token(Token = "0x4002753")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UserDataSortControlView _sortControl;

		// Token: 0x04002754 RID: 10068
		[Token(Token = "0x4002754")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Button _cancelButton;
	}
}
