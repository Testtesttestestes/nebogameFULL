using System;
using Core.MVC.Interfaces;
using Gameplay.GdEvents.Control;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.GdEvents.View.EventsList
{
	// Token: 0x02000735 RID: 1845
	[Token(Token = "0x2000735")]
	public class GdEventListWindow : ClosableBaseWindow<GdEventListWindow.GdEventListWindowArgs>
	{
		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06002C09 RID: 11273 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000862")]
		public override string WindowId
		{
			[Token(Token = "0x6002C09")]
			[Address(RVA = "0x7C99", Offset = "0x7C99", VA = "0x7C99", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C0A")]
		[Address(RVA = "0x7C9A", Offset = "0x7C9A", VA = "0x7C9A", Slot = "22")]
		protected override void OnShow(GdEventListWindow.GdEventListWindowArgs args)
		{
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C0B")]
		[Address(RVA = "0x7C9B", Offset = "0x7C9B", VA = "0x7C9B")]
		private void ListOnInitialized()
		{
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C0C")]
		[Address(RVA = "0x7C9C", Offset = "0x7C9C", VA = "0x7C9C", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C0D")]
		[Address(RVA = "0x7C9D", Offset = "0x7C9D", VA = "0x7C9D")]
		public GdEventListWindow()
		{
		}

		// Token: 0x0400181F RID: 6175
		[Token(Token = "0x400181F")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/GdEvents/GdEventListWindow";

		// Token: 0x04001820 RID: 6176
		[Token(Token = "0x4001820")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GdEventsListView _view;

		// Token: 0x04001821 RID: 6177
		[Token(Token = "0x4001821")]
		[FieldOffset(Offset = "0x40")]
		private IViewMediator _mediator;

		// Token: 0x02000736 RID: 1846
		[Token(Token = "0x2000736")]
		public class GdEventListWindowArgs : BaseWindowArgs
		{
			// Token: 0x06002C0E RID: 11278 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C0E")]
			[Address(RVA = "0x7C9E", Offset = "0x7C9E", VA = "0x7C9E")]
			public GdEventListWindowArgs(GdEventsController controller)
			{
			}

			// Token: 0x04001822 RID: 6178
			[Token(Token = "0x4001822")]
			[FieldOffset(Offset = "0x18")]
			public GdEventsController Controller;
		}
	}
}
