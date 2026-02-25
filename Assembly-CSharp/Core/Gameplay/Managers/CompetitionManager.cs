using System;
using System.Runtime.CompilerServices;
using Gameplay.Competition.Control;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001161 RID: 4449
	[Token(Token = "0x2001161")]
	public class CompetitionManager : IGameManager, IBaseManager
	{
		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x060068BF RID: 26815 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700156E")]
		public string Name
		{
			[Token(Token = "0x60068BF")]
			[Address(RVA = "0xB3E5", Offset = "0xB3E5", VA = "0xB3E5", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000279 RID: 633
		// (add) Token: 0x060068C0 RID: 26816 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060068C1 RID: 26817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000279")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60068C0")]
			[Address(RVA = "0xB3E6", Offset = "0xB3E6", VA = "0xB3E6", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60068C1")]
			[Address(RVA = "0xB3E7", Offset = "0xB3E7", VA = "0xB3E7", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400027A RID: 634
		// (add) Token: 0x060068C2 RID: 26818 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060068C3 RID: 26819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400027A")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60068C2")]
			[Address(RVA = "0xB3E8", Offset = "0xB3E8", VA = "0xB3E8", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60068C3")]
			[Address(RVA = "0xB3E9", Offset = "0xB3E9", VA = "0xB3E9", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x060068C4 RID: 26820 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068C5 RID: 26821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700156F")]
		public CompetitionController Controller
		{
			[Token(Token = "0x60068C4")]
			[Address(RVA = "0xB3EA", Offset = "0xB3EA", VA = "0xB3EA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068C5")]
			[Address(RVA = "0xB3EB", Offset = "0xB3EB", VA = "0xB3EB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060068C6 RID: 26822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068C6")]
		[Address(RVA = "0xB3EC", Offset = "0xB3EC", VA = "0xB3EC")]
		public CompetitionManager(IGame game)
		{
		}

		// Token: 0x060068C7 RID: 26823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068C7")]
		[Address(RVA = "0xB3ED", Offset = "0xB3ED", VA = "0xB3ED", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x060068C8 RID: 26824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068C8")]
		[Address(RVA = "0xB3EE", Offset = "0xB3EE", VA = "0xB3EE", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x060068C9 RID: 26825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068C9")]
		[Address(RVA = "0xB3EF", Offset = "0xB3EF", VA = "0xB3EF")]
		private void HandleControllerInitEvent()
		{
		}

		// Token: 0x040037AA RID: 14250
		[Token(Token = "0x40037AA")]
		[FieldOffset(Offset = "0x10")]
		private readonly IGame _game;
	}
}
