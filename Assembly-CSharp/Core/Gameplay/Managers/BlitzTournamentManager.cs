using System;
using System.Runtime.CompilerServices;
using Gameplay.BlitzTournament.Controller;
using Gameplay.BlitzTournament.Events;
using Gameplay.BlitzTournament.Model;
using Gameplay.BlitzTournament.View;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001144 RID: 4420
	[Token(Token = "0x2001144")]
	public class BlitzTournamentManager : IGameManager, IBaseManager
	{
		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x060067DC RID: 26588 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001547")]
		public string Name
		{
			[Token(Token = "0x60067DC")]
			[Address(RVA = "0xB308", Offset = "0xB308", VA = "0xB308", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000264 RID: 612
		// (add) Token: 0x060067DD RID: 26589 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060067DE RID: 26590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000264")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60067DD")]
			[Address(RVA = "0xB309", Offset = "0xB309", VA = "0xB309", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60067DE")]
			[Address(RVA = "0xB30A", Offset = "0xB30A", VA = "0xB30A", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000265 RID: 613
		// (add) Token: 0x060067DF RID: 26591 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060067E0 RID: 26592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000265")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60067DF")]
			[Address(RVA = "0xB30B", Offset = "0xB30B", VA = "0xB30B", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60067E0")]
			[Address(RVA = "0xB30C", Offset = "0xB30C", VA = "0xB30C", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x060067E1 RID: 26593 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060067E2 RID: 26594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001548")]
		public BlitzTournamentController Controller
		{
			[Token(Token = "0x60067E1")]
			[Address(RVA = "0xB30D", Offset = "0xB30D", VA = "0xB30D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60067E2")]
			[Address(RVA = "0xB30E", Offset = "0xB30E", VA = "0xB30E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060067E3 RID: 26595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067E3")]
		[Address(RVA = "0xB30F", Offset = "0xB30F", VA = "0xB30F", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x060067E4 RID: 26596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067E4")]
		[Address(RVA = "0xB310", Offset = "0xB310", VA = "0xB310", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x060067E5 RID: 26597 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60067E5")]
		[Address(RVA = "0xB311", Offset = "0xB311", VA = "0xB311")]
		public BlitzTournamentWindow ShowBlitzTournamentWindow(BlitzTournamentWindow.WindowState windowState = BlitzTournamentWindow.WindowState.Default)
		{
			return null;
		}

		// Token: 0x060067E6 RID: 26598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067E6")]
		[Address(RVA = "0xB312", Offset = "0xB312", VA = "0xB312")]
		public void ReconnectToCombat()
		{
		}

		// Token: 0x060067E7 RID: 26599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067E7")]
		[Address(RVA = "0xB313", Offset = "0xB313", VA = "0xB313")]
		public BlitzTournamentManager()
		{
		}

		// Token: 0x04003763 RID: 14179
		[Token(Token = "0x4003763")]
		[FieldOffset(Offset = "0x10")]
		private BlitzTournamentEvents _events;

		// Token: 0x04003764 RID: 14180
		[Token(Token = "0x4003764")]
		[FieldOffset(Offset = "0x14")]
		private BlitzTournamentModel _model;
	}
}
