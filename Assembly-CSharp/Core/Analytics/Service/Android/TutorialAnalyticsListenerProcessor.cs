using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.Analytics.Service.Android
{
	// Token: 0x0200129C RID: 4764
	[Token(Token = "0x200129C")]
	public class TutorialAnalyticsListenerProcessor
	{
		// Token: 0x06007133 RID: 28979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007133")]
		[Address(RVA = "0xBB56", Offset = "0xBB56", VA = "0xBB56")]
		public void Process(Dictionary<string, Dictionary<string, object>> aggregator, string eventTheme, string eventName, IReadOnlyDictionary<string, object> properties)
		{
		/* --- GHIDRA: Process ---
		void Core_Analytics_Service_Android_TutorialAnalyticsListenerProcessor__Process
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a594d7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Events_Scopes_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27883);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27444);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27890);
		    DAT_ram_00a594d7 = '\x01';
		  }
		  iVar1 = System_Uri___ctor(0);
		  iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x14) + 0xc);
		  if (iVar1 != 0) {
		    iVar2 = unnamed_function_1417
		                      (
		                      Core_Events_Scopes_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs_TypeInfo
		                      );
		    *(undefined4 *)(iVar2 + 8) = param1;
		    param1_00 = unnamed_function_1417
		                          (System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    local_4 = 0;
		    uVar3 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    System_Reflection_FieldInfo__get_IsStatic
		              (param1_00,StringLiteral_27890,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    local_8 = param3;
		    uVar3 = func_ii_1081(DAT_ram_00a66954,&local_8);
		    System_Reflection_FieldInfo__get_IsStatic
		              (param1_00,StringLiteral_27444,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    System_Reflection_FieldInfo__get_IsStatic
		              (param1_00,StringLiteral_27883,param2,
		               Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    *(undefined4 *)(iVar2 + 0xc) = param1_00;
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),iVar2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007134 RID: 28980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007134")]
		[Address(RVA = "0xBB57", Offset = "0xBB57", VA = "0xBB57")]
		private static void BeginStep(string eventTheme, string stage, int step)
		{
		/* --- GHIDRA: BeginStep ---
		void Core_Analytics_Service_Android_TutorialAnalyticsListenerProcessor__BeginStep
		               (undefined4 param1,undefined4 param2,undefined4 param3,int *param4,undefined4 param5)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 uVar1;
		  undefined4 in_register_20000014;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined8 *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 *puVar7;
		  undefined4 param1_01;
		  int iVar8;
		  undefined8 uVar9;
		  double dVar10;
		  undefined8 uVar11;
		  int iVar12;
		  uint uVar13;
		  longlong local_20;
		  undefined4 local_18;
		  int *local_14;
		  undefined8 local_10;
		  int *local_4;
		  
		  if (DAT_ram_00a594d8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Events_Scopes_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_DateTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IReadOnlyDictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Controller_StepActionType_var);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Controller_StepActionType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8793);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27632);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27448);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27389);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4604);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23327);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22513);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27883);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27444);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22106);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25362);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21850);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27890);
		    DAT_ram_00a594d8 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_10 = 0;
		  local_14 = (int *)0x0;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  local_20 = CONCAT44(local_20._4_4_,1);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_20);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_27890,uVar2,
		             Method_System_Collections_Generic_Dictionary_string__object__Add__);
		  local_18 = param3;
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_18);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_27444,uVar2,
		             Method_System_Collections_Generic_Dictionary_string__object__Add__);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_27883,param2,
		             Method_System_Collections_Generic_Dictionary_string__object__Add__);
		  uVar2 = StringLiteral_27389;
		  iVar12 = *param4;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    uVar13 = 0;
		    do {
		      if (System_Collections_Generic_IReadOnlyDictionary_string__object__TypeInfo ==
		          *(int *)(*(int *)(iVar12 + 0x58) + uVar13 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar13 * 8 + 4) * 8 + iVar12 + 200);
		        goto code_r0x81014c8e;
		      }
		      uVar13 = uVar13 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar13);
		  }
		  puVar3 = (uint *)func_ii_1080(param4,
		                                System_Collections_Generic_IReadOnlyDictionary_string__object__TypeInfo
		                                ,1);
		code_r0x81014c8e:
		  uVar11 = CONCAT44(in_register_20000004,param4);
		  uVar9 = CONCAT44(in_register_20000014,uVar2);
		  iVar12 = (**(code **)((ulonglong)*puVar3 * 4))(uVar11,uVar9,&local_4,puVar3[1]);
		  uVar1 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  uVar2 = (undefined4)((ulonglong)uVar11 >> 0x20);
		  if (((iVar12 == 0) || (local_4 == (int *)0x0)) || (*local_4 != System_DateTime_TypeInfo)) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7109(StringLiteral_4604,0);
		  }
		  else {
		    puVar4 = (undefined8 *)func_ii_15774(local_4);
		    uVar11 = *puVar4;
		    if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_DateTime_TypeInfo);
		    }
		    uVar9 = ICSharpCode_SharpZipLib_Zip_ZipEntry___ctor(0);
		    local_10 = System_DateTime__op_Subtraction(uVar9,uVar11,0);
		    uVar1 = (undefined4)((ulonglong)uVar11 >> 0x20);
		    uVar2 = (undefined4)((ulonglong)uVar9 >> 0x20);
		    if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_TimeSpan_TypeInfo);
		    }
		    dVar10 = System_Net_FtpMethodInfo__GetMethodInfo(&local_10,0);
		    if (ABS(dVar10) < 9.223372036854776e+18) {
		      local_20 = (longlong)dVar10;
		    }
		    else {
		      local_20 = -0x8000000000000000;
		    }
		    uVar5 = func_ii_1081(DAT_ram_00a66964,&local_20);
		    func_ii_2946(param1_00,StringLiteral_27448,uVar5,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  }
		  uVar5 = StringLiteral_27632;
		  uVar13 = 0;
		  iVar12 = *param4;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IReadOnlyDictionary_string__object__TypeInfo ==
		          *(int *)(*(int *)(iVar12 + 0x58) + uVar13 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar13 * 8 + 4) * 8 + iVar12 + 200);
		        goto code_r0x81014e02;
		      }
		      uVar13 = uVar13 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar13);
		  }
		  puVar3 = (uint *)func_ii_1080(param4,
		                                System_Collections_Generic_IReadOnlyDictionary_string__object__TypeInfo
		                                ,1);
		code_r0x81014e02:
		  uVar11 = CONCAT44(uVar2,param4);
		  uVar9 = CONCAT44(uVar1,uVar5);
		  iVar12 = (**(code **)((ulonglong)*puVar3 * 4))(uVar11,uVar9,&local_4,puVar3[1]);
		  uVar1 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  uVar2 = (undefined4)((ulonglong)uVar11 >> 0x20);
		  if (iVar12 != 0) {
		    func_ii_2946(param1_00,StringLiteral_27632,local_4,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  }
		  uVar5 = StringLiteral_21850;
		  uVar13 = 0;
		  iVar12 = *param4;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IReadOnlyDictionary_string__object__TypeInfo ==
		          *(int *)(*(int *)(iVar12 + 0x58) + uVar13 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar13 * 8 + 4) * 8 + iVar12 + 200);
		        goto code_r0x81014ea9;
		      }
		      uVar13 = uVar13 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar13);
		  }
		  puVar3 = (uint *)func_ii_1080(param4,
		                                System_Collections_Generic_IReadOnlyDictionary_string__object__TypeInfo
		                                ,1);
		code_r0x81014ea9:
		  uVar11 = CONCAT44(uVar2,param4);
		  uVar9 = CONCAT44(uVar1,uVar5);
		  iVar12 = (**(code **)((ulonglong)*puVar3 * 4))(uVar11,uVar9,&local_4,puVar3[1]);
		  uVar1 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  uVar2 = (undefined4)((ulonglong)uVar11 >> 0x20);
		  if (iVar12 != 0) {
		    func_ii_2946(param1_00,StringLiteral_21850,local_4,
		                 Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  }
		  uVar5 = Gameplay_TutorialV2_Controller_StepActionType_var;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar5 = func_ii_2734(uVar5,0);
		  local_20 = CONCAT44(local_20._4_4_,0x8000);
		  uVar6 = func_ii_1081(Gameplay_TutorialV2_Controller_StepActionType_TypeInfo,&local_20);
		  if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a6697c);
		  }
		  uVar5 = System_Double__ToString(uVar5,uVar6,0);
		  iVar12 = System_Collections_CollectionBase___ctor(param2,uVar5,0);
		  uVar5 = StringLiteral_23327;
		  if (iVar12 != 0) {
		    iVar12 = *param4;
		    if (*(ushort *)(iVar12 + 0xb6) != 0) {
		      uVar13 = 0;
		      do {
		        if (System_Collections_Generic_IReadOnlyDictionary_string__object__TypeInfo ==
		            *(int *)(*(int *)(iVar12 + 0x58) + uVar13 * 8)) {
		          puVar3 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar13 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81014fbe;
		        }
		        uVar13 = uVar13 + 1;
		      } while (*(ushort *)(iVar12 + 0xb6) != uVar13);
		    }
		    puVar3 = (uint *)func_ii_1080(param4,
		                                  System_Collections_Generic_IReadOnlyDictionary_string__object__TypeInfo
		                                  ,0);
		code_r0x81014fbe:
		    uVar11 = CONCAT44(uVar2,param4);
		    uVar9 = CONCAT44(uVar1,uVar5);
		    iVar12 = (**(code **)((ulonglong)*puVar3 * 4))(uVar11,uVar9,puVar3[1]);
		    uVar5 = StringLiteral_22106;
		    uVar1 = (undefined4)((ulonglong)uVar9 >> 0x20);
		    uVar2 = (undefined4)((ulonglong)uVar11 >> 0x20);
		    if (iVar12 != 0) {
		      uVar13 = 0;
		      iVar12 = *param4;
		      if (*(ushort *)(iVar12 + 0xb6) != 0) {
		        do {
		          if (System_Collections_Generic_IReadOnlyDictionary_string__object__TypeInfo ==
		              *(int *)(*(int *)(iVar12 + 0x58) + uVar13 * 8)) {
		            puVar3 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar13 * 8 + 4) * 8 + 0xc0
		                             );
		            goto code_r0x81015045;
		          }
		          uVar13 = uVar13 + 1;
		        } while (*(ushort *)(iVar12 + 0xb6) != uVar13);
		      }
		      puVar3 = (uint *)func_ii_1080(param4,
		                                    System_Collections_Generic_IReadOnlyDictionary_string__object__TypeInfo
		                                    ,0);
		code_r0x81015045:
		      uVar11 = CONCAT44(uVar2,param4);
		      uVar9 = CONCAT44(uVar1,uVar5);
		      iVar12 = (**(code **)((ulonglong)*puVar3 * 4))(uVar11,uVar9,puVar3[1]);
		      uVar5 = StringLiteral_25362;
		      uVar1 = (undefined4)((ulonglong)uVar9 >> 0x20);
		      uVar2 = (undefined4)((ulonglong)uVar11 >> 0x20);
		      if (iVar12 != 0) {
		        uVar13 = 0;
		        iVar12 = *param4;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          do {
		            if (System_Collections_Generic_IReadOnlyDictionary_string__object__TypeInfo ==
		                *(int *)(*(int *)(iVar12 + 0x58) + uVar13 * 8)) {
		              puVar3 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar13 * 8 + 4) * 8 + iVar12 +
		                               200);
		              goto code_r0x810150d5;
		            }
		            uVar13 = uVar13 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar13);
		        }
		        puVar3 = (uint *)func_ii_1080(param4,
		                                      System_Collections_Generic_IReadOnlyDictionary_string__object__TypeInfo
		                                      ,1);
		code_r0x810150d5:
		        uVar11 = CONCAT44(uVar2,param4);
		        uVar9 = CONCAT44(uVar1,uVar5);
		        iVar12 = (**(code **)((ulonglong)*puVar3 * 4))(uVar11,uVar9,&local_14,puVar3[1]);
		        uVar1 = (undefined4)((ulonglong)uVar9 >> 0x20);
		        uVar2 = (undefined4)((ulonglong)uVar11 >> 0x20);
		        if (iVar12 == 0) {
		          uVar5 = 0;
		        }
		        else if (local_14 == (int *)0x0) {
		          uVar5 = 0;
		        }
		        else if (*local_14 == DAT_ram_00a66954) {
		          puVar7 = (undefined4 *)func_ii_15774(local_14);
		          uVar5 = *puVar7;
		        }
		        else {
		          uVar5 = 0;
		        }
		        param1_01 = unnamed_function_1417
		                              (System_Collections_Generic_Dictionary_string__object__TypeInfo);
		        System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		                  (param1_01,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		        uVar6 = StringLiteral_22106;
		        iVar12 = *param4;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          uVar13 = 0;
		          do {
		            if (System_Collections_Generic_IReadOnlyDictionary_string__object__TypeInfo ==
		                *(int *)(*(int *)(iVar12 + 0x58) + uVar13 * 8)) {
		              puVar3 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar13 * 8 + 4) * 8 + iVar12 +
		                               0xd0);
		              goto code_r0x810151a0;
		            }
		            uVar13 = uVar13 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar13);
		        }
		        puVar3 = (uint *)func_ii_1080(param4,
		                                      System_Collections_Generic_IReadOnlyDictionary_string__object__TypeInfo
		                                      ,2);
		code_r0x810151a0:
		        uVar13 = 0;
		        uVar11 = CONCAT44(uVar2,param4);
		        uVar9 = CONCAT44(uVar1,uVar6);
		        uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(uVar11,uVar9,puVar3[1]);
		        uVar1 = (undefined4)((ulonglong)uVar11 >> 0x20);
		        uVar6 = (undefined4)((ulonglong)uVar9 >> 0x20);
		        System_Reflection_FieldInfo__get_IsStatic
		                  (param1_01,StringLiteral_22106,uVar2,
		                   Method_System_Collections_Generic_Dictionary_string__object__Add__);
		        uVar2 = StringLiteral_23327;
		        iVar12 = *param4;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          do {
		            if (System_Collections_Generic_IReadOnlyDictionary_string__object__TypeInfo ==
		                *(int *)(*(int *)(iVar12 + 0x58) + uVar13 * 8)) {
		              puVar3 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar13 * 8 + 4) * 8 + iVar12 +
		                               0xd0);
		              goto code_r0x81015244;
		            }
		            uVar13 = uVar13 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar13);
		        }
		        puVar3 = (uint *)func_ii_1080(param4,
		                                      System_Collections_Generic_IReadOnlyDictionary_string__object__TypeInfo
		                                      ,2);
		code_r0x81015244:
		        uVar11 = CONCAT44(uVar1,param4);
		        uVar9 = CONCAT44(uVar6,uVar2);
		        uVar6 = (**(code **)((ulonglong)*puVar3 * 4))(uVar11,uVar9,puVar3[1]);
		        uVar2 = (undefined4)((ulonglong)uVar11 >> 0x20);
		        uVar1 = (undefined4)((ulonglong)uVar9 >> 0x20);
		        System_Reflection_FieldInfo__get_IsStatic
		                  (param1_01,StringLiteral_23327,uVar6,
		                   Method_System_Collections_Generic_Dictionary_string__object__Add__);
		        local_20 = CONCAT44(local_20._4_4_,uVar5);
		        uVar5 = func_ii_1081(DAT_ram_00a66954,&local_20);
		        System_Reflection_FieldInfo__get_IsStatic
		                  (param1_01,StringLiteral_25362,uVar5,
		                   Method_System_Collections_Generic_Dictionary_string__object__Add__);
		        func_ii_2946(param1_00,StringLiteral_22513,param1_01,
		                     Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		        goto code_r0x810152da;
		      }
		    }
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7109(StringLiteral_8793,0);
		  }
		code_r0x810152da:
		  iVar12 = System_Uri___ctor(0);
		  iVar12 = *(int *)(*(int *)(*(int *)(*(int *)(iVar12 + 0x38) + 0x10) + 0x14) + 0xc);
		  if (iVar12 != 0) {
		    iVar8 = unnamed_function_1417
		                      (
		                      Core_Events_Scopes_AnalyticsEventMediatorScope_AnalyticsEventMediatorArgs_TypeInfo
		                      );
		    *(undefined4 *)(iVar8 + 0xc) = param1_00;
		    *(undefined4 *)(iVar8 + 8) = param1;
		    (**(code **)((ulonglong)*(uint *)(iVar12 + 0xc) * 4))
		              (CONCAT44(uVar2,*(undefined4 *)(iVar12 + 0x20)),CONCAT44(uVar1,iVar8),
		               *(undefined4 *)(iVar12 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007135 RID: 28981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007135")]
		[Address(RVA = "0xBB58", Offset = "0xBB58", VA = "0xBB58")]
		private static void FinishStep(string eventTheme, string stage, int step, IReadOnlyDictionary<string, object> aggregated)
		{
		/* --- GHIDRA: FinishStep ---
		int Core_Analytics_Service_Android_TutorialAnalyticsListenerProcessor__FinishStep
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a594d9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Analytics_Service_Android_TutorialAnalyticsListenerProcessor__UserInputRoutine_d__4_TypeInfo
		              );
		    DAT_ram_00a594d9 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Core_Analytics_Service_Android_TutorialAnalyticsListenerProcessor__UserInputRoutine_d__4_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06007136 RID: 28982 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007136")]
		[Address(RVA = "0xBB59", Offset = "0xBB59", VA = "0xBB59")]
		private static IEnumerator UserInputRoutine(TouchCollector touchCollector)
		{
		/* --- GHIDRA: UserInputRoutine ---
		undefined4
		Core_Analytics_Service_Android_TutorialAnalyticsListenerProcessor__UserInputRoutine
		          (undefined4 param1,undefined4 param2,undefined4 *param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a594da == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_Android_CombatCollector_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__Dictionary_string__object___TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21850);
		    DAT_ram_00a594da = '\x01';
		  }
		  local_4 = 0;
		  local_8 = (int *)0x0;
		  iVar1 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (param2,StringLiteral_21850,&local_4,
		                     Method_System_Collections_Generic_Dictionary_string__Dictionary_string__object___TryGetValue__
		                    );
		  if (((iVar1 != 0) &&
		      (iVar1 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                         (local_4,StringLiteral_21850,&local_8,
		                          Method_System_Collections_Generic_Dictionary_string__object__TryGetValue__
		                         ), iVar1 != 0)) && (local_8 != (int *)0x0)) {
		    if (((uint)*(byte *)(Core_Analytics_Service_Android_CombatCollector_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*local_8 + 0xb8)) &&
		       (*(int *)(*(int *)(*local_8 + 100) +
		                 (uint)*(byte *)(Core_Analytics_Service_Android_CombatCollector_TypeInfo + 0xb8) * 4
		                + -4) == Core_Analytics_Service_Android_CombatCollector_TypeInfo)) {
		      uVar2 = 1;
		      goto code_r0x810148f9;
		    }
		  }
		  local_8 = (int *)0x0;
		  uVar2 = 0;
		code_r0x810148f9:
		  *param3 = local_8;
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06007137 RID: 28983 RVA: 0x00014958 File Offset: 0x00012B58
		[Token(Token = "0x6007137")]
		[Address(RVA = "0xBB5A", Offset = "0xBB5A", VA = "0xBB5A")]
		private bool TryGetCombatCollector(Dictionary<string, Dictionary<string, object>> aggregator, out CombatCollector combatCollector)
		{
			return default(bool);
		}

		// Token: 0x06007138 RID: 28984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007138")]
		[Address(RVA = "0xBB5B", Offset = "0xBB5B", VA = "0xBB5B")]
		public TutorialAnalyticsListenerProcessor()
		{
		}

		// Token: 0x04003B14 RID: 15124
		[Token(Token = "0x4003B14")]
		[FieldOffset(Offset = "0x8")]
		private Coroutine _currentTapRoutine;
	}
}
