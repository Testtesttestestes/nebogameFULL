using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F9C RID: 3996
	[Token(Token = "0x2000F9C")]
	public static class ResourcesDicExt
	{
		// Token: 0x06005FCB RID: 24523 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FCB")]
		[Address(RVA = "0x1DBC", Offset = "0x1DBC", VA = "0x1DBC")]
		public static string GetIcon32AssetId(this ResourcesDic dic)
		{
			return null;
		}

		// Token: 0x06005FCC RID: 24524 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FCC")]
		[Address(RVA = "0x1D5D", Offset = "0x1D5D", VA = "0x1D5D")]
		public static string GetIcon64AssetId(this ResourcesDic dic)
		{
			return null;
		}

		// Token: 0x06005FCD RID: 24525 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FCD")]
		[Address(RVA = "0xAC05", Offset = "0xAC05", VA = "0xAC05")]
		public static string GetIcon256AssetId(this ResourcesDic dic)
		{
		/* --- GHIDRA: GetIcon256AssetId ---
		undefined4 Core_Extensions_Dict_ResourcesDicExt__GetIcon256AssetId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x10),0xbd,0);
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

		// Token: 0x06005FCE RID: 24526 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FCE")]
		[Address(RVA = "0x1AFD", Offset = "0x1AFD", VA = "0x1AFD")]
		public static string GetIconForResourceBar64AssetId(this ResourcesDic dic)
		{
		/* --- GHIDRA: GetIconForResourceBar64AssetId ---
		void Core_Extensions_Dict_ResourcesDicExt__GetIconForResourceBar64AssetId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(*(undefined4 *)(param1 + 0x10),param2,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005FCF RID: 24527 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FCF")]
		[Address(RVA = "0xAC06", Offset = "0xAC06", VA = "0xAC06")]
		public static string GetIconForPriceSpellInCombatAssetId(this ResourcesDic dic)
		{
		/* --- GHIDRA: GetIconForPriceSpellInCombatAssetId ---
		undefined4
		Core_Extensions_Dict_ResourcesDicExt__GetIconForPriceSpellInCombatAssetId
		          (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x14),0x45,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005FD0 RID: 24528 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FD0")]
		[Address(RVA = "0xAC07", Offset = "0xAC07", VA = "0xAC07")]
		public static string GetTitle(this ResourcesDic dic)
		{
		/* --- GHIDRA: GetTitle ---
		undefined4 Core_Extensions_Dict_ResourcesDicExt__GetTitle(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x14),0x46,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005FD1 RID: 24529 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FD1")]
		[Address(RVA = "0xAC08", Offset = "0xAC08", VA = "0xAC08")]
		public static string GetDescription(this ResourcesDic dic)
		{
		/* --- GHIDRA: GetDescription ---
		undefined4 Core_Extensions_Dict_ResourcesDicExt__GetDescription(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x14),0x6d,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005FD2 RID: 24530 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FD2")]
		[Address(RVA = "0xAC09", Offset = "0xAC09", VA = "0xAC09")]
		public static string GetLimitToolTipText(this ResourcesDic dic)
		{
		/* --- GHIDRA: GetLimitToolTipText ---
		undefined4 Core_Extensions_Dict_ResourcesDicExt__GetLimitToolTipText(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x14),0x6e,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005FD3 RID: 24531 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FD3")]
		[Address(RVA = "0xAC0A", Offset = "0xAC0A", VA = "0xAC0A")]
		public static string GetUnlimitToolTipText(this ResourcesDic dic)
		{
		/* --- GHIDRA: GetUnlimitToolTipText ---
		undefined4 Core_Extensions_Dict_ResourcesDicExt__GetUnlimitToolTipText(int param1,undefined4 param2)
		
		{
		  undefined4 *puVar1;
		  
		  if (DAT_ram_00a5a340 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_22048);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22659);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28088);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21419);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22941);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25820);
		    DAT_ram_00a5a340 = '\x01';
		  }
		  if (param1 - 1U < 5) {
		    puVar1 = (undefined4 *)(&PTR_StringLiteral_22048_ram_005a37c4)[param1 - 1U];
		  }
		  else {
		    puVar1 = &StringLiteral_28088;
		  }
		  return *puVar1;
		}
		*/

			return null;
		}
	}
}
