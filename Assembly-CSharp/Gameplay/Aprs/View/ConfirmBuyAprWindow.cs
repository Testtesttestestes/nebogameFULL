using System;
using System.Collections.Generic;
using Gameplay.Aprs.Model;
using Gameplay.Discounts.Model;
using Gameplay.Discounts.View;
using Il2CppDummyDll;
using Protocol.Consts;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Aprs.View
{
	// Token: 0x02000D57 RID: 3415
	[Token(Token = "0x2000D57")]
	public class ConfirmBuyAprWindow : BaseDialogWindow<ConfirmBuyAprWindow.ConfirmBuyAprWindowArgs>, IDiscountTarget
	{
		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x060053C1 RID: 21441 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001104")]
		public DiscountTargets[] DiscountTargets
		{
			[Token(Token = "0x60053C1")]
			[Address(RVA = "0xA180", Offset = "0xA180", VA = "0xA180", Slot = "30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x060053C2 RID: 21442 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001105")]
		public override string WindowId
		{
			[Token(Token = "0x60053C2")]
			[Address(RVA = "0xA181", Offset = "0xA181", VA = "0xA181", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060053C3 RID: 21443 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60053C3")]
		[Address(RVA = "0xA182", Offset = "0xA182", VA = "0xA182")]
		public static ConfirmBuyAprWindow Show(AprData apr, Action<AprData> resultCallback)
		{
			return null;
		}

		// Token: 0x060053C4 RID: 21444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053C4")]
		[Address(RVA = "0xA183", Offset = "0xA183", VA = "0xA183", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x060053C5 RID: 21445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053C5")]
		[Address(RVA = "0xA184", Offset = "0xA184", VA = "0xA184", Slot = "31")]
		public void Setup(IEnumerable<IDiscountArgs> value)
		{
		}

		// Token: 0x060053C6 RID: 21446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053C6")]
		[Address(RVA = "0xA185", Offset = "0xA185", VA = "0xA185")]
		public ConfirmBuyAprWindow()
		{
		}

		// Token: 0x04002D67 RID: 11623
		[Token(Token = "0x4002D67")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AprView _aprView;

		// Token: 0x04002D68 RID: 11624
		[Token(Token = "0x4002D68")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private DiscountGroup _discountGroup;

		// Token: 0x04002D69 RID: 11625
		[Token(Token = "0x4002D69")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private DiscountTargets[] _discountTargets;

		// Token: 0x04002D6A RID: 11626
		[Token(Token = "0x4002D6A")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Aprs/ConfirmBuyAprWindow";

		// Token: 0x02000D58 RID: 3416
		[Token(Token = "0x2000D58")]
		public class ConfirmBuyAprWindowArgs : BaseDialogWindow<ConfirmBuyAprWindow.ConfirmBuyAprWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x060053C7 RID: 21447 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60053C7")]
			[Address(RVA = "0xA186", Offset = "0xA186", VA = "0xA186")]
			public ConfirmBuyAprWindowArgs(AprData apr)
			{
			}

			// Token: 0x04002D6B RID: 11627
			[Token(Token = "0x4002D6B")]
			[FieldOffset(Offset = "0x2C")]
			public AprData AprData;
		}
	}
}
