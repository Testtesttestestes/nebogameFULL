using System;
using System.Collections.Generic;
using Core.Application.Managers.Analytics;
using Il2CppDummyDll;

namespace Core.Analytics
{
	// Token: 0x02001281 RID: 4737
	[Token(Token = "0x2001281")]
	public abstract class AbstractAnalyticsServiceProvider : IDisposable
	{
		// Token: 0x060070A4 RID: 28836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070A4")]
		[Address(RVA = "0xBAD4", Offset = "0xBAD4", VA = "0xBAD4")]
		protected AbstractAnalyticsServiceProvider(string userId, string serverName, IDeviceIDProvider deviceIDProvider)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Analytics_AbstractAnalyticsServiceProvider___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a8c2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Type__IAnalyticsService__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Type__IAnalyticsService__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_Type__IAnalyticsService__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_Type__IAnalyticsService__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_Type__IAnalyticsService__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Type__IAnalyticsService__GetEnumerator__
		              );
		    DAT_ram_00a5a8c2 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x14),
		                     Method_System_Collections_Generic_Dictionary_Type__IAnalyticsService__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_Type__IAnalyticsService__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1a2,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_Type__IAnalyticsService__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81284a21;
		    }
		    if (iVar3 == 0) goto code_r0x81284a77;
		    piVar5 = local_8._4_4_;
		    iVar6 = *local_8._4_4_;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_IDisposable_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x812849c4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8._4_4_,
		                        System_IDisposable_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x812849c4:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(*puVar4,piVar5,puVar4[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81284a21:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x81284a77:
		      DAT_ram_009d3e38 = 0;
		      System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		                (*(undefined4 *)(param1 + 0x14),
		                 Method_System_Collections_Generic_Dictionary_Type__IAnalyticsService__Clear__);
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x36,&local_18);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060070A5 RID: 28837 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60070A5")]
		protected T GetOrCreateAnalyticsService<T>() where T : IAnalyticsService, new()
		{
			return null;
		}

		// Token: 0x060070A6 RID: 28838
		[Token(Token = "0x60070A6")]
		public abstract void SetupListeners(IAnalyticsListenerProvider listenersProvider);

		// Token: 0x060070A7 RID: 28839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070A7")]
		[Address(RVA = "0xBAD5", Offset = "0xBAD5", VA = "0xBAD5", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Analytics_AbstractAnalyticsServiceProvider__Dispose
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a8c3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AdAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AnalyticsEventMediatorListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AppAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AprsAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuchanAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuthAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BankAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BillingAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BlitzTournamentAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BossAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ChatAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ClansAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CollectionsAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CombatAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CraftAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_DailyQuestAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_DebugAnalyticsListenerProxy___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_DiscountsAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GdEventsAnalyticListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GiftsAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GoalsAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GuideAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_InventoryAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_IsleAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ManufactureAssistAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_MedalsAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_NotificationAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PlatformSpecificAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PopupListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_RateGameAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_SchoolAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_SettingsAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ShopAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_SmallGamesAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ThemeDuelAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_TournamentsAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UiAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UserAnalyticsListener___
		              );
		    DAT_ram_00a5a8c3 = '\x01';
		  }
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PlatformSpecificAnalyticsListener___
		  ;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PlatformSpecificAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PlatformSpecificAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81286b9f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PlatformSpecificAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PlatformSpecificAnalyticsListener___
		                              + 0x2c));
		code_r0x81286b9f:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AppAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AppAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AppAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81286c47;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AppAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AppAnalyticsListener___
		                              + 0x2c));
		code_r0x81286c47:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuthAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuthAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuthAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81286cef;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuthAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuthAnalyticsListener___
		                              + 0x2c));
		code_r0x81286cef:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UserAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UserAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UserAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81286d97;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UserAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UserAnalyticsListener___
		                              + 0x2c));
		code_r0x81286d97:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AnalyticsEventMediatorListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AnalyticsEventMediatorListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AnalyticsEventMediatorListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81286e3f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AnalyticsEventMediatorListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AnalyticsEventMediatorListener___
		                              + 0x2c));
		code_r0x81286e3f:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BillingAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BillingAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BillingAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81286ee7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BillingAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BillingAnalyticsListener___
		                              + 0x2c));
		code_r0x81286ee7:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_SettingsAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_SettingsAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_SettingsAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81286f8f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_SettingsAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_SettingsAnalyticsListener___
		                              + 0x2c));
		code_r0x81286f8f:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GuideAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GuideAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GuideAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81287037;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GuideAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GuideAnalyticsListener___
		                              + 0x2c));
		code_r0x81287037:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CombatAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CombatAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CombatAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x812870df;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CombatAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CombatAnalyticsListener___
		                              + 0x2c));
		code_r0x812870df:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_TournamentsAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_TournamentsAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_TournamentsAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81287187;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_TournamentsAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_TournamentsAnalyticsListener___
		                              + 0x2c));
		code_r0x81287187:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BlitzTournamentAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BlitzTournamentAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BlitzTournamentAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x8128722f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BlitzTournamentAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BlitzTournamentAnalyticsListener___
		                              + 0x2c));
		code_r0x8128722f:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BossAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BossAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BossAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x812872d7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BossAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BossAnalyticsListener___
		                              + 0x2c));
		code_r0x812872d7:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_IsleAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_IsleAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_IsleAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x8128737f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_IsleAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_IsleAnalyticsListener___
		                              + 0x2c));
		code_r0x8128737f:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_InventoryAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_InventoryAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_InventoryAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81287427;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_InventoryAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_InventoryAnalyticsListener___
		                              + 0x2c));
		code_r0x81287427:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UiAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UiAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UiAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x812874cf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UiAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UiAnalyticsListener___
		                              + 0x2c));
		code_r0x812874cf:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BankAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BankAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BankAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81287577;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BankAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BankAnalyticsListener___
		                              + 0x2c));
		code_r0x81287577:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_DiscountsAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_DiscountsAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_DiscountsAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x8128761f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_DiscountsAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_DiscountsAnalyticsListener___
		                              + 0x2c));
		code_r0x8128761f:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_MedalsAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_MedalsAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_MedalsAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x812876c7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_MedalsAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_MedalsAnalyticsListener___
		                              + 0x2c));
		code_r0x812876c7:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AprsAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AprsAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AprsAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x8128776f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AprsAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AprsAnalyticsListener___
		                              + 0x2c));
		code_r0x8128776f:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CollectionsAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CollectionsAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CollectionsAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81287817;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CollectionsAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CollectionsAnalyticsListener___
		                              + 0x2c));
		code_r0x81287817:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_DailyQuestAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_DailyQuestAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_DailyQuestAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x812878bf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_DailyQuestAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_DailyQuestAnalyticsListener___
		                              + 0x2c));
		code_r0x812878bf:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_SmallGamesAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_SmallGamesAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_SmallGamesAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81287967;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_SmallGamesAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_SmallGamesAnalyticsListener___
		                              + 0x2c));
		code_r0x81287967:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ShopAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ShopAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ShopAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81287a0f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ShopAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ShopAnalyticsListener___
		                              + 0x2c));
		code_r0x81287a0f:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_SchoolAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_SchoolAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_SchoolAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81287ab7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_SchoolAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_SchoolAnalyticsListener___
		                              + 0x2c));
		code_r0x81287ab7:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ChatAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ChatAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ChatAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81287b5f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ChatAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ChatAnalyticsListener___
		                              + 0x2c));
		code_r0x81287b5f:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuchanAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuchanAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuchanAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81287c07;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuchanAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuchanAnalyticsListener___
		                              + 0x2c));
		code_r0x81287c07:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CraftAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CraftAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CraftAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81287caf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CraftAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CraftAnalyticsListener___
		                              + 0x2c));
		code_r0x81287caf:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ManufactureAssistAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ManufactureAssistAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ManufactureAssistAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81287d57;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ManufactureAssistAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ManufactureAssistAnalyticsListener___
		                              + 0x2c));
		code_r0x81287d57:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GiftsAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GiftsAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GiftsAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81287dff;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GiftsAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GiftsAnalyticsListener___
		                              + 0x2c));
		code_r0x81287dff:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ClansAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ClansAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ClansAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81287ea7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ClansAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ClansAnalyticsListener___
		                              + 0x2c));
		code_r0x81287ea7:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_RateGameAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_RateGameAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_RateGameAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81287f4f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_RateGameAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_RateGameAnalyticsListener___
		                              + 0x2c));
		code_r0x81287f4f:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_NotificationAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_NotificationAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_NotificationAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81287ff7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_NotificationAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_NotificationAnalyticsListener___
		                              + 0x2c));
		code_r0x81287ff7:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AdAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AdAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AdAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x8128809f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AdAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AdAnalyticsListener___
		                              + 0x2c));
		code_r0x8128809f:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GdEventsAnalyticListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GdEventsAnalyticListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GdEventsAnalyticListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81288147;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GdEventsAnalyticListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GdEventsAnalyticListener___
		                              + 0x2c));
		code_r0x81288147:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_DebugAnalyticsListenerProxy___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_DebugAnalyticsListenerProxy___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_DebugAnalyticsListenerProxy___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x812881ef;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_DebugAnalyticsListenerProxy___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_DebugAnalyticsListenerProxy___
		                              + 0x2c));
		code_r0x812881ef:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GoalsAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GoalsAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GoalsAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81288297;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GoalsAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_GoalsAnalyticsListener___
		                              + 0x2c));
		code_r0x81288297:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ThemeDuelAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ThemeDuelAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ThemeDuelAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x8128833f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ThemeDuelAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ThemeDuelAnalyticsListener___
		                              + 0x2c));
		code_r0x8128833f:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PopupListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PopupListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PopupListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x812883e7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PopupListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PopupListener___
		                              + 0x2c));
		code_r0x812883e7:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  return;
		}
		*/

		}

		// Token: 0x060070A8 RID: 28840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070A8")]
		[Address(RVA = "0xBAD6", Offset = "0xBAD6", VA = "0xBAD6")]
		protected void SetupListenersForDefaultAnalyticsService(IAnalyticsListenerProvider listenersProvider, IAnalyticsService defaultAnalyticsService)
		{
		/* --- GHIDRA: SetupListenersForDefaultAnalyticsService ---
		void Core_Analytics_AbstractAnalyticsServiceProvider__SetupListenersForDefaultAnalyticsService
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a8c4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AnalyticsEventMediatorListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuthAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BillingAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PlatformSpecificAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PopupListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ThemeDuelAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UiAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UserAnalyticsListener___
		              );
		    DAT_ram_00a5a8c4 = '\x01';
		  }
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UserAnalyticsListener___
		  ;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UserAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UserAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x812884eb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UserAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UserAnalyticsListener___
		                              + 0x2c));
		code_r0x812884eb:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuthAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuthAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuthAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81288593;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuthAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuthAnalyticsListener___
		                              + 0x2c));
		code_r0x81288593:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AnalyticsEventMediatorListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AnalyticsEventMediatorListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AnalyticsEventMediatorListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x8128863b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AnalyticsEventMediatorListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AnalyticsEventMediatorListener___
		                              + 0x2c));
		code_r0x8128863b:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ThemeDuelAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ThemeDuelAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ThemeDuelAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x812886e3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ThemeDuelAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_ThemeDuelAnalyticsListener___
		                              + 0x2c));
		code_r0x812886e3:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PlatformSpecificAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PlatformSpecificAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PlatformSpecificAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x8128878b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PlatformSpecificAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PlatformSpecificAnalyticsListener___
		                              + 0x2c));
		code_r0x8128878b:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BillingAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BillingAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BillingAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81288833;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BillingAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_BillingAnalyticsListener___
		                              + 0x2c));
		code_r0x81288833:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PopupListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PopupListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PopupListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x812888db;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PopupListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_PopupListener___
		                              + 0x2c));
		code_r0x812888db:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UiAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UiAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UiAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81288983;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UiAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UiAnalyticsListener___
		                              + 0x2c));
		code_r0x81288983:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  return;
		}
		*/

		}

		// Token: 0x060070A9 RID: 28841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070A9")]
		[Address(RVA = "0xBAD7", Offset = "0xBAD7", VA = "0xBAD7")]
		protected void SetupListenersForOkgAnalyticsService(IAnalyticsListenerProvider listenersProvider, IAnalyticsService okgAnalyticsService)
		{
		/* --- GHIDRA: SetupListenersForOkgAnalyticsService ---
		void Core_Analytics_AbstractAnalyticsServiceProvider__SetupListenersForOkgAnalyticsService
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a8c5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AppAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuthAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CombatAnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_Tutorial2AnalyticsListener___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UserAnalyticsListener___
		              );
		    DAT_ram_00a5a8c5 = '\x01';
		  }
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UserAnalyticsListener___
		  ;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UserAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UserAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81288a6f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UserAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_UserAnalyticsListener___
		                              + 0x2c));
		code_r0x81288a6f:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AppAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AppAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AppAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81288b17;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AppAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AppAnalyticsListener___
		                              + 0x2c));
		code_r0x81288b17:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuthAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuthAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuthAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81288bbf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuthAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_AuthAnalyticsListener___
		                              + 0x2c));
		code_r0x81288bbf:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_Tutorial2AnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_Tutorial2AnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_Tutorial2AnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81288c67;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_Tutorial2AnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_Tutorial2AnalyticsListener___
		                              + 0x2c));
		code_r0x81288c67:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  iVar2 = 
		  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CombatAnalyticsListener___
		  ;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CombatAnalyticsListener___
		                  + 0x10) == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        iVar4 = iVar4 + (*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CombatAnalyticsListener___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x81288d0f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  iVar4 = func_ii_1080(param2,*(int *)(
		                                      Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CombatAnalyticsListener___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Core_Application_Managers_Analytics_IAnalyticsListenerProvider_GetAnalyticsListener_CombatAnalyticsListener___
		                              + 0x2c));
		code_r0x81288d0f:
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar4 + 4),iVar2);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 4) * 4))(param2,iVar2);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		            (piVar3,param3,*(undefined4 *)(*piVar3 + 0x104));
		  return;
		}
		*/

		}

		// Token: 0x060070AA RID: 28842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070AA")]
		[Address(RVA = "0xBAD8", Offset = "0xBAD8", VA = "0xBAD8")]
		protected void SetupListenersForAnalyticsEventMediator(IAnalyticsListenerProvider listenersProvider, IAnalyticsService analyticsEventMediator)
		{
		}

		// Token: 0x04003AB4 RID: 15028
		[Token(Token = "0x4003AB4")]
		[FieldOffset(Offset = "0x8")]
		private string _userId;

		// Token: 0x04003AB5 RID: 15029
		[Token(Token = "0x4003AB5")]
		[FieldOffset(Offset = "0xC")]
		private string _serverName;

		// Token: 0x04003AB6 RID: 15030
		[Token(Token = "0x4003AB6")]
		[FieldOffset(Offset = "0x10")]
		private IDeviceIDProvider _deviceIDProvider;

		// Token: 0x04003AB7 RID: 15031
		[Token(Token = "0x4003AB7")]
		[FieldOffset(Offset = "0x14")]
		private Dictionary<Type, IAnalyticsService> _services;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: GetOrCreateAnalyticsService<object> ---
		void Core_Analytics_AbstractAnalyticsServiceProvider__GetOrCreateAnalyticsService_object_
		               (int param1,undefined4 param2,int param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *param1_00;
		  undefined4 *puVar4;
		  undefined1 *param2_00;
		  undefined4 uVar5;
		  int param3_00;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  undefined1 local_10 [12];
		  undefined1 *local_4;
		  
		  puVar4 = *(undefined4 **)(param3 + 0x1c);
		  if (puVar4 == (undefined4 *)0x0) {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Type__IAnalyticsService__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Type__IAnalyticsService__ContainsKey__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Type__IAnalyticsService__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_IAnalyticsService_TypeInfo);
		    puVar4 = *(undefined4 **)(param3 + 0x1c);
		    if (puVar4 == (undefined4 *)0x0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param3);
		      puVar4 = *(undefined4 **)(param3 + 0x1c);
		    }
		  }
		  param3_00 = *(int *)(puVar4[2] + 0x84);
		  param2_00 = local_10 + -(param3_00 + 0xfU & 0xfffffff0);
		  uVar5 = *puVar4;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar5 = func_ii_2734(uVar5,0);
		  iVar2 = System_Xml_Schema_SchemaInfo__get_Notations
		                    (*(undefined4 *)(param1 + 0x14),uVar5,
		                     Method_System_Collections_Generic_Dictionary_Type__IAnalyticsService__ContainsKey__
		                    );
		  if (iVar2 == 0) {
		    puVar4 = *(undefined4 **)(*(int *)(param3 + 0x1c) + 4);
		    local_4 = param2_00;
		    (**(code **)((ulonglong)(uint)puVar4[2] * 4))(*puVar4,puVar4,0,&local_4,param2_00);
		    param1_00 = (int *)func_ii_1081(*(undefined4 *)(*(int *)(param3 + 0x1c) + 8),param2_00);
		    uVar6 = *(undefined4 *)(param1 + 8);
		    uVar7 = *(undefined4 *)(param1 + 0xc);
		    uVar8 = *(undefined4 *)(param1 + 0x10);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Analytics_IAnalyticsService_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x821ea1dc;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Analytics_IAnalyticsService_TypeInfo,0);
		code_r0x821ea1dc:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar6,uVar7,uVar8,puVar3[1]);
		    System_Reflection_FieldInfo__get_IsStatic
		              (*(undefined4 *)(param1 + 0x14),uVar5,param1_00,
		               Method_System_Collections_Generic_Dictionary_Type__IAnalyticsService__Add__);
		  }
		  else {
		    param1_00 = (int *)System_Data_DataRelationCollection__Add
		                                 (*(undefined4 *)(param1 + 0x14),uVar5,
		                                  Method_System_Collections_Generic_Dictionary_Type__IAnalyticsService__get_Item__
		                                 );
		  }
		  iVar2 = *(int *)(*(int *)(param3 + 0x1c) + 8);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  uVar5 = func_ii_2732(param1_00,iVar2,param2_00);
		  unnamed_function_713(param2,uVar5,param3_00);
		  return;
		}
		*/

}
