using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000FAD RID: 4013
	[Token(Token = "0x2000FAD")]
	public static class UserBuildingViewsDicExt
	{
		// Token: 0x06006004 RID: 24580 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006004")]
		[Address(RVA = "0xAC39", Offset = "0xAC39", VA = "0xAC39")]
		public static string GetImageAssetId(this UserBuildingViewsDic userBuildingViewsDic)
		{
		/* --- GHIDRA: GetImageAssetId ---
		undefined4
		Core_Extensions_Dict_UserBuildingViewsDicExt__GetImageAssetId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x30),0x4d,0);
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

		// Token: 0x06006005 RID: 24581 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006005")]
		[Address(RVA = "0xAC3A", Offset = "0xAC3A", VA = "0xAC3A")]
		public static string GetMiniatureAssetId(this UserBuildingViewsDic userBuildingViewsDic)
		{
		/* --- GHIDRA: GetMiniatureAssetId ---
		undefined4
		Core_Extensions_Dict_UserBuildingViewsDicExt__GetMiniatureAssetId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x30),0x67,0);
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

		// Token: 0x06006006 RID: 24582 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006006")]
		[Address(RVA = "0xAC3B", Offset = "0xAC3B", VA = "0xAC3B")]
		public static string GetAnimationAssetId(this UserBuildingViewsDic userBuildingViewsDic)
		{
		/* --- GHIDRA: GetAnimationAssetId ---
		undefined4
		Core_Extensions_Dict_UserBuildingViewsDicExt__GetAnimationAssetId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x30),0x7e,0);
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

		// Token: 0x06006007 RID: 24583 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006007")]
		[Address(RVA = "0xAC3C", Offset = "0xAC3C", VA = "0xAC3C")]
		public static string GetAnimationUiAssetId(this UserBuildingViewsDic userBuildingViewsDic)
		{
		/* --- GHIDRA: GetAnimationUiAssetId ---
		undefined4
		Core_Extensions_Dict_UserBuildingViewsDicExt__GetAnimationUiAssetId(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = 0;
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x30),0x67,0);
		  if (iVar1 != 0) {
		    param1_00 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(param1_00,0)
		  ;
		  if (iVar1 != 0) {
		    param1_00 = 0;
		    iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x30),0x13,0);
		    if (iVar1 != 0) {
		      param1_00 = *(undefined4 *)(iVar1 + 0x10);
		    }
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06006008 RID: 24584 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006008")]
		[Address(RVA = "0xAC3D", Offset = "0xAC3D", VA = "0xAC3D")]
		public static string GetIsleViewAssetId(this UserBuildingViewsDic userBuildingViewsDic)
		{
		/* --- GHIDRA: GetIsleViewAssetId ---
		undefined4
		Core_Extensions_Dict_UserBuildingViewsDicExt__GetIsleViewAssetId(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = 0;
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x30),0x7e,0);
		  if (iVar1 != 0) {
		    param1_00 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(param1_00,0)
		  ;
		  if (iVar1 != 0) {
		    param1_00 = 0;
		    iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x30),0x13,0);
		    if (iVar1 != 0) {
		      param1_00 = *(undefined4 *)(iVar1 + 0x10);
		    }
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06006009 RID: 24585 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006009")]
		[Address(RVA = "0xAC3E", Offset = "0xAC3E", VA = "0xAC3E")]
		public static string GetIsleViewUiAssetId(this UserBuildingViewsDic userBuildingViewsDic)
		{
		/* --- GHIDRA: GetIsleViewUiAssetId ---
		undefined4
		Core_Extensions_Dict_UserBuildingViewsDicExt__GetIsleViewUiAssetId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x1c),0x55,0);
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
