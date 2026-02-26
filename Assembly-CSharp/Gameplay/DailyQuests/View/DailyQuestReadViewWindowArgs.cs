using System;
using Gameplay.DailyQuests.Controller;
using Il2CppDummyDll;
using UI.Windows;

namespace Gameplay.DailyQuests.View
{
	// Token: 0x0200086E RID: 2158
	[Token(Token = "0x200086E")]
	public class DailyQuestReadViewWindowArgs : BaseWindowArgs
	{
		// Token: 0x060032B9 RID: 12985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B9")]
		[Address(RVA = "0x830B", Offset = "0x830B", VA = "0x830B")]
		public DailyQuestReadViewWindowArgs()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_DailyQuests_View_DailyQuestReadViewWindowArgs___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57c1a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectorGenericList_DailyQuestsListArgs__DailyQuestsListElement__DailyQuestsListElementArgs___ctor__
		              );
		    DAT_ram_00a57c1a = '\x01';
		  }
		  UI_Elements_GenericList_SelectedGenericListElement_object___set_Selected
		            (param1,
		             Method_UI_Elements_GenericList_SelectorGenericList_DailyQuestsListArgs__DailyQuestsListElement__DailyQuestsListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04001BC5 RID: 7109
		[Token(Token = "0x4001BC5")]
		[FieldOffset(Offset = "0x18")]
		public DailyQuestsController Controller;
	}
}
