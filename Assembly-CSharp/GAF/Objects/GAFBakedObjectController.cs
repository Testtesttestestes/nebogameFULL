using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GAF.Objects
{
	// Token: 0x020013DD RID: 5085
	[Token(Token = "0x20013DD")]
	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[Serializable]
	public class GAFBakedObjectController : MonoBehaviour
	{
		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x0600796F RID: 31087 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06007970 RID: 31088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001801")]
		public GAFBakedObject bakedObject
		{
			[Token(Token = "0x600796F")]
			[Address(RVA = "0xC24E", Offset = "0xC24E", VA = "0xC24E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007970")]
			[Address(RVA = "0xC24F", Offset = "0xC24F", VA = "0xC24F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06007971 RID: 31089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007971")]
		[Address(RVA = "0xC250", Offset = "0xC250", VA = "0xC250")]
		public void init(GAFBakedObject _Object)
		{
		}

		// Token: 0x06007972 RID: 31090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007972")]
		[Address(RVA = "0xC251", Offset = "0xC251", VA = "0xC251")]
		public void updateToState(Mesh _Mesh, Material _Material)
		{
		}

		// Token: 0x06007973 RID: 31091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007973")]
		[Address(RVA = "0xC252", Offset = "0xC252", VA = "0xC252")]
		public GAFBakedObjectController()
		{
		/* --- GHIDRA: .ctor ---
		void GAF_Objects_GAFBakedObjectController___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a54ea3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_GAFInternal_Objects_GAFBakedObjectsManagerInternal_GAFBakedObject__reload__);
		    DAT_ram_00a54ea3 = '\x01';
		  }
		  uVar1 = GAFInternal_Core_GAFBehaviour__get_cachedTransform(param1,0);
		  UnityEngine_MaterialPropertyBlock_BindingsMarshaller__ConvertToNative(uVar1,0,0);
		  uVar1 = GAFInternal_Core_GAFBehaviour__get_cachedTransform(param1,0);
		  UnityEngine_Renderer__get_reflectionProbeUsage(uVar1,0,0);
		  uVar1 = GAFInternal_Core_GAFBehaviour__get_cachedTransform(param1,0);
		  UnityEngine_Renderer__get_shadowCastingMode(uVar1,0,0);
		  uVar1 = GAFInternal_Core_GAFBehaviour__get_cachedTransform(param1,0);
		  UnityEngine_Renderer__get_receiveShadows(uVar1,0,0);
		  GAFInternal_Objects_GAFBakedObjectsManagerInternal_object___initialize
		            (param1,
		             Method_GAFInternal_Objects_GAFBakedObjectsManagerInternal_GAFBakedObject__reload__);
		  return;
		}
		*/

		}
	}
}
