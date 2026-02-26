using System;
using GAFInternal.Objects;
using Il2CppDummyDll;
using UnityEngine;

namespace GAF.Objects
{
	// Token: 0x020013DF RID: 5087
	[Token(Token = "0x20013DF")]
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class GAFObject : GAFObjectInternal
	{
		// Token: 0x06007977 RID: 31095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007977")]
		[Address(RVA = "0xC256", Offset = "0xC256", VA = "0xC256", Slot = "12")]
		public override void reload()
		{
		}

		// Token: 0x06007978 RID: 31096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007978")]
		[Address(RVA = "0xC257", Offset = "0xC257", VA = "0xC257")]
		public GAFObject()
		{
		/* --- GHIDRA: .ctor ---
		void GAF_Objects_GAFObject___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a54ea6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_GAFInternal_Objects_GAFObjectsManagerInternal_GAFObject__reload__);
		    DAT_ram_00a54ea6 = '\x01';
		  }
		  uVar1 = GAFInternal_Core_GAFBehaviour__get_cachedTransform(param1,0);
		  UnityEngine_MaterialPropertyBlock_BindingsMarshaller__ConvertToNative(uVar1,0,0);
		  uVar1 = GAFInternal_Core_GAFBehaviour__get_cachedTransform(param1,0);
		  UnityEngine_Renderer__get_reflectionProbeUsage(uVar1,0,0);
		  uVar1 = GAFInternal_Core_GAFBehaviour__get_cachedTransform(param1,0);
		  UnityEngine_Renderer__get_shadowCastingMode(uVar1,0,0);
		  uVar1 = GAFInternal_Core_GAFBehaviour__get_cachedTransform(param1,0);
		  UnityEngine_Renderer__get_receiveShadows(uVar1,0,0);
		  GAFInternal_Objects_GAFObjectsManagerInternal_object___initialize
		            (param1,Method_GAFInternal_Objects_GAFObjectsManagerInternal_GAFObject__reload__);
		  return;
		}
		*/

		}
	}
}
