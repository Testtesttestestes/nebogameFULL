using System;
using Gameplay.Boss.Controller;
using Il2CppDummyDll;
using UI.Tabs;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Boss.View
{
	// Token: 0x02000B4B RID: 2891
	[Token(Token = "0x2000B4B")]
	public class BossWindow : ClosableBaseWindow<BossWindowArgs>
	{
		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x060045FE RID: 17918 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DC6")]
		public override string WindowId
		{
			[Token(Token = "0x60045FE")]
			[Address(RVA = "0x9498", Offset = "0x9498", VA = "0x9498", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x060045FF RID: 17919 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DC7")]
		public TabBar TabBar
		{
			[Token(Token = "0x60045FF")]
			[Address(RVA = "0x9499", Offset = "0x9499", VA = "0x9499")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x06004600 RID: 17920 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DC8")]
		public BossWindowStateController BossWindowStateController
		{
			[Token(Token = "0x6004600")]
			[Address(RVA = "0x949A", Offset = "0x949A", VA = "0x949A")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004601")]
		[Address(RVA = "0x949B", Offset = "0x949B", VA = "0x949B", Slot = "22")]
		protected override void OnShow(BossWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Boss_View_BossWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a579a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_ClosableBaseWindow_BossWindowArgs__OnClose__);
		    DAT_ram_00a579a3 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,Method_UI_Windows_ClosableBaseWindow_BossWindowArgs__OnClose__);
		  piVar1 = *(int **)(param1 + 0x48);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x48) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06004602 RID: 17922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004602")]
		[Address(RVA = "0x949C", Offset = "0x949C", VA = "0x949C", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Boss_View_BossWindow__OnClose(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a579a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_ClosableBaseWindow_BossWindowArgs___ctor__);
		    DAT_ram_00a579a4 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_BossWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06004603 RID: 17923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004603")]
		[Address(RVA = "0x949D", Offset = "0x949D", VA = "0x949D")]
		public BossWindow()
		{
		}

		// Token: 0x04002639 RID: 9785
		[Token(Token = "0x4002639")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Boss/BossWindow";

		// Token: 0x0400263A RID: 9786
		[Token(Token = "0x400263A")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x0400263B RID: 9787
		[Token(Token = "0x400263B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BossWindowStateController bossWindowStateController;

		// Token: 0x0400263C RID: 9788
		[Token(Token = "0x400263C")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private MonoBehaviour[] _views;

		// Token: 0x0400263D RID: 9789
		[Token(Token = "0x400263D")]
		[FieldOffset(Offset = "0x48")]
		private BossWindowMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_BossWindowStateController ---
		void Gameplay_Boss_View_BossWindow__get_BossWindowStateController
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  int param1_00;
		  undefined4 uVar8;
		  undefined4 uVar9;
		  undefined4 uVar10;
		  int *piVar11;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a579a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_BaseWindow_BossWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossWindowMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_ClosableBaseWindow_BossWindowArgs__OnShow__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_View_IBossWindowView_TypeInfo);
		    DAT_ram_00a579a2 = '\x01';
		  }
		  func_ii_7769(param1,param2,Method_UI_Windows_ClosableBaseWindow_BossWindowArgs__OnShow__);
		  iVar7 = *(int *)(param1 + 0x44);
		  if (0 < *(int *)(iVar7 + 0xc)) {
		    do {
		      param1_00 = *(int *)(iVar7 + iVar5 * 4 + 0x10);
		      iVar2 = func_ii_8093(param1,Method_UI_Windows_BaseWindow_BossWindowArgs__get_WindowArgs__);
		      uVar8 = *(undefined4 *)(*(int *)(iVar2 + 0x18) + 8);
		      iVar2 = func_ii_8093(param1,Method_UI_Windows_BaseWindow_BossWindowArgs__get_WindowArgs__);
		      uVar9 = *(undefined4 *)(*(int *)(iVar2 + 0x18) + 0x10);
		      iVar3 = func_ii_8093(param1,Method_UI_Windows_BaseWindow_BossWindowArgs__get_WindowArgs__);
		      iVar2 = Gameplay_Boss_View_IBossWindowView_TypeInfo;
		      uVar10 = *(undefined4 *)(*(int *)(iVar3 + 0x18) + 0xc);
		      piVar6 = (int *)0x0;
		      if ((param1_00 != 0) &&
		         (piVar6 = (int *)func_ii_1082(param1_00,Gameplay_Boss_View_IBossWindowView_TypeInfo),
		         piVar6 == (int *)0x0)) {
		        System_Activator__CreateInstance(param1_00,iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = *piVar6;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar11 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		          if (iVar2 == *piVar11) {
		            puVar4 = (uint *)(iVar3 + piVar11[1] * 8 + 0xc0);
		            goto code_r0x80e0d1ce;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar6,iVar2,0);
		code_r0x80e0d1ce:
		      (**(code **)((ulonglong)*puVar4 * 4))(piVar6,uVar8,uVar9,uVar10,puVar4[1]);
		      iVar5 = iVar5 + 1;
		    } while (iVar5 < *(int *)(iVar7 + 0xc));
		  }
		  iVar5 = func_ii_8093(param1,Method_UI_Windows_BaseWindow_BossWindowArgs__get_WindowArgs__);
		  uVar8 = *(undefined4 *)(*(int *)(iVar5 + 0x18) + 8);
		  iVar5 = func_ii_8093(param1,Method_UI_Windows_BaseWindow_BossWindowArgs__get_WindowArgs__);
		  uVar9 = *(undefined4 *)(*(int *)(iVar5 + 0x18) + 0x10);
		  iVar5 = func_ii_8093(param1,Method_UI_Windows_BaseWindow_BossWindowArgs__get_WindowArgs__);
		  uVar10 = *(undefined4 *)(*(int *)(iVar5 + 0x18) + 0xc);
		  piVar6 = (int *)unnamed_function_1417(Gameplay_Boss_Controller_BossWindowMediator_TypeInfo);
		  Gameplay_Boss_Controller_BossTeamsViewMediator___c___CaptainTeamsReceivedEvent_b__8_1
		            (piVar6,uVar8,uVar9,uVar10,0);
		  *(int **)(param1 + 0x48) = piVar6;
		  (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x160) * 4))
		            (piVar6,param1,*(undefined4 *)(*piVar6 + 0x164));
		  return;
		}
		*/

}
