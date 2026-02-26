using System;
using Core.Animations;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;

namespace Core.Materials
{
	// Token: 0x02000EBF RID: 3775
	[Token(Token = "0x2000EBF")]
	public class GrayscaleSpineUI : IDisposable
	{
		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x06005C09 RID: 23561 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012AC")]
		private SkeletonGraphic SkeletonGraphic
		{
			[Token(Token = "0x6005C09")]
			[Address(RVA = "0xA8C5", Offset = "0xA8C5", VA = "0xA8C5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x06005C0A RID: 23562 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012AD")]
		private Material CachedMaterial
		{
			[Token(Token = "0x6005C0A")]
			[Address(RVA = "0xA8C6", Offset = "0xA8C6", VA = "0xA8C6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005C0B RID: 23563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C0B")]
		[Address(RVA = "0xA8C7", Offset = "0xA8C7", VA = "0xA8C7")]
		public GrayscaleSpineUI(ISkeletonGraphicProvider skeletonGraphicProvider)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Materials_GrayscaleSpineUI___ctor(int param1,float param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a6063b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_GameSpineAnimationBindings_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo);
		    DAT_ram_00a6063b = '\x01';
		  }
		  if (param2 != *(float *)(param1 + 8)) {
		    if (param2 == 0.0) {
		      if (DAT_ram_00a60639 == 0) {
		        Mono_Security_ASN1__get_Item(&Core_Animations_ISkeletonGraphicProvider_TypeInfo);
		        DAT_ram_00a60639 = 1;
		      }
		      piVar4 = *(int **)(param1 + 0x10);
		      iVar5 = *piVar4;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Animations_ISkeletonGraphicProvider_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x81cbd345;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar4,Core_Animations_ISkeletonGraphicProvider_TypeInfo,0);
		code_r0x81cbd345:
		      piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		      (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x1c8) * 4))
		                (piVar4,*(undefined4 *)
		                         (*(int *)(Core_Animations_GameSpineAnimationBindings_TypeInfo + 0x5c) + 4),
		                 *(undefined4 *)(*piVar4 + 0x1cc));
		    }
		    else if (param2 == 1.0) {
		      if ((DAT_ram_00a60639 & 1) == 0) {
		        Mono_Security_ASN1__get_Item(&Core_Animations_ISkeletonGraphicProvider_TypeInfo);
		        DAT_ram_00a60639 = 1;
		      }
		      uVar1 = 0;
		      piVar4 = *(int **)(param1 + 0x10);
		      iVar5 = *piVar4;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Core_Animations_ISkeletonGraphicProvider_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x81cbd41e;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar4,Core_Animations_ISkeletonGraphicProvider_TypeInfo,0);
		code_r0x81cbd41e:
		      piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		      (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x1c8) * 4))
		                (piVar4,*(undefined4 *)
		                         (*(int *)(Core_Animations_GameSpineAnimationBindings_TypeInfo + 0x5c) + 8),
		                 *(undefined4 *)(*piVar4 + 0x1cc));
		    }
		    else {
		      if ((DAT_ram_00a60639 & 1) == 0) {
		        Mono_Security_ASN1__get_Item(&Core_Animations_ISkeletonGraphicProvider_TypeInfo);
		        DAT_ram_00a60639 = 1;
		      }
		      uVar1 = 0;
		      piVar4 = *(int **)(param1 + 0x10);
		      iVar5 = *piVar4;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Core_Animations_ISkeletonGraphicProvider_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x81cbd4e3;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar4,Core_Animations_ISkeletonGraphicProvider_TypeInfo,0);
		code_r0x81cbd4e3:
		      piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		      uVar3 = Core_Materials_GrayscaleSpineUI__get_SkeletonGraphic(param1,piVar4);
		      (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x1c8) * 4))
		                (piVar4,uVar3,*(undefined4 *)(*piVar4 + 0x1cc));
		      if (DAT_ram_00a60639 == 0) {
		        Mono_Security_ASN1__get_Item(&Core_Animations_ISkeletonGraphicProvider_TypeInfo);
		        DAT_ram_00a60639 = 1;
		      }
		      piVar4 = *(int **)(param1 + 0x10);
		      iVar5 = *piVar4;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Animations_ISkeletonGraphicProvider_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x81cbd5a2;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar4,Core_Animations_ISkeletonGraphicProvider_TypeInfo,0);
		code_r0x81cbd5a2:
		      piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x1c0) * 4))
		                        (piVar4,*(undefined4 *)(*piVar4 + 0x1c4));
		      if (*(int *)(Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo);
		      }
		      UnityEngine_Material__SetFloat
		                (uVar3,*(undefined4 *)
		                        (*(int *)(Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo + 0x5c) + 4),
		                 param2,0);
		    }
		    *(float *)(param1 + 8) = param2;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005C0C RID: 23564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C0C")]
		[Address(RVA = "0xA8C8", Offset = "0xA8C8", VA = "0xA8C8")]
		public void SetGrayscale(float value)
		{
		/* --- GHIDRA: SetGrayscale ---
		void Core_Materials_GrayscaleSpineUI__SetGrayscale(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a6063c == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a6063c = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0xc);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 != 0) {
		    uVar2 = *(undefined4 *)(param1 + 0xc);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    UnityEngine_Application__get_isPlaying(uVar2,0);
		    *(undefined4 *)(param1 + 0xc) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005C0D RID: 23565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C0D")]
		[Address(RVA = "0xA8C9", Offset = "0xA8C9", VA = "0xA8C9", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		undefined4 Core_Materials_GrayscaleSpineUI__Dispose(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a6063d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_GameSpineAnimationBindings_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_Material___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a6063d = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(uVar2,0,0);
		  if (iVar1 == 0) {
		    return *(undefined4 *)(param1 + 0x10);
		  }
		  uVar2 = *(undefined4 *)
		           (*(int *)(Core_Animations_GameSpineAnimationBindings_TypeInfo + 0x5c) + 0xc);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar2 = func_ii_5950(uVar2,Method_UnityEngine_Object_Instantiate_Material___);
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  return uVar2;
		}
		*/

		}

		// Token: 0x0400324F RID: 12879
		[Token(Token = "0x400324F")]
		[FieldOffset(Offset = "0x8")]
		private float _grayscale;

		// Token: 0x04003250 RID: 12880
		[Token(Token = "0x4003250")]
		[FieldOffset(Offset = "0xC")]
		private Material _cachedMaterial;

		// Token: 0x04003251 RID: 12881
		[Token(Token = "0x4003251")]
		[FieldOffset(Offset = "0x10")]
		private ISkeletonGraphicProvider _skeletonGraphicProvider;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SkeletonGraphic ---
		undefined4 Core_Materials_GrayscaleSpineUI__get_SkeletonGraphic(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a6063a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_GameSpineAnimationBindings_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_Material___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a6063a = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0xc);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(uVar2,0,0);
		  if (iVar1 == 0) {
		    return *(undefined4 *)(param1 + 0xc);
		  }
		  uVar2 = *(undefined4 *)(*(int *)(Core_Animations_GameSpineAnimationBindings_TypeInfo + 0x5c) + 4);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar2 = func_ii_5950(uVar2,Method_UnityEngine_Object_Instantiate_Material___);
		  *(undefined4 *)(param1 + 0xc) = uVar2;
		  return uVar2;
		}
		*/

}
