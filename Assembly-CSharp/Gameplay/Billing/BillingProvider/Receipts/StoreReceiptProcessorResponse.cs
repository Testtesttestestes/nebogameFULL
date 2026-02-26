using System;
using Il2CppDummyDll;

namespace Gameplay.Billing.BillingProvider.Receipts
{
	// Token: 0x02000C15 RID: 3093
	[Token(Token = "0x2000C15")]
	public class StoreReceiptProcessorResponse
	{
		// Token: 0x06004BB1 RID: 19377 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004BB1")]
		[Address(RVA = "0x99F7", Offset = "0x99F7", VA = "0x99F7", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004BB2 RID: 19378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BB2")]
		[Address(RVA = "0x99F8", Offset = "0x99F8", VA = "0x99F8")]
		public StoreReceiptProcessorResponse()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Billing_BillingProvider_Receipts_StoreReceiptProcessorResponse___ctor
		          (int param1,undefined4 param2)
		
		{
		  int *param2_00;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  float4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a60958 == '\0') {
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20453);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22980);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22113);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28695);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25362);
		    DAT_ram_00a60958 = '\x01';
		  }
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,8);
		  if (StringLiteral_22980 == 0) {
		    iVar1 = 0;
		  }
		  else {
		    iVar2 = func_ii_1082(StringLiteral_22980,*(undefined4 *)(*param2_00 + 0x20));
		    iVar1 = StringLiteral_22980;
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
		  iVar1 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0))
		  {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[5] = iVar1;
		  if (StringLiteral_22113 == 0) {
		    iVar1 = 0;
		  }
		  else {
		    iVar2 = func_ii_1082(StringLiteral_22113,*(undefined4 *)(*param2_00 + 0x20));
		    iVar1 = StringLiteral_22113;
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
		  if (StringLiteral_20453 == 0) {
		    iVar1 = 0;
		  }
		  else {
		    iVar2 = func_ii_1082(StringLiteral_20453,*(undefined4 *)(*param2_00 + 0x20));
		    iVar1 = StringLiteral_20453;
		    if (iVar2 == 0) {
		      uVar3 = func_ii_1083();
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param2_00[8] = iVar1;
		  local_8 = *(float4 *)(param1 + 0x10);
		  iVar1 = func_ii_1081(DAT_ram_00a6696c,&local_8);
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0))
		  {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[9] = iVar1;
		  if (StringLiteral_25362 == 0) {
		    iVar1 = 0;
		  }
		  else {
		    iVar2 = func_ii_1082(StringLiteral_25362,*(undefined4 *)(*param2_00 + 0x20));
		    iVar1 = StringLiteral_25362;
		    if (iVar2 == 0) {
		      uVar3 = func_ii_1083();
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param2_00[10] = iVar1;
		  iVar1 = *(int *)(param1 + 0x14);
		  if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*param2_00 + 0x20)), iVar2 == 0))
		  {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[0xb] = iVar1;
		  uVar3 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                    (StringLiteral_28695,param2_00,0);
		  return uVar3;
		}
		*/

		}

		// Token: 0x0400291F RID: 10527
		[Token(Token = "0x400291F")]
		[FieldOffset(Offset = "0x8")]
		public StoreReceiptProcessorResponse.Errors error_code;

		// Token: 0x04002920 RID: 10528
		[Token(Token = "0x4002920")]
		[FieldOffset(Offset = "0xC")]
		public string error_msg;

		// Token: 0x02000C16 RID: 3094
		[Token(Token = "0x2000C16")]
		public enum Errors
		{
			// Token: 0x04002922 RID: 10530
			[Token(Token = "0x4002922")]
			Success,
			// Token: 0x04002923 RID: 10531
			[Token(Token = "0x4002923")]
			Fail,
			// Token: 0x04002924 RID: 10532
			[Token(Token = "0x4002924")]
			Internal
		}
	}
}
