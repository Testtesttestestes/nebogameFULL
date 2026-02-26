using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;

namespace Gameplay.Combat.Control
{
	// Token: 0x020009BA RID: 2490
	[Token(Token = "0x20009BA")]
	public class Conveyor : IDisposable
	{
		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06003BA7 RID: 15271 RVA: 0x0000C030 File Offset: 0x0000A230
		// (set) Token: 0x06003BA8 RID: 15272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BC6")]
		public bool IsPause
		{
			[Token(Token = "0x6003BA7")]
			[Address(RVA = "0x8A80", Offset = "0x8A80", VA = "0x8A80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003BA8")]
			[Address(RVA = "0x8A81", Offset = "0x8A81", VA = "0x8A81")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06003BA9 RID: 15273 RVA: 0x0000C048 File Offset: 0x0000A248
		[Token(Token = "0x17000BC7")]
		public LinkedList<IConveyorItem>.Enumerator GetQueueEnumerator
		{
			[Token(Token = "0x6003BA9")]
			[Address(RVA = "0x8A82", Offset = "0x8A82", VA = "0x8A82")]
			get
			{
				return default(LinkedList<IConveyorItem>.Enumerator);
			}
		}

		// Token: 0x06003BAA RID: 15274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BAA")]
		[Address(RVA = "0x8A83", Offset = "0x8A83", VA = "0x8A83", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Combat_Control_Conveyor__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57e5c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_IConveyorItem___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_LinkedList_IConveyorItem__TypeInfo);
		    DAT_ram_00a57e5c = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_LinkedList_IConveyorItem__TypeInfo);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  *(undefined4 *)(param1 + 0x10) = param3;
		  *(undefined4 *)(param1 + 0xc) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06003BAB RID: 15275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BAB")]
		[Address(RVA = "0x8A84", Offset = "0x8A84", VA = "0x8A84")]
		public Conveyor(Action<IConveyorItem> executeCallback, Action completeQueueCallback)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_Control_Conveyor___ctor(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined8 local_3c;
		  undefined8 local_34;
		  undefined4 local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57e5e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_Conveyor__Execute_d__14___
		              );
		    DAT_ram_00a57e5e = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_3c,0);
		  local_20 = local_34;
		  local_2c = 0xffffffff;
		  local_28 = local_3c;
		  local_18 = param2;
		  local_14 = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_ConfigurationManager__Init_d__17_
		            (&local_28,&local_2c,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_Conveyor__Execute_d__14___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BAC")]
		[Address(RVA = "0x1C3C", Offset = "0x1C3C", VA = "0x1C3C")]
		private void Next()
		{
		/* --- GHIDRA: Next ---
		void Gameplay_Combat_Control_Conveyor__Next(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x14) = 0xffffffff;
		  *(undefined4 *)(param1 + 0x10) = 1;
		  return;
		}
		*/

		}

		// Token: 0x06003BAD RID: 15277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BAD")]
		[Address(RVA = "0x8A85", Offset = "0x8A85", VA = "0x8A85")]
		private void Execute(IConveyorItem item)
		{
		/* --- GHIDRA: Execute ---
		void Gameplay_Combat_Control_Conveyor__Execute(int param1,undefined4 param2)
		
		{
		  *(undefined2 *)(param1 + 8) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06003BAE RID: 15278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BAE")]
		[Address(RVA = "0x8A86", Offset = "0x8A86", VA = "0x8A86")]
		private void StopInternal()
		{
		/* --- GHIDRA: StopInternal ---
		void Gameplay_Combat_Control_Conveyor__StopInternal(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57e5f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_IConveyorItem__Clear__);
		    DAT_ram_00a57e5f = '\x01';
		  }
		  System_Collections_Generic_LinkedList_UIRenderDevice_DeviceToFree___AddLast
		            (*(undefined4 *)(param1 + 0x18),
		             Method_System_Collections_Generic_LinkedList_IConveyorItem__Clear__);
		  return;
		}
		*/

		}

		// Token: 0x06003BAF RID: 15279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BAF")]
		[Address(RVA = "0x8A87", Offset = "0x8A87", VA = "0x8A87")]
		public void Reset()
		{
		/* --- GHIDRA: Reset ---
		int Gameplay_Combat_Control_Conveyor__Reset(int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57e60 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_IConveyorItem__AddLast__);
		    DAT_ram_00a57e60 = '\x01';
		  }
		  System_Collections_Generic_LinkedList_object____ctor
		            (*(undefined4 *)(param1 + 0x18),param2,
		             Method_System_Collections_Generic_LinkedList_IConveyorItem__AddLast__);
		  return param1;
		}
		*/

		}

		// Token: 0x06003BB0 RID: 15280 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003BB0")]
		[Address(RVA = "0x8A88", Offset = "0x8A88", VA = "0x8A88")]
		public Conveyor Append(IConveyorItem item)
		{
		/* --- GHIDRA: Append ---
		void Gameplay_Combat_Control_Conveyor__Append(int param1,undefined4 param2)
		
		{
		  if (*(char *)(param1 + 8) == '\0') {
		    *(undefined2 *)(param1 + 8) = 1;
		    func_ii_7227(param1,param1);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003BB1 RID: 15281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB1")]
		[Address(RVA = "0x8A89", Offset = "0x8A89", VA = "0x8A89")]
		public void Play()
		{
		/* --- GHIDRA: Play ---
		void Gameplay_Combat_Control_Conveyor__Play(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x1c) != 0) {
		    System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		              (*(int *)(param1 + 0x1c),0);
		    System_Threading_CancellationTokenSource__Cancel(*(undefined4 *)(param1 + 0x1c),0);
		  }
		  *(undefined2 *)(param1 + 8) = 0;
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB2")]
		[Address(RVA = "0x8A8A", Offset = "0x8A8A", VA = "0x8A8A")]
		public void Stop()
		{
		/* --- GHIDRA: Stop ---
		void Gameplay_Combat_Control_Conveyor__Stop(int param1,undefined4 param2)
		
		{
		  *(undefined2 *)(param1 + 8) = 0x100;
		  return;
		}
		*/

		}

		// Token: 0x06003BB3 RID: 15283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB3")]
		[Address(RVA = "0x8A8B", Offset = "0x8A8B", VA = "0x8A8B")]
		public void Pause()
		{
		}

		// Token: 0x040020CC RID: 8396
		[Token(Token = "0x40020CC")]
		[FieldOffset(Offset = "0x8")]
		private bool _isPlay;

		// Token: 0x040020CE RID: 8398
		[Token(Token = "0x40020CE")]
		[FieldOffset(Offset = "0xC")]
		private Action<IConveyorItem> _executeCallback;

		// Token: 0x040020CF RID: 8399
		[Token(Token = "0x40020CF")]
		[FieldOffset(Offset = "0x10")]
		private Action _completeQueueCallback;

		// Token: 0x040020D0 RID: 8400
		[Token(Token = "0x40020D0")]
		[FieldOffset(Offset = "0x14")]
		private bool _isDisposed;

		// Token: 0x040020D1 RID: 8401
		[Token(Token = "0x40020D1")]
		[FieldOffset(Offset = "0x18")]
		private readonly LinkedList<IConveyorItem> _queue;

		// Token: 0x040020D2 RID: 8402
		[Token(Token = "0x40020D2")]
		[FieldOffset(Offset = "0x1C")]
		private CancellationTokenSource _awaitableCancellationTs;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_IsPause ---
		void Gameplay_Combat_Control_Conveyor__set_IsPause(undefined8 *param1,int param2,undefined4 param3)
		
		{
		  undefined8 local_14;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57e5b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_IConveyorItem__GetEnumerator__);
		    DAT_ram_00a57e5b = '\x01';
		  }
		  func_ii_16538(&local_14,*(undefined4 *)(param2 + 0x18),
		                Method_System_Collections_Generic_LinkedList_IConveyorItem__GetEnumerator__);
		  *(undefined4 *)(param1 + 2) = local_4;
		  param1[1] = local_c;
		  *param1 = local_14;
		  return;
		}
		*/


		/* --- GHIDRA: get_GetQueueEnumerator ---
		void Gameplay_Combat_Control_Conveyor__get_GetQueueEnumerator(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x1c) != 0) {
		    System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		              (*(int *)(param1 + 0x1c),0);
		    System_Threading_CancellationTokenSource__Cancel(*(undefined4 *)(param1 + 0x1c),0);
		  }
		  *(undefined2 *)(param1 + 8) = 0;
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  if (DAT_ram_00a57e5f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_IConveyorItem__Clear__);
		    DAT_ram_00a57e5f = '\x01';
		  }
		  System_Collections_Generic_LinkedList_UIRenderDevice_DeviceToFree___AddLast
		            (*(undefined4 *)(param1 + 0x18),
		             Method_System_Collections_Generic_LinkedList_IConveyorItem__Clear__);
		  *(undefined1 *)(param1 + 0x14) = 1;
		  *(undefined8 *)(param1 + 0xc) = 0;
		  return;
		}
		*/

}
