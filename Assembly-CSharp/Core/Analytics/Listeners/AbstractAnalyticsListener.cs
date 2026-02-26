using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Analytics.Service;
using Core.Events;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012B9 RID: 4793
	[Token(Token = "0x20012B9")]
	public abstract class AbstractAnalyticsListener : IDisposable
	{
		// Token: 0x1700171C RID: 5916
		// (get) Token: 0x060071BF RID: 29119 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700171C")]
		protected IAnalyticsApi AnalyticsServiceProxy
		{
			[Token(Token = "0x60071BF")]
			[Address(RVA = "0xBBCD", Offset = "0xBBCD", VA = "0xBBCD")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700171D RID: 5917
		// (get) Token: 0x060071C0 RID: 29120
		[Token(Token = "0x1700171D")]
		protected abstract string Theme { [Token(Token = "0x60071C0")] get; }

		// Token: 0x1700171E RID: 5918
		// (get) Token: 0x060071C1 RID: 29121 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060071C2 RID: 29122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700171E")]
		public virtual EventBus EventBus
		{
			[Token(Token = "0x60071C1")]
			[Address(RVA = "0xBBCE", Offset = "0xBBCE", VA = "0xBBCE", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60071C2")]
			[Address(RVA = "0xBBCF", Offset = "0xBBCF", VA = "0xBBCF", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x060071C3 RID: 29123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071C3")]
		[Address(RVA = "0xBBD0", Offset = "0xBBD0", VA = "0xBBD0", Slot = "8")]
		public virtual void AddService(IAnalyticsService service)
		{
		/* --- GHIDRA: AddService ---
		void Core_Analytics_Listeners_AbstractAnalyticsListener__AddService
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a59525 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_IAnalyticsService__Contains__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_IAnalyticsService__Remove__);
		    DAT_ram_00a59525 = '\x01';
		  }
		  iVar1 = func_ii_10159(*(undefined4 *)(*(int *)(param1 + 8) + 8),param2,
		                        Method_System_Collections_Generic_HashSet_IAnalyticsService__Contains__);
		  if (iVar1 != 0) {
		    Unity_Services_Analytics_AnalyticsService__get_Instance
		              (*(undefined4 *)(*(int *)(param1 + 8) + 8),param2,
		               Method_System_Collections_Generic_HashSet_IAnalyticsService__Remove__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060071C4 RID: 29124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071C4")]
		[Address(RVA = "0xBBD1", Offset = "0xBBD1", VA = "0xBBD1", Slot = "9")]
		public virtual void RemoveService(IAnalyticsService service)
		{
		/* --- GHIDRA: RemoveService ---
		undefined4
		Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService
		          (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59526 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a59526 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  return param1_00;
		}
		*/

		}

		// Token: 0x060071C5 RID: 29125 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60071C5")]
		[Address(RVA = "0xBBD2", Offset = "0xBBD2", VA = "0xBBD2")]
		protected Dictionary<string, object> GetEmptyProperties()
		{
		/* --- GHIDRA: GetEmptyProperties ---
		undefined4
		Core_Analytics_Listeners_AbstractAnalyticsListener__GetEmptyProperties
		          (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59527 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_DateTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26538);
		    DAT_ram_00a59527 = '\x01';
		  }
		  if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTime_TypeInfo);
		  }
		  local_8 = System_Net_ServicePoint__get_HasTimedOut(0);
		  if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		  }
		  uVar1 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		  uVar1 = System_DateTime__ToString(&local_8,StringLiteral_26538,uVar1,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060071C6 RID: 29126 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60071C6")]
		[Address(RVA = "0xBBD3", Offset = "0xBBD3", VA = "0xBBD3")]
		protected string GetDateString()
		{
		/* --- GHIDRA: GetDateString ---
		undefined8
		Core_Analytics_Listeners_AbstractAnalyticsListener__GetDateString
		          (undefined4 param1,undefined4 param2)
		
		{
		  undefined8 uVar1;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59528 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    DAT_ram_00a59528 = '\x01';
		  }
		  if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTimeOffset_TypeInfo);
		  }
		  func_ii_13875(&local_20,0);
		  local_8 = local_18;
		  local_10 = local_20;
		  uVar1 = System_DateTimeOffset__get_Now(&local_10,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060071C7 RID: 29127 RVA: 0x00014B38 File Offset: 0x00012D38
		[Token(Token = "0x60071C7")]
		[Address(RVA = "0xBBD4", Offset = "0xBBD4", VA = "0xBBD4")]
		protected long GetTs()
		{
		/* --- GHIDRA: GetTs ---
		undefined4
		Core_Analytics_Listeners_AbstractAnalyticsListener__GetTs
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  
		  if (DAT_ram_00a5952a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_22051);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28094);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22663);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25821);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22941);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21420);
		    DAT_ram_00a5952a = '\x01';
		  }
		  if (param2 - 1U < 5) {
		    puVar1 = (undefined4 *)(&PTR_StringLiteral_22051_ram_005a3618)[param2 - 1U];
		  }
		  else {
		    puVar1 = &StringLiteral_28094;
		  }
		  return *puVar1;
		}
		*/

			return 0L;
		}

		// Token: 0x060071C8 RID: 29128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071C8")]
		[Address(RVA = "0x1EBE", Offset = "0x1EBE", VA = "0x1EBE")]
		protected void AppendResourceSetToProperties(Dictionary<string, object> properties, ResourceSet price, string prefix)
		{
		/* --- GHIDRA: AppendResourceSetToProperties ---
		int * Core_Analytics_Listeners_AbstractAnalyticsListener__AppendResourceSetToProperties(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060071C9 RID: 29129 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60071C9")]
		[Address(RVA = "0xBBD5", Offset = "0xBBD5", VA = "0xBBD5")]
		protected string GetResourceAnalyticsName(Resources resource)
		{
		/* --- GHIDRA: GetResourceAnalyticsName ---
		void Core_Analytics_Listeners_AbstractAnalyticsListener__GetResourceAnalyticsName
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5952c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Analytics_Listeners_AbstractAnalyticsListener_MultipleAnalyticsServiceProxy_TypeInfo
		              );
		    DAT_ram_00a5952c = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Core_Analytics_Listeners_AbstractAnalyticsListener_MultipleAnalyticsServiceProxy_TypeInfo
		                    );
		  if (DAT_ram_00a59532 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_IAnalyticsService___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_IAnalyticsService__TypeInfo);
		    DAT_ram_00a59532 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_HashSet_IAnalyticsService__TypeInfo);
		  func_ii_7115(param1_00,Method_System_Collections_Generic_HashSet_IAnalyticsService___ctor__);
		  *(undefined4 *)(iVar1 + 8) = param1_00;
		  *(int *)(param1 + 8) = iVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060071CA RID: 29130
		[Token(Token = "0x60071CA")]
		public abstract void Init();

		// Token: 0x060071CB RID: 29131
		[Token(Token = "0x60071CB")]
		protected abstract void Deinit();

		// Token: 0x060071CC RID: 29132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071CC")]
		[Address(RVA = "0x2273", Offset = "0x2273", VA = "0x2273", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		int * Core_Analytics_Listeners_AbstractAnalyticsListener__Dispose(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060071CD RID: 29133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071CD")]
		[Address(RVA = "0xBBD6", Offset = "0xBBD6", VA = "0xBBD6")]
		protected AbstractAnalyticsListener()
		{
		}

		// Token: 0x04003BA1 RID: 15265
		[Token(Token = "0x4003BA1")]
		[FieldOffset(Offset = "0x8")]
		private AbstractAnalyticsListener.MultipleAnalyticsServiceProxy _analyticsProxy;

		// Token: 0x04003BA2 RID: 15266
		[Token(Token = "0x4003BA2")]
		[FieldOffset(Offset = "0xC")]
		private EventBus _eventBus;

		// Token: 0x020012BA RID: 4794
		[Token(Token = "0x20012BA")]
		private class MultipleAnalyticsServiceProxy : IAnalyticsApi
		{
			// Token: 0x1700171F RID: 5919
			// (get) Token: 0x060071CE RID: 29134 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700171F")]
			public HashSet<IAnalyticsService> Services
			{
				[Token(Token = "0x60071CE")]
				[Address(RVA = "0xBBD7", Offset = "0xBBD7", VA = "0xBBD7")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x060071CF RID: 29135 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60071CF")]
			[Address(RVA = "0xBBD8", Offset = "0xBBD8", VA = "0xBBD8", Slot = "4")]
			public void SetUserPropertyOnce(string property, object value)
			{
			}

			// Token: 0x060071D0 RID: 29136 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60071D0")]
			[Address(RVA = "0xBBD9", Offset = "0xBBD9", VA = "0xBBD9", Slot = "5")]
			public void SetUserProperty(string property, object value)
			{
			}

			// Token: 0x060071D1 RID: 29137 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60071D1")]
			[Address(RVA = "0xBBDA", Offset = "0xBBDA", VA = "0xBBDA", Slot = "6")]
			public void AddUserProperty(string property, object value)
			{
			}

			// Token: 0x060071D2 RID: 29138 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60071D2")]
			[Address(RVA = "0xBBDB", Offset = "0xBBDB", VA = "0xBBDB", Slot = "7")]
			public void LogEvent(string eventTheme, string eventName, IDictionary<string, object> properties)
			{
			}

			// Token: 0x060071D3 RID: 29139 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60071D3")]
			[Address(RVA = "0xBBDC", Offset = "0xBBDC", VA = "0xBBDC", Slot = "8")]
			public void LogRevenue(string productId, int quantity, double price, IDictionary<string, object> eventProperties)
			{
			}

			// Token: 0x060071D4 RID: 29140 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60071D4")]
			[Address(RVA = "0xBBDD", Offset = "0xBBDD", VA = "0xBBDD")]
			public MultipleAnalyticsServiceProxy()
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_EventBus ---
		void Core_Analytics_Listeners_AbstractAnalyticsListener__set_EventBus
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a59524 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_IAnalyticsService__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_IAnalyticsService__Contains__);
		    DAT_ram_00a59524 = '\x01';
		  }
		  iVar1 = func_ii_10159(*(undefined4 *)(*(int *)(param1 + 8) + 8),param2,
		                        Method_System_Collections_Generic_HashSet_IAnalyticsService__Contains__);
		  if (iVar1 == 0) {
		    System_Collections_Generic_HashSet_object___Clear
		              (*(undefined4 *)(*(int *)(param1 + 8) + 8),param2,
		               Method_System_Collections_Generic_HashSet_IAnalyticsService__Add__);
		  }
		  return;
		}
		*/

}
