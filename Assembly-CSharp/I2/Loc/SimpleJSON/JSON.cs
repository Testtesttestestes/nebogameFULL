using System;
using Il2CppDummyDll;

namespace I2.Loc.SimpleJSON
{
	// Token: 0x020013C5 RID: 5061
	[Token(Token = "0x20013C5")]
	public static class JSON
	{
		// Token: 0x060078A1 RID: 30881 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60078A1")]
		[Address(RVA = "0xC1F3", Offset = "0xC1F3", VA = "0xC1F3")]
		public static JSONNode Parse(string aJSON)
		{
		/* --- GHIDRA: Parse ---
		void I2_Loc_SimpleJSON_JSON__Parse(undefined4 param1)
		
		{
		  if (DAT_ram_00a54e8a == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16180);
		    DAT_ram_00a54e8a = '\x01';
		  }
		  if (*(int *)(UnityEngine_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Debug_TypeInfo);
		  }
		  Unity_Collections_NativeArray_ContactPairHeader___AsReadOnly(StringLiteral_16180,0);
		  return;
		}
		*/

			return null;
		}
	}
}
