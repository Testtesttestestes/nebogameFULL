using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.Materials
{
	// Token: 0x02000EBD RID: 3773
	[Token(Token = "0x2000EBD")]
	public class AlphaSpine
	{
		// Token: 0x06005C03 RID: 23555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C03")]
		[Address(RVA = "0xA8BF", Offset = "0xA8BF", VA = "0xA8BF")]
		public AlphaSpine(MeshRenderer meshRenderer)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Materials_AlphaSpine___ctor(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a60635 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_MaterialPropertyBlock_TypeInfo);
		    DAT_ram_00a60635 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  if (param1_00 == 0) {
		    param1_00 = unnamed_function_1417(UnityEngine_MaterialPropertyBlock_TypeInfo);
		    UnityEngine_MaterialPropertyBlock__SetVectorArray(param1_00,0);
		    *(int *)(param1 + 0x10) = param1_00;
		  }
		  UnityEngine_Renderer__SetPropertyBlock(*(undefined4 *)(param1 + 0xc),param1_00,0);
		  return *(undefined4 *)(param1 + 0x10);
		}
		*/

		}

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x06005C04 RID: 23556 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012AA")]
		private MaterialPropertyBlock MaterialPropertyBlock
		{
			[Token(Token = "0x6005C04")]
			[Address(RVA = "0xA8C0", Offset = "0xA8C0", VA = "0xA8C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005C05 RID: 23557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C05")]
		[Address(RVA = "0xA8C1", Offset = "0xA8C1", VA = "0xA8C1")]
		public void SetAlpha(float value, ref MaterialType materialType)
		{
		}

		// Token: 0x04003249 RID: 12873
		[Token(Token = "0x4003249")]
		[FieldOffset(Offset = "0x8")]
		private float _alpha;

		// Token: 0x0400324A RID: 12874
		[Token(Token = "0x400324A")]
		[FieldOffset(Offset = "0xC")]
		private readonly MeshRenderer _meshRenderer;

		// Token: 0x0400324B RID: 12875
		[Token(Token = "0x400324B")]
		[FieldOffset(Offset = "0x10")]
		private MaterialPropertyBlock _materialPropertyBlock;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_MaterialPropertyBlock ---
		void Core_Materials_AlphaSpine__get_MaterialPropertyBlock
		               (int param1,float param2,int *param3,undefined4 param4)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60636 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_GameSpineAnimationBindings_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo);
		    DAT_ram_00a60636 = '\x01';
		  }
		  if (param2 != *(float *)(param1 + 8)) {
		    if (*param3 != 2) {
		      uVar1 = UnityEngine_Renderer__set_material(*(undefined4 *)(param1 + 0xc),0);
		      UnityEngine_Shader__Find
		                (uVar1,*(undefined4 *)
		                        (*(int *)(Core_Animations_GameSpineAnimationBindings_TypeInfo + 0x5c) + 0x14
		                        ),0);
		      *param3 = 2;
		    }
		    if (DAT_ram_00a60635 == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_MaterialPropertyBlock_TypeInfo);
		      DAT_ram_00a60635 = '\x01';
		    }
		    param1_00 = *(int *)(param1 + 0x10);
		    if (param1_00 == 0) {
		      param1_00 = unnamed_function_1417(UnityEngine_MaterialPropertyBlock_TypeInfo);
		      UnityEngine_MaterialPropertyBlock__SetVectorArray(param1_00,0);
		      *(int *)(param1 + 0x10) = param1_00;
		    }
		    UnityEngine_Renderer__SetPropertyBlock(*(undefined4 *)(param1 + 0xc),param1_00,0);
		    uVar1 = *(undefined4 *)(param1 + 0x10);
		    if (*(int *)(Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo);
		    }
		    UnityEngine_MaterialPropertyBlock__Dispose
		              (uVar1,*(undefined4 *)
		                      (*(int *)(Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo + 0x5c) + 0xc),
		               param2,0);
		    UnityEngine_Renderer__HasPropertyBlock(*(undefined4 *)(param1 + 0xc),uVar1,0);
		    *(float *)(param1 + 8) = param2;
		  }
		  return;
		}
		*/

}
