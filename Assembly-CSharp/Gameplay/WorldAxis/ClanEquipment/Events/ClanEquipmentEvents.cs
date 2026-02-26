using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.WorldAxis.ClanEquipment.Events
{
	// Token: 0x02000350 RID: 848
	[Token(Token = "0x2000350")]
	public class ClanEquipmentEvents : AbstractMVCEvents
	{
		// Token: 0x0600135E RID: 4958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600135E")]
		[Address(RVA = "0x654E", Offset = "0x654E", VA = "0x654E")]
		public ClanEquipmentEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_ClanEquipment_Events_ClanEquipmentEvents___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58c43 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ClanEquipmentModel__ClanEquipmentEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ColossusService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a58c43 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_ClanEquipmentModel__ClanEquipmentEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ColossusService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04000A69 RID: 2665
		[Token(Token = "0x4000A69")]
		[FieldOffset(Offset = "0x14")]
		public Action DollArtifactsRequestedEvent;

		// Token: 0x04000A6A RID: 2666
		[Token(Token = "0x4000A6A")]
		[FieldOffset(Offset = "0x18")]
		public Action DataChangedEvent;
	}
}
