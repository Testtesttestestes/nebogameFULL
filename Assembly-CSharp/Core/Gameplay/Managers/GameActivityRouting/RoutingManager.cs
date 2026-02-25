using System;
using System.Runtime.CompilerServices;
using Core.Rounting;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.GameActivityRouting
{
	// Token: 0x020011C8 RID: 4552
	[Token(Token = "0x20011C8")]
	public class RoutingManager : IGameManager, IBaseManager, IRouter
	{
		// Token: 0x140002CB RID: 715
		// (add) Token: 0x06006C6E RID: 27758 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006C6F RID: 27759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002CB")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006C6E")]
			[Address(RVA = "0xB75A", Offset = "0xB75A", VA = "0xB75A", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006C6F")]
			[Address(RVA = "0xB75B", Offset = "0xB75B", VA = "0xB75B", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002CC RID: 716
		// (add) Token: 0x06006C70 RID: 27760 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006C71 RID: 27761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002CC")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006C70")]
			[Address(RVA = "0xB75C", Offset = "0xB75C", VA = "0xB75C", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006C71")]
			[Address(RVA = "0xB75D", Offset = "0xB75D", VA = "0xB75D", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x06006C72 RID: 27762 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001627")]
		public string Name
		{
			[Token(Token = "0x6006C72")]
			[Address(RVA = "0xB75E", Offset = "0xB75E", VA = "0xB75E", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x06006C73 RID: 27763 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006C74 RID: 27764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001628")]
		public ILocatorRepository LocatorRepository
		{
			[Token(Token = "0x6006C73")]
			[Address(RVA = "0xB75F", Offset = "0xB75F", VA = "0xB75F", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006C74")]
			[Address(RVA = "0xB760", Offset = "0xB760", VA = "0xB760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x06006C75 RID: 27765 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006C76 RID: 27766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001629")]
		public IGame Game
		{
			[Token(Token = "0x6006C75")]
			[Address(RVA = "0xB761", Offset = "0xB761", VA = "0xB761")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006C76")]
			[Address(RVA = "0xB762", Offset = "0xB762", VA = "0xB762")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006C77 RID: 27767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C77")]
		[Address(RVA = "0xB763", Offset = "0xB763", VA = "0xB763")]
		public RoutingManager(IGame game)
		{
		}

		// Token: 0x06006C78 RID: 27768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C78")]
		[Address(RVA = "0xB764", Offset = "0xB764", VA = "0xB764", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006C79 RID: 27769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C79")]
		[Address(RVA = "0xB765", Offset = "0xB765", VA = "0xB765", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006C7A RID: 27770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C7A")]
		[Address(RVA = "0xB766", Offset = "0xB766", VA = "0xB766")]
		private void HandleDeepLinkUriChangedEvent(Uri uri)
		{
		}
	}
}
