using System;
using Il2CppDummyDll;

namespace Gameplay.Billing.Model.PurchasePayload
{
	// Token: 0x02000BF3 RID: 3059
	[Token(Token = "0x2000BF3")]
	[Serializable]
	public class DeveloperPayloadId
	{
		// Token: 0x06004B08 RID: 19208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B08")]
		[Address(RVA = "0x9965", Offset = "0x9965", VA = "0x9965")]
		public DeveloperPayloadId()
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_Billing_Model_PurchasePayload_DeveloperPayloadId___ctor
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a60928 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a60928 = '\x01';
		  }
		  iVar1 = UI_Preloader_PreloaderBackgroundLoader_PreloaderBackgroundDto___ctor(param1,0);
		  if (iVar1 == 0) {
		    iVar1 = StringLiteral_5;
		  }
		  return iVar1;
		}
		*/

		/* --- GHIDRA: .ctor ---
		int Gameplay_Billing_Model_PurchasePayload_DeveloperPayloadId___ctor
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a60928 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a60928 = '\x01';
		  }
		  iVar1 = UI_Preloader_PreloaderBackgroundLoader_PreloaderBackgroundDto___ctor(param1,0);
		  if (iVar1 == 0) {
		    iVar1 = StringLiteral_5;
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x06004B09 RID: 19209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B09")]
		[Address(RVA = "0x9966", Offset = "0x9966", VA = "0x9966")]
		public DeveloperPayloadId(string id, string platform)
		{
		}

		// Token: 0x06004B0A RID: 19210 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004B0A")]
		[Address(RVA = "0x9967", Offset = "0x9967", VA = "0x9967", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040028D3 RID: 10451
		[Token(Token = "0x40028D3")]
		[FieldOffset(Offset = "0x8")]
		public string id;

		// Token: 0x040028D4 RID: 10452
		[Token(Token = "0x40028D4")]
		[FieldOffset(Offset = "0xC")]
		public string p;
	}
}
