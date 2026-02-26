using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Analytics.Service.Android
{
	// Token: 0x02001293 RID: 4755
	[Token(Token = "0x2001293")]
	public class MyTrackerAnalyticsService : IAnalyticsService, IAnalyticsApi, IDisposable
	{
		// Token: 0x060070FB RID: 28923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070FB")]
		[Address(RVA = "0xBB22", Offset = "0xBB22", VA = "0xBB22", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x060070FC RID: 28924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070FC")]
		[Address(RVA = "0xBB23", Offset = "0xBB23", VA = "0xBB23", Slot = "4")]
		public void Init(string userId, string serverName, IDeviceIDProvider deviceIDProvider)
		{
		}

		// Token: 0x060070FD RID: 28925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070FD")]
		[Address(RVA = "0xBB24", Offset = "0xBB24", VA = "0xBB24", Slot = "5")]
		public void SetUserPropertyOnce(string property, object value)
		{
		}

		// Token: 0x060070FE RID: 28926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070FE")]
		[Address(RVA = "0xBB25", Offset = "0xBB25", VA = "0xBB25", Slot = "6")]
		public void SetUserProperty(string property, object value)
		{
		}

		// Token: 0x060070FF RID: 28927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070FF")]
		[Address(RVA = "0xBB26", Offset = "0xBB26", VA = "0xBB26", Slot = "7")]
		public void AddUserProperty(string property, object value)
		{
		/* --- GHIDRA: AddUserProperty ---
		void Core_Analytics_Service_Android_MyTrackerAnalyticsService__AddUserProperty
		               (undefined4 param1,undefined4 param2,undefined4 param3,double param4,int *param5,
		               undefined4 param6)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 param4_00;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int *piVar7;
		  int iVar8;
		  undefined4 local_18;
		  int *local_14;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a594bc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_KeyValuePair_string__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_KeyValuePair_string__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__object__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__object__get_Value__);
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_MyTracker_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13612);
		    DAT_ram_00a594bc = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  iVar8 = *param5;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_KeyValuePair_string__object___TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x810107f3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param5,
		                                System_Collections_Generic_IEnumerable_KeyValuePair_string__object___TypeInfo
		                                ,0);
		code_r0x810107f3:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param5,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar6 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x810108c1;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81010a82:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81010a8a;
		    }
		code_r0x810108c1:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    piVar6 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81010a82;
		    if (iVar8 == 0) {
		      iVar8 = 0;
		      goto code_r0x81010ad3;
		    }
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_KeyValuePair_string__object___TypeInfo == *piVar7
		           ) {
		          puVar3 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x8101099b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_KeyValuePair_string__object___TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81010a6e:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81010a8a;
		    }
		code_r0x8101099b:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar3,&local_18,piVar6,puVar3[1]);
		    uVar4 = local_18;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81010a6e;
		    DAT_ram_009d3e38 = 0;
		    param4_00 = import::env::invoke_iii
		                          (*(undefined4 *)(*local_14 + 0xd8),local_14,
		                           *(undefined4 *)(*local_14 + 0xdc));
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x4b,param1_00,uVar4,param4_00,
		               Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81010a8a:
		  iVar8 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar8 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar8;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x81010ad3:
		      piVar6 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar5 = *local_4;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x81010b4b;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x81010b4b:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		      }
		      if (iVar8 == 0) {
		        if (*(int *)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Mycom_Tracker_Unity_MyTracker_TypeInfo);
		        }
		        Mycom_Tracker_Unity_MyTracker__SetAttributionListener(StringLiteral_13612,param1_00,0);
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2dc,&local_c);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06007100 RID: 28928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007100")]
		[Address(RVA = "0xBB27", Offset = "0xBB27", VA = "0xBB27", Slot = "9")]
		public void LogRevenue(string productId, int quantity, double price, IDictionary<string, object> eventProperties)
		{
		/* --- GHIDRA: LogRevenue ---
		void Core_Analytics_Service_Android_MyTrackerAnalyticsService__LogRevenue
		               (undefined4 param1,undefined4 param2,undefined4 param3,int *param4,undefined4 param5)
		
		{
		  undefined8 uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 *puVar7;
		  int iVar8;
		  int iVar9;
		  uint uVar10;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a594bd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Convert_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_string__object___string__string___
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_KeyValuePair_string__object___string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IDictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_MyTracker_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Service_Android_MyTrackerAnalyticsService___c__LogEvent_b__6_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Service_Android_MyTrackerAnalyticsService___c__LogEvent_b__6_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Service_Android_MyTrackerAnalyticsService___c__LogEvent_b__6_2__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Service_Android_MyTrackerAnalyticsService___c__LogEvent_b__6_3__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Service_Android_MyTrackerAnalyticsService___c__LogEvent_b__6_4__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Service_Android_MyTrackerAnalyticsService___c__LogEvent_b__6_5__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23317);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25183);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25097);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26366);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25096);
		    DAT_ram_00a594bd = '\x01';
		  }
		  iVar2 = System_Collections_CollectionBase___ctor(param3,StringLiteral_25183,0);
		  uVar5 = StringLiteral_23317;
		  if (iVar2 == 0) {
		    iVar2 = System_Collections_CollectionBase___ctor(param3,StringLiteral_26366,0);
		    uVar5 = StringLiteral_23317;
		    if (iVar2 == 0) {
		      iVar2 = System_Collections_CollectionBase___ctor(param3,StringLiteral_25097,0);
		      uVar5 = StringLiteral_25096;
		      if (iVar2 != 0) {
		        uVar10 = 0;
		        iVar2 = *param4;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          do {
		            if (System_Collections_Generic_IDictionary_string__object__TypeInfo ==
		                *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		              puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x810110e3;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		        }
		        puVar3 = (uint *)func_ii_1080(param4,
		                                      System_Collections_Generic_IDictionary_string__object__TypeInfo
		                                      ,0);
		code_r0x810110e3:
		        uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param4,uVar5,puVar3[1]);
		        if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		          func_ii_306000(System_Convert_TypeInfo);
		        }
		        uVar5 = System_Convert__ToUInt16(uVar5,0);
		        local_8 = 0;
		        System_Data_SqlTypes_SqlInt32___ctor(&local_8,uVar5,Method_System_Nullable_int___ctor__);
		        if (*(int *)(Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo + 0x74)
		            == 0) {
		          func_ii_306000(Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo);
		        }
		        uVar1 = local_8;
		        puVar7 = *(undefined4 **)
		                  (Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo + 0x5c);
		        iVar8 = puVar7[5];
		        iVar2 = Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo;
		        if (iVar8 == 0) {
		          if (*(int *)(Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo + 0x74)
		              == 0) {
		            func_ii_306000(Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo);
		            puVar7 = *(undefined4 **)
		                      (Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo + 0x5c)
		            ;
		          }
		          uVar5 = *puVar7;
		          iVar8 = unnamed_function_1417(System_Func_KeyValuePair_string__object___string__TypeInfo);
		          func_ii_7795(iVar8,uVar5,
		                       Method_Core_Analytics_Service_Android_MyTrackerAnalyticsService___c__LogEvent_b__6_4__
		                       ,0);
		          iVar2 = Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo;
		          *(int *)(*(int *)(Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo +
		                           0x5c) + 0x14) = iVar8;
		        }
		        if (*(int *)(iVar2 + 0x74) == 0) {
		          func_ii_306000(iVar2);
		          iVar2 = Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo;
		        }
		        puVar7 = *(undefined4 **)(iVar2 + 0x5c);
		        iVar9 = puVar7[6];
		        if (iVar9 == 0) {
		          if (*(int *)(iVar2 + 0x74) == 0) {
		            func_ii_306000(iVar2);
		            puVar7 = *(undefined4 **)
		                      (Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo + 0x5c)
		            ;
		          }
		          uVar5 = *puVar7;
		          iVar9 = unnamed_function_1417(System_Func_KeyValuePair_string__object___string__TypeInfo);
		          func_ii_7795(iVar9,uVar5,
		                       Method_Core_Analytics_Service_Android_MyTrackerAnalyticsService___c__LogEvent_b__6_5__
		                       ,0);
		          *(int *)(*(int *)(Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo +
		                           0x5c) + 0x18) = iVar9;
		        }
		        uVar5 = System_Func_KeyValuePair_object__object___object____ctor
		                          (param4,iVar8,iVar9,
		                           Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_string__object___string__string___
		                          );
		        if (*(int *)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Mycom_Tracker_Unity_MyTracker_TypeInfo);
		        }
		        local_18 = uVar1;
		        local_10 = uVar1;
		        Mycom_Tracker_Unity_MyTracker__TrackInviteEvent(&local_18,uVar5,0);
		      }
		    }
		    else {
		      iVar2 = *param4;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          if (System_Collections_Generic_IDictionary_string__object__TypeInfo ==
		              *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		            puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x81010f48;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		      }
		      puVar3 = (uint *)func_ii_1080(param4,
		                                    System_Collections_Generic_IDictionary_string__object__TypeInfo,
		                                    0);
		code_r0x81010f48:
		      piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param4,uVar5,puVar3[1]);
		      uVar5 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xd8) * 4))
		                        (piVar4,*(undefined4 *)(*piVar4 + 0xdc));
		      if (*(int *)(Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo + 0x74) ==
		          0) {
		        func_ii_306000(Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo);
		      }
		      puVar7 = *(undefined4 **)
		                (Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo + 0x5c);
		      iVar8 = puVar7[3];
		      iVar2 = Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo;
		      if (iVar8 == 0) {
		        if (*(int *)(Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo + 0x74)
		            == 0) {
		          func_ii_306000(Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo);
		          puVar7 = *(undefined4 **)
		                    (Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo + 0x5c);
		        }
		        uVar6 = *puVar7;
		        iVar8 = unnamed_function_1417(System_Func_KeyValuePair_string__object___string__TypeInfo);
		        func_ii_7795(iVar8,uVar6,
		                     Method_Core_Analytics_Service_Android_MyTrackerAnalyticsService___c__LogEvent_b__6_2__
		                     ,0);
		        iVar2 = Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo;
		        *(int *)(*(int *)(Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo +
		                         0x5c) + 0xc) = iVar8;
		      }
		      if (*(int *)(iVar2 + 0x74) == 0) {
		        func_ii_306000(iVar2);
		        iVar2 = Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo;
		      }
		      puVar7 = *(undefined4 **)(iVar2 + 0x5c);
		      iVar9 = puVar7[4];
		      if (iVar9 == 0) {
		        if (*(int *)(iVar2 + 0x74) == 0) {
		          func_ii_306000(iVar2);
		          puVar7 = *(undefined4 **)
		                    (Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo + 0x5c);
		        }
		        uVar6 = *puVar7;
		        iVar9 = unnamed_function_1417(System_Func_KeyValuePair_string__object___string__TypeInfo);
		        func_ii_7795(iVar9,uVar6,
		                     Method_Core_Analytics_Service_Android_MyTrackerAnalyticsService___c__LogEvent_b__6_3__
		                     ,0);
		        *(int *)(*(int *)(Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo +
		                         0x5c) + 0x10) = iVar9;
		      }
		      uVar6 = System_Func_KeyValuePair_object__object___object____ctor
		                        (param4,iVar8,iVar9,
		                         Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_string__object___string__string___
		                        );
		      if (*(int *)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Mycom_Tracker_Unity_MyTracker_TypeInfo);
		      }
		      Mycom_Tracker_Unity_MyTracker__TrackLoginEvent(uVar5,0,uVar6,0);
		    }
		  }
		  else {
		    uVar10 = 0;
		    iVar2 = *param4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_IDictionary_string__object__TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		          puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81010d7a;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		    }
		    puVar3 = (uint *)func_ii_1080(param4,
		                                  System_Collections_Generic_IDictionary_string__object__TypeInfo,0)
		    ;
		code_r0x81010d7a:
		    piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param4,uVar5,puVar3[1]);
		    uVar5 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xd8) * 4))
		                      (piVar4,*(undefined4 *)(*piVar4 + 0xdc));
		    if (*(int *)(Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo + 0x74) == 0)
		    {
		      func_ii_306000(Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo);
		    }
		    puVar7 = *(undefined4 **)
		              (Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo + 0x5c);
		    iVar8 = puVar7[1];
		    iVar2 = Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo;
		    if (iVar8 == 0) {
		      if (*(int *)(Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo + 0x74) ==
		          0) {
		        func_ii_306000(Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo);
		        puVar7 = *(undefined4 **)
		                  (Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo + 0x5c);
		      }
		      uVar6 = *puVar7;
		      iVar8 = unnamed_function_1417(System_Func_KeyValuePair_string__object___string__TypeInfo);
		      func_ii_7795(iVar8,uVar6,
		                   Method_Core_Analytics_Service_Android_MyTrackerAnalyticsService___c__LogEvent_b__6_0__
		                   ,0);
		      iVar2 = Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo;
		      *(int *)(*(int *)(Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo + 0x5c
		                       ) + 4) = iVar8;
		    }
		    if (*(int *)(iVar2 + 0x74) == 0) {
		      func_ii_306000(iVar2);
		      iVar2 = Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo;
		    }
		    puVar7 = *(undefined4 **)(iVar2 + 0x5c);
		    iVar9 = puVar7[2];
		    if (iVar9 == 0) {
		      if (*(int *)(iVar2 + 0x74) == 0) {
		        func_ii_306000(iVar2);
		        puVar7 = *(undefined4 **)
		                  (Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo + 0x5c);
		      }
		      uVar6 = *puVar7;
		      iVar9 = unnamed_function_1417(System_Func_KeyValuePair_string__object___string__TypeInfo);
		      func_ii_7795(iVar9,uVar6,
		                   Method_Core_Analytics_Service_Android_MyTrackerAnalyticsService___c__LogEvent_b__6_1__
		                   ,0);
		      *(int *)(*(int *)(Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo + 0x5c
		                       ) + 8) = iVar9;
		    }
		    uVar6 = System_Func_KeyValuePair_object__object___object____ctor
		                      (param4,iVar8,iVar9,
		                       Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_string__object___string__string___
		                      );
		    if (*(int *)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Mycom_Tracker_Unity_MyTracker_TypeInfo);
		    }
		    Mycom_Tracker_Unity_MyTracker__TrackLevelEvent(uVar5,0,uVar6,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007101 RID: 28929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007101")]
		[Address(RVA = "0xBB28", Offset = "0xBB28", VA = "0xBB28", Slot = "8")]
		public void LogEvent(string eventTheme, string eventName, IDictionary<string, object> properties)
		{
		}

		// Token: 0x06007102 RID: 28930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007102")]
		[Address(RVA = "0xBB29", Offset = "0xBB29", VA = "0xBB29")]
		public MyTrackerAnalyticsService()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Analytics_Service_Android_MyTrackerAnalyticsService___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a594be == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo);
		    DAT_ram_00a594be = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo);
		  **(undefined4 **)(Core_Analytics_Service_Android_MyTrackerAnalyticsService___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}
	}
}
