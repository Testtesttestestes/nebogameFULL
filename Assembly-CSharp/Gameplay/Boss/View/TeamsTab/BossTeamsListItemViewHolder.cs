using System;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Il2CppDummyDll;

namespace Gameplay.Boss.View.TeamsTab
{
	// Token: 0x02000B56 RID: 2902
	[Token(Token = "0x2000B56")]
	public class BossTeamsListItemViewHolder : BaseItemViewsHolder
	{
		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x0600463D RID: 17981 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600463E RID: 17982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DD7")]
		public BossTeamsListItemView Renderer
		{
			[Token(Token = "0x600463D")]
			[Address(RVA = "0x94D6", Offset = "0x94D6", VA = "0x94D6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600463E")]
			[Address(RVA = "0x94D7", Offset = "0x94D7", VA = "0x94D7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600463F RID: 17983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600463F")]
		[Address(RVA = "0x94D8", Offset = "0x94D8", VA = "0x94D8", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x06004640 RID: 17984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004640")]
		[Address(RVA = "0x94D9", Offset = "0x94D9", VA = "0x94D9")]
		public BossTeamsListItemViewHolder()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_View_TeamsTab_BossTeamsListItemViewHolder___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579bf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamRewardData__TypeInfo);
		    DAT_ram_00a579bf = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_TeamRewardData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_TeamRewardData__TypeInfo), iVar2 == 0)) break;
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

		/* --- GHIDRA: set_Renderer ---
		void Gameplay_Boss_View_TeamsTab_BossTeamsListItemViewHolder__set_Renderer
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a579be == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponent_BossTeamsListItemView___);
		    DAT_ram_00a579be = '\x01';
		  }
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 8),
		                       Method_UnityEngine_Component_GetComponent_BossTeamsListItemView___);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/

}
