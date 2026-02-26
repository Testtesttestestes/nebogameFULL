using System;
using Il2CppDummyDll;
using MVC;

namespace Core.Gameplay.Managers.Ad.Placements.Base.Events
{
	// Token: 0x0200121C RID: 4636
	[Token(Token = "0x200121C")]
	public class AdPlacementEvents : AbstractMVCEvents
	{
		// Token: 0x06006DD2 RID: 28114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DD2")]
		[Address(RVA = "0xB891", Offset = "0xB891", VA = "0xB891")]
		public AdPlacementEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Ad_Placements_Base_Events_AdPlacementEvents___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  if (DAT_ram_00a5a7ad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BankOptionsAdPlacementModel__BankOptionsAdPlacementController__BankOptionsAdPlacementEvents___ctor__
		              );
		    DAT_ram_00a5a7ad = '\x01';
		  }
		  Unity_Services_Core_Internal_DependencyTree___ctor
		            (param1,param2,param3,param4,param5,
		             Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BankOptionsAdPlacementModel__BankOptionsAdPlacementController__BankOptionsAdPlacementEvents___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04003978 RID: 14712
		[Token(Token = "0x4003978")]
		[FieldOffset(Offset = "0x14")]
		public Action AdAvailabilityPossiblyChangedEvent;

		// Token: 0x04003979 RID: 14713
		[Token(Token = "0x4003979")]
		[FieldOffset(Offset = "0x18")]
		public Action AdRewardedEvent;
	}
}
