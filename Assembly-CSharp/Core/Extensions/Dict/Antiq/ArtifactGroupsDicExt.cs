using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict.Antiq
{
	// Token: 0x02000FB3 RID: 4019
	[Token(Token = "0x2000FB3")]
	public static class ArtifactGroupsDicExt
	{
		// Token: 0x06006018 RID: 24600 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006018")]
		[Address(RVA = "0xAC49", Offset = "0xAC49", VA = "0xAC49")]
		public static string GetImageAssetId(this Antiq.Types.ArtifactGroupsDic dict)
		{
		/* --- GHIDRA: GetImageAssetId ---
		undefined4
		Core_Extensions_Dict_Antiq_ArtifactGroupsDicExt__GetImageAssetId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x2c),0xe3,0);
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

		// Token: 0x06006019 RID: 24601 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006019")]
		[Address(RVA = "0xAC4A", Offset = "0xAC4A", VA = "0xAC4A")]
		public static string GetImageThumbnailAssetId(this Antiq.Types.ArtifactGroupsDic dict)
		{
		/* --- GHIDRA: GetImageThumbnailAssetId ---
		undefined4
		Core_Extensions_Dict_Antiq_ArtifactGroupsDicExt__GetImageThumbnailAssetId
		          (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x30),0xce,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600601A RID: 24602 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600601A")]
		[Address(RVA = "0xAC4B", Offset = "0xAC4B", VA = "0xAC4B")]
		public static string GetTitle(this Antiq.Types.ArtifactGroupsDic dict)
		{
		/* --- GHIDRA: GetTitle ---
		undefined4 Core_Extensions_Dict_Antiq_ArtifactGroupsDicExt__GetTitle(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x30),0xcf,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600601B RID: 24603 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600601B")]
		[Address(RVA = "0xAC4C", Offset = "0xAC4C", VA = "0xAC4C")]
		public static string GetDescription(this Antiq.Types.ArtifactGroupsDic dict)
		{
		/* --- GHIDRA: GetDescription ---
		undefined4
		Core_Extensions_Dict_Antiq_ArtifactGroupsDicExt__GetDescription(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x18),0xd2,0);
		  return uVar1;
		}
		*/

			return null;
		}
	}
}
