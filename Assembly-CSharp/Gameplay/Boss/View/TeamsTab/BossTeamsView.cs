using System;
using Gameplay.Boss.Controller;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Boss.View.TeamsTab
{
	// Token: 0x02000B58 RID: 2904
	[Token(Token = "0x2000B58")]
	public class BossTeamsView : AbstractBossWindowView<BossTeamsView, BossTeamsViewMediator>
	{
		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x06004649 RID: 17993 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DD9")]
		public BossPossibleEmptyWindowStateController StateController
		{
			[Token(Token = "0x6004649")]
			[Address(RVA = "0x94E2", Offset = "0x94E2", VA = "0x94E2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x0600464A RID: 17994 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DDA")]
		public BossTeamsListAdapter ListAdapter
		{
			[Token(Token = "0x600464A")]
			[Address(RVA = "0x94E3", Offset = "0x94E3", VA = "0x94E3")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600464B")]
		[Address(RVA = "0x94E4", Offset = "0x94E4", VA = "0x94E4", Slot = "5")]
		protected override BossTeamsViewMediator CreateMediator()
		{
		/* --- GHIDRA: CreateMediator ---
		void Gameplay_Boss_View_TeamsTab_BossTeamsView__CreateMediator(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a579c5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_AbstractBossWindowView_BossTeamsView__BossTeamsViewMediator___ctor__
		              );
		    DAT_ram_00a579c5 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_Gameplay_Boss_View_AbstractBossWindowView_BossTeamsView__BossTeamsViewMediator___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600464C RID: 17996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600464C")]
		[Address(RVA = "0x94E5", Offset = "0x94E5", VA = "0x94E5")]
		public BossTeamsView()
		{
		}

		// Token: 0x0400266F RID: 9839
		[Token(Token = "0x400266F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private BossTeamsListAdapter _listAdapter;

		// Token: 0x04002670 RID: 9840
		[Token(Token = "0x4002670")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BossPossibleEmptyWindowStateController _stateController;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ListAdapter ---
		undefined4 Gameplay_Boss_View_TeamsTab_BossTeamsView__get_ListAdapter(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param4;
		  undefined4 param3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a579c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossTeamsViewMediator_TypeInfo);
		    DAT_ram_00a579c4 = '\x01';
		  }
		  param4 = *(undefined4 *)(param1 + 0x1c);
		  param3 = *(undefined4 *)(param1 + 0x18);
		  param2_00 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(Gameplay_Boss_Controller_BossTeamsViewMediator_TypeInfo);
		  Gameplay_Boss_Controller_BossTeamEditViewMediator___c__DisplayClass17_0___RemoveFromTeam_b__0
		            (param1_00,param2_00,param3,param4,0);
		  return param1_00;
		}
		*/

}
