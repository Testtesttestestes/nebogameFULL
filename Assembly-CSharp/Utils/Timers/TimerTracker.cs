using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Utils.Timers
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	public class TimerTracker : IDisposable
	{
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600031C RID: 796 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600031D RID: 797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000E")]
		public event Action TimerExpiredEvent
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x578F", Offset = "0x578F", VA = "0x578F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x5790", Offset = "0x5790", VA = "0x5790")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x5791", Offset = "0x5791", VA = "0x5791")]
		public TimerTracker()
		{
		/* --- GHIDRA: .ctor ---
		uint Utils_Timers_TimerTracker___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a62840 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__TimerTracker_TimerWrapper__get_Count__
		              );
		    DAT_ram_00a62840 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                    (*(undefined4 *)(param1 + 0xc),
		                     Method_System_Collections_Generic_Dictionary_uint__TimerTracker_TimerWrapper__get_Count__
		                    );
		  if (iVar1 != 0) {
		    Utils_Timers_TimerTracker__TryRun(param1,param1);
		  }
		  return (uint)(iVar1 != 0);
		}
		*/

		}

		// Token: 0x0600031F RID: 799 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1E0B", Offset = "0x1E0B", VA = "0x1E0B")]
		public bool TryGetValue(uint id, out BackTime value)
		{
		/* --- GHIDRA: TryGetValue ---
		void Utils_Timers_TimerTracker__TryGetValue(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  int *piVar2;
		  
		  *(undefined1 *)(param1 + 0x1c) = (undefined1)param2;
		  param1_00 = (int *)0x0;
		  if (DAT_ram_00a63bb7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Animations_SpineUiButtonAnimation_TypeInfo);
		    DAT_ram_00a63bb7 = '\x01';
		  }
		  piVar2 = *(int **)(*(int *)(param1 + 0x10) + 0x3c);
		  if (piVar2 != (int *)0x0) {
		    if (((uint)*(byte *)(Animations_SpineUiButtonAnimation_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*piVar2 + 0xb8)) &&
		       (param1_00 = piVar2,
		       *(int *)(*(int *)(*piVar2 + 100) +
		                (uint)*(byte *)(Animations_SpineUiButtonAnimation_TypeInfo + 0xb8) * 4 + -4) !=
		       Animations_SpineUiButtonAnimation_TypeInfo)) {
		      param1_00 = (int *)0x0;
		    }
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1_00,0);
		  if (iVar1 != 0) {
		    Animations_SpineUiButtonAnimation__get_Enabled(param1_00,(uint)*(byte *)(param1 + 0x1c),0);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1CA6", Offset = "0x1CA6", VA = "0x1CA6")]
		public void UpdateOrCreate(uint id, BackTime value)
		{
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x5792", Offset = "0x5792", VA = "0x5792")]
		public bool TryRun()
		{
		/* --- GHIDRA: TryRun ---
		void Utils_Timers_TimerTracker__TryRun(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 *puVar1;
		  int iVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a62841 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Aggregate_TimerTracker_TimerWrapper___);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_TimerTracker_TimerWrapper__TimerTracker_TimerWrapper__TimerTracker_TimerWrapper__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_Timers_TimerTracker___c__StartTracking_b__11_0__);
		    Mono_Security_ASN1__get_Item(&Utils_Timers_TimerTracker___c_TypeInfo);
		    DAT_ram_00a62841 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(Utils_Timers_TimerTracker___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_Timers_TimerTracker___c_TypeInfo);
		  }
		  puVar1 = *(undefined4 **)(Utils_Timers_TimerTracker___c_TypeInfo + 0x5c);
		  iVar2 = puVar1[1];
		  if (iVar2 == 0) {
		    if (*(int *)(Utils_Timers_TimerTracker___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_Timers_TimerTracker___c_TypeInfo);
		      puVar1 = *(undefined4 **)(Utils_Timers_TimerTracker___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar1;
		    iVar2 = unnamed_function_1417
		                      (
		                      System_Func_TimerTracker_TimerWrapper__TimerTracker_TimerWrapper__TimerTracker_TimerWrapper__TypeInfo
		                      );
		    System_Threading_Tasks_Task_object___get_Factory
		              (iVar2,param2_00,Method_Utils_Timers_TimerTracker___c__StartTracking_b__11_0__,0);
		    *(int *)(*(int *)(Utils_Timers_TimerTracker___c_TypeInfo + 0x5c) + 4) = iVar2;
		  }
		  iVar2 = UnityEngine_UIElements_EnumField__ProcessPointerDown_object_
		                    (param1_00,iVar2,
		                     Method_System_Linq_Enumerable_Aggregate_TimerTracker_TimerWrapper___);
		  Utils_Timers_DelayedCall__SetDelay
		            (*(undefined4 *)(param1 + 0x14),*(undefined4 *)(iVar2 + 0xc),iVar2);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x5793", Offset = "0x5793", VA = "0x5793")]
		private void StartTracking()
		{
		/* --- GHIDRA: StartTracking ---
		void Utils_Timers_TimerTracker__StartTracking(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  float fVar2;
		  int iVar3;
		  int iVar4;
		  int param2_00;
		  
		  if (DAT_ram_00a62842 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__TimerTracker_TimerWrapper__Remove__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__TimerTracker_TimerWrapper__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TimerTracker_TimerWrapper__RemoveAt__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TimerTracker_TimerWrapper__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TimerTracker_TimerWrapper__get_Item__);
		    DAT_ram_00a62842 = '\x01';
		  }
		  iVar4 = *(int *)(*(int *)(param1 + 0x10) + 0xc);
		  param2_00 = iVar4 + -1;
		  if (-1 < param2_00) {
		    do {
		      iVar3 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(param1 + 0x10),param2_00,
		                         Method_System_Collections_Generic_List_TimerTracker_TimerWrapper__get_Item__
		                        );
		      fVar2 = func_ii_7103(*(undefined4 *)(iVar3 + 0xc),0);
		      if (fVar2 <= 0.0) {
		        UnityEngine_TextCore_Glyph__set_atlasIndex
		                  (*(undefined4 *)(param1 + 0x10),param2_00,
		                   Method_System_Collections_Generic_List_TimerTracker_TimerWrapper__RemoveAt__);
		        System_Collections_Generic_List_Enumerator_uint___MoveNext
		                  (*(undefined4 *)(param1 + 0xc),*(undefined4 *)(iVar3 + 8),
		                   Method_System_Collections_Generic_Dictionary_uint__TimerTracker_TimerWrapper__Remove__
		                  );
		      }
		      bVar1 = 0 < param2_00;
		      param2_00 = param2_00 + -1;
		    } while (bVar1);
		  }
		  iVar3 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                    (*(undefined4 *)(param1 + 0xc),
		                     Method_System_Collections_Generic_Dictionary_uint__TimerTracker_TimerWrapper__get_Count__
		                    );
		  if ((iVar3 < iVar4) && (param2_00 = *(int *)(param1 + 8), param2_00 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(param2_00 + 0xc) * 4))
		              (*(undefined4 *)(param2_00 + 0x20),*(undefined4 *)(param2_00 + 0x14));
		  }
		  if (DAT_ram_00a62840 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__TimerTracker_TimerWrapper__get_Count__
		              );
		    DAT_ram_00a62840 = '\x01';
		  }
		  iVar4 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                    (*(undefined4 *)(param1 + 0xc),
		                     Method_System_Collections_Generic_Dictionary_uint__TimerTracker_TimerWrapper__get_Count__
		                    );
		  if (iVar4 != 0) {
		    Utils_Timers_TimerTracker__TryRun(param1,param2_00);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000323 RID: 803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x5794", Offset = "0x5794", VA = "0x5794")]
		private void ClearExpiredTimers()
		{
		/* --- GHIDRA: ClearExpiredTimers ---
		void Utils_Timers_TimerTracker__ClearExpiredTimers(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a62843 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__TimerTracker_TimerWrapper__Clear__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TimerTracker_TimerWrapper__Clear__);
		    DAT_ram_00a62843 = '\x01';
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0xc),
		             Method_System_Collections_Generic_Dictionary_uint__TimerTracker_TimerWrapper__Clear__);
		  iVar1 = *(int *)(param1 + 0x10);
		  iVar2 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < iVar2) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,iVar2,0);
		  }
		  iVar1 = *(int *)(param1 + 0x14);
		  *(undefined4 *)(iVar1 + 8) = 0;
		  if ((*(int *)(iVar1 + 0x10) != 0) &&
		     (iVar2 = System_Collections_Generic_LinkedList_object___AddFirst(*(int *)(iVar1 + 0x10),0),
		     iVar2 == 0)) {
		    System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		              (*(undefined4 *)(iVar1 + 0x10),0);
		    System_Threading_CancellationTokenSource__Cancel(*(undefined4 *)(iVar1 + 0x10),0);
		  }
		  *(undefined4 *)(param1 + 8) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x5795", Offset = "0x5795", VA = "0x5795", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0xC")]
		private readonly Dictionary<uint, TimerTracker.TimerWrapper> _timers;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<TimerTracker.TimerWrapper> _timersList;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x14")]
		private DelayedCall _delayedCall;

		// Token: 0x02000061 RID: 97
		[Token(Token = "0x2000061")]
		private class TimerWrapper
		{
			// Token: 0x06000325 RID: 805 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x5796", Offset = "0x5796", VA = "0x5796")]
			public TimerWrapper(uint id, BackTime backtime)
			{
			}

			// Token: 0x04000167 RID: 359
			[Token(Token = "0x4000167")]
			[FieldOffset(Offset = "0x8")]
			public readonly uint Id;

			// Token: 0x04000168 RID: 360
			[Token(Token = "0x4000168")]
			[FieldOffset(Offset = "0xC")]
			public BackTime Backtime;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_TimerExpiredEvent ---
		void Utils_Timers_TimerTracker__add_TimerExpiredEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a6283c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a6283c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 8,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_TimerExpiredEvent ---
		void Utils_Timers_TimerTracker__remove_TimerExpiredEvent(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a6283d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_Timers_DelayedCall_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__TimerTracker_TimerWrapper___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__TimerTracker_TimerWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TimerTracker_TimerWrapper___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_TimerTracker_TimerWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Timers_TimerTracker_ClearExpiredTimers__);
		    DAT_ram_00a6283d = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_uint__TimerTracker_TimerWrapper__TypeInfo
		                    );
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_uint__TimerTracker_TimerWrapper___ctor__);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_TimerTracker_TimerWrapper__TypeInfo)
		  ;
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_TimerTracker_TimerWrapper___ctor__);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Utils_Timers_TimerTracker_ClearExpiredTimers__,0);
		  iVar2 = unnamed_function_1417(Utils_Timers_DelayedCall_TypeInfo);
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  *(int *)(param1 + 0x14) = iVar2;
		  return;
		}
		*/

}
