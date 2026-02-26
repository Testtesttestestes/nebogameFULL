using System;
using Gameplay.Isles.Base.Events;
using Il2CppDummyDll;

namespace Gameplay.Isles.Clan.Events
{
	// Token: 0x02000CF4 RID: 3316
	[Token(Token = "0x2000CF4")]
	public class ClanIsleEvents : BaseIsleEvents
	{
		// Token: 0x060050B5 RID: 20661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B5")]
		[Address(RVA = "0x9EC4", Offset = "0x9EC4", VA = "0x9EC4")]
		public ClanIsleEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_Clan_Events_ClanIsleEvents___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58cb7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_Controller_BaseIsleController_ClanIsleModel__ClanIsleEvents___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClanIsleService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClansService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a58cb7 = '\x01';
		  }
		  UI_Windows_Buildings_BaseIsleBuildingWindowArgs___Il2CppFullySharedGenericType____ctor
		            (param1,param3,param4,
		             Method_Gameplay_Isles_Base_Controller_BaseIsleController_ClanIsleModel__ClanIsleEvents___ctor__
		            );
		  *(undefined4 *)(param1 + 0x24) = param2;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ClanIsleService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ClansService___);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04002C13 RID: 11283
		[Token(Token = "0x4002C13")]
		[FieldOffset(Offset = "0x24")]
		public Action GolemStateChangedEvent;
	}
}
