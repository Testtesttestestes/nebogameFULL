using System;
using Gameplay.WorldAxis.Office.Controller;
using Gameplay.WorldAxis.Office.Events;
using Gameplay.WorldAxis.Office.Model;
using Gameplay.WorldAxis.Office.View.FrontPageTab;
using Gameplay.WorldAxis.Office.View.History;
using Gameplay.WorldAxis.Office.View.Ratings;
using Gameplay.WorldAxis.Office.View.Rewards;
using Gameplay.WorldAxis.Office.View.Schedule;
using Il2CppDummyDll;
using UI.Tabs;
using UI.Windows;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View
{
	// Token: 0x020002EA RID: 746
	[Token(Token = "0x20002EA")]
	public class WorldAxisOfficeWindow : ClosableBaseWindow<WorldAxisOfficeWindow.WorldAxisOfficeWindowArgs>
	{
		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060011BB RID: 4539 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700029C")]
		public override string WindowId
		{
			[Token(Token = "0x60011BB")]
			[Address(RVA = "0x63B8", Offset = "0x63B8", VA = "0x63B8", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700029D")]
		public TabBar TabBar
		{
			[Token(Token = "0x60011BC")]
			[Address(RVA = "0x63B9", Offset = "0x63B9", VA = "0x63B9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700029E")]
		public FrontPageView FrontPageTab
		{
			[Token(Token = "0x60011BD")]
			[Address(RVA = "0x63BA", Offset = "0x63BA", VA = "0x63BA")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700029F")]
		public WorldAxisScheduleView ScheduleTab
		{
			[Token(Token = "0x60011BE")]
			[Address(RVA = "0x63BB", Offset = "0x63BB", VA = "0x63BB")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A0")]
		public HistoryView HistoryTab
		{
			[Token(Token = "0x60011BF")]
			[Address(RVA = "0x63BC", Offset = "0x63BC", VA = "0x63BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A1")]
		public ClanRatingsView ClanRatingsTab
		{
			[Token(Token = "0x60011C0")]
			[Address(RVA = "0x63BD", Offset = "0x63BD", VA = "0x63BD")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060011C1 RID: 4545 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A2")]
		public UserRatingsView UserRatingsTab
		{
			[Token(Token = "0x60011C1")]
			[Address(RVA = "0x63BE", Offset = "0x63BE", VA = "0x63BE")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A3")]
		public SeasonRewardsView RewardsTab
		{
			[Token(Token = "0x60011C2")]
			[Address(RVA = "0x63BF", Offset = "0x63BF", VA = "0x63BF")]
			get
			{
				return null;
			}
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011C3")]
		[Address(RVA = "0x63C0", Offset = "0x63C0", VA = "0x63C0", Slot = "22")]
		protected override void OnShow(WorldAxisOfficeWindow.WorldAxisOfficeWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_WorldAxis_Office_View_WorldAxisOfficeWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58b8f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_WorldAxisOfficeWindow_WorldAxisOfficeWindowArgs__OnClose__
		              );
		    DAT_ram_00a58b8f = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_WorldAxisOfficeWindow_WorldAxisOfficeWindowArgs__OnClose__
		            );
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x60),0);
		  iVar1 = **(int **)(param1 + 100);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 100),*(undefined4 *)(iVar1 + 0x134));
		  iVar1 = **(int **)(param1 + 0x60);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x60),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x58);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x58),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined8 *)(param1 + 0x60) = 0;
		  *(undefined4 *)(param1 + 0x58) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011C4")]
		[Address(RVA = "0x63C1", Offset = "0x63C1", VA = "0x63C1", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_WorldAxis_Office_View_WorldAxisOfficeWindow__OnClose(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  undefined4 uVar8;
		  undefined4 param4;
		  
		  if (DAT_ram_00a58b90 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Office_Events_WorldAxisOfficeEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator_TypeInfo);
		    DAT_ram_00a58b90 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 600);
		        goto code_r0x80f7ef0c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x80f7ef0c:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar5;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x80f7efb8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f7efb8:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  uVar8 = *(undefined4 *)(iVar6 + 0x14);
		  uVar4 = unnamed_function_1417(Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel_TypeInfo);
		  Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel__get_Dict(uVar4,uVar3,uVar8,0);
		  *(undefined4 *)(param1 + 0x58) = uVar4;
		  uVar3 = *(undefined4 *)(iVar6 + 0x18);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar5;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x230);
		        goto code_r0x80f7f096;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f7f096:
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar8 = *(undefined4 *)(iVar7 + 0x14);
		  uVar4 = unnamed_function_1417(Gameplay_WorldAxis_Office_Events_WorldAxisOfficeEvents_TypeInfo);
		  Core_Dict_Model_DictModel___ctor(uVar4,uVar3,uVar8,0);
		  *(undefined4 *)(param1 + 0x5c) = uVar4;
		  uVar8 = *(undefined4 *)(param1 + 0x58);
		  param4 = *(undefined4 *)(iVar6 + 0x1c);
		  uVar3 = unnamed_function_1417
		                    (Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController_TypeInfo);
		  Gameplay_WorldAxis_Office_Controller_UserRatingsViewMediator___UpdateList_b__12_1
		            (uVar3,uVar8,uVar4,param4,0);
		  *(undefined4 *)(param1 + 0x60) = uVar3;
		  uVar4 = *(undefined4 *)(param1 + 0x58);
		  uVar8 = *(undefined4 *)(param1 + 0x5c);
		  piVar5 = (int *)unnamed_function_1417
		                            (
		                            Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeViewMediator_TypeInfo
		                            );
		  Gameplay_WorldAxis_Office_Controller_WorldAxisOfficeController___c___RepopulateSchedule_b__8_0
		            (piVar5,uVar4,uVar8,uVar3,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x160) * 4))
		            (piVar5,param1,*(undefined4 *)(*piVar5 + 0x164));
		  *(int **)(param1 + 100) = piVar5;
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x60),0);
		  return;
		}
		*/

		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011C5")]
		[Address(RVA = "0x63C2", Offset = "0x63C2", VA = "0x63C2")]
		private void SetupMVC()
		{
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011C6")]
		[Address(RVA = "0x63C3", Offset = "0x63C3", VA = "0x63C3")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_WorldAxis_Office_View_WorldAxisOfficeWindow__DestroyMVC
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58b91 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_WorldAxisOfficeWindow_WorldAxisOfficeWindowArgs___ctor__
		              );
		    DAT_ram_00a58b91 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_WorldAxisOfficeWindow_WorldAxisOfficeWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011C7")]
		[Address(RVA = "0x63C4", Offset = "0x63C4", VA = "0x63C4")]
		public WorldAxisOfficeWindow()
		{
		}

		// Token: 0x04000919 RID: 2329
		[Token(Token = "0x4000919")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/WorldAxis/WorldAxisWindow";

		// Token: 0x0400091A RID: 2330
		[Token(Token = "0x400091A")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x0400091B RID: 2331
		[Token(Token = "0x400091B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private FrontPageView _frontPageTab;

		// Token: 0x0400091C RID: 2332
		[Token(Token = "0x400091C")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private WorldAxisScheduleView _scheduleTab;

		// Token: 0x0400091D RID: 2333
		[Token(Token = "0x400091D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private HistoryView _historyTab;

		// Token: 0x0400091E RID: 2334
		[Token(Token = "0x400091E")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ClanRatingsView _clanRatingsTab;

		// Token: 0x0400091F RID: 2335
		[Token(Token = "0x400091F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UserRatingsView _userRatingsTab;

		// Token: 0x04000920 RID: 2336
		[Token(Token = "0x4000920")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private SeasonRewardsView _rewardsTab;

		// Token: 0x04000921 RID: 2337
		[Token(Token = "0x4000921")]
		[FieldOffset(Offset = "0x58")]
		private WorldAxisOfficeModel _model;

		// Token: 0x04000922 RID: 2338
		[Token(Token = "0x4000922")]
		[FieldOffset(Offset = "0x5C")]
		private WorldAxisOfficeEvents _events;

		// Token: 0x04000923 RID: 2339
		[Token(Token = "0x4000923")]
		[FieldOffset(Offset = "0x60")]
		private WorldAxisOfficeController _controller;

		// Token: 0x04000924 RID: 2340
		[Token(Token = "0x4000924")]
		[FieldOffset(Offset = "0x64")]
		private WorldAxisOfficeViewMediator _mediator;

		// Token: 0x020002EB RID: 747
		[Token(Token = "0x20002EB")]
		public enum Tab
		{
			// Token: 0x04000926 RID: 2342
			[Token(Token = "0x4000926")]
			FRONT_PAGE,
			// Token: 0x04000927 RID: 2343
			[Token(Token = "0x4000927")]
			SCHEDULE,
			// Token: 0x04000928 RID: 2344
			[Token(Token = "0x4000928")]
			HISTORY,
			// Token: 0x04000929 RID: 2345
			[Token(Token = "0x4000929")]
			CLAN_RATINGS,
			// Token: 0x0400092A RID: 2346
			[Token(Token = "0x400092A")]
			USER_RATINGS,
			// Token: 0x0400092B RID: 2347
			[Token(Token = "0x400092B")]
			REWARDS
		}

		// Token: 0x020002EC RID: 748
		[Token(Token = "0x20002EC")]
		public class WorldAxisOfficeWindowArgs : BaseWindowArgs
		{
			// Token: 0x060011C8 RID: 4552 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60011C8")]
			[Address(RVA = "0x63C5", Offset = "0x63C5", VA = "0x63C5")]
			public WorldAxisOfficeWindowArgs()
			{
			}

			// Token: 0x0400092C RID: 2348
			[Token(Token = "0x400092C")]
			[FieldOffset(Offset = "0x18")]
			public WorldAxisOfficeWindow.Tab TabToOpen;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RewardsTab ---
		void Gameplay_WorldAxis_Office_View_WorldAxisOfficeWindow__get_RewardsTab
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58b8e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_WorldAxisOfficeWindow_WorldAxisOfficeWindowArgs__OnShow__
		              );
		    DAT_ram_00a58b8e = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_WorldAxisOfficeWindow_WorldAxisOfficeWindowArgs__OnShow__
		              );
		  Gameplay_WorldAxis_Office_View_WorldAxisOfficeWindow__OnClose(param1,param1);
		  return;
		}
		*/

}
