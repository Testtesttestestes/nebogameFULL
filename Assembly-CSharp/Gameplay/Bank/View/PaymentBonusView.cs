using System;
using AssetContent;
using Gameplay.Bank.Controller;
using Il2CppDummyDll;
using UI;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C4C RID: 3148
	[Token(Token = "0x2000C4C")]
	public class PaymentBonusView : MonoBehaviour, IToolTipDataProvider
	{
		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06004CBF RID: 19647 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F79")]
		public BacktimeViewUGUI BacktimeView
		{
			[Token(Token = "0x6004CBF")]
			[Address(RVA = "0x9AFC", Offset = "0x9AFC", VA = "0x9AFC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06004CC0 RID: 19648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F7A")]
		public GameAnimatedButton GameAnimatedButton
		{
			[Token(Token = "0x6004CC0")]
			[Address(RVA = "0x9AFD", Offset = "0x9AFD", VA = "0x9AFD")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004CC1 RID: 19649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CC1")]
		[Address(RVA = "0x9AFE", Offset = "0x9AFE", VA = "0x9AFE")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Bank_View_PaymentBonusView__OnDestroy(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 param4;
		  
		  if (DAT_ram_00a597a9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAnimationView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Controller_PaymentBonusViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_View_PaymentBonusView_GameAnimationViewOnAnimationReadyEvent__)
		    ;
		    DAT_ram_00a597a9 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 400);
		        goto code_r0x81069c27;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x81069c27:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar5 = *(undefined4 *)(iVar4 + 0x1c);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 400);
		        goto code_r0x81069cd6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x81069cd6:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar6 = *(undefined4 *)(iVar4 + 0x18);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 400);
		        goto code_r0x81069d85;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x81069d85:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param4 = *(undefined4 *)(iVar4 + 0x14);
		  param1_00 = unnamed_function_1417(Gameplay_Bank_Controller_PaymentBonusViewMediator_TypeInfo);
		  if (DAT_ram_00a5981e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PaymentBonusModel__PaymentBonusEvents__PaymentBonusController__PaymentBonusView___ctor__
		              );
		    DAT_ram_00a5981e = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1_00,uVar5,uVar6,param4,
		             Method_MVC_AbstractViewMediator_PaymentBonusModel__PaymentBonusEvents__PaymentBonusController__PaymentBonusView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  uVar6 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x10);
		  uVar5 = unnamed_function_1417(System_Action_GameAnimationView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,
		             Method_Gameplay_Bank_View_PaymentBonusView_GameAnimationViewOnAnimationReadyEvent__,0);
		  AssetContent_GameAnimationView__remove_ClickEvent(uVar6,uVar5,0);
		  iVar4 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x160) * 4))
		            (*(int **)(param1 + 0x18),param1,*(undefined4 *)(iVar4 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x06004CC2 RID: 19650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CC2")]
		[Address(RVA = "0x9AFF", Offset = "0x9AFF", VA = "0x9AFF")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Bank_View_PaymentBonusView__Start(undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a597aa == '\0') {
		    Mono_Security_ASN1__get_Item(&Animations_SpineUiButtonAnimation_TypeInfo);
		    DAT_ram_00a597aa = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x3c);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(Animations_SpineUiButtonAnimation_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*param1_00 + 0xb8)) &&
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(Animations_SpineUiButtonAnimation_TypeInfo + 0xb8) * 4 + -4) ==
		        Animations_SpineUiButtonAnimation_TypeInfo)) {
		      Animations_SpineUiButtonAnimation__get_DemoMode(param1_00,1,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004CC3 RID: 19651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CC3")]
		[Address(RVA = "0x9B00", Offset = "0x9B00", VA = "0x9B00")]
		private void GameAnimationViewOnAnimationReadyEvent(GameAnimationView animation)
		{
		/* --- GHIDRA: GameAnimationViewOnAnimationReadyEvent ---
		int Gameplay_Bank_View_PaymentBonusView__GameAnimationViewOnAnimationReadyEvent
		              (int param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a597ab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PaymentBonusModel__PaymentBonusEvents__PaymentBonusController__PaymentBonusView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_PaymentBonusModel___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_PaymentBonusModel__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_PaymentBonusModel__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12526);
		    DAT_ram_00a597ab = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_PaymentBonusModel__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12526,Method_UI_ToolTip_ToolTipData_PaymentBonusModel___ctor__)
		  ;
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(*(int *)(param1 + 0x18) + 8);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06004CC4 RID: 19652 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004CC4")]
		[Address(RVA = "0x9B01", Offset = "0x9B01", VA = "0x9B01", Slot = "4")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06004CC5 RID: 19653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CC5")]
		[Address(RVA = "0x9B02", Offset = "0x9B02", VA = "0x9B02")]
		public PaymentBonusView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Bank_View_PaymentBonusView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a597ac == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12573);
		    DAT_ram_00a597ac = '\x01';
		  }
		  return StringLiteral_12573;
		}
		*/

		}

		// Token: 0x040029E6 RID: 10726
		[Token(Token = "0x40029E6")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAnimatedButton _gameAnimatedButton;

		// Token: 0x040029E7 RID: 10727
		[Token(Token = "0x40029E7")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x040029E8 RID: 10728
		[Token(Token = "0x40029E8")]
		[FieldOffset(Offset = "0x18")]
		private PaymentBonusViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_GameAnimatedButton ---
		void Gameplay_Bank_View_PaymentBonusView__get_GameAnimatedButton(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *piVar1;
		  
		  if (DAT_ram_00a597a8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAnimationView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_View_PaymentBonusView_GameAnimationViewOnAnimationReadyEvent__)
		    ;
		    DAT_ram_00a597a8 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_GameAnimationView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Bank_View_PaymentBonusView_GameAnimationViewOnAnimationReadyEvent__,0);
		  AssetContent_GameAnimationView__add_ReadyEvent(param1_01,param1_00,0);
		  piVar1 = *(int **)(param1 + 0x18);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

}
