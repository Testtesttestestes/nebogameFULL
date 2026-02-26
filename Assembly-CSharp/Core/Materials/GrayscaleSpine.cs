using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.Materials
{
	// Token: 0x02000EBE RID: 3774
	[Token(Token = "0x2000EBE")]
	public class GrayscaleSpine
	{
		// Token: 0x06005C06 RID: 23558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C06")]
		[Address(RVA = "0xA8C2", Offset = "0xA8C2", VA = "0xA8C2")]
		public GrayscaleSpine(MeshRenderer meshRenderer)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Materials_GrayscaleSpine___ctor(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a60637 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_MaterialPropertyBlock_TypeInfo);
		    DAT_ram_00a60637 = '\x01';
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

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x06005C07 RID: 23559 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012AB")]
		private MaterialPropertyBlock MaterialPropertyBlock
		{
			[Token(Token = "0x6005C07")]
			[Address(RVA = "0xA8C3", Offset = "0xA8C3", VA = "0xA8C3")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005C08 RID: 23560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C08")]
		[Address(RVA = "0xA8C4", Offset = "0xA8C4", VA = "0xA8C4")]
		public void SetGrayscale(float value, ref MaterialType materialType)
		{
		/* --- GHIDRA: SetGrayscale ---
		undefined4 Core_Materials_GrayscaleSpine__SetGrayscale(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a60639 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_ISkeletonGraphicProvider_TypeInfo);
		    DAT_ram_00a60639 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Animations_ISkeletonGraphicProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81cbd1be;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Animations_ISkeletonGraphicProvider_TypeInfo,0);
		code_r0x81cbd1be:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/

		}

		// Token: 0x0400324C RID: 12876
		[Token(Token = "0x400324C")]
		[FieldOffset(Offset = "0x8")]
		private float _grayscale;

		// Token: 0x0400324D RID: 12877
		[Token(Token = "0x400324D")]
		[FieldOffset(Offset = "0xC")]
		private readonly MeshRenderer _meshRenderer;

		// Token: 0x0400324E RID: 12878
		[Token(Token = "0x400324E")]
		[FieldOffset(Offset = "0x10")]
		private MaterialPropertyBlock _materialPropertyBlock;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_MaterialPropertyBlock ---
		void Core_Materials_GrayscaleSpine__get_MaterialPropertyBlock
		               (int param1,float param2,int *param3,undefined4 param4)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60638 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_GameSpineAnimationBindings_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo);
		    DAT_ram_00a60638 = '\x01';
		  }
		  if (param2 != *(float *)(param1 + 8)) {
		    if (*param3 != 1) {
		      uVar1 = UnityEngine_Renderer__set_material(*(undefined4 *)(param1 + 0xc),0);
		      UnityEngine_Shader__Find
		                (uVar1,*(undefined4 *)
		                        (*(int *)(Core_Animations_GameSpineAnimationBindings_TypeInfo + 0x5c) + 0x18
		                        ),0);
		      uVar1 = UnityEngine_Renderer__set_material(*(undefined4 *)(param1 + 0xc),0);
		      if (*(int *)(Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo);
		      }
		      UnityEngine_Material__SetFloat
		                (uVar1,**(undefined4 **)
		                         (Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo + 0x5c),0.0,0);
		      *param3 = 1;
		    }
		    if (DAT_ram_00a60637 == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_MaterialPropertyBlock_TypeInfo);
		      DAT_ram_00a60637 = '\x01';
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
		              (uVar1,**(undefined4 **)(Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo + 0x5c),
		               param2,0);
		    UnityEngine_Renderer__HasPropertyBlock(*(undefined4 *)(param1 + 0xc),uVar1,0);
		    *(float *)(param1 + 8) = param2;
		  }
		  return;
		}
		*/

}
