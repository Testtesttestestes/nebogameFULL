using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Core.Net.Connection
{
	// Token: 0x02000EB1 RID: 3761
	[Token(Token = "0x2000EB1")]
	public abstract class ThreadSafeConnection : AbstractConnection
	{
		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x06005B69 RID: 23401 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005B6A RID: 23402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700129E")]
		[CanBeNull]
		private protected CancellationTokenSource Cts
		{
			[Token(Token = "0x6005B69")]
			[Address(RVA = "0xA82B", Offset = "0xA82B", VA = "0xA82B")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6005B6A")]
			[Address(RVA = "0xA82C", Offset = "0xA82C", VA = "0xA82C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x06005B6B RID: 23403 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700129F")]
		protected override IEnumerable<ISrvCommand> CommandsAwaitAnswer
		{
			[Token(Token = "0x6005B6B")]
			[Address(RVA = "0xA82D", Offset = "0xA82D", VA = "0xA82D", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005B6C RID: 23404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B6C")]
		[Address(RVA = "0xA82E", Offset = "0xA82E", VA = "0xA82E")]
		public ThreadSafeConnection(IPacketParser parser, int handleCmdQueuePeriod)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Net_Connection_ThreadSafeConnection___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a605e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Threading_CancellationTokenSource_TypeInfo);
		    DAT_ram_00a605e4 = '\x01';
		  }
		  if (*(char *)(param1 + 0x34) == '\0') {
		    param1_00 = unnamed_function_1417(System_Threading_CancellationTokenSource_TypeInfo);
		    Gameplay_Combat_Control_Conveyor__Next(param1_00,0);
		    *(undefined4 *)(param1 + 0x40) = param1_00;
		    Core_Net_Connection_AbstractConnection__GetEventHandlers(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005B6D RID: 23405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B6D")]
		[Address(RVA = "0xA82F", Offset = "0xA82F", VA = "0xA82F", Slot = "19")]
		public override void Run()
		{
		/* --- GHIDRA: Run ---
		void Core_Net_Connection_ThreadSafeConnection__Run(int param1,undefined4 param2)
		
		{
		  if (*(char *)(param1 + 0x34) != '\0') {
		    System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		              (*(undefined4 *)(param1 + 0x40),0);
		    System_Threading_CancellationTokenSource__Cancel(*(undefined4 *)(param1 + 0x40),0);
		    Core_Net_Connection_AbstractConnection__Run(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005B6E RID: 23406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B6E")]
		[Address(RVA = "0xA830", Offset = "0xA830", VA = "0xA830", Slot = "20")]
		public override void Stop()
		{
		/* --- GHIDRA: Stop ---
		void Core_Net_Connection_ThreadSafeConnection__Stop(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  (**(code **)((ulonglong)*(uint *)(*param1 + 400) * 4))
		            (param1,param2,*(undefined4 *)(*param1 + 0x194));
		  return;
		}
		*/

		}

		// Token: 0x06005B6F RID: 23407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B6F")]
		[Address(RVA = "0xA831", Offset = "0xA831", VA = "0xA831", Slot = "18")]
		public override void Push(SrvCommand command)
		{
		/* --- GHIDRA: Push ---
		void Core_Net_Connection_ThreadSafeConnection__Push(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a605e5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Concurrent_ConcurrentDictionary_uint__SrvCommand__Clear__)
		    ;
		    DAT_ram_00a605e5 = '\x01';
		  }
		  System_Collections_Concurrent_ConcurrentDictionary_uint__object____ctor
		            (*(undefined4 *)(param1 + 0x3c),
		             Method_System_Collections_Concurrent_ConcurrentDictionary_uint__SrvCommand__Clear__);
		  return;
		}
		*/

		}

		// Token: 0x06005B70 RID: 23408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B70")]
		[Address(RVA = "0xA832", Offset = "0xA832", VA = "0xA832", Slot = "21")]
		public override void Rollback()
		{
		/* --- GHIDRA: Rollback ---
		uint Core_Net_Connection_ThreadSafeConnection__Rollback
		               (int param1,int param2,undefined4 *param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a605e6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Concurrent_ConcurrentDictionary_uint__SrvCommand__TryRemove__
		              );
		    DAT_ram_00a605e6 = '\x01';
		  }
		  *param3 = 0;
		  iVar2 = *(int *)(param2 + 8);
		  if (iVar2 != 0) {
		    do {
		      iVar1 = System_Collections_Concurrent_ConcurrentDictionary_uint__object___TryGetValueInternal
		                        (*(undefined4 *)(param1 + 0x3c),*(undefined4 *)(param2 + 8),param3,
		                         Method_System_Collections_Concurrent_ConcurrentDictionary_uint__SrvCommand__TryRemove__
		                        );
		    } while (iVar1 == 0);
		  }
		  return (uint)(iVar2 != 0);
		}
		*/

		}

		// Token: 0x06005B71 RID: 23409 RVA: 0x00010428 File Offset: 0x0000E628
		[Token(Token = "0x6005B71")]
		[Address(RVA = "0xA833", Offset = "0xA833", VA = "0xA833", Slot = "23")]
		protected override bool TryRemoveAwaitCommand(PacketParser.Packet packet, out SrvCommand cmd)
		{
		/* --- GHIDRA: TryRemoveAwaitCommand ---
		undefined4
		Core_Net_Connection_ThreadSafeConnection__TryRemoveAwaitCommand(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  uVar1 = unnamed_function_2232(&System_NotImplementedException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  UnityEngine_InputSystem_InputActionRebindingExtensions__ApplyBindingOverride(uVar1,0);
		  param2_00 = unnamed_function_2232(&Method_Core_Net_Connection_ThreadSafeConnection_Test__);
		  func_ii_1050(uVar1,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x06005B72 RID: 23410 RVA: 0x00010440 File Offset: 0x0000E640
		[Token(Token = "0x6005B72")]
		[Address(RVA = "0xA834", Offset = "0xA834", VA = "0xA834", Slot = "25")]
		protected override bool Test()
		{
			return default(bool);
		}

		// Token: 0x06005B73 RID: 23411
		[Token(Token = "0x6005B73")]
		protected abstract void Send(SrvCommand command);

		// Token: 0x040031F1 RID: 12785
		[Token(Token = "0x40031F1")]
		[FieldOffset(Offset = "0x3C")]
		protected readonly ConcurrentDictionary<uint, SrvCommand> _commandsAwaitAnswer;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Cts ---
		undefined4 Core_Net_Connection_ThreadSafeConnection__set_Cts(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a605e2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Concurrent_ConcurrentDictionary_uint__SrvCommand__get_Values__
		              );
		    DAT_ram_00a605e2 = '\x01';
		  }
		  uVar1 = System_Collections_Concurrent_ConcurrentDictionary_uint__object___System_Collections_IDictionary_get_Keys
		                    (*(undefined4 *)(param1 + 0x3c),
		                     Method_System_Collections_Concurrent_ConcurrentDictionary_uint__SrvCommand__get_Values__
		                    );
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_CommandsAwaitAnswer ---
		void Core_Net_Connection_ThreadSafeConnection__get_CommandsAwaitAnswer
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a605e3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Concurrent_ConcurrentDictionary_uint__SrvCommand___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Concurrent_ConcurrentDictionary_uint__SrvCommand__TypeInfo);
		    DAT_ram_00a605e3 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Concurrent_ConcurrentDictionary_uint__SrvCommand__TypeInfo
		                        );
		  System_Collections_Concurrent_ConcurrentDictionary_uint__object____cctor
		            (param1_00,
		             Method_System_Collections_Concurrent_ConcurrentDictionary_uint__SrvCommand___ctor__);
		  *(undefined4 *)(param1 + 0x3c) = param1_00;
		  Core_Net_Connection_AbstractConnection__set_IsRun(param1,param2,param3,param1);
		  return;
		}
		*/

}
