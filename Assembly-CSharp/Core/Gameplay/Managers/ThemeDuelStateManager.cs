using System;
using System.Runtime.CompilerServices;
using Gameplay.ThemeDuelState;
using Gameplay.ThemeDuelState.Control;
using Gameplay.ThemeDuelState.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200117B RID: 4475
	[Token(Token = "0x200117B")]
	public class ThemeDuelStateManager : IGameManager, IBaseManager
	{
		// Token: 0x140002A2 RID: 674
		// (add) Token: 0x060069FA RID: 27130 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069FB RID: 27131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002A2")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60069FA")]
			[Address(RVA = "0xB51A", Offset = "0xB51A", VA = "0xB51A", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069FB")]
			[Address(RVA = "0xB51B", Offset = "0xB51B", VA = "0xB51B", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002A3 RID: 675
		// (add) Token: 0x060069FC RID: 27132 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069FD RID: 27133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002A3")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60069FC")]
			[Address(RVA = "0xB51C", Offset = "0xB51C", VA = "0xB51C", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069FD")]
			[Address(RVA = "0xB51D", Offset = "0xB51D", VA = "0xB51D", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x060069FE RID: 27134 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060069FF RID: 27135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015AF")]
		public ThemeDuelStateController Controller
		{
			[Token(Token = "0x60069FE")]
			[Address(RVA = "0xB51E", Offset = "0xB51E", VA = "0xB51E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60069FF")]
			[Address(RVA = "0xB51F", Offset = "0xB51F", VA = "0xB51F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x06006A00 RID: 27136 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A01 RID: 27137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015B0")]
		public ThemeDuelStateModel Model
		{
			[Token(Token = "0x6006A00")]
			[Address(RVA = "0xB520", Offset = "0xB520", VA = "0xB520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A01")]
			[Address(RVA = "0xB521", Offset = "0xB521", VA = "0xB521")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x06006A02 RID: 27138 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A03 RID: 27139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015B1")]
		public ThemeDuelStateEvents Events
		{
			[Token(Token = "0x6006A02")]
			[Address(RVA = "0xB522", Offset = "0xB522", VA = "0xB522")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A03")]
			[Address(RVA = "0xB523", Offset = "0xB523", VA = "0xB523")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006A04 RID: 27140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A04")]
		[Address(RVA = "0xB524", Offset = "0xB524", VA = "0xB524", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006A05 RID: 27141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A05")]
		[Address(RVA = "0xB525", Offset = "0xB525", VA = "0xB525", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006A06 RID: 27142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A06")]
		[Address(RVA = "0xB526", Offset = "0xB526", VA = "0xB526")]
		private void OnThemeDuelStateReceived()
		{
		}

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x06006A07 RID: 27143 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015B2")]
		public string Name
		{
			[Token(Token = "0x6006A07")]
			[Address(RVA = "0xB527", Offset = "0xB527", VA = "0xB527", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006A08 RID: 27144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A08")]
		[Address(RVA = "0xB528", Offset = "0xB528", VA = "0xB528")]
		public ThemeDuelStateManager()
		{
		}
	}
}
