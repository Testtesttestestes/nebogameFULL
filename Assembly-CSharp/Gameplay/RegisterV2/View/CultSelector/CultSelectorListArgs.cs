using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UI.Elements.GenericList;

namespace Gameplay.RegisterV2.View.CultSelector
{
	// Token: 0x02000569 RID: 1385
	[Token(Token = "0x2000569")]
	public class CultSelectorListArgs : SelectedGenericListArgs<CultListElementArgs>
	{
		// Token: 0x06002157 RID: 8535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002157")]
		[Address(RVA = "0x72B9", Offset = "0x72B9", VA = "0x72B9")]
		public CultSelectorListArgs()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_RegisterV2_View_CultSelector_CultSelectorListArgs___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58382 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_GenericList_SelectedGenericListArgs_CultListElementArgs___ctor__)
		    ;
		    DAT_ram_00a58382 = '\x01';
		  }
		  UI_Elements_GenericList_SelectedGenericListArgs_object____ctor
		            (param1,param2,
		             Method_UI_Elements_GenericList_SelectedGenericListArgs_CultListElementArgs___ctor__);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_RegisterV2_View_CultSelector_CultSelectorListArgs___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58382 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_GenericList_SelectedGenericListArgs_CultListElementArgs___ctor__)
		    ;
		    DAT_ram_00a58382 = '\x01';
		  }
		  UI_Elements_GenericList_SelectedGenericListArgs_object____ctor
		            (param1,param2,
		             Method_UI_Elements_GenericList_SelectedGenericListArgs_CultListElementArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06002158 RID: 8536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002158")]
		[Address(RVA = "0x72BA", Offset = "0x72BA", VA = "0x72BA")]
		public CultSelectorListArgs(List<CultListElementArgs> list)
		{
		}
	}
}
