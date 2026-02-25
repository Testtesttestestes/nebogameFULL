using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Application.Managers;
using Core.Data;
using Core.Rounting;
using Gameplay.AccountLinker.ProgressSaver.Controller;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.UserInterface.View.Menu
{
	// Token: 0x020003D4 RID: 980
	[Token(Token = "0x20003D4")]
	public class MenuWindow : ClosableBaseWindow<MenuWindow.MenuWindowArgs>
	{
		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003ED")]
		public override string WindowId
		{
			[Token(Token = "0x60016FC")]
			[Address(RVA = "0x68BB", Offset = "0x68BB", VA = "0x68BB", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x060016FD RID: 5885 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003EE")]
		public MenuView MenuMenuView
		{
			[Token(Token = "0x60016FD")]
			[Address(RVA = "0x68BC", Offset = "0x68BC", VA = "0x68BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016FE")]
		[Address(RVA = "0x68BD", Offset = "0x68BD", VA = "0x68BD", Slot = "22")]
		protected override void OnShow(MenuWindow.MenuWindowArgs args)
		{
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016FF")]
		[Address(RVA = "0x68BE", Offset = "0x68BE", VA = "0x68BE", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001700")]
		[Address(RVA = "0x68BF", Offset = "0x68BF", VA = "0x68BF")]
		public void SelectTab(MenuWindow.MenuWindowArgs.SelectedTab tab, LocatorPayload payload)
		{
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001701")]
		[Address(RVA = "0x68C0", Offset = "0x68C0", VA = "0x68C0")]
		public MenuWindow()
		{
		}

		// Token: 0x04000C33 RID: 3123
		[Token(Token = "0x4000C33")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/MenuWindow";

		// Token: 0x04000C34 RID: 3124
		[Token(Token = "0x4000C34")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private MenuView _menuView;

		// Token: 0x04000C35 RID: 3125
		[Token(Token = "0x4000C35")]
		[FieldOffset(Offset = "0x40")]
		private ProgressSaverEnterPointFromMenuViewMediator _progresSaverMediator;

		// Token: 0x020003D5 RID: 981
		[Token(Token = "0x20003D5")]
		public class MenuWindowArgs : BaseWindowArgs
		{
			// Token: 0x170003EF RID: 1007
			// (get) Token: 0x06001702 RID: 5890 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003EF")]
			public UserData User
			{
				[Token(Token = "0x6001702")]
				[Address(RVA = "0x68C1", Offset = "0x68C1", VA = "0x68C1")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170003F0 RID: 1008
			// (get) Token: 0x06001703 RID: 5891 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003F0")]
			public IPlatformSigninProvider SiginProdider
			{
				[Token(Token = "0x6001703")]
				[Address(RVA = "0x68C2", Offset = "0x68C2", VA = "0x68C2")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170003F1 RID: 1009
			// (get) Token: 0x06001704 RID: 5892 RVA: 0x00005580 File Offset: 0x00003780
			[Token(Token = "0x170003F1")]
			public MenuWindow.MenuWindowArgs.SelectedTab Selected
			{
				[Token(Token = "0x6001704")]
				[Address(RVA = "0x68C3", Offset = "0x68C3", VA = "0x68C3")]
				[CompilerGenerated]
				get
				{
					return MenuWindow.MenuWindowArgs.SelectedTab.undefined;
				}
			}

			// Token: 0x170003F2 RID: 1010
			// (get) Token: 0x06001705 RID: 5893 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003F2")]
			public IReadOnlyDictionary<string, string> Payload
			{
				[Token(Token = "0x6001705")]
				[Address(RVA = "0x68C4", Offset = "0x68C4", VA = "0x68C4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06001706 RID: 5894 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001706")]
			[Address(RVA = "0x68C5", Offset = "0x68C5", VA = "0x68C5")]
			public MenuWindowArgs(UserData user, IPlatformSigninProvider siginProdider, MenuWindow.MenuWindowArgs.SelectedTab selectedTab, IReadOnlyDictionary<string, string> payload)
			{
			}

			// Token: 0x020003D6 RID: 982
			[Token(Token = "0x20003D6")]
			public enum SelectedTab
			{
				// Token: 0x04000C3B RID: 3131
				[Token(Token = "0x4000C3B")]
				undefined,
				// Token: 0x04000C3C RID: 3132
				[Token(Token = "0x4000C3C")]
				save_progress,
				// Token: 0x04000C3D RID: 3133
				[Token(Token = "0x4000C3D")]
				menu_settings,
				// Token: 0x04000C3E RID: 3134
				[Token(Token = "0x4000C3E")]
				notifications,
				// Token: 0x04000C3F RID: 3135
				[Token(Token = "0x4000C3F")]
				feedback
			}
		}
	}
}
