using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using AssetContent.Loaders;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.ProgressBars;
using UI.Elements.RightPanel;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B7D RID: 2941
	[Token(Token = "0x2000B7D")]
	public class BossInfoView : MonoBehaviour
	{
		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06004763 RID: 18275 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E3E")]
		public TextMeshProUGUI HealthLabel
		{
			[Token(Token = "0x6004763")]
			[Address(RVA = "0x95F7", Offset = "0x95F7", VA = "0x95F7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06004764 RID: 18276 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E3F")]
		public GameImageLoader DominateCultIcon
		{
			[Token(Token = "0x6004764")]
			[Address(RVA = "0x95F8", Offset = "0x95F8", VA = "0x95F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06004765 RID: 18277 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E40")]
		public ProgressBar ProgressBar
		{
			[Token(Token = "0x6004765")]
			[Address(RVA = "0x95F9", Offset = "0x95F9", VA = "0x95F9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06004766 RID: 18278 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E41")]
		public BacktimeViewUGUI BacktimeViewUGUI
		{
			[Token(Token = "0x6004766")]
			[Address(RVA = "0x95FA", Offset = "0x95FA", VA = "0x95FA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06004767 RID: 18279 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E42")]
		public GameAssetViewRawImage Avatar
		{
			[Token(Token = "0x6004767")]
			[Address(RVA = "0x95FB", Offset = "0x95FB", VA = "0x95FB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06004768 RID: 18280 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E43")]
		public TitleWithLevel TitleWithLevel
		{
			[Token(Token = "0x6004768")]
			[Address(RVA = "0x95FC", Offset = "0x95FC", VA = "0x95FC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06004769 RID: 18281 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E44")]
		public Button InfoButton
		{
			[Token(Token = "0x6004769")]
			[Address(RVA = "0x95FD", Offset = "0x95FD", VA = "0x95FD")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x0600476A RID: 18282 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E45")]
		public Image CultIcon
		{
			[Token(Token = "0x600476A")]
			[Address(RVA = "0x95FE", Offset = "0x95FE", VA = "0x95FE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x0600476B RID: 18283 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E46")]
		public BossSkillInfoView SkillsInfoView
		{
			[Token(Token = "0x600476B")]
			[Address(RVA = "0x95FF", Offset = "0x95FF", VA = "0x95FF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x0600476C RID: 18284 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E47")]
		public List<BossAttackOptionView> AttackOptionViews
		{
			[Token(Token = "0x600476C")]
			[Address(RVA = "0x9600", Offset = "0x9600", VA = "0x9600")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001C2 RID: 450
		// (add) Token: 0x0600476D RID: 18285 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600476E RID: 18286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001C2")]
		public event Action<BossInfo.BossAttackOption, BossInfo.BossAttackOption.BossAttackOptionVariant> AttackButtonClickEvent
		{
			[Token(Token = "0x600476D")]
			[Address(RVA = "0x1B47", Offset = "0x1B47", VA = "0x1B47")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600476E")]
			[Address(RVA = "0x9601", Offset = "0x9601", VA = "0x9601")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000E48 RID: 3656
		// (set) Token: 0x0600476F RID: 18287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E48")]
		public IList<BossInfo.BossAttackOption> AttackOptions
		{
			[Token(Token = "0x600476F")]
			[Address(RVA = "0x1B55", Offset = "0x1B55", VA = "0x1B55")]
			set
			{
			}
		}

		// Token: 0x06004770 RID: 18288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004770")]
		[Address(RVA = "0x9602", Offset = "0x9602", VA = "0x9602")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004771 RID: 18289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004771")]
		[Address(RVA = "0x9603", Offset = "0x9603", VA = "0x9603")]
		private void OptionViewOnAttackButtonClickEvent(BossInfo.BossAttackOption arg1, BossInfo.BossAttackOption.BossAttackOptionVariant arg2)
		{
		}

		// Token: 0x06004772 RID: 18290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004772")]
		[Address(RVA = "0x9604", Offset = "0x9604", VA = "0x9604")]
		public BossInfoView()
		{
		}

		// Token: 0x04002731 RID: 10033
		[Token(Token = "0x4002731")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TitleWithLevel _titleWithLevel;

		// Token: 0x04002732 RID: 10034
		[Token(Token = "0x4002732")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ProgressBar _progressBar;

		// Token: 0x04002733 RID: 10035
		[Token(Token = "0x4002733")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameAssetViewRawImage _avatar;

		// Token: 0x04002734 RID: 10036
		[Token(Token = "0x4002734")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _infoButton;

		// Token: 0x04002735 RID: 10037
		[Token(Token = "0x4002735")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _cultIcon;

		// Token: 0x04002736 RID: 10038
		[Token(Token = "0x4002736")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeViewUGUI;

		// Token: 0x04002737 RID: 10039
		[Token(Token = "0x4002737")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _attackOptionContainer;

		// Token: 0x04002738 RID: 10040
		[Token(Token = "0x4002738")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private BossSkillInfoView _skillsInfoView;

		// Token: 0x04002739 RID: 10041
		[Token(Token = "0x4002739")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameImageLoader _dominateCultIcon;

		// Token: 0x0400273A RID: 10042
		[Token(Token = "0x400273A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _healthLabel;

		// Token: 0x0400273B RID: 10043
		[Token(Token = "0x400273B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BossAttackOptionView _attackOptionPrefab;

		// Token: 0x0400273C RID: 10044
		[Token(Token = "0x400273C")]
		[FieldOffset(Offset = "0x3C")]
		private List<BossAttackOptionView> _attackOptionViews;
	}
}
