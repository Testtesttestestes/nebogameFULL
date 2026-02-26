using System;
using Il2CppDummyDll;
using UnityEngine.Purchasing;

namespace Gameplay.Billing.BillingProvider.UnityIAP
{
	// Token: 0x02000C09 RID: 3081
	[Token(Token = "0x2000C09")]
	public class InitializationFailureData
	{
		// Token: 0x06004B6F RID: 19311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B6F")]
		[Address(RVA = "0x99BE", Offset = "0x99BE", VA = "0x99BE")]
		public InitializationFailureData(InitializationFailureReason reason, string details)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Billing_BillingProvider_UnityIAP_InitializationFailureData___ctor
		          (int param1,undefined4 param2)
		
		{
		  int *param2_00;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a6093c == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Purchasing_InitializationFailureReason_TypeInfo);
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28692);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6505);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13370);
		    DAT_ram_00a6093c = '\x01';
		  }
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,4);
		  if (StringLiteral_13370 == 0) {
		    iVar1 = 0;
		  }
		  else {
		    iVar2 = func_ii_1082(StringLiteral_13370,*(undefined4 *)(*param2_00 + 0x20));
		    iVar1 = StringLiteral_13370;
		    if (iVar2 == 0) {
		      uVar3 = func_ii_1083();
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param2_00[4] = iVar1;
		  local_4 = *(undefined4 *)(param1 + 8);
		  iVar1 = func_ii_1081(UnityEngine_Purchasing_InitializationFailureReason_TypeInfo,&local_4);
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0))
		  {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[5] = iVar1;
		  if (StringLiteral_6505 == 0) {
		    iVar1 = 0;
		  }
		  else {
		    iVar2 = func_ii_1082(StringLiteral_6505,*(undefined4 *)(*param2_00 + 0x20));
		    iVar1 = StringLiteral_6505;
		    if (iVar2 == 0) {
		      uVar3 = func_ii_1083();
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param2_00[6] = iVar1;
		  iVar1 = *(int *)(param1 + 0xc);
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0))
		  {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[7] = iVar1;
		  uVar3 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                    (StringLiteral_28692,param2_00,0);
		  return uVar3;
		}
		*/

		}

		// Token: 0x06004B70 RID: 19312 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004B70")]
		[Address(RVA = "0x99BF", Offset = "0x99BF", VA = "0x99BF", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040028FE RID: 10494
		[Token(Token = "0x40028FE")]
		[FieldOffset(Offset = "0x8")]
		public readonly InitializationFailureReason Reason;

		// Token: 0x040028FF RID: 10495
		[Token(Token = "0x40028FF")]
		[FieldOffset(Offset = "0xC")]
		public readonly string Details;
	}
}
