using System;
using System.Collections.Generic;
using Gameplay.Billing.Model;
using Il2CppDummyDll;

namespace Core.Analytics.Service.Android
{
	// Token: 0x0200128C RID: 4748
	[Token(Token = "0x200128C")]
	public class AppsFlyerAnalyticsService : IAnalyticsService, IAnalyticsApi, IDisposable
	{
		// Token: 0x060070D5 RID: 28885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070D5")]
		[Address(RVA = "0xBAFC", Offset = "0xBAFC", VA = "0xBAFC", Slot = "4")]
		public void Init(string userId, string serverName, IDeviceIDProvider deviceIDProvider)
		{
		}

		// Token: 0x060070D6 RID: 28886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070D6")]
		[Address(RVA = "0xBAFD", Offset = "0xBAFD", VA = "0xBAFD", Slot = "5")]
		public void SetUserPropertyOnce(string property, object value)
		{
		}

		// Token: 0x060070D7 RID: 28887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070D7")]
		[Address(RVA = "0xBAFE", Offset = "0xBAFE", VA = "0xBAFE", Slot = "6")]
		public void SetUserProperty(string property, object value)
		{
		}

		// Token: 0x060070D8 RID: 28888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070D8")]
		[Address(RVA = "0xBAFF", Offset = "0xBAFF", VA = "0xBAFF", Slot = "7")]
		public void AddUserProperty(string property, object value)
		{
		/* --- GHIDRA: AddUserProperty ---
		void Core_Analytics_Service_Android_AppsFlyerAnalyticsService__AddUserProperty
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_01;
		  int param1_02;
		  
		  if (DAT_ram_00a594a9 == '\0') {
		    Mono_Security_ASN1__get_Item(&AppsFlyerSDK_AppsFlyer_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_string__object___string__string___
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_KeyValuePair_string__object___string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c__LogEvent_b__5_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c__LogEvent_b__5_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo);
		    DAT_ram_00a594a9 = '\x01';
		  }
		  if (*(int *)(Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)
		            (Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo + 0x5c);
		  param1_01 = puVar2[1];
		  param1_00 = Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo;
		  if (param1_01 == 0) {
		    if (*(int *)(Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo + 0x74) == 0)
		    {
		      func_ii_306000(Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo);
		      puVar2 = *(undefined4 **)
		                (Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_01 = unnamed_function_1417(System_Func_KeyValuePair_string__object___string__TypeInfo);
		    func_ii_7795(param1_01,uVar1,
		                 Method_Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c__LogEvent_b__5_0__
		                 ,0);
		    param1_00 = Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo;
		    *(int *)(*(int *)(Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo + 0x5c)
		            + 4) = param1_01;
		  }
		  if (*(int *)(param1_00 + 0x74) == 0) {
		    func_ii_306000(param1_00);
		    param1_00 = Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo;
		  }
		  puVar2 = *(undefined4 **)(param1_00 + 0x5c);
		  param1_02 = puVar2[2];
		  if (param1_02 == 0) {
		    if (*(int *)(param1_00 + 0x74) == 0) {
		      func_ii_306000(param1_00);
		      puVar2 = *(undefined4 **)
		                (Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_02 = unnamed_function_1417(System_Func_KeyValuePair_string__object___string__TypeInfo);
		    func_ii_7795(param1_02,uVar1,
		                 Method_Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c__LogEvent_b__5_1__
		                 ,0);
		    *(int *)(*(int *)(Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo + 0x5c)
		            + 8) = param1_02;
		  }
		  uVar1 = System_Func_KeyValuePair_object__object___object____ctor
		                    (param4,param1_01,param1_02,
		                     Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_string__object___string__string___
		                    );
		  if (*(int *)(AppsFlyerSDK_AppsFlyer_TypeInfo + 0x74) == 0) {
		    func_ii_306000(AppsFlyerSDK_AppsFlyer_TypeInfo);
		  }
		  AppsFlyerSDK_AppsFlyer__startSDK(param3,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060070D9 RID: 28889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070D9")]
		[Address(RVA = "0xBB00", Offset = "0xBB00", VA = "0xBB00", Slot = "8")]
		public void LogEvent(string eventTheme, string eventName, IDictionary<string, object> properties)
		{
		/* --- GHIDRA: LogEvent ---
		void Core_Analytics_Service_Android_AppsFlyerAnalyticsService__LogEvent
		               (int param1,undefined4 param2,undefined4 param3,double param4,int *param5,
		               undefined4 param6)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 *puVar6;
		  int iVar7;
		  int param1_01;
		  
		  if (DAT_ram_00a594aa == '\0') {
		    Mono_Security_ASN1__get_Item(&AppsFlyerSDK_AppsFlyer_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_string___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_BillingProviderId__string___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_string__object___string__string___
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_string__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_KeyValuePair_string__object___string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_BillingProviderId__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IDictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IReadOnlyCollection_BillingProviderId__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c__LogRevenue_b__6_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c__LogRevenue_b__6_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c__LogRevenue_b__6_2__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c__DisplayClass6_0__LogRevenue_b__3__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c__DisplayClass6_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19756);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26198);
		    DAT_ram_00a594aa = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IReadOnlyCollection_BillingProviderId__TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8100e99f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                System_Collections_Generic_IReadOnlyCollection_BillingProviderId__TypeInfo
		                                ,0);
		code_r0x8100e99f:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  if (0 < iVar4) {
		    uVar1 = 0;
		    iVar4 = unnamed_function_1417
		                      (
		                      Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c__DisplayClass6_0_TypeInfo
		                      );
		    uVar5 = StringLiteral_26198;
		    iVar7 = *param5;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_IDictionary_string__object__TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xf8);
		          goto code_r0x8100ea40;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param5,
		                                  System_Collections_Generic_IDictionary_string__object__TypeInfo,7)
		    ;
		code_r0x8100ea40:
		    iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(param5,uVar5,iVar4 + 8,puVar2[1]);
		    if (iVar7 == 0) {
		      return;
		    }
		    uVar5 = *(undefined4 *)(param1 + 8);
		    if (*(int *)(Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo + 0x74) == 0)
		    {
		      func_ii_306000(Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo);
		    }
		    puVar6 = *(undefined4 **)
		              (Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo + 0x5c);
		    iVar7 = puVar6[3];
		    if (iVar7 == 0) {
		      if (*(int *)(Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo + 0x74) ==
		          0) {
		        func_ii_306000(Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo);
		        puVar6 = *(undefined4 **)
		                  (Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo + 0x5c);
		      }
		      uVar3 = *puVar6;
		      iVar7 = unnamed_function_1417(System_Func_BillingProviderId__string__TypeInfo);
		      func_ii_8070(iVar7,uVar3,
		                   Method_Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c__LogRevenue_b__6_2__
		                   ,0);
		      *(int *)(*(int *)(Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo + 0x5c
		                       ) + 0xc) = iVar7;
		    }
		    uVar5 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                      (uVar5,iVar7,Method_System_Linq_Enumerable_Select_BillingProviderId__string___
		                      );
		    uVar3 = unnamed_function_1417(System_Func_string__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar3,iVar4,
		               Method_Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c__DisplayClass6_0__LogRevenue_b__3__
		               ,0);
		    iVar4 = Newtonsoft_Json_Utilities_ReflectionUtils__IsOverridenGenericMember
		                      (uVar5,uVar3,Method_System_Linq_Enumerable_Any_string___);
		    if (iVar4 == 0) {
		      return;
		    }
		  }
		  if (*(int *)(Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo);
		  }
		  uVar5 = StringLiteral_19756;
		  puVar6 = *(undefined4 **)
		            (Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo + 0x5c);
		  iVar7 = puVar6[4];
		  iVar4 = Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo;
		  if (iVar7 == 0) {
		    if (*(int *)(Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo + 0x74) == 0)
		    {
		      func_ii_306000(Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo);
		      puVar6 = *(undefined4 **)
		                (Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo + 0x5c);
		    }
		    uVar3 = *puVar6;
		    iVar7 = unnamed_function_1417(System_Func_KeyValuePair_string__object___string__TypeInfo);
		    func_ii_7795(iVar7,uVar3,
		                 Method_Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c__LogRevenue_b__6_0__
		                 ,0);
		    iVar4 = Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo;
		    *(int *)(*(int *)(Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo + 0x5c)
		            + 0x10) = iVar7;
		  }
		  if (*(int *)(iVar4 + 0x74) == 0) {
		    func_ii_306000(iVar4);
		    iVar4 = Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo;
		  }
		  puVar6 = *(undefined4 **)(iVar4 + 0x5c);
		  param1_01 = puVar6[5];
		  if (param1_01 == 0) {
		    if (*(int *)(iVar4 + 0x74) == 0) {
		      func_ii_306000(iVar4);
		      puVar6 = *(undefined4 **)
		                (Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo + 0x5c);
		    }
		    uVar3 = *puVar6;
		    param1_01 = unnamed_function_1417(System_Func_KeyValuePair_string__object___string__TypeInfo);
		    func_ii_7795(param1_01,uVar3,
		                 Method_Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c__LogRevenue_b__6_1__
		                 ,0);
		    *(int *)(*(int *)(Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo + 0x5c)
		            + 0x14) = param1_01;
		  }
		  uVar3 = System_Func_KeyValuePair_object__object___object____ctor
		                    (param5,iVar7,param1_01,
		                     Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_string__object___string__string___
		                    );
		  if (*(int *)(AppsFlyerSDK_AppsFlyer_TypeInfo + 0x74) == 0) {
		    func_ii_306000(AppsFlyerSDK_AppsFlyer_TypeInfo);
		  }
		  AppsFlyerSDK_AppsFlyer__startSDK(uVar5,uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x060070DA RID: 28890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070DA")]
		[Address(RVA = "0xBB01", Offset = "0xBB01", VA = "0xBB01", Slot = "9")]
		public void LogRevenue(string productId, int quantity, double price, IDictionary<string, object> eventProperties)
		{
		}

		// Token: 0x060070DB RID: 28891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070DB")]
		[Address(RVA = "0xBB02", Offset = "0xBB02", VA = "0xBB02", Slot = "10")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Analytics_Service_Android_AppsFlyerAnalyticsService__Dispose(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a594ab == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_BillingProviderId___);
		    DAT_ram_00a594ab = '\x01';
		  }
		  iVar2 = Method_System_Array_Empty_BillingProviderId___;
		  iVar1 = *(int *)(Method_System_Array_Empty_BillingProviderId___ + 0x1c);
		  if (iVar1 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_BillingProviderId___);
		    iVar1 = *(int *)(iVar2 + 0x1c);
		  }
		  iVar1 = *(int *)(iVar1 + 8);
		  if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		    iVar1 = func_ii_1079(iVar1);
		  }
		  if (*(int *)(iVar1 + 0x74) == 0) {
		    func_ii_306000(iVar1);
		  }
		  iVar2 = *(int *)(*(int *)(iVar2 + 0x1c) + 8);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  *(undefined4 *)(param1 + 8) = **(undefined4 **)(iVar2 + 0x5c);
		  return;
		}
		*/

		}

		// Token: 0x060070DC RID: 28892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070DC")]
		[Address(RVA = "0xBB03", Offset = "0xBB03", VA = "0xBB03")]
		public AppsFlyerAnalyticsService()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Analytics_Service_Android_AppsFlyerAnalyticsService___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a594ac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo);
		    DAT_ram_00a594ac = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo);
		  **(undefined4 **)(Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04003AE5 RID: 15077
		[Token(Token = "0x4003AE5")]
		[FieldOffset(Offset = "0x8")]
		private readonly IReadOnlyList<BillingProviderId> CompatibleBillingProviders;
	}
}
