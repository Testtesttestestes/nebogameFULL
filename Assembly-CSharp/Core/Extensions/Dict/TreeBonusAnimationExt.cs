using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000FA8 RID: 4008
	[Token(Token = "0x2000FA8")]
	public static class TreeBonusAnimationExt
	{
		// Token: 0x06005FFB RID: 24571 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FFB")]
		[Address(RVA = "0xAC30", Offset = "0xAC30", VA = "0xAC30")]
		public static string GetCrystalAssetId(this TreeBonusAnimation treeBonusAnimation)
		{
		/* --- GHIDRA: GetCrystalAssetId ---
		undefined4
		Core_Extensions_Dict_TreeBonusAnimationExt__GetCrystalAssetId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x30),0x5b,0);
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

		// Token: 0x06005FFC RID: 24572 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FFC")]
		[Address(RVA = "0xAC31", Offset = "0xAC31", VA = "0xAC31")]
		public static string GetDiamondsAssetId(this TreeBonusAnimation treeBonusAnimation)
		{
		/* --- GHIDRA: GetDiamondsAssetId ---
		undefined4
		Core_Extensions_Dict_TreeBonusAnimationExt__GetDiamondsAssetId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x30),0x59,0);
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

		// Token: 0x06005FFD RID: 24573 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FFD")]
		[Address(RVA = "0xAC32", Offset = "0xAC32", VA = "0xAC32")]
		public static string GetEnergyAssetId(this TreeBonusAnimation treeBonusAnimation)
		{
		/* --- GHIDRA: GetEnergyAssetId ---
		undefined4
		Core_Extensions_Dict_TreeBonusAnimationExt__GetEnergyAssetId(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x24),0x2d,0);
		  return uVar1;
		}
		*/

			return null;
		}
	}
}
