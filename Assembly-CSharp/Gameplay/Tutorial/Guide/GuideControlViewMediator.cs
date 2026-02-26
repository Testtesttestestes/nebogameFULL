using System;
using System.Runtime.CompilerServices;
using Gameplay.Tutorial.Guide.Control;
using Gameplay.Tutorial.Guide.Model;
using Gameplay.Tutorial.Guide.View.Control;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Tutorial.Guide
{
	// Token: 0x02000455 RID: 1109
	[Token(Token = "0x2000455")]
	public class GuideControlViewMediator : AbstractViewMediator<GuideModel, GuideEvents, GuideController, GuideControlView>
	{
		// Token: 0x06001A45 RID: 6725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A45")]
		[Address(RVA = "0x6BDC", Offset = "0x6BDC", VA = "0x6BDC")]
		public GuideControlViewMediator(GuideModel model, GuideEvents events, GuideController controller)
		{
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001A46 RID: 6726 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001A47 RID: 6727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049A")]
		public override GuideEvents Events
		{
			[Token(Token = "0x6001A46")]
			[Address(RVA = "0x6BDD", Offset = "0x6BDD", VA = "0x6BDD", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A47")]
			[Address(RVA = "0x6BDE", Offset = "0x6BDE", VA = "0x6BDE", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700049B RID: 1179
		// (set) Token: 0x06001A48 RID: 6728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049B")]
		public override GuideControlView View
		{
			[Token(Token = "0x6001A48")]
			[Address(RVA = "0x6BDF", Offset = "0x6BDF", VA = "0x6BDF", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A49")]
		[Address(RVA = "0x6BE0", Offset = "0x6BE0", VA = "0x6BE0")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Tutorial_Guide_GuideControlViewMediator__SetupView
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Tutorial_Guide_GuideControlViewMediator__HandleGuideToggle(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4A")]
		[Address(RVA = "0x6BE1", Offset = "0x6BE1", VA = "0x6BE1")]
		private void HandleGuideToggle()
		{
		/* --- GHIDRA: HandleGuideToggle ---
		void Gameplay_Tutorial_Guide_GuideControlViewMediator__HandleGuideToggle
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58432 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GuideModel__GuideEvents__GuideController__GuideControlView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Data_User_IUserSettings_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_GuideControlView_GuideControlViewStates__set_CurrentState__
		              );
		    DAT_ram_00a58432 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar3 = *(int **)(param1[2] + 0x2c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80ee9941;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x80ee9941:
		  param2_00 = 1;
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xe0) * 4))
		                    (piVar3,*(undefined4 *)(*piVar3 + 0xe4));
		  if (iVar4 == 0) {
		    param2_00 = 2;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1_00,param2_00,
		             Method_UI_MonoBehaviourWithStates_GuideControlView_GuideControlViewStates__set_CurrentState__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4B")]
		[Address(RVA = "0x6BE2", Offset = "0x6BE2", VA = "0x6BE2")]
		private void ValidateState()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Tutorial_Guide_GuideControlViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58430 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GuideModel__GuideEvents__GuideController__GuideControlView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_GuideControlViewMediator_HandleGuideToggle__);
		    DAT_ram_00a58430 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x24);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Tutorial_Guide_GuideControlViewMediator_HandleGuideToggle__,0);
		    UI_Toggle_GreenToggle__add_ChangedEvent(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Tutorial_Guide_GuideControlViewMediator__set_View(param1,param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x24);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Tutorial_Guide_GuideControlViewMediator_HandleGuideToggle__,0);
		    UI_ToolTip_Controller_Android_ToolTipController__GetPointerPosition(uVar3,uVar1,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Tutorial_Guide_GuideControlViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  int iVar5;
		  uint *puVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a58431 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GuideModel__GuideEvents__GuideController__GuideControlView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_User_IUserSettings_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15266);
		    DAT_ram_00a58431 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar7 = *(undefined4 *)(iVar2 + 0x1c);
		  piVar3 = (int *)Mono_Security_ASN1Convert__ToOid(UI_Tabs_TabBarItemData___TypeInfo,1);
		  iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = func_ii_7508(StringLiteral_15266,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0x10) = uVar4;
		  iVar5 = func_ii_1082(iVar2,*(undefined4 *)(*piVar3 + 0x20));
		  if (iVar5 == 0) {
		    uVar7 = func_ii_1083();
		    func_ii_1050(uVar7,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar3[4] = iVar2;
		  UI_Tabs_TabBar__HandleSelected(uVar7,piVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(iVar2 + 0x1c),0,0,0);
		  Gameplay_Tutorial_Guide_GuideControlViewMediator__HandleGuideToggle(param1,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar7 = *(undefined4 *)(iVar2 + 0x24);
		  piVar3 = *(int **)(param1[2] + 0x2c);
		  iVar2 = *piVar3;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar6 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80ee9846;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar3,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x80ee9846:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar6 * 4))(piVar3,puVar6[1]);
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xe0) * 4))
		                    (piVar3,*(undefined4 *)(*piVar3 + 0xe4));
		  UI_Toggle_GreenToggle__get_IsEnabled(uVar7,uVar4,0);
		  return;
		}
		*/

}
