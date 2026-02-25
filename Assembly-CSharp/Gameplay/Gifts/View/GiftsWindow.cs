using System;
using Core.Data;
using Gameplay.Gifts.Controller;
using Gameplay.Gifts.Events;
using Gameplay.Gifts.Model;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Gifts.View
{
	// Token: 0x0200070A RID: 1802
	[Token(Token = "0x200070A")]
	public class GiftsWindow : ClosableBaseWindow<GiftsWindow.GiftsWindowArgs>
	{
		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06002B1E RID: 11038 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000833")]
		public override string WindowId
		{
			[Token(Token = "0x6002B1E")]
			[Address(RVA = "0x7BB9", Offset = "0x7BB9", VA = "0x7BB9", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B1F")]
		[Address(RVA = "0x7BBA", Offset = "0x7BBA", VA = "0x7BBA")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B20")]
		[Address(RVA = "0x7BBB", Offset = "0x7BBB", VA = "0x7BBB", Slot = "22")]
		protected override void OnShow(GiftsWindow.GiftsWindowArgs args)
		{
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B21")]
		[Address(RVA = "0x7BBC", Offset = "0x7BBC", VA = "0x7BBC")]
		private void SetupMVC()
		{
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B22")]
		[Address(RVA = "0x7BBD", Offset = "0x7BBD", VA = "0x7BBD")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B23")]
		[Address(RVA = "0x7BBE", Offset = "0x7BBE", VA = "0x7BBE")]
		public GiftsWindow()
		{
		}

		// Token: 0x0400178F RID: 6031
		[Token(Token = "0x400178F")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Gifts/GiftsWindow";

		// Token: 0x04001790 RID: 6032
		[Token(Token = "0x4001790")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GiftsView _giftsView;

		// Token: 0x04001791 RID: 6033
		[Token(Token = "0x4001791")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UserView _userView;

		// Token: 0x04001792 RID: 6034
		[Token(Token = "0x4001792")]
		[FieldOffset(Offset = "0x44")]
		private GiftsModel _model;

		// Token: 0x04001793 RID: 6035
		[Token(Token = "0x4001793")]
		[FieldOffset(Offset = "0x48")]
		private GiftsEvents _events;

		// Token: 0x04001794 RID: 6036
		[Token(Token = "0x4001794")]
		[FieldOffset(Offset = "0x4C")]
		private GiftsController _controller;

		// Token: 0x04001795 RID: 6037
		[Token(Token = "0x4001795")]
		[FieldOffset(Offset = "0x50")]
		private GiftsViewMediator _mediator;

		// Token: 0x04001796 RID: 6038
		[Token(Token = "0x4001796")]
		[FieldOffset(Offset = "0x54")]
		private bool _mvcSetUp;

		// Token: 0x0200070B RID: 1803
		[Token(Token = "0x200070B")]
		public class GiftsWindowArgs : BaseWindowArgs
		{
			// Token: 0x06002B24 RID: 11044 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002B24")]
			[Address(RVA = "0x7BBF", Offset = "0x7BBF", VA = "0x7BBF")]
			public GiftsWindowArgs(UserData owner)
			{
			}

			// Token: 0x04001797 RID: 6039
			[Token(Token = "0x4001797")]
			[FieldOffset(Offset = "0x18")]
			public UserData Owner;
		}
	}
}
