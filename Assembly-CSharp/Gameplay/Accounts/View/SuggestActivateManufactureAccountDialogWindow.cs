using System;
using AssetContent;
using Gameplay.Accounts.Model.Data;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Accounts.View
{
	// Token: 0x02000DCE RID: 3534
	[Token(Token = "0x2000DCE")]
	public class SuggestActivateManufactureAccountDialogWindow : BaseDialogWindow<SuggestActivateManufactureAccountDialogWindow.SuggestActivateManufactureAccountDialogWindowArgs>
	{
		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x06005631 RID: 22065 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001187")]
		public override string WindowId
		{
			[Token(Token = "0x6005631")]
			[Address(RVA = "0xA3CF", Offset = "0xA3CF", VA = "0xA3CF", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005632 RID: 22066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005632")]
		[Address(RVA = "0xA3D0", Offset = "0xA3D0", VA = "0xA3D0", Slot = "22")]
		protected override void OnShow(SuggestActivateManufactureAccountDialogWindow.SuggestActivateManufactureAccountDialogWindowArgs args)
		{
		}

		// Token: 0x06005633 RID: 22067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005633")]
		[Address(RVA = "0xA3D1", Offset = "0xA3D1", VA = "0xA3D1")]
		public static void Show(SuggestActivateManufactureAccountDialogWindow.SuggestActivateManufactureAccountDialogWindowArgs args)
		{
		}

		// Token: 0x06005634 RID: 22068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005634")]
		[Address(RVA = "0xA3D2", Offset = "0xA3D2", VA = "0xA3D2")]
		public SuggestActivateManufactureAccountDialogWindow()
		{
		}

		// Token: 0x04002EC3 RID: 11971
		[Token(Token = "0x4002EC3")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Accounts/SuggestActivateManufactureAccountDialogWindow";

		// Token: 0x04002EC4 RID: 11972
		[Token(Token = "0x4002EC4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameRawImage _image;

		// Token: 0x04002EC5 RID: 11973
		[Token(Token = "0x4002EC5")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04002EC6 RID: 11974
		[Token(Token = "0x4002EC6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AccountDic.Types.ContentResource _contentResource;

		// Token: 0x02000DCF RID: 3535
		[Token(Token = "0x2000DCF")]
		public class SuggestActivateManufactureAccountDialogWindowArgs : BaseDialogWindow<SuggestActivateManufactureAccountDialogWindow.SuggestActivateManufactureAccountDialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06005635 RID: 22069 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005635")]
			[Address(RVA = "0xA3D3", Offset = "0xA3D3", VA = "0xA3D3")]
			public SuggestActivateManufactureAccountDialogWindowArgs(ManufactureAccount accountDataDecorator)
			{
			}

			// Token: 0x04002EC7 RID: 11975
			[Token(Token = "0x4002EC7")]
			[FieldOffset(Offset = "0x2C")]
			public ManufactureAccount AccountDataDecorator;
		}
	}
}
