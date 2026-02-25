using System;
using AssetContent;
using Gameplay.Bank.Controller;
using Il2CppDummyDll;
using UI;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C4C RID: 3148
	[Token(Token = "0x2000C4C")]
	public class PaymentBonusView : MonoBehaviour, IToolTipDataProvider
	{
		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06004CBF RID: 19647 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F79")]
		public BacktimeViewUGUI BacktimeView
		{
			[Token(Token = "0x6004CBF")]
			[Address(RVA = "0x9AFC", Offset = "0x9AFC", VA = "0x9AFC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06004CC0 RID: 19648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F7A")]
		public GameAnimatedButton GameAnimatedButton
		{
			[Token(Token = "0x6004CC0")]
			[Address(RVA = "0x9AFD", Offset = "0x9AFD", VA = "0x9AFD")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004CC1 RID: 19649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CC1")]
		[Address(RVA = "0x9AFE", Offset = "0x9AFE", VA = "0x9AFE")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004CC2 RID: 19650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CC2")]
		[Address(RVA = "0x9AFF", Offset = "0x9AFF", VA = "0x9AFF")]
		private void Start()
		{
		}

		// Token: 0x06004CC3 RID: 19651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CC3")]
		[Address(RVA = "0x9B00", Offset = "0x9B00", VA = "0x9B00")]
		private void GameAnimationViewOnAnimationReadyEvent(GameAnimationView animation)
		{
		}

		// Token: 0x06004CC4 RID: 19652 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004CC4")]
		[Address(RVA = "0x9B01", Offset = "0x9B01", VA = "0x9B01", Slot = "4")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06004CC5 RID: 19653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CC5")]
		[Address(RVA = "0x9B02", Offset = "0x9B02", VA = "0x9B02")]
		public PaymentBonusView()
		{
		}

		// Token: 0x040029E6 RID: 10726
		[Token(Token = "0x40029E6")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAnimatedButton _gameAnimatedButton;

		// Token: 0x040029E7 RID: 10727
		[Token(Token = "0x40029E7")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x040029E8 RID: 10728
		[Token(Token = "0x40029E8")]
		[FieldOffset(Offset = "0x18")]
		private PaymentBonusViewMediator _mediator;
	}
}
