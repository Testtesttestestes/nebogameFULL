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

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: LogEvent ---
		void Core_Analytics_Service_WebGL_AnalyticsExternalApi__LogEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  param1_00 = unnamed_function_1428(param1);
		  param2_00 = unnamed_function_1428(param2);
		  import::env::SetUserProperty(param1_00,param2_00);
		  unnamed_function_1427(param1_00);
		  unnamed_function_1427(param2_00);
		  return;
		}
		*/


		/* --- GHIDRA: SetUserProperty ---
		void Core_Analytics_Service_WebGL_AnalyticsExternalApi__SetUserProperty
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  param1_00 = unnamed_function_1428(param1);
		  param2_00 = unnamed_function_1428(param2);
		  import::env::SetUserPropertyOnce(param1_00,param2_00);
		  unnamed_function_1427(param1_00);
		  unnamed_function_1427(param2_00);
		  return;
		}
		*/


		/* --- GHIDRA: SetUserPropertyOnce ---
		void Core_Analytics_Service_WebGL_AnalyticsExternalApi__SetUserPropertyOnce
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  param1_00 = unnamed_function_1428(param1);
		  param2_00 = unnamed_function_1428(param2);
		  import::env::AddUserProperty(param1_00,param2_00);
		  unnamed_function_1427(param1_00);
		  unnamed_function_1427(param2_00);
		  return;
		}
		*/


		/* --- GHIDRA: AddUserProperty ---
		void Core_Analytics_Service_WebGL_AnalyticsExternalApi__AddUserProperty
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  undefined4 param4_00;
		  
		  param1_00 = unnamed_function_1428(param1);
		  param2_00 = unnamed_function_1428(param2);
		  param3_00 = unnamed_function_1428(param3);
		  param4_00 = unnamed_function_1428(param4);
		  import::env::LogRevenue(param1_00,param2_00,param3_00,param4_00);
		  unnamed_function_1427(param1_00);
		  unnamed_function_1427(param2_00);
		  unnamed_function_1427(param3_00);
		  unnamed_function_1427(param4_00);
		  return;
		}
		*/


		/* --- GHIDRA: LogRevenue ---
		void Core_Analytics_Service_WebGL_AnalyticsExternalApi__LogRevenue
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a8c1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Type__IAnalyticsService___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_Type__IAnalyticsService__TypeInfo);
		    DAT_ram_00a5a8c1 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_Type__IAnalyticsService__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_Type__IAnalyticsService___ctor__
		            );
		  *(undefined4 *)(param1 + 0x14) = param1_00;
		  *(undefined4 *)(param1 + 0x10) = param4;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  *(undefined4 *)(param1 + 8) = param2;
		  return;
		}
		*/

}
