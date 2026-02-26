using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.ClanWars.Events
{
	// Token: 0x02000AA7 RID: 2727
	[Token(Token = "0x2000AA7")]
	public class ClanWarsEvents : AbstractMVCEvents
	{
		// Token: 0x060041C2 RID: 16834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C2")]
		[Address(RVA = "0x9076", Offset = "0x9076", VA = "0x9076")]
		public ClanWarsEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_ClanWars_Events_ClanWarsEvents___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a577c9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ClanWarsModel__ClanWarsEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClanWarsService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a577c9 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_ClanWarsModel__ClanWarsEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ClanWarsService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04002453 RID: 9299
		[Token(Token = "0x4002453")]
		[FieldOffset(Offset = "0x14")]
		public Action WarStateChangedEvent;

		// Token: 0x04002454 RID: 9300
		[Token(Token = "0x4002454")]
		[FieldOffset(Offset = "0x18")]
		public Action ClanWarDeclaredEvent;

		// Token: 0x04002455 RID: 9301
		[Token(Token = "0x4002455")]
		[FieldOffset(Offset = "0x1C")]
		public Action SeasonChangedEvent;
	}
}
