using System;
using Gameplay.Bank.Controller;
using Il2CppDummyDll;
using TMPro;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C39 RID: 3129
	[Token(Token = "0x2000C39")]
	public class BankOptionInfoWindow : ClosableBaseWindow<BankOptionInfoWindowArgs>
	{
		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06004C46 RID: 19526 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F5F")]
		public override string WindowId
		{
			[Token(Token = "0x6004C46")]
			[Address(RVA = "0x9A89", Offset = "0x9A89", VA = "0x9A89", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06004C47 RID: 19527 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F60")]
		public TextMeshProUGUI BottomDescription
		{
			[Token(Token = "0x6004C47")]
			[Address(RVA = "0x9A8A", Offset = "0x9A8A", VA = "0x9A8A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06004C48 RID: 19528 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F61")]
		public BankOptionView BankOptionView
		{
			[Token(Token = "0x6004C48")]
			[Address(RVA = "0x9A8B", Offset = "0x9A8B", VA = "0x9A8B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06004C49 RID: 19529 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F62")]
		public Button PrevButton
		{
			[Token(Token = "0x6004C49")]
			[Address(RVA = "0x9A8C", Offset = "0x9A8C", VA = "0x9A8C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06004C4A RID: 19530 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F63")]
		public Button NextButton
		{
			[Token(Token = "0x6004C4A")]
			[Address(RVA = "0x9A8D", Offset = "0x9A8D", VA = "0x9A8D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x06004C4B RID: 19531 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F64")]
		public BankOptionArtikulContainerView ArtikulContainerView
		{
			[Token(Token = "0x6004C4B")]
			[Address(RVA = "0x9A8E", Offset = "0x9A8E", VA = "0x9A8E")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004C4C RID: 19532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C4C")]
		[Address(RVA = "0x9A8F", Offset = "0x9A8F", VA = "0x9A8F", Slot = "22")]
		protected override void OnShow(BankOptionInfoWindowArgs args)
		{
		}

		// Token: 0x06004C4D RID: 19533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C4D")]
		[Address(RVA = "0x9A90", Offset = "0x9A90", VA = "0x9A90", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06004C4E RID: 19534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C4E")]
		[Address(RVA = "0x9A91", Offset = "0x9A91", VA = "0x9A91")]
		public BankOptionInfoWindow()
		{
		}

		// Token: 0x04002998 RID: 10648
		[Token(Token = "0x4002998")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Bank/BankOptionInfoWindow";

		// Token: 0x04002999 RID: 10649
		[Token(Token = "0x4002999")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private BankOptionArtikulContainerView _artikulContainerView;

		// Token: 0x0400299A RID: 10650
		[Token(Token = "0x400299A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _prevButton;

		// Token: 0x0400299B RID: 10651
		[Token(Token = "0x400299B")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Button _nextButton;

		// Token: 0x0400299C RID: 10652
		[Token(Token = "0x400299C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BankOptionView _bankOptionView;

		// Token: 0x0400299D RID: 10653
		[Token(Token = "0x400299D")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private TextMeshProUGUI _bottomDescription;

		// Token: 0x0400299E RID: 10654
		[Token(Token = "0x400299E")]
		[FieldOffset(Offset = "0x50")]
		private BankOptionInfoWindowMediator _mediator;
	}
}
