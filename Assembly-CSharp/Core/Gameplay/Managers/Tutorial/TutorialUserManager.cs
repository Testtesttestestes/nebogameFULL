using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Tutorial
{
	// Token: 0x02001185 RID: 4485
	[Token(Token = "0x2001185")]
	public class TutorialUserManager : IGameManager, IBaseManager
	{
		// Token: 0x06006A94 RID: 27284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A94")]
		[Address(RVA = "0xB5AD", Offset = "0xB5AD", VA = "0xB5AD")]
		public TutorialUserManager(ITutorialManager tutorialManager)
		{
		}

		// Token: 0x140002B2 RID: 690
		// (add) Token: 0x06006A95 RID: 27285 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A96 RID: 27286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002B2")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006A95")]
			[Address(RVA = "0xB5AE", Offset = "0xB5AE", VA = "0xB5AE", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A96")]
			[Address(RVA = "0xB5AF", Offset = "0xB5AF", VA = "0xB5AF", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002B3 RID: 691
		// (add) Token: 0x06006A97 RID: 27287 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A98 RID: 27288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002B3")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006A97")]
			[Address(RVA = "0xB5B0", Offset = "0xB5B0", VA = "0xB5B0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A98")]
			[Address(RVA = "0xB5B1", Offset = "0xB5B1", VA = "0xB5B1", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006A99 RID: 27289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A99")]
		[Address(RVA = "0xB5B2", Offset = "0xB5B2", VA = "0xB5B2", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006A9A RID: 27290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A9A")]
		[Address(RVA = "0xB5B3", Offset = "0xB5B3", VA = "0xB5B3", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x06006A9B RID: 27291 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015D2")]
		public string Name
		{
			[Token(Token = "0x6006A9B")]
			[Address(RVA = "0xB5B4", Offset = "0xB5B4", VA = "0xB5B4", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x04003856 RID: 14422
		[Token(Token = "0x4003856")]
		[FieldOffset(Offset = "0x8")]
		private ITutorialManager _tutorialManager;
	}
}
