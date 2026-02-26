using System;
using Gameplay.UserInterface.Menu.ExternalLinks.Model;
using Gameplay.UserInterface.Menu.ExternalLinks.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.UserInterface.Menu.ExternalLinks.Control
{
	// Token: 0x020003E6 RID: 998
	[Token(Token = "0x20003E6")]
	public class ExternalLinksController : AbstractController<ExternalLinksModel, ExternalLinksEvents>
	{
		// Token: 0x0600174F RID: 5967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600174F")]
		[Address(RVA = "0x690C", Offset = "0x690C", VA = "0x690C")]
		public ExternalLinksController(ExternalLinksModel model, ExternalLinksEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInterface_Menu_ExternalLinks_Control_ExternalLinksController___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a5989c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ExternalLinksModel__ExternalLinksEvents__ExternalLinksController__ExternalLinksView___ctor__
		              );
		    DAT_ram_00a5989c = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ExternalLinksModel__ExternalLinksEvents__ExternalLinksController__ExternalLinksView___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
