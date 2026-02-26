using System;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Il2CppDummyDll;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B82 RID: 2946
	[Token(Token = "0x2000B82")]
	public class BossPossibleAssistantViewHolder : BaseItemViewsHolder
	{
		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06004792 RID: 18322 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004793 RID: 18323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E4E")]
		public BossUserListItemView AssistantView
		{
			[Token(Token = "0x6004792")]
			[Address(RVA = "0x9622", Offset = "0x9622", VA = "0x9622")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004793")]
			[Address(RVA = "0x9623", Offset = "0x9623", VA = "0x9623")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004794 RID: 18324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004794")]
		[Address(RVA = "0x9624", Offset = "0x9624", VA = "0x9624", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x06004795 RID: 18325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004795")]
		[Address(RVA = "0x9625", Offset = "0x9625", VA = "0x9625")]
		public BossPossibleAssistantViewHolder()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_AssistantView ---
		void Gameplay_Boss_View_CaptainTab_BossPossibleAssistantViewHolder__set_AssistantView
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57a5f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_BossUserListItemView___)
		    ;
		    DAT_ram_00a57a5f = '\x01';
		  }
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 8),
		                       Method_UnityEngine_Component_GetComponent_BossUserListItemView___);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/

}
