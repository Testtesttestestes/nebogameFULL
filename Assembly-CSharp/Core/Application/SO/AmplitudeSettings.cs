using System;
using Il2CppDummyDll;

namespace Core.Application.SO
{
	// Token: 0x0200123C RID: 4668
	[Token(Token = "0x200123C")]
	[Serializable]
	public class AmplitudeSettings
	{
		// Token: 0x06006EC3 RID: 28355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EC3")]
		[Address(RVA = "0xB941", Offset = "0xB941", VA = "0xB941")]
		public AmplitudeSettings()
		{
		/* --- GHIDRA: .ctor ---
		int Core_Application_SO_AmplitudeSettings___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int param1_01;
		  int iVar3;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a5a804 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_AmplitudeSettings___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_477);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3045);
		    DAT_ram_00a5a804 = '\x01';
		  }
		  param1_01 = *(int *)(param1 + 0x2c);
		  if (0 < *(int *)(param1_01 + 0xc)) {
		    do {
		      iVar3 = *(int *)(param1_01 + iVar2 * 4 + 0x10);
		      iVar1 = System_Collections_CollectionBase___ctor(*(undefined4 *)(iVar3 + 8),param2,0);
		      if (iVar1 != 0) {
		        return iVar3;
		      }
		      iVar2 = iVar2 + 1;
		    } while (iVar2 < *(int *)(param1_01 + 0xc));
		    param1_01 = *(int *)(param1 + 0x2c);
		  }
		  iVar2 = System_Linq_Enumerable__Count_object_
		                    (param1_01,Method_System_Linq_Enumerable_First_AmplitudeSettings___);
		  param1_00 = System_Int32__ToString
		                        (StringLiteral_3045,param2,StringLiteral_477,*(undefined4 *)(iVar2 + 8),0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  func_ii_7830(param1_00,0);
		  return iVar2;
		}
		*/

		}

		// Token: 0x040039DB RID: 14811
		[Token(Token = "0x40039DB")]
		[FieldOffset(Offset = "0x8")]
		public string Server;

		// Token: 0x040039DC RID: 14812
		[Token(Token = "0x40039DC")]
		[FieldOffset(Offset = "0xC")]
		public string ApiKey;

		// Token: 0x040039DD RID: 14813
		[Token(Token = "0x40039DD")]
		[FieldOffset(Offset = "0x10")]
		public bool UserDynamicConfig;
	}
}
