using System;
using System.Runtime.CompilerServices;
using Gameplay.RateGame.Controller;
using Gameplay.RateGame.Events;
using Gameplay.RateGame.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.RateGame.View
{
	// Token: 0x020005A4 RID: 1444
	[Token(Token = "0x20005A4")]
	public class RateGameWindow : BaseDialogWindow<RateGameWindow.RateGameWindowArgs>
	{
		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x060022B1 RID: 8881 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000653")]
		public RateWindowStateController StateController
		{
			[Token(Token = "0x60022B1")]
			[Address(RVA = "0x7408", Offset = "0x7408", VA = "0x7408")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x060022B2 RID: 8882 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000654")]
		public Button PositiveRateButton
		{
			[Token(Token = "0x60022B2")]
			[Address(RVA = "0x7409", Offset = "0x7409", VA = "0x7409")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x060022B3 RID: 8883 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000655")]
		public Button NegativeRateButton
		{
			[Token(Token = "0x60022B3")]
			[Address(RVA = "0x740A", Offset = "0x740A", VA = "0x740A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x060022B4 RID: 8884 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000656")]
		public Button RateGameButton
		{
			[Token(Token = "0x60022B4")]
			[Address(RVA = "0x740B", Offset = "0x740B", VA = "0x740B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x00006D68 File Offset: 0x00004F68
		[Token(Token = "0x17000657")]
		public int CurrentRateValue
		{
			[Token(Token = "0x60022B5")]
			[Address(RVA = "0x740C", Offset = "0x740C", VA = "0x740C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1400014A RID: 330
		// (add) Token: 0x060022B6 RID: 8886 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060022B7 RID: 8887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400014A")]
		public event Action CloseButtonClickEvent
		{
			[Token(Token = "0x60022B6")]
			[Address(RVA = "0x740D", Offset = "0x740D", VA = "0x740D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60022B7")]
			[Address(RVA = "0x740E", Offset = "0x740E", VA = "0x740E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x060022B8 RID: 8888 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000658")]
		public override string WindowId
		{
			[Token(Token = "0x60022B8")]
			[Address(RVA = "0x740F", Offset = "0x740F", VA = "0x740F", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022B9")]
		[Address(RVA = "0x7410", Offset = "0x7410", VA = "0x7410", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		void Gameplay_RateGame_View_RateGameWindow__HandleContent(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a580c0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseDialogWindow_RateGameWindow_RateGameWindowArgs__OnShow__);
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_MonoBehaviourWithStates_ClientStateChangedDelegate_RateGameWindow_RateGameWindowState__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_RateGameWindow_RateGameWindowState__add_CurrentStateChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_RateGame_Controller_RateGameWindowMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_RateGame_View_RateGameWindow_StateControllerOnCurrentStateChangedEvent__
		              );
		    DAT_ram_00a580c0 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___OnDestroy
		            (param1,param2,
		             Method_UI_Windows_BaseDialogWindow_RateGameWindow_RateGameWindowArgs__OnShow__);
		  uVar2 = *(undefined4 *)(param1 + 0x54);
		  uVar1 = unnamed_function_1417
		                    (
		                    UI_MonoBehaviourWithStates_ClientStateChangedDelegate_RateGameWindow_RateGameWindowState__TypeInfo
		                    );
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate_ByteEnum___Invoke
		            (uVar1,param1,
		             Method_Gameplay_RateGame_View_RateGameWindow_StateControllerOnCurrentStateChangedEvent__
		             ,0);
		  UI_MonoBehaviourWithStates_Int32Enum___HandleCurrentStateChanged
		            (uVar2,uVar1,
		             Method_UI_MonoBehaviourWithStates_RateGameWindow_RateGameWindowState__add_CurrentStateChangedEvent__
		            );
		  uVar1 = *(undefined4 *)(param2 + 0x2c);
		  uVar2 = *(undefined4 *)(param2 + 0x34);
		  param2_00 = *(undefined4 *)(param2 + 0x30);
		  param1_00 = (int *)unnamed_function_1417
		                               (Gameplay_RateGame_Controller_RateGameWindowMediator_TypeInfo);
		  if (DAT_ram_00a580d2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RateGameModel__RateGameEvents__RateGameController__RateGameWindow___ctor__
		              );
		    DAT_ram_00a580d2 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1_00,param2_00,uVar2,uVar1,
		             Method_MVC_AbstractViewMediator_RateGameModel__RateGameEvents__RateGameController__RateGameWindow___ctor__
		            );
		  *(int **)(param1 + 0x68) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x060022BA RID: 8890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022BA")]
		[Address(RVA = "0x7411", Offset = "0x7411", VA = "0x7411", Slot = "22")]
		protected override void OnShow(RateGameWindow.RateGameWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_RateGame_View_RateGameWindow__OnShow
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a580c1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_RateGame_View_RateGameWindow_RateGameWindowState_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13089);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13090);
		    DAT_ram_00a580c1 = '\x01';
		  }
		  local_4 = param3;
		  uVar1 = func_ii_1081(Gameplay_RateGame_View_RateGameWindow_RateGameWindowState_TypeInfo,&local_4);
		  uVar1 = func_ii_4419(StringLiteral_13090,uVar1,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar1,1,0,1,0,0,0,0);
		  if (DAT_ram_00a580c2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_RateGameWindow_RateGameWindowArgs__get_WindowArgs__);
		    DAT_ram_00a580c2 = '\x01';
		  }
		  iVar2 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_RateGameWindow_RateGameWindowArgs__get_WindowArgs__
		                      );
		  *(undefined4 *)(iVar2 + 0x18) = uVar1;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 400) * 4))(param1,*(undefined4 *)(*param1 + 0x194));
		  local_8 = param3;
		  uVar1 = func_ii_1081(Gameplay_RateGame_View_RateGameWindow_RateGameWindowState_TypeInfo,&local_8);
		  uVar1 = func_ii_4419(StringLiteral_13089,uVar1,0);
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar1,1,0,1,0,0,0,0);
		  if (DAT_ram_00a580c3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_RateGameWindow_RateGameWindowArgs__get_WindowArgs__);
		    DAT_ram_00a580c3 = '\x01';
		  }
		  iVar2 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_RateGameWindow_RateGameWindowArgs__get_WindowArgs__
		                      );
		  *(undefined4 *)(iVar2 + 0x1c) = uVar1;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x198) * 4))(param1,*(undefined4 *)(*param1 + 0x19c));
		  return;
		}
		*/

		}

		// Token: 0x060022BB RID: 8891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022BB")]
		[Address(RVA = "0x7412", Offset = "0x7412", VA = "0x7412")]
		private void StateControllerOnCurrentStateChangedEvent(RateGameWindow.RateGameWindowState fromState, RateGameWindow.RateGameWindowState toState)
		{
		/* --- GHIDRA: StateControllerOnCurrentStateChangedEvent ---
		void Gameplay_RateGame_View_RateGameWindow__StateControllerOnCurrentStateChangedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a580c2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_RateGameWindow_RateGameWindowArgs__get_WindowArgs__);
		    DAT_ram_00a580c2 = '\x01';
		  }
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_RateGameWindow_RateGameWindowArgs__get_WindowArgs__
		                      );
		  *(undefined4 *)(iVar1 + 0x18) = param2;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 400) * 4))(param1,*(undefined4 *)(*param1 + 0x194));
		  return;
		}
		*/

		}

		// Token: 0x17000659 RID: 1625
		// (set) Token: 0x060022BC RID: 8892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000659")]
		private string Title
		{
			[Token(Token = "0x60022BC")]
			[Address(RVA = "0x7413", Offset = "0x7413", VA = "0x7413")]
			set
			{
			}
		}

		// Token: 0x1700065A RID: 1626
		// (set) Token: 0x060022BD RID: 8893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700065A")]
		private string Desc
		{
			[Token(Token = "0x60022BD")]
			[Address(RVA = "0x7414", Offset = "0x7414", VA = "0x7414")]
			set
			{
			}
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022BE")]
		[Address(RVA = "0x7415", Offset = "0x7415", VA = "0x7415", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_RateGame_View_RateGameWindow__OnClose(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a580c5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_WindowWhitCloseButton_RateGameWindow_RateGameWindowArgs__HandleCloseButton__
		              );
		    DAT_ram_00a580c5 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 100);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  UI_Windows_WindowWhitCloseButton_object___Awake
		            (param1,
		             Method_UI_Windows_WindowWhitCloseButton_RateGameWindow_RateGameWindowArgs__HandleCloseButton__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060022BF RID: 8895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022BF")]
		[Address(RVA = "0x7416", Offset = "0x7416", VA = "0x7416", Slot = "25")]
		protected override void HandleCloseButton()
		{
		/* --- GHIDRA: HandleCloseButton ---
		void Gameplay_RateGame_View_RateGameWindow__HandleCloseButton(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a580c6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseDialogWindow_RateGameWindow_RateGameWindowArgs___ctor__);
		    DAT_ram_00a580c6 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,Method_UI_Windows_BaseDialogWindow_RateGameWindow_RateGameWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022C0")]
		[Address(RVA = "0x7417", Offset = "0x7417", VA = "0x7417")]
		public RateGameWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_RateGame_View_RateGameWindow___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a580c7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_RateGameWindow_RateGameWindowArgs___ctor__
		              );
		    DAT_ram_00a580c7 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_RateGameWindow_RateGameWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x040012F0 RID: 4848
		[Token(Token = "0x40012F0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RateGameComponent _rateGameComponent;

		// Token: 0x040012F1 RID: 4849
		[Token(Token = "0x40012F1")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private RateWindowStateController _stateController;

		// Token: 0x040012F2 RID: 4850
		[Token(Token = "0x40012F2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _rateGameButton;

		// Token: 0x040012F3 RID: 4851
		[Token(Token = "0x40012F3")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Button _negativeRateButton;

		// Token: 0x040012F4 RID: 4852
		[Token(Token = "0x40012F4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _positiveRateButton;

		// Token: 0x040012F6 RID: 4854
		[Token(Token = "0x40012F6")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/RateGameWindow";

		// Token: 0x040012F7 RID: 4855
		[Token(Token = "0x40012F7")]
		[FieldOffset(Offset = "0x68")]
		private RateGameWindowMediator _mediator;

		// Token: 0x020005A5 RID: 1445
		[Token(Token = "0x20005A5")]
		public enum RateGameWindowState
		{
			// Token: 0x040012F9 RID: 4857
			[Token(Token = "0x40012F9")]
			UNKNOWN_STATE,
			// Token: 0x040012FA RID: 4858
			[Token(Token = "0x40012FA")]
			DEFAULT,
			// Token: 0x040012FB RID: 4859
			[Token(Token = "0x40012FB")]
			NEGATIVE_FEEDBACK,
			// Token: 0x040012FC RID: 4860
			[Token(Token = "0x40012FC")]
			POSITIVE_FEEDBACK
		}

		// Token: 0x020005A6 RID: 1446
		[Token(Token = "0x20005A6")]
		public class RateGameWindowArgs : BaseDialogWindow<RateGameWindow.RateGameWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x060022C1 RID: 8897 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60022C1")]
			[Address(RVA = "0x7418", Offset = "0x7418", VA = "0x7418")]
			public RateGameWindowArgs()
			{
			}

			// Token: 0x040012FD RID: 4861
			[Token(Token = "0x40012FD")]
			[FieldOffset(Offset = "0x2C")]
			public RateGameController Controller;

			// Token: 0x040012FE RID: 4862
			[Token(Token = "0x40012FE")]
			[FieldOffset(Offset = "0x30")]
			public RateGameModel Model;

			// Token: 0x040012FF RID: 4863
			[Token(Token = "0x40012FF")]
			[FieldOffset(Offset = "0x34")]
			public RateGameEvents Events;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RateGameButton ---
		undefined4 Gameplay_RateGame_View_RateGameWindow__get_RateGameButton(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x50) + 0x14);
		}
		*/


		/* --- GHIDRA: get_CurrentRateValue ---
		void Gameplay_RateGame_View_RateGameWindow__get_CurrentRateValue
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a580bc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a580bc = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 100);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 100,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_CloseButtonClickEvent ---
		void Gameplay_RateGame_View_RateGameWindow__add_CloseButtonClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a580bd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a580bd = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 100);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 100,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_CloseButtonClickEvent ---
		undefined4
		Gameplay_RateGame_View_RateGameWindow__remove_CloseButtonClickEvent
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a580be == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12660);
		    DAT_ram_00a580be = '\x01';
		  }
		  return StringLiteral_12660;
		}
		*/


		/* --- GHIDRA: get_WindowId ---
		void Gameplay_RateGame_View_RateGameWindow__get_WindowId(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a580bf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_RateGameWindow_RateGameWindowArgs__HandleContent__
		              );
		    DAT_ram_00a580bf = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_RateGameWindow_RateGameWindowArgs__HandleContent__);
		  param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param1 + 0x50),0);
		  Gameplay_SmallGames_View_SmallGamesResourceRenderer__Init(param1_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Title ---
		void Gameplay_RateGame_View_RateGameWindow__set_Title
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a580c3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_RateGameWindow_RateGameWindowArgs__get_WindowArgs__);
		    DAT_ram_00a580c3 = '\x01';
		  }
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_RateGameWindow_RateGameWindowArgs__get_WindowArgs__
		                      );
		  *(undefined4 *)(iVar1 + 0x1c) = param2;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x198) * 4))(param1,*(undefined4 *)(*param1 + 0x19c));
		  return;
		}
		*/


		/* --- GHIDRA: set_Desc ---
		void Gameplay_RateGame_View_RateGameWindow__set_Desc(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a580c4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseDialogWindow_RateGameWindow_RateGameWindowArgs__OnClose__);
		    DAT_ram_00a580c4 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleTitle
		            (param1,Method_UI_Windows_BaseDialogWindow_RateGameWindow_RateGameWindowArgs__OnClose__)
		  ;
		  piVar1 = *(int **)(param1 + 0x68);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x68) = 0;
		  return;
		}
		*/

}
