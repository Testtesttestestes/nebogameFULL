using System;
using System.Collections;
using System.Collections.Generic;
using BestHTTP.WebSocket;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.Net.Connection
{
	// Token: 0x02000EB2 RID: 3762
	[Token(Token = "0x2000EB2")]
	public class WebSocketConnection : AbstractConnection
	{
		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x06005B74 RID: 23412 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012A0")]
		protected override IEnumerable<ISrvCommand> CommandsAwaitAnswer
		{
			[Token(Token = "0x6005B74")]
			[Address(RVA = "0xA835", Offset = "0xA835", VA = "0xA835", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005B75 RID: 23413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B75")]
		[Address(RVA = "0xA836", Offset = "0xA836", VA = "0xA836")]
		public WebSocketConnection(IPacketParser parser, int handleCmdQueuePeriod)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Net_Connection_WebSocketConnection___ctor(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a605e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_LinkedList_SrvCommand__Clear__);
		    DAT_ram_00a605e8 = '\x01';
		  }
		  System_Collections_Generic_LinkedList_UIRenderDevice_DeviceToFree___AddLast
		            (*(undefined4 *)(param1 + 0x40),
		             Method_System_Collections_Generic_LinkedList_SrvCommand__Clear__);
		  return;
		}
		*/

		}

		// Token: 0x06005B76 RID: 23414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B76")]
		[Address(RVA = "0xA837", Offset = "0xA837", VA = "0xA837", Slot = "21")]
		public override void Rollback()
		{
		/* --- GHIDRA: Rollback ---
		undefined4
		Core_Net_Connection_WebSocketConnection__Rollback
		          (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a605e9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_SrvCommand__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_SrvCommand__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_SrvCommand__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_SrvCommand__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_LinkedList_SrvCommand__Remove__)
		    ;
		    DAT_ram_00a605e9 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  func_ii_16538(&local_18,*(undefined4 *)(param1 + 0x40),
		                Method_System_Collections_Generic_LinkedList_SrvCommand__GetEnumerator__);
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x355,&local_18,
		                       Method_System_Collections_Generic_LinkedList_Enumerator_SrvCommand__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cb49d7;
		    }
		    if (iVar2 == 0) goto code_r0x81cb4a77;
		  } while (*(int *)(local_10._4_4_ + 0xc) != *(int *)(param2 + 8));
		  *param3 = local_10._4_4_;
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::invoke_iiii
		                    (s_struct_VertexOutput____builtin_p_ram_00002c3d + 0xd8,
		                     *(undefined4 *)(param1 + 0x40),local_10._4_4_,
		                     Method_System_Collections_Generic_LinkedList_SrvCommand__Remove__);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    DAT_ram_009d3e38 = 0;
		    return uVar3;
		  }
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cb49d7:
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x81cb4a77:
		      DAT_ram_009d3e38 = 0;
		      *param3 = 0;
		      return 0;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x13,&local_20);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005B77 RID: 23415 RVA: 0x00010458 File Offset: 0x0000E658
		[Token(Token = "0x6005B77")]
		[Address(RVA = "0xA838", Offset = "0xA838", VA = "0xA838", Slot = "23")]
		protected override bool TryRemoveAwaitCommand(PacketParser.Packet packet, out SrvCommand cmd)
		{
			return default(bool);
		}

		// Token: 0x06005B78 RID: 23416 RVA: 0x00010470 File Offset: 0x0000E670
		[Token(Token = "0x6005B78")]
		[Address(RVA = "0xA839", Offset = "0xA839", VA = "0xA839", Slot = "25")]
		protected override bool Test()
		{
		/* --- GHIDRA: Test ---
		void Core_Net_Connection_WebSocketConnection__Test(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a605ea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_SrvCommand__AddLast__);
		    DAT_ram_00a605ea = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x3c);
		  param2_00 = System_Threading_Tasks_Task__Run(param2,*(undefined4 *)(param1 + 0x30),param1);
		  BestHTTP_WebSocket_WebSocket__Send(param1_00,param2_00,0);
		  System_Collections_Generic_LinkedList_object____ctor
		            (*(undefined4 *)(param1 + 0x40),param2,
		             Method_System_Collections_Generic_LinkedList_SrvCommand__AddLast__);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005B79 RID: 23417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B79")]
		[Address(RVA = "0xA83A", Offset = "0xA83A", VA = "0xA83A", Slot = "18")]
		public override void Push(SrvCommand command)
		{
		/* --- GHIDRA: Push ---
		void Core_Net_Connection_WebSocketConnection__Push(int param1,undefined4 param2)
		
		{
		  if (*(char *)(param1 + 0x34) == '\0') {
		    Core_Net_Connection_AbstractConnection__GetEventHandlers(param1,param1);
		    Core_Net_Connection_WebSocketConnection__Stop(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005B7A RID: 23418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B7A")]
		[Address(RVA = "0xA83B", Offset = "0xA83B", VA = "0xA83B", Slot = "19")]
		public override void Run()
		{
		/* --- GHIDRA: Run ---
		void Core_Net_Connection_WebSocketConnection__Run(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  
		  if (DAT_ram_00a605eb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo);
		    DAT_ram_00a605eb = '\x01';
		  }
		  if (*(char *)(param1 + 0x34) != '\0') {
		    param2_00 = unnamed_function_1417
		                          (Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo);
		    *(undefined4 *)(param2_00 + 8) = 3;
		    Core_Net_Connection_WebSocketConnection__InternalRun(param1,param2_00,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005B7B RID: 23419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B7B")]
		[Address(RVA = "0xA83C", Offset = "0xA83C", VA = "0xA83C", Slot = "20")]
		public override void Stop()
		{
		/* --- GHIDRA: Stop ---
		void Core_Net_Connection_WebSocketConnection__Stop(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a605ec == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_Connection_ConnectionState_TypeInfo);
		    DAT_ram_00a605ec = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Net_Connection_ConnectionState_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = 2;
		  Core_Net_Connection_AbstractConnection__get_CurrentState(param1,iVar1,param1);
		  iVar1 = Core_Net_Connection_WebSocketConnection__CmdCoroutine(param1,param1);
		  *(int *)(param1 + 0x3c) = iVar1;
		  if (iVar1 != 0) {
		    if (DAT_ram_00a605ee == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Core_Net_Connection_WebSocketConnection__CmdCoroutine_d__14_TypeInfo);
		      DAT_ram_00a605ee = '\x01';
		    }
		    iVar1 = unnamed_function_1417
		                      (Core_Net_Connection_WebSocketConnection__CmdCoroutine_d__14_TypeInfo);
		    *(int *)(iVar1 + 0x10) = param1;
		    *(undefined4 *)(iVar1 + 8) = 0;
		    uVar2 = Utils_CoroutineSource__GetMono(iVar1,0);
		    *(undefined4 *)(param1 + 0x44) = uVar2;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005B7C RID: 23420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B7C")]
		[Address(RVA = "0xA83D", Offset = "0xA83D", VA = "0xA83D")]
		private void InternalRun()
		{
		/* --- GHIDRA: InternalRun ---
		void Core_Net_Connection_WebSocketConnection__InternalRun
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a605ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_Connection_ConnectionState_TypeInfo);
		    DAT_ram_00a605ed = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Net_Connection_ConnectionState_TypeInfo);
		  *(undefined4 *)(iVar1 + 0xc) = param2;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  Core_Net_Connection_AbstractConnection__get_CurrentState(param1,iVar1,param1);
		  Core_Net_Connection_AbstractConnection__Run(param1,param1);
		  if (*(int *)(param1 + 0x44) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x44),0);
		  }
		  if (*(int *)(param1 + 0x3c) != 0) {
		    Core_Net_Connection_WebSocketConnection__ListenSocket(param1,*(int *)(param1 + 0x3c),param1);
		    iVar1 = BestHTTP_WebSocket_WebSocket__get_State(*(undefined4 *)(param1 + 0x3c),0);
		    if (iVar1 != 0) {
		      BestHTTP_WebSocket_WebSocket__Send(*(undefined4 *)(param1 + 0x3c),0);
		    }
		    *(undefined4 *)(param1 + 0x3c) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005B7D RID: 23421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B7D")]
		[Address(RVA = "0xA83E", Offset = "0xA83E", VA = "0xA83E")]
		private void InternalStop(ConnectionState.ConnectionStateReason reason)
		{
		/* --- GHIDRA: InternalStop ---
		int Core_Net_Connection_WebSocketConnection__InternalStop(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a605ee == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Net_Connection_WebSocketConnection__CmdCoroutine_d__14_TypeInfo);
		    DAT_ram_00a605ee = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Core_Net_Connection_WebSocketConnection__CmdCoroutine_d__14_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06005B7E RID: 23422 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B7E")]
		[Address(RVA = "0xA83F", Offset = "0xA83F", VA = "0xA83F")]
		private IEnumerator CmdCoroutine()
		{
		/* --- GHIDRA: CmdCoroutine ---
		undefined4 Core_Net_Connection_WebSocketConnection__CmdCoroutine(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  undefined4 *param2_00;
		  undefined4 param3;
		  int *piVar5;
		  
		  if (DAT_ram_00a605ef == '\0') {
		    Mono_Security_ASN1__get_Item(&BestHTTP_WebSocket_WebSocket_TypeInfo);
		    DAT_ram_00a605ef = '\x01';
		  }
		  param3 = *(undefined4 *)(param1 + 0x10);
		  DAT_ram_009d3e38 = 0;
		  uVar1 = import::env::invoke_ii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                     BestHTTP_WebSocket_WebSocket_TypeInfo);
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x14,uVar1,param3,0);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		      Core_Net_Connection_WebSocketConnection__Connect(param1,uVar1,param1);
		      BestHTTP_WebSocket_WebSocket___ctor(uVar1,0);
		      return uVar1;
		    }
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar4 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar2) {
		    puVar3 = (undefined4 *)import::env::__cxa_begin_catch(uVar1);
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar1,
		                         *(undefined4 *)*puVar3);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 != 1) {
		        if (iVar2 != 0) {
		          piVar5 = (int *)*puVar3;
		          import::env::__cxa_end_catch();
		          uVar1 = unnamed_function_2232
		                            (&Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo);
		          iVar4 = unnamed_function_1417(uVar1);
		          *(undefined4 *)(iVar4 + 8) = 1;
		          iVar2 = *piVar5;
		          uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		                            (piVar5,*(undefined4 *)(iVar2 + 0xec));
		          *(undefined4 *)(iVar4 + 0xc) = uVar1;
		          Core_Net_Connection_WebSocketConnection__InternalRun(param1,iVar4,param1);
		          return 0;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar3;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81cb4daf;
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
		code_r0x81cb4daf:
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

			return null;
		}

		// Token: 0x06005B7F RID: 23423 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B7F")]
		[Address(RVA = "0xA840", Offset = "0xA840", VA = "0xA840")]
		private WebSocket Connect()
		{
		/* --- GHIDRA: Connect ---
		void Core_Net_Connection_WebSocketConnection__Connect
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a605f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&BestHTTP_WebSocket_OnWebSocketBinaryDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item(&BestHTTP_WebSocket_OnWebSocketClosedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item(&BestHTTP_WebSocket_OnWebSocketErrorDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item(&BestHTTP_WebSocket_OnWebSocketOpenDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_Connection_WebSocketConnection_OnBinary__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_Connection_WebSocketConnection_OnClosed__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_Connection_WebSocketConnection_OnError__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_Connection_WebSocketConnection_OnOpen__);
		    DAT_ram_00a605f0 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 8);
		  uVar2 = unnamed_function_1417(BestHTTP_WebSocket_OnWebSocketOpenDelegate_TypeInfo);
		  BestHTTP_SOCKSProxy__WriteBytes
		            (uVar2,param1,Method_Core_Net_Connection_WebSocketConnection_OnOpen__,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar2,0);
		  iVar1 = BestHTTP_WebSocket_OnWebSocketOpenDelegate_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 8) = 0;
		  }
		  else if ((BestHTTP_WebSocket_OnWebSocketOpenDelegate_TypeInfo != *piVar3) ||
		          (*(int **)(param2 + 8) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x14);
		  uVar2 = unnamed_function_1417(BestHTTP_WebSocket_OnWebSocketClosedDelegate_TypeInfo);
		  BestHTTP_WebSocket_OnWebSocketBinaryDelegate__EndInvoke
		            (uVar2,param1,Method_Core_Net_Connection_WebSocketConnection_OnClosed__,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar2,0);
		  iVar1 = BestHTTP_WebSocket_OnWebSocketClosedDelegate_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x14) = 0;
		  }
		  else if ((BestHTTP_WebSocket_OnWebSocketClosedDelegate_TypeInfo != *piVar3) ||
		          (*(int **)(param2 + 0x14) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x18);
		  uVar2 = unnamed_function_1417(BestHTTP_WebSocket_OnWebSocketErrorDelegate_TypeInfo);
		  BestHTTP_WebSocket_OnWebSocketClosedDelegate__EndInvoke
		            (uVar2,param1,Method_Core_Net_Connection_WebSocketConnection_OnError__,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar2,0);
		  iVar1 = BestHTTP_WebSocket_OnWebSocketErrorDelegate_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x18) = 0;
		  }
		  else if ((BestHTTP_WebSocket_OnWebSocketErrorDelegate_TypeInfo != *piVar3) ||
		          (*(int **)(param2 + 0x18) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x10);
		  uVar2 = unnamed_function_1417(BestHTTP_WebSocket_OnWebSocketBinaryDelegate_TypeInfo);
		  BestHTTP_WebSocket_OnWebSocketMessageDelegate__EndInvoke
		            (uVar2,param1,Method_Core_Net_Connection_WebSocketConnection_OnBinary__,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar2,0);
		  iVar1 = BestHTTP_WebSocket_OnWebSocketBinaryDelegate_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x10) = 0;
		    return;
		  }
		  if ((BestHTTP_WebSocket_OnWebSocketBinaryDelegate_TypeInfo == *piVar3) &&
		     (*(int **)(param2 + 0x10) = piVar3, *piVar3 == iVar1)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,iVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06005B80 RID: 23424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B80")]
		[Address(RVA = "0xA841", Offset = "0xA841", VA = "0xA841")]
		private void ListenSocket(WebSocket socket)
		{
		/* --- GHIDRA: ListenSocket ---
		void Core_Net_Connection_WebSocketConnection__ListenSocket
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a605f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&BestHTTP_WebSocket_OnWebSocketBinaryDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item(&BestHTTP_WebSocket_OnWebSocketClosedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item(&BestHTTP_WebSocket_OnWebSocketErrorDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item(&BestHTTP_WebSocket_OnWebSocketOpenDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_Connection_WebSocketConnection_OnBinary__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_Connection_WebSocketConnection_OnClosed__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_Connection_WebSocketConnection_OnError__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_Connection_WebSocketConnection_OnOpen__);
		    DAT_ram_00a605f1 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 8);
		  uVar2 = unnamed_function_1417(BestHTTP_WebSocket_OnWebSocketOpenDelegate_TypeInfo);
		  BestHTTP_SOCKSProxy__WriteBytes
		            (uVar2,param1,Method_Core_Net_Connection_WebSocketConnection_OnOpen__,0);
		  piVar3 = (int *)func_ii_7048(uVar4,uVar2,0);
		  iVar1 = BestHTTP_WebSocket_OnWebSocketOpenDelegate_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 8) = 0;
		  }
		  else if ((BestHTTP_WebSocket_OnWebSocketOpenDelegate_TypeInfo != *piVar3) ||
		          (*(int **)(param2 + 8) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x14);
		  uVar2 = unnamed_function_1417(BestHTTP_WebSocket_OnWebSocketClosedDelegate_TypeInfo);
		  BestHTTP_WebSocket_OnWebSocketBinaryDelegate__EndInvoke
		            (uVar2,param1,Method_Core_Net_Connection_WebSocketConnection_OnClosed__,0);
		  piVar3 = (int *)func_ii_7048(uVar4,uVar2,0);
		  iVar1 = BestHTTP_WebSocket_OnWebSocketClosedDelegate_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x14) = 0;
		  }
		  else if ((BestHTTP_WebSocket_OnWebSocketClosedDelegate_TypeInfo != *piVar3) ||
		          (*(int **)(param2 + 0x14) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x18);
		  uVar2 = unnamed_function_1417(BestHTTP_WebSocket_OnWebSocketErrorDelegate_TypeInfo);
		  BestHTTP_WebSocket_OnWebSocketClosedDelegate__EndInvoke
		            (uVar2,param1,Method_Core_Net_Connection_WebSocketConnection_OnError__,0);
		  piVar3 = (int *)func_ii_7048(uVar4,uVar2,0);
		  iVar1 = BestHTTP_WebSocket_OnWebSocketErrorDelegate_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x18) = 0;
		  }
		  else if ((BestHTTP_WebSocket_OnWebSocketErrorDelegate_TypeInfo != *piVar3) ||
		          (*(int **)(param2 + 0x18) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x10);
		  uVar2 = unnamed_function_1417(BestHTTP_WebSocket_OnWebSocketBinaryDelegate_TypeInfo);
		  BestHTTP_WebSocket_OnWebSocketMessageDelegate__EndInvoke
		            (uVar2,param1,Method_Core_Net_Connection_WebSocketConnection_OnBinary__,0);
		  piVar3 = (int *)func_ii_7048(uVar4,uVar2,0);
		  iVar1 = BestHTTP_WebSocket_OnWebSocketBinaryDelegate_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x10) = 0;
		    return;
		  }
		  if ((BestHTTP_WebSocket_OnWebSocketBinaryDelegate_TypeInfo == *piVar3) &&
		     (*(int **)(param2 + 0x10) = piVar3, *piVar3 == iVar1)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,iVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005B81 RID: 23425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B81")]
		[Address(RVA = "0xA842", Offset = "0xA842", VA = "0xA842")]
		private void RemoveListenSocket(WebSocket socket)
		{
		/* --- GHIDRA: RemoveListenSocket ---
		void Core_Net_Connection_WebSocketConnection__RemoveListenSocket
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a605cb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_IPacketParser_TypeInfo);
		    DAT_ram_00a605cb = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x30);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Net_IPacketParser_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd8);
		        goto code_r0x81cb537c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Net_IPacketParser_TypeInfo,3);
		code_r0x81cb537c:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param3,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06005B82 RID: 23426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B82")]
		[Address(RVA = "0xA843", Offset = "0xA843", VA = "0xA843")]
		private void OnBinary(WebSocket websocket, byte[] data)
		{
		/* --- GHIDRA: OnBinary ---
		void Core_Net_Connection_WebSocketConnection__OnBinary
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  
		  if (DAT_ram_00a605f2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo);
		    DAT_ram_00a605f2 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo);
		  *(undefined4 *)(param2_00 + 0xc) = param3;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  Core_Net_Connection_WebSocketConnection__InternalRun(param1,param2_00,param2_00);
		  return;
		}
		*/

		}

		// Token: 0x06005B83 RID: 23427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B83")]
		[Address(RVA = "0xA844", Offset = "0xA844", VA = "0xA844")]
		private void OnError(WebSocket websocket, string reason)
		{
		/* --- GHIDRA: OnError ---
		void Core_Net_Connection_WebSocketConnection__OnError
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  int param2_00;
		  
		  if (DAT_ram_00a605f3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo);
		    DAT_ram_00a605f3 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo);
		  *(undefined4 *)(param2_00 + 0x10) = param3;
		  *(undefined4 *)(param2_00 + 0xc) = param4;
		  *(undefined4 *)(param2_00 + 8) = 1;
		  Core_Net_Connection_WebSocketConnection__InternalRun(param1,param2_00,param2_00);
		  return;
		}
		*/

		}

		// Token: 0x06005B84 RID: 23428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B84")]
		[Address(RVA = "0xA845", Offset = "0xA845", VA = "0xA845")]
		private void OnClosed(WebSocket websocket, ushort code, string message)
		{
		/* --- GHIDRA: OnClosed ---
		void Core_Net_Connection_WebSocketConnection__OnClosed
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  
		  if (DAT_ram_00a605f4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_Connection_ConnectionState_TypeInfo);
		    DAT_ram_00a605f4 = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x168) * 4))(param1,*(undefined4 *)(*param1 + 0x16c));
		  param2_00 = unnamed_function_1417(Core_Net_Connection_ConnectionState_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = 1;
		  Core_Net_Connection_AbstractConnection__get_CurrentState(param1,param2_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06005B85 RID: 23429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B85")]
		[Address(RVA = "0xA846", Offset = "0xA846", VA = "0xA846")]
		private void OnOpen(WebSocket websocket)
		{
		}

		// Token: 0x040031F3 RID: 12787
		[Token(Token = "0x40031F3")]
		[FieldOffset(Offset = "0x3C")]
		private WebSocket _currentSocket;

		// Token: 0x040031F4 RID: 12788
		[Token(Token = "0x40031F4")]
		[FieldOffset(Offset = "0x40")]
		private readonly LinkedList<SrvCommand> _commandsAwaitAnswer;

		// Token: 0x040031F5 RID: 12789
		[Token(Token = "0x40031F5")]
		[FieldOffset(Offset = "0x44")]
		private Coroutine _cmdCoroutine;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CommandsAwaitAnswer ---
		void Core_Net_Connection_WebSocketConnection__get_CommandsAwaitAnswer
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a605e7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_LinkedList_SrvCommand___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_LinkedList_SrvCommand__TypeInfo);
		    DAT_ram_00a605e7 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_LinkedList_SrvCommand__TypeInfo);
		  *(undefined4 *)(param1 + 0x40) = uVar1;
		  Core_Net_Connection_AbstractConnection__set_IsRun(param1,param2,param3,param1);
		  return;
		}
		*/

}
