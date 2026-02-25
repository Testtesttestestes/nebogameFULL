using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay.Managers;
using Core.Gameplay.Managers.GameActivityRouting;
using Gameplay.World.Events;
using Il2CppDummyDll;
using MVC;
using Protocol.Announcements;
using UI.Windows;

namespace Gameplay.Announcements.Model
{
	// Token: 0x02000DA4 RID: 3492
	[Token(Token = "0x2000DA4")]
	public class AnnouncementsModel : AbstractModel
	{
		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x0600554E RID: 21838 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600554F RID: 21839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001154")]
		public IDictProvider DictProvider
		{
			[Token(Token = "0x600554E")]
			[Address(RVA = "0xA2EF", Offset = "0xA2EF", VA = "0xA2EF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600554F")]
			[Address(RVA = "0xA2F0", Offset = "0xA2F0", VA = "0xA2F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x06005550 RID: 21840 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005551 RID: 21841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001155")]
		public IRouter Router
		{
			[Token(Token = "0x6005550")]
			[Address(RVA = "0xA2F1", Offset = "0xA2F1", VA = "0xA2F1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005551")]
			[Address(RVA = "0xA2F2", Offset = "0xA2F2", VA = "0xA2F2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x06005552 RID: 21842 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005553 RID: 21843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001156")]
		public PopupScheduleManager PopupScheduler
		{
			[Token(Token = "0x6005552")]
			[Address(RVA = "0xA2F3", Offset = "0xA2F3", VA = "0xA2F3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005553")]
			[Address(RVA = "0xA2F4", Offset = "0xA2F4", VA = "0xA2F4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x06005554 RID: 21844 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005555 RID: 21845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001157")]
		public PopupController PopupController
		{
			[Token(Token = "0x6005554")]
			[Address(RVA = "0xA2F5", Offset = "0xA2F5", VA = "0xA2F5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005555")]
			[Address(RVA = "0xA2F6", Offset = "0xA2F6", VA = "0xA2F6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x06005556 RID: 21846 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005557 RID: 21847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001158")]
		public PopupScheduleManager.Args PopupScheduledArgs
		{
			[Token(Token = "0x6005556")]
			[Address(RVA = "0xA2F7", Offset = "0xA2F7", VA = "0xA2F7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005557")]
			[Address(RVA = "0xA2F8", Offset = "0xA2F8", VA = "0xA2F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x06005558 RID: 21848 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005559 RID: 21849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001159")]
		public WorldEngineEvents WorldEngineEvents
		{
			[Token(Token = "0x6005558")]
			[Address(RVA = "0xA2F9", Offset = "0xA2F9", VA = "0xA2F9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005559")]
			[Address(RVA = "0xA2FA", Offset = "0xA2FA", VA = "0xA2FA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600555A RID: 21850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600555A")]
		[Address(RVA = "0xA2FB", Offset = "0xA2FB", VA = "0xA2FB", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600555B RID: 21851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600555B")]
		[Address(RVA = "0xA2FC", Offset = "0xA2FC", VA = "0xA2FC")]
		public AnnouncementsModel(IDictProvider dictProvider, IRouter router, WorldEngineEvents worldEvents, PopupScheduleManager popupScheduler, PopupController popupController, PopupScheduleManager.Args popupScheduleArgs, UserData user)
		{
		}

		// Token: 0x0600555C RID: 21852 RVA: 0x0000F6F0 File Offset: 0x0000D8F0
		[Token(Token = "0x600555C")]
		[Address(RVA = "0xA2FD", Offset = "0xA2FD", VA = "0xA2FD")]
		public int GetNotificationsCount()
		{
			return 0;
		}

		// Token: 0x0600555D RID: 21853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600555D")]
		[Address(RVA = "0xA2FE", Offset = "0xA2FE", VA = "0xA2FE")]
		public void Add(IEnumerable<AnnouncementsData> values)
		{
		}

		// Token: 0x0600555E RID: 21854 RVA: 0x0000F708 File Offset: 0x0000D908
		[Token(Token = "0x600555E")]
		[Address(RVA = "0xA2FF", Offset = "0xA2FF", VA = "0xA2FF")]
		public bool TryGetNotification(ulong id, out AnnouncementsData value)
		{
			return default(bool);
		}

		// Token: 0x0600555F RID: 21855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600555F")]
		[Address(RVA = "0xA300", Offset = "0xA300", VA = "0xA300")]
		public void Remove(ulong id)
		{
		}

		// Token: 0x06005560 RID: 21856 RVA: 0x0000F720 File Offset: 0x0000D920
		[Token(Token = "0x6005560")]
		[Address(RVA = "0x1D2D", Offset = "0x1D2D", VA = "0x1D2D")]
		public bool TryCreate(Announcement value, out AnnouncementsData data)
		{
			return default(bool);
		}

		// Token: 0x06005561 RID: 21857 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005561")]
		[Address(RVA = "0xA301", Offset = "0xA301", VA = "0xA301")]
		public AnnouncementsData GetCurrent()
		{
			return null;
		}

		// Token: 0x04002E35 RID: 11829
		[Token(Token = "0x4002E35")]
		[FieldOffset(Offset = "0xC")]
		private readonly LinkedList<AnnouncementsData> _notifications;
	}
}
