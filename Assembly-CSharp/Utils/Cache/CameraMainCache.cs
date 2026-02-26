using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Utils.Cache
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	public static class CameraMainCache
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000355 RID: 853 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700007F")]
		public static Camera Camera
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x57B4", Offset = "0x57B4", VA = "0x57B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x0")]
		private static Camera _camera;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Camera ---
		void Utils_Cache_CameraMainCache__get_Camera(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a6284e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a6284e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 8,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
