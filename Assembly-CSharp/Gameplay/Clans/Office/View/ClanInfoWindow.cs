using System;
using Core.Money;
using Gameplay.Clans.ClanWars.Controller;
using Gameplay.Clans.Controller;
using Gameplay.Clans.Office.Controller;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.ClanMembersTab;
using Gameplay.Clans.Office.View.ClanOverviewTab;
using Gameplay.Clans.Office.View.ClanResumesTab;
using Gameplay.Clans.Office.View.ClanTreasuryTab;
using Gameplay.Clans.Office.View.ClanWarsTab;
using Gameplay.Clans.Office.View.ClassTab;
using Gameplay.Clans.Office.View.SquadTab;
using Il2CppDummyDll;
using UI.Tabs;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Clans.Office.View
{
	// Token: 0x020009F3 RID: 2547
	[Token(Token = "0x20009F3")]
	public class ClanInfoWindow : ClosableBaseWindow<ClanInfoWindow.ClanInfoWindowArgs>
	{
		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06003CC4 RID: 15556 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BF6")]
		public override string WindowId
		{
			[Token(Token = "0x6003CC4")]
			[Address(RVA = "0x8B87", Offset = "0x8B87", VA = "0x8B87", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06003CC5 RID: 15557 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BF7")]
		public TabBar TabBar
		{
			[Token(Token = "0x6003CC5")]
			[Address(RVA = "0x8B88", Offset = "0x8B88", VA = "0x8B88")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06003CC6 RID: 15558 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BF8")]
		public ClanOverview ClanOverviewTab
		{
			[Token(Token = "0x6003CC6")]
			[Address(RVA = "0x8B89", Offset = "0x8B89", VA = "0x8B89")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06003CC7 RID: 15559 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BF9")]
		public ClanMembersView ClanMembersTab
		{
			[Token(Token = "0x6003CC7")]
			[Address(RVA = "0x8B8A", Offset = "0x8B8A", VA = "0x8B8A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06003CC8 RID: 15560 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BFA")]
		public ClanWarsView ClanWarsTab
		{
			[Token(Token = "0x6003CC8")]
			[Address(RVA = "0x8B8B", Offset = "0x8B8B", VA = "0x8B8B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06003CC9 RID: 15561 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BFB")]
		public ClanResumesView ClanResumesTab
		{
			[Token(Token = "0x6003CC9")]
			[Address(RVA = "0x8B8C", Offset = "0x8B8C", VA = "0x8B8C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06003CCA RID: 15562 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BFC")]
		public ClanTreasuryView ClanTreasuryTab
		{
			[Token(Token = "0x6003CCA")]
			[Address(RVA = "0x8B8D", Offset = "0x8B8D", VA = "0x8B8D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06003CCB RID: 15563 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BFD")]
		public SquadView SquadTab
		{
			[Token(Token = "0x6003CCB")]
			[Address(RVA = "0x8B8E", Offset = "0x8B8E", VA = "0x8B8E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06003CCC RID: 15564 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BFE")]
		public ClassView ClassTab
		{
			[Token(Token = "0x6003CCC")]
			[Address(RVA = "0x8B8F", Offset = "0x8B8F", VA = "0x8B8F")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003CCD RID: 15565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CCD")]
		[Address(RVA = "0x8B90", Offset = "0x8B90", VA = "0x8B90", Slot = "22")]
		protected override void OnShow(ClanInfoWindow.ClanInfoWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Clans_Office_View_ClanInfoWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57ef9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_ClanInfoWindow_ClanInfoWindowArgs__OnClose__);
		    DAT_ram_00a57ef9 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_ClanInfoWindow_ClanInfoWindowArgs__OnClose__);
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x60),0);
		  iVar1 = **(int **)(param1 + 0x5c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x5c),*(undefined4 *)(iVar1 + 0x134));
		  iVar1 = **(int **)(param1 + 0x60);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x60),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 100);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 100),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined4 *)(param1 + 100) = 0;
		  *(undefined8 *)(param1 + 0x5c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06003CCE RID: 15566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CCE")]
		[Address(RVA = "0x8B91", Offset = "0x8B91", VA = "0x8B91", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Clans_Office_View_ClanInfoWindow__OnClose(int param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 param4;
		  undefined8 param4_00;
		  uint uVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a57efa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_ClanInfoWindow_ClanInfoWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Controller_ClanInfoController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Events_ClanInfoEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Model_ClanInfoModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Controller_ClanInfoViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57efa = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar7 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x80e7d820;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar7);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e7d820:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar5,puVar1[1]);
		  uVar2 = func_ii_7112(uVar2,0);
		  iVar6 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ClanInfoWindow_ClanInfoWindowArgs__get_WindowArgs__
		                      );
		  iVar8 = **(int **)(iVar6 + 0x20);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x100) * 4))
		                    (*(int **)(iVar6 + 0x20),*(undefined4 *)(iVar8 + 0x104));
		  iVar6 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ClanInfoWindow_ClanInfoWindowArgs__get_WindowArgs__
		                      );
		  param4_00 = *(undefined8 *)(iVar6 + 0x18);
		  uVar4 = unnamed_function_1417(Gameplay_Clans_Office_Model_ClanInfoModel_TypeInfo);
		  Gameplay_Clans_Office_Model_ClanInfoModel__get_Dict(uVar4,uVar2,uVar3,param4_00,0,0);
		  *(undefined4 *)(param1 + 100) = uVar4;
		  iVar6 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ClanInfoWindow_ClanInfoWindowArgs__get_WindowArgs__
		                      );
		  iVar8 = **(int **)(iVar6 + 0x20);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x110) * 4))
		                    (*(int **)(iVar6 + 0x20),*(undefined4 *)(iVar8 + 0x114));
		  iVar6 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ClanInfoWindow_ClanInfoWindowArgs__get_WindowArgs__
		                      );
		  iVar8 = **(int **)(iVar6 + 0x24);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x110) * 4))
		                    (*(int **)(iVar6 + 0x24),*(undefined4 *)(iVar8 + 0x114));
		  uVar4 = unnamed_function_1417(Gameplay_Clans_Office_Events_ClanInfoEvents_TypeInfo);
		  Core_Dict_Model_DictModel___ctor(uVar4,uVar2,uVar3,0);
		  *(undefined4 *)(param1 + 0x68) = uVar4;
		  uVar3 = *(undefined4 *)(param1 + 100);
		  iVar6 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ClanInfoWindow_ClanInfoWindowArgs__get_WindowArgs__
		                      );
		  param4 = *(undefined4 *)(iVar6 + 0x20);
		  uVar2 = unnamed_function_1417(Gameplay_Clans_Office_Controller_ClanInfoController_TypeInfo);
		  Gameplay_Clans_Office_Controller_ClanCreationViewMediator__Hide(uVar2,uVar3,uVar4,param4,0);
		  *(undefined4 *)(param1 + 0x60) = uVar2;
		  uVar3 = *(undefined4 *)(param1 + 100);
		  uVar4 = *(undefined4 *)(param1 + 0x68);
		  piVar5 = (int *)unnamed_function_1417
		                            (Gameplay_Clans_Office_Controller_ClanInfoViewMediator_TypeInfo);
		  Gameplay_Clans_Office_Controller_ClanInfoController___c__DisplayClass32_0___UserLeftClanEventHandler_b__0
		            (piVar5,uVar3,uVar4,uVar2,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x160) * 4))
		            (piVar5,param1,*(undefined4 *)(*piVar5 + 0x164));
		  *(int **)(param1 + 0x5c) = piVar5;
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x60),0);
		  return;
		}
		*/

		}

		// Token: 0x06003CCF RID: 15567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CCF")]
		[Address(RVA = "0x8B92", Offset = "0x8B92", VA = "0x8B92")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_Clans_Office_View_ClanInfoWindow__SetupMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x60),0);
		  iVar1 = **(int **)(param1 + 0x5c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x5c),*(undefined4 *)(iVar1 + 0x134));
		  iVar1 = **(int **)(param1 + 0x60);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x60),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 100);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 100),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined4 *)(param1 + 100) = 0;
		  *(undefined8 *)(param1 + 0x5c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06003CD0 RID: 15568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CD0")]
		[Address(RVA = "0x8B93", Offset = "0x8B93", VA = "0x8B93")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_Clans_Office_View_ClanInfoWindow__DestroyMVC(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57efb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_ClanInfoWindow_ClanInfoWindowArgs___ctor__);
		    DAT_ram_00a57efb = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_ClanInfoWindow_ClanInfoWindowArgs___ctor__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06003CD1 RID: 15569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CD1")]
		[Address(RVA = "0x8B94", Offset = "0x8B94", VA = "0x8B94")]
		public ClanInfoWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_View_ClanInfoWindow___ctor
		               (int param1,undefined8 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  UI_Windows_BaseWindowArgs__Dispose(param1,0);
		  *(undefined4 *)(param1 + 0x24) = param4;
		  *(undefined4 *)(param1 + 0x20) = param3;
		  *(undefined8 *)(param1 + 0x18) = param2;
		  return;
		}
		*/

		}

		// Token: 0x04002192 RID: 8594
		[Token(Token = "0x4002192")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Clans/Office/ClanInfoWindow";

		// Token: 0x04002193 RID: 8595
		[Token(Token = "0x4002193")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x04002194 RID: 8596
		[Token(Token = "0x4002194")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ClanOverview _clanOverviewTab;

		// Token: 0x04002195 RID: 8597
		[Token(Token = "0x4002195")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private ClanMembersView _clanMembersTab;

		// Token: 0x04002196 RID: 8598
		[Token(Token = "0x4002196")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ClanWarsView _clanWarsTab;

		// Token: 0x04002197 RID: 8599
		[Token(Token = "0x4002197")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ClanResumesView _clanResumesTab;

		// Token: 0x04002198 RID: 8600
		[Token(Token = "0x4002198")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ClanTreasuryView _clanTreasuryTab;

		// Token: 0x04002199 RID: 8601
		[Token(Token = "0x4002199")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private SquadView _squadTab;

		// Token: 0x0400219A RID: 8602
		[Token(Token = "0x400219A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ClassView _classTab;

		// Token: 0x0400219B RID: 8603
		[Token(Token = "0x400219B")]
		[FieldOffset(Offset = "0x5C")]
		private ClanInfoViewMediator _mediator;

		// Token: 0x0400219C RID: 8604
		[Token(Token = "0x400219C")]
		[FieldOffset(Offset = "0x60")]
		private ClanInfoController _controller;

		// Token: 0x0400219D RID: 8605
		[Token(Token = "0x400219D")]
		[FieldOffset(Offset = "0x64")]
		private ClanInfoModel _model;

		// Token: 0x0400219E RID: 8606
		[Token(Token = "0x400219E")]
		[FieldOffset(Offset = "0x68")]
		private ClanInfoEvents _events;

		// Token: 0x020009F4 RID: 2548
		[Token(Token = "0x20009F4")]
		public enum State
		{
			// Token: 0x040021A0 RID: 8608
			[Token(Token = "0x40021A0")]
			UNKNOWN_STATE,
			// Token: 0x040021A1 RID: 8609
			[Token(Token = "0x40021A1")]
			FOREIGN_CLAN,
			// Token: 0x040021A2 RID: 8610
			[Token(Token = "0x40021A2")]
			MY_CLAN,
			// Token: 0x040021A3 RID: 8611
			[Token(Token = "0x40021A3")]
			LEADER
		}

		// Token: 0x020009F5 RID: 2549
		[Token(Token = "0x20009F5")]
		public enum Tab
		{
			// Token: 0x040021A5 RID: 8613
			[Token(Token = "0x40021A5")]
			INFO,
			// Token: 0x040021A6 RID: 8614
			[Token(Token = "0x40021A6")]
			MEMBERS,
			// Token: 0x040021A7 RID: 8615
			[Token(Token = "0x40021A7")]
			WARS,
			// Token: 0x040021A8 RID: 8616
			[Token(Token = "0x40021A8")]
			RESUMES,
			// Token: 0x040021A9 RID: 8617
			[Token(Token = "0x40021A9")]
			TREASURY,
			// Token: 0x040021AA RID: 8618
			[Token(Token = "0x40021AA")]
			SQUAD,
			// Token: 0x040021AB RID: 8619
			[Token(Token = "0x40021AB")]
			CLASS
		}

		// Token: 0x020009F6 RID: 2550
		[Token(Token = "0x20009F6")]
		public class ClanInfoWindowArgs : BaseWindowArgs
		{
			// Token: 0x06003CD2 RID: 15570 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003CD2")]
			[Address(RVA = "0x8B95", Offset = "0x8B95", VA = "0x8B95")]
			public ClanInfoWindowArgs(ulong clanId, ClansController clansController, ClanWarsController clanWarsController)
			{
			}

			// Token: 0x040021AC RID: 8620
			[Token(Token = "0x40021AC")]
			[FieldOffset(Offset = "0x18")]
			public readonly ulong ClanId;

			// Token: 0x040021AD RID: 8621
			[Token(Token = "0x40021AD")]
			[FieldOffset(Offset = "0x20")]
			public readonly ClansController ClansController;

			// Token: 0x040021AE RID: 8622
			[Token(Token = "0x40021AE")]
			[FieldOffset(Offset = "0x24")]
			public readonly ClanWarsController ClanWarsController;

			// Token: 0x040021AF RID: 8623
			[Token(Token = "0x40021AF")]
			[FieldOffset(Offset = "0x28")]
			public Money DeficientResources;

			// Token: 0x040021B0 RID: 8624
			[Token(Token = "0x40021B0")]
			[FieldOffset(Offset = "0x2C")]
			public ClanInfoWindow.Tab TabToOpen;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ClassTab ---
		void Gameplay_Clans_Office_View_ClanInfoWindow__get_ClassTab
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57ef8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_ClanInfoWindow_ClanInfoWindowArgs__OnShow__);
		    DAT_ram_00a57ef8 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_ClanInfoWindow_ClanInfoWindowArgs__OnShow__);
		  Gameplay_Clans_Office_View_ClanInfoWindow__OnClose(param1,param1);
		  return;
		}
		*/

}
