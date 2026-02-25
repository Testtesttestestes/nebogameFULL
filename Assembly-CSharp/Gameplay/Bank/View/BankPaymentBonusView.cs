using System;
using AssetContent;
using Gameplay.Bank.Controller;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C44 RID: 3140
	[Token(Token = "0x2000C44")]
	public class BankPaymentBonusView : MonoBehaviour
	{
		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06004C98 RID: 19608 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F6F")]
		public TextMeshProUGUI BonusDescription
		{
			[Token(Token = "0x6004C98")]
			[Address(RVA = "0x9AD9", Offset = "0x9AD9", VA = "0x9AD9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06004C99 RID: 19609 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F70")]
		public RewardsRender RewardsRender
		{
			[Token(Token = "0x6004C99")]
			[Address(RVA = "0x9ADA", Offset = "0x9ADA", VA = "0x9ADA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06004C9A RID: 19610 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F71")]
		public GameRawImage BannerView
		{
			[Token(Token = "0x6004C9A")]
			[Address(RVA = "0x9ADB", Offset = "0x9ADB", VA = "0x9ADB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06004C9B RID: 19611 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F72")]
		public BacktimeViewUGUI BacktimeView
		{
			[Token(Token = "0x6004C9B")]
			[Address(RVA = "0x9ADC", Offset = "0x9ADC", VA = "0x9ADC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004C9C RID: 19612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C9C")]
		[Address(RVA = "0x9ADD", Offset = "0x9ADD", VA = "0x9ADD")]
		private void Start()
		{
		}

		// Token: 0x06004C9D RID: 19613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C9D")]
		[Address(RVA = "0x9ADE", Offset = "0x9ADE", VA = "0x9ADE")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004C9E RID: 19614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C9E")]
		[Address(RVA = "0x9ADF", Offset = "0x9ADF", VA = "0x9ADF")]
		public BankPaymentBonusView()
		{
		}

		// Token: 0x040029CC RID: 10700
		[Token(Token = "0x40029CC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private BankGalleryView _bankGalleryView;

		// Token: 0x040029CD RID: 10701
		[Token(Token = "0x40029CD")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameRawImage _bannerView;

		// Token: 0x040029CE RID: 10702
		[Token(Token = "0x40029CE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x040029CF RID: 10703
		[Token(Token = "0x40029CF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RewardsRender _rewardsRender;

		// Token: 0x040029D0 RID: 10704
		[Token(Token = "0x40029D0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _bonusDescription;

		// Token: 0x040029D1 RID: 10705
		[Token(Token = "0x40029D1")]
		[FieldOffset(Offset = "0x24")]
		private BankPaymentBonusViewMediator _mediator;
	}
}
