using System;
using Com.TheFallenGames.OSA.Core;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.View.Lists
{
	// Token: 0x0200078C RID: 1932
	[Token(Token = "0x200078C")]
	public class GameEventsListItemViewsHolder : BaseItemViewsHolder
	{
		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06002DF1 RID: 11761 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002DF2 RID: 11762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008D5")]
		public GameEventsListView.GameEventsListItemWrapper GameEventData
		{
			[Token(Token = "0x6002DF1")]
			[Address(RVA = "0x7E6F", Offset = "0x7E6F", VA = "0x7E6F")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002DF2")]
			[Address(RVA = "0x7E70", Offset = "0x7E70", VA = "0x7E70")]
			set
			{
			}
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF3")]
		[Address(RVA = "0x7E71", Offset = "0x7E71", VA = "0x7E71", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF4")]
		[Address(RVA = "0x7E72", Offset = "0x7E72", VA = "0x7E72")]
		public GameEventsListItemViewsHolder()
		{
		}

		// Token: 0x04001931 RID: 6449
		[Token(Token = "0x4001931")]
		[FieldOffset(Offset = "0x14")]
		private GameEventItemRenderer _itemRenderer;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_GameEventData ---
		void Gameplay_GameEvents_View_Lists_GameEventsListItemViewsHolder__get_GameEventData
		               (int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  int param2_00;
		  
		  param1_00 = *(int *)(param1 + 0x14);
		  param2_00 = *(int *)(param1_00 + 0x28);
		  if (param2 != param2_00) {
		    *(int *)(param1_00 + 0x28) = param2;
		    Gameplay_GameEvents_View_Lists_GameEventItemRenderer__set_Data
		              (param1_00,param2_00,param2,param2);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_GameEventData ---
		void Gameplay_GameEvents_View_Lists_GameEventsListItemViewsHolder__set_GameEventData
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a574b0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponent_GameEventItemRenderer___);
		    DAT_ram_00a574b0 = '\x01';
		  }
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 8),
		                       Method_UnityEngine_Component_GetComponent_GameEventItemRenderer___);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/

}
