using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Core.Net.Monitor.Responseability.Analysis;
using Core.Net.Monitor.Responseability.Testing.Common;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Core.Net.Monitor.Responseability
{
	// Token: 0x02000E98 RID: 3736
	[Token(Token = "0x2000E98")]
	public class LowResponseAbilityMonitor : ILowResponseAbilityMonitor, IDisposable
	{
		// Token: 0x14000225 RID: 549
		// (add) Token: 0x06005AD0 RID: 23248 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005AD1 RID: 23249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000225")]
		public event Action<ResponseAbilityStatus> ResponseAbilityChangedEvent
		{
			[Token(Token = "0x6005AD0")]
			[Address(RVA = "0xA7B4", Offset = "0xA7B4", VA = "0xA7B4", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005AD1")]
			[Address(RVA = "0xA7B5", Offset = "0xA7B5", VA = "0xA7B5", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000226 RID: 550
		// (add) Token: 0x06005AD2 RID: 23250 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005AD3 RID: 23251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000226")]
		public event Action<bool> ResponseTimeExceededEvent
		{
			[Token(Token = "0x6005AD2")]
			[Address(RVA = "0xA7B6", Offset = "0xA7B6", VA = "0xA7B6", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005AD3")]
			[Address(RVA = "0xA7B7", Offset = "0xA7B7", VA = "0xA7B7", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000227 RID: 551
		// (add) Token: 0x06005AD4 RID: 23252 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005AD5 RID: 23253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000227")]
		public event Action<double> TestRunEvent
		{
			[Token(Token = "0x6005AD4")]
			[Address(RVA = "0xA7B8", Offset = "0xA7B8", VA = "0xA7B8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005AD5")]
			[Address(RVA = "0xA7B9", Offset = "0xA7B9", VA = "0xA7B9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x06005AD6 RID: 23254 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005AD7 RID: 23255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001283")]
		public Configuration Config
		{
			[Token(Token = "0x6005AD6")]
			[Address(RVA = "0xA7BA", Offset = "0xA7BA", VA = "0xA7BA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005AD7")]
			[Address(RVA = "0xA7BB", Offset = "0xA7BB", VA = "0xA7BB")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x06005AD8 RID: 23256 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005AD9 RID: 23257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001284")]
		public IAnalysis Analysis
		{
			[Token(Token = "0x6005AD8")]
			[Address(RVA = "0xA7BC", Offset = "0xA7BC", VA = "0xA7BC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005AD9")]
			[Address(RVA = "0xA7BD", Offset = "0xA7BD", VA = "0xA7BD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005ADA RID: 23258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ADA")]
		[Address(RVA = "0xA7BE", Offset = "0xA7BE", VA = "0xA7BE", Slot = "10")]
		public void Dispose()
		{
		/* --- GHIDRA: <SetIsResponseTimeExceeded>b__29_0 ---
		void Core_Net_Monitor_Responseability_LowResponseAbilityMonitor___SetIsResponseTimeExceeded_b__29_0
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined8 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined8 *puVar5;
		  int *piVar6;
		  int iVar7;
		  undefined8 local_10;
		  int *local_4;
		  
		  if (DAT_ram_00a605b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_Monitor_Responseability_INetTestLauncher_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_Monitor_Responseability_Testing_Common_INetTest_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_2191);
		    DAT_ram_00a605b2 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Net_Monitor_Responseability_INetTestLauncher_TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81cade46;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Net_Monitor_Responseability_INetTestLauncher_TypeInfo,0)
		  ;
		code_r0x81cade46:
		  uVar2 = CONCAT44(in_register_20000014,&local_4);
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,uVar2,puVar3[1]);
		  piVar6 = local_4;
		  uVar4 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  if (iVar7 == 0) {
		    Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__ResetTest(param1,0,puVar3);
		  }
		  else {
		    if (*(char *)(param1 + 0x34) != '\0') {
		      uVar1 = 0;
		      iVar7 = *local_4;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (Core_Net_Monitor_Responseability_Testing_Common_INetTest_TypeInfo ==
		              *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x81cadedd;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(local_4,
		                                    Core_Net_Monitor_Responseability_Testing_Common_INetTest_TypeInfo
		                                    ,0);
		code_r0x81cadedd:
		      local_10 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,CONCAT44(uVar4,puVar3[1]));
		      uVar4 = func_ii_1081(DAT_ram_00a66964,&local_10);
		      puVar3 = (uint *)System_Collections_Generic_Dictionary_int__object___ContainsKey
		                                 (StringLiteral_2191,uVar4,param2,0);
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      System_Collections_Generic_Dictionary_uint__object___get_Count(puVar3,0);
		    }
		    Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__StatusChangedPostContextCallback
		              (param1,local_4,puVar3);
		    iVar7 = *(int *)(param1 + 0x10);
		    if (iVar7 != 0) {
		      if (param2 == (int *)0x0) {
		        System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (*(int *)(*param2 + 0x20) != *(int *)(DAT_ram_00a66970 + 0x20)) {
		        System_Activator__CreateInstance(param2,DAT_ram_00a66970);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      puVar5 = (undefined8 *)func_ii_15774(param2);
		      (**(code **)((ulonglong)*(uint *)(iVar7 + 0xc) * 4))
		                (*(undefined4 *)(iVar7 + 0x20),*puVar5,*(undefined4 *)(iVar7 + 0x14));
		    }
		  }
		  return;
		}
		*/

		/* --- GHIDRA: Dispose ---
		void Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7,undefined4 param8)
		
		{
		  *(undefined4 *)(param1 + 0x30) = param3;
		  *(undefined4 *)(param1 + 0x20) = param2;
		  *(undefined4 *)(param1 + 0x24) = param4;
		  *(undefined4 *)(param1 + 0x18) = param5;
		  *(undefined1 *)(param1 + 0x34) = (undefined1)param7;
		  *(undefined4 *)(param1 + 0x14) = param6;
		  return;
		}
		*/

		}

		// Token: 0x06005ADB RID: 23259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ADB")]
		[Address(RVA = "0xA7BF", Offset = "0xA7BF", VA = "0xA7BF")]
		public LowResponseAbilityMonitor([NotNull] SynchronizationContext synchronizationContext, [NotNull] object syncMonitor, [NotNull] INetTestLauncher netTestLauncher, [NotNull] IAnalysis analysis, [NotNull] Configuration configuration, bool debug = false)
		{
		}

		// Token: 0x06005ADC RID: 23260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ADC")]
		[Address(RVA = "0xA7C0", Offset = "0xA7C0", VA = "0xA7C0", Slot = "9")]
		public void Monitor(ISrvAnswer value)
		{
		/* --- GHIDRA: Monitor ---
		void Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__Monitor
		               (int param1,uint param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a605ad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__SetIsResponseTimeExceeded_b__29_0__
		              );
		    Mono_Security_ASN1__get_Item(&System_Threading_SendOrPostCallback_TypeInfo);
		    DAT_ram_00a605ad = '\x01';
		  }
		  if (param2 != *(byte *)(param1 + 0x2c)) {
		    *(char *)(param1 + 0x2c) = (char)param2;
		    piVar2 = *(int **)(param1 + 0x20);
		    param1_00 = unnamed_function_1417(System_Threading_SendOrPostCallback_TypeInfo);
		    func_ii_13894(param1_00,param1,
		                  Method_Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__SetIsResponseTimeExceeded_b__29_0__
		                  ,0);
		    local_1 = *(undefined1 *)(param1 + 0x2c);
		    uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe8) * 4))
		              (piVar2,param1_00,uVar1,*(undefined4 *)(iVar3 + 0xec));
		  }
		  return;
		}
		*/

		/* --- GHIDRA: Monitor ---
		void Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__Monitor
		               (int param1,uint param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a605ad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__SetIsResponseTimeExceeded_b__29_0__
		              );
		    Mono_Security_ASN1__get_Item(&System_Threading_SendOrPostCallback_TypeInfo);
		    DAT_ram_00a605ad = '\x01';
		  }
		  if (param2 != *(byte *)(param1 + 0x2c)) {
		    *(char *)(param1 + 0x2c) = (char)param2;
		    piVar2 = *(int **)(param1 + 0x20);
		    param1_00 = unnamed_function_1417(System_Threading_SendOrPostCallback_TypeInfo);
		    func_ii_13894(param1_00,param1,
		                  Method_Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__SetIsResponseTimeExceeded_b__29_0__
		                  ,0);
		    local_1 = *(undefined1 *)(param1 + 0x2c);
		    uVar1 = func_ii_1081(DAT_ram_00a66944,&local_1);
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe8) * 4))
		              (piVar2,param1_00,uVar1,*(undefined4 *)(iVar3 + 0xec));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005ADD RID: 23261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ADD")]
		[Address(RVA = "0xA7C1", Offset = "0xA7C1", VA = "0xA7C1", Slot = "8")]
		public void Monitor(IEnumerable<ISrvCommand> value)
		{
		}

		// Token: 0x06005ADE RID: 23262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ADE")]
		[Address(RVA = "0xA7C2", Offset = "0xA7C2", VA = "0xA7C2")]
		private void SetIsResponseTimeExceeded(bool value)
		{
		/* --- GHIDRA: SetIsResponseTimeExceeded ---
		void Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__SetIsResponseTimeExceeded
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a605ae == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Net_Monitor_Responseability_LowResponseAbilityMonitor_StatusChangedPostContextCallback__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_Monitor_Responseability_ResponseAbilityStatus_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Threading_SendOrPostCallback_TypeInfo);
		    DAT_ram_00a605ae = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x1c);
		  *(int *)(param1 + 0x1c) = param2;
		  if (param2 != iVar2) {
		    piVar3 = *(int **)(param1 + 0x20);
		    param1_00 = unnamed_function_1417(System_Threading_SendOrPostCallback_TypeInfo);
		    func_ii_13894(param1_00,param1,
		                  Method_Core_Net_Monitor_Responseability_LowResponseAbilityMonitor_StatusChangedPostContextCallback__
		                  ,0);
		    local_4 = *(undefined4 *)(param1 + 0x1c);
		    uVar1 = func_ii_1081(Core_Net_Monitor_Responseability_ResponseAbilityStatus_TypeInfo,&local_4);
		    iVar2 = *piVar3;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (piVar3,param1_00,uVar1,*(undefined4 *)(iVar2 + 0xec));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005ADF RID: 23263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ADF")]
		[Address(RVA = "0xA7C3", Offset = "0xA7C3", VA = "0xA7C3")]
		private void SetStatus(ResponseAbilityStatus value)
		{
		/* --- GHIDRA: SetStatus ---
		void Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__SetStatus
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a605af == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_Monitor_Responseability_ResponseAbilityStatus_TypeInfo);
		    DAT_ram_00a605af = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (*(int *)(*param2 + 0x20) ==
		        *(int *)(Core_Net_Monitor_Responseability_ResponseAbilityStatus_TypeInfo + 0x20)) {
		      puVar1 = (undefined4 *)func_ii_15774(param2);
		      iVar2 = *(int *)(param1 + 8);
		      if (iVar2 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                  (*(undefined4 *)(iVar2 + 0x20),*puVar1,*(undefined4 *)(iVar2 + 0x14));
		      }
		      return;
		    }
		    System_Activator__CreateInstance
		              (param2,Core_Net_Monitor_Responseability_ResponseAbilityStatus_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005AE0 RID: 23264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AE0")]
		[Address(RVA = "0xA7C4", Offset = "0xA7C4", VA = "0xA7C4")]
		private void StatusChangedPostContextCallback(object value)
		{
		/* --- GHIDRA: StatusChangedPostContextCallback ---
		void Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__StatusChangedPostContextCallback
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int *piVar3;
		  int local_14;
		  byte *local_10;
		  undefined4 *local_c;
		  byte local_5;
		  undefined4 local_4;
		  
		  iVar2 = 0;
		  local_4 = *(undefined4 *)(param1 + 0x30);
		  local_5 = 0;
		  DAT_ram_009d3e38 = 0;
		  local_c = &local_4;
		  local_14 = 0;
		  local_10 = &local_5;
		  import::env::invoke_viii
		            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x48,local_4,&local_5,0);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    *(undefined4 *)(param1 + 0x28) = param2;
		code_r0x81cad4eb:
		    if (local_5 != 0) {
		      func_ii_21161(local_4);
		    }
		    if (iVar2 == 0) {
		      return;
		    }
		    System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar2 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_14 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) goto code_r0x81cad4eb;
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Contex_ram_0000360b + 0x26,&local_14);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005AE1 RID: 23265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AE1")]
		[Address(RVA = "0x3632", Offset = "0x3632", VA = "0x3632")]
		private void RequestTest(double avgLatency)
		{
		}

		// Token: 0x06005AE2 RID: 23266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AE2")]
		[Address(RVA = "0xA7C5", Offset = "0xA7C5", VA = "0xA7C5")]
		private void SetTest(INetTest test)
		{
		/* --- GHIDRA: SetTest ---
		void Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__SetTest
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  int iVar3;
		  undefined4 param1_00;
		  undefined4 *puVar4;
		  int iVar5;
		  int *piVar6;
		  undefined1 auStack_20 [12];
		  int local_14;
		  byte *local_10;
		  undefined4 *local_c;
		  byte local_5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a605b1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    DAT_ram_00a605b1 = '\x01';
		  }
		  Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__ResetTest(param1,0,auStack_20);
		  local_4 = *(undefined4 *)(param1 + 0x30);
		  local_5 = 0;
		  DAT_ram_009d3e38 = 0;
		  local_c = &local_4;
		  local_14 = 0;
		  local_10 = &local_5;
		  import::env::invoke_viii
		            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x48,local_4,&local_5,0);
		  iVar3 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar3 == 1) {
		    param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    iVar3 = 3;
		    piVar6 = *(int **)(param1 + 0x28);
		    if (piVar6 == (int *)0x0) {
		      iVar5 = 0;
		      goto code_r0x81cad256;
		    }
		    uVar2 = 0;
		    iVar5 = *piVar6;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		          puVar4 = (undefined4 *)
		                   (iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81cad1c1;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                        System_IDisposable_TypeInfo,0);
		    if (DAT_ram_009d3e38 != 1) {
		code_r0x81cad1c1:
		      iVar5 = 0;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii(*puVar4,piVar6,puVar4[1]);
		      if (DAT_ram_009d3e38 != 1) goto code_r0x81cad256;
		    }
		    DAT_ram_009d3e38 = 0;
		    param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar3 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar3 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar5 = *piVar6;
		    iVar3 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_14 = iVar5;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		code_r0x81cad256:
		      DAT_ram_009d3e38 = 0;
		      if (local_5 != 0) {
		        func_ii_21161(local_4);
		      }
		      if (iVar5 == 0) {
		        if ((iVar3 == 0) || (((iVar3 != 1 && (iVar3 != 2)) && (iVar3 == 3)))) {
		          Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__StatusChangedPostContextCallback
		                    (param1,0,auStack_20);
		        }
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Contex_ram_0000360b + 0x24,&local_14);
		  iVar3 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar3 != 1) {
		    import::env::__resumeException(param1_00);
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
		*/

		}

		// Token: 0x06005AE3 RID: 23267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AE3")]
		[Address(RVA = "0xA7C6", Offset = "0xA7C6", VA = "0xA7C6")]
		private void ResetTest()
		{
		/* --- GHIDRA: ResetTest ---
		void Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__ResetTest
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int *piVar3;
		  int local_14;
		  byte *local_10;
		  undefined4 *local_c;
		  byte local_5;
		  undefined4 local_4;
		  
		  iVar2 = 0;
		  local_4 = *(undefined4 *)(param1 + 0x30);
		  local_5 = 0;
		  DAT_ram_009d3e38 = 0;
		  local_c = &local_4;
		  local_14 = 0;
		  local_10 = &local_5;
		  import::env::invoke_viii
		            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x48,local_4,&local_5,0);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    *(undefined1 *)(param1 + 0x2d) = (undefined1)param2;
		code_r0x81cad3ab:
		    if (local_5 != 0) {
		      func_ii_21161(local_4);
		    }
		    if (iVar2 == 0) {
		      return;
		    }
		    System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar2 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_14 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) goto code_r0x81cad3ab;
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Contex_ram_0000360b + 0x25,&local_14);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005AE4 RID: 23268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AE4")]
		[Address(RVA = "0xA7C7", Offset = "0xA7C7", VA = "0xA7C7")]
		private void SetTestRequest(bool value)
		{
		/* --- GHIDRA: SetTestRequest ---
		void Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__SetTestRequest
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined1 *puVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0xc);
		  if (iVar2 != 0) {
		    if (param2 == (int *)0x0) {
		      System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (*(int *)(*param2 + 0x20) != *(int *)(DAT_ram_00a66944 + 0x20)) {
		      System_Activator__CreateInstance(param2,DAT_ram_00a66944);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    puVar1 = (undefined1 *)func_ii_15774(param2);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*puVar1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x040031A7 RID: 12711
		[Token(Token = "0x40031A7")]
		[FieldOffset(Offset = "0x1C")]
		private ResponseAbilityStatus _status;

		// Token: 0x040031A8 RID: 12712
		[Token(Token = "0x40031A8")]
		[FieldOffset(Offset = "0x20")]
		private SynchronizationContext _synchronizationContext;

		// Token: 0x040031A9 RID: 12713
		[Token(Token = "0x40031A9")]
		[FieldOffset(Offset = "0x24")]
		private INetTestLauncher _netTestLauncher;

		// Token: 0x040031AA RID: 12714
		[Token(Token = "0x40031AA")]
		[FieldOffset(Offset = "0x28")]
		private INetTest _currentTest;

		// Token: 0x040031AB RID: 12715
		[Token(Token = "0x40031AB")]
		[FieldOffset(Offset = "0x2C")]
		private bool _isResponseTimeExceeded;

		// Token: 0x040031AC RID: 12716
		[Token(Token = "0x40031AC")]
		[FieldOffset(Offset = "0x2D")]
		private bool _testRequested;

		// Token: 0x040031AD RID: 12717
		[Token(Token = "0x40031AD")]
		[FieldOffset(Offset = "0x30")]
		private readonly object _syncMonitor;

		// Token: 0x040031AE RID: 12718
		[Token(Token = "0x40031AE")]
		[FieldOffset(Offset = "0x34")]
		private readonly bool _debug;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ResponseAbilityChangedEvent ---
		void Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__add_ResponseAbilityChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a605a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ResponseAbilityStatus__TypeInfo);
		    DAT_ram_00a605a7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ResponseAbilityStatus__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ResponseAbilityStatus__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: remove_ResponseAbilityChangedEvent ---
		void Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__remove_ResponseAbilityChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a605a8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    DAT_ram_00a605a8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_bool__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_bool__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: add_ResponseTimeExceededEvent ---
		void Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__add_ResponseTimeExceededEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a605a9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    DAT_ram_00a605a9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_bool__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_bool__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_ResponseTimeExceededEvent ---
		void Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__remove_ResponseTimeExceededEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a605aa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_double__TypeInfo);
		    DAT_ram_00a605aa = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_double__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_double__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
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


		/* --- GHIDRA: add_TestRunEvent ---
		void Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__add_TestRunEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a605ab == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_double__TypeInfo);
		    DAT_ram_00a605ab = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_double__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_double__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
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


		/* --- GHIDRA: set_Analysis ---
		void Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__set_Analysis
		               (int param1,undefined4 param2)
		
		{
		  Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__SetTest(param1,param1);
		  *(undefined8 *)(param1 + 0x14) = 0;
		  *(undefined4 *)(param1 + 0x20) = 0;
		  return;
		}
		*/

}
