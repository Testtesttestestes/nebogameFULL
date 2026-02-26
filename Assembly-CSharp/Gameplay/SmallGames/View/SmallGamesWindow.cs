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
		/* --- GHIDRA: GetSlotsWheels ---
		void Gameplay_SmallGames_View_SmallGamesWindow__GetSlotsWheels
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58678 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_SmallGamesWindow_SmallGamesWindowArgs__OnShow__
		              );
		    DAT_ram_00a58678 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_SmallGamesWindow_SmallGamesWindowArgs__OnShow__)
		  ;
		  Gameplay_SmallGames_View_SmallGamesWindow__OnClose(param1,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F47")]
		[Address(RVA = "0x70AD", Offset = "0x70AD", VA = "0x70AD", Slot = "22")]
		protected override void OnShow(SmallGamesWindow.SmallGamesWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_SmallGames_View_SmallGamesWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58679 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_SmallGamesWindow_SmallGamesWindowArgs__OnClose__
		              );
		    DAT_ram_00a58679 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_SmallGamesWindow_SmallGamesWindowArgs__OnClose__);
		  if (*(char *)(param1 + 0x68) != '\0') {
		    iVar1 = **(int **)(param1 + 100);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 100),*(undefined4 *)(iVar1 + 0x134));
		    *(undefined4 *)(param1 + 100) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F48")]
		[Address(RVA = "0x70AE", Offset = "0x70AE", VA = "0x70AE", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_SmallGames_View_SmallGamesWindow__OnClose(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param3;
		  int iVar2;
		  int *param1_00;
		  int *param4;
		  
		  if (DAT_ram_00a5867a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_SmallGamesWindow_SmallGamesWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_SmallGames_Controller_SmallGamesViewMediator_TypeInfo);
		    DAT_ram_00a5867a = '\x01';
		  }
		  if (*(char *)(param1 + 0x68) == '\0') {
		    iVar1 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_SmallGamesWindow_SmallGamesWindowArgs__get_WindowArgs__
		                        );
		    param4 = *(int **)(iVar1 + 0x1c);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x100) * 4))
		                      (param4,*(undefined4 *)(*param4 + 0x104));
		    param3 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x110) * 4))
		                       (param4,*(undefined4 *)(*param4 + 0x114));
		    iVar2 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_SmallGamesWindow_SmallGamesWindowArgs__get_WindowArgs__
		                        );
		    if (*(int *)(iVar2 + 0x18) != 0) {
		      iVar2 = func_ii_8093(param1,
		                           Method_UI_Windows_BaseWindow_SmallGamesWindow_SmallGamesWindowArgs__get_WindowArgs__
		                          );
		      *(undefined4 *)(iVar1 + 0x38) = *(undefined4 *)(iVar2 + 0x18);
		    }
		    param1_00 = (int *)unnamed_function_1417
		                                 (Gameplay_SmallGames_Controller_SmallGamesViewMediator_TypeInfo);
		    Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c__DisplayClass6_0___ArtifactDropRemoveEventHandler_b__0
		              (param1_00,iVar1,param3,param4,0);
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		              (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		    *(undefined1 *)(param1 + 0x68) = 1;
		    *(int **)(param1 + 100) = param1_00;
		  }
		  return;
		}
		*/

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
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_SmallGames_View_SmallGamesWindow__DestroyMVC(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5867b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_SmallGamesWindow_SmallGamesWindowArgs___ctor__)
		    ;
		    DAT_ram_00a5867b = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_SmallGamesWindow_SmallGamesWindowArgs___ctor__);
		  return;
		}
		*/

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

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_CurrentSlotWheelsView ---
		undefined4
		Gameplay_SmallGames_View_SmallGamesWindow__set_CurrentSlotWheelsView
		          (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int local_4;
		  
		  iVar4 = *(int *)(*(int *)(param1 + 0x5c) + 0xc);
		  if (0 < iVar4) {
		    iVar1 = 0;
		    do {
		      iVar5 = *(int *)(*(int *)(param1 + 0x5c) + iVar1 * 4 + 0x10);
		      if (*(int *)(iVar5 + 8) == param2) {
		        return *(undefined4 *)(iVar5 + 0xc);
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar4);
		  }
		  local_4 = param2;
		  uVar2 = unnamed_function_2232(&Protocol_SmallGames_SlotMachineType_TypeInfo);
		  uVar2 = func_ii_1081(uVar2,&local_4);
		  uVar3 = unnamed_function_2232(&StringLiteral_11649);
		  uVar2 = func_ii_4419(uVar3,uVar2,0);
		  uVar3 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar3 = unnamed_function_1417(uVar3);
		  System_String__Concat(uVar3,uVar2,0);
		  uVar2 = unnamed_function_2232(&Method_Gameplay_SmallGames_View_SmallGamesWindow_GetSlotsWheels__);
		  func_ii_1050(uVar3,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
