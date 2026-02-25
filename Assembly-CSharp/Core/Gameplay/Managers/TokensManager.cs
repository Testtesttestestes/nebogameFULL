using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay.Tokens;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200117C RID: 4476
	[Token(Token = "0x200117C")]
	public class TokensManager : IAppManager, IBaseManager
	{
		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x06006A09 RID: 27145 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015B3")]
		public string Name
		{
			[Token(Token = "0x6006A09")]
			[Address(RVA = "0xB529", Offset = "0xB529", VA = "0xB529", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002A4 RID: 676
		// (add) Token: 0x06006A0A RID: 27146 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A0B RID: 27147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002A4")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006A0A")]
			[Address(RVA = "0xB52A", Offset = "0xB52A", VA = "0xB52A", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A0B")]
			[Address(RVA = "0xB52B", Offset = "0xB52B", VA = "0xB52B", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002A5 RID: 677
		// (add) Token: 0x06006A0C RID: 27148 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A0D RID: 27149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002A5")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006A0C")]
			[Address(RVA = "0xB52C", Offset = "0xB52C", VA = "0xB52C", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A0D")]
			[Address(RVA = "0xB52D", Offset = "0xB52D", VA = "0xB52D", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x06006A0E RID: 27150 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A0F RID: 27151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015B4")]
		public IdTokenRepository IdTokenRepository
		{
			[Token(Token = "0x6006A0E")]
			[Address(RVA = "0xB52E", Offset = "0xB52E", VA = "0xB52E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A0F")]
			[Address(RVA = "0xB52F", Offset = "0xB52F", VA = "0xB52F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006A10 RID: 27152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A10")]
		[Address(RVA = "0xB530", Offset = "0xB530", VA = "0xB530")]
		public TokensManager(IApp app)
		{
		}

		// Token: 0x06006A11 RID: 27153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A11")]
		[Address(RVA = "0xB531", Offset = "0xB531", VA = "0xB531", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006A12 RID: 27154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A12")]
		[Address(RVA = "0xB532", Offset = "0xB532", VA = "0xB532", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x0400382F RID: 14383
		[Token(Token = "0x400382F")]
		[FieldOffset(Offset = "0x14")]
		private readonly IApp _app;
	}
}
