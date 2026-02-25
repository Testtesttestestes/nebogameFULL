using System;
using System.Runtime.CompilerServices;
using Gameplay.EndlessPaymentOptionsList.Control;
using Gameplay.EndlessPaymentOptionsList.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UI.Windows;

namespace Core.Gameplay.Managers.EndlessPaymentOptionsList
{
	// Token: 0x020011EF RID: 4591
	[Token(Token = "0x20011EF")]
	public class EndlessPaymentOptionsListManager : IGameManager, IBaseManager
	{
		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x06006D05 RID: 27909 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001631")]
		public string Name
		{
			[Token(Token = "0x6006D05")]
			[Address(RVA = "0xB7EE", Offset = "0xB7EE", VA = "0xB7EE", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002CD RID: 717
		// (add) Token: 0x06006D06 RID: 27910 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006D07 RID: 27911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002CD")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006D06")]
			[Address(RVA = "0xB7EF", Offset = "0xB7EF", VA = "0xB7EF", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006D07")]
			[Address(RVA = "0xB7F0", Offset = "0xB7F0", VA = "0xB7F0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002CE RID: 718
		// (add) Token: 0x06006D08 RID: 27912 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006D09 RID: 27913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002CE")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006D08")]
			[Address(RVA = "0xB7F1", Offset = "0xB7F1", VA = "0xB7F1", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006D09")]
			[Address(RVA = "0xB7F2", Offset = "0xB7F2", VA = "0xB7F2", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006D0A RID: 27914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D0A")]
		[Address(RVA = "0xB7F3", Offset = "0xB7F3", VA = "0xB7F3")]
		public EndlessPaymentOptionsListManager(IGame game)
		{
		}

		// Token: 0x06006D0B RID: 27915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D0B")]
		[Address(RVA = "0xB7F4", Offset = "0xB7F4", VA = "0xB7F4", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006D0C RID: 27916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D0C")]
		[Address(RVA = "0xB7F5", Offset = "0xB7F5", VA = "0xB7F5")]
		private void EndlessPaymentOptionsReceivedEventHandler()
		{
		}

		// Token: 0x06006D0D RID: 27917 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006D0D")]
		[Address(RVA = "0xB7F6", Offset = "0xB7F6", VA = "0xB7F6")]
		private PopupScheduleManager.Args GetArgs()
		{
			return null;
		}

		// Token: 0x06006D0E RID: 27918 RVA: 0x00014118 File Offset: 0x00012318
		[Token(Token = "0x6006D0E")]
		[Address(RVA = "0xB7F7", Offset = "0xB7F7", VA = "0xB7F7")]
		private bool CheckFreeOption()
		{
			return default(bool);
		}

		// Token: 0x06006D0F RID: 27919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D0F")]
		[Address(RVA = "0xB7F8", Offset = "0xB7F8", VA = "0xB7F8")]
		private void UnScheduleShow()
		{
		}

		// Token: 0x06006D10 RID: 27920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D10")]
		[Address(RVA = "0xB7F9", Offset = "0xB7F9", VA = "0xB7F9")]
		private void ShowEndlessPaymentOptionsListWindowScheduled()
		{
		}

		// Token: 0x06006D11 RID: 27921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D11")]
		[Address(RVA = "0xB7FA", Offset = "0xB7FA", VA = "0xB7FA")]
		private void ShowEndlessPaymentOptionsListWindow(EndlessPaymentOptionListData listData, WindowOpenReasonSource source = WindowOpenReasonSource.DefaultSource)
		{
		}

		// Token: 0x06006D12 RID: 27922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D12")]
		[Address(RVA = "0xB7FB", Offset = "0xB7FB", VA = "0xB7FB")]
		private void HandleControllerInitEvent()
		{
		}

		// Token: 0x06006D13 RID: 27923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D13")]
		[Address(RVA = "0xB7FC", Offset = "0xB7FC", VA = "0xB7FC", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x04003910 RID: 14608
		[Token(Token = "0x4003910")]
		[FieldOffset(Offset = "0x10")]
		private IGame _game;

		// Token: 0x04003911 RID: 14609
		[Token(Token = "0x4003911")]
		[FieldOffset(Offset = "0x14")]
		[CanBeNull]
		public EndlessPaymentOptionsListController Controller;
	}
}
