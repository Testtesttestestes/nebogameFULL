using System;
using Il2CppDummyDll;
using MVC;
using Protocol.Craft;

namespace Gameplay.Craft.Events
{
	// Token: 0x020008C2 RID: 2242
	[Token(Token = "0x20008C2")]
	public class CraftEvents : AbstractMVCEvents
	{
		// Token: 0x060034B1 RID: 13489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034B1")]
		[Address(RVA = "0x84DA", Offset = "0x84DA", VA = "0x84DA")]
		public CraftEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Craft_Events_CraftEvents___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63a2e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_CraftModel__CraftEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_CraftService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a63a2e = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_CraftModel__CraftEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_CraftService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04001CDD RID: 7389
		[Token(Token = "0x4001CDD")]
		[FieldOffset(Offset = "0x14")]
		public Action ProfessionRequestedEvent;

		// Token: 0x04001CDE RID: 7390
		[Token(Token = "0x4001CDE")]
		[FieldOffset(Offset = "0x18")]
		public Action SchemesRequestedEvent;

		// Token: 0x04001CDF RID: 7391
		[Token(Token = "0x4001CDF")]
		[FieldOffset(Offset = "0x1C")]
		public Action CraftSlotsRequestedEvent;

		// Token: 0x04001CE0 RID: 7392
		[Token(Token = "0x4001CE0")]
		[FieldOffset(Offset = "0x20")]
		public Action UserBalanceChangedEvent;

		// Token: 0x04001CE1 RID: 7393
		[Token(Token = "0x4001CE1")]
		[FieldOffset(Offset = "0x24")]
		public Action<UserScheme> SchemeChangedEvent;

		// Token: 0x04001CE2 RID: 7394
		[Token(Token = "0x4001CE2")]
		[FieldOffset(Offset = "0x28")]
		public Action CraftSlotsChangedEvent;
	}
}
