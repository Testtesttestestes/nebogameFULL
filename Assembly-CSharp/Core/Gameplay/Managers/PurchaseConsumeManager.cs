using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001174 RID: 4468
	[Token(Token = "0x2001174")]
	public class PurchaseConsumeManager : IGameManager, IBaseManager
	{
		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x06006999 RID: 27033 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700159A")]
		public string Name
		{
			[Token(Token = "0x6006999")]
			[Address(RVA = "0xB4B9", Offset = "0xB4B9", VA = "0xB4B9", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000294 RID: 660
		// (add) Token: 0x0600699A RID: 27034 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600699B RID: 27035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000294")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x600699A")]
			[Address(RVA = "0xB4BA", Offset = "0xB4BA", VA = "0xB4BA", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600699B")]
			[Address(RVA = "0xB4BB", Offset = "0xB4BB", VA = "0xB4BB", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000295 RID: 661
		// (add) Token: 0x0600699C RID: 27036 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600699D RID: 27037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000295")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x600699C")]
			[Address(RVA = "0xB4BC", Offset = "0xB4BC", VA = "0xB4BC", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600699D")]
			[Address(RVA = "0xB4BD", Offset = "0xB4BD", VA = "0xB4BD", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600699E RID: 27038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600699E")]
		[Address(RVA = "0xB4BE", Offset = "0xB4BE", VA = "0xB4BE")]
		public PurchaseConsumeManager(IGame game)
		{
		}

		// Token: 0x0600699F RID: 27039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600699F")]
		[Address(RVA = "0xB4BF", Offset = "0xB4BF", VA = "0xB4BF", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x060069A0 RID: 27040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069A0")]
		[Address(RVA = "0xB4C0", Offset = "0xB4C0", VA = "0xB4C0", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x04003808 RID: 14344
		[Token(Token = "0x4003808")]
		[FieldOffset(Offset = "0x10")]
		public readonly IGame Game;
	}
}
