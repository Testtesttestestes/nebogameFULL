using System;
using Gameplay.VortexRating.Events;
using Gameplay.VortexRating.Model;
using Gameplay.VortexRating.View.VortexTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.VortexRating.Controller
{
	// Token: 0x020003A1 RID: 929
	[Token(Token = "0x20003A1")]
	public class VortexViewMediator : AbstractViewMediator<VortexRatingModel, VortexRatingEvents, VortexRatingController, VortexView>, IHideableMediator
	{
		// Token: 0x060015AA RID: 5546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015AA")]
		[Address(RVA = "0x676C", Offset = "0x676C", VA = "0x676C")]
		public VortexViewMediator(VortexRatingModel model, VortexRatingEvents events, VortexRatingController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_VortexRating_Controller_VortexViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a581fd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VortexView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_VortexViewMediator_InVortexButtonClickedEventHandler__
		              );
		    DAT_ram_00a581fd = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x10) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_VortexRating_Controller_VortexViewMediator_InVortexButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x10) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_VortexRating_Controller_VortexViewMediator_InVortexButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    Gameplay_VortexRating_Controller_VortexViewMediator__InVortexButtonClickedEventHandler
		              (param1,param1);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000392 RID: 914
		// (set) Token: 0x060015AB RID: 5547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000392")]
		public override VortexView View
		{
			[Token(Token = "0x60015AB")]
			[Address(RVA = "0x676D", Offset = "0x676D", VA = "0x676D", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015AC")]
		[Address(RVA = "0x676E", Offset = "0x676E", VA = "0x676E")]
		private void InVortexButtonClickedEventHandler()
		{
		/* --- GHIDRA: InVortexButtonClickedEventHandler ---
		void Gameplay_VortexRating_Controller_VortexViewMediator__InVortexButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a581ff == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VortexView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a581ff = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x10) + 0xb8);
		  iVar1 = param1[2];
		  param2_00 = *(undefined4 *)(iVar1 + 8);
		  uVar2 = Gameplay_VortexRating_Model_VortexRatingModel__GetTabBarItemData(iVar1,iVar1);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__op_Explicit(uVar2,0);
		  UI_Price_Price__SetColor(param1_00,param2_00,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x060015AD RID: 5549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015AD")]
		[Address(RVA = "0x676F", Offset = "0x676F", VA = "0x676F")]
		private void Init()
		{
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015AE")]
		[Address(RVA = "0x6770", Offset = "0x6770", VA = "0x6770", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_VortexRating_Controller_VortexViewMediator__Hide
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58200 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VoteRewardsView___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_VortexRating_View_VoteRewardsTab_GiftListElement___TypeInfo);
		    DAT_ram_00a58200 = '\x01';
		  }
		  uVar1 = Mono_Security_ASN1Convert__ToOid
		                    (Gameplay_VortexRating_View_VoteRewardsTab_GiftListElement___TypeInfo,0);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VoteRewardsView___ctor__
		            );
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_VortexRating_Controller_VortexViewMediator__set_View(int param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a581fe == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__Stop__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__TryRun__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VortexView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_VortexCombat_TypeInfo);
		    DAT_ram_00a581fe = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 8) + 8);
		  param2_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  param1_00 = (int *)unnamed_function_1417(Gameplay_VortexCombat_VortexCombat_TypeInfo);
		  Gameplay_VortexCombat_VortexCombat__CheckRunRestrictions
		            (param1_00,param2_00,uVar2,uVar2,0,param1_00);
		  uVar2 = Gameplay_VortexRating_Model_VortexRatingModel__GetTabBarItemData
		                    (*(undefined4 *)(param1 + 8),param1_00);
		  iVar1 = Gameplay_Combat_AbstractCombat_object__object__object__object__object___TryRun
		                    (param1_00,uVar2,
		                     Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__TryRun__
		                    );
		  if (iVar1 != 0) {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		    UI_Windows_PopupController__Close(uVar2,2,0);
		    return;
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___SetView
		            (param1_00,
		             Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__Stop__
		            );
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x118) * 4))
		            (param1_00,*(undefined4 *)(*param1_00 + 0x11c));
		  return;
		}
		*/

}
