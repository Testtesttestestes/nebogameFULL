using System;
using System.Collections.Generic;
using Core.Analytics.Okg.Data;
using Il2CppDummyDll;

namespace Core.Analytics.Service.Android
{
	// Token: 0x02001289 RID: 4745
	[Token(Token = "0x2001289")]
	public class AnalyticsEventMediator : IAnalyticsService, IAnalyticsApi, IDisposable
	{
		// Token: 0x060070C3 RID: 28867 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60070C3")]
		[Address(RVA = "0xBAEA", Offset = "0xBAEA", VA = "0xBAEA")]
		public static OkgAnalyticsData GetOkgAnalyticsDataTemplate()
		{
		/* --- GHIDRA: GetOkgAnalyticsDataTemplate ---
		void Core_Analytics_Service_Android_AnalyticsEventMediator__GetOkgAnalyticsDataTemplate
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Core_Analytics_Service_Android_AnalyticsEventMediator__SetUserPropertyOnce
		            (param1,param2,param3,param3);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060070C4 RID: 28868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070C4")]
		[Address(RVA = "0xBAEB", Offset = "0xBAEB", VA = "0xBAEB", Slot = "5")]
		public void SetUserPropertyOnce(string property, object value)
		{
		/* --- GHIDRA: SetUserPropertyOnce ---
		void Core_Analytics_Service_Android_AnalyticsEventMediator__SetUserPropertyOnce
		               (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined8 uVar4;
		  int iVar5;
		  int param1_00;
		  
		  if (DAT_ram_00a5a8cb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23317);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25764);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25096);
		    DAT_ram_00a5a8cb = '\x01';
		  }
		  iVar1 = System_Collections_CollectionBase___ctor(param2,StringLiteral_23317,0);
		  if (iVar1 != 0) {
		    if (*(int *)(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo);
		    }
		    iVar1 = **(int **)(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo + 0x5c);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param3 + 0xd8) * 4))
		                      (param3,*(undefined4 *)(*param3 + 0xdc));
		    if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		    }
		    uVar3 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		    uVar4 = Google_Protobuf_Reflection_MessageDescriptor_FieldCollection__get_Item(uVar2,uVar3,0);
		    *(undefined8 *)(iVar1 + 0x10) = uVar4;
		    if (*(char *)(param1 + 0x18) != '\0') {
		      if (*(int *)(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo);
		      }
		      iVar1 = **(int **)(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo + 0x5c);
		      if (*(char *)(iVar1 + 0x34) == '\0') {
		        *(undefined1 *)(iVar1 + 0x34) = 0;
		        return;
		      }
		      uVar2 = Core_Analytics_Service_Android_AnalyticsEventMediator__SetUserProperty(iVar1,iVar1);
		      *(byte *)(iVar1 + 0x34) = (byte)uVar2 ^ 1;
		      return;
		    }
		    if (*(int *)(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo);
		    }
		    iVar1 = **(int **)(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo + 0x5c);
		    uVar2 = Core_Analytics_Service_Android_AnalyticsEventMediator__SetUserProperty
		                      (Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo,
		                       Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo);
		    *(byte *)(iVar1 + 0x34) = (byte)uVar2 ^ 1;
		    *(undefined1 *)(param1 + 0x18) = 1;
		    return;
		  }
		  iVar1 = System_Collections_CollectionBase___ctor(param2,StringLiteral_25764,0);
		  if (iVar1 == 0) {
		    iVar1 = System_Collections_CollectionBase___ctor(param2,StringLiteral_25096,0);
		    if (iVar1 != 0) {
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param3 + 0xd8) * 4))
		                        (param3,*(undefined4 *)(*param3 + 0xdc));
		      if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		      }
		      uVar3 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		      uVar2 = func_ii_5066(uVar2,uVar3,0);
		      if (*(int *)(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo);
		      }
		      iVar1 = Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo;
		      iVar5 = **(int **)(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo + 0x5c);
		      *(undefined4 *)(iVar5 + 0x18) = uVar2;
		      if (*(char *)(param1 + 0x18) != '\0') {
		        if (*(int *)(iVar1 + 0x74) == 0) {
		          func_ii_306000(iVar1);
		          iVar5 = **(int **)(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo + 0x5c);
		        }
		        if (*(char *)(iVar5 + 0x34) == '\0') {
		          *(undefined1 *)(iVar5 + 0x34) = 0;
		          return;
		        }
		        uVar2 = Core_Analytics_Service_Android_AnalyticsEventMediator__SetUserProperty(iVar1,iVar1);
		        *(byte *)(iVar5 + 0x34) = (byte)uVar2 ^ 1;
		        return;
		      }
		      if (*(int *)(iVar1 + 0x74) == 0) {
		        func_ii_306000(iVar1);
		        iVar5 = **(int **)(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo + 0x5c);
		      }
		      uVar2 = Core_Analytics_Service_Android_AnalyticsEventMediator__SetUserProperty(iVar1,iVar1);
		      *(byte *)(iVar5 + 0x34) = (byte)uVar2 ^ 1;
		      *(undefined1 *)(param1 + 0x18) = 1;
		    }
		    return;
		  }
		  if (*(int *)(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo);
		  }
		  iVar1 = Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo;
		  iVar5 = **(int **)(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo + 0x5c);
		  if ((param3 != (int *)0x0) && (DAT_ram_00a66978 != *param3)) {
		    System_Activator__CreateInstance(param3,DAT_ram_00a66978);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int **)(iVar5 + 0x30) = param3;
		  param1_00 = *(int *)(iVar1 + 0x74);
		  if (*(char *)(param1 + 0x18) == '\0') {
		    if (param1_00 == 0) {
		      func_ii_306000(iVar1);
		      iVar5 = **(int **)(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo + 0x5c);
		    }
		    uVar2 = Core_Analytics_Service_Android_AnalyticsEventMediator__SetUserProperty
		                      (param1_00,param1_00);
		    *(byte *)(iVar5 + 0x34) = (byte)uVar2 ^ 1;
		    *(undefined1 *)(param1 + 0x18) = 1;
		    return;
		  }
		  if (param1_00 == 0) {
		    func_ii_306000(iVar1);
		    iVar5 = **(int **)(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo + 0x5c);
		  }
		  if (*(char *)(iVar5 + 0x34) == '\0') {
		    *(undefined1 *)(iVar5 + 0x34) = 0;
		    return;
		  }
		  uVar2 = Core_Analytics_Service_Android_AnalyticsEventMediator__SetUserProperty
		                    (param1_00,param1_00);
		  *(byte *)(iVar5 + 0x34) = (byte)uVar2 ^ 1;
		  return;
		}
		*/

		}

