using System;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C3B RID: 3131
	[Token(Token = "0x2000C3B")]
	public class BankOptionListElement : BankOptionView
	{
		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06004C50 RID: 19536 RVA: 0x0000E0A0 File Offset: 0x0000C2A0
		[Token(Token = "0x17000F65")]
		protected override bool ShowFaqButton
		{
			[Token(Token = "0x6004C50")]
			[Address(RVA = "0x9A93", Offset = "0x9A93", VA = "0x9A93", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F66 RID: 3942
		// (set) Token: 0x06004C51 RID: 19537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F66")]
		public bool Selected
		{
			[Token(Token = "0x6004C51")]
			[Address(RVA = "0x1D11", Offset = "0x1D11", VA = "0x1D11")]
			set
			{
			}
		}

		// Token: 0x06004C52 RID: 19538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C52")]
		[Address(RVA = "0x9A94", Offset = "0x9A94", VA = "0x9A94")]
		private void Start()
		{
		}

		// Token: 0x06004C53 RID: 19539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C53")]
		[Address(RVA = "0x9A95", Offset = "0x9A95", VA = "0x9A95", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06004C54 RID: 19540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C54")]
		[Address(RVA = "0x9A96", Offset = "0x9A96", VA = "0x9A96")]
		private void ButtonClickedEventHandler()
		{
		}

		// Token: 0x06004C55 RID: 19541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C55")]
		[Address(RVA = "0x9A97", Offset = "0x9A97", VA = "0x9A97")]
		public void Init(BankOptionListElement.BankOptionListElementArgs args)
		{
		}

		// Token: 0x06004C56 RID: 19542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C56")]
		[Address(RVA = "0x9A98", Offset = "0x9A98", VA = "0x9A98", Slot = "26")]
		protected override void BuyButtonClickHandler()
		{
		}

		// Token: 0x06004C57 RID: 19543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C57")]
		[Address(RVA = "0x9A99", Offset = "0x9A99", VA = "0x9A99", Slot = "25")]
		protected override void FaqButtonClickHandler()
		{
		}

		// Token: 0x06004C58 RID: 19544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C58")]
		[Address(RVA = "0x9A9A", Offset = "0x9A9A", VA = "0x9A9A")]
		public BankOptionListElement()
		{
		}

		// Token: 0x040029A0 RID: 10656
		[Token(Token = "0x40029A0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected Image _selectedImage;

		// Token: 0x040029A1 RID: 10657
		[Token(Token = "0x40029A1")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		protected Button _button;

		// Token: 0x040029A2 RID: 10658
		[Token(Token = "0x40029A2")]
		[FieldOffset(Offset = "0x70")]
		private BankOptionListElement.BankOptionListElementArgs _args;

		// Token: 0x02000C3C RID: 3132
		[Token(Token = "0x2000C3C")]
		public class BankOptionListElementArgs
		{
			// Token: 0x06004C59 RID: 19545 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004C59")]
			[Address(RVA = "0x9A9B", Offset = "0x9A9B", VA = "0x9A9B")]
			public BankOptionListElementArgs()
			{
			}

			// Token: 0x040029A3 RID: 10659
			[Token(Token = "0x40029A3")]
			[FieldOffset(Offset = "0x8")]
			public BankOptionViewArgs BankOptionViewArgs;

			// Token: 0x040029A4 RID: 10660
			[Token(Token = "0x40029A4")]
			[FieldOffset(Offset = "0xC")]
			public Action<BankOptionData> BuyButtonClickHandler;

			// Token: 0x040029A5 RID: 10661
			[Token(Token = "0x40029A5")]
			[FieldOffset(Offset = "0x10")]
			public Action<BankOptionData> FaqButtonClickHandler;

			// Token: 0x040029A6 RID: 10662
			[Token(Token = "0x40029A6")]
			[FieldOffset(Offset = "0x14")]
			public Action<BankOptionListElement.BankOptionListElementArgs> ForceViewSelectedEvent;
		}
	}
}
