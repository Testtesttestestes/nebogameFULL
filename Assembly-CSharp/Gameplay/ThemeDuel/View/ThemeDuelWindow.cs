using System;
using Gameplay.ThemeDuel.Controller;
using Gameplay.ThemeDuel.Events;
using Gameplay.ThemeDuel.Model;
using Gameplay.ThemeDuel.View.RatingTab;
using Gameplay.ThemeDuel.View.RulesTab;
using Gameplay.ThemeDuel.View.ShopTab;
using Il2CppDummyDll;
using TMPro;
using UI.Tabs;
using UI.Windows;
using UnityEngine;

namespace Gameplay.ThemeDuel.View
{
	// Token: 0x020004DB RID: 1243
	[Token(Token = "0x20004DB")]
	public class ThemeDuelWindow : ClosableBaseWindow<ThemeDuelWindow.ThemeDuelWindowArgs>
	{
		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700054B")]
		public override string WindowId
		{
			[Token(Token = "0x6001DA3")]
			[Address(RVA = "0x6F21", Offset = "0x6F21", VA = "0x6F21", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700054C")]
		public TabBar TabBarView
		{
			[Token(Token = "0x6001DA4")]
			[Address(RVA = "0x6F22", Offset = "0x6F22", VA = "0x6F22")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700054D")]
		public RatingView RatingTab
		{
			[Token(Token = "0x6001DA5")]
			[Address(RVA = "0x6F23", Offset = "0x6F23", VA = "0x6F23")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700054E")]
		public ShopView ShopTab
		{
			[Token(Token = "0x6001DA6")]
			[Address(RVA = "0x6F24", Offset = "0x6F24", VA = "0x6F24")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700054F")]
		public RulesView RulesTab
		{
			[Token(Token = "0x6001DA7")]
			[Address(RVA = "0x6F25", Offset = "0x6F25", VA = "0x6F25")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000550")]
		public TextMeshProUGUI EventTitle
		{
			[Token(Token = "0x6001DA8")]
			[Address(RVA = "0x6F26", Offset = "0x6F26", VA = "0x6F26")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA9")]
		[Address(RVA = "0x6F27", Offset = "0x6F27", VA = "0x6F27", Slot = "22")]
		protected override void OnShow(ThemeDuelWindow.ThemeDuelWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_ThemeDuel_View_ThemeDuelWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a585be == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_ThemeDuelWindow_ThemeDuelWindowArgs__OnClose__)
		    ;
		    DAT_ram_00a585be = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_ThemeDuelWindow_ThemeDuelWindowArgs__OnClose__);
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x58),0);
		  iVar1 = **(int **)(param1 + 0x5c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x5c),*(undefined4 *)(iVar1 + 0x134));
		  iVar1 = **(int **)(param1 + 0x58);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x58),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x50);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x50),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined8 *)(param1 + 0x58) = 0;
		  *(undefined4 *)(param1 + 0x50) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DAA")]
		[Address(RVA = "0x6F28", Offset = "0x6F28", VA = "0x6F28", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_ThemeDuel_View_ThemeDuelWindow__OnClose(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int param1_00;
		  int param1_01;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a585bf == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Events_RatingEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_RatingService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuel_Controller_ThemeDuelController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuel_Events_ThemeDuelEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuel_Model_ThemeDuelModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuel_Controller_ThemeDuelRatingController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuel_Controller_ThemeDuelShopController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator_TypeInfo);
		    DAT_ram_00a585bf = '\x01';
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
		        goto code_r0x80f0d74e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f0d74e:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar7 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  uVar4 = unnamed_function_1417(Gameplay_ThemeDuel_Model_ThemeDuelModel_TypeInfo);
		  Gameplay_ThemeDuel_Model_ThemeDuelModel__get_StateModel(uVar4,uVar3,uVar7,uVar3);
		  *(undefined4 *)(param1 + 0x50) = uVar4;
		  uVar3 = unnamed_function_1417(Gameplay_ThemeDuel_Events_ThemeDuelEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x54) = uVar3;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar3 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_RatingService___);
		  uVar7 = *(undefined4 *)(*(int *)(param1 + 0x50) + 0x10);
		  uVar4 = unnamed_function_1417(Gameplay_Rating_Events_RatingEvents_TypeInfo);
		  iVar6 = unnamed_function_1417(Gameplay_ThemeDuel_Controller_ThemeDuelRatingController_TypeInfo);
		  if (DAT_ram_00a585e1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ThemeDuelRatingModel__RatingEvents___ctor__);
		    DAT_ram_00a585e1 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (iVar6,uVar7,uVar4,
		             Method_MVC_AbstractController_ThemeDuelRatingModel__RatingEvents___ctor__);
		  *(undefined4 *)(iVar6 + 0x18) = uVar3;
		  uVar3 = *(undefined4 *)(param1 + 0x54);
		  uVar4 = *(undefined4 *)(param1 + 0x50);
		  param1_00 = unnamed_function_1417(Gameplay_ThemeDuel_Controller_ThemeDuelShopController_TypeInfo);
		  if (DAT_ram_00a585f7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ThemeDuelModel__ThemeDuelEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ThemeDuelService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a585f7 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1_00,uVar4,uVar3,
		             Method_MVC_AbstractController_ThemeDuelModel__ThemeDuelEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar3 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ThemeDuelService___);
		  *(undefined4 *)(param1_00 + 0x18) = uVar3;
		  uVar3 = *(undefined4 *)(param1 + 0x54);
		  uVar4 = *(undefined4 *)(param1 + 0x50);
		  param1_01 = unnamed_function_1417(Gameplay_ThemeDuel_Controller_ThemeDuelController_TypeInfo);
		  if (DAT_ram_00a585e0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ThemeDuelModel__ThemeDuelEvents___ctor__);
		    DAT_ram_00a585e0 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1_01,uVar4,uVar3,
		             Method_MVC_AbstractController_ThemeDuelModel__ThemeDuelEvents___ctor__);
		  *(int *)(param1_01 + 0x1c) = param1_00;
		  *(int *)(param1_01 + 0x18) = iVar6;
		  *(int *)(param1 + 0x58) = param1_01;
		  uVar3 = *(undefined4 *)(param1 + 0x50);
		  uVar4 = *(undefined4 *)(param1 + 0x54);
		  piVar5 = (int *)unnamed_function_1417
		                            (Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator_TypeInfo);
		  Gameplay_ThemeDuel_Controller_ThemeDuelShopViewMediator__GetStoreItemsInfoEvent
		            (piVar5,uVar3,uVar4,param1_01,param1_01);
		  (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x160) * 4))
		            (piVar5,param1,*(undefined4 *)(*piVar5 + 0x164));
		  *(int **)(param1 + 0x5c) = piVar5;
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x58),0);
		  return;
		}
		*/

		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DAB")]
		[Address(RVA = "0x6F29", Offset = "0x6F29", VA = "0x6F29")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_ThemeDuel_View_ThemeDuelWindow__SetupMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x58),0);
		  iVar1 = **(int **)(param1 + 0x5c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x5c),*(undefined4 *)(iVar1 + 0x134));
		  iVar1 = **(int **)(param1 + 0x58);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x58),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x50);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x50),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined8 *)(param1 + 0x58) = 0;
		  *(undefined4 *)(param1 + 0x50) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DAC")]
		[Address(RVA = "0x6F2A", Offset = "0x6F2A", VA = "0x6F2A")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_ThemeDuel_View_ThemeDuelWindow__DestroyMVC(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a585c0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_ThemeDuelWindow_ThemeDuelWindowArgs___ctor__);
		    DAT_ram_00a585c0 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_ThemeDuelWindow_ThemeDuelWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DAD")]
		[Address(RVA = "0x6F2B", Offset = "0x6F2B", VA = "0x6F2B")]
		public ThemeDuelWindow()
		{
		}

		// Token: 0x04001016 RID: 4118
		[Token(Token = "0x4001016")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/ThemeDuel/ThemeDuelWindow";

		// Token: 0x04001017 RID: 4119
		[Token(Token = "0x4001017")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TabBar _tabBarView;

		// Token: 0x04001018 RID: 4120
		[Token(Token = "0x4001018")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RulesView _rulesTab;

		// Token: 0x04001019 RID: 4121
		[Token(Token = "0x4001019")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private RatingView _ratingTab;

		// Token: 0x0400101A RID: 4122
		[Token(Token = "0x400101A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ShopView _shopTab;

		// Token: 0x0400101B RID: 4123
		[Token(Token = "0x400101B")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private TextMeshProUGUI _eventTitle;

		// Token: 0x0400101C RID: 4124
		[Token(Token = "0x400101C")]
		[FieldOffset(Offset = "0x50")]
		private ThemeDuelModel _model;

		// Token: 0x0400101D RID: 4125
		[Token(Token = "0x400101D")]
		[FieldOffset(Offset = "0x54")]
		private ThemeDuelEvents _events;

		// Token: 0x0400101E RID: 4126
		[Token(Token = "0x400101E")]
		[FieldOffset(Offset = "0x58")]
		private ThemeDuelController _controller;

		// Token: 0x0400101F RID: 4127
		[Token(Token = "0x400101F")]
		[FieldOffset(Offset = "0x5C")]
		private ThemeDuelViewMediator _mediator;

		// Token: 0x020004DC RID: 1244
		[Token(Token = "0x20004DC")]
		public class ThemeDuelWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001DAE RID: 7598 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001DAE")]
			[Address(RVA = "0x6F2C", Offset = "0x6F2C", VA = "0x6F2C")]
			public ThemeDuelWindowArgs(ThemeDuelTargets targetForShow)
			{
			}

			// Token: 0x06001DAF RID: 7599 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001DAF")]
			[Address(RVA = "0x6F2D", Offset = "0x6F2D", VA = "0x6F2D")]
			public ThemeDuelWindowArgs()
			{
			}

			// Token: 0x04001020 RID: 4128
			[Token(Token = "0x4001020")]
			[FieldOffset(Offset = "0x18")]
			public readonly ThemeDuelTargets TargetForShow;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_EventTitle ---
		void Gameplay_ThemeDuel_View_ThemeDuelWindow__get_EventTitle
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  int iVar2;
		  undefined4 param5;
		  undefined8 param4;
		  
		  if (DAT_ram_00a585bd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_ThemeDuelWindow_ThemeDuelWindowArgs__OnShow__);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ThemeDuelScope_OpenWindowEventArgs_TypeInfo);
		    DAT_ram_00a585bd = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_ThemeDuelWindow_ThemeDuelWindowArgs__OnShow__);
		  Gameplay_ThemeDuel_View_ThemeDuelWindow__OnClose(param1,param1);
		  iVar1 = System_Uri___ctor(0);
		  iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x98) + 0x10);
		  if (iVar1 != 0) {
		    param2_00 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *(int *)(*(int *)(param1 + 0x50) + 0x14);
		    func_ii_7103(*(undefined4 *)(iVar2 + 0x34),0);
		    param5 = *(undefined4 *)(param2 + 0x10);
		    param4 = *(undefined8 *)(*(int *)(iVar2 + 0x10) + 0x10);
		    param1_00 = unnamed_function_1417
		                          (Core_Events_Scopes_ThemeDuelScope_OpenWindowEventArgs_TypeInfo);
		    Core_Events_Scopes_ThemeDuelScope_BattleFinishedArgs__get_WinnerId
		              (param1_00,param2_00,param3_00,param4,param5,0);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}
