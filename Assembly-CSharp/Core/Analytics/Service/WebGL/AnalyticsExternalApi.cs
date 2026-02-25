using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Core.Analytics.Service.WebGL
{
	// Token: 0x02001287 RID: 4743
	[Token(Token = "0x2001287")]
	public static class AnalyticsExternalApi
	{
		// Token: 0x060070BB RID: 28859
		[Token(Token = "0x60070BB")]
		[Address(RVA = "0xBAE2", Offset = "0xBAE2", VA = "0xBAE2")]
		[PreserveSig]
		public static extern void LogEvent(string eventName, string eventParameters);

		// Token: 0x060070BC RID: 28860
		[Token(Token = "0x60070BC")]
		[Address(RVA = "0xBAE3", Offset = "0xBAE3", VA = "0xBAE3")]
		[PreserveSig]
		public static extern void SetUserProperty(string eventName, string eventParameters);

		// Token: 0x060070BD RID: 28861
		[Token(Token = "0x60070BD")]
		[Address(RVA = "0xBAE4", Offset = "0xBAE4", VA = "0xBAE4")]
		[PreserveSig]
		public static extern void SetUserPropertyOnce(string property, string value);

		// Token: 0x060070BE RID: 28862
		[Token(Token = "0x60070BE")]
		[Address(RVA = "0xBAE5", Offset = "0xBAE5", VA = "0xBAE5")]
		[PreserveSig]
		public static extern void AddUserProperty(string property, string value);

		// Token: 0x060070BF RID: 28863
		[Token(Token = "0x60070BF")]
		[Address(RVA = "0xBAE6", Offset = "0xBAE6", VA = "0xBAE6")]
		[PreserveSig]
		public static extern void LogRevenue(string productId, string quantity, string price, string eventParameters);
	}
}
