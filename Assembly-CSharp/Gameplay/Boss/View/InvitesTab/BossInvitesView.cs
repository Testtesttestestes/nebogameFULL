using System;
using Gameplay.Boss.Controller;
using Gameplay.Boss.View.CaptainTab;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Boss.View.InvitesTab
{
	// Token: 0x02000B71 RID: 2929
	[Token(Token = "0x2000B71")]
	public class BossInvitesView : AbstractBossWindowView<BossInvitesView, BossAssistantViewMediator>
	{
		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06004723 RID: 18211 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E28")]
		public BossInvitesSortControlView SortControl
		{
			[Token(Token = "0x6004723")]
			[Address(RVA = "0x95B9", Offset = "0x95B9", VA = "0x95B9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06004724 RID: 18212 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E29")]
		public TextMeshProUGUI LicenceInfoLabel
		{
			[Token(Token = "0x6004724")]
			[Address(RVA = "0x95BA", Offset = "0x95BA", VA = "0x95BA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06004725 RID: 18213 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E2A")]
		public TextMeshProUGUI LicenceInfoLabel2
		{
			[Token(Token = "0x6004725")]
			[Address(RVA = "0x95BB", Offset = "0x95BB", VA = "0x95BB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06004726 RID: 18214 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E2B")]
		public Button BuyLicenceButton
		{
			[Token(Token = "0x6004726")]
			[Address(RVA = "0x95BC", Offset = "0x95BC", VA = "0x95BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06004727 RID: 18215 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E2C")]
		public Button BuyLicenceButton2
		{
			[Token(Token = "0x6004727")]
			[Address(RVA = "0x95BD", Offset = "0x95BD", VA = "0x95BD")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06004728 RID: 18216 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E2D")]
		public Button AcceptButton
		{
			[Token(Token = "0x6004728")]
			[Address(RVA = "0x95BE", Offset = "0x95BE", VA = "0x95BE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06004729 RID: 18217 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E2E")]
		public Button RefuseButton
		{
			[Token(Token = "0x6004729")]
			[Address(RVA = "0x95BF", Offset = "0x95BF", VA = "0x95BF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x0600472A RID: 18218 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E2F")]
		public BossPossibleEmptyWindowStateController StateController
		{
			[Token(Token = "0x600472A")]
			[Address(RVA = "0x95C0", Offset = "0x95C0", VA = "0x95C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x0600472B RID: 18219 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E30")]
		public BossTeamView BossTeamView
		{
			[Token(Token = "0x600472B")]
			[Address(RVA = "0x95C1", Offset = "0x95C1", VA = "0x95C1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x0600472C RID: 18220 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E31")]
		public BossInvitesListAdapter ListAdapter
		{
			[Token(Token = "0x600472C")]
			[Address(RVA = "0x95C2", Offset = "0x95C2", VA = "0x95C2")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600472D RID: 18221 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600472D")]
		[Address(RVA = "0x95C3", Offset = "0x95C3", VA = "0x95C3", Slot = "5")]
		protected override BossAssistantViewMediator CreateMediator()
		{
		/* --- GHIDRA: CreateMediator ---
		void Gameplay_Boss_View_InvitesTab_BossInvitesView__CreateMediator
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57a24 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_AbstractBossWindowView_BossInvitesView__BossAssistantViewMediator___ctor__
		              );
		    DAT_ram_00a57a24 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_Gameplay_Boss_View_AbstractBossWindowView_BossInvitesView__BossAssistantViewMediator___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600472E RID: 18222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600472E")]
		[Address(RVA = "0x95C4", Offset = "0x95C4", VA = "0x95C4")]
		public BossInvitesView()
		{
		}

		// Token: 0x04002700 RID: 9984
		[Token(Token = "0x4002700")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private BossInvitesListAdapter _listAdapter;

		// Token: 0x04002701 RID: 9985
		[Token(Token = "0x4002701")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BossTeamView _bossTeamView;

		// Token: 0x04002702 RID: 9986
		[Token(Token = "0x4002702")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private BossPossibleEmptyWindowStateController _stateController;

		// Token: 0x04002703 RID: 9987
		[Token(Token = "0x4002703")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _licenceInfoLabel;

		// Token: 0x04002704 RID: 9988
		[Token(Token = "0x4002704")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _licenceInfoLabel2;

		// Token: 0x04002705 RID: 9989
		[Token(Token = "0x4002705")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BossInvitesSortControlView _sortControl;

		// Token: 0x04002706 RID: 9990
		[Token(Token = "0x4002706")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Button _buyLicenceButton;

		// Token: 0x04002707 RID: 9991
		[Token(Token = "0x4002707")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _buyLicenceButton2;

		// Token: 0x04002708 RID: 9992
		[Token(Token = "0x4002708")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Button _acceptButton;

		// Token: 0x04002709 RID: 9993
		[Token(Token = "0x4002709")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _refuseButton;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ListAdapter ---
		undefined4
		Gameplay_Boss_View_InvitesTab_BossInvitesView__get_ListAdapter(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param4;
		  undefined4 param3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57a23 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossAssistantViewMediator_TypeInfo);
		    DAT_ram_00a57a23 = '\x01';
		  }
		  param4 = *(undefined4 *)(param1 + 0x1c);
		  param3 = *(undefined4 *)(param1 + 0x18);
		  param2_00 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(Gameplay_Boss_Controller_BossAssistantViewMediator_TypeInfo);
		  Gameplay_Boss_Controller_BossInstanceController___c__DisplayClass39_0___PrepareTeam_g__GetTeamAndPlaceHandler_1
		            (param1_00,param2_00,param3,param4,0);
		  return param1_00;
		}
		*/

}
