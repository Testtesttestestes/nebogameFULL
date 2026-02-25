using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.FeedbackForm.Model;
using Gameplay.FeedbackForm.Model.Controll;
using Gameplay.FeedbackForm.Model.Source;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UI.Windows;
using UnityEngine;

namespace Gameplay.FeedbackForm.View
{
	// Token: 0x02000816 RID: 2070
	[Token(Token = "0x2000816")]
	public class FeedbackFormWindow : ClosableBaseWindow<FeedbackFormWindow.FeedbackFormWindowArgs>
	{
		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x060030D1 RID: 12497 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000988")]
		public override string WindowId
		{
			[Token(Token = "0x60030D1")]
			[Address(RVA = "0x8136", Offset = "0x8136", VA = "0x8136", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x060030D2 RID: 12498 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000989")]
		public FeedbackFormView View
		{
			[Token(Token = "0x60030D2")]
			[Address(RVA = "0x8137", Offset = "0x8137", VA = "0x8137")]
			get
			{
				return null;
			}
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030D3")]
		[Address(RVA = "0x8138", Offset = "0x8138", VA = "0x8138", Slot = "22")]
		protected override void OnShow(FeedbackFormWindow.FeedbackFormWindowArgs args)
		{
		}

		// Token: 0x060030D4 RID: 12500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030D4")]
		[Address(RVA = "0x8139", Offset = "0x8139", VA = "0x8139", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030D5")]
		[Address(RVA = "0x813A", Offset = "0x813A", VA = "0x813A", Slot = "25")]
		protected override void HandleCloseButton()
		{
		}

		// Token: 0x060030D6 RID: 12502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030D6")]
		[Address(RVA = "0x813B", Offset = "0x813B", VA = "0x813B", Slot = "29")]
		protected override void HandleBackButton()
		{
		}

		// Token: 0x060030D7 RID: 12503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030D7")]
		[Address(RVA = "0x813C", Offset = "0x813C", VA = "0x813C")]
		public FeedbackFormWindow()
		{
		}

		// Token: 0x04001A9E RID: 6814
		[Token(Token = "0x4001A9E")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/FeedbackForm/FeedbackFormWindow";

		// Token: 0x04001A9F RID: 6815
		[Token(Token = "0x4001A9F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private FeedbackFormView _view;

		// Token: 0x04001AA0 RID: 6816
		[Token(Token = "0x4001AA0")]
		[FieldOffset(Offset = "0x40")]
		private FeedbackFormController _controller;

		// Token: 0x04001AA1 RID: 6817
		[Token(Token = "0x4001AA1")]
		[FieldOffset(Offset = "0x44")]
		private FeedbackFormViewMediator _mediator;

		// Token: 0x04001AA2 RID: 6818
		[Token(Token = "0x4001AA2")]
		[FieldOffset(Offset = "0x48")]
		private FeedbackFormModel _model;

		// Token: 0x02000817 RID: 2071
		[Token(Token = "0x2000817")]
		public class FeedbackFormWindowArgs : BaseWindowArgs
		{
			// Token: 0x1700098A RID: 2442
			// (get) Token: 0x060030D9 RID: 12505 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700098A")]
			[NotNull]
			public new IFeedbackFormSource Source
			{
				[Token(Token = "0x60030D9")]
				[Address(RVA = "0x813E", Offset = "0x813E", VA = "0x813E")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x060030DA RID: 12506 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030DA")]
			[Address(RVA = "0x813F", Offset = "0x813F", VA = "0x813F")]
			public FeedbackFormWindowArgs(IFeedbackFormSource source)
			{
			}

			// Token: 0x04001AA3 RID: 6819
			[Token(Token = "0x4001AA3")]
			[FieldOffset(Offset = "0x18")]
			[CanBeNull]
			public UserData User;

			// Token: 0x04001AA5 RID: 6821
			[Token(Token = "0x4001AA5")]
			[FieldOffset(Offset = "0x20")]
			public Themes Theme;
		}
	}
}
