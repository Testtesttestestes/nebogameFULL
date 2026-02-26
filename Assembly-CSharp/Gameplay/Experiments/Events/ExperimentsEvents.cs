using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Experiments.Events
{
	// Token: 0x0200082C RID: 2092
	[Token(Token = "0x200082C")]
	public class ExperimentsEvents : AbstractMVCEvents
	{
		// Token: 0x06003148 RID: 12616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003148")]
		[Address(RVA = "0x81A0", Offset = "0x81A0", VA = "0x81A0")]
		public ExperimentsEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Experiments_Events_ExperimentsEvents___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5761d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ExperimentsModel__ExperimentsEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5761d = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_ExperimentsModel__ExperimentsEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}
	}
}
