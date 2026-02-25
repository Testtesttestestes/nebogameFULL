using System;
using System.Runtime.CompilerServices;
using Gameplay.Tournaments.Controller;
using Gameplay.Tournaments.Events;
using Gameplay.Tournaments.Model;
using Gameplay.Tournaments.View;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200117D RID: 4477
	[Token(Token = "0x200117D")]
	public class TournamentsManager : IGameManager, IBaseManager
	{
		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x06006A13 RID: 27155 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015B5")]
		public string Name
		{
			[Token(Token = "0x6006A13")]
			[Address(RVA = "0xB533", Offset = "0xB533", VA = "0xB533", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002A6 RID: 678
		// (add) Token: 0x06006A14 RID: 27156 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A15 RID: 27157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002A6")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006A14")]
			[Address(RVA = "0xB534", Offset = "0xB534", VA = "0xB534", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A15")]
			[Address(RVA = "0xB535", Offset = "0xB535", VA = "0xB535", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002A7 RID: 679
		// (add) Token: 0x06006A16 RID: 27158 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A17 RID: 27159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002A7")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006A16")]
			[Address(RVA = "0xB536", Offset = "0xB536", VA = "0xB536", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A17")]
			[Address(RVA = "0xB537", Offset = "0xB537", VA = "0xB537", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x06006A18 RID: 27160 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A19 RID: 27161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015B6")]
		public TournamentsController Controller
		{
			[Token(Token = "0x6006A18")]
			[Address(RVA = "0xB538", Offset = "0xB538", VA = "0xB538")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A19")]
			[Address(RVA = "0xB539", Offset = "0xB539", VA = "0xB539")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006A1A RID: 27162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A1A")]
		[Address(RVA = "0xB53A", Offset = "0xB53A", VA = "0xB53A", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006A1B RID: 27163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A1B")]
		[Address(RVA = "0xB53B", Offset = "0xB53B", VA = "0xB53B", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006A1C RID: 27164 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006A1C")]
		[Address(RVA = "0xB53C", Offset = "0xB53C", VA = "0xB53C")]
		public TournamentsWindow ShowTournamentWindow()
		{
			return null;
		}

		// Token: 0x06006A1D RID: 27165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A1D")]
		[Address(RVA = "0xB53D", Offset = "0xB53D", VA = "0xB53D")]
		public void ReconnectToCombat()
		{
		}

		// Token: 0x06006A1E RID: 27166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A1E")]
		[Address(RVA = "0xB53E", Offset = "0xB53E", VA = "0xB53E")]
		public TournamentsManager()
		{
		}

		// Token: 0x04003832 RID: 14386
		[Token(Token = "0x4003832")]
		[FieldOffset(Offset = "0x10")]
		private TournamentsEvents _events;

		// Token: 0x04003833 RID: 14387
		[Token(Token = "0x4003833")]
		[FieldOffset(Offset = "0x14")]
		private TournamentsModel _model;
	}
}
