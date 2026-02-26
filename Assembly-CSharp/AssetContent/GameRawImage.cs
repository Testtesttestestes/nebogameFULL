using System;
using AssetContent.Loaders;
using Core;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace AssetContent
{
	// Token: 0x02000E2E RID: 3630
	[Token(Token = "0x2000E2E")]
	[RequireComponent(typeof(GameRawImageLoader))]
	public class GameRawImage : RawImageWithGrayscale, IGameAssetContent
	{
		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x060058E6 RID: 22758 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060058E7 RID: 22759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700121C")]
		public string AssetId
		{
			[Token(Token = "0x60058E6")]
			[Address(RVA = "0xA64E", Offset = "0xA64E", VA = "0xA64E", Slot = "68")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058E7")]
			[Address(RVA = "0x1BE9", Offset = "0x1BE9", VA = "0x1BE9", Slot = "69")]
			set
			{
			}
		}

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x060058E8 RID: 22760 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060058E9 RID: 22761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700121D")]
		public string AssetPath
		{
			[Token(Token = "0x60058E8")]
			[Address(RVA = "0xA64F", Offset = "0xA64F", VA = "0xA64F", Slot = "70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058E9")]
			[Address(RVA = "0xA650", Offset = "0xA650", VA = "0xA650")]
			set
			{
			}
		}

		// Token: 0x060058EA RID: 22762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058EA")]
		[Address(RVA = "0xA651", Offset = "0xA651", VA = "0xA651")]
		private void ValidateLoader()
		{
		/* --- GHIDRA: ValidateLoader ---
		void AssetContent_GameRawImage__ValidateLoader(undefined4 param1,undefined4 param2)
		
		{
		  UI_RawImageWithGrayscale__OnDestroy(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060058EB RID: 22763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058EB")]
		[Address(RVA = "0xA652", Offset = "0xA652", VA = "0xA652")]
		public GameRawImage()
		{
		/* --- GHIDRA: .ctor ---
		void AssetContent_GameRawImage___ctor(undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int *piVar1;
		  undefined8 local_20;
		  undefined8 local_18;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a63bf1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__get_AssetRender__
		              );
		    DAT_ram_00a63bf1 = '\x01';
		  }
		  param1_00 = AssetContent_Loaders_AbstractGameGraphicLoader_object__object___get_AssetPath
		                        (param1,
		                         Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__get_AssetRender__
		                        );
		  func_ii_7050(param1_00,param2,0);
		  piVar1 = (int *)AssetContent_Loaders_AbstractGameGraphicLoader_object__object___get_AssetPath
		                            (param1,
		                             Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__get_AssetRender__
		                            );
		  local_10 = 1.0;
		  if (param2 == 0) {
		    local_10 = 0.0;
		  }
		  local_18 = CONCAT44(local_10,local_10);
		  local_20 = CONCAT44(local_10,local_10);
		  local_c = local_10;
		  local_8 = local_10;
		  local_4 = local_10;
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x178) * 4))
		            (piVar1,&local_20,*(undefined4 *)(*piVar1 + 0x17c));
		  return;
		}
		*/

		}

		// Token: 0x0400300B RID: 12299
		[Token(Token = "0x400300B")]
		[FieldOffset(Offset = "0x98")]
		private GameRawImageLoader _gameRawImageLoader;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_AssetId ---
		undefined4 AssetContent_GameRawImage__get_AssetId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63bee == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__get_AssetPath__
		              );
		    DAT_ram_00a63bee = '\x01';
		  }
		  if (DAT_ram_00a63bf0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_GameRawImageLoader___);
		    DAT_ram_00a63bf0 = '\x01';
		  }
		  if (*(int *)(param1 + 0x98) != 0) {
		    return *(undefined4 *)(*(int *)(param1 + 0x98) + 0x18);
		  }
		  iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_GameRawImageLoader___);
		  *(int *)(param1 + 0x98) = iVar1;
		  return *(undefined4 *)(iVar1 + 0x18);
		}
		*/


		/* --- GHIDRA: set_AssetId ---
		void AssetContent_GameRawImage__set_AssetId(int param1,float param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  float4 local_4;
		  
		  *(float *)(param1 + 0x14) = param2;
		  piVar2 = *(int **)(param1 + 8);
		  local_4 = (float4)param2;
		  uVar1 = System_Collections_Generic_List_float___GetEnumerator(&local_4,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/


		/* --- GHIDRA: get_AssetPath ---
		void AssetContent_GameRawImage__get_AssetPath(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63bef == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetPath__
		              );
		    DAT_ram_00a63bef = '\x01';
		  }
		  if (DAT_ram_00a63bf0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_GameRawImageLoader___);
		    DAT_ram_00a63bf0 = '\x01';
		  }
		  if (*(int *)(param1 + 0x98) == 0) {
		    param1_00 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_GameRawImageLoader___)
		    ;
		    *(undefined4 *)(param1 + 0x98) = param1_00;
		  }
		  else {
		    param1_00 = *(undefined4 *)(param1 + 0x98);
		  }
		  Core_Extensions_Dict_AprDicExt__GetImageListAssetId
		            (param1_00,param2,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetPath__
		            );
		  return;
		}
		*/


		/* --- GHIDRA: set_AssetPath ---
		void AssetContent_GameRawImage__set_AssetPath(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63bf0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_GameRawImageLoader___);
		    DAT_ram_00a63bf0 = '\x01';
		  }
		  if (*(int *)(param1 + 0x98) == 0) {
		    uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_GameRawImageLoader___);
		    *(undefined4 *)(param1 + 0x98) = uVar1;
		  }
		  return;
		}
		*/

}
