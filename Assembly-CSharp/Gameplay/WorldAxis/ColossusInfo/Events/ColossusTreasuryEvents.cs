using System;
using Gameplay.Clans.Buildings.Golem.Events;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;

namespace Gameplay.WorldAxis.ColossusInfo.Events
{
	// Token: 0x0200032D RID: 813
	[Token(Token = "0x200032D")]
	public class ColossusTreasuryEvents : AbstractMVCEvents
	{
		// Token: 0x060012A7 RID: 4775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012A7")]
		[Address(RVA = "0x64A1", Offset = "0x64A1", VA = "0x64A1")]
		public ColossusTreasuryEvents(GolemInventoryEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_ColossusInfo_Events_ColossusTreasuryEvents___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58be3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusTreasuryModel__ColossusTreasuryEvents__ColossusTreasuryController__ColossusTreasuryView___ctor__
		              );
		    DAT_ram_00a58be3 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ColossusTreasuryModel__ColossusTreasuryEvents__ColossusTreasuryController__ColossusTreasuryView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04000A18 RID: 2584
		[Token(Token = "0x4000A18")]
		[FieldOffset(Offset = "0x14")]
		public readonly GolemInventoryEvents GolemInventoryEvents;

		// Token: 0x04000A19 RID: 2585
		[Token(Token = "0x4000A19")]
		[FieldOffset(Offset = "0x18")]
		public Action TreasuryOptionsRequestedEvent;

		// Token: 0x04000A1A RID: 2586
		[Token(Token = "0x4000A1A")]
		[FieldOffset(Offset = "0x1C")]
		public Action<ResourceSet, ResourceSet> ClanBalanceChangedEvent;
	}
}
