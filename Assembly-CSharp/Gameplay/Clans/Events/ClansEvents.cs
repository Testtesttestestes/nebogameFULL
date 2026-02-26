using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Events
{
	// Token: 0x02000A8C RID: 2700
	[Token(Token = "0x2000A8C")]
	public class ClansEvents : AbstractMVCEvents
	{
		// Token: 0x060040AC RID: 16556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040AC")]
		[Address(RVA = "0x8F63", Offset = "0x8F63", VA = "0x8F63")]
		public ClansEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Events_ClansEvents___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57745 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_ClansModel__ClansEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClanIsleService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClansService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a57745 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_ClansModel__ClansEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ClansService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ClanIsleService___);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x040023EC RID: 9196
		[Token(Token = "0x40023EC")]
		[FieldOffset(Offset = "0x14")]
		public Action ClanTreasuryChangedEvent;

		// Token: 0x040023ED RID: 9197
		[Token(Token = "0x40023ED")]
		[FieldOffset(Offset = "0x18")]
		public Action UserClanStatusChangedEvent;

		// Token: 0x040023EE RID: 9198
		[Token(Token = "0x40023EE")]
		[FieldOffset(Offset = "0x1C")]
		public Action UserTriggersChangedEvents;
	}
}
