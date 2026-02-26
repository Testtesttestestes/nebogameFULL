using System;
using Core.Data;
using Il2CppDummyDll;
using UI.Rewards;
using UnityEngine;

namespace UI.Elements.RightPanel.TitledList.Elements
{
	// Token: 0x0200020C RID: 524
	[Token(Token = "0x200020C")]
	public class RewardsTitledListElement : BaseTitledListElement<RewardsTitledListElementArgs>
	{
		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D45 RID: 3397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BD")]
		public RewardData[] Rewards
		{
			[Token(Token = "0x6000D44")]
			[Address(RVA = "0x6027", Offset = "0x6027", VA = "0x6027")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D45")]
			[Address(RVA = "0x6028", Offset = "0x6028", VA = "0x6028")]
			set
			{
			}
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D46")]
		[Address(RVA = "0x6029", Offset = "0x6029", VA = "0x6029", Slot = "6")]
		protected override void OnInit(RewardsTitledListElementArgs args)
		{
		/* --- GHIDRA: OnInit ---
		void UI_Elements_RightPanel_TitledList_Elements_RewardsTitledListElement__OnInit
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63966 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_RightPanel_TitledList_BaseTitledListElement_RewardsTitledListElementArgs___ctor__
		              );
		    DAT_ram_00a63966 = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,
		             Method_UI_Elements_RightPanel_TitledList_BaseTitledListElement_RewardsTitledListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D47")]
		[Address(RVA = "0x602A", Offset = "0x602A", VA = "0x602A")]
		public RewardsTitledListElement()
		{
		}

		// Token: 0x0400068F RID: 1679
		[Token(Token = "0x400068F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private AbstractRewardsRender _rewardsRender;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Rewards ---
		void UI_Elements_RightPanel_TitledList_Elements_RewardsTitledListElement__get_Rewards
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  UI_Rewards_AbstractRewardsRender__get_Rewards(*(undefined4 *)(param1 + 0x10),param2,0);
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xf0) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar1 + 0xf4));
		  return;
		}
		*/

}
