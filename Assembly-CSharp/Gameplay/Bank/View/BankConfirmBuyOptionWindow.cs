using System;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C33 RID: 3123
	[Token(Token = "0x2000C33")]
	public class BankConfirmBuyOptionWindow : BaseDialogWindow<BankConfirmBuyOptionWindow.BankConfirmBuyOptionWindowArgs>
	{
		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06004C28 RID: 19496 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F59")]
		public override string WindowId
		{
			[Token(Token = "0x6004C28")]
			[Address(RVA = "0x9A6C", Offset = "0x9A6C", VA = "0x9A6C", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004C29 RID: 19497 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004C29")]
		[Address(RVA = "0x9A6D", Offset = "0x9A6D", VA = "0x9A6D")]
		public static BankConfirmBuyOptionWindow Show(BankOptionData bankOptionData, Action<BankOptionData> resultCallback)
		{
			return null;
		}

		// Token: 0x06004C2A RID: 19498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C2A")]
		[Address(RVA = "0x9A6E", Offset = "0x9A6E", VA = "0x9A6E", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x06004C2B RID: 19499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C2B")]
		[Address(RVA = "0x9A6F", Offset = "0x9A6F", VA = "0x9A6F")]
		private void BankOptionViewOnBuyButtonClickEvent(IBankOptionView bankOptionView)
		{
		}

		// Token: 0x06004C2C RID: 19500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C2C")]
		[Address(RVA = "0x9A70", Offset = "0x9A70", VA = "0x9A70", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06004C2D RID: 19501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C2D")]
		[Address(RVA = "0x9A71", Offset = "0x9A71", VA = "0x9A71")]
		public BankConfirmBuyOptionWindow()
		{
		}

		// Token: 0x04002977 RID: 10615
		[Token(Token = "0x4002977")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Bank/BankConfirmBuyOptionWindow";

		// Token: 0x04002978 RID: 10616
		[Token(Token = "0x4002978")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BankOptionView _bankOptionViewPrefab;

		// Token: 0x04002979 RID: 10617
		[Token(Token = "0x4002979")]
		[FieldOffset(Offset = "0x54")]
		private IBankOptionView _bankOptionView;

		// Token: 0x02000C34 RID: 3124
		[Token(Token = "0x2000C34")]
		public class BankConfirmBuyOptionWindowArgs : BaseDialogWindow<BankConfirmBuyOptionWindow.BankConfirmBuyOptionWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06004C2E RID: 19502 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004C2E")]
			[Address(RVA = "0x9A72", Offset = "0x9A72", VA = "0x9A72")]
			public BankConfirmBuyOptionWindowArgs()
			{
			}

			// Token: 0x0400297A RID: 10618
			[Token(Token = "0x400297A")]
			[FieldOffset(Offset = "0x2C")]
			public BankOptionData BankOptionData;

			// Token: 0x0400297B RID: 10619
			[Token(Token = "0x400297B")]
			[FieldOffset(Offset = "0x30")]
			public Action<BankOptionData> ResultCallback;
		}
	}
}
