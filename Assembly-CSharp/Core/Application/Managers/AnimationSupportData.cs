using System;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;

namespace Core.Application.Managers
{
	// Token: 0x02001249 RID: 4681
	[Token(Token = "0x2001249")]
	[CreateAssetMenu(menuName = "Heavens/AnimationSupportData")]
	public class AnimationSupportData : ScriptableObject
	{
		// Token: 0x170016A4 RID: 5796
		// (get) Token: 0x06006EE6 RID: 28390 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016A4")]
		public Material DefaultSpineUIMaterial
		{
			[Token(Token = "0x6006EE6")]
			[Address(RVA = "0xB964", Offset = "0xB964", VA = "0xB964")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016A5 RID: 5797
		// (get) Token: 0x06006EE7 RID: 28391 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016A5")]
		public Material GraySpineUIMaterial
		{
			[Token(Token = "0x6006EE7")]
			[Address(RVA = "0xB965", Offset = "0xB965", VA = "0xB965")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016A6 RID: 5798
		// (get) Token: 0x06006EE8 RID: 28392 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016A6")]
		public Material DefaultUIMaterial
		{
			[Token(Token = "0x6006EE8")]
			[Address(RVA = "0xB966", Offset = "0xB966", VA = "0xB966")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016A7 RID: 5799
		// (get) Token: 0x06006EE9 RID: 28393 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016A7")]
		public Material GrayUIMaterial
		{
			[Token(Token = "0x6006EE9")]
			[Address(RVA = "0xB967", Offset = "0xB967", VA = "0xB967")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016A8 RID: 5800
		// (get) Token: 0x06006EEA RID: 28394 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016A8")]
		public Shader GrayscaleSpineShader
		{
			[Token(Token = "0x6006EEA")]
			[Address(RVA = "0xB968", Offset = "0xB968", VA = "0xB968")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x06006EEB RID: 28395 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016A9")]
		public Shader TintSpineShader
		{
			[Token(Token = "0x6006EEB")]
			[Address(RVA = "0xB969", Offset = "0xB969", VA = "0xB969")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006EEC RID: 28396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EEC")]
		[Address(RVA = "0xB96A", Offset = "0xB96A", VA = "0xB96A")]
		public AnimationSupportData()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Application_Managers_AnimationSupportData___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a809 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a809 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
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

		// Token: 0x040039F5 RID: 14837
		[Token(Token = "0x40039F5")]
		[FieldOffset(Offset = "0xC")]
		public BlendModeMaterialsAsset BlendModeMaterialsAsset;

		// Token: 0x040039F6 RID: 14838
		[Token(Token = "0x40039F6")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Material _defaultSpineUIMaterial;

		// Token: 0x040039F7 RID: 14839
		[Token(Token = "0x40039F7")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Material _graySpineUIMaterial;

		// Token: 0x040039F8 RID: 14840
		[Token(Token = "0x40039F8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Material _defaultUIMaterial;

		// Token: 0x040039F9 RID: 14841
		[Token(Token = "0x40039F9")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Material _grayUIMaterial;

		// Token: 0x040039FA RID: 14842
		[Token(Token = "0x40039FA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Material _defaultSpineMaterial;

		// Token: 0x040039FB RID: 14843
		[Token(Token = "0x40039FB")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Material _tintSpineMaterial;

		// Token: 0x040039FC RID: 14844
		[Token(Token = "0x40039FC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Shader _grayscaleSpineShader;

		// Token: 0x040039FD RID: 14845
		[Token(Token = "0x40039FD")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Shader _tintSpineShader;
	}
}
