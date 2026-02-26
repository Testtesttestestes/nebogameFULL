using System;
using Il2CppDummyDll;

namespace Mycom.Tracker.Unity.Ads
{
	// Token: 0x0200134C RID: 4940
	[Token(Token = "0x200134C")]
	public sealed class AdEvent : MyTrackerEvent
	{
		// Token: 0x0600755D RID: 30045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600755D")]
		[Address(RVA = "0xBEF1", Offset = "0xBEF1", VA = "0xBEF1")]
		internal AdEvent(AppEventEnum appEvent, AdNetworkEnum network, double revenue, string currency, string source, string placementId, string adId, string adFormat)
		{
		/* --- GHIDRA: .ctor ---
		int Mycom_Tracker_Unity_Ads_AdEvent___ctor(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5970f == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_Ads_AdEventBuilder_TypeInfo);
		    DAT_ram_00a5970f = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Mycom_Tracker_Unity_Ads_AdEventBuilder_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x18) = 0;
		  *(undefined8 *)(iVar1 + 0x10) = 0x7ff8000000000000;
		  *(undefined4 *)(iVar1 + 0xc) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0x11;
		  return iVar1;
		}
		*/

		}

		// Token: 0x04003D41 RID: 15681
		[Token(Token = "0x4003D41")]
		[FieldOffset(Offset = "0xC")]
		public readonly AdNetworkEnum network;

		// Token: 0x04003D42 RID: 15682
		[Token(Token = "0x4003D42")]
		[FieldOffset(Offset = "0x10")]
		public readonly double revenue;

		// Token: 0x04003D43 RID: 15683
		[Token(Token = "0x4003D43")]
		[FieldOffset(Offset = "0x18")]
		public readonly string currency;

		// Token: 0x04003D44 RID: 15684
		[Token(Token = "0x4003D44")]
		[FieldOffset(Offset = "0x1C")]
		public readonly string source;

		// Token: 0x04003D45 RID: 15685
		[Token(Token = "0x4003D45")]
		[FieldOffset(Offset = "0x20")]
		public readonly string placementId;

		// Token: 0x04003D46 RID: 15686
		[Token(Token = "0x4003D46")]
		[FieldOffset(Offset = "0x24")]
		public readonly string adId;

		// Token: 0x04003D47 RID: 15687
		[Token(Token = "0x4003D47")]
		[FieldOffset(Offset = "0x28")]
		public readonly string adFormat;
	}
}
