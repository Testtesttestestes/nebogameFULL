using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UI;
using UI.Tabs;
using UI.Toggle;
using UnityEngine;

namespace Gameplay.DailyQuests.View
{
	// Token: 0x02000875 RID: 2165
	[Token(Token = "0x2000875")]
	public class DailyQuestsView : MonoBehaviour
	{
		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x060032DE RID: 13022 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A04")]
		public Toggle SwitchActiveToggle
		{
			[Token(Token = "0x60032DE")]
			[Address(RVA = "0x8330", Offset = "0x8330", VA = "0x8330")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x060032DF RID: 13023 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A05")]
		public CounterBacklight Counter
		{
			[Token(Token = "0x60032DF")]
			[Address(RVA = "0x8331", Offset = "0x8331", VA = "0x8331")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x060032E0 RID: 13024 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A06")]
		public TabBar TabBar
		{
			[Token(Token = "0x60032E0")]
			[Address(RVA = "0x8332", Offset = "0x8332", VA = "0x8332")]
			get
			{
				return null;
			}
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E1")]
		[Address(RVA = "0x8333", Offset = "0x8333", VA = "0x8333")]
		public void Init(IList<DailyQuestsListElementArgs> items)
		{
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E2")]
		[Address(RVA = "0x8334", Offset = "0x8334", VA = "0x8334")]
		public DailyQuestsView()
		{
		}

		// Token: 0x04001BD6 RID: 7126
		[Token(Token = "0x4001BD6")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x04001BD7 RID: 7127
		[Token(Token = "0x4001BD7")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private DailyQuestsListAdapter _questsListAdapter;

		// Token: 0x04001BD8 RID: 7128
		[Token(Token = "0x4001BD8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Toggle _switchActiveToggle;

		// Token: 0x04001BD9 RID: 7129
		[Token(Token = "0x4001BD9")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CounterBacklight _counter;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_TabBar ---
		void Gameplay_DailyQuests_View_DailyQuestsView__get_TabBar
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a57c34 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__DailyQuestsViewsHolder__get_IsInitialized__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_DailyQuests_View_DailyQuestsView___c__DisplayClass10_0__Init_b__0__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_DailyQuests_View_DailyQuestsView___c__DisplayClass10_0_TypeInfo);
		    DAT_ram_00a57c34 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_DailyQuests_View_DailyQuestsView___c__DisplayClass10_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int *)(param2_00 + 8) = param1;
		  iVar3 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x3b8) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar3 + 0x3bc));
		  piVar2 = *(int **)(param1 + 0x14);
		  if ((char)piVar2[0x14] != '\0') {
		    uVar1 = *(undefined4 *)(param2_00 + 0xc);
		    if (DAT_ram_00a57c1d == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_DailyQuestsListElementArgs__ResetItems__
		                );
		      DAT_ram_00a57c1d = '\x01';
		    }
		    Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		              (piVar2[0x28],uVar1,0,
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_DailyQuestsListElementArgs__ResetItems__
		              );
		    return;
		  }
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param2_00,
		             Method_Gameplay_DailyQuests_View_DailyQuestsView___c__DisplayClass10_0__Init_b__0__,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x298) * 4))
		            (piVar2,uVar1,*(undefined4 *)(*piVar2 + 0x29c));
		  return;
		}
		*/

}
