using System;
using Il2CppDummyDll;

namespace Core.Rounting
{
	// Token: 0x02000E7B RID: 3707
	[Token(Token = "0x2000E7B")]
	public class HttpLocator : ILocator, IDisposable
	{
		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x06005A48 RID: 23112 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001264")]
		public string[] Schemes
		{
			[Token(Token = "0x6005A48")]
			[Address(RVA = "0xA750", Offset = "0xA750", VA = "0xA750", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x06005A49 RID: 23113 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001265")]
		public string Host
		{
			[Token(Token = "0x6005A49")]
			[Address(RVA = "0xA751", Offset = "0xA751", VA = "0xA751", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005A4A RID: 23114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A4A")]
		[Address(RVA = "0xA752", Offset = "0xA752", VA = "0xA752", Slot = "7")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		undefined4 Core_Rounting_HttpLocator__Dispose(undefined4 param1,int *param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a60572 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_19433);
		    DAT_ram_00a60572 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xd8) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0xdc));
		  Core_ExternAppMethods__OpenPaymentWindow(param1_00,StringLiteral_19433,0,0);
		  return 1;
		}
		*/

		}

		// Token: 0x06005A4B RID: 23115 RVA: 0x000100F8 File Offset: 0x0000E2F8
		[Token(Token = "0x6005A4B")]
		[Address(RVA = "0xA753", Offset = "0xA753", VA = "0xA753", Slot = "6")]
		public bool TryExecute(Uri uri)
		{
		/* --- GHIDRA: TryExecute ---
		undefined4 Core_Rounting_HttpLocator__TryExecute(undefined4 param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60573 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_14086);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1253);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1236);
		    DAT_ram_00a60573 = '\x01';
		  }
		  if (DAT_ram_00a60571 == '\0') {
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Uri_TypeInfo);
		    DAT_ram_00a60571 = '\x01';
		  }
		  param2_00 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,2);
		  if (*(int *)(System_Uri_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Uri_TypeInfo);
		  }
		  *(undefined4 *)(param2_00 + 0x10) = *(undefined4 *)(*(int *)(System_Uri_TypeInfo + 0x5c) + 0xc);
		  *(undefined4 *)(param2_00 + 0x14) = *(undefined4 *)(*(int *)(System_Uri_TypeInfo + 0x5c) + 0x10);
		  uVar1 = UnityEngine_Assertions_Assert__IsFalse(StringLiteral_1236,param2_00,0);
		  uVar1 = System_Int32__ToString(StringLiteral_14086,uVar1,StringLiteral_1253,0,0);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005A4C RID: 23116 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005A4C")]
		[Address(RVA = "0xA754", Offset = "0xA754", VA = "0xA754", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005A4D RID: 23117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A4D")]
		[Address(RVA = "0xA755", Offset = "0xA755", VA = "0xA755")]
		public HttpLocator()
		{
		}
	}
}
