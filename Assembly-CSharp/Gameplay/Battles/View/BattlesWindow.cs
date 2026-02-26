using System;
using Gameplay.Battles.Controller;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Battles.View
{
	// Token: 0x02000C28 RID: 3112
	[Token(Token = "0x2000C28")]
	public class BattlesWindow : ClosableBaseWindow<BattlesWindow.BattlesWindowArgs>
	{
		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06004BE6 RID: 19430 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F4A")]
		public override string WindowId
		{
			[Token(Token = "0x6004BE6")]
			[Address(RVA = "0x9A2A", Offset = "0x9A2A", VA = "0x9A2A", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06004BE7 RID: 19431 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F4B")]
		public BattlesWndButton[] Buttons
		{
			[Token(Token = "0x6004BE7")]
			[Address(RVA = "0x9A2B", Offset = "0x9A2B", VA = "0x9A2B")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004BE8 RID: 19432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BE8")]
		[Address(RVA = "0x9A2C", Offset = "0x9A2C", VA = "0x9A2C")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Battles_View_BattlesWindow__OnDestroy(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 param4;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a6096f == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Battles_Controller_BattlesViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_BattlesWindow_BattlesWindowArgs__OnShow__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a6096f = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_BattlesWindow_BattlesWindowArgs__OnShow__);
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1f0);
		        goto code_r0x81d06d8a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x26);
		code_r0x81d06d8a:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param4 = *(undefined4 *)(iVar4 + 0x18);
		  param3_00 = *(undefined4 *)(iVar4 + 0x14);
		  param2_00 = *(undefined4 *)(iVar4 + 0x10);
		  piVar3 = (int *)unnamed_function_1417(Gameplay_Battles_Controller_BattlesViewMediator_TypeInfo);
		  if (DAT_ram_00a60989 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattlesModel__BattlesEvents__BattlesController__BattlesWindow___ctor__
		              );
		    DAT_ram_00a60989 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (piVar3,param2_00,param3_00,param4,
		             Method_MVC_AbstractViewMediator_BattlesModel__BattlesEvents__BattlesController__BattlesWindow___ctor__
		            );
		  *(int **)(param1 + 0x40) = piVar3;
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		            (piVar3,param1,*(undefined4 *)(*piVar3 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x06004BE9 RID: 19433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BE9")]
		[Address(RVA = "0x9A2D", Offset = "0x9A2D", VA = "0x9A2D", Slot = "22")]
		protected override void OnShow(BattlesWindow.BattlesWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Battles_View_BattlesWindow__OnShow(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60970 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_BattlesWindow_BattlesWindowArgs___ctor__);
		    DAT_ram_00a60970 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_BattlesWindow_BattlesWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06004BEA RID: 19434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BEA")]
		[Address(RVA = "0x9A2E", Offset = "0x9A2E", VA = "0x9A2E")]
		public BattlesWindow()
		{
		}

		// Token: 0x04002957 RID: 10583
		[Token(Token = "0x4002957")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Battles/BattlesWindow";

		// Token: 0x04002958 RID: 10584
		[Token(Token = "0x4002958")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private BattlesWndButton[] _buttons;

		// Token: 0x04002959 RID: 10585
		[Token(Token = "0x4002959")]
		[FieldOffset(Offset = "0x40")]
		private BattlesViewMediator _mediator;

		// Token: 0x0400295A RID: 10586
		[Token(Token = "0x400295A")]
		[FieldOffset(Offset = "0x44")]
		private bool _mvcSetUp;

		// Token: 0x02000C29 RID: 3113
		[Token(Token = "0x2000C29")]
		public class BattlesWindowArgs : BaseWindowArgs
		{
			// Token: 0x06004BEB RID: 19435 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BEB")]
			[Address(RVA = "0x9A2F", Offset = "0x9A2F", VA = "0x9A2F")]
			public BattlesWindowArgs()
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Buttons ---
		void Gameplay_Battles_View_BattlesWindow__get_Buttons(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  piVar1 = *(int **)(param1 + 0x40);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x160) * 4))
		              (piVar1,0,*(undefined4 *)(*piVar1 + 0x164));
		    iVar2 = **(int **)(param1 + 0x40);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))
		              (*(int **)(param1 + 0x40),*(undefined4 *)(iVar2 + 0x134));
		    *(undefined4 *)(param1 + 0x40) = 0;
		  }
		  return;
		}
		*/

}
