using System;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;

namespace Core.Animations
{
	// Token: 0x02001278 RID: 4728
	[Token(Token = "0x2001278")]
	public class AlphaSpineUI : IDisposable
	{
		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x0600702B RID: 28715 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016E2")]
		private SkeletonGraphic SkeletonGraphic
		{
			[Token(Token = "0x600702B")]
			[Address(RVA = "0xBA70", Offset = "0xBA70", VA = "0xBA70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x0600702C RID: 28716 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016E3")]
		private Material CachedMaterial
		{
			[Token(Token = "0x600702C")]
			[Address(RVA = "0xBA71", Offset = "0xBA71", VA = "0xBA71")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600702D RID: 28717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600702D")]
		[Address(RVA = "0xBA72", Offset = "0xBA72", VA = "0xBA72")]
		public AlphaSpineUI(ISkeletonGraphicProvider skeletonGraphicProvider)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Animations_AlphaSpineUI___ctor(int param1,float param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a897 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo);
		    DAT_ram_00a5a897 = '\x01';
		  }
		  if (param2 != *(float *)(param1 + 8)) {
		    if (DAT_ram_00a5a895 == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Animations_ISkeletonGraphicProvider_TypeInfo);
		      DAT_ram_00a5a895 = '\x01';
		    }
		    piVar4 = *(int **)(param1 + 0x10);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Animations_ISkeletonGraphicProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81284d31;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Animations_ISkeletonGraphicProvider_TypeInfo,0);
		code_r0x81284d31:
		    piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    uVar3 = Core_Animations_AlphaSpineUI__get_SkeletonGraphic(param1,piVar4);
		    (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x1c8) * 4))
		              (piVar4,uVar3,*(undefined4 *)(*piVar4 + 0x1cc));
		    if (DAT_ram_00a5a895 == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Animations_ISkeletonGraphicProvider_TypeInfo);
		      DAT_ram_00a5a895 = '\x01';
		    }
		    piVar4 = *(int **)(param1 + 0x10);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Animations_ISkeletonGraphicProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81284df0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Animations_ISkeletonGraphicProvider_TypeInfo,0);
		code_r0x81284df0:
		    piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x1c0) * 4))
		                      (piVar4,*(undefined4 *)(*piVar4 + 0x1c4));
		    if (*(int *)(Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo);
		    }
		    UnityEngine_Material__SetFloat
		              (uVar3,*(undefined4 *)
		                      (*(int *)(Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo + 0x5c) + 0xc),
		               param2,0);
		    *(float *)(param1 + 8) = param2;
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600702E RID: 28718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600702E")]
		[Address(RVA = "0xBA73", Offset = "0xBA73", VA = "0xBA73")]
		public void SetAlpha(float value)
		{
		/* --- GHIDRA: SetAlpha ---
		void Core_Animations_AlphaSpineUI__SetAlpha(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a898 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5a898 = '\x01';
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

		// Token: 0x0600702F RID: 28719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600702F")]
		[Address(RVA = "0xBA74", Offset = "0xBA74", VA = "0xBA74", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Animations_AlphaSpineUI__Dispose(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a899 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_GAFBakedMovieClip___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_AddComponent_BoxCollider2D___);
		    DAT_ram_00a5a899 = '\x01';
		  }
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_GAFBakedMovieClip___);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  uVar1 = UnityEngine_GameObject__GetComponent_object_
		                    (uVar1,Method_UnityEngine_GameObject_AddComponent_BoxCollider2D___);
		  local_10 = 0x4348000043480000;
		  local_8 = 0x4348000043480000;
		  UnityEngine_BoxCollider2D__get_size(uVar1,&local_10,0);
		  return;
		}
		*/

		}

		// Token: 0x04003A88 RID: 14984
		[Token(Token = "0x4003A88")]
		[FieldOffset(Offset = "0x8")]
		private float _alpha;

		// Token: 0x04003A89 RID: 14985
		[Token(Token = "0x4003A89")]
		[FieldOffset(Offset = "0xC")]
		private Material _cachedMaterial;

		// Token: 0x04003A8A RID: 14986
		[Token(Token = "0x4003A8A")]
		[FieldOffset(Offset = "0x10")]
		private ISkeletonGraphicProvider _skeletonGraphicProvider;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SkeletonGraphic ---
		undefined4 Core_Animations_AlphaSpineUI__get_SkeletonGraphic(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a896 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_GameSpineAnimationBindings_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_Material___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5a896 = '\x01';
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
