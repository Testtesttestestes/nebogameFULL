using System;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Boss.View.Rewarding
{
	// Token: 0x02000B60 RID: 2912
	[Token(Token = "0x2000B60")]
	public class BossRewardingView : MonoBehaviour
	{
		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06004697 RID: 18071 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DF7")]
		public TextMeshProUGUI HintText
		{
			[Token(Token = "0x6004697")]
			[Address(RVA = "0x952D", Offset = "0x952D", VA = "0x952D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06004698 RID: 18072 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DF8")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6004698")]
			[Address(RVA = "0x952E", Offset = "0x952E", VA = "0x952E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06004699 RID: 18073 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DF9")]
		public Button PrevButton
		{
			[Token(Token = "0x6004699")]
			[Address(RVA = "0x952F", Offset = "0x952F", VA = "0x952F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x0600469A RID: 18074 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DFA")]
		public Button NextButton
		{
			[Token(Token = "0x600469A")]
			[Address(RVA = "0x9530", Offset = "0x9530", VA = "0x9530")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x0600469B RID: 18075 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DFB")]
		public BossRewardingAssistantsView AssistantsView
		{
			[Token(Token = "0x600469B")]
			[Address(RVA = "0x9531", Offset = "0x9531", VA = "0x9531")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x0600469C RID: 18076 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DFC")]
		public BossRewardingCaptainView CaptainView
		{
			[Token(Token = "0x600469C")]
			[Address(RVA = "0x9532", Offset = "0x9532", VA = "0x9532")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x0600469D RID: 18077 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DFD")]
		public Button ApplyButton
		{
			[Token(Token = "0x600469D")]
			[Address(RVA = "0x9533", Offset = "0x9533", VA = "0x9533")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x0600469E RID: 18078 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DFE")]
		public Button ResetButton
		{
			[Token(Token = "0x600469E")]
			[Address(RVA = "0x9534", Offset = "0x9534", VA = "0x9534")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x0600469F RID: 18079 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DFF")]
		public Button RandomButton
		{
			[Token(Token = "0x600469F")]
			[Address(RVA = "0x9535", Offset = "0x9535", VA = "0x9535")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x060046A0 RID: 18080 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E00")]
		public BacktimeViewUGUI BacktimeView
		{
			[Token(Token = "0x60046A0")]
			[Address(RVA = "0x9536", Offset = "0x9536", VA = "0x9536")]
			get
			{
				return null;
			}
		}

		// Token: 0x060046A1 RID: 18081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046A1")]
		[Address(RVA = "0x9537", Offset = "0x9537", VA = "0x9537")]
		public BossRewardingView()
		{
		}

		// Token: 0x040026A0 RID: 9888
		[Token(Token = "0x40026A0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private BossRewardingAssistantsView _assistantsView;

		// Token: 0x040026A1 RID: 9889
		[Token(Token = "0x40026A1")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private BossRewardingCaptainView _captainView;

		// Token: 0x040026A2 RID: 9890
		[Token(Token = "0x40026A2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _randomButton;

		// Token: 0x040026A3 RID: 9891
		[Token(Token = "0x40026A3")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _applyButton;

		// Token: 0x040026A4 RID: 9892
		[Token(Token = "0x40026A4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _resetButton;

		// Token: 0x040026A5 RID: 9893
		[Token(Token = "0x40026A5")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x040026A6 RID: 9894
		[Token(Token = "0x40026A6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040026A7 RID: 9895
		[Token(Token = "0x40026A7")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _hintText;

		// Token: 0x040026A8 RID: 9896
		[Token(Token = "0x40026A8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _prevButton;

		// Token: 0x040026A9 RID: 9897
		[Token(Token = "0x40026A9")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Button _nextButton;
	}
}
