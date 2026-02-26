using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Assets.Scripts.Core.Extensions.Dict
{
	// Token: 0x02000E40 RID: 3648
	[Token(Token = "0x2000E40")]
	public static class DollSkillDicExt
	{
		// Token: 0x0600596C RID: 22892 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600596C")]
		[Address(RVA = "0x1DDE", Offset = "0x1DDE", VA = "0x1DDE")]
		public static string GetTitle(this DollSkillDic dic)
		{
		/* --- GHIDRA: GetTitle ---
		undefined4
		Assets_Scripts_Core_Extensions_Dict_DollSkillDicExt__GetTitle(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x10),0x9f,0);
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

		// Token: 0x0600596D RID: 22893 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600596D")]
		[Address(RVA = "0xA69A", Offset = "0xA69A", VA = "0xA69A")]
		public static string GetDescription(this DollSkillDic dic)
		{
		/* --- GHIDRA: GetDescription ---
		undefined4
		Assets_Scripts_Core_Extensions_Dict_DollSkillDicExt__GetDescription
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63c0d == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12609);
		    DAT_ram_00a63c0d = '\x01';
		  }
		  return StringLiteral_12609;
		}
		*/

			return null;
		}

		// Token: 0x0600596E RID: 22894 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600596E")]
		[Address(RVA = "0x1DDF", Offset = "0x1DDF", VA = "0x1DDF")]
		public static string GetIconAssetId(this DollSkillDic dic)
		{
		/* --- GHIDRA: GetIconAssetId ---
		undefined4
		Assets_Scripts_Core_Extensions_Dict_DollSkillDicExt__GetIconAssetId(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param3;
		  longlong lVar2;
		  
		  if (DAT_ram_00a60824 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    Mono_Security_ASN1__get_Item(&StringLiteral_121);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1739);
		    DAT_ram_00a60824 = '\x01';
		  }
		  lVar2 = *(longlong *)(param1 + 0x10);
		  if (lVar2 == 0) {
		    if (*(longlong *)(param1 + 0x18) == 0) {
		      return StringLiteral_1739;
		    }
		    uVar1 = Core_Data_Skills_SkillData__op_Subtraction(param1,param1);
		    return uVar1;
		  }
		  if (*(longlong *)(param1 + 0x18) == 0) {
		    if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_StringUtils_TypeInfo);
		    }
		    uVar1 = UI_SimpleIconValue__set_IconAssetId((double)lVar2,StringLiteral_28780,0);
		    return uVar1;
		  }
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  uVar1 = UI_SimpleIconValue__set_IconAssetId((double)lVar2,StringLiteral_28780,0);
		  param3 = Core_Data_Skills_SkillData__op_Subtraction(param1,param1);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar1,StringLiteral_121,param3,0);
		  return uVar1;
		}
		*/

			return null;
		}
	}
}
