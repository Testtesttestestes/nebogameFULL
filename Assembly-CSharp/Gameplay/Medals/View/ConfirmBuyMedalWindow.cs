using System;
using Core.Data;
using Gameplay.Discounts.View;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Medals.View
{
	// Token: 0x020005F2 RID: 1522
	[Token(Token = "0x20005F2")]
	public class ConfirmBuyMedalWindow : BaseDialogWindow<ConfirmBuyMedalWindow.ConfirmBuyMedalWindowArgs>
	{
		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060024E7 RID: 9447 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006E0")]
		public override string WindowId
		{
			[Token(Token = "0x60024E7")]
			[Address(RVA = "0x7632", Offset = "0x7632", VA = "0x7632", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024E8")]
		[Address(RVA = "0x7633", Offset = "0x7633", VA = "0x7633", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60024E9")]
		[Address(RVA = "0x7634", Offset = "0x7634", VA = "0x7634")]
		public static ConfirmBuyMedalWindow Show(MedalData medal, Action<MedalData> resultCallback)
		{
			return null;
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024EA")]
		[Address(RVA = "0x7635", Offset = "0x7635", VA = "0x7635")]
		public ConfirmBuyMedalWindow()
		{
		}

		// Token: 0x04001424 RID: 5156
		[Token(Token = "0x4001424")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MedalView _medalView;

		// Token: 0x04001425 RID: 5157
		[Token(Token = "0x4001425")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private DiscountGroup _discountGroup;

		// Token: 0x04001426 RID: 5158
		[Token(Token = "0x4001426")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Medals/ConfirmBuyMedalWindow";

		// Token: 0x020005F3 RID: 1523
		[Token(Token = "0x20005F3")]
		public class ConfirmBuyMedalWindowArgs : BaseDialogWindow<ConfirmBuyMedalWindow.ConfirmBuyMedalWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x060024EB RID: 9451 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60024EB")]
			[Address(RVA = "0x7636", Offset = "0x7636", VA = "0x7636")]
			public ConfirmBuyMedalWindowArgs()
			{
			}

			// Token: 0x04001427 RID: 5159
			[Token(Token = "0x4001427")]
			[FieldOffset(Offset = "0x2C")]
			public MedalData MedalData;
		}
	}
}
