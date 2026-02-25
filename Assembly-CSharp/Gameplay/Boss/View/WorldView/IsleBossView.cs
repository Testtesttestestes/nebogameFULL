using System;
using System.Runtime.CompilerServices;
using Gameplay.Boss.Controller;
using Gameplay.Boss.Model;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.ProgressBars;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Boss.View.WorldView
{
	// Token: 0x02000B53 RID: 2899
	[Token(Token = "0x2000B53")]
	public class IsleBossView : BaseIsleMonsterView, IToolTipDataProvider
	{
		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06004622 RID: 17954 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DD0")]
		public Canvas Canvas
		{
			[Token(Token = "0x6004622")]
			[Address(RVA = "0x94BB", Offset = "0x94BB", VA = "0x94BB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x06004623 RID: 17955 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DD1")]
		public BacktimeViewUGUI BacktimeView
		{
			[Token(Token = "0x6004623")]
			[Address(RVA = "0x94BC", Offset = "0x94BC", VA = "0x94BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06004624 RID: 17956 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DD2")]
		public TextMeshProUGUI HealthLabel
		{
			[Token(Token = "0x6004624")]
			[Address(RVA = "0x94BD", Offset = "0x94BD", VA = "0x94BD")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06004625 RID: 17957 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DD3")]
		public ProgressBar ProgressBar
		{
			[Token(Token = "0x6004625")]
			[Address(RVA = "0x94BE", Offset = "0x94BE", VA = "0x94BE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06004626 RID: 17958 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004627 RID: 17959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DD4")]
		public BossInstance BossInstance
		{
			[Token(Token = "0x6004626")]
			[Address(RVA = "0x94BF", Offset = "0x94BF", VA = "0x94BF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004627")]
			[Address(RVA = "0x94C0", Offset = "0x94C0", VA = "0x94C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004628 RID: 17960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004628")]
		[Address(RVA = "0x94C1", Offset = "0x94C1", VA = "0x94C1")]
		public void Init(BossInstance instance)
		{
		}

		// Token: 0x06004629 RID: 17961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004629")]
		[Address(RVA = "0x94C2", Offset = "0x94C2", VA = "0x94C2", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600462A RID: 17962 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600462A")]
		[Address(RVA = "0x94C3", Offset = "0x94C3", VA = "0x94C3", Slot = "12")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x0600462B RID: 17963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600462B")]
		[Address(RVA = "0x94C4", Offset = "0x94C4", VA = "0x94C4")]
		public IsleBossView()
		{
		}

		// Token: 0x0400265E RID: 9822
		[Token(Token = "0x400265E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ProgressBar _progressBar;

		// Token: 0x0400265F RID: 9823
		[Token(Token = "0x400265F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _healthLabel;

		// Token: 0x04002660 RID: 9824
		[Token(Token = "0x4002660")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x04002661 RID: 9825
		[Token(Token = "0x4002661")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Canvas _canvas;

		// Token: 0x04002663 RID: 9827
		[Token(Token = "0x4002663")]
		[FieldOffset(Offset = "0x40")]
		private IsleBossViewMediator _mediator;
	}
}
