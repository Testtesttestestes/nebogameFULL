using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000FAF RID: 4015
	[Token(Token = "0x2000FAF")]
	public static class UserRatingKindDicExt
	{
		// Token: 0x0600600C RID: 24588 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600600C")]
		[Address(RVA = "0x1C6C", Offset = "0x1C6C", VA = "0x1C6C")]
		public static string GetIcon32AssetId(this UserRatingKindDic dic)
		{
		/* --- GHIDRA: GetIcon32AssetId ---
		void Core_Extensions_Dict_UserRatingKindDicExt__GetIcon32AssetId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(*(undefined4 *)(param1 + 0x24),param2,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600600D RID: 24589 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600600D")]
		[Address(RVA = "0xAC41", Offset = "0xAC41", VA = "0xAC41")]
		public static string GetIcon256AssetId(this UserRatingKindDic dic)
		{
		/* --- GHIDRA: GetIcon256AssetId ---
		undefined4
		Core_Extensions_Dict_UserRatingKindDicExt__GetIcon256AssetId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x14),0x38,0);
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

		// Token: 0x0600600E RID: 24590 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600600E")]
		[Address(RVA = "0xAC42", Offset = "0xAC42", VA = "0xAC42")]
		public static string GetButton128AssetId(this UserRatingKindDic dic)
		{
		/* --- GHIDRA: GetButton128AssetId ---
		undefined4
		Core_Extensions_Dict_UserRatingKindDicExt__GetButton128AssetId(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x18),0x14,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600600F RID: 24591 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600600F")]
		[Address(RVA = "0x1C6A", Offset = "0x1C6A", VA = "0x1C6A")]
		public static string GetTitle(this UserRatingKindDic dic)
		{
		/* --- GHIDRA: GetTitle ---
		void Core_Extensions_Dict_UserRatingKindDicExt__GetTitle
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a598e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_2003);
		    DAT_ram_00a598e9 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x1c);
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(param2,StringLiteral_2003,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06006010 RID: 24592 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006010")]
		[Address(RVA = "0xAC43", Offset = "0xAC43", VA = "0xAC43")]
		public static string GetDescription(this UserRatingKindDic dic)
		{
		/* --- GHIDRA: GetDescription ---
		undefined4 Core_Extensions_Dict_UserRatingKindDicExt__GetDescription(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x20),7,0);
		  return uVar1;
		}
		*/

			return null;
		}
	}
}
