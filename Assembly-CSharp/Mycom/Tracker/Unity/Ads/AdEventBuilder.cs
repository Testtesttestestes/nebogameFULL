using System;
using Il2CppDummyDll;

namespace Mycom.Tracker.Unity.Ads
{
	// Token: 0x0200134D RID: 4941
	[Token(Token = "0x200134D")]
	public sealed class AdEventBuilder
	{
		// Token: 0x0600755E RID: 30046 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600755E")]
		[Address(RVA = "0xBEF2", Offset = "0xBEF2", VA = "0xBEF2")]
		public static AdEventBuilder NewClickBuilder(AdNetworkEnum network)
		{
		/* --- GHIDRA: NewClickBuilder ---
		int Mycom_Tracker_Unity_Ads_AdEventBuilder__NewClickBuilder(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a59710 == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_Ads_AdEventBuilder_TypeInfo);
		    DAT_ram_00a59710 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Mycom_Tracker_Unity_Ads_AdEventBuilder_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x18) = 0;
		  *(undefined8 *)(iVar1 + 0x10) = 0x7ff8000000000000;
		  *(undefined4 *)(iVar1 + 0xc) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0x12;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600755F RID: 30047 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600755F")]
		[Address(RVA = "0xBEF3", Offset = "0xBEF3", VA = "0xBEF3")]
		public static AdEventBuilder NewImpressionBuilder(AdNetworkEnum network)
		{
		/* --- GHIDRA: NewImpressionBuilder ---
		int Mycom_Tracker_Unity_Ads_AdEventBuilder__NewImpressionBuilder
		              (undefined4 param1,double param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a59711 == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_Ads_AdEventBuilder_TypeInfo);
		    DAT_ram_00a59711 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Mycom_Tracker_Unity_Ads_AdEventBuilder_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x18) = param3;
		  *(double *)(iVar1 + 0x10) = param2;
		  *(undefined4 *)(iVar1 + 0xc) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0x13;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06007560 RID: 30048 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007560")]
		[Address(RVA = "0xBEF4", Offset = "0xBEF4", VA = "0xBEF4")]
		public static AdEventBuilder NewRevenueBuilder(AdNetworkEnum network, double revenue, string currency)
		{
		/* --- GHIDRA: NewRevenueBuilder ---
		void Mycom_Tracker_Unity_Ads_AdEventBuilder__NewRevenueBuilder
		               (int param1,undefined4 param2,undefined4 param3,double param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  *(undefined4 *)(param1 + 0x18) = param5;
		  *(double *)(param1 + 0x10) = param4;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  *(undefined4 *)(param1 + 8) = param2;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06007561 RID: 30049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007561")]
		[Address(RVA = "0xBEF5", Offset = "0xBEF5", VA = "0xBEF5")]
		private AdEventBuilder(AppEventEnum appEvent, AdNetworkEnum network, double revenue, string currency)
		{
		}

		// Token: 0x06007562 RID: 30050 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007562")]
		[Address(RVA = "0xBEF6", Offset = "0xBEF6", VA = "0xBEF6")]
		public AdEventBuilder WithSource(string source)
		{
			return null;
		}

		// Token: 0x06007563 RID: 30051 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007563")]
		[Address(RVA = "0xBEF7", Offset = "0xBEF7", VA = "0xBEF7")]
		public AdEventBuilder WithPlacementId(string placementId)
		{
			return null;
		}

		// Token: 0x06007564 RID: 30052 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007564")]
		[Address(RVA = "0xBEF8", Offset = "0xBEF8", VA = "0xBEF8")]
		public AdEventBuilder WithAdId(string adId)
		{
			return null;
		}

		// Token: 0x06007565 RID: 30053 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007565")]
		[Address(RVA = "0xBEF9", Offset = "0xBEF9", VA = "0xBEF9")]
		public AdEventBuilder WithAdFormat(string adFormat)
		{
		/* --- GHIDRA: WithAdFormat ---
		int Mycom_Tracker_Unity_Ads_AdEventBuilder__WithAdFormat(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined8 uVar3;
		  undefined8 uVar4;
		  undefined8 uVar5;
		  undefined8 uVar6;
		  
		  if (DAT_ram_00a59712 == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_Ads_AdEvent_TypeInfo);
		    DAT_ram_00a59712 = '\x01';
		  }
		  uVar3 = *(undefined8 *)(param1 + 8);
		  uVar4 = *(undefined8 *)(param1 + 0x10);
		  uVar5 = *(undefined8 *)(param1 + 0x18);
		  uVar6 = *(undefined8 *)(param1 + 0x20);
		  uVar2 = *(undefined4 *)(param1 + 0x28);
		  iVar1 = unnamed_function_1417(Mycom_Tracker_Unity_Ads_AdEvent_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x28) = uVar2;
		  *(undefined8 *)(iVar1 + 0x20) = uVar6;
		  *(undefined8 *)(iVar1 + 0x18) = uVar5;
		  *(undefined8 *)(iVar1 + 0x10) = uVar4;
		  *(undefined8 *)(iVar1 + 8) = uVar3;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06007566 RID: 30054 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007566")]
		[Address(RVA = "0xBEFA", Offset = "0xBEFA", VA = "0xBEFA")]
		public AdEvent Build()
		{
		/* --- GHIDRA: Build ---
		void Mycom_Tracker_Unity_Ads_AdEventBuilder__Build(undefined4 param1)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a59713 == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_Ads_AdFormat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26467);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25525);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24648);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20465);
		    DAT_ram_00a59713 = '\x01';
		  }
		  **(undefined4 **)(Mycom_Tracker_Unity_Ads_AdFormat_TypeInfo + 0x5c) = StringLiteral_20465;
		  iVar1 = *(int *)(Mycom_Tracker_Unity_Ads_AdFormat_TypeInfo + 0x5c);
		  *(undefined4 *)(iVar1 + 4) = StringLiteral_24648;
		  *(undefined4 *)(iVar1 + 8) = StringLiteral_25525;
		  *(undefined4 *)(iVar1 + 0xc) = StringLiteral_26467;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x04003D48 RID: 15688
		[Token(Token = "0x4003D48")]
		[FieldOffset(Offset = "0x8")]
		private readonly AppEventEnum appEvent;

		// Token: 0x04003D49 RID: 15689
		[Token(Token = "0x4003D49")]
		[FieldOffset(Offset = "0xC")]
		private readonly AdNetworkEnum network;

		// Token: 0x04003D4A RID: 15690
		[Token(Token = "0x4003D4A")]
		[FieldOffset(Offset = "0x10")]
		private readonly double revenue;

		// Token: 0x04003D4B RID: 15691
		[Token(Token = "0x4003D4B")]
		[FieldOffset(Offset = "0x18")]
		private readonly string currency;

		// Token: 0x04003D4C RID: 15692
		[Token(Token = "0x4003D4C")]
		[FieldOffset(Offset = "0x1C")]
		private string source;

		// Token: 0x04003D4D RID: 15693
		[Token(Token = "0x4003D4D")]
		[FieldOffset(Offset = "0x20")]
		private string placementId;

		// Token: 0x04003D4E RID: 15694
		[Token(Token = "0x4003D4E")]
		[FieldOffset(Offset = "0x24")]
		private string adId;

		// Token: 0x04003D4F RID: 15695
		[Token(Token = "0x4003D4F")]
		[FieldOffset(Offset = "0x28")]
		private string adFormat;
	}
}
