using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.Extensions
{
	// Token: 0x02000F00 RID: 3840
	[Token(Token = "0x2000F00")]
	public static class BoundsExt
	{
		// Token: 0x06005D14 RID: 23828 RVA: 0x00010BA8 File Offset: 0x0000EDA8
		[Token(Token = "0x6005D14")]
		[Address(RVA = "0xA99A", Offset = "0xA99A", VA = "0xA99A")]
		public static Rect ToRect(this Bounds bounds, Camera camera)
		{
		/* --- GHIDRA: ToRect ---
		void Core_Extensions_BoundsExt__ToRect
		               (undefined4 *param1,undefined8 *param2,undefined4 param3,undefined4 param4)
		
		{
		  float fVar1;
		  float fVar2;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined1 local_10 [16];
		  
		  local_18 = *(undefined4 *)(param2 + 1);
		  local_20 = *param2;
		  UnityEngine_Camera__ScreenToWorldPoint(local_10,param3,&local_20,0);
		  fVar1 = *(float *)(param2 + 2);
		  fVar2 = *(float *)((int)param2 + 0xc);
		  param1[1] = SUB84(local_10._0_8_,4);
		  *param1 = (int)local_10._0_8_;
		  param1[3] = fVar1 + fVar1;
		  param1[2] = fVar2 + fVar2;
		  return;
		}
		*/

			return default(Rect);
		}

		// Token: 0x06005D15 RID: 23829 RVA: 0x00010BC0 File Offset: 0x0000EDC0
		[Token(Token = "0x6005D15")]
		[Address(RVA = "0xA99B", Offset = "0xA99B", VA = "0xA99B")]
		public static Rect ToRectFor2D(this Bounds bounds, Camera camera)
		{
		/* --- GHIDRA: ToRectFor2D ---
		undefined8 Core_Extensions_BoundsExt__ToRectFor2D(int param1,int param2,undefined4 param3)
		
		{
		  undefined8 uVar1;
		  
		  if (DAT_ram_00a5accf == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_long__get_Item__)
		    ;
		    DAT_ram_00a5accf = '\x01';
		  }
		  uVar1 = func_ii_7271(*(undefined4 *)(param1 + 0x24),param2 + -1,
		                       Method_Google_Protobuf_Collections_RepeatedField_long__get_Item__);
		  return uVar1;
		}
		*/

			return default(Rect);
		}
	}
}
