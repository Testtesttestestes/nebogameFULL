using System;
using Com.TheFallenGames.OSA.Core;
using Il2CppDummyDll;

namespace Gameplay.Chat.View
{
	// Token: 0x02000AEA RID: 2794
	[Token(Token = "0x2000AEA")]
	public class ChatVisitorViewsHolder : BaseItemViewsHolder
	{
		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x0600435B RID: 17243 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D45")]
		public VisitorItemRenderer ItemRenderer
		{
			[Token(Token = "0x600435B")]
			[Address(RVA = "0x920F", Offset = "0x920F", VA = "0x920F")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600435C RID: 17244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600435C")]
		[Address(RVA = "0x9210", Offset = "0x9210", VA = "0x9210", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x0600435D RID: 17245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600435D")]
		[Address(RVA = "0x9211", Offset = "0x9211", VA = "0x9211")]
		public ChatVisitorViewsHolder()
		{
		}

		// Token: 0x0400251C RID: 9500
		[Token(Token = "0x400251C")]
		[FieldOffset(Offset = "0x14")]
		private VisitorItemRenderer _itemRenderer;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ItemRenderer ---
		void Gameplay_Chat_View_ChatVisitorViewsHolder__get_ItemRenderer(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57adb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_VisitorItemRenderer___);
		    DAT_ram_00a57adb = '\x01';
		  }
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 8),
		                       Method_UnityEngine_Component_GetComponent_VisitorItemRenderer___);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/

}
