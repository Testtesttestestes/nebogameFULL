using System;
using System.Runtime.CompilerServices;
using Gameplay.Boss.Controller;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B83 RID: 2947
	[Token(Token = "0x2000B83")]
	public class BossTeamEditView : AbstractBossWindowView<BossTeamEditView, BossTeamEditViewMediator>
	{
		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06004796 RID: 18326 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E4F")]
		public UserDataSortControlView SortControl
		{
			[Token(Token = "0x6004796")]
			[Address(RVA = "0x9626", Offset = "0x9626", VA = "0x9626")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06004797 RID: 18327 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E50")]
		public BossTeamEditListAdapter ListAdapter
		{
			[Token(Token = "0x6004797")]
			[Address(RVA = "0x9627", Offset = "0x9627", VA = "0x9627")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06004798 RID: 18328 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E51")]
		public Button ConfirmButton
		{
			[Token(Token = "0x6004798")]
			[Address(RVA = "0x9628", Offset = "0x9628", VA = "0x9628")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06004799 RID: 18329 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E52")]
		public Button CancelButton
		{
			[Token(Token = "0x6004799")]
			[Address(RVA = "0x9629", Offset = "0x9629", VA = "0x9629")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x0600479A RID: 18330 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E53")]
		public BossTeamView TeamView
		{
			[Token(Token = "0x600479A")]
			[Address(RVA = "0x962A", Offset = "0x962A", VA = "0x962A")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001C5 RID: 453
		// (add) Token: 0x0600479B RID: 18331 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600479C RID: 18332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001C5")]
		public event Action ExitEditModeEvent
		{
			[Token(Token = "0x600479B")]
			[Address(RVA = "0x1B4A", Offset = "0x1B4A", VA = "0x1B4A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600479C")]
			[Address(RVA = "0x962B", Offset = "0x962B", VA = "0x962B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600479D RID: 18333 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600479D")]
		[Address(RVA = "0x962C", Offset = "0x962C", VA = "0x962C", Slot = "5")]
		protected override BossTeamEditViewMediator CreateMediator()
		{
			return null;
		}

		// Token: 0x0600479E RID: 18334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600479E")]
		[Address(RVA = "0x962D", Offset = "0x962D", VA = "0x962D")]
		public void ExitEditMode()
		{
		/* --- GHIDRA: ExitEditMode ---
		void Gameplay_Boss_View_CaptainTab_BossTeamEditView__ExitEditMode
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57a63 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_AbstractBossWindowView_BossTeamEditView__BossTeamEditViewMediator___ctor__
		              );
		    DAT_ram_00a57a63 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_Gameplay_Boss_View_AbstractBossWindowView_BossTeamEditView__BossTeamEditViewMediator___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600479F RID: 18335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600479F")]
		[Address(RVA = "0x962E", Offset = "0x962E", VA = "0x962E")]
		public BossTeamEditView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_View_CaptainTab_BossTeamEditView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57a65 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamData_TeamAssistantData__TypeInfo);
		    DAT_ram_00a57a65 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x38);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_TeamData_TeamAssistantData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_TeamData_TeamAssistantData__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x38,iVar2,param1_00);
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

		// Token: 0x04002750 RID: 10064
		[Token(Token = "0x4002750")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private BossTeamView _teamView;

		// Token: 0x04002751 RID: 10065
		[Token(Token = "0x4002751")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _confirmButton;

		// Token: 0x04002752 RID: 10066
		[Token(Token = "0x4002752")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private BossTeamEditListAdapter _listAdapter;

		// Token: 0x04002753 RID: 10067
		[Token(Token = "0x4002753")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UserDataSortControlView _sortControl;

		// Token: 0x04002754 RID: 10068
		[Token(Token = "0x4002754")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Button _cancelButton;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_TeamView ---
		void Gameplay_Boss_View_CaptainTab_BossTeamEditView__get_TeamView
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57a61 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57a61 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x38);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x38,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_ExitEditModeEvent ---
		void Gameplay_Boss_View_CaptainTab_BossTeamEditView__add_ExitEditModeEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57a64 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamData_TeamAssistantData__TypeInfo);
		    DAT_ram_00a57a64 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x38);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_TeamData_TeamAssistantData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_TeamData_TeamAssistantData__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x38,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ExitEditModeEvent ---
		undefined4
		Gameplay_Boss_View_CaptainTab_BossTeamEditView__remove_ExitEditModeEvent
		          (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param4;
		  undefined4 param3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57a62 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossTeamEditViewMediator_TypeInfo);
		    DAT_ram_00a57a62 = '\x01';
		  }
		  param4 = *(undefined4 *)(param1 + 0x1c);
		  param3 = *(undefined4 *)(param1 + 0x18);
		  param2_00 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(Gameplay_Boss_Controller_BossTeamEditViewMediator_TypeInfo);
		  Gameplay_Boss_Controller_BossRolesViewMediator__ViewOnSelectedEvent
		            (param1_00,param2_00,param3,param4,0);
		  return param1_00;
		}
		*/

}
