using System;
using System.Runtime.CompilerServices;
using Gameplay.SmallGames.Controller;
using Gameplay.SmallGames.Events;
using Gameplay.SmallGames.Model;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using Protocol.SmallGames;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001179 RID: 4473
	[Token(Token = "0x2001179")]
	public class SmallGamesManager : IGameManager, IBaseManager
	{
		// Token: 0x1400029E RID: 670
		// (add) Token: 0x060069D9 RID: 27097 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069DA RID: 27098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400029E")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60069D9")]
			[Address(RVA = "0xB4F9", Offset = "0xB4F9", VA = "0xB4F9", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069DA")]
			[Address(RVA = "0xB4FA", Offset = "0xB4FA", VA = "0xB4FA", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400029F RID: 671
		// (add) Token: 0x060069DB RID: 27099 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069DC RID: 27100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400029F")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60069DB")]
			[Address(RVA = "0xB4FB", Offset = "0xB4FB", VA = "0xB4FB", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069DC")]
			[Address(RVA = "0xB4FC", Offset = "0xB4FC", VA = "0xB4FC", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060069DD RID: 27101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069DD")]
		[Address(RVA = "0xB4FD", Offset = "0xB4FD", VA = "0xB4FD", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x060069DE RID: 27102 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015A9")]
		public SmallGamesController Controller
		{
			[Token(Token = "0x60069DE")]
			[Address(RVA = "0xB4FE", Offset = "0xB4FE", VA = "0xB4FE")]
			get
			{
				return null;
			}
		}

		// Token: 0x060069DF RID: 27103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069DF")]
		[Address(RVA = "0xB4FF", Offset = "0xB4FF", VA = "0xB4FF")]
		public void SetView(UserInterfaceView view)
		{
		}

		// Token: 0x060069E0 RID: 27104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069E0")]
		[Address(RVA = "0xB500", Offset = "0xB500", VA = "0xB500")]
		private void HandleFeatureInitEvent()
		{
		}

		// Token: 0x060069E1 RID: 27105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069E1")]
		[Address(RVA = "0xB501", Offset = "0xB501", VA = "0xB501", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x060069E2 RID: 27106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069E2")]
		[Address(RVA = "0xB502", Offset = "0xB502", VA = "0xB502")]
		public void ShowSmallGamesWindow(SlotMachineType slotMachineType = SlotMachineType.UnknownMachine)
		{
		}

		// Token: 0x060069E3 RID: 27107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069E3")]
		[Address(RVA = "0xB503", Offset = "0xB503", VA = "0xB503")]
		public void ShowDailyRewardsWindow()
		{
		}

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x060069E4 RID: 27108 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015AA")]
		public string Name
		{
			[Token(Token = "0x60069E4")]
			[Address(RVA = "0xB504", Offset = "0xB504", VA = "0xB504", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060069E5 RID: 27109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069E5")]
		[Address(RVA = "0xB505", Offset = "0xB505", VA = "0xB505")]
		public SmallGamesManager()
		{
		}

		// Token: 0x0400381D RID: 14365
		[Token(Token = "0x400381D")]
		[FieldOffset(Offset = "0x10")]
		private Gameplay.SmallGames.Events.SmallGamesEvents _events;

		// Token: 0x0400381E RID: 14366
		[Token(Token = "0x400381E")]
		[FieldOffset(Offset = "0x14")]
		private SmallGamesModel _model;

		// Token: 0x0400381F RID: 14367
		[Token(Token = "0x400381F")]
		[FieldOffset(Offset = "0x18")]
		private SmallGamesController _controller;

		// Token: 0x04003820 RID: 14368
		[Token(Token = "0x4003820")]
		[FieldOffset(Offset = "0x1C")]
		private SmallGamesEnterPointViewMediator _mediator;
	}
}
