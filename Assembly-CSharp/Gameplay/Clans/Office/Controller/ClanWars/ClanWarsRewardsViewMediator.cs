using System;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.ClanWarsTab.ClanWarsRewardsTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.Clans.Office.Controller.ClanWars
{
	// Token: 0x02000A86 RID: 2694
	[Token(Token = "0x2000A86")]
	public class ClanWarsRewardsViewMediator : AbstractViewMediator<ClanWarsOfficeModel, ClanWarsOfficeEvents, ClanWarsOfficeController, ClanWarsRewardsView>, IHideableMediator
	{
		// Token: 0x06004071 RID: 16497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004071")]
		[Address(RVA = "0x8F2B", Offset = "0x8F2B", VA = "0x8F2B")]
		public ClanWarsRewardsViewMediator(ClanWarsOfficeModel model, ClanWarsOfficeEvents events, ClanWarsOfficeController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57729 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanWarsRewardsView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_SubFilterListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator_FilterViewClickedEventHandler__
		              );
		    DAT_ram_00a57729 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_SubFilterListElement__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator_FilterViewClickedEventHandler__
		               ,0);
		    UI_Elements_Filters_GenericFilter_GenericSubFilterView__add_ClickedEvent(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_SubFilterListElement__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator_FilterViewClickedEventHandler__
		               ,0);
		    UI_Elements_Filters_GenericFilter_GenericFilterView___ctor(uVar3,uVar1,0);
		    Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator__UpdateCurrentSeasonInfo
		              (param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000CB7 RID: 3255
		// (set) Token: 0x06004072 RID: 16498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB7")]
		public override ClanWarsRewardsView View
		{
			[Token(Token = "0x6004072")]
			[Address(RVA = "0x8F2C", Offset = "0x8F2C", VA = "0x8F2C", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (set) Token: 0x06004073 RID: 16499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB8")]
		public override ClanWarsOfficeEvents Events
		{
			[Token(Token = "0x6004073")]
			[Address(RVA = "0x8F2D", Offset = "0x8F2D", VA = "0x8F2D", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004074 RID: 16500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004074")]
		[Address(RVA = "0x8F2E", Offset = "0x8F2E", VA = "0x8F2E")]
		private void UpdateCurrentSeasonInfo()
		{
		/* --- GHIDRA: UpdateCurrentSeasonInfo ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator__UpdateCurrentSeasonInfo
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5772c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanWarsRewardsView__get_Model__
		              );
		    DAT_ram_00a5772c = '\x01';
		  }
		  if (DAT_ram_00a5772b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanWarsRewardsView__get_Model__
		              );
		    DAT_ram_00a5772b = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1[2] + 0x2c) + 0x1c);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar2 == 0) {
		    Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__SetCurrentSeasonBacktime
		              (uVar1,*(undefined4 *)(*(int *)(param1[2] + 0x2c) + 0x20),0);
		  }
		  else {
		    Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__UpdateLeagueInfo
		              (uVar1,*(undefined4 *)(*(int *)(param1[2] + 0x2c) + 0x1c),0);
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_Filters_GenericFilter_GenericSubFilterView__remove_ClickedEvent
		            (*(undefined4 *)(iVar2 + 0x18),*(undefined4 *)(param1[2] + 0x14),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView___ctor
		            (*(undefined4 *)(iVar2 + 0x1c),*(undefined4 *)(param1[2] + 0x30),
		             *(undefined4 *)(param1[2] + 0x10),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = UI_Elements_Filters_GenericFilter_GenericSubFilterView__SelectByIndexSilent
		                    (*(undefined4 *)(iVar2 + 0x18),0,0);
		  Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator__FilterViewClickedEventHandler
		            (param1,uVar1,param1);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Office_Controller_ClanWars_ClanWarsOfficeController__Init(uVar1,param1);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004075 RID: 16501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004075")]
		[Address(RVA = "0x8F2F", Offset = "0x8F2F", VA = "0x8F2F")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator__Init
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Data
		            (*(undefined4 *)(param1 + 0x18),0,0);
		  Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator__FilterViewClickedEventHandler
		            (param1,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004076 RID: 16502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004076")]
		[Address(RVA = "0x8F30", Offset = "0x8F30", VA = "0x8F30")]
		private void FilterViewClickedEventHandler(SubFilterListElement element)
		{
		/* --- GHIDRA: FilterViewClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator__FilterViewClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a5772d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanWarsRewardsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_FilterListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ClanLeagueDic_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator_FilterListElementClickedEventHandler__
		              );
		    DAT_ram_00a5772d = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Dic_ClanLeagueDic_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Dic_ClanLeagueDic_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1[6] = param2;
		  Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Data(param2,1,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = Gameplay_Clans_Office_Model_ClanWarsOfficeModel__GetBankDistribution
		                        (param1[2],param1_01[3],0);
		  param1_00 = unnamed_function_1417(System_Action_FilterListElement__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator_FilterListElementClickedEventHandler__
		             ,0);
		  uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__get_InfoBox
		                    (uVar1,param2_00,param1_00,0);
		  Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator__FilterListElementClickedEventHandler
		            (param1,uVar1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004077 RID: 16503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004077")]
		[Address(RVA = "0x8F31", Offset = "0x8F31", VA = "0x8F31")]
		private void SelectFilter(SubFilterListElement element)
		{
		/* --- GHIDRA: SelectFilter ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator__SelectFilter
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  UI_Elements_Filters_GenericFilter_FilterListElement__get_Selected
		            (*(undefined4 *)(param1 + 0x1c),0,0);
		  Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator__FilterListElementClickedEventHandler
		            (param1,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004078 RID: 16504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004078")]
		[Address(RVA = "0x8F32", Offset = "0x8F32", VA = "0x8F32")]
		private void FilterListElementClickedEventHandler(FilterListElement element)
		{
		/* --- GHIDRA: FilterListElementClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator__FilterListElementClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 param4;
		  int *param1_01;
		  
		  if (DAT_ram_00a5772e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanWarsRewardsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_SeasonLeagueRewardsDic_TypeInfo);
		    DAT_ram_00a5772e = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x24);
		  if ((param1_01 != (int *)0x0) && (Protocol_Dic_SeasonLeagueRewardsDic_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Dic_SeasonLeagueRewardsDic_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1[7] = param2;
		  UI_Elements_Filters_GenericFilter_FilterListElement__get_Selected(param2,1,0);
		  uVar1 = Gameplay_Clans_Office_Model_ClanResumesModel___c__DisplayClass13_0___AddUsersList_b__0
		                    (param1[2],0);
		  uVar1 = Core_Extensions_Dict_DictExt__GetClanPrizesByKindId(uVar1,param1_01[4],0);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  param4 = Gameplay_Clans_Office_Model_ClanWarsOfficeModel__SetBankDistribution
		                     (param1[2],param1_01[4],param1_01[5],0);
		  Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__UpdateRewardsList
		            (param1_00,uVar1,param1_01,param4,0);
		  return;
		}
		*/

		}

		// Token: 0x06004079 RID: 16505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004079")]
		[Address(RVA = "0x8F33", Offset = "0x8F33", VA = "0x8F33")]
		private void SelectListElement(FilterListElement element)
		{
		/* --- GHIDRA: SelectListElement ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator__SelectListElement
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5772f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SubFilterListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator_FilterViewClickedEventHandler__
		              );
		    DAT_ram_00a5772f = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		            (param1,0,*(undefined4 *)(*param1 + 0x144));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_SubFilterListElement__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator_FilterViewClickedEventHandler__
		             ,0);
		  UI_Elements_Filters_GenericFilter_GenericSubFilterView__add_ClickedEvent(param1_00,uVar2,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  return;
		}
		*/

		}

		// Token: 0x0600407A RID: 16506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600407A")]
		[Address(RVA = "0x8F34", Offset = "0x8F34", VA = "0x8F34", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator__Hide
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  Gameplay_Clans_Office_Controller_ClanWars_TruceStatusViewMediator__AttackButtonClickedEventHandler
		            (param1,param2,param3,param4,param5,param5);
		  return;
		}
		*/

		}

		// Token: 0x040023DF RID: 9183
		[Token(Token = "0x40023DF")]
		[FieldOffset(Offset = "0x18")]
		private SubFilterListElement _selectedFilter;

		// Token: 0x040023E0 RID: 9184
		[Token(Token = "0x40023E0")]
		[FieldOffset(Offset = "0x1C")]
		private FilterListElement _selectedElement;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5772a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanWarsRewardsView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator_UpdateCurrentSeasonInfo__
		              );
		    DAT_ram_00a5772a = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar4 = *(int *)(iVar1 + 0x14);
		    uVar5 = *(undefined4 *)(iVar4 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator_UpdateCurrentSeasonInfo__
		               ,0);
		    piVar3 = (int *)func_ii_7048(uVar5,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar3 == (int *)0x0) {
		      *(undefined4 *)(iVar4 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar3) ||
		            (*(int **)(iVar4 + 0x1c) = piVar3, *piVar3 != iVar1)) {
		      System_Activator__CreateInstance(piVar3,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar4 = *(int *)(iVar1 + 0x14);
		    uVar5 = *(undefined4 *)(iVar4 + 0x1c);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator_UpdateCurrentSeasonInfo__
		               ,0);
		    piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar3 == (int *)0x0) {
		      *(undefined4 *)(iVar4 + 0x1c) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar3) || (*(int **)(iVar4 + 0x1c) = piVar3, *piVar3 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar3,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsRewardsViewMediator__set_Events
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5772b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsOfficeModel__ClanWarsOfficeEvents__ClanWarsOfficeController__ClanWarsRewardsView__get_Model__
		              );
		    DAT_ram_00a5772b = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1[2] + 0x2c) + 0x1c);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar1 != 0) {
		    Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__UpdateLeagueInfo
		              (param1_00,*(undefined4 *)(*(int *)(param1[2] + 0x2c) + 0x1c),0);
		    return;
		  }
		  Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__SetCurrentSeasonBacktime
		            (param1_00,*(undefined4 *)(*(int *)(param1[2] + 0x2c) + 0x20),0);
		  return;
		}
		*/

}
