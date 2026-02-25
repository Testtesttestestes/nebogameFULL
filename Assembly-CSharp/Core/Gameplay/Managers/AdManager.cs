using System;
using System.Runtime.CompilerServices;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Model;
using Core.Gameplay.Managers.Ad.Statistics;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200113D RID: 4413
	[Token(Token = "0x200113D")]
	public class AdManager : IGameManager, IBaseManager
	{
		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x06006768 RID: 26472 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700152B")]
		public string Name
		{
			[Token(Token = "0x6006768")]
			[Address(RVA = "0xB294", Offset = "0xB294", VA = "0xB294", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000256 RID: 598
		// (add) Token: 0x06006769 RID: 26473 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600676A RID: 26474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000256")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006769")]
			[Address(RVA = "0xB295", Offset = "0xB295", VA = "0xB295", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600676A")]
			[Address(RVA = "0xB296", Offset = "0xB296", VA = "0xB296", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000257 RID: 599
		// (add) Token: 0x0600676B RID: 26475 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600676C RID: 26476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000257")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x600676B")]
			[Address(RVA = "0xB297", Offset = "0xB297", VA = "0xB297", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600676C")]
			[Address(RVA = "0xB298", Offset = "0xB298", VA = "0xB298", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x0600676D RID: 26477 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700152C")]
		public AbstractAdController Controller
		{
			[Token(Token = "0x600676D")]
			[Address(RVA = "0xB299", Offset = "0xB299", VA = "0xB299")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x0600676E RID: 26478 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700152D")]
		public AbstractAdModel Model
		{
			[Token(Token = "0x600676E")]
			[Address(RVA = "0xB29A", Offset = "0xB29A", VA = "0xB29A")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x0600676F RID: 26479 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700152E")]
		public AdEvents Events
		{
			[Token(Token = "0x600676F")]
			[Address(RVA = "0xB29B", Offset = "0xB29B", VA = "0xB29B")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006770 RID: 26480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006770")]
		[Address(RVA = "0xB29C", Offset = "0xB29C", VA = "0xB29C", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006771 RID: 26481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006771")]
		[Address(RVA = "0xB29D", Offset = "0xB29D", VA = "0xB29D", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006772 RID: 26482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006772")]
		[Address(RVA = "0xB29E", Offset = "0xB29E", VA = "0xB29E")]
		private void SetupMvc()
		{
		}

		// Token: 0x06006773 RID: 26483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006773")]
		[Address(RVA = "0xB29F", Offset = "0xB29F", VA = "0xB29F")]
		private void InitEvent()
		{
		}

		// Token: 0x06006774 RID: 26484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006774")]
		[Address(RVA = "0xB2A0", Offset = "0xB2A0", VA = "0xB2A0")]
		private void DestroyMvc()
		{
		}

		// Token: 0x06006775 RID: 26485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006775")]
		[Address(RVA = "0xB2A1", Offset = "0xB2A1", VA = "0xB2A1")]
		public AdManager()
		{
		}

		// Token: 0x04003737 RID: 14135
		[Token(Token = "0x4003737")]
		[FieldOffset(Offset = "0x10")]
		private AbstractAdController _controller;

		// Token: 0x04003738 RID: 14136
		[Token(Token = "0x4003738")]
		[FieldOffset(Offset = "0x14")]
		private AbstractAdModel _model;

		// Token: 0x04003739 RID: 14137
		[Token(Token = "0x4003739")]
		[FieldOffset(Offset = "0x18")]
		private AdEvents _events;

		// Token: 0x0400373A RID: 14138
		[Token(Token = "0x400373A")]
		[FieldOffset(Offset = "0x1C")]
		private AdStatisticsHelper _statisticsHelper;
	}
}
