using System;
using Gameplay.Boss.Controller;
using Il2CppDummyDll;
using UI.Wiki;
using UnityEngine;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B7A RID: 2938
	[Token(Token = "0x2000B7A")]
	public class BossCaptainView : AbstractBossWindowView<BossCaptainView, BossCaptainViewMediator>
	{
		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x0600475B RID: 18267 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E39")]
		public WikiUriRouter Wiki
		{
			[Token(Token = "0x600475B")]
			[Address(RVA = "0x95EF", Offset = "0x95EF", VA = "0x95EF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x0600475C RID: 18268 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E3A")]
		public BossInfoView BossInfoView
		{
			[Token(Token = "0x600475C")]
			[Address(RVA = "0x95F0", Offset = "0x95F0", VA = "0x95F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x0600475D RID: 18269 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E3B")]
		public BossTeamEditView TeamEditView
		{
			[Token(Token = "0x600475D")]
			[Address(RVA = "0x95F1", Offset = "0x95F1", VA = "0x95F1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x0600475E RID: 18270 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E3C")]
		public BossCaptainViewStateController StateController
		{
			[Token(Token = "0x600475E")]
			[Address(RVA = "0x95F2", Offset = "0x95F2", VA = "0x95F2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x0600475F RID: 18271 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E3D")]
		public BossTeamView TeamView
		{
			[Token(Token = "0x600475F")]
			[Address(RVA = "0x95F3", Offset = "0x95F3", VA = "0x95F3")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004760 RID: 18272 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004760")]
		[Address(RVA = "0x95F4", Offset = "0x95F4", VA = "0x95F4", Slot = "5")]
		protected override BossCaptainViewMediator CreateMediator()
		{
		/* --- GHIDRA: CreateMediator ---
		void Gameplay_Boss_View_CaptainTab_BossCaptainView__CreateMediator
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57a44 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_AbstractBossWindowView_BossCaptainView__BossCaptainViewMediator___ctor__
		              );
		    DAT_ram_00a57a44 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_Gameplay_Boss_View_AbstractBossWindowView_BossCaptainView__BossCaptainViewMediator___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004761 RID: 18273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004761")]
		[Address(RVA = "0x95F5", Offset = "0x95F5", VA = "0x95F5")]
		public BossCaptainView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_View_CaptainTab_BossCaptainView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57a45 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_BossCaptainViewStateController_BossCaptainViewState___ctor__
		              );
		    DAT_ram_00a57a45 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_UI_MonoBehaviourWithStates_BossCaptainViewStateController_BossCaptainViewState___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04002728 RID: 10024
		[Token(Token = "0x4002728")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private BossTeamView _teamView;

		// Token: 0x04002729 RID: 10025
		[Token(Token = "0x4002729")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BossCaptainViewStateController _stateController;

		// Token: 0x0400272A RID: 10026
		[Token(Token = "0x400272A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private BossTeamEditView _teamEditView;

		// Token: 0x0400272B RID: 10027
		[Token(Token = "0x400272B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BossInfoView _bossInfoView;

		// Token: 0x0400272C RID: 10028
		[Token(Token = "0x400272C")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private WikiUriRouter _wiki;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_TeamView ---
		undefined4 Gameplay_Boss_View_CaptainTab_BossCaptainView__get_TeamView(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param4;
		  undefined4 param3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57a43 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossCaptainViewMediator_TypeInfo);
		    DAT_ram_00a57a43 = '\x01';
		  }
		  param4 = *(undefined4 *)(param1 + 0x1c);
		  param3 = *(undefined4 *)(param1 + 0x18);
		  param2_00 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(Gameplay_Boss_Controller_BossCaptainViewMediator_TypeInfo);
		  Gameplay_Boss_Controller_BossCaptainViewMediator__Dispose(param1_00,param2_00,param3,param4,0);
		  return param1_00;
		}
		*/

}
