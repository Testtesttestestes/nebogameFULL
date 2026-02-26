using System;
using Gameplay.DailyQuests.Controller;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.DailyQuests.View
{
	// Token: 0x02000877 RID: 2167
	[Token(Token = "0x2000877")]
	public class DailyQuestsWindow : ClosableBaseWindow<DailyQuestsWindowArgs>
	{
		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x060032E5 RID: 13029 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A07")]
		public override string WindowId
		{
			[Token(Token = "0x60032E5")]
			[Address(RVA = "0x8337", Offset = "0x8337", VA = "0x8337", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E6")]
		[Address(RVA = "0x8338", Offset = "0x8338", VA = "0x8338", Slot = "22")]
		protected override void OnShow(DailyQuestsWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_DailyQuests_View_DailyQuestsWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  piVar1 = *(int **)(param1 + 0x40);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x40) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060032E7 RID: 13031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E7")]
		[Address(RVA = "0x8339", Offset = "0x8339", VA = "0x8339")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_DailyQuests_View_DailyQuestsWindow__OnDestroy(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57c37 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_DailyQuestsWindowArgs___ctor__);
		    DAT_ram_00a57c37 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_DailyQuestsWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060032E8 RID: 13032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E8")]
		[Address(RVA = "0x833A", Offset = "0x833A", VA = "0x833A")]
		public DailyQuestsWindow()
		{
		}

		// Token: 0x04001BDC RID: 7132
		[Token(Token = "0x4001BDC")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/DailyQuests/DailyQuestsWindow";

		// Token: 0x04001BDD RID: 7133
		[Token(Token = "0x4001BDD")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private DailyQuestsView _dailyQuestsView;

		// Token: 0x04001BDE RID: 7134
		[Token(Token = "0x4001BDE")]
		[FieldOffset(Offset = "0x40")]
		private DailyQuestsViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_DailyQuests_View_DailyQuestsWindow__get_WindowId
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param3_00;
		  int *param1_00;
		  int iVar1;
		  undefined4 param4;
		  int iVar2;
		  
		  if (DAT_ram_00a57c36 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_DailyQuestsWindowArgs__OnShow__);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Controller_DailyQuestsViewMediator_TypeInfo);
		    DAT_ram_00a57c36 = '\x01';
		  }
		  func_ii_7769(param1,param2,Method_UI_Windows_ClosableBaseWindow_DailyQuestsWindowArgs__OnShow__);
		  iVar2 = **(int **)(param2 + 0x18);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                        (*(int **)(param2 + 0x18),*(undefined4 *)(iVar2 + 0x104));
		  iVar2 = **(int **)(param2 + 0x18);
		  param3_00 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		                        (*(int **)(param2 + 0x18),*(undefined4 *)(iVar2 + 0x114));
		  iVar2 = *(int *)(param2 + 0x1c);
		  param4 = *(undefined4 *)(param2 + 0x18);
		  param1_00 = (int *)unnamed_function_1417
		                               (Gameplay_DailyQuests_Controller_DailyQuestsViewMediator_TypeInfo);
		  if (DAT_ram_00a57c8a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestsView___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Sorting_QuestComparer_TypeInfo);
		    DAT_ram_00a57c8a = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Sorting_QuestComparer_TypeInfo);
		  param1_00[7] = iVar1;
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1_00,param2_00,param3_00,param4,
		             Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestsView___ctor__
		            );
		  param1_00[6] = iVar2;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,*(undefined4 *)(param1 + 0x3c),*(undefined4 *)(*param1_00 + 0x164));
		  *(int **)(param1 + 0x40) = param1_00;
		  return;
		}
		*/

}
