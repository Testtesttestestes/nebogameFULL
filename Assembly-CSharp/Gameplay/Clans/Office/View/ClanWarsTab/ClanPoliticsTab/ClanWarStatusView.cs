using System;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Requirements;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.ClanWarsTab.ClanPoliticsTab
{
	// Token: 0x02000A28 RID: 2600
	[Token(Token = "0x2000A28")]
	public class ClanWarStatusView : MonoBehaviourWithStates<ClanWarStatusView.State>
	{
		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06003DAD RID: 15789 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C46")]
		public TextMeshProUGUI StatusText
		{
			[Token(Token = "0x6003DAD")]
			[Address(RVA = "0x8C6C", Offset = "0x8C6C", VA = "0x8C6C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06003DAE RID: 15790 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C47")]
		public BacktimeViewUGUI BacktimeView
		{
			[Token(Token = "0x6003DAE")]
			[Address(RVA = "0x8C6D", Offset = "0x8C6D", VA = "0x8C6D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06003DAF RID: 15791 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C48")]
		public Button AttackButton
		{
			[Token(Token = "0x6003DAF")]
			[Address(RVA = "0x8C6E", Offset = "0x8C6E", VA = "0x8C6E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06003DB0 RID: 15792 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C49")]
		public Button ZigguratButton
		{
			[Token(Token = "0x6003DB0")]
			[Address(RVA = "0x8C6F", Offset = "0x8C6F", VA = "0x8C6F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06003DB1 RID: 15793 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C4A")]
		public Button ActionButton
		{
			[Token(Token = "0x6003DB1")]
			[Address(RVA = "0x8C70", Offset = "0x8C70", VA = "0x8C70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06003DB2 RID: 15794 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C4B")]
		public RequirementsView RequirementsView
		{
			[Token(Token = "0x6003DB2")]
			[Address(RVA = "0x8C71", Offset = "0x8C71", VA = "0x8C71")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003DB3 RID: 15795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DB3")]
		[Address(RVA = "0x8C72", Offset = "0x8C72", VA = "0x8C72")]
		public void SetDefendersAndAttackers(uint defenders, uint attackers)
		{
		/* --- GHIDRA: SetDefendersAndAttackers ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanWarStatusView__SetDefendersAndAttackers
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57f62 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ClanWarStatusView_State___ctor__);
		    DAT_ram_00a57f62 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_ClanWarStatusView_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06003DB4 RID: 15796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DB4")]
		[Address(RVA = "0x8C73", Offset = "0x8C73", VA = "0x8C73")]
		public ClanWarStatusView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanWarStatusView___ctor
		          (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57f63 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingsViewsHolder_TypeInfo);
		    DAT_ram_00a57f63 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingsViewsHolder_TypeInfo);
		  if (DAT_ram_00a57f66 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ItemViewsHolder_UserInRatingListElement___ctor__);
		    DAT_ram_00a57f66 = '\x01';
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x0400227A RID: 8826
		[Token(Token = "0x400227A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _statusText;

		// Token: 0x0400227B RID: 8827
		[Token(Token = "0x400227B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x0400227C RID: 8828
		[Token(Token = "0x400227C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Button _attackButton;

		// Token: 0x0400227D RID: 8829
		[Token(Token = "0x400227D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _zigguratButton;

		// Token: 0x0400227E RID: 8830
		[Token(Token = "0x400227E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _actionButton;

		// Token: 0x0400227F RID: 8831
		[Token(Token = "0x400227F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RequirementsView _requirementsView;

		// Token: 0x04002280 RID: 8832
		[Token(Token = "0x4002280")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _defenders;

		// Token: 0x04002281 RID: 8833
		[Token(Token = "0x4002281")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _attackers;

		// Token: 0x02000A29 RID: 2601
		[Token(Token = "0x2000A29")]
		public enum State
		{
			// Token: 0x04002283 RID: 8835
			[Token(Token = "0x4002283")]
			UNKNOWN_STATE,
			// Token: 0x04002284 RID: 8836
			[Token(Token = "0x4002284")]
			CAN_ATTACK,
			// Token: 0x04002285 RID: 8837
			[Token(Token = "0x4002285")]
			CAN_NOT_ATTACK,
			// Token: 0x04002286 RID: 8838
			[Token(Token = "0x4002286")]
			PREPARATION,
			// Token: 0x04002287 RID: 8839
			[Token(Token = "0x4002287")]
			WAR_IN_PROGRESS,
			// Token: 0x04002288 RID: 8840
			[Token(Token = "0x4002288")]
			ACCELERATION_BLOCKED
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RequirementsView ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanWarStatusView__get_RequirementsView
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  uVar2 = *(undefined4 *)(param1 + 0x34);
		  local_8 = param3;
		  local_4 = param2;
		  uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x38);
		  uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_8,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  return;
		}
		*/

}
