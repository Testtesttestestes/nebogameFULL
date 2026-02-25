using System;
using System.Runtime.CompilerServices;
using Core.Gameplay.Managers.Notifications.Controller;
using Core.Gameplay.Managers.Notifications.Events;
using Core.Gameplay.Managers.Notifications.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Notifications
{
	// Token: 0x020011A5 RID: 4517
	[Token(Token = "0x20011A5")]
	public class GameNotificationsManager : IGameManager, IBaseManager
	{
		// Token: 0x140002BE RID: 702
		// (add) Token: 0x06006B56 RID: 27478 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006B57 RID: 27479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002BE")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006B56")]
			[Address(RVA = "0xB654", Offset = "0xB654", VA = "0xB654", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006B57")]
			[Address(RVA = "0xB655", Offset = "0xB655", VA = "0xB655", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002BF RID: 703
		// (add) Token: 0x06006B58 RID: 27480 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006B59 RID: 27481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002BF")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006B58")]
			[Address(RVA = "0xB656", Offset = "0xB656", VA = "0xB656", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006B59")]
			[Address(RVA = "0xB657", Offset = "0xB657", VA = "0xB657", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x06006B5A RID: 27482 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015E0")]
		public GameNotificationsController Controller
		{
			[Token(Token = "0x6006B5A")]
			[Address(RVA = "0xB658", Offset = "0xB658", VA = "0xB658")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x06006B5B RID: 27483 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015E1")]
		public GameNotificationsModel Model
		{
			[Token(Token = "0x6006B5B")]
			[Address(RVA = "0xB659", Offset = "0xB659", VA = "0xB659")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x06006B5C RID: 27484 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015E2")]
		public GameNotificationsEvents Events
		{
			[Token(Token = "0x6006B5C")]
			[Address(RVA = "0xB65A", Offset = "0xB65A", VA = "0xB65A")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006B5D RID: 27485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B5D")]
		[Address(RVA = "0xB65B", Offset = "0xB65B", VA = "0xB65B", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006B5E RID: 27486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B5E")]
		[Address(RVA = "0xB65C", Offset = "0xB65C", VA = "0xB65C", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006B5F RID: 27487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B5F")]
		[Address(RVA = "0xB65D", Offset = "0xB65D", VA = "0xB65D")]
		private void SetupMvc()
		{
		}

		// Token: 0x06006B60 RID: 27488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B60")]
		[Address(RVA = "0xB65E", Offset = "0xB65E", VA = "0xB65E")]
		private void InitEvent()
		{
		}

		// Token: 0x06006B61 RID: 27489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B61")]
		[Address(RVA = "0xB65F", Offset = "0xB65F", VA = "0xB65F")]
		private void DestroyMvc()
		{
		}

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x06006B62 RID: 27490 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015E3")]
		public string Name
		{
			[Token(Token = "0x6006B62")]
			[Address(RVA = "0xB660", Offset = "0xB660", VA = "0xB660", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006B63 RID: 27491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B63")]
		[Address(RVA = "0xB661", Offset = "0xB661", VA = "0xB661")]
		public GameNotificationsManager()
		{
		}

		// Token: 0x040038AE RID: 14510
		[Token(Token = "0x40038AE")]
		[FieldOffset(Offset = "0x10")]
		private GameNotificationsController _controller;

		// Token: 0x040038AF RID: 14511
		[Token(Token = "0x40038AF")]
		[FieldOffset(Offset = "0x14")]
		private GameNotificationsModel _model;

		// Token: 0x040038B0 RID: 14512
		[Token(Token = "0x40038B0")]
		[FieldOffset(Offset = "0x18")]
		private GameNotificationsEvents _events;
	}
}
