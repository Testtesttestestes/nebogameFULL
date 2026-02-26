using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.WorldAxis.ClanEquipment.Controller;
using Gameplay.WorldAxis.ClanEquipment.Events;
using Gameplay.WorldAxis.ClanEquipment.Model;
using Il2CppDummyDll;
using UI.Elements.Filters.GenericFilter;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.WorldAxis.ClanEquipment.View
{
	// Token: 0x02000341 RID: 833
	[Token(Token = "0x2000341")]
	public class ClanEquipmentWindow : ClosableBaseWindow<ClanEquipmentWindow.ClanEquipmentWindowArgs>
	{
		// Token: 0x17000300 RID: 768
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000300")]
		public override string WindowId
		{
			[Token(Token = "0x600132E")]
			[Address(RVA = "0x651F", Offset = "0x651F", VA = "0x651F", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000301")]
		public EquipmentInfoBox InfoBox
		{
			[Token(Token = "0x600132F")]
			[Address(RVA = "0x6520", Offset = "0x6520", VA = "0x6520")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000302")]
		public Button TakeOffAllButton
		{
			[Token(Token = "0x6001330")]
			[Address(RVA = "0x6521", Offset = "0x6521", VA = "0x6521")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000303")]
		public Button ExpellButton
		{
			[Token(Token = "0x6001331")]
			[Address(RVA = "0x6522", Offset = "0x6522", VA = "0x6522")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000304")]
		public DeselectableGenericFilterView Filter
		{
			[Token(Token = "0x6001332")]
			[Address(RVA = "0x6523", Offset = "0x6523", VA = "0x6523")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06001333 RID: 4915 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000305")]
		public Toggle OnlyEquippedToggle
		{
			[Token(Token = "0x6001333")]
			[Address(RVA = "0x6524", Offset = "0x6524", VA = "0x6524")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001334")]
		[Address(RVA = "0x6525", Offset = "0x6525", VA = "0x6525", Slot = "22")]
		protected override void OnShow(ClanEquipmentWindow.ClanEquipmentWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_WorldAxis_ClanEquipment_View_ClanEquipmentWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58c2b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ClanEquipmentWindow_ClanEquipmentWindowArgs__OnClose__
		              );
		    DAT_ram_00a58c2b = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_ClanEquipmentWindow_ClanEquipmentWindowArgs__OnClose__
		            );
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x5c),0);
		  iVar1 = **(int **)(param1 + 0x60);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x60),*(undefined4 *)(iVar1 + 0x134));
		  iVar1 = **(int **)(param1 + 0x5c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x5c),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x54);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x54),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined8 *)(param1 + 0x5c) = 0;
		  *(undefined4 *)(param1 + 0x54) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001335")]
		[Address(RVA = "0x6526", Offset = "0x6526", VA = "0x6526", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_WorldAxis_ClanEquipment_View_ClanEquipmentWindow__OnClose
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a58c2c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ClanMemberDollsOSAView_ClansMembersViewsHolder__get_IsInitialized__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ClanEquipment_View_ClanEquipmentWindow___c__DisplayClass25_0__Init_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_ClanEquipment_View_ClanEquipmentWindow___c__DisplayClass25_0_TypeInfo
		              );
		    DAT_ram_00a58c2c = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_WorldAxis_ClanEquipment_View_ClanEquipmentWindow___c__DisplayClass25_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int *)(param2_00 + 8) = param1;
		  iVar2 = **(int **)(param1 + 0x3c);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x3b8) * 4))
		            (*(int **)(param1 + 0x3c),*(undefined4 *)(iVar2 + 0x3bc));
		  piVar1 = *(int **)(param1 + 0x3c);
		  if ((char)piVar1[0x14] != '\0') {
		    (**(code **)((ulonglong)
		                 *(uint *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + *piVar1 + 0x10) * 4))
		              (piVar1,*(undefined4 *)(param2_00 + 0xc),
		               *(undefined4 *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + *piVar1 + 0x14));
		    return;
		  }
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param2_00,
		             Method_Gameplay_WorldAxis_ClanEquipment_View_ClanEquipmentWindow___c__DisplayClass25_0__Init_b__0__
		             ,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x298) * 4))
		            (piVar1,param1_00,*(undefined4 *)(*piVar1 + 0x29c));
		  return;
		}
		*/

		}

		// Token: 0x06001336 RID: 4918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001336")]
		[Address(RVA = "0x6527", Offset = "0x6527", VA = "0x6527")]
		public void Init(IList<ClanMemberDollsListElement.ClanMemberDollsListElementArgs> items)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_WorldAxis_ClanEquipment_View_ClanEquipmentWindow__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  undefined4 uVar3;
		  undefined4 param3;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58c2d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ClanEquipmentWindow_ClanEquipmentWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_ClanEquipment_Events_ClanEquipmentEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_TypeInfo);
		    DAT_ram_00a58c2d = '\x01';
		  }
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ClanEquipmentWindow_ClanEquipmentWindowArgs__get_WindowArgs__
		                      );
		  uVar3 = *(undefined4 *)(iVar1 + 0x18);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ClanEquipmentWindow_ClanEquipmentWindowArgs__get_WindowArgs__
		                      );
		  param3 = *(undefined4 *)(iVar1 + 0x1c);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ClanEquipmentWindow_ClanEquipmentWindowArgs__get_WindowArgs__
		                      );
		  local_8 = *(undefined8 *)(iVar1 + 0x28);
		  local_10 = *(undefined8 *)(iVar1 + 0x20);
		  uVar2 = unnamed_function_1417(Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel_TypeInfo);
		  local_18 = local_8;
		  local_20 = local_10;
		  Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel__set_DollOwners
		            (uVar2,uVar3,param3,&local_20,param1);
		  *(undefined4 *)(param1 + 0x54) = uVar2;
		  uVar2 = unnamed_function_1417
		                    (Gameplay_WorldAxis_ClanEquipment_Events_ClanEquipmentEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x58) = uVar2;
		  uVar3 = *(undefined4 *)(param1 + 0x54);
		  iVar1 = unnamed_function_1417
		                    (Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController_TypeInfo);
		  if (DAT_ram_00a58c43 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ClanEquipmentModel__ClanEquipmentEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ColossusService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a58c43 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (iVar1,uVar3,uVar2,
		             Method_MVC_AbstractController_ClanEquipmentModel__ClanEquipmentEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ColossusService___);
		  *(undefined4 *)(iVar1 + 0x18) = uVar2;
		  *(int *)(param1 + 0x5c) = iVar1;
		  uVar2 = *(undefined4 *)(param1 + 0x54);
		  uVar3 = *(undefined4 *)(param1 + 0x58);
		  param1_00 = (int *)unnamed_function_1417
		                               (
		                               Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentViewMediator_TypeInfo
		                               );
		  Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController___c__DisplayClass7_0___TakeOffArtifactsResultHandler_b__0
		            (param1_00,uVar2,uVar3,iVar1,param1);
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  *(int **)(param1 + 0x60) = param1_00;
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x5c),0);
		  return;
		}
		*/

		}

		// Token: 0x06001337 RID: 4919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001337")]
		[Address(RVA = "0x6528", Offset = "0x6528", VA = "0x6528")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_WorldAxis_ClanEquipment_View_ClanEquipmentWindow__SetupMVC
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x5c),0);
		  iVar1 = **(int **)(param1 + 0x60);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x60),*(undefined4 *)(iVar1 + 0x134));
		  iVar1 = **(int **)(param1 + 0x5c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x5c),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x54);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x54),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined8 *)(param1 + 0x5c) = 0;
		  *(undefined4 *)(param1 + 0x54) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001338")]
		[Address(RVA = "0x6529", Offset = "0x6529", VA = "0x6529")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_WorldAxis_ClanEquipment_View_ClanEquipmentWindow__DestroyMVC
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58c2e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ClanEquipmentWindow_ClanEquipmentWindowArgs___ctor__
		              );
		    DAT_ram_00a58c2e = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_ClanEquipmentWindow_ClanEquipmentWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001339")]
		[Address(RVA = "0x652A", Offset = "0x652A", VA = "0x652A")]
		public ClanEquipmentWindow()
		{
		}

		// Token: 0x04000A3D RID: 2621
		[Token(Token = "0x4000A3D")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/WorldAxis/ClanEquipmentWindow";

		// Token: 0x04000A3E RID: 2622
		[Token(Token = "0x4000A3E")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ClanMemberDollsOSAView _osaView;

		// Token: 0x04000A3F RID: 2623
		[Token(Token = "0x4000A3F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private EquipmentInfoBox _infoBox;

		// Token: 0x04000A40 RID: 2624
		[Token(Token = "0x4000A40")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Button _takeOffAllButton;

		// Token: 0x04000A41 RID: 2625
		[Token(Token = "0x4000A41")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _expellButton;

		// Token: 0x04000A42 RID: 2626
		[Token(Token = "0x4000A42")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private DeselectableGenericFilterView _filter;

		// Token: 0x04000A43 RID: 2627
		[Token(Token = "0x4000A43")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Toggle _onlyEquippedToggle;

		// Token: 0x04000A44 RID: 2628
		[Token(Token = "0x4000A44")]
		[FieldOffset(Offset = "0x54")]
		private ClanEquipmentModel _model;

		// Token: 0x04000A45 RID: 2629
		[Token(Token = "0x4000A45")]
		[FieldOffset(Offset = "0x58")]
		private ClanEquipmentEvents _events;

		// Token: 0x04000A46 RID: 2630
		[Token(Token = "0x4000A46")]
		[FieldOffset(Offset = "0x5C")]
		private ClanEquipmentController _controller;

		// Token: 0x04000A47 RID: 2631
		[Token(Token = "0x4000A47")]
		[FieldOffset(Offset = "0x60")]
		private ClanEquipmentViewMediator _mediator;

		// Token: 0x02000342 RID: 834
		[Token(Token = "0x2000342")]
		public class ClanEquipmentWindowArgs : BaseWindowArgs
		{
			// Token: 0x0600133A RID: 4922 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600133A")]
			[Address(RVA = "0x652B", Offset = "0x652B", VA = "0x652B")]
			public ClanEquipmentWindowArgs()
			{
			}

			// Token: 0x04000A48 RID: 2632
			[Token(Token = "0x4000A48")]
			[FieldOffset(Offset = "0x18")]
			public UserData User;

			// Token: 0x04000A49 RID: 2633
			[Token(Token = "0x4000A49")]
			[FieldOffset(Offset = "0x1C")]
			public UserData GolemUserData;

			// Token: 0x04000A4A RID: 2634
			[Token(Token = "0x4000A4A")]
			[FieldOffset(Offset = "0x20")]
			public ulong? SelectedUserId;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_OnlyEquippedToggle ---
		void Gameplay_WorldAxis_ClanEquipment_View_ClanEquipmentWindow__get_OnlyEquippedToggle
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58c2a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ClanEquipmentWindow_ClanEquipmentWindowArgs__OnShow__
		              );
		    DAT_ram_00a58c2a = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_ClanEquipmentWindow_ClanEquipmentWindowArgs__OnShow__
		              );
		  Gameplay_WorldAxis_ClanEquipment_View_ClanEquipmentWindow__Init(param1,param1);
		  return;
		}
		*/

}
