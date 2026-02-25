using System;
using System.Runtime.CompilerServices;
using Gameplay.RateGame.Controller;
using Gameplay.RateGame.Events;
using Gameplay.RateGame.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001175 RID: 4469
	[Token(Token = "0x2001175")]
	public class RateGameManager : IGameManager, IBaseManager
	{
		// Token: 0x14000296 RID: 662
		// (add) Token: 0x060069A1 RID: 27041 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069A2 RID: 27042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000296")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60069A1")]
			[Address(RVA = "0xB4C1", Offset = "0xB4C1", VA = "0xB4C1", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069A2")]
			[Address(RVA = "0xB4C2", Offset = "0xB4C2", VA = "0xB4C2", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000297 RID: 663
		// (add) Token: 0x060069A3 RID: 27043 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069A4 RID: 27044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000297")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60069A3")]
			[Address(RVA = "0xB4C3", Offset = "0xB4C3", VA = "0xB4C3", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069A4")]
			[Address(RVA = "0xB4C4", Offset = "0xB4C4", VA = "0xB4C4", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x060069A5 RID: 27045 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060069A6 RID: 27046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700159B")]
		public RateGameController Controller
		{
			[Token(Token = "0x60069A5")]
			[Address(RVA = "0xB4C5", Offset = "0xB4C5", VA = "0xB4C5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60069A6")]
			[Address(RVA = "0xB4C6", Offset = "0xB4C6", VA = "0xB4C6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x060069A7 RID: 27047 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060069A8 RID: 27048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700159C")]
		public RateGameEvents Events
		{
			[Token(Token = "0x60069A7")]
			[Address(RVA = "0xB4C7", Offset = "0xB4C7", VA = "0xB4C7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60069A8")]
			[Address(RVA = "0xB4C8", Offset = "0xB4C8", VA = "0xB4C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x060069A9 RID: 27049 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060069AA RID: 27050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700159D")]
		public RateGameModel Model
		{
			[Token(Token = "0x60069A9")]
			[Address(RVA = "0xB4C9", Offset = "0xB4C9", VA = "0xB4C9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60069AA")]
			[Address(RVA = "0xB4CA", Offset = "0xB4CA", VA = "0xB4CA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060069AB RID: 27051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069AB")]
		[Address(RVA = "0xB4CB", Offset = "0xB4CB", VA = "0xB4CB", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x060069AC RID: 27052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069AC")]
		[Address(RVA = "0xB4CC", Offset = "0xB4CC", VA = "0xB4CC", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x060069AD RID: 27053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069AD")]
		[Address(RVA = "0xB4CD", Offset = "0xB4CD", VA = "0xB4CD")]
		private void SetupMVC()
		{
		}

		// Token: 0x060069AE RID: 27054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069AE")]
		[Address(RVA = "0xB4CE", Offset = "0xB4CE", VA = "0xB4CE")]
		private void DestroyMVC()
		{
		}

		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x060069AF RID: 27055 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700159E")]
		public string Name
		{
			[Token(Token = "0x60069AF")]
			[Address(RVA = "0xB4CF", Offset = "0xB4CF", VA = "0xB4CF", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060069B0 RID: 27056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069B0")]
		[Address(RVA = "0xB4D0", Offset = "0xB4D0", VA = "0xB4D0")]
		public RateGameManager()
		{
		}
	}
}
