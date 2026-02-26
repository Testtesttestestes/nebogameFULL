using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Portals.Events
{
	// Token: 0x020005D8 RID: 1496
	[Token(Token = "0x20005D8")]
	public class PortalsEvents : AbstractMVCEvents
	{
		// Token: 0x06002402 RID: 9218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002402")]
		[Address(RVA = "0x7553", Offset = "0x7553", VA = "0x7553")]
		public PortalsEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_Events_PortalsEvents___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  if (DAT_ram_00a5813a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsEntryPointView___ctor__
		              );
		    DAT_ram_00a5813a = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_PortalsModel__PortalsEvents__PortalsController__PortalsEntryPointView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x18) = param5;
		  return;
		}
		*/

		}

		// Token: 0x040013DE RID: 5086
		[Token(Token = "0x40013DE")]
		[FieldOffset(Offset = "0x14")]
		public Action UserRegisteredEvent;

		// Token: 0x040013DF RID: 5087
		[Token(Token = "0x40013DF")]
		[FieldOffset(Offset = "0x18")]
		public Action CurrentMonsterReceivedEvent;

		// Token: 0x040013E0 RID: 5088
		[Token(Token = "0x40013E0")]
		[FieldOffset(Offset = "0x1C")]
		public Action CurrentMonsterChangedEvent;

		// Token: 0x040013E1 RID: 5089
		[Token(Token = "0x40013E1")]
		[FieldOffset(Offset = "0x20")]
		public Action StageInfoReceivedEvent;

		// Token: 0x040013E2 RID: 5090
		[Token(Token = "0x40013E2")]
		[FieldOffset(Offset = "0x24")]
		public Action StageInfoChangedEvent;

		// Token: 0x040013E3 RID: 5091
		[Token(Token = "0x40013E3")]
		[FieldOffset(Offset = "0x28")]
		public Action UserInfoChangedEvent;

		// Token: 0x040013E4 RID: 5092
		[Token(Token = "0x40013E4")]
		[FieldOffset(Offset = "0x2C")]
		public Action GetStoreItemsEvent;

		// Token: 0x040013E5 RID: 5093
		[Token(Token = "0x40013E5")]
		[FieldOffset(Offset = "0x30")]
		public Action PortalInfoReceivedEvent;

		// Token: 0x040013E6 RID: 5094
		[Token(Token = "0x40013E6")]
		[FieldOffset(Offset = "0x34")]
		public Action PortalRatingReceivedEvent;

		// Token: 0x040013E7 RID: 5095
		[Token(Token = "0x40013E7")]
		[FieldOffset(Offset = "0x38")]
		public Action AttackSuccessEvent;

		// Token: 0x040013E8 RID: 5096
		[Token(Token = "0x40013E8")]
		[FieldOffset(Offset = "0x3C")]
		public Action BetListUpdatedEvent;

		// Token: 0x040013E9 RID: 5097
		[Token(Token = "0x40013E9")]
		[FieldOffset(Offset = "0x40")]
		public Action BetRestrictedEvent;

		// Token: 0x040013EA RID: 5098
		[Token(Token = "0x40013EA")]
		[FieldOffset(Offset = "0x44")]
		public Action BetRegisteredEvent;

		// Token: 0x040013EB RID: 5099
		[Token(Token = "0x40013EB")]
		[FieldOffset(Offset = "0x48")]
		public Action ParticipantsForBetNotAvailEvent;

		// Token: 0x040013EC RID: 5100
		[Token(Token = "0x40013EC")]
		[FieldOffset(Offset = "0x4C")]
		public Action BetsHistoryUpdatedEvent;

		// Token: 0x040013ED RID: 5101
		[Token(Token = "0x40013ED")]
		[FieldOffset(Offset = "0x50")]
		public Action PortalStateChangedEvent;

		// Token: 0x040013EE RID: 5102
		[Token(Token = "0x40013EE")]
		[FieldOffset(Offset = "0x54")]
		public Action BetPoolInfoReceivedEvent;

		// Token: 0x040013EF RID: 5103
		[Token(Token = "0x40013EF")]
		[FieldOffset(Offset = "0x58")]
		public Action JackpotInfoReceivedEvent;
	}
}
