using System;
using Il2CppDummyDll;
using MVC;
using Protocol.Main;

namespace Gameplay.WorldAxis.Events
{
	// Token: 0x020002C9 RID: 713
	[Token(Token = "0x20002C9")]
	public class WorldAxisEvents : AbstractMVCEvents
	{
		// Token: 0x060010CE RID: 4302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010CE")]
		[Address(RVA = "0x62CB", Offset = "0x62CB", VA = "0x62CB")]
		public WorldAxisEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Events_WorldAxisEvents___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58af7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_WorldAxisModel__WorldAxisEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ColossusService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a58af7 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_WorldAxisModel__WorldAxisEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ColossusService___);
		  *(undefined4 *)(param1 + 0x1c) = param4;
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x040008AE RID: 2222
		[Token(Token = "0x40008AE")]
		[FieldOffset(Offset = "0x14")]
		public Action ScheduleChangedEvent;

		// Token: 0x040008AF RID: 2223
		[Token(Token = "0x40008AF")]
		[FieldOffset(Offset = "0x18")]
		public Action PartyChangedEvent;

		// Token: 0x040008B0 RID: 2224
		[Token(Token = "0x40008B0")]
		[FieldOffset(Offset = "0x1C")]
		public Action<ProtoStackableChangesAns> DollItemsChangedEvent;
	}
}
