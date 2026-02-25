using System;
using System.Runtime.CompilerServices;
using Gameplay.Shop;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001178 RID: 4472
	[Token(Token = "0x2001178")]
	public class ShopManager : IGameManager, IBaseManager
	{
		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x060069CA RID: 27082 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015A5")]
		public string Name
		{
			[Token(Token = "0x60069CA")]
			[Address(RVA = "0xB4EA", Offset = "0xB4EA", VA = "0xB4EA", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400029C RID: 668
		// (add) Token: 0x060069CB RID: 27083 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069CC RID: 27084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400029C")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60069CB")]
			[Address(RVA = "0xB4EB", Offset = "0xB4EB", VA = "0xB4EB", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069CC")]
			[Address(RVA = "0xB4EC", Offset = "0xB4EC", VA = "0xB4EC", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400029D RID: 669
		// (add) Token: 0x060069CD RID: 27085 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069CE RID: 27086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400029D")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60069CD")]
			[Address(RVA = "0xB4ED", Offset = "0xB4ED", VA = "0xB4ED", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069CE")]
			[Address(RVA = "0xB4EE", Offset = "0xB4EE", VA = "0xB4EE", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x060069CF RID: 27087 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060069D0 RID: 27088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015A6")]
		public ShopEvents Events
		{
			[Token(Token = "0x60069CF")]
			[Address(RVA = "0xB4EF", Offset = "0xB4EF", VA = "0xB4EF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60069D0")]
			[Address(RVA = "0xB4F0", Offset = "0xB4F0", VA = "0xB4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x060069D1 RID: 27089 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060069D2 RID: 27090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015A7")]
		public ShopModel Model
		{
			[Token(Token = "0x60069D1")]
			[Address(RVA = "0xB4F1", Offset = "0xB4F1", VA = "0xB4F1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60069D2")]
			[Address(RVA = "0xB4F2", Offset = "0xB4F2", VA = "0xB4F2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x060069D3 RID: 27091 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060069D4 RID: 27092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015A8")]
		public ShopController Controller
		{
			[Token(Token = "0x60069D3")]
			[Address(RVA = "0xB4F3", Offset = "0xB4F3", VA = "0xB4F3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60069D4")]
			[Address(RVA = "0xB4F4", Offset = "0xB4F4", VA = "0xB4F4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060069D5 RID: 27093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069D5")]
		[Address(RVA = "0xB4F5", Offset = "0xB4F5", VA = "0xB4F5", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x060069D6 RID: 27094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069D6")]
		[Address(RVA = "0xB4F6", Offset = "0xB4F6", VA = "0xB4F6")]
		private void OnInitEvent()
		{
		}

		// Token: 0x060069D7 RID: 27095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069D7")]
		[Address(RVA = "0xB4F7", Offset = "0xB4F7", VA = "0xB4F7", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x060069D8 RID: 27096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069D8")]
		[Address(RVA = "0xB4F8", Offset = "0xB4F8", VA = "0xB4F8")]
		public ShopManager()
		{
		}
	}
}
