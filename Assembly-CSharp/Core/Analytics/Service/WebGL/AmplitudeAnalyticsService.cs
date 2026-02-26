using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Analytics.Service.WebGL
{
	// Token: 0x02001286 RID: 4742
	[Token(Token = "0x2001286")]
	public class AmplitudeAnalyticsService : IAnalyticsService, IAnalyticsApi, IDisposable
	{
		// Token: 0x060070B3 RID: 28851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070B3")]
		[Address(RVA = "0xBADA", Offset = "0xBADA", VA = "0xBADA", Slot = "4")]
		public void Init(string userId, string serverName, IDeviceIDProvider deviceIdProvider)
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Service_WebGL_AmplitudeAnalyticsService__Init
		               (undefined4 param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param3 + 0xd8) * 4))
		                    (param3,*(undefined4 *)(*param3 + 0xdc));
		  param1_00 = unnamed_function_1428(param2);
		  uVar1 = unnamed_function_1428(uVar1);
		  import::env::SetUserPropertyOnce(param1_00,uVar1);
		  unnamed_function_1427(param1_00);
		  unnamed_function_1427(uVar1);
		  return;
		}
		*/

		}

		// Token: 0x060070B4 RID: 28852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070B4")]
		[Address(RVA = "0xBADB", Offset = "0xBADB", VA = "0xBADB", Slot = "5")]
		public void SetUserPropertyOnce(string property, object value)
		{
		/* --- GHIDRA: SetUserPropertyOnce ---
		void Core_Analytics_Service_WebGL_AmplitudeAnalyticsService__SetUserPropertyOnce
		               (undefined4 param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param3 + 0xd8) * 4))
		                    (param3,*(undefined4 *)(*param3 + 0xdc));
		  param1_00 = unnamed_function_1428(param2);
		  uVar1 = unnamed_function_1428(uVar1);
		  import::env::SetUserProperty(param1_00,uVar1);
		  unnamed_function_1427(param1_00);
		  unnamed_function_1427(uVar1);
		  return;
		}
		*/

		}

		// Token: 0x060070B5 RID: 28853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070B5")]
		[Address(RVA = "0xBADC", Offset = "0xBADC", VA = "0xBADC", Slot = "6")]
		public void SetUserProperty(string property, object value)
		{
		/* --- GHIDRA: SetUserProperty ---
		void Core_Analytics_Service_WebGL_AmplitudeAnalyticsService__SetUserProperty
		               (undefined4 param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param3 + 0xd8) * 4))
		                    (param3,*(undefined4 *)(*param3 + 0xdc));
		  param1_00 = unnamed_function_1428(param2);
		  uVar1 = unnamed_function_1428(uVar1);
		  import::env::AddUserProperty(param1_00,uVar1);
		  unnamed_function_1427(param1_00);
		  unnamed_function_1427(uVar1);
		  return;
		}
		*/

		}

		// Token: 0x060070B6 RID: 28854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070B6")]
		[Address(RVA = "0xBADD", Offset = "0xBADD", VA = "0xBADD", Slot = "7")]
		public void AddUserProperty(string property, object value)
		{
		/* --- GHIDRA: AddUserProperty ---
		void Core_Analytics_Service_WebGL_AmplitudeAnalyticsService__AddUserProperty
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5a8c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_19096);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19805);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27884);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18830);
		    DAT_ram_00a5a8c6 = '\x01';
		  }
		  iVar1 = System_Collections_CollectionBase___ctor(param2,StringLiteral_19805,0);
		  if ((iVar1 == 0) ||
		     (iVar1 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                        (param3,StringLiteral_27884,0), iVar1 == 0)) {
		    uVar2 = System_Int32__ToString(StringLiteral_18830,param2,StringLiteral_19096,param3,0);
		    uVar3 = AmplitudeNS_MiniJSON_Json__Deserialize(param4,0);
		    uVar2 = unnamed_function_1428(uVar2);
		    uVar3 = unnamed_function_1428(uVar3);
		    import::env::LogEvent(uVar2,uVar3);
		    unnamed_function_1427(uVar2);
		    unnamed_function_1427(uVar3);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060070B7 RID: 28855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070B7")]
		[Address(RVA = "0xBADE", Offset = "0xBADE", VA = "0xBADE", Slot = "8")]
		public void LogEvent(string eventTheme, string eventName, IDictionary<string, object> properties)
		{
		/* --- GHIDRA: LogEvent ---
		void Core_Analytics_Service_WebGL_AmplitudeAnalyticsService__LogEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,double param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  float8 local_10;
		  undefined4 local_4;
		  
		  local_10 = (float8)param4;
		  local_4 = param3;
		  if (DAT_ram_00a5a8c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    DAT_ram_00a5a8c7 = '\x01';
		  }
		  uVar1 = AmplitudeNS_MiniJSON_Json__Deserialize(param5,0);
		  uVar2 = func_ii_4443(&local_4,0);
		  if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		  }
		  uVar3 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		  uVar3 = System_Double__GetHashCode(&local_10,uVar3,0);
		  param1_00 = unnamed_function_1428(param2);
		  uVar2 = unnamed_function_1428(uVar2);
		  uVar3 = unnamed_function_1428(uVar3);
		  uVar1 = unnamed_function_1428(uVar1);
		  import::env::LogRevenue(param1_00,uVar2,uVar3,uVar1);
		  unnamed_function_1427(param1_00);
		  unnamed_function_1427(uVar2);
		  unnamed_function_1427(uVar3);
		  unnamed_function_1427(uVar1);
		  return;
		}
		*/

		}

		// Token: 0x060070B8 RID: 28856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070B8")]
		[Address(RVA = "0xBADF", Offset = "0xBADF", VA = "0xBADF", Slot = "9")]
		public void LogRevenue(string productId, int quantity, double price, IDictionary<string, object> eventProperties)
		{
		}

		// Token: 0x060070B9 RID: 28857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070B9")]
		[Address(RVA = "0xBAE0", Offset = "0xBAE0", VA = "0xBAE0", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x060070BA RID: 28858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070BA")]
		[Address(RVA = "0xBAE1", Offset = "0xBAE1", VA = "0xBAE1")]
		public AmplitudeAnalyticsService()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Analytics_Service_WebGL_AmplitudeAnalyticsService___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  param1_00 = unnamed_function_1428(param1);
		  param2_00 = unnamed_function_1428(param2);
		  import::env::LogEvent(param1_00,param2_00);
		  unnamed_function_1427(param1_00);
		  unnamed_function_1427(param2_00);
		  return;
		}
		*/

		}
	}
}
