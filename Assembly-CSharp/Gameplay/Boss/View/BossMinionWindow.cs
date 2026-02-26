using System;
using Gameplay.Boss.Controller;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;
using UI;
using UI.Wiki;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Boss.View
{
	// Token: 0x02000B47 RID: 2887
	[Token(Token = "0x2000B47")]
	public class BossMinionWindow : ClosableBaseWindow<BossMinionWindowArgs>
	{
		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x060045F4 RID: 17908 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DC2")]
		public override string WindowId
		{
			[Token(Token = "0x60045F4")]
			[Address(RVA = "0x948E", Offset = "0x948E", VA = "0x948E", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x060045F5 RID: 17909 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DC3")]
		public WikiUriRouter Wiki
		{
			[Token(Token = "0x60045F5")]
			[Address(RVA = "0x948F", Offset = "0x948F", VA = "0x948F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x060045F6 RID: 17910 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DC4")]
		public BacktimeViewUGUI BacktimeViewUGUI
		{
			[Token(Token = "0x60045F6")]
			[Address(RVA = "0x9490", Offset = "0x9490", VA = "0x9490")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x060045F7 RID: 17911 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DC5")]
		public MonsterInfoView MonsterInfoView
		{
			[Token(Token = "0x60045F7")]
			[Address(RVA = "0x9491", Offset = "0x9491", VA = "0x9491")]
			get
			{
				return null;
			}
		}

		// Token: 0x060045F8 RID: 17912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045F8")]
		[Address(RVA = "0x9492", Offset = "0x9492", VA = "0x9492", Slot = "22")]
		protected override void OnShow(BossMinionWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Boss_View_BossMinionWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a5799d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_BossMinionWindowArgs__OnClose__);
		    DAT_ram_00a5799d = '\x01';
		  }
		  piVar1 = *(int **)(param1 + 0x48);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x48) = 0;
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,Method_UI_Windows_ClosableBaseWindow_BossMinionWindowArgs__OnClose__);
		  return;
		}
		*/

		}

		// Token: 0x060045F9 RID: 17913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045F9")]
		[Address(RVA = "0x9493", Offset = "0x9493", VA = "0x9493", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		uint Gameplay_Boss_View_BossMinionWindow__OnClose(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5799e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossModel__BossEvents__BossController__BossMinionWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_BossCombat_BossMinionCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ICombatManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5799e = '\x01';
		  }
		  piVar3 = *(int **)(*(int *)(*(int *)(param1 + 0x48) + 8) + 0x14);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x218);
		        goto code_r0x80e0cf41;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2b);
		code_r0x80e0cf41:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_ICombatManager_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e0cfc1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_Managers_ICombatManager_TypeInfo,0);
		code_r0x80e0cfc1:
		  uVar1 = 1;
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  if (piVar3 != (int *)0x0) {
		    if ((uint)*(byte *)(Gameplay_BossCombat_BossMinionCombat_TypeInfo + 0xb8) <=
		        (uint)*(byte *)(*piVar3 + 0xb8)) {
		      uVar1 = (uint)(*(int *)(*(int *)(*piVar3 + 100) +
		                              (uint)*(byte *)(Gameplay_BossCombat_BossMinionCombat_TypeInfo + 0xb8)
		                              * 4 + -4) != Gameplay_BossCombat_BossMinionCombat_TypeInfo);
		    }
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x060045FA RID: 17914 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
		[Token(Token = "0x60045FA")]
		[Address(RVA = "0x9494", Offset = "0x9494", VA = "0x9494", Slot = "17")]
		public override bool CheckForClose()
		{
		/* --- GHIDRA: CheckForClose ---
		void Gameplay_Boss_View_BossMinionWindow__CheckForClose(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5799f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_BossMinionWindowArgs___ctor__);
		    DAT_ram_00a5799f = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_BossMinionWindowArgs___ctor__);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045FB")]
		[Address(RVA = "0x9495", Offset = "0x9495", VA = "0x9495")]
		public BossMinionWindow()
		{
		}

		// Token: 0x0400262C RID: 9772
		[Token(Token = "0x400262C")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Boss/BossMinionWindow";

		// Token: 0x0400262D RID: 9773
		[Token(Token = "0x400262D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private MonsterInfoView _monsterInfoView;

		// Token: 0x0400262E RID: 9774
		[Token(Token = "0x400262E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeViewUGUI;

		// Token: 0x0400262F RID: 9775
		[Token(Token = "0x400262F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private WikiUriRouter _wiki;

		// Token: 0x04002630 RID: 9776
		[Token(Token = "0x4002630")]
		[FieldOffset(Offset = "0x48")]
		private BossMinionWindowMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_MonsterInfoView ---
		void Gameplay_Boss_View_BossMinionWindow__get_MonsterInfoView
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 param4;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5799c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossMinionWindowMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_BossMinionWindowArgs__OnShow__);
		    DAT_ram_00a5799c = '\x01';
		  }
		  func_ii_7769(param1,param2,Method_UI_Windows_ClosableBaseWindow_BossMinionWindowArgs__OnShow__);
		  iVar1 = *(int *)(param2 + 0x1c);
		  param4 = *(undefined4 *)(iVar1 + 0x10);
		  param3_00 = *(undefined4 *)(iVar1 + 0x14);
		  param2_00 = *(undefined4 *)(iVar1 + 0x18);
		  param1_00 = (int *)unnamed_function_1417
		                               (Gameplay_Boss_Controller_BossMinionWindowMediator_TypeInfo);
		  Gameplay_Boss_Controller_BossListWindowMediator___c___InstanceListChangedEvent_b__16_0
		            (param1_00,param2_00,param3_00,param4,0);
		  *(int **)(param1 + 0x48) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  return;
		}
		*/

}
