using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Analytics;
using Core.Analytics.Listeners;
using Core.Analytics.Service.Android;
using Il2CppDummyDll;

namespace Core.Application.Managers.Analytics
{
	// Token: 0x02001276 RID: 4726
	[Token(Token = "0x2001276")]
	public class AnalyticsManager : IAppManager, IBaseManager, IAnalyticsListenerProvider
	{
		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x06007020 RID: 28704 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016E1")]
		public string Name
		{
			[Token(Token = "0x6007020")]
			[Address(RVA = "0xBA67", Offset = "0xBA67", VA = "0xBA67", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002F9 RID: 761
		// (add) Token: 0x06007021 RID: 28705 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007022 RID: 28706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002F9")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6007021")]
			[Address(RVA = "0xBA68", Offset = "0xBA68", VA = "0xBA68", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007022")]
			[Address(RVA = "0xBA69", Offset = "0xBA69", VA = "0xBA69", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002FA RID: 762
		// (add) Token: 0x06007023 RID: 28707 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007024 RID: 28708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002FA")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6007023")]
			[Address(RVA = "0xBA6A", Offset = "0xBA6A", VA = "0xBA6A", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007024")]
			[Address(RVA = "0xBA6B", Offset = "0xBA6B", VA = "0xBA6B", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06007025 RID: 28709 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007025")]
		public T GetAnalyticsListener<T>() where T : AbstractAnalyticsListener, new()
		{
			return null;
		}

		// Token: 0x06007026 RID: 28710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007026")]
		[Address(RVA = "0xBA6C", Offset = "0xBA6C", VA = "0xBA6C", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Application_Managers_Analytics_AnalyticsManager__Init(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int param1_01;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int *local_4;
		  
		  if (DAT_ram_00a5a892 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_WebGL_AnalyticsServiceProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo);
		    DAT_ram_00a5a892 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar3 = **(int **)(DAT_ram_00a66978 + 0x5c);
		  if (DAT_ram_00a5a7ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		    DAT_ram_00a5a7ed = '\x01';
		  }
		  iVar4 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  if (iVar4 == 0) {
		    param1_00 = unnamed_function_1417(Core_Application_App_TypeInfo);
		    Core_Application_App__set_FileDownloadLogger(param1_00,param1_00);
		    **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = param1_00;
		    iVar4 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		  }
		  piVar5 = *(int **)(*(int *)(iVar4 + 0x48) + 0x10);
		  iVar4 = *piVar5;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x81284493;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,
		                                Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo
		                                ,5);
		code_r0x81284493:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,&local_4,puVar2[1]);
		  piVar5 = local_4;
		  if (iVar4 != 0) {
		    uVar1 = 0;
		    iVar3 = *local_4;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		          goto code_r0x8128451d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(local_4,
		                                  Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo
		                                  ,2);
		code_r0x8128451d:
		    iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    iVar3 = *(int *)(iVar3 + 0x14);
		  }
		  iVar4 = UnityEngine_SystemInfo__GetPhysicalMemoryMB(0);
		  iVar6 = *(int *)(param1 + 0x18);
		  piVar5 = (int *)unnamed_function_1417
		                            (Core_Analytics_Service_WebGL_AnalyticsServiceProvider_TypeInfo);
		  if (DAT_ram_00a5a8c1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Type__IAnalyticsService___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_Type__IAnalyticsService__TypeInfo);
		    DAT_ram_00a5a8c1 = '\x01';
		  }
		  param1_01 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_Type__IAnalyticsService__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_01,Method_System_Collections_Generic_Dictionary_Type__IAnalyticsService___ctor__
		            );
		  piVar5[5] = param1_01;
		  piVar5[4] = iVar6;
		  piVar5[3] = iVar3;
		  piVar5[2] = iVar4;
		  *(int **)(param1 + 0x10) = piVar5;
		  (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xe8) * 4))
		            (piVar5,param1,*(undefined4 *)(*piVar5 + 0xec));
		  return;
		}
		*/

		}

		// Token: 0x06007027 RID: 28711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007027")]
		[Address(RVA = "0xBA6D", Offset = "0xBA6D", VA = "0xBA6D")]
		private void CreateAnalyticsServices()
		{
		/* --- GHIDRA: CreateAnalyticsServices ---
		void Core_Application_Managers_Analytics_AnalyticsManager__CreateAnalyticsServices
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  undefined1 auStack_20 [8];
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a893 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Type__AbstractAnalyticsListener__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_Type__AbstractAnalyticsListener__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_Type__AbstractAnalyticsListener__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_Type__AbstractAnalyticsListener__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Type__AbstractAnalyticsListener__GetEnumerator__
		              );
		    DAT_ram_00a5a893 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  Core_Analytics_AbstractAnalyticsServiceProvider___ctor(*(undefined4 *)(param1 + 0x10),auStack_20);
		  *(undefined4 *)(param1 + 0x10) = 0;
		  uVar1 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x14),
		                     Method_System_Collections_Generic_Dictionary_Type__AbstractAnalyticsListener__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar1,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_Type__AbstractAnalyticsListener__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1a2,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_Type__AbstractAnalyticsListener__MoveNext__
		                      );
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8128476f;
		    }
		    if (iVar2 == 0) goto code_r0x812847c5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x34,local_8._4_4_,0);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar4 != 1);
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8128476f:
		  iVar4 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar2) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar1);
		    iVar2 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x812847c5:
		      DAT_ram_009d3e38 = 0;
		      *(undefined4 *)(param1 + 0x14) = 0;
		      iVar4 = *(int *)(param1 + 0xc);
		      if (iVar4 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                  (*(undefined4 *)(iVar4 + 0x20),param1,*(undefined4 *)(iVar4 + 0x14));
		      }
		      return;
		    }
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x35,&local_18);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06007028 RID: 28712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007028")]
		[Address(RVA = "0xBA6E", Offset = "0xBA6E", VA = "0xBA6E", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Application_Managers_Analytics_AnalyticsManager__Deinit(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a894 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Type__AbstractAnalyticsListener___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_Type__AbstractAnalyticsListener__TypeInfo);
		    DAT_ram_00a5a894 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_Type__AbstractAnalyticsListener__TypeInfo
		                        );
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_Type__AbstractAnalyticsListener___ctor__);
		  *(undefined4 *)(param1 + 0x14) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06007029 RID: 28713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007029")]
		[Address(RVA = "0xBA6F", Offset = "0xBA6F", VA = "0xBA6F")]
		public AnalyticsManager()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Application_Managers_Analytics_AnalyticsManager___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5a895 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_ISkeletonGraphicProvider_TypeInfo);
		    DAT_ram_00a5a895 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Animations_ISkeletonGraphicProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81284bbe;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Animations_ISkeletonGraphicProvider_TypeInfo,0);
		code_r0x81284bbe:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/

		}

		// Token: 0x04003A85 RID: 14981
		[Token(Token = "0x4003A85")]
		[FieldOffset(Offset = "0x10")]
		private AbstractAnalyticsServiceProvider _analyticsServiceProvider;

		// Token: 0x04003A86 RID: 14982
		[Token(Token = "0x4003A86")]
		[FieldOffset(Offset = "0x14")]
		private Dictionary<Type, AbstractAnalyticsListener> _analyticsListeners;

		// Token: 0x04003A87 RID: 14983
		[Token(Token = "0x4003A87")]
		[FieldOffset(Offset = "0x18")]
		private DeviceIDProvider _deviceIDProvider;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Application_Managers_Analytics_AnalyticsManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a88d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a88d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Application_Managers_Analytics_AnalyticsManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a88e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a88e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Application_Managers_Analytics_AnalyticsManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a88f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a88f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Application_Managers_Analytics_AnalyticsManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a890 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a890 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_DeinitCompleteEvent ---
		void Core_Application_Managers_Analytics_AnalyticsManager__remove_DeinitCompleteEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5a891 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_Android_DeviceIDProvider_TypeInfo);
		    DAT_ram_00a5a891 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Analytics_Service_Android_DeviceIDProvider_TypeInfo);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  Core_Application_Managers_Analytics_AnalyticsManager__Init(param1,param1);
		  iVar2 = *(int *)(param1 + 8);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: GetAnalyticsListener<object> ---
		undefined4
		Core_Application_Managers_Analytics_AnalyticsManager__GetAnalyticsListener_object_
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param3_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a632d3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_HuaweiMobileServices_Utils_JavaObjectWrapper_CallAsWrapper_AndroidBundle___);
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23848);
		    DAT_ram_00a632d3 = '\x01';
		  }
		  param3_00 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,1);
		  if ((param2 != 0) && (iVar1 = func_ii_1082(param2,*(undefined4 *)(*param3_00 + 0x20)), iVar1 == 0)
		     ) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param3_00[4] = param2;
		  uVar2 = HuaweiMobileServices_Utils_JavaObjectWrapper__Call___Il2CppFullySharedGenericType_
		                    (param1,StringLiteral_23848,param3_00,
		                     Method_HuaweiMobileServices_Utils_JavaObjectWrapper_CallAsWrapper_AndroidBundle___
		                    );
		  return uVar2;
		}
		*/

}
