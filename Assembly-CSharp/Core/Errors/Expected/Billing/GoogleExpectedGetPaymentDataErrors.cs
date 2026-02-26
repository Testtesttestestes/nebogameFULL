using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Billing
{
	// Token: 0x0200108E RID: 4238
	[Token(Token = "0x200108E")]
	public class GoogleExpectedGetPaymentDataErrors : ExpectedGetPaymentDataErrors
	{
		// Token: 0x060062AF RID: 25263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062AF")]
		[Address(RVA = "0xAED4", Offset = "0xAED4", VA = "0xAED4", Slot = "5")]
		protected override void LogUnhandledError(ExpectedGetPaymentDataErrors.ExpectedGetPaymentDataErrorsArgs args)
		{
		}

		// Token: 0x060062B0 RID: 25264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062B0")]
		[Address(RVA = "0xAED5", Offset = "0xAED5", VA = "0xAED5")]
		public GoogleExpectedGetPaymentDataErrors()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Errors_Expected_Billing_GoogleExpectedGetPaymentDataErrors___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 param5;
		  undefined4 param3_00;
		  undefined4 param6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a60739 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_BillingScope_BuyOptionErrorEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28677);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24324);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8586);
		    DAT_ram_00a60739 = '\x01';
		  }
		  local_4 = *(undefined4 *)(*(int *)(param2 + 0xc) + 0x10);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28677,StringLiteral_8586,uVar2,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  uVar1 = 0;
		  func_ii_7109(uVar2,0);
		  piVar4 = *(int **)(param2 + 8);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x81cd7e1f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81cd7e1f:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x100);
		        goto code_r0x81cd7ea1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,8);
		code_r0x81cd7ea1:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  iVar5 = *(int *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x20) + 0x28);
		  if (iVar5 != 0) {
		    uVar1 = 0;
		    piVar4 = *(int **)(param2 + 8);
		    iVar6 = *piVar4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe0);
		          goto code_r0x81cd7f2d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81cd7f2d:
		    uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    param5 = *(undefined4 *)(param2 + 0x10);
		    param3_00 = *(undefined4 *)(param2 + 8);
		    param6 = *(undefined4 *)(*(int *)(param2 + 0xc) + 0x10);
		    iVar6 = unnamed_function_1417(Core_Events_Scopes_BillingScope_BuyOptionErrorEventArgs_TypeInfo);
		    Core_Events_Scopes_BillingScope_BuyOptionErrorEventArgs__set_ErrorCode
		              (iVar6,uVar2,param3_00,3,param5,param6,StringLiteral_24324,0);
		    *(undefined4 *)(iVar6 + 0x1c) = *(undefined4 *)(*(int *)(param2 + 0xc) + 0xc);
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		              (*(undefined4 *)(iVar5 + 0x20),iVar6,*(undefined4 *)(iVar5 + 0x14));
		  }
		  return;
		}
		*/

		}
	}
}
