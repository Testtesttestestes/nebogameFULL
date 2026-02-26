using System;
using Gameplay.DailyQuests.Controller;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.DailyQuests.View
{
	// Token: 0x0200086D RID: 2157
	[Token(Token = "0x200086D")]
	public class DailyQuestReadViewWindow : ClosableBaseWindow<DailyQuestReadViewWindowArgs>
	{
		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x060032B5 RID: 12981 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009FF")]
		public override string WindowId
		{
			[Token(Token = "0x60032B5")]
			[Address(RVA = "0x8307", Offset = "0x8307", VA = "0x8307", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060032B6 RID: 12982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B6")]
		[Address(RVA = "0x8308", Offset = "0x8308", VA = "0x8308", Slot = "22")]
		protected override void OnShow(DailyQuestReadViewWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_DailyQuests_View_DailyQuestReadViewWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57c18 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_DailyQuestReadViewWindowArgs__OnClose__);
		    DAT_ram_00a57c18 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,Method_UI_Windows_ClosableBaseWindow_DailyQuestReadViewWindowArgs__OnClose__);
		  iVar1 = **(int **)(param1 + 0x40);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x40),*(undefined4 *)(iVar1 + 0x134));
		  return;
		}
		*/

		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B7")]
		[Address(RVA = "0x8309", Offset = "0x8309", VA = "0x8309", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_DailyQuests_View_DailyQuestReadViewWindow__OnClose
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57c19 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_DailyQuestReadViewWindowArgs___ctor__);
		    DAT_ram_00a57c19 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_DailyQuestReadViewWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060032B8 RID: 12984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B8")]
		[Address(RVA = "0x830A", Offset = "0x830A", VA = "0x830A")]
		public DailyQuestReadViewWindow()
		{
		}

		// Token: 0x04001BC2 RID: 7106
		[Token(Token = "0x4001BC2")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/DailyQuests/DailyQuestReadViewWindow";

		// Token: 0x04001BC3 RID: 7107
		[Token(Token = "0x4001BC3")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private DailyQuestReadView _view;

		// Token: 0x04001BC4 RID: 7108
		[Token(Token = "0x4001BC4")]
		[FieldOffset(Offset = "0x40")]
		private DailyQuestReadViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_DailyQuests_View_DailyQuestReadViewWindow__get_WindowId
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param3_00;
		  int *param1_00;
		  undefined4 param4;
		  int iVar1;
		  
		  if (DAT_ram_00a57c17 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_DailyQuestReadViewWindowArgs__OnShow__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator_TypeInfo);
		    DAT_ram_00a57c17 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_DailyQuestReadViewWindowArgs__OnShow__);
		  iVar1 = **(int **)(param2 + 0x18);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x100) * 4))
		                        (*(int **)(param2 + 0x18),*(undefined4 *)(iVar1 + 0x104));
		  iVar1 = **(int **)(param2 + 0x18);
		  param3_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x110) * 4))
		                        (*(int **)(param2 + 0x18),*(undefined4 *)(iVar1 + 0x114));
		  param4 = *(undefined4 *)(param2 + 0x18);
		  param1_00 = (int *)unnamed_function_1417
		                               (Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator_TypeInfo)
		  ;
		  Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator__Dispose
		            (param1_00,param2_00,param3_00,param4,param1_00);
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,*(undefined4 *)(param1 + 0x3c),*(undefined4 *)(*param1_00 + 0x164));
		  *(int **)(param1 + 0x40) = param1_00;
		  return;
		}
		*/

}
