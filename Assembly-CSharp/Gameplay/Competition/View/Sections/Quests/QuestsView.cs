using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.MVC.Interfaces;
using Gameplay.Competition.Control.Sections;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Gameplay.DailyQuests.Model;
using Gameplay.DailyQuests.View;
using Il2CppDummyDll;
using MVC;
using UnityEngine;

namespace Gameplay.Competition.View.Sections.Quests
{
	// Token: 0x020008E7 RID: 2279
	[Token(Token = "0x20008E7")]
	[AddComponentMenu("Competition/View/Sections/QuestsView")]
	public class QuestsView : BaseSectionView<QuestController>
	{
		// Token: 0x14000172 RID: 370
		// (add) Token: 0x060035B5 RID: 13749 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060035B6 RID: 13750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000172")]
		public event Action<IDailyQuest> ItemSelectedEvent
		{
			[Token(Token = "0x60035B5")]
			[Address(RVA = "0x85C3", Offset = "0x85C3", VA = "0x85C3")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60035B6")]
			[Address(RVA = "0x85C4", Offset = "0x85C4", VA = "0x85C4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B7")]
		[Address(RVA = "0x85C5", Offset = "0x85C5", VA = "0x85C5", Slot = "6")]
		protected override void CreateController(CompetitionModel model, CompetitionEvents events, out QuestController controller)
		{
		/* --- GHIDRA: CreateController ---
		void Gameplay_Competition_View_Sections_Quests_QuestsView__CreateController
		               (undefined4 param1,int *param2,int *param3,undefined4 param4)
		
		{
		  undefined4 param3_00;
		  undefined4 param4_00;
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63aa0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Control_Sections_QuestsViewMediator_TypeInfo)
		    ;
		    DAT_ram_00a63aa0 = '\x01';
		  }
		  param3_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x100) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0x104));
		  param4_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x110) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0x114));
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Competition_Control_Sections_QuestsViewMediator_TypeInfo);
		  if (DAT_ram_00a63aee == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_QuestModel__QuestEvents__QuestController__QuestsView___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Sorting_QuestComparer_TypeInfo);
		    DAT_ram_00a63aee = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Sorting_QuestComparer_TypeInfo);
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  MVC_AbstractCozyViewMediator_object__object__object__object____ctor
		            (param1_00,param1,param3_00,param4_00,param2,
		             Method_MVC_AbstractCozyViewMediator_QuestModel__QuestEvents__QuestController__QuestsView___ctor__
		            );
		  *param3 = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B8")]
		[Address(RVA = "0x85C6", Offset = "0x85C6", VA = "0x85C6", Slot = "7")]
		protected override void CreateMediator(QuestController controller, out IViewMediator mediator)
		{
		/* --- GHIDRA: CreateMediator ---
		void Gameplay_Competition_View_Sections_Quests_QuestsView__CreateMediator
		               (undefined4 param1,int *param2,undefined4 *param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x110) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0x114));
		  *param3 = uVar1;
		  MVC_AbstractController__Dispose(param2,0);
		  return;
		}
		*/

		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B9")]
		[Address(RVA = "0x85C7", Offset = "0x85C7", VA = "0x85C7", Slot = "8")]
		protected override void RunController(QuestController controller, out AbstractMVCEvents events)
		{
		/* --- GHIDRA: RunController ---
		void Gameplay_Competition_View_Sections_Quests_QuestsView__RunController
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  
		  if (DAT_ram_00a63aa1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__DailyQuestsViewsHolder__get_IsInitialized__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_View_Sections_Quests_QuestsView___c__DisplayClass7_0__Init_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Competition_View_Sections_Quests_QuestsView___c__DisplayClass7_0_TypeInfo);
		    DAT_ram_00a63aa1 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Competition_View_Sections_Quests_QuestsView___c__DisplayClass7_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int *)(param2_00 + 8) = param1;
		  iVar1 = **(int **)(param1 + 0x24);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x3b8) * 4))
		            (*(int **)(param1 + 0x24),*(undefined4 *)(iVar1 + 0x3bc));
		  param1_01 = *(int **)(param1 + 0x24);
		  if ((char)param1_01[0x14] != '\0') {
		    Gameplay_DailyQuests_View_DailyQuestsListAdapter__Start
		              (param1_01,*(undefined4 *)(param2_00 + 0xc),0);
		    return;
		  }
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param2_00,
		             Method_Gameplay_Competition_View_Sections_Quests_QuestsView___c__DisplayClass7_0__Init_b__0__
		             ,0);
		  (**(code **)((ulonglong)*(uint *)(*param1_01 + 0x298) * 4))
		            (param1_01,param1_00,*(undefined4 *)(*param1_01 + 0x29c));
		  return;
		}
		*/

		}

		// Token: 0x060035BA RID: 13754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035BA")]
		[Address(RVA = "0x85C8", Offset = "0x85C8", VA = "0x85C8")]
		public void Init(IList<DailyQuestsListElementArgs> items)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Competition_View_Sections_Quests_QuestsView__Init(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63aa2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Competition_View_Sections_BaseSectionView_QuestController___ctor__);
		    DAT_ram_00a63aa2 = '\x01';
		  }
		  Gameplay_AccountLinker_ProgressSaver_Controller_BaseProgressSaverEnterPointViewMediator_object___set_View
		            (param1,
		             Method_Gameplay_Competition_View_Sections_BaseSectionView_QuestController___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060035BB RID: 13755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035BB")]
		[Address(RVA = "0x85C9", Offset = "0x85C9", VA = "0x85C9")]
		public QuestsView()
		{
		}

		// Token: 0x04001D61 RID: 7521
		[Token(Token = "0x4001D61")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private DailyQuestsListAdapter _questsListAdapter;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ItemSelectedEvent ---
		void Gameplay_Competition_View_Sections_Quests_QuestsView__add_ItemSelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63a9e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IDailyQuest__TypeInfo);
		    DAT_ram_00a63a9e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IDailyQuest__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IDailyQuest__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ItemSelectedEvent ---
		void Gameplay_Competition_View_Sections_Quests_QuestsView__remove_ItemSelectedEvent
		               (undefined4 param1,int param2,undefined4 param3,undefined4 *param4,undefined4 param5)
		
		{
		  int param3_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a63a9f == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Control_Sections_QuestController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Events_QuestEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Model_QuestModel_TypeInfo);
		    DAT_ram_00a63a9f = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0xc);
		  uVar2 = *(undefined4 *)(iVar1 + 0x14);
		  uVar3 = *(undefined4 *)(iVar1 + 0x10);
		  uVar4 = *(undefined4 *)(iVar1 + 8);
		  param2_00 = *(undefined4 *)(param2 + 8);
		  iVar1 = unnamed_function_1417(Gameplay_Competition_Model_QuestModel_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(iVar1,param2_00,0);
		  *(undefined4 *)(iVar1 + 0x14) = uVar4;
		  *(undefined4 *)(iVar1 + 0x10) = uVar3;
		  *(undefined4 *)(iVar1 + 0xc) = uVar2;
		  *(int *)(iVar1 + 0x18) = param2;
		  param3_00 = unnamed_function_1417(Gameplay_Competition_Events_QuestEvents_TypeInfo);
		  *(undefined4 *)(param3_00 + 0x14) = param3;
		  uVar2 = unnamed_function_1417(Gameplay_Competition_Control_Sections_QuestController_TypeInfo);
		  if (DAT_ram_00a63aed == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_QuestModel__QuestEvents___ctor__);
		    DAT_ram_00a63aed = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (uVar2,iVar1,param3_00,Method_MVC_AbstractController_QuestModel__QuestEvents___ctor__);
		  *param4 = uVar2;
		  return;
		}
		*/

}
