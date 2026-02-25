using System;
using System.Collections.Generic;
using Core.Data;
using Core.Gameplay;
using Gameplay.Bank.View;
using Gameplay.SpecialOffers.Controller;
using Gameplay.SpecialOffers.Events;
using Gameplay.SpecialOffers.Model;
using Gameplay.SpecialOffers.View.Picker;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Windows;
using UnityEngine;

namespace Gameplay.SpecialOffers.View
{
	// Token: 0x020004FA RID: 1274
	[Token(Token = "0x20004FA")]
	public class OptionsOfferWindow : ClosableBaseWindow<OptionsOfferWindow.OptionsOfferWindowArgs>, IOptionsOfferWindow
	{
		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001E65 RID: 7781 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000584")]
		public override string WindowId
		{
			[Token(Token = "0x6001E65")]
			[Address(RVA = "0x6FDE", Offset = "0x6FDE", VA = "0x6FDE", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x000064E0 File Offset: 0x000046E0
		[Token(Token = "0x17000585")]
		public override bool IsFullscreenWindow
		{
			[Token(Token = "0x6001E66")]
			[Address(RVA = "0x6FDF", Offset = "0x6FDF", VA = "0x6FDF", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001E67 RID: 7783 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000586")]
		public SpecialOfferPicker Picker
		{
			[Token(Token = "0x6001E67")]
			[Address(RVA = "0x6FE0", Offset = "0x6FE0", VA = "0x6FE0", Slot = "32")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000587")]
		public IndexButtonBasic InBankButton
		{
			[Token(Token = "0x6001E68")]
			[Address(RVA = "0x6FE1", Offset = "0x6FE1", VA = "0x6FE1", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001E69 RID: 7785 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000588")]
		public OptionBoughtView OptionBoughtView
		{
			[Token(Token = "0x6001E69")]
			[Address(RVA = "0x6FE2", Offset = "0x6FE2", VA = "0x6FE2", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E6A")]
		[Address(RVA = "0x6FE3", Offset = "0x6FE3", VA = "0x6FE3", Slot = "22")]
		protected override void OnShow(OptionsOfferWindow.OptionsOfferWindowArgs args)
		{
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E6B")]
		[Address(RVA = "0x6FE4", Offset = "0x6FE4", VA = "0x6FE4", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E6C")]
		[Address(RVA = "0x6FE5", Offset = "0x6FE5", VA = "0x6FE5", Slot = "30")]
		public void Init(IList<BankOptionListElement.BankOptionListElementArgs> optionArgs)
		{
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E6D")]
		[Address(RVA = "0x6FE6", Offset = "0x6FE6", VA = "0x6FE6")]
		private void SetupMVC()
		{
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E6E")]
		[Address(RVA = "0x6FE7", Offset = "0x6FE7", VA = "0x6FE7")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E6F")]
		[Address(RVA = "0x6FE8", Offset = "0x6FE8", VA = "0x6FE8")]
		public OptionsOfferWindow()
		{
		}

		// Token: 0x04001081 RID: 4225
		[Token(Token = "0x4001081")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/SpecialOffers/OptionsOfferWindow";

		// Token: 0x04001082 RID: 4226
		[Token(Token = "0x4001082")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private SpecialOfferPicker _picker;

		// Token: 0x04001083 RID: 4227
		[Token(Token = "0x4001083")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private IndexButtonBasic _inBankButton;

		// Token: 0x04001084 RID: 4228
		[Token(Token = "0x4001084")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001085 RID: 4229
		[Token(Token = "0x4001085")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001086 RID: 4230
		[Token(Token = "0x4001086")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private OptionBoughtView _optionBoughtView;

		// Token: 0x04001087 RID: 4231
		[Token(Token = "0x4001087")]
		[FieldOffset(Offset = "0x50")]
		private OptionsOfferController _controller;

		// Token: 0x04001088 RID: 4232
		[Token(Token = "0x4001088")]
		[FieldOffset(Offset = "0x54")]
		private OptionsOfferModel _model;

		// Token: 0x04001089 RID: 4233
		[Token(Token = "0x4001089")]
		[FieldOffset(Offset = "0x58")]
		private OptionsOfferEvents _events;

		// Token: 0x0400108A RID: 4234
		[Token(Token = "0x400108A")]
		[FieldOffset(Offset = "0x5C")]
		private OptionsOfferViewMediator _mediator;

		// Token: 0x020004FB RID: 1275
		[Token(Token = "0x20004FB")]
		public class OptionsOfferWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001E70 RID: 7792 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E70")]
			[Address(RVA = "0x6FE9", Offset = "0x6FE9", VA = "0x6FE9")]
			public OptionsOfferWindowArgs()
			{
			}

			// Token: 0x0400108B RID: 4235
			[Token(Token = "0x400108B")]
			[FieldOffset(Offset = "0x18")]
			public UserData User;

			// Token: 0x0400108C RID: 4236
			[Token(Token = "0x400108C")]
			[FieldOffset(Offset = "0x1C")]
			public IList<uint> OptionIds;

			// Token: 0x0400108D RID: 4237
			[Token(Token = "0x400108D")]
			[FieldOffset(Offset = "0x20")]
			public string Title;

			// Token: 0x0400108E RID: 4238
			[Token(Token = "0x400108E")]
			[FieldOffset(Offset = "0x24")]
			public string Description;

			// Token: 0x0400108F RID: 4239
			[Token(Token = "0x400108F")]
			[FieldOffset(Offset = "0x28")]
			public IGame Game;
		}
	}
}
