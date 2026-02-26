using System;
using Il2CppDummyDll;
using UI;

namespace Gameplay.Ad.EnergyRegenAd.View
{
	// Token: 0x02000DAC RID: 3500
	[Token(Token = "0x2000DAC")]
	public class EnergyRegenAdViewStateController : MonoBehaviourWithStates<EnergyRegenAdViewStateController.State>
	{
		// Token: 0x0600558C RID: 21900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600558C")]
		[Address(RVA = "0xA32C", Offset = "0xA32C", VA = "0xA32C")]
		public EnergyRegenAdViewStateController()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Ad_EnergyRegenAd_View_EnergyRegenAdViewStateController___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58843 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementEvents__EnergyRegenAdPlacementController__EnergyRegenAdView___ctor__
		              );
		    DAT_ram_00a58843 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementEvents__EnergyRegenAdPlacementController__EnergyRegenAdView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x02000DAD RID: 3501
		[Token(Token = "0x2000DAD")]
		public enum State
		{
			// Token: 0x04002E50 RID: 11856
			[Token(Token = "0x4002E50")]
			UnknownState,
			// Token: 0x04002E51 RID: 11857
			[Token(Token = "0x4002E51")]
			Default,
			// Token: 0x04002E52 RID: 11858
			[Token(Token = "0x4002E52")]
			AdWatched
		}
	}
}
