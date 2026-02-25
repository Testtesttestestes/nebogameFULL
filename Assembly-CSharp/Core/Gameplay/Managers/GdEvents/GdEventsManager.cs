using System;
using System.Runtime.CompilerServices;
using Gameplay.Collections.Model.Factories;
using Gameplay.GdEvents.Control;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.GdEvents
{
	// Token: 0x020011C2 RID: 4546
	[Token(Token = "0x20011C2")]
	public class GdEventsManager : IGameManager, IBaseManager
	{
		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x06006C42 RID: 27714 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001623")]
		public string Name
		{
			[Token(Token = "0x6006C42")]
			[Address(RVA = "0xB72F", Offset = "0xB72F", VA = "0xB72F", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002C7 RID: 711
		// (add) Token: 0x06006C43 RID: 27715 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006C44 RID: 27716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002C7")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006C43")]
			[Address(RVA = "0xB730", Offset = "0xB730", VA = "0xB730", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006C44")]
			[Address(RVA = "0xB731", Offset = "0xB731", VA = "0xB731", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002C8 RID: 712
		// (add) Token: 0x06006C45 RID: 27717 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006C46 RID: 27718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002C8")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006C45")]
			[Address(RVA = "0xB732", Offset = "0xB732", VA = "0xB732", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006C46")]
			[Address(RVA = "0xB733", Offset = "0xB733", VA = "0xB733", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x06006C47 RID: 27719 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006C48 RID: 27720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001624")]
		public GdEventsController Controller
		{
			[Token(Token = "0x6006C47")]
			[Address(RVA = "0xB734", Offset = "0xB734", VA = "0xB734")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006C48")]
			[Address(RVA = "0xB735", Offset = "0xB735", VA = "0xB735")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006C49 RID: 27721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C49")]
		[Address(RVA = "0xB736", Offset = "0xB736", VA = "0xB736")]
		public GdEventsManager(IGame game)
		{
		}

		// Token: 0x06006C4A RID: 27722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C4A")]
		[Address(RVA = "0xB737", Offset = "0xB737", VA = "0xB737", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006C4B RID: 27723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C4B")]
		[Address(RVA = "0xB738", Offset = "0xB738", VA = "0xB738", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x040038F8 RID: 14584
		[Token(Token = "0x40038F8")]
		[FieldOffset(Offset = "0x14")]
		private IGame _game;

		// Token: 0x040038F9 RID: 14585
		[Token(Token = "0x40038F9")]
		[FieldOffset(Offset = "0x18")]
		private ICollectionDataFactory _collectionDataFactory;
	}
}
