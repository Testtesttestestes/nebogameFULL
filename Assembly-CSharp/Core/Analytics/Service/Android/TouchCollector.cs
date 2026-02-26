using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Core.Analytics.Service.Android
{
	// Token: 0x02001297 RID: 4759
	[Token(Token = "0x2001297")]
	internal class TouchCollector
	{
		// Token: 0x06007118 RID: 28952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007118")]
		[Address(RVA = "0xBB3F", Offset = "0xBB3F", VA = "0xBB3F")]
		public TouchCollector()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Analytics_Service_Android_TouchCollector___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  undefined8 param4;
		  uint uVar5;
		  int iVar6;
		  undefined1 auStack_40 [8];
		  undefined8 local_38;
		  undefined4 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a594cc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__TouchCollector_TapInfoRecord__Clear__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__TouchCollector_TapInfoRecord__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__TouchCollector_TapInfoRecord__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__TouchCollector_TapInfoRecord__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__TouchCollector_TapInfoRecord__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Newtonsoft_Json_JsonConvert_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TouchCollector_TapInfoRecord__Add__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_int__TouchCollector_TapInfoRecord__GetEnumerator__
		              );
		    DAT_ram_00a594cc = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  if (*(char *)(param1 + 0x18) == '\0') {
		    uVar2 = *(undefined4 *)(param1 + 0xc);
		    if (*(int *)(Newtonsoft_Json_JsonConvert_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Newtonsoft_Json_JsonConvert_TypeInfo);
		    }
		    uVar2 = Newtonsoft_Json_JsonConvert__ToString(uVar2,0);
		    return uVar2;
		  }
		  param4 = Core_Analytics_Service_Android_TouchCollector__ConvertToViewPosition(param1,auStack_40);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 8),
		                     Method_System_Collections_Generic_Dictionary_int__TouchCollector_TapInfoRecord__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_int__TouchCollector_TapInfoRecord__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x152,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__TouchCollector_TapInfoRecord__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81012475;
		    }
		    if (iVar3 == 0) break;
		    local_20 = 0;
		    local_30 = 0;
		    local_28 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_38 = 0;
		    uVar2 = local_8._4_4_;
		    unnamed_function_184056
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2dd,local_8._4_4_,3,param4,
		               &local_38,auStack_40);
		    iVar3 = DAT_ram_009d3e38;
		    iVar6 = Method_System_Collections_Generic_List_TouchCollector_TapInfoRecord__Add__;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81012475;
		    }
		    iVar3 = *(int *)(param1 + 0xc);
		    *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		    uVar5 = *(uint *)(iVar3 + 0xc);
		    if (uVar5 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		      *(uint *)(iVar3 + 0xc) = uVar5 + 1;
		      *(undefined4 *)(*(int *)(iVar3 + 8) + uVar5 * 4 + 0x10) = uVar2;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar3,uVar2,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81012475:
		        iVar6 = global_1;
		        iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar6 == iVar3) {
		          piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		          iVar6 = *piVar4;
		          iVar3 = 0;
		          DAT_ram_009d3e38 = 0;
		          local_18 = iVar6;
		          import::env::invoke_v(0x123);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 != 1) {
		code_r0x810124c2:
		            DAT_ram_009d3e38 = 0;
		            if (iVar6 != 0) {
		              System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		              do {
		                halt_trap();
		              } while( true );
		            }
		            if (iVar3 != 0) {
		              if (iVar3 == 1) {
		                DAT_ram_009d3e38 = 0;
		                return 0;
		              }
		              if (iVar3 == 2) {
		                DAT_ram_009d3e38 = 0;
		                return 0;
		              }
		              if (iVar3 == 3) {
		                DAT_ram_009d3e38 = 0;
		                return 0;
		              }
		              if (iVar3 == 4) {
		                DAT_ram_009d3e38 = 0;
		                return 0;
		              }
		              if (iVar3 != 5) {
		                DAT_ram_009d3e38 = 0;
		                return 0;
		              }
		            }
		            System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		                      (*(undefined4 *)(param1 + 8),
		                       Method_System_Collections_Generic_Dictionary_int__TouchCollector_TapInfoRecord__Clear__
		                      );
		            *(undefined1 *)(param1 + 0x18) = 0;
		            uVar2 = *(undefined4 *)(param1 + 0xc);
		            if (*(int *)(Newtonsoft_Json_JsonConvert_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Newtonsoft_Json_JsonConvert_TypeInfo);
		            }
		            uVar2 = Newtonsoft_Json_JsonConvert__ToString(uVar2,0);
		            return uVar2;
		          }
		          uVar2 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2de,&local_18);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 != 1) {
		          import::env::__resumeException(uVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  iVar3 = 5;
		  iVar6 = local_18;
		  goto code_r0x810124c2;
		}
		*/

		}

		// Token: 0x06007119 RID: 28953 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007119")]
		[Address(RVA = "0xBB40", Offset = "0xBB40", VA = "0xBB40")]
		public string StopCollect()
		{
			return null;
		}

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x0600711A RID: 28954 RVA: 0x00014838 File Offset: 0x00012A38
		// (set) Token: 0x0600711B RID: 28955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001704")]
		public bool IsActive
		{
			[Token(Token = "0x600711A")]
			[Address(RVA = "0xBB41", Offset = "0xBB41", VA = "0xBB41")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600711B")]
			[Address(RVA = "0xBB42", Offset = "0xBB42", VA = "0xBB42")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600711C RID: 28956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600711C")]
		[Address(RVA = "0x1E69", Offset = "0x1E69", VA = "0x1E69")]
		public void Began(int touchId, Vector2 position)
		{
		/* --- GHIDRA: Began ---
		int * Core_Analytics_Service_Android_TouchCollector__Began(int *param1)
		
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

		// Token: 0x0600711D RID: 28957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600711D")]
		[Address(RVA = "0x1E68", Offset = "0x1E68", VA = "0x1E68")]
		public void Moved(int touchId, Vector2 position)
		{
		/* --- GHIDRA: Moved ---
		void Core_Analytics_Service_Android_TouchCollector__Moved
		               (int param1,undefined4 param2,undefined8 *param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined8 param3_00;
		  undefined4 param1_00;
		  undefined8 uVar6;
		  undefined8 local_18;
		  float4 local_10;
		  float4 local_c;
		  byte local_8;
		  undefined4 uStack_4;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a594cd == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__TouchCollector_TapInfoRecord__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__TouchCollector_TapInfoRecord__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__TouchCollector_TapInfoRecord__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__TouchCollector_TapInfoRecord__get_Values__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_All_TouchCollector_TapInfoRecord___)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Func_TouchCollector_TapInfoRecord__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int__get_Value__);
		    Mono_Security_ASN1__get_Item
		              (&Core_Analytics_Service_Android_TouchCollector_TapInfoRecord_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Service_Android_TouchCollector___c__DisplayClass12_0__Began_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Analytics_Service_Android_TouchCollector___c__DisplayClass12_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4628);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16408);
		    DAT_ram_00a594cd = '\x01';
		  }
		  if (*(char *)(param1 + 0x18) != '\0') {
		    iVar1 = GAFInternal_Core_GAFSetSequenceEvent__subscribe
		                      (*(undefined4 *)(param1 + 8),param2,
		                       Method_System_Collections_Generic_Dictionary_int__TouchCollector_TapInfoRecord__ContainsKey__
		                      );
		    if (iVar1 == 0) {
		      _local_8 = 0;
		      iVar1 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                        (*(undefined4 *)(param1 + 8),
		                         Method_System_Collections_Generic_Dictionary_int__TouchCollector_TapInfoRecord__get_Count__
		                        );
		      if (iVar1 == 0) {
		        iVar1 = 1;
		code_r0x81012ea1:
		        System_Data_SqlTypes_SqlInt32___ctor(&local_8,iVar1,Method_System_Nullable_int___ctor__);
		      }
		      else {
		        iVar2 = unnamed_function_1417
		                          (
		                          Core_Analytics_Service_Android_TouchCollector___c__DisplayClass12_0_TypeInfo
		                          );
		        *(undefined4 *)(iVar2 + 8) = 1;
		        do {
		          uVar3 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                            (*(undefined4 *)(param1 + 8),
		                             Method_System_Collections_Generic_Dictionary_int__TouchCollector_TapInfoRecord__get_Values__
		                            );
		          uVar4 = unnamed_function_1417(System_Func_TouchCollector_TapInfoRecord__bool__TypeInfo);
		          System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                    (uVar4,iVar2,
		                     Method_Core_Analytics_Service_Android_TouchCollector___c__DisplayClass12_0__Began_b__0__
		                     ,0);
		          iVar5 = System_Collections_Generic_Stack_object___Peek
		                            (uVar3,uVar4,
		                             Method_System_Linq_Enumerable_All_TouchCollector_TapInfoRecord___);
		          iVar1 = *(int *)(iVar2 + 8);
		          if (iVar5 != 0) goto code_r0x81012ea1;
		          *(int *)(iVar2 + 8) = iVar1 + 1;
		        } while (iVar1 + 1 < 0xb);
		      }
		      if (local_8 == 0) {
		        if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		          func_ii_306000(OKG_Logs_Debug_TypeInfo);
		        }
		        func_ii_7109(StringLiteral_4628,0);
		      }
		      else {
		        param1_00 = *(undefined4 *)(param1 + 8);
		        uVar3 = System_Nullable_DefaultEventSystem_FocusBasedEventSequenceContext___get_HasValue
		                          (&local_8,Method_System_Nullable_int__get_Value__);
		        param3_00 = Core_Analytics_Service_Android_TouchCollector__ConvertToViewPosition
		                              (param1,iVar2);
		        uVar6 = *param3;
		        iVar2 = UnityEngine_RefreshRate__ToString(0);
		        iVar1 = UnityEngine_Screen__get_width(0);
		        uVar4 = unnamed_function_1417
		                          (Core_Analytics_Service_Android_TouchCollector_TapInfoRecord_TypeInfo);
		        local_c = (float4)((float)((ulonglong)uVar6 >> 0x20) / (float)iVar1);
		        local_10 = (float4)((float)uVar6 / (float)iVar2);
		        local_18 = CONCAT44(local_c,local_10);
		        Core_Analytics_Service_Android_TouchCollector_TapInfoRecord__get_Phases
		                  (uVar4,uVar3,param3_00,&local_18,uVar4);
		        UnityEngine_Object__GetInstanceID
		                  (param1_00,param2,uVar4,
		                   Method_System_Collections_Generic_Dictionary_int__TouchCollector_TapInfoRecord__Add__
		                  );
		      }
		    }
		    else {
		      _local_8 = CONCAT44(uStack_4,param2);
		      uVar3 = func_ii_1081(DAT_ram_00a66954,&local_8);
		      uVar3 = func_ii_4419(StringLiteral_16408,uVar3,0);
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      func_ii_7109(uVar3,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600711E RID: 28958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600711E")]
		[Address(RVA = "0x1E6C", Offset = "0x1E6C", VA = "0x1E6C")]
		public void Ended(int touchId)
		{
		/* --- GHIDRA: Ended ---
		int * Core_Analytics_Service_Android_TouchCollector__Ended(int *param1)
		
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

		// Token: 0x0600711F RID: 28959 RVA: 0x00014850 File Offset: 0x00012A50
		[Token(Token = "0x600711F")]
		[Address(RVA = "0xBB43", Offset = "0xBB43", VA = "0xBB43")]
		private Vector2 ConvertToViewPosition(Vector2 position)
		{
		/* --- GHIDRA: ConvertToViewPosition ---
		longlong Core_Analytics_Service_Android_TouchCollector__ConvertToViewPosition
		                   (int param1,undefined4 param2)
		
		{
		  undefined8 param1_00;
		  double dVar1;
		  longlong lVar2;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a594d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    DAT_ram_00a594d0 = '\x01';
		  }
		  if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTime_TypeInfo);
		  }
		  param1_00 = ICSharpCode_SharpZipLib_Zip_ZipEntry___ctor(0);
		  local_8 = System_DateTime__op_Subtraction(param1_00,*(undefined8 *)(param1 + 0x10),0);
		  if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_TimeSpan_TypeInfo);
		  }
		  dVar1 = System_Net_FtpMethodInfo__GetMethodInfo(&local_8,0);
		  if (ABS(dVar1) < 9.223372036854776e+18) {
		    lVar2 = (longlong)dVar1;
		  }
		  else {
		    lVar2 = -0x8000000000000000;
		  }
		  return lVar2;
		}
		*/

			return default(Vector2);
		}

		// Token: 0x06007120 RID: 28960 RVA: 0x00014868 File Offset: 0x00012A68
		[Token(Token = "0x6007120")]
		[Address(RVA = "0xBB44", Offset = "0xBB44", VA = "0xBB44")]
		private long GetTimestamp()
		{
			return 0L;
		}

		// Token: 0x04003B03 RID: 15107
		[Token(Token = "0x4003B03")]
		private const float MoveThreshold = 0.01f;

		// Token: 0x04003B04 RID: 15108
		[Token(Token = "0x4003B04")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<int, TouchCollector.TapInfoRecord> _activeTaps;

		// Token: 0x04003B05 RID: 15109
		[Token(Token = "0x4003B05")]
		[FieldOffset(Offset = "0xC")]
		private readonly List<TouchCollector.TapInfoRecord> _tapsArchive;

		// Token: 0x04003B06 RID: 15110
		[Token(Token = "0x4003B06")]
		[FieldOffset(Offset = "0x10")]
		private readonly DateTime _startTime;

		// Token: 0x02001298 RID: 4760
		[Token(Token = "0x2001298")]
		private class TapPhaseRecord
		{
			// Token: 0x17001705 RID: 5893
			// (get) Token: 0x06007121 RID: 28961 RVA: 0x00014880 File Offset: 0x00012A80
			[Token(Token = "0x17001705")]
			public TouchPhase Phase
			{
				[Token(Token = "0x6007121")]
				[Address(RVA = "0xBB45", Offset = "0xBB45", VA = "0xBB45")]
				[CompilerGenerated]
				get
				{
					return TouchPhase.None;
				}
			}

			// Token: 0x17001706 RID: 5894
			// (get) Token: 0x06007122 RID: 28962 RVA: 0x00014898 File Offset: 0x00012A98
			[Token(Token = "0x17001706")]
			public Vector2 Position
			{
				[Token(Token = "0x6007122")]
				[Address(RVA = "0xBB46", Offset = "0xBB46", VA = "0xBB46")]
				[CompilerGenerated]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x17001707 RID: 5895
			// (get) Token: 0x06007123 RID: 28963 RVA: 0x000148B0 File Offset: 0x00012AB0
			[Token(Token = "0x17001707")]
			public long Timestamp
			{
				[Token(Token = "0x6007123")]
				[Address(RVA = "0xBB47", Offset = "0xBB47", VA = "0xBB47")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x06007124 RID: 28964 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007124")]
			[Address(RVA = "0xBB48", Offset = "0xBB48", VA = "0xBB48")]
			public TapPhaseRecord(TouchPhase phase, Vector2 position, long timestamp)
			{
			}

			// Token: 0x06007125 RID: 28965 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6007125")]
			[Address(RVA = "0xBB49", Offset = "0xBB49", VA = "0xBB49", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		// Token: 0x02001299 RID: 4761
		[Token(Token = "0x2001299")]
		private class TapInfoRecord
		{
			// Token: 0x17001708 RID: 5896
			// (get) Token: 0x06007126 RID: 28966 RVA: 0x000148C8 File Offset: 0x00012AC8
			[Token(Token = "0x17001708")]
			[JsonProperty("id")]
			public int Id
			{
				[Token(Token = "0x6007126")]
				[Address(RVA = "0xBB4A", Offset = "0xBB4A", VA = "0xBB4A")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001709 RID: 5897
			// (get) Token: 0x06007127 RID: 28967 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001709")]
			[JsonProperty("p")]
			public string[] Phases
			{
				[Token(Token = "0x6007127")]
				[Address(RVA = "0xBB4B", Offset = "0xBB4B", VA = "0xBB4B")]
				get
				{
					return null;
				}
			}

			// Token: 0x06007128 RID: 28968 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007128")]
			[Address(RVA = "0xBB4C", Offset = "0xBB4C", VA = "0xBB4C")]
			public TapInfoRecord(int tapId, long timestamp, Vector2 position)
			{
			}

			// Token: 0x06007129 RID: 28969 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007129")]
			[Address(RVA = "0x1E64", Offset = "0x1E64", VA = "0x1E64")]
			public void AddPhase(TouchPhase phase, long timestamp, Vector2? position)
			{
			}

			// Token: 0x04003B0B RID: 15115
			[Token(Token = "0x4003B0B")]
			[FieldOffset(Offset = "0x8")]
			private readonly List<TouchCollector.TapPhaseRecord> _phases;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_IsActive ---
		void Core_Analytics_Service_Android_TouchCollector__set_IsActive
		               (float *param1,undefined4 param2,float *param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  float fVar3;
		  float fVar4;
		  
		  fVar3 = *param3;
		  iVar1 = UnityEngine_RefreshRate__ToString(0);
		  fVar4 = param3[1];
		  iVar2 = UnityEngine_Screen__get_width(0);
		  *param1 = fVar3 / (float)iVar1;
		  param1[1] = fVar4 / (float)iVar2;
		  return;
		}
		*/

}
