using System;
using Core.Gameplay.Managers.Ad.Placements.EnergyRegen;
using Gameplay.Ad.EnergyRegenAd.Controller;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Ad.EnergyRegenAd.View
{
	// Token: 0x02000DAB RID: 3499
	[Token(Token = "0x2000DAB")]
	public class EnergyRegenAdView : MonoBehaviour
	{
		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x06005586 RID: 21894 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700115D")]
		public EnergyRegenAdViewStateController StateController
		{
			[Token(Token = "0x6005586")]
			[Address(RVA = "0xA326", Offset = "0xA326", VA = "0xA326")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x06005587 RID: 21895 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700115E")]
		public Button WatchButton
		{
			[Token(Token = "0x6005587")]
			[Address(RVA = "0xA327", Offset = "0xA327", VA = "0xA327")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x06005588 RID: 21896 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700115F")]
		public TextMeshProUGUI MessageTextField
		{
			[Token(Token = "0x6005588")]
			[Address(RVA = "0xA328", Offset = "0xA328", VA = "0xA328")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005589 RID: 21897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005589")]
		[Address(RVA = "0xA329", Offset = "0xA329", VA = "0xA329")]
		public void Init(EnergyRegenAdPlacementManager manager)
		{
		}

		// Token: 0x0600558A RID: 21898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600558A")]
		[Address(RVA = "0xA32A", Offset = "0xA32A", VA = "0xA32A")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600558B RID: 21899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600558B")]
		[Address(RVA = "0xA32B", Offset = "0xA32B", VA = "0xA32B")]
		public EnergyRegenAdView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Ad_EnergyRegenAd_View_EnergyRegenAdView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58842 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_EnergyRegenAdViewStateController_State___ctor__);
		    DAT_ram_00a58842 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_UI_MonoBehaviourWithStates_EnergyRegenAdViewStateController_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x04002E4B RID: 11851
		[Token(Token = "0x4002E4B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _watchButton;

		// Token: 0x04002E4C RID: 11852
		[Token(Token = "0x4002E4C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _messageTextField;

		// Token: 0x04002E4D RID: 11853
		[Token(Token = "0x4002E4D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private EnergyRegenAdViewStateController _stateController;

		// Token: 0x04002E4E RID: 11854
		[Token(Token = "0x4002E4E")]
		[FieldOffset(Offset = "0x1C")]
		private EnergyRegenAdViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_MessageTextField ---
		void Gameplay_Ad_EnergyRegenAd_View_EnergyRegenAdView__get_MessageTextField
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  undefined4 param4;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58841 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementController__EnergyRegenAdPlacementEvents__get_Controller__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementController__EnergyRegenAdPlacementEvents__get_Events__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementController__EnergyRegenAdPlacementEvents__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Ad_EnergyRegenAd_Controller_EnergyRegenAdViewMediator_TypeInfo);
		    DAT_ram_00a58841 = '\x01';
		  }
		  param4 = *(undefined4 *)(param2 + 0x18);
		  param3_00 = *(undefined4 *)(param2 + 0x20);
		  param2_00 = *(undefined4 *)(param2 + 0x1c);
		  param1_00 = (int *)unnamed_function_1417
		                               (
		                               Gameplay_Ad_EnergyRegenAd_Controller_EnergyRegenAdViewMediator_TypeInfo
		                               );
		  if (DAT_ram_00a58843 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementEvents__EnergyRegenAdPlacementController__EnergyRegenAdView___ctor__
		              );
		    DAT_ram_00a58843 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1_00,param2_00,param3_00,param4,
		             Method_MVC_AbstractViewMediator_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementEvents__EnergyRegenAdPlacementController__EnergyRegenAdView___ctor__
		            );
		  *(int **)(param1 + 0x1c) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  return;
		}
		*/

}
