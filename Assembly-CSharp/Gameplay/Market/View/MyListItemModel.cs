using System;
using Il2CppDummyDll;

namespace Gameplay.Market.View
{
	// Token: 0x02000619 RID: 1561
	[Token(Token = "0x2000619")]
	public class MyListItemModel
	{
		// Token: 0x060025E8 RID: 9704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E8")]
		[Address(RVA = "0x7726", Offset = "0x7726", VA = "0x7726")]
		public MyListItemModel()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Craft_View_MyListItemModel___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x14);
		  if (DAT_ram_00a57cdb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CraftRecipeListElement_CraftRecipeListElementArgs__get_args__
		              );
		    DAT_ram_00a57cdb = '\x01';
		  }
		  return *(undefined4 *)(iVar1 + 0x18);
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Market_View_MyListItemModel___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x14);
		  if (DAT_ram_00a59fe6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_MarketLotListElement_MarketLotListElementArgs__get_args__
		              );
		    DAT_ram_00a59fe6 = '\x01';
		  }
		  return *(undefined4 *)(iVar1 + 0x18);
		}
		*/

		}
	}
}
