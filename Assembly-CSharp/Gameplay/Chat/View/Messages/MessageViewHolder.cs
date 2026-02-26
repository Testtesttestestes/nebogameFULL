using System;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Il2CppDummyDll;

namespace Gameplay.Chat.View.Messages
{
	// Token: 0x02000AFE RID: 2814
	[Token(Token = "0x2000AFE")]
	public class MessageViewHolder : BaseItemViewsHolder
	{
		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x060043F4 RID: 17396 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060043F5 RID: 17397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D61")]
		public MessageItemRenderer ItemRenderer
		{
			[Token(Token = "0x60043F4")]
			[Address(RVA = "0x92A7", Offset = "0x92A7", VA = "0x92A7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60043F5")]
			[Address(RVA = "0x92A8", Offset = "0x92A8", VA = "0x92A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060043F6 RID: 17398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043F6")]
		[Address(RVA = "0x92A9", Offset = "0x92A9", VA = "0x92A9", Slot = "7")]
		public override void CollectViews()
		{
		/* --- GHIDRA: CollectViews ---
		void Gameplay_Chat_View_Messages_MessageViewHolder__CollectViews(int param1,undefined4 param2)
		
		{
		  UnityEngine_Object__op_Implicit(*(undefined4 *)(*(int *)(param1 + 0x14) + 0x18),1,0);
		  Com_TheFallenGames_OSA_Core_AbstractViewsHolder__CollectViews(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060043F7 RID: 17399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043F7")]
		[Address(RVA = "0x92AA", Offset = "0x92AA", VA = "0x92AA", Slot = "8")]
		public override void MarkForRebuild()
		{
		/* --- GHIDRA: MarkForRebuild ---
		void Gameplay_Chat_View_Messages_MessageViewHolder__MarkForRebuild(int param1,undefined4 param2)
		
		{
		  UnityEngine_Object__op_Implicit(*(undefined4 *)(*(int *)(param1 + 0x14) + 0x18),0,0);
		  return;
		}
		*/

		}

		// Token: 0x060043F8 RID: 17400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043F8")]
		[Address(RVA = "0x92AB", Offset = "0x92AB", VA = "0x92AB", Slot = "9")]
		public override void UnmarkForRebuild()
		{
		}

		// Token: 0x060043F9 RID: 17401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043F9")]
		[Address(RVA = "0x92AC", Offset = "0x92AC", VA = "0x92AC")]
		public MessageViewHolder()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Chat_View_Messages_MessageViewHolder___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57b24 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_ChatBanArticleData__TypeInfo);
		    DAT_ram_00a57b24 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_EventHandler_ChatBanArticleData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_EventHandler_ChatBanArticleData__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_ItemRenderer ---
		void Gameplay_Chat_View_Messages_MessageViewHolder__set_ItemRenderer(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57b23 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_MessageItemRenderer___);
		    DAT_ram_00a57b23 = '\x01';
		  }
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 8),
		                       Method_UnityEngine_Component_GetComponent_MessageItemRenderer___);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/

}
