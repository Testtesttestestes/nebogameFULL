using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Utils.Uri
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	public static class UriUtil
	{
		// Token: 0x06000303 RID: 771 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x5776", Offset = "0x5776", VA = "0x5776")]
		public static Dictionary<string, string> GetQueryParams(string uriString)
		{
		/* --- GHIDRA: GetQueryParams ---
		void Utils_Uri_UriUtil__GetQueryParams(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6282e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    DAT_ram_00a6282e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IAsyncLoadableContent__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAsyncLoadableContent__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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

			return null;
		}
	}
}
