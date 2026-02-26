using System;
using Il2CppDummyDll;

namespace Gameplay.Billing.Model.PurchasePayload
{
	// Token: 0x02000BF2 RID: 3058
	[Token(Token = "0x2000BF2")]
	[Serializable]
	public class DeveloperPayload
	{
		// Token: 0x06004B03 RID: 19203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B03")]
		[Address(RVA = "0x9960", Offset = "0x9960", VA = "0x9960")]
		public DeveloperPayload(string raw)
		{
		/* --- GHIDRA: .ctor ---
		undefined8
		Gameplay_Billing_Model_PurchasePayload_DeveloperPayload___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a60926 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_JsonUtility_FromJson_PayloadContent___);
		    DAT_ram_00a60926 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 8);
		  if (iVar1 == 0) {
		    iVar1 = func_ii_5995(*(undefined4 *)(param1 + 0xc),
		                         Method_UnityEngine_JsonUtility_FromJson_PayloadContent___);
		    *(int *)(param1 + 8) = iVar1;
		  }
		  return *(undefined8 *)(*(int *)(*(int *)(iVar1 + 8) + 0x10) + 8);
		}
		*/

		}

		// Token: 0x06004B04 RID: 19204 RVA: 0x0000DE30 File Offset: 0x0000C030
		[Token(Token = "0x6004B04")]
		[Address(RVA = "0x9961", Offset = "0x9961", VA = "0x9961")]
		public ulong GetOptionId()
		{
		/* --- GHIDRA: GetOptionId ---
		undefined8
		Gameplay_Billing_Model_PurchasePayload_DeveloperPayload__GetOptionId(int param1,undefined4 param2)
		
		{
		  undefined8 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a60925 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    DAT_ram_00a60925 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  if (DAT_ram_00a60926 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_JsonUtility_FromJson_PayloadContent___);
		    DAT_ram_00a60926 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 8);
		  if (iVar2 == 0) {
		    iVar2 = func_ii_5995(*(undefined4 *)(param1 + 0xc),
		                         Method_UnityEngine_JsonUtility_FromJson_PayloadContent___);
		    *(int *)(param1 + 8) = iVar2;
		  }
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 8) + 0x10) + 0x10);
		  if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTimeOffset_TypeInfo);
		  }
		  iVar2 = System_DateTimeOffset__ToUniversalTime(uVar3,&local_10,0);
		  if (iVar2 != 0) {
		    if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_DateTimeOffset_TypeInfo);
		    }
		    uVar1 = System_DateTimeOffset__get_UtcNow(&local_10,0);
		    return uVar1;
		  }
		  uVar4 = *(undefined4 *)(param1 + 0xc);
		  uVar3 = unnamed_function_2232(&StringLiteral_27729);
		  uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar3,uVar4,0);
		  uVar4 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar4 = unnamed_function_1417(uVar4);
		  System_String__Concat(uVar4,uVar3,0);
		  uVar3 = unnamed_function_2232
		                    (&Method_Gameplay_Billing_Model_PurchasePayload_DeveloperPayload_GetTimestamp__)
		  ;
		  func_ii_1050(uVar4,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return 0UL;
		}

		// Token: 0x06004B05 RID: 19205 RVA: 0x0000DE48 File Offset: 0x0000C048
		[Token(Token = "0x6004B05")]
		[Address(RVA = "0x9962", Offset = "0x9962", VA = "0x9962")]
		public long GetTimestamp()
		{
		/* --- GHIDRA: GetTimestamp ---
		int Gameplay_Billing_Model_PurchasePayload_DeveloperPayload__GetTimestamp
		              (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a60926 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_JsonUtility_FromJson_PayloadContent___);
		    DAT_ram_00a60926 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 8);
		  if (iVar1 == 0) {
		    iVar1 = func_ii_5995(*(undefined4 *)(param1 + 0xc),
		                         Method_UnityEngine_JsonUtility_FromJson_PayloadContent___);
		    *(int *)(param1 + 8) = iVar1;
		  }
		  return iVar1;
		}
		*/

			return 0L;
		}

		// Token: 0x06004B06 RID: 19206 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004B06")]
		[Address(RVA = "0x9963", Offset = "0x9963", VA = "0x9963")]
		public PayloadContent GetPayload()
		{
		/* --- GHIDRA: GetPayload ---
		undefined4
		Gameplay_Billing_Model_PurchasePayload_DeveloperPayload__GetPayload(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60927 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_13336);
		    DAT_ram_00a60927 = '\x01';
		  }
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor
		                    (StringLiteral_13336,*(undefined4 *)(param1 + 0xc),0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06004B07 RID: 19207 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004B07")]
		[Address(RVA = "0x9964", Offset = "0x9964", VA = "0x9964", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040028D1 RID: 10449
		[Token(Token = "0x40028D1")]
		[FieldOffset(Offset = "0x8")]
		private PayloadContent _payloadContent;

		// Token: 0x040028D2 RID: 10450
		[Token(Token = "0x40028D2")]
		[FieldOffset(Offset = "0xC")]
		public string Raw;
	}
}
