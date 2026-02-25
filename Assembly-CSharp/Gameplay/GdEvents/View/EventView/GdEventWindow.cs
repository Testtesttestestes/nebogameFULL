using System;
using Core.MVC.Interfaces;
using Gameplay.GdEvents.Control;
using Il2CppDummyDll;
using TMPro;
using UI.Tabs;
using UI.Windows;
using UnityEngine;

namespace Gameplay.GdEvents.View.EventView
{
	// Token: 0x02000746 RID: 1862
	[Token(Token = "0x2000746")]
	public class GdEventWindow : ClosableBaseWindow<GdEventWindow.GdEventWindowArgs>
	{
		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06002C5A RID: 11354 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000876")]
		public override string WindowId
		{
			[Token(Token = "0x6002C5A")]
			[Address(RVA = "0x7CE9", Offset = "0x7CE9", VA = "0x7CE9", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06002C5B RID: 11355 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000877")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6002C5B")]
			[Address(RVA = "0x7CEA", Offset = "0x7CEA", VA = "0x7CEA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06002C5C RID: 11356 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000878")]
		public BlueTabBar TabBar
		{
			[Token(Token = "0x6002C5C")]
			[Address(RVA = "0x7CEB", Offset = "0x7CEB", VA = "0x7CEB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06002C5D RID: 11357 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000879")]
		public ContentContainerView Content
		{
			[Token(Token = "0x6002C5D")]
			[Address(RVA = "0x7CEC", Offset = "0x7CEC", VA = "0x7CEC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C5E")]
		[Address(RVA = "0x7CED", Offset = "0x7CED", VA = "0x7CED", Slot = "22")]
		protected override void OnShow(GdEventWindow.GdEventWindowArgs args)
		{
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C5F")]
		[Address(RVA = "0x7CEE", Offset = "0x7CEE", VA = "0x7CEE", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C60")]
		[Address(RVA = "0x7CEF", Offset = "0x7CEF", VA = "0x7CEF")]
		public GdEventWindow()
		{
		}

		// Token: 0x04001854 RID: 6228
		[Token(Token = "0x4001854")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/GdEvents/GdEventWindow";

		// Token: 0x04001855 RID: 6229
		[Token(Token = "0x4001855")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private BlueTabBar _tabBar;

		// Token: 0x04001856 RID: 6230
		[Token(Token = "0x4001856")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001857 RID: 6231
		[Token(Token = "0x4001857")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private ContentContainerView _content;

		// Token: 0x04001858 RID: 6232
		[Token(Token = "0x4001858")]
		[FieldOffset(Offset = "0x48")]
		private IViewMediator _mediator;

		// Token: 0x02000747 RID: 1863
		[Token(Token = "0x2000747")]
		public class GdEventWindowArgs : BaseWindowArgs
		{
			// Token: 0x06002C61 RID: 11361 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002C61")]
			[Address(RVA = "0x7CF0", Offset = "0x7CF0", VA = "0x7CF0")]
			public GdEventWindowArgs(GdEventsController controller)
			{
			}

			// Token: 0x04001859 RID: 6233
			[Token(Token = "0x4001859")]
			[FieldOffset(Offset = "0x18")]
			public GdEventsController Controller;
		}
	}
}
