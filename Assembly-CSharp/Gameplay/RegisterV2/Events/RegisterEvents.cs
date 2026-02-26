using System;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Auth2;

namespace Gameplay.RegisterV2.Events
{
	// Token: 0x0200056B RID: 1387
	[Token(Token = "0x200056B")]
	public class RegisterEvents : AbstractMVCEvents, IDisposable
	{
		// Token: 0x0600215F RID: 8543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600215F")]
		[Address(RVA = "0x72C1", Offset = "0x72C1", VA = "0x72C1", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002160")]
		[Address(RVA = "0x72C2", Offset = "0x72C2", VA = "0x72C2")]
		public RegisterEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_RegisterV2_Events_RegisterEvents___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58387 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_RegisterModel__RegisterEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_Auth2Service___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a58387 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_RegisterModel__RegisterEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_Auth2Service___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04001244 RID: 4676
		[Token(Token = "0x4001244")]
		[FieldOffset(Offset = "0x14")]
		public Action NickGeneratedEvent;

		// Token: 0x04001245 RID: 4677
		[Token(Token = "0x4001245")]
		[FieldOffset(Offset = "0x18")]
		public Action RegistrationProcessCompleteEvent;

		// Token: 0x04001246 RID: 4678
		[Token(Token = "0x4001246")]
		[FieldOffset(Offset = "0x1C")]
		public Action<RepeatedField<string>, RegisterCmd.Types.Result> InvalidNickErrorEvent;
	}
}
