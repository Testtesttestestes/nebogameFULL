using System;
using Gameplay.Clans.Office.Controller;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.AboutClansTab;
using Gameplay.Clans.Office.View.ClanCreationTab;
using Gameplay.Clans.Office.View.VacanciesTab;
using Gameplay.World.Controller;
using Il2CppDummyDll;
using UI.Tabs;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Clans.Office.View
{
	// Token: 0x020009FB RID: 2555
	[Token(Token = "0x20009FB")]
	public class ClanOfficeWindow : ClosableBaseWindow<ClanOfficeWindow.ClanOfficeWindowArgs>
	{
		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06003CD9 RID: 15577 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BFF")]
		public override string WindowId
		{
			[Token(Token = "0x6003CD9")]
			[Address(RVA = "0x8B99", Offset = "0x8B99", VA = "0x8B99", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06003CDA RID: 15578 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C00")]
		public ClanCreationView ClanCreationTab
		{
			[Token(Token = "0x6003CDA")]
			[Address(RVA = "0x8B9A", Offset = "0x8B9A", VA = "0x8B9A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06003CDB RID: 15579 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C01")]
		public VacanciesView VacanciesTab
		{
			[Token(Token = "0x6003CDB")]
			[Address(RVA = "0x8B9B", Offset = "0x8B9B", VA = "0x8B9B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06003CDC RID: 15580 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C02")]
		public AboutClansView AboutClansTab
		{
			[Token(Token = "0x6003CDC")]
			[Address(RVA = "0x8B9C", Offset = "0x8B9C", VA = "0x8B9C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x06003CDD RID: 15581 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C03")]
		public TabBar TabBar
		{
			[Token(Token = "0x6003CDD")]
			[Address(RVA = "0x8B9D", Offset = "0x8B9D", VA = "0x8B9D")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003CDE RID: 15582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CDE")]
		[Address(RVA = "0x8B9E", Offset = "0x8B9E", VA = "0x8B9E", Slot = "22")]
		protected override void OnShow(ClanOfficeWindow.ClanOfficeWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Clans_Office_View_ClanOfficeWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57f00 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ClanOfficeWindow_ClanOfficeWindowArgs__OnClose__
		              );
		    DAT_ram_00a57f00 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_ClanOfficeWindow_ClanOfficeWindowArgs__OnClose__);
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x50),0);
		  iVar1 = **(int **)(param1 + 0x4c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x4c),*(undefined4 *)(iVar1 + 0x134));
		  iVar1 = **(int **)(param1 + 0x50);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x50),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x54);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x54),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined4 *)(param1 + 0x54) = 0;
		  *(undefined8 *)(param1 + 0x4c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06003CDF RID: 15583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CDF")]
		[Address(RVA = "0x8B9F", Offset = "0x8B9F", VA = "0x8B9F", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Clans_Office_View_ClanOfficeWindow__OnClose(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 param4;
		  
		  if (DAT_ram_00a57f01 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_ClanOfficeWindow_ClanOfficeWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Controller_ClanOfficeController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Events_ClanOfficeEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Model_ClanOfficeModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Controller_ClanOfficeViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57f01 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x80e7dda7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e7dda7:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  uVar4 = unnamed_function_1417(Gameplay_Clans_Office_Model_ClanOfficeModel_TypeInfo);
		  Gameplay_Clans_Office_Model_ClanOfficeData__Create(uVar4,uVar3,0);
		  *(undefined4 *)(param1 + 0x54) = uVar4;
		  uVar3 = unnamed_function_1417(Gameplay_Clans_Office_Events_ClanOfficeEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x58) = uVar3;
		  uVar7 = *(undefined4 *)(param1 + 0x54);
		  iVar6 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ClanOfficeWindow_ClanOfficeWindowArgs__get_WindowArgs__
		                      );
		  param4 = *(undefined4 *)(iVar6 + 0x18);
		  uVar4 = unnamed_function_1417(Gameplay_Clans_Office_Controller_ClanOfficeController_TypeInfo);
		  Gameplay_Clans_Office_Controller_ClanMembersViewMediator___ShowBuyPlaceConfirmationWindow_b__38_0
		            (uVar4,uVar7,uVar3,param4,0);
		  *(undefined4 *)(param1 + 0x50) = uVar4;
		  uVar3 = *(undefined4 *)(param1 + 0x54);
		  uVar7 = *(undefined4 *)(param1 + 0x58);
		  piVar5 = (int *)unnamed_function_1417
		                            (Gameplay_Clans_Office_Controller_ClanOfficeViewMediator_TypeInfo);
		  Gameplay_Clans_Office_Controller_ClanOfficeController__CreateClanResultHandler
		            (piVar5,uVar3,uVar7,uVar4,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x160) * 4))
		            (piVar5,param1,*(undefined4 *)(*piVar5 + 0x164));
		  *(int **)(param1 + 0x4c) = piVar5;
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x50),0);
		  return;
		}
		*/

		}

		// Token: 0x06003CE0 RID: 15584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CE0")]
		[Address(RVA = "0x8BA0", Offset = "0x8BA0", VA = "0x8BA0")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_Clans_Office_View_ClanOfficeWindow__SetupMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x50),0);
		  iVar1 = **(int **)(param1 + 0x4c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x4c),*(undefined4 *)(iVar1 + 0x134));
		  iVar1 = **(int **)(param1 + 0x50);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x50),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x54);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x54),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined4 *)(param1 + 0x54) = 0;
		  *(undefined8 *)(param1 + 0x4c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06003CE1 RID: 15585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CE1")]
		[Address(RVA = "0x8BA1", Offset = "0x8BA1", VA = "0x8BA1")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_Clans_Office_View_ClanOfficeWindow__DestroyMVC(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57f02 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_ClanOfficeWindow_ClanOfficeWindowArgs___ctor__)
		    ;
		    DAT_ram_00a57f02 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_ClanOfficeWindow_ClanOfficeWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06003CE2 RID: 15586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CE2")]
		[Address(RVA = "0x8BA2", Offset = "0x8BA2", VA = "0x8BA2")]
		public ClanOfficeWindow()
		{
		}

		// Token: 0x040021BB RID: 8635
		[Token(Token = "0x40021BB")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Clans/Office/ClanOfficeWindow";

		// Token: 0x040021BC RID: 8636
		[Token(Token = "0x40021BC")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x040021BD RID: 8637
		[Token(Token = "0x40021BD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ClanCreationView _clanCreationTab;

		// Token: 0x040021BE RID: 8638
		[Token(Token = "0x40021BE")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private VacanciesView _vacanciesTab;

		// Token: 0x040021BF RID: 8639
		[Token(Token = "0x40021BF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AboutClansView _aboutClansTab;

		// Token: 0x040021C0 RID: 8640
		[Token(Token = "0x40021C0")]
		[FieldOffset(Offset = "0x4C")]
		private ClanOfficeViewMediator _mediator;

		// Token: 0x040021C1 RID: 8641
		[Token(Token = "0x40021C1")]
		[FieldOffset(Offset = "0x50")]
		private ClanOfficeController _controller;

		// Token: 0x040021C2 RID: 8642
		[Token(Token = "0x40021C2")]
		[FieldOffset(Offset = "0x54")]
		private ClanOfficeModel _model;

		// Token: 0x040021C3 RID: 8643
		[Token(Token = "0x40021C3")]
		[FieldOffset(Offset = "0x58")]
		private ClanOfficeEvents _events;

		// Token: 0x020009FC RID: 2556
		[Token(Token = "0x20009FC")]
		public class ClanOfficeWindowArgs : BaseWindowArgs
		{
			// Token: 0x06003CE3 RID: 15587 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003CE3")]
			[Address(RVA = "0x8BA3", Offset = "0x8BA3", VA = "0x8BA3")]
			public ClanOfficeWindowArgs()
			{
			}

			// Token: 0x040021C4 RID: 8644
			[Token(Token = "0x40021C4")]
			[FieldOffset(Offset = "0x18")]
			public IUserIslesWorldMovement UserWorldMovement;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_TabBar ---
		void Gameplay_Clans_Office_View_ClanOfficeWindow__get_TabBar
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57eff == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_ClanOfficeWindow_ClanOfficeWindowArgs__OnShow__
		              );
		    DAT_ram_00a57eff = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_ClanOfficeWindow_ClanOfficeWindowArgs__OnShow__)
		  ;
		  Gameplay_Clans_Office_View_ClanOfficeWindow__OnClose(param1,param1);
		  return;
		}
		*/

}
