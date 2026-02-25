using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Dict;
using Il2CppDummyDll;
using Protocol.Notifier;

namespace Core.Application.Managers
{
	// Token: 0x02001252 RID: 4690
	[Token(Token = "0x2001252")]
	public class NotificationManager : INotificationManager, IAppManager, IBaseManager, IDisposable
	{
		// Token: 0x140002ED RID: 749
		// (add) Token: 0x06006F2E RID: 28462 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F2F RID: 28463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002ED")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006F2E")]
			[Address(RVA = "0xB9A9", Offset = "0xB9A9", VA = "0xB9A9", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F2F")]
			[Address(RVA = "0xB9AA", Offset = "0xB9AA", VA = "0xB9AA", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002EE RID: 750
		// (add) Token: 0x06006F30 RID: 28464 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F31 RID: 28465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002EE")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006F30")]
			[Address(RVA = "0xB9AB", Offset = "0xB9AB", VA = "0xB9AB", Slot = "9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F31")]
			[Address(RVA = "0xB9AC", Offset = "0xB9AC", VA = "0xB9AC", Slot = "10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006F32 RID: 28466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F32")]
		[Address(RVA = "0xB9AD", Offset = "0xB9AD", VA = "0xB9AD")]
		public NotificationManager()
		{
		}

		// Token: 0x06006F33 RID: 28467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F33")]
		[Address(RVA = "0xB9AE", Offset = "0xB9AE", VA = "0xB9AE", Slot = "11")]
		public void Init()
		{
		}

		// Token: 0x06006F34 RID: 28468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F34")]
		[Address(RVA = "0xB9AF", Offset = "0xB9AF", VA = "0xB9AF")]
		private void ImplementationOnInitCompleteEvent(IBaseManager manager)
		{
		}

		// Token: 0x06006F35 RID: 28469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F35")]
		[Address(RVA = "0xB9B0", Offset = "0xB9B0", VA = "0xB9B0")]
		private void ImplementationOnDeinitCompleteEvent(IBaseManager manager)
		{
		}

		// Token: 0x06006F36 RID: 28470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F36")]
		[Address(RVA = "0xB9B1", Offset = "0xB9B1", VA = "0xB9B1", Slot = "12")]
		public void Deinit()
		{
		}

		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x06006F37 RID: 28471 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016B4")]
		public string Name
		{
			[Token(Token = "0x6006F37")]
			[Address(RVA = "0xB9B2", Offset = "0xB9B2", VA = "0xB9B2", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006F38 RID: 28472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F38")]
		[Address(RVA = "0xB9B3", Offset = "0xB9B3", VA = "0xB9B3", Slot = "14")]
		public void Dispose()
		{
		}

		// Token: 0x06006F39 RID: 28473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F39")]
		[Address(RVA = "0xB9B4", Offset = "0xB9B4", VA = "0xB9B4", Slot = "4")]
		public void ScheduleNotification(int id, string title, string message, int delay, Dictionary<string, object> developerPayload, LocalNotifications channel)
		{
		}

		// Token: 0x06006F3A RID: 28474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F3A")]
		[Address(RVA = "0xB9B5", Offset = "0xB9B5", VA = "0xB9B5", Slot = "5")]
		public void ClearNotification(int id)
		{
		}

		// Token: 0x06006F3B RID: 28475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F3B")]
		[Address(RVA = "0xB9B6", Offset = "0xB9B6", VA = "0xB9B6", Slot = "6")]
		public void InitChannels(IDictProvider dictProvider)
		{
		}

		// Token: 0x04003A18 RID: 14872
		[Token(Token = "0x4003A18")]
		[FieldOffset(Offset = "0x10")]
		private INotificationManager _implementation;
	}
}
