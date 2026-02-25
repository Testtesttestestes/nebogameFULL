using System;
using System.Runtime.CompilerServices;
using Gameplay.Announcements.Control;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200113E RID: 4414
	[Token(Token = "0x200113E")]
	public class AnnouncementsManager : IGameManager, IBaseManager
	{
		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x06006776 RID: 26486 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006777 RID: 26487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700152F")]
		public IGame Game
		{
			[Token(Token = "0x6006776")]
			[Address(RVA = "0xB2A2", Offset = "0xB2A2", VA = "0xB2A2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006777")]
			[Address(RVA = "0xB2A3", Offset = "0xB2A3", VA = "0xB2A3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x06006778 RID: 26488 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001530")]
		public string Name
		{
			[Token(Token = "0x6006778")]
			[Address(RVA = "0xB2A4", Offset = "0xB2A4", VA = "0xB2A4", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000258 RID: 600
		// (add) Token: 0x06006779 RID: 26489 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600677A RID: 26490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000258")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006779")]
			[Address(RVA = "0xB2A5", Offset = "0xB2A5", VA = "0xB2A5", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600677A")]
			[Address(RVA = "0xB2A6", Offset = "0xB2A6", VA = "0xB2A6", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000259 RID: 601
		// (add) Token: 0x0600677B RID: 26491 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600677C RID: 26492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000259")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x600677B")]
			[Address(RVA = "0xB2A7", Offset = "0xB2A7", VA = "0xB2A7", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600677C")]
			[Address(RVA = "0xB2A8", Offset = "0xB2A8", VA = "0xB2A8", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600677D RID: 26493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600677D")]
		[Address(RVA = "0xB2A9", Offset = "0xB2A9", VA = "0xB2A9")]
		public AnnouncementsManager(IGame game)
		{
		}

		// Token: 0x0600677E RID: 26494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600677E")]
		[Address(RVA = "0xB2AA", Offset = "0xB2AA", VA = "0xB2AA", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x0600677F RID: 26495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600677F")]
		[Address(RVA = "0xB2AB", Offset = "0xB2AB", VA = "0xB2AB", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006780 RID: 26496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006780")]
		[Address(RVA = "0xB2AC", Offset = "0xB2AC", VA = "0xB2AC")]
		private void HandleInitEvent()
		{
		}

		// Token: 0x0400373E RID: 14142
		[Token(Token = "0x400373E")]
		[FieldOffset(Offset = "0x14")]
		private AnnouncementsController _controller;
	}
}
