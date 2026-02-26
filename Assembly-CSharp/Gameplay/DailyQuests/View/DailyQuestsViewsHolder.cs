using System;
using Com.TheFallenGames.OSA.Core;
using Il2CppDummyDll;

namespace Gameplay.DailyQuests.View
{
	// Token: 0x02000872 RID: 2162
	[Token(Token = "0x2000872")]
	public class DailyQuestsViewsHolder : BaseItemViewsHolder
	{
		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x060032C4 RID: 12996 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060032C5 RID: 12997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A01")]
		public DailyQuestsListElementArgs DailyQuestData
		{
			[Token(Token = "0x60032C4")]
			[Address(RVA = "0x8316", Offset = "0x8316", VA = "0x8316")]
			get
			{
				return null;
			}
			[Token(Token = "0x60032C5")]
			[Address(RVA = "0x8317", Offset = "0x8317", VA = "0x8317")]
			set
			{
			}
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032C6")]
		[Address(RVA = "0x8318", Offset = "0x8318", VA = "0x8318")]
		public void Reset()
		{
		/* --- GHIDRA: Reset ---
		void Gameplay_DailyQuests_View_DailyQuestsViewsHolder__Reset(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57c22 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponent_DailyQuestsListElement___);
		    DAT_ram_00a57c22 = '\x01';
		  }
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 8),
		                       Method_UnityEngine_Component_GetComponent_DailyQuestsListElement___);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032C7")]
		[Address(RVA = "0x8319", Offset = "0x8319", VA = "0x8319", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x060032C8 RID: 13000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032C8")]
		[Address(RVA = "0x831A", Offset = "0x831A", VA = "0x831A")]
		public DailyQuestsViewsHolder()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_DailyQuests_View_DailyQuestsViewsHolder___ctor(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57c23 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14978);
		    DAT_ram_00a57c23 = '\x01';
		  }
		  piVar1 = (int *)UI_Rewards_AbstractRewardsRender__SetRewards
		                            (*(undefined4 *)(param1 + 0x34),
		                             Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___)
		  ;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_14978,1,0,1,0,0,0,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x2d0) * 4))
		            (piVar1,uVar2,*(undefined4 *)(*piVar1 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x04001BC7 RID: 7111
		[Token(Token = "0x4001BC7")]
		[FieldOffset(Offset = "0x14")]
		private DailyQuestsListElement _dailyQuestsListElement;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_DailyQuestData ---
		void Gameplay_DailyQuests_View_DailyQuestsViewsHolder__get_DailyQuestData
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x14);
		  if (DAT_ram_00a57c26 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__get_Initted__
		              );
		    DAT_ram_00a57c26 = '\x01';
		  }
		  if (*(char *)(param1_00 + 0x1c) == '\0') {
		    UI_Elements_Buildings_SpellItemArgs___ctor
		              (param1_00,param2,
		               Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__Init__)
		    ;
		    return;
		  }
		  Gameplay_DailyQuests_View_DailyQuestsListElement__Awake(param1_00,param2,param1_00);
		  Gameplay_DailyQuests_View_DailyQuestsListElement__OnInit(param1_00,param1_00);
		  return;
		}
		*/


		/* --- GHIDRA: set_DailyQuestData ---
		void Gameplay_DailyQuests_View_DailyQuestsViewsHolder__set_DailyQuestData
		               (int param1,undefined4 param2)
		
		{
		  Gameplay_DailyQuests_View_DailyQuestsListElement__Awake(*(undefined4 *)(param1 + 0x14),0,param1);
		  return;
		}
		*/

}
