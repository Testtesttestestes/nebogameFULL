using System;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Il2CppDummyDll;

namespace Core.Net.Connection
{
	// Token: 0x02000EAB RID: 3755
	[Token(Token = "0x2000EAB")]
	public class SSLConnection : ThreadSafeConnection
	{
		// Token: 0x06005B43 RID: 23363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B43")]
		[Address(RVA = "0xA805", Offset = "0xA805", VA = "0xA805")]
		public SSLConnection(IPacketParser parser, int handleCmdQueuePeriod)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Net_Connection_SSLConnection___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a605d1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_Connection_SSLConnection_Internal_RunJob__);
		    Mono_Security_ASN1__get_Item(&System_Threading_WaitCallback_TypeInfo);
		    DAT_ram_00a605d1 = '\x01';
		  }
		  if (*(char *)(param1 + 0x34) != '\0') {
		    return;
		  }
		  if (DAT_ram_00a605e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Threading_CancellationTokenSource_TypeInfo);
		    DAT_ram_00a605e4 = '\x01';
		    if (*(char *)(param1 + 0x34) != '\0') goto code_r0x81cb162a;
		  }
		  uVar1 = unnamed_function_1417(System_Threading_CancellationTokenSource_TypeInfo);
		  Gameplay_Combat_Control_Conveyor__Next(uVar1,0);
		  *(undefined4 *)(param1 + 0x40) = uVar1;
		  Core_Net_Connection_AbstractConnection__GetEventHandlers(param1,param1);
		code_r0x81cb162a:
		  uVar1 = unnamed_function_1417(System_Threading_WaitCallback_TypeInfo);
		  System_Threading_EventWaitHandle__Set
		            (uVar1,param1,Method_Core_Net_Connection_SSLConnection_Internal_RunJob__,0);
		  System_Net_ExceptionHelper__get_RequestAbortedException(uVar1,*(undefined4 *)(param1 + 0x40),0);
		  return;
		}
		*/

		}

		// Token: 0x06005B44 RID: 23364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B44")]
		[Address(RVA = "0xA806", Offset = "0xA806", VA = "0xA806", Slot = "19")]
		public override void Run()
		{
		/* --- GHIDRA: Run ---
		void Core_Net_Connection_SSLConnection__Run(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  
		  if (DAT_ram_00a605d2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo);
		    DAT_ram_00a605d2 = '\x01';
		  }
		  if (*(char *)(param1 + 0x34) != '\0') {
		    param2_00 = unnamed_function_1417
		                          (Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo);
		    *(undefined4 *)(param2_00 + 8) = 3;
		    Core_Net_Connection_SSLConnection__Stop(param1,param2_00,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005B45 RID: 23365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B45")]
		[Address(RVA = "0xA807", Offset = "0xA807", VA = "0xA807", Slot = "20")]
		public override void Stop()
		{
		/* --- GHIDRA: Stop ---
		void Core_Net_Connection_SSLConnection__Stop(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  int *piVar1;
		  
		  if (DAT_ram_00a605d3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_Connection_ConnectionState_TypeInfo);
		    DAT_ram_00a605d3 = '\x01';
		  }
		  if (*(char *)(param1 + 0x34) != '\0') {
		    System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		              (*(undefined4 *)(param1 + 0x40),0);
		    System_Threading_CancellationTokenSource__Cancel(*(undefined4 *)(param1 + 0x40),0);
		    Core_Net_Connection_AbstractConnection__Run(param1,param1);
		    piVar1 = *(int **)(param1 + 0x4c);
		    if (piVar1 != (int *)0x0) {
		      (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x160) * 4))
		                (piVar1,*(undefined4 *)(*piVar1 + 0x164));
		    }
		    if (*(int *)(param1 + 0x48) != 0) {
		      System_Net_ServicePoint__CallEndPointDelegate(*(int *)(param1 + 0x48),0);
		    }
		    *(undefined8 *)(param1 + 0x48) = 0;
		    param2_00 = unnamed_function_1417(Core_Net_Connection_ConnectionState_TypeInfo);
		    *(undefined4 *)(param2_00 + 0xc) = param2;
		    *(undefined4 *)(param2_00 + 8) = 0;
		    Core_Net_Connection_AbstractConnection__get_CurrentState(param1,param2_00,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005B46 RID: 23366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B46")]
		[Address(RVA = "0xA808", Offset = "0xA808", VA = "0xA808")]
		private void InternalStop(ConnectionState.ConnectionStateReason reason)
		{
		/* --- GHIDRA: InternalStop ---
		void Core_Net_Connection_SSLConnection__InternalStop(int *param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a605d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&byte___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Threading_CancellationTokenSource_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_Connection_ConnectionState_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_Connection_SSLConnection_JobArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Net_Sockets_NetworkStream_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_Connection_SSLConnection_ReadJob__);
		    Mono_Security_ASN1__get_Item(&System_Threading_WaitCallback_TypeInfo);
		    DAT_ram_00a605d4 = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(System_Threading_CancellationTokenSource_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(System_Threading_CancellationTokenSource_TypeInfo + 0xb8) * 4 + -4)
		        != System_Threading_CancellationTokenSource_TypeInfo)) {
		      System_Activator__CreateInstance(param2,System_Threading_CancellationTokenSource_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = unnamed_function_1417(Core_Net_Connection_ConnectionState_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = 2;
		  iVar2 = unnamed_function_1417(Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo);
		  *(undefined4 *)(iVar2 + 8) = 3;
		  *(int *)(iVar1 + 0xc) = iVar2;
		  Core_Net_Connection_AbstractConnection__get_CurrentState(param1,iVar1,param1);
		  iVar1 = Core_Net_Connection_SSLConnection__GetSsl(param1,param1);
		  param1[0x12] = iVar1;
		  iVar1 = System_Collections_Generic_LinkedList_object___AddFirst(param2,0);
		  if ((iVar1 == 0) && (iVar1 = param1[0x12], iVar1 != 0)) {
		    uVar3 = unnamed_function_1417(System_Net_Sockets_NetworkStream_TypeInfo);
		    System_Net_Sockets_Socket__Close(uVar3,iVar1,1,0);
		    iVar1 = Core_Net_Connection_SSLConnection__ReadJob(param1,uVar3,param1);
		    param1[0x13] = iVar1;
		    iVar1 = System_Collections_Generic_LinkedList_object___AddFirst(param2,0);
		    if ((iVar1 == 0) && (piVar4 = (int *)param1[0x13], piVar4 != (int *)0x0)) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x108) * 4))
		                        (piVar4,*(undefined4 *)(*piVar4 + 0x10c));
		      if (iVar1 != 0) {
		        iVar1 = *(int *)param1[0x13];
		        (**(code **)((ulonglong)*(uint *)(iVar1 + 0x138) * 4))
		                  ((int *)param1[0x13],param1[6],*(undefined4 *)(iVar1 + 0x13c));
		        iVar1 = *(int *)param1[0x13];
		        (**(code **)((ulonglong)*(uint *)(iVar1 + 0x148) * 4))
		                  ((int *)param1[0x13],param1[5],*(undefined4 *)(iVar1 + 0x14c));
		      }
		      iVar1 = Mono_Security_ASN1Convert__ToOid(byte___TypeInfo,param1[7]);
		      param1[0x11] = iVar1;
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x188) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x18c));
		      if (iVar1 != 0) {
		        iVar1 = unnamed_function_1417
		                          (Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo);
		        *(undefined4 *)(iVar1 + 8) = 5;
		        Core_Net_Connection_SSLConnection__Stop(param1,iVar1,param1);
		        return;
		      }
		      (**(code **)((ulonglong)*(uint *)(*param1 + 0x168) * 4))
		                (param1,*(undefined4 *)(*param1 + 0x16c));
		      iVar1 = unnamed_function_1417(Core_Net_Connection_ConnectionState_TypeInfo);
		      *(undefined4 *)(iVar1 + 8) = 1;
		      Core_Net_Connection_AbstractConnection__get_CurrentState(param1,iVar1,param1);
		      iVar2 = param1[0x13];
		      uVar3 = func_ii_6977(param2,0);
		      iVar1 = unnamed_function_1417(Core_Net_Connection_SSLConnection_JobArgs_TypeInfo);
		      *(undefined4 *)(iVar1 + 0xc) = uVar3;
		      *(int *)(iVar1 + 8) = iVar2;
		      uVar3 = unnamed_function_1417(System_Threading_WaitCallback_TypeInfo);
		      System_Threading_EventWaitHandle__Set
		                (uVar3,param1,Method_Core_Net_Connection_SSLConnection_ReadJob__,0);
		      System_Net_ExceptionHelper__get_RequestAbortedException(uVar3,iVar1,0);
		      iVar1 = System_Collections_Generic_LinkedList_object___AddFirst(param2,0);
		      while (iVar1 == 0) {
		        (**(code **)((ulonglong)*(uint *)(*param1 + 0x170) * 4))
		                  (param1,*(undefined4 *)(*param1 + 0x174));
		        System_Net_NclUtilities__IsFatal(param1[0xe],0);
		        iVar1 = System_Collections_Generic_LinkedList_object___AddFirst(param2,0);
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005B47 RID: 23367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B47")]
		[Address(RVA = "0xA809", Offset = "0xA809", VA = "0xA809")]
		private void Internal_RunJob(object args)
		{
		/* --- GHIDRA: Internal_RunJob ---
		void Core_Net_Connection_SSLConnection__Internal_RunJob(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  undefined4 uVar7;
		  int iVar8;
		  undefined4 *puVar9;
		  undefined4 *param2_00;
		  uint *puVar10;
		  int *piVar11;
		  int *piVar12;
		  int *piVar13;
		  
		  if (DAT_ram_00a605d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&byte___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Threading_CancellationToken_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_ICollection_PacketParser_Packet__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_Connection_SSLConnection_JobArgs_TypeInfo);
		    DAT_ram_00a605d5 = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(Core_Net_Connection_SSLConnection_JobArgs_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(Core_Net_Connection_SSLConnection_JobArgs_TypeInfo + 0xb8) * 4 + -4
		                ) != Core_Net_Connection_SSLConnection_JobArgs_TypeInfo)) {
		      System_Activator__CreateInstance(param2,Core_Net_Connection_SSLConnection_JobArgs_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  piVar6 = param2 + 3;
		  do {
		    if (*(int *)(System_Threading_CancellationToken_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Threading_CancellationToken_TypeInfo);
		    }
		    iVar2 = func_ii_8047(piVar6,0);
		    if (iVar2 != 0) {
		      return;
		    }
		    do {
		      if (*(int *)(System_Threading_CancellationToken_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Threading_CancellationToken_TypeInfo);
		      }
		      iVar2 = func_ii_8047(piVar6,0);
		      if (iVar2 != 0) break;
		      iVar2 = *(int *)param2[2];
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iiiiii
		                        (*(undefined4 *)(iVar2 + 0x1d0),(int *)param2[2],*(int *)(param1 + 0x44),0,
		                         *(undefined4 *)(*(int *)(param1 + 0x44) + 0xc),
		                         *(undefined4 *)(iVar2 + 0x1d4));
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar2 = global_1;
		        iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar2 != iVar3) goto code_r0x81cb3396;
		        piVar12 = (int *)import::env::__cxa_begin_catch(uVar4);
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::invoke_ii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                           &System_ObjectDisposedException_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x81cb335c:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_2();
		code_r0x81cb335f:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_v(0x123);
		          iVar2 = DAT_ram_009d3e38;
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          iVar3 = import::env::invoke_iii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar4,
		                             *(undefined4 *)*piVar12);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x81cb335c;
		          if (iVar3 != 0) {
		code_r0x81cb3347:
		            DAT_ram_009d3e38 = 0;
		            import::env::__cxa_end_catch();
		            return;
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::invoke_ii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                             &System_OperationCanceledException_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x81cb335c;
		          DAT_ram_009d3e38 = 0;
		          iVar3 = import::env::invoke_iii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar4,
		                             *(undefined4 *)*piVar12);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x81cb335c;
		          if (iVar3 != 0) goto code_r0x81cb3347;
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::invoke_ii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                             &System_IO_IOException_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x81cb335c;
		          DAT_ram_009d3e38 = 0;
		          iVar5 = import::env::invoke_iii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar4,
		                             *(undefined4 *)*piVar12);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 == 1) goto code_r0x81cb335c;
		          if (iVar5 != 0) {
		            piVar12 = (int *)*piVar12;
		            import::env::__cxa_end_catch();
		            uVar4 = unnamed_function_2232
		                              (&Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo);
		            iVar2 = unnamed_function_1417(uVar4);
		            *(undefined4 *)(iVar2 + 8) = 1;
		            uVar4 = (**(code **)((ulonglong)*(uint *)(*piVar12 + 0xe8) * 4))
		                              (piVar12,*(undefined4 *)(*piVar12 + 0xec));
		            uVar7 = unnamed_function_2232(&StringLiteral_7567);
		            uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar7,uVar4,0);
		            uVar7 = unnamed_function_2232(&System_Text_StringBuilder_TypeInfo);
		            piVar13 = (int *)unnamed_function_1417(uVar7);
		            System_Text_Latin1Encoding___cctor(piVar13,uVar4,0);
		            piVar11 = (int *)piVar12[5];
		            if (piVar11 != (int *)0x0) {
		              iVar3 = unnamed_function_2232(&System_Net_Sockets_SocketException_TypeInfo);
		              iVar5 = *piVar11;
		              if (((uint)*(byte *)(iVar3 + 0xb8) <= (uint)*(byte *)(iVar5 + 0xb8)) &&
		                 (*(int *)(*(int *)(iVar5 + 100) + (uint)*(byte *)(iVar3 + 0xb8) * 4 + -4) == iVar3)
		                 ) {
		                uVar4 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x130) * 4))
		                                  (piVar11,*(undefined4 *)(iVar5 + 0x134));
		                *(undefined4 *)(iVar2 + 0x10) = uVar4;
		              }
		              iVar3 = *(int *)piVar12[5];
		              uVar4 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe8) * 4))
		                                ((int *)piVar12[5],*(undefined4 *)(iVar3 + 0xec));
		              uVar7 = unnamed_function_2232(&StringLiteral_9378);
		              uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar7,uVar4,0);
		              func_ii_2010(piVar13,uVar4,0);
		            }
		            iVar3 = *piVar13;
		            uVar4 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0xd8) * 4))
		                              (piVar13,*(undefined4 *)(iVar3 + 0xdc));
		            *(undefined4 *)(iVar2 + 0xc) = uVar4;
		            Core_Net_Connection_SSLConnection__Stop(param1,iVar2,iVar3);
		            break;
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::invoke_ii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                             &System_AggregateException_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x81cb335c;
		          DAT_ram_009d3e38 = 0;
		          iVar5 = import::env::invoke_iii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar4,
		                             *(undefined4 *)*piVar12);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 == 1) goto code_r0x81cb335c;
		          if (iVar5 == 0) {
		            DAT_ram_009d3e38 = 0;
		            uVar4 = import::env::invoke_ii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                               &System_Exception_TypeInfo);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x81cb335c;
		            DAT_ram_009d3e38 = 0;
		            iVar3 = import::env::invoke_iii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar4,
		                               *(undefined4 *)*piVar12);
		            iVar2 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 == 1) goto code_r0x81cb335c;
		            if (iVar3 == 0) {
		              piVar6 = (int *)unnamed_function_951(4);
		              *piVar6 = *piVar12;
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,piVar6,
		                         &DAT_ram_0072c9c8,0);
		              iVar2 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar2 == 1) {
		                uVar4 = import::env::__cxa_find_matching_catch_2();
		                goto code_r0x81cb335f;
		              }
		              goto code_r0x81cb3355;
		            }
		            piVar12 = (int *)*piVar12;
		            import::env::__cxa_end_catch();
		            uVar4 = unnamed_function_2232
		                              (&Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo);
		            iVar2 = unnamed_function_1417(uVar4);
		            *(undefined4 *)(iVar2 + 8) = 1;
		            iVar3 = *piVar12;
		            uVar4 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe8) * 4))
		                              (piVar12,*(undefined4 *)(iVar3 + 0xec));
		            *(undefined4 *)(iVar2 + 0xc) = uVar4;
		            Core_Net_Connection_SSLConnection__Stop(param1,iVar2,iVar2);
		            break;
		          }
		          iVar5 = *piVar12;
		          import::env::__cxa_end_catch();
		          DAT_ram_009d3e38 = 0;
		          iVar3 = import::env::invoke_ii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                             &Core_Net_Connection_SSLConnection___c_TypeInfo);
		          if (DAT_ram_009d3e38 != 1) {
		            if (*(int *)(iVar3 + 0x74) == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,iVar3);
		              if (DAT_ram_009d3e38 == 1) goto code_r0x81cb3019;
		            }
		            DAT_ram_009d3e38 = 0;
		            iVar3 = import::env::invoke_ii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                               &Core_Net_Connection_SSLConnection___c_TypeInfo);
		            if (DAT_ram_009d3e38 != 1) {
		              iVar3 = *(int *)(*(int *)(iVar3 + 0x5c) + 4);
		              if (iVar3 == 0) {
		                DAT_ram_009d3e38 = 0;
		                iVar3 = import::env::invoke_ii
		                                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                                   &Core_Net_Connection_SSLConnection___c_TypeInfo);
		                if (DAT_ram_009d3e38 != 1) {
		                  if (*(int *)(iVar3 + 0x74) == 0) {
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_vi
		                              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,iVar3);
		                    if (DAT_ram_009d3e38 == 1) goto code_r0x81cb3019;
		                  }
		                  DAT_ram_009d3e38 = 0;
		                  iVar3 = import::env::invoke_ii
		                                    (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                                     &Core_Net_Connection_SSLConnection___c_TypeInfo);
		                  if (DAT_ram_009d3e38 != 1) {
		                    uVar7 = **(undefined4 **)(iVar3 + 0x5c);
		                    DAT_ram_009d3e38 = 0;
		                    uVar4 = import::env::invoke_ii
		                                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                                       &System_Func_Exception__bool__TypeInfo);
		                    if (DAT_ram_009d3e38 != 1) {
		                      DAT_ram_009d3e38 = 0;
		                      iVar3 = import::env::invoke_ii
		                                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                         uVar4);
		                      if (DAT_ram_009d3e38 != 1) {
		                        DAT_ram_009d3e38 = 0;
		                        uVar4 = import::env::invoke_ii
		                                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                                           &
		                                           Method_Core_Net_Connection_SSLConnection___c__ReadJob_b__9_0__
		                                          );
		                        if (DAT_ram_009d3e38 != 1) {
		                          DAT_ram_009d3e38 = 0;
		                          import::env::invoke_viiii
		                                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,iVar3,
		                                     uVar7,uVar4,0);
		                          if (DAT_ram_009d3e38 != 1) {
		                            DAT_ram_009d3e38 = 0;
		                            iVar8 = import::env::invoke_ii
		                                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 +
		                                               0x1c,&Core_Net_Connection_SSLConnection___c_TypeInfo)
		                            ;
		                            if (DAT_ram_009d3e38 != 1) {
		                              *(int *)(*(int *)(iVar8 + 0x5c) + 4) = iVar3;
		                              DAT_ram_009d3e38 = 0;
		                              import::env::invoke_ii
		                                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                                         &Core_Net_Connection_SSLConnection___c_TypeInfo);
		                              if (DAT_ram_009d3e38 != 1) goto code_r0x81cb2fe7;
		                            }
		                          }
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		              else {
		code_r0x81cb2fe7:
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_viii
		                          (s___Scripting__UnityEngine__UnityS_ram_00003636 + 0xb,iVar5,iVar3,0);
		                iVar3 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar3 != 1) break;
		              }
		            }
		          }
		code_r0x81cb3019:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          if (iVar2 != global_1) goto code_r0x81cb3396;
		          puVar9 = (undefined4 *)import::env::__cxa_begin_catch(uVar4);
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::invoke_ii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                             &System_AggregateException_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x81cb30d0:
		            DAT_ram_009d3e38 = 0;
		            uVar4 = import::env::__cxa_find_matching_catch_2();
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            iVar3 = import::env::invoke_iii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar4,
		                               *(undefined4 *)*puVar9);
		            iVar2 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 == 1) goto code_r0x81cb30d0;
		            if (iVar3 != 0) {
		              import::env::__cxa_end_catch();
		              uVar4 = unnamed_function_2232
		                                (&Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo
		                                );
		              iVar2 = unnamed_function_1417(uVar4);
		              *(undefined4 *)(iVar2 + 8) = 1;
		              Core_Net_Connection_SSLConnection__Connect(iVar2,iVar5,iVar2);
		              Core_Net_Connection_SSLConnection__Stop(param1,iVar2,iVar2);
		              break;
		            }
		            param2_00 = (undefined4 *)unnamed_function_951(4);
		            *param2_00 = *puVar9;
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                       &DAT_ram_0072c9c8,0);
		            iVar2 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 != 1) {
		code_r0x81cb3355:
		              do {
		                halt_trap();
		              } while( true );
		            }
		            uVar4 = import::env::__cxa_find_matching_catch_2();
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_v(0x123);
		          iVar2 = DAT_ram_009d3e38;
		        }
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::__cxa_find_matching_catch_3(0);
		          unnamed_function_937();
		          do {
		            halt_trap();
		          } while( true );
		        }
		code_r0x81cb3396:
		        import::env::__resumeException(uVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (*(int *)(System_Threading_CancellationToken_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Threading_CancellationToken_TypeInfo);
		      }
		      iVar2 = func_ii_8047(piVar6,0);
		      if (iVar2 != 0) break;
		      if (iVar3 == 0) {
		        iVar2 = unnamed_function_1417
		                          (Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo);
		        *(undefined4 *)(iVar2 + 8) = 5;
		        Core_Net_Connection_SSLConnection__Stop(param1,iVar2,iVar2);
		        break;
		      }
		      iVar2 = *(int *)(param1 + 0x44);
		      if (iVar3 < *(int *)(iVar2 + 0xc)) {
		        iVar2 = Mono_Security_ASN1Convert__ToOid(byte___TypeInfo,iVar3);
		        System_Array__CreateInstance
		                  (*(undefined4 *)(param1 + 0x44),iVar2,*(undefined4 *)(iVar2 + 0xc),0);
		      }
		      if (DAT_ram_00a605cb == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Net_IPacketParser_TypeInfo);
		        DAT_ram_00a605cb = '\x01';
		      }
		      piVar12 = *(int **)(param1 + 0x30);
		      iVar3 = *piVar12;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar13 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		          if (Core_Net_IPacketParser_TypeInfo == *piVar13) {
		            puVar10 = (uint *)(piVar13[1] * 8 + iVar3 + 0xd8);
		            goto code_r0x81cb328e;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      puVar10 = (uint *)func_ii_1080(piVar12,Core_Net_IPacketParser_TypeInfo,3);
		code_r0x81cb328e:
		      piVar12 = (int *)(**(code **)((ulonglong)*puVar10 * 4))(piVar12,iVar2,puVar10[1]);
		      iVar2 = *piVar12;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar13 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_ICollection_PacketParser_Packet__TypeInfo == *piVar13) {
		            puVar10 = (uint *)(iVar2 + piVar13[1] * 8 + 0xc0);
		            goto code_r0x81cb330e;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar10 = (uint *)func_ii_1080(piVar12,
		                                     System_Collections_Generic_ICollection_PacketParser_Packet__TypeInfo
		                                     ,0);
		code_r0x81cb330e:
		      iVar2 = (**(code **)((ulonglong)*puVar10 * 4))(piVar12,puVar10[1]);
		      if (0 < iVar2) break;
		      if (*(int *)(System_Threading_CancellationToken_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Threading_CancellationToken_TypeInfo);
		      }
		      iVar2 = func_ii_8047(piVar6,0);
		    } while (iVar2 == 0);
		  } while( true );
		}
		*/

		}

		// Token: 0x06005B48 RID: 23368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B48")]
		[Address(RVA = "0xA80A", Offset = "0xA80A", VA = "0xA80A")]
		private void ReadJob(object args)
		{
		/* --- GHIDRA: ReadJob ---
		undefined4
		Core_Net_Connection_SSLConnection__ReadJob(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  
		  if (DAT_ram_00a605d6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Net_Security_RemoteCertificateValidationCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_Connection_SSLConnection_ValidateServerCertificate__);
		    Mono_Security_ASN1__get_Item(&System_Net_Security_SslStream_TypeInfo);
		    DAT_ram_00a605d6 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Net_Security_RemoteCertificateValidationCallback_TypeInfo);
		  MVC_AbstractController__HandleRun
		            (uVar1,0,Method_Core_Net_Connection_SSLConnection_ValidateServerCertificate__,0);
		  piVar2 = (int *)unnamed_function_1417(System_Net_Security_SslStream_TypeInfo);
		  System_Net_Security_SslStream___ctor(piVar2,param2,0,uVar1,0,0);
		  DAT_ram_009d3e38 = 0;
		  uVar1 = import::env::invoke_iii
		                    (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x32a,
		                     *(undefined4 *)(param1 + 0x10),0);
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(*piVar2 + 0x208),piVar2,uVar1,*(undefined4 *)(*piVar2 + 0x20c));
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      return piVar2;
		    }
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar4 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar3) {
		    piVar2 = (int *)import::env::__cxa_begin_catch(uVar1);
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Threading_ThreadAbortException_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar1,
		                         *(undefined4 *)*piVar2);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 != 1) {
		        if (iVar3 != 0) {
		          piVar2 = (int *)*piVar2;
		          import::env::__cxa_end_catch();
		          iVar4 = System_Threading_ThreadAbortException___ctor(piVar2,0);
		          if (iVar4 == *(int *)(param1 + 0x2c)) {
		            return 0;
		          }
		          uVar1 = unnamed_function_2232
		                            (&Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo);
		          iVar4 = unnamed_function_1417(uVar1);
		          *(undefined4 *)(iVar4 + 8) = 1;
		          uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe8) * 4))
		                            (piVar2,*(undefined4 *)(*piVar2 + 0xec));
		          *(undefined4 *)(iVar4 + 0xc) = uVar1;
		code_r0x81cb24b2:
		          Core_Net_Connection_SSLConnection__Stop(param1,iVar4,iVar4);
		          return 0;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar1 = import::env::invoke_ii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                           &System_Security_Authentication_AuthenticationException_TypeInfo);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          iVar3 = import::env::invoke_iii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar1,
		                             *(undefined4 *)*piVar2);
		          iVar4 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 != 1) {
		            if (iVar3 != 0) {
		              piVar2 = (int *)*piVar2;
		              import::env::__cxa_end_catch();
		              uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe8) * 4))
		                                (piVar2,*(undefined4 *)(*piVar2 + 0xec));
		              uVar5 = unnamed_function_2232(&StringLiteral_3451);
		              uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar5,uVar1,0);
		              uVar5 = unnamed_function_2232(&System_Text_StringBuilder_TypeInfo);
		              piVar6 = (int *)unnamed_function_1417(uVar5);
		              System_Text_Latin1Encoding___cctor(piVar6,uVar1,0);
		              piVar2 = (int *)piVar2[5];
		              if (piVar2 != (int *)0x0) {
		                uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe8) * 4))
		                                  (piVar2,*(undefined4 *)(*piVar2 + 0xec));
		                uVar5 = unnamed_function_2232(&StringLiteral_62);
		                uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar5,uVar1,0);
		                func_ii_2010(piVar6,uVar1,0);
		              }
		              uVar1 = unnamed_function_2232
		                                (&Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo
		                                );
		              iVar4 = unnamed_function_1417(uVar1);
		              *(undefined4 *)(iVar4 + 8) = 4;
		              uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar6 + 0xd8) * 4))
		                                (piVar6,*(undefined4 *)(*piVar6 + 0xdc));
		              *(undefined4 *)(iVar4 + 0xc) = uVar1;
		              goto code_r0x81cb24b2;
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar1 = import::env::invoke_ii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                               &System_AggregateException_TypeInfo);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              iVar3 = import::env::invoke_iii
		                                (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar1,
		                                 *(undefined4 *)*piVar2);
		              iVar4 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar4 != 1) {
		                if (iVar3 != 0) {
		                  iVar3 = *piVar2;
		                  import::env::__cxa_end_catch();
		                  uVar1 = unnamed_function_2232
		                                    (&
		                                     Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo
		                                    );
		                  iVar4 = unnamed_function_1417(uVar1);
		                  *(undefined4 *)(iVar4 + 8) = 1;
		                  Core_Net_Connection_SSLConnection__Connect(iVar4,iVar3,iVar4);
		                  goto code_r0x81cb24b2;
		                }
		                DAT_ram_009d3e38 = 0;
		                uVar1 = import::env::invoke_ii
		                                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                                   &System_Exception_TypeInfo);
		                if (DAT_ram_009d3e38 != 1) {
		                  DAT_ram_009d3e38 = 0;
		                  iVar3 = import::env::invoke_iii
		                                    (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar1,
		                                     *(undefined4 *)*piVar2);
		                  iVar4 = DAT_ram_009d3e38;
		                  DAT_ram_009d3e38 = 0;
		                  if (iVar4 != 1) {
		                    if (iVar3 != 0) {
		                      piVar2 = (int *)*piVar2;
		                      import::env::__cxa_end_catch();
		                      uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe8) * 4))
		                                        (piVar2,*(undefined4 *)(*piVar2 + 0xec));
		                      uVar5 = unnamed_function_2232(&StringLiteral_7567);
		                      uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar5,uVar1,0);
		                      uVar5 = unnamed_function_2232(&System_Text_StringBuilder_TypeInfo);
		                      piVar6 = (int *)unnamed_function_1417(uVar5);
		                      System_Text_Latin1Encoding___cctor(piVar6,uVar1,0);
		                      piVar2 = (int *)piVar2[5];
		                      if (piVar2 != (int *)0x0) {
		                        uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe8) * 4))
		                                          (piVar2,*(undefined4 *)(*piVar2 + 0xec));
		                        uVar5 = unnamed_function_2232(&StringLiteral_62);
		                        uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar5,uVar1,0);
		                        func_ii_2010(piVar6,uVar1,0);
		                      }
		                      uVar1 = unnamed_function_2232
		                                        (&
		                                         Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo
		                                        );
		                      iVar4 = unnamed_function_1417(uVar1);
		                      *(undefined4 *)(iVar4 + 8) = 1;
		                      uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar6 + 0xd8) * 4))
		                                        (piVar6,*(undefined4 *)(*piVar6 + 0xdc));
		                      *(undefined4 *)(iVar4 + 0xc) = uVar1;
		                      goto code_r0x81cb24b2;
		                    }
		                    piVar6 = (int *)unnamed_function_951(4);
		                    *piVar6 = *piVar2;
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_viii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,piVar6,
		                               &DAT_ram_0072c9c8,0);
		                    if (DAT_ram_009d3e38 != 1) goto code_r0x81cb24ce;
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x81cb24ce:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005B49 RID: 23369 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B49")]
		[Address(RVA = "0xA80B", Offset = "0xA80B", VA = "0xA80B")]
		private SslStream GetSsl(Stream stream)
		{
		/* --- GHIDRA: GetSsl ---
		undefined4 Core_Net_Connection_SSLConnection__GetSsl(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int param1_00;
		  char *pcVar3;
		  int iVar4;
		  undefined4 *puVar5;
		  int iVar6;
		  undefined4 *puVar7;
		  undefined4 param2_00;
		  int *piVar8;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a605d7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Net_IPEndPoint_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Net_Sockets_Socket_TypeInfo);
		    DAT_ram_00a605d7 = '\x01';
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar1 = import::env::invoke_iii
		                    (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x32a,
		                     *(undefined4 *)(param1 + 0x10),0);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 == 1) {
		    uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cb1e21:
		    iVar6 = global_1;
		    iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar6 != iVar4) goto code_r0x81cb1f77;
		    puVar5 = (undefined4 *)import::env::__cxa_begin_catch(uVar1);
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Net_Sockets_SocketException_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar1,
		                         *(undefined4 *)*puVar5);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 != 1) {
		        if (iVar4 != 0) {
		          piVar8 = (int *)*puVar5;
		          import::env::__cxa_end_catch();
		          uVar1 = unnamed_function_2232
		                            (&Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo);
		          iVar6 = unnamed_function_1417(uVar1);
		          *(undefined4 *)(iVar6 + 8) = 1;
		          uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar8 + 0xe8) * 4))
		                            (piVar8,*(undefined4 *)(*piVar8 + 0xec));
		          *(undefined4 *)(iVar6 + 0xc) = uVar1;
		          uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar8 + 0x130) * 4))
		                            (piVar8,*(undefined4 *)(*piVar8 + 0x134));
		          *(undefined4 *)(iVar6 + 0x10) = uVar1;
		code_r0x81cb1f7d:
		          Core_Net_Connection_SSLConnection__Stop(param1,iVar6,iVar6);
		          return 0;
		        }
		        puVar7 = (undefined4 *)unnamed_function_951(4);
		        *puVar7 = *puVar5;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,puVar7,&DAT_ram_0072c9c8,0
		                  );
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81cb1f75;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii(s_struct_VertexOutput____builtin_p_ram_00002c3d + 0xbf,uVar1,0);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cb1e21;
		    }
		    iVar4 = *(int *)(iVar2 + 0x10);
		    if (*(int *)(iVar4 + 0xc) < 1) {
		      DAT_ram_009d3e38 = 0;
		      return 0;
		    }
		    while( true ) {
		      DAT_ram_009d3e38 = 0;
		      param2_00 = *(undefined4 *)(iVar4 + iVar6 * 4 + 0x10);
		      uVar1 = System_Net_Sockets_Socket___ctor(*(undefined4 *)(param1 + 0x10),0);
		      piVar8 = (int *)unnamed_function_1417(System_Net_IPEndPoint_TypeInfo);
		      func_ii_11377(piVar8,param2_00,uVar1,0);
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar8 + 0xe0) * 4))
		                        (piVar8,*(undefined4 *)(*piVar8 + 0xe4));
		      param1_00 = unnamed_function_1417(System_Net_Sockets_Socket_TypeInfo);
		      System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebConnection__Connect_d__16_
		                (param1_00,uVar1,1,6,0);
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s___Scripting__UnityEngine__UnityS_ram_00003636 + 10,param1_00,piVar8,0);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) break;
		      if (*(char *)(param1_00 + 0x32) != '\0') {
		        DAT_ram_009d3e38 = 0;
		        return param1_00;
		      }
		      iVar6 = iVar6 + 1;
		      if (*(int *)(iVar4 + 0xc) <= iVar6) {
		        DAT_ram_009d3e38 = 0;
		        return 0;
		      }
		    }
		    uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar6 = global_1;
		    iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar6 != iVar4) goto code_r0x81cb1f77;
		    puVar5 = (undefined4 *)import::env::__cxa_begin_catch(uVar1);
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Net_Sockets_SocketException_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar1,
		                         *(undefined4 *)*puVar5);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 != 1) {
		        if (iVar4 != 0) {
		          piVar8 = (int *)*puVar5;
		          import::env::__cxa_end_catch();
		          pcVar3 = (char *)(**(code **)((ulonglong)*(uint *)(*piVar8 + 0x130) * 4))
		                                     (piVar8,*(undefined4 *)(*piVar8 + 0x134));
		          uVar1 = unnamed_function_2232
		                            (&Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo);
		          iVar6 = unnamed_function_1417(uVar1);
		          if (pcVar3 == s_var<private>_posTex__array<vec4<_ram_00002538 + 0x214) {
		            *(undefined4 *)(iVar6 + 8) = 2;
		            uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar8 + 0xe8) * 4))
		                              (piVar8,*(undefined4 *)(*piVar8 + 0xec));
		            *(undefined4 *)(iVar6 + 0xc) = uVar1;
		            uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar8 + 0x130) * 4))
		                              (piVar8,*(undefined4 *)(*piVar8 + 0x134));
		            *(undefined4 *)(iVar6 + 0x10) = uVar1;
		          }
		          else {
		            *(undefined4 *)(iVar6 + 8) = 1;
		            uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar8 + 0xe8) * 4))
		                              (piVar8,*(undefined4 *)(*piVar8 + 0xec));
		            *(undefined4 *)(iVar6 + 0xc) = uVar1;
		            uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar8 + 0x130) * 4))
		                              (piVar8,*(undefined4 *)(*piVar8 + 0x134));
		            *(undefined4 *)(iVar6 + 0x10) = uVar1;
		          }
		          goto code_r0x81cb1f7d;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar1 = import::env::invoke_ii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                           &System_ArgumentNullException_TypeInfo);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          iVar4 = import::env::invoke_iii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar1,
		                             *(undefined4 *)*puVar5);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 != 1) {
		            if (iVar4 != 0) {
		              piVar8 = (int *)*puVar5;
		              import::env::__cxa_end_catch();
		              uVar1 = unnamed_function_2232
		                                (&Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo
		                                );
		              iVar6 = unnamed_function_1417(uVar1);
		              *(undefined4 *)(iVar6 + 8) = 1;
		              iVar4 = *piVar8;
		              uVar1 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe8) * 4))
		                                (piVar8,*(undefined4 *)(iVar4 + 0xec));
		              *(undefined4 *)(iVar6 + 0xc) = uVar1;
		              goto code_r0x81cb1f7d;
		            }
		            puVar7 = (undefined4 *)unnamed_function_951(4);
		            *puVar7 = *puVar5;
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,puVar7,
		                       &DAT_ram_0072c9c8,0);
		            if (DAT_ram_009d3e38 != 1) goto code_r0x81cb1f75;
		          }
		        }
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		  }
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		code_r0x81cb1f75:
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x81cb1f77:
		  import::env::__resumeException(uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06005B4A RID: 23370 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B4A")]
		[Address(RVA = "0xA80C", Offset = "0xA80C", VA = "0xA80C")]
		private Socket Connect()
		{
		/* --- GHIDRA: Connect ---
		void Core_Net_Connection_SSLConnection__Connect(int param1,int *param2,undefined4 param3)
		
		{
		  int *param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 param4;
		  int *piVar5;
		  int *piVar6;
		  int param2_00;
		  int local_4;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a605d8 == '\0') {
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_ObjectModel_ReadOnlyCollection_Exception__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_ObjectModel_ReadOnlyCollection_Exception__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Net_Sockets_SocketException_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_47);
		    Mono_Security_ASN1__get_Item(&StringLiteral_64);
		    Mono_Security_ASN1__get_Item(&StringLiteral_87);
		    Mono_Security_ASN1__get_Item(&StringLiteral_66);
		    Mono_Security_ASN1__get_Item(&StringLiteral_63);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2958);
		    Mono_Security_ASN1__get_Item(&StringLiteral_49);
		    DAT_ram_00a605d8 = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  System_Text_Latin1Encoding___cctor(param1_00,StringLiteral_2958,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe8) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xec));
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_47,uVar1,0);
		  func_ii_2010(param1_00,uVar1,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x110) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0x114));
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_66,uVar1,0);
		  func_ii_2010(param1_00,uVar1,0);
		  piVar5 = (int *)param2[5];
		  if (piVar5 != (int *)0x0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xe8) * 4))
		                      (piVar5,*(undefined4 *)(*piVar5 + 0xec));
		    iVar2 = *(int *)param2[5];
		    uVar4 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		                      ((int *)param2[5],*(undefined4 *)(iVar2 + 0x114));
		    uVar1 = System_Int32__ToString(StringLiteral_63,uVar1,StringLiteral_66,uVar4,0);
		    func_ii_2010(param1_00,uVar1,0);
		  }
		  iVar2 = Sirenix_Utilities_ImmutableList___Il2CppFullySharedGenericType___System_Collections_IList_set_Item
		                    (param2[0x12],
		                     Method_System_Collections_ObjectModel_ReadOnlyCollection_Exception__get_Count__
		                    );
		  if (0 < iVar2) {
		    func_ii_2010(param1_00,StringLiteral_64,0);
		  }
		  iVar2 = Sirenix_Utilities_ImmutableList___Il2CppFullySharedGenericType___System_Collections_IList_set_Item
		                    (param2[0x12],
		                     Method_System_Collections_ObjectModel_ReadOnlyCollection_Exception__get_Count__
		                    );
		  if (0 < iVar2) {
		    do {
		      piVar5 = (int *)System_Collections_ObjectModel_ReadOnlyDictionary_object__object___get_Count
		                                (param2[0x12],param2_00,
		                                 Method_System_Collections_ObjectModel_ReadOnlyCollection_Exception__get_Item__
		                                );
		      piVar6 = (int *)piVar5[5];
		      if (piVar6 != (int *)0x0) {
		        iVar2 = *piVar6;
		        if (((uint)*(byte *)(System_Net_Sockets_SocketException_TypeInfo + 0xb8) <=
		             (uint)*(byte *)(iVar2 + 0xb8)) &&
		           (*(int *)(*(int *)(iVar2 + 100) +
		                     (uint)*(byte *)(System_Net_Sockets_SocketException_TypeInfo + 0xb8) * 4 + -4)
		            == System_Net_Sockets_SocketException_TypeInfo)) {
		          uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))
		                            (piVar6,*(undefined4 *)(iVar2 + 0x134));
		          *(undefined4 *)(param1 + 0x10) = uVar1;
		        }
		      }
		      piVar6 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,4);
		      local_4 = param2_00;
		      iVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		      if ((iVar2 != 0) && (iVar3 = func_ii_1082(iVar2,*(undefined4 *)(*piVar6 + 0x20)), iVar3 == 0))
		      {
		        uVar1 = func_ii_1083();
		        func_ii_1050(uVar1,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar6[4] = iVar2;
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xe8) * 4))
		                        (piVar5,*(undefined4 *)(*piVar5 + 0xec));
		      if ((iVar2 != 0) && (iVar3 = func_ii_1082(iVar2,*(undefined4 *)(*piVar6 + 0x20)), iVar3 == 0))
		      {
		        uVar1 = func_ii_1083();
		        func_ii_1050(uVar1,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar6[5] = iVar2;
		      iVar2 = unnamed_function_143827(piVar5);
		      if ((iVar2 != 0) && (iVar3 = func_ii_1082(iVar2,*(undefined4 *)(*piVar6 + 0x20)), iVar3 == 0))
		      {
		        uVar1 = func_ii_1083();
		        func_ii_1050(uVar1,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar6[6] = iVar2;
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x110) * 4))
		                        (piVar5,*(undefined4 *)(*piVar5 + 0x114));
		      if ((iVar2 != 0) && (iVar3 = func_ii_1082(iVar2,*(undefined4 *)(*piVar6 + 0x20)), iVar3 == 0))
		      {
		        uVar1 = func_ii_1083();
		        func_ii_1050(uVar1,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar6[7] = iVar2;
		      uVar1 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                        (StringLiteral_87,piVar6,0);
		      func_ii_2010(param1_00,uVar1,0);
		      piVar6 = (int *)piVar5[5];
		      if (piVar6 != (int *)0x0) {
		        uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar6 + 0xe8) * 4))
		                          (piVar6,*(undefined4 *)(*piVar6 + 0xec));
		        uVar4 = unnamed_function_143827(piVar5[5]);
		        iVar2 = *(int *)piVar5[5];
		        param4 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		                           ((int *)piVar5[5],*(undefined4 *)(iVar2 + 0x114));
		        uVar1 = func_ii_8529(StringLiteral_49,uVar1,uVar4,param4,0);
		        func_ii_2010(param1_00,uVar1,0);
		      }
		      iVar2 = Sirenix_Utilities_ImmutableList___Il2CppFullySharedGenericType___System_Collections_IList_set_Item
		                        (param2[0x12],
		                         Method_System_Collections_ObjectModel_ReadOnlyCollection_Exception__get_Count__
		                        );
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < iVar2);
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                    (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005B4B RID: 23371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B4B")]
		[Address(RVA = "0xA80D", Offset = "0xA80D", VA = "0xA80D")]
		private static void FillReasonFromAggregateException(ConnectionState.ConnectionStateReason reason, AggregateException ex)
		{
		/* --- GHIDRA: FillReasonFromAggregateException ---
		undefined4
		Core_Net_Connection_SSLConnection__FillReasonFromAggregateException(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = func_ii_11564(*(undefined4 *)(param1 + 0x48),
		                        s_var<private>_posTex__array<vec4<_ram_00002538 + 0x1d8,0,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06005B4C RID: 23372 RVA: 0x000103B0 File Offset: 0x0000E5B0
		[Token(Token = "0x6005B4C")]
		[Address(RVA = "0xA80E", Offset = "0xA80E", VA = "0xA80E", Slot = "25")]
		protected override bool Test()
		{
		/* --- GHIDRA: Test ---
		void Core_Net_Connection_SSLConnection__Test(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 *param2_00;
		  int *piVar5;
		  
		  if (DAT_ram_00a605d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Threading_Tasks_Task_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_Connection_SSLConnection___c__DisplayClass15_0__Send_b__0__);
		    Mono_Security_ASN1__get_Item(&Core_Net_Connection_SSLConnection___c__DisplayClass15_0_TypeInfo);
		    DAT_ram_00a605d9 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Net_Connection_SSLConnection___c__DisplayClass15_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 0xc) = param2;
		  *(int *)(iVar1 + 8) = param1;
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::invoke_ii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,System_Action_TypeInfo)
		  ;
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x81cb352e:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x381,uVar2,iVar1,
		               Method_Core_Net_Connection_SSLConnection___c__DisplayClass15_0__Send_b__0__,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81cb352e;
		    DAT_ram_009d3e38 = 0;
		    param3_00 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x37a,
		                           *(undefined4 *)(param1 + 0x40),0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      if (*(int *)(System_Threading_Tasks_Task_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   System_Threading_Tasks_Task_TypeInfo);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81cb354a;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_iiii
		                (s___Scripting__UnityEngine__UnityS_ram_00003636 + 0xc,uVar2,param3_00,0);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		code_r0x81cb354a:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    puVar4 = (undefined4 *)import::env::__cxa_begin_catch(uVar2);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Threading_Tasks_TaskCanceledException_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar1 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar2,
		                         *(undefined4 *)*puVar4);
		      if (DAT_ram_009d3e38 != 1) {
		        if (iVar1 != 0) {
		code_r0x81cb36b8:
		          DAT_ram_009d3e38 = 0;
		          piVar5 = (int *)*puVar4;
		          import::env::__cxa_end_catch();
		          uVar2 = unnamed_function_2232
		                            (&Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo);
		          iVar1 = unnamed_function_1417(uVar2);
		          *(undefined4 *)(iVar1 + 8) = 1;
		          iVar3 = *piVar5;
		          uVar2 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe8) * 4))
		                            (piVar5,*(undefined4 *)(iVar3 + 0xec));
		          *(undefined4 *)(iVar1 + 0xc) = uVar2;
		          Core_Net_Connection_SSLConnection__Stop(param1,iVar1,iVar1);
		          return;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_ii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                           &System_ObjectDisposedException_TypeInfo);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          iVar3 = import::env::invoke_iii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar2,
		                             *(undefined4 *)*puVar4);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 != 1) {
		            if (iVar3 != 0) goto code_r0x81cb36b8;
		            param2_00 = (undefined4 *)unnamed_function_951(4);
		            *param2_00 = *puVar4;
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                       &DAT_ram_0072c9c8,0);
		            if (DAT_ram_009d3e38 != 1) goto code_r0x81cb3704;
		          }
		        }
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x81cb3704:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x06005B4D RID: 23373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B4D")]
		[Address(RVA = "0xA80F", Offset = "0xA80F", VA = "0xA80F", Slot = "26")]
		protected override void Send(SrvCommand command)
		{
		/* --- GHIDRA: Send ---
		uint Core_Net_Connection_SSLConnection__Send
		               (undefined4 param1,undefined4 param2,undefined4 param3,int param4,undefined4 param5)
		
		{
		  return (uint)(param4 == 0);
		}
		*/

		}

		// Token: 0x06005B4E RID: 23374 RVA: 0x000103C8 File Offset: 0x0000E5C8
		[Token(Token = "0x6005B4E")]
		[Address(RVA = "0xA810", Offset = "0xA810", VA = "0xA810")]
		private static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return default(bool);
		}

		// Token: 0x040031E4 RID: 12772
		[Token(Token = "0x40031E4")]
		[FieldOffset(Offset = "0x44")]
		private byte[] _buffer;

		// Token: 0x040031E5 RID: 12773
		[Token(Token = "0x40031E5")]
		[FieldOffset(Offset = "0x48")]
		private Socket _client;

		// Token: 0x040031E6 RID: 12774
		[Token(Token = "0x40031E6")]
		[FieldOffset(Offset = "0x4C")]
		private SslStream _sslStream;

		// Token: 0x040031E7 RID: 12775
		[Token(Token = "0x40031E7")]
		[FieldOffset(Offset = "0x50")]
		private object _sendSyncMonitor;

		// Token: 0x02000EAC RID: 3756
		[Token(Token = "0x2000EAC")]
		private class JobArgs
		{
			// Token: 0x06005B4F RID: 23375 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B4F")]
			[Address(RVA = "0xA811", Offset = "0xA811", VA = "0xA811")]
			public JobArgs(SslStream stream, CancellationToken cancellationToken)
			{
			}

			// Token: 0x040031E8 RID: 12776
			[Token(Token = "0x40031E8")]
			[FieldOffset(Offset = "0x8")]
			public readonly SslStream Stream;

			// Token: 0x040031E9 RID: 12777
			[Token(Token = "0x40031E9")]
			[FieldOffset(Offset = "0xC")]
			public CancellationToken CancellationToken;
		}
	}
}
