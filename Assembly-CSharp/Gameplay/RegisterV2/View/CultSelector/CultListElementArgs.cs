using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Elements.GenericList;

namespace Gameplay.RegisterV2.View.CultSelector
{
	// Token: 0x02000567 RID: 1383
	[Token(Token = "0x2000567")]
	public class CultListElementArgs : GenericListElementArgs
	{
		// Token: 0x06002155 RID: 8533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002155")]
		[Address(RVA = "0x72B7", Offset = "0x72B7", VA = "0x72B7")]
		public CultListElementArgs(CultDic cultDic)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_RegisterV2_View_CultSelector_CultListElementArgs___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58380 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectorGenericList_CultSelectorListArgs__CultListElement__CultListElementArgs___ctor__
		              );
		    DAT_ram_00a58380 = '\x01';
		  }
		  UI_Elements_GenericList_SelectedGenericListElement_object___set_Selected
		            (param1,
		             Method_UI_Elements_GenericList_SelectorGenericList_CultSelectorListArgs__CultListElement__CultListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04001235 RID: 4661
		[Token(Token = "0x4001235")]
		[FieldOffset(Offset = "0xC")]
		public CultDic CultDic;
	}
}
