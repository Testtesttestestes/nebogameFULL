using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Analytics.Service.Android
{
	// Token: 0x02001295 RID: 4757
	[Token(Token = "0x2001295")]
	public class OkgAnalyticsService : IAnalyticsService, IAnalyticsApi, IDisposable
	{
		// Token: 0x0600710B RID: 28939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600710B")]
		[Address(RVA = "0xBB32", Offset = "0xBB32", VA = "0xBB32", Slot = "4")]
		public void Init(string userId, string serverName, IDeviceIDProvider deviceIDProvider)
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Service_Android_OkgAnalyticsService__Init
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Core_Analytics_Service_Android_OkgAnalyticsService__SetUserPropertyOnce
		            (param1,param2,param3,param3);
		  return;
		}
		*/

		}

		// Token: 0x0600710C RID: 28940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600710C")]
		[Address(RVA = "0xBB33", Offset = "0xBB33", VA = "0xBB33", Slot = "5")]
		public void SetUserPropertyOnce(string property, object value)
		{
		/* --- GHIDRA: SetUserPropertyOnce ---
		void Core_Analytics_Service_Android_OkgAnalyticsService__SetUserPropertyOnce
		               (undefined4 param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  int iVar2;
		  undefined4 param2_00;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  undefined8 uVar6;
		  int *piVar7;
		  uint uVar8;
		  
		  if (DAT_ram_00a594c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_IOkgAnalytics_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23317);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25096);
		    DAT_ram_00a594c5 = '\x01';
		  }
		  iVar2 = System_Collections_CollectionBase___ctor(param2,StringLiteral_23317,0);
		  if (iVar2 == 0) {
		    iVar2 = System_Collections_CollectionBase___ctor(param2,StringLiteral_25096,0);
		    if (iVar2 == 0) {
		      return;
		    }
		    uVar6 = CONCAT44(in_register_20000014,*(undefined4 *)(*param3 + 0xdc));
		    uVar4 = (**(code **)((ulonglong)*(uint *)(*param3 + 0xd8) * 4))(param3,uVar6);
		    uVar3 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		    }
		    param2_00 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		    uVar4 = func_ii_5066(uVar4,param2_00,0);
		    if (DAT_ram_00a594e1 == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_OkgAnalytics_TypeInfo);
		      DAT_ram_00a594e1 = '\x01';
		    }
		    iVar2 = Core_Analytics_Okg_OkgAnalytics_TypeInfo;
		    piVar7 = (int *)**(int **)(Core_Analytics_Okg_OkgAnalytics_TypeInfo + 0x5c);
		    if (piVar7 == (int *)0x0) {
		      piVar7 = (int *)unnamed_function_1417(Core_Analytics_Okg_OkgAnalytics_TypeInfo);
		      Core_Analytics_Okg_OkgAnalytics__get_Instance(piVar7,1,1,1,1,iVar2);
		      **(int **)(Core_Analytics_Okg_OkgAnalytics_TypeInfo + 0x5c) = (int)piVar7;
		    }
		    uVar1 = 0;
		    iVar2 = *piVar7;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Okg_IOkgAnalytics_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		          goto code_r0x810117a6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar7,Core_Analytics_Okg_IOkgAnalytics_TypeInfo,2);
		code_r0x810117a6:
		    uVar6 = CONCAT44(uVar3,uVar4);
		    (**(code **)((ulonglong)*puVar5 * 4))(piVar7,uVar6,puVar5[1]);
		    uVar1 = (uint)((ulonglong)uVar6 >> 0x20);
		    iVar2 = Core_Analytics_Service_Android_OkgAnalyticsService__SetUserProperty(puVar5,puVar5);
		    if (iVar2 == 0) {
		      return;
		    }
		    if (DAT_ram_00a594e1 == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_OkgAnalytics_TypeInfo);
		      DAT_ram_00a594e1 = '\x01';
		    }
		    iVar2 = Core_Analytics_Okg_OkgAnalytics_TypeInfo;
		    piVar7 = (int *)**(undefined4 **)(Core_Analytics_Okg_OkgAnalytics_TypeInfo + 0x5c);
		    if (piVar7 == (int *)0x0) {
		      piVar7 = (int *)unnamed_function_1417(Core_Analytics_Okg_OkgAnalytics_TypeInfo);
		      Core_Analytics_Okg_OkgAnalytics__get_Instance(piVar7,1,1,1,1,iVar2);
		      **(int **)(Core_Analytics_Okg_OkgAnalytics_TypeInfo + 0x5c) = (int)piVar7;
		    }
		    uVar8 = 0;
		    iVar2 = *piVar7;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Okg_IOkgAnalytics_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar8 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar8 * 8 + 4) * 8 + iVar2 + 0xd8);
		          goto code_r0x81011888;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar8);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar7,Core_Analytics_Okg_IOkgAnalytics_TypeInfo,3);
		  }
		  else {
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param3 + 0xd8) * 4))
		                      (param3,CONCAT44(in_register_20000014,*(undefined4 *)(*param3 + 0xdc)));
		    if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		    }
		    uVar4 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		    uVar6 = Google_Protobuf_Reflection_MessageDescriptor_FieldCollection__get_Item(uVar3,uVar4,0);
		    if (DAT_ram_00a594e1 == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_OkgAnalytics_TypeInfo);
		      DAT_ram_00a594e1 = '\x01';
		    }
		    iVar2 = Core_Analytics_Okg_OkgAnalytics_TypeInfo;
		    piVar7 = (int *)**(int **)(Core_Analytics_Okg_OkgAnalytics_TypeInfo + 0x5c);
		    if (piVar7 == (int *)0x0) {
		      piVar7 = (int *)unnamed_function_1417(Core_Analytics_Okg_OkgAnalytics_TypeInfo);
		      Core_Analytics_Okg_OkgAnalytics__get_Instance(piVar7,1,1,1,1,iVar2);
		      **(int **)(Core_Analytics_Okg_OkgAnalytics_TypeInfo + 0x5c) = (int)piVar7;
		    }
		    iVar2 = *piVar7;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Analytics_Okg_IOkgAnalytics_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		          goto code_r0x81011684;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar7,Core_Analytics_Okg_IOkgAnalytics_TypeInfo,1);
		code_r0x81011684:
		    (**(code **)((ulonglong)*puVar5 * 4))(piVar7,uVar6,puVar5[1]);
		    uVar1 = (uint)((ulonglong)uVar6 >> 0x20);
		    iVar2 = Core_Analytics_Service_Android_OkgAnalyticsService__SetUserProperty(puVar5,puVar5);
		    if (iVar2 == 0) {
		      return;
		    }
		    if (DAT_ram_00a594e1 == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_OkgAnalytics_TypeInfo);
		      DAT_ram_00a594e1 = '\x01';
		    }
		    iVar2 = Core_Analytics_Okg_OkgAnalytics_TypeInfo;
		    piVar7 = (int *)**(int **)(Core_Analytics_Okg_OkgAnalytics_TypeInfo + 0x5c);
		    if (piVar7 == (int *)0x0) {
		      piVar7 = (int *)unnamed_function_1417(Core_Analytics_Okg_OkgAnalytics_TypeInfo);
		      Core_Analytics_Okg_OkgAnalytics__get_Instance(piVar7,1,1,1,1,iVar2);
		      **(int **)(Core_Analytics_Okg_OkgAnalytics_TypeInfo + 0x5c) = (int)piVar7;
		    }
		    uVar8 = 0;
		    iVar2 = *piVar7;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Okg_IOkgAnalytics_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar8 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar8 * 8 + 4) * 8 + iVar2 + 0xd8);
		          goto code_r0x81011888;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar8);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar7,Core_Analytics_Okg_IOkgAnalytics_TypeInfo,3);
		  }
		code_r0x81011888:
		  (**(code **)((ulonglong)*puVar5 * 4))(piVar7,(ulonglong)uVar1 << 0x20,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600710D RID: 28941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600710D")]
		[Address(RVA = "0xBB34", Offset = "0xBB34", VA = "0xBB34", Slot = "6")]
		public void SetUserProperty(string property, object value)
		{
		/* --- GHIDRA: SetUserProperty ---
		uint Core_Analytics_Service_Android_OkgAnalyticsService__SetUserProperty
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a594c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_RefAccountInfo__get_Count__);
		    DAT_ram_00a594c6 = '\x01';
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
		          goto code_r0x8101196a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8101196a:
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

		// Token: 0x0600710E RID: 28942 RVA: 0x00014820 File Offset: 0x00012A20
		[Token(Token = "0x600710E")]
		[Address(RVA = "0xBB35", Offset = "0xBB35", VA = "0xBB35")]
		private bool UserIsRegistered()
		{
			return default(bool);
		}

		// Token: 0x0600710F RID: 28943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600710F")]
		[Address(RVA = "0xBB36", Offset = "0xBB36", VA = "0xBB36", Slot = "7")]
		public void AddUserProperty(string property, object value)
		{
		/* --- GHIDRA: AddUserProperty ---
		void Core_Analytics_Service_Android_OkgAnalyticsService__AddUserProperty
		               (int param1,undefined4 param2,undefined4 param3,int *param4,undefined4 param5)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined1 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  longlong lVar6;
		  longlong param2_00;
		  undefined8 uVar7;
		  undefined4 *puVar8;
		  int iVar9;
		  int iVar10;
		  undefined4 uVar11;
		  int *piVar12;
		  int iVar13;
		  uint uVar14;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a594c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_DateTime_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_string__object___string__object___
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_KeyValuePair_string__object___object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_KeyValuePair_string__object___string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameTime_ICurrentTimeProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IDictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_IOkgAnalytics_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IReadOnlyDictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Service_Android_OkgAnalyticsService___c__LogEvent_b__6_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Service_Android_OkgAnalyticsService___c__LogEvent_b__6_1__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_Android_OkgAnalyticsService___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28505);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23038);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28503);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26192);
		    DAT_ram_00a594c7 = '\x01';
		  }
		  uVar11 = StringLiteral_26192;
		  local_4 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  local_30 = 0;
		  iVar13 = *param4;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    uVar14 = 0;
		    do {
		      if (System_Collections_Generic_IDictionary_string__object__TypeInfo ==
		          *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8 + 4) * 8 + iVar13 + 0xf8);
		        goto code_r0x81011b11;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		  }
		  puVar3 = (uint *)func_ii_1080(param4,
		                                System_Collections_Generic_IDictionary_string__object__TypeInfo,7);
		code_r0x81011b11:
		  uVar7 = CONCAT44(in_register_20000004,param4);
		  uVar1 = CONCAT44(in_register_20000014,uVar11);
		  iVar13 = (**(code **)((ulonglong)*puVar3 * 4))(uVar7,uVar1,&local_4,puVar3[1]);
		  uVar11 = StringLiteral_23038;
		  uVar5 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar4 = (undefined4)((ulonglong)uVar7 >> 0x20);
		  if (iVar13 == 0) {
		code_r0x81011bbd:
		    if (*(int *)(Core_Analytics_Service_Android_OkgAnalyticsService___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Analytics_Service_Android_OkgAnalyticsService___c_TypeInfo);
		    }
		    puVar8 = *(undefined4 **)
		              (Core_Analytics_Service_Android_OkgAnalyticsService___c_TypeInfo + 0x5c);
		    iVar9 = puVar8[1];
		    iVar13 = Core_Analytics_Service_Android_OkgAnalyticsService___c_TypeInfo;
		    if (iVar9 == 0) {
		      if (*(int *)(Core_Analytics_Service_Android_OkgAnalyticsService___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Analytics_Service_Android_OkgAnalyticsService___c_TypeInfo);
		        puVar8 = *(undefined4 **)
		                  (Core_Analytics_Service_Android_OkgAnalyticsService___c_TypeInfo + 0x5c);
		      }
		      uVar11 = *puVar8;
		      iVar9 = unnamed_function_1417(System_Func_KeyValuePair_string__object___string__TypeInfo);
		      func_ii_7795(iVar9,uVar11,
		                   Method_Core_Analytics_Service_Android_OkgAnalyticsService___c__LogEvent_b__6_0__,
		                   0);
		      iVar13 = Core_Analytics_Service_Android_OkgAnalyticsService___c_TypeInfo;
		      *(int *)(*(int *)(Core_Analytics_Service_Android_OkgAnalyticsService___c_TypeInfo + 0x5c) + 4)
		           = iVar9;
		    }
		    if (*(int *)(iVar13 + 0x74) == 0) {
		      func_ii_306000(iVar13);
		      iVar13 = Core_Analytics_Service_Android_OkgAnalyticsService___c_TypeInfo;
		    }
		    puVar8 = *(undefined4 **)(iVar13 + 0x5c);
		    iVar10 = puVar8[2];
		    if (iVar10 == 0) {
		      if (*(int *)(iVar13 + 0x74) == 0) {
		        func_ii_306000(iVar13);
		        puVar8 = *(undefined4 **)
		                  (Core_Analytics_Service_Android_OkgAnalyticsService___c_TypeInfo + 0x5c);
		      }
		      uVar11 = *puVar8;
		      iVar10 = unnamed_function_1417(System_Func_KeyValuePair_string__object___object__TypeInfo);
		      func_ii_7795(iVar10,uVar11,
		                   Method_Core_Analytics_Service_Android_OkgAnalyticsService___c__LogEvent_b__6_1__,
		                   0);
		      *(int *)(*(int *)(Core_Analytics_Service_Android_OkgAnalyticsService___c_TypeInfo + 0x5c) + 8)
		           = iVar10;
		    }
		    iVar13 = System_Func_KeyValuePair_object__object___object____ctor
		                       (param4,iVar9,iVar10,
		                        Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_string__object___string__object___
		                       );
		  }
		  else {
		    uVar14 = 0;
		    iVar13 = *param4;
		    if (*(ushort *)(iVar13 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_IDictionary_string__object__TypeInfo ==
		            *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8 + 4) * 8 + iVar13 + 0xe0);
		          goto code_r0x81011b98;
		        }
		        uVar14 = uVar14 + 1;
		      } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		    }
		    puVar3 = (uint *)func_ii_1080(param4,
		                                  System_Collections_Generic_IDictionary_string__object__TypeInfo,4)
		    ;
		code_r0x81011b98:
		    uVar7 = CONCAT44(uVar4,param4);
		    uVar1 = CONCAT44(uVar5,uVar11);
		    iVar13 = (**(code **)((ulonglong)*puVar3 * 4))(uVar7,uVar1,puVar3[1]);
		    uVar5 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar4 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    if ((iVar13 == 0) ||
		       (iVar13 = func_ii_1082(local_4,
		                              System_Collections_Generic_IReadOnlyDictionary_string__object__TypeInfo
		                             ), iVar13 == 0)) goto code_r0x81011bbd;
		  }
		  if (*(int *)(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Analytics_Service_Android_AnalyticsEventMediator_TypeInfo);
		  }
		  iVar9 = Core_Analytics_Service_Android_AnalyticsEventMediator___cctor(0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar12 = (int *)**(int **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  if (piVar12 != (int *)0x0) {
		    iVar10 = *piVar12;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      uVar14 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar14 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar14 * 8 + 4) * 8 + iVar10 + 0x270)
		          ;
		          goto code_r0x81011d8d;
		        }
		        uVar14 = uVar14 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar14);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar12,Core_Gameplay_IGame_TypeInfo,0x36);
		code_r0x81011d8d:
		    uVar7 = CONCAT44(uVar4,piVar12);
		    uVar1 = CONCAT44(uVar5,puVar3[1]);
		    iVar10 = (**(code **)((ulonglong)*puVar3 * 4))(uVar7,uVar1);
		    uVar4 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar11 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    if ((iVar10 != 0) && (piVar12 = *(int **)(iVar10 + 0x10), piVar12 != (int *)0x0)) {
		      uVar14 = 0;
		      iVar10 = *piVar12;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        do {
		          if (Core_GameTime_ICurrentTimeProvider_TypeInfo ==
		              *(int *)(*(int *)(iVar10 + 0x58) + uVar14 * 8)) {
		            puVar3 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar14 * 8 + 4) * 8 + 0xc0
		                             );
		            goto code_r0x81011e18;
		          }
		          uVar14 = uVar14 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar14);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar12,Core_GameTime_ICurrentTimeProvider_TypeInfo,0);
		code_r0x81011e18:
		      uVar7 = CONCAT44(uVar11,piVar12);
		      param2_00 = (**(code **)((ulonglong)*puVar3 * 4))(uVar7,CONCAT44(uVar4,puVar3[1]));
		      uVar11 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_DateTimeOffset_TypeInfo);
		      }
		      func_ii_13875(&local_40,0);
		      local_28 = local_38;
		      local_30 = local_40;
		      lVar6 = System_DateTimeOffset__get_UtcNow(&local_30,0);
		      if (*(char *)(param1 + 8) == '\0') {
		        if (DAT_ram_00a594e1 == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_OkgAnalytics_TypeInfo);
		          DAT_ram_00a594e1 = '\x01';
		        }
		        iVar10 = Core_Analytics_Okg_OkgAnalytics_TypeInfo;
		        piVar12 = (int *)**(int **)(Core_Analytics_Okg_OkgAnalytics_TypeInfo + 0x5c);
		        if (piVar12 == (int *)0x0) {
		          piVar12 = (int *)unnamed_function_1417(Core_Analytics_Okg_OkgAnalytics_TypeInfo);
		          Core_Analytics_Okg_OkgAnalytics__get_Instance(piVar12,1,1,1,1,iVar10);
		          **(int **)(Core_Analytics_Okg_OkgAnalytics_TypeInfo + 0x5c) = (int)piVar12;
		        }
		        uVar14 = 0;
		        iVar10 = *piVar12;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          do {
		            if (Core_Analytics_Okg_IOkgAnalytics_TypeInfo ==
		                *(int *)(*(int *)(iVar10 + 0x58) + uVar14 * 8)) {
		              puVar3 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar14 * 8 + 4) * 8 + iVar10 +
		                               0xe0);
		              goto code_r0x81011f3d;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar14);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar12,Core_Analytics_Okg_IOkgAnalytics_TypeInfo,4);
		code_r0x81011f3d:
		        uVar2 = (**(code **)((ulonglong)*puVar3 * 4))
		                          (CONCAT44(uVar11,piVar12),param2_00 - lVar6,puVar3[1]);
		        *(undefined1 *)(param1 + 8) = uVar2;
		      }
		      goto code_r0x81011f70;
		    }
		  }
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = Utils_LocalProps__Reset(0);
		code_r0x81011f70:
		  if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTimeOffset_TypeInfo);
		  }
		  System_DateTimeOffset__FromUnixTimeSeconds(&local_40,param2_00,0);
		  uVar11 = (undefined4)((ulonglong)param2_00 >> 0x20);
		  local_10 = local_38;
		  local_18 = local_40;
		  if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTime_TypeInfo);
		  }
		  local_20 = ICSharpCode_SharpZipLib_Zip_ZipEntry___ctor(0);
		  uVar7 = System_DateTimeOffset__get_DateTime(&local_18,0);
		  uVar4 = Core_Extensions_DateTimeExt__GetDefaultCultureForDate(uVar7,StringLiteral_28503,0);
		  *(undefined4 *)(iVar9 + 8) = uVar4;
		  uVar4 = (undefined4)((ulonglong)uVar7 >> 0x20);
		  uVar7 = System_DateTimeOffset__get_UtcNow(&local_18,0);
		  *(undefined8 *)(iVar9 + 0x20) = uVar7;
		  uVar5 = System_DateTime__ToString(&local_20,StringLiteral_28505,0);
		  *(undefined4 *)(iVar9 + 0x1c) = param3;
		  *(undefined4 *)(iVar9 + 0x2c) = uVar5;
		  if (DAT_ram_00a594e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_OkgAnalytics_TypeInfo);
		    DAT_ram_00a594e1 = '\x01';
		  }
		  iVar10 = Core_Analytics_Okg_OkgAnalytics_TypeInfo;
		  piVar12 = (int *)**(int **)(Core_Analytics_Okg_OkgAnalytics_TypeInfo + 0x5c);
		  if (piVar12 == (int *)0x0) {
		    piVar12 = (int *)unnamed_function_1417(Core_Analytics_Okg_OkgAnalytics_TypeInfo);
		    Core_Analytics_Okg_OkgAnalytics__get_Instance(piVar12,1,1,1,1,iVar10);
		    **(int **)(Core_Analytics_Okg_OkgAnalytics_TypeInfo + 0x5c) = (int)piVar12;
		  }
		  uVar14 = 0;
		  iVar10 = *piVar12;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Okg_IOkgAnalytics_TypeInfo ==
		          *(int *)(*(int *)(iVar10 + 0x58) + uVar14 * 8)) {
		        puVar3 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar14 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x810120e4;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar14);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar12,Core_Analytics_Okg_IOkgAnalytics_TypeInfo,0);
		code_r0x810120e4:
		  (**(code **)((ulonglong)*puVar3 * 4))
		            (CONCAT44(uVar4,piVar12),CONCAT44(uVar11,iVar9),iVar13,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007110 RID: 28944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007110")]
		[Address(RVA = "0xBB37", Offset = "0xBB37", VA = "0xBB37", Slot = "8")]
		public void LogEvent(string eventTheme, string eventName, IDictionary<string, object> properties)
		{
		/* --- GHIDRA: LogEvent ---
		void Core_Analytics_Service_Android_OkgAnalyticsService__LogEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,double param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  return;
		}
		*/

		}

		// Token: 0x06007111 RID: 28945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007111")]
		[Address(RVA = "0xBB38", Offset = "0xBB38", VA = "0xBB38", Slot = "9")]
		public void LogRevenue(string productId, int quantity, double price, IDictionary<string, object> eventProperties)
		{
		}

		// Token: 0x06007112 RID: 28946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007112")]
		[Address(RVA = "0xBB39", Offset = "0xBB39", VA = "0xBB39", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x06007113 RID: 28947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007113")]
		[Address(RVA = "0xBB3A", Offset = "0xBB3A", VA = "0xBB3A")]
		public OkgAnalyticsService()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Analytics_Service_Android_OkgAnalyticsService___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a594c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_Android_OkgAnalyticsService___c_TypeInfo);
		    DAT_ram_00a594c8 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Analytics_Service_Android_OkgAnalyticsService___c_TypeInfo);
		  **(undefined4 **)(Core_Analytics_Service_Android_OkgAnalyticsService___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04003AFF RID: 15103
		[Token(Token = "0x4003AFF")]
		[FieldOffset(Offset = "0x8")]
		private bool _globalTimeIsActual;
	}
}
