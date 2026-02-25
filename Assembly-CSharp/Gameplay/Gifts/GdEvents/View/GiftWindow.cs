using System;
using Gameplay.Gifts.GdEvents.Control;
using Gameplay.Gifts.GdEvents.Model;
using Gameplay.Gifts.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Gifts.GdEvents.View
{
	// Token: 0x0200070E RID: 1806
	[Token(Token = "0x200070E")]
	public class GiftWindow : ClosableBaseWindow<GiftWindow.GiftWindowArgs>
	{
		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06002B39 RID: 11065 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700083C")]
		public override string WindowId
		{
			[Token(Token = "0x6002B39")]
			[Address(RVA = "0x7BD4", Offset = "0x7BD4", VA = "0x7BD4", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06002B3A RID: 11066 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700083D")]
		public GiftView GiftView
		{
			[Token(Token = "0x6002B3A")]
			[Address(RVA = "0x7BD5", Offset = "0x7BD5", VA = "0x7BD5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06002B3B RID: 11067 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700083E")]
		public TextMeshProUGUI Annotation
		{
			[Token(Token = "0x6002B3B")]
			[Address(RVA = "0x7BD6", Offset = "0x7BD6", VA = "0x7BD6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B3C")]
		[Address(RVA = "0x7BD7", Offset = "0x7BD7", VA = "0x7BD7", Slot = "18")]
		protected override void OnShow(BaseWindowArgs args)
		{
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B3D")]
		[Address(RVA = "0x7BD8", Offset = "0x7BD8", VA = "0x7BD8", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B3E")]
		[Address(RVA = "0x7BD9", Offset = "0x7BD9", VA = "0x7BD9")]
		public GiftWindow()
		{
		}

		// Token: 0x040017A0 RID: 6048
		[Token(Token = "0x40017A0")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Gifts/GdEvents/GiftWindow";

		// Token: 0x040017A1 RID: 6049
		[Token(Token = "0x40017A1")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GiftView _giftView;

		// Token: 0x040017A2 RID: 6050
		[Token(Token = "0x40017A2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _annotation;

		// Token: 0x040017A3 RID: 6051
		[Token(Token = "0x40017A3")]
		[FieldOffset(Offset = "0x44")]
		private GiftController _controller;

		// Token: 0x040017A4 RID: 6052
		[Token(Token = "0x40017A4")]
		[FieldOffset(Offset = "0x48")]
		private GiftModel _model;

		// Token: 0x040017A5 RID: 6053
		[Token(Token = "0x40017A5")]
		[FieldOffset(Offset = "0x4C")]
		private GiftWindowMediator _mediator;

		// Token: 0x0200070F RID: 1807
		[Token(Token = "0x200070F")]
		public class GiftWindowArgs : BaseWindowArgs
		{
			// Token: 0x06002B3F RID: 11071 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002B3F")]
			[Address(RVA = "0x7BDA", Offset = "0x7BDA", VA = "0x7BDA")]
			public GiftWindowArgs(SocialGiftDic gift)
			{
			}

			// Token: 0x040017A6 RID: 6054
			[Token(Token = "0x40017A6")]
			[FieldOffset(Offset = "0x18")]
			public readonly SocialGiftDic Gift;
		}
	}
}
