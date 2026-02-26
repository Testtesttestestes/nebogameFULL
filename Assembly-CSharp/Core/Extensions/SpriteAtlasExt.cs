using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.U2D;

namespace Core.Extensions
{
	// Token: 0x02000F0E RID: 3854
	[Token(Token = "0x2000F0E")]
	public static class SpriteAtlasExt
	{
		// Token: 0x06005D35 RID: 23861 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D35")]
		[Address(RVA = "0xA9AE", Offset = "0xA9AE", VA = "0xA9AE")]
		private static Sprite GetSpriteWhitOriginalName(this SpriteAtlas atlas, string name)
		{
			return null;
		}

		// Token: 0x06005D36 RID: 23862 RVA: 0x00010CE0 File Offset: 0x0000EEE0
		[Token(Token = "0x6005D36")]
		[Address(RVA = "0x1ECE", Offset = "0x1ECE", VA = "0x1ECE")]
		public static bool TryGetSprite(this SpriteAtlas atlas, string name, out Sprite sprite)
		{
		/* --- GHIDRA: TryGetSprite ---
		void Core_Extensions_SpriteAtlasExt__TryGetSprite(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a6201e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_MarshalledUnityObject_MarshalNotNull_SpriteRenderer___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_MarshalledUnityObject_Marshal_Sprite___)
		    ;
		    DAT_ram_00a6201e = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 8);
		  if (iVar2 == 0) {
		    System_Collections_Generic_ArraySortHelper_AppBuildInfo_Element___InternalBinarySearch(param1,0)
		    ;
		  }
		  uVar1 = 0;
		  if (*(int *)(Method_UnityEngine_Object_MarshalledUnityObject_Marshal_Sprite___ + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference
		              (Method_UnityEngine_Object_MarshalledUnityObject_Marshal_Sprite___);
		  }
		  if (param2 != 0) {
		    uVar1 = *(undefined4 *)(param2 + 8);
		  }
		  if (DAT_ram_00a62028 == 0) {
		    DAT_ram_00a62028 = func_ii_2140(s_UnityEngine_SpriteRenderer__set__ram_00060e88);
		  }
		  (**(code **)((ulonglong)DAT_ram_00a62028 * 4))(iVar2,uVar1);
		  return;
		}
		*/

			return default(bool);
		}
	}
}
