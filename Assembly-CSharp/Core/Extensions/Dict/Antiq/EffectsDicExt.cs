using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict.Antiq
{
	// Token: 0x02000FB6 RID: 4022
	[Token(Token = "0x2000FB6")]
	public static class EffectsDicExt
	{
		// Token: 0x0600601E RID: 24606 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600601E")]
		[Address(RVA = "0xAC4F", Offset = "0xAC4F", VA = "0xAC4F")]
		public static string GetMessage(this Antiq.Types.EffectsDic dict, Antiq.Types.EffectsDic.Types.ContentString type)
		{
		/* --- GHIDRA: GetMessage ---
		undefined4 Core_Extensions_Dict_Antiq_EffectsDicExt__GetMessage(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x28),0xd0,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600601F RID: 24607 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600601F")]
		[Address(RVA = "0xAC50", Offset = "0xAC50", VA = "0xAC50")]
		public static string GetTitle(this Antiq.Types.EffectsDic dict)
		{
		/* --- GHIDRA: GetTitle ---
		undefined4
		Core_Extensions_Dict_Antiq_EffectsDicExt__GetTitle(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x24),param2,0);
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

		// Token: 0x06006020 RID: 24608 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006020")]
		[Address(RVA = "0x2A45", Offset = "0x2A45", VA = "0x2A45")]
		public static string GetCombatText(this Antiq.Types.EffectsDic dict)
		{
		/* --- GHIDRA: GetCombatText ---
		void Core_Extensions_Dict_Antiq_EffectsDicExt__GetCombatText
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  *(undefined4 *)(param1 + 0x14) = param4;
		  *(undefined4 *)(param1 + 0x18) = param2;
		  *(undefined4 *)(param1 + 0x20) = param6;
		  *(undefined4 *)(param1 + 0x10) = param5;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06006021 RID: 24609 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006021")]
		[Address(RVA = "0xAC51", Offset = "0xAC51", VA = "0xAC51")]
		public static string GetAssetId(this Antiq.Types.EffectsDic effectDic, Antiq.Types.EffectsDic.Types.ContentResource contentResourceId)
		{
		/* --- GHIDRA: GetAssetId ---
		undefined4 Core_Extensions_Dict_Antiq_EffectsDicExt__GetAssetId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x24),0xe8,0);
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

		// Token: 0x06006022 RID: 24610 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006022")]
		[Address(RVA = "0x2A43", Offset = "0x2A43", VA = "0x2A43")]
		public static string GetCombatAnimation(this Antiq.Types.EffectsDic dict)
		{
		/* --- GHIDRA: GetCombatAnimation ---
		undefined4
		Core_Extensions_Dict_Antiq_EffectsDicExt__GetCombatAnimation(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x24),0xe9,0);
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

		// Token: 0x06006023 RID: 24611 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006023")]
		[Address(RVA = "0xAC52", Offset = "0xAC52", VA = "0xAC52")]
		public static string GetCombatAnimationCanvas(this Antiq.Types.EffectsDic dict)
		{
			return null;
		}

		// Token: 0x06006024 RID: 24612 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006024")]
		[Address(RVA = "0x2A44", Offset = "0x2A44", VA = "0x2A44")]
		public static string GetCombatSound(this Antiq.Types.EffectsDic dict)
		{
		/* --- GHIDRA: GetCombatSound ---
		undefined4 Core_Extensions_Dict_Antiq_EffectsDicExt__GetCombatSound(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x28),0xd5,0);
		  return uVar1;
		}
		*/

			return null;
		}
	}
}
