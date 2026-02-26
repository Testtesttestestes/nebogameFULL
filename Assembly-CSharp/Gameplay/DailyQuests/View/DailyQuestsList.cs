using System;
using Il2CppDummyDll;
using UI.Elements.GenericList;

namespace Gameplay.DailyQuests.View
{
	// Token: 0x0200086F RID: 2159
	[Token(Token = "0x200086F")]
	public class DailyQuestsList : SelectorGenericList<DailyQuestsListArgs, DailyQuestsListElement, DailyQuestsListElementArgs>
	{
		// Token: 0x060032BA RID: 12986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032BA")]
		[Address(RVA = "0x830C", Offset = "0x830C", VA = "0x830C")]
		public DailyQuestsList()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_DailyQuests_View_DailyQuestsList___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57c1b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectedGenericListArgs_DailyQuestsListElementArgs___ctor__
		              );
		    DAT_ram_00a57c1b = '\x01';
		  }
		  UI_Elements_GenericList_SelectableListElement_object___get_Data
		            (param1,
		             Method_UI_Elements_GenericList_SelectedGenericListArgs_DailyQuestsListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
