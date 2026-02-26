using System;
using Il2CppDummyDll;
using UI.Elements.GenericList;

namespace Gameplay.RegisterV2.View.CultSelector
{
	// Token: 0x02000568 RID: 1384
	[Token(Token = "0x2000568")]
	public class CultSectorList : SelectorGenericList<CultSelectorListArgs, CultListElement, CultListElementArgs>
	{
		// Token: 0x06002156 RID: 8534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002156")]
		[Address(RVA = "0x72B8", Offset = "0x72B8", VA = "0x72B8")]
		public CultSectorList()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_RegisterV2_View_CultSelector_CultSectorList___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58381 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_GenericList_SelectedGenericListArgs_CultListElementArgs___ctor__)
		    ;
		    DAT_ram_00a58381 = '\x01';
		  }
		  UI_Elements_GenericList_SelectableListElement_object___get_Data
		            (param1,
		             Method_UI_Elements_GenericList_SelectedGenericListArgs_CultListElementArgs___ctor__);
		  return;
		}
		*/

		}
	}
}