		// Token: 0x060070C5 RID: 28869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070C5")]
		[Address(RVA = "0xBAEC", Offset = "0xBAEC", VA = "0xBAEC", Slot = "6")]
		public void SetUserProperty(string property, object value)
		{
		/* --- GHIDRA: SetUserProperty ---
		uint Core_Analytics_Service_Android_AnalyticsEventMediator__SetUserProperty
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a8cc == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_RefAccountInfo__get_Count__);
		    DAT_ram_00a5a8cc = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(int **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  if (param1_00 != (int *)0x0) {
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x140);
		          goto code_r0x8128965c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8128965c:
		    iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    if (iVar3 == 0) {
		      return 0;
		    }
		    uVar1 = 0;
		    iVar3 = func_ii_7112(iVar3,0);
		    if ((iVar3 != 0) && (*(int *)(iVar3 + 0x50) != 0)) {
		      uVar1 = (uint)(0 < *(int *)(*(int *)(iVar3 + 0x50) + 0xc));
		    }
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x060070C6 RID: 28870 RVA: 0x00014778 File Offset: 0x00012978
		[Token(Token = "0x60070C6")]
		[Address(RVA = "0xBAED", Offset = "0xBAED", VA = "0xBAED")]
		private bool UserIsRegistered()
		{
			return default(bool);
		}

		// Token: 0x060070C7 RID: 28871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070C7")]
		[Address(RVA = "0xBAEE", Offset = "0xBAEE", VA = "0xBAEE", Slot = "7")]
		public void AddUserProperty(string property, object value)
		{
		/* --- GHIDRA: AddUserProperty ---
		void Core_Analytics_Service_Android_AnalyticsEventMediator__AddUserProperty
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  int param1_01;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5a8cd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_string__object___string__object___
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_KeyValuePair_string__object___object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_KeyValuePair_string__object___string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IReadOnlyDictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Service_Android_AnalyticsEventMediator___c__LogEvent_b__12_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Service_Android_AnalyticsEventMediator___c__LogEvent_b__12_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Analytics_Service_Android_AnalyticsEventMediator___c_TypeInfo);
		    DAT_ram_00a5a8cd = '\x01';
		  }
		  iVar1 = func_ii_1082(param4,
		                       System_Collections_Generic_IReadOnlyDictionary_string__object__TypeInfo);
		  if (iVar1 == 0) {
		    if (*(int *)(Core_Analytics_Service_Android_AnalyticsEventMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Analytics_Service_Android_AnalyticsEventMediator___c_TypeInfo);
		    }
		    puVar2 = *(undefined4 **)
		              (Core_Analytics_Service_Android_AnalyticsEventMediator___c_TypeInfo + 0x5c);
		    param1_00 = puVar2[1];
		    iVar1 = Core_Analytics_Service_Android_AnalyticsEventMediator___c_TypeInfo;
		    if (param1_00 == 0) {
		      if (*(int *)(Core_Analytics_Service_Android_AnalyticsEventMediator___c_TypeInfo + 0x74) == 0)
		      {
		        func_ii_306000(Core_Analytics_Service_Android_AnalyticsEventMediator___c_TypeInfo);
		        puVar2 = *(undefined4 **)
		                  (Core_Analytics_Service_Android_AnalyticsEventMediator___c_TypeInfo + 0x5c);
		      }
		      uVar3 = *puVar2;
		      param1_00 = unnamed_function_1417(System_Func_KeyValuePair_string__object___string__TypeInfo);
		      func_ii_7795(param1_00,uVar3,
		                   Method_Core_Analytics_Service_Android_AnalyticsEventMediator___c__LogEvent_b__12_0__
		                   ,0);
		      iVar1 = Core_Analytics_Service_Android_AnalyticsEventMediator___c_TypeInfo;
		      *(int *)(*(int *)(Core_Analytics_Service_Android_AnalyticsEventMediator___c_TypeInfo + 0x5c) +
		              4) = param1_00;
		    }
		    if (*(int *)(iVar1 + 0x74) == 0) {
		      func_ii_306000(iVar1);
		      iVar1 = Core_Analytics_Service_Android_AnalyticsEventMediator___c_TypeInfo;
		    }
		    puVar2 = *(undefined4 **)(iVar1 + 0x5c);
		    param1_01 = puVar2[2];
		    if (param1_01 == 0) {
		      if (*(int *)(iVar1 + 0x74) == 0) {
		        func_ii_306000(iVar1);
		        puVar2 = *(undefined4 **)
		                  (Core_Analytics_Service_Android_AnalyticsEventMediator___c_TypeInfo + 0x5c);
		      }
		      uVar3 = *puVar2;
		      param1_01 = unnamed_function_1417(System_Func_KeyValuePair_string__object___object__TypeInfo);
		      func_ii_7795(param1_01,uVar3,
		                   Method_Core_Analytics_Service_Android_AnalyticsEventMediator___c__LogEvent_b__12_1__
		                   ,0);
		      *(int *)(*(int *)(Core_Analytics_Service_Android_AnalyticsEventMediator___c_TypeInfo + 0x5c) +
		              8) = param1_01;
		    }
		    iVar1 = System_Func_KeyValuePair_object__object___object____ctor
		                      (param4,param1_00,param1_01,
		                       Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_string__object___string__object___
		                      );
		  }
		  Core_Analytics_Service_Android_AnalyticsEventMediator__Init(param1,param2,param3,iVar1,iVar1);
		  return;
		}
		*/

		}

