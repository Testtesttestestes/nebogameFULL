using System;
using Com.TheFallenGames.OSA.Core;
using Il2CppDummyDll;

namespace Gameplay.Market.View
{
	// Token: 0x0200061A RID: 1562
	[Token(Token = "0x200061A")]
	public class MarketLotViewsHolder : BaseItemViewsHolder
	{
		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x060025E9 RID: 9705 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060025EA RID: 9706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700071E")]
		public MarketLotListElement.MarketLotListElementArgs MarketLotData
		{
			[Token(Token = "0x60025E9")]
			[Address(RVA = "0x7727", Offset = "0x7727", VA = "0x7727")]
			get
			{
				return null;
			}
			[Token(Token = "0x60025EA")]
			[Address(RVA = "0x7728", Offset = "0x7728", VA = "0x7728")]
			set
			{
			}
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025EB")]
		[Address(RVA = "0x7729", Offset = "0x7729", VA = "0x7729", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025EC")]
		[Address(RVA = "0x772A", Offset = "0x772A", VA = "0x772A")]
		public MarketLotViewsHolder()
		{
		}

		// Token: 0x040014AB RID: 5291
		[Token(Token = "0x40014AB")]
		[FieldOffset(Offset = "0x14")]
		private MarketLotListElement _listElement;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_MarketLotData ---
		void Gameplay_Market_View_MarketLotViewsHolder__get_MarketLotData
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Market_View_MarketLotListElement__get_Data(*(undefined4 *)(param1 + 0x14),param2,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_MarketLotData ---
		void Gameplay_Market_View_MarketLotViewsHolder__set_MarketLotData(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59fe3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_MarketLotListElement___)
		    ;
		    DAT_ram_00a59fe3 = '\x01';
		  }
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 8),
		                       Method_UnityEngine_Component_GetComponent_MarketLotListElement___);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/

}
