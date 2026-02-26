using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000FA3 RID: 4003
	[Token(Token = "0x2000FA3")]
	public static class SpellDicExt
	{
		// Token: 0x06005FE2 RID: 24546 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FE2")]
		[Address(RVA = "0xAC19", Offset = "0xAC19", VA = "0xAC19")]
		public static string GetAssetId(this SpellDic spellDic, SpellDic.Types.ContentResource contentResourceId)
		{
		/* --- GHIDRA: GetAssetId ---
		undefined4 Core_Extensions_Dict_SpellDicExt__GetAssetId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x48),0x26,0);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06005FE3 RID: 24547 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FE3")]
		[Address(RVA = "0xAC1A", Offset = "0xAC1A", VA = "0xAC1A")]
		public static string GetIconAssetId(this SpellDic spellDic)
		{
		/* --- GHIDRA: GetIconAssetId ---
		undefined4 Core_Extensions_Dict_SpellDicExt__GetIconAssetId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x48),0xbe,0);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06005FE4 RID: 24548 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FE4")]
		[Address(RVA = "0xAC1B", Offset = "0xAC1B", VA = "0xAC1B")]
		public static string GetIcon94x94AssetId(this SpellDic spellDic)
		{
		/* --- GHIDRA: GetIcon94x94AssetId ---
		undefined4 Core_Extensions_Dict_SpellDicExt__GetIcon94x94AssetId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x48),0x11,0);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06005FE5 RID: 24549 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FE5")]
		[Address(RVA = "0xAC1C", Offset = "0xAC1C", VA = "0xAC1C")]
		public static string GetAnimationAssetId(this SpellDic spellDic)
		{
		/* --- GHIDRA: GetAnimationAssetId ---
		undefined4 Core_Extensions_Dict_SpellDicExt__GetAnimationAssetId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x48),0x8c,0);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06005FE6 RID: 24550 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FE6")]
		[Address(RVA = "0xAC1D", Offset = "0xAC1D", VA = "0xAC1D")]
		public static string GetAnimationCanvasAssetId(this SpellDic spellDic)
		{
		/* --- GHIDRA: GetAnimationCanvasAssetId ---
		undefined4 Core_Extensions_Dict_SpellDicExt__GetAnimationCanvasAssetId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x48),0x89,0);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06005FE7 RID: 24551 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FE7")]
		[Address(RVA = "0xAC1E", Offset = "0xAC1E", VA = "0xAC1E")]
		public static string GetAnimationOnAvatarCanvasAssetId(this SpellDic spellDic)
		{
		/* --- GHIDRA: GetAnimationOnAvatarCanvasAssetId ---
		undefined4
		Core_Extensions_Dict_SpellDicExt__GetAnimationOnAvatarCanvasAssetId(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x4c),0x1e,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005FE8 RID: 24552 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FE8")]
		[Address(RVA = "0xAC1F", Offset = "0xAC1F", VA = "0xAC1F")]
		public static string GetTitle(this SpellDic spellDic)
		{
		/* --- GHIDRA: GetTitle ---
		undefined4 Core_Extensions_Dict_SpellDicExt__GetTitle(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x4c),0x1f,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005FE9 RID: 24553 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FE9")]
		[Address(RVA = "0xAC20", Offset = "0xAC20", VA = "0xAC20")]
		public static string GetDescription(this SpellDic spellDic)
		{
		/* --- GHIDRA: GetDescription ---
		undefined4 Core_Extensions_Dict_SpellDicExt__GetDescription(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x4c),0xa2,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005FEA RID: 24554 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FEA")]
		[Address(RVA = "0xAC21", Offset = "0xAC21", VA = "0xAC21")]
		public static string GetTutorialDescription(this SpellDic spellDic)
		{
		/* --- GHIDRA: GetTutorialDescription ---
		undefined4
		Core_Extensions_Dict_SpellDicExt__GetTutorialDescription
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x3c),param2,0);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  return uVar2;
		}
		*/

			return null;
		}
	}
}
