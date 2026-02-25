using System;
using System.Runtime.CompilerServices;
using Gameplay.SmallGames.Controller;
using Il2CppDummyDll;
using Protocol.SmallGames;
using UI.Elements.ProgressBars;
using UI.Tabs;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.SmallGames.View
{
	// Token: 0x02000520 RID: 1312
	[Token(Token = "0x2000520")]
	public class SmallGamesWindow : ClosableBaseWindow<SmallGamesWindow.SmallGamesWindowArgs>
	{
		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001F3B RID: 7995 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005AF")]
		public override string WindowId
		{
			[Token(Token = "0x6001F3B")]
			[Address(RVA = "0x70A1", Offset = "0x70A1", VA = "0x70A1", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001F3C RID: 7996 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005B0")]
		public LastJackpotsView LastJackpots
		{
			[Token(Token = "0x6001F3C")]
			[Address(RVA = "0x70A2", Offset = "0x70A2", VA = "0x70A2")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001F3D RID: 7997 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005B1")]
		public SmallGamesResourceRenderer Jackpot
		{
			[Token(Token = "0x6001F3D")]
			[Address(RVA = "0x70A3", Offset = "0x70A3", VA = "0x70A3")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001F3E RID: 7998 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005B2")]
		public SpinButtonView SpinButtonView
		{
			[Token(Token = "0x6001F3E")]
			[Address(RVA = "0x70A4", Offset = "0x70A4", VA = "0x70A4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001F3F RID: 7999 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005B3")]
		public RewardsDisplay RewardsDisplay
		{
			[Token(Token = "0x6001F3F")]
			[Address(RVA = "0x70A5", Offset = "0x70A5", VA = "0x70A5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001F40 RID: 8000 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005B4")]
		public ProgressBarWithTimer Timer
		{
			[Token(Token = "0x6001F40")]
			[Address(RVA = "0x70A6", Offset = "0x70A6", VA = "0x70A6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001F41 RID: 8001 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005B5")]
		public GameObject TimerRoot
		{
			[Token(Token = "0x6001F41")]
			[Address(RVA = "0x70A7", Offset = "0x70A7", VA = "0x70A7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001F42 RID: 8002 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005B6")]
		public TabBar TabBar
		{
			[Token(Token = "0x6001F42")]
			[Address(RVA = "0x70A8", Offset = "0x70A8", VA = "0x70A8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001F43 RID: 8003 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005B7")]
		public Button WinningCombinationsButton
		{
			[Token(Token = "0x6001F43")]
			[Address(RVA = "0x70A9", Offset = "0x70A9", VA = "0x70A9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001F44 RID: 8004 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001F45 RID: 8005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005B8")]
		public SlotWheelsView CurrentSlotWheelsView
		{
			[Token(Token = "0x6001F44")]
			[Address(RVA = "0x70AA", Offset = "0x70AA", VA = "0x70AA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F45")]
			[Address(RVA = "0x70AB", Offset = "0x70AB", VA = "0x70AB")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001F46")]
		[Address(RVA = "0x70AC", Offset = "0x70AC", VA = "0x70AC")]
		public SlotWheelsView GetSlotsWheels(SlotMachineType type)
		{
			return null;
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F47")]
		[Address(RVA = "0x70AD", Offset = "0x70AD", VA = "0x70AD", Slot = "22")]
		protected override void OnShow(SmallGamesWindow.SmallGamesWindowArgs args)
		{
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F48")]
		[Address(RVA = "0x70AE", Offset = "0x70AE", VA = "0x70AE", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F49")]
		[Address(RVA = "0x70AF", Offset = "0x70AF", VA = "0x70AF")]
		private void SetupMVC()
		{
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F4A")]
		[Address(RVA = "0x70B0", Offset = "0x70B0", VA = "0x70B0")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F4B")]
		[Address(RVA = "0x70B1", Offset = "0x70B1", VA = "0x70B1")]
		public SmallGamesWindow()
		{
		}

		// Token: 0x040010F5 RID: 4341
		[Token(Token = "0x40010F5")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/SmallGames/SmallGamesWindow";

		// Token: 0x040010F6 RID: 4342
		[Token(Token = "0x40010F6")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private LastJackpotsView _lastJackpots;

		// Token: 0x040010F7 RID: 4343
		[Token(Token = "0x40010F7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SmallGamesResourceRenderer _jackpotRenderer;

		// Token: 0x040010F8 RID: 4344
		[Token(Token = "0x40010F8")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private SpinButtonView _spinButtonView;

		// Token: 0x040010F9 RID: 4345
		[Token(Token = "0x40010F9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RewardsDisplay _rewards;

		// Token: 0x040010FA RID: 4346
		[Token(Token = "0x40010FA")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ProgressBarWithTimer _timer;

		// Token: 0x040010FB RID: 4347
		[Token(Token = "0x40010FB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _timerRoot;

		// Token: 0x040010FC RID: 4348
		[Token(Token = "0x40010FC")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x040010FD RID: 4349
		[Token(Token = "0x40010FD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _winningCombinationsButton;

		// Token: 0x040010FE RID: 4350
		[Token(Token = "0x40010FE")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private SmallGamesWindow.SlotsWheelConfig[] _slotsWheels;

		// Token: 0x04001100 RID: 4352
		[Token(Token = "0x4001100")]
		[FieldOffset(Offset = "0x64")]
		private SmallGamesViewMediator _mediator;

		// Token: 0x04001101 RID: 4353
		[Token(Token = "0x4001101")]
		[FieldOffset(Offset = "0x68")]
		private bool _mvcSetUp;

		// Token: 0x02000521 RID: 1313
		[Token(Token = "0x2000521")]
		[Serializable]
		public class SlotsWheelConfig
		{
			// Token: 0x06001F4C RID: 8012 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F4C")]
			[Address(RVA = "0x70B2", Offset = "0x70B2", VA = "0x70B2")]
			public SlotsWheelConfig()
			{
			}

			// Token: 0x04001102 RID: 4354
			[Token(Token = "0x4001102")]
			[FieldOffset(Offset = "0x8")]
			public SlotMachineType SlotMachineType;

			// Token: 0x04001103 RID: 4355
			[Token(Token = "0x4001103")]
			[FieldOffset(Offset = "0xC")]
			public SlotWheelsView Wheels;
		}

		// Token: 0x02000522 RID: 1314
		[Token(Token = "0x2000522")]
		public class SmallGamesWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001F4D RID: 8013 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F4D")]
			[Address(RVA = "0x70B3", Offset = "0x70B3", VA = "0x70B3")]
			public SmallGamesWindowArgs(SlotMachineType slotMachineType, SmallGamesController controller)
			{
			}

			// Token: 0x04001104 RID: 4356
			[Token(Token = "0x4001104")]
			[FieldOffset(Offset = "0x18")]
			public readonly SlotMachineType SlotMachineType;

			// Token: 0x04001105 RID: 4357
			[Token(Token = "0x4001105")]
			[FieldOffset(Offset = "0x1C")]
			public SmallGamesController Controller;
		}
	}
}
