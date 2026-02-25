using System;
using System.Runtime.CompilerServices;
using Gameplay.Chat.Control;
using Gameplay.Chat.Model.Data;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001147 RID: 4423
	[Token(Token = "0x2001147")]
	public class ChatManager : IGameManager, IBaseManager
	{
		// Token: 0x1400026A RID: 618
		// (add) Token: 0x06006810 RID: 26640 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006811 RID: 26641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400026A")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006810")]
			[Address(RVA = "0xB33C", Offset = "0xB33C", VA = "0xB33C", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006811")]
			[Address(RVA = "0xB33D", Offset = "0xB33D", VA = "0xB33D", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400026B RID: 619
		// (add) Token: 0x06006812 RID: 26642 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006813 RID: 26643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400026B")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006812")]
			[Address(RVA = "0xB33E", Offset = "0xB33E", VA = "0xB33E", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006813")]
			[Address(RVA = "0xB33F", Offset = "0xB33F", VA = "0xB33F", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x06006814 RID: 26644 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006815 RID: 26645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001553")]
		public ChatController Controller
		{
			[Token(Token = "0x6006814")]
			[Address(RVA = "0xB340", Offset = "0xB340", VA = "0xB340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006815")]
			[Address(RVA = "0xB341", Offset = "0xB341", VA = "0xB341")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006816 RID: 26646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006816")]
		[Address(RVA = "0xB342", Offset = "0xB342", VA = "0xB342")]
		public ChatManager(IGame game)
		{
		}

		// Token: 0x06006817 RID: 26647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006817")]
		[Address(RVA = "0xB343", Offset = "0xB343", VA = "0xB343", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006818 RID: 26648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006818")]
		[Address(RVA = "0xB344", Offset = "0xB344", VA = "0xB344", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x06006819 RID: 26649 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001554")]
		public string Name
		{
			[Token(Token = "0x6006819")]
			[Address(RVA = "0xB345", Offset = "0xB345", VA = "0xB345", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600681A RID: 26650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600681A")]
		[Address(RVA = "0xB346", Offset = "0xB346", VA = "0xB346")]
		public void RunBanProcess(ChatVisitorData visitor)
		{
		}

		// Token: 0x04003777 RID: 14199
		[Token(Token = "0x4003777")]
		[FieldOffset(Offset = "0x14")]
		private readonly IGame _game;
	}
}
