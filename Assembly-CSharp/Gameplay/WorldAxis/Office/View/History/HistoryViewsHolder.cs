using System;
using Il2CppDummyDll;
using UI;
using UI.Elements.GenericList;

namespace Gameplay.WorldAxis.Office.View.History
{
	// Token: 0x02000313 RID: 787
	[Token(Token = "0x2000313")]
	public class HistoryViewsHolder : ItemViewsHolder<BattleHistoryListElement>
	{
		// Token: 0x0600123C RID: 4668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600123C")]
		[Address(RVA = "0x6436", Offset = "0x6436", VA = "0x6436", Slot = "13")]
		public override void SetData(GenericListElementArgs args)
		{
		/* --- GHIDRA: SetData ---
		void Gameplay_WorldAxis_Office_View_History_HistoryViewsHolder__SetData
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58bc0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ItemViewsHolder_BattleHistoryListElement___ctor__);
		    DAT_ram_00a58bc0 = '\x01';
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600123D RID: 4669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600123D")]
		[Address(RVA = "0x6437", Offset = "0x6437", VA = "0x6437")]
		public HistoryViewsHolder()
		{
		}
	}
}
