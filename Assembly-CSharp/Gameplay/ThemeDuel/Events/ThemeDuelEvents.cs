using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.ThemeDuel.Events
{
	// Token: 0x020004EA RID: 1258
	[Token(Token = "0x20004EA")]
	public class ThemeDuelEvents : AbstractMVCEvents
	{
		// Token: 0x06001E06 RID: 7686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E06")]
		[Address(RVA = "0x6F84", Offset = "0x6F84", VA = "0x6F84")]
		public ThemeDuelEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ThemeDuel_Events_ThemeDuelEvents___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a585d9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelModel__ThemeDuelEvents__ThemeDuelController__RulesView___ctor__
		              );
		    DAT_ram_00a585d9 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ThemeDuelModel__ThemeDuelEvents__ThemeDuelController__RulesView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04001060 RID: 4192
		[Token(Token = "0x4001060")]
		[FieldOffset(Offset = "0x14")]
		public Action GetStoreItemsInfoEvent;
	}
}
