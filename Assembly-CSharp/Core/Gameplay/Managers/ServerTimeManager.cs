using System;
using System.Runtime.CompilerServices;
using Core.GameTime;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001177 RID: 4471
	[Token(Token = "0x2001177")]
	public class ServerTimeManager : IGameManager, IBaseManager
	{
		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x060069BF RID: 27071 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015A3")]
		public string Name
		{
			[Token(Token = "0x60069BF")]
			[Address(RVA = "0xB4DF", Offset = "0xB4DF", VA = "0xB4DF", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400029A RID: 666
		// (add) Token: 0x060069C0 RID: 27072 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069C1 RID: 27073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400029A")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60069C0")]
			[Address(RVA = "0xB4E0", Offset = "0xB4E0", VA = "0xB4E0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069C1")]
			[Address(RVA = "0xB4E1", Offset = "0xB4E1", VA = "0xB4E1", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400029B RID: 667
		// (add) Token: 0x060069C2 RID: 27074 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069C3 RID: 27075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400029B")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60069C2")]
			[Address(RVA = "0xB4E2", Offset = "0xB4E2", VA = "0xB4E2", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069C3")]
			[Address(RVA = "0xB4E3", Offset = "0xB4E3", VA = "0xB4E3", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x060069C4 RID: 27076 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015A4")]
		public ICurrentTimeProvider CurrentTime
		{
			[Token(Token = "0x60069C4")]
			[Address(RVA = "0xB4E4", Offset = "0xB4E4", VA = "0xB4E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060069C5 RID: 27077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069C5")]
		[Address(RVA = "0xB4E5", Offset = "0xB4E5", VA = "0xB4E5")]
		public ServerTimeManager(IGame game)
		{
		}

		// Token: 0x060069C6 RID: 27078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069C6")]
		[Address(RVA = "0xB4E6", Offset = "0xB4E6", VA = "0xB4E6", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x060069C7 RID: 27079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069C7")]
		[Address(RVA = "0xB4E7", Offset = "0xB4E7", VA = "0xB4E7", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x060069C8 RID: 27080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069C8")]
		[Address(RVA = "0xB4E8", Offset = "0xB4E8", VA = "0xB4E8")]
		private void CurrentTimeProviderOnReadyEvent(AbstractCurrentTimeProvider provider)
		{
		}

		// Token: 0x060069C9 RID: 27081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069C9")]
		[Address(RVA = "0xB4E9", Offset = "0xB4E9", VA = "0xB4E9")]
		private void Complete()
		{
		}

		// Token: 0x04003815 RID: 14357
		[Token(Token = "0x4003815")]
		[FieldOffset(Offset = "0x10")]
		private ServerTimeProvider _provider;
	}
}
