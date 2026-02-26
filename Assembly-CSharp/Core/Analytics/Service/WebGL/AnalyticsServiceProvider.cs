using System;
using Core.Application.Managers.Analytics;
using Il2CppDummyDll;

namespace Core.Analytics.Service.WebGL
{
	// Token: 0x02001288 RID: 4744
	[Token(Token = "0x2001288")]
	public class AnalyticsServiceProvider : AbstractAnalyticsServiceProvider
	{
		// Token: 0x060070C0 RID: 28864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070C0")]
		[Address(RVA = "0xBAE7", Offset = "0xBAE7", VA = "0xBAE7")]
		public AnalyticsServiceProvider(string userId, string serverName, IDeviceIDProvider deviceIDProvider)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Analytics_Service_WebGL_AnalyticsServiceProvider___ctor
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a8c8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_AbstractAnalyticsServiceProvider_GetOrCreateAnalyticsService_AmplitudeAnalyticsService___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_AbstractAnalyticsServiceProvider_GetOrCreateAnalyticsService_AnalyticsEventMediator___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_AbstractAnalyticsServiceProvider_GetOrCreateAnalyticsService_AppsFlyerAnalyticsService___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_AbstractAnalyticsServiceProvider_GetOrCreateAnalyticsService_OkgAnalyticsService___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BillingAnalyticsListener___
		              );
		    DAT_ram_00a5a8c8 = '\x01';
		  }
		  uVar2 = System_Xml_Linq_XHashtable___Il2CppFullySharedGenericType___TryGetValue
		                    (param1,
		                     Method_Core_Analytics_AbstractAnalyticsServiceProvider_GetOrCreateAnalyticsService_AnalyticsEventMediator___
		                    );
		  Core_Analytics_AbstractAnalyticsServiceProvider__SetupListenersForOkgAnalyticsService
		            (param1,param2,uVar2,param1);
		  uVar2 = System_Xml_Linq_XHashtable___Il2CppFullySharedGenericType___TryGetValue
		                    (param1,
		                     Method_Core_Analytics_AbstractAnalyticsServiceProvider_GetOrCreateAnalyticsService_AmplitudeAnalyticsService___
		                    );
		  Core_Analytics_AbstractAnalyticsServiceProvider__Dispose(param1,param2,uVar2,param1);
		  uVar2 = System_Xml_Linq_XHashtable___Il2CppFullySharedGenericType___TryGetValue
		                    (param1,
		                     Method_Core_Analytics_AbstractAnalyticsServiceProvider_GetOrCreateAnalyticsService_OkgAnalyticsService___
		                    );
		  Core_Analytics_AbstractAnalyticsServiceProvider__SetupListenersForDefaultAnalyticsService
		            (param1,param2,uVar2,param1);
		  uVar2 = System_Xml_Linq_XHashtable___Il2CppFullySharedGenericType___TryGetValue
		                    (param1,
		                     Method_Core_Analytics_AbstractAnalyticsServiceProvider_GetOrCreateAnalyticsService_AppsFlyerAnalyticsService___
		                    );
		  iVar3 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BillingAnalyticsListener___
		  ;
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BillingAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        iVar5 = iVar5 + (*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BillingAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x812890f7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  iVar5 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BillingAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BillingAnalyticsListener___
		                              + 0x2c));
		code_r0x812890f7:
		  iVar3 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar5 + 4),iVar3);
		  piVar4 = (int *)(**(code **)((ulonglong)*(uint *)(iVar3 + 4) * 4))(param2,iVar3);
		  (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x100) * 4))
		            (piVar4,uVar2,*(undefined4 *)(*piVar4 + 0x104));
		  return;
		}
		*/

		}

		// Token: 0x060070C1 RID: 28865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070C1")]
		[Address(RVA = "0xBAE8", Offset = "0xBAE8", VA = "0xBAE8", Slot = "5")]
		public override void SetupListeners(IAnalyticsListenerProvider listenersProvider)
		{
		/* --- GHIDRA: SetupListeners ---
		void Core_Analytics_Service_WebGL_AnalyticsServiceProvider__SetupListeners(undefined4 param1)
		
		{
		  undefined4 param1_00;
		  undefined4 param3;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a8c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_Data_OkgAnalyticsData_TypeInfo);
		    DAT_ram_00a5a8c9 = '\x01';
		  }
		  if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Application_TypeInfo);
		  }
		  param1_00 = UnityEngine_Application__get_unityVersion(0);
		  param3 = Core_Analytics_Okg_OkgAnalytics__SetIsTempUserFlag(param1_00,0);
		  param1_01 = unnamed_function_1417(Core_Analytics_Okg_Data_OkgAnalyticsData_TypeInfo);
		  Core_Analytics_Okg_Data_OkgAnalyticsData__set_Params(param1_01,param1_00,param3,0);
		  **(undefined4 **)(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo + 0x5c) =
		       param1_01;
		  return;
		}
		*/

		}
	}
}
