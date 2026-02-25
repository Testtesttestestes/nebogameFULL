using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Gameplay.Portals;
using Gameplay.Portals.Controller;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001171 RID: 4465
	[Token(Token = "0x2001171")]
	public class PortalsManager : IGameManager, IBaseManager, IPortal, IBalance, IMonsterSource
	{
		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x06006975 RID: 26997 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001593")]
		public string Name
		{
			[Token(Token = "0x6006975")]
			[Address(RVA = "0xB495", Offset = "0xB495", VA = "0xB495", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000290 RID: 656
		// (add) Token: 0x06006976 RID: 26998 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006977 RID: 26999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000290")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006976")]
			[Address(RVA = "0xB496", Offset = "0xB496", VA = "0xB496", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006977")]
			[Address(RVA = "0xB497", Offset = "0xB497", VA = "0xB497", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000291 RID: 657
		// (add) Token: 0x06006978 RID: 27000 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006979 RID: 27001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000291")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006978")]
			[Address(RVA = "0xB498", Offset = "0xB498", VA = "0xB498", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006979")]
			[Address(RVA = "0xB499", Offset = "0xB499", VA = "0xB499", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x0600697A RID: 27002 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600697B RID: 27003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001594")]
		public PortalsModel Model
		{
			[Token(Token = "0x600697A")]
			[Address(RVA = "0xB49A", Offset = "0xB49A", VA = "0xB49A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600697B")]
			[Address(RVA = "0xB49B", Offset = "0xB49B", VA = "0xB49B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x0600697C RID: 27004 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600697D RID: 27005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001595")]
		public PortalsEvents Events
		{
			[Token(Token = "0x600697C")]
			[Address(RVA = "0xB49C", Offset = "0xB49C", VA = "0xB49C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600697D")]
			[Address(RVA = "0xB49D", Offset = "0xB49D", VA = "0xB49D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x0600697E RID: 27006 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600697F RID: 27007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001596")]
		public PortalsController Controller
		{
			[Token(Token = "0x600697E")]
			[Address(RVA = "0xB49E", Offset = "0xB49E", VA = "0xB49E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600697F")]
			[Address(RVA = "0xB49F", Offset = "0xB49F", VA = "0xB49F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x06006980 RID: 27008 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006981 RID: 27009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001597")]
		public IGame Game
		{
			[Token(Token = "0x6006980")]
			[Address(RVA = "0xB4A0", Offset = "0xB4A0", VA = "0xB4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006981")]
			[Address(RVA = "0xB4A1", Offset = "0xB4A1", VA = "0xB4A1")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006982 RID: 27010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006982")]
		[Address(RVA = "0xB4A2", Offset = "0xB4A2", VA = "0xB4A2")]
		public PortalsManager(IGame game)
		{
		}

		// Token: 0x06006983 RID: 27011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006983")]
		[Address(RVA = "0xB4A3", Offset = "0xB4A3", VA = "0xB4A3", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006984 RID: 27012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006984")]
		[Address(RVA = "0xB4A4", Offset = "0xB4A4", VA = "0xB4A4", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006985 RID: 27013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006985")]
		[Address(RVA = "0xB4A5", Offset = "0xB4A5", VA = "0xB4A5")]
		private void InitEvent()
		{
		}

		// Token: 0x06006986 RID: 27014 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006986")]
		[Address(RVA = "0xB4A6", Offset = "0xB4A6", VA = "0xB4A6", Slot = "11")]
		public PortalDic GetConfig()
		{
			return null;
		}

		// Token: 0x06006987 RID: 27015 RVA: 0x000139B0 File Offset: 0x00011BB0
		[Token(Token = "0x6006987")]
		[Address(RVA = "0xB4A7", Offset = "0xB4A7", VA = "0xB4A7", Slot = "12")]
		public UniTask<ulong> GetValue()
		{
			return default(UniTask<ulong>);
		}

		// Token: 0x06006988 RID: 27016 RVA: 0x000139C8 File Offset: 0x00011BC8
		[Token(Token = "0x6006988")]
		[Address(RVA = "0xB4A8", Offset = "0xB4A8", VA = "0xB4A8", Slot = "13")]
		public UniTask<PortalMonsterData> GetMonster()
		{
			return default(UniTask<PortalMonsterData>);
		}
	}
}
