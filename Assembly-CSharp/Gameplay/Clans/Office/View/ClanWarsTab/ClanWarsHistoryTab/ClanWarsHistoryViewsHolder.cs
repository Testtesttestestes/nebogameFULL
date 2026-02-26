using System;
using Il2CppDummyDll;
using UI;
using UI.Elements.GenericList;

namespace Gameplay.Clans.Office.View.ClanWarsTab.ClanWarsHistoryTab
{
	// Token: 0x02000A1D RID: 2589
	[Token(Token = "0x2000A1D")]
	public class ClanWarsHistoryViewsHolder : ItemViewsHolder<ClanWarHistoryListElement>
	{
		// Token: 0x06003D7F RID: 15743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D7F")]
		[Address(RVA = "0x8C3E", Offset = "0x8C3E", VA = "0x8C3E", Slot = "13")]
		public override void SetData(GenericListElementArgs args)
		{
		/* --- GHIDRA: SetData ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryViewsHolder__SetData
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57f50 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ItemViewsHolder_ClanWarHistoryListElement___ctor__);
		    DAT_ram_00a57f50 = '\x01';
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D80")]
		[Address(RVA = "0x8C3F", Offset = "0x8C3F", VA = "0x8C3F")]
		public ClanWarsHistoryViewsHolder()
		{
		}
	}
}
