using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Rounting
{
	// Token: 0x02000E80 RID: 3712
	[Token(Token = "0x2000E80")]
	public class LocatorPayload
	{
		// Token: 0x06005A55 RID: 23125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A55")]
		[Address(RVA = "0xA756", Offset = "0xA756", VA = "0xA756")]
		public LocatorPayload(Dictionary<string, string> args, string fragment)
		{
		/* --- GHIDRA: .ctor ---
		int Core_Rounting_LocatorPayload___ctor
		              (int param1,undefined4 param2,int param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a60574 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19458);
		    Mono_Security_ASN1__get_Item(&StringLiteral_284);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12324);
		    DAT_ram_00a60574 = '\x01';
		  }
		  iVar1 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (*(undefined4 *)(param1 + 8),param2,param4,
		                     Method_System_Collections_Generic_Dictionary_string__string__TryGetValue__);
		  if (iVar1 == 0) {
		    param1_00 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,5);
		    *(undefined4 *)(param1_00 + 0x10) = StringLiteral_12324;
		    *(undefined4 *)(param1_00 + 0x14) = *(undefined4 *)(param3 + 8);
		    uVar2 = StringLiteral_19458;
		    *(undefined4 *)(param1_00 + 0x1c) = param2;
		    *(undefined4 *)(param1_00 + 0x18) = uVar2;
		    *(undefined4 *)(param1_00 + 0x20) = StringLiteral_284;
		    uVar2 = System_Single__ToString(param1_00,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7109(uVar2,0);
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x06005A56 RID: 23126 RVA: 0x00010110 File Offset: 0x0000E310
		[Token(Token = "0x6005A56")]
		[Address(RVA = "0xA757", Offset = "0xA757", VA = "0xA757")]
		public bool TryGetRequiredArgValue(string name, AbstractPathNode node, out string value)
		{
		/* --- GHIDRA: TryGetRequiredArgValue ---
		undefined4
		Core_Rounting_LocatorPayload__TryGetRequiredArgValue
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60575 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__TryGetValue__);
		    DAT_ram_00a60575 = '\x01';
		  }
		  uVar1 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (*(undefined4 *)(param1 + 8),param2,param3,
		                     Method_System_Collections_Generic_Dictionary_string__string__TryGetValue__);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005A57 RID: 23127 RVA: 0x00010128 File Offset: 0x0000E328
		[Token(Token = "0x6005A57")]
		[Address(RVA = "0xA758", Offset = "0xA758", VA = "0xA758")]
		public bool TryGetOptionalArgValue(string name, out string value)
		{
		/* --- GHIDRA: TryGetOptionalArgValue ---
		undefined4 Core_Rounting_LocatorPayload__TryGetOptionalArgValue(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60576 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_String_Join_KeyValuePair_string__string____);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1248);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3239);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1236);
		    DAT_ram_00a60576 = '\x01';
		  }
		  uVar1 = System_String__Create___Il2CppFullySharedGenericType_
		                    (StringLiteral_1236,*(undefined4 *)(param1 + 8),
		                     Method_System_String_Join_KeyValuePair_string__string____);
		  uVar1 = System_Int32__ToString
		                    (StringLiteral_3239,uVar1,StringLiteral_1248,*(undefined4 *)(param1 + 0xc),0);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005A58 RID: 23128 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005A58")]
		[Address(RVA = "0xA759", Offset = "0xA759", VA = "0xA759", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400314D RID: 12621
		[Token(Token = "0x400314D")]
		[FieldOffset(Offset = "0x8")]
		public readonly Dictionary<string, string> Args;

		// Token: 0x0400314E RID: 12622
		[Token(Token = "0x400314E")]
		[FieldOffset(Offset = "0xC")]
		public readonly string Fragment;
	}
}