		// Token: 0x060070C8 RID: 28872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070C8")]
		[Address(RVA = "0xBAEF", Offset = "0xBAEF", VA = "0xBAEF", Slot = "8")]
		public void LogEvent(string eventTheme, string eventName, IDictionary<string, object> properties)
		{
		}

		// Token: 0x060070C9 RID: 28873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070C9")]
		[Address(RVA = "0xBAF0", Offset = "0xBAF0", VA = "0xBAF0")]
		private void DoLogEvent(string eventTheme, string eventName, IReadOnlyDictionary<string, object> properties)
		{
		}

		// Token: 0x060070CA RID: 28874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070CA")]
		[Address(RVA = "0xBAF1", Offset = "0xBAF1", VA = "0xBAF1", Slot = "9")]
		public void LogRevenue(string productId, int quantity, double price, IDictionary<string, object> eventProperties)
		{
		}

		// Token: 0x060070CB RID: 28875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070CB")]
		[Address(RVA = "0xBAF2", Offset = "0xBAF2", VA = "0xBAF2", Slot = "10")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Analytics_Service_Android_AnalyticsEventMediator__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,int *param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a8ce == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_IDeviceIDProvider_TypeInfo);
		    DAT_ram_00a5a8ce = '\x01';
		  }
		  if (*(int *)(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo);
		  }
		  uVar1 = 0;
		  iVar4 = **(int **)(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo + 0x5c);
		  iVar5 = *param4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_IDeviceIDProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81289f55;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param4,Core_Analytics_IDeviceIDProvider_TypeInfo,0);
		code_r0x81289f55:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param4,param2,puVar2[1]);
		  *(undefined4 *)(iVar4 + 0x30) = uVar3;
		  return;
		}
		*/

		}

		// Token: 0x060070CC RID: 28876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070CC")]
		[Address(RVA = "0xBAF3", Offset = "0xBAF3", VA = "0xBAF3", Slot = "4")]
		public void Init(string userId, string serverName, IDeviceIDProvider deviceIDProvider)
		{
		/* --- GHIDRA: Init ---
		undefined4
		Core_Analytics_Service_Android_AnalyticsEventMediator__Init
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5a8cf == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27882);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19850);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20014);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21850);
		    DAT_ram_00a5a8cf = '\x01';
		  }
		  iVar1 = System_Collections_CollectionBase___ctor(param2,StringLiteral_19850,0);
		  if (iVar1 == 0) {
		    iVar1 = System_Collections_CollectionBase___ctor(param2,StringLiteral_20014,0);
		    if (iVar1 == 0) {
		      iVar1 = System_Collections_CollectionBase___ctor(param2,StringLiteral_27882,0);
		      if ((iVar1 == 0) &&
		         (iVar1 = System_Collections_CollectionBase___ctor(param2,StringLiteral_21850,0), iVar1 == 0
		         )) {
		        return 0;
		      }
		      Core_Analytics_Service_Android_TouchCollector___c__DisplayClass12_0___Began_b__0
		                (*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param1 + 8),param2,param3,param4,0);
		    }
		    else {
		      param1_00 = *(undefined4 *)(param1 + 0x10);
		      param2_00 = *(undefined4 *)(param1 + 8);
		      if (*(int *)(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo);
		      }
		      Core_Analytics_Service_Android_AppsFlyerAnalyticsService___c__DisplayClass6_0___LogRevenue_b__3
		                (param1_00,param2_00,
		                 **(undefined4 **)
		                   (Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo + 0x5c),param2,
		                 param3,param4,0);
		      Core_Analytics_Service_Android_TouchCollector___c__DisplayClass12_0___Began_b__0
		                (*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param1 + 8),param2,param3,param4,0);
		    }
		  }
		  else {
		    Core_Analytics_Service_Android_AnalyticsEventMediator___c___LogEvent_b__12_1
		              (param2,*(undefined4 *)(param1 + 8),param2,param3,param4,param2);
		  }
		  return 1;
		}
		*/

		}

		// Token: 0x060070CD RID: 28877 RVA: 0x00014790 File Offset: 0x00012990
		[Token(Token = "0x60070CD")]
		[Address(RVA = "0xBAF4", Offset = "0xBAF4", VA = "0xBAF4")]
		private bool TryAggregateEvent(string eventTheme, string eventName, IReadOnlyDictionary<string, object> properties)
		{
		/* --- GHIDRA: TryAggregateEvent ---
		void Core_Analytics_Service_Android_AnalyticsEventMediator__TryAggregateEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a8d0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Analytics_Service_Android_AppAnalyticsListenerProcessor_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Analytics_Service_Android_AuthAnalyticsListenerProcessor_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__Dictionary_string__object____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_string__Dictionary_string__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Analytics_Service_Android_TutorialAnalyticsListenerProcessor_TypeInfo);
		    DAT_ram_00a5a8d0 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_string__Dictionary_string__object___TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_string__Dictionary_string__object____ctor__
		            );
		  *(undefined4 *)(param1 + 8) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (Core_Analytics_Service_Android_AppAnalyticsListenerProcessor_TypeInfo);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (Core_Analytics_Service_Android_AuthAnalyticsListenerProcessor_TypeInfo);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (Core_Analytics_Service_Android_TutorialAnalyticsListenerProcessor_TypeInfo);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060070CE RID: 28878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070CE")]
		[Address(RVA = "0xBAF5", Offset = "0xBAF5", VA = "0xBAF5")]
		public AnalyticsEventMediator()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Analytics_Service_Android_AnalyticsEventMediator___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a8d1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Analytics_Service_Android_AnalyticsEventMediator___c_TypeInfo);
		    DAT_ram_00a5a8d1 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Analytics_Service_Android_AnalyticsEventMediator___c_TypeInfo);
		  **(undefined4 **)(Core_Analytics_Service_Android_AnalyticsEventMediator___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .cctor ---
		int * Core_Analytics_Service_Android_AnalyticsEventMediator___cctor(undefined4 param1)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a5a8ca == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_Data_OkgAnalyticsData_TypeInfo);
		    DAT_ram_00a5a8ca = '\x01';
		  }
		  if (*(int *)(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo);
		  }
		  param1_00 = (int *)Core_Analytics_Okg_Data_OkgAnalyticsData___ctor
		                               (**(undefined4 **)
		                                  (Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo +
		                                  0x5c),0);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Core_Analytics_Okg_Data_OkgAnalyticsData_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(Core_Analytics_Okg_Data_OkgAnalyticsData_TypeInfo + 0xb8) * 4 + -4)
		        != Core_Analytics_Okg_Data_OkgAnalyticsData_TypeInfo)) {
		      System_Activator__CreateInstance(param1_00,Core_Analytics_Okg_Data_OkgAnalyticsData_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x04003ADC RID: 15068
		[Token(Token = "0x4003ADC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly OkgAnalyticsData DataTemplate;

		// Token: 0x04003ADD RID: 15069
		[Token(Token = "0x4003ADD")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<string, Dictionary<string, object>> _aggregator;

		// Token: 0x04003ADE RID: 15070
		[Token(Token = "0x4003ADE")]
		[FieldOffset(Offset = "0xC")]
		private readonly AppAnalyticsListenerProcessor _appAnalyticsListenerProcessor;

		// Token: 0x04003ADF RID: 15071
		[Token(Token = "0x4003ADF")]
		[FieldOffset(Offset = "0x10")]
		private readonly AuthAnalyticsListenerProcessor _authAnalyticsListenerProcessor;

		// Token: 0x04003AE0 RID: 15072
		[Token(Token = "0x4003AE0")]
		[FieldOffset(Offset = "0x14")]
		private readonly TutorialAnalyticsListenerProcessor _tutorialAnalyticsListenerProcessor;

		// Token: 0x04003AE1 RID: 15073
		[Token(Token = "0x4003AE1")]
		[FieldOffset(Offset = "0x18")]
		private bool _isTempUserInitialized;
	}
}
