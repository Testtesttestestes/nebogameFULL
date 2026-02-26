using System;
using Gameplay.Boss.Model;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Boss.View.TeamsTab
{
	// Token: 0x02000B54 RID: 2900
	[Token(Token = "0x2000B54")]
	public class BossTeamMemberView : MonoBehaviour
	{
		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x0600462C RID: 17964 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600462D RID: 17965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DD5")]
		public TeamRewardData.TeamMemberData TeamMemberData
		{
			[Token(Token = "0x600462C")]
			[Address(RVA = "0x94C5", Offset = "0x94C5", VA = "0x94C5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600462D")]
			[Address(RVA = "0x94C6", Offset = "0x94C6", VA = "0x94C6")]
			set
			{
			}
		}

		// Token: 0x0600462E RID: 17966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600462E")]
		[Address(RVA = "0x94C7", Offset = "0x94C7", VA = "0x94C7")]
		private void HandleMemberDataChanged(TeamRewardData.TeamMemberData from, TeamRewardData.TeamMemberData to)
		{
		/* --- GHIDRA: HandleMemberDataChanged ---
		void Gameplay_Boss_View_TeamsTab_BossTeamMemberView__HandleMemberDataChanged
		               (int param1,undefined4 param2)
		
		{
		  Gameplay_Rating_View_UserView__get_UserData
		            (*(undefined4 *)(param1 + 0x10),*(undefined4 *)(*(int *)(param1 + 0x14) + 0x14),0);
		  return;
		}
		*/

		}

		// Token: 0x0600462F RID: 17967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600462F")]
		[Address(RVA = "0x94C8", Offset = "0x94C8", VA = "0x94C8")]
		private void TeamMemberDataOnUserDataChangedEvent()
		{
		/* --- GHIDRA: TeamMemberDataOnUserDataChangedEvent ---
		void Gameplay_Boss_View_TeamsTab_BossTeamMemberView__TeamMemberDataOnUserDataChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  
		  param2_00 = *(undefined4 *)(param1 + 0x14);
		  *(undefined4 *)(param1 + 0x14) = 0;
		  Gameplay_Boss_View_TeamsTab_BossTeamMemberView__set_TeamMemberData(param1,param2_00,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004630 RID: 17968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004630")]
		[Address(RVA = "0x94C9", Offset = "0x94C9", VA = "0x94C9")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004631 RID: 17969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004631")]
		[Address(RVA = "0x94CA", Offset = "0x94CA", VA = "0x94CA")]
		public BossTeamMemberView()
		{
		}

		// Token: 0x04002664 RID: 9828
		[Token(Token = "0x4002664")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private UserView _userView;

		// Token: 0x04002665 RID: 9829
		[Token(Token = "0x4002665")]
		[FieldOffset(Offset = "0x14")]
		private TeamRewardData.TeamMemberData _teamMemberData;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_TeamMemberData ---
		void Gameplay_Boss_View_TeamsTab_BossTeamMemberView__get_TeamMemberData
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  
		  param2_00 = *(undefined4 *)(param1 + 0x14);
		  *(undefined4 *)(param1 + 0x14) = param2;
		  Gameplay_Boss_View_TeamsTab_BossTeamMemberView__set_TeamMemberData(param1,param2_00,param2,param1)
		  ;
		  return;
		}
		*/


		/* --- GHIDRA: set_TeamMemberData ---
		void Gameplay_Boss_View_TeamsTab_BossTeamMemberView__set_TeamMemberData
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a579b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_TeamsTab_BossTeamMemberView_TeamMemberDataOnUserDataChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_TryGetComponent_ToolTip___);
		    DAT_ram_00a579b5 = '\x01';
		  }
		  local_4 = 0;
		  if (param2 != 0) {
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Boss_View_TeamsTab_BossTeamMemberView_TeamMemberDataOnUserDataChangedEvent__
		               ,0);
		    Gameplay_Boss_Model_TeamRewardData_TeamMemberData__add_UserDataChangedEvent(param2,uVar1,0);
		  }
		  uVar1 = 0;
		  if (param3 != 0) {
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Boss_View_TeamsTab_BossTeamMemberView_TeamMemberDataOnUserDataChangedEvent__
		               ,0);
		    Gameplay_Boss_Model_TeamRewardData_TeamMemberData__set_UserId(param3,uVar1,0);
		    uVar1 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0x14);
		  }
		  Gameplay_Rating_View_UserView__get_UserData(*(undefined4 *)(param1 + 0x10),uVar1,0);
		  iVar2 = UnityEngine_UIElements_GroupBoxUtility__UnregisterGroupBoxOption_object_
		                    (*(undefined4 *)(param1 + 0x10),&local_4,
		                     Method_UnityEngine_Component_TryGetComponent_ToolTip___);
		  if (iVar2 != 0) {
		    UI_ToolTip_ToolTip__get_enabled(local_4,(uint)(param3 != 0),0);
		  }
		  return;
		}
		*/

}
