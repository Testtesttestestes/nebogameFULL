using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.Materials
{
	// Token: 0x02000EC0 RID: 3776
	[Token(Token = "0x2000EC0")]
	public class GrayscaleUI : IDisposable
	{
		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x06005C0E RID: 23566 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012AE")]
		private Material CachedMaterial
		{
			[Token(Token = "0x6005C0E")]
			[Address(RVA = "0xA8CA", Offset = "0xA8CA", VA = "0xA8CA")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005C0F RID: 23567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C0F")]
		[Address(RVA = "0xA8CB", Offset = "0xA8CB", VA = "0xA8CB")]
		public GrayscaleUI(IMaterialProvider materialProvider)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Materials_GrayscaleUI___ctor(int param1,float param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a6063e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_GameSpineAnimationBindings_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Materials_IMaterialProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo);
		    DAT_ram_00a6063e = '\x01';
		  }
		  if (param2 != *(float *)(param1 + 8)) {
		    *(float *)(param1 + 8) = param2;
		    if (param2 == 0.0) {
		      uVar1 = 0;
		      uVar2 = *(undefined4 *)
		               (*(int *)(Core_Animations_GameSpineAnimationBindings_TypeInfo + 0x5c) + 0xc);
		      piVar4 = *(int **)(param1 + 0xc);
		      iVar5 = *piVar4;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Core_Materials_IMaterialProvider_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		            goto code_r0x81cbd7f1;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar4,Core_Materials_IMaterialProvider_TypeInfo,1);
		code_r0x81cbd7f1:
		      (**(code **)((ulonglong)*puVar3 * 4))(piVar4,uVar2,puVar3[1]);
		      return;
		    }
		    piVar4 = *(int **)(param1 + 0xc);
		    if (param2 == 1.0) {
		      uVar1 = 0;
		      uVar2 = *(undefined4 *)
		               (*(int *)(Core_Animations_GameSpineAnimationBindings_TypeInfo + 0x5c) + 0x10);
		      iVar5 = *piVar4;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Core_Materials_IMaterialProvider_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		            goto code_r0x81cbd894;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar4,Core_Materials_IMaterialProvider_TypeInfo,1);
		code_r0x81cbd894:
		      (**(code **)((ulonglong)*puVar3 * 4))(piVar4,uVar2,puVar3[1]);
		      return;
		    }
		    uVar1 = 0;
		    uVar2 = Core_Materials_GrayscaleSpineUI__Dispose(param1,0);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Materials_IMaterialProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		          goto code_r0x81cbd91c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Materials_IMaterialProvider_TypeInfo,1);
		code_r0x81cbd91c:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar4,uVar2,puVar3[1]);
		    uVar1 = 0;
		    piVar4 = *(int **)(param1 + 0xc);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Materials_IMaterialProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81cbd99b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Materials_IMaterialProvider_TypeInfo,0);
		code_r0x81cbd99b:
		    uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    if (*(int *)(Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo);
		    }
		    UnityEngine_Material__SetFloat
		              (uVar2,*(undefined4 *)
		                      (*(int *)(Utils_Shaders_UI_Grayscale_ShaderProperties_TypeInfo + 0x5c) + 4),
		               *(float *)(param1 + 8),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005C10 RID: 23568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C10")]
		[Address(RVA = "0xA8CC", Offset = "0xA8CC", VA = "0xA8CC")]
		public void SetGrayscale(float value)
		{
		/* --- GHIDRA: SetGrayscale ---
		void Core_Materials_GrayscaleUI__SetGrayscale(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a6063f == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a6063f = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 != 0) {
		    uVar2 = *(undefined4 *)(param1 + 0x10);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    UnityEngine_Application__get_isPlaying(uVar2,0);
		    *(undefined4 *)(param1 + 0x10) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005C11 RID: 23569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C11")]
		[Address(RVA = "0xA8CD", Offset = "0xA8CD", VA = "0xA8CD", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Materials_GrayscaleUI__Dispose(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a60640 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AbstractCurrentTimeProvider__TypeInfo);
		    DAT_ram_00a60640 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_AbstractCurrentTimeProvider__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_AbstractCurrentTimeProvider__TypeInfo),
		       iVar2 == 0)) break;
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

		// Token: 0x04003252 RID: 12882
		[Token(Token = "0x4003252")]
		[FieldOffset(Offset = "0x8")]
		private float _grayscale;

		// Token: 0x04003253 RID: 12883
		[Token(Token = "0x4003253")]
		[FieldOffset(Offset = "0xC")]
		private readonly IMaterialProvider _materialProvider;

		// Token: 0x04003254 RID: 12884
		[Token(Token = "0x4003254")]
		[FieldOffset(Offset = "0x10")]
		private Material _cachedMaterial;
	}
}
