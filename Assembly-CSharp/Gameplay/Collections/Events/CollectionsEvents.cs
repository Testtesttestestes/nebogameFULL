using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Collections.Events
{
	// Token: 0x020009E5 RID: 2533
	[Token(Token = "0x20009E5")]
	public class CollectionsEvents : AbstractMVCEvents
	{
		// Token: 0x06003C7C RID: 15484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C7C")]
		[Address(RVA = "0x8B43", Offset = "0x8B43", VA = "0x8B43")]
		public CollectionsEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Collections_Events_CollectionsEvents___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  if (DAT_ram_00a57ed0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionInfoWindow___ctor__
		              );
		    DAT_ram_00a57ed0 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionInfoWindow___ctor__
		            );
		  *(undefined4 *)(param1 + 0x1c) = param5;
		  *(undefined4 *)(param1 + 0x20) = param6;
		  return;
		}
		*/

		}

		// Token: 0x04002176 RID: 8566
		[Token(Token = "0x4002176")]
		[FieldOffset(Offset = "0x14")]
		public Action UserCollectionImprovedEvent;

		// Token: 0x04002177 RID: 8567
		[Token(Token = "0x4002177")]
		[FieldOffset(Offset = "0x18")]
		public Action DependenciesChangedEvent;
	}
}
