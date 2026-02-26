using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Net
{
	// Token: 0x02000E90 RID: 3728
	[Token(Token = "0x2000E90")]
	public static class ServiceFactory
	{
		// Token: 0x06005A98 RID: 23192 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005A98")]
		public static T GetService<T>() where T : AbstractService, new()
		{
			return null;
		}

		// Token: 0x0400317A RID: 12666
		[Token(Token = "0x400317A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ProtocolCommandInfoProvider ProtocolInfoProvider;

		// Token: 0x0400317B RID: 12667
		[Token(Token = "0x400317B")]
		[FieldOffset(Offset = "0x4")]
		private static readonly Dictionary<Type, AbstractService> _services;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: GetService<object> ---
		void Core_Net_ServiceFactory__GetService_object_(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6287b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MoveUserEvt__TypeInfo);
		    DAT_ram_00a6287b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_MoveUserEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MoveUserEvt__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
