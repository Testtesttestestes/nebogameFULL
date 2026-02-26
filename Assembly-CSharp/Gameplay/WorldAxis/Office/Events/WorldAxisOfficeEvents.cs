using System;
using Gameplay.Clans.Events;
using Gameplay.WorldAxis.Events;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.WorldAxis.Office.Events
{
	// Token: 0x020002DB RID: 731
	[Token(Token = "0x20002DB")]
	public class WorldAxisOfficeEvents : AbstractMVCEvents
	{
		// Token: 0x06001134 RID: 4404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001134")]
		[Address(RVA = "0x6331", Offset = "0x6331", VA = "0x6331")]
		public WorldAxisOfficeEvents(WorldAxisEvents worldAxisEvents, ClansEvents clansEvents)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_Events_WorldAxisOfficeEvents___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58b29 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingsModel__RatingsEvents__RatingsController__ClanRatingsView___ctor__
		              );
		    DAT_ram_00a58b29 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_RatingsModel__RatingsEvents__RatingsController__ClanRatingsView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x040008F4 RID: 2292
		[Token(Token = "0x40008F4")]
		[FieldOffset(Offset = "0x14")]
		public readonly WorldAxisEvents WorldAxisEvents;

		// Token: 0x040008F5 RID: 2293
		[Token(Token = "0x40008F5")]
		[FieldOffset(Offset = "0x18")]
		public readonly ClansEvents ClansEvents;

		// Token: 0x040008F6 RID: 2294
		[Token(Token = "0x40008F6")]
		[FieldOffset(Offset = "0x1C")]
		public Action ScheduleChangedEvent;

		// Token: 0x040008F7 RID: 2295
		[Token(Token = "0x40008F7")]
		[FieldOffset(Offset = "0x20")]
		public Action ColossusRatingRequestedEvent;
	}
}
