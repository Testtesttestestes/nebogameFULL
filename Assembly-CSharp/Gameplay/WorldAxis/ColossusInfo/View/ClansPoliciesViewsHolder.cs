using System;
using Il2CppDummyDll;
using UI;
using UI.Elements.GenericList;

namespace Gameplay.WorldAxis.ColossusInfo.View
{
	// Token: 0x02000328 RID: 808
	[Token(Token = "0x2000328")]
	public class ClansPoliciesViewsHolder : ItemViewsHolder<TreasuryOptionListElement>
	{
		// Token: 0x0600128E RID: 4750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600128E")]
		[Address(RVA = "0x6488", Offset = "0x6488", VA = "0x6488", Slot = "13")]
		public override void SetData(GenericListElementArgs args)
		{
		/* --- GHIDRA: SetData ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClansPoliciesViewsHolder__SetData
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57f58 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ItemViewsHolder_ClanPolicyListElement___ctor__);
		    DAT_ram_00a57f58 = '\x01';
		  }
		  return;
		}
		*/

		/* --- GHIDRA: SetData ---
		void Gameplay_WorldAxis_ColossusInfo_View_ClansPoliciesViewsHolder__SetData
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58bda == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ItemViewsHolder_TreasuryOptionListElement___ctor__);
		    DAT_ram_00a58bda = '\x01';
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600128F")]
		[Address(RVA = "0x6489", Offset = "0x6489", VA = "0x6489")]
		public ClansPoliciesViewsHolder()
		{
		}
	}
}
