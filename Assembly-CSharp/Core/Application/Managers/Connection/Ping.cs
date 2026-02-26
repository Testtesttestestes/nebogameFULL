using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Core.Gameplay.Managers.Configuration;
using Core.Net.Connection;
using Google.Protobuf;
using Il2CppDummyDll;
using UnityEngine;
using Utils;

namespace Core.Application.Managers.Connection
{
	// Token: 0x0200126C RID: 4716
	[Token(Token = "0x200126C")]
	public class Ping : IPing, IDisposable
	{
		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x06006FDF RID: 28639 RVA: 0x00014538 File Offset: 0x00012738
		// (set) Token: 0x06006FE0 RID: 28640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016D7")]
		public bool IsRun
		{
			[Token(Token = "0x6006FDF")]
			[Address(RVA = "0xBA2F", Offset = "0xBA2F", VA = "0xBA2F")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006FE0")]
			[Address(RVA = "0xBA30", Offset = "0xBA30", VA = "0xBA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006FE1 RID: 28641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FE1")]
		[Address(RVA = "0xBA31", Offset = "0xBA31", VA = "0xBA31", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x06006FE2 RID: 28642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FE2")]
		[Address(RVA = "0xBA32", Offset = "0xBA32", VA = "0xBA32")]
		public Ping(ConfigRecord config, IConnection connection)
		{
		/* --- GHIDRA: .ctor ---
		int Core_Application_Managers_Connection_Ping___ctor
		              (undefined4 param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a87a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Application_Managers_Connection_Ping__PingCoroutine_d__10_TypeInfo);
		    DAT_ram_00a5a87a = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Core_Application_Managers_Connection_Ping__PingCoroutine_d__10_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(float *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06006FE3 RID: 28643 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006FE3")]
		[Address(RVA = "0xBA33", Offset = "0xBA33", VA = "0xBA33")]
		private IEnumerator PingCoroutine(float timeout)
		{
		/* --- GHIDRA: PingCoroutine ---
		void Core_Application_Managers_Connection_Ping__PingCoroutine(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (*(char *)(param1 + 0x14) == '\0') {
		    if (*(char *)(param1 + 0x15) == '\0') {
		      iVar3 = *(int *)(*(int *)(param1 + 8) + 0x10);
		      if (DAT_ram_00a5a87a == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Core_Application_Managers_Connection_Ping__PingCoroutine_d__10_TypeInfo);
		        DAT_ram_00a5a87a = '\x01';
		      }
		      param1_00 = unnamed_function_1417
		                            (Core_Application_Managers_Connection_Ping__PingCoroutine_d__10_TypeInfo
		                            );
		      *(int *)(param1_00 + 0x14) = param1;
		      *(undefined4 *)(param1_00 + 8) = 0;
		      *(float *)(param1_00 + 0x10) = (float)iVar3 / 1000.0;
		      iVar3 = Utils_CoroutineSource__GetMono(param1_00,0);
		      *(int *)(param1 + 0xc) = iVar3;
		      *(bool *)(param1 + 0x15) = iVar3 != 0;
		    }
		    return;
		  }
		  uVar1 = unnamed_function_2232(&System_ObjectDisposedException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  uVar2 = unnamed_function_2232(&StringLiteral_12385);
		  func_ii_11454(uVar1,uVar2,0);
		  uVar2 = unnamed_function_2232(&Method_Core_Application_Managers_Connection_Ping_Run__);
		  func_ii_1050(uVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06006FE4 RID: 28644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FE4")]
		[Address(RVA = "0xBA34", Offset = "0xBA34", VA = "0xBA34")]
		public void Run()
		{
		/* --- GHIDRA: Run ---
		void Core_Application_Managers_Connection_Ping__Run(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (*(char *)(param1 + 0x14) == '\0') {
		    if (*(char *)(param1 + 0x15) != '\0') {
		      func_ii_7950(*(undefined4 *)(param1 + 0xc),0);
		      *(undefined1 *)(param1 + 0x15) = 0;
		    }
		    return;
		  }
		  uVar1 = unnamed_function_2232(&System_ObjectDisposedException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  uVar2 = unnamed_function_2232(&StringLiteral_12385);
		  func_ii_11454(uVar1,uVar2,0);
		  uVar2 = unnamed_function_2232(&Method_Core_Application_Managers_Connection_Ping_Stop__);
		  func_ii_1050(uVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006FE5 RID: 28645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FE5")]
		[Address(RVA = "0xBA35", Offset = "0xBA35", VA = "0xBA35")]
		public void Stop()
		{
		/* --- GHIDRA: Stop ---
		uint Core_Application_Managers_Connection_Ping__Stop
		               (undefined4 param1,undefined4 *param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined4 *puVar3;
		  int *param1_01;
		  
		  if (DAT_ram_00a5a87b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a5a87b = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  if (DAT_ram_00a60671 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a60671 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  uVar1 = func_ii_4769(*(undefined4 *)(*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 8),0);
		  if (uVar1 == 0) {
		    if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		    }
		    param1_00 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                          (Method_Core_Net_ServiceFactory_GetService_MainService___);
		    iVar2 = ServicesNamespace_MainService__SellArtifact(param1_00,0);
		    *param3 = iVar2;
		    param1_01 = *(int **)(iVar2 + 0x10);
		    if (param1_01 == (int *)0x0) {
		      System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (*(int *)(*param1_01 + 0x20) != *(int *)(DAT_ram_00a66958 + 0x20)) {
		      System_Activator__CreateInstance(param1_01,DAT_ram_00a66958);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    puVar3 = (undefined4 *)func_ii_15774(param1_01);
		    *param2 = *puVar3;
		  }
		  else {
		    *param2 = 0;
		    *param3 = 0;
		  }
		  return uVar1 ^ 1;
		}
		*/

		}

		// Token: 0x06006FE6 RID: 28646 RVA: 0x00014550 File Offset: 0x00012750
		[Token(Token = "0x6006FE6")]
		[Address(RVA = "0xBA36", Offset = "0xBA36", VA = "0xBA36", Slot = "4")]
		public bool TrySend(out uint index, out OpToken<IMessage, object> token)
		{
			return default(bool);
		}

		// Token: 0x04003A64 RID: 14948
		[Token(Token = "0x4003A64")]
		[FieldOffset(Offset = "0x8")]
		private ConfigRecord _config;

		// Token: 0x04003A65 RID: 14949
		[Token(Token = "0x4003A65")]
		[FieldOffset(Offset = "0xC")]
		private Coroutine _currentPingCoroutine;

		// Token: 0x04003A66 RID: 14950
		[Token(Token = "0x4003A66")]
		[FieldOffset(Offset = "0x10")]
		private IConnection _connection;

		// Token: 0x04003A67 RID: 14951
		[Token(Token = "0x4003A67")]
		[FieldOffset(Offset = "0x14")]
		private bool _disposed;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_IsRun ---
		void Core_Application_Managers_Connection_Ping__set_IsRun(int param1,undefined4 param2)
		
		{
		  Core_Application_Managers_Connection_Ping__Run(param1,param1);
		  *(undefined4 *)(param1 + 0x10) = 0;
		  *(undefined8 *)(param1 + 8) = 0;
		  *(undefined1 *)(param1 + 0x14) = 1;
		  return;
		}
		*/

}
