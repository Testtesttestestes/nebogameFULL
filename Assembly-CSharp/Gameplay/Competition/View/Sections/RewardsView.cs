using System;
using Core.MVC.Interfaces;
using Gameplay.Competition.Control.Sections;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Gameplay.VortexRating.View.GreatPrizesTab;
using Il2CppDummyDll;
using MVC;
using UnityEngine;

namespace Gameplay.Competition.View.Sections
{
	// Token: 0x020008E0 RID: 2272
	[Token(Token = "0x20008E0")]
	[AddComponentMenu("Competition/View/Sections/RewardsView")]
	public class RewardsView : BaseSectionView<RewardsController>
	{
		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06003575 RID: 13685 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A90")]
		public GreatPrizesView GreatPrizesTab
		{
			[Token(Token = "0x6003575")]
			[Address(RVA = "0x8583", Offset = "0x8583", VA = "0x8583")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003576 RID: 13686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003576")]
		[Address(RVA = "0x8584", Offset = "0x8584", VA = "0x8584", Slot = "6")]
		protected override void CreateController(CompetitionModel model, CompetitionEvents events, out RewardsController controller)
		{
		/* --- GHIDRA: CreateController ---
		void Gameplay_Competition_View_Sections_RewardsView__CreateController
		               (undefined4 param1,int *param2,undefined4 *param3,undefined4 param4)
		
		{
		  undefined4 param3_00;
		  undefined4 param4_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63a87 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Competition_Control_Sections_RewardsViewMediator_TypeInfo);
		    DAT_ram_00a63a87 = '\x01';
		  }
		  param3_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x100) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0x104));
		  param4_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x110) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0x114));
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Competition_Control_Sections_RewardsViewMediator_TypeInfo);
		  Gameplay_Competition_Control_Sections_RewardsController__HandleRun
		            (param1_00,param1,param3_00,param4_00,param2,param2);
		  *param3 = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06003577 RID: 13687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003577")]
		[Address(RVA = "0x8585", Offset = "0x8585", VA = "0x8585", Slot = "7")]
		protected override void CreateMediator(RewardsController controller, out IViewMediator mediator)
		{
		}

		// Token: 0x06003578 RID: 13688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003578")]
		[Address(RVA = "0x8586", Offset = "0x8586", VA = "0x8586", Slot = "8")]
		protected override void RunController(RewardsController controller, out AbstractMVCEvents events)
		{
		/* --- GHIDRA: RunController ---
		void Gameplay_Competition_View_Sections_RewardsView__RunController
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63a88 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Competition_View_Sections_BaseSectionView_RewardsController___ctor__
		              );
		    DAT_ram_00a63a88 = '\x01';
		  }
		  Gameplay_AccountLinker_ProgressSaver_Controller_BaseProgressSaverEnterPointViewMediator_object___set_View
		            (param1,
		             Method_Gameplay_Competition_View_Sections_BaseSectionView_RewardsController___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06003579 RID: 13689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003579")]
		[Address(RVA = "0x8587", Offset = "0x8587", VA = "0x8587")]
		public RewardsView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Competition_View_Sections_RewardsView___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a63a89 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_Sections__get_Configs__);
		    DAT_ram_00a63a89 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(*(int *)(iVar2 + iVar1 * 4 + 0x10) + 8),0,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x04001D40 RID: 7488
		[Token(Token = "0x4001D40")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GreatPrizesView _greatPrizesTab;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_GreatPrizesTab ---
		void Gameplay_Competition_View_Sections_RewardsView__get_GreatPrizesTab
		               (undefined4 param1,int param2,undefined4 param3,undefined4 *param4,undefined4 param5)
		
		{
		  int param1_00;
		  int param3_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a63a86 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Control_Sections_RewardsController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Events_RewardsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Model_RewardsModel_TypeInfo);
		    DAT_ram_00a63a86 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(*(int *)(param2 + 0xc) + 8);
		  uVar2 = *(undefined4 *)(param2 + 0x2c);
		  param2_00 = *(undefined4 *)(param2 + 8);
		  param1_00 = unnamed_function_1417(Gameplay_Competition_Model_RewardsModel_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,param2_00,0);
		  *(undefined4 *)(param1_00 + 0xc) = uVar2;
		  *(undefined4 *)(param1_00 + 0x10) = uVar1;
		  param3_00 = unnamed_function_1417(Gameplay_Competition_Events_RewardsEvents_TypeInfo);
		  *(undefined4 *)(param3_00 + 0x14) = param3;
		  uVar1 = unnamed_function_1417(Gameplay_Competition_Control_Sections_RewardsController_TypeInfo);
		  if (DAT_ram_00a63b05 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_RewardsModel__RewardsEvents___ctor__);
		    DAT_ram_00a63b05 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (uVar1,param1_00,param3_00,
		             Method_MVC_AbstractController_RewardsModel__RewardsEvents___ctor__);
		  *param4 = uVar1;
		  return;
		}
		*/

}
