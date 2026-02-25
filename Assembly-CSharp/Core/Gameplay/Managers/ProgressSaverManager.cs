using System;
using System.Runtime.CompilerServices;
using Gameplay.AccountLinker;
using Gameplay.AccountLinker.ProgressSaver.Controller;
using Gameplay.AccountLinker.ProgressSaver.Model;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using UI.Windows;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001173 RID: 4467
	[Token(Token = "0x2001173")]
	public class ProgressSaverManager : IGameManager, IBaseManager
	{
		// Token: 0x14000292 RID: 658
		// (add) Token: 0x0600698B RID: 27019 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600698C RID: 27020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000292")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x600698B")]
			[Address(RVA = "0xB4AB", Offset = "0xB4AB", VA = "0xB4AB", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600698C")]
			[Address(RVA = "0xB4AC", Offset = "0xB4AC", VA = "0xB4AC", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000293 RID: 659
		// (add) Token: 0x0600698D RID: 27021 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600698E RID: 27022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000293")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x600698D")]
			[Address(RVA = "0xB4AD", Offset = "0xB4AD", VA = "0xB4AD", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600698E")]
			[Address(RVA = "0xB4AE", Offset = "0xB4AE", VA = "0xB4AE", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600698F RID: 27023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600698F")]
		[Address(RVA = "0xB4AF", Offset = "0xB4AF", VA = "0xB4AF")]
		public ProgressSaverManager(IGame game)
		{
		}

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x06006990 RID: 27024 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001598")]
		public ProgressSaverController Controller
		{
			[Token(Token = "0x6006990")]
			[Address(RVA = "0xB4B0", Offset = "0xB4B0", VA = "0xB4B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006991 RID: 27025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006991")]
		[Address(RVA = "0xB4B1", Offset = "0xB4B1", VA = "0xB4B1", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006992 RID: 27026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006992")]
		[Address(RVA = "0xB4B2", Offset = "0xB4B2", VA = "0xB4B2", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x06006993 RID: 27027 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001599")]
		public string Name
		{
			[Token(Token = "0x6006993")]
			[Address(RVA = "0xB4B3", Offset = "0xB4B3", VA = "0xB4B3", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006994 RID: 27028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006994")]
		[Address(RVA = "0xB4B4", Offset = "0xB4B4", VA = "0xB4B4")]
		private void ShowProgressSaverWindow()
		{
		}

		// Token: 0x06006995 RID: 27029 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006995")]
		[Address(RVA = "0xB4B5", Offset = "0xB4B5", VA = "0xB4B5")]
		public DialogWindow ShowAccountLinkDialogWindow()
		{
			return null;
		}

		// Token: 0x06006996 RID: 27030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006996")]
		[Address(RVA = "0xB4B6", Offset = "0xB4B6", VA = "0xB4B6")]
		public void SetView(UserInterfaceView view)
		{
		}

		// Token: 0x040037FF RID: 14335
		[Token(Token = "0x40037FF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string AssetResourcePath;

		// Token: 0x04003802 RID: 14338
		[Token(Token = "0x4003802")]
		[FieldOffset(Offset = "0x10")]
		private ProgressSaverModel _model;

		// Token: 0x04003803 RID: 14339
		[Token(Token = "0x4003803")]
		[FieldOffset(Offset = "0x14")]
		private AccountLinker _accountLinker;

		// Token: 0x04003804 RID: 14340
		[Token(Token = "0x4003804")]
		[FieldOffset(Offset = "0x18")]
		private ProgressSaverController _controller;

		// Token: 0x04003805 RID: 14341
		[Token(Token = "0x4003805")]
		[FieldOffset(Offset = "0x1C")]
		public readonly IGame Game;
	}
}
