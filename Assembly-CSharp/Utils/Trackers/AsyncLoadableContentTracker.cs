using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Utils.Trackers
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	[Serializable]
	public class AsyncLoadableContentTracker : IAsyncLoadableContent, IDisposable
	{
		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000304 RID: 772 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000305 RID: 773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000C")]
		public event Action<IAsyncLoadableContent> ReadyEvent
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x5777", Offset = "0x5777", VA = "0x5777", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x5778", Offset = "0x5778", VA = "0x5778", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000076 RID: 118
		// (set) Token: 0x06000306 RID: 774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000076")]
		private IAsyncLoadableContent[] Loaders
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x5779", Offset = "0x5779", VA = "0x5779")]
			set
			{
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x17000077")]
		public bool IsReady
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x577A", Offset = "0x577A", VA = "0x577A", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x577B", Offset = "0x577B", VA = "0x577B")]
		public void Init(IEnumerable<IAsyncLoadableContent> loaders)
		{
		/* --- GHIDRA: Init ---
		void Utils_Trackers_AsyncLoadableContentTracker__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  *(undefined2 *)(param1 + 0x10) = 0x100;
		  iVar1 = Utils_Trackers_AsyncLoadableContentTracker__set_Loaders(param1,param1);
		  if ((iVar1 != 0) && (iVar1 = *(int *)(param1 + 0xc), iVar1 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x577C", Offset = "0x577C", VA = "0x577C")]
		public void StartTracking()
		{
		/* --- GHIDRA: StartTracking ---
		void Utils_Trackers_AsyncLoadableContentTracker__StartTracking(int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(param1 + 0x11) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600030A RID: 778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x577D", Offset = "0x577D", VA = "0x577D")]
		public void StopTracking()
		{
		/* --- GHIDRA: StopTracking ---
		void Utils_Trackers_AsyncLoadableContentTracker__StopTracking
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if ((((*(char *)(param1 + 0x11) != '\0') && (*(char *)(param1 + 0x10) == '\0')) &&
		      (iVar1 = Utils_Trackers_AsyncLoadableContentTracker__set_Loaders(param1,param1), iVar1 != 0))
		     && (iVar1 = *(int *)(param1 + 0xc), iVar1 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x577E", Offset = "0x577E", VA = "0x577E")]
		private void LoaderReadyEventHandler(IAsyncLoadableContent loader)
		{
		/* --- GHIDRA: LoaderReadyEventHandler ---
		void Utils_Trackers_AsyncLoadableContentTracker__LoaderReadyEventHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = Utils_Trackers_AsyncLoadableContentTracker__set_Loaders(param1,param1);
		  if ((iVar1 != 0) && (iVar1 = *(int *)(param1 + 0xc), iVar1 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x577F", Offset = "0x577F", VA = "0x577F")]
		private void NotifyIfReady()
		{
		/* --- GHIDRA: NotifyIfReady ---
		void Utils_Trackers_AsyncLoadableContentTracker__NotifyIfReady(int param1,undefined4 param2)
		
		{
		  Utils_Trackers_AsyncLoadableContentTracker__remove_ReadyEvent(param1,0,param1);
		  *(undefined4 *)(param1 + 0xc) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600030D RID: 781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x5780", Offset = "0x5780", VA = "0x5780", Slot = "7")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Utils_Trackers_AsyncLoadableContentTracker__Dispose(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 8) = 0x3f000000;
		  return;
		}
		*/

		}

		// Token: 0x0600030E RID: 782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x5781", Offset = "0x5781", VA = "0x5781")]
		public AsyncLoadableContentTracker()
		{
		/* --- GHIDRA: .ctor ---
		void Utils_Trackers_AsyncLoadableContentTracker___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a62833 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_Trackers_AsyncLoadableContentTracker___c_TypeInfo);
		    DAT_ram_00a62833 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Utils_Trackers_AsyncLoadableContentTracker___c_TypeInfo);
		  **(undefined4 **)(Utils_Trackers_AsyncLoadableContentTracker___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x8")]
		[Tooltip("Уведомляет, когда доля загруженных ассетов больше данного порога")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _threshold;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x10")]
		private bool _isReady;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x11")]
		private bool _isTracking;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x14")]
		private IAsyncLoadableContent[] _loaders;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ReadyEvent ---
		void Utils_Trackers_AsyncLoadableContentTracker__add_ReadyEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6282f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    DAT_ram_00a6282f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IAsyncLoadableContent__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAsyncLoadableContent__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: remove_ReadyEvent ---
		void Utils_Trackers_AsyncLoadableContentTracker__remove_ReadyEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  int *piVar8;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a62830 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Trackers_AsyncLoadableContentTracker_LoaderReadyEventHandler__);
		    Mono_Security_ASN1__get_Item(&Core_IAsyncLoadableContent_TypeInfo);
		    DAT_ram_00a62830 = '\x01';
		  }
		  iVar5 = *(int *)(param1 + 0x14);
		  if ((iVar5 != 0) && (0 < *(int *)(iVar5 + 0xc))) {
		    do {
		      piVar6 = *(int **)(iVar5 + iVar2 * 4 + 0x10);
		      uVar3 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar3,param1,
		                 Method_Utils_Trackers_AsyncLoadableContentTracker_LoaderReadyEventHandler__,0);
		      iVar7 = *piVar6;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		          if (Core_IAsyncLoadableContent_TypeInfo == *piVar8) {
		            puVar4 = (uint *)(piVar8[1] * 8 + iVar7 + 0xd0);
		            goto code_r0x820f717c;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar6,Core_IAsyncLoadableContent_TypeInfo,2);
		code_r0x820f717c:
		      (**(code **)((ulonglong)*puVar4 * 4))(piVar6,uVar3,puVar4[1]);
		      iVar2 = iVar2 + 1;
		    } while (iVar2 < *(int *)(iVar5 + 0xc));
		  }
		  *(int *)(param1 + 0x14) = param2;
		  if ((param2 != 0) && (0 < *(int *)(param2 + 0xc))) {
		    iVar2 = 0;
		    do {
		      piVar6 = *(int **)(param2 + iVar2 * 4 + 0x10);
		      uVar3 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar3,param1,
		                 Method_Utils_Trackers_AsyncLoadableContentTracker_LoaderReadyEventHandler__,0);
		      iVar5 = *piVar6;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		          if (Core_IAsyncLoadableContent_TypeInfo == *piVar8) {
		            puVar4 = (uint *)(piVar8[1] * 8 + iVar5 + 200);
		            goto code_r0x820f724f;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar6,Core_IAsyncLoadableContent_TypeInfo,1);
		code_r0x820f724f:
		      (**(code **)((ulonglong)*puVar4 * 4))(piVar6,uVar3,puVar4[1]);
		      iVar2 = iVar2 + 1;
		    } while (iVar2 < *(int *)(param2 + 0xc));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Loaders ---
		uint Utils_Trackers_AsyncLoadableContentTracker__set_Loaders(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 *puVar5;
		  int param1_00;
		  
		  if (DAT_ram_00a62831 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Count_IAsyncLoadableContent___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_IAsyncLoadableContent___);
		    Mono_Security_ASN1__get_Item(&System_Func_IAsyncLoadableContent__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Trackers_AsyncLoadableContentTracker___c__get_IsReady_b__10_0__);
		    Mono_Security_ASN1__get_Item(&Utils_Trackers_AsyncLoadableContentTracker___c_TypeInfo);
		    DAT_ram_00a62831 = '\x01';
		  }
		  uVar2 = 1;
		  iVar4 = *(int *)(param1 + 0x14);
		  if ((iVar4 != 0) && (*(int *)(iVar4 + 0xc) != 0)) {
		    if (*(int *)(Utils_Trackers_AsyncLoadableContentTracker___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_Trackers_AsyncLoadableContentTracker___c_TypeInfo);
		    }
		    puVar5 = *(undefined4 **)(Utils_Trackers_AsyncLoadableContentTracker___c_TypeInfo + 0x5c);
		    param1_00 = puVar5[1];
		    if (param1_00 == 0) {
		      if (*(int *)(Utils_Trackers_AsyncLoadableContentTracker___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Utils_Trackers_AsyncLoadableContentTracker___c_TypeInfo);
		        puVar5 = *(undefined4 **)(Utils_Trackers_AsyncLoadableContentTracker___c_TypeInfo + 0x5c);
		      }
		      uVar3 = *puVar5;
		      param1_00 = unnamed_function_1417(System_Func_IAsyncLoadableContent__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (param1_00,uVar3,
		                 Method_Utils_Trackers_AsyncLoadableContentTracker___c__get_IsReady_b__10_0__,0);
		      *(int *)(*(int *)(Utils_Trackers_AsyncLoadableContentTracker___c_TypeInfo + 0x5c) + 4) =
		           param1_00;
		    }
		    uVar3 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                      (iVar4,param1_00,Method_System_Linq_Enumerable_Where_IAsyncLoadableContent___)
		    ;
		    iVar4 = func_ii_6330(uVar3,Method_System_Linq_Enumerable_Count_IAsyncLoadableContent___);
		    bVar1 = *(float *)(param1 + 8) < (float)iVar4 / (float)*(int *)(*(int *)(param1 + 0x14) + 0xc);
		    uVar2 = (uint)bVar1;
		    *(bool *)(param1 + 0x10) = bVar1;
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_IsReady ---
		void Utils_Trackers_AsyncLoadableContentTracker__get_IsReady
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a62832 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_IAsyncLoadableContent___);
		    DAT_ram_00a62832 = '\x01';
		  }
		  *(undefined2 *)(param1 + 0x10) = 0x100;
		  param2_00 = func_ii_6295(param2,Method_System_Linq_Enumerable_ToArray_IAsyncLoadableContent___);
		  Utils_Trackers_AsyncLoadableContentTracker__remove_ReadyEvent(param1,param2_00,param1);
		  return;
		}
		*/

}
