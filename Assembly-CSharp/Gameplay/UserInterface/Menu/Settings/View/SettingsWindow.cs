using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.UserInterface.Menu.Settings.Control;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.UserInterface.Menu.Settings.View
{
	// Token: 0x020003DC RID: 988
	[Token(Token = "0x20003DC")]
	public class SettingsWindow : ClosableBaseWindow<SettingsWindow.SettingsWindowArgs>
	{
		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000400")]
		public override string WindowId
		{
			[Token(Token = "0x6001723")]
			[Address(RVA = "0x68E2", Offset = "0x68E2", VA = "0x68E2", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001724")]
		[Address(RVA = "0x68E3", Offset = "0x68E3", VA = "0x68E3", Slot = "18")]
		protected override void OnShow(BaseWindowArgs args)
		{
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001725")]
		[Address(RVA = "0x68E4", Offset = "0x68E4", VA = "0x68E4", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001726")]
		[Address(RVA = "0x68E5", Offset = "0x68E5", VA = "0x68E5")]
		public SettingsWindow()
		{
		}

		// Token: 0x04000C51 RID: 3153
		[Token(Token = "0x4000C51")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/SettingsWindow";

		// Token: 0x04000C52 RID: 3154
		[Token(Token = "0x4000C52")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private SettingsView _settingsView;

		// Token: 0x04000C53 RID: 3155
		[Token(Token = "0x4000C53")]
		[FieldOffset(Offset = "0x40")]
		private SettingsViewMediator _mediator;

		// Token: 0x020003DD RID: 989
		[Token(Token = "0x20003DD")]
		public class SettingsWindowArgs : BaseWindowArgs
		{
			// Token: 0x17000401 RID: 1025
			// (get) Token: 0x06001727 RID: 5927 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000401")]
			public UserData User
			{
				[Token(Token = "0x6001727")]
				[Address(RVA = "0x68E6", Offset = "0x68E6", VA = "0x68E6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000402 RID: 1026
			// (get) Token: 0x06001728 RID: 5928 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000402")]
			public IGame Game
			{
				[Token(Token = "0x6001728")]
				[Address(RVA = "0x68E7", Offset = "0x68E7", VA = "0x68E7")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06001729 RID: 5929 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001729")]
			[Address(RVA = "0x68E8", Offset = "0x68E8", VA = "0x68E8")]
			public SettingsWindowArgs(IGame game, UserData user)
			{
			}
		}
	}
}
