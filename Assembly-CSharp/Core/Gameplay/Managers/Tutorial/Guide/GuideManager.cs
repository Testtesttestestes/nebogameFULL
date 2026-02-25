using System;
using System.Runtime.CompilerServices;
using Gameplay.Tutorial.Guide.Control;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Tutorial.Guide
{
	// Token: 0x02001186 RID: 4486
	[Token(Token = "0x2001186")]
	public class GuideManager : IGameManager, IBaseManager
	{
		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x06006A9C RID: 27292 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015D3")]
		public string Name
		{
			[Token(Token = "0x6006A9C")]
			[Address(RVA = "0xB5B5", Offset = "0xB5B5", VA = "0xB5B5", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002B4 RID: 692
		// (add) Token: 0x06006A9D RID: 27293 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A9E RID: 27294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002B4")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006A9D")]
			[Address(RVA = "0xB5B6", Offset = "0xB5B6", VA = "0xB5B6", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A9E")]
			[Address(RVA = "0xB5B7", Offset = "0xB5B7", VA = "0xB5B7", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002B5 RID: 693
		// (add) Token: 0x06006A9F RID: 27295 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006AA0 RID: 27296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002B5")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006A9F")]
			[Address(RVA = "0xB5B8", Offset = "0xB5B8", VA = "0xB5B8", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006AA0")]
			[Address(RVA = "0xB5B9", Offset = "0xB5B9", VA = "0xB5B9", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x06006AA1 RID: 27297 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006AA2 RID: 27298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015D4")]
		public GuideController Controller
		{
			[Token(Token = "0x6006AA1")]
			[Address(RVA = "0xB5BA", Offset = "0xB5BA", VA = "0xB5BA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006AA2")]
			[Address(RVA = "0xB5BB", Offset = "0xB5BB", VA = "0xB5BB")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06006AA3 RID: 27299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AA3")]
		[Address(RVA = "0xB5BC", Offset = "0xB5BC", VA = "0xB5BC", Slot = "11")]
		public virtual void Init()
		{
		}

		// Token: 0x06006AA4 RID: 27300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AA4")]
		[Address(RVA = "0xB5BD", Offset = "0xB5BD", VA = "0xB5BD")]
		protected void InitComplete()
		{
		}

		// Token: 0x06006AA5 RID: 27301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AA5")]
		[Address(RVA = "0xB5BE", Offset = "0xB5BE", VA = "0xB5BE")]
		protected void DeInitComplete()
		{
		}

		// Token: 0x06006AA6 RID: 27302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AA6")]
		[Address(RVA = "0xB5BF", Offset = "0xB5BF", VA = "0xB5BF", Slot = "12")]
		public virtual void Deinit()
		{
		}

		// Token: 0x06006AA7 RID: 27303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AA7")]
		[Address(RVA = "0xB5C0", Offset = "0xB5C0", VA = "0xB5C0")]
		public void ShowControlWindow()
		{
		}

		// Token: 0x06006AA8 RID: 27304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AA8")]
		[Address(RVA = "0xB5C1", Offset = "0xB5C1", VA = "0xB5C1")]
		public GuideManager()
		{
		}
	}
}
